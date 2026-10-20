using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cognex.Cnx.Diagnostics;
using Cognex.Explorer.Diagnostics;
using Cognex.InSight.Internal;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal sealed class EventManager : MarshalByRefObject
{
	internal abstract class ManagedEvent
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public ManagedEvent _003C_003E4__this;

			public EventArgs e;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _003C_003Ec__DisplayClass8_0()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				DnugFHsuqGrsLl2WvQYN(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _003CInvokeEvent_003Eb__0(object o)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				try
				{
					IDisposable disposable = CvsTraceSDK.Events.TraceBlock((string)boVKHasuBTgHlxHUw4VJ(_003C_003E4__this));
					try
					{
						if (!_003C_003E4__this.mEventManager.TimeToStop)
						{
							c3Z0JmsujyRgtl3tO4ES(_003C_003E4__this, e);
						}
					}
					finally
					{
						if (disposable != null)
						{
							r8Sg6Usuc9ElHloHJR18(disposable);
						}
					}
					dTg3ursu2cDhrCXWZXOl(1);
				}
				catch (Exception ex)
				{
					cvC4jesuCgYoldQV2OUR(CvsTraceSDK.Error, i0XrdIsuteWBVolQP4xd(Ac9mgqsuWNuYJoZM0kb9(57084), xi2gPEsu7jjkp58wWDaw(ex)));
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void DnugFHsuqGrsLl2WvQYN(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				P_0._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool eKPUdWsudGgyes3SJebJ()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool FINhD9suidE0i75fDi6Q()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object boVKHasuBTgHlxHUw4VJ(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((ManagedEvent)P_0).Name;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void c3Z0JmsujyRgtl3tO4ES(object P_0, object P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((ManagedEvent)P_0).DirectCall((EventArgs)P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void r8Sg6Usuc9ElHloHJR18(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((IDisposable)P_0).Dispose();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void dTg3ursu2cDhrCXWZXOl(int P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				Thread.Sleep(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object Ac9mgqsuWNuYJoZM0kb9(int P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object xi2gPEsu7jjkp58wWDaw(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Exception)P_0).Message;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object i0XrdIsuteWBVolQP4xd(object P_0, object P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (string)P_0 + (string)P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void cvC4jesuCgYoldQV2OUR(object P_0, object P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((CnxTraceChannel)P_0).TraceMessage((string)P_1);
			}
		}

		protected EventManager mEventManager;

		protected EventArgs mCurrentEventArgs;

		protected abstract string Name { get; }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ManagedEvent(EventManager eventManager)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!AFntxcs9P2mFVa2yrTBt())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_003b;
				}
			}
			goto IL_0053;
			IL_007a:
			mEventManager = eventManager;
			num = 5;
			if (!G0dgiWs9oHX4BHMPViU6())
			{
				return;
			}
			goto IL_0053;
			IL_003b:
			MPYChps9N7vJGMUI8wHJ(this);
			goto IL_007a;
			IL_0053:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					wNYwBts9YmnMDX4xgcZj();
					break;
				case 1:
				case 3:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_007a;
				case 5:
					return;
				}
				break;
			}
			goto IL_003b;
		}

		public abstract EventArgs RemoveEvent();

		public abstract void RemoveAllEvents();

		protected abstract void DirectCall(EventArgs e);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InvokeEvent(EventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			_003C_003Ec__DisplayClass8_0 obj = default;
			bool lockTaken = default;
			object pXobqDBl1Y = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					obj._003C_003E4__this = this;
					num = 7;
					continue;
				case 4:
					mCurrentEventArgs = obj.e;
					goto case 6;
				default:
					num = 6;
					continue;
				case 0:
					obj = new _003C_003Ec__DisplayClass8_0();
					_ = 0;
					num = ((!G0dgiWs9oHX4BHMPViU6()) ? 2 : 3);
					continue;
				case 2:
				case 5:
					lockTaken = false;
					num = 8;
					continue;
				case 6:
					pXobqDBl1Y = PXobqDBl1Y;
					goto case 2;
				case 7:
					obj.e = e;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 8:
					break;
				}
				break;
			}
			try
			{
				Monitor.Enter(pXobqDBl1Y, ref lockTaken);
				try
				{
					JBw1UXs9xtYwXjuZJ76d(mEventManager.P3obl5jMb2(), new SendOrPostCallback(obj._003CInvokeEvent_003Eb__0), null);
				}
				catch (Exception ex)
				{
					MBUuVZs93adoP3L4jgbg(CvsTraceSDK.Error, oiTfqRs9reJsAItcm4GW(kgbOBx7BanbFa22Hp9.ol99ukmDA(50408), euS0p7s91gomu26o9sli(ex)));
				}
			}
			finally
			{
				if (lockTaken)
				{
					DMQx32s9OsUFuFqKteqR(pXobqDBl1Y);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wNYwBts9YmnMDX4xgcZj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MPYChps9N7vJGMUI8wHJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G0dgiWs9oHX4BHMPViU6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AFntxcs9P2mFVa2yrTBt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JBw1UXs9xtYwXjuZJ76d(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SynchronizationContext)P_0).Send((SendOrPostCallback)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object euS0p7s91gomu26o9sli(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oiTfqRs9reJsAItcm4GW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MBUuVZs93adoP3L4jgbg(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DMQx32s9OsUFuFqKteqR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Monitor.Exit(P_0);
		}
	}

	internal abstract class CachedManagedEvent : ManagedEvent
	{
		private EventArgs FYk7xR75fN;

		protected abstract override string Name { get; }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CachedManagedEvent(EventManager eventManager)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HHt6oos9l3Nxb91clCNI();
			base._002Ector(eventManager);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddEvent()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (RSoTLLs9Mpkk5QleRIq3())
			{
				num = 3;
				if (sCRfoGs9Q8XRFxp2Mt52())
				{
				}
			}
			else
			{
				num = 2;
			}
			bool lockTaken = default;
			EventManager eventManager = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					lockTaken = false;
					break;
				default:
					goto IL_005b;
				case 0:
				case 3:
					eventManager = mEventManager;
					goto case 1;
				case 4:
					break;
				}
				break;
				IL_005b:
				num = 4;
			}
			try
			{
				Monitor.Enter(eventManager, ref lockTaken);
				RSoTLLs9Mpkk5QleRIq3();
				int num2;
				if (!sCRfoGs9Q8XRFxp2Mt52())
				{
					num2 = 2;
					if (sCRfoGs9Q8XRFxp2Mt52())
					{
						goto IL_00a4;
					}
				}
				else
				{
					num2 = 3;
				}
				goto IL_00c6;
				IL_0106:
				LhOmt5s9InF30uaOlJEx(mEventManager);
				return;
				IL_00c6:
				switch (num2)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_00ef;
				case 4:
					goto IL_0106;
				}
				goto IL_00a4;
				IL_00a4:
				YIaKmQs9u9aaVfnfJ8Et(CvsTraceSDK.Events, IT44BFs9eR0BfQhhyawk(this));
				goto IL_00ef;
				IL_00ef:
				FYk7xR75fN = EventArgs.Empty;
				num2 = 4;
				if (0 == 0)
				{
					goto IL_00c6;
				}
				goto IL_0106;
			}
			finally
			{
				if (lockTaken)
				{
					BIFvq3s9Ram7493t4rbK(eventManager);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddEvent(EventArgs args)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RSoTLLs9Mpkk5QleRIq3();
			int num = (sCRfoGs9Q8XRFxp2Mt52() ? 2 : 3);
			bool lockTaken = default;
			EventManager eventManager = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					lockTaken = false;
					break;
				default:
					goto IL_0055;
				case 0:
				case 3:
					eventManager = mEventManager;
					goto case 1;
				case 4:
					break;
				}
				break;
				IL_0055:
				num = 4;
			}
			try
			{
				Monitor.Enter(eventManager, ref lockTaken);
				_ = 0;
				int num2;
				if (RSoTLLs9Mpkk5QleRIq3())
				{
					num2 = 3;
				}
				else
				{
					num2 = 2;
					if (1 == 0)
					{
						goto IL_00e1;
					}
				}
				goto IL_00b6;
				IL_00e1:
				FYk7xR75fN = args;
				num2 = 4;
				if (true)
				{
					goto IL_00b6;
				}
				goto IL_00f4;
				IL_00f4:
				mEventManager.TriggerAnyEvent();
				return;
				IL_00b6:
				switch (num2)
				{
				case 0:
				case 3:
					YIaKmQs9u9aaVfnfJ8Et(CvsTraceSDK.Events, IT44BFs9eR0BfQhhyawk(this));
					break;
				case 4:
					goto IL_00f4;
				}
				goto IL_00e1;
			}
			finally
			{
				if (lockTaken)
				{
					BIFvq3s9Ram7493t4rbK(eventManager);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EventArgs RemoveEvent()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventArgs fYk7xR75fN = FYk7xR75fN;
			FYk7xR75fN = null;
			return fYk7xR75fN;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void RemoveAllEvents()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FYk7xR75fN = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HHt6oos9l3Nxb91clCNI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RSoTLLs9Mpkk5QleRIq3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sCRfoGs9Q8XRFxp2Mt52()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IT44BFs9eR0BfQhhyawk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ManagedEvent)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YIaKmQs9u9aaVfnfJ8Et(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LhOmt5s9InF30uaOlJEx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EventManager)P_0).TriggerAnyEvent();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BIFvq3s9Ram7493t4rbK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Monitor.Exit(P_0);
		}
	}

	internal class ResultsChangedManagedEvent : CachedManagedEvent
	{
		protected override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(6618);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResultsChangedManagedEvent(EventManager eventManager)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector(eventManager);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DirectCall(EventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IDisposable disposable = CvsTrace.Display.ResultsUpdate.TraceResultFunction(this, (string)BhTOIRs9GlSmvF2ZsU0J(50438));
			try
			{
				bYpnbks9bHi8XJ1pZp1s(APYBU3s9XN1NmGPMVXRO(mEventManager), APYBU3s9XN1NmGPMVXRO(mEventManager), (CvsInternalEventArgs)e);
			}
			finally
			{
				if (disposable != null)
				{
					VyYO6Ms96Hi0GLJgfFLN(disposable);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Oq0W96s9aHJLPKCA9fbM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b3qZb5s9n9c0s7J7yOSX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BhTOIRs9GlSmvF2ZsU0J(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object APYBU3s9XN1NmGPMVXRO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EventManager)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bYpnbks9bHi8XJ1pZp1s(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).HandleResultsChanged(P_1, (CvsInternalEventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VyYO6Ms96Hi0GLJgfFLN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}
	}

	internal class StateChangedManagedEvent : CachedManagedEvent
	{
		protected override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(6776);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StateChangedManagedEvent(EventManager eventManager)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector(eventManager);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DirectCall(EventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Lf0QTis9khml7n2El5UN(Vy8YQ8s94wKNc5eswbeV(mEventManager), Vy8YQ8s94wKNc5eswbeV(mEventManager), (CvsStateChangedEventArgs)e);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yiH5f3s9piG8QAcsnqHs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool btjFxss90hPhPb0pHJ9D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vy8YQ8s94wKNc5eswbeV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EventManager)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Lf0QTis9khml7n2El5UN(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).HandleStateChanged(P_1, (CvsStateChangedEventArgs)P_2);
		}
	}

	internal class IsLiveAcquisitionChangedManagedEvent : CachedManagedEvent
	{
		protected override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (string)L1etUds9mSijToGE3s0h(6804);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IsLiveAcquisitionChangedManagedEvent(EventManager eventManager)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			py8syFs9yVN065O81tSI();
			base._002Ector(eventManager);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DirectCall(EventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LgyYYTs9ZZ9CwR4FwiXA(FfDLiGs9gq6oNy0wymf0(mEventManager), FfDLiGs9gq6oNy0wymf0(mEventManager), EventArgs.Empty);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L1etUds9mSijToGE3s0h(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void py8syFs9yVN065O81tSI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cDmY4ms9fNQfLm60gNNh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E8ib01s9FfpkDhxfIZ3O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FfDLiGs9gq6oNy0wymf0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EventManager)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LgyYYTs9ZZ9CwR4FwiXA(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).HandleIsLiveAcquisitionChanged(P_1, (EventArgs)P_2);
		}
	}

	internal class IsOnlineChangedManagedEvent : CachedManagedEvent
	{
		protected override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(50462);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IsOnlineChangedManagedEvent(EventManager eventManager)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector(eventManager);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DirectCall(EventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AKvjJosSwTx7LuAoxWY7(CBNV3Es9zDnO1JrOEEHX(mEventManager), CBNV3Es9zDnO1JrOEEHX(mEventManager), EventArgs.Empty);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AslMuHs9J3bfXGOu2v6m()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vC54gts98xBKv442oIEq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CBNV3Es9zDnO1JrOEEHX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EventManager)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AKvjJosSwTx7LuAoxWY7(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).HandleIsOnlineChanged(P_1, (EventArgs)P_2);
		}
	}

	internal class NamedEditCellValueChangedManagedEvent : CachedManagedEvent
	{
		protected override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (string)y3qAxKsSLxYK21da56os(6890);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NamedEditCellValueChangedManagedEvent(EventManager eventManager)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IAnTDlsS9oBxafGNrTUi();
			base._002Ector(eventManager);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DirectCall(EventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fHgf5MsSEAblvQQNG5bm(g0SIrMsSSBZ8QKpHGuUy(mEventManager), g0SIrMsSSBZ8QKpHGuUy(mEventManager), EventArgs.Empty);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object y3qAxKsSLxYK21da56os(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IAnTDlsS9oBxafGNrTUi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ja2xslsSsPOX2G9PgTYo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IcZpOqsShjGgfbWRRAyQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g0SIrMsSSBZ8QKpHGuUy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EventManager)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fHgf5MsSEAblvQQNG5bm(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).HandleNamedEditCellValueChanged(P_1, (EventArgs)P_2);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public EventManager _003C_003E4__this;

		public CvsStateChangedEventArgs e;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass52_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			f0d3wMsSVXqbfuqZJCxm();
			rfYYYdsSAHisYHLdvGEU(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CFireImmediateStateChanged_003Eb__0(object o)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			try
			{
				VyDPnJsSDP5VnukeSM98(_003C_003E4__this.w0SbT3KS1u, _003C_003E4__this.w0SbT3KS1u, e);
			}
			catch (Exception ex)
			{
				CvsTraceSDK.Error.TraceMessage((string)vsvra1sSTwHocq5aiS1p(A9SCUysSUqg1MMvmtkdX(50502), ex.Message));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void f0d3wMsSVXqbfuqZJCxm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rfYYYdsSAHisYHLdvGEU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KsFfW8sSvYbsUIF7OYS6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dTbQdcsSH30b9akXHsjb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VyDPnJsSDP5VnukeSM98(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).HandleStateChanged(P_1, (CvsStateChangedEventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A9SCUysSUqg1MMvmtkdX(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vsvra1sSTwHocq5aiS1p(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}
	}

	private static readonly object PXobqDBl1Y;

	private readonly CvsInSight w0SbT3KS1u;

	private readonly Thread TY7bBoLASp;

	private readonly AutoResetEvent aqgbJnLTtM;

	private readonly ManualResetEvent nG4bMa5ZbQ;

	private volatile bool AGobo2Yk49;

	private bool ppIbAfAtIi;

	private int jb4bt2BBHR;

	private readonly ManagedEvent[] E7LbWtmY1P;

	[CompilerGenerated]
	private readonly ResultsChangedManagedEvent MKYb31VmQ1;

	[CompilerGenerated]
	private readonly StateChangedManagedEvent YGXbLNo2S3;

	[CompilerGenerated]
	private readonly IsLiveAcquisitionChangedManagedEvent nSHbk6Wsql;

	[CompilerGenerated]
	private readonly IsOnlineChangedManagedEvent fb8bXGM6Gh;

	[CompilerGenerated]
	private readonly NamedEditCellValueChangedManagedEvent y67bfRWSA5;

	private bool MyFbjkCNHc;

	private static object y5Zbcnvvbx;

	private static int uI8b555qtF;

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return w0SbT3KS1u;
		}
	}

	public bool TimeToStop
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AGobo2Yk49;
		}
	}

	public ResultsChangedManagedEvent ResultsChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MKYb31VmQ1;
		}
	}

	public StateChangedManagedEvent StateChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YGXbLNo2S3;
		}
	}

	public IsLiveAcquisitionChangedManagedEvent IsLiveAcquisitionChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nSHbk6Wsql;
		}
	}

	public IsOnlineChangedManagedEvent IsOnlineChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fb8bXGM6Gh;
		}
	}

	public NamedEditCellValueChangedManagedEvent NamedEditCellValueChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return y67bfRWSA5;
		}
	}

	public static int ActiveEventManagers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nJDCfUAC7ZHfOZGejN0();
			int num = ((!iC3LtBAtC1klA6POGAO()) ? 3 : 2);
			object obj = default;
			bool lockTaken = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					obj = y5Zbcnvvbx;
					goto case 1;
				case 1:
				case 3:
					lockTaken = false;
					break;
				default:
					goto IL_006b;
				case 4:
					break;
				}
				break;
				IL_006b:
				num = 4;
			}
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				return uI8b555qtF;
			}
			finally
			{
				if (lockTaken)
				{
					i0US8bAOR8t8VdoDxu5(obj);
				}
			}
		}
	}

	public bool CurrentThreadIsMainThread
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nKnVkGAeGrCG6p0aOuo(Thread.CurrentThread) == w0SbT3KS1u.MainThreadID;
		}
	}

	public ManualResetEvent EventThreadNotBusy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nG4bMa5ZbQ;
		}
	}

	public bool StillAlive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ppIbAfAtIi;
		}
	}

	public bool EventsBlocked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jb4bt2BBHR > 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EventManager(CvsInSight insight)
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
			case 5:
				yGHBksArQ0lFgyfCHll(TY7bBoLASp, ThreadPriority.Highest);
				num = 2;
				break;
			case 14:
				kRLl1kAYjqlrIqyiKYc(TY7bBoLASp, BP0odqAPtXkyZmYfn3D(fIpUExAoYwbmH5dgUAU()));
				iC3LtBAtC1klA6POGAO();
				if (!nJDCfUAC7ZHfOZGejN0())
				{
					num = 4;
					break;
				}
				num = 3;
				if (nJDCfUAC7ZHfOZGejN0())
				{
				}
				break;
			case 7:
				y67bfRWSA5 = new NamedEditCellValueChangedManagedEvent(this);
				goto case 12;
			default:
				num = 12;
				break;
			case 15:
				MKYb31VmQ1 = new ResultsChangedManagedEvent(this);
				YGXbLNo2S3 = new StateChangedManagedEvent(this);
				num = 8;
				break;
			case 4:
			case 10:
				TY7bBoLASp.CurrentUICulture = (CultureInfo)KkHnVWANUvppiT2gh4p(fIpUExAoYwbmH5dgUAU());
				c7AyX3AxRkSQYU7hpfr(TY7bBoLASp, true);
				goto case 3;
			case 12:
				E7LbWtmY1P = new ManagedEvent[5] { ResultsChanged, StateChanged, IsLiveAcquisitionChanged, IsOnlineChanged, NamedEditCellValueChanged };
				TY7bBoLASp = new Thread(zIWbhmO1wT);
				num = 14;
				break;
			case 8:
				nSHbk6Wsql = new IsLiveAcquisitionChangedManagedEvent(this);
				num = 1;
				break;
			case 13:
				OP8G0UA5LjxDHT7igTk(this);
				num = 16;
				break;
			case 2:
				rr4U8QA3D4vLqnHrxMk(TY7bBoLASp);
				num = 17;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				nG4bMa5ZbQ = new ManualResetEvent(initialState: true);
				aqgbJnLTtM = new AutoResetEvent(initialState: false);
				num = 5;
				break;
			case 3:
			case 11:
				UVCvsTA1LcFMMx4RgcJ(TY7bBoLASp, kgbOBx7BanbFa22Hp9.ol99ukmDA(7436));
				num = 6;
				break;
			case 0:
				EfwhAeAKA54ZCZCfyYH();
				num = 9;
				break;
			case 16:
				w0SbT3KS1u = insight;
				num = 15;
				break;
			case 1:
				fb8bXGM6Gh = new IsOnlineChangedManagedEvent(this);
				num = 7;
				break;
			case 9:
				ppIbAfAtIi = true;
				num = 13;
				if (nJDCfUAC7ZHfOZGejN0())
				{
				}
				break;
			case 17:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetActiveEventManagers()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!nJDCfUAC7ZHfOZGejN0())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0073;
			}
		}
		bool lockTaken = default;
		object obj = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_0051;
			case 0:
			case 2:
				obj = y5Zbcnvvbx;
				goto case 1;
			case 4:
				break;
			}
			break;
			IL_0051:
			num = 4;
		}
		goto IL_0073;
		IL_0073:
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			uI8b555qtF = 0;
		}
		finally
		{
			if (lockTaken)
			{
				i0US8bAOR8t8VdoDxu5(obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Join(int ms)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (TY7bBoLASp != null)
		{
			return Sqn5PdAMDiFLLFGniQv(TY7bBoLASp, ms);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Interrupt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Thread tY7bBoLASp = TY7bBoLASp;
		if (tY7bBoLASp != null)
		{
			C8YaKDAQYT5HLfsKFqx(tY7bBoLASp);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private SynchronizationContext P3obl5jMb2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (SynchronizationContext)CGAbAWAlXmu9fW5oOjS(w0SbT3KS1u);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopThread()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nJDCfUAC7ZHfOZGejN0();
		int num;
		if (iC3LtBAtC1klA6POGAO())
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
		goto IL_0062;
		IL_0047:
		AGobo2Yk49 = true;
		goto IL_0089;
		IL_0062:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 3:
				goto IL_0047;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_0089;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		if (!AGobo2Yk49)
		{
			goto IL_0047;
		}
		return;
		IL_0089:
		jDV1S1Au7gWtRtRyw85(aqgbJnLTtM);
		num = 5;
		goto IL_0062;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BlockEvents()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!nJDCfUAC7ZHfOZGejN0())
		{
			num = 2;
			if (nJDCfUAC7ZHfOZGejN0())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 3:
				goto IL_003c;
			default:
				num = 4;
				if (iC3LtBAtC1klA6POGAO())
				{
					continue;
				}
				goto IL_0079;
			case 4:
				goto IL_0079;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		EventManager eventManager = this;
		goto IL_003c;
		IL_003c:
		bool lockTaken = false;
		goto IL_0079;
		IL_0079:
		try
		{
			Monitor.Enter(eventManager, ref lockTaken);
			iC3LtBAtC1klA6POGAO();
			int num2 = (nJDCfUAC7ZHfOZGejN0() ? 3 : 2);
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					jb4bt2BBHR++;
					break;
				case 4:
					nG4bMa5ZbQ.Set();
					return;
				}
				Q6M9TJARD0kPoU5j093(CvsTraceSDK.Events, SGZftbAIduEBAHeLyrl(7464), jb4bt2BBHR);
				num2 = 4;
			}
		}
		finally
		{
			if (lockTaken)
			{
				i0US8bAOR8t8VdoDxu5(eventManager);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnblockEvents()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UnblockEvents(fireEvents: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnblockEvents(bool fireEvents)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!iC3LtBAtC1klA6POGAO()) ? 3 : 2);
		EventManager obj = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				obj = this;
				goto case 1;
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_0063;
			case 4:
				break;
			}
			break;
			IL_0063:
			num = 4;
		}
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			int num2 = 4;
			ManagedEvent[] e7LbWtmY1P = default;
			int num3 = default;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (fireEvents)
					{
						num2 = 8;
						continue;
					}
					e7LbWtmY1P = E7LbWtmY1P;
					num2 = 1;
					continue;
				case 8:
					jb4bt2BBHR--;
					jDV1S1Au7gWtRtRyw85(aqgbJnLTtM);
					num2 = 7;
					continue;
				case 4:
					if (jb4bt2BBHR == 1)
					{
						num2 = 3;
						continue;
					}
					if (jb4bt2BBHR <= 0)
					{
						break;
					}
					goto case 9;
				case 2:
					jb4bt2BBHR--;
					num2 = 11;
					if (!nJDCfUAC7ZHfOZGejN0())
					{
						continue;
					}
					goto case 1;
				case 1:
					num3 = 0;
					goto case 0;
				default:
					num2 = 0;
					if (!nJDCfUAC7ZHfOZGejN0())
					{
						continue;
					}
					goto case 5;
				case 5:
				case 6:
					num3++;
					goto case 0;
				case 0:
					if (num3 >= e7LbWtmY1P.Length)
					{
						num2 = 2;
						continue;
					}
					h1curGAatsZS9NHN9uU(e7LbWtmY1P[num3]);
					nJDCfUAC7ZHfOZGejN0();
					num2 = (iC3LtBAtC1klA6POGAO() ? 5 : 10);
					continue;
				case 9:
				case 10:
					jb4bt2BBHR--;
					num2 = 12;
					continue;
				case 7:
				case 11:
				case 12:
					break;
				}
				break;
			}
			Q6M9TJARD0kPoU5j093(CvsTraceSDK.Events, SGZftbAIduEBAHeLyrl(7500), jb4bt2BBHR);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TriggerAnyEvent()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (iC3LtBAtC1klA6POGAO())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_00c9;
			}
		}
		goto IL_0092;
		IL_0092:
		bool lockTaken = default;
		EventManager obj = default;
		while (true)
		{
			switch (num)
			{
			default:
				ResetMsgQueueEmpty();
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				jDV1S1Au7gWtRtRyw85(aqgbJnLTtM);
				num = 7;
				continue;
			case 5:
				lockTaken = false;
				num = 2;
				continue;
			case 2:
			{
				int num2;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					num2 = jb4bt2BBHR;
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				if (num2 <= 0)
				{
					goto default;
				}
				return;
			}
			case 0:
			case 1:
				break;
			case 7:
				return;
			}
			break;
		}
		goto IL_00c9;
		IL_00c9:
		obj = this;
		num = 5;
		goto IL_0092;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FireImmediateStateChanged(CvsStateChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003C_003Ec__DisplayClass52_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				obj = new _003C_003Ec__DisplayClass52_0();
				iC3LtBAtC1klA6POGAO();
				num = (nJDCfUAC7ZHfOZGejN0() ? 5 : 3);
				break;
			case 4:
				RemoveAllEvents();
				num = 6;
				break;
			case 2:
			case 5:
				obj.e = e;
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
			case 3:
				obj._003C_003E4__this = this;
				goto case 2;
			case 6:
				try
				{
					UBVNLiAn5PxyCnhM4ms(P3obl5jMb2(), new SendOrPostCallback(obj._003CFireImmediateStateChanged_003Eb__0), null);
					return;
				}
				catch (Exception ex)
				{
					CvsTraceSDK.Error.TraceMessage(kgbOBx7BanbFa22Hp9.ol99ukmDA(7540) + (string)ijIXrUAGh461OQ3B6xT(ex));
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllEvents()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MyFbjkCNHc = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CIWbp922Ru()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		ManagedEvent[] e7LbWtmY1P = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				e7LbWtmY1P = E7LbWtmY1P;
				num = 1;
				continue;
			case 0:
			case 2:
			case 6:
				if (num2 >= e7LbWtmY1P.Length)
				{
					num = 7;
					if (!nJDCfUAC7ZHfOZGejN0())
					{
						continue;
					}
					goto case 1;
				}
				h1curGAatsZS9NHN9uU(e7LbWtmY1P[num2]);
				break;
			case 1:
				num2 = 0;
				iC3LtBAtC1klA6POGAO();
				num = (nJDCfUAC7ZHfOZGejN0() ? 4 : 0);
				continue;
			case 7:
				return;
			}
			num2++;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zIWbhmO1wT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			object obj = y5Zbcnvvbx;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				uI8b555qtF++;
			}
			finally
			{
				if (lockTaken)
				{
					i0US8bAOR8t8VdoDxu5(obj);
				}
			}
			using (ngxB3BAXk45BQc18Ckp())
			{
				try
				{
					Queue queue = new Queue();
					while (true)
					{
						aqgbJnLTtM.WaitOne();
						if (AGobo2Yk49)
						{
							break;
						}
						int num = jb4bt2BBHR;
						try
						{
							bool flag = false;
							lockTaken = false;
							try
							{
								Monitor.Enter(this, ref lockTaken);
								_ = 0;
								int num2;
								if (iC3LtBAtC1klA6POGAO())
								{
									num2 = 3;
								}
								else
								{
									num2 = 2;
									if (nJDCfUAC7ZHfOZGejN0())
									{
									}
								}
								while (true)
								{
									switch (num2)
									{
									case 0:
									case 3:
										if (AGobo2Yk49)
										{
											break;
										}
										if (num == 0)
										{
											goto IL_00ee;
										}
										goto IL_010e;
									case 2:
										break;
									case 4:
										flag = true;
										goto IL_010e;
									}
									break;
									IL_00ee:
									num2 = 4;
								}
							}
							finally
							{
								if (lockTaken)
								{
									i0US8bAOR8t8VdoDxu5(this);
								}
							}
							goto end_IL_0069;
							IL_010e:
							HBZb4A8GYC(queue, flag);
							if (!AGobo2Yk49)
							{
								if (MyFbjkCNHc)
								{
									CIWbp922Ru();
									MyFbjkCNHc = false;
								}
								else if (!AGobo2Yk49)
								{
									continue;
								}
							}
							end_IL_0069:;
						}
						finally
						{
							jDV1S1Au7gWtRtRyw85(nG4bMa5ZbQ);
						}
						break;
					}
				}
				catch (Exception ex)
				{
					if (!AGobo2Yk49)
					{
						X9GGltAbpT626FrST11(CvsTraceSDK.Error, ex);
					}
				}
				ppIbAfAtIi = false;
			}
		}
		finally
		{
			object obj = y5Zbcnvvbx;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				uI8b555qtF--;
			}
			finally
			{
				if (lockTaken)
				{
					i0US8bAOR8t8VdoDxu5(obj);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ResetMsgQueueEmpty()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iC3LtBAtC1klA6POGAO();
		int num = (nJDCfUAC7ZHfOZGejN0() ? 3 : 2);
		EventManager eventManager = default;
		bool lockTaken = default;
		do
		{
			switch (num)
			{
			case 0:
			case 2:
				eventManager = this;
				goto case 1;
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_0067;
			case 4:
				break;
			}
			break;
			IL_0067:
			num = 4;
		}
		while (iC3LtBAtC1klA6POGAO());
		try
		{
			Monitor.Enter(eventManager, ref lockTaken);
			_ = 0;
			int num2;
			if (iC3LtBAtC1klA6POGAO())
			{
				num2 = 3;
				if (false)
				{
					goto IL_0097;
				}
			}
			else
			{
				num2 = 2;
			}
			goto IL_00b5;
			IL_00de:
			jDV1S1Au7gWtRtRyw85(nG4bMa5ZbQ);
			num2 = 4;
			if (false)
			{
				return;
			}
			goto IL_00b5;
			IL_00b5:
			switch (num2)
			{
			case 0:
			case 3:
				break;
			default:
				goto IL_00de;
			case 4:
				return;
			}
			goto IL_0097;
			IL_0097:
			if (jb4bt2BBHR > 0)
			{
				goto IL_00de;
			}
			mXYZU2A6i4XC6qWEbrg(nG4bMa5ZbQ);
		}
		finally
		{
			if (lockTaken)
			{
				i0US8bAOR8t8VdoDxu5(eventManager);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HBZb4A8GYC(Queue P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		int num3 = default;
		bool lockTaken = default;
		EventManager eventManager = default;
		EventArgs e2 = default;
		ManagedEvent managedEvent = default;
		IEnumerator enumerator = default;
		ManagedEvent[] e7LbWtmY1P = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				num3 = 0;
				num = 9;
				if (!nJDCfUAC7ZHfOZGejN0())
				{
					continue;
				}
				goto case 6;
			case 6:
				lockTaken = false;
				goto case 2;
			case 2:
			case 7:
				try
				{
					Monitor.Enter(eventManager, ref lockTaken);
					_ = 1;
					int num4;
					if (!nJDCfUAC7ZHfOZGejN0())
					{
						num4 = 2;
					}
					else
					{
						num4 = 3;
						if (!iC3LtBAtC1klA6POGAO())
						{
							goto IL_00a4;
						}
					}
					goto IL_0075;
					IL_005b:
					e2 = (EventArgs)oC90ePApbhCU9xcQSDI(managedEvent);
					goto IL_00a4;
					IL_00a4:
					if (e2 == null)
					{
						num4 = 4;
						goto IL_0075;
					}
					m55mVxA00p7r9GMg930(P_0, e2);
					goto IL_005b;
					IL_0075:
					switch (num4)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_00a4;
					case 4:
						goto end_IL_003d;
					}
					goto IL_005b;
					end_IL_003d:;
				}
				finally
				{
					if (lockTaken)
					{
						i0US8bAOR8t8VdoDxu5(eventManager);
					}
				}
				enumerator = (IEnumerator)xmLArKA4kZ1WpIW2bvn(P_0);
				num = 11;
				continue;
			case 10:
				eventManager = this;
				goto case 6;
			default:
				num = 6;
				continue;
			case 8:
			case 9:
				if (num3 >= e7LbWtmY1P.Length)
				{
					num = 12;
					continue;
				}
				managedEvent = e7LbWtmY1P[num3];
				num = 3;
				if (iC3LtBAtC1klA6POGAO())
				{
					continue;
				}
				goto case 3;
			case 1:
			case 4:
				P_0.Clear();
				num = 10;
				continue;
			case 3:
				if (MyFbjkCNHc)
				{
					return;
				}
				if (!P_1)
				{
					break;
				}
				iC3LtBAtC1klA6POGAO();
				if (nJDCfUAC7ZHfOZGejN0())
				{
					num = 2;
					continue;
				}
				num = 1;
				if (!nJDCfUAC7ZHfOZGejN0())
				{
					continue;
				}
				goto case 0;
			case 0:
				e7LbWtmY1P = E7LbWtmY1P;
				num = 5;
				continue;
			case 11:
				try
				{
					while (sOT7eBAFW2WJ8wGJhgX(enumerator))
					{
						EventArgs e = (EventArgs)Fx2WVXAk1CjtaaGcoD9(enumerator);
						int num2 = 4;
						while (true)
						{
							switch (num2)
							{
							case 1:
							case 3:
								return;
							case 4:
								if (!MyFbjkCNHc)
								{
									if (AGobo2Yk49)
									{
										break;
									}
									goto default;
								}
								_ = 0;
								num2 = (iC3LtBAtC1klA6POGAO() ? 3 : 0);
								continue;
							default:
								U8bk6BAf4sI56vtFdhy(managedEvent, e);
								num2 = 5;
								continue;
							case 5:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						DDUr3fAmwwgcb7fgFh6(disposable);
					}
				}
				break;
			case 12:
				return;
			}
			num3++;
			num = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventManager()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				PXobqDBl1Y = new object();
				goto case 2;
			case 3:
				EfwhAeAKA54ZCZCfyYH();
				_ = 0;
				num = (iC3LtBAtC1klA6POGAO() ? 5 : 4);
				continue;
			case 2:
			case 4:
				y5Zbcnvvbx = new object();
				break;
			default:
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 0:
				break;
			case 6:
				return;
			}
			uI8b555qtF = 0;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iC3LtBAtC1klA6POGAO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nJDCfUAC7ZHfOZGejN0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EfwhAeAKA54ZCZCfyYH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OP8G0UA5LjxDHT7igTk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((MarshalByRefObject)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fIpUExAoYwbmH5dgUAU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Thread.CurrentThread;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BP0odqAPtXkyZmYfn3D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Thread)P_0).CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kRLl1kAYjqlrIqyiKYc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Thread)P_0).CurrentCulture = (CultureInfo)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KkHnVWANUvppiT2gh4p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Thread)P_0).CurrentUICulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c7AyX3AxRkSQYU7hpfr(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Thread)P_0).IsBackground = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UVCvsTA1LcFMMx4RgcJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Thread)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yGHBksArQ0lFgyfCHll(object P_0, ThreadPriority P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Thread)P_0).Priority = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rr4U8QA3D4vLqnHrxMk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Thread)P_0).Start();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i0US8bAOR8t8VdoDxu5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Sqn5PdAMDiFLLFGniQv(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Thread)P_0).Join(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C8YaKDAQYT5HLfsKFqx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Thread)P_0).Interrupt();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CGAbAWAlXmu9fW5oOjS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).MainThreadContext;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nKnVkGAeGrCG6p0aOuo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Thread)P_0).ManagedThreadId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jDV1S1Au7gWtRtRyw85(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EventWaitHandle)P_0).Set();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SGZftbAIduEBAHeLyrl(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q6M9TJARD0kPoU5j093(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h1curGAatsZS9NHN9uU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ManagedEvent)P_0).RemoveAllEvents();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UBVNLiAn5PxyCnhM4ms(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SynchronizationContext)P_0).Post((SendOrPostCallback)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ijIXrUAGh461OQ3B6xT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ngxB3BAXk45BQc18Ckp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxTrace.TraceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X9GGltAbpT626FrST11(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceException((Exception)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mXYZU2A6i4XC6qWEbrg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EventWaitHandle)P_0).Reset();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oC90ePApbhCU9xcQSDI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ManagedEvent)P_0).RemoveEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m55mVxA00p7r9GMg930(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Queue)P_0).Enqueue(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xmLArKA4kZ1WpIW2bvn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Queue)P_0).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fx2WVXAk1CjtaaGcoD9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U8bk6BAf4sI56vtFdhy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ManagedEvent)P_0).InvokeEvent((EventArgs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sOT7eBAFW2WJ8wGJhgX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DDUr3fAmwwgcb7fgFh6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}
}
