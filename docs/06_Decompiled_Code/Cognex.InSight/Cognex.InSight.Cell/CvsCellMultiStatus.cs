using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using Cognex.Common;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellMultiStatus : CvsCell
{
	private int VLdfU8S9fn;

	private int NdQf0yVJlo;

	private bool UfMfwofDQ5;

	private Color cipfRFhXX2;

	private Color JdHfs7M62v;

	public override object CellValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Value;
		}
	}

	public int Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XMN483mFX47fdBpERNj(hbIBhImf2bVjWVEMsqU(CellResult));
		}
	}

	public int StartBit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VLdfU8S9fn;
		}
	}

	public int NumBits
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NdQf0yVJlo;
		}
	}

	public bool ReverseOrder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UfMfwofDQ5;
		}
	}

	public Color Color0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cipfRFhXX2;
		}
	}

	public Color Color1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JdHfs7M62v;
		}
	}

	public override Type DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nvxXJwmJJEAPWDgnNfM(typeof(int).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellMultiStatus()
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
			default:
				base._002Ector();
				num = 6;
				if (HYd8cLman9d5wDRiDow())
				{
					continue;
				}
				goto case 2;
			case 2:
				JdHfs7M62v = qiTFL0mXdYaN6RmHoOt();
				goto default;
			case 5:
				V91rbrmGAbUPl76LMOx();
				_ = 0;
				if (!HYd8cLman9d5wDRiDow())
				{
					num = 0;
					continue;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				break;
			case 1:
			case 4:
				break;
			case 6:
				return;
			}
			cipfRFhXX2 = qiTFL0mXdYaN6RmHoOt();
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellMultiStatus(CvsCellMultiStatus cell)
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
			case 2:
				NdQf0yVJlo = cell.NdQf0yVJlo;
				num = 4;
				break;
			case 10:
				cipfRFhXX2 = qiTFL0mXdYaN6RmHoOt();
				num = 5;
				break;
			case 6:
				base._002Ector(cell);
				num = 1;
				break;
			case 7:
			case 9:
				cipfRFhXX2 = cell.cipfRFhXX2;
				goto case 0;
			case 1:
				VLdfU8S9fn = cell.VLdfU8S9fn;
				goto case 2;
			default:
				num = 2;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 8:
				JdHfs7M62v = cell.JdHfs7M62v;
				num = 11;
				break;
			case 3:
				V91rbrmGAbUPl76LMOx();
				num = 10;
				break;
			case 4:
				UfMfwofDQ5 = cell.UfMfwofDQ5;
				_ = 1;
				if (LbiNhnmn2b7YHpTDI5o())
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				num = 9;
				break;
			case 5:
				JdHfs7M62v = qiTFL0mXdYaN6RmHoOt();
				num = 6;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellMultiStatus(CvsCellLocation cell, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsCogMultiStatusResult cvsCogMultiStatusResult = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				VLdfU8S9fn = cvsCogMultiStatusResult.StartBit;
				NdQf0yVJlo = nXVQFNm6RwiNdkgGTPe(cvsCogMultiStatusResult);
				HYd8cLman9d5wDRiDow();
				num = (LbiNhnmn2b7YHpTDI5o() ? 2 : 9);
				continue;
			case 3:
				JdHfs7M62v = qiTFL0mXdYaN6RmHoOt();
				num = 7;
				continue;
			case 7:
				base._002Ector(cell, cellResult);
				num = 0;
				continue;
			case 4:
				cipfRFhXX2 = ColorUtils.FromRgb(YSYor3m0LIdQNwN2SNv(cvsCogMultiStatusResult));
				break;
			case 1:
				V91rbrmGAbUPl76LMOx();
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				cvsCogMultiStatusResult = (CvsCogMultiStatusResult)IE0o2Tmbha9MUI5jO1x(cellResult);
				goto case 5;
			default:
				num = 5;
				continue;
			case 6:
			case 9:
				UfMfwofDQ5 = qecb3DmpDUq6t6hvu5k(cvsCogMultiStatusResult);
				num = 4;
				continue;
			case 10:
				cipfRFhXX2 = qiTFL0mXdYaN6RmHoOt();
				num = 3;
				continue;
			case 2:
			case 8:
				break;
			case 11:
				return;
			}
			JdHfs7M62v = VOhR35mkFQ0C7piYsMT(gUn2kvm4QdswSKOMAQk(cvsCogMultiStatusResult));
			num = 11;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellMultiStatus(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		int num2 = default;
		int num3 = default;
		StringBuilder stringBuilder = default;
		int num4 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
			case 8:
				if (num2 >= NdQf0yVJlo)
				{
					break;
				}
				if ((Value & num3) != 0)
				{
					GaVHLtmyAUqNh63HOgL(stringBuilder, HLwOLvmm3G8DyYIintb(41870));
					num = 10;
				}
				else
				{
					GaVHLtmyAUqNh63HOgL(stringBuilder, HLwOLvmm3G8DyYIintb(34482));
					num = 15;
				}
				continue;
			default:
				num = 5;
				continue;
			case 2:
			case 14:
				if (!UfMfwofDQ5)
				{
					num4 = 0;
					num = 12;
				}
				else
				{
					num = 0;
				}
				continue;
			case 4:
			case 11:
				num3 <<= 1;
				num = 7;
				continue;
			case 9:
				stringBuilder.Insert(0, (string)HLwOLvmm3G8DyYIintb(41870));
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 7:
				num4++;
				goto case 12;
			case 12:
				if (num4 < NdQf0yVJlo)
				{
					if ((Value & num3) != 0)
					{
						num = 9;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					}
					u7iPZQmgi2wLGgl88El(stringBuilder, 0, kgbOBx7BanbFa22Hp9.ol99ukmDA(34482));
					num = 4;
					continue;
				}
				num = 16;
				continue;
			case 10:
			case 15:
				num3 <<= 1;
				num2++;
				num = 6;
				continue;
			case 0:
				num2 = 0;
				num = 8;
				continue;
			case 13:
				stringBuilder = new StringBuilder(16);
				_ = 0;
				if (HYd8cLman9d5wDRiDow())
				{
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				}
				num = 14;
				continue;
			case 1:
			case 3:
				num3 = 1 << VLdfU8S9fn;
				goto case 2;
			case 5:
			case 16:
				break;
			}
			break;
		}
		return (string)xx2afAmZ9IxhUBld2vv(HLwOLvmm3G8DyYIintb(47094), stringBuilder.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V91rbrmGAbUPl76LMOx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color qiTFL0mXdYaN6RmHoOt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Black;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HYd8cLman9d5wDRiDow()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LbiNhnmn2b7YHpTDI5o()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IE0o2Tmbha9MUI5jO1x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nXVQFNm6RwiNdkgGTPe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogMultiStatusResult)P_0).NumBits;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qecb3DmpDUq6t6hvu5k(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogMultiStatusResult)P_0).Reverse;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YSYor3m0LIdQNwN2SNv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogMultiStatusResult)P_0).Color0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gUn2kvm4QdswSKOMAQk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogMultiStatusResult)P_0).Color1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color VOhR35mkFQ0C7piYsMT(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ColorUtils.FromRgb(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hbIBhImf2bVjWVEMsqU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XMN483mFX47fdBpERNj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HLwOLvmm3G8DyYIintb(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GaVHLtmyAUqNh63HOgL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u7iPZQmgi2wLGgl88El(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Insert(P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xx2afAmZ9IxhUBld2vv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type nvxXJwmJJEAPWDgnNfM(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
