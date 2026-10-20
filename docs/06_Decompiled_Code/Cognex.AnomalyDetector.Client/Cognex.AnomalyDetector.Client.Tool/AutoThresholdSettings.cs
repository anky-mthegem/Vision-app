using Cognex.AnomalyDetector.Client.Tool.Interfaces;

namespace Cognex.AnomalyDetector.Client.Tool;

public class AutoThresholdSettings : IAutoThresholdSettings
{
	public bool UseAutoThreshold { get; set; }

	public AutoThresholdOptions SelectedOption { get; set; }

	public AutoThresholdSettings(bool useAutoThreshold, AutoThresholdOptions selectedOption)
	{
		SelectedOption = selectedOption;
		UseAutoThreshold = useAutoThreshold;
	}
}
