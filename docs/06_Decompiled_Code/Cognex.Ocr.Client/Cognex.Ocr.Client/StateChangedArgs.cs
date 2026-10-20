namespace Cognex.Ocr.Client;

public class StateChangedArgs
{
	public string ToolId { get; }

	public States State { get; }

	public StateChangedArgs(string toolId, States state)
	{
		ToolId = toolId;
		State = state;
	}
}
