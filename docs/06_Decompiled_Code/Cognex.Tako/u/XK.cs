using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 25)]
[UnsafeValueType]
[NativeCppClass]
internal struct XK
{
	private long u;
}
