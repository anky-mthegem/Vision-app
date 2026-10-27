"""Comprehensive Industrial OpenCV Operations Catalog.

Registers and implements OpenCV computer vision algorithms with rich,
strongly-typed parameter schemas for dynamic in-UI editing.
"""

from __future__ import annotations
from typing import Any, Dict, List
import cv2
import numpy as np

from pipeline_engine import (
    BaseOperation,
    ParamSchema,
    ParamType,
    register_op,
)
from tools.yolo_detector import YoloDetectorTool, YoloResult
from tools.hand_tracker import HandTrackerTool
from tools.ocr import ReadOcrMaxTool, OcrResult


def ensure_grayscale(img: np.ndarray) -> np.ndarray:
    """Safely converts image to 8-bit single-channel grayscale if needed."""
    if img.ndim == 2:
        return img
    if img.ndim == 3:
        if img.shape[2] == 4:
            return cv2.cvtColor(img, cv2.COLOR_BGRA2GRAY)
        return cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    return img


def ensure_bgr(img: np.ndarray) -> np.ndarray:
    """Safely converts grayscale or binary images to 3-channel BGR."""
    if img.ndim == 2:
        return cv2.cvtColor(img, cv2.COLOR_GRAY2BGR)
    if img.ndim == 3 and img.shape[2] == 4:
        return cv2.cvtColor(img, cv2.COLOR_BGRA2BGR)
    return img


# ==============================================================================
# CATEGORY 0: AI & Deep Learning (YOLO)
# ==============================================================================

import math
import os

@register_op
class YoloObjectDetectorOp(BaseOperation):
    name = "YOLO26 / YOLO Neural Detector"
    category = "AI & Deep Learning (YOLO)"
    description = "Universal deep learning neural engine (YOLO26 / YOLO11 / YOLOv8) supporting Detection, Instance & Semantic Segmentation, Depth, Classification, Pose, and OBB."
    param_schemas = [
        ParamSchema(
            name="task_mode",
            label="Vision Task Mode",
            param_type=ParamType.CHOICE,
            default="detect",
            choices=[
                ("Object Detection (Bounding Boxes)", "detect"),
                ("Instance Segmentation (Object Masks)", "segment"),
                ("Semantic Segmentation (Pixel Classes)", "semantic"),
                ("Depth Estimation (Distance Colormap)", "depth"),
                ("Image Classification (Top-K Classes)", "classify"),
                ("Pose Estimation (Skeleton Keypoints)", "pose"),
                ("Oriented Bounding Boxes (Rotated OBB)", "obb"),
            ],
            description="Select Computer Vision task: Bounding Boxes, Masks, Semantics, Depth, Cls, Pose, or OBB.",
        ),
        ParamSchema(
            name="model_variant",
            label="Model Architecture",
            param_type=ParamType.CHOICE,
            default="yolo26",
            choices=[
                ("YOLO26 Next-Gen (Ultralytics Edge NMS-Free)", "yolo26"),
                ("YOLO11 Edge Vision Neural Network", "yolo11"),
                ("YOLOv8 Nano Embedded ONNX", "yolov8n"),
                ("Custom Weights (.onnx / .pt)", "custom"),
            ],
            description="Select neural model architecture or provide custom trained weights.",
        ),
        ParamSchema(
            name="target_class",
            label="Target Class Filter",
            param_type=ParamType.CHOICE,
            default="all",
            choices=[
                ("All 80 Classes", "all"),
                ("person", "person"),
                ("car", "car"),
                ("bottle", "bottle"),
                ("cup", "cup"),
                ("chair", "chair"),
                ("cell phone", "cell phone"),
                ("laptop", "laptop"),
                ("bus", "bus"),
                ("truck", "truck"),
                ("backpack", "backpack"),
                ("book", "book"),
                ("scissors", "scissors"),
            ],
            description="Target object class to detect and highlight (or 'all' for any COCO class).",
        ),
        ParamSchema(
            name="confidence",
            label="Confidence Threshold",
            param_type=ParamType.FLOAT,
            default=0.35,
            min_val=0.10,
            max_val=1.00,
            step=0.05,
            description="Minimum confidence score for detections.",
        ),
        ParamSchema(
            name="draw_boxes",
            label="Draw Visual Overlays",
            param_type=ParamType.BOOL,
            default=True,
            description="Draw high-tech bounding boxes, masks, colormaps, keypoints, or reticles.",
        ),
        ParamSchema(
            name="custom_path",
            label="Custom Weights Path",
            param_type=ParamType.STRING,
            default="models/yolo26n.onnx",
            description="Path to custom model weights if 'Custom Weights' is chosen.",
        ),
    ]

    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self._detector: Optional[YoloDetectorTool] = None
        self._active_variant: Optional[str] = None

    def _get_detector(self) -> YoloDetectorTool:
        variant = str(self.params.get("model_variant", "yolo26"))
        custom_p = str(self.params.get("custom_path", "")).strip()
        tgt = str(self.params.get("target_class", "all"))
        conf = float(self.params.get("confidence", 0.35))

        target_path = custom_p if variant == "custom" and custom_p else None
        if self._detector is None or self._active_variant != variant:
            self._detector = YoloDetectorTool(model_path=target_path, model_name=variant, target_class=tgt, confidence=conf)
            self._active_variant = variant
        else:
            self._detector.target_class = tgt
            self._detector.confidence = conf
        return self._detector

    def process(self, image: np.ndarray) -> np.ndarray:
        bgr = ensure_bgr(image)
        detector = self._get_detector()
        task = str(self.params.get("task_mode", "detect")).lower()

        result = detector.run_task(bgr, task=task)

        draw_b = bool(self.params.get("draw_boxes", True))
        output = bgr.copy()
        if draw_b and (result.found or result.task_mode in ("depth", "semantic", "classify")):
            output = YoloDetectorTool.draw_results(output, result)

        first_x = 0.0
        first_y = 0.0
        first_angle = 0.0

        if result.detections:
            d = result.detections[0]
            first_x = float(d.bbox[0] + d.bbox[2] / 2.0)
            first_y = float(d.bbox[1] + d.bbox[3] / 2.0)
            if d.obb:
                first_angle = float(d.obb[4])

        det_classes = [d.class_name for d in result.detections]
        metrics: Dict[str, Any] = {
            "passed": result.found,
            "count": result.count,
            "x": first_x,
            "y": first_y,
            "task_mode": task,
            "latency_ms": round(result.latency_ms, 2),
            "model": result.model_name,
            "detected_classes": det_classes,
            "class_counts": {c: det_classes.count(c) for c in set(det_classes)},
            "detections": [d.to_dict() for d in result.detections],
        }

        if task == "segment":
            metrics["total_mask_area"] = result.metrics.get("total_mask_area", 0.0)
            metrics["instances"] = result.count
        elif task == "semantic":
            metrics["foreground_ratio"] = result.metrics.get("foreground_ratio", 0.0)
            metrics["class_distribution"] = result.metrics.get("class_distribution", {})
        elif task == "depth":
            metrics["min_depth"] = result.metrics.get("min_depth", 0.0)
            metrics["max_depth"] = result.metrics.get("max_depth", 1.0)
            metrics["center_depth"] = result.metrics.get("center_depth", 0.5)
        elif task == "classify":
            metrics["top1_class"] = result.metrics.get("top1_class", "unknown")
            metrics["top1_conf"] = result.metrics.get("top1_conf", 0.0)
        elif task == "pose":
            metrics["pose_count"] = result.count
            metrics["poses"] = result.metrics.get("poses", [])
        elif task == "obb":
            metrics["obb_count"] = result.count
            metrics["angle"] = first_angle
            metrics["primary_angle"] = first_angle

        self.last_metrics = metrics
        return output


@register_op
class YoloInstanceSegmentationOp(YoloObjectDetectorOp):
    name = "YOLO Instance Segmentation"
    category = "AI & Deep Learning (YOLO)"
    description = "Extracts pixel-accurate polygon masks and area metrics for each detected object instance."
    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self.params["task_mode"] = "segment"


@register_op
class YoloSemanticSegmentationOp(YoloObjectDetectorOp):
    name = "YOLO Semantic Segmentation"
    category = "AI & Deep Learning (YOLO)"
    description = "Partitions image pixels into semantic categories (Foreground, Structures, Background) with area percentages."
    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self.params["task_mode"] = "semantic"


@register_op
class YoloDepthEstimationOp(YoloObjectDetectorOp):
    name = "YOLO Depth Estimation"
    category = "AI & Deep Learning (YOLO)"
    description = "Estimates monocular relative distance fields with false-color colormaps and optical depth probes."
    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self.params["task_mode"] = "depth"


@register_op
class YoloClassificationOp(YoloObjectDetectorOp):
    name = "YOLO Image Classification"
    category = "AI & Deep Learning (YOLO)"
    description = "Classifies images into top category rankings with confidence percentage progress bars."
    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self.params["task_mode"] = "classify"


@register_op
class YoloPoseEstimationOp(YoloObjectDetectorOp):
    name = "YOLO Pose Estimation"
    category = "AI & Deep Learning (YOLO)"
    description = "Tracks 17 standard COCO human skeletal keypoints, colored limb bones, and joint angles."
    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self.params["task_mode"] = "pose"


@register_op
class YoloObbOp(YoloObjectDetectorOp):
    name = "YOLO Oriented Bounding Boxes (OBB)"
    category = "AI & Deep Learning (YOLO)"
    description = "Detects arbitrary rotated bounding boxes with orientation angles and heading direction vectors."
    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self.params["task_mode"] = "obb"


# Alias for backwards compatibility with saved recipes and tests
from pipeline_engine import OPERATION_REGISTRY, CATEGORY_REGISTRY
OPERATION_REGISTRY["YOLOv8 Object Detector"] = YoloObjectDetectorOp
if "AI & Deep Learning (YOLO)" in CATEGORY_REGISTRY:
    if "YOLOv8 Object Detector" not in CATEGORY_REGISTRY["AI & Deep Learning (YOLO)"]:
        CATEGORY_REGISTRY["AI & Deep Learning (YOLO)"].append("YOLOv8 Object Detector")



# ==============================================================================
# CATEGORY 1: Pre-processing & Filtering
# ==============================================================================

@register_op
class GaussianBlurOp(BaseOperation):
    name = "Gaussian Blur"
    category = "Pre-processing & Filtering"
    description = "Smoothes image using a Gaussian filter to reduce high-frequency noise."
    param_schemas = [
        ParamSchema(
            name="ksize",
            label="Kernel Size (Odd)",
            param_type=ParamType.INT,
            default=5,
            min_val=1,
            max_val=31,
            step=2,
            description="Kernel size width & height (must be positive odd number).",
        ),
        ParamSchema(
            name="sigmaX",
            label="Sigma X",
            param_type=ParamType.FLOAT,
            default=1.5,
            min_val=0.0,
            max_val=20.0,
            step=0.1,
            description="Gaussian kernel standard deviation in X direction (0 = auto).",
        ),
        ParamSchema(
            name="sigmaY",
            label="Sigma Y",
            param_type=ParamType.FLOAT,
            default=0.0,
            min_val=0.0,
            max_val=20.0,
            step=0.1,
            description="Gaussian kernel standard deviation in Y direction (0 = equal to sigmaX).",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        k = max(1, int(self.params.get("ksize", 5)))
        if k % 2 == 0:
            k += 1
        sx = float(self.params.get("sigmaX", 1.5))
        sy = float(self.params.get("sigmaY", 0.0))
        return cv2.GaussianBlur(image, (k, k), sigmaX=sx, sigmaY=sy)


@register_op
class MedianBlurOp(BaseOperation):
    name = "Median Blur"
    category = "Pre-processing & Filtering"
    description = "Non-linear filter highly effective at eliminating salt-and-pepper noise while preserving edges."
    param_schemas = [
        ParamSchema(
            name="ksize",
            label="Kernel Aperture Size",
            param_type=ParamType.INT,
            default=5,
            min_val=1,
            max_val=31,
            step=2,
            description="Aperture linear size; must be odd and greater than 1.",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        k = max(1, int(self.params.get("ksize", 5)))
        if k % 2 == 0:
            k += 1
        return cv2.medianBlur(image, k)


@register_op
class BilateralFilterOp(BaseOperation):
    name = "Bilateral Filter"
    category = "Pre-processing & Filtering"
    description = "Edge-preserving smoothing filter that prevents edge blurring while reducing noise."
    param_schemas = [
        ParamSchema(
            name="d",
            label="Diameter (d)",
            param_type=ParamType.INT,
            default=9,
            min_val=1,
            max_val=25,
            step=1,
            description="Diameter of each pixel neighborhood used during filtering.",
        ),
        ParamSchema(
            name="sigmaColor",
            label="Sigma Color",
            param_type=ParamType.FLOAT,
            default=75.0,
            min_val=1.0,
            max_val=250.0,
            step=5.0,
            description="Filter sigma in the color space. Larger value mixes colors together.",
        ),
        ParamSchema(
            name="sigmaSpace",
            label="Sigma Space",
            param_type=ParamType.FLOAT,
            default=75.0,
            min_val=1.0,
            max_val=250.0,
            step=5.0,
            description="Filter sigma in coordinate space. Larger value includes farther pixels.",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        d = int(self.params.get("d", 9))
        sc = float(self.params.get("sigmaColor", 75.0))
        ss = float(self.params.get("sigmaSpace", 75.0))
        return cv2.bilateralFilter(image, d, sc, ss)


@register_op
class ColorConvertOp(BaseOperation):
    name = "Color Space Conversion"
    category = "Pre-processing & Filtering"
    description = "Transforms image between color spaces (Grayscale, BGR, HSV, RGB, LAB)."
    param_schemas = [
        ParamSchema(
            name="conversion",
            label="Conversion Mode",
            param_type=ParamType.CHOICE,
            default="BGR to Gray",
            choices=[
                ("BGR to Gray", "BGR2GRAY"),
                ("Gray to BGR", "GRAY2BGR"),
                ("BGR to HSV", "BGR2HSV"),
                ("BGR to RGB", "BGR2RGB"),
                ("BGR to LAB", "BGR2LAB"),
                ("BGR to YCrCb", "BGR2YCrCb"),
            ],
            description="Source and target color space pair.",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        mode = self.params.get("conversion", "BGR2GRAY")
        is_gray = image.ndim == 2

        if mode == "BGR2GRAY":
            return ensure_grayscale(image)
        elif mode == "GRAY2BGR":
            return ensure_bgr(image)
        elif mode == "BGR2HSV":
            bgr = ensure_bgr(image)
            return cv2.cvtColor(bgr, cv2.COLOR_BGR2HSV)
        elif mode == "BGR2RGB":
            bgr = ensure_bgr(image)
            return cv2.cvtColor(bgr, cv2.COLOR_BGR2RGB)
        elif mode == "BGR2LAB":
            bgr = ensure_bgr(image)
            return cv2.cvtColor(bgr, cv2.COLOR_BGR2LAB)
        elif mode == "BGR2YCrCb":
            bgr = ensure_bgr(image)
            return cv2.cvtColor(bgr, cv2.COLOR_BGR2YCrCb)
        return image


@register_op
class HsvColorFilterOp(BaseOperation):
    name = "HSV Color InRange Filter"
    category = "Pre-processing & Filtering"
    description = "Isolates specific target colors using lower and upper Hue-Saturation-Value thresholds."
    param_schemas = [
        ParamSchema(name="h_min", label="Hue Min (0-180)", param_type=ParamType.INT, default=0, min_val=0, max_val=180, step=1),
        ParamSchema(name="h_max", label="Hue Max (0-180)", param_type=ParamType.INT, default=180, min_val=0, max_val=180, step=1),
        ParamSchema(name="s_min", label="Sat Min (0-255)", param_type=ParamType.INT, default=50, min_val=0, max_val=255, step=1),
        ParamSchema(name="s_max", label="Sat Max (0-255)", param_type=ParamType.INT, default=255, min_val=0, max_val=255, step=1),
        ParamSchema(name="v_min", label="Val Min (0-255)", param_type=ParamType.INT, default=50, min_val=0, max_val=255, step=1),
        ParamSchema(name="v_max", label="Val Max (0-255)", param_type=ParamType.INT, default=255, min_val=0, max_val=255, step=1),
        ParamSchema(name="invert", label="Invert Mask", param_type=ParamType.BOOL, default=False),
        ParamSchema(name="apply_mask", label="Output Masked BGR", param_type=ParamType.BOOL, default=False, description="When True outputs masked color image; when False outputs binary mask."),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        bgr = ensure_bgr(image)
        hsv = cv2.cvtColor(bgr, cv2.COLOR_BGR2HSV)
        lower = np.array([int(self.params["h_min"]), int(self.params["s_min"]), int(self.params["v_min"])], dtype=np.uint8)
        upper = np.array([int(self.params["h_max"]), int(self.params["s_max"]), int(self.params["v_max"])], dtype=np.uint8)
        mask = cv2.inRange(hsv, lower, upper)
        if self.params.get("invert", False):
            mask = cv2.bitwise_not(mask)
        if self.params.get("apply_mask", False):
            return cv2.bitwise_and(bgr, bgr, mask=mask)
        return mask


# ==============================================================================
# CATEGORY 2: Thresholding & Binarization
# ==============================================================================

@register_op
class AdaptiveThresholdOp(BaseOperation):
    name = "Adaptive Threshold"
    category = "Thresholding & Binarization"
    description = "Calculates threshold for small regions, ideal for varying illumination."
    param_schemas = [
        ParamSchema(
            name="maxValue",
            label="Max Value",
            param_type=ParamType.FLOAT,
            default=255.0,
            min_val=1.0,
            max_val=255.0,
            step=1.0,
            description="Non-zero value assigned to the pixels for which the condition is satisfied.",
        ),
        ParamSchema(
            name="adaptiveMethod",
            label="Adaptive Method",
            param_type=ParamType.CHOICE,
            default=cv2.ADAPTIVE_THRESH_GAUSSIAN_C,
            choices=[
                ("Gaussian Weighted", cv2.ADAPTIVE_THRESH_GAUSSIAN_C),
                ("Mean Neighborhood", cv2.ADAPTIVE_THRESH_MEAN_C),
            ],
            description="Algorithm used to calculate the threshold value.",
        ),
        ParamSchema(
            name="thresholdType",
            label="Threshold Type",
            param_type=ParamType.CHOICE,
            default=cv2.THRESH_BINARY,
            choices=[
                ("Binary (Foreground White)", cv2.THRESH_BINARY),
                ("Binary Inverted (Foreground Black)", cv2.THRESH_BINARY_INV),
            ],
            description="Thresholding type: binary or inverted binary.",
        ),
        ParamSchema(
            name="blockSize",
            label="Block Size (Odd)",
            param_type=ParamType.INT,
            default=11,
            min_val=3,
            max_val=99,
            step=2,
            description="Size of pixel neighborhood used to calculate threshold (must be odd > 1).",
        ),
        ParamSchema(
            name="C",
            label="Constant C",
            param_type=ParamType.FLOAT,
            default=2.0,
            min_val=-50.0,
            max_val=50.0,
            step=0.5,
            description="Constant subtracted from the mean or weighted mean.",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        gray = ensure_grayscale(image)
        max_val = float(self.params.get("maxValue", 255.0))
        method = int(self.params.get("adaptiveMethod", cv2.ADAPTIVE_THRESH_GAUSSIAN_C))
        ttype = int(self.params.get("thresholdType", cv2.THRESH_BINARY))
        bsize = max(3, int(self.params.get("blockSize", 11)))
        if bsize % 2 == 0:
            bsize += 1
        c_val = float(self.params.get("C", 2.0))
        return cv2.adaptiveThreshold(gray, max_val, method, ttype, bsize, c_val)


@register_op
class ThresholdOp(BaseOperation):
    name = "Standard & Otsu Threshold"
    category = "Thresholding & Binarization"
    description = "Fixed-level binarization with optional Otsu optimal threshold detection."
    param_schemas = [
        ParamSchema(
            name="thresh",
            label="Threshold Level",
            param_type=ParamType.FLOAT,
            default=127.0,
            min_val=0.0,
            max_val=255.0,
            step=1.0,
            description="Threshold cutoff value (ignored if Otsu is active).",
        ),
        ParamSchema(
            name="maxval",
            label="Maximum Value",
            param_type=ParamType.FLOAT,
            default=255.0,
            min_val=1.0,
            max_val=255.0,
            step=1.0,
            description="Maximum value used with THRESH_BINARY and THRESH_BINARY_INV.",
        ),
        ParamSchema(
            name="type",
            label="Threshold Mode",
            param_type=ParamType.CHOICE,
            default=cv2.THRESH_BINARY,
            choices=[
                ("Binary", cv2.THRESH_BINARY),
                ("Binary Inverted", cv2.THRESH_BINARY_INV),
                ("Truncate", cv2.THRESH_TRUNC),
                ("To Zero", cv2.THRESH_TOZERO),
                ("To Zero Inverted", cv2.THRESH_TOZERO_INV),
            ],
            description="Thresholding mode.",
        ),
        ParamSchema(
            name="use_otsu",
            label="Otsu Automatic Threshold",
            param_type=ParamType.BOOL,
            default=False,
            description="Automatically computes optimal threshold from histogram.",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        gray = ensure_grayscale(image)
        thresh = float(self.params.get("thresh", 127.0))
        maxval = float(self.params.get("maxval", 255.0))
        ttype = int(self.params.get("type", cv2.THRESH_BINARY))
        if self.params.get("use_otsu", False):
            ttype |= cv2.THRESH_OTSU
        _, dst = cv2.threshold(gray, thresh, maxval, ttype)
        return dst


# ==============================================================================
# CATEGORY 3: Morphology
# ==============================================================================

@register_op
class MorphologyExOp(BaseOperation):
    name = "Morphology Ex"
    category = "Morphology"
    description = "Advanced mathematical morphology operations (Open, Close, Gradient, Top Hat, Black Hat)."
    param_schemas = [
        ParamSchema(
            name="op_type",
            label="Morphology Operation",
            param_type=ParamType.CHOICE,
            default=cv2.MORPH_OPEN,
            choices=[
                ("Opening (Remove Noise)", cv2.MORPH_OPEN),
                ("Closing (Close Gaps)", cv2.MORPH_CLOSE),
                ("Gradient (Outline)", cv2.MORPH_GRADIENT),
                ("Top Hat (Light Details)", cv2.MORPH_TOPHAT),
                ("Black Hat (Dark Details)", cv2.MORPH_BLACKHAT),
            ],
            description="Type of morphological transformation.",
        ),
        ParamSchema(
            name="kernel_shape",
            label="Structuring Element Shape",
            param_type=ParamType.CHOICE,
            default=cv2.MORPH_RECT,
            choices=[
                ("Rectangle", cv2.MORPH_RECT),
                ("Ellipse / Circle", cv2.MORPH_ELLIPSE),
                ("Cross", cv2.MORPH_CROSS),
            ],
            description="Shape of structuring element.",
        ),
        ParamSchema(
            name="kernel_size",
            label="Kernel Size (Odd)",
            param_type=ParamType.INT,
            default=3,
            min_val=1,
            max_val=31,
            step=2,
            description="Dimensions of structuring element.",
        ),
        ParamSchema(
            name="iterations",
            label="Iterations",
            param_type=ParamType.INT,
            default=1,
            min_val=1,
            max_val=10,
            step=1,
            description="Number of times the operation is applied.",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        op = int(self.params.get("op_type", cv2.MORPH_OPEN))
        shape = int(self.params.get("kernel_shape", cv2.MORPH_RECT))
        ksize = max(1, int(self.params.get("kernel_size", 3)))
        if ksize % 2 == 0:
            ksize += 1
        iters = max(1, int(self.params.get("iterations", 1)))

        kernel = cv2.getStructuringElement(shape, (ksize, ksize))
        return cv2.morphologyEx(image, op, kernel, iterations=iters)


@register_op
class DilateOp(BaseOperation):
    name = "Dilate"
    category = "Morphology"
    description = "Expands bright image regions, joining close components."
    param_schemas = [
        ParamSchema(
            name="kernel_shape",
            label="Kernel Shape",
            param_type=ParamType.CHOICE,
            default=cv2.MORPH_RECT,
            choices=[("Rectangle", cv2.MORPH_RECT), ("Ellipse", cv2.MORPH_ELLIPSE), ("Cross", cv2.MORPH_CROSS)],
        ),
        ParamSchema(name="kernel_size", label="Kernel Size", param_type=ParamType.INT, default=3, min_val=1, max_val=31, step=2),
        ParamSchema(name="iterations", label="Iterations", param_type=ParamType.INT, default=1, min_val=1, max_val=10, step=1),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        shape = int(self.params.get("kernel_shape", cv2.MORPH_RECT))
        ksize = max(1, int(self.params.get("kernel_size", 3)))
        iters = max(1, int(self.params.get("iterations", 1)))
        kernel = cv2.getStructuringElement(shape, (ksize, ksize))
        return cv2.dilate(image, kernel, iterations=iters)


@register_op
class ErodeOp(BaseOperation):
    name = "Erode"
    category = "Morphology"
    description = "Erodes boundaries of bright regions, isolating distinct features."
    param_schemas = [
        ParamSchema(
            name="kernel_shape",
            label="Kernel Shape",
            param_type=ParamType.CHOICE,
            default=cv2.MORPH_RECT,
            choices=[("Rectangle", cv2.MORPH_RECT), ("Ellipse", cv2.MORPH_ELLIPSE), ("Cross", cv2.MORPH_CROSS)],
        ),
        ParamSchema(name="kernel_size", label="Kernel Size", param_type=ParamType.INT, default=3, min_val=1, max_val=31, step=2),
        ParamSchema(name="iterations", label="Iterations", param_type=ParamType.INT, default=1, min_val=1, max_val=10, step=1),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        shape = int(self.params.get("kernel_shape", cv2.MORPH_RECT))
        ksize = max(1, int(self.params.get("kernel_size", 3)))
        iters = max(1, int(self.params.get("iterations", 1)))
        kernel = cv2.getStructuringElement(shape, (ksize, ksize))
        return cv2.erode(image, kernel, iterations=iters)


# ==============================================================================
# CATEGORY 4: Edges & Gradients
# ==============================================================================

@register_op
class CannyEdgeOp(BaseOperation):
    name = "Canny Edge"
    category = "Edges & Gradients"
    description = "Multi-stage edge detector finding intensity discontinuities with hysteresis."
    param_schemas = [
        ParamSchema(
            name="threshold1",
            label="First Threshold (Hysteresis Low)",
            param_type=ParamType.FLOAT,
            default=100.0,
            min_val=0.0,
            max_val=500.0,
            step=5.0,
            description="Lower hysteresis threshold for linking edge segments.",
        ),
        ParamSchema(
            name="threshold2",
            label="Second Threshold (Hysteresis High)",
            param_type=ParamType.FLOAT,
            default=200.0,
            min_val=0.0,
            max_val=500.0,
            step=5.0,
            description="Upper hysteresis threshold for strong edge seeds.",
        ),
        ParamSchema(
            name="apertureSize",
            label="Sobel Aperture Size",
            param_type=ParamType.CHOICE,
            default=3,
            choices=[("3x3", 3), ("5x5", 5), ("7x7", 7)],
            description="Aperture size for the Sobel operator.",
        ),
        ParamSchema(
            name="L2gradient",
            label="Use L2 Gradient Norm",
            param_type=ParamType.BOOL,
            default=False,
            description="True uses L2 norm = sqrt(dI/dx^2 + dI/dy^2) for accuracy; False uses L1 sum of abs.",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        gray = ensure_grayscale(image)
        t1 = float(self.params.get("threshold1", 100.0))
        t2 = float(self.params.get("threshold2", 200.0))
        ap = int(self.params.get("apertureSize", 3))
        l2 = bool(self.params.get("L2gradient", False))
        return cv2.Canny(gray, t1, t2, apertureSize=ap, L2gradient=l2)


@register_op
class SobelOp(BaseOperation):
    name = "Sobel Gradient"
    category = "Edges & Gradients"
    description = "Calculates first image derivatives using an extended Sobel operator."
    param_schemas = [
        ParamSchema(
            name="dx",
            label="Derivative Order X",
            param_type=ParamType.CHOICE,
            default=1,
            choices=[("Order 1 (Horizontal Edges)", 1), ("Order 2", 2), ("None (0)", 0)],
        ),
        ParamSchema(
            name="dy",
            label="Derivative Order Y",
            param_type=ParamType.CHOICE,
            default=0,
            choices=[("Order 1 (Vertical Edges)", 1), ("Order 2", 2), ("None (0)", 0)],
        ),
        ParamSchema(
            name="ksize",
            label="Kernel Size",
            param_type=ParamType.CHOICE,
            default=3,
            choices=[("1x1", 1), ("3x3", 3), ("5x5", 5), ("7x7", 7)],
        ),
        ParamSchema(name="scale", label="Scale Factor", param_type=ParamType.FLOAT, default=1.0, min_val=0.1, max_val=10.0, step=0.1),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        gray = ensure_grayscale(image)
        dx = int(self.params.get("dx", 1))
        dy = int(self.params.get("dy", 0))
        if dx == 0 and dy == 0:
            dx = 1
        ksize = int(self.params.get("ksize", 3))
        scale = float(self.params.get("scale", 1.0))
        grad = cv2.Sobel(gray, cv2.CV_16S, dx, dy, ksize=ksize, scale=scale)
        return cv2.convertScaleAbs(grad)


@register_op
class LaplacianOp(BaseOperation):
    name = "Laplacian"
    category = "Edges & Gradients"
    description = "Second-derivative isotropic edge detector highlighting rapid intensity transitions."
    param_schemas = [
        ParamSchema(
            name="ksize",
            label="Aperture Size",
            param_type=ParamType.CHOICE,
            default=3,
            choices=[("1x1", 1), ("3x3", 3), ("5x5", 5), ("7x7", 7)],
        ),
        ParamSchema(name="scale", label="Scale Factor", param_type=ParamType.FLOAT, default=1.0, min_val=0.1, max_val=10.0, step=0.1),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        gray = ensure_grayscale(image)
        ksize = int(self.params.get("ksize", 3))
        scale = float(self.params.get("scale", 1.0))
        lap = cv2.Laplacian(gray, cv2.CV_16S, ksize=ksize, scale=scale)
        return cv2.convertScaleAbs(lap)


# ==============================================================================
# CATEGORY 5: Contours & Calipers
# ==============================================================================

@register_op
class FindContoursOp(BaseOperation):
    name = "Find Contours & Filter"
    category = "Contours & Calipers"
    description = "Extracts object boundaries, filters by area, and renders annotated bounding boxes and contours."
    param_schemas = [
        ParamSchema(
            name="mode",
            label="Retrieval Mode",
            param_type=ParamType.CHOICE,
            default=cv2.RETR_EXTERNAL,
            choices=[
                ("External Only", cv2.RETR_EXTERNAL),
                ("List (All Contours)", cv2.RETR_LIST),
                ("Hierarchical Tree", cv2.RETR_TREE),
                ("2-Level Connected Components", cv2.RETR_CCOMP),
            ],
            description="Contour hierarchy retrieval mode.",
        ),
        ParamSchema(
            name="method",
            label="Approximation Method",
            param_type=ParamType.CHOICE,
            default=cv2.CHAIN_APPROX_SIMPLE,
            choices=[
                ("Simple (Compress Horiz/Vert/Diag)", cv2.CHAIN_APPROX_SIMPLE),
                ("None (Store All Points)", cv2.CHAIN_APPROX_NONE),
            ],
            description="Contour approximation method.",
        ),
        ParamSchema(
            name="min_area",
            label="Min Area (px²)",
            param_type=ParamType.FLOAT,
            default=100.0,
            min_val=0.0,
            max_val=1000000.0,
            step=50.0,
            description="Minimum contour area threshold.",
        ),
        ParamSchema(
            name="max_area",
            label="Max Area (px²)",
            param_type=ParamType.FLOAT,
            default=500000.0,
            min_val=0.0,
            max_val=5000000.0,
            step=1000.0,
            description="Maximum contour area threshold.",
        ),
        ParamSchema(
            name="draw_mode",
            label="Visualization Style",
            param_type=ParamType.CHOICE,
            default="Bounding Box & Center",
            choices=[
                ("Contours Outline", "contour"),
                ("Filled Contours", "filled"),
                ("Bounding Box (Axis Aligned)", "bbox"),
                ("Rotated Min Area Box", "min_rect"),
                ("Bounding Box & Center", "bbox_center"),
            ],
            description="How to annotate detected contours on the output frame.",
        ),
        ParamSchema(
            name="color",
            label="Annotation Color",
            param_type=ParamType.CHOICE,
            default="Green",
            choices=[
                ("Green", "green"),
                ("Cyan", "cyan"),
                ("Yellow", "yellow"),
                ("Red", "red"),
                ("Magenta", "magenta"),
            ],
        ),
        ParamSchema(
            name="thickness",
            label="Line Thickness",
            param_type=ParamType.INT,
            default=2,
            min_val=1,
            max_val=10,
            step=1,
        ),
    ]

    COLOR_MAP = {
        "green": (0, 230, 118),
        "cyan": (0, 210, 255),
        "yellow": (0, 230, 255),
        "red": (30, 30, 255),
        "magenta": (255, 0, 255),
    }

    def process(self, image: np.ndarray) -> np.ndarray:
        gray = ensure_grayscale(image)
        # If image is grayscale with gradient, binarize with Otsu
        if len(np.unique(gray)) > 2:
            _, bin_img = cv2.threshold(gray, 0, 255, cv2.THRESH_BINARY | cv2.THRESH_OTSU)
        else:
            bin_img = gray.copy()

        mode = int(self.params.get("mode", cv2.RETR_EXTERNAL))
        method = int(self.params.get("method", cv2.CHAIN_APPROX_SIMPLE))
        min_area = float(self.params.get("min_area", 100.0))
        max_area = float(self.params.get("max_area", 500000.0))
        draw_mode = str(self.params.get("draw_mode", "bbox_center"))
        color_name = str(self.params.get("color", "green")).lower()
        color = self.COLOR_MAP.get(color_name, (0, 230, 118))
        th = int(self.params.get("thickness", 2))

        contours, _ = cv2.findContours(bin_img, mode, method)
        output = ensure_bgr(image).copy()

        valid_count = 0
        for cnt in contours:
            area = cv2.contourArea(cnt)
            if min_area <= area <= max_area:
                valid_count += 1
                if draw_mode == "contour":
                    cv2.drawContours(output, [cnt], -1, color, th)
                elif draw_mode == "filled":
                    cv2.drawContours(output, [cnt], -1, color, -1)
                elif draw_mode == "bbox":
                    x, y, w, h = cv2.boundingRect(cnt)
                    cv2.rectangle(output, (x, y), (x + w, y + h), color, th)
                elif draw_mode == "min_rect":
                    rect = cv2.minAreaRect(cnt)
                    box = np.int32(cv2.boxPoints(rect))
                    cv2.drawContours(output, [box], 0, color, th)
                elif draw_mode == "bbox_center":
                    x, y, w, h = cv2.boundingRect(cnt)
                    cv2.rectangle(output, (x, y), (x + w, y + h), color, th)
                    M = cv2.moments(cnt)
                    if M["m00"] != 0:
                        cx = int(M["m10"] / M["m00"])
                        cy = int(M["m01"] / M["m00"])
                        cv2.circle(output, (cx, cy), 4, (0, 210, 255), -1)
                        cv2.putText(
                            output,
                            f"A:{int(area)}",
                            (x, max(15, y - 6)),
                            cv2.FONT_HERSHEY_SIMPLEX,
                            0.45,
                            color,
                            1,
                            cv2.LINE_AA,
                        )

        # Draw HUD badge showing count
        cv2.putText(
            output,
            f"Objects Found: {valid_count}",
            (18, 28),
            cv2.FONT_HERSHEY_SIMPLEX,
            0.65,
            (0, 210, 255),
            2,
            cv2.LINE_AA,
        )
        self.last_metrics = {
            "passed": valid_count > 0,
            "count": valid_count,
            "x": float(contours[0][0][0][0]) if valid_count > 0 and len(contours[0]) > 0 else 0.0,
            "y": float(contours[0][0][0][1]) if valid_count > 0 and len(contours[0]) > 0 else 0.0,
        }
        return output


@register_op
class IndustrialMeasurementOp(BaseOperation):
    name = "Industrial Caliper & Measurement"
    category = "Contours & Calipers"
    description = "Measures line lengths, shape areas, caliper dimensions, and diameters with camera calibration factor and Go/No-Go tolerance verification."
    param_schemas = [
        ParamSchema(
            name="calibration_factor",
            label="Calibration (Units/Pixel)",
            param_type=ParamType.FLOAT,
            default=0.10,
            min_val=0.0001,
            max_val=10.0,
            step=0.005,
            description="Physical units per pixel (e.g., 0.10 mm/pixel means 100 pixels = 10 mm).",
        ),
        ParamSchema(
            name="unit",
            label="Measurement Unit",
            param_type=ParamType.CHOICE,
            default="mm",
            choices=[
                ("Millimeters (mm)", "mm"),
                ("Centimeters (cm)", "cm"),
                ("Inches (in)", "in"),
                ("Microns (um)", "um"),
                ("Pixels (px)", "px"),
            ],
            description="Engineering measurement unit for display and export.",
        ),
        ParamSchema(
            name="measurement_mode",
            label="Measurement Mode",
            param_type=ParamType.CHOICE,
            default="all",
            choices=[
                ("All Caliper Dimensions (Area, L, W, D)", "all"),
                ("Length of Line / Major Caliper Axis", "line_length"),
                ("Shape Surface Area", "shape_area"),
                ("Bounding Box (Width x Height)", "bounding_box"),
                ("Circle Diameter & Radius", "circle_diameter"),
            ],
            description="Measurement geometry to calculate and verify.",
        ),
        ParamSchema(
            name="min_area",
            label="Min Feature Area (px²)",
            param_type=ParamType.FLOAT,
            default=150.0,
            min_val=10.0,
            max_val=50000.0,
            step=50.0,
            description="Minimum area threshold for parts to be measured.",
        ),
        ParamSchema(
            name="target_dimension",
            label="Nominal Target Dimension",
            param_type=ParamType.FLOAT,
            default=50.0,
            min_val=0.0,
            max_val=1000.0,
            step=1.0,
            description="Target expected dimension for Go/No-Go check (0 to disable).",
        ),
        ParamSchema(
            name="tolerance",
            label="Tolerance (± Delta)",
            param_type=ParamType.FLOAT,
            default=2.5,
            min_val=0.01,
            max_val=50.0,
            step=0.1,
            description="Allowable tolerance band (±) around target dimension.",
        ),
        ParamSchema(
            name="draw_arrows",
            label="Draw Caliper Dimension Arrows",
            param_type=ParamType.BOOL,
            default=True,
            description="Draw engineering dimension witness lines and double-ended arrows.",
        ),
        ParamSchema(
            name="draw_callout",
            label="Draw Metrology Callout HUD",
            param_type=ParamType.BOOL,
            default=True,
            description="Display callout box with calibrated values and PASS/FAIL status.",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        gray = ensure_grayscale(image)
        output = ensure_bgr(image).copy()

        # Binarize with Otsu
        if len(np.unique(gray)) > 2:
            _, bin_img = cv2.threshold(gray, 0, 255, cv2.THRESH_BINARY | cv2.THRESH_OTSU)
        else:
            bin_img = gray.copy()

        cal_factor = float(self.params.get("calibration_factor", 0.10))
        unit = str(self.params.get("unit", "mm"))
        mode = str(self.params.get("measurement_mode", "all"))
        min_area = float(self.params.get("min_area", 150.0))
        target_dim = float(self.params.get("target_dimension", 50.0))
        tolerance = float(self.params.get("tolerance", 2.5))
        draw_arr = bool(self.params.get("draw_arrows", True))
        draw_call = bool(self.params.get("draw_callout", True))

        contours, _ = cv2.findContours(bin_img, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
        valid_contours = [c for c in contours if cv2.contourArea(c) >= min_area]
        valid_contours.sort(key=cv2.contourArea, reverse=True)

        passed = False
        length_cal = 0.0
        width_cal = 0.0
        area_cal = 0.0
        diam_cal = 0.0
        dev_val = 0.0
        primary_val = 0.0
        first_x, first_y = 0.0, 0.0

        if valid_contours:
            c = valid_contours[0]
            area_px = cv2.contourArea(c)
            area_cal = area_px * (cal_factor ** 2)

            rect = cv2.minAreaRect(c)
            (rcx, rcy), (rw, rh), angle = rect
            first_x, first_y = float(rcx), float(rcy)

            l_px = max(rw, rh)
            w_px = min(rw, rh)
            length_cal = l_px * cal_factor
            width_cal = w_px * cal_factor

            (ccx, ccy), radius = cv2.minEnclosingCircle(c)
            diam_cal = (radius * 2.0) * cal_factor

            if mode == "shape_area":
                primary_val = area_cal
            elif mode == "circle_diameter":
                primary_val = diam_cal
            else:
                primary_val = length_cal

            if target_dim > 0:
                dev_val = primary_val - target_dim
                passed = abs(dev_val) <= tolerance
            else:
                passed = True
                dev_val = 0.0

            color = (0, 230, 118) if passed else (0, 23, 255)
            box_pts = cv2.boxPoints(rect).astype(np.int32)
            cv2.drawContours(output, [box_pts], 0, (0, 210, 255), 2)
            cv2.drawMarker(output, (int(rcx), int(rcy)), color, cv2.MARKER_CROSS, 14, 2)

            if draw_arr:
                p1 = box_pts[0]
                p2 = box_pts[1]
                p3 = box_pts[2]
                d12 = np.linalg.norm(p1 - p2)
                d23 = np.linalg.norm(p2 - p3)
                if d12 >= d23:
                    start_pt, end_pt = p1, p2
                    w_start, w_end = p2, p3
                else:
                    start_pt, end_pt = p2, p3
                    w_start, w_end = p1, p2

                cv2.arrowedLine(output, tuple(start_pt), tuple(end_pt), color, 2, tipLength=0.08)
                cv2.arrowedLine(output, tuple(end_pt), tuple(start_pt), color, 2, tipLength=0.08)
                mid_l = ((start_pt[0] + end_pt[0]) // 2, (start_pt[1] + end_pt[1]) // 2)
                cv2.putText(output, f"L: {length_cal:.2f} {unit}", (mid_l[0] - 30, mid_l[1] - 8), cv2.FONT_HERSHEY_SIMPLEX, 0.50, color, 2, cv2.LINE_AA)

                cv2.arrowedLine(output, tuple(w_start), tuple(w_end), (255, 180, 0), 1, tipLength=0.1)
                mid_w = ((w_start[0] + w_end[0]) // 2, (w_start[1] + w_end[1]) // 2)
                cv2.putText(output, f"W: {width_cal:.2f} {unit}", (mid_w[0] + 5, mid_w[1]), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (255, 180, 0), 1, cv2.LINE_AA)

            if draw_call:
                status_str = "PASS" if passed else f"FAIL (DEV: {dev_val:+.2f}{unit})"
                hud_x, hud_y = 20, 30
                cv2.rectangle(output, (hud_x - 5, hud_y - 20), (hud_x + 320, hud_y + 80), (22, 25, 29), -1)
                cv2.rectangle(output, (hud_x - 5, hud_y - 20), (hud_x + 320, hud_y + 80), color, 2)
                cv2.putText(output, f"CALIPER METROLOGY [{status_str}]", (hud_x + 5, hud_y), cv2.FONT_HERSHEY_SIMPLEX, 0.55, color, 2, cv2.LINE_AA)
                cv2.putText(output, f"Length: {length_cal:.2f} {unit} | Width: {width_cal:.2f} {unit}", (hud_x + 5, hud_y + 24), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (224, 230, 237), 1, cv2.LINE_AA)
                cv2.putText(output, f"Area: {area_cal:.1f} {unit}² | Diam: {diam_cal:.2f} {unit}", (hud_x + 5, hud_y + 46), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (224, 230, 237), 1, cv2.LINE_AA)
                cv2.putText(output, f"Target: {target_dim:.2f} ±{tolerance:.2f} {unit}", (hud_x + 5, hud_y + 68), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (0, 210, 255), 1, cv2.LINE_AA)

        self.last_metrics = {
            "passed": passed,
            "count": len(valid_contours),
            "length": round(length_cal, 3),
            "width": round(width_cal, 3),
            "area": round(area_cal, 3),
            "diameter": round(diam_cal, 3),
            "deviation": round(dev_val, 3),
            "unit": unit,
            "calibration_factor": cal_factor,
            "x": first_x,
            "y": first_y,
        }
        return output


# ==============================================================================
# CATEGORY 6: Feature Detection (Shapes, Hands, OCR)
# ==============================================================================

@register_op
class BasicShapeDetectorOp(BaseOperation):
    name = "Geometric Shape Detector"
    category = "Feature Detection"
    description = "Classifies geometric shapes (Circle, Square, Rectangle, Triangle, Polygon, Ellipse) with area, aspect ratio, and circularity metrics."
    param_schemas = [
        ParamSchema(
            name="target_shape",
            label="Target Shape",
            param_type=ParamType.CHOICE,
            default="all",
            choices=[
                ("All Geometric Shapes", "all"),
                ("Circle", "circle"),
                ("Square", "square"),
                ("Rectangle", "rectangle"),
                ("Triangle", "triangle"),
                ("Polygon / Multi-sided", "polygon"),
                ("Ellipse", "ellipse"),
            ],
            description="Filter inspection to a specific geometric shape or detect all.",
        ),
        ParamSchema(
            name="min_area",
            label="Minimum Area (px²)",
            param_type=ParamType.FLOAT,
            default=150.0,
            min_val=10.0,
            max_val=50000.0,
            step=50.0,
            description="Discard contours smaller than this area.",
        ),
        ParamSchema(
            name="max_area",
            label="Maximum Area (px²)",
            param_type=ParamType.FLOAT,
            default=500000.0,
            min_val=1000.0,
            max_val=2000000.0,
            step=1000.0,
            description="Discard contours larger than this area.",
        ),
        ParamSchema(
            name="circularity_threshold",
            label="Circularity Threshold",
            param_type=ParamType.FLOAT,
            default=0.78,
            min_val=0.50,
            max_val=1.00,
            step=0.02,
            description="Min 4*pi*Area/P^2 ratio to classify contour as circle.",
        ),
        ParamSchema(
            name="draw_contours",
            label="Draw Contours",
            param_type=ParamType.BOOL,
            default=True,
            description="Draw colored shape boundary contours.",
        ),
        ParamSchema(
            name="draw_labels",
            label="Draw Shape Badges",
            param_type=ParamType.BOOL,
            default=True,
            description="Draw shape classification badge with dimensions and center.",
        ),
    ]

    SHAPE_COLORS = {
        "circle": (255, 210, 0),      # Cyan
        "square": (118, 230, 0),      # Emerald Green
        "rectangle": (0, 255, 128),   # Lime Green
        "triangle": (0, 165, 255),    # Orange
        "polygon": (255, 0, 210),     # Magenta
        "ellipse": (240, 150, 180),   # Lavender
    }

    def process(self, image: np.ndarray) -> np.ndarray:
        gray = ensure_grayscale(image)
        output = ensure_bgr(image).copy()

        blurred = cv2.GaussianBlur(gray, (5, 5), 0)
        _, thresh = cv2.threshold(blurred, 0, 255, cv2.THRESH_BINARY | cv2.THRESH_OTSU)

        target = str(self.params.get("target_shape", "all")).lower()
        min_a = float(self.params.get("min_area", 150.0))
        max_a = float(self.params.get("max_area", 500000.0))
        circ_th = float(self.params.get("circularity_threshold", 0.78))
        draw_c = bool(self.params.get("draw_contours", True))
        draw_l = bool(self.params.get("draw_labels", True))

        contours, _ = cv2.findContours(thresh, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

        matched_shapes = []
        counts_by_type = {}
        first_x, first_y, first_area = 0.0, 0.0, 0.0

        for c in contours:
            a = cv2.contourArea(c)
            if a < min_a or a > max_a:
                continue
            p = cv2.arcLength(c, True)
            if p < 8:
                continue

            circ = (4.0 * math.pi * a) / (p * p)
            M = cv2.moments(c)
            cx = int(M["m10"] / M["m00"]) if M["m00"] != 0 else 0
            cy = int(M["m01"] / M["m00"]) if M["m00"] != 0 else 0

            approx = cv2.approxPolyDP(c, 0.035 * p, True)
            num_v = len(approx)

            x, y, w, h = cv2.boundingRect(c)
            ar = float(w) / float(h) if h > 0 else 1.0
            (enc_cx, enc_cy), enc_r = cv2.minEnclosingCircle(c)
            c_area_ratio = a / (math.pi * (enc_r ** 2)) if enc_r > 0 else 0

            stype = "polygon"
            dim_tag = f"{w}x{h}"
            if circ >= circ_th and c_area_ratio >= 0.70:
                stype = "circle"
                dim_tag = f"D={int(enc_r * 2)}px"
            elif num_v == 3:
                stype = "triangle"
                dim_tag = f"{w}x{h}px"
            elif num_v == 4:
                if 0.85 <= ar <= 1.15:
                    stype = "square"
                    dim_tag = f"{w}x{h}px"
                else:
                    stype = "rectangle"
                    dim_tag = f"{w}x{h}px"
            elif len(c) >= 5 and 0.55 <= circ < circ_th:
                stype = "ellipse"
                dim_tag = f"{w}x{h}px"
            else:
                stype = "polygon"
                dim_tag = f"{num_v} sides"

            if target != "all" and stype != target:
                continue

            matched_shapes.append((stype, (cx, cy), (x, y, w, h), a, dim_tag, c))
            counts_by_type[stype] = counts_by_type.get(stype, 0) + 1

        if matched_shapes:
            first_x = float(matched_shapes[0][1][0])
            first_y = float(matched_shapes[0][1][1])
            first_area = float(matched_shapes[0][3])

            for stype, (cx, cy), (x, y, w, h), a, dim_tag, c in matched_shapes:
                color = self.SHAPE_COLORS.get(stype, (0, 210, 255))
                if draw_c:
                    cv2.drawContours(output, [c], -1, color, 2)
                    cv2.circle(output, (cx, cy), 3, (255, 255, 255), -1)

                if draw_l:
                    lbl = f"{stype.upper()} [{dim_tag}]"
                    cv2.rectangle(output, (x, max(0, y - 20)), (x + len(lbl) * 9 + 10, y), color, -1)
                    cv2.putText(output, lbl, (x + 4, max(12, y - 5)), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (0, 0, 0), 1, cv2.LINE_AA)

        shapes_summary = ", ".join(f"{k.title()}:{v}" for k, v in counts_by_type.items()) or "None"
        cv2.putText(
            output,
            f"Shapes: {len(matched_shapes)} Found [{shapes_summary}]",
            (18, 30),
            cv2.FONT_HERSHEY_SIMPLEX,
            0.60,
            (0, 230, 118) if matched_shapes else (0, 210, 255),
            2,
            cv2.LINE_AA,
        )

        self.last_metrics = {
            "passed": len(matched_shapes) > 0,
            "count": len(matched_shapes),
            "shapes_found": counts_by_type,
            "x": first_x,
            "y": first_y,
            "area": round(first_area, 1),
        }
        return output


@register_op
class HandTrackerOp(BaseOperation):
    name = "Hand & Gesture Tracker"
    category = "Feature Detection"
    description = "Tracks human hands and landmark kinematics using MediaPipe Hands (21 landmarks) with configurable indices for cursor control, click gestures, and threshold triggers."
    param_schemas = [
        ParamSchema(
            name="cursor_index",
            label="Cursor Tracking Landmark (ID)",
            param_type=ParamType.CHOICE,
            default=8,
            choices=[
                ("Index Tip (ID: 8)", 8),
                ("Thumb Tip (ID: 4)", 4),
                ("Middle Tip (ID: 12)", 12),
                ("Ring Tip (ID: 16)", 16),
                ("Pinky Tip (ID: 20)", 20),
                ("Wrist Root (ID: 0)", 0),
                ("Palm Center Knuckle (ID: 9)", 9),
            ],
            description="Landmark index used to determine cursor position coordinates.",
        ),
        ParamSchema(
            name="enable_mouse_control",
            label="Drive OS Mouse Cursor (PyAutoGUI)",
            param_type=ParamType.BOOL,
            default=False,
            description="When enabled, moves mouse cursor and executes clicks on the OS desktop.",
        ),
        ParamSchema(
            name="click_pair",
            label="Left-Click Landmark Pair",
            param_type=ParamType.CHOICE,
            default="4,8",
            choices=[
                ("Thumb (4) + Index (8) Pinch", "4,8"),
                ("Thumb (4) + Middle (12) Pinch", "4,12"),
                ("Thumb (4) + Pinky (20) Pinch", "4,20"),
                ("Index (8) + Middle (12) Pinch", "8,12"),
            ],
            description="Pair of landmark indices whose proximity triggers a left click.",
        ),
        ParamSchema(
            name="right_click_pair",
            label="Right-Click Landmark Pair",
            param_type=ParamType.CHOICE,
            default="4,12",
            choices=[
                ("Disabled", "none"),
                ("Thumb (4) + Middle (12) Pinch", "4,12"),
                ("Thumb (4) + Pinky (20) Pinch", "4,20"),
                ("Index (8) + Middle (12) Pinch", "8,12"),
            ],
            description="Pair of landmark indices whose proximity triggers a right click.",
        ),
        ParamSchema(
            name="distance_mode",
            label="Distance Calculation Mode",
            param_type=ParamType.CHOICE,
            default="1d_vertical",
            choices=[
                ("1D Vertical Distance abs(y1 - y2)", "1d_vertical"),
                ("2D Euclidean Distance hypot(dx, dy)", "2d_euclidean"),
            ],
            description="Distance algorithm between finger landmarks (1D vertical matches reference script).",
        ),
        ParamSchema(
            name="click_threshold",
            label="Click Distance Threshold (px)",
            param_type=ParamType.INT,
            default=30,
            min_val=5,
            max_val=150,
            step=5,
            description="Distance threshold below which pinch executes a mouse click.",
        ),
        ParamSchema(
            name="move_threshold_min",
            label="Move Threshold Min (px)",
            param_type=ParamType.INT,
            default=70,
            min_val=0,
            max_val=300,
            step=10,
            description="Minimum distance between click pair to allow mouse cursor movement.",
        ),
        ParamSchema(
            name="move_threshold_max",
            label="Move Threshold Max (px)",
            param_type=ParamType.INT,
            default=200,
            min_val=50,
            max_val=600,
            step=10,
            description="Maximum distance between click pair to allow mouse cursor movement.",
        ),
        ParamSchema(
            name="offset",
            label="Mouse Screen Offset (px)",
            param_type=ParamType.INT,
            default=300,
            min_val=-1000,
            max_val=1000,
            step=25,
            description="Screen pixel coordinate offset added to mouse movements.",
        ),
        ParamSchema(
            name="flip_horizontal",
            label="Mirror Video (Flip Horizontal)",
            param_type=ParamType.BOOL,
            default=True,
            description="Flip camera frame horizontally for natural mirror interaction.",
        ),
        ParamSchema(
            name="draw_skeleton",
            label="Draw 21-Landmark Skeleton",
            param_type=ParamType.BOOL,
            default=True,
            description="Render MediaPipe standard skeletal lines and landmark nodes.",
        ),
        ParamSchema(
            name="highlight_indices",
            label="Highlight Active Landmark Circles",
            param_type=ParamType.BOOL,
            default=True,
            description="Draw yellow landmark target circles on active cursor and pinch indices.",
        ),
    ]

    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self._tracker: Optional[HandTrackerTool] = None

    def _parse_pair(self, val: Any, default: Tuple[int, int]) -> Tuple[int, int]:
        if isinstance(val, (tuple, list)) and len(val) >= 2:
            return int(val[0]), int(val[1])
        s = str(val).strip().lower()
        if s == "none" or not s:
            return (-1, -1)
        if "," in s:
            parts = s.split(",")
            try:
                return int(parts[0].strip()), int(parts[1].strip())
            except ValueError:
                pass
        return default

    def _get_tracker(self) -> HandTrackerTool:
        c_idx = int(self.params.get("cursor_index", 8))
        c_pair = self._parse_pair(self.params.get("click_pair", "4,8"), (4, 8))
        rc_pair = self._parse_pair(self.params.get("right_click_pair", "4,12"), (4, 12))
        dist_m = str(self.params.get("distance_mode", "1d_vertical"))
        c_thresh = float(self.params.get("click_threshold", 30.0))
        m_min = float(self.params.get("move_threshold_min", 70.0))
        m_max = float(self.params.get("move_threshold_max", 200.0))
        en_mouse = bool(self.params.get("enable_mouse_control", False))
        offset_val = int(self.params.get("offset", 300))

        if (
            self._tracker is None
            or self._tracker.cursor_index != c_idx
            or self._tracker.click_pair != c_pair
            or self._tracker.right_click_pair != rc_pair
            or self._tracker.distance_mode != dist_m
            or self._tracker.click_threshold != c_thresh
            or self._tracker.move_threshold_min != m_min
            or self._tracker.move_threshold_max != m_max
            or self._tracker.enable_mouse_control != en_mouse
            or self._tracker.offset != offset_val
        ):
            self._tracker = HandTrackerTool(
                static_image_mode=False,
                max_num_hands=1,
                cursor_index=c_idx,
                click_pair=c_pair,
                right_click_pair=rc_pair,
                distance_mode=dist_m,
                click_threshold=c_thresh,
                move_threshold_min=m_min,
                move_threshold_max=m_max,
                enable_mouse_control=en_mouse,
                offset=offset_val,
            )
        return self._tracker

    def process(self, image: np.ndarray) -> np.ndarray:
        bgr = ensure_bgr(image)
        tracker = self._get_tracker()
        flip_h = bool(self.params.get("flip_horizontal", True))
        draw_skel = bool(self.params.get("draw_skeleton", True))
        highlight_idx = bool(self.params.get("highlight_indices", self.params.get("highlight_index_finger", True)))

        annotated_frame, result = tracker.process(
            bgr,
            flip_horizontal=flip_h,
            draw_skeleton=draw_skel,
            highlight_index_tip=highlight_idx,
        )

        self.last_metrics = {
            "passed": result.found,
            "hand_detected": result.found,
            "hand_count": result.count,
            "fingers_count": result.primary_finger_count,
            "gesture": result.primary_gesture,
            "action": result.action,
            "distance": result.distance,
            "x": float(result.primary_palm[0]),
            "y": float(result.primary_palm[1]),
            "index_x": float(result.primary_index_tip[0]),
            "index_y": float(result.primary_index_tip[1]),
            "thumb_x": float(result.primary_thumb_tip[0]),
            "thumb_y": float(result.primary_thumb_tip[1]),
            "engine": "MediaPipe Hands",
        }
        return annotated_frame


@register_op
class OpticalCharacterRecognitionOp(BaseOperation):
    name = "Optical Character Recognition (OCR)"
    category = "Feature Detection"
    description = "Discovers, segments, and recognizes text using OpenCV DNN Text Detectors (EAST / DB ResNet) with optional polygon inpainting text removal."
    param_schemas = [
        ParamSchema(
            name="model_type",
            label="Text Detection Model",
            param_type=ParamType.CHOICE,
            default="auto",
            choices=[
                ("Auto (OpenCV DNN / Fallback)", "auto"),
                ("OpenCV EAST (Neural ResNet)", "east"),
                ("OpenCV DB (Differentiable Binarization)", "db"),
                ("All Models Ensemble (EAST + DB)", "ensemble"),
                ("Morphological Gradient Contour", "morphology"),
            ],
            description="OpenCV text detection architecture: EAST, DB, Multi-Model Ensemble, or Morphology.",
        ),
        ParamSchema(
            name="task_mode",
            label="Vision Task Mode",
            param_type=ParamType.CHOICE,
            default="detect",
            choices=[
                ("Detect & Annotate Text Polygons", "detect"),
                ("Inpaint & Remove Text (Clean Surface)", "inpaint"),
                ("Both (Annotate Text & Inpaint)", "both"),
            ],
            description="Whether to detect text or inpaint/remove text from image using OpenCV inpainting.",
        ),
        ParamSchema(
            name="conf_thresh",
            label="Confidence Threshold",
            param_type=ParamType.FLOAT,
            default=0.80,
            min_val=0.10,
            max_val=1.00,
            step=0.05,
            description="Detection confidence threshold for OpenCV EAST/DB models.",
        ),
        ParamSchema(
            name="nms_thresh",
            label="NMS Suppress Threshold",
            param_type=ParamType.FLOAT,
            default=0.40,
            min_val=0.10,
            max_val=1.00,
            step=0.05,
            description="Non-Maximum Suppression threshold for text box overlap.",
        ),
        ParamSchema(
            name="inpaint_radius",
            label="Inpainting Radius (px)",
            param_type=ParamType.INT,
            default=5,
            min_val=1,
            max_val=30,
            step=1,
            description="Neighborhood radius for OpenCV Navier-Stokes inpainting.",
        ),
        ParamSchema(
            name="inpaint_method",
            label="Inpainting Algorithm",
            param_type=ParamType.CHOICE,
            default="ns",
            choices=[
                ("Navier-Stokes (cv2.INPAINT_NS)", "ns"),
                ("Alexandru Telea (cv2.INPAINT_TELEA)", "telea"),
            ],
            description="OpenCV inpainting method for background reconstruction.",
        ),
        ParamSchema(
            name="box_color",
            label="Annotation Color",
            param_type=ParamType.CHOICE,
            default="green",
            choices=[
                ("Green (High-Vis All Models)", "green"),
                ("Cyan (EAST Classic)", "cyan"),
                ("Red (DB50 Classic)", "red"),
                ("Blue (DB18 Classic)", "blue"),
            ],
            description="Color of detected polygon boundaries and badges.",
        ),
        ParamSchema(
            name="draw_boxes",
            label="Draw Polygons / Bounding Boxes",
            param_type=ParamType.BOOL,
            default=True,
            description="Draw high-visibility polygon boundaries around detected text.",
        ),
        ParamSchema(
            name="draw_text",
            label="Draw Text Badges & HUD",
            param_type=ParamType.BOOL,
            default=True,
            description="Render detected text strings and confidence HUD over image.",
        ),
        ParamSchema(
            name="min_char_height",
            label="Min Text Block Height (px)",
            param_type=ParamType.INT,
            default=10,
            min_val=4,
            max_val=80,
            step=2,
            description="Minimum height for candidate text regions in fallback mode.",
        ),
    ]

    def __init__(self, params: Optional[Dict[str, Any]] = None):
        super().__init__(params)
        self._tool: Optional[ReadOcrMaxTool] = None

    def _get_tool(self) -> ReadOcrMaxTool:
        m_type = str(self.params.get("model_type", "auto")).lower()
        c_th = float(self.params.get("conf_thresh", 0.80))
        n_th = float(self.params.get("nms_thresh", 0.40))
        if self._tool is None or self._tool.model_type != m_type or self._tool.conf_thresh != c_th:
            self._tool = ReadOcrMaxTool(model_type=m_type, conf_thresh=c_th, nms_thresh=n_th)
        return self._tool

    def process(self, image: np.ndarray) -> np.ndarray:
        bgr = ensure_bgr(image)
        tool = self._get_tool()

        task_mode = str(self.params.get("task_mode", "detect")).lower()
        m_type = str(self.params.get("model_type", "auto")).lower()
        c_th = float(self.params.get("conf_thresh", 0.80))
        n_th = float(self.params.get("nms_thresh", 0.40))
        inpaint_r = int(self.params.get("inpaint_radius", 5))
        inpaint_m = str(self.params.get("inpaint_method", "ns")).lower()
        draw_b = bool(self.params.get("draw_boxes", True))
        draw_t = bool(self.params.get("draw_text", True))
        color_choice = str(self.params.get("box_color", "green")).lower()

        color_map = {
            "green": (0, 255, 0),
            "cyan": (0, 255, 255),
            "red": (0, 0, 255),
            "blue": (255, 0, 0),
        }
        line_color = color_map.get(color_choice, (0, 255, 0))

        should_inpaint = task_mode in ("inpaint", "both")
        result = tool.read(
            bgr,
            model=m_type,
            perform_inpaint=should_inpaint,
            inpaint_radius=inpaint_r,
            inpaint_method=inpaint_m,
        )

        if task_mode == "inpaint" and result.inpainted_image is not None:
            output = result.inpainted_image.copy()
        else:
            output = bgr.copy()

        first_x, first_y = 0.0, 0.0
        if result.boxes:
            first_x, first_y = float(result.boxes[0][0]), float(result.boxes[0][1])

        if draw_b and task_mode != "inpaint":
            if result.polygons:
                for poly in result.polygons:
                    cv2.polylines(output, [poly], isClosed=True, color=line_color, thickness=2)
            else:
                for bx, by, bw, bh in result.boxes:
                    cv2.rectangle(output, (bx, by), (bx + bw, by + bh), line_color, 2)

        if draw_t and task_mode != "inpaint":
            words = result.text.split() if result.text else []
            for idx, (bx, by, bw, bh) in enumerate(result.boxes):
                tag = words[idx] if idx < len(words) else f"TEXT #{idx+1}"
                badge_w = len(tag) * 8 + 8
                cv2.rectangle(output, (bx, max(0, by - 18)), (bx + badge_w, by), (22, 25, 29), -1)
                cv2.putText(output, tag, (bx + 4, max(12, by - 4)), cv2.FONT_HERSHEY_SIMPLEX, 0.42, line_color, 1, cv2.LINE_AA)

        hud = f"OCR [{result.model_used}]: {len(result.boxes)} Regions Discovered"
        if task_mode == "inpaint":
            hud = f"OCR Inpainted [{result.model_used}]: {len(result.boxes)} Regions Removed"
        cv2.putText(
            output,
            hud,
            (18, 30),
            cv2.FONT_HERSHEY_SIMPLEX,
            0.60,
            (0, 230, 118) if result.found else (0, 210, 255),
            2,
            cv2.LINE_AA,
        )

        self.last_metrics = {
            "passed": result.found,
            "count": len(result.boxes),
            "text": result.text,
            "confidence": result.confidence,
            "model": result.model_used,
            "x": first_x,
            "y": first_y,
        }
        return output


# ==============================================================================
# CATEGORY 7: Custom & Enhancements
# ==============================================================================

@register_op
class ClaheOp(BaseOperation):
    name = "Histogram Equalization (CLAHE)"
    category = "Custom & Enhancements"
    description = "Contrast Limited Adaptive Histogram Equalization prevents over-amplification of noise."
    param_schemas = [
        ParamSchema(
            name="clipLimit",
            label="Clip Limit",
            param_type=ParamType.FLOAT,
            default=2.0,
            min_val=0.5,
            max_val=40.0,
            step=0.5,
            description="Threshold for contrast limiting.",
        ),
        ParamSchema(
            name="tileGridSize",
            label="Tile Grid Size",
            param_type=ParamType.INT,
            default=8,
            min_val=2,
            max_val=32,
            step=1,
            description="Size of grid for histogram equalization tiles (e.g. 8x8).",
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        clip = float(self.params.get("clipLimit", 2.0))
        grid = max(2, int(self.params.get("tileGridSize", 8)))
        clahe = cv2.createCLAHE(clipLimit=clip, tileGridSize=(grid, grid))

        if image.ndim == 2:
            return clahe.apply(image)
        elif image.ndim == 3:
            # Apply to L channel in LAB color space to preserve color balance
            lab = cv2.cvtColor(image, cv2.COLOR_BGR2LAB)
            lab[:, :, 0] = clahe.apply(lab[:, :, 0])
            return cv2.cvtColor(lab, cv2.COLOR_LAB2BGR)
        return image


@register_op
class InvertImageOp(BaseOperation):
    name = "Invert Image (Bitwise NOT)"
    category = "Custom & Enhancements"
    description = "Inverts pixel values (255 - value) for negative contrast inspection."
    param_schemas = []

    def process(self, image: np.ndarray) -> np.ndarray:
        return cv2.bitwise_not(image)


@register_op
class CropRoiOp(BaseOperation):
    name = "Crop / Region of Interest (ROI)"
    category = "Contours & Calipers"
    description = "Restricts or crops the inspection region of interest (ROI) to user-defined coordinates with live interactive on-canvas drag & resize."
    param_schemas = [
        ParamSchema(
            name="x",
            label="ROI X (Left)",
            param_type=ParamType.INT,
            default=50,
            min_val=0,
            max_val=4096,
            description="Horizontal start coordinate of the inspection window in pixels."
        ),
        ParamSchema(
            name="y",
            label="ROI Y (Top)",
            param_type=ParamType.INT,
            default=50,
            min_val=0,
            max_val=4096,
            description="Vertical start coordinate of the inspection window in pixels."
        ),
        ParamSchema(
            name="width",
            label="ROI Width",
            param_type=ParamType.INT,
            default=320,
            min_val=10,
            max_val=4096,
            description="Width of the inspection window in pixels."
        ),
        ParamSchema(
            name="height",
            label="ROI Height",
            param_type=ParamType.INT,
            default=240,
            min_val=10,
            max_val=4096,
            description="Height of the inspection window in pixels."
        ),
        ParamSchema(
            name="mode",
            label="ROI Mode",
            param_type=ParamType.CHOICE,
            default="crop",
            choices=[
                ("Crop Image to ROI Box", "crop"),
                ("Mask Outside (Keep Dimensions)", "mask"),
                ("Highlight Box Only", "draw"),
            ],
            description="Crop trims the output down to the box; Mask blacks out the outside; Draw overlays the box border."
        ),
    ]

    def process(self, image: np.ndarray) -> np.ndarray:
        if image is None or image.size == 0:
            return image
        h, w = image.shape[:2]
        x = max(0, min(w - 1, int(self.params.get("x", 0))))
        y = max(0, min(h - 1, int(self.params.get("y", 0))))
        rw = max(1, min(w - x, int(self.params.get("width", 320))))
        rh = max(1, min(h - y, int(self.params.get("height", 240))))
        mode = self.params.get("mode", "crop")

        if mode == "crop":
            return image[y:y+rh, x:x+rw].copy()
        elif mode == "mask":
            out = np.zeros_like(image)
            out[y:y+rh, x:x+rw] = image[y:y+rh, x:x+rw]
            return out
        else:  # draw
            out = image.copy()
            cv2.rectangle(out, (x, y), (x + rw, y + rh), (0, 210, 255), 2)
            cv2.putText(out, f"ROI: {rw}x{rh}", (x, max(22, y - 6)), cv2.FONT_HERSHEY_SIMPLEX, 0.55, (0, 210, 255), 1, cv2.LINE_AA)
            return out
