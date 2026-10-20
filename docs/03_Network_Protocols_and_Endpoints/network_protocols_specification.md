# Cognex In-Sight Vision Suite - Network Protocols & Communication Endpoints

## 1. Network Services & Port Map
The In-Sight Vision System and In-Sight Emulator expose several standardized and proprietary network services:

| Protocol | Default Port | Transport | Service / Daemon | Functional Role |
|---|---|---|---|---|
| **CogNamer** | **1069** (alt 51069) | **UDP** | `CogNamerServer.exe` | Camera discovery, IP assignment, factory reset, flash LEDs |
| **CogSocket** | **80 / 443** (or ephemeral) | **TCP (WebSocket)** | `InSightSheets.exe` | Live spreadsheet synchronization, ROI manipulation, results streaming |
| **Native Mode** | **23** (Telnet) | **TCP** | `InSightSheets.exe` | Two-letter text commands (LF, SJ, GV, SI, SF, SS, SO, GO, SE) |
| **FTP** | **21** / 51000-51050 | **TCP** | `vsftpd` / internal | Job (`.job`) and image (`.bmp`/`.jpg`) transfer, passive data ports |
| **WebHMI** | **80** (HTTP) / **443** (HTTPS) | **TCP** | `nginx` / internal | Web-based operator HMI interface, WebAssembly (`takoweb.wasm`) |
| **EtherNet/IP** | **44818** / **2222** | **TCP / UDP** | In-Sight CIP Stack | Industrial PLC cyclic I/O and explicit messaging |
| **PROFINET** | **34964** / 161-162 | **UDP** | PROFINET Stack | Real-time cyclic IO data exchange and SNMP diagnostic |
| **SLMP** | **32704 - 32768** | **TCP** | SLMP Scanner | Mitsubishi MC Protocol / Seamless Message Protocol scanner |
| **OPC UA** | **4840** | **TCP** | OPC UA Server | Industrial SCADA/MES tag subscription and monitoring |
| **MQTT** | 1883 / 8883 | TCP (Client) | MQTT Forwarder | Telemetry publishing and remote Native Mode command execution |
| **Tracing** | **50006 / 50007** | **TCP** | Tracing Daemon | Low-level firmware diagnostic log streams |

---

## 2. CogNamer Discovery Protocol (UDP Port 1069)

### 2.1 Packet Wire Format
Discovered from `Cognex.CogNamer.Client.dll`:
- **Broadcast Address**: `255.255.255.255:1069` (or unicast to camera IP, fallback port `51069`).
- **Endianness**: Little-Endian.
- **Integer Encoding**: Multi-byte integers use **LEB128 Variable-Length Integers (VarInt)**.

```
+--------------------+----------------+---------------+-------------------+--------------------+--------------------+-----------------------+
| Magic (4 bytes)    | Version (1 B)  | Flags (1 B)   | Command (VarInt)  | ErrorCode (VarInt) | Length (VarInt)    | Records (TLV stream)  |
| 0x4D 0x41 0x4E 0x43| 0x04           | Bitmask       | 1 to 8            | 0 = Success        | Byte length        | Attribute Records     |
| ASCII: "MANC"      | Protocol v4    | Flags         | Command ID        | Error Status       | Payload Byte Count | Repeated TLV items    |
+--------------------+----------------+---------------+-------------------+--------------------+--------------------+-----------------------+
```

### 2.2 VarInt Algorithm (LEB128)
```csharp
// Encode
while (value >= 0x80) {
    writer.Write((byte)(value | 0x80));
    value >>= 7;
}
writer.Write((byte)value);

// Decode
int num = 0, shift = 0;
do {
    byte b = reader.ReadByte();
    num |= (b & 0x7F) << shift;
    shift += 7;
} while ((b & 0x80) != 0);
```

### 2.3 CogNamer Commands (`CogNamerCommand`)
| Command ID | Command Name | Description |
|---|---|---|
| `1` | `IPRequest` | Discovery request broadcast sent by Cognex Explorer |
| `2` | `SetNetwork` | Set static IP, subnet mask, gateway, or DHCP enable |
| `3` | `FactoryReset` | Reset vision system to factory defaults |
| `4` | `Flash` | Flash physical sensor LEDs to identify camera on line |
| `5` | `Hello` | Heartbeat / sensor announcement |
| `6` | `Restart` | Soft reboot vision system |
| `7` | `SetAttribute` | Write custom device attribute |
| `8` | `ResetAdminPassword` | Reset admin credentials |

### 2.4 Attribute TLV Record Format
Each record inside the payload has:
- `AttributeType` (VarInt)
- `Length` (VarInt)
- `Data` (byte array, typically UTF-8 encoded string)

| Attribute ID | Name | Data Type | Description |
|---|---|---|---|
| `32` (`0x20`) | `DeviceType` | String | e.g., "In-Sight 2800", "In-Sight D900", "In-Sight 3D-L4000" |
| `33` (`0x21`) | `MacAddress` | Binary / String | Physical Ethernet MAC address (e.g. `00:D0:24:xx:xx:xx`) |
| `34` (`0x22`) | `HostName` | String | Configured camera network name |
| `35` (`0x23`) | `IpAddress` | String / UInt32 | Current IP address |
| `36` (`0x24`) | `NetworkSettings` | Struct | Subnet mask, gateway, DNS, DHCP flag |
| `37` (`0x25`) | `ModelNumber` | String | Cognex internal model number |
| `38` (`0x26`) | `SerialNumber` | String | Hardware serial number |
| `39` (`0x27`) | `SoftwareVersion` | String | Firmware version (e.g., "25.1.0") |
| `40` (`0x28`) | `Description` | String | User description |
| `41` (`0x29`) | `GroupName` | String | Vision suite grouping tag |
| `43` (`0x2B`) | `Services` | Bitmask / String | Supported services bitfield |
| `48` (`0x30`) | `ProductIdentity` | String | Product GUID identity |

---

## 3. CogSocket Remoting Protocol (JSON-RPC over WebSockets)

### 3.1 Overview
Discovered from `Cognex.Remoting.CogSocket.dll` and `Cognex.InSight.dll`:
CogSocket is Cognex's proprietary REST-like JSON-RPC communication bridge running over full-duplex TCP/WebSocket connections. It allows synchronous request-response queries, asynchronous state subscriptions, and bi-directional RPC event streaming.

### 3.2 Message Structure
Every CogSocket message is a JSON object with a single root key identifying the message type:
```json
{
  "<MessageType>": {
    "id": 101,
    "path": "/sheet/cell/A2/value",
    "body": { ... },
    "error": 0
  }
}
```

### 3.3 Message Types (`CogSocketMessage`)
| Message Verb | Class | DataContract Name | Direction | Description |
|---|---|---|---|---|
| `get` | `CogSocketGetMessage` | `"get"` | Client -> Server | Retrieve value, cell property, image, or system state |
| `put` | `CogSocketPutMessage` | `"put"` | Client -> Server | Update existing resource, write cell value, update ROI |
| `post` | `CogSocketPostMessage` | `"post"` | Client -> Server | Trigger action (acquire image, execute inspection, add tool) |
| `response` | `CogSocketResponseMessage`| `"response"` | Server -> Client | Return requested result or execution status matching request `id` |
| `event` | `CogSocketEventMessage` | `"event"` | Server -> Client | Asynchronous notification (acquisition complete, sheet updated) |
| `listen` | `CogSocketListenMessage` | `"listen"` | Client -> Server | Subscribe to path changes (e.g. `/sheet/results`) |
| `unlisten` | `CogSocketUnlistenMessage` | `"unlisten"` | Client -> Server | Unsubscribe from path |
| `invoke` | `CogSocketInvokeMessage` | `"invoke"` | Client -> Server | Remote method invocation with argument list |
| `delegate` | `CogSocketDelegateMessage`| `"delegate"` | Client -> Server | Register remote callback delegate |

### 3.4 Key Resource Paths
- `/sheet/results`: Current spreadsheet execution results (`CvsCogSheetResult`).
- `/sheet/cells/<col><row>`: Individual cell metadata, formula, and graphic shapes (`CvsCogShape[]`).
- `/acq/live`: Live camera acquisition stream.
- `/acq/trigger`: Trigger software acquisition.
- `/job/active`: Active job file operations (load, save, validate).
- `/system/info`: Camera serial, model, temperature, uptime.

---

## 4. Native Mode Communications (Telnet TCP Port 23)

### 4.1 Overview
Native Mode is an ASCII text command protocol designed for PLCs, robots, SCADA systems, and terminal consoles.
- **Transport**: Raw TCP socket on port 23 (or transmitted over MQTT).
- **Line Terminator**: Carriage Return + Line Feed (`\r\n`).
- **Authentication**: When enabled, the camera prompts `User:` and `Password:`.

### 4.2 Comprehensive Command Reference Table
Aligned with `Ref docs\08_Native_Mode_Communications`:

| Cmd | Name | Syntax | Parameters | Response | Description |
|---|---|---|---|---|---|
| **`LF`** | Load File | `LF[Filename]` | Filename on flash | `1` (Success) or `-2` (Fail) | Loads `.job` file from flash memory making it active |
| **`RF`** | Read File | `RF[Filename]` | Filename | `[Size][Checksum]\r\n[Data]` | Reads file contents in Hex-ASCII |
| **`WF`** | Write File | `WF[Filename]` | Filename, Size, Data | `1` or error | Writes file to flash memory |
| **`DF`** | Delete File | `DF[Filename]` | Filename | `1` or `-2` | Deletes job or `.cxd` data file |
| **`GF`** | Get File | `GF` | None | `[Filename]` | Returns name of active loaded job |
| **`TF`** | Store File | `TF[Filename]` | Filename | `1` or `-2` | Saves current job with specified filename |
| **`SJ`** | Set Job | `SJ[JobID]` | Job ID (0-999) | `1` or `-2` | Loads job from numbered slot |
| **`TJ`** | Store Job | `TJ[JobID]` | Job ID (0-999) | `1` or `-2` | Saves current job to numbered slot |
| **`RJ`** | Read Job | `RJ[JobID]` | Job ID | Hex-ASCII block | Reads job data from slot |
| **`WJ`** | Write Job | `WJ[JobID]` | Job ID, Data | `1` or `-2` | Writes job data to slot |
| **`DJ`** | Delete Job | `DJ[JobID]` | Job ID | `1` or `-2` | Deletes job in numbered slot |
| **`GJ`** | Get Job | `GJ` | None | `[JobID]` | Returns ID number of active job |
| **`GV`** | Get Value | `GV[Col][Row]` | e.g., `GVA002` | `[Value]` | Returns evaluated value in cell |
| **`SI`** | Set Integer | `SI[Col][Row][Val]` | Cell, Int | `1` or `-2` | Sets integer value in cell |
| **`SF`** | Set Float | `SF[Col][Row][Val]` | Cell, Float | `1` or `-2` | Sets floating-point value in cell |
| **`SS`** | Set String | `SS[Col][Row][Str]` | Cell, Text | `1` or `-2` | Sets string value in cell |
| **`SR`** | Set Region | `SR[Col][Row][Params]`| Cell, X, Y, W, H, Ang | `1` or `-2` | Sets 2D EditRegion cell parameters |
| **`ST`** | Set Region3D | `ST[Col][Row][Params]`| Cell, 3D Box Params | `1` or `-2` | Sets 3D EditRegion3D cell parameters |
| **`SO`** | Set Online | `SO[1/0]` | `1`=Online, `0`=Offline | `1` or `-2` | Toggles camera Online / Offline |
| **`GO`** | Get Online | `GO` | None | `1` or `0` | Queries Online state |
| **`SE`** | Set Event | `SE[EventNum]` | Event number (0-7) | `1` or `-2` | Triggers spreadsheet event |
| **`SW`** | Set Event & Wait | `SW[EventNum]` | Event number (0-7) | `1` (Completed) | Triggers event and waits for execution |
| **`MT`** | Manual Trigger | `MT` | None | `1` or `-2` | Triggers image acquisition |
| **`RB`** | Read BMP | `RB` | None | Hex-ASCII BMP | Returns current image in BMP format |
| **`GI`** | Get Info | `GI` | None | Model, Serial, Firmware | Returns system hardware info |
| **`RT`** | Reset (Reboot) | `RT` | None | Connection closed | Reboots vision system |
| **`GSV`** | Get System Valid. | `GSV` | None | Status bitmask | Returns system validation health |
| **`RJV`** | Run Job Valid. | `RJV` | None | Status | Executes job validation |

### 4.3 Native Mode Checksum Algorithm
When checksum verification is enabled in communications settings, commands and responses append an 8-character hexadecimal checksum calculated via CCITT CRC-16 or 32-bit additive sum across ASCII byte values.

---

## 5. Industrial Ethernet Protocols

### 5.1 EtherNet/IP (CIP)
- **Ports**: TCP/UDP `44818` (Encapsulation), UDP `2222` (Implicit I/O).
- **Object Model**:
  - Class `0x04` (Assembly Object):
    - **Instance 11 / 13**: Input Assembly (Status, Inspection Results, User Data to PLC).
    - **Instance 21 / 23**: Output Assembly (Control Flags, Job Change, Trigger from PLC).
  - Class `0x78` (Cognex Vision Object): Provides vendor-specific job slot control, acquisition trigger, and online mode.

### 5.2 PROFINET IO
- **Port**: UDP `34964` (RT Data Exchange), UDP `161/162` (SNMP).
- **GSDML Identification**: `GSDML-V2.42-Cognex-InSight-*.xml`.
- **Submodules**:
  - Submodule 1: User Data (Acquisition Control, Inspection Control, Error Clear).
  - Submodule 2: Results Data (Pass/Fail, Tool Metrics, User Output Buffer).

### 5.3 SLMP (Seamless Message Protocol)
- **Ports**: TCP `32704 - 32768`.
- **Target**: Mitsubishi iQ-R / iQ-F / Q series PLCs.
- **Protocol Scanner**:
  - Cyclic connection polling data blocks in PLC D/W/R registers.
  - Command Block (Trigger, Job Change, Online).
  - Response Block (Status, Execution Time, Results).
