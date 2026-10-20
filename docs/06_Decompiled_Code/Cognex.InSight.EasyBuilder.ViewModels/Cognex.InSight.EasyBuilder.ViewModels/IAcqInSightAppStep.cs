using System;
using System.Threading.Tasks;
using Cognex.InSight.Cell;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public interface IAcqInSightAppStep
{
	CvsInSight AcqInSight { get; }

	bool Supports(Guid guid);

	Task AddSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange);
}
