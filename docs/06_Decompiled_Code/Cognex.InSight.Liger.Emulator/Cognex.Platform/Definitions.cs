using System;
using System.IO;

namespace Cognex.Platform;

internal static class Definitions
{
	public enum CogNamerApplicationId : byte
	{
		Main,
		Failsafe,
		Diags,
		Emulator,
		FailsafeEmulator
	}

	public const string RuntimeVersion = "25.1.0";

	public const string JsonExtension = ".json";

	public const string OptionsFile = "platformoptions_25.1.0.json";

	public const string StateFile = "persistentState_25.1.0.json";

	public const string BackupConfigFilename = "backupconfig_25.1.0.json";

	public const string ProductName = "In-Sight Vision Suite";

	public static readonly string SoftwareControllerProductName = "Cognex In-Sight Vision Suite 9.9.9";

	public const string CoguserdApplicationName = "coguserd";

	public const string LigerApplicationName = "InSightSheets";

	public const string CogNamerApplicationName = "CogNamerServer";

	public const string SecurityService = "cogss3_srv";

	public const string InstallerLogFile = "installer.log";

	public const string UserFile = "users.json";

	public const string BackupConfigFile = "backupconfig25.1.0.json";

	public const string Company = "Cognex\\In-Sight";

	public const string Product = "Cognex In-Sight";

	public const string GetRegisteredPortsUrl = "getPorts";

	public const string GetStatusUrl = "getStatus";

	public const string PutControlUrl = "putControl";

	public const string GetApplicationUrl = "getControlApplication";

	public const string PutApplicationUrl = "putControlApplication";

	public const string GetEmulationModesUrl = "getEmulationModes";

	public const string GetCurrentEmulationModesUrl = "getCurrentEmulationMode";

	public const string GetOperationalModeUrl = "getOperationalMode";

	public const string GetPlatformConfigUrl = "getPlatformConfig";

	public const string PutOperationalModeUrl = "putMode";

	public const string PutEmulationConfigurationUrl = "putEmulationConfiguration";

	public const string GetProductInfoUrl = "getProductInfo";

	public const string GetOverlordConfigUrl = "getOverlordConfig";

	public const string PutOverlordConfigUrl = "putOverlordConfig";

	public const string MonitorStartedUrl = "MonitorOn";

	public const string MonitorExitUrl = "MonitorOff";

	public const string RuntimeStartUrl = "ControllerAppOn";

	public const string RuntimeCloseUrl = "ControllerAppOff";

	public const string RuntimeFailedUrl = "ControllerAppFailed";

	public const string ControllerStatusUrl = "service/controller/status";

	public const string PlatformStatusUrl = "service/platform/status";

	public const string ActionOkResponse = "OK";

	public const string ActionErrorResponse = "ERROR";

	public const string InFailSafeResponse = "FAILSAFE";

	public const string ConfigFolder = "configs";

	public const string BackupWorkingFolder = "backupfiles";

	public const string BackupZipFile = "backup.bak";

	public const string LogFolder = "log";

	public const string BackupFolder = "backup";

	public const string FirmwareFolder = "firmware";

	public const string PubfsFolder = "pubfs";

	public const string PubfsImagesFolder = "pubfs/Images";

	public const string ControllerApiVersion = "9.9.9";

	public const string CognexSignatureSubject = "CN=Cognex Corporation, O=Cognex Corporation, L=Natick, S=Massachusetts, C=US";

	public const string InSightFolder = "Cognex\\In-Sight\\In-Sight";

	public static readonly string EmulatorControllerRoot = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cognex", "In-Sight Emulator");

	public static readonly string PortRegistryFilePath = Path.Combine(EmulatorControllerRoot, "sheetsPortRegistry.json");

	public const uint BringToFrontMessageId = 1025u;

	public const int CogNamerPort = 1069;
}
