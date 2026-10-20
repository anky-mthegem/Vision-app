using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

internal sealed class CvsCompositeOperationConverter : EnumConverter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCompositeOperationConverter()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tRW7cCxXUgjBc98xnrI();
		RF803rx60v2xlklnOfE(this, ibPw3gxbGv3PTALKe30(typeof(CvsCompositeOperation).TypeHandle));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (fFB786xniqcR9ilLKMl())
		{
			num = 2;
			if (!fFB786xniqcR9ilLKMl())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_007f;
			}
		}
		goto IL_004c;
		IL_002a:
		string text = default;
		if (mGMqcIx05nB6JKKGP1u(text, DaEj9VxpMOwvFGZmRp4()))
		{
			goto IL_007f;
		}
		if (text == (string)ILjBxYx4YF4UhgEoWNQ())
		{
			num = 6;
			if (0 == 0)
			{
				goto IL_004c;
			}
			goto IL_00a2;
		}
		goto IL_00ca;
		IL_007f:
		return CvsCompositeOperation.Add;
		IL_00ca:
		return G1RkcexkrcXkgvcFdDB(this, context, culture, value);
		IL_00a2:
		if (text != null)
		{
			num = 1;
			goto IL_004c;
		}
		goto IL_00ca;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_007f;
			case 4:
				goto IL_00a2;
			case 0:
			case 2:
				text = value as string;
				num = 4;
				continue;
			case 6:
				return CvsCompositeOperation.Subtract;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		CvsCompositeOperation cvsCompositeOperation2 = default;
		CvsCompositeOperation cvsCompositeOperation = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				return DaEj9VxpMOwvFGZmRp4();
			case 5:
				if (value is CvsCompositeOperation)
				{
					BxuSfOxGML05gCyqFsh();
					num = ((!fFB786xniqcR9ilLKMl()) ? 2 : 4);
					break;
				}
				return base.ConvertTo(context, culture, value, destinationType);
			case 1:
			case 4:
				cvsCompositeOperation2 = (CvsCompositeOperation)value;
				num = 6;
				break;
			case 6:
				if (cvsCompositeOperation2 == CvsCompositeOperation.Subtract)
				{
					return ILjBxYx4YF4UhgEoWNQ();
				}
				goto default;
			default:
				if (cvsCompositeOperation2 != CvsCompositeOperation.Add)
				{
					cvsCompositeOperation = CvsCompositeOperation.Invalid;
					num = 7;
				}
				else
				{
					num = 0;
				}
				break;
			case 7:
				return cvsCompositeOperation.ToString();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tRW7cCxXUgjBc98xnrI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type ibPw3gxbGv3PTALKe30(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RF803rx60v2xlklnOfE(object P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EnumConverter)P_0)._002Ector(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fFB786xniqcR9ilLKMl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BxuSfOxGML05gCyqFsh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DaEj9VxpMOwvFGZmRp4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CompositeOperation_Add;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mGMqcIx05nB6JKKGP1u(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ILjBxYx4YF4UhgEoWNQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CompositeOperation_Subtract;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G1RkcexkrcXkgvcFdDB(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EnumConverter)P_0).ConvertFrom((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
	}
}
