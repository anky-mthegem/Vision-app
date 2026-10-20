using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.Data;

public struct CnxTableLocation
{
	public int Sheet;

	public int Column;

	public int Row;

	public static readonly CnxTableLocation Invalid;

	public const int MaxRow = 65534;

	public const int MaxColumn = 1022;

	public const int MaxSheet = 62;

	public const int MaxOneLetterColumn = 25;

	public const int MaxTwoLetterColumn = 701;

	public bool IsValid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (Row >= 0)
					{
						num = 7;
						continue;
					}
					break;
				case 6:
					if (Sheet < 0)
					{
						break;
					}
					qoktt9snfqrrwi62XO9();
					if (kUGu6FsaKjWnvFYofHR())
					{
						num = 3;
						continue;
					}
					num = 5;
					if (kUGu6FsaKjWnvFYofHR())
					{
						continue;
					}
					goto case 2;
				case 1:
				case 3:
					if (Sheet > 62)
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					if (Column < 0)
					{
						break;
					}
					goto case 4;
				default:
					num = 4;
					continue;
				case 4:
					if (Column <= 1022)
					{
						num = 0;
						continue;
					}
					break;
				case 7:
					return Row <= 65534;
				}
				break;
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxTableLocation(int sheetColumn, int row)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_006d;
		IL_002e:
		gCCYMasGCM1ObGMGP17();
		kUGu6FsaKjWnvFYofHR();
		if (!qoktt9snfqrrwi62XO9())
		{
			num = 3;
			if (!kUGu6FsaKjWnvFYofHR())
			{
				goto IL_0053;
			}
		}
		else
		{
			num = 0;
		}
		goto IL_006d;
		IL_0053:
		int num2 = (sheetColumn >> 10) & 0x3F;
		goto IL_001a;
		IL_006d:
		int num3 = default;
		switch (num)
		{
		case 4:
			goto IL_002e;
		case 1:
		case 3:
			goto IL_0053;
		case 5:
			Sheet = ((num2 > 62) ? (-1) : num2);
			Column = ((num3 > 1022) ? (-1) : num3);
			Row = ((row > 65534) ? (-1) : row);
			return;
		}
		goto IL_001a;
		IL_001a:
		num3 = sheetColumn & 0x3FF;
		num = 5;
		if (false)
		{
			goto IL_002e;
		}
		goto IL_006d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxTableLocation(int sheet, int column, int row)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gCCYMasGCM1ObGMGP17();
		Sheet = ((sheet > 62) ? (-1) : sheet);
		Column = ((column > 1022) ? (-1) : column);
		Row = ((row > 65534) ? (-1) : row);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxTableLocation(string str, int index, out bool absoluteColumn, out bool absoluteRow, out int numChars)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gCCYMasGCM1ObGMGP17();
		this = new CnxTableLocation(str, index, out absoluteColumn, out absoluteRow, out numChars, null, -1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxTableLocation(string str, int index, out bool absoluteColumn, out bool absoluteRow, out int numChars, string[] sheets, int activeSheetIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0069;
		IL_001a:
		int num2 = default;
		if (num2 >= 0)
		{
			num = 11;
			goto IL_0069;
		}
		goto IL_00c4;
		IL_00c4:
		int num4 = default;
		int num3 = (num4 = (num2 = -1));
		num = 2;
		goto IL_0069;
		IL_0069:
		int numChars2 = default;
		int numChars3 = default;
		int numChars4 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				break;
			case 6:
				Sheet = num3;
				num = 12;
				continue;
			case 2:
				numChars = numChars2 + numChars3 + numChars4;
				num = 6;
				continue;
			case 11:
				if (num4 >= 0)
				{
					goto case 2;
				}
				goto IL_00c4;
			default:
				num = 8;
				continue;
			case 10:
				Row = num4;
				num = 13;
				if (true)
				{
					continue;
				}
				goto IL_00c4;
			case 8:
				goto IL_00c4;
			case 9:
				num3 = SheetFromString(str, index, out numChars2, sheets, activeSheetIndex);
				num = 7;
				continue;
			case 1:
				gCCYMasGCM1ObGMGP17();
				num = 9;
				continue;
			case 7:
				num2 = ColumnFromString(str, index + numChars2, out absoluteColumn, out numChars3);
				_ = 0;
				if (kUGu6FsaKjWnvFYofHR())
				{
					num = 0;
					if (kUGu6FsaKjWnvFYofHR())
					{
						continue;
					}
					goto case 12;
				}
				num = 5;
				continue;
			case 12:
				Column = num2;
				num = 10;
				continue;
			case 0:
			case 3:
				num4 = RowFromString(str, index + numChars2 + numChars3, out absoluteRow, out numChars4);
				if (num3 >= 0)
				{
					break;
				}
				goto IL_00c4;
			case 13:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxTableLocation(string str)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gCCYMasGCM1ObGMGP17();
		this = new CnxTableLocation(str, null, -1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxTableLocation(string str, string[] sheets, int activeSheetIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		int num4 = default;
		int num3 = default;
		int num2 = default;
		int numChars = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (num4 < 0)
				{
					goto case 9;
				}
				goto case 2;
			case 9:
				num3 = (num2 = (num4 = int.MinValue));
				num = 10;
				if (!qoktt9snfqrrwi62XO9())
				{
					break;
				}
				goto case 6;
			case 6:
				Column = num4;
				num = 4;
				if (kUGu6FsaKjWnvFYofHR())
				{
					break;
				}
				goto case 10;
			case 10:
				Sheet = num3;
				num = 6;
				break;
			case 2:
			case 5:
				if (num2 < 0)
				{
					goto case 9;
				}
				goto case 10;
			default:
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 7:
				num3 = SheetFromString(str, 0, out numChars, sheets, activeSheetIndex);
				num = 11;
				break;
			case 11:
			{
				num4 = ColumnFromString(str, numChars, out var absoluteColumn, out var numChars2);
				num2 = RowFromString(str, numChars + numChars2, out absoluteColumn, out var _);
				num = 8;
				break;
			}
			case 8:
				if (num3 < 0)
				{
					goto case 9;
				}
				num = 3;
				if (!qoktt9snfqrrwi62XO9())
				{
					break;
				}
				goto case 0;
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				_ = 0;
				num = (kUGu6FsaKjWnvFYofHR() ? 7 : 2);
				break;
			case 4:
				Row = num2;
				num = 12;
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SheetFromString(string str, int index, out int numChars, string[] sheets, int activeSheetIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (str.Length <= index)
				{
					num = 2;
					continue;
				}
				num2 = BhRW92sXTtMKHo1qS8i(str, '!');
				goto case 4;
			case 8:
				numChars = 0;
				_ = 1;
				num = (qoktt9snfqrrwi62XO9() ? 9 : 5);
				continue;
			case 3:
				if (sheets != null)
				{
					num = 7;
					continue;
				}
				goto case 6;
			case 1:
			case 5:
				if (str != null)
				{
					num = 0;
					continue;
				}
				goto case 2;
			case 7:
				if (sheets.Length == 0)
				{
					num = 6;
					if (kUGu6FsaKjWnvFYofHR())
					{
						continue;
					}
					goto case 4;
				}
				try
				{
					int result = PnQbSNspQys90mHLE0p(Nc9gF9s6PBZQ6dsg2Pa(str, 0, num2));
					numChars = num2 + 1;
					return result;
				}
				catch (Exception)
				{
					int num3 = 0;
					foreach (string text in sheets)
					{
						if (!FPIdFHs0iK23p1vggLY(text) && qiae04sFrvuLM2CiMH7(rlpJfFs41Nc8rdG1XCY(str, index), DwA7KvsfXYJokFDj6SO(text, IKFFPNsk56NtoHcu4NQ(840)), StringComparison.CurrentCultureIgnoreCase))
						{
							numChars = PYZa3BsmULQ2rcxZdK2(text) + 1;
							return num3;
						}
						num3++;
					}
				}
				break;
			case 4:
			case 9:
				if (num2 < 0)
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				continue;
			case 6:
				numChars = num2 + 1;
				num = 10;
				continue;
			case 2:
				return int.MinValue;
			case 10:
				return X8bos4sbXmNspX0VwZg(0, activeSheetIndex);
			}
			break;
		}
		return Math.Max(0, activeSheetIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ColumnFromString(string str, int index, out bool absoluteColumn, out int numChars)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		int num4 = default;
		if (true)
		{
			int num2 = default;
			int num5 = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 10:
					break;
				case 7:
					if (str.Length != num2)
					{
						num5 = JICjx9sg3UIMkwC58dn(A022g5syepQUgjjYwMB(str, num2), hYToI9sZugHmQ9hhrrg()) - 65;
						if (num5 >= 0)
						{
							num = 15;
							continue;
						}
						goto case 2;
					}
					num = 0;
					continue;
				case 26:
					if (str != null)
					{
						num = 16;
						continue;
					}
					goto IL_0260;
				case 14:
					numChars = num2 - index;
					num = 25;
					continue;
				case 11:
					numChars = num2 - index;
					num = 27;
					continue;
				case 18:
				case 20:
					return num4;
				case 23:
					num4 = int.MinValue;
					num = 11;
					continue;
				case 1:
					return int.MinValue;
				case 21:
					if (num3 > 25)
					{
						goto case 14;
					}
					num2++;
					num4 = (num4 + 1) * 26 + num3;
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 0;
				default:
					num = 14;
					continue;
				case 15:
					if (num5 <= 25)
					{
						num2++;
						num = 5;
					}
					else
					{
						num = 2;
					}
					continue;
				case 6:
					numChars = num2 - index;
					return num4;
				case 13:
					absoluteColumn = false;
					num = 26;
					continue;
				case 3:
					if (str.Length == num2)
					{
						numChars = num2 - index;
						return int.MinValue;
					}
					num4 = JICjx9sg3UIMkwC58dn(A022g5syepQUgjjYwMB(str, num2), CultureInfo.InvariantCulture) - 65;
					num = 17;
					continue;
				case 8:
					if (num4 <= 25)
					{
						num2++;
						num = 24;
					}
					else
					{
						num = 12;
					}
					continue;
				case 5:
					num4 = (num4 + 1) * 26 + num5;
					goto case 19;
				case 25:
					return num4;
				case 0:
					numChars = num2 - index;
					num = 10;
					continue;
				case 17:
					if (num4 >= 0)
					{
						num = 8;
						continue;
					}
					goto case 12;
				case 4:
					if (num3 >= 0)
					{
						num = 21;
						continue;
					}
					goto case 14;
				case 12:
					numChars = num2 - index;
					num = 1;
					continue;
				case 16:
					if (PYZa3BsmULQ2rcxZdK2(str) > index)
					{
						num2 = index;
						if (str[num2] == '$')
						{
							num2++;
							num = 9;
							continue;
						}
						goto case 3;
					}
					goto IL_0260;
				case 24:
					if (PYZa3BsmULQ2rcxZdK2(str) != num2)
					{
						num3 = char.ToUpper(A022g5syepQUgjjYwMB(str, num2), CultureInfo.InvariantCulture) - 65;
						num = 4;
					}
					else
					{
						num = 6;
					}
					continue;
				case 19:
				case 22:
					if (num4 > 1022)
					{
						num = 23;
						continue;
					}
					goto case 11;
				case 2:
					numChars = num2 - index;
					_ = 1;
					if (qoktt9snfqrrwi62XO9())
					{
						num = 19;
						continue;
					}
					num = 18;
					if (kUGu6FsaKjWnvFYofHR())
					{
						continue;
					}
					goto case 9;
				case 9:
					absoluteColumn = true;
					num = 3;
					if (kUGu6FsaKjWnvFYofHR())
					{
						continue;
					}
					goto case 27;
				case 27:
					{
						return num4;
					}
					IL_0260:
					numChars = 0;
					return int.MinValue;
				}
				break;
			}
		}
		return num4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int RowFromString(string str, int index, out bool absoluteRow, out int numChars)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		if (!qoktt9snfqrrwi62XO9())
		{
		}
		int num3 = default;
		int num2 = default;
		char c = default;
		bool flag = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				absoluteRow = true;
				goto IL_0025;
			case 2:
			case 7:
				if (str.Length <= index)
				{
					num = 11;
					if (kUGu6FsaKjWnvFYofHR())
					{
						continue;
					}
					goto case 10;
				}
				num3 = index;
				num = 16;
				if (!qoktt9snfqrrwi62XO9())
				{
					continue;
				}
				break;
			case 10:
				num2 = 0;
				num = 17;
				if (0 == 0)
				{
					continue;
				}
				goto case 17;
			default:
				num = 9;
				if (!qoktt9snfqrrwi62XO9())
				{
					continue;
				}
				goto case 16;
			case 16:
				if (str[num3] == '$')
				{
					num = 0;
					continue;
				}
				goto IL_0025;
			case 9:
				if (do7ID5sJxeTcbbDwAe3(c))
				{
					num = 13;
					continue;
				}
				goto case 14;
			case 12:
				num2 = int.MinValue;
				num = 14;
				if (qoktt9snfqrrwi62XO9())
				{
				}
				continue;
			case 17:
				if (num3 < str.Length)
				{
					c = A022g5syepQUgjjYwMB(str, num3);
					goto case 9;
				}
				num = 18;
				if (true)
				{
					continue;
				}
				goto case 13;
			case 13:
				num3++;
				flag = true;
				num = 3;
				if (qoktt9snfqrrwi62XO9())
				{
				}
				continue;
			case 1:
			case 6:
				if (str != null)
				{
					goto case 2;
				}
				goto case 11;
			case 4:
				num2 = int.MinValue;
				goto IL_0183;
			case 0:
				num3++;
				num = 8;
				continue;
			case 3:
				num2 = num2 * 10 + c - 48;
				num = 5;
				continue;
			case 14:
			case 18:
				if (flag)
				{
					goto IL_0183;
				}
				num = 4;
				if (!qoktt9snfqrrwi62XO9())
				{
					continue;
				}
				goto case 15;
			case 15:
				absoluteRow = false;
				qoktt9snfqrrwi62XO9();
				num = (kUGu6FsaKjWnvFYofHR() ? 6 : 7);
				continue;
			case 5:
				if (num2 > 65534)
				{
					num = 12;
					continue;
				}
				goto case 17;
			case 11:
				numChars = 0;
				return int.MinValue;
			case 19:
				break;
				IL_0183:
				numChars = num3 - index;
				num = 19;
				continue;
				IL_0025:
				flag = false;
				num = 10;
				if (qoktt9snfqrrwi62XO9())
				{
				}
				continue;
			}
			break;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(CnxTableLocation a, CnxTableLocation b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (a.Sheet == b.Sheet && a.Row == b.Row)
		{
			return a.Column == b.Column;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(CnxTableLocation a, CnxTableLocation b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !sM0jJXs8BOu8W6I9AMd(a, b);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj is CnxTableLocation)
		{
			return sM0jJXs8BOu8W6I9AMd((CnxTableLocation)obj, this);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Row << 16) | (Column & 0x3FF) | ((Sheet << 10) & 0xFC00);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ColumnFromString(string str)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int result = ColumnFromString(str, 0, out var _, out var numChars);
		if (numChars != PYZa3BsmULQ2rcxZdK2(str))
		{
			return int.MinValue;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SheetToString(int sheet, string[] sheets, int activeSheetIndex, StringBuilder sb)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ColumnToString(int column, StringBuilder sb)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		int num3 = default;
		int num4 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				Ux5FL5sz8qq0CijND3U(sb, ']');
				num = 1;
				break;
			case 14:
				if (num3 > 701)
				{
					num = 10;
					break;
				}
				if (num3 <= 25)
				{
					goto case 7;
				}
				goto case 6;
			case 3:
				Ux5FL5sz8qq0CijND3U(sb, (char)(65 + num4));
				num = 0;
				break;
			case 5:
				Ux5FL5sz8qq0CijND3U(sb, (char)(65 + num2));
				goto case 11;
			default:
				num = 11;
				break;
			case 0:
				num3 -= num4 * 26;
				goto case 7;
			case 7:
				sb.Append((char)(65 + num3));
				num = 18;
				if (kUGu6FsaKjWnvFYofHR())
				{
					break;
				}
				goto case 6;
			case 6:
			case 13:
				num3 -= 26;
				num4 = num3 / 26;
				num = 3;
				break;
			case 12:
				num3 -= num2 * 26;
				num = 7;
				break;
			case 16:
				if (column >= 0)
				{
					num = 17;
					break;
				}
				goto IL_01a7;
			case 10:
				num3 -= 702;
				num = 9;
				break;
			case 9:
				num2 = num3 / 676;
				num = 5;
				break;
			case 11:
				num3 -= num2 * 26 * 26;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 2:
			case 15:
				sb.Append(column.ToString((IFormatProvider)hYToI9sZugHmQ9hhrrg()));
				num = 8;
				break;
			case 17:
				if (column <= 1022)
				{
					num3 = column;
					num = 14;
					if (false)
					{
						return;
					}
					break;
				}
				goto IL_01a7;
			case 4:
				num2 = num3 / 26;
				Ux5FL5sz8qq0CijND3U(sb, (char)(65 + num2));
				num = 12;
				if (false)
				{
					return;
				}
				break;
			case 1:
				return;
			case 18:
				return;
				IL_01a7:
				Ux5FL5sz8qq0CijND3U(sb, '[');
				qoktt9snfqrrwi62XO9();
				num = (kUGu6FsaKjWnvFYofHR() ? 15 : 6);
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ColumnToString(int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		StringBuilder stringBuilder = new StringBuilder();
		ColumnToString(column, stringBuilder);
		return stringBuilder.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ToString(int column, int row, bool absoluteColumn, bool absoluteRow)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)AEAZOYhwed5NWmTKCvf(0, column, row, absoluteColumn, absoluteRow, null, -1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ToString(string sheetName, int column, int row, bool absoluteColumn, bool absoluteRow)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		StringBuilder stringBuilder = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				if (absoluteRow)
				{
					num = 10;
					if (0 == 0)
					{
						break;
					}
					goto case 10;
				}
				goto default;
			case 10:
				stringBuilder.Append('$');
				goto default;
			case 11:
				do
				{
					Ux5FL5sz8qq0CijND3U(stringBuilder, '$');
					_ = 0;
					if (!kUGu6FsaKjWnvFYofHR())
					{
						num = 0;
						continue;
					}
					num = 1;
					break;
				}
				while (1 == 0);
				break;
			default:
				if (row < 0)
				{
					stringBuilder.Append('[');
					num = 4;
				}
				else
				{
					wfdyeLhhq2q0LhYJ0oU(stringBuilder, row.ToString());
					num = 12;
				}
				break;
			case 4:
				wfdyeLhhq2q0LhYJ0oU(stringBuilder, row.ToString());
				num = 7;
				break;
			case 1:
			case 3:
				uynqAahspCWwy4SKevo(column, stringBuilder);
				num = 2;
				break;
			case 8:
				if (absoluteColumn)
				{
					num = 11;
					break;
				}
				goto case 1;
			case 5:
				stringBuilder = new StringBuilder();
				num = 8;
				if (qoktt9snfqrrwi62XO9())
				{
				}
				break;
			case 7:
				Ux5FL5sz8qq0CijND3U(stringBuilder, ']');
				num = 9;
				break;
			case 9:
			case 12:
				return stringBuilder.ToString();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ToString(int sheet, int column, int row, bool absoluteColumn, bool absoluteRow, string[] sheets, int activeSheetIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		StringBuilder stringBuilder = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				if (absoluteRow)
				{
					num = 8;
					if (!qoktt9snfqrrwi62XO9())
					{
						break;
					}
					goto case 4;
				}
				goto case 5;
			case 4:
				piYRSRhLSGwMXfXXasE(sheet, sheets, activeSheetIndex, stringBuilder);
				if (absoluteColumn)
				{
					qoktt9snfqrrwi62XO9();
					num = ((!kUGu6FsaKjWnvFYofHR()) ? 9 : 11);
					break;
				}
				goto case 3;
			case 1:
				wfdyeLhhq2q0LhYJ0oU(stringBuilder, row.ToString());
				num = 0;
				break;
			case 3:
				ColumnToString(column, stringBuilder);
				num = 12;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
			case 9:
				Ux5FL5sz8qq0CijND3U(stringBuilder, '[');
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				stringBuilder = new StringBuilder();
				num = 4;
				break;
			case 2:
			case 11:
				stringBuilder.Append('$');
				num = 3;
				break;
			case 8:
				Ux5FL5sz8qq0CijND3U(stringBuilder, '$');
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
				Ux5FL5sz8qq0CijND3U(stringBuilder, ']');
				num = 10;
				break;
			case 5:
				if (row >= 0)
				{
					wfdyeLhhq2q0LhYJ0oU(stringBuilder, row.ToString());
					num = 13;
					if (kUGu6FsaKjWnvFYofHR())
					{
						break;
					}
					goto case 0;
				}
				goto case 7;
			case 10:
			case 13:
				return stringBuilder.ToString();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)AEAZOYhwed5NWmTKCvf(Sheet, Column, Row, false, false, new string[0], 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToString(string[] sheets, int activeSheetIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)AEAZOYhwed5NWmTKCvf(Sheet, Column, Row, false, false, sheets, activeSheetIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToString(bool absoluteColumn, bool absoluteRow)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToString(absoluteColumn, absoluteRow, null, -1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToString(bool absoluteColumn, bool absoluteRow, string[] sheets, int activeSheetIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)AEAZOYhwed5NWmTKCvf(Sheet, Column, Row, absoluteColumn, absoluteRow, sheets, activeSheetIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Compare(CnxTableLocation a, CnxTableLocation b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 5:
				return -1;
			case 3:
				return -1;
			default:
				num = 4;
				break;
			case 4:
				return 1;
			case 1:
			case 7:
				return -1;
			case 0:
			case 2:
				return 1;
			case 6:
				if (a.Sheet >= b.Sheet)
				{
					if (a.Sheet <= b.Sheet)
					{
						if (a.Row >= b.Row)
						{
							if (a.Row > b.Row)
							{
								goto case 4;
							}
							if (a.Column >= b.Column)
							{
								if (a.Column <= b.Column)
								{
									return 0;
								}
								num = 8;
							}
							else
							{
								num = 5;
							}
							break;
						}
						num = 3;
						break;
					}
				}
				else
				{
					kUGu6FsaKjWnvFYofHR();
					if (!qoktt9snfqrrwi62XO9())
					{
						num = 7;
						if (kUGu6FsaKjWnvFYofHR())
						{
							break;
						}
						goto case 8;
					}
					num = 0;
					if (kUGu6FsaKjWnvFYofHR())
					{
						break;
					}
				}
				goto case 0;
			case 8:
				return 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CnxTableLocation()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gCCYMasGCM1ObGMGP17();
		Invalid = new CnxTableLocation(int.MinValue, int.MinValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gCCYMasGCM1ObGMGP17()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kUGu6FsaKjWnvFYofHR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qoktt9snfqrrwi62XO9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BhRW92sXTtMKHo1qS8i(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int X8bos4sbXmNspX0VwZg(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nc9gF9s6PBZQ6dsg2Pa(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PnQbSNspQys90mHLE0p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return int.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FPIdFHs0iK23p1vggLY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rlpJfFs41Nc8rdG1XCY(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IKFFPNsk56NtoHcu4NQ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DwA7KvsfXYJokFDj6SO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qiae04sFrvuLM2CiMH7(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PYZa3BsmULQ2rcxZdK2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char A022g5syepQUgjjYwMB(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char JICjx9sg3UIMkwC58dn(char P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.ToUpper(P_0, (CultureInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hYToI9sZugHmQ9hhrrg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool do7ID5sJxeTcbbDwAe3(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.IsDigit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sM0jJXs8BOu8W6I9AMd(CnxTableLocation a, CnxTableLocation b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return a == b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ux5FL5sz8qq0CijND3U(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AEAZOYhwed5NWmTKCvf(int sheet, int column, int row, bool absoluteColumn, bool absoluteRow, object P_5, int activeSheetIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToString(sheet, column, row, absoluteColumn, absoluteRow, (string[])P_5, activeSheetIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uynqAahspCWwy4SKevo(int column, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ColumnToString(column, (StringBuilder)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wfdyeLhhq2q0LhYJ0oU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void piYRSRhLSGwMXfXXasE(int sheet, object P_1, int activeSheetIndex, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SheetToString(sheet, (string[])P_1, activeSheetIndex, (StringBuilder)P_3);
	}
}
