using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace u;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[NativeCppClass]
[UnsafeValueType]
internal struct B8
{
}
[StructLayout(LayoutKind.Sequential, Size = 8)]
[NativeCppClass]
internal struct b8
{
}
