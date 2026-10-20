using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps;

public interface IToolPropertyCollection
{
	string AddMenuText { get; }

	void Add(CellViewModel model);
}
