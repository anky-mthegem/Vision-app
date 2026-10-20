using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.ViDiEL.Read;

[CvsSerializable("ELReadCharacterLabel")]
public class ELReadCharacterLabel
{
	[CompilerGenerated]
	private double ifvQ6Q6LbG;

	[CompilerGenerated]
	private double JeTQpK9QG3;

	[CompilerGenerated]
	private string U8YQ3rk2cE;

	[CompilerGenerated]
	private double? K60Q9qNvk0;

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
			return ifvQ6Q6LbG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ifvQ6Q6LbG = value;
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
			return JeTQpK9QG3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JeTQpK9QG3 = value;
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
			return U8YQ3rk2cE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U8YQ3rk2cE = value;
		}
	}

	[JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
	public double? LabelConfidence
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return K60Q9qNvk0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			K60Q9qNvk0 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ELReadCharacterLabel FromCharacterResult(ELReadCharacterResult charResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ELReadCharacterLabel eLReadCharacterLabel = new ELReadCharacterLabel();
		q0mMsmud6LkgcyiZhHY(eLReadCharacterLabel, charResult.CenterX);
		mypPymukYlQUE7f8HFR(eLReadCharacterLabel, charResult.CenterY);
		amuD8guMMQ43c82pxyL(eLReadCharacterLabel, charResult.Character);
		return eLReadCharacterLabel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ELReadCharacterLabel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BR4YS9u2Xo6bDn4I5Hw();
		gEmsSBuLHaLIy2m5Zvd(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fGcdSwuGDCApOkVx0wY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hffZtZunsH6wrewF4ib()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q0mMsmud6LkgcyiZhHY(object P_0, double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ELReadCharacterLabel)P_0).CenterX = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mypPymukYlQUE7f8HFR(object P_0, double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ELReadCharacterLabel)P_0).CenterY = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void amuD8guMMQ43c82pxyL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ELReadCharacterLabel)P_0).Character = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BR4YS9u2Xo6bDn4I5Hw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gEmsSBuLHaLIy2m5Zvd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
