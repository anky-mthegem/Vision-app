using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.InSight.Controls.Display.Views.Wpf.Test;
using Cognex.InSight.Services;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class CaliperMethodToolApi : ICaliperMethodService
{
	private readonly ResourceNode wuLaidJ0Wy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CaliperMethodToolApi(ResourceNode parentNode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!Fg8gqTddIsVOUlgSlyq()) ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				base._002Ector();
				break;
			default:
				num = 3;
				continue;
			case 3:
				break;
			case 0:
			case 4:
				zqFkb2dqFLtbN4oK3j6();
				goto case 1;
			case 5:
				return;
			}
			wuLaidJ0Wy = parentNode;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsCogCaliperScoringMethod[]> ICaliperMethodService.GetCaliperScoringMethods()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wuLaidJ0Wy.PostAsync<CvsCogCaliperScoringMethod[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9558), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ICaliperMethodService.SetCaliperScoringMethods(CvsCogCaliperScoringMethod[] methods)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wuLaidJ0Wy.PostAsync<object>((string)gbh8mFdBVrNPldpRshs(9602), new object[1] { methods });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsCogCaliperScoringMethod> ICaliperMethodService.GetScoringMethod(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wuLaidJ0Wy.PostAsync<CvsCogCaliperScoringMethod>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9646), new object[2] { index, 0 });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ICaliperMethodService.UpdateCaliperScoringMethod(int index, CvsCogCaliperScoringMethod method)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wuLaidJ0Wy.PostAsync<object>((string)gbh8mFdBVrNPldpRshs(9682), new object[2] { index, method });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ICaliperMethodService.ResetAllScoringMethods()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wuLaidJ0Wy.PostAsync<object>((string)gbh8mFdBVrNPldpRshs(9718), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zqFkb2dqFLtbN4oK3j6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fg8gqTddIsVOUlgSlyq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rw57L7di7sPo80CuacP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gbh8mFdBVrNPldpRshs(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
