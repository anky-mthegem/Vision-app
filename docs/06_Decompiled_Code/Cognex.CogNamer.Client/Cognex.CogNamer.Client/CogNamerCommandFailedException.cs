namespace Cognex.CogNamer.Client;

public class CogNamerCommandFailedException : CogNamerException
{
	public int ErrorCode { get; private set; }

	public CogNamerCommandFailedException(int errorcode, string message)
		: base(message)
	{
		ErrorCode = errorcode;
	}
}
