using System.Runtime.CompilerServices;
using Cognex.InSight.Sensor;

namespace Cognex.InSight.UserAccess.Internal;

public static class CvsPasswordValidator
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetCDSMinPasswordLength()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetCDSMaxPasswordLength()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return 30;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Validate(char c, bool cdsCheck)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!cdsCheck)
		{
			return xmsaFQ2eNNi02AmIYHD(c);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Validate(string password, bool cdsCheck)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!cdsCheck)
		{
			return W85PaQ2uuCjIGjjR7ax(password);
		}
		return jly4PmLuCK(password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ValidateCDS(string password)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return h7CWYr2IScdYfKFESch(password);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool jly4PmLuCK(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (e0Rp492RE68xRs5abeG(P_0) >= 1)
		{
			return e0Rp492RE68xRs5abeG(P_0) <= 30;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool dGW4IlHlnk(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return W85PaQ2uuCjIGjjR7ax(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xmsaFQ2eNNi02AmIYHD(char c)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsUser.IsValidUserNameOrPasswordChar(c);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tK4nHG2QUvpREIlWsQF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BhOSyu2lyfV5X6umEHn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W85PaQ2uuCjIGjjR7ax(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsUser.IsValidPassword((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool h7CWYr2IScdYfKFESch(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jly4PmLuCK((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int e0Rp492RE68xRs5abeG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}
}
