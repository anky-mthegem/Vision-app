using System;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.Platform.IO.IDE.DiscreteIOSettings.ViewModels;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class Output
{
	private static class cBRLaGjQbwY8Pcidj7
	{
	}

	[CompilerGenerated]
	private DIOLineViewModel hol759rmR7;

	[CompilerGenerated]
	private readonly IntViewModel qBm7pDpofJ;

	[CompilerGenerated]
	private OutputLinksViewModel DoI7UUV1x6;

	[CompilerGenerated]
	private ListBoxViewModel baw776n4BF;

	[CompilerGenerated]
	private readonly BoolViewModel mUi7NckP5A;

	public DIOLineViewModel DioLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hol759rmR7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hol759rmR7 = value;
		}
	}

	public IntViewModel Line
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qBm7pDpofJ;
		}
	}

	public OutputLinksViewModel Signal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DoI7UUV1x6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DoI7UUV1x6 = value;
		}
	}

	public ListBoxViewModel Force
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return baw776n4BF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			baw776n4BF = value;
		}
	}

	public BoolViewModel ValueWithForce
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mUi7NckP5A;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Output(AppStepViewModel appStepVm, CvsCellCollection cells, CvsCellLocation signalLocation, int lineIndex, int maxCol)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		int num3 = default;
		int result = default;
		string text = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 7:
				num3 = result;
				num = 15;
				if (QfPrKRIZplWvZ9M6bDj())
				{
					break;
				}
				goto case 3;
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 14;
				break;
			case 0:
			case 11:
			case 15:
				mUi7NckP5A = new BoolViewModel((CvsInSight)Rmq04xIS41Q7uFUTPlB(appStepVm), cells, signalLocation, string.Format((string)gP2ENgIovDCbBYjChGZ(3362), l1amaBIpbP2p5Vrhsak(), num3));
				goto case 5;
			case 1:
				if (text.IndexOf((string)gP2ENgIovDCbBYjChGZ(3484), StringComparison.Ordinal) < 0)
				{
					if (sSrHSxI8nrRnjieYFVf(text, gP2ENgIovDCbBYjChGZ(3514), StringComparison.Ordinal) >= 0)
					{
						Force = new ListBoxViewModel((CvsInSight)Rmq04xIS41Q7uFUTPlB(appStepVm), cells, signalLocation, text);
						num = 4;
						if (0 == 0)
						{
							break;
						}
						goto case 7;
					}
					int num2;
					if ((num2 = text.IndexOf((string)gP2ENgIovDCbBYjChGZ(3544), StringComparison.Ordinal)) >= 0)
					{
						if (int.TryParse((string)beivxsIEI44L46Dy3ND(text, num2 + n8FjUAIqELigTnLfL5r(gP2ENgIovDCbBYjChGZ(3544))), out result))
						{
							num = 7;
							break;
						}
						num3 = lineIndex + 1;
						_ = 1;
						if (CbC0vrIBXCpDArqYBOc())
						{
							num = 16;
							break;
						}
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 14;
					}
					if (text.IndexOf((string)gP2ENgIovDCbBYjChGZ(3572), StringComparison.Ordinal) >= 0)
					{
						num = 6;
						break;
					}
				}
				else
				{
					num = 10;
					if (true)
					{
						break;
					}
				}
				goto case 5;
			case 9:
				obj = null;
				goto IL_012e;
			case 6:
				Signal = new OutputLinksViewModel(appStepVm, cells, signalLocation, text);
				num = 8;
				break;
			case 14:
				pOXRX2Ibu2uBW9EYFws(this);
				num = 2;
				if (CbC0vrIBXCpDArqYBOc())
				{
				}
				break;
			case 10:
				qBm7pDpofJ = new IntViewModel((CvsInSight)Rmq04xIS41Q7uFUTPlB(appStepVm), cells, signalLocation, text);
				ruCMafIk5b81YscxgUR(Line, true);
				num = 13;
				break;
			case 5:
			case 8:
			case 12:
			case 13:
			case 16:
				signalLocation.Column++;
				goto case 2;
			case 2:
				if (signalLocation.Column < maxCol)
				{
					CvsCell cvsCell = cells[signalLocation];
					if (cvsCell != null)
					{
						obj = f4StNmIGOgouMY2qUkV(cvsCell);
						goto IL_012e;
					}
					num = 9;
					break;
				}
				num = 17;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				ruCMafIk5b81YscxgUR(Force, true);
				goto case 5;
			default:
				num = 5;
				if (1 == 0)
				{
					return;
				}
				break;
			case 17:
				return;
				IL_012e:
				text = (string)obj;
				if (text != null)
				{
					num = 1;
					break;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 7:
				ValueWithForce.Refresh(cells);
				num = 3;
				break;
			case 6:
				Force.Refresh(cells);
				num = 7;
				break;
			case 3:
				if (DioLine != null)
				{
					goto default;
				}
				return;
			default:
				_ = 1;
				if (!CbC0vrIBXCpDArqYBOc())
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				num = 1;
				break;
			case 1:
			case 5:
				YW0SjZI4DwAjSigB0Ws(DioLine, lkM6qNI9jPxe9lXnsJn(Signal));
				num = 8;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				DioLine.AvailableJobResults = Signal.Links;
				goto case 1;
			case 2:
				mTmPhcIXtQNROl8QQ5f(Signal, cells);
				num = 6;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pOXRX2Ibu2uBW9EYFws(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f4StNmIGOgouMY2qUkV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gP2ENgIovDCbBYjChGZ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rmq04xIS41Q7uFUTPlB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ruCMafIk5b81YscxgUR(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sSrHSxI8nrRnjieYFVf(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int n8FjUAIqELigTnLfL5r(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object beivxsIEI44L46Dy3ND(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l1amaBIpbP2p5Vrhsak()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.fTILWgOS7S();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QfPrKRIZplWvZ9M6bDj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CbC0vrIBXCpDArqYBOc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mTmPhcIXtQNROl8QQ5f(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((OutputLinksViewModel)P_0).Refresh((CvsCellCollection)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lkM6qNI9jPxe9lXnsJn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((OutputLinksViewModel)P_0).SelectedLink;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YW0SjZI4DwAjSigB0Ws(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DIOLineViewModel)P_0).JobResult = P_1;
	}
}
