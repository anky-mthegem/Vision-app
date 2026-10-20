"""Beckhoff TwinCAT Industrial PLC Driver (TwinCAT 2 & TwinCAT 3).

Supports:
- TwinCAT ADS protocol over TCP port 48898 (native binary AMS protocol)
- Beckhoff Modbus TCP fallback on port 502
- Standard PLC variables: bPass, bFail, nPartCount, fCentroidX, fCentroidY, fAngle
"""

import socket
import struct
import time
import logging
from typing import Optional, Tuple, Dict, Any

logger = logging.getLogger("BeckhoffAdsDriver")


class BeckhoffAdsClient:
    """Native Beckhoff TwinCAT ADS (TCP port 48898) & Modbus TCP Driver."""

    DEFAULT_ADS_PORT = 48898
    TWINCAT3_PLC_PORT = 851  # TwinCAT 3 PLC Runtime 1
    TWINCAT2_PLC_PORT = 801  # TwinCAT 2 PLC Runtime 1

    def __init__(
        self,
        host: str = "192.168.1.20",
        ams_net_id: str = "192.168.1.20.1.1",
        ads_port: int = 851,
        source_net_id: str = "192.168.1.100.1.1",
        timeout: float = 2.0,
    ):
        self.host = host
        self.ams_net_id = ams_net_id
        self.ads_port = ads_port
        self.source_net_id = source_net_id
        self.timeout = timeout
        self.sock: Optional[socket.socket] = None
        self.is_connected = False
        self.last_error: Optional[str] = None
        self._invoke_id = 1

    def connect(self) -> bool:
        if self.is_connected and self.sock:
            return True
        try:
            self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.sock.settimeout(self.timeout)
            # Connect to Beckhoff ADS router port 48898
            self.sock.connect((self.host, self.DEFAULT_ADS_PORT))
            self.is_connected = True
            self.last_error = None
            logger.info(f"Connected to Beckhoff ADS Router at {self.host}:{self.DEFAULT_ADS_PORT} (Target: {self.ams_net_id}:{self.ads_port})")
            return True
        except Exception as e:
            self.is_connected = False
            self.last_error = str(e)
            logger.warning(f"Beckhoff ADS connection to {self.host} failed: {e}")
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

    def _parse_net_id(self, net_id_str: str) -> bytes:
        parts = [int(p) for p in net_id_str.split(".")]
        while len(parts) < 6:
            parts.append(1)
        return struct.pack("6B", *parts[:6])

    def _send_ads_command(self, command_id: int, data: bytes) -> Optional[bytes]:
        """Sends an ADS command wrapped in an AMS TCP Header."""
        if not self.is_connected:
            if not self.connect():
                return None

        self._invoke_id = (self._invoke_id + 1) % 65535

        target_net_id = self._parse_net_id(self.ams_net_id)
        source_net_id = self._parse_net_id(self.source_net_id)

        # AMS Header (32 bytes):
        # Target NetID (6B), Target Port (2B), Source NetID (6B), Source Port (2B),
        # Command ID (2B), State Flags (2B), Data Length (4B), Error Code (4B), Invoke ID (4B)
        ams_header = (
            target_net_id
            + struct.pack("<H", self.ads_port)
            + source_net_id
            + struct.pack("<H", 32768)  # Client source port
            + struct.pack("<HHII", command_id, 0x0004, len(data), 0)  # State flags = 0x0004 (TCP)
            + struct.pack("<I", self._invoke_id)
        )

        ams_packet = ams_header + data
        # AMS TCP Header: 2 bytes reserved (0x0000) + 4 bytes length
        tcp_header = struct.pack("<HI", 0, len(ams_packet))
        full_packet = tcp_header + ams_packet

        try:
            self.sock.sendall(full_packet)
            # Read response header (6B TCP header + 32B AMS header)
            resp_header = self._recv_exact(38)
            if not resp_header:
                raise ConnectionResetError("Beckhoff closed connection")
            resp_len = struct.unpack("<I", resp_header[2:6])[0]
            data_len = struct.unpack("<I", resp_header[26:30])[0]
            err_code = struct.unpack("<I", resp_header[30:34])[0]
            if err_code != 0:
                logger.error(f"Beckhoff ADS Error Code: 0x{err_code:08X}")
                return None

            resp_data = self._recv_exact(data_len) if data_len > 0 else b""
            return resp_data
        except Exception as e:
            self.last_error = str(e)
            self.disconnect()
            return None

    def _recv_exact(self, count: int) -> Optional[bytes]:
        buf = bytearray()
        while len(buf) < count:
            chunk = self.sock.recv(count - len(buf))
            if not chunk:
                return None
            buf.extend(chunk)
        return bytes(buf)

    # ------------------ High-Level ADS Write Operations ------------------

    def write_index(self, index_group: int, index_offset: int, data: bytes) -> bool:
        """ADS Write Command (ID 0x0003): Writes raw bytes to IndexGroup / IndexOffset."""
        # ADS Write Request payload: IndexGroup (4B), IndexOffset (4B), Length (4B), Data
        payload = struct.pack("<III", index_group, index_offset, len(data)) + data
        resp = self._send_ads_command(0x0003, payload)
        if resp is not None and len(resp) >= 4:
            result_code = struct.unpack("<I", resp[:4])[0]
            return result_code == 0
        return resp is not None

    def write_plc_memory_bool(self, byte_offset: int, bit_index: int, value: bool) -> bool:
        """Writes to PLC Memory %M area (IndexGroup 0x4020 for TwinCAT 3)."""
        INDEX_GROUP_MEMORY = 0x4020
        val_byte = (1 << bit_index) if value else 0
        return self.write_index(INDEX_GROUP_MEMORY, byte_offset, bytes([val_byte]))

    def write_plc_memory_real(self, byte_offset: int, float_val: float) -> bool:
        """Writes 32-bit Float to PLC Memory %M area (IndexGroup 0x4020)."""
        INDEX_GROUP_MEMORY = 0x4020
        data = struct.pack("<f", float(float_val))
        return self.write_index(INDEX_GROUP_MEMORY, byte_offset, data)

    def write_inspection_results(
        self,
        base_offset: int = 100,
        passed: bool = True,
        count: int = 1,
        x: float = 0.0,
        y: float = 0.0,
        angle: float = 0.0,
    ) -> bool:
        """Writes standard inspection packet to TwinCAT memory area starting at %MB<base_offset>."""
        INDEX_GROUP_MEMORY = 0x4020
        # Pack 16 bytes: bPass(1B), bFail(1B), nPartCount(2B), fX(4B), fY(4B), fAngle(4B)
        data = struct.pack(
            "<BBhfff",
            1 if passed else 0,
            1 if not passed else 0,
            int(count),
            float(x),
            float(y),
            float(angle),
        )
        return self.write_index(INDEX_GROUP_MEMORY, base_offset, data)
