using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public sealed class CvsExpressionException : CvsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsExpressionException()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nOX4xBTt2ooeb5jLyYF();
		int num = ((!YF3LkAT7L44lUWlPLLM()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 2:
				eMvWUSTKL82fRB8WGef(this, -2147221493);
				num = 5;
				continue;
			case 1:
			case 4:
				base._002Ector((string)dcKT0bTCP9n7xxF1Jav());
				goto case 2;
			case 5:
				return;
			}
			num = 2;
			if (!YF3LkAT7L44lUWlPLLM())
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsExpressionException(string message)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!YF3LkAT7L44lUWlPLLM()) ? 4 : 3);
		do
		{
			IL_003d:
			switch (num)
			{
			case 1:
				base._002Ector(message);
				break;
			case 0:
			case 3:
				H0Df3eT5lHstQUH1pZq();
				num = 1;
				goto IL_003d;
			case 5:
				return;
			}
			eMvWUSTKL82fRB8WGef(this, -2147221493);
			num = 5;
		}
		while (!nOX4xBTt2ooeb5jLyYF());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsExpressionException(string message, Exception innerException)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!YF3LkAT7L44lUWlPLLM())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_001e:
		base._002Ector(message, innerException);
		goto IL_0065;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			default:
				goto IL_0065;
			case 3:
				goto IL_007a;
			case 5:
				return;
			}
			break;
			IL_007a:
			H0Df3eT5lHstQUH1pZq();
			nOX4xBTt2ooeb5jLyYF();
			num = ((!YF3LkAT7L44lUWlPLLM()) ? 4 : 0);
		}
		goto IL_001e;
		IL_0065:
		eMvWUSTKL82fRB8WGef(this, -2147221493);
		num = 5;
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private CvsExpressionException(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YF3LkAT7L44lUWlPLLM();
		int num = (nOX4xBTt2ooeb5jLyYF() ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				base._002Ector(info, context);
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 0:
			case 3:
				H0Df3eT5lHstQUH1pZq();
				goto case 1;
			case 5:
				return;
			}
			eMvWUSTKL82fRB8WGef(this, -2147221493);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dcKT0bTCP9n7xxF1Jav()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ExpressionException;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eMvWUSTKL82fRB8WGef(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0).HResult = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YF3LkAT7L44lUWlPLLM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nOX4xBTt2ooeb5jLyYF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H0Df3eT5lHstQUH1pZq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}
}
