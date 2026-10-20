namespace Cognex.Segmenter.Client.Tool.Interfaces;

public interface ISegmenterSample : IIdentifiableElement
{
	string image { get; set; }

	IMaskBitmap labelImage { get; set; }
}
