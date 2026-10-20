using System.ComponentModel;

namespace Cognex.CogNamer.Client;

public class ClearHostsPropertyChangedEventArgs : PropertyChangedEventArgs
{
	public ClearHostsPropertyChangedEventArgs(string propertyName)
		: base(propertyName)
	{
	}
}
