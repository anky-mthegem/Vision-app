using System;

namespace Cognex.Explorer.Common.AppServices;

public interface IWindowHostService : IHostService
{
	IntPtr GetParentHandle();

	bool IsEnabled();

	void SetEnabled(bool isEnabled, bool activate);

	void RequestClose(bool force);
}
