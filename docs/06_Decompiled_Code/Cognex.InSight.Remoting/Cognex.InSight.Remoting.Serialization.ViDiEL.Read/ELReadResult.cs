using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.ViDiEL.Read;

[CvsSerializable("ELReadResult")]
public class ELReadResult
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ELReadCharacterResult, ELReadCharacterLabel> _003C_003E9__21_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AkKYW4tpaGVyNAZn7YE();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AkKYW4tpaGVyNAZn7YE();
			s7MGVwtyJdrujhdoOm6(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ELReadCharacterLabel _003Cget_CharacterLabels_003Eb__21_0(ELReadCharacterResult c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (ELReadCharacterLabel)Q6oCHutKwupvfNq8wai(c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AkKYW4tpaGVyNAZn7YE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GRLxgXtEefQMRidBLmw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Stk3uRtx07W0PwhsLGU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void s7MGVwtyJdrujhdoOm6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q6oCHutKwupvfNq8wai(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadCharacterResult)P_0).ToCharacterLabel();
		}
	}

	[CompilerGenerated]
	private double YjbQSaYUgM;

	[CompilerGenerated]
	private double kn8QnX2XO7;

	[CompilerGenerated]
	private List<ELReadCharacterResult> SAMQ1K3TD6;

	[CompilerGenerated]
	private ELReadFieldingResult cJbQkVqfOs;

	[CompilerGenerated]
	private string DIPQEcJAXT;

	[JsonProperty("characterHeight")]
	public double CharacterHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YjbQSaYUgM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YjbQSaYUgM = value;
		}
	}

	[JsonProperty("characterWidth")]
	public double CharacterWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kn8QnX2XO7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kn8QnX2XO7 = value;
		}
	}

	[JsonProperty("characters")]
	public List<ELReadCharacterResult> Characters
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SAMQ1K3TD6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SAMQ1K3TD6 = value;
		}
	}

	[JsonProperty("fielding", NullValueHandling = NullValueHandling.Ignore)]
	public ELReadFieldingResult FieldingResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cJbQkVqfOs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cJbQkVqfOs = value;
		}
	}

	[JsonProperty("string")]
	public string String
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DIPQEcJAXT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DIPQEcJAXT = value;
		}
	}

	[JsonIgnore]
	public IEnumerable<ELReadCharacterLabel> CharacterLabels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Characters.Select([MethodImpl(MethodImplOptions.NoInlining)] (ELReadCharacterResult c) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (ELReadCharacterLabel)_003C_003Ec.Q6oCHutKwupvfNq8wai(c);
			});
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ELReadResult()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EMorORHwTEIpseoO7r6();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QooMxvH4T7sTfbH3LRr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mUvas9HsdkSF3dtsGwt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EMorORHwTEIpseoO7r6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
