using System.Collections.Generic;

namespace Cognex.Explorer.Common;

public interface ITargetLocatorService
{
	IEnumerable<IDiscoveredTarget> DetectedTargets { get; }

	bool Active { get; set; }

	event TargetsChangedDelegate TargetsChanged;

	void Search();
}
