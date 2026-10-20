using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Cognex.CogNamer.Client;

public class CogNamerNetworkAdapter : ICogNamerNetworkAdapter
{
	private static bool _useCache = false;

	private static List<CogNamerNetworkAdapter> _cogNamerNetworkAdapterCache = null;

	private static object _cacheLock = new object();

	public long Index { get; private set; }

	public IPAddress IP { get; private set; }

	public IPAddress SubnetMask { get; private set; }

	public IPAddress SubnetBroadcast { get; private set; }

	public bool IsLoopback => IP.Equals(IPAddress.Loopback);

	public static bool UseCache
	{
		get
		{
			return _useCache;
		}
		set
		{
			if (_useCache != value)
			{
				_useCache = value;
				if (!_useCache)
				{
					FlushAdapterCache();
				}
			}
		}
	}

	private CogNamerNetworkAdapter(long index, IPAddress ip, IPAddress subnetMask)
	{
		Index = index;
		IP = ip;
		SubnetMask = subnetMask;
		byte[] addressBytes = ip.GetAddressBytes();
		byte[] addressBytes2 = subnetMask.GetAddressBytes();
		long num = 0L;
		for (int i = 0; i < addressBytes.Length; i++)
		{
			int num2 = (addressBytes[i] & addressBytes2[i]) | ~addressBytes2[i];
			num |= (uint)((num2 & 0xFF) << i * 8);
		}
		SubnetBroadcast = new IPAddress(num);
	}

	public static CogNamerNetworkAdapter[] GetAllNetworkAdapters()
	{
		return GetNetworkAdaptersWhere((ICogNamerNetworkAdapter _) => true);
	}

	public static CogNamerNetworkAdapter[] GetNetworkAdaptersWhere(Func<ICogNamerNetworkAdapter, bool> adapterPredicate)
	{
		List<CogNamerNetworkAdapter> list = null;
		if (UseCache)
		{
			lock (_cacheLock)
			{
				if (_cogNamerNetworkAdapterCache != null)
				{
					list = new List<CogNamerNetworkAdapter>(_cogNamerNetworkAdapterCache);
				}
			}
		}
		if (list == null)
		{
			list = new List<CogNamerNetworkAdapter>();
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.OperationalStatus != OperationalStatus.Up)
				{
					continue;
				}
				foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
				{
					if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						CogNamerNetworkAdapter cogNamerNetworkAdapter = new CogNamerNetworkAdapter(networkInterface.GetIPProperties().GetIPv4Properties().Index, unicastAddress.Address, unicastAddress.IPv4Mask);
						if (adapterPredicate(cogNamerNetworkAdapter))
						{
							list.Add(cogNamerNetworkAdapter);
						}
					}
				}
			}
			if (UseCache)
			{
				lock (_cacheLock)
				{
					_cogNamerNetworkAdapterCache = list;
				}
			}
		}
		return list.ToArray();
	}

	public static void FlushAdapterCache()
	{
		lock (_cacheLock)
		{
			if (_cogNamerNetworkAdapterCache != null)
			{
				_cogNamerNetworkAdapterCache.Clear();
			}
			_cogNamerNetworkAdapterCache = null;
		}
	}

	public bool IsInSubnet(IPAddress ip)
	{
		bool result = false;
		if (ip.AddressFamily == AddressFamily.InterNetwork)
		{
			result = true;
			byte[] addressBytes = IP.GetAddressBytes();
			byte[] addressBytes2 = SubnetMask.GetAddressBytes();
			byte[] addressBytes3 = ip.GetAddressBytes();
			for (int i = 0; i < 4; i++)
			{
				if ((addressBytes[i] & addressBytes2[i]) != (addressBytes3[i] & addressBytes2[i]))
				{
					result = false;
					break;
				}
			}
		}
		return result;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is CogNamerNetworkAdapter cogNamerNetworkAdapter))
		{
			return false;
		}
		if (Index == cogNamerNetworkAdapter.Index && IP.Equals(cogNamerNetworkAdapter.IP))
		{
			return SubnetMask.Equals(cogNamerNetworkAdapter.SubnetMask);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return IP.GetHashCode() ^ SubnetMask.GetHashCode() ^ Index.GetHashCode();
	}
}
