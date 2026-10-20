namespace Cognex.CogNamer.Client;

public abstract class CogNamerServiceBase
{
	protected ICogNamerNetworkMonitorNetworkInterface _netInterface;

	protected CogNamerServiceBase(ICogNamerNetworkMonitorNetworkInterface netInterface)
	{
		_netInterface = netInterface;
	}
}
