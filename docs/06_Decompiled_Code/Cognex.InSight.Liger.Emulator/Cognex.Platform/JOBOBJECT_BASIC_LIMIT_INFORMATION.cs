using System;

namespace Cognex.Platform;

public struct JOBOBJECT_BASIC_LIMIT_INFORMATION
{
	public long PerProcessUserTimeLimit;

	public long PerJobUserTimeLimit;

	public JOBOBJECTLIMIT LimitFlags;

	public UIntPtr MinimumWorkingSetSize;

	public UIntPtr MaximumWorkingSetSize;

	public uint ActiveProcessLimit;

	public long Affinity;

	public uint PriorityClass;

	public uint SchedulingClass;
}
