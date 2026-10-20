using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

internal class ControllerLiveModeService : ILiveModeService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DInternal_002DILiveModeService_002DAcquireNextImage_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ControllerLiveModeService _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			ControllerLiveModeService controllerLiveModeService = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					controllerLiveModeService = _003C_003E4__this;
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
					num2 = _003C_003E1__state;
					TZ4fuPsrGvgrRhhpc8iM();
					if (!UO3FGVsrXBVxNKBGyAOV())
					{
						num = 5;
						continue;
					}
					num = 4;
					if (!TZ4fuPsrGvgrRhhpc8iM())
					{
						return;
					}
					continue;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							grGFJOsr6NBJm9F5iRMp(CvsTraceSDK.Info, ytifEIsrbcTWG9tlvHiI(55602));
							num3 = 0;
							if (UO3FGVsrXBVxNKBGyAOV())
							{
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								TZ4fuPsrGvgrRhhpc8iM();
								if (!UO3FGVsrXBVxNKBGyAOV())
								{
									num3 = 1;
									if (TZ4fuPsrGvgrRhhpc8iM())
									{
										continue;
									}
									goto case 5;
								}
								num3 = 10;
								continue;
							case 5:
								awaiter = ((Task)LsCwlmsrpk74DOdHT8cB(controllerLiveModeService.XJktkgkMND())).GetAwaiter();
								num3 = 8;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 6:
								return;
							case 10:
								return;
							case 9:
								if (controllerLiveModeService.XJktkgkMND() != null)
								{
									num3 = 5;
									continue;
								}
								goto end_IL_014c;
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
								if (((ILiveModeService)controllerLiveModeService).IsLiveAcquisition)
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
									break;
								}
								goto end_IL_014c;
							case 11:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_014c:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ytifEIsrbcTWG9tlvHiI(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void grGFJOsr6NBJm9F5iRMp(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LsCwlmsrpk74DOdHT8cB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICogSocketAcq)P_0).ManualTriggerAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TZ4fuPsrGvgrRhhpc8iM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UO3FGVsrXBVxNKBGyAOV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight gp3t5PxtqL;

	private readonly object oa7tYuJSHt;

	[CompilerGenerated]
	private EventHandler q5xt761wpS;

	bool ILiveModeService.IsLiveAcquisition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ICogSocketAcq cogSocketAcq = XJktkgkMND();
			if (cogSocketAcq == null)
			{
				return false;
			}
			return RcjiKhIpUZsJuDRbgBU(cogSocketAcq);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 9;
			ICogSocketAcq cogSocketAcq = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					throw new CvsNotConnectedException();
				case 4:
				case 6:
					if (value)
					{
						num = 7;
						break;
					}
					return;
				case 7:
					cogSocketAcq.ManualTrigger();
					num = 10;
					if (!phGlxwIbBfCa5EYRdVa())
					{
						break;
					}
					goto case 0;
				case 0:
				{
					EventHandler eventHandler = q5xt761wpS;
					if (eventHandler == null)
					{
						goto case 4;
					}
					S96QCdI4bu2FtKLiFGl(eventHandler, this, EventArgs.Empty);
					num = 6;
					break;
				}
				default:
					num = 4;
					break;
				case 8:
					if (cogSocketAcq != null)
					{
						goto case 2;
					}
					return;
				case 2:
				case 3:
					fTIlp9I0AaUsYIqHCh7(cogSocketAcq, value);
					num = 0;
					break;
				case 9:
					if (!((gp3t5PxtqL.State == CvsInSightState.NotConnected) & value))
					{
						cogSocketAcq = XJktkgkMND();
						num = 8;
						break;
					}
					RleiDHIX3A5iR6ZaOPA();
					if (phGlxwIbBfCa5EYRdVa())
					{
						num = 2;
						break;
					}
					num = 5;
					if (!RleiDHIX3A5iR6ZaOPA())
					{
						return;
					}
					break;
				case 10:
					return;
				}
			}
		}
	}

	event EventHandler ILiveModeService.IsLiveAcquisitionChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RleiDHIX3A5iR6ZaOPA();
			int num = (phGlxwIbBfCa5EYRdVa() ? 3 : 2);
			object obj = default;
			bool lockTaken = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					obj = oa7tYuJSHt;
					goto case 1;
				case 1:
				case 3:
					lockTaken = false;
					break;
				default:
					goto IL_006c;
				case 4:
					break;
				}
				break;
				IL_006c:
				num = 4;
			}
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				Ivetfn8BUB(value);
			}
			finally
			{
				if (lockTaken)
				{
					tisdfUIfkZfLXZZ55Xe(obj);
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!phGlxwIbBfCa5EYRdVa())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_003d;
				}
			}
			object obj = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					obj = oa7tYuJSHt;
					break;
				case 1:
				case 2:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_0074;
				}
				break;
			}
			goto IL_003d;
			IL_0074:
			bool lockTaken = default;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				GA9tj1JYK8(value);
				return;
			}
			finally
			{
				if (lockTaken)
				{
					tisdfUIfkZfLXZZ55Xe(obj);
				}
			}
			IL_003d:
			lockTaken = false;
			goto IL_0074;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ControllerLiveModeService(CvsInSight insight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (phGlxwIbBfCa5EYRdVa() ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				oa7tYuJSHt = new object();
				num = 4;
				break;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 3:
				gp3t5PxtqL = insight;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				Tdd9ydI6I0dnijUBf5A(this);
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DInternal_002DILiveModeService_002DAcquireNextImage_003Ed__5))]
	Task ILiveModeService.AcquireNextImage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		phGlxwIbBfCa5EYRdVa();
		int num = ((!RleiDHIX3A5iR6ZaOPA()) ? 5 : 4);
		_003CCognex_002DInSight_002DInternal_002DILiveModeService_002DAcquireNextImage_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = GaCrn6IkmPsm6kRMMkA();
				num = 1;
				continue;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			num = 3;
			if (phGlxwIbBfCa5EYRdVa())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void Ivetfn8BUB(EventHandler value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0077;
		IL_002d:
		EventHandler eventHandler = q5xt761wpS;
		num = 1;
		if (1 == 0)
		{
			goto IL_0040;
		}
		goto IL_0077;
		IL_00ac:
		EventHandler eventHandler2 = eventHandler;
		_ = 0;
		if (!RleiDHIX3A5iR6ZaOPA())
		{
			num = 0;
		}
		else
		{
			num = 4;
			if (false)
			{
				return;
			}
		}
		goto IL_0077;
		IL_0040:
		EventHandler value2 = default;
		eventHandler = Interlocked.CompareExchange(ref q5xt761wpS, value2, eventHandler2);
		num = 6;
		goto IL_0077;
		IL_001a:
		if ((object)eventHandler == eventHandler2)
		{
			num = 7;
			if (false)
			{
				goto IL_002d;
			}
			goto IL_0077;
		}
		goto IL_00ac;
		IL_0077:
		switch (num)
		{
		case 6:
			break;
		case 5:
			goto IL_002d;
		default:
			goto IL_0040;
		case 2:
		case 4:
			value2 = (EventHandler)OHVxcVIF2iqV8ijNH0l(eventHandler2, value);
			goto IL_0040;
		case 1:
			goto IL_00ac;
		case 7:
			return;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void GA9tj1JYK8(EventHandler value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RleiDHIX3A5iR6ZaOPA();
		int num;
		if (!phGlxwIbBfCa5EYRdVa())
		{
			num = 2;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0049;
		IL_007e:
		EventHandler value2 = default;
		EventHandler eventHandler2 = default;
		EventHandler eventHandler = Interlocked.CompareExchange(ref q5xt761wpS, value2, eventHandler2);
		num = 3;
		goto IL_0049;
		IL_0049:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				num = 6;
				if (RleiDHIX3A5iR6ZaOPA())
				{
					continue;
				}
				goto IL_007e;
			case 6:
				goto IL_007e;
			case 3:
				if ((object)eventHandler == eventHandler2)
				{
					num = 7;
					if (true)
					{
						continue;
					}
				}
				goto case 1;
			case 1:
			case 4:
				eventHandler2 = eventHandler;
				num = 5;
				continue;
			case 0:
			case 2:
				eventHandler = q5xt761wpS;
				goto case 1;
			case 7:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		value2 = (EventHandler)taKm42ImGLA7hdkOyIi(eventHandler2, value);
		goto IL_007e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private ICogSocketAcq XJktkgkMND()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return gp3t5PxtqL?.CogSocket?.Acq;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tdd9ydI6I0dnijUBf5A(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RleiDHIX3A5iR6ZaOPA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool phGlxwIbBfCa5EYRdVa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RcjiKhIpUZsJuDRbgBU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICogSocketAcq)P_0).IsLiveAcquisition;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fTIlp9I0AaUsYIqHCh7(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ICogSocketAcq)P_0).IsLiveAcquisition = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S96QCdI4bu2FtKLiFGl(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GaCrn6IkmPsm6kRMMkA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tisdfUIfkZfLXZZ55Xe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OHVxcVIF2iqV8ijNH0l(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object taKm42ImGLA7hdkOyIi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}
}
