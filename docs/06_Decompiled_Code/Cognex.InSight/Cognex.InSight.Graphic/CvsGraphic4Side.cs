using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphic4Side : CvsGraphic, ICvsEditableGraphic
{
	private PointF fo8TVABxDj;

	private PointF T6eTvW72Dk;

	private PointF ohPTZnBDxp;

	private PointF c98T8YcMis;

	private RectangleF H35TzGGHrU;

	private CvsDisplayable4SideStyle FekBPSU17y;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new double[8]
			{
				YdVaZXYV8Z03ikECNm4(fo8TVABxDj.Y),
				Convert.ToDouble(fo8TVABxDj.X),
				YdVaZXYV8Z03ikECNm4(T6eTvW72Dk.Y),
				YdVaZXYV8Z03ikECNm4(T6eTvW72Dk.X),
				YdVaZXYV8Z03ikECNm4(ohPTZnBDxp.Y),
				YdVaZXYV8Z03ikECNm4(ohPTZnBDxp.X),
				YdVaZXYV8Z03ikECNm4(c98T8YcMis.Y),
				YdVaZXYV8Z03ikECNm4(c98T8YcMis.X)
			};
		}
	}

	public PointF Point0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fo8TVABxDj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			J55wrTPJTtxh0XyEsuF();
			int num = ((!urpeIMPZn2ooQgSjSSH()) ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 3:
					OnPropertyChanged((string)HxHM7UYiLxJ96dtMswI(33798));
					num = 5;
					break;
				case 1:
				case 2:
					fo8TVABxDj = value;
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 4:
					CheckLock();
					goto case 1;
				case 5:
					return;
				}
			}
		}
	}

	public PointF Point1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return T6eTvW72Dk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					T6eTvW72Dk = value;
					goto default;
				default:
					zPC8AtYsJ7ATPyCO8Xa(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33814));
					num = 5;
					if (J55wrTPJTtxh0XyEsuF())
					{
					}
					break;
				case 0:
					CheckLock();
					J55wrTPJTtxh0XyEsuF();
					num = (urpeIMPZn2ooQgSjSSH() ? 4 : 3);
					break;
				case 5:
					return;
				}
			}
		}
	}

	public PointF Point2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ohPTZnBDxp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (J55wrTPJTtxh0XyEsuF() ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					ohPTZnBDxp = value;
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 4:
					CheckLock();
					goto case 1;
				case 3:
					break;
				case 5:
					return;
				}
				zPC8AtYsJ7ATPyCO8Xa(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33830));
				num = 5;
			}
		}
	}

	public PointF Point3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c98T8YcMis;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			J55wrTPJTtxh0XyEsuF();
			int num;
			if (urpeIMPZn2ooQgSjSSH())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (!urpeIMPZn2ooQgSjSSH())
				{
					goto IL_008a;
				}
			}
			goto IL_0041;
			IL_0041:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					c98T8YcMis = value;
					break;
				default:
					num = 4;
					if (urpeIMPZn2ooQgSjSSH())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 4:
					break;
				case 5:
					return;
				}
				break;
			}
			goto IL_008a;
			IL_008a:
			zPC8AtYsJ7ATPyCO8Xa(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33846));
			num = 5;
			if (J55wrTPJTtxh0XyEsuF())
			{
				return;
			}
			goto IL_0041;
		}
	}

	public CvsDisplayable4SideStyle Style
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FekBPSU17y;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FekBPSU17y = value;
		}
	}

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsEditFlags.Location | CvsEditFlags.Rotation | CvsEditFlags.Bend | CvsEditFlags.InPlane | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem;
		}
	}

	public RectangleF EditBounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return H35TzGGHrU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (J55wrTPJTtxh0XyEsuF() ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					CheckLock();
					num = 3;
					if (urpeIMPZn2ooQgSjSSH())
					{
						continue;
					}
					goto case 3;
				case 3:
					H35TzGGHrU = value;
					break;
				case 5:
					return;
				}
				zPC8AtYsJ7ATPyCO8Xa(this, HxHM7UYiLxJ96dtMswI(33862));
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphic4Side(CvsGraphic4Side graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 6:
				c98T8YcMis = graphic.Point3;
				num = 8;
				break;
			case 0:
				ohPTZnBDxp = GoSPXRPzhJwO4xgNgdq(graphic);
				num = 6;
				if (urpeIMPZn2ooQgSjSSH())
				{
					break;
				}
				goto case 7;
			case 7:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				J55wrTPJTtxh0XyEsuF();
				if (urpeIMPZn2ooQgSjSSH())
				{
					num = 5;
					break;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 2:
				fo8TVABxDj = UX6eGrP8DtvBVhCeXNB(graphic);
				goto case 3;
			case 1:
			case 5:
				base._002Ector(graphic);
				num = 2;
				break;
			case 3:
			case 4:
				T6eTvW72Dk = graphic.Point1;
				goto case 0;
			default:
				num = 0;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphic4Side(CvsCellLocation cellLocation, PointF[] points, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				mLabel = label;
				num = 9;
				if (!J55wrTPJTtxh0XyEsuF())
				{
					break;
				}
				goto case 2;
			case 2:
				fo8TVABxDj = points[0];
				_ = 0;
				num = ((!urpeIMPZn2ooQgSjSSH()) ? 7 : 8);
				break;
			case 6:
				base._002Ector(cellLocation, label);
				num = 2;
				if (J55wrTPJTtxh0XyEsuF())
				{
				}
				break;
			case 5:
				c98T8YcMis = points[3];
				num = 1;
				break;
			default:
				ohPTZnBDxp = points[2];
				num = 5;
				break;
			case 0:
				FUgaxqYwIvHvWNqCQqC();
				num = 6;
				break;
			case 3:
			case 8:
				T6eTvW72Dk = points[1];
				goto default;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphic4Side()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		urpeIMPZn2ooQgSjSSH();
		int num = (J55wrTPJTtxh0XyEsuF() ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 3:
				base._002Ector();
				break;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				FUgaxqYwIvHvWNqCQqC();
				goto case 1;
			case 5:
				return;
			}
			Initialize(0, 0, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, "");
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float pt0Row, float pt0Col, float pt1Row, float pt1Col, float pt2Row, float pt2Col, float pt3Row, float pt3Col, string graphicLabel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 7:
				c98T8YcMis = new PointF(pt3Col, pt3Row);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 9:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				goto case 2;
			case 4:
				T6eTvW72Dk = new PointF(pt1Col, pt1Row);
				num = 8;
				break;
			case 0:
				zPC8AtYsJ7ATPyCO8Xa(this, null);
				num = 10;
				break;
			case 8:
				ohPTZnBDxp = new PointF(pt2Col, pt2Row);
				goto case 7;
			default:
				num = 7;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 3:
				fo8TVABxDj = new PointF(pt0Col, pt0Row);
				num = 4;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				CheckLock();
				_ = 0;
				num = (urpeIMPZn2ooQgSjSSH() ? 9 : 3);
				break;
			case 6:
				mLabel = graphicLabel;
				num = 0;
				if (false)
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCog4Side fourSide)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				zPC8AtYsJ7ATPyCO8Xa(this, null);
				num = 9;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				T6eTvW72Dk = new PointF((float)FueByFY9WhJBe0cC1Ff(fourSide), (float)SynNpkYSVfiTrGjeSdD(fourSide));
				goto default;
			default:
				ohPTZnBDxp = new PointF((float)fourSide.X2, (float)bGuAaRYEjcO4PEeCHJP(fourSide));
				num = 7;
				continue;
			case 7:
				c98T8YcMis = new PointF((float)JCUZ3QYvx3lVIgrd0Ih(fourSide), (float)HV6Ot3YHNRsf8Aa6rMS(fourSide));
				num = 2;
				continue;
			case 5:
				base.FromSerializableGraphic(fourSide);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				fo8TVABxDj = new PointF((float)CNkP4GYhEbTYSULPrOg(fourSide), (float)Cm7ZIlYLgGcf4IZJ1ix(fourSide));
				J55wrTPJTtxh0XyEsuF();
				if (!urpeIMPZn2ooQgSjSSH())
				{
					num = 8;
					continue;
				}
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			case 0:
				break;
			case 9:
				return;
			}
			CheckLock();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphic4Side(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCog4Side cvsCog4Side = new CvsCog4Side
		{
			CellLocation = CellLocation.ToString()
		};
		Xr5MGRYAemxq4c7BMiB(cvsCog4Side, Color.ToArgb());
		cvsCog4Side.X0 = fo8TVABxDj.X;
		lDZu9TYDCTV51spbmIQ(cvsCog4Side, T6eTvW72Dk.X);
		cvsCog4Side.X2 = ohPTZnBDxp.X;
		GuiOAAYUs4Ay1lWQSJo(cvsCog4Side, c98T8YcMis.X);
		cvsCog4Side.Y0 = fo8TVABxDj.Y;
		VWjj7wYTpj3OQwYQIJf(cvsCog4Side, T6eTvW72Dk.Y);
		yCH3C4YdG0RjOGnDZIq(cvsCog4Side, ohPTZnBDxp.Y);
		cvsCog4Side.Y3 = c98T8YcMis.Y;
		return cvsCog4Side;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF UX6eGrP8DtvBVhCeXNB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic4Side)P_0).Point0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF GoSPXRPzhJwO4xgNgdq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic4Side)P_0).Point2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool urpeIMPZn2ooQgSjSSH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool J55wrTPJTtxh0XyEsuF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FUgaxqYwIvHvWNqCQqC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zPC8AtYsJ7ATPyCO8Xa(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double CNkP4GYhEbTYSULPrOg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCog4Side)P_0).X0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Cm7ZIlYLgGcf4IZJ1ix(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCog4Side)P_0).Y0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double FueByFY9WhJBe0cC1Ff(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCog4Side)P_0).X1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double SynNpkYSVfiTrGjeSdD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCog4Side)P_0).Y1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double bGuAaRYEjcO4PEeCHJP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCog4Side)P_0).Y2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double JCUZ3QYvx3lVIgrd0Ih(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCog4Side)P_0).X3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double HV6Ot3YHNRsf8Aa6rMS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCog4Side)P_0).Y3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double YdVaZXYV8Z03ikECNm4(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xr5MGRYAemxq4c7BMiB(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogShape)P_0).Color = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lDZu9TYDCTV51spbmIQ(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCog4Side)P_0).X1 = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GuiOAAYUs4Ay1lWQSJo(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCog4Side)P_0).X3 = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VWjj7wYTpj3OQwYQIJf(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCog4Side)P_0).Y1 = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yCH3C4YdG0RjOGnDZIq(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCog4Side)P_0).Y2 = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HxHM7UYiLxJ96dtMswI(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
