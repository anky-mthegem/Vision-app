using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELClassify.Updates;

public class UnclassifedDetectionUpdate : ISnippetUpdate
{
	private readonly SnippetLocalizer eY7DwUlIKm;

	private readonly int srCDyPmiCP;

	private CvsCellLocation BHyDxEw717;

	private CvsCellLocation oa5DvgM7cy;

	private CvsCellLocation khEDeeUuCU;

	private CvsCellLocation HJYD2GyqBo;

	private CvsCellLocation xxjDq0p6Bs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnclassifedDetectionUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				BHyDxEw717 = new CvsCellLocation(3, 6);
				num = 9;
				continue;
			case 8:
				xxjDq0p6Bs = new CvsCellLocation(10, 4);
				num = 7;
				continue;
			case 5:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 10;
				continue;
			case 9:
				oa5DvgM7cy = new CvsCellLocation(7, 6);
				goto case 3;
			case 0:
				HJYD2GyqBo = new CvsCellLocation(4, 0);
				num = 8;
				continue;
			case 3:
			case 4:
				khEDeeUuCU = new CvsCellLocation(7, 7);
				goto case 0;
			default:
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				VLdxCVBi5JnS8E9IEus(this);
				num = 6;
				continue;
			case 6:
				eY7DwUlIKm = localizer;
				num = 11;
				if (true)
				{
					continue;
				}
				break;
			case 10:
				break;
			case 11:
				return;
			}
			srCDyPmiCP = 13;
			uj6ac2BIc2F40cRGvri();
			if (BFRyhwBDmDnspZ0DLgH())
			{
				num = 3;
				continue;
			}
			num = 1;
			if (false)
			{
				break;
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
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_009b;
		IL_001a:
		PasteBuffer pasteBuffer = new ExpressionEditUpdate(xxjDq0p6Bs, XjxDOcffuE, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return exp;
		}).Apply(pasteBuffer);
		num = 7;
		goto IL_009b;
		IL_009b:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 2:
			case 6:
				pasteBuffer = new AddCellUpdate(oa5DvgM7cy, vyhDjhEeo9, eY7DwUlIKm).Apply(pasteBuffer);
				goto case 5;
			default:
				num = 5;
				continue;
			case 1:
			case 3:
				pasteBuffer = new ExpressionEditUpdate(HJYD2GyqBo, Nt0DWl7Wma, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return exp;
				}).Apply(pasteBuffer);
				goto case 2;
			case 5:
				pasteBuffer = new AddCellUpdate(khEDeeUuCU, U6ZDCpRnTp, eY7DwUlIKm).Apply(pasteBuffer);
				num = 0;
				continue;
			case 4:
				pasteBuffer = new AddCellUpdate(BHyDxEw717, wewDT2P0mV, eY7DwUlIKm).Apply(originalSnippet);
				_ = 1;
				if (BFRyhwBDmDnspZ0DLgH())
				{
					num = 6;
					if (uj6ac2BIc2F40cRGvri())
					{
						continue;
					}
					goto case 5;
				}
				num = 3;
				continue;
			case 7:
				return pasteBuffer;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell wewDT2P0mV(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string snippetName = (string)wqgmI4BnXO1yFPQ48gX(P_0);
		CvsCellLocation loc = XkRuIBBVsuBVA4Y8s5L(P_0, BHyDxEw717);
		JObject jObject = new JObject { [(string)vFISiDBfiv6gqbH5F23(1624)] = (JToken?)atTKluBdUgkSdxLy8is(CdQUGaROfy7He9T0foW.KbIzwHEDLa(8344)) };
		n7ejiTBgSjCljJeQw6r(jObject, vFISiDBfiv6gqbH5F23(8360), Qyv1GWBlROMIsAte1QR(11));
		n7ejiTBgSjCljJeQw6r(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368), atTKluBdUgkSdxLy8is(vFISiDBfiv6gqbH5F23(8384)));
		JObject jObject2 = jObject;
		string state = AmHDHpoaoC(P_0, (string)vFISiDBfiv6gqbH5F23(8420));
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc)
		{
			Expression = (string)vFISiDBfiv6gqbH5F23(8450),
			State = state,
			Name = EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(7670)),
			Value = (JToken)sGwZdLBs2PCxvN9OcDe(0.0)
		};
		VvkmeTBvxStuZfdgx78(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string Nt0DWl7Wma(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsParse.FindAllArgs(P_1).Count();
		string text = XkRuIBBVsuBVA4Y8s5L(P_0, BHyDxEw717).ToString(absoluteRow: true, absoluteColumn: true);
		string text2 = AmHDHpoaoC(P_0, (string)vFISiDBfiv6gqbH5F23(7842));
		return (string)votj2TBrZpjY1gsYmvN(votj2TBrZpjY1gsYmvN(P_1, 10, text), 11, text2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell vyhDjhEeo9(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PasteBufferCell pasteBufferCell = new PasteBufferCell(P_0.GetLocationFromOrigin(oa5DvgM7cy));
		WmY7J1BPcKKV0rlSrhJ(pasteBufferCell, vFISiDBfiv6gqbH5F23(8522));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell U6ZDCpRnTp(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string snippetName = (string)wqgmI4BnXO1yFPQ48gX(P_0);
		CvsCellLocation loc = XkRuIBBVsuBVA4Y8s5L(P_0, khEDeeUuCU);
		string text = AmHDHpoaoC(P_0, (string)vFISiDBfiv6gqbH5F23(7538));
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		WmY7J1BPcKKV0rlSrhJ(pasteBufferCell, MG0KEVBZ9lPX9ZVl7ou(vFISiDBfiv6gqbH5F23(8558), text, vFISiDBfiv6gqbH5F23(6970)));
		Syq6FLBBdrtGIjcoLfg(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, (string)vFISiDBfiv6gqbH5F23(7766), isInternal: true));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string XjxDOcffuE(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string text3 = default;
		string text2 = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				text3 = AmHDHpoaoC(P_0, (string)vFISiDBfiv6gqbH5F23(7810));
				goto default;
			default:
				text2 = AmHDHpoaoC(P_0, (string)vFISiDBfiv6gqbH5F23(7538));
				num = 5;
				break;
			case 0:
				text = AmHDHpoaoC(P_0, (string)vFISiDBfiv6gqbH5F23(8040), _0020: true);
				_ = 1;
				num = ((!BFRyhwBDmDnspZ0DLgH()) ? 4 : 3);
				break;
			case 5:
				return (string)vFISiDBfiv6gqbH5F23(8126) + text + CdQUGaROfy7He9T0foW.KbIzwHEDLa(8146) + text2 + (string)vFISiDBfiv6gqbH5F23(8180) + text3 + (string)vFISiDBfiv6gqbH5F23(8598);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string AmHDHpoaoC(PasteBuffer P_0, string P_1, bool P_2 = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)uysyIEBbWm81cuvtJP1(SnippetPasteBuffer.GetCellInTool(P_0, P_1, P_2))).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VLdxCVBi5JnS8E9IEus(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uj6ac2BIc2F40cRGvri()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BFRyhwBDmDnspZ0DLgH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wqgmI4BnXO1yFPQ48gX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation XkRuIBBVsuBVA4Y8s5L(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vFISiDBfiv6gqbH5F23(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object atTKluBdUgkSdxLy8is(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Qyv1GWBlROMIsAte1QR(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n7ejiTBgSjCljJeQw6r(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sGwZdLBs2PCxvN9OcDe(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VvkmeTBvxStuZfdgx78(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object votj2TBrZpjY1gsYmvN(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WmY7J1BPcKKV0rlSrhJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MG0KEVBZ9lPX9ZVl7ou(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Syq6FLBBdrtGIjcoLfg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uysyIEBbWm81cuvtJP1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}
}
