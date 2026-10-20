using Cognex.AnomalyDetector.Client.Tool.Interfaces;

namespace Cognex.AnomalyDetector.Client.Tool;

public class AnomalyDetectorStats : IAnomalyDetectorStats
{
	public int NumSamples { get; set; }

	public int NumGoodSamples { get; set; }

	public int NumNotGoodSamples { get; set; }

	public float ModelHealth { get; set; }
}
