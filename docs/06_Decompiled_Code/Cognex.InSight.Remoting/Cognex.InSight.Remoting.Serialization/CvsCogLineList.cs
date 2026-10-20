using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "LineList")]
public class CvsCogLineList : CvsCogShape
{
	[CompilerGenerated]
	private double[] BxQBUVfY5U;

	[JsonProperty(PropertyName = "lines", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Lines
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BxQBUVfY5U;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BxQBUVfY5U = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLineList()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 4:
				VdHJfNIWcTe6CH3pUbd();
				ujZH7ePzuND92HrWKFF();
				num = ((!xhZfOdIQ2fUaF9yTGqb()) ? 3 : 0);
				continue;
			case 1:
			case 3:
				base._002Ector();
				break;
			case 5:
				return;
			}
			Lines = new double[0];
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLineList(IEnumerable<double> lines)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
		Lines = new List<double>(lines).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VdHJfNIWcTe6CH3pUbd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ujZH7ePzuND92HrWKFF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xhZfOdIQ2fUaF9yTGqb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
