using System;

namespace Cognex.Tako;

[Flags]
public enum InteractiveHandle
{
	Rotate = 1,
	Translate = 2,
	Scale = 4,
	InPlaneOnly = 8,
	All = Rotate | Translate | Scale
}
