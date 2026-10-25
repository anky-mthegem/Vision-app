"""Industrial Computer Vision Pipeline Manager (PyQt6).

Enterprise-grade, clean, and highly modular computer vision pipeline manager.
Supports dynamic parameter tuning, single & 2-window synchronized split view,
sequential OpenCV chaining with branching inputs, and non-blocking background threading.

Made with <3 by Anky Singh
"""

from __future__ import annotations
import sys
import os
import time
import copy
from typing import Dict, Optional

import cv2
import numpy as np

from PyQt6.QtCore import Qt, QThread, pyqtSignal, QTimer
from PyQt6.QtGui import QIcon, QFont, QAction, QPixmap
from PyQt6.QtWidgets import (
    QApplication,
    QMainWindow,
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QSplitter,
    QToolBar,
    QLabel,
    QComboBox,
    QLineEdit,
    QPushButton,
    QStatusBar,
    QFrame,
    QFileDialog,
    QMessageBox,
)

# Core Pipeline & Operations
from pipeline_engine import (
    PipelineEngine,
    PipelineStep,
    OPERATION_REGISTRY,
    get_categories,
    get_operations_in_category,
)
import operations_catalog  # registers all OpenCV operations
from property_inspector import PropertyInspectorDrawer
from viewport_widget import FlexibleInspectionViewport
from pipeline_table import PipelineTableView
from camera.camera_manager import CameraDevice, CameraConfig, CameraProtocol
from comms.io_manager import IndustrialIoManager
from ui.comms_dialog import IndustrialCommsDialog
from ui.startup_banner import StartupBannerSplash


# ==============================================================================
# INDUSTRIAL DARK THEME STYLESHEET
# ==============================================================================
DARK_INDUSTRIAL_STYLE = """
QMainWindow, QWidget {
    background-color: #16191D;
    color: #E0E6ED;
    font-family: 'Segoe UI', -apple-system, BlinkMacSystemFont, Roboto, sans-serif;
    font-size: 9pt;
}

QToolBar {
    background-color: #1F242D;
    border-bottom: 1px solid #2B323D;
    spacing: 8px;
    padding: 6px 12px;
}

QStatusBar {
    background-color: #121417;
    color: #8C9BAE;
    border-top: 1px solid #2B323D;
    font-family: 'Consolas', monospace;
    font-size: 8.5pt;
}

QLabel {
    color: #E0E6ED;
}

QLineEdit {
    background-color: #16191D;
    color: #00D2FF;
    border: 1px solid #363E4E;
    border-radius: 4px;
    padding: 4px 8px;
    font-family: 'Consolas', monospace;
    font-size: 8.5pt;
}
QLineEdit:focus {
    border-color: #00D2FF;
}

QComboBox {
    background-color: #16191D;
    color: #E0E6ED;
    border: 1px solid #363E4E;
    border-radius: 4px;
    padding: 4px 8px;
    font-size: 8.5pt;
}
QComboBox:hover {
    border-color: #00D2FF;
}
QComboBox QAbstractItemView {
    background-color: #1F242D;
    color: #E0E6ED;
    selection-background-color: #00D2FF;
    selection-color: #0B0D13;
}

QSplitter::handle {
    background-color: #2B323D;
}
QSplitter::handle:horizontal {
    width: 6px;
    background-color: #242A35;
    border-left: 1px solid #1A1F26;
    border-right: 1px solid #1A1F26;
}
QSplitter::handle:horizontal:hover {
    background-color: #00D2FF;
}
QSplitter::handle:pressed {
    background-color: #00E676;
}

QScrollBar:horizontal {
    background: #16191D;
    height: 8px;
    margin: 0px;
    border-radius: 4px;
}
QScrollBar::handle:horizontal {
    background: #2B323D;
    min-width: 20px;
    border-radius: 4px;
}
QScrollBar::handle:horizontal:hover {
    background: #00D2FF;
}
QScrollBar:vertical {
    background: #16191D;
    width: 8px;
    margin: 0px;
    border-radius: 4px;
}
QScrollBar::handle:vertical {
    background: #2B323D;
    min-height: 20px;
    border-radius: 4px;
}
QScrollBar::handle:vertical:hover {
    background: #00D2FF;
}
QScrollBar::add-line, QScrollBar::sub-line {
    width: 0px;
    height: 0px;
}

QToolTip {
    background-color: #1F242D;
    color: #E0E6ED;
    border: 1px solid #00D2FF;
    padding: 4px 8px;
    font-size: 8.5pt;
}
"""


class PipelineWorkerThread(QThread):
    """Background worker thread executing camera acquisition and sequential pipeline evaluation

    without blocking or stuttering the main PyQt6 GUI thread.
    """

    frame_processed = pyqtSignal(dict, dict, float, float)  # (results_dict, step_names, fps, latency_ms)
    camera_offline = pyqtSignal()

    def __init__(self, camera: CameraDevice, engine: PipelineEngine, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.camera = camera
        self.engine = engine
        self._running = True
        self._paused = False

    def run(self):
        fps_counter = 0
        last_fps_time = time.time()
        current_fps = 0.0

        while self._running:
            try:
                if self._paused or not self.camera._running:
                    self.camera_offline.emit()
                    time.sleep(0.04)
                    continue

                frame = self.camera.get_latest_frame()
                if frame is None:
                    self.camera_offline.emit()
                    time.sleep(0.04)
                    continue

                # Execute pipeline steps
                t0 = time.perf_counter()
                results = self.engine.execute(frame, is_live=True)
                latency = (time.perf_counter() - t0) * 1000.0

                # Calculate FPS
                fps_counter += 1
                now = time.time()
                if now - last_fps_time >= 1.0:
                    current_fps = fps_counter / (now - last_fps_time)
                    fps_counter = 0
                    last_fps_time = now

                step_names = {0: "Step 0: Raw Camera Image"}
                for s in self.engine.steps:
                    step_names[s.step_id] = f"Step #{self.engine.get_step_index(s.step_id) + 1}: {s.operation_name}"

                self.frame_processed.emit(results, step_names, current_fps, latency)
                time.sleep(0.015)  # Cap loop to ~60 FPS
            except Exception as e:
                import traceback
                traceback.print_exc()
                time.sleep(0.05)

    def stop(self):
        self._running = False
        self.wait(1000)


class MainWindow(QMainWindow):
    """Main window integrating the Three-Pane Master-Detail layout, Toolbar, and Camera Subsystem."""

    def __init__(self):
        super().__init__()
        self.setWindowTitle("VisionStudio - Industrial Computer Vision Pipeline Manager")
        self.resize(1600, 960)
        self.setMinimumSize(960, 540)
        self.showMaximized()
        
        icon_path = os.path.join(os.path.dirname(os.path.abspath(__file__)), "assets", "app_icon.png")
        if os.path.exists(icon_path):
            self.setWindowIcon(QIcon(icon_path))
        self.setStyleSheet(DARK_INDUSTRIAL_STYLE)

        # 1. Pipeline Engine
        self.engine = PipelineEngine()
        self._setup_default_inspection_recipe()

        # 2. Industrial I/O & Remote PLC/Ethernet Manager
        self.io_manager = IndustrialIoManager(trigger_cb=self._on_software_trigger)

        # 3. Camera Subsystem (Starts in DISCONNECTED state)
        self.camera_config = CameraConfig(protocol=CameraProtocol.USB, source="0")
        self.camera = CameraDevice(self.camera_config)

        # 4. Build UI Layout
        self._init_toolbar()
        self._init_central_ui()
        self._init_statusbar()

        # 5. Background Execution Thread
        self.worker = PipelineWorkerThread(self.camera, self.engine, self)
        self.worker.frame_processed.connect(self._on_frame_processed)
        self.worker.camera_offline.connect(self._on_camera_offline)
        self.worker.start()

        # Connect Table & Inspector
        self.table_view.step_selected.connect(self._on_step_selected)
        self.table_view.show_in_viewport_a.connect(self.viewport.set_viewport_a_source)
        self.table_view.show_in_viewport_b.connect(self.viewport.set_viewport_b_source)
        self.table_view.step_remote_link_changed.connect(self._on_step_remote_link_changed)
        self.table_view.step_output_config_changed.connect(self._on_step_output_config_changed)

        self.inspector.parameter_changed.connect(self._on_param_changed)
        self.inspector.reset_defaults_requested.connect(self._on_reset_defaults)
        self.inspector.remote_link_toggled.connect(self._on_step_remote_link_changed)
        self.inspector.output_config_changed.connect(self._on_step_output_config_changed)
        self.inspector.configure_remote_requested.connect(self._open_plc_dialog)

        # Connect Interactive Canvas ROI Handles
        self.viewport.roi_changed.connect(self._on_viewport_roi_changed)
        self.viewport.roi_finished.connect(self._on_viewport_roi_finished)

        # Default selection
        if self.engine.steps:
            self.table_view.table.selectRow(0)
            self._on_step_selected(self.engine.steps[0])

        # Initial button state: DISCONNECTED (Red)
        self._update_connect_button_state(False)
        self._show_offline_frame()
        self._update_plc_status_badge()

    def _setup_default_inspection_recipe(self):
        """Initializes an industrial starter pipeline (Gaussian Blur -> Canny Edge -> Find Contours)."""
        self.engine.add_step(
            category="Pre-processing & Filtering",
            operation_name="Gaussian Blur",
            name="Smooth Noise",
            params={"ksize": 5, "sigmaX": 1.5},
        )
        self.engine.add_step(
            category="Edges & Gradients",
            operation_name="Canny Edge",
            name="Extract Part Edges",
            params={"threshold1": 80.0, "threshold2": 180.0, "apertureSize": 3},
        )
        self.engine.add_step(
            category="Contours & Calipers",
            operation_name="Find Contours & Filter",
            name="Inspect Defects & Blobs",
            params={"min_area": 80.0, "max_area": 500000.0, "draw_mode": "bbox_center", "color": "green"},
            link_to_remote=True,
        )

    def _init_toolbar(self):
        toolbar = QToolBar("MainToolbar", self)
        toolbar.setMovable(False)
        self.addToolBar(toolbar)

        # Title Branding & Logo
        logo_path = os.path.join(os.path.dirname(os.path.abspath(__file__)), "assets", "app_logo.png")
        if os.path.exists(logo_path):
            lbl_logo = QLabel()
            pix = QPixmap(logo_path).scaled(28, 28, Qt.AspectRatioMode.KeepAspectRatio, Qt.TransformationMode.SmoothTransformation)
            lbl_logo.setPixmap(pix)
            lbl_logo.setStyleSheet("margin-left: 4px; margin-right: 4px;")
            toolbar.addWidget(lbl_logo)

        lbl_brand = QLabel(" VISIONSTUDIO ")
        lbl_brand.setStyleSheet("font-weight: 900; font-size: 10pt; color: #00D2FF; letter-spacing: 1px;")
        toolbar.addWidget(lbl_brand)
        toolbar.addSeparator()

        # Camera Protocol
        toolbar.addWidget(QLabel(" Protocol: "))
        self.combo_protocol = QComboBox()
        for p in CameraProtocol:
            self.combo_protocol.addItem(p.value, p)
        self.combo_protocol.currentIndexChanged.connect(self._on_protocol_changed)
        toolbar.addWidget(self.combo_protocol)

        # Source / URL
        toolbar.addWidget(QLabel(" Source: "))
        self.edit_source = QLineEdit("0")
        self.edit_source.setFixedWidth(180)
        toolbar.addWidget(self.edit_source)

        # Dynamic Connect Camera Button (Red when disconnected, Green when connected)
        self.btn_connect = QPushButton("Connect Camera")
        self.btn_connect.setObjectName("btnConnect")
        self.btn_connect.clicked.connect(self._toggle_camera_connection)
        toolbar.addWidget(self.btn_connect)

        toolbar.addSeparator()

        # Trigger Button
        self.btn_trigger = QPushButton("⚡ SW Trigger")
        self.btn_trigger.setStyleSheet("""
            QPushButton {
                background-color: #242A35;
                color: #00D2FF;
                border: 1px solid #363E4E;
                font-weight: 700;
                padding: 5px 12px;
                border-radius: 6px;
            }
            QPushButton:hover {
                background-color: #2F3746;
                border-color: #00D2FF;
            }
        """)
        self.btn_trigger.clicked.connect(self._on_software_trigger)
        toolbar.addWidget(self.btn_trigger)

        toolbar.addSeparator()

        # Preset Recipes Menu
        toolbar.addWidget(QLabel(" Presets: "))
        self.combo_presets = QComboBox()
        self.combo_presets.addItem("Select Recipe Preset...", None)
        self.combo_presets.addItem("1. Edge Detection & Defect Inspection", "edges")
        self.combo_presets.addItem("2. Adaptive Threshold & Contours", "adaptive")
        self.combo_presets.addItem("3. HSV Color Isolation & Filtering", "hsv")
        self.combo_presets.addItem("4. Morphological Cleanup Pipeline", "morph")
        self.combo_presets.addItem("5. Blank / Clean Pipeline", "clean")
        self.combo_presets.addItem("6. YOLO26 / Neural Object Detection", "yolo")
        self.combo_presets.addItem("7. Geometric Shape Detection (Circle, Square, Rect)", "shapes")
        self.combo_presets.addItem("8. Hand Tracking & Gesture Recognition", "hand")
        self.combo_presets.addItem("9. Optical Character Recognition (OCR)", "ocr")
        self.combo_presets.addItem("10. Calibrated Metrology & Dimension Caliper", "measure")
        self.combo_presets.addItem("11. Interactive Crop / Region of Interest (ROI)", "roi")
        self.combo_presets.currentIndexChanged.connect(self._apply_preset_recipe)
        toolbar.addWidget(self.combo_presets)

        toolbar.addSeparator()

        # Camera Calibration Button
        self.btn_calib = QPushButton("📐 Calibration")
        self.btn_calib.setObjectName("btnCalib")
        self.btn_calib.setToolTip("Configure Camera Optical Calibration Factor (mm/pixel)")
        self.btn_calib.setStyleSheet("""
            QPushButton#btnCalib {
                background-color: #1F242D;
                color: #00E676;
                border: 1px solid #00E676;
                font-weight: 700;
                padding: 5px 12px;
                border-radius: 6px;
            }
            QPushButton#btnCalib:hover {
                background-color: #00E676;
                color: #0B0D13;
            }
        """)
        self.btn_calib.clicked.connect(self._open_calibration_dialog)
        toolbar.addWidget(self.btn_calib)

        # PLC & Remote Device Dispatch Button
        self.btn_plc = QPushButton("📡 PLC & Devices")
        self.btn_plc.setObjectName("btnPlc")
        self.btn_plc.setToolTip("Configure Siemens, Delta, Beckhoff PLCs, Ethernet Devices & Raspberry Pi GPIO")
        self.btn_plc.setStyleSheet("""
            QPushButton#btnPlc {
                background-color: #1F242D;
                color: #00D2FF;
                border: 1px solid #00D2FF;
                font-weight: 700;
                padding: 5px 12px;
                border-radius: 6px;
            }
            QPushButton#btnPlc:hover {
                background-color: #00D2FF;
                color: #0B0D13;
            }
        """)
        self.btn_plc.clicked.connect(self._open_plc_dialog)
        toolbar.addWidget(self.btn_plc)

        toolbar.addSeparator()

        # KPI Badges
        self.badge_fps = QLabel("FPS: 0.0")
        self.badge_fps.setStyleSheet("background: rgba(0,210,255,0.12); color: #00D2FF; font-weight: 800; padding: 4px 8px; border-radius: 4px; font-family: 'Consolas';")
        toolbar.addWidget(self.badge_fps)

        self.badge_latency = QLabel("Latency: 0.0 ms")
        self.badge_latency.setStyleSheet("background: rgba(0,230,118,0.12); color: #00E676; font-weight: 800; padding: 4px 8px; border-radius: 4px; font-family: 'Consolas';")
        toolbar.addWidget(self.badge_latency)

        self.badge_plc = QLabel("PLC: Standby")
        self.badge_plc.setStyleSheet("background: rgba(140,155,174,0.12); color: #8C9BAE; font-weight: 700; padding: 4px 8px; border-radius: 4px; font-family: 'Consolas';")
        toolbar.addWidget(self.badge_plc)

    def _init_central_ui(self):
        # Master Horizontal Splitter across 3 Panes (Left, Center, Right columns)
        self.main_splitter = QSplitter(Qt.Orientation.Horizontal)
        self.main_splitter.setChildrenCollapsible(False)
        self.main_splitter.setHandleWidth(6)
        self.setCentralWidget(self.main_splitter)

        # 1. Left Pane: Spreadsheet Pipeline Table
        self.left_pane = QWidget()
        self.left_pane.setMinimumWidth(320)
        left_layout = QVBoxLayout(self.left_pane)
        left_layout.setContentsMargins(6, 6, 6, 6)
        self.table_view = PipelineTableView(self.engine, self)
        left_layout.addWidget(self.table_view)
        self.main_splitter.addWidget(self.left_pane)

        # 2. Center Pane: Flexible Inspection Viewport (Single vs. Split)
        self.center_pane = QWidget()
        self.center_pane.setMinimumWidth(400)
        center_layout = QVBoxLayout(self.center_pane)
        center_layout.setContentsMargins(6, 6, 6, 6)
        self.viewport = FlexibleInspectionViewport(self)
        center_layout.addWidget(self.viewport)
        self.main_splitter.addWidget(self.center_pane)

        # 3. Right Pane: Collapsible Dynamic Parameter Inspector Drawer
        self.right_pane = QWidget()
        self.right_pane.setMinimumWidth(260)
        right_layout = QVBoxLayout(self.right_pane)
        right_layout.setContentsMargins(6, 6, 6, 6)
        self.inspector = PropertyInspectorDrawer(self)
        right_layout.addWidget(self.inspector)
        self.main_splitter.addWidget(self.right_pane)

        # Stretch factors: Left=0 (stable width), Center=1 (absorbs extra width when maximized/resized), Right=0 (stable width)
        self.main_splitter.setStretchFactor(0, 0)
        self.main_splitter.setStretchFactor(1, 1)
        self.main_splitter.setStretchFactor(2, 0)

        # Set Initial Pane Split Ratio: Left=420px, Center=860px, Right=320px
        self.main_splitter.setSizes([420, 860, 320])

    def _init_statusbar(self):
        self.status = QStatusBar()
        self.setStatusBar(self.status)
        self.status.showMessage("VisionStudio Initialized | Camera: Disconnected | Ready to inspect | Made with <3 by Anky Singh")

    # ==========================================================================
    # CAMERA CONNECTION & DYNAMIC BUTTON MANAGEMENT
    # ==========================================================================

    def _update_connect_button_state(self, is_connected: bool):
        if is_connected:
            self.btn_connect.setText("Disconnect Camera")
            self.btn_connect.setToolTip("Camera is currently connected and streaming. Click to disconnect.")
            self.btn_connect.setStyleSheet("""
                QPushButton#btnConnect {
                    background-color: #00E676;
                    border: 1px solid #00C853;
                    color: #0B0D13;
                    font-weight: 700;
                    padding: 5px 14px;
                    border-radius: 6px;
                }
                QPushButton#btnConnect:hover {
                    background-color: #69F0AE;
                    border-color: #00E676;
                    color: #000000;
                }
            """)
        else:
            self.btn_connect.setText("Connect Camera")
            self.btn_connect.setToolTip("Camera is currently disconnected. Click to connect.")
            self.btn_connect.setStyleSheet("""
                QPushButton#btnConnect {
                    background-color: #FF1744;
                    border: 1px solid #D50000;
                    color: #FFFFFF;
                    font-weight: 700;
                    padding: 5px 14px;
                    border-radius: 6px;
                }
                QPushButton#btnConnect:hover {
                    background-color: #FF5252;
                    border-color: #FF1744;
                    color: #FFFFFF;
                }
            """)

    def _toggle_camera_connection(self):
        if self.camera._running:
            # Currently running -> Stop / Disconnect
            self.camera.stop()
            self._update_connect_button_state(False)
            self._show_offline_frame()
            self.status.showMessage("Camera disconnected by user. Acquisition stopped.")
        else:
            # Currently stopped -> Start / Connect
            self.camera.stop()
            self.camera_config.protocol = self.combo_protocol.currentData()
            self.camera_config.source = self.edit_source.text().strip()
            self.camera = CameraDevice(self.camera_config)
            self.worker.camera = self.camera
            self.camera.start()
            self._update_connect_button_state(True)
            self.status.showMessage(f"Connecting to {self.camera_config.protocol.value} ({self.camera_config.source})...")

    def _on_protocol_changed(self):
        proto = self.combo_protocol.currentData()
        if proto == CameraProtocol.USB:
            self.edit_source.setText("0")
        elif proto == CameraProtocol.RTSP:
            self.edit_source.setText("rtsp://admin:admin123@192.168.1.100:554/live")
        elif proto == CameraProtocol.HTTP:
            self.edit_source.setText("http://192.168.1.100/snapshot.jpg")
        elif proto == CameraProtocol.TEST_STREAM:
            self.edit_source.setText("Virtual Calibration Pattern")
        elif proto == CameraProtocol.FILE_LOOP:
            self.edit_source.setText("test_bus.jpg")

        if self.camera._running:
            self._toggle_camera_connection()
            self._toggle_camera_connection()

    def _on_software_trigger(self):
        self.camera.trigger()
        self.status.showMessage("Software acquisition trigger event fired.")

    def _show_offline_frame(self):
        no_cam = self._create_no_camera_frame()
        self.viewport.update_pipeline_results({0: no_cam}, {0: "Step 0: Camera Disconnected"})

    def _create_no_camera_frame(self) -> np.ndarray:
        w, h = 1280, 720
        frame = np.full((h, w, 3), 15, dtype=np.uint8)

        # Industrial alignment grid
        for x in range(0, w, 64):
            cv2.line(frame, (x, 0), (x, h), (24, 27, 36), 1)
        for y in range(0, h, 64):
            cv2.line(frame, (0, y), (w, y), (24, 27, 36), 1)

        # Frame border
        cv2.rectangle(frame, (24, 24), (w - 24, h - 24), (45, 50, 68), 1)

        # Center reticle
        cx, cy = w // 2, h // 2
        cv2.circle(frame, (cx, cy), 80, (40, 45, 60), 1)
        cv2.circle(frame, (cx, cy), 4, (60, 65, 85), -1)
        cv2.line(frame, (cx - 100, cy), (cx + 100, cy), (40, 45, 60), 1)
        cv2.line(frame, (cx, cy - 100), (cx, cy + 100), (40, 45, 60), 1)

        title_text = "NO CAMERA CONNECTED"
        src_str = self.edit_source.text().strip() or "0"
        sub_text = f"Protocol: {self.combo_protocol.currentText()} | Source: {src_str}"
        hint_text = "Click 'Connect Camera' or select Virtual Synthetic Generator / File Loop to begin"

        (tw1, _), _ = cv2.getTextSize(title_text, cv2.FONT_HERSHEY_SIMPLEX, 1.05, 2)
        cv2.putText(frame, title_text, (cx - tw1 // 2, cy - 20), cv2.FONT_HERSHEY_SIMPLEX, 1.05, (100, 110, 135), 2, cv2.LINE_AA)

        (tw2, _), _ = cv2.getTextSize(sub_text, cv2.FONT_HERSHEY_SIMPLEX, 0.52, 1)
        cv2.putText(frame, sub_text, (cx - tw2 // 2, cy + 22), cv2.FONT_HERSHEY_SIMPLEX, 0.52, (70, 80, 100), 1, cv2.LINE_AA)

        (tw3, _), _ = cv2.getTextSize(hint_text, cv2.FONT_HERSHEY_SIMPLEX, 0.44, 1)
        cv2.putText(frame, hint_text, (cx - tw3 // 2, cy + 54), cv2.FONT_HERSHEY_SIMPLEX, 0.44, (50, 58, 75), 1, cv2.LINE_AA)

        return frame

    # ==========================================================================
    # WORKER SIGNALS & PIPELINE SYNCHRONIZATION
    # ==========================================================================

    def _on_frame_processed(self, results: Dict[int, np.ndarray], step_names: Dict[int, str], fps: float, latency: float):
        try:
            if not self.camera._running:
                self._show_offline_frame()
                self._update_connect_button_state(False)
                return

            self._update_connect_button_state(True)
            self.badge_fps.setText(f"FPS: {fps:.1f}")
            self.badge_latency.setText(f"Latency: {latency:.1f} ms")

            # Update Viewport with intermediate buffers
            self.viewport.update_pipeline_results(results, step_names)

            # Refresh Spreadsheet Table Latency & Output Badges
            self.table_view.refresh()

            # Dispatch linked step outputs to active remote devices (PLCs, Ethernet, Raspberry Pi)
            for s in self.engine.steps:
                if getattr(s, "link_to_remote", False):
                    sig = s.evaluate_output_signal()
                    step_info = {
                        "step_id": s.step_id,
                        "step_name": s.name,
                        "operation": s.operation_name,
                        "passed": s.status_ok,
                        "latency_ms": s.last_exec_ms,
                        "output_info": s.output_info,
                        "count": getattr(s, "metrics", {}).get("count", 1 if s.status_ok else 0),
                        "x": getattr(s, "metrics", {}).get("x", 0.0),
                        "y": getattr(s, "metrics", {}).get("y", 0.0),
                        "angle": getattr(s, "metrics", {}).get("angle", 0.0),
                        "signal_id": sig.get("signal_id", 0),
                        "output_value": sig.get("numeric_value", 0.0),
                        "numeric_value": sig.get("numeric_value", 0.0),
                        "text_value": sig.get("text_value", ""),
                        "output_mode": sig.get("output_mode", "default"),
                        "target_class": sig.get("target_class", ""),
                        "display_str": sig.get("display_str", ""),
                        "signal_active": sig.get("active", True),
                    }
                    self.io_manager.dispatch_step_output(step_info)
        except Exception as e:
            import traceback
            traceback.print_exc()

    def _open_plc_dialog(self):
        dialog = IndustrialCommsDialog(self.io_manager, pipeline_engine=self.engine, parent=self)
        if dialog.exec():
            self.table_view.refresh()
            self._update_plc_status_badge()

    def _update_plc_status_badge(self):
        active_devs = []
        if self.io_manager.enable_siemens:
            active_devs.append("Siemens")
        if self.io_manager.enable_delta:
            active_devs.append("Delta")
        if self.io_manager.enable_beckhoff:
            active_devs.append("Beckhoff")
        if self.io_manager.enable_ethernet:
            active_devs.append(f"ETH ({self.io_manager.ethernet_client.target_ip})")
        if self.io_manager.enable_gpio:
            active_devs.append("RPi GPIO")

        linked_steps = sum(1 for s in self.engine.steps if getattr(s, "link_to_remote", False))
        if active_devs:
            dev_str = ", ".join(active_devs)
            self.badge_plc.setText(f"PLC: {dev_str} | {linked_steps} Linked")
            self.badge_plc.setStyleSheet("background: rgba(0,230,118,0.12); color: #00E676; font-weight: 700; padding: 4px 8px; border-radius: 4px; font-family: 'Consolas';")
        else:
            self.badge_plc.setText(f"PLC: Standby ({linked_steps} Linked)")
            self.badge_plc.setStyleSheet("background: rgba(140,155,174,0.12); color: #8C9BAE; font-weight: 700; padding: 4px 8px; border-radius: 4px; font-family: 'Consolas';")

    def _on_step_remote_link_changed(self, step_id: int, enabled: bool):
        step = self.engine.get_step_by_id(step_id)
        if step:
            step.link_to_remote = enabled
            if hasattr(step, "output_config") and isinstance(step.output_config, dict):
                step.output_config["link_to_remote"] = enabled
            self.table_view.refresh()
            self._update_plc_status_badge()
            self.status.showMessage(f"Step #{step_id} ({step.name}) remote dispatch {'ENABLED' if enabled else 'DISABLED'}")

    def _on_step_output_config_changed(self, step_id: int, cfg: dict):
        step = self.engine.get_step_by_id(step_id)
        if step:
            step.output_config = cfg
            if "link_to_remote" in cfg:
                step.link_to_remote = cfg["link_to_remote"]
            self.table_view.refresh()
            self._update_plc_status_badge()
            summary = step.get_output_summary()
            self.status.showMessage(f"Step #{step_id} ({step.name}) output signal configured: {summary}")

    def _on_camera_offline(self):
        self._update_connect_button_state(False)
        self.badge_fps.setText("FPS: 0.0")
        self._show_offline_frame()

    def _on_step_selected(self, step: Optional[PipelineStep]):
        self.inspector.inspect_step(step)
        self._sync_roi_for_step(step)

    def _sync_roi_for_step(self, step: Optional[PipelineStep]):
        if step and ("Crop" in step.operation_name or "ROI" in step.name or {"x", "y", "width", "height"}.issubset(step.params.keys())):
            x = int(step.params.get("x", 50))
            y = int(step.params.get("y", 50))
            w = int(step.params.get("width", 320))
            h = int(step.params.get("height", 240))
            self.viewport.set_roi_rect(x, y, w, h, emit_signal=False)
            self.viewport.set_roi_active(True)
        elif not self.viewport.is_roi_active():
            self.viewport.set_roi_active(False)

    def _on_viewport_roi_changed(self, x: int, y: int, w: int, h: int):
        self.status.showMessage(f"ROI Handle: X={x}, Y={y}, Width={w}, Height={h}")
        step = self.inspector.current_step
        if step and {"x", "y", "width", "height"}.issubset(step.params.keys()):
            self.inspector.update_control_value("x", x)
            self.inspector.update_control_value("y", y)
            self.inspector.update_control_value("width", w)
            self.inspector.update_control_value("height", h)
            self.engine.set_step_param(step.step_id, "x", x)
            self.engine.set_step_param(step.step_id, "y", y)
            self.engine.set_step_param(step.step_id, "width", w)
            self.engine.set_step_param(step.step_id, "height", h)

    def _on_viewport_roi_finished(self, x: int, y: int, w: int, h: int):
        self._on_viewport_roi_changed(x, y, w, h)
        self.status.showMessage(f"ROI Boundary Committed: [{x}, {y}, {w}x{h}]", 3000)

    def _on_param_changed(self, step_id: int, param_name: str, value: object):
        step = self.engine.get_step_by_id(step_id)
        if step:
            step.set_param(param_name, value)
            idx = self.engine.get_step_index(step_id)
            self.engine.mark_dirty_from(idx)
            if param_name in ("x", "y", "width", "height"):
                x = int(step.params.get("x", 50))
                y = int(step.params.get("y", 50))
                w = int(step.params.get("width", 320))
                h = int(step.params.get("height", 240))
                self.viewport.set_roi_rect(x, y, w, h, emit_signal=False)
                self.viewport.set_roi_active(True)

    def _on_reset_defaults(self, step_id: int):
        idx = self.engine.get_step_index(step_id)
        if idx >= 0:
            self.engine.mark_dirty_from(idx)

    def _open_calibration_dialog(self):
        from ui.calibration_dialog import CameraCalibrationDialog
        dialog = CameraCalibrationDialog(parent=self, pipeline_engine=self.engine)
        dialog.calibration_applied.connect(self._on_calibration_applied)
        dialog.exec()

    def _on_calibration_applied(self, factor: float, unit: str):
        self.table_view.refresh()
        if self.inspector.current_step:
            self.inspector.inspect_step(self.inspector.current_step)
        self.status.showMessage(f"Camera Optical Scale calibrated: 1 px = {factor:.4f} {unit}")

    # ==========================================================================
    # PRESET RECIPES
    # ==========================================================================

    def _apply_preset_recipe(self, index: int):
        preset_key = self.combo_presets.currentData()
        if not preset_key:
            return

        self.table_view.model.beginResetModel()
        self.engine.steps.clear()

        if preset_key == "edges":
            self.engine.add_step("Pre-processing & Filtering", "Gaussian Blur", "Smooth", params={"ksize": 5, "sigmaX": 1.5})
            self.engine.add_step("Edges & Gradients", "Canny Edge", "Canny", params={"threshold1": 80.0, "threshold2": 180.0})
            self.engine.add_step("Morphology", "Dilate", "Dilate Edges", params={"kernel_size": 3, "iterations": 1})
            self.engine.add_step("Contours & Calipers", "Find Contours & Filter", "Count Defects", params={"min_area": 50.0})

        elif preset_key == "adaptive":
            self.engine.add_step("Pre-processing & Filtering", "Median Blur", "De-noise", params={"ksize": 5})
            self.engine.add_step("Thresholding & Binarization", "Adaptive Threshold", "Adaptive", params={"blockSize": 15, "C": 3.0})
            self.engine.add_step("Morphology", "Morphology Ex", "Close Gaps", params={"op_type": cv2.MORPH_CLOSE, "kernel_size": 3})
            self.engine.add_step("Contours & Calipers", "Find Contours & Filter", "Classify Blobs", params={"draw_mode": "bbox_center"})

        elif preset_key == "hsv":
            self.engine.add_step("Pre-processing & Filtering", "HSV Color InRange Filter", "Isolate Hue", params={"h_min": 10, "h_max": 90, "apply_mask": True})
            self.engine.add_step("Pre-processing & Filtering", "Bilateral Filter", "Smooth Edge", params={"d": 7, "sigmaColor": 50.0})
            self.engine.add_step("Thresholding & Binarization", "Standard & Otsu Threshold", "Otsu Binarize", params={"use_otsu": True})

        elif preset_key == "morph":
            self.engine.add_step("Thresholding & Binarization", "Standard & Otsu Threshold", "Initial Threshold", params={"thresh": 128.0})
            self.engine.add_step("Morphology", "Morphology Ex", "Open Filter", params={"op_type": cv2.MORPH_OPEN, "kernel_size": 5})
            self.engine.add_step("Morphology", "Morphology Ex", "Close Holes", params={"op_type": cv2.MORPH_CLOSE, "kernel_size": 5})

        elif preset_key == "yolo":
            self.engine.add_step(
                category="AI & Deep Learning (YOLO)",
                operation_name="YOLO26 / YOLO Neural Detector",
                name="YOLO26 Neural Detection",
                params={"model_variant": "yolo26", "target_class": "all", "confidence": 0.35, "draw_boxes": True, "draw_labels": True},
            )

        elif preset_key == "shapes":
            self.engine.add_step(
                category="Pre-processing & Filtering",
                operation_name="Gaussian Blur",
                name="De-noise",
                params={"ksize": 5, "sigmaX": 1.2},
            )
            self.engine.add_step(
                category="Feature Detection",
                operation_name="Geometric Shape Detector",
                name="Detect Circles, Squares & Rects",
                params={"target_shape": "all", "min_area": 120.0, "circularity_threshold": 0.78, "draw_contours": True, "draw_labels": True},
                link_to_remote=True,
            )

        elif preset_key == "hand":
            self.engine.add_step(
                category="Feature Detection",
                operation_name="Hand & Gesture Tracker",
                name="Hand Tracking & Gestures",
                params={"min_hand_area": 2000.0, "draw_skeleton": True, "draw_fingers_count": True},
                link_to_remote=True,
            )

        elif preset_key == "ocr":
            self.engine.add_step(
                category="Pre-processing & Filtering",
                operation_name="Gaussian Blur",
                name="Filter Background Noise",
                params={"ksize": 3, "sigmaX": 1.0},
            )
            self.engine.add_step(
                category="Feature Detection",
                operation_name="Optical Character Recognition (OCR)",
                name="Segment Text & Read Characters",
                params={"min_char_height": 10, "draw_boxes": True, "draw_text": True},
                link_to_remote=True,
            )

        elif preset_key == "measure":
            self.engine.add_step(
                category="Pre-processing & Filtering",
                operation_name="Gaussian Blur",
                name="Clean Noise",
                params={"ksize": 5, "sigmaX": 1.5},
            )
            self.engine.add_step(
                category="Contours & Calipers",
                operation_name="Industrial Caliper & Measurement",
                name="Calibrated Dimensional Caliper",
                params={
                    "calibration_factor": 0.10,
                    "unit": "mm",
                    "measurement_mode": "all",
                    "target_dimension": 50.0,
                    "tolerance": 2.5,
                    "draw_arrows": True,
                    "draw_callout": True,
                },
                link_to_remote=True,
            )

        elif preset_key == "roi":
            self.engine.add_step(
                category="Contours & Calipers",
                operation_name="Crop / Region of Interest (ROI)",
                name="Crop / Focus ROI",
                params={"x": 80, "y": 60, "width": 480, "height": 360, "mode": "crop"},
            )
            self.engine.add_step(
                category="Pre-processing & Filtering",
                operation_name="Gaussian Blur",
                name="Smooth ROI",
                params={"ksize": 5, "sigmaX": 1.2},
            )
            self.engine.add_step(
                category="Edges & Gradients",
                operation_name="Canny Edge",
                name="Detect Edges in ROI",
                params={"threshold1": 60.0, "threshold2": 160.0},
            )
            self.engine.add_step(
                category="Contours & Calipers",
                operation_name="Find Contours & Filter",
                name="Inspect ROI Features",
                params={"min_area": 40.0, "draw_mode": "bbox_center", "color": "green"},
                link_to_remote=True,
            )

        self.table_view.model.endResetModel()
        self.table_view.refresh()

        if self.engine.steps:
            self.table_view.table.selectRow(0)
            self._on_step_selected(self.engine.steps[0])
            self.viewport.set_viewport_a_source(self.engine.steps[0].step_id)

        # Reset combo to first item
        self.combo_presets.blockSignals(True)
        self.combo_presets.setCurrentIndex(0)
        self.combo_presets.blockSignals(False)

    def closeEvent(self, event):
        self.worker.stop()
        self.camera.stop()
        event.accept()


def main():
    app = QApplication.instance() or QApplication(sys.argv)
    app.setFont(QFont("Segoe UI", 9))
    icon_path = os.path.join(os.path.dirname(os.path.abspath(__file__)), "assets", "app_icon.png")
    if os.path.exists(icon_path):
        app.setWindowIcon(QIcon(icon_path))

    show_splash = "--no-splash" not in sys.argv
    if show_splash:
        splash = StartupBannerSplash(auto_dismiss_ms=2500)
        splash.show()
        app.processEvents()

        window = MainWindow()

        def on_splash_finish():
            window.showMaximized()
            window.raise_()
            window.activateWindow()

        if not splash.isVisible():
            on_splash_finish()
        else:
            splash.finished.connect(on_splash_finish)
    else:
        window = MainWindow()
        window.showMaximized()

    sys.exit(app.exec())


if __name__ == "__main__":
    main()
