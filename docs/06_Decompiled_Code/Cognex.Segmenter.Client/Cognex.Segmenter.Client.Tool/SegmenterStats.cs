using Cognex.Segmenter.Client.Tool.Interfaces;

namespace Cognex.Segmenter.Client.Tool;

public class SegmenterStats : ISegmenterStats
{
	public int numClasses { get; set; }

	public int numSamples { get; set; }

	public float modelHealth { get; set; }

	public int maxNumClasses { get; set; }
}
