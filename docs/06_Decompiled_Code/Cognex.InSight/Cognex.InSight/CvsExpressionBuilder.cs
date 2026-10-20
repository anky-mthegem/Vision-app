using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cognex.InSight.Internal;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsExpressionBuilder
{
	public const double MinRepresentableFloatInStandardNotation = 1E-05;

	public const double MaxRepresentableFloatInStandardNotation = 9999999999.0;

	private readonly CvsFunctionTable U9BbngYetV;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsExpressionBuilder(CvsFunctionTable functionTable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		do
		{
			IL_0030:
			switch (num)
			{
			case 1:
			case 4:
				base._002Ector();
				break;
			case 0:
				sMdfuTA8SHEXjhZOhTH();
				_ = 0;
				num = (kgrXANAZwPDI8g53fMI() ? 4 : 3);
				goto IL_0030;
			case 5:
				return;
			}
			U9BbngYetV = functionTable;
			num = 5;
		}
		while (!INhu3JAJ4iXpmXMKYuj());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string BuildExpression(string funcName, Dictionary<string, string> argValues = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BuildExpression(U9BbngYetV.FindFunction(funcName), argValues);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string BuildExpression(CvsFunction func, Dictionary<string, string> argValues = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (func == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(func.Name + kgbOBx7BanbFa22Hp9.ol99ukmDA(7598));
		for (int i = 0; i < func.MinNumberOfArgs; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(kgbOBx7BanbFa22Hp9.ol99ukmDA(7604));
			}
			CvsFunctionArg arg = func.GetArg(i);
			string fullName = arg.FullName;
			if (argValues != null && argValues.ContainsKey(fullName))
			{
				stringBuilder.Append(argValues[fullName]);
			}
			else
			{
				stringBuilder.Append(arg.GetDefaultValue());
			}
		}
		stringBuilder.Append(')');
		return stringBuilder.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string BuildExpression(string funcName, string[] argValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)uyhoShDw1SaElypJu3s(WLsjOwAzXKIFOFkwMn4(U9BbngYetV, funcName), argValues);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string BuildExpression(CvsFunction func, string[] argValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!kgrXANAZwPDI8g53fMI())
		{
			goto IL_001e;
		}
		goto IL_005f;
		IL_0103:
		if (argValues.Length > WQJJmPDhkO7OqFdgdR4(func))
		{
			goto IL_016f;
		}
		goto IL_017f;
		IL_016f:
		throw new ArgumentException((string)j0bLyvDL2oZnvDsdAH6(7610));
		IL_017f:
		StringBuilder stringBuilder = new StringBuilder((string)eli6I0D9kRJ3vAZQXmB(func.Name, kgbOBx7BanbFa22Hp9.ol99ukmDA(7598)));
		num = 11;
		if (kgrXANAZwPDI8g53fMI())
		{
			goto IL_005f;
		}
		goto IL_01aa;
		IL_001e:
		if (MotxGtDsaGi5kW9MZLI(func) == WQJJmPDhkO7OqFdgdR4(func))
		{
			num = 5;
			if (!kgrXANAZwPDI8g53fMI())
			{
				goto IL_003f;
			}
			goto IL_005f;
		}
		goto IL_017f;
		IL_0155:
		int num2 = default;
		stringBuilder.Append(argValues[num2]);
		num = 8;
		if (kgrXANAZwPDI8g53fMI())
		{
			goto IL_005f;
		}
		goto IL_016f;
		IL_003f:
		num2 = 0;
		goto IL_0121;
		IL_0121:
		if (num2 < argValues.Length)
		{
			if (num2 > 0)
			{
				goto IL_0134;
			}
			goto IL_0155;
		}
		num = 2;
		goto IL_005f;
		IL_0134:
		iij5SNDSC2YInpTfHK2(stringBuilder, kgbOBx7BanbFa22Hp9.ol99ukmDA(7604));
		num = 10;
		if (kgrXANAZwPDI8g53fMI())
		{
			goto IL_005f;
		}
		goto IL_0155;
		IL_01aa:
		return stringBuilder.ToString();
		IL_005f:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 11:
				goto IL_003f;
			default:
				num = 9;
				continue;
			case 8:
				num2++;
				num = 12;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				htTdJ3DEhVh658nkb9N(stringBuilder, ')');
				num = 13;
				continue;
			case 6:
				if (argValues != null)
				{
					INhu3JAJ4iXpmXMKYuj();
					if (kgrXANAZwPDI8g53fMI())
					{
						num = 7;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					}
					num = 0;
					continue;
				}
				goto IL_016f;
			case 1:
			case 7:
				if (argValues.Length >= MotxGtDsaGi5kW9MZLI(func))
				{
					num = 3;
					continue;
				}
				goto IL_016f;
			case 5:
				goto IL_0103;
			case 12:
				goto IL_0121;
			case 9:
				goto IL_0134;
			case 10:
				goto IL_0155;
			case 0:
			case 4:
				goto IL_016f;
			case 13:
				goto IL_01aa;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetArgFullName(string summaryName, string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!GaVXmADvhF5JXMITXrJ(summaryName))
		{
			return (string)sRW9nIDHlc3NC1O6e5p(j0bLyvDL2oZnvDsdAH6(7730), summaryName, name);
		}
		return name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BuildRegionArgs(double x, double y, double width, double height, double angle, double curve, string prefix = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Dictionary<string, string>
		{
			{
				prefix + kgbOBx7BanbFa22Hp9.ol99ukmDA(7748),
				x.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				prefix + kgbOBx7BanbFa22Hp9.ol99ukmDA(7774),
				y.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				prefix + kgbOBx7BanbFa22Hp9.ol99ukmDA(7794),
				width.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				prefix + kgbOBx7BanbFa22Hp9.ol99ukmDA(7822),
				height.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				prefix + kgbOBx7BanbFa22Hp9.ol99ukmDA(7852),
				angle.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				prefix + kgbOBx7BanbFa22Hp9.ol99ukmDA(7880),
				curve.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			}
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BuildAnulusArgs(double x, double y, double innerRadius, double outerRadius)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Dictionary<string, string>
		{
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(7908),
				x.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(7930),
				y.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(7952),
				innerRadius.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(7996),
				outerRadius.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			}
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BuildFixtureArgs(double x, double y, double theta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Dictionary<string, string>
		{
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8040),
				x.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8062),
				y.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8084),
				theta.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			}
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BuildLineArgs(double x0, double y0, double x1, double y1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Dictionary<string, string>
		{
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8114),
				x0.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8132),
				y0.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8150),
				x1.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8168),
				y1.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			}
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BuildCircleArgs(double x, double y, double radius)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Dictionary<string, string>
		{
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8186),
				x.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8206),
				y.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8226),
				radius.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			}
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BuildArcArgs(double centerX, double centerY, double startX, double startY, double endX, double endY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Dictionary<string, string>
		{
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8256),
				centerX.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8284),
				centerY.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8312),
				startX.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8338),
				startY.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8364),
				endX.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8386),
				endY.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			}
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BuildPointArgs(double x, double y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Dictionary<string, string>
		{
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8408),
				x.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8426),
				y.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			}
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, string> BuildCrossArgs(double x, double y, double angle, double width, double height)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Dictionary<string, string>
		{
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8444),
				x.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8462),
				y.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8480),
				angle.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8506),
				width.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			},
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(8532),
				height.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(7768), CultureInfo.InvariantCulture)
			}
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string BuildExpressionFromDouble(double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				if (!(aWRgY6DVCU0QtPwSRjs(value) >= 1E-05))
				{
					break;
				}
				goto default;
			case 3:
				if (value != 0.0)
				{
					_ = 1;
					if (INhu3JAJ4iXpmXMKYuj())
					{
						num = 0;
						continue;
					}
					num = 4;
					if (true)
					{
						continue;
					}
					goto default;
				}
				goto case 5;
			default:
				if (aWRgY6DVCU0QtPwSRjs(value) <= 9999999999.0)
				{
					num = 5;
					continue;
				}
				break;
			case 5:
				return value.ToString((string)j0bLyvDL2oZnvDsdAH6(8560), CultureInfo.InvariantCulture);
			}
			break;
		}
		return value.ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(8578), CultureInfo.InvariantCulture);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sMdfuTA8SHEXjhZOhTH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kgrXANAZwPDI8g53fMI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool INhu3JAJ4iXpmXMKYuj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WLsjOwAzXKIFOFkwMn4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionTable)P_0).FindFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uyhoShDw1SaElypJu3s(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BuildExpression((CvsFunction)P_0, (string[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MotxGtDsaGi5kW9MZLI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).MinNumberOfArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WQJJmPDhkO7OqFdgdR4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).MaxNumberOfArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j0bLyvDL2oZnvDsdAH6(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eli6I0D9kRJ3vAZQXmB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iij5SNDSC2YInpTfHK2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object htTdJ3DEhVh658nkb9N(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GaVXmADvhF5JXMITXrJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sRW9nIDHlc3NC1O6e5p(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double aWRgY6DVCU0QtPwSRjs(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}
}
