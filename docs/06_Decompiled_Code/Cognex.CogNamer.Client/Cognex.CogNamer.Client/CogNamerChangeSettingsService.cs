using System;
using System.Net;
using System.Threading;
using Cognex.CogNamer.Client.Common;

namespace Cognex.CogNamer.Client;

public sealed class CogNamerChangeSettingsService : CogNamerServiceBase
{
	private readonly string _address;

	private CogNamerListener _listener;

	private ICogNamerEthernetSettings _newSettings;

	private readonly string _username;

	private readonly string _password;

	public CogNamerChangeSettingsService(string hostName, string username, string password, ICogNamerNetworkMonitorNetworkInterface netInterface)
		: base(netInterface)
	{
		_address = hostName;
		_username = username;
		_password = password;
	}

	public void Change(ICogNamerEthernetSettings settings, ManualResetEvent stopEvt, Action<string> StatusCallBack)
	{
		_newSettings = settings;
		try
		{
			ManualResetEvent manualResetEvent = stopEvt;
			if (manualResetEvent == null)
			{
				manualResetEvent = new ManualResetEvent(initialState: false);
			}
			_listener = new CogNamerListener(_netInterface);
			_listener.DiscoverMisconfiguredDevices = true;
			CogNamerDevice cogNamerDevice = _listener.Resolve(_address);
			if (cogNamerDevice == null && !manualResetEvent.WaitOne(0, exitContext: false))
			{
				_listener.Refresh();
				if (manualResetEvent.WaitOne(3000, exitContext: false))
				{
					throw new ApplicationException(Strings.CouldNotResolveHost);
				}
				cogNamerDevice = _listener.Resolve(_address);
			}
			if (cogNamerDevice == null)
			{
				throw new ApplicationException(string.Format(Strings.CouldNotResolveHost, _address));
			}
			if (!manualResetEvent.WaitOne(0, exitContext: false))
			{
				StatusCallBack?.Invoke(Strings.ChangingNetworkSettings);
				_listener.SendSetNetwork(cogNamerDevice, _username, _password, _newSettings.HostName, _newSettings.Dhcp, IPAddress.Parse(_newSettings.IpAddress), IPAddress.Parse(_newSettings.SubMask), IPAddress.Parse(_newSettings.Gateway), IPAddress.Parse(_newSettings.PrimaryDNS), _newSettings.DomainName, reset: false);
				manualResetEvent.WaitOne(3000, exitContext: false);
			}
			if (manualResetEvent.WaitOne(0, exitContext: false))
			{
				return;
			}
			StatusCallBack?.Invoke(Strings.AttemptingToContact);
			_listener.Refresh();
			for (int i = 0; i < 3; i++)
			{
				cogNamerDevice = _listener.Resolve(_newSettings.HostName);
				if (cogNamerDevice != null)
				{
					break;
				}
			}
			StatusCallBack?.Invoke(Strings.CompletedSuccessfully);
		}
		finally
		{
			_listener.Dispose();
		}
	}
}
