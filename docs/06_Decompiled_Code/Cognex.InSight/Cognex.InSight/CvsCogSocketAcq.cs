using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.Configuration;
using Cognex.Diagnostics.Logging;
using Cognex.Extensions;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.Remoting.CogSocket;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsCogSocketAcq : SyncContextService, ICogSocketAcq, ICogSocketAcqProperties
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddListenersAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mTxnw9JLJvrEm9lBx0i();
			int num = (HMMT2TJ9OAUyNh1Avxx() ? 5 : 3);
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (!cvsCogSocketAcq._cogSocket.IsRuntimeSupported)
							{
								num3 = 13;
								goto IL_0125;
							}
							goto IL_030f;
						case 2:
							awaiter = _003C_003Eu__1;
							goto IL_00de;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 5;
							goto IL_0125;
						case 1:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 12;
								goto IL_0125;
							}
							IL_00de:
							_003C_003Eu__1 = default;
							num3 = 15;
							goto IL_0125;
							IL_030f:
							awaiter = ((IRemoteDeviceApi)soJCF8JSJFmTqxaFLt1(cvsCogSocketAcq._cogSocket)).AddListener((string)TQwHqYJvcdB7q97L0UQ(cvsCogSocketAcq.AcqPath, gAFYNOJEQWqg9QDkZr8(48562)), (CogSocketEventHandler)cvsCogSocketAcq.clOIeDSrWd).GetAwaiter();
							num3 = 6;
							if (!mTxnw9JLJvrEm9lBx0i())
							{
								break;
							}
							goto IL_0125;
							IL_0125:
							while (true)
							{
								switch (num3)
								{
								case 21:
									awaiter.GetResult();
									num3 = 4;
									continue;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 14;
									if (!HMMT2TJ9OAUyNh1Avxx())
									{
										continue;
									}
									goto case 5;
								case 5:
									_003C_003Eu__1 = default;
									num3 = 11;
									if (HMMT2TJ9OAUyNh1Avxx())
									{
									}
									continue;
								case 9:
									_003C_003Eu__1 = awaiter;
									num3 = 10;
									continue;
								case 3:
								case 18:
									break;
								case 12:
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									continue;
								case 6:
									if (awaiter.IsCompleted)
									{
										goto case 0;
									}
									goto case 19;
								default:
									num3 = 19;
									continue;
								case 7:
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									if (mTxnw9JLJvrEm9lBx0i())
									{
										continue;
									}
									goto case 16;
								case 16:
								case 17:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 2;
									continue;
								case 13:
									awaiter = cvsCogSocketAcq.AddImageReadyListenerAsync().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 7;
										continue;
									}
									goto case 21;
								case 0:
									awaiter.GetResult();
									num3 = 20;
									continue;
								case 19:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 8;
									if (!HMMT2TJ9OAUyNh1Avxx())
									{
										continue;
									}
									goto case 20;
								case 20:
									awaiter = ((Task)h6VOBDJHpa3MfsgMo96(cvsCogSocketAcq._cogSocket.DeviceApi, cvsCogSocketAcq.AcqPath + (string)gAFYNOJEQWqg9QDkZr8(48596), new CogSocketEventHandler(cvsCogSocketAcq.OvfISiepHB))).GetAwaiter();
									num3 = 1;
									continue;
								case 2:
									return;
								case 14:
									return;
								case 1:
									goto IL_02a5;
								case 8:
									return;
								case 11:
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									continue;
								case 15:
									num2 = (_003C_003E1__state = -1);
									num3 = 22;
									continue;
								case 4:
									goto IL_030f;
								case 22:
									goto end_IL_0053;
								}
								break;
								IL_02a5:
								if (awaiter.IsCompleted)
								{
									goto end_IL_0053;
								}
								_ = 1;
								num3 = ((!HMMT2TJ9OAUyNh1Avxx()) ? 17 : 3);
							}
							goto IL_00de;
							end_IL_0053:
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
				default:
					num = 2;
					continue;
				case 2:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (HMMT2TJ9OAUyNh1Avxx())
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
		internal static object soJCF8JSJFmTqxaFLt1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gAFYNOJEQWqg9QDkZr8(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TQwHqYJvcdB7q97L0UQ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object h6VOBDJHpa3MfsgMo96(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRemoteDeviceApi)P_0).AddListener((string)P_1, (CogSocketEventHandler)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mTxnw9JLJvrEm9lBx0i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HMMT2TJ9OAUyNh1Avxx()
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
	private struct _003CRemoveListenersAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zjwqqGJVX0j95VC9gTL();
			int num;
			if (!E2bZUOJA0DDOx1NNt0h())
			{
				num = 1;
			}
			else
			{
				num = 5;
				if (false)
				{
					return;
				}
			}
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 4;
					if (true)
					{
						continue;
					}
					break;
				case 0:
				case 1:
					break;
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (!NTdgnfJDnsth3kF1sZf(cvsCogSocketAcq._cogSocket))
							{
								num3 = 21;
								if (1 == 0)
								{
									goto IL_008f;
								}
								goto IL_01e1;
							}
							goto IL_0265;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 18;
							goto IL_01e1;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 13;
							goto IL_01e1;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 5;
								goto IL_01e1;
							}
							IL_00ab:
							awaiter = wLU7WxJU127jVnKJ2nC(cvsCogSocketAcq.RemoveImageReadyListenerAsync());
							E2bZUOJA0DDOx1NNt0h();
							num3 = ((!zjwqqGJVX0j95VC9gTL()) ? 16 : 20);
							goto IL_01e1;
							IL_0265:
							awaiter = ((Task)y24pAiJqw5uGRssBxLH(CVCR4qJTTWieZxYm2Hs(cvsCogSocketAcq._cogSocket), Yi9nbRJicXD6tOPifgA(cvsCogSocketAcq.AcqPath, xJmV96JdDoA3uHbdrJP(48562)), new CogSocketEventHandler(cvsCogSocketAcq.clOIeDSrWd))).GetAwaiter();
							num3 = 12;
							goto IL_01e1;
							IL_01e1:
							while (true)
							{
								switch (num3)
								{
								case 8:
									break;
								case 21:
									goto IL_00ab;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 10;
									if (true)
									{
										continue;
									}
									return;
								case 4:
									return;
								case 0:
									num2 = (_003C_003E1__state = -1);
									num3 = 22;
									if (0 == 0)
									{
										continue;
									}
									goto case 7;
								case 7:
								case 16:
									num2 = (_003C_003E1__state = -1);
									goto IL_012b;
								case 3:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__1 = awaiter;
										num3 = 2;
										continue;
									}
									goto case 22;
								case 9:
									awaiter = wLU7WxJU127jVnKJ2nC(y24pAiJqw5uGRssBxLH(CVCR4qJTTWieZxYm2Hs(cvsCogSocketAcq._cogSocket), Yi9nbRJicXD6tOPifgA(cvsCogSocketAcq.AcqPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(48596)), new CogSocketEventHandler(cvsCogSocketAcq.OvfISiepHB)));
									num3 = 3;
									continue;
								case 13:
									_003C_003Eu__1 = default;
									num3 = 0;
									continue;
								case 12:
									if (!awaiter.IsCompleted)
									{
										break;
									}
									goto IL_02af;
								default:
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 15;
								case 15:
									_003C_003Eu__1 = awaiter;
									num3 = 19;
									if (!E2bZUOJA0DDOx1NNt0h())
									{
										continue;
									}
									goto IL_0265;
								case 11:
									goto IL_0265;
								case 18:
									num2 = (_003C_003E1__state = -1);
									goto IL_02af;
								case 5:
									_003C_003Eu__1 = default;
									goto case 7;
								case 14:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 4;
									continue;
								case 19:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 17;
									continue;
								case 6:
									num2 = (_003C_003E1__state = 0);
									num3 = 15;
									continue;
								case 10:
									return;
								case 17:
									return;
								case 1:
								case 20:
									if (!awaiter.IsCompleted)
									{
										num3 = 6;
										continue;
									}
									goto IL_012b;
								case 22:
									{
										awaiter.GetResult();
										goto end_IL_0062;
									}
									IL_012b:
									awaiter.GetResult();
									num3 = 11;
									if (E2bZUOJA0DDOx1NNt0h())
									{
									}
									continue;
									IL_02af:
									awaiter.GetResult();
									num3 = 9;
									if (!E2bZUOJA0DDOx1NNt0h())
									{
										continue;
									}
									goto case 5;
								}
								break;
							}
							goto IL_008f;
							IL_008f:
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							num3 = 14;
							if (false)
							{
								goto IL_00ab;
							}
							goto IL_01e1;
							end_IL_0062:
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
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
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
		internal static bool NTdgnfJDnsth3kF1sZf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).IsRuntimeSupported;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter wLU7WxJU127jVnKJ2nC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CVCR4qJTTWieZxYm2Hs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xJmV96JdDoA3uHbdrJP(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Yi9nbRJicXD6tOPifgA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object y24pAiJqw5uGRssBxLH(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRemoteDeviceApi)P_0).RemoveListener((string)P_1, (CogSocketEventHandler)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zjwqqGJVX0j95VC9gTL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E2bZUOJA0DDOx1NNt0h()
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
	private struct _003CAddImageReadyListenerAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (hOZot2Jj9bv4h5Rv2h1() ? 4 : 5);
			int num2 = default;
			TaskAwaiter awaiter = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_ = 0;
							if (!BJUiMIJBBGhWwlIgVr5())
							{
								num3 = 2;
								if (1 == 0)
								{
									goto IL_00ba;
								}
							}
							else
							{
								num3 = 8;
								if (false)
								{
									goto IL_00f1;
								}
							}
							goto IL_0141;
						}
						if (Interlocked.Increment(ref cvsCogSocketAcq.OAHICfBLu6) == 1)
						{
							num3 = 5;
							goto IL_0141;
						}
						goto end_IL_0024;
						IL_00f1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						if (!BJUiMIJBBGhWwlIgVr5())
						{
							goto IL_010f;
						}
						goto IL_0141;
						IL_010f:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						if (!BJUiMIJBBGhWwlIgVr5())
						{
							goto IL_0128;
						}
						goto IL_0141;
						IL_00ba:
						num2 = (_003C_003E1__state = 0);
						num3 = 1;
						goto IL_0141;
						IL_0141:
						while (true)
						{
							switch (num3)
							{
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 10;
							case 5:
								awaiter = ((IRemoteDeviceApi)wnySdyJcnRWlwjU00bX(cvsCogSocketAcq._cogSocket)).AddListener((string)hw9RxCJWM2528p7YLY2(cvsCogSocketAcq.AcqPath, cK08EpJ2C90YFb0oNnN(48652)), (CogSocketEventHandler)cvsCogSocketAcq.XH9IulMmvN).GetAwaiter();
								num3 = 0;
								continue;
							case 6:
							case 8:
								_003C_003Eu__1 = default;
								goto IL_010f;
							case 9:
								break;
							case 4:
								return;
							case 3:
								goto IL_00f1;
							case 2:
							case 7:
								goto IL_010f;
							case 1:
								goto IL_0128;
							default:
								num3 = 3;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0024;
							}
							break;
						}
						goto IL_00ba;
						IL_0128:
						_003C_003Eu__1 = awaiter;
						goto IL_00f1;
						end_IL_0024:;
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
				case 1:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 2;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static object wnySdyJcnRWlwjU00bX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cK08EpJ2C90YFb0oNnN(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hw9RxCJWM2528p7YLY2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BJUiMIJBBGhWwlIgVr5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hOZot2Jj9bv4h5Rv2h1()
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
	private struct _003CRemoveImageReadyListenerAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					cvsCogSocketAcq = _003C_003E4__this;
					_ = 1;
					num = (VNqKZCJtmk6O9gWpXvH() ? 4 : 0);
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (1 == 0)
							{
								goto IL_00ad;
							}
							goto IL_014b;
						}
						if (Interlocked.Decrement(ref cvsCogSocketAcq.OAHICfBLu6) == 0)
						{
							VNqKZCJtmk6O9gWpXvH();
							num3 = ((!SJqX6IJ7U7HtTJppXCB()) ? 8 : 9);
							goto IL_014b;
						}
						goto end_IL_0035;
						IL_014b:
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 10;
							case 6:
								break;
							case 7:
								return;
							case 4:
								goto IL_00ad;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
							case 9:
								awaiter = ((Task)URxAj2JKIEvUEFCnI9u(aHInXcJCsU0LyDT1tSF(cvsCogSocketAcq._cogSocket), cvsCogSocketAcq.AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(48652), new CogSocketEventHandler(cvsCogSocketAcq.XH9IulMmvN))).GetAwaiter();
								num3 = 5;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto IL_0132;
							case 3:
							case 8:
								goto IL_0132;
							default:
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0035;
							}
							break;
						}
						goto IL_007b;
						IL_0132:
						_003C_003Eu__1 = awaiter;
						goto IL_007b;
						IL_007b:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 7;
						if (1 == 0)
						{
							return;
						}
						goto IL_014b;
						IL_00ad:
						num2 = (_003C_003E1__state = 0);
						goto IL_0132;
						end_IL_0035:;
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
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static object aHInXcJCsU0LyDT1tSF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object URxAj2JKIEvUEFCnI9u(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRemoteDeviceApi)P_0).RemoveListener((string)P_1, (CogSocketEventHandler)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SJqX6IJ7U7HtTJppXCB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VNqKZCJtmk6O9gWpXvH()
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
	private struct _003CAddAcquisitionErrorListenerAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					num2 = _003C_003E1__state;
					wrUh1VJoua3OlLdvOi1();
					num = (H6ZOJkJ5qrxxYn7teBZ() ? 4 : 0);
					break;
				case 1:
				case 4:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (1 == 0)
							{
								goto IL_00cb;
							}
							goto IL_010a;
						}
						if (Interlocked.Exchange(ref cvsCogSocketAcq.yJgI2FwRqs, 1) == 0)
						{
							num3 = 7;
							goto IL_010a;
						}
						goto end_IL_0061;
						IL_00cb:
						if (!awaiter.IsCompleted)
						{
							wrUh1VJoua3OlLdvOi1();
							num3 = (H6ZOJkJ5qrxxYn7teBZ() ? 6 : 0);
							goto IL_010a;
						}
						goto IL_01af;
						IL_010a:
						while (true)
						{
							switch (num3)
							{
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto case 0;
							case 5:
								return;
							case 1:
								break;
							case 0:
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 7:
								awaiter = IeaVJpJxOpMDAOiLK6L(WvZTUeJNQ0vuwQQl4ag(LaVNkeJP2ZoLcVaBXue(cvsCogSocketAcq._cogSocket), cvsCogSocketAcq.AcqPath + (string)guTCG9JYOTYq26LMRO4(48676), new CogSocketEventHandler(cvsCogSocketAcq.UXZIG9WeiQ)));
								num3 = 1;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 10:
								goto IL_01af;
							}
							break;
						}
						goto IL_00cb;
						IL_01af:
						awaiter.GetResult();
						end_IL_0061:;
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
		internal static object LaVNkeJP2ZoLcVaBXue(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object guTCG9JYOTYq26LMRO4(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WvZTUeJNQ0vuwQQl4ag(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRemoteDeviceApi)P_0).AddListener((string)P_1, (CogSocketEventHandler)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter IeaVJpJxOpMDAOiLK6L(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H6ZOJkJ5qrxxYn7teBZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wrUh1VJoua3OlLdvOi1()
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
	private struct _003CRemoveAcquisitionErrorListenerAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LItjUjJ1MPOBPWnilOu();
			int num = (cg32oQJrHdfhkcMwYaf() ? 5 : 4);
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 2;
					if (!cg32oQJrHdfhkcMwYaf())
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							goto IL_0152;
						}
						int num3;
						if (Interlocked.Exchange(ref cvsCogSocketAcq.yJgI2FwRqs, 0) == 1)
						{
							num3 = 9;
							goto IL_007a;
						}
						goto end_IL_003f;
						IL_007a:
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									cg32oQJrHdfhkcMwYaf();
									if (LItjUjJ1MPOBPWnilOu())
									{
										num3 = 4;
										continue;
									}
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 5;
								}
								goto case 10;
							case 7:
								return;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 9:
								awaiter = ((IRemoteDeviceApi)uugBTWJ37ZRZAO0yUy9(cvsCogSocketAcq._cogSocket)).RemoveListener((string)KJQQvDJMoeYCm3YOFLR(cvsCogSocketAcq.AcqPath, OEsRq8JOy8rkc8hf634(48676)), (CogSocketEventHandler)cvsCogSocketAcq.UXZIG9WeiQ).GetAwaiter();
								num3 = 3;
								continue;
							case 6:
							case 8:
								break;
							case 2:
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_007a;
							}
							goto IL_0152;
							continue;
							end_IL_007a:
							break;
						}
						goto end_IL_003f;
						IL_0152:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_007a;
						end_IL_003f:;
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
					if (LItjUjJ1MPOBPWnilOu())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static object uugBTWJ37ZRZAO0yUy9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OEsRq8JOy8rkc8hf634(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KJQQvDJMoeYCm3YOFLR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LItjUjJ1MPOBPWnilOu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cg32oQJrHdfhkcMwYaf()
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
	private struct _003CGetAcqSettingsEditableProperties_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IEnumerable<CvsCogPropertyDescriptorGroup>> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private ConfiguredTaskAwaitable<CvsCogPropertyDescriptorGroup[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			IEnumerable<CvsCogPropertyDescriptorGroup> result = default;
			int num2 = default;
			ConfiguredTaskAwaitable<CvsCogPropertyDescriptorGroup[]> configuredTaskAwaitable = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			ConfiguredTaskAwaitable<CvsCogPropertyDescriptorGroup[]>.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!ppKn5qJQPTovGj11rVk()) ? 5 : 4);
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketAcq._cogSocket.DeviceApi.GetAsync<CvsCogPropertyDescriptorGroup[]>(cvsCogSocketAcq.AcqPath + (string)ptplWKJeDQs63ZDPT7k(48696)).ConfigureAwait(continueOnCapturedContext: false);
							ppKn5qJQPTovGj11rVk();
							if (!TRYxygJltLyJKk7vZom())
							{
								num3 = 7;
								if (1 == 0)
								{
									goto IL_009a;
								}
							}
							else
							{
								num3 = 3;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (!ppKn5qJQPTovGj11rVk())
							{
								goto IL_018e;
							}
						}
						goto IL_0122;
						IL_009a:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_0122;
						IL_0122:
						while (true)
						{
							switch (num3)
							{
							case 6:
								break;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									goto case 2;
								}
								goto IL_018e;
							case 0:
							case 7:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 1;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 5:
								return;
							case 10:
								goto IL_018e;
							}
							break;
						}
						goto IL_009a;
						IL_018e:
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					break;
				case 1:
				case 4:
					cvsCogSocketAcq = _003C_003E4__this;
					goto case 2;
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
		internal static object ptplWKJeDQs63ZDPT7k(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ppKn5qJQPTovGj11rVk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TRYxygJltLyJKk7vZom()
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
	private struct _003CGetAcqWhiteBalanceSupported_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter<CvsCogRegion> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!Aws4vDJIM7kYkZ2j5Dm())
			{
				num = 4;
				if (!Bytgd2JuRmJ5NAo5FSu())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_0043;
				}
			}
			goto IL_01ff;
			IL_0043:
			CvsCogSocketAcq cvsCogSocketAcq = _003C_003E4__this;
			num = 3;
			goto IL_01ff;
			IL_01ff:
			bool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 5:
					goto IL_0043;
				case 2:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 3:
					try
					{
						try
						{
							TaskAwaiter<CvsCogRegion> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = cvsCogSocketAcq._cogSocket.DeviceApi.GetAsync<CvsCogRegion>((string)HhgOAGJapQoat0Oiexy(cvsCogSocketAcq.WhiteBalancePath, nAYWVWJR14CVdwXDY7F(48754))).GetAwaiter();
								num3 = 4;
								if (!Bytgd2JuRmJ5NAo5FSu())
								{
									goto IL_00ae;
								}
								goto IL_0116;
							}
							awaiter = _003C_003Eu__1;
							goto IL_0182;
							IL_0182:
							_003C_003Eu__1 = default;
							num3 = 6;
							if (Aws4vDJIM7kYkZ2j5Dm())
							{
							}
							goto IL_0116;
							IL_0116:
							while (true)
							{
								switch (num3)
								{
								case 6:
									break;
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									if (Bytgd2JuRmJ5NAo5FSu())
									{
										continue;
									}
									return;
								case 1:
									return;
								case 0:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 1;
									continue;
								case 8:
									_003C_003Eu__1 = awaiter;
									_ = 0;
									if (!Bytgd2JuRmJ5NAo5FSu())
									{
										num3 = 9;
										continue;
									}
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 7;
								case 7:
									awaiter.GetResult();
									num3 = 10;
									continue;
								case 5:
								case 9:
									goto IL_0182;
								case 4:
									if (awaiter.IsCompleted)
									{
										goto case 7;
									}
									num3 = 2;
									if (true)
									{
										continue;
									}
									goto case 10;
								case 10:
									result = true;
									goto end_IL_006d;
								}
								break;
							}
							goto IL_00ae;
							IL_00ae:
							num2 = (_003C_003E1__state = -1);
							num3 = 7;
							goto IL_0116;
							end_IL_006d:;
						}
						catch
						{
							result = false;
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
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_0043;
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
		internal static object nAYWVWJR14CVdwXDY7F(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HhgOAGJapQoat0Oiexy(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Bytgd2JuRmJ5NAo5FSu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Aws4vDJIM7kYkZ2j5Dm()
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
	private struct _003CIs2DLineScanAsync_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private bool _003CisLineScan_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!c0HydOJnZbtGS9beiie())
			{
				goto IL_001e;
			}
			goto IL_01f1;
			IL_001e:
			bool result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01f1;
			IL_01f1:
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			bool result2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					cvsCogSocketAcq = _003C_003E4__this;
					_ = 0;
					num = ((!c0HydOJnZbtGS9beiie()) ? 1 : 5);
					continue;
				case 2:
				case 5:
					try
					{
						if (num2 != 0)
						{
							_003CisLineScan_003E5__2 = false;
						}
						try
						{
							TaskAwaiter<bool> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = ((IRemoteDeviceApi)kUKLJ6JXQ9hn3Unv2eM(cvsCogSocketAcq._cogSocket)).GetAsync<bool>((string)a9DYCpJbN3dZPhLq9Ou(cvsCogSocketAcq.AcqPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(48770))).GetAwaiter();
								num3 = 2;
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
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									continue;
								case 2:
									if (!awaiter.IsCompleted)
									{
										c0HydOJnZbtGS9beiie();
										num3 = (pTcAQSJGaCD9Goiupiq() ? 9 : 0);
										continue;
									}
									goto case 7;
								default:
									return;
								case 9:
									return;
								case 3:
									_003C_003Eu__1 = default;
									num3 = 6;
									if (0 == 0)
									{
										continue;
									}
									goto case 7;
								case 7:
									result2 = awaiter.GetResult();
									num3 = 10;
									continue;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								case 0:
								case 1:
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									continue;
								case 10:
									_003CisLineScan_003E5__2 = result2;
									break;
								}
								break;
							}
						}
						catch
						{
						}
						result = _003CisLineScan_003E5__2;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
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
		internal static object kUKLJ6JXQ9hn3Unv2eM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a9DYCpJbN3dZPhLq9Ou(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c0HydOJnZbtGS9beiie()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pTcAQSJGaCD9Goiupiq()
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
	private struct _003CAcceptsPointCloudsAsync_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_016a;
			IL_001a:
			int num2 = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			bool result = default;
			try
			{
				TaskAwaiter<bool> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = cvsCogSocketAcq._cogSocket.AcceptsPointCloudsAsync().GetAwaiter();
					num3 = 6;
					goto IL_008a;
				}
				awaiter = _003C_003Eu__1;
				goto IL_00db;
				IL_00db:
				_003C_003Eu__1 = default;
				num3 = 4;
				goto IL_008a;
				IL_008a:
				while (true)
				{
					switch (num3)
					{
					case 4:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 7:
						return;
					case 0:
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 7;
						if (true)
						{
							continue;
						}
						goto case 6;
					case 6:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							if (0 == 0)
							{
								continue;
							}
							break;
						}
						goto case 9;
					case 1:
					case 5:
						break;
					case 8:
						_003C_003Eu__1 = awaiter;
						Gqp4FyJ6ImCaMEeHe2F();
						num3 = (fSEGG0JppKln5TriUp4() ? 1 : 0);
						continue;
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						if (true)
						{
							continue;
						}
						goto case 9;
					case 9:
						result = awaiter.GetResult();
						goto end_IL_008a;
					}
					goto IL_00db;
					continue;
					end_IL_008a:
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
			goto IL_019b;
			IL_016a:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					goto IL_019b;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 0:
					goto IL_01c2;
				case 6:
					return;
				}
				break;
				IL_01c2:
				cvsCogSocketAcq = _003C_003E4__this;
				fSEGG0JppKln5TriUp4();
				num = (Gqp4FyJ6ImCaMEeHe2F() ? 1 : 5);
			}
			goto IL_001a;
			IL_019b:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_016a;
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
		internal static bool Gqp4FyJ6ImCaMEeHe2F()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fSEGG0JppKln5TriUp4()
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
	private struct _003CDoAutoExposure_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JZaYqJJ080LMtPBZMOm();
			int num = (mKA08JJ4ND3bKBwmivp() ? 5 : 3);
			int num2 = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((IRemoteDeviceApi)nnARQOJkryCpt3nyUWr(cvsCogSocketAcq._cogSocket)).PostAsync<object>(cvsCogSocketAcq.AcqPath + (string)FaRosWJfuPgnU2VMGr9(48808), Array.Empty<object>()).GetAwaiter();
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (!JZaYqJJ080LMtPBZMOm())
							{
								goto IL_0131;
							}
						}
						goto IL_00de;
						IL_0131:
						num2 = (_003C_003E1__state = 0);
						_ = 1;
						num3 = ((!mKA08JJ4ND3bKBwmivp()) ? 7 : 5);
						goto IL_00de;
						IL_00de:
						while (true)
						{
							switch (num3)
							{
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								goto case 5;
							case 5:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 3:
								return;
							case 8:
								break;
							case 9:
								awaiter.GetResult();
								goto end_IL_00de;
							}
							goto IL_0131;
							continue;
							end_IL_00de:
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
					if (mKA08JJ4ND3bKBwmivp())
					{
					}
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 2;
					continue;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static object nnARQOJkryCpt3nyUWr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FaRosWJfuPgnU2VMGr9(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JZaYqJJ080LMtPBZMOm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mKA08JJ4ND3bKBwmivp()
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
	private struct _003CDoAutoROI_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = cvsCogSocketAcq._cogSocket.DeviceApi.PostAsync<object>((string)R5YejZJgcmPOfYoEVEh(cvsCogSocketAcq.AcqPath, uSOnYxJyFXIW6OsSvRM(48854)), Array.Empty<object>()).GetAwaiter();
							_ = 0;
							num3 = ((!kit9fUJFrBQk6Umvo53()) ? 1 : 7);
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
							case 2:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (YSZs3bJmEMw31CEfHgH())
								{
								}
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							case 4:
								return;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 1:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
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
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					cvsCogSocketAcq = _003C_003E4__this;
					_ = 0;
					num = ((!kit9fUJFrBQk6Umvo53()) ? 4 : 0);
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
		internal static object uSOnYxJyFXIW6OsSvRM(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object R5YejZJgcmPOfYoEVEh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kit9fUJFrBQk6Umvo53()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YSZs3bJmEMw31CEfHgH()
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
	private struct _003CCreateImageAsync_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		public Bitmap bmp;

		private string _003CimagePath_003E5__2;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			string result = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 6:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 0:
					cvsCogSocketAcq = _003C_003E4__this;
					zvS2ElJZxtcZxkbo2eA();
					num = (SOa4XdJJFa9aIMC9ZkY() ? 1 : 5);
					continue;
				case 2:
				case 5:
					try
					{
						if (num2 != 0)
						{
							_003CimagePath_003E5__2 = null;
						}
						try
						{
							TaskAwaiter<Stream> awaiter;
							if (num2 != 0)
							{
								string text = string.Format((string)VGN2XhJ82V6wyonf9Af(48890), cvsCogSocketAcq.AcqPath, VGN2XhJ82V6wyonf9Af(48958), VGN2XhJ82V6wyonf9Af(48984));
								string text2 = (string)yMwR8sJzgVPKdUrBEd8(cvsCogSocketAcq._cogSocket, text);
								awaiter = cvsCogSocketAcq.bFuIiuBauM(text2, bmp).GetAwaiter();
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
							StreamReader streamReader = new StreamReader(awaiter.GetResult());
							try
							{
								CvsCogRef cvsCogRef = JsonConvert.DeserializeObject<CvsCogRef>(streamReader.ReadToEnd());
								_ = 1;
								switch (SOa4XdJJFa9aIMC9ZkY() ? 3 : 2)
								{
								case 0:
								case 2:
									if (cvsCogRef != null)
									{
										break;
									}
									goto end_IL_012d;
								}
								_003CimagePath_003E5__2 = (string)XCF1dO8wfiNIhjhyZ8B(cvsCogRef);
								end_IL_012d:;
							}
							finally
							{
								if (num2 < 0 && streamReader != null)
								{
									g2iCYr8sMlDMNpOv1Qn(streamReader);
								}
							}
						}
						catch (Exception ex)
						{
							cvsCogSocketAcq._logger.DebugException((string)VGN2XhJ82V6wyonf9Af(49028), ex);
							if (ex is CvsNetworkException)
							{
								throw;
							}
							throw new CvsNetworkException(ex);
						}
						result = _003CimagePath_003E5__2;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CimagePath_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 7:
					return;
				}
				_003CimagePath_003E5__2 = null;
				num = 4;
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
		internal static object VGN2XhJ82V6wyonf9Af(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yMwR8sJzgVPKdUrBEd8(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).MakeHttpUrl((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XCF1dO8wfiNIhjhyZ8B(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogRef)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void g2iCYr8sMlDMNpOv1Qn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zvS2ElJZxtcZxkbo2eA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SOa4XdJJFa9aIMC9ZkY()
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
	private struct _003CPostImageByHTTPAsync_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		public Bitmap bmp;

		public string url;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			o1vl7P8hYRnjaeDCLLT();
			int num;
			if (!p59nH38L7EWcrYNLEvt())
			{
				num = 2;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (p59nH38L7EWcrYNLEvt())
				{
				}
			}
			goto IL_01f1;
			IL_022c:
			Stream result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01f1;
			IL_01f1:
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					goto IL_022c;
				case 4:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 1;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
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
				Stream stream;
				if (num2 != 0)
				{
					stream = null;
				}
				try
				{
					int num3;
					if (num2 != 0)
					{
						cvsCogSocketAcq.jodIrn2S0p = true;
						p59nH38L7EWcrYNLEvt();
						num3 = ((!o1vl7P8hYRnjaeDCLLT()) ? 7 : 8);
						goto IL_00b3;
					}
					TaskAwaiter<Stream> awaiter = _003C_003Eu__1;
					goto IL_0070;
					IL_00b3:
					while (true)
					{
						switch (num3)
						{
						case 2:
							if (!awaiter.IsCompleted)
							{
								num3 = 3;
								continue;
							}
							goto case 10;
						case 6:
						case 7:
							break;
						case 9:
							num2 = (_003C_003E1__state = -1);
							num3 = 10;
							continue;
						case 5:
							_003C_003Eu__1 = awaiter;
							goto case 1;
						default:
							num3 = 1;
							if (o1vl7P8hYRnjaeDCLLT())
							{
								continue;
							}
							goto case 0;
						case 0:
						case 8:
							awaiter = PostImageHelper.PostImageByHTTPAsync((IRemoteDeviceApi)fSN34889hwdNZgW7cXT(cvsCogSocketAcq._cogSocket), bmp, url, cvsCogSocketAcq.FunctionName((string)WUHS5r8SMIAM68hm8KI(49094)), HttpImageTimeout, useSystemDebug: false, cvsCogSocketAcq._logger).GetAwaiter();
							num3 = 2;
							continue;
						case 3:
							num2 = (_003C_003E1__state = 0);
							num3 = 5;
							continue;
						case 1:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 4;
							continue;
						case 4:
							return;
						case 10:
							stream = awaiter.GetResult();
							goto end_IL_00b3;
						}
						goto IL_0070;
						continue;
						end_IL_00b3:
						break;
					}
					goto end_IL_0033;
					IL_0070:
					_003C_003Eu__1 = default;
					num3 = 9;
					goto IL_00b3;
					end_IL_0033:;
				}
				catch (Exception ex)
				{
					cvsCogSocketAcq.jodIrn2S0p = false;
					if (ex is CvsNetworkException)
					{
						throw;
					}
					throw new CvsNetworkException(ex);
				}
				result = stream;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_022c;
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
		internal static object fSN34889hwdNZgW7cXT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WUHS5r8SMIAM68hm8KI(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o1vl7P8hYRnjaeDCLLT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p59nH38L7EWcrYNLEvt()
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
	private struct _003CGetSettingsId_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!XlITmf8EygwZtdVnaem()) ? 4 : 3);
					continue;
				case 2:
				case 4:
					try
					{
						try
						{
							TaskAwaiter<string> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = ((IRemoteDeviceApi)NJZgvG8HqCVtTjR2rpJ(cvsCogSocketAcq._cogSocket)).PostAsync<string>((string)CJNS6B8ABCZ6WWCQuTs(cvsCogSocketAcq.AcqPath, BJG2wl8VhKOOcCItNLI(49138)), Array.Empty<object>()).GetAwaiter();
								num3 = 7;
								goto IL_011e;
							}
							awaiter = _003C_003Eu__1;
							goto IL_00e2;
							IL_00e2:
							_003C_003Eu__1 = default;
							num3 = 6;
							if (!XlITmf8EygwZtdVnaem())
							{
								goto IL_00fe;
							}
							goto IL_011e;
							IL_00fe:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							IL_011e:
							while (true)
							{
								switch (num3)
								{
								case 7:
									if (!awaiter.IsCompleted)
									{
										goto IL_0084;
									}
									goto case 9;
								case 1:
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									continue;
								case 4:
									return;
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									break;
								case 3:
								case 5:
									break;
								case 0:
									goto IL_00fe;
								default:
									num3 = 4;
									continue;
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									continue;
								case 9:
									result = awaiter.GetResult();
									goto end_IL_0038;
								}
								break;
								IL_0084:
								xujJgR8v4T7RXMGXXTN();
								num3 = ((!XlITmf8EygwZtdVnaem()) ? 3 : 2);
							}
							goto IL_00e2;
							end_IL_0038:;
						}
						catch
						{
							result = null;
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
					num = 5;
					continue;
				case 1:
				case 3:
					cvsCogSocketAcq = _003C_003E4__this;
					goto case 2;
				case 5:
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
		internal static object NJZgvG8HqCVtTjR2rpJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BJG2wl8VhKOOcCItNLI(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CJNS6B8ABCZ6WWCQuTs(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XlITmf8EygwZtdVnaem()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xujJgR8v4T7RXMGXXTN()
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
	private struct _003CGetEditableProperties_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IEnumerable<CvsCogPropertyDescriptorGroup>> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private ConfiguredTaskAwaitable<IEnumerable<CvsCogPropertyDescriptorGroup>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IpQExF8DG1qymgsNL71();
			int num;
			if (!kiXEVx8UbbG0HHxGWj7())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0193;
			IL_01f1:
			CvsCogSocketAcq cvsCogSocketAcq = _003C_003E4__this;
			num = 3;
			goto IL_0193;
			IL_0193:
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
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto IL_01f1;
				case 2:
					goto IL_01d5;
				case 1:
				case 5:
					goto IL_01f1;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			IEnumerable<CvsCogPropertyDescriptorGroup> result = default;
			try
			{
				ConfiguredTaskAwaitable<IEnumerable<CvsCogPropertyDescriptorGroup>> configuredTaskAwaitable = default;
				int num3;
				if (num2 != 0)
				{
					configuredTaskAwaitable = cvsCogSocketAcq.GetAcqSettingsEditableProperties().ConfigureAwait(continueOnCapturedContext: false);
					num3 = 0;
					goto IL_0113;
				}
				ConfiguredTaskAwaitable<IEnumerable<CvsCogPropertyDescriptorGroup>>.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_0048;
				IL_0048:
				_003C_003Eu__1 = default;
				num3 = 4;
				if (kiXEVx8UbbG0HHxGWj7())
				{
				}
				goto IL_0113;
				IL_0113:
				while (true)
				{
					switch (num3)
					{
					case 6:
					case 9:
						break;
					case 3:
					case 5:
						return;
					case 2:
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							continue;
						}
						goto case 10;
					case 0:
						awaiter = configuredTaskAwaitable.GetAwaiter();
						num3 = 2;
						continue;
					case 4:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						kiXEVx8UbbG0HHxGWj7();
						num3 = (IpQExF8DG1qymgsNL71() ? 3 : 9);
						continue;
					case 1:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						continue;
					case 8:
						_003C_003Eu__1 = awaiter;
						goto case 7;
					default:
						num3 = 7;
						if (true)
						{
							continue;
						}
						goto case 10;
					case 10:
						result = awaiter.GetResult();
						goto end_IL_0113;
					}
					goto IL_0048;
					continue;
					end_IL_0113:
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
			goto IL_01d5;
			IL_01d5:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (IpQExF8DG1qymgsNL71())
			{
				goto IL_0193;
			}
			goto IL_01f1;
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
		internal static bool IpQExF8DG1qymgsNL71()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kiXEVx8UbbG0HHxGWj7()
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
	private struct _003CGetAllProperties_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IEnumerable<UntypedDescribedProperty>> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private ConfiguredTaskAwaitable<CvsCogAcqSettingsContainer>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			IEnumerable<UntypedDescribedProperty> describedProperties = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			ConfiguredTaskAwaitable<CvsCogAcqSettingsContainer> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<CvsCogAcqSettingsContainer>.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					if (!VPBpAd8deR6ElboNvH6())
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult(describedProperties);
					num = 6;
					break;
				case 0:
					cvsCogSocketAcq = _003C_003E4__this;
					_ = 0;
					if (n7pcuq8TPYNBY4oFMXY())
					{
						num = 4;
						break;
					}
					num = 1;
					if (VPBpAd8deR6ElboNvH6())
					{
					}
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketAcq.GetAcqSettingsContainer().ConfigureAwait(continueOnCapturedContext: false);
							_ = 0;
							if (n7pcuq8TPYNBY4oFMXY())
							{
								num3 = 3;
							}
							else
							{
								num3 = 5;
								if (false)
								{
									goto IL_0164;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_00fc;
						IL_00fc:
						while (true)
						{
							switch (num3)
							{
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 8:
								return;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
							case 3:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								break;
							case 1:
							case 5:
								break;
							case 10:
								goto IL_017c;
							}
							break;
						}
						goto IL_0164;
						IL_017c:
						describedProperties = awaiter.GetResult().GetDescribedProperties();
						goto end_IL_0062;
						IL_0164:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							if (0 == 0)
							{
								goto IL_00fc;
							}
						}
						goto IL_017c;
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
		internal static bool n7pcuq8TPYNBY4oFMXY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VPBpAd8deR6ElboNvH6()
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
	private struct _003CSetPropertyValue_003Ed__84<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		public UntypedDescribedProperty property;

		public T value;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 3 : 5);
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			ConfiguredTaskAwaitable configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketAcq.PutAcqSetting(property.PropertyName, value).ConfigureAwait(continueOnCapturedContext: false);
							_ = 0;
							num3 = ((1 == 0) ? 6 : 2);
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
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 0:
							case 2:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 5;
								continue;
							case 3:
								return;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								goto case 6;
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
				default:
					num = 2;
					continue;
				case 2:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static bool ROQHHW8igMfVHOK1hZ3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jGGH5q8qEPvVEqT4Igg()
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
	private struct _003CSetPropertyValue_003Ed__85<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		public CvsCogPropertyDescriptor property;

		public T value;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 1 : 3);
			int num2 = default;
			ConfiguredTaskAwaitable configuredTaskAwaitable = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketAcq.PutAcqSetting(property.Path, value).ConfigureAwait(continueOnCapturedContext: false);
							num3 = 0;
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
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 1:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 2:
								return;
							case 3:
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 0:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								_ = 0;
								num3 = (true ? 8 : 7);
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
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
				default:
					num = 4;
					continue;
				case 5:
					cvsCogSocketAcq = _003C_003E4__this;
					goto case 1;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static bool H7eql18BCOjRNbhSi7Y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pfG1jb8judjKwD3jALg()
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
	private struct _003CGetPropertyValue_003Ed__86<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		public UntypedDescribedProperty property;

		private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 4 : 5);
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			ConfiguredTaskAwaitable<T> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter awaiter = default;
			T result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketAcq.GetAcqSetting<T>(property.PropertyName).ConfigureAwait(continueOnCapturedContext: false);
							_ = 0;
							num3 = ((1 == 0) ? 6 : 5);
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
								num3 = 7;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 2:
								return;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 0:
							case 5:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								goto case 1;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 10:
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
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
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
		internal static bool K4o8ap8cZ8b7Ltx9mSD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QHhIaZ826S1n0mhXFiY()
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
	private struct _003CGetPropertyValue_003Ed__87<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		public CvsCogPropertyDescriptor property;

		private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			int num2 = default;
			ConfiguredTaskAwaitable<T> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter awaiter = default;
			T result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					cvsCogSocketAcq = _003C_003E4__this;
					goto case 2;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((1 == 0) ? 3 : 0);
					continue;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketAcq.GetAcqSetting<T>(property.Path).ConfigureAwait(continueOnCapturedContext: false);
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 0;
							num3 = (true ? 8 : 9);
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 2;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 7:
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 6:
							case 8:
								_003C_003Eu__1 = default;
								goto case 7;
							case 5:
								return;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 10:
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
					num = 5;
					continue;
				case 5:
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
		internal static bool N6CYOV8WqovDC1cYOu7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WjoOGL87cb5ucvTRFeQ()
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
	private struct _003CResetAcqSettingToDefault_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (pg4CRB8CSNSm5XkCa8h() ? 5 : 4);
			int num2 = default;
			ConfiguredTaskAwaitable configuredTaskAwaitable = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = GEM8Sj8KmmMF8JMcVD6(cvsCogSocketAcq.ResetToDefaults(), false);
							_ = 1;
							num3 = (pg4CRB8CSNSm5XkCa8h() ? 7 : 4);
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
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 2;
							case 8:
								return;
							case 2:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (amZ9Kh8tNFyUChsIHf5())
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
							case 4:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 6;
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
				default:
					num = 3;
					if (amZ9Kh8tNFyUChsIHf5())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					cvsCogSocketAcq = _003C_003E4__this;
					num = 2;
					if (amZ9Kh8tNFyUChsIHf5())
					{
						continue;
					}
					break;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static ConfiguredTaskAwaitable GEM8Sj8KmmMF8JMcVD6(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool amZ9Kh8tNFyUChsIHf5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pg4CRB8CSNSm5XkCa8h()
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
	private struct _003CExecute_003Ed__89 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketAcq _003C_003E4__this;

		public CogSocketActionPath action;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			CvsCogSocketAcq cvsCogSocketAcq = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					Vr0L4b85TExLRDBSRW1();
					num = ((!TnMtGh8oHsIa3A4gbuj()) ? 3 : 0);
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((IRemoteDeviceApi)a5Dtre8P9P6fX7AjF3F(cvsCogSocketAcq._cogSocket)).PostAsync<object>((string)raJUKx8N55iiruaCOed(cvsCogSocketAcq.AcqPath, s51TOf8YyAtwq31ZqFh(action)), Array.Empty<object>()).GetAwaiter();
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (!Vr0L4b85TExLRDBSRW1())
							{
								goto IL_016f;
							}
						}
						goto IL_0110;
						IL_016f:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_0110;
						IL_0110:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								if (!TnMtGh8oHsIa3A4gbuj())
								{
									num3 = 1;
									if (!TnMtGh8oHsIa3A4gbuj())
									{
										continue;
									}
									goto case 6;
								}
								num3 = 0;
								if (!TnMtGh8oHsIa3A4gbuj())
								{
									continue;
								}
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 0:
								return;
							case 5:
								break;
							case 9:
								awaiter.GetResult();
								goto end_IL_0110;
							}
							goto IL_016f;
							continue;
							end_IL_0110:
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
				case 1:
				case 3:
					cvsCogSocketAcq = _003C_003E4__this;
					goto case 0;
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
		internal static object a5Dtre8P9P6fX7AjF3F(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object s51TOf8YyAtwq31ZqFh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CogSocketActionPath)P_0).Path;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object raJUKx8N55iiruaCOed(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vr0L4b85TExLRDBSRW1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TnMtGh8oHsIa3A4gbuj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected readonly CvsCogSocket _cogSocket;

	protected readonly ManualResetEvent _waitForImageReady;

	protected readonly ILogger _logger;

	private bool jodIrn2S0p;

	private int OAHICfBLu6;

	private int yJgI2FwRqs;

	private static TimeSpan TfpIyLNN0w;

	private static TimeSpan kN9IVnlEsT;

	private bool b5MIvLDegB;

	private string pNhIZu2S25;

	protected object _lockLatestAcqImageUrl;

	[CompilerGenerated]
	private EventHandler CoBI8Vgjm2;

	[CompilerGenerated]
	private EventHandler<CogSocketEventArgs> PWQIz9LI0a;

	[CompilerGenerated]
	private EventHandler<CogSocketEventArgs> mnO1PHXlgv;

	[CompilerGenerated]
	private EventHandler<CogSocketEventArgs> M3F1IiwBKm;

	public static TimeSpan HttpImageTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kN9IVnlEsT;
		}
	}

	public string AcqPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)QS5nnX9vXg3Y2YPfix5(fSGsyV99FDso0joBJWU(1550), zsk08U9EEJClL0fRSTN(_cogSocket));
		}
	}

	public string RuntimePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)QS5nnX9vXg3Y2YPfix5(fSGsyV99FDso0joBJWU(1568), _cogSocket.CamPath);
		}
	}

	public string RuntimeAcqImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)QS5nnX9vXg3Y2YPfix5(kgbOBx7BanbFa22Hp9.ol99ukmDA(1594), zsk08U9EEJClL0fRSTN(_cogSocket));
		}
	}

	public bool IsLiveAcquisition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b5MIvLDegB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dRbSXU9wv45w9L88dEm();
			int num = (ehMVZt9sJCgmjV4cb8Q() ? 1 : 3);
			while (true)
			{
				switch (num)
				{
				case 5:
					b5MIvLDegB = value;
					goto case 1;
				case 1:
				case 2:
					if (_cogSocket.IsRuntimeSupported)
					{
						goto case 4;
					}
					return;
				default:
					num = 4;
					break;
				case 0:
				case 3:
					if (b5MIvLDegB != value)
					{
						num = 5;
						break;
					}
					return;
				case 4:
					if (value)
					{
						num = 6;
						if (true)
						{
							break;
						}
						goto case 6;
					}
					try
					{
						H6t92t9HmrqMUJHLZ0c(RemoveImageReadyListenerAsync());
						return;
					}
					catch (Exception ex2)
					{
						hsWLW19VCJ1QbNrd0hP(_logger, kgbOBx7BanbFa22Hp9.ol99ukmDA(1722), ex2);
						return;
					}
				case 6:
					try
					{
						H6t92t9HmrqMUJHLZ0c(AddImageReadyListenerAsync());
						return;
					}
					catch (Exception ex)
					{
						hsWLW19VCJ1QbNrd0hP(_logger, fSGsyV99FDso0joBJWU(1646), ex);
						return;
					}
				}
			}
		}
	}

	public string LatestAcqImageUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dRbSXU9wv45w9L88dEm();
			int num;
			if (!ehMVZt9sJCgmjV4cb8Q())
			{
				num = 4;
				if (ehMVZt9sJCgmjV4cb8Q())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 2;
				if (ehMVZt9sJCgmjV4cb8Q())
				{
				}
			}
			goto IL_0078;
			IL_0078:
			object lockLatestAcqImageUrl = default;
			bool lockTaken = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 2:
					goto IL_0058;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_009f;
				case 5:
					try
					{
						Monitor.Enter(lockLatestAcqImageUrl, ref lockTaken);
						return pNhIZu2S25;
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(lockLatestAcqImageUrl);
						}
					}
				}
				break;
			}
			goto IL_002e;
			IL_0058:
			return RuntimeAcqImagePath;
			IL_002e:
			if (UlUwE09A1eywUv8hvE6(_cogSocket))
			{
				goto IL_0058;
			}
			lockLatestAcqImageUrl = _lockLatestAcqImageUrl;
			goto IL_009f;
			IL_009f:
			lockTaken = false;
			num = 5;
			goto IL_0078;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dRbSXU9wv45w9L88dEm();
			int num = (ehMVZt9sJCgmjV4cb8Q() ? 2 : 3);
			object lockLatestAcqImageUrl = default;
			bool lockTaken = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					lockLatestAcqImageUrl = _lockLatestAcqImageUrl;
					goto case 1;
				case 1:
				case 2:
					lockTaken = false;
					break;
				default:
					goto IL_006c;
				case 4:
					break;
				}
				break;
				IL_006c:
				num = 4;
			}
			try
			{
				Monitor.Enter(lockLatestAcqImageUrl, ref lockTaken);
				pNhIZu2S25 = value;
			}
			finally
			{
				if (lockTaken)
				{
					vZcky19Dn0Y98bmiNU8(lockLatestAcqImageUrl);
				}
			}
		}
	}

	public string WhiteBalancePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)VRoTl49UqbwjHJ186mU(AcqPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(2440));
		}
	}

	public AcqProperty<double> WhiteBalanceRedAcqProperty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new AcqProperty<double>(kgbOBx7BanbFa22Hp9.ol99ukmDA(2538));
		}
	}

	public AcqProperty<double> WhiteBalanceGreenAcqProperty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new AcqProperty<double>(kgbOBx7BanbFa22Hp9.ol99ukmDA(2574));
		}
	}

	public AcqProperty<double> WhiteBalanceBlueAcqProperty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new AcqProperty<double>(kgbOBx7BanbFa22Hp9.ol99ukmDA(2614));
		}
	}

	public AcqProperty<CvsCogRegion> WhiteBalanceRegionAcqProperty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new AcqProperty<CvsCogRegion>(kgbOBx7BanbFa22Hp9.ol99ukmDA(2652));
		}
	}

	public event EventHandler ImageReady
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			do
			{
				IL_0077:
				switch (num)
				{
				case 5:
					eventHandler2 = eventHandler;
					_ = 1;
					if (!ehMVZt9sJCgmjV4cb8Q())
					{
						num = 4;
						goto IL_0077;
					}
					num = 6;
					if (0 == 0)
					{
						goto IL_0077;
					}
					break;
				case 0:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						goto IL_0077;
					}
					goto case 5;
				case 1:
					eventHandler = CoBI8Vgjm2;
					num = 5;
					if (!ehMVZt9sJCgmjV4cb8Q())
					{
						goto IL_0077;
					}
					goto case 2;
				case 2:
				case 4:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					break;
				case 7:
					return;
				}
				eventHandler = Interlocked.CompareExchange(ref CoBI8Vgjm2, value2, eventHandler2);
				num = 0;
			}
			while (!ehMVZt9sJCgmjV4cb8Q());
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dRbSXU9wv45w9L88dEm();
			int num = (ehMVZt9sJCgmjV4cb8Q() ? 3 : 5);
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			do
			{
				IL_0089:
				switch (num)
				{
				case 3:
				case 4:
					if ((object)eventHandler2 != eventHandler)
					{
						break;
					}
					num = 7;
					if (0 == 0)
					{
						goto IL_0089;
					}
					goto case 2;
				case 2:
					eventHandler2 = Interlocked.CompareExchange(ref CoBI8Vgjm2, value2, eventHandler);
					goto case 3;
				case 0:
				case 5:
					eventHandler2 = CoBI8Vgjm2;
					num = 6;
					goto IL_0089;
				case 1:
					value2 = (EventHandler)IBGXyd95bBgfZkGLAZC(eventHandler, value);
					goto case 2;
				default:
					num = 2;
					goto IL_0089;
				case 6:
					break;
				case 7:
					return;
				}
				eventHandler = eventHandler2;
				num = 1;
			}
			while (!ehMVZt9sJCgmjV4cb8Q());
		}
	}

	public event EventHandler<CogSocketEventArgs> AcquisitionErrorReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = PWQIz9LI0a;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PWQIz9LI0a, value2, eventHandler2);
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
			EventHandler<CogSocketEventArgs> eventHandler = PWQIz9LI0a;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PWQIz9LI0a, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CogSocketEventArgs> SettingChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = mnO1PHXlgv;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref mnO1PHXlgv, value2, eventHandler2);
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
			EventHandler<CogSocketEventArgs> eventHandler = mnO1PHXlgv;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref mnO1PHXlgv, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CogSocketEventArgs> PropertyDescriptorsChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = M3F1IiwBKm;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref M3F1IiwBKm, value2, eventHandler2);
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
			EventHandler<CogSocketEventArgs> eventHandler = M3F1IiwBKm;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref M3F1IiwBKm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCogSocketAcq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		int value2 = default;
		int value = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 7:
				kN9IVnlEsT = L7vHed9LY2t8bbnXKHB(30000.0);
				goto case 1;
			case 1:
			case 3:
				if (AppConfiguration.TryGet<int>((string)fSGsyV99FDso0joBJWU(1412), out value2))
				{
					goto case 8;
				}
				goto case 0;
			default:
				num = 8;
				if (dRbSXU9wv45w9L88dEm())
				{
					break;
				}
				goto case 8;
			case 8:
				TfpIyLNN0w = L7vHed9LY2t8bbnXKHB(value2);
				num = 0;
				if (dRbSXU9wv45w9L88dEm())
				{
					break;
				}
				goto case 0;
			case 0:
				if (AppConfiguration.TryGet<int>(kgbOBx7BanbFa22Hp9.ol99ukmDA(1482), out value))
				{
					num = 6;
					break;
				}
				return;
			case 5:
				TfpIyLNN0w = L7vHed9LY2t8bbnXKHB(30000.0);
				_ = 1;
				num = (ehMVZt9sJCgmjV4cb8Q() ? 1 : 7);
				break;
			case 4:
				znfVfy9hSKCXPYXgcSo();
				num = 5;
				break;
			case 6:
				kN9IVnlEsT = TimeSpan.FromMilliseconds(value);
				num = 9;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSocketAcq(CvsCogSocket cogSocket)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dRbSXU9wv45w9L88dEm();
		int num = (ehMVZt9sJCgmjV4cb8Q() ? 2 : 7);
		while (true)
		{
			switch (num)
			{
			case 5:
				_waitForImageReady = new ManualResetEvent(initialState: false);
				num = 1;
				break;
			case 4:
				base._002Ector();
				num = 6;
				break;
			case 1:
				_logger = LogManager.GetLogger<CvsCogSocketAcq>();
				goto case 2;
			case 0:
			case 7:
				znfVfy9hSKCXPYXgcSo();
				num = 5;
				break;
			case 2:
			case 3:
				_lockLatestAcqImageUrl = new object();
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				_cogSocket = cogSocket;
				num = 8;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSocketAcq(CvsCogSocket cogSocket, SynchronizationContext context)
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
		goto IL_008a;
		IL_001a:
		_cogSocket = cogSocket;
		num = 8;
		goto IL_008a;
		IL_008a:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 3:
				base._002Ector(context);
				num = 5;
				continue;
			case 0:
			case 1:
				_waitForImageReady = new ManualResetEvent(initialState: false);
				goto case 2;
			case 2:
			case 7:
				_logger = LogManager.GetLogger<CvsCogSocketAcq>();
				num = 4;
				continue;
			case 4:
				_lockLatestAcqImageUrl = new object();
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				znfVfy9hSKCXPYXgcSo();
				dRbSXU9wv45w9L88dEm();
				if (ehMVZt9sJCgmjV4cb8Q())
				{
					num = 7;
					continue;
				}
				num = 0;
				if (ehMVZt9sJCgmjV4cb8Q())
				{
				}
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddListenersAsync_003Ed__13))]
	public Task AddListenersAsync()
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
		goto IL_004c;
		IL_0032:
		_003CAddListenersAsync_003Ed__13 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0077;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 0:
			case 2:
				goto IL_0032;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0077;
			case 5:
				stateMachine._003C_003Et__builder = mDUaHH9SsK2SU3qlitB();
				dRbSXU9wv45w9L88dEm();
				if (ehMVZt9sJCgmjV4cb8Q())
				{
					num = 0;
					continue;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0077:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_004c;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_0032;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveListenersAsync_003Ed__14))]
	public Task RemoveListenersAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dRbSXU9wv45w9L88dEm();
		int num;
		if (!ehMVZt9sJCgmjV4cb8Q())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0084;
		IL_002a:
		_003CRemoveListenersAsync_003Ed__14 stateMachine = default;
		stateMachine._003C_003Et__builder = mDUaHH9SsK2SU3qlitB();
		num = 5;
		goto IL_0084;
		IL_0084:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddImageReadyListenerAsync_003Ed__15))]
	public Task AddImageReadyListenerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!dRbSXU9wv45w9L88dEm()) ? 2 : 5);
		_003CAddImageReadyListenerAsync_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = mDUaHH9SsK2SU3qlitB();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveImageReadyListenerAsync_003Ed__16))]
	public Task RemoveImageReadyListenerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CRemoveImageReadyListenerAsync_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
				stateMachine._003C_003Et__builder = mDUaHH9SsK2SU3qlitB();
				_ = 1;
				if (!ehMVZt9sJCgmjV4cb8Q())
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
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddAcquisitionErrorListenerAsync_003Ed__17))]
	public Task AddAcquisitionErrorListenerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!dRbSXU9wv45w9L88dEm())
		{
			goto IL_001e;
		}
		goto IL_008c;
		IL_0072:
		_003CAddAcquisitionErrorListenerAsync_003Ed__17 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0058;
		IL_008c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 4:
				goto IL_0036;
			case 0:
				goto IL_0058;
			case 2:
			case 3:
				goto IL_0072;
			default:
				num = 0;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0036:
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			_ = 0;
			num = (dRbSXU9wv45w9L88dEm() ? 5 : 3);
		}
		goto IL_001e;
		IL_0058:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (1 == 0)
		{
			goto IL_0072;
		}
		goto IL_008c;
		IL_001e:
		stateMachine._003C_003E4__this = this;
		goto IL_0072;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveAcquisitionErrorListenerAsync_003Ed__18))]
	public Task RemoveAcquisitionErrorListenerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CRemoveAcquisitionErrorListenerAsync_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (dRbSXU9wv45w9L88dEm())
				{
					num = 5;
					if (ehMVZt9sJCgmjV4cb8Q())
					{
					}
				}
				else
				{
					num = 0;
				}
				break;
			case 1:
				stateMachine._003C_003Et__builder = mDUaHH9SsK2SU3qlitB();
				num = 4;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
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
	public Task ResetToDefaults()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.PostAsync<object>((string)VRoTl49UqbwjHJ186mU(AcqPath, fSGsyV99FDso0joBJWU(1802)), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task EnableTrigger()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PostAsync<object>((string)VRoTl49UqbwjHJ186mU(AcqPath, fSGsyV99FDso0joBJWU(1852)), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task DisableTrigger()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PostAsync<object>(AcqPath + (string)fSGsyV99FDso0joBJWU(1868), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object[]> PrivateAcquisition(string format, string clientId = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.PostAsync<object[]>(AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(1886), new object[2] { format, clientId });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CancelAllAcquisitions()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PostAsync<object>((string)VRoTl49UqbwjHJ186mU(AcqPath, fSGsyV99FDso0joBJWU(1918)), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ManualTriggerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsTraceSDK.Info.TraceMessage(FunctionName(kgbOBx7BanbFa22Hp9.ol99ukmDA(1964)));
		jodIrn2S0p = true;
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PostAsync<object>((string)VRoTl49UqbwjHJ186mU(AcqPath, fSGsyV99FDso0joBJWU(2004)), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualTrigger(bool block = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = CvsTraceSDK.Info.TraceFunction(FunctionName((string)fSGsyV99FDso0joBJWU(2032)));
		try
		{
			jodIrn2S0p = true;
			try
			{
				if (!block || !_cogSocket.IsRuntimeSupported)
				{
					goto IL_0156;
				}
				int num = 8;
				goto IL_01a5;
				IL_00f8:
				_cogSocket.DeviceApi.PostAsync<object>(AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2004), Array.Empty<object>()).Wait();
				goto IL_0137;
				IL_0187:
				_waitForImageReady.Reset();
				goto IL_00f8;
				IL_01a5:
				while (true)
				{
					switch (num)
					{
					case 0:
						CvsTraceSDK.Error.TraceMessage((string)fSGsyV99FDso0joBJWU(2062), FunctionName(kgbOBx7BanbFa22Hp9.ol99ukmDA(2032)), fSGsyV99FDso0joBJWU(2148));
						num = 2;
						continue;
					case 8:
						Q1019L9dq87uOnWKe2j(CvsTraceSDK.Error, kgbOBx7BanbFa22Hp9.ol99ukmDA(2062), new object[2]
						{
							FunctionName(kgbOBx7BanbFa22Hp9.ol99ukmDA(2032)),
							fSGsyV99FDso0joBJWU(2082)
						});
						num = 7;
						if (!ehMVZt9sJCgmjV4cb8Q())
						{
							continue;
						}
						return;
					case 2:
						return;
					case 1:
						break;
					case 5:
					case 6:
						goto IL_0137;
					case 4:
						goto IL_0156;
					case 7:
						goto IL_0178;
					case 3:
					case 9:
						goto IL_0187;
					default:
						num = 1;
						if (0 == 0)
						{
							continue;
						}
						return;
					case 10:
						return;
					}
					break;
				}
				goto IL_00f8;
				IL_0137:
				if (_waitForImageReady.WaitOne(TfpIyLNN0w))
				{
					LdON8r9iXktKNY6A19U(_cogSocket);
					num = 10;
				}
				else
				{
					num = 0;
				}
				goto IL_01a5;
				IL_0156:
				if (block)
				{
					ehMVZt9sJCgmjV4cb8Q();
					if (!dRbSXU9wv45w9L88dEm())
					{
						num = 6;
					}
					else
					{
						num = 9;
						if (false)
						{
							goto IL_0178;
						}
					}
					goto IL_01a5;
				}
				TBoJtS9qe58tbyriDwY(((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PostAsync<object>(AcqPath + (string)fSGsyV99FDso0joBJWU(2004), Array.Empty<object>()));
				return;
				IL_0178:
				block = false;
				num = 4;
				if (false)
				{
					goto IL_0187;
				}
				goto IL_01a5;
			}
			finally
			{
				if (block)
				{
					jodIrn2S0p = false;
				}
			}
		}
		finally
		{
			if (disposable != null)
			{
				fUihNO9BtO8aCdsxFKF(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAcqSettings GetAcqSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsCogAcqSettings)gByRDC9joZaDLY46my3(GetAcqSettingsContainer().Result);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogAcqSettingsContainer> GetAcqSettingsContainer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogAcqSettingsContainer>(AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2210));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAcqSettingsEditableProperties_003Ed__43))]
	public Task<IEnumerable<CvsCogPropertyDescriptorGroup>> GetAcqSettingsEditableProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAcqSettingsEditableProperties_003Ed__43 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<CvsCogPropertyDescriptorGroup>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> GetAcqSetting<T>(string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2230) + propertyName;
		return _cogSocket.DeviceApi.GetAsync<T>(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PutAcqSetting<T>(string propertyName, T propertyValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2230) + propertyName;
		return _cogSocket.DeviceApi.PutAsync<object>(path, propertyValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> GetAcqPropertySetting<T>(AcqProperty<T> property)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<T>(AcqPath + property.Path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PutAcqPropertySetting<T>(AcqProperty<T> property, T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.PutAsync<T>(AcqPath + property.Path, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PutFocusRegionSetting(CvsCogRegion region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PutAsync<object>((string)VRoTl49UqbwjHJ186mU(AcqPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(2252)), (object)region);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogRegion> GetFocusRegionBounds()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogRegion>(AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2298));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<double> GetAcqFocusPositionResolution()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<double>(AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2356));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetAcqFocusAttached()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<bool>(AcqPath + (string)fSGsyV99FDso0joBJWU(2408)).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAcqWhiteBalanceSupported_003Ed__54))]
	public Task<bool> GetAcqWhiteBalanceSupported()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAcqWhiteBalanceSupported_003Ed__54 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CIs2DLineScanAsync_003Ed__55))]
	public Task<bool> Is2DLineScanAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CIs2DLineScanAsync_003Ed__55 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptsPointCloudsAsync_003Ed__56))]
	public Task<bool> AcceptsPointCloudsAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAcceptsPointCloudsAsync_003Ed__56 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetAcqWhiteBalanceConnected()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).GetAsync<bool>((string)VRoTl49UqbwjHJ186mU(WhiteBalancePath, fSGsyV99FDso0joBJWU(2488))).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogRegion> GetWhiteBalanceRegionBounds()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogRegion>(WhiteBalancePath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2510));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PutWhiteBalanceRegionSetting(CvsCogRegion region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PutAsync<object>(AcqPath + (string)fSGsyV99FDso0joBJWU(2652), (object)region);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetAcqIlluminationDetected()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).GetAsync<bool>((string)VRoTl49UqbwjHJ186mU(AcqPath, fSGsyV99FDso0joBJWU(2712))).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogIlluminationObject GetAcqIlluminationObject()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).GetAsync<CvsCogIlluminationObject>(AcqPath + (string)fSGsyV99FDso0joBJWU(2762)).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAcqProperties GetAcqProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).GetAsync<CvsCogAcqProperties>((string)VRoTl49UqbwjHJ186mU(AcqPath, fSGsyV99FDso0joBJWU(2790))).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogImage> GetAcqImageProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogImage>(LatestAcqImageUrl);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogAcquisitionStatus> GetAcqStatus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.PostAsync<CvsCogAcquisitionStatus>(AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2814), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogRef> GetLastImageRef()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _cogSocket.DeviceApi.GetAsync<CvsCogRef>(AcqPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(2836));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoAutofocus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TBoJtS9qe58tbyriDwY(((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PostAsync<object>((string)VRoTl49UqbwjHJ186mU(AcqPath, fSGsyV99FDso0joBJWU(2860)), Array.Empty<object>()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoAutoWhiteBalance()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TBoJtS9qe58tbyriDwY(((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket)).PostAsync<object>((string)VRoTl49UqbwjHJ186mU(AcqPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(2894)), Array.Empty<object>()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAutoExposure_003Ed__76))]
	public Task DoAutoExposure()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ehMVZt9sJCgmjV4cb8Q();
		int num;
		if (dRbSXU9wv45w9L88dEm())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0056;
		IL_002a:
		_003CDoAutoExposure_003Ed__76 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0056;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = mDUaHH9SsK2SU3qlitB();
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAutoROI_003Ed__77))]
	public Task DoAutoROI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDoAutoROI_003Ed__77 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				while (true)
				{
					stateMachine._003C_003Et__builder = mDUaHH9SsK2SU3qlitB();
					ehMVZt9sJCgmjV4cb8Q();
					if (dRbSXU9wv45w9L88dEm())
					{
						break;
					}
					num = 4;
					if (dRbSXU9wv45w9L88dEm())
					{
						goto end_IL_0032;
					}
				}
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (dRbSXU9wv45w9L88dEm())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				{
					return stateMachine._003C_003Et__builder.Task;
				}
				end_IL_0032:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateImageAsync_003Ed__78))]
	public Task<string> CreateImageAsync(Bitmap bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateImageAsync_003Ed__78 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bmp = bmp;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PostImageByHTTP(Bitmap bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (dRbSXU9wv45w9L88dEm())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_008e;
			}
		}
		string url = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				url = (string)XIaKwV9cEZNdUZeT0Y1(_cogSocket, text);
				break;
			default:
				goto IL_005c;
			case 0:
			case 2:
				text = (string)QS5nnX9vXg3Y2YPfix5(kgbOBx7BanbFa22Hp9.ol99ukmDA(2956), AcqPath);
				goto case 1;
			case 4:
				break;
			}
			break;
			IL_005c:
			num = 4;
		}
		goto IL_008e;
		IL_008e:
		try
		{
			jodIrn2S0p = true;
			PostImageHelper.PostImageByHTTP((IRemoteDeviceApi)OiNv8H9TQxCo5a6FPAJ(_cogSocket), bmp, url, FunctionName((string)fSGsyV99FDso0joBJWU(2984)), Y6gOj0924SFj5fETdQ1(), useSystemDebug: false, _logger);
		}
		catch (Exception ex)
		{
			jodIrn2S0p = false;
			if (ex is CvsNetworkException)
			{
				throw;
			}
			throw new CvsNetworkException(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostImageByHTTPAsync_003Ed__80))]
	private Task<Stream> bFuIiuBauM(string P_0, Bitmap P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPostImageByHTTPAsync_003Ed__80 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = P_0;
		stateMachine.bmp = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSettingsId_003Ed__81))]
	public Task<string> GetSettingsId()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSettingsId_003Ed__81 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetEditableProperties_003Ed__82))]
	public Task<IEnumerable<CvsCogPropertyDescriptorGroup>> GetEditableProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetEditableProperties_003Ed__82 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<CvsCogPropertyDescriptorGroup>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAllProperties_003Ed__83))]
	public Task<IEnumerable<UntypedDescribedProperty>> GetAllProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAllProperties_003Ed__83 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<UntypedDescribedProperty>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetPropertyValue_003Ed__84<>))]
	public Task SetPropertyValue<T>(UntypedDescribedProperty property, T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSetPropertyValue_003Ed__84<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.property = property;
		stateMachine.value = value;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetPropertyValue_003Ed__85<>))]
	public Task SetPropertyValue<T>(CvsCogPropertyDescriptor property, T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSetPropertyValue_003Ed__85<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.property = property;
		stateMachine.value = value;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPropertyValue_003Ed__86<>))]
	public Task<T> GetPropertyValue<T>(UntypedDescribedProperty property)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPropertyValue_003Ed__86<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.property = property;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPropertyValue_003Ed__87<>))]
	public Task<T> GetPropertyValue<T>(CvsCogPropertyDescriptor property)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPropertyValue_003Ed__87<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.property = property;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CResetAcqSettingToDefault_003Ed__88))]
	public Task ResetAcqSettingToDefault()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!ehMVZt9sJCgmjV4cb8Q())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (!dRbSXU9wv45w9L88dEm())
			{
				goto IL_00b5;
			}
		}
		_003CResetAcqSettingToDefault_003Ed__88 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = mDUaHH9SsK2SU3qlitB();
				num = 3;
				continue;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				continue;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				break;
			}
			break;
		}
		goto IL_00b5;
		IL_00b5:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CExecute_003Ed__89))]
	public Task Execute(CogSocketActionPath action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ehMVZt9sJCgmjV4cb8Q();
		int num;
		if (dRbSXU9wv45w9L88dEm())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0044;
		IL_009d:
		_003CExecute_003Ed__89 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0073;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				num = 2;
				continue;
			case 3:
			case 4:
				goto IL_0073;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 2:
				goto IL_009d;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 6;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine.action = action;
		goto IL_009d;
		IL_0073:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0044;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dSuIdH3LPg(object P_0, CogSocketEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KJyho19Wo76Grf37Rg0(_logger, fSGsyV99FDso0joBJWU(3018));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XH9IulMmvN(object P_0, CogSocketEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!ehMVZt9sJCgmjV4cb8Q())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (!dRbSXU9wv45w9L88dEm())
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
				num = 4;
				if (dRbSXU9wv45w9L88dEm())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				disposable = (IDisposable)heWmxc97QYLexsAUu0A(CvsTraceSDK.Info, FunctionName((string)fSGsyV99FDso0joBJWU(3046)));
				break;
			case 4:
				return;
			}
			break;
		}
		try
		{
			try
			{
				if (UlUwE09A1eywUv8hvE6(_cogSocket) && b5MIvLDegB)
				{
					vUgIDLMkVq(P_1);
					return;
				}
				if (!_cogSocket.Sheet.HasSheet || IsLiveAcquisition)
				{
					string latestAcqImageUrl = LatestAcqImageUrl;
					CvsCogRef cvsCogRef = P_1.Args[2] as CvsCogRef;
					bool flag = false;
					if (!jodIrn2S0p && sXYCFf9Co1AtHkO0P0W(latestAcqImageUrl, XERGCc9tJ7E8Glw8eI9(cvsCogRef)))
					{
						Q1019L9dq87uOnWKe2j(CvsTraceSDK.Info, fSGsyV99FDso0joBJWU(2062), new object[2]
						{
							FunctionName(kgbOBx7BanbFa22Hp9.ol99ukmDA(3046)),
							XERGCc9tJ7E8Glw8eI9(cvsCogRef)
						});
						if (sXYCFf9Co1AtHkO0P0W(latestAcqImageUrl, XERGCc9tJ7E8Glw8eI9(cvsCogRef)))
						{
							LatestAcqImageUrl = (string)XERGCc9tJ7E8Glw8eI9(cvsCogRef);
						}
					}
					if (jodIrn2S0p | flag)
					{
						try
						{
							if (latestAcqImageUrl == null || sXYCFf9Co1AtHkO0P0W(latestAcqImageUrl, cvsCogRef.Url))
							{
								LatestAcqImageUrl = (string)XERGCc9tJ7E8Glw8eI9(cvsCogRef);
								((CvsCogSocketSheet)W2ixXc9KOy6MQcnOeng(_cogSocket)).FireSheetUpdated(false);
							}
						}
						catch (Exception exception)
						{
							_logger.DebugException((string)fSGsyV99FDso0joBJWU(3082), exception);
						}
						finally
						{
							jodIrn2S0p = false;
						}
					}
				}
			}
			finally
			{
				_waitForImageReady.Set();
			}
		}
		finally
		{
			disposable?.Dispose();
		}
		vUgIDLMkVq(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UXZIG9WeiQ(object P_0, CogSocketEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		InvokeEvent(PWQIz9LI0a, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vUgIDLMkVq(CogSocketEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FireHandlerReady(CoBI8Vgjm2, P_0, (string)fSGsyV99FDso0joBJWU(3144));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void FireHandlerReady(EventHandler handler, CogSocketEventArgs args, string handlerName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dRbSXU9wv45w9L88dEm();
		int num = (ehMVZt9sJCgmjV4cb8Q() ? 3 : 2);
		IEnumerator<EventHandler> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				if (handler != null)
				{
					goto case 1;
				}
				return;
			case 1:
			case 3:
				enumerator = ((IEnumerable)v8AMRq9odVpciMkkaQW(handler)).OfType<EventHandler>().GetEnumerator();
				goto case 4;
			case 4:
				try
				{
					while (zKECGV9YLhQqGNFvOid(enumerator))
					{
						EventHandler current = enumerator.Current;
						try
						{
							current(this, args);
						}
						catch (Exception ex)
						{
							hsWLW19VCJ1QbNrd0hP(_logger, Q52pZ09PdrE3Nyv4Uqj(fSGsyV99FDso0joBJWU(3158), handlerName, fSGsyV99FDso0joBJWU(3188)), ex);
						}
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						fUihNO9BtO8aCdsxFKF(enumerator);
					}
				}
			}
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected string FunctionName(string function)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)YUalol9NXIAlf50gfbN(fSGsyV99FDso0joBJWU(3210), _cogSocket.Camera, function);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void clOIeDSrWd(object P_0, CogSocketEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		InvokeEvent(mnO1PHXlgv, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OvfISiepHB(object P_0, CogSocketEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		InvokeEvent(M3F1IiwBKm, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void znfVfy9hSKCXPYXgcSo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan L7vHed9LY2t8bbnXKHB(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TimeSpan.FromMilliseconds(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fSGsyV99FDso0joBJWU(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dRbSXU9wv45w9L88dEm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ehMVZt9sJCgmjV4cb8Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder mDUaHH9SsK2SU3qlitB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zsk08U9EEJClL0fRSTN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).CamPath;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QS5nnX9vXg3Y2YPfix5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H6t92t9HmrqMUJHLZ0c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).IgnoreResult();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hsWLW19VCJ1QbNrd0hP(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UlUwE09A1eywUv8hvE6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).IsRuntimeSupported;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vZcky19Dn0Y98bmiNU8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VRoTl49UqbwjHJ186mU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OiNv8H9TQxCo5a6FPAJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).DeviceApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q1019L9dq87uOnWKe2j(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LdON8r9iXktKNY6A19U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogSocket)P_0).WaitForResultBuildComplete();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TBoJtS9qe58tbyriDwY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).Wait();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fUihNO9BtO8aCdsxFKF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gByRDC9joZaDLY46my3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAcqSettingsContainer)P_0).AsSettings();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XIaKwV9cEZNdUZeT0Y1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).MakeHttpUrl((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan Y6gOj0924SFj5fETdQ1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HttpImageTimeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KJyho19Wo76Grf37Rg0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).Debug((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object heWmxc97QYLexsAUu0A(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XERGCc9tJ7E8Glw8eI9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRef)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sXYCFf9Co1AtHkO0P0W(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W2ixXc9KOy6MQcnOeng(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IBGXyd95bBgfZkGLAZC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v8AMRq9odVpciMkkaQW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Delegate)P_0).GetInvocationList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q52pZ09PdrE3Nyv4Uqj(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zKECGV9YLhQqGNFvOid(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YUalol9NXIAlf50gfbN(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}
}
