using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class UndoFormatStringRemoveArgument : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringRemoveArgument _003C_003E4__this;

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
			if (UYISE25d3wZY4SC5fUdJ())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (FZT2795djkIFLbxRL0Sl())
				{
					goto IL_0056;
				}
			}
			goto IL_01e5;
			IL_01e5:
			int num2 = default;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			UndoFormatStringRemoveArgument undoFormatStringRemoveArgument = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 3:
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ezFormatStringViewModel = undoFormatStringRemoveArgument.GM8kOnYn9J();
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 3:
								return;
							case 7:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 1;
								if (FZT2795djkIFLbxRL0Sl())
								{
									num3 = 3;
									if (true)
									{
										continue;
									}
									goto case 1;
								}
								num3 = 2;
								if (UYISE25d3wZY4SC5fUdJ())
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 6:
							{
								FormatStringArgViewModel argument = undoFormatStringRemoveArgument.OW3kHBDTwL(ezFormatStringViewModel, undoFormatStringRemoveArgument.X4lkeUlmXi);
								awaiter = ((FormatStringViewModel)xBW1aT5d6BfRbJQtQNpB(ezFormatStringViewModel)).RemoveArgumentAsync(argument).GetAwaiter();
								num3 = 0;
								continue;
							}
							case 9:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (FZT2795djkIFLbxRL0Sl())
								{
								}
								continue;
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
					goto case 2;
				default:
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0056;
			IL_0056:
			undoFormatStringRemoveArgument = _003C_003E4__this;
			num = 5;
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
		internal static object xBW1aT5d6BfRbJQtQNpB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).FormatStringViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UYISE25d3wZY4SC5fUdJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FZT2795djkIFLbxRL0Sl()
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
	private struct _003CRedo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringRemoveArgument _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YnjUQR5dC7YfkQbfSvGH();
			int num;
			if (!Suc5LC5dAHCaUoHVd5ch())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_0043;
				}
			}
			goto IL_01a2;
			IL_002a:
			int num2 = _003C_003E1__state;
			goto IL_0043;
			IL_01a2:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 5:
					goto IL_0043;
				case 4:
					goto IL_0056;
				default:
					num = 2;
					if (YnjUQR5dC7YfkQbfSvGH())
					{
						continue;
					}
					goto IL_01d3;
				case 2:
					goto IL_01d3;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_0043:
			UndoFormatStringRemoveArgument undoFormatStringRemoveArgument = _003C_003E4__this;
			num = 4;
			if (1 == 0)
			{
				goto IL_0056;
			}
			goto IL_01a2;
			IL_01d3:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a2;
			IL_0056:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = trO8nl5dRXgQ8fm91UuB(undoFormatStringRemoveArgument.Do());
					num3 = 0;
					if (Suc5LC5dAHCaUoHVd5ch())
					{
						goto IL_0078;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 7;
				}
				goto IL_0125;
				IL_0125:
				while (true)
				{
					switch (num3)
					{
					case 6:
						break;
					case 0:
						if (!awaiter.IsCompleted)
						{
							_ = 0;
							num3 = ((!YnjUQR5dC7YfkQbfSvGH()) ? 5 : 3);
							continue;
						}
						goto case 9;
					case 2:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 1:
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						if (!Suc5LC5dAHCaUoHVd5ch())
						{
							continue;
						}
						goto case 7;
					case 7:
						_003C_003Eu__1 = default;
						num3 = 2;
						if (true)
						{
							continue;
						}
						return;
					default:
						return;
					case 5:
						return;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 9:
						awaiter.GetResult();
						goto end_IL_0125;
					}
					goto IL_0078;
					continue;
					end_IL_0125:
					break;
				}
				goto end_IL_0056;
				IL_0078:
				_003C_003Eu__1 = awaiter;
				num3 = 8;
				goto IL_0125;
				end_IL_0056:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01d3;
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
		internal static TaskAwaiter trO8nl5dRXgQ8fm91UuB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YnjUQR5dC7YfkQbfSvGH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Suc5LC5dAHCaUoHVd5ch()
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
	private struct _003CUndo_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringRemoveArgument _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RHBsUW5dTwu3l6oRWGec();
			int num = ((!mfrvoh5dWedW2GC6f8yE()) ? 3 : 5);
			UndoFormatStringRemoveArgument undoFormatStringRemoveArgument = default;
			int num2 = default;
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
					undoFormatStringRemoveArgument = _003C_003E4__this;
					num = 2;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = vVufcP5d0lDVo6QGik9r(((FormatStringViewModel)eGvEaw5dyr15s6fZJbPi(undoFormatStringRemoveArgument.GM8kOnYn9J())).AddArgsAsync((IList<FormatStringArgViewModel>)new FormatStringArgViewModel[1] { undoFormatStringRemoveArgument.yuikvFERK1 }, undoFormatStringRemoveArgument.X4lkeUlmXi));
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (RHBsUW5dTwu3l6oRWGec())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								mfrvoh5dWedW2GC6f8yE();
								num3 = ((!RHBsUW5dTwu3l6oRWGec()) ? 5 : 7);
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
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
					goto case 4;
				default:
					num = 4;
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
		internal static object eGvEaw5dyr15s6fZJbPi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).FormatStringViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vVufcP5d0lDVo6QGik9r(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mfrvoh5dWedW2GC6f8yE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RHBsUW5dTwu3l6oRWGec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<FormatStringArgViewModel> _003C_003E9__15_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jYD3ul5dY8W5JdLOKj9o();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			jVUXS75dUOByfyqHbZfA(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CGetArgument_003Eb__15_0(FormatStringArgViewModel a)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			c6jmBw5dHWSJKiEuvY6P(a, false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jYD3ul5dY8W5JdLOKj9o()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wx5Qs25dFyg94Ogc6Mr4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AFSBEJ5dMx5ZPcxgGcJx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jVUXS75dUOByfyqHbZfA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void c6jmBw5dHWSJKiEuvY6P(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatStringArgViewModel)P_0).IsSelected = P_1;
		}
	}

	private CommStepViewModel AXakysmRsn;

	private Type uvOkxtcVjY;

	private FormatStringArgViewModel yuikvFERK1;

	private int X4lkeUlmXi;

	private Type[] Vcjk2LZwfI;

	[CompilerGenerated]
	private string d0ykqBeqE9;

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
			return d0ykqBeqE9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			d0ykqBeqE9 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoFormatStringRemoveArgument(CommStepViewModel commAppStep, Type type, FormatStringArgViewModel arg)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		EzFormatStringViewModel ezFormatStringViewModel = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				pRBAUj1MTnwHKGDwtqi();
				num = 3;
				break;
			case 1:
				if (!Vcjk2LZwfI.Contains(type))
				{
					throw new NotSupportedException(type.ToString());
				}
				AXakysmRsn = commAppStep;
				num = 9;
				break;
			case 8:
				yuikvFERK1 = arg;
				num = 6;
				break;
			case 5:
			case 7:
				X4lkeUlmXi = ezFormatStringViewModel.Arguments.IndexOf(arg);
				num = 10;
				break;
			case 9:
				uvOkxtcVjY = type;
				goto case 8;
			default:
				num = 8;
				break;
			case 6:
				ezFormatStringViewModel = GM8kOnYn9J();
				goto case 5;
			case 10:
				Text = (string)q8YAIo1mepeujX8IBQ4(sqawEc1H8kOo5EIkXGd(), K9gojY1xTrYAXKvimKG(arg));
				num = 11;
				break;
			case 3:
				Vcjk2LZwfI = new Type[3]
				{
					BTRu4W1Y1STBmrRyZtg(typeof(WriteDataFtp).TypeHandle),
					BTRu4W1Y1STBmrRyZtg(typeof(WriteDataSerial).TypeHandle),
					typeof(WriteTcpIp)
				};
				wAr5OE1FU6imNlpeR9A();
				if (!GSs9Dg104n41I4nOfE1())
				{
					num = 5;
					if (GSs9Dg104n41I4nOfE1())
					{
						break;
					}
					goto case 10;
				}
				num = 4;
				break;
			case 2:
			case 4:
				coNejB1U2Vw4oSrPqRX(this);
				num = 1;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__10))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (wAr5OE1FU6imNlpeR9A() ? 3 : 2);
		_003CDo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__11))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GSs9Dg104n41I4nOfE1();
		int num = (wAr5OE1FU6imNlpeR9A() ? 2 : 5);
		_003CRedo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (wAr5OE1FU6imNlpeR9A())
				{
				}
				continue;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
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
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__13))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wAr5OE1FU6imNlpeR9A();
		int num;
		if (GSs9Dg104n41I4nOfE1())
		{
			num = 1;
		}
		else
		{
			num = 2;
			if (!GSs9Dg104n41I4nOfE1())
			{
				goto IL_008b;
			}
		}
		goto IL_0054;
		IL_008b:
		_003CUndo_003Ed__13 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		num = 4;
		if (GSs9Dg104n41I4nOfE1())
		{
			goto IL_0054;
		}
		goto IL_00a7;
		IL_00a7:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0054;
		IL_0054:
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto IL_00a7;
			case 0:
			case 1:
				break;
			default:
				goto IL_00a7;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_008b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzFormatStringViewModel GM8kOnYn9J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		EzFormatStringViewModel result = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (poQhHv1QSw9UxpvRuOT(uvOkxtcVjY, BTRu4W1Y1STBmrRyZtg(typeof(WriteDataFtp).TypeHandle)))
				{
					wAr5OE1FU6imNlpeR9A();
					if (GSs9Dg104n41I4nOfE1())
					{
						num = 4;
						if (!wAr5OE1FU6imNlpeR9A())
						{
							continue;
						}
						goto case 6;
					}
					num = 1;
					if (!wAr5OE1FU6imNlpeR9A())
					{
						continue;
					}
					break;
				}
				if (poQhHv1QSw9UxpvRuOT(uvOkxtcVjY, BTRu4W1Y1STBmrRyZtg(typeof(WriteDataSerial).TypeHandle)))
				{
					goto case 8;
				}
				if (poQhHv1QSw9UxpvRuOT(uvOkxtcVjY, BTRu4W1Y1STBmrRyZtg(typeof(WriteTcpIp).TypeHandle)))
				{
					num = 0;
					continue;
				}
				break;
			case 6:
				result = null;
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				break;
			default:
				num = 8;
				if (wAr5OE1FU6imNlpeR9A())
				{
				}
				continue;
			case 2:
			case 4:
				result = (EzFormatStringViewModel)kO8dE312fIFhURDqCLF(oULGam1NE2pEalskXxb(AXakysmRsn));
				num = 7;
				continue;
			case 0:
				result = AXakysmRsn.WriteTcpIp.FormatString;
				num = 9;
				if (wAr5OE1FU6imNlpeR9A())
				{
				}
				continue;
			case 8:
				result = (EzFormatStringViewModel)kO8dE312fIFhURDqCLF(AXakysmRsn.WriteDataSerial);
				break;
			case 1:
			case 5:
			case 7:
			case 9:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FormatStringArgViewModel OW3kHBDTwL(EzFormatStringViewModel P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0099;
		IL_00c4:
		FormatStringArgViewModel result = P_0.Arguments[P_1];
		num = 6;
		goto IL_0099;
		IL_00db:
		return result;
		IL_0076:
		if (P_1 < DNk9Lf1caja4oqf3Qdd(P_0.Arguments))
		{
			goto IL_00c4;
		}
		goto IL_00db;
		IL_001a:
		P_0.Arguments.ForEach([MethodImpl(MethodImplOptions.NoInlining)] (FormatStringArgViewModel a) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec.c6jmBw5dHWSJKiEuvY6P(a, false);
		});
		if (P_1 >= 0)
		{
			goto IL_0076;
		}
		goto IL_00db;
		IL_0099:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 4:
				goto IL_005e;
			case 0:
			case 2:
				goto IL_0076;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_00c4;
			case 6:
				goto IL_00db;
			}
			break;
			IL_005e:
			result = null;
			_ = 1;
			num = ((!wAr5OE1FU6imNlpeR9A()) ? 5 : 0);
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pRBAUj1MTnwHKGDwtqi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type BTRu4W1Y1STBmrRyZtg(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void coNejB1U2Vw4oSrPqRX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sqawEc1H8kOo5EIkXGd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DpItyYFd3O();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K9gojY1xTrYAXKvimKG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringArgViewModel)P_0).LocalizedCellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q8YAIo1mepeujX8IBQ4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GSs9Dg104n41I4nOfE1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wAr5OE1FU6imNlpeR9A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool poQhHv1QSw9UxpvRuOT(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oULGam1NE2pEalskXxb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteDataFtp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kO8dE312fIFhURDqCLF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzFormatStringSupportSnippet)P_0).FormatString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DNk9Lf1caja4oqf3Qdd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<FormatStringArgViewModel>)P_0).Count;
	}
}
