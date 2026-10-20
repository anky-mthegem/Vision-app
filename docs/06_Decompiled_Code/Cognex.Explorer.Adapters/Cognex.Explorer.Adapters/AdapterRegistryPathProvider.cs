using System.Collections.Generic;
using System.IO;
using Cognex.Explorer.Common;
using Microsoft.Win32;
using pthEIVC1aCm1sfNHFV;

namespace Cognex.Explorer.Adapters;

public static class AdapterRegistryPathProvider
{
	public static IEnumerable<string> GetPathFromRegistry(string subPath, string configFileSearchPattern)
	{
		string text = Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(0) + ShellVersionInfo.HostVersion.ToString();
		string text2 = (string)Registry.GetValue(text, Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(136), null);
		if (text2 == null)
		{
			throw new RegistryKeyNotFoundException(text + Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(156));
		}
		return ConfigFilesDiscovery.DiscoverConfigFiles(configFileSearchPattern, Path.Combine(text2, subPath));
	}
}
