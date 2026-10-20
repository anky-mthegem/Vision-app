using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Plane3D")]
public class CvsCogPlane3D : CvsCogShape3D
{
	[CompilerGenerated]
	private double[] NmABY18cqc;

	[CompilerGenerated]
	private double[] N4iB52gUHn;

	[CompilerGenerated]
	private bool nebBBiJ1XS;

	[JsonProperty(PropertyName = "normal", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Normal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NmABY18cqc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NmABY18cqc = value;
		}
	}

	[JsonProperty(PropertyName = "point", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Point
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N4iB52gUHn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			N4iB52gUHn = value;
		}
	}

	[JsonProperty(PropertyName = "directionIndicator", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool DirectionIndicator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nebBBiJ1XS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nebBBiJ1XS = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPlane3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		R92e58IPUGQQBsJcLdn();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPlane3D(double[] normal, double[] point, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cObqKgIwHlm7RmEZFN5();
		int num;
		if (Hw0u2MIsKSGl9JOQlZl())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 7;
		}
		goto IL_0052;
		IL_002a:
		R92e58IPUGQQBsJcLdn();
		num = 5;
		goto IL_0052;
		IL_0052:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 3:
			case 7:
				Point = point;
				goto case 6;
			default:
				num = 6;
				continue;
			case 5:
				base._002Ector();
				num = 2;
				continue;
			case 1:
				CellLocation = cellLocation;
				num = 8;
				continue;
			case 2:
				Normal = normal;
				goto case 3;
			case 6:
				Color = color;
				num = 1;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R92e58IPUGQQBsJcLdn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Hw0u2MIsKSGl9JOQlZl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cObqKgIwHlm7RmEZFN5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
