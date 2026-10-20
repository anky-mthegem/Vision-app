namespace Cognex.InSight.Undo;

public interface IMergeableUndoAction
{
	bool CanMerge(IUndoAction undoAction);

	void MergeInto(IUndoAction undoAction);
}
