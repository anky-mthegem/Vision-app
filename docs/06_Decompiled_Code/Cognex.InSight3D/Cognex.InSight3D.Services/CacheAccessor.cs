using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using GHWKpuG7rE0PZAeeF5;

namespace Cognex.InSight3D.Services;

public class CacheAccessor : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBuildCacheAccessorAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CacheAccessor> _003C_003Et__builder;

		public string baseUrl;

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
			if (OpoNyO4chLwP6i9PIK6())
			{
				num = 4;
				if (T8aw4F4UulctRmOteO5())
				{
				}
			}
			else
			{
				num = 3;
			}
			int num2 = default;
			CacheAccessor result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = TsMxWL4ZUVkHa89jn2i(onPnmX4vcJp5bAkKa8b(bJ8baIJu1));
							num3 = 8;
							goto IL_010f;
						}
						awaiter = _003C_003Eu__1;
						goto IL_009d;
						IL_009d:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_010f;
						IL_010f:
						while (true)
						{
							switch (num3)
							{
							case 4:
							case 7:
								return;
							case 3:
							case 5:
								break;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 6;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 1;
								if (T8aw4F4UulctRmOteO5())
								{
									num3 = 3;
									if (T8aw4F4UulctRmOteO5())
									{
									}
								}
								else
								{
									num3 = 7;
								}
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 6:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 10:
								result = new CacheAccessor(baseUrl);
								goto end_IL_010f;
							}
							goto IL_009d;
							continue;
							end_IL_010f:
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
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 5;
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
		internal static object onPnmX4vcJp5bAkKa8b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SemaphoreSlim)P_0).WaitAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter TsMxWL4ZUVkHa89jn2i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OpoNyO4chLwP6i9PIK6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T8aw4F4UulctRmOteO5()
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
	private struct _003CClearCache_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			do
			{
				IL_01ac:
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					if (e7Ju0H4iTkGZkAWFGZx())
					{
						num = 4;
						goto IL_01ac;
					}
					num = 3;
					if (true)
					{
						goto IL_01ac;
					}
					break;
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = iRIN8L4fCahRP0KIjak(g1fJwB4qTBVRFvAdKtF(bJ8baIJu1));
							_ = 1;
							num3 = (Px23pJ4T5MtXZjucesG() ? 5 : 9);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (false)
							{
								goto IL_00cb;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto IL_006a;
							case 5:
							case 7:
								jyvL9rBcr.Clear();
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (!Px23pJ4T5MtXZjucesG())
								{
									continue;
								}
								return;
							case 1:
								return;
							case 3:
								break;
							default:
								num3 = 1;
								if (!Px23pJ4T5MtXZjucesG())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 9:
								if (awaiter.IsCompleted)
								{
									goto IL_006a;
								}
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 10:
								{
									J9a0dB4GTUd7dJlMqtd(bJ8baIJu1);
									goto end_IL_00eb;
								}
								IL_006a:
								awaiter.GetResult();
								goto case 5;
							}
							goto IL_00cb;
							continue;
							end_IL_00eb:
							break;
						}
						goto end_IL_0035;
						IL_00cb:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0035:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 5;
			}
			while (e7Ju0H4iTkGZkAWFGZx());
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
		internal static object g1fJwB4qTBVRFvAdKtF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SemaphoreSlim)P_0).WaitAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter iRIN8L4fCahRP0KIjak(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int J9a0dB4GTUd7dJlMqtd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SemaphoreSlim)P_0).Release();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e7Ju0H4iTkGZkAWFGZx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Px23pJ4T5MtXZjucesG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly uint i98gwJxep;

	private static readonly LinkedList<Tuple<string, IDownloadedData>> jyvL9rBcr;

	private static readonly SemaphoreSlim bJ8baIJu1;

	private readonly string ousSJp1F8;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CacheAccessor(string baseUrl)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TKy100ax2KSUgvqCyh();
		int num = ((!U6iMrROtlNlCv37wvA()) ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector();
				goto case 4;
			default:
				num = 4;
				if (U6iMrROtlNlCv37wvA())
				{
					break;
				}
				goto case 4;
			case 4:
				ousSJp1F8 = baseUrl;
				num = 5;
				if (U6iMrROtlNlCv37wvA())
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddData(IDownloadedData data)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TKy100ax2KSUgvqCyh();
		int num = (U6iMrROtlNlCv37wvA() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				ICxEZ3j3eid5mF8YFi(jyvL9rBcr);
				num = 5;
				break;
			case 0:
			case 1:
				jyvL9rBcr.AddFirst(new Tuple<string, IDownloadedData>(ousSJp1F8, data));
				num = 3;
				break;
			case 3:
				if (J9jtkpCkdXMUKxfy4B(jyvL9rBcr) > i98gwJxep)
				{
					goto default;
				}
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IDownloadedData GetData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jyvL9rBcr.AsEnumerable().FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (Tuple<string, IDownloadedData> P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.Item1 == ousSJp1F8;
		})?.Item2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CBuildCacheAccessorAsync_003Ed__7))]
	public static Task<CacheAccessor> BuildCacheAccessorAsync(string baseUrl)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CBuildCacheAccessorAsync_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CacheAccessor>.Create();
		stateMachine.baseUrl = baseUrl;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClearCache_003Ed__8))]
	public static Task ClearCache()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (U6iMrROtlNlCv37wvA())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_0042;
			}
		}
		goto IL_0074;
		IL_0074:
		_003CClearCache_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AdnftltKpwknHAniJE();
				goto case 1;
			case 3:
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				goto IL_0091;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0091:
			num = 3;
		}
		goto IL_0042;
		IL_0042:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EeXBApHtsgYqAq1ZKe(bJ8baIJu1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CacheAccessor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (TKy100ax2KSUgvqCyh() ? 2 : 5);
		while (true)
		{
			switch (num)
			{
			case 3:
				jyvL9rBcr = new LinkedList<Tuple<string, IDownloadedData>>();
				goto case 4;
			default:
				num = 4;
				continue;
			case 4:
				bJ8baIJu1 = new SemaphoreSlim(1);
				num = 6;
				continue;
			case 0:
			case 5:
				KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
				break;
			case 1:
			case 2:
				break;
			case 6:
				return;
			}
			i98gwJxep = 2u;
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool SaqtqCToS(Tuple<string, IDownloadedData> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.Item1 == ousSJp1F8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool U6iMrROtlNlCv37wvA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TKy100ax2KSUgvqCyh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int J9jtkpCkdXMUKxfy4B(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LinkedList<Tuple<string, IDownloadedData>>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ICxEZ3j3eid5mF8YFi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((LinkedList<Tuple<string, IDownloadedData>>)P_0).RemoveLast();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder AdnftltKpwknHAniJE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EeXBApHtsgYqAq1ZKe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SemaphoreSlim)P_0).Release();
	}
}
