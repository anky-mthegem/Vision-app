using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.Color;

[CvsSerializable("ColorModel")]
public class ColorMatchModel
{
	[JsonProperty("id")]
	private int reMmaBHHj6;

	[CompilerGenerated]
	private ColorMatchModelSettings xAZmxUjgX1;

	[CompilerGenerated]
	private Rgb Lwcm6a9iJL;

	[CompilerGenerated]
	private Hsi UYFmpCFQmx;

	[CompilerGenerated]
	private ColorModelColorSamples ViLm3iA02s;

	[JsonIgnore]
	public ModelId UniqueModelId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new ModelId(reMmaBHHj6);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			reMmaBHHj6 = value.Id;
		}
	}

	[JsonProperty("settings")]
	public ColorMatchModelSettings Settings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xAZmxUjgX1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xAZmxUjgX1 = value;
		}
	}

	[JsonProperty("averageRgb")]
	public Rgb AverageRgb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Lwcm6a9iJL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Lwcm6a9iJL = value;
		}
	}

	[JsonProperty("averageHsi")]
	public Hsi AverageHsi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UYFmpCFQmx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UYFmpCFQmx = value;
		}
	}

	[JsonIgnore]
	public ColorModelColorSamples Samples
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ViLm3iA02s;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ViLm3iA02s = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ColorMatchModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		t8TjoKHO406I7eD4x1D();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V5mGDVHX66CGaRZtaJu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HB1VFbHl4KY8HJE02OT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t8TjoKHO406I7eD4x1D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
