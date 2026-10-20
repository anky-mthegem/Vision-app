using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cognex.Explorer.Common.Targets;

[Serializable]
public class ManagedTarget : IManagedTarget, ISerializable
{
	private readonly Dictionary<string, string> _userAttributes = new Dictionary<string, string>();

	public string DisplayName => Target.DisplayName;

	public string Identifier => Target.Identifier;

	public string DisplayType { get; set; }

	public string Description { get; set; }

	public string AlertMessage { get; set; }

	public IDiscoveredTarget Target { get; }

	public XImage Icon { get; set; }

	public Dictionary<string, string> UserVisibleAttributes => _userAttributes;

	public ITargetAction[] Actions { get; set; }

	public ManagedTarget(IDiscoveredTarget target)
	{
		Target = target;
		Actions = new ITargetAction[0];
	}

	public ManagedTarget(SerializationInfo info, StreamingContext context)
	{
		Target = (IDiscoveredTarget)info.GetValue("Target", typeof(IDiscoveredTarget));
		Icon = (XImage)info.GetValue("Icon", typeof(XImage));
		_userAttributes = (Dictionary<string, string>)info.GetValue("UserVisibleAttributes", typeof(Dictionary<string, string>));
		Actions = (ITargetAction[])info.GetValue("Actions", typeof(ITargetAction[]));
		DisplayType = info.GetString("DisplayType");
		Description = info.GetString("Description");
		AlertMessage = info.GetString("AlertMessage");
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Target", Target);
		info.AddValue("Icon", Icon);
		info.AddValue("UserVisibleAttributes", UserVisibleAttributes);
		info.AddValue("Actions", Actions);
		info.AddValue("DisplayType", DisplayType);
		info.AddValue("Description", Description);
		info.AddValue("AlertMessage", AlertMessage);
	}
}
