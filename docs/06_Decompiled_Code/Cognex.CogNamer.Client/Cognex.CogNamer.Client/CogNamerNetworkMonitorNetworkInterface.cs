#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace Cognex.CogNamer.Client;

public class CogNamerNetworkMonitorNetworkInterface : IDisposable, ICogNamerNetworkMonitorNetworkInterface
{
	private class AdapterSocket
	{
		public readonly CogNamerNetworkAdapter Adapter;

		public readonly Socket Socket;

		public AdapterSocket(CogNamerNetworkAdapter adapter, Socket socket)
		{
			Adapter = adapter;
			Socket = socket;
		}
	}

	private static readonly TraceSwitch mSwitch = new TraceSwitch("CogNamerNetworkMonitor", "Trace Level");

	private readonly List<AdapterSocket> _sockets = new List<AdapterSocket>();

	private readonly List<AdapterSocket> _shutdownSockets = new List<AdapterSocket>();

	private readonly Func<ICogNamerNetworkAdapter, bool> _adapterPredicate;

	private Socket _defaultSocket;

	private Socket _broadcastSocket;

	private const int NamerPort = 1069;

	private const int RecvPacketSize = 8196;

	private const int RecvBufferSize = 130000;

	public byte[] ReceiveBuffer = new byte[8196];

	private Thread _recvThread;

	private bool _recvThreadIsAlive;

	private bool _running;

	private bool _started;

	private bool _disposed;

	private bool _receiveMessageFromSupported = true;

	private bool _networkChangedNotify;

	private List<CogNamerNetworkAdapter> _netInterfaces = new List<CogNamerNetworkAdapter>();

	public bool IsRunning
	{
		get
		{
			if (_running)
			{
				return _recvThreadIsAlive;
			}
			return false;
		}
	}

	public event CogNamerPacketReceivedEventHandler PacketReceived;

	public event EventHandler NetworkChanged;

	public CogNamerNetworkMonitorNetworkInterface()
		: this(null)
	{
	}

	public CogNamerNetworkMonitorNetworkInterface(Func<ICogNamerNetworkAdapter, bool> adapterPredicate)
	{
		_adapterPredicate = adapterPredicate;
		_receiveMessageFromSupported = Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.CompareTo(new Version(5, 1)) >= 0;
		NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
		CreateBroadcastReceiveSocket();
		BindDefaultSendSocket();
		BindSendSockets();
	}

	private void BindSendSockets()
	{
		lock (this)
		{
			if (_disposed)
			{
				return;
			}
			if (CogNamerNetworkAdapter.UseCache)
			{
				CogNamerNetworkAdapter.FlushAdapterCache();
			}
			CogNamerNetworkAdapter[] array = ((_adapterPredicate == null) ? CogNamerNetworkAdapter.GetAllNetworkAdapters() : CogNamerNetworkAdapter.GetNetworkAdaptersWhere(_adapterPredicate));
			List<CogNamerNetworkAdapter> list = new List<CogNamerNetworkAdapter>();
			List<CogNamerNetworkAdapter> list2 = new List<CogNamerNetworkAdapter>();
			CogNamerNetworkAdapter[] array2 = array;
			foreach (CogNamerNetworkAdapter item in array2)
			{
				list2.Add(item);
				list.Add(item);
			}
			AdapterSocket[] array3 = _sockets.ToArray();
			foreach (AdapterSocket adapterSocket in array3)
			{
				IPAddress obj = IPAddress.Any;
				try
				{
					obj = ((IPEndPoint)adapterSocket.Socket.LocalEndPoint).Address;
				}
				catch (SocketException)
				{
				}
				bool flag = false;
				foreach (CogNamerNetworkAdapter item2 in list)
				{
					if (item2.IP.Equals(obj))
					{
						list.Remove(item2);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					adapterSocket.Socket.Shutdown(SocketShutdown.Both);
					_shutdownSockets.Add(adapterSocket);
					_sockets.Remove(adapterSocket);
					_networkChangedNotify = true;
				}
			}
			foreach (CogNamerNetworkAdapter item3 in list)
			{
				BindSendSocket(item3);
				_networkChangedNotify = true;
			}
			_netInterfaces = list2;
		}
	}

	private void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
	{
		for (int i = 0; i < 3; i++)
		{
			try
			{
				BindSendSockets();
				break;
			}
			catch (CogNamerCommunicationException)
			{
				Thread.Sleep(100);
			}
			catch (Exception ex2)
			{
				if (mSwitch.TraceError)
				{
					Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Unexcepted error NetworkChange_NetworkAddressChanged: {0}", new object[1] { ex2.Message }));
				}
				break;
			}
		}
	}

	private void BindSendSocket(CogNamerNetworkAdapter localIp)
	{
		Socket socket = null;
		try
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, 130000);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
			if (_receiveMessageFromSupported)
			{
				socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, 1);
			}
			socket.Bind(new IPEndPoint(localIp.IP, 0));
			DisableUdpConnReset(socket);
			_sockets.Add(new AdapterSocket(localIp, socket));
		}
		catch (SocketException ex)
		{
			if (mSwitch.TraceError)
			{
				Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Unable to bind socket: {0}", new object[1] { ex.Message }));
			}
			socket?.Close();
		}
	}

	private void BindDefaultSendSocket()
	{
		Socket socket = null;
		try
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, 130000);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
			if (_receiveMessageFromSupported)
			{
				socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, 1);
			}
			socket.Bind(new IPEndPoint(IPAddress.Any, 0));
			DisableUdpConnReset(socket);
			_defaultSocket = socket;
		}
		catch (SocketException ex)
		{
			if (mSwitch.TraceError)
			{
				Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Unable to bind in socket: {0}", new object[1] { ex.Message }));
			}
			socket?.Close();
			throw new CogNamerCommunicationException(ex);
		}
	}

	private void CreateBroadcastReceiveSocket()
	{
		try
		{
			_broadcastSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			_broadcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, 0);
			_broadcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, 130000);
			_broadcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
			_broadcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
			_broadcastSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, 1);
			_broadcastSocket.Bind(new IPEndPoint(IPAddress.Any, 1069));
			DisableUdpConnReset(_broadcastSocket);
		}
		catch (SocketException ex)
		{
			if (mSwitch.TraceError)
			{
				Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Unable to bind in socket: {0}", new object[1] { ex.Message }));
			}
			if (_broadcastSocket != null)
			{
				_broadcastSocket.Close();
				_broadcastSocket = null;
			}
		}
	}

	public void DisableUdpConnReset(Socket socket)
	{
		byte[] optionInValue = new byte[1] { Convert.ToByte(value: false) };
		byte[] optionOutValue = new byte[0];
		socket.IOControl(-1744830452, optionInValue, optionOutValue);
	}

	public void Start()
	{
		_recvThread = new Thread(Run);
		_running = true;
		_recvThread.IsBackground = true;
		_recvThreadIsAlive = true;
		_recvThread.Start();
		for (int i = 0; i < 300; i++)
		{
			Thread.Sleep(10);
			if (_started)
			{
				break;
			}
		}
	}

	public void Dispose()
	{
		_disposed = true;
		if (_running)
		{
			Stop();
		}
		NetworkChange.NetworkAddressChanged -= NetworkChange_NetworkAddressChanged;
		lock (this)
		{
			foreach (AdapterSocket socket in _sockets)
			{
				socket.Socket.Close();
			}
			_sockets.Clear();
			foreach (AdapterSocket shutdownSocket in _shutdownSockets)
			{
				shutdownSocket.Socket.Close();
			}
			_shutdownSockets.Clear();
		}
		if (_broadcastSocket != null)
		{
			_broadcastSocket.Close();
		}
		if (_defaultSocket != null)
		{
			_defaultSocket.Close();
		}
	}

	public void Stop()
	{
		_running = false;
		foreach (AdapterSocket socket in _sockets)
		{
			try
			{
				socket.Socket.Shutdown(SocketShutdown.Both);
			}
			catch
			{
			}
		}
		if (_broadcastSocket != null)
		{
			try
			{
				_broadcastSocket.Shutdown(SocketShutdown.Both);
			}
			catch
			{
			}
		}
		_recvThread.Join(3000);
	}

	private void Run()
	{
		try
		{
			_started = true;
			int capacity = _sockets.Count + 1;
			List<Socket> list = new List<Socket>(capacity);
			List<Socket> list2 = new List<Socket>(capacity);
			byte[] array = new byte[8196];
			EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
			int num = 0;
			while (_running)
			{
				list.Clear();
				if (_networkChangedNotify)
				{
					_networkChangedNotify = false;
					if (NetworkChanged != null)
					{
						NetworkChanged(this, new EventArgs());
					}
				}
				lock (this)
				{
					foreach (AdapterSocket shutdownSocket in _shutdownSockets)
					{
						shutdownSocket.Socket.Close();
					}
					_shutdownSockets.Clear();
					foreach (AdapterSocket socket in _sockets)
					{
						list.Add(socket.Socket);
					}
				}
				if (_broadcastSocket != null)
				{
					list.Add(_broadcastSocket);
				}
				if (_defaultSocket != null)
				{
					list.Add(_defaultSocket);
				}
				list2.Clear();
				list2.AddRange(list);
				Socket.Select(list, null, list2, 1000000);
				int num2 = 0;
				while (_running && num2 < list.Count)
				{
					while (_running && list[num2].Available > 0)
					{
						if (_receiveMessageFromSupported)
						{
							try
							{
								SocketFlags socketFlags = SocketFlags.None;
								num = list[num2].ReceiveMessageFrom(array, 0, array.Length, ref socketFlags, ref remoteEP, out var ipPacketInformation);
								if (PacketReceived != null)
								{
									CogNamerNetworkAdapter networkInterface = GetNetworkInterface(ipPacketInformation.Interface);
									IPAddress localIP = ((networkInterface != null) ? networkInterface.IP : IPAddress.Any);
									PacketReceived(this, new CogNamerPacketReceivedEventArgs(array, num, remoteEP as IPEndPoint, localIP));
								}
							}
							catch (PlatformNotSupportedException)
							{
								_receiveMessageFromSupported = false;
							}
						}
						else
						{
							num = list[num2].ReceiveFrom(array, ref remoteEP);
							if (PacketReceived != null)
							{
								PacketReceived(this, new CogNamerPacketReceivedEventArgs(array, num, remoteEP as IPEndPoint, IPAddress.Any));
							}
						}
					}
					num2++;
				}
			}
		}
		catch (SocketException ex2)
		{
			_ = _running;
			CogNamerTrace.WriteLineIf(mSwitch.TraceWarning, "CvsNetworkMonitor: ReceivePacket - WARNING - UNEXPECTED ERROR! " + ex2.Message);
		}
		catch (ObjectDisposedException ex3)
		{
			_ = _running;
			CogNamerTrace.WriteLineIf(mSwitch.TraceWarning, "CvsNetworkMonitor: Receive Socket Closed" + ex3.Message);
		}
		catch (Exception)
		{
		}
		finally
		{
			_recvThreadIsAlive = false;
		}
	}

	private CogNamerNetworkAdapter GetNetworkInterface(int index)
	{
		foreach (CogNamerNetworkAdapter netInterface in _netInterfaces)
		{
			if (netInterface.Index == index)
			{
				return netInterface;
			}
		}
		return null;
	}

	public void ClearCachedInterfaceInfo()
	{
		lock (_netInterfaces)
		{
			try
			{
				BindSendSockets();
			}
			catch (CogNamerCommunicationException ex)
			{
				if (mSwitch.TraceWarning)
				{
					Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Unexcepted error ClearCachedInterfaceInfo: {0}", new object[1] { ex.Message }));
				}
			}
		}
	}

	public bool WaitForReceivedPackets(int timeout)
	{
		_recvThread.Priority = ThreadPriority.AboveNormal;
		Trace.WriteLineIf(mSwitch.TraceInfo, "WaitForReceivedPackets");
		bool flag = false;
		while (timeout > 0 && !flag)
		{
			flag = true;
			if (_broadcastSocket != null && _broadcastSocket.Available > 0)
			{
				Trace.WriteLineIf(mSwitch.TraceInfo, "WaitForReceivedPackets: Broadcast Available = " + _broadcastSocket.Available);
				flag = false;
			}
			lock (this)
			{
				foreach (AdapterSocket socket in _sockets)
				{
					if (socket.Socket.Available > 0)
					{
						Trace.WriteLineIf(mSwitch.TraceInfo, $"WaitForReceivedPackets: Socket{socket} Available = {socket.Socket.Available}");
						flag = false;
						break;
					}
				}
			}
			Trace.WriteLineIf(mSwitch.TraceInfo, "WaitForReceivedPackets");
			Thread.Sleep(100);
			timeout -= 100;
		}
		_recvThread.Priority = ThreadPriority.Normal;
		return flag;
	}

	public void SendPacket(byte[] packet, int len, IPEndPoint dest)
	{
		lock (this)
		{
			if (dest.Address.Equals(IPAddress.Broadcast))
			{
				foreach (AdapterSocket socket2 in _sockets)
				{
					socket2.Socket.SendTo(packet, len, SocketFlags.None, socket2.Adapter.IP.Equals(IPAddress.Loopback) ? new IPEndPoint(socket2.Adapter.SubnetBroadcast, dest.Port) : dest);
				}
				return;
			}
			CogNamerNetworkAdapter cogNamerNetworkAdapter = null;
			foreach (CogNamerNetworkAdapter netInterface in _netInterfaces)
			{
				if (netInterface.IsInSubnet(dest.Address))
				{
					cogNamerNetworkAdapter = netInterface;
					break;
				}
			}
			Socket socket = null;
			if (cogNamerNetworkAdapter != null)
			{
				foreach (AdapterSocket socket3 in _sockets)
				{
					if (((IPEndPoint)socket3.Socket.LocalEndPoint).Address.Equals(cogNamerNetworkAdapter.IP))
					{
						socket = socket3.Socket;
						break;
					}
					if (cogNamerNetworkAdapter.IsLoopback)
					{
						dest = new IPEndPoint(cogNamerNetworkAdapter.SubnetBroadcast, dest.Port);
					}
					if (socket == null)
					{
						socket = socket3.Socket;
					}
				}
			}
			else
			{
				socket = _defaultSocket;
			}
			socket.SendTo(packet, len, SocketFlags.None, dest);
		}
	}

	public void SendSubnetBroadcast(byte[] packet, int len)
	{
		lock (this)
		{
			foreach (AdapterSocket socket in _sockets)
			{
				socket.Socket.SendTo(packet, len, SocketFlags.None, new IPEndPoint(socket.Adapter.SubnetBroadcast, 1069));
			}
		}
	}
}
