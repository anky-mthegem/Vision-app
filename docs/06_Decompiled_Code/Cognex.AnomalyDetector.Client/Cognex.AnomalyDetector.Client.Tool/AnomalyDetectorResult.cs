using Cognex.AnomalyDetector.Client.Tool.Interfaces;

namespace Cognex.AnomalyDetector.Client.Tool;

public class AnomalyDetectorResult : IAnomalyDetectorResult
{
	public string Image { get; set; }

	public string Heatmap { get; set; }

	public float Score { get; set; }

	public string SampleId { get; set; }

	public bool IsPredictionGood { get; set; }
}
