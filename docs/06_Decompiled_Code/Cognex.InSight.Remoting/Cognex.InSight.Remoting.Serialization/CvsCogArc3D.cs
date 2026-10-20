using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "Arc3D")]
public class CvsCogArc3D : CvsCogShape3D
{
	[CompilerGenerated]
	private double[] AWIU53OVSP;

	[CompilerGenerated]
	private double[] yIeUBL5LxY;

	[CompilerGenerated]
	private double[] N9HUyikGCN;

	[CompilerGenerated]
	private string RKWUMMZpRa;

	[JsonProperty(PropertyName = "mid", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Mid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AWIU53OVSP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AWIU53OVSP = value;
		}
	}

	[JsonProperty(PropertyName = "start", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Start
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yIeUBL5LxY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yIeUBL5LxY = value;
		}
	}

	[JsonProperty(PropertyName = "end", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] End
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N9HUyikGCN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			N9HUyikGCN = value;
		}
	}

	[DefaultValue("Regular")]
	[JsonProperty(PropertyName = "style", DefaultValueHandling = DefaultValueHandling.Populate)]
	public string Style
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RKWUMMZpRa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RKWUMMZpRa = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogArc3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogArc3D(double[] start, double[] mid, double[] end, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (z6fjGCWHISb1EubaAE0() ? 5 : 4);
		do
		{
			IL_0096:
			switch (num)
			{
			case 0:
			case 4:
				nNA7DHWZqpfE74owW2h();
				num = 3;
				goto IL_0096;
			case 2:
			case 5:
				Start = start;
				num = 1;
				goto IL_0096;
			case 6:
				End = end;
				num = 7;
				goto IL_0096;
			case 7:
				Color = color;
				num = 8;
				goto IL_0096;
			case 3:
				base._002Ector();
				goto case 2;
			case 1:
				Mid = mid;
				goto case 6;
			default:
				num = 6;
				if (true)
				{
					goto IL_0096;
				}
				break;
			case 8:
				break;
			case 9:
				return;
			}
			CellLocation = cellLocation;
			num = 9;
		}
		while (mYeurCWuucTfanEP9HP());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mYeurCWuucTfanEP9HP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool z6fjGCWHISb1EubaAE0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nNA7DHWZqpfE74owW2h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
