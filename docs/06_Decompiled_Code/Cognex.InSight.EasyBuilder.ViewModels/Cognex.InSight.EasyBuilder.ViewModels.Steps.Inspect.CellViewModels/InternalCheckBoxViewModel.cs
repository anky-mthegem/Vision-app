using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class InternalCheckBoxViewModel : CellViewModel
{
	private bool xnQxuJMBbD;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Bool;
		}
	}

	public override bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public bool Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xnQxuJMBbD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref xnQxuJMBbD, value, (string)RT2HYAUZhyiQFJIFwYH(5436)))
			{
				fgIq7iUBJASYGRmlYUH(this, RT2HYAUZhyiQFJIFwYH(27684));
			}
		}
	}

	public override string DisplayValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)makrLLUbeJMxRjHHwZf(RT2HYAUZhyiQFJIFwYH(1906), Value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InternalCheckBoxViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		do
		{
			IL_0054:
			switch (num)
			{
			case 3:
				xvn5HSUrUmrh5QMb5ow();
				Lx7CdoUvWf9OuNm3L6a();
				num = ((!oloNUPUsFn9DFOAkqww()) ? 4 : 0);
				goto IL_0054;
			case 0:
			case 1:
				base._002Ector(insight, loc, displayName);
				break;
			case 5:
				return;
			}
			Refresh(cells, init: true);
			num = 5;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Lx7CdoUvWf9OuNm3L6a();
		int num = (oloNUPUsFn9DFOAkqww() ? 1 : 6);
		bool value = default;
		CvsCellCheckBox cvsCellCheckBox = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				base.RefreshValue(cell, init);
				num = 7;
				break;
			case 7:
				value = false;
				num = 3;
				break;
			case 4:
			case 6:
				if (cvsCellCheckBox != null)
				{
					num = 8;
					if (oloNUPUsFn9DFOAkqww())
					{
						break;
					}
					goto case 8;
				}
				value = CellViewModel.ConvertCellValue<bool>(cell);
				num = 12;
				break;
			case 8:
				value = z0pl4RUP9dIH5ZEdfIM(cvsCellCheckBox);
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
			case 12:
				if (init)
				{
					num = 9;
					break;
				}
				if (cell != null)
				{
					num = 5;
					if (true)
					{
						break;
					}
					return;
				}
				return;
			case 3:
				cellLocation = CellLocation;
				num = 11;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				Value = value;
				num = 13;
				break;
			case 11:
				if (cellLocation.IsValid)
				{
					cvsCellCheckBox = cell as CvsCellCheckBox;
					goto case 4;
				}
				goto case 2;
			case 9:
				xnQxuJMBbD = value;
				num = 10;
				break;
			case 10:
				return;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteViaRun(Dictionary<string, object> dict, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = value;
		dict[CellName] = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xvn5HSUrUmrh5QMb5ow()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oloNUPUsFn9DFOAkqww()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Lx7CdoUvWf9OuNm3L6a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool z0pl4RUP9dIH5ZEdfIM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCheckBox)P_0).Checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RT2HYAUZhyiQFJIFwYH(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fgIq7iUBJASYGRmlYUH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object makrLLUbeJMxRjHHwZf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}
}
