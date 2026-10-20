using System;
using System.Linq;

namespace Cognex.Platform;

public class InSightControllerState
{
	public bool Enabled { get; set; }

	public bool IsRunning { get; set; }

	public ProcessStatus[] ProcessStatuses { get; set; }

	public bool ReadFailure { get; set; }

	public DateTime StartTime { get; set; } = DateTime.MinValue;

	public DateTime StopTime { get; set; } = DateTime.MinValue;

	public InSightControllerState Clone()
	{
		return new InSightControllerState
		{
			Enabled = Enabled,
			IsRunning = IsRunning,
			ProcessStatuses = ProcessStatuses?.Select((ProcessStatus p) => p.Clone()).ToArray(),
			ReadFailure = ReadFailure,
			StartTime = StartTime,
			StopTime = StopTime
		};
	}
}
