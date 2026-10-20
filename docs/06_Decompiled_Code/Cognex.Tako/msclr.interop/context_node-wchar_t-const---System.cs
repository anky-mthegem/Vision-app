using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using u;

namespace msclr.interop;

internal class context_node_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E : n, IDisposable
{
	private IntPtr n;

	public unsafe context_node_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E(char** P_0, string P_1)
	{
		//IL_0021: Expected I8, but got I
		IntPtr intPtr = Marshal.StringToHGlobalUni(P_1);
		n = intPtr;
		*(long*)P_0 = (nint)n.ToPointer();
	}

	private new void u()
	{
		W();
	}

	private void W()
	{
		if (n != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(n);
		}
	}

	[HandleProcessCorruptedStateExceptions]
	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			W();
			return;
		}
		try
		{
			W();
		}
		finally
		{
			base.Finalize();
		}
	}

	public virtual sealed void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	~context_node_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E()
	{
		Dispose(false);
	}
}
