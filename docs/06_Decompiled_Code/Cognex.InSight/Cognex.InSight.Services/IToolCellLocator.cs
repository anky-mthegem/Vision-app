using System.Collections.Generic;

namespace Cognex.InSight.Services;

public interface IToolCellLocator
{
	IEnumerable<(CvsCellLocation location, string displayName)> GetColorLibraries();
}
