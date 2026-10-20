#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Extensions;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoRedoQueue : MarshalByRefObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFireAndForgetAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Task task;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!Ue4gyvsoIeVv3pAxMaSs())
			{
				goto IL_001e;
			}
			goto IL_0197;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 0;
			num = (Ue4gyvsoIeVv3pAxMaSs() ? 3 : 0);
			goto IL_0197;
			IL_0197:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 3:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = TaetgusoaAbrWCicpESI(task);
								num3 = 1;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 0;
								if (1 == 0)
								{
									goto IL_0127;
								}
							}
							goto IL_008d;
							IL_0127:
							_003C_003Eu__1 = awaiter;
							FixBSnsoR1kKKcG7ARRw();
							num3 = (Ue4gyvsoIeVv3pAxMaSs() ? 2 : 5);
							goto IL_008d;
							IL_008d:
							while (true)
							{
								switch (num3)
								{
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									continue;
								case 2:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 7;
									continue;
								case 0:
									_003C_003Eu__1 = default;
									goto case 5;
								case 5:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (!FixBSnsoR1kKKcG7ARRw())
									{
										continue;
									}
									goto case 1;
								case 1:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 9;
								case 7:
									return;
								case 4:
									break;
								case 9:
									awaiter.GetResult();
									goto end_IL_008d;
								}
								goto IL_0127;
								continue;
								end_IL_008d:
								break;
							}
						}
						catch (Exception ex)
						{
							t8spDZson97YRAlbkQyX(ex);
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_01c4;
				default:
					goto IL_01c4;
				case 5:
					return;
				}
				break;
				IL_01c4:
				_003C_003Et__builder.SetResult();
				num = 5;
			}
			goto IL_001e;
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
		internal static TaskAwaiter TaetgusoaAbrWCicpESI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void t8spDZson97YRAlbkQyX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Console.WriteLine(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ue4gyvsoIeVv3pAxMaSs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FixBSnsoR1kKKcG7ARRw()
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
	private struct _003CResetAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRedoQueue _003C_003E4__this;

		public bool fireEvents;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			UndoRedoQueue undoRedoQueue = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							Ng22fWsobcWr2iRtmg4h(undoRedoQueue.EsGq3PjbDS);
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (!UBZE4isoGhZq0ayQp42Q())
							{
								goto IL_017f;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								Ng22fWsobcWr2iRtmg4h(undoRedoQueue.zAaqWuF255);
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 10;
								continue;
							case 2:
								if (fireEvents)
								{
									tEItjoso6da4fGhSVB5U(undoRedoQueue, UndoEventType.Reset);
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 6;
								}
								goto end_IL_00c7;
							case 6:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 1:
								num2 = (_003C_003E1__state = 0);
								goto default;
							default:
								qT1dgTsoXoqXsKGuFq4I();
								num3 = ((!UBZE4isoGhZq0ayQp42Q()) ? 9 : 4);
								continue;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							case 11:
								awaiter = ((Task)Kdieo6sopQrcf3EWHw0p(undoRedoQueue, UndoEventType.Reset)).GetAwaiter();
								num3 = 7;
								if (!qT1dgTsoXoqXsKGuFq4I())
								{
									continue;
								}
								return;
							case 8:
								return;
							case 12:
								break;
							}
							goto IL_017f;
							continue;
							end_IL_00c7:
							break;
						}
						goto end_IL_0018;
						IL_017f:
						awaiter.GetResult();
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
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					if (UBZE4isoGhZq0ayQp42Q())
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
					undoRedoQueue = _003C_003E4__this;
					UBZE4isoGhZq0ayQp42Q();
					if (qT1dgTsoXoqXsKGuFq4I())
					{
						num = 4;
						if (UBZE4isoGhZq0ayQp42Q())
						{
							break;
						}
						goto case 5;
					}
					num = 0;
					if (1 == 0)
					{
						return;
					}
					break;
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
		internal static void Ng22fWsobcWr2iRtmg4h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((LinkedList<IUndoAction>)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tEItjoso6da4fGhSVB5U(object P_0, UndoEventType eventType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((UndoRedoQueue)P_0).OnUndoChanged(eventType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Kdieo6sopQrcf3EWHw0p(object P_0, UndoEventType eventType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).OnUndoChangedAsync(eventType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UBZE4isoGhZq0ayQp42Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qT1dgTsoXoqXsKGuFq4I()
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
	private struct _003CAddUndo_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRedoQueue _003C_003E4__this;

		public IUndoAction action;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			UndoRedoQueue undoRedoQueue = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					undoRedoQueue = _003C_003E4__this;
					_ = 0;
					if (Jtqpeaso0ii5HIZpmp3H())
					{
						num = 1;
						break;
					}
					num = 0;
					if (FWyyFjso4TU884SwsywB())
					{
					}
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00e3;
						}
						if ((uint)(num2 - 1) <= 2u)
						{
							goto IL_00f0;
						}
						if (!undoRedoQueue.IsEditingQueue)
						{
							undoRedoQueue.IsEditingQueue = true;
							if (!undoRedoQueue.CanUndo())
							{
								awaiter = qCif6hsofjZyvKijufhM(gMuxnasok7XFiXTEWNKP(action));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00e3;
							}
							goto IL_00f0;
						}
						goto end_IL_005b;
						IL_00e3:
						awaiter.GetResult();
						goto end_IL_005b;
						IL_00f0:
						try
						{
							IUndoAction undoAction;
							switch (num2)
							{
							default:
								undoRedoQueue.EsGq3PjbDS.Clear();
								awaiter = qCif6hsofjZyvKijufhM(nxHylGsoFMCRaya9VymX(action));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_016b;
							case 1:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_016b;
							case 2:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_01ce;
							case 3:
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_01ce:
								awaiter.GetResult();
								undoAction = undoRedoQueue.zAaqWuF255.First?.Value;
								if (undoAction != null && action is IMergeableUndoAction mergeableUndoAction && SFtnfosomLw4R0MBiDeo(mergeableUndoAction, undoAction))
								{
									W17xr7soyLSaWhvUmJOu(mergeableUndoAction, undoAction);
								}
								else
								{
									undoRedoQueue.zAaqWuF255.AddFirst(action);
									while (lh4IA7soJPu1nwBZoHkl(undoRedoQueue.zAaqWuF255) > undoRedoQueue.c5gqLciIjx)
									{
										IDisposable obj = undoRedoQueue.zAaqWuF255.Last.Value as IDisposable;
										if (obj != null)
										{
											nAv9fRsogrfMrlh4gHkS(obj);
										}
										LkbKUvsoZcA8iPdJsayI(undoRedoQueue.zAaqWuF255);
									}
								}
								if (OPusIxso8ht14Y49vg8b(undoRedoQueue.LgHqtlkRrR))
								{
									vtYC6UsPLpo4CgHuiFd1(mreFsOsPhLCHlwGJuyFV(OEk78TsozO0QSVVBor2Z(55410), kQTKuhsPwu6nHR96KA81(action.GetType()), OEk78TsozO0QSVVBor2Z(55430), QIO76NsPscITFjF91HxZ(action)));
								}
								l2sSmJsP9HIa9XWdFc7a(undoRedoQueue, UndoEventType.Add);
								awaiter = qCif6hsofjZyvKijufhM(undoRedoQueue.OnUndoChangedAsync(UndoEventType.Add));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
								IL_016b:
								awaiter.GetResult();
								awaiter = qCif6hsofjZyvKijufhM(gMuxnasok7XFiXTEWNKP(action));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_01ce;
							}
							awaiter.GetResult();
						}
						catch (UndoActionCanceledException)
						{
						}
						catch (CvsNetworkException)
						{
							throw;
						}
						catch (ArgumentOutOfRangeException)
						{
							throw;
						}
						catch (Exception ex4)
						{
							CvsNetworkException ex5 = ex4.GetAs<CvsNetworkException>();
							if (ex5 != null)
							{
								SagjGMsPEnp8cAISdi37(SEJHQ4sPSErq5bYAFH62(ex5));
							}
							throw new CvsNetworkException(ex4);
						}
						finally
						{
							if (num2 < 0)
							{
								undoRedoQueue.IsEditingQueue = false;
							}
						}
						end_IL_005b:;
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
		internal static object gMuxnasok7XFiXTEWNKP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter qCif6hsofjZyvKijufhM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nxHylGsoFMCRaya9VymX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SFtnfosomLw4R0MBiDeo(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IMergeableUndoAction)P_0).CanMerge((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void W17xr7soyLSaWhvUmJOu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IMergeableUndoAction)P_0).MergeInto((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nAv9fRsogrfMrlh4gHkS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LkbKUvsoZcA8iPdJsayI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((LinkedList<IUndoAction>)P_0).RemoveLast();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int lh4IA7soJPu1nwBZoHkl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((LinkedList<IUndoAction>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OPusIxso8ht14Y49vg8b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TraceSwitch)P_0).TraceInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OEk78TsozO0QSVVBor2Z(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kQTKuhsPwu6nHR96KA81(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemberInfo)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QIO76NsPscITFjF91HxZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mreFsOsPhLCHlwGJuyFV(object P_0, object P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vtYC6UsPLpo4CgHuiFd1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Trace.WriteLine((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void l2sSmJsP9HIa9XWdFc7a(object P_0, UndoEventType eventType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((UndoRedoQueue)P_0).OnUndoChanged(eventType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SEJHQ4sPSErq5bYAFH62(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SagjGMsPEnp8cAISdi37(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Jtqpeaso0ii5HIZpmp3H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FWyyFjso4TU884SwsywB()
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
	private struct _003COnUndoChangedAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRedoQueue _003C_003E4__this;

		public UndoEventType eventType;

		private Delegate[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			UndoRedoQueue undoRedoQueue = default;
			int num2 = default;
			Func<object, UndoEventType, Task> func = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					undoRedoQueue = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (m0lgEOsPHhiYvgCZZyV6())
					{
					}
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!m0lgEOsPHhiYvgCZZyV6())
					{
						num = 2;
						break;
					}
					num = 0;
					if (m0lgEOsPHhiYvgCZZyV6())
					{
					}
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							func = undoRedoQueue.y0mqXalXAD;
							num3 = 11;
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
							case 10:
								awaiter.GetResult();
								num3 = 0;
								if (YY3eposPv1ECAxx9NM3W())
								{
									continue;
								}
								goto case 2;
							case 11:
								if (func != null)
								{
									_003C_003E7__wrap1 = (Delegate[])EreqkpsPVqktHWipvapM(func);
									num3 = 1;
									if (YY3eposPv1ECAxx9NM3W())
									{
										continue;
									}
									goto case 0;
								}
								break;
							case 0:
								_003C_003E7__wrap2++;
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								if (YY3eposPv1ECAxx9NM3W())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 8:
								if (awaiter.IsCompleted)
								{
									goto case 10;
								}
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 6:
							case 13:
								if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
								{
									awaiter = ((Func<object, UndoEventType, Task>)_003C_003E7__wrap1[_003C_003E7__wrap2])(undoRedoQueue, eventType).GetAwaiter();
									goto case 3;
								}
								num3 = 14;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 12;
								continue;
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003E7__wrap2 = 0;
								_ = 1;
								num3 = ((!m0lgEOsPHhiYvgCZZyV6()) ? 13 : 8);
								continue;
							case 9:
								return;
							case 4:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 9;
								continue;
							case 14:
								_003C_003E7__wrap1 = null;
								break;
							}
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
		internal static object EreqkpsPVqktHWipvapM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Delegate)P_0).GetInvocationList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YY3eposPv1ECAxx9NM3W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m0lgEOsPHhiYvgCZZyV6()
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
	private struct _003CUndo_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRedoQueue _003C_003E4__this;

		private IUndoAction _003Caction_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_032d;
			IL_001a:
			UndoRedoQueue undoRedoQueue = _003C_003E4__this;
			fhdqXRsPAuCfcDpZQkHW();
			num = ((!LYgMRZsPDu0AFGE9QNcd()) ? 5 : 0);
			goto IL_032d;
			IL_032d:
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						if ((uint)num2 <= 1u || (undoRedoQueue.UndoEnabled && !undoRedoQueue.IsEditingQueue))
						{
							try
							{
								int num3;
								if (num2 != 0)
								{
									if (num2 != 1)
									{
										num3 = 7;
									}
									else
									{
										awaiter = _003C_003Eu__1;
										_003C_003Eu__1 = default;
										num3 = 10;
									}
								}
								else
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 16;
								}
								while (true)
								{
									switch (num3)
									{
									case 8:
										return;
									case 14:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 8;
										if (0 == 0)
										{
											continue;
										}
										goto case 11;
									case 11:
										hveSuxsPdcdpufJvrTvx(undoRedoQueue.zAaqWuF255);
										num3 = 17;
										if (0 == 0)
										{
											continue;
										}
										goto case 0;
									case 0:
										awaiter = oMcMf4sPTaSqRU8DI6CT(f1tbBJsPU5jODOf8YPcM(_003Caction_003E5__2));
										num3 = 3;
										if (fhdqXRsPAuCfcDpZQkHW())
										{
											continue;
										}
										goto case 16;
									case 16:
										awaiter.GetResult();
										num3 = 11;
										if (LYgMRZsPDu0AFGE9QNcd())
										{
										}
										continue;
									case 13:
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										LYgMRZsPDu0AFGE9QNcd();
										num3 = ((!fhdqXRsPAuCfcDpZQkHW()) ? 2 : 4);
										continue;
									case 7:
										undoRedoQueue.IsEditingQueue = true;
										num3 = 1;
										continue;
									case 17:
										undoRedoQueue.EsGq3PjbDS.AddFirst(_003Caction_003E5__2);
										goto default;
									case 19:
										if (!awaiter.IsCompleted)
										{
											num3 = 18;
											continue;
										}
										goto case 6;
									case 12:
										_003C_003Eu__1 = awaiter;
										num3 = 14;
										if (LYgMRZsPDu0AFGE9QNcd())
										{
										}
										continue;
									case 3:
										if (awaiter.IsCompleted)
										{
											goto case 16;
										}
										num2 = (_003C_003E1__state = 0);
										num3 = 13;
										if (true)
										{
											continue;
										}
										goto case 1;
									case 1:
										_003Caction_003E5__2 = undoRedoQueue.UndoAction;
										num3 = 0;
										continue;
									case 18:
										num2 = (_003C_003E1__state = 1);
										num3 = 12;
										continue;
									case 4:
									case 5:
										return;
									case 15:
										awaiter = oMcMf4sPTaSqRU8DI6CT(RcAriSsPismTPfd79u8Z(undoRedoQueue, UndoEventType.Undo));
										num3 = 19;
										continue;
									case 10:
										num2 = (_003C_003E1__state = -1);
										num3 = 6;
										if (0 == 0)
										{
											continue;
										}
										goto default;
									default:
										undoRedoQueue.OnUndoChanged(UndoEventType.Undo);
										num3 = 15;
										if (true)
										{
											continue;
										}
										goto case 6;
									case 6:
										awaiter.GetResult();
										num3 = 20;
										if (true)
										{
											continue;
										}
										break;
									case 20:
										break;
									}
									break;
								}
								_003Caction_003E5__2 = null;
							}
							finally
							{
								if (num2 < 0)
								{
									undoRedoQueue.IsEditingQueue = false;
								}
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
					goto default;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					return;
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
		internal static object f1tbBJsPU5jODOf8YPcM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter oMcMf4sPTaSqRU8DI6CT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hveSuxsPdcdpufJvrTvx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((LinkedList<IUndoAction>)P_0).RemoveFirst();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RcAriSsPismTPfd79u8Z(object P_0, UndoEventType eventType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).OnUndoChangedAsync(eventType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fhdqXRsPAuCfcDpZQkHW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LYgMRZsPDu0AFGE9QNcd()
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
	private struct _003CRedo_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRedoQueue _003C_003E4__this;

		private IUndoAction _003Caction_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoRedoQueue undoRedoQueue = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					undoRedoQueue = _003C_003E4__this;
					goto case 2;
				case 0:
					do
					{
						num2 = _003C_003E1__state;
						OBlmt2sPBnLkNpuaoFeE();
						if (!TlVicysPqifCXCqO1mnj())
						{
							num = 5;
							continue;
						}
						num = 4;
						break;
					}
					while (false);
					continue;
				case 2:
				case 5:
					try
					{
						if ((uint)num2 <= 1u || (undoRedoQueue.RedoEnabled && !undoRedoQueue.IsEditingQueue))
						{
							try
							{
								int num3;
								if (num2 != 0)
								{
									if (num2 == 1)
									{
										awaiter = _003C_003Eu__1;
										goto IL_00b8;
									}
									num3 = 3;
								}
								else
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num3 = 5;
								}
								goto IL_014e;
								IL_014e:
								while (true)
								{
									switch (num3)
									{
									case 1:
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 7:
									case 16:
										break;
									case 5:
										num2 = (_003C_003E1__state = -1);
										num3 = 19;
										continue;
									case 13:
										d5SsiasP2GmYHvbeWceX(undoRedoQueue, UndoEventType.Redo);
										num3 = 12;
										continue;
									case 0:
										awaiter = EWF1WjsPjgPItoIPDdWo(_003Caction_003E5__2.Redo());
										num3 = 18;
										continue;
									case 11:
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 2;
										continue;
									case 19:
										awaiter.GetResult();
										goto case 15;
									default:
										num3 = 15;
										if (0 == 0)
										{
											continue;
										}
										goto case 6;
									case 6:
										_003Caction_003E5__2 = undoRedoQueue.RedoAction;
										num3 = 0;
										continue;
									case 8:
										awaiter.GetResult();
										num3 = 20;
										continue;
									case 4:
									case 14:
										num2 = (_003C_003E1__state = 0);
										num3 = 11;
										continue;
									case 2:
										return;
									case 3:
										undoRedoQueue.IsEditingQueue = true;
										num3 = 6;
										continue;
									case 10:
										num2 = (_003C_003E1__state = 1);
										num3 = 1;
										if (TlVicysPqifCXCqO1mnj())
										{
											continue;
										}
										goto case 17;
									case 17:
										undoRedoQueue.zAaqWuF255.AddFirst(_003Caction_003E5__2);
										num3 = 13;
										continue;
									case 18:
										if (!awaiter.IsCompleted)
										{
											_ = 0;
											num3 = (TlVicysPqifCXCqO1mnj() ? 14 : 7);
											continue;
										}
										goto case 19;
									case 12:
										awaiter = ((Task)CIf8tvsPWuJdf6S3U1gK(undoRedoQueue, UndoEventType.Redo)).GetAwaiter();
										num3 = 9;
										continue;
									case 9:
										if (!awaiter.IsCompleted)
										{
											num3 = 10;
											continue;
										}
										goto case 8;
									case 15:
										Xbb3nvsPcgKlQgSCXnOs(undoRedoQueue.EsGq3PjbDS);
										num3 = 17;
										continue;
									case 20:
										_003Caction_003E5__2 = null;
										goto end_IL_014e;
									}
									goto IL_00b8;
									continue;
									end_IL_014e:
									break;
								}
								goto end_IL_0070;
								IL_00b8:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								goto IL_014e;
								end_IL_0070:;
							}
							finally
							{
								if (num2 < 0)
								{
									undoRedoQueue.IsEditingQueue = false;
								}
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
					break;
				default:
					num = 3;
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
		internal static TaskAwaiter EWF1WjsPjgPItoIPDdWo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Xbb3nvsPcgKlQgSCXnOs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((LinkedList<IUndoAction>)P_0).RemoveFirst();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void d5SsiasP2GmYHvbeWceX(object P_0, UndoEventType eventType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((UndoRedoQueue)P_0).OnUndoChanged(eventType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CIf8tvsPWuJdf6S3U1gK(object P_0, UndoEventType eventType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).OnUndoChangedAsync(eventType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TlVicysPqifCXCqO1mnj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OBlmt2sPBnLkNpuaoFeE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private bool Y5YqAs8ZCq;

	private readonly TraceSwitch LgHqtlkRrR;

	private readonly LinkedList<IUndoAction> zAaqWuF255;

	private readonly LinkedList<IUndoAction> EsGq3PjbDS;

	private readonly int c5gqLciIjx;

	[CompilerGenerated]
	private EventHandler<UndoEventType> PTEqkDtnRw;

	[CompilerGenerated]
	private Func<object, UndoEventType, Task> y0mqXalXAD;

	public bool IsEditingQueue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Y5YqAs8ZCq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Y5YqAs8ZCq = value;
		}
	}

	public IEnumerable<IUndoAction> UndoActions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zAaqWuF255;
		}
	}

	public IEnumerable<IUndoAction> RedoActions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EsGq3PjbDS;
		}
	}

	public bool UndoEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zAaqWuF255.Count > 0;
		}
	}

	public IUndoAction UndoAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zAaqWuF255.First?.Value;
		}
	}

	public string UndoText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IUndoAction undoAction = UndoAction;
			if (undoAction != null)
			{
				return string.Format((string)NdH4l0CphZ0UpkyFLcG(), undoAction.Text);
			}
			return string.Format(Resources.UndoHandlerUndoText, "");
		}
	}

	public bool RedoEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Dsa8hqC0bSZsEtw7Bh5(EsGq3PjbDS) > 0;
		}
	}

	public IUndoAction RedoAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EsGq3PjbDS.First?.Value;
		}
	}

	public string RedoText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IUndoAction redoAction = RedoAction;
			if (redoAction != null)
			{
				return (string)fLYu17CkhlGCsOqlJWk(L7SCgDC4P2PYbGX7pdu(), redoAction.Text);
			}
			return (string)fLYu17CkhlGCsOqlJWk(L7SCgDC4P2PYbGX7pdu(), "");
		}
	}

	public event EventHandler<UndoEventType> UndoChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<UndoEventType> eventHandler = PTEqkDtnRw;
			EventHandler<UndoEventType> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<UndoEventType> value2 = (EventHandler<UndoEventType>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PTEqkDtnRw, value2, eventHandler2);
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
			EventHandler<UndoEventType> eventHandler = PTEqkDtnRw;
			EventHandler<UndoEventType> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<UndoEventType> value2 = (EventHandler<UndoEventType>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PTEqkDtnRw, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event Func<object, UndoEventType, Task> UndoChangedAsync
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, UndoEventType, Task> func = y0mqXalXAD;
			Func<object, UndoEventType, Task> func2;
			do
			{
				func2 = func;
				Func<object, UndoEventType, Task> value2 = (Func<object, UndoEventType, Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref y0mqXalXAD, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, UndoEventType, Task> func = y0mqXalXAD;
			Func<object, UndoEventType, Task> func2;
			do
			{
				func2 = func;
				Func<object, UndoEventType, Task> value2 = (Func<object, UndoEventType, Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref y0mqXalXAD, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoRedoQueue(int maxUndoStackSizeSize = 20)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00b2;
		IL_00b2:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 7:
				goto IL_003c;
			default:
				zAaqWuF255 = new LinkedList<IUndoAction>();
				num = 7;
				continue;
			case 2:
				LgHqtlkRrR = new TraceSwitch((string)BHFeFACarfgIcUDFim6(17238), (string)BHFeFACarfgIcUDFim6(17238));
				num = 1;
				if (FYWO1ICIllIxcoGE2H1())
				{
				}
				continue;
			case 0:
			case 3:
				c5gqLciIjx = maxUndoStackSizeSize;
				goto default;
			case 6:
				goto IL_00ed;
			case 8:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_00ed:
		mtYItSCRE2U9AXEAxLh();
		num = 2;
		goto IL_00b2;
		IL_003c:
		EsGq3PjbDS = new LinkedList<IUndoAction>();
		num = 8;
		goto IL_00b2;
		IL_001a:
		base._002Ector();
		AfN3aaCuEW2a8gfhmcg();
		if (!FYWO1ICIllIxcoGE2H1())
		{
			num = 0;
			if (false)
			{
				goto IL_003c;
			}
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_00ed;
			}
		}
		goto IL_00b2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CanUndo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFireAndForgetAsync_003Ed__14))]
	private void SdtqMe9Tag(Task P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0064;
		IL_001a:
		_003CFireAndForgetAsync_003Ed__14 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0064;
		IL_0064:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 4:
				stateMachine.task = P_0;
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 3;
				continue;
			case 0:
				stateMachine._003C_003Et__builder = JIIegVCnC8XdLPNtymd();
				AfN3aaCuEW2a8gfhmcg();
				num = ((!FYWO1ICIllIxcoGE2H1()) ? 4 : 5);
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset(bool fireEvents = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (FYWO1ICIllIxcoGE2H1() ? 6 : 3);
		while (true)
		{
			switch (num)
			{
			case 4:
				x1Ne7cCXRBK3b2yVTH4(this, UndoEventType.Reset);
				num = 2;
				continue;
			case 2:
				SdtqMe9Tag((Task)LY6fNNCbFJrIEZvveV9(this, UndoEventType.Reset));
				num = 7;
				continue;
			case 0:
			case 3:
				TFQ3Y1CG1Npak2S4aU7(EsGq3PjbDS);
				goto case 1;
			case 1:
			case 6:
				TFQ3Y1CG1Npak2S4aU7(zAaqWuF255);
				num = 5;
				continue;
			case 5:
				if (fireEvents)
				{
					goto case 4;
				}
				return;
			case 7:
				return;
			}
			num = 4;
			if (!AfN3aaCuEW2a8gfhmcg())
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CResetAsync_003Ed__16))]
	public Task ResetAsync(bool fireEvents = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CResetAsync_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 3:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
				stateMachine.fireEvents = fireEvents;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 2:
				do
				{
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					AfN3aaCuEW2a8gfhmcg();
					if (FYWO1ICIllIxcoGE2H1())
					{
						num = 3;
						continue;
					}
					num = 6;
					break;
				}
				while (FYWO1ICIllIxcoGE2H1());
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddUndo_003Ed__17))]
	public Task AddUndo(IUndoAction action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CAddUndo_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 6:
				stateMachine.action = action;
				goto case 3;
			default:
				num = 3;
				continue;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = nabf4fC66b4F6bewjOe();
				AfN3aaCuEW2a8gfhmcg();
				if (FYWO1ICIllIxcoGE2H1())
				{
					num = 6;
					continue;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnUndoChanged(UndoEventType eventType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PTEqkDtnRw?.Invoke(this, eventType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnUndoChangedAsync_003Ed__37))]
	protected virtual Task OnUndoChangedAsync(UndoEventType eventType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!AfN3aaCuEW2a8gfhmcg())
		{
			goto IL_001e;
		}
		goto IL_00a0;
		IL_001e:
		_003COnUndoChangedAsync_003Ed__37 stateMachine = default;
		stateMachine._003C_003Et__builder = nabf4fC66b4F6bewjOe();
		_ = 0;
		num = ((!AfN3aaCuEW2a8gfhmcg()) ? 6 : 0);
		goto IL_00a0;
		IL_00a0:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (FYWO1ICIllIxcoGE2H1())
				{
				}
				continue;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 4:
				stateMachine.eventType = eventType;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__38))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FYWO1ICIllIxcoGE2H1();
		int num = ((!AfN3aaCuEW2a8gfhmcg()) ? 2 : 3);
		_003CUndo_003Ed__38 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = nabf4fC66b4F6bewjOe();
				goto case 1;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__39))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0072;
		IL_001a:
		_003CRedo_003Ed__39 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		AfN3aaCuEW2a8gfhmcg();
		if (!FYWO1ICIllIxcoGE2H1())
		{
			num = 0;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_00a5;
			}
		}
		goto IL_0072;
		IL_00a5:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0072;
		IL_0072:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
				stateMachine._003C_003Et__builder = nabf4fC66b4F6bewjOe();
				num = 4;
				if (AfN3aaCuEW2a8gfhmcg())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto IL_00a5;
			default:
				goto IL_00a5;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AfN3aaCuEW2a8gfhmcg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FYWO1ICIllIxcoGE2H1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mtYItSCRE2U9AXEAxLh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BHFeFACarfgIcUDFim6(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder JIIegVCnC8XdLPNtymd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TFQ3Y1CG1Npak2S4aU7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((LinkedList<IUndoAction>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x1Ne7cCXRBK3b2yVTH4(object P_0, UndoEventType eventType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UndoRedoQueue)P_0).OnUndoChanged(eventType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LY6fNNCbFJrIEZvveV9(object P_0, UndoEventType eventType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoRedoQueue)P_0).OnUndoChangedAsync(eventType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder nabf4fC66b4F6bewjOe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NdH4l0CphZ0UpkyFLcG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoHandlerUndoText;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Dsa8hqC0bSZsEtw7Bh5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LinkedList<IUndoAction>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L7SCgDC4P2PYbGX7pdu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoHandlerRedoText;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fLYu17CkhlGCsOqlJWk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}
}
