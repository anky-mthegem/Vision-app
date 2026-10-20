using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PixelCount.PixelCountUpdates;

public class ErrFreeRangeLimitMax : ISnippetUpdate
{
	private readonly SnippetLocalizer OwRb3tGSs3;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ErrFreeRangeLimitMax(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!MSNdBFkmEj6adhgRrOZ())
		{
			goto IL_001e;
		}
		goto IL_0036;
		IL_001e:
		base._002Ector();
		goto IL_0063;
		IL_0036:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			default:
				goto IL_0063;
			case 3:
				goto IL_0074;
			case 5:
				return;
			}
			break;
			IL_0074:
			Ge1PuXkN8jNUbx5cdXY();
			_ = 0;
			num = ((!MSNdBFkmEj6adhgRrOZ()) ? 4 : 0);
		}
		goto IL_001e;
		IL_0063:
		OwRb3tGSs3 = localizer;
		num = 5;
		goto IL_0036;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = (string)GMuY3ek2o4W4D59tONi(originalSnippet);
		CvsCellLocation cellOffset = originalSnippet.GetCellOffset((string)ITfOUAk1rbOV8p8FumE(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1044), text, LGJrnskckVR59BeTkYS(19666)));
		CvsCellLocation cvsCellLocation = iHg5aAkuHlMJq3dNVvd(originalSnippet, ITfOUAk1rbOV8p8FumE(LGJrnskckVR59BeTkYS(1044), text, LGJrnskckVR59BeTkYS(19692)));
		string newArg = (string)ITfOUAk1rbOV8p8FumE(LGJrnskckVR59BeTkYS(8126), cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true), LGJrnskckVR59BeTkYS(19718));
		return new EditArgumentUpdate(cellOffset, newArg, 0, OwRb3tGSs3).Apply(originalSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ge1PuXkN8jNUbx5cdXY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MSNdBFkmEj6adhgRrOZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fENpVIkQaP2X47iHPrx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GMuY3ek2o4W4D59tONi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LGJrnskckVR59BeTkYS(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ITfOUAk1rbOV8p8FumE(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation iHg5aAkuHlMJq3dNVvd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellLocation((string)P_1);
	}
}
