using System;

namespace Cognex.Cnx.ComponentModel;

public interface ICnxReferenceCount : IDisposable
{
	int AddReference();
}
