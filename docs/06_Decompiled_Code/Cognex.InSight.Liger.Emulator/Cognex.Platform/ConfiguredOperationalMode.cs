using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cognex.Platform;

public class ConfiguredOperationalMode : OperationalModeBase
{
	public string Name { get; set; }

	public int NumberOfCameras { get; set; }

	public bool IsResolutionConfigurable { get; set; }

	public ConfiguredOperationalMode Clone()
	{
		ConfiguredOperationalMode configuredOperationalMode = new ConfiguredOperationalMode();
		configuredOperationalMode.Name = Name;
		configuredOperationalMode.PlatformMode = PlatformMode;
		configuredOperationalMode.NumberOfCameras = NumberOfCameras;
		configuredOperationalMode.IsResolutionConfigurable = IsResolutionConfigurable;
		configuredOperationalMode.EmulationSettings = new List<CamEmulation>();
		configuredOperationalMode.UpdateEmulationSettings(this);
		return configuredOperationalMode;
	}

	public OperationalMode CreateOperationalMode()
	{
		OperationalMode operationalMode = new OperationalMode();
		operationalMode.PlatformMode = PlatformMode;
		operationalMode.UpdateEmulationSettings(this);
		return operationalMode;
	}

	public override string ToString()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}
}
