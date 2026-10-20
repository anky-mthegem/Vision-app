using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class AddTcpServerOption : ISnippetUpdate
{
	private readonly SnippetLocalizer ogJG7QSiF1;

	private readonly CvsCellLocation tcJGNRvRf4;

	private readonly CvsCellLocation u7CGAkxMAE;

	private readonly CvsCellLocation TSbGd2Y67m;

	private readonly CvsCellLocation hUfG6NIxIk;

	private readonly CvsCellLocation iOvGuBgBjs;

	private readonly CvsCellLocation RWpGFpZfcd;

	private readonly CvsCellLocation S62GXDc0TK;

	private readonly CvsCellLocation C5vGodFg4a;

	private readonly CvsCellLocation xmgGScq8w3;

	private readonly CvsCellLocation iGdGDMEPVh;

	private readonly CvsCellLocation R84G3iKeCx;

	private readonly CvsCellLocation xJ3GIxLesJ;

	private readonly CvsCellLocation I1TGfo3X80;

	private readonly CvsCellLocation w0aGEbQubb;

	private readonly CvsCellLocation N9GGbOKnYq;

	private readonly CvsCellLocation BnuGcDPF21;

	private readonly CvsCellLocation hn9GQWkSTR;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddTcpServerOption(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		while (true)
		{
			switch (num)
			{
			case 9:
				rI9RlczRjPC5vQxW3lf();
				_ = 0;
				if (pr8m0pzCYMBpmKosl4q())
				{
					num = 6;
					continue;
				}
				num = 0;
				if (!pJiLjBzAV6pK7XY7SRp())
				{
					continue;
				}
				goto case 16;
			case 7:
				I1TGfo3X80 = new CvsCellLocation(2, 2);
				num = 8;
				continue;
			case 8:
				w0aGEbQubb = new CvsCellLocation(3, 1);
				num = 14;
				if (pr8m0pzCYMBpmKosl4q())
				{
					continue;
				}
				goto case 4;
			case 4:
				hUfG6NIxIk = new CvsCellLocation(4, 4);
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 10;
			case 10:
				S62GXDc0TK = new CvsCellLocation(2, 6);
				num = 16;
				continue;
			case 11:
				BnuGcDPF21 = new CvsCellLocation(3, 3);
				num = 5;
				continue;
			case 17:
				xJ3GIxLesJ = new CvsCellLocation(2, 5);
				num = 7;
				continue;
			case 14:
				N9GGbOKnYq = new CvsCellLocation(4, 1);
				num = 11;
				continue;
			case 1:
			case 6:
				tcJGNRvRf4 = new CvsCellLocation(3, 2);
				u7CGAkxMAE = new CvsCellLocation(4, 5);
				goto case 0;
			case 16:
				C5vGodFg4a = new CvsCellLocation(2, 3);
				num = 15;
				continue;
			case 13:
				ogJG7QSiF1 = localizer;
				num = 18;
				continue;
			case 5:
				hn9GQWkSTR = new CvsCellLocation(2, 1);
				VEe44pzWdMLWZhvcgiD(this);
				num = 13;
				continue;
			case 3:
				iOvGuBgBjs = new CvsCellLocation(4, 6);
				RWpGFpZfcd = new CvsCellLocation(2, 7);
				num = 10;
				continue;
			case 0:
			case 2:
				TSbGd2Y67m = new CvsCellLocation(4, 3);
				num = 4;
				continue;
			case 12:
				iGdGDMEPVh = new CvsCellLocation(2, 4);
				R84G3iKeCx = new CvsCellLocation(4, 2);
				goto case 17;
			default:
				num = 17;
				if (pr8m0pzCYMBpmKosl4q())
				{
					continue;
				}
				break;
			case 15:
				break;
			case 18:
				return;
			}
			xmgGScq8w3 = new CvsCellLocation(2, 0);
			num = 12;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0101;
		IL_001a:
		PasteBuffer pasteBuffer = new AddCellUpdate(R84G3iKeCx, WX9K1wsPEy, ogJG7QSiF1).Apply(pasteBuffer);
		num = 7;
		goto IL_0101;
		IL_0101:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 5:
				pasteBuffer = new EditCellStateUpdate(iOvGuBgBjs, CkDG5rPF4m(pasteBuffer), ogJG7QSiF1).Apply(pasteBuffer);
				num = 8;
				if (pJiLjBzAV6pK7XY7SRp())
				{
				}
				continue;
			case 4:
				pasteBuffer = new CellNameUpdate(iOvGuBgBjs, sMCGpeu7XJ(pasteBuffer), newNameIsInternal: true, isSupportSnippet: true).Apply(pasteBuffer);
				num = 12;
				continue;
			case 11:
				pasteBuffer = new AddCellUpdate(N9GGbOKnYq, DlsKm1Ldid, ogJG7QSiF1).Apply(originalSnippet);
				num = 9;
				continue;
			case 3:
				pasteBuffer = new EditCellStateUpdate(hn9GQWkSTR, OarKrxuqDf(pasteBuffer), ogJG7QSiF1).Apply(pasteBuffer);
				goto default;
			default:
				pasteBuffer = new EditCellStateUpdate(u7CGAkxMAE, aANGaS6P3M(pasteBuffer), ogJG7QSiF1).Apply(pasteBuffer);
				num = 5;
				if (pr8m0pzCYMBpmKosl4q())
				{
					continue;
				}
				goto case 9;
			case 9:
				pasteBuffer = new AddCellUpdate(w0aGEbQubb, H1NK9FNCjt, ogJG7QSiF1).Apply(pasteBuffer);
				pr8m0pzCYMBpmKosl4q();
				if (pJiLjBzAV6pK7XY7SRp())
				{
					num = 10;
					continue;
				}
				num = 1;
				if (!pJiLjBzAV6pK7XY7SRp())
				{
					continue;
				}
				goto case 8;
			case 8:
				pasteBuffer = new ExpressionEditUpdate(hUfG6NIxIk, TJlGUnsPkG, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return exp;
				}).Apply(pasteBuffer);
				num = 4;
				continue;
			case 7:
				pasteBuffer = new AddCellUpdate(TSbGd2Y67m, Mp7KzXUUIF, ogJG7QSiF1).Apply(pasteBuffer);
				num = 3;
				if (pr8m0pzCYMBpmKosl4q())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				pasteBuffer = new AddCellUpdate(tcJGNRvRf4, nHRKh1wlJx, ogJG7QSiF1).Apply(pasteBuffer);
				pasteBuffer = new AddCellUpdate(BnuGcDPF21, zOaK8SUbOq, ogJG7QSiF1).Apply(pasteBuffer);
				num = 0;
				continue;
			case 12:
				return pasteBuffer;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell H1NK9FNCjt(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pJiLjBzAV6pK7XY7SRp();
		int num = ((!pr8m0pzCYMBpmKosl4q()) ? 3 : 4);
		CvsCellLocation locationFromOrigin = default;
		CvsCellLocation cvsCellLocation = default;
		CvsCellLocation cvsCellLocation2 = default;
		CvsCellLocation cvsCellLocation3 = default;
		CvsCellLocation location = default;
		PasteBufferCell pasteBufferCell = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
			{
				CvsCellLocation loc = pXDl2KzTiFNWxdBKoIi(P_0, w0aGEbQubb);
				locationFromOrigin = P_0.GetLocationFromOrigin(I1TGfo3X80);
				cvsCellLocation = pXDl2KzTiFNWxdBKoIi(P_0, xJ3GIxLesJ);
				cvsCellLocation2 = pXDl2KzTiFNWxdBKoIi(P_0, S62GXDc0TK);
				cvsCellLocation3 = pXDl2KzTiFNWxdBKoIi(P_0, RWpGFpZfcd);
				location = pXDl2KzTiFNWxdBKoIi(P_0, N9GGbOKnYq);
				pasteBufferCell = new PasteBufferCell(loc);
				goto case 1;
			}
			case 1:
			case 3:
			{
				PasteBufferCell pasteBufferCell2 = pasteBufferCell;
				string[] array = new string[11]
				{
					(string)SbIgThzyt4Dq3CmE6dT(32800),
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					null
				};
				CvsCellLocation cvsCellLocation4 = locationFromOrigin;
				array[1] = cvsCellLocation4.ToString();
				array[2] = (string)SbIgThzyt4Dq3CmE6dT(32824);
				cvsCellLocation4 = cvsCellLocation;
				array[3] = cvsCellLocation4.ToString();
				array[4] = (string)SbIgThzyt4Dq3CmE6dT(32836);
				cvsCellLocation4 = cvsCellLocation;
				array[5] = cvsCellLocation4.ToString();
				array[6] = CdQUGaROfy7He9T0foW.KbIzwHEDLa(21486);
				cvsCellLocation4 = cvsCellLocation2;
				array[7] = cvsCellLocation4.ToString();
				array[8] = (string)SbIgThzyt4Dq3CmE6dT(5424);
				cvsCellLocation4 = cvsCellLocation3;
				array[9] = cvsCellLocation4.ToString();
				array[10] = (string)SbIgThzyt4Dq3CmE6dT(6970);
				KbyeBvzFS7noFtZdn4K(pasteBufferCell2, mAHFECz0P5EMdMpAH3X(array));
				goto case 2;
			}
			default:
				num = 2;
				break;
			case 2:
				XcjsGizUiJjVs1eFXKw(pasteBufferCell, JnJ2vTzYHeQlSri8fWC(r37qnKzMG0NFM3Q5QFI(P_0, location)));
				num = 5;
				break;
			case 5:
				return pasteBufferCell;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string OarKrxuqDf(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation location = pXDl2KzTiFNWxdBKoIi(P_0, TSbGd2Y67m);
		return (string)JnJ2vTzYHeQlSri8fWC(P_0.GetCellAt(location));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell nHRKh1wlJx(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (pr8m0pzCYMBpmKosl4q())
		{
			num = 5;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
			if (pJiLjBzAV6pK7XY7SRp())
			{
				goto IL_010d;
			}
		}
		goto IL_00d2;
		IL_00d2:
		PasteBufferCell pasteBufferCell = default;
		CvsCellLocation location = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 6:
				pasteBufferCell.Name = CdQUGaROfy7He9T0foW.KbIzwHEDLa(32880);
				goto default;
			case 0:
			case 5:
				goto IL_010d;
			case 2:
				pasteBufferCell.Value = null;
				num = 7;
				continue;
			default:
				pasteBufferCell.State = (string)JnJ2vTzYHeQlSri8fWC(r37qnKzMG0NFM3Q5QFI(P_0, location));
				num = 2;
				continue;
			case 7:
				return pasteBufferCell;
			}
			break;
		}
		goto IL_0026;
		IL_010d:
		CvsCellLocation loc = pXDl2KzTiFNWxdBKoIi(P_0, tcJGNRvRf4);
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(w0aGEbQubb);
		CvsCellLocation cvsCellLocation = pXDl2KzTiFNWxdBKoIi(P_0, xmgGScq8w3);
		CvsCellLocation cvsCellLocation2 = pXDl2KzTiFNWxdBKoIi(P_0, iGdGDMEPVh);
		location = pXDl2KzTiFNWxdBKoIi(P_0, N9GGbOKnYq);
		pasteBufferCell = new PasteBufferCell(loc);
		num = 1;
		goto IL_00d2;
		IL_0026:
		PasteBufferCell pasteBufferCell2 = pasteBufferCell;
		string[] array = new string[7]
		{
			(string)SbIgThzyt4Dq3CmE6dT(32852),
			null,
			null,
			null,
			null,
			null,
			null
		};
		CvsCellLocation cvsCellLocation3 = cvsCellLocation;
		array[1] = cvsCellLocation3.ToString();
		array[2] = (string)SbIgThzyt4Dq3CmE6dT(5424);
		cvsCellLocation3 = locationFromOrigin;
		array[3] = cvsCellLocation3.ToString();
		array[4] = (string)SbIgThzyt4Dq3CmE6dT(5424);
		cvsCellLocation3 = cvsCellLocation2;
		array[5] = cvsCellLocation3.ToString();
		array[6] = (string)SbIgThzyt4Dq3CmE6dT(6970);
		KbyeBvzFS7noFtZdn4K(pasteBufferCell2, mAHFECz0P5EMdMpAH3X(array));
		num = 6;
		goto IL_00d2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell zOaK8SUbOq(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(BnuGcDPF21);
		JObject jObject = new JObject();
		dZYNB2zx05nP3pVnFnQ(jObject, SbIgThzyt4Dq3CmE6dT(1624), U9c4wvzHorqOZtIAKsT(SbIgThzyt4Dq3CmE6dT(8344)));
		dZYNB2zx05nP3pVnFnQ(jObject, SbIgThzyt4Dq3CmE6dT(8360), DxtXQszmQJGNjO1FwWY(53));
		dZYNB2zx05nP3pVnFnQ(jObject, SbIgThzyt4Dq3CmE6dT(8368), (JToken)(string?)SbIgThzyt4Dq3CmE6dT(32942));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
		KbyeBvzFS7noFtZdn4K(pasteBufferCell, SbIgThzyt4Dq3CmE6dT(33090));
		XcjsGizUiJjVs1eFXKw(pasteBufferCell, "");
		reaRf3zQxQCLsltUegj(pasteBufferCell, SbIgThzyt4Dq3CmE6dT(33162));
		Vur8oCzNvbwM3aniVdR(pasteBufferCell, (JToken)1.0);
		lO1wyPz2RpW2dsadapY(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell DlsKm1Ldid(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pJiLjBzAV6pK7XY7SRp();
		int num;
		if (pr8m0pzCYMBpmKosl4q())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0098;
		IL_00bf:
		PasteBufferCell pasteBufferCell = default;
		reaRf3zQxQCLsltUegj(pasteBufferCell, CdQUGaROfy7He9T0foW.KbIzwHEDLa(33240));
		num = 5;
		goto IL_0098;
		IL_0098:
		CvsCellLocation locationFromOrigin = default;
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_00bf;
			case 0:
			case 4:
			{
				CvsCellLocation loc = pXDl2KzTiFNWxdBKoIi(P_0, N9GGbOKnYq);
				locationFromOrigin = P_0.GetLocationFromOrigin(C5vGodFg4a);
				cvsCellLocation = pXDl2KzTiFNWxdBKoIi(P_0, BnuGcDPF21);
				pasteBufferCell = new PasteBufferCell(loc);
				break;
			}
			case 5:
				return pasteBufferCell;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		PasteBufferCell pasteBufferCell2 = pasteBufferCell;
		string[] array = new string[5]
		{
			(string)SbIgThzyt4Dq3CmE6dT(18546),
			null,
			null,
			null,
			null
		};
		CvsCellLocation cvsCellLocation2 = cvsCellLocation;
		array[1] = cvsCellLocation2.ToString();
		array[2] = (string)SbIgThzyt4Dq3CmE6dT(33202);
		cvsCellLocation2 = locationFromOrigin;
		array[3] = cvsCellLocation2.ToString();
		array[4] = CdQUGaROfy7He9T0foW.KbIzwHEDLa(33220);
		KbyeBvzFS7noFtZdn4K(pasteBufferCell2, mAHFECz0P5EMdMpAH3X(array));
		goto IL_00bf;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell WX9K1wsPEy(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = pXDl2KzTiFNWxdBKoIi(P_0, R84G3iKeCx);
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(tcJGNRvRf4);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		object obj = SbIgThzyt4Dq3CmE6dT(33292);
		CvsCellLocation cvsCellLocation = locationFromOrigin;
		pasteBufferCell.Expression = (string)zWwnenzc3k3Uw8aNHTY(obj, cvsCellLocation.ToString(), SbIgThzyt4Dq3CmE6dT(6970));
		pasteBufferCell.Name = CdQUGaROfy7He9T0foW.KbIzwHEDLa(33312);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell Mp7KzXUUIF(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pJiLjBzAV6pK7XY7SRp();
		int num = ((!pr8m0pzCYMBpmKosl4q()) ? 1 : 3);
		PasteBufferCell pasteBufferCell = default;
		CvsCellLocation cvsCellLocation2 = default;
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			{
				PasteBufferCell pasteBufferCell2 = pasteBufferCell;
				string[] array = new string[5]
				{
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(18546),
					null,
					null,
					null,
					null
				};
				CvsCellLocation cvsCellLocation3 = cvsCellLocation2;
				array[1] = cvsCellLocation3.ToString();
				array[2] = (string)SbIgThzyt4Dq3CmE6dT(33358);
				cvsCellLocation3 = cvsCellLocation;
				array[3] = cvsCellLocation3.ToString();
				array[4] = (string)SbIgThzyt4Dq3CmE6dT(33220);
				KbyeBvzFS7noFtZdn4K(pasteBufferCell2, mAHFECz0P5EMdMpAH3X(array));
				goto default;
			}
			default:
				reaRf3zQxQCLsltUegj(pasteBufferCell, SbIgThzyt4Dq3CmE6dT(33376));
				num = 5;
				continue;
			case 0:
			case 3:
			{
				CvsCellLocation loc = pXDl2KzTiFNWxdBKoIi(P_0, TSbGd2Y67m);
				cvsCellLocation = pXDl2KzTiFNWxdBKoIi(P_0, C5vGodFg4a);
				cvsCellLocation2 = pXDl2KzTiFNWxdBKoIi(P_0, BnuGcDPF21);
				pasteBufferCell = new PasteBufferCell(loc);
				num = 4;
				if (true)
				{
					continue;
				}
				break;
			}
			case 5:
				break;
			}
			break;
		}
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string aANGaS6P3M(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation location = pXDl2KzTiFNWxdBKoIi(P_0, TSbGd2Y67m);
		return (string)JnJ2vTzYHeQlSri8fWC(P_0.GetCellAt(location));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string CkDG5rPF4m(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation location = pXDl2KzTiFNWxdBKoIi(P_0, TSbGd2Y67m);
		return ((PasteBufferCell)r37qnKzMG0NFM3Q5QFI(P_0, location)).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string sMCGpeu7XJ(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)SbIgThzyt4Dq3CmE6dT(33428);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string TJlGUnsPkG(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCellLocation locationFromOrigin2 = default;
		CvsCellLocation locationFromOrigin = default;
		CvsCellLocation cvsCellLocation2 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				locationFromOrigin2 = P_0.GetLocationFromOrigin(u7CGAkxMAE);
				goto default;
			case 4:
				locationFromOrigin = P_0.GetLocationFromOrigin(TSbGd2Y67m);
				pr8m0pzCYMBpmKosl4q();
				num = ((!pJiLjBzAV6pK7XY7SRp()) ? 3 : 0);
				break;
			default:
				cvsCellLocation2 = pXDl2KzTiFNWxdBKoIi(P_0, iOvGuBgBjs);
				num = 5;
				break;
			case 5:
			{
				string[] array = new string[6];
				CvsCellLocation cvsCellLocation = locationFromOrigin;
				array[0] = cvsCellLocation.ToString();
				array[1] = (string)SbIgThzyt4Dq3CmE6dT(33490);
				cvsCellLocation = locationFromOrigin2;
				array[2] = cvsCellLocation.ToString();
				array[3] = (string)SbIgThzyt4Dq3CmE6dT(33524);
				cvsCellLocation = cvsCellLocation2;
				array[4] = cvsCellLocation.ToString();
				array[5] = CdQUGaROfy7He9T0foW.KbIzwHEDLa(33566);
				return (string)mAHFECz0P5EMdMpAH3X(array);
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rI9RlczRjPC5vQxW3lf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VEe44pzWdMLWZhvcgiD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pr8m0pzCYMBpmKosl4q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pJiLjBzAV6pK7XY7SRp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation pXDl2KzTiFNWxdBKoIi(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SbIgThzyt4Dq3CmE6dT(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mAHFECz0P5EMdMpAH3X(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KbyeBvzFS7noFtZdn4K(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r37qnKzMG0NFM3Q5QFI(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellAt(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JnJ2vTzYHeQlSri8fWC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XcjsGizUiJjVs1eFXKw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U9c4wvzHorqOZtIAKsT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dZYNB2zx05nP3pVnFnQ(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DxtXQszmQJGNjO1FwWY(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void reaRf3zQxQCLsltUegj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vur8oCzNvbwM3aniVdR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lO1wyPz2RpW2dsadapY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zWwnenzc3k3Uw8aNHTY(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
