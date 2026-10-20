using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using u;

namespace msclr.interop;

internal class context_node_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E : n, IDisposable
{
	private unsafe sbyte* n;

	public unsafe context_node_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E(sbyte** P_0, string P_1)
	{
		//IL_000e: Expected I, but got I8
		//IL_002d: Expected I8, but got I
		//IL_0042: Expected I, but got I8
		//IL_0046: Expected I, but got I8
		//IL_0055: Expected I8, but got I
		//IL_006c: Expected I, but got I8
		n = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Uf uf2);
		if (P_1 == null)
		{
			*(long*)P_0 = 0L;
		}
		else
		{
			ulong num = _003CModule_003E.msclr_002Einterop_002Edetails_002EGetAnsiStringSize(P_1);
			*(long*)(&uf2) = (nint)_003CModule_003E.new_005B_005D(num);
			try
			{
				if (*(long*)(&uf2) == 0L)
				{
					throw new InsufficientMemoryException();
				}
				_003CModule_003E.msclr_002Einterop_002Edetails_002EWriteAnsiString((sbyte*)(*(ulong*)(&uf2)), num, P_1);
				sbyte* ptr = (sbyte*)(*(ulong*)(&uf2));
				*(long*)(&uf2) = 0L;
				n = ptr;
				*(long*)P_0 = (nint)ptr;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Uf*, void>)(&_003CModule_003E.u_002EUf_002E_007Bdtor_007D), &uf2);
				throw;
			}
			_003CModule_003E.delete_005B_005D(null);
		}
		try
		{
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Uf*, void>)(&_003CModule_003E.u_002EUf_002E_007Bdtor_007D), &uf2);
			throw;
		}
	}

	private new unsafe void u()
	{
		_003CModule_003E.delete_005B_005D(n);
	}

	private unsafe void W()
	{
		_003CModule_003E.delete_005B_005D(n);
	}

	[HandleProcessCorruptedStateExceptions]
	protected unsafe virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_003CModule_003E.delete_005B_005D(n);
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

	~context_node_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_003E()
	{
		Dispose(false);
	}
}
