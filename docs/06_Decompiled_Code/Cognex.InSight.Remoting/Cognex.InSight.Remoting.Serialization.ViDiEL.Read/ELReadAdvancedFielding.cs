using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.ViDiEL.Read;

[CvsSerializable("ELReadAdvancedFielding")]
public class ELReadAdvancedFielding
{
	[CompilerGenerated]
	private Dictionary<string, ELReadPattern> FZOQR2nbrN;

	[JsonProperty("patterns")]
	public Dictionary<string, ELReadPattern> Patterns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FZOQR2nbrN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FZOQR2nbrN = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ELReadAdvancedFielding()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fy4VgCuxCX0KXm8U3JA();
		int num = (cEuxu1upcLCD1v5DISK() ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				FZOQR2nbrN = new Dictionary<string, ELReadPattern>();
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				break;
			case 4:
				break;
			case 0:
			case 2:
				hZBb1RuyClhR7P9tgtU();
				goto case 1;
			case 5:
				return;
			}
			RnlFituK8QmWmEI47qX(this);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hZBb1RuyClhR7P9tgtU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RnlFituK8QmWmEI47qX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fy4VgCuxCX0KXm8U3JA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cEuxu1upcLCD1v5DISK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
