using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 48)]
[NativeCppClass]
[UnsafeValueType]
internal struct RM
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 96)]
[NativeCppClass]
internal struct Rm
{
}
