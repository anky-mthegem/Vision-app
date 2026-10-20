using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId.ReadIdUpdates;

public class AddPharmacodeUpdate : ISnippetUpdate
{
	private readonly SnippetLocalizer nbXf2lF3b7;

	private readonly CvsCellLocation v3wfqDFx5g;

	private readonly CvsCellLocation FRgfijrsDg;

	private readonly CvsCellLocation hAlfkZQs5Q;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddPharmacodeUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				v3wfqDFx5g = new CvsCellLocation(2, 0);
				num = 7;
				break;
			case 0:
			case 3:
				hAlfkZQs5Q = new CvsCellLocation(4, 7);
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				HULli4oUWpTSGif2p7n(this);
				num = 5;
				break;
			case 5:
				nbXf2lF3b7 = localizer;
				num = 8;
				break;
			case 6:
				umsJLroYlGdJ0m4XTfP();
				cvG6usoML7s1vNx9rIq();
				if (NZ8NoAoFNuCe8505qoF())
				{
					num = 4;
					if (NZ8NoAoFNuCe8505qoF())
					{
						break;
					}
					goto case 7;
				}
				num = 0;
				if (1 == 0)
				{
					return;
				}
				break;
			case 7:
				FRgfijrsDg = new CvsCellLocation(4, 5);
				goto case 0;
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
		cvG6usoML7s1vNx9rIq();
		int num = ((!NZ8NoAoFNuCe8505qoF()) ? 3 : 2);
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				pasteBuffer = new AddCellUpdate(FRgfijrsDg, gW0fyCo1av, nbXf2lF3b7).Apply(originalSnippet);
				goto case 1;
			case 1:
			case 3:
				pasteBuffer = new AddCellUpdate(hAlfkZQs5Q, KhEfxFBEVG, nbXf2lF3b7, replaceCell: true).Apply(pasteBuffer);
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				pasteBuffer = new ExpressionEditUpdate(v3wfqDFx5g, KrFfvKyM0i, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return exp;
				}).Apply(pasteBuffer);
				num = 5;
				break;
			case 5:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell gW0fyCo1av(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(FRgfijrsDg);
		string text = B1Yfe6GHUv(P_0, (string)Ae0qaQoHFeV9U4TeC13(8420));
		string snippetName = (string)A6kUfxoxqCqPPNbXqrH(P_0);
		JObject jObject = new JObject { [(string)Ae0qaQoHFeV9U4TeC13(1624)] = (string?)Ae0qaQoHFeV9U4TeC13(8344) };
		QB9LyLoQunpte6SKEMi(jObject, Ae0qaQoHFeV9U4TeC13(8360), G2kTQTomFHr1mXpmUBo(11));
		jObject[CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368)] = (JToken?)dLcjiUoNE2xZvDtDmjC(Ae0qaQoHFeV9U4TeC13(8384));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
		lgsEo4o2IDmHKq7rwSC(pasteBufferCell, Ae0qaQoHFeV9U4TeC13(17722));
		qyAsGvocSUUV54bkSUI(pasteBufferCell, text);
		EY1vXjo1TeniNbY8WGV(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(9826), isInternal: true));
		Ls1rMBoh9CMQb17kcv9(pasteBufferCell, DdGFGhouI6A2FNlfEIh(0.0));
		g7wbNNot8TjNNyGR8LK(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell KhEfxFBEVG(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCellLocation locationFromOrigin = default;
		string expression = default;
		string snippetName = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				locationFromOrigin = P_0.GetLocationFromOrigin(hAlfkZQs5Q);
				cvG6usoML7s1vNx9rIq();
				if (NZ8NoAoFNuCe8505qoF())
				{
					num = 4;
					break;
				}
				num = 3;
				if (true)
				{
					break;
				}
				goto default;
			case 1:
			case 4:
			{
				string expression2 = ((PasteBufferCell)u9qUssozNEKkFHP7UKK(P_0, locationFromOrigin)).Expression;
				CvsCellLocation locationFromOrigin2 = P_0.GetLocationFromOrigin(FRgfijrsDg);
				int startIndex = rnBvkGSLpQEmCBAm2pt(expression2, Ae0qaQoHFeV9U4TeC13(5424));
				expression = expression2.Insert(startIndex, (string)uQAqfpSKSsm0uNY7wYb(CdQUGaROfy7He9T0foW.KbIzwHEDLa(17770), locationFromOrigin2.ToString(absoluteRow: true, absoluteColumn: true)));
				goto default;
			}
			default:
				snippetName = (string)A6kUfxoxqCqPPNbXqrH(P_0);
				num = 5;
				break;
			case 5:
				return new PasteBufferCell(locationFromOrigin)
				{
					Expression = expression,
					Name = EzSnippet.AssembleFullCellName(snippetName, (string)Ae0qaQoHFeV9U4TeC13(17778), isInternal: true)
				};
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string KrFfvKyM0i(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string newarg = P_0.GetLocationFromOrigin(FRgfijrsDg).ToString(absoluteRow: true, absoluteColumn: true);
		return CvsParse.ReplaceArg(P_1, 14, newarg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string B1Yfe6GHUv(PasteBuffer P_0, string P_1, bool P_2 = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)Fd6vKFS5ErZTMhDBLvN(SnippetPasteBuffer.GetCellInTool(P_0, P_1, P_2))).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void umsJLroYlGdJ0m4XTfP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HULli4oUWpTSGif2p7n(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NZ8NoAoFNuCe8505qoF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cvG6usoML7s1vNx9rIq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ae0qaQoHFeV9U4TeC13(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A6kUfxoxqCqPPNbXqrH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G2kTQTomFHr1mXpmUBo(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QB9LyLoQunpte6SKEMi(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dLcjiUoNE2xZvDtDmjC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lgsEo4o2IDmHKq7rwSC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qyAsGvocSUUV54bkSUI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EY1vXjo1TeniNbY8WGV(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DdGFGhouI6A2FNlfEIh(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ls1rMBoh9CMQb17kcv9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g7wbNNot8TjNNyGR8LK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u9qUssozNEKkFHP7UKK(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellAt(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rnBvkGSLpQEmCBAm2pt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uQAqfpSKSsm0uNY7wYb(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fd6vKFS5ErZTMhDBLvN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}
}
