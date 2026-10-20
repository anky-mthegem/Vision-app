using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicArc : CvsGraphic
{
	private PointF hwZBaanrIE;

	private float a98BOaVsbp;

	private float ACXBp9NNXK;

	private float mIrBhTZ4gS;

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hwZBaanrIE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g9JxDjYrFemGChN5nUG();
			int num = (wrXO0NY3P0FKKaiouw2() ? 3 : 2);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					CheckLock();
					goto case 1;
				case 4:
					nR0kHfYev1pcCkWMgqj(this, SrrmCyYRVZPgy2qbqph(33886));
					num = 5;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 3:
					hwZBaanrIE = value;
					goto case 4;
				default:
					num = 4;
					if (!g9JxDjYrFemGChN5nUG())
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

	public float StartAngle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return a98BOaVsbp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g9JxDjYrFemGChN5nUG();
			int num;
			if (!wrXO0NY3P0FKKaiouw2())
			{
				num = 3;
				if (wrXO0NY3P0FKKaiouw2())
				{
				}
			}
			else
			{
				num = 4;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 1:
				case 4:
					a98BOaVsbp = value;
					break;
				default:
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 5:
					return;
				}
				nR0kHfYev1pcCkWMgqj(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33954));
				num = 5;
			}
		}
	}

	public float EndAngle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ACXBp9NNXK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g9JxDjYrFemGChN5nUG();
			int num = (wrXO0NY3P0FKKaiouw2() ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 4:
					nR0kHfYev1pcCkWMgqj(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33978));
					num = 5;
					continue;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 1:
				case 2:
					ACXBp9NNXK = value;
					goto case 4;
				case 5:
					return;
				}
				num = 4;
				if (wrXO0NY3P0FKKaiouw2())
				{
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
			return mIrBhTZ4gS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (wrXO0NY3P0FKKaiouw2() ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 4:
					OnPropertyChanged((string)SrrmCyYRVZPgy2qbqph(33998));
					num = 5;
					break;
				case 1:
				case 2:
					mIrBhTZ4gS = value;
					goto case 4;
				default:
					num = 4;
					break;
				case 5:
					return;
				}
			}
		}
	}

	public bool CounterClockwise
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ACXBp9NNXK >= a98BOaVsbp;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicArc(CvsGraphicArc graphic)
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
			case 5:
				hwZBaanrIE = tDMpyMYMvJrP9QNZ64w(graphic);
				goto case 0;
			case 4:
				ACXBp9NNXK = y6te9EYlXR4N1qUCaD1(graphic);
				num = 6;
				break;
			case 0:
			case 3:
				a98BOaVsbp = XyGX38YQXeMsquS32kP(graphic);
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				mIrBhTZ4gS = graphic.Radius;
				num = 8;
				break;
			case 1:
			case 2:
				base._002Ector(graphic);
				num = 5;
				break;
			case 7:
				TUqkRZYORSw7P6U59Bb();
				_ = 0;
				num = (g9JxDjYrFemGChN5nUG() ? 2 : 0);
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicArc(CvsCellLocation cellLocation, PointF center, float startAngle, float endAngle, float radius, string label)
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
			case 4:
				a98BOaVsbp = startAngle;
				goto case 6;
			default:
				num = 6;
				break;
			case 2:
			case 5:
				mIrBhTZ4gS = radius;
				num = 8;
				break;
			case 6:
				ACXBp9NNXK = endAngle;
				goto case 2;
			case 1:
			case 3:
				base._002Ector(cellLocation, label);
				num = 0;
				break;
			case 0:
				hwZBaanrIE = center;
				num = 4;
				break;
			case 7:
				TUqkRZYORSw7P6U59Bb();
				_ = 0;
				num = (g9JxDjYrFemGChN5nUG() ? 3 : 2);
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicArc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		g9JxDjYrFemGChN5nUG();
		int num;
		if (!wrXO0NY3P0FKKaiouw2())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0042;
		IL_007e:
		Initialize(0, 0, 0f, 0f, 0f, 0f, 0f, "");
		num = 5;
		goto IL_0042;
		IL_0042:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				num = 3;
				continue;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				break;
			case 3:
				goto IL_007e;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		base._002Ector();
		goto IL_007e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float centerRow, float centerCol, float startAngle, float endAngle, float radius, string label)
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
			case 5:
				CheckLock();
				num = 3;
				break;
			case 1:
				a98BOaVsbp = startAngle;
				num = 4;
				if (!wrXO0NY3P0FKKaiouw2())
				{
					break;
				}
				goto case 6;
			case 6:
			case 7:
				nR0kHfYev1pcCkWMgqj(this, null);
				num = 10;
				if (g9JxDjYrFemGChN5nUG())
				{
					break;
				}
				goto case 9;
			case 9:
				mIrBhTZ4gS = radius;
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 8:
				hwZBaanrIE = new PointF(centerCol, centerRow);
				num = 1;
				break;
			case 0:
				mLabel = label;
				goto case 6;
			case 3:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				wrXO0NY3P0FKKaiouw2();
				if (!g9JxDjYrFemGChN5nUG())
				{
					num = 6;
					break;
				}
				num = 8;
				if (wrXO0NY3P0FKKaiouw2())
				{
				}
				break;
			case 4:
				ACXBp9NNXK = endAngle;
				goto case 9;
			default:
				num = 9;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogArc arc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0061;
		IL_001a:
		a98BOaVsbp = pHglhLYIO7rrvTPOOks(arc);
		goto IL_00c3;
		IL_0061:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 3:
				hwZBaanrIE = new PointF(arc.X, arc.Y);
				break;
			default:
				num = 5;
				continue;
			case 2:
				base.FromSerializableGraphic(arc);
				_ = 0;
				if (!g9JxDjYrFemGChN5nUG())
				{
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 3;
				}
				num = 6;
				continue;
			case 1:
			case 6:
				mIrBhTZ4gS = w8UANlYuh5JSxthLIkt(arc);
				num = 3;
				continue;
			case 0:
			case 4:
				goto IL_00c3;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_00c3:
		ACXBp9NNXK = arc.Angle1;
		num = 7;
		if (false)
		{
			return;
		}
		goto IL_0061;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicArc(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogArc(Center.X, Center.Y, StartAngle, EndAngle, Radius, !CounterClockwise, Color.ToArgb(), CellLocation.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TUqkRZYORSw7P6U59Bb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF tDMpyMYMvJrP9QNZ64w(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicArc)P_0).Center;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float XyGX38YQXeMsquS32kP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicArc)P_0).StartAngle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float y6te9EYlXR4N1qUCaD1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicArc)P_0).EndAngle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool g9JxDjYrFemGChN5nUG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wrXO0NY3P0FKKaiouw2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nR0kHfYev1pcCkWMgqj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float w8UANlYuh5JSxthLIkt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogArc)P_0).Radius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float pHglhLYIO7rrvTPOOks(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogArc)P_0).Angle0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SrrmCyYRVZPgy2qbqph(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
