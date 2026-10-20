using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct fl
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 96)]
[UnsafeValueType]
[NativeCppClass]
internal struct fL
{
	private long u;
}
