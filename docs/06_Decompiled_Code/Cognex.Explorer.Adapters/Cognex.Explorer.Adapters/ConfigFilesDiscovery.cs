using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cognex.Dependency;
using Cognex.Dependency.Implementation;
using b4Zxkh9w1NDrmwo2EQ;

namespace Cognex.Explorer.Adapters;

public static class ConfigFilesDiscovery
{
	private static readonly IFileSystem aOoLvAZio;

	private static ConfigFilesDiscovery Bte0k56MK5NoQgEECC;

	public static IEnumerable<string> DiscoverConfigFiles(string configFileSearchPattern, params string[] directories)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < directories.Length; i++)
		{
			IEnumerable<string> enumerable = gbnCs0UYc(directories[i], configFileSearchPattern, aOoLvAZio);
			if (enumerable != null)
			{
				list.AddRange(enumerable);
			}
		}
		return list;
	}

	private static IEnumerable<string> gbnCs0UYc(string P_0, string P_1, IFileSystem P_2)
	{
		if (!P_2.DirectoryExists(P_0))
		{
			return null;
		}
		return from f in P_2.GetFiles(P_0, P_1, SearchOption.AllDirectories)
			orderby f
			select f;
	}

	static ConfigFilesDiscovery()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					aOoLvAZio = new FileSystemImpl();
					return;
				case 1:
					break;
				}
				d6axwalMtbJMEmduIX();
				num2 = 0;
			}
			while (true);
		}
	}

	internal static void d6axwalMtbJMEmduIX()
	{
		YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
	}

	internal static bool cuqhSEdF8Zm5jxLpaT()
	{
		return Bte0k56MK5NoQgEECC == null;
	}

	internal static ConfigFilesDiscovery MYoA9fDloSruuEwI5g()
	{
		return Bte0k56MK5NoQgEECC;
	}
}
