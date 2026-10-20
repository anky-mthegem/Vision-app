using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[NativeCppClass]
internal struct ZS
{
}
[StructLayout(LayoutKind.Sequential, Size = 72)]
[NativeCppClass]
internal struct Zs
{
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	[CLSCompliant(false)]
	[NativeCppClass]
	public struct Zq
	{
		[StructLayout(LayoutKind.Sequential, Size = 4)]
		[NativeCppClass]
		[CLSCompliant(false)]
		public struct Zd
		{
			private int u;
		}

		[FieldOffset(0)]
		private int u;
	}

	private long u;
}
