using System;
using System.IO;
using System.Text;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerStringAttribute : CogNamerNetworkDeviceAttribute
{
	private readonly string _value;

	public override string StringValue => _value;

	internal CogNamerStringAttribute(CogNamerAttributeType programmaticName, string value)
		: base(programmaticName, null)
	{
		_value = value;
		MemoryStream memoryStream = new MemoryStream(value.Length);
		byte[] bytes = Encoding.UTF8.GetBytes(value);
		memoryStream.Write(bytes, 0, bytes.Length);
		_data = memoryStream.ToArray();
	}

	internal CogNamerStringAttribute(CogNamerAttributeType programmaticName, byte[] data)
		: base(programmaticName, data)
	{
		_value = CogNamerPacket.ReadString(new BinaryReader(new MemoryStream(data)), data.Length);
	}

	public override bool Equals(object obj)
	{
		if (obj is CogNamerStringAttribute)
		{
			CogNamerStringAttribute cogNamerStringAttribute = (CogNamerStringAttribute)obj;
			if (AttributeType != cogNamerStringAttribute.AttributeType)
			{
				return false;
			}
			if (AttributeType == CogNamerAttributeType.HostName || AttributeType == CogNamerAttributeType.GroupName)
			{
				return _value.Equals(cogNamerStringAttribute._value, StringComparison.CurrentCultureIgnoreCase);
			}
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		if (AttributeType == CogNamerAttributeType.HostName || AttributeType == CogNamerAttributeType.GroupName)
		{
			return _value.ToLower().GetHashCode() ^ AttributeType.GetHashCode();
		}
		return base.GetHashCode();
	}
}
