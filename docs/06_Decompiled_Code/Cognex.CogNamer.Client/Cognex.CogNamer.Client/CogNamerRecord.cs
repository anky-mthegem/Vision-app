using System;
using System.IO;
using System.Text;
using Cognex.CogNamer.Client.Attributes;

namespace Cognex.CogNamer.Client;

[Serializable]
public class CogNamerRecord
{
	private readonly CogNamerAttributeType _type;

	private readonly byte[] _data;

	public bool IsAttributeRecord => _type >= CogNamerAttributeType.DeviceType;

	public CogNamerAttributeType RecordType => _type;

	public byte[] Data => _data;

	public int Length => _data.Length;

	public CogNamerRecord(CogNamerAttributeType type, byte[] data)
	{
		_type = type;
		_data = data;
	}

	public CogNamerRecord(CogNamerAttributeType type, string data)
	{
		_type = type;
		_data = Encoding.UTF8.GetBytes(data);
	}

	public string GetString()
	{
		return Encoding.UTF8.GetString(_data, 0, _data.Length);
	}

	public void Write(BinaryWriter bw)
	{
		CogNamerPacket.WriteVarInt(bw, (int)_type);
		CogNamerPacket.WriteVarInt(bw, _data.Length);
		bw.Write(_data);
	}
}
