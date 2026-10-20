using System;
using System.IO;
using NLog;
using Newtonsoft.Json;

namespace Cognex.InSight.Liger.Emulator;

public class InSightSheetsPorts
{
	public const string ErrorStatus = "error";

	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	[JsonProperty("http_priority_1")]
	public int LowPriority { get; set; }

	[JsonProperty("http_priority_3")]
	public int MidPriority { get; set; }

	[JsonProperty("http_priority_2")]
	public int HighPriority { get; set; }

	[JsonProperty("trace")]
	public int Trace { get; set; }

	[JsonProperty("trigger")]
	public int Trigger { get; set; }

	[JsonProperty("http_web_hmi")]
	public int WebHmi { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; } = "";

	public static InSightSheetsPorts ReadAllPorts(string filepath)
	{
		try
		{
			return JsonConvert.DeserializeObject<InSightSheetsPorts>(File.ReadAllText(filepath));
		}
		catch (Exception arg)
		{
			Logger.Error($"Error getting InSightsheetsPorts: {arg}");
			return new InSightSheetsPorts
			{
				Status = "error"
			};
		}
	}

	public string Serialize()
	{
		return JsonConvert.SerializeObject(this);
	}
}
