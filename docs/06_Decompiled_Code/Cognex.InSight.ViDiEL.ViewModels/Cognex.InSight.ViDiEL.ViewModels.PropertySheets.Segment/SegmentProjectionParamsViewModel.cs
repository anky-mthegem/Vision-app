using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.Foundations.Mvvm.Common;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Remoting.Serialization.ViDiEL;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.Segment;
using Cognex.Mvvm;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets.Segment;

public class SegmentProjectionParamsViewModel : PropertySheetViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeProjectionParams_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SegmentProjectionParamsViewModel _003C_003E4__this;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!oWi1kWx753UgqvAHyjB())
			{
				num = 3;
				if (!aaBHe3xlIIXYrhA8q9r())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (false)
				{
					return;
				}
			}
			goto IL_01bf;
			IL_002a:
			SegmentProjectionParamsViewModel segmentProjectionParamsViewModel = _003C_003E4__this;
			num = 2;
			goto IL_01bf;
			IL_01bf:
			int num2 = default;
			ELTunableProjectionParams result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
					try
					{
						TaskAwaiter<ELTunableProjectionParams> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentProjectionParamsViewModel.ToolAdapter.GetProjectionParams(segmentProjectionParamsViewModel.ToolId).GetAwaiter();
							num3 = 9;
							goto IL_011c;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0167;
						IL_0167:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_011c;
						IL_011c:
						while (true)
						{
							switch (num3)
							{
							case 1:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									if (true)
									{
										continue;
									}
									return;
								}
								goto case 1;
							case 4:
							case 7:
								return;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (!oWi1kWx753UgqvAHyjB())
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								oWi1kWx753UgqvAHyjB();
								num3 = (aaBHe3xlIIXYrhA8q9r() ? 7 : 6);
								continue;
							case 5:
							case 6:
								break;
							case 10:
								segmentProjectionParamsViewModel.mp1oz7pF1k(result);
								goto end_IL_011c;
							}
							goto IL_0167;
							continue;
							end_IL_011c:
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
					goto case 4;
				default:
					num = 4;
					if (!oWi1kWx753UgqvAHyjB())
					{
						continue;
					}
					goto case 0;
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
		internal static bool aaBHe3xlIIXYrhA8q9r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oWi1kWx753UgqvAHyjB()
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
	private struct _003CPerformAutoTune_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SegmentProjectionParamsViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private ITopLevelProgressableOperation _003C_003E7__wrap3;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			SegmentProjectionParamsViewModel segmentProjectionParamsViewModel = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<ELTunableProjectionParams> awaiter3 = default;
			CancellationTokenSource cancellationTokenSource = default;
			ELTunableProjectionParams result = default;
			int num2 = default;
			do
			{
				IL_03e5:
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter<bool> awaiter;
						if ((uint)num2 > 1u)
						{
							if (num2 == 2)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_039b;
							}
							_003C_003E7__wrap2 = 0;
						}
						try
						{
							if ((uint)num2 <= 1u)
							{
								goto IL_0078;
							}
							ITopLevelProgressableOperation topLevelProgressableOperation = null;
							IOperationProgressManager operationProgressManager = segmentProjectionParamsViewModel.OperationProgressManager;
							if (operationProgressManager != null && m3bIycxfVSA1vBVsJbZ(operationProgressManager))
							{
								topLevelProgressableOperation = ((IOperationProgressManager)eVgdcGxzBDfbKSSf6s8(segmentProjectionParamsViewModel)).StartBlockingOperation((string)yRyLXqh2QphiMliR71H(), Array.Empty<StepDescriptor>());
							}
							if (topLevelProgressableOperation != null)
							{
								_003C_003E7__wrap3 = topLevelProgressableOperation;
								goto IL_0078;
							}
							goto end_IL_002e;
							IL_0078:
							try
							{
								int num3;
								if (num2 != 0)
								{
									if (num2 != 1)
									{
										num3 = 5;
										if (false)
										{
											goto IL_0091;
										}
									}
									else
									{
										awaiter2 = _003C_003Eu__2;
										_003C_003Eu__2 = default;
										num3 = 6;
									}
								}
								else
								{
									awaiter3 = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									if (rXHNHqxnxc15MO7E7BB())
									{
										goto IL_01b7;
									}
								}
								goto IL_0101;
								IL_01e4:
								awaiter3 = segmentProjectionParamsViewModel.ToolAdapter.GetAutoTuneProjectionParameters(segmentProjectionParamsViewModel.ToolId).GetAwaiter();
								num3 = 1;
								goto IL_0101;
								IL_01b7:
								num2 = (_003C_003E1__state = 1);
								num3 = 12;
								if (0 == 0)
								{
									goto IL_0101;
								}
								goto IL_01cc;
								IL_02a1:
								awaiter2.GetResult();
								goto end_IL_0078;
								IL_01cc:
								if (!awaiter2.IsCompleted)
								{
									num3 = 2;
									if (true)
									{
										goto IL_0101;
									}
									goto IL_01e4;
								}
								goto IL_02a1;
								IL_0091:
								awaiter2 = v4Ub4ihkedaOJEFODo7(lgEfTkhM3OsqYAonGTw(segmentProjectionParamsViewModel.ToolAdapter, segmentProjectionParamsViewModel.ToolId, fyoNcLhXQTTr7NkOGno(cancellationTokenSource)));
								num3 = 13;
								goto IL_0101;
								IL_0101:
								while (true)
								{
									switch (num3)
									{
									case 0:
									case 9:
										break;
									case 3:
									case 7:
										_003C_003Eu__1 = awaiter3;
										num3 = 16;
										if (W329ZcxyZg0nqpLvnDo())
										{
											continue;
										}
										goto case 1;
									case 1:
										if (!awaiter3.IsCompleted)
										{
											num3 = 10;
											continue;
										}
										goto case 11;
									case 4:
										segmentProjectionParamsViewModel.mp1oz7pF1k(result);
										goto case 8;
									default:
										num3 = 8;
										if (0 == 0)
										{
											continue;
										}
										goto case 6;
									case 6:
										num2 = (_003C_003E1__state = -1);
										num3 = 17;
										continue;
									case 16:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 15;
										continue;
									case 15:
										return;
									case 2:
										goto IL_01b7;
									case 13:
										goto IL_01cc;
									case 5:
										goto IL_01e4;
									case 11:
										result = awaiter3.GetResult();
										num3 = 4;
										continue;
									case 12:
										_003C_003Eu__2 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 14;
										continue;
									case 14:
										return;
									case 10:
										num2 = (_003C_003E1__state = 0);
										W329ZcxyZg0nqpLvnDo();
										if (!rXHNHqxnxc15MO7E7BB())
										{
											num3 = 7;
											if (true)
											{
												continue;
											}
											goto case 8;
										}
										num3 = 0;
										if (rXHNHqxnxc15MO7E7BB())
										{
										}
										continue;
									case 8:
										cancellationTokenSource = new CancellationTokenSource();
										break;
									case 17:
										goto IL_02a1;
									}
									break;
								}
								goto IL_0091;
								end_IL_0078:;
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap3 != null)
								{
									hOm5Fxhm4LHyJ3WYsFw(_003C_003E7__wrap3);
								}
							}
							_003C_003E7__wrap3 = null;
							end_IL_002e:;
						}
						catch (Exception ex)
						{
							_003C_003E7__wrap1 = ex;
							_003C_003E7__wrap2 = 1;
						}
						int num4 = _003C_003E7__wrap2;
						if (num4 == 1)
						{
							Exception ex2 = (Exception)_003C_003E7__wrap1;
							s4XDDehPfTdLuhRbe7w(vEwaOZUNMJ, LogLevel.Error, zUtENYhraRhl1Idwjb8(7702), ex2);
							object broadcaster = Fx331hh45AC3LwkMd4Y();
							ErrorMessageViewModel errorMessageViewModel = new ErrorMessageViewModel();
							jp2gFRh1Q7aARxV5fMm(errorMessageViewModel, TbV8DYhgJvvYE4dlHb0());
							errorMessageViewModel.Message = Resources.AutoTuneMinImages;
							awaiter = ((IViewModelBroadcaster)broadcaster).Broadcast(null, errorMessageViewModel).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_039b;
						}
						goto IL_03a3;
						IL_039b:
						awaiter.GetResult();
						goto IL_03a3;
						IL_03a3:
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
					goto IL_03e5;
				case 0:
				case 1:
					segmentProjectionParamsViewModel = _003C_003E4__this;
					goto case 2;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (rXHNHqxnxc15MO7E7BB() ? 5 : 0);
					goto IL_03e5;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (0 == 0);
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
		internal static bool m3bIycxfVSA1vBVsJbZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).HasNoOperationsPending;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eVgdcGxzBDfbKSSf6s8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TopLevelViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yRyLXqh2QphiMliR71H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ApplyingChanges;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken fyoNcLhXQTTr7NkOGno(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lgEfTkhM3OsqYAonGTw(object P_0, object P_1, CancellationToken token)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).TrainAsync((string)P_1, token);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter v4Ub4ihkedaOJEFODo7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hOm5Fxhm4LHyJ3WYsFw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zUtENYhraRhl1Idwjb8(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void s4XDDehPfTdLuhRbe7w(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fx331hh45AC3LwkMd4Y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.Mvvm.ViewModelBroadcaster.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TbV8DYhgJvvYE4dlHb0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.AutoTuneFailed;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jp2gFRh1Q7aARxV5fMm(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Heading = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W329ZcxyZg0nqpLvnDo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rXHNHqxnxc15MO7E7BB()
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
	private struct _003CSetProjectionParamsAndTrain_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SegmentProjectionParamsViewModel _003C_003E4__this;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kAF3FJhShrNUbqfvJey();
			int num = (xnb6Alh6HYyW7Kuejb1() ? 3 : 2);
			SegmentProjectionParamsViewModel segmentProjectionParamsViewModel = default;
			int num2 = default;
			CancellationTokenSource cancellationTokenSource = default;
			TaskAwaiter awaiter2 = default;
			do
			{
				IL_02dc:
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 4:
					try
					{
						TaskAwaiter<ELTunableProjectionParams> awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_013e;
							}
							ELTunableProjectionParams eLTunableProjectionParams = new ELTunableProjectionParams();
							rlqiSPh8qsTV22CASCO(eLTunableProjectionParams, Dqly5vhDsOq8IkJ5Byc(segmentProjectionParamsViewModel.SelectedProjectionModeIndex));
							eLTunableProjectionParams.FeatureWidth = segmentProjectionParamsViewModel.FeatureWidth;
							tI73ANhF5CY4YJRn1D0(eLTunableProjectionParams, segmentProjectionParamsViewModel.FeatureHeight);
							ELTunableProjectionParams projectionParams = eLTunableProjectionParams;
							awaiter = segmentProjectionParamsViewModel.ToolAdapter.SetProjectionParams(segmentProjectionParamsViewModel.ToolId, projectionParams).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						ELTunableProjectionParams result = awaiter.GetResult();
						segmentProjectionParamsViewModel.mp1oz7pF1k(result);
						cancellationTokenSource = new CancellationTokenSource();
						ITopLevelProgressableOperation topLevelProgressableOperation = null;
						object obj = QIrShIhsH3w15dUoNK0(segmentProjectionParamsViewModel);
						if (obj != null && HPBIUQhdXKgP7Xa7Ue8(obj))
						{
							topLevelProgressableOperation = (ITopLevelProgressableOperation)tBuDdbh5uYLJRjXFZvG(QIrShIhsH3w15dUoNK0(segmentProjectionParamsViewModel), eUvXTShEUWVMnw1TSMJ(), Array.Empty<StepDescriptor>());
						}
						if (topLevelProgressableOperation != null)
						{
							_003C_003E7__wrap1 = topLevelProgressableOperation;
							goto IL_013e;
						}
						goto end_IL_003f;
						IL_013e:
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 5;
							}
							else
							{
								awaiter2 = _003C_003Eu__2;
								num3 = 0;
							}
							while (true)
							{
								switch (num3)
								{
								case 8:
									num2 = (_003C_003E1__state = 1);
									num3 = 6;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								case 5:
									awaiter2 = lB62KihooNmVnJcfOmx(PyRVwFhaGP0ntc5fFH7(segmentProjectionParamsViewModel.ToolAdapter, segmentProjectionParamsViewModel.ToolId, j1jf7kh3Y0Y2GgKnt5l(cancellationTokenSource)));
									xnb6Alh6HYyW7Kuejb1();
									if (kAF3FJhShrNUbqfvJey())
									{
										num3 = 4;
										if (1 == 0)
										{
											return;
										}
									}
									else
									{
										num3 = 3;
									}
									continue;
								case 2:
									return;
								case 0:
									_003C_003Eu__2 = default;
									goto case 3;
								case 3:
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 1;
								case 1:
								case 4:
									if (awaiter2.IsCompleted)
									{
										break;
									}
									num3 = 8;
									if (!xnb6Alh6HYyW7Kuejb1())
									{
										continue;
									}
									goto case 9;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 2;
									continue;
								case 6:
									_003C_003Eu__2 = awaiter2;
									goto case 9;
								default:
									num3 = 9;
									continue;
								case 10:
									break;
								}
								break;
							}
							awaiter2.GetResult();
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								ICGqjPhc9Mgn6IPgLnS(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
						end_IL_003f:;
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
					if (xnb6Alh6HYyW7Kuejb1())
					{
					}
					goto IL_02dc;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						goto IL_02dc;
					}
					break;
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				segmentProjectionParamsViewModel = _003C_003E4__this;
				num = 4;
			}
			while (kAF3FJhShrNUbqfvJey());
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
		internal static int Dqly5vhDsOq8IkJ5Byc(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aSEoUp590m(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rlqiSPh8qsTV22CASCO(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELTunableProjectionParams)P_0).Mode = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tI73ANhF5CY4YJRn1D0(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELTunableProjectionParams)P_0).FeatureHeight = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QIrShIhsH3w15dUoNK0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TopLevelViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HPBIUQhdXKgP7Xa7Ue8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).HasNoOperationsPending;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eUvXTShEUWVMnw1TSMJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ApplyingChanges;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tBuDdbh5uYLJRjXFZvG(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken j1jf7kh3Y0Y2GgKnt5l(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PyRVwFhaGP0ntc5fFH7(object P_0, object P_1, CancellationToken token)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).TrainAsync((string)P_1, token);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lB62KihooNmVnJcfOmx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ICGqjPhc9Mgn6IPgLnS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kAF3FJhShrNUbqfvJey()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xnb6Alh6HYyW7Kuejb1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static ILogger vEwaOZUNMJ;

	[CompilerGenerated]
	private readonly CvsInSight f2JaIv4AHN;

	[CompilerGenerated]
	private readonly SegmentAdapterBase jxCa2CgPDv;

	[CompilerGenerated]
	private string XbQaxLUjo1;

	[CompilerGenerated]
	private List<ProjectionMode> PMAaoaok4o;

	private int GBaaa0ngxk;

	private double BX5aVKwuut;

	private double LnVaNDUsBO;

	private bool oH5aGrsQyo;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)B7ddvmr7INvdkfSe6Su(2538);
		}
	}

	protected CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f2JaIv4AHN;
		}
	}

	protected SegmentAdapterBase ToolAdapter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jxCa2CgPDv;
		}
	}

	public string ToolId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XbQaxLUjo1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XbQaxLUjo1 = value;
		}
	}

	public List<ProjectionMode> ProjectionModes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PMAaoaok4o;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PMAaoaok4o = value;
		}
	}

	public int SelectedProjectionModeIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GBaaa0ngxk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 0:
					WCeowmMmYH();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					if (GBaaa0ngxk != value)
					{
						_ = 0;
						num = ((!RUKajXreviBJhgmarwJ()) ? 5 : 4);
						break;
					}
					return;
				case 1:
				case 4:
					SetField(ref GBaaa0ngxk, value, (string)B7ddvmr7INvdkfSe6Su(2624));
					goto case 2;
				case 2:
				case 5:
					ekePO0PXQrpndYAdVym(this, B7ddvmr7INvdkfSe6Su(2624));
					goto case 0;
				default:
					num = 0;
					break;
				case 6:
					return;
				}
			}
		}
	}

	public double FeatureWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BX5aVKwuut;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0082;
			IL_001a:
			if (BX5aVKwuut != value)
			{
				num = 0;
				goto IL_0082;
			}
			return;
			IL_0082:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
					SetField(ref BX5aVKwuut, value, (string)B7ddvmr7INvdkfSe6Su(2682));
					_ = 0;
					if (RUKajXreviBJhgmarwJ())
					{
						num = 4;
						if (true)
						{
							continue;
						}
						goto case 2;
					}
					num = 5;
					continue;
				case 2:
				case 4:
					ekePO0PXQrpndYAdVym(this, B7ddvmr7INvdkfSe6Su(2682));
					goto default;
				default:
					WCeowmMmYH();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public double FeatureHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LnVaNDUsBO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (RUKajXreviBJhgmarwJ())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (!RUKajXreviBJhgmarwJ())
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					WCeowmMmYH();
					num = 6;
					break;
				case 1:
				case 4:
					SetField(ref LnVaNDUsBO, value, (string)B7ddvmr7INvdkfSe6Su(2710));
					num = 2;
					break;
				case 2:
					ekePO0PXQrpndYAdVym(this, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2710));
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 5:
					if (LnVaNDUsBO != value)
					{
						goto case 1;
					}
					return;
				case 6:
					return;
				}
			}
		}
	}

	public bool EnableAutoTune
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oH5aGrsQyo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref oH5aGrsQyo, value, (string)B7ddvmr7INvdkfSe6Su(2740));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SegmentProjectionParamsViewModel(CvsInSight insight, SegmentAdapterBase toolAdapter, string ezbToolId = null)
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
		goto IL_00d9;
		IL_001a:
		rtRB62rnkO9YJQh4MEh(this);
		_ = 1;
		if (!JmKbZIrlCbm9HPltRj7())
		{
			num = 10;
			if (JmKbZIrlCbm9HPltRj7())
			{
			}
		}
		else
		{
			num = 7;
		}
		goto IL_00d9;
		IL_00d9:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 6:
				GloINDryvLPVUseBZIH();
				num = 5;
				continue;
			case 1:
				oH5aGrsQyo = false;
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 7:
				throw new ArgumentNullException((string)B7ddvmr7INvdkfSe6Su(2606));
			case 2:
			case 10:
				if (insight != null)
				{
					f2JaIv4AHN = insight;
					num = 4;
					continue;
				}
				goto case 3;
			case 9:
				ToolId = ezbToolId;
				num = 0;
				continue;
			case 8:
				GBaaa0ngxk = sEuo4Fl8E9(3);
				num = 1;
				continue;
			case 4:
				jxCa2CgPDv = toolAdapter;
				goto case 9;
			default:
				num = 9;
				continue;
			case 0:
				ProjectionModes = ((IEnumerable)WUU4t8rzwdAcljRXDeL(rx1SswrfXcmxkOdwCgq(typeof(ProjectionMode).TypeHandle))).Cast<ProjectionMode>().ToList();
				num = 8;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeProjectionParams_003Ed__4))]
	public void InitializeProjectionParams()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!RUKajXreviBJhgmarwJ()) ? 4 : 2);
		_003CInitializeProjectionParams_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = uH37O1P2y3FBSw4XMif();
				goto case 1;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 6:
				return;
			}
			num = 5;
			if (false)
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPerformAutoTune_003Ed__5))]
	public void PerformAutoTune()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JmKbZIrlCbm9HPltRj7();
		int num;
		if (RUKajXreviBJhgmarwJ())
		{
			num = 2;
		}
		else
		{
			num = 1;
			if (false)
			{
				return;
			}
		}
		_003CPerformAutoTune_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = uH37O1P2y3FBSw4XMif();
				num = 4;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (RUKajXreviBJhgmarwJ())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetProjectionParamsAndTrain_003Ed__6))]
	private void WCeowmMmYH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!JmKbZIrlCbm9HPltRj7())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
			if (!RUKajXreviBJhgmarwJ())
			{
				goto IL_005a;
			}
		}
		goto IL_008c;
		IL_008c:
		_003CSetProjectionParamsAndTrain_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = uH37O1P2y3FBSw4XMif();
				break;
			case 5:
				goto IL_005a;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto IL_005a;
			default:
				num = 5;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_005a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_008c;
		IL_0026:
		stateMachine._003C_003E4__this = this;
		num = 4;
		goto IL_008c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int sEuo4Fl8E9(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Tr0guePMrWGGFGQ8nX3(Enum.GetValues(rx1SswrfXcmxkOdwCgq(typeof(ProjectionMode).TypeHandle)), (ProjectionMode)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int aSEoUp590m(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (int)quyV6nPk35nPe7rXYhu(WUU4t8rzwdAcljRXDeL(rx1SswrfXcmxkOdwCgq(typeof(ProjectionMode).TypeHandle)), P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mp1oz7pF1k(ELTunableProjectionParams P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 0:
				SetField(ref GBaaa0ngxk, LbEUdaPrRPmrOVDUC6Q(HK2QtPPmNxIIR59wX1R(P_0)), (string)B7ddvmr7INvdkfSe6Su(2772));
				num = 8;
				break;
			case 5:
				if (P_0 != null)
				{
					num = 0;
					break;
				}
				return;
			case 8:
				FirePropertyChangedExplicit(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2624));
				JmKbZIrlCbm9HPltRj7();
				num = ((!RUKajXreviBJhgmarwJ()) ? 7 : 6);
				break;
			default:
				FirePropertyChangedExplicit((string)B7ddvmr7INvdkfSe6Su(2682));
				num = 2;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				SetField(ref LnVaNDUsBO, P_0.FeatureHeight, (string)B7ddvmr7INvdkfSe6Su(2772));
				num = 1;
				break;
			case 3:
			case 6:
				SetField(ref BX5aVKwuut, bxJ5GgPPhhaIGp9O3Oq(P_0), plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2772));
				goto default;
			case 1:
				ekePO0PXQrpndYAdVym(this, B7ddvmr7INvdkfSe6Su(2710));
				num = 9;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SegmentProjectionParamsViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		vEwaOZUNMJ = LogManager.GetLogger<SegmentProjectionParamsViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B7ddvmr7INvdkfSe6Su(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GloINDryvLPVUseBZIH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rtRB62rnkO9YJQh4MEh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type rx1SswrfXcmxkOdwCgq(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WUU4t8rzwdAcljRXDeL(Type P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enum.GetValues(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RUKajXreviBJhgmarwJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JmKbZIrlCbm9HPltRj7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder uH37O1P2y3FBSw4XMif()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ekePO0PXQrpndYAdVym(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.InSight.Controls.ViewModels.BaseViewModel)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Tr0guePMrWGGFGQ8nX3(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Array.IndexOf((Array)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object quyV6nPk35nPe7rXYhu(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Array)P_0).GetValue(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int HK2QtPPmNxIIR59wX1R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ELTunableProjectionParams)P_0).Mode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LbEUdaPrRPmrOVDUC6Q(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sEuo4Fl8E9(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double bxJ5GgPPhhaIGp9O3Oq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ELTunableProjectionParams)P_0).FeatureWidth;
	}
}
