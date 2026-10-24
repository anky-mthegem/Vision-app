"""Interactive Add Operation Dialog for Pipeline Step Creation.

Provides categorized browsing with search filtering, operation descriptions,
parameter previews, custom step naming, and input source selection.
"""

from __future__ import annotations
from typing import Dict, List, Optional, Tuple
from PyQt6.QtCore import Qt
from PyQt6.QtGui import QFont, QColor
from PyQt6.QtWidgets import (
    QDialog,
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QLabel,
    QLineEdit,
    QListWidget,
    QListWidgetItem,
    QComboBox,
    QCheckBox,
    QPushButton,
    QSplitter,
    QFrame,
    QScrollArea,
)

from pipeline_engine import (
    PipelineEngine,
    OPERATION_REGISTRY,
    get_categories,
    get_operations_in_category,
)
import operations_catalog


class AddStepDialog(QDialog):
    """Modern categorized dialog allowing the operator to select and configure an operation before adding it to the pipeline."""

    CATEGORY_ICONS = {
        "AI & Deep Learning (YOLO)": "🤖",
        "Pre-processing & Filtering": "🎨",
        "Thresholding & Binarization": "⚖️",
        "Morphology": "🔄",
        "Edges & Gradients": "📏",
        "Contours & Calipers": "🔍",
        "Feature Detection": "🎯",
        "Custom & Enhancements": "✨",
    }

    def __init__(self, engine: PipelineEngine, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.engine = engine
        self.selected_category: str = ""
        self.selected_operation: str = ""
        self.step_name: str = ""
        self.input_source_id: int = 0
        self.link_to_remote: bool = False

        self.setWindowTitle("Add Pipeline Operation")
        self.resize(850, 560)
        self.setStyleSheet("""
            QDialog {
                background-color: #16191D;
                color: #E0E6ED;
                font-family: 'Segoe UI', sans-serif;
            }
            QLabel {
                color: #E0E6ED;
            }
            QLineEdit {
                background-color: #1F242D;
                color: #00D2FF;
                border: 1px solid #363E4E;
                border-radius: 6px;
                padding: 6px 10px;
                font-size: 12px;
            }
            QLineEdit:focus {
                border-color: #00D2FF;
            }
            QListWidget {
                background-color: #1F242D;
                border: 1px solid #2B323D;
                border-radius: 6px;
                color: #E0E6ED;
                padding: 4px;
            }
            QListWidget::item {
                padding: 8px 10px;
                border-radius: 4px;
                margin-bottom: 2px;
            }
            QListWidget::item:hover {
                background-color: #262D38;
                color: #00D2FF;
            }
            QListWidget::item:selected {
                background-color: #00D2FF;
                color: #0B0D13;
                font-weight: 700;
            }
            QComboBox {
                background-color: #1F242D;
                color: #E0E6ED;
                border: 1px solid #363E4E;
                border-radius: 6px;
                padding: 5px 10px;
                font-size: 12px;
            }
            QComboBox:hover {
                border-color: #00D2FF;
            }
        """)

        self._init_ui()
        self._populate_categories()

    def _init_ui(self):
        main_layout = QVBoxLayout(self)
        main_layout.setContentsMargins(16, 16, 16, 16)
        main_layout.setSpacing(12)

        # Top Header & Search Bar
        top_bar = QHBoxLayout()
        header_title = QLabel("Select Vision Operation to Add")
        header_title.setStyleSheet("font-size: 16px; font-weight: 800; color: #00D2FF;")
        top_bar.addWidget(header_title)
        top_bar.addStretch()

        self.edit_search = QLineEdit()
        self.edit_search.setPlaceholderText("🔍 Search all operations (e.g. canny, yolo, blur, otsu)...")
        self.edit_search.setFixedWidth(300)
        self.edit_search.textChanged.connect(self._on_search_text_changed)
        top_bar.addWidget(self.edit_search)
        main_layout.addLayout(top_bar)

        # 3-Column Splitter: Categories | Operations | Details Preview
        splitter = QSplitter(Qt.Orientation.Horizontal)
        splitter.setStyleSheet("""
            QSplitter::handle {
                background-color: #2B323D;
                width: 4px;
            }
        """)

        # 1. Categories Column
        cat_widget = QWidget()
        cat_layout = QVBoxLayout(cat_widget)
        cat_layout.setContentsMargins(0, 0, 0, 0)
        cat_layout.addWidget(QLabel("<b>Categories</b>"))
        self.list_categories = QListWidget()
        self.list_categories.currentRowChanged.connect(self._on_category_changed)
        cat_layout.addWidget(self.list_categories)
        splitter.addWidget(cat_widget)

        # 2. Operations Column
        ops_widget = QWidget()
        ops_layout = QVBoxLayout(ops_widget)
        ops_layout.setContentsMargins(0, 0, 0, 0)
        ops_layout.addWidget(QLabel("<b>Available Functions</b>"))
        self.list_operations = QListWidget()
        self.list_operations.currentRowChanged.connect(self._on_operation_changed)
        self.list_operations.itemDoubleClicked.connect(self._on_accept)
        ops_layout.addWidget(self.list_operations)
        splitter.addWidget(ops_widget)

        # 3. Details & Configuration Column
        details_widget = QFrame()
        details_widget.setStyleSheet("""
            QFrame {
                background-color: #1F242D;
                border: 1px solid #2B323D;
                border-radius: 6px;
                padding: 10px;
            }
        """)
        det_layout = QVBoxLayout(details_widget)
        det_layout.setContentsMargins(12, 10, 12, 10)
        det_layout.setSpacing(10)

        self.lbl_det_title = QLabel("Operation Details")
        self.lbl_det_title.setStyleSheet("font-size: 14px; font-weight: 800; color: #00D2FF;")
        det_layout.addWidget(self.lbl_det_title)

        self.lbl_det_cat = QLabel("Category: --")
        self.lbl_det_cat.setStyleSheet("color: #8C9BAE; font-size: 11px;")
        det_layout.addWidget(self.lbl_det_cat)

        self.lbl_det_desc = QLabel("Select an operation from the list to view its specifications.")
        self.lbl_det_desc.setWordWrap(True)
        self.lbl_det_desc.setStyleSheet("color: #B0BAC9; font-size: 11px; margin-top: 4px;")
        det_layout.addWidget(self.lbl_det_desc)

        det_layout.addSpacing(6)
        det_layout.addWidget(QLabel("<b>Configurable Parameters:</b>"))
        self.lbl_det_params = QLabel("None")
        self.lbl_det_params.setWordWrap(True)
        self.lbl_det_params.setStyleSheet("color: #8C9BAE; font-family: 'Consolas', monospace; font-size: 11px;")
        det_layout.addWidget(self.lbl_det_params)

        det_layout.addStretch()

        # Step Custom Name
        det_layout.addWidget(QLabel("Custom Step Name:"))
        self.edit_step_name = QLineEdit()
        self.edit_step_name.setPlaceholderText("e.g. My Edge Inspection")
        det_layout.addWidget(self.edit_step_name)

        # Input Source Selection
        det_layout.addWidget(QLabel("Input Source:"))
        self.combo_source = QComboBox()
        self._populate_input_sources()
        det_layout.addWidget(self.combo_source)

        # Remote Device Link
        self.chk_link_remote = QCheckBox("🔗 Link output to remote device (PLC / Ethernet / RPi)")
        self.chk_link_remote.setStyleSheet("color: #00D2FF; font-weight: 600; font-size: 11px; margin-top: 6px;")
        det_layout.addWidget(self.chk_link_remote)

        splitter.addWidget(details_widget)
        splitter.setSizes([200, 260, 340])
        main_layout.addWidget(splitter, 1)

        # Bottom Button Bar
        btn_bar = QHBoxLayout()
        btn_bar.addStretch()

        btn_cancel = QPushButton("Cancel")
        btn_cancel.setStyleSheet("""
            QPushButton {
                background-color: #242A35;
                color: #B0BAC9;
                border: 1px solid #363E4E;
                padding: 7px 18px;
                border-radius: 6px;
                font-weight: 600;
            }
            QPushButton:hover {
                background-color: #2F3746;
                color: #E0E6ED;
            }
        """)
        btn_cancel.clicked.connect(self.reject)
        btn_bar.addWidget(btn_cancel)

        self.btn_add = QPushButton("✓ Add to Pipeline")
        self.btn_add.setStyleSheet("""
            QPushButton {
                background-color: #00E676;
                color: #0B0D13;
                border: 1px solid #00C853;
                padding: 7px 22px;
                border-radius: 6px;
                font-weight: 800;
                font-size: 12px;
            }
            QPushButton:hover {
                background-color: #69F0AE;
                border-color: #00E676;
            }
        """)
        self.btn_add.clicked.connect(self._on_accept)
        btn_bar.addWidget(self.btn_add)

        main_layout.addLayout(btn_bar)

    def _populate_input_sources(self):
        self.combo_source.clear()
        # Default: Previous Step
        if self.engine.steps:
            prev_step = self.engine.steps[-1]
            prev_idx = len(self.engine.steps)
            self.combo_source.addItem(f"Previous Step (#{prev_idx}: {prev_step.operation_name})", prev_step.step_id)
        
        self.combo_source.addItem("Step 0: Raw Camera Frame", 0)

        for idx, s in enumerate(self.engine.steps):
            self.combo_source.addItem(f"Step #{idx + 1}: {s.name} ({s.operation_name})", s.step_id)

    def _populate_categories(self):
        self.list_categories.clear()
        categories = get_categories()
        for cat in categories:
            icon = self.CATEGORY_ICONS.get(cat, "📁")
            item = QListWidgetItem(f"{icon}  {cat}")
            item.setData(Qt.ItemDataRole.UserRole, cat)
            self.list_categories.addItem(item)

        if self.list_categories.count() > 0:
            self.list_categories.setCurrentRow(0)

    def _on_category_changed(self, row: int):
        if row < 0:
            return
        item = self.list_categories.item(row)
        cat = item.data(Qt.ItemDataRole.UserRole)
        self.selected_category = cat
        self._populate_operations(cat)

    def _populate_operations(self, category: str):
        self.list_operations.clear()
        ops = get_operations_in_category(category)
        for op in ops:
            self.list_operations.addItem(op)

        if self.list_operations.count() > 0:
            self.list_operations.setCurrentRow(0)

    def _on_search_text_changed(self, query: str):
        query = query.strip().lower()
        if not query:
            # Revert to category view
            cur_row = self.list_categories.currentRow()
            if cur_row >= 0:
                self._on_category_changed(cur_row)
            return

        # Global search across all operations (name matches prioritized over descriptions)
        self.list_operations.clear()
        name_matches = []
        desc_matches = []
        for op_name, op_cls in OPERATION_REGISTRY.items():
            if query in op_name.lower():
                name_matches.append((op_name, op_cls))
            elif query in op_cls.category.lower() or query in op_cls.description.lower():
                desc_matches.append((op_name, op_cls))

        for op_name, op_cls in name_matches + desc_matches:
            item = QListWidgetItem(f"{op_name}  [{op_cls.category}]")
            item.setData(Qt.ItemDataRole.UserRole, (op_cls.category, op_name))
            self.list_operations.addItem(item)

        if self.list_operations.count() > 0:
            self.list_operations.setCurrentRow(0)

    def _on_operation_changed(self, row: int):
        if row < 0:
            return
        item = self.list_operations.item(row)
        user_data = item.data(Qt.ItemDataRole.UserRole)
        if user_data and isinstance(user_data, tuple):
            cat, op_name = user_data
        else:
            cat = self.selected_category
            op_name = item.text()

        self.selected_category = cat
        self.selected_operation = op_name

        # Update details panel
        op_cls = OPERATION_REGISTRY.get(op_name)
        if op_cls:
            self.lbl_det_title.setText(op_cls.name)
            self.lbl_det_cat.setText(f"Category: {op_cls.category}")
            self.lbl_det_desc.setText(op_cls.description)

            # Parameter list
            if op_cls.param_schemas:
                param_strs = [f"• {s.label} ({s.name}): default={s.default}" for s in op_cls.param_schemas]
                self.lbl_det_params.setText("\n".join(param_strs))
            else:
                self.lbl_det_params.setText("• No configurable parameters.")

            self.edit_step_name.setText(op_cls.name)

    def _on_accept(self):
        if not self.selected_operation:
            return
        self.step_name = self.edit_step_name.text().strip() or self.selected_operation
        src = self.combo_source.currentData()
        self.input_source_id = src if src is not None else 0
        self.link_to_remote = self.chk_link_remote.isChecked()
        self.accept()
