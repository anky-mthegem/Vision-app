"""High-Performance Interactive Pan/Zoom Image Viewport with Synchronized Split View.

Supports Single View, Dual Split View (Side-by-Side or Top/Bottom),
Synchronized Pan & Zoom, Difference / Blend Mode, and Live Pixel Inspector HUD.
"""

from __future__ import annotations
import math
from typing import Dict, Optional, Tuple
import cv2
import numpy as np

from PyQt6.QtCore import Qt, QPoint, QPointF, QRectF, pyqtSignal, QEvent
from PyQt6.QtGui import (
    QImage,
    QPixmap,
    QPainter,
    QWheelEvent,
    QMouseEvent,
    QTransform,
    QColor,
    QFont,
)
from PyQt6.QtWidgets import (
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QGraphicsView,
    QGraphicsScene,
    QGraphicsPixmapItem,
    QLabel,
    QComboBox,
    QPushButton,
    QSplitter,
    QFrame,
    QToolButton,
    QButtonGroup,
)


class PanZoomGraphicsView(QGraphicsView):
    """QGraphicsView with smooth mouse-wheel zooming, middle-click panning,

    pixel coordinate inspection, and synchronization signals.
    """

    zoom_changed = pyqtSignal(float, QPointF)  # (scale_factor, scene_center)
    pan_changed = pyqtSignal(QPointF)          # (scene_center)
    pixel_inspected = pyqtSignal(int, int, object)  # (x, y, pixel_value_str)

    def __init__(self, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.scene = QGraphicsScene(self)
        self.setScene(self.scene)
        self.pixmap_item = QGraphicsPixmapItem()
        self.scene.addItem(self.pixmap_item)

        self._image_cache: Optional[np.ndarray] = None
        self._is_panning = False
        self._pan_start = QPoint()
        self._current_zoom = 1.0
        self._sync_enabled = True

        # Render hints
        self.setRenderHint(QPainter.RenderHint.Antialiasing, False)
        self.setRenderHint(QPainter.RenderHint.SmoothPixmapTransform, False)
        self.setTransformationAnchor(QGraphicsView.ViewportAnchor.AnchorUnderMouse)
        self.setResizeAnchor(QGraphicsView.ViewportAnchor.AnchorUnderMouse)
        self.setVerticalScrollBarPolicy(Qt.ScrollBarPolicy.ScrollBarAlwaysOff)
        self.setHorizontalScrollBarPolicy(Qt.ScrollBarPolicy.ScrollBarAlwaysOff)
        self.setFrameShape(QFrame.Shape.NoFrame)
        self.setMouseTracking(True)
        self.setStyleSheet("background-color: #0E1114;")

    def set_image(self, img: Optional[np.ndarray]):
        self._image_cache = img
        if img is None or img.size == 0:
            self.pixmap_item.setPixmap(QPixmap())
            return

        h, w = img.shape[:2]
        if img.ndim == 2:
            bytes_per_line = w
            q_img = QImage(img.data, w, h, bytes_per_line, QImage.Format.Format_Grayscale8)
        elif img.ndim == 3 and img.shape[2] == 3:
            bytes_per_line = 3 * w
            q_img = QImage(img.data, w, h, bytes_per_line, QImage.Format.Format_BGR888)
        elif img.ndim == 3 and img.shape[2] == 4:
            bytes_per_line = 4 * w
            q_img = QImage(img.data, w, h, bytes_per_line, QImage.Format.Format_ARGB32)
        else:
            q_img = QImage()

        pix = QPixmap.fromImage(q_img)
        self.pixmap_item.setPixmap(pix)
        self.scene.setSceneRect(0, 0, w, h)

    def fit_image(self):
        """Fits image neatly inside the viewport bounds."""
        if self._image_cache is None:
            return
        self.resetTransform()
        rect = self.pixmap_item.boundingRect()
        if not rect.isEmpty():
            self.fitInView(rect, Qt.AspectRatioMode.KeepAspectRatio)
            self._current_zoom = self.transform().m11()
            center = self.mapToScene(self.viewport().rect().center())
            self.zoom_changed.emit(self._current_zoom, center)

    def zoom_100(self):
        """Sets 1:1 pixel scale."""
        self.resetTransform()
        self._current_zoom = 1.0
        center = self.mapToScene(self.viewport().rect().center())
        self.zoom_changed.emit(self._current_zoom, center)

    def apply_sync_transform(self, scale: float, scene_center: QPointF):
        """Applies transform received from partner viewport without re-emitting sync signals."""
        self.blockSignals(True)
        self.resetTransform()
        self.scale(scale, scale)
        self.centerOn(scene_center)
        self._current_zoom = scale
        self.blockSignals(False)

    def wheelEvent(self, event: QWheelEvent):
        delta = event.angleDelta().y()
        if delta == 0:
            return

        factor = 1.20 if delta > 0 else 0.8333
        new_zoom = self._current_zoom * factor

        # Clamp zoom level between 0.05x and 40x
        if 0.05 <= new_zoom <= 40.0:
            self._current_zoom = new_zoom
            self.scale(factor, factor)
            center = self.mapToScene(self.viewport().rect().center())
            self.zoom_changed.emit(self._current_zoom, center)

        event.accept()

    def mousePressEvent(self, event: QMouseEvent):
        if event.button() in (Qt.MouseButton.MiddleButton, Qt.MouseButton.LeftButton):
            self._is_panning = True
            self._pan_start = event.pos()
            self.setCursor(Qt.CursorShape.ClosedHandCursor)
            event.accept()
        else:
            super().mousePressEvent(event)

    def mouseMoveEvent(self, event: QMouseEvent):
        # 1. Handle Panning
        if self._is_panning:
            delta = event.pos() - self._pan_start
            self._pan_start = event.pos()
            self.horizontalScrollBar().setValue(self.horizontalScrollBar().value() - delta.x())
            self.verticalScrollBar().setValue(self.verticalScrollBar().value() - delta.y())
            center = self.mapToScene(self.viewport().rect().center())
            self.pan_changed.emit(center)
            event.accept()

        # 2. Handle Pixel Inspector
        pos_scene = self.mapToScene(event.pos())
        x = int(math.floor(pos_scene.x()))
        y = int(math.floor(pos_scene.y()))

        if self._image_cache is not None:
            h, w = self._image_cache.shape[:2]
            if 0 <= x < w and 0 <= y < h:
                val = self._image_cache[y, x]
                if self._image_cache.ndim == 2:
                    val_str = f"Gray: {val}"
                elif self._image_cache.shape[2] == 3:
                    b, g, r = int(val[0]), int(val[1]), int(val[2])
                    val_str = f"RGB: ({r}, {g}, {b})  Hex: #{r:02X}{g:02X}{b:02X}"
                else:
                    val_str = str(val)
                self.pixel_inspected.emit(x, y, val_str)
            else:
                self.pixel_inspected.emit(x, y, "Outside Image")

        super().mouseMoveEvent(event)

    def mouseReleaseEvent(self, event: QMouseEvent):
        if self._is_panning:
            self._is_panning = False
            self.setCursor(Qt.CursorShape.ArrowCursor)
            event.accept()
        else:
            super().mouseReleaseEvent(event)


class SingleViewportPanel(QWidget):
    """Sub-viewport containing header badge, pan/zoom view, and floating HUD overlay."""

    def __init__(self, label: str = "Viewport A", parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.label_prefix = label
        self.step_id: int = 0
        self.operation_name: str = "Raw Image"

        layout = QVBoxLayout(self)
        layout.setContentsMargins(2, 2, 2, 2)
        layout.setSpacing(4)

        # Header bar
        self.header = QFrame()
        self.header.setStyleSheet("""
            QFrame {
                background-color: #1F242D;
                border: 1px solid #2B323D;
                border-radius: 6px;
                padding: 4px;
            }
        """)
        h_layout = QHBoxLayout(self.header)
        h_layout.setContentsMargins(6, 2, 6, 2)
        h_layout.setSpacing(8)

        self.lbl_badge = QLabel(f" {label} ")
        self.lbl_badge.setStyleSheet("""
            background-color: #00D2FF;
            color: #0B0D13;
            font-weight: 800;
            font-size: 11px;
            border-radius: 3px;
            padding: 2px 6px;
        """)
        h_layout.addWidget(self.lbl_badge)

        self.source_combo = QComboBox()
        self.source_combo.setStyleSheet("""
            QComboBox {
                background-color: #16191D;
                color: #E0E6ED;
                border: 1px solid #363E4E;
                border-radius: 4px;
                padding: 2px 8px;
                font-size: 11px;
                min-width: 140px;
            }
            QComboBox:hover {
                border-color: #00D2FF;
            }
        """)
        h_layout.addWidget(self.source_combo)

        self.lbl_info = QLabel("Viewing: Step 0 - Raw Image")
        self.lbl_info.setStyleSheet("color: #8C9BAE; font-size: 11px; font-weight: 600;")
        h_layout.addWidget(self.lbl_info)
        h_layout.addStretch()

        # Zoom buttons
        self.btn_fit = QToolButton()
        self.btn_fit.setText("Zoom Fit")
        self.btn_fit.setToolTip("Fit image inside viewport")
        self.btn_fit.setStyleSheet("background: #242A35; color: #B0BAC9; border: 1px solid #363E4E; border-radius: 4px; padding: 2px 8px; font-size: 10px;")
        h_layout.addWidget(self.btn_fit)

        self.btn_100 = QToolButton()
        self.btn_100.setText("1:1")
        self.btn_100.setToolTip("Zoom to 100% native resolution")
        self.btn_100.setStyleSheet("background: #242A35; color: #B0BAC9; border: 1px solid #363E4E; border-radius: 4px; padding: 2px 8px; font-size: 10px;")
        h_layout.addWidget(self.btn_100)

        layout.addWidget(self.header)

        # Viewport Frame with Stacked HUD
        self.view_container = QWidget()
        v_layout = QVBoxLayout(self.view_container)
        v_layout.setContentsMargins(0, 0, 0, 0)

        self.graphics_view = PanZoomGraphicsView(self)
        v_layout.addWidget(self.graphics_view)

        # Floating HUD Overlay for Pixel Inspector
        self.hud_label = QLabel("X: --  Y: --  |  Pixel: --", self.graphics_view)
        self.hud_label.setStyleSheet("""
            background-color: rgba(15, 18, 24, 0.85);
            color: #00D2FF;
            font-family: 'Consolas', monospace;
            font-size: 11px;
            font-weight: 600;
            border: 1px solid #2B323D;
            border-radius: 4px;
            padding: 4px 8px;
        """)
        self.hud_label.move(12, 12)
        self.hud_label.show()

        self.graphics_view.pixel_inspected.connect(self._on_pixel_inspected)
        self.btn_fit.clicked.connect(self.graphics_view.fit_image)
        self.btn_100.clicked.connect(self.graphics_view.zoom_100)

        layout.addWidget(self.view_container, 1)

    def _on_pixel_inspected(self, x: int, y: int, val_str: str):
        self.hud_label.setText(f"X: {x}  Y: {y}  |  {val_str}")
        self.hud_label.adjustSize()

    def update_header(self, step_id: int, op_name: str, info_str: str):
        self.step_id = step_id
        self.operation_name = op_name
        step_text = f"Step {step_id}: {op_name}" if step_id > 0 else "Step 0: Raw Camera Image"
        self.lbl_info.setText(f"Viewing: {step_text}  [{info_str}]")


class FlexibleInspectionViewport(QWidget):
    """Main container hosting Single View vs. 2-Window Synchronized Split View."""

    # Emitted when source selection changes: (viewport_index, step_id)
    source_selection_changed = pyqtSignal(int, int)

    def __init__(self, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self._is_split_mode = False
        self._is_diff_mode = False
        self._diff_style = "absdiff"  # "absdiff" or "blend"

        self._pipeline_results: Dict[int, np.ndarray] = {}
        self._pipeline_step_names: Dict[int, str] = {0: "Step 0: Raw Camera Image"}

        self.source_a_id = 0
        self.source_b_id = 0

        self._init_ui()
        self._setup_sync()

    def _init_ui(self):
        main_layout = QVBoxLayout(self)
        main_layout.setContentsMargins(6, 6, 6, 6)
        main_layout.setSpacing(6)

        # Top Master Control Toolbar
        self.top_toolbar = QFrame()
        self.top_toolbar.setStyleSheet("""
            QFrame {
                background-color: #1F242D;
                border: 1px solid #2B323D;
                border-radius: 8px;
                padding: 4px;
            }
        """)
        tb_layout = QHBoxLayout(self.top_toolbar)
        tb_layout.setContentsMargins(8, 4, 8, 4)
        tb_layout.setSpacing(10)

        tb_layout.addWidget(QLabel("Viewport Mode:"))

        # Segmented View Mode Toggle: [ Single View ] | [ 2-Window Split View ]
        self.btn_single = QPushButton("Single View")
        self.btn_single.setCheckable(True)
        self.btn_single.setChecked(True)
        self.btn_single.setStyleSheet(self._get_toggle_btn_style())

        self.btn_split = QPushButton("2-Window Split View")
        self.btn_split.setCheckable(True)
        self.btn_split.setChecked(False)
        self.btn_split.setStyleSheet(self._get_toggle_btn_style())

        self.mode_group = QButtonGroup(self)
        self.mode_group.addButton(self.btn_single)
        self.mode_group.addButton(self.btn_split)

        tb_layout.addWidget(self.btn_single)
        tb_layout.addWidget(self.btn_split)

        # Split orientation toggle
        self.btn_orient = QPushButton("Toggle Orientation (H/V)")
        self.btn_orient.setStyleSheet("""
            QPushButton {
                background-color: #242A35;
                color: #B0BAC9;
                border: 1px solid #363E4E;
                border-radius: 4px;
                padding: 4px 10px;
                font-size: 11px;
            }
            QPushButton:hover {
                background-color: #2F3746;
                color: #00D2FF;
            }
        """)
        self.btn_orient.clicked.connect(self._toggle_split_orientation)
        self.btn_orient.hide()
        tb_layout.addWidget(self.btn_orient)

        # Difference / Blend Mode Button
        self.btn_diff = QPushButton("Diff / Blend Overlay")
        self.btn_diff.setCheckable(True)
        self.btn_diff.setChecked(False)
        self.btn_diff.setStyleSheet(self._get_toggle_btn_style())
        self.btn_diff.clicked.connect(self._on_diff_toggle)
        self.btn_diff.hide()
        tb_layout.addWidget(self.btn_diff)

        tb_layout.addStretch()

        self.lbl_fps_stat = QLabel("Synchronized Pan & Zoom: ON")
        self.lbl_fps_stat.setStyleSheet("color: #00E676; font-size: 11px; font-weight: 700;")
        tb_layout.addWidget(self.lbl_fps_stat)

        main_layout.addWidget(self.top_toolbar)

        # Splitter housing Viewport A and Viewport B
        self.splitter = QSplitter(Qt.Orientation.Horizontal)
        self.splitter.setStyleSheet("""
            QSplitter::handle {
                background-color: #2B323D;
                width: 6px;
                height: 6px;
            }
            QSplitter::handle:hover {
                background-color: #00D2FF;
            }
        """)

        self.viewport_a = SingleViewportPanel("Viewport A (Primary)")
        self.viewport_b = SingleViewportPanel("Viewport B (Comparison)")
        self.viewport_b.lbl_badge.setStyleSheet("""
            background-color: #FFB300;
            color: #0B0D13;
            font-weight: 800;
            font-size: 11px;
            border-radius: 3px;
            padding: 2px 6px;
        """)

        self.splitter.addWidget(self.viewport_a)
        self.splitter.addWidget(self.viewport_b)

        # Start in Single View mode: Hide Viewport B
        self.viewport_b.hide()

        main_layout.addWidget(self.splitter, 1)

        # Connect view mode buttons
        self.btn_single.clicked.connect(lambda: self.set_view_mode(split=False))
        self.btn_split.clicked.connect(lambda: self.set_view_mode(split=True))

        # Connect source dropdowns
        self.viewport_a.source_combo.currentIndexChanged.connect(self._on_combo_a_changed)
        self.viewport_b.source_combo.currentIndexChanged.connect(self._on_combo_b_changed)

    def _setup_sync(self):
        """Cross-connects zoom and pan between Viewport A and Viewport B for pixel-perfect alignment."""
        view_a = self.viewport_a.graphics_view
        view_b = self.viewport_b.graphics_view

        view_a.zoom_changed.connect(lambda s, c: view_b.apply_sync_transform(s, c) if self._is_split_mode else None)
        view_a.pan_changed.connect(lambda c: view_b.apply_sync_transform(view_a._current_zoom, c) if self._is_split_mode else None)

        view_b.zoom_changed.connect(lambda s, c: view_a.apply_sync_transform(s, c) if self._is_split_mode else None)
        view_b.pan_changed.connect(lambda c: view_a.apply_sync_transform(view_b._current_zoom, c) if self._is_split_mode else None)

    @staticmethod
    def _get_toggle_btn_style() -> str:
        return """
            QPushButton {
                background-color: #242A35;
                color: #B0BAC9;
                border: 1px solid #363E4E;
                border-radius: 6px;
                padding: 4px 12px;
                font-weight: 700;
                font-size: 11px;
            }
            QPushButton:hover {
                background-color: #2F3746;
                color: #00D2FF;
                border-color: #00D2FF;
            }
            QPushButton:checked {
                background-color: #00D2FF;
                color: #0B0D13;
                border-color: #00D2FF;
            }
        """

    def set_view_mode(self, split: bool):
        self._is_split_mode = split
        self.btn_single.setChecked(not split)
        self.btn_split.setChecked(split)

        if split:
            self.viewport_b.show()
            self.btn_orient.show()
            self.btn_diff.show()
            self.splitter.setSizes([700, 700])
            # Synchronize view B to match view A immediately
            self.viewport_b.graphics_view.apply_sync_transform(
                self.viewport_a.graphics_view._current_zoom,
                self.viewport_a.graphics_view.mapToScene(self.viewport_a.graphics_view.viewport().rect().center()),
            )
        else:
            self.viewport_b.hide()
            self.btn_orient.hide()
            self.btn_diff.hide()
            if self._is_diff_mode:
                self._is_diff_mode = False
                self.btn_diff.setChecked(False)

        self._refresh_viewport_images()

    def _toggle_split_orientation(self):
        cur = self.splitter.orientation()
        new_orient = Qt.Orientation.Vertical if cur == Qt.Orientation.Horizontal else Qt.Orientation.Horizontal
        self.splitter.setOrientation(new_orient)

    def _on_diff_toggle(self, checked: bool):
        self._is_diff_mode = checked
        self._refresh_viewport_images()

    def update_pipeline_results(self, results: Dict[int, np.ndarray], step_names: Dict[int, str]):
        """Receives new execution frame buffers from pipeline worker."""
        self._pipeline_results = results
        self._pipeline_step_names = step_names

        # Update dropdown items if step count changed
        self._update_dropdown_items()
        self._refresh_viewport_images()

    def _update_dropdown_items(self):
        current_step_items = list(self._pipeline_step_names.items())
        if getattr(self, "_cached_step_items", None) == current_step_items:
            return
        self._cached_step_items = current_step_items

        for combo in (self.viewport_a.source_combo, self.viewport_b.source_combo):
            current_id = combo.currentData() if combo.count() > 0 else 0
            if current_id is None:
                current_id = 0

            combo.blockSignals(True)
            combo.clear()
            for s_id, s_name in self._pipeline_step_names.items():
                combo.addItem(s_name, s_id)

            idx = combo.findData(current_id)
            if idx >= 0:
                combo.setCurrentIndex(idx)
            else:
                combo.setCurrentIndex(0)
            combo.blockSignals(False)

    def set_viewport_a_source(self, step_id: int):
        self.source_a_id = step_id
        idx = self.viewport_a.source_combo.findData(step_id)
        if idx >= 0:
            self.viewport_a.source_combo.blockSignals(True)
            self.viewport_a.source_combo.setCurrentIndex(idx)
            self.viewport_a.source_combo.blockSignals(False)
        self._refresh_viewport_images()

    def set_viewport_b_source(self, step_id: int):
        self.source_b_id = step_id
        idx = self.viewport_b.source_combo.findData(step_id)
        if idx >= 0:
            self.viewport_b.source_combo.blockSignals(True)
            self.viewport_b.source_combo.setCurrentIndex(idx)
            self.viewport_b.source_combo.blockSignals(False)
        self._refresh_viewport_images()

    def _on_combo_a_changed(self, idx: int):
        step_id = self.viewport_a.source_combo.itemData(idx)
        if step_id is not None:
            self.source_a_id = step_id
            self.source_selection_changed.emit(0, step_id)
            self._refresh_viewport_images()

    def _on_combo_b_changed(self, idx: int):
        step_id = self.viewport_b.source_combo.itemData(idx)
        if step_id is not None:
            self.source_b_id = step_id
            self.source_selection_changed.emit(1, step_id)
            self._refresh_viewport_images()

    def _refresh_viewport_images(self):
        img_a = self._pipeline_results.get(self.source_a_id)
        img_b = self._pipeline_results.get(self.source_b_id)

        # Single view or standard split view
        if not self._is_diff_mode or not self._is_split_mode:
            self.viewport_a.graphics_view.set_image(img_a)
            name_a = self._pipeline_step_names.get(self.source_a_id, f"Step {self.source_a_id}")
            self.viewport_a.update_header(self.source_a_id, name_a, self._get_shape_str(img_a))

            if self._is_split_mode:
                self.viewport_b.graphics_view.set_image(img_b)
                name_b = self._pipeline_step_names.get(self.source_b_id, f"Step {self.source_b_id}")
                self.viewport_b.update_header(self.source_b_id, name_b, self._get_shape_str(img_b))

        else:
            # Difference / Blend Mode in Split View
            diff_img = self._compute_diff_or_blend(img_a, img_b)
            self.viewport_a.graphics_view.set_image(img_a)
            self.viewport_b.graphics_view.set_image(diff_img)
            name_a = self._pipeline_step_names.get(self.source_a_id, f"Step {self.source_a_id}")
            self.viewport_a.update_header(self.source_a_id, name_a, self._get_shape_str(img_a))
            self.viewport_b.update_header(-1, "Diff / Blend Overlay", self._get_shape_str(diff_img))

    def _compute_diff_or_blend(self, img_a: Optional[np.ndarray], img_b: Optional[np.ndarray]) -> Optional[np.ndarray]:
        if img_a is None or img_b is None:
            return img_a or img_b

        # Ensure matching shapes and 3 channels for visual diff
        ha, wa = img_a.shape[:2]
        hb, wb = img_b.shape[:2]

        a_3ch = cv2.cvtColor(img_a, cv2.COLOR_GRAY2BGR) if img_a.ndim == 2 else img_a
        b_3ch = cv2.cvtColor(img_b, cv2.COLOR_GRAY2BGR) if img_b.ndim == 2 else img_b

        if (ha, wa) != (hb, wb):
            b_3ch = cv2.resize(b_3ch, (wa, ha))

        # Absolute Difference with Color Heatmap
        diff = cv2.absdiff(a_3ch, b_3ch)
        diff_gray = cv2.cvtColor(diff, cv2.COLOR_BGR2GRAY)
        heatmap = cv2.applyColorMap(diff_gray, cv2.COLORMAP_JET)

        # Blend with original image A
        overlay = cv2.addWeighted(a_3ch, 0.6, heatmap, 0.4, 0)
        cv2.putText(overlay, "DIFFERENCE HEATMAP (JET)", (20, 35), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0, 255, 255), 2)
        return overlay

    @staticmethod
    def _get_shape_str(img: Optional[np.ndarray]) -> str:
        if img is None:
            return "No Image"
        h, w = img.shape[:2]
        ch = 1 if img.ndim == 2 else img.shape[2]
        return f"{w}x{h} ({'Gray' if ch==1 else f'{ch}ch'})"

    def fit_all_views(self):
        self.viewport_a.graphics_view.fit_image()
        if self._is_split_mode:
            self.viewport_b.graphics_view.fit_image()
