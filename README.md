# VisionStudio — Industrial Machine Vision & Automation Platform

[![Python Version](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.14-00D2FF?style=flat-square&logo=python&logoColor=white)](https://python.org)
[![PyQt6 GUI](https://img.shields.io/badge/GUI-PyQt6%20Industrial%20Suite-00E676?style=flat-square&logo=qt&logoColor=white)](https://riverbankcomputing.com/software/pyqt/)
[![OpenCV Metrology](https://img.shields.io/badge/Vision-OpenCV%204.8%2B-FF6F00?style=flat-square&logo=opencv&logoColor=white)](https://opencv.org)
[![YOLO Inference](https://img.shields.io/badge/AI%20Inference-YOLO%20%2F%20ONNX%20Runtime-7C4DFF?style=flat-square)](https://onnxruntime.ai)
[![Industrial Fieldbus](https://img.shields.io/badge/Fieldbus-Modbus%20%7C%20S7%20%7C%20ADS%20%7C%20GPIO-00B0FF?style=flat-square)](file:///comms/)
[![WebHMI](https://img.shields.io/badge/WebHMI-FastAPI%20%2B%20WebSockets-FF4081?style=flat-square&logo=fastapi&logoColor=white)](http://localhost:8080)
[![License: MIT](https://img.shields.io/badge/License-MIT-E0E0E0?style=flat-square)](LICENSE)

**VisionStudio** is an open, high-performance industrial machine vision and automation platform engineered for factory automation, dimensional metrology, defect inspection, robotic guidance, and edge AI vision. Built from the ground up for industrial reliability and 60 FPS deterministic throughput, VisionStudio combines a Directed Acyclic Graph (DAG) spreadsheet pipeline engine, multi-protocol camera acquisition, classical and deep learning vision tools, multi-fieldbus PLC connectivity, interactive on-canvas ROI manipulation, and a real-time WebHMI.

---

## Key System Architecture

```
┌────────────────────────────────────────────────────────────────────────────────────────┐
│                                 VISIONSTUDIO PLATFORM                                  │
├──────────────────────────┬─────────────────────────────┬───────────────────────────────┤
│    CAMERA SUBSYSTEM      │    PIPELINE & DAG ENGINE    │    INDUSTRIAL FIELDBUS I/O    │
│  • USB3 / DirectShow     │  • Sequential & Branching   │  • Delta PLC (Modbus TCP)     │
│  • RTSP H.264 / IP Cam   │  • Intermediate Buffering   │  • Siemens S7 (ISO-on-TCP)    │
│  • HTTP / MJPEG Feed     │  • Output / Signal Column   │  • Beckhoff TwinCAT ADS       │
│  • GenICam GigE Emulator │  • 9 Universal Signal Modes │  • Industrial Ethernet TCP/UDP│
│  • Synthetic PCB Stream  │  • Calibrated Metrology     │  • Raspberry Pi GPIO (Pigpio) │
│  • UDP Subnet Discovery  │  • YOLO Deep Learning AI    │  • Native Industrial TCP Mode │
└──────────────────────────┴─────────────────────────────┴───────────────────────────────┘
```

---

## 1. Core Architectural Pillars

### 1.1 Multi-Protocol Camera Subsystem (`camera/`)
Connects seamlessly to factory cameras, network video streams, and virtual simulators:
- **USB / DirectShow**: High-speed USB3 industrial cameras and webcams (indices `0`, `1`, `2`, ...).
- **Ethernet / RTSP Stream**: Security cameras, IP cameras, ONVIF / H.264 video streams (`rtsp://user:pass@ip:554/stream`).
- **HTTP / MJPEG**: Network snapshot feeds and remote web endpoints (`http://ip/snapshot.jpg`).
- **GenICam / Industrial GigE Vision Emulator**: Software trigger (`SW`), hardware strobe, exposure, and gain control.
- **Synthetic Industrial Part Generator**: Generates moving PCBs, fiducials, IC chips, drilled holes, and simulated defects for testing without physical camera hardware.
- **Industrial Subnet Device Discovery (`camera/cognamer.py`)**: High-speed UDP broadcast device discovery protocol on industrial port `1069`.

### 1.2 Spreadsheet DAG Pipeline Engine (`pipeline_engine.py`, `engine/`)
Inspection logic is evaluated via a deterministic pipeline and cell dependency graph (`A0`, `B2`, `C3`, `D4`, etc.):
- **Clean Standby Startup**: On launch, the application operates in camera streaming standby mode (`A0 = AcquireImage()`). No heavy inspection tools run automatically until explicitly added or configured by the operator.
- **Dedicated Output / Signal Column (Col #5)**:
  - Directly visible and editable in the spreadsheet table.
  - Displays real-time evaluation status and active output signal codes.
  - Click or double-click to configure output signal targets for any function.
  - Cyan `📡` indicator illuminates whenever live transmission to remote devices is enabled.
- **Universal Remote Signal Modes across All Functions**:
  1. *Pass / Fail Boolean Logic*: Emits Signal 1 (M0 coil / GPIO High) on Pass and 0 on Fail.
  2. *Calibrated Measurement Value*: Select continuous float metric (`Length`, `Width`, `Area`, `Diameter`, `Deviation`) with calibrated unit formatting.
  3. *YOLO Specific Object Class*: Trigger a designated signal ID only when a specific object class is detected (e.g. Signal #101 on `'bottle'`; ignores other classes) with optional inverted logic.
  4. *YOLO Combined (All Objects)*: Generates a combined trigger whenever total detected objects meet the threshold.
  5. *YOLO Multi-Class Signal Map*: Configures a discrete signal lookup table per class (e.g. Person = 1, Bottle = 2, Car = 3).
  6. *Quantity Count & Blobs*: Streams count of detected contours, blobs, or defects.
  7. *Centroid Coordinates (X, Y)*: Dispatches part coordinates for robot pick-and-place guidance.
  8. *Text / Decoded Strings*: Streams OCR read text, serial numbers, and barcode strings.
  9. *Custom Numeric Signal Code*: Fixed user-defined numeric code for PLC status synchronization.
- **Branching Input Sources**: Any step can consume either the raw camera frame (`Step 0`) or the processed output of any upstream step.
- **Intermediate Buffer Caching**: Unchanged upstream filters are automatically skipped, delivering sub-millisecond pipeline latency.
- **JSON Recipe Persistence**: Full inspection jobs (operations, parameters, branching inputs, and output signal configurations) export to human-readable JSON files for rapid batch recipe changeover.

### 1.3 Vision Tools Catalog (40+ Operations) (`operations_catalog.py`, `tools/`)
- **YOLO Deep Learning Suite**: YOLOv8 Nano/Small neural networks for Object Detection (80 COCO categories), Instance Segmentation, Semantic Segmentation, Depth Estimation, Pose Estimation (17 keypoints), and Oriented Bounding Boxes (OBB).
- **Geometric Contours & Calipers**: Subpixel edge detection, contour hierarchy filtering, convex hull, bounding boxes, oriented calipers, and circular hole/pin fitting.
- **Calibrated Metrology**: 2-point camera calibration tool (`1 px = X mm`) with automatic millimeter scaling across length, width, area, and deviation metrics.
- **1D & 2D Barcode & OCR**: QR code, DataMatrix, Code128, EAN barcode readers, and EasyOCR deep text extraction with alphanumeric regex fielding.
- **Geometric Shape Detector & Hand Tracker**: Real-time polygon, circle, rectangle, and triangle classification, plus 21-keypoint hand gesture tracking.
- **Pre-processing & Filtering**: Gaussian blur, bilateral smoothing, median denoising, morphology (erode, dilate, open, close, gradient), Canny edge, Sobel, Laplacian, thresholding (Otsu, adaptive), and CLAHE contrast enhancement.

### 1.4 Interactive Canvas ROI & Viewport (`viewport_widget.py`, `ui/roi_item.py`)
- **Interactive On-Canvas ROI Handles**:
  - 8-point interactive resize handles (top, bottom, left, right, and 4 corners).
  - Smooth drag-and-move with viewport boundary clamping.
  - Floating dimension HUD pill displaying `(X, Y) W x H [Area]`.
  - Full bi-directional synchronization with Property Inspector parameters.
- **Dual Split Viewport**:
  - Seamless toggle between Single View and 2-Window Split View (Viewport A Primary vs Viewport B Comparison).
  - Synchronized subpixel pan and zoom up to 1000%.
  - Real-time **Difference Heatmap Overlay** (JET colormap) illuminating subtle part deviations and surface shifts.
  - Floating Pixel Inspector HUD sampling real-time RGB/Gray intensity and subpixel cursor coordinates.

### 1.5 Multi-Fieldbus Industrial PLC & Robot Communications (`comms/`)
Production-grade bi-directional communication with factory automation controllers:
1. **Delta PLC via Modbus TCP (`comms/modbus_driver.py`)**:
   - Native Modbus TCP driver for Delta DVP, AS, and AH series controllers (port 502).
   - Structured register mapping:
     - `M0`: Pass (1) / Fail (0) Coil
     - `D100`: Status Code (1 = PASS, 0 = FAIL)
     - `D101`: Object / Defect Quantity Count
     - `D102 - D103`: Centroid X (FLOAT32)
     - `D104 - D105`: Centroid Y (FLOAT32)
     - `D106`: **Configured Signal ID / YOLO Class Code**
     - `D108 - D109`: **Continuous Calibrated Measurement (Length / Width / Area FLOAT32)**
2. **Siemens S7 PLC (`comms/siemens_s7.py`)**:
   - Supports Siemens S7-300, S7-400, S7-1200, and S7-1500 via ISO-on-TCP (port 102).
   - High-speed DB batch writes: Pass/Fail bit, Part Count, Centroid X/Y, Rotation Angle.
3. **Beckhoff TwinCAT PLC (`comms/beckhoff_ads.py`)**:
   - Native binary TwinCAT ADS client operating over TCP port 48898 (ADS router / port 851).
   - Writes directly to TwinCAT PLC `%M` memory area (`IndexGroup 0x4020`) or Modbus port 502.
4. **Generic Industrial Ethernet Devices (`comms/ethernet_device.py`)**:
   - TCP Client / Server & UDP Unicast / Broadcast for robots (ABB, KUKA, Fanuc, Universal Robots) and MES systems.
   - Dispatches formatted JSON payloads containing step metadata, pass/fail status, cycle time, coordinates, signal IDs, and numeric measurement values.
   - Remote trigger support: send `TRIGGER` over TCP to fire camera acquisition.
5. **Raspberry Pi GPIO (`comms/rpi_gpio.py`)**:
   - Remote **Pigpio Network Protocol** (TCP port 8888) to control physical pins on any Raspberry Pi over WiFi/Ethernet from Windows/Linux, or local memory-mapped `RPi.GPIO`.
   - Dedicated signals: PASS (GPIO 17), FAIL (GPIO 27), READY (GPIO 22), camera STROBE (GPIO 23), and opto-isolated hardware TRIGGER (GPIO 4).
   - Evaluated `signal_id` directly drives corresponding `class_id` hardware strobe pins.
6. **Native Industrial TCP Server (`comms/native_mode.py`)**:
   - Industrial ASCII command server on TCP port `1023` / `23`:
     - `GV <cell>`: Read cell result (e.g. `GV E5`, `GV B2.Score`).
     - `SW`: Software trigger image capture.
     - `SE 8`: Event trigger.
     - `SO <0|1>` / `GO`: Set / Get Online status.
     - `RB` / `RT`: Read inspection result buffer and cycle time.
7. **Central Industrial I/O Coordinator (`comms/io_manager.py`)**:
   - Asynchronous background thread dispatch (`dispatch_results_async`) preventing network latency from impacting frame rates.
   - Settings persisted in `config_industrial_io.json`.
   - Dedicated **`📡 PLC & Devices`** toolbar configuration dialog with live hardware ping test buttons.

### 1.6 Modern Cyber-Industrial User Interface
- **Cyber-Industrial Startup Banner (`ui/startup_banner.py`)**:
  - Frameless translucent cyber-glass card with illuminated emblem halo, smooth 350ms fade-in, and author tag *"Made with <3 By Anky Singh"*.
  - Automatically dismisses after 2.5s or instantly upon mouse click or keypress. Can be previewed standalone via `python preview_banner.py` or disabled with `--no-splash`.
- **Maximized Startup & Responsive Splitter Layout**:
  - Main window launches maximized with locked master-detail splitters (`420px` Pipeline Table, `860px` Viewport, `320px` Property Inspector).
- **Interactive User Manual (`user manual/index.html`)**:
  - Comprehensive dark-themed documentation suite with 8 chapters, high-resolution UI screenshots, formula cheat sheets, and PLC wiring diagrams.
  - Launchable via `Launch_User_Manual.bat`.

---

## 2. Quick Start

### Prerequisites
- Python 3.10, 3.11, 3.12, or 3.14
- Windows 10/11, Linux (Ubuntu 20.04+), or macOS

### Installation
```powershell
# Clone the repository
git clone https://github.com/anky-mthegem/Vision-app.git
cd Vision-app

# Install dependencies
pip install -r requirements.txt
```

### Starting the Application
Double-click `Launch_VisionStudio.bat` or run:
```powershell
python main.py
```

### Launching the Interactive User Manual
Double-click `Launch_User_Manual.bat` or open `user manual/index.html` in your web browser.

### Starting in Headless Mode (Industrial Edge / Docker)
For headless industrial rack-mount PCs, fanless edge controllers, or containers without graphical displays:
```powershell
python main.py --headless --port 8080 --native-port 1023
```

### Running the Automated Test Suite
```powershell
# Run complete industrial pipeline integration tests
python tests/test_pipeline_manager.py

# Run spreadsheet output column & remote signal dispatch tests
python tests/test_output_column.py

# Run PLC and industrial fieldbus communications tests
python tests/test_plc_comms.py
```

---

## 3. Project Structure

```
Vision-app/
├── camera/                          # Multi-protocol camera drivers & discovery
│   ├── base_camera.py               # Abstract industrial camera interface
│   ├── opencv_camera.py             # USB DirectShow & RTSP stream driver
│   ├── genicam_emulator.py          # Industrial GigE Vision software emulator
│   └── cognamer.py                  # UDP device discovery protocol
├── comms/                           # Industrial fieldbus & remote I/O drivers
│   ├── io_manager.py                # Unified asynchronous I/O coordinator
│   ├── modbus_driver.py             # Delta PLC Modbus TCP driver
│   ├── siemens_s7.py                # Siemens S7-300/400/1200/1500 driver
│   ├── beckhoff_ads.py              # Beckhoff TwinCAT ADS binary driver
│   ├── ethernet_device.py           # Industrial Ethernet TCP/UDP robot client
│   ├── rpi_gpio.py                  # Raspberry Pi Pigpio & local GPIO driver
│   └── native_mode.py               # Native Industrial ASCII TCP server (port 1023)
├── engine/                          # Spreadsheet DAG calculation engine
│   ├── dag.py                       # Topological DAG execution graph
│   ├── cell.py                      # Spreadsheet cell representations & formulas
│   └── parser.py                    # Expression & formula syntax parser
├── models/                          # Neural network model weights
│   └── yolov8n.onnx                 # YOLOv8 Nano ONNX deep learning weights
├── tools/                           # Classical & neural vision algorithms
│   ├── yolo_detector.py             # YOLOv8 ONNX multi-task inference
│   ├── measurement.py               # Subpixel geometry & caliper metrology
│   ├── blob_detector.py             # Connected components & blob analysis
│   ├── edge_detector.py             # Caliper edge rater & line fitting
│   ├── code_reader.py               # 1D/2D Barcode & QR code scanner
│   ├── ocr_tool.py                  # Optical character recognition reader
│   └── hand_tracker.py              # 21-keypoint hand & gesture tracker
├── ui/                              # PyQt6 industrial user interface components
│   ├── startup_banner.py            # Cyber-industrial splash banner
│   ├── output_signal_dialog.py      # Remote output & signal configuration modal
│   ├── roi_item.py                  # Interactive on-canvas ROI handles
│   ├── comms_dialog.py              # PLC & remote device IP configuration
│   └── calibration_dialog.py        # Optical scale factor calibration dialog
├── user manual/                     # Comprehensive HTML documentation suite
│   ├── index.html                   # Master user manual portal
│   ├── 01_getting_started.html      # Workspace layout & camera connection
│   ├── 02_camera_subsystem.html     # Protocols, calibration & synthetic feeds
│   ├── 03_spreadsheet_engine.html   # Spreadsheet DAG & Output column guide
│   ├── 04_vision_tools_catalog.html # Full algorithm catalog & parameters
│   ├── 05_plc_industrial_io.html    # Fieldbus wiring & register mapping
│   ├── 06_remote_control_native_mode.html # Native Mode TCP commands
│   └── 07_webhmi_dashboard.html     # Browser WebHMI telemetry & control
├── web/                             # WebHMI server
│   └── server.py                    # FastAPI & WebSockets real-time server
├── main.py                          # Application entry point & master window
├── pipeline_engine.py               # Pipeline step coordinator & signal evaluator
├── pipeline_table.py                # Spreadsheet table model & view
├── property_inspector.py            # Dynamic parameter drawer
├── viewport_widget.py               # Inspection canvas with split view & heatmap
├── preview_banner.py                # Standalone banner preview utility
├── Launch_VisionStudio.bat          # One-click desktop launcher
├── Launch_User_Manual.bat           # One-click manual launcher
└── requirements.txt                 # Project dependencies
```

---

## 4. Author & License

- **Author**: Anky Singh
- **Branding**: VisionStudio Industrial Suite • *Made with <3 By Anky Singh*
- **License**: [MIT License](LICENSE) — Open for industrial and commercial automation applications.
