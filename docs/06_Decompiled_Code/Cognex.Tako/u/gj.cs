using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace u;

[Serializable]
internal class gj : Exception
{
	public const string u = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";

	protected gj(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	public gj(string P_0, Exception P_1)
		: base(P_0, P_1)
	{
	}

	public gj(string P_0)
		: base(P_0)
	{
	}
}
[NativeCppClass]
internal enum gJ
{

}
