using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Controls;
using Cognex.InSight.Controls.Display;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Run;

public class RunStepDisplay : AppStepDisplayBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RunStepDisplay(CvsInSightDisplay display)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pF27uHO9Z19yaHJGWh5();
		base._002Ector(display);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDisplayToStepMode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 7:
				BGZCkcOCl6I4knfJWpZ(Display, false);
				goto default;
			default:
				jYbOsWOpqgT6iRotYWM();
				num = ((!G1N6TsOX28h3LUYlPhn()) ? 1 : 0);
				break;
			case 0:
			case 6:
				((CvsInSight)LoHq8mOA3YiqmN47O9P(Display)).GraphicsLayerFilter = null;
				num = 8;
				break;
			case 3:
				s918tBO3CYLMHjvNO2r(dIvM0JOjlr0xZs1DeVg(Display.Edit), false);
				num = 2;
				break;
			case 4:
				if (Display != null)
				{
					num = 9;
					if (true)
					{
						break;
					}
					goto case 9;
				}
				return;
			case 9:
				s918tBO3CYLMHjvNO2r(bmpjHbO7t3ZiSP7Kehc(knKCd8O4oSPJm9JJ0VR(Display)), false);
				num = 3;
				if (!G1N6TsOX28h3LUYlPhn())
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				Display.ShowGraphics = true;
				goto case 0;
			case 2:
				zqoXmoO6eIWuY0T47pu(dIvM0JOjlr0xZs1DeVg(knKCd8O4oSPJm9JJ0VR(Display)));
				num = 7;
				if (jYbOsWOpqgT6iRotYWM())
				{
					break;
				}
				goto case 8;
			case 8:
				h12V8HORVkEWrfsNPvQ(LoHq8mOA3YiqmN47O9P(Display), true, true);
				num = 10;
				if (1 == 0)
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDisplayToNormalState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Display != null)
		{
			EaEyyUOWRjnrruLB1Pa(Display, false);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pF27uHO9Z19yaHJGWh5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jYbOsWOpqgT6iRotYWM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool G1N6TsOX28h3LUYlPhn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object knKCd8O4oSPJm9JJ0VR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).Edit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bmpjHbO7t3ZiSP7Kehc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplayEdit)P_0).AcceptChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s918tBO3CYLMHjvNO2r(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsAction)P_0).Suppressed = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dIvM0JOjlr0xZs1DeVg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplayEdit)P_0).CancelChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zqoXmoO6eIWuY0T47pu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsAction)P_0).Execute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BGZCkcOCl6I4knfJWpZ(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).ShowGrid = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LoHq8mOA3YiqmN47O9P(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h12V8HORVkEWrfsNPvQ(object P_0, bool P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).MakeNewResult(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EaEyyUOWRjnrruLB1Pa(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).ShowGraphics = P_1;
	}
}
