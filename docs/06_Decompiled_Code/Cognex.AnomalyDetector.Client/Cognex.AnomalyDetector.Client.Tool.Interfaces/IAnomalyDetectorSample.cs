using Newtonsoft.Json;

namespace Cognex.AnomalyDetector.Client.Tool.Interfaces;

public interface IAnomalyDetectorSample : IIdentifiableElement
{
	[JsonProperty("image")]
	string Image { get; set; }

	[JsonProperty("label")]
	AnomalyDetectorLabels Label { get; set; }

	[JsonProperty("date")]
	long Date { get; set; }
}
