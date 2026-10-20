using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.ComponentModel;

public class CnxCompletedEventArgs : EventArgs
{
	private readonly object zsjMFJp1O;

	private readonly Exception LBtonawF7;

	public Exception Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LBtonawF7;
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
			if (LBtonawF7 == null)
			{
				return "";
			}
			return (string)xHFksHhqwpZYnSPCTmo(LBtonawF7);
		}
	}

	public object Result
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zsjMFJp1O;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxCompletedEventArgs(object result, Exception exception)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 4:
				RMg9mHhdOx3JrvTIUW9();
				num = 5;
				continue;
			case 5:
				GcIjCAhifDIU55ss5AY(this);
				TmtnychU3ME75lf5Zrq();
				if (!dSK2oNhTHtI6wZQ5IqP())
				{
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 1;
				}
				num = 0;
				continue;
			case 1:
			case 2:
				zsjMFJp1O = result;
				break;
			case 6:
				return;
			}
			LBtonawF7 = exception;
			num = 6;
			if (dSK2oNhTHtI6wZQ5IqP())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RMg9mHhdOx3JrvTIUW9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GcIjCAhifDIU55ss5AY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EventArgs)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TmtnychU3ME75lf5Zrq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dSK2oNhTHtI6wZQ5IqP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xHFksHhqwpZYnSPCTmo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}
}
