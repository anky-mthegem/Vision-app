using System.Collections.Generic;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.Color;

namespace Cognex.InSight.Services;

public interface ITrainExtractColorService : IBaseIToolCustomService
{
	Task<string> GetLibraryName();

	Task SetLibraryName(string libraryName);

	Task<TrainExtractColorLibraryModelType> GetSelectedModelType();

	Task SetSelectedModelType(TrainExtractColorLibraryModelType modelType);

	Task<Dictionary<string, TrainExtractColorGroup>> GetAllGroups();

	Task<TrainExtractColorGroup> CreateGroup(string groupName = null);

	Task DeleteGroup(int groupId);

	Task RenameGroup(int groupId, string newName);

	Task SetSelectedGroup(int groupId);

	Task<CvsCogView> GetTrainEditView();

	Task<TrainExtractColorModel> TrainSingleColor(int groupId, CvsCogShape shape, TrainExtractColorModelOperation operation);

	Task<TrainExtractColorModel[]> TrainMultipleColors(int groupId, CvsCogShape shape, TrainExtractColorModelOperation operation, float minimumColorArea, float smoothing);

	Task DeleteColorModel(int groupId, int colorModelId);

	Task RenameColorModel(int groupId, int colorModelId, string newName);

	Task SetColorModelOrder(int groupId, int[] colorModelIds);

	Task SetColorModelHueTolerance(int groupId, int colorModelId, double tolerance);

	Task SetColorModelDarkMatteLineTolerance(int groupId, int colorModelId, double tolerance);

	Task SetColorModelLightMatteLineTolerance(int groupId, int colorModelId, double tolerance);

	Task SetColorModelHighlightLineTolerance(int groupId, int colorModelId, double tolerance);

	Task SetColorModelOperation(int groupId, int colorModelId, TrainExtractColorModelOperation operation);

	Task<TrainExtractColorSamples> GetColorSamples(int groupId, int colorModelId, int numSamples);
}
