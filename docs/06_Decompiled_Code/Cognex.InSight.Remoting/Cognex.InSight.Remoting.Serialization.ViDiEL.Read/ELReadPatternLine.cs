using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.ViDiEL.Read;

[CvsSerializable("ELReadPatternLine")]
public class ELReadPatternLine
{
	[CompilerGenerated]
	private List<ELReadFieldingCharacterClass> bhqQgEVnZ7;

	[JsonProperty("characters")]
	public List<ELReadFieldingCharacterClass> Characters
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bhqQgEVnZ7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bhqQgEVnZ7 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ELReadPatternLine()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		e6NfkEHWE4gamniqlDw();
		int num;
		if (!T2qoVgHCZ8DT5rofXBS())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_008d;
			}
		}
		goto IL_0045;
		IL_0045:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				bhqQgEVnZ7 = new List<ELReadFieldingCharacterClass>();
				break;
			default:
				num = 4;
				if (T2qoVgHCZ8DT5rofXBS())
				{
				}
				continue;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				goto case 1;
			case 4:
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_008d;
		IL_008d:
		N2nxjTH6ewYUkBVXbsT(this);
		num = 5;
		if (false)
		{
			return;
		}
		goto IL_0045;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N2nxjTH6ewYUkBVXbsT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e6NfkEHWE4gamniqlDw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T2qoVgHCZ8DT5rofXBS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
