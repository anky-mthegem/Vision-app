"""Modbus TCP Industrial Driver for Delta PLC, Schneider, Omron, and Generic Modbus Devices.

Supports:
- Delta PLC (DVP-SE, DVP-SV, AS200, AS300, AH500)
- Delta D-Register mapping (D0 -> Modbus 4096 / 0x1000)
- Delta M-Coil mapping (M0 -> Modbus 2048 / 0x0800)
- Discrete Coils, Holding Registers (16-bit INT, 32-bit DINT, 32-bit FLOAT IEEE-754)
"""

import socket
import struct
import time
import logging
from typing import Optional, List, Tuple, Union, Dict, Any

logger = logging.getLogger("ModbusDriver")


class ModbusTcpClient:
    """Lightweight, resilient pure Python Modbus TCP client."""

    def __init__(self, host: str = "192.168.1.50", port: int = 502, unit_id: int = 1, timeout: float = 2.0):
        self.host = host
        self.port = port
        self.unit_id = unit_id
        self.timeout = timeout
        self.sock: Optional[socket.socket] = None
        self._tx_id = 1
        self.is_connected = False
        self.last_error: Optional[str] = None

    def connect(self) -> bool:
        """Establishes TCP connection to Modbus server/PLC."""
        if self.is_connected and self.sock:
            return True
        try:
            self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.sock.settimeout(self.timeout)
            self.sock.connect((self.host, self.port))
            self.is_connected = True
            self.last_error = None
            logger.info(f"Modbus TCP connected to {self.host}:{self.port} (Unit {self.unit_id})")
            return True
        except Exception as e:
            self.is_connected = False
            self.last_error = str(e)
            logger.warning(f"Modbus connection to {self.host}:{self.port} failed: {e}")
            if self.sock:
                try:
                    self.sock.close()
                except Exception:
                    pass
                self.sock = None
            return False

    def disconnect(self):
        self.is_connected = False
        if self.sock:
            try:
                self.sock.close()
            except Exception:
                pass
            self.sock = None

    def _next_tx_id(self) -> int:
        self._tx_id = (self._tx_id + 1) % 65535
        return self._tx_id

    def _send_pdu(self, function_code: int, data: bytes) -> Optional[bytes]:
        if not self.is_connected:
            if not self.connect():
                return None

        tx_id = self._next_tx_id()
        pdu = struct.pack("B", function_code) + data
        # MBAP Header: Transaction ID (2B), Protocol ID 0 (2B), Length (2B), Unit ID (1B)
        mbap = struct.pack(">HHHB", tx_id, 0, len(pdu) + 1, self.unit_id)
        packet = mbap + pdu

        try:
            self.sock.sendall(packet)
            header = self._recv_exact(7)
            if not header:
                raise ConnectionResetError("Modbus server closed connection")
            resp_tx, proto, length, unit = struct.unpack(">HHHB", header)
            resp_pdu = self._recv_exact(length - 1)
            if not resp_pdu:
                raise ConnectionResetError("Empty PDU received")

            resp_fc = resp_pdu[0]
            if resp_fc & 0x80:
                err_code = resp_pdu[1] if len(resp_pdu) > 1 else 0
                logger.error(f"Modbus Exception: FC {function_code} returned error 0x{err_code:02X}")
                return None
            return resp_pdu[1:]
        except Exception as e:
            self.last_error = str(e)
            self.disconnect()
            return None

    def _recv_exact(self, num_bytes: int) -> Optional[bytes]:
        buf = bytearray()
        while len(buf) < num_bytes:
            chunk = self.sock.recv(num_bytes - len(buf))
            if not chunk:
                return None
            buf.extend(chunk)
        return bytes(buf)

    # ------------------ High-Level Operations ------------------

    def write_coil(self, address: int, value: bool) -> bool:
        """FC 0x05: Write Single Coil."""
        val_bytes = struct.pack(">HH", address, 0xFF00 if value else 0x0000)
        resp = self._send_pdu(0x05, val_bytes)
        return resp is not None

    def write_register(self, address: int, value: int) -> bool:
        """FC 0x06: Write Single Register (16-bit INT)."""
        val_bytes = struct.pack(">Hh", address, value)
        resp = self._send_pdu(0x06, val_bytes)
        return resp is not None

    def write_registers(self, address: int, values: List[int]) -> bool:
        """FC 0x10: Write Multiple Registers."""
        count = len(values)
        byte_count = count * 2
        payload = struct.pack(">HHB", address, count, byte_count)
        for v in values:
            payload += struct.pack(">h", int(v))
        resp = self._send_pdu(0x10, payload)
        return resp is not None

    def write_float(self, address: int, float_val: float) -> bool:
        """Writes 32-bit IEEE 754 Float across 2 Holding Registers (CDAB / Little-Endian word order)."""
        # Pack float into 4 bytes
        float_bytes = struct.pack(">f", float(float_val))
        reg1, reg2 = struct.unpack(">HH", float_bytes)
        return self.write_registers(address, [reg1, reg2])

    def read_holding_registers(self, address: int, count: int = 1) -> Optional[List[int]]:
        """FC 0x03: Read Holding Registers."""
        payload = struct.pack(">HH", address, count)
        resp = self._send_pdu(0x03, payload)
        if not resp or len(resp) < 1 + count * 2:
            return None
        byte_len = resp[0]
        regs = []
        for i in range(count):
            reg = struct.unpack(">h", resp[1 + i * 2 : 3 + i * 2])[0]
            regs.append(reg)
        return regs

    def read_coil(self, address: int) -> Optional[bool]:
        """FC 0x01: Read Coil."""
        payload = struct.pack(">HH", address, 1)
        resp = self._send_pdu(0x01, payload)
        if not resp or len(resp) < 2:
            return None
        return bool(resp[1] & 0x01)

    # ------------------ Delta PLC Specific Helpers ------------------

    @staticmethod
    def delta_d_to_modbus(d_num: int) -> int:
        """Converts Delta D-register (e.g. D0, D100) to standard Modbus address (0x1000 = 4096)."""
        return 0x1000 + int(d_num)

    @staticmethod
    def delta_m_to_modbus(m_num: int) -> int:
        """Converts Delta M-coil (e.g. M0, M10) to standard Modbus coil address (0x0800 = 2048)."""
        return 0x0800 + int(m_num)

    def write_delta_d_register(self, d_num: int, value: int) -> bool:
        """Directly writes value to Delta D register (e.g. D100)."""
        addr = self.delta_d_to_modbus(d_num)
        return self.write_register(addr, value)

    def write_delta_d_float(self, d_num: int, float_val: float) -> bool:
        """Directly writes 32-bit Float to Delta D registers (e.g. D100-D101)."""
        addr = self.delta_d_to_modbus(d_num)
        return self.write_float(addr, float_val)

    def write_delta_m_coil(self, m_num: int, state: bool) -> bool:
        """Directly writes boolean Pass/Fail flag to Delta M coil (e.g. M0)."""
        addr = self.delta_m_to_modbus(m_num)
        return self.write_coil(addr, state)
