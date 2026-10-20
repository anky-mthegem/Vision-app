# Cognex In-Sight Vision Suite - Binary Catalog & Classification Analysis

## 1. Overview
A total of **1,273 executable PE binaries** (.exe and .dll) were discovered, mapped, and cataloged across the Cognex In-Sight installation directory (`C:\Program Files\Cognex\In-Sight`).

### High-Level Summary Statistics:
- **Total Binaries**: 1,273
- **Managed (.NET CLI) Assemblies**: 1,195 (93.9%)
- **Native C/C++ Binaries**: 78 (6.1%)
- **Target Architectures**: x64 (64-bit AMD64) and x86 (32-bit legacy/bridge)
- **Primary .NET Runtime**: .NET Framework v4.8 (v4.0.30319 CLR)
- **Native Runtime**: Microsoft Visual C++ 14.x CRT (`VCRUNTIME140.dll`, `MSVCP140.dll`)

The complete inventory is cataloged in:
- Structured JSON: [`binary_inventory.json`](file:///C:/Users/anky_/Downloads/Vision%20rea/02_Binary_Catalog/binary_inventory.json)
- Full Markdown Table: [`binary_inventory.md`](file:///C:/Users/anky_/Downloads/Vision%20rea/02_Binary_Catalog/binary_inventory.md)

---

## 2. Binary Distribution by Functional Subsystem

| Subsystem / Directory | Total Binaries | Managed (.NET) | Native C/C++ | Primary Role |
|---|---|---|---|---|
| **Runtime Vision Engine & ML** (`Emulators\...\Runtime`) | 63 | 12 | 51 | Real-time vision execution, deep learning inference, MKL math libraries |
| **Emulator Shell** (`Emulators\In-Sight Emulator 25.1.0`) | 282 | 275 | 7 | Virtual camera host, simulated device acquisition |
| **Vision Suite Editor** (`In-Sight Vision Suite Editors`) | 396 | 385 | 11 | Spreadsheet and EasyBuilder interactive configuration UIs |
| **Vision Suite Adapter** (`In-Sight Vision Suite Adapters`) | 486 | 479 | 7 | Remoting, protocol serialization, camera communication bridge |
| **Vision Suite Shell** (`In-Sight Vision Suite`) | 34 | 33 | 1 | Central Cognex Explorer launch shell and license manager |
| **Process Host** (`In-Sight Vision Suite\ProcHost`) | 12 | 11 | 1 | 64-bit and 32-bit out-of-process isolation harnesses |

---

## 3. Analysis of Critical Native C/C++ Engines (78 Binaries)

### 3.1 Core Vision & Spreadsheet Engine
- **`InSightSheets.exe`** (64.5 MB, x64) & **`InSightSheets3D.exe`** (77.9 MB, x64):
  - The monolithic core vision execution engine.
  - Contains complete implementations of 328 Spreadsheet functions (PatMax, Edge, Blob, OCRMax, 3D Cross-Sections, HeightMaps).
  - Listens on TCP port 23 (Native Mode console), WebSockets / HTTP for CogSocket remoting, and communicates with `CogNamerServer.exe`.
- **`tako-vc140-21_1.dll`** (6.38 MB, x64):
  - "Tako" is Cognex's internal cross-platform spreadsheet calculation and graphics rendering library.
  - Also compiled into WebAssembly (`takoweb.wasm`) for the WebHMI operator browser interface.

### 3.2 Deep Learning & Edge AI Runtimes
- **`cartel.dll`** (6.06 MB, x64) & **`cartelwrapper.dll`** (194 KB, x64):
  - ViDi deep learning engine for inspection, classification, and OCR.
  - 625 exported C/C++ API symbols interfacing with deep neural networks.
- **`elaod.dll`** (2.59 MB, x64):
  - Edge Learning Anomaly & Object Detection module.
- **`cartel_msg.dll`** (1.78 MB, x64), **`cartel_anomalyhelpers.dll`** (64 KB), **`cartel_ocrhelpers.dll`** (58 KB):
  - Model serialization, message marshalling, and specialized OCR inference pipelines.

### 3.3 Hardware-Accelerated Inferencing & Linear Algebra
- **LibTorch (PyTorch C++ Backend)**:
  - `torch_cpu.dll` (129.5 MB, x64): Full CPU neural network tensor engine.
  - `torchvision.dll` (641 KB), `c10.dll` (801 KB), `torch.dll` (9.7 KB).
- **ONNX Runtime**:
  - `onnxruntime.dll` (8.45 MB, x64), `onnx_proto.dll` (457 KB).
- **TensorFlow Lite**:
  - `tensorflow-lite.dll` (5.95 MB, x64), `tflite_shared_rsc.dll` (27 KB).
- **Intel Math Kernel Library (MKL)**:
  - `mkl_core.dll` (71.6 MB), `mkl_avx2.dll` (41.1 MB), `mkl_avx512.dll` (51.9 MB), `mkl_avx.dll` (43.7 MB), `mkl_def.dll` (35.8 MB), `mkl_intel_thread.dll` (33.0 MB).
  - Intel Threading Building Blocks: `tbb.dll` (809 KB), `tbbmalloc.dll` (634 KB).

### 3.4 Cryptography & Industrial Security
- **GnuTLS Cryptographic Stack**:
  - `libgnutls-30.dll` (2.11 MB), `libgmp-10.dll` (818 KB), `libnettle-8.dll` (323 KB), `libhogweed-6.dll` (268 KB), `libwinpthread-1.dll` (67 KB).
  - Provides TLS 1.3 / DTLS encryption for secure industrial networks, FTPS (via `FluentFTP.GnuTLS.dll`), and HTTPS WebHMI.

---

## 4. Analysis of Key Managed .NET Assemblies (1,195 Binaries)

### 4.1 Shell & Integration Tier
- `Cognex.Explorer.exe` (755 KB): WPF Shell, manages main window, device view, and dockable tools.
- `Cognex.Explorer.Adapters.dll` (38 KB): Discovers adapters via Windows Registry and local file paths.
- `Cognex.Explorer.XProc.dll` (32 KB): .NET Remoting IPC interface (`IXProc`) connecting the shell to `Cognex.Explorer.ProcHost.exe`.
- `Cognex.CogNamer.Client.dll` (110 KB): UDP broadcast client on port 1069 for discovery, network settings, and factory resets.

### 4.2 Remoting & Protocol Serialization
- `Cognex.Remoting.CogSocket.dll` (112 KB): Implements bidirectional JSON-RPC message passing over WebSockets.
- `Cognex.InSight.Remoting.dll` (494 KB): Data contracts for all vision tool results, ROI shapes, ViDi models, and color palettes.
- `Cognex.InSight.dll` (2.15 MB): High-level client API (`CvsInSight`, `CvsSensor`, `CvsCogSocketSheet`).

### 4.3 Editors & User Controls
- `Cognex.InSight.Liger.SpreadsheetEditor.Shell.dll` (68 KB): The Spreadsheet Editor hosting shell.
- `Cognex.InSight.Liger.EasyBuilder.Shell.dll` (69 KB): The EasyBuilder guided application wizard.
- `Cognex.Tuna.Control.dll` (1.39 MB): Core custom WPF spreadsheet grid control.
- `Cognex.Tako.dll` (1.23 MB) & `Cognex.Tako.Controls.dll`: Managed wrapper around native `tako-vc140-21_1.dll`.
