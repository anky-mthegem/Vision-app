using System;
using System.Threading;
using Cognex.CogNamer.Client.Attributes;

namespace Cognex.CogNamer.Client;

internal sealed class CogNamerResetToDefaultService : CogNamerServiceBase
{
	private readonly string _deviceAddress;

	private Exception _unhandledException;

	private CogNamerListener _listener;

	private CogNamerDevice _device;

	private bool _done;

	private readonly ManualResetEvent _ipConfigReceived = new ManualResetEvent(initialState: false);

	private readonly ManualResetEvent _cmdProcDone = new ManualResetEvent(initialState: false);

	private string _stateString = string.Empty;

	private readonly string _username;

	private readonly string _password;

	public CogNamerResetToDefaultService(string deviceAddress, string username, string password, ICogNamerNetworkMonitorNetworkInterface netInterface)
		: base(netInterface)
	{
		_deviceAddress = deviceAddress;
		_username = username;
		_password = password;
	}

	private void Dispose()
	{
		_done = true;
		_cmdProcDone.WaitOne();
		if (_listener != null)
		{
			_listener.Dispose();
		}
		_ipConfigReceived.Close();
		_cmdProcDone.Close();
	}

	public void ResetToDefaults(ManualResetEvent stopEvt, Action<string> statusCallBack)
	{
		try
		{
			_stateString = "Initializing...";
			statusCallBack?.Invoke(_stateString);
			_listener = new CogNamerListener(_netInterface);
			_listener.DiscoverMisconfiguredDevices = true;
			_listener.PacketReceived += HandleCogNamerPacket;
			if (_device == null)
			{
				_device = _listener.Resolve(_deviceAddress);
				if (_device == null)
				{
					throw new ApplicationException($"Couldn't resolve host '{_deviceAddress}'");
				}
			}
			_stateString = "Please manually cycle power...";
			statusCallBack?.Invoke(_stateString);
			while (!_ipConfigReceived.WaitOne(500, exitContext: false))
			{
				if (_done)
				{
					_cmdProcDone.Set();
					return;
				}
			}
			_stateString = "Resetting device settings...";
			statusCallBack?.Invoke(_stateString);
			try
			{
				_listener.SendSetNetwork(_device, _username, _password, _device.HostName, _device.IsDhcpEnabled, _device.IPAddress, _device.SubnetMask, _device.DefaultGateway, _device.DnsServer, _device.DomainName, reset: true);
				_stateString = "Done";
				statusCallBack?.Invoke(_stateString);
			}
			catch (Exception unhandledException)
			{
				_stateString = (_unhandledException = unhandledException).Message;
			}
			finally
			{
				_done = true;
			}
		}
		catch (Exception unhandledException2)
		{
			_unhandledException = unhandledException2;
			_cmdProcDone.Set();
		}
	}

	private void HandleCogNamerPacket(object sender, CogNamerPacketEventArgs e)
	{
		if (!_done && e.Command == CogNamerCommand.IPRequest && e.Device.MacAddressLong == _device.MacAddressLong)
		{
			_ipConfigReceived.Set();
		}
	}
}
