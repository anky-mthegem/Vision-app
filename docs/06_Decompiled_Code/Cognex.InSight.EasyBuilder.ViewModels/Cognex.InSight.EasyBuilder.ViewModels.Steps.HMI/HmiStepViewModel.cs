using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Controls;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Runtime.ViewModels.EasyView;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.HMI;

[Shared]
[Export(typeof(AppStepViewModel))]
public class HmiStepViewModel : AppStepViewModel, IInSightAppStep, ISnippetConsumer, IToolPropertyCollection
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public HmiStepViewModel _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			HmiStepViewModel hmiStepViewModel = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
			IRuntimeModeService runtimeModeService = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						object obj3;
						if (num2 != 0)
						{
							object obj = F2UuC35JYLADfvjlmYx9(hmiStepViewModel);
							if (obj == null)
							{
								num3 = 8;
								if (1 == 0)
								{
									goto IL_004c;
								}
							}
							else
							{
								object obj2 = ETI1wH5JUKPn8XB84FcC(obj);
								if (obj2 != null)
								{
									obj3 = ((RuntimeViewModel)obj2).RuntimeModeService;
									goto IL_00bc;
								}
								num3 = 9;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 2;
						}
						goto IL_0188;
						IL_00b1:
						obj3 = null;
						goto IL_00bc;
						IL_012e:
						obj3 = null;
						goto IL_00bc;
						IL_0162:
						awaiter = valueTask.GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							goto IL_00ec;
						}
						goto IL_01e6;
						IL_008f:
						valueTask = hmiStepViewModel.MqfekliSsa();
						goto IL_0162;
						IL_00cf:
						num2 = (_003C_003E1__state = -1);
						num3 = 13;
						if (qV2w5q5JMyLlt1GoaQve())
						{
						}
						goto IL_0188;
						IL_00bc:
						runtimeModeService = (IRuntimeModeService)obj3;
						if (runtimeModeService == null)
						{
							goto IL_004c;
						}
						num3 = 4;
						if (1 == 0)
						{
							goto IL_00cf;
						}
						goto IL_0188;
						IL_004c:
						CheckBoxTreeViewModel checkBoxTreeViewModel = hmiStepViewModel.CheckBoxTreeViewModel;
						if (checkBoxTreeViewModel == null)
						{
							num3 = 10;
							goto IL_0188;
						}
						ESeuJT5JH4XesnB2SnRD(checkBoxTreeViewModel);
						goto IL_008f;
						IL_00ec:
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						if (false)
						{
							goto IL_0101;
						}
						goto IL_0188;
						IL_0101:
						runtimeModeService.RuntimeModeChanged -= hmiStepViewModel.RuntimeModeService_RuntimeModeChanged;
						F7RYpX5JFGktW8M3EsEN();
						if (qV2w5q5JMyLlt1GoaQve())
						{
							num3 = 0;
							if (qV2w5q5JMyLlt1GoaQve())
							{
							}
						}
						else
						{
							num3 = 1;
						}
						goto IL_0188;
						IL_0188:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 3:
								break;
							case 7:
								return;
							case 10:
								goto IL_008f;
							case 9:
								goto IL_00b1;
							case 2:
								goto IL_00cf;
							case 12:
								goto IL_00ec;
							case 4:
								goto IL_0101;
							case 8:
								goto IL_012e;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 0:
							case 5:
								goto IL_0162;
							default:
								num3 = 12;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								if (F7RYpX5JFGktW8M3EsEN())
								{
									continue;
								}
								goto IL_01e6;
							case 13:
								goto IL_01e6;
							}
							break;
						}
						goto IL_004c;
						IL_01e6:
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
				case 2:
					num2 = _003C_003E1__state;
					qV2w5q5JMyLlt1GoaQve();
					num = ((!F7RYpX5JFGktW8M3EsEN()) ? 5 : 0);
					break;
				case 0:
				case 1:
					hmiStepViewModel = _003C_003E4__this;
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
		internal static object F2UuC35JYLADfvjlmYx9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ETI1wH5JUKPn8XB84FcC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).Runtime;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ESeuJT5JH4XesnB2SnRD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CheckBoxTreeViewModel)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F7RYpX5JFGktW8M3EsEN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qV2w5q5JMyLlt1GoaQve()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public HmiStepViewModel _003C_003E4__this;

		public EasyViewViewModel easyViewViewModel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass29_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Kbna2Q5JQs9vGCB0vxDi();
			Lvox5e5JNIhqGE3AgUXS(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CUpdateCheckBoxTreeNodes_003Eb__0(EzSnippet tool)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (jqc58W5JmSo25J3pKElM())
			{
				goto IL_001e;
			}
			goto IL_00a6;
			IL_001e:
			zqSHAW5J1aecjxl6haM4(Log, crxa5n5JcDSN99522O6V(lFJZKe5J2v8iTW5tLAUg(51558), tool.Name, lFJZKe5J2v8iTW5tLAUg(29060)));
			jqc58W5JmSo25J3pKElM();
			num = ((!U20thL5JxwlYW4UDQIWI()) ? 4 : 3);
			goto IL_00a6;
			IL_00a6:
			while (true)
			{
				CheckBoxTreeViewModel checkBoxTreeViewModel;
				switch (num)
				{
				case 0:
					break;
				default:
					return;
				case 4:
					return;
				case 1:
				case 3:
					checkBoxTreeViewModel = _003C_003E4__this.CheckBoxTreeViewModel;
					if (checkBoxTreeViewModel != null)
					{
						goto IL_0062;
					}
					return;
				case 5:
					return;
				}
				break;
				IL_0062:
				checkBoxTreeViewModel.AddNode(new EasyViewToolViewModel((EzTool)tool, easyViewViewModel));
				num = 5;
			}
			goto IL_001e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Kbna2Q5JQs9vGCB0vxDi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Lvox5e5JNIhqGE3AgUXS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U20thL5JxwlYW4UDQIWI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jqc58W5JmSo25J3pKElM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lFJZKe5J2v8iTW5tLAUg(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object crxa5n5JcDSN99522O6V(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zqSHAW5J1aecjxl6haM4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Debug((string)P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_1
	{
		public JobPassFail passFail;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass29_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uUbTpk5JtaFnMe3Df4BA();
			H7SYy25Jz4E7Zcl6Imkd(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateCheckBoxTreeNodes_003Eb__1(CheckBoxTreeItemViewModel it)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)((it != null) ? JeEpHW5aLxtS5WkJ6wgy(it) : null) == (string)fdDOBy5aKXm0YTvDU9cG(passFail);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uUbTpk5JtaFnMe3Df4BA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void H7SYy25Jz4E7Zcl6Imkd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vP1j195JucMcUyHsOreg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SHZEdm5Jh6qJnowu4ajS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JeEpHW5aLxtS5WkJ6wgy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CheckBoxTreeItemViewModel)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fdDOBy5aKXm0YTvDU9cG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCompleteInitializationAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HmiStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KVN2GQ5awWOKbR9NRTVu();
			int num;
			if (yficla5a59EQI5vmAxqV())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (KVN2GQ5awWOKbR9NRTVu())
				{
				}
			}
			HmiStepViewModel hmiStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					hmiStepViewModel = _003C_003E4__this;
					num = 5;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							goto IL_0116;
						}
						int num3;
						if (hmiStepViewModel.EasyView != null)
						{
							num3 = 0;
							if (KVN2GQ5awWOKbR9NRTVu())
							{
								goto IL_0090;
							}
							goto IL_0158;
						}
						goto end_IL_006f;
						IL_0158:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 8:
								break;
							case 9:
								goto IL_00a8;
							case 5:
								return;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 0:
								goto IL_00ef;
							case 2:
							case 6:
								goto IL_0116;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto IL_00a8;
							default:
								num3 = 9;
								if (!KVN2GQ5awWOKbR9NRTVu())
								{
									continue;
								}
								goto IL_0199;
							case 10:
								goto IL_0199;
							}
							break;
							IL_00ef:
							awaiter = n0WrXw5aaFmeDBurYFAm(PLWsPr5aJKOrern2cTDN(hmiStepViewModel.EasyView));
							_ = 1;
							num3 = ((!KVN2GQ5awWOKbR9NRTVu()) ? 8 : 2);
						}
						goto IL_0090;
						IL_00a8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 5;
						goto IL_0158;
						IL_0116:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_0158;
						IL_0090:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							if (false)
							{
								goto IL_00a8;
							}
							goto IL_0158;
						}
						goto IL_0199;
						IL_0199:
						awaiter.GetResult();
						end_IL_006f:;
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
		internal static object PLWsPr5aJKOrern2cTDN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyViewViewModel)P_0).LoadEasyView();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter n0WrXw5aaFmeDBurYFAm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yficla5a59EQI5vmAxqV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KVN2GQ5awWOKbR9NRTVu()
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
	private struct _003COnEnterStep_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HmiStepViewModel _003C_003E4__this;

		public StepBase previousStep;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!pnkpnb5ae0mxp8wxfBIv()) ? 5 : 3);
			int num2 = default;
			HmiStepViewModel hmiStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					hmiStepViewModel = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = JZ0PW95aI0QFa1aB5mt6(hmiStepViewModel.k8MePLJDQT(previousStep));
							num3 = 7;
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
							default:
								return;
							case 2:
								return;
							case 0:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter.IsCompleted)
								{
									pnkpnb5ae0mxp8wxfBIv();
									if (!S60ITM5aOS0Y8NRRDDif())
									{
										num3 = 3;
										continue;
									}
									num3 = 2;
									if (S60ITM5aOS0Y8NRRDDif())
									{
									}
									continue;
								}
								goto case 0;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								if (pnkpnb5ae0mxp8wxfBIv())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								if (pnkpnb5ae0mxp8wxfBIv())
								{
									continue;
								}
								break;
							case 10:
								break;
							}
							break;
						}
						hmiStepViewModel.tnTeiQLJ13();
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
		internal static TaskAwaiter JZ0PW95aI0QFa1aB5mt6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pnkpnb5ae0mxp8wxfBIv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S60ITM5aOS0Y8NRRDDif()
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HmiStepViewModel _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			HmiStepViewModel hmiStepViewModel = default;
			CvsCell cvsCell = default;
			CvsCellRange cvsCellRange = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01b6;
						}
						List<EasyViewItem> list = new List<EasyViewItem>();
						IEnumerator<EasyViewItem> enumerator = hmiStepViewModel.Settings.Items.GetEnumerator();
						try
						{
							while (MEk8PH5al3xBltN0fhyj(enumerator))
							{
								EasyViewItem current = enumerator.Current;
								int num3 = 2;
								if (1 == 0)
								{
									goto IL_004e;
								}
								goto IL_00a7;
								IL_004e:
								list.Add(current);
								num3 = 7;
								goto IL_00a7;
								IL_00a7:
								while (true)
								{
									switch (num3)
									{
									case 0:
									case 4:
										break;
									case 2:
										cvsCell = (CvsCell)tvImbt5aVcTcV7fb4rJu(lXRy4R5ancsRCyvCOQsj(e), current.CellName);
										num3 = 6;
										continue;
									case 5:
										cvsCellRange = zx3bkO5adnCsEDuOUKFD(Pjko4x5afbQkcIcfd9Cf(e));
										goto default;
									default:
										o0a2En5aiA1xPKkCXAcH();
										if (jijSim5aD7FuYp43s1Y9())
										{
											num3 = 1;
											continue;
										}
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 6;
									case 1:
									case 3:
										if (!cvsCellRange.Contains(cvsCell.Location))
										{
											goto IL_011c;
										}
										break;
									case 6:
										if (cvsCell != null)
										{
											num3 = 5;
											continue;
										}
										goto IL_011c;
									case 7:
										goto IL_011c;
									}
									break;
								}
								goto IL_004e;
								IL_011c:;
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								l2ilH95ag2HMfnccXoPu(enumerator);
							}
						}
						if (L9jJtg5as9buQ5KejvCK(list) > 0)
						{
							RemoveReferencesHmiUndoAction removeReferencesHmiUndoAction = new RemoveReferencesHmiUndoAction(hmiStepViewModel, list);
							awaiter = gMVOar5ar6H5EctQV24p(I7594N5avTUV063i3gtA(e, removeReferencesHmiUndoAction));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01b6;
						}
						goto end_IL_0018;
						IL_01b6:
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
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (o0a2En5aiA1xPKkCXAcH())
					{
					}
					break;
				case 5:
					hmiStepViewModel = _003C_003E4__this;
					_ = 0;
					if (!jijSim5aD7FuYp43s1Y9())
					{
						num = 1;
						if (0 == 0)
						{
							break;
						}
						goto case 4;
					}
					num = 0;
					if (o0a2En5aiA1xPKkCXAcH())
					{
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
		internal static object lXRy4R5ancsRCyvCOQsj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tvImbt5aVcTcV7fb4rJu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).FindCellByName((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Pjko4x5afbQkcIcfd9Cf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Snippet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange zx3bkO5adnCsEDuOUKFD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MEk8PH5al3xBltN0fhyj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void l2ilH95ag2HMfnccXoPu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int L9jJtg5as9buQ5KejvCK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<EasyViewItem>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object I7594N5avTUV063i3gtA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter gMVOar5ar6H5EctQV24p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jijSim5aD7FuYp43s1Y9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o0a2En5aiA1xPKkCXAcH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public EasyViewItem item;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass35_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g8Tis65aBUM6wU1hoyi2();
			cgPFAE5abaC6Kyys5i0b(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetConsumer_002ERenameReferences_003Eb__0(string k)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oQ0xp95aouXSWPl1RW8b(k, bNyJ4Q5aGyw1VU5glq6e(item));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void g8Tis65aBUM6wU1hoyi2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cgPFAE5abaC6Kyys5i0b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i9OT7G5aPePQO2hTKNEj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool efBbo65aZrTYdP92BrP1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bNyJ4Q5aGyw1VU5glq6e(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyViewItem)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oQ0xp95aouXSWPl1RW8b(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRenameReferences_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HmiStepViewModel _003C_003E4__this;

		public SnippetRenamedEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			HmiStepViewModel hmiStepViewModel = default;
			string text = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					hmiStepViewModel = _003C_003E4__this;
					gFg1id5akSuF3RvPhT7D();
					if (VGVdu95aSxyTw7LuO3Fm())
					{
						num = 5;
						continue;
					}
					num = 4;
					if (VGVdu95aSxyTw7LuO3Fm())
					{
						continue;
					}
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0266;
						}
						bool flag = false;
						if (hmiStepViewModel.EasyView != null && hmiStepViewModel.Settings != null)
						{
							IEnumerator<EasyViewItem> enumerator = hmiStepViewModel.Settings.Items.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass35_0();
									_ = 0;
									int num3;
									if (VGVdu95aSxyTw7LuO3Fm())
									{
										num3 = 3;
									}
									else
									{
										num3 = 2;
										if (gFg1id5akSuF3RvPhT7D())
										{
										}
									}
									while (true)
									{
										switch (num3)
										{
										case 1:
											if (!kNogqW5apc1dXOZ0AHBX(dHTmhu5aE1FW0UCY9NTO(CS_0024_003C_003E8__locals7.item), text))
											{
												goto case 8;
											}
											goto case 2;
										case 8:
											flag = true;
											num3 = 10;
											continue;
										case 0:
										case 3:
											CS_0024_003C_003E8__locals7.item = enumerator.Current;
											num3 = 7;
											continue;
										case 5:
											text = e.Names.Keys.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (string k) =>
											{
												while (false)
												{
													_ = ((object[])null)[0];
												}
												return _003C_003Ec__DisplayClass35_0.oQ0xp95aouXSWPl1RW8b(k, _003C_003Ec__DisplayClass35_0.bNyJ4Q5aGyw1VU5glq6e(CS_0024_003C_003E8__locals7.item));
											});
											num3 = 9;
											continue;
										case 4:
											SOm1lL5aqMZvROj9K09b(CS_0024_003C_003E8__locals7.item, e.Names[text]);
											num3 = 1;
											if (0 == 0)
											{
												continue;
											}
											goto case 7;
										case 7:
											if (ghAV3p5a8CCoK7sp6mXO(CS_0024_003C_003E8__locals7.item) != null)
											{
												num3 = 5;
												continue;
											}
											break;
										case 9:
											if (text == null)
											{
												break;
											}
											goto case 4;
										default:
											num3 = 4;
											continue;
										case 2:
										case 6:
											CS_0024_003C_003E8__locals7.item.Caption = (string)ghAV3p5a8CCoK7sp6mXO(CS_0024_003C_003E8__locals7.item);
											num3 = 8;
											continue;
										case 10:
											break;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									sEJ0tA5aXbpO1XOmj7CZ(enumerator);
								}
							}
							if (flag)
							{
								awaiter = ERqND85a4oKsbk1B5x4r(lxRldZ5a96eLmfM8xkBU(hmiStepViewModel.EasyView));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0266;
							}
						}
						goto end_IL_004e;
						IL_0266:
						awaiter.GetResult();
						end_IL_004e:;
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
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 1;
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
		internal static object ghAV3p5a8CCoK7sp6mXO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyViewItem)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SOm1lL5aqMZvROj9K09b(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EasyViewItem)P_0).CellName = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dHTmhu5aE1FW0UCY9NTO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyViewItem)P_0).Caption;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kNogqW5apc1dXOZ0AHBX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sEJ0tA5aXbpO1XOmj7CZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lxRldZ5a96eLmfM8xkBU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyViewViewModel)P_0).SaveEasyView();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ERqND85a4oKsbk1B5x4r(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VGVdu95aSxyTw7LuO3Fm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gFg1id5akSuF3RvPhT7D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected static readonly ILogger Log;

	private string kuiesT3vOw;

	private readonly string cw2eKiQ5oU;

	[CompilerGenerated]
	private readonly CheckBoxTreeViewModel CbOeG18XWj;

	private int tUKeBqqCY9;

	public CheckBoxTreeViewModel CheckBoxTreeViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CbOeG18XWj;
		}
	}

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Steps_HmiIcon;
		}
	}

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)iKEjQdQB8oaEZlCw9tS();
		}
	}

	public override string Category
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)vpV6mQQbQMJdU5cltKg();
		}
	}

	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.r43YasjviR();
		}
	}

	public override string HelpTopic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AppStepHelpTopics.Hmi;
		}
	}

	public override int Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tUKeBqqCY9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref tUKeBqqCY9, value, (string)UVSOidQPjlSRk9xbLZX(3256));
		}
	}

	public Uri Uri
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new Uri(kuiesT3vOw);
		}
	}

	public EasyViewViewModel EasyView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EasyBuilderApplicationViewModel appViewModel = AppViewModel;
			if (appViewModel == null)
			{
				return null;
			}
			return (EasyViewViewModel)e2uCvnQGobgKsfWVqkp(appViewModel);
		}
	}

	public EasyViewSettings Settings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EasyViewViewModel easyView = EasyView;
			if (easyView == null)
			{
				return null;
			}
			return (EasyViewSettings)mZ6bsSQo4yMTQxw1PG7(easyView);
		}
	}

	public string AddMenuText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)Wck1HXQWJCIu4HdrmgX();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HmiStepViewModel()
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
			case 0:
				CbOeG18XWj = new CheckBoxTreeViewModel();
				goto case 5;
			case 6:
				tUKeBqqCY9 = 700;
				DZ8mN2Qv8GUl18l7AuV();
				num = (G7EibwQsErYZWtIrkg9() ? 2 : 7);
				break;
			case 5:
			case 7:
				ShowInSightDisplay = false;
				num = 8;
				break;
			case 2:
			case 3:
				base._002Ector();
				goto case 0;
			default:
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				uIGviYQrrbaiqW3aNkr();
				num = 1;
				break;
			case 1:
				cw2eKiQ5oU = (string)UVSOidQPjlSRk9xbLZX(28902);
				num = 6;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__4))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!G7EibwQsErYZWtIrkg9()) ? 3 : 4);
		_003CDisposeAsync_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = DvbOA9QZ328rgcw8YBZ();
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
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
	protected override void RuntimeModeService_RuntimeModeChanged(object sender, RuntimeModeChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (CheckBoxTreeViewModel != null)
		{
			CheckBoxTreeViewModel.AreCheckboxesEnabled = !c26qZFQSigvynlLLOP5(e) && !e.IsOperatorOnline;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tnTeiQLJ13()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00c0;
		IL_001a:
		_003C_003Ec__DisplayClass29_0 obj = new _003C_003Ec__DisplayClass29_0();
		num = 16;
		goto IL_00c0;
		IL_00c0:
		_003C_003Ec__DisplayClass29_1 obj3 = default;
		while (true)
		{
			object obj4;
			object obj2;
			switch (num)
			{
			case 13:
				break;
			case 0:
				obj4 = null;
				goto IL_0035;
			case 5:
			case 6:
			{
				EasyBuilderApplicationViewModel appViewModel = AppViewModel;
				if (appViewModel == null)
				{
					num = 14;
					continue;
				}
				appViewModel.Inspect?.Snippets?.ForEach(obj._003CUpdateCheckBoxTreeNodes_003Eb__0);
				goto case 7;
			}
			case 15:
				obj3 = new _003C_003Ec__DisplayClass29_1();
				G7EibwQsErYZWtIrkg9();
				num = (DZ8mN2Qv8GUl18l7AuV() ? 11 : 5);
				continue;
			default:
				num = 7;
				continue;
			case 4:
			case 12:
				obj.easyViewViewModel = EasyView;
				num = 8;
				continue;
			case 3:
			{
				CheckBoxTreeViewModel checkBoxTreeViewModel = CheckBoxTreeViewModel;
				if (checkBoxTreeViewModel == null)
				{
					num = 1;
					if (DZ8mN2Qv8GUl18l7AuV())
					{
					}
					continue;
				}
				checkBoxTreeViewModel.AddNode(new EasyViewPassFailViewModel(obj3.passFail, obj.easyViewViewModel));
				num = 17;
				if (true)
				{
					continue;
				}
				goto case 16;
			}
			case 8:
				if (obj.easyViewViewModel != null)
				{
					num = 15;
					continue;
				}
				return;
			case 2:
				AMlHjtQEp09quJ693yj(Log, (string)UVSOidQPjlSRk9xbLZX(28996) + (string)tKR3hoQqnptX4xrxovs(obj3.passFail) + (string)UVSOidQPjlSRk9xbLZX(29060));
				num = 3;
				if (!DZ8mN2Qv8GUl18l7AuV())
				{
					continue;
				}
				goto case 4;
			case 10:
			case 11:
			{
				CheckBoxTreeViewModel checkBoxTreeViewModel3 = CheckBoxTreeViewModel;
				if (checkBoxTreeViewModel3 != null)
				{
					obj4 = checkBoxTreeViewModel3.TreeNodes;
					goto IL_0035;
				}
				num = 0;
				continue;
			}
			case 9:
				obj2 = null;
				goto IL_01ee;
			case 7:
			case 14:
			{
				obj3.passFail = ((EasyBuilderApplicationViewModel)X7nvj4Q8yeq935ZLn2h(this))?.Inspect?.JobPassFail;
				JobPassFail jobPassFail = obj3.passFail;
				if (jobPassFail != null)
				{
					obj2 = jobPassFail.AllProperties;
					goto IL_01ee;
				}
				num = 9;
				continue;
			}
			case 1:
				return;
			case 16:
			{
				obj._003C_003E4__this = this;
				CheckBoxTreeViewModel checkBoxTreeViewModel2 = CheckBoxTreeViewModel;
				if (checkBoxTreeViewModel2 != null)
				{
					ObservableCollection<CheckBoxTreeItemViewModel> treeNodes = checkBoxTreeViewModel2.TreeNodes;
					if (treeNodes != null)
					{
						T2yLGoQkF1YV2l9XVmL(treeNodes);
						goto case 4;
					}
					num = 4;
					if (G7EibwQsErYZWtIrkg9())
					{
						continue;
					}
					goto case 10;
				}
				num = 12;
				continue;
			}
			case 17:
				return;
				IL_0035:
				if (obj4 != null && CheckBoxTreeViewModel.TreeNodes.IndexOf(obj3._003CUpdateCheckBoxTreeNodes_003Eb__1) < 0)
				{
					num = 2;
					continue;
				}
				return;
				IL_01ee:
				if (obj2 != null && obj3.passFail.AllProperties.Any())
				{
					goto case 10;
				}
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		int num2 = default;
		string text = default;
		IRuntimeModeService runtimeModeService = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			{
				object obj = wKNVDcQXMVGqydJBDXe(tZ6LZhQp3PDxUWembKC(this));
				num2 = BJ0tEgQ906qYpOxFlQZ(tZ6LZhQp3PDxUWembKC(this));
				text = (string)X0wKE8Q4mjeDEfmSXTA(((CvsCogSocket)obj).HttpUrl, UriComponents.UserInfo | UriComponents.Host, UriFormat.Unescaped);
				_ = 0;
				num = ((!G7EibwQsErYZWtIrkg9()) ? 3 : 0);
				break;
			}
			case 5:
				PggCGBQ3O98il8bS6na(CheckBoxTreeViewModel, runtimeModeService.IsOperatorOfflineAndNotInLiveMode);
				num = 7;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 3:
				runtimeModeService = ((BaseIdeViewModel)X7nvj4Q8yeq935ZLn2h(this)).Runtime.RuntimeModeService;
				goto case 6;
			default:
				num = 6;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				runtimeModeService.RuntimeModeChanged += RuntimeModeService_RuntimeModeChanged;
				num = 5;
				if (DZ8mN2Qv8GUl18l7AuV())
				{
				}
				break;
			case 0:
			case 1:
				kuiesT3vOw = (string)qx8LMnQ7nTYEHqApqcD(UVSOidQPjlSRk9xbLZX(29068), text, num2, cw2eKiQ5oU);
				goto case 2;
			case 7:
				return (Task)TBs8vEQjVc1FbgbYtWY();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCompleteInitializationAsync_003Ed__31))]
	public override Task CompleteInitializationAsync(ISnippetManager snippetManager)
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
		goto IL_004e;
		IL_00af:
		_003CCompleteInitializationAsync_003Ed__31 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (0 == 0)
		{
			goto IL_004e;
		}
		goto IL_00c9;
		IL_00c9:
		return stateMachine._003C_003Et__builder.Task;
		IL_004e:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 2:
			case 4:
				goto IL_0034;
			default:
				num = 3;
				if (DZ8mN2Qv8GUl18l7AuV())
				{
				}
				continue;
			case 0:
				goto IL_0083;
			case 3:
				goto IL_00af;
			case 6:
				goto IL_00c9;
			}
			break;
			IL_0083:
			stateMachine._003C_003Et__builder = WDOHOeQ6Uka3yw8CEYy();
			G7EibwQsErYZWtIrkg9();
			if (DZ8mN2Qv8GUl18l7AuV())
			{
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0034;
			}
			num = 5;
			if (!DZ8mN2Qv8GUl18l7AuV())
			{
				continue;
			}
			goto IL_00af;
		}
		goto IL_001a;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_0034;
		IL_0034:
		stateMachine._003C_003E1__state = -1;
		goto IL_00af;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnEnterStep_003Ed__32))]
	protected override Task OnEnterStep(StepBase previousStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!G7EibwQsErYZWtIrkg9()) ? 3 : 4);
		_003COnEnterStep_003Ed__32 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = WDOHOeQ6Uka3yw8CEYy();
				num = 6;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 2:
			case 3:
				stateMachine.previousStep = previousStep;
				goto case 5;
			default:
				num = 5;
				if (G7EibwQsErYZWtIrkg9())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				if (G7EibwQsErYZWtIrkg9())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ISnippetConsumer.AddDefaultReferences(SnippetAddedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		EzTool ezTool = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				if (RhWenpQCKJMtAkKmTxf(e) != SnippetAddedEventType.Created)
				{
					break;
				}
				_ = 1;
				if (!DZ8mN2Qv8GUl18l7AuV())
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				}
				num = 3;
				continue;
			case 5:
				if (ezTool == null)
				{
					break;
				}
				num = 6;
				if (G7EibwQsErYZWtIrkg9())
				{
					continue;
				}
				goto case 6;
			case 6:
			{
				EasyViewViewModel easyView = EasyView;
				if (easyView == null)
				{
					break;
				}
				object obj = mZ6bsSQo4yMTQxw1PG7(easyView);
				if (obj == null)
				{
					num = 2;
					continue;
				}
				lSoXXAQRgO5XhTiBfBm(obj, ezTool.ResultCell);
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 7;
			}
			case 0:
			case 1:
				ezTool = qtPn1UQAM9vk3DLQ8OL(e) as EzTool;
				num = 5;
				continue;
			}
			break;
		}
		return (Task)TBs8vEQjVc1FbgbYtWY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__34))]
	Task ISnippetConsumer.RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DZ8mN2Qv8GUl18l7AuV();
		int num;
		if (G7EibwQsErYZWtIrkg9())
		{
			num = 2;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (!G7EibwQsErYZWtIrkg9())
			{
				goto IL_00c7;
			}
		}
		goto IL_008c;
		IL_002a:
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__34 stateMachine = default;
		stateMachine._003C_003Et__builder = WDOHOeQ6Uka3yw8CEYy();
		num = 6;
		if (!G7EibwQsErYZWtIrkg9())
		{
			goto IL_0046;
		}
		goto IL_008c;
		IL_00c7:
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_008c;
		IL_0046:
		stateMachine._003C_003E4__this = this;
		num = 4;
		if (false)
		{
			goto IL_005a;
		}
		goto IL_008c;
		IL_008c:
		switch (num)
		{
		case 0:
		case 2:
			break;
		case 6:
			goto IL_0046;
		case 5:
			goto IL_005a;
		case 4:
			stateMachine.e = e;
			goto IL_00c7;
		default:
			goto IL_00c7;
		case 7:
			return stateMachine._003C_003Et__builder.Task;
		}
		goto IL_002a;
		IL_005a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_008c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRenameReferences_003Ed__35))]
	Task ISnippetConsumer.RenameReferences(SnippetRenamedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRenameReferences_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine.e = e;
				goto case 2;
			default:
				num = 2;
				continue;
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				G7EibwQsErYZWtIrkg9();
				num = ((!DZ8mN2Qv8GUl18l7AuV()) ? 3 : 5);
				continue;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 0;
				if (0 == 0)
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
	public void Add(CellViewModel cellViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EasyViewSettings settings = Settings;
		if (settings != null)
		{
			lSoXXAQRgO5XhTiBfBm(settings, cellViewModel);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(CellViewModel cellViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EasyViewSettings settings = Settings;
		if (settings != null)
		{
			BmfgMCQTCy767eJB9Qw(settings, cellViewModel);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HmiStepViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uIGviYQrrbaiqW3aNkr();
		Log = LogManager.GetLogger<HmiStepViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask MqfekliSsa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task k8MePLJDQT(StepBase P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnEnterStep(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uIGviYQrrbaiqW3aNkr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UVSOidQPjlSRk9xbLZX(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool G7EibwQsErYZWtIrkg9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DZ8mN2Qv8GUl18l7AuV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder DvbOA9QZ328rgcw8YBZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iKEjQdQB8oaEZlCw9tS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.HMI;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vpV6mQQbQMJdU5cltKg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.G8N9KIQENn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e2uCvnQGobgKsfWVqkp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).EasyView;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mZ6bsSQo4yMTQxw1PG7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyViewViewModel)P_0).Settings;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c26qZFQSigvynlLLOP5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeModeChangedEventArgs)P_0).IsLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T2yLGoQkF1YV2l9XVmL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<CheckBoxTreeItemViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X7nvj4Q8yeq935ZLn2h(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tKR3hoQqnptX4xrxovs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AMlHjtQEp09quJ693yj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).Debug((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tZ6LZhQp3PDxUWembKC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wKNVDcQXMVGqydJBDXe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BJ0tEgQ906qYpOxFlQZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).HmiHttpPort;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X0wKE8Q4mjeDEfmSXTA(object P_0, UriComponents P_1, UriFormat P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Uri)P_0).GetComponents(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qx8LMnQ7nTYEHqApqcD(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PggCGBQ3O98il8bS6na(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CheckBoxTreeViewModel)P_0).AreCheckboxesEnabled = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TBs8vEQjVc1FbgbYtWY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder WDOHOeQ6Uka3yw8CEYy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SnippetAddedEventType RhWenpQCKJMtAkKmTxf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetAddedEventArgs)P_0).SnippetAddedType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qtPn1UQAM9vk3DLQ8OL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetAddedEventArgs)P_0).Snippet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lSoXXAQRgO5XhTiBfBm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyViewSettings)P_0).AddItem((ICellViewModel)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Wck1HXQWJCIu4HdrmgX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SLmGL7CyIs();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BmfgMCQTCy767eJB9Qw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyViewSettings)P_0).RemoveItem((ICellViewModel)P_1);
	}
}
