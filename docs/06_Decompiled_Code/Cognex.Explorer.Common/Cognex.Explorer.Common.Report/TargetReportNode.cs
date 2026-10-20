using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cognex.Explorer.Common.Report;

[Serializable]
public class TargetReportNode : Dictionary<string, string>
{
	public string Header { get; protected set; }

	public List<TargetReportNode> Children { get; protected set; } = new List<TargetReportNode>();

	public TargetReportNode(string header)
	{
		Header = header;
	}

	public TargetReportNode(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		Header = info.GetString("Header");
		Children = (List<TargetReportNode>)info.GetValue("Children", typeof(List<TargetReportNode>));
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Header", Header);
		info.AddValue("Children", Children);
	}
}
