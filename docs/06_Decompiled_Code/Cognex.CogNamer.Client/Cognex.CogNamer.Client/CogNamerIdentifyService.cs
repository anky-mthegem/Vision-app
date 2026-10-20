using System;
using System.Threading;

namespace Cognex.CogNamer.Client;

public sealed class CogNamerIdentifyService : CogNamerServiceBase
{
	private readonly string _address;

	private TimeSpan _duration;

	public CogNamerIdentifyService(string hostName, ICogNamerNetworkMonitorNetworkInterface netInterface)
		: base(netInterface)
	{
		_address = hostName;
	}

	public void Identify(TimeSpan duration, ManualResetEvent stopEvt)
	{
		_duration = duration;
		CogNamerDevice cogNamerDevice = null;
		using CogNamerListener cogNamerListener = new CogNamerListener(_netInterface);
		cogNamerListener.DiscoverMisconfiguredDevices = true;
		cogNamerDevice = cogNamerListener.Resolve(_address);
		if (cogNamerDevice == null)
		{
			throw new ApplicationException(string.Format("Strings.CouldNotResolveHost", _address));
		}
		TimeSpan timeSpan = _duration;
		while (timeSpan.TotalMilliseconds > 0.0)
		{
			int tickCount = Environment.TickCount;
			cogNamerListener.SendFlash(cogNamerDevice);
			int num = Environment.TickCount - tickCount;
			int num2 = 2000 - num;
			if (num2 < 1)
			{
				num2 = 1;
			}
			else if (num2 > 2000)
			{
				num2 = 2000;
			}
			while (num2 > 0)
			{
				if (stopEvt.WaitOne(100, exitContext: true))
				{
					timeSpan = TimeSpan.Zero;
				}
				num2 -= 100;
			}
			timeSpan.Subtract(TimeSpan.FromMilliseconds(num + num2));
		}
	}
}
