using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[NativeCppClass]
internal static struct PL
{
	[StructLayout(LayoutKind.Sequential, Size = 56)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[UnsafeValueType]
	public struct PO
	{
		private long u;
	}

	[NativeCppClass]
	[CLSCompliant(false)]
	public enum PQ
	{

	}

	private long u;
}
