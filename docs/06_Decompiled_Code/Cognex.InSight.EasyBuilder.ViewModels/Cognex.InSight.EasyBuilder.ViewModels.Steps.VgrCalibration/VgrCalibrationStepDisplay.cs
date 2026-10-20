using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Controls;
using Cognex.InSight.Controls.Display;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.VgrCalibration;

public class VgrCalibrationStepDisplay : AppStepDisplayBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public VgrCalibrationStepDisplay(CvsInSightDisplay display)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gtsEi0etiIZrh22vK6R();
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
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_004d;
		IL_001a:
		if (Display != null)
		{
			num = 2;
			goto IL_004d;
		}
		return;
		IL_004d:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 5:
				Display.ShowGrid = false;
				goto case 8;
			default:
				num = 8;
				continue;
			case 2:
				tx5D1cOKycZEk6iOKtO(gwFXK0OL0NPesE2B3BP(nOWexmezNkbMUoZcIb7(Display)), false);
				num = 0;
				continue;
			case 3:
			case 9:
				((CvsAction)NxCfo2O5NIw8QGoqdQq(nOWexmezNkbMUoZcIb7(Display))).Execute();
				num = 5;
				continue;
			case 6:
			case 7:
				zuKl2fOJ91yvOZph1n2(lSooi1OwOtM1f9DHZke(Display), true, true);
				num = 10;
				continue;
			case 1:
				Display.InSight.GraphicsLayerFilter = null;
				goto case 6;
			case 8:
				Display.ShowGraphics = true;
				num = 1;
				continue;
			case 0:
				tx5D1cOKycZEk6iOKtO(NxCfo2O5NIw8QGoqdQq(nOWexmezNkbMUoZcIb7(Display)), false);
				_ = 1;
				if (cVQwYMehmuvhCNYl1E7())
				{
					num = 6;
					continue;
				}
				num = 9;
				if (false)
				{
					return;
				}
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_001a;
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
			sW1EOeOa7yqc10pJvKJ(Display, false);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gtsEi0etiIZrh22vK6R()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool moCtmQeumuFUpdTYLek()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cVQwYMehmuvhCNYl1E7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nOWexmezNkbMUoZcIb7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).Edit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gwFXK0OL0NPesE2B3BP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplayEdit)P_0).AcceptChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tx5D1cOKycZEk6iOKtO(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsAction)P_0).Suppressed = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NxCfo2O5NIw8QGoqdQq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplayEdit)P_0).CancelChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lSooi1OwOtM1f9DHZke(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zuKl2fOJ91yvOZph1n2(object P_0, bool P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).MakeNewResult(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sW1EOeOa7yqc10pJvKJ(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).ShowGraphics = P_1;
	}
}
