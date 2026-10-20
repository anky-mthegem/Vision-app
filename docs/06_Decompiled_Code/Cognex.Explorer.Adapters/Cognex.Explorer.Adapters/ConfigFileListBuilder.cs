using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using b4Zxkh9w1NDrmwo2EQ;
using pthEIVC1aCm1sfNHFV;

namespace Cognex.Explorer.Adapters;

public class ConfigFileListBuilder
{
	private readonly string sFam1DLEP;

	private readonly string tArEVHjTr;

	[CompilerGenerated]
	private readonly IEnumerable<string> hUOdrxKPO;

	[CompilerGenerated]
	private readonly IEnumerable<string> V8Z55oWrN;

	internal static ConfigFileListBuilder A8pLLbyQtNm7ssCTd2;

	public IEnumerable<string> AdapterConfigFiles
	{
		[CompilerGenerated]
		get
		{
			return hUOdrxKPO;
		}
	}

	public IEnumerable<string> EmulatorConfigFiles
	{
		[CompilerGenerated]
		get
		{
			return V8Z55oWrN;
		}
	}

	public ConfigFileListBuilder(IDirectoryProvider directoryProvider)
	{
		KxAhGerTjPMlCVZywx();
		sFam1DLEP = Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(178);
		tArEVHjTr = Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(242);
		base._002Ector();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					hUOdrxKPO = AdapterRegistryPathProvider.GetPathFromRegistry(sFam1DLEP, (string)LTrj6OtINvcf9SXD0D(264));
					num2 = 3;
					continue;
				case 1:
					if (!EmulatorConfigFiles.Any())
					{
						num2 = 0;
						if (0 == 0)
						{
							continue;
						}
						break;
					}
					return;
				case 3:
					V8Z55oWrN = AdapterRegistryPathProvider.GetPathFromRegistry(tArEVHjTr, Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(292));
					return;
				case 5:
					if (!AdapterConfigFiles.Any())
					{
						num2 = 1;
						if (0 == 0)
						{
							continue;
						}
						break;
					}
					return;
				case 2:
					hUOdrxKPO = ConfigFilesDiscovery.DiscoverConfigFiles(Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(264), (string[])Eav1HGsUFURGTIXKKA(directoryProvider));
					num2 = 4;
					continue;
				case 4:
					V8Z55oWrN = ConfigFilesDiscovery.DiscoverConfigFiles(Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(292), (string[])SiEbucYmFAUOAJyiGn(directoryProvider));
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	internal static void KxAhGerTjPMlCVZywx()
	{
		YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
	}

	internal static object Eav1HGsUFURGTIXKKA(object P_0)
	{
		return ((IDirectoryProvider)P_0).GetAdapterDirectories();
	}

	internal static object SiEbucYmFAUOAJyiGn(object P_0)
	{
		return ((IDirectoryProvider)P_0).GetEmulatorDirectories();
	}

	internal static object LTrj6OtINvcf9SXD0D(int P_0)
	{
		return Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(P_0);
	}

	internal static bool t0UORaW2nVkcAlGDil()
	{
		return A8pLLbyQtNm7ssCTd2 == null;
	}

	internal static ConfigFileListBuilder aksYfEUaTyg2YVXiBF()
	{
		return A8pLLbyQtNm7ssCTd2;
	}
}
