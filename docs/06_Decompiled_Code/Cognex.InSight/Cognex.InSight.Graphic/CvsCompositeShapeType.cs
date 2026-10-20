using System.ComponentModel;

namespace Cognex.InSight.Graphic;

[TypeConverter(typeof(CvsCompositeShapeTypeConverter))]
public enum CvsCompositeShapeType
{
	None,
	RegionType,
	PolygonType,
	CircleType,
	AnnulusType
}
