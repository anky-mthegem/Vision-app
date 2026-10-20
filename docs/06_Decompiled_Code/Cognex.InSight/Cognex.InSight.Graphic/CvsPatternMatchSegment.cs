using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public class CvsPatternMatchSegment
{
	private readonly PointF MFNBeuqsA0;

	private readonly PointF hIXBSH7f4h;

	private readonly Color eDeBrH3ON7;

	private readonly Color b8WBCVsGIP;

	public PointF StartLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MFNBeuqsA0;
		}
	}

	public PointF EndLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hIXBSH7f4h;
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
			return eDeBrH3ON7;
		}
	}

	public int ColorAsRgb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return a0UcjixeVH4PmL2cu8h(eDeBrH3ON7);
		}
	}

	public Color HighlightColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b8WBCVsGIP;
		}
	}

	public int HighlightColorAsRgb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return a0UcjixeVH4PmL2cu8h(b8WBCVsGIP);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsPatternMatchSegment(PointF startLocation, PointF endLocation, Color color, Color highlightColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (lmBwgexrwEuDB6fSiUt() ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 6:
				MFNBeuqsA0 = startLocation;
				num = 2;
				continue;
			case 1:
			case 5:
				base._002Ector();
				num = 6;
				continue;
			case 2:
				hIXBSH7f4h = endLocation;
				break;
			default:
				num = 3;
				continue;
			case 0:
			case 4:
				QwqM2Wx3Pp7bQWHdm5Y();
				goto case 1;
			case 7:
				b8WBCVsGIP = highlightColor;
				num = 8;
				if (b5g2MIx1JBqD5rVchOo())
				{
					continue;
				}
				break;
			case 3:
				break;
			case 8:
				return;
			}
			eDeBrH3ON7 = color;
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsPatternMatchSegment(CvsPatternMatchSegment original)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!b5g2MIx1JBqD5rVchOo()) ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 7:
				hIXBSH7f4h = iJjg7nxQrr6WN4Tje3D(original);
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				eDeBrH3ON7 = original.Color;
				num = 4;
				break;
			case 6:
				IUSsRgxOIhRR1kTqdB9(this);
				goto case 1;
			case 1:
			case 2:
				MFNBeuqsA0 = a0sAfYxMEu8RuL8hGUu(original);
				num = 7;
				break;
			case 4:
				b8WBCVsGIP = GeRvyyxlwSrn8Qv6bNJ(original);
				num = 8;
				break;
			case 0:
			case 3:
				QwqM2Wx3Pp7bQWHdm5Y();
				num = 6;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QwqM2Wx3Pp7bQWHdm5Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b5g2MIx1JBqD5rVchOo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lmBwgexrwEuDB6fSiUt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IUSsRgxOIhRR1kTqdB9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF a0sAfYxMEu8RuL8hGUu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsPatternMatchSegment)P_0).StartLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF iJjg7nxQrr6WN4Tje3D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsPatternMatchSegment)P_0).EndLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color GeRvyyxlwSrn8Qv6bNJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsPatternMatchSegment)P_0).HighlightColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int a0UcjixeVH4PmL2cu8h(Color P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ColorTranslator.ToOle(P_0);
	}
}
