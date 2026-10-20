using System.Threading.Tasks;

namespace Cognex.InSight.Undo;

public interface IUndoAction
{
	string Text { get; }

	Task SaveState();

	Task Do();

	Task Redo();

	Task Undo();
}
