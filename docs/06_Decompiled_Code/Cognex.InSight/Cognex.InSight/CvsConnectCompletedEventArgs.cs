using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public class CvsConnectCompletedEventArgs : EventArgs
{
	private readonly Exception Y1vbaJoZSk;

	public Exception Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Y1vbaJoZSk;
		}
	}

	public int ErrorNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Y1vbaJoZSk == null)
			{
				return 0;
			}
			return be4DHMAj2nwGEfiqLRV(Y1vbaJoZSk);
		}
	}

	public string ErrorMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Y1vbaJoZSk == null)
			{
				return "";
			}
			return Y1vbaJoZSk.Message;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsConnectCompletedEventArgs(Exception exception)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Hht1h2AdLrk6ZddANZj();
		int num = (xWyHRnAiRUrHdSUJros() ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				eaXIVfAqHqMweKovbGW();
				goto case 1;
			case 4:
				Y1vbaJoZSk = exception;
				num = 5;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				RiI8PGAB8RE1MxBbov2(this);
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eaXIVfAqHqMweKovbGW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RiI8PGAB8RE1MxBbov2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EventArgs)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Hht1h2AdLrk6ZddANZj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xWyHRnAiRUrHdSUJros()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int be4DHMAj2nwGEfiqLRV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Marshal.GetHRForException((Exception)P_0);
	}
}
