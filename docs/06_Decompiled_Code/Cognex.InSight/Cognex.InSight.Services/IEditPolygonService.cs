using System.Drawing;
using System.Threading.Tasks;

namespace Cognex.InSight.Services;

public interface IEditPolygonService
{
	Task<PointF[]> GetPoints();

	Task<RectangleF> GetEditBounds();

	Task SetPoints(PointF[] points);

	Task<PointF[]> EditPoints();
}
