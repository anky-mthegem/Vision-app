"""Lightweight YOLO Object Detection Engine using ONNXRuntime & OpenCV NMS.

Features:
- Standard YOLOv8 Nano model (80 COCO classes).
- Fast CPU inference with letterbox preprocessing and vectorized post-processing.
- Filter by user-selected class(es) and confidence threshold.
"""

import os
import cv2
import numpy as np
import onnxruntime as ort
from typing import List, Dict, Any, Tuple, Optional

# Standard 80 COCO Classes
COCO_CLASSES = [
    "person", "bicycle", "car", "motorcycle", "airplane", "bus", "train", "truck", "boat",
    "traffic light", "fire hydrant", "stop sign", "parking meter", "bench", "bird", "cat",
    "dog", "horse", "sheep", "cow", "elephant", "bear", "zebra", "giraffe", "backpack",
    "umbrella", "handbag", "tie", "suitcase", "frisbee", "skis", "snowboard", "sports ball",
    "kite", "baseball bat", "baseball glove", "skateboard", "surfboard", "tennis racket",
    "bottle", "wine glass", "cup", "fork", "knife", "spoon", "bowl", "banana", "apple",
    "sandwich", "orange", "broccoli", "carrot", "hot dog", "pizza", "donut", "cake",
    "chair", "couch", "potted plant", "bed", "dining table", "toilet", "tv", "laptop",
    "mouse", "remote", "keyboard", "cell phone", "microwave", "oven", "toaster", "sink",
    "refrigerator", "book", "clock", "vase", "scissors", "teddy bear", "hair drier", "toothbrush"
]


class YoloDetection:
    def __init__(self, class_name: str, class_id: int, confidence: float, bbox: Tuple[int, int, int, int]):
        self.class_name = class_name
        self.class_id = class_id
        self.confidence = confidence
        self.bbox = bbox  # (x, y, w, h)

    def to_dict(self) -> Dict[str, Any]:
        return {
            "class": self.class_name,
            "conf": round(self.confidence * 100.0, 1),
            "bbox": self.bbox,
        }


class YoloResult:
    def __init__(self, count: int, detections: List[YoloDetection], class_counts: Dict[str, int]):
        self.count = count
        self.detections = detections
        self.class_counts = class_counts
        self.found = count > 0

    def to_dict(self) -> Dict[str, Any]:
        return {
            "count": self.count,
            "class_counts": self.class_counts,
            "objects": [d.to_dict() for d in self.detections[:10]],
        }


class YoloDetectorTool:
    """Industrial YOLO object detection tool."""

    DEFAULT_MODEL_PATH = os.path.join(
        os.path.dirname(os.path.dirname(os.path.abspath(__file__))),
        "models",
        "yolov8n.onnx",
    )

    _SHARED_SESSION: Optional[ort.InferenceSession] = None
    _SHARED_INPUT_NAME: Optional[str] = None

    def __init__(
        self,
        model_path: Optional[str] = None,
        target_class: str = "all",
        confidence: float = 0.40,
        iou_thresh: float = 0.45,
    ):
        self.model_path = model_path or self.DEFAULT_MODEL_PATH
        self.target_class = target_class.strip().lower()
        self.confidence = confidence
        self.iou_thresh = iou_thresh
        self.session: Optional[ort.InferenceSession] = None
        self.input_name: Optional[str] = None
        self._load_model()

    def _load_model(self):
        if YoloDetectorTool._SHARED_SESSION is not None:
            self.session = YoloDetectorTool._SHARED_SESSION
            self.input_name = YoloDetectorTool._SHARED_INPUT_NAME
            return

        if not os.path.exists(self.model_path):
            return

        opts = ort.SessionOptions()
        opts.graph_optimization_level = ort.GraphOptimizationLevel.ORT_ENABLE_ALL
        threads = min(4, max(1, (os.cpu_count() or 2) // 2))
        opts.intra_op_num_threads = threads
        opts.inter_op_num_threads = 1
        opts.execution_mode = ort.ExecutionMode.ORT_SEQUENTIAL
        session = ort.InferenceSession(self.model_path, opts, providers=["CPUExecutionProvider"])
        input_name = session.get_inputs()[0].name

        YoloDetectorTool._SHARED_SESSION = session
        YoloDetectorTool._SHARED_INPUT_NAME = input_name
        self.session = session
        self.input_name = input_name

    def detect(
        self,
        image: np.ndarray,
        target_class: Optional[str] = None,
        confidence: Optional[float] = None,
    ) -> YoloResult:
        if self.session is None:
            self._load_model()
            if self.session is None:
                return YoloResult(0, [], {})

        filter_class = (target_class or self.target_class).strip().lower()
        conf_threshold = confidence if confidence is not None else self.confidence

        orig_h, orig_w = image.shape[:2]

        # 1. Letterbox Preprocessing (640x640)
        blob, scale, pad_x, pad_y = self._preprocess(image)

        # 2. Run ONNX Inference
        outputs = self.session.run(None, {self.input_name: blob})[0]  # Shape: (1, 84, 8400)

        # 3. Post-process predictions
        # Output is (1, 84, 8400) -> transpose to (8400, 84)
        preds = np.transpose(outputs[0])  # (8400, 84)

        boxes = []
        confidences = []
        class_ids = []

        # The first 4 elements are cx, cy, w, h; remaining 80 are class probabilities
        scores = preds[:, 4:]  # (8400, 80)
        max_scores = np.max(scores, axis=1)  # (8400,)
        max_class_ids = np.argmax(scores, axis=1)  # (8400,)

        # Mask candidates above threshold
        mask = max_scores >= conf_threshold
        if not np.any(mask):
            return YoloResult(0, [], {})

        cand_preds = preds[mask]
        cand_scores = max_scores[mask]
        cand_cls = max_class_ids[mask]

        # Check if model outputs normalized coordinates [0.0, 1.0] vs pixel coords [0, 640]
        is_normalized = bool(np.all(cand_preds[:, :4] <= 2.0))

        # Convert letterboxed coordinates back to original image space
        for pred, score, cid in zip(cand_preds, cand_scores, cand_cls):
            c_name = COCO_CLASSES[cid] if cid < len(COCO_CLASSES) else f"class_{cid}"

            # Filter by user selected class if specified
            if filter_class not in ("all", "*", ""):
                selected_classes = [c.strip() for c in filter_class.split(",")]
                if c_name not in selected_classes and str(cid) not in selected_classes:
                    continue

            cx, cy, bw, bh = pred[:4]
            if is_normalized:
                cx *= 640.0
                cy *= 640.0
                bw *= 640.0
                bh *= 640.0

            # Rescale to original image
            x = int((cx - bw / 2.0 - pad_x) / scale)
            y = int((cy - bh / 2.0 - pad_y) / scale)
            w = int(bw / scale)
            h = int(bh / scale)

            # Clamp boundaries
            x = max(0, min(orig_w - 1, x))
            y = max(0, min(orig_h - 1, y))
            w = max(1, min(orig_w - x, w))
            h = max(1, min(orig_h - y, h))

            boxes.append([x, y, w, h])
            confidences.append(float(score))
            class_ids.append(int(cid))

        if len(boxes) == 0:
            return YoloResult(0, [], {})

        # 4. Fast OpenCV Non-Maximum Suppression (NMS)
        indices = cv2.dnn.NMSBoxes(boxes, confidences, conf_threshold, self.iou_thresh)

        final_detections = []
        class_counts = {}

        if len(indices) > 0:
            for i in indices.flatten():
                cid = class_ids[i]
                c_name = COCO_CLASSES[cid] if cid < len(COCO_CLASSES) else f"class_{cid}"
                conf = confidences[i]
                bbox = tuple(boxes[i])

                final_detections.append(YoloDetection(c_name, cid, conf, bbox))
                class_counts[c_name] = class_counts.get(c_name, 0) + 1

        return YoloResult(len(final_detections), final_detections, class_counts)

    def _preprocess(self, image: np.ndarray, input_size: int = 640) -> Tuple[np.ndarray, float, float, float]:
        """Letterbox resize maintaining aspect ratio with BGR to RGB conversion."""
        h, w = image.shape[:2]
        scale = min(input_size / h, input_size / w)
        nh, nw = int(h * scale), int(w * scale)

        # Convert OpenCV BGR to RGB for correct neural inference
        if len(image.shape) == 2:
            img_rgb = cv2.cvtColor(image, cv2.COLOR_GRAY2RGB)
        elif image.shape[2] == 3:
            img_rgb = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)
        else:
            img_rgb = image

        resized = cv2.resize(img_rgb, (nw, nh), interpolation=cv2.INTER_LINEAR)
        canvas = np.full((input_size, input_size, 3), 114, dtype=np.uint8)

        pad_x = (input_size - nw) // 2
        pad_y = (input_size - nh) // 2
        canvas[pad_y : pad_y + nh, pad_x : pad_x + nw] = resized

        # Normalize to [0.0, 1.0] and CHW format
        blob = canvas.astype(np.float32) / 255.0
        blob = np.transpose(blob, (2, 0, 1))  # (3, 640, 640)
        blob = np.expand_dims(blob, axis=0)  # (1, 3, 640, 640)
        return blob, scale, float(pad_x), float(pad_y)

    @staticmethod
    def draw_detections(img: np.ndarray, result: YoloResult) -> np.ndarray:
        """Renders high-visibility industrial bounding boxes and reticles around detected objects."""
        if not result or not result.found:
            return img

        overlay = img.copy()
        h, w = img.shape[:2]

        for det in result.detections:
            bx, by, bw, bh = det.bbox
            x1 = max(0, min(w - 1, int(bx)))
            y1 = max(0, min(h - 1, int(by)))
            x2 = max(0, min(w - 1, int(bx + bw)))
            y2 = max(0, min(h - 1, int(by + bh)))

            # Distinct vibrant color per class ID
            hue = int((det.class_id * 37) % 180)
            bgr = cv2.cvtColor(np.uint8([[[hue, 230, 255]]]), cv2.COLOR_HSV2BGR)[0][0]
            color = (int(bgr[0]), int(bgr[1]), int(bgr[2]))

            # 1. Semi-transparent highlight box
            cv2.rectangle(overlay, (x1, y1), (x2, y2), color, -1)

            # 2. Main crisp bounding box border
            cv2.rectangle(img, (x1, y1), (x2, y2), color, 2)

            # 3. High-tech corner reticle brackets (thickness 4)
            c_len = min(20, min(bw // 3, bh // 3))
            if c_len > 3:
                # Top-Left
                cv2.line(img, (x1, y1), (x1 + c_len, y1), color, 4)
                cv2.line(img, (x1, y1), (x1, y1 + c_len), color, 4)
                # Top-Right
                cv2.line(img, (x2, y1), (x2 - c_len, y1), color, 4)
                cv2.line(img, (x2, y1), (x2, y1 + c_len), color, 4)
                # Bottom-Left
                cv2.line(img, (x1, y2), (x1 + c_len, y2), color, 4)
                cv2.line(img, (x1, y2), (x1, y2 - c_len), color, 4)
                # Bottom-Right
                cv2.line(img, (x2, y2), (x2 - c_len, y2), color, 4)
                cv2.line(img, (x2, y2), (x2, y2 - c_len), color, 4)

            # 4. Center crosshair
            cx, cy = (x1 + x2) // 2, (y1 + y2) // 2
            cv2.drawMarker(img, (cx, cy), color, cv2.MARKER_CROSS, 12, 1)

            # 5. Label badge
            label = f"{det.class_name.upper()} {det.confidence*100:.0f}%"
            (tw, th), bl = cv2.getTextSize(label, cv2.FONT_HERSHEY_SIMPLEX, 0.50, 1)
            badge_y1 = max(0, y1 - th - 8)
            badge_y2 = y1 if y1 - th - 8 >= 0 else y1 + th + 8
            badge_x2 = min(w, x1 + tw + 10)

            cv2.rectangle(img, (x1, badge_y1), (badge_x2, badge_y2), color, -1)
            text_y = badge_y2 - 5 if y1 - th - 8 >= 0 else badge_y2 - 3
            cv2.putText(img, label, (x1 + 5, text_y), cv2.FONT_HERSHEY_SIMPLEX, 0.50, (0, 0, 0), 1, cv2.LINE_AA)

        # Blend semi-transparent highlight (alpha 0.12)
        cv2.addWeighted(overlay, 0.12, img, 0.88, 0, img)
        return img
