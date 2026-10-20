using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellEditFloat : CvsCell, ICvsCellEditNumber<double>
{
	private double F6yfXtEois;

	private double tnoff5LJKO;

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

	public double Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bplNHfFaQIjNyd3PfqH(LQc02kFRhpuRSvQl5RB(CellResult));
		}
	}

	public double MinValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return F6yfXtEois;
		}
	}

	public double MaxValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tnoff5LJKO;
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
			return (string)pSlrgPFXNCFfkoZ2p3Y(h88XZoFn5cUr8V3eJ6m(), x9s12sFGQdlejuLdmwj(47020), Value);
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
			return wP9h19F67FwHqNfp890(typeof(double).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditFloat()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		c2F3q1FeyVyreV8YUm2();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditFloat(CvsCellEditFloat cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (b1RvU3Fl96pdD9CTDsQ() ? 4 : 3);
		do
		{
			IL_0059:
			switch (num)
			{
			case 1:
			case 4:
				base._002Ector(cell);
				num = 2;
				if (CuKb0tFQPxJsx15II7U())
				{
					goto IL_0059;
				}
				goto case 2;
			case 2:
				F6yfXtEois = cell.F6yfXtEois;
				break;
			default:
				num = 5;
				if (CuKb0tFQPxJsx15II7U())
				{
					goto IL_0059;
				}
				goto case 0;
			case 0:
			case 3:
				c2F3q1FeyVyreV8YUm2();
				goto case 1;
			case 5:
				break;
			case 6:
				return;
			}
			tnoff5LJKO = cell.tnoff5LJKO;
			num = 6;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditFloat(CvsCellLocation cell, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!b1RvU3Fl96pdD9CTDsQ()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 5:
				base._002Ector(cell, cellResult);
				goto case 2;
			case 0:
			case 1:
				c2F3q1FeyVyreV8YUm2();
				num = 5;
				continue;
			case 2:
			case 4:
				F6yfXtEois = ((CvsCogEditFloatResult)cellResult.Face).Min;
				break;
			default:
				num = 3;
				continue;
			case 3:
				break;
			case 6:
				return;
			}
			tnoff5LJKO = Hg1aVPFI19bZ56fiJCn((CvsCogEditFloatResult)qsZbQVFuLcZbA3QtYlp(cellResult));
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellEditFloat(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)IhUNfAFbRbl94DiOVHw(Value, h88XZoFn5cUr8V3eJ6m());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c2F3q1FeyVyreV8YUm2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CuKb0tFQPxJsx15II7U()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b1RvU3Fl96pdD9CTDsQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qsZbQVFuLcZbA3QtYlp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Hg1aVPFI19bZ56fiJCn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditFloatResult)P_0).Max;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LQc02kFRhpuRSvQl5RB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double bplNHfFaQIjNyd3PfqH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsMath.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object h88XZoFn5cUr8V3eJ6m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x9s12sFGQdlejuLdmwj(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pSlrgPFXNCFfkoZ2p3Y(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IhUNfAFbRbl94DiOVHw(double P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToString(P_0, (IFormatProvider)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type wP9h19F67FwHqNfp890(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
