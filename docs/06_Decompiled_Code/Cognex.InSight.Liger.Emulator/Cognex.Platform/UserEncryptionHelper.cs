using System;
using System.Diagnostics;
using System.Text;

namespace Cognex.Platform;

internal class UserEncryptionHelper
{
	private static readonly Encoding _encoding = Encoding.UTF8;

	private static readonly byte[] Key = new byte[32]
	{
		213, 180, 22, 120, 167, 221, 210, 103, 67, 147,
		127, 49, 80, 167, 150, 16, 12, 218, 165, 216,
		96, 187, 53, 68, 58, 32, 181, 53, 184, 51,
		187, 236
	};

	[DebuggerStepThrough]
	public static string XOREncryptAndBase64(string input)
	{
		if (input == null)
		{
			return null;
		}
		byte[] bytes = _encoding.GetBytes(input);
		for (int i = 0; i < bytes.Length; i++)
		{
			bytes[i] ^= Key[i % Key.Length];
		}
		return Convert.ToBase64String(bytes);
	}

	[DebuggerStepThrough]
	public static string XORDecryptFromBase64(string input)
	{
		if (input == null)
		{
			return null;
		}
		byte[] array = Convert.FromBase64String(input);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] ^= Key[i % Key.Length];
		}
		return _encoding.GetString(array);
	}
}
