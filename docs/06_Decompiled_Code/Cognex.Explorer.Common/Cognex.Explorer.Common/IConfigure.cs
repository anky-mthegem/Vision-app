namespace Cognex.Explorer.Common;

public interface IConfigure
{
	event ConfigureFinishedDelegate ConfigureFinished;

	void StartConfiguration();
}
