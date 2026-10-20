using System;
using System.Text;

namespace Cognex.CogNamer.Client;

public class CogNamerEncrypt : IEncrypt, IDecrypt
{
	private class SeedValue
	{
		internal int Seed;

		internal int Value;
	}

	private const int MULTIPLIER = 3417;

	private const int ADDER = 23;

	private const int RAND_MASK = 4064;

	private const int OFFSET_0 = 26;

	private const int OFFSET_US = 36;

	private const int OFFSET_MINUS = 37;

	private const int OFFSET_A = 38;

	private static readonly byte[] sLookupTable;

	static CogNamerEncrypt()
	{
		sLookupTable = new byte[64];
		int i;
		for (i = 0; i <= 25; i++)
		{
			sLookupTable[i] = (byte)(i + 97);
		}
		for (int j = 48; j <= 57; j++)
		{
			sLookupTable[i] = (byte)j;
			i++;
		}
		sLookupTable[i++] = 95;
		sLookupTable[i++] = 45;
		for (int k = 65; k <= 90; k++)
		{
			sLookupTable[i] = (byte)k;
			i++;
		}
	}

	public byte[] Encrypt(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			return new byte[0];
		}
		return av_encrypt(Encoding.UTF8.GetBytes(str));
	}

	private static byte[] av_encrypt(byte[] str)
	{
		if (str == null || str.Length == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[str.Length + 1];
		SeedValue seedValue = new SeedValue();
		if (str.Length == 0)
		{
			return null;
		}
		Random random = new Random();
		seedValue.Seed = (int)(random.NextDouble() * 63.0) + 1;
		array[0] = sLookupTable[seedValue.Seed];
		av_random(seedValue);
		seedValue.Seed = 0;
		int num = 0;
		while (num < str.Length)
		{
			int num2 = av_random(seedValue) % 64;
			int offset = GetOffset(str[num]);
			if (offset >= 0)
			{
				array[++num] = sLookupTable[(num2 + offset) % 64];
			}
			else
			{
				array[++num] = (byte)(-offset);
			}
		}
		return array;
	}

	public string Decrypt(byte[] src)
	{
		if (src == null || src.Length < 1)
		{
			return string.Empty;
		}
		byte[] array = av_decrypt(src);
		char[] array2 = new char[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (char)array[i];
		}
		return new string(array2);
	}

	public string Decrypt(string src)
	{
		if (string.IsNullOrEmpty(src))
		{
			return string.Empty;
		}
		char[] array = src.ToCharArray();
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (byte)array[i];
		}
		array2 = av_decrypt(array2);
		array = new char[array2.Length];
		for (int j = 0; j < array2.Length; j++)
		{
			array[j] = (char)array2[j];
		}
		return new string(array);
	}

	private static byte[] av_decrypt(byte[] encrypt)
	{
		if (encrypt == null || encrypt.Length == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[encrypt.Length - 1];
		SeedValue seedValue = new SeedValue();
		seedValue.Seed = GetOffset(encrypt[0]);
		av_random(seedValue);
		seedValue.Seed = 0;
		for (int i = 1; i < encrypt.Length; i++)
		{
			int num = av_random(seedValue) % 64;
			int offset = GetOffset(encrypt[i]);
			if (offset >= 0)
			{
				num = offset - num;
				num = ((num < 0) ? (num + 64) : num);
				array[i - 1] = sLookupTable[num];
			}
			else
			{
				array[i - 1] = (byte)(-offset);
			}
		}
		return array;
	}

	private static int av_random(SeedValue v)
	{
		if (v.Seed != 0)
		{
			v.Value = -1 * v.Seed;
		}
		v.Value = v.Value * 3417 + 23;
		return UrShift(v.Value & 0xFE0, 4);
	}

	private static int UrShift(int number, int bits)
	{
		if (number >= 0)
		{
			return number >> bits;
		}
		return (number >> bits) + (2 << ~bits);
	}

	private static int GetOffset(byte b)
	{
		int num = b & 0xFF;
		if (num >= 97 && num <= 122)
		{
			return num - 97;
		}
		if (num >= 65 && num <= 90)
		{
			return num - 65 + 38;
		}
		if (num >= 48 && num <= 57)
		{
			return num - 48 + 26;
		}
		return num switch
		{
			95 => 36, 
			45 => 37, 
			_ => -num, 
		};
	}
}
