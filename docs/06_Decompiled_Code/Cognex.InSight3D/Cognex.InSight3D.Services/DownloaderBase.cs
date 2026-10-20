using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Internal;
using Cognex.ThreeD.Graphics;
using GHWKpuG7rE0PZAeeF5;

namespace Cognex.InSight3D.Services;

public class DownloaderBase : IDownloader
{
	protected string _baseUrl;

	protected CancellationToken _cancelToken;

	protected CognexRemoteServiceBase<Stream> _service;

	protected static readonly ILogger Logger;

	[CompilerGenerated]
	private EventHandler<ReportProgressEventArgs> v619wPRrc;

	public event EventHandler<ReportProgressEventArgs> ProgressChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<ReportProgressEventArgs> eventHandler = v619wPRrc;
			EventHandler<ReportProgressEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ReportProgressEventArgs> value2 = (EventHandler<ReportProgressEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref v619wPRrc, value2, eventHandler2);
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
			EventHandler<ReportProgressEventArgs> eventHandler = v619wPRrc;
			EventHandler<ReportProgressEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ReportProgressEventArgs> value2 = (EventHandler<ReportProgressEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref v619wPRrc, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void ReportProgress(double? progress)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		v619wPRrc?.Invoke(this, new ReportProgressEventArgs(progress));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnProgressChanged(ReportProgressEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		v619wPRrc?.Invoke(this, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DownloaderBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		W6Ge3cxVHcSyg75dtQ();
		xlBXafNqurTPCybjyS(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DownloaderBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		W6Ge3cxVHcSyg75dtQ();
		Logger = LogManager.GetLogger<DownloaderBase>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cIk83GM2b96F1dd8Ai()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xLFhtJDwx52o42K7DL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W6Ge3cxVHcSyg75dtQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xlBXafNqurTPCybjyS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
