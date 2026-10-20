using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[NativeCppClass]
internal struct Xa
{
}
[StructLayout(LayoutKind.Sequential, Size = 45)]
[NativeCppClass]
[UnsafeValueType]
internal struct XA
{
	private long u;
}
