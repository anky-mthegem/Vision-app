using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cognex.Features;
using Cognex.InSight.VisionBuilder.Types;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder;

internal static class VisionBuilderConfig
{
	public static readonly Server VisionEu;

	public static readonly Server VisionUs;

	public static readonly Server[] ProductionServers;

	private static readonly FeatureFlag<int> BUdpi9bpO3;

	public static int MaximumNumberOfImageUploads
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BUdpi9bpO3.Value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Server[] GetConfigFileServers(string configFilePath = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MZBb4qjtVcDZ7gCa4l2();
		int num;
		if (wu7AAfj7d0pHqP1lYph())
		{
			num = 6;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0081;
		IL_002a:
		string text = default;
		configFilePath = (string)Feb9EejoLp0B6lYV7TZ(new string[5]
		{
			text,
			(string)j4mKPcj5MybcqOCGyb5(13986),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(14002),
			(string)j4mKPcj5MybcqOCGyb5(14002),
			(string)j4mKPcj5MybcqOCGyb5(14022)
		});
		goto IL_00c8;
		IL_011f:
		Server[] array;
		return (Server[])array;
		IL_00c8:
		if (!tOtYpKjPJp0J4rbjTsN(configFilePath))
		{
			num = 5;
		}
		else
		{
			array = JsonConvert.DeserializeObject<Server[]>((string)l5sT8fjYaVf8xA9Zoic(configFilePath));
			if (array != null)
			{
				goto IL_011f;
			}
			num = 7;
		}
		goto IL_0081;
		IL_011a:
		array = Array.Empty<Server>();
		goto IL_011f;
		IL_0081:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				break;
			default:
				num = 3;
				continue;
			case 1:
				text = (string)i78cuVjKq3Z7uFWSYdZ(Environment.SpecialFolder.CommonApplicationData);
				break;
			case 3:
				goto IL_00c8;
			case 0:
			case 6:
				if (!ugBV3EjCjIAMrtg8dPi(configFilePath))
				{
					goto IL_00c8;
				}
				num = 1;
				if (wu7AAfj7d0pHqP1lYph())
				{
					continue;
				}
				goto case 5;
			case 5:
				return Array.Empty<Server>();
			case 7:
				goto IL_011a;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisionBuilderConfig()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (MZBb4qjtVcDZ7gCa4l2() ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				VisionUs = new Server((string)j4mKPcj5MybcqOCGyb5(14422), (string)j4mKPcj5MybcqOCGyb5(14538), (string)j4mKPcj5MybcqOCGyb5(14582), (string)j4mKPcj5MybcqOCGyb5(14638), kgbOBx7BanbFa22Hp9.ol99ukmDA(14706), kgbOBx7BanbFa22Hp9.ol99ukmDA(14706));
				break;
			default:
				num = 2;
				if (wu7AAfj7d0pHqP1lYph())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 6:
			{
				FeatureDescriptor featureDescriptor = new FeatureDescriptor();
				BcdL90jNmSMGYk81SBB(featureDescriptor, j4mKPcj5MybcqOCGyb5(14766));
				featureDescriptor.DefaultValue = 8;
				featureDescriptor.Description = kgbOBx7BanbFa22Hp9.ol99ukmDA(14828);
				BUdpi9bpO3 = FeatureRegistry.RegisterFeature<int>(featureDescriptor);
				num = 7;
				if (wu7AAfj7d0pHqP1lYph())
				{
					continue;
				}
				goto case 1;
			}
			case 1:
			case 5:
				VisionEu = new Server((string)j4mKPcj5MybcqOCGyb5(14078), (string)j4mKPcj5MybcqOCGyb5(14194), kgbOBx7BanbFa22Hp9.ol99ukmDA(14238), (string)j4mKPcj5MybcqOCGyb5(14294), (string)j4mKPcj5MybcqOCGyb5(14362), kgbOBx7BanbFa22Hp9.ol99ukmDA(14362));
				num = 3;
				continue;
			case 2:
				break;
			case 7:
				return;
			}
			ProductionServers = new Server[2] { VisionEu, VisionUs };
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ugBV3EjCjIAMrtg8dPi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i78cuVjKq3Z7uFWSYdZ(Environment.SpecialFolder P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Environment.GetFolderPath(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j4mKPcj5MybcqOCGyb5(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Feb9EejoLp0B6lYV7TZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Path.Combine((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tOtYpKjPJp0J4rbjTsN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return File.Exists((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l5sT8fjYaVf8xA9Zoic(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return File.ReadAllText((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wu7AAfj7d0pHqP1lYph()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MZBb4qjtVcDZ7gCa4l2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BcdL90jNmSMGYk81SBB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Id = (string)P_1;
	}
}
