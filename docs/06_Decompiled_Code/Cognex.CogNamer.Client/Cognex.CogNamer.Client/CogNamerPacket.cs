using System.IO;
using System.Net;
using System.Text;

namespace Cognex.CogNamer.Client;

public class CogNamerPacket
{
	private const int AVNAMER_PROTO_VERSION = 4;

	private const int AVNAMER_MAGIC = 1296975683;

	private readonly byte[] _buffer;

	public CogNamerPacket()
	{
	}

	public CogNamerPacket(int command, byte flags, int errorCode, CogNamerRecordList records)
	{
		int num = 0;
		if (records != null)
		{
			for (int i = 0; i < records.Count; i++)
			{
				int length = records[i].Length;
				num += 1 + GetVarIntLen(length) + length;
			}
		}
		int num2 = 6 + GetVarIntLen(command) + GetVarIntLen(errorCode) + GetVarIntLen(num) + num;
		_buffer = new byte[num2];
		BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream(_buffer));
		binaryWriter.Write(1296975683);
		binaryWriter.Write((byte)4);
		binaryWriter.Write(flags);
		WriteVarInt(binaryWriter, command);
		WriteVarInt(binaryWriter, errorCode);
		WriteVarInt(binaryWriter, num);
		if (records != null)
		{
			for (int j = 0; j < records.Count; j++)
			{
				records[j].Write(binaryWriter);
			}
		}
	}

	public byte[] GetBuffer()
	{
		return _buffer;
	}

	public static int ReadVarInt(BinaryReader br)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		byte b;
		do
		{
			b = br.ReadByte();
			num |= (b & 0x7F) << num2;
			num2 += 7;
			num3++;
		}
		while ((b & 0x80) != 0 && num3 < br.BaseStream.Length);
		return num;
	}

	public static void WriteVarInt(BinaryWriter bw, int value)
	{
		while (value >= 128)
		{
			bw.Write((byte)(value | 0x80));
			value >>= 7;
		}
		bw.Write((byte)value);
	}

	public static int GetVarIntLen(int val)
	{
		if (val < 128)
		{
			return 1;
		}
		if (val < 16384)
		{
			return 2;
		}
		if (val < 2097152)
		{
			return 3;
		}
		if (val < 268435456)
		{
			return 4;
		}
		return 5;
	}

	public static IPAddress ReadIP(BinaryReader br)
	{
		return new IPAddress(((br.ReadByte() << 24) | (br.ReadByte() << 16) | (br.ReadByte() << 8) | br.ReadByte()) & 0xFFFFFFFFu);
	}

	public static void WriteIP(BinaryWriter bw, IPAddress ip)
	{
		byte[] addressBytes = ip.GetAddressBytes();
		for (int num = 3; num >= 0; num--)
		{
			bw.Write(addressBytes[num]);
		}
	}

	public static string ReadString(BinaryReader br)
	{
		int len = ReadVarInt(br);
		return ReadString(br, len);
	}

	public static int GetStringLength(string s)
	{
		int byteCount = Encoding.UTF8.GetByteCount(s);
		return byteCount + GetVarIntLen(byteCount);
	}

	public static string ReadString(BinaryReader br, int len)
	{
		byte[] bytes = br.ReadBytes(len);
		return Encoding.UTF8.GetString(bytes, 0, len);
	}

	public static void WriteString(BinaryWriter bw, string s)
	{
		int byteCount = Encoding.UTF8.GetByteCount(s);
		WriteVarInt(bw, byteCount);
		bw.Write(Encoding.UTF8.GetBytes(s));
	}

	public static void WriteString(BinaryWriter bw, byte[] s)
	{
		int value = s.Length;
		WriteVarInt(bw, value);
		bw.Write(s);
	}
}
