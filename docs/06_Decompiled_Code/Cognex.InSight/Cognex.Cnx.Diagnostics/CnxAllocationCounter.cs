using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using btFy13pd5uf4WC4h18;

namespace Cognex.Cnx.Diagnostics;

public struct CnxAllocationCounter
{
	private int lRAImrwZnB;

	private int Tf5InbaYoO;

	public int Allocated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lRAImrwZnB;
		}
	}

	public int Freed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Tf5InbaYoO;
		}
	}

	public int InUse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lRAImrwZnB - Tf5InbaYoO;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxAllocationCounter operator +(CnxAllocationCounter a, CnxAllocationCounter b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!BPIxe0hzfnviPyhiT4D()) ? 3 : 4);
		CnxAllocationCounter result = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				result.Tf5InbaYoO = a.Tf5InbaYoO + b.Tf5InbaYoO;
				num = 5;
				break;
			case 0:
			case 4:
				result = default;
				goto case 1;
			case 1:
			case 3:
				result.lRAImrwZnB = a.lRAImrwZnB + b.lRAImrwZnB;
				goto case 2;
			default:
				num = 2;
				break;
			case 5:
				return result;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxAllocationCounter operator -(CnxAllocationCounter a, CnxAllocationCounter b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (BPIxe0hzfnviPyhiT4D())
		{
			num = 4;
			if (!BPIxe0hzfnviPyhiT4D())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0068;
		IL_002a:
		CnxAllocationCounter result = default;
		goto IL_0042;
		IL_00af:
		return result;
		IL_0042:
		result.lRAImrwZnB = a.lRAImrwZnB - b.lRAImrwZnB;
		goto IL_008f;
		IL_0068:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 3:
				goto IL_0042;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_008f;
			case 5:
				goto IL_00af;
			}
			break;
		}
		goto IL_002a;
		IL_008f:
		result.Tf5InbaYoO = a.Tf5InbaYoO - b.Tf5InbaYoO;
		num = 5;
		if (true)
		{
			goto IL_0068;
		}
		goto IL_00af;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)qJRemJLh7GMIf66TA4k(new string[6]
		{
			(string)I5x5aKLsXRE2rmh3J0Z(1240),
			Allocated.ToString(),
			(string)I5x5aKLsXRE2rmh3J0Z(1264),
			Freed.ToString(),
			(string)I5x5aKLsXRE2rmh3J0Z(1282),
			InUse.ToString()
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("DEBUG")]
	public void OnAllocated()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!lqnfuaLwQKrJbwUJued())
		{
			num = 2;
			if (lqnfuaLwQKrJbwUJued())
			{
			}
		}
		else
		{
			num = 3;
		}
		Type obj = default;
		bool lockTaken = default;
		do
		{
			switch (num)
			{
			case 0:
			case 2:
				obj = jWl2g4LLMYfe4Gi9sBD(typeof(CnxAllocationCounter).TypeHandle);
				goto case 1;
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_0076;
			case 4:
				break;
			}
			break;
			IL_0076:
			num = 4;
		}
		while (true);
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			lRAImrwZnB++;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("DEBUG")]
	public void OnAllocated(int count)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!lqnfuaLwQKrJbwUJued())
		{
			num = 2;
			if (!BPIxe0hzfnviPyhiT4D())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		Type typeFromHandle = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 2:
				typeFromHandle = typeof(CnxAllocationCounter);
				break;
			case 4:
				goto IL_007c;
			}
			break;
		}
		goto IL_002a;
		IL_007c:
		bool lockTaken = default;
		try
		{
			Monitor.Enter(typeFromHandle, ref lockTaken);
			lRAImrwZnB += count;
			return;
		}
		finally
		{
			if (lockTaken)
			{
				BCfEY8L9Gu5vqScDUA8(typeFromHandle);
			}
		}
		IL_002a:
		lockTaken = false;
		goto IL_007c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("DEBUG")]
	public void OnAllocated(IntPtr h)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		Type typeFromHandle = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (KRgB6xLS7WPf1dbGGvT(h, IntPtr.Zero))
				{
					BPIxe0hzfnviPyhiT4D();
					num = (lqnfuaLwQKrJbwUJued() ? 3 : 0);
					break;
				}
				return;
			case 0:
			case 1:
				typeFromHandle = typeof(CnxAllocationCounter);
				goto default;
			default:
				lockTaken = false;
				num = 5;
				break;
			case 5:
				try
				{
					Monitor.Enter(typeFromHandle, ref lockTaken);
					lRAImrwZnB++;
					return;
				}
				finally
				{
					if (lockTaken)
					{
						BCfEY8L9Gu5vqScDUA8(typeFromHandle);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("DEBUG")]
	public void OnFreed()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lqnfuaLwQKrJbwUJued();
		int num;
		if (BPIxe0hzfnviPyhiT4D())
		{
			num = 3;
			if (!BPIxe0hzfnviPyhiT4D())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
			if (lqnfuaLwQKrJbwUJued())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				goto IL_0053;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_008a;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		Type type = jWl2g4LLMYfe4Gi9sBD(typeof(CnxAllocationCounter).TypeHandle);
		goto IL_0053;
		IL_0053:
		bool lockTaken = false;
		goto IL_008a;
		IL_008a:
		try
		{
			Monitor.Enter(type, ref lockTaken);
			Tf5InbaYoO++;
		}
		finally
		{
			if (lockTaken)
			{
				BCfEY8L9Gu5vqScDUA8(type);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("DEBUG")]
	public void OnFreed(int count)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!BPIxe0hzfnviPyhiT4D()) ? 3 : 2);
		Type type = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				type = jWl2g4LLMYfe4Gi9sBD(typeof(CnxAllocationCounter).TypeHandle);
				goto case 1;
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_006c;
			case 4:
				break;
			}
			break;
			IL_006c:
			num = 4;
		}
		try
		{
			Monitor.Enter(type, ref lockTaken);
			Tf5InbaYoO += count;
		}
		finally
		{
			if (lockTaken)
			{
				BCfEY8L9Gu5vqScDUA8(type);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("DEBUG")]
	public void OnFreed(IntPtr h)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (lqnfuaLwQKrJbwUJued() ? 4 : 3);
		Type type = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				type = jWl2g4LLMYfe4Gi9sBD(typeof(CnxAllocationCounter).TypeHandle);
				goto default;
			case 0:
			case 3:
				if (KRgB6xLS7WPf1dbGGvT(h, IntPtr.Zero))
				{
					num = 1;
					break;
				}
				return;
			default:
				lockTaken = false;
				num = 5;
				if (lqnfuaLwQKrJbwUJued())
				{
				}
				break;
			case 5:
				try
				{
					Monitor.Enter(type, ref lockTaken);
					Tf5InbaYoO++;
					return;
				}
				finally
				{
					if (lockTaken)
					{
						BCfEY8L9Gu5vqScDUA8(type);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BPIxe0hzfnviPyhiT4D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lqnfuaLwQKrJbwUJued()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I5x5aKLsXRE2rmh3J0Z(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qJRemJLh7GMIf66TA4k(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type jWl2g4LLMYfe4Gi9sBD(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BCfEY8L9Gu5vqScDUA8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KRgB6xLS7WPf1dbGGvT(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}
}
