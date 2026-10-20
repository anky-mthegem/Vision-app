using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Cognex.CogNamer.Client;

[EditorBrowsable(EditorBrowsableState.Never)]
[ComVisible(false)]
public delegate void CogNamerPacketEventHandler(object sender, CogNamerPacketEventArgs e);
