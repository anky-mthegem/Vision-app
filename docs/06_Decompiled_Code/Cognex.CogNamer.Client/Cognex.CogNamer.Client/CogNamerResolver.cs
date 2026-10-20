using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace Cognex.CogNamer.Client;

public static class CogNamerResolver
{
	public static Task<CogNamerDevice> ResolveAsync(IPAddress dstIp, CancellationToken cancel = default(CancellationToken))
	{
		return CogNamerListener.ResolveDeviceAsync(dstIp, cancel);
	}

	public static CogNamerDevice Resolve(IPAddress dstIp)
	{
		return CogNamerListener.ResolveDevice(dstIp);
	}

	public static Task<CogNamerDevice> ResolveAsync(string name, CancellationToken cancel = default(CancellationToken))
	{
		return CogNamerListener.ResolveDeviceAsync(name, cancel);
	}

	public static CogNamerDevice Resolve(string name)
	{
		return CogNamerListener.ResolveDevice(name);
	}

	public static Task<CogNamerDevice> ResolveAsync(string macId, bool broadcast, CancellationToken cancel = default(CancellationToken))
	{
		return CogNamerListener.ResolveDeviceAsync(PhysicalAddress.Parse(macId.ToUpperInvariant()), broadcast, cancel);
	}

	public static CogNamerDevice Resolve(string macId, bool broadcast)
	{
		return CogNamerListener.ResolveDevice(PhysicalAddress.Parse(macId.ToUpperInvariant()), broadcast);
	}
}
