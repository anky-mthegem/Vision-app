using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.VisionBuilder.Types;

namespace Cognex.InSight.VisionBuilder.Extensions;

public static class ToolchainApiExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadToolChainAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public byte[] toolchainArchive;

		public IToolchainApi api;

		private MemoryStream _003Cstream_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bxNCKGsid4bwUu5HkYRg();
			int num;
			if (!lRcAccsiiSGVPLRos6wp())
			{
				num = 2;
				if (!bxNCKGsid4bwUu5HkYRg())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_01d0;
			IL_002e:
			_003C_003Et__builder.SetResult();
			num = 5;
			goto IL_01d0;
			IL_01d0:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 3:
					try
					{
						if (num2 != 0)
						{
							_003Cstream_003E5__2 = new MemoryStream(toolchainArchive);
						}
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = ((Task)CUP7rVsiqSGIHW8s5Nqw(api, _003Cstream_003E5__2)).GetAwaiter();
								_ = 1;
								if (!lRcAccsiiSGVPLRos6wp())
								{
									num3 = 5;
								}
								else
								{
									num3 = 7;
									if (false)
									{
										goto IL_00e8;
									}
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 8;
							}
							goto IL_0119;
							IL_0119:
							while (true)
							{
								switch (num3)
								{
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 8:
									_003C_003Eu__1 = default;
									num3 = 6;
									continue;
								case 0:
								case 5:
									if (!awaiter.IsCompleted)
									{
										num3 = 4;
										continue;
									}
									goto case 9;
								case 4:
									num2 = (_003C_003E1__state = 0);
									break;
								case 2:
								case 7:
									break;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 3;
									continue;
								case 3:
									return;
								case 9:
									awaiter.GetResult();
									goto end_IL_0119;
								}
								goto IL_00e8;
								continue;
								end_IL_0119:
								break;
							}
							goto end_IL_005b;
							IL_00e8:
							_003C_003Eu__1 = awaiter;
							num3 = 1;
							goto IL_0119;
							end_IL_005b:;
						}
						finally
						{
							if (num2 < 0 && _003Cstream_003E5__2 != null)
							{
								((IDisposable)_003Cstream_003E5__2).Dispose();
							}
						}
						_003Cstream_003E5__2 = null;
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
					if (bxNCKGsid4bwUu5HkYRg())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					return;
				}
				break;
			}
			goto IL_002e;
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
		internal static object CUP7rVsiqSGIHW8s5Nqw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IToolchainApi)P_0).LoadToolChainAsync((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bxNCKGsid4bwUu5HkYRg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lRcAccsiiSGVPLRos6wp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadToolChainAsync_003Ed__0))]
	public static Task LoadToolChainAsync(this IToolchainApi api, byte[] toolchainArchive)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CLoadToolChainAsync_003Ed__0 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine.api = api;
				_ = 1;
				num = (pZghkI2Sff1nNpXBQD8() ? 5 : 0);
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 0:
			case 2:
				stateMachine.toolchainArchive = toolchainArchive;
				goto case 6;
			default:
				num = 6;
				if (true)
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
	internal static bool EwpTdA299KHyHqH3HK2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pZghkI2Sff1nNpXBQD8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
