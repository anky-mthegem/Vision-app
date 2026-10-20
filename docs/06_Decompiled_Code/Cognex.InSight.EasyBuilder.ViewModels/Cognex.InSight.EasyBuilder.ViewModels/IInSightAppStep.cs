using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Cognex.InSight.Cell;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public interface IInSightAppStep
{
	EasyBuilderApplicationViewModel AppViewModel { get; set; }

	CvsInSight InSight { get; set; }

	ObservableCollection<EzSnippet> Snippets { get; }

	Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading);

	Task CompleteInitializationAsync(ISnippetManager snippetManager);

	void Refresh(CvsCellCollection cells);
}
