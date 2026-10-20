namespace Cognex.Cnx.ComponentModel;

public interface ICnxAsyncMethod
{
	event CnxCompletedEventHandler Completed;

	void Start();

	void Abort();

	int GetProgress(out string status);
}
