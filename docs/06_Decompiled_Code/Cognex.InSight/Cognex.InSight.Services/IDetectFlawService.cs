using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.Services;

public interface IDetectFlawService
{
	Task AddResidualImage();

	Task ExpandMask();

	Task ShrinkMask();

	Task RemoveMask();

	Task ResetToDefaultMask();

	Task<CvsCogDetectFlawDefect[]> GetDefects();

	Task SelectDefects(int[] selectIndexes);

	Task IgnoreDefects(int[] ignoreIndexes);

	Task<bool> GetShowMaskOverride();

	Task SetShowMaskOverride(bool showMaskOverride);
}
