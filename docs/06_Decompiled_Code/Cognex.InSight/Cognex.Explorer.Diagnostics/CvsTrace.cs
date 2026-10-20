using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Diagnostics;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Explorer.Diagnostics;

public static class CvsTrace
{
	public static class Display
	{
		public static readonly CnxTraceChannel Critical;

		public static readonly CnxTraceChannel Error;

		public static readonly CnxTraceChannel Info;

		public static readonly CnxTraceChannel CropScale;

		public static readonly CnxTraceChannel ViewUpdateService;

		public static readonly CnxTraceChannel ResultsUpdate;

		public static readonly CnxTraceChannel UpdateRate;

		public static readonly CnxTraceChannel Draw;

		public static readonly CnxTraceChannel Svg;

		public static readonly CnxTraceChannel ImageMemoryLeaks;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Display()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!RJmNG7gASVqu6dxCs7I())
			{
				goto IL_001e;
			}
			goto IL_00d2;
			IL_001e:
			Svg = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(47996), (string)Xs1X5YgTk6Rguigy5pC(48030), TraceLevel.Verbose, CnxTraceVisibility.Internal);
			num = 8;
			goto IL_00d2;
			IL_00d2:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 9:
					Draw = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(47908), (string)Xs1X5YgTk6Rguigy5pC(47944), TraceLevel.Verbose, CnxTraceVisibility.Internal);
					num = 3;
					continue;
				default:
					UpdateRate = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(47804), (string)Xs1X5YgTk6Rguigy5pC(47852), TraceLevel.Info, CnxTraceVisibility.Public);
					num = 9;
					continue;
				case 10:
					ResultsUpdate = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(47720), (string)Xs1X5YgTk6Rguigy5pC(47774), TraceLevel.Verbose, CnxTraceVisibility.Internal);
					goto default;
				case 8:
					ImageMemoryLeaks = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(48090), (string)Xs1X5YgTk6Rguigy5pC(48144), TraceLevel.Verbose, CnxTraceVisibility.Internal);
					num = 12;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
				case 7:
					Error = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(47404), (string)Xs1X5YgTk6Rguigy5pC(47442), TraceLevel.Error, CnxTraceVisibility.Public, enabled: true);
					num = 5;
					continue;
				case 0:
					ejtxsSgUZ0XBpwbT0nr();
					num = 1;
					continue;
				case 5:
					Info = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(47472), (string)Xs1X5YgTk6Rguigy5pC(47508), TraceLevel.Info, CnxTraceVisibility.Public);
					num = 11;
					if (bAI5hVgDQINf8r3PgQm())
					{
					}
					continue;
				case 1:
					Critical = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(47308), kgbOBx7BanbFa22Hp9.ol99ukmDA(47352), TraceLevel.Error, CnxTraceVisibility.Public, enabled: true);
					_ = 0;
					if (!RJmNG7gASVqu6dxCs7I())
					{
						num = 4;
						continue;
					}
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 11;
				case 11:
					CropScale = new CnxTraceChannel((string)Xs1X5YgTk6Rguigy5pC(47536), (string)Xs1X5YgTk6Rguigy5pC(47582), TraceLevel.Info, CnxTraceVisibility.Internal);
					ViewUpdateService = new CnxTraceChannel(kgbOBx7BanbFa22Hp9.ol99ukmDA(47630), (string)Xs1X5YgTk6Rguigy5pC(47678), TraceLevel.Verbose, CnxTraceVisibility.Internal);
					num = 10;
					continue;
				case 12:
					return;
				}
				break;
			}
			goto IL_001e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ejtxsSgUZ0XBpwbT0nr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xs1X5YgTk6Rguigy5pC(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RJmNG7gASVqu6dxCs7I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bAI5hVgDQINf8r3PgQm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}
}
