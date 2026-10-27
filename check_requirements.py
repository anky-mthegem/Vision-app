"""VisionStudio Requirements Verification & Diagnostic Utility.

Verifies and validates all core and optional runtime dependencies.
Can be invoked by Launch_VisionStudio.bat or independently from terminal.

Made By <3 by Anky Singh
"""

from __future__ import annotations
import sys
import importlib
from typing import Dict, List, Tuple, Optional

# Core dependencies strictly required to run VisionStudio
CORE_REQUIREMENTS: List[Tuple[str, str, str]] = [
    ("PyQt6", "PyQt6", "Enterprise Desktop GUI & Three-Pane Viewport Framework"),
    ("cv2", "opencv-python", "Computer Vision Algorithms & Image Processing"),
    ("numpy", "numpy", "High-Performance Numerical Array Operations"),
    ("PIL", "Pillow", "Image Processing & Icon Serialization"),
    ("onnxruntime", "onnxruntime", "YOLO AI Multi-Task Neural Acceleration"),
    ("fastapi", "fastapi", "WebHMI Industrial REST API Server"),
    ("uvicorn", "uvicorn", "High-Speed ASGI Web Server Engine"),
    ("websockets", "websockets", "Real-Time 60 FPS WebSocket Frame Streaming"),
    ("snap7", "python-snap7", "Siemens S7-300/400/1200/1500 PLC Communications"),
    ("pymodbus", "pymodbus", "Delta PLC Modbus TCP Industrial Fieldbus"),
]

# Optional advanced vision extensions (software will gracefully fallback if absent)
OPTIONAL_REQUIREMENTS: List[Tuple[str, str, str]] = [
    ("mediapipe", "mediapipe", "MediaPipe 21-Landmark Hand & Gesture Kinematics"),
    ("pyautogui", "pyautogui", "Human-Interface Device Mouse & Input Automation"),
    ("pytesseract", "pytesseract", "Optical Character Recognition (Contour OCR fallback active)"),
]


def check_dependency(module_name: str) -> Tuple[bool, Optional[str]]:
    """Attempts to import a module and returns (is_available, version_string)."""
    try:
        mod = importlib.import_module(module_name)
        ver = getattr(mod, "__version__", None)
        if ver is None:
            # Check secondary version attributes
            for attr in ("VERSION", "version", "__VERSION__"):
                if hasattr(mod, attr):
                    ver = str(getattr(mod, attr))
                    break
        return True, str(ver) if ver else "installed"
    except Exception:
        return False, None


def main() -> int:
    silent = "--silent" in sys.argv
    verbose = "--verbose" in sys.argv or not silent

    if verbose:
        print("=" * 72)
        print("  VisionStudio Industrial Machine Vision - Dependency Diagnostic")
        print("  Made By <3 by Anky Singh")
        print("=" * 72)
        print(f"  Python Runtime : {sys.version.split()[0]} ({sys.executable})")
        print("-" * 72)

    missing_core: List[Tuple[str, str, str]] = []
    satisfied_core: List[Tuple[str, str, str, str]] = []

    for mod_name, pkg_name, desc in CORE_REQUIREMENTS:
        available, ver = check_dependency(mod_name)
        if available:
            satisfied_core.append((mod_name, pkg_name, str(ver), desc))
            if verbose:
                print(f"  [OK]   {pkg_name:<16} (v{ver:<10}) - {desc}")
        else:
            missing_core.append((mod_name, pkg_name, desc))
            if verbose:
                print(f"  [FAIL] {pkg_name:<16} (MISSING)    - {desc}")

    if verbose:
        print("-" * 72)
        print("  Optional Vision Extensions:")
        for mod_name, pkg_name, desc in OPTIONAL_REQUIREMENTS:
            available, ver = check_dependency(mod_name)
            if available:
                print(f"  [OK]   {pkg_name:<16} (v{ver:<10}) - {desc}")
            else:
                print(f"  [INFO] {pkg_name:<16} (Optional)   - {desc}")
        print("=" * 72)

    if missing_core:
        if verbose:
            print(f"\n[!] ATTENTION: {len(missing_core)} required package(s) missing:")
            for _, pkg, desc in missing_core:
                print(f"    - {pkg} ({desc})")
            print("\nRun: python -m pip install -r requirements.txt\n")
        return 1
    else:
        if verbose:
            print(f"\n[OK] All {len(satisfied_core)} core dependencies are installed and verified!\n")
        return 0


if __name__ == "__main__":
    sys.exit(main())
