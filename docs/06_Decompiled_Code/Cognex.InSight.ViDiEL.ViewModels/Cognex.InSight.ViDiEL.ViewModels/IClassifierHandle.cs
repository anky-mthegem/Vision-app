namespace Cognex.InSight.ViDiEL.ViewModels;

public interface IClassifierHandle
{
	string ToolName { get; set; }

	string InitialImagesPath { get; }

	bool InitialImagesPathHasImages { get; }

	Classifier GetClassifier();

	CvsCellLocation GetCellLocation();
}
