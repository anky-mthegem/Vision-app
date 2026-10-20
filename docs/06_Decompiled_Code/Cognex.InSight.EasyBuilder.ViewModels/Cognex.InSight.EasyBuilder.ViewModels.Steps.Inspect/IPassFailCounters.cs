using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;

public interface IPassFailCounters
{
	IntViewModel PassCount { get; }

	IntViewModel FailCount { get; }

	IntViewModel ErrorCount { get; }

	IntViewModel TotalCount { get; }
}
