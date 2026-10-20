using Newtonsoft.Json;

namespace Cognex.Platform;

public class BackupConfig
{
	[JsonProperty(PropertyName = "sysFiles", NullValueHandling = NullValueHandling.Include)]
	public string[] SystemFiles;

	[JsonProperty(PropertyName = "userFiles", NullValueHandling = NullValueHandling.Include)]
	public string[] UserFolders;
}
