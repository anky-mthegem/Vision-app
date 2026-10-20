using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 90)]
[UnsafeValueType]
[NativeCppClass]
internal struct X1
{
	private long u;
}
