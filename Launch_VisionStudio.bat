@echo off
title VisionStudio - In-Sight Computer Vision System
cd /d "%~dp0"
echo =====================================================================
echo  VisionStudio - In-Sight Computer Vision System
echo  Multi-Protocol Camera Acquisition & Inspection Engine
echo =====================================================================
echo.
echo Starting VisionStudio Industrial Desktop Application...
echo WebHMI will be available at: http://localhost:8080
echo Native Mode Telnet Server at: localhost:1023
echo.
python main.py
if errorlevel 1 (
    echo.
    echo Application exited with an error. Running headless mode fallback...
    python main.py --headless
)
pause
