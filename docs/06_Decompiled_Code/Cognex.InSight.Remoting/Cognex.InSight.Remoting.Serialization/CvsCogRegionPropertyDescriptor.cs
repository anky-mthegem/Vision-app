using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "RegionPropertyDescriptor")]
public class CvsCogRegionPropertyDescriptor : CvsCogPropertyDescriptor
{
	[CompilerGenerated]
	private CvsCogRegion EyfrUMiOuf;

	[JsonProperty(PropertyName = "bounds")]
	public CvsCogRegion Bounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EyfrUMiOuf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EyfrUMiOuf = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRegionPropertyDescriptor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!iMSg4oiimxWsedID2W2())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_006e;
		IL_0051:
		EyfrUMiOuf = new CvsCogRegion();
		goto IL_003b;
		IL_006e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 3:
				goto IL_003b;
			case 1:
			case 4:
				goto IL_0051;
			default:
				num = 3;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		goto IL_0051;
		IL_003b:
		base._002Ector();
		num = 5;
		if (iMSg4oiimxWsedID2W2())
		{
			goto IL_0051;
		}
		goto IL_006e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool n4cEejiqKovsXK6gGAw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iMSg4oiimxWsedID2W2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
