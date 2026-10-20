using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using Cognex.Extensions;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;

namespace Cognex.InSight;

public static class RemoteSerializationExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Matrix GetTransformMatrix(this CvsCogLinearTransform transform)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Matrix((float)WfUpNRiaCS6sHJKeq0f(transform), (float)dplFjhin8N9LV64ldtK(transform), (float)bj8MDtiGwIwSA9YTN88(transform), (float)AYHO5NiX2hsh1RjH4nc(transform), (float)lia9j0ibgHeoRdMXLy6(transform), (float)hWeA6Ji65rjB3WjMury(transform));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Matrix GetVectorTransformMatrix(this CvsCogLinearTransform transform)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Matrix((float)WfUpNRiaCS6sHJKeq0f(transform), (float)dplFjhin8N9LV64ldtK(transform), (float)bj8MDtiGwIwSA9YTN88(transform), (float)transform.M11, 0f, 0f);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RectangleF GetViewportRectangle(this CvsCogImageLayer imageLayer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FvWTHXiRqH6vVXCD4tm();
		int num;
		if (axC4oFiI8r2U4pGR4gm())
		{
			num = 2;
			if (!axC4oFiI8r2U4pGR4gm())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_004b;
			}
		}
		goto IL_00d9;
		IL_0076:
		if (QL5nKqiy2RyL47qbrqI(imageLayer) == null)
		{
			num = 6;
			goto IL_00d9;
		}
		RectangleF rectangleF = default;
		return A5o69BiZOaQj77D9hKi(oxUboEigPtFB5PWhv2H(QL5nKqiy2RyL47qbrqI(imageLayer)), rectangleF);
		IL_00d9:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 4:
				goto IL_004b;
			case 3:
			case 5:
				goto IL_0076;
			default:
				num = 5;
				if (FvWTHXiRqH6vVXCD4tm())
				{
				}
				continue;
			case 6:
				return rectangleF;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		if (imageLayer.Image == null)
		{
			goto IL_004b;
		}
		rectangleF = new RectangleF(wIf98ji4jffdXW6CjT3(imageLayer.Image), Srl1Eqiksagq9hJx6BL(imageLayer.Image), j3SHyOiFWadyPptHbd4(wEGJBVifQXh86NbBwOX(imageLayer)), rP5d9rim9JgblHaSVvO(imageLayer.Image));
		goto IL_0076;
		IL_004b:
		rectangleF = new RectangleF(0f, 0f, Fn7C9bipPtuELtMriZA(imageLayer), GE8U8Wi0BHddvf3H0wb(imageLayer));
		num = 3;
		if (1 == 0)
		{
			goto IL_0076;
		}
		goto IL_00d9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RectangleF GetBoundingRectangle(this CvsCogImageLayer imageLayer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCogRegion cvsCogRegion = (CvsCogRegion)((wEGJBVifQXh86NbBwOX(imageLayer) == null) ? null : s6EOPuiJIsfYn5Icchb(wEGJBVifQXh86NbBwOX(imageLayer)));
		if (cvsCogRegion != null)
		{
			return new RectangleF((float)iK3bLti8IFrh4Kn0UNt(cvsCogRegion), (float)aT6jCUizsIkYdNXaFs8(cvsCogRegion), (float)cvsCogRegion.Width, (float)Uqt79VqwV4FnJcwR8d1(cvsCogRegion));
		}
		return mhwf0lqsPhCpPiGpyZq(imageLayer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Size GetSize(this CvsCogViewPort viewport)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Size(viewport.Width, b6EmpaqhNcQ6VV4F6K4(viewport));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsEditableGraphic(this CvsCogEditInfo editInfo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (!axC4oFiI8r2U4pGR4gm())
		{
			goto IL_001e;
		}
		goto IL_016e;
		IL_001e:
		string text = (string)ksrekTqLMhFscYZeWM9(editInfo);
		num = 6;
		goto IL_016e;
		IL_016e:
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				break;
			case 28:
				if (num2 != 25494375)
				{
					num = 25;
					continue;
				}
				if (!AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(12966)))
				{
					num = 21;
					continue;
				}
				goto case 32;
			case 25:
				if (num2 != 314158253)
				{
					num = 15;
					continue;
				}
				if (!AO2B4aqEX7RQyf0SWS8(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(12780)))
				{
					num = 1;
					continue;
				}
				goto case 32;
			case 17:
				if (num2 != 4225423623u)
				{
					goto case 0;
				}
				if (!(text == (string)Q2HnfAqSL3TFQYDweKL(12752)))
				{
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 26;
				}
				goto case 32;
			default:
				num = 5;
				continue;
			case 26:
				if (num2 != 3984166231u || !AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(13204)))
				{
					goto case 0;
				}
				num = 32;
				continue;
			case 2:
				if (num2 == 600169591)
				{
					if (AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(12842)))
					{
						goto case 32;
					}
					num = 23;
					if (axC4oFiI8r2U4pGR4gm())
					{
						continue;
					}
				}
				goto case 0;
			case 12:
				if (num2 <= 2727138257u)
				{
					if (num2 != 2695733389u)
					{
						if (num2 == 2727138257u && AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(13148)))
						{
							goto case 32;
						}
					}
					else if (AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(13090)))
					{
						goto case 32;
					}
				}
				else
				{
					if (num2 == 2804794614u)
					{
						if (!AO2B4aqEX7RQyf0SWS8(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(13048)))
						{
							num = 29;
							continue;
						}
						goto case 32;
					}
					num = 16;
					if (true)
					{
						continue;
					}
				}
				goto case 0;
			case 11:
				if (num2 == 3726117623u)
				{
					if (!AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(12872)))
					{
						num = 27;
						continue;
					}
					goto case 32;
				}
				num = 26;
				if (axC4oFiI8r2U4pGR4gm())
				{
					continue;
				}
				goto case 0;
			case 13:
				if (num2 == 1286120798)
				{
					if (!AO2B4aqEX7RQyf0SWS8(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(13000)))
					{
						num = 22;
						continue;
					}
					goto case 32;
				}
				num = 3;
				continue;
			case 9:
			case 14:
				if (num2 == 2624604888u)
				{
					if (text == (string)Q2HnfAqSL3TFQYDweKL(12720))
					{
						goto case 32;
					}
					num = 18;
					if (axC4oFiI8r2U4pGR4gm())
					{
						continue;
					}
				}
				goto case 0;
			case 6:
				num2 = M8ODa8q9SOhgvw4VcsS(text);
				if (num2 > 2624604888u)
				{
					if (num2 > 2919445631u)
					{
						if (num2 <= 3984166231u)
						{
							num = 11;
							continue;
						}
						if (num2 == 3984920967u)
						{
							if (!AO2B4aqEX7RQyf0SWS8(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(12904)))
							{
								num = 8;
								continue;
							}
							goto case 32;
						}
						num = 17;
						if (FvWTHXiRqH6vVXCD4tm())
						{
						}
						continue;
					}
					num = 12;
					if (true)
					{
						continue;
					}
				}
				else
				{
					if (num2 > 600169591)
					{
						if (num2 <= 1286120798)
						{
							if (num2 != 1080009044)
							{
								num = 13;
								continue;
							}
							if (!AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(13118)))
							{
								num = 19;
								continue;
							}
						}
						else
						{
							if (num2 != 1954199548)
							{
								_ = 0;
								if (axC4oFiI8r2U4pGR4gm())
								{
									num = 14;
									if (true)
									{
										continue;
									}
									goto case 0;
								}
								num = 4;
								continue;
							}
							if (!AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(12806)))
							{
								num = 30;
								continue;
							}
						}
						goto case 32;
					}
					num = 31;
					if (true)
					{
						continue;
					}
				}
				goto case 0;
			case 16:
				if (num2 == 2919445631u)
				{
					if (AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(12934)))
					{
						goto case 32;
					}
					goto case 0;
				}
				num = 20;
				if (!FvWTHXiRqH6vVXCD4tm())
				{
					continue;
				}
				goto case 31;
			case 31:
				if (num2 > 314158253)
				{
					if (num2 == 319997127)
					{
						if (!AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(13176)))
						{
							num = 0;
							continue;
						}
						goto case 32;
					}
					num = 2;
					continue;
				}
				num = 28;
				continue;
			case 32:
				return true;
			case 0:
			case 1:
			case 3:
			case 4:
			case 5:
			case 7:
			case 8:
			case 15:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 23:
			case 24:
			case 27:
			case 29:
			case 30:
				return false;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsMaximizableGraphic(this CvsCogEditInfo editInfo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		axC4oFiI8r2U4pGR4gm();
		int num = (FvWTHXiRqH6vVXCD4tm() ? 5 : 2);
		string text = default;
		bool? isExpandable = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!(text == (string)Q2HnfAqSL3TFQYDweKL(12806)))
				{
					goto case 3;
				}
				goto IL_00f8;
			case 0:
			case 2:
				text = (string)ksrekTqLMhFscYZeWM9(editInfo);
				num = 6;
				continue;
			case 7:
				if (!isExpandable.HasValue)
				{
					num = 8;
					continue;
				}
				return isExpandable == true;
			case 6:
				if (!AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(12904)))
				{
					num = 1;
					if (axC4oFiI8r2U4pGR4gm())
					{
						continue;
					}
					goto case 3;
				}
				goto IL_00f8;
			case 3:
			case 5:
				if (!AO2B4aqEX7RQyf0SWS8(text, Q2HnfAqSL3TFQYDweKL(13268)))
				{
					break;
				}
				isExpandable = editInfo.IsExpandable;
				num = 7;
				continue;
			default:
				num = 4;
				continue;
			case 8:
				return true;
			case 4:
				break;
				IL_00f8:
				return true;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double WfUpNRiaCS6sHJKeq0f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLinearTransform)P_0).M00;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double dplFjhin8N9LV64ldtK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLinearTransform)P_0).M01;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double bj8MDtiGwIwSA9YTN88(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLinearTransform)P_0).M10;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double AYHO5NiX2hsh1RjH4nc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLinearTransform)P_0).M11;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double lia9j0ibgHeoRdMXLy6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLinearTransform)P_0).XOffset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double hWeA6Ji65rjB3WjMury(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLinearTransform)P_0).YOffset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool axC4oFiI8r2U4pGR4gm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FvWTHXiRqH6vVXCD4tm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Fn7C9bipPtuELtMriZA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImageLayer)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GE8U8Wi0BHddvf3H0wb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImageLayer)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wIf98ji4jffdXW6CjT3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).OffsetX;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Srl1Eqiksagq9hJx6BL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).OffsetY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wEGJBVifQXh86NbBwOX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImageLayer)P_0).Image;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int j3SHyOiFWadyPptHbd4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rP5d9rim9JgblHaSVvO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QL5nKqiy2RyL47qbrqI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImageLayer)P_0).Transform;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oxUboEigPtFB5PWhv2H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLinearTransform)P_0).GetTransformMatrix();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF A5o69BiZOaQj77D9hKi(object P_0, RectangleF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Matrix)P_0).VectorTransformRectPoints(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s6EOPuiJIsfYn5Icchb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Mask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double iK3bLti8IFrh4Kn0UNt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double aT6jCUizsIkYdNXaFs8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Uqt79VqwV4FnJcwR8d1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF mhwf0lqsPhCpPiGpyZq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImageLayer)P_0).GetViewportRectangle();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int b6EmpaqhNcQ6VV4F6K4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogViewPort)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ksrekTqLMhFscYZeWM9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditInfo)P_0).EditingType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint M8ODa8q9SOhgvw4VcsS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q2HnfAqSL3TFQYDweKL(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AO2B4aqEX7RQyf0SWS8(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
