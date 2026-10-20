using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Cylinder3D")]
public class CvsCogCylinder3D : CvsCogRoundShape
{
	[CompilerGenerated]
	private double mwu58Rksys;

	[JsonProperty(PropertyName = "height", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mwu58Rksys;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mwu58Rksys = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogCylinder3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		aeJdgTPd2cVaIrwlvoJ();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogCylinder3D(double[] modelMatrix, double height, double radius, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (zoiNxyPGmNjP6wJt480() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 4:
				base._002Ector(modelMatrix, radius, color, cellLocation);
				goto default;
			default:
				Height = height;
				num = 5;
				break;
			case 0:
			case 1:
				aeJdgTPd2cVaIrwlvoJ();
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aeJdgTPd2cVaIrwlvoJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zoiNxyPGmNjP6wJt480()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mVL67VPnbg4VmBt4t3u()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
