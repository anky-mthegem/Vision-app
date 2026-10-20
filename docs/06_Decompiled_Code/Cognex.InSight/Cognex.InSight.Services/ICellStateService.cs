using System.Threading.Tasks;

namespace Cognex.InSight.Services;

public interface ICellStateService
{
	Task SetState(CvsCellRange range, CellState cellState);

	CellState[] GetState(CvsCellRange range);
}
