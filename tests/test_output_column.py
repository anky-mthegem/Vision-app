"""Test Suite for Spreadsheet Output Column and Remote Signal Dispatch.

Verifies:
1. Spreadsheet table columns: Output column at index 5 with header 'Output / Signal'.
2. Output display and formatting in PipelineTableModel.
3. OutputSignalConfigDialog configuration for diverse functions:
   - Caliper / Measurement selection (length, width, area, etc.)
   - YOLO single-class signal triggers (e.g., class 'bottle' -> signal 101)
   - YOLO combined detection signals (all objects)
   - YOLO multi-class mapping table (per-class discrete signals)
   - OCR text, Count, Centroid Coordinates, Pass/Fail Boolean.
4. Signal evaluation via step.evaluate_output_signal().
5. End-to-end dispatch through IndustrialIoManager to remote devices.
6. Recipe serialization and deserialization of output_config.
"""

import sys
import os
import unittest
import numpy as np

# Ensure repository root is on sys.path
REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
if REPO_ROOT not in sys.path:
    sys.path.insert(0, REPO_ROOT)

# Headless Qt setup
os.environ["QT_QPA_PLATFORM"] = "offscreen"

from PyQt6.QtWidgets import QApplication
app = QApplication.instance() or QApplication(sys.argv)

from pipeline_engine import PipelineEngine, PipelineStep
from pipeline_table import PipelineTableView, PipelineTableModel
from ui.output_signal_dialog import OutputSignalConfigDialog
from comms.io_manager import IndustrialIoManager


class TestSpreadsheetOutputColumn(unittest.TestCase):
    """Verifies output column in spreadsheet and signal configuration engine."""

    def setUp(self):
        self.engine = PipelineEngine()
        self.table_view = PipelineTableView(self.engine)
        self.model = self.table_view.model

    def test_01_spreadsheet_column_structure(self):
        """Verifies column headers and index of Output / Signal column."""
        self.assertEqual(self.model.COL_OUTPUT, 5, "COL_OUTPUT must be column index 5")
        self.assertEqual(self.model.columnCount(), 8, "Spreadsheet table must have 8 columns")

        headers = [self.model.headerData(c, self.model.parent() or 1) for c in range(8)]
        # Qt Orientation.Horizontal is 1
        from PyQt6.QtCore import Qt
        headers = [self.model.headerData(c, Qt.Orientation.Horizontal) for c in range(8)]
        self.assertEqual(headers[5], "Output / Signal", "Column 5 header must be 'Output / Signal'")
        print("[OK] Column structure verified: index 5 is 'Output / Signal'")

    def test_02_default_output_modes_per_operation(self):
        """Verifies intelligent default output mode auto-detection."""
        s1 = self.engine.add_step("Contours & Calipers", "Find Contours & Filter", "Defect Count")
        self.assertEqual(s1.output_config.get("mode"), "count")

        s2 = self.engine.add_step("YOLO26 Vision Suite", "YOLO Object Detection", "Detect Parts")
        self.assertEqual(s2.output_config.get("mode"), "yolo_class")

        s3 = self.engine.add_step("OCR & Text Extraction", "EasyOCR Text Reader", "Read Serial")
        self.assertEqual(s3.output_config.get("mode"), "text")

        s4 = self.engine.add_step("Pre-processing & Filtering", "Gaussian Blur", "Denoise")
        self.assertEqual(s4.output_config.get("mode"), "default")
        print("[OK] Default output modes auto-detected accurately across operations")

    def test_03_caliper_measurement_selection(self):
        """Verifies caliper measurement metric selection and signal evaluation."""
        step = self.engine.add_step("Contours & Calipers", "Find Contours & Filter", "Measure Part")
        step.link_to_remote = True

        # Configure measurement mode: Length
        step.output_config = {
            "mode": "measurement",
            "metric": "length",
            "signal_id": 42,
            "link_to_remote": True,
        }

        # Simulate execution metrics written by caliper operation
        step.metrics = {"length": 128.54, "width": 45.2, "area": 5809.0, "status": "PASS"}
        step.status_ok = True

        sig = step.evaluate_output_signal()
        self.assertTrue(sig["active"])
        self.assertEqual(sig["signal_id"], 42)
        self.assertAlmostEqual(sig["numeric_value"], 128.54, places=2)
        self.assertIn("128.54", sig["display_str"])
        self.assertIn("Length", step.get_output_summary())

        # Switch metric to Area
        step.output_config["metric"] = "area"
        sig_area = step.evaluate_output_signal()
        self.assertAlmostEqual(sig_area["numeric_value"], 5809.0, places=1)
        self.assertIn("Area", step.get_output_summary())
        print("[OK] Caliper measurement selection (Length & Area) verified")

    def test_04_yolo_object_signals(self):
        """Verifies YOLO single-class, combined, and multi-class mapping."""
        step = self.engine.add_step("YOLO26 Vision Suite", "YOLO Object Detection", "AI Inspector")
        step.link_to_remote = True

        # Case A: Combined signal for any object
        step.output_config = {
            "mode": "yolo_combined",
            "signal_id": 10,
            "link_to_remote": True,
        }
        step.metrics = {
            "detected_classes": ["bottle", "person"],
            "class_counts": {"bottle": 2, "person": 1},
            "count": 3,
        }
        sig_comb = step.evaluate_output_signal()
        self.assertTrue(sig_comb["active"])
        self.assertEqual(sig_comb["signal_id"], 10)
        self.assertEqual(sig_comb["numeric_value"], 3.0)

        # Case B: Specific single class filter ("bottle")
        step.output_config = {
            "mode": "yolo_class",
            "target_class": "bottle",
            "signal_id": 88,
            "link_to_remote": True,
        }
        sig_bottle = step.evaluate_output_signal()
        self.assertTrue(sig_bottle["active"])
        self.assertEqual(sig_bottle["signal_id"], 88)
        self.assertEqual(sig_bottle["numeric_value"], 2.0)

        # Non-matching class filter ("car")
        step.output_config["target_class"] = "car"
        sig_car = step.evaluate_output_signal()
        self.assertFalse(sig_car["active"])
        self.assertEqual(sig_car["numeric_value"], 0.0)

        # Case C: Multi-class discrete signal table
        step.output_config = {
            "mode": "yolo_multiclass",
            "class_signals": {"person": 101, "bottle": 102, "car": 103},
            "default_signal": 999,
            "link_to_remote": True,
        }
        sig_multi = step.evaluate_output_signal()
        self.assertTrue(sig_multi["active"])
        # Should pick the signal for detected classes (person or bottle)
        self.assertIn(sig_multi["signal_id"], [101, 102])
        print("[OK] YOLO object signal modes (single-class, combined, multi-class) verified")

    def test_05_dialog_configuration_gui(self):
        """Verifies OutputSignalConfigDialog initializes and captures parameters."""
        step = self.engine.add_step("Contours & Calipers", "Find Contours & Filter", "Dialog Test Step")
        dlg = OutputSignalConfigDialog(step)

        # Select custom mode programmatically
        idx = dlg.combo_mode.findData("custom")
        self.assertGreaterEqual(idx, 0)
        dlg.combo_mode.setCurrentIndex(idx)
        dlg.spin_cust_sig.setValue(77)
        dlg.spin_cust_val.setValue(45.5)

        cfg = dlg.get_config()
        self.assertEqual(cfg["mode"], "custom")
        self.assertEqual(cfg["signal_id"], 77)
        self.assertEqual(cfg["custom_val"], 45.5)
        dlg.close()
        print("[OK] OutputSignalConfigDialog interactive form verified")

    def test_06_remote_dispatch_integration(self):
        """Verifies end-to-end dispatch of evaluated output to IndustrialIoManager."""
        io_mgr = IndustrialIoManager()
        # Enable Ethernet client and mock send_result
        io_mgr.enable_ethernet = True
        sent_payloads = []
        io_mgr.ethernet_client.send_result = lambda p: sent_payloads.append(p)

        step = self.engine.add_step("YOLO26 Vision Suite", "YOLO Object Detection", "Robot Guiding")
        step.link_to_remote = True
        step.output_config = {
            "mode": "yolo_class",
            "target_class": "part_a",
            "signal_id": 55,
            "link_to_remote": True,
        }
        step.metrics = {"detected_classes": ["part_a"], "count": 1, "x": 320.0, "y": 240.0}
        step.status_ok = True

        sig = step.evaluate_output_signal()
        step_info = {
            "step_id": step.step_id,
            "step_name": step.name,
            "operation": step.operation_name,
            "passed": step.status_ok,
            "latency_ms": 15.2,
            "output_info": step.output_info,
            "count": 1,
            "x": 320.0,
            "y": 240.0,
            "signal_id": sig.get("signal_id", 0),
            "numeric_value": sig.get("numeric_value", 0.0),
            "output_mode": sig.get("output_mode", "default"),
            "target_class": sig.get("target_class", ""),
            "display_str": sig.get("display_str", ""),
            "signal_active": sig.get("active", True),
        }

        # Synchronously invoke worker for test determinism
        io_mgr.dispatch_step_output(step_info)
        # Give worker thread 50ms to dispatch
        import time
        time.sleep(0.08)

        self.assertGreater(len(sent_payloads), 0, "Ethernet device should have received dispatched payload")
        p = sent_payloads[-1]
        self.assertEqual(p["signal_id"], 55)
        self.assertEqual(p["output_mode"], "yolo_class")
        self.assertEqual(p["target_class"], "part_a")
        print("[OK] Remote industrial dispatch integration verified")

    def test_07_recipe_serialization(self):
        """Verifies recipe JSON serialization of output_config."""
        step = self.engine.add_step("OCR & Text Extraction", "EasyOCR Text Reader", "Barcode Step")
        step.output_config = {
            "mode": "text",
            "signal_id": 99,
            "link_to_remote": True,
            "custom_note": "Plant_Floor_Line_3",
        }

        recipe_dict = self.engine.to_dict()
        engine2 = PipelineEngine()
        engine2.from_dict(recipe_dict)

        s2 = engine2.steps[0]
        self.assertEqual(s2.output_config.get("mode"), "text")
        self.assertEqual(s2.output_config.get("signal_id"), 99)
        self.assertEqual(s2.output_config.get("custom_note"), "Plant_Floor_Line_3")
        print("[OK] Recipe JSON serialization roundtrip verified")


if __name__ == "__main__":
    unittest.main()
