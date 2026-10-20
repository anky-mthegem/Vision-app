using System.Diagnostics;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public static class CvsTraceEzb
{
	public static readonly CnxTraceChannel Critical;

	public static readonly CnxTraceChannel Error;

	public static readonly CnxTraceChannel Info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsTraceEzb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		acGAJZ0C9chrv0EFcO();
		int num;
		if (WMLr3YyMwOk89YNYqI())
		{
			num = 3;
		}
		else
		{
			num = 1;
			if (acGAJZ0C9chrv0EFcO())
			{
				goto IL_009b;
			}
		}
		goto IL_00ce;
		IL_0028:
		Info = new CnxTraceChannel((string)hn3sIfMpjIQi4LHn1k(518), CdQUGaROfy7He9T0foW.KbIzwHEDLa(546), TraceLevel.Info, CnxTraceVisibility.Public);
		num = 6;
		goto IL_00ce;
		IL_009b:
		Error = new CnxTraceChannel(CdQUGaROfy7He9T0foW.KbIzwHEDLa(466), (string)hn3sIfMpjIQi4LHn1k(496), TraceLevel.Error, CnxTraceVisibility.Public, enabled: true);
		goto IL_0028;
		IL_00ce:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				eLYMXxFDSSRNWNn7iG();
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				Critical = new CnxTraceChannel(CdQUGaROfy7He9T0foW.KbIzwHEDLa(386), (string)hn3sIfMpjIQi4LHn1k(422), TraceLevel.Error, CnxTraceVisibility.Public, enabled: true);
				goto IL_009b;
			case 1:
			case 2:
				goto IL_009b;
			default:
				num = 4;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0028;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eLYMXxFDSSRNWNn7iG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hn3sIfMpjIQi4LHn1k(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WMLr3YyMwOk89YNYqI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool acGAJZ0C9chrv0EFcO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
