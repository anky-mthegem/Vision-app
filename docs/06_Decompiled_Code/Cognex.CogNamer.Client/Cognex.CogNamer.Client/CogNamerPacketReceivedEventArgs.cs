using System;
using System.Net;

namespace Cognex.CogNamer.Client;

[CoverageExclude]
public class CogNamerPacketReceivedEventArgs : EventArgs, ICogNamerPacketReceivedEventArgs
{
	private byte[] _buffer;

	private int _length;

	private IPEndPoint _endpoint;

	private IPAddress _localIP;

	private bool _handled;

	public byte[] Data
	{
		get
		{
			return _buffer;
		}
		set
		{
			_buffer = value;
		}
	}

	public int Length
	{
		get
		{
			return _length;
		}
		set
		{
			_length = value;
		}
	}

	public IPEndPoint IPEndPoint
	{
		get
		{
			return _endpoint;
		}
		set
		{
			_endpoint = value;
		}
	}

	public IPAddress LocalIP
	{
		get
		{
			return _localIP;
		}
		set
		{
			_localIP = value;
		}
	}

	public bool Handled
	{
		get
		{
			return _handled;
		}
		set
		{
			_handled = value;
		}
	}

	public CogNamerPacketReceivedEventArgs(byte[] buffer, int length, IPEndPoint endpoint, IPAddress localIP)
	{
		_buffer = buffer;
		_length = length;
		_endpoint = endpoint;
		_localIP = localIP;
	}

	public bool IsPacketLocal(IPAddress deviceNetMask)
	{
		if (_localIP.Equals(IPAddress.Any) || IPAddress.IsLoopback(_localIP))
		{
			return true;
		}
		int num = BitConverter.ToInt32(IPEndPoint.Address.GetAddressBytes(), 0);
		int num2 = BitConverter.ToInt32(_localIP.GetAddressBytes(), 0);
		int num3 = BitConverter.ToInt32(deviceNetMask.GetAddressBytes(), 0);
		int num4 = BitConverter.ToInt32(deviceNetMask.GetAddressBytes(), 0);
		if (num4 == 0)
		{
			num4 = num3;
		}
		return (num & num4) == (num2 & num3);
	}
}
