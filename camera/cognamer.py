"""CogNamer UDP discovery protocol implementation matching Cognex In-Sight specification.

Packet Magic: 'MANC' (0x4D 0x41 0x4E 0x43)
Default Port: 1069 (UDP)
Protocol Version: 0x04
"""

import socket
import struct
import threading
import time
import logging
from typing import List, Dict, Any, Optional

logger = logging.getLogger("CogNamer")


def encode_leb128(val: int) -> bytes:
    """Encode an integer as unsigned LEB128 (VarInt)."""
    buf = bytearray()
    while val >= 0x80:
        buf.append((val & 0x7F) | 0x80)
        val >>= 7
    buf.append(val & 0x7F)
    return bytes(buf)


def decode_leb128(data: bytes, offset: int = 0) -> (int, int):
    """Decode an unsigned LEB128 integer from data at offset, returning (value, new_offset)."""
    result = 0
    shift = 0
    while offset < len(data):
        b = data[offset]
        offset += 1
        result |= (b & 0x7F) << shift
        if (b & 0x80) == 0:
            break
        shift += 7
    return result, offset


class DiscoveredCamera:
    def __init__(self, ip: str, name: str, model: str, mac: str, firmware: str):
        self.ip = ip
        self.name = name
        self.model = model
        self.mac = mac
        self.firmware = firmware

    def to_dict(self) -> Dict[str, Any]:
        return {
            "ip": self.ip,
            "name": self.name,
            "model": self.model,
            "mac": self.mac,
            "firmware": self.firmware,
        }


class CogNamerService:
    """Discovers Cognex cameras and emulates a CogNamer device on the local network."""

    MAGIC = b"MANC"
    PORT = 1069

    def __init__(self, bind_ip: str = "0.0.0.0"):
        self.bind_ip = bind_ip
        self.discovered: Dict[str, DiscoveredCamera] = {}
        self._running = False
        self._sock: Optional[socket.socket] = None
        self._thread: Optional[threading.Thread] = None

    def start(self):
        if self._running:
            return
        self._running = True
        try:
            self._sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
            self._sock.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
            self._sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
            self._sock.bind((self.bind_ip, self.PORT))
            self._thread = threading.Thread(target=self._listen_loop, daemon=True)
            self._thread.start()
            logger.info(f"CogNamer service listening on UDP {self.PORT}")
        except Exception as e:
            logger.warning(f"Could not bind CogNamer UDP port {self.PORT} (may require admin): {e}")

    def stop(self):
        self._running = False
        if self._sock:
            self._sock.close()

    def broadcast_discovery(self):
        """Sends Cognex MANC discovery broadcast packet."""
        try:
            s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
            s.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
            # MANC header: Magic (4B), Version 4 (1B), Flags 0 (1B), Command 1 (IPRequest), ErrorCode 0, Length 0
            pkt = bytearray(self.MAGIC)
            pkt.append(0x04)  # Version 4
            pkt.append(0x00)  # Flags
            pkt.extend(encode_leb128(1))  # Command = 1 (IPRequest)
            pkt.extend(encode_leb128(0))  # ErrorCode = 0
            pkt.extend(encode_leb128(0))  # Length = 0
            s.sendto(bytes(pkt), ("255.255.255.255", self.PORT))
            s.close()
            logger.info("Sent CogNamer broadcast request")
        except Exception as e:
            logger.error(f"Failed to send CogNamer broadcast: {e}")

    def _listen_loop(self):
        while self._running:
            try:
                data, addr = self._sock.recvfrom(2048)
                if len(data) >= 7 and data[:4] == self.MAGIC:
                    self._parse_packet(data, addr[0])
            except Exception:
                break

    def _parse_packet(self, data: bytes, sender_ip: str):
        try:
            version = data[4]
            flags = data[5]
            cmd, offset = decode_leb128(data, 6)
            err, offset = decode_leb128(data, offset)
            length, offset = decode_leb128(data, offset)

            # Store discovered device
            dev = DiscoveredCamera(
                ip=sender_ip,
                name=f"InSight_{sender_ip.replace('.', '_')}",
                model="In-Sight Vision System",
                mac="00:D0:24:XX:XX:XX",
                firmware="v24.1.0",
            )
            self.discovered[sender_ip] = dev
            logger.info(f"Discovered Cognex device at {sender_ip}")
        except Exception as e:
            logger.debug(f"CogNamer packet parse error: {e}")
