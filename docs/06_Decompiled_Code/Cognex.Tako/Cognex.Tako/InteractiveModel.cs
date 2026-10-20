using System;
using System.Runtime.CompilerServices;

namespace Cognex.Tako;

public interface InteractiveModel
{
	[SpecialName]
	event EventHandler<DragEventArgs> DragEndEvent;

	[SpecialName]
	event EventHandler<DragEventArgs> DragBeginEvent;
}
