using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class UndoActionBlockingProgressWrapper : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoActionBlockingProgressWrapper _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!CNNnAfKuDfrHo6cQ89Sk()) ? 3 : 4);
			UndoActionBlockingProgressWrapper undoActionBlockingProgressWrapper = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (hv3CBMKui9Fa2MHQfguS())
					{
					}
					break;
				case 1:
				case 3:
					undoActionBlockingProgressWrapper = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (undoActionBlockingProgressWrapper.ztpHu3DqCF != null)
							{
								awaiter = B3wvlpKuVvj6omWYd0HV(tCL9ttKunFD4tuL9gtuD(undoActionBlockingProgressWrapper.ztpHu3DqCF));
								goto IL_00ca;
							}
							hv3CBMKui9Fa2MHQfguS();
							num3 = ((!CNNnAfKuDfrHo6cQ89Sk()) ? 7 : 2);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_00f9;
						IL_019c:
						awaiter.GetResult();
						goto end_IL_006d;
						IL_00ca:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							goto IL_00f9;
						}
						goto IL_019c;
						IL_00f9:
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (true)
								{
									continue;
								}
								break;
							case 1:
							case 7:
								break;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (CNNnAfKuDfrHo6cQ89Sk())
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
							case 2:
								goto end_IL_006d;
							case 6:
								return;
							case 10:
								goto IL_019c;
							}
							break;
						}
						goto IL_00ca;
						end_IL_006d:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 2;
				default:
					num = 2;
					if (!CNNnAfKuDfrHo6cQ89Sk())
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
		internal static object tCL9ttKunFD4tuL9gtuD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter B3wvlpKuVvj6omWYd0HV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CNNnAfKuDfrHo6cQ89Sk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hv3CBMKui9Fa2MHQfguS()
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
	private struct _003CDo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoActionBlockingProgressWrapper _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			saEnBDKud9E8rnI5SFDN();
			int num;
			if (vaMiWCKufIWrk6WTtskX())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (saEnBDKud9E8rnI5SFDN())
				{
					goto IL_0201;
				}
			}
			goto IL_01a8;
			IL_01a8:
			int num2 = default;
			UndoActionBlockingProgressWrapper undoActionBlockingProgressWrapper = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (undoActionBlockingProgressWrapper.ztpHu3DqCF == null)
							{
								num3 = 2;
							}
							else
							{
								awaiter = undoActionBlockingProgressWrapper.hHcH6tEBdU(undoActionBlockingProgressWrapper.ztpHu3DqCF.Do, undoActionBlockingProgressWrapper.mh2HXwXhmW).GetAwaiter();
								num3 = 1;
							}
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
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 9;
								if (vaMiWCKufIWrk6WTtskX())
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 4:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 2:
								goto end_IL_0107;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								vaMiWCKufIWrk6WTtskX();
								num3 = ((!saEnBDKud9E8rnI5SFDN()) ? 7 : 6);
								continue;
							case 6:
								return;
							case 10:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0107:
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
				default:
					num = 2;
					continue;
				case 1:
				case 4:
					undoActionBlockingProgressWrapper = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_0201;
			IL_0201:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a8;
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
		internal static bool vaMiWCKufIWrk6WTtskX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool saEnBDKud9E8rnI5SFDN()
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
	private struct _003CRedo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoActionBlockingProgressWrapper _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			UndoActionBlockingProgressWrapper undoActionBlockingProgressWrapper = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					undoActionBlockingProgressWrapper = _003C_003E4__this;
					num = 0;
					continue;
				case 2:
					num2 = _003C_003E1__state;
					lTyvbYKulowqfnwKVd0q();
					if (!RiVWfcKugEIEWgBHrLeG())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (false)
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
							if (undoActionBlockingProgressWrapper.ztpHu3DqCF != null)
							{
								awaiter = GRiKjyKusemRgloQMAxC(undoActionBlockingProgressWrapper.hHcH6tEBdU(undoActionBlockingProgressWrapper.ztpHu3DqCF.Redo, undoActionBlockingProgressWrapper.wIOHogr3GL));
								goto IL_009d;
							}
							RiVWfcKugEIEWgBHrLeG();
							if (lTyvbYKulowqfnwKVd0q())
							{
								num3 = 8;
							}
							else
							{
								num3 = 9;
								if (1 == 0)
								{
									goto IL_011d;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						goto IL_016a;
						IL_009d:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							goto IL_016a;
						}
						goto IL_01a5;
						IL_01a5:
						awaiter.GetResult();
						goto end_IL_005f;
						IL_011d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						if (!lTyvbYKulowqfnwKVd0q())
						{
							return;
						}
						goto IL_016a;
						IL_016a:
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 1:
							case 9:
								break;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (lTyvbYKulowqfnwKVd0q())
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
							case 8:
								goto end_IL_005f;
							case 7:
								goto IL_011d;
							case 4:
								return;
							case 5:
								_003C_003Eu__1 = awaiter;
								goto IL_011d;
							default:
								num3 = 7;
								continue;
							case 10:
								goto IL_01a5;
							}
							break;
						}
						goto IL_009d;
						end_IL_005f:;
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
		internal static TaskAwaiter GRiKjyKusemRgloQMAxC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lTyvbYKulowqfnwKVd0q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RiVWfcKugEIEWgBHrLeG()
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
	private struct _003CUndo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoActionBlockingProgressWrapper _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!BgeIr9KuvxxrcGZQGhuG())
			{
				goto IL_001e;
			}
			goto IL_01de;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 0;
			if (JrN3n8KurFyXo18qlOj9())
			{
			}
			goto IL_01de;
			IL_01de:
			UndoActionBlockingProgressWrapper undoActionBlockingProgressWrapper = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
					undoActionBlockingProgressWrapper = _003C_003E4__this;
					BgeIr9KuvxxrcGZQGhuG();
					if (!JrN3n8KurFyXo18qlOj9())
					{
						num = 1;
						continue;
					}
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto default;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (undoActionBlockingProgressWrapper.ztpHu3DqCF == null)
							{
								num3 = 0;
							}
							else
							{
								awaiter = RGbbXiKuPA9X4We5gYAA(undoActionBlockingProgressWrapper.hHcH6tEBdU(undoActionBlockingProgressWrapper.ztpHu3DqCF.Undo, undoActionBlockingProgressWrapper.tqyHSil2Nm));
								num3 = 8;
								if (1 == 0)
								{
									goto IL_00aa;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_0102;
						IL_0102:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 8:
								goto IL_00aa;
							case 2:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (BgeIr9KuvxxrcGZQGhuG())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 1:
								return;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto IL_019e;
							case 10:
								goto IL_019e;
							}
							break;
						}
						goto end_IL_005a;
						IL_00aa:
						if (!awaiter.IsCompleted)
						{
							BgeIr9KuvxxrcGZQGhuG();
							num3 = (JrN3n8KurFyXo18qlOj9() ? 1 : 7);
							goto IL_0102;
						}
						goto IL_019e;
						IL_019e:
						awaiter.GetResult();
						end_IL_005a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
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
		internal static TaskAwaiter RGbbXiKuPA9X4We5gYAA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BgeIr9KuvxxrcGZQGhuG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JrN3n8KurFyXo18qlOj9()
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
	private struct _003CDoAction_BlockUiIfNotYetBlocked_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoActionBlockingProgressWrapper _003C_003E4__this;

		public Func<Task> action;

		public string message;

		private TaskAwaiter _003C_003Eu__1;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nFQ9fGKuZBJpf2CfaK1f();
			int num = (PoaDuZKuByrqvAvD56CE() ? 1 : 5);
			UndoActionBlockingProgressWrapper undoActionBlockingProgressWrapper = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					undoActionBlockingProgressWrapper = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 2:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00ce;
						}
						if (num2 != 1)
						{
							if (undoActionBlockingProgressWrapper.BF1HFhVG7t == null || undoActionBlockingProgressWrapper.BF1HFhVG7t.HasOperationsPending)
							{
								awaiter = oSnQifKub4a7fuekJdfX(action());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00ce;
							}
							_003C_003E7__wrap1 = (ITopLevelProgressableOperation)iPqhcRKuGCfw1KD9TDAV(undoActionBlockingProgressWrapper.BF1HFhVG7t, message, Array.Empty<StepDescriptor>());
						}
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 9;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 8;
							}
							while (true)
							{
								switch (num3)
								{
								case 9:
									awaiter = oSnQifKub4a7fuekJdfX(action());
									num3 = 2;
									if (!PoaDuZKuByrqvAvD56CE())
									{
										continue;
									}
									goto case 1;
								case 1:
								case 3:
									_003C_003Eu__1 = awaiter;
									goto default;
								case 5:
									num2 = (_003C_003E1__state = 1);
									PoaDuZKuByrqvAvD56CE();
									if (!nFQ9fGKuZBJpf2CfaK1f())
									{
										num3 = 7;
										continue;
									}
									num3 = 1;
									if (true)
									{
										continue;
									}
									goto case 2;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									break;
								case 0:
									return;
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 8;
								case 8:
									_003C_003Eu__1 = default;
									num3 = 6;
									continue;
								default:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									continue;
								case 10:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								zk1rK2KuohCyXj22P3Tx(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
						goto end_IL_004a;
						IL_00ce:
						awaiter.GetResult();
						end_IL_004a:;
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
		internal static TaskAwaiter oSnQifKub4a7fuekJdfX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iPqhcRKuGCfw1KD9TDAV(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zk1rK2KuohCyXj22P3Tx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nFQ9fGKuZBJpf2CfaK1f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PoaDuZKuByrqvAvD56CE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly IUndoAction ztpHu3DqCF;

	private readonly IOperationProgressManager BF1HFhVG7t;

	private readonly string mh2HXwXhmW;

	private readonly string wIOHogr3GL;

	private readonly string tqyHSil2Nm;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IUndoAction undoAction = ztpHu3DqCF;
			return (string)(((undoAction != null) ? w9PqM2yXWSK3tZnLe1O(undoAction) : null) ?? "");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoActionBlockingProgressWrapper(IOperationProgressManager progressManager, IUndoAction undoAction, string doBusyMessage, string undoBusyMessage, string redoBusyMessage = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cvbvmky8CMT2J4oK6Jt();
		int num = (rLvmanyq4QedjeHP0qM() ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				brhQ5GyEpd5rarRKj82();
				num = 1;
				if (rLvmanyq4QedjeHP0qM())
				{
				}
				break;
			case 3:
				ztpHu3DqCF = undoAction;
				num = 6;
				break;
			case 1:
				s3kdGUyp0a0GSOBlKk6(this);
				goto case 2;
			case 2:
			case 5:
				BF1HFhVG7t = progressManager;
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				mh2HXwXhmW = doBusyMessage ?? "";
				tqyHSil2Nm = undoBusyMessage ?? "";
				wIOHogr3GL = redoBusyMessage ?? mh2HXwXhmW;
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__8))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CSaveState_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 2:
				stateMachine._003C_003Et__builder = q6PV3iy92gk1t61Tm31();
				_ = 1;
				num = (rLvmanyq4QedjeHP0qM() ? 4 : 0);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__9))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003Et__builder = q6PV3iy92gk1t61Tm31();
				cvbvmky8CMT2J4oK6Jt();
				if (!rLvmanyq4QedjeHP0qM())
				{
					num = 5;
					break;
				}
				num = 4;
				if (cvbvmky8CMT2J4oK6Jt())
				{
					break;
				}
				goto case 2;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__10))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rLvmanyq4QedjeHP0qM();
		int num;
		if (cvbvmky8CMT2J4oK6Jt())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (!cvbvmky8CMT2J4oK6Jt())
			{
				goto IL_00c3;
			}
		}
		_003CRedo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = q6PV3iy92gk1t61Tm31();
				num = 5;
				continue;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				if (rLvmanyq4QedjeHP0qM())
				{
				}
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				break;
			}
			break;
		}
		goto IL_00c3;
		IL_00c3:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__11))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rLvmanyq4QedjeHP0qM();
		int num = ((!cvbvmky8CMT2J4oK6Jt()) ? 1 : 4);
		_003CUndo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = q6PV3iy92gk1t61Tm31();
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAction_BlockUiIfNotYetBlocked_003Ed__12))]
	private Task hHcH6tEBdU(Func<Task> P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDoAction_BlockUiIfNotYetBlocked_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.action = P_0;
		stateMachine.message = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void brhQ5GyEpd5rarRKj82()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s3kdGUyp0a0GSOBlKk6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cvbvmky8CMT2J4oK6Jt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rLvmanyq4QedjeHP0qM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w9PqM2yXWSK3tZnLe1O(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IUndoAction)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder q6PV3iy92gk1t61Tm31()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
