using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance.DistanceUpdates;

public class AddTransWorldToPixelCellUpdateLtl : ISnippetUpdate
{
	private static readonly CvsCellLocation wpsThNcGPA;

	private static readonly CvsCellLocation hndT80ryV6;

	private static readonly CvsCellLocation aDRTmBXFxk;

	private static readonly CvsCellLocation LdlT1WJl0t;

	private static readonly CvsCellLocation dlCTzhWBwy;

	private static readonly CvsCellLocation ydnWasdYIv;

	private static readonly CvsCellLocation lyQW5UVOph;

	private static readonly CvsCellLocation Vd1WpNpMVX;

	private static readonly CvsCellLocation c3eWU65JA4;

	private static readonly CvsCellLocation PnEW7dbfrU;

	private static readonly CvsCellLocation z0FWNfHAwE;

	private static readonly CvsCellLocation DoqWACFyxq;

	private readonly AddCellUpdate VVKWdMAUor;

	private readonly AddCellUpdate cnmW6hvp35;

	private readonly AddCellUpdate ug3Wurm8nV;

	private readonly AddCellUpdate XdQWFJNAZf;

	private readonly AddCellUpdate l6XWXG0XnP;

	private readonly LocationUpdate YeEWoDCEOJ;

	private readonly LocationUpdate coSWSCqEBI;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddTransWorldToPixelCellUpdateLtl(SnippetLocalizer localizer, CvsFunctionTable table, IExpressionConstants constants)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!lkW7KxCP2Jhvf5Dt5Pq())
		{
			goto IL_001e;
		}
		goto IL_0163;
		IL_001e:
		cnmW6hvp35 = new AddCellUpdate(lyQW5UVOph, almTVuD4Zy, lyQW5UVOph, localizer);
		O1sGjPCZBonD1v8SwrO();
		num = ((!lkW7KxCP2Jhvf5Dt5Pq()) ? 3 : 6);
		goto IL_0163;
		IL_0163:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
				XdQWFJNAZf = new AddCellUpdate(c3eWU65JA4, almTVuD4Zy, c3eWU65JA4, localizer);
				num = 0;
				continue;
			case 3:
			case 7:
				YeEWoDCEOJ = new LocationUpdate(dlCTzhWBwy, hndT80ryV6, SnippetUpdateHelper.GetAbsRefLocationOfCell, c3eWU65JA4, table, constants);
				num = 10;
				continue;
			case 10:
				coSWSCqEBI = new LocationUpdate(dlCTzhWBwy, aDRTmBXFxk, SnippetUpdateHelper.GetAbsRefLocationOfCell, PnEW7dbfrU, table, constants);
				num = 11;
				continue;
			case 0:
				l6XWXG0XnP = new AddCellUpdate(PnEW7dbfrU, almTVuD4Zy, PnEW7dbfrU, localizer);
				goto case 3;
			case 1:
				RNcKC7CBriWGd5uhTAp();
				num = 8;
				continue;
			case 4:
			case 6:
				ug3Wurm8nV = new AddCellUpdate(Vd1WpNpMVX, almTVuD4Zy, Vd1WpNpMVX, localizer);
				goto case 2;
			default:
				num = 2;
				continue;
			case 8:
				sH87SHCbIImduBHLkD2(this);
				num = 9;
				continue;
			case 9:
				VVKWdMAUor = new AddCellUpdate(ydnWasdYIv, H3aT0MhGUF, localizer);
				num = 5;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				pasteBuffer = YeEWoDCEOJ.Apply(pasteBuffer);
				num = 1;
				break;
			case 7:
				pasteBuffer = (PasteBuffer)rrtilsCGga77rTQZUbR(originalSnippet);
				num = 4;
				break;
			case 5:
			case 10:
				pasteBuffer = (PasteBuffer)tpoUZXCokJ4BreUSoIW(l6XWXG0XnP, pasteBuffer);
				goto case 2;
			case 4:
				pasteBuffer = VVKWdMAUor.Apply(pasteBuffer);
				num = 3;
				break;
			case 8:
				pasteBuffer = (PasteBuffer)tpoUZXCokJ4BreUSoIW(XdQWFJNAZf, pasteBuffer);
				goto default;
			default:
				_ = 0;
				if (!lkW7KxCP2Jhvf5Dt5Pq())
				{
					num = 2;
					break;
				}
				num = 10;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				pasteBuffer = (PasteBuffer)cQmsFOCkg1sqBfL7fCk(coSWSCqEBI, pasteBuffer);
				num = 11;
				break;
			case 3:
				pasteBuffer = cnmW6hvp35.Apply(pasteBuffer);
				num = 0;
				if (O1sGjPCZBonD1v8SwrO())
				{
				}
				break;
			case 0:
				pasteBuffer = ug3Wurm8nV.Apply(pasteBuffer);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 6:
				pasteBuffer = (PasteBuffer)HGVGYgCSAydRpG7CLWN(pasteBuffer, LdlT1WJl0t, wpsThNcGPA, lyQW5UVOph, Vd1WpNpMVX);
				num = 9;
				break;
			case 11:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell H3aT0MhGUF(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = IB4abEC8cJqkLLFG8ni(P_0, ydnWasdYIv);
		string text = SnippetUpdateHelper.InputImageLocationFactory(P_0);
		string text2 = (string)GO8dtuCq5jpkLVbrrw7(CdQUGaROfy7He9T0foW.KbIzwHEDLa(26642), text);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		igAwTGCEMSBrR17aNaW(pasteBufferCell, text2);
		dw8ow9CpYFsPPh7RG2H(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell almTVuD4Zy(PasteBuffer P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = IB4abEC8cJqkLLFG8ni(P_0, P_1);
		string text = vWJTJxnUll(P_0, P_1);
		CvsCellLocation cellOffset = ptoJIBCXODuJNK6EI61(P_1);
		string absRefLocationOfCell = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, cellOffset);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		igAwTGCEMSBrR17aNaW(pasteBufferCell, text);
		dw8ow9CpYFsPPh7RG2H(pasteBufferCell, "");
		HGtMkTC9wZGVHBhPA2s(pasteBufferCell, absRefLocationOfCell);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBuffer t9aTLQbTDj(PasteBuffer P_0, CvsCellLocation P_1, CvsCellLocation P_2, CvsCellLocation P_3, CvsCellLocation P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		IReadOnlyCollection<string> source = default;
		PasteBufferCell pasteBufferCell = default;
		string text7 = default;
		string text6 = default;
		string text3 = default;
		string text4 = default;
		string text2 = default;
		string newValue = default;
		int num2 = default;
		PasteBuffer pasteBuffer = default;
		string text = default;
		string text5 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				source = CvsParse.FindAllArgs((string)UoK409C7xJyRCOHAslv(pasteBufferCell)).ToReadonlyList();
				num = 10;
				continue;
			case 6:
				text7 = (string)aiJ9D6C6IvnGrxcQOWb(U4ctq9CjMk0jSBwHHdC(1832), text6, CdQUGaROfy7He9T0foW.KbIzwHEDLa(26692));
				num = 12;
				continue;
			case 1:
				if (Ah62SeCCF1MsoLB2oMg(text3, text4))
				{
					num = 15;
					if (0 == 0)
					{
						continue;
					}
				}
				else if (Ah62SeCCF1MsoLB2oMg(text3, text7))
				{
					text2 = text3.Replace(text7, newValue);
					goto case 0;
				}
				goto case 4;
			case 4:
				num2++;
				goto case 8;
			case 9:
				pasteBufferCell = (PasteBufferCell)chRpSCC4HE61mZSL0o8(pasteBuffer, P_1);
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 10;
			case 10:
				text6 = (string)qhqcplC3X3PnlP3YWlV(P_0, P_2);
				text4 = (string)U4ctq9CjMk0jSBwHHdC(1832) + text6 + (string)U4ctq9CjMk0jSBwHHdC(6970);
				num = 6;
				continue;
			case 0:
				igAwTGCEMSBrR17aNaW(pasteBufferCell, n7Fje7CRbq4Xsm8cyVq(pasteBufferCell.Expression, num2, text2));
				num = 4;
				continue;
			case 8:
			case 11:
			case 14:
				if (num2 < source.Count())
				{
					text3 = source.ElementAt(num2);
					num = 1;
					continue;
				}
				num = 17;
				if (!O1sGjPCZBonD1v8SwrO())
				{
					continue;
				}
				goto case 3;
			case 3:
				text = (string)qhqcplC3X3PnlP3YWlV(P_0, P_4);
				_ = 1;
				num = ((!O1sGjPCZBonD1v8SwrO()) ? 16 : 11);
				continue;
			case 12:
			{
				string absRefLocationOfCell = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, P_3);
				text5 = (string)aiJ9D6C6IvnGrxcQOWb(U4ctq9CjMk0jSBwHHdC(1832), absRefLocationOfCell, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6970));
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 13;
			}
			case 13:
				pasteBuffer = P_0.Clone();
				num = 9;
				continue;
			case 5:
				num2 = 0;
				num = 8;
				continue;
			case 15:
				text2 = (string)LqcE95CAMTVGrU4JuGq(text3, text4, text5);
				num = 0;
				continue;
			case 7:
			case 16:
				newValue = (string)U4ctq9CjMk0jSBwHHdC(1832) + text + (string)U4ctq9CjMk0jSBwHHdC(6970);
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 17:
				break;
			}
			break;
		}
		return pasteBuffer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string vWJTJxnUll(PasteBuffer P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!O1sGjPCZBonD1v8SwrO())
		{
			num = 8;
		}
		else
		{
			num = 6;
			if (!lkW7KxCP2Jhvf5Dt5Pq())
			{
				goto IL_0110;
			}
		}
		string text4 = default;
		CvsCellLocation cellOffset = default;
		string text2 = default;
		string text3 = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				text4 = (string)qhqcplC3X3PnlP3YWlV(P_0, cellOffset);
				goto case 4;
			default:
				num = 4;
				if (!O1sGjPCZBonD1v8SwrO())
				{
					continue;
				}
				goto case 5;
			case 5:
				text2 = (string)U4ctq9CjMk0jSBwHHdC(26702);
				num = 7;
				if (lkW7KxCP2Jhvf5Dt5Pq())
				{
					continue;
				}
				goto case 1;
			case 1:
				text3 = (string)qhqcplC3X3PnlP3YWlV(P_0, ydnWasdYIv);
				num = 2;
				continue;
			case 4:
				if (MVvH9gCTyy09XIdqoJ0(P_1, Vd1WpNpMVX))
				{
					num = 5;
					continue;
				}
				text2 = (string)U4ctq9CjMk0jSBwHHdC(26810);
				num = 9;
				continue;
			case 0:
			case 8:
				text = SnippetUpdateHelper.InputImageLocationFactory(P_0);
				num = 1;
				continue;
			case 2:
				cellOffset = JSyNXpCWipqIHPatHeS(P_1);
				goto case 3;
			case 7:
			case 9:
				break;
			}
			break;
		}
		goto IL_0110;
		IL_0110:
		return (string)E8aQ0bCyyWOfuX7657B(text2, text, text3, text4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsCellLocation ODfT9q5H3V(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!O1sGjPCZBonD1v8SwrO()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (MVvH9gCTyy09XIdqoJ0(P_0, Vd1WpNpMVX))
				{
					num = 2;
					break;
				}
				if (!MVvH9gCTyy09XIdqoJ0(P_0, c3eWU65JA4))
				{
					if (MVvH9gCTyy09XIdqoJ0(P_0, PnEW7dbfrU))
					{
						num = 6;
						break;
					}
					return B0aPVwC0eWwUp1dFNqr(null);
				}
				goto default;
			default:
				return hndT80ryV6;
			case 0:
			case 1:
				if (!MVvH9gCTyy09XIdqoJ0(P_0, lyQW5UVOph))
				{
					num = 5;
					break;
				}
				goto case 2;
			case 2:
				return wpsThNcGPA;
			case 6:
				return aDRTmBXFxk;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsCellLocation q6fTr7LdUB(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lkW7KxCP2Jhvf5Dt5Pq();
		int num = (O1sGjPCZBonD1v8SwrO() ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (MVvH9gCTyy09XIdqoJ0(P_0, PnEW7dbfrU))
				{
					num = 6;
					if (lkW7KxCP2Jhvf5Dt5Pq())
					{
						break;
					}
					goto case 3;
				}
				return B0aPVwC0eWwUp1dFNqr(null);
			case 3:
				return z0FWNfHAwE;
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				if (!MVvH9gCTyy09XIdqoJ0(P_0, Vd1WpNpMVX))
				{
					if (!MVvH9gCTyy09XIdqoJ0(P_0, c3eWU65JA4))
					{
						goto case 5;
					}
					goto case 6;
				}
				num = 3;
				break;
			case 0:
			case 4:
				if (MVvH9gCTyy09XIdqoJ0(P_0, lyQW5UVOph))
				{
					goto case 3;
				}
				goto case 1;
			case 6:
				return DoqWACFyxq;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AddTransWorldToPixelCellUpdateLtl()
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
				PnEW7dbfrU = new CvsCellLocation(6, 7);
				num = 1;
				if (!O1sGjPCZBonD1v8SwrO())
				{
					break;
				}
				goto default;
			default:
				Vd1WpNpMVX = new CvsCellLocation(5, 7);
				num = 0;
				break;
			case 7:
				RNcKC7CBriWGd5uhTAp();
				num = 10;
				if (true)
				{
					break;
				}
				goto case 11;
			case 11:
				DoqWACFyxq = new CvsCellLocation(4, 7);
				num = 13;
				if (lkW7KxCP2Jhvf5Dt5Pq())
				{
					break;
				}
				goto case 3;
			case 3:
			case 5:
				aDRTmBXFxk = new CvsCellLocation(2, 3);
				LdlT1WJl0t = new CvsCellLocation(3, 5);
				num = 9;
				break;
			case 9:
				dlCTzhWBwy = new CvsCellLocation(4, 5);
				ydnWasdYIv = new CvsCellLocation(6, 5);
				num = 2;
				break;
			case 10:
				wpsThNcGPA = new CvsCellLocation(3, 2);
				num = 12;
				break;
			case 2:
				lyQW5UVOph = new CvsCellLocation(5, 6);
				goto default;
			case 0:
				c3eWU65JA4 = new CvsCellLocation(6, 6);
				num = 4;
				break;
			case 1:
				z0FWNfHAwE = new CvsCellLocation(3, 7);
				num = 11;
				break;
			case 12:
				hndT80ryV6 = new CvsCellLocation(1, 3);
				O1sGjPCZBonD1v8SwrO();
				if (!lkW7KxCP2Jhvf5Dt5Pq())
				{
					num = 8;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				num = 5;
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RNcKC7CBriWGd5uhTAp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sH87SHCbIImduBHLkD2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lkW7KxCP2Jhvf5Dt5Pq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O1sGjPCZBonD1v8SwrO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rrtilsCGga77rTQZUbR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tpoUZXCokJ4BreUSoIW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AddCellUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HGVGYgCSAydRpG7CLWN(object P_0, CvsCellLocation P_1, CvsCellLocation P_2, CvsCellLocation P_3, CvsCellLocation P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return t9aTLQbTDj((PasteBuffer)P_0, P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cQmsFOCkg1sqBfL7fCk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LocationUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation IB4abEC8cJqkLLFG8ni(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GO8dtuCq5jpkLVbrrw7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void igAwTGCEMSBrR17aNaW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dw8ow9CpYFsPPh7RG2H(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation ptoJIBCXODuJNK6EI61(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return q6fTr7LdUB(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HGtMkTC9wZGVHBhPA2s(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object chRpSCC4HE61mZSL0o8(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithOffset(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UoK409C7xJyRCOHAslv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qhqcplC3X3PnlP3YWlV(object P_0, CvsCellLocation cellOffset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetUpdateHelper.GetAbsRefLocationOfCell((PasteBuffer)P_0, cellOffset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U4ctq9CjMk0jSBwHHdC(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aiJ9D6C6IvnGrxcQOWb(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ah62SeCCF1MsoLB2oMg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Contains((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LqcE95CAMTVGrU4JuGq(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n7Fje7CRbq4Xsm8cyVq(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation JSyNXpCWipqIHPatHeS(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ODfT9q5H3V(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MVvH9gCTyy09XIdqoJ0(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E8aQ0bCyyWOfuX7657B(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation B0aPVwC0eWwUp1dFNqr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0;
	}
}
