using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace u;

internal class gW : Stack
{
	private static object n;

	internal static gW B;

	[SecuritySafeCritical]
	internal void u(EventHandler P_0)
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			Monitor.Enter(n, ref lockTaken);
			RuntimeHelpers.PrepareDelegate(P_0);
			Push(P_0);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(n);
			}
		}
	}

	[SecurityCritical]
	static gW()
	{
		n = new object();
		B = new gW();
	}

	[SecuritySafeCritical]
	private gW()
	{
		EventHandler value = W;
		AppDomain.CurrentDomain.DomainUnload += value;
		AppDomain.CurrentDomain.ProcessExit += value;
	}

	[PrePrepareMethod]
	[SecurityCritical]
	private void W(object P_0, EventArgs P_1)
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			Monitor.Enter(n, ref lockTaken);
			IEnumerator enumerator = GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					((EventHandler)enumerator.Current)(P_0, P_1);
				}
			}
			finally
			{
				IEnumerator enumerator2 = enumerator;
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(n);
			}
		}
	}
}
[NativeCppClass]
internal enum gw
{

}
