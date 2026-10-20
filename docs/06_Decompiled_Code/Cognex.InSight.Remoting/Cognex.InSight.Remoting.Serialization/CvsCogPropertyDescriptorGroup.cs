using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "PropertyDescriptorGroup")]
public class CvsCogPropertyDescriptorGroup
{
	[CompilerGenerated]
	private string y4PITrsBNH;

	[CompilerGenerated]
	private string nRWIvWSCcJ;

	[CompilerGenerated]
	private string HlRIzroDXG;

	[CompilerGenerated]
	private IEnumerable<CvsCogPropertyDescriptor> ArHrAjPdgQ;

	[CompilerGenerated]
	private IDictionary<string, object> E0grH98AhZ;

	[JsonProperty(PropertyName = "id")]
	public string Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return y4PITrsBNH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			y4PITrsBNH = value;
		}
	}

	[JsonProperty(PropertyName = "name")]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nRWIvWSCcJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nRWIvWSCcJ = value;
		}
	}

	[JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HlRIzroDXG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HlRIzroDXG = value;
		}
	}

	[JsonProperty(PropertyName = "properties")]
	public IEnumerable<CvsCogPropertyDescriptor> Properties
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ArHrAjPdgQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ArHrAjPdgQ = value;
		}
	}

	[JsonProperty(PropertyName = "meta", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IDictionary<string, object> Meta
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E0grH98AhZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E0grH98AhZ = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPropertyDescriptorGroup()
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
			case 1:
				y4PITrsBNH = "";
				num = 0;
				break;
			case 5:
			case 6:
				E0grH98AhZ = new Dictionary<string, object>();
				num = 2;
				break;
			case 4:
			case 8:
				ArHrAjPdgQ = new List<CvsCogPropertyDescriptor>();
				goto case 5;
			case 7:
				RK92dhiIOmrwxbLjwLu();
				num = 1;
				if (b2wM4piw8ybtV5EmMFo())
				{
					break;
				}
				goto case 3;
			case 3:
				HlRIzroDXG = "";
				goto default;
			default:
				MDdIeciPmpExsCWYn6w();
				num = (b2wM4piw8ybtV5EmMFo() ? 8 : 6);
				break;
			case 2:
				pcxR2licoOtOvngKNhG(this);
				num = 9;
				break;
			case 0:
				nRWIvWSCcJ = "";
				num = 3;
				if (false)
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
	internal static bool b2wM4piw8ybtV5EmMFo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MDdIeciPmpExsCWYn6w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RK92dhiIOmrwxbLjwLu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pcxR2licoOtOvngKNhG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
