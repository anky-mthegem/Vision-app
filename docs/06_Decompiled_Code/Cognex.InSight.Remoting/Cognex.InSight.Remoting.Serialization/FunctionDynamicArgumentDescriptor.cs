using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "DynamicArgDescriptor")]
[CvsChildSerializable]
public class FunctionDynamicArgumentDescriptor : FunctionArgumentDescriptor
{
	[CompilerGenerated]
	private string o10Y96lgX2;

	[JsonProperty("HeaderDisplayName")]
	public string HeaderDisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return o10Y96lgX2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			o10Y96lgX2 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[OnDeserialized]
	private void W2AY3lVlCE(StreamingContext QiO0cGAXCJNiOQoC25)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mjOwfNwlxiJr6hV8cD9();
		int num;
		if (!hgAKNewOiMbPokV5nL1())
		{
			num = 2;
			if (hgAKNewOiMbPokV5nL1())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_009c;
		IL_002e:
		kRIWM8wgw02TVc6jwLC(Group, HeaderDisplayName);
		num = 3;
		goto IL_009c;
		IL_009c:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 1:
			case 4:
				Group = new ArgumentGroupDescriptor();
				num = 5;
				continue;
			case 0:
			case 2:
				if (HeaderDisplayName != null)
				{
					goto case 1;
				}
				return;
			case 5:
				A4maRjwbdyJ5fZcnAcK(Group, T_Header);
				break;
			default:
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				red0dVwN0M82Xx7HnhD(Group, HeaderDisplayName);
				num = 7;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FunctionDynamicArgumentDescriptor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Rm7wEfw9YZtwcYVLvd1();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mjOwfNwlxiJr6hV8cD9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hgAKNewOiMbPokV5nL1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A4maRjwbdyJ5fZcnAcK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ArgumentGroupDescriptor)P_0).Description = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kRIWM8wgw02TVc6jwLC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ArgumentGroupDescriptor)P_0).Title = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void red0dVwN0M82Xx7HnhD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ArgumentGroupDescriptor)P_0).DisplayTitle = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Rm7wEfw9YZtwcYVLvd1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
