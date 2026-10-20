using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "EasyBuilderLicense")]
public class CvsCogEasyBuilderLicense
{
	[CompilerGenerated]
	private string eyXlfD7x1b;

	[CompilerGenerated]
	private Guid bDJl4ZjEEa;

	[JsonProperty(PropertyName = "guid", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string GuidStr
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eyXlfD7x1b;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eyXlfD7x1b = value;
		}
	}

	public Guid License
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bDJl4ZjEEa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bDJl4ZjEEa = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[JsonConstructor]
	public CvsCogEasyBuilderLicense(string guidStr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!sUNE2HCqwRcr8A6xEm2())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0083;
		IL_0026:
		License = (fNKbomCuKXUwUHsHMMC(guidStr) ? Guid.Empty : new Guid(guidStr));
		GuidStr = License.ToString();
		num = 5;
		goto IL_0083;
		IL_0083:
		while (true)
		{
			switch (num)
			{
			case 3:
				AhN4AlCh4Riherv6rU7(this);
				break;
			case 0:
			case 4:
				goto IL_00b0;
			case 5:
				return;
			}
			break;
			IL_00b0:
			wL2WXoCivMwhV4ToGjQ();
			num = 3;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gd4UyrCcqHhYalbD1iO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sUNE2HCqwRcr8A6xEm2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wL2WXoCivMwhV4ToGjQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AhN4AlCh4Riherv6rU7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fNKbomCuKXUwUHsHMMC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}
}
