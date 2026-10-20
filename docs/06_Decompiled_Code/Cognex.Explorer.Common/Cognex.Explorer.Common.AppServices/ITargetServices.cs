using System.Collections.Generic;

namespace Cognex.Explorer.Common.AppServices;

public interface ITargetServices : IHostService
{
	IDiscoveredTarget[] GetTargetList();

	void Reset();

	void SetUserData(string targetIdentifier, Dictionary<string, object> attributes);
}
