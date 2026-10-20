using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public class CvsNetworkException : CvsCommunicationException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsNetworkException()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (k5V9VbUfRGGdxOxRqu6() ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				base._002Ector((string)RFmENDUmnAgjxRcq9pL());
				break;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				du6pBvUFql5AI5f9Wx4();
				goto case 1;
			case 3:
				break;
			case 5:
				return;
			}
			b5sxNyUyKFlTMGKshLh(this, -2147221504);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsNetworkException(string message)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!k5V9VbUfRGGdxOxRqu6())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (k5V9VbUfRGGdxOxRqu6())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				du6pBvUFql5AI5f9Wx4();
				goto case 1;
			case 1:
			case 4:
				base._002Ector(message);
				break;
			default:
				num = 2;
				continue;
			case 2:
				break;
			case 5:
				return;
			}
			b5sxNyUyKFlTMGKshLh(this, -2147221504);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsNetworkException(string message, Exception innerException)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		k5V9VbUfRGGdxOxRqu6();
		int num = ((!bpeLNrUkT2KQqJt6Fi4()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector(message, innerException);
				break;
			default:
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 2:
				break;
			case 5:
				return;
			}
			HResult = -2147221504;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsNetworkException(Exception innerException)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!k5V9VbUfRGGdxOxRqu6())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				du6pBvUFql5AI5f9Wx4();
				num = 1;
				continue;
			case 1:
				base._002Ector(Resources.NetworkException, innerException);
				break;
			case 5:
				return;
			}
			b5sxNyUyKFlTMGKshLh(this, -2147221504);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected CvsNetworkException(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (bpeLNrUkT2KQqJt6Fi4())
		{
			num = 4;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_006a;
		IL_0026:
		b5sxNyUyKFlTMGKshLh(this, -2147221504);
		num = 5;
		goto IL_006a;
		IL_006a:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 4:
				du6pBvUFql5AI5f9Wx4();
				goto case 1;
			case 1:
			case 2:
				base._002Ector(info, context);
				break;
			default:
				goto IL_0087;
			case 5:
				return;
			}
			break;
			IL_0087:
			num = 3;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void du6pBvUFql5AI5f9Wx4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RFmENDUmnAgjxRcq9pL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NetworkException;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b5sxNyUyKFlTMGKshLh(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0).HResult = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bpeLNrUkT2KQqJt6Fi4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k5V9VbUfRGGdxOxRqu6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
