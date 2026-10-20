using System;
using System.Collections.Generic;
using System.Linq;

namespace Cognex.Platform;

public class OperationalModeBase
{
	public PlatformMode PlatformMode { get; set; }

	public List<CamEmulation> EmulationSettings { get; set; }

	public void UpdateEmulationSettings(OperationalModeBase toCopy)
	{
		if (toCopy == null)
		{
			throw new ArgumentNullException("toCopy");
		}
		if (EmulationSettings == null)
		{
			EmulationSettings = new List<CamEmulation>();
		}
		List<CamEmulation> emulationSettings = toCopy.EmulationSettings;
		if (emulationSettings != null && emulationSettings.Any())
		{
			EmulationSettings = toCopy.EmulationSettings.Select((CamEmulation s) => new CamEmulation(s)).ToList();
		}
	}

	public bool HasSameEmulationSettingsAs(OperationalModeBase other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (EmulationSettings == null)
		{
			throw new NullReferenceException("EmulationSettings");
		}
		foreach (CamEmulation emuSetting in EmulationSettings)
		{
			CamEmulation camEmulation = other?.EmulationSettings?.FirstOrDefault((CamEmulation e) => e?.CamSlot == emuSetting?.CamSlot);
			if (camEmulation == null || !camEmulation.HasSameSettingsAs(emuSetting))
			{
				return false;
			}
		}
		return true;
	}
}
