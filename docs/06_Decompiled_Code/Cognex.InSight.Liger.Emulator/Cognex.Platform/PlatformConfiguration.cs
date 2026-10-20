using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NLog;
using Newtonsoft.Json;

namespace Cognex.Platform;

public class PlatformConfiguration
{
	private static readonly object _lock = new object();

	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	public const int DefaultResolutionWidth = 640;

	public const int DefaultResolutionHeight = 480;

	public const string vgaResolution = "640x480";

	public const int MaxPossibleCameras = 4;

	public PlatformStartupMode StartupMode { get; set; }

	public int MaintenancePort { get; set; }

	public int HttpPort { get; set; }

	public int FtpPort { get; set; }

	public int HttpsPort { get; set; }

	public int SshPort { get; set; }

	public int TelnetPort { get; set; }

	public int Type { get; set; }

	public int SubType { get; set; }

	public string HostIP { get; set; }

	public string NetworkAdapterId { get; set; }

	public string MinimumFirmware { get; set; }

	public int StatusPollIntervalInSec { get; set; }

	public List<string> DiscoveredCameras { get; set; }

	public int MaxCameras { get; set; }

	public bool IsEmulationLicensed { get; set; }

	public bool AtLastStartWasFaulted { get; set; }

	public bool IsLicensed { get; set; }

	public List<string> Licenses { get; set; }

	public bool AutoElevelatePermissionsWhenEmulated { get; set; }

	public DateTime LastStart { get; set; }

	public bool IpOverride { get; set; }

	public List<ConfiguredOperationalMode> OperationModes { get; set; }

	public PlatformMode CurrentOperationMode { get; set; }

	public StartupOperation StartupOperation { get; set; }

	public static int Hash { get; set; }

	public static string FilePath => Path.Combine(DataFolderPath, "configs", "platformoptions_25.1.0.json");

	[JsonIgnore]
	public bool IsEmulating
	{
		get
		{
			if (CurrentOperationMode != PlatformMode.ViDiPcProduction)
			{
				return CurrentOperationMode != PlatformMode.None;
			}
			return false;
		}
	}

	[JsonIgnore]
	public List<CamEmulation> EmulationList => OperationModes.FirstOrDefault((ConfiguredOperationalMode m) => m.PlatformMode == CurrentOperationMode)?.EmulationSettings ?? new List<CamEmulation>();

	[JsonIgnore]
	public ConfiguredOperationalMode CurrentEmulationModeConfiguration => OperationModes.FirstOrDefault((ConfiguredOperationalMode m) => m.PlatformMode == CurrentOperationMode);

	private static string DefaultEmulationFolder => Path.Combine(DataFolderPath, "pubfs");

	public static List<CamEmulation> DefaultCamEmulation => new List<CamEmulation>
	{
		new CamEmulation
		{
			CamSlot = "cam0",
			Resolution = "640x480",
			Directory = Path.Combine(DataFolderPath, "pubfs/Images"),
			Enabled = true,
			IsResolutionChangeSupported = true
		},
		new CamEmulation
		{
			CamSlot = "cam1",
			Resolution = "640x480",
			Directory = Path.Combine(DataFolderPath, "pubfs/Images"),
			Enabled = true,
			IsResolutionChangeSupported = true
		},
		new CamEmulation
		{
			CamSlot = "cam2",
			Resolution = "640x480",
			Directory = Path.Combine(DataFolderPath, "pubfs/Images"),
			Enabled = true,
			IsResolutionChangeSupported = true
		},
		new CamEmulation
		{
			CamSlot = "cam3",
			Resolution = "640x480",
			Directory = Path.Combine(DataFolderPath, "pubfs/Images"),
			Enabled = true,
			IsResolutionChangeSupported = true
		}
	};

	public static string DataFolderPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Cognex\\In-Sight\\In-Sight ViDi PC", "25.1.0");

	public static PlatformConfiguration Load(bool defaultIfMissing, int maxCameras = 4, PlatformMode defaultMode = PlatformMode.None)
	{
		PlatformConfiguration platformConfiguration = null;
		try
		{
			if (maxCameras == 0)
			{
				Logger.Warn("No licensed cameras, allow the configuration to have 1.");
				maxCameras = 1;
			}
			string text;
			lock (_lock)
			{
				if (!File.Exists(FilePath))
				{
					return defaultIfMissing ? CreateDefaultOptions(maxCameras) : null;
				}
				text = File.ReadAllText(FilePath);
			}
			Hash = text.GetHashCode();
			platformConfiguration = JsonConvert.DeserializeObject<PlatformConfiguration>(text);
			if (platformConfiguration.OperationModes == null)
			{
				platformConfiguration.CurrentOperationMode = defaultMode;
				platformConfiguration.OperationModes = CreateSupportedOperationModes(DefaultCamEmulation);
			}
			else
			{
				foreach (ConfiguredOperationalMode operationMode in platformConfiguration.OperationModes)
				{
					if (operationMode == null)
					{
						continue;
					}
					int num = Math.Min(maxCameras, operationMode.NumberOfCameras);
					int num2 = operationMode.EmulationSettings?.Count ?? 0;
					List<CamEmulation> emulationSettings = operationMode.EmulationSettings;
					if (emulationSettings == null || !emulationSettings.Any() || operationMode.EmulationSettings.Count != num)
					{
						List<CamEmulation> emulationSettings2 = operationMode.EmulationSettings;
						operationMode.EmulationSettings = new List<CamEmulation>();
						if (emulationSettings2 != null)
						{
							operationMode.EmulationSettings.AddRange(emulationSettings2);
						}
						operationMode.EmulationSettings.AddRange(DefaultCamEmulation);
						Logger.Warn($"No emulation settings found in {operationMode.Name}, or number changed from {num2} to {num} using defaults");
					}
					CheckEmulationList(operationMode.EmulationSettings);
					operationMode.EmulationSettings = operationMode.EmulationSettings.Take(num).ToList();
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to load the settings\n" + ex);
		}
		PlatformConfiguration platformConfiguration2 = platformConfiguration;
		if (platformConfiguration2 == null)
		{
			if (!defaultIfMissing)
			{
				return null;
			}
			platformConfiguration2 = CreateDefaultOptions(maxCameras);
		}
		return platformConfiguration2;
	}

	public static void Save(PlatformConfiguration options)
	{
		try
		{
			string text = JsonConvert.SerializeObject(options, Formatting.Indented);
			Hash = text.GetHashCode();
			lock (_lock)
			{
				using FileStream stream = File.Create(FilePath);
				using StreamWriter streamWriter = new StreamWriter(stream);
				streamWriter.WriteAsync(text).Wait();
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to save the settings\n" + ex);
		}
	}

	public static void CheckEmulationList(List<CamEmulation> info)
	{
		if (info == null)
		{
			return;
		}
		int num = 0;
		foreach (CamEmulation item in info)
		{
			item.CamSlot = $"cam{num++}";
			item.Directory = (string.IsNullOrWhiteSpace(item.Directory) ? DefaultEmulationFolder : item.Directory);
			item.Resolution = (string.IsNullOrWhiteSpace(item.Resolution) ? "640x480" : item.Resolution);
		}
	}

	public static PlatformConfiguration CreateDefaultOptions(int maxCameras = 4)
	{
		StartupOperation startupOperation = new StartupOperation
		{
			Mode = PlatformMode.None,
			Version = "IS ViDi 25.1.0"
		};
		PlatformConfiguration platformConfiguration = new PlatformConfiguration
		{
			StartupMode = PlatformStartupMode.UserLogin,
			HostIP = "127.0.0.1",
			LastStart = DateTime.MinValue,
			MaintenancePort = 8084,
			HttpPort = 80,
			HttpsPort = 443,
			FtpPort = 21,
			SshPort = 22,
			TelnetPort = 23,
			MinimumFirmware = "0.0.0.0",
			StatusPollIntervalInSec = 10,
			Type = 10,
			SubType = 3,
			MaxCameras = maxCameras,
			DiscoveredCameras = new List<string>(),
			CurrentOperationMode = PlatformMode.None,
			StartupOperation = startupOperation,
			OperationModes = CreateSupportedOperationModes(DefaultCamEmulation.Take(maxCameras).ToList())
		};
		Save(platformConfiguration);
		return platformConfiguration;
	}

	public static List<ConfiguredOperationalMode> CreateSupportedOperationModes(List<CamEmulation> emulationConfiguration)
	{
		string directory = (emulationConfiguration.Any() ? emulationConfiguration[0].Directory : Path.Combine(DataFolderPath, "pubfs/Images"));
		return new List<ConfiguredOperationalMode>
		{
			new ConfiguredOperationalMode
			{
				PlatformMode = PlatformMode.D905M,
				Name = "In-Sight D905M",
				NumberOfCameras = 1,
				EmulationSettings = new List<CamEmulation>
				{
					new CamEmulation
					{
						CamSlot = "cam0",
						Resolution = "2448x2048",
						Directory = directory,
						Enabled = true,
						IsResolutionChangeSupported = false
					}
				}
			},
			new ConfiguredOperationalMode
			{
				PlatformMode = PlatformMode.D902M,
				Name = "In-Sight D902M",
				NumberOfCameras = 1,
				EmulationSettings = new List<CamEmulation>
				{
					new CamEmulation
					{
						CamSlot = "cam0",
						Resolution = "1920x1200",
						Directory = directory,
						Enabled = true,
						IsResolutionChangeSupported = false
					}
				}
			},
			new ConfiguredOperationalMode
			{
				PlatformMode = PlatformMode.ViDiPcEmulation,
				Name = "In-Sight ViDi PC",
				NumberOfCameras = emulationConfiguration.Count,
				EmulationSettings = emulationConfiguration
			}
		};
	}
}
