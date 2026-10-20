using System;
using System.Threading;
using Cognex.CogNamer.Client.Attributes;

namespace Cognex.CogNamer.Client;

internal sealed class CogNamerResetPasswordService : CogNamerServiceBase
{
	private readonly string _deviceAddress;

	private Exception _unhandledException;

	private CogNamerListener _listener;

	private CogNamerDevice _device;

	private bool _done;

	private readonly ManualResetEvent _ipConfigReceived = new ManualResetEvent(initialState: false);

	private readonly ManualResetEvent _cmdProcDone = new ManualResetEvent(initialState: false);

	private string _stateString = string.Empty;

	public bool Success => _unhandledException == null;

	public Exception Exception => _unhandledException;

	public CogNamerResetPasswordService(string deviceAddress, ICogNamerNetworkMonitorNetworkInterface netInterface)
		: base(netInterface)
	{
		_deviceAddress = deviceAddress;
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

	public void ResetPassword(ManualResetEvent stopEvt, Action<string, int> statusCallBack)
	{
		try
		{
			_stateString = "Initializing...";
			statusCallBack?.Invoke(_stateString, 0);
			_listener = new CogNamerListener(_netInterface);
			_listener.DiscoverMisconfiguredDevices = true;
			_listener.PacketReceived += HandleCogNamerPacket;
			_stateString = "Please manually cycle power...";
			statusCallBack?.Invoke(_stateString, 10);
			while (!_ipConfigReceived.WaitOne(200, exitContext: false))
			{
				if (_done)
				{
					_cmdProcDone.Set();
					return;
				}
				if (stopEvt.WaitOne(1, exitContext: false))
				{
					_done = true;
				}
			}
			_stateString = "Resetting device settings...";
			statusCallBack?.Invoke(_stateString, 70);
			try
			{
				_listener.SendResetAdminPassword(_device);
				_stateString = "Done";
				statusCallBack?.Invoke(_stateString, 100);
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
		if (!_done && e.Command == CogNamerCommand.IPRequest && e.Device.MacAddress == _deviceAddress)
		{
			_device = e.Device;
			_ipConfigReceived.Set();
		}
	}
}
