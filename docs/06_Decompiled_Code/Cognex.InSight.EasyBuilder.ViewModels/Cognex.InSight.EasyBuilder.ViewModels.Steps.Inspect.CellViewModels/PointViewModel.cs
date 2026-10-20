using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using DUIE9v8SVGR17TWQwQ;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class PointViewModel : CellViewModel, edFbVBhD6RDc8FLg4U, QpXw26KT7OGd3H62pw
{
	[CompilerGenerated]
	private CvsDisplayablePoint yUZxeItV5X;

	private string iWax2mR940;

	private SourceLink W9RxqiSwmA;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Point;
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
			return true;
		}
	}

	public CvsDisplayablePoint Point
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yUZxeItV5X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yUZxeItV5X = value;
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
			return iWax2mR940;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref iWax2mR940, value, (string)MkIIGbHeY8wfyuE95rC(5436)))
			{
				ETb97HHOn3QuZNZ579k(this, MkIIGbHeY8wfyuE95rC(27684));
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

	SourceLink QpXw26KT7OGd3H62pw.SourceLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (W9RxqiSwmA == null)
			{
				W9RxqiSwmA = new SourceLink(this);
			}
			return W9RxqiSwmA;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PointViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (fWtiRCHK5RMnCAfjAWv())
		{
			num = 4;
		}
		else
		{
			num = 5;
			if (1 == 0)
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
				num = 6;
				break;
			case 1:
			case 5:
				base._002Ector(insight, loc, displayName);
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				Point = EditableGraphicHelper.ConstructPoint(loc, cells);
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				UW3DWYHwWUWjNLUGogG();
				goto case 1;
			case 6:
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
		RefreshStringValue([MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Value = P_0;
		}, cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshGraphic(CvsCellCollection cells, bool pass, CvsCellLocation inputImageCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		F5cCS2HamNO10JGZX5L(Point, oLUDhmHJmZbjWWdFoZ5(cells, inputImageCell));
		EditableGraphicHelper.UpdatePoint(Point, cells, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void B39xylGc5b(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UW3DWYHwWUWjNLUGogG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fWtiRCHK5RMnCAfjAWv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rhPSbKH5ExkfsA0y2po()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oLUDhmHJmZbjWWdFoZ5(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F5cCS2HamNO10JGZX5L(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MkIIGbHeY8wfyuE95rC(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ETb97HHOn3QuZNZ579k(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}
}
