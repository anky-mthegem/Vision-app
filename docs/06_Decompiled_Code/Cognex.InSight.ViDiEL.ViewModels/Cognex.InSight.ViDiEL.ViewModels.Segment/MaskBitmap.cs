using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cognex.Segmenter.Client.Tool.Interfaces;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Segment;

public class MaskBitmap : IMaskBitmap
{
	[CompilerGenerated]
	private byte[] eJO2m7IsxP;

	[CompilerGenerated]
	private int u1V2M9UgHN;

	[CompilerGenerated]
	private int qTX27AdsOy;

	public byte[] byteArray
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eJO2m7IsxP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eJO2m7IsxP = value;
		}
	}

	public int col
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return u1V2M9UgHN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			u1V2M9UgHN = value;
		}
	}

	public int row
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qTX27AdsOy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qTX27AdsOy = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bitmap ToBitmap(IMaskBitmap maskImage)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		int num2 = default;
		int num6 = default;
		Rectangle rectangle = default;
		Bitmap bitmap = default;
		BitmapData bitmapData = default;
		byte[] array = default;
		int num4 = default;
		int num3 = default;
		int num5 = default;
		ColorPalette colorPalette = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				num2++;
				num = 0;
				break;
			default:
				num6 = 0;
				num = 8;
				break;
			case 4:
				num6++;
				num = 6;
				break;
			case 14:
				rectangle = new Rectangle(0, 0, bitmap.Width, UG5TP1M9c9HU0sdOhE6(bitmap));
				num = 17;
				break;
			case 15:
				if (bitmapData.Stride == bitmapData.Width)
				{
					_ = 0;
					num = ((!ukSBPSMQRBsjLWjywxD()) ? 19 : 12);
					break;
				}
				array = new byte[k4TJkbMZnVbEsHIIX5G(bitmapData) * cMAfViM0Vp0Hl5Umvxm(bitmapData)];
				goto default;
			case 9:
			case 12:
				array = maskImage.byteArray;
				goto IL_0134;
			case 6:
			case 8:
				if (num6 >= cMAfViM0Vp0Hl5Umvxm(bitmapData))
				{
					goto IL_0134;
				}
				num4 = num6 * k4TJkbMZnVbEsHIIX5G(bitmapData);
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 3:
				num3++;
				num = 11;
				break;
			case 5:
				num5 = num6 * leA3J4MOXe7eXoE4W3u(bitmapData);
				num3 = 0;
				num = 1;
				if (true)
				{
					break;
				}
				goto case 17;
			case 17:
				bitmapData = (BitmapData)P4a5YSMv99WfuhWEoSl(bitmap, rectangle, ImageLockMode.WriteOnly, bitmap.PixelFormat);
				num = 15;
				break;
			case 1:
			case 11:
				if (num3 >= leA3J4MOXe7eXoE4W3u(bitmapData))
				{
					num = 4;
					break;
				}
				array[num4 + num3] = ((byte[])qJManTMHAF3GvHi0glq(maskImage))[num5 + num3];
				num = 3;
				break;
			case 13:
				colorPalette = (ColorPalette)amyAlBMiDMAmBW32bbc(bitmap);
				num = 2;
				break;
			case 2:
				num2 = 0;
				num = 18;
				break;
			case 0:
			case 18:
				if (num2 < 256)
				{
					colorPalette.Entries[num2] = NQ1DTtMLyELboRtoKQQ(255, num2, num2, num2);
					num = 7;
					if (ukSBPSMQRBsjLWjywxD())
					{
						break;
					}
					goto case 13;
				}
				NEZrTMMtyDk1gKNQRKJ(bitmap, colorPalette);
				num = 14;
				break;
			case 16:
				bitmap = new Bitmap(maskImage.col, nTXMMYMV06bQaq0kxAa(maskImage), PixelFormat.Format8bppIndexed);
				num = 13;
				break;
			case 20:
				{
					return bitmap;
				}
				IL_0134:
				qK9mwCMY4G5fK5EigMl(array, 0, SIipCCMTrmQduG0thhD(bitmapData), array.Length);
				FJUKEJMJrAcYyQqrv7a(bitmap, bitmapData);
				num = 20;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MaskBitmap FromBitmap(Bitmap bitmap)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!u8oYERMqJkmWYuGhBui())
		{
			num = 4;
		}
		else
		{
			num = 14;
			if (u8oYERMqJkmWYuGhBui())
			{
			}
		}
		int num5 = default;
		BitmapData bitmapData = default;
		int num4 = default;
		int num3 = default;
		int num2 = default;
		byte[] array2 = default;
		byte[] array = default;
		while (true)
		{
			switch (num)
			{
			case 10:
			case 11:
				if (num5 >= cMAfViM0Vp0Hl5Umvxm(bitmapData))
				{
					num = 15;
					if (u8oYERMqJkmWYuGhBui())
					{
					}
				}
				else
				{
					num4 = num5 * k4TJkbMZnVbEsHIIX5G(bitmapData);
					num3 = num5 * leA3J4MOXe7eXoE4W3u(bitmapData);
					num = 5;
				}
				break;
			case 5:
				num2 = 0;
				num = 7;
				break;
			case 12:
				num2++;
				num = 13;
				break;
			case 2:
				bitmap.UnlockBits(bitmapData);
				num = 6;
				break;
			case 8:
				num5 = 0;
				goto case 10;
			default:
				num = 10;
				break;
			case 0:
			case 4:
				bitmapData = (BitmapData)P4a5YSMv99WfuhWEoSl(bitmap, new Rectangle(0, 0, z96p5CMKTtXyaumMy3r(bitmap), UG5TP1M9c9HU0sdOhE6(bitmap)), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
				goto case 1;
			case 1:
			case 14:
				array2 = new byte[k4TJkbMZnVbEsHIIX5G(bitmapData) * bitmapData.Height];
				num = 3;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				if (k4TJkbMZnVbEsHIIX5G(bitmapData) == leA3J4MOXe7eXoE4W3u(bitmapData))
				{
					array = array2;
					num = 9;
				}
				else
				{
					array = new byte[leA3J4MOXe7eXoE4W3u(bitmapData) * cMAfViM0Vp0Hl5Umvxm(bitmapData)];
					num = 8;
				}
				break;
			case 7:
			case 13:
				if (num2 < bitmapData.Width)
				{
					array[num3 + num2] = array2[num4 + num2];
					num = 12;
					if (0 == 0)
					{
						break;
					}
					goto case 10;
				}
				num5++;
				num = 11;
				break;
			case 3:
				Marshal.Copy(SIipCCMTrmQduG0thhD(bitmapData), array2, 0, array2.Length);
				num = 2;
				break;
			case 9:
			case 15:
			{
				MaskBitmap maskBitmap = new MaskBitmap();
				AvpndLMCZPsCpMKKFps(maskBitmap, array);
				maskBitmap.row = UG5TP1M9c9HU0sdOhE6(bitmap);
				FeeJVnMABBC2NmvxLBn(maskBitmap, bitmap.Width);
				return maskBitmap;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MaskBitmap()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		g19iRLMNJw3oENwhQNj();
		MMvUf0MwBT5RNXMOIt1(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ukSBPSMQRBsjLWjywxD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u8oYERMqJkmWYuGhBui()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nTXMMYMV06bQaq0kxAa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IMaskBitmap)P_0).row;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object amyAlBMiDMAmBW32bbc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Image)P_0).Palette;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color NQ1DTtMLyELboRtoKQQ(int P_0, int P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NEZrTMMtyDk1gKNQRKJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image)P_0).Palette = (ColorPalette)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UG5TP1M9c9HU0sdOhE6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Image)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P4a5YSMv99WfuhWEoSl(object P_0, Rectangle P_1, ImageLockMode P_2, PixelFormat P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Bitmap)P_0).LockBits(P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int k4TJkbMZnVbEsHIIX5G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BitmapData)P_0).Stride;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cMAfViM0Vp0Hl5Umvxm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BitmapData)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int leA3J4MOXe7eXoE4W3u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BitmapData)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qJManTMHAF3GvHi0glq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IMaskBitmap)P_0).byteArray;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr SIipCCMTrmQduG0thhD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BitmapData)P_0).Scan0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qK9mwCMY4G5fK5EigMl(object P_0, int P_1, IntPtr P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Marshal.Copy((byte[])P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FJUKEJMJrAcYyQqrv7a(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Bitmap)P_0).UnlockBits((BitmapData)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int z96p5CMKTtXyaumMy3r(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Image)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AvpndLMCZPsCpMKKFps(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((MaskBitmap)P_0).byteArray = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FeeJVnMABBC2NmvxLBn(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((MaskBitmap)P_0).col = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g19iRLMNJw3oENwhQNj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MMvUf0MwBT5RNXMOIt1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
