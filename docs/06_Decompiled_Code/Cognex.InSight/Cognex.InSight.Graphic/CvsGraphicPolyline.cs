using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicPolyline : CvsGraphic, ICvsEditableGraphic
{
	private readonly List<PointF> uZUMcKI5Uu;

	private RectangleF Pj0M5xNpIT;

	private CvsEditFlags hmsMYdPyFf;

	public int NumPoints
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (uZUMcKI5Uu == null)
			{
				return 0;
			}
			return gKsmwoMox6ogYq7W8r4(uZUMcKI5Uu);
		}
	}

	public PointF[] Points
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uZUMcKI5Uu.ToArray();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (hewCdOMtDAZMJ3J97hS() ? 4 : 2);
			while (true)
			{
				switch (num)
				{
				case 3:
					kCMPbgM5htujM37Lsyi(this, LosQ81MPyy6wEM9oFF3(34728));
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					uZUMcKI5Uu.AddRange(value);
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 2:
					C2eUtEMKTIAKFeFabxU(uZUMcKI5Uu);
					goto case 1;
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
			return hmsMYdPyFf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hewCdOMtDAZMJ3J97hS();
			int num = ((!rZO1JLM7ViWpk3Xos7D()) ? 3 : 2);
			while (true)
			{
				switch (num)
				{
				case 4:
					kCMPbgM5htujM37Lsyi(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
					num = 5;
					continue;
				case 0:
				case 2:
					CheckLock();
					goto case 1;
				case 1:
				case 3:
					hmsMYdPyFf = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem);
					goto case 4;
				case 5:
					return;
				}
				num = 4;
				if (false)
				{
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
			return Pj0M5xNpIT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!rZO1JLM7ViWpk3Xos7D()) ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				default:
					kCMPbgM5htujM37Lsyi(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33862));
					num = 5;
					break;
				case 0:
				case 4:
					CheckLock();
					num = 1;
					break;
				case 1:
					Pj0M5xNpIT = value;
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolyline(CvsGraphicPolyline graphic)
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
		goto IL_0058;
		IL_009f:
		base._002Ector(graphic);
		num = 6;
		if (0 == 0)
		{
			goto IL_0058;
		}
		goto IL_00b2;
		IL_00b2:
		uZUMcKI5Uu = new List<PointF>();
		goto IL_003b;
		IL_003b:
		hmsMYdPyFf = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
		goto IL_009f;
		IL_001a:
		leAwOYMCPuaNee6tr2d();
		_ = 1;
		if (!hewCdOMtDAZMJ3J97hS())
		{
			num = 3;
			if (!rZO1JLM7ViWpk3Xos7D())
			{
				goto IL_003b;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0058;
		IL_0058:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
			case 4:
				goto IL_003b;
			default:
				num = 0;
				continue;
			case 6:
				uZUMcKI5Uu = graphic.uZUMcKI5Uu;
				num = 7;
				if (true)
				{
					continue;
				}
				goto IL_009f;
			case 0:
				goto IL_009f;
			case 1:
			case 3:
				goto IL_00b2;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolyline()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hewCdOMtDAZMJ3J97hS();
		int num = ((!rZO1JLM7ViWpk3Xos7D()) ? 3 : 5);
		while (true)
		{
			switch (num)
			{
			case 2:
				hmsMYdPyFf = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				uZUMcKI5Uu = new List<PointF>();
				num = 2;
				continue;
			case 4:
				break;
			case 0:
			case 5:
				leAwOYMCPuaNee6tr2d();
				goto case 1;
			case 6:
				return;
			}
			base._002Ector();
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, PointF[] points)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_005e;
		IL_001a:
		mCellLocation = new CvsCellLocation(cellRow, cellCol);
		rZO1JLM7ViWpk3Xos7D();
		num = ((!hewCdOMtDAZMJ3J97hS()) ? 4 : 0);
		goto IL_005e;
		IL_005e:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
			case 4:
				C2eUtEMKTIAKFeFabxU(uZUMcKI5Uu);
				goto default;
			default:
				uZUMcKI5Uu.AddRange(points);
				num = 1;
				continue;
			case 1:
				kCMPbgM5htujM37Lsyi(this, null);
				num = 7;
				if (rZO1JLM7ViWpk3Xos7D())
				{
					continue;
				}
				goto case 6;
			case 6:
				CheckLock();
				num = 5;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicPolyline(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00ac;
		IL_0052:
		int num2 = default;
		double[] array = default;
		if (num2 >= gKsmwoMox6ogYq7W8r4(uZUMcKI5Uu))
		{
			num = 3;
		}
		else
		{
			array[num2 * 2] = uZUMcKI5Uu[num2].X;
			num = 9;
		}
		goto IL_00ac;
		IL_00ac:
		CvsCogPolyline cvsCogPolyline = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 8:
				goto IL_003c;
			case 0:
			case 4:
			case 6:
				goto IL_0052;
			case 3:
				cvsCogPolyline.Points = array;
				num = 10;
				continue;
			case 9:
				array[num2 * 2 + 1] = uZUMcKI5Uu[num2].Y;
				goto IL_003c;
			default:
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				num2 = 0;
				num = 4;
				continue;
			case 1:
			case 7:
				array = new double[gKsmwoMox6ogYq7W8r4(uZUMcKI5Uu) * 2];
				num = 5;
				continue;
			case 10:
				return cvsCogPolyline;
			}
			break;
		}
		goto IL_001a;
		IL_003c:
		num2++;
		goto IL_0052;
		IL_001a:
		cvsCogPolyline = new CvsCogPolyline();
		_ = 0;
		if (rZO1JLM7ViWpk3Xos7D())
		{
			num = 7;
			if (hewCdOMtDAZMJ3J97hS())
			{
				goto IL_003c;
			}
		}
		else
		{
			num = 0;
			if (1 == 0)
			{
				goto IL_0052;
			}
		}
		goto IL_00ac;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogPolyline poly)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				num2 = 0;
				rZO1JLM7ViWpk3Xos7D();
				if (!hewCdOMtDAZMJ3J97hS())
				{
					num = 6;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 0;
				break;
			case 1:
				base.FromSerializableGraphic(poly);
				num = 5;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
			case 6:
				if (num2 >= ((Array)wmwlIWMYIrwUL7Dde7i(poly)).Length)
				{
					num = 7;
					break;
				}
				uZUMcKI5Uu.Insert(num2 / 2, new PointF((float)((double[])wmwlIWMYIrwUL7Dde7i(poly))[num2], (float)poly.Points[num2 + 1]));
				goto default;
			default:
				num2 += 2;
				num = 4;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void leAwOYMCPuaNee6tr2d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rZO1JLM7ViWpk3Xos7D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hewCdOMtDAZMJ3J97hS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C2eUtEMKTIAKFeFabxU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<PointF>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kCMPbgM5htujM37Lsyi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gKsmwoMox6ogYq7W8r4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<PointF>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LosQ81MPyy6wEM9oFF3(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wmwlIWMYIrwUL7Dde7i(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPointList)P_0).Points;
	}
}
