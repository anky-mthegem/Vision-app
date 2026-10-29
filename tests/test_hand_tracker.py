"""Unit and Integration Tests for HandTrackerTool & Gesture Recognition."""

import math
import unittest
import numpy as np
import cv2

from tools.hand_tracker import (
    HandTrackerTool,
    HandTrackingResult,
    classify_hand_gesture,
    ensure_model_file,
)
from pipeline_engine import PipelineEngine
from operations_catalog import HandTrackerOp


class TestHandTracker(unittest.TestCase):
    """Test suite for MediaPipe kinematics, gesture classification, and OpenCV fallback."""

    def test_ensure_model_file(self):
        """Verify model file path resolution or availability."""
        model_path = ensure_model_file()
        self.assertIsNotNone(model_path, "Model file should be resolved or downloaded")

    def test_gesture_classification_all_gestures(self):
        """Test the orientation-invariant geometric gesture classifier across standard poses."""
        wrist = (100, 300)

        def make_hand(thumb_ext=False, index_ext=False, middle_ext=False, ring_ext=False, pinky_ext=False, thumb_dir="up", pinch=False):
            pts = {0: wrist}
            # Pinky MCP at (160, 200)
            pts[17] = (160, 200)
            pts[18] = (165, 170)
            pts[19] = (170, 140)
            pts[20] = (175, 110) if pinky_ext else (160, 230)

            # Ring MCP at (140, 190)
            pts[13] = (140, 190)
            pts[14] = (140, 160)
            pts[15] = (140, 130)
            pts[16] = (140, 100) if ring_ext else (140, 230)

            # Middle MCP at (120, 185)
            pts[9] = (120, 185)
            pts[10] = (120, 150)
            pts[11] = (120, 120)
            pts[12] = (120, 90) if middle_ext else (120, 230)

            # Index MCP at (100, 190)
            pts[5] = (100, 190)
            pts[6] = (100, 155)
            pts[7] = (100, 125)
            pts[8] = (100, 95) if index_ext else (100, 230)

            # Thumb CMC at (70, 260), MCP at (60, 230), IP at (50, 200)
            pts[1] = (70, 260)
            pts[2] = (60, 230)
            pts[3] = (50, 200)
            if thumb_ext:
                if thumb_dir == "up":
                    pts[4] = (30, 160)
                else:
                    pts[4] = (30, 280)
            else:
                pts[4] = (80, 210)  # Tucked against palm

            if pinch:
                pts[4] = (98, 97)
                pts[8] = (100, 95)

            return pts

        # 1. Open Hand / Palm
        pts_open = make_hand(thumb_ext=True, index_ext=True, middle_ext=True, ring_ext=True, pinky_ext=True)
        g, cnt, _ = classify_hand_gesture(pts_open)
        self.assertEqual(g, "Open Hand / Palm")
        self.assertEqual(cnt, 5)

        # 2. Fist
        pts_fist = make_hand(thumb_ext=False, index_ext=False, middle_ext=False, ring_ext=False, pinky_ext=False)
        g, cnt, _ = classify_hand_gesture(pts_fist)
        self.assertEqual(g, "Fist")
        self.assertEqual(cnt, 0)

        # 3. Pointing / Index
        pts_point = make_hand(thumb_ext=False, index_ext=True, middle_ext=False, ring_ext=False, pinky_ext=False)
        g, cnt, _ = classify_hand_gesture(pts_point)
        self.assertEqual(g, "Pointing / Index")
        self.assertEqual(cnt, 1)

        # 4. Peace / Victory
        pts_peace = make_hand(thumb_ext=False, index_ext=True, middle_ext=True, ring_ext=False, pinky_ext=False)
        g, cnt, _ = classify_hand_gesture(pts_peace)
        self.assertEqual(g, "Peace / Victory (V-Sign)")
        self.assertEqual(cnt, 2)

        # 5. Thumbs Up
        pts_tup = make_hand(thumb_ext=True, index_ext=False, middle_ext=False, ring_ext=False, pinky_ext=False, thumb_dir="up")
        g, cnt, _ = classify_hand_gesture(pts_tup)
        self.assertEqual(g, "Thumbs Up")
        self.assertEqual(cnt, 1)

        # 6. Thumbs Down
        pts_tdown = make_hand(thumb_ext=True, index_ext=False, middle_ext=False, ring_ext=False, pinky_ext=False, thumb_dir="down")
        g, cnt, _ = classify_hand_gesture(pts_tdown)
        self.assertEqual(g, "Thumbs Down")
        self.assertEqual(cnt, 1)

        # 7. Rock On / Horns
        pts_rock = make_hand(thumb_ext=False, index_ext=True, middle_ext=False, ring_ext=False, pinky_ext=True)
        g, cnt, _ = classify_hand_gesture(pts_rock)
        self.assertEqual(g, "Rock On / Horns")
        self.assertEqual(cnt, 2)

        # 8. Call Me / Shaka
        pts_shaka = make_hand(thumb_ext=True, index_ext=False, middle_ext=False, ring_ext=False, pinky_ext=True)
        g, cnt, _ = classify_hand_gesture(pts_shaka)
        self.assertEqual(g, "Call Me / Shaka")
        self.assertEqual(cnt, 2)

        # 9. OK Sign
        pts_ok = make_hand(thumb_ext=True, index_ext=True, middle_ext=True, ring_ext=True, pinky_ext=True, pinch=True)
        g, _, _ = classify_hand_gesture(pts_ok, click_threshold=35.0)
        self.assertEqual(g, "OK Sign")

    def test_hand_tracker_process_blank(self):
        """Ensure blank frames produce clean ready states rather than freezing."""
        tracker = HandTrackerTool()
        img = np.zeros((480, 640, 3), dtype=np.uint8)
        annotated, res = tracker.process(img)
        self.assertEqual(annotated.shape, img.shape)
        self.assertFalse(res.found)
        self.assertEqual(res.primary_gesture, "None")
        self.assertIn("hand_detected", res.metrics)

    def test_opencv_fallback(self):
        """Verify the OpenCV skin-chroma fallback tracks hand-colored regions."""
        tracker = HandTrackerTool(prefer_mediapipe=False)
        self.assertTrue(tracker.use_opencv_fallback)

        # Create a synthetic skin patch (YCrCb skin color approx: BGR 140, 160, 220)
        img = np.zeros((480, 640, 3), dtype=np.uint8)
        cv2.ellipse(img, (320, 240), (70, 100), 0, 0, 360, (140, 175, 230), -1)

        annotated, res = tracker.process(img, min_hand_area=500.0)
        self.assertEqual(annotated.shape, img.shape)
        self.assertTrue(res.found)
        self.assertEqual(res.metrics.get("engine"), "OpenCV (Skin-Chroma Fallback)")
        self.assertGreater(res.primary_finger_count, 0)

    def test_pipeline_engine_operation(self):
        """Verify Hand & Gesture Tracker runs through the PipelineEngine cleanly."""
        engine = PipelineEngine()
        step = engine.add_step(
            category="Feature Detection",
            operation_name="Hand & Gesture Tracker",
            params={"click_pair": "4,8", "distance_mode": "1d_vertical"},
        )
        img = np.zeros((480, 640, 3), dtype=np.uint8)
        engine.execute(img)
        self.assertIsNotNone(step.cached_output)
        self.assertEqual(step.cached_output.shape, img.shape)
        self.assertIn("gesture", step.metrics)
        self.assertIn("fingers_count", step.metrics)
        self.assertIn("action", step.metrics)


if __name__ == "__main__":
    unittest.main()
