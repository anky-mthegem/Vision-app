using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellInt : CvsCell, ICvsCellText, ICvsCellNumber<int>
{
	public int Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ob1fb1mtdQO4e9IYJXY(WPDbCem7YL8hxO9GYkx(CellResult));
		}
	}

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((IFormatProvider)mpcp8lmCDtgM8HMkoEF(), kgbOBx7BanbFa22Hp9.ol99ukmDA(47036), Value);
		}
	}

	public override Type DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PbgMjKm5uXb1KIS7AGd(typeof(int).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellInt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CRlUATmcklcDnDcIEhe();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellInt(CvsCellInt cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CRlUATmcklcDnDcIEhe();
		base._002Ector(cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellInt(CvsCellLocation cell, long val)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!yyNY0hmBg1XyS5j6eoo())
		{
			goto IL_001e;
		}
		goto IL_0058;
		IL_0085:
		caKtbymWV6S4tmjYyQf(CellResult, vCngMRm2IJ340UexPaB(val));
		num = 5;
		goto IL_0058;
		IL_0058:
		switch (num)
		{
		case 0:
			break;
		case 1:
		case 3:
			goto IL_003f;
		default:
			goto IL_0085;
		case 5:
			return;
		}
		goto IL_001e;
		IL_003f:
		base._002Ector(cell);
		goto IL_0085;
		IL_001e:
		CRlUATmcklcDnDcIEhe();
		yyNY0hmBg1XyS5j6eoo();
		if (!lbj6ZamjrcFqqARfRmF())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_003f;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0058;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellInt(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)gXjVRHmKnOqLymSrDOI(Value, mpcp8lmCDtgM8HMkoEF());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CRlUATmcklcDnDcIEhe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yyNY0hmBg1XyS5j6eoo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lbj6ZamjrcFqqARfRmF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vCngMRm2IJ340UexPaB(long P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void caKtbymWV6S4tmjYyQf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCellResult)P_0).Value = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WPDbCem7YL8hxO9GYkx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ob1fb1mtdQO4e9IYJXY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsMath.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mpcp8lmCDtgM8HMkoEF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gXjVRHmKnOqLymSrDOI(int P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToString(P_0, (IFormatProvider)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type PbgMjKm5uXb1KIS7AGd(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
