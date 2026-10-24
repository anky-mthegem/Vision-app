"""Industrial Hand & Gesture Tracker Tool with MediaPipe & OpenCV Fallback.

Provides high-precision 21-landmark hand kinematic tracking, skeleton rendering,
fingertip coordinate extraction, extended finger counting, and gesture recognition.
"""

from __future__ import annotations
import math
import logging
from dataclasses import dataclass, field
from typing import Any, Dict, List, Optional, Tuple

import cv2
import numpy as np

logger = logging.getLogger("HandTrackerTool")

try:
    import mediapipe as mp
    HAS_MEDIAPIPE = True
except ImportError:
    mp = None
    HAS_MEDIAPIPE = False


@dataclass
class HandLandmark:
    id: int
    name: str
    x: float  # Normalized 0..1
    y: float  # Normalized 0..1
    z: float
    px: int   # Pixel X
    py: int   # Pixel Y


@dataclass
class HandInstance:
    handedness: str = "Unknown"  # "Left", "Right", or "Unknown"
    confidence: float = 0.0
    landmarks: List[HandLandmark] = field(default_factory=list)
    bbox: Tuple[int, int, int, int] = (0, 0, 0, 0)  # x, y, w, h
    index_tip_px: Tuple[int, int] = (0, 0)          # ID 8 (INDEX_FINGER_TIP)
    thumb_tip_px: Tuple[int, int] = (0, 0)          # ID 4 (THUMB_TIP)
    palm_center_px: Tuple[int, int] = (0, 0)
    fingers_count: int = 0
    gesture: str = "None"
    extended_fingers: Dict[str, bool] = field(default_factory=dict)


@dataclass
class HandTrackingResult:
    found: bool = False
    count: int = 0
    hands: List[HandInstance] = field(default_factory=list)
    primary_gesture: str = "None"
    primary_finger_count: int = 0
    primary_index_tip: Tuple[int, int] = (0, 0)
    primary_palm: Tuple[int, int] = (0, 0)
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
    """Enterprise Hand Tracker utilizing MediaPipe with automatic OpenCV fallback."""

    # 21 MediaPipe standard hand landmarks
    LANDMARK_NAMES = [
        "WRIST",
        "THUMB_CMC", "THUMB_MCP", "THUMB_IP", "THUMB_TIP",
        "INDEX_FINGER_MCP", "INDEX_FINGER_PIP", "INDEX_FINGER_DIP", "INDEX_FINGER_TIP",
        "MIDDLE_FINGER_MCP", "MIDDLE_FINGER_PIP", "MIDDLE_FINGER_DIP", "MIDDLE_FINGER_TIP",
        "RING_FINGER_MCP", "RING_FINGER_PIP", "RING_FINGER_DIP", "RING_FINGER_TIP",
        "PINKY_MCP", "PINKY_PIP", "PINKY_DIP", "PINKY_TIP",
    ]

    def __init__(
        self,
        static_image_mode: bool = False,
        max_num_hands: int = 2,
        min_detection_confidence: float = 0.5,
        min_tracking_confidence: float = 0.5,
        prefer_mediapipe: bool = True,
    ):
        self.static_image_mode = static_image_mode
        self.max_num_hands = max_num_hands
        self.min_detection_confidence = min_detection_confidence
        self.min_tracking_confidence = min_tracking_confidence
        self.prefer_mediapipe = prefer_mediapipe

        self._mp_hands = None
        self._mp_drawing = None
        self._mp_drawing_styles = None
        self._detector = None

        if HAS_MEDIAPIPE and prefer_mediapipe:
            self._init_mediapipe()

    def _init_mediapipe(self):
        try:
            self._mp_hands = mp.solutions.hands
            self._mp_drawing = mp.solutions.drawing_utils
            self._mp_drawing_styles = mp.solutions.drawing_styles

            self._detector = self._mp_hands.Hands(
                static_image_mode=self.static_image_mode,
                max_num_hands=self.max_num_hands,
                min_detection_confidence=self.min_detection_confidence,
                min_tracking_confidence=self.min_tracking_confidence,
            )
            logger.info("MediaPipe Hands initialized successfully.")
        except Exception as e:
            logger.warning(f"Could not initialize MediaPipe Hands: {e}. Falling back to OpenCV.")
            self._detector = None

    def process(
        self,
        image: np.ndarray,
        flip_horizontal: bool = False,
        draw_skeleton: bool = True,
        highlight_index_tip: bool = True,
        min_hand_area: float = 2500.0,
    ) -> Tuple[np.ndarray, HandTrackingResult]:
        """Processes an image for hands, renders visual overlays, and returns metrics.

        Args:
            image: BGR input image
            flip_horizontal: Whether to mirror viewing horizontally
            draw_skeleton: Whether to draw landmark graph and connections
            highlight_index_tip: Whether to highlight Index Fingertip (ID: 8)
            min_hand_area: Area threshold for OpenCV fallback

        Returns:
            Tuple of (annotated_bgr_frame, result_data)
        """
        if image is None or image.size == 0:
            return image, HandTrackingResult()

        frame = image.copy()
        if flip_horizontal:
            frame = cv2.flip(frame, 1)

        h, w = frame.shape[:2]

        # 1. Try MediaPipe Hands
        if self._detector is not None:
            try:
                rgb_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
                output = self._detector.process(rgb_frame)

                if output.multi_hand_landmarks:
                    instances: List[HandInstance] = []

                    for idx, hand_landmarks in enumerate(output.multi_hand_landmarks):
                        handedness_label = "Unknown"
                        score = 0.95
                        if output.multi_handedness and idx < len(output.multi_handedness):
                            classification = output.multi_handedness[idx].classification[0]
                            handedness_label = classification.label
                            score = float(classification.score)

                        # Extract pixel coords
                        pts = []
                        lm_objs = []
                        for lm_id, lm in enumerate(hand_landmarks.landmark):
                            cx = int(round(lm.x * w))
                            cy = int(round(lm.y * h))
                            pts.append((cx, cy))
                            name = self.LANDMARK_NAMES[lm_id] if lm_id < len(self.LANDMARK_NAMES) else f"LM_{lm_id}"
                            lm_objs.append(HandLandmark(
                                id=lm_id,
                                name=name,
                                x=float(lm.x),
                                y=float(lm.y),
                                z=float(lm.z),
                                px=cx,
                                py=cy
                            ))

                        # Bounding box
                        xs = [p[0] for p in pts]
                        ys = [p[1] for p in pts]
                        min_x, max_x = max(0, min(xs)), min(w - 1, max(xs))
                        min_y, max_y = max(0, min(ys)), min(h - 1, max(ys))
                        bbox = (min_x, min_y, max_x - min_x, max_y - min_y)

                        # Palm center (average of wrist 0, index MCP 5, and pinky MCP 17)
                        palm_cx = int((pts[0][0] + pts[5][0] + pts[17][0]) / 3)
                        palm_cy = int((pts[0][1] + pts[5][1] + pts[17][1]) / 3)

                        # Fingertips
                        # Thumb: 4, Index: 8, Middle: 12, Ring: 16, Pinky: 20
                        index_tip_px = pts[8]
                        thumb_tip_px = pts[4]

                        # Extended fingers calculation (invariant to rotation using distance from wrist)
                        wrist = pts[0]
                        extended = {}

                        # Thumb: distance from thumb tip (4) to pinky MCP (17) vs thumb IP (3) to pinky MCP
                        d_thumb_tip_pinky = math.dist(pts[4], pts[17])
                        d_thumb_ip_pinky = math.dist(pts[3], pts[17])
                        extended["thumb"] = d_thumb_tip_pinky > d_thumb_ip_pinky * 1.1

                        # Other fingers: compare tip distance to wrist vs PIP joint distance to wrist
                        # Index (8 tip, 6 pip)
                        extended["index"] = math.dist(pts[8], wrist) > math.dist(pts[6], wrist) * 1.1
                        # Middle (12 tip, 10 pip)
                        extended["middle"] = math.dist(pts[12], wrist) > math.dist(pts[10], wrist) * 1.1
                        # Ring (16 tip, 14 pip)
                        extended["ring"] = math.dist(pts[16], wrist) > math.dist(pts[14], wrist) * 1.1
                        # Pinky (20 tip, 18 pip)
                        extended["pinky"] = math.dist(pts[20], wrist) > math.dist(pts[18], wrist) * 1.1

                        finger_count = sum(1 for v in extended.values() if v)

                        # Gesture classification
                        if finger_count == 0:
                            gesture = "Fist"
                        elif finger_count == 1:
                            if extended["index"]:
                                gesture = "Pointing / Index"
                            elif extended["thumb"]:
                                gesture = "Thumbs Up"
                            else:
                                gesture = "Single Finger"
                        elif finger_count == 2:
                            if extended["index"] and extended["middle"]:
                                gesture = "Peace / Victory (V-Sign)"
                            elif extended["thumb"] and extended["pinky"]:
                                gesture = "Call Me / Shaka"
                            else:
                                gesture = "Two Fingers"
                        elif finger_count == 3:
                            if not extended["thumb"] and not extended["pinky"]:
                                gesture = "Three Fingers"
                            elif extended["thumb"] and extended["index"] and extended["pinky"]:
                                gesture = "Rock On / I Love You"
                            else:
                                gesture = "Three Fingers"
                        elif finger_count == 4:
                            gesture = "Four Fingers"
                        else:
                            gesture = "Open Hand / Palm"

                        # Check for OK Sign: thumb tip close to index tip while other 3 are extended
                        if math.dist(pts[4], pts[8]) < (math.dist(pts[5], pts[17]) * 0.45) and extended["middle"] and extended["ring"]:
                            gesture = "OK Sign"

                        instance = HandInstance(
                            handedness=handedness_label,
                            confidence=score,
                            landmarks=lm_objs,
                            bbox=bbox,
                            index_tip_px=index_tip_px,
                            thumb_tip_px=thumb_tip_px,
                            palm_center_px=(palm_cx, palm_cy),
                            fingers_count=finger_count,
                            gesture=gesture,
                            extended_fingers=extended,
                        )
                        instances.append(instance)

                        # Visual Drawing
                        if draw_skeleton and self._mp_drawing and self._mp_hands:
                            self._mp_drawing.draw_landmarks(
                                frame,
                                hand_landmarks,
                                self._mp_hands.HAND_CONNECTIONS,
                                self._mp_drawing_styles.get_default_hand_landmarks_style(),
                                self._mp_drawing_styles.get_default_hand_connections_style(),
                            )

                        # Highlight Index Fingertip (ID: 8) as requested
                        if highlight_index_tip:
                            cv2.circle(frame, index_tip_px, radius=9, color=(0, 255, 255), thickness=-1)
                            cv2.circle(frame, index_tip_px, radius=11, color=(22, 25, 29), thickness=2)
                            cv2.putText(
                                frame,
                                "INDEX",
                                (index_tip_px[0] + 12, index_tip_px[1] - 4),
                                cv2.FONT_HERSHEY_SIMPLEX,
                                0.42,
                                (0, 255, 255),
                                1,
                                cv2.LINE_AA,
                            )

                        # High-tech Bounding Box & Badge
                        bx, by, bw, bh = bbox
                        cv2.rectangle(frame, (bx, by), (bx + bw, by + bh), (0, 210, 255), 2)
                        badge_text = f"✋ {handedness_label}: {gesture} ({finger_count} Fingers)"
                        tw = len(badge_text) * 8 + 12
                        cv2.rectangle(frame, (bx, max(0, by - 24)), (bx + tw, by), (22, 25, 29), -1)
                        cv2.rectangle(frame, (bx, max(0, by - 24)), (bx + tw, by), (0, 230, 118), 1)
                        cv2.putText(
                            frame,
                            badge_text,
                            (bx + 6, max(16, by - 6)),
                            cv2.FONT_HERSHEY_SIMPLEX,
                            0.45,
                            (0, 230, 118),
                            1,
                            cv2.LINE_AA,
                        )

                    primary = instances[0]
                    res = HandTrackingResult(
                        found=True,
                        count=len(instances),
                        hands=instances,
                        primary_gesture=primary.gesture,
                        primary_finger_count=primary.fingers_count,
                        primary_index_tip=primary.index_tip_px,
                        primary_palm=primary.palm_center_px,
                        metrics={
                            "passed": True,
                            "hand_detected": True,
                            "hand_count": len(instances),
                            "gesture": primary.gesture,
                            "fingers_count": primary.fingers_count,
                            "index_x": primary.index_tip_px[0],
                            "index_y": primary.index_tip_px[1],
                            "palm_x": primary.palm_center_px[0],
                            "palm_y": primary.palm_center_px[1],
                            "engine": "MediaPipe (21-Landmark Neural)",
                        }
                    )

                    # Top HUD
                    hud = f"MediaPipe Hand Tracking: {primary.gesture} ({len(instances)} Hand{'s' if len(instances)>1 else ''})"
                    cv2.putText(frame, hud, (18, 30), cv2.FONT_HERSHEY_SIMPLEX, 0.60, (0, 230, 118), 2, cv2.LINE_AA)
                    return frame, res

            except Exception as e:
                logger.warning(f"MediaPipe inference failed: {e}. Falling back to OpenCV algorithm.")

        # 2. OpenCV Skin-Chroma / Distance-Transform Fallback
        return self._process_opencv_fallback(frame, min_hand_area, draw_skeleton, highlight_index_tip)

    def _process_opencv_fallback(
        self,
        frame: np.ndarray,
        min_hand_area: float,
        draw_skeleton: bool,
        highlight_index_tip: bool,
    ) -> Tuple[np.ndarray, HandTrackingResult]:
        """Robust OpenCV contour and distance-transform based hand tracking."""
        h, w = frame.shape[:2]
        output = frame.copy()

        ycrcb = cv2.cvtColor(frame, cv2.COLOR_BGR2YCrCb)
        mask_ycrcb = cv2.inRange(ycrcb, np.array([0, 133, 77], dtype=np.uint8), np.array([255, 173, 127], dtype=np.uint8))

        hsv = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)
        mask_hsv = cv2.inRange(hsv, np.array([0, 25, 45], dtype=np.uint8), np.array([25, 255, 255], dtype=np.uint8))

        skin_mask = cv2.bitwise_and(mask_ycrcb, mask_hsv)
        kernel = cv2.getStructuringElement(cv2.MORPH_ELLIPSE, (5, 5))
        skin_mask = cv2.morphologyEx(skin_mask, cv2.MORPH_OPEN, kernel, iterations=1)
        skin_mask = cv2.morphologyEx(skin_mask, cv2.MORPH_CLOSE, kernel, iterations=2)

        contours, _ = cv2.findContours(skin_mask, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
        hand_contours = [c for c in contours if cv2.contourArea(c) >= min_hand_area]
        hand_contours.sort(key=cv2.contourArea, reverse=True)

        if not hand_contours:
            hud = "Hand Tracking: No Hand Detected"
            cv2.putText(output, hud, (18, 30), cv2.FONT_HERSHEY_SIMPLEX, 0.60, (0, 210, 255), 2, cv2.LINE_AA)
            return output, HandTrackingResult(
                found=False,
                count=0,
                metrics={
                    "passed": False,
                    "hand_detected": False,
                    "hand_count": 0,
                    "gesture": "None",
                    "fingers_count": 0,
                    "engine": "OpenCV (Skin-Chroma Fallback)",
                }
            )

        hand_c = hand_contours[0]
        dist = cv2.distanceTransform(skin_mask, cv2.DIST_L2, 5)
        _, max_val, _, max_loc = cv2.minMaxLoc(dist)
        palm_cx, palm_cy = max_loc
        palm_r = max_val

        hull = cv2.convexHull(hand_c, returnPoints=False)
        fingertips = []
        if len(hull) > 3:
            defects = cv2.convexityDefects(hand_c, hull)
            if defects is not None:
                for i in range(len(defects)):
                    s, e, f, d = defects[i].ravel()
                    start = hand_c[int(s)][0]
                    end = hand_c[int(e)][0]
                    far = hand_c[int(f)][0]

                    a = math.dist(start, end)
                    b = math.dist(far, start)
                    c_dist = math.dist(far, end)
                    if b * c_dist > 0:
                        cosine = (b**2 + c_dist**2 - a**2) / (2 * b * c_dist)
                        angle = math.acos(max(-1.0, min(1.0, cosine))) * 180 / math.pi
                        depth = d / 256.0
                        if angle <= 88 and depth > (palm_r * 0.25):
                            if math.dist(start, (palm_cx, palm_cy)) > palm_r * 1.2:
                                fingertips.append(start)

        unique_tips = []
        for tip in fingertips:
            if not any(math.dist(tip, u) < 25 for u in unique_tips):
                unique_tips.append(tip)
        finger_count = min(5, len(unique_tips))

        if finger_count == 0:
            gesture = "Fist"
        elif finger_count == 1:
            gesture = "Pointing / Index"
        elif finger_count == 2:
            gesture = "Peace / Victory (V-Sign)"
        elif finger_count == 3:
            gesture = "Three Fingers"
        elif finger_count == 4:
            gesture = "Four Fingers"
        else:
            gesture = "Open Hand / Palm"

        bx, by, bw, bh = cv2.boundingRect(hand_c)
        cv2.rectangle(output, (bx, by), (bx + bw, by + bh), (0, 210, 255), 2)

        # Primary fingertip
        primary_tip = unique_tips[0] if unique_tips else (palm_cx, palm_cy - int(palm_r * 1.5))
        primary_tip_px = (int(primary_tip[0]), int(primary_tip[1]))

        if draw_skeleton:
            cv2.circle(output, (palm_cx, palm_cy), int(palm_r), (0, 230, 118), 2)
            cv2.circle(output, (palm_cx, palm_cy), 4, (0, 230, 118), -1)
            for tip in unique_tips:
                cv2.line(output, (palm_cx, palm_cy), tuple(tip), (0, 210, 255), 2)
                cv2.circle(output, tuple(tip), 6, (0, 23, 255), -1)
                cv2.circle(output, tuple(tip), 8, (255, 255, 255), 1)

        if highlight_index_tip:
            cv2.circle(output, primary_tip_px, radius=9, color=(0, 255, 255), thickness=-1)
            cv2.circle(output, primary_tip_px, radius=11, color=(22, 25, 29), thickness=2)
            cv2.putText(
                output,
                "INDEX",
                (primary_tip_px[0] + 12, primary_tip_px[1] - 4),
                cv2.FONT_HERSHEY_SIMPLEX,
                0.42,
                (0, 255, 255),
                1,
                cv2.LINE_AA,
            )

        badge_text = f"✋ {gesture} ({finger_count} Fingers)"
        tw = len(badge_text) * 8 + 12
        cv2.rectangle(output, (bx, max(0, by - 24)), (bx + tw, by), (22, 25, 29), -1)
        cv2.rectangle(output, (bx, max(0, by - 24)), (bx + tw, by), (0, 230, 118), 1)
        cv2.putText(output, badge_text, (bx + 6, max(16, by - 6)), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (0, 230, 118), 1, cv2.LINE_AA)

        hud = f"Hand Tracking (OpenCV): {gesture}"
        cv2.putText(output, hud, (18, 30), cv2.FONT_HERSHEY_SIMPLEX, 0.60, (0, 230, 118), 2, cv2.LINE_AA)

        inst = HandInstance(
            handedness="Single",
            confidence=0.85,
            bbox=(bx, by, bw, bh),
            index_tip_px=primary_tip_px,
            thumb_tip_px=(palm_cx - int(palm_r), palm_cy),
            palm_center_px=(palm_cx, palm_cy),
            fingers_count=finger_count,
            gesture=gesture,
        )

        return output, HandTrackingResult(
            found=True,
            count=1,
            hands=[inst],
            primary_gesture=gesture,
            primary_finger_count=finger_count,
            primary_index_tip=primary_tip_px,
            primary_palm=(palm_cx, palm_cy),
            metrics={
                "passed": True,
                "hand_detected": True,
                "hand_count": 1,
                "gesture": gesture,
                "fingers_count": finger_count,
                "index_x": primary_tip_px[0],
                "index_y": primary_tip_px[1],
                "palm_x": palm_cx,
                "palm_y": palm_cy,
                "engine": "OpenCV (Skin-Chroma Fallback)",
            }
        )
