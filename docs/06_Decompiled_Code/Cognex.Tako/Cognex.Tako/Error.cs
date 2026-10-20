using System;

namespace Cognex.Tako;

public class Error : Exception
{
	public Error(string error)
		: base(error)
	{
	}
}
