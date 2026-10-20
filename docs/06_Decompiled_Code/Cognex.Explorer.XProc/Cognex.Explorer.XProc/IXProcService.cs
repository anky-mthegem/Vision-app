using System;
using Cognex.Explorer.Common.AppServices;

namespace Cognex.Explorer.XProc;

public interface IXProcService
{
	bool IsRunning { get; }

	event EventHandler<EventArgs> Exited;

	event EventHandler<EventArgs> Started;

	void AddHostService(Type serviceType, IHostService service);

	T GetService<T>();

	void Start();

	void Stop(int timeout = 5000);
}
