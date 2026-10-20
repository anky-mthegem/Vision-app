using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class EditStringViewModel : CellViewModel
{
	private string qdSyEZWfIY;

	private int lB4ybXgkbn;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.String;
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

	public string Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qdSyEZWfIY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WlIgjxM4bc5AECY1uoI();
			int num = (E6BlarM7BpaSyMjQlSL() ? 1 : 3);
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					pF9eaxMRB2FRoMerJYG(this, WBqn1JMCGrA8L1j0Hjg(27684));
					num = 6;
					break;
				case 0:
				case 3:
					text = qdSyEZWfIY;
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					UpfoSJM0yuOYI5O8APS(xrm4mfMWA5GmaGKyBqj(InSight), new UndoEditCellChange<string>(InSight, CellName, text, qdSyEZWfIY, (string)znIfvfMyxc6OYgu4GEj(s40KdeMTZSXlPMRJQd7(), CellName, text, qdSyEZWfIY)));
					goto case 5;
				default:
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					if (SetField(ref qdSyEZWfIY, value, (string)WBqn1JMCGrA8L1j0Hjg(5436)))
					{
						goto case 1;
					}
					return;
				case 6:
					return;
				}
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
			return Value;
		}
	}

	public int MaxChars
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lB4ybXgkbn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref lB4ybXgkbn, value, (string)WBqn1JMCGrA8L1j0Hjg(28082));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditStringViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WlIgjxM4bc5AECY1uoI();
		int num;
		if (!E6BlarM7BpaSyMjQlSL())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (!WlIgjxM4bc5AECY1uoI())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				Refresh(cells, init: true);
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				base._002Ector(insight, loc, displayName);
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		CvsCellEditString cvsCellEditString = default;
		string text = default;
		CvsCellString cvsCellString = default;
		int value = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (cvsCellEditString != null)
				{
					text = (string)NAM36dM3j1w3klltAwM(cvsCellEditString);
					num = 13;
					continue;
				}
				cvsCellString = cell as CvsCellString;
				goto case 6;
			case 6:
			case 15:
				if (cvsCellString == null)
				{
					text = CellViewModel.ConvertCellValue<string>(cell);
					num = 14;
				}
				else
				{
					num = 5;
				}
				continue;
			case 5:
				text = (string)NAM36dM3j1w3klltAwM(cvsCellString);
				break;
			default:
				num = 0;
				continue;
			case 3:
				text = string.Empty;
				value = 0;
				cellLocation = CellLocation;
				WlIgjxM4bc5AECY1uoI();
				num = (E6BlarM7BpaSyMjQlSL() ? 15 : 12);
				continue;
			case 1:
				lB4ybXgkbn = value;
				num = 11;
				continue;
			case 16:
				fTpyIcNQn1(text);
				num = 17;
				continue;
			case 10:
				base.RefreshValue(cell, init);
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 12:
				if (cellLocation.IsValid)
				{
					cvsCellEditString = cell as CvsCellEditString;
					num = 4;
					continue;
				}
				break;
			case 13:
				value = aC8ZnJMj608RqFZAM5i(cvsCellEditString);
				num = 7;
				if (E6BlarM7BpaSyMjQlSL())
				{
				}
				continue;
			case 9:
				qdSyEZWfIY = text;
				num = 1;
				if (!E6BlarM7BpaSyMjQlSL())
				{
					continue;
				}
				break;
			case 8:
				MaxChars = value;
				num = 16;
				continue;
			case 0:
			case 7:
			case 14:
				break;
			case 11:
				return;
			case 17:
				return;
			}
			if (init)
			{
				num = 9;
				continue;
			}
			if (cell != null)
			{
				num = 8;
				continue;
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fTpyIcNQn1(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				wSH95ZMAwKXF9ul7vxq(this, WBqn1JMCGrA8L1j0Hjg(5436));
				goto default;
			case 0:
				if (qEWIAAM6hjccXJ9TS15(qdSyEZWfIY, P_0))
				{
					num = 4;
					break;
				}
				return;
			case 4:
				qdSyEZWfIY = P_0;
				_ = 1;
				num = ((!E6BlarM7BpaSyMjQlSL()) ? 1 : 5);
				break;
			default:
				pF9eaxMRB2FRoMerJYG(this, WBqn1JMCGrA8L1j0Hjg(27684));
				num = 6;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WlIgjxM4bc5AECY1uoI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E6BlarM7BpaSyMjQlSL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NAM36dM3j1w3klltAwM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aC8ZnJMj608RqFZAM5i(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellEditString)P_0).MaxChars;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qEWIAAM6hjccXJ9TS15(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WBqn1JMCGrA8L1j0Hjg(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wSH95ZMAwKXF9ul7vxq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pF9eaxMRB2FRoMerJYG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xrm4mfMWA5GmaGKyBqj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).UndoHandler;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s40KdeMTZSXlPMRJQd7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.pd1hOYqP56();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object znIfvfMyxc6OYgu4GEj(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UpfoSJM0yuOYI5O8APS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
	}
}
