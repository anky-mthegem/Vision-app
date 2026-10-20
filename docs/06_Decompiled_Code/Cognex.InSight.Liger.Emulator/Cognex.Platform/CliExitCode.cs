namespace Cognex.Platform;

public enum CliExitCode
{
	FailedToSaveSettings,
	FailedToStartServices,
	FailedToStopServices,
	GeneralError,
	HandleStartupFailure,
	OtherProductRunning,
	SettingsSaved,
	StopSuccessful,
	SwcRunning,
	SwcStarting,
	SwcStateUnknown,
	UpdateUi,
	Success,
	RuntimeIsRunning,
	RuntimeNotRunning,
	ServiceIsRunning,
	ServiceNotRunning,
	InSightViDiPcIsRunning,
	InSightViDiPcNotRunning,
	FailedToQueryInfo
}
