using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cognex.Explorer.Common;

[Serializable]
public class RemoteDevice : ISerializable
{
	private const string DisplayNameTag = "DisplayName";

	private const string IconTag = "Icon";

	private const string ExtraInfoTag = "ExtraInfo";

	private const string ActionsTag = "Actions";

	public string DisplayName { get; }

	public XImage Icon { get; }

	public IDictionary<string, string> ExtraInfo { get; }

	public ITargetAction[] Actions { get; }

	public RemoteDevice(string displayName, XImage icon, IDictionary<string, string> extraInfo, ITargetAction[] actions)
	{
		DisplayName = displayName;
		Icon = icon;
		ExtraInfo = extraInfo;
		Actions = actions;
	}

	public RemoteDevice(SerializationInfo info, StreamingContext context)
	{
		DisplayName = info.GetString("DisplayName");
		Icon = (XImage)info.GetValue("Icon", typeof(XImage));
		ExtraInfo = (IDictionary<string, string>)info.GetValue("ExtraInfo", typeof(IDictionary<string, string>));
		Actions = (ITargetAction[])info.GetValue("Actions", typeof(ITargetAction[]));
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("DisplayName", DisplayName);
		info.AddValue("Icon", Icon);
		info.AddValue("ExtraInfo", ExtraInfo);
		info.AddValue("Actions", Actions);
	}
}
