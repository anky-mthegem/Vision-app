namespace Cognex.Segmenter.Client.Tool.Interfaces;

public interface ISegmenterResult : IImageResult
{
	IMaskBitmap overlayImage { get; set; }

	bool isTrained { get; set; }
}
