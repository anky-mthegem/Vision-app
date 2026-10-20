using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Controls.ViewModels.PropertySheet.FormatElement;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class DataElement : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public CellViewModel cell;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass13_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			JTtRq35Iex1KmnxSAp0d(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CIsSupportedInput_003Eb__0(DataElement d)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d.Cell == cell;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JTtRq35Iex1KmnxSAp0d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pstl3Y5IJqtJ0yTvcpAi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BhFXCu5Iauj99UWPs6ko()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CellViewModel s0h2GTfy1U;

	private FormatElementViewModel B8V2BadA4w;

	public CellViewModel Cell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s0h2GTfy1U;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (D8mEhNNp7HQDdgNonrG())
			{
				num = 6;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
				if (CboNdQNXiMgxbas06ZU())
				{
					goto IL_0047;
				}
			}
			goto IL_0086;
			IL_0026:
			if (s0h2GTfy1U == null)
			{
				goto IL_005c;
			}
			goto IL_00dc;
			IL_0047:
			if (s0h2GTfy1U != null)
			{
				num = 3;
				goto IL_0086;
			}
			return;
			IL_00dc:
			s0h2GTfy1U.CellViewModelReplaced -= gFC2k6KBrI;
			num = 2;
			if (CboNdQNXiMgxbas06ZU())
			{
				return;
			}
			goto IL_0086;
			IL_005c:
			SetField(ref s0h2GTfy1U, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29182));
			goto IL_0047;
			IL_0086:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 6:
					break;
				case 4:
					goto IL_0047;
				case 2:
					goto IL_005c;
				default:
					num = 4;
					continue;
				case 3:
					s0h2GTfy1U.CellViewModelReplaced += gFC2k6KBrI;
					num = 7;
					if (!CboNdQNXiMgxbas06ZU())
					{
						continue;
					}
					goto IL_00dc;
				case 1:
				case 5:
					goto IL_00dc;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
		}
	}

	public FormatElementViewModel DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return B8V2BadA4w;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 5:
					B8V2BadA4w.PropertyChanged -= HeZ2P9IVK7;
					num = 4;
					continue;
				case 4:
					SetField(ref B8V2BadA4w, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29194));
					break;
				case 6:
					OxgYc6N3yLeE7afHriq(B8V2BadA4w, new PropertyChangedEventHandler(HeZ2P9IVK7));
					num = 7;
					continue;
				case 0:
					if (B8V2BadA4w != null)
					{
						_ = 0;
						num = (D8mEhNNp7HQDdgNonrG() ? 5 : 2);
						continue;
					}
					goto case 4;
				case 7:
					return;
				}
				if (B8V2BadA4w != null)
				{
					num = 6;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DataElement(CellViewModel cell, string format = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!D8mEhNNp7HQDdgNonrG())
		{
			goto IL_001e;
		}
		goto IL_0088;
		IL_001e:
		DataType = (FormatElementViewModel)qCLPvLN7l0KvwHlhOxU(cell.DataType);
		num = 0;
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			case 6:
				X1hKYdN4BonhywllpRO(this);
				D8mEhNNp7HQDdgNonrG();
				num = (CboNdQNXiMgxbas06ZU() ? 5 : 7);
				continue;
			case 3:
				if (format != null)
				{
					DataType = new FormatElementViewModel(format);
					num = 8;
					continue;
				}
				break;
			case 1:
				Xfx2YsN95IJGIMMsLOL();
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 7:
				Cell = cell;
				num = 3;
				if (!CboNdQNXiMgxbas06ZU())
				{
					continue;
				}
				return;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task gFC2k6KBrI(object P_0, PropertyValueChangedEventArgs<CellViewModel> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Cell = P_1.Current;
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HeZ2P9IVK7(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		otWMq3N6fBoe1buJQiH(this, wdwMcQNjL96IcVyVt2n(29194));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static FormatElementViewModel ToFormatVm(CellType cellType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		FormatElementDataType formatElementDataType = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				if (cellType == CellType.String)
				{
				}
				goto case 3;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				if (cellType != CellType.Enum)
				{
					D8mEhNNp7HQDdgNonrG();
					num = (CboNdQNXiMgxbas06ZU() ? 11 : 6);
					continue;
				}
				formatElementDataType = FormatElementDataType.Int8;
				break;
			case 3:
			case 5:
			case 6:
				formatElementDataType = FormatElementDataType.String;
				num = 12;
				continue;
			case 1:
				if (cellType != CellType.Bool)
				{
					num = 4;
					continue;
				}
				formatElementDataType = FormatElementDataType.Bit;
				break;
			case 0:
				if (cellType != CellType.Int)
				{
					num = 2;
					continue;
				}
				formatElementDataType = FormatElementDataType.Int32;
				num = 9;
				continue;
			case 10:
				if (cellType > CellType.Enum)
				{
					if (cellType != CellType.Float)
					{
						num = 0;
						if (CboNdQNXiMgxbas06ZU())
						{
						}
					}
					else
					{
						formatElementDataType = FormatElementDataType.Float32;
						num = 8;
					}
					continue;
				}
				num = 1;
				if (!CboNdQNXiMgxbas06ZU())
				{
					continue;
				}
				goto case 3;
			case 7:
			case 8:
			case 9:
			case 11:
			case 12:
				break;
			}
			break;
		}
		FormatElementViewModel formatElementViewModel = new FormatElementViewModel();
		e7YoC7NCqUYFOZB3erF(formatElementViewModel, formatElementDataType);
		return formatElementViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool Kp82sSbjhs(CellType P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		D8mEhNNp7HQDdgNonrG();
		int num;
		if (!CboNdQNXiMgxbas06ZU())
		{
			num = 6;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_00d1;
			}
		}
		goto IL_0084;
		IL_00d1:
		if (P_0 > CellType.Enum)
		{
			if (P_0 != CellType.Float)
			{
				goto IL_0028;
			}
		}
		else
		{
			num = 2;
			if (!CboNdQNXiMgxbas06ZU())
			{
				goto IL_0084;
			}
		}
		goto IL_00e9;
		IL_00eb:
		return false;
		IL_0053:
		if (P_0 == CellType.String)
		{
			num = 8;
			goto IL_0084;
		}
		goto IL_00eb;
		IL_0040:
		if (P_0 != CellType.Bool)
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_0053;
			}
			goto IL_0084;
		}
		goto IL_00e9;
		IL_0028:
		if (P_0 != CellType.Int)
		{
			num = 7;
			if (CboNdQNXiMgxbas06ZU())
			{
				goto IL_0040;
			}
			goto IL_0084;
		}
		goto IL_00e9;
		IL_0084:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
				goto IL_0040;
			case 7:
				goto IL_0053;
			default:
				num = 5;
				continue;
			case 1:
				if (P_0 == CellType.Enum)
				{
					goto IL_00e9;
				}
				goto IL_00eb;
			case 0:
			case 6:
				goto IL_00d1;
			case 8:
				goto IL_00e9;
			case 3:
			case 4:
				goto IL_00eb;
			}
			break;
		}
		goto IL_0028;
		IL_00e9:
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSupportedInput(FactoryProtocol factoryProtocol, CellViewModel cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003C_003Ec__DisplayClass13_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				obj.cell = cell;
				_ = 1;
				if (!CboNdQNXiMgxbas06ZU())
				{
					num = 3;
					continue;
				}
				num = 8;
				if (!CboNdQNXiMgxbas06ZU())
				{
					continue;
				}
				goto case 9;
			case 1:
				if (!(obj.cell is SnippetNameViewModel))
				{
					num = 5;
					continue;
				}
				break;
			default:
				if (Kp82sSbjhs(PIrCLYNRTYGOnNOpGXf(obj.cell)))
				{
					num = 1;
					continue;
				}
				break;
			case 5:
				if (!Vu6FhCNTxjXakGOPrQ8(JWhB2gNWmyltNueYPiZ(obj.cell), CdQUGaROfy7He9T0foW.KbIzwHEDLa(29214), StringComparison.Ordinal))
				{
					num = 9;
					continue;
				}
				break;
			case 0:
				obj = new _003C_003Ec__DisplayClass13_0();
				num = 6;
				continue;
			case 2:
			case 3:
				if (obj.cell.IsReadOnly)
				{
					break;
				}
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				if (Nl0ZHjNAjnWi4R4CcCm(obj.cell))
				{
					break;
				}
				goto default;
			case 9:
				return ((FormatDataBase)t5WVsoNybLHaNcKpKil(factoryProtocol)).Elements.FirstOrDefault(obj._003CIsSupportedInput_003Eb__0) == null;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSupportedOutput(CellViewModel cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!Nl0ZHjNAjnWi4R4CcCm(cell))
		{
			return Kp82sSbjhs(PIrCLYNRTYGOnNOpGXf(cell));
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xfx2YsN95IJGIMMsLOL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X1hKYdN4BonhywllpRO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qCLPvLN7l0KvwHlhOxU(CellType cellType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToFormatVm(cellType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool D8mEhNNp7HQDdgNonrG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CboNdQNXiMgxbas06ZU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OxgYc6N3yLeE7afHriq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wdwMcQNjL96IcVyVt2n(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void otWMq3N6fBoe1buJQiH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e7YoC7NCqUYFOZB3erF(object P_0, FormatElementDataType P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatElementViewModel)P_0).DataType = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Nl0ZHjNAjnWi4R4CcCm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).Internal;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CellType PIrCLYNRTYGOnNOpGXf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).DataType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JWhB2gNWmyltNueYPiZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Vu6FhCNTxjXakGOPrQ8(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t5WVsoNybLHaNcKpKil(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FactoryProtocol)P_0).InputData;
	}
}
