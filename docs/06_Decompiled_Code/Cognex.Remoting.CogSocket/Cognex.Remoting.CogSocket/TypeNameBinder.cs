using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using IawbpyxeWauKVJvQ4t;
using Newtonsoft.Json.Linq;

namespace Cognex.Remoting.CogSocket;

public class TypeNameBinder : SerializationBinder
{
	private Dictionary<Type, string> CGLiRdjyfE;

	private Dictionary<string, Type> u5firZdsuw;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterAssembly(Assembly asm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Register((Type[])g7wS2tDSbufd7OWq0tk(asm));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Register(params Type[] types)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00a2;
		IL_001a:
		string text = default;
		Type type = default;
		Register(text, type);
		num = 11;
		goto IL_00a2;
		IL_00a2:
		object[] array2 = default;
		int num2 = default;
		Type[] array = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 8:
				array2 = (object[])UY38xKDWQP2MRhV9gHF(type, JRZ9N3DiHC8xAt29GnW(typeof(DataContractAttribute).TypeHandle), false);
				num = 5;
				if (I7xX1fDBRKoMtAsEBua())
				{
					continue;
				}
				goto case 9;
			case 9:
				text = (string)UeLK8FDl0hXixMhu83t((DataContractAttribute)array2[0]);
				goto IL_005e;
			case 11:
				num2++;
				num = 10;
				continue;
			case 2:
			case 3:
				text = null;
				num = 8;
				continue;
			case 5:
				if (array2.Length != 0)
				{
					goto case 9;
				}
				goto IL_005e;
			default:
				num = 9;
				continue;
			case 0:
			case 10:
				if (num2 >= array.Length)
				{
					num = 12;
					continue;
				}
				type = array[num2];
				goto case 2;
			case 6:
				array = types;
				rnkOymDhKo7UN16NZJ3();
				num = (I7xX1fDBRKoMtAsEBua() ? 4 : 2);
				continue;
			case 1:
			case 4:
				num2 = 0;
				num = 0;
				continue;
			case 12:
				return;
				IL_005e:
				if (text != null)
				{
					num = 7;
					continue;
				}
				goto case 11;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Register(string name, Type type)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		u5firZdsuw[name] = type;
		CGLiRdjyfE[type] = name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				if (CGLiRdjyfE.ContainsKey(serializedType))
				{
					goto case 0;
				}
				typeName = serializedType.AssemblyQualifiedName;
				num = 6;
				break;
			case 0:
			case 2:
				typeName = CGLiRdjyfE[serializedType];
				return;
			default:
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				assemblyName = null;
				I7xX1fDBRKoMtAsEBua();
				if (rnkOymDhKo7UN16NZJ3())
				{
					num = 0;
					break;
				}
				num = 5;
				if (!I7xX1fDBRKoMtAsEBua())
				{
					return;
				}
				break;
			case 4:
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Type BindToType(string assemblyName, string typeName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (u5firZdsuw.ContainsKey(typeName))
		{
			return u5firZdsuw[typeName];
		}
		return HOHodtDYCpW7KKMTHQN(typeName, false) ?? JRZ9N3DiHC8xAt29GnW(typeof(JToken).TypeHandle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TypeNameBinder()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		I7xX1fDBRKoMtAsEBua();
		int num;
		if (!rnkOymDhKo7UN16NZJ3())
		{
			num = 1;
			if (rnkOymDhKo7UN16NZJ3())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_005b;
		IL_002e:
		kXCbU7DzleaD5CtLxvl(this);
		num = 6;
		goto IL_005b;
		IL_005b:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
			case 5:
				u5firZdsuw = new Dictionary<string, Type>();
				break;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				CGLiRdjyfE = new Dictionary<Type, string>();
				goto case 2;
			case 0:
			case 1:
				rUhxYHDgLh9xIMnqG6j();
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g7wS2tDSbufd7OWq0tk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetTypes();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I7xX1fDBRKoMtAsEBua()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rnkOymDhKo7UN16NZJ3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type JRZ9N3DiHC8xAt29GnW(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UY38xKDWQP2MRhV9gHF(object P_0, Type P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UeLK8FDl0hXixMhu83t(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DataContractAttribute)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type HOHodtDYCpW7KKMTHQN(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetType((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rUhxYHDgLh9xIMnqG6j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kXCbU7DzleaD5CtLxvl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationBinder)P_0)._002Ector();
	}
}
