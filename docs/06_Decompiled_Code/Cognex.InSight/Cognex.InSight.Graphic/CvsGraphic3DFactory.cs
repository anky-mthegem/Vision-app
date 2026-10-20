using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.Graphic;

public static class CvsGraphic3DFactory
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsGraphic3D CreateFromCogSocket(CvsCogShape cogGraphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 27;
		CvsCogRegion3D cvsCogRegion3D = default;
		CvsCogCircle3D cvsCogCircle3D = default;
		CvsGraphic3D result = default;
		CvsCogPlane3D cvsCogPlane3D = default;
		CvsCogRect3D cvsCogRect3D = default;
		CvsCogArc3D cvsCogArc3D = default;
		CvsCogPoint3D cvsCogPoint3D = default;
		CvsCogCylinder3D cvsCogCylinder3D = default;
		CvsCogPolygon3D cvsCogPolygon3D = default;
		CvsCogLine3D cvsCogLine3D = default;
		CvsCogText3D cvsCogText3D = default;
		CvsCogBox3D cvsCogBox3D = default;
		CvsCogLineArray3D cvsCogLineArray3D = default;
		while (true)
		{
			switch (num)
			{
			case 28:
			{
				if (cvsCogRegion3D != null)
				{
					num = 0;
					continue;
				}
				if (!(cogGraphic is CvsCogSphere cvsCogSphere))
				{
					cvsCogCircle3D = cogGraphic as CvsCogCircle3D;
					num = 6;
					continue;
				}
				CvsGraphicSphere cvsGraphicSphere = new CvsGraphicSphere();
				Oe8scjPkgSXfj5OO4Y0(cvsGraphicSphere, cvsCogSphere);
				result = cvsGraphicSphere;
				num = 22;
				continue;
			}
			case 16:
			{
				CvsGraphicPlane3D cvsGraphicPlane3D = new CvsGraphicPlane3D();
				IpSpT7P6CRCLq6Lg8Ey(cvsGraphicPlane3D, cvsCogPlane3D);
				result = cvsGraphicPlane3D;
				num = 5;
				continue;
			}
			case 11:
				if (cvsCogRect3D != null)
				{
					num = 31;
					continue;
				}
				cvsCogArc3D = cogGraphic as CvsCogArc3D;
				num = 23;
				continue;
			case 30:
				if (cvsCogPlane3D != null)
				{
					num = 16;
					continue;
				}
				cvsCogPoint3D = cogGraphic as CvsCogPoint3D;
				num = 4;
				continue;
			case 10:
				if (cvsCogCylinder3D != null)
				{
					num = 25;
					continue;
				}
				cvsCogRegion3D = cogGraphic as CvsCogRegion3D;
				goto case 28;
			case 14:
			{
				CvsGraphicPolygon3D cvsGraphicPolygon3D = new CvsGraphicPolygon3D();
				tvVHXyPgVIyglUjN7Xd(cvsGraphicPolygon3D, cvsCogPolygon3D);
				result = cvsGraphicPolygon3D;
				num = 32;
				continue;
			}
			case 15:
			{
				CvsGraphicArc3D cvsGraphicArc3D = new CvsGraphicArc3D();
				WNdoNrPmTCjPiPf3oqp(cvsGraphicArc3D, cvsCogArc3D);
				result = cvsGraphicArc3D;
				break;
			}
			case 25:
			{
				CvsGraphicCylinder3D cvsGraphicCylinder3D = new CvsGraphicCylinder3D();
				aY5rSOP0tvyUWiKTCk4(cvsGraphicCylinder3D, cvsCogCylinder3D);
				result = cvsGraphicCylinder3D;
				break;
			}
			default:
				num = 28;
				continue;
			case 7:
			{
				CvsGraphicCircle3D cvsGraphicCircle3D = new CvsGraphicCircle3D();
				jJJBWYPffY2oFod94fL(cvsGraphicCircle3D, cvsCogCircle3D);
				result = cvsGraphicCircle3D;
				num = 17;
				continue;
			}
			case 27:
				if (cogGraphic == null)
				{
					JmkVMUPnZ61GamOZnEu();
					num = ((!xc9DHoPaUBKMRyosT2g()) ? 26 : 9);
				}
				else
				{
					result = null;
					num = 19;
				}
				continue;
			case 1:
			case 9:
				return null;
			case 13:
			case 26:
			{
				CvsGraphicPoint3D cvsGraphicPoint3D = new CvsGraphicPoint3D();
				bS0OHNPp6eOYtfGsmJ4(cvsGraphicPoint3D, cvsCogPoint3D);
				result = cvsGraphicPoint3D;
				break;
			}
			case 2:
			{
				if (cvsCogLine3D == null)
				{
					cvsCogText3D = cogGraphic as CvsCogText3D;
					num = 8;
					continue;
				}
				CvsGraphicLine3D cvsGraphicLine3D = new CvsGraphicLine3D();
				ynMhsSPXQReI6De9f6A(cvsGraphicLine3D, cvsCogLine3D);
				result = cvsGraphicLine3D;
				num = 21;
				continue;
			}
			case 20:
			{
				CvsGraphicBox3D cvsGraphicBox3D = new CvsGraphicBox3D();
				WtPef2PGUyW41G1VTWw(cvsGraphicBox3D, cvsCogBox3D);
				result = cvsGraphicBox3D;
				num = 24;
				continue;
			}
			case 31:
			{
				CvsGraphicRect3D cvsGraphicRect3D = new CvsGraphicRect3D();
				hkZ6ddPF6KQH93cgVQu(cvsGraphicRect3D, cvsCogRect3D);
				result = cvsGraphicRect3D;
				break;
			}
			case 6:
				if (cvsCogCircle3D != null)
				{
					num = 7;
					if (!JmkVMUPnZ61GamOZnEu())
					{
						continue;
					}
					goto case 8;
				}
				cvsCogRect3D = cogGraphic as CvsCogRect3D;
				num = 11;
				continue;
			case 8:
				if (cvsCogText3D != null)
				{
					CvsGraphicText3D cvsGraphicText3D = new CvsGraphicText3D();
					IArQ9ZPbv26NRQltYyQ(cvsGraphicText3D, cvsCogText3D);
					result = cvsGraphicText3D;
					num = 18;
				}
				else
				{
					cvsCogPlane3D = cogGraphic as CvsCogPlane3D;
					num = 30;
				}
				continue;
			case 0:
			{
				CvsGraphicRegion3D cvsGraphicRegion3D = new CvsGraphicRegion3D();
				nPNC2QP47Bv68BF3VfS(cvsGraphicRegion3D, cvsCogRegion3D);
				result = cvsGraphicRegion3D;
				break;
			}
			case 3:
				if (cvsCogLineArray3D != null)
				{
					num = 12;
					if (!JmkVMUPnZ61GamOZnEu())
					{
						continue;
					}
					break;
				}
				cvsCogPolygon3D = cogGraphic as CvsCogPolygon3D;
				num = 29;
				if (xc9DHoPaUBKMRyosT2g())
				{
					continue;
				}
				goto case 19;
			case 29:
				if (cvsCogPolygon3D == null)
				{
					break;
				}
				num = 14;
				if (true)
				{
					continue;
				}
				goto case 23;
			case 23:
				if (cvsCogArc3D == null)
				{
					cvsCogLineArray3D = cogGraphic as CvsCogLineArray3D;
					num = 3;
				}
				else
				{
					num = 15;
				}
				continue;
			case 4:
				if (cvsCogPoint3D == null)
				{
					cvsCogCylinder3D = cogGraphic as CvsCogCylinder3D;
					num = 10;
					if (xc9DHoPaUBKMRyosT2g())
					{
						continue;
					}
					goto case 2;
				}
				goto case 13;
			case 12:
			{
				CvsGraphicLineArray3D cvsGraphicLineArray3D = new CvsGraphicLineArray3D();
				P3YgOZPyU7oemTYRXq7(cvsGraphicLineArray3D, cvsCogLineArray3D);
				result = cvsGraphicLineArray3D;
				break;
			}
			case 19:
				cvsCogBox3D = cogGraphic as CvsCogBox3D;
				if (cvsCogBox3D == null)
				{
					cvsCogLine3D = cogGraphic as CvsCogLine3D;
					num = 2;
					if (JmkVMUPnZ61GamOZnEu())
					{
					}
				}
				else
				{
					num = 20;
				}
				continue;
			case 5:
			case 17:
			case 18:
			case 21:
			case 22:
			case 24:
			case 32:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WtPef2PGUyW41G1VTWw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicBox3D)P_0).FromSerializableGraphic((CvsCogBox3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ynMhsSPXQReI6De9f6A(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicLine3D)P_0).FromSerializableGraphic((CvsCogLine3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IArQ9ZPbv26NRQltYyQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicText3D)P_0).FromSerializableGraphic((CvsCogText3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IpSpT7P6CRCLq6Lg8Ey(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPlane3D)P_0).FromSerializableGraphic((CvsCogPlane3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bS0OHNPp6eOYtfGsmJ4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPoint3D)P_0).FromSerializableGraphic((CvsCogPoint3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aY5rSOP0tvyUWiKTCk4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCylinder3D)P_0).FromSerializableGraphic((CvsCogCylinder3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nPNC2QP47Bv68BF3VfS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicRegion3D)P_0).FromSerializableGraphic((CvsCogRegion3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Oe8scjPkgSXfj5OO4Y0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicSphere)P_0).FromSerializableGraphic((CvsCogSphere)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jJJBWYPffY2oFod94fL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCircle3D)P_0).FromSerializableGraphic((CvsCogCircle3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hkZ6ddPF6KQH93cgVQu(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicRect3D)P_0).FromSerializableGraphic((CvsCogRect3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WNdoNrPmTCjPiPf3oqp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicArc3D)P_0).FromSerializableGraphic((CvsCogArc3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P3YgOZPyU7oemTYRXq7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicLineArray3D)P_0).FromSerializableGraphic((CvsCogLineArray3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tvVHXyPgVIyglUjN7Xd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPolygon3D)P_0).FromSerializableGraphic((CvsCogPolygon3D)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xc9DHoPaUBKMRyosT2g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JmkVMUPnZ61GamOZnEu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
