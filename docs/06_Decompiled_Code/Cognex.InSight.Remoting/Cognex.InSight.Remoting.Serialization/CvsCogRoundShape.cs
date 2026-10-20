using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
public class CvsCogRoundShape : CvsCogShape3D
{
	[CompilerGenerated]
	private double fa5B1bjKDf;

	[JsonProperty(PropertyName = "radius", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Radius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fa5B1bjKDf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fa5B1bjKDf = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRoundShape()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JTSsoYIz6rcp1126AmS();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRoundShape(double[] modelMatrix, double radius, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fYIGF6I3fUgsRgOuLjm();
		int num = (WDjcbFIeTh1MbFTYCCx() ? 6 : 7);
		while (true)
		{
			switch (num)
			{
			case 3:
				CellLocation = cellLocation;
				num = 8;
				continue;
			case 0:
			case 7:
				JTSsoYIz6rcp1126AmS();
				break;
			case 4:
				ModelMatrix = modelMatrix;
				num = 5;
				if (fYIGF6I3fUgsRgOuLjm())
				{
					continue;
				}
				goto case 2;
			case 2:
				Color = color;
				num = 3;
				continue;
			case 5:
				Radius = radius;
				goto case 2;
			default:
				num = 2;
				continue;
			case 1:
			case 6:
				break;
			case 8:
				return;
			}
			base._002Ector();
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JTSsoYIz6rcp1126AmS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fYIGF6I3fUgsRgOuLjm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WDjcbFIeTh1MbFTYCCx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
