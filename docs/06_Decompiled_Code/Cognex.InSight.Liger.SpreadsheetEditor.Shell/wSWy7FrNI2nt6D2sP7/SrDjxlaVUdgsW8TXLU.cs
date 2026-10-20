using System.Composition;
using System.Runtime.CompilerServices;
using Cognex.CogNamer.Client;
using Cognex.CogNamer.Client.Attributes;
using Cognex.Documentation;
using Cognex.InSight.IDE.Common;
using Cognex.ServiceLocator;
using MiADQg66xs74MkKsSp;
using fwndm9dOZy61LXFGHR;

namespace wSWy7FrNI2nt6D2sP7;

[Export(typeof(IHelpSystem))]
internal class SrDjxlaVUdgsW8TXLU : HelpSystem
{
	private static readonly string i4OX7PKdF;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SrDjxlaVUdgsW8TXLU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		jn3p43FShOg9dGcDiF();
		int num;
		if (!BNwKKCqnlf22jgamEA())
		{
			num = 5;
			if (1 == 0)
			{
				return;
			}
		}
		else
		{
			num = 3;
		}
		string modelNumber = default;
		CogNamerNetworkDeviceType cogNamerNetworkDeviceType = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 0:
			case 5:
				TtyXORhirCqMfPlYgE();
				num = 8;
				continue;
			case 1:
				if (!HyKq3JnkIwxF2j52E6(modelNumber, zl1yAMP0exExSdqEo1(0)))
				{
					SetHelpFileBasePath(i4OX7PKdF);
					num = 9;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				num = 7;
				continue;
			case 2:
			case 3:
			{
				InSightStartupArgs instance = Locator.Current.GetInstance<InSightStartupArgs>();
				cogNamerNetworkDeviceType = c1ZjflmMeWnG9VqWhw(Cjj41c9cbvGyfpj30F(instance));
				modelNumber = ((CogNamerDevice)Cjj41c9cbvGyfpj30F(instance)).ModelNumber;
				num = 6;
				continue;
			}
			case 8:
				HUY5ZiME8qiGsNGLrP(this);
				goto case 2;
			case 6:
				if (cogNamerNetworkDeviceType == CogNamerNetworkDeviceType.InSightL38)
				{
					break;
				}
				goto case 1;
			default:
				num = 1;
				continue;
			case 7:
				break;
			case 9:
				return;
			}
			mAljyf8QlMllRBxMwd(this, i4OX7PKdF + (string)zl1yAMP0exExSdqEo1(28));
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SrDjxlaVUdgsW8TXLU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TtyXORhirCqMfPlYgE();
		i4OX7PKdF = (string)zl1yAMP0exExSdqEo1(36);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TtyXORhirCqMfPlYgE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QydVltWcCHDiPv4cA0.RScLt1ez0Xo5H();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HUY5ZiME8qiGsNGLrP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((HelpSystem)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Cjj41c9cbvGyfpj30F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InSightStartupArgs)P_0).CogNamerDevice;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CogNamerNetworkDeviceType c1ZjflmMeWnG9VqWhw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CogNamerDevice)P_0).Type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zl1yAMP0exExSdqEo1(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BPZOUyCNIstMNXq2qm.sDbguHB1e(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HyKq3JnkIwxF2j52E6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Contains((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mAljyf8QlMllRBxMwd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((HelpSystem)P_0).SetHelpFileBasePath((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jn3p43FShOg9dGcDiF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BNwKKCqnlf22jgamEA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
