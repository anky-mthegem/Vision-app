using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cognex.Cnx.Drawing;
using Cognex.Cnx.Geometry;
using Cognex.Cnx.Implementation;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.Imaging.Implementation;

public static class CnxColorConversion
{
	private unsafe static readonly byte* BtXIfrxGgC;

	private unsafe static readonly byte* EBMIjPAnIv;

	private unsafe static readonly byte* ytpIcj46BN;

	private unsafe static readonly byte* YvSI5GWltN;

	private unsafe static readonly short* UhtIY8wxUN;

	private unsafe static readonly byte* uYJI73e9dM;

	internal unsafe static short* GrayscaleTo565Table
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UhtIY8wxUN;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	unsafe static CnxColorConversion()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 28;
		if (1 == 0)
		{
			goto IL_0210;
		}
		goto IL_02c0;
		IL_004f:
		byte b = default;
		byte b2 = default;
		byte b3 = default;
		byte b4 = default;
		UhtIY8wxUN[(int)b] = (short)((b2 << 11) | (b3 << 5) | b4);
		b--;
		num = 18;
		if (PpT4hJhbbXH6e8Jte3a())
		{
			goto IL_023c;
		}
		goto IL_02c0;
		IL_023c:
		ushort num2 = default;
		int crColor = default;
		if (num2 < 256)
		{
			crColor = num2 | (num2 << 8) | (num2 << 16);
			num = 4;
		}
		else
		{
			num = 16;
		}
		goto IL_02c0;
		IL_02c0:
		ushort num3 = default;
		int num4 = default;
		IntPtr hdc = default;
		CnxNativeMethods.BITMAPINFO pbmi = default;
		ushort num5 = default;
		int pixel = default;
		int num6 = default;
		CnxColor cnxColor = default;
		ushort* ptr = default;
		IntPtr intPtr2 = default;
		IntPtr ppvBits = default;
		IntPtr intPtr = default;
		while (true)
		{
			IL_02c0_2:
			switch (num)
			{
			case 30:
				break;
			case 11:
				goto IL_004f;
			case 19:
			case 40:
				goto IL_00bc;
			case 27:
				YvSI5GWltN[(int)num3] = (byte)((num4 & 0xFF00) >> 8);
				num3++;
				num = 40;
				if (0 == 0)
				{
					continue;
				}
				goto case 35;
			case 35:
				wqJ4q4hyO4CjxiEVuCR(hdc);
				num = 15;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
			case 29:
				pbmi = new CnxNativeMethods.BITMAPINFO(new CnxVector2F(1f, 1f), CnxPixelFormat.Format16bppRgb565, null);
				num = 26;
				if (WmniILhXXNwZOkJuS3I())
				{
					continue;
				}
				goto case 4;
			case 4:
				RRyBl3hFJFj7gxxq0Q6(hdc, 0, 0, crColor);
				num = 34;
				if (WmniILhXXNwZOkJuS3I())
				{
					continue;
				}
				goto case 1;
			case 1:
				ytpIcj46BN[(int)num5] = (byte)((pixel & 0xFF0000) >> 16);
				num5++;
				num = 21;
				continue;
			case 25:
				uYJI73e9dM[num6] = cnxColor.Brightness;
				num6++;
				num = 3;
				continue;
			case 34:
				BtXIfrxGgC[(int)num2] = (byte)(*ptr & 0x1F);
				num = 37;
				continue;
			case 16:
				num5 = 0;
				goto case 21;
			case 39:
				intPtr2 = CnxNativeMethods.CreateDIBSection(IntPtr.Zero, ref pbmi, 0, out ppvBits, IntPtr.Zero, 0);
				num = 22;
				if (PpT4hJhbbXH6e8Jte3a())
				{
				}
				continue;
			case 18:
			case 31:
				goto IL_0210;
			case 26:
				ppvBits = IntPtr.Zero;
				num = 39;
				continue;
			default:
				goto IL_023c;
			case 3:
			case 23:
				goto IL_0252;
			case 8:
				num4 = kO1CBfhmpBoPiaTsrPX(hdc, 0, 0);
				num = 27;
				continue;
			case 32:
				intPtr = WaHEc3hpCduOGvvYUpE(256);
				num = 10;
				continue;
			case 37:
				EBMIjPAnIv[(int)num2] = (byte)((*ptr & 0x7E0) >> 5);
				num2++;
				goto IL_023c;
			case 13:
				while (true)
				{
					uYJI73e9dM = (byte*)intPtr.ToPointer();
					WmniILhXXNwZOkJuS3I();
					if (!PpT4hJhbbXH6e8Jte3a())
					{
						break;
					}
					num = 14;
					if (!PpT4hJhbbXH6e8Jte3a())
					{
						goto IL_02c0_2;
					}
				}
				num = 29;
				if (0 == 0)
				{
					continue;
				}
				goto case 22;
			case 22:
				if (iiOEtEh0GHLfU0UYQkO(intPtr2, IntPtr.Zero))
				{
					throw new InvalidOperationException((string)j2LGgFh4lFDUqiOY7WW(1112));
				}
				hdc = tw3CN0hkgZi5quNKGGo(IntPtr.Zero);
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 21;
			case 21:
				if (num5 < 32)
				{
					*ptr = num5;
					pixel = CnxNativeMethods.GetPixel(hdc, 0, 0);
					num = 1;
				}
				else
				{
					num = 12;
				}
				continue;
			case 0:
				f3wptqhfUkhDPtnQaMp(hdc, intPtr2);
				num = 30;
				continue;
			case 7:
				ytpIcj46BN = (byte*)intPtr.ToPointer();
				num = 36;
				continue;
			case 2:
				intPtr = WaHEc3hpCduOGvvYUpE(256);
				num = 17;
				continue;
			case 12:
				num3 = 0;
				num = 19;
				continue;
			case 6:
				b4 = BtXIfrxGgC[(int)b];
				num = 11;
				continue;
			case 28:
				jIyud1h6gXLTbJlCHje();
				num = 2;
				continue;
			case 17:
				BtXIfrxGgC = (byte*)intPtr.ToPointer();
				num = 32;
				continue;
			case 36:
				YvSI5GWltN = (byte*)WaHEc3hpCduOGvvYUpE(64).ToPointer();
				UhtIY8wxUN = (short*)WaHEc3hpCduOGvvYUpE(512).ToPointer();
				intPtr = WaHEc3hpCduOGvvYUpE(65536);
				num = 13;
				continue;
			case 10:
				EBMIjPAnIv = (byte*)intPtr.ToPointer();
				num = 38;
				continue;
			case 5:
				num2 = 0;
				num = 33;
				if (PpT4hJhbbXH6e8Jte3a())
				{
				}
				continue;
			case 24:
				b3 = EBMIjPAnIv[(int)b];
				num = 6;
				continue;
			case 15:
				KWPXk6hgb3OccBb4yBL(intPtr2);
				b = byte.MaxValue;
				num = 31;
				continue;
			case 38:
				intPtr = WaHEc3hpCduOGvvYUpE(32);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 41:
				return;
			}
			break;
			IL_0252:
			if (num6 < 65536)
			{
				cnxColor = new CnxColor(eSKqkhhZ2BuGqkEY3G6((short)num6));
				num = 25;
			}
			else
			{
				num = 41;
			}
			continue;
			IL_00bc:
			if (num3 >= 64)
			{
				num = 35;
				continue;
			}
			*ptr = (ushort)(num3 << 5);
			num = 8;
			if (true)
			{
				continue;
			}
			goto IL_0210;
		}
		goto IL_003a;
		IL_0210:
		if (b > 0)
		{
			b2 = BtXIfrxGgC[(int)b];
			num = 24;
			if (!WmniILhXXNwZOkJuS3I())
			{
				goto IL_003a;
			}
		}
		else
		{
			*UhtIY8wxUN = 0;
			num6 = 0;
			num = 23;
		}
		goto IL_02c0;
		IL_003a:
		ptr = (ushort*)ppvBits.ToPointer();
		num = 5;
		if (false)
		{
			goto IL_004f;
		}
		goto IL_02c0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static short Rgb888ToRgb565(int rgb888)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PpT4hJhbbXH6e8Jte3a();
		int num = ((!WmniILhXXNwZOkJuS3I()) ? 2 : 3);
		byte b2 = default;
		byte b = default;
		byte b3 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				b2 = (byte)(rgb888 >> 8);
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				b = (byte)(rgb888 >> 16);
				goto case 1;
			case 4:
				b3 = (byte)rgb888;
				num = 5;
				if (!PpT4hJhbbXH6e8Jte3a())
				{
					continue;
				}
				break;
			case 5:
				break;
			}
			break;
		}
		byte b4 = BtXIfrxGgC[(int)b];
		byte b5 = EBMIjPAnIv[(int)b2];
		byte b6 = BtXIfrxGgC[(int)b3];
		return (short)((b4 << 11) | (b5 << 5) | b6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static byte Rgb565ToGray8(short rgb565)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return uYJI73e9dM[(int)(ushort)rgb565];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int Rgb565ToRgb888(short rgb565)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		byte b = default;
		byte b3 = default;
		byte b2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				b = (byte)((ushort)rgb565 >> 11);
				PpT4hJhbbXH6e8Jte3a();
				if (WmniILhXXNwZOkJuS3I())
				{
					num = 4;
					if (!PpT4hJhbbXH6e8Jte3a())
					{
						continue;
					}
					goto default;
				}
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				break;
			default:
				b3 = (byte)(rgb565 & 0x1F);
				num = 5;
				if (!PpT4hJhbbXH6e8Jte3a())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				b2 = (byte)((rgb565 & 0x7E0) >> 5);
				goto default;
			case 5:
				break;
			}
			break;
		}
		byte b4 = ytpIcj46BN[(int)b];
		byte b5 = YvSI5GWltN[(int)b2];
		byte b6 = ytpIcj46BN[(int)b3];
		return (b4 << 16) | (b5 << 8) | b6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static short Gs8ToRgb565(byte gs8)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UhtIY8wxUN[(int)gs8];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ColorToGdi(Color color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xjD0wZhJBKYFjR6V1cN(color.ToArgb());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color GdiToColor(int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fpOkG7h8hNyNP4cQ81v(GdiToArgb(value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GdiToArgb(int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return -16777216 | ((value & 0xFF) << 16) | (value & 0xFF00) | ((value & 0xFF0000) >> 16);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ArgbToGdi(int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((value & 0xFF) << 16) | (value & 0xFF00) | ((value & 0xFF0000) >> 16);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jIyud1h6gXLTbJlCHje()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr WaHEc3hpCduOGvvYUpE(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Marshal.AllocCoTaskMem(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iiOEtEh0GHLfU0UYQkO(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j2LGgFh4lFDUqiOY7WW(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr tw3CN0hkgZi5quNKGGo(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.CreateCompatibleDC(hdc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr f3wptqhfUkhDPtnQaMp(IntPtr hdc, IntPtr hgdiobj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SelectObject(hdc, hgdiobj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RRyBl3hFJFj7gxxq0Q6(IntPtr hdc, int X, int Y, int crColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetPixel(hdc, X, Y, crColor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kO1CBfhmpBoPiaTsrPX(IntPtr hdc, int nXPos, int nYPos)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.GetPixel(hdc, nXPos, nYPos);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wqJ4q4hyO4CjxiEVuCR(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.DeleteDC(hdc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KWPXk6hgb3OccBb4yBL(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.DeleteBitmap(hObject);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int eSKqkhhZ2BuGqkEY3G6(short rgb565)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Rgb565ToRgb888(rgb565);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WmniILhXXNwZOkJuS3I()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PpT4hJhbbXH6e8Jte3a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xjD0wZhJBKYFjR6V1cN(int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ArgbToGdi(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color fpOkG7h8hNyNP4cQ81v(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0);
	}
}
