using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.Filmstrip.ViewModels;
using Cognex.InSight.ViDiEL.ViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELClassify;

public class ViDiELClassifierHandle : IClassifierHandle
{
	private readonly InspectStepViewModel xiqSxs4IiZ;

	[CompilerGenerated]
	private string ruQSvgaLhM;

	public string ToolName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ruQSvgaLhM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ruQSvgaLhM = value;
		}
	}

	string IClassifierHandle.InitialImagesPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FilmstripActionsViewModel)u8L6snPQXOcvPnFh4YC(LR2CCUPmXb7VmXvak4L(xsyfbFPxGVkBV9fJel4(xiqSxs4IiZ)))).Path;
		}
	}

	bool IClassifierHandle.InitialImagesPathHasImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FilmstripPanelViewModel)LR2CCUPmXb7VmXvak4L(xsyfbFPxGVkBV9fJel4(xiqSxs4IiZ))).HasImages;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELClassifierHandle(InspectStepViewModel inspect, string toolName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!MteOfsPUwXaj2qffOhO())
		{
			num = 1;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0050;
		IL_0026:
		ToolName = toolName;
		num = 6;
		goto IL_0050;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
			case 5:
				xiqSxs4IiZ = inspect;
				break;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 3;
				continue;
			case 3:
				gL43fIPHiZKTqrmIIrs(this);
				goto case 2;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ViDiELClassifyTool tIlSw5Oihc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xiqSxs4IiZ.Snippets.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qhIoIUP1iteY8cJw5ak(E9tnLbPcO5ocFKjwXDD(P_0), ToolName) && P_0 is ViDiELClassifyTool;
		}) as ViDiELClassifyTool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Classifier IClassifierHandle.GetClassifier()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		Classifier result = default;
		ViDiELClassifyTool viDiELClassifyTool = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				result = (Classifier)wNmTaHPN5lFAGH6brCG(viDiELClassifyTool);
				num = 6;
				if (!MteOfsPUwXaj2qffOhO())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				viDiELClassifyTool = tIlSw5Oihc();
				goto case 2;
			case 5:
				result = null;
				_ = 0;
				num = (gntmn4PYUOqUg2foniF() ? 3 : 4);
				continue;
			case 2:
			case 4:
				if (viDiELClassifyTool == null)
				{
					break;
				}
				goto case 0;
			default:
				num = 0;
				continue;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	CvsCellLocation IClassifierHandle.GetCellLocation()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MteOfsPUwXaj2qffOhO();
		int num;
		if (gntmn4PYUOqUg2foniF())
		{
			num = 2;
			if (MteOfsPUwXaj2qffOhO())
			{
			}
		}
		else
		{
			num = 5;
		}
		ViDiELClassifyTool viDiELClassifyTool = default;
		CvsCellLocation result = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				viDiELClassifyTool = tIlSw5Oihc();
				num = 4;
				continue;
			case 4:
				if (viDiELClassifyTool == null)
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				continue;
			case 0:
			case 2:
				result = CvsCellLocation.Invalid;
				goto case 1;
			case 3:
				result = sWcs6jP2OLO9EMQpQ9u(viDiELClassifyTool);
				num = 6;
				continue;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool g0tSyroXUa(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (qhIoIUP1iteY8cJw5ak(E9tnLbPcO5ocFKjwXDD(P_0), ToolName))
		{
			return P_0 is ViDiELClassifyTool;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gL43fIPHiZKTqrmIIrs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gntmn4PYUOqUg2foniF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MteOfsPUwXaj2qffOhO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xsyfbFPxGVkBV9fJel4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LR2CCUPmXb7VmXvak4L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).Filmstrip;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u8L6snPQXOcvPnFh4YC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FilmstripPanelViewModel)P_0).ActionsVm;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wNmTaHPN5lFAGH6brCG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELClassifyTool)P_0).SpreadsheetTool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation sWcs6jP2OLO9EMQpQ9u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELEzToolBase)P_0).ELFunctionCellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E9tnLbPcO5ocFKjwXDD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qhIoIUP1iteY8cJw5ak(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
