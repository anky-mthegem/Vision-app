using Newtonsoft.Json;

namespace Cognex.AnomalyDetector.Client.Tool.Interfaces;

public interface IFeatureSizeSettings
{
	[JsonProperty("minimum")]
	double Minimum { get; set; }

	[JsonProperty("maximum")]
	double Maximum { get; set; }

	[JsonProperty("currentValue")]
	double CurrentValue { get; set; }
}
