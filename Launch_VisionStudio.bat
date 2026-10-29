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

:: ---------------------------------------------------------------------
:: 1. Verify Host System Python Installation
:: ---------------------------------------------------------------------
python --version >nul 2>&1
if errorlevel 1 (
    echo [ERROR] Python is not installed or not found in system PATH!
    echo Please install Python 3.10+ from https://www.python.org/
    echo Make sure to check the box "Add python.exe to PATH" during setup.
    echo.
    pause
    exit /b 1
)

for /f "tokens=*" %%i in ('python --version') do set BASE_PYTHON_VER=%%i
echo [1/3] Detected System Python: !BASE_PYTHON_VER!

:: ---------------------------------------------------------------------
:: 2. Check and Create Dedicated Project Virtual Environment (.venv)
:: ---------------------------------------------------------------------
set "VENV_DIR=%~dp0.venv"
set "VENV_PYTHON=%VENV_DIR%\Scripts\python.exe"
set "VENV_ACTIVATE=%VENV_DIR%\Scripts\activate.bat"

if not exist "!VENV_PYTHON!" (
    echo [*] No virtual environment found. Creating dedicated .venv environment...
    python -m venv "%VENV_DIR%" --system-site-packages >nul 2>&1
    if errorlevel 1 (
        echo [*] Falling back to standard venv creation...
        python -m venv "%VENV_DIR%"
    )
    if not exist "!VENV_PYTHON!" (
        echo [ERROR] Failed to create Python virtual environment at: %VENV_DIR%
        echo Please ensure python-venv is available or install manually:
        echo    python -m venv .venv
        echo.
        pause
        exit /b 1
    )
    echo [OK] Virtual environment successfully initialized at .venv
) else (
    echo [OK] Dedicated virtual environment verified at: %VENV_DIR%
)

:: Activate the virtual environment for this execution session
call "%VENV_ACTIVATE%"
echo [OK] Virtual environment activated successfully.
echo.

:: ---------------------------------------------------------------------
:: 3. Verify and Automatically Install Required Dependencies inside .venv
:: ---------------------------------------------------------------------
echo [2/3] Verifying runtime dependencies inside virtual environment...
"%VENV_PYTHON%" check_requirements.py --silent
if errorlevel 1 (
    echo.
    echo [!] Missing or incomplete dependencies detected inside virtual environment.
    echo [*] Automatically installing required packages from requirements.txt into .venv...
    echo.
    "%VENV_PYTHON%" -m pip install --upgrade pip >nul 2>&1
    "%VENV_PYTHON%" -m pip install -r requirements.txt
    if errorlevel 1 (
        echo.
        echo [ERROR] Failed to install requirements automatically inside .venv.
        echo Please ensure you have an active internet connection or run manually:
        echo    .venv\Scripts\python.exe -m pip install -r requirements.txt
        echo.
        pause
        exit /b 1
    )
    echo.
    echo [*] Re-verifying package installation inside .venv...
    "%VENV_PYTHON%" check_requirements.py
    if errorlevel 1 (
        echo [ERROR] Dependency verification failed after installation.
        pause
        exit /b 1
    )
) else (
    echo [OK] All core dependencies verified and ready inside .venv!
)

:: ---------------------------------------------------------------------
:: 4. Launch Desktop Application inside Virtual Environment
:: ---------------------------------------------------------------------
echo.
echo =====================================================================
echo  [3/3] Starting VisionStudio Desktop Application inside .venv...
echo  - Python Interpreter: %VENV_PYTHON%
echo  - Live WebHMI Dashboard: http://localhost:8080
echo  - Native Mode TCP Server: localhost:1023
echo =====================================================================
echo.

"%VENV_PYTHON%" main.py
if errorlevel 1 (
    echo.
    echo [!] Application exited with return code %ERRORLEVEL%.
    echo Attempting headless inspection mode fallback...
    "%VENV_PYTHON%" main.py --headless
)

echo.
echo VisionStudio session terminated.
pause
