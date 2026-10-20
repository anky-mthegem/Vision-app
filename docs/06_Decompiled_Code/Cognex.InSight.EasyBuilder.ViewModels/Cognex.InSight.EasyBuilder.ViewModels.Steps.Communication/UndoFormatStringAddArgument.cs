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
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class UndoFormatStringAddArgument : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringAddArgument _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoFormatStringAddArgument undoFormatStringAddArgument = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					undoFormatStringAddArgument = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = X2rVjd5dLOIHuCqgalgc(((FormatStringViewModel)NnYXIS5fzAkpAawRiB8p(undoFormatStringAddArgument.zUvi9ys5TC())).AddArgsAsync((IList<FormatStringArgViewModel>)undoFormatStringAddArgument.kiMi1Q9mLs, -1));
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 7:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = (KtHOuK5fhkohBxHgTYNE() ? 8 : 5);
									continue;
								}
								break;
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
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
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (NjO6L25ftSrI9W4xVfyl())
					{
						num = 2;
						if (0 == 0)
						{
							break;
						}
						goto default;
					}
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
		internal static object NnYXIS5fzAkpAawRiB8p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).FormatStringViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter X2rVjd5dLOIHuCqgalgc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KtHOuK5fhkohBxHgTYNE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NjO6L25ftSrI9W4xVfyl()
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

		public UndoFormatStringAddArgument _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mmsWFE5d5K5RYkKADjVV();
			int num = ((!o5jL1v5dKvgjd3RlbnNb()) ? 4 : 5);
			int num2 = default;
			UndoFormatStringAddArgument undoFormatStringAddArgument = default;
			do
			{
				IL_0182:
				switch (num)
				{
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ixh0KP5dwALYZ03kpNes(undoFormatStringAddArgument.Do());
							_ = 0;
							if (o5jL1v5dKvgjd3RlbnNb())
							{
								num3 = 7;
								if (mmsWFE5d5K5RYkKADjVV())
								{
								}
							}
							else
							{
								num3 = 5;
								if (1 == 0)
								{
									goto IL_00b4;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (!o5jL1v5dKvgjd3RlbnNb())
							{
								goto IL_0096;
							}
						}
						goto IL_00d4;
						IL_00b4:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_0142:
						awaiter.GetResult();
						goto end_IL_0028;
						IL_0096:
						if (!awaiter.IsCompleted)
						{
							goto IL_011c;
						}
						goto IL_0142;
						IL_011c:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						goto IL_00d4;
						IL_00d4:
						while (true)
						{
							switch (num3)
							{
							case 6:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (mmsWFE5d5K5RYkKADjVV())
								{
								}
								continue;
							case 4:
								return;
							case 0:
							case 7:
								break;
							case 3:
								goto IL_00b4;
							default:
								num3 = 4;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 1:
							case 5:
								goto IL_011c;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								goto IL_0142;
							}
							break;
						}
						goto IL_0096;
						end_IL_0028:;
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
					goto IL_0182;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_0182;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				undoFormatStringAddArgument = _003C_003E4__this;
				num = 3;
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
		internal static TaskAwaiter ixh0KP5dwALYZ03kpNes(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o5jL1v5dKvgjd3RlbnNb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mmsWFE5d5K5RYkKADjVV()
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
			cCCki55debVMGoOcD3tG();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cCCki55debVMGoOcD3tG();
			pCLYrd5dOfCrs4oSlfVV(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CGetArgument_003Eb__15_0(FormatStringArgViewModel a)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kxHpyj5dIm9Dmq0IIA6V(a, false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cCCki55debVMGoOcD3tG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bxpmrq5dJMSSoSlQUSkm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UGaMNE5da5lH7bT9xPA6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pCLYrd5dOfCrs4oSlfVV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kxHpyj5dIm9Dmq0IIA6V(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatStringArgViewModel)P_0).IsSelected = P_1;
		}
	}

	private CommStepViewModel Xvai8nkJaR;

	private Type D5XimqyQMf;

	private FormatStringArgViewModel[] kiMi1Q9mLs;

	private string afdiz9O3YR;

	private Type[] qy1kanK92A;

	[CompilerGenerated]
	private string Cenk55TPdJ;

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
			return Cenk55TPdJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Cenk55TPdJ = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoFormatStringAddArgument(CommStepViewModel commAppStep, Type type, FormatStringArgViewModel[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		FormatStringArgViewModel formatStringArgViewModel = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (kiMi1Q9mLs.Length == 1)
				{
					formatStringArgViewModel = kiMi1Q9mLs[0];
					num = 1;
				}
				else
				{
					Text = (string)rQKddfcQK9Apk1HsmkH(Resources.WJutHcB4qn(), jgkElmcNEjdPbv9P0bu(29822));
					num = 12;
				}
				continue;
			case 7:
				return;
			default:
				kiMi1Q9mLs = args;
				num = 3;
				continue;
			case 1:
				Text = (string)rQKddfcQK9Apk1HsmkH(z5mxUMcxtvrPCohIKqw(), dmLwFAcmsEnPdhZPo2D(formatStringArgViewModel));
				num = 7;
				continue;
			case 2:
				if (!qy1kanK92A.Contains(type))
				{
					num = 9;
					continue;
				}
				Xvai8nkJaR = commAppStep;
				jsscoOcYt2b5jZ0ngu4();
				if (JpEduOcUEA8eGwygCNF())
				{
					num = 8;
					continue;
				}
				num = 4;
				if (jsscoOcYt2b5jZ0ngu4())
				{
					continue;
				}
				break;
			case 0:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 10;
				if (jsscoOcYt2b5jZ0ngu4())
				{
					continue;
				}
				goto case 4;
			case 4:
			case 5:
				D5XimqyQMf = type;
				goto default;
			case 11:
				base._002Ector();
				num = 2;
				continue;
			case 9:
				throw new NotSupportedException(type.ToString());
			case 10:
				break;
			case 12:
				return;
			}
			qy1kanK92A = new Type[3]
			{
				JStDcFcHTeTyAs5Jvt2(typeof(WriteDataFtp).TypeHandle),
				JStDcFcHTeTyAs5Jvt2(typeof(WriteDataSerial).TypeHandle),
				JStDcFcHTeTyAs5Jvt2(typeof(WriteTcpIp).TypeHandle)
			};
			num = 11;
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
		jsscoOcYt2b5jZ0ngu4();
		int num = (JpEduOcUEA8eGwygCNF() ? 5 : 2);
		_003CDo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = sXusPPc2axFvFEJR8Jh();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
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
		int num = 5;
		_003CRedo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = sXusPPc2axFvFEJR8Jh();
				_ = 1;
				if (!JpEduOcUEA8eGwygCNF())
				{
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto default;
				}
				num = 2;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 0;
				if (JpEduOcUEA8eGwygCNF())
				{
				}
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
		EzFormatStringViewModel ezFormatStringViewModel = zUvi9ys5TC();
		afdiz9O3YR = (string)p6N4QIccn3G1WG0JdLi(ezFormatStringViewModel);
		return (Task)VTtBLlc1bO8ggPHxcKv();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		zUvi9ys5TC().Refresh(afdiz9O3YR);
		return (Task)VTtBLlc1bO8ggPHxcKv();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzFormatStringViewModel zUvi9ys5TC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		EzFormatStringViewModel result = default;
		if (true)
		{
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					if (!JpEduOcUEA8eGwygCNF())
					{
						continue;
					}
					goto case 8;
				case 8:
					result = null;
					num = 7;
					continue;
				case 1:
					result = (EzFormatStringViewModel)FfvQPSctj2GVBy2YVoT(AXZAE8chARJoQEDnrTR(Xvai8nkJaR));
					num = 0;
					continue;
				case 7:
					if (!dkURBPcunhuuAYsFV23(D5XimqyQMf, JStDcFcHTeTyAs5Jvt2(typeof(WriteDataFtp).TypeHandle)))
					{
						if (!dkURBPcunhuuAYsFV23(D5XimqyQMf, JStDcFcHTeTyAs5Jvt2(typeof(WriteDataSerial).TypeHandle)))
						{
							if (!dkURBPcunhuuAYsFV23(D5XimqyQMf, JStDcFcHTeTyAs5Jvt2(typeof(WriteTcpIp).TypeHandle)))
							{
								break;
							}
							goto case 4;
						}
					}
					else
					{
						num = 1;
						if (jsscoOcYt2b5jZ0ngu4())
						{
							continue;
						}
					}
					goto case 2;
				case 2:
					result = (EzFormatStringViewModel)FfvQPSctj2GVBy2YVoT(mYiQisczGNrQEyOjVaG(Xvai8nkJaR));
					jsscoOcYt2b5jZ0ngu4();
					if (!JpEduOcUEA8eGwygCNF())
					{
						num = 3;
						continue;
					}
					num = 4;
					if (JpEduOcUEA8eGwygCNF())
					{
					}
					continue;
				case 4:
				case 6:
					result = ((EzFormatStringSupportSnippet)mNotIu1LZNlny5HFnw7(Xvai8nkJaR)).FormatString;
					num = 9;
					continue;
				case 0:
				case 3:
				case 5:
				case 9:
					break;
				}
				break;
			}
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FormatStringArgViewModel R4qir1NOQC(EzFormatStringViewModel P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JpEduOcUEA8eGwygCNF();
		int num = ((!jsscoOcYt2b5jZ0ngu4()) ? 4 : 2);
		FormatStringArgViewModel result = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				result = null;
				goto case 1;
			case 5:
				result = P_0.Arguments[P_1];
				num = 6;
				continue;
			case 3:
				if (P_1 >= l2jjOy1KDqLI2kqc0Lx(P_0.Arguments))
				{
					break;
				}
				goto case 5;
			default:
				num = 5;
				continue;
			case 1:
			case 4:
				P_0.Arguments.ForEach([MethodImpl(MethodImplOptions.NoInlining)] (FormatStringArgViewModel a) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					_003C_003Ec.kxHpyj5dIm9Dmq0IIA6V(a, false);
				});
				if (P_1 >= 0)
				{
					num = 3;
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type JStDcFcHTeTyAs5Jvt2(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z5mxUMcxtvrPCohIKqw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.WJutHcB4qn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dmLwFAcmsEnPdhZPo2D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringArgViewModel)P_0).LocalizedCellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rQKddfcQK9Apk1HsmkH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jgkElmcNEjdPbv9P0bu(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jsscoOcYt2b5jZ0ngu4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JpEduOcUEA8eGwygCNF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder sXusPPc2axFvFEJR8Jh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p6N4QIccn3G1WG0JdLi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzFormatStringViewModel)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VTtBLlc1bO8ggPHxcKv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dkURBPcunhuuAYsFV23(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AXZAE8chARJoQEDnrTR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteDataFtp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FfvQPSctj2GVBy2YVoT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzFormatStringSupportSnippet)P_0).FormatString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mYiQisczGNrQEyOjVaG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteDataSerial;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mNotIu1LZNlny5HFnw7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteTcpIp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int l2jjOy1KDqLI2kqc0Lx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<FormatStringArgViewModel>)P_0).Count;
	}
}
