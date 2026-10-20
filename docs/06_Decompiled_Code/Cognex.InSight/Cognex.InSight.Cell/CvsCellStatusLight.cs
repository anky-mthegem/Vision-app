using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.Common;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellStatusLight : CvsCell
{
	private Color XjhfK4CoFv;

	private string IMFfEYu8GG;

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
			return UFQcYKyjji3m29iPxRn(CellResult.Value);
		}
	}

	public Color Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XjhfK4CoFv;
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
			return IMFfEYu8GG;
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
			return i9mTE5y2bJjvRZuu762(typeof(int).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellStatusLight()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (WV3x92yT94ELtSPUdLD() ? 4 : 5);
		do
		{
			IL_0052:
			switch (num)
			{
			case 0:
			case 5:
				yGHfvVydohm92MMb7dm();
				num = 2;
				if (true)
				{
					goto IL_0052;
				}
				goto case 1;
			case 1:
				IMFfEYu8GG = "";
				break;
			case 2:
				XjhfK4CoFv = DfGxgZyi7vxNvuHt33X();
				num = 1;
				goto IL_0052;
			case 6:
				return;
			}
			base._002Ector();
			num = 6;
		}
		while (CC6VxSyUDGYARSmkWBj());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellStatusLight(CvsCellStatusLight cell)
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
			case 5:
				IMFfEYu8GG = cell.IMFfEYu8GG;
				num = 8;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				yGHfvVydohm92MMb7dm();
				num = 6;
				break;
			case 7:
				base._002Ector(cell);
				goto default;
			default:
				XjhfK4CoFv = cell.XjhfK4CoFv;
				num = 5;
				break;
			case 0:
			case 2:
				IMFfEYu8GG = "";
				num = 7;
				break;
			case 6:
				XjhfK4CoFv = DfGxgZyi7vxNvuHt33X();
				_ = 0;
				num = ((!CC6VxSyUDGYARSmkWBj()) ? 1 : 0);
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellStatusLight(CvsCellLocation cell, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCogStatusResult cvsCogStatusResult = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				IMFfEYu8GG = "";
				num = 2;
				if (!WV3x92yT94ELtSPUdLD())
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				XjhfK4CoFv = Color.Black;
				num = 4;
				break;
			case 0:
				yGHfvVydohm92MMb7dm();
				_ = 0;
				if (CC6VxSyUDGYARSmkWBj())
				{
					num = 3;
					if (!WV3x92yT94ELtSPUdLD())
					{
						break;
					}
					goto case 6;
				}
				num = 7;
				break;
			case 6:
			case 7:
				XjhfK4CoFv = ColorUtils.FromRgb(K1bQmayBCOPnuoYS4E7(cvsCogStatusResult));
				num = 9;
				if (CC6VxSyUDGYARSmkWBj())
				{
					break;
				}
				goto case 5;
			case 5:
				cvsCogStatusResult = (CvsCogStatusResult)cellResult.Face;
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 8;
			case 8:
				IMFfEYu8GG = (string)vkAjH5yqif8HhqyOwEd(cvsCogStatusResult);
				goto case 6;
			case 2:
				base._002Ector(cell, cellResult);
				goto case 5;
			default:
				num = 5;
				if (WV3x92yT94ELtSPUdLD())
				{
				}
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellStatusLight(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)GHnOX2ycEX0yvpfwGTT(kgbOBx7BanbFa22Hp9.ol99ukmDA(47144), Value.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yGHfvVydohm92MMb7dm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color DfGxgZyi7vxNvuHt33X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Black;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CC6VxSyUDGYARSmkWBj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WV3x92yT94ELtSPUdLD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vkAjH5yqif8HhqyOwEd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogStatusResult)P_0).Caption;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int K1bQmayBCOPnuoYS4E7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogStatusResult)P_0).Color;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UFQcYKyjji3m29iPxRn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GHnOX2ycEX0yvpfwGTT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type i9mTE5y2bJjvRZuu762(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
