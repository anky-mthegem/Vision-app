using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using IXHqQxfoEA8Uykucse;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class DeleteToolUndoAction : RemoveSnippetUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DeleteToolUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			DeleteToolUndoAction deleteToolUndoAction = default;
			do
			{
				IL_016a:
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = k97r9tKcLaJx9EjBOFde(deleteToolUndoAction.Hx0OO0Khf6());
							num3 = 0;
							if (!zywKckK2tq3tPhQqjQWs())
							{
								goto IL_003a;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						while (true)
						{
							IL_00c5:
							switch (num3)
							{
							case 2:
							case 4:
								break;
							case 6:
								while (true)
								{
									num2 = (_003C_003E1__state = 0);
									_ = 0;
									if (zywKckK2tq3tPhQqjQWs())
									{
										break;
									}
									num3 = 5;
									if (1 == 0)
									{
										continue;
									}
									goto IL_00c5;
								}
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 7;
								if (!V1q6u7K2zCBquZIU01u3())
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto IL_00a5;
							case 3:
							case 5:
								goto IL_00a5;
							default:
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 8:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_0018;
							}
							break;
						}
						goto IL_003a;
						IL_00a5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_003a:
						_003C_003Eu__1 = awaiter;
						goto IL_00a5;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					do
					{
						deleteToolUndoAction = _003C_003E4__this;
						zywKckK2tq3tPhQqjQWs();
						if (V1q6u7K2zCBquZIU01u3())
						{
							num = 5;
							continue;
						}
						num = 1;
						if (V1q6u7K2zCBquZIU01u3())
						{
						}
						break;
					}
					while (!zywKckK2tq3tPhQqjQWs());
					goto IL_016a;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						goto IL_016a;
					}
					break;
				case 0:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 4;
			}
			while (!V1q6u7K2zCBquZIU01u3());
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
		internal static TaskAwaiter k97r9tKcLaJx9EjBOFde(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zywKckK2tq3tPhQqjQWs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V1q6u7K2zCBquZIU01u3()
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
	private struct _003CUndo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DeleteToolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

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
			eVpS6iKcKyOUt1LX5DfD();
			int num;
			if (!uhFEshKc5Laeq89FHT9U())
			{
				num = 1;
			}
			else
			{
				num = 2;
				if (uhFEshKc5Laeq89FHT9U())
				{
					return;
				}
			}
			DeleteToolUndoAction deleteToolUndoAction = default;
			TaskAwaiter awaiter3 = default;
			int num4 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					deleteToolUndoAction = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = deleteToolUndoAction.Inspect.PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00db;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00db;
						case 1:
						case 2:
						case 3:
						case 4:
							try
							{
								int num3;
								switch (num2)
								{
								default:
									num3 = 14;
									if (uhFEshKc5Laeq89FHT9U())
									{
										goto IL_0121;
									}
									goto IL_01ac;
								case 1:
									awaiter3 = _003C_003Eu__2;
									_ = 0;
									if (eVpS6iKcKyOUt1LX5DfD())
									{
										num3 = 24;
									}
									else
									{
										num3 = 28;
										if (false)
										{
											goto IL_0357;
										}
									}
									goto IL_01ac;
								case 3:
									awaiter3 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num3 = 6;
									if (!uhFEshKc5Laeq89FHT9U())
									{
										goto IL_01ac;
									}
									goto IL_0305;
								case 2:
									awaiter3 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									goto IL_01ac;
								case 4:
									{
										awaiter3 = _003C_003Eu__2;
										num3 = 9;
										goto IL_01ac;
									}
									IL_026d:
									awaiter3.GetResult();
									num3 = 27;
									goto IL_01ac;
									IL_0357:
									num2 = (_003C_003E1__state = 3);
									num3 = 15;
									goto IL_01ac;
									IL_01ac:
									while (true)
									{
										switch (num3)
										{
										case 13:
											break;
										case 26:
											if (!awaiter3.IsCompleted)
											{
												num3 = 11;
												continue;
											}
											goto case 0;
										case 2:
											return;
										case 19:
											awaiter3 = JdufoeKcwn6Q2bRxycjZ(ihyKPnKcaksnbv0IxsXa(deleteToolUndoAction.Inspect));
											num3 = 23;
											continue;
										case 23:
											if (!awaiter3.IsCompleted)
											{
												goto IL_0357;
											}
											goto case 17;
										default:
											num3 = 4;
											continue;
										case 0:
											awaiter3.GetResult();
											num3 = 29;
											continue;
										case 14:
											awaiter3 = JdufoeKcwn6Q2bRxycjZ(deleteToolUndoAction.ocXOwkvNI6());
											num3 = 10;
											continue;
										case 21:
										case 28:
											_003C_003Eu__2 = awaiter3;
											num3 = 16;
											continue;
										case 1:
											goto IL_026d;
										case 18:
											num2 = (_003C_003E1__state = -1);
											num3 = 0;
											continue;
										case 22:
											if (!awaiter3.IsCompleted)
											{
												num2 = (_003C_003E1__state = 2);
												_003C_003Eu__2 = awaiter3;
												_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
												num3 = 25;
												continue;
											}
											goto case 7;
										case 15:
											_003C_003Eu__2 = awaiter3;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 10:
											goto IL_0305;
										case 12:
											goto IL_0321;
										case 11:
											num2 = (_003C_003E1__state = 4);
											goto case 21;
										case 4:
											goto IL_0357;
										case 5:
										case 24:
											_003C_003Eu__2 = default;
											num2 = (_003C_003E1__state = -1);
											num3 = 1;
											continue;
										case 3:
											awaiter3 = JdufoeKcwn6Q2bRxycjZ(S5uAT2KcJjlOU7KFsqYA(new L3xsfUdIkfTQrRcPb8(deleteToolUndoAction.AppStepVm, num4, deleteToolUndoAction._listPosition, "")));
											num3 = 22;
											if (eVpS6iKcKyOUt1LX5DfD())
											{
												continue;
											}
											return;
										case 25:
											return;
										case 27:
											num4 = deleteToolUndoAction.AppStepVm.Snippets.IndexOf(deleteToolUndoAction.Inspect.Tools.FirstOrDefault(deleteToolUndoAction.bnvOHqbTRh));
											num3 = 3;
											if (0 == 0)
											{
												continue;
											}
											goto case 16;
										case 16:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num3 = 20;
											continue;
										case 6:
											num2 = (_003C_003E1__state = -1);
											num3 = 17;
											continue;
										case 9:
											_003C_003Eu__2 = default;
											num3 = 18;
											if (eVpS6iKcKyOUt1LX5DfD())
											{
												continue;
											}
											goto case 8;
										case 8:
											awaiter3 = JdufoeKcwn6Q2bRxycjZ(deleteToolUndoAction.Inspect.SetCurrentSnippet(deleteToolUndoAction.Inspect.Snippets[deleteToolUndoAction._listPosition]));
											num3 = 26;
											continue;
										case 7:
											awaiter3.GetResult();
											num3 = 19;
											if (true)
											{
												continue;
											}
											goto case 17;
										case 17:
											awaiter3.GetResult();
											num3 = 8;
											if (eVpS6iKcKyOUt1LX5DfD())
											{
												continue;
											}
											return;
										case 20:
											return;
										case 29:
											A4HrSAKceG8poDGF7Zd5(deleteToolUndoAction.Inspect, null);
											goto end_IL_00fc;
										}
										break;
									}
									goto IL_0121;
									IL_0305:
									if (awaiter3.IsCompleted)
									{
										goto IL_026d;
									}
									num3 = 12;
									if (eVpS6iKcKyOUt1LX5DfD())
									{
										goto IL_01ac;
									}
									goto IL_0321;
									IL_0121:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 2;
									goto IL_01ac;
									IL_0321:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter3;
									num3 = 13;
									goto IL_01ac;
									end_IL_00fc:
									break;
								}
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003C_003E7__wrap1 == null)
							{
								break;
							}
							awaiter = yS2PlMKcOxcaky2CkRQ0(_003C_003E7__wrap1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 5);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_056c;
						case 5:
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_056c;
							}
							IL_056c:
							awaiter.GetResult();
							break;
							IL_00db:
							result = awaiter2.GetResult();
							_003C_003E7__wrap1 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							s1xt7TKcDHQtJIa9bDYx(mrFj7EKcIKW3jLwUi9mk((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
						_003C_003E7__wrap1 = null;
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
		internal static TaskAwaiter JdufoeKcwn6Q2bRxycjZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object S5uAT2KcJjlOU7KFsqYA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((L3xsfUdIkfTQrRcPb8)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ihyKPnKcaksnbv0IxsXa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).Ip9AfAmPAi();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void A4HrSAKceG8poDGF7Zd5(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).AddingSnippetType = (EzSnippetType)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask yS2PlMKcOxcaky2CkRQ0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mrFj7EKcIKW3jLwUi9mk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void s1xt7TKcDHQtJIa9bDYx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eVpS6iKcKyOUt1LX5DfD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uhFEshKc5Laeq89FHT9U()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly string GoLOyGl3ZY;

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GoLOyGl3ZY;
		}
	}

	protected InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (InspectStepViewModel)AppStepVm;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeleteToolUndoAction(InspectStepViewModel inspect, string snippetName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!UVgDRcTNmN35h71vmZc())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				Ydjq8WT2OueqOSB2sJ8();
				rjk1QjTQHibKaPKL7P3();
				num = (UVgDRcTNmN35h71vmZc() ? 4 : 0);
				continue;
			case 0:
			case 1:
				base._002Ector(inspect, snippetName);
				break;
			case 5:
				return;
			}
			GoLOyGl3ZY = (string)rLnv3IT1I77jA4exigA(biY1meTcRZ39Uf9MwMs(), snippetName);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__6))]
	public override Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UVgDRcTNmN35h71vmZc();
		int num = ((!rjk1QjTQHibKaPKL7P3()) ? 3 : 4);
		_003CSaveState_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__7))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rjk1QjTQHibKaPKL7P3();
		int num = (UVgDRcTNmN35h71vmZc() ? 4 : 5);
		_003CUndo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = SX9Ax1TuUWhYH9ZTsMO();
				num = 2;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 1;
				if (rjk1QjTQHibKaPKL7P3())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (UVgDRcTNmN35h71vmZc())
				{
				}
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task Hx0OO0Khf6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.SaveState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool bnvOHqbTRh(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)VyiFCZThBLbSGlmlTZ6(P_0) == SnippetName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task ocXOwkvNI6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.Undo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ydjq8WT2OueqOSB2sJ8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object biY1meTcRZ39Uf9MwMs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.xPQhxosZve();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rLnv3IT1I77jA4exigA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rjk1QjTQHibKaPKL7P3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UVgDRcTNmN35h71vmZc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder SX9Ax1TuUWhYH9ZTsMO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VyiFCZThBLbSGlmlTZ6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}
}
