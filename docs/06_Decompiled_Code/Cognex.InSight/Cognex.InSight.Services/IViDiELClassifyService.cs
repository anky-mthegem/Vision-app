using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.ViDiEL;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Classify;

namespace Cognex.InSight.Services;

public interface IViDiELClassifyService
{
	Task<string[]> GetImageIds(string label);

	Task<CvsCogImage> GetImageInfo(string imageId);

	Task<double> GetModelHealth();

	Task<string> GetNextImageToLabel();

	Task<long> GetClassLabelImageCount(string label);

	Task<string[]> GetClassLabels();

	Task<BitmapImage> GetBitmap(string Imageid);

	Task<ELClassifyPredictedResult> GetPredictedResult(string imageId);

	Task<string[]> GetToolFailingClassNames();

	Task AddCurrentImageToUnlabeled();

	Task AddClass(string label);

	Task LabelCurrentImage(string label);

	Task RenameClass(string oldClassName, string newClassName);

	Task SetClassLabel(string imageId, string label);

	Task SetClassFailsTool(string label, bool failTool);

	Task Train();

	Task RemoveImage(string imageId);

	Task ClearClassLabel(string imageId);

	Task RemoveClassLabel(string label);

	Task SetProjectionParams(ELTunableProjectionParams tunableParams);

	Task<ELTunableProjectionParams> AutoTuneProjectionParameters();

	Task<ELTunableProjectionParams> GetProjectionParams();
}
