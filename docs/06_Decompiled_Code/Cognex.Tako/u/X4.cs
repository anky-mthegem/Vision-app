using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
[UnsafeValueType]
internal struct X4
{
	private int u;
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct x4
{
}
