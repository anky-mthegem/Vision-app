using System;
using System.Globalization;
using System.Text;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerMacAddressAttribute : CogNamerNetworkDeviceAttribute
{
	private readonly long _macAddress;

	public override string StringValue => Format(_macAddress);

	public long MacAddress => _macAddress;

	internal CogNamerMacAddressAttribute(long macAddress)
		: base(CogNamerAttributeType.MacAddress, null)
	{
		_macAddress = macAddress;
		_data = new byte[6];
		for (int i = 0; i < 6; i++)
		{
			_data[i] = (byte)(macAddress & 0xFF);
			macAddress >>= 8;
		}
	}

	internal CogNamerMacAddressAttribute(byte[] buffer)
		: base(CogNamerAttributeType.MacAddress, buffer)
	{
		long num = 0L;
		for (int i = 0; i < 6; i++)
		{
			num = (num << 8) | buffer[i];
		}
		_macAddress = num;
	}

	public static string Format(long macAddress)
	{
		StringBuilder stringBuilder = new StringBuilder(32);
		for (int i = 0; i < 6; i++)
		{
			if (i > 0)
			{
				stringBuilder.Insert(0, new char[1] { '-' });
			}
			stringBuilder.Insert(0, string.Format(CultureInfo.InvariantCulture, "{0:x2}", new object[1] { macAddress & 0xFF }));
			macAddress >>= 8;
		}
		return stringBuilder.ToString();
	}
}
