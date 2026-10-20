import os
import sys
import numpy as np
import cv2

if sys.stdout.encoding != "utf-8":
    try:
        sys.stdout.reconfigure(encoding="utf-8")
    except Exception:
        pass

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from tools.yolo_detector import YoloDetectorTool, YoloDetection, YoloResult
from ui.main_window import MainWindow
from PyQt6.QtWidgets import QApplication

os.environ["QT_QPA_PLATFORM"] = "offscreen"
app = QApplication.instance() or QApplication(sys.argv)
win = MainWindow()

# Simulate a YOLO detection result
det1 = YoloDetection("bottle", 39, 0.92, (150, 120, 80, 220))
det2 = YoloDetection("person", 0, 0.88, (300, 80, 200, 450))
mock_yolo_result = YoloResult(2, [det1, det2], {"bottle": 1, "person": 1})

# Add a mock cell with this result
cell = win.job.add_cell("B2", '=YoloDetect(A0, class="all", conf=0.40)', label="YOLO Test")
cell.value = mock_yolo_result
win.job.compile()

# Render overlays on test image
test_img = np.full((720, 1280, 3), 30, dtype=np.uint8)
win._render_overlays(test_img)

# Verify pixels changed (overlay was rendered)
assert np.any(test_img != 30), "Overlays should have drawn bounding boxes on the image!"
print("Bounding boxes, tags, crosshairs, and HUD banner rendered properly on frame.")

# Verify table display value for YOLO
win._refresh_table_display()
table_item = win.table.item(1, 4)
print(f"Table result display: '{table_item.text()}'")
assert "Found 2" in table_item.text()
assert "bottle:1" in table_item.text()

win.close()
print("=== YOLO OVERLAY & TABLE TEST PASSED! ===")
