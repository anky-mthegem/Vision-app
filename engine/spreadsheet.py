"""In-Sight Spreadsheet DAG & Formula Execution Engine.

Implements cell dependency graph evaluation, topological sorting, tool execution,
and mathematical / logical formula parsing for all industrial vision tools.
"""

import re
import time
import numpy as np
import logging
from typing import Dict, Any, List, Optional, Set, Tuple

from tools.patmax import PatMaxTool, PatMaxResult
from tools.blob import BlobTool, BlobResult
from tools.edge import CaliperTool, LineResult, CircleResult
from tools.caliper_width import CaliperWidthTool, EdgeCountTool, CaliperWidthResult, EdgeCountResult
from tools.measurement import MeasurementTools
from tools.id_reader import IDReaderTool, CodeResult
from tools.flaw import FlawDetectorTool, FlawResult
from tools.filters import ImageFilterTool, BinarizeTool, HistogramTool, ExtractColorTool, HistogramResult, ColorResult
from tools.ocr import ReadOcrMaxTool, OcrResult
from tools.yolo_detector import YoloDetectorTool, YoloResult, YoloDetection, COCO_CLASSES
from tools.hand_tracker import HandTrackerTool, HandTrackingResult
from comms.modbus_driver import ModbusTcpClient
from comms.siemens_s7 import SiemensS7Client
from comms.beckhoff_ads import BeckhoffAdsClient
from comms.ethernet_device import EthernetDeviceClient
from comms.rpi_gpio import RaspberryPiGpioClient

logger = logging.getLogger("SpreadsheetEngine")


# Master Industrial Vision Function Catalog
INDUSTRIAL_FUNCTION_CATALOG = [
    # 1. Pattern Matching & Alignment
    {
        "category": "Pattern Matching & Alignment",
        "name": "PatMax",
        "syntax": "=PatMax(A0)",
        "desc": "Geometric contour & gradient-vector pattern matching with rotation and scale tolerance",
        "return_type": "PatMaxResult (Score, X, Y, Angle, Scale)",
    },
    {
        "category": "Pattern Matching & Alignment",
        "name": "TrainPatMax",
        "syntax": "=TrainPatMax(A0, roi=[100,100,200,200])",
        "desc": "Trains new geometric model pattern from target ROI",
        "return_type": "Boolean (Trained successfully)",
    },
    {
        "category": "AI & Deep Learning (YOLO)",
        "name": "YoloDetect",
        "syntax": '=YoloDetect(A0, class="all", conf=0.40)',
        "desc": "Ultra-fast neural object detector (80 COCO classes) with customizable class filter and confidence",
        "return_type": "YoloResult (Count, Detections, ClassCounts)",
    },
    # 2. Presence / Absence & Flaw Detection
    {
        "category": "Presence & Defect Inspection",
        "name": "FindBlobs",
        "syntax": "=FindBlobs(A0, threshold=128, min_area=50)",
        "desc": "Extracts connected components, bounding boxes, circularity, and moments",
        "return_type": "BlobResult (Count, Blobs list)",
    },
    {
        "category": "Presence & Defect Inspection",
        "name": "DetectBlobs",
        "syntax": "=DetectBlobs(A0, threshold=100)",
        "desc": "Presence/absence inspection by counting foreground connected blobs",
        "return_type": "BlobResult",
    },
    {
        "category": "Presence & Defect Inspection",
        "name": "DetectFlaw",
        "syntax": "=DetectFlaw(A0, sensitivity=35)",
        "desc": "Surface defect & scratch inspection against golden reference template",
        "return_type": "FlawResult (Passed, DefectScore, FlawCount)",
    },
    {
        "category": "Presence & Defect Inspection",
        "name": "Histogram",
        "syntax": "=Histogram(A0)",
        "desc": "Measures mean brightness, standard deviation, peak bin, min, and max",
        "return_type": "HistogramResult (Mean, StdDev, Min, Max, Peak)",
    },
    # 3. Edges & Caliper Measurements
    {
        "category": "Edges & Caliper Measurement",
        "name": "FindLine",
        "syntax": "=FindLine(A0)",
        "desc": "Projects perpendicular caliper rakes and fits subpixel boundary line",
        "return_type": "LineResult (P1, P2, Angle, Points)",
    },
    {
        "category": "Edges & Caliper Measurement",
        "name": "FindCircle",
        "syntax": "=FindCircle(A0)",
        "desc": "Radial caliper rays fitting circular edge center and diameter",
        "return_type": "CircleResult (Center, Radius, Points)",
    },
    {
        "category": "Edges & Caliper Measurement",
        "name": "Caliper",
        "syntax": "=Caliper(A0)",
        "desc": "Precision width/gap distance between edge pairs",
        "return_type": "CaliperWidthResult (Width, Center)",
    },
    {
        "category": "Edges & Caliper Measurement",
        "name": "EdgeCount",
        "syntax": "=EdgeCount(A0)",
        "desc": "Counts transition crossings (dark-to-light, light-to-dark) along a scan segment",
        "return_type": "EdgeCountResult (Count)",
    },
    # 4. Identification & OCR
    {
        "category": "Identification & Codes",
        "name": "ReadIDMax",
        "syntax": "=ReadIDMax(A0)",
        "desc": "Reads 1D Barcodes (Code 128, Code 39) and 2D QR / DataMatrix codes",
        "return_type": "CodeResult (Text, Type, Polygon)",
    },
    {
        "category": "Identification & Codes",
        "name": "ReadOcrMax",
        "syntax": '=ReadOcrMax(A0, regex="[A-Z0-9]+")' ,
        "desc": "Industrial optical character recognition with regular expression fielding",
        "return_type": "OcrResult (Text, Confidence, ValidField)",
    },
    # 5. Image Processing & Color
    {
        "category": "Color & Image Filters",
        "name": "ExtractColor",
        "syntax": '=ExtractColor(A0, color="GREEN")',
        "desc": "Color space segmentation (RED, GREEN, BLUE, YELLOW, WHITE)",
        "return_type": "ColorResult (PixelCount, Percentage)",
    },
    {
        "category": "Color & Image Filters",
        "name": "ImageFilter",
        "syntax": '=ImageFilter(A0, filter="Gaussian", ksize=5)',
        "desc": "Image enhancement: Gaussian, Median, Sobel, Laplacian, MorphOpen, MorphClose",
        "return_type": "Filtered Image ndarray",
    },
    {
        "category": "Color & Image Filters",
        "name": "Binarize",
        "syntax": '=Binarize(A0, method="Otsu")',
        "desc": "Converts image to binary mask (Otsu, Adaptive, Fixed)",
        "return_type": "Binary Image ndarray",
    },
    # 6. Geometry & Coordinates
    {
        "category": "Geometry & Coordinate Transforms",
        "name": "Distance",
        "syntax": "=Distance(B2.X, B2.Y, C3.X, C3.Y)",
        "desc": "Calculates Euclidean distance between two points",
        "return_type": "Float distance (pixels / mm)",
    },
    {
        "category": "Geometry & Coordinate Transforms",
        "name": "Angle",
        "syntax": "=Angle(B2.X, B2.Y, 500, 300)",
        "desc": "Calculates slope angle (-180 to +180 deg) between two points",
        "return_type": "Float angle (degrees)",
    },
    {
        "category": "Geometry & Coordinate Transforms",
        "name": "MidPoint",
        "syntax": "=MidPoint(B2.X, B2.Y, 500, 300)",
        "desc": "Calculates center coordinate (X, Y) of segment",
        "return_type": "Tuple (X, Y)",
    },
    {
        "category": "Geometry & Coordinate Transforms",
        "name": "PointToLineDistance",
        "syntax": "=PointToLineDistance(B2.X, B2.Y, 100, 200, 500, 200)",
        "desc": "Perpendicular distance from point to line",
        "return_type": "Float distance",
    },
    {
        "category": "Geometry & Coordinate Transforms",
        "name": "Fixture",
        "syntax": "=Fixture(B2.X, B2.Y, B2.Angle)",
        "desc": "Dynamic coordinate fixture tracking parts across motion",
        "return_type": "Fixture (Origin X, Origin Y, Angle)",
    },
    # 7. Decision Logic & PLC
    {
        "category": "Math, Logic & Industrial PLC",
        "name": "If",
        "syntax": '=If(B2.Score >= 75.0, "PASS", "FAIL")',
        "desc": "Conditional branching evaluating pass/fail criteria",
        "return_type": "Any",
    },
    {
        "category": "Math, Logic & Industrial PLC",
        "name": "CountPassFail",
        "syntax": "=CountPassFail(E5)",
        "desc": "Latched statistics counter for total pass and fail items",
        "return_type": "Dict (Total, Pass, Fail)",
    },
    # 8. Industrial PLC & Communications
    {
        "category": "Industrial PLC & Communications",
        "name": "WriteModbus",
        "syntax": '=WriteModbus(E5, ip="192.168.1.50", reg=100)',
        "desc": "Transmits inspection results or coordinates to Delta PLC (D-registers / M-coils) or Modbus TCP devices",
        "return_type": "String confirmation",
    },
    {
        "category": "Industrial PLC & Communications",
        "name": "WriteSiemens",
        "syntax": '=WriteSiemens(E5, ip="192.168.1.10", db=1, byte=0)',
        "desc": "Transmits Pass/Fail and part coordinates to Siemens S7-300 / S7-1200 / S7-1500 DataBlock",
        "return_type": "String confirmation",
    },
    {
        "category": "Industrial PLC & Communications",
        "name": "WriteBeckhoff",
        "syntax": '=WriteBeckhoff(E5, ip="192.168.1.20", offset=100)',
        "desc": "Transmits vision telemetry to Beckhoff TwinCAT ADS / CX controller memory area",
        "return_type": "String confirmation",
    },
    {
        "category": "Industrial PLC & Communications",
        "name": "WriteEthernet",
        "syntax": '=WriteEthernet(E5, ip="192.168.1.100", port=9000, fmt="JSON")',
        "desc": "Dispatches inspection packet over raw TCP/UDP to robots (ABB, KUKA, Fanuc) or MES servers",
        "return_type": "String confirmation",
    },
    {
        "category": "Industrial PLC & Communications",
        "name": "WriteGPIO",
        "syntax": '=WriteGPIO(E5, pass_pin=17, fail_pin=27, host="192.168.1.200")',
        "desc": "Drives physical Raspberry Pi digital I/O lines (Pass/Fail pins, reject cylinder, camera strobe)",
        "return_type": "String confirmation",
    },
]


class Cell:
    """Individual spreadsheet cell in the In-Sight inspection graph."""

    def __init__(self, coord: str, formula: str = "", label: str = "", enabled: bool = True):
        self.coord = coord.upper()  # e.g., "A0", "B2", "D4"
        self.formula = formula.strip()
        self.label = label
        self.enabled = enabled
        self.value: Any = None
        self.tool_instance: Any = None
        self.last_exec_ms: float = 0.0
        self.is_pass: Optional[bool] = None
        self.error: Optional[str] = None
        self.dependencies: Set[str] = set()

    def set_formula(self, formula: str):
        self.formula = formula.strip()
        self.dependencies = self._extract_dependencies(self.formula)

    def _extract_dependencies(self, text: str) -> Set[str]:
        """Finds referenced cell coordinates (e.g., A0, B2, C3.Score)."""
        pattern = r"\b([A-Z][0-9]{1,3})\b"
        matches = re.findall(pattern, text.upper())
        return {m for m in matches if m != self.coord}


class InspectionJob:
    """Container for the complete inspection spreadsheet program."""

    def __init__(self, name: str = "EmptyJob"):
        self.name = name
        self.cells: Dict[str, Cell] = {}
        self.execution_order: List[str] = []
        self._compiled = False
        self.total_cycle_time_ms: float = 0.0
        self.overall_pass: bool = True
        self.total_inspections: int = 0
        self.total_passed: int = 0
        self.total_failed: int = 0

    def add_cell(self, coord: str, formula: str, label: str = "", enabled: bool = True) -> Cell:
        cell = Cell(coord, formula, label, enabled)
        cell.set_formula(formula)
        self.cells[cell.coord] = cell
        self._compiled = False
        return cell

    def remove_cell(self, coord: str):
        coord = coord.upper()
        if coord in self.cells:
            del self.cells[coord]
            self._compiled = False

    def compile(self) -> bool:
        """Topological sort to determine DAG execution order."""
        visited = set()
        temp_marked = set()
        order = []

        def visit(node: str):
            if node in temp_marked:
                logger.error(f"Circular dependency detected at cell {node}")
                return
            if node not in visited:
                temp_marked.add(node)
                cell = self.cells.get(node)
                if cell and cell.enabled:
                    for dep in cell.dependencies:
                        if dep in self.cells:
                            visit(dep)
                temp_marked.remove(node)
                visited.add(node)
                order.append(node)

        for coord in list(self.cells.keys()):
            if coord not in visited and self.cells[coord].enabled:
                visit(coord)

        self.execution_order = order
        self._compiled = True
        logger.info(f"Spreadsheet DAG compiled. Active sequence: {self.execution_order}")
        return True

    def execute(self, current_image: np.ndarray) -> Dict[str, Any]:
        """Evaluates spreadsheet across active cells."""
        if not self._compiled:
            self.compile()

        start_time = time.perf_counter()
        cell_context: Dict[str, Any] = {}
        overall_pass = True

        for coord in self.execution_order:
            cell = self.cells[coord]
            if not cell.enabled:
                continue

            c_start = time.perf_counter()
            cell.error = None

            try:
                self._evaluate_cell(cell, current_image, cell_context)
            except Exception as e:
                cell.error = str(e)
                cell.value = "ERROR"
                logger.error(f"Cell {coord} execution failed: {e}")

            cell.last_exec_ms = (time.perf_counter() - c_start) * 1000.0

            # Determine pass/fail
            if isinstance(cell.value, str):
                if cell.value.upper() == "PASS":
                    cell.is_pass = True
                elif cell.value.upper() == "FAIL":
                    cell.is_pass = False
                    overall_pass = False
            elif isinstance(cell.value, bool):
                cell.is_pass = cell.value
                if not cell.value:
                    overall_pass = False

            cell_context[coord] = cell.value

        self.total_cycle_time_ms = (time.perf_counter() - start_time) * 1000.0
        self.overall_pass = overall_pass

        # Only update counters if inspection tools were executed (more than just A0)
        has_tools = len([c for c in self.execution_order if c != "A0"]) > 0
        if has_tools:
            self.total_inspections += 1
            if overall_pass:
                self.total_passed += 1
            else:
                self.total_failed += 1

        return {
            "overall_pass": self.overall_pass,
            "cycle_time_ms": round(self.total_cycle_time_ms, 2),
            "inspections": self.total_inspections,
            "pass_count": self.total_passed,
            "fail_count": self.total_failed,
            "yield_pct": round((self.total_passed / max(1, self.total_inspections)) * 100.0, 1),
        }

    def _evaluate_cell(self, cell: Cell, current_image: np.ndarray, context: Dict[str, Any]):
        formula = cell.formula
        if not formula.startswith("="):
            try:
                cell.value = float(formula)
            except ValueError:
                cell.value = formula
            return

        body = formula[1:].strip()
        h, w = current_image.shape[:2]

        # 1. AcquireImage
        if body.upper().startswith("ACQUIREIMAGE"):
            cell.value = current_image
            return

        # 2. PatMax
        if body.upper().startswith("PATMAX"):
            if cell.tool_instance is None:
                cell.tool_instance = PatMaxTool()
                cell.tool_instance.train(current_image, (w // 2 - 60, h // 2 - 60, 120, 120))
            cell.value = cell.tool_instance.find(current_image)
            return

        # 3. FindBlobs / DetectBlobs
        if body.upper().startswith("FINDBLOBS") or body.upper().startswith("DETECTBLOBS"):
            if cell.tool_instance is None:
                cell.tool_instance = BlobTool(threshold=100, min_area=30.0)
            cell.value = cell.tool_instance.inspect(current_image)
            return

        # 4. FindLine
        if body.upper().startswith("FINDLINE"):
            if cell.tool_instance is None:
                cell.tool_instance = CaliperTool(threshold=20.0)
            cell.value = cell.tool_instance.find_line(current_image, (w * 0.3, h * 0.3), (w * 0.7, h * 0.3))
            return

        # 5. FindCircle
        if body.upper().startswith("FINDCIRCLE"):
            if cell.tool_instance is None:
                cell.tool_instance = CaliperTool(threshold=15.0)
            cell.value = cell.tool_instance.find_circle(current_image, (w * 0.5, h * 0.5), 65.0)
            return

        # 6. Caliper (Width/Gap measurement)
        if body.upper().startswith("CALIPER"):
            if cell.tool_instance is None:
                cell.tool_instance = CaliperWidthTool(threshold=15.0)
            cell.value = cell.tool_instance.measure_width(current_image, (w * 0.3, h * 0.5), (w * 0.7, h * 0.5))
            return

        # 7. EdgeCount
        if body.upper().startswith("EDGECOUNT"):
            if cell.tool_instance is None:
                cell.tool_instance = EdgeCountTool(threshold=15.0)
            cell.value = cell.tool_instance.count_edges(current_image, (w * 0.2, h * 0.5), (w * 0.8, h * 0.5))
            return

        # 8. ReadIDMax
        if body.upper().startswith("READIDMAX"):
            if cell.tool_instance is None:
                cell.tool_instance = IDReaderTool()
            cell.value = cell.tool_instance.read(current_image)
            return

        # 9. ReadOcrMax
        if body.upper().startswith("READOCRMAX"):
            if cell.tool_instance is None:
                cell.tool_instance = ReadOcrMaxTool()
            cell.value = cell.tool_instance.read(current_image)
            return

        # 10. DetectFlaw
        if body.upper().startswith("DETECTFLAW"):
            if cell.tool_instance is None:
                cell.tool_instance = FlawDetectorTool()
                cell.tool_instance.set_golden_reference(current_image)
            cell.value = cell.tool_instance.inspect(current_image)
            return

        # 11. Histogram
        if body.upper().startswith("HISTOGRAM"):
            cell.value = HistogramTool.analyze(current_image)
            return

        # 12. ExtractColor
        if body.upper().startswith("EXTRACTCOLOR"):
            cell.value = ExtractColorTool.extract(current_image, "GREEN")
            return

        # 13. ImageFilter
        if body.upper().startswith("IMAGEFILTER"):
            cell.value = ImageFilterTool.filter(current_image, "Gaussian")
            return

        # 14. Binarize
        if body.upper().startswith("BINARIZE"):
            cell.value = BinarizeTool.threshold(current_image, "Otsu")
            return

        # 15. YOLO Multi-Task Deep Learning Vision
        if body.upper().startswith("YOLO") or body.upper().startswith("YOLODETECT"):
            target_cls = "all"
            conf_val = 0.40
            task_mode = "detect"
            m_cls = re.search(r'class\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            if m_cls:
                target_cls = m_cls.group(1)
            m_conf = re.search(r'conf\s*=\s*([0-9.]+)', body, re.IGNORECASE)
            if m_conf:
                conf_val = float(m_conf.group(1))
            m_task = re.search(r'task\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            if m_task:
                task_mode = m_task.group(1).lower()

            if cell.tool_instance is None:
                cell.tool_instance = YoloDetectorTool(target_class=target_cls, confidence=conf_val)
            else:
                cell.tool_instance.target_class = target_cls.strip().lower()
                cell.tool_instance.confidence = conf_val
            cell.value = cell.tool_instance.run_task(current_image, task=task_mode)
            return

        # 16. TrackHands / HandTracker (MediaPipe 21-Landmark & Index Fingertip Tracking)
        if body.upper().startswith("TRACKHANDS") or body.upper().startswith("HANDTRACKER"):
            m_hands = re.search(r'max_hands\s*=\s*([0-9]+)', body, re.IGNORECASE)
            max_h = int(m_hands.group(1)) if m_hands else 2
            m_conf = re.search(r'conf\s*=\s*([0-9.]+)', body, re.IGNORECASE)
            conf_val = float(m_conf.group(1)) if m_conf else 0.50

            if cell.tool_instance is None or not isinstance(cell.tool_instance, HandTrackerTool):
                cell.tool_instance = HandTrackerTool(max_num_hands=max_h, min_detection_confidence=conf_val)

            _, res = cell.tool_instance.process(current_image, highlight_index_tip=True, draw_skeleton=True)
            cell.value = res
            return

        # 17. WriteModbus (Delta PLC & Generic Modbus TCP)
        if body.upper().startswith("WRITEMODBUS"):
            m_ip = re.search(r'ip\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            ip_val = m_ip.group(1) if m_ip else "192.168.1.50"
            m_port = re.search(r'port\s*=\s*([0-9]+)', body, re.IGNORECASE)
            port_val = int(m_port.group(1)) if m_port else 502
            m_reg = re.search(r'reg\s*=\s*([0-9]+)', body, re.IGNORECASE)
            reg_val = int(m_reg.group(1)) if m_reg else 100
            m_unit = re.search(r'unit\s*=\s*([0-9]+)', body, re.IGNORECASE)
            unit_val = int(m_unit.group(1)) if m_unit else 1

            arg_m = re.search(r'WriteModbus\s*\(\s*([^,\)]+)', body, re.IGNORECASE)
            arg_str = arg_m.group(1).strip() if arg_m else "PASS"
            val = self._resolve_arg_value(arg_str, context)

            if cell.tool_instance is None or getattr(cell.tool_instance, "host", "") != ip_val:
                cell.tool_instance = ModbusTcpClient(host=ip_val, port=port_val, unit_id=unit_val, timeout=0.8)

            client: ModbusTcpClient = cell.tool_instance
            try:
                if isinstance(val, bool) or str(val).upper() in ("PASS", "FAIL"):
                    b_val = True if (val is True or str(val).upper() == "PASS") else False
                    ok = client.write_delta_m_coil(reg_val if reg_val < 1000 else reg_val - 2048, b_val)
                elif isinstance(val, float):
                    ok = client.write_delta_d_float(reg_val if reg_val < 4096 else reg_val - 4096, val)
                else:
                    try:
                        int_v = int(val)
                    except Exception:
                        int_v = 1 if val else 0
                    ok = client.write_delta_d_register(reg_val if reg_val < 4096 else reg_val - 4096, int_v)
                cell.value = f"Delta D{reg_val}: {'OK' if ok else 'OFFLINE'}"
            except Exception as e:
                cell.value = f"Delta ERR: {e}"
            return

        # 17. WriteSiemens (Siemens S7-300 / 1200 / 1500)
        if body.upper().startswith("WRITESIEMENS"):
            m_ip = re.search(r'ip\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            ip_val = m_ip.group(1) if m_ip else "192.168.1.10"
            m_db = re.search(r'db\s*=\s*([0-9]+)', body, re.IGNORECASE)
            db_val = int(m_db.group(1)) if m_db else 1
            m_byte = re.search(r'byte\s*=\s*([0-9]+)', body, re.IGNORECASE)
            byte_val = int(m_byte.group(1)) if m_byte else 0
            m_rack = re.search(r'rack\s*=\s*([0-9]+)', body, re.IGNORECASE)
            rack_val = int(m_rack.group(1)) if m_rack else 0
            m_slot = re.search(r'slot\s*=\s*([0-9]+)', body, re.IGNORECASE)
            slot_val = int(m_slot.group(1)) if m_slot else 1

            arg_m = re.search(r'WriteSiemens\s*\(\s*([^,\)]+)', body, re.IGNORECASE)
            arg_str = arg_m.group(1).strip() if arg_m else "PASS"
            val = self._resolve_arg_value(arg_str, context)

            if cell.tool_instance is None or getattr(cell.tool_instance, "host", "") != ip_val:
                cell.tool_instance = SiemensS7Client(host=ip_val, rack=rack_val, slot=slot_val, timeout=0.8)

            client_s7: SiemensS7Client = cell.tool_instance
            try:
                if isinstance(val, bool) or str(val).upper() in ("PASS", "FAIL"):
                    b_val = True if (val is True or str(val).upper() == "PASS") else False
                    ok = client_s7.write_db_bool(db_val, byte_val, 0, b_val)
                elif isinstance(val, float):
                    ok = client_s7.write_db_real(db_val, byte_val, val)
                else:
                    try:
                        int_v = int(val)
                    except Exception:
                        int_v = 1 if val else 0
                    ok = client_s7.write_db_int(db_val, byte_val, int_v)
                cell.value = f"Siemens DB{db_val}.DB{byte_val}: {'OK' if ok else 'OFFLINE'}"
            except Exception as e:
                cell.value = f"Siemens ERR: {e}"
            return

        # 18. WriteBeckhoff (TwinCAT ADS & Modbus)
        if body.upper().startswith("WRITEBECKHOFF"):
            m_ip = re.search(r'ip\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            ip_val = m_ip.group(1) if m_ip else "192.168.1.20"
            m_offset = re.search(r'offset\s*=\s*([0-9]+)', body, re.IGNORECASE)
            offset_val = int(m_offset.group(1)) if m_offset else 100
            m_ams = re.search(r'ams\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            ams_val = m_ams.group(1) if m_ams else f"{ip_val}.1.1"
            m_port = re.search(r'port\s*=\s*([0-9]+)', body, re.IGNORECASE)
            port_val = int(m_port.group(1)) if m_port else 851

            arg_m = re.search(r'WriteBeckhoff\s*\(\s*([^,\)]+)', body, re.IGNORECASE)
            arg_str = arg_m.group(1).strip() if arg_m else "PASS"
            val = self._resolve_arg_value(arg_str, context)

            if cell.tool_instance is None or getattr(cell.tool_instance, "host", "") != ip_val:
                cell.tool_instance = BeckhoffAdsClient(host=ip_val, ams_net_id=ams_val, ads_port=port_val, timeout=0.8)

            client_ads: BeckhoffAdsClient = cell.tool_instance
            try:
                if isinstance(val, bool) or str(val).upper() in ("PASS", "FAIL"):
                    b_val = True if (val is True or str(val).upper() == "PASS") else False
                    ok = client_ads.write_plc_memory_bool(offset_val, 0, b_val)
                elif isinstance(val, float):
                    ok = client_ads.write_plc_memory_real(offset_val, val)
                else:
                    try:
                        int_v = int(val)
                    except Exception:
                        int_v = 1 if val else 0
                    ok = client_ads.write_index(0x4020, offset_val, int_v.to_bytes(2, "little", signed=True))
                cell.value = f"Beckhoff %MB{offset_val}: {'OK' if ok else 'OFFLINE'}"
            except Exception as e:
                cell.value = f"Beckhoff ERR: {e}"
            return

        # 19. WriteEthernet (Generic TCP / UDP)
        if body.upper().startswith("WRITEETHERNET"):
            m_ip = re.search(r'ip\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            ip_val = m_ip.group(1) if m_ip else "192.168.1.100"
            m_port = re.search(r'port\s*=\s*([0-9]+)', body, re.IGNORECASE)
            port_val = int(m_port.group(1)) if m_port else 9000
            m_fmt = re.search(r'fmt\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            fmt_val = m_fmt.group(1).upper() if m_fmt else "JSON"
            m_proto = re.search(r'proto\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            proto_val = m_proto.group(1).upper() if m_proto else "TCP"

            arg_m = re.search(r'WriteEthernet\s*\(\s*([^,\)]+)', body, re.IGNORECASE)
            arg_str = arg_m.group(1).strip() if arg_m else "PASS"
            val = self._resolve_arg_value(arg_str, context)

            if cell.tool_instance is None or getattr(cell.tool_instance, "target_ip", "") != ip_val:
                cell.tool_instance = EthernetDeviceClient(target_ip=ip_val, port=port_val, protocol=proto_val, data_format=fmt_val, timeout=0.8)

            client_eth: EthernetDeviceClient = cell.tool_instance
            try:
                passed = True if (val is True or str(val).upper() == "PASS") else False
                payload = {
                    "result": str(val),
                    "overall_pass": passed,
                    "timestamp": time.time(),
                }
                ok = client_eth.send_result(payload)
                cell.value = f"Ethernet {ip_val}:{port_val} {'Sent' if ok else 'OFFLINE'}"
            except Exception as e:
                cell.value = f"Ethernet ERR: {e}"
            return

        # 20. WriteGPIO (Raspberry Pi GPIO)
        if body.upper().startswith("WRITEGPIO"):
            m_host = re.search(r'host\s*=\s*["\']([^"\']+)["\']', body, re.IGNORECASE)
            host_val = m_host.group(1) if m_host else "192.168.1.200"
            m_pass = re.search(r'pass_pin\s*=\s*([0-9]+)', body, re.IGNORECASE)
            pass_val = int(m_pass.group(1)) if m_pass else 17
            m_fail = re.search(r'fail_pin\s*=\s*([0-9]+)', body, re.IGNORECASE)
            fail_val = int(m_fail.group(1)) if m_fail else 27

            arg_m = re.search(r'WriteGPIO\s*\(\s*([^,\)]+)', body, re.IGNORECASE)
            arg_str = arg_m.group(1).strip() if arg_m else "PASS"
            val = self._resolve_arg_value(arg_str, context)

            if cell.tool_instance is None or getattr(cell.tool_instance, "host", "") != host_val:
                cell.tool_instance = RaspberryPiGpioClient(host=host_val, pass_pin=pass_val, fail_pin=fail_val, timeout=0.8)
                cell.tool_instance.connect()

            client_gpio: RaspberryPiGpioClient = cell.tool_instance
            try:
                b_pass = True if (val is True or str(val).upper() == "PASS") else False
                client_gpio.output_inspection_result(passed=b_pass, strobe_ms=40)
                cell.value = f"GPIO Pass={pass_val} Fail={fail_val} (Pin={'HIGH' if b_pass else 'LOW'})"
            except Exception as e:
                cell.value = f"GPIO ERR: {e}"
            return

        # Geometry & Mathematical Formula Evaluator
        eval_expr = self._prepare_expression(body, context)
        try:
            safe_globals = {
                "__builtins__": None,
                "Distance": MeasurementTools.distance,
                "Angle": MeasurementTools.angle,
                "MidPoint": MeasurementTools.midpoint,
                "PointToLineDistance": MeasurementTools.point_to_line_distance,
                "LineIntersection": MeasurementTools.line_intersection,
                "Fixture": MeasurementTools.fixture_transform,
                "If": lambda cond, t, f: t if cond else f,
                "sin": np.sin,
                "cos": np.cos,
                "tan": np.tan,
                "asin": np.arcsin,
                "acos": np.arccos,
                "atan": np.arctan,
                "sqrt": np.sqrt,
                "exp": np.exp,
                "log": np.log,
                "abs": abs,
                "min": min,
                "max": max,
                "round": round,
            }
            cell.value = eval(eval_expr, safe_globals, {})
        except Exception as e:
            cell.value = f"FORMULA_ERR: {e}"

    def _prepare_expression(self, expr: str, context: Dict[str, Any]) -> str:
        def replacer(match):
            token = match.group(0)
            parts = token.split(".")
            coord = parts[0].upper()
            val = context.get(coord, None)

            if len(parts) > 1:
                prop = parts[1].lower()
                if hasattr(val, prop):
                    sub_val = getattr(val, prop)
                    return str(sub_val)
                elif isinstance(val, dict) and prop in val:
                    return str(val[prop])
                return "0.0"

            if isinstance(val, (int, float)):
                return str(val)
            elif isinstance(val, str):
                return repr(val)
            elif val is None:
                return "0"
            return str(val)

        pattern = r"\b[A-Z][0-9]{1,3}(?:\.[A-Za-z0-9_]+)?\b"
        return re.sub(pattern, replacer, expr)

    def _resolve_arg_value(self, arg_str: str, context: Dict[str, Any]) -> Any:
        """Resolves a formula argument (cell reference, property, or literal) to its computed value."""
        arg = arg_str.strip().strip("'\"")
        # Check if coordinate or property (e.g. E5 or B2.Score)
        if "." in arg:
            coord, prop = arg.split(".", 1)
            parent = context.get(coord.upper(), None)
            if hasattr(parent, prop.lower()):
                return getattr(parent, prop.lower())
            elif isinstance(parent, dict) and prop.lower() in parent:
                return parent[prop.lower()]
        elif arg.upper() in context:
            return context[arg.upper()]

        # Try boolean / pass-fail keywords
        if arg.upper() in ("PASS", "TRUE"):
            return True
        elif arg.upper() in ("FAIL", "FALSE"):
            return False
        try:
            return float(arg)
        except ValueError:
            return arg

