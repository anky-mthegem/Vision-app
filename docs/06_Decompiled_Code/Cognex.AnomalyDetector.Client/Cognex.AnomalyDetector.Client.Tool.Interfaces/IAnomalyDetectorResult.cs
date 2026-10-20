using Newtonsoft.Json;

namespace Cognex.AnomalyDetector.Client.Tool.Interfaces;

public interface IAnomalyDetectorResult
{
	[JsonProperty("image")]
	string Image { get; set; }

	[JsonProperty("heatmap")]
	string Heatmap { get; set; }

	[JsonProperty("score")]
	float Score { get; set; }

	[JsonProperty("sampleId")]
	string SampleId { get; set; }

	[JsonProperty("isPredictionGood")]
	bool IsPredictionGood { get; set; }
}
