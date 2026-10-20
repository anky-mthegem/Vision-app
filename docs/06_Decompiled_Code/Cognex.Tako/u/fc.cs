using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 24)]
[NativeCppClass]
internal struct fc
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct fC
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[NativeCppClass]
	[CLSCompliant(false)]
	public struct fN
	{
		private long u;
	}

	[StructLayout(LayoutKind.Sequential, Size = 56)]
	[CLSCompliant(false)]
	[NativeCppClass]
	public struct fe
	{
		private long u;
	}

	[StructLayout(LayoutKind.Sequential, Size = 16)]
	[NativeCppClass]
	[CLSCompliant(false)]
	public struct f1
	{
		private long u;
	}

	private long u;
}
