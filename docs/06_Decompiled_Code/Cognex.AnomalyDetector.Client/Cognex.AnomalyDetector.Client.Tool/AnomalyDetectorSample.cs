using Cognex.AnomalyDetector.Client.Tool.Interfaces;

namespace Cognex.AnomalyDetector.Client.Tool;

public class AnomalyDetectorSample : IAnomalyDetectorSample, IIdentifiableElement
{
	public string Id { get; set; }

	public string Image { get; set; }

	public AnomalyDetectorLabels Label { get; set; }

	public long Date { get; set; }
}
