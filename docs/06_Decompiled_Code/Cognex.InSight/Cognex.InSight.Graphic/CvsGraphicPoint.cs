using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicPoint : CvsGraphic, ICvsEditableGraphic
{
	private PointF bTqM4E48bb;

	private RectangleF MfqMlAYGbO;

	private CvsEditFlags AwvMgMbeFd;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new double[2]
			{
				PMdHxUOaGZfLgP7Ku4k(bTqM4E48bb.Y),
				PMdHxUOaGZfLgP7Ku4k(bTqM4E48bb.X)
			};
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
			return bTqM4E48bb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RV58ldOQRHVn7yxuLY5();
			int num;
			if (WElXhkOMS9HiANhTB8w())
			{
				num = 1;
				if (!WElXhkOMS9HiANhTB8w())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0076;
				}
			}
			goto IL_0047;
			IL_0086:
			B6WqefOXOkOe8B7BEuQ(this, bRIqCLOGr7DmmLqsStA(34080));
			num = 5;
			goto IL_0047;
			IL_0076:
			CheckLock();
			num = 4;
			goto IL_0047;
			IL_002e:
			bTqM4E48bb = value;
			goto IL_0086;
			IL_0047:
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 1:
				goto IL_0076;
			default:
				goto IL_0086;
			case 5:
				return;
			}
			goto IL_002e;
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
			return AwvMgMbeFd;
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
					RV58ldOQRHVn7yxuLY5();
					if (WElXhkOMS9HiANhTB8w())
					{
						num = 3;
						if (WElXhkOMS9HiANhTB8w())
						{
							break;
						}
						goto default;
					}
					num = 0;
					if (false)
					{
						return;
					}
					break;
				default:
					B6WqefOXOkOe8B7BEuQ(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
					num = 5;
					break;
				case 1:
				case 3:
					AwvMgMbeFd = value & CvsEditFlags.Location;
					goto default;
				case 5:
					return;
				}
			}
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
			return MfqMlAYGbO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (RV58ldOQRHVn7yxuLY5() ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					MfqMlAYGbO = value;
					break;
				default:
					num = 3;
					continue;
				case 3:
					break;
				case 0:
				case 4:
					CheckLock();
					goto case 1;
				case 5:
					return;
				}
				B6WqefOXOkOe8B7BEuQ(this, bRIqCLOGr7DmmLqsStA(33862));
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPoint(CvsGraphicPoint graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RV58ldOQRHVn7yxuLY5();
		int num = ((!WElXhkOMS9HiANhTB8w()) ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				AwvMgMbeFd = CvsEditFlags.Location;
				num = 2;
				continue;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 3:
				bTqM4E48bb = graphic.bTqM4E48bb;
				num = 6;
				continue;
			case 2:
				base._002Ector(graphic);
				goto case 3;
			case 6:
				return;
			}
			num = 3;
			if (RV58ldOQRHVn7yxuLY5())
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPoint(CvsCellLocation cellLocation, CvsCogEditingPoint editPoint)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WElXhkOMS9HiANhTB8w();
		int num;
		if (!RV58ldOQRHVn7yxuLY5())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (RV58ldOQRHVn7yxuLY5())
			{
				goto IL_008c;
			}
		}
		goto IL_00df;
		IL_002a:
		EditFlags = (editPoint.Move ? CvsEditFlags.Location : CvsEditFlags.None);
		MfqMlAYGbO = H0YaEIOR0DjtJrhvqC2(op5DssOIIBQLQMxnIMy(editPoint));
		num = 8;
		goto IL_00df;
		IL_00a4:
		AwvMgMbeFd = CvsEditFlags.Location;
		num = 6;
		if (1 == 0)
		{
			goto IL_00b7;
		}
		goto IL_00df;
		IL_008c:
		base._002Ector(cellLocation, editPoint);
		num = 2;
		if (!WElXhkOMS9HiANhTB8w())
		{
			goto IL_00a4;
		}
		goto IL_00df;
		IL_00df:
		CvsCogPoint cvsCogPoint = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 7:
				bTqM4E48bb = new PointF((float)drlxQAOuv3Cf5obBLck(cvsCogPoint), (float)cvsCogPoint.Y);
				break;
			case 6:
				goto IL_008c;
			case 4:
				goto IL_00a4;
			case 0:
			case 3:
				goto IL_00b7;
			case 2:
				cvsCogPoint = (CvsCogPoint)ySZS3pOeQDPHFfWQGct(editPoint);
				goto case 7;
			default:
				num = 7;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_00b7:
		pRN3D7OlC2RR4xTkLIU();
		num = 4;
		goto IL_00df;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPoint(CvsCellLocation cellLocation, PointF point, string label)
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
			case 2:
				pRN3D7OlC2RR4xTkLIU();
				WElXhkOMS9HiANhTB8w();
				if (!RV58ldOQRHVn7yxuLY5())
				{
					num = 4;
					if (WElXhkOMS9HiANhTB8w())
					{
						continue;
					}
					goto case 5;
				}
				num = 0;
				continue;
			case 5:
				base._002Ector(cellLocation, label);
				goto default;
			default:
				bTqM4E48bb = new PointF(point.X, point.Y);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 1:
			case 4:
				break;
			case 6:
				return;
			}
			AwvMgMbeFd = CvsEditFlags.Location;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPoint()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (RV58ldOQRHVn7yxuLY5() ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
				base._002Ector();
				goto default;
			default:
				Initialize(0, 0, 0f, 0f, "");
				num = 6;
				break;
			case 2:
				AwvMgMbeFd = CvsEditFlags.Location;
				num = 1;
				break;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 2;
				if (false)
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float pointRow, float pointCol, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!RV58ldOQRHVn7yxuLY5())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0046;
		IL_00c3:
		mLabel = label;
		num = 3;
		if (RV58ldOQRHVn7yxuLY5())
		{
			return;
		}
		goto IL_0046;
		IL_0046:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				break;
			default:
				num = 1;
				if (RV58ldOQRHVn7yxuLY5())
				{
				}
				continue;
			case 0:
			case 6:
				CheckLock();
				num = 5;
				continue;
			case 3:
				OnPropertyChanged(null);
				num = 7;
				if (WElXhkOMS9HiANhTB8w())
				{
					continue;
				}
				goto case 5;
			case 5:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				break;
			case 1:
				goto IL_00c3;
			case 7:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		bTqM4E48bb = new PointF(pointCol, pointRow);
		goto IL_00c3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicPoint(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogPoint(bTqM4E48bb.X, bTqM4E48bb.Y, Color.ToArgb(), CellLocation.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogPoint point)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(point);
		Location = new PointF((float)point.X, (float)SgY8GZOnFU2mYidMn3T(point));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WElXhkOMS9HiANhTB8w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RV58ldOQRHVn7yxuLY5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pRN3D7OlC2RR4xTkLIU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ySZS3pOeQDPHFfWQGct(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPoint)P_0).Point;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double drlxQAOuv3Cf5obBLck(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPoint)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object op5DssOIIBQLQMxnIMy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF H0YaEIOR0DjtJrhvqC2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).ToRectangleF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double PMdHxUOaGZfLgP7Ku4k(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double SgY8GZOnFU2mYidMn3T(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPoint)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bRIqCLOGr7DmmLqsStA(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B6WqefOXOkOe8B7BEuQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}
}
