using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace u;

[Serializable]
internal class gc : Exception
{
	protected gc(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	public gc(string P_0, Exception P_1)
		: base(P_0, P_1)
	{
	}

	public gc(string P_0)
		: base(P_0)
	{
	}
}
[NativeCppClass]
internal enum gC
{

}
