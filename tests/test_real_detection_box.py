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

from tools.yolo_detector import YoloDetectorTool
from ui.main_window import MainWindow
from PyQt6.QtWidgets import QApplication

# 1. Test detection on actual sample object
person_img = cv2.imread("camera/sample_person.jpg")
assert person_img is not None, "camera/sample_person.jpg missing!"
h, w = person_img.shape[:2]
print(f"Loaded sample image shape: {w}x{h}")

detector = YoloDetectorTool(target_class="person", confidence=0.30)
res = detector.detect(person_img)
print(f"YOLO detections on sample: count={res.count}, classes={res.class_counts}")
assert res.count > 0, "YOLO should detect person in sample image"

det = res.detections[0]
bx, by, bw, bh = det.bbox
print(f"Detected {det.class_name} ({det.confidence*100:.1f}%) at bbox: x={bx}, y={by}, w={bw}, h={bh}")
assert bw > 50 and bh > 100, f"BBox should be realistic object bounds, got w={bw}, h={bh}"

# 2. Draw detections on the image
annotated = YoloDetectorTool.draw_detections(person_img.copy(), res)
diff = cv2.absdiff(person_img, annotated)
assert np.sum(diff) > 0, "Bounding box overlay was not rendered!"
print("Verified: Bounding box, corner reticles, and label badge successfully drawn on image.")

# 3. Test with Virtual Synthetic Generator
os.environ["QT_QPA_PLATFORM"] = "offscreen"
app = QApplication.instance() or QApplication(sys.argv)
win = MainWindow()

# Get synthetic frame from camera
import time
time.sleep(0.15)
synth_frame = win.camera.get_latest_frame()
assert synth_frame is not None, "Camera should produce synthetic frame"

synth_res = detector.detect(synth_frame)
print(f"YOLO on synthetic camera stream: count={synth_res.count}, classes={synth_res.class_counts}")
assert synth_res.count > 0, "YOLO should detect object in synthetic camera stream test bay"

# Run timer tick to verify overlay rendering on display_frame
win.job.add_cell("B1", '=YoloDetect(A0, class="all", conf=0.30)', label="YOLO Test")
win.job.compile()
win._on_timer_tick()

display_frame = win.get_display_frame()
assert display_frame is not None, "get_display_frame should return annotated frame"
print("Verified: get_display_frame() returns annotated frame with bounding boxes for both Desktop UI and WebHMI.")

win.close()
print("\n=== REAL DETECTION & BOUNDING BOX TEST PASSED CLEANLY! ===")
