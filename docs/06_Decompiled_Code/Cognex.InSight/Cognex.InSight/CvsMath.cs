using System;
using System.Runtime.CompilerServices;

namespace Cognex.InSight;

public static class CvsMath
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double NormalizeDegrees(double degrees)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		degrees -= IJymsFHcv2crrCxwgb6(degrees / 360.0) * 360.0;
		return degrees;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static sbyte Clamp(sbyte value, sbyte min, sbyte max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vo5CBZHW7rW0dZhO0bu(min, McMD08H2KQURGlP09hI(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte Clamp(byte value, byte min, byte max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return WL5JANH71nqqJrngJ01(min, Math.Min(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static short Clamp(short value, short min, short max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xfIGKVHtUA4DSgNof5a(min, Math.Min(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ushort Clamp(ushort value, ushort min, ushort max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xicMXCHCb10HDdCkVBh(min, Math.Min(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int Clamp(int value, int min, int max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mkfWbUH5392xAREkRiq(min, UT64RCHK2jqK4cRC9xP(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint Clamp(uint value, uint min, uint max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return lF0Pl3HPOmbDeyGUQjL(min, oxwSIPHo5ikyQAbVd4F(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long Clamp(long value, long min, long max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PtP0IAHNOqH6nLsOUDg(min, e3D18GHYaLJ6o9k6wrD(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ulong Clamp(ulong value, ulong min, ulong max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return VPXwuDH1WmrsONXfTfy(min, nv37IuHxF01GKAAuxFK(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float Clamp(float value, float min, float max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RtuSgtH3ReqFHgQkibE(min, s131BfHr2y5aLSWEppC(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double Clamp(double value, double min, double max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(min, Math.Min(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static decimal Clamp(decimal value, decimal min, decimal max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return uI5kTrHMd0hhALXy5yF(min, KwWJdVHODsHaOKSb2WD(value, max));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (value.CompareTo(max) <= 0)
		{
			if (value.CompareTo(min) >= 0)
			{
				return value;
			}
			return min;
		}
		return max;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ToInt32(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MsRIqJHlbLD9FWoCJuf(Clamp(uc7cktHQAgkLHbmW5RC(value), -2147483648L, 2147483647L));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long ToInt64(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			return Ho9lCSHeit86KlEjKsH(value);
		}
		catch (OverflowException)
		{
			return long.MaxValue;
		}
		catch (Exception)
		{
			return 0L;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double ToDouble(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			return Convert.ToDouble(value);
		}
		catch (Exception)
		{
			return double.NaN;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AreEpsilonEqual(float v1, float v2, float epsilon)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vEbTmjHu2gNBOhiTTpT(v1 - v2) <= epsilon;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AreEpsilonEqual(double v1, double v2, double epsilon)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return w798HsHIVnGtKpeuGd4(v1 - v2) <= epsilon;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AreEpsilonEqual(decimal v1, decimal v2, decimal epsilon)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TD7kSpHaScXsr7tVgA1(aE7Vm6HR6lYIQVxriZh(v1 - v2), epsilon);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double IJymsFHcv2crrCxwgb6(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Floor(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mKsZohHB5j6jJDQuGfQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m0W9PcHjlEWHfgrVMtc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static sbyte McMD08H2KQURGlP09hI(sbyte P_0, sbyte P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static sbyte vo5CBZHW7rW0dZhO0bu(sbyte P_0, sbyte P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte WL5JANH71nqqJrngJ01(byte P_0, byte P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static short xfIGKVHtUA4DSgNof5a(short P_0, short P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort xicMXCHCb10HDdCkVBh(ushort P_0, ushort P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UT64RCHK2jqK4cRC9xP(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mkfWbUH5392xAREkRiq(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint oxwSIPHo5ikyQAbVd4F(uint P_0, uint P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint lF0Pl3HPOmbDeyGUQjL(uint P_0, uint P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long e3D18GHYaLJ6o9k6wrD(long P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long PtP0IAHNOqH6nLsOUDg(long P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong nv37IuHxF01GKAAuxFK(ulong P_0, ulong P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ulong VPXwuDH1WmrsONXfTfy(ulong P_0, ulong P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float s131BfHr2y5aLSWEppC(float P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float RtuSgtH3ReqFHgQkibE(float P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static decimal KwWJdVHODsHaOKSb2WD(decimal P_0, decimal P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static decimal uI5kTrHMd0hhALXy5yF(decimal P_0, decimal P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long uc7cktHQAgkLHbmW5RC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToInt64(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MsRIqJHlbLD9FWoCJuf(long P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long Ho9lCSHeit86KlEjKsH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt64(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float vEbTmjHu2gNBOhiTTpT(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double w798HsHIVnGtKpeuGd4(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static decimal aE7Vm6HR6lYIQVxriZh(decimal P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TD7kSpHaScXsr7tVgA1(decimal P_0, decimal P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 <= P_1;
	}
}
