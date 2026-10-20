using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 24)]
[NativeCppClass]
internal struct fu
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 24)]
[NativeCppClass]
[UnsafeValueType]
internal struct fU
{
	private long u;
}
