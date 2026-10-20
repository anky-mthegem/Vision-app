"""Cognex In-Sight Native Mode Communications Protocol Server (TCP Port 23 / 1023).

Implements authentic ASCII two-letter In-Sight command set:
- GV <cell>: Get cell value / tool result
- SI <cell> <int>: Set integer in cell
- SF <cell> <float>: Set float in cell
- SS <cell> <string>: Set string in cell
- SE <event>: Trigger event (e.g. SE 8 = Software Trigger)
- SW: Software trigger image acquisition
- SO <0|1>: Set Online / Offline
- GO: Get Online status (1 = Online, 0 = Offline)
- RB: Read inspection buffer
- RT: Read last cycle time (ms)
"""

import socket
import threading
import logging
from typing import Optional, Callable, Dict, Any

logger = logging.getLogger("NativeMode")


class NativeModeServer:
    """Telnet / Raw TCP ASCII command server matching In-Sight Native Mode."""

    def __init__(self, job_getter_cb: Callable[[], Any], trigger_cb: Callable[[], None], port: int = 1023):
        self.job_getter = job_getter_cb
        self.trigger_cb = trigger_cb
        self.port = port
        self.is_online = 1
        self._running = False
        self._server_sock: Optional[socket.socket] = None
        self._thread: Optional[threading.Thread] = None

    def start(self):
        if self._running:
            return
        self._running = True
        try:
            self._server_sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self._server_sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
            self._server_sock.bind(("0.0.0.0", self.port))
            self._server_sock.listen(5)
            self._thread = threading.Thread(target=self._accept_loop, daemon=True)
            self._thread.start()
            logger.info(f"In-Sight Native Mode server listening on TCP port {self.port}")
        except Exception as e:
            logger.error(f"Failed to start Native Mode server on port {self.port}: {e}")

    def stop(self):
        self._running = False
        if self._server_sock:
            self._server_sock.close()

    def _accept_loop(self):
        while self._running:
            try:
                conn, addr = self._server_sock.accept()
                threading.Thread(target=self._client_handler, args=(conn, addr), daemon=True).start()
            except Exception:
                break

    def _client_handler(self, conn: socket.socket, addr):
        logger.info(f"Native Mode client connected: {addr}")
        conn.sendall(b"Welcome to VisionStudio In-Sight Native Mode Server\r\n")

        buffer = ""
        while self._running:
            try:
                data = conn.recv(1024)
                if not data:
                    break
                buffer += data.decode("utf-8", errors="ignore")

                while "\r\n" in buffer or "\n" in buffer:
                    if "\r\n" in buffer:
                        cmd_line, buffer = buffer.split("\r\n", 1)
                    else:
                        cmd_line, buffer = buffer.split("\n", 1)

                    cmd_line = cmd_line.strip()
                    if not cmd_line:
                        continue

                    response = self._process_command(cmd_line)
                    conn.sendall(response.encode("utf-8") + b"\r\n")

            except Exception as e:
                logger.debug(f"Native Mode client error: {e}")
                break

        conn.close()
        logger.info(f"Native Mode client disconnected: {addr}")

    def _process_command(self, cmd: str) -> str:
        parts = cmd.split()
        if not parts:
            return "-1"

        verb = parts[0].upper()
        job = self.job_getter()

        # GV: Get Value
        if verb == "GV":
            if len(parts) < 2:
                return "-1"
            coord_expr = parts[1].upper()
            cell_parts = coord_expr.split(".")
            cell_name = cell_parts[0]

            if not job or cell_name not in job.cells:
                return "-2"  # Error: cell not found

            cell = job.cells[cell_name]
            val = cell.value

            if len(cell_parts) > 1 and hasattr(val, cell_parts[1].lower()):
                return f"1\r\n{getattr(val, cell_parts[1].lower())}"
            elif hasattr(val, "to_dict"):
                return f"1\r\n{val.to_dict()}"
            return f"1\r\n{val}"

        # SW: Software Trigger
        elif verb == "SW":
            self.trigger_cb()
            return "1"

        # SE: Set Event (SE 8 = Trigger)
        elif verb == "SE":
            if len(parts) >= 2 and parts[1] == "8":
                self.trigger_cb()
                return "1"
            return "1"

        # SO: Set Online
        elif verb == "SO":
            if len(parts) >= 2:
                self.is_online = 1 if parts[1] == "1" else 0
                return "1"
            return "-1"

        # GO: Get Online
        elif verb == "GO":
            return f"1\r\n{self.is_online}"

        # RT: Read Cycle Time
        elif verb == "RT":
            if job:
                return f"1\r\n{job.total_cycle_time_ms:.2f}"
            return "1\r\n0.0"

        # RB: Read Buffer
        elif verb == "RB":
            if job:
                status = "PASS" if job.overall_pass else "FAIL"
                return f"1\r\nSTATUS={status};CYCLE_MS={job.total_cycle_time_ms:.1f};TOTAL={job.total_inspections}"
            return "1\r\nREADY"

        # SI: Set Integer
        elif verb == "SI":
            if len(parts) >= 3 and job and parts[1].upper() in job.cells:
                job.cells[parts[1].upper()].set_formula(parts[2])
                return "1"
            return "-1"

        # SS: Set String
        elif verb == "SS":
            if len(parts) >= 3 and job and parts[1].upper() in job.cells:
                text_val = " ".join(parts[2:])
                job.cells[parts[1].upper()].set_formula(f'"{text_val}"')
                return "1"
            return "-1"

        return "-1"  # Unknown command
