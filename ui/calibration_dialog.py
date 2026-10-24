"""Interactive Camera Calibration Dialog for Industrial Machine Vision.

Allows configuring physical scale factors (mm/pixel, cm/pixel, inch/pixel),
interactive reference gauge ratio calculation, and batch propagation across
pipeline measurement steps.
"""

from __future__ import annotations
import json
import os
from typing import Optional, Dict, Any

from PyQt6.QtCore import Qt, pyqtSignal
from PyQt6.QtWidgets import (
    QDialog,
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QGridLayout,
    QLabel,
    QLineEdit,
    QDoubleSpinBox,
    QComboBox,
    QPushButton,
    QCheckBox,
    QFrame,
    QGroupBox,
)


CONFIG_CALIBRATION_FILE = "camera_calibration.json"


def load_calibration_config() -> Dict[str, Any]:
    if os.path.exists(CONFIG_CALIBRATION_FILE):
        try:
            with open(CONFIG_CALIBRATION_FILE, "r") as f:
                return json.load(f)
        except Exception:
            pass
    return {
        "calibration_factor": 0.10,
        "unit": "mm",
        "reference_name": "Standard 10mm Gauge Block",
    }


def save_calibration_config(data: Dict[str, Any]):
    try:
        with open(CONFIG_CALIBRATION_FILE, "w") as f:
            json.dump(data, f, indent=4)
    except Exception as e:
        print(f"Error saving calibration config: {e}")


class CameraCalibrationDialog(QDialog):
    """Modern Industrial Calibration Modal for Vision Measurements."""

    calibration_applied = pyqtSignal(float, str)  # (factor, unit)

    def __init__(self, parent: Optional[QWidget] = None, pipeline_engine=None):
        super().__init__(parent)
        self.pipeline_engine = pipeline_engine
        self.config = load_calibration_config()

        self.setWindowTitle("Camera Optical Metrology & Calibration")
        self.resize(520, 480)
        self.setStyleSheet("""
            QDialog {
                background-color: #16191D;
                color: #E0E6ED;
                font-family: 'Segoe UI', sans-serif;
            }
            QLabel {
                color: #E0E6ED;
            }
            QGroupBox {
                border: 1px solid #2B323D;
                border-radius: 8px;
                margin-top: 14px;
                padding-top: 16px;
                font-weight: 700;
                color: #00D2FF;
            }
            QGroupBox::title {
                subcontrol-origin: margin;
                left: 12px;
                padding: 0 4px;
            }
            QLineEdit, QDoubleSpinBox, QComboBox {
                background-color: #1F242D;
                color: #00D2FF;
                border: 1px solid #363E4E;
                border-radius: 6px;
                padding: 6px 10px;
                font-weight: 700;
                font-size: 12px;
            }
            QLineEdit:focus, QDoubleSpinBox:focus, QComboBox:focus {
                border-color: #00D2FF;
            }
            QComboBox QAbstractItemView {
                background-color: #1F242D;
                color: #E0E6ED;
                selection-background-color: #00D2FF;
                selection-color: #0B0D13;
            }
        """)

        self._init_ui()

    def _init_ui(self):
        main_layout = QVBoxLayout(self)
        main_layout.setContentsMargins(20, 20, 20, 20)
        main_layout.setSpacing(14)

        # Header Title
        top_bar = QHBoxLayout()
        icon_lbl = QLabel("📐")
        icon_lbl.setStyleSheet("font-size: 24px;")
        top_bar.addWidget(icon_lbl)

        title_vbox = QVBoxLayout()
        header_title = QLabel("Camera Optical Calibration")
        header_title.setStyleSheet("font-size: 16px; font-weight: 800; color: #00D2FF;")
        sub_title = QLabel("Convert pixel distances to physical engineering units (mm, cm, in)")
        sub_title.setStyleSheet("font-size: 11px; color: #8C9BAE;")
        title_vbox.addWidget(header_title)
        title_vbox.addWidget(sub_title)
        top_bar.addLayout(title_vbox)
        top_bar.addStretch()
        main_layout.addLayout(top_bar)

        # Group 1: Direct Scale Factor
        grp_direct = QGroupBox("Active Camera Scale Factor")
        d_layout = QGridLayout(grp_direct)
        d_layout.setContentsMargins(14, 14, 14, 14)
        d_layout.setSpacing(10)

        d_layout.addWidget(QLabel("Scale Factor (Units/px):"), 0, 0)
        self.spin_factor = QDoubleSpinBox()
        self.spin_factor.setRange(0.0001, 100.0)
        self.spin_factor.setDecimals(4)
        self.spin_factor.setSingleStep(0.005)
        self.spin_factor.setValue(float(self.config.get("calibration_factor", 0.10)))
        d_layout.addWidget(self.spin_factor, 0, 1)

        d_layout.addWidget(QLabel("Measurement Unit:"), 1, 0)
        self.combo_unit = QComboBox()
        self.combo_unit.addItems(["mm", "cm", "in", "um", "px"])
        cur_unit = self.config.get("unit", "mm")
        idx = self.combo_unit.findText(cur_unit)
        if idx >= 0:
            self.combo_unit.setCurrentIndex(idx)
        d_layout.addWidget(self.combo_unit, 1, 1)

        main_layout.addWidget(grp_direct)

        # Group 2: Calibration Gauge Calculator
        grp_calc = QGroupBox("Reference Gauge Calculator")
        c_layout = QGridLayout(grp_calc)
        c_layout.setContentsMargins(14, 14, 14, 14)
        c_layout.setSpacing(10)

        c_layout.addWidget(QLabel("Known Physical Dimension:"), 0, 0)
        self.spin_known_dim = QDoubleSpinBox()
        self.spin_known_dim.setRange(0.1, 10000.0)
        self.spin_known_dim.setDecimals(2)
        self.spin_known_dim.setValue(50.0)
        c_layout.addWidget(self.spin_known_dim, 0, 1)

        c_layout.addWidget(QLabel("Measured Distance in Image:"), 1, 0)
        self.spin_measured_px = QDoubleSpinBox()
        self.spin_measured_px.setRange(1.0, 10000.0)
        self.spin_measured_px.setDecimals(1)
        self.spin_measured_px.setValue(500.0)
        c_layout.addWidget(self.spin_measured_px, 1, 1)

        btn_calc = QPushButton("⚡ Compute Ratio")
        btn_calc.setStyleSheet("""
            QPushButton {
                background-color: #242A35;
                color: #00D2FF;
                border: 1px solid #00D2FF;
                border-radius: 6px;
                padding: 6px 14px;
                font-weight: 700;
            }
            QPushButton:hover {
                background-color: #00D2FF;
                color: #0B0D13;
            }
        """)
        btn_calc.clicked.connect(self._compute_ratio)
        c_layout.addWidget(btn_calc, 2, 0, 1, 2)

        self.lbl_ratio_result = QLabel("Formula: Factor = Known Dimension / Measured Pixels")
        self.lbl_ratio_result.setStyleSheet("color: #8C9BAE; font-size: 11px; font-style: italic;")
        c_layout.addWidget(self.lbl_ratio_result, 3, 0, 1, 2)

        main_layout.addWidget(grp_calc)

        # Option: Apply to all pipeline measurement steps
        self.chk_update_pipeline = QCheckBox("Update all Industrial Measurement steps in current pipeline")
        self.chk_update_pipeline.setChecked(True)
        self.chk_update_pipeline.setStyleSheet("color: #00E676; font-weight: 600; margin-top: 6px;")
        main_layout.addWidget(self.chk_update_pipeline)

        main_layout.addStretch()

        # Bottom Buttons
        btn_box = QHBoxLayout()
        btn_box.addStretch()

        btn_cancel = QPushButton("Cancel")
        btn_cancel.setStyleSheet("""
            QPushButton {
                background-color: #242A35;
                color: #B0BAC9;
                border: 1px solid #363E4E;
                padding: 7px 18px;
                border-radius: 6px;
                font-weight: 600;
            }
            QPushButton:hover {
                background-color: #2F3746;
                color: #E0E6ED;
            }
        """)
        btn_cancel.clicked.connect(self.reject)
        btn_box.addWidget(btn_cancel)

        btn_save = QPushButton("✓ Apply & Save Calibration")
        btn_save.setStyleSheet("""
            QPushButton {
                background-color: #00E676;
                color: #0B0D13;
                border: 1px solid #00C853;
                padding: 7px 22px;
                border-radius: 6px;
                font-weight: 800;
                font-size: 12px;
            }
            QPushButton:hover {
                background-color: #69F0AE;
                border-color: #00E676;
            }
        """)
        btn_save.clicked.connect(self._on_save_applied)
        btn_box.addWidget(btn_save)

        main_layout.addLayout(btn_box)

    def _compute_ratio(self):
        known = self.spin_known_dim.value()
        pixels = self.spin_measured_px.value()
        if pixels > 0:
            factor = known / pixels
            self.spin_factor.setValue(factor)
            unit = self.combo_unit.currentText()
            px_per_unit = 1.0 / factor if factor > 0 else 0
            self.lbl_ratio_result.setText(f"Computed: 1 px = {factor:.4f} {unit}  ({px_per_unit:.2f} px/{unit})")
            self.lbl_ratio_result.setStyleSheet("color: #00E676; font-weight: 700; font-size: 11px;")

    def _on_save_applied(self):
        factor = float(self.spin_factor.value())
        unit = self.combo_unit.currentText()

        self.config["calibration_factor"] = factor
        self.config["unit"] = unit
        save_calibration_config(self.config)

        # Propagate to pipeline if requested
        if self.chk_update_pipeline.isChecked() and self.pipeline_engine:
            for s in self.pipeline_engine.steps:
                if s.operation_name == "Industrial Caliper & Measurement":
                    s.set_param("calibration_factor", factor)
                    s.set_param("unit", unit)
            self.pipeline_engine.mark_dirty_from(0)

        self.calibration_applied.emit(factor, unit)
        self.accept()
