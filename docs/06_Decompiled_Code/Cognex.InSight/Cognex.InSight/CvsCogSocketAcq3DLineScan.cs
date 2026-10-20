using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.Configuration;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.Remoting.CogSocket;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsCogSocketAcq3DLineScan : CvsCogSocketAcq, ICogSocketAcq3DLineScan, ICogSocketAcq, ICogSocketAcqProperties
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddPointCloudReadyListenerAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq3DLineScan _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!aniFtb8xyiQEL4oZkFO()) ? 2 : 5);
			int num2 = default;
			TaskAwaiter awaiter = default;
			CvsCogSocketAcq3DLineScan cvsCogSocketAcq3DLineScan = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							goto IL_0139;
						}
						if (Interlocked.Increment(ref cvsCogSocketAcq3DLineScan.xSB1bqtykY) == 1)
						{
							num3 = 7;
							goto IL_0139;
						}
						goto end_IL_003b;
						IL_0139:
						while (true)
						{
							switch (num3)
							{
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 1:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 4;
								if (true)
								{
									continue;
								}
								return;
							case 9:
								return;
							case 7:
								awaiter = E7Tadp8MKwqkcselZgo(W1Fu6f8OsLglny2mmos(qlrHkU8rQC1HgNmJdpn(cvsCogSocketAcq3DLineScan._cogSocket), cvsCogSocketAcq3DLineScan.AcqPath + (string)vOG1MM83tvQotelZxW7(49164), new CogSocketEventHandler(cvsCogSocketAcq3DLineScan.JUQ11tTwOg)));
								_ = 0;
								if (!aniFtb8xyiQEL4oZkFO())
								{
									num3 = 5;
									if (true)
									{
										continue;
									}
									goto case 1;
								}
								num3 = 2;
								continue;
							case 3:
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_003b:;
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
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					cvsCogSocketAcq3DLineScan = _003C_003E4__this;
					num = 3;
					if (aniFtb8xyiQEL4oZkFO())
					{
						break;
					}
					goto case 0;
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
		internal static object qlrHkU8rQC1HgNmJdpn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vOG1MM83tvQotelZxW7(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object W1Fu6f8OsLglny2mmos(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRemoteDeviceApi)P_0).AddListener((string)P_1, (CogSocketEventHandler)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter E7Tadp8MKwqkcselZgo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aniFtb8xyiQEL4oZkFO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Brk6h78108fhEYZI4qc()
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
	private struct _003CRemovePointCloudReadyListenerAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq3DLineScan _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GDPrvu8QUPV4ItFZvJK();
			int num = (m3EyeK8lNGfO9am5gNJ() ? 5 : 4);
			int num2 = default;
			TaskAwaiter awaiter = default;
			CvsCogSocketAcq3DLineScan cvsCogSocketAcq3DLineScan = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 2:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							goto IL_005f;
						}
						int num3;
						if (Interlocked.Decrement(ref cvsCogSocketAcq3DLineScan.xSB1bqtykY) == 0)
						{
							num3 = 3;
							goto IL_00e8;
						}
						goto end_IL_003f;
						IL_00e8:
						while (true)
						{
							switch (num3)
							{
							case 6:
							case 7:
								break;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 10;
							case 5:
							case 9:
								return;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								m3EyeK8lNGfO9am5gNJ();
								num3 = (GDPrvu8QUPV4ItFZvJK() ? 9 : 7);
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
								awaiter = ((Task)Hw62jh8RXEEb2xSdHaU(YO72K78eyS1S4U1SpfS(cvsCogSocketAcq3DLineScan._cogSocket), qaEmkF8I9D1QhnKg9TU(cvsCogSocketAcq3DLineScan.AcqPath, sbpYXM8uemGSEdAjg4n(49164)), new CogSocketEventHandler(cvsCogSocketAcq3DLineScan.JUQ11tTwOg))).GetAwaiter();
								num3 = 4;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_00e8;
							}
							goto IL_005f;
							continue;
							end_IL_00e8:
							break;
						}
						goto end_IL_003f;
						IL_005f:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00e8;
						end_IL_003f:;
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
					continue;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				cvsCogSocketAcq3DLineScan = _003C_003E4__this;
				num = 2;
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
		internal static object YO72K78eyS1S4U1SpfS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sbpYXM8uemGSEdAjg4n(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qaEmkF8I9D1QhnKg9TU(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Hw62jh8RXEEb2xSdHaU(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRemoteDeviceApi)P_0).RemoveListener((string)P_1, (CogSocketEventHandler)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GDPrvu8QUPV4ItFZvJK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m3EyeK8lNGfO9am5gNJ()
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
	private struct _003CGetRoiRowFromZ_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<double> _003C_003Et__builder;

		public CvsCogSocketAcq3DLineScan _003C_003E4__this;

		public double z;

		public bool binning;

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
			if (M6Pigf8adhllh8qseiZ())
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
			}
			goto IL_01aa;
			IL_0204:
			CvsCogSocketAcq3DLineScan cvsCogSocketAcq3DLineScan = _003C_003E4__this;
			num = 4;
			goto IL_01aa;
			IL_01aa:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					num = 5;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto IL_0204;
				case 5:
					goto IL_01ec;
				case 1:
				case 2:
					goto IL_0204;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			double result = default;
			try
			{
				TaskAwaiter<double> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((IRemoteDeviceApi)OMrCvq8G3sEHGEGToxS(cvsCogSocketAcq3DLineScan._cogSocket)).PostAsync<double>((string)aHSXH18bLVdWMvkhoMu(cvsCogSocketAcq3DLineScan.FieldCalPath, ri4J3q8XimyseVHFRxh(49198)), new object[2] { z, binning }).GetAwaiter();
					num3 = 7;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 5;
					if (1 == 0)
					{
						goto IL_00f2;
					}
				}
				goto IL_00a3;
				IL_00f2:
				_003C_003Eu__1 = awaiter;
				_ = 1;
				num3 = ((!VRBXEW8ngq1O9nlXEiS()) ? 1 : 0);
				goto IL_00a3;
				IL_00a3:
				while (true)
				{
					switch (num3)
					{
					case 1:
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 2;
						continue;
					case 2:
						return;
					case 8:
						break;
					case 7:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							continue;
						}
						goto case 9;
					case 5:
						_003C_003Eu__1 = default;
						goto case 0;
					case 4:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						continue;
					case 0:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 9:
						result = awaiter.GetResult();
						goto end_IL_00a3;
					}
					goto IL_00f2;
					continue;
					end_IL_00a3:
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
			goto IL_01ec;
			IL_01ec:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (true)
			{
				goto IL_01aa;
			}
			goto IL_0204;
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
		internal static object OMrCvq8G3sEHGEGToxS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ri4J3q8XimyseVHFRxh(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aHSXH18bLVdWMvkhoMu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M6Pigf8adhllh8qseiZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VRBXEW8ngq1O9nlXEiS()
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
	private struct _003CGetRoiZFromRow_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<double> _003C_003Et__builder;

		public CvsCogSocketAcq3DLineScan _003C_003E4__this;

		public double row;

		public bool binning;

		private TaskAwaiter<double> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (tF5tWC8pI1okhFyHxWl() ? 3 : 2);
			CvsCogSocketAcq3DLineScan cvsCogSocketAcq3DLineScan = default;
			int num2 = default;
			double result = default;
			do
			{
				IL_01cd:
				switch (num)
				{
				case 1:
				case 3:
					cvsCogSocketAcq3DLineScan = _003C_003E4__this;
					num = 5;
					if (UKLjal86EIJVYKgXTNk())
					{
						goto IL_01cd;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter<double> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = cvsCogSocketAcq3DLineScan._cogSocket.DeviceApi.PostAsync<double>((string)Po5yuw801fDNYcEGpmQ(cvsCogSocketAcq3DLineScan.FieldCalPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(49230)), new object[2] { row, binning }).GetAwaiter();
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
							case 8:
								_003C_003Eu__1 = default;
								goto case 5;
							case 5:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (tF5tWC8pI1okhFyHxWl())
								{
								}
								continue;
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								UKLjal86EIJVYKgXTNk();
								if (tF5tWC8pI1okhFyHxWl())
								{
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								}
								num3 = 2;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 0:
								return;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
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
				default:
					num = 4;
					if (0 == 0)
					{
						goto IL_01cd;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static object Po5yuw801fDNYcEGpmQ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UKLjal86EIJVYKgXTNk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tF5tWC8pI1okhFyHxWl()
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
	private struct _003CResetEncoderCounter_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq3DLineScan _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (diy6Ri84MmSh7M3b57s())
			{
				num = 4;
				if (!diy6Ri84MmSh7M3b57s())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (!diy6Ri84MmSh7M3b57s())
				{
					goto IL_01e5;
				}
			}
			goto IL_019d;
			IL_019d:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto IL_01e5;
				case 1:
				case 5:
					goto IL_01e5;
				case 3:
					goto IL_01f6;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_01e5:
			CvsCogSocketAcq3DLineScan cvsCogSocketAcq3DLineScan = _003C_003E4__this;
			num = 2;
			goto IL_019d;
			IL_002a:
			try
			{
				TaskAwaiter<object> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((IRemoteDeviceApi)IGSqdS8f3S8xdyLisxq(cvsCogSocketAcq3DLineScan._cogSocket)).PostAsync<object>((string)T2Quhb8mfI1uOdAZWgT(cvsCogSocketAcq3DLineScan.EncoderCounterPath, tn3TII8FmMbeyamhjCo(49262)), Array.Empty<object>()).GetAwaiter();
					num3 = 1;
					if (1 == 0)
					{
						goto IL_006c;
					}
					goto IL_0106;
				}
				awaiter = _003C_003Eu__1;
				goto IL_00ce;
				IL_014b:
				_003C_003Eu__1 = awaiter;
				num3 = 8;
				goto IL_0106;
				IL_0133:
				_ = 1;
				if (lTPG5A8k6daEDRFOAZ4())
				{
					num3 = 7;
					if (false)
					{
						goto IL_00bb;
					}
				}
				else
				{
					num3 = 6;
					if (1 == 0)
					{
						goto IL_014b;
					}
				}
				goto IL_0106;
				IL_006c:
				if (!awaiter.IsCompleted)
				{
					num3 = 2;
					if (!diy6Ri84MmSh7M3b57s())
					{
						goto IL_0088;
					}
					goto IL_0106;
				}
				goto IL_015c;
				IL_00bb:
				num2 = (_003C_003E1__state = -1);
				num3 = 9;
				goto IL_0106;
				IL_0088:
				num2 = (_003C_003E1__state = 0);
				num3 = 0;
				if (false)
				{
					return;
				}
				goto IL_0106;
				IL_0106:
				switch (num3)
				{
				case 1:
					break;
				case 2:
					goto IL_0088;
				case 4:
				case 6:
					return;
				case 3:
					goto IL_00bb;
				case 5:
				case 7:
					goto IL_00ce;
				case 8:
					goto IL_00e6;
				default:
					goto IL_0133;
				case 0:
					goto IL_014b;
				case 9:
					goto IL_015c;
				}
				goto IL_006c;
				IL_00ce:
				_003C_003Eu__1 = default;
				num3 = 3;
				if (1 == 0)
				{
					goto IL_00e6;
				}
				goto IL_0106;
				IL_00e6:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				goto IL_0133;
				IL_015c:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01f6;
			IL_01f6:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_019d;
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
		internal static object IGSqdS8f3S8xdyLisxq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tn3TII8FmMbeyamhjCo(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object T2Quhb8mfI1uOdAZWgT(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool diy6Ri84MmSh7M3b57s()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lTPG5A8k6daEDRFOAZ4()
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
	private struct _003CGetEncoderCount_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<uint> _003C_003Et__builder;

		public CvsCogSocketAcq3DLineScan _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Lk9mfv8g9HnZXoSdImR();
			int num;
			if (wa9VEn8yhHB4Tv8CxDX())
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
			goto IL_01b0;
			IL_002a:
			int num2 = _003C_003E1__state;
			num = 4;
			goto IL_01b0;
			IL_01b0:
			CvsCogSocketAcq3DLineScan cvsCogSocketAcq3DLineScan = default;
			uint result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((IRemoteDeviceApi)m9yhj78ZXuM3i9xVQV0(cvsCogSocketAcq3DLineScan._cogSocket)).GetAsync<object>((string)Yap2XA8Jm339IcjkUnw(cvsCogSocketAcq3DLineScan.EncoderCounterPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(49300))).GetAwaiter();
							num3 = 8;
							if (false)
							{
								goto IL_0078;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (1 == 0)
							{
								goto IL_0168;
							}
						}
						goto IL_00c3;
						IL_0168:
						result = Convert.ToUInt32(awaiter.GetResult());
						goto end_IL_003b;
						IL_00c3:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 3:
								goto IL_008d;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto IL_0168;
							case 0:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (wa9VEn8yhHB4Tv8CxDX())
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = 0);
								wa9VEn8yhHB4Tv8CxDX();
								num3 = (Lk9mfv8g9HnZXoSdImR() ? 6 : 0);
								continue;
							case 6:
								return;
							case 9:
								goto IL_0168;
							}
							break;
						}
						goto IL_0078;
						IL_0078:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (1 == 0)
						{
							goto IL_008d;
						}
						goto IL_00c3;
						IL_008d:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00c3;
						end_IL_003b:;
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
					cvsCogSocketAcq3DLineScan = _003C_003E4__this;
					num = 2;
					continue;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
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
		internal static object m9yhj78ZXuM3i9xVQV0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Yap2XA8Jm339IcjkUnw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wa9VEn8yhHB4Tv8CxDX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Lk9mfv8g9HnZXoSdImR()
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
	private struct _003CApplyPointCloudAcquisitionFilters_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq3DLineScan _003C_003E4__this;

		public string pointCloudUrl;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsCogSocketAcq3DLineScan cvsCogSocketAcq3DLineScan = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					cvsCogSocketAcq3DLineScan = _003C_003E4__this;
					_ = 1;
					num = ((!UxgiZs8z8V4qGug1Q4x()) ? 1 : 5);
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					if (UyOfmV88xSDW2dMPPHo())
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = oWL3XZzw9R5pjxwV6i2(cvsCogSocketAcq3DLineScan._cogSocket.ApplyPointCloudFiltersAndRun(pointCloudUrl));
							num3 = 3;
							if (false)
							{
								goto IL_008d;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_013f;
						IL_013f:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 4:
							case 9:
								return;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									if (true)
									{
										continue;
									}
								}
								goto case 5;
							case 5:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 0:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								goto case 0;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								UyOfmV88xSDW2dMPPHo();
								num3 = ((!UxgiZs8z8V4qGug1Q4x()) ? 9 : 0);
								continue;
							case 10:
								((CvsCogSocketSheet)AigWC8zsJc1ejlc2Beb(cvsCogSocketAcq3DLineScan._cogSocket)).FireSheetUpdated(false);
								goto end_IL_013f;
							}
							goto IL_008d;
							continue;
							end_IL_013f:
							break;
						}
						goto end_IL_0063;
						IL_008d:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						goto IL_013f;
						end_IL_0063:;
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
		internal static TaskAwaiter oWL3XZzw9R5pjxwV6i2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AigWC8zsJc1ejlc2Beb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UyOfmV88xSDW2dMPPHo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UxgiZs8z8V4qGug1Q4x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private bool tvv1FWmGkH;

	private int xSB1bqtykY;

	private static TimeSpan OyX1aCZAGT;

	private string xkL1OFdPt7;

	[CompilerGenerated]
	private EventHandler FdM1pZa43n;

	public static TimeSpan HttpImage3DTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OyX1aCZAGT;
		}
	}

	public string FieldCalPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)fWhbiW9MKI3FO6UJVXH(_cogSocket.CamPath, HdHheO9rsYIwJo20Vys(3332));
		}
	}

	public string EncoderCounterPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _cogSocket.CamPath + (string)HdHheO9rsYIwJo20Vys(3362);
		}
	}

	public string LatestAcqPointCloudUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!s2ZhTe91J78UbQeQwvW())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_003d;
				}
			}
			object lockLatestAcqImageUrl = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					lockLatestAcqImageUrl = _lockLatestAcqImageUrl;
					break;
				case 1:
				case 3:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_0074;
				}
				break;
			}
			goto IL_003d;
			IL_0074:
			bool lockTaken = default;
			try
			{
				Monitor.Enter(lockLatestAcqImageUrl, ref lockTaken);
				return xkL1OFdPt7;
			}
			finally
			{
				if (lockTaken)
				{
					dfpTdc9QSQMfPVgM5MM(lockLatestAcqImageUrl);
				}
			}
			IL_003d:
			lockTaken = false;
			goto IL_0074;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!s2ZhTe91J78UbQeQwvW())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0074;
				}
			}
			bool lockTaken = default;
			object lockLatestAcqImageUrl = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					lockTaken = false;
					break;
				default:
					goto IL_0051;
				case 0:
				case 2:
					lockLatestAcqImageUrl = _lockLatestAcqImageUrl;
					goto case 1;
				case 4:
					break;
				}
				break;
				IL_0051:
				num = 4;
			}
			goto IL_0074;
			IL_0074:
			try
			{
				Monitor.Enter(lockLatestAcqImageUrl, ref lockTaken);
				xkL1OFdPt7 = value;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(lockLatestAcqImageUrl);
				}
			}
		}
	}

	public event EventHandler PointCloudReady
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
			int num;
			if (shtmm69xSuuUVXbENDE())
			{
				num = 2;
			}
			else
			{
				num = 6;
				if (s2ZhTe91J78UbQeQwvW())
				{
					return;
				}
			}
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 6:
					eventHandler2 = eventHandler;
					num = 3;
					break;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 4:
					eventHandler = Interlocked.CompareExchange(ref FdM1pZa43n, value2, eventHandler2);
					num = 5;
					break;
				case 3:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto case 4;
				default:
					num = 4;
					break;
				case 0:
				case 2:
					eventHandler = FdM1pZa43n;
					goto case 1;
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
			s2ZhTe91J78UbQeQwvW();
			int num = (shtmm69xSuuUVXbENDE() ? 1 : 5);
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					eventHandler2 = eventHandler;
					num = 2;
					break;
				case 2:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					goto case 3;
				default:
					num = 3;
					break;
				case 4:
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 6;
				case 3:
					eventHandler = Interlocked.CompareExchange(ref FdM1pZa43n, value2, eventHandler2);
					goto case 4;
				case 0:
				case 1:
					eventHandler = FdM1pZa43n;
					num = 6;
					break;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCogSocketAcq3DLineScan()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		s2ZhTe91J78UbQeQwvW();
		int num = (shtmm69xSuuUVXbENDE() ? 1 : 5);
		int value = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				if (AppConfiguration.TryGet<int>((string)HdHheO9rsYIwJo20Vys(3260), out value))
				{
					goto case 3;
				}
				return;
			default:
				num = 3;
				break;
			case 3:
				OyX1aCZAGT = TimeSpan.FromMilliseconds(value);
				num = 6;
				break;
			case 4:
				OyX1aCZAGT = TimeSpan.FromSeconds(300.0);
				goto case 2;
			case 0:
			case 1:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 4;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSocketAcq3DLineScan(CvsCogSocket cogSocket)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SK695R93viL6Fq1P65m();
		base._002Ector(cogSocket);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSocketAcq3DLineScan(CvsCogSocket cogSocket, SynchronizationContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SK695R93viL6Fq1P65m();
		base._002Ector(cogSocket, context);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddPointCloudReadyListenerAsync_003Ed__8))]
	public Task AddPointCloudReadyListenerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		shtmm69xSuuUVXbENDE();
		int num;
		if (!s2ZhTe91J78UbQeQwvW())
		{
			num = 5;
			if (s2ZhTe91J78UbQeQwvW())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0060;
		IL_0046:
		_003CAddPointCloudReadyListenerAsync_003Ed__8 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_008b;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 2:
			case 3:
				goto IL_0046;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_008b;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = W2uqFU9OjkF8iMX1XoQ();
				num = 1;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003E4__this = this;
		goto IL_0046;
		IL_008b:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0060;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemovePointCloudReadyListenerAsync_003Ed__9))]
	public Task RemovePointCloudReadyListenerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!s2ZhTe91J78UbQeQwvW())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (!shtmm69xSuuUVXbENDE())
			{
				goto IL_0060;
			}
		}
		goto IL_007a;
		IL_0060:
		_003CRemovePointCloudReadyListenerAsync_003Ed__9 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0024;
		IL_0042:
		stateMachine._003C_003E4__this = this;
		goto IL_0060;
		IL_007a:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
				goto IL_0042;
			case 2:
			case 4:
				goto IL_0060;
			default:
				num = 3;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0024;
		IL_0024:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (!shtmm69xSuuUVXbENDE())
		{
			goto IL_0042;
		}
		goto IL_007a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogFieldCalStatus> GetFieldCalStatusAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogFieldCalStatus>(FieldCalPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(3404));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogWorkingSection> GetWorkingSectionAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogWorkingSection>(FieldCalPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(3420));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogRoiZRange> GetRoiZRangeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogRoiZRange>(FieldCalPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(3452));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ImportFieldCalAsync(CvsCogByteArray data)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)zwaxmS9lZeXcFLOZ6Rk(_cogSocket)).PostAsync<CvsCogByteArray>(FieldCalPath + (string)HdHheO9rsYIwJo20Vys(3474), new object[1] { data });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogByteArray> ExportFieldCalAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogByteArray>(FieldCalPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(3490));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRoiRowFromZ_003Ed__23))]
	public Task<double> GetRoiRowFromZ(double z, bool binning)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetRoiRowFromZ_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<double>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.z = z;
		stateMachine.binning = binning;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRoiZFromRow_003Ed__24))]
	public Task<double> GetRoiZFromRow(double row, bool binning)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetRoiZFromRow_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<double>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.row = row;
		stateMachine.binning = binning;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CResetEncoderCounter_003Ed__25))]
	public Task ResetEncoderCounter()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!shtmm69xSuuUVXbENDE()) ? 1 : 5);
		_003CResetEncoderCounter_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = W2uqFU9OjkF8iMX1XoQ();
				num = 2;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetEncoderCount_003Ed__26))]
	public Task<uint> GetEncoderCount()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetEncoderCount_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<uint>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CApplyPointCloudAcquisitionFilters_003Ed__27))]
	public Task ApplyPointCloudAcquisitionFilters(string pointCloudUrl)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CApplyPointCloudAcquisitionFilters_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				s2ZhTe91J78UbQeQwvW();
				num = ((!shtmm69xSuuUVXbENDE()) ? 5 : 4);
				break;
			case 2:
			case 4:
				stateMachine.pointCloudUrl = pointCloudUrl;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JUQ11tTwOg(object P_0, CogSocketEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (shtmm69xSuuUVXbENDE())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				return;
			}
		}
		IDisposable disposable = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				goto IL_019d;
			case 0:
			case 3:
				disposable = CvsTraceSDK.Info.TraceFunction(FunctionName((string)HdHheO9rsYIwJo20Vys(3506)));
				break;
			case 4:
				return;
			}
			break;
			IL_019d:
			num = 4;
		}
		try
		{
			try
			{
				if (Nf3JfV9e5ABKmafD4bJ(_cogSocket) && IsLiveAcquisition)
				{
					EKi1xbl7OP(P_1);
					return;
				}
				if (!mTtbx09IXUfualB5eL9(gUBy589uK3XUUiTV2hA(_cogSocket)) || IsLiveAcquisition)
				{
					string latestAcqPointCloudUrl = LatestAcqPointCloudUrl;
					CvsCogRef cvsCogRef = P_1.Args[2] as CvsCogRef;
					bool flag = false;
					if (!tvv1FWmGkH && hqXM1j9a5fsBvn789C9(latestAcqPointCloudUrl, p4SOsq9R84mJZMU4wDf(cvsCogRef)))
					{
						iMNuMS9n1Bt7b0j9naD(CvsTraceSDK.Info, HdHheO9rsYIwJo20Vys(2062), new object[2]
						{
							FunctionName((string)HdHheO9rsYIwJo20Vys(3506)),
							p4SOsq9R84mJZMU4wDf(cvsCogRef)
						});
						LatestAcqPointCloudUrl = cvsCogRef.Url;
					}
					if (tvv1FWmGkH | flag)
					{
						try
						{
							if (latestAcqPointCloudUrl == null || latestAcqPointCloudUrl != cvsCogRef.Url)
							{
								LatestAcqPointCloudUrl = (string)p4SOsq9R84mJZMU4wDf(cvsCogRef);
								((CvsCogSocketSheet)gUBy589uK3XUUiTV2hA(_cogSocket)).FireSheetUpdated(false);
							}
						}
						catch (Exception exception)
						{
							_logger.DebugException((string)HdHheO9rsYIwJo20Vys(3552), exception);
						}
						finally
						{
							tvv1FWmGkH = false;
						}
					}
				}
			}
			finally
			{
				qpuFwU9GpofIVZaCjVm(_waitForImageReady);
			}
		}
		finally
		{
			if (disposable != null)
			{
				ysrQkD9XrPCI6vnhaQV(disposable);
			}
		}
		EKi1xbl7OP(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EKi1xbl7OP(CogSocketEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FireHandlerReady(FdM1pZa43n, P_0, (string)HdHheO9rsYIwJo20Vys(3624));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HdHheO9rsYIwJo20Vys(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool shtmm69xSuuUVXbENDE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s2ZhTe91J78UbQeQwvW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SK695R93viL6Fq1P65m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder W2uqFU9OjkF8iMX1XoQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fWhbiW9MKI3FO6UJVXH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dfpTdc9QSQMfPVgM5MM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zwaxmS9lZeXcFLOZ6Rk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).DeviceApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Nf3JfV9e5ABKmafD4bJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).IsRuntimeSupported;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gUBy589uK3XUUiTV2hA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mTtbx09IXUfualB5eL9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).HasSheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p4SOsq9R84mJZMU4wDf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRef)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hqXM1j9a5fsBvn789C9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iMNuMS9n1Bt7b0j9naD(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qpuFwU9GpofIVZaCjVm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EventWaitHandle)P_0).Set();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ysrQkD9XrPCI6vnhaQV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}
}
