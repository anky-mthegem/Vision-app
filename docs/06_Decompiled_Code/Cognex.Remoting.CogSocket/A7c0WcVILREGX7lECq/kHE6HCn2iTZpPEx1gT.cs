using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Remoting;
using Cognex.Remoting.CogSocket;
using IawbpyxeWauKVJvQ4t;
using WebSocketSharp;
using WebSocketSharp.Server;
using kxduZxr85lI9sYTvcZ;
using swW0OkHZDnPhGmp0Jx;
using yFqFqrNb1tZ9uvfT9p;

namespace A7c0WcVILREGX7lECq;

internal class kHE6HCn2iTZpPEx1gT : WebSocketBehavior, eHevCLhAWrFr1omhrY, IMessagePayloadPreview
{
	private static readonly JsonRemoteSerializer f89iaK5Lr5;

	private CogSocket fDFi0P3QAR;

	[CompilerGenerated]
	private EventHandler V8EicHcBU9;

	[CompilerGenerated]
	private EventHandler FFTi1SwKDf;

	[CompilerGenerated]
	private EventHandler<CogSocketErrorArgs> cUDiThM6Cs;

	[CompilerGenerated]
	private EventHandler<GwKxq4dal8dyreJLBV> PSuieXWbkE;

	[CompilerGenerated]
	private EventHandler<MessagePayloadPreviewEventArgs> bb5iErtyd9;

	public event EventHandler Opened
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					eventHandler = V8EicHcBU9;
					num = 6;
					if (qmyCELDRi7EkXZgu9gQ())
					{
						break;
					}
					goto case 5;
				case 5:
					value2 = (EventHandler)hs1WXrDEWQoZy2rpkKZ(eventHandler2, eventHandler3);
					goto default;
				default:
					_ = 0;
					num = ((!qmyCELDRi7EkXZgu9gQ()) ? 2 : 0);
					break;
				case 0:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref V8EicHcBU9, value2, eventHandler2);
					goto case 2;
				case 6:
					eventHandler2 = eventHandler;
					num = 5;
					break;
				case 2:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 6;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			do
			{
				IL_007b:
				switch (num)
				{
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						goto IL_007b;
					}
					goto case 1;
				case 1:
				case 3:
					eventHandler2 = eventHandler;
					goto case 0;
				case 4:
					eventHandler = V8EicHcBU9;
					qmyCELDRi7EkXZgu9gQ();
					num = ((!uVyujUDZWixHDFsw4Ig()) ? 3 : 0);
					goto IL_007b;
				case 0:
				case 2:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value3);
					break;
				default:
					num = 5;
					goto IL_007b;
				case 5:
					break;
				case 7:
					return;
				}
				eventHandler = Interlocked.CompareExchange(ref V8EicHcBU9, value2, eventHandler2);
				num = 6;
			}
			while (true);
		}
	}

	public event EventHandler Closed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (qmyCELDRi7EkXZgu9gQ())
			{
				num = 5;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
				if (false)
				{
					return;
				}
			}
			goto IL_006f;
			IL_0044:
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = eventHandler2;
			num = 2;
			goto IL_006f;
			IL_006f:
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
				case 4:
					goto IL_0044;
				case 2:
					value2 = (EventHandler)hs1WXrDEWQoZy2rpkKZ(eventHandler, eventHandler3);
					break;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					goto IL_0044;
				case 0:
				case 5:
					eventHandler2 = FFTi1SwKDf;
					goto IL_0044;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			eventHandler2 = Interlocked.CompareExchange(ref FFTi1SwKDf, value2, eventHandler);
			num = 6;
			if (uVyujUDZWixHDFsw4Ig())
			{
				goto IL_0044;
			}
			goto IL_006f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref FFTi1SwKDf, value2, eventHandler2);
					goto case 2;
				case 5:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value3);
					goto default;
				default:
					_ = 1;
					num = (uVyujUDZWixHDFsw4Ig() ? 2 : 0);
					break;
				case 1:
					eventHandler = FFTi1SwKDf;
					num = 6;
					break;
				case 6:
					eventHandler2 = eventHandler;
					num = 5;
					break;
				case 2:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 6;
				case 7:
					return;
				}
			}
		}
	}

	public new event EventHandler<CogSocketErrorArgs> Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketErrorArgs> eventHandler = cUDiThM6Cs;
			EventHandler<CogSocketErrorArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketErrorArgs> value2 = (EventHandler<CogSocketErrorArgs>)Delegate.Combine(eventHandler2, b);
				eventHandler = Interlocked.CompareExchange(ref cUDiThM6Cs, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketErrorArgs> eventHandler = cUDiThM6Cs;
			EventHandler<CogSocketErrorArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketErrorArgs> value2 = (EventHandler<CogSocketErrorArgs>)Delegate.Remove(eventHandler2, value3);
				eventHandler = Interlocked.CompareExchange(ref cUDiThM6Cs, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GwKxq4dal8dyreJLBV> Message
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<GwKxq4dal8dyreJLBV> eventHandler = PSuieXWbkE;
			EventHandler<GwKxq4dal8dyreJLBV> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GwKxq4dal8dyreJLBV> value2 = (EventHandler<GwKxq4dal8dyreJLBV>)Delegate.Combine(eventHandler2, b);
				eventHandler = Interlocked.CompareExchange(ref PSuieXWbkE, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<GwKxq4dal8dyreJLBV> eventHandler = PSuieXWbkE;
			EventHandler<GwKxq4dal8dyreJLBV> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GwKxq4dal8dyreJLBV> value2 = (EventHandler<GwKxq4dal8dyreJLBV>)Delegate.Remove(eventHandler2, value3);
				eventHandler = Interlocked.CompareExchange(ref PSuieXWbkE, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<MessagePayloadPreviewEventArgs> PreviewMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<MessagePayloadPreviewEventArgs> eventHandler = bb5iErtyd9;
			EventHandler<MessagePayloadPreviewEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<MessagePayloadPreviewEventArgs> value2 = (EventHandler<MessagePayloadPreviewEventArgs>)Delegate.Combine(eventHandler2, b);
				eventHandler = Interlocked.CompareExchange(ref bb5iErtyd9, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<MessagePayloadPreviewEventArgs> eventHandler = bb5iErtyd9;
			EventHandler<MessagePayloadPreviewEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<MessagePayloadPreviewEventArgs> value2 = (EventHandler<MessagePayloadPreviewEventArgs>)Delegate.Remove(eventHandler2, value3);
				eventHandler = Interlocked.CompareExchange(ref bb5iErtyd9, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static kHE6HCn2iTZpPEx1gT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XBmaHrDkGXpl1Pu9KJf();
		f89iaK5Lr5 = new JsonRemoteSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public kHE6HCn2iTZpPEx1gT(IRemoteResourceRoot P_0, IRemoteSerializer P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector();
				goto default;
			default:
				fDFi0P3QAR = new CogSocket(this, P_0, P_1);
				num = 5;
				break;
			case 0:
				XBmaHrDkGXpl1Pu9KJf();
				_ = 0;
				if (!qmyCELDRi7EkXZgu9gQ())
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto default;
				}
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public CogSocket bPmiALwEMq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fDFi0P3QAR;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnMessage(MessageEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uVyujUDZWixHDFsw4Ig();
		int num = ((!qmyCELDRi7EkXZgu9gQ()) ? 4 : 2);
		byte[] array = default;
		CogSocketMessage cogSocketMessage = default;
		kHE6HCn2iTZpPEx1gT kHE6HCn2iTZpPEx1gT2 = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				array = new byte[4] { 0, 0, 224, 128 };
				num = 10;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				if (PSuieXWbkE != null)
				{
					num = 5;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				return;
			case 1:
			case 4:
				b52VlFv0Wl((MessagePayloadPreviewEventArgs)FVNpsuDN4cPAZxATQiL(P_0.Data));
				num = 9;
				if (uVyujUDZWixHDFsw4Ig())
				{
				}
				break;
			case 0:
			case 2:
				if (VPoIkwDnXgB0ICoBHHZ(P_0))
				{
					goto case 1;
				}
				if (yb8OaZDUVFxIGgYM7d0(P_0))
				{
					num = 3;
					break;
				}
				return;
			case 9:
				cogSocketMessage = f89iaK5Lr5.Deserialize<CogSocketMessage>(P_0.Data);
				num = 8;
				break;
			case 5:
				PSuieXWbkE(this, new GwKxq4dal8dyreJLBV(cogSocketMessage));
				return;
			default:
				num = 6;
				break;
			case 10:
				kHE6HCn2iTZpPEx1gT2 = this;
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				lockTaken = false;
				num = 11;
				break;
			case 6:
				return;
			case 11:
				try
				{
					Monitor.Enter(kHE6HCn2iTZpPEx1gT2, ref lockTaken);
					XuQxXsDoqL11ygHaiGt(this, array);
					return;
				}
				finally
				{
					if (lockTaken)
					{
						BCU13lDKIGodbcaHxsh(kHE6HCn2iTZpPEx1gT2);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void Close()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnOpen()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qmyCELDRi7EkXZgu9gQ();
		int num;
		if (!uVyujUDZWixHDFsw4Ig())
		{
			num = 4;
			if (!qmyCELDRi7EkXZgu9gQ())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_006c;
		IL_0049:
		V8EicHcBU9(this, EventArgs.Empty);
		goto IL_0099;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 2:
				goto IL_0049;
			default:
				num = 3;
				if (!uVyujUDZWixHDFsw4Ig())
				{
					continue;
				}
				goto IL_0099;
			case 3:
				goto IL_0099;
			case 5:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		if (V8EicHcBU9 != null)
		{
			goto IL_0049;
		}
		goto IL_0099;
		IL_0099:
		lCESLWDIMaOTenvcrfn(this);
		num = 5;
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnClose(CloseEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 5:
				fDFi0P3QAR = null;
				num = 8;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				if (FFTi1SwKDf != null)
				{
					_ = 1;
					num = (uVyujUDZWixHDFsw4Ig() ? 4 : 6);
					break;
				}
				goto case 0;
			case 0:
				base.OnClose(P_0);
				goto case 3;
			case 2:
				TD1DFEDeUMijLoRWVlv(fDFi0P3QAR);
				num = 5;
				break;
			case 3:
			case 4:
				if (fDFi0P3QAR != null)
				{
					goto case 2;
				}
				return;
			default:
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 6:
				JEqjTfDaHs24sVaQT9n(FFTi1SwKDf, this, EventArgs.Empty);
				num = 0;
				if (uVyujUDZWixHDFsw4Ig())
				{
					return;
				}
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnError(ErrorEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qmyCELDRi7EkXZgu9gQ();
		int num;
		if (!uVyujUDZWixHDFsw4Ig())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_0058;
			}
		}
		goto IL_0087;
		IL_0087:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 3:
				if (cUDiThM6Cs == null)
				{
					break;
				}
				goto IL_0058;
			case 1:
			case 4:
				goto IL_0058;
			default:
				num = 2;
				if (uVyujUDZWixHDFsw4Ig())
				{
				}
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_0058:
		cUDiThM6Cs(this, new CogSocketErrorArgs((string)QrXiJfDXmFkRC3WG1TJ(P_0), (Exception)CBxMhVDwIRK4t4d8Lor(P_0)));
		goto IL_002a;
		IL_002a:
		MF1PDDDTAhMhlldpykl(this, P_0);
		num = 5;
		goto IL_0087;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Connect()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		throw new InvalidOperationException((string)idZYahD1OWfqGJKyxvH(1216));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(CogSocketMessage P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (qmyCELDRi7EkXZgu9gQ())
		{
			num = 3;
			if (uVyujUDZWixHDFsw4Ig())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0066;
		IL_0052:
		kHE6HCn2iTZpPEx1gT obj = this;
		goto IL_0046;
		IL_0066:
		bool lockTaken = default;
		string data = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 2:
				goto IL_0046;
			case 1:
			case 4:
				goto IL_0052;
			default:
				num = 2;
				if (uVyujUDZWixHDFsw4Ig())
				{
				}
				continue;
			case 5:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					Send(data);
					return;
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		data = (string)xu5t7nD3eeAFSkp5DqG(f89iaK5Lr5, P_0);
		goto IL_0052;
		IL_0046:
		lockTaken = false;
		num = 5;
		goto IL_0066;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void b52VlFv0Wl(MessagePayloadPreviewEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		EventHandler<MessagePayloadPreviewEventArgs> eventHandler = default;
		while (true)
		{
			switch (num)
			{
			default:
				eventHandler(this, P_0);
				num = 5;
				break;
			case 4:
				eventHandler = bb5iErtyd9;
				_ = 0;
				if (qmyCELDRi7EkXZgu9gQ())
				{
					num = 3;
					if (qmyCELDRi7EkXZgu9gQ())
					{
						break;
					}
					goto case 1;
				}
				num = 0;
				break;
			case 1:
			case 3:
				if (eventHandler != null)
				{
					goto default;
				}
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool eHevCLhAWrFr1omhrY.LockAndPing(TimeSpan P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		throw new NotImplementedException((string)idZYahD1OWfqGJKyxvH(1340));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XBmaHrDkGXpl1Pu9KJf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qmyCELDRi7EkXZgu9gQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uVyujUDZWixHDFsw4Ig()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VPoIkwDnXgB0ICoBHHZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MessageEventArgs)P_0).IsText;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FVNpsuDN4cPAZxATQiL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MessagePayloadPreviewEventArgs.Incoming(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yb8OaZDUVFxIGgYM7d0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MessageEventArgs)P_0).IsBinary;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XuQxXsDoqL11ygHaiGt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WebSocketBehavior)P_0).Send((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BCU13lDKIGodbcaHxsh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lCESLWDIMaOTenvcrfn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WebSocketBehavior)P_0).OnOpen();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JEqjTfDaHs24sVaQT9n(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TD1DFEDeUMijLoRWVlv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CogSocket)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QrXiJfDXmFkRC3WG1TJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ErrorEventArgs)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CBxMhVDwIRK4t4d8Lor(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ErrorEventArgs)P_0).Exception;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MF1PDDDTAhMhlldpykl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WebSocketBehavior)P_0).OnError((ErrorEventArgs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object idZYahD1OWfqGJKyxvH(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UNkfE94JEjYP98PsqC.cGFu3AUnFy(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xu5t7nD3eeAFSkp5DqG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JsonRemoteSerializer)P_0).SerializeObject(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hs1WXrDEWQoZy2rpkKZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}
}
