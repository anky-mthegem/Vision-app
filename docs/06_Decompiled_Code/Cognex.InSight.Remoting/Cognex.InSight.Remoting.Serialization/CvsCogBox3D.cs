using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Box3D")]
public class CvsCogBox3D : CvsCogShape3D
{
	[CompilerGenerated]
	private double[] Osm5NYpHep;

	[CompilerGenerated]
	private bool cZU5fQHWD1;

	[CompilerGenerated]
	private bool ONj544hP0M;

	[CompilerGenerated]
	private string mNR52llrA0;

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
			return Osm5NYpHep;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Osm5NYpHep = value;
		}
	}

	[JsonProperty(PropertyName = "axisIndicator", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool AxisIndicator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cZU5fQHWD1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cZU5fQHWD1 = value;
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
			return ONj544hP0M;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ONj544hP0M = value;
		}
	}

	[DefaultValue("Z")]
	[JsonProperty(PropertyName = "directionIndicatorAxis", DefaultValueHandling = DefaultValueHandling.Populate)]
	public string DirectionIndicatorAxis
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mNR52llrA0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mNR52llrA0 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogBox3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		w36xcBPtprTvSpPGdR2();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogBox3D(double[] modelMatrix, double[] size, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (SFcT4qPZQlui4nGrF57() ? 3 : 6);
		while (true)
		{
			switch (num)
			{
			case 2:
				ModelMatrix = modelMatrix;
				num = 5;
				continue;
			case 5:
				Size = size;
				goto default;
			case 7:
				base._002Ector();
				num = 2;
				continue;
			case 0:
			case 6:
				w36xcBPtprTvSpPGdR2();
				num = 7;
				continue;
			default:
				Color = color;
				num = 1;
				if (F5dk9aPHW86hka0YqEM())
				{
					continue;
				}
				break;
			case 1:
				break;
			case 8:
				return;
			}
			CellLocation = cellLocation;
			num = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w36xcBPtprTvSpPGdR2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F5dk9aPHW86hka0YqEM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SFcT4qPZQlui4nGrF57()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
