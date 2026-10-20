"""In-Sight Caliper Width & EdgeCount Measurement Tools.

Measures edge-pair width/gap and counts dark-to-light/light-to-dark transitions.
"""

import cv2
import numpy as np
from typing import Optional, Dict, Any, List, Tuple
from tools.edge import CaliperTool, EdgePoint


class CaliperWidthResult:
    def __init__(self, found: bool, width: float, center: Tuple[float, float], edge1: Optional[EdgePoint], edge2: Optional[EdgePoint]):
        self.found = found
        self.width = width
        self.center = center
        self.edge1 = edge1
        self.edge2 = edge2

    def to_dict(self) -> Dict[str, Any]:
        return {
            "found": self.found,
            "width": round(self.width, 2),
            "center": (round(self.center[0], 2), round(self.center[1], 2)),
        }


class EdgeCountResult:
    def __init__(self, count: int, edge_points: List[EdgePoint]):
        self.count = count
        self.edge_points = edge_points

    def to_dict(self) -> Dict[str, Any]:
        return {
            "count": self.count,
        }


class CaliperWidthTool:
    """In-Sight Caliper width measurement between edge pairs."""

    def __init__(self, threshold: float = 15.0):
        self.caliper = CaliperTool(threshold=threshold)

    def measure_width(self, image: np.ndarray, p_start: Tuple[float, float], p_end: Tuple[float, float]) -> CaliperWidthResult:
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY) if len(image.shape) == 3 else image
        x0, y0 = p_start
        x1, y1 = p_end
        length = int(np.hypot(x1 - x0, y1 - y0))
        if length < 5:
            return CaliperWidthResult(False, 0.0, (0, 0), None, None)

        xs = np.linspace(x0, x1, length)
        ys = np.linspace(y0, y1, length)

        h, w = gray.shape[:2]
        valid_mask = (xs >= 0) & (xs < w - 1) & (ys >= 0) & (ys < h - 1)
        if np.count_nonzero(valid_mask) < 5:
            return CaliperWidthResult(False, 0.0, (0, 0), None, None)

        xs_val = xs[valid_mask]
        ys_val = ys[valid_mask]
        profile = cv2.remap(
            gray.astype(np.float32),
            xs_val.astype(np.float32),
            ys_val.astype(np.float32),
            cv2.INTER_LINEAR,
        ).flatten()

        grad = np.diff(profile)
        # Find positive peak (edge 1) and negative peak (edge 2)
        pos_idx = int(np.argmax(grad))
        neg_idx = int(np.argmin(grad))

        if abs(grad[pos_idx]) < self.caliper.threshold or abs(grad[neg_idx]) < self.caliper.threshold:
            return CaliperWidthResult(False, 0.0, (0, 0), None, None)

        pt1 = EdgePoint(float(xs_val[pos_idx]), float(ys_val[pos_idx]), float(grad[pos_idx]), "DarkToLight")
        pt2 = EdgePoint(float(xs_val[neg_idx]), float(ys_val[neg_idx]), float(abs(grad[neg_idx])), "LightToDark")

        width = float(np.hypot(pt2.x - pt1.x, pt2.y - pt1.y))
        cx = (pt1.x + pt2.x) / 2.0
        cy = (pt1.y + pt2.y) / 2.0

        return CaliperWidthResult(True, width, (cx, cy), pt1, pt2)


class EdgeCountTool:
    """In-Sight EdgeCount tool: counts transitions along a line."""

    def __init__(self, threshold: float = 15.0):
        self.threshold = threshold

    def count_edges(self, image: np.ndarray, p_start: Tuple[float, float], p_end: Tuple[float, float]) -> EdgeCountResult:
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY) if len(image.shape) == 3 else image
        x0, y0 = p_start
        x1, y1 = p_end
        length = int(np.hypot(x1 - x0, y1 - y0))
        if length < 5:
            return EdgeCountResult(0, [])

        xs = np.linspace(x0, x1, length)
        ys = np.linspace(y0, y1, length)

        h, w = gray.shape[:2]
        valid_mask = (xs >= 0) & (xs < w - 1) & (ys >= 0) & (ys < h - 1)
        if np.count_nonzero(valid_mask) < 5:
            return EdgeCountResult(0, [])

        profile = cv2.remap(
            gray.astype(np.float32),
            xs[valid_mask].astype(np.float32),
            ys[valid_mask].astype(np.float32),
            cv2.INTER_LINEAR,
        ).flatten()

        grad = np.diff(profile)
        peaks = []
        for i in range(1, len(grad) - 1):
            if abs(grad[i]) >= self.threshold and abs(grad[i]) > abs(grad[i - 1]) and abs(grad[i]) > abs(grad[i + 1]):
                px = float(xs[valid_mask][i])
                py = float(ys[valid_mask][i])
                trans = "DarkToLight" if grad[i] > 0 else "LightToDark"
                peaks.append(EdgePoint(px, py, float(abs(grad[i])), trans))

        return EdgeCountResult(len(peaks), peaks)
