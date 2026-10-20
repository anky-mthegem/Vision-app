namespace Cognex.Ocr.Client.Tool;

public class FieldingSettings
{
	public string FieldingType { get; set; }

	public string AcceptedCharacters { get; set; }

	public int? NumberOfLines { get; set; }

	public FieldingPattern[] Patterns { get; set; }

	public string FlexibleFieldingValue { get; set; }

	public string FlexibleFieldingReference { get; set; }
}
