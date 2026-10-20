using Cognex.AnomalyDetector.Client.Tool.Interfaces;

namespace Cognex.AnomalyDetector.Client.Tool;

public class FeatureSizeSettings : IFeatureSizeSettings
{
	public double Minimum { get; set; }

	public double Maximum { get; set; }

	public double CurrentValue { get; set; }
}
