using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[NativeCppClass]
internal static struct S3
{
	private long u;
}
