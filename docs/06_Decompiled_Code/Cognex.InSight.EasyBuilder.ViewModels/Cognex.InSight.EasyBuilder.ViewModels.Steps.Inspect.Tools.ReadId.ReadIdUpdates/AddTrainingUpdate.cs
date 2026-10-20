using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId.ReadIdUpdates;

public class AddTrainingUpdate : ISnippetUpdate
{
	private readonly SnippetLocalizer tUREourQWR;

	private readonly CvsCellLocation eFHES53stX;

	private CvsCellLocation aNfEDIVtkA;

	private CvsCellLocation qqQE3V4CQO;

	private CvsCellLocation s75EIIRbsw;

	private CvsCellLocation B2QEflDxvP;

	private CvsCellLocation qkjEEu52df;

	private CvsCellLocation sM5EbyZkiJ;

	private CvsCellLocation qTeEcipJNd;

	private CvsCellLocation FYMEQcT9Ip;

	private CvsCellLocation oLlEgVTSfH;

	private CvsCellLocation AKuEMRGs2Q;

	private CvsCellLocation qjgER2lywh;

	private CvsCellLocation TpdE48GSZ7;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddTrainingUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 14;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0155;
		IL_001a:
		tUREourQWR = localizer;
		num = 15;
		goto IL_0155;
		IL_0155:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 0:
			case 9:
				oLlEgVTSfH = new CvsCellLocation(10, 2);
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				qkjEEu52df = new CvsCellLocation(6, 3);
				num = 3;
				continue;
			case 1:
				AKuEMRGs2Q = new CvsCellLocation(12, 3);
				qjgER2lywh = new CvsCellLocation(13, 3);
				TpdE48GSZ7 = new CvsCellLocation(10, 3);
				num = 5;
				continue;
			case 11:
				eFHES53stX = new CvsCellLocation(2, 0);
				num = 12;
				if (LC70y3So8VKhZABm76Q())
				{
					continue;
				}
				goto case 7;
			case 7:
				s75EIIRbsw = new CvsCellLocation(11, 5);
				num = 4;
				if (!gLSI2VSSyIVOqcwxYVe())
				{
					continue;
				}
				goto case 13;
			case 13:
				qTeEcipJNd = new CvsCellLocation(12, 2);
				_ = 0;
				if (LC70y3So8VKhZABm76Q())
				{
					num = 10;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				}
				num = 0;
				continue;
			case 4:
				B2QEflDxvP = new CvsCellLocation(5, 3);
				num = 2;
				continue;
			case 5:
				asq4G8S8eRfOjfwW8Ck(this);
				num = 6;
				continue;
			case 8:
			case 10:
				FYMEQcT9Ip = new CvsCellLocation(13, 2);
				goto case 0;
			case 3:
				sM5EbyZkiJ = new CvsCellLocation(6, 4);
				goto case 13;
			default:
				num = 13;
				if (true)
				{
					continue;
				}
				goto case 14;
			case 14:
				QuaAgcSkq372tKYmQDy();
				num = 11;
				continue;
			case 12:
				aNfEDIVtkA = new CvsCellLocation(5, 2);
				qqQE3V4CQO = new CvsCellLocation(6, 2);
				num = 7;
				continue;
			case 15:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				pasteBuffer = new AddCellUpdate(FYMEQcT9Ip, uUXEAY8BTv, tUREourQWR).Apply(pasteBuffer);
				num = 12;
				break;
			default:
				pasteBuffer = new AddCellUpdate(oLlEgVTSfH, c31ENi2c22, tUREourQWR).Apply(pasteBuffer);
				num = 11;
				if (LC70y3So8VKhZABm76Q())
				{
					break;
				}
				goto case 12;
			case 12:
				pasteBuffer = new AddCellUpdate(TpdE48GSZ7, Uf9E5HZyLD, tUREourQWR).Apply(pasteBuffer);
				pasteBuffer = new AddCellUpdate(AKuEMRGs2Q, THXEpZvbsN, tUREourQWR).Apply(pasteBuffer);
				num = 9;
				if (LC70y3So8VKhZABm76Q())
				{
					break;
				}
				goto case 0;
			case 0:
				pasteBuffer = new AddCellUpdate(sM5EbyZkiJ, CtGEu5KmO0, tUREourQWR).Apply(pasteBuffer);
				goto default;
			case 1:
				pasteBuffer = new AddCellUpdate(qkjEEu52df, xW6E6to1E9, tUREourQWR).Apply(pasteBuffer);
				num = 0;
				break;
			case 9:
				pasteBuffer = new AddCellUpdate(qjgER2lywh, Yu5EUIwChl, tUREourQWR).Apply(pasteBuffer);
				pasteBuffer = new ExpressionEditUpdate(eFHES53stX, X7nEFPqoIF, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return exp;
				}).Apply(pasteBuffer);
				num = 13;
				break;
			case 3:
			case 7:
				pasteBuffer = new AddCellUpdate(B2QEflDxvP, rCdEdQGxM4, tUREourQWR).Apply(pasteBuffer);
				num = 1;
				break;
			case 11:
				pasteBuffer = new AddCellUpdate(qTeEcipJNd, d34E7aKPCX, tUREourQWR).Apply(pasteBuffer);
				num = 2;
				break;
			case 5:
				pasteBuffer = new AddCellUpdate(s75EIIRbsw, Hv6f1RCAkV, tUREourQWR).Apply(originalSnippet);
				num = 8;
				break;
			case 10:
				pasteBuffer = new AddCellUpdate(qqQE3V4CQO, PaXEaIG5C4, tUREourQWR).Apply(pasteBuffer);
				gLSI2VSSyIVOqcwxYVe();
				num = (LC70y3So8VKhZABm76Q() ? 7 : 4);
				break;
			case 8:
				pasteBuffer = new AddCellUpdate(aNfEDIVtkA, b5Sfzsn9nF, tUREourQWR).Apply(pasteBuffer);
				num = 10;
				break;
			case 13:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell Hv6f1RCAkV(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gLSI2VSSyIVOqcwxYVe();
		int num = ((!LC70y3So8VKhZABm76Q()) ? 1 : 3);
		PasteBufferCell pasteBufferCell = default;
		string snippetName = default;
		string text = default;
		string text2 = default;
		string text3 = default;
		while (true)
		{
			switch (num)
			{
			default:
				LKauChS9pLkHGPk3WJk(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, (string)HensapSEmnHhHweetnD(18582), isInternal: true));
				num = 5;
				break;
			case 0:
			case 3:
			{
				CvsCellLocation loc = GqbfGuSqldK70nImmUt(P_0, s75EIIRbsw);
				text = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(8420));
				text2 = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(17778), _0020: true);
				text3 = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(18510), _0020: true);
				snippetName = (string)k1MLgeSpHHJvq2nyK6Z(P_0);
				pasteBufferCell = new PasteBufferCell(loc);
				num = 4;
				break;
			}
			case 4:
				pasteBufferCell.Expression = (string)r7Bj1SSXg9STlDjg8h4(new string[7]
				{
					(string)HensapSEmnHhHweetnD(18546),
					text,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(18556),
					text2,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(17770),
					text3,
					(string)HensapSEmnHhHweetnD(18566)
				});
				goto default;
			case 5:
				return pasteBufferCell;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell b5Sfzsn9nF(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new PasteBufferCell(GqbfGuSqldK70nImmUt(P_0, aNfEDIVtkA))
		{
			Expression = (string)HensapSEmnHhHweetnD(18632)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell PaXEaIG5C4(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = GqbfGuSqldK70nImmUt(P_0, qqQE3V4CQO);
		string text = P_0.GetLocationFromOrigin(s75EIIRbsw).ToString(absoluteRow: true, absoluteColumn: true);
		string snippetName = (string)k1MLgeSpHHJvq2nyK6Z(P_0);
		JObject jObject = new JObject { [(string)HensapSEmnHhHweetnD(1624)] = (string?)HensapSEmnHhHweetnD(8344) };
		R7m7iGS7W9LewmHIMlW(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8360), e9bSBRS4PDIhysGCVAk(11));
		R7m7iGS7W9LewmHIMlW(jObject, HensapSEmnHhHweetnD(8368), A6iE1ZS34SlxDHvR1Co(CdQUGaROfy7He9T0foW.KbIzwHEDLa(8384)));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		BqPlfTSjqnBPCInmv5n(pasteBufferCell, HensapSEmnHhHweetnD(18668));
		h1TIn7S6RfdNwHfg5nF(pasteBufferCell, text);
		pasteBufferCell.Name = EzSnippet.AssembleFullCellName(snippetName, (string)HensapSEmnHhHweetnD(10844), isInternal: true);
		pasteBufferCell.Value = (JToken)MAd22USCqSYv3nJQxHh(0.0);
		VEsXeoSAjCn2q4EKJwu(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell Uf9E5HZyLD(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LC70y3So8VKhZABm76Q();
		int num = (gLSI2VSSyIVOqcwxYVe() ? 2 : 3);
		PasteBufferCell pasteBufferCell = default;
		string text2 = default;
		string text = default;
		string text3 = default;
		string text4 = default;
		string text5 = default;
		string toolName = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				BqPlfTSjqnBPCInmv5n(pasteBufferCell, (string)HensapSEmnHhHweetnD(18696) + text2 + (string)HensapSEmnHhHweetnD(18708) + text + (string)HensapSEmnHhHweetnD(18716) + text3 + (string)HensapSEmnHhHweetnD(17770) + text4 + CdQUGaROfy7He9T0foW.KbIzwHEDLa(17770) + text5 + CdQUGaROfy7He9T0foW.KbIzwHEDLa(18566));
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				LKauChS9pLkHGPk3WJk(pasteBufferCell, EzSnippet.AssembleFullCellName(toolName, (string)HensapSEmnHhHweetnD(18728), isInternal: true));
				num = 5;
				break;
			case 0:
			case 3:
			{
				CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(TpdE48GSZ7);
				text = GqbfGuSqldK70nImmUt(P_0, qqQE3V4CQO).ToString(absoluteRow: true, absoluteColumn: true);
				text2 = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(8420));
				text3 = H01EXyXXH3(P_0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(17778), _0020: true);
				text4 = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(10474), _0020: true);
				text5 = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(10512), _0020: true);
				toolName = SnippetPasteBuffer.GetToolName(P_0);
				pasteBufferCell = new PasteBufferCell(locationFromOrigin);
				goto case 1;
			}
			case 5:
				return pasteBufferCell;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell THXEpZvbsN(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PasteBufferCell pasteBufferCell = new PasteBufferCell(GqbfGuSqldK70nImmUt(P_0, AKuEMRGs2Q));
		BqPlfTSjqnBPCInmv5n(pasteBufferCell, HensapSEmnHhHweetnD(18778));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell Yu5EUIwChl(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = GqbfGuSqldK70nImmUt(P_0, qjgER2lywh);
		string snippetName = (string)k1MLgeSpHHJvq2nyK6Z(P_0);
		string text = GqbfGuSqldK70nImmUt(P_0, TpdE48GSZ7).ToString(absoluteRow: true, absoluteColumn: true);
		JObject jObject = new JObject { [(string)HensapSEmnHhHweetnD(1624)] = (JToken?)A6iE1ZS34SlxDHvR1Co(HensapSEmnHhHweetnD(8344)) };
		R7m7iGS7W9LewmHIMlW(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8360), (JToken)11);
		R7m7iGS7W9LewmHIMlW(jObject, HensapSEmnHhHweetnD(8368), (JToken)(string?)HensapSEmnHhHweetnD(8384));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		BqPlfTSjqnBPCInmv5n(pasteBufferCell, HensapSEmnHhHweetnD(18668));
		h1TIn7S6RfdNwHfg5nF(pasteBufferCell, text);
		pasteBufferCell.Name = EzSnippet.AssembleFullCellName(snippetName, (string)HensapSEmnHhHweetnD(10922), isInternal: true);
		GBufoVSRVbkOQNcqWNJ(pasteBufferCell, (JToken)0.0);
		VEsXeoSAjCn2q4EKJwu(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell d34E7aKPCX(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new PasteBufferCell(GqbfGuSqldK70nImmUt(P_0, qTeEcipJNd))
		{
			Expression = CdQUGaROfy7He9T0foW.KbIzwHEDLa(18814)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell c31ENi2c22(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gLSI2VSSyIVOqcwxYVe();
		int num = ((!LC70y3So8VKhZABm76Q()) ? 1 : 3);
		PasteBufferCell pasteBufferCell = default;
		string snippetName = default;
		string text = default;
		string text2 = default;
		string text3 = default;
		string text4 = default;
		string text5 = default;
		while (true)
		{
			switch (num)
			{
			default:
				LKauChS9pLkHGPk3WJk(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, (string)HensapSEmnHhHweetnD(18868), isInternal: true));
				num = 5;
				if (gLSI2VSSyIVOqcwxYVe())
				{
				}
				break;
			case 4:
				BqPlfTSjqnBPCInmv5n(pasteBufferCell, r7Bj1SSXg9STlDjg8h4(new string[11]
				{
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(18696),
					text,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(18708),
					text2,
					(string)HensapSEmnHhHweetnD(18716),
					text3,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(17770),
					text4,
					(string)HensapSEmnHhHweetnD(17770),
					text5,
					(string)HensapSEmnHhHweetnD(18566)
				}));
				goto default;
			case 0:
			case 3:
			{
				CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(oLlEgVTSfH);
				text = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(8420));
				text2 = P_0.GetLocationFromOrigin(qqQE3V4CQO).ToString(absoluteRow: true, absoluteColumn: true);
				text3 = H01EXyXXH3(P_0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(17778), _0020: true);
				text4 = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(10474), _0020: true);
				text5 = H01EXyXXH3(P_0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10512), _0020: true);
				snippetName = (string)k1MLgeSpHHJvq2nyK6Z(P_0);
				pasteBufferCell = new PasteBufferCell(locationFromOrigin);
				num = 4;
				break;
			}
			case 5:
				return pasteBufferCell;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell uUXEAY8BTv(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = GqbfGuSqldK70nImmUt(P_0, FYMEQcT9Ip);
		string snippetName = (string)k1MLgeSpHHJvq2nyK6Z(P_0);
		string text = GqbfGuSqldK70nImmUt(P_0, oLlEgVTSfH).ToString(absoluteRow: true, absoluteColumn: true);
		JObject jObject = new JObject { [(string)HensapSEmnHhHweetnD(1624)] = (string?)HensapSEmnHhHweetnD(8344) };
		R7m7iGS7W9LewmHIMlW(jObject, HensapSEmnHhHweetnD(8360), e9bSBRS4PDIhysGCVAk(11));
		jObject[CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368)] = (string?)HensapSEmnHhHweetnD(8384);
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		BqPlfTSjqnBPCInmv5n(pasteBufferCell, HensapSEmnHhHweetnD(18668));
		h1TIn7S6RfdNwHfg5nF(pasteBufferCell, text);
		pasteBufferCell.Name = EzSnippet.AssembleFullCellName(snippetName, (string)HensapSEmnHhHweetnD(10876), isInternal: true);
		GBufoVSRVbkOQNcqWNJ(pasteBufferCell, MAd22USCqSYv3nJQxHh(0.0));
		VEsXeoSAjCn2q4EKJwu(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell rCdEdQGxM4(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PasteBufferCell pasteBufferCell = new PasteBufferCell(P_0.GetLocationFromOrigin(B2QEflDxvP));
		BqPlfTSjqnBPCInmv5n(pasteBufferCell, HensapSEmnHhHweetnD(18932));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell xW6E6to1E9(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = GqbfGuSqldK70nImmUt(P_0, qkjEEu52df);
		string text = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(9614));
		string text2 = H01EXyXXH3(P_0, (string)HensapSEmnHhHweetnD(8420));
		k1MLgeSpHHJvq2nyK6Z(P_0);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		BqPlfTSjqnBPCInmv5n(pasteBufferCell, UsZH7DSWErMMxydApaI(HensapSEmnHhHweetnD(18976), text, HensapSEmnHhHweetnD(6970)));
		h1TIn7S6RfdNwHfg5nF(pasteBufferCell, text2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell CtGEu5KmO0(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		PasteBufferCell pasteBufferCell = default;
		string text = default;
		string text2 = default;
		string snippetName = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				BqPlfTSjqnBPCInmv5n(pasteBufferCell, r7Bj1SSXg9STlDjg8h4(new string[5]
				{
					(string)HensapSEmnHhHweetnD(19020),
					text,
					(string)HensapSEmnHhHweetnD(19052),
					text,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(6970)
				}));
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				h1TIn7S6RfdNwHfg5nF(pasteBufferCell, text2);
				goto default;
			case 5:
				do
				{
					CvsCellLocation loc = GqbfGuSqldK70nImmUt(P_0, sM5EbyZkiJ);
					text = P_0.GetLocationFromOrigin(qkjEEu52df).ToString(absoluteRow: true, absoluteColumn: true);
					text2 = H01EXyXXH3(P_0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8420));
					snippetName = (string)k1MLgeSpHHJvq2nyK6Z(P_0);
					pasteBufferCell = new PasteBufferCell(loc);
					LC70y3So8VKhZABm76Q();
					if (gLSI2VSSyIVOqcwxYVe())
					{
						num = 0;
						continue;
					}
					num = 4;
					break;
				}
				while (1 == 0);
				break;
			default:
				pasteBufferCell.Name = EzSnippet.AssembleFullCellName(snippetName, (string)HensapSEmnHhHweetnD(10970));
				num = 6;
				break;
			case 6:
				return pasteBufferCell;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string X7nEFPqoIF(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gLSI2VSSyIVOqcwxYVe();
		int num = ((!LC70y3So8VKhZABm76Q()) ? 7 : 4);
		CvsCellLocation cvsCellLocation = default;
		string text2 = default;
		string newarg = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				cvsCellLocation = GqbfGuSqldK70nImmUt(P_0, qqQE3V4CQO);
				goto case 1;
			case 5:
				text2 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 8;
				break;
			case 2:
				newarg = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				goto case 6;
			default:
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 7:
				text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 3;
				break;
			case 6:
				cvsCellLocation = P_0.GetLocationFromOrigin(FYMEQcT9Ip);
				num = 5;
				break;
			case 3:
				cvsCellLocation = P_0.GetLocationFromOrigin(qjgER2lywh);
				num = 2;
				break;
			case 8:
				return (string)aOcRiDSTD4vIvfwc5qA(CvsParse.ReplaceArg((string)aOcRiDSTD4vIvfwc5qA(P_1, 10, text), 44, newarg), 45, text2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string H01EXyXXH3(PasteBuffer P_0, string P_1, bool P_2 = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)zsTOW1SykQ2rgBYDri4(SnippetPasteBuffer.GetCellInTool(P_0, P_1, P_2))).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QuaAgcSkq372tKYmQDy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void asq4G8S8eRfOjfwW8Ck(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LC70y3So8VKhZABm76Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gLSI2VSSyIVOqcwxYVe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation GqbfGuSqldK70nImmUt(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HensapSEmnHhHweetnD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k1MLgeSpHHJvq2nyK6Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r7Bj1SSXg9STlDjg8h4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LKauChS9pLkHGPk3WJk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e9bSBRS4PDIhysGCVAk(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R7m7iGS7W9LewmHIMlW(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A6iE1ZS34SlxDHvR1Co(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BqPlfTSjqnBPCInmv5n(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h1TIn7S6RfdNwHfg5nF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MAd22USCqSYv3nJQxHh(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VEsXeoSAjCn2q4EKJwu(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GBufoVSRVbkOQNcqWNJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UsZH7DSWErMMxydApaI(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aOcRiDSTD4vIvfwc5qA(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zsTOW1SykQ2rgBYDri4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}
}
