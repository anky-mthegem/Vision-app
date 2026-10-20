using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Circle")]
public class CvsCogCircle : CvsCogShape
{
	[CompilerGenerated]
	private double REq5x9hSM7;

	[CompilerGenerated]
	private double o8a56eZPcX;

	[CompilerGenerated]
	private double tx35pYKwoN;

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
			return REq5x9hSM7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			REq5x9hSM7 = value;
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
			return o8a56eZPcX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			o8a56eZPcX = value;
		}
	}

	[JsonProperty(PropertyName = "radius", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Radius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tx35pYKwoN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tx35pYKwoN = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogCircle()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogCircle(double x, double y, double radius, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 5:
				CellLocation = cellLocation;
				num = 9;
				if (DekXPbPU3DoATntFrHR())
				{
					break;
				}
				goto case 1;
			case 1:
			case 6:
				base._002Ector();
				num = 4;
				break;
			case 7:
				Color = color;
				num = 5;
				break;
			case 0:
			case 3:
				Y = y;
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				Radius = radius;
				num = 7;
				break;
			case 8:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				DekXPbPU3DoATntFrHR();
				if (!V3O0gRPr8Nvsq7nL5jb())
				{
					num = 6;
					break;
				}
				num = 0;
				if (0 == 0)
				{
					break;
				}
				return;
			case 4:
				X = x;
				goto case 0;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DekXPbPU3DoATntFrHR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V3O0gRPr8Nvsq7nL5jb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
