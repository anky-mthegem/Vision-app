"""Unit tests for Visual Camera Calibration with interactive on-screen line drawing.

Tests:
1. CalibrationRulerItem geometry, distance, and angle math.
2. VisualCalibrationView interactive mouse line drawing and endpoint dragging.
3. CameraCalibrationDialog live stream handling, freeze frame, preset selection,
   scale factor computation, and pipeline recipe propagation.
"""

import os
import sys
import unittest
import numpy as np

os.environ["QT_QPA_PLATFORM"] = "offscreen"
sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from PyQt6.QtCore import Qt, QPoint, QPointF
from PyQt6.QtGui import QMouseEvent
from PyQt6.QtWidgets import QApplication

# Ensure QApplication instance exists
app = QApplication.instance()
if app is None:
    app = QApplication(sys.argv)

from ui.calibration_dialog import (
    CalibrationRulerItem,
    VisualCalibrationView,
    CameraCalibrationDialog,
    load_calibration_config,
)
from pipeline_engine import PipelineEngine, PipelineStep
import operations_catalog


class TestVisualCalibration(unittest.TestCase):
    """Test suite for interactive visual line calibration."""

    def test_ruler_item_geometry_and_angle(self):
        """Verifies geometric calculations for on-screen ruler line."""
        p1 = QPointF(100.0, 200.0)
        p2 = QPointF(500.0, 200.0)
        ruler = CalibrationRulerItem(p1, p2)

        self.assertAlmostEqual(ruler.length_px(), 400.0, places=3)
        self.assertAlmostEqual(ruler.angle_deg(), 0.0, places=3)

        # Vertical line downwards (90 degrees)
        ruler.p2 = QPointF(100.0, 500.0)
        self.assertAlmostEqual(ruler.length_px(), 300.0, places=3)
        self.assertAlmostEqual(ruler.angle_deg(), 90.0, places=3)

        # Diagonal 3-4-5 triangle line (500 px)
        ruler.p2 = QPointF(500.0, 500.0)
        self.assertAlmostEqual(ruler.length_px(), 500.0, places=3)
        self.assertAlmostEqual(ruler.angle_deg(), 36.87, places=1)

        # Calibration data update
        ruler.update_calibration_data(100.0, 0.20, "mm")
        self.assertEqual(ruler.known_dim, 100.0)
        self.assertEqual(ruler.factor, 0.20)
        self.assertEqual(ruler.unit, "mm")

    def test_visual_calibration_view_mouse_interactions(self):
        """Simulates drawing a calibration ruler line on the viewfinder canvas."""
        view = VisualCalibrationView()
        view.resize(1280, 720)
        view.resetTransform()
        frame = np.zeros((720, 1280, 3), dtype=np.uint8)
        view.set_frame(frame)
        view.resetTransform()

        signals_received = []
        view.ruler_changed.connect(lambda dist, p1, p2: signals_received.append((dist, p1, p2)))

        # 1. Simulate mouse press at (200, 300) to start drawing brand new line
        pos1 = QPoint(200, 300)
        press_ev = QMouseEvent(
            QMouseEvent.Type.MouseButtonPress,
            QPointF(pos1),
            QPointF(pos1),
            Qt.MouseButton.LeftButton,
            Qt.MouseButton.LeftButton,
            Qt.KeyboardModifier.NoModifier,
        )
        view.mousePressEvent(press_ev)
        self.assertEqual(view._drag_target, "new")

        # 2. Simulate mouse move to (700, 300) (length = 500 px)
        pos2 = QPoint(700, 300)
        move_ev = QMouseEvent(
            QMouseEvent.Type.MouseMove,
            QPointF(pos2),
            QPointF(pos2),
            Qt.MouseButton.LeftButton,
            Qt.MouseButton.LeftButton,
            Qt.KeyboardModifier.NoModifier,
        )
        view.mouseMoveEvent(move_ev)
        self.assertAlmostEqual(view.ruler.length_px(), 500.0, places=1)

        # 3. Simulate mouse release
        rel_ev = QMouseEvent(
            QMouseEvent.Type.MouseButtonRelease,
            QPointF(pos2),
            QPointF(pos2),
            Qt.MouseButton.LeftButton,
            Qt.MouseButton.NoButton,
            Qt.KeyboardModifier.NoModifier,
        )
        view.mouseReleaseEvent(rel_ev)
        self.assertIsNone(view._drag_target)
        self.assertGreater(len(signals_received), 0)
        last_dist, last_p1, last_p2 = signals_received[-1]
        self.assertAlmostEqual(last_dist, 500.0, places=1)

    def test_calibration_dialog_computation_and_pipeline_update(self):
        """Tests CameraCalibrationDialog ratio computation, presets, and recipe sync."""
        # Setup mock pipeline engine with Caliper measurement step
        engine = PipelineEngine()
        caliper_step = PipelineStep(
            step_id=1,
            name="Measure Length",
            operation_name="Industrial Caliper & Measurement",
            category="Metrology & Calipers",
            params={
                "metric_type": "Length & Feret Extents",
                "calibration_factor": 1.0,
                "unit": "px",
            },
        )
        engine.steps.append(caliper_step)

        # Synthetic camera frame callback providing a 100mm floor scale pattern
        test_frame = np.full((720, 1280, 3), 40, dtype=np.uint8)
        dialog = CameraCalibrationDialog(
            pipeline_engine=engine,
            get_frame_cb=lambda: test_frame,
        )

        try:
            # Check frame acquisition
            self.assertIsNotNone(dialog._current_frame)
            self.assertEqual(dialog._current_frame.shape, (720, 1280, 3))

            # Simulate measuring 500 pixels across a 100 mm scale
            dialog.spin_measured_px.setValue(500.0)
            dialog.spin_known_dim.setValue(100.0)
            dialog.combo_unit.setCurrentText("mm")

            dialog._compute_ratio()

            # Expected: 100 mm / 500 px = 0.20000 mm/px (5.00 px/mm)
            self.assertAlmostEqual(dialog.spin_factor.value(), 0.20000, places=5)
            self.assertIn("1 px = 0.2000 mm", dialog.lbl_factor_badge.text())
            self.assertIn("Resolution: 5.00 px / mm", dialog.lbl_res_badge.text())

            # Test Quick Presets (e.g. 150mm)
            dialog._apply_preset_dimension(150.0)
            self.assertEqual(dialog.spin_known_dim.value(), 150.0)
            # 150 mm / 500 px = 0.30000 mm/px
            self.assertAlmostEqual(dialog.spin_factor.value(), 0.30000, places=5)

            # Revert to 100mm preset
            dialog._apply_preset_dimension(100.0)
            self.assertAlmostEqual(dialog.spin_factor.value(), 0.20000, places=5)

            # Test Freeze Frame Toggle
            self.assertFalse(dialog._is_frozen)
            dialog.btn_freeze.click()
            self.assertTrue(dialog._is_frozen)
            self.assertIn("Resume Live Video", dialog.btn_freeze.text())
            self.assertIn("FROZEN", dialog.lbl_camera_badge.text())

            dialog.btn_freeze.click()
            self.assertFalse(dialog._is_frozen)
            self.assertIn("Freeze Frame", dialog.btn_freeze.text())
            self.assertIn("LIVE", dialog.lbl_camera_badge.text())

            # Test Apply & Save: propagates 0.20 mm/px to Caliper step
            emitted_results = []
            dialog.calibration_applied.connect(lambda factor, unit: emitted_results.append((factor, unit)))

            dialog._on_save_applied()

            self.assertEqual(len(emitted_results), 1)
            self.assertAlmostEqual(emitted_results[0][0], 0.20000, places=5)
            self.assertEqual(emitted_results[0][1], "mm")

            # Verify Caliper step received new factor and unit
            self.assertAlmostEqual(caliper_step.params["calibration_factor"], 0.20000, places=5)
            self.assertEqual(caliper_step.params["unit"], "mm")

        finally:
            dialog._stream_timer.stop()
            dialog.close()


if __name__ == "__main__":
    unittest.main()
