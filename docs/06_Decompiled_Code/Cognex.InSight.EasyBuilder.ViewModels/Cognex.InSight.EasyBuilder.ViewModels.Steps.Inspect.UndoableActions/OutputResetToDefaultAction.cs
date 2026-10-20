using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class OutputResetToDefaultAction : IUndoAction
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
			int num = 0;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = jA0XVoK2Tx9mWsDZX156(dxnituK2WkjkZuZuqIjj());
							num3 = 6;
							goto IL_00d8;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0048;
						IL_0048:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_00d8;
						IL_00d8:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 5:
								break;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 1:
								return;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								if (!GpxMXnK2AwykRNeLXGmr())
								{
									num3 = 0;
									continue;
								}
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_00d8;
							}
							goto IL_0048;
							continue;
							end_IL_00d8:
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
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!i2qMpqK2RquxCEmEAoAy()) ? 4 : 3);
					break;
				case 5:
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
		internal static object dxnituK2WkjkZuZuqIjj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter jA0XVoK2Tx9mWsDZX156(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GpxMXnK2AwykRNeLXGmr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i2qMpqK2RquxCEmEAoAy()
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

		public OutputResetToDefaultAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!EQYTcgK20qSQUTGfkbg1())
			{
				num = 2;
			}
			else
			{
				num = 1;
				if (!wZwF1vK2yDemHadhwVbk())
				{
					goto IL_01e7;
				}
			}
			goto IL_01b0;
			IL_01b0:
			OutputResetToDefaultAction outputResetToDefaultAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					outputResetToDefaultAction = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ErEoIGK2M8UUQ3Uc45LP(outputResetToDefaultAction.w0jOWjoP81, QsXYSPK2FjlNXfsHdtBA(outputResetToDefaultAction.w0jOWjoP81));
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 2:
								awaiter = fDnm7pK2UxBiWQF8nly9(cb8U9EK2YjNCq5Xk53j6());
								EQYTcgK20qSQUTGfkbg1();
								num3 = (wZwF1vK2yDemHadhwVbk() ? 9 : 0);
								continue;
							case 6:
								_003C_003Eu__1 = default;
								goto case 0;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 4:
								return;
							case 0:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (!EQYTcgK20qSQUTGfkbg1())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (EQYTcgK20qSQUTGfkbg1())
								{
								}
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (!EQYTcgK20qSQUTGfkbg1())
								{
									continue;
								}
								break;
							case 10:
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
					goto default;
				case 0:
				case 2:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_01e7;
			IL_01e7:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_01b0;
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
		internal static object QsXYSPK2FjlNXfsHdtBA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((OutputLinksViewModel)P_0).vghO3Gq9XT();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ErEoIGK2M8UUQ3Uc45LP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((OutputLinksViewModel)P_0).SelectedLink = (SourceLink)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cb8U9EK2YjNCq5Xk53j6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter fDnm7pK2UxBiWQF8nly9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wZwF1vK2yDemHadhwVbk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EQYTcgK20qSQUTGfkbg1()
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

		public OutputResetToDefaultAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (KZlrBZK2HBMdgqmO8lxG())
			{
				num = 5;
			}
			else
			{
				num = 1;
				if (Pt3XYtK2xYWG9QJ7w7q1())
				{
				}
			}
			OutputResetToDefaultAction outputResetToDefaultAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!Pt3XYtK2xYWG9QJ7w7q1())
					{
						break;
					}
					goto case 3;
				case 3:
					outputResetToDefaultAction = _003C_003E4__this;
					goto case 1;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = IU2WQ2K2menyswMwsxxv(outputResetToDefaultAction.Do());
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (false)
							{
								goto IL_00b1;
							}
						}
						goto IL_00d1;
						IL_0176:
						awaiter.GetResult();
						goto end_IL_0060;
						IL_00fe:
						_ = 1;
						if (!Pt3XYtK2xYWG9QJ7w7q1())
						{
							num3 = 1;
							if (false)
							{
								goto IL_0116;
							}
						}
						else
						{
							num3 = 5;
							if (Pt3XYtK2xYWG9QJ7w7q1())
							{
							}
						}
						goto IL_00d1;
						IL_00d1:
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (Pt3XYtK2xYWG9QJ7w7q1())
								{
								}
								continue;
							case 1:
							case 4:
								return;
							case 0:
								break;
							default:
								goto IL_00fe;
							case 8:
								goto IL_0116;
							case 7:
								_003C_003Eu__1 = default;
								goto case 5;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 5:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								goto IL_0176;
							}
							break;
						}
						goto IL_00b1;
						IL_00b1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto IL_00fe;
						IL_0116:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							goto IL_00d1;
						}
						goto IL_0176;
						end_IL_0060:;
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
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
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
		internal static TaskAwaiter IU2WQ2K2menyswMwsxxv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KZlrBZK2HBMdgqmO8lxG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pt3XYtK2xYWG9QJ7w7q1()
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

		public OutputResetToDefaultAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (IfhgHwK2N5EUdg5me5i9() ? 3 : 5);
			OutputResetToDefaultAction outputResetToDefaultAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 3:
					outputResetToDefaultAction = _003C_003E4__this;
					num = 2;
					if (X9utDSK2QT49Vrtc2wKZ())
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
							i9Ynr6K22d4l53pRbtuR(outputResetToDefaultAction.w0jOWjoP81, outputResetToDefaultAction.yYqOTqpeRr);
							X9utDSK2QT49Vrtc2wKZ();
							num3 = (IfhgHwK2N5EUdg5me5i9() ? 9 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (1 == 0)
							{
								goto IL_00ed;
							}
						}
						goto IL_009a;
						IL_009a:
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 5:
								return;
							case 9:
								return;
							case 8:
								break;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
							case 7:
								awaiter = ((Task)l7H2ZyK2cXULMagNKKbj()).GetAwaiter();
								num3 = 8;
								if (!IfhgHwK2N5EUdg5me5i9())
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								goto IL_0178;
							}
							break;
						}
						goto IL_00ed;
						IL_0178:
						awaiter.GetResult();
						goto end_IL_0050;
						IL_00ed:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							goto IL_009a;
						}
						goto IL_0178;
						end_IL_0050:;
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
					if (IfhgHwK2N5EUdg5me5i9())
					{
					}
					break;
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
		internal static void i9Ynr6K22d4l53pRbtuR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((OutputLinksViewModel)P_0).SelectedLink = (SourceLink)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object l7H2ZyK2cXULMagNKKbj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X9utDSK2QT49Vrtc2wKZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IfhgHwK2N5EUdg5me5i9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly SourceLink yYqOTqpeRr;

	private readonly OutputLinksViewModel w0jOWjoP81;

	[CompilerGenerated]
	private readonly string IJxOjq5dxM;

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
			return IJxOjq5dxM;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutputResetToDefaultAction(OutputLinksViewModel vm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!vOXyCSTFgLddYfqrWdJ())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0044;
		IL_006f:
		w0jOWjoP81 = vm;
		num = 6;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_006f;
			case 1:
			case 2:
				XA0ZFGTMGxf1vFBg7Is(this);
				num = 4;
				if (dEoJrJT0MVgSMMB44Np())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		yYqOTqpeRr = vm.SelectedLink;
		goto IL_006f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__6))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CSaveState_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 0:
				stateMachine._003C_003Et__builder = M4S0uiTYXlQ7YiIWlGa();
				_ = 0;
				num = (dEoJrJT0MVgSMMB44Np() ? 3 : 4);
				break;
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
		dEoJrJT0MVgSMMB44Np();
		int num = (vOXyCSTFgLddYfqrWdJ() ? 5 : 2);
		_003CDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = M4S0uiTYXlQ7YiIWlGa();
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (dEoJrJT0MVgSMMB44Np())
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
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
		int num = 2;
		_003CRedo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				vOXyCSTFgLddYfqrWdJ();
				if (!dEoJrJT0MVgSMMB44Np())
				{
					num = 0;
					continue;
				}
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (dEoJrJT0MVgSMMB44Np())
		{
			num = 4;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0070;
		IL_0026:
		_003CUndo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = M4S0uiTYXlQ7YiIWlGa();
		num = 3;
		goto IL_0070;
		IL_0070:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				continue;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XA0ZFGTMGxf1vFBg7Is(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dEoJrJT0MVgSMMB44Np()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vOXyCSTFgLddYfqrWdJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder M4S0uiTYXlQ7YiIWlGa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
