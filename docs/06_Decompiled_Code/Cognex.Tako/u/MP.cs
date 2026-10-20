using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 56)]
[NativeCppClass]
[UnsafeValueType]
internal struct MP
{
	private int u;
}
