using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Layouts;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.HMI;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELClassify;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.ViDiEL.ViewModels.Properties;

namespace ICraTblKpVpLpuwWBe;

internal class GjX9jMYl1IjaOnecky : EasyBuilderLayout
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<AppStepViewModel, int> _003C_003E9__20_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KHhJfc5rV18GWQuxfVAs();
			E43EHf5rfr2TCoqXQReX(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003CApplyStepsLayout_003Eb__20_0(AppStepViewModel x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return i0qZ7Z5rdfNxFkV1WOMF(x);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iJFp3t5rinsuogkSlJtr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n1aExS5rn4UiwS1rvD63()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KHhJfc5rV18GWQuxfVAs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void E43EHf5rfr2TCoqXQReX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int i0qZ7Z5rdfNxFkV1WOMF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StepBase)P_0).Order;
		}
	}

	public override bool IsResultQueueVisible
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

	public override bool IsBannerVisible
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

	public override string BannerLayoutName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)ieYJPFKK4IF3E7P8oMpv();
		}
	}

	public override bool IsSetupImageTriggerPanelVisible
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

	public override bool IsCommsPanelCollapsed
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

	public override bool IsClassifyUIConfidenceHidden
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

	public override bool ShouldModifyClasses
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

	public override string Class1Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.n4nLbbdRqA();
		}
	}

	public override string Class2Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)f8CbqaKK7n4jeIgQ2cGj();
		}
	}

	public override int ClassificationConfidence
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override ReadOnlyObservableCollection<AppStepViewModel> sP2bblEtOlY(EasyBuilderApplicationViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<AppStepViewModel> list = new List<AppStepViewModel>(P_0.Steps);
		foreach (AppStepViewModel item in list)
		{
			if (!(item is SetupImageStepViewModel setupImageStepViewModel))
			{
				if (!(item is InspectStepViewModel inspectStepViewModel))
				{
					if (!(item is OutputsStepViewModel))
					{
						if (!(item is CommStepViewModel))
						{
							if (item is HmiStepViewModel)
							{
								item.Order = 4;
							}
						}
						else
						{
							item.Order = 3;
						}
					}
					else
					{
						item.Order = 2;
					}
				}
				else
				{
					Gt7mjyCfml(inspectStepViewModel);
				}
			}
			else
			{
				setupImageStepViewModel.AcqSettings.EasyModeExposure.Range = new InclusiveRange<double>(0.0, 5.0);
			}
		}
		list = list.OrderBy([MethodImpl(MethodImplOptions.NoInlining)] (AppStepViewModel x) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.i0qZ7Z5rdfNxFkV1WOMF(x);
		}).ToList();
		return new ReadOnlyObservableCollection<AppStepViewModel>(new ObservableCollection<AppStepViewModel>(list));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PitmTdfyiP(InspectStepViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		foreach (ToolCategory simplifiedCategory in P_0.SimplifiedCategories)
		{
			simplifiedCategory.IsExpanded = sEoKBeKKj1bnWEyfWKU5(simplifiedCategory.Name, r1UafCKK3qadlFYjW4bQ());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void topmWbv4ZX(InspectStepViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (eYIuFVKKXVVr7nNhOpDj())
		{
			goto IL_00b8;
		}
		goto IL_0163;
		IL_0163:
		int num2 = num2 + 1;
		num = 4;
		goto IL_00b8;
		IL_00b8:
		ViDiELClassifyToolType viDiELClassifyToolType = default;
		EzToolType ezToolType = default;
		EzToolType[] toolTypes = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				viDiELClassifyToolType = ezToolType as ViDiELClassifyToolType;
				num = 1;
				if (!CfuSTtKK9JVPnKc9GhT2())
				{
					continue;
				}
				break;
			case 1:
				if (viDiELClassifyToolType != null)
				{
					LejhyCKK69edj5yxeW0T(viDiELClassifyToolType, 0);
					num = 11;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				goto case 0;
			case 7:
				num2 = 0;
				CfuSTtKK9JVPnKc9GhT2();
				num = (eYIuFVKKXVVr7nNhOpDj() ? 12 : 0);
				continue;
			case 0:
			case 5:
				if (!(ezToolType is RedLineToolType redLineToolType))
				{
					break;
				}
				redLineToolType.Order = 90;
				num = 9;
				continue;
			default:
				num = 3;
				if (eYIuFVKKXVVr7nNhOpDj())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 4:
			case 12:
				if (num2 >= toolTypes.Length)
				{
					num = 8;
					continue;
				}
				ezToolType = toolTypes[num2];
				num = 6;
				if (eYIuFVKKXVVr7nNhOpDj())
				{
					continue;
				}
				goto case 8;
			case 8:
				LtQeJWKKCCJTCySDxOdf(P_0, P_0.AppViewModel.EasyBuilderConfig);
				num = 13;
				if (eYIuFVKKXVVr7nNhOpDj())
				{
					continue;
				}
				goto case 10;
			case 10:
				toolTypes = P_0.ToolTypes;
				num = 7;
				continue;
			case 3:
			case 9:
			case 11:
				break;
			case 13:
				return;
			}
			break;
		}
		goto IL_0163;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Gt7mjyCfml(InspectStepViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		topmWbv4ZX(P_0);
		PitmTdfyiP(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override bool aGPbbKPdxWt(EzToolType P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eYIuFVKKXVVr7nNhOpDj();
		int num = (CfuSTtKK9JVPnKc9GhT2() ? 1 : 4);
		ViDiELClassifyToolType viDiELClassifyToolType = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				viDiELClassifyToolType = P_0 as ViDiELClassifyToolType;
				num = 3;
				break;
			default:
				ApKmCdmDqY(viDiELClassifyToolType);
				num = 5;
				break;
			case 3:
				if (viDiELClassifyToolType != null)
				{
					goto default;
				}
				return false;
			case 5:
				return true;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApKmCdmDqY(ViDiELClassifyToolType P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		CvsCell cvsCell = default;
		CvsCogImage cvsCogImage = default;
		SourceLink sourceLink = default;
		int num2 = default;
		int num3 = default;
		CvsDisplayableRegion cvsDisplayableRegion = default;
		do
		{
			IL_0071:
			switch (num)
			{
			case 4:
				if (cvsCell != null)
				{
					cvsCogImage = jIkfjjKKFP7ovm83eGsh(cvsCell.CellResult) as CvsCogImage;
					num = 0;
					if (0 == 0)
					{
						goto IL_0071;
					}
					goto case 6;
				}
				goto case 10;
			case 6:
				sourceLink = P_0.InputImageLinks[VBYg7TKKAeLaN2JihsY6(P_0)];
				num = 3;
				goto IL_0071;
			case 0:
				if (cvsCogImage != null)
				{
					goto case 1;
				}
				goto case 10;
			default:
				num = 1;
				goto IL_0071;
			case 3:
				cvsCell = (CvsCell)SwgU3WKK02p4oIfl2IG7(((CvsResultSet)jLvhNTKKT4fw7xabrNS2(jhhfchKKWP0h8tqhnD19(IK889mKKR2O9xehpjZ9Y(P_0)))).Cells, new CvsCellLocation((string)Y1PQreKKySacsYjMA1pJ(sourceLink)));
				num = 4;
				goto IL_0071;
			case 5:
			case 7:
				num2 = Kqdr8lKKYIkehjyhDbfo(cvsCogImage);
				num = 10;
				goto IL_0071;
			case 1:
				num3 = T7fM1pKKMa3csUFHmpuj(cvsCogImage);
				_ = 1;
				num = (CfuSTtKK9JVPnKc9GhT2() ? 8 : 5);
				goto IL_0071;
			case 11:
				num3 = 200;
				num = 2;
				goto IL_0071;
			case 10:
				cvsDisplayableRegion = EditableGraphicHelper.ConstructRegion(CvsCellLocation.Invalid, (int)((double)num3 * 0.1), (int)((double)num2 * 0.1), (int)((double)num3 * 0.8), (int)((double)num2 * 0.8), 0.0, 0.0, cvsCell);
				break;
			case 2:
				num2 = 200;
				num = 6;
				if (!CfuSTtKK9JVPnKc9GhT2())
				{
					goto IL_0071;
				}
				break;
			case 8:
			case 9:
				break;
			case 12:
				return;
			}
			DmRomDKKUBF4Sm7nUpkG(P_0, cvsDisplayableRegion);
			num = 12;
		}
		while (eYIuFVKKXVVr7nNhOpDj());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GjX9jMYl1IjaOnecky()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KTDx1aKKH7GU522L2Oqc();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ieYJPFKK4IF3E7P8oMpv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.MhW04vHgLE();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f8CbqaKK7n4jeIgQ2cGj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.YYgnjVY9Uf();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r1UafCKK3qadlFYjW4bQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELTools;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sEoKBeKKj1bnWEyfWKU5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eYIuFVKKXVVr7nNhOpDj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CfuSTtKK9JVPnKc9GhT2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LejhyCKK69edj5yxeW0T(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzToolType)P_0).Order = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LtQeJWKKCCJTCySDxOdf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InspectStepViewModel)P_0).InitToolTypes((CvsCogEasyBuilderConfig)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VBYg7TKKAeLaN2JihsY6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).InputImageIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IK889mKKR2O9xehpjZ9Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jhhfchKKWP0h8tqhnD19(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jLvhNTKKT4fw7xabrNS2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y1PQreKKySacsYjMA1pJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SwgU3WKK02p4oIfl2IG7(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jIkfjjKKFP7ovm83eGsh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int T7fM1pKKMa3csUFHmpuj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Kqdr8lKKYIkehjyhDbfo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DmRomDKKUBF4Sm7nUpkG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELClassifyToolType)P_0).EditableRegion = (CvsDisplayableRegion)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KTDx1aKKH7GU522L2Oqc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
