using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "EditingBox3D")]
public class CvsCogEditingBox3D : CvsCogEditingShape3D
{
	[CompilerGenerated]
	private bool iP4FnkTVmF;

	public CvsCogBox3D Box3D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Shape as CvsCogBox3D;
		}
	}

	[JsonProperty(PropertyName = "isHeightColor", DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue("false")]
	public bool IsForHeightColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iP4FnkTVmF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iP4FnkTVmF = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogEditingBox3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PsDekasq0W3sYpjjTpD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JSRgCfsi03GBdovCVHD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
