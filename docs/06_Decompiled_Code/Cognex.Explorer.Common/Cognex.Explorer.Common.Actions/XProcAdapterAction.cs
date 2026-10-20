using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Media.Imaging;

namespace Cognex.Explorer.Common.Actions;

[Serializable]
public class XProcAdapterAction : IXProcAdapterAction, ITargetAction, ISerializable
{
	public string Name { get; set; }

	public string DisplayName { get; set; }

	public string Description { get; set; }

	public string UniqueId { get; set; }

	public bool IsEnabled { get; set; }

	public bool IsDefault { get; set; }

	public TargetAccessMode AccessMode { get; set; }

	public BitmapSource Icon { get; set; }

	public MultiTargetMode MultiTargetMode { get; set; }

	public Dictionary<string, object> Arguments { get; } = new Dictionary<string, object>();

	public object Tag { get; set; }

	public XProcAdapterAction()
	{
	}

	protected XProcAdapterAction(SerializationInfo info, StreamingContext context)
	{
		Name = info.GetString("Name");
		DisplayName = info.GetString("DisplayName");
		Description = info.GetString("Description");
		UniqueId = info.GetString("UniqueId");
		MultiTargetMode = (MultiTargetMode)info.GetValue("MultiTargetMode", typeof(MultiTargetMode));
		IsEnabled = info.GetBoolean("IsEnabled");
		IsDefault = info.GetBoolean("IsDefault");
		Icon = Utils.BytesToImage((byte[])info.GetValue("Icon", typeof(byte[])));
		Icon?.Freeze();
		AccessMode = (TargetAccessMode)info.GetValue("AccessMode", typeof(TargetAccessMode));
		Arguments = (Dictionary<string, object>)info.GetValue("Arguments", typeof(Dictionary<string, object>));
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Name", Name);
		info.AddValue("DisplayName", DisplayName);
		info.AddValue("Description", Description);
		info.AddValue("UniqueId", UniqueId);
		info.AddValue("AccessMode", AccessMode);
		info.AddValue("MultiTargetMode", MultiTargetMode);
		info.AddValue("IsDefault", IsDefault);
		info.AddValue("IsEnabled", IsEnabled);
		info.AddValue("Icon", Utils.ImageToByte(Icon));
		info.AddValue("Arguments", Arguments);
	}
}
