using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicEdgeProfile : CvsGraphic
{
	private int QWBJ4gVQQP;

	private int zACJllosqY;

	private int hhQJg5F9Ay;

	private int[] RkTJq8anKl;

	public int PositiveThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QWBJ4gVQQP;
		}
	}

	public int NegativeThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zACJllosqY;
		}
	}

	public int NumEdgeValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hhQJg5F9Ay;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicEdgeProfile(CvsGraphicEdgeProfile graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0059;
		IL_001a:
		base._002Ector(graphic);
		y31CefrBWUptH627Uav();
		if (!wQYveprj0sIpOkasM4P())
		{
			num = 7;
		}
		else
		{
			num = 4;
			if (wQYveprj0sIpOkasM4P())
			{
			}
		}
		goto IL_0059;
		IL_0059:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 3:
			case 4:
				zACJllosqY = graphic.zACJllosqY;
				goto case 1;
			default:
				num = 1;
				if (y31CefrBWUptH627Uav())
				{
					continue;
				}
				goto case 1;
			case 1:
				hhQJg5F9Ay = graphic.hhQJg5F9Ay;
				num = 5;
				continue;
			case 5:
				RkTJq8anKl = graphic.RkTJq8anKl;
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 7:
				QWBJ4gVQQP = graphic.QWBJ4gVQQP;
				goto case 3;
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 6;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicEdgeProfile(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int[] GetEdgeValues()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RkTJq8anKl;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y31CefrBWUptH627Uav()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wQYveprj0sIpOkasM4P()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
