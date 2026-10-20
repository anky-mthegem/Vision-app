using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using Cognex.AnomalyDetector.Client;
using Cognex.AnomalyDetector.Client.Tool;
using Cognex.AnomalyDetector.Client.Tool.Interfaces;
using Cognex.Foundations.Mvvm.Common;
using Cognex.InSight.Remoting.Serialization.ViDiEL.AnomalyDetect;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.Utils;
using Cognex.Mvvm;
using Cognex.WebToolEditControl.Core;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.AnomalyDetect;

public abstract class AnomalyDetectAdapterBase : ViDiELAdapterBase, IAnomalyDetectorAdapter
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public AnomalyDetectAdapterBase _003C_003E4__this;

		public NewResultArgs args;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass23_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			difuvUQtW6vhSMNkwSy();
			aBiV8YQ91ACreAQMhXp(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003COnNewResult_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003E4__this.YcUV9LCeSG?.Invoke(_003C_003E4__this, args);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void difuvUQtW6vhSMNkwSy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aBiV8YQ91ACreAQMhXp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Mee8ZHQiVtSWbHWxvoH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S8tMJIQLMvBsOiCwTPW()
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
	private struct _003CDeleteSamples_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public ICollection<string> sampleIds;

		private CancellationToken _003Ctoken_003E5__2;

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
			if (YmE8oIQvav0I4Q8aXjR())
			{
				num = 5;
				if (!YmE8oIQvav0I4Q8aXjR())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_02d9;
			IL_002a:
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = _003C_003E4__this;
			num = 1;
			goto IL_02d9;
			IL_02d9:
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 3;
								if (!YmE8oIQvav0I4Q8aXjR())
								{
									goto IL_0058;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
							}
							goto IL_008c;
						}
						awaiter = _003C_003Eu__1;
						goto IL_006e;
						IL_008c:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 7:
							case 13:
								goto IL_006e;
							default:
								num3 = 11;
								if (YmE8oIQvav0I4Q8aXjR())
								{
									continue;
								}
								goto IL_00ed;
							case 11:
								goto IL_00ed;
							case 4:
							case 12:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 0;
									if (!lsYg1oQZT5Zg2JDf8qI())
									{
										continue;
									}
									goto case 5;
								}
								goto case 9;
							case 5:
								awaiter = anomalyDetectAdapterBase.HKdVMY9U7e(toolId, sampleIds, _003Ctoken_003E5__2).GetAwaiter();
								YmE8oIQvav0I4Q8aXjR();
								num3 = (lsYg1oQZT5Zg2JDf8qI() ? 13 : 12);
								continue;
							case 16:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 1:
								return;
							case 3:
								anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
								num3 = 10;
								if (lsYg1oQZT5Zg2JDf8qI())
								{
								}
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
								_003Ctoken_003E5__2 = mFh4ASQ0QYEA3FOn3mU(anomalyDetectAdapterBase.CancellationSource);
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 15;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 14:
								if (!awaiter.IsCompleted)
								{
									num3 = 16;
									continue;
								}
								goto case 18;
							case 0:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								if (YmE8oIQvav0I4Q8aXjR())
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								num3 = 17;
								if (true)
								{
									continue;
								}
								goto case 17;
							case 17:
								awaiter = anomalyDetectAdapterBase.TrainAsync(toolId, _003Ctoken_003E5__2).GetAwaiter();
								num3 = 14;
								continue;
							case 10:
								anomalyDetectAdapterBase.ClearCaches(toolId);
								num3 = 8;
								continue;
							case 18:
								awaiter.GetResult();
								goto end_IL_003b;
							}
							break;
						}
						goto IL_0058;
						IL_0058:
						_003C_003Eu__1 = default;
						num3 = 15;
						goto IL_008c;
						IL_006e:
						_003C_003Eu__1 = default;
						goto IL_00ed;
						IL_00ed:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_008c;
						end_IL_003b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctoken_003E5__2 = default;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 6:
					_003C_003Et__builder.SetResult();
					num = 7;
					continue;
				default:
					_003Ctoken_003E5__2 = default;
					num = 6;
					continue;
				case 7:
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
		internal static CancellationToken mFh4ASQ0QYEA3FOn3mU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YmE8oIQvav0I4Q8aXjR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lsYg1oQZT5Zg2JDf8qI()
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
	private struct _003CGetAutoThresholdSettings_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IAutoThresholdSettings> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELAnomalyDetectorAutoThresholdSettings> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tDBC47QHC746vUSRaxU();
			int num = ((!EW3KFAQOMKmHDlCr9T2()) ? 3 : 2);
			int num2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			IAutoThresholdSettings result2 = default;
			TaskAwaiter<ELAnomalyDetectorAutoThresholdSettings> awaiter = default;
			ELAnomalyDetectorAutoThresholdSettings result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 4;
					break;
				case 5:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							EW3KFAQOMKmHDlCr9T2();
							num3 = ((!tDBC47QHC746vUSRaxU()) ? 9 : 3);
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 9:
								_003C_003Eu__1 = default;
								goto case 3;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 0:
								return;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (EW3KFAQOMKmHDlCr9T2())
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 2:
								awaiter = ((AnomalyDetectToolApi)QdYmQjQT97qa4QqwgRP(anomalyDetectAdapterBase, toolId)).GetAutoThresholdSettings().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									if (true)
									{
										continue;
									}
								}
								goto case 7;
							case 7:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 3:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 10:
							{
								AnomalyDetectAutoThresholdSettings anomalyDetectAutoThresholdSettings = new AnomalyDetectAutoThresholdSettings();
								i2gQ8FQJRbnb38yXYFS(anomalyDetectAutoThresholdSettings, OhUifTQYGhKFaepxMOB(result));
								TrgbA6QCHNoTBwdErQO(anomalyDetectAutoThresholdSettings, (AutoThresholdOptions)icAH6AQKqSqKA01DP9S(result));
								result2 = anomalyDetectAutoThresholdSettings;
								break;
							}
							}
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
					goto case 5;
				default:
					num = 5;
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
		internal static object QdYmQjQT97qa4QqwgRP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OhUifTQYGhKFaepxMOB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorAutoThresholdSettings)P_0).UseAutoThreshold;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void i2gQ8FQJRbnb38yXYFS(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectAutoThresholdSettings)P_0).UseAutoThreshold = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int icAH6AQKqSqKA01DP9S(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorAutoThresholdSettings)P_0).SelectedOption;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TrgbA6QCHNoTBwdErQO(object P_0, AutoThresholdOptions value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectAutoThresholdSettings)P_0).SelectedOption = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EW3KFAQOMKmHDlCr9T2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tDBC47QHC746vUSRaxU()
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
	private struct _003CGetResult_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IAnomalyDetectorResult> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<AnomalyDetectorResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			TaskAwaiter<AnomalyDetectorResult> awaiter = default;
			IAnomalyDetectorResult result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (1 == 0)
							{
								goto IL_012c;
							}
						}
						goto IL_00d9;
						IL_015a:
						result = awaiter.GetResult();
						goto end_IL_0018;
						IL_012c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						VWEfEbQAxn8ZRLTVdE1();
						if (OSU4sjQNuKW8k3WqQEU())
						{
							num3 = 6;
						}
						else
						{
							num3 = 1;
							if (!VWEfEbQAxn8ZRLTVdE1())
							{
								goto IL_015a;
							}
						}
						goto IL_00d9;
						IL_00d9:
						while (true)
						{
							switch (num3)
							{
							case 3:
								awaiter = anomalyDetectAdapterBase.px6VvCVbRJ.GetResultAsync(toolId, anomalyDetectAdapterBase.CancellationSource.Token).GetAwaiter();
								num3 = 2;
								if (VWEfEbQAxn8ZRLTVdE1())
								{
									continue;
								}
								goto case 6;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								goto case 6;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 9;
								}
								goto IL_015a;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								break;
							default:
								num3 = 8;
								continue;
							case 1:
							case 5:
								return;
							case 8:
								break;
							case 10:
								goto IL_015a;
							}
							break;
						}
						goto IL_012c;
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
					anomalyDetectAdapterBase = _003C_003E4__this;
					OSU4sjQNuKW8k3WqQEU();
					num = ((!VWEfEbQAxn8ZRLTVdE1()) ? 1 : 5);
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					if (!VWEfEbQAxn8ZRLTVdE1())
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
		internal static bool VWEfEbQAxn8ZRLTVdE1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OSU4sjQNuKW8k3WqQEU()
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
	private struct _003CGetSample_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IAnomalyDetectorSample> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public string sampleId;

		public bool metadataOnly;

		private ResourceNode _003CtoolNode_003E5__2;

		private AnomalyDetectSample _003CfoundSample_003E5__3;

		private TaskAwaiter<Dictionary<string, AnomalyDetectSample>> _003C_003Eu__1;

		private AnomalyDetectSample _003C_003E7__wrap3;

		private AnomalyDetectSample _003C_003E7__wrap4;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			TaskAwaiter<string> awaiter = default;
			TaskAwaiter<Dictionary<string, AnomalyDetectSample>> awaiter2 = default;
			IAnomalyDetectorSample result = default;
			AnomalyDetectSample anomalyDetectSample = default;
			int num2 = default;
			string text = default;
			AnomalyDetectSample value = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 4;
					if (true)
					{
						break;
					}
					goto case 6;
				case 6:
					_003CtoolNode_003E5__2 = null;
					goto case 7;
				default:
					num = 7;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 2;
								if (1 == 0)
								{
									goto IL_0090;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 12;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_03f6;
						IL_0090:
						_003C_003E7__wrap4 = new AnomalyDetectSample();
						num3 = 31;
						goto IL_03f6;
						IL_03f6:
						while (true)
						{
							switch (num3)
							{
							case 17:
								break;
							case 23:
								result = anomalyDetectSample;
								num3 = 10;
								continue;
							case 18:
								_003C_003E7__wrap4.Date = VdDev6Ql8iVVfeCdOm8(_003CfoundSample_003E5__3);
								num3 = 11;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 28:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto case 8;
							case 21:
								goto end_IL_03f6;
							case 13:
								anomalyDetectAdapterBase.YARVdRkZrx.Add(toolId, new Dictionary<string, AnomalyDetectSample> { { sampleId, anomalyDetectSample } });
								num3 = 27;
								continue;
							case 2:
								anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
								num3 = 30;
								continue;
							case 8:
								text = awaiter.GetResult();
								goto case 15;
							case 15:
								bY6TOpQbwBPyWktCPhI(_003C_003E7__wrap3, text);
								num3 = 24;
								continue;
							case 24:
								_003C_003E7__wrap4.Label = iS0BB1QeNyAN2mTmyHv(_003CfoundSample_003E5__3);
								num3 = 18;
								if (!vcWMVWQph9CnEFUeXE8())
								{
									continue;
								}
								goto case 20;
							case 20:
								if (!awaiter2.IsCompleted)
								{
									num3 = 29;
									continue;
								}
								goto case 16;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 1:
								_003C_003E7__wrap3 = null;
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto end_IL_03f6;
							case 10:
								goto end_IL_03f6;
							case 14:
							case 19:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								if (yEjEayQw56ROWEkOdM1())
								{
									continue;
								}
								return;
							case 25:
								return;
							case 16:
								if (awaiter2.GetResult().TryGetValue(sampleId, out _003CfoundSample_003E5__3))
								{
									num3 = 17;
									if (0 == 0)
									{
										continue;
									}
									goto case 30;
								}
								result = null;
								goto end_IL_03f6;
							case 30:
							{
								if (!anomalyDetectAdapterBase.YARVdRkZrx.TryGetValue(toolId, out var value2) || !value2.TryGetValue(sampleId, out value))
								{
									_003CtoolNode_003E5__2 = (ResourceNode)wDP12pQGMoexyZ511xd(anomalyDetectAdapterBase, toolId);
									_ = 1;
									if (!vcWMVWQph9CnEFUeXE8())
									{
										num3 = 3;
										if (yEjEayQw56ROWEkOdM1())
										{
											continue;
										}
										goto case 13;
									}
									num3 = 14;
									continue;
								}
								num3 = 26;
								continue;
							}
							case 11:
								anomalyDetectSample = _003C_003E7__wrap4;
								num3 = 1;
								continue;
							case 0:
								_003C_003E7__wrap4 = null;
								if (!metadataOnly)
								{
									if (!anomalyDetectAdapterBase.YARVdRkZrx.ContainsKey(toolId))
									{
										num3 = 13;
										continue;
									}
									anomalyDetectAdapterBase.YARVdRkZrx[toolId][sampleId] = anomalyDetectSample;
									goto case 27;
								}
								num3 = 23;
								continue;
							case 31:
								gKpeOnQI2SVHMglCgqB(_003C_003E7__wrap4, n2lY7GQj5Hw9035Rofw(_003CfoundSample_003E5__3));
								num3 = 7;
								continue;
							case 27:
								result = anomalyDetectSample;
								num3 = 32;
								continue;
							case 22:
								_003C_003E7__wrap3 = _003C_003E7__wrap4;
								if (!metadataOnly)
								{
									awaiter = anomalyDetectAdapterBase.idcVpkVXoj(_003CfoundSample_003E5__3.ImageUrl, _003CtoolNode_003E5__2).GetAwaiter();
									num3 = 28;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								}
								text = null;
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 29;
							case 29:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 9;
								continue;
							case 7:
								UMOs7rQWWGAVKdor6uW(_003C_003E7__wrap4, _003CfoundSample_003E5__3.ImageUrl);
								goto case 22;
							default:
								num3 = 22;
								continue;
							case 26:
								result = value;
								num3 = 21;
								continue;
							case 3:
							case 4:
								awaiter2 = anomalyDetectAdapterBase.DBeVLXdNet.GetResultAsync(toolId, oP9JmSQRhf2uHBHYvgZ(anomalyDetectAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 20;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 25;
								continue;
							case 12:
								_003C_003Eu__2 = default;
								goto case 14;
							case 32:
								goto end_IL_03f6;
							}
							goto IL_0090;
							continue;
							end_IL_03f6:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CtoolNode_003E5__2 = null;
						_003CfoundSample_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 6;
					break;
				case 0:
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 8;
					break;
				case 7:
					_003CfoundSample_003E5__3 = null;
					goto case 0;
				case 3:
					num2 = _003C_003E1__state;
					vcWMVWQph9CnEFUeXE8();
					num = (yEjEayQw56ROWEkOdM1() ? 2 : 0);
					break;
				case 8:
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
		internal static object wDP12pQGMoexyZ511xd(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken oP9JmSQRhf2uHBHYvgZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object n2lY7GQj5Hw9035Rofw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectSample)P_0).Id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gKpeOnQI2SVHMglCgqB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectSample)P_0).Id = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UMOs7rQWWGAVKdor6uW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectSample)P_0).ImageUrl = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bY6TOpQbwBPyWktCPhI(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectSample)P_0).Image = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AnomalyDetectorLabels iS0BB1QeNyAN2mTmyHv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectSample)P_0).Label;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long VdDev6Ql8iVVfeCdOm8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectSample)P_0).Date;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yEjEayQw56ROWEkOdM1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vcWMVWQph9CnEFUeXE8()
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
	private struct _003CGetSamples_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ICollection<IAnomalyDetectorSample>> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public int imageSize;

		private TaskAwaiter<Dictionary<string, AnomalyDetectSample>> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			ICollection<IAnomalyDetectorSample> result = default;
			int num2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			TaskAwaiter<Dictionary<string, AnomalyDetectSample>> awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 8;
							if (1 == 0)
							{
								goto IL_004c;
							}
							goto IL_010d;
						}
						awaiter = _003C_003Eu__1;
						goto IL_005f;
						IL_005f:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_010d;
						IL_010d:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 2:
							case 6:
								goto IL_005f;
							case 9:
								awaiter = anomalyDetectAdapterBase.DBeVLXdNet.GetResultAsync(toolId, bjNL8OQn9CQwkhR8SPY(anomalyDetectAdapterBase.CancellationSource)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 10;
							case 8:
								anomalyDetectAdapterBase.v5dV5hbBig = imageSize;
								num3 = 9;
								continue;
							case 5:
							case 7:
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							default:
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 0;
								if (!xpYgDHQ7YYKRwy2iCey())
								{
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
									goto case 4;
								}
								num3 = 7;
								continue;
							case 10:
								result = ((IEnumerable<IAnomalyDetectorSample>)awaiter.GetResult().Values).ToList();
								goto end_IL_002e;
							}
							break;
						}
						goto IL_004c;
						IL_004c:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						goto IL_010d;
						end_IL_002e:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					anomalyDetectAdapterBase = _003C_003E4__this;
					_ = 1;
					num = ((!rKr0EqQygwPjY6GFnBd()) ? 1 : 0);
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
		internal static CancellationToken bjNL8OQn9CQwkhR8SPY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xpYgDHQ7YYKRwy2iCey()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rKr0EqQygwPjY6GFnBd()
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
	private struct _003CGetStats_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IAnomalyDetectorStats> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<AnomalyDetectStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XwB11LQfrCIRV9ZWkgv();
			int num = (uLfkYEQziGCie62qEgo() ? 2 : 5);
			int num2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			TaskAwaiter<AnomalyDetectStats> awaiter = default;
			IAnomalyDetectorStats result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 5;
							goto IL_008e;
						}
						awaiter = _003C_003Eu__1;
						goto IL_011a;
						IL_011a:
						_003C_003Eu__1 = default;
						num3 = 9;
						if (uLfkYEQziGCie62qEgo())
						{
						}
						goto IL_008e;
						IL_008e:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (!uLfkYEQziGCie62qEgo())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								awaiter = anomalyDetectAdapterBase.P1xV0tQjEG.GetResultAsync(toolId, YZuf9Mq2FpJp4v0g9kH(anomalyDetectAdapterBase.CancellationSource)).GetAwaiter();
								_ = 1;
								if (!uLfkYEQziGCie62qEgo())
								{
									num3 = 2;
									if (!uLfkYEQziGCie62qEgo())
									{
										continue;
									}
									break;
								}
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 4:
							case 6:
								break;
							case 0:
								return;
							case 1:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_008e;
							}
							goto IL_011a;
							continue;
							end_IL_008e:
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
					num = 3;
					continue;
				case 1:
				case 2:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 4;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
				if (uLfkYEQziGCie62qEgo())
				{
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
		internal static CancellationToken YZuf9Mq2FpJp4v0g9kH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XwB11LQfrCIRV9ZWkgv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uLfkYEQziGCie62qEgo()
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
	private struct _003CGetScaledThreshold_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<float> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<float> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gLbUEZqXvLb69MCRm4M();
			int num = ((!KGyqUmqM8JX0ZcgvVeY()) ? 1 : 3);
			int num2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			TaskAwaiter<float> awaiter = default;
			float result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 4;
							goto IL_0120;
						}
						awaiter = _003C_003Eu__1;
						goto IL_005c;
						IL_005c:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_0120;
						IL_0120:
						while (true)
						{
							switch (num3)
							{
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 2:
							case 6:
								break;
							case 4:
								awaiter = anomalyDetectAdapterBase.GetTool(toolId).GetScaledThreshold().GetAwaiter();
								num3 = 1;
								if (KGyqUmqM8JX0ZcgvVeY())
								{
								}
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								KGyqUmqM8JX0ZcgvVeY();
								if (gLbUEZqXvLb69MCRm4M())
								{
									num3 = 8;
									if (false)
									{
										return;
									}
								}
								else
								{
									num3 = 2;
								}
								continue;
							case 0:
								return;
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0120;
							}
							goto IL_005c;
							continue;
							end_IL_0120:
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
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					anomalyDetectAdapterBase = _003C_003E4__this;
					goto case 2;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static bool gLbUEZqXvLb69MCRm4M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KGyqUmqM8JX0ZcgvVeY()
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
	private struct _003CLabelImage_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public string sampleId;

		public AnomalyDetectorLabels label;

		private AnomalyDetectToolApi _003Ctool_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<ELAnomalyDetectorModelStats> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0442;
			IL_0031:
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			int num2 = default;
			try
			{
				TaskAwaiter<bool> awaiter;
				switch (num2)
				{
				default:
					anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
					_003Ctool_003E5__2 = (AnomalyDetectToolApi)JT0lgfqrR2QFw0oXmlh(anomalyDetectAdapterBase, toolId);
					anomalyDetectAdapterBase.ClearCaches(toolId);
					anomalyDetectAdapterBase.CancellationSource.Token.ThrowIfCancellationRequested();
					_003C_003E7__wrap3 = 0;
					goto case 0;
				case 0:
				case 1:
				case 2:
				case 3:
				{
					try
					{
						TaskAwaiter<ELAnomalyDetectorModelStats> awaiter3;
						TaskAwaiter awaiter2;
						ELAnomalyDetectorModelStats result;
						switch (num2)
						{
						default:
							if (TdANyrqPkWeNThGSiyM(sampleId))
							{
								awaiter3 = _003Ctool_003E5__2.GetModelStats().GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0119;
							}
							awaiter2 = SMCUBPqS0BkgOaq7ZSy(_003Ctool_003E5__2.LabelImage(sampleId, label));
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_021a;
						case 0:
							awaiter3 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0119;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01a3;
						case 2:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_021a;
						case 3:
							{
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_021a:
							awaiter2.GetResult();
							goto IL_0221;
							IL_01a3:
							awaiter2.GetResult();
							goto IL_0221;
							IL_0119:
							result = awaiter3.GetResult();
							if ((double)FbLpvlq46am7duPpoQh(result) >= vogCLlqgrcNyVPJYP1p(result))
							{
								throw new InvalidOperationException((string)Qi8cIKq1dUtAEUHi2mg());
							}
							awaiter2 = SMCUBPqS0BkgOaq7ZSy(_003Ctool_003E5__2.LabelCurrentImage(label));
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01a3;
							IL_0221:
							awaiter2 = SMCUBPqS0BkgOaq7ZSy(anomalyDetectAdapterBase.TrainAsync(toolId, anomalyDetectAdapterBase.CancellationSource.Token));
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							break;
						}
						awaiter2.GetResult();
					}
					catch (CvsHttpNetworkException ex)
					{
						_003C_003E7__wrap2 = ex;
						_003C_003E7__wrap3 = 1;
					}
					catch (Exception ex2)
					{
						_003C_003E7__wrap2 = ex2;
						_003C_003E7__wrap3 = 2;
					}
					int num3 = _003C_003E7__wrap3;
					if (num3 != 1)
					{
						if (num3 != 2)
						{
							break;
						}
						Exception ex3 = (Exception)_003C_003E7__wrap2;
						object broadcaster = x0KR6Cq6dJEdwO7OJHN();
						ErrorMessageViewModel errorMessageViewModel = new ErrorMessageViewModel
						{
							Heading = (string)hJTUxyqDB4no6Fj9K9l()
						};
						rrULI2qskPlIIdV35ZS(errorMessageViewModel, vGJsxBqdBQG8tLdoSZv(ex3));
						awaiter = ((IViewModelBroadcaster)broadcaster).Broadcast(null, errorMessageViewModel).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 5);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_03f1;
					}
					object broadcaster2 = x0KR6Cq6dJEdwO7OJHN();
					ErrorMessageViewModel errorMessageViewModel2 = new ErrorMessageViewModel();
					HjbuIRq8evoJZYIjZ3Q(errorMessageViewModel2, hJTUxyqDB4no6Fj9K9l());
					rrULI2qskPlIIdV35ZS(errorMessageViewModel2, E04I0CqFU0HDlK0RGMk());
					awaiter = ((IViewModelBroadcaster)broadcaster2).Broadcast(null, errorMessageViewModel2).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 4);
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_035b;
				}
				case 4:
					awaiter = _003C_003Eu__3;
					_003C_003Eu__3 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_035b;
				case 5:
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_03f1;
					}
					IL_03f1:
					awaiter.GetResult();
					break;
					IL_035b:
					awaiter.GetResult();
					break;
				}
				_003C_003E7__wrap2 = null;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Ctool_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0467;
			IL_0442:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 2:
					goto IL_0031;
				default:
					goto IL_0467;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 3:
				case 6:
					_003Ctool_003E5__2 = null;
					goto case 1;
				case 1:
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0467:
			_ = 0;
			num = ((!nDOFDIqkCbSkG8YM1vm()) ? 1 : 6);
			goto IL_0442;
			IL_001a:
			anomalyDetectAdapterBase = _003C_003E4__this;
			num = 2;
			if (!nDOFDIqkCbSkG8YM1vm())
			{
				goto IL_0031;
			}
			goto IL_0442;
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
		internal static object JT0lgfqrR2QFw0oXmlh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TdANyrqPkWeNThGSiyM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int FbLpvlq46am7duPpoQh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorModelStats)P_0).NumSamples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double vogCLlqgrcNyVPJYP1p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorModelStats)P_0).MaxNumSamples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Qi8cIKq1dUtAEUHi2mg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELAnomalyDetectMemoryLimitError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter SMCUBPqS0BkgOaq7ZSy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x0KR6Cq6dJEdwO7OJHN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ViewModelBroadcaster.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hJTUxyqDB4no6Fj9K9l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELAnomalyDetectLabelError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HjbuIRq8evoJZYIjZ3Q(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Heading = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object E04I0CqFU0HDlK0RGMk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELAnomalyDetectLabelGenericMessage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rrULI2qskPlIIdV35ZS(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Message = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vGJsxBqdBQG8tLdoSZv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nDOFDIqkCbSkG8YM1vm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool enCxDsqmRk8KX2omVs2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public AnomalyDetectAdapterBase _003C_003E4__this;

		public ThresholdUpdatedArgs args;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass32_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lBlk92q3FHsu7sjqSx2();
			wiMGBMqabuWVcip6cST(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CSetAutoThresholdSettings_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003E4__this.X9aVAj17f4?.Invoke(_003C_003E4__this, args);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lBlk92q3FHsu7sjqSx2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wiMGBMqabuWVcip6cST(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BSaFFZqEgycgECUrudb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YMZCdrq5fa6ajSYQgDC()
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
	private struct _003CSetAutoThresholdSettings_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public IAutoThresholdSettings newSettings;

		private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_036a;
			IL_001a:
			_003C_003E8__1 = null;
			goto IL_0399;
			IL_036a:
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 2:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 3;
					continue;
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 1;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 5;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 19;
							break;
						}
						while (true)
						{
							EventHandler<ThresholdUpdatedArgs> eventHandler;
							switch (num3)
							{
							case 5:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 16;
							case 16:
								if (anomalyDetectAdapterBase._mainThreadDispatcher != null)
								{
									num3 = 0;
									continue;
								}
								goto IL_00f7;
							case 8:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 17:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								if (!dUdYqqqcvWk1YAh5KCc())
								{
									num3 = 15;
									if (true)
									{
										continue;
									}
									goto case 19;
								}
								num3 = 4;
								continue;
							case 19:
								_003C_003Eu__1 = default;
								num3 = 13;
								if (bvAMZvqokhvAZqykRr2())
								{
									continue;
								}
								goto case 4;
							case 6:
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								if (true)
								{
									continue;
								}
								return;
							case 2:
								return;
							case 9:
								return;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 22;
								continue;
							case 3:
								awaiter.GetResult();
								goto case 20;
							default:
								num3 = 20;
								continue;
							case 20:
							{
								_003C_003Ec__DisplayClass32_0 obj = _003C_003E8__1;
								ThresholdUpdatedArgs thresholdUpdatedArgs = new ThresholdUpdatedArgs();
								MJt1lAqxROdlWfO1vKB(thresholdUpdatedArgs, toolId);
								obj.args = thresholdUpdatedArgs;
								num3 = 16;
								continue;
							}
							case 7:
								_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
								num3 = 21;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								if (!XZ68BhqhKfs8F9RQ0Fw(anomalyDetectAdapterBase._mainThreadDispatcher))
								{
									bo270EqUlNx2dIwkLiM(anomalyDetectAdapterBase._mainThreadDispatcher, (Action)([MethodImpl(MethodImplOptions.NoInlining)] () =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										_003C_003E8__1._003C_003E4__this.X9aVAj17f4?.Invoke(_003C_003E8__1._003C_003E4__this, _003C_003E8__1.args);
									}));
									num3 = 10;
									continue;
								}
								goto IL_00f7;
							case 4:
							case 10:
							case 12:
							case 14:
								awaiter = heeTfDqqtfAsLgUoH3E(oUI6BaqQB5OWWLEjiKo(anomalyDetectAdapterBase));
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 17;
								continue;
							case 18:
								awaiter = ((Task)q9HDGwqBpTatO5stZ9L(XKig7wquOp8JQsJun94(anomalyDetectAdapterBase, toolId), newSettings)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto case 3;
							case 21:
								anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
								num3 = 18;
								continue;
							case 1:
								_003C_003E8__1 = new _003C_003Ec__DisplayClass32_0();
								num3 = 7;
								if (bvAMZvqokhvAZqykRr2())
								{
									continue;
								}
								break;
							case 22:
								break;
								IL_00f7:
								eventHandler = anomalyDetectAdapterBase.X9aVAj17f4;
								if (eventHandler == null)
								{
									goto case 4;
								}
								eventHandler(anomalyDetectAdapterBase, _003C_003E8__1.args);
								num3 = 12;
								continue;
							}
							break;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 5;
					continue;
				case 4:
				case 6:
					goto IL_0399;
				case 0:
					goto IL_03ae;
				case 7:
					return;
				}
				break;
				IL_03ae:
				num2 = _003C_003E1__state;
				bvAMZvqokhvAZqykRr2();
				num = ((!dUdYqqqcvWk1YAh5KCc()) ? 2 : 6);
			}
			goto IL_001a;
			IL_0399:
			_003C_003Et__builder.SetResult();
			num = 7;
			goto IL_036a;
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
		internal static object XKig7wquOp8JQsJun94(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object q9HDGwqBpTatO5stZ9L(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectToolApi)P_0).SetAutoThresholdSettings((IAutoThresholdSettings)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MJt1lAqxROdlWfO1vKB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ThresholdUpdatedArgs)P_0).ToolId = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XZ68BhqhKfs8F9RQ0Fw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Dispatcher)P_0).CheckAccess();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bo270EqUlNx2dIwkLiM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Dispatcher)P_0).Invoke((Action)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oUI6BaqQB5OWWLEjiKo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).RunToolAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter heeTfDqqtfAsLgUoH3E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bvAMZvqokhvAZqykRr2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dUdYqqqcvWk1YAh5KCc()
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
	private struct _003CGetImage_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Size requestedSize;

		public string endpointUrl;

		public ResourceNode toolNode;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GfgJLZqV1c6gXs0ECDA();
			int num;
			if (!aqtG8xqiluJ0EQ7IMMx())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_01a2;
			IL_005d:
			int num2 = default;
			string result2 = default;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num2 != 0)
				{
					if (hILiDbqLIjpinhAcqRd(requestedSize, default))
					{
						string text = string.Format((string)IFW00eqtOL8l5RgTD0y(6954), requestedSize.Width, requestedSize.Height);
						endpointUrl = (string)wAD23Iq9bR6eXq2BjjW(endpointUrl, text);
					}
					awaiter = toolNode.GetHttpAsync(endpointUrl, new TimeSpan(0, 1, 0)).GetAwaiter();
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
				Stream result = awaiter.GetResult();
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					BcDIPpqvIpd6BgjXQO8(result, memoryStream);
					result2 = Convert.ToBase64String((byte[])z9tPgpqZDUuCNmyDe4n(memoryStream));
				}
				finally
				{
					if (num2 < 0 && memoryStream != null)
					{
						DYWD0Rq0KNk6Vh5a1P6(memoryStream);
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
			goto IL_0041;
			IL_01a2:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 2:
					goto IL_0041;
				case 1:
				case 3:
					goto IL_005d;
				default:
					num = 2;
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_005d;
			IL_0041:
			_003C_003Et__builder.SetResult(result2);
			num = 5;
			if (aqtG8xqiluJ0EQ7IMMx())
			{
				goto IL_005d;
			}
			goto IL_01a2;
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
		internal static bool hILiDbqLIjpinhAcqRd(Size P_0, Size P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 != P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IFW00eqtOL8l5RgTD0y(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wAD23Iq9bR6eXq2BjjW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BcDIPpqvIpd6BgjXQO8(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).CopyTo((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object z9tPgpqZDUuCNmyDe4n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DYWD0Rq0KNk6Vh5a1P6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GfgJLZqV1c6gXs0ECDA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aqtG8xqiluJ0EQ7IMMx()
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
	private struct _003CGetModelStatsFromCameraAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<AnomalyDetectStats> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private TaskAwaiter<ELAnomalyDetectorModelStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			AnomalyDetectStats result2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			TaskAwaiter<ELAnomalyDetectorModelStats> awaiter = default;
			ELAnomalyDetectorModelStats result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					if (JcWeY1qOwg404wqFrBf())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								result = awaiter.GetResult();
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								if (!YeXOGZqHnQshTZQgL74())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 4;
							case 2:
							case 3:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 9:
							{
								object obj = jS30EgqTyG9u31rTBtN(anomalyDetectAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = ((AnomalyDetectToolApi)obj).GetModelStats().GetAwaiter();
								YeXOGZqHnQshTZQgL74();
								num3 = ((!JcWeY1qOwg404wqFrBf()) ? 2 : 6);
								continue;
							}
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 7;
								if (YeXOGZqHnQshTZQgL74())
								{
								}
								continue;
							case 0:
								return;
							case 10:
							{
								AnomalyDetectStats anomalyDetectStats = new AnomalyDetectStats();
								cCnFgaqJhKSWljqgs2m(anomalyDetectStats, tIbEyuqYWTQ82iUG01T(result));
								fy5sNdqCi45KQgX38jJ(anomalyDetectStats, VgOo0oqKBLvJQt0p137(result));
								xNMwydqA7bRjkuYdw6q(anomalyDetectStats, result.NumNotGoodSamples);
								yhJLyhqwDfwCLWuPhPF(anomalyDetectStats, (float)rDkKT1qNRFCw25XtMFv(result));
								result2 = anomalyDetectStats;
								break;
							}
							}
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
				case 4:
					anomalyDetectAdapterBase = _003C_003E4__this;
					_ = 1;
					if (YeXOGZqHnQshTZQgL74())
					{
						num = 0;
						break;
					}
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
		internal static object jS30EgqTyG9u31rTBtN(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int tIbEyuqYWTQ82iUG01T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorModelStats)P_0).NumSamples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cCnFgaqJhKSWljqgs2m(object P_0, int value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectStats)P_0).NumSamples = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int VgOo0oqKBLvJQt0p137(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorModelStats)P_0).NumGoodSamples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fy5sNdqCi45KQgX38jJ(object P_0, int value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectStats)P_0).NumGoodSamples = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xNMwydqA7bRjkuYdw6q(object P_0, int value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectStats)P_0).NumNotGoodSamples = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double rDkKT1qNRFCw25XtMFv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorModelStats)P_0).ModelHealth;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yhJLyhqwDfwCLWuPhPF(object P_0, float value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectStats)P_0).ModelHealth = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JcWeY1qOwg404wqFrBf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YeXOGZqHnQshTZQgL74()
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
	private struct _003CGetResultFromCameraAsync_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<AnomalyDetectorResult> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private ResourceNode _003CtoolNode_003E5__2;

		private ELAnomalyDetectorResult _003Cresult_003E5__3;

		private TaskAwaiter<ELAnomalyDetectorResult> _003C_003Eu__1;

		private bool _003ChasHeatmap_003E5__4;

		private AnomalyDetectorResult _003C_003E7__wrap4;

		private AnomalyDetectorResult _003C_003E7__wrap5;

		private AnomalyDetectorResult _003C_003E7__wrap6;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!NeavbxqpjxM71Di1UlU())
			{
				goto IL_001e;
			}
			goto IL_0575;
			IL_001e:
			AnomalyDetectorResult result = default;
			_003C_003Et__builder.SetResult(result);
			num = 8;
			if (!NeavbxqpjxM71Di1UlU())
			{
				goto IL_003a;
			}
			goto IL_0575;
			IL_0575:
			int num2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			TaskAwaiter<ELAnomalyDetectorResult> awaiter2 = default;
			TaskAwaiter<string> awaiter = default;
			string result3 = default;
			string heatmap = default;
			while (true)
			{
				switch (num)
				{
				case 5:
				case 7:
					break;
				case 1:
					goto IL_003a;
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 3;
							goto IL_01d9;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 14;
							goto IL_01d9;
						case 1:
							awaiter = _003C_003Eu__2;
							num3 = 16;
							if (NeavbxqpjxM71Di1UlU())
							{
								goto IL_01d9;
							}
							goto IL_037c;
						case 2:
							{
								awaiter = _003C_003Eu__2;
								num3 = 20;
								goto IL_01d9;
							}
							IL_01d9:
							while (true)
							{
								object obj2;
								ELAnomalyDetectorResult result2;
								switch (num3)
								{
								case 23:
									_003C_003E7__wrap5 = _003C_003E7__wrap6;
									num3 = 11;
									continue;
								case 20:
									_003C_003Eu__2 = default;
									num3 = 32;
									continue;
								case 29:
									result3 = awaiter.GetResult();
									num3 = 26;
									continue;
								case 17:
									result = new AnomalyDetectorResult();
									goto end_IL_01d9;
								case 22:
									num2 = (_003C_003E1__state = 1);
									num3 = 10;
									continue;
								case 26:
									ixRaElqe5UnFODtutHv(_003C_003E7__wrap4, result3);
									num3 = 23;
									continue;
								case 8:
									num2 = (_003C_003E1__state = -1);
									goto IL_0113;
								case 19:
									return;
								case 9:
								case 15:
								case 27:
								case 28:
									_003C_003E7__wrap5.Heatmap = heatmap;
									num3 = 6;
									if (fDkvxmqGsvvPRmGYOoK())
									{
									}
									continue;
								case 31:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 19;
									continue;
								case 16:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 29;
									continue;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 22;
										continue;
									}
									goto case 29;
								case 10:
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 4;
									if (NeavbxqpjxM71Di1UlU())
									{
										continue;
									}
									goto case 14;
								case 14:
									_003C_003Eu__1 = default;
									num3 = 8;
									continue;
								case 6:
									sXkZaHq7iWaTQMtpnIZ(_003C_003E7__wrap6, hQQiFAqlFRNYU0jEiiv(_003Cresult_003E5__3));
									num3 = 21;
									continue;
								case 24:
									awaiter = anomalyDetectAdapterBase.idcVpkVXoj(_003Cresult_003E5__3.ImageUrl, _003CtoolNode_003E5__2).GetAwaiter();
									num3 = 2;
									if (NeavbxqpjxM71Di1UlU())
									{
										continue;
									}
									goto case 1;
								case 1:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__2 = awaiter;
									num3 = 13;
									continue;
								case 7:
									awaiter = anomalyDetectAdapterBase.idcVpkVXoj(_003Cresult_003E5__3.HeatmapUrl, _003CtoolNode_003E5__2).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto IL_03c4;
								case 30:
									obj2 = null;
									goto IL_0348;
								case 4:
									return;
								case 25:
									break;
								case 0:
									_003C_003E7__wrap6 = new AnomalyDetectorResult();
									num3 = 5;
									continue;
								case 32:
									num2 = (_003C_003E1__state = -1);
									goto IL_03c4;
								case 18:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 25;
										continue;
									}
									goto IL_0113;
								case 11:
									if (!_003ChasHeatmap_003E5__4)
									{
										heatmap = null;
										goto case 9;
									}
									num3 = 7;
									continue;
								case 12:
								{
									ELAnomalyDetectorResult eLAnomalyDetectorResult = _003Cresult_003E5__3;
									if (eLAnomalyDetectorResult != null)
									{
										obj2 = T1FRRtqIt0dsEdv5fCT(eLAnomalyDetectorResult);
										goto IL_0348;
									}
									num3 = 30;
									continue;
								}
								case 3:
								{
									_003CtoolNode_003E5__2 = (ResourceNode)qPJXJBqRQi3D3jdQilC(anomalyDetectAdapterBase, toolId);
									object obj = Uk3xgpqjwg2q687EUsC(anomalyDetectAdapterBase, toolId);
									token.ThrowIfCancellationRequested();
									awaiter2 = ((AnomalyDetectToolApi)obj).GetResult().GetAwaiter();
									num3 = 18;
									continue;
								}
								case 21:
									hAI7DZqymMLpNcnE1Ap(_003C_003E7__wrap6, _003Cresult_003E5__3.ResultScore);
									_003C_003E7__wrap6.SampleId = (string)W4oWgAqnCqop8QO0crX(_003Cresult_003E5__3);
									num3 = 33;
									continue;
								case 5:
									_003C_003E7__wrap4 = _003C_003E7__wrap6;
									num3 = 24;
									if (NeavbxqpjxM71Di1UlU())
									{
										continue;
									}
									goto case 13;
								case 13:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 33:
									{
										result = _003C_003E7__wrap6;
										goto end_IL_01d9;
									}
									IL_0113:
									result2 = awaiter2.GetResult();
									_003Cresult_003E5__3 = result2;
									num3 = 12;
									continue;
									IL_0348:
									if (!AyfxwDqWweTLEKE3GLD(obj2))
									{
										_003ChasHeatmap_003E5__4 = !string.IsNullOrEmpty((string)EbaPvcqbO6xeprITABo(_003Cresult_003E5__3));
										num3 = 0;
									}
									else
									{
										num3 = 17;
									}
									continue;
									IL_03c4:
									heatmap = awaiter.GetResult();
									_ = 0;
									num3 = (NeavbxqpjxM71Di1UlU() ? 9 : 15);
									continue;
								}
								goto IL_037c;
								continue;
								end_IL_01d9:
								break;
							}
							break;
							IL_037c:
							_003C_003Eu__1 = awaiter2;
							num3 = 31;
							goto IL_01d9;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CtoolNode_003E5__2 = null;
						_003Cresult_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 6;
					continue;
				case 0:
				case 4:
					_003Cresult_003E5__3 = null;
					break;
				case 2:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
					_003CtoolNode_003E5__2 = null;
					goto default;
				default:
					_ = 0;
					if (!NeavbxqpjxM71Di1UlU())
					{
						num = 7;
						if (!fDkvxmqGsvvPRmGYOoK())
						{
							continue;
						}
						goto case 2;
					}
					num = 0;
					continue;
				case 8:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_003a:
			num2 = _003C_003E1__state;
			num = 2;
			goto IL_0575;
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
		internal static object qPJXJBqRQi3D3jdQilC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Uk3xgpqjwg2q687EUsC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object T1FRRtqIt0dsEdv5fCT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorResult)P_0).ImageUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AyfxwDqWweTLEKE3GLD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EbaPvcqbO6xeprITABo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorResult)P_0).HeatmapUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ixRaElqe5UnFODtutHv(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectorResult)P_0).Image = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hQQiFAqlFRNYU0jEiiv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorResult)P_0).IsPredictionGood;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sXkZaHq7iWaTQMtpnIZ(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectorResult)P_0).IsPredictionGood = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hAI7DZqymMLpNcnE1Ap(object P_0, float P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectorResult)P_0).Score = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object W4oWgAqnCqop8QO0crX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorResult)P_0).SampleId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NeavbxqpjxM71Di1UlU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fDkvxmqGsvvPRmGYOoK()
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
	private struct _003CGetSamplesFromCameraAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Dictionary<string, AnomalyDetectSample>> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private ResourceNode _003CtoolNode_003E5__2;

		private AnomalyDetectToolApi _003Ctool_003E5__3;

		private Dictionary<string, AnomalyDetectSample> _003Csamples_003E5__4;

		private ICollection<ELAnomalyDetectorSample> _003CanomalySamples_003E5__5;

		private Size _003ClowResSize_003E5__6;

		private TaskAwaiter<ELAnomalyDetectorSample[]> _003C_003Eu__1;

		private Size _003CsampleSize_003E5__7;

		private TaskAwaiter<Size> _003C_003Eu__2;

		private TaskAwaiter<ELAnomalyDetectorFeatureSizeSettings> _003C_003Eu__3;

		private IEnumerator<ELAnomalyDetectorSample> _003C_003E7__wrap7;

		private ELAnomalyDetectorSample _003Csample_003E5__9;

		private Dictionary<string, AnomalyDetectSample> _003C_003E7__wrap9;

		private string _003C_003E7__wrap10;

		private AnomalyDetectSample _003C_003E7__wrap11;

		private AnomalyDetectSample _003C_003E7__wrap12;

		private TaskAwaiter<string> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			Dictionary<string, AnomalyDetectSample> result = default;
			int num2 = default;
			TaskAwaiter<string> awaiter4 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003CtoolNode_003E5__2 = null;
					mR1o4rqfrEKcKaMNjLJ();
					num = (awU1jwqzknwOPkEK3CH() ? 6 : 8);
					break;
				default:
					_003Csamples_003E5__4 = null;
					num = 7;
					if (mR1o4rqfrEKcKaMNjLJ())
					{
						break;
					}
					goto case 1;
				case 1:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 9;
					break;
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 4:
				case 8:
					_003Ctool_003E5__3 = null;
					goto default;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 10;
					if (mR1o4rqfrEKcKaMNjLJ())
					{
						break;
					}
					goto case 9;
				case 9:
					try
					{
						TaskAwaiter<ELAnomalyDetectorSample[]> awaiter3;
						TaskAwaiter<Size> awaiter2;
						TaskAwaiter<ELAnomalyDetectorFeatureSizeSettings> awaiter;
						Size result2;
						ELAnomalyDetectorSample[] result3;
						float num3;
						switch (num2)
						{
						default:
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							_003CtoolNode_003E5__2 = (ResourceNode)HltrCdV2s1aLQZxiEuT(anomalyDetectAdapterBase, toolId);
							_003Ctool_003E5__3 = anomalyDetectAdapterBase.GetTool(toolId);
							token.ThrowIfCancellationRequested();
							_003Csamples_003E5__4 = new Dictionary<string, AnomalyDetectSample>();
							awaiter3 = _003Ctool_003E5__3.GetSamples().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_01a3;
						case 0:
							awaiter3 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01a3;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_023a;
						case 2:
							awaiter = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_02aa;
						case 3:
							break;
							IL_023a:
							result2 = awaiter2.GetResult();
							_003CsampleSize_003E5__7 = result2;
							awaiter = _003Ctool_003E5__3.GetFeatureSizeSettings().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_02aa;
							IL_01a3:
							result3 = awaiter3.GetResult();
							_003CanomalySamples_003E5__5 = result3;
							token.ThrowIfCancellationRequested();
							_003ClowResSize_003E5__6 = new Size(0, 0);
							if (_003CanomalySamples_003E5__5.Count() > 0)
							{
								awaiter2 = _003Ctool_003E5__3.GetInferenceSize().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_023a;
							}
							goto IL_02d9;
							IL_02d9:
							_003C_003E7__wrap7 = _003CanomalySamples_003E5__5.GetEnumerator();
							break;
							IL_02aa:
							num3 = L7Tjl2VXeylRye8vmFV(awaiter.GetResult());
							_003ClowResSize_003E5__6 = anomalyDetectAdapterBase.HifVWsfj8p(_003CsampleSize_003E5__7, num3);
							_003CsampleSize_003E5__7 = default;
							goto IL_02d9;
						}
						try
						{
							int num4;
							if (num2 != 3)
							{
								num4 = 1;
							}
							else
							{
								awaiter4 = _003C_003Eu__4;
								num4 = 4;
								if (!mR1o4rqfrEKcKaMNjLJ())
								{
									goto IL_05c5;
								}
							}
							goto IL_04cc;
							IL_0525:
							_ = 0;
							num4 = ((!mR1o4rqfrEKcKaMNjLJ()) ? 15 : 14);
							goto IL_04cc;
							IL_04ac:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							goto IL_0525;
							IL_04cc:
							while (true)
							{
								switch (num4)
								{
								case 10:
								{
									string result4 = awaiter4.GetResult();
									_003C_003E7__wrap11.Image = result4;
									num4 = 12;
									continue;
								}
								case 2:
									_003C_003E7__wrap9 = null;
									num4 = 7;
									continue;
								case 3:
									_003Csample_003E5__9 = null;
									num4 = 20;
									continue;
								case 7:
									_003C_003E7__wrap10 = null;
									num4 = 5;
									continue;
								case 13:
								case 15:
									_003C_003E7__wrap9.Add(_003C_003E7__wrap10, _003C_003E7__wrap12);
									num4 = 2;
									continue;
								case 16:
									_003C_003E7__wrap10 = (string)pLEx5aVMcPiQavvwCQq(_003Csample_003E5__9);
									num4 = 17;
									if (mR1o4rqfrEKcKaMNjLJ())
									{
										continue;
									}
									goto case 17;
								case 17:
									_003C_003E7__wrap12 = new AnomalyDetectSample();
									num4 = 19;
									if (!awU1jwqzknwOPkEK3CH())
									{
										continue;
									}
									goto case 6;
								case 6:
									_003C_003E7__wrap11 = _003C_003E7__wrap12;
									awaiter4 = anomalyDetectAdapterBase.idcVpkVXoj(_003Csample_003E5__9.ImageUrl, _003CtoolNode_003E5__2, _003ClowResSize_003E5__6).GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										num4 = 8;
										continue;
									}
									goto case 10;
								case 5:
									_003C_003E7__wrap11 = null;
									_003C_003E7__wrap12 = null;
									num4 = 3;
									continue;
								case 4:
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									num4 = 10;
									continue;
								case 0:
									_003C_003Eu__4 = awaiter4;
									num4 = 18;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								case 8:
									num2 = (_003C_003E1__state = 3);
									num4 = 0;
									continue;
								case 19:
									_003C_003E7__wrap12.Id = _003Csample_003E5__9.Id;
									_003C_003E7__wrap12.ImageUrl = (string)YcT9qYVkgB1EAmk0poe(_003Csample_003E5__9);
									num4 = 6;
									continue;
								case 18:
									break;
								default:
									goto IL_0525;
								case 11:
									_003C_003E7__wrap9 = _003Csamples_003E5__4;
									num4 = 16;
									continue;
								case 12:
									LVtVX1VPlhG8DiS2w90(_003C_003E7__wrap12, (!VXUXNDVrirlYFNgA0HH(_003Csample_003E5__9.Label, beekqBVmfVjHeBaRCt6(4632))) ? AnomalyDetectorLabels.NG : AnomalyDetectorLabels.OK);
									V5A3HAVgtLmu83veCZD(_003C_003E7__wrap12, SEA52CV4MmbTsaXqe2P(_003Csample_003E5__9));
									goto case 13;
								case 9:
								case 14:
									return;
								case 1:
								case 20:
									goto IL_05c5;
								}
								break;
							}
							goto IL_04ac;
							IL_05c5:
							if (vOaS1vV1V9fsL59Uw8k(_003C_003E7__wrap7))
							{
								_003Csample_003E5__9 = _003C_003E7__wrap7.Current;
								num4 = 11;
								if (!mR1o4rqfrEKcKaMNjLJ())
								{
									goto IL_04ac;
								}
								goto IL_04cc;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap7 != null)
							{
								zWPHBjVSi0bw9pUo06G(_003C_003E7__wrap7);
							}
						}
						_003C_003E7__wrap7 = null;
						result = _003Csamples_003E5__4;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CtoolNode_003E5__2 = null;
						_003Ctool_003E5__3 = null;
						_003Csamples_003E5__4 = null;
						_003CanomalySamples_003E5__5 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 3;
					break;
				case 7:
					_003CanomalySamples_003E5__5 = null;
					num = 0;
					break;
				case 10:
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
		internal static object HltrCdV2s1aLQZxiEuT(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static float L7Tjl2VXeylRye8vmFV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorFeatureSizeSettings)P_0).CurrentValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pLEx5aVMcPiQavvwCQq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorSample)P_0).Id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YcT9qYVkgB1EAmk0poe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorSample)P_0).ImageUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object beekqBVmfVjHeBaRCt6(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VXUXNDVrirlYFNgA0HH(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LVtVX1VPlhG8DiS2w90(object P_0, AnomalyDetectorLabels value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectSample)P_0).Label = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long SEA52CV4MmbTsaXqe2P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELAnomalyDetectorSample)P_0).DateLabeled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void V5A3HAVgtLmu83veCZD(object P_0, long value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AnomalyDetectSample)P_0).Date = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vOaS1vV1V9fsL59Uw8k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zWPHBjVSi0bw9pUo06G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mR1o4rqfrEKcKaMNjLJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool awU1jwqzknwOPkEK3CH()
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
	private struct _003CDeleteSamplesAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		public ICollection<string> sampleIds;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (vPCqvbVDUBPr3ouLkHI() ? 5 : 3);
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
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
				case 5:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 2;
					if (LiuyBQV6nTNye9kMex9())
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
							{
								object obj = oG5gCKV8td7m9Ib2nbf(anomalyDetectAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = m5UO3lVFLhrxIfeGu3o(((AnomalyDetectToolApi)obj).DeleteSamples(sampleIds));
								_ = 1;
								if (!vPCqvbVDUBPr3ouLkHI())
								{
									num3 = 4;
									if (LiuyBQV6nTNye9kMex9())
									{
										continue;
									}
									goto case 6;
								}
								num3 = 8;
								if (LiuyBQV6nTNye9kMex9())
								{
									continue;
								}
								return;
							}
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 8:
								return;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 1:
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
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
					goto case 4;
				default:
					num = 4;
					if (!LiuyBQV6nTNye9kMex9())
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
		internal static object oG5gCKV8td7m9Ib2nbf(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter m5UO3lVFLhrxIfeGu3o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LiuyBQV6nTNye9kMex9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vPCqvbVDUBPr3ouLkHI()
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
	private struct _003CTrainAsync_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					anomalyDetectAdapterBase = _003C_003E4__this;
					goto case 2;
				case 0:
					num2 = _003C_003E1__state;
					DmrU8pVsb62G3Y5q9QN();
					if (MiCcaeVdGxPuxCaDVqU())
					{
						num = 3;
						break;
					}
					num = 5;
					if (DmrU8pVsb62G3Y5q9QN())
					{
						break;
					}
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_022d;
							}
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							anomalyDetectToolApi = (AnomalyDetectToolApi)a6SdB3VEExXcZPgRAlR(anomalyDetectAdapterBase, toolId);
							token.ThrowIfCancellationRequested();
							anomalyDetectAdapterBase.ClearCaches(toolId);
							_003C_003E7__wrap1 = null;
							_003C_003E7__wrap2 = 0;
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								awaiter = J0cpd2V3G31qasZNx8e(YiYNe4V5o7rZc7pQRxO(anomalyDetectToolApi));
								num3 = 8;
								if (false)
								{
									return;
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
								default:
									return;
								case 7:
									return;
								case 8:
									if (!awaiter.IsCompleted)
									{
										MiCcaeVdGxPuxCaDVqU();
										num3 = ((!DmrU8pVsb62G3Y5q9QN()) ? 7 : 6);
										continue;
									}
									break;
								case 3:
									_003C_003Eu__1 = default;
									num3 = 2;
									continue;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 0:
									_003C_003Eu__1 = awaiter;
									num3 = 5;
									continue;
								case 1:
								case 6:
									num2 = (_003C_003E1__state = 0);
									num3 = 0;
									continue;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (object obj)
						{
							_003C_003E7__wrap1 = obj;
						}
						awaiter = ((Task)btCGmHVaCeBn45uVql9(anomalyDetectAdapterBase)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_022d;
						IL_022d:
						awaiter.GetResult();
						object obj2 = _003C_003E7__wrap1;
						if (obj2 != null)
						{
							kONajsVcLKFegUE6mh0(f6imMsVo5BrEo27nn0b((obj2 as Exception) ?? throw obj2));
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
		internal static object a6SdB3VEExXcZPgRAlR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YiYNe4V5o7rZc7pQRxO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectToolApi)P_0).Train();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter J0cpd2V3G31qasZNx8e(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object btCGmHVaCeBn45uVql9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).RunToolAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object f6imMsVo5BrEo27nn0b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kONajsVcLKFegUE6mh0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DmrU8pVsb62G3Y5q9QN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MiCcaeVdGxPuxCaDVqU()
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
	private struct _003CGetFeatureSizeSettings_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IFeatureSizeSettings> _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELAnomalyDetectorFeatureSizeSettings> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			IFeatureSizeSettings result2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			int num2 = default;
			TaskAwaiter<ELAnomalyDetectorFeatureSizeSettings> awaiter = default;
			ELAnomalyDetectorFeatureSizeSettings result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 1:
				case 3:
					anomalyDetectAdapterBase = _003C_003E4__this;
					goto case 0;
				case 5:
					num2 = _003C_003E1__state;
					cJ2VNUVuhTQppmtck4C();
					num = ((!AQBC2uVBMFOK7M7P8hJ()) ? 3 : 0);
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 4:
							case 7:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 5;
									continue;
								}
								goto case 4;
							case 8:
								return;
							case 3:
								awaiter = ((AnomalyDetectToolApi)HqmOUgVxQvN1yOtGiqA(anomalyDetectAdapterBase, toolId)).GetFeatureSizeSettings().GetAwaiter();
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto case 4;
							case 1:
								_003C_003Eu__1 = default;
								cJ2VNUVuhTQppmtck4C();
								num3 = ((!AQBC2uVBMFOK7M7P8hJ()) ? 2 : 4);
								continue;
							case 10:
							{
								FeatureSizeSettings featureSizeSettings = new FeatureSizeSettings();
								tuHvGNVhJM9nXGfsn13(featureSizeSettings, result.CurrentValue);
								GeMpFFVUJA5i3gdxAZQ(featureSizeSettings, result.Maximum);
								Pk7I9rVQTwK2jf6bpal(featureSizeSettings, result.Minimum);
								result2 = featureSizeSettings;
								break;
							}
							}
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
		internal static object HqmOUgVxQvN1yOtGiqA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tuHvGNVhJM9nXGfsn13(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FeatureSizeSettings)P_0).CurrentValue = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GeMpFFVUJA5i3gdxAZQ(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FeatureSizeSettings)P_0).Maximum = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pk7I9rVQTwK2jf6bpal(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FeatureSizeSettings)P_0).Minimum = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cJ2VNUVuhTQppmtck4C()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AQBC2uVBMFOK7M7P8hJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public AnomalyDetectAdapterBase _003C_003E4__this;

		public FeatureSizeArgs featureSizeArgs;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass41_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HiYnSqVijX18yjtQFCH();
			SnhhqNVLUBkyRJj98ly(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CSetFeatureSize_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003E4__this.YcYVyqmsId?.Invoke(_003C_003E4__this, featureSizeArgs);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HiYnSqVijX18yjtQFCH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SnhhqNVLUBkyRJj98ly(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ubBun2Vq8s6xPNTNJTZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RjTrwQVVfnXh2hTGTos()
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
	private struct _003CSetFeatureSize_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		public double featureSize;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private TaskAwaiter _003C_003Eu__1;

		private Exception _003Cex_003E5__6;

		private TaskAwaiter<bool> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			int num2 = default;
			do
			{
				IL_0443:
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (o2WqMHVtWhDTSPRyQn1())
					{
						goto IL_0443;
					}
					goto case 1;
				case 1:
					anomalyDetectAdapterBase = _003C_003E4__this;
					_ = 1;
					num = (aPVrUpV9jPvEQfLd33D() ? 6 : 5);
					goto IL_0443;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if ((uint)num2 > 1u)
						{
							if (num2 == 2)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03ca;
							}
							_003C_003E8__1 = new _003C_003Ec__DisplayClass41_0();
							_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							anomalyDetectToolApi = (AnomalyDetectToolApi)mcXSjiVv9uoI6PLYL4n(anomalyDetectAdapterBase, toolId);
							anomalyDetectAdapterBase.ClearCaches(toolId);
							_003C_003E7__wrap1 = null;
							_003C_003E7__wrap2 = 0;
						}
						try
						{
							TaskAwaiter<bool> awaiter2;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0349;
								}
								_003C_003E7__wrap4 = 0;
							}
							try
							{
								int num3;
								if (num2 != 0)
								{
									awaiter = eZAhVtVZ4fN4vmeCX7o(anomalyDetectToolApi.SetFeatureSize(featureSize));
									num3 = 7;
								}
								else
								{
									awaiter = _003C_003Eu__1;
									num3 = 6;
								}
								while (true)
								{
									EventHandler<FeatureSizeArgs> eventHandler;
									switch (num3)
									{
									case 12:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 9;
										continue;
									case 9:
										return;
									case 3:
									case 8:
										if (!dwRIsOVOhth1QerDTsq(anomalyDetectAdapterBase._mainThreadDispatcher))
										{
											num3 = 1;
											if (true)
											{
												continue;
											}
											goto case 1;
										}
										goto IL_0160;
									case 1:
										ARS8N6VHvmxZH34uUXZ(anomalyDetectAdapterBase._mainThreadDispatcher, (Action)([MethodImpl(MethodImplOptions.NoInlining)] () =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											_003C_003E8__1._003C_003E4__this.YcYVyqmsId?.Invoke(_003C_003E8__1._003C_003E4__this, _003C_003E8__1.featureSizeArgs);
										}));
										goto end_IL_01c7;
									case 10:
										goto end_IL_01c7;
									case 11:
										goto end_IL_01c7;
									case 6:
										_003C_003Eu__1 = default;
										num3 = 4;
										continue;
									case 7:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											num3 = 0;
											continue;
										}
										goto case 5;
									case 4:
										num2 = (_003C_003E1__state = -1);
										goto case 5;
									default:
										num3 = 5;
										continue;
									case 5:
										awaiter.GetResult();
										num3 = 2;
										if (aPVrUpV9jPvEQfLd33D())
										{
										}
										continue;
									case 2:
									{
										_003C_003Ec__DisplayClass41_0 obj = _003C_003E8__1;
										FeatureSizeArgs featureSizeArgs = new FeatureSizeArgs();
										ltkrs2V0sEIiQyMSpOu(featureSizeArgs, toolId);
										obj.featureSizeArgs = featureSizeArgs;
										if (anomalyDetectAdapterBase._mainThreadDispatcher != null)
										{
											_ = 1;
											if (aPVrUpV9jPvEQfLd33D())
											{
												num3 = 11;
												continue;
											}
											num3 = 3;
											if (o2WqMHVtWhDTSPRyQn1())
											{
												continue;
											}
											break;
										}
										goto IL_0160;
									}
									case 0:
										break;
									case 13:
										goto end_IL_01c7;
										IL_0160:
										eventHandler = anomalyDetectAdapterBase.YcYVyqmsId;
										if (eventHandler == null)
										{
											num3 = 13;
											continue;
										}
										eventHandler(anomalyDetectAdapterBase, _003C_003E8__1.featureSizeArgs);
										goto end_IL_01c7;
									}
									_003C_003Eu__1 = awaiter;
									num3 = 12;
									continue;
									end_IL_01c7:
									break;
								}
							}
							catch (Exception ex)
							{
								_003C_003E7__wrap3 = ex;
								_003C_003E7__wrap4 = 1;
							}
							int num4 = _003C_003E7__wrap4;
							if (num4 == 1)
							{
								_003Cex_003E5__6 = (Exception)_003C_003E7__wrap3;
								IViewModelBroadcaster broadcaster = ViewModelBroadcaster.Default;
								ErrorMessageViewModel errorMessageViewModel = new ErrorMessageViewModel();
								YCXvFJVY9k6FUh1w4k7(errorMessageViewModel, VqXXiWVThOwfb4dclmO());
								Q0JdlVVKKHgZyHOILAO(errorMessageViewModel, nQH48DVJitLL9VOw3ck());
								awaiter2 = broadcaster.Broadcast(null, errorMessageViewModel).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0349;
							}
							_003C_003E7__wrap3 = null;
							goto end_IL_00ae;
							IL_0349:
							awaiter2.GetResult();
							throw _003Cex_003E5__6;
							end_IL_00ae:;
						}
						catch (object obj2)
						{
							_003C_003E7__wrap1 = obj2;
						}
						awaiter = eZAhVtVZ4fN4vmeCX7o(anomalyDetectAdapterBase.RunToolAsync());
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_03ca;
						IL_03ca:
						awaiter.GetResult();
						object obj3 = _003C_003E7__wrap1;
						if (obj3 != null)
						{
							Fa64H5VCXxUuLkGkg5s(ExceptionDispatchInfo.Capture((obj3 as Exception) ?? throw obj3));
						}
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					goto IL_0443;
				case 7:
					return;
				}
				_003C_003E8__1 = null;
				num = 4;
			}
			while (!aPVrUpV9jPvEQfLd33D());
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
		internal static object mcXSjiVv9uoI6PLYL4n(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter eZAhVtVZ4fN4vmeCX7o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ltkrs2V0sEIiQyMSpOu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FeatureSizeArgs)P_0).ToolId = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dwRIsOVOhth1QerDTsq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Dispatcher)P_0).CheckAccess();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ARS8N6VHvmxZH34uUXZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Dispatcher)P_0).Invoke((Action)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VqXXiWVThOwfb4dclmO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELAnomalyDetectFeatureSizeError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YCXvFJVY9k6FUh1w4k7(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Heading = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nQH48DVJitLL9VOw3ck()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELAnomalyDetectFeatureSizeGenericMessage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Q0JdlVVKKHgZyHOILAO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Message = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Fa64H5VCXxUuLkGkg5s(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o2WqMHVtWhDTSPRyQn1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aPVrUpV9jPvEQfLd33D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public AnomalyDetectAdapterBase _003C_003E4__this;

		public FeatureSizeArgs featureSizeArgs;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass42_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003COptimizeFeatureSize_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003E4__this.YcYVyqmsId?.Invoke(_003C_003E4__this, featureSizeArgs);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KyXt86VAWArcC4KSB7q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Jo0CvWVNJOlJ9CtbLKH()
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
	private struct _003COptimizeFeatureSize_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		public string toolId;

		private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private TaskAwaiter _003C_003Eu__1;

		private Exception _003Cex_003E5__6;

		private TaskAwaiter<bool> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0410;
			IL_001a:
			int num2 = _003C_003E1__state;
			num = 5;
			goto IL_0410;
			IL_0410:
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						if ((uint)num2 > 1u)
						{
							if (num2 == 2)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0397;
							}
							_003C_003E8__1 = new _003C_003Ec__DisplayClass42_0();
							_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
							anomalyDetectAdapterBase.ThrowIfToolIdInvalid(toolId);
							anomalyDetectToolApi = (AnomalyDetectToolApi)Mvn2BBVGwErVjDknCJa(anomalyDetectAdapterBase, toolId);
							anomalyDetectAdapterBase.ClearCaches(toolId);
							_003C_003E7__wrap1 = null;
							_003C_003E7__wrap2 = 0;
						}
						try
						{
							TaskAwaiter<bool> awaiter2;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0316;
								}
								_003C_003E7__wrap4 = 0;
							}
							try
							{
								int num3;
								if (num2 != 0)
								{
									awaiter = YFAxZVVjAcnhCksTBPB(MgAA63VREUjpfILbQlf(anomalyDetectToolApi));
									num3 = 3;
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
									case 5:
										num2 = (_003C_003E1__state = -1);
										goto IL_00c3;
									default:
										num3 = 12;
										continue;
									case 6:
										_003C_003Eu__1 = default;
										num3 = 5;
										if (!LHVgWBVprByotGWapQ3())
										{
											continue;
										}
										goto case 7;
									case 7:
										OwCvAhVWHIIwpXjYmt1(anomalyDetectAdapterBase._mainThreadDispatcher, (Action)([MethodImpl(MethodImplOptions.NoInlining)] () =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											_003C_003E8__1._003C_003E4__this.YcYVyqmsId?.Invoke(_003C_003E8__1._003C_003E4__this, _003C_003E8__1.featureSizeArgs);
										}));
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										goto case 3;
									case 3:
										if (awaiter.IsCompleted)
										{
											goto IL_00c3;
										}
										_ = 1;
										if (!LHVgWBVprByotGWapQ3())
										{
											num3 = 8;
											if (0 == 0)
											{
												continue;
											}
											goto case 12;
										}
										num3 = 0;
										continue;
									case 12:
									{
										_003C_003Ec__DisplayClass42_0 obj = _003C_003E8__1;
										FeatureSizeArgs featureSizeArgs = new FeatureSizeArgs();
										D787I8VIT6JeaUHfR2R(featureSizeArgs, toolId);
										obj.featureSizeArgs = featureSizeArgs;
										num3 = 11;
										continue;
									}
									case 0:
									case 2:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 9;
										continue;
									case 4:
										if (!anomalyDetectAdapterBase._mainThreadDispatcher.CheckAccess())
										{
											num3 = 7;
											continue;
										}
										break;
									case 9:
										return;
									case 11:
										if (anomalyDetectAdapterBase._mainThreadDispatcher != null)
										{
											num3 = 4;
											continue;
										}
										break;
									case 1:
									case 8:
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										goto case 0;
									case 10:
										goto end_IL_00dc;
									case 13:
										goto end_IL_00dc;
										IL_00c3:
										awaiter.GetResult();
										goto case 12;
									}
									EventHandler<FeatureSizeArgs> eventHandler = anomalyDetectAdapterBase.YcYVyqmsId;
									if (eventHandler == null)
									{
										num3 = 13;
										continue;
									}
									eventHandler(anomalyDetectAdapterBase, _003C_003E8__1.featureSizeArgs);
									break;
									continue;
									end_IL_00dc:
									break;
								}
							}
							catch (Exception ex)
							{
								_003C_003E7__wrap3 = ex;
								_003C_003E7__wrap4 = 1;
							}
							int num4 = _003C_003E7__wrap4;
							if (num4 == 1)
							{
								_003Cex_003E5__6 = (Exception)_003C_003E7__wrap3;
								object broadcaster = WdjSsyVbRPv77CUhIOW();
								ErrorMessageViewModel errorMessageViewModel = new ErrorMessageViewModel();
								WKsFPvVldg4CXGmvTOL(errorMessageViewModel, KEnd6YVecDRvmib4Rpq());
								KfnOxVVyScBU1FMPHnU(errorMessageViewModel, PwqL0JV7KeTa37alF0m());
								awaiter2 = ((IViewModelBroadcaster)broadcaster).Broadcast(null, errorMessageViewModel).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0316;
							}
							_003C_003E7__wrap3 = null;
							goto end_IL_0089;
							IL_0316:
							awaiter2.GetResult();
							throw _003Cex_003E5__6;
							end_IL_0089:;
						}
						catch (object obj2)
						{
							_003C_003E7__wrap1 = obj2;
						}
						awaiter = YFAxZVVjAcnhCksTBPB(anomalyDetectAdapterBase.RunToolAsync());
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0397;
						IL_0397:
						awaiter.GetResult();
						object obj3 = _003C_003E7__wrap1;
						if (obj3 != null)
						{
							qJ6DUcVnOWe64ydvQnw(ExceptionDispatchInfo.Capture((obj3 as Exception) ?? throw obj3));
						}
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_ = 1;
					if (!LHVgWBVprByotGWapQ3())
					{
						num = 1;
						continue;
					}
					num = 0;
					if (1 == 0)
					{
						return;
					}
					continue;
				case 0:
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					continue;
				case 5:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 2;
					continue;
				case 1:
				case 3:
					_003C_003E8__1 = null;
					goto case 0;
				case 7:
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
		internal static object Mvn2BBVGwErVjDknCJa(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MgAA63VREUjpfILbQlf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectToolApi)P_0).OptimizeFeatureSize();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YFAxZVVjAcnhCksTBPB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void D787I8VIT6JeaUHfR2R(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FeatureSizeArgs)P_0).ToolId = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OwCvAhVWHIIwpXjYmt1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Dispatcher)P_0).Invoke((Action)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WdjSsyVbRPv77CUhIOW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ViewModelBroadcaster.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KEnd6YVecDRvmib4Rpq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELAnomalyDetectFeatureSizeError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WKsFPvVldg4CXGmvTOL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Heading = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PwqL0JV7KeTa37alF0m()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELAnomalyDetectFeatureSizeGenericMessage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KfnOxVVyScBU1FMPHnU(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Message = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qJ6DUcVnOWe64ydvQnw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k6P0D0Vwab4f7ShO6Mg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LHVgWBVprByotGWapQ3()
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
	private struct _003CRunToolAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectAdapterBase _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			elYPI8VzlAjhdA6n7JU();
			int num;
			if (koEKDcVfspTODgSEral())
			{
				num = 1;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0188;
			IL_01ca:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0188;
			IL_0188:
			int num2 = default;
			AnomalyDetectAdapterBase anomalyDetectAdapterBase = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				default:
					goto IL_01ca;
				case 4:
					anomalyDetectAdapterBase = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				TaskAwaiter awaiter = default;
				int num3;
				if (num2 == 0)
				{
					awaiter = _003C_003Eu__1;
					num3 = 7;
					goto IL_00cb;
				}
				if (anomalyDetectAdapterBase.RunToolCallback != null)
				{
					num3 = 6;
					goto IL_00cb;
				}
				goto end_IL_002a;
				IL_00cb:
				while (true)
				{
					switch (num3)
					{
					case 7:
						_003C_003Eu__1 = default;
						num3 = 0;
						continue;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 1;
						continue;
					case 6:
						awaiter = bDt3d3i2v6U55ue9Maa(anomalyDetectAdapterBase.RunToolCallback());
						num3 = 8;
						continue;
					case 2:
						return;
					case 5:
						return;
					case 1:
						_003C_003Eu__1 = awaiter;
						goto default;
					default:
						_ = 0;
						if (koEKDcVfspTODgSEral())
						{
							num3 = 9;
							if (true)
							{
								continue;
							}
							goto case 8;
						}
						num3 = 2;
						continue;
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							continue;
						}
						break;
					case 4:
					case 9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 10:
						break;
					}
					break;
				}
				awaiter.GetResult();
				end_IL_002a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ca;
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
		internal static TaskAwaiter bDt3d3i2v6U55ue9Maa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool koEKDcVfspTODgSEral()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool elYPI8VzlAjhdA6n7JU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly string MilV7QBvO5;

	private static readonly string vEsVYnQaZh;

	private readonly AsyncCache<string, AnomalyDetectStats> P1xV0tQjEG;

	private readonly AsyncCache<string, AnomalyDetectorResult> px6VvCVbRJ;

	private readonly AsyncCache<string, Dictionary<string, AnomalyDetectSample>> DBeVLXdNet;

	private readonly Dictionary<string, Dictionary<string, AnomalyDetectSample>> YARVdRkZrx;

	private int v5dV5hbBig;

	[CompilerGenerated]
	private Func<Task> kNQVfXJVI0;

	[CompilerGenerated]
	private EventHandler<NewResultArgs> YcUV9LCeSG;

	[CompilerGenerated]
	private EventHandler<ThresholdUpdatedArgs> X9aVAj17f4;

	[CompilerGenerated]
	private EventHandler<FeatureSizeArgs> YcYVyqmsId;

	public Func<Task> RunToolCallback
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kNQVfXJVI0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kNQVfXJVI0 = value;
		}
	}

	public event EventHandler<NewResultArgs> NewResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<NewResultArgs> eventHandler = YcUV9LCeSG;
			EventHandler<NewResultArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NewResultArgs> value2 = (EventHandler<NewResultArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref YcUV9LCeSG, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<NewResultArgs> eventHandler = YcUV9LCeSG;
			EventHandler<NewResultArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NewResultArgs> value2 = (EventHandler<NewResultArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref YcUV9LCeSG, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<ThresholdUpdatedArgs> ThresholdUpdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<ThresholdUpdatedArgs> eventHandler = X9aVAj17f4;
			EventHandler<ThresholdUpdatedArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ThresholdUpdatedArgs> value2 = (EventHandler<ThresholdUpdatedArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref X9aVAj17f4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<ThresholdUpdatedArgs> eventHandler = X9aVAj17f4;
			EventHandler<ThresholdUpdatedArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ThresholdUpdatedArgs> value2 = (EventHandler<ThresholdUpdatedArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref X9aVAj17f4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FeatureSizeArgs> FeatureSizeUpdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FeatureSizeArgs> eventHandler = YcYVyqmsId;
			EventHandler<FeatureSizeArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FeatureSizeArgs> value2 = (EventHandler<FeatureSizeArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref YcYVyqmsId, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FeatureSizeArgs> eventHandler = YcYVyqmsId;
			EventHandler<FeatureSizeArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FeatureSizeArgs> value2 = (EventHandler<FeatureSizeArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref YcYVyqmsId, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AnomalyDetectAdapterBase(CvsInSight insight, Func<Task> triggerAcquisition)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector(insight, triggerAcquisition);
		P1xV0tQjEG = new AsyncCache<string, AnomalyDetectStats>(exnVS3kcnI);
		px6VvCVbRJ = new AsyncCache<string, AnomalyDetectorResult>(bb4VKUtcS7);
		DBeVLXdNet = new AsyncCache<string, Dictionary<string, AnomalyDetectSample>>(UsMVm47UJJ);
		YARVdRkZrx = new Dictionary<string, Dictionary<string, AnomalyDetectSample>>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Register(IAnomalyDetectorAdapter adapter)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Q2R93egsGbApSwR28eg();
		int num = (eNt8B5gdMi4MQZnxHyd() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				AnomalyDetectorClient.SetInitialTheme(MilV7QBvO5);
				break;
			case 0:
			case 4:
				c2HH3ngEEwDQvWbIitD(ExceptionLoggingDispatchProxyAsync.Create(adapter));
				num = 3;
				continue;
			case 5:
				return;
			}
			object obj = TGxKh4g3E4ZrG4QmaIJ(qhNyAcg5HFCqODGb69m());
			LocalizationOverride[] array = new LocalizationOverride[1];
			LocalizationOverride localizationOverride = new LocalizationOverride();
			XfZXFqgaE1CJN7Dvn3I(localizationOverride, vEsVYnQaZh);
			ktHsSMgcF25jTttLeJF(localizationOverride, QIoCchgosTNdJ1qIXlX());
			array[0] = localizationOverride;
			llSHuigu0ZT4SDodu1m(obj, array);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalClearCaches(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Q2R93egsGbApSwR28eg();
		int num;
		if (!eNt8B5gdMi4MQZnxHyd())
		{
			num = 1;
			if (eNt8B5gdMi4MQZnxHyd())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 5;
			if (eNt8B5gdMi4MQZnxHyd())
			{
			}
		}
		goto IL_004d;
		IL_0088:
		YARVdRkZrx.Remove(toolId);
		num = 6;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				goto IL_0088;
			case 4:
				px6VvCVbRJ.Remove(toolId);
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				P1xV0tQjEG.Remove(toolId);
				num = 4;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		DBeVLXdNet.Remove(toolId);
		goto IL_0088;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnNewResult(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		_003C_003Ec__DisplayClass23_0 obj = default;
		while (true)
		{
			EventHandler<NewResultArgs> eventHandler;
			switch (num)
			{
			case 3:
				ClearCaches((string)dol9cpgxnv5RDFpMRrr(obj.args));
				goto default;
			case 9:
				return;
			default:
				if (_mainThreadDispatcher != null)
				{
					num = 6;
					break;
				}
				goto IL_012e;
			case 8:
				ThrowIfToolIdInvalid((string)dol9cpgxnv5RDFpMRrr(obj.args));
				num = 3;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			{
				_003C_003Ec__DisplayClass23_0 obj2 = obj;
				NewResultArgs newResultArgs = new NewResultArgs();
				s9PI8pgB6ckcgELKZTH(newResultArgs, toolId);
				obj2.args = newResultArgs;
				num = 8;
				break;
			}
			case 6:
				if (!OcfTHmghbZTYbm1qWOV(_mainThreadDispatcher))
				{
					num = 2;
					break;
				}
				goto IL_012e;
			case 1:
			case 4:
				obj._003C_003E4__this = this;
				num = 0;
				break;
			case 2:
				Iu99hAgUD8291PgEl3K(_mainThreadDispatcher, new Action(obj._003COnNewResult_003Eb__0));
				return;
			case 10:
				obj = new _003C_003Ec__DisplayClass23_0();
				_ = 0;
				num = (Q2R93egsGbApSwR28eg() ? 4 : 7);
				break;
			case 11:
				return;
				IL_012e:
				eventHandler = YcUV9LCeSG;
				if (eventHandler != null)
				{
					eventHandler(this, obj.args);
					num = 11;
					if (!eNt8B5gdMi4MQZnxHyd())
					{
						break;
					}
					goto default;
				}
				num = 9;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteSamples_003Ed__24))]
	public Task DeleteSamples(string toolId, ICollection<string> sampleIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDeleteSamples_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.sampleIds = sampleIds;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAutoThresholdSettings_003Ed__25))]
	public Task<IAutoThresholdSettings> GetAutoThresholdSettings(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAutoThresholdSettings_003Ed__25 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IAutoThresholdSettings>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetResult_003Ed__26))]
	public Task<IAnomalyDetectorResult> GetResult(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetResult_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IAnomalyDetectorResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSample_003Ed__27))]
	public Task<IAnomalyDetectorSample> GetSample(string toolId, string sampleId, bool metadataOnly = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSample_003Ed__27 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IAnomalyDetectorSample>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.sampleId = sampleId;
		stateMachine.metadataOnly = metadataOnly;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamples_003Ed__28))]
	public Task<ICollection<IAnomalyDetectorSample>> GetSamples(string toolId, int imageSize)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamples_003Ed__28 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ICollection<IAnomalyDetectorSample>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.imageSize = imageSize;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetStats_003Ed__29))]
	public Task<IAnomalyDetectorStats> GetStats(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetStats_003Ed__29 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IAnomalyDetectorStats>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetScaledThreshold_003Ed__30))]
	public Task<float> GetScaledThreshold(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetScaledThreshold_003Ed__30 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<float>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLabelImage_003Ed__31))]
	public Task LabelImage(string toolId, string sampleId, AnomalyDetectorLabels label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CLabelImage_003Ed__31 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine.label = label;
				num = 7;
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 8:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (Q2R93egsGbApSwR28eg() ? 6 : 0);
				break;
			case 2:
			case 6:
				stateMachine.toolId = toolId;
				num = 1;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 3:
				stateMachine._003C_003Et__builder = kWokTngQ2dAyhWMWUwj();
				num = 8;
				break;
			case 1:
				stateMachine.sampleId = sampleId;
				goto default;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetAutoThresholdSettings_003Ed__32))]
	public Task SetAutoThresholdSettings(string toolId, IAutoThresholdSettings newSettings)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eNt8B5gdMi4MQZnxHyd();
		int num = ((!Q2R93egsGbApSwR28eg()) ? 4 : 5);
		_003CSetAutoThresholdSettings_003Ed__32 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine.newSettings = newSettings;
				goto case 6;
			default:
				num = 6;
				if (eNt8B5gdMi4MQZnxHyd())
				{
				}
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = kWokTngQ2dAyhWMWUwj();
				num = 1;
				if (Q2R93egsGbApSwR28eg())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				if (Q2R93egsGbApSwR28eg())
				{
					break;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 2:
			case 4:
				stateMachine.toolId = toolId;
				num = 3;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImage_003Ed__33))]
	private Task<string> idcVpkVXoj(string P_0, ResourceNode P_1, Size P_2 = default(Size))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImage_003Ed__33 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.endpointUrl = P_0;
		stateMachine.toolNode = P_1;
		stateMachine.requestedSize = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Size HifVWsfj8p(Size P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!eNt8B5gdMi4MQZnxHyd())
		{
			num = 12;
			if (!Q2R93egsGbApSwR28eg())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 14;
			if (eNt8B5gdMi4MQZnxHyd())
			{
			}
		}
		Size size2 = default;
		Size size = default;
		int height = default;
		double num2 = default;
		int width = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				break;
			case 2:
				return P_0;
			case 7:
				if (size2.Height < v5dV5hbBig)
				{
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				}
				goto IL_01fc;
			case 4:
			case 14:
				size = default;
				num = 10;
				continue;
			case 5:
				height = (int)mRw8k9gq0OybxDcA5VA((double)P_0.Height / (double)P_0.Width * (double)v5dV5hbBig);
				num = 13;
				continue;
			case 10:
				size.Width = (int)((double)P_0.Width / num2);
				num = 3;
				continue;
			case 8:
				if (size2.Width < v5dV5hbBig)
				{
					num = 7;
					continue;
				}
				goto IL_01fc;
			case 0:
			case 12:
				if (!P_0.IsEmpty)
				{
					if (P_0.Width >= v5dV5hbBig || P_0.Height >= v5dV5hbBig)
					{
						num2 = P_1 / 8.0;
						goto case 4;
					}
					num = 6;
					if (eNt8B5gdMi4MQZnxHyd())
					{
					}
					continue;
				}
				num = 2;
				continue;
			case 9:
				size2 = size;
				goto case 8;
			default:
				num = 8;
				if (!eNt8B5gdMi4MQZnxHyd())
				{
					continue;
				}
				goto case 6;
			case 6:
				size = default;
				num = 11;
				continue;
			case 1:
				return default;
			case 15:
				width = v5dV5hbBig;
				num = 5;
				continue;
			case 3:
				size.Height = (int)((double)P_0.Height / num2);
				num = 9;
				continue;
			case 13:
			case 16:
				{
					return new Size(width, height);
				}
				IL_01fc:
				if (P_0.Width <= P_0.Height)
				{
					width = (int)mRw8k9gq0OybxDcA5VA((double)P_0.Width / (double)P_0.Height * (double)v5dV5hbBig);
					height = v5dV5hbBig;
					num = 16;
					if (Q2R93egsGbApSwR28eg())
					{
						continue;
					}
					goto case 7;
				}
				num = 15;
				continue;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		return size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetModelStatsFromCameraAsync_003Ed__35))]
	private Task<AnomalyDetectStats> exnVS3kcnI(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetModelStatsFromCameraAsync_003Ed__35 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<AnomalyDetectStats>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetResultFromCameraAsync_003Ed__36))]
	private Task<AnomalyDetectorResult> bb4VKUtcS7(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetResultFromCameraAsync_003Ed__36 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<AnomalyDetectorResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamplesFromCameraAsync_003Ed__37))]
	private Task<Dictionary<string, AnomalyDetectSample>> UsMVm47UJJ(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamplesFromCameraAsync_003Ed__37 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Dictionary<string, AnomalyDetectSample>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteSamplesAsync_003Ed__38))]
	private Task HKdVMY9U7e(string P_0, ICollection<string> P_1, CancellationToken P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDeleteSamplesAsync_003Ed__38 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.sampleIds = P_1;
		stateMachine.token = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTrainAsync_003Ed__39))]
	public Task TrainAsync(string toolId, CancellationToken token)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CTrainAsync_003Ed__39 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 2:
				stateMachine._003C_003Et__builder = kWokTngQ2dAyhWMWUwj();
				num = 7;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 4:
				stateMachine.toolId = toolId;
				_ = 1;
				num = (eNt8B5gdMi4MQZnxHyd() ? 1 : 0);
				break;
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 0:
			case 3:
				stateMachine.token = token;
				goto case 6;
			default:
				num = 6;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFeatureSizeSettings_003Ed__40))]
	public Task<IFeatureSizeSettings> GetFeatureSizeSettings(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFeatureSizeSettings_003Ed__40 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IFeatureSizeSettings>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetFeatureSize_003Ed__41))]
	public Task SetFeatureSize(string toolId, double featureSize)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CSetFeatureSize_003Ed__41 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (Q2R93egsGbApSwR28eg())
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine.featureSize = featureSize;
				goto case 7;
			default:
				num = 7;
				if (Q2R93egsGbApSwR28eg())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				Q2R93egsGbApSwR28eg();
				num = ((!eNt8B5gdMi4MQZnxHyd()) ? 1 : 0);
				break;
			case 6:
				stateMachine._003C_003Et__builder = kWokTngQ2dAyhWMWUwj();
				num = 4;
				break;
			case 1:
			case 2:
				stateMachine.toolId = toolId;
				goto case 0;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COptimizeFeatureSize_003Ed__42))]
	public Task OptimizeFeatureSize(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COptimizeFeatureSize_003Ed__42 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine.toolId = toolId;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (eNt8B5gdMi4MQZnxHyd())
				{
				}
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				eNt8B5gdMi4MQZnxHyd();
				if (!Q2R93egsGbApSwR28eg())
				{
					num = 6;
					if (Q2R93egsGbApSwR28eg())
					{
						break;
					}
					goto case 0;
				}
				num = 2;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (Q2R93egsGbApSwR28eg())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	protected abstract AnomalyDetectToolApi GetTool(string toolId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunToolAsync_003Ed__44))]
	protected override Task RunToolAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eNt8B5gdMi4MQZnxHyd();
		int num;
		if (Q2R93egsGbApSwR28eg())
		{
			num = 2;
			if (eNt8B5gdMi4MQZnxHyd())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0062;
		IL_0062:
		_003CRunToolAsync_003Ed__44 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 4:
				goto IL_0048;
			default:
				num = 3;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = kWokTngQ2dAyhWMWUwj();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_0048:
		stateMachine._003C_003E1__state = -1;
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (1 == 0)
		{
			goto IL_0048;
		}
		goto IL_0062;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalDisposeCaches()
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
			case 2:
			case 5:
				DBeVLXdNet.Dispose();
				goto case 3;
			default:
				num = 3;
				if (eNt8B5gdMi4MQZnxHyd())
				{
				}
				break;
			case 3:
				TSEXgJgLI9kxgWutGrB(YARVdRkZrx);
				num = 6;
				if (eNt8B5gdMi4MQZnxHyd())
				{
				}
				break;
			case 0:
			case 1:
				nodo0Ggi1ehMtOAqsiY(px6VvCVbRJ);
				goto case 2;
			case 4:
				D6e3T8gVGK0C4xfThee(P1xV0tQjEG);
				Q2R93egsGbApSwR28eg();
				num = (eNt8B5gdMi4MQZnxHyd() ? 5 : 0);
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnomalyDetectAdapterBase()
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
			case 1:
				MilV7QBvO5 = (string)P12VPyg9wDg7mReLuHA(894);
				break;
			case 3:
				zb9EfegtMPHienQRqMh();
				_ = 0;
				num = ((!Q2R93egsGbApSwR28eg()) ? 4 : 0);
				continue;
			case 5:
				return;
			}
			vEsVYnQaZh = (string)P12VPyg9wDg7mReLuHA(6726);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c2HH3ngEEwDQvWbIitD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AnomalyDetectorClient.RegisterAdapter((IAnomalyDetectorAdapter)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qhNyAcg5HFCqODGb69m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentUICulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TGxKh4g3E4ZrG4QmaIJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CultureInfo)P_0).TwoLetterISOLanguageName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XfZXFqgaE1CJN7Dvn3I(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((LocalizationOverride)P_0).key = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QIoCchgosTNdJ1qIXlX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NextImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ktHsSMgcF25jTttLeJF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((LocalizationOverride)P_0).value = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void llSHuigu0ZT4SDodu1m(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AnomalyDetectorClient.SetLocale((string)P_0, (LocalizationOverride[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q2R93egsGbApSwR28eg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eNt8B5gdMi4MQZnxHyd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s9PI8pgB6ckcgELKZTH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((NewResultArgs)P_0).ToolId = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dol9cpgxnv5RDFpMRrr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NewResultArgs)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OcfTHmghbZTYbm1qWOV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dispatcher)P_0).CheckAccess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Iu99hAgUD8291PgEl3K(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Dispatcher)P_0).Invoke((Action)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder kWokTngQ2dAyhWMWUwj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double mRw8k9gq0OybxDcA5VA(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Round(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D6e3T8gVGK0C4xfThee(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AsyncCache<string, AnomalyDetectStats>)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nodo0Ggi1ehMtOAqsiY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AsyncCache<string, AnomalyDetectorResult>)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TSEXgJgLI9kxgWutGrB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Dictionary<string, Dictionary<string, AnomalyDetectSample>>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zb9EfegtMPHienQRqMh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P12VPyg9wDg7mReLuHA(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}
}
