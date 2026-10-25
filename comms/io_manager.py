"""Industrial Communication & I/O Manager.

Coordinates asynchronous communication dispatch to:
1. Siemens S7 PLC (S7-300, S7-400, S7-1200, S7-1500)
2. Delta PLC (DVP, AS, AH series via Modbus TCP)
3. Beckhoff PLC (TwinCAT ADS & Modbus)
4. Generic Ethernet Devices (TCP Client/Server, UDP Broadcast)
5. Raspberry Pi GPIO (Remote Pigpio & Local Hardware)
"""

import os
import json
import logging
import threading
import time
from typing import Dict, Any, Optional, Callable

from comms.modbus_driver import ModbusTcpClient
from comms.siemens_s7 import SiemensS7Client
from comms.beckhoff_ads import BeckhoffAdsClient
from comms.ethernet_device import EthernetDeviceClient
from comms.rpi_gpio import RaspberryPiGpioClient

logger = logging.getLogger("IndustrialIoManager")


class IndustrialIoManager:
    """Unified Industrial I/O Coordinator for Factory Automation & PLCs."""

    CONFIG_FILE = os.path.join(
        os.path.dirname(os.path.dirname(os.path.abspath(__file__))),
        "config_industrial_io.json",
    )

    def __init__(self, trigger_cb: Optional[Callable[[], None]] = None):
        self.trigger_cb = trigger_cb

        # Device Drivers
        self.delta_client = ModbusTcpClient(host="192.168.1.50", port=502, unit_id=1)
        self.siemens_client = SiemensS7Client(host="192.168.1.10", rack=0, slot=1)
        self.beckhoff_client = BeckhoffAdsClient(host="192.168.1.20", ams_net_id="192.168.1.20.1.1", ads_port=851)
        self.ethernet_client = EthernetDeviceClient(target_ip="192.168.1.100", port=9000, protocol="TCP", mode="Client", trigger_callback=self.trigger_cb)
        self.gpio_client = RaspberryPiGpioClient(host="192.168.1.200", port=8888, trigger_callback=self.trigger_cb)

        # Enable Flags
        self.enable_delta = False
        self.enable_siemens = False
        self.enable_beckhoff = False
        self.enable_ethernet = False
        self.enable_gpio = False

        # Configuration options
        self.delta_config = {"d_start": 100, "m_pass": 0, "m_fail": 1}
        self.siemens_config = {"db_number": 1, "start_byte": 0}
        self.beckhoff_config = {"byte_offset": 100}

        self._load_config()

    def _load_config(self):
        if not os.path.exists(self.CONFIG_FILE):
            return
        try:
            with open(self.CONFIG_FILE, "r") as f:
                data = json.load(f)
            self.enable_delta = data.get("enable_delta", False)
            self.enable_siemens = data.get("enable_siemens", False)
            self.enable_beckhoff = data.get("enable_beckhoff", False)
            self.enable_ethernet = data.get("enable_ethernet", False)
            self.enable_gpio = data.get("enable_gpio", False)

            if "delta" in data:
                d = data["delta"]
                self.delta_client.host = d.get("host", self.delta_client.host)
                self.delta_client.port = d.get("port", self.delta_client.port)
                self.delta_client.unit_id = d.get("unit_id", self.delta_client.unit_id)
                self.delta_config["d_start"] = d.get("d_start", 100)

            if "siemens" in data:
                s = data["siemens"]
                self.siemens_client.host = s.get("host", self.siemens_client.host)
                self.siemens_client.rack = s.get("rack", self.siemens_client.rack)
                self.siemens_client.slot = s.get("slot", self.siemens_client.slot)
                self.siemens_config["db_number"] = s.get("db_number", 1)

            if "beckhoff" in data:
                b = data["beckhoff"]
                self.beckhoff_client.host = b.get("host", self.beckhoff_client.host)
                self.beckhoff_client.ams_net_id = b.get("ams_net_id", self.beckhoff_client.ams_net_id)
                self.beckhoff_client.ads_port = b.get("ads_port", self.beckhoff_client.ads_port)

            if "ethernet" in data:
                e = data["ethernet"]
                self.ethernet_client.target_ip = e.get("target_ip", self.ethernet_client.target_ip)
                self.ethernet_client.port = e.get("port", self.ethernet_client.port)
                self.ethernet_client.protocol = e.get("protocol", self.ethernet_client.protocol)
                self.ethernet_client.mode = e.get("mode", self.ethernet_client.mode)
                self.ethernet_client.data_format = e.get("data_format", self.ethernet_client.data_format)

            if "gpio" in data:
                g = data["gpio"]
                self.gpio_client.host = g.get("host", self.gpio_client.host)
                self.gpio_client.pass_pin = g.get("pass_pin", self.gpio_client.pass_pin)
                self.gpio_client.fail_pin = g.get("fail_pin", self.gpio_client.fail_pin)
                self.gpio_client.ready_pin = g.get("ready_pin", self.gpio_client.ready_pin)
                self.gpio_client.strobe_pin = g.get("strobe_pin", self.gpio_client.strobe_pin)
                self.gpio_client.trigger_pin = g.get("trigger_pin", self.gpio_client.trigger_pin)

        except Exception as e:
            logger.warning(f"Could not load PLC config: {e}")

    def save_config(self):
        data = {
            "enable_delta": self.enable_delta,
            "enable_siemens": self.enable_siemens,
            "enable_beckhoff": self.enable_beckhoff,
            "enable_ethernet": self.enable_ethernet,
            "enable_gpio": self.enable_gpio,
            "delta": {
                "host": self.delta_client.host,
                "port": self.delta_client.port,
                "unit_id": self.delta_client.unit_id,
                "d_start": self.delta_config["d_start"],
            },
            "siemens": {
                "host": self.siemens_client.host,
                "rack": self.siemens_client.rack,
                "slot": self.siemens_client.slot,
                "db_number": self.siemens_config["db_number"],
            },
            "beckhoff": {
                "host": self.beckhoff_client.host,
                "ams_net_id": self.beckhoff_client.ams_net_id,
                "ads_port": self.beckhoff_client.ads_port,
            },
            "ethernet": {
                "target_ip": self.ethernet_client.target_ip,
                "port": self.ethernet_client.port,
                "protocol": self.ethernet_client.protocol,
                "mode": self.ethernet_client.mode,
                "data_format": self.ethernet_client.data_format,
            },
            "gpio": {
                "host": self.gpio_client.host,
                "pass_pin": self.gpio_client.pass_pin,
                "fail_pin": self.gpio_client.fail_pin,
                "ready_pin": self.gpio_client.ready_pin,
                "strobe_pin": self.gpio_client.strobe_pin,
                "trigger_pin": self.gpio_client.trigger_pin,
            },
        }
        try:
            with open(self.CONFIG_FILE, "w") as f:
                json.dump(data, f, indent=2)
            logger.info("Saved PLC & Industrial I/O configuration")
        except Exception as e:
            logger.error(f"Failed to save PLC config: {e}")

    # ------------------ High-Speed Result Dispatch ------------------

    def dispatch_step_output(self, step_info: Dict[str, Any]):
        """Dispatches inspection results from a pipeline step to all enabled remote devices."""
        job_stats = {
            "overall_pass": bool(step_info.get("passed", True)),
            "pass_count": 1 if step_info.get("passed", True) else 0,
            "fail_count": 0 if step_info.get("passed", True) else 1,
            "step_id": step_info.get("step_id", 0),
            "step_name": step_info.get("step_name", ""),
            "operation": step_info.get("operation", ""),
            "count": int(step_info.get("count", 1 if step_info.get("passed", True) else 0)),
            "cycle_time_ms": float(step_info.get("latency_ms", 0.0)),
            "x": float(step_info.get("x", 0.0)),
            "y": float(step_info.get("y", 0.0)),
            "angle": float(step_info.get("angle", 0.0)),
            "output_info": str(step_info.get("output_info", "")),
            "output_mode": str(step_info.get("output_mode", "default")),
            "signal_id": int(step_info.get("signal_id", 0)),
            "numeric_value": float(step_info.get("numeric_value", step_info.get("output_value", 0.0))),
            "text_value": str(step_info.get("text_value", "")),
            "target_class": str(step_info.get("target_class", "")),
            "display_str": str(step_info.get("display_str", "")),
            "signal_active": bool(step_info.get("signal_active", True)),
            "timestamp": time.time(),
        }
        self.dispatch_results_async(job_stats, {})

    def dispatch_results_async(self, job_stats: Dict[str, Any], cells_data: Optional[Dict[str, Any]] = None):
        """Dispatches inspection results to all enabled PLCs and GPIO in background thread."""
        threading.Thread(target=self._dispatch_worker, args=(job_stats, cells_data or {}), daemon=True).start()

    def _dispatch_worker(self, stats: Dict[str, Any], cells: Dict[str, Any]):
        passed = bool(stats.get("overall_pass", True))
        count = int(stats.get("count", stats.get("pass_count", 0) if passed else stats.get("fail_count", 0)))
        signal_id = int(stats.get("signal_id", 0))
        numeric_val = float(stats.get("numeric_value", 0.0))

        # Find first measurement / coordinate
        first_x = float(stats.get("x", 0.0))
        first_y = float(stats.get("y", 0.0))
        first_angle = float(stats.get("angle", 0.0))

        if cells and (first_x == 0.0 and first_y == 0.0):
            for val in cells.values():
                if hasattr(val, "x") and hasattr(val, "y"):
                    first_x = float(getattr(val, "x", 0.0))
                    first_y = float(getattr(val, "y", 0.0))
                    first_angle = float(getattr(val, "angle", 0.0))
                    break
                elif hasattr(val, "detections") and getattr(val, "detections"):
                    d = getattr(val, "detections")[0]
                    first_x = float(d.bbox[0] + d.bbox[2] / 2.0)
                    first_y = float(d.bbox[1] + d.bbox[3] / 2.0)
                    break

        # 1. Delta PLC (Modbus TCP)
        if self.enable_delta:
            try:
                # Write Pass/Fail Coil M0
                self.delta_client.write_delta_m_coil(self.delta_config.get("m_pass", 0), passed)
                # Write D-Registers:
                # D100=Pass(1)/Fail(0), D101=Count, D102=X(float), D104=Y(float)
                # D106=Signal ID (or discrete class signal), D108=Continuous Measurement / Value (float)
                d_base = self.delta_config.get("d_start", 100)
                self.delta_client.write_delta_d_register(d_base, 1 if passed else 0)
                self.delta_client.write_delta_d_register(d_base + 1, count)
                self.delta_client.write_delta_d_float(d_base + 2, first_x)
                self.delta_client.write_delta_d_float(d_base + 4, first_y)
                self.delta_client.write_delta_d_register(d_base + 6, signal_id)
                self.delta_client.write_delta_d_float(d_base + 8, numeric_val)
            except Exception as e:
                logger.warning(f"Delta PLC dispatch error: {e}")

        # 2. Siemens S7 PLC
        if self.enable_siemens:
            try:
                db_num = self.siemens_config.get("db_number", 1)
                self.siemens_client.write_inspection_batch(
                    db_number=db_num,
                    start_byte=0,
                    passed=passed,
                    part_count=count,
                    centroid_x=first_x,
                    centroid_y=first_y,
                    angle=first_angle,
                )
            except Exception as e:
                logger.warning(f"Siemens S7 dispatch error: {e}")

        # 3. Beckhoff PLC (TwinCAT ADS)
        if self.enable_beckhoff:
            try:
                offset = self.beckhoff_config.get("byte_offset", 100)
                self.beckhoff_client.write_inspection_results(
                    base_offset=offset,
                    passed=passed,
                    count=count,
                    x=first_x,
                    y=first_y,
                    angle=first_angle,
                )
            except Exception as e:
                logger.warning(f"Beckhoff ADS dispatch error: {e}")

        # 4. Generic Ethernet Device (TCP / UDP)
        if self.enable_ethernet:
            try:
                payload = {
                    "step_id": stats.get("step_id", 0),
                    "step_name": stats.get("step_name", ""),
                    "operation": stats.get("operation", ""),
                    "overall_pass": passed,
                    "count": count,
                    "cycle_time_ms": stats.get("cycle_time_ms", 0.0),
                    "x": round(first_x, 2),
                    "y": round(first_y, 2),
                    "angle": round(first_angle, 2),
                    "output_info": stats.get("output_info", ""),
                    "output_mode": stats.get("output_mode", "default"),
                    "signal_id": signal_id,
                    "numeric_value": round(numeric_val, 4),
                    "text_value": stats.get("text_value", ""),
                    "target_class": stats.get("target_class", ""),
                    "display_str": stats.get("display_str", ""),
                    "signal_active": stats.get("signal_active", True),
                    "timestamp": stats.get("timestamp", time.time()),
                }
                self.ethernet_client.send_result(payload)
            except Exception as e:
                logger.warning(f"Ethernet dispatch error: {e}")

        # 5. Raspberry Pi GPIO
        if self.enable_gpio:
            try:
                # Use evaluated signal_id as class_id for GPIO pin signaling
                self.gpio_client.output_inspection_result(passed=passed, class_id=signal_id, strobe_ms=40)
            except Exception as e:
                logger.warning(f"Raspberry Pi GPIO dispatch error: {e}")
