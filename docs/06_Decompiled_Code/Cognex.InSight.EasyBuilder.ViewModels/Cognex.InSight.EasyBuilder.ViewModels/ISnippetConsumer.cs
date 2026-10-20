using System.Threading.Tasks;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public interface ISnippetConsumer
{
	Task AddDefaultReferences(SnippetAddedEventArgs e);

	Task RemoveReferences(SnippetPreRemoveEventArgs e);

	Task RenameReferences(SnippetRenamedEventArgs e);
}
