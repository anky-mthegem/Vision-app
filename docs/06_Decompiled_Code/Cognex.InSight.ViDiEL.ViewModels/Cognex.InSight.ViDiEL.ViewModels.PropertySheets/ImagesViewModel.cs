using System.Runtime.CompilerServices;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Services;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets;

public class ImagesViewModel : PropertySheetChildViewModel
{
	public readonly ClassifyViewModel ParentViewModel;

	private readonly ViewModelErrors GWjoE1Akqo;

	private readonly PropertySheetConfiguration MLYo81T2Ng;

	public IPropertySheetService PropertySheetService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (IPropertySheetService)hMBKsZr9TJ7bVmlJlEw(MLYo81T2Ng);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImagesViewModel(ClassifyViewModel parentViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (EtNgqkriDkBpKiGjb83() ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 5:
				MLYo81T2Ng = (PropertySheetConfiguration)UhpE3Prty6s4ndngIb3(parentViewModel);
				num = 3;
				continue;
			case 6:
				ParentViewModel = parentViewModel;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				GWjoE1Akqo = new ViewModelErrors(this);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 1:
			case 4:
				break;
			case 0:
			case 2:
				HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
				break;
			case 7:
				return;
			}
			FiVbRPrLenI2Opa6IiJ(this, parentViewModel);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FiVbRPrLenI2Opa6IiJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetChildViewModel)P_0)._002Ector((PropertySheetViewModel)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UhpE3Prty6s4ndngIb3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassifyViewModel)P_0).PropertySheetConfiguration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SHqc08rVvAUNJFe2dxI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EtNgqkriDkBpKiGjb83()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hMBKsZr9TJ7bVmlJlEw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetConfiguration)P_0).PropertySheetService;
	}
}
