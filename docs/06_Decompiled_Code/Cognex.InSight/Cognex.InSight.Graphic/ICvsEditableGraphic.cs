using System.Drawing;

namespace Cognex.InSight.Graphic;

public interface ICvsEditableGraphic
{
	CvsEditFlags EditFlags { get; }

	RectangleF EditBounds { get; }
}
