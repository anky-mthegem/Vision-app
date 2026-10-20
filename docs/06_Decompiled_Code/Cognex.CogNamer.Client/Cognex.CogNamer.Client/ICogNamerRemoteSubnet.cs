using System.Net;

namespace Cognex.CogNamer.Client;

public interface ICogNamerRemoteSubnet
{
	IPAddress IPAddress { get; set; }

	IPAddress Mask { get; set; }
}
