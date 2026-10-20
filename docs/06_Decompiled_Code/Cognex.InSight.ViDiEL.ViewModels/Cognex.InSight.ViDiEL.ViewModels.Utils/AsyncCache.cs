using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Diagnostics.Logging;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Utils;

public sealed class AsyncCache<TKey, TResult> : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTryGetResultAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TResult> _003C_003Et__builder;

		public TKey key;

		public AsyncCache<TKey, TResult> _003C_003E4__this;

		public CancellationToken token;

		private TaskAwaiter<TResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			AsyncCache<TKey, TResult> asyncCache = default;
			int num2 = default;
			TResult result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					asyncCache = _003C_003E4__this;
					_ = 0;
					num = ((1 == 0) ? 4 : 5);
					continue;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 2:
				case 5:
					try
					{
						if (num2 != 0 && key == null)
						{
							throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(870));
						}
						try
						{
							TaskAwaiter<TResult> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = asyncCache.GetResultAsync(key, token).GetAwaiter();
								num3 = 0;
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
								case 1:
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									continue;
								case 6:
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 4:
									_003C_003Eu__1 = default;
									goto case 6;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 5;
									continue;
								case 5:
									return;
								case 7:
									num2 = (_003C_003E1__state = 0);
									_ = 0;
									num3 = (true ? 1 : 8);
									continue;
								case 0:
									if (!awaiter.IsCompleted)
									{
										num3 = 7;
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
						catch (Exception ex)
						{
							AsyncCache<TKey, TResult>.N83IR14Xa2.ErrorException(ex.Message, ex);
							goto IL_0196;
						}
						goto end_IL_0042;
						IL_0196:
						result = default;
						end_IL_0042:;
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
		internal static bool pg6jXTFeLwQByXliInj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dn1vTPFll4pjNv1ljca()
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
	private struct _003CGetResultAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TResult> _003C_003Et__builder;

		public TKey key;

		public AsyncCache<TKey, TResult> _003C_003E4__this;

		public CancellationToken token;

		private TaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			AsyncCache<TKey, TResult> asyncCache = default;
			TResult value = default;
			int num2 = default;
			TResult result = default;
			ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter awaiter2 = default;
			ConfiguredTaskAwaitable<TResult> configuredTaskAwaitable = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((1 == 0) ? 3 : 5);
					continue;
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00e2;
						}
						if (num2 == 1)
						{
							goto IL_00ea;
						}
						if (key == null)
						{
							throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(870));
						}
						if (!asyncCache.pJaI8PAxPv.TryGetValue(key, out value))
						{
							awaiter = asyncCache.ULDIE8EBNA.WaitAsync(token).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00e2;
						}
						result = value;
						goto end_IL_0031;
						IL_00ea:
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 8;
							}
							else
							{
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 9;
							}
							while (true)
							{
								switch (num3)
								{
								case 10:
									_003C_003Eu__2 = awaiter2;
									num3 = 5;
									continue;
								case 3:
									awaiter2 = configuredTaskAwaitable.GetAwaiter();
									_ = 0;
									num3 = ((1 == 0) ? 13 : 6);
									continue;
								case 12:
									break;
								case 7:
									return;
								case 4:
								case 6:
									if (!awaiter2.IsCompleted)
									{
										num3 = 0;
										continue;
									}
									goto case 2;
								case 9:
									num2 = (_003C_003E1__state = -1);
									num3 = 2;
									continue;
								case 11:
								case 13:
									asyncCache.pJaI8PAxPv[key] = value;
									num3 = 14;
									continue;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 7;
									continue;
								case 1:
									configuredTaskAwaitable = asyncCache.xPoI15WOhi(key, token).ConfigureAwait(continueOnCapturedContext: false);
									num3 = 3;
									continue;
								case 2:
									value = awaiter2.GetResult();
									goto case 11;
								case 8:
									if (!asyncCache.pJaI8PAxPv.TryGetValue(key, out value))
									{
										token.ThrowIfCancellationRequested();
										num3 = 1;
									}
									else
									{
										result = value;
										num3 = 12;
									}
									continue;
								case 0:
									num2 = (_003C_003E1__state = 1);
									goto case 10;
								default:
									num3 = 10;
									continue;
								case 14:
									result = value;
									break;
								}
								break;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								asyncCache.ULDIE8EBNA.Release();
							}
						}
						goto end_IL_0031;
						IL_00e2:
						awaiter.GetResult();
						goto IL_00ea;
						end_IL_0031:;
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
				case 4:
					break;
				case 1:
				case 5:
					asyncCache = _003C_003E4__this;
					goto case 2;
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
		internal static bool vqAxjRF7QMB9Z5jWBo4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aABIK8FyhF347ow4lxb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger N83IR14Xa2;

	private readonly SemaphoreSlim ULDIE8EBNA;

	private readonly ConcurrentDictionary<TKey, TResult> pJaI8PAxPv;

	private readonly Func<TKey, CancellationToken, Task<TResult>> xPoI15WOhi;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncCache(Func<TKey, CancellationToken, Task<TResult>> fetchFunc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		ULDIE8EBNA = new SemaphoreSlim(1);
		pJaI8PAxPv = new ConcurrentDictionary<TKey, TResult>();
		base._002Ector();
		xPoI15WOhi = fetchFunc ?? throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(848));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(AsyncCache<, >._003CTryGetResultAsync_003Ed__5))]
	public Task<TResult> TryGetResultAsync(TKey key, CancellationToken token = default(CancellationToken))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CTryGetResultAsync_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.key = key;
		stateMachine.token = token;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(AsyncCache<, >._003CGetResultAsync_003Ed__6))]
	public Task<TResult> GetResultAsync(TKey key, CancellationToken token = default(CancellationToken))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetResultAsync_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.key = key;
		stateMachine.token = token;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pJaI8PAxPv.Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(TKey key)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (key == null)
		{
			throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(870));
		}
		TResult value;
		return pJaI8PAxPv.TryRemove(key, out value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pJaI8PAxPv.Clear();
		ULDIE8EBNA.Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AsyncCache()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		N83IR14Xa2 = LogManager.GetLogger(typeof(AsyncCache<TKey, TResult>));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w3fUGaXuJwSXJIW9UDr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UvMyQ2XBoyZ6OZePsKI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
