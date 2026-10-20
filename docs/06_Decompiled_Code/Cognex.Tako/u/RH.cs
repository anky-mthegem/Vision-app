using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 36)]
[NativeCppClass]
internal struct RH
{
	private int u;
}
[StructLayout(LayoutKind.Sequential, Size = 49)]
[NativeCppClass]
[UnsafeValueType]
internal struct Rh
{
	private long u;
}
