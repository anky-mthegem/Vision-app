using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cognex.Utilities;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public abstract class SyncContextService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public EventHandler handler;

		public SyncContextService _003C_003E4__this;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass5_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NNYL1wsDvnMfFUnXhppb();
			qdlbXOsDHFCgvXUFeINn(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CInvokeEvent_003Eb__0(object cb)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			W75A3NsDVnsT1MA5qR9d(handler, _003C_003E4__this, EventArgs.Empty);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NNYL1wsDvnMfFUnXhppb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qdlbXOsDHFCgvXUFeINn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j1JW6HsDSGjGPddDKR7Y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NKwXWSsDEdbhZ9uellVv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void W75A3NsDVnsT1MA5qR9d(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0(P_1, (EventArgs)P_2);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0<T>
	{
		public EventHandler<T> handler;

		public SyncContextService _003C_003E4__this;

		public T args;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass6_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CInvokeEvent_003Eb__0(object cb)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			handler(_003C_003E4__this, args);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GIBNaCsDAQPqPQoNDgAy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q8WWjgsDDjvsX0iwlDQM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly SynchronizationContext CD7p4vY1Lm;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SynchronizationContext GetPreviousContextIfPump(SynchronizationContext current)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!nRuTL0BotVpKyvfrSUu()) ? 2 : 4);
		IAsyncPumpSyncContext asyncPumpSyncContext = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				asyncPumpSyncContext = current as IAsyncPumpSyncContext;
				goto case 1;
			case 3:
				current = (SynchronizationContext)ADiV4gBYqSWNdeZbX5i(asyncPumpSyncContext);
				num = 5;
				continue;
			case 1:
			case 2:
				if (asyncPumpSyncContext == null)
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				continue;
			case 5:
				break;
			}
			break;
		}
		return current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SynchronizationContext GetCurrentContext()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (SynchronizationContext)k9EaOPBNmlFc6syedCf(SynchronizationContext.Current);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SyncContextService()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (bv9h3DBP0rLdjnZGNRk())
		{
			goto IL_001e;
		}
		goto IL_0051;
		IL_001e:
		yFvppVBxCNJmfjLiYDQ();
		_ = 0;
		num = ((!nRuTL0BotVpKyvfrSUu()) ? 3 : 0);
		goto IL_0051;
		IL_0051:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 1:
				kUUy9jB18C3gTf451mO(this);
				goto IL_007e;
			default:
				goto IL_007e;
			case 5:
				return;
			}
			break;
			IL_007e:
			CD7p4vY1Lm = (SynchronizationContext)qmjQxIBr0sm8J1mtr4B();
			num = 5;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SyncContextService(SynchronizationContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bv9h3DBP0rLdjnZGNRk();
		int num;
		if (nRuTL0BotVpKyvfrSUu())
		{
			num = 3;
			if (!nRuTL0BotVpKyvfrSUu())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0046;
		IL_0073:
		CD7p4vY1Lm = (SynchronizationContext)k9EaOPBNmlFc6syedCf(context);
		num = 5;
		goto IL_0046;
		IL_0046:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 4;
				if (!bv9h3DBP0rLdjnZGNRk())
				{
					continue;
				}
				goto IL_0073;
			case 4:
				goto IL_0073;
			case 0:
			case 3:
				yFvppVBxCNJmfjLiYDQ();
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		base._002Ector();
		goto IL_0073;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InvokeEvent(EventHandler handler)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003C_003Ec__DisplayClass5_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 6:
				return;
			case 7:
				obj._003C_003E4__this = this;
				num = 0;
				break;
			case 2:
				obj.handler = handler;
				num = 7;
				break;
			case 0:
				if (obj.handler == null)
				{
					goto default;
				}
				if (CD7p4vY1Lm == null)
				{
					TGAMcOBO9kAcZOCn4wY(obj.handler, this, EventArgs.Empty);
					num = 9;
				}
				else
				{
					num = 3;
				}
				break;
			default:
				_ = 1;
				if (!bv9h3DBP0rLdjnZGNRk())
				{
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				num = 5;
				break;
			case 1:
				obj = new _003C_003Ec__DisplayClass5_0();
				num = 2;
				break;
			case 4:
			case 8:
				return;
			case 3:
				r8VO5bB3iRucFv59GHR(CD7p4vY1Lm, new SendOrPostCallback(obj._003CInvokeEvent_003Eb__0), null);
				return;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InvokeEvent<T>(EventHandler<T> handler, T args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass6_0<T> CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass6_0<T>();
		CS_0024_003C_003E8__locals9.handler = handler;
		CS_0024_003C_003E8__locals9._003C_003E4__this = this;
		CS_0024_003C_003E8__locals9.args = args;
		if (CS_0024_003C_003E8__locals9.handler == null)
		{
			return;
		}
		if (CD7p4vY1Lm != null)
		{
			CD7p4vY1Lm.Post([MethodImpl(MethodImplOptions.NoInlining)] (object cb) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				CS_0024_003C_003E8__locals9.handler(CS_0024_003C_003E8__locals9._003C_003E4__this, CS_0024_003C_003E8__locals9.args);
			}, null);
		}
		else
		{
			CS_0024_003C_003E8__locals9.handler(this, CS_0024_003C_003E8__locals9.args);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ADiV4gBYqSWNdeZbX5i(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IAsyncPumpSyncContext)P_0).PreviousContext;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nRuTL0BotVpKyvfrSUu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bv9h3DBP0rLdjnZGNRk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k9EaOPBNmlFc6syedCf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetPreviousContextIfPump((SynchronizationContext)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yFvppVBxCNJmfjLiYDQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kUUy9jB18C3gTf451mO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qmjQxIBr0sm8J1mtr4B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetCurrentContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r8VO5bB3iRucFv59GHR(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SynchronizationContext)P_0).Post((SendOrPostCallback)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TGAMcOBO9kAcZOCn4wY(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}
}
