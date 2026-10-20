using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;

public class MathToolFunctionValidation
{
	private readonly CvsFunctionTable yckgsNtiE6;

	private readonly CvsFunctionGroupCategory[] RhGgKwIVNL;

	private static readonly string[] iARgGb0Ynr;

	private static readonly string[] NKYgBWcP0V;

	private static readonly string[] twVgZcvu1P;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MathToolFunctionValidation(CvsFunctionTable functionTable)
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
		goto IL_0055;
		IL_008a:
		IEnumerable<IReadOnlyList<CvsFunction>> source = iARgGb0Ynr.Select([MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yckgsNtiE6.FindFunctionsByName(P_0);
		}).Where([MethodImpl(MethodImplOptions.NoInlining)] (IReadOnlyList<CvsFunction> f) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f.Any();
		});
		num = 1;
		if (0 == 0)
		{
			goto IL_0055;
		}
		goto IL_00d4;
		IL_0055:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 2:
				goto IL_003c;
			default:
				goto IL_008a;
			case 6:
				goto IL_00d4;
			case 1:
				RhGgKwIVNL = source.Select([MethodImpl(MethodImplOptions.NoInlining)] (IReadOnlyList<CvsFunction> f) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return f[0].Category;
				}).ToArray();
				num = 7;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_003c:
		yckgsNtiE6 = functionTable;
		goto IL_008a;
		IL_001a:
		hec6mSX8KD96uWAkcgs(this);
		_ = 1;
		if (!V4Mn7jXkjgdh9xnskFT())
		{
			num = 0;
			if (V4Mn7jXkjgdh9xnskFT())
			{
				goto IL_003c;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0055;
		IL_00d4:
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		num = 4;
		goto IL_0055;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidFunction(CvsFunction function)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		string name = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (yckgsNtiE6.FindFunctionsByName(name).All([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunction P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return RhGgKwIVNL.Contains(P_0.Category);
				}))
				{
					_ = 1;
					num = ((!V4Mn7jXkjgdh9xnskFT()) ? 1 : 4);
					continue;
				}
				if (twVgZcvu1P.Contains(name, (IEqualityComparer<string>)AV7srKXqOLDur7PGdhD()))
				{
					goto default;
				}
				if (!NKYgBWcP0V.Contains(name, (IEqualityComparer<string>)AV7srKXqOLDur7PGdhD()))
				{
					num = 5;
					if (V4Mn7jXkjgdh9xnskFT())
					{
					}
					continue;
				}
				break;
			case 1:
			case 2:
				return false;
			case 6:
				name = function.Name;
				num = 0;
				continue;
			default:
				return false;
			case 5:
				if (function.PropertySheetEdit)
				{
					num = 7;
					continue;
				}
				break;
			case 7:
				return false;
			}
			break;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MathToolFunctionValidation()
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
			case 1:
				gSWecTXEHJEmkvoe0ZI();
				num = 0;
				break;
			case 2:
			case 5:
				NKYgBWcP0V = new string[35]
				{
					(string)KbLO4iXpnw6w6V9W83d(22942),
					(string)KbLO4iXpnw6w6V9W83d(1890),
					(string)KbLO4iXpnw6w6V9W83d(22966),
					(string)KbLO4iXpnw6w6V9W83d(22986),
					(string)KbLO4iXpnw6w6V9W83d(23002),
					(string)KbLO4iXpnw6w6V9W83d(23026),
					(string)KbLO4iXpnw6w6V9W83d(23050),
					(string)KbLO4iXpnw6w6V9W83d(23074),
					(string)KbLO4iXpnw6w6V9W83d(23102),
					(string)KbLO4iXpnw6w6V9W83d(23116),
					(string)KbLO4iXpnw6w6V9W83d(23146),
					(string)KbLO4iXpnw6w6V9W83d(23168),
					(string)KbLO4iXpnw6w6V9W83d(23186),
					(string)KbLO4iXpnw6w6V9W83d(23210),
					(string)KbLO4iXpnw6w6V9W83d(23228),
					(string)KbLO4iXpnw6w6V9W83d(23248),
					(string)KbLO4iXpnw6w6V9W83d(23262),
					(string)KbLO4iXpnw6w6V9W83d(23288),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23300),
					(string)KbLO4iXpnw6w6V9W83d(23318),
					(string)KbLO4iXpnw6w6V9W83d(23336),
					(string)KbLO4iXpnw6w6V9W83d(23354),
					(string)KbLO4iXpnw6w6V9W83d(23364),
					(string)KbLO4iXpnw6w6V9W83d(23388),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23410),
					(string)KbLO4iXpnw6w6V9W83d(23430),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23452),
					(string)KbLO4iXpnw6w6V9W83d(23476),
					(string)KbLO4iXpnw6w6V9W83d(23490),
					(string)KbLO4iXpnw6w6V9W83d(23520),
					(string)KbLO4iXpnw6w6V9W83d(23546),
					(string)KbLO4iXpnw6w6V9W83d(23574),
					(string)KbLO4iXpnw6w6V9W83d(23612),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23656),
					(string)KbLO4iXpnw6w6V9W83d(23672)
				};
				goto default;
			default:
				twVgZcvu1P = new string[16]
				{
					(string)KbLO4iXpnw6w6V9W83d(23702),
					(string)KbLO4iXpnw6w6V9W83d(23724),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23740),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(1822),
					(string)KbLO4iXpnw6w6V9W83d(23760),
					(string)KbLO4iXpnw6w6V9W83d(23786),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23812),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23844),
					(string)KbLO4iXpnw6w6V9W83d(23872),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23786),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(23904),
					(string)KbLO4iXpnw6w6V9W83d(23930),
					(string)KbLO4iXpnw6w6V9W83d(23966),
					(string)KbLO4iXpnw6w6V9W83d(23990),
					(string)KbLO4iXpnw6w6V9W83d(24000),
					(string)KbLO4iXpnw6w6V9W83d(24014)
				};
				num = 6;
				break;
			case 0:
				iARgGb0Ynr = new string[17]
				{
					(string)KbLO4iXpnw6w6V9W83d(22302),
					(string)KbLO4iXpnw6w6V9W83d(22322),
					(string)KbLO4iXpnw6w6V9W83d(22374),
					(string)KbLO4iXpnw6w6V9W83d(22424),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(22464),
					(string)KbLO4iXpnw6w6V9W83d(22488),
					(string)KbLO4iXpnw6w6V9W83d(22526),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(22566),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(22610),
					(string)KbLO4iXpnw6w6V9W83d(22652),
					(string)KbLO4iXpnw6w6V9W83d(22680),
					(string)KbLO4iXpnw6w6V9W83d(22714),
					(string)KbLO4iXpnw6w6V9W83d(22744),
					(string)KbLO4iXpnw6w6V9W83d(22782),
					(string)KbLO4iXpnw6w6V9W83d(22824),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(22850),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(22900)
				};
				jm261OXS3hAehqvT5cd();
				num = ((!V4Mn7jXkjgdh9xnskFT()) ? 5 : 4);
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private IReadOnlyList<CvsFunction> KFlgkvWOSx(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return yckgsNtiE6.FindFunctionsByName(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool O0ygPTOFNo(CvsFunction P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RhGgKwIVNL.Contains(P_0.Category);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hec6mSX8KD96uWAkcgs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jm261OXS3hAehqvT5cd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V4Mn7jXkjgdh9xnskFT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AV7srKXqOLDur7PGdhD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return StringComparer.OrdinalIgnoreCase;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gSWecTXEHJEmkvoe0ZI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KbLO4iXpnw6w6V9W83d(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
