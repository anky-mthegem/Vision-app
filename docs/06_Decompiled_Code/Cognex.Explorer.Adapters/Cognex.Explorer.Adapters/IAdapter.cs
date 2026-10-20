using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Cognex.Explorer.Adapters;

public interface IAdapter
{
	string AdapterGroup { get; }

	string UniqueId { get; }

	Version Version { get; }

	Version HostVersion { get; }

	bool SupportsDiscovery { get; }

	bool Is32Bit { get; }

	string EntryPoint { get; }

	DateTime ReleaseDate { get; }

	List<string> SupportedLanguages { get; }

	string HelpFile { get; }

	BitmapImage Logo { get; }

	string GetEntryPointPath();
}
