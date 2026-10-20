using System.Collections.Generic;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization.Color;

namespace Cognex.InSight.Services;

public interface IExtractColorService : IBaseIToolCustomService
{
	Task<string> GetLibraryName();

	Task<Dictionary<string, ExtractColorGroup>> GetAllGroups();

	Task EnableGroup(int groupId, bool enabled);
}
