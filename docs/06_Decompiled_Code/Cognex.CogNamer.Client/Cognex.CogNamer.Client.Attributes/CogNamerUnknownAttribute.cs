using System;
using System.Text;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerUnknownAttribute : CogNamerNetworkDeviceAttribute
{
	public override string StringValue
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Unknown attribute type {0}: ", AttributeType);
			stringBuilder.Append("0x");
			byte[] data = _data;
			foreach (byte b in data)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}
	}

	public CogNamerUnknownAttribute(CogNamerAttributeType type, byte[] data)
		: base(type, data)
	{
	}
}
