using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.ThreeD.Geometry;
using G7hE9PifqggqUiW7wA;
using GHWKpuG7rE0PZAeeF5;

namespace YYNs7EWJ0BnMDIuHpG;

internal static class U2UsKSXlrvh88x8y6C
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public OtwTTbu1x8raUjqWOp.nY9QKjxeoorN5Ab1lZ header;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass1_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			f3hLTcKbZYEjhNAQx5w();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRead_003Eb__0(Tuple<OtwTTbu1x8raUjqWOp.nY9QKjxeoorN5Ab1lZ, Func<BinaryReader, IImageGeometry3D>> t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t.Item1.Equals(header);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void f3hLTcKbZYEjhNAQx5w()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T3UU24KAXrg2vv2QSP2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y8C3Y6KwAi72xXqVhqF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public static readonly PointCloud3D SjfMtJohj;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IImageGeometry3D eUElSBHmx(BinaryReader P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IImageGeometry3D result = default;
		try
		{
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals2.header = (OtwTTbu1x8raUjqWOp.nY9QKjxeoorN5Ab1lZ)xdePWwR5p9m6artu39(P_0);
			int num = 0;
			IEnumerable<Tuple<OtwTTbu1x8raUjqWOp.nY9QKjxeoorN5Ab1lZ, Func<BinaryReader, IImageGeometry3D>>> source = default;
			while (true)
			{
				IL_0048:
				switch (num)
				{
				case 1:
				case 4:
					if (source.Count() != 1)
					{
						goto default;
					}
					result = source.FirstOrDefault().Item2(P_0);
					break;
				case 0:
					while (true)
					{
						source = OtwTTbu1x8raUjqWOp.oIU0myu3H.Where([MethodImpl(MethodImplOptions.NoInlining)] (Tuple<OtwTTbu1x8raUjqWOp.nY9QKjxeoorN5Ab1lZ, Func<BinaryReader, IImageGeometry3D>> t) =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							return t.Item1.Equals(CS_0024_003C_003E8__locals2.header);
						});
						_ = 0;
						if (EiLAA3Be70Qsu2xxPy())
						{
							break;
						}
						num = 3;
						if (EiLAA3Be70Qsu2xxPy())
						{
							goto IL_0048;
						}
					}
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto default;
				default:
					result = SjfMtJohj;
					num = 5;
					if (!SI5gfeFsc7iOQCJe23())
					{
						continue;
					}
					break;
				case 5:
					break;
				}
				break;
			}
		}
		catch (IOException)
		{
			result = SjfMtJohj;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static U2UsKSXlrvh88x8y6C()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PrYBQth3v9l529j9R0();
		SjfMtJohj = new PointCloud3D(0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xdePWwR5p9m6artu39(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return OtwTTbu1x8raUjqWOp.nY9QKjxeoorN5Ab1lZ.Y33VjkANI((BinaryReader)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EiLAA3Be70Qsu2xxPy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SI5gfeFsc7iOQCJe23()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrYBQth3v9l529j9R0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
	}
}
