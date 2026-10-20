using System;
using System.IO;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerDeviceTypeAttribute : CogNamerNetworkDeviceAttribute
{
	private readonly CogNamerNetworkDeviceType _deviceType;

	public CogNamerNetworkDeviceType Type => _deviceType;

	public override string StringValue => $"Type: {_deviceType.ToString()}";

	internal CogNamerDeviceTypeAttribute(CogNamerNetworkDeviceType deviceType)
		: base(CogNamerAttributeType.DeviceType, new byte[2]
		{
			(byte)(((int)deviceType >> 8) & 0xFF),
			(byte)(deviceType & CogNamerNetworkDeviceType.SubtypeMask)
		})
	{
		_deviceType = deviceType;
	}

	internal CogNamerDeviceTypeAttribute(byte[] data)
		: base(CogNamerAttributeType.DeviceType, data)
	{
		BinaryReader br = new BinaryReader(new MemoryStream(data));
		int num = CogNamerPacket.ReadVarInt(br);
		int num2 = CogNamerPacket.ReadVarInt(br);
		_deviceType = (CogNamerNetworkDeviceType)((num << 8) | num2);
	}
}
