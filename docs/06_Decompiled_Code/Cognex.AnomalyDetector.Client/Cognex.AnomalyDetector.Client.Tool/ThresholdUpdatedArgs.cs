using System;
using Newtonsoft.Json;

namespace Cognex.AnomalyDetector.Client.Tool;

public class ThresholdUpdatedArgs : EventArgs
{
	[JsonProperty("toolId")]
	public string ToolId { get; set; }

	public float Threshold { get; set; }
}
