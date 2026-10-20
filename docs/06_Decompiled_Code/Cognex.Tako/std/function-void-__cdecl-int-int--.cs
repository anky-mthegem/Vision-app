using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 64)]
[NativeCppClass]
[UnsafeValueType]
internal struct function_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E
{
	private long u;

	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(function_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E* P_0, function_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E* P_1)
	{
		*(long*)((ulong)(nint)P_0 + 56uL) = 0L;
		try
		{
			_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_002Cint_003E_002E_Reset_copy((_Func_class_003Cvoid_002Cint_002Cint_003E*)P_0, (_Func_class_003Cvoid_002Cint_002Cint_003E*)P_1);
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Func_class_003Cvoid_002Cint_002Cint_003E*, void>)(&_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_002Cint_003E_002E_007Bdtor_007D), P_0);
			throw;
		}
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(function_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E* P_0)
	{
		_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_002Cint_003E_002E_Tidy((_Func_class_003Cvoid_002Cint_002Cint_003E*)P_0);
	}
}
