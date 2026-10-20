"""In-Sight DetectFlaw Tool: Golden reference comparison and surface defect detection."""

import cv2
import numpy as np
from typing import Optional, Dict, Any, List, Tuple


class FlawResult:
    def __init__(self, passed: bool, defect_score: float, flaw_count: int, flaw_boxes: List[Tuple[int, int, int, int]]):
        self.passed = passed
        self.defect_score = defect_score
        self.flaw_count = flaw_count
        self.flaw_boxes = flaw_boxes

    def to_dict(self) -> Dict[str, Any]:
        return {
            "passed": self.passed,
            "defect_score": round(self.defect_score, 2),
            "flaw_count": self.flaw_count,
            "flaw_boxes": self.flaw_boxes,
        }


class FlawDetectorTool:
    """In-Sight DetectFlaw surface defect detection tool."""

    def __init__(self, sensitivity: int = 35, min_flaw_area: int = 15, max_allowable_score: float = 10.0):
        self.sensitivity = sensitivity
        self.min_flaw_area = min_flaw_area
        self.max_allowable_score = max_allowable_score
        self.golden_reference: Optional[np.ndarray] = None

    def set_golden_reference(self, image: np.ndarray, roi: Optional[Tuple[int, int, int, int]] = None):
        """Learns baseline golden part."""
        if len(image.shape) == 3:
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        else:
            gray = image.copy()

        if roi is not None:
            rx, ry, rw, rh = roi
            self.golden_reference = gray[ry : ry + rh, rx : rx + rw]
        else:
            self.golden_reference = gray

    def inspect(self, image: np.ndarray, roi: Optional[Tuple[int, int, int, int]] = None) -> FlawResult:
        if self.golden_reference is None:
            return FlawResult(True, 0.0, 0, [])

        if len(image.shape) == 3:
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        else:
            gray = image

        offset_x, offset_y = 0, 0
        if roi is not None:
            rx, ry, rw, rh = roi
            patch = gray[ry : ry + rh, rx : rx + rw]
            offset_x, offset_y = rx, ry
        else:
            patch = gray

        # Resize patch to match reference if slight dimension difference
        ref_h, ref_w = self.golden_reference.shape[:2]
        if patch.shape[:2] != (ref_h, ref_w):
            patch = cv2.resize(patch, (ref_w, ref_h))

        # Absolute difference
        diff = cv2.absdiff(self.golden_reference, patch)
        _, thresh = cv2.threshold(diff, self.sensitivity, 255, cv2.THRESH_BINARY)

        # Morphological opening to eliminate sensor noise
        kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (3, 3))
        cleaned = cv2.morphologyEx(thresh, cv2.MORPH_OPEN, kernel)

        contours, _ = cv2.findContours(cleaned, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

        flaw_boxes = []
        total_defect_area = 0.0

        for c in contours:
            area = cv2.contourArea(c)
            if area >= self.min_flaw_area:
                x, y, w, h = cv2.boundingRect(c)
                flaw_boxes.append((x + offset_x, y + offset_y, w, h))
                total_defect_area += area

        defect_score = (total_defect_area / (ref_w * ref_h)) * 100.0
        passed = defect_score <= self.max_allowable_score

        return FlawResult(passed, defect_score, len(flaw_boxes), flaw_boxes)
