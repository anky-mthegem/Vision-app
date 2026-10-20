using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight;
using Cognex.InSight.EasyBuilder.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace SBuh9qWVuQSChmKUHq;

internal class dM56x35dlwOvRXNG9K : ISnippetUpdate
{
	private static readonly CvsCellLocation dsbQUXvTSm;

	private static readonly CvsCellLocation wwIQ7h416I;

	private readonly AddCellUpdate ttFQNhWVh1;

	private readonly EditArgumentUpdate hB3QAivh3I;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public dM56x35dlwOvRXNG9K(SnippetLocalizer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
				ttFQNhWVh1 = new AddCellUpdate(dsbQUXvTSm, BYMQ5BPITG, P_0);
				goto default;
			case 4:
				lGFtbREou2SYqm2kL4N();
				vohRO1EbFJd6YGmha2M();
				num = (f1JYBPEGtZBIe6mJKKZ() ? 5 : 0);
				break;
			default:
				hB3QAivh3I = new EditArgumentUpdate(wwIQ7h416I, yubQpMq2ee, 0, P_0);
				num = 6;
				break;
			case 0:
			case 1:
				qsoT6VESDq3dLSNhiEX(this);
				num = 2;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0068;
		IL_001a:
		PasteBuffer pasteBuffer = P_0;
		_ = 1;
		num = (f1JYBPEGtZBIe6mJKKZ() ? 3 : 4);
		goto IL_0068;
		IL_0068:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			default:
				goto IL_0032;
			case 1:
			case 4:
				pasteBuffer = ttFQNhWVh1.Apply(pasteBuffer);
				goto IL_0032;
			case 5:
				return pasteBuffer;
			}
			break;
			IL_0032:
			pasteBuffer = hB3QAivh3I.Apply(pasteBuffer);
			num = 5;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell BYMQ5BPITG(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		string text2 = default;
		CvsCellLocation cvsCellLocation = default;
		string text6 = default;
		string snippetName = default;
		string text3 = default;
		string text5 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				text2 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				goto default;
			case 7:
				cvsCellLocation = iMNhb6E8sgZXftV9eBy(P_0, text6);
				num = 2;
				break;
			default:
				text6 = EzSnippet.AssembleFullCellName(snippetName, (string)IYEgrIEq8s9b4AuO1ZY(6096));
				num = 7;
				break;
			case 2:
				text3 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 9;
				break;
			case 8:
				snippetName = (string)quxTIrEkXmadXNdW7HJ(P_0);
				num = 6;
				if (f1JYBPEGtZBIe6mJKKZ())
				{
				}
				break;
			case 0:
				cvsCellLocation = iMNhb6E8sgZXftV9eBy(P_0, text5);
				_ = 0;
				if (!vohRO1EbFJd6YGmha2M())
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 7;
				}
				num = 1;
				if (vohRO1EbFJd6YGmha2M())
				{
					break;
				}
				goto case 6;
			case 6:
				text5 = EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(19732));
				num = 0;
				break;
			case 9:
			{
				CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(dsbQUXvTSm);
				string text = (string)noLQhHEEdJiDq5AHU4m(IYEgrIEq8s9b4AuO1ZY(21508), text2, text3);
				string text4 = EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(20350));
				PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
				unxTl5EpptwNr8crnok(pasteBufferCell, text);
				iokRQAEXBaBrBkDCUle(pasteBufferCell, text4);
				return pasteBufferCell;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string yubQpMq2ee(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PjNC94E9yTlxGiw6FfL(P_0, dsbQUXvTSm).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static dM56x35dlwOvRXNG9K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				dsbQUXvTSm = new CvsCellLocation(6, 2);
				break;
			case 0:
				lGFtbREou2SYqm2kL4N();
				_ = 0;
				num = (vohRO1EbFJd6YGmha2M() ? 4 : 3);
				continue;
			case 5:
				return;
			}
			wwIQ7h416I = new CvsCellLocation(5, 2);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lGFtbREou2SYqm2kL4N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qsoT6VESDq3dLSNhiEX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vohRO1EbFJd6YGmha2M()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f1JYBPEGtZBIe6mJKKZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object quxTIrEkXmadXNdW7HJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation iMNhb6E8sgZXftV9eBy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellLocation((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IYEgrIEq8s9b4AuO1ZY(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object noLQhHEEdJiDq5AHU4m(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void unxTl5EpptwNr8crnok(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iokRQAEXBaBrBkDCUle(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation PjNC94E9yTlxGiw6FfL(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}
}
