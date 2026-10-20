namespace Cognex.InSight;

public interface ICvsSpreadSheetSimpleCellDefinition
{
	string Expression { get; set; }

	string Name { get; set; }

	int Row { get; set; }

	int Col { get; set; }

	bool InputFlag { get; set; }

	bool FatalIfNotSupported { get; set; }
}
