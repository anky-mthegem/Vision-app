using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.CogNamer.Client;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Run;
using Cognex.InSight.IDE.Common;
using Cognex.InSight.IDE.Common.Authentication;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.Extensions;
using Cognex.InSight.Runtime.Ftp;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Validation;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Validation;

public class ValidationStepViewModel : AppStepViewModel, IInSightAppStep
{
	private int FPKUG7px6C;

	[CompilerGenerated]
	private ValidationPanelViewModel ejxUBeKyRE;

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
			return (string)vgkk0DOvC9c7MW0JBOp();
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
			return (string)KZ5oSjOrCgalhasWtjx();
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
			return Resources.HSNhmvaAoI();
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
			return AppStepHelpTopics.Inspect;
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
			return FPKUG7px6C;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref FPKUG7px6C, value, (string)tFucwxOP27xBiIakuEJ(3256));
		}
	}

	public ValidationPanelViewModel ValidationViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ejxUBeKyRE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ejxUBeKyRE = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValidationStepViewModel()
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
			default:
				StepDisplay = new RunStepDisplay(((EasyBuilderApplicationViewModel)zv3UNrOsLE6uhIXQdtr(this))?.Display);
				num = 4;
				break;
			case 4:
				ShowInSightDisplay = true;
				num = 7;
				break;
			case 1:
			case 2:
				base._002Ector();
				goto default;
			case 5:
				FPKUG7px6C = 600;
				GQgVFtOlX0BtnER7dYs();
				num = (QaWAsKOdyBOjcaySQRF() ? 1 : 0);
				break;
			case 6:
				LadkUDOgqmCjRJDyqdI();
				num = 5;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		ValidationService validationService = default;
		FtpService ftpService = default;
		UserData userData = default;
		while (true)
		{
			object obj4;
			object obj2;
			object obj;
			NetworkCredential credentials;
			switch (num)
			{
			case 9:
				validationService = new ValidationService((ResourceNode)HRaWEyOb5u8F6ah73kX(rVREs9OB5D9LJiGRaFx(GXfcoJOZPZ9xcuVLuCU(this))), (ResourceNode)X5hvFGOGbJ0OSSl2qxS(rVREs9OB5D9LJiGRaFx(GXfcoJOZPZ9xcuVLuCU(this))));
				_ = 1;
				num = (GQgVFtOlX0BtnER7dYs() ? 3 : 6);
				break;
			case 10:
				if (((CogNamerDevice)q4vpy0Ooe3aElfhmZj4(ezbVm)).GetServicePort((string)tFucwxOP27xBiIakuEJ(3270)) > 0)
				{
					num = 4;
					if (QaWAsKOdyBOjcaySQRF())
					{
						break;
					}
					goto case 8;
				}
				goto case 5;
			case 8:
				obj4 = null;
				goto IL_008a;
			case 5:
				ValidationViewModel = new ValidationPanelViewModel((CvsInSight)GXfcoJOZPZ9xcuVLuCU(this), null, validationService, ftpService, ezbVm.Runtime, ViewModelBroadcaster.Default);
				num = 11;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 6:
				ftpService = null;
				goto case 2;
			case 4:
			{
				object obj3 = kFZxuPOSxTRnydDBRND(ezbVm);
				if (obj3 != null)
				{
					obj4 = ((InSightStartupArgs)obj3).User;
					goto IL_008a;
				}
				goto case 8;
			}
			default:
				num = 8;
				break;
			case 7:
				obj2 = new NetworkCredential((string)NOQu20O8xglOq3a1ot5(userData), (string)jyd1DIOqNXKReYhQ5tT(userData));
				goto IL_014f;
			case 0:
				obj = null;
				goto IL_0173;
			case 2:
			case 3:
				if (q4vpy0Ooe3aElfhmZj4(ezbVm) != null)
				{
					num = 10;
					break;
				}
				goto case 5;
			case 11:
				{
					return Task.CompletedTask;
				}
				IL_014f:
				credentials = (NetworkCredential)obj2;
				ftpService = new FtpService((CogNamerDevice)q4vpy0Ooe3aElfhmZj4(ezbVm), credentials);
				num = 5;
				break;
				IL_008a:
				userData = (UserData)obj4;
				if (userData == null)
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				obj = userData.Username;
				goto IL_0173;
				IL_0173:
				if (PUCqG0OkFgKypj2tQnw(obj))
				{
					obj2 = null;
					goto IL_014f;
				}
				num = 7;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task CompleteInitializationAsync(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)YX2EZHOE6VBVuqfdRKA();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LadkUDOgqmCjRJDyqdI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zv3UNrOsLE6uhIXQdtr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QaWAsKOdyBOjcaySQRF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GQgVFtOlX0BtnER7dYs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vgkk0DOvC9c7MW0JBOp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Validation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KZ5oSjOrCgalhasWtjx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.zLfruqTZFu();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tFucwxOP27xBiIakuEJ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GXfcoJOZPZ9xcuVLuCU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rVREs9OB5D9LJiGRaFx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HRaWEyOb5u8F6ah73kX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).GetRuntimeResource();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X5hvFGOGbJ0OSSl2qxS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).GetValidationResource();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q4vpy0Ooe3aElfhmZj4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).iWIKIyxRi();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kFZxuPOSxTRnydDBRND(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).StartupArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PUCqG0OkFgKypj2tQnw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NOQu20O8xglOq3a1ot5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UserData)P_0).Username;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jyd1DIOqNXKReYhQ5tT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UserData)P_0).GetUnencryptedPassword();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YX2EZHOE6VBVuqfdRKA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
