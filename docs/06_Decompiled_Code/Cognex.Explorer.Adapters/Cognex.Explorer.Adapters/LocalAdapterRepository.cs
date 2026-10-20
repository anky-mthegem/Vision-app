using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cognex.Dependency;
using Cognex.Explorer.Adapters.Internal;
using NLog;
using b4Zxkh9w1NDrmwo2EQ;
using pthEIVC1aCm1sfNHFV;

namespace Cognex.Explorer.Adapters;

public sealed class LocalAdapterRepository : IAdapterRepository
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public IAdapter ur7uvHYVg;

		private static _003C_003Ec__DisplayClass22_0 d8tgquRjt9hIXKBZJb;

		public _003C_003Ec__DisplayClass22_0()
		{
			Ep2poGZmeZGAKMIuHs();
			base._002Ector();
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal bool mhkByOcce(AdapterInfo a)
		{
			return xdEpZR5anGRrA83aj6j(bS9wvyoV8r8BpgTMYa(a), guJcC6zIBQcFSfMpKO(ur7uvHYVg));
		}

		internal static void Ep2poGZmeZGAKMIuHs()
		{
			YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
		}

		internal static bool P5I5gGCQMs3hYR8UxB()
		{
			return d8tgquRjt9hIXKBZJb == null;
		}

		internal static _003C_003Ec__DisplayClass22_0 iwEKYrINOsm0w0y5Io()
		{
			return d8tgquRjt9hIXKBZJb;
		}

		internal static object bS9wvyoV8r8BpgTMYa(object P_0)
		{
			return ((AdapterInfo)P_0).AdapterGroup;
		}

		internal static object guJcC6zIBQcFSfMpKO(object P_0)
		{
			return ((IAdapter)P_0).AdapterGroup;
		}

		internal static bool xdEpZR5anGRrA83aj6j(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec x9iKPTiyO;

		public static Func<AdapterInfo, Version> cJIRsdU0O;

		private static _003C_003Ec XkXiTl55kpgbfU21fAL;

		static _003C_003Ec()
		{
			hO7yIo5XcOpqRxR2PGp();
			x9iKPTiyO = new _003C_003Ec();
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public _003C_003Ec()
		{
			YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
			base._002Ector();
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal Version aSMHbTo3d(AdapterInfo p)
		{
			return (Version)Jh2JTP5NDjdpnAti8ku(p);
		}

		internal static void hO7yIo5XcOpqRxR2PGp()
		{
			YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
		}

		internal static bool Fd6m595p7feBslXWw0W()
		{
			return XkXiTl55kpgbfU21fAL == null;
		}

		internal static _003C_003Ec WLonZw5Vq6skxugZagt()
		{
			return XkXiTl55kpgbfU21fAL;
		}

		internal static object Jh2JTP5NDjdpnAti8ku(object P_0)
		{
			return ((AdapterInfo)P_0).Version;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public IAdapter b4ZJxkhw1;

		private static _003C_003Ec__DisplayClass23_0 rHBmrt5uaMwbGxM9Yn4;

		public _003C_003Ec__DisplayClass23_0()
		{
			gesB4j5Pj5ZRohBJ7Kw();
			base._002Ector();
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal bool i0U4H6n6b(AdapterInfo a)
		{
			return n7mlKw5W4ynHIS0yWeU(bKEunH5y3StE4BtYl2x(a), b4ZJxkhw1.AdapterGroup);
		}

		internal static void gesB4j5Pj5ZRohBJ7Kw()
		{
			YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
		}

		internal static bool RftwuI5cFCDaTWVKVQw()
		{
			return rHBmrt5uaMwbGxM9Yn4 == null;
		}

		internal static _003C_003Ec__DisplayClass23_0 w4MEIg5k0UMX9ygxp3l()
		{
			return rHBmrt5uaMwbGxM9Yn4;
		}

		internal static object bKEunH5y3StE4BtYl2x(object P_0)
		{
			return ((AdapterInfo)P_0).AdapterGroup;
		}

		internal static bool n7mlKw5W4ynHIS0yWeU(object P_0, object P_1)
		{
			return (string)P_0 != (string)P_1;
		}
	}

	public static readonly string DefaultRepositoryPath;

	private readonly ConcurrentDictionary<string, AdapterInfo> F4PU78DD3;

	private readonly ObservableCollection<IAdapter> i2nt8ggg1;

	private readonly IFileSystem vhnXqW3Pe;

	private readonly ISerializer IFIr4QkNR;

	private static readonly Logger K8fwxM2yP;

	private readonly ConfigFileListBuilder kpG8JV8QW;

	[CompilerGenerated]
	private EventHandler<AdapterInstalledEventArgs> wKygXV6gk;

	[CompilerGenerated]
	private EventHandler<AdapterInstalledEventArgs> AjI6uVvGR;

	[CompilerGenerated]
	private readonly ReadOnlyObservableCollection<IAdapter> xpO9BsFAt;

	internal static LocalAdapterRepository eWq1F1MODaDX8NdGT2;

	public IEnumerable<IAdapter> AvailableAdapters => F4PU78DD3.Values;

	public ReadOnlyObservableCollection<IAdapter> ActiveAdapters
	{
		[CompilerGenerated]
		get
		{
			return xpO9BsFAt;
		}
	}

	public event EventHandler<AdapterInstalledEventArgs> AdapterUpdateInstalled
	{
		[CompilerGenerated]
		add
		{
			EventHandler<AdapterInstalledEventArgs> eventHandler = wKygXV6gk;
			EventHandler<AdapterInstalledEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdapterInstalledEventArgs> value2 = (EventHandler<AdapterInstalledEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wKygXV6gk, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<AdapterInstalledEventArgs> eventHandler = wKygXV6gk;
			EventHandler<AdapterInstalledEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdapterInstalledEventArgs> value2 = (EventHandler<AdapterInstalledEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wKygXV6gk, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<AdapterInstalledEventArgs> AdapterInstalled
	{
		[CompilerGenerated]
		add
		{
			EventHandler<AdapterInstalledEventArgs> eventHandler = AjI6uVvGR;
			EventHandler<AdapterInstalledEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdapterInstalledEventArgs> value2 = (EventHandler<AdapterInstalledEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref AjI6uVvGR, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<AdapterInstalledEventArgs> eventHandler = AjI6uVvGR;
			EventHandler<AdapterInstalledEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AdapterInstalledEventArgs> value2 = (EventHandler<AdapterInstalledEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref AjI6uVvGR, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public LocalAdapterRepository(IFileSystem fileSystem, ISerializer serializer, ConfigFileListBuilder configFileListBuilder)
	{
		YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
		F4PU78DD3 = new ConcurrentDictionary<string, AdapterInfo>();
		i2nt8ggg1 = new ObservableCollection<IAdapter>();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				YfltpDnTyRV3tfJ10K(K8fwxM2yP, Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(322));
				num = 0;
				if (true)
				{
					num = 1;
				}
				break;
			case 2:
				q2m7TrSFd();
				num = 4;
				break;
			case 4:
				return;
			case 1:
				xpO9BsFAt = new ReadOnlyObservableCollection<IAdapter>(i2nt8ggg1);
				num = 6;
				break;
			default:
				tCoFbq9tt();
				num = 2;
				break;
			case 6:
				vhnXqW3Pe = fileSystem ?? throw new ArgumentNullException((string)aqDD0S1VK50FnmubrV(360));
				num = 5;
				break;
			case 5:
				IFIr4QkNR = serializer ?? throw new ArgumentNullException(Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(384));
				kpG8JV8QW = configFileListBuilder ?? throw new ArgumentNullException(Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(408));
				num = 0;
				if (false)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Activate(string adapterId)
	{
		i2nt8ggg1.Add(F4PU78DD3[adapterId]);
	}

	public void Rescan()
	{
		tCoFbq9tt();
	}

	private void q2m7TrSFd()
	{
		IEnumerator<KeyValuePair<string, AdapterInfo>> enumerator = F4PU78DD3.GetEnumerator();
		try
		{
			int num2 = default;
			while (enumerator.MoveNext())
			{
				while (true)
				{
					KeyValuePair<string, AdapterInfo> current = enumerator.Current;
					i2nt8ggg1.Add(current.Value);
					int num = 0;
					if (hxSBAT7Z1mLSpc2hgN() != null)
					{
						num = num2;
					}
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				int num3 = 0;
				if (hxSBAT7Z1mLSpc2hgN() != null)
				{
					int num4 = default;
					num3 = num4;
				}
				switch (num3)
				{
				default:
					enumerator.Dispose();
					break;
				}
			}
		}
	}

	private bool RmIbMpwxw(IAdapter P_0)
	{
		int num = 2;
		_003C_003Ec__DisplayClass22_0 obj = default;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					obj = new _003C_003Ec__DisplayClass22_0();
					num2 = 1;
					if (!DaIQ9bJJJvyhT3Zhca())
					{
						num2 = 1;
					}
					goto IL_0012;
				case 1:
					break;
				default:
				{
					AdapterInfo adapterInfo = (from p in F4PU78DD3.Values.Where(obj.mhkByOcce)
						orderby (Version)_003C_003Ec.Jh2JTP5NDjdpnAti8ku(p)
						select p).FirstOrDefault();
					if (adapterInfo != null)
					{
						return EUVI1c8c2GW4faWdGE(obj.ur7uvHYVg.Version, adapterInfo.Version);
					}
					return false;
				}
				}
				obj.ur7uvHYVg = P_0;
				num2 = 0;
			}
			while (hxSBAT7Z1mLSpc2hgN() == null);
		}
	}

	private bool KdExRd4cm(IAdapter P_0)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals2.b4ZJxkhw1 = P_0;
		int num = 0;
		if (hxSBAT7Z1mLSpc2hgN() == null)
		{
			num = 0;
		}
		return num switch
		{
			_ => F4PU78DD3.Values.All((AdapterInfo a) => _003C_003Ec__DisplayClass23_0.n7mlKw5W4ynHIS0yWeU(_003C_003Ec__DisplayClass23_0.bKEunH5y3StE4BtYl2x(a), CS_0024_003C_003E8__locals2.b4ZJxkhw1.AdapterGroup)), 
		};
	}

	private List<AdapterInfo> QwVh7Dtu9(IEnumerable<string> P_0)
	{
		List<AdapterInfo> list = new List<AdapterInfo>();
		foreach (string item in P_0)
		{
			using Stream reader = vhnXqW3Pe.OpenRead(item);
			AdapterInfo adapterInfo = IFIr4QkNR.Deserialize<AdapterInfo>(reader);
			if (adapterInfo.HostVersion == new Version(1, 0))
			{
				adapterInfo.Directory = Path.GetDirectoryName(item);
				K8fwxM2yP.Info(Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(454), adapterInfo.AdapterGroup, adapterInfo.Directory, adapterInfo.VersionStr, adapterInfo.Is32Bit, adapterInfo.SupportsDiscovery);
				list.Add(adapterInfo);
			}
		}
		return list;
	}

	private void tCoFbq9tt()
	{
		int num = 2;
		IEnumerator<AdapterInfo> enumerator = default;
		IEnumerable<string> adapterConfigFiles = default;
		AdapterInfo current = default;
		int num4 = default;
		int num6 = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					enumerator = (from P_0 in QwVh7Dtu9(adapterConfigFiles)
						where !F4PU78DD3.ContainsKey(P_0.UniqueId)
						select P_0).GetEnumerator();
					num2 = 0;
					if (DaIQ9bJJJvyhT3Zhca())
					{
						continue;
					}
					break;
				case 2:
					adapterConfigFiles = kpG8JV8QW.AdapterConfigFiles;
					num2 = 1;
					if (DaIQ9bJJJvyhT3Zhca())
					{
						continue;
					}
					break;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (!DaIQ9bJJJvyhT3Zhca())
								{
									goto IL_008b;
								}
							}
							else
							{
								current = enumerator.Current;
								num3 = 1;
								if (hxSBAT7Z1mLSpc2hgN() != null)
								{
									goto IL_008b;
								}
							}
							goto IL_008f;
							IL_008f:
							while (true)
							{
								switch (num3)
								{
								case 2:
									return;
								case 5:
									break;
								default:
									goto end_IL_008f;
								case 1:
									goto IL_010e;
								case 4:
									F4PU78DD3.TryAdd((string)FqauEwK3GGlgT0g0Ah(current), current);
									num3 = 5;
									continue;
								}
								BsfqNHFVY(new AdapterInstalledEventArgs(current));
								num3 = 3;
								if (DaIQ9bJJJvyhT3Zhca())
								{
									continue;
								}
								goto IL_008b;
								IL_010e:
								if (KdExRd4cm(current))
								{
									num3 = 4;
									if (!DaIQ9bJJJvyhT3Zhca())
									{
										num3 = 1;
									}
									continue;
								}
								if (!RmIbMpwxw(current))
								{
									break;
								}
								F4PU78DD3.TryAdd(current.UniqueId, current);
								kEIfV1aCm(new AdapterInstalledEventArgs(current));
								num3 = 0;
								if (DaIQ9bJJJvyhT3Zhca())
								{
									num3 = 0;
								}
								continue;
								end_IL_008f:
								break;
							}
							continue;
							IL_008b:
							num3 = num4;
							goto IL_008f;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 0;
							if (!DaIQ9bJJJvyhT3Zhca())
							{
								num5 = num6;
							}
							switch (num5)
							{
							default:
								enumerator.Dispose();
								break;
							}
						}
					}
				}
				break;
			}
		}
	}

	private void kEIfV1aCm(AdapterInstalledEventArgs P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				EventHandler<AdapterInstalledEventArgs> eventHandler = wKygXV6gk;
				if (eventHandler == null)
				{
					num2 = 0;
					if (hxSBAT7Z1mLSpc2hgN() == null)
					{
						num2 = 0;
					}
					break;
				}
				eventHandler(this, P_0);
				return;
			}
			case 0:
				return;
			}
		}
	}

	private void BsfqNHFVY(AdapterInstalledEventArgs P_0)
	{
		EventHandler<AdapterInstalledEventArgs> eventHandler = AjI6uVvGR;
		if (eventHandler != null)
		{
			eventHandler(this, P_0);
			int num = 0;
			if (!DaIQ9bJJJvyhT3Zhca())
			{
				int num2 = default;
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	static LocalAdapterRepository()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
					num2 = 0;
					if (true)
					{
						num2 = 1;
					}
					goto IL_0012;
				case 1:
					break;
				default:
					K8fwxM2yP = (Logger)kMvyN1AQkGrFDlaZ3k();
					return;
				}
				DefaultRepositoryPath = (string)FDwu8E4s6QZUV7GASY(sML9g5bCmQ8IoAWmwb(Environment.SpecialFolder.CommonApplicationData), Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(626), Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(642), aqDD0S1VK50FnmubrV(662));
				num2 = 0;
			}
			while (0 == 0);
		}
	}

	[CompilerGenerated]
	private bool tPSyTBuBf(AdapterInfo P_0)
	{
		return !F4PU78DD3.ContainsKey(P_0.UniqueId);
	}

	internal static void YfltpDnTyRV3tfJ10K(object P_0, object P_1)
	{
		((Logger)P_0).Trace((string)P_1);
	}

	internal static object aqDD0S1VK50FnmubrV(int P_0)
	{
		return Qcm4wV57Dtu9gCobq9.d2PIC2DeoW(P_0);
	}

	internal static bool DaIQ9bJJJvyhT3Zhca()
	{
		return eWq1F1MODaDX8NdGT2 == null;
	}

	internal static LocalAdapterRepository hxSBAT7Z1mLSpc2hgN()
	{
		return eWq1F1MODaDX8NdGT2;
	}

	internal static bool EUVI1c8c2GW4faWdGE(object P_0, object P_1)
	{
		return (Version)P_0 > (Version)P_1;
	}

	internal static object FqauEwK3GGlgT0g0Ah(object P_0)
	{
		return ((AdapterInfo)P_0).UniqueId;
	}

	internal static object sML9g5bCmQ8IoAWmwb(Environment.SpecialFolder P_0)
	{
		return Environment.GetFolderPath(P_0);
	}

	internal static object FDwu8E4s6QZUV7GASY(object P_0, object P_1, object P_2, object P_3)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static object kMvyN1AQkGrFDlaZ3k()
	{
		return LogManager.GetCurrentClassLogger();
	}
}
