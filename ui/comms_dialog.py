"""Industrial PLC & Hardware Device Communications Configuration Dialog.

Provides interactive configuration and live test functionality for:
1. Siemens S7 PLC (S7-300, S7-1200, S7-1500)
2. Delta PLC (Modbus TCP D-Registers & M-Coils)
3. Beckhoff TwinCAT ADS (TCP Port 48898)
4. Generic Ethernet Devices (TCP Client/Server, UDP Broadcast)
5. Raspberry Pi GPIO (Remote Pigpio & Local Hardware)
"""

import time
import logging
from typing import Optional

from PyQt6.QtWidgets import (
    QDialog,
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QGridLayout,
    QTabWidget,
    QLabel,
    QLineEdit,
    QSpinBox,
    QCheckBox,
    QPushButton,
    QFrame,
    QComboBox,
    QMessageBox,
)
from PyQt6.QtCore import Qt
from PyQt6.QtGui import QColor, QFont

from comms.io_manager import IndustrialIoManager

logger = logging.getLogger("IndustrialCommsDialog")


class IndustrialCommsDialog(QDialog):
    """Configuration & Hardware Testing Dialog for Factory PLCs & I/O."""

    def __init__(self, io_manager: IndustrialIoManager, parent=None):
        super().__init__(parent)
        self.io_manager = io_manager
        self.setWindowTitle("Industrial PLC & Hardware Communications")
        self.resize(760, 580)
        self.setStyleSheet("""
            QDialog {
                background-color: #0f1117;
                color: #e8ecf4;
                font-family: 'Segoe UI', 'Inter', sans-serif;
            }
            QTabWidget::pane {
                border: 1px solid #2d3244;
                background-color: #181b24;
                border-radius: 8px;
                padding: 12px;
            }
            QTabBar::tab {
                background-color: #141720;
                color: #8b94a8;
                padding: 8px 16px;
                border-top-left-radius: 6px;
                border-top-right-radius: 6px;
                font-weight: 600;
                margin-right: 4px;
            }
            QTabBar::tab:selected {
                background-color: #181b24;
                color: #00d2ff;
                border-bottom: 2px solid #00d2ff;
            }
            QGroupBox, QFrame.card {
                background-color: #141720;
                border: 1px solid #2d3244;
                border-radius: 8px;
                padding: 12px;
            }
            QLabel {
                color: #e8ecf4;
            }
            QLineEdit, QSpinBox, QComboBox {
                background-color: #202430;
                border: 1px solid #2d3244;
                border-radius: 6px;
                padding: 6px 10px;
                color: #e8ecf4;
                font-family: 'Consolas', monospace;
            }
            QLineEdit:focus, QSpinBox:focus, QComboBox:focus {
                border-color: #00d2ff;
            }
            QPushButton {
                background-color: #202430;
                border: 1px solid #2d3244;
                border-radius: 6px;
                padding: 8px 16px;
                font-weight: 600;
                color: #e8ecf4;
            }
            QPushButton:hover {
                background-color: #2d3244;
                border-color: #00d2ff;
            }
            QPushButton.primary {
                background-color: #00d2ff;
                color: #0f1117;
                border: none;
                font-weight: 700;
            }
            QPushButton.primary:hover {
                background-color: #33dcff;
            }
            QPushButton.test_btn {
                background-color: #1b2636;
                border: 1px solid #00d2ff;
                color: #00d2ff;
                font-weight: 700;
            }
            QPushButton.test_btn:hover {
                background-color: #00d2ff;
                color: #0f1117;
            }
        """)

        self._init_ui()

    def _init_ui(self):
        main_layout = QVBoxLayout(self)
        main_layout.setContentsMargins(16, 16, 16, 16)
        main_layout.setSpacing(12)

        # Header
        header = QFrame()
        header.setStyleSheet("background-color: #181b24; border: 1px solid #2d3244; border-radius: 8px; padding: 10px;")
        h_layout = QVBoxLayout(header)
        h_layout.setContentsMargins(8, 4, 8, 4)
        title = QLabel("<b style='font-size:15px; color:#00d2ff;'>📡 Industrial PLC & Hardware Communications</b>")
        subtitle = QLabel("<span style='color:#8b94a8; font-size:12px;'>Dispatch inspection pass/fail decisions and part coordinates to Siemens, Delta, Beckhoff, Ethernet devices and Raspberry Pi GPIO.</span>")
        h_layout.addWidget(title)
        h_layout.addWidget(subtitle)
        main_layout.addWidget(header)

        # Tabs
        self.tabs = QTabWidget()
        self.tabs.addTab(self._create_siemens_tab(), "Siemens S7 PLC")
        self.tabs.addTab(self._create_delta_tab(), "Delta PLC (Modbus)")
        self.tabs.addTab(self._create_beckhoff_tab(), "Beckhoff TwinCAT")
        self.tabs.addTab(self._create_ethernet_tab(), "Ethernet Device")
        self.tabs.addTab(self._create_gpio_tab(), "Raspberry Pi GPIO")
        main_layout.addWidget(self.tabs, 1)

        # Bottom Buttons
        btn_box = QHBoxLayout()
        btn_box.addStretch()

        self.btn_cancel = QPushButton("Cancel")
        self.btn_cancel.clicked.connect(self.reject)
        btn_box.addWidget(self.btn_cancel)

        self.btn_save = QPushButton("💾 Save & Apply Settings")
        self.btn_save.setProperty("class", "primary")
        self.btn_save.setStyleSheet("background-color: #00d2ff; color: #0f1117; font-weight: 700; padding: 8px 18px;")
        self.btn_save.clicked.connect(self._save_settings)
        btn_box.addWidget(self.btn_save)

        main_layout.addLayout(btn_box)

    # ------------------ 1. SIEMENS S7 TAB ------------------

    def _create_siemens_tab(self) -> QWidget:
        tab = QWidget()
        layout = QVBoxLayout(tab)
        layout.setSpacing(12)

        # Enable Checkbox
        self.chk_siemens = QCheckBox("Enable Siemens S7 Result Dispatch (S7-300 / S7-1200 / S7-1500)")
        self.chk_siemens.setChecked(self.io_manager.enable_siemens)
        self.chk_siemens.setStyleSheet("font-size: 13px; font-weight: 700; color: #00d2ff;")
        layout.addWidget(self.chk_siemens)

        # Form Card
        card = QFrame()
        card.setProperty("class", "card")
        f_layout = QGridLayout(card)
        f_layout.setSpacing(10)

        f_layout.addWidget(QLabel("PLC IP Address:"), 0, 0)
        self.edit_s7_ip = QLineEdit(self.io_manager.siemens_client.host)
        f_layout.addWidget(self.edit_s7_ip, 0, 1)

        f_layout.addWidget(QLabel("Rack:"), 0, 2)
        self.spin_s7_rack = QSpinBox()
        self.spin_s7_rack.setRange(0, 7)
        self.spin_s7_rack.setValue(self.io_manager.siemens_client.rack)
        f_layout.addWidget(self.spin_s7_rack, 0, 3)

        f_layout.addWidget(QLabel("Slot (1200/1500=1, 300=2):"), 1, 0)
        self.spin_s7_slot = QSpinBox()
        self.spin_s7_slot.setRange(0, 31)
        self.spin_s7_slot.setValue(self.io_manager.siemens_client.slot)
        f_layout.addWidget(self.spin_s7_slot, 1, 1)

        f_layout.addWidget(QLabel("Target DataBlock (DB):"), 1, 2)
        self.spin_s7_db = QSpinBox()
        self.spin_s7_db.setRange(1, 65535)
        self.spin_s7_db.setValue(self.io_manager.siemens_config.get("db_number", 1))
        f_layout.addWidget(self.spin_s7_db, 1, 3)

        f_layout.addWidget(QLabel("Start Byte Offset:"), 2, 0)
        self.spin_s7_byte = QSpinBox()
        self.spin_s7_byte.setRange(0, 65535)
        self.spin_s7_byte.setValue(self.io_manager.siemens_config.get("start_byte", 0))
        f_layout.addWidget(self.spin_s7_byte, 2, 1)

        layout.addWidget(card)

        # Info Box
        info = QFrame()
        info.setStyleSheet("background-color: #141720; border: 1px solid #2d3244; border-radius: 6px; padding: 8px;")
        i_layout = QVBoxLayout(info)
        i_layout.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'><b>Siemens DataBlock Memory Layout (16 Bytes):</b><br>"
                                 "• +0.0: Byte (Bit 0=PASS, Bit 1=FAIL, Bit 2=INSPECT_DONE)<br>"
                                 "• +2.0: Word / INT (Part Count / Defect Count)<br>"
                                 "• +4.0: Real / Float (Centroid X coordinate in mm / px)<br>"
                                 "• +8.0: Real / Float (Centroid Y coordinate in mm / px)<br>"
                                 "• +12.0: Real / Float (Part Rotation Angle in degrees)</span>"))
        layout.addWidget(info)

        # Test Action & Status
        test_box = QHBoxLayout()
        self.btn_test_s7 = QPushButton("⚡ Test Connection & Write DB")
        self.btn_test_s7.setProperty("class", "test_btn")
        self.btn_test_s7.clicked.connect(self._test_siemens)
        test_box.addWidget(self.btn_test_s7)

        self.lbl_s7_status = QLabel("Status: Standby")
        self.lbl_s7_status.setStyleSheet("color: #8b94a8; font-family: monospace;")
        test_box.addWidget(self.lbl_s7_status, 1)
        layout.addLayout(test_box)

        layout.addStretch()
        return tab

    def _test_siemens(self):
        self.lbl_s7_status.setText("Testing connection...")
        self.io_manager.siemens_client.host = self.edit_s7_ip.text().strip()
        self.io_manager.siemens_client.rack = self.spin_s7_rack.value()
        self.io_manager.siemens_client.slot = self.spin_s7_slot.value()
        db_num = self.spin_s7_db.value()
        start_byte = self.spin_s7_byte.value()

        try:
            ok = self.io_manager.siemens_client.write_inspection_batch(
                db_number=db_num,
                start_byte=start_byte,
                passed=True,
                part_count=1,
                centroid_x=120.5,
                centroid_y=340.2,
                angle=15.0,
            )
            if ok:
                self.lbl_s7_status.setText(f"✅ Success! Wrote 16-byte inspection batch to DB{db_num} at {self.io_manager.siemens_client.host}")
                self.lbl_s7_status.setStyleSheet("color: #00e676; font-weight: bold;")
            else:
                err = self.io_manager.siemens_client.last_error or "Check PLC IP & Rack/Slot"
                self.lbl_s7_status.setText(f"⚠️ S7 Connection Warning: {err}")
                self.lbl_s7_status.setStyleSheet("color: #ffb300;")
        except Exception as e:
            self.lbl_s7_status.setText(f"❌ Error: {e}")
            self.lbl_s7_status.setStyleSheet("color: #ff1744;")

    # ------------------ 2. DELTA PLC (MODBUS TCP) TAB ------------------

    def _create_delta_tab(self) -> QWidget:
        tab = QWidget()
        layout = QVBoxLayout(tab)
        layout.setSpacing(12)

        # Enable Checkbox
        self.chk_delta = QCheckBox("Enable Delta PLC Modbus TCP Result Dispatch (DVP / AS / AH Series)")
        self.chk_delta.setChecked(self.io_manager.enable_delta)
        self.chk_delta.setStyleSheet("font-size: 13px; font-weight: 700; color: #00d2ff;")
        layout.addWidget(self.chk_delta)

        # Form Card
        card = QFrame()
        card.setProperty("class", "card")
        f_layout = QGridLayout(card)
        f_layout.setSpacing(10)

        f_layout.addWidget(QLabel("PLC IP Address:"), 0, 0)
        self.edit_delta_ip = QLineEdit(self.io_manager.delta_client.host)
        f_layout.addWidget(self.edit_delta_ip, 0, 1)

        f_layout.addWidget(QLabel("Modbus Port (Default 502):"), 0, 2)
        self.spin_delta_port = QSpinBox()
        self.spin_delta_port.setRange(1, 65535)
        self.spin_delta_port.setValue(self.io_manager.delta_client.port)
        f_layout.addWidget(self.spin_delta_port, 0, 3)

        f_layout.addWidget(QLabel("Modbus Unit ID / Slave:"), 1, 0)
        self.spin_delta_unit = QSpinBox()
        self.spin_delta_unit.setRange(1, 255)
        self.spin_delta_unit.setValue(self.io_manager.delta_client.unit_id)
        f_layout.addWidget(self.spin_delta_unit, 1, 1)

        f_layout.addWidget(QLabel("Base D-Register (e.g. D100):"), 1, 2)
        self.spin_delta_d = QSpinBox()
        self.spin_delta_d.setRange(0, 9999)
        self.spin_delta_d.setValue(self.io_manager.delta_config.get("d_start", 100))
        f_layout.addWidget(self.spin_delta_d, 1, 3)

        f_layout.addWidget(QLabel("Pass/Fail M-Coil (e.g. M0):"), 2, 0)
        self.spin_delta_m = QSpinBox()
        self.spin_delta_m.setRange(0, 4095)
        self.spin_delta_m.setValue(self.io_manager.delta_config.get("m_pass", 0))
        f_layout.addWidget(self.spin_delta_m, 2, 1)

        layout.addWidget(card)

        # Info Box
        info = QFrame()
        info.setStyleSheet("background-color: #141720; border: 1px solid #2d3244; border-radius: 6px; padding: 8px;")
        i_layout = QVBoxLayout(info)
        i_layout.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'><b>Delta PLC Register Mapping:</b><br>"
                                 "• <b>M-Coil (M0)</b>: M0 = 1 (PASS), M1 = 1 (FAIL) via Modbus address 0x0800 (2048)<br>"
                                 "• <b>D-Register (D100)</b>: Pass/Fail state (1/0) via Modbus address 0x1000 + 100<br>"
                                 "• <b>D101</b>: Total inspected parts counter (16-bit INT)<br>"
                                 "• <b>D102-D103</b>: Centroid X (32-bit Float IEEE-754)<br>"
                                 "• <b>D104-D105</b>: Centroid Y (32-bit Float IEEE-754)</span>"))
        layout.addWidget(info)

        # Test Action & Status
        test_box = QHBoxLayout()
        self.btn_test_delta = QPushButton("⚡ Test Delta Modbus & Write D100")
        self.btn_test_delta.setProperty("class", "test_btn")
        self.btn_test_delta.clicked.connect(self._test_delta)
        test_box.addWidget(self.btn_test_delta)

        self.lbl_delta_status = QLabel("Status: Standby")
        self.lbl_delta_status.setStyleSheet("color: #8b94a8; font-family: monospace;")
        test_box.addWidget(self.lbl_delta_status, 1)
        layout.addLayout(test_box)

        layout.addStretch()
        return tab

    def _test_delta(self):
        self.lbl_delta_status.setText("Testing Modbus TCP connection...")
        self.io_manager.delta_client.host = self.edit_delta_ip.text().strip()
        self.io_manager.delta_client.port = self.spin_delta_port.value()
        self.io_manager.delta_client.unit_id = self.spin_delta_unit.value()
        d_base = self.spin_delta_d.value()
        m_coil = self.spin_delta_m.value()

        try:
            ok1 = self.io_manager.delta_client.write_delta_m_coil(m_coil, True)
            ok2 = self.io_manager.delta_client.write_delta_d_register(d_base, 1)
            ok3 = self.io_manager.delta_client.write_delta_d_float(d_base + 2, 245.8)
            if ok1 and ok2:
                self.lbl_delta_status.setText(f"✅ Success! Wrote M{m_coil}=1, D{d_base}=1, D{d_base+2}=245.8 to Delta PLC")
                self.lbl_delta_status.setStyleSheet("color: #00e676; font-weight: bold;")
            else:
                err = self.io_manager.delta_client.last_error or "Check IP & Port 502"
                self.lbl_delta_status.setText(f"⚠️ Delta Connection Warning: {err}")
                self.lbl_delta_status.setStyleSheet("color: #ffb300;")
        except Exception as e:
            self.lbl_delta_status.setText(f"❌ Error: {e}")
            self.lbl_delta_status.setStyleSheet("color: #ff1744;")

    # ------------------ 3. BECKHOFF TWINCAT TAB ------------------

    def _create_beckhoff_tab(self) -> QWidget:
        tab = QWidget()
        layout = QVBoxLayout(tab)
        layout.setSpacing(12)

        # Enable Checkbox
        self.chk_beckhoff = QCheckBox("Enable Beckhoff TwinCAT ADS Result Dispatch (TwinCAT 2 / TwinCAT 3)")
        self.chk_beckhoff.setChecked(self.io_manager.enable_beckhoff)
        self.chk_beckhoff.setStyleSheet("font-size: 13px; font-weight: 700; color: #00d2ff;")
        layout.addWidget(self.chk_beckhoff)

        # Form Card
        card = QFrame()
        card.setProperty("class", "card")
        f_layout = QGridLayout(card)
        f_layout.setSpacing(10)

        f_layout.addWidget(QLabel("Controller IP Address:"), 0, 0)
        self.edit_beckhoff_ip = QLineEdit(self.io_manager.beckhoff_client.host)
        f_layout.addWidget(self.edit_beckhoff_ip, 0, 1)

        f_layout.addWidget(QLabel("Target AMS Net ID:"), 0, 2)
        self.edit_beckhoff_ams = QLineEdit(self.io_manager.beckhoff_client.ams_net_id)
        f_layout.addWidget(self.edit_beckhoff_ams, 0, 3)

        f_layout.addWidget(QLabel("ADS Port (TC3=851, TC2=801):"), 1, 0)
        self.spin_beckhoff_port = QSpinBox()
        self.spin_beckhoff_port.setRange(1, 65535)
        self.spin_beckhoff_port.setValue(self.io_manager.beckhoff_client.ads_port)
        f_layout.addWidget(self.spin_beckhoff_port, 1, 1)

        f_layout.addWidget(QLabel("Memory Area Byte Offset (%MB):"), 1, 2)
        self.spin_beckhoff_offset = QSpinBox()
        self.spin_beckhoff_offset.setRange(0, 65535)
        self.spin_beckhoff_offset.setValue(self.io_manager.beckhoff_config.get("byte_offset", 100))
        f_layout.addWidget(self.spin_beckhoff_offset, 1, 3)

        layout.addWidget(card)

        # Info Box
        info = QFrame()
        info.setStyleSheet("background-color: #141720; border: 1px solid #2d3244; border-radius: 6px; padding: 8px;")
        i_layout = QVBoxLayout(info)
        i_layout.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'><b>Beckhoff ADS Native Protocol:</b><br>"
                                 "• Communicates directly to TwinCAT router on <b>TCP Port 48898</b>.<br>"
                                 "• Writes binary inspection packet to PLC %M Memory Area (IndexGroup 0x4020).<br>"
                                 "• Packet contains: bPass (1B), bFail (1B), nCount (2B), fX (4B), fY (4B), fAngle (4B).</span>"))
        layout.addWidget(info)

        # Test Action & Status
        test_box = QHBoxLayout()
        self.btn_test_beckhoff = QPushButton("⚡ Test Beckhoff ADS Write")
        self.btn_test_beckhoff.setProperty("class", "test_btn")
        self.btn_test_beckhoff.clicked.connect(self._test_beckhoff)
        test_box.addWidget(self.btn_test_beckhoff)

        self.lbl_beckhoff_status = QLabel("Status: Standby")
        self.lbl_beckhoff_status.setStyleSheet("color: #8b94a8; font-family: monospace;")
        test_box.addWidget(self.lbl_beckhoff_status, 1)
        layout.addLayout(test_box)

        layout.addStretch()
        return tab

    def _test_beckhoff(self):
        self.lbl_beckhoff_status.setText("Testing TwinCAT ADS connection...")
        self.io_manager.beckhoff_client.host = self.edit_beckhoff_ip.text().strip()
        self.io_manager.beckhoff_client.ams_net_id = self.edit_beckhoff_ams.text().strip()
        self.io_manager.beckhoff_client.ads_port = self.spin_beckhoff_port.value()
        offset = self.spin_beckhoff_offset.value()

        try:
            ok = self.io_manager.beckhoff_client.write_inspection_results(
                base_offset=offset,
                passed=True,
                count=1,
                x=150.0,
                y=250.0,
                angle=45.0,
            )
            if ok:
                self.lbl_beckhoff_status.setText(f"✅ Success! Wrote inspection packet to TwinCAT %MB{offset}")
                self.lbl_beckhoff_status.setStyleSheet("color: #00e676; font-weight: bold;")
            else:
                err = self.io_manager.beckhoff_client.last_error or "Check IP & Port 48898"
                self.lbl_beckhoff_status.setText(f"⚠️ Beckhoff Connection Warning: {err}")
                self.lbl_beckhoff_status.setStyleSheet("color: #ffb300;")
        except Exception as e:
            self.lbl_beckhoff_status.setText(f"❌ Error: {e}")
            self.lbl_beckhoff_status.setStyleSheet("color: #ff1744;")

    # ------------------ 4. ETHERNET DEVICE TAB ------------------

    def _create_ethernet_tab(self) -> QWidget:
        tab = QWidget()
        layout = QVBoxLayout(tab)
        layout.setSpacing(12)

        # Enable Checkbox
        self.chk_ethernet = QCheckBox("Enable Generic Ethernet Device Communication (Robots, MES, Barcode Printers)")
        self.chk_ethernet.setChecked(self.io_manager.enable_ethernet)
        self.chk_ethernet.setStyleSheet("font-size: 13px; font-weight: 700; color: #00d2ff;")
        layout.addWidget(self.chk_ethernet)

        # Form Card
        card = QFrame()
        card.setProperty("class", "card")
        f_layout = QGridLayout(card)
        f_layout.setSpacing(10)

        f_layout.addWidget(QLabel("Target Host / Broadcast IP:"), 0, 0)
        self.edit_eth_ip = QLineEdit(self.io_manager.ethernet_client.target_ip)
        f_layout.addWidget(self.edit_eth_ip, 0, 1)

        f_layout.addWidget(QLabel("Port:"), 0, 2)
        self.spin_eth_port = QSpinBox()
        self.spin_eth_port.setRange(1, 65535)
        self.spin_eth_port.setValue(self.io_manager.ethernet_client.port)
        f_layout.addWidget(self.spin_eth_port, 0, 3)

        f_layout.addWidget(QLabel("Protocol:"), 1, 0)
        self.combo_eth_proto = QComboBox()
        self.combo_eth_proto.addItems(["TCP", "UDP"])
        self.combo_eth_proto.setCurrentText(self.io_manager.ethernet_client.protocol)
        f_layout.addWidget(self.combo_eth_proto, 1, 1)

        f_layout.addWidget(QLabel("Mode:"), 1, 2)
        self.combo_eth_mode = QComboBox()
        self.combo_eth_mode.addItems(["Client", "Server"])
        self.combo_eth_mode.setCurrentText(self.io_manager.ethernet_client.mode)
        f_layout.addWidget(self.combo_eth_mode, 1, 3)

        f_layout.addWidget(QLabel("Payload Format:"), 2, 0)
        self.combo_eth_fmt = QComboBox()
        self.combo_eth_fmt.addItems(["JSON", "CSV", "NATIVE"])
        self.combo_eth_fmt.setCurrentText(self.io_manager.ethernet_client.data_format)
        f_layout.addWidget(self.combo_eth_fmt, 2, 1)

        layout.addWidget(card)

        # Info Box
        info = QFrame()
        info.setStyleSheet("background-color: #141720; border: 1px solid #2d3244; border-radius: 6px; padding: 8px;")
        i_layout = QVBoxLayout(info)
        i_layout.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'><b>Ethernet Integration Capabilities:</b><br>"
                                 "• <b>TCP Client</b>: Directly transmits results to robot controllers (ABB, KUKA, Fanuc, UR).<br>"
                                 "• <b>TCP Server</b>: Listens for remote trigger commands (send 'TRIGGER' to trigger image capture).<br>"
                                 "• <b>UDP Broadcast</b>: Zero-latency unicast or subnet broadcast (e.g. 255.255.255.255).</span>"))
        layout.addWidget(info)

        # Test Action & Status
        test_box = QHBoxLayout()
        self.btn_test_eth = QPushButton("⚡ Send Test Packet")
        self.btn_test_eth.setProperty("class", "test_btn")
        self.btn_test_eth.clicked.connect(self._test_ethernet)
        test_box.addWidget(self.btn_test_eth)

        self.lbl_eth_status = QLabel("Status: Standby")
        self.lbl_eth_status.setStyleSheet("color: #8b94a8; font-family: monospace;")
        test_box.addWidget(self.lbl_eth_status, 1)
        layout.addLayout(test_box)

        layout.addStretch()
        return tab

    def _test_ethernet(self):
        self.lbl_eth_status.setText("Transmitting test packet...")
        self.io_manager.ethernet_client.target_ip = self.edit_eth_ip.text().strip()
        self.io_manager.ethernet_client.port = self.spin_eth_port.value()
        self.io_manager.ethernet_client.protocol = self.combo_eth_proto.currentText()
        self.io_manager.ethernet_client.mode = self.combo_eth_mode.currentText()
        self.io_manager.ethernet_client.data_format = self.combo_eth_fmt.currentText()

        test_payload = {
            "test_packet": True,
            "overall_pass": True,
            "cycle_time_ms": 14.8,
            "part_id": "PART_TEST_88",
            "x": 320.0,
            "y": 240.0,
            "timestamp": time.time(),
        }

        try:
            ok = self.io_manager.ethernet_client.send_result(test_payload)
            if ok:
                self.lbl_eth_status.setText(f"✅ Dispatched {self.combo_eth_fmt.currentText()} packet via {self.combo_eth_proto.currentText()} to {self.edit_eth_ip.text()}:{self.spin_eth_port.value()}")
                self.lbl_eth_status.setStyleSheet("color: #00e676; font-weight: bold;")
            else:
                self.lbl_eth_status.setText("⚠️ Dispatch Warning: Target server not responding")
                self.lbl_eth_status.setStyleSheet("color: #ffb300;")
        except Exception as e:
            self.lbl_eth_status.setText(f"❌ Error: {e}")
            self.lbl_eth_status.setStyleSheet("color: #ff1744;")

    # ------------------ 5. RASPBERRY PI GPIO TAB ------------------

    def _create_gpio_tab(self) -> QWidget:
        tab = QWidget()
        layout = QVBoxLayout(tab)
        layout.setSpacing(12)

        # Enable Checkbox
        self.chk_gpio = QCheckBox("Enable Raspberry Pi Physical / Remote GPIO Result Output")
        self.chk_gpio.setChecked(self.io_manager.enable_gpio)
        self.chk_gpio.setStyleSheet("font-size: 13px; font-weight: 700; color: #00d2ff;")
        layout.addWidget(self.chk_gpio)

        # Form Card
        card = QFrame()
        card.setProperty("class", "card")
        f_layout = QGridLayout(card)
        f_layout.setSpacing(10)

        f_layout.addWidget(QLabel("Raspberry Pi IP / Host:"), 0, 0)
        self.edit_gpio_host = QLineEdit(self.io_manager.gpio_client.host)
        f_layout.addWidget(self.edit_gpio_host, 0, 1)

        f_layout.addWidget(QLabel("Pigpio Port (Default 8888):"), 0, 2)
        self.spin_gpio_port = QSpinBox()
        self.spin_gpio_port.setRange(1, 65535)
        self.spin_gpio_port.setValue(self.io_manager.gpio_client.port)
        f_layout.addWidget(self.spin_gpio_port, 0, 3)

        f_layout.addWidget(QLabel("PASS Pin (BCM):"), 1, 0)
        self.spin_gpio_pass = QSpinBox()
        self.spin_gpio_pass.setRange(0, 40)
        self.spin_gpio_pass.setValue(self.io_manager.gpio_client.pass_pin)
        f_layout.addWidget(self.spin_gpio_pass, 1, 1)

        f_layout.addWidget(QLabel("FAIL Pin (BCM):"), 1, 2)
        self.spin_gpio_fail = QSpinBox()
        self.spin_gpio_fail.setRange(0, 40)
        self.spin_gpio_fail.setValue(self.io_manager.gpio_client.fail_pin)
        f_layout.addWidget(self.spin_gpio_fail, 1, 3)

        f_layout.addWidget(QLabel("READY Pin (BCM):"), 2, 0)
        self.spin_gpio_ready = QSpinBox()
        self.spin_gpio_ready.setRange(0, 40)
        self.spin_gpio_ready.setValue(self.io_manager.gpio_client.ready_pin)
        f_layout.addWidget(self.spin_gpio_ready, 2, 1)

        f_layout.addWidget(QLabel("STROBE Pin (BCM):"), 2, 2)
        self.spin_gpio_strobe = QSpinBox()
        self.spin_gpio_strobe.setRange(0, 40)
        self.spin_gpio_strobe.setValue(self.io_manager.gpio_client.strobe_pin)
        f_layout.addWidget(self.spin_gpio_strobe, 2, 3)

        f_layout.addWidget(QLabel("TRIGGER Sensor Pin (BCM):"), 3, 0)
        self.spin_gpio_trig = QSpinBox()
        self.spin_gpio_trig.setRange(0, 40)
        self.spin_gpio_trig.setValue(self.io_manager.gpio_client.trigger_pin)
        f_layout.addWidget(self.spin_gpio_trig, 3, 1)

        layout.addWidget(card)

        # Info Box
        info = QFrame()
        info.setStyleSheet("background-color: #141720; border: 1px solid #2d3244; border-radius: 6px; padding: 8px;")
        i_layout = QVBoxLayout(info)
        i_layout.addWidget(QLabel("<span style='color:#8b94a8; font-size:11px;'><b>Raspberry Pi Industrial I/O Capabilities:</b><br>"
                                 "• <b>Remote Pigpio (Port 8888)</b>: Controls remote Raspberry Pi physical pins over Ethernet/WiFi from PC.<br>"
                                 "• <b>Local Hardware</b>: Direct memory-mapped RPi.GPIO pins when running directly on a Pi.<br>"
                                 "• <b>Hardware Trigger</b>: Rising edge on TRIGGER pin initiates zero-latency image acquisition.</span>"))
        layout.addWidget(info)

        # Test Action & Status
        test_box = QHBoxLayout()
        self.btn_test_gpio = QPushButton("⚡ Pulse PASS (Pin 17) & Strobe (Pin 23)")
        self.btn_test_gpio.setProperty("class", "test_btn")
        self.btn_test_gpio.clicked.connect(self._test_gpio)
        test_box.addWidget(self.btn_test_gpio)

        self.lbl_gpio_status = QLabel("Status: Standby")
        self.lbl_gpio_status.setStyleSheet("color: #8b94a8; font-family: monospace;")
        test_box.addWidget(self.lbl_gpio_status, 1)
        layout.addLayout(test_box)

        layout.addStretch()
        return tab

    def _test_gpio(self):
        self.lbl_gpio_status.setText("Testing GPIO...")
        self.io_manager.gpio_client.host = self.edit_gpio_host.text().strip()
        self.io_manager.gpio_client.port = self.spin_gpio_port.value()
        self.io_manager.gpio_client.pass_pin = self.spin_gpio_pass.value()
        self.io_manager.gpio_client.fail_pin = self.spin_gpio_fail.value()
        self.io_manager.gpio_client.ready_pin = self.spin_gpio_ready.value()
        self.io_manager.gpio_client.strobe_pin = self.spin_gpio_strobe.value()
        self.io_manager.gpio_client.trigger_pin = self.spin_gpio_trig.value()

        try:
            self.io_manager.gpio_client.connect()
            self.io_manager.gpio_client.output_inspection_result(passed=True, strobe_ms=100)
            mode = self.io_manager.gpio_client.mode
            self.lbl_gpio_status.setText(f"✅ Success! Pulsed PASS (Pin {self.spin_gpio_pass.value()}) and Strobe ({mode} mode)")
            self.lbl_gpio_status.setStyleSheet("color: #00e676; font-weight: bold;")
        except Exception as e:
            self.lbl_gpio_status.setText(f"❌ Error: {e}")
            self.lbl_gpio_status.setStyleSheet("color: #ff1744;")

    # ------------------ SAVE SETTINGS ------------------

    def _save_settings(self):
        """Applies UI values to IndustrialIoManager and saves config_industrial_io.json."""
        # Enable flags
        self.io_manager.enable_siemens = self.chk_siemens.isChecked()
        self.io_manager.enable_delta = self.chk_delta.isChecked()
        self.io_manager.enable_beckhoff = self.chk_beckhoff.isChecked()
        self.io_manager.enable_ethernet = self.chk_ethernet.isChecked()
        self.io_manager.enable_gpio = self.chk_gpio.isChecked()

        # Siemens
        self.io_manager.siemens_client.host = self.edit_s7_ip.text().strip()
        self.io_manager.siemens_client.rack = self.spin_s7_rack.value()
        self.io_manager.siemens_client.slot = self.spin_s7_slot.value()
        self.io_manager.siemens_config["db_number"] = self.spin_s7_db.value()
        self.io_manager.siemens_config["start_byte"] = self.spin_s7_byte.value()

        # Delta
        self.io_manager.delta_client.host = self.edit_delta_ip.text().strip()
        self.io_manager.delta_client.port = self.spin_delta_port.value()
        self.io_manager.delta_client.unit_id = self.spin_delta_unit.value()
        self.io_manager.delta_config["d_start"] = self.spin_delta_d.value()
        self.io_manager.delta_config["m_pass"] = self.spin_delta_m.value()

        # Beckhoff
        self.io_manager.beckhoff_client.host = self.edit_beckhoff_ip.text().strip()
        self.io_manager.beckhoff_client.ams_net_id = self.edit_beckhoff_ams.text().strip()
        self.io_manager.beckhoff_client.ads_port = self.spin_beckhoff_port.value()
        self.io_manager.beckhoff_config["byte_offset"] = self.spin_beckhoff_offset.value()

        # Ethernet
        self.io_manager.ethernet_client.target_ip = self.edit_eth_ip.text().strip()
        self.io_manager.ethernet_client.port = self.spin_eth_port.value()
        self.io_manager.ethernet_client.protocol = self.combo_eth_proto.currentText()
        self.io_manager.ethernet_client.mode = self.combo_eth_mode.currentText()
        self.io_manager.ethernet_client.data_format = self.combo_eth_fmt.currentText()

        # GPIO
        self.io_manager.gpio_client.host = self.edit_gpio_host.text().strip()
        self.io_manager.gpio_client.port = self.spin_gpio_port.value()
        self.io_manager.gpio_client.pass_pin = self.spin_gpio_pass.value()
        self.io_manager.gpio_client.fail_pin = self.spin_gpio_fail.value()
        self.io_manager.gpio_client.ready_pin = self.spin_gpio_ready.value()
        self.io_manager.gpio_client.strobe_pin = self.spin_gpio_strobe.value()
        self.io_manager.gpio_client.trigger_pin = self.spin_gpio_trig.value()

        self.io_manager.save_config()
        self.accept()
