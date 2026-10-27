"""VisionStudio Hand Tracking & Kinematic Gesture Control Tool.

Exclusively uses Google MediaPipe Hands (21 3D Landmarks) and PyAutoGUI
for computer vision hand kinematic tracking, index-based gesture control,
and optional operating-system cursor automation.

21 MediaPipe Hand Landmark Reference:
    0:  WRIST (Base of Palm)
    1:  THUMB_CMC, 2: THUMB_MCP, 3: THUMB_IP, 4: THUMB_TIP
    5:  INDEX_MCP, 6: INDEX_PIP, 7: INDEX_DIP, 8: INDEX_TIP
    9:  MIDDLE_MCP, 10: MIDDLE_PIP, 11: MIDDLE_DIP, 12: MIDDLE_TIP
    13: RING_MCP, 14: RING_PIP, 15: RING_DIP, 16: RING_TIP
    17: PINKY_MCP, 18: PINKY_PIP, 19: PINKY_DIP, 20: PINKY_TIP
"""

from __future__ import annotations
import math
import os
import logging
import time
from dataclasses import dataclass, field
from typing import Any, Dict, List, Optional, Tuple

import cv2
import numpy as np

logger = logging.getLogger("HandTrackerTool")

# Import MediaPipe & PyAutoGUI
try:
    import mediapipe as mp
    HAS_MEDIAPIPE = True
except ImportError:
    mp = None
    HAS_MEDIAPIPE = False

try:
    import pyautogui
    HAS_PYAUTOGUI = True
except ImportError:
    pyautogui = None
    HAS_PYAUTOGUI = False

try:
    import ctypes
    HAS_CTYPES = True
except ImportError:
    ctypes = None
    HAS_CTYPES = False


# 21 MediaPipe Standard Hand Landmarks Map
LANDMARK_NAMES: Dict[int, str] = {
    0: "WRIST",
    1: "THUMB_CMC",
    2: "THUMB_MCP",
    3: "THUMB_IP",
    4: "THUMB_TIP",
    5: "INDEX_FINGER_MCP",
    6: "INDEX_FINGER_PIP",
    7: "INDEX_FINGER_DIP",
    8: "INDEX_FINGER_TIP",
    9: "MIDDLE_FINGER_MCP",
    10: "MIDDLE_FINGER_PIP",
    11: "MIDDLE_FINGER_DIP",
    12: "MIDDLE_FINGER_TIP",
    13: "RING_FINGER_MCP",
    14: "RING_FINGER_PIP",
    15: "RING_FINGER_DIP",
    16: "RING_FINGER_TIP",
    17: "PINKY_MCP",
    18: "PINKY_PIP",
    19: "PINKY_DIP",
    20: "PINKY_TIP",
}

# Standard MediaPipe 21-node hand skeletal connections
HAND_CONNECTIONS = [
    (0, 1), (1, 2), (2, 3), (3, 4),           # Thumb
    (0, 5), (5, 6), (6, 7), (7, 8),           # Index
    (5, 9), (9, 10), (10, 11), (11, 12),      # Middle
    (9, 13), (13, 14), (14, 15), (15, 16),   # Ring
    (13, 17), (17, 18), (18, 19), (19, 20),  # Pinky
    (0, 17),                                  # Palm base
]


@dataclass
class NormalizedLandmark:
    x: float
    y: float
    z: float = 0.0


@dataclass
class NormalizedHandLandmarks:
    landmark: List[NormalizedLandmark]


@dataclass
class HandLandmark:
    id: int
    name: str
    x: float  # Normalized 0..1
    y: float  # Normalized 0..1
    z: float
    px: int   # Pixel coordinate X
    py: int   # Pixel coordinate Y


@dataclass
class HandInstance:
    landmarks: List[HandLandmark] = field(default_factory=list)
    pts: Dict[int, Tuple[int, int]] = field(default_factory=dict)
    index_tip_px: Tuple[int, int] = (0, 0)          # ID 8 (INDEX_FINGER_TIP)
    thumb_tip_px: Tuple[int, int] = (0, 0)          # ID 4 (THUMB_TIP)
    palm_center_px: Tuple[int, int] = (0, 0)        # ID 0 (WRIST)
    gesture: str = "Idle"
    action: str = "None"
    pinch_distance: float = 0.0
    fingers_count: int = 0


@dataclass
class HandTrackingResult:
    found: bool = False
    count: int = 0
    hands: List[HandInstance] = field(default_factory=list)
    primary_gesture: str = "None"
    primary_finger_count: int = 0
    primary_index_tip: Tuple[int, int] = (0, 0)
    primary_thumb_tip: Tuple[int, int] = (0, 0)
    primary_palm: Tuple[int, int] = (0, 0)
    distance: float = 0.0
    action: str = "None"
    metrics: Dict[str, Any] = field(default_factory=dict)

    @property
    def gesture(self) -> str:
        return self.primary_gesture

    @property
    def fingers_count(self) -> int:
        return self.primary_finger_count

    @property
    def fingers(self) -> int:
        return self.primary_finger_count

    @property
    def index_x(self) -> int:
        return self.primary_index_tip[0]

    @property
    def index_y(self) -> int:
        return self.primary_index_tip[1]

    @property
    def palm_x(self) -> int:
        return self.primary_palm[0]

    @property
    def palm_y(self) -> int:
        return self.primary_palm[1]


class HandTrackerTool:
    """MediaPipe-Powered Hand Kinematics & Gesture Control Engine.

    Configurable options for landmark indices:
    - cursor_index: Which landmark drives cursor coordinates (default: 8 - Index Tip)
    - click_pair: Pair of indices for Left Click pinch (default: 4 and 8)
    - right_click_pair: Pair of indices for Right Click pinch (default: 4 and 12)
    - double_click_pair: Pair of indices for Double Click pinch (default: 4 and 20)
    - distance_mode: "1d_vertical" abs(y1 - y2) or "2d_euclidean" hypot(dx, dy)
    - click_threshold: Distance threshold for click (default: 30 px)
    - move_threshold_min & max: Distance window where cursor moves (default: 70..200 px)
    - enable_mouse_control: Controls whether PyAutoGUI drives the OS mouse
    - offset: Mouse coordinate offset (default: 300 px)
    """

    def __init__(
        self,
        static_image_mode: bool = False,
        max_num_hands: int = 1,
        min_detection_confidence: float = 0.7,
        min_tracking_confidence: float = 0.5,
        cursor_index: int = 8,
        click_pair: Tuple[int, int] = (4, 8),
        right_click_pair: Tuple[int, int] = (4, 12),
        double_click_pair: Tuple[int, int] = (4, 20),
        click_threshold: float = 30.0,
        move_threshold_min: float = 70.0,
        move_threshold_max: float = 200.0,
        distance_mode: str = "1d_vertical",
        enable_mouse_control: bool = False,
        offset: int = 300,
        click_cooldown: float = 0.35,
    ):
        self.static_image_mode = static_image_mode
        self.max_num_hands = max_num_hands
        self.min_detection_confidence = min_detection_confidence
        self.min_tracking_confidence = min_tracking_confidence

        self.cursor_index = cursor_index
        self.click_pair = click_pair
        self.right_click_pair = right_click_pair
        self.double_click_pair = double_click_pair
        self.click_threshold = click_threshold
        self.move_threshold_min = move_threshold_min
        self.move_threshold_max = move_threshold_max
        self.distance_mode = distance_mode
        self.enable_mouse_control = enable_mouse_control
        self.offset = offset
        self.click_cooldown = click_cooldown

        self._last_click_time = 0.0

        if HAS_PYAUTOGUI:
            try:
                self.screen_width, self.screen_height = pyautogui.size()
            except Exception:
                self.screen_width, self.screen_height = 1920, 1080
        else:
            self.screen_width, self.screen_height = 1920, 1080

        self.hand_detector = None
        self.tasks_detector = None
        self.drawing_utils = None

        if HAS_MEDIAPIPE:
            self._init_mediapipe()

    def _init_mediapipe(self):
        """Initializes MediaPipe Hands via classic solutions or modern tasks API."""
        # 1. Try legacy Solutions API (mediapipe <= 0.10.x)
        if hasattr(mp, "solutions") and hasattr(mp.solutions, "hands"):
            try:
                self.hand_detector = mp.solutions.hands.Hands(
                    static_image_mode=self.static_image_mode,
                    max_num_hands=self.max_num_hands,
                    min_detection_confidence=self.min_detection_confidence,
                    min_tracking_confidence=self.min_tracking_confidence,
                )
                self.drawing_utils = mp.solutions.drawing_utils
                logger.info("MediaPipe Solutions Hands initialized.")
                return
            except Exception as e:
                logger.warning(f"MediaPipe solutions.hands error: {e}")

        # 2. Try Tasks API (mediapipe 0.10.30+ / 1.x)
        try:
            from mediapipe.tasks.python import vision
            from mediapipe.tasks import python as mp_python

            # Locate or verify model
            model_path = os.path.join(os.path.dirname(os.path.dirname(__file__)), "models", "hand_landmarker.task")
            if not os.path.exists(model_path):
                alt_path = "models/hand_landmarker.task"
                if os.path.exists(alt_path):
                    model_path = alt_path

            if os.path.exists(model_path):
                base_options = mp_python.BaseOptions(model_asset_path=model_path)
                options = vision.HandLandmarkerOptions(
                    base_options=base_options,
                    num_hands=self.max_num_hands,
                    min_hand_detection_confidence=self.min_detection_confidence,
                    min_tracking_confidence=self.min_tracking_confidence,
                )
                self.tasks_detector = vision.HandLandmarker.create_from_options(options)
                logger.info("MediaPipe Tasks HandLandmarker initialized.")
        except Exception as e:
            logger.error(f"Failed to initialize MediaPipe Tasks HandLandmarker: {e}")

    def calc_distance(self, p1: Tuple[int, int], p2: Tuple[int, int]) -> float:
        """Distance between two landmark points."""
        if self.distance_mode == "1d_vertical":
            return float(abs(p1[1] - p2[1]))
        return float(math.hypot(p1[0] - p2[0], p1[1] - p2[1]))

    def process(
        self,
        image: np.ndarray,
        flip_horizontal: bool = True,
        draw_skeleton: bool = True,
        highlight_index_tip: bool = True,
        **kwargs,
    ) -> Tuple[np.ndarray, HandTrackingResult]:
        """Processes frame for hand landmarks and gesture commands."""
        if image is None or image.size == 0:
            return image, HandTrackingResult()

        frame = image.copy()
        if flip_horizontal:
            frame = cv2.flip(frame, 1)

        frame_height, frame_width = frame.shape[:2]

        if not HAS_MEDIAPIPE or (self.hand_detector is None and self.tasks_detector is None):
            cv2.putText(
                frame,
                "MediaPipe Hands initializing...",
                (20, 40),
                cv2.FONT_HERSHEY_SIMPLEX,
                0.65,
                (0, 165, 255),
                2,
                cv2.LINE_AA,
            )
            return frame, HandTrackingResult(metrics={"error": "MediaPipe not ready"})

        rgb_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        hands_list: List[NormalizedHandLandmarks] = []

        # Inference: Classic Solutions
        if self.hand_detector is not None:
            output = self.hand_detector.process(rgb_frame)
            if output.multi_hand_landmarks:
                for h in output.multi_hand_landmarks:
                    lms = [NormalizedLandmark(lm.x, lm.y, getattr(lm, "z", 0.0)) for lm in h.landmark]
                    hands_list.append(NormalizedHandLandmarks(landmark=lms))

        # Inference: Tasks API
        elif self.tasks_detector is not None:
            mp_img = mp.Image(image_format=mp.ImageFormat.SRGB, data=rgb_frame)
            res = self.tasks_detector.detect(mp_img)
            if res.hand_landmarks:
                for h in res.hand_landmarks:
                    lms = [NormalizedLandmark(lm.x, lm.y, getattr(lm, "z", 0.0)) for lm in h]
                    hands_list.append(NormalizedHandLandmarks(landmark=lms))

        if not hands_list:
            return frame, HandTrackingResult(
                found=False,
                count=0,
                metrics={
                    "passed": False,
                    "hand_detected": False,
                    "hand_count": 0,
                    "gesture": "None",
                    "fingers_count": 0,
                    "index_x": 0,
                    "index_y": 0,
                    "action": "None",
                },
            )

        instances: List[HandInstance] = []
        primary_action = "Idle"
        primary_dist = 0.0
        screen_x, screen_y = 0, 0

        for hand in hands_list:
            landmarks = hand.landmark
            pts: Dict[int, Tuple[int, int]] = {}
            lm_objs: List[HandLandmark] = []

            for lm_id, lm in enumerate(landmarks):
                x = int(lm.x * frame_width)
                y = int(lm.y * frame_height)
                pts[lm_id] = (x, y)
                lm_name = LANDMARK_NAMES.get(lm_id, f"ID_{lm_id}")
                lm_objs.append(HandLandmark(
                    id=lm_id,
                    name=lm_name,
                    x=float(lm.x),
                    y=float(lm.y),
                    z=float(lm.z),
                    px=x,
                    py=y,
                ))

            # Draw skeleton connections
            if draw_skeleton:
                for p1_id, p2_id in HAND_CONNECTIONS:
                    if p1_id in pts and p2_id in pts:
                        cv2.line(frame, pts[p1_id], pts[p2_id], (0, 255, 128), 2)
                for pt in pts.values():
                    cv2.circle(frame, pt, 3, (0, 0, 255), -1)

            # Selected Cursor Landmark (Default: 8 - Index Tip)
            cursor_pt = pts.get(self.cursor_index, pts.get(8, (0, 0)))
            index_pt = pts.get(8, (0, 0))
            thumb_pt = pts.get(4, (0, 0))
            wrist_pt = pts.get(0, (0, 0))

            # Screen-mapped coordinates
            screen_x = int((self.screen_width / frame_width) * cursor_pt[0])
            screen_y = int((self.screen_height / frame_height) * cursor_pt[1])

            # Highlight selected active landmarks on frame
            if highlight_index_tip:
                # Highlight Cursor Landmark (Yellow circle radius 10)
                cv2.circle(frame, cursor_pt, 10, (0, 255, 255), cv2.FILLED)
                cv2.circle(frame, cursor_pt, 12, (20, 20, 20), 2)
                cv2.putText(
                    frame,
                    f"ID:{self.cursor_index}",
                    (cursor_pt[0] + 12, cursor_pt[1] - 4),
                    cv2.FONT_HERSHEY_SIMPLEX,
                    0.45,
                    (0, 255, 255),
                    1,
                    cv2.LINE_AA,
                )

                # Highlight Click Pair
                c1, c2 = self.click_pair
                if c1 in pts:
                    cv2.circle(frame, pts[c1], 10, (0, 255, 255), cv2.FILLED)
                    cv2.circle(frame, pts[c1], 12, (20, 20, 20), 2)
                if c2 in pts:
                    cv2.circle(frame, pts[c2], 10, (0, 255, 255), cv2.FILLED)
                    cv2.circle(frame, pts[c2], 12, (20, 20, 20), 2)

            action = "Tracking"
            now = time.time()
            can_click = (now - self._last_click_time) >= self.click_cooldown

            # 1. Left Click Check (e.g. Indices 4 & 8)
            i1, i2 = self.click_pair
            click_dist = 999.0
            if i1 in pts and i2 in pts:
                click_dist = self.calc_distance(pts[i1], pts[i2])
                primary_dist = click_dist
                cv2.line(frame, pts[i1], pts[i2], (0, 255, 0), 2)

                if click_dist < self.click_threshold:
                    action = f"Left Click ({i1}+{i2})"
                    if self.enable_mouse_control and HAS_PYAUTOGUI and can_click:
                        pyautogui.click()
                        self._last_click_time = now
                elif self.move_threshold_min < click_dist < self.move_threshold_max:
                    action = f"Move Cursor ({self.cursor_index})"
                    if self.enable_mouse_control and HAS_PYAUTOGUI:
                        pyautogui.moveTo(screen_x + self.offset, screen_y + self.offset)

            # 2. Right Click Check (e.g. Indices 4 & 12)
            r1, r2 = self.right_click_pair
            if r1 in pts and r2 in pts and (r1, r2) != (i1, i2) and r1 >= 0:
                r_dist = self.calc_distance(pts[r1], pts[r2])
                if r_dist < self.click_threshold:
                    action = f"Right Click ({r1}+{r2})"
                    if self.enable_mouse_control and HAS_PYAUTOGUI and can_click:
                        pyautogui.rightClick()
                        self._last_click_time = now

            # Finger Count (Fingertip higher than PIP joint in camera)
            fingers_count = 0
            if 4 in pts and 2 in pts:
                if abs(pts[4][0] - pts[0][0]) > abs(pts[2][0] - pts[0][0]):
                    fingers_count += 1
            for tip_id, pip_id in [(8, 6), (12, 10), (16, 14), (20, 18)]:
                if tip_id in pts and pip_id in pts:
                    if pts[tip_id][1] < pts[pip_id][1]:
                        fingers_count += 1

            inst = HandInstance(
                landmarks=lm_objs,
                pts=pts,
                index_tip_px=index_pt,
                thumb_tip_px=thumb_pt,
                palm_center_px=wrist_pt,
                gesture=action,
                action=action,
                pinch_distance=click_dist,
                fingers_count=fingers_count,
            )
            instances.append(inst)
            primary_action = action

        primary = instances[0]

        hud_text = f"Hand Track | Action: {primary_action} | Dist: {int(primary_dist)}px | Cursor: ({screen_x}, {screen_y})"
        cv2.putText(frame, hud_text, (20, 32), cv2.FONT_HERSHEY_SIMPLEX, 0.60, (0, 230, 118), 2, cv2.LINE_AA)

        result = HandTrackingResult(
            found=True,
            count=len(instances),
            hands=instances,
            primary_gesture=primary.gesture,
            primary_finger_count=primary.fingers_count,
            primary_index_tip=primary.index_tip_px,
            primary_thumb_tip=primary.thumb_tip_px,
            primary_palm=primary.palm_center_px,
            distance=primary_dist,
            action=primary_action,
            metrics={
                "passed": True,
                "hand_detected": True,
                "hand_count": len(instances),
                "gesture": primary.gesture,
                "action": primary_action,
                "fingers_count": primary.fingers_count,
                "index_x": primary.index_tip_px[0],
                "index_y": primary.index_tip_px[1],
                "thumb_x": primary.thumb_tip_px[0],
                "thumb_y": primary.thumb_tip_px[1],
                "palm_x": primary.palm_center_px[0],
                "palm_y": primary.palm_center_px[1],
                "cursor_x": screen_x,
                "cursor_y": screen_y,
                "pinch_distance": round(primary_dist, 1),
                "cursor_index": self.cursor_index,
                "click_pair": f"{self.click_pair[0]},{self.click_pair[1]}",
                "engine": "MediaPipe Hands",
            },
        )
        return frame, result


if __name__ == "__main__":
    offset = 300
    cap = cv2.VideoCapture(0)
    tracker = HandTrackerTool(
        cursor_index=8,
        click_pair=(4, 8),
        click_threshold=30.0,
        move_threshold_min=70.0,
        move_threshold_max=200.0,
        distance_mode="1d_vertical",
        enable_mouse_control=True,
        offset=offset,
    )

    print("=" * 60)
    print("VisionStudio Hand Tracking & Kinematic Control")
    print("Press 'e' or 'q' to exit")
    print("=" * 60)

    while True:
        ret, frame = cap.read()
        if not ret:
            break

        annotated_frame, res = tracker.process(frame, flip_horizontal=True)
        cv2.imshow("Mouse vali Window", annotated_frame)

        if HAS_CTYPES:
            hwnd = ctypes.windll.user32.FindWindowW(None, "Mouse vali Window")
            if hwnd:
                ctypes.windll.user32.SetWindowLongW(hwnd, -20, 0x00080000 | 0x00000020)
                ctypes.windll.user32.SetLayeredWindowAttributes(hwnd, 0, 128, 2)

        k = cv2.waitKey(1) & 0xFF
        if k == ord("e") or k == ord("q"):
            break

    cap.release()
    cv2.destroyAllWindows()
