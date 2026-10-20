using Cognex.Designer.Core;
using Cognex.InSight.ViDiEL.ViewModels.Properties;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets.Classify;

public enum ProjectionMode
{
	[DisplayName(typeof(Resources), "HeightMap")]
	HeightMap = 0,
	[DisplayName(typeof(Resources), "VerticalShapeChange")]
	VerticalShapeChange = 1,
	[DisplayName(typeof(Resources), "ShapeChange")]
	ShapeChange = 2,
	[DisplayName(typeof(Resources), "AutomaticHeightMap")]
	AutomaticHeightMap = 3,
	[DisplayName(typeof(Resources), "FlexInspect")]
	FlexInspect = 4,
	[DisplayName(typeof(Resources), "CurveInspect")]
	CurveInspect = 6,
	[DisplayName(typeof(Resources), "Greyscale")]
	Greyscale = 7
}
