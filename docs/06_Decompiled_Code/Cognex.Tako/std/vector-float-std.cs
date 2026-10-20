using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 24)]
[NativeCppClass]
internal struct vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E
{
	private long u;

	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E* P_0, vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E* P_1)
	{
		_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bctor_007D(P_0, P_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E* P_0)
	{
		_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_Tidy(P_0);
	}
}
