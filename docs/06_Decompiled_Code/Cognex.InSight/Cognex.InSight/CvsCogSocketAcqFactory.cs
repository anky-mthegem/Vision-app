using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsCogSocketAcqFactory : ICogSocketAcqFactory
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreate_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ICogSocketAcq> _003C_003Et__builder;

		public CvsCogSocketAcqFactory _003C_003E4__this;

		public CvsCogSocket cogSocket;

		private ICogSocketAcq _003Cresult_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter<IEnumerable<CvsCogPropertyDescriptorGroup>> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dNFG3uzhwvYA9Ku6W9W();
			int num = (YPEVKczLrK1vckKphKi() ? 4 : 3);
			ICogSocketAcq result = default;
			int num2 = default;
			TaskAwaiter<bool> awaiter2 = default;
			TaskAwaiter<IEnumerable<CvsCogPropertyDescriptorGroup>> awaiter = default;
			CvsCogSocketAcqFactory cvsCogSocketAcqFactory = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 5:
					try
					{
						_ = 1;
						try
						{
							int num3;
							switch (num2)
							{
							default:
								num3 = 17;
								break;
							case 0:
								awaiter2 = _003C_003Eu__1;
								num3 = 1;
								break;
							case 1:
								awaiter = _003C_003Eu__2;
								num3 = 10;
								break;
							}
							while (true)
							{
								switch (num3)
								{
								case 16:
									num2 = (_003C_003E1__state = -1);
									dNFG3uzhwvYA9Ku6W9W();
									num3 = ((!YPEVKczLrK1vckKphKi()) ? 7 : 0);
									continue;
								case 2:
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 17:
									awaiter2 = cvsCogSocketAcqFactory.PAD1hTxivd(cogSocket).GetAwaiter();
									num3 = 11;
									continue;
								case 0:
								case 15:
									awaiter.GetResult();
									num3 = 18;
									continue;
								case 3:
									if (awaiter.IsCompleted)
									{
										goto case 0;
									}
									num3 = 14;
									if (true)
									{
										continue;
									}
									goto case 8;
								case 8:
									num2 = (_003C_003E1__state = -1);
									goto case 0;
								case 6:
								case 7:
									if (awaiter2.GetResult())
									{
										_003Cresult_003E5__2 = new CvsCogSocketAcq3DLineScan(cogSocket, cvsCogSocketAcqFactory.ULx1lSnCAp);
										num3 = 4;
										continue;
									}
									_003Cresult_003E5__2 = new CvsCogSocketAcq(cogSocket, cvsCogSocketAcqFactory.ULx1lSnCAp);
									goto case 4;
								case 4:
								case 13:
									awaiter = _003Cresult_003E5__2.GetEditableProperties().GetAwaiter();
									num3 = 3;
									continue;
								case 10:
									_003C_003Eu__2 = default;
									num3 = 8;
									continue;
								case 5:
									return;
								case 1:
									_003C_003Eu__1 = default;
									num3 = 16;
									continue;
								case 12:
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 5;
									continue;
								case 9:
									num2 = (_003C_003E1__state = 0);
									num3 = 2;
									continue;
								case 14:
									num2 = (_003C_003E1__state = 1);
									num3 = 12;
									continue;
								default:
									num3 = 13;
									continue;
								case 11:
									if (!awaiter2.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									goto case 6;
								case 18:
									result = _003Cresult_003E5__2;
									break;
								}
								break;
							}
						}
						catch (Exception ex)
						{
							QAk7cIzScx7v2DGLT63(cvsCogSocketAcqFactory.arY14c5XX1, FOhMTEz9V11UdCxLJEw(49328), ex);
							result = new CvsCogSocketNullAcq();
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
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				cvsCogSocketAcqFactory = _003C_003E4__this;
				num = 5;
				if (YPEVKczLrK1vckKphKi())
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
		internal static object FOhMTEz9V11UdCxLJEw(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QAk7cIzScx7v2DGLT63(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).DebugException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dNFG3uzhwvYA9Ku6W9W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YPEVKczLrK1vckKphKi()
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
	private struct _003CIsL38AcqAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocket cogsocket;

		public CvsCogSocketAcqFactory _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			bool result = default;
			int num2 = default;
			CvsCogSocketAcqFactory cvsCogSocketAcqFactory = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (!jI2dEpzv5Kf40OZJOwP())
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					try
					{
						try
						{
							TaskAwaiter<bool> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = cogsocket.AcceptsPointCloudsAsync().GetAwaiter();
								jI2dEpzv5Kf40OZJOwP();
								num3 = ((!CRt4KBzE7I7ycTydMMT()) ? 5 : 9);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 7;
							}
							do
							{
								IL_00b8:
								switch (num3)
								{
								case 7:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 6;
									goto IL_00b8;
								case 3:
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									goto IL_00b8;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 2;
									goto IL_00b8;
								case 6:
									if (awaiter.GetResult())
									{
										num3 = 4;
										if (CRt4KBzE7I7ycTydMMT())
										{
											goto IL_00b8;
										}
										goto case 4;
									}
									goto IL_0194;
								case 4:
									result = true;
									num3 = 10;
									if (CRt4KBzE7I7ycTydMMT())
									{
										goto IL_00b8;
									}
									goto case 0;
								case 0:
								case 9:
									if (!awaiter.IsCompleted)
									{
										break;
									}
									goto case 6;
								case 2:
									return;
								case 1:
								case 5:
									break;
								case 10:
									goto end_IL_00b8;
								}
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
								end_IL_00b8:
								break;
							}
							while (CRt4KBzE7I7ycTydMMT());
						}
						catch (Exception ex)
						{
							KQ9LhlzH0wS02Cfro4i(cvsCogSocketAcqFactory.arY14c5XX1, kgbOBx7BanbFa22Hp9.ol99ukmDA(49440), ex);
							goto IL_0194;
						}
						goto end_IL_0034;
						IL_0194:
						result = false;
						end_IL_0034:;
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
					cvsCogSocketAcqFactory = _003C_003E4__this;
					jI2dEpzv5Kf40OZJOwP();
					num = (CRt4KBzE7I7ycTydMMT() ? 4 : 5);
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					if (1 == 0)
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
		internal static void KQ9LhlzH0wS02Cfro4i(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).DebugException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CRt4KBzE7I7ycTydMMT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jI2dEpzv5Kf40OZJOwP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ILogger arY14c5XX1;

	private readonly SynchronizationContext ULx1lSnCAp;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSocketAcqFactory()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (PrewTy9b2kVW7AfRcfk())
		{
			num = 5;
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_0041;
			}
		}
		goto IL_006e;
		IL_006e:
		while (true)
		{
			switch (num)
			{
			case 4:
				arY14c5XX1 = LogManager.GetLogger<CvsCogSocketAcqFactory>();
				goto case 2;
			case 1:
				break;
			case 2:
			case 3:
				HEJpTh904KJi31o0dYs(this);
				break;
			default:
				num = 1;
				continue;
			case 0:
			case 5:
				RsqeGt9pfFQPolpqYlJ();
				num = 4;
				if (!cEfxPw960RpTmQ9GIgs())
				{
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_0041;
		IL_0041:
		ULx1lSnCAp = (SynchronizationContext)uxTDNT94dA8jG1yUdJe();
		num = 6;
		goto IL_006e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreate_003Ed__3))]
	public Task<ICogSocketAcq> Create(CvsCogSocket cogSocket)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreate_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ICogSocketAcq>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cogSocket = cogSocket;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CIsL38AcqAsync_003Ed__4))]
	private Task<bool> PAD1hTxivd(CvsCogSocket P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CIsL38AcqAsync_003Ed__4 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cogsocket = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RsqeGt9pfFQPolpqYlJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HEJpTh904KJi31o0dYs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uxTDNT94dA8jG1yUdJe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SynchronizationContext.Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PrewTy9b2kVW7AfRcfk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cEfxPw960RpTmQ9GIgs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
