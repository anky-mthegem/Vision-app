using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Controls;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;

public class ImageStepDisplay : AppStepDisplayBase
{
	private SetupImageStepViewModel wlHvm034b9;

	private IRuntimeModeService x3Mv1kEYEc;

	private StepDisplayState Ae7vzYTe9I;

	public SetupImageStepViewModel SetupImageStepViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wlHvm034b9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 4:
					ResetViewModel();
					num = 7;
					continue;
				case 5:
					if (wlHvm034b9 == null)
					{
						break;
					}
					num = 6;
					if (YUR664x8wfQqVyeL3BA())
					{
						continue;
					}
					goto case 6;
				case 6:
					P40Ny2xXxSyG1sY4HQm(Display, null);
					_ = 0;
					num = (YUR664x8wfQqVyeL3BA() ? 1 : 0);
					continue;
				case 1:
				case 2:
					klLvhFeTJ5(StepDisplayState.Run);
					break;
				case 7:
					return;
				}
				wlHvm034b9 = value;
				num = 4;
			}
		}
	}

	private IRuntimeModeService RuntimeModeService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x3Mv1kEYEc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
					x3Mv1kEYEc.RuntimeModeChanged += oG0v0Xf4kg;
					num = 8;
					break;
				case 0:
				case 2:
					x3Mv1kEYEc = value;
					num = 3;
					break;
				case 3:
					if (x3Mv1kEYEc != null)
					{
						goto case 5;
					}
					return;
				default:
					num = 5;
					break;
				case 7:
					if (x3Mv1kEYEc != null)
					{
						_ = 1;
						num = ((!u0c4VWxqxifdf3DEdcE()) ? 6 : 0);
						break;
					}
					goto case 0;
				case 5:
					y9AvYEreXB(AhSMlbxAPuAEF5fFVao(RuntimeModeService), wjRFUvxRS3dnduYrhDY(RuntimeModeService));
					num = 4;
					break;
				case 1:
				case 6:
					x3Mv1kEYEc.RuntimeModeChanged -= oG0v0Xf4kg;
					goto case 0;
				case 8:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageStepDisplay(CvsInSightDisplay display, SetupImageStepViewModel setupImageStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				EPUEbYxEB6YeMcScbgK();
				num = 1;
				continue;
			case 2:
			case 4:
				Display = display;
				break;
			case 1:
				base._002Ector(display);
				_ = 1;
				num = ((!u0c4VWxqxifdf3DEdcE()) ? 4 : 5);
				continue;
			case 6:
				return;
			}
			SetupImageStepViewModel = setupImageStep;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDisplay(CvsInSightDisplay display)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!YUR664x8wfQqVyeL3BA()) ? 4 : 2);
		do
		{
			IL_0063:
			switch (num)
			{
			case 0:
			case 2:
				base.SetDisplay(display);
				goto case 1;
			case 1:
			case 4:
				P40Ny2xXxSyG1sY4HQm(Display, YaAlh2xp0Yl2iUvKAf8(SetupImageStepViewModel));
				break;
			default:
				num = 3;
				goto IL_0063;
			case 3:
				break;
			case 5:
				return;
			}
			ResetViewModel();
			num = 5;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDisplayToNormalState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		klLvhFeTJ5(StepDisplayState.Edit);
		RuntimeModeService = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDisplayToStepMode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SetupImageStepViewModel setupImageStepViewModel = wlHvm034b9;
		object value;
		if (setupImageStepViewModel == null)
		{
			value = null;
		}
		else
		{
			object obj = MlVrK4x9oSQYE1SW1ao(setupImageStepViewModel);
			value = ((obj != null) ? XX9Gbdx7wbhDXtn5Let(ypcxBVx48gL83R7ZHST(obj)) : null);
		}
		RuntimeModeService = (IRuntimeModeService)value;
		ResetViewModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool YknvtsRDie(CvsCogShape P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetViewModel()
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
			case 1:
				if (Display == null)
				{
					return;
				}
				u0c4VWxqxifdf3DEdcE();
				if (YUR664x8wfQqVyeL3BA())
				{
					num = 0;
					break;
				}
				num = 9;
				if (u0c4VWxqxifdf3DEdcE())
				{
				}
				break;
			case 0:
			case 2:
				P40Ny2xXxSyG1sY4HQm(Display, wlHvm034b9.InSight);
				goto case 3;
			case 4:
				dBP4IPxjM6014K5vUjG(Display, false);
				goto case 5;
			default:
				num = 5;
				break;
			case 3:
			case 9:
				((CvsInSight)EE3tHrx3D4swYfH4Gjn(Display)).GraphicsLayerFilter = YknvtsRDie;
				num = 4;
				break;
			case 7:
				if (wlHvm034b9 != null)
				{
					num = 1;
					break;
				}
				return;
			case 5:
				u4lRcMx6T37nind4e5v(Display, false);
				num = 8;
				break;
			case 8:
				f4CFnfxC7HFsccbdwD5(Display, true);
				num = 6;
				break;
			case 6:
				klLvhFeTJ5(StepDisplayState.Edit);
				num = 10;
				if (false)
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
	private void y9AvYEreXB(bool P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 8:
				klLvhFeTJ5(StepDisplayState.Run);
				return;
			default:
				num = 4;
				break;
			case 1:
				if (wlHvm034b9 != null)
				{
					num = 0;
					break;
				}
				return;
			case 2:
			case 6:
				if (P_0)
				{
					goto case 3;
				}
				if (!P_1)
				{
					klLvhFeTJ5(StepDisplayState.Edit);
					num = 9;
				}
				else
				{
					num = 7;
				}
				break;
			case 5:
				return;
			case 7:
				klLvhFeTJ5(StepDisplayState.Live);
				num = 5;
				break;
			case 4:
				return;
			case 0:
				if (Display != null)
				{
					u0c4VWxqxifdf3DEdcE();
					num = (YUR664x8wfQqVyeL3BA() ? 6 : 8);
					break;
				}
				return;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oG0v0Xf4kg(object P_0, RuntimeModeChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y9AvYEreXB(wFIOKfxW7a3FQwxQ2gS(P_1), zdpuTuxT0atXNgVHaRL(P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private StepDisplayState yMfvreAa5j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Ae7vzYTe9I;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private void klLvhFeTJ5(StepDisplayState value)
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
			case 2:
				if (Display == null)
				{
					YUR664x8wfQqVyeL3BA();
					num = ((!u0c4VWxqxifdf3DEdcE()) ? 9 : 0);
					break;
				}
				if (Ae7vzYTe9I == StepDisplayState.Edit)
				{
					num = 10;
					break;
				}
				goto IL_0194;
			case 11:
				((CvsAction)Aikpb0xMIxIGJXCpxAC(iI1Udbxy816A9cmvniD(Display))).Suppressed = true;
				num = 8;
				break;
			case 6:
				E0e5Y7xFlNrh0OiAXR3(tYD7Skx0DRaT2qMMMTG(iI1Udbxy816A9cmvniD(Display)), true);
				num = 11;
				break;
			case 0:
			case 5:
				if (Ae7vzYTe9I == StepDisplayState.Edit)
				{
					goto case 4;
				}
				return;
			default:
				num = 4;
				break;
			case 4:
				if (wlHvm034b9 != null)
				{
					num = 6;
					break;
				}
				return;
			case 8:
				Display.EditInternalGraphics(GetViewableEditGraphics(), null, null, Cv8vVFTNqy, hpWvLVQcgN);
				num = 12;
				break;
			case 3:
				E0e5Y7xFlNrh0OiAXR3(Aikpb0xMIxIGJXCpxAC(Display.Edit), false);
				num = 7;
				break;
			case 10:
				E0e5Y7xFlNrh0OiAXR3(tYD7Skx0DRaT2qMMMTG(iI1Udbxy816A9cmvniD(Display)), false);
				num = 3;
				break;
			case 1:
			case 9:
				return;
			case 7:
				((CvsInSightDisplayEdit)iI1Udbxy816A9cmvniD(Display)).CancelChanges.Execute();
				goto IL_0194;
			case 12:
				return;
				IL_0194:
				Ae7vzYTe9I = value;
				goto case 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		bool suppressed = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				((CvsAction)Aikpb0xMIxIGJXCpxAC(Display.Edit)).Suppressed = suppressed;
				num = 4;
				if (false)
				{
					return;
				}
				break;
			case 2:
				return;
			case 8:
				return;
			case 0:
				((CvsAction)Aikpb0xMIxIGJXCpxAC(Display.Edit)).Suppressed = false;
				goto case 6;
			default:
				num = 6;
				break;
			case 3:
				if (Display == null)
				{
					return;
				}
				u0c4VWxqxifdf3DEdcE();
				if (YUR664x8wfQqVyeL3BA())
				{
					num = 7;
					break;
				}
				num = 8;
				if (u0c4VWxqxifdf3DEdcE())
				{
				}
				break;
			case 6:
				FX9UEWxUVL5GwdvimWc(Aikpb0xMIxIGJXCpxAC(Display.Edit));
				num = 5;
				break;
			case 1:
			case 7:
				if (yMfvreAa5j() != StepDisplayState.Edit)
				{
					return;
				}
				suppressed = bpR3JaxYd8mOKH3QRPC(Aikpb0xMIxIGJXCpxAC(iI1Udbxy816A9cmvniD(Display)));
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 4:
				Display.EditInternalGraphics(GetViewableEditGraphics(), null, null, Cv8vVFTNqy, hpWvLVQcgN);
				num = 9;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override List<CvsEditableDisplayGraphic> GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SetupImageStepViewModel.GetEditableGraphics();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task Cv8vVFTNqy(object P_0, CvsEditEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				wlHvm034b9.WriteGraphic(cvsEditableDisplayGraphic);
				num = 8;
				continue;
			default:
				if (!Mti19xxmFK0MBw4Tq4h(P_1))
				{
					num = 5;
					continue;
				}
				break;
			case 2:
				if (KfZ78KxxFLV6WsuHwyG(P_1))
				{
					break;
				}
				goto default;
			case 6:
				cvsEditableDisplayGraphic = P_1.Value as CvsEditableDisplayGraphic;
				YUR664x8wfQqVyeL3BA();
				num = (u0c4VWxqxifdf3DEdcE() ? 3 : 0);
				continue;
			case 7:
				return (Task)c7RxnbxHoZvXjjEdpG0();
			case 0:
			case 1:
				do
				{
					if (cvsEditableDisplayGraphic != null)
					{
						cvsEditableDisplayGraphic.Fit();
						num = 2;
						continue;
					}
					num = 7;
					break;
				}
				while (!YUR664x8wfQqVyeL3BA());
				continue;
			case 8:
				break;
			}
			break;
		}
		return (Task)c7RxnbxHoZvXjjEdpG0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task hpWvLVQcgN(object P_0, CvsEditEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)c7RxnbxHoZvXjjEdpG0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EPUEbYxEB6YeMcScbgK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YUR664x8wfQqVyeL3BA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u0c4VWxqxifdf3DEdcE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YaAlh2xp0Yl2iUvKAf8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P40Ny2xXxSyG1sY4HQm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).InSight = (CvsInSight)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MlVrK4x9oSQYE1SW1ao(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ypcxBVx48gL83R7ZHST(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).Runtime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XX9Gbdx7wbhDXtn5Let(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).RuntimeModeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EE3tHrx3D4swYfH4Gjn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dBP4IPxjM6014K5vUjG(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).ShowGrid = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u4lRcMx6T37nind4e5v(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).ShowGraphics = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f4CFnfxC7HFsccbdwD5(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).IsEasyBuilder = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AhSMlbxAPuAEF5fFVao(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wjRFUvxRS3dnduYrhDY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wFIOKfxW7a3FQwxQ2gS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeModeChangedEventArgs)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zdpuTuxT0atXNgVHaRL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeModeChangedEventArgs)P_0).IsLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iI1Udbxy816A9cmvniD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).Edit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tYD7Skx0DRaT2qMMMTG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplayEdit)P_0).AcceptChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E0e5Y7xFlNrh0OiAXR3(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsAction)P_0).Suppressed = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Aikpb0xMIxIGJXCpxAC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplayEdit)P_0).CancelChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bpR3JaxYd8mOKH3QRPC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsAction)P_0).Suppressed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FX9UEWxUVL5GwdvimWc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsAction)P_0).Execute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c7RxnbxHoZvXjjEdpG0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KfZ78KxxFLV6WsuHwyG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditEventArgs)P_0).IsFocusChange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Mti19xxmFK0MBw4Tq4h(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditEventArgs)P_0).IsEditingGraphic;
	}
}
