using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicHistogram : CvsGraphic
{
	private int C8UJm0SL5A;

	private int[] o1QJnIV5I6;

	public int Threshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C8UJm0SL5A;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicHistogram(CvsGraphicHistogram graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!Pw5y8y32FBsgUMOZON9()) ? 2 : 3);
		do
		{
			IL_0042:
			switch (num)
			{
			case 4:
				C8UJm0SL5A = graphic.C8UJm0SL5A;
				break;
			default:
				num = 5;
				goto IL_0042;
			case 1:
			case 2:
				base._002Ector(graphic);
				num = 4;
				goto IL_0042;
			case 0:
			case 3:
				BEM8WU37HLqFrEPeIs9();
				goto case 1;
			case 5:
				break;
			case 6:
				return;
			}
			o1QJnIV5I6 = graphic.o1QJnIV5I6;
			num = 6;
		}
		while (Pw5y8y32FBsgUMOZON9());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicHistogram(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int[] GetHistogram()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return o1QJnIV5I6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BEM8WU37HLqFrEPeIs9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Pw5y8y32FBsgUMOZON9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GNGgpv3Wv92np1gbVNG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
