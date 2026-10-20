"""In-Sight Filter, Color, and Histogram Tools.

Implements ImageFilter, Binarize, ExtractColor, and Histogram tools.
"""

import cv2
import numpy as np
from typing import Optional, Dict, Any, Tuple


class HistogramResult:
    def __init__(self, mean: float, std_dev: float, min_val: int, max_val: int, peak_bin: int):
        self.mean = mean
        self.std_dev = std_dev
        self.min_val = min_val
        self.max_val = max_val
        self.peak_bin = peak_bin

    def to_dict(self) -> Dict[str, Any]:
        return {
            "mean": round(self.mean, 1),
            "std_dev": round(self.std_dev, 1),
            "min": self.min_val,
            "max": self.max_val,
            "peak_bin": self.peak_bin,
        }


class ColorResult:
    def __init__(self, pixel_count: int, percentage: float, mask: np.ndarray):
        self.pixel_count = pixel_count
        self.percentage = percentage
        self.mask = mask

    def to_dict(self) -> Dict[str, Any]:
        return {
            "pixel_count": self.pixel_count,
            "percentage": round(self.percentage, 2),
        }


class ImageFilterTool:
    """In-Sight ImageFilter operations: Gaussian, Median, Sobel, Laplacian, Morphology."""

    @staticmethod
    def filter(image: np.ndarray, filter_type: str = "Gaussian", kernel_size: int = 5) -> np.ndarray:
        k = max(3, kernel_size if kernel_size % 2 == 1 else kernel_size + 1)
        ft = filter_type.upper()

        if ft == "GAUSSIAN":
            return cv2.GaussianBlur(image, (k, k), 0)
        elif ft == "MEDIAN":
            return cv2.medianBlur(image, k)
        elif ft == "SOBEL":
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY) if len(image.shape) == 3 else image
            sx = cv2.Sobel(gray, cv2.CV_16S, 1, 0, ksize=3)
            sy = cv2.Sobel(gray, cv2.CV_16S, 0, 1, ksize=3)
            abs_x = cv2.convertScaleAbs(sx)
            abs_y = cv2.convertScaleAbs(sy)
            return cv2.addWeighted(abs_x, 0.5, abs_y, 0.5, 0)
        elif ft == "LAPLACIAN":
            gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY) if len(image.shape) == 3 else image
            lap = cv2.Laplacian(gray, cv2.CV_16S, ksize=3)
            return cv2.convertScaleAbs(lap)
        elif ft in ("OPEN", "MORPH_OPEN"):
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (k, k))
            return cv2.morphologyEx(image, cv2.MORPH_OPEN, kernel)
        elif ft in ("CLOSE", "MORPH_CLOSE"):
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (k, k))
            return cv2.morphologyEx(image, cv2.MORPH_CLOSE, kernel)
        elif ft == "DILATE":
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (k, k))
            return cv2.dilate(image, kernel, iterations=1)
        elif ft == "ERODE":
            kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (k, k))
            return cv2.erode(image, kernel, iterations=1)
        return image


class BinarizeTool:
    """In-Sight Binarize tool: Fixed, Otsu, or Adaptive thresholding."""

    @staticmethod
    def threshold(image: np.ndarray, method: str = "Otsu", threshold_val: int = 128) -> np.ndarray:
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY) if len(image.shape) == 3 else image
        m = method.upper()

        if m == "OTSU":
            _, bin_img = cv2.threshold(gray, 0, 255, cv2.THRESH_BINARY + cv2.THRESH_OTSU)
            return bin_img
        elif m == "ADAPTIVE":
            return cv2.adaptiveThreshold(gray, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C, cv2.THRESH_BINARY, 11, 2)
        else:  # FIXED
            _, bin_img = cv2.threshold(gray, threshold_val, 255, cv2.THRESH_BINARY)
            return bin_img


class HistogramTool:
    """In-Sight Histogram brightness analysis tool."""

    @staticmethod
    def analyze(image: np.ndarray, roi: Optional[Tuple[int, int, int, int]] = None) -> HistogramResult:
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY) if len(image.shape) == 3 else image
        if roi is not None:
            rx, ry, rw, rh = roi
            patch = gray[ry : ry + rh, rx : rx + rw]
        else:
            patch = gray

        mean, std_dev = cv2.meanStdDev(patch)
        min_v, max_v, _, _ = cv2.minMaxLoc(patch)
        hist = cv2.calcHist([patch], [0], None, [256], [0, 256])
        peak_bin = int(np.argmax(hist))

        return HistogramResult(
            mean=float(mean[0][0]),
            std_dev=float(std_dev[0][0]),
            min_val=int(min_v),
            max_val=int(max_v),
            peak_bin=peak_bin,
        )


class ExtractColorTool:
    """In-Sight ExtractColor tool: HSV color space thresholding (Red, Green, Blue, Yellow)."""

    COLOR_RANGES = {
        "RED": [((0, 70, 50), (10, 255, 255)), ((170, 70, 50), (180, 255, 255))],
        "GREEN": [((35, 50, 50), (85, 255, 255))],
        "BLUE": [((95, 70, 50), (135, 255, 255))],
        "YELLOW": [((18, 70, 50), (34, 255, 255))],
        "WHITE": [((0, 0, 200), (180, 40, 255))],
    }

    @staticmethod
    def extract(image: np.ndarray, target_color: str = "GREEN", roi: Optional[Tuple[int, int, int, int]] = None) -> ColorResult:
        if len(image.shape) != 3:
            return ColorResult(0, 0.0, np.zeros_like(image))

        if roi is not None:
            rx, ry, rw, rh = roi
            patch = image[ry : ry + rh, rx : rx + rw]
        else:
            patch = image

        hsv = cv2.cvtColor(patch, cv2.COLOR_BGR2HSV)
        ranges = ExtractColorTool.COLOR_RANGES.get(target_color.upper(), ExtractColorTool.COLOR_RANGES["GREEN"])

        mask = np.zeros(patch.shape[:2], dtype=np.uint8)
        for (lower, upper) in ranges:
            mask |= cv2.inRange(hsv, np.array(lower), np.array(upper))

        pixel_count = int(cv2.countNonZero(mask))
        total_pixels = patch.shape[0] * patch.shape[1]
        pct = (pixel_count / max(1, total_pixels)) * 100.0

        return ColorResult(pixel_count, pct, mask)
