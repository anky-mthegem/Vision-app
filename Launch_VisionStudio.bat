@echo off
setlocal EnableDelayedExpansion
title VisionStudio - Industrial Computer Vision System
cd /d "%~dp0"

echo =====================================================================
echo  VisionStudio - Industrial Machine Vision & Automation System
echo  Multi-Protocol Camera Acquisition, YOLO AI & PLC Fieldbus Engine
echo  Made with <3 by Anky Singh
echo =====================================================================
echo.

:: 1. Verify Python Installation
python --version >nul 2>&1
if errorlevel 1 (
    echo [ERROR] Python is not installed or not found in system PATH!
    echo Please install Python 3.10+ from https://www.python.org/
    echo Make sure to check the box "Add python.exe to PATH" during setup.
    echo.
    pause
    exit /b 1
)

for /f "tokens=*" %%i in ('python --version') do set PYTHON_VER=%%i
echo Detected Python: !PYTHON_VER!
echo.

:: 2. Check and Automatically Install Requirements
echo [1/2] Verifying VisionStudio runtime dependencies...
python check_requirements.py --silent
if errorlevel 1 (
    echo.
    echo [!] Missing or incomplete dependencies detected.
    echo [*] Automatically installing required packages from requirements.txt...
    echo.
    python -m pip install --upgrade pip >nul 2>&1
    python -m pip install -r requirements.txt
    if errorlevel 1 (
        echo.
        echo [ERROR] Failed to install requirements automatically.
        echo Please ensure you have an active internet connection or run manually:
        echo    python -m pip install -r requirements.txt
        echo.
        pause
        exit /b 1
    )
    echo.
    echo [*] Re-verifying package installation...
    python check_requirements.py
    if errorlevel 1 (
        echo [ERROR] Verification failed after installation.
        pause
        exit /b 1
    )
) else (
    echo [OK] All core dependencies verified and ready!
)

:: 3. Launch Application
echo.
echo =====================================================================
echo  Starting VisionStudio Industrial Desktop Application...
echo  - Live WebHMI Dashboard: http://localhost:8080
echo  - Native Mode TCP Server: localhost:1023
echo =====================================================================
echo.

python main.py
if errorlevel 1 (
    echo.
    echo [!] Application exited with return code %ERRORLEVEL%.
    echo Attempting headless inspection mode fallback...
    python main.py --headless
)

echo.
echo VisionStudio session terminated.
pause

