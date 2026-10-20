using System;
using System.IO;
using System.Threading.Tasks;
using Cognex.Extensions;
using Cognex.Utilities.Sdk.Internal;
using NLog;
using Newtonsoft.Json;

namespace Cognex.Platform;

public class PersistentState
{
	private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

	public bool InFailSafe { get; set; }

	public PlatformState State { get; set; }

	public PlatformStateError Error { get; set; }

	public FirmwareUpdateStates StartupFirmwareState { get; set; } = FirmwareUpdateStates.UpdateAllowed;

	public BackupRestoreStates StartupBackupState { get; set; } = BackupRestoreStates.Allowed;

	public bool PendingFirmwareUpdate { get; set; }

	private static string FilePath => Path.Combine(PlatformConfiguration.DataFolderPath, "configs", "persistentState_25.1.0.json");

	public PersistentState Clone()
	{
		return new PersistentState
		{
			InFailSafe = InFailSafe,
			State = State,
			Error = Error,
			StartupFirmwareState = StartupFirmwareState,
			StartupBackupState = StartupBackupState,
			PendingFirmwareUpdate = PendingFirmwareUpdate
		};
	}

	public bool IsDifferentState(PersistentState otherState)
	{
		if (otherState.State == State)
		{
			return otherState.Error != Error;
		}
		return true;
	}

	public static PersistentState Load()
	{
		PersistentState persistentState = null;
		try
		{
			if (File.Exists(FilePath))
			{
				persistentState = JsonConvert.DeserializeObject<PersistentState>(File.ReadAllText(FilePath));
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to load the settings\n" + ex);
		}
		return persistentState ?? CreateDefaultOptionsAndSave();
	}

	public static async Task Save(PersistentState options)
	{
		try
		{
			string value = JsonConvert.SerializeObject(options);
			using FileStream writer = File.Create(FilePath);
			using StreamWriter streamWriter = new StreamWriter(writer);
			await streamWriter.WriteAsync(value);
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to save the settings\n" + ex);
		}
	}

	public static PersistentState CreateDefaultOptionsAndSave()
	{
		PersistentState persistentState = new PersistentState
		{
			InFailSafe = false,
			State = PlatformState.Unknown,
			Error = PlatformStateError.None,
			PendingFirmwareUpdate = false,
			StartupFirmwareState = FirmwareUpdateStates.UpdateAllowed,
			StartupBackupState = BackupRestoreStates.Allowed
		};
		Save(persistentState).IgnoreResult();
		return persistentState;
	}

	public static PersistentState CreateDefaultOptions(PlatformState state, PlatformStateError error = PlatformStateError.None)
	{
		return new PersistentState
		{
			InFailSafe = false,
			State = state,
			Error = error,
			PendingFirmwareUpdate = false,
			StartupFirmwareState = FirmwareUpdateStates.UpdateAllowed,
			StartupBackupState = BackupRestoreStates.Allowed
		};
	}

	public static PersistentState CreateStartingOrStoppedState(PlatformState previousState)
	{
		return new PersistentState
		{
			InFailSafe = false,
			State = ((previousState == PlatformState.Starting) ? PlatformState.Starting : PlatformState.Stopped),
			Error = PlatformStateError.None,
			PendingFirmwareUpdate = false,
			StartupFirmwareState = FirmwareUpdateStates.UpdateAllowed,
			StartupBackupState = BackupRestoreStates.Allowed
		};
	}

	public override string ToString()
	{
		return "{" + State.ToString() + "," + Error.ToString() + "}";
	}
}
