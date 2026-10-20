using System;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Diagnostics;
using btFy13pd5uf4WC4h18;

namespace Cognex.Explorer.Diagnostics;

public static class CvsTraceExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IDisposable TraceResultFunction(this CnxTraceChannel self, long resultId, object caller, [CallerMemberName] string name = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return self.TraceFunction((string)LbrSWXjmalp21TlIA6(PckObFB3dDWDW8j8Ta(314), resultId, caller.GetType().Name, name));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IDisposable TraceResultFunction(this CnxTraceChannel self, object caller, [CallerMemberName] string name = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (IDisposable)FiQheg29qC6uij0eTe(self, qQuOLtcgUouKw6wojV(caller.GetType().Name, kgbOBx7BanbFa22Hp9.ol99ukmDA(344), name));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IDisposable TraceResultBlock(this CnxTraceChannel self, long resultId, object caller, [CallerMemberName] string name = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (IDisposable)IsiC4CWo69JKtqgd97(self, LbrSWXjmalp21TlIA6(PckObFB3dDWDW8j8Ta(314), resultId, caller.GetType().Name, name));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IDisposable TraceResultBlock(this CnxTraceChannel self, object caller, string message, [CallerMemberName] string name = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (IDisposable)IsiC4CWo69JKtqgd97(self, nJ1mo47WDYjkMH03J2(new string[5]
		{
			caller.GetType().Name,
			(string)PckObFB3dDWDW8j8Ta(344),
			name,
			kgbOBx7BanbFa22Hp9.ol99ukmDA(350),
			message
		}));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TraceResultMessage(this CnxTraceChannel self, string message, [CallerMemberName] string name = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HuELWRtZG8UmWdsVEj(self, name + (string)PckObFB3dDWDW8j8Ta(358) + message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void TraceResultMessage(this CnxTraceChannel self, long resultId, string message, [CallerMemberName] string name = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HuELWRtZG8UmWdsVEj(self, LbrSWXjmalp21TlIA6(PckObFB3dDWDW8j8Ta(368), resultId, name, message));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PckObFB3dDWDW8j8Ta(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LbrSWXjmalp21TlIA6(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TtccqOilkkCmUPObAD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JXutfxq4NG89csKEJO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qQuOLtcgUouKw6wojV(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FiQheg29qC6uij0eTe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IsiC4CWo69JKtqgd97(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceBlock((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nJ1mo47WDYjkMH03J2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HuELWRtZG8UmWdsVEj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1);
	}
}
