using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Imaging;
using Cognex.Cnx.Implementation;
using btFy13pd5uf4WC4h18;

namespace Cognex.InSight.Internal;

public static class CvsImageBufferFactory
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ICvsImageBuffer CreateNew(Size size, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsImageBuffer(size, format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ICvsImageBuffer Copy(ICvsImageBuffer other, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsImageBuffer(other, format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ICvsImageBuffer FromBitmap(Bitmap bitmap, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsImageBuffer(bitmap, format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ICvsImageBuffer FromResource(Assembly assembly, string resourceId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (ICvsImageBuffer)xuDywX0ynhMj9YSKpax(assembly, resourceId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ICvsImageBuffer FromGraphics(Graphics graphics)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Rectangle rectangle = CfK2xy0ZGWQTSWQ52Kb(rA2kwX0gCNHtfyd5GAp(graphics));
		return FromBitmap(new Bitmap(rectangle.Width, rectangle.Height, graphics), lt8uof0JX3xfmR4Bjof(graphics));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxPixelFormat GetCnxPixelFormat(PixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		b83Jbu0mXBOiwu6fSNI();
		int num;
		if (VgUJwj0FKR7MYtmtjRr())
		{
			num = 4;
		}
		else
		{
			num = 6;
			if (!VgUJwj0FKR7MYtmtjRr())
			{
				goto IL_0103;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				if (format <= PixelFormat.Format24bppRgb)
				{
					num = 7;
					continue;
				}
				if (format != PixelFormat.Format32bppRgb)
				{
					goto case 5;
				}
				return CnxPixelFormat.Format32bppRgb;
			default:
				num = 5;
				continue;
			case 5:
				if (format != PixelFormat.Format8bppIndexed)
				{
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 2;
				}
				return CnxPixelFormat.Format8bppGrayscale;
			case 2:
				if (format != PixelFormat.Format32bppArgb)
				{
					num = 8;
					continue;
				}
				return CnxPixelFormat.Format32bppARgb;
			case 7:
				if (format != PixelFormat.Format16bppRgb565)
				{
					num = 1;
					continue;
				}
				return CnxPixelFormat.Format16bppRgb565;
			case 1:
				if (format != PixelFormat.Format24bppRgb)
				{
					break;
				}
				return CnxPixelFormat.Format24bppRgb;
			case 3:
			case 6:
			case 8:
				break;
			}
			break;
		}
		goto IL_0103;
		IL_0103:
		throw new NotSupportedException((string)bSax8U0zBfq6EdULNZN(yOWW2r08WDSKFFiY9Pr(45590), format.ToString()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PixelFormat GetImagingPixelFormat(CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return format switch
		{
			CnxPixelFormat.Format8bppGrayscale => PixelFormat.Format8bppIndexed, 
			CnxPixelFormat.Format16bppRgb565 => PixelFormat.Format16bppRgb565, 
			CnxPixelFormat.Format24bppRgb => PixelFormat.Format24bppRgb, 
			CnxPixelFormat.Format32bppRgb => PixelFormat.Format32bppRgb, 
			_ => throw new NotSupportedException((string)bSax8U0zBfq6EdULNZN(kgbOBx7BanbFa22Hp9.ol99ukmDA(45590), format.ToString())), 
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxPixelFormat GetGraphicsFormat(Graphics graphics)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0062;
		IL_001a:
		int num2 = default;
		if (num2 != 16)
		{
			goto IL_0095;
		}
		return CnxPixelFormat.Format16bppRgb565;
		IL_0062:
		IntPtr intPtr = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
				intPtr = yymeSn4wNwoymcW3vZV(graphics);
				num = 1;
				continue;
			case 3:
			case 7:
				if (num2 != 8)
				{
					break;
				}
				return CnxPixelFormat.Format8bppGrayscale;
			default:
				num = 4;
				continue;
			case 5:
			case 6:
				goto IL_0095;
			case 0:
				onTxIU4hOLGjcyqCgeE(graphics, intPtr);
				_ = 0;
				if (!VgUJwj0FKR7MYtmtjRr())
				{
					num = 6;
					if (!b83Jbu0mXBOiwu6fSNI())
					{
						continue;
					}
					goto case 2;
				}
				num = 7;
				continue;
			case 1:
				num2 = E19ruK4sxBiAbZRd8BV(intPtr, CnxNativeMethods.DeviceCapsIndex.BITSPIXEL);
				num = 0;
				continue;
			case 8:
				return CnxPixelFormat.Format32bppRgb;
			}
			break;
		}
		goto IL_001a;
		IL_0095:
		_ = 32;
		num = 8;
		goto IL_0062;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VgUJwj0FKR7MYtmtjRr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b83Jbu0mXBOiwu6fSNI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xuDywX0ynhMj9YSKpax(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsImageBuffer.FromResource((Assembly)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF rA2kwX0gCNHtfyd5GAp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Graphics)P_0).ClipBounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle CfK2xy0ZGWQTSWQ52Kb(RectangleF P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Rectangle.Round(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxPixelFormat lt8uof0JX3xfmR4Bjof(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetGraphicsFormat((Graphics)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yOWW2r08WDSKFFiY9Pr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bSax8U0zBfq6EdULNZN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr yymeSn4wNwoymcW3vZV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Graphics)P_0).GetHdc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int E19ruK4sxBiAbZRd8BV(IntPtr hdc, CnxNativeMethods.DeviceCapsIndex nIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.GetDeviceCaps(hdc, nIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void onTxIU4hOLGjcyqCgeE(object P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Graphics)P_0).ReleaseHdc(P_1);
	}
}
