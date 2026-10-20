namespace Cognex.CogNamer.Client;

public class CogNamerTrace : ICogNamerTrace
{
	void ICogNamerTrace.TraceError(string message)
	{
	}

	void ICogNamerTrace.WriteLine(string message)
	{
	}

	void ICogNamerTrace.WriteLineIf(bool warning, string message)
	{
	}

	public static void TraceError(string message)
	{
		WriteLine("Trace: " + message);
	}

	public static void WriteLine(string message)
	{
	}

	public static void WriteLineIf(bool warning, string message)
	{
	}
}
