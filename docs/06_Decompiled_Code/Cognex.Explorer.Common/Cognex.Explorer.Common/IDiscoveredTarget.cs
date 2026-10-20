using System;
using System.Collections.Generic;

namespace Cognex.Explorer.Common;

public interface IDiscoveredTarget
{
	string DisplayName { get; }

	string Identifier { get; }

	int TypeFlag { get; }

	bool IsUserDefinedTarget { get; }

	Version Version { get; }

	Dictionary<string, object> Attributes { get; }
}
