using System;
using System.Reflection;
using b4Zxkh9w1NDrmwo2EQ;

namespace w0UYcAEOovAZior2mT;

internal class XrxKPOmG8Z5oWrNCbn
{
	internal delegate void qSFdJmdIMpwxwQdERd(object o);

	internal static Module xDr3mwo2E;

	internal static XrxKPOmG8Z5oWrNCbn JMW01v5YoFn4jtcMbQ0;

	internal static void vb8bY9ssZWOhh(int typemdt)
	{
		Type type = DdSLea5dHaCkrEVtGKv(xDr3mwo2E, 33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 2;
		if (fLDJgK5t18GAn8rbf9I())
		{
			num = 5;
		}
		FieldInfo fieldInfo = default;
		int num2 = default;
		MethodInfo method = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 1:
				fieldInfo = fields[num2];
				method = (MethodInfo)xDr3mwo2E.ResolveMethod(Wo2g6x5D8ffyIYjnZVi(fieldInfo) + 100663296);
				num = 0;
				if (yDhwRJ56mIEMxFUZ235() != null)
				{
					num = num3;
				}
				break;
			default:
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num2++;
				num = 0;
				if (fLDJgK5t18GAn8rbf9I())
				{
					num = 2;
				}
				break;
			case 2:
			case 3:
				if (num2 >= fields.Length)
				{
					return;
				}
				goto case 1;
			case 5:
				num2 = 0;
				num = 3;
				if (yDhwRJ56mIEMxFUZ235() == null)
				{
					num = 3;
				}
				break;
			}
		}
	}

	public XrxKPOmG8Z5oWrNCbn()
	{
		FFv4xB5l8S0NCArU2xJ();
		base._002Ector();
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static XrxKPOmG8Z5oWrNCbn()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					xDr3mwo2E = xYTkZF5iCpMCbrkMQep(typeof(XrxKPOmG8Z5oWrNCbn).TypeHandle).Assembly.ManifestModule;
					return;
				case 1:
					break;
				}
				YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
				num2 = 0;
			}
			while (0 == 0);
		}
	}

	internal static Type DdSLea5dHaCkrEVtGKv(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static int Wo2g6x5D8ffyIYjnZVi(object P_0)
	{
		return ((MemberInfo)P_0).MetadataToken;
	}

	internal static bool fLDJgK5t18GAn8rbf9I()
	{
		return JMW01v5YoFn4jtcMbQ0 == null;
	}

	internal static XrxKPOmG8Z5oWrNCbn yDhwRJ56mIEMxFUZ235()
	{
		return JMW01v5YoFn4jtcMbQ0;
	}

	internal static void FFv4xB5l8S0NCArU2xJ()
	{
		YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
	}

	internal static Type xYTkZF5iCpMCbrkMQep(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
