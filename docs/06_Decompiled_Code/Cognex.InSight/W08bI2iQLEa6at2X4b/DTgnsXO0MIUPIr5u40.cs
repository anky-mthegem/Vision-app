using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace W08bI2iQLEa6at2X4b;

internal class DTgnsXO0MIUPIr5u40
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module zmj0LmQ6D;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RbtOyGoo2kIGR(int typemdt)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m24tfjsuXCHYokgPWFhv();
		int num = (wJCtVSsubPym3oPDO3dn() ? 1 : 4);
		FieldInfo[] fields = default;
		Type type = default;
		int num2 = default;
		FieldInfo fieldInfo = default;
		MethodInfo methodInfo = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				fields = type.GetFields();
				num = 8;
				break;
			case 0:
			case 4:
				type = zmj0LmQ6D.ResolveType(33554432 + typemdt);
				num = 3;
				break;
			case 2:
			case 6:
				if (num2 >= fields.Length)
				{
					num = 10;
					break;
				}
				fieldInfo = fields[num2];
				num = 7;
				break;
			case 8:
				num2 = 0;
				num = 2;
				break;
			default:
				fieldInfo.SetValue(null, (MulticastDelegate)dMJfXBsu0dGZssvS5O6e(type, methodInfo));
				num = 9;
				break;
			case 7:
				methodInfo = (MethodInfo)hsrcJtsuprOkMRa80YVj(zmj0LmQ6D, UInh8Msu6Rw7V7vwGJs1(fieldInfo) + 100663296);
				goto default;
			case 9:
				num2++;
				num = 6;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DTgnsXO0MIUPIr5u40()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DTgnsXO0MIUPIr5u40()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		zmj0LmQ6D = (Module)DFH3bCsukKn6w3IbX7lc(nLdThvsu4xBfuUjMrayP(typeof(DTgnsXO0MIUPIr5u40).TypeHandle).Assembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UInh8Msu6Rw7V7vwGJs1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).MetadataToken;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hsrcJtsuprOkMRa80YVj(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Module)P_0).ResolveMethod(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dMJfXBsu0dGZssvS5O6e(Type P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.CreateDelegate(P_0, (MethodInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m24tfjsuXCHYokgPWFhv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wJCtVSsubPym3oPDO3dn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type nLdThvsu4xBfuUjMrayP(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DFH3bCsukKn6w3IbX7lc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).ManifestModule;
	}
}
