using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Controls;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Runtime.ViewModels.EasyView;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.HMI;

public sealed class EasyViewPassFailViewModel : EasyViewTreeItemViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public EasyViewPassFailViewModel _003C_003E4__this;

		public EasyViewViewModel easyView;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass0_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rnXvb75JkwH082JXjdaE();
			jkDkaS5J8UrtlQ9nAduj(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003C_002Ector_003Eb__0(CellViewModel cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003E4__this.TreeNodes.Add(new EasyViewCellViewModel(cell, easyView));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003C_002Ector_003Eb__1(CheckBoxTreeItemViewModel child)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			child.IsCheckedChanged += _003C_003E4__this.KBqeO9XwtB;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rnXvb75JkwH082JXjdaE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jkDkaS5J8UrtlQ9nAduj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hKEZdo5JoZte5j8q68Mw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U121G05JSOAPS0Tt5E0J()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly JobPassFail f7yeHO0CGT;

	public JobPassFail PassFail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f7yeHO0CGT;
		}
	}

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
			SetIsChecked(value, PassFail);
		}
	}

	public override CellViewModel ResultCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PassFail?.Pass;
		}
	}

	public override bool? PassFailValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PassFail?.Pass?.Value;
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
			JobPassFail passFail = PassFail;
			if (passFail == null)
			{
				return null;
			}
			return (string)vkV4EDQLLo5vVdR718Y(passFail);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EasyViewPassFailViewModel(JobPassFail passFail, EasyViewViewModel easyView)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (Git9r9mtSApIEAHYNlu() ? 10 : 6);
		_003C_003Ec__DisplayClass0_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				ObservableCollection<CheckBoxTreeItemViewModel> treeNodes = TreeNodes;
				if (treeNodes == null)
				{
					num = 5;
					if (V08KWkmhBgmdWrxViun())
					{
						break;
					}
					goto case 4;
				}
				treeNodes.ForEach(obj._003C_002Ector_003Eb__1);
				num = 11;
				break;
			}
			case 4:
			case 10:
				obj._003C_003E4__this = this;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				f7yeHO0CGT = passFail;
				num = 9;
				break;
			case 2:
				obj.easyView = easyView;
				num = 8;
				break;
			case 0:
			case 6:
				TVXwdKmzHm9iKwQq86A();
				num = 7;
				break;
			case 7:
				obj = new _003C_003Ec__DisplayClass0_0();
				num = 2;
				if (V08KWkmhBgmdWrxViun())
				{
					break;
				}
				goto case 9;
			case 9:
				passFail.AllProperties.ForEach(obj._003C_002Ector_003Eb__0);
				SubscribeToResultCellRefreshed();
				num = 1;
				break;
			case 8:
				base._002Ector(obj.easyView);
				goto case 4;
			case 5:
				return;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KBqeO9XwtB(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FireIsCheckedChangedEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TVXwdKmzHm9iKwQq86A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V08KWkmhBgmdWrxViun()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Git9r9mtSApIEAHYNlu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vkV4EDQLLo5vVdR718Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}
}
