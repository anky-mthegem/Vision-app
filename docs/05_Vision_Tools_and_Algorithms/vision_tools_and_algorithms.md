# Cognex In-Sight Vision Suite - Vision Tools & Algorithmic Architecture

## 1. Algorithmic Overview
Cognex In-Sight combines classical rule-based computer vision (geometric pattern matching, edge analysis, blob topology) with modern machine learning (Edge Learning and ViDi Deep Learning) and full 3D point cloud processing.

All tools operate within the cell dependency graph evaluated by the native InSightSheets.exe and InSightSheets3D.exe engines.

---

## 2. Complete Spreadsheet Function Taxonomy (328 Functions)

Cross-referenced from Ref docs\metadata\spreadsheet_functions.json and verified in native binary export tables:

| Functional Category | Function Count | Core Functions & Capabilities |
|---|---|---|
| **2D Vision Tools** | 30 | PatMax, FindBlobs, FindLine, FindCircle, DetectFlaw, ReadIDMax, ReadOcrMax, Histogram, ExtractColor |
| **3D Vision Tools** | 31 | ExtractCrossSection3D, ExtractParallelCrossSections3D, ExtractRadialCrossSections3D, ExtractBlob3D, FitPlane3D, FitCylinder3D, FitSphere3D |
| **3D Construct Functions** | 26 | ConstructPlane3D, ConstructPoint3D, ConstructLine3D, ConstructBox3D, Intersect3D, ProjectPoint3D |
| **3D Vision Data Access** | 28 | GetPointCloudPoints, GetCrossSectionPoints, GetResiduals3D, GetInliers3D, GetOutliers3D |
| **3D Measure Functions** | 13 | Distance3D, Angle3D, PointToPlaneDistance3D, CylinderDiameter3D, SphereRadius3D |
| **3D Graphics & Structures** | 29 | PlotPointCloud3D, PlotCrossSection3D, PlotPlane3D, PlotSphere3D, PlotBoundingBox3D |
| **3D Sort & Controls** | 6 | SortPoints3D, FilterPointCloud3D, Acquisition3DControl |
| **2D Geometry Functions** | 13 | Distance, Angle, MidPoint, LineIntersection, BisectLine |
| **2D Structures & Transforms**| 29 | TransRot, CoordTransform, Fixture, MapPoint, OffsetFixture |
| **2D Vision Data Access** | 25 | GetRow, GetCol, GetScore, GetAngle, GetArea, GetPerimeter |
| **Graphics & Overlay** | 35 | PlotLine, PlotCircle, PlotRegion, PlotString, PlotCompositeRegion, PlotChart |
| **Input / Output & Comm** | 28 | WriteToPLC, ReadFromPLC, WriteFTP, ReadFTP, FormatString, ParseString |
| **Clocked Data Storage** | 16 | ClockedArray, ClockedAverage, ClockedMax, ClockedMin, FIFOBuffer |
| **Mathematics & Logic** | 6 | Sin, Cos, Tan, ASin, ACos, ATan, Sqrt, Exp, Ln, If, Choose |
| **Arrays & Objects** | 7 | ArrayCreate, ArrayGet, ArraySet, ObjectSerialize, ObjectDeserialize |
| **Scripting & Automation** | 4 | SpiderMonkey JavaScript execution (ScriptToolApi, async promise wrappers) |

---

## 3. Deep Dive into Core Algorithmic Engines

### 3.1 PatMax (Geometric Pattern Matching)
- **Principle**: Unlike pixel-grid cross-correlation, PatMax extracts geometric contours and feature vectors (boundary gradient magnitude and angle).
- **Invariance**: Provides full 6-DOF 2D transformation invariance (translation $X, Y$, rotation $\theta$, anisotropic scale $S_x, S_y$, aspect ratio, and shading/illumination).
- **Sub-pixel Accuracy**: Sub-pixel boundary fitting achieves precision down to 1/40th of a pixel.
- **Trained Model**: Serialized in the .job file as a geometric boundary chain and spatial index tree.

### 3.2 3D Point Cloud Processing & Volumetric Tools (InSightSheets3D.exe & Cognex.InSight3D.dll)
Designed for 3D displacement sensors (such as the In-Sight 3D-L4000 laser profiler, codename "Pumbaa"):
- **Raw Acquisition**: Produces calibrated Cartesian point clouds $(X, Y, Z)$ stored in native memory buffers (cortex::types::DataView).
- **Cross-Section Extraction**:
  - ExtractCrossSection3D: Slices a 3D point cloud along a specified plane to produce a 2D profile curve $(X, Z)$.
  - ExtractParallelCrossSections3D / ExtractRadialCrossSections3D: Generates multiple sequential cross-sections for cylindrical, curved, or threaded objects.
- **Robust Model Fitting (RANSAC & M-Estimators)**:
  - FitPlane3D, FitCylinder3D, FitSphere3D: Fits mathematical primitives to noisy point clouds.
  - Distinguishes **Inliers** (points within tolerance threshold) from **Outliers** (points outside threshold).
  - Calculates **Residuals**: Root-mean-squared (RMS) and maximum error metrics indicating surface quality or defect severity.

### 3.3 OCRMax & Deep OCR (cartel_ocrhelpers.dll & Cognex.Ocr.Client.dll)
- **Auto-Tuning Engine**:
  - Export cartel::ocr_helpers::find_optimal_character_size(string, ImageView): Analyzes image spatial frequency and edge gradients to determine the ideal bounding-box height and stroke width.
  - Export cartel::ocr_helpers::flexible_fielding_from_expression(...): Implements timeout-bounded regular expression validation for industrial date codes, lot numbers, and alphanumeric strings.
- **Client Architecture**:
  - Cognex.Ocr.Client.Tool.OcrToolService: Manages labeling, sample collection, character bounding box corrections, and candidate font definitions.

### 3.4 Edge Learning & Deep Learning (cartel.dll, cartel_msg.dll, cartel_anomalyhelpers.dll)
- **Anomaly Detection Calibration**:
  - Defined in cartel_anomalyhelpers.dll:
    - cartel::anomaly_helpers::BezierCurveParams: Cubic Bézier curve parameter representation.
    - cartel::anomaly_helpers::find_mapping_points: Calibrates raw feature-space L2 distances against user Good/Bad annotations.
    - cartel::anomaly_helpers::find_optimal_feature_size: Evaluates candidate feature kernels to select the highest discriminative scale.
    - cartel::anomaly_helpers::map_score_map_to_heatmap: Converts raw floating-point score arrays into RGB heatmaps for operator visualization in WebHMI.
- **Protobuf Schemas (cartel_msg.dll)**:
  - 6,676 exported symbols defining serialization for classification, anomaly detection, segmentation, and OCR models.
- **Client Architecture**:
  - Cognex.AnomalyDetector.Client.Tool.AnomalyDetectorToolService: Manages training sets, auto-threshold calculations, and real-time inference feedback.
  - Cognex.Segmenter.Client.Tool.SegmenterToolService: Coordinates pixel-level defect segmentation and mask generation (IMaskBitmap).

---

## 4. Scripting & JavaScript Engine Integration

### 4.1 Mozilla SpiderMonkey Embedding
Binary disassembly and export table analysis of InSightSheets.exe (704 exports) and InSightSheets3D.exe (670 exports) reveals that Cognex embeds **Mozilla SpiderMonkey** (js:: and JS::), not Google V8:
- **Core Engine Types**:
  - JSContext: Execution environment and thread isolation.
  - JS::CompileOptions & JS::OwningCompileOptions: Syntax compiler settings.
  - js::CrossCompartmentWrapper & js::SecurityWrapper: Strict security sandbox separating spreadsheet user scripts from native memory.
  - js::proxy_Call, js::proxy_GetProperty, js::proxy_SetProperty: Native reflection proxies exposing In-Sight spreadsheet cells as JavaScript objects.
- **Cell Scripting API**:
  - Users can write spreadsheet cells containing JavaScript functions that execute synchronously during the camera's inspection cycle.
