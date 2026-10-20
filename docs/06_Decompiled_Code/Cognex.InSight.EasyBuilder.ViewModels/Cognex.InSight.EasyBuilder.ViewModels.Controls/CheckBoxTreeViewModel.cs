using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.Extensions;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Controls;

public class CheckBoxTreeViewModel : BaseViewModel, IDisposable
{
	protected static readonly ILogger Log;

	[CompilerGenerated]
	private readonly ObservableCollection<CheckBoxTreeItemViewModel> eyO1fZTBy0;

	[CompilerGenerated]
	private readonly ObservableCollection<CheckBoxTreeItemViewModel> fQb1E18VGK;

	private bool tRw1b357h2;

	private string aAj1cIUUPf;

	public ObservableCollection<CheckBoxTreeItemViewModel> TreeNodes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eyO1fZTBy0;
		}
	}

	public ObservableCollection<CheckBoxTreeItemViewModel> VisibleTreeNodes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fQb1E18VGK;
		}
	}

	public bool AreCheckboxesEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tRw1b357h2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref tRw1b357h2, value, (string)PLXdKtKw0tfYSbdiUvqx(47800));
		}
	}

	public string FilterText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aAj1cIUUPf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref aAj1cIUUPf, value, (string)PLXdKtKw0tfYSbdiUvqx(47844)))
			{
				T501I2rrXB();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CheckBoxTreeViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 7:
				tRw1b357h2 = true;
				B3LvwwKwTl1Dg5LJZOg5();
				num = ((!Xm2ogCKwyviU1YDTBxVe()) ? 4 : 0);
				break;
			case 2:
			case 4:
				aAj1cIUUPf = "";
				goto case 0;
			case 5:
				eyO1fZTBy0 = new ObservableCollection<CheckBoxTreeItemViewModel>();
				num = 6;
				break;
			case 6:
				fQb1E18VGK = new ObservableCollection<CheckBoxTreeItemViewModel>();
				num = 8;
				break;
			case 1:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 7;
				break;
			case 0:
			case 3:
				base._002Ector();
				goto case 5;
			default:
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNode(CheckBoxTreeItemViewModel node)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Xm2ogCKwyviU1YDTBxVe();
		int num;
		if (B3LvwwKwTl1Dg5LJZOg5())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_0075;
			}
		}
		goto IL_0046;
		IL_0046:
		while (true)
		{
			switch (num)
			{
			case 1:
				TreeNodes.Add(node);
				goto IL_0090;
			case 0:
			case 3:
				break;
			default:
				goto IL_0090;
			case 5:
				return;
			}
			break;
			IL_0090:
			T501I2rrXB();
			num = 5;
			if (1 == 0)
			{
				return;
			}
		}
		goto IL_0075;
		IL_0075:
		if (!TreeNodes.Contains(node))
		{
			num = 1;
			goto IL_0046;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveNode(CheckBoxTreeItemViewModel node)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Xm2ogCKwyviU1YDTBxVe())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_0074;
			}
		}
		goto IL_008c;
		IL_0024:
		NyipTkKwFXfngFusiG6r(node);
		num = 6;
		goto IL_008c;
		IL_0074:
		T501I2rrXB();
		goto IL_0024;
		IL_008c:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 1:
			case 3:
				if (!TreeNodes.Remove(node))
				{
					break;
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				if (TreeNodes.Contains(node))
				{
					goto case 1;
				}
				return;
			case 4:
				goto IL_0074;
			default:
				num = 5;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0024;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void T501I2rrXB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0100;
		IL_001a:
		IEnumerator<CheckBoxTreeItemViewModel> enumerator = default;
		List<CheckBoxTreeItemViewModel> list = default;
		try
		{
			while (enumerator.MoveNext())
			{
				CheckBoxTreeItemViewModel current = enumerator.Current;
				int num2 = 3;
				if (!Xm2ogCKwyviU1YDTBxVe())
				{
				}
				while (true)
				{
					switch (num2)
					{
					default:
						current.OyD1oiWYro(FilterText);
						num2 = 5;
						if (0 == 0)
						{
							continue;
						}
						goto case 3;
					case 3:
						if (!Pc18LkKwMySPmNMRfE4o(current, FilterText, current))
						{
							break;
						}
						_ = 0;
						if (B3LvwwKwTl1Dg5LJZOg5())
						{
							num2 = 0;
							if (!Xm2ogCKwyviU1YDTBxVe())
							{
								continue;
							}
							goto case 0;
						}
						num2 = 4;
						continue;
					case 0:
					case 1:
						list.Add(current);
						goto default;
					case 5:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				wZ1EZNKwYcFFt3OI9Alo(enumerator);
			}
		}
		zmc7dCKwUNgnjCRgZV7c(VisibleTreeNodes);
		goto IL_012b;
		IL_0100:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_012b;
			case 1:
			case 5:
				enumerator = TreeNodes.GetEnumerator();
				break;
			case 3:
				goto IL_015d;
			case 6:
				return;
			}
			break;
			IL_015d:
			list = new List<CheckBoxTreeItemViewModel>();
			_ = 0;
			if (!B3LvwwKwTl1Dg5LJZOg5())
			{
				num = 0;
				continue;
			}
			num = 5;
			if (Xm2ogCKwyviU1YDTBxVe())
			{
				return;
			}
		}
		goto IL_001a;
		IL_012b:
		VisibleTreeNodes.AddRange(list);
		num = 6;
		goto IL_0100;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Xm2ogCKwyviU1YDTBxVe();
		int num;
		if (B3LvwwKwTl1Dg5LJZOg5())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_0094;
			}
		}
		goto IL_00b3;
		IL_0032:
		ObservableCollection<CheckBoxTreeItemViewModel> visibleTreeNodes = VisibleTreeNodes;
		if (visibleTreeNodes == null)
		{
			num = 5;
			goto IL_00b3;
		}
		visibleTreeNodes.Clear();
		return;
		IL_0094:
		ObservableCollection<CheckBoxTreeItemViewModel> treeNodes = TreeNodes;
		if (treeNodes != null)
		{
			LNFUbIKwHsM5AKDiawLn(treeNodes);
		}
		goto IL_0032;
		IL_00b3:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 3:
				TreeNodes?.ForEach([MethodImpl(MethodImplOptions.NoInlining)] (CheckBoxTreeItemViewModel node) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					node.Dispose();
				});
				goto IL_0094;
			case 1:
			case 4:
				goto IL_0094;
			default:
				num = 2;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_0032;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CheckBoxTreeViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vWvQV6KwxAoq3Y65cNcG();
		Log = LogManager.GetLogger<CheckBoxTreeViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B3LvwwKwTl1Dg5LJZOg5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xm2ogCKwyviU1YDTBxVe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PLXdKtKw0tfYSbdiUvqx(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NyipTkKwFXfngFusiG6r(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CheckBoxTreeViewModel)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Pc18LkKwMySPmNMRfE4o(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CheckBoxTreeItemViewModel)P_0).fys1SpaZLV((string)P_1, (CheckBoxTreeItemViewModel)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wZ1EZNKwYcFFt3OI9Alo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zmc7dCKwUNgnjCRgZV7c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<CheckBoxTreeItemViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LNFUbIKwHsM5AKDiawLn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<CheckBoxTreeItemViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vWvQV6KwxAoq3Y65cNcG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
