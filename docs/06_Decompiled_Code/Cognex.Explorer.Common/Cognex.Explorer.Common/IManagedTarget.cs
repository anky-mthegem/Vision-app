using System.Collections.Generic;

namespace Cognex.Explorer.Common;

public interface IManagedTarget
{
	string DisplayName { get; }

	string Identifier { get; }

	string DisplayType { get; }

	string Description { get; }

	string AlertMessage { get; }

	IDiscoveredTarget Target { get; }

	XImage Icon { get; }

	Dictionary<string, string> UserVisibleAttributes { get; }

	ITargetAction[] Actions { get; }
}
