using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class Chrono
{
	public struct Result
	{
		public double Mean;

		public double StdDev;

		public int N;

		public string Name;

		public unsafe Result(PL.PO* native)
		{
			//IL_0025: Expected I, but got I8
			//IL_0033: Expected I, but got I8
			Mean = *(double*)native;
			StdDev = *(double*)((ulong)(nint)native + 16uL);
			N = *(int*)((ulong)(nint)native + 8uL);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((ulong)(nint)native + 24uL);
			sbyte* value = ((16uL > (ulong)(*(long*)((ulong)(nint)ptr + 24uL))) ? ((sbyte*)ptr) : ((sbyte*)(*(ulong*)ptr)));
			Name = new string(value);
		}
	}

	protected unsafe PL* native_;

	public unsafe bool Enable
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_0022: Expected I, but got I8
			PL* ptr = native_;
			if (ptr == null)
			{
				throw new ObjectDisposedException("Chrono already disposed");
			}
			return ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, byte>)(*(ulong*)(*(long*)ptr + 32)))((nint)ptr) != 0;
		}
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			//IL_0023: Expected I, but got I8
			PL* ptr = native_;
			if (ptr == null)
			{
				throw new ObjectDisposedException("Chrono already disposed");
			}
			((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, byte, void>)(*(ulong*)(*(long*)ptr + 24)))((nint)ptr, value ? ((byte)1) : ((byte)0));
		}
	}

	public unsafe Chrono(PL* native)
	{
		native_ = native;
	}

	public unsafe void DumpAll()
	{
		//IL_0021: Expected I, but got I8
		PL* ptr = native_;
		if (ptr == null)
		{
			throw new ObjectDisposedException("Chrono already disposed");
		}
		((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, void>)(*(ulong*)(*(long*)ptr + 8)))((nint)ptr);
	}

	public unsafe void Tic(string name)
	{
		//IL_0031: Expected I, but got I8
		if (native_ == null)
		{
			throw new ObjectDisposedException("Chrono already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = StringHelper.to_UTF8(&obj, name);
		try
		{
			PL* ptr2 = native_;
			((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(*(ulong*)(*(long*)ptr2 + 48)))((nint)ptr2, ptr);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj, true, 0uL);
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
	}

	public unsafe void Toc(string name)
	{
		//IL_0032: Expected I, but got I8
		if (native_ == null)
		{
			throw new ObjectDisposedException("Chrono already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = StringHelper.to_UTF8(&obj, name);
		try
		{
			PL* ptr2 = native_;
			((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, PL.PQ, void>)(*(ulong*)(*(long*)ptr2 + 56)))((nint)ptr2, ptr, (PL.PQ)2);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj, true, 0uL);
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
	}

	public unsafe List<Result> GetAll()
	{
		//IL_002f: Expected I, but got I8
		//IL_0030: Expected I8, but got I
		//IL_0038: Expected I, but got I8
		//IL_0080: Expected I, but got I8
		if (native_ == null)
		{
			throw new ObjectDisposedException("Chrono already disposed");
		}
		List<Result> list = new List<Result>();
		PL* ptr = native_;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E obj);
		long num = (nint)((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, vector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E*, vector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E*>)(*(ulong*)(*(long*)ptr + 16)))((nint)ptr, &obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E obj2);
		try
		{
			_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_002E_007Bctor_007D(&obj2, (vector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E*)num);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_002E_Tidy(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_0020_003E obj3);
			_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_002Ebegin(&obj2, &obj3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_0020_003E obj4);
			_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_002Eend(&obj2, &obj4);
			while (*(long*)(&obj3) != *(long*)(&obj4))
			{
				Result item = new Result((PL.PO*)(*(ulong*)(&obj3)));
				list.Add(item);
				*(long*)(&obj3) += 56L;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AChrono_003A_003AResult_003E_0020_003E_002E_Tidy(&obj2);
		return list;
	}

	public unsafe void ResetNative()
	{
		//IL_0008: Expected I, but got I8
		native_ = null;
	}

	protected unsafe void DisposedCheck()
	{
		if (native_ == null)
		{
			throw new ObjectDisposedException("Chrono already disposed");
		}
	}
}
