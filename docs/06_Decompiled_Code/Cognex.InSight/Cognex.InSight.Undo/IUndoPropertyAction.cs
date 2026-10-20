namespace Cognex.InSight.Undo;

public interface IUndoPropertyAction : IUndoAction
{
	CvsCellLocation DropLocation { get; set; }

	CvsInSight InSight { get; set; }

	CvsCellRange[] ModifiedCells { get; }

	CvsCellRange ValuesRange { get; }
}
