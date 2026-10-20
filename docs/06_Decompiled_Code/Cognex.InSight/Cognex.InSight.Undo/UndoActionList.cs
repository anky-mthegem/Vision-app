using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public sealed class UndoActionList : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (U3EJc0siPIg6ZBsByxDt() ? 2 : 4);
			int num2 = default;
			while (true)
			{
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
							awaiter = XLdVFLsiNFuL1Dt3v8sL(BePmNfsiYk7fNJ2QJR2K());
							U3EJc0siPIg6ZBsByxDt();
							num3 = ((!iklRsasiouIM8s0dTrR6()) ? 6 : 3);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 0:
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
								return;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
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
					num = 3;
					continue;
				case 3:
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 5;
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
		internal static object BePmNfsiYk7fNJ2QJR2K()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XLdVFLsiNFuL1Dt3v8sL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iklRsasiouIM8s0dTrR6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U3EJc0siPIg6ZBsByxDt()
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
	private struct _003CDo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoActionList _003C_003E4__this;

		private List<IUndoAction>.Enumerator _003C_003E7__wrap1;

		private IUndoAction _003Caction_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VZ95N3sixB6mCjOR9QfU();
			int num;
			if (!j9evWBsi1K0yy8hBOIWZ())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_02e6;
			IL_002a:
			UndoActionList undoActionList = _003C_003E4__this;
			num = 5;
			goto IL_02e6;
			IL_02e6:
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				case 5:
					try
					{
						if ((uint)num2 > 1u)
						{
							_003C_003E7__wrap1 = undoActionList.qH24Fqitl2.GetEnumerator();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 2;
									if (false)
									{
										goto IL_0273;
									}
								}
								else
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num3 = 14;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 16;
								if (j9evWBsi1K0yy8hBOIWZ())
								{
									goto IL_00e9;
								}
							}
							goto IL_0126;
							IL_0273:
							if (_003C_003E7__wrap1.MoveNext())
							{
								_003Caction_003E5__3 = _003C_003E7__wrap1.Current;
								num3 = 0;
								goto IL_0126;
							}
							goto end_IL_0054;
							IL_00e9:
							num2 = (_003C_003E1__state = 1);
							num3 = 8;
							goto IL_0126;
							IL_0126:
							while (true)
							{
								switch (num3)
								{
								case 13:
									break;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 17;
									continue;
								case 4:
								case 9:
									return;
								case 5:
									goto end_IL_0126;
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 1;
									continue;
								case 15:
									awaiter.GetResult();
									goto case 10;
								default:
									num3 = 10;
									continue;
								case 17:
									return;
								case 3:
									awaiter.GetResult();
									num3 = 11;
									if (0 == 0)
									{
										continue;
									}
									goto case 11;
								case 11:
									_003Caction_003E5__3 = null;
									num3 = 18;
									continue;
								case 16:
									_003C_003Eu__1 = default;
									goto case 6;
								case 14:
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									continue;
								case 10:
									awaiter = ((Task)AHEHl7si3B42Xb6oXWXh(_003Caction_003E5__3)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									goto case 3;
								case 0:
									awaiter = BgNl6fsirxIouJImuYnL(_003Caction_003E5__3.SaveState());
									if (awaiter.IsCompleted)
									{
										goto case 15;
									}
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								case 6:
								case 12:
									num2 = (_003C_003E1__state = -1);
									num3 = 15;
									continue;
								case 7:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num3 = 13;
									continue;
								case 2:
								case 18:
									goto IL_0273;
								}
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								VZ95N3sixB6mCjOR9QfU();
								num3 = (j9evWBsi1K0yy8hBOIWZ() ? 12 : 9);
								continue;
								end_IL_0126:
								break;
							}
							goto IL_00e9;
							end_IL_0054:;
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					continue;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (j9evWBsi1K0yy8hBOIWZ())
					{
					}
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
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
		internal static TaskAwaiter BgNl6fsirxIouJImuYnL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AHEHl7si3B42Xb6oXWXh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VZ95N3sixB6mCjOR9QfU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j9evWBsi1K0yy8hBOIWZ()
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
	private struct _003CRedo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoActionList _003C_003E4__this;

		private List<IUndoAction>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_01fd;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01fd;
			IL_01fd:
			UndoActionList undoActionList = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					undoActionList = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = undoActionList.qH24Fqitl2.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_018a;
							}
							TaskAwaiter awaiter = _003C_003Eu__1;
							int num3 = 9;
							if (CpZ22fsiML1mf8taYINT())
							{
							}
							goto IL_00a3;
							IL_00a3:
							while (true)
							{
								switch (num3)
								{
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 3;
									continue;
								case 5:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 0;
								case 8:
									num2 = (_003C_003E1__state = 0);
									lls173siOSD29F9b9a2Q();
									num3 = ((!CpZ22fsiML1mf8taYINT()) ? 6 : 0);
									continue;
								case 0:
								case 7:
									awaiter.GetResult();
									num3 = 10;
									if (true)
									{
										continue;
									}
									return;
								case 3:
									return;
								case 9:
									_003C_003Eu__1 = default;
									num3 = 4;
									continue;
								case 4:
									num2 = (_003C_003E1__state = -1);
									goto case 0;
								case 2:
								case 6:
									_003C_003Eu__1 = awaiter;
									num3 = 1;
									continue;
								case 10:
									break;
								}
								break;
							}
							goto IL_018a;
							IL_018a:
							if (_003C_003E7__wrap1.MoveNext())
							{
								awaiter = _003C_003E7__wrap1.Current.Redo().GetAwaiter();
								num3 = 5;
								goto IL_00a3;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
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
					num2 = _003C_003E1__state;
					CpZ22fsiML1mf8taYINT();
					if (!lls173siOSD29F9b9a2Q())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (1 == 0)
					{
						return;
					}
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
		internal static bool lls173siOSD29F9b9a2Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CpZ22fsiML1mf8taYINT()
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
	private struct _003CUndo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoActionList _003C_003E4__this;

		private IEnumerator<IUndoAction> _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			UndoActionList undoActionList = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					xE5uyEsiQWkGRnYQQxI0();
					num = (vRrxqNsiloWCUCuT7nyr() ? 3 : 5);
					break;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (xE5uyEsiQWkGRnYQQxI0())
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					undoActionList = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = Enumerable.Reverse(undoActionList.qH24Fqitl2).GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_01b4;
							}
							TaskAwaiter awaiter = _003C_003Eu__1;
							goto IL_0174;
							IL_0103:
							int num3;
							while (true)
							{
								switch (num3)
								{
								case 8:
									break;
								case 1:
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									continue;
								case 3:
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 2;
									if (true)
									{
										continue;
									}
									return;
								case 2:
									return;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										if (0 == 0)
										{
											continue;
										}
										goto end_IL_0103;
									}
									goto case 0;
								case 5:
								case 6:
									goto end_IL_0103;
								case 9:
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									if (!vRrxqNsiloWCUCuT7nyr())
									{
										continue;
									}
									goto case 0;
								case 0:
									awaiter.GetResult();
									num3 = 10;
									continue;
								case 10:
									goto IL_01b4;
								}
								_003C_003Eu__1 = awaiter;
								_ = 0;
								num3 = ((!xE5uyEsiQWkGRnYQQxI0()) ? 6 : 7);
								continue;
								end_IL_0103:
								break;
							}
							goto IL_0174;
							IL_01b4:
							if (QR8sS3siIQu3svTIPsjk(_003C_003E7__wrap1))
							{
								awaiter = v59wFksiuYJHUYDIRuAp(BoFVDOsiejihrK8DBTxE(_003C_003E7__wrap1.Current));
								num3 = 4;
								goto IL_0103;
							}
							goto end_IL_0088;
							IL_0174:
							_003C_003Eu__1 = default;
							num3 = 9;
							goto IL_0103;
							end_IL_0088:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								_003C_003E7__wrap1.Dispose();
							}
						}
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
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
		internal static object BoFVDOsiejihrK8DBTxE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter v59wFksiuYJHUYDIRuAp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QR8sS3siIQu3svTIPsjk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xE5uyEsiQWkGRnYQQxI0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vRrxqNsiloWCUCuT7nyr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private List<IUndoAction> qH24Fqitl2;

	[CompilerGenerated]
	private readonly string yhH4bkG6uW;

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
			return yhH4bkG6uW;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoActionList(string text)
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
			case 2:
			case 4:
				base._002Ector();
				goto default;
			default:
				yhH4bkG6uW = text;
				num = 6;
				if (!QNk0WTWHl0kpMH0QoRx())
				{
					break;
				}
				goto case 5;
			case 5:
				qH24Fqitl2 = new List<IUndoAction>();
				QNk0WTWHl0kpMH0QoRx();
				num = ((!xHIOpTWvpKOhK4gWr2x()) ? 1 : 4);
				break;
			case 0:
				F6mPoGWVUbYVSPwH1nR();
				num = 5;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoActionList(string text, params IUndoAction[] actions)
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
			case 0:
				F6mPoGWVUbYVSPwH1nR();
				_ = 1;
				if (!QNk0WTWHl0kpMH0QoRx())
				{
					num = 4;
					continue;
				}
				num = 3;
				if (QNk0WTWHl0kpMH0QoRx())
				{
				}
				continue;
			case 1:
			case 4:
				this._002Ector(text);
				break;
			case 5:
				return;
			}
			qH24Fqitl2.AddRange(actions);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__6))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSaveState_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 3:
				stateMachine._003C_003Et__builder = dRPdoPWAmJdq2flCwLZ();
				xHIOpTWvpKOhK4gWr2x();
				if (!QNk0WTWHl0kpMH0QoRx())
				{
					num = 0;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				num = 4;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__7))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				while (true)
				{
					stateMachine._003C_003E4__this = this;
					xHIOpTWvpKOhK4gWr2x();
					if (!QNk0WTWHl0kpMH0QoRx())
					{
						break;
					}
					num = 1;
					if (!QNk0WTWHl0kpMH0QoRx())
					{
						goto end_IL_0032;
					}
				}
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = dRPdoPWAmJdq2flCwLZ();
				num = 4;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				{
					return stateMachine._003C_003Et__builder.Task;
				}
				end_IL_0032:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__8))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!QNk0WTWHl0kpMH0QoRx())
		{
			num = 4;
		}
		else
		{
			num = 5;
			if (!xHIOpTWvpKOhK4gWr2x())
			{
				goto IL_0042;
			}
		}
		goto IL_0074;
		IL_0074:
		_003CRedo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 1:
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 1;
				if (xHIOpTWvpKOhK4gWr2x())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = dRPdoPWAmJdq2flCwLZ();
				num = 3;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0042;
		IL_0042:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_004c;
		IL_009f:
		_003CUndo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (xHIOpTWvpKOhK4gWr2x())
		{
			goto IL_004c;
		}
		goto IL_00bd;
		IL_00bd:
		return stateMachine._003C_003Et__builder.Task;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 0:
			case 2:
				goto IL_0032;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder = dRPdoPWAmJdq2flCwLZ();
				QNk0WTWHl0kpMH0QoRx();
				num = (xHIOpTWvpKOhK4gWr2x() ? 5 : 0);
				continue;
			case 4:
				goto IL_009f;
			case 6:
				goto IL_00bd;
			}
			break;
		}
		goto IL_001a;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_0032;
		IL_0032:
		stateMachine._003C_003E1__state = -1;
		goto IL_009f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F6mPoGWVUbYVSPwH1nR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xHIOpTWvpKOhK4gWr2x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QNk0WTWHl0kpMH0QoRx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder dRPdoPWAmJdq2flCwLZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
