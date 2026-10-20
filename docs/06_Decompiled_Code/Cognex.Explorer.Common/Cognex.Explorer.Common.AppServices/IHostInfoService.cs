using System;

namespace Cognex.Explorer.Common.AppServices;

public interface IHostInfoService : IHostService
{
	bool IsAlive { get; }

	string ProductName { get; }

	Version Version { get; }
}
