using System;

namespace Cognex.InSight.Cell;

[Serializable]
[Flags]
internal enum CvsCellFlags : short
{
	Disabled = short.MinValue,
	Error = 0x4000,
	Empty = 0x2000,
	Control = 0x1000,
	Quotes = 0x800,
	HasChecksum = 8
}
