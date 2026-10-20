using System;
using Cognex.CogNamer.Client.Attributes;

namespace Cognex.CogNamer.Client;

public class CogNamerPacketEventArgs : EventArgs
{
	private readonly CogNamerCommand _cmd;

	private readonly CogNamerDevice _device;

	public CogNamerCommand Command => _cmd;

	public CogNamerDevice Device => _device;

	public CogNamerPacketEventArgs(CogNamerCommand cmd, CogNamerDevice device)
	{
		_cmd = cmd;
		_device = device;
	}
}
