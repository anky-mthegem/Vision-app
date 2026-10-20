using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Services;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class ScriptToolApi : IScriptService
{
	private readonly ResourceNode awxa8LhAgH;

	private readonly CvsCogSocket wrOazoFZlI;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ScriptToolApi(ResourceNode parentNode, CvsCogSocket cogSocket)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!hXPOpVd0nMiVWdSImZ0()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 5:
				wrOazoFZlI = cogSocket;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 3:
				awxa8LhAgH = parentNode;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
			case 4:
				Ip1qfjdkF1p0kjOgmDv();
				num = 1;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				r4oP74dfjWv56OA2Boa(this);
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<string> IScriptService.GetScript()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return awxa8LhAgH.GetAsync<string>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11328));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IScriptService.SetScript(string script)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return awxa8LhAgH.PutAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11328), script);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<object[]> IScriptService.GetConsoleLog()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wrOazoFZlI.CameraResourceNode.PostAsync<object[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11352), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ip1qfjdkF1p0kjOgmDv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r4oP74dfjWv56OA2Boa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hXPOpVd0nMiVWdSImZ0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zC3AwZd403A8YYqCONL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
