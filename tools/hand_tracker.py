"""VisionStudio Hand Tracking & Kinematic Gesture Control Tool.

Provides robust multi-modal hand kinematics tracking and gesture recognition using:
1. Google MediaPipe Hands Tasks API (MediaPipe 0.10.x - 1.x) with automatic model download
2. Google MediaPipe Solutions API (MediaPipe <= 0.10.14 legacy support)
3. Native OpenCV Skin-Chroma / Contour Convexity Defect Fallback (offline / zero-dependency)

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
import urllib.request
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

MODEL_DOWNLOAD_URL = (
    "https://storage.googleapis.com/mediapipe-models/hand_landmarker/hand_landmarker/float16/latest/hand_landmarker.task"
)


def ensure_model_file(preferred_path: Optional[str] = None) -> Optional[str]:
    """Ensures the MediaPipe HandLandmarker .task model file is available on disk.

    If missing (such as upon fresh GitHub download), automatically downloads the
    official float16 model from Google's repository into the models directory.
    """
    candidate_paths: List[str] = []
    if preferred_path:
        candidate_paths.append(preferred_path)

    # 1. Project root / models
    repo_root = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
    candidate_paths.append(os.path.join(repo_root, "models", "hand_landmarker.task"))
    candidate_paths.append(os.path.join("models", "hand_landmarker.task"))

    # 2. User home cache directory
    cache_dir = os.path.join(os.path.expanduser("~"), ".cache", "vision_studio", "models")
    candidate_paths.append(os.path.join(cache_dir, "hand_landmarker.task"))

    for p in candidate_paths:
        if os.path.exists(p) and os.path.getsize(p) > 1000000:
            return p

    # Download model from Google CDN
    target_path = os.path.join(repo_root, "models", "hand_landmarker.task")
    try:
        os.makedirs(os.path.dirname(target_path), exist_ok=True)
        logger.info(f"Downloading MediaPipe HandLandmarker model to {target_path}...")
        req = urllib.request.Request(MODEL_DOWNLOAD_URL, headers={"User-Agent": "VisionStudio/1.0"})
        with urllib.request.urlopen(req, timeout=20) as response, open(target_path, "wb") as out_file:
            data = response.read()
            out_file.write(data)
        if os.path.exists(target_path) and os.path.getsize(target_path) > 1000000:
            logger.info("MediaPipe HandLandmarker model downloaded successfully.")
            return target_path
    except Exception as e:
        logger.warning(f"Could not auto-download MediaPipe HandLandmarker model: {e}")

    return None


def classify_hand_gesture(
    pts: Dict[int, Tuple[int, int]],
    click_threshold: float = 35.0,
) -> Tuple[str, int, Dict[str, bool]]:
    """Accurately classifies hand gestures from 21 MediaPipe skeletal points.

    Uses orientation-invariant distance metrics comparing fingertip-to-wrist and
    fingertip-to-MCP distances against intermediate PIP knuckle joints.

    Returns:
        Tuple of (gesture_name, extended_finger_count, extended_fingers_dict)
    """
    if len(pts) < 21:
        return "Unknown", 0, {}

    wrist = pts[0]
    extended: Dict[str, bool] = {}

    # 1. Four main fingers (Index: 8, Middle: 12, Ring: 16, Pinky: 20)
    for name, tip_id, pip_id, mcp_id in [
        ("index", 8, 6, 5),
        ("middle", 12, 10, 9),
        ("ring", 16, 14, 13),
        ("pinky", 20, 18, 17),
    ]:
        dist_tip_w = math.hypot(pts[tip_id][0] - wrist[0], pts[tip_id][1] - wrist[1])
        dist_pip_w = math.hypot(pts[pip_id][0] - wrist[0], pts[pip_id][1] - wrist[1])
        dist_tip_mcp = math.hypot(pts[tip_id][0] - pts[mcp_id][0], pts[tip_id][1] - pts[mcp_id][1])
        dist_pip_mcp = math.hypot(pts[pip_id][0] - pts[mcp_id][0], pts[pip_id][1] - pts[mcp_id][1])
        # A finger is extended if its tip is substantially further from wrist and MCP base than the PIP joint
        extended[name] = (dist_tip_w > dist_pip_w * 1.10) and (dist_tip_mcp > dist_pip_mcp * 0.95)

    # 2. Thumb (Tip: 4, IP: 3, MCP: 2, CMC: 1)
    dist_th_mcp = math.hypot(pts[4][0] - pts[2][0], pts[4][1] - pts[2][1])
    dist_ip_mcp = math.hypot(pts[3][0] - pts[2][0], pts[3][1] - pts[2][1])
    dist_th_pinky = math.hypot(pts[4][0] - pts[17][0], pts[4][1] - pts[17][1])
    dist_th_ip_pinky = math.hypot(pts[3][0] - pts[17][0], pts[3][1] - pts[17][1])
    extended["thumb"] = (dist_th_mcp > dist_ip_mcp * 1.20) and (
        dist_th_pinky > dist_th_ip_pinky * 1.08 or dist_th_mcp > 45
    )

    # 3. Pinch check (Thumb tip 4 and Index tip 8 proximity)
    pinch_dist = math.hypot(pts[4][0] - pts[8][0], pts[4][1] - pts[8][1])
    is_pinch = pinch_dist < click_threshold

    # OK Sign: Thumb and Index tips touch, while Middle, Ring, and Pinky are extended
    if is_pinch and extended["middle"] and extended["ring"]:
        return "OK Sign", sum(extended.values()), extended

    count = sum(1 for v in extended.values() if v)

    # Semantic Gesture Classification
    if count == 0:
        return "Fist", 0, extended

    if count == 1:
        if extended["thumb"]:
            # Up vs Down based on Y coordinate relative to MCP joint
            if pts[4][1] < pts[2][1] - 15:
                return "Thumbs Up", 1, extended
            elif pts[4][1] > pts[2][1] + 15:
                return "Thumbs Down", 1, extended
            return "Thumbs Out", 1, extended
        if extended["index"]:
            return "Pointing / Index", 1, extended
        return "Single Finger", 1, extended

    if count == 2:
        if extended["index"] and extended["middle"]:
            return "Peace / Victory (V-Sign)", 2, extended
        if extended["thumb"] and extended["pinky"]:
            return "Call Me / Shaka", 2, extended
        if extended["index"] and extended["pinky"]:
            return "Rock On / Horns", 2, extended
        return "Two Fingers", 2, extended

    if count == 3:
        if extended["thumb"] and extended["index"] and extended["pinky"]:
            return "Rock On / I Love You", 3, extended
        if extended["index"] and extended["middle"] and extended["ring"]:
            return "Three Fingers", 3, extended
        return "Three Fingers", 3, extended

    if count == 4:
        return "Four Fingers", 4, extended

    if count == 5:
        return "Open Hand / Palm", 5, extended

    return f"{count} Fingers", count, extended


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
    handedness: str = "Unknown"
    confidence: float = 0.90
    bbox: Tuple[int, int, int, int] = (0, 0, 0, 0)
    extended_fingers: Dict[str, bool] = field(default_factory=dict)


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
    def thumb_x(self) -> int:
        return self.primary_thumb_tip[0]

    @property
    def thumb_y(self) -> int:
        return self.primary_thumb_tip[1]

    @property
    def palm_x(self) -> int:
        return self.primary_palm[0]

    @property
    def palm_y(self) -> int:
        return self.primary_palm[1]


class HandTrackerTool:
    """MediaPipe-Powered Hand Kinematics & Gesture Control Engine with OpenCV Fallback.

    Features:
    - 21 3D Landmark kinematic tracking with sub-pixel precision
    - Multi-gesture classification: Open Palm, Fist, Pointing, Peace, Thumbs Up/Down, OK Sign, Rock On
    - Orientation-invariant finger counting
    - Configurable cursor index and pinch pairs for mouse automation
    - Automatic download of MediaPipe HandLandmarker model file if missing
    - Seamless fallback to OpenCV skin-chroma contour tracking if MediaPipe is unavailable
    """

    def __init__(
        self,
        static_image_mode: bool = False,
        max_num_hands: int = 1,
        min_detection_confidence: float = 0.5,
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
        prefer_mediapipe: bool = True,
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
        self.prefer_mediapipe = prefer_mediapipe

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
        self.use_opencv_fallback = False

        if HAS_MEDIAPIPE and self.prefer_mediapipe:
            self._init_mediapipe()
        else:
            self.use_opencv_fallback = True

    def _init_mediapipe(self):
        """Initializes MediaPipe Hands via classic solutions or modern Tasks API."""
        # 1. Try legacy Solutions API (mediapipe <= 0.10.14)
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

        # 2. Try Tasks API (mediapipe 0.10.15+ / 1.x)
        try:
            from mediapipe.tasks.python import vision
            from mediapipe.tasks import python as mp_python

            # Locate or automatically download model file
            model_path = ensure_model_file()
            if model_path and os.path.exists(model_path):
                base_options = mp_python.BaseOptions(model_asset_path=model_path)
                options = vision.HandLandmarkerOptions(
                    base_options=base_options,
                    num_hands=self.max_num_hands,
                    min_hand_detection_confidence=self.min_detection_confidence,
                    min_tracking_confidence=self.min_tracking_confidence,
                )
                self.tasks_detector = vision.HandLandmarker.create_from_options(options)
                logger.info("MediaPipe Tasks HandLandmarker initialized.")
                return
            else:
                logger.warning("MediaPipe Tasks model file not found and download failed. Using OpenCV fallback.")
        except Exception as e:
            logger.error(f"Failed to initialize MediaPipe Tasks HandLandmarker: {e}. Using OpenCV fallback.")

        self.use_opencv_fallback = True

    def calc_distance(self, p1: Tuple[int, int], p2: Tuple[int, int]) -> float:
        """Calculates distance between two landmark points."""
        if self.distance_mode == "1d_vertical":
            return float(abs(p1[1] - p2[1]))
        return float(math.hypot(p1[0] - p2[0], p1[1] - p2[1]))

    def process(
        self,
        image: np.ndarray,
        flip_horizontal: bool = True,
        draw_skeleton: bool = True,
        highlight_index_tip: bool = True,
        min_hand_area: float = 2000.0,
        **kwargs,
    ) -> Tuple[np.ndarray, HandTrackingResult]:
        """Processes frame for hand landmarks, gestures, and kinematic commands."""
        if image is None or image.size == 0:
            return image, HandTrackingResult()

        frame = image.copy()
        if flip_horizontal:
            frame = cv2.flip(frame, 1)

        frame_height, frame_width = frame.shape[:2]

        # If MediaPipe is not available or uninitialized, run the OpenCV Fallback
        if not HAS_MEDIAPIPE or (self.hand_detector is None and self.tasks_detector is None) or self.use_opencv_fallback:
            return self._process_opencv_fallback(
                frame,
                min_hand_area=min_hand_area,
                draw_skeleton=draw_skeleton,
                highlight_index_tip=highlight_index_tip,
            )

        rgb_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
        hands_list: List[NormalizedHandLandmarks] = []
        handedness_labels: List[str] = []

        try:
            # Inference: Classic Solutions
            if self.hand_detector is not None:
                output = self.hand_detector.process(rgb_frame)
                if output.multi_hand_landmarks:
                    for idx, h in enumerate(output.multi_hand_landmarks):
                        lms = [NormalizedLandmark(lm.x, lm.y, getattr(lm, "z", 0.0)) for lm in h.landmark]
                        hands_list.append(NormalizedHandLandmarks(landmark=lms))
                        label = "Hand"
                        if output.multi_handedness and idx < len(output.multi_handedness):
                            label = output.multi_handedness[idx].classification[0].label
                        handedness_labels.append(label)

            # Inference: Tasks API
            elif self.tasks_detector is not None:
                mp_img = mp.Image(image_format=mp.ImageFormat.SRGB, data=rgb_frame)
                res = self.tasks_detector.detect(mp_img)
                if res.hand_landmarks:
                    for idx, h in enumerate(res.hand_landmarks):
                        lms = [NormalizedLandmark(lm.x, lm.y, getattr(lm, "z", 0.0)) for lm in h]
                        hands_list.append(NormalizedHandLandmarks(landmark=lms))
                        label = "Hand"
                        if hasattr(res, "handedness") and res.handedness and idx < len(res.handedness):
                            label = res.handedness[idx][0].category_name
                        handedness_labels.append(label)

        except Exception as e:
            logger.warning(f"MediaPipe inference failed: {e}. Falling back to OpenCV.")
            return self._process_opencv_fallback(
                frame,
                min_hand_area=min_hand_area,
                draw_skeleton=draw_skeleton,
                highlight_index_tip=highlight_index_tip,
            )

        # No hands detected in frame
        if not hands_list:
            hud_text = "Hand Tracking: Ready (Show Hand to Camera)"
            cv2.putText(frame, hud_text, (20, 32), cv2.FONT_HERSHEY_SIMPLEX, 0.60, (0, 210, 255), 2, cv2.LINE_AA)
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
                    "engine": "MediaPipe Hands",
                },
            )

        instances: List[HandInstance] = []
        primary_action = "Idle"
        primary_dist = 0.0
        screen_x, screen_y = 0, 0

        for idx, hand in enumerate(hands_list):
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

            # Bounding box
            xs = [p[0] for p in pts.values()]
            ys = [p[1] for p in pts.values()]
            bx, by = max(0, min(xs)), max(0, min(ys))
            bw, bh = min(frame_width - bx, max(xs) - bx), min(frame_height - by, max(ys) - by)
            bbox = (bx, by, bw, bh)

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
                    cv2.circle(frame, pts[c1], 8, (0, 255, 255), cv2.FILLED)
                    cv2.circle(frame, pts[c1], 10, (20, 20, 20), 2)
                if c2 in pts:
                    cv2.circle(frame, pts[c2], 8, (0, 255, 255), cv2.FILLED)
                    cv2.circle(frame, pts[c2], 10, (20, 20, 20), 2)

            # 1. Semantic Gesture Recognition
            gesture_name, fingers_count, ext_dict = classify_hand_gesture(pts, click_threshold=self.click_threshold)

            # 2. Kinematic Mouse Action
            action = "Tracking"
            now = time.time()
            can_click = (now - self._last_click_time) >= self.click_cooldown

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

            # Right Click Check
            r1, r2 = self.right_click_pair
            if r1 in pts and r2 in pts and (r1, r2) != (i1, i2) and r1 >= 0:
                r_dist = self.calc_distance(pts[r1], pts[r2])
                if r_dist < self.click_threshold:
                    action = f"Right Click ({r1}+{r2})"
                    if self.enable_mouse_control and HAS_PYAUTOGUI and can_click:
                        pyautogui.rightClick()
                        self._last_click_time = now

            handedness_label = handedness_labels[idx] if idx < len(handedness_labels) else "Hand"

            # Draw High-Tech Badge above Hand
            badge_text = f"✋ {handedness_label}: {gesture_name} ({fingers_count} Fingers)"
            tw = len(badge_text) * 8 + 14
            cv2.rectangle(frame, (bx, max(0, by - 26)), (bx + tw, by), (22, 25, 29), -1)
            cv2.rectangle(frame, (bx, max(0, by - 26)), (bx + tw, by), (0, 230, 118), 1)
            cv2.putText(
                frame,
                badge_text,
                (bx + 6, max(16, by - 8)),
                cv2.FONT_HERSHEY_SIMPLEX,
                0.45,
                (0, 230, 118),
                1,
                cv2.LINE_AA,
            )

            inst = HandInstance(
                landmarks=lm_objs,
                pts=pts,
                index_tip_px=index_pt,
                thumb_tip_px=thumb_pt,
                palm_center_px=wrist_pt,
                gesture=gesture_name,
                action=action,
                pinch_distance=click_dist,
                fingers_count=fingers_count,
                handedness=handedness_label,
                confidence=0.95,
                bbox=bbox,
                extended_fingers=ext_dict,
            )
            instances.append(inst)
            primary_action = action

        primary = instances[0]

        # Top HUD Banner
        hud_text = f"Hand Track | Gesture: {primary.gesture} ({primary.fingers_count} Fg) | Action: {primary_action} | Cursor: ({screen_x}, {screen_y})"
        cv2.putText(frame, hud_text, (20, 32), cv2.FONT_HERSHEY_SIMPLEX, 0.58, (0, 230, 118), 2, cv2.LINE_AA)

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

    def _process_opencv_fallback(
        self,
        frame: np.ndarray,
        min_hand_area: float = 2000.0,
        draw_skeleton: bool = True,
        highlight_index_tip: bool = True,
    ) -> Tuple[np.ndarray, HandTrackingResult]:
        """Robust OpenCV contour and convexity-defect based hand tracking fallback.

        Executed automatically whenever MediaPipe is unavailable or uninitialized.
        """
        h, w = frame.shape[:2]
        output = frame.copy()

        ycrcb = cv2.cvtColor(frame, cv2.COLOR_BGR2YCrCb)
        mask_ycrcb = cv2.inRange(
            ycrcb,
            np.array([0, 133, 77], dtype=np.uint8),
            np.array([255, 173, 127], dtype=np.uint8),
        )

        hsv = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)
        mask_hsv = cv2.inRange(
            hsv,
            np.array([0, 25, 45], dtype=np.uint8),
            np.array([25, 255, 255], dtype=np.uint8),
        )

        skin_mask = cv2.bitwise_and(mask_ycrcb, mask_hsv)
        kernel = cv2.getStructuringElement(cv2.MORPH_ELLIPSE, (5, 5))
        skin_mask = cv2.morphologyEx(skin_mask, cv2.MORPH_OPEN, kernel, iterations=1)
        skin_mask = cv2.morphologyEx(skin_mask, cv2.MORPH_CLOSE, kernel, iterations=2)

        contours, _ = cv2.findContours(skin_mask, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
        hand_contours = [c for c in contours if cv2.contourArea(c) >= min_hand_area]
        hand_contours.sort(key=cv2.contourArea, reverse=True)

        if not hand_contours:
            hud = "Hand Tracking (OpenCV Fallback): Ready (Show Hand)"
            cv2.putText(output, hud, (20, 32), cv2.FONT_HERSHEY_SIMPLEX, 0.58, (0, 210, 255), 2, cv2.LINE_AA)
            return output, HandTrackingResult(
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
                    "engine": "OpenCV (Skin-Chroma Fallback)",
                },
            )

        hand_c = hand_contours[0]
        bx, by, bw, bh = cv2.boundingRect(hand_c)
        cv2.rectangle(output, (bx, by), (bx + bw, by + bh), (0, 210, 255), 2)

        hull = cv2.convexHull(hand_c, returnPoints=False)
        fingertip_pts: List[Tuple[int, int]] = []
        if len(hull) > 3:
            try:
                defects = cv2.convexityDefects(hand_c, hull)
                if defects is not None:
                    for i in range(defects.shape[0]):
                        s, e, f, d = defects[i, 0]
                        start = tuple(hand_c[s][0])
                        end = tuple(hand_c[e][0])
                        far = tuple(hand_c[f][0])
                        a = math.dist(start, end)
                        b = math.dist(start, far)
                        c = math.dist(end, far)
                        angle = math.acos(max(-1.0, min(1.0, (b**2 + c**2 - a**2) / (2 * b * c + 1e-5))))
                        if angle <= math.pi / 2 and d > 12000:
                            if not any(math.dist(start, p) < 25 for p in fingertip_pts):
                                fingertip_pts.append(start)
                            if not any(math.dist(end, p) < 25 for p in fingertip_pts):
                                fingertip_pts.append(end)
            except Exception:
                pass

        finger_count = min(5, max(1, len(fingertip_pts)))
        gesture_map = {
            0: "Fist",
            1: "Pointing / Index",
            2: "Peace / Victory (V-Sign)",
            3: "Three Fingers",
            4: "Four Fingers",
            5: "Open Hand / Palm",
        }
        gesture_name = gesture_map.get(finger_count, f"{finger_count} Fingers")

        m = cv2.moments(hand_c)
        cx = int(m["m10"] / (m["m00"] + 1e-5))
        cy = int(m["m01"] / (m["m00"] + 1e-5))

        primary_tip = fingertip_pts[0] if fingertip_pts else (cx, by)

        if highlight_index_tip:
            cv2.circle(output, primary_tip, 10, (0, 255, 255), -1)
            cv2.circle(output, primary_tip, 12, (20, 20, 20), 2)
            cv2.putText(
                output,
                "TIP",
                (primary_tip[0] + 12, primary_tip[1] - 4),
                cv2.FONT_HERSHEY_SIMPLEX,
                0.45,
                (0, 255, 255),
                1,
                cv2.LINE_AA,
            )

        badge_text = f"✋ OpenCV: {gesture_name} ({finger_count} Fingers)"
        tw = len(badge_text) * 8 + 14
        cv2.rectangle(output, (bx, max(0, by - 26)), (bx + tw, by), (22, 25, 29), -1)
        cv2.rectangle(output, (bx, max(0, by - 26)), (bx + tw, by), (0, 230, 118), 1)
        cv2.putText(
            output,
            badge_text,
            (bx + 6, max(16, by - 8)),
            cv2.FONT_HERSHEY_SIMPLEX,
            0.45,
            (0, 230, 118),
            1,
            cv2.LINE_AA,
        )

        hud_text = f"Hand Track (OpenCV Fallback) | Gesture: {gesture_name} | Fingers: {finger_count}"
        cv2.putText(output, hud_text, (20, 32), cv2.FONT_HERSHEY_SIMPLEX, 0.58, (0, 230, 118), 2, cv2.LINE_AA)

        inst = HandInstance(
            index_tip_px=primary_tip,
            thumb_tip_px=(cx - 20, cy),
            palm_center_px=(cx, cy),
            gesture=gesture_name,
            action="Tracking",
            fingers_count=finger_count,
            handedness="Single",
            confidence=0.85,
            bbox=(bx, by, bw, bh),
        )

        return output, HandTrackingResult(
            found=True,
            count=1,
            hands=[inst],
            primary_gesture=gesture_name,
            primary_finger_count=finger_count,
            primary_index_tip=primary_tip,
            primary_thumb_tip=(cx - 20, cy),
            primary_palm=(cx, cy),
            action="Tracking",
            metrics={
                "passed": True,
                "hand_detected": True,
                "hand_count": 1,
                "gesture": gesture_name,
                "action": "Tracking",
                "fingers_count": finger_count,
                "index_x": primary_tip[0],
                "index_y": primary_tip[1],
                "thumb_x": cx - 20,
                "thumb_y": cy,
                "palm_x": cx,
                "palm_y": cy,
                "engine": "OpenCV (Skin-Chroma Fallback)",
            },
        )


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
        enable_mouse_control=False,
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
        cv2.imshow("VisionStudio Hand Tracker", annotated_frame)

        if HAS_CTYPES:
            hwnd = ctypes.windll.user32.FindWindowW(None, "VisionStudio Hand Tracker")
            if hwnd:
                ctypes.windll.user32.SetWindowLongW(hwnd, -20, 0x00080000 | 0x00000020)
                ctypes.windll.user32.SetLayeredWindowAttributes(hwnd, 0, 128, 2)

        k = cv2.waitKey(1) & 0xFF
        if k == ord("e") or k == ord("q"):
            break

    cap.release()
    cv2.destroyAllWindows()
