using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "cameraInfo")]
public class CvsCogCameraInfo
{
	[CompilerGenerated]
	private string F7nUryRaJG;

	[CompilerGenerated]
	private string KW5UQ289D7;

	[CompilerGenerated]
	private int P2xUmqeUkh;

	[CompilerGenerated]
	private string amNUN6daGH;

	[CompilerGenerated]
	private string YqMUfWwSRn;

	[JsonProperty(PropertyName = "cameraName")]
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
			return F7nUryRaJG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			F7nUryRaJG = value;
		}
	}

	[JsonProperty(PropertyName = "model")]
	public string CameraModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KW5UQ289D7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KW5UQ289D7 = value;
		}
	}

	[JsonProperty(PropertyName = "cameraPort")]
	public int CameraPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P2xUmqeUkh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P2xUmqeUkh = value;
		}
	}

	[JsonProperty(PropertyName = "cameraDisplayName")]
	public string CameraDisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return amNUN6daGH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			amNUN6daGH = value;
		}
	}

	[JsonProperty(PropertyName = "productFamily")]
	public string CameraProductFamily
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YqMUfWwSRn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YqMUfWwSRn = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[JsonConstructor]
	public CvsCogCameraInfo(string cameraName, string cameraDisplayName, string cameraModel, int cameraPort, string cameraProductFamily = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!NGqgCsWfCRJH0qhBSIO())
		{
			goto IL_001e;
		}
		goto IL_0037;
		IL_001e:
		CameraDisplayName = cameraDisplayName;
		goto IL_0099;
		IL_0037:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				break;
			default:
				num = 5;
				if (NGqgCsWfCRJH0qhBSIO())
				{
					continue;
				}
				goto case 6;
			case 6:
				CameraName = cameraName;
				break;
			case 0:
				CameraPort = cameraPort;
				num = 8;
				continue;
			case 5:
				goto IL_0099;
			case 2:
				goto IL_00aa;
			case 1:
			case 7:
				deoTiSWVBtDn6EK8poB(this);
				num = 6;
				continue;
			case 8:
				CameraProductFamily = (SaXZv6WR7KAyjVAKv5j(cameraProductFamily) ? cameraModel : cameraProductFamily);
				return;
			}
			break;
			IL_00aa:
			oWiYNSWrA0jHDHiebqx();
			_ = 1;
			num = ((!GfpwiiWU7tehtYGrk6X()) ? 7 : 4);
		}
		goto IL_001e;
		IL_0099:
		CameraModel = cameraModel;
		num = 0;
		goto IL_0037;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NGqgCsWfCRJH0qhBSIO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GfpwiiWU7tehtYGrk6X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oWiYNSWrA0jHDHiebqx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void deoTiSWVBtDn6EK8poB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SaXZv6WR7KAyjVAKv5j(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}
}
