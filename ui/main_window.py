"""VisionStudio Main Industrial Desktop Window using PyQt6.

Features:
- On-demand tool execution (no vision functions run on startup until user selects them).
- Comprehensive Industrial Vision Tool Catalog (Pattern, Blobs, Caliper, EdgeCount, Barcode/QR, OCR, Color, Filters, Geometry, Logic).
- Interactive spreadsheet grid with per-cell enable/disable checkboxes.
- Real-time camera display with graphics overlays and formula bar.
"""

import sys
import cv2
import numpy as np
import time
from typing import Optional

import threading

from PyQt6.QtWidgets import (
    QMainWindow,
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QGridLayout,
    QLabel,
    QPushButton,
    QComboBox,
    QLineEdit,
    QTableWidget,
    QTableWidgetItem,
    QHeaderView,
    QSplitter,
    QGroupBox,
    QStatusBar,
    QToolBar,
    QFrame,
    QTabWidget,
    QScrollArea,
    QCheckBox,
    QSlider,
    QMessageBox,
)
from PyQt6.QtCore import Qt, QTimer, pyqtSlot
from PyQt6.QtGui import QImage, QPixmap, QColor, QFont, QIcon, QPainter, QPen, QBrush

from camera.camera_manager import CameraDevice, CameraConfig, CameraProtocol
from engine.spreadsheet import InspectionJob, Cell, INDUSTRIAL_FUNCTION_CATALOG
from comms.native_mode import NativeModeServer
from web.server import WebHmiServer
from tools.patmax import PatMaxResult
from tools.blob import BlobResult
from tools.edge import LineResult, CircleResult
from tools.caliper_width import CaliperWidthResult, EdgeCountResult
from tools.id_reader import CodeResult
from tools.ocr import OcrResult
from tools.flaw import FlawResult
from tools.filters import HistogramResult, ColorResult
from tools.yolo_detector import YoloDetectorTool, YoloResult, YoloDetection, COCO_CLASSES
from comms.io_manager import IndustrialIoManager
from ui.comms_dialog import IndustrialCommsDialog


DARK_STYLESHEET = """
QMainWindow, QWidget {
    background-color: #0f1117;
    color: #e8ecf4;
    font-family: 'Segoe UI', 'Inter', sans-serif;
    font-size: 13px;
}
QToolBar {
    background-color: #181b24;
    border-bottom: 1px solid #2d3244;
    padding: 8px 12px;
    spacing: 10px;
}
QGroupBox {
    background-color: #181b24;
    border: 1px solid #2d3244;
    border-radius: 8px;
    margin-top: 14px;
    padding-top: 14px;
    font-weight: 600;
    color: #8b94a8;
}
QGroupBox::title {
    subcontrol-origin: margin;
    subcontrol-position: top left;
    padding: 0 8px;
    color: #00d2ff;
}
QPushButton {
    background-color: #202430;
    border: 1px solid #2d3244;
    border-radius: 6px;
    padding: 6px 14px;
    font-weight: 600;
    color: #e8ecf4;
}
QPushButton:hover {
    background-color: #2d3244;
    border-color: #00d2ff;
}
QPushButton:pressed {
    background-color: #00d2ff;
    color: #000;
}
QPushButton#btnTrigger {
    background-color: #00d2ff;
    color: #0f1117;
    font-weight: 700;
}
QPushButton#btnTrigger:hover {
    background-color: #33dcff;
}
QPushButton#btnPlc {
    background-color: #162438;
    border-color: #00d2ff;
    color: #00d2ff;
    font-weight: 700;
}
QPushButton#btnPlc:hover {
    background-color: #00d2ff;
    color: #0f1117;
}
QPushButton#btnClear {
    background-color: #3a1a24;
    border-color: #ff1744;
    color: #ff5252;
}
QPushButton#btnClear:hover {
    background-color: #ff1744;
    color: #fff;
}
QComboBox, QLineEdit {
    background-color: #202430;
    border: 1px solid #2d3244;
    border-radius: 6px;
    padding: 6px 10px;
    color: #e8ecf4;
}
QComboBox:focus, QLineEdit:focus {
    border-color: #00d2ff;
}
QTableWidget {
    background-color: #181b24;
    border: 1px solid #2d3244;
    border-radius: 8px;
    gridline-color: #2d3244;
    font-family: 'Consolas', 'JetBrains Mono', monospace;
    font-size: 12px;
}
QHeaderView::section {
    background-color: #202430;
    color: #8b94a8;
    padding: 6px;
    border: 1px solid #2d3244;
    font-weight: 600;
}
QTabWidget::pane {
    border: 1px solid #2d3244;
    background-color: #181b24;
    border-radius: 6px;
}
QTabBar::tab {
    background: #141720;
    color: #8b94a8;
    padding: 8px 14px;
    border: 1px solid #2d3244;
    border-bottom: none;
    border-top-left-radius: 6px;
    border-top-right-radius: 6px;
    margin-right: 2px;
}
QTabBar::tab:selected {
    background: #181b24;
    color: #00d2ff;
    font-weight: 600;
}
QStatusBar {
    background-color: #141720;
    color: #8b94a8;
    border-top: 1px solid #2d3244;
}
"""


class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("VisionStudio | In-Sight Industrial Computer Vision System")
        self.resize(1440, 920)
        self.setStyleSheet(DARK_STYLESHEET)

        # 1. Initialize Clean Job (NO tools running on startup, only A0 camera grab)
        self.job = InspectionJob("CustomJob")
        self._setup_clean_job()

        # 2. Camera Device
        self.camera_config = CameraConfig(protocol=CameraProtocol.TEST_STREAM)
        self.camera = CameraDevice(self.camera_config)

        # 3. Native Mode Server (Port 1023)
        self.native_server = NativeModeServer(
            job_getter_cb=lambda: self.job,
            trigger_cb=self.trigger_acquisition,
            port=1023,
        )
        self.native_server.start()

        # 4. WebHMI Server (Port 8080)
        self._last_annotated_frame: Optional[np.ndarray] = None
        self.web_server = WebHmiServer(
            frame_getter=self.get_display_frame,
            job_getter=lambda: self.job,
            trigger_cb=self.trigger_acquisition,
            port=8080,
        )
        self.web_server.start()

        # 5. Industrial PLC, Ethernet & GPIO Manager
        self.io_manager = IndustrialIoManager(trigger_cb=self.trigger_acquisition)

        # 6. Build UI
        self._init_ui()

        # 7. Performance & Asynchronous Execution States (Lightweight & Smooth 30+ FPS)
        self._inspecting = False
        self._last_stats = {}
        self._tick_counter = 0
        self._selected_coord: Optional[str] = None

        # 8. Start Camera & Timer
        self.camera.start()
        self.timer = QTimer(self)
        self.timer.timeout.connect(self._on_timer_tick)
        self.timer.start(33)

    def get_display_frame(self) -> Optional[np.ndarray]:
        if self._last_annotated_frame is not None:
            return self._last_annotated_frame.copy()
        return self.camera.get_latest_frame()

    def _setup_clean_job(self):
        """Starts in pure acquisition mode: NO vision tools execute until user selects them."""
        self.job.cells.clear()
        self.job.add_cell("A0", "=AcquireImage()", "Camera Image", enabled=True)
        self.job.compile()

    def _init_ui(self):
        # Top Toolbar
        toolbar = QToolBar("MainToolbar", self)
        self.addToolBar(toolbar)

        toolbar.addWidget(QLabel(" Camera Protocol: "))
        self.protocol_combo = QComboBox()
        for p in CameraProtocol:
            self.protocol_combo.addItem(p.value, p)
        self.protocol_combo.currentIndexChanged.connect(self._on_protocol_changed)
        toolbar.addWidget(self.protocol_combo)

        toolbar.addWidget(QLabel(" Source / URL: "))
        self.source_edit = QLineEdit("0")
        self.source_edit.setFixedWidth(200)
        toolbar.addWidget(self.source_edit)

        self.btn_connect = QPushButton("Connect Camera")
        self.btn_connect.clicked.connect(self._on_reconnect)
        toolbar.addWidget(self.btn_connect)

        toolbar.addSeparator()

        self.btn_trigger = QPushButton("TRIGGER [SW]")
        self.btn_trigger.setObjectName("btnTrigger")
        self.btn_trigger.clicked.connect(self.trigger_acquisition)
        toolbar.addWidget(self.btn_trigger)

        toolbar.addSeparator()

        self.btn_clear = QPushButton("Clear All Tools")
        self.btn_clear.setObjectName("btnClear")
        self.btn_clear.clicked.connect(self._on_clear_tools)
        toolbar.addWidget(self.btn_clear)

        toolbar.addSeparator()
        self.btn_web = QPushButton("Open WebHMI (Port 8080)")
        self.btn_web.clicked.connect(self._open_webhmi)
        toolbar.addWidget(self.btn_web)

        toolbar.addSeparator()
        self.btn_plc = QPushButton("📡 PLC & Devices")
        self.btn_plc.setObjectName("btnPlc")
        self.btn_plc.setToolTip("Configure Siemens, Delta, Beckhoff PLCs, Ethernet Devices & Raspberry Pi GPIO")
        self.btn_plc.clicked.connect(self._open_plc_dialog)
        toolbar.addWidget(self.btn_plc)

        # Main Splitter (Left: Live Viewport | Right: Spreadsheet & Function Catalog)
        splitter = QSplitter(Qt.Orientation.Horizontal)
        self.setCentralWidget(splitter)

        # ----------------- LEFT PANEL: VIEWPORT & KPI -----------------
        left_widget = QWidget()
        left_layout = QVBoxLayout(left_widget)
        left_layout.setContentsMargins(10, 10, 10, 10)

        # KPI Banner
        kpi_frame = QFrame()
        kpi_frame.setStyleSheet("background-color: #181b24; border: 1px solid #2d3244; border-radius: 8px; padding: 6px;")
        kpi_layout = QHBoxLayout(kpi_frame)

        self.lbl_overall = QLabel("READY (STANDBY)")
        self.lbl_overall.setStyleSheet("font-size: 15px; font-weight: 800; color: #00d2ff; padding: 4px 10px; background: rgba(0,210,255,0.1); border-radius: 6px;")
        kpi_layout.addWidget(self.lbl_overall)

        self.lbl_stats = QLabel("Live Stream Active | Select a vision function below to begin inspection")
        self.lbl_stats.setStyleSheet("font-family: 'Consolas', monospace; font-size: 12px; color: #8b94a8;")
        kpi_layout.addWidget(self.lbl_stats)
        kpi_layout.addStretch()
        left_layout.addWidget(kpi_frame)

        # Viewport
        self.lbl_viewport = QLabel()
        self.lbl_viewport.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.lbl_viewport.setStyleSheet("background-color: #050608; border: 1px solid #2d3244; border-radius: 8px;")
        self.lbl_viewport.setMinimumSize(640, 480)
        left_layout.addWidget(self.lbl_viewport, 1)

        splitter.addWidget(left_widget)

        # ----------------- RIGHT PANEL: SPREADSHEET & CATALOG -----------------
        right_widget = QWidget()
        right_layout = QVBoxLayout(right_widget)
        right_layout.setContentsMargins(10, 10, 10, 10)

        # Formula Bar
        formula_box = QHBoxLayout()
        formula_box.addWidget(QLabel("Cell Formula:"))
        self.formula_input = QLineEdit()
        self.formula_input.setPlaceholderText("Select cell or type formula (e.g. =PatMax(A0) or =FindBlobs(A0))")
        self.formula_input.returnPressed.connect(self._on_formula_entered)
        formula_box.addWidget(self.formula_input)
        self.btn_apply_formula = QPushButton("Apply Formula")
        self.btn_apply_formula.clicked.connect(self._on_formula_entered)
        formula_box.addWidget(self.btn_apply_formula)
        right_layout.addLayout(formula_box)

        # Active Spreadsheet Table
        self.table = QTableWidget(1, 6)
        self.table.setHorizontalHeaderLabels(["Run", "Cell", "Label", "Formula", "Result", "Time (ms)"])
        self.table.horizontalHeader().setSectionResizeMode(QHeaderView.ResizeMode.Interactive)
        self.table.horizontalHeader().resizeSection(0, 45)
        self.table.horizontalHeader().resizeSection(1, 55)
        self.table.horizontalHeader().resizeSection(2, 110)
        self.table.horizontalHeader().resizeSection(3, 170)
        self.table.horizontalHeader().resizeSection(4, 220)
        self.table.horizontalHeader().resizeSection(5, 70)
        self.table.itemClicked.connect(self._on_cell_clicked)
        right_layout.addWidget(self.table, 1)

        # Vision Functions Catalog Tabs
        catalog_group = QGroupBox("Industrial Vision Function Catalog (Click to Add & Run)")
        catalog_layout = QVBoxLayout(catalog_group)

        self.catalog_tabs = QTabWidget()
        self._populate_catalog_tabs()
        catalog_layout.addWidget(self.catalog_tabs)

        right_layout.addWidget(catalog_group, 1)

        splitter.addWidget(right_widget)
        splitter.setSizes([850, 590])

        # Status Bar
        self.status = QStatusBar()
        self.setStatusBar(self.status)
        self.status.showMessage("In-Sight Native Mode: Port 1023 | CogNamer UDP: Port 1069 | WebHMI: Port 8080 | Standby: No tools running")

        self._refresh_table_display()

    def _populate_catalog_tabs(self):
        """Builds categorized function cards from the master catalog."""
        categories = {}
        for func in INDUSTRIAL_FUNCTION_CATALOG:
            cat = func["category"]
            if cat not in categories:
                categories[cat] = []
            categories[cat].append(func)

        # Category icons mapping
        icons = {
            "AI & Deep Learning (YOLO)": "🤖 AI / YOLO",
            "Pattern Matching & Alignment": "🎯 Alignment",
            "Presence & Defect Inspection": "🔍 Defects",
            "Edges & Caliper Measurement": "📏 Caliper",
            "Identification & Codes": "🏷️ ID & OCR",
            "Color & Image Filters": "🎨 Filters",
            "Geometry & Coordinate Transforms": "📐 Geometry",
            "Math, Logic & Industrial PLC": "⚖️ Logic & PLC",
            "Industrial PLC & Communications": "📡 PLC & Comms",
        }

        for cat_name, funcs in categories.items():
            scroll = QScrollArea()
            scroll.setWidgetResizable(True)

            if cat_name == "AI & Deep Learning (YOLO)":
                scroll_widget = self._create_yolo_catalog_widget()
                scroll.setWidget(scroll_widget)
                tab_title = icons.get(cat_name, "🤖 AI / YOLO")
                self.catalog_tabs.addTab(scroll, tab_title)
                continue

            scroll_widget = QWidget()
            tab_layout = QVBoxLayout(scroll_widget)
            tab_layout.setContentsMargins(6, 6, 6, 6)
            tab_layout.setSpacing(6)

            for item in funcs:
                card = QFrame()
                card.setStyleSheet("background-color: #202430; border: 1px solid #2d3244; border-radius: 6px; padding: 6px;")
                c_layout = QHBoxLayout(card)
                c_layout.setContentsMargins(8, 4, 8, 4)

                # Info
                info_layout = QVBoxLayout()
                title_lbl = QLabel(f"<b>{item['name']}</b> <span style='color:#8b94a8;'>{item['syntax']}</span>")
                desc_lbl = QLabel(f"<span style='color:#8b94a8; font-size:11px;'>{item['desc']}</span>")
                info_layout.addWidget(title_lbl)
                info_layout.addWidget(desc_lbl)
                c_layout.addLayout(info_layout, 1)

                # Add Button
                btn_add = QPushButton("+ Add to Job")
                btn_add.setFixedWidth(100)
                btn_add.clicked.connect(lambda checked, s=item["syntax"], n=item["name"]: self._add_catalog_function(s, n))
                c_layout.addWidget(btn_add)

                tab_layout.addWidget(card)

            tab_layout.addStretch()
            scroll.setWidget(scroll_widget)
            tab_title = icons.get(cat_name, cat_name)
            self.catalog_tabs.addTab(scroll, tab_title)

    def _create_yolo_catalog_widget(self) -> QWidget:
        """Interactive YOLO deep learning configuration panel."""
        widget = QWidget()
        layout = QVBoxLayout(widget)
        layout.setContentsMargins(10, 10, 10, 10)
        layout.setSpacing(10)

        # Header Card
        header = QFrame()
        header.setStyleSheet("background-color: #151a24; border: 1px solid #00d2ff; border-radius: 6px; padding: 8px;")
        h_layout = QVBoxLayout(header)
        h_layout.setContentsMargins(8, 8, 8, 8)
        title = QLabel("<b style='font-size:13px; color:#00d2ff;'>🤖 YOLOv8 Neural Object Detector</b>")
        desc = QLabel("<span style='color:#8b94a8; font-size:11px;'>Standard ONNX Model • 80 COCO Classes • Lightweight & Fast CPU Inference</span>")
        h_layout.addWidget(title)
        h_layout.addWidget(desc)
        layout.addWidget(header)

        # Form Card
        form = QFrame()
        form.setStyleSheet("background-color: #202430; border: 1px solid #2d3244; border-radius: 6px; padding: 10px;")
        f_layout = QVBoxLayout(form)
        f_layout.setSpacing(10)

        # Target Class Selection
        row_cls = QHBoxLayout()
        lbl_cls = QLabel("<b>Target Class:</b>")
        lbl_cls.setFixedWidth(100)
        row_cls.addWidget(lbl_cls)

        self.yolo_class_combo = QComboBox()
        self.yolo_class_combo.setEditable(True)
        self.yolo_class_combo.addItem("all (Detect Any Object)", "all")

        quick_picks = [
            "person", "bottle", "cup", "cell phone", "chair", "laptop",
            "mouse", "keyboard", "book", "car", "truck", "backpack", "scissors", "clock"
        ]
        for qp in quick_picks:
            self.yolo_class_combo.addItem(qp, qp)

        self.yolo_class_combo.insertSeparator(len(quick_picks) + 1)
        for c in sorted(COCO_CLASSES):
            if c not in quick_picks:
                self.yolo_class_combo.addItem(c, c)

        row_cls.addWidget(self.yolo_class_combo, 1)
        f_layout.addLayout(row_cls)

        # Quick Presets
        presets_row = QHBoxLayout()
        presets_row.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'>Presets:</span>"))
        for p_name, p_val in [("All Classes", "all"), ("Person", "person"), ("Bottle", "bottle"), ("Cup", "cup"), ("Electronics", "cell phone, laptop, mouse, keyboard")]:
            btn_p = QPushButton(p_name)
            btn_p.setStyleSheet("padding: 2px 8px; font-size: 11px;")
            btn_p.clicked.connect(lambda checked, v=p_val: self.yolo_class_combo.setCurrentText(v))
            presets_row.addWidget(btn_p)
        presets_row.addStretch()
        f_layout.addLayout(presets_row)

        # Confidence Slider
        row_conf = QHBoxLayout()
        lbl_conf = QLabel("<b>Confidence:</b>")
        lbl_conf.setFixedWidth(100)
        row_conf.addWidget(lbl_conf)

        self.yolo_conf_slider = QSlider(Qt.Orientation.Horizontal)
        self.yolo_conf_slider.setRange(5, 95)
        self.yolo_conf_slider.setValue(40)
        self.yolo_conf_slider.setTickPosition(QSlider.TickPosition.TicksBelow)
        self.yolo_conf_slider.setTickInterval(10)
        self.yolo_conf_slider.valueChanged.connect(self._on_yolo_slider_changed)
        row_conf.addWidget(self.yolo_conf_slider, 1)

        self.lbl_yolo_conf_val = QLabel("40% (0.40)")
        self.lbl_yolo_conf_val.setStyleSheet("font-weight: 700; color: #00d2ff; min-width: 75px;")
        row_conf.addWidget(self.lbl_yolo_conf_val)
        f_layout.addLayout(row_conf)

        # Action Buttons
        btn_box = QHBoxLayout()
        self.btn_add_yolo = QPushButton("➕ Add YOLO to Job")
        self.btn_add_yolo.setStyleSheet("background-color: #00d2ff; color: #0f1117; font-weight: 700; padding: 6px 14px;")
        self.btn_add_yolo.clicked.connect(self._on_add_yolo_clicked)
        btn_box.addWidget(self.btn_add_yolo)

        self.btn_apply_yolo = QPushButton("🔄 Apply to Selected Cell")
        self.btn_apply_yolo.setStyleSheet("background-color: #202430; border: 1px solid #00d2ff; color: #00d2ff; font-weight: 600; padding: 6px 14px;")
        self.btn_apply_yolo.clicked.connect(self._on_update_selected_yolo_clicked)
        btn_box.addWidget(self.btn_apply_yolo)

        f_layout.addLayout(btn_box)
        layout.addWidget(form)

        # Technical spec badge
        spec_frame = QFrame()
        spec_frame.setStyleSheet("background-color: #141720; border: 1px solid #2d3244; border-radius: 6px; padding: 6px;")
        s_layout = QVBoxLayout(spec_frame)
        s_layout.setContentsMargins(6, 6, 6, 6)
        s_layout.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'>• Model: <b>YOLOv8 Nano</b> (12.7 MB, official ONNX)</span>"))
        s_layout.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'>• Execution: <b>Vectorized CPU ONNXRuntime + OpenCV NMS</b></span>"))
        s_layout.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'>• Formula: <code style='color:#00d2ff;'>=YoloDetect(A0, class=\"all\", conf=0.40)</code></span>"))
        layout.addWidget(spec_frame)

        layout.addStretch()
        return widget

    def _on_yolo_slider_changed(self, val: int):
        self.lbl_yolo_conf_val.setText(f"{val}% ({val/100.0:.2f})")
        if self._selected_coord and self._selected_coord in self.job.cells:
            cell = self.job.cells[self._selected_coord]
            if "YOLO" in cell.formula.upper():
                cls_val = self.yolo_class_combo.currentData() or self.yolo_class_combo.currentText().strip()
                if " (" in cls_val:
                    cls_val = cls_val.split(" (")[0]
                new_formula = f'=YoloDetect(A0, class="{cls_val}", conf={val/100.0:.2f})'
                cell.set_formula(new_formula)
                self.formula_input.setText(f"{cell.coord} = {new_formula}")
                self.job.compile()
                self._refresh_table_display()

    def _on_add_yolo_clicked(self):
        cls_val = self.yolo_class_combo.currentData() or self.yolo_class_combo.currentText().strip()
        if " (" in cls_val:
            cls_val = cls_val.split(" (")[0]
        conf_val = self.yolo_conf_slider.value() / 100.0
        formula = f'=YoloDetect(A0, class="{cls_val}", conf={conf_val:.2f})'
        self._add_catalog_function(formula, f"YOLO ({cls_val})")

    def _on_update_selected_yolo_clicked(self):
        if not self._selected_coord or self._selected_coord not in self.job.cells:
            self._on_add_yolo_clicked()
            return

        cls_val = self.yolo_class_combo.currentData() or self.yolo_class_combo.currentText().strip()
        if " (" in cls_val:
            cls_val = cls_val.split(" (")[0]
        conf_val = self.yolo_conf_slider.value() / 100.0
        formula = f'=YoloDetect(A0, class="{cls_val}", conf={conf_val:.2f})'

        cell = self.job.cells[self._selected_coord]
        cell.set_formula(formula)
        cell.label = f"YOLO ({cls_val})"
        self.formula_input.setText(f"{cell.coord} = {formula}")
        self.job.compile()
        self._refresh_table_display()
        self.status.showMessage(f"Updated cell {cell.coord} to {formula}")

    def _add_catalog_function(self, syntax: str, name: str):
        """Adds a selected vision tool function to the spreadsheet DAG."""
        next_idx = len(self.job.cells)
        col = "B" if next_idx <= 2 else ("C" if next_idx <= 4 else ("D" if next_idx <= 6 else "E"))
        coord = f"{col}{next_idx}"

        # Adjust syntax if formula already exists
        self.job.add_cell(coord, syntax, label=name, enabled=True)
        self.job.compile()
        self._refresh_table_display()
        self.status.showMessage(f"Added function {name} at cell {coord}")

    def _on_clear_tools(self):
        """Resets the job back to standby mode (AcquireImage only)."""
        self._setup_clean_job()
        self._refresh_table_display()
        self.lbl_overall.setText("STANDBY")
        self.lbl_overall.setStyleSheet("font-size: 15px; font-weight: 800; color: #00d2ff; padding: 4px 10px; background: rgba(0,210,255,0.1); border-radius: 6px;")
        self.lbl_stats.setText("Live Stream Active | All tools cleared")
        self.status.showMessage("Cleared all vision tools. Standby mode active.")

    def _refresh_table_display(self):
        """Refreshes the spreadsheet table rows and active checkboxes."""
        cells = list(self.job.cells.values())
        self.table.setRowCount(len(cells))

        for row, c in enumerate(cells):
            # Checkbox in column 0
            chk = QCheckBox()
            chk.setChecked(c.enabled)
            # A0 cannot be unchecked
            if c.coord == "A0":
                chk.setEnabled(False)
            chk.stateChanged.connect(lambda state, cell_ref=c: self._on_cell_enabled_toggled(cell_ref, state))
            chk_widget = QWidget()
            chk_layout = QHBoxLayout(chk_widget)
            chk_layout.addWidget(chk)
            chk_layout.setAlignment(Qt.AlignmentFlag.AlignCenter)
            chk_layout.setContentsMargins(0, 0, 0, 0)
            self.table.setCellWidget(row, 0, chk_widget)

            # Coord & Label
            self.table.setItem(row, 1, QTableWidgetItem(c.coord))
            self.table.setItem(row, 2, QTableWidgetItem(c.label))
            self.table.setItem(row, 3, QTableWidgetItem(c.formula))

            # Display Value
            display_val = ""
            if not c.enabled:
                display_val = "[DISABLED]"
            elif isinstance(c.value, YoloResult):
                if c.value.count == 0:
                    display_val = "0 detected (Searching)"
                else:
                    counts_str = ", ".join(f"{k}:{v}" for k, v in c.value.class_counts.items())
                    display_val = f"Found {c.value.count} ({counts_str})"
            elif hasattr(c.value, "to_dict"):
                d = c.value.to_dict()
                if "score" in d:
                    display_val = f"Score: {d['score']}% (X={d.get('x')}, Y={d.get('y')})"
                elif "count" in d:
                    display_val = f"Count: {d['count']}"
                elif "radius" in d:
                    display_val = f"Radius: {d['radius']}"
                elif "width" in d:
                    display_val = f"Width: {d['width']}"
                elif "text" in d:
                    display_val = f"Text: {d['text']}"
                elif "mean" in d:
                    display_val = f"Mean: {d['mean']}, Peak: {d['peak_bin']}"
                else:
                    display_val = str(d)
            elif isinstance(c.value, np.ndarray):
                display_val = f"Image ({c.value.shape[1]}x{c.value.shape[0]})"
            else:
                display_val = str(c.value)

            val_item = QTableWidgetItem(display_val)
            if c.enabled:
                if c.is_pass is True:
                    val_item.setForeground(QBrush(QColor("#00e676")))
                elif c.is_pass is False:
                    val_item.setForeground(QBrush(QColor("#ff1744")))
            else:
                val_item.setForeground(QBrush(QColor("#6b7280")))
            self.table.setItem(row, 4, val_item)

            self.table.setItem(row, 5, QTableWidgetItem(f"{c.last_exec_ms:.1f}"))

    def _on_cell_enabled_toggled(self, cell: Cell, state: int):
        cell.enabled = (state == 2)
        self.job.compile()

    def _on_cell_clicked(self, item: QTableWidgetItem):
        row = item.row()
        coord_item = self.table.item(row, 1)
        formula_item = self.table.item(row, 3)
        if coord_item and formula_item:
            coord = coord_item.text().strip().upper()
            formula = formula_item.text().strip()
            self._selected_coord = coord
            self.formula_input.setText(f"{coord} = {formula}")

            # If clicked cell is a YOLO cell, synchronize YOLO controls
            if "YOLO" in formula.upper():
                import re
                m_cls = re.search(r'class\s*=\s*["\']([^"\']+)["\']', formula, re.IGNORECASE)
                if m_cls:
                    t_cls = m_cls.group(1).strip()
                    idx = self.yolo_class_combo.findData(t_cls)
                    if idx >= 0:
                        self.yolo_class_combo.setCurrentIndex(idx)
                    else:
                        self.yolo_class_combo.setCurrentText(t_cls)
                m_conf = re.search(r'conf\s*=\s*([0-9.]+)', formula, re.IGNORECASE)
                if m_conf:
                    conf_pct = int(float(m_conf.group(1)) * 100)
                    self.yolo_conf_slider.setValue(conf_pct)

    def _on_formula_entered(self):
        text = self.formula_input.text().strip()
        if "=" in text:
            parts = text.split("=", 1)
            coord = parts[0].strip().upper()
            formula = "=" + parts[1].strip()
            if coord in self.job.cells:
                self.job.cells[coord].set_formula(formula)
            else:
                self.job.add_cell(coord, formula, enabled=True)
            self.job.compile()
            self._refresh_table_display()

    def _on_protocol_changed(self):
        selected_protocol = self.protocol_combo.currentData()
        if selected_protocol == CameraProtocol.USB:
            self.source_edit.setText("0")
        elif selected_protocol == CameraProtocol.RTSP:
            self.source_edit.setText("rtsp://admin:admin123@192.168.1.100:554/live")
        elif selected_protocol == CameraProtocol.HTTP:
            self.source_edit.setText("http://192.168.1.100/snapshot.jpg")
        elif selected_protocol == CameraProtocol.TEST_STREAM:
            self.source_edit.setText("Synthetic Part Simulator")
        self._on_reconnect()

    def _on_reconnect(self):
        self.camera.stop()
        self.camera_config.protocol = self.protocol_combo.currentData()
        self.camera_config.source = self.source_edit.text().strip()
        self.camera = CameraDevice(self.camera_config)
        self.camera.start()

    def trigger_acquisition(self):
        self.camera.trigger()

    def _open_webhmi(self):
        import webbrowser
        webbrowser.open("http://localhost:8080")

    def _open_plc_dialog(self):
        dialog = IndustrialCommsDialog(self.io_manager, self)
        dialog.exec()

    def _on_timer_tick(self):
        frame = self.camera.get_latest_frame()
        if frame is None:
            return

        has_tools = len([c for c in self.job.cells.values() if c.coord != "A0" and c.enabled]) > 0
        self._tick_counter += 1

        # Asynchronous non-blocking inspection execution:
        # Prevents UI stutters and ensures live camera display stays at full FPS (30+ FPS)
        if has_tools:
            if not self._inspecting:
                self._inspecting = True
                def _worker(img):
                    try:
                        self._last_stats = self.job.execute(img)
                        # Asynchronous industrial communication dispatch to PLCs and GPIO
                        self.io_manager.dispatch_results_async(self._last_stats, self.job.cells)
                    except Exception:
                        pass
                    finally:
                        self._inspecting = False

                threading.Thread(target=_worker, args=(frame,), daemon=True).start()

        # Update KPI banner
        if not has_tools:
            self.lbl_overall.setText("STANDBY")
            self.lbl_overall.setStyleSheet("font-size: 15px; font-weight: 800; color: #00d2ff; padding: 4px 10px; background: rgba(0,210,255,0.1); border-radius: 6px;")
            self.lbl_stats.setText(f"FPS: {self.camera.fps:.1f} | Frame: {self.camera.frame_count} | Standby: Select a vision tool to inspect")
        else:
            if self.job.overall_pass:
                self.lbl_overall.setText("INSPECTION PASS")
                self.lbl_overall.setStyleSheet("font-size: 15px; font-weight: 800; color: #00e676; padding: 4px 10px; background: rgba(0,230,118,0.12); border-radius: 6px;")
            else:
                self.lbl_overall.setText("INSPECTION FAIL")
                self.lbl_overall.setStyleSheet("font-size: 15px; font-weight: 800; color: #ff1744; padding: 4px 10px; background: rgba(255,23,68,0.12); border-radius: 6px;")

            stats = self._last_stats or {
                "cycle_time_ms": round(self.job.total_cycle_time_ms, 2),
                "inspections": self.job.total_inspections,
                "pass_count": self.job.total_passed,
                "fail_count": self.job.total_failed,
                "yield_pct": round((self.job.total_passed / max(1, self.job.total_inspections)) * 100.0, 1),
            }
            self.lbl_stats.setText(
                f"FPS: {self.camera.fps:.1f} | Cycle: {stats.get('cycle_time_ms', 0.0)} ms | Total: {stats.get('inspections', 0)} | Pass: {stats.get('pass_count', 0)} | Fail: {stats.get('fail_count', 0)} | Yield: {stats.get('yield_pct', 100.0)}%"
            )

        # Refresh table every 5 ticks (~160ms) to conserve CPU
        if self._tick_counter % 5 == 0:
            self._refresh_table_display()

        # Draw inspection overlays
        display_frame = frame.copy()
        if has_tools:
            self._render_overlays(display_frame)

        self._last_annotated_frame = display_frame

        # Convert OpenCV to Qt QPixmap
        h, w, ch = display_frame.shape
        bytes_per_line = ch * w
        q_img = QImage(display_frame.data, w, h, bytes_per_line, QImage.Format.Format_BGR888)
        pixmap = QPixmap.fromImage(q_img).scaled(
            self.lbl_viewport.size(),
            Qt.AspectRatioMode.KeepAspectRatio,
            Qt.TransformationMode.SmoothTransformation,
        )
        self.lbl_viewport.setPixmap(pixmap)

    def _render_overlays(self, img: np.ndarray):
        """Draws visual annotations onto the frame for enabled cells."""
        try:
            for c in self.job.cells.values():
                if not c.enabled:
                    continue
                val = c.value

                # 1. PatMax Overlay
                if isinstance(val, PatMaxResult):
                    if val.box_points is not None and val.found:
                        color = (0, 230, 118) if val.score >= 0.6 else (0, 100, 255)
                        box = np.int32(val.box_points)
                        cv2.polylines(img, [box], True, color, 2)
                        cx, cy = int(val.x), int(val.y)
                        cv2.drawMarker(img, (cx, cy), color, cv2.MARKER_CROSS, 20, 2)
                        cv2.putText(
                            img,
                            f"PatMax: {val.score*100:.1f}% ({val.angle:.1f} deg)",
                            (cx - 60, cy - 20),
                            cv2.FONT_HERSHEY_SIMPLEX,
                            0.45,
                            color,
                            1,
                            cv2.LINE_AA,
                        )

                # 2. Blob Overlay
                elif isinstance(val, BlobResult):
                    for b in val.blobs:
                        x, y, bw, bh = b.bbox
                        cv2.rectangle(img, (x, y), (x + bw, y + bh), (255, 171, 0), 2)
                        cv2.circle(img, (int(b.cx), int(b.cy)), 4, (0, 210, 255), -1)

                # 3. Caliper Line Overlay
                elif isinstance(val, LineResult):
                    if val.found:
                        p1 = (int(val.p1[0]), int(val.p1[1]))
                        p2 = (int(val.p2[0]), int(val.p2[1]))
                        cv2.line(img, p1, p2, (0, 230, 118), 2)
                        for pt in val.points:
                            cv2.circle(img, (int(pt.x), int(pt.y)), 3, (0, 210, 255), -1)

                # 4. Caliper Circle Overlay
                elif isinstance(val, CircleResult):
                    if val.found:
                        center_pt = (int(val.center[0]), int(val.center[1]))
                        r = int(val.radius)
                        cv2.circle(img, center_pt, r, (0, 230, 118), 2)
                        for pt in val.points:
                            cv2.circle(img, (int(pt.x), int(pt.y)), 3, (0, 210, 255), -1)

                # 5. Caliper Width Overlay
                elif isinstance(val, CaliperWidthResult):
                    if val.found and val.edge1 and val.edge2:
                        p1 = (int(val.edge1.x), int(val.edge1.y))
                        p2 = (int(val.edge2.x), int(val.edge2.y))
                        cv2.line(img, p1, p2, (0, 230, 118), 2)
                        cx, cy = int(val.center[0]), int(val.center[1])
                        cv2.putText(img, f"Width: {val.width:.1f}px", (cx - 40, cy - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (0, 230, 118), 1)

                # 6. EdgeCount Overlay
                elif isinstance(val, EdgeCountResult):
                    for pt in val.edge_points:
                        cv2.drawMarker(img, (int(pt.x), int(pt.y)), (0, 210, 255), cv2.MARKER_TILTED_CROSS, 8, 1)

                # 7. ID Reader Overlay
                elif isinstance(val, CodeResult):
                    if val.found and val.polygon is not None:
                        pts = np.int32(val.polygon)
                        cv2.polylines(img, [pts], True, (0, 230, 118), 2)
                        cv2.putText(
                            img,
                            f"{val.code_type}: {val.text}",
                            (int(pts[0][0]), int(pts[0][1] - 10)),
                            cv2.FONT_HERSHEY_SIMPLEX,
                            0.5,
                            (0, 230, 118),
                            1,
                            cv2.LINE_AA,
                        )

                # 8. OCR Overlay
                elif isinstance(val, OcrResult):
                    if val.found:
                        for (bx, by, bw, bh) in val.boxes:
                            cv2.rectangle(img, (bx, by), (bx + bw, by + bh), (0, 230, 118), 1)
                        if val.boxes:
                            fx, fy = val.boxes[0][0], val.boxes[0][1]
                            cv2.putText(img, f"OCR: {val.text}", (fx, fy - 8), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 230, 118), 1)

                # 9. Flaw Result Overlay
                elif isinstance(val, FlawResult):
                    for (fx, fy, fw, fh) in val.flaw_boxes:
                        cv2.rectangle(img, (fx, fy), (fx + fw, fy + fh), (0, 0, 255), 2)

                # 10. Color Extraction Overlay
                elif isinstance(val, ColorResult):
                    cv2.putText(img, f"Color Pixels: {val.pixel_count} ({val.percentage:.1f}%)", (30, 80),
                                cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 255, 100), 1)

                # 11. YOLO Object Detection Overlay (Crisp Bounding Boxes, Reticles & Badges)
                elif isinstance(val, YoloResult):
                    if val.found:
                        YoloDetectorTool.draw_detections(img, val)
                        summary_str = ", ".join(f"{k}x{v}" for k, v in val.class_counts.items())
                        hud_text = f"YOLOv8: {val.count} objects [{summary_str}]"
                        cv2.putText(img, hud_text, (20, 75), cv2.FONT_HERSHEY_SIMPLEX, 0.55, (0, 230, 118), 2, cv2.LINE_AA)
                    else:
                        cv2.putText(img, "YOLOv8: Searching (0 objects detected)", (20, 75), cv2.FONT_HERSHEY_SIMPLEX, 0.50, (0, 210, 255), 1, cv2.LINE_AA)

        except Exception:
            pass

    def closeEvent(self, event):
        self.camera.stop()
        self.native_server.stop()
        try:
            self.web_server.stop()
        except Exception:
            pass
        try:
            self.io_manager.gpio_client.disconnect()
            self.io_manager.ethernet_client.stop()
            self.io_manager.delta_client.disconnect()
            self.io_manager.siemens_client.disconnect()
            self.io_manager.beckhoff_client.disconnect()
        except Exception:
            pass
        event.accept()


def run_app():
    from PyQt6.QtWidgets import QApplication
    q_app = QApplication.instance() or QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(q_app.exec())


if __name__ == "__main__":
    run_app()
