namespace Cognex.Explorer.Common;

public interface IManagedAcceleratorTarget : IManagedTarget
{
	RemoteDevice[] RemoteDevices { get; }
}
