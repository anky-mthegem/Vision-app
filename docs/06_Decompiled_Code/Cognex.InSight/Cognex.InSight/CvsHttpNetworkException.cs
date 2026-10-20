using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public sealed class CvsHttpNetworkException : CvsNetworkException
{
	[CompilerGenerated]
	private HttpStatusCode OosbviUMBM;

	public HttpStatusCode StatusCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OosbviUMBM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OosbviUMBM = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsHttpNetworkException(string message, HttpStatusCode httpStatus, Exception innerException = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0081;
		IL_0034:
		StatusCode = httpStatus;
		num = 6;
		if (1 == 0)
		{
			goto IL_0047;
		}
		goto IL_0081;
		IL_0081:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 0:
				goto IL_0034;
			case 3:
				goto IL_0047;
			case 2:
			case 5:
				goto IL_0064;
			default:
				num = 0;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_0047:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		_ = 0;
		if (!SW77moUgrs7KhmcEny0())
		{
			num = 5;
			if (false)
			{
				goto IL_0034;
			}
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_0064;
			}
		}
		goto IL_0081;
		IL_001a:
		base._002Ector(message, innerException);
		goto IL_0064;
		IL_0064:
		HResult = -2147221504;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SW77moUgrs7KhmcEny0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tlK8yHUZSsv1D3x7rpt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
