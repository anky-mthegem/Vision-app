"""Multi-protocol camera acquisition engine supporting USB, RTSP/Ethernet, HTTP, and Industrial Emulation."""

import cv2
import numpy as np
import threading
import time
import logging
from enum import Enum
from typing import Optional, Tuple, Dict, Any, Callable

logger = logging.getLogger("CameraManager")


class CameraProtocol(str, Enum):
    USB = "USB / DirectShow"
    RTSP = "Ethernet / RTSP Stream"
    HTTP = "HTTP Snapshot / MJPEG"
    TEST_STREAM = "Virtual Synthetic Generator"
    FILE_LOOP = "Image / Video File"


class CameraConfig:
    def __init__(
        self,
        protocol: CameraProtocol = CameraProtocol.USB,
        source: str = "0",
        width: int = 1280,
        height: int = 720,
        fps: int = 30,
        name: str = "Default Camera",
        exposure: int = -6,
        gain: int = 0,
    ):
        self.protocol = protocol
        self.source = source  # "0", "rtsp://...", "http://...", "sample.png"
        self.width = width
        self.height = height
        self.fps = fps
        self.name = name
        self.exposure = exposure
        self.gain = gain


class CameraDevice:
    """Thread-safe multi-protocol camera driver."""

    def __init__(self, config: CameraConfig):
        self.config = config
        self._cap: Optional[cv2.VideoCapture] = None
        self._running = False
        self._thread: Optional[threading.Thread] = None
        self._lock = threading.Lock()
        self._latest_frame: Optional[np.ndarray] = None
        self._frame_count = 0
        self._fps_actual = 0.0
        self._last_fps_time = time.time()
        self._fps_counter = 0
        self._on_frame_callbacks = []
        self._trigger_mode = False  # False = Continuous, True = Software Trigger
        self._triggered = False

    def start(self) -> bool:
        if self._running:
            return True

        if self.config.protocol == CameraProtocol.USB:
            try:
                idx = int(self.config.source)
            except ValueError:
                idx = 0
            self._cap = cv2.VideoCapture(idx, cv2.CAP_DSHOW)
            if not self._cap.isOpened():
                self._cap = cv2.VideoCapture(idx)
            if self._cap.isOpened():
                self._cap.set(cv2.CAP_PROP_FRAME_WIDTH, self.config.width)
                self._cap.set(cv2.CAP_PROP_FRAME_HEIGHT, self.config.height)
                self._cap.set(cv2.CAP_PROP_FPS, self.config.fps)

        elif self.config.protocol in (CameraProtocol.RTSP, CameraProtocol.HTTP):
            self._cap = cv2.VideoCapture(self.config.source, cv2.CAP_FFMPEG)
            if self._cap.isOpened():
                self._cap.set(cv2.CAP_PROP_BUFFERSIZE, 1)

        elif self.config.protocol == CameraProtocol.FILE_LOOP:
            self._cap = cv2.VideoCapture(self.config.source)

        self._running = True
        self._thread = threading.Thread(target=self._capture_loop, daemon=True)
        self._thread.start()
        logger.info(f"Camera started: {self.config.name} ({self.config.protocol})")
        return True

    def stop(self):
        self._running = False
        if self._thread and self._thread.is_alive():
            self._thread.join(timeout=1.0)
        if self._cap:
            self._cap.release()
            self._cap = None
        with self._lock:
            self._latest_frame = None
        self._fps_actual = 0.0
        logger.info(f"Camera stopped: {self.config.name}")

    def trigger(self):
        """Software trigger event."""
        self._triggered = True

    def set_trigger_mode(self, enabled: bool):
        self._trigger_mode = enabled

    def get_latest_frame(self) -> Optional[np.ndarray]:
        if not self._running:
            return None
        with self._lock:
            if self._latest_frame is not None:
                return self._latest_frame.copy()
            return None

    def add_frame_callback(self, cb: Callable[[np.ndarray], None]):
        self._on_frame_callbacks.append(cb)

    @property
    def fps(self) -> float:
        return self._fps_actual

    @property
    def frame_count(self) -> int:
        return self._frame_count

    @property
    def is_connected(self) -> bool:
        if self.config.protocol == CameraProtocol.TEST_STREAM:
            return self._running
        return self._running and (self._cap is not None and self._cap.isOpened())

    def _capture_loop(self):
        while self._running:
            frame = None

            if self.config.protocol == CameraProtocol.TEST_STREAM:
                frame = self._generate_synthetic_frame()
                time.sleep(1.0 / max(5, self.config.fps))

            elif self.config.protocol == CameraProtocol.FILE_LOOP:
                if self._cap and self._cap.isOpened():
                    ret, frame = self._cap.read()
                    if not ret:
                        self._cap.set(cv2.CAP_PROP_POS_FRAMES, 0)
                        ret, frame = self._cap.read()
                time.sleep(1.0 / max(1, self.config.fps))

            else:
                if self._cap and self._cap.isOpened():
                    ret, frame = self._cap.read()
                    if not ret:
                        time.sleep(0.05)
                        continue
                else:
                    time.sleep(0.1)
                    continue

            if frame is not None:
                if self._trigger_mode and not self._triggered:
                    continue
                self._triggered = False

                with self._lock:
                    self._latest_frame = frame
                    self._frame_count += 1
                    self._fps_counter += 1

                now = time.time()
                dt = now - self._last_fps_time
                if dt >= 1.0:
                    self._fps_actual = self._fps_counter / dt
                    self._fps_counter = 0
                    self._last_fps_time = now

                for cb in self._on_frame_callbacks:
                    try:
                        cb(frame)
                    except Exception as e:
                        logger.error(f"Error in frame callback: {e}")

    def _generate_synthetic_frame(self) -> np.ndarray:
        """Generates static industrial test pattern: non-rotating, clean calibration card without photos."""
        w, h = self.config.width, self.config.height
        img = np.full((h, w, 3), 35, dtype=np.uint8)

        # Outer frame
        cv2.rectangle(img, (20, 20), (w - 20, h - 20), (50, 50, 50), -1)
        cv2.rectangle(img, (20, 20), (w - 20, h - 20), (100, 100, 100), 2)

        # Static, non-rotating test card
        cx, cy = w // 2, h // 2
        rect_w, rect_h = 440, 280

        # PCB Body
        x1, y1 = cx - rect_w // 2, cy - rect_h // 2
        x2, y2 = cx + rect_w // 2, cy + rect_h // 2
        cv2.rectangle(img, (x1, y1), (x2, y2), (18, 95, 38), -1)
        cv2.rectangle(img, (x1, y1), (x2, y2), (40, 180, 80), 2)

        # Corner Mounting Holes
        for ox, oy in [(-180, -100), (180, -100), (-180, 100), (180, 100)]:
            px, py = cx + ox, cy + oy
            cv2.circle(img, (px, py), 14, (220, 220, 220), -1)
            cv2.circle(img, (px, py), 8, (0, 0, 0), -1)
            cv2.circle(img, (px, py), 3, (220, 220, 220), -1)

        # Central IC Chip (Static, Non-Rotating)
        ic_s = 130
        ic_x1, ic_y1 = cx - ic_s // 2, cy - ic_s // 2
        ic_x2, ic_y2 = cx + ic_s // 2, cy + ic_s // 2
        cv2.rectangle(img, (ic_x1, ic_y1), (ic_x2, ic_y2), (25, 25, 25), -1)
        cv2.rectangle(img, (ic_x1, ic_y1), (ic_x2, ic_y2), (200, 200, 200), 1)
        cv2.circle(img, (ic_x1 + 18, ic_y1 + 18), 5, (230, 230, 230), -1)

        cv2.putText(
            img,
            "VISION TEST TARGET",
            (cx - 72, cy + 5),
            cv2.FONT_HERSHEY_SIMPLEX,
            0.38,
            (210, 210, 210),
            1,
            cv2.LINE_AA,
        )

        # QR Code Matrix
        qrx, qry = cx + 110, cy
        cv2.rectangle(img, (qrx - 28, qry - 28), (qrx + 28, qry + 28), (255, 255, 255), -1)
        cv2.rectangle(img, (qrx - 22, qry - 22), (qrx - 8, qry - 8), (0, 0, 0), -1)
        cv2.rectangle(img, (qrx + 8, qry - 22), (qrx + 22, qry - 8), (0, 0, 0), -1)
        cv2.rectangle(img, (qrx - 22, qry + 8), (qrx - 8, qry + 22), (0, 0, 0), -1)
        cv2.rectangle(img, (qrx - 4, qry - 4), (qrx + 4, qry + 4), (0, 0, 0), -1)

        # Measurement Holes
        cv2.circle(img, (cx - 100, cy + 40), 16, (15, 15, 15), -1)
        cv2.circle(img, (cx - 100, cy + 40), 16, (180, 180, 180), 2)
        cv2.circle(img, (cx - 100, cy - 40), 16, (15, 15, 15), -1)
        cv2.circle(img, (cx - 100, cy - 40), 16, (180, 180, 180), 2)

        t_str = time.strftime("%Y-%m-%d %H:%M:%S")
        cv2.putText(
            img,
            f"STREAM: Static Calibration Target | {t_str} | FPS: {self._fps_actual:.1f}",
            (25, 45),
            cv2.FONT_HERSHEY_SIMPLEX,
            0.5,
            (0, 255, 200),
            1,
            cv2.LINE_AA,
        )

        return img
