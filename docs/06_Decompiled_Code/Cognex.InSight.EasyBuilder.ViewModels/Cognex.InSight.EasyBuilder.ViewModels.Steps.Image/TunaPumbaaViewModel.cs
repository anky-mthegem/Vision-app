using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.IDE.Common;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.Wpf.Tuna;
using Cognex.ServiceLocator;
using Cognex.Tako;
using Cognex.ThreeD.Controls;
using Cognex.ThreeD.Graphics;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;

public class TunaPumbaaViewModel : TunaViewModel<TunaSensorApiPumbaa>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TunaPumbaaViewModel(SetupImageStepViewModel viewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QiEuGOm9xI53hJVHnf6();
		HoyQFMm4wn0WAhxvRdE(this, viewModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CreateTunaSensorApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsInSight cvsInSight = default;
		IGraphic3DElementConverter<QuadMeshGraphic, Node> instance = default;
		while (true)
		{
			switch (num)
			{
			default:
				TunaSensorApi = new TunaSensorApiPumbaa((BaseIdeViewModel)LQGd88m3BrSRRtYiDrt(_appViewModel), isEasyBuilder: true, (InSightStartupArgs)Kx1VhjmjcwFq3mU9yAD(LQGd88m3BrSRRtYiDrt(_appViewModel)), cvsInSight.CogSocket, cvsInSight, instance);
				num = 5;
				break;
			case 4:
				instance = Locator.Current.GetInstance<IGraphic3DElementConverter<QuadMeshGraphic, Node>>();
				_ = 0;
				num = ((!mnhLF2mpvfucjOyKpyn()) ? 3 : 0);
				break;
			case 0:
			case 1:
				cvsInSight = (CvsInSight)aBTHpam7yI99JNN7tfL(_appViewModel);
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QiEuGOm9xI53hJVHnf6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HoyQFMm4wn0WAhxvRdE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TunaViewModel<TunaSensorApiPumbaa>)P_0)._002Ector((SetupImageStepViewModel)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mnhLF2mpvfucjOyKpyn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s0WjonmXqKlDCH3FVPK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aBTHpam7yI99JNN7tfL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LQGd88m3BrSRRtYiDrt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kx1VhjmjcwFq3mU9yAD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).StartupArgs;
	}
}
