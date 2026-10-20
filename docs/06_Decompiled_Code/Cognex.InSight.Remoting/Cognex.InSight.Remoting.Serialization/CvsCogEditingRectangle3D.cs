using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "EditingRectangle3D")]
public class CvsCogEditingRectangle3D : CvsCogEditingShape3D
{
	[CompilerGenerated]
	private bool QQEC8BiApQ;

	[JsonProperty(PropertyName = "inPlane", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool InPlane
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QQEC8BiApQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QQEC8BiApQ = value;
		}
	}

	public CvsCogRect3D Rect3D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Shape as CvsCogRect3D;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogEditingRectangle3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lXnN8VwQGk1CZqGX0DK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JrEjEUwW5LTKCruOn1a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
