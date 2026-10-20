using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellEditInt : CvsCell, ICvsCellEditNumber<int>
{
	private int SG0fjiAqeZ;

	private int uDPfcb5CST;

	public override object CellValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Value;
		}
	}

	public int Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KVVEfdFF1SCIHMBv1JB(QUaJf0FfXZxPZmVhDJK(CellResult));
		}
	}

	public int MinValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SG0fjiAqeZ;
		}
	}

	public int MaxValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uDPfcb5CST;
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
			return (string)UfJAh3Fy6Fd9FN19vdm(yOugHCFmPGLJOl5uqtr(), kgbOBx7BanbFa22Hp9.ol99ukmDA(47036), Value);
		}
	}

	public override bool IsEditCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
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
			return vDkXYaFgVVo07I04dJe(typeof(int).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditInt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditInt(CvsCellEditInt cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!fvtrw3F0sDKaHHogODj())
		{
			num = 5;
			if (!kEHPpeFp1VTEpJirJYB())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_0052;
			}
		}
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				break;
			case 1:
				base._002Ector(cell);
				goto IL_006a;
			case 4:
				goto IL_0052;
			case 2:
			case 3:
				goto IL_006a;
			default:
				num = 4;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_0052:
		uDPfcb5CST = cell.uDPfcb5CST;
		num = 6;
		if (false)
		{
			goto IL_006a;
		}
		goto IL_0088;
		IL_002a:
		eBVp7AF45JvJaNvkjI2();
		num = 1;
		goto IL_0088;
		IL_006a:
		SG0fjiAqeZ = cell.SG0fjiAqeZ;
		goto IL_0052;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditInt(CvsCellLocation cell, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fvtrw3F0sDKaHHogODj();
		int num;
		if (kEHPpeFp1VTEpJirJYB())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_007b;
			}
		}
		goto IL_00a3;
		IL_0028:
		uDPfcb5CST = ((CvsCogEditIntResult)sruhojFkFQq7v23bVjp(cellResult)).Max;
		num = 6;
		if (fvtrw3F0sDKaHHogODj())
		{
		}
		goto IL_00a3;
		IL_007b:
		SG0fjiAqeZ = ((CvsCogEditIntResult)cellResult.Face).Min;
		goto IL_0028;
		IL_00a3:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 4:
				base._002Ector(cell, cellResult);
				num = 5;
				continue;
			case 0:
			case 2:
				eBVp7AF45JvJaNvkjI2();
				goto case 1;
			case 5:
				goto IL_007b;
			default:
				num = 3;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0028;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellEditInt(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToString(Value, CultureInfo.CurrentCulture);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kEHPpeFp1VTEpJirJYB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fvtrw3F0sDKaHHogODj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eBVp7AF45JvJaNvkjI2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sruhojFkFQq7v23bVjp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QUaJf0FfXZxPZmVhDJK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KVVEfdFF1SCIHMBv1JB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsMath.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yOugHCFmPGLJOl5uqtr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UfJAh3Fy6Fd9FN19vdm(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type vDkXYaFgVVo07I04dJe(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
