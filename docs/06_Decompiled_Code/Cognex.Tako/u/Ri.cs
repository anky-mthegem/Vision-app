using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 36)]
[NativeCppClass]
internal struct Ri
{
	private int u;
}
[StructLayout(LayoutKind.Sequential, Size = 128)]
[UnsafeValueType]
[NativeCppClass]
internal struct RI
{
	private long u;
}
