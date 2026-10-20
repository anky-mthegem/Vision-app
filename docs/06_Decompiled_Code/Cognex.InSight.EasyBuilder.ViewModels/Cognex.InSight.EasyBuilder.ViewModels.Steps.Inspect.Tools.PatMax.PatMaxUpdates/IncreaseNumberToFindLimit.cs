using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax.PatMaxUpdates;

public class IncreaseNumberToFindLimit : ISnippetUpdate
{
	private readonly SnippetLocalizer aJfQdkOwMM;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IncreaseNumberToFindLimit(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HiTvnnE4xxUw8V63lfu();
		int num;
		if (!oZkYBNE7tr8My8I4Dt4())
		{
			num = 3;
		}
		else
		{
			num = 1;
			if (false)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				aJfQdkOwMM = localizer;
				num = 5;
				break;
			case 0:
			case 3:
				BJMHrYE3NYx9N47RmU2();
				num = 4;
				break;
			case 4:
				base._002Ector();
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string snippetName = (string)TsrhM6EjXkt5CfNjPi1(originalSnippet);
		return (PasteBuffer)XjNGH3ECAu9xkFsRBbU(new EditArgumentUpdate(originalSnippet.GetCellOffset(EzSnippet.AssembleFullCellName(snippetName, (string)C7Hvd1E66lSnRvX98xJ(20286))), CdQUGaROfy7He9T0foW.KbIzwHEDLa(21586), 1, aJfQdkOwMM), originalSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BJMHrYE3NYx9N47RmU2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HiTvnnE4xxUw8V63lfu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oZkYBNE7tr8My8I4Dt4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TsrhM6EjXkt5CfNjPi1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C7Hvd1E66lSnRvX98xJ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XjNGH3ECAu9xkFsRBbU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditArgumentUpdate)P_0).Apply((PasteBuffer)P_1);
	}
}
