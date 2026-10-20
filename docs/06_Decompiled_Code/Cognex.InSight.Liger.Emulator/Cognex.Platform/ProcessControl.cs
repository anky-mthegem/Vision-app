using System.Collections.Generic;

namespace Cognex.Platform;

public class ProcessControl
{
	public bool EnableController { get; set; }

	public string ApiVersion { get; set; }

	public string IpAddress { get; set; }

	public int MaxCameras { get; set; }

	public KeyValuePair<string, string>[] Capablities { get; set; }

	public CamEmulation[] EmulationSettings { get; set; }
}
