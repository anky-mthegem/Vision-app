using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Common.Commands;
using Cognex.Extensions;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class UndoFormatStringMoveArg : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringMoveArg _003C_003E4__this;

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
			if (GYZH885dDjtfXyGh8Myy())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_003d;
				}
			}
			goto IL_02cb;
			IL_02cb:
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			UndoFormatStringMoveArg undoFormatStringMoveArg = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 14;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 4;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 13;
						}
						while (true)
						{
							switch (num3)
							{
							case 11:
								_003C_003Eu__1 = awaiter;
								goto case 7;
							case 3:
							case 6:
								awaiter = CVL8V35ddlRjRX9AQy6u(e1HOu95dfvK7WkqcOcXh(XnEUds5dVUBJPh55RaII(FwapkN5dncOtb70BWisa(ezFormatStringViewModel)), null));
								num3 = 8;
								continue;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 11;
								continue;
							case 12:
								num2 = (_003C_003E1__state = 1);
								num3 = 0;
								continue;
							case 17:
								goto end_IL_019e;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto IL_0163;
							case 4:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								if (f30SEU5diiC717GhKK2n())
								{
								}
								continue;
							case 1:
								return;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								break;
							case 9:
								num2 = (_003C_003E1__state = -1);
								goto IL_0163;
							case 7:
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 16:
								if (!undoFormatStringMoveArg.JhHkE4WyMK)
								{
									awaiter = ((Task)e1HOu95dfvK7WkqcOcXh(ezFormatStringViewModel.FormatStringViewModel.MoveDownCommand, null)).GetAwaiter();
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								}
								f30SEU5diiC717GhKK2n();
								num3 = (GYZH885dDjtfXyGh8Myy() ? 6 : 15);
								continue;
							case 2:
								undoFormatStringMoveArg.JDMkotuPwq(ezFormatStringViewModel, undoFormatStringMoveArg.Ns1kIqYJwR);
								num3 = 16;
								continue;
							case 14:
								ezFormatStringViewModel = undoFormatStringMoveArg.qlkkXcn7VW();
								num3 = 2;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
								_003C_003Eu__1 = default;
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 18:
								break;
								IL_0163:
								awaiter.GetResult();
								num3 = 17;
								if (f30SEU5diiC717GhKK2n())
								{
								}
								continue;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_019e:
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
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					undoFormatStringMoveArg = _003C_003E4__this;
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_003d;
			IL_003d:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02cb;
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
		internal static object FwapkN5dncOtb70BWisa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).FormatStringViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XnEUds5dVUBJPh55RaII(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatStringViewModel)P_0).MoveUpCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object e1HOu95dfvK7WkqcOcXh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncCommand)P_0).ExecuteAsync(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter CVL8V35ddlRjRX9AQy6u(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GYZH885dDjtfXyGh8Myy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f30SEU5diiC717GhKK2n()
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
	private struct _003CRedo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringMoveArg _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			UndoFormatStringMoveArg undoFormatStringMoveArg = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (ftLpU45dlItYJUbqHhiV())
					{
						break;
					}
					goto case 0;
				case 0:
					undoFormatStringMoveArg = _003C_003E4__this;
					yYQNUU5dgV2jRWlZuXr2();
					num = ((!ftLpU45dlItYJUbqHhiV()) ? 1 : 5);
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoFormatStringMoveArg.Do().GetAwaiter();
							num3 = 5;
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
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							default:
								return;
							case 3:
								return;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								yYQNUU5dgV2jRWlZuXr2();
								if (ftLpU45dlItYJUbqHhiV())
								{
									num3 = 1;
									continue;
								}
								num3 = 3;
								if (!yYQNUU5dgV2jRWlZuXr2())
								{
									continue;
								}
								goto case 7;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 0;
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
		internal static bool ftLpU45dlItYJUbqHhiV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yYQNUU5dgV2jRWlZuXr2()
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

		public UndoFormatStringMoveArg _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (w61TR35dvkVRAnklWBJa())
			{
				goto IL_001e;
			}
			goto IL_02b7;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 1;
			if (!w61TR35dvkVRAnklWBJa())
			{
				num = 3;
				if (false)
				{
					goto IL_003d;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_02b7;
			IL_02b7:
			TaskAwaiter awaiter = default;
			UndoFormatStringMoveArg undoFormatStringMoveArg = default;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
					goto IL_003d;
				case 2:
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 9;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 0;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 8;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 16:
								num2 = (_003C_003E1__state = 1);
								num3 = 11;
								continue;
							case 17:
								goto end_IL_01f4;
							case 1:
							case 4:
								undoFormatStringMoveArg.JDMkotuPwq(ezFormatStringViewModel, undoFormatStringMoveArg.wQVkfitIn5);
								num3 = 5;
								continue;
							case 10:
								return;
							case 0:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 9:
								ezFormatStringViewModel = undoFormatStringMoveArg.qlkkXcn7VW();
								pCNMoU5dsVIDnWtGbtgv();
								if (!w61TR35dvkVRAnklWBJa())
								{
									num3 = 4;
									continue;
								}
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 13;
							case 7:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								return;
							case 13:
								awaiter = ((Task)rIUfF05dZZMSWVa8fxWs(gvDyWJ5dPoV1GtxZvAUy(sBE7vg5drWi4OF6YmSN5(ezFormatStringViewModel)), null)).GetAwaiter();
								num3 = 14;
								continue;
							case 12:
								num2 = (_003C_003E1__state = -1);
								goto IL_0160;
							case 2:
								return;
							case 14:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								}
								goto IL_0160;
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 16;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								goto case 12;
							default:
								num3 = 12;
								continue;
							case 5:
								if (!undoFormatStringMoveArg.JhHkE4WyMK)
								{
									awaiter = N6ylox5dbjSgX2Z5PHQr(rIUfF05dZZMSWVa8fxWs(kkQlwA5dBq4d00lY6PXt(sBE7vg5drWi4OF6YmSN5(ezFormatStringViewModel)), null));
									num3 = 3;
								}
								else
								{
									num3 = 13;
								}
								continue;
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 15;
								continue;
							case 18:
								break;
								IL_0160:
								awaiter.GetResult();
								num3 = 17;
								continue;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_01f4:
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
					goto IL_003d;
				default:
					num = 0;
					continue;
				case 1:
				case 3:
					undoFormatStringMoveArg = _003C_003E4__this;
					goto case 2;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_003d:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02b7;
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
		internal static object sBE7vg5drWi4OF6YmSN5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).FormatStringViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gvDyWJ5dPoV1GtxZvAUy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatStringViewModel)P_0).MoveDownCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rIUfF05dZZMSWVa8fxWs(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncCommand)P_0).ExecuteAsync(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kkQlwA5dBq4d00lY6PXt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatStringViewModel)P_0).MoveUpCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter N6ylox5dbjSgX2Z5PHQr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pCNMoU5dsVIDnWtGbtgv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w61TR35dvkVRAnklWBJa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CommStepViewModel oWBkDMPRBk;

	private Type Y0qk3XoHug;

	private int Ns1kIqYJwR;

	private int wQVkfitIn5;

	private bool JhHkE4WyMK;

	private Type[] VRYkbOHYKA;

	[CompilerGenerated]
	private string fYrkc789eb;

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
			return fYrkc789eb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fYrkc789eb = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoFormatStringMoveArg(CommStepViewModel commAppStep, Type type, bool up)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		FormatStringArgViewModel formatStringArgViewModel = default;
		EzFormatStringViewModel ezFormatStringViewModel = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 6;
				break;
			case 6:
				VRYkbOHYKA = new Type[3]
				{
					typeof(WriteDataFtp),
					RfH9nF18xBhmtTa7MM2(typeof(WriteDataSerial).TypeHandle),
					RfH9nF18xBhmtTa7MM2(typeof(WriteTcpIp).TypeHandle)
				};
				_ = 1;
				num = ((!B7Cebe1ki33SXH5PaJc()) ? 1 : 9);
				break;
			case 4:
				if (JhHkE4WyMK)
				{
					Text = (string)UKYdKr1XenbB0HWEdUA(na8xlR1pnMx4gAi4FEX(), formatStringArgViewModel.CellName);
					num = 10;
					break;
				}
				Text = (string)UKYdKr1XenbB0HWEdUA(qjQWwF19dbMCDDW5q1I(), IcRqu914JICba7BtXgr(formatStringArgViewModel));
				num = 13;
				if (!B7Cebe1ki33SXH5PaJc())
				{
					break;
				}
				goto case 0;
			case 7:
				JhHkE4WyMK = up;
				goto case 8;
			default:
				num = 8;
				break;
			case 3:
			case 9:
				throw new NotSupportedException(type.ToString());
			case 12:
				Y0qk3XoHug = type;
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				GfHqV71qKNmkfdcjYN1(this);
				if (VRYkbOHYKA.Contains(type))
				{
					oWBkDMPRBk = commAppStep;
					num = 12;
					break;
				}
				goto case 3;
			case 10:
				return;
			case 0:
				Ns1kIqYJwR = ((FormatStringViewModel)IHtpf21E14C4db32aMA(ezFormatStringViewModel)).GetCurrentArgumentIndex();
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 8;
			case 8:
				ezFormatStringViewModel = qlkkXcn7VW();
				num = 0;
				break;
			case 5:
				wQVkfitIn5 = (JhHkE4WyMK ? (Ns1kIqYJwR - 1) : (Ns1kIqYJwR + 1));
				formatStringArgViewModel = ezFormatStringViewModel.Arguments[Ns1kIqYJwR];
				num = 4;
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__11))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!B7Cebe1ki33SXH5PaJc())
		{
		}
		_003CDo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = GPcF3r17EoL69ipZtUW();
				xmbRow1SwsrEGGNSeJG();
				if (!B7Cebe1ki33SXH5PaJc())
				{
					num = 0;
					if (!B7Cebe1ki33SXH5PaJc())
					{
						break;
					}
					goto case 3;
				}
				num = 5;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (!B7Cebe1ki33SXH5PaJc())
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__12))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (B7Cebe1ki33SXH5PaJc() ? 2 : 5);
		_003CRedo_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
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
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)hRTQrB134hZDkn8uxy0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__14))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (xmbRow1SwsrEGGNSeJG())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
			if (B7Cebe1ki33SXH5PaJc())
			{
				goto IL_00b7;
			}
		}
		goto IL_0056;
		IL_0056:
		_003CUndo_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 6:
				goto IL_00b7;
			}
			break;
		}
		goto IL_0026;
		IL_00b7:
		return stateMachine._003C_003Et__builder.Task;
		IL_0026:
		stateMachine._003C_003Et__builder = GPcF3r17EoL69ipZtUW();
		num = 5;
		goto IL_0056;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzFormatStringViewModel qlkkXcn7VW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		EzFormatStringViewModel result = default;
		while (true)
		{
			switch (num)
			{
			default:
				num = 7;
				continue;
			case 4:
				result = null;
				_ = 1;
				if (!B7Cebe1ki33SXH5PaJc())
				{
					num = 6;
					continue;
				}
				num = 0;
				if (!B7Cebe1ki33SXH5PaJc())
				{
					continue;
				}
				goto case 8;
			case 3:
				result = (EzFormatStringViewModel)Lb3qfS1CsOke8syAxx8(xJ686f16DD4clqHLeuJ(oWBkDMPRBk));
				num = 2;
				continue;
			case 1:
			case 6:
				if (!IJQFAP1jKWWOmXlo6Tm(Y0qk3XoHug, RfH9nF18xBhmtTa7MM2(typeof(WriteDataFtp).TypeHandle)))
				{
					if (!IJQFAP1jKWWOmXlo6Tm(Y0qk3XoHug, RfH9nF18xBhmtTa7MM2(typeof(WriteDataSerial).TypeHandle)))
					{
						if (IJQFAP1jKWWOmXlo6Tm(Y0qk3XoHug, typeof(WriteTcpIp)))
						{
							num = 8;
							if (true)
							{
								continue;
							}
						}
						break;
					}
				}
				else
				{
					num = 3;
					if (true)
					{
						continue;
					}
				}
				goto case 7;
			case 7:
				result = (EzFormatStringViewModel)Lb3qfS1CsOke8syAxx8(LF6rXl1Avem0sthnkGE(oWBkDMPRBk));
				break;
			case 8:
				result = (EzFormatStringViewModel)Lb3qfS1CsOke8syAxx8(hlpu381RUbx8vUboqCD(oWBkDMPRBk));
				num = 9;
				if (xmbRow1SwsrEGGNSeJG())
				{
					continue;
				}
				break;
			case 0:
			case 2:
			case 5:
			case 9:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JDMkotuPwq(EzFormatStringViewModel P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B7Cebe1ki33SXH5PaJc();
		int num;
		if (xmbRow1SwsrEGGNSeJG())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (!xmbRow1SwsrEGGNSeJG())
			{
				goto IL_0090;
			}
		}
		goto IL_00b3;
		IL_0046:
		P_0.Arguments.ForEach([MethodImpl(MethodImplOptions.NoInlining)] (FormatStringArgViewModel a) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			a.IsSelected = false;
		});
		if (P_1 >= 0)
		{
			goto IL_0090;
		}
		return;
		IL_0028:
		P_0.Arguments[P_1].IsSelected = true;
		num = 5;
		if (1 == 0)
		{
			goto IL_0046;
		}
		goto IL_00b3;
		IL_00b3:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 4:
				goto IL_0046;
			case 1:
			case 2:
				goto IL_0090;
			default:
				num = 3;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_0028;
		IL_0090:
		if (P_1 < YMZGju1WZuUxNT8gg00(P_0.Arguments))
		{
			goto IL_0028;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type RfH9nF18xBhmtTa7MM2(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GfHqV71qKNmkfdcjYN1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IHtpf21E14C4db32aMA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzFormatStringViewModel)P_0).FormatStringViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object na8xlR1pnMx4gAi4FEX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.pgrt2UNO9t();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UKYdKr1XenbB0HWEdUA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qjQWwF19dbMCDDW5q1I()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.WYutvXgTOI();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IcRqu914JICba7BtXgr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringArgViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xmbRow1SwsrEGGNSeJG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B7Cebe1ki33SXH5PaJc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GPcF3r17EoL69ipZtUW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hRTQrB134hZDkn8uxy0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IJQFAP1jKWWOmXlo6Tm(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xJ686f16DD4clqHLeuJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteDataFtp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Lb3qfS1CsOke8syAxx8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzFormatStringSupportSnippet)P_0).FormatString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LF6rXl1Avem0sthnkGE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteDataSerial;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hlpu381RUbx8vUboqCD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteTcpIp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YMZGju1WZuUxNT8gg00(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<FormatStringArgViewModel>)P_0).Count;
	}
}
