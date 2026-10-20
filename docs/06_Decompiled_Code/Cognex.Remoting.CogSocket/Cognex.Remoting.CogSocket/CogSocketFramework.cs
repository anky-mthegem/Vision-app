using System;
using System.Runtime.CompilerServices;
using System.Threading;
using IawbpyxeWauKVJvQ4t;
using yFqFqrNb1tZ9uvfT9p;

namespace Cognex.Remoting.CogSocket;

public static class CogSocketFramework
{
	public static class ExceptionData
	{
		[CompilerGenerated]
		private static readonly string gNYipAR9DF;

		[CompilerGenerated]
		private static readonly string yxCisKvXhf;

		public static string PathKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return gNYipAR9DF;
			}
		}

		public static string TypeKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return yxCisKvXhf;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExceptionData()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (thpRWARHSyVcg3Jmhva())
			{
				num = 3;
				if (NV4D3sRVtuWSy45Ckel())
				{
				}
			}
			else
			{
				num = 4;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					gNYipAR9DF = UNkfE94JEjYP98PsqC.cGFu3AUnFy(1786);
					break;
				case 0:
				case 3:
					uY237NRfbrdSc29mm18();
					num = 1;
					continue;
				case 5:
					return;
				}
				yxCisKvXhf = (string)r200MyR2VrD3mg4wXQ4(1798);
				num = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uY237NRfbrdSc29mm18()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object r200MyR2VrD3mg4wXQ4(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UNkfE94JEjYP98PsqC.cGFu3AUnFy(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool thpRWARHSyVcg3Jmhva()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NV4D3sRVtuWSy45Ckel()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private static EventHandler<CogSocket> MimwlwtUl;

	internal static event EventHandler<CogSocket> CogSocketCreated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocket> eventHandler = MimwlwtUl;
			EventHandler<CogSocket> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocket> value2 = (EventHandler<CogSocket>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MimwlwtUl, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocket> eventHandler = MimwlwtUl;
			EventHandler<CogSocket> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocket> value2 = (EventHandler<CogSocket>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MimwlwtUl, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Mwojw8Xue(CogSocket P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (WN0jaMpPYtEinnfarFr() ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
			{
				if (P_0 == null)
				{
					return;
				}
				EventHandler<CogSocket> mimwlwtUl = MimwlwtUl;
				if (mimwlwtUl == null)
				{
					return;
				}
				mimwlwtUl(P_0, P_0);
				num = 5;
				break;
			}
			case 1:
				return;
			case 3:
				return;
			default:
				num = 2;
				if (!EMYaLmpFKYKmtPjIusQ())
				{
					return;
				}
				break;
			case 2:
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EMYaLmpFKYKmtPjIusQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WN0jaMpPYtEinnfarFr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
