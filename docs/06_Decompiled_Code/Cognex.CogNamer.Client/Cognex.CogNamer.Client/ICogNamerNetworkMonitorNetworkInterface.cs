using System;
using System.Net;
using System.Net.Sockets;

namespace Cognex.CogNamer.Client;

public interface ICogNamerNetworkMonitorNetworkInterface : IDisposable
{
	event CogNamerPacketReceivedEventHandler PacketReceived;

	void ClearCachedInterfaceInfo();

	void DisableUdpConnReset(Socket socket);

	void SendSubnetBroadcast(byte[] packetBuffer, int length);

	void SendPacket(byte[] packetBuffer, int length, IPEndPoint endPoint);

	void Start();
}
