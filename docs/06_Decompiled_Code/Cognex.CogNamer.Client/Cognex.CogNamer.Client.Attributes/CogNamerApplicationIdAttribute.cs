using System;
using System.IO;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerApplicationIdAttribute : CogNamerNetworkDeviceAttribute
{
	public int ApplicationId
	{
		get
		{
			if (_data != null && _data.Length == 1)
			{
				using (MemoryStream input = new MemoryStream(_data))
				{
					using BinaryReader br = new BinaryReader(input);
					return CogNamerPacket.ReadVarInt(br);
				}
			}
			return 0;
		}
	}

	public bool IsInFailSafe => ApplicationId == 1;

	public override string StringValue => ApplicationId.ToString();

	internal CogNamerApplicationIdAttribute(byte[] data)
		: base(CogNamerAttributeType.ApplicationId, data)
	{
	}

	internal CogNamerApplicationIdAttribute(int id)
		: base(CogNamerAttributeType.ApplicationId, null)
	{
		if (id < 0)
		{
			throw new ArgumentException();
		}
		_data = BitConverter.GetBytes(id);
	}
}
