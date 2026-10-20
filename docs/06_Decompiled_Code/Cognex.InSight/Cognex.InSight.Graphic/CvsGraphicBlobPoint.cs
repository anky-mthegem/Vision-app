using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public struct CvsGraphicBlobPoint
{
	private readonly CvsGraphicBlobDirection veoBcPFQaV;

	private readonly int bIqB5PxMmc;

	public CvsGraphicBlobDirection Direction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return veoBcPFQaV;
		}
	}

	public int Distance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bIqB5PxMmc;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphicBlobPoint(CvsGraphicBlobDirection direction, int distance)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		jvp0atN3ZotthTg6l1B();
		int num;
		if (!Yy8YIgNOLEmTZ1Ipswp())
		{
			num = 3;
			if (Yy8YIgNOLEmTZ1Ipswp())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0058;
		IL_002e:
		bIqB5PxMmc = distance;
		num = 5;
		goto IL_0058;
		IL_0058:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 2:
				veoBcPFQaV = direction;
				break;
			default:
				goto IL_0075;
			case 0:
			case 3:
				kPYGDZNMs1ST1U6ss1t();
				goto case 1;
			case 5:
				return;
			}
			break;
			IL_0075:
			num = 4;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PointF GetLocation(PointF previousPoint)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		PointF result = default;
		CvsGraphicBlobDirection direction = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				result.X += Distance;
				_ = 1;
				if (!Yy8YIgNOLEmTZ1Ipswp())
				{
					num = 8;
					continue;
				}
				num = 9;
				if (Yy8YIgNOLEmTZ1Ipswp())
				{
				}
				continue;
			case 0:
				result = previousPoint;
				num = 7;
				if (!Yy8YIgNOLEmTZ1Ipswp())
				{
					continue;
				}
				goto case 9;
			case 9:
			case 12:
				result.X -= Distance;
				break;
			case 3:
				switch (direction)
				{
				case CvsGraphicBlobDirection.ChainNW:
					break;
				case CvsGraphicBlobDirection.ChainSW:
					goto IL_006c;
				case CvsGraphicBlobDirection.ChainW:
					goto IL_00c7;
				default:
					goto IL_010c;
				case CvsGraphicBlobDirection.ChainE:
					goto IL_011d;
				case CvsGraphicBlobDirection.ChainSE:
					goto IL_0137;
				case CvsGraphicBlobDirection.ChainN:
					goto IL_019b;
				case CvsGraphicBlobDirection.ChainNE:
					goto IL_01bf;
				case CvsGraphicBlobDirection.ChainS:
					goto IL_024b;
				}
				result.Y -= Distance;
				num = 6;
				continue;
			case 1:
				result.X += Distance;
				num = 13;
				continue;
			case 6:
				result.X -= Distance;
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			default:
				num = 1;
				continue;
			case 7:
				direction = Direction;
				num = 3;
				continue;
			case 2:
			case 4:
			case 5:
			case 8:
			case 10:
			case 13:
			case 14:
			case 15:
				break;
				IL_024b:
				result.Y += Distance;
				num = 2;
				continue;
				IL_01bf:
				result.Y -= Distance;
				goto case 1;
				IL_019b:
				result.Y -= Distance;
				num = 4;
				continue;
				IL_0137:
				result.Y += Distance;
				num = 11;
				continue;
				IL_011d:
				result.X += Distance;
				break;
				IL_010c:
				num = 14;
				if (0 == 0)
				{
					continue;
				}
				break;
				IL_00c7:
				result.X -= Distance;
				num = 15;
				continue;
				IL_006c:
				result.Y += Distance;
				goto case 9;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kPYGDZNMs1ST1U6ss1t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jvp0atN3ZotthTg6l1B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Yy8YIgNOLEmTZ1Ipswp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
