using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public class ToolCategory : BaseViewModel
{
	[CompilerGenerated]
	private string jsouw0SDLV;

	private bool onCuyA5jFv;

	[CompilerGenerated]
	private bool Q9GuxPRt6a;

	[CompilerGenerated]
	private readonly ObservableCollection<ToolCategory> SC1uvlhYG6;

	[CompilerGenerated]
	private readonly ObservableCollection<EzToolType> nq5ue2VbTe;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jsouw0SDLV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jsouw0SDLV = value;
		}
	}

	public bool IsExpanded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return onCuyA5jFv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref onCuyA5jFv, value, (string)VngqW5sI9iXecX6phCy(5324));
		}
	}

	public bool IsSelected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Q9GuxPRt6a;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q9GuxPRt6a = value;
		}
	}

	public ObservableCollection<ToolCategory> Categories
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SC1uvlhYG6;
		}
	}

	public ObservableCollection<EzToolType> Tools
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nq5ue2VbTe;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolCategory()
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
				i9sdrUsJ4xcQh3hlbBS();
				num = 1;
				break;
			case 1:
				SC1uvlhYG6 = new ObservableCollection<ToolCategory>();
				_ = 0;
				if (vyUxges5PEoCZBpvcPS())
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto default;
				}
				num = 0;
				if (false)
				{
					return;
				}
				break;
			default:
				base._002Ector();
				num = 6;
				if (vyUxges5PEoCZBpvcPS())
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				nq5ue2VbTe = new ObservableCollection<EzToolType>();
				goto default;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolCategory(ToolCategory category)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
				Categories.AddRange(category.Categories);
				num = 10;
				break;
			case 1:
				IsSelected = category.IsSelected;
				num = 0;
				break;
			case 7:
				IsExpanded = dmiD1dsO4W04X2mQvGB(category);
				num = 1;
				break;
			case 10:
				Tools.AddRange(category.Tools);
				num = 11;
				break;
			case 8:
				Name = (string)iPOpZgseoiLcePrqZMD(category);
				goto case 7;
			default:
				num = 7;
				break;
			case 3:
			case 5:
				rMrOQwsa9LHmtXvbioq(this);
				num = 8;
				if (!vFoNJUswdT72YOweOtU())
				{
					break;
				}
				goto case 2;
			case 2:
			case 6:
				nq5ue2VbTe = new ObservableCollection<EzToolType>();
				goto case 3;
			case 4:
				i9sdrUsJ4xcQh3hlbBS();
				num = 9;
				break;
			case 9:
				SC1uvlhYG6 = new ObservableCollection<ToolCategory>();
				vFoNJUswdT72YOweOtU();
				num = (vyUxges5PEoCZBpvcPS() ? 6 : 5);
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetToDefault()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IsExpanded = false;
		IsSelected = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i9sdrUsJ4xcQh3hlbBS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vyUxges5PEoCZBpvcPS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vFoNJUswdT72YOweOtU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rMrOQwsa9LHmtXvbioq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iPOpZgseoiLcePrqZMD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ToolCategory)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dmiD1dsO4W04X2mQvGB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ToolCategory)P_0).IsExpanded;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VngqW5sI9iXecX6phCy(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
