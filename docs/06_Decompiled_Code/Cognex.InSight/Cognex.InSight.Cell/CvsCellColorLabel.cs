using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.Common;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellColorLabel : CvsCell, ICvsCellText
{
	private Color hMKf3FA165;

	private Color LDWfLbnshn;

	private string RlOfkEQ9DZ;

	public override object CellValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return G7j9IvFMvEWWQ03To3X(this);
		}
	}

	public Color ForeColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hMKf3FA165;
		}
	}

	public Color BackColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LDWfLbnshn;
		}
	}

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RlOfkEQ9DZ;
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
			return typeof(string);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellColorLabel()
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
			case 3:
				hr1w6wFNhkmKkyhQfB8();
				_ = 1;
				if (!zqg0nkFYusf4u8vBhhm())
				{
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 2;
				}
				num = 5;
				continue;
			case 2:
				RlOfkEQ9DZ = "";
				break;
			case 0:
			case 1:
				hMKf3FA165 = sbdEOAFxTD63f0Ygqbg();
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				LDWfLbnshn = sbdEOAFxTD63f0Ygqbg();
				goto case 2;
			default:
				num = 2;
				continue;
			case 4:
			case 5:
				break;
			case 7:
				return;
			}
			base._002Ector();
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellColorLabel(CvsCellColorLabel cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		if (!zqg0nkFYusf4u8vBhhm())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base._002Ector(cell);
				goto default;
			case 2:
			case 4:
				LDWfLbnshn = sbdEOAFxTD63f0Ygqbg();
				num = 3;
				break;
			default:
				hMKf3FA165 = cell.hMKf3FA165;
				num = 6;
				break;
			case 0:
				hMKf3FA165 = sbdEOAFxTD63f0Ygqbg();
				_ = 1;
				if (zqg0nkFYusf4u8vBhhm())
				{
					num = 8;
					break;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				RlOfkEQ9DZ = "";
				num = 1;
				break;
			case 6:
				LDWfLbnshn = cell.LDWfLbnshn;
				num = 7;
				break;
			case 9:
				hr1w6wFNhkmKkyhQfB8();
				num = 0;
				break;
			case 7:
				RlOfkEQ9DZ = cell.RlOfkEQ9DZ;
				num = 10;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellColorLabel(CvsCellLocation cell, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCogColorLabelResult cvsCogColorLabelResult = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 8:
				base._002Ector(cell, cellResult);
				num = 2;
				continue;
			default:
				if (RlOfkEQ9DZ == null)
				{
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				}
				goto case 10;
			case 1:
				hMKf3FA165 = Color.Black;
				LDWfLbnshn = Color.Black;
				num = 11;
				continue;
			case 4:
				RlOfkEQ9DZ = Yi0I5EF12H3RZhStcCe(cellResult) as string;
				goto default;
			case 7:
				RlOfkEQ9DZ = string.Empty;
				num = 10;
				continue;
			case 2:
				cvsCogColorLabelResult = (CvsCogColorLabelResult)cellResult.Face;
				num = 4;
				continue;
			case 11:
				RlOfkEQ9DZ = "";
				zqg0nkFYusf4u8vBhhm();
				if (!CTx9NGFPmY5QH3iTIY4())
				{
					num = 9;
					if (true)
					{
						continue;
					}
					goto case 7;
				}
				num = 8;
				continue;
			case 5:
				LDWfLbnshn = vDiQsrF3QM24BsrDLKb(ntZ2iAFOxonjPSkGdnX(cvsCogColorLabelResult));
				num = 12;
				if (true)
				{
					continue;
				}
				goto case 10;
			case 10:
				hMKf3FA165 = vDiQsrF3QM24BsrDLKb(mZVNJeFrrHrQX2MOYyT(cvsCogColorLabelResult));
				num = 5;
				if (!zqg0nkFYusf4u8vBhhm())
				{
					continue;
				}
				break;
			case 0:
				break;
			case 12:
				return;
			}
			hr1w6wFNhkmKkyhQfB8();
			num = 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellColorLabel(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RlOfkEQ9DZ;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hr1w6wFNhkmKkyhQfB8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color sbdEOAFxTD63f0Ygqbg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Black;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CTx9NGFPmY5QH3iTIY4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zqg0nkFYusf4u8vBhhm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Yi0I5EF12H3RZhStcCe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mZVNJeFrrHrQX2MOYyT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogColorLabelResult)P_0).ForeColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color vDiQsrF3QM24BsrDLKb(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ColorUtils.FromRgb(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ntZ2iAFOxonjPSkGdnX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogColorLabelResult)P_0).BackColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G7j9IvFMvEWWQ03To3X(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Text;
	}
}
