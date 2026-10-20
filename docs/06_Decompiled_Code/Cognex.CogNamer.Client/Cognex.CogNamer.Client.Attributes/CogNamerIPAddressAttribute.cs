using System;
using System.Net;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerIPAddressAttribute : CogNamerNetworkDeviceAttribute
{
	public IPAddress IPAddress => new IPAddress(((_data[0] << 24) | (_data[1] << 16) | (_data[2] << 8) | _data[3]) & 0xFFFFFFFFu);

	public override string StringValue => IPAddress.ToString();

	internal CogNamerIPAddressAttribute(byte[] data)
		: base(CogNamerAttributeType.IpAddress, data)
	{
	}

	internal CogNamerIPAddressAttribute(IPAddress ip)
		: base(CogNamerAttributeType.IpAddress, null)
	{
		byte[] addressBytes = ip.GetAddressBytes();
		Array.Reverse(addressBytes);
		_data = addressBytes;
	}
}
