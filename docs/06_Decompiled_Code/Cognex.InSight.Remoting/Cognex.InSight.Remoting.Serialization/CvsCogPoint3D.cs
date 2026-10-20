using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Point3D")]
public class CvsCogPoint3D : CvsCogShape3D
{
	[CompilerGenerated]
	private double[] wuhBINbmv8;

	[JsonProperty(PropertyName = "position", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wuhBINbmv8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wuhBINbmv8 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPoint3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lmqUqnIhWBe58fDu0Lr();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPoint3D(double[] position, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0049;
		IL_0030:
		Position = position;
		goto IL_0095;
		IL_0049:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 2:
			case 4:
				goto IL_0030;
			default:
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				lmqUqnIhWBe58fDu0Lr();
				_ = 0;
				num = (zqhpAQIqVhg7dgx634b() ? 5 : 4);
				continue;
			case 6:
				goto IL_0095;
			case 0:
				CellLocation = cellLocation;
				num = 7;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_0095:
		Color = color;
		num = 0;
		goto IL_0049;
		IL_001a:
		base._002Ector();
		goto IL_0030;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lmqUqnIhWBe58fDu0Lr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zqhpAQIqVhg7dgx634b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ixv5osIifWR124jFvK3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
