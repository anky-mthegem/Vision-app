using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
[UnsafeValueType]
internal struct RV
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 54)]
[NativeCppClass]
[UnsafeValueType]
internal struct Rv
{
	private long u;
}
