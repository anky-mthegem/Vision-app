using System.Threading.Tasks;

namespace Cognex.InSight;

public interface IInsertDeleteService
{
	Task DoInsert(CvsCellRange cellRange, ShiftCells shift);

	Task DoDelete(CvsCellRange cellRange, ShiftCells shift);
}
