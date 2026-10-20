using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using Cognex.InSight.Internal;
using jUKn21pup6XFIrInBb;

namespace Cognex.InSight.ViDiEL.ViewModels.Extensions;

public static class ImageHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static BitmapImage d41VHUV609(Bitmap P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ppjNvvgm3Jt3Tndpasd();
		int num = ((!XpsltSgkfxMOTfFAN0w()) ? 3 : 2);
		BitmapImage bitmapImage = default;
		MemoryStream memoryStream = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				bitmapImage = null;
				goto case 1;
			case 1:
			case 3:
				memoryStream = new MemoryStream();
				break;
			default:
				goto IL_006b;
			case 4:
				break;
			}
			break;
			IL_006b:
			num = 4;
		}
		try
		{
			vdBht6grYUMGLo68Xqq(P_0, memoryStream, ImageFormat.Png);
			XpsltSgkfxMOTfFAN0w();
			int num2;
			if (!ppjNvvgm3Jt3Tndpasd())
			{
				num2 = 2;
				if (1 == 0)
				{
					goto IL_009d;
				}
			}
			else
			{
				num2 = 1;
			}
			goto IL_00b5;
			IL_00b5:
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				default:
					num2 = 6;
					continue;
				case 5:
					bitmapImage = new BitmapImage();
					num2 = 3;
					continue;
				case 6:
					goto IL_00f4;
				case 1:
				case 4:
					goto IL_010b;
				case 0:
				case 2:
					jSNCQVgPi1S3wSBgKsQ(memoryStream, 0L);
					num2 = 5;
					continue;
				case 7:
					Eq9hXTg11NBtGHWurjc(bitmapImage);
					return bitmapImage;
				}
				break;
			}
			goto IL_009d;
			IL_010b:
			XKt5pIggiA10JCDlQ3I(bitmapImage, BitmapCacheOption.OnLoad);
			num2 = 7;
			goto IL_00b5;
			IL_009d:
			PAwrCtg4T115HE9bMOS(bitmapImage);
			goto IL_00f4;
			IL_00f4:
			bitmapImage.StreamSource = memoryStream;
			goto IL_010b;
		}
		finally
		{
			if (memoryStream != null)
			{
				TVcfwlgS5Ldi7GroWlb(memoryStream);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BitmapImage GetImageFromInSight(this CvsInSight inSight, string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (BitmapImage)MJpOgegFKcrARcDifkS(RfgCWZg8tTobQFJvNJK(zhL1Twg6VTK1vvObrct(inSight), url, null, null, null, null, null, null, HMvZutgDSUQh954dsfr(1982), HMvZutgDSUQh954dsfr(1982)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vdBht6grYUMGLo68Xqq(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image)P_0).Save((Stream)P_1, (ImageFormat)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jSNCQVgPi1S3wSBgKsQ(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PAwrCtg4T115HE9bMOS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BitmapImage)P_0).BeginInit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XKt5pIggiA10JCDlQ3I(object P_0, BitmapCacheOption P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BitmapImage)P_0).CacheOption = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Eq9hXTg11NBtGHWurjc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BitmapImage)P_0).EndInit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TVcfwlgS5Ldi7GroWlb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XpsltSgkfxMOTfFAN0w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ppjNvvgm3Jt3Tndpasd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zhL1Twg6VTK1vvObrct(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HMvZutgDSUQh954dsfr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RfgCWZg8tTobQFJvNJK(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).GetImageByHttp((string)P_1, (string)P_2, (string)P_3, (string)P_4, (string)P_5, (string)P_6, (string)P_7, (string)P_8, (string)P_9);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MJpOgegFKcrARcDifkS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return d41VHUV609((Bitmap)P_0);
	}
}
