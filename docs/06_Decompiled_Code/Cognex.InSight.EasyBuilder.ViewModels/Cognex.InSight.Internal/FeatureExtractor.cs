using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Imaging;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.Graphic;

namespace Cognex.InSight.Internal;

public class FeatureExtractor : IFeatureExtractor
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsEditableDisplayGraphic> FindLines(CvsImage image)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (image == null)
		{
			return new List<CvsEditableDisplayGraphic>();
		}
		try
		{
			CvsLineSegmentFinder.LineSegment[] array;
			using (CvsLineSegmentFinder cvsLineSegmentFinder = new CvsLineSegmentFinder())
			{
				using ICvsImageBuffer cvsImageBuffer = CvsImageBufferFactory.Copy(image.Buffer, CnxPixelFormat.Format8bppGrayscale);
				using Bitmap bitmap = cvsImageBuffer.ToBitmap();
				array = cvsLineSegmentFinder.Run(bitmap, new Rectangle(12, 12, cvsImageBuffer.Size.Width - 24, cvsImageBuffer.Size.Height - 24));
			}
			if (array == null)
			{
				return new List<CvsEditableDisplayGraphic>();
			}
			List<CvsEditableDisplayGraphic> list = new List<CvsEditableDisplayGraphic>();
			CvsLineSegmentFinder.LineSegment[] array2 = array;
			foreach (CvsLineSegmentFinder.LineSegment obj in array2)
			{
				PointF startPoint = obj.StartPoint;
				PointF endPoint = obj.EndPoint;
				PointF pointF = default;
				PointF pointF2 = default;
				float num = image.AcquiredWidth / image.Buffer.Size.Width;
				float num2 = image.AcquiredHeight / image.Buffer.Size.Height;
				pointF.X = (float)image.CroppedRegion.Left + (startPoint.X + 12f) * num;
				pointF.Y = (float)image.CroppedRegion.Top + (startPoint.Y + 12f) * num2;
				pointF2.X = (float)image.CroppedRegion.Left + (endPoint.X + 12f) * num;
				pointF2.Y = (float)image.CroppedRegion.Top + (endPoint.Y + 12f) * num2;
				CvsDisplayableLine cvsDisplayableLine = new CvsDisplayableLine(new CvsGraphicLine(CvsCellLocation.Invalid, new PointF(pointF.X, pointF.Y), new PointF(pointF2.X, pointF2.Y), string.Empty));
				cvsDisplayableLine.EditFlags = CvsEditFlags.None;
				cvsDisplayableLine.Color = Color.Cyan;
				cvsDisplayableLine.SelectedColor = Color.Magenta;
				cvsDisplayableLine.LineWidth = 2;
				cvsDisplayableLine.AutoHighlight = true;
				cvsDisplayableLine.EditBounds = Dtb5NOkid(image);
				list.Add(cvsDisplayableLine);
			}
			return list;
		}
		catch (DllNotFoundException)
		{
			return new List<CvsEditableDisplayGraphic>();
		}
		catch (Exception)
		{
			return new List<CvsEditableDisplayGraphic>();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsEditableDisplayGraphic> FindCircles(CvsImage image)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (image == null)
		{
			return new List<CvsEditableDisplayGraphic>();
		}
		try
		{
			using CvsShapeFinder cvsShapeFinder = new CvsShapeFinder();
			cvsShapeFinder.Width = 30f;
			cvsShapeFinder.ScaleHighPercent = 120f;
			cvsShapeFinder.ScaleLowPercent = 80f;
			cvsShapeFinder.ShapeType = CvsShapeKind.Ellipse;
			cvsShapeFinder.Polarity = CvsShapePolarity.Either;
			cvsShapeFinder.AcceptThreshold = 0.75f;
			cvsShapeFinder.Overlap = 1f;
			using ICvsImageBuffer cvsImageBuffer = CvsImageBufferFactory.Copy(image.Buffer, CnxPixelFormat.Format8bppGrayscale);
			using Bitmap bitmap = cvsImageBuffer.ToBitmap();
			List<CvsEditableDisplayGraphic> list = new List<CvsEditableDisplayGraphic>();
			do
			{
				CvsShapeFinder.Shape[] array = cvsShapeFinder.Run(bitmap);
				if (array != null)
				{
					CvsShapeFinder.Shape[] array2 = array;
					foreach (CvsShapeFinder.Shape obj in array2)
					{
						PointF center = obj.Center;
						SizeF size = obj.Size;
						PointF pointF = default;
						float num = image.AcquiredWidth / image.Buffer.Size.Width;
						float num2 = image.AcquiredHeight / image.Buffer.Size.Height;
						pointF.X = (float)image.CroppedRegion.Left + center.X * num;
						pointF.Y = (float)image.CroppedRegion.Top + center.Y * num2;
						float radius = (size.Width + size.Height) / 4f * num;
						CvsDisplayableCircle cvsDisplayableCircle = new CvsDisplayableCircle(new CvsGraphicCircle(CvsCellLocation.Invalid, new PointF(pointF.X, pointF.Y), radius, string.Empty));
						cvsDisplayableCircle.EditFlags = CvsEditFlags.None;
						cvsDisplayableCircle.Color = Color.Cyan;
						cvsDisplayableCircle.SelectedColor = Color.Magenta;
						cvsDisplayableCircle.LineWidth = 2;
						cvsDisplayableCircle.AutoHighlight = true;
						cvsDisplayableCircle.EditBounds = Dtb5NOkid(image);
						if (!cvsDisplayableCircle.IsInBounds())
						{
							continue;
						}
						bool flag = true;
						foreach (CvsDisplayableCircle item in list)
						{
							if (aPFpSTLwg(item, cvsDisplayableCircle))
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							list.Add(cvsDisplayableCircle);
						}
					}
				}
				cvsShapeFinder.Width = cvsShapeFinder.Width * cvsShapeFinder.ScaleHighPercent / cvsShapeFinder.ScaleLowPercent;
			}
			while ((double)cvsShapeFinder.Width < (double)image.Height * 0.75);
			return list;
		}
		catch (DllNotFoundException)
		{
			return new List<CvsEditableDisplayGraphic>();
		}
		catch (Exception)
		{
			return new List<CvsEditableDisplayGraphic>();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private RectangleF Dtb5NOkid(CvsImage P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!R5HjH0gSlDNJbDuLbi())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_009d;
		IL_0026:
		RectangleF result = new RectangleF(P_0.CroppedRegion.Left, rmoKhfsrQ7Z62htSKB(P_0).Top, rmoKhfsrQ7Z62htSKB(P_0).Width, rmoKhfsrQ7Z62htSKB(P_0).Height);
		num = 5;
		goto IL_009d;
		IL_009d:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				result = RectangleF.Empty;
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				if (P_0 != null)
				{
					break;
				}
				goto case 5;
			case 5:
				return result;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aPFpSTLwg(CvsDisplayableCircle P_0, CvsDisplayableCircle P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		bool result = default;
		float num4 = default;
		PointF pointF = default;
		double num3 = default;
		PointF center = default;
		float num2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				result = false;
				num = 9;
				continue;
			case 1:
			case 7:
				result = true;
				num = 10;
				if (i5yPxClU55GuwM1M7e())
				{
					continue;
				}
				goto case 8;
			case 8:
				num4 = Nw50S0PbgtjLq58SMt(yvT9xfvvg3IOORpU8O(P_1));
				goto default;
			default:
				_ = 1;
				if (!R5HjH0gSlDNJbDuLbi())
				{
					num = 0;
					continue;
				}
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 9:
				pointF = Rk3sEJrFxhnsG4DO1s(yvT9xfvvg3IOORpU8O(P_0));
				num = 6;
				continue;
			case 4:
				if (!(num3 < 0.15))
				{
					break;
				}
				goto case 1;
			case 0:
			case 5:
			{
				float num5 = center.X - pointF.X;
				float num6 = center.Y - pointF.Y;
				double num7 = T89xLqZ404ZUXirD4v(num5 * num5 + num6 * num6);
				num3 = (double)SNU6T3BGtxTZBpjAJT(num4 - num2) / (double)num2;
				if (num7 * 4.0 < (double)num2)
				{
					num = 4;
					continue;
				}
				break;
			}
			case 3:
				center = ((CvsGraphicCircle)yvT9xfvvg3IOORpU8O(P_1)).Center;
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				num2 = Nw50S0PbgtjLq58SMt(yvT9xfvvg3IOORpU8O(P_0));
				num = 3;
				continue;
			case 10:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LinesAreSimilar(CvsDisplayableLine line1, CvsDisplayableLine line2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		PointF pointF = default;
		CvsGraphicLine cvsGraphicLine2 = default;
		double num13 = default;
		double num14 = default;
		double num12 = default;
		double num23 = default;
		double num9 = default;
		double num3 = default;
		double num18 = default;
		double num21 = default;
		double num22 = default;
		double num10 = default;
		double num5 = default;
		double num2 = default;
		double num7 = default;
		double num11 = default;
		double num4 = default;
		CvsGraphicLine cvsGraphicLine = default;
		double num8 = default;
		bool result = default;
		double num6 = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				pointF = EOoRkvSgfflsjx7kn7(cvsGraphicLine2);
				num = 18;
				continue;
			case 16:
			case 28:
				if (num13 <= num14)
				{
					num = 33;
					continue;
				}
				break;
			case 18:
				num12 = uomHilkTftesk7OY8R(pointF.Y, hfaHdho1OAOgIdQdHC(cvsGraphicLine2).Y);
				pointF = EOoRkvSgfflsjx7kn7(cvsGraphicLine2);
				num = 8;
				continue;
			case 29:
			{
				float num24 = pointF.X * EOoRkvSgfflsjx7kn7(cvsGraphicLine2).Y;
				float x5 = EOoRkvSgfflsjx7kn7(cvsGraphicLine2).X;
				pointF = cvsGraphicLine2.EndPoint;
				num23 = num24 - x5 * pointF.Y;
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 8;
			}
			case 8:
			{
				float y2 = pointF.Y;
				pointF = cvsGraphicLine2.EndPoint;
				num14 = JR5jbu8lm7maRrMhBF(y2, pointF.Y);
				num = 22;
				if (0 == 0)
				{
					continue;
				}
				goto case 17;
			}
			case 17:
				num9 = 0.0 - num3;
				num = 5;
				continue;
			case 4:
			{
				float x3 = pointF.X;
				pointF = hfaHdho1OAOgIdQdHC(cvsGraphicLine2);
				num18 = JR5jbu8lm7maRrMhBF(x3, pointF.X);
				num = 2;
				continue;
			}
			case 15:
				if (num21 <= num18 && num22 < 5.0 && num10 < 0.15)
				{
					num = 7;
					continue;
				}
				break;
			case 13:
				num21 = (num9 * num23 - num5 * num2) / num7;
				num = 10;
				continue;
			case 33:
				if (!(num21 >= num11))
				{
					break;
				}
				num = 15;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				num4 = (cvsGraphicLine.StartPoint.Y + cvsGraphicLine.EndPoint.Y) / 2f;
				pointF = EOoRkvSgfflsjx7kn7(cvsGraphicLine);
				num = 24;
				continue;
			case 23:
				pointF = EOoRkvSgfflsjx7kn7(cvsGraphicLine2);
				num = 4;
				continue;
			case 30:
				cvsGraphicLine = (CvsGraphicLine)DracMxGDDTUnPlcv7B(line1);
				goto case 20;
			case 20:
			{
				float x6 = cvsGraphicLine2.StartPoint.X;
				pointF = hfaHdho1OAOgIdQdHC(cvsGraphicLine2);
				num5 = x6 - pointF.X;
				num = 31;
				continue;
			}
			case 5:
				num8 = num5;
				num = 21;
				if (i5yPxClU55GuwM1M7e())
				{
					continue;
				}
				goto case 22;
			case 22:
				pointF = EOoRkvSgfflsjx7kn7(cvsGraphicLine2);
				num = 32;
				continue;
			case 9:
				result = false;
				num = 0;
				continue;
			case 0:
				if (z7YIxZbmmfkHqjf9KC(line1) > z7YIxZbmmfkHqjf9KC(line2))
				{
					num = 1;
					continue;
				}
				cvsGraphicLine2 = (CvsGraphicLine)DracMxGDDTUnPlcv7B(line2);
				num = 30;
				continue;
			case 19:
				num10 = Math.PI * 2.0 - num10;
				num = 26;
				if (!R5HjH0gSlDNJbDuLbi())
				{
					continue;
				}
				goto case 3;
			case 3:
				num13 = (num3 * num2 - num8 * num23) / num7;
				num = 13;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				cvsGraphicLine2 = (CvsGraphicLine)DracMxGDDTUnPlcv7B(line1);
				num = 11;
				if (i5yPxClU55GuwM1M7e())
				{
					continue;
				}
				goto case 24;
			case 24:
			{
				float x4 = pointF.X;
				pointF = hfaHdho1OAOgIdQdHC(cvsGraphicLine);
				num6 = (x4 + pointF.X) / 2f;
				num = 17;
				continue;
			}
			case 26:
				if (!(num10 > Math.PI / 2.0))
				{
					goto IL_0342;
				}
				i5yPxClU55GuwM1M7e();
				if (!R5HjH0gSlDNJbDuLbi())
				{
					num = 14;
					continue;
				}
				num = 16;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 32:
			{
				float x = pointF.X;
				pointF = hfaHdho1OAOgIdQdHC(cvsGraphicLine2);
				num11 = uomHilkTftesk7OY8R(x, pointF.X);
				num = 23;
				continue;
			}
			case 25:
				pointF = hfaHdho1OAOgIdQdHC(cvsGraphicLine2);
				num = 29;
				continue;
			case 14:
			case 27:
				num10 = Math.PI - num10;
				goto IL_0342;
			case 7:
				result = true;
				num = 34;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			{
				double num15 = SQ54dGqNELKuB46Hjo(hfaHdho1OAOgIdQdHC(cvsGraphicLine2).Y - EOoRkvSgfflsjx7kn7(cvsGraphicLine2).Y, cvsGraphicLine2.EndPoint.X - EOoRkvSgfflsjx7kn7(cvsGraphicLine2).X);
				double num16 = cvsGraphicLine.EndPoint.Y - EOoRkvSgfflsjx7kn7(cvsGraphicLine).Y;
				float x2 = hfaHdho1OAOgIdQdHC(cvsGraphicLine).X;
				pointF = EOoRkvSgfflsjx7kn7(cvsGraphicLine);
				double num17 = SQ54dGqNELKuB46Hjo(num16, x2 - pointF.X);
				num10 = qMNLpJEa40OpKOS2k6(num15 - num17);
				if (!(num10 > Math.PI))
				{
					goto case 26;
				}
				num = 19;
				if (0 == 0)
				{
					continue;
				}
				goto case 10;
			}
			case 10:
			{
				double num19 = num4 - num13;
				double num20 = num6 - num21;
				num22 = T89xLqZ404ZUXirD4v(num19 * num19 + num20 * num20);
				goto case 12;
			}
			default:
				num = 12;
				if (R5HjH0gSlDNJbDuLbi())
				{
				}
				continue;
			case 31:
			{
				float y = hfaHdho1OAOgIdQdHC(cvsGraphicLine2).Y;
				pointF = cvsGraphicLine2.StartPoint;
				num3 = y - pointF.Y;
				num = 25;
				continue;
			}
			case 11:
				cvsGraphicLine = line2.Line;
				num = 20;
				continue;
			case 21:
				num2 = num3 * num4 - num5 * num6;
				num7 = num5 * num8 - num3 * num9;
				num = 3;
				if (i5yPxClU55GuwM1M7e())
				{
					continue;
				}
				break;
			case 34:
				break;
				IL_0342:
				if (!(num13 >= num12))
				{
					break;
				}
				goto case 16;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FeatureExtractor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HkMLH9pBUg8mTkLXhh();
		ccYcE3XNfFX7Qs0N4y(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle rmoKhfsrQ7Z62htSKB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImage)P_0).CroppedRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool i5yPxClU55GuwM1M7e()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R5HjH0gSlDNJbDuLbi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yvT9xfvvg3IOORpU8O(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableCircle)P_0).CircleGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF Rk3sEJrFxhnsG4DO1s(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCircle)P_0).Center;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float Nw50S0PbgtjLq58SMt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCircle)P_0).Radius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double T89xLqZ404ZUXirD4v(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Sqrt(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float SNU6T3BGtxTZBpjAJT(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double z7YIxZbmmfkHqjf9KC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).Area;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DracMxGDDTUnPlcv7B(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableLine)P_0).Line;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF hfaHdho1OAOgIdQdHC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicLine)P_0).EndPoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF EOoRkvSgfflsjx7kn7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicLine)P_0).StartPoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float uomHilkTftesk7OY8R(float P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float JR5jbu8lm7maRrMhBF(float P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double SQ54dGqNELKuB46Hjo(double P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Atan2(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double qMNLpJEa40OpKOS2k6(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HkMLH9pBUg8mTkLXhh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ccYcE3XNfFX7Qs0N4y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
