using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicAnnulus : CvsGraphic, ICvsEditableGraphic
{
	private PointF FtmBIM5sVC;

	private float C6cB1cKOw3;

	private float VYvBxOsAkM;

	private RectangleF v0mBFVu8jL;

	private CvsEditFlags Qw9Bb20lHu;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new double[4]
			{
				me5IpQYxRhcSRVh9fGO(FtmBIM5sVC.Y),
				me5IpQYxRhcSRVh9fGO(FtmBIM5sVC.X),
				me5IpQYxRhcSRVh9fGO(C6cB1cKOw3),
				me5IpQYxRhcSRVh9fGO(VYvBxOsAkM)
			};
		}
	}

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FtmBIM5sVC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Qd9M0vYjMW0pNuuZUTX();
			int num;
			if (!nfXyiKYcdRrtt8VL3nZ())
			{
				num = 4;
				if (nfXyiKYcdRrtt8VL3nZ())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0076;
				}
			}
			goto IL_0047;
			IL_0086:
			E75VDFYNDB5FB2KsuEX(this, f6r3iIY1lh9XVCeqOko(33886));
			num = 5;
			if (!Qd9M0vYjMW0pNuuZUTX())
			{
				return;
			}
			goto IL_0047;
			IL_0076:
			CheckLock();
			num = 1;
			goto IL_0047;
			IL_002e:
			FtmBIM5sVC = value;
			goto IL_0086;
			IL_0047:
			switch (num)
			{
			case 1:
				break;
			case 0:
			case 4:
				goto IL_0076;
			default:
				goto IL_0086;
			case 5:
				return;
			}
			goto IL_002e;
		}
	}

	public float InnerRadius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C6cB1cKOw3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Qd9M0vYjMW0pNuuZUTX();
			int num = (nfXyiKYcdRrtt8VL3nZ() ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 1:
					C6cB1cKOw3 = value;
					break;
				case 0:
				case 3:
					CheckLock();
					num = 1;
					if (Qd9M0vYjMW0pNuuZUTX())
					{
						continue;
					}
					break;
				case 5:
					return;
				}
				OnPropertyChanged((string)f6r3iIY1lh9XVCeqOko(33902));
				num = 5;
			}
		}
	}

	public float OuterRadius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VYvBxOsAkM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (nfXyiKYcdRrtt8VL3nZ() ? 3 : 4);
			do
			{
				IL_0053:
				switch (num)
				{
				case 0:
				case 4:
					CheckLock();
					goto case 1;
				case 1:
				case 3:
					VYvBxOsAkM = value;
					break;
				default:
					num = 2;
					if (!nfXyiKYcdRrtt8VL3nZ())
					{
						goto IL_0053;
					}
					break;
				case 2:
					break;
				case 5:
					return;
				}
				OnPropertyChanged((string)f6r3iIY1lh9XVCeqOko(33928));
				num = 5;
			}
			while (Qd9M0vYjMW0pNuuZUTX());
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
			return Qw9Bb20lHu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (nfXyiKYcdRrtt8VL3nZ())
			{
				goto IL_001e;
			}
			goto IL_0039;
			IL_001e:
			Qw9Bb20lHu = value & (CvsEditFlags.Location | CvsEditFlags.Size);
			goto IL_0066;
			IL_0039:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				default:
					goto IL_0066;
				case 3:
					goto IL_0080;
				case 5:
					return;
				}
				break;
				IL_0080:
				CheckLock();
				_ = 1;
				num = (nfXyiKYcdRrtt8VL3nZ() ? 4 : 0);
			}
			goto IL_001e;
			IL_0066:
			OnPropertyChanged((string)f6r3iIY1lh9XVCeqOko(33720));
			num = 5;
			goto IL_0039;
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
			return v0mBFVu8jL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Qd9M0vYjMW0pNuuZUTX();
			int num = (nfXyiKYcdRrtt8VL3nZ() ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 1:
					v0mBFVu8jL = value;
					goto default;
				default:
					E75VDFYNDB5FB2KsuEX(this, f6r3iIY1lh9XVCeqOko(33862));
					num = 5;
					break;
				case 0:
				case 3:
					CheckLock();
					num = 1;
					break;
				case 5:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicAnnulus(CvsGraphicAnnulus graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nfXyiKYcdRrtt8VL3nZ();
		int num;
		if (Qd9M0vYjMW0pNuuZUTX())
		{
			num = 4;
		}
		else
		{
			num = 1;
			if (!Qd9M0vYjMW0pNuuZUTX())
			{
				goto IL_0083;
			}
		}
		goto IL_00b7;
		IL_00b7:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				CnkSbsY2LlEo3gyTvWY();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				C6cB1cKOw3 = graphic.C6cB1cKOw3;
				num = 2;
				continue;
			case 5:
				Qw9Bb20lHu = CvsEditFlags.Location | CvsEditFlags.Size;
				num = 6;
				if (Qd9M0vYjMW0pNuuZUTX())
				{
					continue;
				}
				goto case 6;
			case 6:
				base._002Ector(graphic);
				goto case 1;
			case 2:
				break;
			case 1:
			case 3:
				FtmBIM5sVC = graphic.FtmBIM5sVC;
				goto case 7;
			default:
				num = 7;
				if (Qd9M0vYjMW0pNuuZUTX())
				{
					continue;
				}
				return;
			case 8:
				return;
			}
			break;
		}
		goto IL_0083;
		IL_0083:
		VYvBxOsAkM = graphic.VYvBxOsAkM;
		num = 8;
		goto IL_00b7;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicAnnulus(CvsCellLocation cellLocation, CvsCogEditingAnnulus editAnn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCogAnnulus cvsCogAnnulus = default;
		do
		{
			IL_0102:
			switch (num)
			{
			case 3:
				cvsCogAnnulus = (CvsCogAnnulus)Jxl5HTYWrerZEsrTV1h(editAnn);
				num = 6;
				if (0 == 0)
				{
					goto IL_0102;
				}
				goto case 4;
			case 4:
				CnkSbsY2LlEo3gyTvWY();
				Qd9M0vYjMW0pNuuZUTX();
				if (!nfXyiKYcdRrtt8VL3nZ())
				{
					num = 5;
					goto IL_0102;
				}
				num = 10;
				if (true)
				{
					goto IL_0102;
				}
				goto case 9;
			case 2:
				OuterRadius = (float)lbSmRtYKmHJnBgKf8qR(cvsCogAnnulus);
				EditFlags = (CvsEditFlags)((rL1RavY5yGFCSetw0Cv(editAnn) ? 1 : 0) | (FHOfYaYoes3a7gKhbn6(editAnn) ? 2 : 0));
				num = 7;
				goto IL_0102;
			case 7:
				v0mBFVu8jL = p2cBfOYYTb4SZnM4yNg(lvXKgIYPvC6B0s1bW9b(editAnn));
				break;
			case 9:
				InnerRadius = (float)IF8dd1YCR3nXojrpnfP(cvsCogAnnulus);
				num = 2;
				goto IL_0102;
			case 1:
			case 5:
				Qw9Bb20lHu = CvsEditFlags.Location | CvsEditFlags.Size;
				num = 0;
				goto IL_0102;
			case 6:
				Center = new PointF((float)wuUirbY7TF6CygqcAXi(cvsCogAnnulus), (float)T3EcmVYtn5htCDTKcOs(cvsCogAnnulus));
				goto case 9;
			default:
				num = 9;
				if (true)
				{
					goto IL_0102;
				}
				goto case 0;
			case 0:
				base._002Ector(cellLocation, editAnn);
				num = 3;
				goto IL_0102;
			case 8:
			case 10:
				break;
			case 11:
				return;
			}
			UniqueId = cellLocation.ToString();
			num = 11;
		}
		while (Qd9M0vYjMW0pNuuZUTX());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicAnnulus(CvsCellLocation loc, PointF center, float innerRadius, float outerRadius, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!Qd9M0vYjMW0pNuuZUTX()) ? 4 : 5);
		while (true)
		{
			switch (num)
			{
			default:
				Initialize(loc.Row, loc.Column, center.Y, center.X, innerRadius, outerRadius, label);
				num = 1;
				break;
			case 2:
				Qw9Bb20lHu = CvsEditFlags.Location | CvsEditFlags.Size;
				num = 6;
				if (!nfXyiKYcdRrtt8VL3nZ())
				{
					break;
				}
				goto case 1;
			case 1:
				UniqueId = loc.ToString();
				num = 7;
				break;
			case 6:
				base._002Ector();
				goto default;
			case 0:
			case 5:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 2;
				if (1 == 0)
				{
					return;
				}
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicAnnulus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Qd9M0vYjMW0pNuuZUTX();
		int num = (nfXyiKYcdRrtt8VL3nZ() ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 1:
			case 5:
				Qw9Bb20lHu = CvsEditFlags.Location | CvsEditFlags.Size;
				num = 3;
				continue;
			case 4:
				Initialize(0, 0, 0f, 0f, 0f, 0f, "");
				num = 6;
				continue;
			case 3:
				base._002Ector();
				goto case 4;
			case 6:
				return;
			}
			num = 4;
			if (!Qd9M0vYjMW0pNuuZUTX())
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float centerRow, float centerCol, float innerRadius, float outerRadius, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Qd9M0vYjMW0pNuuZUTX();
		int num = (nfXyiKYcdRrtt8VL3nZ() ? 2 : 5);
		while (true)
		{
			switch (num)
			{
			case 6:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 1;
				continue;
			case 7:
				mLabel = label;
				num = 8;
				continue;
			case 1:
				FtmBIM5sVC = new PointF(centerCol, centerRow);
				num = 3;
				continue;
			case 0:
			case 5:
				CheckLock();
				num = 6;
				continue;
			case 3:
				C6cB1cKOw3 = innerRadius;
				break;
			case 8:
				E75VDFYNDB5FB2KsuEX(this, null);
				num = 9;
				continue;
			case 9:
				return;
			}
			VYvBxOsAkM = outerRadius;
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
		return new CvsGraphicAnnulus(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogAnnulus(FtmBIM5sVC.X, FtmBIM5sVC.Y, C6cB1cKOw3, VYvBxOsAkM, mColor.ToArgb(), mCellLocation.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogAnnulus ann)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (nfXyiKYcdRrtt8VL3nZ() ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				base.FromSerializableGraphic(ann);
				break;
			case 2:
				InnerRadius = (float)IF8dd1YCR3nXojrpnfP(ann);
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				OuterRadius = (float)ann.OuterRadius;
				num = 6;
				continue;
			case 1:
			case 4:
				break;
			case 6:
				return;
			}
			Center = new PointF((float)wuUirbY7TF6CygqcAXi(ann), (float)ann.Y);
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CnkSbsY2LlEo3gyTvWY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Qd9M0vYjMW0pNuuZUTX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nfXyiKYcdRrtt8VL3nZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Jxl5HTYWrerZEsrTV1h(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingAnnulus)P_0).Annulus;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wuUirbY7TF6CygqcAXi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double T3EcmVYtn5htCDTKcOs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double IF8dd1YCR3nXojrpnfP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).InnerRadius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double lbSmRtYKmHJnBgKf8qR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).OuterRadius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rL1RavY5yGFCSetw0Cv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingAnnulus)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FHOfYaYoes3a7gKhbn6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingAnnulus)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lvXKgIYPvC6B0s1bW9b(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF p2cBfOYYTb4SZnM4yNg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).ToRectangleF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E75VDFYNDB5FB2KsuEX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double me5IpQYxRhcSRVh9fGO(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f6r3iIY1lh9XVCeqOko(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
