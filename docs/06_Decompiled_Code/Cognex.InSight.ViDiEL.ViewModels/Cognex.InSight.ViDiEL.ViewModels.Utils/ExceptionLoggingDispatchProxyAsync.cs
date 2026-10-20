using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Diagnostics.Logging;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Utils;

public class ExceptionLoggingDispatchProxyAsync : DispatchProxyAsync, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInvokeAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MethodInfo method;

		public ExceptionLoggingDispatchProxyAsync _003C_003E4__this;

		public object[] args;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!PPICGlFn3BPO7pDdEVE()) ? 3 : 4);
			int num2 = default;
			ExceptionLoggingDispatchProxyAsync exceptionLoggingDispatchProxyAsync = default;
			Task task = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					exceptionLoggingDispatchProxyAsync = _003C_003E4__this;
					goto case 2;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (PPICGlFn3BPO7pDdEVE())
					{
						break;
					}
					goto case 2;
				case 2:
				case 3:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								task = wtJg8rFzyiHkeDgPZU3(method, exceptionLoggingDispatchProxyAsync.acjIPIym08, args) as Task;
								num3 = 7;
								goto IL_00e5;
							}
							awaiter = _003C_003Eu__1;
							goto IL_0097;
							IL_0097:
							_003C_003Eu__1 = default;
							num3 = 8;
							goto IL_00e5;
							IL_00e5:
							while (true)
							{
								switch (num3)
								{
								case 4:
								case 6:
									break;
								case 2:
								case 5:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 3;
										continue;
									}
									goto case 10;
								case 3:
									_003C_003Eu__1 = awaiter;
									goto case 9;
								default:
									num3 = 9;
									continue;
								case 7:
									if (task != null)
									{
										num3 = 0;
										continue;
									}
									goto end_IL_00e5;
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 0:
									awaiter = RMhLPXs23b13kuD0Gs4(task);
									PPICGlFn3BPO7pDdEVE();
									num3 = (jG1BseFfKx1CGyDkF2s() ? 4 : 5);
									continue;
								case 1:
									return;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 1;
									if (PPICGlFn3BPO7pDdEVE())
									{
										continue;
									}
									goto case 10;
								case 10:
									awaiter.GetResult();
									goto end_IL_00e5;
								}
								goto IL_0097;
								continue;
								end_IL_00e5:
								break;
							}
						}
						catch (Exception ex)
						{
							AYOxJysXG6WFQrLkSjl(ex);
							throw;
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
		internal static object wtJg8rFzyiHkeDgPZU3(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter RMhLPXs23b13kuD0Gs4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AYOxJysXG6WFQrLkSjl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rQNID7InW3((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PPICGlFn3BPO7pDdEVE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jG1BseFfKx1CGyDkF2s()
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
	private struct _003CInvokeAsyncT_003Ed__5<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public MethodInfo method;

		public ExceptionLoggingDispatchProxyAsync _003C_003E4__this;

		public object[] args;

		private TaskAwaiter<T> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			Task<T> task = default;
			ExceptionLoggingDispatchProxyAsync exceptionLoggingDispatchProxyAsync = default;
			TaskAwaiter<T> awaiter = default;
			T result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								task = method.Invoke(exceptionLoggingDispatchProxyAsync.acjIPIym08, args) as Task<T>;
								num3 = 0;
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
									if (task != null)
									{
										num3 = 6;
										continue;
									}
									result = default;
									break;
								default:
									return;
								case 8:
									return;
								case 7:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 9:
									result = awaiter.GetResult();
									num3 = 11;
									continue;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 1:
									_003C_003Eu__1 = default;
									num3 = 2;
									continue;
								case 4:
									if (!awaiter.IsCompleted)
									{
										_ = 0;
										num3 = (true ? 10 : 8);
										continue;
									}
									goto case 9;
								case 6:
									awaiter = task.GetAwaiter();
									num3 = 4;
									continue;
								case 3:
								case 10:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 11:
									break;
								}
								break;
							}
						}
						catch (Exception ex)
						{
							rQNID7InW3(ex);
							throw;
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
				case 1:
					exceptionLoggingDispatchProxyAsync = _003C_003E4__this;
					_ = 0;
					num = (true ? 4 : 0);
					continue;
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
		internal static bool M8tSSksMsSVEBIPe0P2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool beubtmskiwbrRkGvA2W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger cCOIjdhV8L;

	private object acjIPIym08;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Create<T>(T target)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object obj = DispatchProxyAsync.Create<T, ExceptionLoggingDispatchProxyAsync>();
		((ExceptionLoggingDispatchProxyAsync)obj).acjIPIym08 = target;
		return (T)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object Invoke(MethodInfo method, object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			return method.Invoke(acjIPIym08, args);
		}
		catch (Exception ex)
		{
			XhdoIXXU1sBrrBFsC9G(ex);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__4))]
	public override Task InvokeAsync(MethodInfo method, object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!cQHG3jXhdwJjsb8w8L7())
		{
			num = 5;
			if (!SXEStnXx5C5nKHIc77L())
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
		_003CInvokeAsync_003Ed__4 stateMachine = default;
		stateMachine.method = method;
		num = 3;
		goto IL_0056;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 3:
				stateMachine.args = args;
				goto case 7;
			default:
				num = 7;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = blsf3yXQRLGdmVSN66j();
				goto case 1;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (SXEStnXx5C5nKHIc77L())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (!cQHG3jXhdwJjsb8w8L7())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				if (true)
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
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInvokeAsyncT_003Ed__5<>))]
	public override Task<T> InvokeAsyncT<T>(MethodInfo method, object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CInvokeAsyncT_003Ed__5<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.method = method;
		stateMachine.args = args;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void rQNID7InW3(Exception P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		TargetInvocationException ex = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				NTNKcGXiglRSmEMWiW7(cCOIjdhV8L, GqHswCXVjIoaZFeAES9(P_0), P_0);
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				ex = P_0 as TargetInvocationException;
				num = 6;
				continue;
			case 2:
			case 3:
				P_0 = (Exception)sVIe0eXq7PQu8MGFl6H(ex);
				goto case 4;
			case 6:
				if (ex != null)
				{
					num = 0;
					continue;
				}
				goto case 4;
			case 0:
				if (sVIe0eXq7PQu8MGFl6H(ex) != null)
				{
					break;
				}
				goto case 4;
			case 7:
				return;
			}
			SXEStnXx5C5nKHIc77L();
			num = ((!cQHG3jXhdwJjsb8w8L7()) ? 2 : 5);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!cQHG3jXhdwJjsb8w8L7()) ? 1 : 3);
		IDisposable disposable = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (disposable != null)
				{
					goto default;
				}
				return;
			case 0:
			case 1:
				disposable = acjIPIym08 as IDisposable;
				num = 4;
				if (cQHG3jXhdwJjsb8w8L7())
				{
				}
				break;
			default:
				vFLipQXLeHGScuGDHhY(disposable);
				num = 5;
				if (1 == 0)
				{
					return;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExceptionLoggingDispatchProxyAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iBW1rTXttg9Gn5rCMFT();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionLoggingDispatchProxyAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iBW1rTXttg9Gn5rCMFT();
		cCOIjdhV8L = LogManager.GetLogger<ExceptionLoggingDispatchProxyAsync>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XhdoIXXU1sBrrBFsC9G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rQNID7InW3((Exception)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SXEStnXx5C5nKHIc77L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cQHG3jXhdwJjsb8w8L7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder blsf3yXQRLGdmVSN66j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sVIe0eXq7PQu8MGFl6H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).InnerException;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GqHswCXVjIoaZFeAES9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NTNKcGXiglRSmEMWiW7(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vFLipQXLeHGScuGDHhY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iBW1rTXttg9Gn5rCMFT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}
}
