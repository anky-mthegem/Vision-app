using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 60)]
[UnsafeValueType]
[NativeCppClass]
internal struct XF
{
	private int u;
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct xf
{
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct xF
{
}
