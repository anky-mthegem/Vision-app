using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "SubRegion")]
public class CvsCogSubRegion : CvsCogShape
{
	[CompilerGenerated]
	private bool mYBBTwCt11;

	[CompilerGenerated]
	private CvsCogShape owQBvR0TtG;

	[JsonProperty(PropertyName = "add", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool Add
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mYBBTwCt11;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mYBBTwCt11 = value;
		}
	}

	[JsonProperty(PropertyName = "shape", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CvsCogShape Shape
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return owQBvR0TtG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			owQBvR0TtG = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSubRegion()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tT1Jg1cUSINc28wJK6c();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSubRegion(bool add, CvsCogShape shape)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!kLFSHMcf6xnvqwVhoqI())
		{
			num = 1;
		}
		else
		{
			num = 5;
			if (kLFSHMcf6xnvqwVhoqI())
			{
				goto IL_0094;
			}
		}
		goto IL_005d;
		IL_005d:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				tT1Jg1cUSINc28wJK6c();
				num = 4;
				continue;
			default:
				Shape = shape;
				num = 6;
				continue;
			case 2:
				Add = add;
				goto default;
			case 4:
				break;
			case 6:
				return;
			}
			break;
		}
		goto IL_0094;
		IL_0094:
		base._002Ector();
		num = 2;
		if (!fFbjDCcDywSMsIwDwKG())
		{
			return;
		}
		goto IL_005d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tT1Jg1cUSINc28wJK6c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fFbjDCcDywSMsIwDwKG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kLFSHMcf6xnvqwVhoqI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
