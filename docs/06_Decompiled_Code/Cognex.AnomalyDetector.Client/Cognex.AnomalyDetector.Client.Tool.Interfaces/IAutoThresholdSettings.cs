using Newtonsoft.Json;

namespace Cognex.AnomalyDetector.Client.Tool.Interfaces;

public interface IAutoThresholdSettings
{
	[JsonProperty("useAutoThreshold")]
	bool UseAutoThreshold { get; set; }

	[JsonProperty("selectedOption")]
	AutoThresholdOptions SelectedOption { get; set; }
}
