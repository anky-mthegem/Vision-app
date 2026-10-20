using System.Collections;
using System.Collections.Generic;

namespace Cognex.CogNamer.Client.Attributes;

public interface INetworkDeviceAttributeProvider : IEnumerable<CogNamerNetworkDeviceAttribute>, IEnumerable
{
	CogNamerNetworkDeviceAttribute this[CogNamerAttributeType type] { get; }

	int Count { get; }

	bool Contains(CogNamerAttributeType type);
}
