"""Industrial Remote Output & Signal Configuration Dialog.

Allows industrial operators to customize which output metric, measurement,
or AI detection signal is sent to remote industrial devices (PLCs, Ethernet, GPIO).
Supports:
- Pass/Fail boolean signals
- Continuous calibrated measurements (Length, Width, Area, Diameter, etc.)
- YOLO single-class filtering (e.g., Signal #1 for 'person', Signal #2 for 'bottle')
- YOLO combined detection signals (all objects)
- YOLO multi-class discrete signal mapping table
- Feature count, centroid coordinates (X, Y), OCR text, or custom register values.
"""

from __future__ import annotations
import copy
from typing import Any, Dict, List, Optional

from PyQt6.QtCore import Qt, pyqtSignal
from PyQt6.QtGui import QFont, QColor
from PyQt6.QtWidgets import (
    QDialog,
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QGridLayout,
    QLabel,
    QComboBox,
    QSpinBox,
    QDoubleSpinBox,
    QCheckBox,
    QLineEdit,
    QPushButton,
    QTableWidget,
    QTableWidgetItem,
    QHeaderView,
    QFrame,
    QGroupBox,
    QStackedWidget,
    QMessageBox,
)

from pipeline_engine import PipelineStep
from tools.yolo_detector import COCO_CLASSES


class OutputSignalConfigDialog(QDialog):
    """Modal dialog to configure the remote output signal for any pipeline step."""

    signal_configured = pyqtSignal(int, dict)  # (step_id, output_config)

    def __init__(self, step: PipelineStep, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.step = step
        self.config: Dict[str, Any] = copy.deepcopy(getattr(step, "output_config", {}) or {})
        
        # Ensure default keys
        if "mode" not in self.config:
            self.config["mode"] = self._detect_default_mode()
        if "signal_id" not in self.config:
            self.config["signal_id"] = 1
        if "target_metric" not in self.config:
            self.config["target_metric"] = "length"
        if "target_class" not in self.config:
            self.config["target_class"] = "all"
        if "class_signals" not in self.config:
            self.config["class_signals"] = {"person": 1, "bottle": 2, "car": 3}
        if "custom_val" not in self.config:
            self.config["custom_val"] = 1.0

        self.setWindowTitle(f"Remote Output Signal - Step #{step.step_id} ({step.operation_name})")
        self.resize(600, 560)
        self.setMinimumSize(540, 480)
        self.setStyleSheet("""
            QDialog {
                background-color: #16191D;
                color: #E0E6ED;
                font-family: 'Segoe UI', sans-serif;
                font-size: 9pt;
            }
            QGroupBox {
                border: 1px solid #2B323D;
                border-radius: 8px;
                margin-top: 14px;
                padding-top: 14px;
                font-weight: 700;
                color: #00D2FF;
                background-color: #1A1F26;
            }
            QGroupBox::title {
                subcontrol-origin: margin;
                subcontrol-position: top left;
                padding: 0 8px;
                color: #00D2FF;
            }
            QLabel {
                color: #E0E6ED;
            }
            QComboBox, QSpinBox, QDoubleSpinBox, QLineEdit {
                background-color: #1F242D;
                color: #00D2FF;
                border: 1px solid #363E4E;
                border-radius: 5px;
                padding: 5px 8px;
                font-family: 'Consolas', monospace;
                font-size: 9pt;
            }
            QComboBox:focus, QSpinBox:focus, QDoubleSpinBox:focus, QLineEdit:focus {
                border-color: #00D2FF;
            }
            QComboBox QAbstractItemView {
                background-color: #1F242D;
                color: #E0E6ED;
                selection-background-color: #00D2FF;
                selection-color: #0B0D13;
            }
            QTableWidget {
                background-color: #121417;
                border: 1px solid #2B323D;
                border-radius: 6px;
                gridline-color: #2B323D;
                color: #E0E6ED;
                font-family: 'Consolas', monospace;
                font-size: 8.5pt;
            }
            QHeaderView::section {
                background-color: #1F242D;
                color: #8C9BAE;
                font-weight: 700;
                padding: 4px;
                border: 1px solid #2B323D;
            }
            QPushButton {
                background-color: #242A35;
                border: 1px solid #363E4E;
                color: #E0E6ED;
                font-weight: 600;
                padding: 6px 14px;
                border-radius: 5px;
            }
            QPushButton:hover {
                background-color: #2F3746;
                border-color: #00D2FF;
                color: #00D2FF;
            }
            QPushButton#btnSave {
                background-color: #00E676;
                color: #0B0D13;
                font-weight: 700;
                border-color: #00C853;
            }
            QPushButton#btnSave:hover {
                background-color: #69F0AE;
                color: #000000;
            }
        """)

        self._init_ui()
        self._update_live_preview()

    def _detect_default_mode(self) -> str:
        op = (self.step.operation_name or "").lower()
        cat = (self.step.category or "").lower()
        if "yolo" in op or "yolo" in cat or "neural" in op:
            return "yolo_class"
        elif "caliper" in op or "measurement" in op:
            return "measurement"
        elif "ocr" in op or "barcode" in op:
            return "text"
        elif "shape" in op or "contour" in op or "blob" in op:
            return "count"
        return "default"

    def _init_ui(self):
        main_layout = QVBoxLayout(self)
        main_layout.setSpacing(10)
        main_layout.setContentsMargins(14, 14, 14, 14)

        # Header Info Card
        hdr_frame = QFrame()
        hdr_frame.setStyleSheet("background-color: #1F242D; border: 1px solid #2B323D; border-radius: 6px; padding: 8px;")
        hdr_layout = QVBoxLayout(hdr_frame)
        hdr_layout.setSpacing(4)

        lbl_title = QLabel(f"Step #{self.step.step_id}: {self.step.name}")
        lbl_title.setStyleSheet("font-size: 11pt; font-weight: 800; color: #00D2FF;")
        hdr_layout.addWidget(lbl_title)

        lbl_sub = QLabel(f"Category: {self.step.category}  |  Operation: {self.step.operation_name}")
        lbl_sub.setStyleSheet("font-size: 8.5pt; color: #8C9BAE;")
        hdr_layout.addWidget(lbl_sub)

        # Checkbox: Enable remote dispatch
        self.chk_remote = QCheckBox("🔗 Enable Remote Dispatch for this Step (Sends to PLCs / Ethernet / GPIO)")
        self.chk_remote.setChecked(getattr(self.step, "link_to_remote", False))
        self.chk_remote.setStyleSheet("color: #00E676; font-weight: 700; margin-top: 4px;")
        hdr_layout.addWidget(self.chk_remote)

        main_layout.addWidget(hdr_frame)

        # Output Signal Mode Selector
        mode_group = QGroupBox("Signal Mode & Output Target")
        mode_layout = QGridLayout(mode_group)
        mode_layout.setSpacing(8)

        mode_layout.addWidget(QLabel("Output Signal Type:"), 0, 0)
        self.combo_mode = QComboBox()
        self.combo_mode.addItem("⚡ Standard Pass / Fail Logic (Signal 1 on Pass, 0 on Fail)", "default")
        self.combo_mode.addItem("📏 Calibrated Measurement Value (Length, Width, Area, etc.)", "measurement")
        self.combo_mode.addItem("🤖 YOLO: Specific Object Class (Filter by Class)", "yolo_class")
        self.combo_mode.addItem("📦 YOLO: Combined (Any Object Triggers Combined Signal)", "yolo_combined")
        self.combo_mode.addItem("🔀 YOLO: Multi-Class Signal Map (Different Signals per Class)", "yolo_multiclass")
        self.combo_mode.addItem("🔢 Quantity Count (Object / Blob / Feature Count)", "count")
        self.combo_mode.addItem("📍 Centroid Coordinates (X, Y Position)", "coordinates")
        self.combo_mode.addItem("🏷️ Text / Decoded String (OCR / Barcode / Tag)", "text")
        self.combo_mode.addItem("⚙ Custom Numeric Signal Code", "custom")

        # Set current mode
        cur_mode = self.config.get("mode", "default")
        idx = self.combo_mode.findData(cur_mode)
        if idx >= 0:
            self.combo_mode.setCurrentIndex(idx)
        else:
            self.combo_mode.setCurrentIndex(0)
        self.combo_mode.currentIndexChanged.connect(self._on_mode_changed)
        mode_layout.addWidget(self.combo_mode, 0, 1)

        main_layout.addWidget(mode_group)

        # Stacked Widget for Mode-Specific Configurations
        self.stack = QStackedWidget()

        # Page 0: Default Pass/Fail
        p0 = QWidget()
        p0_layout = QVBoxLayout(p0)
        lbl_p0 = QLabel("• Sends high/true (1) when step status is OK and low/false (0) on error or defect.\n• Automatically maps to PLC M-Coil, Siemens DB byte 0, Beckhoff offset, and GPIO PASS/FAIL pins.")
        lbl_p0.setStyleSheet("color: #8C9BAE; font-size: 8.5pt;")
        p0_layout.addWidget(lbl_p0)
        self.stack.addWidget(p0)

        # Page 1: Measurement Value
        p1 = QWidget()
        p1_layout = QGridLayout(p1)
        p1_layout.addWidget(QLabel("Target Measurement Metric:"), 0, 0)
        self.combo_metric = QComboBox()
        self.combo_metric.addItem("Length (Calibrated mm / px)", "length")
        self.combo_metric.addItem("Width (Calibrated mm / px)", "width")
        self.combo_metric.addItem("Surface Area (Calibrated mm² / px²)", "area")
        self.combo_metric.addItem("Diameter (Calibrated mm / px)", "diameter")
        self.combo_metric.addItem("Deviation from Target (mm)", "deviation")
        cur_m = self.config.get("target_metric", "length")
        m_idx = self.combo_metric.findData(cur_m)
        if m_idx >= 0:
            self.combo_metric.setCurrentIndex(m_idx)
        p1_layout.addWidget(self.combo_metric, 0, 1)

        p1_layout.addWidget(QLabel("PLC Register Offset / Signal ID:"), 1, 0)
        self.spin_meas_sig = QSpinBox()
        self.spin_meas_sig.setRange(1, 65535)
        self.spin_meas_sig.setValue(int(self.config.get("signal_id", 1)))
        p1_layout.addWidget(self.spin_meas_sig, 1, 1)

        self.chk_meas_tol = QCheckBox("Send active signal ONLY if measurement is within tolerance")
        self.chk_meas_tol.setChecked(bool(self.config.get("tolerance_only", True)))
        p1_layout.addWidget(self.chk_meas_tol, 2, 0, 1, 2)
        self.stack.addWidget(p1)

        # Page 2: YOLO Single Class Filter
        p2 = QWidget()
        p2_layout = QGridLayout(p2)
        p2_layout.addWidget(QLabel("Target Object Class:"), 0, 0)
        self.combo_yolo_class = QComboBox()
        self.combo_yolo_class.addItem("All Detected Objects (Any)", "all")
        for c in COCO_CLASSES:
            self.combo_yolo_class.addItem(f"{c.title()} ({c})", c)
        cur_cls = self.config.get("target_class", "person")
        c_idx = self.combo_yolo_class.findData(cur_cls)
        if c_idx >= 0:
            self.combo_yolo_class.setCurrentIndex(c_idx)
        p2_layout.addWidget(self.combo_yolo_class, 0, 1)

        p2_layout.addWidget(QLabel("Remote Signal ID (Code / Pin):"), 1, 0)
        self.spin_yolo_sig = QSpinBox()
        self.spin_yolo_sig.setRange(1, 255)
        self.spin_yolo_sig.setValue(int(self.config.get("signal_id", 1)))
        p2_layout.addWidget(self.spin_yolo_sig, 1, 1)

        self.chk_invert_class = QCheckBox("Invert Logic: Signal when target class is NOT detected (Missing item)")
        self.chk_invert_class.setChecked(bool(self.config.get("invert_logic", False)))
        p2_layout.addWidget(self.chk_invert_class, 2, 0, 1, 2)
        self.stack.addWidget(p2)

        # Page 3: YOLO Combined Signal
        p3 = QWidget()
        p3_layout = QGridLayout(p3)
        p3_layout.addWidget(QLabel("Signal ID for Combined Objects:"), 0, 0)
        self.spin_comb_sig = QSpinBox()
        self.spin_comb_sig.setRange(1, 255)
        self.spin_comb_sig.setValue(int(self.config.get("signal_id", 1)))
        p3_layout.addWidget(self.spin_comb_sig, 0, 1)

        p3_layout.addWidget(QLabel("Minimum Object Count Threshold:"), 1, 0)
        self.spin_comb_thresh = QSpinBox()
        self.spin_comb_thresh.setRange(1, 1000)
        self.spin_comb_thresh.setValue(int(self.config.get("min_count", 1)))
        p3_layout.addWidget(self.spin_comb_thresh, 1, 1)
        self.stack.addWidget(p3)

        # Page 4: YOLO Multi-Class Signal Map
        p4 = QWidget()
        p4_layout = QVBoxLayout(p4)
        lbl_p4_desc = QLabel("Assign distinct numeric signal codes for each detected object class:")
        lbl_p4_desc.setStyleSheet("color: #8C9BAE; font-size: 8.5pt;")
        p4_layout.addWidget(lbl_p4_desc)

        self.table_classes = QTableWidget(0, 2)
        self.table_classes.setHorizontalHeaderLabels(["Detected Class Name", "Remote Signal ID (Code / Coil)"])
        self.table_classes.horizontalHeader().setSectionResizeMode(0, QHeaderView.ResizeMode.Stretch)
        self.table_classes.horizontalHeader().setSectionResizeMode(1, QHeaderView.ResizeMode.Interactive)
        self.table_classes.setColumnWidth(1, 160)
        p4_layout.addWidget(self.table_classes, 1)

        # Populate class map
        class_map = self.config.get("class_signals", {"person": 1, "bottle": 2, "car": 3})
        for c_name, sig in class_map.items():
            self._add_class_row(c_name, sig)

        # Row add controls
        add_box = QHBoxLayout()
        self.edit_new_class = QComboBox()
        self.edit_new_class.setEditable(True)
        for c in COCO_CLASSES:
            self.edit_new_class.addItem(c)
        add_box.addWidget(self.edit_new_class, 1)

        self.spin_new_sig = QSpinBox()
        self.spin_new_sig.setRange(1, 255)
        self.spin_new_sig.setValue(len(class_map) + 1)
        add_box.addWidget(self.spin_new_sig)

        btn_add_cls = QPushButton("+ Add Class")
        btn_add_cls.clicked.connect(self._on_add_class_click)
        add_box.addWidget(btn_add_cls)

        btn_del_cls = QPushButton("- Remove")
        btn_del_cls.clicked.connect(self._on_del_class_click)
        add_box.addWidget(btn_del_cls)

        p4_layout.addLayout(add_box)
        self.stack.addWidget(p4)

        # Page 5: Count
        p5 = QWidget()
        p5_layout = QGridLayout(p5)
        p5_layout.addWidget(QLabel("Remote Signal ID:"), 0, 0)
        self.spin_cnt_sig = QSpinBox()
        self.spin_cnt_sig.setRange(1, 255)
        self.spin_cnt_sig.setValue(int(self.config.get("signal_id", 1)))
        p5_layout.addWidget(self.spin_cnt_sig, 0, 1)
        self.stack.addWidget(p5)

        # Page 6: Coordinates
        p6 = QWidget()
        p6_layout = QGridLayout(p6)
        p6_layout.addWidget(QLabel("Output Coordinates Format:"), 0, 0)
        self.combo_coords = QComboBox()
        self.combo_coords.addItem("Centroid (X, Y) Floating-Point Registers", "xy")
        self.combo_coords.addItem("X Position Only", "x")
        self.combo_coords.addItem("Y Position Only", "y")
        p6_layout.addWidget(self.combo_coords, 0, 1)
        self.stack.addWidget(p6)

        # Page 7: Text / String
        p7 = QWidget()
        p7_layout = QVBoxLayout(p7)
        lbl_p7 = QLabel("• Transmits decoded OCR text, barcode, or QR code string via Ethernet JSON payload.\n• PLC D-registers receive character count or hash code.")
        lbl_p7.setStyleSheet("color: #8C9BAE; font-size: 8.5pt;")
        p7_layout.addWidget(lbl_p7)
        self.stack.addWidget(p7)

        # Page 8: Custom Numeric Signal
        p8 = QWidget()
        p8_layout = QGridLayout(p8)
        p8_layout.addWidget(QLabel("Custom Signal ID:"), 0, 0)
        self.spin_cust_sig = QSpinBox()
        self.spin_cust_sig.setRange(1, 65535)
        self.spin_cust_sig.setValue(int(self.config.get("signal_id", 1)))
        p8_layout.addWidget(self.spin_cust_sig, 0, 1)

        p8_layout.addWidget(QLabel("Custom Value:"), 1, 0)
        self.spin_cust_val = QDoubleSpinBox()
        self.spin_cust_val.setRange(-999999.0, 999999.0)
        self.spin_cust_val.setValue(float(self.config.get("custom_val", 1.0)))
        p8_layout.addWidget(self.spin_cust_val, 1, 1)
        self.stack.addWidget(p8)

        # Container Group
        container = QGroupBox("Signal Parameters & Rules")
        c_layout = QVBoxLayout(container)
        c_layout.addWidget(self.stack)
        main_layout.addWidget(container, 1)

        # Live Signal Preview Card
        prev_card = QFrame()
        prev_card.setStyleSheet("background-color: #121417; border: 1px solid #2B323D; border-radius: 6px; padding: 6px;")
        prev_layout = QHBoxLayout(prev_card)
        self.lbl_preview = QLabel("Live Signal Preview: Computing...")
        self.lbl_preview.setStyleSheet("color: #00E676; font-family: 'Consolas', monospace; font-size: 8.5pt; font-weight: 700;")
        prev_layout.addWidget(self.lbl_preview)
        main_layout.addWidget(prev_card)

        # Dialog Buttons
        btn_layout = QHBoxLayout()
        btn_layout.addStretch()

        self.btn_cancel = QPushButton("Cancel")
        self.btn_cancel.clicked.connect(self.reject)
        btn_layout.addWidget(self.btn_cancel)

        self.btn_save = QPushButton("💾 Save & Apply Signal")
        self.btn_save.setObjectName("btnSave")
        self.btn_save.clicked.connect(self._on_save)
        btn_layout.addWidget(self.btn_save)

        main_layout.addLayout(btn_layout)

        # Set initial stack page
        self._on_mode_changed(self.combo_mode.currentIndex())

    def _add_class_row(self, class_name: str, signal_id: int):
        row = self.table_classes.rowCount()
        self.table_classes.insertRow(row)
        item_name = QTableWidgetItem(str(class_name))
        item_name.setForeground(QColor("#00D2FF"))
        self.table_classes.setItem(row, 0, item_name)

        spin = QSpinBox()
        spin.setRange(1, 255)
        spin.setValue(int(signal_id))
        self.table_classes.setCellWidget(row, 1, spin)

    def _on_add_class_click(self):
        cls_name = self.edit_new_class.currentText().strip().lower()
        if not cls_name:
            return
        sig = self.spin_new_sig.value()
        self._add_class_row(cls_name, sig)
        self.spin_new_sig.setValue(sig + 1)
        self._update_live_preview()

    def _on_del_class_click(self):
        cur = self.table_classes.currentRow()
        if cur >= 0:
            self.table_classes.removeRow(cur)
            self._update_live_preview()

    def _on_mode_changed(self, index: int):
        mode = self.combo_mode.currentData()
        mapping = {
            "default": 0,
            "measurement": 1,
            "yolo_class": 2,
            "yolo_combined": 3,
            "yolo_multiclass": 4,
            "count": 5,
            "coordinates": 6,
            "text": 7,
            "custom": 8,
        }
        page_idx = mapping.get(mode, 0)
        self.stack.setCurrentIndex(page_idx)
        self._update_live_preview()

    def _update_live_preview(self):
        # Temporarily apply config to step to preview evaluation
        mode = self.combo_mode.currentData()
        cfg = self._build_config_dict()
        old_cfg = self.step.output_config
        self.step.output_config = cfg
        try:
            eval_res = self.step.evaluate_output_signal()
            act_str = "ACTIVE (TRUE)" if eval_res["active"] else "INACTIVE (FALSE)"
            sig_val = eval_res["numeric_value"]
            disp = eval_res["display_str"]
            self.lbl_preview.setText(f"Live Output Preview: [{act_str}] | Signal #{eval_res['signal_id']} | Value: {sig_val} | Display: {disp}")
        except Exception as e:
            self.lbl_preview.setText(f"Live Output Preview: Mode={mode} (Ready to dispatch)")
        finally:
            self.step.output_config = old_cfg

    def _build_config_dict(self) -> Dict[str, Any]:
        mode = self.combo_mode.currentData()
        cfg: Dict[str, Any] = {"mode": mode}

        if mode == "default":
            cfg["signal_id"] = 1

        elif mode == "measurement":
            cfg["target_metric"] = self.combo_metric.currentData()
            cfg["signal_id"] = self.spin_meas_sig.value()
            cfg["tolerance_only"] = self.chk_meas_tol.isChecked()

        elif mode == "yolo_class":
            cfg["target_class"] = self.combo_yolo_class.currentData()
            cfg["signal_id"] = self.spin_yolo_sig.value()
            cfg["invert_logic"] = self.chk_invert_class.isChecked()

        elif mode == "yolo_combined":
            cfg["signal_id"] = self.spin_comb_sig.value()
            cfg["min_count"] = self.spin_comb_thresh.value()

        elif mode == "yolo_multiclass":
            class_map = {}
            for r in range(self.table_classes.rowCount()):
                name_item = self.table_classes.item(r, 0)
                spin_widget = self.table_classes.cellWidget(r, 1)
                if name_item and spin_widget:
                    class_map[name_item.text().strip().lower()] = spin_widget.value()
            cfg["class_signals"] = class_map
            cfg["signal_id"] = list(class_map.values())[0] if class_map else 1

        elif mode == "count":
            cfg["signal_id"] = self.spin_cnt_sig.value()

        elif mode == "coordinates":
            cfg["coords_format"] = self.combo_coords.currentData()
            cfg["signal_id"] = 1

        elif mode == "text":
            cfg["signal_id"] = 1

        elif mode == "custom":
            cfg["signal_id"] = self.spin_cust_sig.value()
            cfg["custom_val"] = self.spin_cust_val.value()

        return cfg

    def get_config(self) -> Dict[str, Any]:
        """Returns the full output configuration dictionary with link_to_remote."""
        cfg = self._build_config_dict()
        cfg["link_to_remote"] = self.chk_remote.isChecked()
        return cfg

    def _on_save(self):
        cfg = self.get_config()
        self.step.output_config = cfg
        self.step.link_to_remote = self.chk_remote.isChecked()
        self.signal_configured.emit(self.step.step_id, cfg)
        self.accept()
