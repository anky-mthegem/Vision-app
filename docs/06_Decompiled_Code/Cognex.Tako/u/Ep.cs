using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 80)]
[NativeCppClass]
internal static struct Ep
{
	private long u;
}
