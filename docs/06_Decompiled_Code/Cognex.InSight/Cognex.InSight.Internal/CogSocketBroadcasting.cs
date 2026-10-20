using System;
using System.Runtime.CompilerServices;
using Cognex.Features;
using Cognex.Remoting.Broadcasting;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public static class CogSocketBroadcasting
{
	public const int DefaultPort = 9011;

	private static readonly FeatureFlag<int> eqQo23JaeE;

	private static ISerializedMessagesSink tWooyHsyfR;

	private static CogSocketFrameworkRegistry fMMoVZr9mU;

	private static bool AsQovNZ4D2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CogSocketBroadcasting()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!nTEqfWeJs9SCctJwM7Z()) ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				WtijCTezVcShDiHKjMl();
				goto case 1;
			case 1:
			case 3:
			{
				FeatureDescriptor featureDescriptor = new FeatureDescriptor();
				QHLBb5usiEuZE0GNTpn(featureDescriptor, IMIBoguws8vXbWYe3AY(36642));
				h8UXeDuhgbYAiToNGpA(featureDescriptor, kgbOBx7BanbFa22Hp9.ol99ukmDA(36716));
				s6pKLxuLwEBpBNKErpi(featureDescriptor, 9011);
				eqQo23JaeE = FeatureRegistry.RegisterFeature<int>(featureDescriptor);
				break;
			}
			default:
				goto IL_00a3;
			case 4:
				break;
			}
			break;
			IL_00a3:
			num = 4;
		}
		try
		{
			if (c6iqyYu9olThiPdFUQO(eqQo23JaeE))
			{
				ForceEnableBroadcasting(eqQo23JaeE.Value);
			}
		}
		catch (Exception)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool InitializeIfEnabled()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsQovNZ4D2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ForceEnableBroadcasting(int port)
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
			case 4:
				throw new InvalidOperationException((string)IMIBoguws8vXbWYe3AY(36840));
			case 5:
				AsQovNZ4D2 = true;
				num = 7;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				fMMoVZr9mU = new CogSocketFrameworkRegistry(tWooyHsyfR);
				num = 5;
				continue;
			case 0:
			case 2:
				tWooyHsyfR = new HttpMessageSink(port);
				goto default;
			case 6:
				break;
			case 7:
				return;
			}
			do
			{
				if (!AsQovNZ4D2)
				{
					Vnv7GPuSGhW5aUi64KG();
					sBSriGe8onAW16jlLhW();
					if (nTEqfWeJs9SCctJwM7Z())
					{
						num = 0;
						break;
					}
					num = 1;
					continue;
				}
				num = 4;
				break;
			}
			while (1 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WtijCTezVcShDiHKjMl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IMIBoguws8vXbWYe3AY(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QHLBb5usiEuZE0GNTpn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Id = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h8UXeDuhgbYAiToNGpA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Description = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s6pKLxuLwEBpBNKErpi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).DefaultValue = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c6iqyYu9olThiPdFUQO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FeatureFlag)P_0).IsEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nTEqfWeJs9SCctJwM7Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sBSriGe8onAW16jlLhW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vnv7GPuSGhW5aUi64KG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VersionIndependentCogSocket.InstallIfRequired();
	}
}
