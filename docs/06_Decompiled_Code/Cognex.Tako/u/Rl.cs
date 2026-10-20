using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
[UnsafeValueType]
internal struct Rl
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 41)]
[UnsafeValueType]
[NativeCppClass]
internal struct RL
{
	private long u;
}
