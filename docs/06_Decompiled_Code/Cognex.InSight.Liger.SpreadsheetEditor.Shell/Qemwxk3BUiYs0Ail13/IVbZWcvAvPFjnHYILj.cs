using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using fwndm9dOZy61LXFGHR;

namespace Qemwxk3BUiYs0Ail13;

internal class IVbZWcvAvPFjnHYILj
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module yYjOoiHNV;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yg3Lt1eeyXkZB(int typemdt)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!wLCquIkaOZZIsGl8Ii())
		{
			goto IL_001e;
		}
		goto IL_00ef;
		IL_001e:
		int num2 = num2 + 1;
		num = 1;
		goto IL_00ef;
		IL_00ef:
		FieldInfo[] fields = default;
		Type type = default;
		FieldInfo fieldInfo = default;
		MethodInfo methodInfo = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 9:
				fields = type.GetFields();
				num = 8;
				continue;
			case 1:
			case 3:
			case 6:
				if (num2 >= fields.Length)
				{
					num = 10;
					continue;
				}
				fieldInfo = fields[num2];
				num = 4;
				continue;
			case 8:
				num2 = 0;
				_ = 0;
				if (wLCquIkaOZZIsGl8Ii())
				{
					num = 6;
					continue;
				}
				num = 7;
				if (!wLCquIkaOZZIsGl8Ii())
				{
					return;
				}
				continue;
			case 0:
				type = mohCDIYudCTZ5t4ohS(yYjOoiHNV, 33554432 + typemdt);
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			default:
				SRZXt8UVXAyhCXPpt1(fieldInfo, null, (MulticastDelegate)EaJ3OIBhBhCZ30bhRT(type, methodInfo));
				num = 2;
				if (wLCquIkaOZZIsGl8Ii())
				{
					continue;
				}
				goto case 4;
			case 4:
				methodInfo = (MethodInfo)K0DW4EysL142Bs3HmZ(yYjOoiHNV, fieldInfo.MetadataToken + 100663296);
				goto default;
			case 10:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IVbZWcvAvPFjnHYILj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QydVltWcCHDiPv4cA0.RScLt1ez0Xo5H();
		tuvYeCzOnncq7KJF9E(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static IVbZWcvAvPFjnHYILj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IkSoCacjHFYvMaXfd3T();
		yYjOoiHNV = (Module)pwbXYgcvLJi03JtBSuu(lkLNhfccGsY5c3S7T98(typeof(IVbZWcvAvPFjnHYILj).TypeHandle).Assembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type mohCDIYudCTZ5t4ohS(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Module)P_0).ResolveType(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K0DW4EysL142Bs3HmZ(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Module)P_0).ResolveMethod(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EaJ3OIBhBhCZ30bhRT(Type P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.CreateDelegate(P_0, (MethodInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SRZXt8UVXAyhCXPpt1(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wLCquIkaOZZIsGl8Ii()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ecE9nuil1drDhEeJkj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tuvYeCzOnncq7KJF9E(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IkSoCacjHFYvMaXfd3T()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QydVltWcCHDiPv4cA0.RScLt1ez0Xo5H();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type lkLNhfccGsY5c3S7T98(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pwbXYgcvLJi03JtBSuu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).ManifestModule;
	}
}
