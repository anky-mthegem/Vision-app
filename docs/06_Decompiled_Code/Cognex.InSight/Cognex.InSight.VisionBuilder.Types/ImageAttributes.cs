using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder.Types;

public class ImageAttributes
{
	[CompilerGenerated]
	private string WbxpVDMTcN;

	[CompilerGenerated]
	private string zM7pvKytg3;

	[CompilerGenerated]
	private string fiKpZG8mox;

	[CompilerGenerated]
	private string j04p8B2nYM;

	[JsonProperty("imageId")]
	public string ImageId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WbxpVDMTcN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WbxpVDMTcN = value;
		}
	}

	[JsonProperty("timestamp")]
	public string Timestamp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zM7pvKytg3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zM7pvKytg3 = value;
		}
	}

	[JsonProperty("cameraName")]
	public string CameraName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fiKpZG8mox;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fiKpZG8mox = value;
		}
	}

	[JsonProperty("serialNumber")]
	public string SerialNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return j04p8B2nYM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			j04p8B2nYM = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageAttributes(ImageMetadata metadata)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				ImageId = (string)rWbkThcSMimYe2TXAsf(metadata);
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				ViuMP2c9neK93rBLj5Y(this);
				_ = 1;
				num = (DDAacuchJ5WqUiKTPBW() ? 6 : 3);
				continue;
			default:
				CameraName = (string)KuNX0XcvPu66EBNbGXY(metadata);
				num = 0;
				continue;
			case 7:
				OJuvZtcL88qXneabySK();
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			case 0:
				break;
			case 5:
				Timestamp = (string)pkpV0fcEaF1mHdGWKBu(metadata);
				goto default;
			case 8:
				return;
			}
			SerialNumber = (string)WNIVr5cHDCGhgeVpF4x(metadata);
			num = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OJuvZtcL88qXneabySK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViuMP2c9neK93rBLj5Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rWbkThcSMimYe2TXAsf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageMetadata)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pkpV0fcEaF1mHdGWKBu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageMetadata)P_0).Timestamp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KuNX0XcvPu66EBNbGXY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageMetadata)P_0).CameraName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WNIVr5cHDCGhgeVpF4x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageMetadata)P_0).SerialNumber;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eHMsfPcsYdk4hgtj30i()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DDAacuchJ5WqUiKTPBW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
