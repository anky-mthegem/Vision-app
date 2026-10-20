using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 64)]
[NativeCppClass]
[UnsafeValueType]
internal struct _2H
{
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	[NativeCppClass]
	[UnsafeValueType]
	internal struct _28
	{
		[FieldOffset(0)]
		private long u;
	}

	private long u;
}
