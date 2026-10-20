using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[NativeCppClass]
internal struct ZR
{
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
[UnsafeValueType]
internal struct Zr
{
	private int u;
}
