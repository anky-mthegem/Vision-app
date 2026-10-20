using System;

namespace Cognex.Platform;

public interface IIpcServer : IDisposable
{
	event EventHandler<string> Received;

	void Start();

	void Stop();
}
