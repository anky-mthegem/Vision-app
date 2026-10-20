using System.Threading.Tasks;
using Cognex.InSight.Controls.Display.Views.Wpf.Test;

namespace Cognex.InSight.Services;

public interface ICaliperMethodService
{
	Task<CvsCogCaliperScoringMethod[]> GetCaliperScoringMethods();

	Task<CvsCogCaliperScoringMethod> GetScoringMethod(int index);

	Task SetCaliperScoringMethods(CvsCogCaliperScoringMethod[] methods);

	Task UpdateCaliperScoringMethod(int index, CvsCogCaliperScoringMethod methodObject);

	Task ResetAllScoringMethods();
}
