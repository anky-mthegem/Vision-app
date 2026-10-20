using System.Collections.Generic;
using Cognex.Explorer.Common.AppServices;

namespace Cognex.Explorer.Common;

public interface IEntryPoint
{
	void Start(IAppService service, string actionName, Dictionary<string, object> arguments);

	void Stop();
}
