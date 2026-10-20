namespace Cognex.CogNamer.Client;

public interface ICogNamerTrace
{
	void TraceError(string message);

	void WriteLine(string message);

	void WriteLineIf(bool warning, string message);
}
