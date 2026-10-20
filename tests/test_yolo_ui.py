import os
import sys
import numpy as np
import cv2

if sys.stdout.encoding != 'utf-8':
    try:
        sys.stdout.reconfigure(encoding='utf-8')
    except Exception:
        pass

# Add parent directory to sys.path
sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from tools.yolo_detector import YoloDetectorTool, COCO_CLASSES, YoloResult
from engine.spreadsheet import InspectionJob

print("=== 1. Testing YOLO Detector Tool ===")
detector = YoloDetectorTool(target_class="all", confidence=0.35)
print(f"Session loaded: {detector.session is not None}")
print(f"Total COCO classes available: {len(COCO_CLASSES)}")
assert len(COCO_CLASSES) == 80, "Expected 80 COCO classes"

# Create a test frame
img = np.full((720, 1280, 3), 40, dtype=np.uint8)
res = detector.detect(img)
print(f"Detection result on blank frame -> count: {res.count}, found: {res.found}")
assert isinstance(res, YoloResult)

print("\n=== 2. Testing Spreadsheet Integration ===")
job = InspectionJob("TestJob")
job.add_cell("A0", "=AcquireImage()")
c1 = job.add_cell("B2", '=YoloDetect(A0, class="bottle", conf=0.30)', label="YOLO Bottle")
job.compile()

stats = job.execute(img)
print("Job stats:", stats)
print("B2 cell value:", c1.value.to_dict())
assert c1.tool_instance is not None
assert c1.tool_instance.target_class == "bottle"
assert abs(c1.tool_instance.confidence - 0.30) < 1e-4

print("\n=== 3. Testing Dynamic Formula Change ===")
c1.set_formula('=YoloDetect(A0, class="person, cup", conf=0.55)')
job.compile()
stats2 = job.execute(img)
print("Updated B2 class:", c1.tool_instance.target_class, "conf:", c1.tool_instance.confidence)
assert c1.tool_instance.target_class == "person, cup"
assert abs(c1.tool_instance.confidence - 0.55) < 1e-4

print("\n=== 4. Testing PyQt6 MainWindow UI Integration (Offscreen) ===")
os.environ["QT_QPA_PLATFORM"] = "offscreen"
from PyQt6.QtWidgets import QApplication
from ui.main_window import MainWindow

app = QApplication.instance() or QApplication(sys.argv)
win = MainWindow()
print("MainWindow initialized successfully.")
print(f"Catalog tabs count: {win.catalog_tabs.count()}")
tab_titles = [win.catalog_tabs.tabText(i) for i in range(win.catalog_tabs.count())]
print("Tab titles:", tab_titles)
assert any("YOLO" in t or "AI" in t for t in tab_titles), "YOLO catalog tab missing!"

# Test slider & combo box
win.yolo_class_combo.setCurrentText("cell phone")
win.yolo_conf_slider.setValue(65)
print(f"YOLO combo current: {win.yolo_class_combo.currentText()}, slider label: {win.lbl_yolo_conf_val.text()}")
assert "65%" in win.lbl_yolo_conf_val.text()

# Test adding YOLO to job
win._on_add_yolo_clicked()
print("Cells after adding YOLO:", list(win.job.cells.keys()))
assert any("YOLO" in c.label.upper() or "YOLO" in c.formula.upper() for c in win.job.cells.values())

# Run one timer tick
win._on_timer_tick()
print("Timer tick executed without errors.")

win.close()
print("\n=== ALL TESTS PASSED SUCCESSFULLY! ===")
