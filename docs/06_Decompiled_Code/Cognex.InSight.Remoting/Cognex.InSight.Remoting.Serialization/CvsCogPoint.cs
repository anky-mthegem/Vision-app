using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Point")]
public class CvsCogPoint : CvsCogShape
{
	[CompilerGenerated]
	private double xTsByq2Rid;

	[CompilerGenerated]
	private double cdPBMLvKPr;

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
			return xTsByq2Rid;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xTsByq2Rid = value;
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
			return cdPBMLvKPr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cdPBMLvKPr = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPoint()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPoint(double x, double y, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 7:
				Y = y;
				goto default;
			default:
				Color = color;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				CellLocation = cellLocation;
				num = 8;
				break;
			case 2:
				base._002Ector();
				num = 1;
				break;
			case 1:
				X = x;
				j680DCIccFRgZKbneJf();
				num = (MtJ9peIIVcWBpUfHMDw() ? 7 : 5);
				break;
			case 0:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				num = 2;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MtJ9peIIVcWBpUfHMDw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool j680DCIccFRgZKbneJf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
