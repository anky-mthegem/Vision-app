using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId.ReadIdUpdates;

public class AddPostalCodeUpdate : ISnippetUpdate
{
	private readonly SnippetLocalizer Vw7f0Gt0kd;

	private readonly CvsCellLocation kFnfVHffNh;

	private readonly CvsCellLocation g6FfL1C2k4;

	private readonly CvsCellLocation GeifJdm5tE;

	private readonly CvsCellLocation HKjf9ux5sT;

	private readonly CvsCellLocation olgfrnVmIe;

	private readonly CvsCellLocation UnMfhY5ueC;

	private readonly CvsCellLocation WsCf8IplpS;

	private readonly CvsCellLocation WGVfmyHCV5;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddPostalCodeUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (HjBDUZSJsQZ2coxesUj())
		{
			goto IL_001e;
		}
		goto IL_00df;
		IL_001e:
		aUogxfSa9wCYrxwlt2y();
		num = 3;
		goto IL_00df;
		IL_00df:
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 4:
				GeifJdm5tE = new CvsCellLocation(5, 4);
				num = 1;
				continue;
			case 1:
				HKjf9ux5sT = new CvsCellLocation(5, 5);
				num = 5;
				continue;
			case 3:
				kFnfVHffNh = new CvsCellLocation(2, 0);
				xlGNT0SwN4L6pNeRmNV();
				if (!HjBDUZSJsQZ2coxesUj())
				{
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 9;
				}
				num = 10;
				continue;
			case 9:
				UnMfhY5ueC = new CvsCellLocation(5, 7);
				WsCf8IplpS = new CvsCellLocation(6, 5);
				goto case 7;
			case 0:
				gl8QkdSeaEbRLLAPxbh(this);
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				olgfrnVmIe = new CvsCellLocation(5, 6);
				goto case 9;
			default:
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
			case 10:
				WGVfmyHCV5 = new CvsCellLocation(4, 7);
				num = 0;
				continue;
			case 2:
			case 6:
				g6FfL1C2k4 = new CvsCellLocation(4, 6);
				num = 4;
				if (!HjBDUZSJsQZ2coxesUj())
				{
					continue;
				}
				goto case 11;
			case 11:
				Vw7f0Gt0kd = localizer;
				num = 12;
				if (xlGNT0SwN4L6pNeRmNV())
				{
					continue;
				}
				return;
			case 12:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xlGNT0SwN4L6pNeRmNV();
		int num;
		if (!HjBDUZSJsQZ2coxesUj())
		{
			num = 8;
		}
		else
		{
			num = 5;
			if (!xlGNT0SwN4L6pNeRmNV())
			{
				goto IL_017e;
			}
		}
		goto IL_01b5;
		IL_01b5:
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				pasteBuffer = new AddCellUpdate(WGVfmyHCV5, JBXfndvjeh, Vw7f0Gt0kd, replaceCell: true).Apply(pasteBuffer);
				num = 7;
				continue;
			case 4:
				pasteBuffer = new AddCellUpdate(GeifJdm5tE, mDYfsLJynn, Vw7f0Gt0kd).Apply(pasteBuffer);
				num = 1;
				continue;
			case 9:
				pasteBuffer = new AddCellUpdate(g6FfL1C2k4, egCfPWhAQM, Vw7f0Gt0kd).Apply(pasteBuffer);
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 5:
			case 6:
				break;
			case 0:
			case 8:
				goto IL_00e8;
			case 7:
				pasteBuffer = new ExpressionEditUpdate(kFnfVHffNh, X7PfteN1p5, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return exp;
				}).Apply(pasteBuffer);
				num = 11;
				continue;
			case 3:
				goto IL_0143;
			case 2:
				goto IL_017e;
			default:
				num = 3;
				continue;
			case 1:
				pasteBuffer = new AddCellUpdate(HKjf9ux5sT, MFyfKd0TAE, Vw7f0Gt0kd).Apply(pasteBuffer);
				num = 2;
				continue;
			case 11:
				return pasteBuffer;
			}
			break;
		}
		goto IL_00b7;
		IL_00b7:
		pasteBuffer = new AddCellUpdate(WsCf8IplpS, BENfZPXB9F, Vw7f0Gt0kd).Apply(pasteBuffer);
		num = 10;
		if (false)
		{
			goto IL_00e8;
		}
		goto IL_01b5;
		IL_00e8:
		pasteBuffer = originalSnippet.Clone();
		num = 9;
		goto IL_01b5;
		IL_0143:
		pasteBuffer = new AddCellUpdate(UnMfhY5ueC, QQ1fB3eolD, Vw7f0Gt0kd).Apply(pasteBuffer);
		goto IL_00b7;
		IL_017e:
		pasteBuffer = new AddCellUpdate(olgfrnVmIe, Q6ZfGZAYeC, Vw7f0Gt0kd).Apply(pasteBuffer);
		goto IL_0143;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell egCfPWhAQM(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = lg7COySOn33b0Y4okKt(P_0, g6FfL1C2k4);
		string text = XghfYhjSgA(P_0, (string)J6I9ExSIb6kNs7K25K4(8420));
		string snippetName = (string)vJvVsbSDfb0LXhAvLbe(P_0);
		JObject jObject = new JObject();
		aeYp4ISnsOIMCifeSrB(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1624), bIolrjSi8qVnaCBc7Hh(J6I9ExSIb6kNs7K25K4(8344)));
		aeYp4ISnsOIMCifeSrB(jObject, J6I9ExSIb6kNs7K25K4(8360), (JToken)19);
		aeYp4ISnsOIMCifeSrB(jObject, J6I9ExSIb6kNs7K25K4(8368), (JToken)(string?)J6I9ExSIb6kNs7K25K4(17814));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		S11jhNSVW4Xucn7Y6LT(pasteBufferCell, J6I9ExSIb6kNs7K25K4(17874));
		F3wZBtSfWUk4EIPrfFK(pasteBufferCell, text);
		UHmdnASdA8BCeR0GYAf(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10214), isInternal: true));
		PNAoY9Sg9Vy8B1ipGYR(pasteBufferCell, b0KbHhSlRc83SiomQwu(0.0));
		MlcVWSSs0QN2pR6xNof(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell mDYfsLJynn(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = lg7COySOn33b0Y4okKt(P_0, GeifJdm5tE);
		string state = XghfYhjSgA(P_0, (string)J6I9ExSIb6kNs7K25K4(8420));
		string toolName = SnippetPasteBuffer.GetToolName(P_0);
		JObject jObject = new JObject { [(string)J6I9ExSIb6kNs7K25K4(1624)] = (JToken?)bIolrjSi8qVnaCBc7Hh(J6I9ExSIb6kNs7K25K4(8344)) };
		aeYp4ISnsOIMCifeSrB(jObject, J6I9ExSIb6kNs7K25K4(8360), hUu376SvaOXPOvJgbCt(18));
		aeYp4ISnsOIMCifeSrB(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368), (JToken)(string?)J6I9ExSIb6kNs7K25K4(17916));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		S11jhNSVW4Xucn7Y6LT(pasteBufferCell, J6I9ExSIb6kNs7K25K4(17968));
		pasteBufferCell.State = state;
		UHmdnASdA8BCeR0GYAf(pasteBufferCell, EzSnippet.AssembleFullCellName(toolName, (string)J6I9ExSIb6kNs7K25K4(10246), isInternal: true));
		PNAoY9Sg9Vy8B1ipGYR(pasteBufferCell, b0KbHhSlRc83SiomQwu(0.0));
		MlcVWSSs0QN2pR6xNof(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell MFyfKd0TAE(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = lg7COySOn33b0Y4okKt(P_0, HKjf9ux5sT);
		string text = XghfYhjSgA(P_0, (string)J6I9ExSIb6kNs7K25K4(8420));
		string snippetName = (string)vJvVsbSDfb0LXhAvLbe(P_0);
		JObject jObject = new JObject();
		aeYp4ISnsOIMCifeSrB(jObject, J6I9ExSIb6kNs7K25K4(1624), bIolrjSi8qVnaCBc7Hh(J6I9ExSIb6kNs7K25K4(8344)));
		aeYp4ISnsOIMCifeSrB(jObject, J6I9ExSIb6kNs7K25K4(8360), hUu376SvaOXPOvJgbCt(22));
		jObject[(string)J6I9ExSIb6kNs7K25K4(8368)] = (JToken?)bIolrjSi8qVnaCBc7Hh(J6I9ExSIb6kNs7K25K4(18008));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		S11jhNSVW4Xucn7Y6LT(pasteBufferCell, J6I9ExSIb6kNs7K25K4(18076));
		F3wZBtSfWUk4EIPrfFK(pasteBufferCell, text);
		pasteBufferCell.Name = EzSnippet.AssembleFullCellName(snippetName, (string)J6I9ExSIb6kNs7K25K4(10276), isInternal: true);
		PNAoY9Sg9Vy8B1ipGYR(pasteBufferCell, (JToken)0.0);
		MlcVWSSs0QN2pR6xNof(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell Q6ZfGZAYeC(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(olgfrnVmIe);
		string text = XghfYhjSgA(P_0, (string)J6I9ExSIb6kNs7K25K4(8420));
		string snippetName = (string)vJvVsbSDfb0LXhAvLbe(P_0);
		JObject jObject = new JObject { [(string)J6I9ExSIb6kNs7K25K4(1624)] = CdQUGaROfy7He9T0foW.KbIzwHEDLa(8344) };
		aeYp4ISnsOIMCifeSrB(jObject, J6I9ExSIb6kNs7K25K4(8360), hUu376SvaOXPOvJgbCt(26));
		jObject[CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368)] = CdQUGaROfy7He9T0foW.KbIzwHEDLa(18124);
		JObject data = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin)
		{
			Expression = (string)J6I9ExSIb6kNs7K25K4(18200)
		};
		F3wZBtSfWUk4EIPrfFK(pasteBufferCell, text);
		UHmdnASdA8BCeR0GYAf(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, (string)J6I9ExSIb6kNs7K25K4(10312), isInternal: true));
		PNAoY9Sg9Vy8B1ipGYR(pasteBufferCell, b0KbHhSlRc83SiomQwu(0.0));
		pasteBufferCell.Data = data;
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell QQ1fB3eolD(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = lg7COySOn33b0Y4okKt(P_0, UnMfhY5ueC);
		string text = XghfYhjSgA(P_0, (string)J6I9ExSIb6kNs7K25K4(8420));
		string snippetName = (string)vJvVsbSDfb0LXhAvLbe(P_0);
		JObject jObject = new JObject();
		aeYp4ISnsOIMCifeSrB(jObject, J6I9ExSIb6kNs7K25K4(1624), bIolrjSi8qVnaCBc7Hh(J6I9ExSIb6kNs7K25K4(8344)));
		jObject[CdQUGaROfy7He9T0foW.KbIzwHEDLa(8360)] = (JToken?)hUu376SvaOXPOvJgbCt(15);
		aeYp4ISnsOIMCifeSrB(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368), bIolrjSi8qVnaCBc7Hh(J6I9ExSIb6kNs7K25K4(18256)));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		S11jhNSVW4Xucn7Y6LT(pasteBufferCell, J6I9ExSIb6kNs7K25K4(18300));
		F3wZBtSfWUk4EIPrfFK(pasteBufferCell, text);
		pasteBufferCell.Name = EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10356), isInternal: true);
		PNAoY9Sg9Vy8B1ipGYR(pasteBufferCell, b0KbHhSlRc83SiomQwu(0.0));
		MlcVWSSs0QN2pR6xNof(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell BENfZPXB9F(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(WsCf8IplpS);
		string text = XghfYhjSgA(P_0, (string)J6I9ExSIb6kNs7K25K4(8420));
		string snippetName = (string)vJvVsbSDfb0LXhAvLbe(P_0);
		JObject jObject = new JObject();
		aeYp4ISnsOIMCifeSrB(jObject, J6I9ExSIb6kNs7K25K4(1624), bIolrjSi8qVnaCBc7Hh(J6I9ExSIb6kNs7K25K4(8344)));
		aeYp4ISnsOIMCifeSrB(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8360), hUu376SvaOXPOvJgbCt(36));
		jObject[(string)J6I9ExSIb6kNs7K25K4(8368)] = (string?)J6I9ExSIb6kNs7K25K4(18334);
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
		S11jhNSVW4Xucn7Y6LT(pasteBufferCell, J6I9ExSIb6kNs7K25K4(18434));
		F3wZBtSfWUk4EIPrfFK(pasteBufferCell, text);
		UHmdnASdA8BCeR0GYAf(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, (string)J6I9ExSIb6kNs7K25K4(10380), isInternal: true));
		pasteBufferCell.Value = (JToken)b0KbHhSlRc83SiomQwu(0.0);
		MlcVWSSs0QN2pR6xNof(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell JBXfndvjeh(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (xlGNT0SwN4L6pNeRmNV() ? 1 : 3);
		CvsCellLocation cvsCellLocation = default;
		string expression = default;
		string toolName = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			{
				string expression2 = ((PasteBufferCell)QHK7p1Srb9jSeJs4Dkw(P_0, cvsCellLocation)).Expression;
				CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(g6FfL1C2k4);
				CvsCellLocation locationFromOrigin2 = P_0.GetLocationFromOrigin(GeifJdm5tE);
				CvsCellLocation cvsCellLocation2 = lg7COySOn33b0Y4okKt(P_0, HKjf9ux5sT);
				CvsCellLocation cvsCellLocation3 = lg7COySOn33b0Y4okKt(P_0, olgfrnVmIe);
				CvsCellLocation cvsCellLocation4 = lg7COySOn33b0Y4okKt(P_0, UnMfhY5ueC);
				CvsCellLocation cvsCellLocation5 = lg7COySOn33b0Y4okKt(P_0, WsCf8IplpS);
				int num2 = expression2.IndexOf((string)J6I9ExSIb6kNs7K25K4(5424));
				expression = (string)P4ga36SZkL4KH988iJs(expression2, num2, uGdKIhSPJEwdvI3N07y(new string[12]
				{
					(string)J6I9ExSIb6kNs7K25K4(17770),
					locationFromOrigin.ToString(absoluteRow: true, absoluteColumn: true),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(17770),
					locationFromOrigin2.ToString(absoluteRow: true, absoluteColumn: true),
					(string)J6I9ExSIb6kNs7K25K4(17770),
					cvsCellLocation2.ToString(absoluteRow: true, absoluteColumn: true),
					(string)J6I9ExSIb6kNs7K25K4(17770),
					cvsCellLocation3.ToString(absoluteRow: true, absoluteColumn: true),
					(string)J6I9ExSIb6kNs7K25K4(17770),
					cvsCellLocation4.ToString(absoluteRow: true, absoluteColumn: true),
					(string)J6I9ExSIb6kNs7K25K4(17770),
					cvsCellLocation5.ToString(absoluteRow: true, absoluteColumn: true)
				}));
				goto default;
			}
			case 0:
			case 1:
				cvsCellLocation = lg7COySOn33b0Y4okKt(P_0, WGVfmyHCV5);
				num = 4;
				break;
			default:
				toolName = SnippetPasteBuffer.GetToolName(P_0);
				num = 5;
				break;
			case 5:
			{
				PasteBufferCell pasteBufferCell = new PasteBufferCell(cvsCellLocation)
				{
					Expression = expression
				};
				UHmdnASdA8BCeR0GYAf(pasteBufferCell, EzSnippet.AssembleFullCellName(toolName, (string)J6I9ExSIb6kNs7K25K4(17778), isInternal: true));
				return pasteBufferCell;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string X7PfteN1p5(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (!xlGNT0SwN4L6pNeRmNV())
		{
			goto IL_001e;
		}
		goto IL_00ec;
		IL_001e:
		CvsCellLocation cvsCellLocation = lg7COySOn33b0Y4okKt(P_0, olgfrnVmIe);
		num = 3;
		goto IL_00ec;
		IL_00ec:
		string text = default;
		string text4 = default;
		string newarg = default;
		string text3 = default;
		string text5 = default;
		string text2 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				break;
			case 7:
				text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 5;
				continue;
			case 5:
				cvsCellLocation = lg7COySOn33b0Y4okKt(P_0, GeifJdm5tE);
				num = 1;
				if (xlGNT0SwN4L6pNeRmNV())
				{
					continue;
				}
				goto case 3;
			case 3:
				text4 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				_ = 0;
				if (xlGNT0SwN4L6pNeRmNV())
				{
					num = 12;
					continue;
				}
				num = 0;
				if (!HjBDUZSJsQZ2coxesUj())
				{
					continue;
				}
				goto case 2;
			case 0:
			case 9:
				cvsCellLocation = P_0.GetLocationFromOrigin(WsCf8IplpS);
				num = 6;
				continue;
			case 8:
			case 12:
				newarg = lg7COySOn33b0Y4okKt(P_0, UnMfhY5ueC).ToString(absoluteRow: true, absoluteColumn: true);
				goto case 0;
			case 2:
				text3 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				break;
			default:
				num = 11;
				continue;
			case 6:
				text5 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 13;
				continue;
			case 1:
				text2 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				cvsCellLocation = lg7COySOn33b0Y4okKt(P_0, HKjf9ux5sT);
				num = 2;
				continue;
			case 4:
				cvsCellLocation = lg7COySOn33b0Y4okKt(P_0, g6FfL1C2k4);
				num = 7;
				if (!HjBDUZSJsQZ2coxesUj())
				{
					continue;
				}
				goto case 10;
			case 10:
				num2 = 25;
				num = 4;
				continue;
			case 13:
				return (string)qAdhl6SBNoKHNT60SDZ(CvsParse.ReplaceArg((string)qAdhl6SBNoKHNT60SDZ(qAdhl6SBNoKHNT60SDZ(qAdhl6SBNoKHNT60SDZ(qAdhl6SBNoKHNT60SDZ(P_1, num2++, text), num2++, text2), num2++, text3), num2++, text4), num2++, newarg), num2, text5);
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string XghfYhjSgA(PasteBuffer P_0, string P_1, bool P_2 = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sglZfnSGWn5J7ZOlHgn(rp585qSbuXD7i0CVyl1(SnippetPasteBuffer.GetCellInTool(P_0, P_1, P_2))).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aUogxfSa9wCYrxwlt2y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gl8QkdSeaEbRLLAPxbh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xlGNT0SwN4L6pNeRmNV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HjBDUZSJsQZ2coxesUj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation lg7COySOn33b0Y4okKt(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J6I9ExSIb6kNs7K25K4(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vJvVsbSDfb0LXhAvLbe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bIolrjSi8qVnaCBc7Hh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aeYp4ISnsOIMCifeSrB(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S11jhNSVW4Xucn7Y6LT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F3wZBtSfWUk4EIPrfFK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UHmdnASdA8BCeR0GYAf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b0KbHhSlRc83SiomQwu(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PNAoY9Sg9Vy8B1ipGYR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MlcVWSSs0QN2pR6xNof(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hUu376SvaOXPOvJgbCt(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QHK7p1Srb9jSeJs4Dkw(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellAt(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uGdKIhSPJEwdvI3N07y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P4ga36SZkL4KH988iJs(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Insert(P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qAdhl6SBNoKHNT60SDZ(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rp585qSbuXD7i0CVyl1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation sglZfnSGWn5J7ZOlHgn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)P_0);
	}
}
