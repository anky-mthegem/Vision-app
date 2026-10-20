using System;

namespace Cognex.InSight;

[Serializable]
public enum CvsInSightError
{
	None = 0,
	NetworkException = -2147221504,
	InvalidLogonException = -2147221503,
	SensorAlreadyConnectedException = -2147221502,
	NotConnectedException = -2147221496,
	ExpressionException = -2147221493
}
