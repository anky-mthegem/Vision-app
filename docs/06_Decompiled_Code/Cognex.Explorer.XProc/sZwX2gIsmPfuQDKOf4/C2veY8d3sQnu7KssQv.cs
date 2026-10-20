using System;
using System.Reflection;
using JK709E3DnFfvLewQUh;

namespace sZwX2gIsmPfuQDKOf4;

internal class C2veY8d3sQnu7KssQv
{
	internal delegate void j5xYAHx1IvmlPEIiXv(object o);

	internal static Module Y88WYupTA;

	private static C2veY8d3sQnu7KssQv J2L4akOKTO6H05KhWL;

	internal static void KFsFj2LLltwjV(int typemdt)
	{
		Type type = Y88WYupTA.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		int num2 = 3;
		FieldInfo fieldInfo = default;
		MethodInfo method = default;
		while (true)
		{
			int num3 = num2;
			do
			{
				IL_0009:
				switch (num3)
				{
				default:
					return;
				case 5:
					t6pEVkjYsbsNw4UelN(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
					num3 = 2;
					if (L9LOgmIhYxdundaVj6() == null)
					{
						num3 = 2;
					}
					break;
				case 0:
					return;
				case 1:
					fieldInfo = fields[num];
					method = (MethodInfo)Y88WYupTA.ResolveMethod(fieldInfo.MetadataToken + 100663296);
					num3 = 5;
					break;
				case 3:
				case 4:
					if (num < fields.Length)
					{
						goto case 1;
					}
					goto IL_00aa;
				case 2:
					num++;
					num3 = 4;
					break;
				}
				goto IL_0009;
				IL_00aa:
				num3 = 0;
			}
			while (L9LOgmIhYxdundaVj6() == null);
		}
	}

	public C2veY8d3sQnu7KssQv()
	{
		pEW2iouRhAhhYOFNYt();
		base._002Ector();
		int num = 0;
		if (false)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static C2veY8d3sQnu7KssQv()
	{
		pEW2iouRhAhhYOFNYt();
		Y88WYupTA = JM0Z40FkNmGTDayaY4(typeof(C2veY8d3sQnu7KssQv).TypeHandle).Assembly.ManifestModule;
		int num = 0;
		if (1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void t6pEVkjYsbsNw4UelN(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool RqwR4UUFDh2a1Skn7D()
	{
		return J2L4akOKTO6H05KhWL == null;
	}

	internal static C2veY8d3sQnu7KssQv L9LOgmIhYxdundaVj6()
	{
		return J2L4akOKTO6H05KhWL;
	}

	internal static void pEW2iouRhAhhYOFNYt()
	{
		P72r2cmcNm3BJYykhQ.cXSFj2LzQpSyU();
	}

	internal static Type JM0Z40FkNmGTDayaY4(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
