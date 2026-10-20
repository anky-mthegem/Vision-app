using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Geometry;
using Cognex.Cnx.Implementation;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public class CvsClippingRegion : IDisposable
{
	private readonly bool UJ4tVoGqiX;

	private Rectangle l6utv1jkcU;

	private readonly Point[] IDttZ9e8B6;

	private IntPtr wf0t8QCHeT;

	private Region RkktzmNe9F;

	public bool IsRectangular
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UJ4tVoGqiX;
		}
	}

	internal IntPtr HRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 8;
			int num2 = default;
			CnxVector2[] array = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 6:
					num2++;
					num = 3;
					continue;
				case 7:
					wf0t8QCHeT = wk7qP8RnhHrp2idn9PP(array, array.Length, 1);
					num = 11;
					continue;
				case 3:
				case 4:
				case 5:
					if (num2 < IDttZ9e8B6.Length)
					{
						array[num2] = xqUI7NRafeTbCnAtO1e(IDttZ9e8B6[num2]);
						goto case 0;
					}
					num = 7;
					continue;
				case 2:
					num2 = 0;
					goto default;
				default:
					Qiqu5TRPBkqGe8xehe8();
					num = (h33U4fRoaK3eQoGVkBK() ? 4 : 0);
					continue;
				case 8:
					if (c0tsDBRRDMQRqT71VV3(wf0t8QCHeT, IntPtr.Zero))
					{
						num = 1;
						continue;
					}
					break;
				case 1:
					if (!IsRectangular)
					{
						array = new CnxVector2[IDttZ9e8B6.Length];
						num = 2;
						if (h33U4fRoaK3eQoGVkBK())
						{
							continue;
						}
						goto case 3;
					}
					num = 9;
					continue;
				case 9:
					wf0t8QCHeT = CnxNativeMethods.CreateRectRgn(l6utv1jkcU.X, l6utv1jkcU.Y, l6utv1jkcU.Right, l6utv1jkcU.Bottom);
					num = 10;
					continue;
				case 10:
				case 11:
					break;
				}
				break;
			}
			return wf0t8QCHeT;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsClippingRegion(Point[] polygonPoints)
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
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 1;
				break;
			case 3:
				throw new ArgumentNullException((string)TvsKUeRNHZ2laMCcXBc(40690));
			case 2:
			case 6:
				if (polygonPoints != null)
				{
					if (polygonPoints.Length < 3)
					{
						goto case 4;
					}
					IDttZ9e8B6 = polygonPoints;
					num = 7;
					break;
				}
				goto case 3;
			default:
				num = 3;
				break;
			case 4:
			case 5:
				throw new ArgumentException((string)TvsKUeRNHZ2laMCcXBc(40720), (string)TvsKUeRNHZ2laMCcXBc(40690));
			case 1:
				pLW6WvRYy2p92bkUksl(this);
				Qiqu5TRPBkqGe8xehe8();
				if (!h33U4fRoaK3eQoGVkBK())
				{
					num = 5;
					break;
				}
				num = 6;
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
	public CvsClippingRegion(Rectangle rectangle)
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
				gp6nh1RxljMB7GSj3sT();
				_ = 1;
				num = (Qiqu5TRPBkqGe8xehe8() ? 4 : 3);
				break;
			case 0:
				UJ4tVoGqiX = true;
				num = 6;
				break;
			case 2:
			case 4:
				l6utv1jkcU = rectangle;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 3:
				pLW6WvRYy2p92bkUksl(this);
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsClippingRegion(IntPtr hRegion)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (h33U4fRoaK3eQoGVkBK())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_003e;
		IL_006b:
		wf0t8QCHeT = hRegion;
		num = 5;
		goto IL_003e;
		IL_003e:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_006b;
			case 0:
			case 3:
				gp6nh1RxljMB7GSj3sT();
				num = 1;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		pLW6WvRYy2p92bkUksl(this);
		goto IL_006b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~CvsClippingRegion()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			iYityIKiVF(_0020: false);
		}
		finally
		{
			wkxC9wR15Ro1MU1Xe4G(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iYityIKiVF(_0020: true);
		GC.SuppressFinalize(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iYityIKiVF(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0082;
		IL_0082:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				break;
			case 7:
				goto IL_0035;
			case 2:
				goto IL_006a;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_00b5;
			case 6:
				wf0t8QCHeT = IntPtr.Zero;
				num = 2;
				continue;
			case 1:
			case 4:
				JDEfULRr4hkcJg11huR(wf0t8QCHeT);
				num = 6;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_006a:
		if (P_0)
		{
			goto IL_00b5;
		}
		return;
		IL_00b5:
		if (RkktzmNe9F != null)
		{
			goto IL_001a;
		}
		return;
		IL_001a:
		w7yUIyR3Qyh5kNvD9dQ(RkktzmNe9F);
		num = 8;
		if (Qiqu5TRPBkqGe8xehe8())
		{
			goto IL_0035;
		}
		goto IL_0082;
		IL_0035:
		if (!(wf0t8QCHeT != IntPtr.Zero))
		{
			goto IL_006a;
		}
		Qiqu5TRPBkqGe8xehe8();
		if (h33U4fRoaK3eQoGVkBK())
		{
			num = 4;
			if (!h33U4fRoaK3eQoGVkBK())
			{
				goto IL_006a;
			}
		}
		else
		{
			num = 0;
		}
		goto IL_0082;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle GetBounds()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		Rectangle rectangle = default;
		Rectangle rectangle2 = default;
		int num2 = default;
		CnxNativeMethods.RECT lprc = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				rectangle = rectangle2;
				num = 1;
				continue;
			case 3:
				return rectangle;
			case 0:
				return l6utv1jkcU;
			case 4:
			case 7:
			case 10:
				if (num2 >= IDttZ9e8B6.Length)
				{
					num = 3;
					continue;
				}
				rectangle2.Location = IDttZ9e8B6[num2];
				goto default;
			case 2:
				if (!IsRectangular)
				{
					if (IDttZ9e8B6 == null)
					{
						CnxNativeMethods.GetRgnBox(HRegion, out lprc);
						num = 11;
						continue;
					}
					rectangle2 = new Rectangle(IDttZ9e8B6[0].X, IDttZ9e8B6[0].Y, 0, 0);
					num = 6;
					if (h33U4fRoaK3eQoGVkBK())
					{
						continue;
					}
					goto case 4;
				}
				num = 0;
				continue;
			case 9:
				num2++;
				goto case 4;
			case 5:
			case 8:
				rectangle = oyuhxMROP6K1bbNcetB(rectangle, rectangle2);
				num = 9;
				if (Qiqu5TRPBkqGe8xehe8())
				{
				}
				continue;
			default:
				Qiqu5TRPBkqGe8xehe8();
				num = (h33U4fRoaK3eQoGVkBK() ? 8 : 10);
				continue;
			case 1:
				num2 = 1;
				num = 4;
				if (!Qiqu5TRPBkqGe8xehe8())
				{
					continue;
				}
				break;
			case 11:
				break;
			}
			break;
		}
		return EUue9MRMln47aCMvhi7(lprc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsClippingRegion Intersect(CvsClippingRegion a, CvsClippingRegion b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Qiqu5TRPBkqGe8xehe8();
		int num;
		if (h33U4fRoaK3eQoGVkBK())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (Qiqu5TRPBkqGe8xehe8())
			{
			}
		}
		goto IL_006e;
		IL_00d2:
		IntPtr intPtr = jPG9ivReXbxEL4de6HK(0, 0, 0, 0);
		nCnAEYRI6XcrosPdOrx(intPtr, iv8uMIRuTCKAFR45fa7(a), b.HRegion, CnxNativeMethods.RGN.RGN_AND);
		return new CvsClippingRegion(intPtr);
		IL_0051:
		if (Sg0bmiRQoEgeyShrpHN(a))
		{
			goto IL_002a;
		}
		goto IL_00d2;
		IL_002a:
		if (b.IsRectangular)
		{
			num = 6;
			goto IL_006e;
		}
		goto IL_00d2;
		IL_006e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				goto IL_003f;
			case 1:
				return a;
			case 4:
				return b;
			case 6:
				return new CvsClippingRegion(lnSD8QRl9U7ThdqbIKV(a.l6utv1jkcU, b.l6utv1jkcU));
			}
			break;
			IL_003f:
			if (a == null)
			{
				num = 4;
				continue;
			}
			if (b == null)
			{
				num = 1;
				continue;
			}
			goto IL_0051;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Region GetRegion()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		h33U4fRoaK3eQoGVkBK();
		int num;
		if (!Qiqu5TRPBkqGe8xehe8())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_00ce;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				if (RkktzmNe9F != null)
				{
					break;
				}
				num = 2;
				if (!Qiqu5TRPBkqGe8xehe8())
				{
					continue;
				}
				goto case 5;
			case 5:
				RkktzmNe9F = new Region(l6utv1jkcU);
				break;
			case 2:
				if (!IsRectangular)
				{
					RkktzmNe9F = (Region)V4L5JvRGyhea3V3cWBp(HRegion);
					num = 6;
				}
				else
				{
					num = 5;
				}
				continue;
			}
			break;
		}
		goto IL_00ce;
		IL_00ce:
		return RkktzmNe9F;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CvsClippingRegion(Rectangle r)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsClippingRegion(r);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator Region(CvsClippingRegion r)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return r?.GetRegion();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pLW6WvRYy2p92bkUksl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TvsKUeRNHZ2laMCcXBc(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool h33U4fRoaK3eQoGVkBK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Qiqu5TRPBkqGe8xehe8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gp6nh1RxljMB7GSj3sT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wkxC9wR15Ro1MU1Xe4G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0.Finalize();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JDEfULRr4hkcJg11huR(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.DeleteRegion(hObject);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w7yUIyR3Qyh5kNvD9dQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Region)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle oyuhxMROP6K1bbNcetB(Rectangle P_0, Rectangle P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Rectangle.Union(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle EUue9MRMln47aCMvhi7(CnxRectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return rect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Sg0bmiRQoEgeyShrpHN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsClippingRegion)P_0).IsRectangular;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle lnSD8QRl9U7ThdqbIKV(Rectangle P_0, Rectangle P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Rectangle.Intersect(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr jPG9ivReXbxEL4de6HK(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.CreateRectRgn(nLeftRect, nTopRect, nRightRect, nBottomRect);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr iv8uMIRuTCKAFR45fa7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsClippingRegion)P_0).HRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nCnAEYRI6XcrosPdOrx(IntPtr hrgnDest, IntPtr hrgnSrc1, IntPtr hrgnSrc2, CnxNativeMethods.RGN fnCombineMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.CombineRgn(hrgnDest, hrgnSrc1, hrgnSrc2, fnCombineMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c0tsDBRRDMQRqT71VV3(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxVector2 xqUI7NRafeTbCnAtO1e(Point vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr wk7qP8RnhHrp2idn9PP(object P_0, int cPoints, int fnPolyFillMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.CreatePolygonRgn((CnxVector2[])P_0, cPoints, fnPolyFillMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V4L5JvRGyhea3V3cWBp(IntPtr P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Region.FromHrgn(P_0);
	}
}
