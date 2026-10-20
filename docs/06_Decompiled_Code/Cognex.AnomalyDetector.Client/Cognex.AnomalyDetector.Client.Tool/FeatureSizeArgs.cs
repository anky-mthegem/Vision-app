using System;
using Newtonsoft.Json;

namespace Cognex.AnomalyDetector.Client.Tool;

public class FeatureSizeArgs : EventArgs
{
	[JsonProperty("toolId")]
	public string ToolId { get; set; }
}
