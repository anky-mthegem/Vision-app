using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

public sealed class CvsGraphicFeature : CvsGraphic
{
	private double x9vJBInqnu;

	private SizeF scwJJoOsGm;

	private Color Ft9JMTR16v;

	private PointF rFrJoW2dkr;

	public double Angle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x9vJBInqnu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ft6MgXrneJo96yKQftn();
			int num;
			if (uIKE3PraYah93IRNqXI())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_006d;
			IL_002a:
			Bn9CsorFWlvvbLxTRCd(this, VueDhYrX6acQY1DOIvn(34112));
			num = 5;
			goto IL_006d;
			IL_006d:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					goto IL_0044;
				case 3:
					x9vJBInqnu = value;
					break;
				case 5:
					return;
				}
				break;
				IL_0044:
				CheckLock();
				num = 3;
			}
			goto IL_002a;
		}
	}

	public SizeF Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return scwJJoOsGm;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (uIKE3PraYah93IRNqXI())
			{
				num = 2;
				if (!uIKE3PraYah93IRNqXI())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (ft6MgXrneJo96yKQftn())
				{
					goto IL_0090;
				}
			}
			goto IL_0043;
			IL_0090:
			Bn9CsorFWlvvbLxTRCd(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34100));
			num = 5;
			goto IL_0043;
			IL_0043:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				default:
					num = 3;
					if (ft6MgXrneJo96yKQftn())
					{
					}
					continue;
				case 0:
				case 2:
					CheckLock();
					break;
				case 3:
					goto IL_0090;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			scwJJoOsGm = value;
			goto IL_0090;
		}
	}

	public Color FillColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ft9JMTR16v;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					Ft9JMTR16v = value;
					break;
				case 3:
					do
					{
						CheckLock();
						ft6MgXrneJo96yKQftn();
						if (!uIKE3PraYah93IRNqXI())
						{
							num = 4;
							continue;
						}
						num = 0;
						break;
					}
					while (!uIKE3PraYah93IRNqXI());
					continue;
				case 5:
					return;
				}
				Bn9CsorFWlvvbLxTRCd(this, VueDhYrX6acQY1DOIvn(34488));
				num = 5;
			}
		}
	}

	public PointF Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rFrJoW2dkr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					CheckLock();
					ft6MgXrneJo96yKQftn();
					if (uIKE3PraYah93IRNqXI())
					{
						num = 0;
						if (ft6MgXrneJo96yKQftn())
						{
						}
					}
					else
					{
						num = 4;
						if (false)
						{
							return;
						}
					}
					continue;
				case 0:
				case 1:
					rFrJoW2dkr = value;
					break;
				case 5:
					return;
				}
				Bn9CsorFWlvvbLxTRCd(this, VueDhYrX6acQY1DOIvn(34080));
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFeature()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!uIKE3PraYah93IRNqXI()) ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 4:
				cwKJTl3J65(PointF.Empty, SizeF.Empty, 0.0, pbbvjVrGqjpm6mAxg8d(), Color.Cyan, (string)VueDhYrX6acQY1DOIvn(34482), CvsCellLocation.Invalid);
				num = 5;
				if (uIKE3PraYah93IRNqXI())
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 1:
			case 3:
				base._002Ector();
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFeature(CvsGraphicFeature feature)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				base._002Ector(feature);
				num = 6;
				break;
			case 0:
				Ft9JMTR16v = feature.FillColor;
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				scwJJoOsGm = U1WMXlr6BvjVnbnd9DG(feature);
				goto default;
			default:
				x9vJBInqnu = xEQqe2rpSjC2pn2DW7e(feature);
				num = 0;
				break;
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				uIKE3PraYah93IRNqXI();
				num = ((!ft6MgXrneJo96yKQftn()) ? 2 : 7);
				break;
			case 6:
				rFrJoW2dkr = yF1Gx0rb7tQX755WOa4(feature);
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogFeature feature)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				Location = new PointF((float)iHuxyUr0X1gHMB8UMUx(feature), (float)hEy0yGr4APeEhSky29X(feature));
				num = 5;
				continue;
			case 5:
				Size = new SizeF((float)feature.Width, (float)cIaVXHrkeQNSSfGP7rb(feature));
				goto default;
			default:
				ft6MgXrneJo96yKQftn();
				if (uIKE3PraYah93IRNqXI())
				{
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 2;
				}
				num = 1;
				if (ft6MgXrneJo96yKQftn())
				{
				}
				continue;
			case 2:
				base.FromSerializableGraphic(feature);
				num = 0;
				continue;
			case 3:
			case 6:
				Angle = oZWArErf2o0kEI9h0pX(feature);
				break;
			case 1:
			case 4:
				break;
			case 7:
				return;
			}
			FillColor = Color.FromArgb(feature.FillColor);
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicFeature(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cwKJTl3J65(PointF P_0, SizeF P_1, double P_2, Color P_3, Color P_4, string P_5, CvsCellLocation P_6)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!uIKE3PraYah93IRNqXI()) ? 5 : 8);
		while (true)
		{
			switch (num)
			{
			case 4:
				scwJJoOsGm = P_1;
				num = 6;
				if (uIKE3PraYah93IRNqXI())
				{
					break;
				}
				goto case 2;
			case 2:
				OnPropertyChanged(null);
				num = 10;
				break;
			case 0:
			case 8:
				rFrJoW2dkr = P_0;
				num = 4;
				break;
			case 3:
			case 5:
				Ft9JMTR16v = P_3;
				num = 7;
				break;
			case 1:
				mLabel = P_5;
				num = 9;
				break;
			case 7:
				mColor = P_4;
				goto case 1;
			default:
				num = 1;
				break;
			case 6:
				x9vJBInqnu = P_2;
				goto case 3;
			case 9:
				mCellLocation = P_6;
				num = 2;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color pbbvjVrGqjpm6mAxg8d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.LightGray;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VueDhYrX6acQY1DOIvn(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uIKE3PraYah93IRNqXI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ft6MgXrneJo96yKQftn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF yF1Gx0rb7tQX755WOa4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicFeature)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF U1WMXlr6BvjVnbnd9DG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicFeature)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double xEQqe2rpSjC2pn2DW7e(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicFeature)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double iHuxyUr0X1gHMB8UMUx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFeature)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double hEy0yGr4APeEhSky29X(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFeature)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double cIaVXHrkeQNSSfGP7rb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFeature)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double oZWArErf2o0kEI9h0pX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFeature)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bn9CsorFWlvvbLxTRCd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}
}
