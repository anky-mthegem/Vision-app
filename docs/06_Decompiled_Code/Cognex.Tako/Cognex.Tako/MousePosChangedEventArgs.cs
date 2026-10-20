using System;

namespace Cognex.Tako;

public class MousePosChangedEventArgs : EventArgs
{
	public MousePos CurrentPos;

	public MousePosChangedEventArgs(MousePos current)
	{
		CurrentPos = current;
	}
}
