using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.Color;

namespace Cognex.InSight.Services;

public interface ITrainMatchColorService
{
	Task<ColorMatchModel[]> GetAllModels();

	Task UpdateModelSettings(ModelId modelId, ColorMatchModelSettings settings);

	Task RemoveModel(ModelId modelId);

	Task<ColorMatchModel> Retrain(ModelId modelId, CvsCogShape shape);

	Task<ColorMatchModel> TrainNewModel(CvsCogShape shape);

	Task<string> GetLibraryName();

	Task SetLibraryName(string name);
}
