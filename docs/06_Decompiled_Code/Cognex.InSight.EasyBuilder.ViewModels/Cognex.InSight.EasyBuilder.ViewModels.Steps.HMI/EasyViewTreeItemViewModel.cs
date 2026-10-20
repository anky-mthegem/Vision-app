using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Controls;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Runtime.ViewModels.EasyView;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.HMI;

public abstract class EasyViewTreeItemViewModel : CheckBoxTreeItemViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string cellName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass11_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			whKLs55JA0LkGdP5iVFp();
			ksix0V5JRUOCojBK4nJb(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetIsChecked_003Eb__0(EasyViewItem it)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return it.CellName == cellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void whKLs55JA0LkGdP5iVFp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ksix0V5JRUOCojBK4nJb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rZjh2b5J6X239twRtTE8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool byOvj35JCNBu7oEauIWZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CheckBoxTreeItemViewModel, bool> _003C_003E9__11_1;

		public static Func<EasyViewTreeItemViewModel, bool> _003C_003E9__18_0;

		public static Func<EasyViewTreeItemViewModel, CellViewModel> _003C_003E9__18_1;

		public static Action<CheckBoxTreeItemViewModel> _003C_003E9__20_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			b5okny5JyN4F0EtFut5L();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetIsChecked_003Eb__11_1(CheckBoxTreeItemViewModel it)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CeHcNw5JW0ABcdgI43hF();
			int num = (SfXxbF5JTxfJnYuGQcDL() ? 2 : 4);
			bool? isChecked = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					isChecked = it.IsChecked;
					num = 5;
					break;
				case 0:
				case 4:
					isChecked = it.IsChecked;
					goto case 1;
				case 1:
				case 2:
					if (isChecked.HasValue)
					{
						goto case 3;
					}
					return false;
				default:
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					return isChecked.Value;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_CheckedChildCells_003Eb__18_0(EasyViewTreeItemViewModel item)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SfXxbF5JTxfJnYuGQcDL();
			int num;
			if (CeHcNw5JW0ABcdgI43hF())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (SfXxbF5JTxfJnYuGQcDL())
				{
				}
			}
			bool flag = default;
			bool? isChecked = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					flag = true;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					if (item == null)
					{
						goto case 1;
					}
					isChecked = item.IsChecked;
					goto case 2;
				case 1:
				case 4:
					return false;
				default:
					num = 2;
					break;
				case 5:
					return isChecked == flag;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CellViewModel _003Cget_CheckedChildCells_003Eb__18_1(EasyViewTreeItemViewModel item)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CellViewModel)FCZFpb5J0PS6sc6Q5Vyb(item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CFireIsCheckedChanged_003Eb__20_0(CheckBoxTreeItemViewModel child)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			child?.FireIsCheckedChangedEvent();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void b5okny5JyN4F0EtFut5L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CeHcNw5JW0ABcdgI43hF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SfXxbF5JTxfJnYuGQcDL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FCZFpb5J0PS6sc6Q5Vyb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyViewTreeItemViewModel)P_0).ResultCell;
		}
	}

	[CompilerGenerated]
	private readonly EasyViewViewModel bZpeqEot0o;

	protected EasyViewViewModel EasyView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bZpeqEot0o;
		}
	}

	public abstract CellViewModel ResultCell { get; }

	public override bool? IsChecked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetIsChecked();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetIsChecked(value, null);
		}
	}

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ResultCell?.LocalizedCellName;
		}
	}

	public override string Information
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)AgPrORQf38nNyPmCs3H(this))?.DisplayValue;
		}
	}

	protected IEnumerable<CellViewModel> CheckedChildCells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TreeNodes?.OfType<EasyViewTreeItemViewModel>().Where([MethodImpl(MethodImplOptions.NoInlining)] (EasyViewTreeItemViewModel item) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_003C_003Ec.SfXxbF5JTxfJnYuGQcDL();
				int num;
				if (_003C_003Ec.CeHcNw5JW0ABcdgI43hF())
				{
					num = 3;
				}
				else
				{
					num = 4;
					if (_003C_003Ec.SfXxbF5JTxfJnYuGQcDL())
					{
					}
				}
				bool flag = default;
				bool? isChecked = default;
				while (true)
				{
					switch (num)
					{
					case 2:
						flag = true;
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 0;
					case 0:
					case 3:
						if (item != null)
						{
							isChecked = item.IsChecked;
							goto case 2;
						}
						goto case 1;
					case 1:
					case 4:
						return false;
					default:
						num = 2;
						break;
					case 5:
						return isChecked == flag;
					}
				}
			}).Select([MethodImpl(MethodImplOptions.NoInlining)] (EasyViewTreeItemViewModel item) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (CellViewModel)_003C_003Ec.FCZFpb5J0PS6sc6Q5Vyb(item);
			});
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EasyViewTreeItemViewModel(EasyViewViewModel easyView)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 5:
				DZ60taQV1akT8KGhQuE();
				num = 1;
				if (!PgZ3OkQn6wMrOyZs4RD())
				{
					continue;
				}
				goto default;
			default:
				Jkteeprprf();
				num = 6;
				if (SfCHZQQixGvv03lEVUP())
				{
					continue;
				}
				break;
			case 1:
				break;
			case 2:
			case 4:
				bZpeqEot0o = easyView;
				goto default;
			case 6:
				return;
			}
			base._002Ector();
			PgZ3OkQn6wMrOyZs4RD();
			num = (SfCHZQQixGvv03lEVUP() ? 4 : 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SubscribeToResultCellRefreshed()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (AgPrORQf38nNyPmCs3H(this) != null)
		{
			((CellViewModel)AgPrORQf38nNyPmCs3H(this)).CellRefreshed += ResultCell_CellRefreshed;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void ResultCell_CellRefreshed(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RefreshNodeInformation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool? GetIsChecked()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals2.cellName = ResultCell?.CellName;
		bool valueOrDefault = EasyView?.Settings?.Items?.Any([MethodImpl(MethodImplOptions.NoInlining)] (EasyViewItem it) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return it.CellName == CS_0024_003C_003E8__locals2.cellName;
		}) == true;
		bool flag = TreeNodes?.Any([MethodImpl(MethodImplOptions.NoInlining)] (CheckBoxTreeItemViewModel it) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec.CeHcNw5JW0ABcdgI43hF();
			int num = (_003C_003Ec.SfXxbF5JTxfJnYuGQcDL() ? 2 : 4);
			bool? isChecked = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					isChecked = it.IsChecked;
					num = 5;
					break;
				case 0:
				case 4:
					isChecked = it.IsChecked;
					goto case 1;
				case 1:
				case 2:
					if (!isChecked.HasValue)
					{
						return false;
					}
					goto case 3;
				default:
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					return isChecked.Value;
				}
			}
		}) ?? false;
		if (!valueOrDefault)
		{
			if (!flag)
			{
				return false;
			}
			return null;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIsChecked(bool? value, EzSnippet ezTool)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ResultCell != null)
		{
			if (!IsChecked.HasValue || (value.HasValue && value.Value))
			{
				EasyView?.Settings?.UndoAddItem(ResultCell);
			}
			else if (ezTool != null)
			{
				EasyView?.Settings?.UndoRemoveItems(ezTool.AllProperties);
			}
			else
			{
				EasyView?.Settings?.UndoRemoveItem(ResultCell);
			}
			FIqexqLpPr();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.Dispose();
		eiPe2PMODM();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FIqexqLpPr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FireIsCheckedChangedEvent();
		TreeNodes?.ForEach([MethodImpl(MethodImplOptions.NoInlining)] (CheckBoxTreeItemViewModel child) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			child?.FireIsCheckedChangedEvent();
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YTXev31TJr(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FireIsCheckedChangedEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Jkteeprprf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (EasyView != null)
		{
			G2lbnkQdR3m098Of570(EasyView, new EventHandler(YTXev31TJr));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eiPe2PMODM()
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
			case 0:
				if (EasyView != null)
				{
					SfCHZQQixGvv03lEVUP();
					if (!PgZ3OkQn6wMrOyZs4RD())
					{
						num = 5;
						if (SfCHZQQixGvv03lEVUP())
						{
							break;
						}
						goto case 1;
					}
					num = 4;
					break;
				}
				goto case 2;
			case 1:
			case 5:
				P1grtMQlWGGqsAt0qts(EasyView, new EventHandler(YTXev31TJr));
				num = 2;
				break;
			case 2:
				if (AgPrORQf38nNyPmCs3H(this) != null)
				{
					goto default;
				}
				return;
			default:
				jGM6h1QgfdH0DvqyLBB(AgPrORQf38nNyPmCs3H(this), new EventHandler(ResultCell_CellRefreshed));
				num = 6;
				if (!SfCHZQQixGvv03lEVUP())
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DZ60taQV1akT8KGhQuE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SfCHZQQixGvv03lEVUP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PgZ3OkQn6wMrOyZs4RD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AgPrORQf38nNyPmCs3H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyViewTreeItemViewModel)P_0).ResultCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G2lbnkQdR3m098Of570(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyViewViewModel)P_0).SettingsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P1grtMQlWGGqsAt0qts(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyViewViewModel)P_0).SettingsChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jGM6h1QgfdH0DvqyLBB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).CellRefreshed -= (EventHandler)P_1;
	}
}
