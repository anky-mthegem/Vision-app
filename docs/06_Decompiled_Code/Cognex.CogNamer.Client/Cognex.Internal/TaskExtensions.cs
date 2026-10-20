using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cognex.Internal;

public static class TaskExtensions
{
	public static async Task WithWaitCancellation(this Task task, CancellationToken cancellationToken, TimeSpan? timeout = null)
	{
		if (cancellationToken.CanBeCanceled)
		{
			cancellationToken.ThrowIfCancellationRequested();
			TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
			using CancellationTokenSource cancelTimeout = (timeout.HasValue ? new CancellationTokenSource(timeout.Value) : new CancellationTokenSource());
			using (cancelTimeout.Token.Register((object s) =>
			{
				((TaskCompletionSource<bool>)s).TrySetResult(result: true);
			}, taskCompletionSource))
			{
				using (cancellationToken.Register((object s) =>
				{
					((TaskCompletionSource<bool>)s).TrySetResult(result: true);
				}, taskCompletionSource))
				{
					if (task != await Task.WhenAny(task, taskCompletionSource.Task))
					{
						throw new OperationCanceledException(cancellationToken.IsCancellationRequested ? cancellationToken : default(CancellationToken));
					}
				}
			}
		}
		await task;
	}

	public static async Task<T> WithWaitCancellation<T>(this Task<T> task, CancellationToken cancellationToken, TimeSpan? timeout = null)
	{
		if (cancellationToken.CanBeCanceled)
		{
			cancellationToken.ThrowIfCancellationRequested();
			TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
			using CancellationTokenSource cancelTimeout = (timeout.HasValue ? new CancellationTokenSource(timeout.Value) : new CancellationTokenSource());
			using (cancelTimeout.Token.Register((object s) =>
			{
				((TaskCompletionSource<bool>)s).TrySetResult(result: true);
			}, taskCompletionSource))
			{
				using (cancellationToken.Register((object s) =>
				{
					((TaskCompletionSource<bool>)s).TrySetResult(result: true);
				}, taskCompletionSource))
				{
					if (task != await Task.WhenAny(task, taskCompletionSource.Task))
					{
						throw new OperationCanceledException(cancellationToken.IsCancellationRequested ? cancellationToken : default(CancellationToken));
					}
				}
			}
		}
		return await task;
	}

	public static async Task<bool> WasDelayCancelled(this Task task)
	{
		try
		{
			await task;
			return false;
		}
		catch (TaskCanceledException)
		{
			return true;
		}
	}
}
