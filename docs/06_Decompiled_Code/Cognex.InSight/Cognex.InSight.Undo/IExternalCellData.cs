namespace Cognex.InSight.Undo;

public interface IExternalCellData
{
	bool IsModified { get; }

	string GetID();

	void Delete();

	void Restore();

	string CopyPaste();

	void UnCopyPaste();
}
