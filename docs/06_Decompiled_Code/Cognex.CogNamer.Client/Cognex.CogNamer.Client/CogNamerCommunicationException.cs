using System;

namespace Cognex.CogNamer.Client;

public class CogNamerCommunicationException : CogNamerException
{
	public CogNamerCommunicationException(Exception ex)
		: base(ex.Message)
	{
	}

	public CogNamerCommunicationException(string message)
		: base(message)
	{
	}
}
