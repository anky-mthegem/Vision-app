using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.Services;

public interface IOcrMaxService
{
	Task<CvsOcrMaxSettings> GetSettings();

	Task SetSettings(CvsOcrMaxSettings settings);

	Task ResetSettings();

	Task ClearAll();

	Task RelabelInstance(int index, string newLabel);

	Task RemoveInstance(int index);

	Task TrainAll(string trainString);

	Task TrainNew(string trainString);

	Task TrainSingle(int segmentedCharacterIndex, string trainCharacter, OcrMaxTrainSingleMode trainMode, bool trainEvent);

	Task PrepareOCRMaxForTraining(bool trainMode);

	Task SetFontName(string fontName);

	Task<CvsOcrMaxFont> GetFont();

	Task<CvsOcrMaxResult> GetResults();

	Task<ImageBytes[]> GetResultImages();

	Task<ImageBytes[]> GetFontImages();

	Task ImportFont(CvsOcrMaxExportedFont font);

	Task<CvsOcrMaxExportedFont> ExportFont();

	Task<CvsOcrMaxDiagnosticData> GetTextDiagnostics();

	Task StartOcrMaxSession();

	Task EndOcrMaxSession();
}
