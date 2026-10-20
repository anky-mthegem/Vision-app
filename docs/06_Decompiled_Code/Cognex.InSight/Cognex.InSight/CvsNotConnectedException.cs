using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public sealed class CvsNotConnectedException : CvsCommunicationException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsNotConnectedException()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QRBrpATBFyBTtauLNCw();
		int num;
		if (!rtpUVDTjoMUXqYOmosG())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0071;
		IL_0054:
		base._002Ector((string)PwUvadTcAiRmorHTeDA());
		goto IL_003f;
		IL_0071:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 2:
				goto IL_003f;
			case 1:
			case 3:
				goto IL_0054;
			default:
				num = 2;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		goto IL_0054;
		IL_003f:
		ChTCFlT2hrmbp59Zq8V(this, -2147221496);
		num = 5;
		goto IL_0071;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsNotConnectedException(string message)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rtpUVDTjoMUXqYOmosG();
		int num;
		if (QRBrpATBFyBTtauLNCw())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (!QRBrpATBFyBTtauLNCw())
			{
				goto IL_0083;
			}
		}
		goto IL_0041;
		IL_0041:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				base._002Ector(message);
				break;
			default:
				goto IL_005e;
			case 0:
			case 2:
				xPoAcbTWsoRaLFdctLg();
				goto case 1;
			case 3:
				break;
			case 5:
				return;
			}
			break;
			IL_005e:
			num = 3;
		}
		goto IL_0083;
		IL_0083:
		HResult = -2147221496;
		num = 5;
		if (rtpUVDTjoMUXqYOmosG())
		{
		}
		goto IL_0041;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsNotConnectedException(string message, Exception innerException)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				base._002Ector(message, innerException);
				break;
			case 4:
				xPoAcbTWsoRaLFdctLg();
				rtpUVDTjoMUXqYOmosG();
				if (!QRBrpATBFyBTtauLNCw())
				{
					num = 3;
					continue;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 5:
				return;
			}
			ChTCFlT2hrmbp59Zq8V(this, -2147221496);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private CvsNotConnectedException(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rtpUVDTjoMUXqYOmosG();
		int num;
		if (QRBrpATBFyBTtauLNCw())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (rtpUVDTjoMUXqYOmosG())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				ChTCFlT2hrmbp59Zq8V(this, -2147221496);
				num = 5;
				break;
			case 1:
			case 3:
				base._002Ector(info, context);
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 2:
				xPoAcbTWsoRaLFdctLg();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PwUvadTcAiRmorHTeDA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NotConnectedException;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChTCFlT2hrmbp59Zq8V(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0).HResult = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QRBrpATBFyBTtauLNCw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rtpUVDTjoMUXqYOmosG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xPoAcbTWsoRaLFdctLg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}
}
