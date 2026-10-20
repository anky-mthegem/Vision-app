using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELRead.Updates;

public class PretrainedModelSelectionUpdate : ISnippetUpdate
{
	private readonly SnippetLocalizer wyMSWWDXJD;

	private CvsCellLocation QN0SjZTZtc;

	private CvsCellLocation Su4SCAj9c7;

	private CvsCellLocation O8uSOocyRj;

	private CvsCellLocation t6MSHZac2h;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PretrainedModelSelectionUpdate(SnippetLocalizer localizer)
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
			case 5:
				t6MSHZac2h = new CvsCellLocation(1, 5);
				num = 3;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
			case 8:
				wyMSWWDXJD = localizer;
				num = 9;
				if (IxsRigP3G8cDMpHGJCm())
				{
				}
				break;
			case 0:
				fXSqXpPjXn2hnEjDaNJ();
				IxsRigP3G8cDMpHGJCm();
				if (YHFbV9P73NBZTshWQ67())
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto case 2;
				}
				num = 8;
				break;
			case 2:
				Su4SCAj9c7 = new CvsCellLocation(2, 0);
				num = 7;
				if (IxsRigP3G8cDMpHGJCm())
				{
				}
				break;
			case 1:
			case 4:
				QN0SjZTZtc = new CvsCellLocation(1, 6);
				num = 2;
				break;
			case 7:
				O8uSOocyRj = new CvsCellLocation(3, 1);
				goto case 5;
			default:
				num = 5;
				break;
			case 3:
				dihLmLP6EX1MBZqhWob(this);
				goto case 6;
			case 9:
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
		PasteBuffer originalSnippet2 = new AddCellUpdate(QN0SjZTZtc, PlsSl4Ms5w, wyMSWWDXJD).Apply(originalSnippet);
		return new ExpressionEditUpdate(Su4SCAj9c7, oLsSTtsr3j, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return exp;
		}).Apply(originalSnippet2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell PlsSl4Ms5w(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string name = EzSnippet.AssembleFullCellName((string)x1J0DoPC6bxBi8AYUsP(P_0), (string)sl5kFsPAbMUIEWBji0L(6738), isInternal: true);
		CvsCellLocation loc = Y1ISbYPR1fWmUn88fSe(P_0, QN0SjZTZtc);
		CvsCellLocation cvsCellLocation = Y1ISbYPR1fWmUn88fSe(P_0, O8uSOocyRj);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		uiRhSvPW4tMK3EcO3TU(pasteBufferCell, sl5kFsPAbMUIEWBji0L(7302));
		pasteBufferCell.Name = name;
		npKRFoPyTsMDt0fyC5d(pasteBufferCell, SNVXBnPTpOBOeyNWOOY(1));
		rGUI7RP0fu9r8xVk84E(pasteBufferCell, cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string oLsSTtsr3j(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (YHFbV9P73NBZTshWQ67())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_00a0;
		IL_0026:
		CvsCellLocation cvsCellLocation = default;
		string text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
		num = 3;
		goto IL_00a0;
		IL_00a0:
		string text2 = default;
		string text3 = default;
		string text4 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				break;
			case 8:
				text2 = (string)bOCFwAPMJS6vj4Ax2Ed(text2, 9, text3);
				num = 9;
				continue;
			case 7:
				text4 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 1;
				continue;
			case 5:
				cvsCellLocation = P_0.GetLocationFromOrigin(t6MSHZac2h);
				break;
			case 3:
				cvsCellLocation = Y1ISbYPR1fWmUn88fSe(P_0, QN0SjZTZtc);
				goto case 7;
			default:
				num = 7;
				continue;
			case 1:
				text3 = (string)JnVVSePFkXBwMvlCXyp(new string[5]
				{
					(string)sl5kFsPAbMUIEWBji0L(7514),
					text,
					(string)sl5kFsPAbMUIEWBji0L(5424),
					text4,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(7524)
				});
				num = 8;
				continue;
			case 0:
			case 6:
				text2 = P_1;
				num = 5;
				continue;
			case 9:
				return text2;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fXSqXpPjXn2hnEjDaNJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dihLmLP6EX1MBZqhWob(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YHFbV9P73NBZTshWQ67()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IxsRigP3G8cDMpHGJCm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x1J0DoPC6bxBi8AYUsP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sl5kFsPAbMUIEWBji0L(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Y1ISbYPR1fWmUn88fSe(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uiRhSvPW4tMK3EcO3TU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SNVXBnPTpOBOeyNWOOY(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void npKRFoPyTsMDt0fyC5d(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rGUI7RP0fu9r8xVk84E(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JnVVSePFkXBwMvlCXyp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bOCFwAPMJS6vj4Ax2Ed(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}
}
