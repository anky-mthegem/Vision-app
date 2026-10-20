using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;

public static class ImageHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static BitmapImage WqZvnCDVsA(Bitmap P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PSuny6xspmyEnptGRlt();
		int num = ((!sHQ2LTxgYDrenbqJXBS()) ? 2 : 3);
		BitmapImage bitmapImage = default;
		MemoryStream memoryStream = default;
		do
		{
			switch (num)
			{
			case 0:
			case 3:
				bitmapImage = null;
				goto case 1;
			case 1:
			case 2:
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
		while (sHQ2LTxgYDrenbqJXBS());
		try
		{
			xB20yxxrwWkOWKxUmJg(P_0, memoryStream, w9TpEixvS6KmHBrrSbQ());
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 5:
					bitmapImage = new BitmapImage();
					goto case 0;
				case 6:
					rM4EejxBA8jike37XcM(bitmapImage, memoryStream);
					num2 = 3;
					break;
				case 0:
				case 2:
					p4F2bWxZYGG7jhmLA23(bitmapImage);
					goto case 6;
				default:
					num2 = 6;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					b8OP6sxPC9VjU6HUAu4(memoryStream, 0L);
					_ = 0;
					if (!sHQ2LTxgYDrenbqJXBS())
					{
						num2 = 0;
						if (true)
						{
							break;
						}
						goto case 6;
					}
					num2 = 5;
					break;
				case 3:
					LqiucLxbyGJUETWTSGZ(bitmapImage, BitmapCacheOption.OnLoad);
					num2 = 7;
					break;
				case 7:
					bitmapImage.EndInit();
					return bitmapImage;
				}
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				gHEgBKxGNXk8Fi4FbRo(memoryStream);
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
		return (BitmapImage)ERS1pwxkmOAyAIVgtmN(xwUDiAxS6APfwbhIcrH(v10j3Oxoe7jEGTHlgdp(inSight), url, null, null, null, null, null, null, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1838), CdQUGaROfy7He9T0foW.KbIzwHEDLa(1838)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w9TpEixvS6KmHBrrSbQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ImageFormat.Png;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xB20yxxrwWkOWKxUmJg(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((System.Drawing.Image)P_0).Save((Stream)P_1, (ImageFormat)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b8OP6sxPC9VjU6HUAu4(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p4F2bWxZYGG7jhmLA23(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BitmapImage)P_0).BeginInit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rM4EejxBA8jike37XcM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BitmapImage)P_0).StreamSource = (Stream)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LqiucLxbyGJUETWTSGZ(object P_0, BitmapCacheOption P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BitmapImage)P_0).CacheOption = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gHEgBKxGNXk8Fi4FbRo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sHQ2LTxgYDrenbqJXBS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PSuny6xspmyEnptGRlt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v10j3Oxoe7jEGTHlgdp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xwUDiAxS6APfwbhIcrH(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).GetImageByHttp((string)P_1, (string)P_2, (string)P_3, (string)P_4, (string)P_5, (string)P_6, (string)P_7, (string)P_8, (string)P_9);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ERS1pwxkmOAyAIVgtmN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return WqZvnCDVsA((Bitmap)P_0);
	}
}
