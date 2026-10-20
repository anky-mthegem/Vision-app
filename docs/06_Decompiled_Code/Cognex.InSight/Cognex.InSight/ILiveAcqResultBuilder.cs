using Cognex.InSight.Internal;

namespace Cognex.InSight;

internal interface ILiveAcqResultBuilder : IResultBuilder
{
	ILiveModeService LiveModeService { get; set; }

	void SuspendUpdates();

	void ResumeUpdates();
}
