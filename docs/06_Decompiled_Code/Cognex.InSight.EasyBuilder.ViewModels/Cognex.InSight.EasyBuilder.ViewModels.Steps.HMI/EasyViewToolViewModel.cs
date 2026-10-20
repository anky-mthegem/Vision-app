using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Controls;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.EasyView;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.HMI;

public sealed class EasyViewToolViewModel : EasyViewTreeItemViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public EasyViewToolViewModel _003C_003E4__this;

		public EasyViewViewModel easyView;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass0_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NP5Ycy5Jp961euov9k8J();
			maIMa85JXTci1A2ujY15(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003C_002Ector_003Eb__1(CellViewModel cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003E4__this.TreeNodes.Add(new EasyViewCellViewModel(cell, easyView));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003C_002Ector_003Eb__2(CheckBoxTreeItemViewModel child)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lII87t5J9sTL34ckwPVV(child, new EventHandler(_003C_003E4__this.CoCewTyiCJ));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NP5Ycy5Jp961euov9k8J()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void maIMa85JXTci1A2ujY15(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CVR2xN5JqH5NZw898Igj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A32oDW5JEuxHH4CfMrlV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lII87t5J9sTL34ckwPVV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CheckBoxTreeItemViewModel)P_0).IsCheckedChanged += (EventHandler)P_1;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CellViewModel, bool> _003C_003E9__0_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
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
			DXBQUN5J3cqbbKeLgadr(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_002Ector_003Eb__0_0(CellViewModel cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !fLPPXL5JjpDAmRaWruoE(cell);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Nd4rfi5J4nnHiG9eUgH0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vBG7DG5J7bXdcb3kkYPO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DXBQUN5J3cqbbKeLgadr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fLPPXL5JjpDAmRaWruoE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).Internal;
		}
	}

	[CompilerGenerated]
	private readonly EzTool SGNeyIsvW1;

	public EzTool Tool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SGNeyIsvW1;
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
			SetIsChecked(value, Tool);
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
			EzTool tool = Tool;
			if (tool == null)
			{
				return null;
			}
			return (CellViewModel)lZ4LC1QJwM9Sc49I3f6(tool);
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
			EzTool tool = Tool;
			if (tool == null)
			{
				return null;
			}
			return (string)hYew7lQaJhpbwxiX28A(tool);
		}
	}

	public override string ImageSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EzTool tool = Tool;
			if (tool == null)
			{
				return null;
			}
			return (string)LY8wHGQeOAKtYBd49wX(tool);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EasyViewToolViewModel(EzTool tool, EasyViewViewModel easyView)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003C_003Ec__DisplayClass0_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				base._002Ector(obj.easyView);
				obj._003C_003E4__this = this;
				num = 0;
				break;
			case 8:
				return;
			case 1:
			case 5:
				obj = new _003C_003Ec__DisplayClass0_0();
				num = 9;
				break;
			case 2:
				SubscribeToResultCellRefreshed();
				num = 10;
				break;
			case 7:
				tool.AllProperties.Where([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel cell) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return !_003C_003Ec.fLPPXL5JjpDAmRaWruoE(cell);
				}).ForEach(obj._003C_002Ector_003Eb__1);
				num = 2;
				if (pTVThbQ5Q7kPqBGqTTf())
				{
				}
				break;
			case 6:
				rgGRhaQwM87oKgMCeLp();
				pTVThbQ5Q7kPqBGqTTf();
				num = ((!PtXWmWQKCrDYA8LxCXu()) ? 4 : 5);
				break;
			case 0:
				SGNeyIsvW1 = tool;
				goto case 7;
			default:
				num = 7;
				break;
			case 9:
				obj.easyView = easyView;
				goto case 3;
			case 10:
			{
				ObservableCollection<CheckBoxTreeItemViewModel> treeNodes = TreeNodes;
				if (treeNodes != null)
				{
					treeNodes.ForEach(obj._003C_002Ector_003Eb__2);
					num = 11;
					break;
				}
				num = 8;
				if (!PtXWmWQKCrDYA8LxCXu())
				{
					return;
				}
				break;
			}
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CoCewTyiCJ(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		CheckBoxTreeItemViewModel checkBoxTreeItemViewModel = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				FireIsCheckedChangedEvent();
				num = 6;
				break;
			case 0:
			case 1:
				if (checkBoxTreeItemViewModel != null)
				{
					goto case 2;
				}
				return;
			case 2:
			case 4:
				if (BVHeshQDaa26UrutV5u(xLOSwKQOJYBy1iDJVk4(checkBoxTreeItemViewModel), ((CellViewModel)OL5JD0QIkWO6mgKZL4d(this)).DisplayName))
				{
					goto case 3;
				}
				return;
			default:
				num = 3;
				if (PtXWmWQKCrDYA8LxCXu())
				{
					break;
				}
				goto case 5;
			case 5:
				checkBoxTreeItemViewModel = P_0 as CheckBoxTreeItemViewModel;
				PtXWmWQKCrDYA8LxCXu();
				if (pTVThbQ5Q7kPqBGqTTf())
				{
					num = 4;
					if (PtXWmWQKCrDYA8LxCXu())
					{
						break;
					}
					goto case 2;
				}
				num = 0;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rgGRhaQwM87oKgMCeLp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PtXWmWQKCrDYA8LxCXu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pTVThbQ5Q7kPqBGqTTf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lZ4LC1QJwM9Sc49I3f6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).ResultCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hYew7lQaJhpbwxiX28A(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LY8wHGQeOAKtYBd49wX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).ImagePath;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xLOSwKQOJYBy1iDJVk4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CheckBoxTreeItemViewModel)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OL5JD0QIkWO6mgKZL4d(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyViewTreeItemViewModel)P_0).ResultCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BVHeshQDaa26UrutV5u(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
