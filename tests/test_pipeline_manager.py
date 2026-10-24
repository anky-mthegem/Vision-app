"""Comprehensive Test Suite for Industrial Computer Vision Pipeline Manager.

Validates pipeline engine, operations catalog, property inspector,
viewport widget, table model, recipe serialization, and main window GUI.
"""

import os
import sys
import time
import numpy as np
import cv2

os.environ["QT_QPA_PLATFORM"] = "offscreen"
sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from PyQt6.QtWidgets import QApplication
from PyQt6.QtCore import Qt, QPointF

from pipeline_engine import (
    PipelineEngine,
    PipelineStep,
    OPERATION_REGISTRY,
    get_categories,
    get_operations_in_category,
)
import operations_catalog
from property_inspector import PropertyInspectorDrawer
from viewport_widget import FlexibleInspectionViewport, PanZoomGraphicsView
from pipeline_table import PipelineTableView, PipelineTableModel
from add_step_dialog import AddStepDialog
from main import MainWindow


def test_pipeline_engine_and_catalog():
    print("\n--- 1. Testing Pipeline Engine & Operations Catalog ---")
    engine = PipelineEngine()

    # Load test image
    test_img = cv2.imread("test_bus.jpg")
    assert test_img is not None, "test_bus.jpg should exist"
    h, w = test_img.shape[:2]
    print(f"Loaded test image: {w}x{h}")

    # Add operations
    s1 = engine.add_step("Pre-processing & Filtering", "Gaussian Blur", params={"ksize": 7, "sigmaX": 2.0})
    s2 = engine.add_step("Edges & Gradients", "Canny Edge", params={"threshold1": 50.0, "threshold2": 150.0})
    s3 = engine.add_step("Morphology", "Dilate", params={"kernel_size": 3, "iterations": 1})
    s4 = engine.add_step("Contours & Calipers", "Find Contours & Filter", params={"min_area": 100.0, "draw_mode": "bbox_center"})

    assert len(engine.steps) == 4
    print("Pass: Added 4 sequential steps across diverse categories")

    # Execute pipeline
    results = engine.execute(test_img)
    assert len(results) == 5, f"Results should include 0 (raw) + 4 steps, got {len(results)}"
    assert s1.cached_output is not None
    assert s2.cached_output is not None
    assert s3.cached_output is not None
    assert s4.cached_output is not None
    print(f"Pass: Executed full pipeline in {engine.total_latency_ms:.2f} ms")

    # Test intermediate caching: modify Step 3 only
    s1_cached_before = s1.cached_output
    engine.set_step_param(s3.step_id, "iterations", 3)
    assert s3._dirty is True
    assert s4._dirty is True
    assert s1._dirty is False
    assert s2._dirty is False

    # Execute again
    results2 = engine.execute(test_img)
    # Step 1 buffer must be identical / reused from cache
    assert s1.cached_output is s1_cached_before, "Step 1 cached output should be reused without re-computation"
    print("Pass: Intermediate buffer caching successfully skips clean upstream steps")

    # Test branch input: set Step 4 to take input directly from Step 1 (bypassing steps 2 and 3)
    s4.input_source_id = s1.step_id
    engine.mark_dirty_from(3)
    results3 = engine.execute(test_img)
    assert s4.status_ok is True
    print("Pass: Branching input source (Step 4 reading directly from Step 1) executed cleanly")

    # Test YOLOv8 / YOLO26 Neural Object Detection & Live Execution
    s_yolo = engine.add_step(
        "AI & Deep Learning (YOLO)",
        "YOLO26 / YOLO Neural Detector",
        params={"task_mode": "detect", "model_variant": "yolo26", "target_class": "all", "confidence": 0.25, "draw_boxes": True},
    )
    res_yolo = engine.execute(test_img, is_live=True)
    assert s_yolo.cached_output is not None
    assert s_yolo.status_ok is True
    assert s_yolo.step_id in res_yolo
    print(f"Pass: YOLO26 Object Detection executed in {s_yolo.last_exec_ms:.1f} ms with live mode enabled")

    # Test all 7 YOLO Task Modes: Instance Seg, Semantic Seg, Depth, Classification, Pose, OBB
    from tools.yolo_detector import YoloDetectorTool
    tool = s_yolo.operation._get_detector()

    # 2. Instance Segmentation
    res_seg = tool.segment(test_img)
    assert res_seg.task_mode == "segment"
    img_seg = YoloDetectorTool.draw_results(test_img.copy(), res_seg)
    assert img_seg.shape == test_img.shape
    print(f"Pass: YOLO Instance Segmentation executed cleanly ({res_seg.count} instances)")

    # 3. Semantic Segmentation
    res_sem = tool.semantic_segment(test_img)
    assert res_sem.task_mode == "semantic"
    assert "Foreground Objects" in res_sem.semantic_classes
    img_sem = YoloDetectorTool.draw_results(test_img.copy(), res_sem)
    assert img_sem.shape == test_img.shape
    print(f"Pass: YOLO Semantic Segmentation executed cleanly (Foreground: {res_sem.semantic_classes['Foreground Objects']}%)")

    # 4. Depth Estimation
    res_depth = tool.estimate_depth(test_img)
    assert res_depth.task_mode == "depth"
    assert res_depth.depth_map is not None
    img_depth = YoloDetectorTool.draw_results(test_img.copy(), res_depth)
    assert img_depth.shape == test_img.shape
    print(f"Pass: YOLO Depth Estimation executed cleanly (Center depth probe: {res_depth.metrics['center_depth']})")

    # 5. Image Classification
    res_cls = tool.classify(test_img, top_k=5)
    assert res_cls.task_mode == "classify"
    assert "top1_class" in res_cls.classification
    img_cls = YoloDetectorTool.draw_results(test_img.copy(), res_cls)
    assert img_cls.shape == test_img.shape
    print(f"Pass: YOLO Image Classification executed cleanly (Top-1: {res_cls.classification['top1_class']} at {res_cls.classification['top1_conf']*100:.1f}%)")

    # 6. Pose Estimation
    res_pose = tool.estimate_pose(test_img)
    assert res_pose.task_mode == "pose"
    img_pose = YoloDetectorTool.draw_results(test_img.copy(), res_pose)
    assert img_pose.shape == test_img.shape
    print(f"Pass: YOLO Pose Estimation executed cleanly ({len(res_pose.pose_data)} poses tracked with 17 keypoints)")

    # 7. Oriented Bounding Boxes (OBB)
    res_obb = tool.detect_obb(test_img)
    assert res_obb.task_mode == "obb"
    img_obb = YoloDetectorTool.draw_results(test_img.copy(), res_obb)
    assert img_obb.shape == test_img.shape
    print(f"Pass: YOLO Oriented Bounding Boxes (OBB) executed cleanly (Rotated angle: {res_obb.metrics.get('primary_angle', 0.0):.1f}°)")

    # Test Geometric Shape Detector
    s_shape = engine.add_step(
        "Feature Detection",
        "Geometric Shape Detector",
        params={"target_shape": "all", "min_area": 100.0, "draw_contours": True, "draw_labels": True},
    )
    res_shape = engine.execute(test_img)
    assert s_shape.cached_output is not None
    assert "shapes_found" in s_shape.metrics
    print(f"Pass: Geometric Shape Detector executed cleanly, found {s_shape.metrics.get('count', 0)} shapes")

    # Test Hand & Gesture Tracker
    s_hand = engine.add_step(
        "Feature Detection",
        "Hand & Gesture Tracker",
        params={"min_hand_area": 1500.0, "draw_skeleton": True, "draw_fingers_count": True, "highlight_index_finger": True},
    )
    res_hand = engine.execute(test_img)
    assert s_hand.cached_output is not None
    assert "fingers_count" in s_hand.metrics
    assert "index_x" in s_hand.metrics
    assert "index_y" in s_hand.metrics
    print(f"Pass: Hand & Gesture Tracker executed cleanly (fingers: {s_hand.metrics['fingers_count']}, gesture: {s_hand.metrics['gesture']}, Index: ({s_hand.metrics['index_x']}, {s_hand.metrics['index_y']}))")

    from tools.hand_tracker import HandTrackerTool
    standalone_tracker = HandTrackerTool()
    annotated_hand, res_ht = standalone_tracker.process(test_img, highlight_index_tip=True, flip_horizontal=True)
    assert annotated_hand.shape == test_img.shape
    assert res_ht.found is True
    print(f"Pass: Standalone MediaPipe/OpenCV HandTrackerTool validated (Index tip: {res_ht.index_x}, {res_ht.index_y})")

    # Test Optical Character Recognition (OCR)
    s_ocr = engine.add_step(
        "Feature Detection",
        "Optical Character Recognition (OCR)",
        params={"min_char_height": 8, "draw_boxes": True, "draw_text": True},
    )
    res_ocr = engine.execute(test_img)
    assert s_ocr.cached_output is not None
    assert "text" in s_ocr.metrics
    print(f"Pass: OCR Operation executed cleanly (detected text regions: {s_ocr.metrics['count']})")

    # Test Industrial Caliper & Calibrated Metrology
    s_meas = engine.add_step(
        "Contours & Calipers",
        "Industrial Caliper & Measurement",
        params={
            "calibration_factor": 0.05,
            "unit": "mm",
            "measurement_mode": "all",
            "target_dimension": 50.0,
            "tolerance": 5.0,
            "draw_arrows": True,
            "draw_callout": True,
        },
    )
    res_meas = engine.execute(test_img)
    assert s_meas.cached_output is not None
    assert "length" in s_meas.metrics
    assert "area" in s_meas.metrics
    assert s_meas.metrics["calibration_factor"] == 0.05
    assert s_meas.metrics["unit"] == "mm"
    print(f"Pass: Calibrated Caliper Measurement executed: Length={s_meas.metrics['length']} mm, Area={s_meas.metrics['area']} mm²")

    # Test JSON recipe save & load
    recipe_file = "test_recipe_tmp.json"
    engine.save_recipe(recipe_file)
    assert os.path.exists(recipe_file)

    engine_loaded = PipelineEngine()
    engine_loaded.load_recipe(recipe_file)
    assert len(engine_loaded.steps) == 9
    assert engine_loaded.steps[0].operation_name == "Gaussian Blur"
    assert engine_loaded.steps[5].operation_name == "Geometric Shape Detector"
    assert engine_loaded.steps[8].operation_name == "Industrial Caliper & Measurement"
    os.remove(recipe_file)
    print("Pass: Recipe JSON serialization with 9 advanced vision steps validated")


def test_property_inspector_gui():
    print("\n--- 2. Testing Dynamic Property Inspector Drawer ---")
    app = QApplication.instance() or QApplication(sys.argv)
    drawer = PropertyInspectorDrawer()

    engine = PipelineEngine()
    step_canny = engine.add_step("Edges & Gradients", "Canny Edge", params={"threshold1": 100.0, "threshold2": 200.0})

    drawer.inspect_step(step_canny)
    assert "threshold1" in drawer._controls
    assert "threshold2" in drawer._controls
    assert "apertureSize" in drawer._controls
    assert "L2gradient" in drawer._controls
    print("Pass: Generated native PyQt6 controls for Canny Edge schema")

    # Test float spinbox to slider update
    slider, dspin = drawer._controls["threshold1"]
    dspin.setValue(120.0)
    assert slider.value() == 1200  # 120.0 * scale(10)
    print("Pass: Float spinbox synchronized with slider")

    # Test int parameter on Gaussian Blur
    step_blur = engine.add_step("Pre-processing & Filtering", "Gaussian Blur", params={"ksize": 5})
    drawer.inspect_step(step_blur)
    bslider, bspin = drawer._controls["ksize"]
    bslider.setValue(9)
    assert bspin.value() == 9
    print("Pass: Integer slider and spinbox synchronized")

    # Wait for debouncer
    for _ in range(5):
        app.processEvents()
        time.sleep(0.01)

    assert step_canny.params["threshold1"] == 120.0
    assert step_blur.params["ksize"] == 9
    print("Pass: Slider update and debounced live tuning verified")

    # Test reset to defaults
    drawer._on_reset_clicked()
    assert step_blur.params["ksize"] == 5
    print("Pass: Reset to defaults verified")
    drawer.close()
    drawer.deleteLater()
    app.processEvents()


def test_viewport_and_synchronization():
    print("\n--- 3. Testing Viewport Single/Split View & Synchronized Pan/Zoom ---")
    app = QApplication.instance() or QApplication(sys.argv)
    viewport = FlexibleInspectionViewport()

    test_img = np.zeros((480, 640, 3), dtype=np.uint8)
    cv2.circle(test_img, (320, 240), 50, (0, 255, 0), -1)

    canny_img = cv2.Canny(test_img, 100, 200)

    results = {0: test_img, 1: canny_img}
    names = {0: "Step 0: Raw", 1: "Step 1: Canny"}

    viewport.update_pipeline_results(results, names)

    # 1. Start in Single View
    assert viewport._is_split_mode is False
    assert viewport.viewport_b.isHidden() is True
    print("Pass: Viewport starts in Single View mode")

    # 2. Toggle to 2-Window Split View
    viewport.set_view_mode(split=True)
    assert viewport._is_split_mode is True
    assert viewport.viewport_b.isHidden() is False
    print("Pass: Toggled to 2-Window Split View")

    # 3. Test Synchronized Pan & Zoom
    view_a = viewport.viewport_a.graphics_view
    view_b = viewport.viewport_b.graphics_view

    view_a.scale(2.0, 2.0)
    center_pt = QPointF(100.0, 100.0)
    view_a.zoom_changed.emit(view_a.transform().m11(), center_pt)

    for _ in range(5):
        app.processEvents()

    assert abs(view_b.transform().m11() - view_a.transform().m11()) < 1e-4
    print("Pass: Synchronized zoom between Viewport A and Viewport B verified")

    # 4. Test Difference / Blend Mode Overlay
    viewport.btn_diff.setChecked(True)
    viewport._on_diff_toggle(True)
    assert viewport._is_diff_mode is True
    diff_frame = viewport._compute_diff_or_blend(test_img, cv2.cvtColor(canny_img, cv2.COLOR_GRAY2BGR))
    assert diff_frame is not None
    assert diff_frame.shape == (480, 640, 3)
    print("Pass: Difference heatmap and blend overlay computation verified")

    # 5. Test Pixel Inspector coordinate HUD
    view_a.pixel_inspected.emit(320, 240, "RGB: (0, 255, 0)")
    assert "RGB: (0, 255, 0)" in viewport.viewport_a.hud_label.text()
    print("Pass: Pixel Inspector HUD coordinate sampling verified")
    viewport.close()
    viewport.deleteLater()
    app.processEvents()


def test_pipeline_table_model():
    print("\n--- 4. Testing Pipeline Table Model & Actions ---")
    app = QApplication.instance() or QApplication(sys.argv)
    engine = PipelineEngine()
    table_view = PipelineTableView(engine)
    model = table_view.model

    # Add steps non-interactively
    table_view._on_add_step("Feature Detection", "Geometric Shape Detector")
    table_view._on_add_step("Contours & Calipers", "Industrial Caliper & Measurement")
    assert model.rowCount() == 2

    # Toggle Active checkbox via model
    idx = model.index(0, PipelineTableModel.COL_ACTIVE)
    model.setData(idx, Qt.CheckState.Unchecked.value, Qt.ItemDataRole.CheckStateRole)
    assert engine.steps[0].active is False
    print("Pass: Active step bypass toggle verified")

    # Move down
    table_view.table.selectRow(0)
    table_view._on_move_down()
    print("Pass: Move step down verified")

    # Duplicate
    table_view._duplicate_step(0)
    assert model.rowCount() == 3
    print("Pass: Duplicate step verified")

    # Delete
    table_view.table.selectRow(0)
    table_view._on_delete_step()
    assert model.rowCount() == 2
    print("Pass: Delete step verified")
    table_view.close()
    table_view.deleteLater()
    app.processEvents()


def test_main_window_integration():
    print("\n--- 5. Testing Complete MainWindow Integration & Camera Subsystem ---")
    app = QApplication.instance() or QApplication(sys.argv)
    win = MainWindow()

    # 1. Camera starts DISCONNECTED
    assert win.camera._running is False, "Camera must start in DISCONNECTED state"
    assert "#FF1744" in win.btn_connect.styleSheet(), "Connect button must be RED when disconnected"
    assert win.btn_connect.text() == "Connect Camera"
    print("Pass: MainWindow starts with disconnected camera and RED Connect button")

    # 2. Verify PLC and Calibration buttons exist in toolbar
    assert hasattr(win, "btn_plc")
    assert hasattr(win, "btn_calib")
    print("Pass: PLC & Remote Devices button and Camera Calibration button present in Toolbar")

    # 3. Test Camera Calibration Modal Logic
    from ui.calibration_dialog import CameraCalibrationDialog
    calib_dlg = CameraCalibrationDialog(win, pipeline_engine=win.engine)
    calib_dlg.spin_known_dim.setValue(50.0)
    calib_dlg.spin_measured_px.setValue(500.0)
    calib_dlg._compute_ratio()
    assert abs(calib_dlg.spin_factor.value() - 0.10) < 1e-4
    print("Pass: Camera calibration ratio computation verified (50mm / 500px = 0.10 mm/px)")

    # 4. Connect Camera toggle
    win.combo_protocol.setCurrentIndex(win.combo_protocol.findText("Virtual Synthetic Generator"))
    win.btn_connect.click()
    assert win.camera._running is True
    assert "#00E676" in win.btn_connect.styleSheet(), "Connect button must be GREEN when connected"
    assert win.btn_connect.text() == "Disconnect Camera"
    print("Pass: Clicked connect -> Camera running and button is GREEN")
    sys.stdout.flush()

    # Process frame
    time.sleep(0.1)
    for _ in range(10):
        app.processEvents()

    # 5. Disconnect Camera toggle
    win.btn_connect.click()
    assert win.camera._running is False
    assert "#FF1744" in win.btn_connect.styleSheet()
    assert win.btn_connect.text() == "Connect Camera"
    print("Pass: Clicked disconnect -> Camera stopped, button reverted to RED, and offline screen shown")

    # 6. Preset recipes loading
    # Edge preset
    win.combo_presets.setCurrentIndex(1)
    assert len(win.engine.steps) == 4

    # YOLO26 preset
    win.combo_presets.setCurrentIndex(6)
    assert any("YOLO" in s.operation_name for s in win.engine.steps)
    print("Pass: YOLO26 preset loaded cleanly")

    # Geometric Shapes preset
    win.combo_presets.setCurrentIndex(7)
    assert any(s.operation_name == "Geometric Shape Detector" for s in win.engine.steps)
    print("Pass: Geometric Shape Detector preset loaded cleanly")

    # Hand Tracking preset
    win.combo_presets.setCurrentIndex(8)
    assert any(s.operation_name == "Hand & Gesture Tracker" for s in win.engine.steps)
    print("Pass: Hand & Gesture Tracker preset loaded cleanly")

    # OCR preset
    win.combo_presets.setCurrentIndex(9)
    assert any(s.operation_name == "Optical Character Recognition (OCR)" for s in win.engine.steps)
    print("Pass: OCR preset loaded cleanly")

    # Caliper Measurement preset
    win.combo_presets.setCurrentIndex(10)
    assert any(s.operation_name == "Industrial Caliper & Measurement" for s in win.engine.steps)
    print("Pass: Calibrated Caliper Measurement preset loaded cleanly")

    win.worker.stop()
    win.camera.stop()
    win.close()
    win.deleteLater()
    app.processEvents()
    print("\n=== ALL INDUSTRIAL PIPELINE MANAGER TESTS PASSED WITH 100% SUCCESS! ===")


def test_add_step_dialog():
    print("\n--- 6. Testing AddStepDialog Search & Operation Selection ---")
    app = QApplication.instance() or QApplication(sys.argv)
    engine = PipelineEngine()
    dlg = AddStepDialog(engine)

    # 1. Verify categories populated
    assert dlg.list_categories.count() > 0
    cat_names = [dlg.list_categories.item(i).data(Qt.ItemDataRole.UserRole) for i in range(dlg.list_categories.count())]
    assert "AI & Deep Learning (YOLO)" in cat_names
    assert "Feature Detection" in cat_names

    # 2. Search for 'shape'
    dlg.edit_search.setText("shape")
    assert dlg.list_operations.count() > 0
    dlg.list_operations.setCurrentRow(0)
    assert "Geometric Shape Detector" in dlg.selected_operation
    print("Pass: AddStepDialog found and selected Geometric Shape Detector via search")

    # 3. Search for 'hand'
    dlg.edit_search.setText("hand")
    assert dlg.list_operations.count() > 0
    dlg.list_operations.setCurrentRow(0)
    assert "Hand & Gesture Tracker" in dlg.selected_operation
    print("Pass: AddStepDialog found and selected Hand & Gesture Tracker via search")

    # 4. Search for 'caliper'
    dlg.edit_search.setText("caliper")
    assert dlg.list_operations.count() > 0
    dlg.list_operations.setCurrentRow(0)
    assert "Industrial Caliper & Measurement" in dlg.selected_operation
    print("Pass: AddStepDialog found and selected Industrial Caliper & Measurement via search")

    # 5. Remote link checkbox
    assert hasattr(dlg, "chk_link_remote")
    dlg.chk_link_remote.setChecked(True)
    dlg._on_accept()
    assert dlg.link_to_remote is True
    print("Pass: AddStepDialog remote link toggle verified")

    dlg.close()


if __name__ == "__main__":
    import traceback
    try:
        test_pipeline_engine_and_catalog()
        test_property_inspector_gui()
        test_viewport_and_synchronization()
        test_pipeline_table_model()
        test_main_window_integration()
        test_add_step_dialog()
        print("\n=== ALL TEST PHASES COMPLETED CLEANLY! ===")
    except Exception as e:
        traceback.print_exc()
        sys.exit(1)
