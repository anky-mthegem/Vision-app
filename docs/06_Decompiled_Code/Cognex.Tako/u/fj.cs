using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct fj
{
	private long u;

	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(fj* P_0, fj* P_1)
	{
		_003CModule_003E.__ExceptionPtrCopy(P_0, P_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(fj* P_0)
	{
		_003CModule_003E.__ExceptionPtrDestroy(P_0);
	}
}
[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
internal struct fJ
{
	private long u;
}
