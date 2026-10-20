using System;
using System.Threading.Tasks;

namespace Cognex.InSight.Internal;

public interface ILiveModeService
{
	bool IsLiveAcquisition { get; set; }

	event EventHandler IsLiveAcquisitionChanged;

	Task AcquireNextImage();
}
