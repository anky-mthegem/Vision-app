using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELRead.Updates;

public class AddFlexFieldingAndCharFindThreshold : ISnippetUpdate
{
	private readonly SnippetLocalizer rUuSQcPNZ6;

	private CvsCellLocation isQSgTaiVk;

	private CvsCellLocation vrdSMPitVP;

	private CvsCellLocation HTkSRK61Wq;

	private CvsCellLocation hhqS4EbMXk;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddFlexFieldingAndCharFindThreshold(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 4:
				isQSgTaiVk = new CvsCellLocation(1, 3);
				_ = 0;
				num = (HCPy62PPrwBYJl0Lcl9() ? 1 : 0);
				continue;
			case 7:
				aJVFyaPBBeN4WOGIi6g();
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				HTkSRK61Wq = new CvsCellLocation(2, 0);
				break;
			default:
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				vrdSMPitVP = new CvsCellLocation(0, 7);
				goto case 0;
			case 6:
				iXdxK5PbRvepewEReo0(this);
				num = 5;
				continue;
			case 5:
				rUuSQcPNZ6 = localizer;
				num = 9;
				if (HCPy62PPrwBYJl0Lcl9())
				{
					continue;
				}
				break;
			case 8:
				break;
			case 9:
				return;
			}
			hhqS4EbMXk = new CvsCellLocation(3, 1);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!m80BEePZVG14ACmNv0L())
		{
		}
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				pasteBuffer = new AddCellUpdate(vrdSMPitVP, QQsSESZchx, rUuSQcPNZ6, replaceCell: true).Apply(pasteBuffer);
				_ = 1;
				num = (m80BEePZVG14ACmNv0L() ? 1 : 5);
				break;
			case 2:
			case 5:
				pasteBuffer = new AddCellUpdate(isQSgTaiVk, zmHSf9kqdk, rUuSQcPNZ6).Apply(pasteBuffer);
				goto case 0;
			default:
				num = 0;
				if (!m80BEePZVG14ACmNv0L())
				{
					break;
				}
				goto case 6;
			case 6:
				pasteBuffer = originalSnippet;
				num = 3;
				break;
			case 0:
				pasteBuffer = new EditArgumentUpdate(HTkSRK61Wq, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return wUvcOFPSHYpkTe0w0WE(P_0, isQSgTaiVk).ToString(absoluteRow: true, absoluteColumn: true);
				}, 10, null).Apply(pasteBuffer);
				goto case 1;
			case 1:
			case 4:
				pasteBuffer = new EditArgumentUpdate(HTkSRK61Wq, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return P_0.GetLocationFromOrigin(vrdSMPitVP).ToString(absoluteRow: true, absoluteColumn: true);
				}, 11, null).Apply(pasteBuffer);
				num = 7;
				break;
			case 7:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell zmHSf9kqdk(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = EzSnippet.AssembleFullCellName((string)SyYdTNPGQU6d0dM6rFs(P_0), (string)Rir9HsPoOBY27KBf8cU(6806));
		CvsCellLocation loc = wUvcOFPSHYpkTe0w0WE(P_0, isQSgTaiVk);
		CvsCellLocation cvsCellLocation = wUvcOFPSHYpkTe0w0WE(P_0, hhqS4EbMXk);
		JObject jObject = new JObject { [(string)Rir9HsPoOBY27KBf8cU(7052)] = 100 };
		Xt6PKIPk43bCrHrp3I1(jObject, Rir9HsPoOBY27KBf8cU(7062), (JToken)0);
		Xt6PKIPk43bCrHrp3I1(jObject, Rir9HsPoOBY27KBf8cU(1524), pnO9vgP86JUONRol4wm(50));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		TTIGgkPqu0B9P34e2b9(pasteBufferCell, CdQUGaROfy7He9T0foW.KbIzwHEDLa(7072));
		vor3FZPEapSUK1tSR1l(pasteBufferCell, text);
		pasteBufferCell.Value = (JToken)pnO9vgP86JUONRol4wm(50);
		yLNG5dPpAdSaWRIIrhl(pasteBufferCell, cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true));
		yGD5sRPXwxS4atrw93Q(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell QQsSESZchx(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = EzSnippet.AssembleFullCellName((string)SyYdTNPGQU6d0dM6rFs(P_0), (string)Rir9HsPoOBY27KBf8cU(6854));
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(vrdSMPitVP);
		CvsCellLocation cvsCellLocation = wUvcOFPSHYpkTe0w0WE(P_0, hhqS4EbMXk);
		JObject jObject = new JObject { [(string)Rir9HsPoOBY27KBf8cU(7104)] = 256 };
		Xt6PKIPk43bCrHrp3I1(jObject, Rir9HsPoOBY27KBf8cU(1524), oh8tleP9o1XKacAkunI(""));
		JObject data = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin)
		{
			Expression = CdQUGaROfy7He9T0foW.KbIzwHEDLa(7126)
		};
		vor3FZPEapSUK1tSR1l(pasteBufferCell, text);
		pasteBufferCell.Value = (JToken)oh8tleP9o1XKacAkunI("");
		yLNG5dPpAdSaWRIIrhl(pasteBufferCell, cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true));
		pasteBufferCell.Data = data;
		CJwDlSP48DAIhX56HCn(pasteBufferCell, oh8tleP9o1XKacAkunI(CdQUGaROfy7He9T0foW.KbIzwHEDLa(7160)));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string cwRSbgMUmc(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wUvcOFPSHYpkTe0w0WE(P_0, isQSgTaiVk).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string IU2SctejZU(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.GetLocationFromOrigin(vrdSMPitVP).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aJVFyaPBBeN4WOGIi6g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iXdxK5PbRvepewEReo0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HCPy62PPrwBYJl0Lcl9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m80BEePZVG14ACmNv0L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SyYdTNPGQU6d0dM6rFs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rir9HsPoOBY27KBf8cU(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation wUvcOFPSHYpkTe0w0WE(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xt6PKIPk43bCrHrp3I1(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pnO9vgP86JUONRol4wm(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TTIGgkPqu0B9P34e2b9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vor3FZPEapSUK1tSR1l(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yLNG5dPpAdSaWRIIrhl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yGD5sRPXwxS4atrw93Q(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oh8tleP9o1XKacAkunI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CJwDlSP48DAIhX56HCn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Style = (JToken)P_1;
	}
}
