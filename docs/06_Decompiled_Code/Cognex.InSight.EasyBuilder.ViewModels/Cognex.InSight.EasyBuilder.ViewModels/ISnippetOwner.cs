using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Runtime.ViewModels.Cells;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public interface ISnippetOwner
{
	event Func<object, SnippetAddedEventArgs, Task> SnippetAdded;

	event Func<object, SnippetPreRemoveEventArgs, Task> SnippetPreRemove;

	event Func<object, SnippetRemoveEventArgs, Task> SnippetRemove;

	event SnippetRenamedEventHandler SnippetRenamed;

	bool Supports(Guid guid);

	Task AddSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange, SnippetAddedEventType action = SnippetAddedEventType.Located);

	Task UpdateSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange);

	bool SnippetNeedsUpdate(Guid guid, CvsCellCollection cells, CvsCellRange range);

	SourceLink[] GetSourceLinks(CellType reqDataType);

	IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePropertiesGrouped(CellViewModel targetProperty, Func<CellViewModel, bool> predicate = null);

	IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePrimitivesGrouped(CellViewModel targetProperty = null, Func<CellViewModel, bool> predicate = null);

	IEnumerable<CellViewModel> GetLinkableProperties();
}
