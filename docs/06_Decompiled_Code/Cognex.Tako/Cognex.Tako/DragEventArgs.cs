using System;

namespace Cognex.Tako;

public class DragEventArgs : EventArgs
{
	public InteractiveHandle Handle;

	public DragEventArgs(int handle)
	{
		Handle = (InteractiveHandle)handle;
	}

	public DragEventArgs(InteractiveHandle handle)
	{
		Handle = handle;
	}
}
