using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;

namespace u;

[Serializable]
internal class gu : gj
{
	private const string P = "\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n";

	private Exception b;

	public Exception n
	{
		get
		{
			return b;
		}
		set
		{
			b = ex;
		}
	}

	protected gu(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
		n = (Exception)P_0.GetValue("NestedException", typeof(Exception));
	}

	public gu(string P_0, Exception P_1, Exception P_2)
		: base(P_0, P_1)
	{
		n = P_2;
	}

	public override string ToString()
	{
		string text = ((InnerException == null) ? string.Empty : InnerException.ToString());
		string text2 = ((n == null) ? string.Empty : n.ToString());
		object[] array = new object[4]
		{
			GetType(),
			null,
			null,
			null
		};
		string text3 = ((Message == null) ? string.Empty : Message);
		array[1] = text3;
		string text4 = ((text == null) ? string.Empty : text);
		array[2] = text4;
		string text5 = ((text2 == null) ? string.Empty : text2);
		array[3] = text5;
		return string.Format("\n{0}: {1}\n--- Start of primary exception ---\n{2}\n--- End of primary exception ---\n\n--- Start of nested exception ---\n{3}\n--- End of nested exception ---\n", array);
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		base.GetObjectData(P_0, P_1);
		P_0.AddValue("NestedException", n, typeof(Exception));
	}
}
[NativeCppClass]
internal enum gU
{

}
