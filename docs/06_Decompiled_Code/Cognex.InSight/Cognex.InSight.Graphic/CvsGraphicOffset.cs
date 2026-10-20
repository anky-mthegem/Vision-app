using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicOffset : CvsGraphic, ICvsEditableGraphic
{
	private PointF geyJ2p5AKd;

	private PointF pgmJyPH9xv;

	private float MfxJVcE6eY;

	private RectangleF r8GJvicSFH;

	private CvsEditFlags D24JZlgEnt;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			double[] array = new double[2];
			double num = geyJ2p5AKd.Y - pgmJyPH9xv.Y;
			double num2 = geyJ2p5AKd.X - pgmJyPH9xv.X;
			double num3 = fXGkHHOc7U8xk5b7sZg(num * num + num2 * num2);
			double num4 = AWthxTO2Vp5aTbNHCy7(num, num2) + (double)MfxJVcE6eY * Math.PI / 180.0;
			double num5 = num3 * Math.Sin(num4);
			double a = num3 * ucjNAnOWnTHoukWxAmR(num4);
			array[0] = cmu9NGO7kevtXb9eYOq(num5);
			array[1] = Math.Round(a);
			return array;
		}
	}

	public PointF Offset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return geyJ2p5AKd;
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
			goto IL_004d;
			IL_001a:
			aXLnTOODguo136sISt6(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34646));
			num = 5;
			goto IL_004d;
			IL_004d:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					geyJ2p5AKd = value;
					break;
				case 3:
					CheckLock();
					RubZj1OVdPmVeeFyZA9();
					num = (K5kllCOHZGpLjoVWb3G() ? 4 : 0);
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public PointF Origin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pgmJyPH9xv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RubZj1OVdPmVeeFyZA9();
			int num = ((!K5kllCOHZGpLjoVWb3G()) ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					CheckLock();
					num = 1;
					continue;
				case 1:
					pgmJyPH9xv = value;
					break;
				case 5:
					return;
				}
				aXLnTOODguo136sISt6(this, H5DIG4Ots1kbVKZQQpq(34662));
				num = 5;
			}
		}
	}

	public float Angle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MfxJVcE6eY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			K5kllCOHZGpLjoVWb3G();
			int num;
			if (!RubZj1OVdPmVeeFyZA9())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_006d;
			IL_002a:
			OnPropertyChanged((string)H5DIG4Ots1kbVKZQQpq(34112));
			num = 5;
			goto IL_006d;
			IL_006d:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					goto IL_0044;
				case 1:
					MfxJVcE6eY = value;
					break;
				case 5:
					return;
				}
				break;
				IL_0044:
				CheckLock();
				num = 1;
			}
			goto IL_002a;
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
			return D24JZlgEnt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0071;
			IL_001a:
			CheckLock();
			_ = 0;
			if (K5kllCOHZGpLjoVWb3G())
			{
				num = 3;
				if (RubZj1OVdPmVeeFyZA9())
				{
					goto IL_003c;
				}
			}
			else
			{
				num = 0;
			}
			goto IL_0071;
			IL_0071:
			switch (num)
			{
			case 4:
				break;
			default:
				goto IL_003c;
			case 1:
			case 3:
				D24JZlgEnt = value & CvsEditFlags.Location;
				goto IL_003c;
			case 5:
				return;
			}
			goto IL_001a;
			IL_003c:
			OnPropertyChanged(kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
			num = 5;
			goto IL_0071;
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
			return r8GJvicSFH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!K5kllCOHZGpLjoVWb3G()) ? 1 : 4);
			do
			{
				IL_004f:
				switch (num)
				{
				case 0:
				case 4:
					CheckLock();
					num = 3;
					if (true)
					{
						goto IL_004f;
					}
					goto case 3;
				case 3:
					r8GJvicSFH = value;
					break;
				case 5:
					return;
				}
				OnPropertyChanged((string)H5DIG4Ots1kbVKZQQpq(33862));
				num = 5;
			}
			while (K5kllCOHZGpLjoVWb3G());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicOffset(CvsGraphicOffset graphic)
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
			case 6:
				pgmJyPH9xv = graphic.pgmJyPH9xv;
				num = 0;
				if (RubZj1OVdPmVeeFyZA9())
				{
				}
				break;
			case 3:
			case 5:
				geyJ2p5AKd = graphic.geyJ2p5AKd;
				goto case 6;
			default:
				num = 6;
				break;
			case 4:
				D24JZlgEnt = CvsEditFlags.Location;
				_ = 1;
				if (!RubZj1OVdPmVeeFyZA9())
				{
					num = 7;
					if (K5kllCOHZGpLjoVWb3G())
					{
						break;
					}
					goto case 2;
				}
				num = 5;
				break;
			case 2:
			case 7:
				base._002Ector(graphic);
				goto case 3;
			case 0:
				MfxJVcE6eY = graphic.MfxJVcE6eY;
				num = 8;
				break;
			case 1:
				UkjuOVOAaQsKKKPElQh();
				num = 4;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicOffset(CvsCellLocation cellLocation, PointF offset, PointF origin, float angle, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		K5kllCOHZGpLjoVWb3G();
		int num = (RubZj1OVdPmVeeFyZA9() ? 1 : 2);
		while (true)
		{
			switch (num)
			{
			case 3:
				MfxJVcE6eY = angle;
				num = 8;
				break;
			case 5:
				base._002Ector(cellLocation, label);
				num = 6;
				if (!RubZj1OVdPmVeeFyZA9())
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 7;
				break;
			case 6:
				geyJ2p5AKd = offset;
				goto default;
			default:
				pgmJyPH9xv = origin;
				num = 3;
				break;
			case 7:
				D24JZlgEnt = CvsEditFlags.Location;
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicOffset()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!K5kllCOHZGpLjoVWb3G()) ? 2 : 5);
		while (true)
		{
			switch (num)
			{
			case 3:
				Initialize(0, 0, 0f, 0f, 0f, 0f, 0f, "");
				num = 6;
				continue;
			case 0:
			case 5:
				UkjuOVOAaQsKKKPElQh();
				break;
			case 4:
				base._002Ector();
				goto case 3;
			default:
				num = 3;
				if (K5kllCOHZGpLjoVWb3G())
				{
					continue;
				}
				break;
			case 1:
			case 2:
				break;
			case 6:
				return;
			}
			D24JZlgEnt = CvsEditFlags.Location;
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float offsetRow, float offsetCol, float originRow, float originCol, float angle, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (RubZj1OVdPmVeeFyZA9() ? 4 : 6);
		while (true)
		{
			switch (num)
			{
			case 8:
				aXLnTOODguo136sISt6(this, null);
				num = 9;
				break;
			case 7:
				pgmJyPH9xv = new PointF(originCol, originRow);
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 4:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 3;
				break;
			case 3:
				geyJ2p5AKd = new PointF(offsetCol, offsetRow);
				num = 7;
				break;
			case 5:
				MfxJVcE6eY = angle;
				num = 2;
				if (K5kllCOHZGpLjoVWb3G())
				{
					break;
				}
				goto case 0;
			case 0:
			case 6:
				CheckLock();
				goto case 1;
			case 2:
				mLabel = label;
				num = 8;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicOffset(CvsCellLocation cellLocation, CvsCogEditingOffset editOffset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsCogOffset cvsCogOffset = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 8:
				r8GJvicSFH = i1y39vOjXbe71TR62Vj(Dx5B0dOBlauS7BGZUBf(editOffset));
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
			case 7:
				mLabel = string.Empty;
				num = 9;
				continue;
			case 5:
				base._002Ector(cellLocation, editOffset);
				num = 1;
				continue;
			case 4:
				D24JZlgEnt = CvsEditFlags.Location;
				num = 5;
				continue;
			case 2:
				geyJ2p5AKd = new PointF((float)dwRlMmOTfHGYXk8ObJo(cvsCogOffset), (float)NQwm1MOd7tCTBc6Vgil(cvsCogOffset));
				pgmJyPH9xv = new PointF((float)cvsCogOffset.XOrigin, (float)cvsCogOffset.YOrigin);
				break;
			default:
				num = 10;
				continue;
			case 3:
				UkjuOVOAaQsKKKPElQh();
				num = 4;
				continue;
			case 1:
				cvsCogOffset = (CvsCogOffset)yJgCYoOUY9kT8BPh2ew(editOffset);
				num = 2;
				continue;
			case 9:
				EditFlags = (CvsEditFlags)((bef7JiOiif7E68iKKsl(editOffset) ? 1 : 0) | (editOffset.Rotate ? 4 : 0) | (emaSITOqecJxMs27LE7(editOffset) ? 2 : 0));
				goto case 0;
			case 10:
				break;
			case 11:
				return;
			}
			do
			{
				MfxJVcE6eY = (float)cvsCogOffset.Angle;
				K5kllCOHZGpLjoVWb3G();
				if (RubZj1OVdPmVeeFyZA9())
				{
					num = 0;
					continue;
				}
				num = 7;
				break;
			}
			while (1 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogOffset(geyJ2p5AKd.X, geyJ2p5AKd.Y, pgmJyPH9xv.X, pgmJyPH9xv.Y, MfxJVcE6eY);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicOffset(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UkjuOVOAaQsKKKPElQh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K5kllCOHZGpLjoVWb3G()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RubZj1OVdPmVeeFyZA9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aXLnTOODguo136sISt6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yJgCYoOUY9kT8BPh2ew(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingOffset)P_0).Offset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double dwRlMmOTfHGYXk8ObJo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogOffset)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double NQwm1MOd7tCTBc6Vgil(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogOffset)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bef7JiOiif7E68iKKsl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingOffset)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool emaSITOqecJxMs27LE7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingOffset)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dx5B0dOBlauS7BGZUBf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF i1y39vOjXbe71TR62Vj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).ToRectangleF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double fXGkHHOc7U8xk5b7sZg(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Sqrt(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double AWthxTO2Vp5aTbNHCy7(double P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Atan2(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ucjNAnOWnTHoukWxAmR(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Cos(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double cmu9NGO7kevtXb9eYOq(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Round(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H5DIG4Ots1kbVKZQQpq(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
