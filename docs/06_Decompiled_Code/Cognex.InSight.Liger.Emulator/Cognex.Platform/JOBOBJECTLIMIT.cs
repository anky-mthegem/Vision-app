using System;

namespace Cognex.Platform;

[Flags]
public enum JOBOBJECTLIMIT : uint
{
	JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 0x2000u
}
