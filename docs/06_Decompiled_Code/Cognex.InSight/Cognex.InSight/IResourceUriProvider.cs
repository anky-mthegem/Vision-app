using Cognex.InSight.Internal;

namespace Cognex.InSight;

internal interface IResourceUriProvider
{
	string RootResourceUri { get; }

	IRemoteDeviceApi DeviceApi { get; }
}
