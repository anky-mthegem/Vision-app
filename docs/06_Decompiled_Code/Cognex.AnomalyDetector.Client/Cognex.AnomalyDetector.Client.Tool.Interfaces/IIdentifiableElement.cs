using Newtonsoft.Json;

namespace Cognex.AnomalyDetector.Client.Tool.Interfaces;

public interface IIdentifiableElement
{
	[JsonProperty("id")]
	string Id { get; set; }
}
