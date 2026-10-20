using System;

namespace Cognex.Platform;

public class ControllerApplicationState
{
	public bool Enabled { get; set; }

	public bool IsRunning { get; set; }

	public DateTime StartTime { get; set; }

	public DateTime StopTime { get; set; }

	public ControllerApplicationState Clone()
	{
		return new ControllerApplicationState
		{
			Enabled = Enabled,
			IsRunning = IsRunning,
			StartTime = StartTime,
			StopTime = StopTime
		};
	}
}
