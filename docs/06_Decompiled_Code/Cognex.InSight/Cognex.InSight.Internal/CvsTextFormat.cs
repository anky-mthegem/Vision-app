using System;

namespace Cognex.InSight.Internal;

[Flags]
public enum CvsTextFormat
{
	Top = 0,
	Left = 0,
	Center = 1,
	Right = 2,
	VCenter = 4,
	Bottom = 8,
	WordBreak = 0x10,
	SingleLine = 0x20,
	ExpandTabs = 0x40,
	TabStop = 0x80,
	NoClip = 0x100,
	ExternalLeading = 0x200,
	NoPrefix = 0x800,
	Internal = 0x1000,
	EditControl = 0x2000,
	PathEllipses = 0x4000,
	EndEllipses = 0x8000,
	RtlReading = 0x20000,
	WordEllipses = 0x40000,
	DrawInSightSymbols = 0x100000,
	DrawTextMask = 0x7FFFF,
	HorizontalUnspecified = 0x10000000,
	VerticalUnspecified = 0x20000000
}
