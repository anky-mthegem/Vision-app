using System.Net;

namespace Cognex.CogNamer.Client;

public interface ICogNamerPacketReceivedEventArgs
{
	IPAddress LocalIP { get; set; }

	IPEndPoint IPEndPoint { get; set; }

	byte[] Data { get; set; }

	int Length { get; set; }

	bool Handled { get; set; }

	bool IsPacketLocal(IPAddress address);
}
