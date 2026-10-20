using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Read;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Read;

public static class FieldingPatternParser
{
	private enum TGJ4Pbd0loyuCQ26oH
	{

	}

	public const string CharacterClass_Any = "";

	public const string CharacterClass_Numerical = "0123456789";

	public const string CharacterClass_Alphabetical = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

	public const string CharacterClass_Alphanumerical = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

	public const string BasicFieldingMatch_AnyCharacter = "anyCharacter";

	public const string BasicFieldingMatch_Alphanumerical = "alphanumericalOnly";

	public const string BasicFieldingMatch_Alphabetical = "alphabeticalOnly";

	public const string BasicFieldingMatch_Numerical = "numericOnly";

	public const string PatternStringMetaChar_AnyCharacter = "\\.";

	public const string PatternStringMetaChar_Alphanumerical = "\\w";

	public const string PatternStringMetaChar_Alphabetical = "\\l";

	public const string PatternStringMetaChar_Numerical = "\\d";

	private static readonly Dictionary<string, string> pNZxIpG1UP;

	private static readonly Dictionary<string, string> xtbx2kJmFM;

	private static readonly Dictionary<string, string> DJqxxbWb7B;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ELReadFieldingCharacterClass BasicStringToCharacterClass(string basicString)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (basicString == null)
		{
			throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(982));
		}
		if (pNZxIpG1UP.TryGetValue(basicString, out var value))
		{
			ELReadFieldingCharacterClass eLReadFieldingCharacterClass = new ELReadFieldingCharacterClass();
			C1yygSko6JoM1ykNgxJ(eLReadFieldingCharacterClass, value);
			return eLReadFieldingCharacterClass;
		}
		throw new ArgumentException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1038));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CharacterClassToBasicString(ELReadFieldingCharacterClass charClass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (charClass == null)
		{
			throw new ArgumentNullException((string)UUEWX2kcjT3d1bYBw4h(1132));
		}
		if (xtbx2kJmFM.TryGetValue((string)aGfqilkuGu1q3tWO78Q(charClass), out var value))
		{
			return value;
		}
		throw new ArgumentException((string)UUEWX2kcjT3d1bYBw4h(1184));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CharacterClassToMetaString(ELReadFieldingCharacterClass charClass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DQhoB7kaHtIZyRDi97D();
		int num = ((!Q03LAFk3jPKwoGxQ0id()) ? 2 : 4);
		string value = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				if (charClass == null)
				{
					goto case 1;
				}
				if (!DJqxxbWb7B.TryGetValue(charClass.AllowedCharacters, out value))
				{
					if (((string)aGfqilkuGu1q3tWO78Q(charClass)).Length == 1)
					{
						num = 5;
						break;
					}
					throw new ArgumentException((string)UUEWX2kcjT3d1bYBw4h(1256));
				}
				goto case 3;
			case 3:
				return value;
			case 1:
			case 2:
				throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1132));
			default:
				num = 3;
				break;
			case 5:
				return (string)aGfqilkuGu1q3tWO78Q(charClass);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ELReadFieldingCharacterClass Xta2U05tUl(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ELReadFieldingCharacterClass eLReadFieldingCharacterClass = new ELReadFieldingCharacterClass();
		C1yygSko6JoM1ykNgxJ(eLReadFieldingCharacterClass, P_0.ToString());
		return eLReadFieldingCharacterClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ELReadFieldingCharacterClass xa12ztaAoI(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
			{
				if (P_0 != '.')
				{
					goto case 0;
				}
				ELReadFieldingCharacterClass eLReadFieldingCharacterClass5 = new ELReadFieldingCharacterClass();
				C1yygSko6JoM1ykNgxJ(eLReadFieldingCharacterClass5, "");
				return eLReadFieldingCharacterClass5;
			}
			case 3:
			{
				if (P_0 != 'w')
				{
					num = 9;
					if (Q03LAFk3jPKwoGxQ0id())
					{
						continue;
					}
					goto case 7;
				}
				ELReadFieldingCharacterClass eLReadFieldingCharacterClass4 = new ELReadFieldingCharacterClass();
				C1yygSko6JoM1ykNgxJ(eLReadFieldingCharacterClass4, UUEWX2kcjT3d1bYBw4h(1476));
				return eLReadFieldingCharacterClass4;
			}
			case 7:
			{
				if (P_0 != 'd')
				{
					break;
				}
				ELReadFieldingCharacterClass eLReadFieldingCharacterClass3 = new ELReadFieldingCharacterClass();
				C1yygSko6JoM1ykNgxJ(eLReadFieldingCharacterClass3, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1344));
				return eLReadFieldingCharacterClass3;
			}
			default:
				num = 5;
				continue;
			case 0:
			case 2:
			{
				if (P_0 != '\\')
				{
					num = 7;
					continue;
				}
				ELReadFieldingCharacterClass eLReadFieldingCharacterClass2 = new ELReadFieldingCharacterClass();
				C1yygSko6JoM1ykNgxJ(eLReadFieldingCharacterClass2, UUEWX2kcjT3d1bYBw4h(1338));
				return eLReadFieldingCharacterClass2;
			}
			case 6:
				if (P_0 != 'n')
				{
					num = 3;
					continue;
				}
				return null;
			case 8:
				if ((uint)P_0 > 100u)
				{
					if (P_0 == 'l')
					{
						ELReadFieldingCharacterClass eLReadFieldingCharacterClass = new ELReadFieldingCharacterClass();
						C1yygSko6JoM1ykNgxJ(eLReadFieldingCharacterClass, UUEWX2kcjT3d1bYBw4h(1368));
						return eLReadFieldingCharacterClass;
					}
					num = 6;
				}
				else
				{
					_ = 1;
					num = ((!DQhoB7kaHtIZyRDi97D()) ? 4 : 0);
				}
				continue;
			case 5:
			case 9:
				break;
			}
			break;
		}
		throw new ArgumentException((string)rQkHl8kB5ZctSTBoHCj(UUEWX2kcjT3d1bYBw4h(1604), P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ELReadPattern AdvancedStringToReadPattern(string advancedFieldingPattern)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		TGJ4Pbd0loyuCQ26oH tGJ4Pbd0loyuCQ26oH = default;
		ELReadPattern eLReadPattern = default;
		ELReadPatternLine eLReadPatternLine = default;
		int num2 = default;
		string text = default;
		char c = default;
		ELReadFieldingCharacterClass eLReadFieldingCharacterClass = default;
		while (true)
		{
			switch (num)
			{
			case 15:
				throw new ArgumentException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1696));
			default:
				num = 8;
				if (DQhoB7kaHtIZyRDi97D())
				{
				}
				break;
			case 5:
				if (tGJ4Pbd0loyuCQ26oH != (TGJ4Pbd0loyuCQ26oH)1)
				{
					rBwxO1DUvW(eLReadPattern, ref eLReadPatternLine);
					num = 18;
					if (Q03LAFk3jPKwoGxQ0id())
					{
						break;
					}
					goto case 0;
				}
				num = 15;
				break;
			case 9:
				tGJ4Pbd0loyuCQ26oH = (TGJ4Pbd0loyuCQ26oH)1;
				num = 17;
				break;
			case 7:
			case 16:
				if (num2 < text.Length)
				{
					c = w7X3GUkxiM2H7o7CwAY(text, num2);
					num = 3;
				}
				else
				{
					num = 5;
				}
				break;
			case 14:
				num2 = 0;
				num = 16;
				break;
			case 11:
				eLReadPattern = new ELReadPattern();
				_ = 1;
				if (!DQhoB7kaHtIZyRDi97D())
				{
					num = 6;
					break;
				}
				num = 4;
				if (true)
				{
					break;
				}
				goto case 2;
			case 4:
			case 10:
				rBwxO1DUvW(eLReadPattern, ref eLReadPatternLine);
				goto case 12;
			case 13:
				throw new ArgumentOutOfRangeException(string.Format((string)UUEWX2kcjT3d1bYBw4h(1658), tGJ4Pbd0loyuCQ26oH));
			case 0:
			case 17:
				num2++;
				num = 7;
				break;
			case 12:
				tGJ4Pbd0loyuCQ26oH = (TGJ4Pbd0loyuCQ26oH)0;
				num = 0;
				break;
			case 1:
			case 6:
				eLReadPatternLine = new ELReadPatternLine();
				tGJ4Pbd0loyuCQ26oH = (TGJ4Pbd0loyuCQ26oH)0;
				text = advancedFieldingPattern;
				num = 14;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				if (tGJ4Pbd0loyuCQ26oH == 0)
				{
					if (c != '\\')
					{
						eLReadPatternLine.Characters.Add((ELReadFieldingCharacterClass)PEUUVCkhgggkosCnhGV(c));
						goto case 0;
					}
					num = 9;
					break;
				}
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 8;
			case 8:
				if (eLReadFieldingCharacterClass != null)
				{
					eLReadPatternLine.Characters.Add(eLReadFieldingCharacterClass);
					num = 12;
					break;
				}
				goto case 4;
			case 2:
				if (tGJ4Pbd0loyuCQ26oH == (TGJ4Pbd0loyuCQ26oH)1)
				{
					eLReadFieldingCharacterClass = (ELReadFieldingCharacterClass)R9QkMIkU996vjK7Pjal(c);
					goto case 8;
				}
				num = 13;
				break;
			case 18:
				return eLReadPattern;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void rBwxO1DUvW(ELReadPattern P_0, ref ELReadPatternLine P_1)
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
				if (CiPPXHkQyRy1awSIUnn(P_1.Characters) > 0)
				{
					_ = 0;
					num = ((!Q03LAFk3jPKwoGxQ0id()) ? 4 : 3);
					continue;
				}
				return;
			case 1:
			case 3:
				P_0.Lines.Add(P_1);
				break;
			case 5:
				return;
			}
			P_1 = new ELReadPatternLine();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldingPatternParser()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (DQhoB7kaHtIZyRDi97D() ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			case 3:
				DJqxxbWb7B = new Dictionary<string, string>
				{
					{
						string.Empty,
						(string)UUEWX2kcjT3d1bYBw4h(1888)
					},
					{
						plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1476),
						(string)UUEWX2kcjT3d1bYBw4h(1896)
					},
					{
						(string)UUEWX2kcjT3d1bYBw4h(1368),
						(string)UUEWX2kcjT3d1bYBw4h(1904)
					},
					{
						(string)UUEWX2kcjT3d1bYBw4h(1344),
						(string)UUEWX2kcjT3d1bYBw4h(1912)
					}
				};
				num = 6;
				break;
			case 0:
			case 2:
				b022TPkqdK9MtDVXn05();
				goto case 1;
			case 1:
			case 5:
				pNZxIpG1UP = new Dictionary<string, string>
				{
					{
						(string)UUEWX2kcjT3d1bYBw4h(1758),
						string.Empty
					},
					{
						(string)UUEWX2kcjT3d1bYBw4h(1786),
						plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1476)
					},
					{
						(string)UUEWX2kcjT3d1bYBw4h(1826),
						(string)UUEWX2kcjT3d1bYBw4h(1368)
					},
					{
						plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1862),
						(string)UUEWX2kcjT3d1bYBw4h(1344)
					}
				};
				num = 4;
				if (DQhoB7kaHtIZyRDi97D())
				{
				}
				break;
			case 4:
				xtbx2kJmFM = new Dictionary<string, string>
				{
					{
						string.Empty,
						(string)UUEWX2kcjT3d1bYBw4h(1758)
					},
					{
						(string)UUEWX2kcjT3d1bYBw4h(1476),
						(string)UUEWX2kcjT3d1bYBw4h(1786)
					},
					{
						(string)UUEWX2kcjT3d1bYBw4h(1368),
						(string)UUEWX2kcjT3d1bYBw4h(1826)
					},
					{
						plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1344),
						plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1862)
					}
				};
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C1yygSko6JoM1ykNgxJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ELReadFieldingCharacterClass)P_0).AllowedCharacters = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q03LAFk3jPKwoGxQ0id()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DQhoB7kaHtIZyRDi97D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UUEWX2kcjT3d1bYBw4h(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aGfqilkuGu1q3tWO78Q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ELReadFieldingCharacterClass)P_0).AllowedCharacters;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rQkHl8kB5ZctSTBoHCj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char w7X3GUkxiM2H7o7CwAY(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PEUUVCkhgggkosCnhGV(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Xta2U05tUl(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R9QkMIkU996vjK7Pjal(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xa12ztaAoI(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CiPPXHkQyRy1awSIUnn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<ELReadFieldingCharacterClass>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b022TPkqdK9MtDVXn05()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}
}
