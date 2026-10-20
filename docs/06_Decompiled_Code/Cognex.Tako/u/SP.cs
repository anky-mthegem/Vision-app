using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 32)]
[NativeCppClass]
internal struct SP
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 8)]
[NativeCppClass]
internal static struct Sp
{
	private long u;
}
