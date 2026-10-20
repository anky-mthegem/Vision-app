using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

public class IntegerMaybeBooleanConverter : JsonConverter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanConvert(Type objectType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!(objectType == axKJy5cG0LNU98hJLh1(typeof(bool).TypeHandle)))
		{
			return WmEQg0cnEP82EKZaWvb(objectType, typeof(int));
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (rCY7EqcohA8vjHgsPoB())
		{
			int num2 = default;
			bool flag = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					num = 2;
					continue;
				case 3:
					goto IL_007c;
				case 8:
					goto IL_009b;
				case 1:
				case 5:
					num2 = (int)value;
					goto case 0;
				case 2:
					return;
				case 7:
					flag = (bool)value;
					num = 8;
					continue;
				case 0:
				case 6:
					KiNoNTcdkRr6vx0vKrP(writer, num2.ToString());
					num = 9;
					continue;
				case 9:
					return;
				}
				break;
				IL_009b:
				if (!flag)
				{
					num = 4;
					continue;
				}
				goto IL_0024;
				IL_007c:
				if (value is bool)
				{
					num = 7;
					if (pEfpPKcFmKiU0QxRCTv())
					{
					}
					continue;
				}
				if (value is int)
				{
					_ = 1;
					num = ((!pEfpPKcFmKiU0QxRCTv()) ? 1 : 0);
					continue;
				}
				throw new NotImplementedException();
			}
		}
		int num3 = 0;
		goto IL_0025;
		IL_0025:
		int num4 = num3;
		KiNoNTcdkRr6vx0vKrP(writer, num4.ToString());
		return;
		IL_0024:
		num3 = 1;
		goto IL_0025;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JToken jToken = (JToken)ew6A6Mck9piwrrcJSYL(reader);
		object result = default;
		try
		{
			int num;
			if (CAoEHCcMxykvwZ4Ahry(jToken) == JTokenType.Boolean)
			{
				_ = 0;
				if (rCY7EqcohA8vjHgsPoB())
				{
					num = 2;
					if (false)
					{
						goto IL_003a;
					}
				}
				else
				{
					num = 3;
				}
				goto IL_0057;
			}
			result = jToken.Value<int>();
			goto end_IL_0015;
			IL_0057:
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				goto IL_0080;
			case 4:
				goto end_IL_0015;
			}
			goto IL_003a;
			IL_003a:
			if (!jToken.Value<bool>())
			{
				goto IL_0080;
			}
			int num2 = 0;
			goto IL_0087;
			IL_0087:
			result = num2;
			num = 4;
			goto IL_0057;
			IL_0080:
			num2 = 1;
			goto IL_0087;
			end_IL_0015:;
		}
		catch (Exception)
		{
			result = 0;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntegerMaybeBooleanConverter()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iKMy65c26ghLMX8W53x();
		uttXCfcLC3O7TuriHYf(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type axKJy5cG0LNU98hJLh1(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WmEQg0cnEP82EKZaWvb(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rCY7EqcohA8vjHgsPoB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pEfpPKcFmKiU0QxRCTv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KiNoNTcdkRr6vx0vKrP(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JsonWriter)P_0).WriteValue((string?)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ew6A6Mck9piwrrcJSYL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JToken.Load((JsonReader)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static JTokenType CAoEHCcMxykvwZ4Ahry(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JToken)P_0).Type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iKMy65c26ghLMX8W53x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uttXCfcLC3O7TuriHYf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JsonConverter)P_0)._002Ector();
	}
}
