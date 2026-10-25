"""Spreadsheet Pipeline Table Model, Delegates, and Action Bar.

Implements high-performance QTableView with QAbstractTableModel,
in-table dropdown delegates, context menus, and pipeline manipulation buttons.
"""

from __future__ import annotations
from typing import Any, List, Optional
from PyQt6.QtCore import (
    Qt,
    QAbstractTableModel,
    QModelIndex,
    pyqtSignal,
    QRect,
)
from PyQt6.QtGui import QColor, QFont, QAction, QPainter
from PyQt6.QtWidgets import (
    QWidget,
    QVBoxLayout,
    QHBoxLayout,
    QTableView,
    QItemDelegate,
    QComboBox,
    QCheckBox,
    QPushButton,
    QMenu,
    QHeaderView,
    QFileDialog,
    QDialog,
    QMessageBox,
    QFrame,
    QLabel,
)

from pipeline_engine import (
    PipelineEngine,
    PipelineStep,
    get_categories,
    get_operations_in_category,
)
import operations_catalog
from add_step_dialog import AddStepDialog


class PipelineTableModel(QAbstractTableModel):
    """Custom high-performance table model representing sequential pipeline steps."""

    COLUMNS = [
        "Step #",
        "Active",
        "Category",
        "Operation",
        "Input Source",
        "Output / Signal",
        "Latency",
        "Status",
    ]

    COL_STEP = 0
    COL_ACTIVE = 1
    COL_CATEGORY = 2
    COL_OPERATION = 3
    COL_INPUT = 4
    COL_OUTPUT = 5
    COL_LATENCY = 6
    COL_STATUS = 7

    step_modified = pyqtSignal(int)  # index of modified step

    def __init__(self, engine: PipelineEngine, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.engine = engine

    def rowCount(self, parent: QModelIndex = QModelIndex()) -> int:
        return len(self.engine.steps)

    def columnCount(self, parent: QModelIndex = QModelIndex()) -> int:
        return len(self.COLUMNS)

    def headerData(self, section: int, orientation: Qt.Orientation, role: int = Qt.ItemDataRole.DisplayRole) -> Any:
        if orientation == Qt.Orientation.Horizontal and role == Qt.ItemDataRole.DisplayRole:
            return self.COLUMNS[section]
        return None

    def data(self, index: QModelIndex, role: int = Qt.ItemDataRole.DisplayRole) -> Any:
        if not index.isValid() or not (0 <= index.row() < len(self.engine.steps)):
            return None

        step = self.engine.steps[index.row()]
        col = index.column()

        if role == Qt.ItemDataRole.DisplayRole:
            if col == self.COL_STEP:
                return f"#{index.row() + 1} (ID:{step.step_id})"
            elif col == self.COL_ACTIVE:
                return ""  # Rendered via CheckBox delegate
            elif col == self.COL_CATEGORY:
                return step.category
            elif col == self.COL_OPERATION:
                return step.operation_name
            elif col == self.COL_INPUT:
                if step.input_source_id == 0:
                    return "Step 0 (Raw Image)"
                src_step = self.engine.get_step_by_id(step.input_source_id)
                if src_step:
                    src_idx = self.engine.get_step_index(src_step.step_id)
                    return f"Step #{src_idx + 1} ({src_step.operation_name})"
                return f"Source ID: {step.input_source_id}"
            elif col == self.COL_OUTPUT:
                summary = step.get_output_summary()
                if getattr(step, "link_to_remote", False):
                    return f"📡 {summary}"
                return summary
            elif col == self.COL_LATENCY:
                return f"{step.last_exec_ms:.1f} ms"
            elif col == self.COL_STATUS:
                base_status = "✔ OK" if step.status_ok else "✖ Error"
                if getattr(step, "link_to_remote", False):
                    return f"{base_status} 🔗PLC"
                return base_status

        elif role == Qt.ItemDataRole.CheckStateRole:
            if col == self.COL_ACTIVE:
                return Qt.CheckState.Checked if step.active else Qt.CheckState.Unchecked

        elif role == Qt.ItemDataRole.ForegroundRole:
            if col == self.COL_STEP:
                return QColor("#00D2FF")
            elif col == self.COL_OUTPUT:
                return QColor("#00E676") if getattr(step, "link_to_remote", False) else QColor("#00D2FF")
            elif col == self.COL_LATENCY:
                return QColor("#8C9BAE")
            elif col == self.COL_STATUS:
                return QColor("#00E676") if step.status_ok else QColor("#FF3D71")
            elif not step.active:
                return QColor("#5A6678")

        elif role == Qt.ItemDataRole.FontRole:
            font = QFont("Consolas" if col in (self.COL_STEP, self.COL_OUTPUT, self.COL_LATENCY) else "Segoe UI", 9)
            if col in (self.COL_STEP, self.COL_STATUS):
                font.setBold(True)
            return font

        elif role == Qt.ItemDataRole.TextAlignmentRole:
            if col in (self.COL_STEP, self.COL_ACTIVE, self.COL_LATENCY, self.COL_STATUS):
                return Qt.AlignmentFlag.AlignCenter
            return Qt.AlignmentFlag.AlignVCenter | Qt.AlignmentFlag.AlignLeft

        elif role == Qt.ItemDataRole.ToolTipRole:
            if col == self.COL_OUTPUT:
                return "Output & Remote Signal sent to PLCs/Ethernet/GPIO. Click or double-click to configure."
            elif col == self.COL_STATUS:
                remote_str = " | 🔗 Output Linked to Remote PLC/Ethernet/RPi" if getattr(step, "link_to_remote", False) else ""
                return f"{step.status_msg}{remote_str}"
            elif col == self.COL_OPERATION:
                return step.operation.description if step.operation else ""

        return None

    def flags(self, index: QModelIndex) -> Qt.ItemFlag:
        if not index.isValid():
            return Qt.ItemFlag.NoItemFlags

        base_flags = Qt.ItemFlag.ItemIsEnabled | Qt.ItemFlag.ItemIsSelectable
        col = index.column()

        if col == self.COL_ACTIVE:
            return base_flags | Qt.ItemFlag.ItemIsUserCheckable
        elif col in (self.COL_CATEGORY, self.COL_OPERATION, self.COL_INPUT):
            return base_flags | Qt.ItemFlag.ItemIsEditable
        return base_flags

    def setData(self, index: QModelIndex, value: Any, role: int = Qt.ItemDataRole.EditRole) -> bool:
        if not index.isValid() or not (0 <= index.row() < len(self.engine.steps)):
            return False

        step = self.engine.steps[index.row()]
        col = index.column()

        if role == Qt.ItemDataRole.CheckStateRole and col == self.COL_ACTIVE:
            step.active = (value == Qt.CheckState.Checked.value or value is True)
            self.engine.mark_dirty_from(index.row())
            self.dataChanged.emit(index, index)
            self.step_modified.emit(index.row())
            return True

        if role == Qt.ItemDataRole.EditRole:
            if col == self.COL_CATEGORY:
                new_cat = str(value)
                if new_cat != step.category:
                    ops = get_operations_in_category(new_cat)
                    new_op = ops[0] if ops else "Gaussian Blur"
                    step.set_operation(new_cat, new_op)
                    self.engine.mark_dirty_from(index.row())
                    self.dataChanged.emit(self.index(index.row(), 0), self.index(index.row(), self.columnCount() - 1))
                    self.step_modified.emit(index.row())
                    return True

            elif col == self.COL_OPERATION:
                new_op = str(value)
                if new_op != step.operation_name:
                    step.set_operation(step.category, new_op)
                    self.engine.mark_dirty_from(index.row())
                    self.dataChanged.emit(self.index(index.row(), 0), self.index(index.row(), self.columnCount() - 1))
                    self.step_modified.emit(index.row())
                    return True

            elif col == self.COL_INPUT:
                step.input_source_id = int(value)
                self.engine.mark_dirty_from(index.row())
                self.dataChanged.emit(index, index)
                self.step_modified.emit(index.row())
                return True

        return False

    def refresh_display(self):
        """Emits data changed to update output signals, latencies, and status badges smoothly."""
        if len(self.engine.steps) > 0:
            top_left = self.index(0, self.COL_OUTPUT)
            bot_right = self.index(len(self.engine.steps) - 1, self.COL_STATUS)
            self.dataChanged.emit(top_left, bot_right)


class CategoryDelegate(QItemDelegate):
    """Dropdown editor for the Category column."""

    def createEditor(self, parent: QWidget, option: Any, index: QModelIndex) -> QWidget:
        combo = QComboBox(parent)
        combo.setStyleSheet("background-color: #16191D; color: #E0E6ED; border: 1px solid #00D2FF;")
        for cat in get_categories():
            combo.addItem(cat)
        return combo

    def setEditorData(self, editor: QWidget, index: QModelIndex):
        combo: QComboBox = editor
        current = index.model().data(index, Qt.ItemDataRole.DisplayRole)
        idx = combo.findText(current)
        if idx >= 0:
            combo.setCurrentIndex(idx)

    def setModelData(self, editor: QWidget, model: QAbstractTableModel, index: QModelIndex):
        combo: QComboBox = editor
        model.setData(index, combo.currentText(), Qt.ItemDataRole.EditRole)


class OperationDelegate(QItemDelegate):
    """Dropdown editor for the Operation column dynamically filtered by current Category."""

    def __init__(self, engine: PipelineEngine, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.engine = engine

    def createEditor(self, parent: QWidget, option: Any, index: QModelIndex) -> QWidget:
        combo = QComboBox(parent)
        combo.setStyleSheet("background-color: #16191D; color: #E0E6ED; border: 1px solid #00D2FF;")
        step = self.engine.steps[index.row()]
        ops = get_operations_in_category(step.category)
        for op in ops:
            combo.addItem(op)
        return combo

    def setEditorData(self, editor: QWidget, index: QModelIndex):
        combo: QComboBox = editor
        current = index.model().data(index, Qt.ItemDataRole.DisplayRole)
        idx = combo.findText(current)
        if idx >= 0:
            combo.setCurrentIndex(idx)

    def setModelData(self, editor: QWidget, model: QAbstractTableModel, index: QModelIndex):
        combo: QComboBox = editor
        model.setData(index, combo.currentText(), Qt.ItemDataRole.EditRole)


class InputSourceDelegate(QItemDelegate):
    """Dropdown editor allowing selection of any earlier pipeline step or raw frame."""

    def __init__(self, engine: PipelineEngine, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.engine = engine

    def createEditor(self, parent: QWidget, option: Any, index: QModelIndex) -> QWidget:
        combo = QComboBox(parent)
        combo.setStyleSheet("background-color: #16191D; color: #E0E6ED; border: 1px solid #00D2FF;")
        # Always allow Step 0 (Raw Image)
        combo.addItem("Step 0 (Raw Image)", 0)
        # Allow any earlier step
        current_row = index.row()
        for i in range(current_row):
            prior_step = self.engine.steps[i]
            combo.addItem(f"Step #{i + 1} ({prior_step.operation_name})", prior_step.step_id)
        return combo

    def setEditorData(self, editor: QWidget, index: QModelIndex):
        combo: QComboBox = editor
        step = self.engine.steps[index.row()]
        idx = combo.findData(step.input_source_id)
        if idx >= 0:
            combo.setCurrentIndex(idx)
        else:
            combo.setCurrentIndex(0)

    def setModelData(self, editor: QWidget, model: QAbstractTableModel, index: QModelIndex):
        combo: QComboBox = editor
        val = combo.currentData()
        model.setData(index, val, Qt.ItemDataRole.EditRole)


class PipelineTableView(QWidget):
    """Complete left-hand spreadsheet pane with action bar and context menus."""

    step_selected = pyqtSignal(object)  # PipelineStep or None
    show_in_viewport_a = pyqtSignal(int)  # step_id
    show_in_viewport_b = pyqtSignal(int)  # step_id
    step_remote_link_changed = pyqtSignal(int, bool)  # step_id, enabled
    step_output_config_changed = pyqtSignal(int, dict)  # step_id, output_config

    def __init__(self, engine: PipelineEngine, parent: Optional[QWidget] = None):
        super().__init__(parent)
        self.engine = engine
        self._init_ui()

    def _init_ui(self):
        layout = QVBoxLayout(self)
        layout.setContentsMargins(4, 4, 4, 4)
        layout.setSpacing(6)

        # Header Title
        title_box = QHBoxLayout()
        lbl_title = QLabel("Inspection Pipeline Spreadsheet")
        lbl_title.setStyleSheet("font-size: 10pt; font-weight: 800; color: #E0E6ED;")
        title_box.addWidget(lbl_title)
        title_box.addStretch()

        self.lbl_step_count = QLabel("0 Steps")
        self.lbl_step_count.setStyleSheet("color: #00D2FF; font-weight: 700; font-size: 8.5pt;")
        title_box.addWidget(self.lbl_step_count)
        layout.addLayout(title_box)

        # QTableView
        self.table = QTableView()
        self.model = PipelineTableModel(self.engine, self)
        self.table.setModel(self.model)

        # Visual settings
        self.table.setAlternatingRowColors(True)
        self.table.setSelectionBehavior(QTableView.SelectionBehavior.SelectRows)
        self.table.setSelectionMode(QTableView.SelectionMode.SingleSelection)
        self.table.verticalHeader().setVisible(False)
        self.table.setShowGrid(True)
        self.table.setStyleSheet("""
            QTableView {
                background-color: #16191D;
                alternate-background-color: #1A1F26;
                color: #E0E6ED;
                gridline-color: #2B323D;
                border: 1px solid #2B323D;
                border-radius: 6px;
                selection-background-color: rgba(0, 210, 255, 0.22);
                selection-color: #00D2FF;
            }
            QHeaderView::section {
                background-color: #1F242D;
                color: #8C9BAE;
                font-weight: 700;
                font-size: 8.5pt;
                padding: 6px;
                border: 1px solid #2B323D;
            }
            QHeaderView::section:hover {
                background-color: #242A35;
                color: #00D2FF;
            }
        """)

        # Set Column Delegates
        self.table.setItemDelegateForColumn(PipelineTableModel.COL_CATEGORY, CategoryDelegate(self))
        self.table.setItemDelegateForColumn(PipelineTableModel.COL_OPERATION, OperationDelegate(self.engine, self))
        self.table.setItemDelegateForColumn(PipelineTableModel.COL_INPUT, InputSourceDelegate(self.engine, self))

        # Column widths & anti-glitch interactive resizing
        header = self.table.horizontalHeader()
        header.setSectionResizeMode(QHeaderView.ResizeMode.Interactive)
        header.setMinimumSectionSize(35)
        header.setCascadingSectionResizes(False)
        header.setHighlightSections(False)
        header.setStretchLastSection(False)
        self.table.setHorizontalScrollBarPolicy(Qt.ScrollBarPolicy.ScrollBarAsNeeded)
        self.table.setVerticalScrollBarPolicy(Qt.ScrollBarPolicy.ScrollBarAsNeeded)

        self.table.setColumnWidth(PipelineTableModel.COL_STEP, 80)
        self.table.setColumnWidth(PipelineTableModel.COL_ACTIVE, 45)
        self.table.setColumnWidth(PipelineTableModel.COL_CATEGORY, 140)
        self.table.setColumnWidth(PipelineTableModel.COL_OPERATION, 150)
        self.table.setColumnWidth(PipelineTableModel.COL_INPUT, 130)
        self.table.setColumnWidth(PipelineTableModel.COL_OUTPUT, 190)
        self.table.setColumnWidth(PipelineTableModel.COL_LATENCY, 65)
        self.table.setColumnWidth(PipelineTableModel.COL_STATUS, 75)

        self.table.clicked.connect(self._on_row_clicked)
        self.table.doubleClicked.connect(self._on_table_double_clicked)
        self.table.setContextMenuPolicy(Qt.ContextMenuPolicy.CustomContextMenu)
        self.table.customContextMenuRequested.connect(self._show_context_menu)

        layout.addWidget(self.table, 1)

        # Bottom Action Bar
        action_bar = QHBoxLayout()
        action_bar.setSpacing(6)

        self.btn_add = QPushButton("+ Add Step")
        self.btn_add.setStyleSheet(self._btn_style("#00E676", "#0B0D13"))
        self.btn_add.clicked.connect(self._on_add_step)
        action_bar.addWidget(self.btn_add)

        self.btn_delete = QPushButton("- Delete")
        self.btn_delete.setStyleSheet(self._btn_style("#FF3D71", "#FFFFFF"))
        self.btn_delete.clicked.connect(self._on_delete_step)
        action_bar.addWidget(self.btn_delete)

        self.btn_up = QPushButton("▲ Up")
        self.btn_up.setStyleSheet(self._btn_style("#242A35", "#B0BAC9"))
        self.btn_up.clicked.connect(self._on_move_up)
        action_bar.addWidget(self.btn_up)

        self.btn_down = QPushButton("▼ Down")
        self.btn_down.setStyleSheet(self._btn_style("#242A35", "#B0BAC9"))
        self.btn_down.clicked.connect(self._on_move_down)
        action_bar.addWidget(self.btn_down)

        action_bar.addStretch()

        self.btn_save = QPushButton("💾 Save Recipe")
        self.btn_save.setStyleSheet(self._btn_style("#242A35", "#00D2FF"))
        self.btn_save.clicked.connect(self._on_save_recipe)
        action_bar.addWidget(self.btn_save)

        self.btn_load = QPushButton("📂 Load Recipe")
        self.btn_load.setStyleSheet(self._btn_style("#242A35", "#00D2FF"))
        self.btn_load.clicked.connect(self._on_load_recipe)
        action_bar.addWidget(self.btn_load)

        layout.addLayout(action_bar)

    @staticmethod
    def _btn_style(bg: str, fg: str) -> str:
        return f"""
            QPushButton {{
                background-color: {bg};
                color: {fg};
                font-weight: 700;
                font-size: 8.5pt;
                padding: 5px 12px;
                border: 1px solid #363E4E;
                border-radius: 4px;
            }}
            QPushButton:hover {{
                opacity: 0.9;
                border-color: #00D2FF;
            }}
        """

    def refresh(self):
        """Refreshes the spreadsheet table views and latency/status indicators without full reset."""
        if self.model.rowCount() > 0:
            top_left = self.model.index(0, 0)
            bottom_right = self.model.index(self.model.rowCount() - 1, self.model.columnCount() - 1)
            self.model.dataChanged.emit(top_left, bottom_right)
            self.lbl_step_count.setText(f"{len(self.engine.steps)} Steps")

    def _on_row_clicked(self, index: QModelIndex):
        if index.isValid() and 0 <= index.row() < len(self.engine.steps):
            step = self.engine.steps[index.row()]
            self.step_selected.emit(step)
            # Default single-view displays highlighted row output
            self.show_in_viewport_a.emit(step.step_id)
            if index.column() == PipelineTableModel.COL_OUTPUT:
                self._open_output_config_dialog(step)

    def _on_table_double_clicked(self, index: QModelIndex):
        if index.isValid() and 0 <= index.row() < len(self.engine.steps):
            step = self.engine.steps[index.row()]
            if index.column() == PipelineTableModel.COL_OUTPUT:
                self._open_output_config_dialog(step)

    def _open_output_config_dialog(self, step: PipelineStep):
        from ui.output_signal_dialog import OutputSignalConfigDialog
        dlg = OutputSignalConfigDialog(step, parent=self)
        if dlg.exec():
            row = self.engine.get_step_index(step.step_id)
            if row >= 0:
                top_left = self.model.index(row, PipelineTableModel.COL_OUTPUT)
                bot_right = self.model.index(row, PipelineTableModel.COL_STATUS)
                self.model.dataChanged.emit(top_left, bot_right)
                self.model.step_modified.emit(row)
            self.step_output_config_changed.emit(step.step_id, step.output_config)
            self.step_remote_link_changed.emit(step.step_id, step.link_to_remote)

    def _show_context_menu(self, pos):
        index = self.table.indexAt(pos)
        menu = QMenu(self)
        menu.setStyleSheet("""
            QMenu {
                background-color: #1F242D;
                color: #E0E6ED;
                border: 1px solid #2B323D;
                padding: 4px;
            }
            QMenu::item:selected {
                background-color: #00D2FF;
                color: #0B0D13;
                font-weight: 700;
            }
        """)

        if index.isValid() and 0 <= index.row() < len(self.engine.steps):
            step = self.engine.steps[index.row()]

            act_a = menu.addAction(f"Show in Viewport A (Step #{index.row()+1})")
            act_a.triggered.connect(lambda: self.show_in_viewport_a.emit(step.step_id))

            act_b = menu.addAction(f"Show in Viewport B (Step #{index.row()+1})")
            act_b.triggered.connect(lambda: self.show_in_viewport_b.emit(step.step_id))

            menu.addSeparator()

            act_out_cfg = menu.addAction("⚙ Configure Remote Output Signal...")
            act_out_cfg.triggered.connect(lambda _, s=step: self._open_output_config_dialog(s))

            act_link = menu.addAction("🔗 Link Output to Remote Device (PLC / Ethernet / RPi)")
            act_link.setCheckable(True)
            act_link.setChecked(getattr(step, "link_to_remote", False))
            act_link.triggered.connect(lambda _, s=step: self._toggle_step_remote_link(s))

            menu.addSeparator()

            act_dup = menu.addAction("Duplicate Step")
            act_dup.triggered.connect(lambda: self._duplicate_step(index.row()))

            act_up = menu.addAction("Move Up (▲)")
            act_up.triggered.connect(self._on_move_up)

            act_down = menu.addAction("Move Down (▼)")
            act_down.triggered.connect(self._on_move_down)

            menu.addSeparator()

            act_del = menu.addAction("Delete Step (✖)")
            act_del.triggered.connect(self._on_delete_step)

        else:
            act_add = menu.addAction("+ Add New Step")
            act_add.triggered.connect(self._on_add_step)

        menu.exec(self.table.viewport().mapToGlobal(pos))

    def _on_add_step(self, cat: Optional[str] = None, op_name: Optional[str] = None, *args):
        # Handle PyQt clicked(bool) signal where first argument is a bool
        if isinstance(cat, bool):
            cat = None
        if not cat and len(args) >= 1:
            cat = str(args[0])
        if not op_name and len(args) >= 2:
            op_name = str(args[1])

        if cat and op_name:
            self.model.beginResetModel()
            new_step = self.engine.add_step(category=cat, operation_name=op_name)
            self.model.endResetModel()
            new_row = len(self.engine.steps) - 1
            self.table.selectRow(new_row)
            self.step_selected.emit(new_step)
            self.show_in_viewport_a.emit(new_step.step_id)
            self.lbl_step_count.setText(f"{len(self.engine.steps)} Steps")
            return

        dialog = AddStepDialog(self.engine, self)
        if dialog.exec() == QDialog.DialogCode.Accepted:
            selected_cat = dialog.selected_category
            selected_op = dialog.selected_operation
            step_name = dialog.step_name
            src_id = dialog.input_source_id

            if not selected_cat or not selected_op:
                return

            self.model.beginResetModel()
            new_step = self.engine.add_step(
                category=selected_cat,
                operation_name=selected_op,
                name=step_name,
                input_source_id=src_id,
                link_to_remote=getattr(dialog, "link_to_remote", False),
            )
            self.model.endResetModel()

            # Select new row
            new_row = len(self.engine.steps) - 1
            self.table.selectRow(new_row)
            self.step_selected.emit(new_step)
            self.show_in_viewport_a.emit(new_step.step_id)
            self.lbl_step_count.setText(f"{len(self.engine.steps)} Steps")

    def _on_delete_step(self):
        selected = self.table.selectionModel().selectedRows()
        if not selected:
            return
        row = selected[0].row()
        self.model.beginResetModel()
        self.engine.remove_step(row)
        self.model.endResetModel()

        if self.engine.steps:
            new_row = min(row, len(self.engine.steps) - 1)
            self.table.selectRow(new_row)
            self.step_selected.emit(self.engine.steps[new_row])
            self.show_in_viewport_a.emit(self.engine.steps[new_row].step_id)
        else:
            self.step_selected.emit(None)
            self.show_in_viewport_a.emit(0)

        self.lbl_step_count.setText(f"{len(self.engine.steps)} Steps")

    def _toggle_step_remote_link(self, step: PipelineStep):
        step.link_to_remote = not getattr(step, "link_to_remote", False)
        self.model.layoutChanged.emit()
        self.step_remote_link_changed.emit(step.step_id, step.link_to_remote)

    def _on_move_up(self):
        selected = self.table.selectionModel().selectedRows()
        if not selected or selected[0].row() == 0:
            return
        row = selected[0].row()
        self.model.beginResetModel()
        self.engine.move_step(row, row - 1)
        self.model.endResetModel()
        self.table.selectRow(row - 1)
        self.step_selected.emit(self.engine.steps[row - 1])

    def _on_move_down(self):
        selected = self.table.selectionModel().selectedRows()
        if not selected or selected[0].row() >= len(self.engine.steps) - 1:
            return
        row = selected[0].row()
        self.model.beginResetModel()
        self.engine.move_step(row, row + 1)
        self.model.endResetModel()
        self.table.selectRow(row + 1)
        self.step_selected.emit(self.engine.steps[row + 1])

    def _duplicate_step(self, row: int):
        if 0 <= row < len(self.engine.steps):
            orig = self.engine.steps[row]
            self.model.beginResetModel()
            new_step = self.engine.add_step(
                category=orig.category,
                operation_name=orig.operation_name,
                name=f"{orig.name} (Copy)",
                input_source_id=orig.input_source_id,
                params=orig.params.copy(),
            )
            self.model.endResetModel()
            new_idx = len(self.engine.steps) - 1
            self.table.selectRow(new_idx)
            self.step_selected.emit(new_step)
            self.lbl_step_count.setText(f"{len(self.engine.steps)} Steps")

    def _on_save_recipe(self):
        path, _ = QFileDialog.getSaveFileName(self, "Save Pipeline Recipe", "recipe.json", "JSON Recipe (*.json)")
        if path:
            try:
                self.engine.save_recipe(path)
                QMessageBox.information(self, "Recipe Saved", f"Recipe saved successfully to:\n{path}")
            except Exception as e:
                QMessageBox.critical(self, "Save Error", f"Failed to save recipe:\n{e}")

    def _on_load_recipe(self):
        path, _ = QFileDialog.getOpenFileName(self, "Load Pipeline Recipe", "", "JSON Recipe (*.json)")
        if path:
            try:
                self.model.beginResetModel()
                self.engine.load_recipe(path)
                self.model.endResetModel()
                self.lbl_step_count.setText(f"{len(self.engine.steps)} Steps")
                if self.engine.steps:
                    self.table.selectRow(0)
                    self.step_selected.emit(self.engine.steps[0])
                QMessageBox.information(self, "Recipe Loaded", f"Recipe loaded successfully with {len(self.engine.steps)} steps.")
            except Exception as e:
                QMessageBox.critical(self, "Load Error", f"Failed to load recipe:\n{e}")

    def refresh(self):
        self.model.refresh_display()
        self.lbl_step_count.setText(f"{len(self.engine.steps)} Steps")
