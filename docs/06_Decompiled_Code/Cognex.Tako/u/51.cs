using System.Runtime.InteropServices;

namespace u;

internal interface _51
{
	int Height { get; }

	int Width { get; }

	void ImportPacket(byte[] P_0);

	[return: MarshalAs(UnmanagedType.U1)]
	bool IsComplete();
}
