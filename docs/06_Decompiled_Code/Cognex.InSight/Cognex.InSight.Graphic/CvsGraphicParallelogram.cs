using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicParallelogram : CvsGraphic, ICvsEditableGraphic
{
	private PointF HSCJ8i0cY6;

	private float IS3JzXZmAx;

	private float LVvMPXBVW3;

	private float rcFMI0VBQq;

	private float TXeM1QRsL1;

	private Color vhGMx207K6;

	private Color JiGMFojET7;

	private RectangleF jpUMbiGTKw;

	private CvsEditFlags Y2gMa0Kxei;

	[CompilerGenerated]
	private bool wj6MOAiftG;

	public PointF Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HSCJ8i0cY6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sKH2tqOCDwcQTvcsMeF();
			int num = (H7JjKiOKy9qXn5hx5K7() ? 2 : 3);
			do
			{
				IL_0041:
				switch (num)
				{
				case 1:
				case 2:
					HSCJ8i0cY6 = value;
					break;
				default:
					num = 4;
					goto IL_0041;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 4:
					break;
				case 5:
					return;
				}
				lccV4FOYTQoR2wkWsiT(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34080));
				num = 5;
			}
			while (0 == 0);
		}
	}

	public float Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LVvMPXBVW3;
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
				default:
					lccV4FOYTQoR2wkWsiT(this, P5nZc3ON1LJbeJdP7Pu(34428));
					num = 5;
					break;
				case 0:
					CheckLock();
					_ = 1;
					if (!H7JjKiOKy9qXn5hx5K7())
					{
						num = 3;
						break;
					}
					num = 4;
					if (sKH2tqOCDwcQTvcsMeF())
					{
						break;
					}
					return;
				case 1:
				case 3:
					LVvMPXBVW3 = value;
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	public float Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IS3JzXZmAx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sKH2tqOCDwcQTvcsMeF();
			int num = (H7JjKiOKy9qXn5hx5K7() ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					IS3JzXZmAx = value;
					break;
				default:
					num = 4;
					continue;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 4:
					break;
				case 5:
					return;
				}
				lccV4FOYTQoR2wkWsiT(this, P5nZc3ON1LJbeJdP7Pu(34444));
				num = 5;
			}
		}
	}

	public float Rotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rcFMI0VBQq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0059;
			IL_008c:
			lccV4FOYTQoR2wkWsiT(this, P5nZc3ON1LJbeJdP7Pu(34678));
			num = 5;
			if (!sKH2tqOCDwcQTvcsMeF())
			{
				return;
			}
			goto IL_0059;
			IL_0059:
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 1:
				goto IL_0040;
			default:
				goto IL_008c;
			case 5:
				return;
			}
			goto IL_001a;
			IL_0040:
			rcFMI0VBQq = value;
			goto IL_008c;
			IL_001a:
			CheckLock();
			sKH2tqOCDwcQTvcsMeF();
			if (!H7JjKiOKy9qXn5hx5K7())
			{
				num = 0;
				if (H7JjKiOKy9qXn5hx5K7())
				{
					goto IL_0040;
				}
			}
			else
			{
				num = 4;
				if (!sKH2tqOCDwcQTvcsMeF())
				{
					goto IL_008c;
				}
			}
			goto IL_0059;
		}
	}

	public float InteriorAngle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TXeM1QRsL1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sKH2tqOCDwcQTvcsMeF();
			int num = (H7JjKiOKy9qXn5hx5K7() ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 1:
					TXeM1QRsL1 = value;
					break;
				case 0:
				case 3:
					CheckLock();
					num = 1;
					continue;
				case 5:
					return;
				}
				lccV4FOYTQoR2wkWsiT(this, P5nZc3ON1LJbeJdP7Pu(34698));
				num = 5;
			}
		}
	}

	public float Area
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			double num = (double)TXeM1QRsL1 * Math.PI / 180.0;
			return (float)((double)(IS3JzXZmAx * LVvMPXBVW3) * num);
		}
	}

	public Color LabelForeColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vhGMx207K6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!sKH2tqOCDwcQTvcsMeF())
			{
				goto IL_001e;
			}
			goto IL_0037;
			IL_001e:
			vhGMx207K6 = value;
			goto IL_0064;
			IL_0037:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					goto IL_0064;
				case 4:
					goto IL_007e;
				case 5:
					return;
				}
				break;
				IL_007e:
				CheckLock();
				_ = 0;
				num = (sKH2tqOCDwcQTvcsMeF() ? 3 : 0);
			}
			goto IL_001e;
			IL_0064:
			lccV4FOYTQoR2wkWsiT(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34524));
			num = 5;
			goto IL_0037;
		}
	}

	public Color LabelBackColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JiGMFojET7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 4:
					CheckLock();
					sKH2tqOCDwcQTvcsMeF();
					num = (H7JjKiOKy9qXn5hx5K7() ? 3 : 0);
					continue;
				case 0:
				case 1:
					JiGMFojET7 = value;
					break;
				case 5:
					return;
				}
				lccV4FOYTQoR2wkWsiT(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34556));
				num = 5;
			}
		}
	}

	public bool ShouldCenterLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wj6MOAiftG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wj6MOAiftG = value;
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
			return Y2gMa0Kxei;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			H7JjKiOKy9qXn5hx5K7();
			int num;
			if (sKH2tqOCDwcQTvcsMeF())
			{
				num = 3;
			}
			else
			{
				num = 1;
				if (H7JjKiOKy9qXn5hx5K7())
				{
				}
			}
			do
			{
				IL_0043:
				switch (num)
				{
				case 4:
					Y2gMa0Kxei = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
					break;
				case 0:
				case 3:
					CheckLock();
					num = 4;
					goto IL_0043;
				case 5:
					return;
				}
				OnPropertyChanged((string)P5nZc3ON1LJbeJdP7Pu(33720));
				num = 5;
			}
			while (true);
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
			return jpUMbiGTKw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sKH2tqOCDwcQTvcsMeF();
			int num = (H7JjKiOKy9qXn5hx5K7() ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 2:
					lccV4FOYTQoR2wkWsiT(this, P5nZc3ON1LJbeJdP7Pu(33862));
					num = 5;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					jpUMbiGTKw = value;
					goto case 2;
				default:
					num = 2;
					break;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicParallelogram()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (H7JjKiOKy9qXn5hx5K7() ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				wjBgt9O59TjELBNc9D3();
				goto case 1;
			case 2:
				Initialize(0, 0, 0f, 0f, 0f, 0f, 0f, 0f, string.Empty);
				num = 6;
				break;
			case 1:
			case 5:
				Y2gMa0Kxei = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 3;
				break;
			case 3:
				base._002Ector();
				goto case 2;
			default:
				num = 2;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicParallelogram(string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		H7JjKiOKy9qXn5hx5K7();
		int num = ((!sKH2tqOCDwcQTvcsMeF()) ? 5 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				wjBgt9O59TjELBNc9D3();
				goto case 1;
			case 4:
				base._002Ector();
				break;
			default:
				num = 2;
				continue;
			case 1:
			case 5:
				Y2gMa0Kxei = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 4;
				continue;
			case 2:
				break;
			case 6:
				return;
			}
			Initialize(0, 0, 0f, 0f, 0f, 0f, 0f, 0f, label);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicParallelogram(CvsGraphicParallelogram graphic)
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
			case 9:
				Y2gMa0Kxei = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				_ = 0;
				num = ((!sKH2tqOCDwcQTvcsMeF()) ? 11 : 10);
				break;
			case 8:
				jpUMbiGTKw = graphic.jpUMbiGTKw;
				num = 0;
				break;
			case 6:
				JiGMFojET7 = graphic.JiGMFojET7;
				vhGMx207K6 = graphic.vhGMx207K6;
				num = 8;
				break;
			case 7:
				TXeM1QRsL1 = graphic.TXeM1QRsL1;
				num = 12;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				HSCJ8i0cY6 = graphic.HSCJ8i0cY6;
				num = 3;
				break;
			case 4:
				wjBgt9O59TjELBNc9D3();
				num = 9;
				break;
			case 2:
			case 10:
				base._002Ector(graphic);
				num = 1;
				break;
			case 0:
				Y2gMa0Kxei = graphic.Y2gMa0Kxei;
				num = 13;
				if (sKH2tqOCDwcQTvcsMeF())
				{
					break;
				}
				goto case 12;
			case 12:
				rcFMI0VBQq = graphic.rcFMI0VBQq;
				num = 6;
				break;
			case 3:
				IS3JzXZmAx = graphic.IS3JzXZmAx;
				goto case 5;
			case 5:
			case 11:
				LVvMPXBVW3 = graphic.LVvMPXBVW3;
				goto case 7;
			default:
				num = 7;
				if (1 == 0)
				{
					return;
				}
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicParallelogram(PointF topLeft, PointF bottomLeft, PointF bottomRight, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!H7JjKiOKy9qXn5hx5K7()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				this._002Ector(label);
				break;
			case 0:
			case 1:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 3;
				continue;
			case 5:
				return;
			}
			InitializeFromPoints(topLeft, bottomLeft, bottomRight);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float regionRow, float regionCol, float regionHeight, float regionWidth, float regionRotation, float regionInteriorAngle, string regionLabel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 2:
				rcFMI0VBQq = regionRotation;
				goto case 0;
			case 4:
				HSCJ8i0cY6 = new PointF(regionCol, regionRow);
				H7JjKiOKy9qXn5hx5K7();
				num = (sKH2tqOCDwcQTvcsMeF() ? 10 : 0);
				break;
			case 9:
				LVvMPXBVW3 = regionHeight;
				goto case 2;
			default:
				num = 2;
				break;
			case 8:
				mLabel = regionLabel;
				num = 7;
				break;
			case 0:
			case 6:
				TXeM1QRsL1 = regionInteriorAngle;
				num = 8;
				break;
			case 1:
				CheckLock();
				num = 5;
				break;
			case 7:
				OnPropertyChanged(null);
				num = 11;
				break;
			case 3:
			case 10:
				IS3JzXZmAx = regionWidth;
				num = 9;
				break;
			case 5:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 4;
				if (H7JjKiOKy9qXn5hx5K7())
				{
				}
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void InitializeFromPoints(PointF pointA, PointF pointB, PointF pointC)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		float num4 = default;
		double num2 = default;
		double num7 = default;
		float num3 = default;
		double num6 = default;
		double num5 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				num4 = pointC.X - pointB.X;
				H7JjKiOKy9qXn5hx5K7();
				num = ((!sKH2tqOCDwcQTvcsMeF()) ? 10 : 5);
				break;
			case 6:
				rcFMI0VBQq = (float)(num2 * 180.0 / Math.PI);
				TXeM1QRsL1 = (float)(num7 * 180.0 / Math.PI);
				num = 13;
				break;
			case 2:
				num4 = pointA.X - pointB.X;
				num3 = pointB.Y - pointA.Y;
				num = 12;
				break;
			case 0:
				IS3JzXZmAx = (float)num6;
				num = 11;
				break;
			case 9:
				num7 = OjbBcvOo6eJSOdVFtCv(num3, num4) - num2;
				goto case 7;
			case 8:
				num6 = ecFO0EOP0aAsUqFxBfV(num4 * num4 + num3 * num3);
				num = 2;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
			case 10:
				HSCJ8i0cY6 = pointB;
				num = 0;
				break;
			case 1:
			case 5:
				num3 = pointB.Y - pointC.Y;
				num = 4;
				break;
			case 12:
				num5 = Math.Sqrt(num4 * num4 + num3 * num3);
				goto case 9;
			default:
				num = 9;
				break;
			case 11:
				LVvMPXBVW3 = (float)num5;
				num = 6;
				if (H7JjKiOKy9qXn5hx5K7())
				{
				}
				break;
			case 4:
				num2 = OjbBcvOo6eJSOdVFtCv(num3, num4);
				num = 8;
				if (1 == 0)
				{
					return;
				}
				break;
			case 13:
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
		return new CvsGraphicParallelogram(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double[] GetPointData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		PointF location = default;
		double num5 = default;
		double num10 = default;
		double num9 = default;
		double num8 = default;
		double num2 = default;
		double num4 = default;
		double num3 = default;
		double num6 = default;
		double num7 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 8:
				location = Location;
				goto case 1;
			case 5:
				location = Location;
				goto case 0;
			default:
				num = 0;
				break;
			case 4:
				num5 = num10 * QylnBoO135McEj08A96(num9 + num8);
				num = 11;
				if (H7JjKiOKy9qXn5hx5K7())
				{
				}
				break;
			case 1:
			case 3:
				num2 = location.X;
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				num4 = location.Y;
				num = 6;
				break;
			case 7:
				num8 = (double)Rotation * Math.PI / 180.0;
				num = 10;
				if (sKH2tqOCDwcQTvcsMeF())
				{
					break;
				}
				goto case 10;
			case 10:
				num9 = (double)InteriorAngle * Math.PI / 180.0;
				sKH2tqOCDwcQTvcsMeF();
				if (H7JjKiOKy9qXn5hx5K7())
				{
					num = 1;
					break;
				}
				num = 8;
				if (true)
				{
					break;
				}
				goto case 9;
			case 9:
				num3 = num10 * StQgK4Oxtl6PCgZuN7K(num9 + num8);
				num = 4;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
			{
				double num11 = Width;
				num10 = Height;
				num6 = num11 * Math.Cos(num8);
				num7 = num11 * Math.Sin(num8);
				num = 9;
				break;
			}
			case 11:
				return new double[8]
				{
					num2 + num3,
					num4 - num5,
					num2 + num6 + num3,
					num4 - num7 - num5,
					num2 + num6,
					num4 + num7,
					num2,
					num4
				};
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wjBgt9O59TjELBNc9D3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sKH2tqOCDwcQTvcsMeF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H7JjKiOKy9qXn5hx5K7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double OjbBcvOo6eJSOdVFtCv(double P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Atan2(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ecFO0EOP0aAsUqFxBfV(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Sqrt(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lccV4FOYTQoR2wkWsiT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P5nZc3ON1LJbeJdP7Pu(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double StQgK4Oxtl6PCgZuN7K(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Cos(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double QylnBoO135McEj08A96(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Sin(P_0);
	}
}
