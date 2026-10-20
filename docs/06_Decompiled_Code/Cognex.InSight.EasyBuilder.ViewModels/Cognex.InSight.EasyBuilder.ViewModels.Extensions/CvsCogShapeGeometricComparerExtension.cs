using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.EasyBuilder.ViewModels.Extensions;

public static class CvsCogShapeGeometricComparerExtension
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeometricallyEqual(this CvsCogPoint p1, CvsCogPoint p2, float epsilon = 0.001f)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (dyxqSOK5FV0xhNVnuL83())
		{
			goto IL_001e;
		}
		goto IL_0036;
		IL_0065:
		if (CvsMath.AreEpsilonEqual(Oj6FcyK5MxTAUCSwkc4G(p1), Oj6FcyK5MxTAUCSwkc4G(p2), epsilon))
		{
			num = 5;
			goto IL_0036;
		}
		goto IL_00b7;
		IL_00b7:
		return false;
		IL_0036:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			default:
				goto IL_0065;
			case 3:
				goto IL_0087;
			case 5:
				return Dgpfv3K5UNIna08LJx5N(p1.Y, Tq70CXK5YUQ612auv8gd(p2), epsilon);
			}
			break;
			IL_0087:
			if (p1 != null)
			{
				_ = 0;
				if (!DPOSAMK50JCZG3M3stHB())
				{
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0065;
				}
				num = 0;
				continue;
			}
			goto IL_00b7;
		}
		goto IL_001e;
		IL_001e:
		if (p2 != null)
		{
			goto IL_0065;
		}
		goto IL_00b7;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeometricallyEqual(this CvsCogRegion r1, CvsCogRegion r2, float epsilon = 0.001f)
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
			case 3:
				if (!Dgpfv3K5UNIna08LJx5N(HPrVUoK5xvupQyJnFaoU(r1), r2.Curve, epsilon))
				{
					break;
				}
				goto case 4;
			default:
				num = 4;
				continue;
			case 1:
			case 5:
				if (!Dgpfv3K5UNIna08LJx5N(vpF6NkK5QDv9aEJBKwpF(r1), vpF6NkK5QDv9aEJBKwpF(r2), epsilon))
				{
					break;
				}
				goto case 2;
			case 7:
				if (r2 != null)
				{
					num = 8;
					continue;
				}
				break;
			case 2:
			case 6:
				if (!Dgpfv3K5UNIna08LJx5N(EY0HTlK5NbjV8BtDIgxJ(r1), EY0HTlK5NbjV8BtDIgxJ(r2), epsilon))
				{
					break;
				}
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				if (Dgpfv3K5UNIna08LJx5N(t0IKuZK5H1WuHbGkoEIY(r1), t0IKuZK5H1WuHbGkoEIY(r2), epsilon))
				{
					num = 3;
					continue;
				}
				break;
			case 0:
				if (r1 != null)
				{
					num = 7;
					continue;
				}
				break;
			case 4:
				if (Dgpfv3K5UNIna08LJx5N(rY57iIK5mSSxyDuHVfwo(r1), r2.Height, epsilon))
				{
					_ = 0;
					num = (DPOSAMK50JCZG3M3stHB() ? 1 : 2);
					continue;
				}
				break;
			case 9:
				return Dgpfv3K5UNIna08LJx5N(r1.Y, Im3AiYK52GCDbdNk0MyG(r2), epsilon);
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsGeometricallyEqual(this CvsCogAnnulus a1, CvsCogAnnulus a2, float epsilon = 0.001f)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dyxqSOK5FV0xhNVnuL83();
		int num;
		if (DPOSAMK50JCZG3M3stHB())
		{
			num = 6;
		}
		else
		{
			num = 5;
			if (!DPOSAMK50JCZG3M3stHB())
			{
				goto IL_00a0;
			}
		}
		goto IL_00ca;
		IL_00ca:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (Dgpfv3K5UNIna08LJx5N(TqeS7qK5uMy884m2PXyQ(a1), TqeS7qK5uMy884m2PXyQ(a2), epsilon))
				{
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				goto IL_010d;
			case 0:
			case 6:
				if (a1 != null)
				{
					num = 3;
					continue;
				}
				goto IL_010d;
			case 4:
				break;
			case 3:
				goto IL_0084;
			case 2:
			case 5:
				goto IL_00a0;
			default:
				num = 4;
				continue;
			case 7:
				return CvsMath.AreEpsilonEqual(iELew9K5huXG76hXU9Ji(a1), iELew9K5huXG76hXU9Ji(a2), epsilon);
			}
			break;
		}
		goto IL_005c;
		IL_005c:
		if (Dgpfv3K5UNIna08LJx5N(JsawesK51RW0uvgDjiY6(a1), a2.Y, epsilon))
		{
			num = 1;
			if (!DPOSAMK50JCZG3M3stHB())
			{
				goto IL_0084;
			}
			goto IL_00ca;
		}
		goto IL_010d;
		IL_0084:
		if (a2 != null)
		{
			goto IL_00a0;
		}
		goto IL_010d;
		IL_00a0:
		if (CvsMath.AreEpsilonEqual(ObjrTgK5cpuvUcyLjKC1(a1), ObjrTgK5cpuvUcyLjKC1(a2), epsilon))
		{
			goto IL_005c;
		}
		goto IL_010d;
		IL_010d:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Oj6FcyK5MxTAUCSwkc4G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPoint)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Tq70CXK5YUQ612auv8gd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPoint)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Dgpfv3K5UNIna08LJx5N(double P_0, double P_1, double P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsMath.AreEpsilonEqual(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DPOSAMK50JCZG3M3stHB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dyxqSOK5FV0xhNVnuL83()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double t0IKuZK5H1WuHbGkoEIY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double HPrVUoK5xvupQyJnFaoU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Curve;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double rY57iIK5mSSxyDuHVfwo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double vpF6NkK5QDv9aEJBKwpF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double EY0HTlK5NbjV8BtDIgxJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Im3AiYK52GCDbdNk0MyG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ObjrTgK5cpuvUcyLjKC1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double JsawesK51RW0uvgDjiY6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double TqeS7qK5uMy884m2PXyQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).InnerRadius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double iELew9K5huXG76hXU9Ji(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).OuterRadius;
	}
}
