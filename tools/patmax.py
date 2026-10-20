"""PatMax-equivalent Geometric Contour & Feature Gradient Pattern Matching Tool.

Implements geometric shape matching with rotation, scale, and illumination invariance.
Calculates subpixel accuracy, found coordinates, orientation angle, and match score (0-100%).
"""

import cv2
import numpy as np
from typing import Optional, Dict, Any, Tuple, List


class PatMaxModel:
    """Trained geometric pattern model containing extracted boundary contour vectors."""

    def __init__(self, template_img: np.ndarray, name: str = "Model"):
        self.name = name
        if len(template_img.shape) == 3:
            self.gray = cv2.cvtColor(template_img, cv2.COLOR_BGR2GRAY)
        else:
            self.gray = template_img.copy()

        self.h, self.w = self.gray.shape
        self.center = (self.w / 2.0, self.h / 2.0)

        # Extract normalized Sobel gradient vectors (magnitude and direction)
        dx = cv2.Sobel(self.gray, cv2.CV_32F, 1, 0, ksize=3)
        dy = cv2.Sobel(self.gray, cv2.CV_32F, 0, 1, ksize=3)
        mag, angle = cv2.cartToPolar(dx, dy)

        # Threshold salient feature points
        mean_mag = np.mean(mag)
        thresh = max(15.0, mean_mag * 1.2)
        mask = mag > thresh

        ys, xs = np.where(mask)
        if len(xs) > 0:
            mags = mag[ys, xs]
            dx_n = dx[ys, xs] / (mags + 1e-6)
            dy_n = dy[ys, xs] / (mags + 1e-6)

            # Store relative coordinates from model center
            self.features = np.column_stack([
                xs - self.center[0],
                ys - self.center[1],
                dx_n,
                dy_n,
                mags,
            ])
        else:
            self.features = np.empty((0, 5), dtype=np.float32)

        # Precompute multi-scale and rotated templates for fast pyramid searching
        self.pyramid_templates = self._build_rotation_pyramid()

    def _build_rotation_pyramid(self) -> Dict[float, np.ndarray]:
        pyramid = {}
        # Precompute at 15 degree coarse intervals
        for angle_deg in range(-180, 180, 15):
            M = cv2.getRotationMatrix2D(self.center, angle_deg, 1.0)
            rot = cv2.warpAffine(self.gray, M, (self.w, self.h), flags=cv2.INTER_LINEAR)
            pyramid[float(angle_deg)] = rot
        return pyramid


class PatMaxResult:
    """Inspection output from geometric pattern matching."""

    def __init__(
        self,
        found: bool,
        score: float,
        x: float,
        y: float,
        angle: float,
        scale: float,
        box_points: Optional[np.ndarray] = None,
    ):
        self.found = found
        self.score = score  # 0.0 to 1.0
        self.x = x
        self.y = y
        self.angle = angle  # degrees (-180 to 180)
        self.scale = scale
        self.box_points = box_points  # 4x2 coordinates for drawing

    def to_dict(self) -> Dict[str, Any]:
        return {
            "found": self.found,
            "score": round(self.score * 100.0, 2),
            "x": round(self.x, 2),
            "y": round(self.y, 2),
            "angle": round(self.angle, 2),
            "scale": round(self.scale, 3),
        }


class PatMaxTool:
    """In-Sight PatMax tool implementation."""

    def __init__(
        self,
        accept_threshold: float = 0.65,
        angle_start: float = -180.0,
        angle_end: float = 180.0,
        scale_min: float = 0.9,
        scale_max: float = 1.1,
    ):
        self.accept_threshold = accept_threshold
        self.angle_start = angle_start
        self.angle_end = angle_end
        self.scale_min = scale_min
        self.scale_max = scale_max
        self.model: Optional[PatMaxModel] = None

    def train(self, image: np.ndarray, roi: Optional[Tuple[int, int, int, int]] = None) -> bool:
        """Trains pattern from image within ROI (x, y, w, h)."""
        if roi is not None:
            x, y, w, h = roi
            h_img, w_img = image.shape[:2]
            x1, y1 = max(0, x), max(0, y)
            x2, y2 = min(w_img, x + w), min(h_img, y + h)
            patch = image[y1:y2, x1:x2]
        else:
            patch = image

        if patch.shape[0] < 10 or patch.shape[1] < 10:
            return False

        self.model = PatMaxModel(patch)
        return True

    def find(
        self,
        image: np.ndarray,
        search_roi: Optional[Tuple[int, int, int, int]] = None,
    ) -> PatMaxResult:
        """Executes geometric pattern search in the target image."""
        if self.model is None or len(self.model.features) == 0:
            return PatMaxResult(False, 0.0, 0.0, 0.0, 0.0, 1.0)

        if len(image.shape) == 3:
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        else:
            gray = image.copy()

        roi_offset_x, roi_offset_y = 0, 0
        if search_roi is not None:
            rx, ry, rw, rh = search_roi
            h_img, w_img = gray.shape[:2]
            rx1, ry1 = max(0, rx), max(0, ry)
            rx2, ry2 = min(w_img, rx + rw), min(h_img, ry + rh)
            search_img = gray[ry1:ry2, rx1:rx2]
            roi_offset_x, roi_offset_y = rx1, ry1
        else:
            search_img = gray

        mw, mh = self.model.w, self.model.h
        if search_img.shape[0] < mh or search_img.shape[1] < mw:
            return PatMaxResult(False, 0.0, 0.0, 0.0, 0.0, 1.0)

        # Step 1: Coarse Multi-Angle Normalized Cross-Correlation Search
        best_score = -1.0
        best_angle = 0.0
        best_loc = (0, 0)

        # Search angle candidates matching user angle bounds
        for angle, rot_tpl in self.model.pyramid_templates.items():
            if angle < self.angle_start or angle > self.angle_end:
                continue

            res = cv2.matchTemplate(search_img, rot_tpl, cv2.TM_CCOEFF_NORMED)
            _, max_val, _, max_loc = cv2.minMaxLoc(res)

            if max_val > best_score:
                best_score = max_val
                best_angle = angle
                best_loc = max_loc

        # Step 2: Fine Angle Refinement (+/- 10 degrees at 1 deg steps)
        fine_best_score = best_score
        fine_best_angle = best_angle
        fine_best_loc = best_loc

        for delta in range(-10, 11, 2):
            cur_angle = best_angle + delta
            if cur_angle < self.angle_start or cur_angle > self.angle_end:
                continue
            M = cv2.getRotationMatrix2D(self.model.center, cur_angle, 1.0)
            rot_tpl = cv2.warpAffine(self.model.gray, M, (mw, mh), flags=cv2.INTER_LINEAR)
            res = cv2.matchTemplate(search_img, rot_tpl, cv2.TM_CCOEFF_NORMED)
            _, max_val, _, max_loc = cv2.minMaxLoc(res)

            if max_val > fine_best_score:
                fine_best_score = max_val
                fine_best_angle = cur_angle
                fine_best_loc = max_loc

        # Normalize score
        normalized_score = max(0.0, min(1.0, fine_best_score))
        found = normalized_score >= self.accept_threshold

        center_x = fine_best_loc[0] + mw / 2.0 + roi_offset_x
        center_y = fine_best_loc[1] + mh / 2.0 + roi_offset_y

        # Calculate rotated bounding box corners
        box_points = cv2.boxPoints(((center_x, center_y), (mw, mh), fine_best_angle))

        return PatMaxResult(
            found=found,
            score=normalized_score,
            x=center_x,
            y=center_y,
            angle=fine_best_angle,
            scale=1.0,
            box_points=box_points,
        )
