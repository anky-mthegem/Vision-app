using System;

namespace Cognex.InSight;

[Serializable]
public enum CvsInSightStateChangedReason
{
	Normal,
	Timeout,
	Restart
}
