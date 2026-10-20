using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.VgrCalibration;

public class VgrCalibrationStepViewModel : AppStepViewModel, IInSightAppStep
{
	private int qbyUs60AeE;

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Steps_InspectPartIcon;
		}
	}

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)mjoTT8Oi2h65dkClqxT();
		}
	}

	public override string Category
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)K8V9PEOnIn4CJ7QeF53();
		}
	}

	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.LGB8a4nK4s();
		}
	}

	public override string HelpTopic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AppStepHelpTopics.VgrCalibration;
		}
	}

	public override int Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qbyUs60AeE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref qbyUs60AeE, value, (string)JVlLnSOVwXWkl9orRCA(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VgrCalibrationStepViewModel()
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
				ShowInSightDisplay = true;
				num = 7;
				continue;
			case 6:
				JHNxLEOI9Am4AiHiC3f();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 4:
				base._002Ector();
				break;
			case 5:
				qbyUs60AeE = 100;
				P0pKI8OO9Nj8Osa7OnN();
				num = ((!s4Eno6OeMOQwjwJULE9()) ? 1 : 4);
				continue;
			case 7:
				return;
			}
			StepDisplay = new VgrCalibrationStepDisplay(((EasyBuilderApplicationViewModel)W6ehQhODHLYm4DQdflS(this))?.Display);
			num = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)cdAHecOf28WrZX2JJgr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task CompleteInitializationAsync(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)cdAHecOf28WrZX2JJgr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JHNxLEOI9Am4AiHiC3f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W6ehQhODHLYm4DQdflS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s4Eno6OeMOQwjwJULE9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool P0pKI8OO9Nj8Osa7OnN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mjoTT8Oi2h65dkClqxT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.VgrCalibration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K8V9PEOnIn4CJ7QeF53()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.zLfruqTZFu();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JVlLnSOVwXWkl9orRCA(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cdAHecOf28WrZX2JJgr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
