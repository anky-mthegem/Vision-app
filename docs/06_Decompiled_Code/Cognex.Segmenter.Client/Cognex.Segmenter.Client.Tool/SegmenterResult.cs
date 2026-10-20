using Cognex.Segmenter.Client.Tool.Interfaces;

namespace Cognex.Segmenter.Client.Tool;

public class SegmenterResult : ISegmenterResult, IImageResult
{
	public string image { get; set; }

	public IMaskBitmap overlayImage { get; set; }

	public bool isTrained { get; set; }
}
