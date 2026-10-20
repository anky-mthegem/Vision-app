using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicCircle : CvsGraphic, ICvsEditableGraphic
{
	private PointF nQJBsYoQXi;

	private float CAgB6889VC;

	private RectangleF W2TBHIK8eu;

	private CvsEditFlags gWdBKvbtbA;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new double[3]
			{
				Convert.ToDouble(nQJBsYoQXi.Y),
				UcXr8vxStoaKqfyibVa(nQJBsYoQXi.X),
				UcXr8vxStoaKqfyibVa(CAgB6889VC)
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
			return nQJBsYoQXi;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			R7vg7qNJeU4Yl2loBPE();
			int num;
			if (!islRvIN8FAcaA5MwFuY())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (islRvIN8FAcaA5MwFuY())
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					nQJBsYoQXi = value;
					goto case 2;
				default:
					num = 2;
					break;
				case 2:
					T5OPk4x9ZKMSAAL6e9P(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33886));
					num = 5;
					if (!islRvIN8FAcaA5MwFuY())
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 5:
					return;
				}
			}
		}
	}

	public float Radius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CAgB6889VC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			islRvIN8FAcaA5MwFuY();
			int num = ((!R7vg7qNJeU4Yl2loBPE()) ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				case 3:
					CAgB6889VC = value;
					goto default;
				default:
					T5OPk4x9ZKMSAAL6e9P(this, mwE6UNxHip0Rqhj6XkR(33998));
					num = 5;
					break;
				case 0:
				case 4:
					CheckLock();
					num = 3;
					if (false)
					{
						return;
					}
					break;
				case 5:
					return;
				}
			}
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
			return gWdBKvbtbA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_006f;
			IL_001a:
			T5OPk4x9ZKMSAAL6e9P(this, mwE6UNxHip0Rqhj6XkR(33720));
			num = 5;
			goto IL_006f;
			IL_006f:
			while (true)
			{
				switch (num)
				{
				case 3:
					CheckLock();
					R7vg7qNJeU4Yl2loBPE();
					if (!islRvIN8FAcaA5MwFuY())
					{
						num = 0;
						continue;
					}
					num = 4;
					if (!R7vg7qNJeU4Yl2loBPE())
					{
						return;
					}
					continue;
				case 0:
				case 1:
					gWdBKvbtbA = value & (CvsEditFlags.Location | CvsEditFlags.Size);
					break;
				case 5:
					return;
				}
				break;
			}
			goto IL_001a;
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
			return W2TBHIK8eu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			R7vg7qNJeU4Yl2loBPE();
			int num = (islRvIN8FAcaA5MwFuY() ? 3 : 2);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					CheckLock();
					goto case 1;
				case 1:
				case 3:
					W2TBHIK8eu = value;
					break;
				default:
					num = 4;
					continue;
				case 4:
					break;
				case 5:
					return;
				}
				T5OPk4x9ZKMSAAL6e9P(this, mwE6UNxHip0Rqhj6XkR(33862));
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCircle(CvsGraphicCircle graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (R7vg7qNJeU4Yl2loBPE())
		{
			num = 3;
			if (islRvIN8FAcaA5MwFuY())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0087;
		IL_00b8:
		CAgB6889VC = nZdtjtxwcPiCSTrQ1wv(graphic);
		num = 7;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 6:
				gWdBKvbtbA = CvsEditFlags.Location | CvsEditFlags.Size;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 6;
				if (R7vg7qNJeU4Yl2loBPE())
				{
					continue;
				}
				goto case 5;
			case 5:
				base._002Ector(graphic);
				break;
			default:
				num = 1;
				if (true)
				{
					continue;
				}
				goto IL_00b8;
			case 2:
			case 4:
				goto IL_00b8;
			case 7:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		nQJBsYoQXi = eAeCGINzbZoekbjnT0V(graphic);
		goto IL_00b8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCircle(CvsCellLocation cellLocation, CvsCogEditingCircle editCircle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (islRvIN8FAcaA5MwFuY())
		{
			goto IL_001e;
		}
		goto IL_00d2;
		IL_001e:
		W2TBHIK8eu = editCircle.Bounds.ToRectangleF();
		num = 4;
		goto IL_00d2;
		IL_00d2:
		CvsCogCircle circle = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 8:
				gWdBKvbtbA = CvsEditFlags.Location | CvsEditFlags.Size;
				_ = 1;
				if (!islRvIN8FAcaA5MwFuY())
				{
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 1;
				}
				num = 1;
				continue;
			case 1:
			case 3:
				circle = editCircle.Circle;
				num = 0;
				continue;
			case 4:
				UniqueId = cellLocation.ToString();
				num = 10;
				if (!islRvIN8FAcaA5MwFuY())
				{
					continue;
				}
				goto case 5;
			case 5:
				Q18jiIxspqCuimd5rPb();
				num = 8;
				if (R7vg7qNJeU4Yl2loBPE())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 6:
				base._002Ector(cellLocation, editCircle);
				goto case 1;
			case 0:
				FromSerializableGraphic(circle);
				goto case 9;
			default:
				num = 9;
				continue;
			case 9:
				EditFlags = (CvsEditFlags)((U0AHgkxhJKgh259y9ao(editCircle) ? 1 : 0) | (uE8A0ExLmsUR5RfE8wD(editCircle) ? 2 : 0));
				num = 7;
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCircle(CvsCellLocation loc, PointF center, float radius, string label)
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
			case 1:
				base._002Ector();
				goto default;
			default:
				_ = 0;
				if (R7vg7qNJeU4Yl2loBPE())
				{
					num = 2;
					continue;
				}
				num = 6;
				if (R7vg7qNJeU4Yl2loBPE())
				{
					continue;
				}
				break;
			case 5:
				Q18jiIxspqCuimd5rPb();
				num = 0;
				continue;
			case 0:
				gWdBKvbtbA = CvsEditFlags.Location | CvsEditFlags.Size;
				num = 1;
				continue;
			case 2:
			case 3:
				Initialize(loc.Row, loc.Column, center.Y, center.X, radius, label);
				break;
			case 4:
			case 6:
				break;
			case 7:
				return;
			}
			UniqueId = loc.ToString();
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCircle()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_008e;
		IL_008e:
		switch (num)
		{
		case 5:
			break;
		case 4:
			goto IL_002f;
		default:
			goto IL_004e;
		case 0:
		case 2:
			goto IL_0076;
		case 6:
			return;
		}
		goto IL_001a;
		IL_0076:
		base._002Ector();
		goto IL_004e;
		IL_004e:
		Initialize(0, 0, 0f, 0f, 0f, "");
		num = 6;
		if (false)
		{
			goto IL_0076;
		}
		goto IL_008e;
		IL_001a:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		num = 4;
		if (!R7vg7qNJeU4Yl2loBPE())
		{
			goto IL_002f;
		}
		goto IL_008e;
		IL_002f:
		gWdBKvbtbA = CvsEditFlags.Location | CvsEditFlags.Size;
		_ = 1;
		if (!islRvIN8FAcaA5MwFuY())
		{
			num = 0;
			if (1 == 0)
			{
				goto IL_004e;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_008e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float centerRow, float centerCol, float circleRadius, string label)
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
			case 5:
				mLabel = label;
				num = 3;
				break;
			case 3:
				T5OPk4x9ZKMSAAL6e9P(this, null);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				CAgB6889VC = circleRadius;
				goto case 5;
			default:
				num = 5;
				if (islRvIN8FAcaA5MwFuY())
				{
				}
				break;
			case 1:
			case 6:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				goto case 2;
			case 2:
			case 4:
				nQJBsYoQXi = new PointF(centerCol, centerRow);
				num = 7;
				break;
			case 0:
				CheckLock();
				_ = 1;
				if (islRvIN8FAcaA5MwFuY())
				{
					num = 4;
					if (!islRvIN8FAcaA5MwFuY())
					{
						break;
					}
					goto case 2;
				}
				num = 6;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicCircle(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogCircle(nQJBsYoQXi.X, nQJBsYoQXi.Y, CAgB6889VC, mColor.ToArgb(), CellLocation.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogCircle circle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				Radius = (float)zLcVP4xvLS1xlhZ2RSn(circle);
				num = 5;
				break;
			case 0:
			case 1:
				Center = new PointF((float)l4F5bGxEB3MNDZno0Mq(circle), (float)circle.Y);
				goto default;
			case 4:
				base.FromSerializableGraphic(circle);
				islRvIN8FAcaA5MwFuY();
				num = ((!R7vg7qNJeU4Yl2loBPE()) ? 3 : 0);
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF eAeCGINzbZoekbjnT0V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCircle)P_0).Center;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float nZdtjtxwcPiCSTrQ1wv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCircle)P_0).Radius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R7vg7qNJeU4Yl2loBPE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool islRvIN8FAcaA5MwFuY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q18jiIxspqCuimd5rPb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool U0AHgkxhJKgh259y9ao(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCircle)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uE8A0ExLmsUR5RfE8wD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCircle)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T5OPk4x9ZKMSAAL6e9P(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double UcXr8vxStoaKqfyibVa(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double l4F5bGxEB3MNDZno0Mq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCircle)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double zLcVP4xvLS1xlhZ2RSn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCircle)P_0).Radius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mwE6UNxHip0Rqhj6XkR(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
