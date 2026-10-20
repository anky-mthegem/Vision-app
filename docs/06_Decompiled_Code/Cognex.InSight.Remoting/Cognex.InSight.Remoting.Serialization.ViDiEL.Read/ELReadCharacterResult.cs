using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.ViDiEL.Read;

[CvsSerializable("ELReadCharacterResult")]
public class ELReadCharacterResult
{
	[CompilerGenerated]
	private double f6kQLhfEUs;

	[CompilerGenerated]
	private double bBVQVryUjJ;

	[CompilerGenerated]
	private string Y2GQOtypyF;

	[CompilerGenerated]
	private double ngoQtdhCWt;

	[JsonProperty("centerX")]
	public double CenterX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f6kQLhfEUs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			f6kQLhfEUs = value;
		}
	}

	[JsonProperty("centerY")]
	public double CenterY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bBVQVryUjJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bBVQVryUjJ = value;
		}
	}

	[JsonProperty("character")]
	public string Character
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Y2GQOtypyF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Y2GQOtypyF = value;
		}
	}

	[JsonProperty("score")]
	public double Score
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ngoQtdhCWt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ngoQtdhCWt = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ELReadCharacterLabel ToCharacterLabel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ELReadCharacterLabel eLReadCharacterLabel = new ELReadCharacterLabel();
		ARUSCOu7VIP9cA2kbCK(eLReadCharacterLabel, CenterX);
		P8HT3VuXvOa2e5jwATy(eLReadCharacterLabel, CenterY);
		TlM8NVulfuY7eSrZRQu(eLReadCharacterLabel, Character);
		return eLReadCharacterLabel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ELReadCharacterResult()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xNaIesuSsabKFsYBl0G()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Y3FIZSuYKNTssCwmGxJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ARUSCOu7VIP9cA2kbCK(object P_0, double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ELReadCharacterLabel)P_0).CenterX = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P8HT3VuXvOa2e5jwATy(object P_0, double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ELReadCharacterLabel)P_0).CenterY = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TlM8NVulfuY7eSrZRQu(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ELReadCharacterLabel)P_0).Character = (string)P_1;
	}
}
