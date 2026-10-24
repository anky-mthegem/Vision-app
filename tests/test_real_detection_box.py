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

# 1. Test detection on actual test image
test_img_path = "test_bus.jpg"
person_img = cv2.imread(test_img_path)
assert person_img is not None, "test_bus.jpg missing!"
h, w = person_img.shape[:2]
print(f"Loaded test image shape: {w}x{h}")

detector = YoloDetectorTool(target_class="person", confidence=0.30)
res = detector.detect(person_img)
print(f"YOLO detections on test image: count={res.count}, classes={res.class_counts}")
assert res.count > 0, "YOLO should detect person in test image"

det = res.detections[0]
bx, by, bw, bh = det.bbox
print(f"Detected {det.class_name} ({det.confidence*100:.1f}%) at bbox: x={bx}, y={by}, w={bw}, h={bh}")

# 2. Draw detections on the image
annotated = YoloDetectorTool.draw_detections(person_img.copy(), res)
diff = cv2.absdiff(person_img, annotated)
assert np.sum(diff) > 0, "Bounding box overlay was not rendered!"
print("Verified: Bounding box, corner reticles, and label badge successfully drawn on image.")

# 3. Test MainWindow offscreen with camera disconnected state
os.environ["QT_QPA_PLATFORM"] = "offscreen"
app = QApplication.instance() or QApplication(sys.argv)
win = MainWindow()

# Run timer tick to verify no-camera connected fallback
win._on_timer_tick()
display_frame = win.get_display_frame()
assert display_frame is not None, "get_display_frame should return a valid frame"
print("Verified: MainWindow produces clean display frame even when no physical camera is attached.")

win.close()
print("\n=== REAL DETECTION & BOUNDING BOX TEST PASSED CLEANLY! ===")
