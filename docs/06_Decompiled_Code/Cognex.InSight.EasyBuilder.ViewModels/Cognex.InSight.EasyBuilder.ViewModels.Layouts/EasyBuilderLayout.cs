using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Remoting.Serialization;
using ICraTblKpVpLpuwWBe;

namespace Cognex.InSight.EasyBuilder.ViewModels.Layouts;

public class EasyBuilderLayout
{
	public virtual bool IsResultQueueVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	public virtual bool IsBannerVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public virtual string BannerLayoutName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return "";
		}
	}

	public virtual bool IsSetupImageTriggerPanelVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public virtual bool IsCommsPanelCollapsed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public virtual bool IsClassifyUIConfidenceHidden
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public virtual bool ShouldModifyClasses
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public virtual string Class1Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return "";
		}
	}

	public virtual string Class2Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return "";
		}
	}

	public virtual int ClassificationConfidence
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 70;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static EasyBuilderLayout CreateLayout(CvsCogEasyBuilderConfig config)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EgYZKkKK8g2YdX68eX8B();
		int num = (PwbH7QKKqgo9pwRvEHfM() ? 4 : 6);
		bool? flag2 = default;
		while (true)
		{
			bool? flag;
			switch (num)
			{
			case 0:
			case 6:
			{
				if (config == null)
				{
					num = 2;
					if (!PwbH7QKKqgo9pwRvEHfM())
					{
						break;
					}
					goto case 2;
				}
				object obj = r37rvTKKEYrugFpHPUf1(config);
				if (obj == null)
				{
					goto default;
				}
				flag = ((IEnumerable<CvsCogEasyBuilderLayout>)obj).Contains(CvsCogEasyBuilderLayout.Logistics);
				goto IL_00cd;
			}
			case 2:
				flag2 = null;
				num = 1;
				break;
			case 1:
				flag = flag2;
				goto IL_00cd;
			default:
				flag2 = null;
				num = 5;
				break;
			case 5:
				flag = flag2;
				goto IL_00cd;
			case 7:
				{
					return new GjX9jMYl1IjaOnecky();
				}
				IL_00cd:
				flag2 = flag;
				if (flag2 == true)
				{
					num = 7;
					break;
				}
				return new EasyBuilderLayout();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal virtual ReadOnlyObservableCollection<AppStepViewModel> sP2bblEtOlY(EasyBuilderApplicationViewModel appViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return appViewModel.Steps;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal virtual bool aGPbbKPdxWt(EzToolType ezToolType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EasyBuilderLayout()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		uT5BcrKKp9DpFd874nH2(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r37rvTKKEYrugFpHPUf1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEasyBuilderConfig)P_0).Layouts;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EgYZKkKK8g2YdX68eX8B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PwbH7QKKqgo9pwRvEHfM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uT5BcrKKp9DpFd874nH2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
