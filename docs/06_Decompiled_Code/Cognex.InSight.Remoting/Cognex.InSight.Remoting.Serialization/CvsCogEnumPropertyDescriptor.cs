using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "EnumPropertyDescriptor")]
public class CvsCogEnumPropertyDescriptor : CvsCogPropertyDescriptor
{
	[CompilerGenerated]
	private IEnumerable<CvsCogEnumPropertyValueDescriptor> LY3ISUBprk;

	[JsonProperty(PropertyName = "values")]
	public IEnumerable<CvsCogEnumPropertyValueDescriptor> Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LY3ISUBprk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LY3ISUBprk = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogEnumPropertyDescriptor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SPryfRq3RusyijBbp2R();
		int num = ((!zUR52aqvTRdZ9PA9PUr()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 2:
				base._002Ector();
				num = 5;
				continue;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				goto case 1;
			case 1:
			case 3:
				LY3ISUBprk = new List<CvsCogEnumPropertyValueDescriptor>();
				goto case 2;
			case 5:
				return;
			}
			num = 2;
			if (1 == 0)
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zUR52aqvTRdZ9PA9PUr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SPryfRq3RusyijBbp2R()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
