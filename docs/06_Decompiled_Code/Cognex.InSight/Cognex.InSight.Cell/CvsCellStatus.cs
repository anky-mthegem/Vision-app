using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellStatus : CvsCell
{
	private string WdgfH0xF3r;

	public int Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TM0ZtMyVGLRIbm7ou43(eOUHYFyHkC5s24A7ZDJ(CellResult));
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
			return WdgfH0xF3r;
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
			return BswYsWyDInAk5s3um98(typeof(int).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellStatus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (os19tSy9cYdLAa4pQKb())
		{
			goto IL_001e;
		}
		goto IL_006c;
		IL_001e:
		uIZRN9ySXSwoO8TlUhY();
		_ = 1;
		num = ((!os19tSy9cYdLAa4pQKb()) ? 4 : 0);
		goto IL_006c;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				base._002Ector();
				num = 5;
				if (kds8aFyLa6X3mM9rJiO())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				WdgfH0xF3r = "";
				goto default;
			case 5:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellStatus(CvsCellStatus cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		os19tSy9cYdLAa4pQKb();
		int num;
		if (kds8aFyLa6X3mM9rJiO())
		{
			num = 2;
		}
		else
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_0074;
			}
		}
		goto IL_0041;
		IL_0041:
		while (true)
		{
			switch (num)
			{
			case 4:
				base._002Ector(cell);
				goto default;
			case 0:
			case 2:
				break;
			case 5:
				WdgfH0xF3r = "";
				num = 4;
				continue;
			default:
				WdgfH0xF3r = cell.WdgfH0xF3r;
				num = 6;
				if (true)
				{
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_0074;
		IL_0074:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		num = 5;
		goto IL_0041;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellStatus(CvsCellLocation cell, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!kds8aFyLa6X3mM9rJiO()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				uIZRN9ySXSwoO8TlUhY();
				goto case 1;
			case 1:
			case 3:
				WdgfH0xF3r = "";
				num = 2;
				continue;
			case 2:
				base._002Ector(cell, cellResult);
				break;
			default:
				num = 5;
				continue;
			case 5:
				break;
			case 6:
				return;
			}
			WdgfH0xF3r = (string)n2Qrlvyvdp1vdjN2Lfh((CvsCogStatusResult)keUGG8yEUUGJTaYGmCc(cellResult));
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellStatus(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)JsS55ryAu8Qd2TDagSi(47124) + Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uIZRN9ySXSwoO8TlUhY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kds8aFyLa6X3mM9rJiO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool os19tSy9cYdLAa4pQKb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object keUGG8yEUUGJTaYGmCc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n2Qrlvyvdp1vdjN2Lfh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogStatusResult)P_0).Caption;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eOUHYFyHkC5s24A7ZDJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TM0ZtMyVGLRIbm7ou43(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JsS55ryAu8Qd2TDagSi(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type BswYsWyDInAk5s3um98(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
