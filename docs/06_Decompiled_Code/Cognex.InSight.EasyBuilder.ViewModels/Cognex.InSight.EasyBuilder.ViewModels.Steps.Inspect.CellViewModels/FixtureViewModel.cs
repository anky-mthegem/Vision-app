using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime.ViewModels.Cells;
using PwP36oJrJgiKa1qpQA;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class FixtureViewModel : CellViewModel, QpXw26KT7OGd3H62pw, FhUY4uBLEMII4DUtd7
{
	private string bspyO4kadw;

	private SourceLink Cc6yHlNL65;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Fixture;
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

	public string Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bspyO4kadw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref bspyO4kadw, value, (string)EXdNTtY5MIeBfTNF3iR(5436)))
			{
				FirePropertyChangedExplicit((string)EXdNTtY5MIeBfTNF3iR(27684));
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
			if (Cc6yHlNL65 == null)
			{
				Cc6yHlNL65 = new SourceLink(this);
			}
			return Cc6yHlNL65;
		}
	}

	public IEnumerable<FormatStringArgument> FormatStringArguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			List<FormatStringArgument> list = new List<FormatStringArgument>();
			CvsCellLocation cvsCellLocation = CvsCellLocation.TryParse(RefExpression);
			if (cvsCellLocation.IsValid)
			{
				return new List<FormatStringArgument>
				{
					new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28102), string.Format(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28108), cvsCellLocation), FormatStringDataType.FloatingPoint),
					new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28130), string.Format(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28136), cvsCellLocation), FormatStringDataType.FloatingPoint),
					new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(24406), string.Format(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28158), cvsCellLocation), FormatStringDataType.FloatingPoint)
				};
			}
			if (RefExpression.StartsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28188)))
			{
				string expr = CvsParse.FindArg(RefExpression, 1);
				list.Add(new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28102), expr, FormatStringDataType.FloatingPoint));
				string expr2 = CvsParse.FindArg(RefExpression, 2);
				list.Add(new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28130), expr2, FormatStringDataType.FloatingPoint));
				string expr3 = CvsParse.FindArg(RefExpression, 3);
				list.Add(new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(24406), expr3, FormatStringDataType.FloatingPoint));
			}
			return list;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixtureViewModel(CvsInSight insight, CvsCellCollection cells, string virtualCellName, string refExpression, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!QjhIReMtJ55AVrsX0g3())
		{
			goto IL_001e;
		}
		goto IL_0088;
		IL_001e:
		base._002Ector(insight, virtualCellName, refExpression, displayName);
		QjhIReMtJ55AVrsX0g3();
		if (!Nv9xDyMzLlsp8r0ObeD())
		{
			num = 0;
			if (!QjhIReMtJ55AVrsX0g3())
			{
				goto IL_004a;
			}
		}
		else
		{
			num = 1;
			if (1 == 0)
			{
				return;
			}
		}
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 4:
				goto IL_004a;
			default:
				Refresh(cells);
				num = 6;
				continue;
			case 0:
			case 2:
				Value = (string)RejyUBYKEviXobV6buT();
				goto default;
			case 6:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_004a:
		eTbNXhYLSW10CpKInIw();
		num = 5;
		goto IL_0088;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixtureViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (QjhIReMtJ55AVrsX0g3())
		{
			num = 3;
			if (Nv9xDyMzLlsp8r0ObeD())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0070;
		IL_0070:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 3:
				goto IL_003e;
			case 1:
			case 4:
				goto IL_0053;
			default:
				num = 2;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_003e:
		eTbNXhYLSW10CpKInIw();
		goto IL_0053;
		IL_002a:
		Refresh(cells);
		num = 5;
		if (false)
		{
			goto IL_003e;
		}
		goto IL_0070;
		IL_0053:
		base._002Ector(insight, loc, displayName);
		goto IL_002a;
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
	[CompilerGenerated]
	private void bg8yjr9kjw(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eTbNXhYLSW10CpKInIw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RejyUBYKEviXobV6buT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EE7tlLeh60();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QjhIReMtJ55AVrsX0g3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Nv9xDyMzLlsp8r0ObeD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EXdNTtY5MIeBfTNF3iR(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
