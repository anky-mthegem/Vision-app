namespace Cognex.Segmenter.Client.Tool.Interfaces;

public interface ISegmenterStats
{
	int numClasses { get; set; }

	int numSamples { get; set; }

	float modelHealth { get; set; }

	int maxNumClasses { get; set; }
}
