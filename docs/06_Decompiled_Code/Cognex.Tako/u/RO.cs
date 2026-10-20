using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 38)]
[UnsafeValueType]
[NativeCppClass]
internal struct RO
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 28)]
[NativeCppClass]
internal struct Ro
{
	private int u;
}
