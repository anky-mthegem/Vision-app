using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cognex.Explorer.Common.AppServices;

namespace Cognex.Explorer.XProc;

public interface IXProc
{
	void Start(IAppService service, string entryPoint, string action, Dictionary<string, object> arguments);

	[OneWay]
	void Stop();
}
