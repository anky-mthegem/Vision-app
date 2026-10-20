using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Fixture")]
public class CvsCogFixture : CvsCogShape
{
	[CompilerGenerated]
	private double KnK5sBXI82;

	[CompilerGenerated]
	private double o8y50sFQpG;

	[CompilerGenerated]
	private double n2l5G1x3aq;

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
			return KnK5sBXI82;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KnK5sBXI82 = value;
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
			return o8y50sFQpG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			o8y50sFQpG = value;
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
			return n2l5G1x3aq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			n2l5G1x3aq = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogFixture()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MHAWcMPgU7u0sJ4Hhvk();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogFixture(double x, double y, double angle, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (IrVdSnPbOV7WUEkTTt0())
		{
			goto IL_001e;
		}
		goto IL_00ac;
		IL_001e:
		MHAWcMPgU7u0sJ4Hhvk();
		num = 5;
		goto IL_00ac;
		IL_00ac:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 8:
				X = x;
				kS4coxPOpavMLkjjrhO();
				num = (IrVdSnPbOV7WUEkTTt0() ? 2 : 7);
				continue;
			case 5:
				base._002Ector();
				num = 8;
				continue;
			case 1:
				Color = color;
				num = 6;
				continue;
			default:
				Angle = angle;
				num = 1;
				continue;
			case 6:
				CellLocation = cellLocation;
				num = 9;
				continue;
			case 3:
			case 7:
				Y = y;
				goto default;
			case 9:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MHAWcMPgU7u0sJ4Hhvk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kS4coxPOpavMLkjjrhO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IrVdSnPbOV7WUEkTTt0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
