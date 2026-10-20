using Newtonsoft.Json;

namespace Cognex.Platform;

public class CamEmulation
{
	public string Model => string.Empty;

	public bool IsResolutionChangeSupported { get; set; }

	public string CamSlot { get; set; }

	public string Resolution { get; set; } = "640x480";

	public string Directory { get; set; }

	public bool Enabled { get; set; }

	public bool IsColor { get; set; }

	public bool Is2DLineScan { get; set; }

	public CamEmulation()
	{
	}

	public CamEmulation(CamEmulation toCopy)
	{
		Copy(toCopy);
	}

	public void Copy(CamEmulation toCopy)
	{
		CamSlot = toCopy.CamSlot;
		Resolution = toCopy.Resolution;
		Directory = toCopy.Directory;
		Enabled = toCopy.Enabled;
		IsResolutionChangeSupported = toCopy.IsResolutionChangeSupported;
		IsColor = toCopy.IsColor;
		Is2DLineScan = toCopy.Is2DLineScan;
	}

	public bool HasSameSettingsAs(CamEmulation other)
	{
		if (other == null)
		{
			return false;
		}
		if (other.Model == Model && other.IsResolutionChangeSupported == IsResolutionChangeSupported && other.CamSlot == CamSlot && other.Resolution == Resolution && other.Directory == Directory && other.Enabled == Enabled && other.IsColor == IsColor)
		{
			return other.Is2DLineScan == Is2DLineScan;
		}
		return false;
	}

	public override string ToString()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}
}
