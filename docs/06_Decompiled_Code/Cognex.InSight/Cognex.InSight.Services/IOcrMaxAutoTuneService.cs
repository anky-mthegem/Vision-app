using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.Services;

public interface IOcrMaxAutoTuneService : IOcrMaxService
{
	Task SetLastSessionPath(string autoTuneSessionPath);

	Task<string> GetLastSessionPath();

	Task StartAutoTuneMode();

	Task<CvsOcrMaxAutoTuneResultObject[]> AutoSegment(string trainString, CancellationToken cancellationToken);

	Task<CvsOcrMaxAutoTuneRecord[]> AutoTune(int recordIndex);

	Task<CvsOcrMaxAutoSegmentGraphics> GetAutoSegmentGraphics(int resultIndex);

	Task<CvsOcrMaxAutoTuneRecord[]> DeleteRecordInModel(int recordIndex);

	Task<CvsOcrMaxAutoTuneExit> ExitAutoTuneMode(bool commitSegmentation, bool commitFont);

	Task<CvsOcrMaxAutoTuneRecord[]> SetAutoTuneRegions(CvsOcrMaxAutoTuneRegions regions, CancellationToken cancellationToken);

	Task<byte[]> ExportAutoTuneModel();

	Task<CvsOcrMaxAutoTuneRecord[]> ImportAutoTuneModel(byte[] importedData);

	Task SetAutoTuneParameters(CvsOcrMaxAutoTuneParams parameters);

	Task<CvsOcrMaxAutoTuneParams> GetAutoTuneParameters();

	Task<CvsOcrMaxAutoTuneRecord[]> AddRecord(string trainString);

	Task<CvsOcrMaxAutoTuneRecord[]> UseCurrentAsModel(int recordIndex);

	Task<ImageBytes> GetModelImageAndGraphics(int recordIndex);

	Task<ImageBytes[]> GetAutoTuneFontImages();

	Task<CvsOcrMaxFont> GetAutoTuneFont();

	Task<IEnumerable<string>> GetSavedModelNames();

	Task<byte[]> GetSavedAutoTuneModelData(string modelName);

	Task SetAutoTuneModelData(string modelName, byte[] data);

	Task AddAutoTuneModelData(Dictionary<string, byte[]> dataDictionary);

	Task ClearAutoTuneData(string modelName);

	Task<CvsOcrMaxAutoTuneRecord[]> GetAutoTuneRecords();
}
