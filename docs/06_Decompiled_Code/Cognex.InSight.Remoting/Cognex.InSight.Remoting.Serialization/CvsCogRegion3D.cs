using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Region3D")]
public class CvsCogRegion3D : CvsCogShape3D
{
	[CompilerGenerated]
	private double[] UHNBS0LL3N;

	[CompilerGenerated]
	private double mG2BnvwkMb;

	[JsonProperty(PropertyName = "size", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UHNBS0LL3N;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UHNBS0LL3N = value;
		}
	}

	[JsonProperty(PropertyName = "curve", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Curve
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mG2BnvwkMb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mG2BnvwkMb = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRegion3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uUD8tTIv2yTCuAg33WP();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRegion3D(double[] modelMatrix, double[] size, double curve, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0057;
		IL_001a:
		Curve = curve;
		num = 8;
		if (1 == 0)
		{
			goto IL_002d;
		}
		goto IL_0057;
		IL_0057:
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				break;
			case 0:
				goto IL_002d;
			case 1:
				Size = size;
				goto default;
			default:
				_ = 0;
				if (zdUUgcIjrauQ1xuQvC9())
				{
					num = 5;
					continue;
				}
				num = 2;
				if (tBqbSmImhyCwAogc8dK())
				{
				}
				continue;
			case 3:
				base._002Ector();
				num = 0;
				continue;
			case 2:
			case 6:
				CellLocation = cellLocation;
				num = 9;
				continue;
			case 7:
				uUD8tTIv2yTCuAg33WP();
				num = 3;
				continue;
			case 8:
				Color = color;
				goto case 2;
			case 9:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_002d:
		ModelMatrix = modelMatrix;
		num = 1;
		goto IL_0057;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uUD8tTIv2yTCuAg33WP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zdUUgcIjrauQ1xuQvC9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tBqbSmImhyCwAogc8dK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
