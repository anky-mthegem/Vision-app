using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 24)]
[NativeCppClass]
internal struct SB
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct Sb
{
	private long u;
}
