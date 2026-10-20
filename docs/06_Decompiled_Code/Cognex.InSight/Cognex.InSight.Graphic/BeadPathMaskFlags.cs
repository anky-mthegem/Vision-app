using System;

namespace Cognex.InSight.Graphic;

[Flags]
public enum BeadPathMaskFlags : uint
{
	None = 0u,
	FillEdge1 = 1u,
	FillEdge2 = 2u,
	FillEither = FillEdge1 | FillEdge2,
	Ignore = 4u
}
