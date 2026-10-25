"""Industrial Computer Vision Pipeline Engine.

Defines the base operation class, parameter schemas, operation registry,
cached sequential execution graph, and recipe serialization.
"""

from __future__ import annotations
import copy
import json
import time
import logging
from dataclasses import dataclass, field
from enum import Enum
from typing import Any, Callable, Dict, List, Optional, Tuple, Type

import cv2
import numpy as np

logger = logging.getLogger("PipelineEngine")


class ParamType(str, Enum):
    INT = "int"
    FLOAT = "float"
    BOOL = "bool"
    CHOICE = "choice"
    RANGE_TUPLE = "range_tuple"
    COLOR_RANGE = "color_range"
    STRING = "string"


@dataclass
class ParamSchema:
    name: str
    label: str
    param_type: ParamType
    default: Any
    min_val: Optional[float] = None
    max_val: Optional[float] = None
    step: Optional[float] = None
    choices: Optional[List[Tuple[str, Any]]] = None  # [(display_name, value), ...]
    description: str = ""

    def validate(self, value: Any) -> Any:
        """Coerces and clamps a value according to schema specifications."""
        if self.param_type == ParamType.INT:
            v = int(value)
            if self.min_val is not None:
                v = max(int(self.min_val), v)
            if self.max_val is not None:
                v = min(int(self.max_val), v)
            return v
        elif self.param_type == ParamType.FLOAT:
            v = float(value)
            if self.min_val is not None:
                v = max(float(self.min_val), v)
            if self.max_val is not None:
                v = min(float(self.max_val), v)
            return round(v, 4)
        elif self.param_type == ParamType.BOOL:
            return bool(value)
        elif self.param_type == ParamType.STRING:
            return str(value)
        elif self.param_type == ParamType.CHOICE:
            if self.choices:
                allowed = [c[1] for c in self.choices]
                if value in allowed:
                    return value
                return self.choices[0][1]
            return value
        return value


class BaseOperation:
    """Base class for all registered OpenCV pipeline operations."""

    name: str = "Base Operation"
    category: str = "General"
    description: str = ""
    param_schemas: List[ParamSchema] = []

    def __init__(self, params: Optional[Dict[str, Any]] = None):
        self.params: Dict[str, Any] = {}
        # Populate defaults
        for schema in self.param_schemas:
            self.params[schema.name] = schema.default
        if params:
            self.update_params(params)

    def update_params(self, params: Dict[str, Any]):
        for key, value in params.items():
            schema = self.get_schema(key)
            if schema:
                self.params[key] = schema.validate(value)
            else:
                self.params[key] = value

    def get_schema(self, key: str) -> Optional[ParamSchema]:
        for s in self.param_schemas:
            if s.name == key:
                return s
        return None

    def process(self, image: np.ndarray) -> np.ndarray:
        """Executes operation on the input image. Must be overridden by subclasses."""
        raise NotImplementedError

    def __call__(self, image: np.ndarray) -> np.ndarray:
        return self.process(image)


# Global Registries
OPERATION_REGISTRY: Dict[str, Type[BaseOperation]] = {}
CATEGORY_REGISTRY: Dict[str, List[str]] = {}


def register_op(cls: Type[BaseOperation]) -> Type[BaseOperation]:
    """Decorator to register an operation in the global registry."""
    op_name = cls.name
    category = cls.category
    OPERATION_REGISTRY[op_name] = cls
    if category not in CATEGORY_REGISTRY:
        CATEGORY_REGISTRY[category] = []
    if op_name not in CATEGORY_REGISTRY[category]:
        CATEGORY_REGISTRY[category].append(op_name)
    return cls


def get_categories() -> List[str]:
    return list(CATEGORY_REGISTRY.keys())


def get_operations_in_category(category: str) -> List[str]:
    return CATEGORY_REGISTRY.get(category, [])


def create_operation(name: str, params: Optional[Dict[str, Any]] = None) -> BaseOperation:
    if name not in OPERATION_REGISTRY:
        raise ValueError(f"Unknown operation '{name}'. Registered: {list(OPERATION_REGISTRY.keys())}")
    op_cls = OPERATION_REGISTRY[name]
    return op_cls(params)


@dataclass
class PipelineStep:
    step_id: int
    name: str
    category: str
    operation_name: str
    active: bool = True
    input_source_id: int = 0  # 0 = Raw Camera Frame; >0 = Output of Step with that ID
    link_to_remote: bool = False  # If True, step output is dispatched to PLC / Ethernet / RPi
    params: Dict[str, Any] = field(default_factory=dict)
    output_config: Dict[str, Any] = field(default_factory=dict)
    
    # Internal runtime state
    operation: Optional[BaseOperation] = None
    cached_output: Optional[np.ndarray] = None
    last_exec_ms: float = 0.0
    status_ok: bool = True
    status_msg: str = "Ready"
    output_info: str = "None"
    metrics: Dict[str, Any] = field(default_factory=dict)
    _dirty: bool = True

    def __post_init__(self):
        if self.operation is None and self.operation_name in OPERATION_REGISTRY:
            self.operation = create_operation(self.operation_name, self.params)
            # Synchronize sanitized params
            self.params = copy.deepcopy(self.operation.params)

        if not self.output_config:
            op_l = (self.operation_name or "").lower()
            if "yolo" in op_l or "neural" in op_l:
                self.output_config = {"mode": "yolo_class", "target_class": "person", "signal_id": 1}
            elif "caliper" in op_l or "measurement" in op_l:
                self.output_config = {"mode": "measurement", "target_metric": "length", "signal_id": 1}
            elif "ocr" in op_l or "barcode" in op_l:
                self.output_config = {"mode": "text", "signal_id": 1}
            elif "shape" in op_l or "contour" in op_l or "blob" in op_l:
                self.output_config = {"mode": "count", "signal_id": 1}
            else:
                self.output_config = {"mode": "default", "signal_id": 1}

    def set_param(self, key: str, value: Any):
        if self.operation:
            self.operation.update_params({key: value})
            self.params = copy.deepcopy(self.operation.params)
            self._dirty = True

    def reset_params(self):
        if self.operation:
            defaults = {s.name: s.default for s in self.operation.param_schemas}
            self.operation.update_params(defaults)
            self.params = copy.deepcopy(self.operation.params)
            self._dirty = True

    def set_operation(self, category: str, op_name: str):
        self.category = category
        self.operation_name = op_name
        self.operation = create_operation(op_name)
        self.params = copy.deepcopy(self.operation.params)
        self.name = op_name
        self._dirty = True

    def get_output_summary(self) -> str:
        """Returns clean human-readable summary of the configured output signal for UI display."""
        cfg = self.output_config or {}
        mode = cfg.get("mode", "default")
        sig_id = cfg.get("signal_id", 1)

        if mode == "default":
            return f"Pass/Fail [Sig #{sig_id}]"
        elif mode == "measurement":
            metric = cfg.get("target_metric", cfg.get("metric", "length"))
            val = self.metrics.get(metric, self.metrics.get("length", None))
            unit = self.metrics.get("unit", "mm")
            if val is not None:
                return f"Meas: {metric.title()} ({val} {unit})"
            return f"Meas: {metric.title()}"
        elif mode == "yolo_class":
            tgt = cfg.get("target_class", "person")
            return f"YOLO: [{tgt}] -> Sig #{sig_id}"
        elif mode == "yolo_combined":
            return f"YOLO: Combined (All) -> Sig #{sig_id}"
        elif mode == "yolo_multiclass":
            cmap = cfg.get("class_signals", {})
            return f"YOLO: Multi-Sig ({len(cmap)} classes)"
        elif mode == "count":
            cnt = self.metrics.get("count", None)
            return f"Count ({cnt})" if cnt is not None else "Count"
        elif mode == "coordinates":
            x = self.metrics.get("x", None)
            y = self.metrics.get("y", None)
            if x is not None and y is not None:
                return f"Coord ({x:.0f}, {y:.0f})"
            return "Coord (X, Y)"
        elif mode == "text":
            txt = self.metrics.get("text", "")
            return f'Text: "{txt[:12]}"' if txt else "Text String"
        elif mode == "custom":
            return f"Custom Sig #{sig_id} ({cfg.get('custom_val', 1.0)})"
        return f"Output [Sig #{sig_id}]"

    def evaluate_output_signal(self) -> Dict[str, Any]:
        """Evaluates the live signal code, active boolean, numeric value, and payload for remote devices."""
        cfg = self.output_config or {}
        mode = cfg.get("mode", "default")
        metrics = self.metrics or {}
        status_ok = self.status_ok

        active = False
        signal_id = int(cfg.get("signal_id", 1))
        numeric_value = 0.0
        text_value = ""
        target_class = cfg.get("target_class", "all")
        display_str = ""

        if mode == "default":
            active = bool(status_ok)
            numeric_value = 1.0 if active else 0.0
            display_str = "✔ PASS" if active else "✖ FAIL"

        elif mode == "measurement":
            metric_key = cfg.get("target_metric", cfg.get("metric", "length"))
            numeric_value = float(metrics.get(metric_key, metrics.get("length", 0.0)))
            tolerance_only = bool(cfg.get("tolerance_only", True))
            active = bool(status_ok) if tolerance_only else True
            unit = metrics.get("unit", "mm")
            display_str = f"{numeric_value:.2f} {unit}"

        elif mode == "yolo_class":
            tgt = str(cfg.get("target_class", "person")).lower()
            det_classes = [c.lower() for c in metrics.get("detected_classes", [])]
            class_counts = {str(k).lower(): int(v) for k, v in metrics.get("class_counts", {}).items()}
            found = (tgt in det_classes) or (tgt in class_counts and class_counts[tgt] > 0) or (tgt == "all" and (len(det_classes) > 0 or len(class_counts) > 0))
            invert = bool(cfg.get("invert_logic", False))
            active = (not found) if invert else found
            if tgt in class_counts:
                class_cnt = class_counts[tgt]
            elif tgt == "all":
                class_cnt = sum(class_counts.values()) if class_counts else len(det_classes)
            else:
                class_cnt = det_classes.count(tgt)
            numeric_value = float(class_cnt) if active else 0.0
            display_str = f"{tgt}: {class_cnt} found [Sig #{signal_id}]" if found else f"{tgt}: 0 found"

        elif mode == "yolo_combined":
            total_cnt = int(metrics.get("count", 0))
            min_cnt = int(cfg.get("min_count", 1))
            active = total_cnt >= min_cnt
            numeric_value = float(total_cnt)
            display_str = f"Combined: {total_cnt} obj [Sig #{signal_id}]"

        elif mode == "yolo_multiclass":
            class_map = cfg.get("class_signals", {})
            det_classes = [c.lower() for c in metrics.get("detected_classes", [])]
            found_signals = []
            for c_name, sig in class_map.items():
                if c_name.lower() in det_classes:
                    found_signals.append(sig)
            if found_signals:
                active = True
                signal_id = found_signals[0]
                numeric_value = float(signal_id)
                display_str = f"Signals: {found_signals}"
            else:
                active = False
                numeric_value = 0.0
                display_str = "No mapped class"

        elif mode == "count":
            cnt = int(metrics.get("count", metrics.get("instances", 0)))
            active = cnt > 0
            numeric_value = float(cnt)
            display_str = f"Count: {cnt}"

        elif mode == "coordinates":
            x = float(metrics.get("x", 0.0))
            y = float(metrics.get("y", 0.0))
            active = (x != 0.0 or y != 0.0)
            fmt = cfg.get("coords_format", "xy")
            numeric_value = x if fmt != "y" else y
            display_str = f"X:{x:.1f}, Y:{y:.1f}"

        elif mode == "text":
            txt = str(metrics.get("text", metrics.get("code", "")))
            active = bool(txt)
            text_value = txt
            display_str = f'"{txt[:16]}"' if txt else "None"

        elif mode == "custom":
            active = bool(status_ok)
            numeric_value = float(cfg.get("custom_val", 1.0))
            display_str = f"Custom Sig #{signal_id} ({numeric_value})"

        else:
            active = bool(status_ok)
            numeric_value = 1.0 if active else 0.0
            display_str = "OK" if active else "NG"

        return {
            "mode": mode,
            "output_mode": mode,
            "active": active,
            "signal_id": signal_id,
            "numeric_value": numeric_value,
            "text_value": text_value,
            "display_str": display_str,
            "target_class": target_class,
            "timestamp": time.time(),
        }

    def to_dict(self) -> Dict[str, Any]:
        return {
            "step_id": self.step_id,
            "name": self.name,
            "category": self.category,
            "operation_name": self.operation_name,
            "active": self.active,
            "input_source_id": self.input_source_id,
            "link_to_remote": self.link_to_remote,
            "params": self.params,
            "output_config": copy.deepcopy(self.output_config),
        }

    @classmethod
    def from_dict(cls, data: Dict[str, Any]) -> PipelineStep:
        return cls(
            step_id=data.get("step_id", 1),
            name=data.get("name", "Step"),
            category=data.get("category", "Pre-processing & Filtering"),
            operation_name=data.get("operation_name", "Gaussian Blur"),
            active=data.get("active", True),
            input_source_id=data.get("input_source_id", 0),
            link_to_remote=data.get("link_to_remote", False),
            params=data.get("params", {}),
            output_config=data.get("output_config", {}),
        )


class PipelineEngine:
    """Manages sequential step chaining, branching inputs, and intermediate output caching."""

    def __init__(self):
        self.steps: List[PipelineStep] = []
        self._raw_frame_cache: Optional[np.ndarray] = None
        self._total_pipeline_time_ms: float = 0.0
        self._step_counter = 0

    def add_step(
        self,
        category: str,
        operation_name: str,
        name: Optional[str] = None,
        input_source_id: Optional[int] = None,
        params: Optional[Dict[str, Any]] = None,
        link_to_remote: bool = False,
    ) -> PipelineStep:
        self._step_counter += 1
        new_id = self._step_counter
        # Default input source is previous step if exists, else 0 (Raw Frame)
        if input_source_id is None:
            input_source_id = self.steps[-1].step_id if self.steps else 0

        step_name = name or f"{operation_name} ({new_id})"
        step = PipelineStep(
            step_id=new_id,
            name=step_name,
            category=category,
            operation_name=operation_name,
            input_source_id=input_source_id,
            link_to_remote=link_to_remote,
            params=params or {},
        )
        self.steps.append(step)
        self.mark_dirty_from(len(self.steps) - 1)
        return step

    def remove_step(self, index: int) -> bool:
        if 0 <= index < len(self.steps):
            removed_id = self.steps[index].step_id
            self.steps.pop(index)
            # Re-link any downstream steps pointing to the removed step
            for s in self.steps:
                if s.input_source_id == removed_id:
                    s.input_source_id = 0
            self.mark_dirty_from(index)
            return True
        return False

    def move_step(self, from_index: int, to_index: int) -> bool:
        if 0 <= from_index < len(self.steps) and 0 <= to_index < len(self.steps):
            step = self.steps.pop(from_index)
            self.steps.insert(to_index, step)
            # Ensure input source dependencies don't point forward in sequence
            step_ids_before = [0]
            for s in self.steps:
                if s.input_source_id not in step_ids_before:
                    s.input_source_id = step_ids_before[-1]
                step_ids_before.append(s.step_id)
            self.mark_dirty_from(min(from_index, to_index))
            return True
        return False

    def mark_dirty_from(self, start_index: int):
        for i in range(max(0, start_index), len(self.steps)):
            self.steps[i]._dirty = True

    def mark_all_dirty(self):
        for s in self.steps:
            s._dirty = True

    def get_step_by_id(self, step_id: int) -> Optional[PipelineStep]:
        for s in self.steps:
            if s.step_id == step_id:
                return s
        return None

    def get_step_index(self, step_id: int) -> int:
        for idx, s in enumerate(self.steps):
            if s.step_id == step_id:
                return idx
        return -1

    def set_step_param(self, step_id: int, key: str, value: Any):
        idx = self.get_step_index(step_id)
        if idx >= 0:
            self.steps[idx].set_param(key, value)
            self.mark_dirty_from(idx)

    def execute(self, raw_frame: np.ndarray, force_all: bool = False, is_live: bool = False) -> Dict[int, np.ndarray]:
        """Sequentially executes active pipeline steps with intermediate buffer caching.

        Returns a dictionary mapping step_id to output np.ndarray (and 0 to raw_frame).
        """
        if raw_frame is None or not isinstance(raw_frame, np.ndarray):
            return {}

        start_total = time.perf_counter()
        results: Dict[int, np.ndarray] = {0: raw_frame}

        # Check if raw frame has changed dimensions or data
        raw_changed = False
        if self._raw_frame_cache is None or self._raw_frame_cache.shape != raw_frame.shape:
            raw_changed = True
        elif is_live:
            raw_changed = True
        self._raw_frame_cache = raw_frame

        if raw_changed or force_all:
            self.mark_all_dirty()

        recomputed_steps = set()

        for idx, step in enumerate(self.steps):
            # Resolve input image
            source_id = step.input_source_id
            input_img = results.get(source_id, raw_frame)

            needs_recompute = (
                step._dirty
                or source_id in recomputed_steps
                or step.cached_output is None
                or force_all
            )

            # If bypassed (inactive)
            if not step.active:
                step.cached_output = input_img.copy() if input_img is not None else None
                step.last_exec_ms = 0.0
                step.status_ok = True
                step.status_msg = "Bypassed (Pass-through)"
                step.output_info = self._get_img_info(step.cached_output)
                results[step.step_id] = step.cached_output
                if needs_recompute:
                    recomputed_steps.add(step.step_id)
                continue

            # Check if this step or its source was marked dirty
            if needs_recompute:
                recomputed_steps.add(step.step_id)
                t0 = time.perf_counter()
                try:
                    if input_img is None:
                        raise ValueError(f"Step {step.step_id} received null input from source {source_id}")
                    
                    if step.operation is None:
                        step.operation = create_operation(step.operation_name, step.params)

                    # Execute the OpenCV operation
                    output = step.operation.process(input_img)
                    if output is None or not isinstance(output, np.ndarray):
                        raise ValueError(f"Operation {step.operation_name} returned non-array result")

                    step.cached_output = output
                    step.status_ok = True
                    step.status_msg = "OK"
                    if hasattr(step.operation, "last_metrics"):
                        step.metrics = copy.deepcopy(getattr(step.operation, "last_metrics", {}))
                    else:
                        step.metrics = {"passed": True, "count": 1}
                except Exception as ex:
                    logger.warning(f"Error in Step {step.step_id} ({step.operation_name}): {ex}")
                    step.status_ok = False
                    step.status_msg = str(ex)
                    # Pass-through input on failure so downstream doesn't cascade crash
                    step.cached_output = input_img.copy() if input_img is not None else raw_frame.copy()

                step.last_exec_ms = (time.perf_counter() - t0) * 1000.0
                step.output_info = self._get_img_info(step.cached_output)
                step._dirty = False

            results[step.step_id] = step.cached_output

        self._total_pipeline_time_ms = (time.perf_counter() - start_total) * 1000.0
        return results

    @staticmethod
    def _get_img_info(img: Optional[np.ndarray]) -> str:
        if img is None:
            return "None"
        h, w = img.shape[:2]
        ch = 1 if img.ndim == 2 else img.shape[2]
        dtype = str(img.dtype)
        ch_str = "Gray" if ch == 1 else f"{ch}ch"
        return f"{w}x{h} {ch_str} ({dtype})"

    @property
    def total_latency_ms(self) -> float:
        return self._total_pipeline_time_ms

    def to_dict(self) -> Dict[str, Any]:
        """Serializes complete pipeline recipe to a dictionary."""
        return {
            "version": "1.0",
            "name": "VisionStudio Pipeline Recipe",
            "steps": [s.to_dict() for s in self.steps],
        }

    def from_dict(self, data: Dict[str, Any]):
        """Deserializes pipeline recipe from a dictionary."""
        self.steps.clear()
        max_id = 0
        for s_data in data.get("steps", []):
            step = PipelineStep.from_dict(s_data)
            self.steps.append(step)
            max_id = max(max_id, step.step_id)
        self._step_counter = max_id
        self.mark_all_dirty()

    def save_recipe(self, file_path: str):
        data = self.to_dict()
        with open(file_path, "w", encoding="utf-8") as f:
            json.dump(data, f, indent=2)

    def load_recipe(self, file_path: str):
        with open(file_path, "r", encoding="utf-8") as f:
            data = json.load(f)
        self.from_dict(data)
