"""Automated High-Resolution Screenshot Generator for VisionStudio User Manual.
Captures real VisionStudio UI views, Three-Pane Layout, Interactive ROI Gizmo,
Split Viewport & Heatmap, YOLO26 Deep Learning, Calibration, and Industrial Comms.
"""

import sys
import os
import time

WORKSPACE_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
if WORKSPACE_DIR not in sys.path:
    sys.path.insert(0, WORKSPACE_DIR)

import cv2
import numpy as np
from PyQt6.QtWidgets import QApplication
from PyQt6.QtCore import Qt, QRectF
from PyQt6.QtGui import QFont

from main import MainWindow
from camera.camera_manager import CameraProtocol, CameraConfig, CameraDevice
from ui.startup_banner import VisionStudioBanner
from ui.calibration_dialog import CameraCalibrationDialog
from ui.comms_dialog import IndustrialCommsDialog


def generate_all_screenshots():
    out_dir = os.path.join(WORKSPACE_DIR, "user manual", "assets")
    os.makedirs(out_dir, exist_ok=True)

    app = QApplication.instance() or QApplication(sys.argv)
    app.setFont(QFont("Segoe UI", 9))

    print(f"[*] Generating manual screenshots into: {out_dir}")

    # =========================================================================
    # 1. Startup Banner Splash
    # =========================================================================
    banner = VisionStudioBanner()
    banner.resize(440, 270)
    banner.show()
    for _ in range(15):
        app.processEvents()
        time.sleep(0.02)
    banner_path = os.path.join(out_dir, "screenshot_startup_banner.png")
    banner.grab().save(banner_path)
    print("  -> Saved screenshot_startup_banner.png")
    banner.close()

    # =========================================================================
    # 2. Main Window in Clean Standby Mode
    # =========================================================================
    win = MainWindow()
    win.resize(1520, 920)
    win.show()

    for _ in range(25):
        app.processEvents()
        time.sleep(0.02)

    standby_path = os.path.join(out_dir, "screenshot_main_standby.png")
    win.grab().save(standby_path)
    print("  -> Saved screenshot_main_standby.png")

    # =========================================================================
    # 3. Main Window with Active Defect Inspection Pipeline
    # =========================================================================
    # Connect to Virtual Synthetic Generator (moving PCB with fiducials & defects)
    idx_proto = win.combo_protocol.findData(CameraProtocol.TEST_STREAM)
    if idx_proto >= 0:
        win.combo_protocol.setCurrentIndex(idx_proto)
    if not win.camera._running:
        win._toggle_camera_connection()

    # Apply standard defect recipe
    idx_preset = win.combo_presets.findData("edges")
    if idx_preset >= 0:
        win.combo_presets.setCurrentIndex(idx_preset)

    for _ in range(40):
        app.processEvents()
        time.sleep(0.03)

    # Select defect inspection step so it is highlighted and shown in Viewport A
    if len(win.engine.steps) >= 4:
        win.table_view.table.selectRow(3)
        win._on_step_selected(win.engine.steps[3])
        win.viewport.set_viewport_a_source(win.engine.steps[3].step_id)

    for _ in range(20):
        app.processEvents()
        time.sleep(0.03)

    dag_path = os.path.join(out_dir, "screenshot_main_inspection_dag.png")
    win.grab().save(dag_path)
    print("  -> Saved screenshot_main_inspection_dag.png")

    # =========================================================================
    # 4. Interactive On-Canvas ROI Handles Gizmo
    # =========================================================================
    idx_roi = win.combo_presets.findData("roi")
    if idx_roi >= 0:
        win.combo_presets.setCurrentIndex(idx_roi)

    # Set custom ROI coordinates and activate
    win.viewport.set_roi_rect(120, 90, 560, 400, emit_signal=True)
    win.viewport.set_roi_active(True)

    for _ in range(30):
        app.processEvents()
        time.sleep(0.03)

    roi_path = os.path.join(out_dir, "screenshot_interactive_roi.png")
    win.grab().save(roi_path)
    print("  -> Saved screenshot_interactive_roi.png")

    # =========================================================================
    # 5. Dual Split Viewport & Difference Heatmap Mode
    # =========================================================================
    # Switch to split view and difference mode
    win.viewport.set_view_mode(True)
    win.viewport.set_viewport_a_source(0)  # Raw Camera
    if win.engine.steps:
        win.viewport.set_viewport_b_source(win.engine.steps[-1].step_id)

    win.viewport.btn_diff.setChecked(True)
    win.viewport._on_diff_toggle(True)

    for _ in range(30):
        app.processEvents()
        time.sleep(0.03)

    split_path = os.path.join(out_dir, "screenshot_split_diff_viewport.png")
    win.grab().save(split_path)
    print("  -> Saved screenshot_split_diff_viewport.png")

    # Reset split view for next shots
    win.viewport.btn_diff.setChecked(False)
    win.viewport._on_diff_toggle(False)
    win.viewport.set_view_mode(False)
    win.viewport.set_roi_active(False)

    # =========================================================================
    # 6. YOLO26 Deep Learning Detection Mode
    # =========================================================================
    # Switch to file loop with test_bus.jpg if available
    bus_path = os.path.join(WORKSPACE_DIR, "test_bus.jpg")
    if os.path.exists(bus_path):
        idx_file = win.combo_protocol.findData(CameraProtocol.FILE_LOOP)
        if idx_file >= 0:
            win.combo_protocol.setCurrentIndex(idx_file)
            win.edit_source.setText(bus_path)
            # Reconnect camera to switch to file loop
            if win.camera._running:
                win._toggle_camera_connection()
                win._toggle_camera_connection()

    idx_yolo = win.combo_presets.findData("yolo")
    if idx_yolo >= 0:
        win.combo_presets.setCurrentIndex(idx_yolo)

    for _ in range(40):
        app.processEvents()
        time.sleep(0.04)

    yolo_path = os.path.join(out_dir, "screenshot_main_yolo.png")
    win.grab().save(yolo_path)
    print("  -> Saved screenshot_main_yolo.png")

    # =========================================================================
    # 7. Camera Optical Calibration Dialog
    # =========================================================================
    calib_dialog = CameraCalibrationDialog(parent=win, pipeline_engine=win.engine)
    calib_dialog.resize(880, 680)
    calib_dialog.show()
    for _ in range(20):
        app.processEvents()
        time.sleep(0.02)

    calib_path = os.path.join(out_dir, "screenshot_calibration_dialog.png")
    calib_dialog.grab().save(calib_path)
    print("  -> Saved screenshot_calibration_dialog.png")
    calib_dialog.close()

    # =========================================================================
    # 8. Industrial Comms & Fieldbus Dialog (5 Tabs)
    # =========================================================================
    comms_dialog = IndustrialCommsDialog(win.io_manager, pipeline_engine=win.engine, parent=win)
    comms_dialog.resize(800, 600)
    comms_dialog.show()
    app.processEvents()

    # Tab 0: Siemens S7
    comms_dialog.tabs.setCurrentIndex(0)
    app.processEvents()
    comms_dialog.grab().save(os.path.join(out_dir, "screenshot_plc_siemens.png"))
    print("  -> Saved screenshot_plc_siemens.png")

    # Tab 1: Delta Modbus
    comms_dialog.tabs.setCurrentIndex(1)
    app.processEvents()
    comms_dialog.grab().save(os.path.join(out_dir, "screenshot_plc_delta.png"))
    print("  -> Saved screenshot_plc_delta.png")

    # Tab 2: Beckhoff TwinCAT ADS
    comms_dialog.tabs.setCurrentIndex(2)
    app.processEvents()
    comms_dialog.grab().save(os.path.join(out_dir, "screenshot_plc_beckhoff.png"))
    print("  -> Saved screenshot_plc_beckhoff.png")

    # Tab 3: Industrial Ethernet
    comms_dialog.tabs.setCurrentIndex(3)
    app.processEvents()
    comms_dialog.grab().save(os.path.join(out_dir, "screenshot_plc_ethernet.png"))
    print("  -> Saved screenshot_plc_ethernet.png")

    # Tab 4: Raspberry Pi GPIO
    comms_dialog.tabs.setCurrentIndex(4)
    app.processEvents()
    comms_dialog.grab().save(os.path.join(out_dir, "screenshot_plc_gpio.png"))
    print("  -> Saved screenshot_plc_gpio.png")

    comms_dialog.close()
    win.close()
    print("[+] All user manual screenshots generated successfully!")


if __name__ == "__main__":
    generate_all_screenshots()
