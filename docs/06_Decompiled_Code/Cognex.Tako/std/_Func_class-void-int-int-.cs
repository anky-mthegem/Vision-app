using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 64)]
[NativeCppClass]
[UnsafeValueType]
internal struct _Func_class_003Cvoid_002Cint_002Cint_003E
{
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	[NativeCppClass]
	[UnsafeValueType]
	internal struct _Storage
	{
		[FieldOffset(0)]
		private long u;
	}

	private long u;
}
