using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization.Color;

namespace Cognex.InSight.Services;

public interface IMatchColorService
{
	Task<ColorMatchModel[]> GetAvailableModels();

	Task<ModelId[]> GetEnabledIds();

	Task SetEnabledModels(ModelId[] models);
}
