using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 104)]
[NativeCppClass]
internal struct XY
{
}
[StructLayout(LayoutKind.Sequential, Size = 73)]
[NativeCppClass]
[UnsafeValueType]
internal struct Xy
{
	private long u;
}
