using System.Runtime.InteropServices;

namespace Cognex.Tako;

public interface Dimension
{
	LineStyle Style { get; set; }

	bool DrawOnTop
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get;
		[param: MarshalAs(UnmanagedType.U1)]
		set;
	}
}
