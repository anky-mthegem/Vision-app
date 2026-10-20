using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cognex.Remoting.CogSocket;
using btFy13pd5uf4WC4h18;

namespace Cognex.InSight.Remoting.Serialization;

[CvsChildSerializable]
public static class SerializedTypeRegistration
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterBuiltIns()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xivbqKhy9vRjOGmS7rV(OnwWpWhp8NKMh1ZvVXB(typeof(FunctionDescriptor).TypeHandle).Assembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterSerializableTypes(Assembly assembly)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_006c;
		IL_001a:
		CvsSerializableAttribute cvsSerializableAttribute = default;
		Type type = default;
		((TypeNameBinder)er8oTOhF475PgCthg11()).Register((string)MGljshhGDYVgoDvtLBZ(cvsSerializableAttribute), type);
		num = 0;
		goto IL_006c;
		IL_006c:
		int num2 = default;
		object[] array2 = default;
		Type[] array = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				break;
			case 1:
			case 2:
				num2 = 0;
				goto case 5;
			case 7:
				if (array2.Length == 0)
				{
					goto case 0;
				}
				goto case 10;
			default:
				num = 10;
				continue;
			case 5:
				if (num2 < array.Length)
				{
					type = array[num2];
					goto case 3;
				}
				num = 11;
				continue;
			case 3:
			case 4:
				array2 = (object[])dnGuhehog9wvKS95caI(type, OnwWpWhp8NKMh1ZvVXB(typeof(CvsSerializableAttribute).TypeHandle), false);
				num = 7;
				continue;
			case 0:
				num2++;
				num = 5;
				continue;
			case 10:
				cvsSerializableAttribute = (CvsSerializableAttribute)array2[0];
				num = 9;
				continue;
			case 6:
				throw new ArgumentNullException((string)bH47dPh5EVOmWMibIpC(1458));
			case 8:
				if (!dp9UAihKUKpUi21mbEh(assembly, null))
				{
					array = (Type[])e9nBAGhT9eMfV5IneIS(assembly);
					UW6JU7hE8xmEmboK6Bm();
					if (hsvSoBhxKk1QHOPDUF6())
					{
						num = 4;
						if (true)
						{
							continue;
						}
						goto case 7;
					}
					num = 1;
					continue;
				}
				num = 6;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type OnwWpWhp8NKMh1ZvVXB(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xivbqKhy9vRjOGmS7rV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RegisterSerializableTypes((Assembly)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UW6JU7hE8xmEmboK6Bm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hsvSoBhxKk1QHOPDUF6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dp9UAihKUKpUi21mbEh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Assembly)P_0 == (Assembly)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bH47dPh5EVOmWMibIpC(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e9nBAGhT9eMfV5IneIS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetTypes();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dnGuhehog9wvKS95caI(object P_0, Type P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object er8oTOhF475PgCthg11()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JsonRemoteSerializer.TypeNameBinder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MGljshhGDYVgoDvtLBZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsSerializableAttribute)P_0).JsonName;
	}
}
