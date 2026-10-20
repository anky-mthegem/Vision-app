using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "WhiteBalanceSettings")]
public class CvsCogWhiteBalanceSettings
{
	public const string BaseName = "whiteBalance";

	public const string ConnectedName = "connected";

	public const string RegionName = "region";

	public const string RedName = "red";

	public const string GreenName = "green";

	public const string BlueName = "blue";

	public const string RedRangeName = "redRange";

	public const string GreenRangeName = "greenRange";

	public const string BlueRangeName = "blueRange";

	public const string RegionBoundsName = "regionBounds";

	[CompilerGenerated]
	private double ItUFYXTEv4;

	[JsonProperty(PropertyName = "redRange")]
	public double[] RedRange;

	[CompilerGenerated]
	private double cn1F5CCf43;

	[JsonProperty(PropertyName = "greenRange")]
	public double[] GreenRange;

	[CompilerGenerated]
	private double MJuFBe1PI2;

	[JsonProperty(PropertyName = "blueRange")]
	public double[] BlueRange;

	private bool w6vFyHgKkY;

	private CvsCogRegion kOiFMBbol5;

	private bool JpbFI7nv7d;

	private CvsCogRegion QBPFr6bM2M;

	[JsonProperty(PropertyName = "red")]
	public double Red
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ItUFYXTEv4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ItUFYXTEv4 = value;
		}
	}

	public InclusiveRange<double> RedInclusiveRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new InclusiveRange<double>(RedRange[0], RedRange[1]);
		}
	}

	[JsonProperty(PropertyName = "green")]
	public double Green
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cn1F5CCf43;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cn1F5CCf43 = value;
		}
	}

	public InclusiveRange<double> GreenInclusiveRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new InclusiveRange<double>(GreenRange[0], GreenRange[1]);
		}
	}

	[JsonProperty(PropertyName = "blue")]
	public double Blue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MJuFBe1PI2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MJuFBe1PI2 = value;
		}
	}

	public InclusiveRange<double> BlueInclusiveRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new InclusiveRange<double>(BlueRange[0], BlueRange[1]);
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
			if (w6vFyHgKkY)
			{
				return kOiFMBbol5 != null;
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
			return kOiFMBbol5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kOiFMBbol5 = value;
			w6vFyHgKkY = true;
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
			if (JpbFI7nv7d)
			{
				return QBPFr6bM2M != null;
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
			return QBPFr6bM2M;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QBPFr6bM2M = value;
			JpbFI7nv7d = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Verify(double rgbGain)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (1.0 <= rgbGain)
		{
			return rgbGain <= 255.0;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Verify(CvsCogRegion region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Verify(LOuijk4FZKgj9uX2Byh(region), region.Y, region.Width, wCsO0k4GsXbl5iMiipn(region));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Verify(double regionX, double regionY, double regionWidth, double regionHeight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (VW0pSM4TmUv5PjtvjN5())
		{
			num = 5;
			if (KS18Ex4oJAbEDdxSggQ())
			{
			}
		}
		else
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				if (regionX <= LOuijk4FZKgj9uX2Byh(QBPFr6bM2M) + yJLvQs4nbGgjjIW2wUh(QBPFr6bM2M))
				{
					num = 4;
					continue;
				}
				break;
			case 4:
				if (!(regionY >= QBPFr6bM2M.Y))
				{
					break;
				}
				goto case 7;
			default:
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				if (!(regionX >= LOuijk4FZKgj9uX2Byh(QBPFr6bM2M)))
				{
					break;
				}
				goto case 2;
			case 6:
				if (!(regionX + regionWidth <= LOuijk4FZKgj9uX2Byh(QBPFr6bM2M) + yJLvQs4nbGgjjIW2wUh(QBPFr6bM2M)))
				{
					break;
				}
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				if (QBPFr6bM2M != null)
				{
					num = 1;
					continue;
				}
				break;
			case 7:
				if (regionY <= FRyP764dMtedWghXrtP(QBPFr6bM2M) + QBPFr6bM2M.Height)
				{
					num = 6;
					continue;
				}
				break;
			case 8:
				return regionY + regionHeight <= FRyP764dMtedWghXrtP(QBPFr6bM2M) + wCsO0k4GsXbl5iMiipn(QBPFr6bM2M);
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogWhiteBalanceSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		while (true)
		{
			switch (num)
			{
			case 0:
				BlueRange = new double[2] { 1.0, 255.0 };
				num = 6;
				if (!KS18Ex4oJAbEDdxSggQ())
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				RedRange = new double[2] { 1.0, 255.0 };
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 7:
				ItUFYXTEv4 = 1.0;
				goto case 2;
			case 9:
				EkHByM4kaICUTJUvHVs();
				_ = 0;
				if (!VW0pSM4TmUv5PjtvjN5())
				{
					num = 5;
					if (KS18Ex4oJAbEDdxSggQ())
					{
					}
				}
				else
				{
					num = 7;
				}
				break;
			case 3:
				cn1F5CCf43 = 1.0;
				num = 8;
				if (VW0pSM4TmUv5PjtvjN5())
				{
					break;
				}
				goto case 4;
			case 4:
				MJuFBe1PI2 = 1.0;
				num = 0;
				if (VW0pSM4TmUv5PjtvjN5())
				{
					break;
				}
				goto case 8;
			case 8:
				GreenRange = new double[2] { 1.0, 255.0 };
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				BfIbdq4MlJJqkxKpYFH(this);
				num = 10;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VW0pSM4TmUv5PjtvjN5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KS18Ex4oJAbEDdxSggQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double LOuijk4FZKgj9uX2Byh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wCsO0k4GsXbl5iMiipn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double yJLvQs4nbGgjjIW2wUh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double FRyP764dMtedWghXrtP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EkHByM4kaICUTJUvHVs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BfIbdq4MlJJqkxKpYFH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
