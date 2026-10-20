using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 64)]
[NativeCppClass]
internal static struct EX
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 32)]
[NativeCppClass]
internal static struct Ex
{
	private long u;
}
