using System;

namespace Cognex.InSight.Internal;

internal interface IOnlineOfflineService
{
	bool IsOnline { get; }

	event EventHandler IsOnlineChanged;
}
