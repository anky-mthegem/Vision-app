using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellListBox : CvsCell
{
	private int JSsfnNpTBm;

	private string[] riwf98w0WO;

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
			return E4PVDpmu2FvHfmEnqDM(JSsfnNpTBm, 0);
		}
	}

	public int NumSelections
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (riwf98w0WO != null)
			{
				return riwf98w0WO.Length;
			}
			return 0;
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
			if (JSsfnNpTBm < 0 || JSsfnNpTBm >= NumSelections)
			{
				return "";
			}
			return riwf98w0WO[JSsfnNpTBm];
		}
	}

	public string[] Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return riwf98w0WO;
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
			return P2TNFUmRNkujmNSiace(typeof(int).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellListBox()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellListBox(CvsCellListBox cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0073;
		IL_001a:
		Xk5WcamOCZe4pgSaf1c();
		C5q3jBm3vSy6KrFeIpK();
		if (RyvF0WmrQJ9TSvB92HC())
		{
			num = 4;
			if (!RyvF0WmrQJ9TSvB92HC())
			{
				goto IL_003f;
			}
		}
		else
		{
			num = 5;
			if (C5q3jBm3vSy6KrFeIpK())
			{
				return;
			}
		}
		goto IL_0073;
		IL_0073:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 3:
				goto IL_003f;
			case 2:
			case 5:
				JSsfnNpTBm = cell.Value;
				goto IL_003f;
			default:
				num = 3;
				continue;
			case 1:
			case 4:
				base._002Ector(cell);
				goto case 2;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_003f:
		riwf98w0WO = cell.riwf98w0WO;
		num = 6;
		goto IL_0073;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellListBox(CvsCellLocation location, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0034;
		IL_001a:
		base._002Ector(location, cellResult);
		goto IL_0067;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				goto IL_0067;
			case 0:
				goto IL_0087;
			case 5:
				try
				{
					JSsfnNpTBm = AGSEXCmeACJp5Hyp6qr(TISeAqmlaeO0ZrxTXr0(cellResult));
					return;
				}
				catch
				{
					JSsfnNpTBm = 0;
					return;
				}
			}
			break;
			IL_0087:
			Xk5WcamOCZe4pgSaf1c();
			_ = 0;
			if (!RyvF0WmrQJ9TSvB92HC())
			{
				num = 4;
				if (RyvF0WmrQJ9TSvB92HC())
				{
					continue;
				}
				goto IL_0067;
			}
			num = 3;
		}
		goto IL_001a;
		IL_0067:
		riwf98w0WO = (string[])KY2V0bmQZs3Oe1tJDou((CvsCogListBoxResult)RTr4tTmMvqfUDUOKdX4(cellResult));
		num = 5;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellListBox(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSelection(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (index < 0 || index >= NumSelections)
		{
			throw new ArgumentOutOfRangeException((string)eRRbKcmIlD7x3Mdf0ZN(47080));
		}
		return riwf98w0WO[index];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (JSsfnNpTBm < 0 || JSsfnNpTBm >= NumSelections)
		{
			return "";
		}
		return riwf98w0WO[JSsfnNpTBm];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RyvF0WmrQJ9TSvB92HC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool C5q3jBm3vSy6KrFeIpK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xk5WcamOCZe4pgSaf1c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RTr4tTmMvqfUDUOKdX4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KY2V0bmQZs3Oe1tJDou(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogListBoxResult)P_0).Selections;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TISeAqmlaeO0ZrxTXr0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AGSEXCmeACJp5Hyp6qr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int E4PVDpmu2FvHfmEnqDM(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eRRbKcmIlD7x3Mdf0ZN(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type P2TNFUmRNkujmNSiace(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
