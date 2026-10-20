using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 12)]
[NativeCppClass]
[UnsafeValueType]
internal struct Sf
{
	private float u;
}
[StructLayout(LayoutKind.Sequential, Size = 8)]
[NativeCppClass]
internal static struct SF
{
	private long u;
}
