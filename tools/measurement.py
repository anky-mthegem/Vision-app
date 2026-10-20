"""In-Sight Geometry, Measurement & Coordinate Fixturing Functions."""

import numpy as np
from typing import Tuple, Dict, Any, Optional


class MeasurementTools:
    """Implements Cognex In-Sight 2D geometry and measurement spreadsheet functions."""

    @staticmethod
    def distance(x1: float, y1: float, x2: float, y2: float) -> float:
        """Cognex In-Sight Distance(X1, Y1, X2, Y2)."""
        return float(np.hypot(x2 - x1, y2 - y1))

    @staticmethod
    def angle(x1: float, y1: float, x2: float, y2: float) -> float:
        """Cognex In-Sight Angle(X1, Y1, X2, Y2) in degrees (-180 to 180)."""
        return float(np.degrees(np.arctan2(y2 - y1, x2 - x1)))

    @staticmethod
    def midpoint(x1: float, y1: float, x2: float, y2: float) -> Tuple[float, float]:
        """Cognex In-Sight MidPoint(X1, Y1, X2, Y2)."""
        return (float((x1 + x2) / 2.0), float((y1 + y2) / 2.0))

    @staticmethod
    def point_to_line_distance(px: float, py: float, lx1: float, ly1: float, lx2: float, ly2: float) -> float:
        """Perpendicular distance from point P to line (L1-L2)."""
        dx = lx2 - lx1
        dy = ly2 - ly1
        line_len = np.hypot(dx, dy)
        if line_len < 1e-6:
            return float(np.hypot(px - lx1, py - ly1))
        # Cross product magnitude / line length
        return float(abs(dy * px - dx * py + lx2 * ly1 - ly2 * lx1) / line_len)

    @staticmethod
    def line_intersection(
        l1_p1: Tuple[float, float],
        l1_p2: Tuple[float, float],
        l2_p1: Tuple[float, float],
        l2_p2: Tuple[float, float],
    ) -> Optional[Tuple[float, float]]:
        """Intersection point of two infinite lines."""
        x1, y1 = l1_p1
        x2, y2 = l1_p2
        x3, y3 = l2_p1
        x4, y4 = l2_p2

        denom = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4)
        if abs(denom) < 1e-6:
            return None  # Parallel lines

        px = ((x1 * y2 - y1 * x2) * (x3 - x4) - (x1 - x2) * (x3 * y4 - y3 * x4)) / denom
        py = ((x1 * y2 - y1 * x2) * (y3 - y4) - (y1 - y2) * (x3 * y4 - y3 * x4)) / denom
        return (float(px), float(py))

    @staticmethod
    def fixture_transform(
        pt: Tuple[float, float],
        origin_fixture: Tuple[float, float, float],  # (x, y, angle_deg)
        target_fixture: Tuple[float, float, float],
    ) -> Tuple[float, float]:
        """Transforms a point relative to a dynamic fixture (e.g. from PatMax tracking)."""
        ox, oy, o_theta = origin_fixture
        tx, ty, t_theta = target_fixture

        # Step 1: Translate to origin fixture local space
        dx = pt[0] - ox
        dy = pt[1] - oy
        rad_o = np.radians(-o_theta)
        lx = dx * np.cos(rad_o) - dy * np.sin(rad_o)
        ly = dx * np.sin(rad_o) + dy * np.cos(rad_o)

        # Step 2: Transform from local space to target fixture space
        rad_t = np.radians(t_theta)
        nx = lx * np.cos(rad_t) - ly * np.sin(rad_t) + tx
        ny = lx * np.sin(rad_t) + ly * np.cos(rad_t) + ty
        return (float(nx), float(ny))
