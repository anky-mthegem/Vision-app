using System;
using System.Runtime.CompilerServices;
using u;

namespace Cognex.Tako;

public class RenderChrono : Chrono
{
	public unsafe RenderChrono(Pm* native)
	{
		//IL_0018: Expected I, but got I8
		//IL_0006: Expected I, but got I8
		PL* ptr;
		if (native == null)
		{
			ptr = null;
		}
		else
		{
			ptr = (PL*)((long)(nint)native + (long)(*(int*)(*(long*)((ulong)(nint)native + 8uL) + 4)) + 8);
		}
		base._002Ector();
		native_ = ptr;
	}

	public unsafe void Reset()
	{
		//IL_0037: Expected I, but got I8
		//IL_0037: Expected I, but got I8
		DisposedCheck();
		void* ptr = _003CModule_003E.__RTDynamicCast(native_, 0, System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVChrono_0040tako_0040cognex_0040_0040_00408), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVRenderChrono_0040tako_0040cognex_0040_0040_00408), 0);
		long num = (long)(nint)ptr + (long)(*(int*)(*(long*)((ulong)(nint)ptr + 8uL) + 4)) + 8;
		((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, void>)(*(ulong*)(*(long*)num + 40)))((nint)num);
	}

	public unsafe void Toc()
	{
		//IL_0025: Expected I, but got I8
		DisposedCheck();
		void* ptr = _003CModule_003E.__RTDynamicCast(native_, 0, System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVChrono_0040tako_0040cognex_0040_0040_00408), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVRenderChrono_0040tako_0040cognex_0040_0040_00408), 0);
		((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, void>)(*(ulong*)(*(ulong*)ptr)))((nint)ptr);
	}
}
