using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Diagnostics;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public static class CvsTraceSDK
{
	public static readonly CnxTraceChannel Critical;

	public static readonly CnxTraceChannel Error;

	public static readonly CnxTraceChannel Info;

	public static readonly CnxTraceChannel RxCogSocket;

	public static readonly CnxTraceChannel RxPayloadCogSocket;

	public static readonly CnxTraceChannel TxCogSocket;

	public static readonly CnxTraceChannel Events;

	public static readonly CnxTraceChannel Svg;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsTraceSDK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 8:
				Svg = new CnxTraceChannel(kgbOBx7BanbFa22Hp9.ol99ukmDA(42402), (string)YbPmULGtarDFnwPk5Mv(42428), TraceLevel.Info, CnxTraceVisibility.Public);
				num = 11;
				break;
			case 9:
				TxCogSocket = new CnxTraceChannel((string)YbPmULGtarDFnwPk5Mv(42302), kgbOBx7BanbFa22Hp9.ol99ukmDA(42326), TraceLevel.Info, CnxTraceVisibility.Public, vmBob0GCQ6dW9V3gMok());
				num = 4;
				break;
			case 6:
				RxPayloadCogSocket = new CnxTraceChannel((string)YbPmULGtarDFnwPk5Mv(42220), (string)YbPmULGtarDFnwPk5Mv(42258), TraceLevel.Info, CnxTraceVisibility.Public, vmBob0GCQ6dW9V3gMok());
				num = 9;
				break;
			case 2:
				RxCogSocket = new CnxTraceChannel((string)YbPmULGtarDFnwPk5Mv(42168), (string)YbPmULGtarDFnwPk5Mv(42192), TraceLevel.Info, CnxTraceVisibility.Public);
				goto case 6;
			default:
				num = 6;
				break;
			case 1:
			case 7:
				Critical = new CnxTraceChannel((string)YbPmULGtarDFnwPk5Mv(41988), kgbOBx7BanbFa22Hp9.ol99ukmDA(42024), TraceLevel.Error, CnxTraceVisibility.Public, enabled: true);
				num = 10;
				break;
			case 4:
				Events = new CnxTraceChannel((string)YbPmULGtarDFnwPk5Mv(42354), kgbOBx7BanbFa22Hp9.ol99ukmDA(42386), TraceLevel.Info, CnxTraceVisibility.Public);
				num = 8;
				break;
			case 10:
				Error = new CnxTraceChannel((string)YbPmULGtarDFnwPk5Mv(42068), (string)YbPmULGtarDFnwPk5Mv(42098), TraceLevel.Error, CnxTraceVisibility.Public, enabled: true);
				goto case 0;
			case 0:
			case 3:
				Info = new CnxTraceChannel((string)YbPmULGtarDFnwPk5Mv(42120), (string)YbPmULGtarDFnwPk5Mv(42148), TraceLevel.Info, CnxTraceVisibility.Public);
				num = 2;
				if (iRxFtcG7iNtqAuqPBWH())
				{
				}
				break;
			case 5:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				iRxFtcG7iNtqAuqPBWH();
				if (!ulS0UvGWdpCo7LiR5ri())
				{
					num = 0;
					break;
				}
				num = 7;
				if (!ulS0UvGWdpCo7LiR5ri())
				{
					return;
				}
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YbPmULGtarDFnwPk5Mv(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vmBob0GCQ6dW9V3gMok()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Debugger.IsAttached;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ulS0UvGWdpCo7LiR5ri()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iRxFtcG7iNtqAuqPBWH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
