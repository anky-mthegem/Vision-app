using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Diagnostics.Logging;
using Cognex.Foundations.Mvvm.Common;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Remoting.Serialization.ViDiEL;
using Cognex.InSight.Services;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.Mvvm;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets.Classify;

public class ClassifyProjectionParamsViewModel : PropertySheetViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeProjectionParams_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassifyProjectionParamsViewModel _003C_003E4__this;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			ClassifyProjectionParamsViewModel classifyProjectionParamsViewModel = default;
			ELTunableProjectionParams result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!sXSITiUtUEMd031U1k0()) ? 5 : 4);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					try
					{
						TaskAwaiter<ELTunableProjectionParams> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = classifyProjectionParamsViewModel.ToolAdapter.GetProjectionParams().GetAwaiter();
							num3 = 1;
							goto IL_00ce;
						}
						awaiter = _003C_003Eu__1;
						goto IL_006d;
						IL_009c:
						result = awaiter.GetResult();
						num3 = 10;
						goto IL_00ce;
						IL_006d:
						_003C_003Eu__1 = default;
						num3 = 6;
						if (1 == 0)
						{
							goto IL_0085;
						}
						goto IL_00ce;
						IL_00ce:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 5:
								break;
							case 8:
								goto IL_0085;
							case 9:
								goto IL_009c;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 1;
								num3 = (tNTiK8U9hDRS60Cl95i() ? 3 : 7);
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto IL_009c;
							case 4:
							case 7:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								classifyProjectionParamsViewModel.V9WabQD3Pn(result);
								goto end_IL_004c;
							}
							break;
						}
						goto IL_006d;
						IL_0085:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						if (tNTiK8U9hDRS60Cl95i())
						{
							goto IL_009c;
						}
						goto IL_00ce;
						end_IL_004c:;
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
				case 4:
					classifyProjectionParamsViewModel = _003C_003E4__this;
					num = 2;
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
		internal static bool sXSITiUtUEMd031U1k0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tNTiK8U9hDRS60Cl95i()
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

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassifyProjectionParamsViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

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
			IPqY3lUZjRCL0ZLZPEu();
			int num = ((!Mmb3F9Uv8qrFLCPW4D9()) ? 4 : 3);
			ClassifyProjectionParamsViewModel classifyProjectionParamsViewModel = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<ELTunableProjectionParams> awaiter3 = default;
			ELTunableProjectionParams result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					classifyProjectionParamsViewModel = _003C_003E4__this;
					num = 5;
					break;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
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
								goto IL_0328;
							}
							_003C_003E7__wrap2 = 0;
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									goto IL_0203;
								}
								num3 = 14;
							}
							else
							{
								awaiter3 = _003C_003Eu__1;
								num3 = 11;
							}
							goto IL_00ed;
							IL_00ed:
							while (true)
							{
								switch (num3)
								{
								case 9:
									awaiter2 = ycIxWHU0KCrwO5Kvbo8(classifyProjectionParamsViewModel.ToolAdapter.Train());
									if (!awaiter2.IsCompleted)
									{
										num3 = 12;
										if (!IPqY3lUZjRCL0ZLZPEu())
										{
											continue;
										}
										goto case 14;
									}
									goto case 16;
								case 14:
									awaiter3 = classifyProjectionParamsViewModel.ToolAdapter.AutoTuneProjectionParameters().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num3 = 1;
										if (0 == 0)
										{
											continue;
										}
										goto case 4;
									}
									goto case 6;
								case 4:
									num2 = (_003C_003E1__state = -1);
									goto case 6;
								default:
									num3 = 6;
									if (true)
									{
										continue;
									}
									goto case 2;
								case 2:
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 8;
									continue;
								case 1:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 6:
									result = awaiter3.GetResult();
									num3 = 0;
									continue;
								case 3:
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 10;
									continue;
								case 10:
									return;
								case 7:
									_003C_003Eu__1 = awaiter3;
									Mmb3F9Uv8qrFLCPW4D9();
									if (!IPqY3lUZjRCL0ZLZPEu())
									{
										num3 = 15;
										if (!IPqY3lUZjRCL0ZLZPEu())
										{
											continue;
										}
										goto case 11;
									}
									num3 = 5;
									continue;
								case 11:
									_003C_003Eu__1 = default;
									num3 = 4;
									continue;
								case 0:
									classifyProjectionParamsViewModel.V9WabQD3Pn(result);
									num3 = 9;
									continue;
								case 5:
								case 13:
									break;
								case 8:
									return;
								case 12:
									num2 = (_003C_003E1__state = 1);
									num3 = 2;
									continue;
								case 16:
									awaiter2.GetResult();
									goto end_IL_00ed;
								}
								goto IL_0203;
								continue;
								end_IL_00ed:
								break;
							}
							goto end_IL_0064;
							IL_0203:
							num2 = (_003C_003E1__state = -1);
							num3 = 16;
							if (IPqY3lUZjRCL0ZLZPEu())
							{
								return;
							}
							goto IL_00ed;
							end_IL_0064:;
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
							gMiA7xUHU3Ojs66Obcl(I8XawHtDSv, LogLevel.Error, yaRag2UO2tIv9Q9MjXq(7802), ex2);
							IViewModelBroadcaster broadcaster = Cognex.Mvvm.ViewModelBroadcaster.Default;
							ErrorMessageViewModel errorMessageViewModel = new ErrorMessageViewModel
							{
								Heading = Resources.AutoTuneFailed
							};
							Kp6qLZUY4mj6aVY4kAC(errorMessageViewModel, jn4PXPUTsXgNsKBbQ4L());
							awaiter = broadcaster.Broadcast(null, errorMessageViewModel).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0328;
						}
						goto IL_0330;
						IL_0328:
						awaiter.GetResult();
						goto IL_0330;
						IL_0330:
						_003C_003E7__wrap1 = null;
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
					break;
				case 0:
				case 3:
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
		internal static TaskAwaiter ycIxWHU0KCrwO5Kvbo8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yaRag2UO2tIv9Q9MjXq(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gMiA7xUHU3Ojs66Obcl(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jn4PXPUTsXgNsKBbQ4L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.AutoTuneFailed;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Kp6qLZUY4mj6aVY4kAC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Message = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Mmb3F9Uv8qrFLCPW4D9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IPqY3lUZjRCL0ZLZPEu()
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

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassifyProjectionParamsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Tfq0NLUKFKuFE3EBb0x();
			int num;
			if (Uf3tFhUJvyGaEEUf9bI())
			{
				num = 2;
				if (!Uf3tFhUJvyGaEEUf9bI())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_027f;
			IL_02b0:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_027f;
			IL_027f:
			ClassifyProjectionParamsViewModel classifyProjectionParamsViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				default:
					num = 5;
					if (Uf3tFhUJvyGaEEUf9bI())
					{
						continue;
					}
					goto IL_02b0;
				case 5:
					goto IL_02b0;
				case 1:
				case 4:
					classifyProjectionParamsViewModel = _003C_003E4__this;
					num = 3;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 9;
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 11;
					}
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
					case 6:
					case 14:
						awaiter.GetResult();
						goto case 4;
					default:
						num3 = 4;
						if (!Tfq0NLUKFKuFE3EBb0x())
						{
							continue;
						}
						goto case 4;
					case 4:
						awaiter = ((Task)tVw7FWUGssx8ar2mARt(classifyProjectionParamsViewModel.ToolAdapter)).GetAwaiter();
						goto case 1;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 1:
					case 8:
						if (awaiter.IsCompleted)
						{
							break;
						}
						num3 = 5;
						if (Uf3tFhUJvyGaEEUf9bI())
						{
							continue;
						}
						goto case 13;
					case 13:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						continue;
					case 12:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 10;
						continue;
					case 9:
					{
						ELTunableProjectionParams eLTunableProjectionParams = new ELTunableProjectionParams();
						nj1FN3UCGTAIlgi6bkW(eLTunableProjectionParams, idWasBRP5u(classifyProjectionParamsViewModel.SelectedProjectionModeIndex));
						cEZ5WiUAk0vB0e49ARA(eLTunableProjectionParams, classifyProjectionParamsViewModel.FeatureWidth);
						Cm7HwVUNmDM6eeCyIq2(eLTunableProjectionParams, classifyProjectionParamsViewModel.FeatureHeight);
						ELTunableProjectionParams eLTunableProjectionParams2 = eLTunableProjectionParams;
						awaiter = bO4GpCUpgy6KTxPlMm8(cNPf8eUwEUTZmmPAn70(classifyProjectionParamsViewModel.ToolAdapter, eLTunableProjectionParams2));
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							continue;
						}
						goto case 6;
					}
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 15;
						if (true)
						{
							continue;
						}
						goto case 15;
					case 15:
						_003C_003Eu__1 = awaiter;
						num3 = 12;
						continue;
					case 11:
						_003C_003Eu__1 = default;
						num3 = 0;
						continue;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 7:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						_ = 1;
						if (Tfq0NLUKFKuFE3EBb0x())
						{
							num3 = 1;
							continue;
						}
						num3 = 14;
						if (false)
						{
							return;
						}
						continue;
					case 10:
						return;
					case 5:
						num2 = (_003C_003E1__state = 1);
						num3 = 13;
						continue;
					case 16:
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
			goto IL_02b0;
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
		internal static void nj1FN3UCGTAIlgi6bkW(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELTunableProjectionParams)P_0).Mode = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cEZ5WiUAk0vB0e49ARA(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELTunableProjectionParams)P_0).FeatureWidth = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Cm7HwVUNmDM6eeCyIq2(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELTunableProjectionParams)P_0).FeatureHeight = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cNPf8eUwEUTZmmPAn70(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).SetProjectionParams((ELTunableProjectionParams)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter bO4GpCUpgy6KTxPlMm8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tVw7FWUGssx8ar2mARt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).Train();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Uf3tFhUJvyGaEEUf9bI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tfq0NLUKFKuFE3EBb0x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static ILogger I8XawHtDSv;

	[CompilerGenerated]
	private readonly CvsInSight OP0a4mYrTe;

	[CompilerGenerated]
	private readonly IViDiELClassifyService KkTaUKLggB;

	[CompilerGenerated]
	private List<ProjectionMode> MMVaz4kBkT;

	private int v0tVOrpPfj;

	private double sviVIKgYLW;

	private double vhQV2OLsTw;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(3070);
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
			return OP0a4mYrTe;
		}
	}

	protected IViDiELClassifyService ToolAdapter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KkTaUKLggB;
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
			return MMVaz4kBkT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MMVaz4kBkT = value;
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
			return v0tVOrpPfj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yfU6sS45m2phpLpDOAp();
			int num = ((!cKuOCL4EiuDqmNaiyZC()) ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 2:
					XZQakSNECU();
					num = 5;
					break;
				case 0:
				case 3:
					if (v0tVOrpPfj != value)
					{
						goto case 1;
					}
					return;
				case 1:
				case 4:
					SetField(ref v0tVOrpPfj, value, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2624));
					goto case 2;
				default:
					num = 2;
					break;
				case 5:
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
			return sviVIKgYLW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!cKuOCL4EiuDqmNaiyZC()) ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					SetField(ref sviVIKgYLW, value, (string)GqGh9w4B3mMsqC41xes(2682));
					goto case 4;
				default:
					num = 4;
					break;
				case 4:
					XZQakSNECU();
					num = 5;
					break;
				case 0:
				case 3:
					if (sviVIKgYLW != value)
					{
						goto case 1;
					}
					return;
				case 5:
					return;
				}
			}
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
			return vhQV2OLsTw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!cKuOCL4EiuDqmNaiyZC()) ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 3:
					XZQakSNECU();
					num = 5;
					if (cKuOCL4EiuDqmNaiyZC())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					SetField(ref vhQV2OLsTw, value, (string)GqGh9w4B3mMsqC41xes(2710));
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 4:
					if (vhQV2OLsTw != value)
					{
						goto case 1;
					}
					return;
				case 5:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClassifyProjectionParamsViewModel(CvsInSight insight, IViDiELClassifyService toolAdapter)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cKuOCL4EiuDqmNaiyZC();
		int num = (yfU6sS45m2phpLpDOAp() ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			default:
				KkTaUKLggB = toolAdapter;
				num = 8;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				R3wPtw43dW7MbentwO5(this);
				num = 7;
				break;
			case 0:
			case 2:
				HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
				num = 6;
				break;
			case 7:
				if (insight == null)
				{
					num = 1;
					break;
				}
				OP0a4mYrTe = insight;
				goto default;
			case 3:
				v0tVOrpPfj = WL7n9A4c47RfqAZIhqr(3);
				num = 9;
				if (cKuOCL4EiuDqmNaiyZC())
				{
					break;
				}
				goto case 8;
			case 8:
				ProjectionModes = ((IEnumerable)rgaSPq4oF6KwOWoUco9(Eff1i04aJ7adioYXSWg(typeof(ProjectionMode).TypeHandle))).Cast<ProjectionMode>().ToList();
				num = 3;
				break;
			case 1:
				throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2606));
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeProjectionParams_003Ed__4))]
	public Task InitializeProjectionParams()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cKuOCL4EiuDqmNaiyZC();
		int num = (yfU6sS45m2phpLpDOAp() ? 2 : 5);
		_003CInitializeProjectionParams_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = pWQr1X4ufDF8lw9KVP9();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (cKuOCL4EiuDqmNaiyZC())
				{
					break;
				}
				goto default;
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
	[AsyncStateMachine(typeof(_003CPerformAutoTune_003Ed__5))]
	public Task PerformAutoTune()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (yfU6sS45m2phpLpDOAp() ? 5 : 4);
		_003CPerformAutoTune_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = pWQr1X4ufDF8lw9KVP9();
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
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
	[AsyncStateMachine(typeof(_003CSetProjectionParamsAndTrain_003Ed__6))]
	private Task XZQakSNECU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!yfU6sS45m2phpLpDOAp())
		{
		}
		_003CSetProjectionParamsAndTrain_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				cKuOCL4EiuDqmNaiyZC();
				if (!yfU6sS45m2phpLpDOAp())
				{
					num = 1;
					continue;
				}
				num = 0;
				if (cKuOCL4EiuDqmNaiyZC())
				{
					continue;
				}
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int Y0FaQIHhFX(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Array.IndexOf(Enum.GetValues(Eff1i04aJ7adioYXSWg(typeof(ProjectionMode).TypeHandle)), (ProjectionMode)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int idWasBRP5u(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (int)UDqyos4xIXlx2qT1fKf(rgaSPq4oF6KwOWoUco9(Eff1i04aJ7adioYXSWg(typeof(ProjectionMode).TypeHandle)), P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void V9WabQD3Pn(ELTunableProjectionParams P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!cKuOCL4EiuDqmNaiyZC())
		{
			goto IL_001e;
		}
		goto IL_00c4;
		IL_001e:
		SetField(ref vhQV2OLsTw, hjObFU4qycvPpnb9wXt(P_0), (string)GqGh9w4B3mMsqC41xes(2772));
		num = 8;
		goto IL_00c4;
		IL_00c4:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 6:
				if (P_0 != null)
				{
					_ = 0;
					num = (cKuOCL4EiuDqmNaiyZC() ? 5 : 0);
					continue;
				}
				return;
			default:
				tddKuN4QRWE1XQS8Tu7(this, GqGh9w4B3mMsqC41xes(2682));
				num = 2;
				continue;
			case 3:
				FirePropertyChangedExplicit(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2624));
				num = 7;
				continue;
			case 7:
				SetField(ref sviVIKgYLW, jWqfCJ4U6OOttJGyi2r(P_0), (string)GqGh9w4B3mMsqC41xes(2772));
				goto default;
			case 1:
			case 5:
				SetField(ref v0tVOrpPfj, WL7n9A4c47RfqAZIhqr(OwtOwg4hZt5CgOVCxr7(P_0)), (string)GqGh9w4B3mMsqC41xes(2772));
				num = 3;
				continue;
			case 8:
				tddKuN4QRWE1XQS8Tu7(this, GqGh9w4B3mMsqC41xes(2710));
				num = 9;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassifyProjectionParamsViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WEZZna4V6NSKU9BJ16E();
		I8XawHtDSv = LogManager.GetLogger<ClassifyProjectionParamsViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R3wPtw43dW7MbentwO5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Eff1i04aJ7adioYXSWg(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rgaSPq4oF6KwOWoUco9(Type P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enum.GetValues(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WL7n9A4c47RfqAZIhqr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Y0FaQIHhFX(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cKuOCL4EiuDqmNaiyZC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yfU6sS45m2phpLpDOAp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder pWQr1X4ufDF8lw9KVP9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GqGh9w4B3mMsqC41xes(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UDqyos4xIXlx2qT1fKf(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Array)P_0).GetValue(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OwtOwg4hZt5CgOVCxr7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ELTunableProjectionParams)P_0).Mode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double jWqfCJ4U6OOttJGyi2r(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ELTunableProjectionParams)P_0).FeatureWidth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tddKuN4QRWE1XQS8Tu7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.InSight.Controls.ViewModels.BaseViewModel)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double hjObFU4qycvPpnb9wXt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ELTunableProjectionParams)P_0).FeatureHeight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WEZZna4V6NSKU9BJ16E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}
}
