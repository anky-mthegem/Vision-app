using System;
using System.Collections.Generic;

namespace Cognex.Explorer.Common.Targets;

[Serializable]
public class DiscoveredTarget : IDiscoveredTarget
{
	private readonly string _identifier;

	private readonly string _displayname;

	private readonly int _typeId;

	private readonly Version _version;

	private readonly Dictionary<string, object> _attributes = new Dictionary<string, object>();

	public string DisplayName => _displayname;

	public string Identifier => _identifier;

	public int TypeFlag => _typeId;

	public bool IsUserDefinedTarget { get; }

	public Dictionary<string, object> Attributes => _attributes;

	public Version Version => _version;

	public DiscoveredTarget(string identifier, string displayname, int typeId, Version version, bool isUserDefinedTarget = false)
	{
		_identifier = identifier;
		_displayname = displayname;
		_typeId = typeId;
		_version = version;
		IsUserDefinedTarget = isUserDefinedTarget;
	}
}
