using System;

namespace Cognex.InSight.Graphic;

[Serializable]
[Flags]
public enum CvsEditFlags
{
	None = 0,
	Location = 1,
	Size = 2,
	Point0 = Location,
	Point1 = Size,
	Rotation = 4,
	Bend = 8,
	InPlane = 0x10,
	AddItem = 0x40,
	DeleteItem = 0x20,
	EditItem = 0x100,
	Corner0 = Bend,
	Corner1 = InPlane,
	Corner2 = DeleteItem,
	Corner3 = AddItem,
	Skew = Bend,
	MaskArea = 0x200,
	FillEdgeArea = 0x400,
	All = 0x1FF
}
