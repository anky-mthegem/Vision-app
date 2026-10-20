using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "PointList")]
public class CvsCogPointList : CvsCogShape
{
	[CompilerGenerated]
	private double[] kChB41pYXk;

	[JsonProperty(PropertyName = "points", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Points
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kChB41pYXk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kChB41pYXk = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPointList()
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
			case 1:
			case 4:
				base._002Ector();
				break;
			case 0:
				do
				{
					Dd3lDJIDhh1dxr4MFW2();
					_ = 0;
					if (!XAceCkItAkoaKjfFDjo())
					{
						num = 3;
						continue;
					}
					num = 4;
					break;
				}
				while (!XAceCkItAkoaKjfFDjo());
				continue;
			case 5:
				return;
			}
			Points = new double[0];
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPointList(IEnumerable<double> points)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
		Points = new List<double>(points).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Dd3lDJIDhh1dxr4MFW2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XAceCkItAkoaKjfFDjo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xyo4S8IarEvGXKWtf9c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
