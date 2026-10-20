using System;
using System.Runtime.CompilerServices;
using System.Threading;
using yFqFqrNb1tZ9uvfT9p;

namespace Cognex.Remoting.CogSocket;

public struct RequestOptions
{
	private TimeSpan? yfWiOkhJZy;

	[CompilerGenerated]
	private CancellationToken KQUiopjf7l;

	public CancellationToken CancellationToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KQUiopjf7l;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KQUiopjf7l = value;
		}
	}

	public TimeSpan? ResponseTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yfWiOkhJZy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (value == Timeout.InfiniteTimeSpan || !value.HasValue)
			{
				yfWiOkhJZy = null;
				return;
			}
			if (value.Value.TotalMilliseconds <= 0.0)
			{
				throw new ArgumentOutOfRangeException(UNkfE94JEjYP98PsqC.cGFu3AUnFy(1516), UNkfE94JEjYP98PsqC.cGFu3AUnFy(1530));
			}
			yfWiOkhJZy = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Y935qcDFplmtxhohGkK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B6LMufDPHB1kFB5w9Wh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
