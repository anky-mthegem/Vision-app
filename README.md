# VisionStudio — In-Sight Compatible Machine Vision System

**VisionStudio** is an open industrial computer vision application suite reverse-engineered from the **Cognex In-Sight Vision Suite** architecture. It implements multi-protocol camera acquisition, the iconic In-Sight spreadsheet Directed Acyclic Graph (DAG) execution model, classical and geometric inspection tools, authentic Native Mode communication, and an interactive WebHMI.

---

## 1. Core Architectural Pillars

### 1.1 Multi-Protocol Camera Subsystem (`camera/`)
Connects to virtually any camera hardware across industrial, security, and consumer interfaces:
- **USB / DirectShow**: Webcams, USB3 industrial cameras (indices `0`, `1`, `2`, ...).
- **Ethernet / RTSP Stream**: Security cameras, IP cameras, ONVIF / H.264 streams (`rtsp://user:pass@ip:554/stream`).
- **HTTP / MJPEG**: Network snapshot cameras (`http://ip/snapshot.jpg`).
- **GenICam / Industrial Emulation**: GigE Vision emulator supporting software trigger (`SW`), hardware strobe, exposure, and gain.
- **Synthetic Industrial Part Generator**: Generates moving PCBs, fiducials, IC chips, drilled holes, and simulated defects for testing without hardware.
- **CogNamer Protocol (`camera/cognamer.py`)**: UDP discovery protocol implementing the reverse-engineered `MANC` packet wire format on port `1069`.

### 1.2 In-Sight Spreadsheet DAG Engine (`engine/`)
Inspection logic is evaluated via a cell dependency graph (`A0`, `B2`, `C3`, `D4`, etc.):
- **Clean Standby Startup**: On launch, the application operates purely in camera streaming standby mode (`A0 = AcquireImage()`). No inspection tools run automatically until explicitly added or enabled by the user.
- **`=YoloDetect(A0, class="all", conf=0.40)`**: Industrial deep learning object detector (YOLOv8 Nano ONNX). Detects 80 COCO categories with user-selectable target class(es) and confidence threshold.
- **`=PatMax(A0)`**: Geometric contour & gradient vector pattern matching with full rotation and scale tolerance.
- **`=FindBlobs(A0)`**: Morphological blob analysis, connected components, circularity, and perimeter metrics.
- **`=FindLine(A0)`**: Subpixel caliper rake edge detection and robust line fitting.
- **`=FindCircle(A0)`**: Radial caliper rays for hole/pin diameter and center measurement.
- **`=ReadIDMax(A0)`**: 1D and 2D barcode / QR code reader.
- **`=ReadOcrMax(A0)`**: Industrial OCR with regex fielding.
- **`=DetectFlaw(A0)`**: Surface anomaly detection against golden templates.
- **Formula Evaluator**: Supports geometry functions (`Distance`, `Angle`, `MidPoint`), conditional logic (`=If(...)`), and standard math.

### 1.3 Lightweight & High-Speed Architecture
- **Non-blocking Asynchronous Pipeline**: Video streaming and inspection are completely decoupled. The UI viewport runs at a silky smooth 30-60 FPS without dropping frames or freezing during neural network or vision tool evaluation.
- **ONNX Runtime Session Caching**: The 12.7 MB YOLO model is loaded once into memory, sharing session state across cells and keeping weights hot in CPU L3 cache.
- **Vectorized Inference & Native C++ NMS**: Post-processing utilizes vectorized matrix operations and OpenCV C++ Non-Maximum Suppression (`cv2.dnn.NMSBoxes`) for minimal latency (~35ms CPU cycle).
- **Throttled GUI Updates**: Spreadsheet table redraws are throttled to conserve UI thread cycles.

### 1.3 Communication & PLC Integration (`comms/`)
- **Native Mode Telnet Server (TCP Port 1023 / 23)**:
  - `GV <cell>`: Read cell result (e.g. `GV E5`, `GV B2.Score`).
  - `SW`: Software trigger image capture.
  - `SE 8`: Event trigger.
  - `SO <0|1>` / `GO`: Set / Get Online status.
  - `RB` / `RT`: Read inspection result buffer and cycle time.
- **CogSocket WebSockets**: Real-time JSON-RPC telemetry.

### 1.4 Industrial PLC & Hardware Communications Subsystem
Full, production-grade bi-directional communication with factory automation controllers:
1. **Siemens S7 PLC (`comms/siemens_s7.py`)**:
   - Supports Siemens S7-300, S7-400, S7-1200, and S7-1500 via ISO-on-TCP (TCP port 102).
   - High-speed 16-byte DB batch writes: Pass/Fail bit, Part Count (int16), Centroid X (real32), Centroid Y (real32), Rotation Angle (real32).
   - Formula: `=WriteSiemens(E5, ip="192.168.1.10", db=1, byte=0)`.
2. **Delta PLC by Ethernet (`comms/modbus_driver.py`)**:
   - Native Modbus TCP driver for Delta DVP, AS, and AH series controllers (port 502).
   - Automatic Delta register mapping: D-Registers (`D0` -> `0x1000`), M-Coils (`M0` -> `0x0800`).
   - Supports discrete Pass/Fail coils, 16-bit integer registers, and 32-bit IEEE 754 floats.
   - Formula: `=WriteModbus(E5, ip="192.168.1.50", reg=100)`.
3. **Beckhoff TwinCAT PLC (`comms/beckhoff_ads.py`)**:
   - Native binary TwinCAT ADS client operating over TCP port 48898 (ADS router).
   - Writes directly to TwinCAT PLC %M memory area (`IndexGroup 0x4020`) or Modbus port 502.
   - Formula: `=WriteBeckhoff(E5, ip="192.168.1.20", offset=100)`.
4. **Generic Industrial Ethernet Devices (`comms/ethernet_device.py`)**:
   - TCP Client / Server & UDP Unicast / Broadcast for robots (ABB, KUKA, Fanuc, Universal Robots) and MES systems.
   - Selectable payload formatting: JSON, CSV, and Cognex In-Sight Native ASCII.
   - Remote trigger support: send `TRIGGER` over TCP to fire camera acquisition.
   - Formula: `=WriteEthernet(E5, ip="192.168.1.100", port=9000, fmt="JSON")`.
5. **Raspberry Pi GPIO (`comms/rpi_gpio.py`)**:
   - Dual-mode architecture: Remote **Pigpio Network Protocol** (TCP port 8888) to control physical pins on ANY Raspberry Pi over WiFi/Ethernet from Windows/Linux, or local memory-mapped `RPi.GPIO`.
   - Dedicated signals: PASS (GPIO 17), FAIL (GPIO 27), READY (GPIO 22), camera STROBE (GPIO 23), and opto-isolated hardware TRIGGER (GPIO 4).
   - Formula: `=WriteGPIO(E5, pass_pin=17, fail_pin=27, host="192.168.1.200")`.
6. **Central Industrial I/O Coordinator (`comms/io_manager.py`)**:
   - Unified background thread dispatch (`dispatch_results_async`) preventing any network jitter or PLC latency from impacting camera frame rates.
   - Persistent settings stored in `config_industrial_io.json`.
   - Accessible via the **`📡 PLC & Devices`** toolbar dialog with one-click live hardware test buttons.

### 1.5 Dual Interface: Desktop UI + WebHMI
- **Desktop UI (PyQt6)**: Real-time graphical viewport with visual inspection overlays (green PASS / red FAIL boxes, crosshairs, caliper rays, YOLO bounding boxes), live spreadsheet table with formula bar, tool palette, PLC configuration dialog, and KPI statistics banner.
- **WebHMI (FastAPI + WebSockets)**: Accessible in any web browser at `http://localhost:8080` for remote shop-floor monitoring.

---

## 2. Quick Start

### Starting the Application
Double click `Launch_VisionStudio.bat` or run:
```powershell
python main.py
```

### Starting in Headless Mode (Server & WebHMI only)
```powershell
python main.py --headless --port 8080 --native-port 1023
```

### Testing Native Mode Communication
Connect via Telnet or Python:
```python
import socket

s = socket.socket()
s.connect(('127.0.0.1', 1023))
print(s.recv(1024).decode())  # Welcome banner
s.sendall(b'GV E5\r\n')       # Query decision cell
print(s.recv(1024).decode())  # 1\r\nPASS
s.close()
```
