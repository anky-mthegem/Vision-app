using System;
using System.Net.Sockets;

namespace Cognex.CogNamer.Client;

public static class NetworkUtils
{
	internal static void DisableUdpConnReset(object socket)
	{
		byte[] optionInValue = new byte[1] { Convert.ToByte(value: false) };
		byte[] optionOutValue = new byte[0];
		((Socket)socket).IOControl(-1744830452, optionInValue, optionOutValue);
	}
}
