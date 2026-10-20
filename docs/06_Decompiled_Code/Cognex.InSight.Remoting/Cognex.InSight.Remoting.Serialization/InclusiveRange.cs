using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsChildSerializable]
public class InclusiveRange<T> where T : IComparable<T>
{
	[CompilerGenerated]
	private readonly T DXoyFOhhaq;

	[CompilerGenerated]
	private readonly T PwfyC4QV1T;

	public T Minimum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DXoyFOhhaq;
		}
	}

	public T Maximum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PwfyC4QV1T;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InclusiveRange(T minimum, T maximum)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
		DXoyFOhhaq = minimum;
		PwfyC4QV1T = maximum;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValid(T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		T minimum = Minimum;
		if (value.CompareTo(minimum) >= 0)
		{
			T maximum = Maximum;
			return value.CompareTo(maximum) <= 0;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Clamp(T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		T minimum = Minimum;
		if (value.CompareTo(minimum) < 0)
		{
			return Minimum;
		}
		T maximum = Maximum;
		if (value.CompareTo(maximum) > 0)
		{
			return Maximum;
		}
		return value;
	}
}
