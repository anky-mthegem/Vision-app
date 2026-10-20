using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax.PatMaxUpdates;

public class AddGranularityUpdate : ISnippetUpdate
{
	private readonly SnippetLocalizer QSlcJc6N9P;

	private readonly CvsCellLocation L1bc9pQtbf;

	private CvsCellLocation snacrGZmW1;

	private CvsCellLocation E2ichRYZdv;

	private CvsCellLocation IHAc81Z0qy;

	private CvsCellLocation AGWcmi2pI8;

	private CvsCellLocation g61c1KVcIS;

	private CvsCellLocation aU7czXjsDx;

	private CvsCellLocation OBDQa3khbP;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddGranularityUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gM9PNhqzDUfUGGygbbF();
		int num;
		if (!vYNX69ELBapN6qFUqsx())
		{
			num = 9;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0116;
		IL_002a:
		E2ichRYZdv = new CvsCellLocation(9, 6);
		num = 10;
		goto IL_0116;
		IL_0116:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 6:
				L1bc9pQtbf = new CvsCellLocation(2, 6);
				num = 11;
				if (gM9PNhqzDUfUGGygbbF())
				{
					continue;
				}
				goto case 10;
			case 10:
				IHAc81Z0qy = new CvsCellLocation(10, 0);
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				g61c1KVcIS = new CvsCellLocation(10, 2);
				goto case 3;
			case 8:
				QSlcJc6N9P = localizer;
				num = 12;
				continue;
			case 0:
			case 9:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 6;
				continue;
			case 3:
			case 7:
				aU7czXjsDx = new CvsCellLocation(10, 3);
				OBDQa3khbP = new CvsCellLocation(10, 6);
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 11;
			case 11:
				snacrGZmW1 = new CvsCellLocation(8, 5);
				num = 1;
				continue;
			case 4:
				AGWcmi2pI8 = new CvsCellLocation(10, 1);
				goto case 5;
			default:
				num = 5;
				if (gM9PNhqzDUfUGGygbbF())
				{
					continue;
				}
				goto case 2;
			case 2:
				wir7fGEK5YnrT8nGTvj(this);
				num = 8;
				if (gM9PNhqzDUfUGGygbbF())
				{
					continue;
				}
				return;
			case 12:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		int num2 = default;
		PasteBuffer pasteBuffer = default;
		CvsCellLocation cvsCellLocation = default;
		CvsCellRange cvsCellRange = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				g61c1KVcIS.Row = num2;
				num = 11;
				continue;
			case 12:
				pasteBuffer = new AddCellUpdate(g61c1KVcIS, UmjctCvbnt, QSlcJc6N9P).Apply(pasteBuffer);
				num = 2;
				continue;
			case 0:
				pasteBuffer = new AddCellUpdate(AGWcmi2pI8, dODcnbQyIb, QSlcJc6N9P).Apply(pasteBuffer);
				goto case 12;
			default:
				num = 12;
				continue;
			case 11:
				aU7czXjsDx.Row = num2;
				OBDQa3khbP.Row = num2;
				num = 9;
				continue;
			case 4:
				pasteBuffer = new AddCellUpdate(snacrGZmW1, wuPc0YDxaC, QSlcJc6N9P).Apply(pasteBuffer);
				num = 17;
				continue;
			case 9:
				snacrGZmW1.Row = num2 - 2;
				num = 1;
				continue;
			case 13:
				cvsCellLocation = CvsCellLocation.Parse((string)mM5SRJEJCw0uSRhPUsc(MG4kdxEwEplZAIHDFMH(pasteBuffer, snacrGZmW1)));
				num = 16;
				continue;
			case 16:
			{
				string newArg = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				pasteBuffer = new EditArgumentUpdate(E2ichRYZdv, newArg, 0, QSlcJc6N9P).Apply(pasteBuffer);
				goto case 14;
			}
			case 2:
				pasteBuffer = new AddCellUpdate(aU7czXjsDx, uTOcYWWeI2, QSlcJc6N9P).Apply(pasteBuffer);
				num = 4;
				continue;
			case 8:
				pasteBuffer = new AddCellUpdate(IHAc81Z0qy, JTGcZ4eCPf, QSlcJc6N9P).Apply(originalSnippet);
				num = 0;
				continue;
			case 1:
				E2ichRYZdv.Row = num2 - 1;
				num = 8;
				if (!vYNX69ELBapN6qFUqsx())
				{
					continue;
				}
				goto case 14;
			case 14:
			case 15:
				pasteBuffer = new ExpressionEditUpdate(OBDQa3khbP, SgqcLAPogo, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return exp;
				}).Apply(pasteBuffer);
				num = 18;
				continue;
			case 10:
				cvsCellRange = oGNKUtE5IvhWOtjj4dj(originalSnippet);
				num = 7;
				continue;
			case 7:
				num2 = cvsCellRange.Size.Height - 1;
				IHAc81Z0qy.Row = num2;
				num = 5;
				if (vYNX69ELBapN6qFUqsx())
				{
				}
				continue;
			case 17:
				pasteBuffer = new ExpressionEditUpdate(L1bc9pQtbf, aGLcVPt6Sd, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return exp;
				}).Apply(pasteBuffer);
				num = 13;
				continue;
			case 5:
				AGWcmi2pI8.Row = num2;
				_ = 1;
				if (vYNX69ELBapN6qFUqsx())
				{
					num = 14;
					continue;
				}
				num = 6;
				if (!vYNX69ELBapN6qFUqsx())
				{
					continue;
				}
				break;
			case 18:
				break;
			}
			break;
		}
		return pasteBuffer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string dbvcBqdfop(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)mM5SRJEJCw0uSRhPUsc(SnippetPasteBuffer.GetCellInTool(P_0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8420)))).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell JTGcZ4eCPf(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(IHAc81Z0qy);
		string text = dbvcBqdfop(P_0);
		string snippetName = (string)da9VnmEaoH5NIDadLqZ(P_0);
		JObject jObject = new JObject();
		oWWRIMEIZx78iR7ISsy(jObject, fXbTcTEen9ejDTJrjhR(1624), UISIodEOiOGfmC3pRha(CdQUGaROfy7He9T0foW.KbIzwHEDLa(8344)));
		jObject[CdQUGaROfy7He9T0foW.KbIzwHEDLa(8360)] = (JToken?)tBW6kNEDhIg2LQVc4Ef(27);
		jObject[(string)fXbTcTEen9ejDTJrjhR(8368)] = (string?)fXbTcTEen9ejDTJrjhR(21012);
		JObject data = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin)
		{
			Expression = CdQUGaROfy7He9T0foW.KbIzwHEDLa(21088)
		};
		kxVTvUEivZV4y99lolK(pasteBufferCell, text);
		zAUtwMEnTqAyDDGpfjE(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, (string)fXbTcTEen9ejDTJrjhR(20410)));
		vPWvDFEVcYfST5YQOWq(pasteBufferCell, (JToken)1.0);
		pasteBufferCell.Data = data;
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell dODcnbQyIb(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = AYsh2lEf8XH4KmBD3k7(P_0, AGWcmi2pI8);
		string text = dbvcBqdfop(P_0);
		string snippetName = (string)da9VnmEaoH5NIDadLqZ(P_0);
		JObject jObject = new JObject();
		oWWRIMEIZx78iR7ISsy(jObject, fXbTcTEen9ejDTJrjhR(7052), (JToken)30.0);
		oWWRIMEIZx78iR7ISsy(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(7062), B2VDviEdPUdeXgjBEBs(1.0));
		oWWRIMEIZx78iR7ISsy(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1524), B2VDviEdPUdeXgjBEBs(4.0));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc)
		{
			Expression = (string)fXbTcTEen9ejDTJrjhR(21146)
		};
		kxVTvUEivZV4y99lolK(pasteBufferCell, text);
		zAUtwMEnTqAyDDGpfjE(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, (string)fXbTcTEen9ejDTJrjhR(20444)));
		pasteBufferCell.Value = (JToken)B2VDviEdPUdeXgjBEBs(4.0);
		hVSeNnElSpqcc7khQiH(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell UmjctCvbnt(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(g61c1KVcIS);
		string text = dbvcBqdfop(P_0);
		string snippetName = (string)da9VnmEaoH5NIDadLqZ(P_0);
		JObject jObject = new JObject
		{
			[CdQUGaROfy7He9T0foW.KbIzwHEDLa(7052)] = (JToken?)B2VDviEdPUdeXgjBEBs(10.0),
			[(string)fXbTcTEen9ejDTJrjhR(7062)] = (JToken?)B2VDviEdPUdeXgjBEBs(1.0)
		};
		oWWRIMEIZx78iR7ISsy(jObject, fXbTcTEen9ejDTJrjhR(1524), B2VDviEdPUdeXgjBEBs(1.0));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
		BmlqR1EgytBG0OYPgGk(pasteBufferCell, CdQUGaROfy7He9T0foW.KbIzwHEDLa(21180));
		kxVTvUEivZV4y99lolK(pasteBufferCell, text);
		zAUtwMEnTqAyDDGpfjE(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(20482)));
		vPWvDFEVcYfST5YQOWq(pasteBufferCell, B2VDviEdPUdeXgjBEBs(1.0));
		hVSeNnElSpqcc7khQiH(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell uTOcYWWeI2(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = AYsh2lEf8XH4KmBD3k7(P_0, aU7czXjsDx);
		string text = dbvcBqdfop(P_0);
		string toolName = SnippetPasteBuffer.GetToolName(P_0);
		JObject jObject = new JObject { [(string)fXbTcTEen9ejDTJrjhR(1624)] = (JToken?)UISIodEOiOGfmC3pRha(fXbTcTEen9ejDTJrjhR(8344)) };
		oWWRIMEIZx78iR7ISsy(jObject, fXbTcTEen9ejDTJrjhR(8360), tBW6kNEDhIg2LQVc4Ef(55));
		jObject[(string)fXbTcTEen9ejDTJrjhR(8368)] = (JToken?)UISIodEOiOGfmC3pRha(fXbTcTEen9ejDTJrjhR(21214));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc)
		{
			Expression = CdQUGaROfy7He9T0foW.KbIzwHEDLa(21370)
		};
		kxVTvUEivZV4y99lolK(pasteBufferCell, text);
		pasteBufferCell.Name = EzSnippet.AssembleFullCellName(toolName, (string)fXbTcTEen9ejDTJrjhR(20516), isInternal: true);
		vPWvDFEVcYfST5YQOWq(pasteBufferCell, B2VDviEdPUdeXgjBEBs(1.0));
		hVSeNnElSpqcc7khQiH(pasteBufferCell, jObject2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell wuPc0YDxaC(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = AYsh2lEf8XH4KmBD3k7(P_0, snacrGZmW1);
		PasteBufferCell cellInTool = SnippetPasteBuffer.GetCellInTool(P_0, (string)fXbTcTEen9ejDTJrjhR(19990));
		PasteBufferCell cellInTool2 = SnippetPasteBuffer.GetCellInTool(P_0, (string)fXbTcTEen9ejDTJrjhR(19732));
		string text = y5PtPREsqTLrbaHK62L(mM5SRJEJCw0uSRhPUsc(cellInTool)).ToString(absoluteRow: true, absoluteColumn: true);
		string text2 = y5PtPREsqTLrbaHK62L(mM5SRJEJCw0uSRhPUsc(cellInTool2)).ToString(absoluteRow: true, absoluteColumn: true);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		BmlqR1EgytBG0OYPgGk(pasteBufferCell, K0lOZSEvVs1KNlHRYFl(new string[7]
		{
			CdQUGaROfy7He9T0foW.KbIzwHEDLa(21454),
			text,
			(string)fXbTcTEen9ejDTJrjhR(21486),
			text,
			CdQUGaROfy7He9T0foW.KbIzwHEDLa(5424),
			text2,
			(string)fXbTcTEen9ejDTJrjhR(6970)
		}));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string aGLcVPt6Sd(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = AYsh2lEf8XH4KmBD3k7(P_0, IHAc81Z0qy).ToString(absoluteRow: true, absoluteColumn: true);
		object obj = XwB93fErJYvRPMAmqv8(CvsParse.ReplaceArg(P_1, 13, text), 14, text);
		string text2 = AYsh2lEf8XH4KmBD3k7(P_0, AGWcmi2pI8).ToString(absoluteRow: true, absoluteColumn: true);
		object expr = XwB93fErJYvRPMAmqv8(obj, 15, text2);
		string newarg = AYsh2lEf8XH4KmBD3k7(P_0, g61c1KVcIS).ToString(absoluteRow: true, absoluteColumn: true);
		string text3 = CvsParse.ReplaceArg((string)expr, 16, newarg);
		string text4 = AYsh2lEf8XH4KmBD3k7(P_0, aU7czXjsDx).ToString(absoluteRow: true, absoluteColumn: true);
		string text5 = (string)cwbdyOEPG2rnnKjoAZc(text3, 18) + (string)fXbTcTEen9ejDTJrjhR(17770) + text4;
		return (string)XwB93fErJYvRPMAmqv8(XwB93fErJYvRPMAmqv8(text3, 18, text5), 19, text4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string SgqcLAPogo(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = SyFoYdEZhbUxZkqF9aq(P_1, ')');
		object obj = NMTdeqEBglmkr6lk5e1(P_1, 0, num);
		int row = oGNKUtE5IvhWOtjj4dj(P_0).Size.Height - 1;
		int num2 = oGNKUtE5IvhWOtjj4dj(P_0).Size.Width - 1;
		CvsCellLocation location = AYsh2lEf8XH4KmBD3k7(P_0, new CvsCellLocation(row, 0));
		CvsCellLocation lastLocation = AYsh2lEf8XH4KmBD3k7(P_0, new CvsCellLocation(row, num2 - 2));
		return (string)obj + string.Format(arg0: new CvsCellRange(location, lastLocation), format: (string)fXbTcTEen9ejDTJrjhR(21494));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wir7fGEK5YnrT8nGTvj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gM9PNhqzDUfUGGygbbF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vYNX69ELBapN6qFUqsx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange oGNKUtE5IvhWOtjj4dj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MG4kdxEwEplZAIHDFMH(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithOffset(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mM5SRJEJCw0uSRhPUsc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object da9VnmEaoH5NIDadLqZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fXbTcTEen9ejDTJrjhR(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UISIodEOiOGfmC3pRha(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oWWRIMEIZx78iR7ISsy(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tBW6kNEDhIg2LQVc4Ef(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kxVTvUEivZV4y99lolK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zAUtwMEnTqAyDDGpfjE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vPWvDFEVcYfST5YQOWq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation AYsh2lEf8XH4KmBD3k7(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B2VDviEdPUdeXgjBEBs(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hVSeNnElSpqcc7khQiH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BmlqR1EgytBG0OYPgGk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation y5PtPREsqTLrbaHK62L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K0lOZSEvVs1KNlHRYFl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XwB93fErJYvRPMAmqv8(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cwbdyOEPG2rnnKjoAZc(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.FindArg((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int SyFoYdEZhbUxZkqF9aq(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).LastIndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NMTdeqEBglmkr6lk5e1(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1, P_2);
	}
}
