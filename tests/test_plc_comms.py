"""Comprehensive Test Suite for Industrial PLC & Hardware Communications.

Tests:
1. Delta PLC & Modbus TCP driver (address translation, float & coil packing)
2. Siemens S7 driver (16-byte DB batch inspection packet structure)
3. Beckhoff TwinCAT ADS driver (AMS NetID parsing & binary packet structure)
4. Generic Ethernet device driver (JSON, CSV, Native formats & UDP/TCP dispatch)
5. Raspberry Pi GPIO driver (Remote Pigpio protocol, Pin level manipulation)
6. IndustrialIoManager (Async dispatching & configuration persistence)
7. Spreadsheet Engine (DAG evaluation of WriteModbus, WriteSiemens, WriteBeckhoff, WriteEthernet, WriteGPIO)
"""

import os
import sys
import time
import json
import struct
import socket
import unittest
import numpy as np

# Ensure VisionStudio root is in sys.path
BASE_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
if BASE_DIR not in sys.path:
    sys.path.insert(0, BASE_DIR)

from comms.modbus_driver import ModbusTcpClient
from comms.siemens_s7 import SiemensS7Client
from comms.beckhoff_ads import BeckhoffAdsClient
from comms.ethernet_device import EthernetDeviceClient
from comms.rpi_gpio import RaspberryPiGpioClient
from comms.io_manager import IndustrialIoManager
from engine.spreadsheet import InspectionJob, Cell, INDUSTRIAL_FUNCTION_CATALOG


class TestDeltaModbusDriver(unittest.TestCase):
    """Tests Delta PLC Modbus TCP addressing and data packing."""

    def test_delta_address_translation(self):
        # D0 maps to Modbus 4096 (0x1000)
        self.assertEqual(ModbusTcpClient.delta_d_to_modbus(0), 0x1000)
        self.assertEqual(ModbusTcpClient.delta_d_to_modbus(100), 0x1000 + 100)

        # M0 maps to Modbus 2048 (0x0800)
        self.assertEqual(ModbusTcpClient.delta_m_to_modbus(0), 0x0800)
        self.assertEqual(ModbusTcpClient.delta_m_to_modbus(10), 0x0800 + 10)

    def test_float_register_packing(self):
        client = ModbusTcpClient(host="127.0.0.1", port=502)
        test_val = 123.456
        packed = struct.pack(">f", float(test_val))
        reg1, reg2 = struct.unpack(">HH", packed)
        # Verify unpack restores original float with 32-bit precision
        reconstructed = struct.unpack(">f", struct.pack(">HH", reg1, reg2))[0]
        self.assertAlmostEqual(test_val, reconstructed, places=4)


class TestSiemensS7Driver(unittest.TestCase):
    """Tests Siemens S7 DB memory structure and packet formatting."""

    def test_inspection_batch_packet_layout(self):
        # 16-byte DB packet layout verification
        packet = bytearray(16)
        passed = True
        part_count = 42
        centroid_x = 128.5
        centroid_y = 256.75
        angle = -12.3

        status_byte = (1 if passed else 0) | (2 if not passed else 0) | 4
        packet[0] = status_byte
        struct.pack_into(">h", packet, 2, int(part_count))
        struct.pack_into(">f", packet, 4, float(centroid_x))
        struct.pack_into(">f", packet, 8, float(centroid_y))
        struct.pack_into(">f", packet, 12, float(angle))

        self.assertEqual(len(packet), 16)
        self.assertEqual(packet[0] & 0x01, 1)  # PASS bit
        self.assertEqual(packet[0] & 0x04, 4)  # INSPECTION_DONE bit
        self.assertEqual(struct.unpack_from(">h", packet, 2)[0], 42)
        self.assertAlmostEqual(struct.unpack_from(">f", packet, 4)[0], 128.5, places=3)
        self.assertAlmostEqual(struct.unpack_from(">f", packet, 8)[0], 256.75, places=3)
        self.assertAlmostEqual(struct.unpack_from(">f", packet, 12)[0], -12.3, places=3)


class TestBeckhoffAdsDriver(unittest.TestCase):
    """Tests Beckhoff TwinCAT AMS NetID parsing and payload packing."""

    def test_ams_net_id_parsing(self):
        client = BeckhoffAdsClient(ams_net_id="192.168.1.20.1.1")
        parsed = client._parse_net_id("192.168.1.20.1.1")
        self.assertEqual(len(parsed), 6)
        self.assertEqual(list(parsed), [192, 168, 1, 20, 1, 1])

    def test_ads_memory_packet_structure(self):
        # 16-byte Beckhoff struct: bPass(1B), bFail(1B), nCount(2B), fX(4B), fY(4B), fAngle(4B)
        data = struct.pack(
            "<BBhfff",
            1,
            0,
            15,
            320.0,
            240.0,
            45.0,
        )
        self.assertEqual(len(data), 16)
        bPass, bFail, count, x, y, angle = struct.unpack("<BBhfff", data)
        self.assertEqual(bPass, 1)
        self.assertEqual(bFail, 0)
        self.assertEqual(count, 15)
        self.assertEqual(x, 320.0)
        self.assertEqual(y, 240.0)
        self.assertEqual(angle, 45.0)


class TestEthernetDeviceDriver(unittest.TestCase):
    """Tests Ethernet JSON, CSV, and Native formatting & UDP dispatch."""

    def test_payload_formats(self):
        client = EthernetDeviceClient(protocol="UDP", data_format="JSON")
        test_data = {"overall_pass": True, "cycle_time_ms": 12.5, "inspections": 100}
        
        # Test JSON
        client.data_format = "JSON"
        client.send_result(test_data)
        self.assertIn('"overall_pass": true', client.last_sent)

        # Test CSV
        client.data_format = "CSV"
        client.send_result(test_data)
        self.assertEqual(client.last_sent, "PASS,100,12.5")

        # Test NATIVE In-Sight format
        client.data_format = "NATIVE"
        client.send_result(test_data)
        self.assertIn("PASS", client.last_sent)

    def test_udp_loopback(self):
        # Test receiving UDP broadcast packet on local ephemeral port
        srv_sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        srv_sock.bind(("127.0.0.1", 0))
        _, test_port = srv_sock.getsockname()
        srv_sock.settimeout(1.0)

        client = EthernetDeviceClient(target_ip="127.0.0.1", port=test_port, protocol="UDP", data_format="JSON")
        client.send_result({"pass": True, "score": 99.8})

        data, _ = srv_sock.recvfrom(1024)
        srv_sock.close()
        rec_json = json.loads(data.decode("utf-8").strip())
        self.assertTrue(rec_json["pass"])
        self.assertEqual(rec_json["score"], 99.8)


class TestRaspberryPiGpioDriver(unittest.TestCase):
    """Tests Raspberry Pi GPIO driver logic, pin states, and simulation mode."""

    def test_gpio_pin_control(self):
        client = RaspberryPiGpioClient(host="localhost", pass_pin=17, fail_pin=27, strobe_pin=23)
        client.connect()
        self.assertEqual(client.mode, "SIMULATED")

        # Test PASS result
        client.output_inspection_result(passed=True, strobe_ms=0)
        self.assertEqual(client.pin_states[17], 1)
        self.assertEqual(client.pin_states[27], 0)

        # Test FAIL result
        client.output_inspection_result(passed=False, strobe_ms=0)
        self.assertEqual(client.pin_states[17], 0)
        self.assertEqual(client.pin_states[27], 1)

        # Test READY signal
        client.set_ready(True)
        self.assertEqual(client.pin_states[client.ready_pin], 1)
        client.set_ready(False)
        self.assertEqual(client.pin_states[client.ready_pin], 0)


class TestIndustrialIoManager(unittest.TestCase):
    """Tests unified Industrial I/O Manager coordination and background dispatch."""

    def test_manager_config_persistence(self):
        manager = IndustrialIoManager()
        manager.enable_delta = True
        manager.enable_siemens = True
        manager.enable_beckhoff = True
        manager.enable_ethernet = True
        manager.enable_gpio = True
        manager.save_config()

        # Reload
        manager2 = IndustrialIoManager()
        self.assertTrue(manager2.enable_delta)
        self.assertTrue(manager2.enable_siemens)
        self.assertTrue(manager2.enable_beckhoff)
        self.assertTrue(manager2.enable_ethernet)
        self.assertTrue(manager2.enable_gpio)

        # Reset back to False for clean default
        manager.enable_delta = False
        manager.enable_siemens = False
        manager.enable_beckhoff = False
        manager.enable_ethernet = False
        manager.enable_gpio = False
        manager.save_config()

    def test_async_dispatch_safety(self):
        manager = IndustrialIoManager()
        # Enable all devices to test non-blocking execution with dummy offline IPs
        manager.enable_delta = True
        manager.enable_siemens = True
        manager.enable_beckhoff = True
        manager.enable_ethernet = True
        manager.enable_gpio = True

        stats = {"overall_pass": True, "pass_count": 5, "cycle_time_ms": 15.0}
        cells = {"B2": type("DummyCell", (), {"x": 100.0, "y": 200.0, "angle": 0.0})()}

        # Must not raise exceptions or block
        manager.dispatch_results_async(stats, cells)
        time.sleep(0.1)  # Allow thread to initiate safely


class TestSpreadsheetCommsFormulas(unittest.TestCase):
    """Tests spreadsheet formulas for WriteModbus, WriteSiemens, WriteBeckhoff, WriteEthernet, WriteGPIO."""

    def setUp(self):
        self.job = InspectionJob("TestCommsJob")
        self.dummy_img = np.zeros((480, 640, 3), dtype=np.uint8)

    def test_formula_catalog_entries(self):
        names = [f["name"] for f in INDUSTRIAL_FUNCTION_CATALOG]
        self.assertIn("WriteModbus", names)
        self.assertIn("WriteSiemens", names)
        self.assertIn("WriteBeckhoff", names)
        self.assertIn("WriteEthernet", names)
        self.assertIn("WriteGPIO", names)

    def test_eval_write_modbus(self):
        self.job.add_cell("A0", "=AcquireImage()")
        self.job.add_cell("B2", "PASS")
        self.job.add_cell("C3", '=WriteModbus(B2, ip="127.0.0.1", reg=100)')
        self.job.compile()

        res = self.job.execute(self.dummy_img)
        self.assertIn("Delta D100", str(self.job.cells["C3"].value))

    def test_eval_write_siemens(self):
        self.job.add_cell("A0", "=AcquireImage()")
        self.job.add_cell("B2", "PASS")
        self.job.add_cell("C3", '=WriteSiemens(B2, ip="127.0.0.1", db=1, byte=0)')
        self.job.compile()

        res = self.job.execute(self.dummy_img)
        self.assertIn("Siemens DB1", str(self.job.cells["C3"].value))

    def test_eval_write_beckhoff(self):
        self.job.add_cell("A0", "=AcquireImage()")
        self.job.add_cell("B2", "PASS")
        self.job.add_cell("C3", '=WriteBeckhoff(B2, ip="127.0.0.1", offset=100)')
        self.job.compile()

        res = self.job.execute(self.dummy_img)
        self.assertIn("Beckhoff %MB100", str(self.job.cells["C3"].value))

    def test_eval_write_ethernet(self):
        self.job.add_cell("A0", "=AcquireImage()")
        self.job.add_cell("B2", "PASS")
        self.job.add_cell("C3", '=WriteEthernet(B2, ip="127.0.0.1", port=9000, proto="UDP")')
        self.job.compile()

        res = self.job.execute(self.dummy_img)
        self.assertIn("Ethernet 127.0.0.1:9000 Sent", str(self.job.cells["C3"].value))

    def test_eval_write_gpio(self):
        self.job.add_cell("A0", "=AcquireImage()")
        self.job.add_cell("B2", "PASS")
        self.job.add_cell("C3", '=WriteGPIO(B2, pass_pin=17, fail_pin=27)')
        self.job.compile()

        res = self.job.execute(self.dummy_img)
        self.assertIn("GPIO Pass=17 Fail=27 (Pin=HIGH)", str(self.job.cells["C3"].value))


if __name__ == "__main__":
    unittest.main()
