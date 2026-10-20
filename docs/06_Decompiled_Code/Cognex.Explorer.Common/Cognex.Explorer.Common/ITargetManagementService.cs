using System.Collections.Generic;
using Cognex.Explorer.Common.Report;

namespace Cognex.Explorer.Common;

public interface ITargetManagementService
{
	bool IsActive { get; set; }

	event TargetChangedDelegate TargetInfoChanged;

	bool Supports(IDiscoveredTarget target);

	IManagedTarget GetTarget(string identifier);

	TargetReport CreateReport(string identifier);

	void ExecuteAction(string actionName, Dictionary<string, object> arguments);

	void Attach(IDiscoveredTarget target);

	void Detach(IDiscoveredTarget target);
}
