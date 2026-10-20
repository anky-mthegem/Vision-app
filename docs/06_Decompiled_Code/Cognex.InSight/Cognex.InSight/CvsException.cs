using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public abstract class CvsException : Exception
{
	public static readonly string DataDisplayMessageKey;

	public CvsInSightError ErrorNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsInSightError)EdgwJHUbju5hoxdDDWj(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsException()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xe2SZyUaTpP75xhBf0E();
		kA7H5cUnUyevGWsL2sd(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsException(string message)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xe2SZyUaTpP75xhBf0E();
		LDrie3UGebsdl1y98G3(this, message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsException(string message, Exception innerException)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(message, innerException);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected CvsException(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xe2SZyUaTpP75xhBf0E();
		NeKULMUXkllkQC5jUly(this, info, context);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsException()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		DataDisplayMessageKey = (string)kO2wGmU6Zq7W5XIXewO(8776);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xe2SZyUaTpP75xhBf0E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kA7H5cUnUyevGWsL2sd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tkC1JNUIiOuGwgw09h2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kRMv0QUR4JMmdthxLtV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LDrie3UGebsdl1y98G3(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0)._002Ector((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NeKULMUXkllkQC5jUly(object P_0, object P_1, StreamingContext P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0)._002Ector((SerializationInfo)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EdgwJHUbju5hoxdDDWj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).HResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kO2wGmU6Zq7W5XIXewO(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
