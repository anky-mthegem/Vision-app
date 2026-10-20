using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 64)]
[NativeCppClass]
internal static struct El
{
	private long u;
}
