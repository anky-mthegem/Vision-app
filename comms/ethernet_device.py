"""Generic Industrial Ethernet Device Communication Driver (TCP & UDP).

Supports:
- TCP Client: Dispatches inspection results to remote robots (Fanuc, ABB, KUKA, Universal Robots) or barcode printers.
- TCP Server: Listens on dedicated port for PLCs and shop-floor MES systems to query results or trigger inspection.
- UDP Unicast / Broadcast: High-speed zero-latency result broadcasting to entire subnets.
- Formats: JSON, CSV, In-Sight Native ASCII, and Custom formatted templates.
"""

import socket
import json
import threading
import time
import logging
from typing import Optional, Callable, Dict, Any, Union

logger = logging.getLogger("EthernetDevice")


class EthernetDeviceClient:
    """Multi-mode Industrial Ethernet communication client and server."""

    def __init__(
        self,
        target_ip: str = "192.168.1.100",
        port: int = 9000,
        protocol: str = "TCP",  # "TCP" or "UDP"
        mode: str = "Client",   # "Client" or "Server"
        data_format: str = "JSON",  # "JSON", "CSV", "NATIVE"
        timeout: float = 2.0,
        trigger_callback: Optional[Callable[[], None]] = None,
    ):
        self.target_ip = target_ip
        self.port = port
        self.protocol = protocol.upper()
        self.mode = mode
        self.data_format = data_format.upper()
        self.timeout = timeout
        self.trigger_callback = trigger_callback

        self.sock: Optional[socket.socket] = None
        self.server_sock: Optional[socket.socket] = None
        self.is_connected = False
        self._running = False
        self._thread: Optional[threading.Thread] = None
        self.last_sent: Optional[str] = None
        self.last_received: Optional[str] = None

    def start(self) -> bool:
        if self._running:
            return True

        self._running = True
        if self.mode == "Server":
            self._thread = threading.Thread(target=self._server_loop, daemon=True)
            self._thread.start()
            logger.info(f"Ethernet {self.protocol} Server started on port {self.port}")
            return True
        elif self.protocol == "TCP":
            return self._connect_tcp_client()
        elif self.protocol == "UDP":
            self.sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
            self.sock.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
            self.is_connected = True
            logger.info(f"Ethernet UDP sender initialized for {self.target_ip}:{self.port}")
            return True
        return False

    def stop(self):
        self._running = False
        self.is_connected = False
        if self.sock:
            try:
                self.sock.close()
            except Exception:
                pass
            self.sock = None
        if self.server_sock:
            try:
                self.server_sock.close()
            except Exception:
                pass
            self.server_sock = None

    def _connect_tcp_client(self) -> bool:
        try:
            self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.sock.settimeout(self.timeout)
            self.sock.connect((self.target_ip, self.port))
            self.is_connected = True
            logger.info(f"Ethernet TCP connected to {self.target_ip}:{self.port}")
            return True
        except Exception as e:
            self.is_connected = False
            if self.sock:
                try:
                    self.sock.close()
                except Exception:
                    pass
                self.sock = None
            logger.debug(f"TCP connection to {self.target_ip}:{self.port} deferred: {e}")
            return False

    def _server_loop(self):
        """TCP server loop listening for client connections & trigger commands."""
        try:
            self.server_sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.server_sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
            self.server_sock.bind(("0.0.0.0", self.port))
            self.server_sock.listen(5)
            self.server_sock.settimeout(1.0)
            self.is_connected = True

            while self._running:
                try:
                    conn, addr = self.server_sock.accept()
                    logger.info(f"Ethernet device connected from {addr[0]}:{addr[1]}")
                    threading.Thread(target=self._handle_client, args=(conn, addr), daemon=True).start()
                except socket.timeout:
                    continue
                except Exception:
                    break
        except Exception as e:
            logger.warning(f"Ethernet Server error: {e}")
        finally:
            self.is_connected = False

    def _handle_client(self, conn: socket.socket, addr: Tuple[str, int]):
        conn.settimeout(1.0)
        while self._running:
            try:
                data = conn.recv(1024)
                if not data:
                    break
                msg = data.decode("utf-8", errors="ignore").strip()
                self.last_received = msg
                logger.info(f"Ethernet packet received: {msg}")

                # Remote trigger handling
                if msg.upper() in ("TRIGGER", "SW", "SNAP", "TRIG"):
                    if self.trigger_callback:
                        self.trigger_callback()
                    conn.sendall(b"TRIGGER_ACK\r\n")
                elif msg.upper() in ("GET", "RESULT", "DATA"):
                    resp = (self.last_sent or "STANDBY") + "\r\n"
                    conn.sendall(resp.encode("utf-8"))
            except socket.timeout:
                continue
            except Exception:
                break
        conn.close()

    # ------------------ Send Inspection Results ------------------

    def send_result(self, result_data: Dict[str, Any]) -> bool:
        """Formats and sends inspection result across active TCP/UDP connection."""
        # 1. Format payload
        payload_str = ""
        if self.data_format == "JSON":
            payload_str = json.dumps(result_data, default=str)
        elif self.data_format == "CSV":
            status = "PASS" if result_data.get("overall_pass", True) else "FAIL"
            inspections = result_data.get("inspections", 0)
            cycle = result_data.get("cycle_time_ms", 0.0)
            payload_str = f"{status},{inspections},{cycle}"
        else:  # NATIVE Cognex In-Sight format
            status_code = 1 if result_data.get("overall_pass", True) else 0
            payload_str = f"{status_code}\r\n{'PASS' if status_code else 'FAIL'}\r\n{result_data.get('cycle_time_ms', 0)}"

        payload_bytes = (payload_str + "\r\n").encode("utf-8")
        self.last_sent = payload_str

        # 2. Dispatch
        if self.protocol == "UDP":
            try:
                if not self.sock:
                    self.sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
                    self.sock.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
                self.sock.sendto(payload_bytes, (self.target_ip, self.port))
                return True
            except Exception as e:
                logger.warning(f"UDP send to {self.target_ip}:{self.port} failed: {e}")
                return False

        elif self.protocol == "TCP":
            if self.mode == "Client":
                if not self.is_connected or not self.sock:
                    if not self._connect_tcp_client():
                        return False
                try:
                    self.sock.sendall(payload_bytes)
                    return True
                except Exception as e:
                    logger.warning(f"TCP send failed: {e}")
                    self.is_connected = False
                    if self.sock:
                        try:
                            self.sock.close()
                        except Exception:
                            pass
                        self.sock = None
                    return False
        return True
