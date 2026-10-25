"""Interactive On-Canvas Region of Interest (ROI) Item for QGraphicsScene.

Provides a professional draggable, resizable ROI bounding box with 8 handles,
context cursors, live coordinate display, and boundary clamping.
"""

from __future__ import annotations
import math
from typing import Optional, Tuple
from PyQt6.QtCore import Qt, QRectF, QPointF, pyqtSignal
from PyQt6.QtGui import (
    QPainter, QPen, QBrush, QColor, QFont, QCursor
)
from PyQt6.QtWidgets import (
    QGraphicsObject, QGraphicsSceneMouseEvent, QStyleOptionGraphicsItem, QWidget
)


class InteractiveROIItem(QGraphicsObject):
    """Draggable and resizable bounding box overlay with 8 resize handles and coordinate pill."""

    roiChanged = pyqtSignal(int, int, int, int)      # (x, y, width, height)
    roiFinished = pyqtSignal(int, int, int, int)     # emitted on mouse release

    # Handle constants
    HANDLE_NONE = 0
    HANDLE_TL = 1
    HANDLE_TC = 2
    HANDLE_TR = 3
    HANDLE_RC = 4
    HANDLE_BR = 5
    HANDLE_BC = 6
    HANDLE_BL = 7
    HANDLE_LC = 8
    HANDLE_BODY = 9

    HANDLE_SIZE = 8.0  # size in pixels
    MIN_SIZE = 10.0    # minimum width/height

    def __init__(self, rect: Optional[QRectF] = None, parent=None):
        super().__init__(parent)
        self.setAcceptHoverEvents(True)
        self.setFlag(QGraphicsObject.GraphicsItemFlag.ItemIsSelectable, True)
        self.setFlag(QGraphicsObject.GraphicsItemFlag.ItemSendsGeometryChanges, True)

        self._rect: QRectF = rect or QRectF(50, 50, 200, 150)
        self._max_bounds: Optional[QRectF] = None
        self._active_handle = self.HANDLE_NONE
        self._mouse_press_pos = QPointF()
        self._press_rect = QRectF()
        self._color = QColor("#00D2FF")
        self._label = "ROI"

    def set_bounds_limit(self, width: int, height: int):
        """Sets the maximum boundary (typically image dimensions) to clamp the ROI within."""
        if width > 0 and height > 0:
            self._max_bounds = QRectF(0, 0, width, height)
            self._clamp_to_bounds()
            self.update()

    def set_rect(self, x: int, y: int, w: int, h: int, emit_signal: bool = True):
        """Sets the ROI coordinates directly (e.g. from Property Inspector)."""
        w = max(self.MIN_SIZE, float(w))
        h = max(self.MIN_SIZE, float(h))
        self.prepareGeometryChange()
        self._rect = QRectF(float(x), float(y), w, h)
        self._clamp_to_bounds()
        self.update()
        if emit_signal:
            rx, ry, rw, rh = self.get_rect_int()
            self.roiChanged.emit(rx, ry, rw, rh)

    def get_rect_int(self) -> Tuple[int, int, int, int]:
        """Returns integer pixel coordinates (x, y, w, h)."""
        return (
            int(round(self._rect.x())),
            int(round(self._rect.y())),
            int(round(self._rect.width())),
            int(round(self._rect.height())),
        )

    def _clamp_to_bounds(self):
        if not self._max_bounds:
            return
        # Clamp width and height to not exceed bounds
        if self._rect.width() > self._max_bounds.width():
            self._rect.setWidth(self._max_bounds.width())
        if self._rect.height() > self._max_bounds.height():
            self._rect.setHeight(self._max_bounds.height())

        # Clamp position
        if self._rect.left() < self._max_bounds.left():
            self._rect.moveLeft(self._max_bounds.left())
        if self._rect.right() > self._max_bounds.right():
            self._rect.moveRight(self._max_bounds.right())
        if self._rect.top() < self._max_bounds.top():
            self._rect.moveTop(self._max_bounds.top())
        if self._rect.bottom() > self._max_bounds.bottom():
            self._rect.moveBottom(self._max_bounds.bottom())

    def boundingRect(self) -> QRectF:
        pad = self.HANDLE_SIZE + 24.0  # space for handles and coordinate pill
        return self._rect.adjusted(-pad, -pad, pad, pad)

    def _get_handle_rects(self) -> dict[int, QRectF]:
        r = self._rect
        hs = self.HANDLE_SIZE
        half = hs / 2.0
        return {
            self.HANDLE_TL: QRectF(r.left() - half, r.top() - half, hs, hs),
            self.HANDLE_TC: QRectF(r.center().x() - half, r.top() - half, hs, hs),
            self.HANDLE_TR: QRectF(r.right() - half, r.top() - half, hs, hs),
            self.HANDLE_RC: QRectF(r.right() - half, r.center().y() - half, hs, hs),
            self.HANDLE_BR: QRectF(r.right() - half, r.bottom() - half, hs, hs),
            self.HANDLE_BC: QRectF(r.center().x() - half, r.bottom() - half, hs, hs),
            self.HANDLE_BL: QRectF(r.left() - half, r.bottom() - half, hs, hs),
            self.HANDLE_LC: QRectF(r.left() - half, r.center().y() - half, hs, hs),
        }

    def _get_handle_at(self, pos: QPointF) -> int:
        for handle, rect in self._get_handle_rects().items():
            # slightly larger hit test area for easy clicking
            if rect.adjusted(-3, -3, 3, 3).contains(pos):
                return handle
        if self._rect.contains(pos):
            return self.HANDLE_BODY
        return self.HANDLE_NONE

    def hoverMoveEvent(self, event: QGraphicsSceneMouseEvent):
        handle = self._get_handle_at(event.pos())
        if handle in (self.HANDLE_TL, self.HANDLE_BR):
            self.setCursor(QCursor(Qt.CursorShape.SizeFDiagCursor))
        elif handle in (self.HANDLE_TR, self.HANDLE_BL):
            self.setCursor(QCursor(Qt.CursorShape.SizeBDiagCursor))
        elif handle in (self.HANDLE_TC, self.HANDLE_BC):
            self.setCursor(QCursor(Qt.CursorShape.SizeVerCursor))
        elif handle in (self.HANDLE_LC, self.HANDLE_RC):
            self.setCursor(QCursor(Qt.CursorShape.SizeHorCursor))
        elif handle == self.HANDLE_BODY:
            self.setCursor(QCursor(Qt.CursorShape.SizeAllCursor))
        else:
            self.setCursor(QCursor(Qt.CursorShape.ArrowCursor))
        super().hoverMoveEvent(event)

    def hoverLeaveEvent(self, event):
        self.setCursor(QCursor(Qt.CursorShape.ArrowCursor))
        super().hoverLeaveEvent(event)

    def mousePressEvent(self, event: QGraphicsSceneMouseEvent):
        if event.button() == Qt.MouseButton.LeftButton:
            handle = self._get_handle_at(event.pos())
            if handle != self.HANDLE_NONE:
                self._active_handle = handle
                self._mouse_press_pos = event.pos()
                self._press_rect = QRectF(self._rect)
                event.accept()
                return
        super().mousePressEvent(event)

    def mouseMoveEvent(self, event: QGraphicsSceneMouseEvent):
        if self._active_handle == self.HANDLE_NONE:
            super().mouseMoveEvent(event)
            return

        delta = event.pos() - self._mouse_press_pos
        dx = delta.x()
        dy = delta.y()

        r = QRectF(self._press_rect)

        if self._active_handle == self.HANDLE_BODY:
            r.translate(dx, dy)
        else:
            if self._active_handle in (self.HANDLE_TL, self.HANDLE_LC, self.HANDLE_BL):
                r.setLeft(min(r.right() - self.MIN_SIZE, r.left() + dx))
            if self._active_handle in (self.HANDLE_TR, self.HANDLE_RC, self.HANDLE_BR):
                r.setRight(max(r.left() + self.MIN_SIZE, r.right() + dx))
            if self._active_handle in (self.HANDLE_TL, self.HANDLE_TC, self.HANDLE_TR):
                r.setTop(min(r.bottom() - self.MIN_SIZE, r.top() + dy))
            if self._active_handle in (self.HANDLE_BL, self.HANDLE_BC, self.HANDLE_BR):
                r.setBottom(max(r.top() + self.MIN_SIZE, r.bottom() + dy))

        self.prepareGeometryChange()
        self._rect = r.normalized()
        self._clamp_to_bounds()
        self.update()

        rx, ry, rw, rh = self.get_rect_int()
        self.roiChanged.emit(rx, ry, rw, rh)
        event.accept()

    def mouseReleaseEvent(self, event: QGraphicsSceneMouseEvent):
        if event.button() == Qt.MouseButton.LeftButton and self._active_handle != self.HANDLE_NONE:
            self._active_handle = self.HANDLE_NONE
            rx, ry, rw, rh = self.get_rect_int()
            self.roiFinished.emit(rx, ry, rw, rh)
            event.accept()
            return
        super().mouseReleaseEvent(event)

    def paint(self, painter: QPainter, option: QStyleOptionGraphicsItem, widget: Optional[QWidget] = None):
        painter.setRenderHint(QPainter.RenderHint.Antialiasing, True)

        r = self._rect

        # 1. Semi-transparent neon fill
        fill_color = QColor(0, 210, 255, 28)
        painter.fillRect(r, QBrush(fill_color))

        # 2. Subtle center crosshair
        cross_pen = QPen(QColor(0, 210, 255, 60), 1, Qt.PenStyle.DashLine)
        painter.setPen(cross_pen)
        painter.drawLine(int(r.center().x()), int(r.top()), int(r.center().x()), int(r.bottom()))
        painter.drawLine(int(r.left()), int(r.center().y()), int(r.right()), int(r.center().y()))

        # 3. Outer Border
        border_pen = QPen(self._color, 1.5, Qt.PenStyle.SolidLine)
        painter.setPen(border_pen)
        painter.drawRect(r)

        # 4. Resize Handles (8 points)
        handle_pen = QPen(QColor("#0E1116"), 1)
        handle_brush = QBrush(QColor("#FFFFFF"))
        painter.setPen(handle_pen)
        painter.setBrush(handle_brush)

        for rect in self._get_handle_rects().values():
            painter.drawRect(rect)

        # 5. Top Info / Coordinate Pill
        rx, ry, rw, rh = self.get_rect_int()
        pill_text = f"{self._label}: {rw}×{rh} [{rx}, {ry}]"
        
        font = QFont("Consolas", 8, QFont.Weight.Bold)
        painter.setFont(font)
        
        pill_w = len(pill_text) * 7.0 + 16.0
        pill_h = 18.0
        pill_x = r.left()
        pill_y = r.top() - pill_h - 4.0
        
        if pill_y < 0:
            pill_y = r.top() + 4.0  # flip inside if near top boundary

        pill_rect = QRectF(pill_x, pill_y, pill_w, pill_h)
        painter.setPen(QPen(QColor(0, 210, 255, 160), 1))
        painter.setBrush(QBrush(QColor(18, 22, 28, 220)))
        painter.drawRoundedRect(pill_rect, 3, 3)

        painter.setPen(QColor("#00D2FF"))
        painter.drawText(pill_rect, Qt.AlignmentFlag.AlignCenter, pill_text)
