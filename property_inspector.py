"""Dynamic Property Inspector Drawer for Industrial Pipeline Parameters.

Generates native PyQt6 interactive controls from parameter schemas with
synchronized sliders, spinboxes, choices, and debounced live tuning signals.
"""

from __future__ import annotations
from typing import Any, Dict, Optional
from PyQt6.QtCore import Qt, QTimer, pyqtSignal
from PyQt6.QtWidgets import (
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QLabel,
    QSlider,
    QSpinBox,
    QDoubleSpinBox,
    QCheckBox,
    QComboBox,
    QLineEdit,
    QPushButton,
    QScrollArea,
    QFrame,
    QSizePolicy,
)

from pipeline_engine import ParamSchema, ParamType, PipelineStep
from ui.output_signal_dialog import OutputSignalConfigDialog


class PropertyInspectorDrawer(QWidget):
    """Dynamic form generator displaying context-sensitive parameters for a selected pipeline step."""

    # Signals: (step_id, param_name, new_value)
    parameter_changed = pyqtSignal(int, str, object)
    reset_defaults_requested = pyqtSignal(int)
    remote_link_toggled = pyqtSignal(int, bool)
    configure_remote_requested = pyqtSignal()
    output_config_changed = pyqtSignal(int, dict)

    def __init__(self, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.current_step: Optional[PipelineStep] = None
        self._controls: Dict[str, QWidget] = {}
        self._pending_updates: Dict[str, Any] = {}

        # 30ms live tuning debounce timer to ensure silky smooth 60 FPS UI
        self._debounce_timer = QTimer(self)
        self._debounce_timer.setSingleShot(True)
        self._debounce_timer.setInterval(30)
        self._debounce_timer.timeout.connect(self._flush_debounced_updates)

        self._init_ui()

    def _init_ui(self):
        main_layout = QVBoxLayout(self)
        main_layout.setContentsMargins(10, 10, 10, 10)
        main_layout.setSpacing(8)

        # Header Card
        self.header_card = QFrame()
        self.header_card.setObjectName("inspectorHeaderCard")
        self.header_card.setStyleSheet("""
            QFrame#inspectorHeaderCard {
                background-color: #1F242D;
                border: 1px solid #2B323D;
                border-radius: 8px;
                padding: 10px;
            }
        """)
        header_layout = QVBoxLayout(self.header_card)
        header_layout.setContentsMargins(8, 8, 8, 8)
        header_layout.setSpacing(4)

        self.lbl_title = QLabel("Property Inspector")
        self.lbl_title.setStyleSheet("font-size: 11pt; font-weight: 800; color: #00D2FF;")
        header_layout.addWidget(self.lbl_title)

        self.lbl_subtitle = QLabel("Select a step to inspect parameters")
        self.lbl_subtitle.setStyleSheet("font-size: 8.5pt; color: #8C9BAE;")
        header_layout.addWidget(self.lbl_subtitle)

        self.lbl_desc = QLabel("")
        self.lbl_desc.setWordWrap(True)
        self.lbl_desc.setStyleSheet("font-size: 8.5pt; color: #B0BAC9; font-style: italic; margin-top: 4px;")
        header_layout.addWidget(self.lbl_desc)

        main_layout.addWidget(self.header_card)

        # Scrollable Area for Dynamic Parameters
        self.scroll_area = QScrollArea()
        self.scroll_area.setWidgetResizable(True)
        self.scroll_area.setFrameShape(QFrame.Shape.NoFrame)
        self.scroll_area.setStyleSheet("""
            QScrollArea {
                background: transparent;
                border: none;
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
        """)

        self.form_container = QWidget()
        self.form_container.setObjectName("formContainer")
        self.form_container.setStyleSheet("background: transparent;")
        self.form_layout = QVBoxLayout(self.form_container)
        self.form_layout.setContentsMargins(4, 4, 4, 4)
        self.form_layout.setSpacing(12)
        self.form_layout.setAlignment(Qt.AlignmentFlag.AlignTop)
        self.form_layout.addWidget(self._create_empty_placeholder())

        self.scroll_area.setWidget(self.form_container)
        main_layout.addWidget(self.scroll_area, 1)

        # Bottom Action Bar
        self.footer_frame = QFrame()
        footer_layout = QHBoxLayout(self.footer_frame)
        footer_layout.setContentsMargins(0, 4, 0, 0)

        self.btn_reset = QPushButton("⟲ Reset to Defaults")
        self.btn_reset.setObjectName("btnResetParams")
        self.btn_reset.setStyleSheet("""
            QPushButton#btnResetParams {
                background-color: #242A35;
                border: 1px solid #363E4E;
                color: #B0BAC9;
                font-weight: 600;
                padding: 6px 14px;
                border-radius: 6px;
            }
            QPushButton#btnResetParams:hover {
                background-color: #2F3746;
                color: #00D2FF;
                border-color: #00D2FF;
            }
        """)
        self.btn_reset.clicked.connect(self._on_reset_clicked)
        self.btn_reset.setEnabled(False)
        footer_layout.addWidget(self.btn_reset)

        main_layout.addWidget(self.footer_frame)

    def _create_empty_placeholder(self) -> QLabel:
        lbl = QLabel("👉 Click on any row in the pipeline spreadsheet to view and edit its parameters in real-time.")
        lbl.setWordWrap(True)
        lbl.setAlignment(Qt.AlignmentFlag.AlignCenter)
        lbl.setStyleSheet("color: #5A6678; font-size: 9pt; padding: 30px;")
        return lbl

    def inspect_step(self, step: Optional[PipelineStep]):
        """Builds interactive UI controls corresponding to the step's operation schema."""
        self._flush_debounced_updates()
        self.current_step = step
        self._controls.clear()
        self._pending_updates.clear()

        # Clear existing form widgets safely
        while self.form_layout.count():
            item = self.form_layout.takeAt(0)
            w = item.widget()
            if w:
                w.deleteLater()

        if step is None or step.operation is None:
            self.lbl_title.setText("Property Inspector")
            self.lbl_subtitle.setText("No step selected")
            self.lbl_desc.setText("")
            self.btn_reset.setEnabled(False)
            self.form_layout.addWidget(self._create_empty_placeholder())
            return

        self.btn_reset.setEnabled(True)
        self.lbl_title.setText(f"Step #{step.step_id}: {step.name}")
        self.lbl_subtitle.setText(f"Category: {step.category}  |  Op: {step.operation_name}")
        self.lbl_desc.setText(step.operation.description)

        # Remote Output & Signal Configuration Card
        remote_card = QFrame()
        remote_card.setStyleSheet("""
            QFrame {
                background-color: #1F242D;
                border: 1px solid #2B323D;
                border-radius: 6px;
                padding: 6px;
            }
        """)
        rc_layout = QVBoxLayout(remote_card)
        rc_layout.setContentsMargins(8, 8, 8, 8)
        rc_layout.setSpacing(6)

        rc_top = QHBoxLayout()
        chk_remote = QCheckBox("🔗 Remote Device Output (PLC / Ethernet / GPIO)")
        chk_remote.setChecked(getattr(step, "link_to_remote", False))
        chk_remote.setStyleSheet("font-size: 8.5pt; font-weight: 700; color: #00D2FF;")
        rc_top.addWidget(chk_remote, 1)

        btn_cfg_ip = QPushButton("📡 IPs...")
        btn_cfg_ip.setToolTip("Configure remote device IP addresses & protocols (Modbus, S7, ADS, TCP/UDP)")
        btn_cfg_ip.setStyleSheet("""
            QPushButton {
                background-color: #242A35;
                color: #8C9BAE;
                border: 1px solid #363E4E;
                font-weight: 700;
                font-size: 8pt;
                padding: 4px 8px;
                border-radius: 4px;
            }
            QPushButton:hover {
                background-color: #2F3746;
                color: #00D2FF;
                border-color: #00D2FF;
            }
        """)
        btn_cfg_ip.clicked.connect(self.configure_remote_requested.emit)
        rc_top.addWidget(btn_cfg_ip)
        rc_layout.addLayout(rc_top)

        def _get_summary_html() -> str:
            summary = step.get_output_summary()
            is_linked = getattr(step, "link_to_remote", False)
            link_tag = "<span style='color:#00E676; font-weight:bold;'>[LINKED]</span> " if is_linked else "<span style='color:#8C9BAE;'>[OFFLINE]</span> "
            return f"<span style='color:#B0BAC9; font-size:8pt;'>Signal: {link_tag}<b style='color:#00D2FF;'>{summary}</b></span>"

        lbl_signal_summary = QLabel(_get_summary_html())
        lbl_signal_summary.setWordWrap(True)
        lbl_signal_summary.setStyleSheet("""
            background: #16191D;
            border: 1px solid #2B323D;
            border-radius: 4px;
            padding: 5px 8px;
        """)
        rc_layout.addWidget(lbl_signal_summary)

        btn_cfg_signal = QPushButton("⚙ Configure Output Signal / Function...")
        btn_cfg_signal.setToolTip("Select output measurement, YOLO object class trigger, or custom signal code sent to remote devices.")
        btn_cfg_signal.setStyleSheet("""
            QPushButton {
                background-color: #1F3044;
                color: #00E676;
                border: 1px solid #00E676;
                font-weight: 700;
                font-size: 8.5pt;
                padding: 5px 10px;
                border-radius: 5px;
            }
            QPushButton:hover {
                background-color: #26405C;
                color: #69F0AE;
                border-color: #69F0AE;
            }
        """)

        def _on_config_signal_clicked():
            dlg = OutputSignalConfigDialog(step, parent=self)
            if dlg.exec():
                new_cfg = dlg.get_config()
                step.output_config = new_cfg
                step.link_to_remote = new_cfg.get("link_to_remote", step.link_to_remote)
                chk_remote.setChecked(step.link_to_remote)
                lbl_signal_summary.setText(_get_summary_html())
                self.output_config_changed.emit(step.step_id, new_cfg)
                self.remote_link_toggled.emit(step.step_id, step.link_to_remote)

        btn_cfg_signal.clicked.connect(_on_config_signal_clicked)
        rc_layout.addWidget(btn_cfg_signal)

        def _on_remote_toggle(checked: bool):
            step.link_to_remote = checked
            if not hasattr(step, "output_config") or not isinstance(step.output_config, dict):
                step.output_config = {}
            step.output_config["link_to_remote"] = checked
            lbl_signal_summary.setText(_get_summary_html())
            self.remote_link_toggled.emit(step.step_id, checked)
            self.output_config_changed.emit(step.step_id, step.output_config)

        chk_remote.toggled.connect(_on_remote_toggle)

        self.form_layout.addWidget(remote_card)

        schemas = step.operation.param_schemas
        if not schemas:
            no_params_lbl = QLabel("This operation does not require configurable parameters.")
            no_params_lbl.setStyleSheet("color: #7D8A9D; font-style: italic; padding: 12px;")
            self.form_layout.addWidget(no_params_lbl)
            return

        for schema in schemas:
            param_widget = self._create_param_widget(step, schema)
            self.form_layout.addWidget(param_widget)

    def _create_param_widget(self, step: PipelineStep, schema: ParamSchema) -> QWidget:
        card = QFrame()
        card.setStyleSheet("""
            QFrame {
                background-color: #1F242D;
                border: 1px solid #2B323D;
                border-radius: 6px;
                padding: 6px;
            }
        """)
        layout = QVBoxLayout(card)
        layout.setContentsMargins(8, 6, 8, 6)
        layout.setSpacing(6)

        # Label Row
        top_row = QHBoxLayout()
        lbl_name = QLabel(schema.label)
        lbl_name.setStyleSheet("font-weight: 700; color: #E0E6ED; font-size: 8.5pt;")
        if schema.description:
            lbl_name.setToolTip(schema.description)
        top_row.addWidget(lbl_name)
        top_row.addStretch()

        current_val = step.params.get(schema.name, schema.default)

        # 1. INT: Slider + SpinBox
        if schema.param_type == ParamType.INT:
            min_v = int(schema.min_val if schema.min_val is not None else 0)
            max_v = int(schema.max_val if schema.max_val is not None else 100)
            step_v = int(schema.step if schema.step is not None else 1)

            spin = QSpinBox()
            spin.setRange(min_v, max_v)
            spin.setSingleStep(step_v)
            spin.setValue(int(current_val))
            spin.setStyleSheet("""
                QSpinBox {
                    background-color: #16191D;
                    color: #00D2FF;
                    border: 1px solid #363E4E;
                    border-radius: 4px;
                    padding: 2px 6px;
                    font-weight: 700;
                    min-width: 60px;
                }
            """)

            slider = QSlider(Qt.Orientation.Horizontal)
            slider.setRange(min_v, max_v)
            slider.setSingleStep(step_v)
            slider.setValue(int(current_val))
            slider.setStyleSheet("""
                QSlider::groove:horizontal {
                    background: #16191D;
                    height: 6px;
                    border-radius: 3px;
                }
                QSlider::sub-page:horizontal {
                    background: #00D2FF;
                    border-radius: 3px;
                }
                QSlider::handle:horizontal {
                    background: #E0E6ED;
                    width: 14px;
                    margin-top: -4px;
                    margin-bottom: -4px;
                    border-radius: 7px;
                }
                QSlider::handle:horizontal:hover {
                    background: #00D2FF;
                }
            """)

            # Bi-directional sync with signal blocking to prevent feedback loops
            def _on_slider(val: int):
                spin.blockSignals(True)
                spin.setValue(val)
                spin.blockSignals(False)
                self._queue_param_change(schema.name, val)

            def _on_spin(val: int):
                slider.blockSignals(True)
                slider.setValue(val)
                slider.blockSignals(False)
                self._queue_param_change(schema.name, val)

            slider.valueChanged.connect(_on_slider)
            spin.valueChanged.connect(_on_spin)

            top_row.addWidget(spin)
            layout.addLayout(top_row)
            layout.addWidget(slider)
            self._controls[schema.name] = (slider, spin)

        # 2. FLOAT: Synchronized Float Slider + DoubleSpinBox
        elif schema.param_type == ParamType.FLOAT:
            min_v = float(schema.min_val if schema.min_val is not None else 0.0)
            max_v = float(schema.max_val if schema.max_val is not None else 100.0)
            step_v = float(schema.step if schema.step is not None else 0.1)

            scale = 100.0 if step_v < 0.1 else 10.0

            dspin = QDoubleSpinBox()
            dspin.setRange(min_v, max_v)
            dspin.setSingleStep(step_v)
            dspin.setDecimals(2 if scale == 100.0 else 1)
            dspin.setValue(float(current_val))
            dspin.setStyleSheet("""
                QDoubleSpinBox {
                    background-color: #16191D;
                    color: #00D2FF;
                    border: 1px solid #363E4E;
                    border-radius: 4px;
                    padding: 2px 6px;
                    font-weight: 700;
                    min-width: 65px;
                }
            """)

            slider = QSlider(Qt.Orientation.Horizontal)
            slider.setRange(int(min_v * scale), int(max_v * scale))
            slider.setSingleStep(int(step_v * scale))
            slider.setValue(int(float(current_val) * scale))
            slider.setStyleSheet("""
                QSlider::groove:horizontal {
                    background: #16191D;
                    height: 6px;
                    border-radius: 3px;
                }
                QSlider::sub-page:horizontal {
                    background: #00D2FF;
                    border-radius: 3px;
                }
                QSlider::handle:horizontal {
                    background: #E0E6ED;
                    width: 14px;
                    margin-top: -4px;
                    margin-bottom: -4px;
                    border-radius: 7px;
                }
                QSlider::handle:horizontal:hover {
                    background: #00D2FF;
                }
            """)

            def _on_fslider(val_int: int):
                f_val = round(val_int / scale, 2)
                dspin.blockSignals(True)
                dspin.setValue(f_val)
                dspin.blockSignals(False)
                self._queue_param_change(schema.name, f_val)

            def _on_fspin(val_flt: float):
                slider.blockSignals(True)
                slider.setValue(int(val_flt * scale))
                slider.blockSignals(False)
                self._queue_param_change(schema.name, val_flt)

            slider.valueChanged.connect(_on_fslider)
            dspin.valueChanged.connect(_on_fspin)

            top_row.addWidget(dspin)
            layout.addLayout(top_row)
            layout.addWidget(slider)
            self._controls[schema.name] = (slider, dspin)

        # 3. BOOL: Clean Styled Switch / Checkbox
        elif schema.param_type == ParamType.BOOL:
            chk = QCheckBox("Enabled")
            chk.setChecked(bool(current_val))
            chk.setStyleSheet("""
                QCheckBox {
                    color: #00E676;
                    font-weight: 700;
                    spacing: 8px;
                }
                QCheckBox::indicator {
                    width: 18px;
                    height: 18px;
                    border-radius: 4px;
                    border: 1px solid #363E4E;
                    background-color: #16191D;
                }
                QCheckBox::indicator:checked {
                    background-color: #00E676;
                    border-color: #00E676;
                    image: none;
                }
            """)
            chk.toggled.connect(lambda checked: self._queue_param_change(schema.name, checked))
            top_row.addWidget(chk)
            layout.addLayout(top_row)
            self._controls[schema.name] = chk

        # 4. CHOICE: Dropdown
        elif schema.param_type == ParamType.CHOICE:
            combo = QComboBox()
            combo.setStyleSheet("""
                QComboBox {
                    background-color: #16191D;
                    color: #E0E6ED;
                    border: 1px solid #363E4E;
                    border-radius: 4px;
                    padding: 4px 10px;
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
            """)
            selected_idx = 0
            if schema.choices:
                for idx, (display_text, val) in enumerate(schema.choices):
                    combo.addItem(display_text, val)
                    if val == current_val:
                        selected_idx = idx
            combo.setCurrentIndex(selected_idx)
            combo.currentIndexChanged.connect(lambda i: self._queue_param_change(schema.name, combo.currentData()))
            layout.addLayout(top_row)
            layout.addWidget(combo)
            self._controls[schema.name] = combo

        # 5. STRING: LineEdit
        elif schema.param_type == ParamType.STRING:
            edit = QLineEdit(str(current_val if current_val is not None else ""))
            edit.setStyleSheet("""
                QLineEdit {
                    background-color: #16191D;
                    color: #00D2FF;
                    border: 1px solid #363E4E;
                    border-radius: 4px;
                    padding: 4px 8px;
                    font-size: 8.5pt;
                }
                QLineEdit:focus {
                    border-color: #00D2FF;
                }
            """)
            edit.textChanged.connect(lambda txt: self._queue_param_change(schema.name, txt))
            layout.addLayout(top_row)
            layout.addWidget(edit)
            self._controls[schema.name] = edit

        return card

    def _queue_param_change(self, param_name: str, value: Any):
        """Debounces user parameter input to avoid lag spikes while dragging sliders."""
        if not self.current_step:
            return
        self._pending_updates[param_name] = value
        self._debounce_timer.start()

    def _flush_debounced_updates(self):
        if not self.current_step or not self._pending_updates:
            return
        step_id = self.current_step.step_id
        for param_name, value in self._pending_updates.items():
            self.current_step.set_param(param_name, value)
            self.parameter_changed.emit(step_id, param_name, value)
        self._pending_updates.clear()

    def _on_reset_clicked(self):
        if self.current_step:
            step_id = self.current_step.step_id
            self.current_step.reset_params()
            self.reset_defaults_requested.emit(step_id)
            # Re-populate UI to show default values
            self.inspect_step(self.current_step)

    def update_control_value(self, param_name: str, value: Any, emit_change: bool = False):
        """Programmatically updates the control's value without triggering feedback loops."""
        if param_name not in self._controls:
            return
        ctrl = self._controls[param_name]
        if isinstance(ctrl, tuple) and len(ctrl) == 2:
            slider, spin = ctrl
            if isinstance(spin, QSpinBox):
                spin.blockSignals(True)
                slider.blockSignals(True)
                spin.setValue(int(value))
                slider.setValue(int(value))
                spin.blockSignals(False)
                slider.blockSignals(False)
            elif isinstance(spin, QDoubleSpinBox):
                spin.blockSignals(True)
                slider.blockSignals(True)
                spin.setValue(float(value))
                slider.setValue(int(float(value) * 10.0))
                spin.blockSignals(False)
                slider.blockSignals(False)
        elif isinstance(ctrl, QComboBox):
            ctrl.blockSignals(True)
            idx = ctrl.findData(value)
            if idx >= 0:
                ctrl.setCurrentIndex(idx)
            ctrl.blockSignals(False)
        elif isinstance(ctrl, QLineEdit):
            ctrl.blockSignals(True)
            ctrl.setText(str(value))
            ctrl.blockSignals(False)

        if self.current_step:
            self.current_step.params[param_name] = value
            if emit_change:
                self.parameter_changed.emit(self.current_step.step_id, param_name, value)
