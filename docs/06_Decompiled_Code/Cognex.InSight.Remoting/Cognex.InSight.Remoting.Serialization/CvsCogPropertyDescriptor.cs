using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "PropertyDescriptor")]
public class CvsCogPropertyDescriptor
{
	[CompilerGenerated]
	private string smkI77ehBu;

	[CompilerGenerated]
	private object ir3IWeRq1a;

	[CompilerGenerated]
	private string MMtIoKvG93;

	[CompilerGenerated]
	private string xd4IPpXiAD;

	[CompilerGenerated]
	private bool T7KIjyPxvG;

	[CompilerGenerated]
	private bool tNIIcjrhRW;

	[CompilerGenerated]
	private IDictionary<string, object> PboIdlyvGL;

	[JsonProperty(PropertyName = "path")]
	public string Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return smkI77ehBu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			smkI77ehBu = value;
		}
	}

	[JsonProperty(PropertyName = "currentValue")]
	public object Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ir3IWeRq1a;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ir3IWeRq1a = value;
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
			return MMtIoKvG93;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MMtIoKvG93 = value;
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
			return xd4IPpXiAD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xd4IPpXiAD = value;
		}
	}

	[JsonProperty(PropertyName = "readonly", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool IsReadonly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return T7KIjyPxvG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			T7KIjyPxvG = value;
		}
	}

	[JsonProperty(PropertyName = "canBeHidden", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool CanBeHidden
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tNIIcjrhRW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tNIIcjrhRW = value;
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
			return PboIdlyvGL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PboIdlyvGL = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMetadataEntryTrue(string entry)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		bool result = default;
		bool flag = default;
		object value = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (Meta != null)
				{
					num = 7;
					continue;
				}
				break;
			case 5:
				result = flag;
				num = 8;
				continue;
			case 2:
			case 3:
				if (!(value is bool))
				{
					break;
				}
				goto default;
			case 0:
				result = false;
				num = 1;
				continue;
			case 7:
				if (Meta.TryGetValue(entry, out value))
				{
					Y4TJO0i4ihwsC5wiuNZ();
					num = (Jv3Ssbi6ol5bHjEkuAv() ? 2 : 6);
					continue;
				}
				break;
			default:
				flag = (bool)value;
				num = 5;
				continue;
			case 8:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPropertyDescriptor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!Jv3Ssbi6ol5bHjEkuAv())
		{
			goto IL_001e;
		}
		goto IL_0060;
		IL_001e:
		saoSS9is2Re1jBHZWml(this);
		num = 8;
		goto IL_0060;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 2:
			case 7:
				MMtIoKvG93 = "";
				num = 3;
				continue;
			case 3:
				xd4IPpXiAD = "";
				goto default;
			case 5:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				num = 1;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				PboIdlyvGL = new Dictionary<string, object>();
				num = 0;
				if (Jv3Ssbi6ol5bHjEkuAv())
				{
					continue;
				}
				goto case 1;
			case 1:
				smkI77ehBu = "";
				_ = 0;
				num = (Jv3Ssbi6ol5bHjEkuAv() ? 7 : 6);
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Jv3Ssbi6ol5bHjEkuAv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Y4TJO0i4ihwsC5wiuNZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void saoSS9is2Re1jBHZWml(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
