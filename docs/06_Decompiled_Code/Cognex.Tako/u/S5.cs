using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[NativeCppClass]
internal static struct S5
{
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum Sg
	{

	}

	[StructLayout(LayoutKind.Sequential, Size = 12)]
	[UnsafeValueType]
	[CLSCompliant(false)]
	[NativeCppClass]
	public struct SM
	{
		private float u;
	}

	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[CLSCompliant(false)]
	[NativeCppClass]
	public static struct S7
	{
		private long u;
	}

	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[NativeCppClass]
	[CLSCompliant(false)]
	public static struct Sw
	{
		private long u;
	}

	private long u;
}
