using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 40)]
[UnsafeValueType]
[NativeCppClass]
internal struct RS
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 24)]
[NativeCppClass]
internal struct Rs
{
}
