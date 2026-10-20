using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance.DistanceUpdates;

public class AddTransWorldToPixelCellUpdatePtp : ISnippetUpdate
{
	private static readonly CvsCellLocation aHgWCZXBGZ;

	private static readonly CvsCellLocation S7BWOoE8x8;

	private static readonly CvsCellLocation yweWHjJ0bt;

	private static readonly CvsCellLocation I9hWwHEJo0;

	private static readonly CvsCellLocation FwiWyaH1Ei;

	private static readonly CvsCellLocation nodWxuk5Pf;

	private readonly AddCellUpdate o9BWvPOqrt;

	private readonly AddCellUpdate EqHWeEdJWS;

	private readonly AddCellUpdate kFeW2XskSs;

	private readonly LocationUpdate aasWqdVmOo;

	private readonly LocationUpdate uJiWiwLgrK;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddTransWorldToPixelCellUpdatePtp(SnippetLocalizer localizer, CvsFunctionTable table, IExpressionConstants constants)
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
			case 0:
				uJiWiwLgrK = new LocationUpdate(yweWHjJ0bt, S7BWOoE8x8, SnippetUpdateHelper.GetAbsRefLocationOfCell, nodWxuk5Pf, table, constants);
				num = 9;
				continue;
			case 6:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 2;
				continue;
			case 2:
				GEvwqfAIt2jZVC8VXr1(this);
				num = 7;
				continue;
			case 1:
			case 5:
				aasWqdVmOo = new LocationUpdate(yweWHjJ0bt, aHgWCZXBGZ, SnippetUpdateHelper.GetAbsRefLocationOfCell, FwiWyaH1Ei, table, constants);
				num = 0;
				if (p1UjC6AOCJKGUafr54n())
				{
				}
				continue;
			case 7:
				o9BWvPOqrt = new AddCellUpdate(I9hWwHEJo0, CwlWlPeUkx, localizer);
				num = 8;
				continue;
			case 3:
			case 4:
				kFeW2XskSs = new AddCellUpdate(nodWxuk5Pf, RmiWTp5Fku, nodWxuk5Pf, localizer);
				goto case 1;
			case 8:
				EqHWeEdJWS = new AddCellUpdate(FwiWyaH1Ei, RmiWTp5Fku, FwiWyaH1Ei, localizer);
				break;
			case 9:
				return;
			}
			_ = 0;
			if (!bFN7ckAeQ9hi9PeXBQF())
			{
				num = 1;
				continue;
			}
			num = 3;
			if (!bFN7ckAeQ9hi9PeXBQF())
			{
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!bFN7ckAeQ9hi9PeXBQF())
		{
			goto IL_001e;
		}
		goto IL_0092;
		IL_001e:
		PasteBuffer pasteBuffer = (PasteBuffer)hUqHp5AixSCbpuAMUw4(EqHWeEdJWS, pasteBuffer);
		p1UjC6AOCJKGUafr54n();
		num = ((!bFN7ckAeQ9hi9PeXBQF()) ? 4 : 7);
		goto IL_0092;
		IL_0092:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 4:
			case 5:
				pasteBuffer = (PasteBuffer)ybhTcDAnf8rMxHinOYH(uJiWiwLgrK, pasteBuffer);
				num = 8;
				continue;
			case 1:
				pasteBuffer = o9BWvPOqrt.Apply(pasteBuffer);
				num = 2;
				continue;
			case 3:
			case 7:
				pasteBuffer = (PasteBuffer)hUqHp5AixSCbpuAMUw4(kFeW2XskSs, pasteBuffer);
				goto case 0;
			default:
				num = 0;
				continue;
			case 6:
				pasteBuffer = (PasteBuffer)WInLdSAD8xK4fZuUFgq(originalSnippet);
				num = 1;
				continue;
			case 0:
				pasteBuffer = (PasteBuffer)ybhTcDAnf8rMxHinOYH(aasWqdVmOo, pasteBuffer);
				goto case 4;
			case 8:
				return pasteBuffer;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell CwlWlPeUkx(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(I9hWwHEJo0);
		string text = (string)MXM9PpAVaWIfRrMbfH8(P_0);
		string text2 = (string)b4BOGLAfWfny4clMc0h(CdQUGaROfy7He9T0foW.KbIzwHEDLa(26642), text);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
		E23yNdAdVm8oi2tbfZu(pasteBufferCell, text2);
		pasteBufferCell.Name = "";
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell RmiWTp5Fku(PasteBuffer P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = s8qwmVAlGuejMKXKcNF(P_0, P_1);
		string text = sgHWWWk9fm(P_0, P_1);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		E23yNdAdVm8oi2tbfZu(pasteBufferCell, text);
		LKPRMxAgpXXqVDqdSdc(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string sgHWWWk9fm(PasteBuffer P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (bFN7ckAeQ9hi9PeXBQF())
		{
			num = 2;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_0081;
			}
		}
		goto IL_003d;
		IL_003d:
		CvsCellLocation cellOffset = default;
		string arg = default;
		string arg2 = default;
		string absRefLocationOfCell = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				cellOffset = ycmMMYAvAZFy1dmahCo(P_1);
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 2:
				arg = (string)MXM9PpAVaWIfRrMbfH8(P_0);
				goto case 1;
			case 4:
				break;
			case 1:
			case 5:
				arg2 = (string)xIyDYoAs5w8VB2mSXxI(P_0, I9hWwHEJo0);
				num = 3;
				if (bFN7ckAeQ9hi9PeXBQF())
				{
					continue;
				}
				goto case 6;
			case 6:
				return string.Format((string)l9q9QfArNTFFmnZajkr(26810), arg, arg2, absRefLocationOfCell);
			}
			break;
		}
		goto IL_0081;
		IL_0081:
		absRefLocationOfCell = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, cellOffset);
		num = 6;
		goto IL_003d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsCellLocation EWpWjft3a5(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (axxhakAP62opIdmvZL6(P_0, FwiWyaH1Ei))
		{
			return aHgWCZXBGZ;
		}
		return S7BWOoE8x8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AddTransWorldToPixelCellUpdatePtp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				S7BWOoE8x8 = new CvsCellLocation(2, 2);
				num = 3;
				if (bFN7ckAeQ9hi9PeXBQF())
				{
					break;
				}
				goto case 0;
			case 0:
				I9hWwHEJo0 = new CvsCellLocation(8, 0);
				num = 7;
				break;
			case 8:
				EDgeHpAZnsviobq5QID();
				num = 5;
				break;
			case 1:
			case 6:
				nodWxuk5Pf = new CvsCellLocation(8, 2);
				num = 9;
				break;
			case 7:
				FwiWyaH1Ei = new CvsCellLocation(8, 1);
				goto case 1;
			case 5:
				aHgWCZXBGZ = new CvsCellLocation(1, 2);
				_ = 1;
				num = (p1UjC6AOCJKGUafr54n() ? 1 : 4);
				break;
			case 3:
				yweWHjJ0bt = new CvsCellLocation(2, 0);
				goto case 0;
			default:
				num = 0;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GEvwqfAIt2jZVC8VXr1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bFN7ckAeQ9hi9PeXBQF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p1UjC6AOCJKGUafr54n()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WInLdSAD8xK4fZuUFgq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hUqHp5AixSCbpuAMUw4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AddCellUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ybhTcDAnf8rMxHinOYH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LocationUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MXM9PpAVaWIfRrMbfH8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetUpdateHelper.InputImageLocationFactory((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b4BOGLAfWfny4clMc0h(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E23yNdAdVm8oi2tbfZu(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation s8qwmVAlGuejMKXKcNF(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LKPRMxAgpXXqVDqdSdc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xIyDYoAs5w8VB2mSXxI(object P_0, CvsCellLocation cellOffset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetUpdateHelper.GetAbsRefLocationOfCell((PasteBuffer)P_0, cellOffset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation ycmMMYAvAZFy1dmahCo(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EWpWjft3a5(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l9q9QfArNTFFmnZajkr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool axxhakAP62opIdmvZL6(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EDgeHpAZnsviobq5QID()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
