using System.Collections.Generic;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.Services;

public interface IInspectBeadService
{
	Task<CvsInspectBeadArgUpdate> ClearDefectWithParamUpdate(int defectIndex, CvsInspectBeadDefectType defectType, int argIndex, string expression);

	Task ClearDefectWithMask(int defectIndex);

	Task ClearDefectWithFill(int defectIndex, CvsInspectBeadDefectType defectType);

	Task<CvsInspectBeadDefect[]> GetDefects();

	Task<CvsInspectBeadStatistics> GetStatistics();

	Task<CvsCogBeadPathMask> GetBeadPathMaskAndFillForEditing();

	Task SetBeadPathMaskAndFill(List<int> flags);
}
