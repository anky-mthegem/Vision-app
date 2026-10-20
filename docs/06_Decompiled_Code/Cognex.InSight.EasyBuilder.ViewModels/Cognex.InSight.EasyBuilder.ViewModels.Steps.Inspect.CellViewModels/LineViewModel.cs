using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Graphic;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using DUIE9v8SVGR17TWQwQ;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class LineViewModel : CellViewModel, edFbVBhD6RDc8FLg4U, QpXw26KT7OGd3H62pw
{
	[CompilerGenerated]
	private CvsDisplayableLine iocxbvpv9y;

	private string fXwxck8VWL;

	private SourceLink G1QxQWsM6I;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Line;
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

	public CvsDisplayableLine Line
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iocxbvpv9y;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iocxbvpv9y = value;
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
			return fXwxck8VWL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref fXwxck8VWL, value, (string)GRhQ5SU0FYToal3IU2b(5436)))
			{
				MmqcOgUFkj9sMM0rGjS(this, GRhQ5SU0FYToal3IU2b(27684));
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
			if (G1QxQWsM6I == null)
			{
				G1QxQWsM6I = new SourceLink(this);
			}
			return G1QxQWsM6I;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			IL_0076:
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector(insight, loc, displayName);
				goto case 0;
			case 4:
				while (true)
				{
					O2APmoUCeVimsobKAaQ();
					eFTiN0U6FygIYLSGgwc();
					if (Er2oEtUj122LLk3aiJC())
					{
						break;
					}
					num = 0;
					if (1 == 0)
					{
						continue;
					}
					goto IL_0076;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				Line = EditableGraphicHelper.ConstructLine(loc, cells);
				break;
			default:
				num = 5;
				continue;
			case 5:
				break;
			case 6:
				return;
			}
			Refresh(cells, init: true);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, bool showStartArrow, bool showEndArrow)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		O2APmoUCeVimsobKAaQ();
		this._002Ector(insight, cells, loc, displayName);
		k3eCVHURo0jbUpTS8Jw(gxBmR6UAbxLSum7AsuL(Line), showStartArrow ? CvsGraphicLineAdornment.Arrowhead : CvsGraphicLineAdornment.None);
		QjtjFTUWv6FGgk4rijI(gxBmR6UAbxLSum7AsuL(Line), showEndArrow ? CvsGraphicLineAdornment.Arrowhead : CvsGraphicLineAdornment.None);
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
		rtxGGhUyfJSDYoDJDyh(Line, UJktkVUTjgcDG5K9abE(cells, inputImageCell));
		EditableGraphicHelper.UpdateLine(Line, cells, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void ds4xI62XkF(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O2APmoUCeVimsobKAaQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Er2oEtUj122LLk3aiJC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eFTiN0U6FygIYLSGgwc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gxBmR6UAbxLSum7AsuL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableLine)P_0).Line;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k3eCVHURo0jbUpTS8Jw(object P_0, CvsGraphicLineAdornment P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicLine)P_0).StartPointAdornment = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QjtjFTUWv6FGgk4rijI(object P_0, CvsGraphicLineAdornment P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicLine)P_0).EndPointAdornment = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UJktkVUTjgcDG5K9abE(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rtxGGhUyfJSDYoDJDyh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GRhQ5SU0FYToal3IU2b(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MmqcOgUFkj9sMM0rGjS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}
}
