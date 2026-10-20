using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellOcrMaxAutoTune : CvsCell
{
	private string MxJf6eHKd2;

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MxJf6eHKd2;
		}
	}

	public override bool IsEditCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
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
			return N2P3wqyh1WCRwLk01fS(typeof(CvsCellOcrMaxAutoTune).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellOcrMaxAutoTune()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (XE0uK6m8gIhy61iJ6AM())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0068;
		IL_003b:
		base._002Ector();
		num = 5;
		goto IL_0068;
		IL_0068:
		switch (num)
		{
		case 0:
		case 3:
			break;
		default:
			goto IL_003b;
		case 1:
			MxJf6eHKd2 = string.Empty;
			goto IL_003b;
		case 5:
			return;
		}
		goto IL_0026;
		IL_0026:
		EycCToywNDbo41Nshu1();
		num = 1;
		if (!XE0uK6m8gIhy61iJ6AM())
		{
			goto IL_003b;
		}
		goto IL_0068;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellOcrMaxAutoTune(CvsCellOcrMaxAutoTune cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				MxJf6eHKd2 = string.Empty;
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				EycCToywNDbo41Nshu1();
				_ = 0;
				if (XE0uK6m8gIhy61iJ6AM())
				{
					num = 4;
					if (XE0uK6m8gIhy61iJ6AM())
					{
						break;
					}
					goto default;
				}
				num = 0;
				if (1 == 0)
				{
					return;
				}
				break;
			default:
				MxJf6eHKd2 = (string)nII9C1ysQdopQsnkfUt(cell);
				num = 6;
				break;
			case 5:
				base._002Ector(cell);
				goto default;
			case 6:
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
		return new CvsCellOcrMaxAutoTune(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MxJf6eHKd2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EycCToywNDbo41Nshu1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XE0uK6m8gIhy61iJ6AM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sete7XmzLWLjUsGARG1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nII9C1ysQdopQsnkfUt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type N2P3wqyh1WCRwLk01fS(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
