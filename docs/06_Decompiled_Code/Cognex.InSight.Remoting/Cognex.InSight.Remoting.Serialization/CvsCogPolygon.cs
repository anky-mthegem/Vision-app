using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Polygon")]
public class CvsCogPolygon : CvsCogShape
{
	[CompilerGenerated]
	private bool LH5B2MFByJ;

	[CompilerGenerated]
	private double[] bRjBXrIBFW;

	[CompilerGenerated]
	private int lhqBqPVKGC;

	[JsonProperty(PropertyName = "showFill", DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue(false)]
	public bool ShowFill
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LH5B2MFByJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LH5B2MFByJ = value;
		}
	}

	[JsonProperty(PropertyName = "points", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Points
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bRjBXrIBFW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bRjBXrIBFW = value;
		}
	}

	[JsonProperty(PropertyName = "length", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lhqBqPVKGC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lhqBqPVKGC = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPolygon()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!IBaG6DIUQmZk8KiHjxE()) ? 1 : 3);
		do
		{
			IL_004b:
			switch (num)
			{
			case 0:
			case 1:
				uSxUKvIrElk1FnKpb45();
				num = 4;
				goto IL_004b;
			case 4:
				base._002Ector();
				break;
			case 5:
				return;
			}
			Points = new double[0];
			num = 5;
		}
		while (!IBaG6DIUQmZk8KiHjxE());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPolygon(IEnumerable<double> points)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
		Points = new List<double>(points).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uSxUKvIrElk1FnKpb45()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WcgfP8IfSU3HkYksDW9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IBaG6DIUQmZk8KiHjxE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
