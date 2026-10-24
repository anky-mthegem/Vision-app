"""FastAPI WebHMI & WebSockets Server mimicking Cognex In-Sight WebPages.bin / WebHMI.

Allows live monitoring and remote triggering from any web browser, mobile device, or factory panel.
"""

import cv2
import asyncio
import logging
from typing import Optional, Callable, Any
from fastapi import FastAPI, WebSocket, WebSocketDisconnect
from fastapi.responses import HTMLResponse, StreamingResponse
import uvicorn
import threading

logger = logging.getLogger("WebHMI")

app = FastAPI(title="VisionStudio WebHMI")

HTML_TEMPLATE = """
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>VisionStudio - In-Sight WebHMI</title>
    <link href="https://fonts.googleapis.com/css2?family=JetBrains+Mono:wght@400;600;800&family=Inter:wght@400;600;700&display=swap" rel="stylesheet">
    <style>
        :root {
            --bg-base: #0f1117;
            --bg-surface: #181b24;
            --bg-card: #202430;
            --border: #2d3244;
            --accent: #00d2ff;
            --pass: #00e676;
            --fail: #ff1744;
            --text-main: #e8ecf4;
            --text-dim: #8b94a8;
        }
        * { box-sizing: border-box; margin: 0; padding: 0; }
        body {
            font-family: 'Inter', sans-serif;
            background: var(--bg-base);
            color: var(--text-main);
            min-height: 100vh;
            display: flex;
            flex-direction: column;
        }
        header {
            background: var(--bg-surface);
            border-bottom: 1px solid var(--border);
            padding: 14px 28px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }
        .brand {
            display: flex;
            align-items: center;
            gap: 12px;
        }
        .brand h1 {
            font-size: 1.15rem;
            font-weight: 700;
            letter-spacing: 0.5px;
            background: linear-gradient(135deg, #00d2ff, #00e676);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
        }
        .status-badge {
            font-family: 'JetBrains Mono', monospace;
            padding: 6px 14px;
            border-radius: 6px;
            font-size: 0.85rem;
            font-weight: 700;
            text-transform: uppercase;
        }
        .badge-pass { background: rgba(0, 230, 118, 0.15); color: var(--pass); border: 1px solid var(--pass); }
        .badge-fail { background: rgba(255, 23, 68, 0.15); color: var(--fail); border: 1px solid var(--fail); }
        main {
            display: grid;
            grid-template-columns: 1fr 380px;
            gap: 20px;
            padding: 20px;
            flex: 1;
        }
        .viewport-card {
            background: var(--bg-surface);
            border: 1px solid var(--border);
            border-radius: 10px;
            overflow: hidden;
            display: flex;
            flex-direction: column;
        }
        .viewport-card .header {
            padding: 12px 18px;
            background: var(--bg-card);
            border-bottom: 1px solid var(--border);
            font-size: 0.88rem;
            font-weight: 600;
            display: flex;
            justify-content: space-between;
        }
        .img-container {
            flex: 1;
            display: flex;
            align-items: center;
            justify-content: center;
            background: #000;
            position: relative;
        }
        .img-container img {
            max-width: 100%;
            max-height: 70vh;
            object-fit: contain;
        }
        .stats-sidebar {
            display: flex;
            flex-direction: column;
            gap: 16px;
        }
        .card {
            background: var(--bg-surface);
            border: 1px solid var(--border);
            border-radius: 10px;
            padding: 18px;
        }
        .card h2 {
            font-size: 0.9rem;
            font-weight: 600;
            color: var(--text-dim);
            margin-bottom: 14px;
            text-transform: uppercase;
            letter-spacing: 0.5px;
        }
        .metrics-grid {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 12px;
        }
        .metric {
            background: var(--bg-card);
            padding: 12px;
            border-radius: 8px;
            border: 1px solid var(--border);
        }
        .metric .lbl { font-size: 0.75rem; color: var(--text-dim); }
        .metric .val { font-family: 'JetBrains Mono', monospace; font-size: 1.35rem; font-weight: 700; margin-top: 4px; }
        .btn-group {
            display: flex;
            gap: 10px;
            margin-top: 14px;
        }
        button {
            flex: 1;
            padding: 12px;
            border-radius: 8px;
            border: none;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.2s;
        }
        .btn-primary {
            background: var(--accent);
            color: #000;
        }
        .btn-primary:hover {
            opacity: 0.9;
            transform: translateY(-1px);
        }
        .cells-table {
            width: 100%;
            border-collapse: collapse;
            font-family: 'JetBrains Mono', monospace;
            font-size: 0.8rem;
            margin-top: 10px;
        }
        .cells-table th, .cells-table td {
            padding: 8px;
            text-align: left;
            border-bottom: 1px solid var(--border);
        }
        .cells-table th { color: var(--text-dim); font-size: 0.72rem; }
    </style>
</head>
<body>
    <header>
        <div class="brand">
            <svg width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="#00d2ff" stroke-width="2">
                <rect x="2" y="3" width="20" height="14" rx="2"/>
                <circle cx="12" cy="10" r="3"/>
                <line x1="8" y1="21" x2="16" y2="21"/>
                <line x1="12" y1="17" x2="12" y2="21"/>
            </svg>
            <h1>VisionStudio | In-Sight WebHMI</h1>
        </div>
        <div id="statusBadge" class="status-badge badge-pass">SYSTEM ONLINE</div>
    </header>

    <main>
        <div class="viewport-card">
            <div class="header">
                <span>LIVE INSPECTION OVERLAY</span>
                <span id="cycleTime">CYCLE: 0.0 ms</span>
            </div>
            <div class="img-container">
                <img id="videoFeed" src="/video_feed" alt="Camera Stream">
            </div>
        </div>

        <div class="stats-sidebar">
            <div class="card">
                <h2>Inspection Statistics</h2>
                <div class="metrics-grid">
                    <div class="metric">
                        <div class="lbl">TOTAL COUNT</div>
                        <div class="val" id="totalCount">0</div>
                    </div>
                    <div class="metric">
                        <div class="lbl">YIELD RATE</div>
                        <div class="val" id="yieldPct">100%</div>
                    </div>
                    <div class="metric">
                        <div class="lbl">PASSED</div>
                        <div class="val" style="color:var(--pass)" id="passCount">0</div>
                    </div>
                    <div class="metric">
                        <div class="lbl">FAILED</div>
                        <div class="val" style="color:var(--fail)" id="failCount">0</div>
                    </div>
                </div>
                <div class="btn-group">
                    <button class="btn-primary" onclick="triggerInspection()">TRIGGER SOFTWARE</button>
                </div>
            </div>

            <div class="card" style="flex:1;">
                <h2>In-Sight Spreadsheet Cells</h2>
                <table class="cells-table">
                    <thead>
                        <tr>
                            <th>CELL</th>
                            <th>LABEL</th>
                            <th>VALUE</th>
                        </tr>
                    </thead>
                    <tbody id="cellsBody">
                        <tr><td>A0</td><td>AcquireImage</td><td>[Frame]</td></tr>
                        <tr><td>B2</td><td>PatMax</td><td>Score: 98.4%</td></tr>
                        <tr><td>C3</td><td>Blobs</td><td>Count: 4</td></tr>
                        <tr><td>E5</td><td>Result</td><td>PASS</td></tr>
                    </tbody>
                </table>
            </div>
        </div>
    </main>

    <script>
        async function triggerInspection() {
            try {
                await fetch('/api/trigger', { method: 'POST' });
            } catch(e) { console.error(e); }
        }

        setInterval(async () => {
            try {
                const res = await fetch('/api/stats');
                const data = await res.json();
                document.getElementById('totalCount').innerText = data.inspections || 0;
                document.getElementById('yieldPct').innerText = (data.yield_pct || 100) + '%';
                document.getElementById('passCount').innerText = data.pass_count || 0;
                document.getElementById('failCount').innerText = data.fail_count || 0;
                document.getElementById('cycleTime').innerText = 'CYCLE: ' + (data.cycle_time_ms || 0) + ' ms';
                
                const badge = document.getElementById('statusBadge');
                if (data.overall_pass) {
                    badge.className = 'status-badge badge-pass';
                    badge.innerText = 'PASS';
                } else {
                    badge.className = 'status-badge badge-fail';
                    badge.innerText = 'FAIL';
                }
            } catch(e) {}
        }, 500);
    </script>
</body>
</html>
"""


class WebHmiServer:
    def __init__(self, frame_getter: Callable[[], Optional[Any]], job_getter: Callable[[], Any], trigger_cb: Callable[[], None], port: int = 8080):
        self.frame_getter = frame_getter
        self.job_getter = job_getter
        self.trigger_cb = trigger_cb
        self.port = port
        self._server_thread: Optional[threading.Thread] = None

    def start(self):
        @app.get("/", response_class=HTMLResponse)
        async def index():
            return HTML_TEMPLATE

        @app.get("/video_feed")
        def video_feed():
            def generate():
                while True:
                    frame = self.frame_getter()
                    if frame is not None:
                        ret, buffer = cv2.imencode(".jpg", frame, [cv2.IMWRITE_JPEG_QUALITY, 75])
                        if ret:
                            yield (
                                b"--frame\r\n"
                                b"Content-Type: image/jpeg\r\n\r\n"
                                + buffer.tobytes()
                                + b"\r\n"
                            )
                    time.sleep(0.04)

            return StreamingResponse(
                generate(),
                media_type="multipart/x-mixed-replace; boundary=frame",
            )

        @app.post("/api/trigger")
        async def trigger():
            self.trigger_cb()
            return {"status": "triggered"}

        @app.get("/api/stats")
        async def stats():
            job = self.job_getter()
            if job:
                return {
                    "overall_pass": job.overall_pass,
                    "cycle_time_ms": round(job.total_cycle_time_ms, 2),
                    "inspections": job.total_inspections,
                    "pass_count": job.total_passed,
                    "fail_count": job.total_failed,
                    "yield_pct": round((job.total_passed / max(1, job.total_inspections)) * 100.0, 1),
                }
            return {"status": "idle"}

        def run():
            uvicorn.run(app, host="0.0.0.0", port=self.port, log_level="warning")

        self._server_thread = threading.Thread(target=run, daemon=True)
        self._server_thread.start()
        logger.info(f"WebHMI dashboard running at http://localhost:{self.port}")
