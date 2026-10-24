"""Automated High-Resolution Screenshot Generator for User Manual.
Renders real VisionStudio UI views, active tool pipelines, and industrial dialogs.
"""

import sys
import os

WORKSPACE_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
if WORKSPACE_DIR not in sys.path:
    sys.path.insert(0, WORKSPACE_DIR)

import time
import cv2
import numpy as np
from PyQt6.QtWidgets import QApplication
from PyQt6.QtCore import Qt
from ui.main_window import MainWindow
from ui.comms_dialog import IndustrialCommsDialog
from camera.camera_manager import CameraProtocol

def generate_screenshots():
    out_dir = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))), "user manual", "assets")
    os.makedirs(out_dir, exist_ok=True)
    
    app = QApplication.instance() or QApplication(sys.argv)
    
    win = MainWindow()
    win.resize(1440, 920)
    win.show()
    
    # Process startup events
    for _ in range(25):
        app.processEvents()
        time.sleep(0.03)
        
    # 1. Main Standby Viewport
    win.grab().save(os.path.join(out_dir, "screenshot_main_standby.png"))
    print("Saved screenshot_main_standby.png")
    
    # 2. Main Window with YOLO Object Detection
    win.job.add_cell("B2", '=YoloDetect(A0, class="all", conf=0.35)', label="YOLOv8 Object Detector", enabled=True)
    win.job.compile()
    win._selected_coord = "B2"
    win.catalog_tabs.setCurrentIndex(0) # AI tab
    
    if os.path.exists("test_bus.jpg"):
        bus_img = cv2.imread("test_bus.jpg")
        bus_resized = cv2.resize(bus_img, (640, 480))
        win.camera._last_frame = bus_resized
        
    win._on_timer_tick()
    for _ in range(20):
        app.processEvents()
        time.sleep(0.03)
        
    win.grab().save(os.path.join(out_dir, "screenshot_main_yolo.png"))
    print("Saved screenshot_main_yolo.png")
    
    # 3. Main Window with Inspection Pipeline (DAG)
    win._setup_clean_job()
    win.job.add_cell("B2", "=PatMax(A0)", label="IC Alignment", enabled=True)
    win.job.add_cell("C3", "=FindBlobs(A0, threshold=120, min_area=30)", label="Hole Inspection", enabled=True)
    win.job.add_cell("D4", "=FindCircle(A0)", label="Pin Diameter", enabled=True)
    win.job.add_cell("E5", '=If(B2.Score >= 60.0, "PASS", "FAIL")', label="Quality Gate", enabled=True)
    win.job.compile()
    win.catalog_tabs.setCurrentIndex(1) # Alignment tab
    win.camera_config.protocol = CameraProtocol.TEST_STREAM
    win.camera._last_frame = None
    
    for _ in range(35):
        app.processEvents()
        time.sleep(0.03)
        
    win.grab().save(os.path.join(out_dir, "screenshot_main_inspection_dag.png"))
    print("Saved screenshot_main_inspection_dag.png")
    
    # 4. PLC Dialog Tabs
    dialog = IndustrialCommsDialog(win.io_manager, win)
    dialog.resize(760, 580)
    dialog.show()
    app.processEvents()
    
    # Siemens
    dialog.tabs.setCurrentIndex(0)
    app.processEvents()
    dialog.grab().save(os.path.join(out_dir, "screenshot_plc_siemens.png"))
    print("Saved screenshot_plc_siemens.png")
    
    # Delta
    dialog.tabs.setCurrentIndex(1)
    app.processEvents()
    dialog.grab().save(os.path.join(out_dir, "screenshot_plc_delta.png"))
    print("Saved screenshot_plc_delta.png")
    
    # Beckhoff
    dialog.tabs.setCurrentIndex(2)
    app.processEvents()
    dialog.grab().save(os.path.join(out_dir, "screenshot_plc_beckhoff.png"))
    print("Saved screenshot_plc_beckhoff.png")
    
    # Ethernet
    dialog.tabs.setCurrentIndex(3)
    app.processEvents()
    dialog.grab().save(os.path.join(out_dir, "screenshot_plc_ethernet.png"))
    print("Saved screenshot_plc_ethernet.png")
    
    # GPIO
    dialog.tabs.setCurrentIndex(4)
    app.processEvents()
    dialog.grab().save(os.path.join(out_dir, "screenshot_plc_gpio.png"))
    print("Saved screenshot_plc_gpio.png")
    
    dialog.close()
    win.close()
    print("Screenshots captured successfully.")

if __name__ == "__main__":
    generate_screenshots()
