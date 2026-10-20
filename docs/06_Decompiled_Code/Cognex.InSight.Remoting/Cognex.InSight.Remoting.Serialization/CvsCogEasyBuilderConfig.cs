using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "EasyBuilderConfig")]
public class CvsCogEasyBuilderConfig
{
	[CompilerGenerated]
	private CvsCogEasyBuilderLicense[] hTil2NOpU8;

	[CompilerGenerated]
	private CvsCogEasyBuilderLayout[] oUylXtXmRT;

	[JsonProperty(PropertyName = "allowedTools", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CvsCogEasyBuilderLicense[] AllowedLicenses
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hTil2NOpU8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hTil2NOpU8 = value;
		}
	}

	[JsonProperty(PropertyName = "layouts", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CvsCogEasyBuilderLayout[] Layouts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oUylXtXmRT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oUylXtXmRT = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogEasyBuilderConfig(CvsCogEasyBuilderLicense[] licenses, CvsCogEasyBuilderLayout[] layouts)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LI255LCaReEDhL0oVMM();
		int num = ((!PfITWpCtd1oaCUBpF6Z()) ? 2 : 8);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (Layouts != null)
				{
					num = 4;
					break;
				}
				goto case 7;
			case 0:
			case 8:
				fSciOUCD4LWebLEJ8d5();
				goto case 1;
			case 3:
				AllowedLicenses = licenses;
				num = 6;
				if (!LI255LCaReEDhL0oVMM())
				{
					break;
				}
				goto case 4;
			case 4:
				if (Layouts.Length == 0)
				{
					num = 7;
					break;
				}
				return;
			case 6:
				Layouts = layouts;
				goto case 5;
			default:
				num = 5;
				if (!LI255LCaReEDhL0oVMM())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				base._002Ector();
				num = 3;
				break;
			case 7:
				Layouts = new CvsCogEasyBuilderLayout[1];
				num = 9;
				if (1 == 0)
				{
					return;
				}
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PfITWpCtd1oaCUBpF6Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LI255LCaReEDhL0oVMM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fSciOUCD4LWebLEJ8d5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
