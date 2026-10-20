using System.Net;

namespace Cognex.CogNamer.Client;

public interface ICogNamerNetworkAdapter
{
	IPAddress IP { get; }

	IPAddress SubnetMask { get; }

	IPAddress SubnetBroadcast { get; }

	bool IsLoopback { get; }

	bool IsInSubnet(IPAddress address);
}
