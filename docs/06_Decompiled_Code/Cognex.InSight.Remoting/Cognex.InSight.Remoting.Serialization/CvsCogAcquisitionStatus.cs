using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "AcquisitionStatus")]
public class CvsCogAcquisitionStatus
{
	private double gRIUF8fCTO;

	private int y3RUCQHE3Z;

	private int DPxUYU939K;

	[JsonProperty(PropertyName = "currentImageId")]
	public double CurrentImageID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gRIUF8fCTO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gRIUF8fCTO = value;
		}
	}

	[JsonProperty(PropertyName = "imagesAvailable")]
	public int ImagesAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return y3RUCQHE3Z;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			y3RUCQHE3Z = value;
		}
	}

	[JsonProperty(PropertyName = "imagesUsed")]
	public int ImagesUsed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DPxUYU939K;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DPxUYU939K = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAcquisitionStatus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 1:
				mFRFNAWigX64LGFuNFl();
				num = 5;
				continue;
			case 3:
				DPxUYU939K = -1;
				break;
			case 2:
			case 6:
				y3RUCQHE3Z = -1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 5:
				gRIUF8fCTO = double.NaN;
				YcctFjWcvD5KJRkufg7();
				if (tmINYDWqbndS1RtKVSx())
				{
					num = 0;
					continue;
				}
				num = 6;
				if (!tmINYDWqbndS1RtKVSx())
				{
					continue;
				}
				break;
			case 0:
			case 4:
				break;
			case 7:
				return;
			}
			WsJaElWhRkmGR6DMuWd(this);
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YcctFjWcvD5KJRkufg7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tmINYDWqbndS1RtKVSx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mFRFNAWigX64LGFuNFl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WsJaElWhRkmGR6DMuWd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
