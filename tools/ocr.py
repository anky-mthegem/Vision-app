"""VisionStudio Advanced OpenCV Text Detection & OCR Tool.

Implements deep-learning scene text detection utilizing OpenCV's native DNN models:
- cv2.dnn_TextDetectionModel_EAST (Efficient and Accurate Scene Text Detector)
- cv2.dnn_TextDetectionModel_DB (Real-time Differentiable Binarization ResNet)
- Multi-model ensemble (EAST + DB combined)
- High-speed morphological gradient contour fallback
- OpenCV Text Inpainting (cv2.inpaint) for text removal and clean inspection surfaces
"""

from __future__ import annotations
import os
import re
import math
import logging
from typing import Optional, Dict, Any, List, Tuple, Union

import cv2
import numpy as np

logger = logging.getLogger("OpenCvOcrTool")


class OcrResult:
    """Encapsulates detected text bounding polygons, extracted strings, and inpainting outputs."""

    def __init__(
        self,
        found: bool,
        text: str,
        confidence: float,
        valid_field: bool,
        boxes: List[Tuple[int, int, int, int]],
        polygons: Optional[List[np.ndarray]] = None,
        inpaint_mask: Optional[np.ndarray] = None,
        inpainted_image: Optional[np.ndarray] = None,
        model_used: str = "OpenCV",
    ):
        self.found = found
        self.text = text
        self.confidence = confidence
        self.valid_field = valid_field
        self.boxes = boxes
        self.polygons = polygons or []
        self.inpaint_mask = inpaint_mask
        self.inpainted_image = inpainted_image
        self.model_used = model_used

    def to_dict(self) -> Dict[str, Any]:
        return {
            "found": self.found,
            "count": len(self.boxes),
            "text": self.text,
            "confidence": round(self.confidence, 1),
            "valid_field": self.valid_field,
            "model_used": self.model_used,
        }


class ReadOcrMaxTool:
    """Industrial OCR & Scene Text Detection Tool with OpenCV DNN models and inpainting."""

    def __init__(
        self,
        field_regex: str = r".*",
        model_type: str = "auto",  # "auto", "east", "db", "ensemble", "morphology"
        east_model_path: Optional[str] = None,
        db_model_path: Optional[str] = None,
        conf_thresh: float = 0.80,
        nms_thresh: float = 0.40,
        bin_thresh: float = 0.30,
        poly_thresh: float = 0.50,
        input_size: Tuple[int, int] = (320, 320),
    ):
        self.field_regex = field_regex
        self.model_type = model_type.lower()
        self.conf_thresh = conf_thresh
        self.nms_thresh = nms_thresh
        self.bin_thresh = bin_thresh
        self.poly_thresh = poly_thresh
        self.input_size = input_size

        # Resolve model paths
        base_dir = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
        self.east_path = east_model_path or os.path.join(base_dir, "models", "frozen_east_text_detection.pb")
        self.db_path = db_model_path or os.path.join(base_dir, "models", "text_detection_ppocr.onnx")

        self._detector_east = None
        self._detector_db = None
        self._init_models()

    def _init_models(self):
        """Initializes OpenCV native DNN text detectors if model weights are available."""
        # 1. Initialize EAST
        if os.path.exists(self.east_path) and hasattr(cv2, "dnn_TextDetectionModel_EAST"):
            try:
                detector = cv2.dnn_TextDetectionModel_EAST(self.east_path)
                detector.setConfidenceThreshold(self.conf_thresh).setNMSThreshold(self.nms_thresh)
                detector.setInputParams(1.0, self.input_size, (123.68, 116.78, 103.94), True)
                self._detector_east = detector
                logger.info(f"OpenCV EAST Text Detector initialized from {self.east_path}")
            except Exception as e:
                logger.warning(f"Could not load EAST model from {self.east_path}: {e}")
                self._detector_east = None

        # 2. Initialize DB
        if os.path.exists(self.db_path) and hasattr(cv2, "dnn_TextDetectionModel_DB"):
            try:
                detector = cv2.dnn_TextDetectionModel_DB(self.db_path)
                detector.setBinaryThreshold(self.bin_thresh).setPolygonThreshold(self.poly_thresh)
                mean = (122.67891434, 116.66876762, 104.00698793)
                detector.setInputParams(1.0 / 255.0, self.input_size, mean, True)
                self._detector_db = detector
                logger.info(f"OpenCV DB Text Detector initialized from {self.db_path}")
            except Exception as e:
                logger.warning(f"Could not load DB model from {self.db_path}: {e}")
                self._detector_db = None

    def detect_boxes(
        self,
        image: np.ndarray,
        model: Optional[str] = None,
        conf_thresh: Optional[float] = None,
        nms_thresh: Optional[float] = None,
    ) -> Tuple[List[np.ndarray], str]:
        """Detects text bounding polygons in the image.

        Returns:
            Tuple of (list_of_4_point_polygons, model_name_used)
        """
        chosen_model = (model or self.model_type).lower()
        if chosen_model == "auto":
            if self._detector_east is not None:
                chosen_model = "east"
            elif self._detector_db is not None:
                chosen_model = "db"
            else:
                chosen_model = "morphology"

        polygons: List[np.ndarray] = []
        model_name = "Morphological Gradient"

        # 1. EAST Model
        if chosen_model in ("east", "ensemble") and self._detector_east is not None:
            try:
                c_th = conf_thresh if conf_thresh is not None else self.conf_thresh
                n_th = nms_thresh if nms_thresh is not None else self.nms_thresh
                self._detector_east.setConfidenceThreshold(c_th).setNMSThreshold(n_th)
                boxes_east, _ = self._detector_east.detect(image)
                if boxes_east is not None:
                    for b in boxes_east:
                        polygons.append(np.array(b, dtype=np.int32))
                model_name = "OpenCV EAST"
            except Exception as e:
                logger.warning(f"EAST detection error: {e}")

        # 2. DB Model
        if chosen_model in ("db", "ensemble") and self._detector_db is not None:
            try:
                boxes_db, _ = self._detector_db.detect(image)
                if boxes_db is not None:
                    for b in boxes_db:
                        polygons.append(np.array(b, dtype=np.int32))
                model_name = "OpenCV DB" if chosen_model == "db" else "OpenCV Ensemble (EAST+DB)"
            except Exception as e:
                logger.warning(f"DB detection error: {e}")

        # 3. Morphological Fallback (if DNN models not selected or empty)
        if (chosen_model == "morphology" or not polygons) and chosen_model != "east" and chosen_model != "db":
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY) if len(image.shape) == 3 else image
            kernel_grad = cv2.getStructuringElement(cv2.MORPH_RECT, (3, 3))
            grad = cv2.morphologyEx(gray, cv2.MORPH_GRADIENT, kernel_grad)
            _, thresh = cv2.threshold(grad, 0, 255, cv2.THRESH_BINARY | cv2.THRESH_OTSU)
            kernel_conn = cv2.getStructuringElement(cv2.MORPH_RECT, (15, 3))
            connected = cv2.morphologyEx(thresh, cv2.MORPH_CLOSE, kernel_conn)
            contours, _ = cv2.findContours(connected, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

            h_img, w_img = image.shape[:2]
            for c in contours:
                x, y, w, h = cv2.boundingRect(c)
                if h >= 8 and w >= 12 and h < (h_img * 0.85) and w < (w_img * 0.95):
                    poly = np.array([[x, y], [x + w, y], [x + w, y + h], [x, y + h]], dtype=np.int32)
                    polygons.append(poly)
            model_name = "Morphological Gradient"

        return polygons, model_name

    def inpaint(
        self,
        image: np.ndarray,
        polygons: List[np.ndarray],
        inpaint_radius: int = 5,
        flags: int = cv2.INPAINT_NS,
    ) -> Tuple[np.ndarray, np.ndarray]:
        """Inpaints text out of the image using binary polygon masks.

        Args:
            image: Original input image
            polygons: List of text bounding polygons
            inpaint_radius: Inpaint radius in pixels
            flags: cv2.INPAINT_NS (Navier-Stokes) or cv2.INPAINT_TELEA

        Returns:
            Tuple of (inpainted_image, inpaint_mask)
        """
        inpaint_mask = np.zeros(image.shape[:2], dtype=np.uint8)
        for poly in polygons:
            cv2.fillPoly(inpaint_mask, [np.array(poly, dtype=np.int32)], 255)

        # Inpaint text regions
        if np.any(inpaint_mask):
            inpainted = cv2.inpaint(image, inpaint_mask, inpaintRadius=inpaint_radius, flags=flags)
        else:
            inpainted = image.copy()
        return inpainted, inpaint_mask

    def read(
        self,
        image: np.ndarray,
        roi: Optional[Tuple[int, int, int, int]] = None,
        model: Optional[str] = None,
        perform_inpaint: bool = False,
        inpaint_radius: int = 5,
        inpaint_method: str = "ns",
    ) -> OcrResult:
        """Runs end-to-end text detection, recognition, and optional inpainting."""
        if image is None or image.size == 0:
            return OcrResult(False, "", 0.0, False, [])

        h_img, w_img = image.shape[:2]
        ox, oy = 0, 0
        patch = image

        if roi is not None:
            rx, ry, rw, rh = roi
            rx, ry = max(0, rx), max(0, ry)
            rw, rh = min(rw, w_img - rx), min(rh, h_img - ry)
            if rw > 0 and rh > 0:
                patch = image[ry : ry + rh, rx : rx + rw]
                ox, oy = rx, ry

        # 1. Detect Text Polygons
        polygons, model_name = self.detect_boxes(patch, model=model)

        # Adjust polygons by ROI offset
        if ox > 0 or oy > 0:
            adjusted_polys = []
            for p in polygons:
                adj = p.copy()
                adj[:, 0] += ox
                adj[:, 1] += oy
                adjusted_polys.append(adj)
            polygons = adjusted_polys

        # Compute axis-aligned bounding rectangles
        boxes: List[Tuple[int, int, int, int]] = []
        for p in polygons:
            bx, by, bw, bh = cv2.boundingRect(p)
            boxes.append((bx, by, bw, bh))

        # Sort top-to-bottom, left-to-right
        boxes.sort(key=lambda b: (b[1] // 25, b[0]))

        # 2. Extract Text via PyTesseract or Fallback
        extracted_words: List[str] = []
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY) if len(image.shape) == 3 else image
        has_tess = False
        try:
            import pytesseract
            has_tess = True
        except ImportError:
            has_tess = False

        for idx, (bx, by, bw, bh) in enumerate(boxes):
            text_tag = f"TEXT_{idx+1}"
            if has_tess and bw > 10 and bh > 6:
                crop = gray[max(0, by) : min(h_img, by + bh), max(0, bx) : min(w_img, bx + bw)]
                try:
                    res_txt = pytesseract.image_to_string(crop, config="--psm 7").strip()
                    if res_txt:
                        text_tag = res_txt
                except Exception:
                    pass
            extracted_words.append(text_tag)

        combined_text = " ".join(extracted_words) if extracted_words else ""
        valid_field = bool(re.fullmatch(self.field_regex, combined_text)) if combined_text else False
        found = len(boxes) > 0

        # 3. Inpainting (if requested)
        inpainted_img = None
        inpaint_mask = None
        if perform_inpaint and polygons:
            flags = cv2.INPAINT_TELEA if inpaint_method.lower() == "telea" else cv2.INPAINT_NS
            inpainted_img, inpaint_mask = self.inpaint(image, polygons, inpaint_radius=inpaint_radius, flags=flags)

        confidence = 92.0 if "OpenCV" in model_name else 75.0
        return OcrResult(
            found=found,
            text=combined_text,
            confidence=confidence,
            valid_field=valid_field,
            boxes=boxes,
            polygons=polygons,
            inpaint_mask=inpaint_mask,
            inpainted_image=inpainted_img,
            model_used=model_name,
        )


# Standalone runner demonstrating OpenCV Text Detection Models and Inpainting
if __name__ == "__main__":
    import sys

    # Test image or camera frame
    test_path = sys.argv[1] if len(sys.argv) > 1 else "test_bus.jpg"
    if os.path.exists(test_path):
        image = cv2.imread(test_path)
    else:
        # Create synthetic test card with text
        image = np.full((400, 600, 3), 40, dtype=np.uint8)
        cv2.putText(image, "OPENCV OCR ENGINE", (50, 100), cv2.FONT_HERSHEY_SIMPLEX, 1.2, (0, 255, 255), 3)
        cv2.putText(image, "BATCH #2026-X94", (50, 180), cv2.FONT_HERSHEY_SIMPLEX, 1.0, (255, 255, 255), 2)
        cv2.putText(image, "PASS INSPECTION", (50, 260), cv2.FONT_HERSHEY_SIMPLEX, 1.0, (0, 255, 128), 2)

    image_disp = cv2.resize(image, (640, 480))
    tool = ReadOcrMaxTool()

    # Detections
    polys_east, _ = tool.detect_boxes(image_disp, model="east")
    polys_db, _ = tool.detect_boxes(image_disp, model="db")
    all_polys = polys_east + polys_db

    annotated_all = image_disp.copy()
    for p in all_polys:
        cv2.polylines(annotated_all, [p], isClosed=True, color=(0, 255, 0), thickness=2)

    annotated_east = image_disp.copy()
    for p in polys_east:
        cv2.polylines(annotated_east, [p], isClosed=True, color=(0, 255, 255), thickness=2)

    annotated_db = image_disp.copy()
    for p in polys_db:
        cv2.polylines(annotated_db, [p], isClosed=True, color=(255, 0, 0), thickness=2)

    # Inpainting
    inpainted_all, _ = tool.inpaint(image_disp, all_polys, inpaint_radius=5)
    inpainted_east, _ = tool.inpaint(image_disp, polys_east, inpaint_radius=5)
    inpainted_db, _ = tool.inpaint(image_disp, polys_db, inpaint_radius=5)

    cv2.imshow("Original", image_disp)
    cv2.imshow("Annotated (All Models)", annotated_all)
    cv2.imshow("Inpainted (All Models)", inpainted_all)
    cv2.imshow("Annotated (EAST Only)", annotated_east)
    cv2.imshow("Inpainted (EAST Only)", inpainted_east)
    cv2.imshow("Annotated (DB Only)", annotated_db)
    cv2.imshow("Inpainted (DB Only)", inpainted_db)

    print("OpenCV Text Detection & Inpainting Display Active.")
    print("Press any key in OpenCV window to close.")
    cv2.waitKey(0)
    cv2.destroyAllWindows()
