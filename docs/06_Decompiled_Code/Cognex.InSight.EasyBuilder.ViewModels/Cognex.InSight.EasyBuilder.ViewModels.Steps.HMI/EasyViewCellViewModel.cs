using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Runtime.ViewModels.EasyView;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.HMI;

public class EasyViewCellViewModel : EasyViewTreeItemViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public string cellName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass0_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			w7VV9W5JZwJ3sU6WGyFp();
			tvuZL15JB2GtnrCYE4o3(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_002Ector_003Eb__0(EasyViewItem it)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oUTJnl5JGqvGwXUi0RvL(PNwIM85JbLUjPaQZ3fty(it), cellName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void w7VV9W5JZwJ3sU6WGyFp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tvuZL15JB2GtnrCYE4o3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ToYODh5JrGvhHJrEeQ5p()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t8LLE05JPJMe5WK9LTaw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PNwIM85JbLUjPaQZ3fty(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyViewItem)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oUTJnl5JGqvGwXUi0RvL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[CompilerGenerated]
	private readonly CellViewModel MN4eCE92fc;

	public override CellViewModel ResultCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MN4eCE92fc;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EasyViewCellViewModel(CellViewModel cell, EasyViewViewModel easyView)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		EasyViewItem easyViewItem = default;
		_003C_003Ec__DisplayClass0_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				if (easyViewItem != null)
				{
					num = 1;
					continue;
				}
				return;
			case 9:
				YPEWQDm2cHfrooaSidZ();
				num = 2;
				continue;
			case 2:
				base._002Ector(easyView);
				num = 10;
				continue;
			case 8:
				easyViewItem = ((EasyViewSettings)igEm0mm1u5lColeGJ7O(EasyView)).Items.FirstOrDefault(obj._003C_002Ector_003Eb__0);
				num = 7;
				continue;
			case 3:
			case 5:
				MN4eCE92fc = cell;
				goto case 0;
			case 0:
			case 4:
				SubscribeToResultCellRefreshed();
				goto case 6;
			default:
				num = 6;
				if (Ek9AoLmQy6Tq5SMhcwG())
				{
					continue;
				}
				goto case 6;
			case 6:
				obj.cellName = ((CellViewModel)Vn2KxXmcjUEi9K07uaD(this))?.CellName;
				if (obj.cellName != null)
				{
					num = 8;
					continue;
				}
				return;
			case 1:
				GcxDUFmu9PTDiLwYNJ7(easyViewItem, ((CellViewModel)Vn2KxXmcjUEi9K07uaD(this)).LocalizedCellName);
				num = 11;
				if (Ek9AoLmQy6Tq5SMhcwG())
				{
					continue;
				}
				break;
			case 10:
				break;
			case 11:
				return;
			}
			obj = new _003C_003Ec__DisplayClass0_0();
			DTHQQDmNFXv5YM5fXa9();
			num = (Ek9AoLmQy6Tq5SMhcwG() ? 5 : 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YPEWQDm2cHfrooaSidZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Vn2KxXmcjUEi9K07uaD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyViewTreeItemViewModel)P_0).ResultCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object igEm0mm1u5lColeGJ7O(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyViewViewModel)P_0).Settings;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GcxDUFmu9PTDiLwYNJ7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyViewItem)P_0).LocalizedCellName = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ek9AoLmQy6Tq5SMhcwG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DTHQQDmNFXv5YM5fXa9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
