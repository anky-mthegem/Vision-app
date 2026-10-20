namespace Cognex.Platform;

public enum PlatformState
{
	Stopped = 0,
	Starting = 1,
	Running = 2,
	NotInstalled = 3,
	Stopping = 4,
	Failed = 7,
	Failsafe = 8,
	Unknown = 9
}
