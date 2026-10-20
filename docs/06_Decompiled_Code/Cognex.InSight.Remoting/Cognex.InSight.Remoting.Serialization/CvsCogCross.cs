using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Cross")]
public class CvsCogCross : CvsCogShape
{
	[CompilerGenerated]
	private double C9f598DV5H;

	[CompilerGenerated]
	private double aYa5L478aa;

	[CompilerGenerated]
	private double D6O5VuGRRV;

	[CompilerGenerated]
	private double F3K5O2Rflc;

	[CompilerGenerated]
	private double Ola5tViy7T;

	[JsonProperty(PropertyName = "x", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double X
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C9f598DV5H;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			C9f598DV5H = value;
		}
	}

	[JsonProperty(PropertyName = "y", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aYa5L478aa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aYa5L478aa = value;
		}
	}

	[JsonProperty(PropertyName = "w", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D6O5VuGRRV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			D6O5VuGRRV = value;
		}
	}

	[JsonProperty(PropertyName = "h", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return F3K5O2Rflc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			F3K5O2Rflc = value;
		}
	}

	[JsonProperty(PropertyName = "angle", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Angle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ola5tViy7T;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ola5tViy7T = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogCross()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HfTVLPPF54HvIY8i4df();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogCross(double x, double y, double w, double h, double a, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (JwigcxPo9vOI9FxHbau())
		{
			goto IL_001e;
		}
		goto IL_008f;
		IL_001e:
		Angle = a;
		num = 5;
		if (!cjuw89PTcYmcdODOI22())
		{
			goto IL_0036;
		}
		goto IL_008f;
		IL_008f:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 10:
				goto IL_0036;
			case 8:
				Y = y;
				goto case 4;
			case 9:
				CellLocation = cellLocation;
				num = 11;
				continue;
			case 4:
			case 7:
				Width = w;
				goto case 3;
			default:
				num = 3;
				if (!JwigcxPo9vOI9FxHbau())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				base._002Ector();
				num = 10;
				if (cjuw89PTcYmcdODOI22())
				{
					continue;
				}
				goto case 0;
			case 0:
				HfTVLPPF54HvIY8i4df();
				JwigcxPo9vOI9FxHbau();
				if (!cjuw89PTcYmcdODOI22())
				{
					num = 7;
					if (!JwigcxPo9vOI9FxHbau())
					{
						continue;
					}
					goto case 9;
				}
				num = 2;
				continue;
			case 5:
				Color = color;
				num = 9;
				continue;
			case 3:
				Height = h;
				num = 6;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_0036:
		X = x;
		num = 8;
		goto IL_008f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HfTVLPPF54HvIY8i4df()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cjuw89PTcYmcdODOI22()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JwigcxPo9vOI9FxHbau()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
