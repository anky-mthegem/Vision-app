using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId.ReadIdUpdates;

public class FailOnNoResultsUpdate : ISnippetUpdate
{
	private readonly CvsCellLocation L47ETfKaJg;

	private readonly CvsCellLocation l20EWy6gAM;

	private readonly CvsCellLocation La2Ej6FKUb;

	private readonly SnippetLocalizer cPwECUKrIM;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FailOnNoResultsUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 0:
				l20EWy6gAM = new CvsCellLocation(2, 0);
				num = 6;
				break;
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 1;
				break;
			case 2:
			case 4:
				l8KUMeSMPjN0LbtdwQX(this);
				goto case 5;
			case 5:
			case 7:
				cPwECUKrIM = localizer;
				num = 8;
				break;
			case 6:
				La2Ej6FKUb = new CvsCellLocation(20, 7);
				goto default;
			default:
				_ = 1;
				num = ((!aBxXkhSFJqSRBynCPBK()) ? 2 : 7);
				break;
			case 1:
				L47ETfKaJg = new CvsCellLocation(18, 4);
				num = 0;
				break;
			case 8:
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
		return new AddCellUpdate(L47ETfKaJg, BL3El3OhMr, cPwECUKrIM, replaceCell: true).Apply(originalSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell BL3El3OhMr(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!TnWPO7S0Y8FuuoGnGdX()) ? 7 : 2);
		CvsCellLocation cvsCellLocation = default;
		PasteBufferCell pasteBufferCell = default;
		CvsCellLocation locationFromOrigin = default;
		string text = default;
		string text2 = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				cvsCellLocation = sQTsb4SYI26pXmhJXle(P_0, La2Ej6FKUb);
				goto default;
			case 3:
				pasteBufferCell = (PasteBufferCell)WidV0tSUaR15XElxPdM(P_0, locationFromOrigin);
				num = 5;
				break;
			case 0:
			case 2:
				locationFromOrigin = P_0.GetLocationFromOrigin(L47ETfKaJg);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				pasteBufferCell.Expression = (string)juYtbgSxfsLPZ7WkaWU(new string[5]
				{
					(string)HSAuQwSHnsix1tZlfwl(19078),
					text,
					(string)HSAuQwSHnsix1tZlfwl(19104),
					text2,
					(string)HSAuQwSHnsix1tZlfwl(19124)
				});
				num = 9;
				break;
			default:
				text2 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 3;
				break;
			case 6:
				cvsCellLocation = sQTsb4SYI26pXmhJXle(P_0, l20EWy6gAM);
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
				text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 8;
				break;
			case 9:
				return pasteBufferCell;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l8KUMeSMPjN0LbtdwQX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TnWPO7S0Y8FuuoGnGdX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aBxXkhSFJqSRBynCPBK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation sQTsb4SYI26pXmhJXle(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WidV0tSUaR15XElxPdM(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellAt(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HSAuQwSHnsix1tZlfwl(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object juYtbgSxfsLPZ7WkaWU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}
}
