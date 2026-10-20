using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps;

public class RemoveSnippetUndoAction : BaseSnippetAddRemoveAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveSnippetUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			G1n4DvKdso8CDTSy2qgS();
			int num;
			if (!x0SylgKdvdhnrgO5AUXT())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_01e5;
			IL_003d:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01e5;
			IL_01e5:
			int num2 = default;
			EzSnippet item = default;
			RemoveSnippetUndoAction removeSnippetUndoAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 5:
					goto IL_003d;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							item = removeSnippetUndoAction.AppStepVm.Snippets.First(removeSnippetUndoAction.OdKUHxdWps);
							num3 = 0;
							goto IL_0155;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00f6;
						IL_00f6:
						_003C_003Eu__1 = default;
						num3 = 9;
						if (1 == 0)
						{
							goto IL_010e;
						}
						goto IL_0155;
						IL_010e:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						_ = 0;
						if (!G1n4DvKdso8CDTSy2qgS())
						{
							num3 = 1;
						}
						else
						{
							num3 = 7;
							if (x0SylgKdvdhnrgO5AUXT())
							{
							}
						}
						goto IL_0155;
						IL_0155:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 7:
								return;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 0:
								removeSnippetUndoAction._listPosition = removeSnippetUndoAction.AppStepVm.Snippets.IndexOf(item);
								num3 = 4;
								if (G1n4DvKdso8CDTSy2qgS())
								{
									continue;
								}
								goto case 4;
							case 4:
								awaiter = vaFSSjKdPR5JcRtBmLCI(qDgKvSKdr5LDP6shqv5i());
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 10;
							case 1:
							case 6:
								break;
							case 2:
								goto IL_010e;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto IL_010e;
							default:
								num3 = 2;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0052;
							}
							break;
						}
						goto IL_00f6;
						end_IL_0052:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_003d;
				default:
					num = 5;
					continue;
				case 4:
					removeSnippetUndoAction = _003C_003E4__this;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			num = 4;
			if (1 == 0)
			{
				goto IL_003d;
			}
			goto IL_01e5;
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
		internal static object qDgKvSKdr5LDP6shqv5i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vaFSSjKdPR5JcRtBmLCI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G1n4DvKdso8CDTSy2qgS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x0SylgKdvdhnrgO5AUXT()
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
	private struct _003CDo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveSnippetUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private EzSnippet _003Ctool_003E5__5;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

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
			RemoveSnippetUndoAction removeSnippetUndoAction = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			CvsCellCollection result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
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
							awaiter2 = removeSnippetUndoAction.AppStepVm.PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0092;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0092;
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
									_ = 0;
									if (Ib8kW5KdZRBbmYZXxciW())
									{
										num3 = 25;
										if (!Ib8kW5KdZRBbmYZXxciW())
										{
											goto IL_00e4;
										}
									}
									else
									{
										num3 = 10;
										if (false)
										{
											goto IL_02d3;
										}
									}
									goto IL_01c4;
								case 4:
									awaiter3 = _003C_003Eu__3;
									num3 = 28;
									goto IL_01c4;
								case 1:
									awaiter4 = _003C_003Eu__2;
									num3 = 17;
									goto IL_01c4;
								case 3:
									awaiter3 = _003C_003Eu__3;
									num3 = 21;
									goto IL_01c4;
								case 2:
									{
										awaiter3 = _003C_003Eu__3;
										num3 = 1;
										goto IL_01c4;
									}
									IL_00e4:
									awaiter3.GetResult();
									num3 = 6;
									if (!Ib8kW5KdZRBbmYZXxciW())
									{
										goto IL_00fb;
									}
									goto IL_01c4;
									IL_00fb:
									_003Ctool_003E5__5 = removeSnippetUndoAction.AppStepVm.Snippets.First(removeSnippetUndoAction.w4uUwS0Xkt);
									num3 = 15;
									goto IL_01c4;
									IL_01c4:
									while (true)
									{
										switch (num3)
										{
										case 2:
											break;
										case 0:
										case 25:
											goto IL_00fb;
										case 3:
											awaiter3.GetResult();
											num3 = 18;
											if (wVbvGnKdBAJ0G7Mc4WOc())
											{
											}
											continue;
										case 6:
											awaiter3 = OpuGVUKdSNwVOFo7Fhf7(removeSnippetUndoAction.AppStepVm.RemoveSnippet(_003Ctool_003E5__5));
											num3 = 5;
											if (true)
											{
												continue;
											}
											goto case 5;
										case 5:
											if (!awaiter3.IsCompleted)
											{
												num3 = 23;
												continue;
											}
											goto case 10;
										case 7:
											_003C_003Eu__3 = awaiter3;
											num3 = 19;
											continue;
										case 23:
											num2 = (_003C_003E1__state = 4);
											num3 = 7;
											continue;
										case 27:
											num2 = (_003C_003E1__state = 3);
											_003C_003Eu__3 = awaiter3;
											goto case 13;
										default:
											num3 = 13;
											if (true)
											{
												continue;
											}
											goto case 19;
										case 19:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 14:
											return;
										case 13:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num3 = 4;
											continue;
										case 4:
											return;
										case 20:
											num2 = (_003C_003E1__state = -1);
											goto case 10;
										case 21:
											goto IL_02d3;
										case 12:
											goto IL_02eb;
										case 1:
											goto IL_0304;
										case 11:
											num2 = (_003C_003E1__state = -1);
											num3 = 2;
											continue;
										case 16:
											_003C_003Eu__3 = awaiter3;
											num3 = 9;
											continue;
										case 10:
										case 26:
											awaiter3.GetResult();
											num3 = 29;
											continue;
										case 8:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											num3 = 14;
											continue;
										case 22:
											_003C_003Eu__2 = awaiter4;
											num3 = 8;
											continue;
										case 18:
											awaiter3 = OpuGVUKdSNwVOFo7Fhf7(removeSnippetUndoAction.SaveSnippet(BeCBdeKdkLr8B4kdA4oK(_003Ctool_003E5__5)));
											if (!awaiter3.IsCompleted)
											{
												num3 = 27;
												continue;
											}
											break;
										case 24:
											awaiter3 = OpuGVUKdSNwVOFo7Fhf7(DfKXXIKdo1V2dIsL61tU(removeSnippetUndoAction.AppStepVm, new SnippetPreRemoveEventArgs(result2, _003Ctool_003E5__5, removeSnippetUndoAction.ActionsToUndo)));
											if (awaiter3.IsCompleted)
											{
												goto case 3;
											}
											num3 = 12;
											if (true)
											{
												continue;
											}
											goto case 9;
										case 9:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 15:
											awaiter4 = ((CvsCogSocketSheet)jjstIRKdGi2ekSVoxJqJ(((CvsInSight)pxFRNPKdb2DcUyIoNjtX(removeSnippetUndoAction.AppStepVm)).CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
											if (!awaiter4.IsCompleted)
											{
												num2 = (_003C_003E1__state = 1);
												num3 = 22;
												if (true)
												{
													continue;
												}
												goto case 28;
											}
											goto IL_0483;
										case 28:
											_003C_003Eu__3 = default;
											num3 = 20;
											if (0 == 0)
											{
												continue;
											}
											goto case 17;
										case 17:
											_003C_003Eu__2 = default;
											num2 = (_003C_003E1__state = -1);
											goto IL_0483;
										case 29:
											{
												_003Ctool_003E5__5 = null;
												goto end_IL_00b3;
											}
											IL_0483:
											result2 = awaiter4.GetResult();
											num3 = 24;
											continue;
										}
										break;
									}
									goto IL_00e4;
									IL_02d3:
									_003C_003Eu__3 = default;
									num3 = 11;
									if (0 == 0)
									{
										goto IL_01c4;
									}
									goto IL_02eb;
									IL_02eb:
									num2 = (_003C_003E1__state = 2);
									num3 = 16;
									if (Ib8kW5KdZRBbmYZXxciW())
									{
										goto IL_01c4;
									}
									goto IL_0304;
									IL_0304:
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									goto IL_01c4;
									end_IL_00b3:
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
							awaiter = SWm0wvKd8VqmCePW7Xy1(_003C_003E7__wrap1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 5);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_051f;
						case 5:
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_051f;
							}
							IL_051f:
							awaiter.GetResult();
							break;
							IL_0092:
							result = awaiter2.GetResult();
							_003C_003E7__wrap1 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							jq3YC4KdE4iEN8p4Eh0t(BPXAE7KdqD5GvDijh0x8((obj2 as Exception) ?? throw obj2));
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
					break;
				default:
					num = 3;
					continue;
				case 1:
				case 4:
					removeSnippetUndoAction = _003C_003E4__this;
					goto case 2;
				case 0:
					num2 = _003C_003E1__state;
					Ib8kW5KdZRBbmYZXxciW();
					num = ((!wVbvGnKdBAJ0G7Mc4WOc()) ? 4 : 5);
					continue;
				case 3:
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
		internal static object pxFRNPKdb2DcUyIoNjtX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jjstIRKdGi2ekSVoxJqJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DfKXXIKdo1V2dIsL61tU(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetPreRemove((SnippetPreRemoveEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter OpuGVUKdSNwVOFo7Fhf7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange BeCBdeKdkLr8B4kdA4oK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask SWm0wvKd8VqmCePW7Xy1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BPXAE7KdqD5GvDijh0x8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jq3YC4KdE4iEN8p4Eh0t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ib8kW5KdZRBbmYZXxciW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wVbvGnKdBAJ0G7Mc4WOc()
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
	private struct _003CRedo_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveSnippetUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private List<IUndoAction>.Enumerator _003C_003E7__wrap4;

		private TaskAwaiter _003C_003Eu__2;

		private ValueTaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mWTBUBKdXqhvnq8UCkT6();
			int num;
			if (ND0mm2KdpmbB69qTtna1())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_0041;
				}
			}
			goto IL_03ea;
			IL_0041:
			RemoveSnippetUndoAction removeSnippetUndoAction = default;
			int num2 = default;
			try
			{
				TaskAwaiter<IAsyncDisposable> awaiter2;
				ValueTaskAwaiter awaiter;
				IAsyncDisposable result;
				switch (num2)
				{
				default:
					awaiter2 = removeSnippetUndoAction.AppStepVm.PauseResults().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00b3;
				case 0:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_00b3;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter3 = default;
						if (num2 != 1)
						{
							if (num2 == 2)
							{
								awaiter3 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02e8;
							}
							_003C_003E7__wrap4 = removeSnippetUndoAction.ActionsToUndo.GetEnumerator();
						}
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 2;
							}
							else
							{
								awaiter3 = _003C_003Eu__2;
								num3 = 7;
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 8;
									continue;
								case 8:
									awaiter3.GetResult();
									num3 = 10;
									if (ND0mm2KdpmbB69qTtna1())
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Eu__2 = awaiter3;
									goto default;
								default:
									_ = 1;
									if (!mWTBUBKdXqhvnq8UCkT6())
									{
										num3 = 5;
										if (mWTBUBKdXqhvnq8UCkT6())
										{
										}
										continue;
									}
									num3 = 1;
									if (!mWTBUBKdXqhvnq8UCkT6())
									{
										continue;
									}
									break;
								case 9:
									if (awaiter3.IsCompleted)
									{
										goto case 8;
									}
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 0;
								case 0:
									num2 = (_003C_003E1__state = 1);
									num3 = 3;
									continue;
								case 7:
									_003C_003Eu__2 = default;
									goto case 1;
								case 4:
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								case 2:
								case 10:
									break;
								}
								if (_003C_003E7__wrap4.MoveNext())
								{
									awaiter3 = ((Task)jbS2IUKd92HMhhoJ3Qh4(_003C_003E7__wrap4.Current)).GetAwaiter();
									num3 = 9;
									continue;
								}
								break;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap4/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap4 = default;
						EzSnippet snippet = removeSnippetUndoAction.AppStepVm.Snippets.First(removeSnippetUndoAction.wpfUyuJJlC);
						awaiter3 = rqlZGVKd4ivqFfGUXgxM(removeSnippetUndoAction.AppStepVm.RemoveSnippet(snippet));
						if (!awaiter3.IsCompleted)
						{
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__2 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_02e8;
						IL_02e8:
						awaiter3.GetResult();
					}
					catch (object obj)
					{
						_003C_003E7__wrap2 = obj;
					}
					if (_003C_003E7__wrap1 == null)
					{
						break;
					}
					awaiter = iYQg4JKd7e9e1j7GDAfO(_003C_003E7__wrap1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 3);
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0371;
				case 3:
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0371;
					}
					IL_0371:
					awaiter.GetResult();
					break;
					IL_00b3:
					result = awaiter2.GetResult();
					_003C_003E7__wrap1 = result;
					_003C_003E7__wrap2 = null;
					_003C_003E7__wrap3 = 0;
					goto case 1;
				}
				object obj2 = _003C_003E7__wrap2;
				if (obj2 != null)
				{
					jTlCq5Kd3ogsy5vKk2hU(ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw obj2));
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
			goto IL_0415;
			IL_0415:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_03ea;
			IL_03ea:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_0415;
				case 1:
				case 4:
					removeSnippetUndoAction = _003C_003E4__this;
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
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
		internal static object jbS2IUKd92HMhhoJ3Qh4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rqlZGVKd4ivqFfGUXgxM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask iYQg4JKd7e9e1j7GDAfO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jTlCq5Kd3ogsy5vKk2hU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ND0mm2KdpmbB69qTtna1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mWTBUBKdXqhvnq8UCkT6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public EzTool tool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass14_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tqXO1eKdCa6N4ReirTrh();
			FmWe9nKdAv7VSt7bYM3F(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUndo_003Eb__1(EzSnippet s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (s is GroupTool groupTool)
			{
				return groupTool.Children.Contains(tool);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tqXO1eKdCa6N4ReirTrh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FmWe9nKdAv7VSt7bYM3F(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YQm4LOKdj2lZCiIHjj2j()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xOGWeeKd6cR6lwhwEl8F()
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
	private struct _003CUndo_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveSnippetUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		private IEnumerator<IUndoAction> _003C_003E7__wrap4;

		private ValueTaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CsNeTGKdWibFxRYajRxQ();
			int num = ((!RnN8WuKdRQCXbXWIxJpK()) ? 3 : 2);
			RemoveSnippetUndoAction removeSnippetUndoAction = default;
			TaskAwaiter awaiter3 = default;
			int num2 = default;
			do
			{
				IL_0469:
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_0469;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 4:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = removeSnippetUndoAction.AppStepVm.PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00c6;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00c6;
						case 1:
						case 2:
							try
							{
								if (num2 != 1)
								{
									if (num2 == 2)
									{
										goto IL_0177;
									}
									awaiter3 = ANE9PSKdTW56EBZa3iGd(removeSnippetUndoAction.PasteAndParseSnippet(addDefaultRefs: false));
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
								}
								else
								{
									awaiter3 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
								}
								awaiter3.GetResult();
								W1GkZIKdyUqH7wxfLQvi(removeSnippetUndoAction.AppStepVm, null);
								_003C_003E7__wrap4 = Enumerable.Reverse(removeSnippetUndoAction.ActionsToUndo).GetEnumerator();
								goto IL_0177;
								IL_0177:
								try
								{
									int num3;
									if (num2 != 2)
									{
										num3 = 4;
									}
									else
									{
										awaiter3 = _003C_003Eu__2;
										num3 = 7;
										if (1 == 0)
										{
											goto IL_0214;
										}
									}
									goto IL_01c0;
									IL_0233:
									awaiter3.GetResult();
									num3 = 10;
									goto IL_01c0;
									IL_0214:
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 9;
										goto IL_01c0;
									}
									goto IL_0233;
									IL_01c0:
									while (true)
									{
										switch (num3)
										{
										case 9:
											_003C_003Eu__2 = awaiter3;
											goto case 3;
										case 3:
										case 6:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										default:
											num3 = 0;
											continue;
										case 0:
											return;
										case 1:
										case 2:
											break;
										case 5:
											goto IL_0233;
										case 8:
											num2 = (_003C_003E1__state = -1);
											num3 = 5;
											if (RnN8WuKdRQCXbXWIxJpK())
											{
												continue;
											}
											goto case 7;
										case 7:
											_003C_003Eu__2 = default;
											num3 = 8;
											continue;
										case 4:
										case 10:
											goto IL_02a5;
										}
										break;
										IL_02a5:
										if (a0UnMGKdFYuvHCe3re0H(_003C_003E7__wrap4))
										{
											awaiter3 = ANE9PSKdTW56EBZa3iGd(ybTK9EKd0ORR0ed2tewe(_003C_003E7__wrap4.Current));
											_ = 0;
											num3 = (RnN8WuKdRQCXbXWIxJpK() ? 2 : 6);
											continue;
										}
										goto end_IL_0177;
									}
									goto IL_0214;
									end_IL_0177:;
								}
								finally
								{
									if (num2 < 0 && _003C_003E7__wrap4 != null)
									{
										_003C_003E7__wrap4.Dispose();
									}
								}
								_003C_003E7__wrap4 = null;
								EzSnippet ezSnippet = removeSnippetUndoAction.AppStepVm.Snippets.First(removeSnippetUndoAction.wEHUxj8tFM);
								if (ezSnippet is GroupTool groupTool)
								{
									groupTool.nnG4uPQKIR();
								}
								else
								{
									_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass14_0();
									CS_0024_003C_003E8__locals3.tool = ezSnippet as EzTool;
									if (CS_0024_003C_003E8__locals3.tool != null && removeSnippetUndoAction.AppStepVm.Snippets.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet s) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return s is GroupTool groupTool3 && groupTool3.Children.Contains(CS_0024_003C_003E8__locals3.tool);
									}) is GroupTool groupTool2)
									{
										groupTool2.nnG4uPQKIR();
									}
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
							awaiter = WQowCYKdM5E6fJQRaK1p(_003C_003E7__wrap1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_03f0;
						case 3:
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03f0;
							}
							IL_03f0:
							awaiter.GetResult();
							break;
							IL_00c6:
							result = awaiter2.GetResult();
							_003C_003E7__wrap1 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							bcoT4AKdUgr1gQTHFNUt(VKOcI7KdYVnjpeoFbLP8((obj2 as Exception) ?? throw obj2));
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
					goto case 5;
				default:
					num = 5;
					if (true)
					{
						goto IL_0469;
					}
					break;
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				removeSnippetUndoAction = _003C_003E4__this;
				num = 4;
			}
			while (true);
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
		internal static TaskAwaiter ANE9PSKdTW56EBZa3iGd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void W1GkZIKdyUqH7wxfLQvi(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).RefreshPotentialDependencies((EzSnippet)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ybTK9EKd0ORR0ed2tewe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a0UnMGKdFYuvHCe3re0H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask WQowCYKdM5E6fJQRaK1p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VKOcI7KdYVnjpeoFbLP8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bcoT4AKdUgr1gQTHFNUt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RnN8WuKdRQCXbXWIxJpK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CsNeTGKdWibFxRYajRxQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected int _listPosition;

	[CompilerGenerated]
	private List<IUndoAction> Lh5UvcyW81;

	[CompilerGenerated]
	private readonly string etaUeNsdFO;

	protected List<IUndoAction> ActionsToUndo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Lh5UvcyW81;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Lh5UvcyW81 = value;
		}
	}

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
			return etaUeNsdFO;
		}
	}

	protected AppStepViewModel AppStepVm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (AppStepViewModel)Step;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoveSnippetUndoAction(AppStepViewModel appStepVm, string snippetName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		do
		{
			IL_003b:
			switch (num)
			{
			case 2:
			case 5:
				etaUeNsdFO = string.Format((string)LPVdGbej4XLTL00Cbv3(), snippetName);
				break;
			default:
				num = 3;
				goto IL_003b;
			case 0:
				p0Ei13e3GLJgvt462ck();
				_ = 1;
				if (!TSLy86e7oeM3FMlHv7j())
				{
					num = 4;
					if (!TSLy86e7oeM3FMlHv7j())
					{
						goto IL_003b;
					}
					goto case 1;
				}
				num = 5;
				goto IL_003b;
			case 1:
			case 4:
				base._002Ector(appStepVm, snippetName);
				goto case 2;
			case 3:
				break;
			case 6:
				return;
			}
			ActionsToUndo = new List<IUndoAction>();
			num = 6;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__11))]
	public override Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CSaveState_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = (Ts3A26e4uJYlRXslUgF() ? 2 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__12))]
	public override Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDo_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = KHY1Zge6RPOesFYNqFl();
				num = 5;
				if (!TSLy86e7oeM3FMlHv7j())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				Ts3A26e4uJYlRXslUgF();
				num = ((!TSLy86e7oeM3FMlHv7j()) ? 1 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__13))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CRedo_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder = KHY1Zge6RPOesFYNqFl();
				TSLy86e7oeM3FMlHv7j();
				if (Ts3A26e4uJYlRXslUgF())
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto case 5;
				}
				num = 0;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__14))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TSLy86e7oeM3FMlHv7j();
		int num = ((!Ts3A26e4uJYlRXslUgF()) ? 3 : 2);
		_003CUndo_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = KHY1Zge6RPOesFYNqFl();
				goto case 1;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool OdKUHxdWps(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return YuLjxceAaHUE29pevwn(I8sH75eCOg7b5GHPoCA(P_0), SnippetName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool w4uUwS0Xkt(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return YuLjxceAaHUE29pevwn(P_0.Name, SnippetName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool wpfUyuJJlC(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return YuLjxceAaHUE29pevwn(I8sH75eCOg7b5GHPoCA(P_0), SnippetName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool wEHUxj8tFM(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return YuLjxceAaHUE29pevwn(P_0.Name, SnippetName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p0Ei13e3GLJgvt462ck()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LPVdGbej4XLTL00Cbv3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.fx2hwSDtjx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ts3A26e4uJYlRXslUgF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TSLy86e7oeM3FMlHv7j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder KHY1Zge6RPOesFYNqFl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I8sH75eCOg7b5GHPoCA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YuLjxceAaHUE29pevwn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
