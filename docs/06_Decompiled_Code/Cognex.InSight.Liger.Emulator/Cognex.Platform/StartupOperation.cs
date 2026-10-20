using Newtonsoft.Json;

namespace Cognex.Platform;

public class StartupOperation
{
	public string Version { get; set; }

	public PlatformMode Mode { get; set; }

	public override string ToString()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}
}
