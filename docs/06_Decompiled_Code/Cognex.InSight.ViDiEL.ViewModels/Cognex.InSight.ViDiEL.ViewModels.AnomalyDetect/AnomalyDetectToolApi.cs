using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.AnomalyDetector.Client;
using Cognex.AnomalyDetector.Client.Tool.Interfaces;
using Cognex.Extensions;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.ViDiEL.AnomalyDetect;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.AnomalyDetect;

public class AnomalyDetectToolApi
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetModelStats_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELAnomalyDetectorModelStats> _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<ELAnomalyDetectorModelStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (TBCi6EiM3qMFLTYaT2t() ? 4 : 3);
			ELAnomalyDetectorModelStats result = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			int num2 = default;
			do
			{
				IL_01a7:
				switch (num)
				{
				case 1:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						goto IL_01a7;
					}
					goto case 5;
				case 5:
					anomalyDetectToolApi = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<ELAnomalyDetectorModelStats> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.GetAsync<ELAnomalyDetectorModelStats>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7100)).GetAwaiter();
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
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								num3 = ((!TBCi6EiM3qMFLTYaT2t()) ? 1 : 7);
								continue;
							default:
								return;
							case 7:
								return;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
					if (D7JcuRiXeQMnWKHKLGU())
					{
						goto IL_01a7;
					}
					break;
				case 0:
				case 3:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 5;
			}
			while (!TBCi6EiM3qMFLTYaT2t());
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
		internal static bool D7JcuRiXeQMnWKHKLGU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TBCi6EiM3qMFLTYaT2t()
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
	private struct _003CGetInferenceSize_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Size> _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<CogSize> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (eXnxyVimZY9K5DkmEiB())
			{
				goto IL_001e;
			}
			goto IL_01d9;
			IL_001e:
			int num2 = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			Size result2 = default;
			try
			{
				try
				{
					TaskAwaiter<CogSize> awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = anomalyDetectToolApi.ToolNode.GetAsync<CogSize>((string)CDsu3oir7MViK7ZWtu6(7124)).GetAwaiter();
						num3 = 9;
						goto IL_00d8;
					}
					awaiter = _003C_003Eu__1;
					goto IL_008e;
					IL_008e:
					do
					{
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						_ = 1;
						if (eXnxyVimZY9K5DkmEiB())
						{
							num3 = 10;
							continue;
						}
						num3 = 2;
						break;
					}
					while (!UuEZVdikLsaikubs14Z());
					goto IL_00d8;
					IL_00d8:
					CogSize result = default;
					while (true)
					{
						switch (num3)
						{
						case 7:
							num2 = (_003C_003E1__state = 0);
							num3 = 1;
							continue;
						case 1:
							_003C_003Eu__1 = awaiter;
							num3 = 0;
							continue;
						case 4:
							if (result == null)
							{
								goto case 8;
							}
							result2 = new Size(Dm2Veri4s3attETtkyM(Mh786FiPpjeOSdLfMhI(result), MidpointRounding.AwayFromZero), Dm2Veri4s3attETtkyM(PJBkmdigBotOkQW4rKm(result), MidpointRounding.AwayFromZero));
							goto end_IL_00d8;
						case 3:
							break;
						case 5:
							return;
						default:
							num3 = 3;
							if (0 == 0)
							{
								continue;
							}
							goto case 8;
						case 8:
						case 10:
							result2 = Size.Empty;
							num3 = 11;
							continue;
						case 2:
						case 6:
							result = awaiter.GetResult();
							num3 = 4;
							continue;
						case 9:
							if (!awaiter.IsCompleted)
							{
								num3 = 7;
								continue;
							}
							goto case 2;
						case 0:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 5;
							if (UuEZVdikLsaikubs14Z())
							{
								continue;
							}
							goto end_IL_00d8;
						case 11:
							goto end_IL_00d8;
						}
						goto IL_008e;
						continue;
						end_IL_00d8:
						break;
					}
				}
				catch
				{
					result2 = Size.Empty;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_023c;
			IL_01d9:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 0:
					goto IL_021b;
				default:
					goto IL_023c;
				case 6:
					return;
				}
				break;
				IL_021b:
				anomalyDetectToolApi = _003C_003E4__this;
				eXnxyVimZY9K5DkmEiB();
				num = ((!UuEZVdikLsaikubs14Z()) ? 1 : 5);
			}
			goto IL_001e;
			IL_023c:
			_003C_003Et__builder.SetResult(result2);
			num = 6;
			goto IL_01d9;
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
		internal static object CDsu3oir7MViK7ZWtu6(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double Mh786FiPpjeOSdLfMhI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CogSize)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Dm2Veri4s3attETtkyM(double P_0, MidpointRounding P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.Round(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double PJBkmdigBotOkQW4rKm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CogSize)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UuEZVdikLsaikubs14Z()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eXnxyVimZY9K5DkmEiB()
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
	private struct _003CGetFixedRoiSize_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Size> _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<CogSize> _003C_003Eu__1;

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
			goto IL_0227;
			IL_0068:
			int num2 = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			Size result2 = default;
			try
			{
				try
				{
					TaskAwaiter<CogSize> awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = anomalyDetectToolApi.ToolNode.GetAsync<CogSize>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7154)).GetAwaiter();
						num3 = 4;
						if (!Cy6Mnhi1EQ7hQcUxZTG())
						{
							goto IL_009d;
						}
						goto IL_0172;
					}
					awaiter = _003C_003Eu__1;
					goto IL_00de;
					IL_00bc:
					CogSize result = awaiter.GetResult();
					num3 = 9;
					goto IL_0172;
					IL_00b3:
					num2 = (_003C_003E1__state = -1);
					goto IL_00bc;
					IL_009d:
					if (result == null)
					{
						num3 = 6;
						if (!Cy6Mnhi1EQ7hQcUxZTG())
						{
							goto IL_00b3;
						}
						goto IL_0172;
					}
					result2 = new Size(usiVBViDRD2AME6rxFh(N7vNb6i67HRNI9PM8HJ(result), MidpointRounding.AwayFromZero), usiVBViDRD2AME6rxFh(result.Height, MidpointRounding.AwayFromZero));
					goto end_IL_006b;
					IL_00de:
					_003C_003Eu__1 = default;
					num3 = 10;
					goto IL_0172;
					IL_0172:
					while (true)
					{
						switch (num3)
						{
						case 9:
							break;
						case 10:
							goto IL_00b3;
						case 6:
							result2 = Size.Empty;
							num3 = 11;
							continue;
						default:
							goto IL_00de;
						case 8:
							goto IL_00f4;
						case 1:
						case 2:
							_003C_003Eu__1 = awaiter;
							num3 = 7;
							continue;
						case 4:
							goto IL_0125;
						case 7:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 0;
							continue;
						case 0:
							return;
						case 11:
							goto end_IL_006b;
						}
						break;
						IL_0125:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							continue;
						}
						goto IL_00bc;
						IL_00f4:
						num2 = (_003C_003E1__state = 0);
						_ = 0;
						if (Cy6Mnhi1EQ7hQcUxZTG())
						{
							num3 = 1;
							continue;
						}
						num3 = 3;
						if (!Tl0ScoiSG3kg1lSsXTK())
						{
							continue;
						}
						goto end_IL_006b;
					}
					goto IL_009d;
					end_IL_006b:;
				}
				catch
				{
					result2 = Size.Empty;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0052;
			IL_0227:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 0:
					goto IL_0031;
				case 4:
					goto IL_0052;
				case 2:
				case 5:
					goto IL_0068;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
				IL_0031:
				num2 = _003C_003E1__state;
				Tl0ScoiSG3kg1lSsXTK();
				num = (Cy6Mnhi1EQ7hQcUxZTG() ? 3 : 5);
			}
			goto IL_001a;
			IL_0052:
			_003C_003Et__builder.SetResult(result2);
			num = 6;
			goto IL_0227;
			IL_001a:
			anomalyDetectToolApi = _003C_003E4__this;
			goto IL_0068;
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
		internal static double N7vNb6i67HRNI9PM8HJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CogSize)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int usiVBViDRD2AME6rxFh(double P_0, MidpointRounding P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.Round(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Cy6Mnhi1EQ7hQcUxZTG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tl0ScoiSG3kg1lSsXTK()
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
	private struct _003CGetSamples_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELAnomalyDetectorSample[]> _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<ELAnomalyDetectorSample[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			ELAnomalyDetectorSample[] result = default;
			int num2 = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					anomalyDetectToolApi = _003C_003E4__this;
					A5nGAbi8aOkM4K9WA3K();
					if (!SKpi25iFcPrr3wt4MBV())
					{
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 0;
					}
					num = 4;
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<ELAnomalyDetectorSample[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.GetAsync<ELAnomalyDetectorSample[]>((string)B1y4fPisLgTeTvFFX5d(7182)).GetAwaiter();
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							SKpi25iFcPrr3wt4MBV();
							if (!A5nGAbi8aOkM4K9WA3K())
							{
								num3 = 8;
								if (false)
								{
									goto IL_00bc;
								}
							}
							else
							{
								num3 = 1;
							}
						}
						goto IL_00ef;
						IL_00ef:
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 1:
							case 5:
								_003C_003Eu__1 = default;
								goto case 6;
							case 3:
								break;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 7:
								return;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00ef;
							}
							goto IL_00bc;
							continue;
							end_IL_00ef:
							break;
						}
						goto end_IL_0062;
						IL_00bc:
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						goto IL_00ef;
						end_IL_0062:;
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
		internal static object B1y4fPisLgTeTvFFX5d(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A5nGAbi8aOkM4K9WA3K()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SKpi25iFcPrr3wt4MBV()
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
	private struct _003CDeleteSamples_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		public ICollection<string> sampleIds;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!dpfncVidnIp04jCTL0M())
			{
				goto IL_001e;
			}
			goto IL_01c7;
			IL_001e:
			int num2 = _003C_003E1__state;
			WQsDPsiEdMoBVqeRg8u();
			if (dpfncVidnIp04jCTL0M())
			{
				num = 0;
				if (WQsDPsiEdMoBVqeRg8u())
				{
					goto IL_0045;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01c7;
			IL_01c7:
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					goto IL_0045;
				case 5:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.PostAsync<object>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7200), new object[1] { sampleIds }).GetAwaiter();
							_ = 1;
							if (!WQsDPsiEdMoBVqeRg8u())
							{
								num3 = 1;
								if (WQsDPsiEdMoBVqeRg8u())
								{
									goto IL_00a6;
								}
							}
							else
							{
								num3 = 2;
								if (false)
								{
									goto IL_00bf;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						goto IL_010b;
						IL_00a6:
						_003C_003Eu__1 = awaiter;
						goto IL_00eb;
						IL_010b:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 6:
								goto IL_00bf;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (!WQsDPsiEdMoBVqeRg8u())
								{
									continue;
								}
								goto IL_00eb;
							case 2:
							case 3:
								goto IL_00eb;
							default:
								num3 = 4;
								continue;
							case 4:
								return;
							case 0:
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_005a;
							}
							break;
						}
						goto IL_00a6;
						IL_00bf:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_010b;
						IL_00eb:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_005a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_0045;
				case 0:
				case 1:
					anomalyDetectToolApi = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_0045:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01c7;
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
		internal static bool dpfncVidnIp04jCTL0M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WQsDPsiEdMoBVqeRg8u()
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
	private struct _003CLabelCurrentImage_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		public AnomalyDetectorLabels label;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mntaZ3i5qvT2Y2IDNmw();
			int num;
			if (!YitpZBi3jHFh4HGv6rC())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_01ae;
			IL_01d9:
			AnomalyDetectToolApi anomalyDetectToolApi = _003C_003E4__this;
			num = 5;
			if (!YitpZBi3jHFh4HGv6rC())
			{
				goto IL_01ae;
			}
			goto IL_01f0;
			IL_01ae:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 5:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.PostAsync<object>((string)kBB172iaT4YFk3HTTAj(7230), new object[1] { label == AnomalyDetectorLabels.OK }).GetAwaiter();
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (!mntaZ3i5qvT2Y2IDNmw())
							{
								goto IL_016d;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 2:
								do
								{
									_003C_003Eu__1 = awaiter;
									_ = 0;
									if (!mntaZ3i5qvT2Y2IDNmw())
									{
										num3 = 0;
										continue;
									}
									num3 = 7;
									break;
								}
								while (false);
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 0:
								return;
							case 9:
								break;
							}
							break;
						}
						goto IL_016d;
						IL_016d:
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_01f0;
				default:
					num = 4;
					continue;
				case 1:
				case 3:
					goto IL_01d9;
				case 4:
					goto IL_01f0;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_01d9;
			IL_01f0:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (YitpZBi3jHFh4HGv6rC())
			{
			}
			goto IL_01ae;
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
		internal static object kBB172iaT4YFk3HTTAj(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mntaZ3i5qvT2Y2IDNmw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YitpZBi3jHFh4HGv6rC()
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
	private struct _003CLabelImage_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		public string sampleId;

		public AnomalyDetectorLabels label;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sjiTkNioQN5MVmANsug();
			int num = (sh3QCpicPoJJqMwcPeW() ? 4 : 3);
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					anomalyDetectToolApi = _003C_003E4__this;
					num = 5;
					if (!sh3QCpicPoJJqMwcPeW())
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.PostAsync<object>((string)esOmp7iuRuLDtoeEv2V(7290), new object[2]
							{
								sampleId,
								label == AnomalyDetectorLabels.OK
							}).GetAwaiter();
							sjiTkNioQN5MVmANsug();
							if (!sh3QCpicPoJJqMwcPeW())
							{
								num3 = 6;
								if (!sjiTkNioQN5MVmANsug())
								{
									goto IL_00a0;
								}
							}
							else
							{
								num3 = 7;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						goto IL_00d6;
						IL_00a0:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_00d6;
						IL_00d6:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									if (true)
									{
										continue;
									}
									goto case 3;
								}
								goto case 9;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!sh3QCpicPoJJqMwcPeW())
								{
									continue;
								}
								return;
							case 4:
								return;
							case 1:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_00d6;
							}
							goto IL_00a0;
							continue;
							end_IL_00d6:
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
					goto case 2;
				default:
					num = 2;
					break;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
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
		internal static object esOmp7iuRuLDtoeEv2V(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sjiTkNioQN5MVmANsug()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sh3QCpicPoJJqMwcPeW()
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
	private struct _003CGetAutoThresholdSettings_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELAnomalyDetectorAutoThresholdSettings> _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<ELAnomalyDetectorAutoThresholdSettings> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!d6YqGtiB32Fk2nbota0())
			{
				goto IL_001e;
			}
			goto IL_019b;
			IL_001e:
			ELAnomalyDetectorAutoThresholdSettings result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_019b;
			IL_019b:
			int num2 = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<ELAnomalyDetectorAutoThresholdSettings> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.GetAsync<ELAnomalyDetectorAutoThresholdSettings>((string)uVXLdjihVC5KRd0Q077(7866)).GetAwaiter();
							_ = 0;
							num3 = ((!d6YqGtiB32Fk2nbota0()) ? 2 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__1 = default;
								goto case 2;
							case 8:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!E8mGNqixDUe7JXIkyN2())
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
					anomalyDetectToolApi = _003C_003E4__this;
					d6YqGtiB32Fk2nbota0();
					num = ((!E8mGNqixDUe7JXIkyN2()) ? 1 : 4);
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object uVXLdjihVC5KRd0Q077(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d6YqGtiB32Fk2nbota0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E8mGNqixDUe7JXIkyN2()
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
	private struct _003CSetAutoThresholdSettings_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		public IAutoThresholdSettings newSettings;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.PostAsync<object>((string)JvG6NIiqyWdKF9VcC5B(7866), new object[2]
							{
								mUIc1CiVqWlXvfRjMxk(newSettings),
								(int)AgiDjNiicfFu9n7UYTD(newSettings)
							}).GetAwaiter();
							num3 = 7;
							goto IL_00b6;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0080;
						IL_0080:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_00b6;
						IL_00b6:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 3:
							case 5:
								break;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = 0);
								MXoslQiU66CiibA0A74();
								num3 = (yKYSiWiQUbnMX4xg9fD() ? 3 : 0);
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 9;
							case 8:
								return;
							case 9:
								awaiter.GetResult();
								goto end_IL_00b6;
							}
							goto IL_0080;
							continue;
							end_IL_00b6:
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
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!yKYSiWiQUbnMX4xg9fD()) ? 4 : 5);
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				anomalyDetectToolApi = _003C_003E4__this;
				num = 0;
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
		internal static object JvG6NIiqyWdKF9VcC5B(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mUIc1CiVqWlXvfRjMxk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAutoThresholdSettings)P_0).UseAutoThreshold;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AutoThresholdOptions AgiDjNiicfFu9n7UYTD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAutoThresholdSettings)P_0).SelectedOption;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MXoslQiU66CiibA0A74()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yKYSiWiQUbnMX4xg9fD()
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
	private struct _003CTrain_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!XJ8sQeitelvT3cAOXCD())
			{
				num = 1;
				if (!gFa2uJiLpq4wusT3Xdh())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0195;
			IL_01c0:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0195;
			IL_0195:
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_01c0;
				case 5:
					anomalyDetectToolApi = _003C_003E4__this;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				TaskAwaiter<object> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = anomalyDetectToolApi.ToolNode.PostAsync<object>((string)pVirdUi9PqCBfVqF6nX(7402), Array.Empty<object>()).GetAwaiter();
					num3 = 4;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 8;
				}
				while (true)
				{
					switch (num3)
					{
					case 6:
						return;
					case 3:
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 6;
						continue;
					case 8:
						_003C_003Eu__1 = default;
						num3 = 2;
						continue;
					case 4:
						if (awaiter.IsCompleted)
						{
							break;
						}
						gFa2uJiLpq4wusT3Xdh();
						if (!XJ8sQeitelvT3cAOXCD())
						{
							num3 = 7;
							if (0 == 0)
							{
								continue;
							}
							goto case 1;
						}
						num3 = 5;
						if (gFa2uJiLpq4wusT3Xdh())
						{
							continue;
						}
						break;
					case 1:
					case 7:
						num2 = (_003C_003E1__state = 0);
						num3 = 0;
						if (XJ8sQeitelvT3cAOXCD())
						{
						}
						continue;
					case 2:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (true)
						{
							continue;
						}
						goto case 0;
					case 0:
						_003C_003Eu__1 = awaiter;
						goto case 3;
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
			goto IL_01c0;
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
		internal static object pVirdUi9PqCBfVqF6nX(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gFa2uJiLpq4wusT3Xdh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XJ8sQeitelvT3cAOXCD()
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
	private struct _003CGetScaledThreshold_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<float> _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<double> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (M5PHClivNVSoE6mk5i8())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (BFffkGiZ5w0ixGpdmix())
				{
					goto IL_01e0;
				}
			}
			goto IL_0198;
			IL_0198:
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			int num2 = default;
			float result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					anomalyDetectToolApi = _003C_003E4__this;
					num = 3;
					if (M5PHClivNVSoE6mk5i8())
					{
						continue;
					}
					goto case 3;
				case 3:
					try
					{
						TaskAwaiter<double> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.GetAsync<double>((string)XvZu9gi0UJ2tNvZJCYh(7896)).GetAwaiter();
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 1:
								return;
							case 4:
								_003C_003Eu__1 = default;
								goto case 0;
							case 8:
								num2 = (_003C_003E1__state = 0);
								M5PHClivNVSoE6mk5i8();
								if (BFffkGiZ5w0ixGpdmix())
								{
									num3 = 0;
									continue;
								}
								num3 = 5;
								if (!BFffkGiZ5w0ixGpdmix())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								break;
							}
							break;
						}
						result = (float)awaiter.GetResult();
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
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_01e0;
			IL_01e0:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0198;
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
		internal static object XvZu9gi0UJ2tNvZJCYh(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M5PHClivNVSoE6mk5i8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BFffkGiZ5w0ixGpdmix()
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
	private struct _003CGetFeatureSizeSettings_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELAnomalyDetectorFeatureSizeSettings> _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<ELAnomalyDetectorFeatureSizeSettings> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			ELAnomalyDetectorFeatureSizeSettings result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						TaskAwaiter<ELAnomalyDetectorFeatureSizeSettings> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.GetAsync<ELAnomalyDetectorFeatureSizeSettings>((string)r5fiiTiT1CRTj0Qw633(7930)).GetAwaiter();
							_ = 1;
							if (!fZ7KEViHT9sTiGQRIMN())
							{
								num3 = 7;
								if (1 == 0)
								{
									goto IL_0051;
								}
							}
							else
							{
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_00ab;
						IL_0051:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_00ab;
						IL_00ab:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									goto case 1;
								}
								goto case 9;
							case 3:
								return;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00ab;
							}
							goto IL_0051;
							continue;
							end_IL_00ab:
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
				case 1:
				case 4:
					anomalyDetectToolApi = _003C_003E4__this;
					goto case 2;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (VFlOvRiOOeD6bFNcMtr())
					{
						break;
					}
					goto case 0;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!VFlOvRiOOeD6bFNcMtr())
					{
						num = 3;
						if (true)
						{
							break;
						}
						goto case 5;
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
		internal static object r5fiiTiT1CRTj0Qw633(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VFlOvRiOOeD6bFNcMtr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fZ7KEViHT9sTiGQRIMN()
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
	private struct _003CSetFeatureSize_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		public double newSettings;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (PiyaoZiY41jJoHS7fpA())
					{
						break;
					}
					goto case 4;
				case 4:
					anomalyDetectToolApi = _003C_003E4__this;
					IkLdlFiJfnUBK0KCKKw();
					if (PiyaoZiY41jJoHS7fpA())
					{
						num = 0;
						if (PiyaoZiY41jJoHS7fpA())
						{
							break;
						}
						goto case 0;
					}
					num = 5;
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.PutAsync<object>((string)EHc5bDiKuRK3y12yHYC(7972), newSettings).GetAwaiter();
							num3 = 5;
							if (!PiyaoZiY41jJoHS7fpA())
							{
								goto IL_0096;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						goto IL_0117;
						IL_0117:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 3:
							case 6:
								goto IL_00b8;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 2:
							case 4:
								return;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								PiyaoZiY41jJoHS7fpA();
								if (IkLdlFiJfnUBK0KCKKw())
								{
									num3 = 3;
									if (PiyaoZiY41jJoHS7fpA())
									{
										continue;
									}
									goto IL_00b8;
								}
								num3 = 2;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_005a;
							}
							break;
						}
						goto IL_0096;
						IL_00b8:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_0117;
						IL_0096:
						_003C_003Eu__1 = default;
						goto IL_00b8;
						end_IL_005a:;
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
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static object EHc5bDiKuRK3y12yHYC(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PiyaoZiY41jJoHS7fpA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IkLdlFiJfnUBK0KCKKw()
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
	private struct _003COptimizeFeatureSize_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_01be;
			IL_001a:
			int num2 = _003C_003E1__state;
			num = 5;
			goto IL_01be;
			IL_01be:
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 5:
					anomalyDetectToolApi = _003C_003E4__this;
					_ = 1;
					if (!qpI03YiAoAvLVm0xbjM())
					{
						num = 0;
						continue;
					}
					num = 1;
					if (SgWKLiiCevTqKwFRawm())
					{
						continue;
					}
					goto default;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<Stream> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.PostHttpAsync((string)zfpiUpiNC5NtEiwYj9x(7998), MMCVPIEnBW, (string)zfpiUpiNC5NtEiwYj9x(8040), Stream.Null).GetAwaiter();
							qpI03YiAoAvLVm0xbjM();
							if (SgWKLiiCevTqKwFRawm())
							{
								num3 = 5;
							}
							else
							{
								num3 = 8;
								if (1 == 0)
								{
									goto IL_00db;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (qpI03YiAoAvLVm0xbjM())
							{
								goto IL_0167;
							}
						}
						goto IL_010e;
						IL_010e:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 0:
							case 5:
								if (!awaiter.IsCompleted)
								{
									goto case 1;
								}
								goto case 9;
							case 2:
								break;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (!qpI03YiAoAvLVm0xbjM())
								{
									continue;
								}
								return;
							case 7:
								return;
							case 6:
								goto IL_0167;
							case 9:
								awaiter.GetResult();
								goto end_IL_0048;
							}
							break;
						}
						goto IL_00db;
						IL_00db:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_010e;
						IL_0167:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_010e;
						end_IL_0048:;
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
		internal static object zfpiUpiNC5NtEiwYj9x(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SgWKLiiCevTqKwFRawm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qpI03YiAoAvLVm0xbjM()
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
	private struct _003CGetResult_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELAnomalyDetectorResult> _003C_003Et__builder;

		public AnomalyDetectToolApi _003C_003E4__this;

		private TaskAwaiter<ELAnomalyDetectorResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			AnomalyDetectToolApi anomalyDetectToolApi = default;
			ELAnomalyDetectorResult result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					anomalyDetectToolApi = _003C_003E4__this;
					goto case 2;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
					num2 = _003C_003E1__state;
					mOGfx4iwD0nPQqAHvtN();
					num = ((!TApihiipPPVlLr9fg2R()) ? 4 : 5);
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<ELAnomalyDetectorResult> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = anomalyDetectToolApi.ToolNode.GetAsync<ELAnomalyDetectorResult>((string)U6bYdoiGHXfHVKbNQya(7416)).GetAwaiter();
							num3 = 6;
							if (1 == 0)
							{
								goto IL_0095;
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
							case 0:
								break;
							case 6:
								if (!awaiter.IsCompleted)
								{
									TApihiipPPVlLr9fg2R();
									if (!mOGfx4iwD0nPQqAHvtN())
									{
										num3 = 8;
										continue;
									}
									num3 = 2;
									if (mOGfx4iwD0nPQqAHvtN())
									{
										continue;
									}
									goto case 7;
								}
								goto case 9;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 5:
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto IL_012c;
							case 3:
							case 8:
								goto IL_012c;
							default:
								num3 = 5;
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_0068;
							}
							break;
						}
						goto IL_0095;
						IL_0095:
						_003C_003Eu__1 = awaiter;
						goto IL_012c;
						IL_012c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0068:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
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
		internal static object U6bYdoiGHXfHVKbNQya(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mOGfx4iwD0nPQqAHvtN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TApihiipPPVlLr9fg2R()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly TimeSpan MMCVPIEnBW;

	[CompilerGenerated]
	private ResourceNode hOlVqcFHlb;

	public ResourceNode ToolNode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hOlVqcFHlb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hOlVqcFHlb = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetModelStats_003Ed__5))]
	public Task<ELAnomalyDetectorModelStats> GetModelStats()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetModelStats_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELAnomalyDetectorModelStats>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetInferenceSize_003Ed__6))]
	public Task<Size> GetInferenceSize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetInferenceSize_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Size>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFixedRoiSize_003Ed__7))]
	public Task<Size> GetFixedRoiSize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFixedRoiSize_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Size>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamples_003Ed__8))]
	public Task<ELAnomalyDetectorSample[]> GetSamples()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamples_003Ed__8 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELAnomalyDetectorSample[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteSamples_003Ed__9))]
	public Task DeleteSamples(ICollection<string> sampleIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDeleteSamples_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sampleIds = sampleIds;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLabelCurrentImage_003Ed__10))]
	public Task LabelCurrentImage(AnomalyDetectorLabels label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CLabelCurrentImage_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.label = label;
				goto default;
			default:
				B8Xu0EgpxUOHB35DpgS();
				num = ((!m6AcH6gwfJdKSEB2SYS()) ? 6 : 5);
				break;
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 0;
				if (m6AcH6gwfJdKSEB2SYS())
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLabelImage_003Ed__11))]
	public Task LabelImage(string sampleId, AnomalyDetectorLabels label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B8Xu0EgpxUOHB35DpgS();
		int num;
		if (m6AcH6gwfJdKSEB2SYS())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_00b6;
		IL_0044:
		_003CLabelImage_003Ed__11 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 6;
		goto IL_00b6;
		IL_00b6:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 2:
				goto IL_0044;
			case 6:
				stateMachine.sampleId = sampleId;
				num = 5;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto IL_0044;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				if (m6AcH6gwfJdKSEB2SYS())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine.label = label;
				goto case 7;
			default:
				num = 7;
				if (m6AcH6gwfJdKSEB2SYS())
				{
					continue;
				}
				goto case 8;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 8;
		if (false)
		{
			goto IL_0044;
		}
		goto IL_00b6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAutoThresholdSettings_003Ed__12))]
	public Task<ELAnomalyDetectorAutoThresholdSettings> GetAutoThresholdSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAutoThresholdSettings_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELAnomalyDetectorAutoThresholdSettings>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetAutoThresholdSettings_003Ed__13))]
	public Task SetAutoThresholdSettings(IAutoThresholdSettings newSettings)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!m6AcH6gwfJdKSEB2SYS()) ? 2 : 3);
		_003CSetAutoThresholdSettings_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = XBWWUQgGdeWyyV6RA5S();
				num = 6;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 5:
				stateMachine.newSettings = newSettings;
				goto case 1;
			default:
				num = 1;
				if (!B8Xu0EgpxUOHB35DpgS())
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
	[AsyncStateMachine(typeof(_003CTrain_003Ed__14))]
	public Task Train()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!m6AcH6gwfJdKSEB2SYS())
		{
			goto IL_001e;
		}
		goto IL_008a;
		IL_008a:
		_003CTrain_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				goto IL_0042;
			case 0:
				stateMachine._003C_003Et__builder = XBWWUQgGdeWyyV6RA5S();
				num = 4;
				continue;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto IL_0042;
			case 6:
				goto IL_00c1;
			}
			break;
		}
		goto IL_001e;
		IL_00c1:
		return stateMachine._003C_003Et__builder.Task;
		IL_0042:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_008a;
		IL_001e:
		stateMachine._003C_003E4__this = this;
		B8Xu0EgpxUOHB35DpgS();
		if (m6AcH6gwfJdKSEB2SYS())
		{
			num = 5;
			if (false)
			{
				goto IL_0042;
			}
		}
		else
		{
			num = 1;
			if (B8Xu0EgpxUOHB35DpgS())
			{
				goto IL_00c1;
			}
		}
		goto IL_008a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetScaledThreshold_003Ed__15))]
	public Task<float> GetScaledThreshold()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetScaledThreshold_003Ed__15 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<float>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFeatureSizeSettings_003Ed__16))]
	public Task<ELAnomalyDetectorFeatureSizeSettings> GetFeatureSizeSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFeatureSizeSettings_003Ed__16 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELAnomalyDetectorFeatureSizeSettings>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetFeatureSize_003Ed__17))]
	public Task SetFeatureSize(double newSettings)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSetFeatureSize_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (m6AcH6gwfJdKSEB2SYS())
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				stateMachine.newSettings = newSettings;
				goto case 0;
			default:
				num = 0;
				break;
			case 3:
				stateMachine._003C_003Et__builder = XBWWUQgGdeWyyV6RA5S();
				_ = 1;
				num = ((!B8Xu0EgpxUOHB35DpgS()) ? 5 : 4);
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COptimizeFeatureSize_003Ed__18))]
	public Task OptimizeFeatureSize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COptimizeFeatureSize_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = XBWWUQgGdeWyyV6RA5S();
				B8Xu0EgpxUOHB35DpgS();
				num = (m6AcH6gwfJdKSEB2SYS() ? 4 : 2);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetResult_003Ed__19))]
	public Task<ELAnomalyDetectorResult> GetResult()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetResult_003Ed__19 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELAnomalyDetectorResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnomalyDetectToolApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yBrJJngRIIcuM0oQjAN();
		jxk6Ldgjp40nllpw20I(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnomalyDetectToolApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yBrJJngRIIcuM0oQjAN();
		MMCVPIEnBW = TimeSpan.FromSeconds(120.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m6AcH6gwfJdKSEB2SYS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B8Xu0EgpxUOHB35DpgS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder XBWWUQgGdeWyyV6RA5S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yBrJJngRIIcuM0oQjAN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jxk6Ldgjp40nllpw20I(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
