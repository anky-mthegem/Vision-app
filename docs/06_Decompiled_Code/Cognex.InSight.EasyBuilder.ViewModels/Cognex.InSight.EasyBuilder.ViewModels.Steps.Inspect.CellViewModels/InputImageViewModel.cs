using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.Cells;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class InputImageViewModel : InputStructureViewModel
{
	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Image;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputImageViewModel(EzTool tool, CvsCellCollection cells, CvsCellLocation loc, string displayName, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_004a;
		IL_001a:
		RefreshLinks(updateMember: true);
		num = 7;
		goto IL_004a;
		IL_004a:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 2:
				DefaultLink = zyoyrMiLGb(cells);
				goto case 6;
			default:
				num = 6;
				if (w6muoiYAw2B0NXwrPna())
				{
					continue;
				}
				goto case 4;
			case 4:
				UC02MrYWuZlB9qhwkiB();
				_ = 1;
				if (!mrNrWyYRIeU6NI3mdI8())
				{
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				}
				num = 0;
				if (w6muoiYAw2B0NXwrPna())
				{
					continue;
				}
				goto case 6;
			case 1:
			case 5:
				base._002Ector(tool, loc, displayName, isInitialized);
				goto case 0;
			case 6:
				Refresh(cells, init: true);
				num = 3;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SourceLink zyoyrMiLGb(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation cvsCellLocation = S34adFY0H4iHvkK7Hjn(mXbxXTYywuGXkPEUxtT(EvVeLhYTG2dDepfHj5l(Tool)));
		return new SourceLink(Resources.Acquired, cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true), CellType.Image);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UC02MrYWuZlB9qhwkiB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w6muoiYAw2B0NXwrPna()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mrNrWyYRIeU6NI3mdI8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EvVeLhYTG2dDepfHj5l(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).Parent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mXbxXTYywuGXkPEUxtT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation S34adFY0H4iHvkK7Hjn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).Acquired2DImageLocation;
	}
}
