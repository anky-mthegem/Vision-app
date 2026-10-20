using System.Composition;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Run;

[Shared]
[Export(typeof(AppStepViewModel))]
public class RunStepViewModel : AppStepViewModel, IInSightAppStep
{
	private int ffrUZhB4GH;

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Steps_RunIcon;
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
			return (string)e3KuIZOFfcyjEvdWg10();
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
			return (string)rnCaffOMxeViVAk3P3m();
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
			return (string)iEIRjaOYLKU84DZxyY0();
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
			return AppStepHelpTopics.Run;
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
			return ffrUZhB4GH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref ffrUZhB4GH, value, (string)PB6NlFOUv6d9uslLeec(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ImportingConstructor]
	public RunStepViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CZ3B43OTYoeV3f94EMO();
		int num;
		if (!bSGdyEOyt7WXrG921uG())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				base._002Ector();
				break;
			default:
				num = 5;
				continue;
			case 1:
			case 3:
				ffrUZhB4GH = 800;
				num = 6;
				continue;
			case 4:
				ShowInSightDisplay = true;
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 5:
				break;
			case 0:
			case 2:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 7:
				return;
			}
			StepDisplay = new RunStepDisplay(((EasyBuilderApplicationViewModel)Xj6rBEO0kTkFrENEqZw(this))?.Display);
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)pd2IsEOH8AWLuYkmm2a();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task CompleteInitializationAsync(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)pd2IsEOH8AWLuYkmm2a();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xj6rBEO0kTkFrENEqZw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CZ3B43OTYoeV3f94EMO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bSGdyEOyt7WXrG921uG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e3KuIZOFfcyjEvdWg10()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Run;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rnCaffOMxeViVAk3P3m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.G8N9KIQENn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iEIRjaOYLKU84DZxyY0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.nC09BIt9VC();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PB6NlFOUv6d9uslLeec(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pd2IsEOH8AWLuYkmm2a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
