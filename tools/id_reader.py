"""In-Sight ReadIDMax Tool: 1D and 2D barcode identification engine."""

import cv2
import numpy as np
from typing import Optional, Dict, Any, List, Tuple


class CodeResult:
    def __init__(self, found: bool, text: str, code_type: str, polygon: Optional[np.ndarray]):
        self.found = found
        self.text = text
        self.code_type = code_type
        self.polygon = polygon

    def to_dict(self) -> Dict[str, Any]:
        return {
            "found": self.found,
            "text": self.text,
            "type": self.code_type,
        }


class IDReaderTool:
    """In-Sight ReadIDMax barcode and QR reader."""

    def __init__(self):
        self.qr_detector = cv2.QRCodeDetector()
        # Fallback to OpenCV BarcodeDetector if available
        self.barcode_detector = None
        if hasattr(cv2, "barcode") and hasattr(cv2.barcode, "BarcodeDetector"):
            try:
                self.barcode_detector = cv2.barcode.BarcodeDetector()
            except Exception:
                pass

    def read(self, image: np.ndarray, roi: Optional[Tuple[int, int, int, int]] = None) -> CodeResult:
        if len(image.shape) == 3:
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        else:
            gray = image

        offset_x, offset_y = 0, 0
        if roi is not None:
            rx, ry, rw, rh = roi
            h_img, w_img = gray.shape[:2]
            rx1, ry1 = max(0, rx), max(0, ry)
            rx2, ry2 = min(w_img, rx + rw), min(h_img, ry + rh)
            patch = gray[ry1:ry2, rx1:rx2]
            offset_x, offset_y = rx1, ry1
        else:
            patch = gray

        # Step 1: Attempt QR Code
        val, points, _ = self.qr_detector.detectAndDecode(patch)
        if val and len(val) > 0 and points is not None:
            pts = points[0] + np.array([offset_x, offset_y])
            return CodeResult(True, val, "QRCode", pts)

        # Step 2: Attempt Barcode detector
        if self.barcode_detector is not None:
            try:
                res, decoded_info, decoded_type, points = self.barcode_detector.detectAndDecode(patch)
                if res and len(decoded_info) > 0 and len(decoded_info[0]) > 0:
                    pts = points[0] + np.array([offset_x, offset_y])
                    return CodeResult(True, decoded_info[0], decoded_type[0], pts)
            except Exception:
                pass

        return CodeResult(False, "", "Unknown", None)
