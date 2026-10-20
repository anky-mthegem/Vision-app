using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 32)]
[NativeCppClass]
internal static struct ER
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 80)]
[NativeCppClass]
internal static struct Er
{
	private long u;
}
