using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "CompositeRegion")]
public class CvsCogCompositeRegion : CvsCogShape
{
	public static readonly int MaxNumSubRegions;

	[CompilerGenerated]
	private CvsCogSubRegion[] kcO53sNDIW;

	[JsonProperty(PropertyName = "subregions", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CvsCogSubRegion[] SubRegions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kcO53sNDIW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kcO53sNDIW = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogCompositeRegion()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UagQGSPECgrrXSo3T5X();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCogCompositeRegion()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		MaxNumSubRegions = 32;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y52rPSPVmfWix5MDmgt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CX0mJUPRN533vxxPqqt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UagQGSPECgrrXSo3T5X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
