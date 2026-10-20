using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 55)]
[NativeCppClass]
[UnsafeValueType]
internal struct X8
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 1)]
[NativeCppClass]
internal struct x8
{
}
