using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Data;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public struct CvsCellLocation
{
	private int OUIpx8pFvd;

	private int qtdpFnWJ9K;

	public static readonly CvsCellLocation Invalid;

	public const int MaxSheet = 62;

	public const int MaxRow = 65534;

	public const int MaxColumn = 1022;

	public static CvsCellLocation PropertySheet;

	public int Row
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OUIpx8pFvd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OUIpx8pFvd = value;
		}
	}

	public int Column
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qtdpFnWJ9K;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qtdpFnWJ9K = value;
		}
	}

	public bool IsValid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (dRAftwqfJsi43eJZAq9())
			{
				goto IL_001e;
			}
			goto IL_0040;
			IL_00c6:
			return false;
			IL_0040:
			switch (num)
			{
			case 0:
			case 1:
				break;
			default:
				goto IL_006f;
			case 3:
				goto IL_008b;
			case 5:
				return qtdpFnWJ9K != int.MaxValue;
			}
			goto IL_001e;
			IL_008b:
			if (OUIpx8pFvd != int.MinValue)
			{
				dRAftwqfJsi43eJZAq9();
				if (!bCXy6LqkhBJH59HCUEx())
				{
					num = 4;
					if (false)
					{
						goto IL_006f;
					}
				}
				else
				{
					num = 0;
				}
				goto IL_0040;
			}
			goto IL_00c6;
			IL_001e:
			if (OUIpx8pFvd != int.MaxValue)
			{
				goto IL_006f;
			}
			goto IL_00c6;
			IL_006f:
			if (qtdpFnWJ9K != int.MinValue)
			{
				num = 5;
				if (true)
				{
					goto IL_0040;
				}
				goto IL_008b;
			}
			goto IL_00c6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation(string location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!dRAftwqfJsi43eJZAq9())
		{
		}
		CnxTableLocation cnxTableLocation = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 9:
				OUIpx8pFvd = -1;
				goto case 6;
			default:
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 8:
				qtdpFnWJ9K = cnxTableLocation.Column;
				num = 11;
				break;
			case 4:
				if (cnxTableLocation.Row == -1)
				{
					num = 2;
					break;
				}
				goto IL_0023;
			case 10:
				cnxTableLocation = new CnxTableLocation(location);
				num = 4;
				break;
			case 2:
				if (cnxTableLocation.Column == -1)
				{
					num = 9;
					break;
				}
				goto IL_0023;
			case 1:
			case 7:
				OUIpx8pFvd = cnxTableLocation.Row;
				goto case 0;
			case 6:
				qtdpFnWJ9K = -1;
				num = 3;
				break;
			case 5:
				xJF8LvqFqeZGZSL6eJ8();
				num = 10;
				break;
			case 11:
				return;
				IL_0023:
				if (cnxTableLocation.IsValid)
				{
					dRAftwqfJsi43eJZAq9();
					num = (bCXy6LqkhBJH59HCUEx() ? 1 : 0);
					break;
				}
				throw new ArgumentException((string)amyroyqysmDEScDE8A2(WADv3QqmH3Lrxso3fK4(), kgbOBx7BanbFa22Hp9.ol99ukmDA(13830), location));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation(int row, string column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				OUIpx8pFvd = -1;
				num = 0;
				break;
			case 3:
				qtdpFnWJ9K = -1;
				goto case 6;
			default:
				num = 6;
				break;
			case 4:
			case 7:
				qtdpFnWJ9K = num2;
				num = 9;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 10:
				if (row == -1)
				{
					num = 1;
					break;
				}
				goto IL_00e3;
			case 1:
				if (num2 == -1)
				{
					num = 3;
					break;
				}
				goto IL_00e3;
			case 5:
				xJF8LvqFqeZGZSL6eJ8();
				num = 8;
				break;
			case 8:
				num2 = DwRgvFqgFrnyPnLRlFf(column);
				_ = 0;
				if (bCXy6LqkhBJH59HCUEx())
				{
					num = 10;
					break;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 9;
			case 0:
				return;
			case 9:
				if (qtdpFnWJ9K < 0)
				{
					num = 11;
					if (!dRAftwqfJsi43eJZAq9())
					{
						break;
					}
					goto case 11;
				}
				return;
			case 11:
				{
					throw new ArgumentException(string.Format((string)HeqD99qZGSv0Eq8y7Tu(13866), WADv3QqmH3Lrxso3fK4(), column, row));
				}
				IL_00e3:
				OUIpx8pFvd = row;
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation(int row, char column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		this = new CvsCellLocation(row, column.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation(int row, int col)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bCXy6LqkhBJH59HCUEx();
		int num = (dRAftwqfJsi43eJZAq9() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				qtdpFnWJ9K = col;
				num = 5;
				break;
			case 3:
				OUIpx8pFvd = row;
				goto default;
			case 0:
			case 4:
				xJF8LvqFqeZGZSL6eJ8();
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsCellLocation(BinaryReader reader)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!bCXy6LqkhBJH59HCUEx()) ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 3:
				qtdpFnWJ9K = Mybh0jq8bgdm0kSG0QH(reader);
				num = 5;
				break;
			case 0:
			case 2:
				xJF8LvqFqeZGZSL6eJ8();
				goto case 1;
			case 1:
			case 4:
				OUIpx8pFvd = d2e27GqJnA1iYMXKKtI(reader);
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CvsCellLocation(string location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellLocation(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellLocation Parse(string location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellLocation(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellLocation TryParse(string location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CnxTableLocation cnxTableLocation = new CnxTableLocation(location);
		if (cnxTableLocation.IsValid)
		{
			return new CvsCellLocation(cnxTableLocation.Row, cnxTableLocation.Column);
		}
		return Invalid;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Write(BinaryWriter writer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0049;
		IL_001a:
		awdnxuqzv6S7UgDKQGf(writer, OUIpx8pFvd);
		num = 1;
		goto IL_0049;
		IL_0049:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
			case 4:
				awdnxuqzv6S7UgDKQGf(writer, -1);
				return;
			default:
				return;
			case 0:
				return;
			case 1:
				if (qtdpFnWJ9K <= 1022)
				{
					awdnxuqzv6S7UgDKQGf(writer, qtdpFnWJ9K);
					num = 6;
				}
				else
				{
					dRAftwqfJsi43eJZAq9();
					num = (bCXy6LqkhBJH59HCUEx() ? 4 : 0);
				}
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCellLocation cvsCellLocation = default;
		CnxTableLocation cnxTableLocation = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 7:
				cvsCellLocation = (CvsCellLocation)obj;
				goto case 2;
			case 0:
				if (obj is CvsCellLocation)
				{
					_ = 0;
					num = (bCXy6LqkhBJH59HCUEx() ? 7 : 3);
					break;
				}
				if (obj is CnxTableLocation)
				{
					goto case 6;
				}
				return false;
			case 4:
				if (cnxTableLocation.Row == Row)
				{
					num = 8;
					break;
				}
				return false;
			case 2:
			case 3:
				if (cvsCellLocation.Row == Row)
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				return false;
			case 5:
				return cvsCellLocation.Column == Column;
			default:
				num = 6;
				break;
			case 6:
				cnxTableLocation = (CnxTableLocation)obj;
				num = 4;
				break;
			case 8:
				return cnxTableLocation.Column == Column;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(CvsCellLocation left, CvsCellLocation right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (left.Row == right.Row)
		{
			return left.Column == right.Column;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(CvsCellLocation left, CvsCellLocation right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (left.Row == right.Row)
		{
			return left.Column != right.Column;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xBL6iTBwSogB1u3vXkI(Row, Column);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetHashCode(int row, int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (row << 16) | column;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToString(absoluteRow: false, absoluteColumn: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToString(bool absoluteRow, bool absoluteColumn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)AOFsyYBsgoWElywrVeU(qtdpFnWJ9K, OUIpx8pFvd, absoluteColumn, absoluteRow);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string NormalizeCell(string location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = (string)sJKEebBhuTkYgdyy9G2(location);
		if (text != null)
		{
			return text;
		}
		throw new ArgumentException((string)amyroyqysmDEScDE8A2(Resources.InvalidCell, HeqD99qZGSv0Eq8y7Tu(13830), location));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string TryNormalizeCell(string location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!bCXy6LqkhBJH59HCUEx()) ? 4 : 2);
		int numChars = default;
		CnxTableLocation cnxTableLocation = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (numChars == TVNh1tBLdtUABbXdHnt(location))
				{
					num = 5;
					continue;
				}
				break;
			case 0:
			case 2:
			{
				cnxTableLocation = new CnxTableLocation(location, 0, out bool absoluteColumn, out absoluteColumn, out numChars);
				goto case 1;
			}
			case 1:
			case 4:
				if (!cnxTableLocation.IsValid)
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				continue;
			case 5:
				return cnxTableLocation.ToString();
			}
			break;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCellLocation()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dRAftwqfJsi43eJZAq9();
		int num = ((!bCXy6LqkhBJH59HCUEx()) ? 3 : 2);
		do
		{
			IL_004e:
			switch (num)
			{
			case 1:
			case 3:
				Invalid = new CvsCellLocation(int.MinValue, int.MinValue);
				break;
			default:
				num = 4;
				if (bCXy6LqkhBJH59HCUEx())
				{
					goto IL_004e;
				}
				goto case 0;
			case 0:
			case 2:
				xJF8LvqFqeZGZSL6eJ8();
				goto case 1;
			case 4:
				break;
			case 5:
				return;
			}
			PropertySheet = new CvsCellLocation(-1, -1);
			num = 5;
		}
		while (bCXy6LqkhBJH59HCUEx());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xJF8LvqFqeZGZSL6eJ8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WADv3QqmH3Lrxso3fK4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InvalidCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object amyroyqysmDEScDE8A2(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bCXy6LqkhBJH59HCUEx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dRAftwqfJsi43eJZAq9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DwRgvFqgFrnyPnLRlFf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxTableLocation.ColumnFromString((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HeqD99qZGSv0Eq8y7Tu(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int d2e27GqJnA1iYMXKKtI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadInt32();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static short Mybh0jq8bgdm0kSG0QH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadInt16();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void awdnxuqzv6S7UgDKQGf(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BinaryWriter)P_0).Write(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xBL6iTBwSogB1u3vXkI(int row, int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetHashCode(row, column);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AOFsyYBsgoWElywrVeU(int column, int row, bool absoluteColumn, bool absoluteRow)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxTableLocation.ToString(column, row, absoluteColumn, absoluteRow);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sJKEebBhuTkYgdyy9G2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TryNormalizeCell((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TVNh1tBLdtUABbXdHnt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}
}
