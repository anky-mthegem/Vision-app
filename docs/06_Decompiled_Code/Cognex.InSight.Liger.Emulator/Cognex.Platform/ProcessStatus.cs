namespace Cognex.Platform;

public class ProcessStatus
{
	public string Name { get; set; }

	public string ProcessId { get; set; }

	public string State { get; set; }

	public ProcessStatus Clone()
	{
		return new ProcessStatus
		{
			Name = Name,
			ProcessId = ProcessId,
			State = State
		};
	}
}
