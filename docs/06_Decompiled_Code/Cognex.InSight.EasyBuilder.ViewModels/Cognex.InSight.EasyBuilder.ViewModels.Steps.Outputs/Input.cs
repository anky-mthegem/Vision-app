using System;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.Platform.IO.IDE.DiscreteIOSettings.ViewModels;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class Input
{
	private static class J3RtTEIKAqiLNuxu8I
	{
	}

	[CompilerGenerated]
	private DIOLineViewModel zJEUL5Jvwe;

	[CompilerGenerated]
	private readonly IntViewModel DI0UJea4GM;

	[CompilerGenerated]
	private BoolViewModel M2RU9YPYUg;

	[CompilerGenerated]
	private ListBoxViewModel Q2CUrFXQ2D;

	[CompilerGenerated]
	private readonly BoolViewModel P7IUhHumQV;

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
			return zJEUL5Jvwe;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zJEUL5Jvwe = value;
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
			return DI0UJea4GM;
		}
	}

	public BoolViewModel Signal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M2RU9YPYUg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			M2RU9YPYUg = value;
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
			return Q2CUrFXQ2D;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q2CUrFXQ2D = value;
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
			return P7IUhHumQV;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Input(AppStepViewModel appStepVm, CvsCellCollection cells, CvsCellLocation signalLocation, int lineIndex, int maxCol)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		int num3 = default;
		string text = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				P7IUhHumQV = new BoolViewModel((CvsInSight)oVE1UdIKO9IIZ1T5Ko8(appStepVm), cells, signalLocation, string.Format((string)nN2PhsILrxJ1N9rE7ZE(3362), HahqV3Ia0TdReUyoeBH(), num3));
				num = 8;
				break;
			case 1:
			case 7:
				QeFoCyOtAbu8TniVDHP(this);
				num = 14;
				if (0 == 0)
				{
					break;
				}
				goto case 13;
			case 13:
				Force = new ListBoxViewModel((CvsInSight)oVE1UdIKO9IIZ1T5Ko8(appStepVm), cells, signalLocation, text);
				num = 3;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				scfFm1I5OLuRmIntrbo(Signal, true);
				num = 5;
				break;
			case 4:
			case 17:
				scfFm1I5OLuRmIntrbo(Line, true);
				num = 11;
				break;
			case 16:
				Signal = new BoolViewModel((CvsInSight)oVE1UdIKO9IIZ1T5Ko8(appStepVm), cells, signalLocation, text);
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			default:
				num = 9;
				break;
			case 6:
				bYxd41OhlXo126VVRZ8();
				Q8s8LiOult3Q7ChEDfQ();
				if (TYGc3CO1XbQ9eVqrDyh())
				{
					num = 7;
					if (Q8s8LiOult3Q7ChEDfQ())
					{
					}
				}
				else
				{
					num = 17;
				}
				break;
			case 3:
				Force.Internal = true;
				num = 10;
				break;
			case 15:
				if (text.IndexOf((string)nN2PhsILrxJ1N9rE7ZE(3280), StringComparison.Ordinal) >= 0)
				{
					DI0UJea4GM = new IntViewModel((CvsInSight)oVE1UdIKO9IIZ1T5Ko8(appStepVm), cells, signalLocation, text);
					goto case 4;
				}
				if (APWvXpIwbc5vmmfZOG4(text, nN2PhsILrxJ1N9rE7ZE(3308), StringComparison.Ordinal) < 0)
				{
					if ((num2 = APWvXpIwbc5vmmfZOG4(text, nN2PhsILrxJ1N9rE7ZE(3336), StringComparison.Ordinal)) >= 0)
					{
						goto case 9;
					}
					if (APWvXpIwbc5vmmfZOG4(text, nN2PhsILrxJ1N9rE7ZE(3380), StringComparison.Ordinal) >= 0)
					{
						num = 16;
						break;
					}
					goto case 5;
				}
				num = 13;
				break;
			case 9:
			{
				if (int.TryParse(num2 + (string)HnhTyOIJYPFgV9LAKCn(text, ((string)nN2PhsILrxJ1N9rE7ZE(3336)).Length), out var result))
				{
					num3 = result;
					goto case 12;
				}
				num3 = lineIndex + 1;
				num = 12;
				break;
			}
			case 5:
			case 8:
			case 10:
			case 11:
				signalLocation.Column++;
				num = 0;
				break;
			case 0:
			case 14:
				if (signalLocation.Column < maxCol)
				{
					text = ((CvsCell)IQdHIYOzCtx8FPxSGDT(cells, signalLocation))?.Name;
					if (text != null)
					{
						num = 15;
						break;
					}
					goto case 5;
				}
				num = 18;
				if (Q8s8LiOult3Q7ChEDfQ())
				{
					return;
				}
				break;
			case 18:
				return;
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
		_ = 1;
		int num = ((!Q8s8LiOult3Q7ChEDfQ()) ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				Signal.Refresh(cells);
				num = 4;
				continue;
			case 4:
				Force.Refresh(cells);
				break;
			case 5:
				return;
			}
			ValueWithForce.Refresh(cells);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bYxd41OhlXo126VVRZ8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QeFoCyOtAbu8TniVDHP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IQdHIYOzCtx8FPxSGDT(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nN2PhsILrxJ1N9rE7ZE(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oVE1UdIKO9IIZ1T5Ko8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void scfFm1I5OLuRmIntrbo(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int APWvXpIwbc5vmmfZOG4(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HnhTyOIJYPFgV9LAKCn(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HahqV3Ia0TdReUyoeBH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.lpdYbvNgHa();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TYGc3CO1XbQ9eVqrDyh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q8s8LiOult3Q7ChEDfQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
