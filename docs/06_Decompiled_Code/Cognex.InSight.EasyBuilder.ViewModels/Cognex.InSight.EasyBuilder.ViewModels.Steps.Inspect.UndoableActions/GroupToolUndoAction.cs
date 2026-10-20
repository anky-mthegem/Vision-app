using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class GroupToolUndoAction : IUndoAction
{
	private class BACKaw7ulBMk8yj04A : IAsyncDisposable
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CPause_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IAsyncDisposable> _003C_003Et__builder;

			public IInSightAppStep inspect;

			public string text;

			private BACKaw7ulBMk8yj04A _003Cblocker_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				TZ9Nqx5ZsRTA3xWnOf59();
				int num;
				if (!jb3IPW5ZvpfVogxvT1Mi())
				{
					num = 1;
				}
				else
				{
					num = 5;
					if (1 == 0)
					{
						goto IL_0074;
					}
				}
				goto IL_0041;
				IL_0041:
				int num2 = default;
				TaskAwaiter awaiter = default;
				IAsyncDisposable result = default;
				while (true)
				{
					switch (num)
					{
					case 2:
						_003Cblocker_003E5__2 = null;
						break;
					case 0:
					case 1:
						num2 = _003C_003E1__state;
						num = 4;
						continue;
					case 4:
						try
						{
							int num3;
							if (num2 != 0)
							{
								_003Cblocker_003E5__2 = new BACKaw7ulBMk8yj04A(inspect, text);
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
							}
							while (true)
							{
								switch (num3)
								{
								case 9:
									num2 = (_003C_003E1__state = -1);
									goto IL_00cb;
								case 2:
								case 4:
									num2 = (_003C_003E1__state = 0);
									num3 = 6;
									continue;
								case 6:
									_003C_003Eu__1 = awaiter;
									goto case 0;
								default:
									num3 = 0;
									continue;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								case 5:
									awaiter = GnqA905ZP7q9CTTw7iFR(c31kYQ5ZrKkg6IjQVsrb(_003Cblocker_003E5__2));
									jb3IPW5ZvpfVogxvT1Mi();
									num3 = ((!TZ9Nqx5ZsRTA3xWnOf59()) ? 4 : 8);
									continue;
								case 1:
								case 8:
									if (awaiter.IsCompleted)
									{
										goto IL_00cb;
									}
									goto case 2;
								case 7:
									return;
								case 3:
									_003C_003Eu__1 = default;
									num3 = 9;
									continue;
								case 10:
									{
										result = _003Cblocker_003E5__2;
										break;
									}
									IL_00cb:
									awaiter.GetResult();
									num3 = 10;
									continue;
								}
								break;
							}
						}
						catch (Exception exception)
						{
							_003C_003E1__state = -2;
							_003Cblocker_003E5__2 = null;
							_003C_003Et__builder.SetException(exception);
							return;
						}
						_003C_003E1__state = -2;
						num = 2;
						if (TZ9Nqx5ZsRTA3xWnOf59())
						{
							continue;
						}
						return;
					case 6:
						return;
					}
					break;
				}
				goto IL_0074;
				IL_0074:
				_003C_003Et__builder.SetResult(result);
				num = 6;
				goto IL_0041;
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
			internal static object c31kYQ5ZrKkg6IjQVsrb(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((BACKaw7ulBMk8yj04A)P_0).W3o1x5755y();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter GnqA905ZP7q9CTTw7iFR(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool TZ9Nqx5ZsRTA3xWnOf59()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool jb3IPW5ZvpfVogxvT1Mi()
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
		private struct _003CPause_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public BACKaw7ulBMk8yj04A _003C_003E4__this;

			private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 5;
				int num2 = default;
				BACKaw7ulBMk8yj04A bACKaw7ulBMk8yj04A = default;
				TaskAwaiter<IAsyncDisposable> awaiter = default;
				IAsyncDisposable result = default;
				while (true)
				{
					switch (num)
					{
					case 1:
					case 2:
						try
						{
							int num3;
							if (num2 != 0)
							{
								bACKaw7ulBMk8yj04A.G7T1qMt7QJ = bACKaw7ulBMk8yj04A.coD1v6lVSq();
								V2Oy015ZBOYpHIoMdsfE();
								if (VqK5n25ZZCqOLqDlu2n8())
								{
									num3 = 3;
									if (!VqK5n25ZZCqOLqDlu2n8())
									{
										goto IL_004a;
									}
								}
								else
								{
									num3 = 5;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 4;
								if (false)
								{
									goto IL_0142;
								}
							}
							goto IL_006a;
							IL_004a:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							IL_006a:
							while (true)
							{
								switch (num3)
								{
								case 9:
									break;
								default:
									num3 = 6;
									continue;
								case 1:
									num2 = (_003C_003E1__state = -1);
									goto IL_0142;
								case 0:
								case 3:
									awaiter = ((EasyBuilderApplicationViewModel)jYfSLV5ZbkRZKwFVrDw7(bACKaw7ulBMk8yj04A.adg1eGUHlW)).PauseResults().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									goto IL_0142;
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									if (VqK5n25ZZCqOLqDlu2n8())
									{
										continue;
									}
									goto case 8;
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 9;
									continue;
								case 4:
									_003C_003Eu__1 = default;
									num3 = 1;
									continue;
								case 6:
									return;
								case 5:
								case 7:
									goto IL_0142;
								case 10:
									goto IL_015a;
								}
								break;
							}
							goto IL_004a;
							IL_015a:
							bACKaw7ulBMk8yj04A.tSA1ibVMV1 = result;
							goto end_IL_0018;
							IL_0142:
							result = awaiter.GetResult();
							num3 = 10;
							if (!V2Oy015ZBOYpHIoMdsfE())
							{
								goto IL_006a;
							}
							goto IL_015a;
							end_IL_0018:;
						}
						catch (Exception exception)
						{
							_003C_003E1__state = -2;
							_003C_003Et__builder.SetException(exception);
							return;
						}
						_003C_003E1__state = -2;
						break;
					case 0:
						bACKaw7ulBMk8yj04A = _003C_003E4__this;
						V2Oy015ZBOYpHIoMdsfE();
						if (!VqK5n25ZZCqOLqDlu2n8())
						{
							num = 4;
							continue;
						}
						num = 1;
						if (V2Oy015ZBOYpHIoMdsfE())
						{
						}
						continue;
					case 5:
						num2 = _003C_003E1__state;
						num = 0;
						continue;
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
			internal static object jYfSLV5ZbkRZKwFVrDw7(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((IInSightAppStep)P_0).AppViewModel;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool VqK5n25ZZCqOLqDlu2n8()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool V2Oy015ZBOYpHIoMdsfE()
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
		private struct _003CDisposeAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncValueTaskMethodBuilder _003C_003Et__builder;

			public BACKaw7ulBMk8yj04A _003C_003E4__this;

			private ValueTaskAwaiter _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 3;
				if (false)
				{
					goto IL_001a;
				}
				goto IL_029e;
				IL_001a:
				_003C_003Et__builder.SetResult();
				num = 6;
				goto IL_029e;
				IL_029e:
				BACKaw7ulBMk8yj04A bACKaw7ulBMk8yj04A = default;
				int num2 = default;
				TaskAwaiter awaiter = default;
				ValueTaskAwaiter awaiter2 = default;
				while (true)
				{
					switch (num)
					{
					case 5:
						break;
					case 0:
					case 1:
						bACKaw7ulBMk8yj04A = _003C_003E4__this;
						goto case 2;
					case 2:
					case 4:
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 3;
									if (CyqpFg5Zo5uhM1jCHUID())
									{
									}
								}
								else
								{
									awaiter = _003C_003Eu__2;
									num3 = 14;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								num3 = 4;
								if (1 == 0)
								{
									goto IL_017d;
								}
							}
							goto IL_00b7;
							IL_009e:
							awaiter2.GetResult();
							goto IL_014e;
							IL_0246:
							awaiter = tY2LET5ZqgZ2Em3bfZoY(FZBsQJ5Z8adLvyLYFVlX());
							num3 = 2;
							goto IL_00b7;
							IL_017d:
							if (awaiter2.IsCompleted)
							{
								goto IL_009e;
							}
							num3 = 15;
							if (0 == 0)
							{
								goto IL_00b7;
							}
							goto IL_0195;
							IL_01b6:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							IL_00b7:
							while (true)
							{
								switch (num3)
								{
								case 7:
								case 11:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter;
									num3 = 0;
									continue;
								case 16:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 12;
									if (true)
									{
										continue;
									}
									break;
								case 10:
									break;
								default:
									num3 = 6;
									continue;
								case 3:
									awaiter2 = fmVDHo5ZSluKNG1TZEFW(bACKaw7ulBMk8yj04A.tSA1ibVMV1).GetAwaiter();
									_ = 0;
									if (s19U1b5ZG2eH7wjWdfd3())
									{
										num3 = 8;
										continue;
									}
									num3 = 7;
									if (!CyqpFg5Zo5uhM1jCHUID())
									{
										continue;
									}
									goto case 9;
								case 14:
									_003C_003Eu__2 = default;
									num3 = 5;
									continue;
								case 6:
									goto IL_014e;
								case 12:
									return;
								case 1:
								case 8:
									goto IL_017d;
								case 4:
									goto IL_0195;
								case 0:
									goto IL_01b6;
								case 2:
									if (!awaiter.IsCompleted)
									{
										goto case 7;
									}
									goto case 17;
								case 9:
									_003C_003Eu__1 = awaiter2;
									num3 = 16;
									continue;
								case 5:
									num2 = (_003C_003E1__state = -1);
									num3 = 17;
									if (0 == 0)
									{
										continue;
									}
									goto case 15;
								case 15:
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									if (s19U1b5ZG2eH7wjWdfd3())
									{
										continue;
									}
									goto IL_0246;
								case 13:
									goto IL_0246;
								case 17:
									awaiter.GetResult();
									goto end_IL_0048;
								}
								break;
							}
							goto IL_009e;
							IL_0195:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 10;
							if (true)
							{
								goto IL_00b7;
							}
							goto IL_01b6;
							IL_014e:
							IDisposable g7T1qMt7QJ = bACKaw7ulBMk8yj04A.G7T1qMt7QJ;
							if (g7T1qMt7QJ == null)
							{
								num3 = 13;
								goto IL_00b7;
							}
							C8PgDZ5ZkICUMHOklehh(g7T1qMt7QJ);
							goto IL_0246;
							end_IL_0048:;
						}
						catch (Exception exception)
						{
							_003C_003E1__state = -2;
							_003C_003Et__builder.SetException(exception);
							return;
						}
						_003C_003E1__state = -2;
						break;
					default:
						num = 5;
						if (s19U1b5ZG2eH7wjWdfd3())
						{
							continue;
						}
						goto case 3;
					case 3:
						num2 = _003C_003E1__state;
						CyqpFg5Zo5uhM1jCHUID();
						if (!s19U1b5ZG2eH7wjWdfd3())
						{
							num = 4;
							if (0 == 0)
							{
								continue;
							}
							goto case 2;
						}
						num = 0;
						continue;
					case 6:
						return;
					}
					break;
				}
				goto IL_001a;
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
			internal static ValueTask fmVDHo5ZSluKNG1TZEFW(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((IAsyncDisposable)P_0).DisposeAsync();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void C8PgDZ5ZkICUMHOklehh(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((IDisposable)P_0).Dispose();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object FZBsQJ5Z8adLvyLYFVlX()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return Task.CompletedTask;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter tY2LET5ZqgZ2Em3bfZoY(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool s19U1b5ZG2eH7wjWdfd3()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool CyqpFg5Zo5uhM1jCHUID()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		private readonly IInSightAppStep adg1eGUHlW;

		private readonly string zQp129G0p7;

		private IDisposable G7T1qMt7QJ;

		private IAsyncDisposable tSA1ibVMV1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private BACKaw7ulBMk8yj04A(IInSightAppStep P_0, string P_1)
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
				default:
					zQp129G0p7 = P_1;
					num = 6;
					if (!eaqBwNKcnKWKU1rl10Q2())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					jMtlZbKcfJDMFrL2UGRO(this);
					num = 5;
					break;
				case 4:
					dPs7hBKcVqG402j3QIbK();
					eaqBwNKcnKWKU1rl10Q2();
					num = (FgahdeKciLcXjw0JJuQ7() ? 2 : 0);
					break;
				case 5:
					adg1eGUHlW = P_0;
					goto default;
				case 6:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CPause_003Ed__5))]
		public static Task<IAsyncDisposable> Nrm1yA5R06(IInSightAppStep P_0, string P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CPause_003Ed__5 stateMachine = default;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IAsyncDisposable>.Create();
			stateMachine.inspect = P_0;
			stateMachine.text = P_1;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CPause_003Ed__6))]
		private Task W3o1x5755y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (eaqBwNKcnKWKU1rl10Q2())
			{
				goto IL_001e;
			}
			goto IL_0038;
			IL_001e:
			_003CPause_003Ed__6 stateMachine = default;
			stateMachine._003C_003E1__state = -1;
			goto IL_007b;
			IL_0038:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					num = 0;
					continue;
				case 1:
				case 3:
					stateMachine._003C_003E4__this = this;
					break;
				case 0:
					goto IL_007b;
				case 4:
					goto IL_0093;
				case 6:
					return stateMachine._003C_003Et__builder.Task;
				}
				break;
				IL_0093:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = (FgahdeKciLcXjw0JJuQ7() ? 3 : 5);
			}
			goto IL_001e;
			IL_007b:
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			num = 6;
			goto IL_0038;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__7))]
		public ValueTask DisposeAsync()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			_003CDisposeAsync_003Ed__7 stateMachine = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					stateMachine._003C_003E1__state = -1;
					goto default;
				default:
					stateMachine._003C_003Et__builder.Start(ref stateMachine);
					num = 6;
					continue;
				case 5:
					stateMachine._003C_003Et__builder = fp84pQKcd3KWRAdu0VZa();
					eaqBwNKcnKWKU1rl10Q2();
					num = (FgahdeKciLcXjw0JJuQ7() ? 2 : 4);
					continue;
				case 1:
				case 2:
					stateMachine._003C_003E4__this = this;
					num = 0;
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
		private IDisposable coD1v6lVSq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			IOperationProgressManager operationProgressManager = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					operationProgressManager = (IOperationProgressManager)CsClJdKcgIV053SWB9E1(fO2I5fKclNuU4EK4kHvh(adg1eGUHlW));
					_ = 0;
					num = ((!FgahdeKciLcXjw0JJuQ7()) ? 4 : 3);
					continue;
				default:
					if (!sK0PTQKcsfno0m1aRdSG(operationProgressManager))
					{
						break;
					}
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					if (operationProgressManager == null)
					{
						break;
					}
					goto default;
				case 5:
					return (IDisposable)pMMFA1KcvD4KChbs9HCf(((EasyBuilderApplicationViewModel)fO2I5fKclNuU4EK4kHvh(adg1eGUHlW)).OperationProgressManager, zQp129G0p7, Array.Empty<StepDescriptor>());
				}
				break;
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dPs7hBKcVqG402j3QIbK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jMtlZbKcfJDMFrL2UGRO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FgahdeKciLcXjw0JJuQ7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eaqBwNKcnKWKU1rl10Q2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AsyncValueTaskMethodBuilder fp84pQKcd3KWRAdu0VZa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AsyncValueTaskMethodBuilder.Create();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fO2I5fKclNuU4EK4kHvh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CsClJdKcgIV053SWB9E1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sK0PTQKcsfno0m1aRdSG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).HasNoOperationsPending;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pMMFA1KcvD4KChbs9HCf(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GroupToolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003Cblocker_003E5__2;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		private ValueTaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			GroupToolUndoAction groupToolUndoAction = default;
			TaskAwaiter awaiter3 = default;
			int num2 = default;
			do
			{
				IL_03a4:
				switch (num)
				{
				case 1:
				case 3:
					groupToolUndoAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = BACKaw7ulBMk8yj04A.Nrm1yA5R06(groupToolUndoAction.Inspect, groupToolUndoAction.Text).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00a7;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00a7;
						case 1:
						case 2:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 8;
									if (false)
									{
										goto IL_00d8;
									}
									goto IL_0196;
								}
								awaiter3 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_017d;
								IL_0196:
								while (true)
								{
									switch (num3)
									{
									case 7:
										break;
									case 11:
									case 15:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 12:
										num2 = (_003C_003E1__state = 1);
										num3 = 9;
										if (eF6GbfKcr2FBMaALRnIo())
										{
											continue;
										}
										goto case 9;
									case 9:
										_003C_003Eu__2 = awaiter3;
										num3 = 10;
										continue;
									case 6:
										num2 = (_003C_003E1__state = 2);
										num3 = 7;
										if (true)
										{
											continue;
										}
										return;
									case 4:
										return;
									default:
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 8;
									case 8:
										if (num2 == 2)
										{
											awaiter3 = _003C_003Eu__2;
											num3 = 3;
										}
										else
										{
											num3 = 14;
										}
										continue;
									case 5:
									case 13:
										num2 = (_003C_003E1__state = -1);
										num3 = 16;
										continue;
									case 1:
										goto IL_020f;
									case 3:
										_003C_003Eu__2 = default;
										goto case 5;
									case 10:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 4;
										continue;
									case 2:
										if (!awaiter3.IsCompleted)
										{
											num3 = 6;
											continue;
										}
										goto case 16;
									case 0:
										goto IL_026f;
									case 14:
										awaiter3 = ((Task)GFLEZxKcZ1yA0dvliEtR(groupToolUndoAction.TKIOePJfxv())).GetAwaiter();
										num3 = 1;
										continue;
									case 16:
										awaiter3.GetResult();
										goto end_IL_00c5;
									}
									break;
									IL_020f:
									if (!awaiter3.IsCompleted)
									{
										num3 = 12;
										continue;
									}
									goto IL_017d;
								}
								goto IL_00d8;
								IL_026f:
								awaiter3 = groupToolUndoAction.FUuOxFsoYc().GetAwaiter();
								num3 = 2;
								goto IL_0196;
								IL_00d8:
								_003C_003Eu__2 = awaiter3;
								_ = 1;
								num3 = (TyXvNHKcPID2O6mfNG2H() ? 5 : 15);
								goto IL_0196;
								IL_017d:
								awaiter3.GetResult();
								goto IL_026f;
								end_IL_00c5:;
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003Cblocker_003E5__2 == null)
							{
								break;
							}
							awaiter = cYN4GfKcBuGqj4xgQvxs(_003Cblocker_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_032b;
						case 3:
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_032b;
							}
							IL_032b:
							awaiter.GetResult();
							break;
							IL_00a7:
							result = awaiter2.GetResult();
							_003Cblocker_003E5__2 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							WQ28Y3KcGnvG2ZXwDPtH(yNPSAyKcbY8deTkk1taD((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
						_003Cblocker_003E5__2 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 0;
					goto IL_03a4;
				case 4:
					num2 = _003C_003E1__state;
					TyXvNHKcPID2O6mfNG2H();
					num = (eF6GbfKcr2FBMaALRnIo() ? 3 : 5);
					goto IL_03a4;
				case 0:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (0 == 0);
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
		internal static object GFLEZxKcZ1yA0dvliEtR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoActionList)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask cYN4GfKcBuGqj4xgQvxs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yNPSAyKcbY8deTkk1taD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WQ28Y3KcGnvG2ZXwDPtH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eF6GbfKcr2FBMaALRnIo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TyXvNHKcPID2O6mfNG2H()
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
	private struct _003CRedo_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GroupToolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003Cblocker_003E5__2;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		private ValueTaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RaFvcyKcSschthJR1JWY();
			int num = ((!xqodAOKcoTJ0GngAeFJG()) ? 2 : 4);
			GroupToolUndoAction groupToolUndoAction = default;
			TaskAwaiter awaiter3 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					groupToolUndoAction = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = BACKaw7ulBMk8yj04A.Nrm1yA5R06(groupToolUndoAction.Inspect, groupToolUndoAction.Text).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00c2;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00c2;
						case 1:
						case 2:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 1;
								}
								else
								{
									awaiter3 = _003C_003Eu__2;
									num3 = 2;
									if (false)
									{
										goto IL_023f;
									}
								}
								goto IL_01a5;
								IL_0115:
								if (num2 != 2)
								{
									awaiter3 = ((Task)bDLsahKck5Xu8DhQYXCn(groupToolUndoAction.TKIOePJfxv())).GetAwaiter();
									num3 = 5;
									if (RaFvcyKcSschthJR1JWY())
									{
										goto IL_013e;
									}
								}
								else
								{
									awaiter3 = _003C_003Eu__2;
									num3 = 14;
								}
								goto IL_01a5;
								IL_020e:
								_003C_003Eu__2 = default;
								num3 = 13;
								if (false)
								{
									return;
								}
								goto IL_01a5;
								IL_01a5:
								while (true)
								{
									switch (num3)
									{
									case 9:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 11:
										return;
									case 1:
										break;
									case 4:
										goto IL_013e;
									case 0:
										return;
									case 2:
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										num3 = 6;
										if (xqodAOKcoTJ0GngAeFJG())
										{
											continue;
										}
										goto IL_018c;
									case 6:
										goto IL_018c;
									default:
										goto IL_01ee;
									case 14:
										goto IL_020e;
									case 15:
										return;
									case 5:
										goto IL_023f;
									case 12:
										if (!awaiter3.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											num3 = 4;
											if (0 == 0)
											{
												continue;
											}
											goto case 8;
										}
										goto case 16;
									case 8:
										_003C_003Eu__2 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 15;
										if (0 == 0)
										{
											continue;
										}
										goto case 10;
									case 10:
										num2 = (_003C_003E1__state = 1);
										num3 = 8;
										if (RaFvcyKcSschthJR1JWY())
										{
										}
										continue;
									case 3:
									case 7:
										awaiter3 = yNkmZRKc8AoyTuAQcq4Y(groupToolUndoAction.FUuOxFsoYc());
										num3 = 12;
										if (xqodAOKcoTJ0GngAeFJG())
										{
											continue;
										}
										goto case 13;
									case 13:
										num2 = (_003C_003E1__state = -1);
										num3 = 16;
										if (xqodAOKcoTJ0GngAeFJG())
										{
											continue;
										}
										goto case 16;
									case 16:
										awaiter3.GetResult();
										goto end_IL_00e0;
									}
									break;
								}
								goto IL_0115;
								IL_01ee:
								xqodAOKcoTJ0GngAeFJG();
								if (RaFvcyKcSschthJR1JWY())
								{
									num3 = 0;
									if (!xqodAOKcoTJ0GngAeFJG())
									{
										goto IL_0115;
									}
								}
								else
								{
									num3 = 3;
									if (!xqodAOKcoTJ0GngAeFJG())
									{
										goto IL_020e;
									}
								}
								goto IL_01a5;
								IL_023f:
								if (awaiter3.IsCompleted)
								{
									goto IL_018c;
								}
								num3 = 10;
								goto IL_01a5;
								IL_013e:
								_003C_003Eu__2 = awaiter3;
								num3 = 9;
								goto IL_01a5;
								IL_018c:
								awaiter3.GetResult();
								goto IL_01ee;
								end_IL_00e0:;
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003Cblocker_003E5__2 == null)
							{
								break;
							}
							awaiter = JcAohWKcqcRUtH9plcIY(_003Cblocker_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0374;
						case 3:
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0374;
							}
							IL_0374:
							awaiter.GetResult();
							break;
							IL_00c2:
							result = awaiter2.GetResult();
							_003Cblocker_003E5__2 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							((ExceptionDispatchInfo)RK2huOKcETWGNSRYpcUl((obj2 as Exception) ?? throw obj2)).Throw();
						}
						_003C_003E7__wrap2 = null;
						_003Cblocker_003E5__2 = null;
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
		internal static object bDLsahKck5Xu8DhQYXCn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoActionList)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter yNkmZRKc8AoyTuAQcq4Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask JcAohWKcqcRUtH9plcIY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RK2huOKcETWGNSRYpcUl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xqodAOKcoTJ0GngAeFJG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RaFvcyKcSschthJR1JWY()
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
	private struct _003CSaveState_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GroupToolUndoAction _003C_003E4__this;

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
			GroupToolUndoAction groupToolUndoAction = default;
			while (true)
			{
				IL_015b:
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Hf87w9Kc4syWHaQPfYCu(BIQiHpKc9vC0Im90E5iL(groupToolUndoAction.TKIOePJfxv()));
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 8:
								return;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 1:
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								num3 = ((!URndQFKcXIybM1j221oH()) ? 1 : 7);
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 9:
								break;
							}
							break;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 4;
					continue;
				case 1:
				case 5:
					groupToolUndoAction = _003C_003E4__this;
					goto case 0;
				case 3:
					while (true)
					{
						num2 = _003C_003E1__state;
						URndQFKcXIybM1j221oH();
						if (J72Bb8Kcpfvdwt1UbHWo())
						{
							break;
						}
						num = 0;
						if (0 == 0)
						{
							goto IL_015b;
						}
					}
					num = 5;
					if (J72Bb8Kcpfvdwt1UbHWo())
					{
						continue;
					}
					break;
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
		internal static object BIQiHpKc9vC0Im90E5iL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoActionList)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Hf87w9Kc4syWHaQPfYCu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J72Bb8Kcpfvdwt1UbHWo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool URndQFKcXIybM1j221oH()
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
	private struct _003CUndo_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GroupToolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003Cblocker_003E5__2;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		private ValueTaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!Rdq5StKc3Odn53O7iVvq())
			{
				num = 4;
				if (!dLAZfVKc7LlFIuH4Ejax())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (!dLAZfVKc7LlFIuH4Ejax())
				{
					return;
				}
			}
			goto IL_03e3;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_03e3;
			IL_03e3:
			GroupToolUndoAction groupToolUndoAction = default;
			TaskAwaiter awaiter3 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = BACKaw7ulBMk8yj04A.Nrm1yA5R06(groupToolUndoAction.Inspect, groupToolUndoAction.UndoText).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00c8;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00c8;
						case 1:
						case 2:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 13;
									if (Rdq5StKc3Odn53O7iVvq())
									{
									}
								}
								else
								{
									awaiter3 = _003C_003Eu__2;
									num3 = 15;
								}
								while (true)
								{
									switch (num3)
									{
									case 5:
										awaiter3 = MOZrpAKc6dq9iH7ZhK6i(groupToolUndoAction.FUuOxFsoYc());
										num3 = 0;
										if (Rdq5StKc3Odn53O7iVvq())
										{
										}
										continue;
									case 12:
										num2 = (_003C_003E1__state = -1);
										goto case 2;
									default:
										num3 = 2;
										if (0 == 0)
										{
											continue;
										}
										return;
									case 6:
										return;
									case 15:
										_003C_003Eu__2 = default;
										num3 = 12;
										continue;
									case 14:
										_003C_003Eu__2 = awaiter3;
										num3 = 7;
										if (!Rdq5StKc3Odn53O7iVvq())
										{
											continue;
										}
										goto case 1;
									case 1:
									case 9:
										awaiter3 = MOZrpAKc6dq9iH7ZhK6i(eFOaCRKcjNvKvn0k49Sg(groupToolUndoAction.TKIOePJfxv()));
										num3 = 10;
										continue;
									case 11:
										return;
									case 7:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 6;
										if (Rdq5StKc3Odn53O7iVvq())
										{
										}
										continue;
									case 10:
										if (awaiter3.IsCompleted)
										{
											goto case 2;
										}
										goto case 3;
									case 13:
										if (num2 == 2)
										{
											awaiter3 = _003C_003Eu__2;
											_003C_003Eu__2 = default;
											num3 = 8;
										}
										else
										{
											Rdq5StKc3Odn53O7iVvq();
											num3 = (dLAZfVKc7LlFIuH4Ejax() ? 9 : 4);
										}
										continue;
									case 8:
										num2 = (_003C_003E1__state = -1);
										num3 = 16;
										continue;
									case 2:
										awaiter3.GetResult();
										num3 = 5;
										continue;
									case 3:
									case 4:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 11;
										continue;
									case 0:
										if (!awaiter3.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											num3 = 14;
											continue;
										}
										break;
									case 16:
										break;
									}
									break;
								}
								awaiter3.GetResult();
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003Cblocker_003E5__2 == null)
							{
								break;
							}
							awaiter = _003Cblocker_003E5__2.DisposeAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_036a;
						case 3:
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_036a;
							}
							IL_036a:
							awaiter.GetResult();
							break;
							IL_00c8:
							result = awaiter2.GetResult();
							_003Cblocker_003E5__2 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							I1FaJqKcAtnoXkXWd4Eg(Rc7mJYKcC2AFCJdleLFa((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
						_003Cblocker_003E5__2 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 1;
					if (dLAZfVKc7LlFIuH4Ejax())
					{
						continue;
					}
					goto case 3;
				case 3:
					groupToolUndoAction = _003C_003E4__this;
					goto case 2;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static object eFOaCRKcjNvKvn0k49Sg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoActionList)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MOZrpAKc6dq9iH7ZhK6i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Rc7mJYKcC2AFCJdleLFa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void I1FaJqKcAtnoXkXWd4Eg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dLAZfVKc7LlFIuH4Ejax()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Rdq5StKc3Odn53O7iVvq()
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
	private struct _003CRefreshViewModels_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GroupToolUndoAction _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oFAhupKcRa7SHmkeuoVu();
			int num;
			if (!EZ04w7KcW2TOAf2PYULV())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0056;
				}
			}
			goto IL_01d8;
			IL_01d8:
			GroupToolUndoAction groupToolUndoAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				case 5:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)goSSfWKcyoBjOPVchMKL(((CvsInSight)kKheE4KcTqTJAfv3rJ3g(groupToolUndoAction.Inspect)).CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						CvsCellCollection result = awaiter.GetResult();
						IEnumerator<EzTool> enumerator = groupToolUndoAction.Inspect.Tools.GetEnumerator();
						try
						{
							while (sJsVdNKc0GbGfiSwL6Tl(enumerator))
							{
								GroupTool groupTool = enumerator.Current as GroupTool;
								EZ04w7KcW2TOAf2PYULV();
								int num3;
								if (oFAhupKcRa7SHmkeuoVu())
								{
									num3 = 2;
								}
								else
								{
									num3 = 3;
									if (1 == 0)
									{
										continue;
									}
								}
								while (true)
								{
									switch (num3)
									{
									default:
										goto IL_0120;
									case 0:
									case 2:
										if (groupTool != null)
										{
											goto IL_0120;
										}
										break;
									case 4:
										break;
									}
									break;
									IL_0120:
									groupTool.nnG4uPQKIR(result);
									num3 = 4;
								}
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								CoVRXZKcFFNMgJV57Wdk(enumerator);
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					if (oFAhupKcRa7SHmkeuoVu())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0056;
			IL_0056:
			groupToolUndoAction = _003C_003E4__this;
			num = 5;
			goto IL_01d8;
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
		internal static object kKheE4KcTqTJAfv3rJ3g(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object goSSfWKcyoBjOPVchMKL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sJsVdNKc0GbGfiSwL6Tl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CoVRXZKcFFNMgJV57Wdk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oFAhupKcRa7SHmkeuoVu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EZ04w7KcW2TOAf2PYULV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly InspectStepViewModel tyFOqmSDCT;

	[CompilerGenerated]
	private readonly UndoActionList O30OiG18rN;

	[CompilerGenerated]
	private readonly string xpdOkgMKZ6;

	[CompilerGenerated]
	private readonly string uAOOPkm8AD;

	private InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tyFOqmSDCT;
		}
	}

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xpdOkgMKZ6;
		}
	}

	public string UndoText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uAOOPkm8AD;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupToolUndoAction(InspectStepViewModel inspect, string groupToolName, string childToolName, UndoActionList actions, bool isAdding)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		string text = default;
		string text2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				tyFOqmSDCT = inspect;
				goto case 1;
			case 6:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				base._002Ector();
				_ = 0;
				if (!hdrb3STtpidvcRdvvsD())
				{
					num = 1;
					break;
				}
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				text = (string)nAnygJyKwmWaGXX8Q2O(qkYtttyLMxXjIdhQdSx(), childToolName, groupToolName);
				goto case 5;
			default:
				num = 5;
				if (wCFR9FTzAYCun8geMUW())
				{
				}
				break;
			case 5:
				text2 = (string)nAnygJyKwmWaGXX8Q2O(Yx6mWry503rZoAdCQdb(), childToolName, groupToolName);
				num = 4;
				break;
			case 4:
				xpdOkgMKZ6 = (isAdding ? text : text2);
				uAOOPkm8AD = (isAdding ? text2 : text);
				O30OiG18rN = actions;
				num = 8;
				if (!hdrb3STtpidvcRdvvsD())
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
	[SpecialName]
	[CompilerGenerated]
	private UndoActionList TKIOePJfxv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return O30OiG18rN;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__13))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDo_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (!wCFR9FTzAYCun8geMUW())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003Et__builder = xDjh4tywBMcxZeAcoAR();
				_ = 1;
				num = (wCFR9FTzAYCun8geMUW() ? 4 : 2);
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__14))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!wCFR9FTzAYCun8geMUW())
		{
		}
		_003CRedo_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				if (hdrb3STtpidvcRdvvsD())
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				if (wCFR9FTzAYCun8geMUW())
				{
					num = 5;
					if (wCFR9FTzAYCun8geMUW())
					{
					}
					continue;
				}
				num = 2;
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
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__15))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CSaveState_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
				stateMachine._003C_003Et__builder = xDjh4tywBMcxZeAcoAR();
				_ = 1;
				num = (wCFR9FTzAYCun8geMUW() ? 5 : 4);
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__16))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CUndo_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				wCFR9FTzAYCun8geMUW();
				if (!hdrb3STtpidvcRdvvsD())
				{
					num = 0;
					continue;
				}
				num = 1;
				if (!wCFR9FTzAYCun8geMUW())
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
	[AsyncStateMachine(typeof(_003CRefreshViewModels_003Ed__17))]
	private Task FUuOxFsoYc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRefreshViewModels_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = ((!wCFR9FTzAYCun8geMUW()) ? 5 : 4);
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qkYtttyLMxXjIdhQdSx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.t3WGmGCSwN();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nAnygJyKwmWaGXX8Q2O(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Yx6mWry503rZoAdCQdb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Or59lNn0c6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hdrb3STtpidvcRdvvsD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wCFR9FTzAYCun8geMUW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder xDjh4tywBMcxZeAcoAR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
