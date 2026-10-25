"""Startup Banner & Splash Screen for Vision Studio.

Features:
- Frameless translucent window with drop shadow and ambient neon cyan glow
- App name "VISION STUDIO" on top
- App logo centered on an illuminated circular halo disc
- Bottom author tag: "Made with <3 By Anky Singh"
- Smooth fade-in and fade-out transitions
- Auto-dismiss after 2.5s or instant dismissal on click / keypress
"""

from __future__ import annotations
import os
import sys

from PyQt6.QtCore import Qt, QPoint, QRectF, QTimer, QPropertyAnimation, QEasingCurve, pyqtSignal
from PyQt6.QtGui import (
    QPixmap, QFont, QColor, QPainter, QPainterPath,
    QLinearGradient, QRadialGradient, QBrush, QPen, QCursor
)
from PyQt6.QtWidgets import (
    QApplication, QWidget, QVBoxLayout, QHBoxLayout, QLabel, 
    QFrame, QGraphicsDropShadowEffect, QGraphicsOpacityEffect
)

# Robust path resolution for assets
PROJECT_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
LOGO_PATH = os.path.join(PROJECT_ROOT, "assets", "app_logo.png")


class VisionStudioBanner(QFrame):
    """Sleek Cyber-Industrial Startup Banner Card."""

    def __init__(self, parent=None, width: int = 440, height: int = 270):
        super().__init__(parent)
        self.card_w = width
        self.card_h = height
        self.setFixedSize(self.card_w, self.card_h)
        self.setAttribute(Qt.WidgetAttribute.WA_TranslucentBackground)
        self.init_ui()

    def init_ui(self):
        layout = QVBoxLayout(self)
        layout.setContentsMargins(24, 22, 24, 18)
        layout.setSpacing(0)

        # ---------------- TOP: App Name ----------------
        title_box = QVBoxLayout()
        title_box.setSpacing(2)

        self.sub_badge = QLabel("• INDUSTRIAL CV SUITE •")
        self.sub_badge.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.sub_badge.setStyleSheet("""
            QLabel {
                color: #00D2FF;
                font-family: 'Segoe UI', -apple-system, sans-serif;
                font-size: 8px;
                font-weight: 700;
                letter-spacing: 3px;
                background: transparent;
            }
        """)
        title_box.addWidget(self.sub_badge)

        self.title_label = QLabel("VISION STUDIO")
        self.title_label.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.title_label.setStyleSheet("""
            QLabel {
                color: #FFFFFF;
                font-family: 'Segoe UI', -apple-system, BlinkMacSystemFont, 'Montserrat', sans-serif;
                font-size: 23px;
                font-weight: 800;
                letter-spacing: 6px;
                background: transparent;
            }
        """)
        title_box.addWidget(self.title_label)
        layout.addLayout(title_box)

        layout.addSpacing(10)

        # ---------------- CENTER: App Logo ----------------
        center_box = QHBoxLayout()
        center_box.setAlignment(Qt.AlignmentFlag.AlignCenter)

        self.logo_label = QLabel()
        self.logo_label.setFixedSize(98, 98)
        self.logo_label.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.logo_label.setStyleSheet("background: transparent;")

        if os.path.exists(LOGO_PATH):
            orig_pix = QPixmap(LOGO_PATH)
            scaled_pix = orig_pix.scaled(
                92, 92,
                Qt.AspectRatioMode.KeepAspectRatio,
                Qt.TransformationMode.SmoothTransformation
            )
            self.logo_label.setPixmap(scaled_pix)

        center_box.addWidget(self.logo_label)
        layout.addLayout(center_box)

        layout.addSpacing(14)

        # ---------------- BOTTOM: Made with <3 By Anky Singh ----------------
        self.footer_label = QLabel(
            "Made with <span style='color: #FF2E63; font-weight: bold; font-size: 13px;'>&lt;3</span> By <b style='color: #F1F5F9; letter-spacing: 0.5px;'>Anky Singh</b>"
        )
        self.footer_label.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.footer_label.setStyleSheet("""
            QLabel {
                color: #8C9BAE;
                font-family: 'Segoe UI', -apple-system, sans-serif;
                font-size: 11px;
                letter-spacing: 1px;
                background: transparent;
            }
        """)
        layout.addWidget(self.footer_label)

        layout.addSpacing(8)
        self.hint_label = QLabel("Loading Inspection Engine...")
        self.hint_label.setAlignment(Qt.AlignmentFlag.AlignCenter)
        self.hint_label.setStyleSheet("""
            QLabel {
                color: #4A5568;
                font-family: 'Segoe UI', monospace;
                font-size: 9px;
                letter-spacing: 1px;
                background: transparent;
            }
        """)
        layout.addWidget(self.hint_label)

    def paintEvent(self, event):
        painter = QPainter(self)
        painter.setRenderHint(QPainter.RenderHint.Antialiasing)

        rect = QRectF(1.5, 1.5, self.width() - 3.0, self.height() - 3.0)
        radius = 18.0

        # Background gradient (Dark industrial slate)
        bg_gradient = QLinearGradient(0, 0, 0, self.height())
        bg_gradient.setColorAt(0.0, QColor("#181E26"))
        bg_gradient.setColorAt(0.3, QColor("#13171F"))
        bg_gradient.setColorAt(0.75, QColor("#0D1015"))
        bg_gradient.setColorAt(1.0, QColor("#090B0E"))

        path = QPainterPath()
        path.addRoundedRect(rect, radius, radius)
        painter.fillPath(path, bg_gradient)

        # Central illuminated plate behind logo
        cx = self.width() / 2.0
        cy = 126.0
        plate_radius = 56.0

        halo_gradient = QRadialGradient(cx, cy, plate_radius + 25)
        halo_gradient.setColorAt(0.0, QColor(0, 210, 255, 45))
        halo_gradient.setColorAt(0.5, QColor(0, 210, 255, 15))
        halo_gradient.setColorAt(1.0, QColor(0, 210, 255, 0))
        painter.setPen(Qt.PenStyle.NoPen)
        painter.setBrush(QBrush(halo_gradient))
        painter.drawEllipse(QPoint(int(cx), int(cy)), int(plate_radius + 20), int(plate_radius + 20))

        disc_gradient = QRadialGradient(cx, cy, plate_radius)
        disc_gradient.setColorAt(0.0, QColor(20, 28, 38, 200))
        disc_gradient.setColorAt(0.85, QColor(13, 18, 26, 220))
        disc_gradient.setColorAt(1.0, QColor(0, 210, 255, 60))
        painter.setBrush(QBrush(disc_gradient))
        painter.setPen(QPen(QColor(0, 210, 255, 50), 1))
        painter.drawEllipse(QPoint(int(cx), int(cy)), int(plate_radius), int(plate_radius))

        # Neon Cyan dual-tone border
        border_gradient = QLinearGradient(0, 0, self.width(), self.height())
        border_gradient.setColorAt(0.0, QColor(0, 210, 255, 230))
        border_gradient.setColorAt(0.35, QColor(0, 210, 255, 70))
        border_gradient.setColorAt(0.7, QColor(43, 50, 61, 100))
        border_gradient.setColorAt(1.0, QColor(0, 210, 255, 160))

        pen_border = QPen(QBrush(border_gradient), 1.4)
        painter.setPen(pen_border)
        painter.setBrush(Qt.BrushStyle.NoBrush)
        painter.drawRoundedRect(rect, radius, radius)

        # Top glass sheen line
        sheen_rect = rect.adjusted(12, 1, -12, -1)
        top_sheen = QLinearGradient(0, 2, self.width(), 2)
        top_sheen.setColorAt(0.0, QColor(255, 255, 255, 0))
        top_sheen.setColorAt(0.3, QColor(255, 255, 255, 25))
        top_sheen.setColorAt(0.5, QColor(0, 210, 255, 80))
        top_sheen.setColorAt(0.7, QColor(255, 255, 255, 25))
        top_sheen.setColorAt(1.0, QColor(255, 255, 255, 0))
        painter.setPen(QPen(QBrush(top_sheen), 1.2))
        painter.drawLine(int(sheen_rect.left()), 3, int(sheen_rect.right()), 3)

        # Bottom accent line with heart highlight
        bot_bar = QLinearGradient(self.width() * 0.15, self.height() - 4, self.width() * 0.85, self.height() - 4)
        bot_bar.setColorAt(0.0, QColor(0, 210, 255, 0))
        bot_bar.setColorAt(0.3, QColor(0, 210, 255, 180))
        bot_bar.setColorAt(0.5, QColor(255, 46, 99, 220))
        bot_bar.setColorAt(0.7, QColor(0, 210, 255, 180))
        bot_bar.setColorAt(1.0, QColor(0, 210, 255, 0))
        painter.setPen(QPen(QBrush(bot_bar), 2.0))
        painter.drawLine(int(self.width() * 0.18), self.height() - 4, int(self.width() * 0.82), self.height() - 4)


class StartupBannerSplash(QWidget):
    """Frameless Splash Screen Window that automatically displays on app startup."""
    
    finished = pyqtSignal()

    def __init__(self, auto_dismiss_ms: int = 2500):
        super().__init__()
        self._closing = False
        self.setWindowFlags(
            Qt.WindowType.FramelessWindowHint | 
            Qt.WindowType.WindowStaysOnTopHint | 
            Qt.WindowType.SplashScreen
        )
        self.setAttribute(Qt.WidgetAttribute.WA_TranslucentBackground)
        self.setCursor(QCursor(Qt.CursorShape.PointingHandCursor))

        self.layout = QVBoxLayout(self)
        self.layout.setContentsMargins(30, 30, 30, 30)

        # Banner Card
        self.card = VisionStudioBanner(self, width=440, height=270)

        # Drop Shadow / Cyan Glow
        shadow = QGraphicsDropShadowEffect(self)
        shadow.setBlurRadius(36)
        shadow.setColor(QColor(0, 210, 255, 65))
        shadow.setOffset(0, 4)
        self.card.setGraphicsEffect(shadow)

        self.layout.addWidget(self.card)
        self.adjustSize()

        # Center on primary screen
        if screen := QApplication.primaryScreen():
            geo = screen.geometry()
            self.move(
                (geo.width() - self.width()) // 2,
                (geo.height() - self.height()) // 2
            )

        # Opacity fade-in animation
        self.opacity_effect = QGraphicsOpacityEffect(self)
        self.setGraphicsEffect(self.opacity_effect)
        self.anim_in = QPropertyAnimation(self.opacity_effect, b"opacity")
        self.anim_in.setDuration(350)
        self.anim_in.setStartValue(0.0)
        self.anim_in.setEndValue(1.0)
        self.anim_in.setEasingCurve(QEasingCurve.Type.OutCubic)
        self.anim_in.start()

        # Auto-dismiss timer
        if auto_dismiss_ms > 0:
            self.timer = QTimer(self)
            self.timer.setSingleShot(True)
            self.timer.timeout.connect(self.fade_out_and_close)
            self.timer.start(auto_dismiss_ms)
        else:
            self.timer = None

    def mousePressEvent(self, event):
        self.fade_out_and_close()

    def keyPressEvent(self, event):
        if event.key() in (Qt.Key.Key_Escape, Qt.Key.Key_Return, Qt.Key.Key_Space):
            self.fade_out_and_close()

    def fade_out_and_close(self):
        if self._closing:
            return
        self._closing = True
        if self.timer and self.timer.isActive():
            self.timer.stop()

        self.anim_out = QPropertyAnimation(self.opacity_effect, b"opacity")
        self.anim_out.setDuration(280)
        self.anim_out.setStartValue(self.opacity_effect.opacity())
        self.anim_out.setEndValue(0.0)
        self.anim_out.finished.connect(self._on_fade_finished)
        self.anim_out.start()

    def _on_fade_finished(self):
        self.finished.emit()
        self.close()
