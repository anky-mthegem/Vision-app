using System.ComponentModel;

namespace Cognex.CogNamer.Client;

public class ChangeHostPropertyChangedEventArgs : PropertyChangedEventArgs
{
	public CogNamerDevice RemovedDevice { get; }

	public CogNamerDevice AddedDevice { get; }

	public ChangeHostPropertyChangedEventArgs(string propertyName, CogNamerDevice oldDevice, CogNamerDevice newDevice)
		: base(propertyName)
	{
		RemovedDevice = oldDevice;
		AddedDevice = newDevice;
	}
}
