using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Services;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class DetectFlawToolApi : IDetectFlawService
{
	private readonly ResourceNode kLLadQW6JN;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DetectFlawToolApi(ResourceNode resourceNode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		s1NqpsdjIUVnWZ5bRUa();
		int num = ((!vvYU2WdcuIWRfA6JpmF()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				cxOPCHd2ws18yvnbYGa();
				num = 3;
				continue;
			case 3:
				wMWDSRdW9N13T5XgBqG(this);
				break;
			case 5:
				return;
			}
			kLLadQW6JN = resourceNode;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IDetectFlawService.AddResidualImage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kLLadQW6JN.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9766), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IDetectFlawService.ExpandMask()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kLLadQW6JN.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9802), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IDetectFlawService.ShrinkMask()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kLLadQW6JN.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9826), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IDetectFlawService.RemoveMask()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kLLadQW6JN.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9850), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IDetectFlawService.ResetToDefaultMask()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kLLadQW6JN.PostAsync<object>((string)hOkLIrd7wFMgQM2aju7(9874), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsCogDetectFlawDefect[]> IDetectFlawService.GetDefects()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kLLadQW6JN.GetAsync<CvsCogDetectFlawDefect[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9914));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IDetectFlawService.SelectDefects(int[] selectIndexes)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (selectIndexes != null)
		{
			return kLLadQW6JN.PostAsync<object>((string)hOkLIrd7wFMgQM2aju7(9932), new object[1] { selectIndexes });
		}
		return (Task)l2EEJYdtexCBhWiQpiY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IDetectFlawService.IgnoreDefects(int[] ignoreIndexes)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ignoreIndexes != null && ignoreIndexes.Length != 0)
		{
			return kLLadQW6JN.PostAsync<object>((string)hOkLIrd7wFMgQM2aju7(9962), new object[1] { ignoreIndexes });
		}
		return (Task)l2EEJYdtexCBhWiQpiY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<bool> IDetectFlawService.GetShowMaskOverride()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kLLadQW6JN.GetAsync<bool>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9992));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IDetectFlawService.SetShowMaskOverride(bool showMaskOverride)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kLLadQW6JN.PutAsync<object>((string)hOkLIrd7wFMgQM2aju7(9992), showMaskOverride);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cxOPCHd2ws18yvnbYGa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wMWDSRdW9N13T5XgBqG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s1NqpsdjIUVnWZ5bRUa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vvYU2WdcuIWRfA6JpmF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hOkLIrd7wFMgQM2aju7(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l2EEJYdtexCBhWiQpiY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
