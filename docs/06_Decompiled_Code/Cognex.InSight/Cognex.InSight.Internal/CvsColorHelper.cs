using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public abstract class CvsColorHelper
{
	private static readonly uint[] KkeAoEyGfY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color InSightToARGB(InSightColors color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!TbNx5Pu3FacMLHNM9fP()) ? 2 : 3);
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (num2 >= KkeAoEyGfY.Length)
				{
					num = 5;
					break;
				}
				return CSjl7cul0NFRtfUPm5S((int)KkeAoEyGfY[num2]);
			case 0:
			case 3:
				if (color < (InSightColors)0)
				{
					goto case 1;
				}
				num2 = (int)(color - 2) / 4;
				goto case 4;
			case 1:
			case 2:
			{
				int num3 = (((int)color >> 10) & 0x1F) << 3;
				int num4 = (((int)color >> 5) & 0x1F) << 3;
				int num5 = (int)(color & (InSightColors)0x1F) << 3;
				return VwKDWJuM8PhmLrNdnLC(num3, num4, num5);
			}
			default:
				num = 4;
				break;
			case 5:
				return rpnkgEuQ6oL4PBtoEb7();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color InSightToARGB(int color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return T33eXvueACfFOBmitFu((InSightColors)color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color GetHighlightColor(short index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (!TbNx5Pu3FacMLHNM9fP())
		{
			goto IL_001e;
		}
		goto IL_013b;
		IL_01f1:
		return qc7R68uIP0pbegTGkKv(index);
		IL_00ec:
		short num2 = default;
		switch (num2)
		{
		case 29:
			return qc7R68uIP0pbegTGkKv(126);
		case 30:
			return InSightToARGB(130);
		case 33:
			return qc7R68uIP0pbegTGkKv(138);
		case 35:
			return qc7R68uIP0pbegTGkKv(146);
		case 31:
		case 32:
		case 34:
			goto IL_01f1;
		}
		num = 10;
		goto IL_013b;
		IL_013b:
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 0:
			{
				int num3 = ((index >> 10) & 0x1F) << 3;
				int num4 = ((index >> 5) & 0x1F) << 3;
				int num5 = (index & 0x1F) << 3;
				int num6 = sOePlkuuu2UY5nIO4IC(num3 * 3 / 2, 255);
				num4 = sOePlkuuu2UY5nIO4IC(num4 * 3 / 2, 255);
				num5 = sOePlkuuu2UY5nIO4IC(num5 * 3 / 2, 255);
				return VwKDWJuM8PhmLrNdnLC(num6, num4, num5);
			}
			case 3:
			case 9:
				goto IL_0095;
			case 5:
				goto IL_00b4;
			case 4:
				goto IL_00c7;
			case 1:
			case 7:
				goto IL_00ec;
			case 2:
				return qc7R68uIP0pbegTGkKv(index);
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				return qc7R68uIP0pbegTGkKv((short)((num2 + 6) * 4 + 2));
			case 10:
				goto IL_01f1;
			}
			break;
		}
		goto IL_001e;
		IL_001e:
		if (index < 0)
		{
			num = 0;
		}
		else if (index > 255)
		{
			num = 4;
			if (false)
			{
				goto IL_0095;
			}
		}
		else
		{
			num2 = (short)((index - 2) / 4);
			_ = 0;
			num = ((!TbNx5Pu3FacMLHNM9fP()) ? 1 : 9);
		}
		goto IL_013b;
		IL_0186:
		switch (num2)
		{
		case 12:
			return qc7R68uIP0pbegTGkKv(54);
		case 13:
			return qc7R68uIP0pbegTGkKv(62);
		case 14:
			return qc7R68uIP0pbegTGkKv(50);
		}
		goto IL_00ec;
		IL_0095:
		if ((double)num2 != (double)(index - 2) / 4.0)
		{
			num = 2;
			goto IL_013b;
		}
		if (num2 >= 0)
		{
			goto IL_00b4;
		}
		goto IL_0186;
		IL_00b4:
		if (num2 < 6)
		{
			num = 6;
			if (false)
			{
				goto IL_00c7;
			}
			goto IL_013b;
		}
		goto IL_0186;
		IL_00c7:
		return T33eXvueACfFOBmitFu(InSightColors.MAGENTA);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CvsColorHelper()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m1YRtRuRr5IEcBAYWdT();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsColorHelper()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m1YRtRuRr5IEcBAYWdT();
		uint[] array = new uint[48];
		NhdFs9uahAHHjiEev2D(array, __ldtoken(_003CPrivateImplementationDetails_003E.EB3518916FBFF107317D063A4DB26A069BB5ACE7B952B8259605C303BA4CEBB5));
		KkeAoEyGfY = array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color VwKDWJuM8PhmLrNdnLC(int P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color rpnkgEuQ6oL4PBtoEb7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.White;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color CSjl7cul0NFRtfUPm5S(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TbNx5Pu3FacMLHNM9fP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bSq0o8uONRxLTDLtWlo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color T33eXvueACfFOBmitFu(InSightColors color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return InSightToARGB(color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sOePlkuuu2UY5nIO4IC(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color qc7R68uIP0pbegTGkKv(int color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return InSightToARGB(color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m1YRtRuRr5IEcBAYWdT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NhdFs9uahAHHjiEev2D(object P_0, RuntimeFieldHandle P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}
}
