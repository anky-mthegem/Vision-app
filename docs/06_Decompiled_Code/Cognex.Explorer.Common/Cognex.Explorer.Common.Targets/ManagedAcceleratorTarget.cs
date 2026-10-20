using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cognex.Explorer.Common.Targets;

[Serializable]
public class ManagedAcceleratorTarget : IManagedAcceleratorTarget, IManagedTarget, ISerializable
{
	private const string TargetKey = "Target";

	private const string IconKey = "Icon";

	private const string UserVisibleAttributesKey = "UserVisibleAttributes";

	private const string ActionsKey = "Actions";

	private const string DisplayTypeKey = "DisplayType";

	private const string DescriptionKey = "Description";

	private const string AlertMessageKey = "AlertMessage";

	private const string RemoteDevicesKey = "RemoteDevices";

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

	public RemoteDevice[] RemoteDevices { get; set; }

	public ManagedAcceleratorTarget(IDiscoveredTarget target)
	{
		Target = target;
		Actions = Array.Empty<ITargetAction>();
	}

	public ManagedAcceleratorTarget(SerializationInfo info, StreamingContext context)
	{
		Target = (IDiscoveredTarget)info.GetValue("Target", typeof(IDiscoveredTarget));
		Icon = (XImage)info.GetValue("Icon", typeof(XImage));
		_userAttributes = (Dictionary<string, string>)info.GetValue("UserVisibleAttributes", typeof(Dictionary<string, string>));
		Actions = (ITargetAction[])info.GetValue("Actions", typeof(ITargetAction[]));
		DisplayType = info.GetString("DisplayType");
		Description = info.GetString("Description");
		AlertMessage = info.GetString("AlertMessage");
		RemoteDevices = (RemoteDevice[])info.GetValue("RemoteDevices", typeof(RemoteDevice[]));
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Target", Target);
		info.AddValue("Icon", Icon);
		info.AddValue("UserVisibleAttributes", UserVisibleAttributes);
		info.AddValue("Actions", Actions);
		info.AddValue("DisplayType", DisplayType);
		info.AddValue("Description", Description);
		info.AddValue("AlertMessage", AlertMessage);
		info.AddValue("RemoteDevices", RemoteDevices);
	}
}
