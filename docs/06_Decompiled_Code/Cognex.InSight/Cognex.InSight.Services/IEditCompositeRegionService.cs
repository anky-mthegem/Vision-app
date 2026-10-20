using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.Services;

public interface IEditCompositeRegionService
{
	Task<CvsCogSubRegion[]> GetRegions();

	Task SetRegions(CvsCogSubRegion[] regions);

	Task<CvsCogSubRegion[]> EditGraphics();
}
