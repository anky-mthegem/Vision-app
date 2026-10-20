using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GHWKpuG7rE0PZAeeF5;

namespace Cognex.InSight3D.Acquistion;

public class DownloadCache<T> where T : class
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public string key;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass3_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CTryGet_003Eb__0(Tuple<string, T> t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t.Item1 == key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D4ORmbec9b3HYCaar18()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YevkB4eUZ5Jodos5M24()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public string key;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass4_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CAdd_003Eb__0(Tuple<string, T> t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t.Item1 == key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yJX4cGevCD3jprClEgh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CmkNIGeZ5VZLO0iiXa6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly uint zN67KHnxB;

	private readonly LinkedList<Tuple<string, T>> zUiNJutAv;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DownloadCache(uint size)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (true ? 1 : 5);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
				num = 2;
				continue;
			case 4:
				base._002Ector();
				break;
			case 2:
				zUiNJutAv = new LinkedList<Tuple<string, T>>();
				num = 4;
				continue;
			case 6:
				return;
			}
			zN67KHnxB = size;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGet(string key, out T data)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals2.key = key;
		Tuple<string, T> tuple = zUiNJutAv.AsEnumerable().FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (Tuple<string, T> t) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t.Item1 == CS_0024_003C_003E8__locals2.key;
		});
		data = ((tuple != null) ? tuple.Item2 : null);
		return data != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string key, T data)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals3.key = key;
		Tuple<string, T> tuple = zUiNJutAv.AsEnumerable().FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (Tuple<string, T> t) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t.Item1 == CS_0024_003C_003E8__locals3.key;
		});
		if (tuple != null)
		{
			zUiNJutAv.Remove(tuple);
		}
		zUiNJutAv.AddFirst(new Tuple<string, T>(CS_0024_003C_003E8__locals3.key, data));
		if (zUiNJutAv.Count > zN67KHnxB)
		{
			zUiNJutAv.RemoveLast();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qIhSfy4xmpJCXtF3vLl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QJ02LJ4Nh4fTukYyk6Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
