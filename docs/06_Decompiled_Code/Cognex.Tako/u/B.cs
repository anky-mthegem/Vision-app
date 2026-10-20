using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using msclr.interop;

namespace u;

internal class B : IDisposable
{
	public class internal_marshaler_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E
	{
		public unsafe static char* u(string* P_0, LinkedList<object> P_1)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char* result);
			context_node_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E value = new context_node_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E(&result, *P_0);
			P_1.AddLast(value);
			return result;
		}
	}

	public class internal_marshaler_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E
	{
		public unsafe static sbyte* u(string* P_0, LinkedList<object> P_1)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte* result);
			context_node_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E value = new context_node_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E(&result, *P_0);
			P_1.AddLast(value);
			return result;
		}
	}

	internal readonly LinkedList<object> B = new LinkedList<object>();

	public unsafe char* u(string P_0)
	{
		return internal_marshaler_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E.u(&P_0, B);
	}

	private void W()
	{
		LinkedList<object>.Enumerator enumerator = B.GetEnumerator();
		if (!enumerator.MoveNext())
		{
			return;
		}
		do
		{
			if (enumerator.Current is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
		while (enumerator.MoveNext());
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			W();
		}
		else
		{
			base.Finalize();
		}
	}

	public virtual sealed void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	public unsafe sbyte* n(string P_0)
	{
		return internal_marshaler_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E.u(&P_0, B);
	}
}
