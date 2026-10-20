using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax;

public class AddScoreCellUpdate : ISnippetUpdate
{
	private readonly AddCellUpdate klVbflO9nk;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddScoreCellUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JZQD8QktaWm5EC2ljsO();
		int num = ((!nts81hkhVCpv5UxgiF6()) ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				SOSnLt8LIdQwPGPpF8q(this);
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				klVbflO9nk = new AddCellUpdate(new CvsCellLocation(5, 3), IGxbIOi318, localizer);
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				u7Nbnakz5a0dbyr8B7a();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell IGxbIOi318(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nts81hkhVCpv5UxgiF6();
		int num = (JZQD8QktaWm5EC2ljsO() ? 7 : 6);
		CvsCellLocation loc = default;
		string text = default;
		CvsCellLocation cvsCellLocation = default;
		string snippetName = default;
		while (true)
		{
			switch (num)
			{
			default:
				loc.Column += 3;
				num = 1;
				break;
			case 1:
				text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 8;
				if (nts81hkhVCpv5UxgiF6())
				{
					break;
				}
				goto case 3;
			case 3:
				cvsCellLocation = U5RB9l8whNNA8yuLpxf(P_0, EzSnippet.AssembleFullCellName(snippetName, (string)o9oBjZ85iGj24K7ZK2m(19732)));
				num = 5;
				break;
			case 2:
				loc.Row += 5;
				goto default;
			case 0:
			case 6:
				snippetName = (string)gHb5fB8KCac8K1gOIq6(P_0);
				num = 3;
				break;
			case 5:
				loc = BbY3nZ8J2Yh9uCIuxjL(P_0);
				num = 2;
				break;
			case 8:
			{
				PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
				xvD91M8elb7MxcF5LUH(pasteBufferCell, HvL7Su8abZPm9ZZtNME(o9oBjZ85iGj24K7ZK2m(19760), text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(19782)));
				oK0yMG8O1O0ZoftT2Cp(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, (string)o9oBjZ85iGj24K7ZK2m(19792)));
				return pasteBufferCell;
			}
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
		return (PasteBuffer)UCxwES8ILQkDWWDicgS(klVbflO9nk, originalSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u7Nbnakz5a0dbyr8B7a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SOSnLt8LIdQwPGPpF8q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nts81hkhVCpv5UxgiF6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JZQD8QktaWm5EC2ljsO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gHb5fB8KCac8K1gOIq6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o9oBjZ85iGj24K7ZK2m(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation U5RB9l8whNNA8yuLpxf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellLocation((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation BbY3nZ8J2Yh9uCIuxjL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HvL7Su8abZPm9ZZtNME(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xvD91M8elb7MxcF5LUH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oK0yMG8O1O0ZoftT2Cp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UCxwES8ILQkDWWDicgS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AddCellUpdate)P_0).Apply((PasteBuffer)P_1);
	}
}
