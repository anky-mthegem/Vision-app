"""VisionStudio - In-Sight Computer Vision System.

Combines multi-protocol camera acquisition (USB, RTSP, HTTP, GigE Vision simulation),
geometric PatMax pattern matching, caliper edge tools, blob analysis, barcode/QR ID,
an authentic In-Sight spreadsheet DAG dependency engine, and Native Mode TCP server.
"""

import sys
import argparse
import logging

logging.basicConfig(
    level=logging.INFO,
    format="%(asctime)s [%(levelname)s] %(name)s: %(message)s",
)


def main():
    parser = argparse.ArgumentParser(description="VisionStudio - In-Sight Computer Vision System")
    parser.add_argument("--headless", action="store_true", help="Run without GUI (headless WebHMI and Native Mode only)")
    parser.add_argument("--port", type=int, default=8080, help="WebHMI port (default: 8080)")
    parser.add_argument("--native-port", type=int, default=1023, help="In-Sight Native Mode TCP port (default: 1023)")
    args = parser.parse_args()

    if args.headless:
        from camera.camera_manager import CameraDevice, CameraConfig, CameraProtocol
        from engine.spreadsheet import InspectionJob
        from comms.native_mode import NativeModeServer
        from web.server import WebHmiServer
        import time

        job = InspectionJob("HeadlessInSight")
        job.add_cell("A0", "=AcquireImage()", "Camera Image")
        job.add_cell("B2", "=PatMax(A0)", "IC Alignment")
        job.add_cell("C3", "=FindBlobs(A0)", "Hole Inspection")
        job.add_cell("D4", "=Distance(B2.X, B2.Y, 640.0, 360.0)", "Position Offset")
        job.add_cell("E5", '=If(B2.Score >= 60.0 and D4 < 80.0, "PASS", "FAIL")', "Decision")
        job.compile()

        camera = CameraDevice(CameraConfig(protocol=CameraProtocol.TEST_STREAM))
        camera.start()

        native = NativeModeServer(lambda: job, camera.trigger, port=args.native_port)
        native.start()

        web = WebHmiServer(camera.get_latest_frame, lambda: job, camera.trigger, port=args.port)
        web.start()

        print(f"VisionStudio running in HEADLESS mode.")
        print(f"WebHMI: http://localhost:{args.port}")
        print(f"Native Mode Telnet Server: port {args.native_port}")
        print("Press Ctrl+C to stop.")

        try:
            while True:
                frame = camera.get_latest_frame()
                if frame is not None:
                    job.execute(frame)
                time.sleep(0.033)
        except KeyboardInterrupt:
            camera.stop()
            native.stop()
    else:
        from ui.main_window import run_app
        run_app()


if __name__ == "__main__":
    main()
