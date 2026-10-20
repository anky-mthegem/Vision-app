using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 24)]
[NativeCppClass]
internal static struct S1
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[NativeCppClass]
	[CLSCompliant(false)]
	public static struct Sl
	{
		private long u;
	}

	private long u;
}
