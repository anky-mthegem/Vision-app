using System;

namespace Cognex.Cnx.Serialization.Implementation;

public interface ICnxDirectMemoryStream
{
	int Read(IntPtr buffer, int count);

	void Write(IntPtr buffer, int count);
}
