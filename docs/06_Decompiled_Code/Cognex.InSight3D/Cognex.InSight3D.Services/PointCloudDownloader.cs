using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AkHicK0bA1TrKhYAY7;
using Cognex.InSight.Internal;
using Cognex.ThreeD.Geometry;
using Cognex.ThreeD.Graphics;
using GHWKpuG7rE0PZAeeF5;
using YYNs7EWJ0BnMDIuHpG;

namespace Cognex.InSight3D.Services;

public class PointCloudDownloader : DownloaderBase, IPointCloudDownloader, IDownloader
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadInternalAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IImageGeometry3D> _003C_003Et__builder;

		public PointCloudDownloader _003C_003E4__this;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			PointCloudDownloader pointCloudDownloader = default;
			int num2 = default;
			IImageGeometry3D result2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					pointCloudDownloader = _003C_003E4__this;
					num = 4;
					continue;
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!Ys9NZJ45DruGgpe6Rmm())
					{
						num = 0;
						if (!Ys9NZJ45DruGgpe6Rmm())
						{
							continue;
						}
						goto case 4;
					}
					num = 5;
					continue;
				case 4:
					try
					{
						TaskAwaiter<Stream> awaiter;
						if (num2 != 0)
						{
							awaiter = pointCloudDownloader._service.GetAsync(pointCloudDownloader._baseUrl).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						Stream result = awaiter.GetResult();
						try
						{
							BinaryReader binaryReader = new BinaryReader(result);
							try
							{
								result2 = (IImageGeometry3D)eESdG24BZW65B9QvSpD(binaryReader);
							}
							finally
							{
								if (num2 < 0 && binaryReader != null)
								{
									w5UUpn4FxVH2o4p96S9(binaryReader);
								}
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)result)?.Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result2);
				num = 6;
				if (Ys9NZJ45DruGgpe6Rmm())
				{
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eESdG24BZW65B9QvSpD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U2UsKSXlrvh88x8y6C.eUElSBHmx((BinaryReader)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void w5UUpn4FxVH2o4p96S9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J0iRwi42iQDSry97L8Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ys9NZJ45DruGgpe6Rmm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IImageGeometry3D> _003C_003Et__builder;

		public PointCloudDownloader _003C_003E4__this;

		private TaskAwaiter<CacheAccessor> _003C_003Eu__1;

		private TaskAwaiter<IImageGeometry3D> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_027d;
			IL_001a:
			int num2 = _003C_003E1__state;
			num = 4;
			goto IL_027d;
			IL_027d:
			Task<IImageGeometry3D> task = default;
			PointCloudDownloader pointCloudDownloader = default;
			IDownloadedData downloadedData = default;
			DownloadedImageGeometry3DData downloadedImageGeometry3DData = default;
			IImageGeometry3D result2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<IImageGeometry3D> awaiter;
						TaskAwaiter<CacheAccessor> awaiter2;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_023a;
							}
							task = null;
							awaiter2 = CacheAccessor.BuildCacheAccessorAsync(pointCloudDownloader._baseUrl).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						CacheAccessor result = awaiter2.GetResult();
						try
						{
							pointCloudDownloader._cancelToken.ThrowIfCancellationRequested();
							int num3 = 3;
							while (true)
							{
								switch (num3)
								{
								case 9:
									if (downloadedData == null)
									{
										num3 = 2;
										continue;
									}
									goto IL_0129;
								case 1:
								case 6:
									downloadedImageGeometry3DData.Data = pointCloudDownloader.ImmBt3HSq();
									num3 = 7;
									continue;
								case 7:
									task = downloadedImageGeometry3DData.Data;
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 2;
								case 2:
									downloadedData = new DownloadedImageGeometry3DData();
									num3 = 4;
									continue;
								case 5:
								case 8:
									if (downloadedImageGeometry3DData.Data == null)
									{
										goto case 1;
									}
									goto case 7;
								case 4:
									crWvTo4AqCa6BcFELTk(result, downloadedData);
									goto IL_0129;
								default:
									num3 = 0;
									continue;
								case 3:
									downloadedData = (IDownloadedData)c4dDKd43UvSnbCc7kDS(result);
									num3 = 9;
									continue;
								case 0:
									break;
								case 10:
									goto end_IL_0144;
									IL_0129:
									downloadedImageGeometry3DData = downloadedData as DownloadedImageGeometry3DData;
									break;
								}
								if (downloadedImageGeometry3DData != null)
								{
									NZWj4A4hpkBCFd7wO1Z();
									if (!FDXFgL4R3l8hDLOHJGO())
									{
										num3 = 1;
										continue;
									}
									num3 = 8;
									if (false)
									{
										break;
									}
									continue;
								}
								throw new Exception((string)Ei3LIE4wDR0wkbaZt7o(34));
								continue;
								end_IL_0144:
								break;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)result)?.Dispose();
							}
						}
						awaiter = task.GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_023a;
						IL_023a:
						result2 = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					continue;
				case 4:
					pointCloudDownloader = _003C_003E4__this;
					FDXFgL4R3l8hDLOHJGO();
					if (NZWj4A4hpkBCFd7wO1Z())
					{
						num = 0;
						if (true)
						{
							continue;
						}
						goto default;
					}
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object c4dDKd43UvSnbCc7kDS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CacheAccessor)P_0).GetData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void crWvTo4AqCa6BcFELTk(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CacheAccessor)P_0).AddData((IDownloadedData)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ei3LIE4wDR0wkbaZt7o(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FDXFgL4R3l8hDLOHJGO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NZWj4A4hpkBCFd7wO1Z()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PointCloudDownloader(CognexRemoteServiceBase<Stream> service, string baseUrl, CancellationToken cancelToken)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
		base._002Ector();
		_service = service;
		_baseUrl = baseUrl;
		_cancelToken = cancelToken;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadInternalAsync_003Ed__1))]
	private Task<IImageGeometry3D> ImmBt3HSq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadInternalAsync_003Ed__1 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IImageGeometry3D>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__2))]
	public Task<IImageGeometry3D> DownloadAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadAsync_003Ed__2 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IImageGeometry3D>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}
}
