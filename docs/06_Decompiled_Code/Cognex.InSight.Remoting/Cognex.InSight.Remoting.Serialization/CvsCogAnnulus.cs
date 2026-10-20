using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Annulus")]
public class CvsCogAnnulus : CvsCogShape
{
	[CompilerGenerated]
	private double JZ4YG0kFvN;

	[CompilerGenerated]
	private double AUyY7qW4OF;

	[CompilerGenerated]
	private double oXBYWMkUCL;

	[CompilerGenerated]
	private double u3DYojJ5dE;

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
			return JZ4YG0kFvN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JZ4YG0kFvN = value;
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
			return AUyY7qW4OF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AUyY7qW4OF = value;
		}
	}

	[JsonProperty(PropertyName = "innerRadius", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double InnerRadius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oXBYWMkUCL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oXBYWMkUCL = value;
		}
	}

	[JsonProperty(PropertyName = "outerRadius", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double OuterRadius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return u3DYojJ5dE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			u3DYojJ5dE = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAnnulus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bdulkRPWjV97OOCAKue();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAnnulus(double x, double y, double innerRadius, double outerRadius, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!FAOTUGPQovQYb9I1DTc())
		{
			num = 9;
			if (!DWfq5QwzR0QlbCPWKxd())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 8;
			if (false)
			{
				goto IL_008c;
			}
		}
		goto IL_00a5;
		IL_00a5:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 6:
				goto IL_003c;
			case 4:
				X = x;
				num = 7;
				continue;
			case 1:
			case 8:
				base._002Ector();
				num = 4;
				if (!FAOTUGPQovQYb9I1DTc())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 9:
				bdulkRPWjV97OOCAKue();
				goto case 1;
			case 2:
				goto IL_008c;
			default:
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				Color = color;
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				Y = y;
				num = 2;
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_003c:
		OuterRadius = outerRadius;
		num = 5;
		goto IL_00a5;
		IL_002a:
		CellLocation = cellLocation;
		num = 10;
		goto IL_00a5;
		IL_008c:
		InnerRadius = innerRadius;
		goto IL_003c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bdulkRPWjV97OOCAKue()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DWfq5QwzR0QlbCPWKxd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FAOTUGPQovQYb9I1DTc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
