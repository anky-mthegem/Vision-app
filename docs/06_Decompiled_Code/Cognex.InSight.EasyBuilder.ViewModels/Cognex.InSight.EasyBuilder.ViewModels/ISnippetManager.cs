using System.Threading.Tasks;
using Cognex.InSight.Cell;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public interface ISnippetManager
{
	Task<CvsCellRange> GetSnippetLocation(CvsCellRange range, bool isRight = false);

	Task<CvsCellRange> GetSnippetLocation(CvsCellCollection cells, CvsCellRange range, bool isRight = false);
}
