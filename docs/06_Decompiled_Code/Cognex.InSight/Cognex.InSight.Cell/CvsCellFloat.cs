using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellFloat : CvsCell, ICvsCellText, ICvsCellNumber<double>
{
	public double Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fLmdwPmHpl8QEt4ELHd(f4Axd1mvXOkOcIvruPs(CellResult));
		}
	}

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

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsCogCellResult cellResult = CellResult;
			CvsCellFormat cvsCellFormat = (CvsCellFormat)((cellResult != null) ? Hr5r1CmV8EVbST1cYnb(cellResult) : null);
			string text = (string)QJaHu7mUMKwr9TxFFlO(UANMHamA1iHnSYo4EnP(47050), (cvsCellFormat == null) ? UANMHamA1iHnSYo4EnP(47072) : tucpsimDZFgWfkdbAyW(cvsCellFormat));
			return (string)s3vdxPmdTxAY1sRQFjl(cVnxO0mTcsPLg9Fv5aK(), text, Value);
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
			return K3IYubmq4iceLDCOf4v(typeof(double).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellFloat()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Iutt9lmSvyJJAIkTi9p();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellFloat(CvsCellFloat cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Iutt9lmSvyJJAIkTi9p();
		base._002Ector(cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellFloat(CvsCellLocation cell, double val)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		do
		{
			IL_0031:
			switch (num)
			{
			case 1:
			case 4:
				base._002Ector(cell);
				break;
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				sgZyOymLPCrMP5Y8Qid();
				if (qp2feXm9HpBZAu2HD5A())
				{
					num = 3;
					goto IL_0031;
				}
				num = 4;
				if (!qp2feXm9HpBZAu2HD5A())
				{
					goto IL_0031;
				}
				break;
			case 5:
				return;
			}
			yj0g0KmE1BJjYFddkmR(CellResult, val);
			num = 5;
		}
		while (sgZyOymLPCrMP5Y8Qid());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellFloat(CvsCellLocation cell, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Iutt9lmSvyJJAIkTi9p();
		base._002Ector(cell, cellResult);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellFloat(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)zbcUDZmigZrpQsIDVgc(Value, cVnxO0mTcsPLg9Fv5aK());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Iutt9lmSvyJJAIkTi9p()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sgZyOymLPCrMP5Y8Qid()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qp2feXm9HpBZAu2HD5A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yj0g0KmE1BJjYFddkmR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCellResult)P_0).Value = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f4Axd1mvXOkOcIvruPs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double fLmdwPmHpl8QEt4ELHd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsMath.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Hr5r1CmV8EVbST1cYnb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).GetCellFormat();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UANMHamA1iHnSYo4EnP(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tucpsimDZFgWfkdbAyW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellFormat)P_0).NumericFormatString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QJaHu7mUMKwr9TxFFlO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cVnxO0mTcsPLg9Fv5aK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s3vdxPmdTxAY1sRQFjl(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zbcUDZmigZrpQsIDVgc(double P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToString(P_0, (IFormatProvider)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type K3IYubmq4iceLDCOf4v(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
