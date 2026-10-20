using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 44)]
[UnsafeValueType]
[NativeCppClass]
internal struct RY
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 12)]
[NativeCppClass]
internal struct Ry
{
	private int u;
}
