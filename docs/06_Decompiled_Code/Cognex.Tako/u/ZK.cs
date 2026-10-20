using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 44)]
[UnsafeValueType]
[NativeCppClass]
internal struct ZK
{
	private int u;
}
[StructLayout(LayoutKind.Sequential, Size = 24)]
[NativeCppClass]
internal struct Zk
{
	private long u;
}
