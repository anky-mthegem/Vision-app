using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance.DistanceUpdates;

public class FixTransWorldCalibratePtl : ISnippetUpdate
{
	private static readonly CvsCellLocation mb5WmH5fRY;

	private static readonly CvsCellLocation nTGW1l6Z6G;

	private static readonly CvsCellLocation QBuWz4LON3;

	private static readonly CvsCellLocation VQjjavXlAx;

	private static readonly CvsCellLocation CYJj5oeNSQ;

	private static readonly CvsCellLocation amBjpmKpSr;

	private static readonly CvsCellLocation ynUjUgKNpV;

	private readonly AddCellUpdate HyOj7ctesU;

	private readonly LocationUpdate DeQjNYl7Bu;

	private readonly LocationUpdate rD1jAmiH7L;

	private readonly LocationUpdate SUtjdKALYa;

	private readonly LocationUpdate bdEj6FVP5m;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixTransWorldCalibratePtl(SnippetLocalizer localizer, CvsFunctionTable table, IExpressionConstants constants)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 6:
				rD1jAmiH7L = new LocationUpdate(QBuWz4LON3, mb5WmH5fRY, SnippetUpdateHelper.GetAbsRefLocationOfCell, VQjjavXlAx, table, constants);
				goto case 1;
			case 0:
				bdEj6FVP5m = new LocationUpdate(ynUjUgKNpV, CYJj5oeNSQ, SnippetUpdateHelper.GetAbsRefLocationOfCell, VQjjavXlAx, table, constants);
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				jxXgJIA4oaGEH1bt7N0(this);
				num = 7;
				if (DUE88UAX7bXPnSBJR1T())
				{
				}
				break;
			case 8:
				UMI1GHA9DQIho7B03ob();
				num = 4;
				break;
			case 1:
			case 5:
				SUtjdKALYa = new LocationUpdate(amBjpmKpSr, CYJj5oeNSQ, SnippetUpdateHelper.GetAbsRefLocationOfCell, VQjjavXlAx, table, constants);
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				HyOj7ctesU = new AddCellUpdate(VQjjavXlAx, NdWW8CgxbD, localizer);
				_ = 0;
				num = ((!p16yjPAp4Q1vjJHuW91()) ? 1 : 2);
				break;
			case 2:
			case 3:
				DeQjNYl7Bu = new LocationUpdate(nTGW1l6Z6G, mb5WmH5fRY, SnippetUpdateHelper.GetAbsRefLocationOfCell, VQjjavXlAx, table, constants);
				goto case 6;
			default:
				num = 6;
				if (DUE88UAX7bXPnSBJR1T())
				{
					return;
				}
				break;
			case 9:
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
		p16yjPAp4Q1vjJHuW91();
		int num;
		if (!DUE88UAX7bXPnSBJR1T())
		{
			num = 2;
		}
		else
		{
			num = 7;
			if (DUE88UAX7bXPnSBJR1T())
			{
				goto IL_00cb;
			}
		}
		goto IL_0075;
		IL_0075:
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				pasteBuffer = (PasteBuffer)imynSVA3lZidngGEsV4(SUtjdKALYa, pasteBuffer);
				num = 1;
				continue;
			case 6:
				pasteBuffer = (PasteBuffer)rFGgWhA7dtOoCrJRgBL(HyOj7ctesU, pasteBuffer);
				num = 5;
				continue;
			case 3:
			case 7:
				pasteBuffer = (PasteBuffer)imynSVA3lZidngGEsV4(rD1jAmiH7L, pasteBuffer);
				goto case 4;
			default:
				num = 4;
				continue;
			case 5:
				pasteBuffer = (PasteBuffer)imynSVA3lZidngGEsV4(DeQjNYl7Bu, pasteBuffer);
				goto case 3;
			case 0:
			case 2:
				break;
			case 1:
				pasteBuffer = bdEj6FVP5m.Apply(pasteBuffer);
				num = 8;
				continue;
			case 8:
				return pasteBuffer;
			}
			break;
		}
		goto IL_00cb;
		IL_00cb:
		pasteBuffer = originalSnippet.Clone();
		num = 6;
		goto IL_0075;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell NdWW8CgxbD(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = nt3trSAjsgr4iLjg1pI(P_0, VQjjavXlAx);
		string absRefLocationOfCell = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, CYJj5oeNSQ);
		string absRefLocationOfCell2 = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, mb5WmH5fRY);
		string text = (string)cNATdvACh9eaYyCWJMR(sgrdUZA6kdRc23W0JnF(26910), absRefLocationOfCell, absRefLocationOfCell2);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		lKYNTGAAjcnDmvFEUMq(pasteBufferCell, text);
		lLpXKJARmnLTor11W07(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FixTransWorldCalibratePtl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0038;
		IL_001a:
		VQjjavXlAx = new CvsCellLocation(4, 7);
		goto IL_008b;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 4:
			case 6:
				break;
			default:
				num = 2;
				continue;
			case 5:
				ynUjUgKNpV = new CvsCellLocation(8, 2);
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto IL_008b;
			case 2:
				goto IL_008b;
			case 0:
				UMI1GHA9DQIho7B03ob();
				_ = 1;
				if (!DUE88UAX7bXPnSBJR1T())
				{
					num = 9;
					if (!DUE88UAX7bXPnSBJR1T())
					{
						continue;
					}
					goto case 8;
				}
				num = 6;
				if (true)
				{
					continue;
				}
				return;
			case 8:
				amBjpmKpSr = new CvsCellLocation(8, 1);
				num = 5;
				if (p16yjPAp4Q1vjJHuW91())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 9:
				mb5WmH5fRY = new CvsCellLocation(1, 1);
				num = 3;
				if (p16yjPAp4Q1vjJHuW91())
				{
					continue;
				}
				goto case 3;
			case 3:
				nTGW1l6Z6G = new CvsCellLocation(3, 5);
				num = 7;
				if (p16yjPAp4Q1vjJHuW91())
				{
					continue;
				}
				goto case 7;
			case 7:
				QBuWz4LON3 = new CvsCellLocation(3, 6);
				break;
			case 10:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_008b:
		CYJj5oeNSQ = new CvsCellLocation(8, 0);
		num = 8;
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UMI1GHA9DQIho7B03ob()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jxXgJIA4oaGEH1bt7N0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p16yjPAp4Q1vjJHuW91()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DUE88UAX7bXPnSBJR1T()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rFGgWhA7dtOoCrJRgBL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AddCellUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object imynSVA3lZidngGEsV4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LocationUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation nt3trSAjsgr4iLjg1pI(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sgrdUZA6kdRc23W0JnF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cNATdvACh9eaYyCWJMR(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lKYNTGAAjcnDmvFEUMq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lLpXKJARmnLTor11W07(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}
}
