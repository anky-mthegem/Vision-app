using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Cognex.CogNamer.Client;

internal static class SocketExtensions
{
	public struct ReceiveInfo
	{
		public byte[] Buffer;

		public int Length;

		public SocketFlags Flags;

		public IPPacketInformation PacketInfo;

		public EndPoint EndPoint;
	}

	public static Task ConnectTaskAsync(this Socket socket, string host, int port)
	{
		return Task.Factory.FromAsync(socket.BeginConnect(host, port, null, null), socket.EndConnect);
	}

	public static Task<int> ReceiveTaskAsync(this Socket socket, byte[] buffer, int offset, int count)
	{
		return Task.Factory.FromAsync(socket.BeginReceive(buffer, offset, socket.Available, SocketFlags.None, null, socket), (Func<IAsyncResult, int>)socket.EndReceive);
	}

	public static Task<int> ReceiveTaskAsync(this Socket socket, byte[] buffer)
	{
		return Task.Factory.FromAsync((Func<AsyncCallback, object, IAsyncResult>)((AsyncCallback cb, object s) => socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, cb, s)), (Func<IAsyncResult, int>)socket.EndReceive, (object)null);
	}

	public static Task<ReceiveInfo> ReceiveFromAsync(this Socket socket, byte[] buffer, int length, IPEndPoint endPoint, SocketFlags flags)
	{
		return Task.Factory.FromAsync((AsyncCallback cb, object s) =>
		{
			EndPoint remoteEP = new IPEndPoint(endPoint.Address, endPoint.Port);
			return socket.BeginReceiveMessageFrom(buffer, 0, length, flags, ref remoteEP, cb, s);
		}, (IAsyncResult result) =>
		{
			EndPoint endPoint2 = new IPEndPoint(endPoint.Address, endPoint.Port);
			SocketFlags socketFlags = flags;
			int length2 = socket.EndReceiveMessageFrom(result, ref socketFlags, ref endPoint2, out var ipPacketInformation);
			return new ReceiveInfo
			{
				Buffer = buffer,
				Length = length2,
				EndPoint = endPoint2,
				Flags = socketFlags,
				PacketInfo = ipPacketInformation
			};
		}, null);
	}

	public static Task SendTaskAsync(this Socket socket, byte[] buffer, int length = -1, SocketFlags flags = SocketFlags.None)
	{
		return Task.Factory.FromAsync(socket.BeginSend(buffer, 0, (length == -1) ? buffer.Length : length, flags, null, socket), (Func<IAsyncResult, int>)socket.EndSend);
	}

	public static Task SendToAsync(this Socket socket, IPEndPoint endPoint, byte[] buffer, int length = -1, SocketFlags flags = SocketFlags.None)
	{
		return Task.Factory.FromAsync(socket.BeginSendTo(buffer, 0, (length == -1) ? buffer.Length : length, flags, endPoint, null, socket), (Func<IAsyncResult, int>)socket.EndSendTo);
	}
}
