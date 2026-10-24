import sys
import os
os.environ["QT_QPA_PLATFORM"] = "offscreen"
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), "..")))
from PyQt6.QtWidgets import QApplication
from ui.main_window import MainWindow

def test_camera_connect_behavior():
    app = QApplication.instance() or QApplication(sys.argv)
    win = MainWindow()

    # 1. Verify camera is not running at start
    assert win.camera._running is False, "Camera should not be running at start"
    print("Pass: Camera is not running at start")

    # 2. Verify connect button is red at start
    style = win.btn_connect.styleSheet()
    assert "#ff1744" in style, f"Connect button should be red (#ff1744) when disconnected, got: {style}"
    assert win.btn_connect.text() == "Connect Camera"
    print("Pass: Connect button is Red and labeled 'Connect Camera'")

    # 3. Verify timer tick with disconnected camera maintains red state and not connected status
    win._on_timer_tick()
    assert win.lbl_overall.text() == "NOT CONNECTED"
    assert "#ff1744" in win.btn_connect.styleSheet()
    print("Pass: Timer tick on disconnected camera maintains NOT CONNECTED and Red button")

    # 4. Toggle connect with synthetic stream
    from camera.camera_manager import CameraProtocol
    import time
    idx = win.protocol_combo.findText(CameraProtocol.TEST_STREAM.value)
    win.protocol_combo.setCurrentIndex(idx)
    win.btn_connect.click()
    assert win.camera._running is True, "Camera should be running after connect"
    print("Pass: Clicked connect, camera is now running")

    # Give generator thread a moment to produce first frame
    time.sleep(0.1)

    # 5. Timer tick with active frame updates button to green
    win._on_timer_tick()
    assert "#00e676" in win.btn_connect.styleSheet(), f"Connect button should be green (#00e676) when connected, got: {win.btn_connect.styleSheet()}"
    assert win.btn_connect.text() == "Disconnect Camera"
    print("Pass: Connect button turned Green and labeled 'Disconnect Camera'")

    # 6. Click to disconnect
    win.btn_connect.click()
    assert win.camera._running is False, "Camera should not be running after disconnect"
    assert win.camera.get_latest_frame() is None, "get_latest_frame() must return None when disconnected"
    assert win.camera._latest_frame is None, "_latest_frame must be None when disconnected"
    assert "#ff1744" in win.btn_connect.styleSheet(), "Button must be red after disconnect"
    assert win.btn_connect.text() == "Connect Camera"
    assert win.lbl_overall.text() == "NOT CONNECTED"
    print("Pass: Clicked disconnect, camera stopped, frame cleared, and button turned Red")

    # 7. Verify subsequent timer ticks stay in NOT CONNECTED state and never get stuck on old frame
    for tick in range(10):
        win._on_timer_tick()
        assert win.lbl_overall.text() == "NOT CONNECTED", f"Tick {tick}: Status must remain NOT CONNECTED"
        assert "#ff1744" in win.btn_connect.styleSheet(), f"Tick {tick}: Button must remain Red"
        assert win.btn_connect.text() == "Connect Camera", f"Tick {tick}: Button text must remain Connect Camera"
    print("Pass: Subsequent timer ticks continuously maintain NOT CONNECTED state and Red button")

    win.close()
    print("ALL TESTS PASSED SUCCESSFULLY!")

if __name__ == "__main__":
    try:
        test_camera_connect_behavior()
    except Exception as e:
        import traceback
        with open("test_err.txt", "w", encoding="utf-8") as f:
            f.write(traceback.format_exc())
        raise
