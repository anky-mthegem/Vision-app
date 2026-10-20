using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public class CvsStateChangedEventArgs : EventArgs
{
	private readonly CvsInSightState YkVbx552nN;

	private readonly CvsInSightStateChangedReason IiBbFQoUaU;

	private readonly int ifKbbje6Sw;

	public CvsInSightState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YkVbx552nN;
		}
	}

	public CvsInSightStateChangedReason Reason
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IiBbFQoUaU;
		}
	}

	internal int ConnectionCookie
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ifKbbje6Sw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsStateChangedEventArgs(CvsInSightState state, CvsInSightStateChangedReason reason, int connectionCookie)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!k3BuTEADpRNwVF7Rdvh())
		{
			goto IL_001e;
		}
		goto IL_007b;
		IL_0062:
		YkVbx552nN = state;
		goto IL_0034;
		IL_007b:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			case 5:
				goto IL_0034;
			case 6:
				goto IL_0045;
			case 2:
			case 3:
				goto IL_0062;
			default:
				num = 5;
				continue;
			case 4:
				ifKbbje6Sw = connectionCookie;
				num = 7;
				continue;
			case 7:
				return;
			}
			break;
			IL_0045:
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			_ = 1;
			if (pkDCmYAUYOE0NBtcdw3())
			{
				num = 3;
				continue;
			}
			num = 0;
			if (0 == 0)
			{
				continue;
			}
			goto IL_0062;
		}
		goto IL_001e;
		IL_0034:
		IiBbFQoUaU = reason;
		num = 4;
		goto IL_007b;
		IL_001e:
		wXX72MATuK846sn2wCl(this);
		goto IL_0062;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wXX72MATuK846sn2wCl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EventArgs)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k3BuTEADpRNwVF7Rdvh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pkDCmYAUYOE0NBtcdw3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
