"""In-Sight Caliper & Edge Tools: 1D projection, subpixel peak interpolation, FindLine and FindCircle."""

import cv2
import numpy as np
from typing import Optional, Dict, Any, List, Tuple


def subpixel_peak(y_prev: float, y_peak: float, y_next: float) -> float:
    """Parabolic interpolation for subpixel edge position (-0.5 to +0.5 offset)."""
    denom = 2.0 * (y_prev - 2.0 * y_peak + y_next)
    if abs(denom) < 1e-6:
        return 0.0
    return (y_prev - y_next) / denom


class EdgePoint:
    def __init__(self, x: float, y: float, magnitude: float, transition: str):
        self.x = x
        self.y = y
        self.magnitude = magnitude
        self.transition = transition  # "DarkToLight" or "LightToDark"


class LineResult:
    def __init__(self, found: bool, p1: Tuple[float, float], p2: Tuple[float, float], angle: float, points: List[EdgePoint]):
        self.found = found
        self.p1 = p1
        self.p2 = p2
        self.angle = angle
        self.points = points

    def to_dict(self) -> Dict[str, Any]:
        return {
            "found": self.found,
            "p1": (round(self.p1[0], 2), round(self.p1[1], 2)),
            "p2": (round(self.p2[0], 2), round(self.p2[1], 2)),
            "angle": round(self.angle, 2),
            "edge_points_count": len(self.points),
        }


class CircleResult:
    def __init__(self, found: bool, center: Tuple[float, float], radius: float, points: List[EdgePoint]):
        self.found = found
        self.center = center
        self.radius = radius
        self.points = points

    def to_dict(self) -> Dict[str, Any]:
        return {
            "found": self.found,
            "center": (round(self.center[0], 2), round(self.center[1], 2)),
            "radius": round(self.radius, 2),
            "edge_points_count": len(self.points),
        }


class CaliperTool:
    """Caliper rake tool for precision edge detection."""

    def __init__(self, threshold: float = 15.0, transition: str = "Any"):
        self.threshold = threshold
        self.transition = transition  # "Any", "DarkToLight", "LightToDark"

    def scan_line(self, gray: np.ndarray, p_start: Tuple[float, float], p_end: Tuple[float, float]) -> Optional[EdgePoint]:
        """Samples a 1D pixel profile between two points and locates the strongest subpixel edge."""
        x0, y0 = p_start
        x1, y1 = p_end
        length = int(np.hypot(x1 - x0, y1 - y0))
        if length < 3:
            return None

        # Sample points along line
        xs = np.linspace(x0, x1, length)
        ys = np.linspace(y0, y1, length)

        h, w = gray.shape[:2]
        valid_mask = (xs >= 0) & (xs < w - 1) & (ys >= 0) & (ys < h - 1)
        if np.count_nonzero(valid_mask) < 3:
            return None

        # Bilinear interpolation
        xs_val = xs[valid_mask]
        ys_val = ys[valid_mask]
        profile = cv2.remap(
            gray.astype(np.float32),
            xs_val.astype(np.float32),
            ys_val.astype(np.float32),
            cv2.INTER_LINEAR,
        ).flatten()

        # 1D derivative
        gradient = np.diff(profile)
        abs_grad = np.abs(gradient)

        peak_idx = int(np.argmax(abs_grad))
        peak_mag = abs_grad[peak_idx]

        if peak_mag < self.threshold:
            return None

        is_dark_to_light = gradient[peak_idx] > 0
        trans = "DarkToLight" if is_dark_to_light else "LightToDark"

        if self.transition != "Any" and trans != self.transition:
            return None

        # Subpixel interpolation
        sub_offset = 0.0
        if 0 < peak_idx < len(abs_grad) - 1:
            sub_offset = subpixel_peak(abs_grad[peak_idx - 1], peak_mag, abs_grad[peak_idx + 1])

        exact_idx = min(len(xs_val) - 1, max(0, peak_idx + sub_offset))
        edge_x = float(xs_val[int(exact_idx)])
        edge_y = float(ys_val[int(exact_idx)])

        return EdgePoint(edge_x, edge_y, float(peak_mag), trans)

    def find_line(
        self,
        image: np.ndarray,
        p_start: Tuple[float, float],
        p_end: Tuple[float, float],
        rake_count: int = 15,
        rake_length: float = 40.0,
    ) -> LineResult:
        """Projects perpendicular caliper rakes along a guide segment to fit an edge line."""
        if len(image.shape) == 3:
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        else:
            gray = image

        x0, y0 = p_start
        x1, y1 = p_end
        dx = x1 - x0
        dy = y1 - y0
        seg_len = np.hypot(dx, dy)
        if seg_len < 5:
            return LineResult(False, (0, 0), (0, 0), 0.0, [])

        # Unit normal vector
        nx = -dy / seg_len
        ny = dx / seg_len

        edge_points: List[EdgePoint] = []
        for i in range(rake_count):
            t = i / max(1, rake_count - 1)
            cx = x0 + t * dx
            cy = y0 + t * dy

            p_rake_start = (cx - nx * rake_length * 0.5, cy - ny * rake_length * 0.5)
            p_rake_end = (cx + nx * rake_length * 0.5, cy + ny * rake_length * 0.5)

            pt = self.scan_line(gray, p_rake_start, p_rake_end)
            if pt is not None:
                edge_points.append(pt)

        if len(edge_points) < 3:
            return LineResult(False, (0, 0), (0, 0), 0.0, edge_points)

        # Fit line using OpenCV M-estimator
        pts_arr = np.array([[pt.x, pt.y] for pt in edge_points], dtype=np.float32)
        [vx, vy, x_line, y_line] = cv2.fitLine(pts_arr, cv2.DIST_L2, 0, 0.01, 0.01).flatten()

        angle = np.degrees(np.arctan2(vy, vx))
        line_len = seg_len
        p1 = (float(x_line - vx * line_len * 0.5), float(y_line - vy * line_len * 0.5))
        p2 = (float(x_line + vx * line_len * 0.5), float(y_line + vy * line_len * 0.5))

        return LineResult(True, p1, p2, angle, edge_points)

    def find_circle(
        self,
        image: np.ndarray,
        center_estimate: Tuple[float, float],
        radius_estimate: float,
        caliper_count: int = 24,
        search_range: float = 30.0,
    ) -> CircleResult:
        """Projects radial caliper spokes outwards from center to detect circle edges and fit radius."""
        if len(image.shape) == 3:
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        else:
            gray = image

        cx, cy = center_estimate
        edge_points: List[EdgePoint] = []

        for i in range(caliper_count):
            angle = (2.0 * np.pi * i) / caliper_count
            cos_a = np.cos(angle)
            sin_a = np.sin(angle)

            r_start = max(5.0, radius_estimate - search_range * 0.5)
            r_end = radius_estimate + search_range * 0.5

            p_start = (cx + r_start * cos_a, cy + r_start * sin_a)
            p_end = (cx + r_end * cos_a, cy + r_end * sin_a)

            pt = self.scan_line(gray, p_start, p_end)
            if pt is not None:
                edge_points.append(pt)

        if len(edge_points) < 4:
            return CircleResult(False, center_estimate, radius_estimate, edge_points)

        # Fit circle using algebraic least-squares (Kasa method)
        xs = np.array([pt.x for pt in edge_points])
        ys = np.array([pt.y for pt in edge_points])

        A = np.column_stack([xs, ys, np.ones_like(xs)])
        b = xs**2 + ys**2
        c, _, _, _ = np.linalg.lstsq(A, b, rcond=None)

        fit_cx = float(c[0] / 2.0)
        fit_cy = float(c[1] / 2.0)
        fit_radius = float(np.sqrt(c[2] + fit_cx**2 + fit_cy**2))

        return CircleResult(True, (fit_cx, fit_cy), fit_radius, edge_points)
