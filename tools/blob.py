"""In-Sight Blob Tool: Connected components, morphological topology, and boundary metrics."""

import cv2
import numpy as np
from typing import Optional, Dict, Any, List, Tuple


class SingleBlob:
    def __init__(
        self,
        area: float,
        cx: float,
        cy: float,
        bbox: Tuple[int, int, int, int],
        perimeter: float,
        circularity: float,
        angle: float,
    ):
        self.area = area
        self.cx = cx
        self.cy = cy
        self.bbox = bbox  # (x, y, w, h)
        self.perimeter = perimeter
        self.circularity = circularity
        self.angle = angle

    def to_dict(self) -> Dict[str, Any]:
        return {
            "area": round(self.area, 1),
            "cx": round(self.cx, 2),
            "cy": round(self.cy, 2),
            "bbox": self.bbox,
            "circularity": round(self.circularity, 3),
            "angle": round(self.angle, 2),
        }


class BlobResult:
    def __init__(self, blobs: List[SingleBlob], binary_mask: np.ndarray):
        self.blobs = blobs
        self.count = len(blobs)
        self.binary_mask = binary_mask

    def to_dict(self) -> Dict[str, Any]:
        return {
            "count": self.count,
            "blobs": [b.to_dict() for b in self.blobs],
        }


class BlobTool:
    """In-Sight Blob inspection tool."""

    def __init__(
        self,
        threshold: int = 128,
        invert: bool = False,
        min_area: float = 50.0,
        max_area: float = 1000000.0,
        min_circularity: float = 0.0,
        max_circularity: float = 1.0,
    ):
        self.threshold = threshold
        self.invert = invert
        self.min_area = min_area
        self.max_area = max_area
        self.min_circularity = min_circularity
        self.max_circularity = max_circularity

    def inspect(
        self,
        image: np.ndarray,
        roi: Optional[Tuple[int, int, int, int]] = None,
    ) -> BlobResult:
        if len(image.shape) == 3:
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        else:
            gray = image.copy()

        roi_x, roi_y = 0, 0
        if roi is not None:
            rx, ry, rw, rh = roi
            h_img, w_img = gray.shape[:2]
            rx1, ry1 = max(0, rx), max(0, ry)
            rx2, ry2 = min(w_img, rx + rw), min(h_img, ry + rh)
            patch = gray[ry1:ry2, rx1:rx2]
            roi_x, roi_y = rx1, ry1
        else:
            patch = gray

        thresh_type = cv2.THRESH_BINARY_INV if self.invert else cv2.THRESH_BINARY
        _, binary = cv2.threshold(patch, self.threshold, 255, thresh_type)

        # Find external and interior contours
        contours, _ = cv2.findContours(binary, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

        filtered_blobs = []
        for c in contours:
            area = cv2.contourArea(c)
            if area < self.min_area or area > self.max_area:
                continue

            perimeter = cv2.arcLength(c, True)
            if perimeter <= 0:
                continue

            # 4 * pi * Area / Perimeter^2 (1.0 = perfect circle)
            circularity = (4.0 * np.pi * area) / (perimeter * perimeter)
            if circularity < self.min_circularity or circularity > self.max_circularity:
                continue

            # Moments
            M = cv2.moments(c)
            if M["m00"] != 0:
                cx = (M["m10"] / M["m00"]) + roi_x
                cy = (M["m01"] / M["m00"]) + roi_y
            else:
                cx, cy = float(roi_x), float(roi_y)

            # Orientation angle from central moments
            mu20 = M["mu20"]
            mu02 = M["mu02"]
            mu11 = M["mu11"]
            angle = 0.5 * np.degrees(np.arctan2(2 * mu11, mu20 - mu02)) if (mu20 - mu02) != 0 else 0.0

            x, y, w, h = cv2.boundingRect(c)
            bbox = (x + roi_x, y + roi_y, w, h)

            filtered_blobs.append(
                SingleBlob(
                    area=area,
                    cx=cx,
                    cy=cy,
                    bbox=bbox,
                    perimeter=perimeter,
                    circularity=circularity,
                    angle=angle,
                )
            )

        return BlobResult(blobs=filtered_blobs, binary_mask=binary)
