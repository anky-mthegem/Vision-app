using Newtonsoft.Json;

namespace Cognex.AnomalyDetector.Client.Tool.Interfaces;

public interface IAnomalyDetectorStats
{
	[JsonProperty("numSamples")]
	int NumSamples { get; set; }

	[JsonProperty("numGoodSamples")]
	int NumGoodSamples { get; set; }

	[JsonProperty("numNotGoodSamples")]
	int NumNotGoodSamples { get; set; }

	[JsonProperty("modelHealth")]
	float ModelHealth { get; set; }
}
