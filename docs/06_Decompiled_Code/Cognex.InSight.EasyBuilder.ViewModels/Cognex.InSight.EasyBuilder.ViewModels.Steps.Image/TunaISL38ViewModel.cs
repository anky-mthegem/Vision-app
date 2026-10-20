using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.IDE.Common;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.Wpf.Tuna;
using Cognex.ServiceLocator;
using Cognex.Tako;
using Cognex.ThreeD.Controls;
using Cognex.ThreeD.Graphics;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;

public class TunaISL38ViewModel : TunaViewModel<TunaSensorApiL38Liger>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TunaISL38ViewModel(SetupImageStepViewModel viewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		PvAQxomSMCgd6JMPGfG(this, viewModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CreateTunaSensorApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		W2jLdsmoC7rWuq1ldeL();
		int num;
		if (FnrV18mG19QS5mhKRKR())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
			if (false)
			{
				return;
			}
		}
		goto IL_0048;
		IL_0071:
		CvsInSight cvsInSight = default;
		IGraphic3DElementConverter<QuadMeshGraphic, Node> instance = default;
		TunaSensorApi = new TunaSensorApiL38Liger((BaseIdeViewModel)KPqugcm8S0LlPhbHXdp(_appViewModel), isEasyBuilder: true, (InSightStartupArgs)lD55LfmqLppXw8r6PbW(KPqugcm8S0LlPhbHXdp(_appViewModel)), (CvsCogSocket)FhjlqAmEbyyLURQ5oyA(cvsInSight), cvsInSight, instance);
		num = 5;
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0071;
			case 2:
				goto IL_0071;
			case 0:
			case 3:
				instance = Locator.Current.GetInstance<IGraphic3DElementConverter<QuadMeshGraphic, Node>>();
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		cvsInSight = (CvsInSight)UryGgpmkfr1Xj92UAGW(_appViewModel);
		goto IL_0071;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PvAQxomSMCgd6JMPGfG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TunaViewModel<TunaSensorApiL38Liger>)P_0)._002Ector((SetupImageStepViewModel)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FnrV18mG19QS5mhKRKR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W2jLdsmoC7rWuq1ldeL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UryGgpmkfr1Xj92UAGW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KPqugcm8S0LlPhbHXdp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lD55LfmqLppXw8r6PbW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).StartupArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FhjlqAmEbyyLURQ5oyA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}
}
