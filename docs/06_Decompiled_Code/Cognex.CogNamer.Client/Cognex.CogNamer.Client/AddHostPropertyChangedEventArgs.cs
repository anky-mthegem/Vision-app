using System.ComponentModel;

namespace Cognex.CogNamer.Client;

public class AddHostPropertyChangedEventArgs : PropertyChangedEventArgs
{
	public CogNamerDevice AddedDevice { get; }

	public AddHostPropertyChangedEventArgs(string propertyName, CogNamerDevice addedDevice)
		: base(propertyName)
	{
		AddedDevice = addedDevice;
	}
}
