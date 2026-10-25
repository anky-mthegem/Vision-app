"""Interactive Visual Camera Calibration Dialog for Industrial Machine Vision.

Allows operators to perform visual calibration directly on the live camera stream:
1. Open the live camera feed (or freeze motionless frame).
2. Click & drag on screen to draw a calibration ruler line across a physical scale/gauge.
3. Subpixel endpoint handles and crosshair reticles for precision alignment.
4. Enter known physical length in mm (e.g., 100mm floor scale/ruler).
5. Instantly compute scale factor (mm/pixel) and propagate to all metrology caliper steps.
"""

from __future__ import annotations
import json
import math
import os
import time
from typing import Optional, Dict, Any, Callable

import cv2
import numpy as np

from PyQt6.QtCore import Qt, QPoint, QPointF, QRectF, QTimer, pyqtSignal, QLineF
from PyQt6.QtGui import (
    QImage,
    QPixmap,
    QPainter,
    QPen,
    QBrush,
    QColor,
    QFont,
    QCursor,
    QMouseEvent,
    QWheelEvent,
    QPainterPath,
)
from PyQt6.QtWidgets import (
    QDialog,
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QGridLayout,
    QLabel,
    QLineEdit,
    QDoubleSpinBox,
    QComboBox,
    QPushButton,
    QCheckBox,
    QFrame,
    QGroupBox,
    QSplitter,
    QGraphicsView,
    QGraphicsScene,
    QGraphicsPixmapItem,
    QGraphicsItem,
    QStyleOptionGraphicsItem,
    QSizePolicy,
)

CONFIG_CALIBRATION_FILE = "camera_calibration.json"


def load_calibration_config() -> Dict[str, Any]:
    if os.path.exists(CONFIG_CALIBRATION_FILE):
        try:
            with open(CONFIG_CALIBRATION_FILE, "r") as f:
                return json.load(f)
        except Exception:
            pass
    return {
        "calibration_factor": 0.10,
        "unit": "mm",
        "reference_name": "Standard 100mm Scale Gauge",
        "last_known_dim": 100.0,
        "last_measured_px": 500.0,
    }


def save_calibration_config(data: Dict[str, Any]):
    try:
        with open(CONFIG_CALIBRATION_FILE, "w") as f:
            json.dump(data, f, indent=4)
    except Exception as e:
        print(f"Error saving calibration config: {e}")


# ==============================================================================
# INTERACTIVE VISUAL CALIBRATION RULER ITEM (QGraphicsItem)
# ==============================================================================

class CalibrationRulerItem(QGraphicsItem):
    """Interactive visual calibration ruler line with dual endpoint handles,

    perpendicular end caliper jaws, angle readout, and live HUD dimension tag.
    """

    HANDLE_RADIUS = 9.0
    LINE_HIT_RADIUS = 8.0

    def __init__(self, p1: QPointF, p2: QPointF, parent: Optional[QGraphicsItem] = None):
        super().__init__(parent)
        self.p1 = p1
        self.p2 = p2
        self.unit = "mm"
        self.known_dim = 100.0
        self.factor = 0.10
        self.setZValue(100)
        self.setAcceptHoverEvents(True)

    def boundingRect(self) -> QRectF:
        extra = 45.0
        min_x = min(self.p1.x(), self.p2.x()) - extra
        min_y = min(self.p1.y(), self.p2.y()) - extra
        max_x = max(self.p1.x(), self.p2.x()) + extra
        max_y = max(self.p1.y(), self.p2.y()) + extra
        return QRectF(min_x, min_y, max_x - min_x, max_y - min_y)

    def length_px(self) -> float:
        return math.hypot(self.p2.x() - self.p1.x(), self.p2.y() - self.p1.y())

    def angle_deg(self) -> float:
        dx = self.p2.x() - self.p1.x()
        dy = self.p2.y() - self.p1.y()
        return math.degrees(math.atan2(dy, dx))

    def update_calibration_data(self, known_dim: float, factor: float, unit: str):
        self.known_dim = known_dim
        self.factor = factor
        self.unit = unit
        self.update()

    def paint(self, painter: QPainter, option: QStyleOptionGraphicsItem, widget: Optional[QWidget] = None):
        painter.setRenderHint(QPainter.RenderHint.Antialiasing, True)
        dx = self.p2.x() - self.p1.x()
        dy = self.p2.y() - self.p1.y()
        dist = math.hypot(dx, dy)
        if dist < 1.0:
            return

        # Unit normal vector for perpendicular caliper jaws
        nx = -dy / dist
        ny = dx / dist

        # 1. Shadow / Contrast Outline for high visibility over bright/dark backgrounds
        shadow_pen = QPen(QColor(10, 14, 20, 200), 4.5, Qt.PenStyle.SolidLine, Qt.PenCapStyle.RoundCap)
        painter.setPen(shadow_pen)
        painter.drawLine(self.p1, self.p2)

        # 2. Main Illuminating Line
        line_pen = QPen(QColor("#00D2FF"), 2.2, Qt.PenStyle.SolidLine, Qt.PenCapStyle.RoundCap)
        painter.setPen(line_pen)
        painter.drawLine(self.p1, self.p2)

        # 3. Perpendicular Caliper Ticks (End Jaws)
        tick_len = 16.0
        for pt in (self.p1, self.p2):
            t1 = QPointF(pt.x() + nx * tick_len, pt.y() + ny * tick_len)
            t2 = QPointF(pt.x() - nx * tick_len, pt.y() - ny * tick_len)
            painter.setPen(shadow_pen)
            painter.drawLine(t1, t2)
            painter.setPen(line_pen)
            painter.drawLine(t1, t2)

        # 4. Handle 1 (P1 - Start Point, Cyan Target Ring)
        self._draw_target_handle(painter, self.p1, QColor("#00D2FF"), "P1 (0 mm)")

        # 5. Handle 2 (P2 - End Point, Emerald Green Target Ring)
        self._draw_target_handle(painter, self.p2, QColor("#00E676"), f"P2 ({self.known_dim:.1f} {self.unit})")

        # 6. Floating Midpoint HUD Badge
        mid = QPointF((self.p1.x() + self.p2.x()) / 2.0, (self.p1.y() + self.p2.y()) / 2.0)
        hud_text = f"📏 {dist:.1f} px  =  {self.known_dim:.1f} {self.unit}  ({self.factor:.4f} {self.unit}/px)"
        
        font = QFont("Consolas", 9, QFont.Weight.Bold)
        font.setLetterSpacing(QFont.SpacingType.AbsoluteSpacing, 0.5)
        painter.setFont(font)
        fm = painter.fontMetrics()
        tw = fm.horizontalAdvance(hud_text) + 16
        th = fm.height() + 8

        # Offset badge slightly perpendicular to the line to prevent overlap
        badge_center = QPointF(mid.x() + nx * 22, mid.y() + ny * 22)
        badge_rect = QRectF(badge_center.x() - tw / 2, badge_center.y() - th / 2, tw, th)

        # Badge background pill
        painter.setPen(QPen(QColor("#00D2FF"), 1.2))
        painter.setBrush(QBrush(QColor(22, 25, 33, 235)))
        painter.drawRoundedRect(badge_rect, 6, 6)

        # Badge text
        painter.setPen(QColor("#FFFFFF"))
        painter.drawText(badge_rect, Qt.AlignmentFlag.AlignCenter, hud_text)

    def _draw_target_handle(self, painter: QPainter, pt: QPointF, color: QColor, label: str):
        # Outer ring
        painter.setPen(QPen(QColor(10, 14, 20, 220), 4.0))
        painter.setBrush(Qt.BrushStyle.NoBrush)
        painter.drawEllipse(pt, self.HANDLE_RADIUS, self.HANDLE_RADIUS)

        painter.setPen(QPen(color, 2.0))
        painter.setBrush(QBrush(QColor(color.red(), color.green(), color.blue(), 60)))
        painter.drawEllipse(pt, self.HANDLE_RADIUS, self.HANDLE_RADIUS)

        # Center reticle pip
        painter.setPen(Qt.PenStyle.NoPen)
        painter.setBrush(QBrush(color))
        painter.drawEllipse(pt, 2.5, 2.5)

        # Sub-label tag
        painter.setFont(QFont("Segoe UI", 8, QFont.Weight.Bold))
        fm = painter.fontMetrics()
        lw = fm.horizontalAdvance(label) + 8
        lh = fm.height() + 4
        lbl_rect = QRectF(pt.x() - lw / 2, pt.y() + self.HANDLE_RADIUS + 4, lw, lh)
        painter.setPen(QPen(QColor(color.red(), color.green(), color.blue(), 180), 1))
        painter.setBrush(QBrush(QColor(16, 20, 26, 220)))
        painter.drawRoundedRect(lbl_rect, 4, 4)
        painter.setPen(color)
        painter.drawText(lbl_rect, Qt.AlignmentFlag.AlignCenter, label)


# ==============================================================================
# VISUAL CALIBRATION GRAPHICS VIEW
# ==============================================================================

class VisualCalibrationView(QGraphicsView):
    """Interactive camera viewport allowing click-and-drag line calibration,

    endpoint dragging, mouse wheel zooming, and middle-click panning.
    """

    ruler_changed = pyqtSignal(float, QPointF, QPointF)  # (pixel_distance, p1, p2)

    def __init__(self, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.scene = QGraphicsScene(self)
        self.setScene(self.scene)

        # Background image pixmap
        self.pixmap_item = QGraphicsPixmapItem()
        self.scene.addItem(self.pixmap_item)

        # Interactive ruler
        self.ruler = CalibrationRulerItem(QPointF(200, 360), QPointF(600, 360))
        self.scene.addItem(self.ruler)

        self._current_frame: Optional[np.ndarray] = None
        self._drag_target: Optional[str] = None  # "p1", "p2", "line", "new"
        self._pan_active = False
        self._pan_start = QPoint()
        self._drag_start_pt = QPointF()
        self._orig_p1 = QPointF()
        self._orig_p2 = QPointF()

        # Rendering & navigation hints
        self.setRenderHint(QPainter.RenderHint.Antialiasing, True)
        self.setRenderHint(QPainter.RenderHint.SmoothPixmapTransform, True)
        self.setTransformationAnchor(QGraphicsView.ViewportAnchor.AnchorUnderMouse)
        self.setResizeAnchor(QGraphicsView.ViewportAnchor.AnchorUnderMouse)
        self.setVerticalScrollBarPolicy(Qt.ScrollBarPolicy.ScrollBarAlwaysOff)
        self.setHorizontalScrollBarPolicy(Qt.ScrollBarPolicy.ScrollBarAlwaysOff)
        self.setFrameShape(QFrame.Shape.NoFrame)
        self.setMouseTracking(True)
        self._user_has_zoomed = False
        self.setStyleSheet("background-color: #0E1114;")

    def showEvent(self, event):
        super().showEvent(event)
        QTimer.singleShot(60, self.fit_to_view)

    def resizeEvent(self, event):
        super().resizeEvent(event)
        if not self._user_has_zoomed:
            self.fit_to_view()

    def set_frame(self, img: Optional[np.ndarray]):
        """Updates the background camera frame while preserving current ruler coordinates."""
        self._current_frame = img
        if img is None or img.size == 0:
            self.pixmap_item.setPixmap(QPixmap())
            return

        h, w = img.shape[:2]
        if img.ndim == 2:
            q_img = QImage(img.data, w, h, w, QImage.Format.Format_Grayscale8)
        elif img.ndim == 3 and img.shape[2] == 3:
            q_img = QImage(img.data, w, h, 3 * w, QImage.Format.Format_BGR888)
        elif img.ndim == 3 and img.shape[2] == 4:
            q_img = QImage(img.data, w, h, 4 * w, QImage.Format.Format_ARGB32)
        else:
            q_img = QImage()

        pix = QPixmap.fromImage(q_img)
        first_load = self.pixmap_item.pixmap().isNull()
        self.pixmap_item.setPixmap(pix)

        if first_load and w > 0 and h > 0:
            self.scene.setSceneRect(0, 0, w, h)
            # Center default ruler horizontally across 40% of FOV
            self.ruler.p1 = QPointF(w * 0.25, h * 0.5)
            self.ruler.p2 = QPointF(w * 0.65, h * 0.5)
            self.ruler.update()
            self.fit_to_view()
            self._notify_change()

    def fit_to_view(self):
        rect = self.pixmap_item.boundingRect()
        if not rect.isEmpty() and self.viewport().width() > 50 and self.viewport().height() > 50:
            self._user_has_zoomed = False
            self.fitInView(rect, Qt.AspectRatioMode.KeepAspectRatio)

    def reset_ruler_centered(self):
        rect = self.pixmap_item.boundingRect()
        if rect.isEmpty():
            w, h = 1280, 720
        else:
            w, h = rect.width(), rect.height()
        self.ruler.p1 = QPointF(w * 0.30, h * 0.50)
        self.ruler.p2 = QPointF(w * 0.70, h * 0.50)
        self.ruler.update()
        self._notify_change()

    def update_calibration_data(self, known_dim: float, factor: float, unit: str):
        self.ruler.update_calibration_data(known_dim, factor, unit)

    def _notify_change(self):
        dist = self.ruler.length_px()
        self.ruler_changed.emit(dist, self.ruler.p1, self.ruler.p2)

    # ------------------ Mouse & Pan Interaction ------------------

    def mousePressEvent(self, event: QMouseEvent):
        # Middle click or Alt+Left click panning
        if event.button() == Qt.MouseButton.MiddleButton or (event.button() == Qt.MouseButton.LeftButton and event.modifiers() & Qt.KeyboardModifier.AltModifier):
            self._pan_active = True
            self._pan_start = event.pos()
            self.setCursor(Qt.CursorShape.ClosedHandCursor)
            event.accept()
            return

        if event.button() == Qt.MouseButton.LeftButton:
            scene_pos = self.mapToScene(event.pos())
            img_rect = self.pixmap_item.boundingRect()
            if img_rect.isEmpty():
                img_rect = QRectF(0, 0, 1280, 720)

            # Check if clicked near P1 handle
            if math.hypot(scene_pos.x() - self.ruler.p1.x(), scene_pos.y() - self.ruler.p1.y()) <= 15.0:
                self._drag_target = "p1"
                self.setCursor(Qt.CursorShape.SizeAllCursor)
                event.accept()
                return

            # Check if clicked near P2 handle
            if math.hypot(scene_pos.x() - self.ruler.p2.x(), scene_pos.y() - self.ruler.p2.y()) <= 15.0:
                self._drag_target = "p2"
                self.setCursor(Qt.CursorShape.SizeAllCursor)
                event.accept()
                return

            # Check if clicked on the line body to move entire line
            line_dist = self._distance_to_segment(scene_pos, self.ruler.p1, self.ruler.p2)
            if line_dist <= 12.0:
                self._drag_target = "line"
                self._drag_start_pt = scene_pos
                self._orig_p1 = QPointF(self.ruler.p1)
                self._orig_p2 = QPointF(self.ruler.p2)
                self.setCursor(Qt.CursorShape.SizeAllCursor)
                event.accept()
                return

            # Clicked elsewhere on image -> Start drawing a brand new ruler!
            self._drag_target = "new"
            clamped_x = max(0.0, min(scene_pos.x(), img_rect.width()))
            clamped_y = max(0.0, min(scene_pos.y(), img_rect.height()))
            self.ruler.p1 = QPointF(clamped_x, clamped_y)
            self.ruler.p2 = QPointF(clamped_x, clamped_y)
            self.ruler.update()
            self.setCursor(Qt.CursorShape.CrossCursor)
            event.accept()
            return

        super().mousePressEvent(event)

    def mouseMoveEvent(self, event: QMouseEvent):
        if self._pan_active:
            delta = event.pos() - self._pan_start
            self._pan_start = event.pos()
            self.horizontalScrollBar().setValue(self.horizontalScrollBar().value() - delta.x())
            self.verticalScrollBar().setValue(self.verticalScrollBar().value() - delta.y())
            event.accept()
            return

        scene_pos = self.mapToScene(event.pos())
        img_rect = self.pixmap_item.boundingRect()
        if img_rect.isEmpty():
            img_rect = QRectF(0, 0, 1280, 720)

        clamped_x = max(0.0, min(scene_pos.x(), img_rect.width()))
        clamped_y = max(0.0, min(scene_pos.y(), img_rect.height()))
        pos = QPointF(clamped_x, clamped_y)

        if self._drag_target == "p1":
            self.ruler.p1 = pos
            self.ruler.update()
            self._notify_change()
            event.accept()
            return

        elif self._drag_target == "p2" or self._drag_target == "new":
            self.ruler.p2 = pos
            self.ruler.update()
            self._notify_change()
            event.accept()
            return

        elif self._drag_target == "line":
            delta = pos - self._drag_start_pt
            new_p1 = self._orig_p1 + delta
            new_p2 = self._orig_p2 + delta

            # Clamp both endpoints within frame
            w, h = img_rect.width(), img_rect.height()
            min_x = min(new_p1.x(), new_p2.x())
            max_x = max(new_p1.x(), new_p2.x())
            min_y = min(new_p1.y(), new_p2.y())
            max_y = max(new_p1.y(), new_p2.y())

            offset_x = 0.0
            if min_x < 0:
                offset_x = -min_x
            elif max_x > w:
                offset_x = w - max_x

            offset_y = 0.0
            if min_y < 0:
                offset_y = -min_y
            elif max_y > h:
                offset_y = h - max_y

            self.ruler.p1 = QPointF(new_p1.x() + offset_x, new_p1.y() + offset_y)
            self.ruler.p2 = QPointF(new_p2.x() + offset_x, new_p2.y() + offset_y)
            self.ruler.update()
            self._notify_change()
            event.accept()
            return

        # Hover cursor indicators
        d1 = math.hypot(scene_pos.x() - self.ruler.p1.x(), scene_pos.y() - self.ruler.p1.y())
        d2 = math.hypot(scene_pos.x() - self.ruler.p2.x(), scene_pos.y() - self.ruler.p2.y())
        dl = self._distance_to_segment(scene_pos, self.ruler.p1, self.ruler.p2)

        if d1 <= 15.0 or d2 <= 15.0:
            self.setCursor(Qt.CursorShape.PointingHandCursor)
        elif dl <= 12.0:
            self.setCursor(Qt.CursorShape.SizeAllCursor)
        else:
            self.setCursor(Qt.CursorShape.CrossCursor)

        super().mouseMoveEvent(event)

    def mouseReleaseEvent(self, event: QMouseEvent):
        if self._pan_active:
            self._pan_active = False
            self.setCursor(Qt.CursorShape.ArrowCursor)
            event.accept()
            return

        if self._drag_target:
            # If drawn line is too tiny (< 5px), restore a sensible 100px line
            if self.ruler.length_px() < 5.0:
                self.ruler.p2 = QPointF(self.ruler.p1.x() + 100.0, self.ruler.p1.y())
                self.ruler.update()
            self._drag_target = None
            self.setCursor(Qt.CursorShape.ArrowCursor)
            self._notify_change()
            event.accept()
            return

        super().mouseReleaseEvent(event)

    def wheelEvent(self, event: QWheelEvent):
        # Smooth mouse wheel zooming
        self._user_has_zoomed = True
        zoom_factor = 1.15 if event.angleDelta().y() > 0 else (1.0 / 1.15)
        self.scale(zoom_factor, zoom_factor)
        event.accept()

    @staticmethod
    def _distance_to_segment(pt: QPointF, a: QPointF, b: QPointF) -> float:
        line_vec = b - a
        line_len = math.hypot(line_vec.x(), line_vec.y())
        if line_len < 1e-4:
            return math.hypot(pt.x() - a.x(), pt.y() - a.y())
        t = max(0.0, min(1.0, ((pt.x() - a.x()) * line_vec.x() + (pt.y() - a.y()) * line_vec.y()) / (line_len ** 2)))
        proj = QPointF(a.x() + t * line_vec.x(), a.y() + t * line_vec.y())
        return math.hypot(pt.x() - proj.x(), pt.y() - proj.y())


# ==============================================================================
# CAMERA CALIBRATION MODAL DIALOG
# ==============================================================================

class CameraCalibrationDialog(QDialog):
    """Modern Industrial Visual Calibration Modal for Vision Measurements."""

    calibration_applied = pyqtSignal(float, str)  # (factor, unit)

    def __init__(
        self,
        parent: Optional[QWidget] = None,
        pipeline_engine=None,
        camera_device=None,
        get_frame_cb: Optional[Callable[[], Optional[np.ndarray]]] = None,
    ):
        super().__init__(parent)
        self.pipeline_engine = pipeline_engine
        self.camera_device = camera_device or getattr(parent, "camera", None)
        self.get_frame_cb = get_frame_cb
        self.config = load_calibration_config()

        self._is_frozen = False
        self._current_frame: Optional[np.ndarray] = None

        self.setWindowTitle("Camera Optical Metrology & Visual Calibration — VisionStudio")
        self.resize(1100, 720)
        self.setMinimumSize(960, 620)
        self.setStyleSheet("""
            QDialog {
                background-color: #121519;
                color: #E0E6ED;
                font-family: 'Segoe UI', sans-serif;
            }
            QLabel {
                color: #E0E6ED;
            }
            QGroupBox {
                border: 1px solid #2B323D;
                border-radius: 8px;
                margin-top: 14px;
                padding-top: 16px;
                font-weight: 700;
                color: #00D2FF;
                background-color: #16191D;
            }
            QGroupBox::title {
                subcontrol-origin: margin;
                left: 12px;
                padding: 0 6px;
            }
            QLineEdit, QDoubleSpinBox, QComboBox {
                background-color: #1F242D;
                color: #00D2FF;
                border: 1px solid #363E4E;
                border-radius: 6px;
                padding: 6px 10px;
                font-weight: 700;
                font-size: 12px;
            }
            QLineEdit:focus, QDoubleSpinBox:focus, QComboBox:focus {
                border-color: #00D2FF;
            }
            QComboBox QAbstractItemView {
                background-color: #1F242D;
                color: #E0E6ED;
                selection-background-color: #00D2FF;
                selection-color: #0B0D13;
            }
        """)

        self._init_ui()

        # 30 FPS Camera Live Refresh Timer
        self._stream_timer = QTimer(self)
        self._stream_timer.timeout.connect(self._fetch_and_render_frame)
        self._stream_timer.start(33)

        # Initial frame load
        self._fetch_and_render_frame()

    def _init_ui(self):
        main_layout = QVBoxLayout(self)
        main_layout.setContentsMargins(14, 14, 14, 14)
        main_layout.setSpacing(10)

        # Header Title Bar
        header_bar = QHBoxLayout()
        icon_lbl = QLabel("📐")
        icon_lbl.setStyleSheet("font-size: 26px; margin-right: 6px;")
        header_bar.addWidget(icon_lbl)

        title_vbox = QVBoxLayout()
        header_title = QLabel("Visual Optical Calibration & Scale Factor")
        header_title.setStyleSheet("font-size: 15px; font-weight: 800; color: #00D2FF; letter-spacing: 0.5px;")
        sub_title = QLabel("Click & drag directly on the camera view to draw a ruler line over a physical gauge or scale (e.g., 100mm ruler).")
        sub_title.setStyleSheet("font-size: 11px; color: #8C9BAE;")
        title_vbox.addWidget(header_title)
        title_vbox.addWidget(sub_title)
        header_bar.addLayout(title_vbox)
        header_bar.addStretch()

        self.lbl_camera_badge = QLabel("● LIVE CAMERA STREAM")
        self.lbl_camera_badge.setStyleSheet("""
            background-color: rgba(0, 230, 118, 0.15);
            color: #00E676;
            border: 1px solid #00E676;
            border-radius: 6px;
            padding: 4px 10px;
            font-weight: 800;
            font-size: 11px;
            font-family: 'Consolas';
        """)
        header_bar.addWidget(self.lbl_camera_badge)
        main_layout.addLayout(header_bar)

        # Main Central Splitter (Left: Viewfinder Canvas; Right: Control Drawer)
        splitter = QSplitter(Qt.Orientation.Horizontal)
        splitter.setStyleSheet("""
            QSplitter::handle {
                background: #2B323D;
                width: 3px;
                border-radius: 1px;
            }
        """)

        # ------------------ Left Viewfinder Pane ------------------
        view_container = QWidget()
        view_layout = QVBoxLayout(view_container)
        view_layout.setContentsMargins(0, 0, 0, 0)
        view_layout.setSpacing(6)

        # Viewfinder Top Toolbar
        tb_layout = QHBoxLayout()
        tb_layout.setSpacing(6)

        self.btn_freeze = QPushButton("❄ Freeze Frame")
        self.btn_freeze.setToolTip("Freeze motionless frame to calmly position endpoints on ruler markings")
        self.btn_freeze.setStyleSheet("""
            QPushButton {
                background-color: #242A35;
                color: #00D2FF;
                border: 1px solid #363E4E;
                font-weight: 700;
                padding: 5px 12px;
                border-radius: 5px;
            }
            QPushButton:hover {
                background-color: #2F3746;
                border-color: #00D2FF;
            }
        """)
        self.btn_freeze.clicked.connect(self._toggle_freeze)
        tb_layout.addWidget(self.btn_freeze)

        btn_zoom_in = QPushButton("🔍+")
        btn_zoom_in.setToolTip("Zoom in on ruler markings for subpixel precision")
        btn_zoom_in.setStyleSheet("background-color: #242A35; color: #E0E6ED; border: 1px solid #363E4E; font-weight: 700; padding: 5px 10px; border-radius: 5px;")
        btn_zoom_in.clicked.connect(lambda: self.view.scale(1.25, 1.25))
        tb_layout.addWidget(btn_zoom_in)

        btn_zoom_out = QPushButton("🔍-")
        btn_zoom_out.setToolTip("Zoom out")
        btn_zoom_out.setStyleSheet("background-color: #242A35; color: #E0E6ED; border: 1px solid #363E4E; font-weight: 700; padding: 5px 10px; border-radius: 5px;")
        btn_zoom_out.clicked.connect(lambda: self.view.scale(0.8, 0.8))
        tb_layout.addWidget(btn_zoom_out)

        btn_fit = QPushButton("⛶ Fit View")
        btn_fit.setToolTip("Fit complete camera frame into window")
        btn_fit.setStyleSheet("background-color: #242A35; color: #E0E6ED; border: 1px solid #363E4E; font-weight: 700; padding: 5px 10px; border-radius: 5px;")
        btn_fit.clicked.connect(lambda: self.view.fit_to_view())
        tb_layout.addWidget(btn_fit)

        btn_center_ruler = QPushButton("⟲ Center Ruler")
        btn_center_ruler.setToolTip("Reset calibration ruler to horizontal center of camera frame")
        btn_center_ruler.setStyleSheet("background-color: #242A35; color: #E0E6ED; border: 1px solid #363E4E; font-weight: 700; padding: 5px 10px; border-radius: 5px;")
        btn_center_ruler.clicked.connect(lambda: self.view.reset_ruler_centered())
        tb_layout.addWidget(btn_center_ruler)

        tb_layout.addStretch()

        self.lbl_hud_coords = QLabel("P1: (200, 360) → P2: (600, 360)")
        self.lbl_hud_coords.setStyleSheet("font-family: 'Consolas'; color: #8C9BAE; font-size: 11px;")
        tb_layout.addWidget(self.lbl_hud_coords)

        view_layout.addLayout(tb_layout)

        # Interactive Graphics View
        self.view = VisualCalibrationView(self)
        self.view.ruler_changed.connect(self._on_ruler_changed)
        view_layout.addWidget(self.view, 1)

        splitter.addWidget(view_container)

        # ------------------ Right Control Drawer ------------------
        drawer_container = QWidget()
        drawer_layout = QVBoxLayout(drawer_container)
        drawer_layout.setContentsMargins(10, 0, 4, 0)
        drawer_layout.setSpacing(12)

        # Step 1: On-Screen Line Measurement
        grp_meas = QGroupBox("1. On-Screen Ruler Measurement")
        m_layout = QGridLayout(grp_meas)
        m_layout.setContentsMargins(12, 14, 12, 12)
        m_layout.setSpacing(8)

        m_layout.addWidget(QLabel("Measured Pixels:"), 0, 0)
        self.spin_measured_px = QDoubleSpinBox()
        self.spin_measured_px.setRange(1.0, 50000.0)
        self.spin_measured_px.setDecimals(2)
        self.spin_measured_px.setSuffix(" px")
        self.spin_measured_px.setValue(float(self.config.get("last_measured_px", 500.0)))
        self.spin_measured_px.valueChanged.connect(self._compute_ratio)
        m_layout.addWidget(self.spin_measured_px, 0, 1)

        m_layout.addWidget(QLabel("Ruler Angle:"), 1, 0)
        self.lbl_angle = QLabel("0.0° (Horizontal)")
        self.lbl_angle.setStyleSheet("font-family: 'Consolas'; font-weight: 700; color: #00D2FF;")
        m_layout.addWidget(self.lbl_angle, 1, 1)

        drawer_layout.addWidget(grp_meas)

        # Step 2: Known Physical Dimension
        grp_known = QGroupBox("2. Known Physical Reference Size")
        k_layout = QGridLayout(grp_known)
        k_layout.setContentsMargins(12, 14, 12, 12)
        k_layout.setSpacing(8)

        k_layout.addWidget(QLabel("Known Physical Size:"), 0, 0)
        self.spin_known_dim = QDoubleSpinBox()
        self.spin_known_dim.setRange(0.01, 100000.0)
        self.spin_known_dim.setDecimals(2)
        self.spin_known_dim.setValue(float(self.config.get("last_known_dim", 100.0)))
        self.spin_known_dim.valueChanged.connect(self._compute_ratio)
        k_layout.addWidget(self.spin_known_dim, 0, 1)

        k_layout.addWidget(QLabel("Measurement Unit:"), 1, 0)
        self.combo_unit = QComboBox()
        self.combo_unit.addItems(["mm", "cm", "in", "um", "px"])
        cur_unit = self.config.get("unit", "mm")
        idx = self.combo_unit.findText(cur_unit)
        if idx >= 0:
            self.combo_unit.setCurrentIndex(idx)
        self.combo_unit.currentIndexChanged.connect(self._compute_ratio)
        k_layout.addWidget(self.combo_unit, 1, 1)

        # Quick Reference Scale Presets (10mm, 50mm, 100mm, 150mm, 300mm)
        lbl_preset = QLabel("Standard Gauge / Scale Presets:")
        lbl_preset.setStyleSheet("font-size: 11px; color: #8C9BAE; margin-top: 4px;")
        k_layout.addWidget(lbl_preset, 2, 0, 1, 2)

        preset_row = QHBoxLayout()
        preset_row.setSpacing(4)
        for val_mm in [10.0, 50.0, 100.0, 150.0, 300.0]:
            btn_p = QPushButton(f"{int(val_mm)} mm")
            btn_p.setStyleSheet("""
                QPushButton {
                    background-color: #242A35;
                    color: #B0BAC9;
                    border: 1px solid #363E4E;
                    padding: 4px 6px;
                    border-radius: 4px;
                    font-size: 11px;
                    font-weight: 700;
                }
                QPushButton:hover {
                    background-color: #2F3746;
                    color: #00D2FF;
                    border-color: #00D2FF;
                }
            """)
            btn_p.clicked.connect(lambda _, v=val_mm: self._apply_preset_dimension(v))
            preset_row.addWidget(btn_p)
        k_layout.addLayout(preset_row, 3, 0, 1, 2)

        drawer_layout.addWidget(grp_known)

        # Step 3: Computed Calibration Result Card
        grp_result = QGroupBox("3. Computed Scale Factor")
        r_layout = QVBoxLayout(grp_result)
        r_layout.setContentsMargins(12, 14, 12, 12)
        r_layout.setSpacing(8)

        # Scale Factor Spinbox for direct manual entry or fine-tuning
        direct_row = QHBoxLayout()
        direct_row.addWidget(QLabel("Scale Factor (Units/px):"))
        self.spin_factor = QDoubleSpinBox()
        self.spin_factor.setRange(0.00001, 1000.0)
        self.spin_factor.setDecimals(5)
        self.spin_factor.setSingleStep(0.001)
        self.spin_factor.setValue(float(self.config.get("calibration_factor", 0.10)))
        direct_row.addWidget(self.spin_factor)
        r_layout.addLayout(direct_row)

        self.card_result = QFrame()
        self.card_result.setStyleSheet("""
            QFrame {
                background-color: #1A212D;
                border: 1px solid #00D2FF;
                border-radius: 6px;
                padding: 10px;
            }
        """)
        res_vbox = QVBoxLayout(self.card_result)
        res_vbox.setSpacing(4)

        self.lbl_factor_badge = QLabel("1 px = 0.2000 mm")
        self.lbl_factor_badge.setStyleSheet("font-size: 14px; font-weight: 800; color: #00E676; font-family: 'Consolas';")
        res_vbox.addWidget(self.lbl_factor_badge)

        self.lbl_res_badge = QLabel("Resolution: 5.00 px / mm")
        self.lbl_res_badge.setStyleSheet("font-size: 11px; color: #8C9BAE; font-family: 'Consolas';")
        res_vbox.addWidget(self.lbl_res_badge)

        r_layout.addWidget(self.card_result)

        drawer_layout.addWidget(grp_result)

        # Step 4: Recipe Propagation & Controls
        self.chk_update_pipeline = QCheckBox("Update all Caliper / Measurement steps in recipe")
        self.chk_update_pipeline.setChecked(True)
        self.chk_update_pipeline.setStyleSheet("color: #00E676; font-weight: 700; margin-top: 4px;")
        drawer_layout.addWidget(self.chk_update_pipeline)

        drawer_layout.addStretch()

        # Action Buttons
        btn_box = QHBoxLayout()
        btn_box.setSpacing(8)

        btn_cancel = QPushButton("Cancel")
        btn_cancel.setStyleSheet("""
            QPushButton {
                background-color: #242A35;
                color: #B0BAC9;
                border: 1px solid #363E4E;
                padding: 8px 16px;
                border-radius: 6px;
                font-weight: 600;
            }
            QPushButton:hover {
                background-color: #2F3746;
                color: #E0E6ED;
            }
        """)
        btn_cancel.clicked.connect(self.reject)
        btn_box.addWidget(btn_cancel)

        btn_apply = QPushButton("✓ Apply & Save Calibration")
        btn_apply.setStyleSheet("""
            QPushButton {
                background-color: #00E676;
                color: #0B0D13;
                border: 1px solid #00C853;
                padding: 8px 20px;
                border-radius: 6px;
                font-weight: 800;
                font-size: 12px;
            }
            QPushButton:hover {
                background-color: #69F0AE;
                border-color: #00E676;
            }
        """)
        btn_apply.clicked.connect(self._on_save_applied)
        btn_box.addWidget(btn_apply)

        drawer_layout.addLayout(btn_box)

        splitter.addWidget(drawer_container)
        splitter.setStretchFactor(0, 7)
        splitter.setStretchFactor(1, 3)
        splitter.setSizes([750, 350])

        main_layout.addWidget(splitter, 1)

        # Initial ratio computation
        self._compute_ratio()

    # ------------------ Camera Stream Acquisition ------------------

    def _fetch_and_render_frame(self):
        """Fetches the latest camera frame or test pattern and renders to viewfinder."""
        if self._is_frozen and self._current_frame is not None:
            return

        frame = None

        # 1. Try provided frame callback
        if self.get_frame_cb:
            try:
                frame = self.get_frame_cb()
            except Exception:
                pass

        # 2. Try camera device directly
        if frame is None and self.camera_device and hasattr(self.camera_device, "get_latest_frame"):
            try:
                frame = self.camera_device.get_latest_frame()
            except Exception:
                pass

        # 3. Fallback: check cached step frame or load test pattern
        if frame is None or frame.size == 0:
            if self.pipeline_engine and self.pipeline_engine.steps:
                s0 = self.pipeline_engine.steps[0]
                if s0.cached_output is not None and s0.cached_output.size > 0:
                    frame = s0.cached_output

        # 4. Generate visual calibration test pattern if no camera attached
        if frame is None or frame.size == 0:
            if self._current_frame is None:
                frame = self._generate_synthetic_scale_pattern()

        if frame is not None and frame.size > 0:
            self._current_frame = frame
            self.view.set_frame(frame)

    def _generate_synthetic_scale_pattern(self) -> np.ndarray:
        """Generates a 1280x720 industrial calibration pattern with an authentic 100mm scale."""
        w, h = 1280, 720
        img = np.full((h, w, 3), 20, dtype=np.uint8)

        # Alignment grid
        for x in range(0, w, 64):
            cv2.line(img, (x, 0), (x, h), (32, 36, 48), 1)
        for y in range(0, h, 64):
            cv2.line(img, (0, y), (w, y), (32, 36, 48), 1)

        # Simulated 100mm Floor Scale Gauge (width = 500 px -> 0.20 mm/px)
        sx, sy, sw, sh = 390, 310, 500, 100
        cv2.rectangle(img, (sx, sy), (sx + sw, sy + sh), (220, 225, 230), -1)
        cv2.rectangle(img, (sx, sy), (sx + sw, sy + sh), (100, 110, 125), 2)

        # Scale tick marks (every 10mm = 50px)
        for i in range(11):
            tx = sx + i * 50
            tick_h = 35 if (i % 5 == 0) else 20
            cv2.line(img, (tx, sy + sh), (tx, sy + sh - tick_h), (25, 30, 40), 2)
            if i % 2 == 0:
                cv2.putText(img, f"{i*10}", (tx - 12, sy + sh - 42), cv2.FONT_HERSHEY_SIMPLEX, 0.45, (25, 30, 40), 1, cv2.LINE_AA)

        cv2.putText(img, "REFERENCE 100 mm FLOOR GAUGE", (sx + 80, sy + 30), cv2.FONT_HERSHEY_SIMPLEX, 0.65, (20, 25, 35), 2, cv2.LINE_AA)
        cv2.putText(img, "Tip: Click & drag to align cyan/green endpoints with 0 and 100 mm tick marks", (40, 680), cv2.FONT_HERSHEY_SIMPLEX, 0.55, (0, 210, 255), 1, cv2.LINE_AA)

        return img

    def _toggle_freeze(self):
        self._is_frozen = not self._is_frozen
        if self._is_frozen:
            self.btn_freeze.setText("▶ Resume Live Video")
            self.btn_freeze.setStyleSheet("""
                QPushButton {
                    background-color: #1F3044;
                    color: #00E676;
                    border: 1px solid #00E676;
                    font-weight: 800;
                    padding: 5px 12px;
                    border-radius: 5px;
                }
            """)
            self.lbl_camera_badge.setText("❄ FROZEN CALIBRATION FRAME")
            self.lbl_camera_badge.setStyleSheet("""
                background-color: rgba(0, 210, 255, 0.15);
                color: #00D2FF;
                border: 1px solid #00D2FF;
                border-radius: 6px;
                padding: 4px 10px;
                font-weight: 800;
                font-size: 11px;
                font-family: 'Consolas';
            """)
        else:
            self.btn_freeze.setText("❄ Freeze Frame")
            self.btn_freeze.setStyleSheet("""
                QPushButton {
                    background-color: #242A35;
                    color: #00D2FF;
                    border: 1px solid #363E4E;
                    font-weight: 700;
                    padding: 5px 12px;
                    border-radius: 5px;
                }
            """)
            self.lbl_camera_badge.setText("● LIVE CAMERA STREAM")
            self.lbl_camera_badge.setStyleSheet("""
                background-color: rgba(0, 230, 118, 0.15);
                color: #00E676;
                border: 1px solid #00E676;
                border-radius: 6px;
                padding: 4px 10px;
                font-weight: 800;
                font-size: 11px;
                font-family: 'Consolas';
            """)

    # ------------------ Mathematical Scaling ------------------

    def _on_ruler_changed(self, pixel_dist: float, p1: QPointF, p2: QPointF):
        self.spin_measured_px.blockSignals(True)
        self.spin_measured_px.setValue(pixel_dist)
        self.spin_measured_px.blockSignals(False)

        ang = self.view.ruler.angle_deg()
        self.lbl_angle.setText(f"{ang:.1f}°")
        self.lbl_hud_coords.setText(f"P1: ({p1.x():.0f}, {p1.y():.0f}) → P2: ({p2.x():.0f}, {p2.y():.0f})")

        self._compute_ratio()

    def _apply_preset_dimension(self, val_mm: float):
        self.spin_known_dim.setValue(val_mm)
        self._compute_ratio()

    def _compute_ratio(self):
        known = self.spin_known_dim.value()
        pixels = self.spin_measured_px.value()
        unit = self.combo_unit.currentText()

        if pixels > 0:
            factor = known / pixels
            self.spin_factor.blockSignals(True)
            self.spin_factor.setValue(factor)
            self.spin_factor.blockSignals(False)

            px_per_unit = 1.0 / factor if factor > 0 else 0.0

            self.lbl_factor_badge.setText(f"1 px = {factor:.4f} {unit}")
            self.lbl_res_badge.setText(f"Resolution: {px_per_unit:.2f} px / {unit}")

            # Synchronize ruler overlay HUD badge
            self.view.update_calibration_data(known, factor, unit)

    def _on_save_applied(self):
        factor = float(self.spin_factor.value())
        unit = self.combo_unit.currentText()

        self.config["calibration_factor"] = factor
        self.config["unit"] = unit
        self.config["last_known_dim"] = float(self.spin_known_dim.value())
        self.config["last_measured_px"] = float(self.spin_measured_px.value())
        save_calibration_config(self.config)

        # Propagate to pipeline if requested
        if self.chk_update_pipeline.isChecked() and self.pipeline_engine:
            for s in self.pipeline_engine.steps:
                if s.operation_name == "Industrial Caliper & Measurement":
                    s.set_param("calibration_factor", factor)
                    s.set_param("unit", unit)
            self.pipeline_engine.mark_dirty_from(0)

        self._stream_timer.stop()
        self.calibration_applied.emit(factor, unit)
        self.accept()

    def closeEvent(self, event):
        self._stream_timer.stop()
        super().closeEvent(event)

    def reject(self):
        self._stream_timer.stop()
        super().reject()
