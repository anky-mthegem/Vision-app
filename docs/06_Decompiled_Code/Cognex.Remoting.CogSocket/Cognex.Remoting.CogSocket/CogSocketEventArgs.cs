using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using IawbpyxeWauKVJvQ4t;

namespace Cognex.Remoting.CogSocket;

public class CogSocketEventArgs : CogSocketHandlerArgs
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PropertyInfo> _003C_003E9__2_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wPOorXRMtI2kBZ32gIl();
			KG2xcqRdsOoZ5A49JL8(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003CFromEventArgs_003Eb__2_0(PropertyInfo a, PropertyInfo b)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return weJahRRCq5qXlxgp2LY(gT2Kb9RGPhpHaiRrwPb(a), b.Name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fSwrocRLM5ApBZoh9yj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z6TEpQRqaRsGU86htPq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wPOorXRMtI2kBZ32gIl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KG2xcqRdsOoZ5A49JL8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gT2Kb9RGPhpHaiRrwPb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemberInfo)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int weJahRRCq5qXlxgp2LY(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Compare((string)P_0, (string)P_1);
		}
	}

	public new static readonly CogSocketEventArgs Empty;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketEventArgs(object[] args = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YaTdV2pM5MJm1KGirA3();
		base._002Ector(args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CogSocketEventArgs MliSHgHaC(EventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (!kt8db0pLHKPtrdsUpiL())
		{
			goto IL_001e;
		}
		goto IL_00d9;
		IL_001e:
		Type type = P_0.GetType();
		num = 7;
		goto IL_00d9;
		IL_00d9:
		int num2 = default;
		PropertyInfo[] properties = default;
		object[] array = default;
		CogSocketEventArgs e = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 3:
				return Empty;
			default:
				num2 = 0;
				num = 9;
				continue;
			case 2:
				num2++;
				num = 0;
				continue;
			case 4:
				properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
				ljmMsxpqItmn9cEOTrU();
				if (kt8db0pLHKPtrdsUpiL())
				{
					num = 10;
					if (kt8db0pLHKPtrdsUpiL())
					{
						continue;
					}
					goto case 5;
				}
				num = 11;
				continue;
			case 5:
			case 10:
				Array.Sort(properties, [MethodImpl(MethodImplOptions.NoInlining)] (PropertyInfo a, PropertyInfo b) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.weJahRRCq5qXlxgp2LY(_003C_003Ec.gT2Kb9RGPhpHaiRrwPb(a), b.Name);
				});
				array = new object[properties.Length];
				goto default;
			case 0:
			case 9:
				if (num2 >= properties.Length)
				{
					e = new CogSocketEventArgs(array);
					num = 12;
				}
				else
				{
					array[num2] = F8XcrUpCy5B8qjSLe9C(properties[num2], P_0);
					num = 2;
				}
				continue;
			case 1:
				if (e == null)
				{
					num = 4;
					continue;
				}
				goto case 12;
			case 7:
				if (!QdMm3ipGqnaAUX1grcm(type, jCfqpjpdx7xpUDwkkUj(typeof(EventArgs).TypeHandle)))
				{
					e = P_0 as CogSocketEventArgs;
					num = 1;
					if (ljmMsxpqItmn9cEOTrU())
					{
					}
				}
				else
				{
					num = 3;
				}
				continue;
			case 12:
				return e;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CogSocketEventArgs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YaTdV2pM5MJm1KGirA3();
		Empty = new CogSocketEventArgs();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YaTdV2pM5MJm1KGirA3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kt8db0pLHKPtrdsUpiL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ljmMsxpqItmn9cEOTrU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type jCfqpjpdx7xpUDwkkUj(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QdMm3ipGqnaAUX1grcm(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F8XcrUpCy5B8qjSLe9C(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyInfo)P_0).GetValue(P_1);
	}
}
