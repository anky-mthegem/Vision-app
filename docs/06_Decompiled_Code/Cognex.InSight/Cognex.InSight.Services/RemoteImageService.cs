using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Services;

internal class RemoteImageService : CognexRemoteServiceBase<Stream>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public RemoteImageService _003C_003E4__this;

		public string imageReference;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			RemoteImageService remoteImageService = default;
			Stream result = default;
			TimeSpan timeout = default;
			TaskAwaiter<Stream> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!fBIOYKsNdy5iH17DWZtS()) ? 4 : 3);
					break;
				case 1:
				case 3:
					remoteImageService = _003C_003E4__this;
					goto case 2;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							timeout = A7vcGNsNqW0jqa1BVTmV();
							num3 = 8;
							goto IL_0150;
						}
						awaiter = _003C_003Eu__1;
						goto IL_008d;
						IL_018d:
						result = awaiter.GetResult();
						goto end_IL_0064;
						IL_00a5:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							goto IL_0150;
						}
						goto IL_018d;
						IL_0150:
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
							case 6:
								break;
							case 1:
							case 9:
								goto IL_00a5;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 7:
								return;
							case 8:
								goto IL_00f0;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto IL_018d;
							case 10:
								goto IL_018d;
							}
							break;
							IL_00f0:
							awaiter = remoteImageService.MhmTTDpFli.MakeHttpGetRequest(imageReference, timeout).GetAwaiter();
							ii8HyFsNiJWgiVnk22Wq();
							num3 = (fBIOYKsNdy5iH17DWZtS() ? 9 : 3);
						}
						goto IL_008d;
						IL_008d:
						_003C_003Eu__1 = default;
						num3 = 0;
						if (1 == 0)
						{
							goto IL_00a5;
						}
						goto IL_0150;
						end_IL_0064:;
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
		internal static TimeSpan A7vcGNsNqW0jqa1BVTmV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCogSocketAcq.HttpImageTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fBIOYKsNdy5iH17DWZtS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ii8HyFsNiJWgiVnk22Wq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct tA8SeiJ2NYDRBbHYQO : IAsyncStateMachine
		{
			public int BWwnUTlQip;

			public AsyncTaskMethodBuilder<Stream> SoBn0h10JC;

			public _003C_003Ec__DisplayClass3_0 tVAnw7ryQC;

			private TaskAwaiter<Stream> WyTnRSVTQW;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 5;
				int num2 = default;
				Stream result = default;
				_003C_003Ec__DisplayClass3_0 obj = default;
				while (true)
				{
					switch (num)
					{
					case 5:
						num2 = BWwnUTlQip;
						num = 0;
						break;
					default:
						SoBn0h10JC.SetResult(result);
						num = 6;
						break;
					case 0:
						obj = tVAnw7ryQC;
						KphMsssuuuYJEROQNFIM();
						num = (OEE8srsuIpd92Gv8hFhZ() ? 1 : 4);
						break;
					case 2:
					case 4:
						try
						{
							TaskAwaiter<Stream> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = obj._003C_003E4__this.MhmTTDpFli.MakeHttpGetRequest(obj.imageReference, obj.timeout).GetAwaiter();
								_ = 1;
								num3 = (OEE8srsuIpd92Gv8hFhZ() ? 7 : 2);
							}
							else
							{
								awaiter = WyTnRSVTQW;
								num3 = 4;
								if (1 == 0)
								{
									goto IL_017c;
								}
							}
							while (true)
							{
								switch (num3)
								{
								case 0:
								case 2:
									if (awaiter.IsCompleted)
									{
										break;
									}
									num3 = 6;
									if (KphMsssuuuYJEROQNFIM())
									{
										continue;
									}
									goto case 6;
								case 6:
									num2 = (BWwnUTlQip = 0);
									num3 = 5;
									continue;
								case 8:
									num2 = (BWwnUTlQip = -1);
									num3 = 9;
									continue;
								case 3:
								case 7:
									SoBn0h10JC.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 1;
									continue;
								case 4:
									WyTnRSVTQW = default;
									num3 = 8;
									continue;
								case 5:
									WyTnRSVTQW = awaiter;
									goto case 3;
								case 1:
									return;
								case 9:
									break;
								}
								break;
							}
							goto IL_017c;
							IL_017c:
							result = awaiter.GetResult();
						}
						catch (Exception exception)
						{
							BWwnUTlQip = -2;
							SoBn0h10JC.SetException(exception);
							return;
						}
						BWwnUTlQip = -2;
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
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				SoBn0h10JC.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool KphMsssuuuYJEROQNFIM()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool OEE8srsuIpd92Gv8hFhZ()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public RemoteImageService _003C_003E4__this;

		public string imageReference;

		public TimeSpan timeout;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass3_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			L8VSRqsNcn2HEUFRDA0Z();
			YZw9SpsN2bKAuJvx2XfK(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(tA8SeiJ2NYDRBbHYQO))]
		internal Task<Stream> _003CGet_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tA8SeiJ2NYDRBbHYQO stateMachine = default;
			stateMachine.SoBn0h10JC = AsyncTaskMethodBuilder<Stream>.Create();
			stateMachine.tVAnw7ryQC = this;
			stateMachine.BWwnUTlQip = -1;
			stateMachine.SoBn0h10JC.Start(ref stateMachine);
			return stateMachine.SoBn0h10JC.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void L8VSRqsNcn2HEUFRDA0Z()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YZw9SpsN2bKAuJvx2XfK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XSWHcpsNBYSQJdXk3chb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NbXuwvsNjj4Y82a7FTMC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly IRemoteDeviceApi MhmTTDpFli;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoteImageService(IRemoteDeviceApi source)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (w1Kr8rocKHanmcjx4xM())
		{
			goto IL_001e;
		}
		goto IL_0036;
		IL_001e:
		Npy4woo2ru73T8NbTtr(this);
		goto IL_0069;
		IL_0036:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				goto IL_0069;
			case 4:
				goto IL_007a;
			case 5:
				return;
			}
			break;
			IL_007a:
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			w1Kr8rocKHanmcjx4xM();
			if (!LfguorojEG6OBRjCt5w())
			{
				num = 0;
				if (LfguorojEG6OBRjCt5w())
				{
					continue;
				}
				goto IL_0069;
			}
			num = 3;
		}
		goto IL_001e;
		IL_0069:
		MhmTTDpFli = source;
		num = 5;
		goto IL_0036;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAsync_003Ed__2))]
	public override Task<Stream> GetAsync(string imageReference)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAsync_003Ed__2 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.imageReference = imageReference;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Stream Get(string imageReference)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass3_0 obj = new _003C_003Ec__DisplayClass3_0();
		obj._003C_003E4__this = this;
		obj.imageReference = imageReference;
		obj.timeout = d4D3CmoWDD2lv9vHWEm();
		return Task.Run([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass3_0.tA8SeiJ2NYDRBbHYQO))] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass3_0.tA8SeiJ2NYDRBbHYQO stateMachine = default;
			stateMachine.SoBn0h10JC = AsyncTaskMethodBuilder<Stream>.Create();
			stateMachine.tVAnw7ryQC = obj;
			stateMachine.BWwnUTlQip = -1;
			stateMachine.SoBn0h10JC.Start(ref stateMachine);
			return stateMachine.SoBn0h10JC.Task;
		}).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Npy4woo2ru73T8NbTtr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CognexRemoteServiceBase<Stream>)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LfguorojEG6OBRjCt5w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w1Kr8rocKHanmcjx4xM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan d4D3CmoWDD2lv9vHWEm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCogSocketAcq.HttpImageTimeout;
	}
}
