using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance.DistanceUpdates;

public class FixTransWorldCalibrateLtl : ISnippetUpdate
{
	private static readonly CvsCellLocation suGWPZfCO0;

	private static readonly CvsCellLocation qLfWsocyD2;

	private static readonly CvsCellLocation Tj0WKgl6YD;

	private static readonly CvsCellLocation dnuWGHE1lW;

	private static readonly CvsCellLocation E2WWBGDPGn;

	private static readonly CvsCellLocation wYfWZ9H9Cu;

	private static readonly CvsCellLocation AD4WnZxkSc;

	private static readonly CvsCellLocation XbhWtDTutb;

	private static readonly CvsCellLocation hRKWYnFE4e;

	private readonly AddCellUpdate T3SW06amRM;

	private readonly LocationUpdate YqnWVbuPDd;

	private readonly LocationUpdate VsVWLup8Uk;

	private readonly LocationUpdate qrXWJVNmSH;

	private readonly LocationUpdate bBXW9mdpXD;

	private readonly LocationUpdate Xa6WrxomDT;

	private readonly LocationUpdate uKeWhaXUMq;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixTransWorldCalibrateLtl(SnippetLocalizer localizer, CvsFunctionTable table, IExpressionConstants constants)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 10:
				VsVWLup8Uk = new LocationUpdate(Tj0WKgl6YD, suGWPZfCO0, SnippetUpdateHelper.GetAbsRefLocationOfCell, hRKWYnFE4e, table, constants);
				goto case 7;
			default:
				num = 7;
				break;
			case 5:
			case 6:
				bBXW9mdpXD = new LocationUpdate(E2WWBGDPGn, wYfWZ9H9Cu, SnippetUpdateHelper.GetAbsRefLocationOfCell, hRKWYnFE4e, table, constants);
				num = 4;
				break;
			case 2:
				GPfUuwAGLZ4i6C7dh41();
				num = 8;
				break;
			case 8:
				m76aFmAoUW0yYTlbxEx(this);
				num = 1;
				break;
			case 0:
				uKeWhaXUMq = new LocationUpdate(XbhWtDTutb, wYfWZ9H9Cu, SnippetUpdateHelper.GetAbsRefLocationOfCell, hRKWYnFE4e, table, constants);
				num = 11;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
			case 9:
				YqnWVbuPDd = new LocationUpdate(qLfWsocyD2, suGWPZfCO0, SnippetUpdateHelper.GetAbsRefLocationOfCell, hRKWYnFE4e, table, constants);
				num = 10;
				break;
			case 1:
				T3SW06amRM = new AddCellUpdate(hRKWYnFE4e, hfhWkN1Csy, localizer);
				lxY5OQABa9O1l3WhMdZ();
				num = (b4WPaaAbdt8OTcNO2K6() ? 5 : 9);
				break;
			case 7:
				qrXWJVNmSH = new LocationUpdate(dnuWGHE1lW, wYfWZ9H9Cu, SnippetUpdateHelper.GetAbsRefLocationOfCell, hRKWYnFE4e, table, constants);
				goto case 5;
			case 4:
				Xa6WrxomDT = new LocationUpdate(AD4WnZxkSc, wYfWZ9H9Cu, SnippetUpdateHelper.GetAbsRefLocationOfCell, hRKWYnFE4e, table, constants);
				num = 0;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				pasteBuffer = VsVWLup8Uk.Apply(pasteBuffer);
				num = 8;
				break;
			case 4:
			case 6:
				pasteBuffer = (PasteBuffer)o8QvsLAkULRb7wtHZ6S(Xa6WrxomDT, pasteBuffer);
				num = 5;
				break;
			case 7:
				pasteBuffer = (PasteBuffer)o8QvsLAkULRb7wtHZ6S(bBXW9mdpXD, pasteBuffer);
				goto case 4;
			case 8:
				pasteBuffer = (PasteBuffer)o8QvsLAkULRb7wtHZ6S(qrXWJVNmSH, pasteBuffer);
				goto case 7;
			default:
				num = 7;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				pasteBuffer = T3SW06amRM.Apply(pasteBuffer);
				lxY5OQABa9O1l3WhMdZ();
				if (b4WPaaAbdt8OTcNO2K6())
				{
					num = 4;
					break;
				}
				num = 9;
				if (!b4WPaaAbdt8OTcNO2K6())
				{
					break;
				}
				goto case 1;
			case 1:
				pasteBuffer = (PasteBuffer)WiomfTASB3viSQ5h6SD(originalSnippet);
				num = 0;
				break;
			case 5:
				pasteBuffer = (PasteBuffer)o8QvsLAkULRb7wtHZ6S(uKeWhaXUMq, pasteBuffer);
				num = 10;
				if (!b4WPaaAbdt8OTcNO2K6())
				{
					break;
				}
				goto case 2;
			case 2:
			case 9:
				pasteBuffer = (PasteBuffer)o8QvsLAkULRb7wtHZ6S(YqnWVbuPDd, pasteBuffer);
				num = 3;
				break;
			case 10:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell hfhWkN1Csy(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(hRKWYnFE4e);
		string text = string.Format(arg0: SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, wYfWZ9H9Cu), arg1: SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, suGWPZfCO0), format: (string)jHKoc6A8uf8NDqQXn4B(26910));
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
		o4b8bdAqqPqeopWMmeI(pasteBufferCell, text);
		Sw7SZZAEeMHITrBUufF(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FixTransWorldCalibrateLtl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		while (true)
		{
			switch (num)
			{
			case 8:
				AD4WnZxkSc = new CvsCellLocation(6, 6);
				num = 3;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				E2WWBGDPGn = new CvsCellLocation(5, 7);
				goto case 9;
			default:
				num = 9;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				hRKWYnFE4e = new CvsCellLocation(7, 7);
				num = 11;
				break;
			case 5:
				qLfWsocyD2 = new CvsCellLocation(1, 7);
				num = 7;
				break;
			case 7:
				Tj0WKgl6YD = new CvsCellLocation(2, 7);
				dnuWGHE1lW = new CvsCellLocation(5, 6);
				goto case 2;
			case 9:
				wYfWZ9H9Cu = new CvsCellLocation(6, 5);
				num = 8;
				break;
			case 10:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				_ = 1;
				if (b4WPaaAbdt8OTcNO2K6())
				{
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 9;
				}
				num = 0;
				if (lxY5OQABa9O1l3WhMdZ())
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				suGWPZfCO0 = new CvsCellLocation(1, 1);
				num = 5;
				break;
			case 3:
				XbhWtDTutb = new CvsCellLocation(6, 7);
				num = 6;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GPfUuwAGLZ4i6C7dh41()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m76aFmAoUW0yYTlbxEx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lxY5OQABa9O1l3WhMdZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b4WPaaAbdt8OTcNO2K6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WiomfTASB3viSQ5h6SD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o8QvsLAkULRb7wtHZ6S(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LocationUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jHKoc6A8uf8NDqQXn4B(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o4b8bdAqqPqeopWMmeI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Sw7SZZAEeMHITrBUufF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}
}
