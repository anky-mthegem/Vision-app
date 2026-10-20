using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "FocusSettings")]
public class CvsCogFocusSettings
{
	public const string PositionName = "position";

	public const string DistanceName = "distance";

	public const string RegionName = "region";

	public const string RegionBoundsName = "regionBounds";

	private bool H13lusYfPw;

	private double Yt6lZXwAeH;

	private double[] OQrlgyT5mJ;

	private double cgnlSU4PLX;

	private double[] Vt0ln3lgmr;

	private bool veXl1bBDCu;

	private CvsCogRegion XItlkDsSyf;

	private bool kEKlE4aJsV;

	private CvsCogRegion EMqlsinvv3;

	public bool IsPositionSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (H13lusYfPw)
			{
				return PositionRange[0] != PositionRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "position")]
	public double Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Yt6lZXwAeH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Yt6lZXwAeH = value;
			H13lusYfPw = true;
		}
	}

	[JsonProperty(PropertyName = "positionRange")]
	public double[] PositionRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OQrlgyT5mJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OQrlgyT5mJ = value;
		}
	}

	[JsonProperty(PropertyName = "distance")]
	public double DistanceMm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cgnlSU4PLX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cgnlSU4PLX = value;
			H13lusYfPw = true;
		}
	}

	[JsonProperty(PropertyName = "distanceRange")]
	public double[] DistanceRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Vt0ln3lgmr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Vt0ln3lgmr = value;
		}
	}

	public bool IsRegionSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (veXl1bBDCu)
			{
				return XItlkDsSyf != null;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "region")]
	public CvsCogRegion Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XItlkDsSyf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XItlkDsSyf = value;
			veXl1bBDCu = true;
		}
	}

	public bool IsRegionBoundsSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (kEKlE4aJsV)
			{
				return EMqlsinvv3 != null;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "regionBounds")]
	public CvsCogRegion RegionBounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EMqlsinvv3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EMqlsinvv3 = value;
			kEKlE4aJsV = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Verify(double regionX, double regionY, double regionWidth, double regionHeight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (regionY <= EMqlsinvv3.Y + EMqlsinvv3.Height)
				{
					num = 5;
					continue;
				}
				break;
			case 2:
				if (EMqlsinvv3 != null)
				{
					cC7jvVCYSXf7Zv5wEij();
					num = ((!G1ugLjCS1n61X34jDrY()) ? 7 : 6);
					continue;
				}
				break;
			case 3:
			case 7:
				if (!(regionY >= EMqlsinvv3.Y))
				{
					break;
				}
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
				if (!(regionX <= wOI9TbC7T8B0NnUBMsA(EMqlsinvv3) + MTdb38CXBpAvPojbtIN(EMqlsinvv3)))
				{
					break;
				}
				goto case 3;
			case 5:
				if (regionX + regionWidth <= wOI9TbC7T8B0NnUBMsA(EMqlsinvv3) + EMqlsinvv3.Width)
				{
					num = 8;
					continue;
				}
				break;
			case 1:
			case 6:
				if (!(regionX >= wOI9TbC7T8B0NnUBMsA(EMqlsinvv3)))
				{
					break;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				return regionY + regionHeight <= oDowwsCl6nV1BFjh5rY(EMqlsinvv3) + dJ5IGpCOZvcyTR7csEo(EMqlsinvv3);
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogFocusSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!G1ugLjCS1n61X34jDrY())
		{
			goto IL_001e;
		}
		goto IL_003f;
		IL_00e6:
		Vt0ln3lgmr = new double[2]
		{
			0.0,
			double.MaxValue
		};
		goto IL_0094;
		IL_003f:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 0;
				continue;
			case 1:
			case 2:
				OQrlgyT5mJ = new double[2]
				{
					0.0,
					double.MaxValue
				};
				num = 3;
				continue;
			case 5:
			case 6:
				goto IL_0094;
			case 7:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				num = 4;
				continue;
			case 4:
				goto IL_00b3;
			case 0:
				goto IL_00e6;
			case 8:
				return;
			}
			break;
			IL_00b3:
			Yt6lZXwAeH = 41.6;
			cC7jvVCYSXf7Zv5wEij();
			if (G1ugLjCS1n61X34jDrY())
			{
				num = 1;
				if (cC7jvVCYSXf7Zv5wEij())
				{
				}
			}
			else
			{
				num = 6;
				if (!G1ugLjCS1n61X34jDrY())
				{
					return;
				}
			}
		}
		goto IL_001e;
		IL_0094:
		IZ65K3Cb6WjVm3JAJVU(this);
		num = 8;
		goto IL_003f;
		IL_001e:
		cgnlSU4PLX = 250.0;
		goto IL_00e6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool G1ugLjCS1n61X34jDrY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cC7jvVCYSXf7Zv5wEij()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wOI9TbC7T8B0NnUBMsA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double MTdb38CXBpAvPojbtIN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double oDowwsCl6nV1BFjh5rY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double dJ5IGpCOZvcyTR7csEo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IZ65K3Cb6WjVm3JAJVU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
