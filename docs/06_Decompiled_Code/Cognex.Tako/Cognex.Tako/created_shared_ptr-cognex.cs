using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E
{
	private long u;

	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* P_0, created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* P_1)
	{
		*(long*)P_0 = 0L;
		*(long*)((ulong)(nint)P_0 + 8uL) = 0L;
		_003CModule_003E.std_002E_Ptr_base_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_Reset_003Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E((_Ptr_base_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)P_0, (_Ptr_base_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)P_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* P_0)
	{
		//IL_000f: Expected I, but got I8
		ulong num = *(ulong*)((ulong)(nint)P_0 + 8uL);
		if (num != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)num);
		}
	}
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E
{
	private long u;

	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* P_0, created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* P_1)
	{
		*(long*)P_0 = 0L;
		*(long*)((ulong)(nint)P_0 + 8uL) = 0L;
		_003CModule_003E.std_002E_Ptr_base_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002E_Reset_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E((_Ptr_base_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*)P_0, (_Ptr_base_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*)P_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* P_0)
	{
		//IL_000f: Expected I, but got I8
		ulong num = *(ulong*)((ulong)(nint)P_0 + 8uL);
		if (num != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)num);
		}
	}
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct created_shared_ptr_003Ccognex_003A_003Atako_003A_003AVertexColor_003E
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E
{
	private long u;
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E
{
	private long u;
}
