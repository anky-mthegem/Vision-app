using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Acq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;

public class AutoExposure : EzSupportSnippet
{
	internal static class ctyKZYL8Ui70GrRjbT
	{
	}

	private class oLyU47zVffTAHy5pvj : IAsyncDisposable
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CCreate_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<oLyU47zVffTAHy5pvj> _003C_003Et__builder;

			public CvsInSight insight;

			private oLyU47zVffTAHy5pvj _003Cwaiter_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				cmkKsi5ZE296OP1nW2FC();
				int num = (Pqe7ZR5Zpu31rnwvOO9H() ? 3 : 5);
				oLyU47zVffTAHy5pvj result = default;
				int num2 = default;
				TaskAwaiter awaiter = default;
				while (true)
				{
					switch (num)
					{
					case 4:
						_003Cwaiter_003E5__2 = null;
						goto case 2;
					default:
						num = 2;
						break;
					case 2:
						_003C_003Et__builder.SetResult(result);
						num = 6;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					case 1:
					case 3:
						try
						{
							int num3;
							if (num2 != 0)
							{
								_003Cwaiter_003E5__2 = new oLyU47zVffTAHy5pvj(insight);
								num3 = 0;
								if (false)
								{
									goto IL_00a7;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 9;
							}
							goto IL_01b5;
							IL_01b5:
							while (true)
							{
								switch (num3)
								{
								case 0:
									break;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 7;
									continue;
								case 9:
									_003C_003Eu__1 = default;
									num3 = 3;
									continue;
								case 2:
								case 8:
									awaiter = e7hyC35Z9lvRFhN3WK4i(_003Cwaiter_003E5__2.vyQ1KZ8mjT.AddImageReadyListenerAsync());
									num3 = 6;
									continue;
								case 5:
									goto IL_010f;
								case 6:
									if (awaiter.IsCompleted)
									{
										goto case 11;
									}
									goto case 4;
								case 7:
									return;
								case 11:
									awaiter.GetResult();
									num3 = 12;
									continue;
								case 4:
								case 10:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									goto case 1;
								default:
									num3 = 1;
									continue;
								case 3:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									continue;
								case 12:
									goto IL_020b;
								}
								break;
								IL_010f:
								EsZWai5ZX13xtOOhO2Eq(_003Cwaiter_003E5__2.vyQ1KZ8mjT, new EventHandler(_003Cwaiter_003E5__2.oi81sMytP4));
								_ = 1;
								if (!Pqe7ZR5Zpu31rnwvOO9H())
								{
									num3 = 8;
									if (Pqe7ZR5Zpu31rnwvOO9H())
									{
									}
								}
								else
								{
									num3 = 10;
								}
							}
							goto IL_00a7;
							IL_020b:
							result = _003Cwaiter_003E5__2;
							goto end_IL_0084;
							IL_00a7:
							if (_003Cwaiter_003E5__2.vyQ1KZ8mjT != null)
							{
								num3 = 5;
								goto IL_01b5;
							}
							goto IL_020b;
							end_IL_0084:;
						}
						catch (Exception exception)
						{
							_003C_003E1__state = -2;
							_003Cwaiter_003E5__2 = null;
							_003C_003Et__builder.SetException(exception);
							return;
						}
						_003C_003E1__state = -2;
						num = 4;
						if (true)
						{
							break;
						}
						goto case 0;
					case 0:
					case 5:
						num2 = _003C_003E1__state;
						goto case 1;
					case 6:
						return;
					}
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
			internal static void EsZWai5ZX13xtOOhO2Eq(object P_0, object P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((CvsCogSocketAcq)P_0).ImageReady += (EventHandler)P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter e7hyC35Z9lvRFhN3WK4i(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool cmkKsi5ZE296OP1nW2FC()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool Pqe7ZR5Zpu31rnwvOO9H()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public oLyU47zVffTAHy5pvj _003C_003E4__this;

			public TimeSpan? timeout;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _003C_003Ec__DisplayClass5_0()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _003CAwaitImageReady_003Eb__0()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return jjkyYH5ZjT55yudToX7s(_003C_003E4__this.lU51GU5Piu, timeout ?? P38c915Z3h2t64tutlw2(5.0));
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool PTFIWJ5Z436ebfy8tqAr()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool oiF7uy5Z7hZg89LsL6qv()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TimeSpan P38c915Z3h2t64tutlw2(double P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return TimeSpan.FromSeconds(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool jjkyYH5ZjT55yudToX7s(object P_0, TimeSpan P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((WaitHandle)P_0).WaitOne(P_1);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CAwaitImageReady_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(bool Ready, long Ms)> _003C_003Et__builder;

			public oLyU47zVffTAHy5pvj _003C_003E4__this;

			public TimeSpan? timeout;

			private Stopwatch _003Ctimer_003E5__2;

			private TaskAwaiter<bool> _003C_003Eu__1;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 1;
				(bool, long) result = default;
				int num2 = default;
				_003C_003Ec__DisplayClass5_0 obj = default;
				TaskAwaiter<bool> awaiter = default;
				oLyU47zVffTAHy5pvj oLyU47zVffTAHy5pvj2 = default;
				while (true)
				{
					switch (num)
					{
					case 3:
					case 5:
						_003Ctimer_003E5__2 = null;
						goto case 0;
					case 0:
					case 4:
						_003C_003Et__builder.SetResult(result);
						num = 7;
						if (Hxp4QR5Z60rwS6q7SF0d())
						{
							break;
						}
						goto case 2;
					case 2:
						try
						{
							int num3;
							if (num2 != 0)
							{
								obj = new _003C_003Ec__DisplayClass5_0();
								num3 = 4;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 1;
								if (false)
								{
									goto IL_00b6;
								}
							}
							goto IL_017f;
							IL_00b6:
							_003C_003Eu__1 = default;
							num3 = 10;
							goto IL_017f;
							IL_017f:
							while (true)
							{
								switch (num3)
								{
								case 5:
									if (oLyU47zVffTAHy5pvj2.lU51GU5Piu == null)
									{
										num3 = 0;
										continue;
									}
									_003Ctimer_003E5__2 = (Stopwatch)bGeGw15ZALyTMgaQtn4M();
									awaiter = Task.Run((Func<bool>)obj._003CAwaitImageReady_003Eb__0).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										goto default;
									}
									goto case 14;
								case 7:
								case 13:
									_003C_003Eu__1 = awaiter;
									num3 = 11;
									continue;
								case 12:
									if (oLyU47zVffTAHy5pvj2.vyQ1KZ8mjT != null)
									{
										num3 = 5;
										continue;
									}
									goto case 0;
								case 3:
									return;
								case 1:
									break;
								case 0:
									result = (false, 0L);
									num3 = 9;
									continue;
								case 2:
								case 6:
									num2 = (_003C_003E1__state = 0);
									goto case 7;
								case 10:
									num2 = (_003C_003E1__state = -1);
									num3 = 14;
									continue;
								case 8:
									obj.timeout = timeout;
									num3 = 12;
									continue;
								case 11:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 3;
									continue;
								case 9:
									goto end_IL_017f;
								default:
									_ = 0;
									num3 = (Hxp4QR5Z60rwS6q7SF0d() ? 2 : 13);
									continue;
								case 4:
									obj._003C_003E4__this = _003C_003E4__this;
									num3 = 8;
									if (!u0jMGf5ZCMe58FpDe3HA())
									{
										continue;
									}
									goto case 14;
								case 14:
								{
									bool result2 = awaiter.GetResult();
									_003Ctimer_003E5__2.Stop();
									result = (result2, TXdBfB5ZRQtFCtoNJ58p(_003Ctimer_003E5__2));
									goto end_IL_017f;
								}
								}
								goto IL_00b6;
								continue;
								end_IL_017f:
								break;
							}
						}
						catch (Exception exception)
						{
							_003C_003E1__state = -2;
							_003Ctimer_003E5__2 = null;
							_003C_003Et__builder.SetException(exception);
							return;
						}
						_003C_003E1__state = -2;
						goto default;
					default:
						_ = 0;
						num = (Hxp4QR5Z60rwS6q7SF0d() ? 5 : 0);
						break;
					case 1:
						num2 = _003C_003E1__state;
						num = 6;
						break;
					case 6:
						oLyU47zVffTAHy5pvj2 = _003C_003E4__this;
						num = 2;
						if (1 == 0)
						{
							return;
						}
						break;
					case 7:
						return;
					}
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
			internal static object bGeGw15ZALyTMgaQtn4M()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return Stopwatch.StartNew();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static long TXdBfB5ZRQtFCtoNJ58p(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Stopwatch)P_0).ElapsedMilliseconds;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool Hxp4QR5Z60rwS6q7SF0d()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool u0jMGf5ZCMe58FpDe3HA()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CDisposeAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncValueTaskMethodBuilder _003C_003Et__builder;

			public oLyU47zVffTAHy5pvj _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 3;
				int num2 = default;
				TaskAwaiter awaiter = default;
				oLyU47zVffTAHy5pvj oLyU47zVffTAHy5pvj2 = default;
				while (true)
				{
					switch (num)
					{
					case 3:
						num2 = _003C_003E1__state;
						_ = 0;
						if (eBB0o75ZWeZR2VqT3jqt())
						{
							num = 5;
							continue;
						}
						num = 0;
						if (0 == 0)
						{
							continue;
						}
						break;
					case 0:
					case 2:
						try
						{
							try
							{
								int num3;
								if (num2 == 0)
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num3 = 4;
									goto IL_0138;
								}
								if (oLyU47zVffTAHy5pvj2.vyQ1KZ8mjT != null)
								{
									eBB0o75ZWeZR2VqT3jqt();
									num3 = (FdyHCV5ZT46smoMpxx5I() ? 7 : 2);
									goto IL_0138;
								}
								goto end_IL_0038;
								IL_0138:
								while (true)
								{
									switch (num3)
									{
									case 5:
										_003C_003Eu__1 = awaiter;
										num3 = 6;
										continue;
									case 1:
										awaiter = bHWDXp5Z0fKCaqESEGUD(oLyU47zVffTAHy5pvj2.vyQ1KZ8mjT.RemoveImageReadyListenerAsync());
										num3 = 9;
										if (true)
										{
											continue;
										}
										goto case 0;
									case 0:
									case 2:
										a9kfFd5Zy7VGf7RXKgZG(oLyU47zVffTAHy5pvj2.vyQ1KZ8mjT, new EventHandler(oLyU47zVffTAHy5pvj2.oi81sMytP4));
										num3 = 1;
										continue;
									case 6:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 8;
										continue;
									case 8:
										return;
									case 9:
										if (awaiter.IsCompleted)
										{
											break;
										}
										goto case 3;
									case 4:
										num2 = (_003C_003E1__state = -1);
										num3 = 10;
										if (true)
										{
											continue;
										}
										goto case 3;
									case 3:
									case 7:
										num2 = (_003C_003E1__state = 0);
										goto case 5;
									default:
										num3 = 5;
										continue;
									case 10:
										break;
									}
									break;
								}
								awaiter.GetResult();
								end_IL_0038:;
							}
							catch (Exception exception)
							{
								oLyU47zVffTAHy5pvj2.rXW1BqPJvA.WarnException((string)LAxiGF5ZFlqy8ou0ONd5(54774), exception);
							}
							try
							{
								AutoResetEvent lU51GU5Piu = oLyU47zVffTAHy5pvj2.lU51GU5Piu;
								if (lU51GU5Piu != null)
								{
									hd1rq45ZMBLQ4YpKmTCZ(lU51GU5Piu);
								}
							}
							catch (Exception ex)
							{
								svKZO55ZYNEmrIkhTkHX(oLyU47zVffTAHy5pvj2.rXW1BqPJvA, CdQUGaROfy7He9T0foW.KbIzwHEDLa(54878), ex);
							}
						}
						catch (Exception exception2)
						{
							_003C_003E1__state = -2;
							_003C_003Et__builder.SetException(exception2);
							return;
						}
						_003C_003E1__state = -2;
						break;
					default:
						num = 4;
						if (true)
						{
							continue;
						}
						goto case 1;
					case 1:
					case 5:
						oLyU47zVffTAHy5pvj2 = _003C_003E4__this;
						goto case 0;
					case 4:
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
			internal static void a9kfFd5Zy7VGf7RXKgZG(object P_0, object P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((CvsCogSocketAcq)P_0).ImageReady -= (EventHandler)P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter bHWDXp5Z0fKCaqESEGUD(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object LAxiGF5ZFlqy8ou0ONd5(int P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void hd1rq45ZMBLQ4YpKmTCZ(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((WaitHandle)P_0).Dispose();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void svKZO55ZYNEmrIkhTkHX(object P_0, object P_1, object P_2)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool eBB0o75ZWeZR2VqT3jqt()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool FdyHCV5ZT46smoMpxx5I()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		private readonly CvsCogSocketAcq vyQ1KZ8mjT;

		private readonly AutoResetEvent lU51GU5Piu;

		private readonly ILogger rXW1BqPJvA;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CCreate_003Ed__3))]
		public static Task<oLyU47zVffTAHy5pvj> wiE1koW3eh(CvsInSight P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CCreate_003Ed__3 stateMachine = default;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<oLyU47zVffTAHy5pvj>.Create();
			stateMachine.insight = P_0;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private oLyU47zVffTAHy5pvj(CvsInSight P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!cNgbxa55blcFswAlHSjW()) ? 5 : 6);
			while (true)
			{
				switch (num)
				{
				default:
				{
					object obj;
					if (P_0 == null)
					{
						obj = null;
					}
					else
					{
						object obj2 = a4hikc55kRJn7fMkjR7x(P_0);
						obj = ((obj2 != null) ? KCOTxN558SFfWasA5HPJ(obj2) : null);
					}
					vyQ1KZ8mjT = obj as CvsCogSocketAcq;
					num = 1;
					break;
				}
				case 4:
					rXW1BqPJvA = LogManager.GetLogger<oLyU47zVffTAHy5pvj>();
					num = 2;
					if (cNgbxa55blcFswAlHSjW())
					{
						break;
					}
					goto case 1;
				case 1:
					lU51GU5Piu = new AutoResetEvent(initialState: false);
					num = 7;
					break;
				case 2:
					fJ3yHE55SAjuyUeVnErg(this);
					goto default;
				case 0:
				case 6:
					faZc8w55obJ1DgGBlm1Q();
					num = 4;
					break;
				case 7:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CAwaitImageReady_003Ed__5))]
		public Task<(bool Ready, long Ms)> Uyr1PgML0k(TimeSpan? P_0 = null)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CAwaitImageReady_003Ed__5 stateMachine = default;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, long)>.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine.timeout = P_0;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__6))]
		public ValueTask DisposeAsync()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			_003CDisposeAsync_003Ed__6 stateMachine = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					stateMachine._003C_003Et__builder = Md8YvF55qAbaoRXyCtDM();
					x1XrTm55G6xCVyC4eGmQ();
					num = (cNgbxa55blcFswAlHSjW() ? 3 : 0);
					break;
				case 1:
				case 3:
					stateMachine._003C_003E4__this = this;
					goto case 0;
				case 5:
					stateMachine._003C_003Et__builder.Start(ref stateMachine);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					stateMachine._003C_003E1__state = -1;
					goto case 5;
				default:
					num = 5;
					break;
				case 6:
					return stateMachine._003C_003Et__builder.Task;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void oi81sMytP4(object P_0, EventArgs P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DA4RrM55E3WKp5RXvwHw(lU51GU5Piu);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void faZc8w55obJ1DgGBlm1Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fJ3yHE55SAjuyUeVnErg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a4hikc55kRJn7fMkjR7x(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KCOTxN558SFfWasA5HPJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Acq;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cNgbxa55blcFswAlHSjW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x1XrTm55G6xCVyC4eGmQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AsyncValueTaskMethodBuilder Md8YvF55qAbaoRXyCtDM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AsyncValueTaskMethodBuilder.Create();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DA4RrM55E3WKp5RXvwHw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EventWaitHandle)P_0).Set();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public AutoExposure _003C_003E4__this;

		public int optimumAverage;

		public double totalPixels;

		public double maxExposure;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass37_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iYFPeG559VmBbLkL9xHD();
			vTbpwK554wvUbTT0bF6y(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iYFPeG559VmBbLkL9xHD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vTbpwK554wvUbTT0bF6y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VcqF6a55prtkp3ihg5lk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hw2A2e55XdmumM0wMnMB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double M6rvPB557s2wYJKnjqXi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunAutoExposureAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AutoExposure _003C_003E4__this;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private double _003CmiddleExposure_003E5__5;

		private TaskAwaiter _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			AutoExposure autoExposure = default;
			TaskAwaiter awaiter4 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003E8__1 = null;
					num = 4;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				case 2:
				case 6:
					try
					{
						TaskAwaiter<bool> awaiter3;
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						bool result;
						IAsyncDisposable result2;
						switch (num2)
						{
						default:
							_003C_003E8__1 = new _003C_003Ec__DisplayClass37_0();
							_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
							_003C_003E8__1.totalPixels = autoExposure.Width.Value * q3evnQ556DSVdVRn9lFE(autoExposure.Height);
							_003C_003E8__1.maxExposure = ((AcqDoublePropertyViewModel)hSuD3l55A0O838P45n4Y(iHvyFO55CBXb41mIkqnb(autoExposure.Parent))).Range.Maximum;
							awaiter3 = ((ICogSocketAcq)uvwgMV55W5EK18HaOGhQ(fhDyUg55Rw2dLH0sJew7(autoExposure.InSight))).GetAcqWhiteBalanceSupported().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_0132;
						case 0:
							awaiter3 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0132;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01b9;
						case 2:
						case 3:
							try
							{
								int num3;
								if (num2 != 2)
								{
									num3 = 14;
									if (false)
									{
										goto IL_01ec;
									}
									goto IL_02da;
								}
								awaiter4 = _003C_003Eu__3;
								goto IL_02b3;
								IL_02a2:
								awaiter4.GetResult();
								num3 = 16;
								goto IL_02da;
								IL_02b3:
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02a2;
								IL_01ec:
								_003C_003Eu__3 = default;
								num3 = 5;
								goto IL_02da;
								IL_02da:
								while (true)
								{
									switch (num3)
									{
									case 0:
										break;
									case 13:
										num2 = (_003C_003E1__state = 2);
										num3 = 15;
										continue;
									case 16:
										awaiter4 = d9Qeum55yCqyDho1xXl8(m1YUxH550GpDjKWAK3oj(_003C_003E8__1, _003CmiddleExposure_003E5__5, 0.0, _003C_003E8__1.maxExposure));
										if (!awaiter4.IsCompleted)
										{
											num3 = 1;
											continue;
										}
										goto case 17;
									case 15:
										_003C_003Eu__3 = awaiter4;
										num3 = 9;
										continue;
									case 9:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										Vi0QMp553DYO9O5R3ylP();
										if (!LJdXkF55jWvh4IVSXgbo())
										{
											num3 = 11;
											continue;
										}
										num3 = 8;
										if (0 == 0)
										{
											continue;
										}
										goto case 3;
									case 14:
										goto IL_0291;
									case 4:
										goto IL_02a2;
									case 7:
									case 8:
										goto IL_02b3;
									default:
										num3 = 4;
										continue;
									case 5:
										num2 = (_003C_003E1__state = -1);
										num3 = 17;
										if (0 == 0)
										{
											continue;
										}
										goto case 12;
									case 12:
										awaiter4 = d9Qeum55yCqyDho1xXl8(FgRRoD55T7ZeqQ20H8KM(_003C_003E8__1, _003CmiddleExposure_003E5__5));
										if (!awaiter4.IsCompleted)
										{
											num3 = 13;
											continue;
										}
										goto IL_02a2;
									case 2:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num3 = 10;
										continue;
									case 6:
									case 11:
										return;
									case 3:
										_003CmiddleExposure_003E5__5 = (0.0 + _003C_003E8__1.maxExposure) / 2.0;
										num3 = 12;
										continue;
									case 10:
										return;
									case 1:
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__3 = awaiter4;
										num3 = 2;
										continue;
									case 17:
										awaiter4.GetResult();
										goto end_IL_01d9;
									}
									break;
									IL_0291:
									if (num2 != 3)
									{
										num3 = 3;
										continue;
									}
									awaiter4 = _003C_003Eu__3;
									num3 = 0;
								}
								goto IL_01ec;
								end_IL_01d9:;
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003C_003E7__wrap1 == null)
							{
								break;
							}
							awaiter = qWwFNx55F8BhKTHUaJPB(_003C_003E7__wrap1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0495;
						case 4:
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0495;
							}
							IL_0495:
							awaiter.GetResult();
							break;
							IL_0132:
							result = awaiter3.GetResult();
							_003C_003E8__1.optimumAverage = (result ? 192 : 128);
							awaiter2 = autoExposure.Parent.PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01b9;
							IL_01b9:
							result2 = awaiter2.GetResult();
							_003C_003E7__wrap1 = result2;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 2;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							sCh2Oq55MI8TccNkMyea(ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 1:
					autoExposure = _003C_003E4__this;
					Vi0QMp553DYO9O5R3ylP();
					num = ((!LJdXkF55jWvh4IVSXgbo()) ? 6 : 5);
					break;
				case 7:
					return;
				}
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
		internal static double q3evnQ556DSVdVRn9lFE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iHvyFO55CBXb41mIkqnb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SetupImageStepViewModel)P_0).AcqSettings;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hSuD3l55A0O838P45n4Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AcquisitionSettingsViewModel)P_0).EasyModeExposure;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fhDyUg55Rw2dLH0sJew7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uvwgMV55W5EK18HaOGhQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Acq;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FgRRoD55T7ZeqQ20H8KM(object P_0, double exposure)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UpdateExposure(exposure);
			[MethodImpl(MethodImplOptions.NoInlining)]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass37_0.jdivyuRTxI3boCVegu9))]
			Task UpdateExposure(double yxIzAlqyKy)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 2;
				_003C_003Ec__DisplayClass37_0.jdivyuRTxI3boCVegu9 stateMachine = default;
				while (true)
				{
					switch (num)
					{
					case 2:
						stateMachine.e1nzNhhdyw = AsyncTaskMethodBuilder.Create();
						num = 5;
						break;
					case 5:
						stateMachine.Y0ZzdnNpoR = (_003C_003Ec__DisplayClass37_0)P_0;
						num = 6;
						if (true)
						{
							break;
						}
						goto case 1;
					case 1:
					case 3:
						stateMachine.Pukz7r7IOS = -1;
						goto case 0;
					case 6:
						stateMachine.yxIzAlqyKy = yxIzAlqyKy;
						goto default;
					default:
						_ = 1;
						num = ((!_003C_003Ec__DisplayClass37_0.Hw2A2e55XdmumM0wMnMB()) ? 1 : 0);
						break;
					case 0:
					case 4:
						stateMachine.e1nzNhhdyw.Start(ref stateMachine);
						num = 7;
						break;
					case 7:
						return stateMachine.e1nzNhhdyw.Task;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter d9Qeum55yCqyDho1xXl8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object m1YUxH550GpDjKWAK3oj(object P_0, double initialExposure, double lowerLimit, double upperLimit)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FindOptimumExposure(initialExposure, lowerLimit, upperLimit);
			[MethodImpl(MethodImplOptions.NoInlining)]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass37_0.nASRqYRflorMDv8QUS6))]
			Task FindOptimumExposure(double gpF18WPt8A, double jUD1zimgQe, double lSB11LfDyD)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 4;
				_003C_003Ec__DisplayClass37_0.nASRqYRflorMDv8QUS6 stateMachine = default;
				while (true)
				{
					switch (num)
					{
					case 8:
						stateMachine.LSB11LfDyD = lSB11LfDyD;
						num = 6;
						break;
					case 2:
						stateMachine.GpF18WPt8A = gpF18WPt8A;
						goto case 3;
					case 4:
						stateMachine.Ctb1hotCmV = AsyncTaskMethodBuilder.Create();
						_ = 0;
						num = (_003C_003Ec__DisplayClass37_0.VcqF6a55prtkp3ihg5lk() ? 5 : 7);
						break;
					case 3:
					case 7:
						stateMachine.JUD1zimgQe = jUD1zimgQe;
						goto case 8;
					default:
						num = 8;
						if (_003C_003Ec__DisplayClass37_0.VcqF6a55prtkp3ihg5lk())
						{
							break;
						}
						goto case 0;
					case 0:
						stateMachine.Ctb1hotCmV.Start(ref stateMachine);
						num = 9;
						if (0 == 0)
						{
							break;
						}
						goto case 6;
					case 6:
						stateMachine.HhW1rB0XaV = -1;
						num = 0;
						break;
					case 1:
					case 5:
						stateMachine.EF51mo7EmI = (_003C_003Ec__DisplayClass37_0)P_0;
						num = 2;
						break;
					case 9:
						return stateMachine.Ctb1hotCmV.Task;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask qWwFNx55F8BhKTHUaJPB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sCh2Oq55MI8TccNkMyea(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vi0QMp553DYO9O5R3ylP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LJdXkF55jWvh4IVSXgbo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CClear_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AutoExposure _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			AutoExposure autoExposure = default;
			CvsCellRange cellRange = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					if (AOoO0h55UHqOANkegYuG())
					{
					}
					break;
				case 1:
					autoExposure = _003C_003E4__this;
					_ = 1;
					if (!AOoO0h55UHqOANkegYuG())
					{
						num = 4;
						break;
					}
					num = 5;
					if (true)
					{
						break;
					}
					return;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cellRange = autoExposure.CellRange;
							num3 = 10;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
							if (false)
							{
								goto IL_010c;
							}
						}
						goto IL_0190;
						IL_007c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 0;
						goto IL_0190;
						IL_0202:
						awaiter.GetResult();
						goto end_IL_0065;
						IL_0190:
						CvsCogSocket cogSocket;
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 6:
								break;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								if (cellRange.IsValid)
								{
									num3 = 8;
									continue;
								}
								goto end_IL_0065;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (fnGaRh55YAUXuHt5AuSo())
								{
									continue;
								}
								goto IL_00db;
							case 1:
								goto IL_00db;
							case 0:
								return;
							case 2:
							case 4:
								goto IL_010c;
							case 11:
								goto IL_0128;
							case 5:
								goto IL_0169;
							default:
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto IL_01d5;
							case 8:
								goto IL_01d5;
							case 12:
								goto IL_0202;
							}
							break;
							IL_01d5:
							CvsInSight inSight = autoExposure.InSight;
							if (inSight != null)
							{
								cogSocket = inSight.CogSocket;
								if (cogSocket == null)
								{
									num3 = 11;
									continue;
								}
								goto IL_012e;
							}
							AOoO0h55UHqOANkegYuG();
							if (!fnGaRh55YAUXuHt5AuSo())
							{
								num3 = 3;
								if (1 == 0)
								{
									return;
								}
								continue;
							}
							num3 = 4;
							if (fnGaRh55YAUXuHt5AuSo())
							{
								continue;
							}
							goto IL_0202;
						}
						goto IL_007c;
						IL_010c:
						object obj = null;
						goto IL_0133;
						IL_012e:
						obj = cogSocket.Sheet;
						goto IL_0133;
						IL_0169:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							goto IL_00db;
						}
						goto IL_0202;
						IL_00db:
						_003C_003Eu__1 = awaiter;
						goto IL_007c;
						IL_0133:
						if (obj != null)
						{
							awaiter = ((CvsCogSocketSheet)ehm8KY55HFiVpBRQhe86(autoExposure.InSight.CogSocket)).ClearCellsAsync(autoExposure.CellRange).GetAwaiter();
							num3 = 5;
							if (!fnGaRh55YAUXuHt5AuSo())
							{
								goto IL_0169;
							}
							goto IL_0190;
						}
						goto end_IL_0065;
						IL_0128:
						obj = null;
						goto IL_0133;
						end_IL_0065:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					return;
				}
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
		internal static object ehm8KY55HFiVpBRQhe86(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fnGaRh55YAUXuHt5AuSo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AOoO0h55UHqOANkegYuG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private FloatViewModel IDvv2InUho;

	[CompilerGenerated]
	private FloatViewModel sf7vqslwZe;

	[CompilerGenerated]
	private FloatViewModel S3Hvisd5rV;

	[CompilerGenerated]
	private FloatViewModel aGLvkX93pT;

	[CompilerGenerated]
	private FloatViewModel OS3vPOGERC;

	[CompilerGenerated]
	private FloatViewModel fk4vsMRK2L;

	[CompilerGenerated]
	private FloatViewModel roTvKi6f1X;

	protected new SetupImageStepViewModel Parent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (SetupImageStepViewModel)base.Parent;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			base.Parent = value;
		}
	}

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.X3xBge6luv();
		}
	}

	public FloatViewModel Threshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IDvv2InUho;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IDvv2InUho = value;
		}
	}

	public FloatViewModel Contrast
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sf7vqslwZe;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sf7vqslwZe = value;
		}
	}

	public FloatViewModel DarkCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return S3Hvisd5rV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			S3Hvisd5rV = value;
		}
	}

	public FloatViewModel BrightCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aGLvkX93pT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aGLvkX93pT = value;
		}
	}

	public FloatViewModel Average
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OS3vPOGERC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OS3vPOGERC = value;
		}
	}

	public FloatViewModel Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fk4vsMRK2L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fk4vsMRK2L = value;
		}
	}

	public FloatViewModel Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return roTvKi6f1X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			roTvKi6f1X = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutoExposure(SetupImageStepViewModel imageStep, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		NEMGriHzgW8P302dxxP();
		base._002Ector(imageStep, localizer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!e81kIEHtj310cwugopy())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (!RXNTI2HhI9QIBkh1b0Y())
			{
				goto IL_0041;
			}
		}
		CvsCellRange cellRange = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				cellRange = CellRange;
				break;
			case 1:
			case 3:
				break;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0080;
			case 4:
				goto IL_0080;
			}
			break;
		}
		goto IL_0041;
		IL_0080:
		IEnumerator<CvsCellLocation> enumerator = default;
		try
		{
			string text = default;
			while (enumerator.MoveNext())
			{
				CvsCellLocation current = enumerator.Current;
				int num2 = 19;
				if (1 == 0)
				{
					continue;
				}
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 19:
					{
						object obj2 = BT0ASMxLuCEYCRRPx8r(cells, current);
						if (obj2 == null)
						{
							num2 = 5;
							if (true)
							{
								continue;
							}
							goto case 10;
						}
						obj = ((CvsCell)obj2).Name;
						goto IL_02bf;
					}
					case 10:
						Contrast = new FloatViewModel(InSight, cells, current, (string)jSgJIKxwEQjqxftCBmW());
						AddProperty(Contrast);
						num2 = 2;
						continue;
					case 7:
						BrightCount = new FloatViewModel(InSight, cells, current, (string)PjK9GUxJoSwGuhWayR4());
						AddProperty(BrightCount);
						num2 = 4;
						continue;
					case 13:
						AddProperty(DarkCount);
						goto default;
					default:
						RXNTI2HhI9QIBkh1b0Y();
						if (!e81kIEHtj310cwugopy())
						{
							num2 = 18;
							continue;
						}
						num2 = 11;
						if (e81kIEHtj310cwugopy())
						{
						}
						continue;
					case 15:
						if (!Yxu3o6x52LcKdXo3Afg(text, UZbBAOxKhDF0s0atgFF(28422), StringComparison.Ordinal))
						{
							if (Yxu3o6x52LcKdXo3Afg(text, UZbBAOxKhDF0s0atgFF(28462), StringComparison.Ordinal))
							{
								num2 = 10;
								continue;
							}
							if (Yxu3o6x52LcKdXo3Afg(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(28500), StringComparison.Ordinal))
							{
								DarkCount = new FloatViewModel(InSight, cells, current, Resources.xYnZ8LIGMx());
								num2 = 13;
								continue;
							}
							if (Yxu3o6x52LcKdXo3Afg(text, UZbBAOxKhDF0s0atgFF(28540), StringComparison.Ordinal))
							{
								num2 = 7;
								if (e81kIEHtj310cwugopy())
								{
								}
								continue;
							}
							if (Yxu3o6x52LcKdXo3Afg(text, UZbBAOxKhDF0s0atgFF(28584), StringComparison.Ordinal))
							{
								goto case 11;
							}
							if (!Yxu3o6x52LcKdXo3Afg(text, UZbBAOxKhDF0s0atgFF(28620), StringComparison.Ordinal))
							{
								if (Yxu3o6x52LcKdXo3Afg(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(28674), StringComparison.Ordinal))
								{
									Height = new FloatViewModel(InSight, cells, current, (string)UZbBAOxKhDF0s0atgFF(2374));
									num2 = 17;
									if (e81kIEHtj310cwugopy())
									{
									}
									continue;
								}
								break;
							}
							num2 = 16;
							if (RXNTI2HhI9QIBkh1b0Y())
							{
								continue;
							}
							goto case 17;
						}
						num2 = 6;
						continue;
					case 0:
						AddProperty(Width);
						num2 = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 5;
					case 5:
						obj = null;
						goto IL_02bf;
					case 1:
						AddProperty(Threshold);
						num2 = 3;
						continue;
					case 16:
						Width = new FloatViewModel(InSight, cells, current, (string)UZbBAOxKhDF0s0atgFF(28660));
						num2 = 0;
						continue;
					case 6:
						Threshold = new FloatViewModel(InSight, cells, current, Resources.Threshold);
						num2 = 1;
						if (RXNTI2HhI9QIBkh1b0Y())
						{
							continue;
						}
						goto case 11;
					case 11:
					case 12:
						Average = new FloatViewModel(InSight, cells, current, (string)cDaJWFxa4kqK0Q8dOWL());
						AddProperty(Average);
						num2 = 14;
						continue;
					case 17:
						AddProperty(Height);
						num2 = 20;
						if (RXNTI2HhI9QIBkh1b0Y())
						{
							continue;
						}
						break;
					case 2:
					case 3:
					case 4:
					case 8:
					case 9:
					case 14:
					case 18:
					case 20:
						break;
						IL_02bf:
						text = (string)obj;
						if (text != null)
						{
							num2 = 15;
							continue;
						}
						break;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				M7ynA7xekFPWIPbxOJp(enumerator);
			}
		}
		return (Task)F1arX1xOVZ6lTmJ0V36();
		IL_0041:
		enumerator = cellRange.GetEnumerator();
		goto IL_0080;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerator<CellViewModel> enumerator = Properties.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.Refresh(cells);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				M7ynA7xekFPWIPbxOJp(enumerator);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunAutoExposureAsync_003Ed__37))]
	public Task RunAutoExposureAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (RXNTI2HhI9QIBkh1b0Y())
		{
			num = 5;
			if (e81kIEHtj310cwugopy())
			{
			}
		}
		else
		{
			num = 2;
		}
		_003CRunAutoExposureAsync_003Ed__37 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = HdRZhvxIe1XGLVs7sTG();
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClear_003Ed__38))]
	public Task Clear()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CClear_003Ed__38 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = HdRZhvxIe1XGLVs7sTG();
				_ = 0;
				num = ((!RXNTI2HhI9QIBkh1b0Y()) ? 2 : 0);
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NEMGriHzgW8P302dxxP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RXNTI2HhI9QIBkh1b0Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e81kIEHtj310cwugopy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BT0ASMxLuCEYCRRPx8r(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UZbBAOxKhDF0s0atgFF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Yxu3o6x52LcKdXo3Afg(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jSgJIKxwEQjqxftCBmW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Contrast;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PjK9GUxJoSwGuhWayR4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DFlBiTGik6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cDaJWFxa4kqK0Q8dOWL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.H78BWp8V4p();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M7ynA7xekFPWIPbxOJp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F1arX1xOVZ6lTmJ0V36()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder HdRZhvxIe1XGLVs7sTG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
