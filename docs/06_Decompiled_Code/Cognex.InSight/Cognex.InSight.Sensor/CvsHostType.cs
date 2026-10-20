using System;

namespace Cognex.InSight.Sensor;

public enum CvsHostType
{
	Server = 0,
	Unknown = 1,
	HostTableEntry = 2,
	InSightEmulator = 3,
	InSightSensor = 4,
	Browser = 5,
	[Obsolete("InSightEmulator should be used instead")]
	PC = InSightEmulator,
	InSightController = InSightSensor
}
