namespace Cognex.Segmenter.Client.Tool.Interfaces;

public interface IMaskBitmap
{
	byte[] byteArray { get; set; }

	int row { get; set; }

	int col { get; set; }
}
