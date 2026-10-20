# Cognex In-Sight Vision Suite - File Formats & Proprietary Data Structures

## 1. Overview
This specification details the binary formats, serialization schemas, and memory representations of proprietary Cognex file formats reverse-engineered from In-Sight assemblies, native runtime libraries, and firmware packages.

---

## 2. .job File Format (In-Sight Job Configuration)

### 2.1 File Purpose & Scope
A .job file is the complete executable project container for an In-Sight vision application. It contains:
- Complete spreadsheet cell matrices (A0 through Z399 / customizable dimensions).
- Cell formulas, operand trees, cell references, and formatting rules.
- Vision tool definitions (PatMax patterns, edge detectors, OCR fonts, color libraries).
- Camera acquisition settings (exposure, gain, strobe, trigger mode).
- Communication bindings (EtherNet/IP, PROFINET, Modbus, Native Mode tag links).
- WebHMI operator view layouts and interactive controls.

### 2.2 Container Layout
A .job file is stored as a structured binary record:
`
+-------------------------------------------------------------------------+
| File Header (Magic, Version, Architecture, Feature Flags)                |
+-------------------------------------------------------------------------+
| Sensor Configuration (Camera Model, Imager Resolution, Lens, Lighting)  |
+-------------------------------------------------------------------------+
| Spreadsheet Grid Metadata (Active Dimensions, Named Cells, Styles)      |
+-------------------------------------------------------------------------+
| Cell Definitions Stream (Formulas, Constants, Flags, Cell Types)        |
+-------------------------------------------------------------------------+
| Tool Data Payloads (Trained Patterns, ROI coordinates, Deep Models)     |
+-------------------------------------------------------------------------+
| Industrial Communication Tag Mappings & Signal Maps                     |
+-------------------------------------------------------------------------+
| WebHMI Layout Metadata & Operator View Definitions                      |
+-------------------------------------------------------------------------+
| Cryptographic Integrity Hash / Job Validation Signature                 |
+-------------------------------------------------------------------------+
`

### 2.3 Cell Status Flags (CvsCellFlags)
Discovered from Cognex.InSight.Cell.CvsCellFlags.cs:
Each spreadsheet cell stores a 16-bit status integer bitmask:

`csharp
[Serializable]
[Flags]
internal enum CvsCellFlags : short
{
    Disabled    = -32768, // 0x8000: Cell calculation is disabled
    Error       = 0x4000, // 0x4000: Cell evaluated to an error (#ERR)
    Empty       = 0x2000, // 0x2000: Cell contains no data or formula
    Control     = 0x1000, // 0x1000: Cell contains interactive UI control (button, checkbox, listbox)
    Quotes      = 0x0800, // 0x0800: Value is treated as literal quoted string
    HasChecksum = 0x0008  // 0x0008: Cell carries an integrity verification checksum
}
`

### 2.4 Cell Types & Polymorphic Results
Spreadsheet cells inherit from CvsCell and evaluate to polymorphic results:
- **CvsCellFloat / CvsCellInt**: Numeric scalar values.
- **CvsCellString**: Text and string manipulation formulas.
- **CvsCellButton**: Interactive trigger button in WebHMI.
- **CvsCellCheckBox**: Boolean toggle.
- **CvsCellListBox**: Single/multi-choice dropdown.
- **CvsCellColorLabel**: Status indicator with dynamic color mapping.
- **CvsCellJump**: Navigation hyperlink within spreadsheet grid.
- **CvsCellOcrMaxAutoTune**: Specialized auto-tune state machine for OCR font learning.

### 2.5 Job Encryption & Integrity (CvsInSightJobEncryption)
Jobs can be saved with encryption to protect proprietary inspection logic and trained vision IP:
- **Legacy Mode**: Proprietary stream cipher keyed by camera serial number or Cognex master key.
- **Fast Mode**: Modern AES-CBC encryption with SHA-256 integrity verification, admitted on In-Sight firmware 6.x and 24.x+.

---

## 3. .cbd File Format (Cognex Binary Data / Neural Models)

### 3.1 Overview
Discovered in Emulators\In-Sight Emulator 25.1.0\Runtime\:
.cbd files store trained neural network weights, architectures, and preprocessing pipelines for Cognex Deep Learning (ViDi) and Edge Learning (ViDiEL).

### 3.2 Binary Envelope & Header Structure
The binary layout of a .cbd file was reverse-engineered as follows:
`
+---------------+---------------+-----------------------------------------+
| Offset (Hex)  | Length (Bytes)| Field Description                       |
+---------------+---------------+-----------------------------------------+
| 0x00000000    | 8             | Magic Bytes: "CARTEL\0\0"               |
|               |               | (0x43, 0x41, 0x52, 0x54, 0x45, 0x4C, 0, 0)|
+---------------+---------------+-----------------------------------------+
| 0x00000008    | 1             | Format Tag: 0x73                        |
+---------------+---------------+-----------------------------------------+
| 0x00000009    | 1             | Protobuf Field 1 Tag: 0x0A (Len-delim)  |
+---------------+---------------+-----------------------------------------+
| 0x0000000A    | 1             | Length of Version String: 0x0D (13)     |
+---------------+---------------+-----------------------------------------+
| 0x0000000B    | 13            | Version String: "cartel v9.1.0"         |
+---------------+---------------+-----------------------------------------+
| 0x00000018    | 1             | Protobuf Field 2 Tag: 0x12 (Len-delim)  |
+---------------+---------------+-----------------------------------------+
| 0x00000019    | 1             | Digest Length: 0x40 (64 bytes)          |
+---------------+---------------+-----------------------------------------+
| 0x0000001A    | 64            | SHA-256 Digest (Uppercase Hex ASCII)    |
|               |               | e.g., "C364D0A44A709B71...4C8D2C9"     |
+---------------+---------------+-----------------------------------------+
| 0x0000005A    | Variable      | Protobuf Network Graph & Weights Payload|
+---------------+---------------+-----------------------------------------+
`

### 3.3 Shipped Model Inventory
| CBD File | File Size (Bytes) | Functional Role | Engine / Framework |
|---|---|---|---|
| large_detection.cbd | 78,139,223 (~78 MB) | High-accuracy complex object detection | LibTorch / PyTorch C++ |
| aster_detection.cbd | 3,483,688 (~3.5 MB) | Fast high-throughput object locator | ONNX / TFLite |
| otated_faster_detection.cbd | 3,619,496 (~3.6 MB) | Oriented bounding-box object locator | ONNX / TFLite |
| classification.cbd | 2,287,508 (~2.3 MB) | Multi-class part sorting & classification | Edge Learning (Cartel) |
| nomaly_detection.cbd | 581,392 (~581 KB) | Unsupervised defect & anomaly detection | Edge Learning (Cartel) |
| detection_accurate.cbd | 581,920 (~582 KB) | High-precision feature detection | TFLite / Cartel |
| detection_fast.cbd | 71,160 (~71 KB) | Ultra-lightweight presence/absence check | TFLite / Cartel |
| segmentation.cbd | 583,755 (~584 KB) | Pixel-level semantic defect segmentation | Edge Learning (Cartel) |
| deep_ocr_pretrained_whole.cbd | 659,542 (~660 KB) | Pretrained omni-font deep reading model | Deep OCR Engine |
| deep_ocr_pretrained_subset.cbd| 647,050 (~647 KB) | Pretrained industrial character subset | Deep OCR Engine |
| ocr_pretrained.cbd | 980,432 (~980 KB) | Standard OCRMax neural font model | OCR Engine |
| ocr_pretrained_70.cbd | 980,430 (~980 KB) | Alternate checkpoint OCR font model | OCR Engine |
| ocr.cbd | 581,916 (~582 KB) | Base OCR character recognizer | OCR Engine |

### 3.4 Protobuf Message Types (cartel_msg.dll)
Model graphs and inference configurations are encoded using Google Protobuf schemas defined in cartel_msg.dll:
- cartel::msg::classification::ModelConfig
- cartel::msg::anomaly_detector::InferenceConfig
- cartel::msg::ocr::OcrModel
- cartel::msg::segmentation::SegmentationModel
- cartel::msg::common::ConfusionMatrix
- cartel::msg::common::ClassMetrics

---

## 4. WebPages.bin Archive Container Format

### 4.1 Container Structure
WebPages.bin is a custom uncompressed/compressed binary archive file format storing the WebHMI frontend:
`
+---------------+---------------+-----------------------------------------+
| Offset (Hex)  | Length (Bytes)| Field Description                       |
+---------------+---------------+-----------------------------------------+
| 0x00000000    | 4             | Magic Header: 0xABCD0001 (Little-Endian)|
+---------------+---------------+-----------------------------------------+
| 0x00000004    | 4             | Number of Files (UINT32): 43 (0x2B)     |
+---------------+---------------+-----------------------------------------+
| 0x00000008    | 72 * N        | File Directory Table (43 entries)       |
+---------------+---------------+-----------------------------------------+
| Variable      | Variable      | File Data Payloads (Gzipped or raw)     |
+---------------+---------------+-----------------------------------------+
`

### 4.2 Entry Record Layout (72 Bytes Per Entry)
`
+---------------+---------------+-----------------------------------------+
| Offset        | Length (Bytes)| Description                             |
+---------------+---------------+-----------------------------------------+
| +0            | 64            | ASCII Filename (Null-padded string)     |
|               |               | e.g. "takoweb.wasm.gz\0\0..."          |
+---------------+---------------+-----------------------------------------+
| +64           | 4             | Data Offset from start of file (UINT32) |
+---------------+---------------+-----------------------------------------+
| +68           | 4             | Data Payload Length in bytes (UINT32)   |
+---------------+---------------+-----------------------------------------+
`

### 4.3 Embedded WebAssembly & JavaScript Runtime
Extracted and decompressed from WebPages.bin:
- **	akoweb.wasm** (3,323,188 bytes, decompressed):
  - Emscripten WebAssembly compilation of Cognex Tako C++ graphics engine.
  - Contains 97 exported functions mapped in 	akoweb_wasm_exports.json.
  - Implements client-side 2D/3D polygon clipping, Bezier curves, coordinate affine transforms, and WebGL rendering.
- **Framework.js** (9,325,382 bytes, decompressed):
  - AMD/RequireJS based single-page application framework.
  - Contains modular controllers:
    - cogsocket: WebSocket JSON-RPC communication bridge.
    - Adapters/CjsVisionControllerAdapter: Camera controller proxy.
    - Tags/CjsTagEngine: Real-time spreadsheet tag synchronization.
    - Download/CjsDownloadManager: High-speed image and point cloud stream cache.
    - Commands/InSightCommands: Native spreadsheet and camera command executor.

---

## 5. .cxd File Format (Cell Data Exchange)

### 5.1 Overview
.cxd files store externalized spreadsheet data for large structures that would bloat the .job file:
- Trained OCRMax font tables and character instances (CvsOcrMaxExportedFont).
- Color extraction library samples (TrainExtractColorLibrary).
- Large lookup tables and calibrated 3D point cloud reference maps.
- Exported and imported via Native Mode DF / RF / WF commands.
