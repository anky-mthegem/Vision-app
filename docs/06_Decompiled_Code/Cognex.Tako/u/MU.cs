using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 64)]
[NativeCppClass]
internal struct MU
{
	[StructLayout(LayoutKind.Sequential, Size = 32)]
	[CLSCompliant(false)]
	[NativeCppClass]
	public struct M2
	{
		private long u;
	}

	private long u;
}
