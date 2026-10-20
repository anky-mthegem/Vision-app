using System;
using System.Runtime.CompilerServices;
using IawbpyxeWauKVJvQ4t;

namespace Cognex.Remoting.CogSocket;

public class MessagePayloadPreviewEventArgs : EventArgs
{
	[CompilerGenerated]
	private object wZ1iCS7FeG;

	[CompilerGenerated]
	private bool RSMi5i7DXr;

	public object Payload
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wZ1iCS7FeG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wZ1iCS7FeG = value;
		}
	}

	public bool IsOutgoing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RSMi5i7DXr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RSMi5i7DXr = value;
		}
	}

	public bool IsIncoming
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !IsOutgoing;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MessagePayloadPreviewEventArgs(bool isOutgoing, object payload)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		do
		{
			IL_0041:
			switch (num)
			{
			case 1:
			case 4:
				base._002Ector();
				num = 2;
				goto IL_0041;
			case 2:
				IsOutgoing = isOutgoing;
				break;
			case 5:
				QgOcZ4D8qnJ5P0cjT4N();
				uXj4BMD7R2W1VPgggtm();
				num = ((!zlw2UvDcIy6211ekxlO()) ? 4 : 0);
				goto IL_0041;
			case 6:
				return;
			}
			Payload = payload;
			num = 6;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MessagePayloadPreviewEventArgs Incoming(object payload)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new MessagePayloadPreviewEventArgs(isOutgoing: false, payload);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MessagePayloadPreviewEventArgs Outgoing(object payload)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new MessagePayloadPreviewEventArgs(isOutgoing: true, payload);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uXj4BMD7R2W1VPgggtm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zlw2UvDcIy6211ekxlO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QgOcZ4D8qnJ5P0cjT4N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
	}
}
