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
        protocol: CameraProtocol = CameraProtocol.TEST_STREAM,
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
        self._synthetic_angle = 0.0
        self._synthetic_x = 0
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
        logger.info(f"Camera stopped: {self.config.name}")

    def trigger(self):
        """Software trigger event."""
        self._triggered = True

    def set_trigger_mode(self, enabled: bool):
        self._trigger_mode = enabled

    def get_latest_frame(self) -> Optional[np.ndarray]:
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
        """Generates dynamic industrial test part: PCB with fiducials, drilled holes, QR code, measurement pins, and inspection object."""
        import os
        w, h = self.config.width, self.config.height
        img = np.full((h, w, 3), 35, dtype=np.uint8)

        cv2.rectangle(img, (20, 20), (w - 20, h - 20), (50, 50, 50), -1)
        cv2.rectangle(img, (20, 20), (w - 20, h - 20), (120, 120, 120), 2)

        # Embed sample object on inspection conveyor for immediate YOLO testing
        if not hasattr(self, "_sample_obj_img"):
            sample_path = os.path.join(os.path.dirname(os.path.abspath(__file__)), "sample_person.jpg")
            if os.path.exists(sample_path):
                raw_s = cv2.imread(sample_path)
                self._sample_obj_img = cv2.resize(raw_s, (180, 420))
            else:
                self._sample_obj_img = None

        if self._sample_obj_img is not None:
            sx = w - 230
            sy = 130
            img[sy : sy + 420, sx : sx + 180] = self._sample_obj_img
            cv2.rectangle(img, (sx - 4, sy - 4), (sx + 184, sy + 424), (0, 210, 255), 1)
            cv2.putText(img, "YOLO TEST BAY", (sx + 20, sy - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.42, (0, 210, 255), 1)

        self._synthetic_angle += 0.5
        if self._synthetic_angle >= 360:
            self._synthetic_angle = 0
        self._synthetic_x = int(np.sin(np.radians(self._synthetic_angle * 2)) * 30)

        cx, cy = w // 2 + self._synthetic_x, h // 2
        rad = np.radians(self._synthetic_angle)

        rect_w, rect_h = 420, 260
        box = cv2.boxPoints(((cx, cy), (rect_w, rect_h), self._synthetic_angle))
        box = np.int32(box)
        cv2.fillPoly(img, [box], (18, 95, 38))
        cv2.polylines(img, [box], True, (40, 180, 80), 2)

        for offset_x, offset_y in [(-170, -100), (170, -100), (-170, 100), (170, 100)]:
            rx = int(offset_x * np.cos(rad) - offset_y * np.sin(rad)) + cx
            ry = int(offset_x * np.sin(rad) + offset_y * np.cos(rad)) + cy
            cv2.circle(img, (rx, ry), 14, (220, 220, 220), -1)
            cv2.circle(img, (rx, ry), 8, (0, 0, 0), -1)
            cv2.circle(img, (rx, ry), 3, (220, 220, 220), -1)

        ic_box = cv2.boxPoints(((cx, cy), (130, 130), self._synthetic_angle))
        ic_box = np.int32(ic_box)
        cv2.fillPoly(img, [ic_box], (25, 25, 25))
        cv2.polylines(img, [ic_box], True, (200, 200, 200), 1)

        dot_x = int(-45 * np.cos(rad) - (-45) * np.sin(rad)) + cx
        dot_y = int(-45 * np.sin(rad) + (-45) * np.cos(rad)) + cy
        cv2.circle(img, (dot_x, dot_y), 5, (230, 230, 230), -1)

        cv2.putText(
            img,
            "IN-SIGHT 8402",
            (cx - 55, cy + 5),
            cv2.FONT_HERSHEY_SIMPLEX,
            0.35,
            (210, 210, 210),
            1,
            cv2.LINE_AA,
        )

        qr_ox, qr_oy = 100, 0
        qrx = int(qr_ox * np.cos(rad) - qr_oy * np.sin(rad)) + cx
        qry = int(qr_ox * np.sin(rad) + qr_oy * np.cos(rad)) + cy
        cv2.rectangle(img, (qrx - 30, qry - 30), (qrx + 30, qry + 30), (255, 255, 255), -1)
        cv2.rectangle(img, (qrx - 25, qry - 25), (qrx - 10, qry - 10), (0, 0, 0), -1)
        cv2.rectangle(img, (qrx + 10, qry - 25), (qrx + 25, qry - 10), (0, 0, 0), -1)
        cv2.rectangle(img, (qrx - 25, qry + 10), (qrx - 10, qry + 25), (0, 0, 0), -1)
        cv2.rectangle(img, (qrx - 5, qry - 5), (qrx + 5, qry + 5), (0, 0, 0), -1)

        h1_ox, h1_oy = -90, 40
        h2_ox, h2_oy = -90, -40
        h1x = int(h1_ox * np.cos(rad) - h1_oy * np.sin(rad)) + cx
        h1y = int(h1_ox * np.sin(rad) + h1_oy * np.cos(rad)) + cy
        h2x = int(h2_ox * np.cos(rad) - h2_oy * np.sin(rad)) + cx
        h2y = int(h2_ox * np.sin(rad) + h2_oy * np.cos(rad)) + cy

        cv2.circle(img, (h1x, h1y), 16, (15, 15, 15), -1)
        cv2.circle(img, (h1x, h1y), 16, (180, 180, 180), 2)
        cv2.circle(img, (h2x, h2y), 16, (15, 15, 15), -1)
        cv2.circle(img, (h2x, h2y), 16, (180, 180, 180), 2)

        t_str = time.strftime("%Y-%m-%d %H:%M:%S")
        cv2.putText(
            img,
            f"STREAM: {self.config.protocol.value} | {t_str} | FPS: {self._fps_actual:.1f}",
            (25, 45),
            cv2.FONT_HERSHEY_SIMPLEX,
            0.5,
            (0, 255, 200),
            1,
            cv2.LINE_AA,
        )

        return img
