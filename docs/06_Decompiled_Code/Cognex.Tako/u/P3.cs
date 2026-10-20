using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 68)]
[NativeCppClass]
[UnsafeValueType]
internal struct P3
{
	[StructLayout(LayoutKind.Sequential, Size = 24)]
	[NativeCppClass]
	[CLSCompliant(false)]
	public struct PK
	{
		private float u;
	}

	private int u;
}
