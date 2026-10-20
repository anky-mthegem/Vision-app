using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.AnomalyDetector.Client.Tool;
using Cognex.AnomalyDetector.Client.Tool.Interfaces;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Help;
using Cognex.InSight.ViDiEL.ViewModels.AnomalyDetect;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELAnomalyDetect;

[Export(typeof(ViDiELAnomalyDetectTool))]
public class ViDiELAnomalyDetectTool : ViDiELEzToolBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public ViDiELAnomalyDetectTool _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			ViDiELAnomalyDetectTool viDiELAnomalyDetectTool = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
			do
			{
				IL_01bc:
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!dZnvqMK91ZBta4PMAxJ7())
					{
						num = 5;
					}
					else
					{
						num = 2;
						if (dZnvqMK91ZBta4PMAxJ7())
						{
						}
					}
					goto IL_01bc;
				case 1:
				case 5:
					viDiELAnomalyDetectTool = _003C_003E4__this;
					num = 4;
					goto IL_01bc;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							viDiELAnomalyDetectTool.UstDziZMwt.ThresholdUpdated -= viDiELAnomalyDetectTool.tARDtHXurS;
							dZnvqMK91ZBta4PMAxJ7();
							num3 = ((!bwoJkQK9cIDZ7PyNq9fT()) ? 7 : 3);
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
							case 4:
								awaiter = valueTask.GetAwaiter();
								goto case 2;
							case 0:
							case 3:
								valueTask = viDiELAnomalyDetectTool.wc1DVUnL18();
								num3 = 4;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								return;
							case 2:
							case 7:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (bwoJkQK9cIDZ7PyNq9fT())
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
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
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
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
		internal static bool bwoJkQK9cIDZ7PyNq9fT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dZnvqMK91ZBta4PMAxJ7()
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
	private struct _003CInternalPostParse_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELAnomalyDetectTool _003C_003E4__this;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (y8dlwjK9hFeejwtKPTIG() ? 5 : 3);
			int num2 = default;
			ViDiELAnomalyDetectTool viDiELAnomalyDetectTool = default;
			TaskAwaiter awaiter = default;
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
					viDiELAnomalyDetectTool = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								y8dlwjK9hFeejwtKPTIG();
								num3 = ((!eeExtbK9ubQ5DUi75gpq()) ? 9 : 2);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 15;
								if (1 == 0)
								{
									goto IL_00a0;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 5;
						}
						goto IL_0143;
						IL_00a0:
						_003C_003Eu__1 = default;
						num3 = 10;
						goto IL_0143;
						IL_0143:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 15:
								break;
							case 14:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									if (eeExtbK9ubQ5DUi75gpq())
									{
										continue;
									}
									goto case 12;
								}
								goto case 6;
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (eeExtbK9ubQ5DUi75gpq())
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 0:
							case 2:
								awaiter = oklIZFK9t399UA9delT7(viDiELAnomalyDetectTool.wsoDYi6ia0());
								num3 = 14;
								continue;
							case 6:
							case 9:
								awaiter.GetResult();
								goto case 7;
							default:
								num3 = 7;
								if (eeExtbK9ubQ5DUi75gpq())
								{
									continue;
								}
								goto case 13;
							case 13:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (eeExtbK9ubQ5DUi75gpq())
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = 1);
								num3 = 12;
								continue;
							case 7:
								awaiter = viDiELAnomalyDetectTool.LKpDLRZR5V(cells).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 16;
							case 3:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								goto case 6;
							case 8:
								return;
							case 16:
								awaiter.GetResult();
								goto end_IL_0143;
							}
							goto IL_00a0;
							continue;
							end_IL_0143:
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
		internal static TaskAwaiter oklIZFK9t399UA9delT7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eeExtbK9ubQ5DUi75gpq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y8dlwjK9hFeejwtKPTIG()
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
	private struct _003CAdapterThresholdUpdated_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ViDiELAnomalyDetectTool _003C_003E4__this;

		public ThresholdUpdatedArgs e;

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
			if (KVMEW3K9zVcOr1VKTHuf())
			{
				num = 4;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_01c1;
			IL_01fd:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01c1;
			IL_01c1:
			ViDiELAnomalyDetectTool viDiELAnomalyDetectTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				default:
					num = 2;
					continue;
				case 1:
				case 5:
					viDiELAnomalyDetectTool = _003C_003E4__this;
					num = 3;
					continue;
				case 2:
					goto IL_01fd;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				if (num2 == 0 || !(viDiELAnomalyDetectTool.ToolId != (string)tI0Y0eK4KVpwsMIueACe(e)))
				{
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = viDiELAnomalyDetectTool.wsoDYi6ia0().GetAwaiter();
							_ = 0;
							num3 = ((!KVMEW3K9zVcOr1VKTHuf()) ? 2 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (false)
							{
								goto IL_015f;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (KVMEW3K9zVcOr1VKTHuf())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								if (dVpmD7K4L2VDDWtKuSXA())
								{
								}
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 0:
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 3:
								return;
							case 9:
								break;
							}
							break;
						}
						goto IL_015f;
						IL_015f:
						awaiter.GetResult();
					}
					catch (Exception ex)
					{
						synYxEK4wq6h3HnnG5st(ViDiELEzToolBase.Log, f3PT7EK45maaUwl7uBtr(49510), ex);
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
			goto IL_01fd;
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
		internal static object tI0Y0eK4KVpwsMIueACe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ThresholdUpdatedArgs)P_0).ToolId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object f3PT7EK45maaUwl7uBtr(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void synYxEK4wq6h3HnnG5st(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KVMEW3K9zVcOr1VKTHuf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dVpmD7K4L2VDDWtKuSXA()
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
	private struct _003CRefreshAnomalyThresholdEnable_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELAnomalyDetectTool _003C_003E4__this;

		private TaskAwaiter<IAutoThresholdSettings> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E4I5C7K4JRXpPOCeFaTf();
			int num = (H7HcSqK4aIUYa6thYPfe() ? 4 : 3);
			ViDiELAnomalyDetectTool viDiELAnomalyDetectTool = default;
			int num2 = default;
			IAutoThresholdSettings result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					viDiELAnomalyDetectTool = _003C_003E4__this;
					goto case 2;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<IAutoThresholdSettings> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = viDiELAnomalyDetectTool.UstDziZMwt.GetAutoThresholdSettings(viDiELAnomalyDetectTool.ToolId).GetAwaiter();
							H7HcSqK4aIUYa6thYPfe();
							if (E4I5C7K4JRXpPOCeFaTf())
							{
								num3 = 9;
							}
							else
							{
								num3 = 1;
								if (false)
								{
									goto IL_017f;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_00ee;
						IL_00ee:
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (E4I5C7K4JRXpPOCeFaTf())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 1;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 1:
							case 7:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 5:
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto case 1;
							case 3:
								break;
							case 10:
								viDiELAnomalyDetectTool.IsManualAnomalyThresholdEnabled = !result.UseAutoThreshold;
								goto end_IL_00ee;
							}
							goto IL_017f;
							continue;
							end_IL_00ee:
							break;
						}
						goto end_IL_0065;
						IL_017f:
						_003C_003Eu__1 = awaiter;
						num3 = 2;
						goto IL_00ee;
						end_IL_0065:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 1;
				default:
					num = 1;
					if (false)
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
		internal static bool E4I5C7K4JRXpPOCeFaTf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H7HcSqK4aIUYa6thYPfe()
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
	private struct _003CFocusOnPropertyChanged_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELAnomalyDetectTool _003C_003E4__this;

		public object sender;

		public PropertyChangedEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			ViDiELAnomalyDetectTool viDiELAnomalyDetectTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					viDiELAnomalyDetectTool = _003C_003E4__this;
					goto case 2;
				case 5:
					num2 = _003C_003E1__state;
					yotPUOK4iSfph8LZXBS6();
					if (Wor3KMK4nfXGHeGXQ2s4())
					{
						num = 3;
						break;
					}
					num = 0;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = JVpkXYK4VCpewybNtTnw(viDiELAnomalyDetectTool.PIJDJE0P8q(sender, e));
							num3 = 0;
							goto IL_01a7;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0173;
						IL_0173:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_01a7;
						IL_01a7:
						while (true)
						{
							switch (num3)
							{
							case 5:
								num2 = (_003C_003E1__state = -1);
								goto case 7;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 4;
								}
								goto case 7;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 11;
								continue;
							case 6:
							{
								EventHandler eventHandler = viDiELAnomalyDetectTool.XAR3as3j9o;
								if (eventHandler == null)
								{
									num3 = 1;
									continue;
								}
								eventHandler(sender, e);
								num3 = 12;
								continue;
							}
							case 7:
							case 8:
								awaiter.GetResult();
								if (c87t65K4dF81YYAMJGZs(e.PropertyName, GtLY9MK4f48FUcyQCRmf(5436)))
								{
									num3 = 6;
									continue;
								}
								goto end_IL_01a7;
							case 3:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 11:
								_003C_003Eu__1 = awaiter;
								Wor3KMK4nfXGHeGXQ2s4();
								num3 = (yotPUOK4iSfph8LZXBS6() ? 9 : 8);
								continue;
							case 2:
								break;
							case 10:
								return;
							default:
								num3 = 2;
								continue;
							case 1:
							case 12:
								viDiELAnomalyDetectTool.GV2D0E1Lxa();
								goto end_IL_01a7;
							}
							goto IL_0173;
							continue;
							end_IL_01a7:
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
					if (!yotPUOK4iSfph8LZXBS6())
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
		internal static TaskAwaiter JVpkXYK4VCpewybNtTnw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GtLY9MK4f48FUcyQCRmf(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c87t65K4dF81YYAMJGZs(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yotPUOK4iSfph8LZXBS6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Wor3KMK4nfXGHeGXQ2s4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private EZBAnomalyDetectAdapter UstDziZMwt;

	[CompilerGenerated]
	private EventHandler XAR3as3j9o;

	[CompilerGenerated]
	private EditRegionViewModel eC035evW9f;

	[CompilerGenerated]
	private IntViewModel ebb3phasaT;

	[CompilerGenerated]
	private EditIntViewModel wOH3Ulp4Hk;

	private bool GZi372jPNk;

	[CompilerGenerated]
	private StringViewModel DBr3NBYFdQ;

	[CompilerGenerated]
	private FloatViewModel xdB3AbIkIv;

	[CompilerGenerated]
	private ImageViewModel YRs3dq2b5V;

	private bool TNB365MQl3;

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_AnomalyDetectIcon;
		}
	}

	public EditRegionViewModel Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eC035evW9f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eC035evW9f = value;
		}
	}

	public IntViewModel AnomalyThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ebb3phasaT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ebb3phasaT = value;
		}
	}

	public EditIntViewModel ManualAnomalyThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wOH3Ulp4Hk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wOH3Ulp4Hk = value;
		}
	}

	public bool IsManualAnomalyThresholdEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GZi372jPNk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref GZi372jPNk, value, (string)KtnP6tBHgi8tUO03Qs1(8814));
		}
	}

	public StringViewModel ClassLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DBr3NBYFdQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DBr3NBYFdQ = value;
		}
	}

	public FloatViewModel AnomalyScore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xdB3AbIkIv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xdB3AbIkIv = value;
		}
	}

	public ImageViewModel OutputMask
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YRs3dq2b5V;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YRs3dq2b5V = value;
		}
	}

	public override bool ShowHelp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TNB365MQl3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref TNB365MQl3, value, (string)KtnP6tBHgi8tUO03Qs1(6502));
		}
	}

	public event EventHandler FocusChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (iThUBdBF4nba1gjRlCP() ? 1 : 2);
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto case 6;
				default:
					num = 6;
					break;
				case 0:
				case 1:
					eventHandler = XAR3as3j9o;
					num = 3;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (!nVTDfMBMFtlSEsbyWTt())
						{
							break;
						}
					}
					goto case 3;
				case 3:
					eventHandler2 = eventHandler;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				case 6:
					eventHandler = Interlocked.CompareExchange(ref XAR3as3j9o, value2, eventHandler2);
					goto case 2;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						if (0 == 0)
						{
							continue;
						}
						goto case 4;
					}
					goto case 0;
				case 4:
					eventHandler2 = XAR3as3j9o;
					_ = 1;
					num = (nVTDfMBMFtlSEsbyWTt() ? 5 : 0);
					continue;
				case 2:
					value2 = (EventHandler)gSTn1WBY78lBbq7Lx6O(eventHandler, value);
					break;
				case 0:
				case 1:
					eventHandler = eventHandler2;
					num = 2;
					continue;
				case 7:
					return;
				}
				eventHandler2 = Interlocked.CompareExchange(ref XAR3as3j9o, value2, eventHandler);
				num = 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELAnomalyDetectTool(InspectStepViewModel inspect, bool isInitialized, EZBAnomalyDetectAdapter adapter, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nVTDfMBMFtlSEsbyWTt();
		int num;
		if (iThUBdBF4nba1gjRlCP())
		{
			num = 7;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_0057;
			}
		}
		goto IL_007f;
		IL_007f:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			case 3:
				TNB365MQl3 = true;
				break;
			case 0:
			case 7:
				goto IL_0057;
			case 1:
				UstDziZMwt = adapter;
				goto case 4;
			default:
				num = 4;
				continue;
			case 4:
				ViDiELEzToolBase.Log = LogManager.GetLogger<ViDiELAnomalyDetectTool>();
				num = 6;
				continue;
			case 6:
				UstDziZMwt.ThresholdUpdated += tARDtHXurS;
				num = 8;
				if (true)
				{
					continue;
				}
				return;
			case 8:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_0057:
		WHxW5eBU61CQTHm2EiM();
		num = 3;
		goto IL_007f;
		IL_002a:
		base._002Ector(inspect, isInitialized, localizer);
		num = 1;
		goto IL_007f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__5))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nVTDfMBMFtlSEsbyWTt();
		int num;
		if (iThUBdBF4nba1gjRlCP())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_0046;
			}
		}
		goto IL_0060;
		IL_008b:
		_003CDisposeAsync_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0060;
		IL_0046:
		stateMachine._003C_003E1__state = -1;
		goto IL_008b;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
				goto case 1;
			case 5:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_008b;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0046;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 19;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				return;
			case 23:
				return;
			case 4:
				AddProperty(ClassLabel);
				num = 13;
				if (!nVTDfMBMFtlSEsbyWTt())
				{
					break;
				}
				goto case 21;
			case 21:
				AddProperty(AnomalyScore);
				num = 2;
				if (nVTDfMBMFtlSEsbyWTt())
				{
					return;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 16:
				return;
			case 17:
				return;
			case 9:
				return;
			case 20:
				AddProperty(OutputMask);
				num = 9;
				break;
			case 19:
				num2 = _003CPrivateImplementationDetails_003E.ComputeStringHash(relativeCellName);
				_ = 1;
				if (!nVTDfMBMFtlSEsbyWTt())
				{
					num = 22;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				}
				num = 6;
				break;
			case 3:
			case 6:
				if (num2 == 861558077)
				{
					if (!(relativeCellName == (string)KtnP6tBHgi8tUO03Qs1(8730)))
					{
						return;
					}
					AnomalyThreshold = new IntViewModel(InSight, cells, loc, Resources.AnomalyThreshold);
					num = 7;
				}
				else
				{
					num = 5;
				}
				break;
			case 12:
				return;
			case 1:
			case 22:
				if (num2 > 1227782301)
				{
					if (num2 <= 1518639540)
					{
						if (num2 == 1386820839)
						{
							if (xMXQTsBxRPWtDagSH8L(relativeCellName, KtnP6tBHgi8tUO03Qs1(8766)))
							{
								ManualAnomalyThreshold = new EditIntViewModel(InSight, cells, loc, (string)wgRp8BBc4oRa8FDJYSu());
								num = 24;
							}
							else
							{
								num = 8;
							}
						}
						else
						{
							num = 14;
						}
						break;
					}
					if (num2 != 1967271812)
					{
						if (num2 == 4136732135u && relativeCellName == (string)KtnP6tBHgi8tUO03Qs1(8654))
						{
							ClassLabel = new StringViewModel(InSight, cells, loc, (string)YxLlBWBNA21Ch0K7LP5());
							num = 4;
							break;
						}
						return;
					}
					if (xMXQTsBxRPWtDagSH8L(relativeCellName, KtnP6tBHgi8tUO03Qs1(8612)))
					{
						ELFunctionCellLocation = loc;
						return;
					}
					num = 16;
					if (iThUBdBF4nba1gjRlCP())
					{
						break;
					}
					goto case 5;
				}
				num = 18;
				break;
			case 15:
				AddProperty(Region);
				num = 0;
				break;
			case 8:
				return;
			default:
				num = 15;
				break;
			case 7:
				AddProperty(AnomalyThreshold);
				num = 10;
				break;
			case 18:
				if (num2 != 682445656)
				{
					goto case 3;
				}
				if (xMXQTsBxRPWtDagSH8L(relativeCellName, KtnP6tBHgi8tUO03Qs1(8678)))
				{
					AnomalyScore = new FloatViewModel(InSight, cells, loc, Resources.AnomalyScore);
					num = 21;
				}
				else
				{
					num = 12;
				}
				break;
			case 13:
				return;
			case 14:
				if (num2 == 1518639540)
				{
					if (xMXQTsBxRPWtDagSH8L(relativeCellName, KtnP6tBHgi8tUO03Qs1(8706)))
					{
						OutputMask = new ImageViewModel(InSight, cells, loc, (string)dAeUSBB2cEAneM6Bbve());
						num = 20;
					}
					else
					{
						num = 23;
					}
					break;
				}
				return;
			case 5:
				if (num2 == 1227782301)
				{
					if (!xMXQTsBxRPWtDagSH8L(relativeCellName, KtnP6tBHgi8tUO03Qs1(5684)))
					{
						num = 11;
						if (false)
						{
							return;
						}
						break;
					}
					Region = new EditRegionViewModel(InSight, cells, loc, (string)UyvEl4BmeM0v5PCc65x(), NiaNC1BQBYHixi9u0ly(InputImage));
					goto case 15;
				}
				num = 17;
				break;
			case 11:
				return;
			case 24:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__9))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nVTDfMBMFtlSEsbyWTt();
		int num = ((!iThUBdBF4nba1gjRlCP()) ? 1 : 5);
		_003CInternalPostParse_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = XY5gfiB1DDmQjo4v6CH();
				num = 3;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
			case 2:
				stateMachine.cells = cells;
				goto case 6;
			default:
				num = 6;
				if (iThUBdBF4nba1gjRlCP())
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitializeAdditionalHelp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AdditionalHelpText = new List<ExtraHelpText>
		{
			new ExtraHelpText((string)Y1uu1JBuJBDbKZ0Gtv9(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)cc7nlABhXIAcsWCW6qI(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)FXW7PjBt5iYLYf9ws2w(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)BjMEhmBz91nQEEOgelI(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)TdGwWLbLBFARNAhxyDd(), DisplayHelpTextType.IndentedHeader),
			new ExtraHelpText((string)oFY69ObKTUTmCESkxFg(), DisplayHelpTextType.Indented),
			new ExtraHelpText((string)tASFFWb5cRMAsGYc3vP(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)QAWxThbwniifOgH3hYo(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)TsOUlXbJO6mcyTNijS5(), DisplayHelpTextType.Header),
			new ExtraHelpText(Resources.TDk8EPPKq4(), DisplayHelpTextType.Paragraph)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAdapterThresholdUpdated_003Ed__27))]
	private void tARDtHXurS(object P_0, ThresholdUpdatedArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CAdapterThresholdUpdated_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E4__this = this;
				nVTDfMBMFtlSEsbyWTt();
				num = (iThUBdBF4nba1gjRlCP() ? 1 : 0);
				break;
			case 1:
			case 2:
				stateMachine.e = P_1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 4:
				stateMachine._003C_003Et__builder = eBaxxtbautWXmsqsDK1();
				num = 6;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshAnomalyThresholdEnable_003Ed__28))]
	private Task wsoDYi6ia0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (iThUBdBF4nba1gjRlCP())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_005a;
			}
		}
		goto IL_0074;
		IL_005a:
		_003CRefreshAnomalyThresholdEnable_003Ed__28 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0024;
		IL_0024:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = XY5gfiB1DDmQjo4v6CH();
				goto case 1;
			case 3:
				goto IL_005a;
			default:
				num = 2;
				if (iThUBdBF4nba1gjRlCP())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0024;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsEditableDisplayGraphic[1] { Region?.Graphic }.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g != null;
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFocusOnPropertyChanged_003Ed__42))]
	protected override Task FocusOnPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!iThUBdBF4nba1gjRlCP())
		{
			goto IL_001e;
		}
		goto IL_0098;
		IL_003a:
		_003CFocusOnPropertyChanged_003Ed__42 stateMachine = default;
		stateMachine.sender = sender;
		_ = 1;
		if (!nVTDfMBMFtlSEsbyWTt())
		{
			num = 5;
			if (false)
			{
				goto IL_005a;
			}
		}
		else
		{
			num = 7;
		}
		goto IL_0098;
		IL_0098:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
				goto IL_003a;
			default:
				goto IL_005a;
			case 0:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 3:
			case 5:
				stateMachine.e = e;
				goto IL_005a;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_005a:
		stateMachine._003C_003E1__state = -1;
		num = 6;
		goto IL_0098;
		IL_001e:
		stateMachine._003C_003Et__builder = XY5gfiB1DDmQjo4v6CH();
		num = 0;
		if (nVTDfMBMFtlSEsbyWTt())
		{
			goto IL_003a;
		}
		goto IL_0098;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateOnEditModeChange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GV2D0E1Lxa();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GV2D0E1Lxa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				s321DIbOGrxFcrTMWHj(UstDziZMwt, ToolId);
				goto default;
			default:
				nVTDfMBMFtlSEsbyWTt();
				if (iThUBdBF4nba1gjRlCP())
				{
					num = 5;
					if (true)
					{
						break;
					}
					goto case 3;
				}
				num = 6;
				break;
			case 3:
			case 5:
				MainViewModel = this;
				return;
			case 4:
				return;
			case 1:
				if (IsInSnippetEditMode)
				{
					num = 0;
					break;
				}
				goto IL_00a9;
			case 6:
				return;
			case 2:
				if (JnaXF5be3MHQaKi6syv(Focus))
				{
					num = 1;
					break;
				}
				goto IL_00a9;
			case 7:
				return;
				IL_00a9:
				MainViewModel = null;
				num = 7;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask wc1DVUnL18()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task LKpDLRZR5V(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task PIJDJE0P8q(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.FocusOnPropertyChanged(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iThUBdBF4nba1gjRlCP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nVTDfMBMFtlSEsbyWTt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gSTn1WBY78lBbq7Lx6O(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WHxW5eBU61CQTHm2EiM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KtnP6tBHgi8tUO03Qs1(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xMXQTsBxRPWtDagSH8L(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UyvEl4BmeM0v5PCc65x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation NiaNC1BQBYHixi9u0ly(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YxLlBWBNA21Ch0K7LP5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ClassLabel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dAeUSBB2cEAneM6Bbve()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputMask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wgRp8BBc4oRa8FDJYSu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AnomalyThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder XY5gfiB1DDmQjo4v6CH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y1uu1JBuJBDbKZ0Gtv9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.J1c8IvyHmP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cc7nlABhXIAcsWCW6qI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cOs8D7emqj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FXW7PjBt5iYLYf9ws2w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ohi86RGwKB();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BjMEhmBz91nQEEOgelI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SSE8AkqIlE();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TdGwWLbLBFARNAhxyDd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.z1x8o46XSe();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oFY69ObKTUTmCESkxFg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Wyo8FvYa08();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tASFFWb5cRMAsGYc3vP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.jav87qd4vk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QAWxThbwniifOgH3hYo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Gb68pEw6rg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TsOUlXbJO6mcyTNijS5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.P268c0x0qO();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder eBaxxtbautWXmsqsDK1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JnaXF5be3MHQaKi6syv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InternalCheckBoxViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s321DIbOGrxFcrTMWHj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AnomalyDetectAdapterBase)P_0).OnNewResult((string)P_1);
	}
}
