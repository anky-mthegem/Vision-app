using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cognex.Explorer.Common.Report;

[Serializable]
public class TargetReport : TargetReportNode
{
	public TargetReport(string header)
		: base(header)
	{
	}

	public TargetReport(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		Header = info.GetString("Header");
		Children = (List<TargetReportNode>)info.GetValue("Children", typeof(List<TargetReportNode>));
	}
}
