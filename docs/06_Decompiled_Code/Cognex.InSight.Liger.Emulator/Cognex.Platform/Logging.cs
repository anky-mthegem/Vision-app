using System;
using System.Diagnostics;

namespace Cognex.Platform;

public static class Logging
{
	public static void CreateLogger()
	{
		try
		{
			if (!EventLog.SourceExists("Cognex In-Sight"))
			{
				EventLog.CreateEventSource("Cognex In-Sight", "Cognex In-Sight");
			}
		}
		catch (Exception)
		{
		}
	}

	public static void Log(string message, EventLogEntryType type)
	{
		try
		{
			EventLog.WriteEntry("Cognex In-Sight", message, type);
		}
		catch (Exception)
		{
		}
	}

	public static void LogError(string msg)
	{
		Log(msg, EventLogEntryType.Error);
	}

	public static void LogError(string format, params object[] args)
	{
		try
		{
			Log(string.Format(format, args), EventLogEntryType.Error);
		}
		catch (FormatException)
		{
			Log("Error logging " + format, EventLogEntryType.Error);
		}
	}

	public static void LogWarning(string msg)
	{
		Log(msg, EventLogEntryType.Warning);
	}

	public static void LogInfo(string msg)
	{
		Log(msg, EventLogEntryType.Information);
	}

	public static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			EventLog.WriteEntry("Cognex In-Sight", e.ExceptionObject.ToString(), EventLogEntryType.Error);
		}
		catch (Exception ex)
		{
			LogError("Unhandled exception\n" + ex);
		}
	}
}
