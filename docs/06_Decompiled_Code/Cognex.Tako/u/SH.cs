using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 64)]
[NativeCppClass]
[UnsafeValueType]
internal struct SH
{
	private long u;

	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(SH* P_0, SH* P_1)
	{
		*(long*)((ulong)(nint)P_0 + 56uL) = 0L;
		try
		{
			_003CModule_003E.u_002E2H_002E_Reset_copy((_2H*)P_0, (_2H*)P_1);
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_2H*, void>)(&_003CModule_003E.u_002E2H_002E_007Bdtor_007D), P_0);
			throw;
		}
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(SH* P_0)
	{
		_003CModule_003E.u_002E2H_002E_Tidy((_2H*)P_0);
	}
}
