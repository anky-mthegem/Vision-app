using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "IlluminationSettings")]
public class CvsCogIlluminationSettings
{
	public const string ModeName = "mode";

	public const string BankEnablesName = "bankEnables";

	public const string IntensityName = "intensity";

	public const string AlwaysOnName = "alwaysOn";

	public const string LightColorName = "lightColor";

	private Dictionary<string, string> i9EbQALqYy;

	private bool VX2bmTZ1IZ;

	private int AFdbNAs9r9;

	private int[] IsubfaMLJ8;

	private bool wJob4ZC0h0;

	private int dqBb2uTJqj;

	private double[] OpNbX4guWI;

	private bool BuZbqkS87N;

	private double R87bJASFQn;

	private Dictionary<string, string> Tg8bKrltnJ;

	private bool fnebR9bWRY;

	private int hvnbadXNLf;

	private Dictionary<string, string> IEPbxf8wEL;

	private bool Bqrb6XmtoW;

	private int UDvbpCW0N1;

	[JsonProperty(PropertyName = "modeValues")]
	public Dictionary<string, string> ModeValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return i9EbQALqYy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			i9EbQALqYy = value;
		}
	}

	public bool IsModeSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (VX2bmTZ1IZ)
			{
				return ModeValues != null;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "mode")]
	public int Mode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AFdbNAs9r9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AFdbNAs9r9 = value;
			VX2bmTZ1IZ = true;
		}
	}

	[JsonProperty(PropertyName = "bankEnablesRange")]
	public int[] BankEnablesRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IsubfaMLJ8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IsubfaMLJ8 = value;
		}
	}

	public bool IsBankEnablesSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (wJob4ZC0h0 && BankEnablesRange != null)
			{
				return BankEnablesRange.Length > 1;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "bankEnables")]
	public int BankEnables
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dqBb2uTJqj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dqBb2uTJqj = value;
			wJob4ZC0h0 = true;
		}
	}

	[JsonProperty(PropertyName = "intensityRange")]
	public double[] IntensityRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OpNbX4guWI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OpNbX4guWI = value;
		}
	}

	public bool IsIntensitySupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (BuZbqkS87N && IntensityRange != null)
			{
				return IntensityRange.Length > 1;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "intensity")]
	public double Intensity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return R87bJASFQn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			R87bJASFQn = value;
			BuZbqkS87N = true;
		}
	}

	[JsonProperty(PropertyName = "alwaysOnValues")]
	public Dictionary<string, string> AlwaysOnValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Tg8bKrltnJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Tg8bKrltnJ = value;
		}
	}

	public bool IsAlwaysOnSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (fnebR9bWRY)
			{
				return AlwaysOnValues != null;
			}
			return false;
		}
	}

	[JsonConverter(typeof(IntegerMaybeBooleanConverter))]
	[JsonProperty(PropertyName = "alwaysOn")]
	public int AlwaysOn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hvnbadXNLf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hvnbadXNLf = value;
			fnebR9bWRY = true;
		}
	}

	[JsonProperty(PropertyName = "lightColorValues")]
	public Dictionary<string, string> LightColorValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IEPbxf8wEL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IEPbxf8wEL = value;
		}
	}

	public bool IsLightColorSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Bqrb6XmtoW)
			{
				return LightColorValues != null;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "lightColor")]
	public int LightColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UDvbpCW0N1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UDvbpCW0N1 = value;
			Bqrb6XmtoW = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogIlluminationSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UH6akk6wMsRNf2r7K6v();
		iQfRLe6PFkhfD7Gif4X(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hiHS9l64e3D8uMNCUj9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Nth0VC6ssIIeBWca7eO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UH6akk6wMsRNf2r7K6v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iQfRLe6PFkhfD7Gif4X(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
