using System;
using System.Collections.ObjectModel;

namespace Cognex.Explorer.Adapters;

public interface IAdapterRepository
{
	ReadOnlyObservableCollection<IAdapter> ActiveAdapters { get; }

	event EventHandler<AdapterInstalledEventArgs> AdapterUpdateInstalled;

	void Activate(string adapterId);
}
