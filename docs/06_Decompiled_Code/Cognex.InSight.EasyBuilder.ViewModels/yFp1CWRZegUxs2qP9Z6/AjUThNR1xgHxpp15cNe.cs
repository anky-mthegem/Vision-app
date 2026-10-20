using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;

namespace yFp1CWRZegUxs2qP9Z6;

internal class AjUThNR1xgHxpp15cNe
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module t2szc6LaMI;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Up4hNFaai5oWF(int typemdt)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		Type type = default;
		int num2 = default;
		FieldInfo[] fields = default;
		FieldInfo fieldInfo = default;
		MethodInfo method = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				type = BNyD8C5BeZC9Gcg0BMTA(t2szc6LaMI, 33554432 + typemdt);
				num = 0;
				break;
			case 1:
			case 3:
			case 7:
				do
				{
					if (num2 >= fields.Length)
					{
						num = 10;
						continue;
					}
					fieldInfo = fields[num2];
					num = 8;
					break;
				}
				while (false);
				break;
			case 4:
				num2 = 0;
				num = 1;
				break;
			case 0:
				fields = type.GetFields();
				num = 4;
				break;
			case 6:
				num2++;
				goto case 1;
			case 2:
			case 5:
				xUWE5w5BDB5lpMk7Ru62(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 8;
			case 8:
				method = (MethodInfo)rQe1bo5BIEK7IiaJpVNR(t2szc6LaMI, hCaQ2d5BOagDokbrwkFk(fieldInfo) + 100663296);
				goto default;
			default:
				IDtmVq5BJyN2RCaZ40sb();
				if (GC6sTG5BaVk8muVIUy3N())
				{
					num = 3;
					if (!GC6sTG5BaVk8muVIUy3N())
					{
						break;
					}
					goto case 2;
				}
				num = 2;
				if (!IDtmVq5BJyN2RCaZ40sb())
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AjUThNR1xgHxpp15cNe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FmvQSu5Bi2NoacpuCOXN();
		OLH0eW5Bnjmc68q1deG1(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AjUThNR1xgHxpp15cNe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		t2szc6LaMI = (Module)iXLqrA5BfPHJbVRiDLZ5(Eh4O335BVF3rULxe96Yy(typeof(AjUThNR1xgHxpp15cNe).TypeHandle).Assembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type BNyD8C5BeZC9Gcg0BMTA(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Module)P_0).ResolveType(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hCaQ2d5BOagDokbrwkFk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).MetadataToken;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rQe1bo5BIEK7IiaJpVNR(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Module)P_0).ResolveMethod(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xUWE5w5BDB5lpMk7Ru62(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IDtmVq5BJyN2RCaZ40sb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GC6sTG5BaVk8muVIUy3N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FmvQSu5Bi2NoacpuCOXN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OLH0eW5Bnjmc68q1deG1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Eh4O335BVF3rULxe96Yy(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iXLqrA5BfPHJbVRiDLZ5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).ManifestModule;
	}
}
