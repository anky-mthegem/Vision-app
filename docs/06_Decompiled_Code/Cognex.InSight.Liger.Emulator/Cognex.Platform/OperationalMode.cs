using Newtonsoft.Json;

namespace Cognex.Platform;

public class OperationalMode : OperationalModeBase
{
	public string ProductionHostIp { get; set; }

	public string ProductionNetworkId { get; set; }

	public PlatformStartupMode? StartupMode { get; set; }

	public int MaintenancePort { get; set; }

	public bool Faulted { get; set; }

	public OperationalMode Clone()
	{
		OperationalMode result = MemberwiseClone() as OperationalMode;
		UpdateEmulationSettings(this);
		return result;
	}

	public override string ToString()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}
}
