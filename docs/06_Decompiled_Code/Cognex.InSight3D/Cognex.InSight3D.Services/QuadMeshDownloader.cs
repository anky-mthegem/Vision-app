using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using AkHicK0bA1TrKhYAY7;
using Cognex.InSight.Internal;
using Cognex.ThreeD.Geometry;
using Cognex.ThreeD.Graphics;
using GHWKpuG7rE0PZAeeF5;
using YYNs7EWJ0BnMDIuHpG;

namespace Cognex.InSight3D.Services;

public class QuadMeshDownloader : DownloaderBase, IQuadMeshDownloader, IDownloader
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadLowResInternalAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<QuadMesh> _003C_003Et__builder;

		public QuadMeshDownloader _003C_003E4__this;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q7ViKO4bXh8LQoA7rWV();
			int num;
			if (!eII1Nh4slQ3yS3nrwZk())
			{
				num = 1;
			}
			else
			{
				num = 5;
				if (eII1Nh4slQ3yS3nrwZk())
				{
					goto IL_01e8;
				}
			}
			goto IL_019a;
			IL_0204:
			int num2 = _003C_003E1__state;
			num = 3;
			goto IL_019a;
			IL_01e8:
			QuadMesh result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (!eII1Nh4slQ3yS3nrwZk())
			{
				goto IL_019a;
			}
			goto IL_0204;
			IL_019a:
			QuadMeshDownloader quadMeshDownloader = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter<Stream> awaiter;
						if (num2 != 0)
						{
							awaiter = quadMeshDownloader._service.GetAsync(quadMeshDownloader._baseUrl + M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(82)).GetAwaiter();
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
						Stream result2 = awaiter.GetResult();
						try
						{
							BinaryReader binaryReader = new BinaryReader(result2);
							try
							{
								QuadMesh quadMesh = MvYv1Q4g3MyqtBGV7b1(binaryReader) as QuadMesh;
								_ = 0;
								int num3 = ((!Q7ViKO4bXh8LQoA7rWV()) ? 2 : 3);
								while (true)
								{
									switch (num3)
									{
									case 0:
									case 3:
										if (quadMesh != null)
										{
											break;
										}
										throw new Exception((string)WPGEXL4zxqES31k23s4(120));
									case 4:
										goto end_IL_00fc;
									}
									result = quadMesh;
									num3 = 4;
									continue;
									end_IL_00fc:
									break;
								}
							}
							finally
							{
								if (num2 < 0 && binaryReader != null)
								{
									SsjxTaKXH5bCxWVTNOP(binaryReader);
								}
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)result2)?.Dispose();
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
				default:
					num = 4;
					if (!eII1Nh4slQ3yS3nrwZk())
					{
						continue;
					}
					goto case 3;
				case 3:
					quadMeshDownloader = _003C_003E4__this;
					goto case 2;
				case 4:
					break;
				case 0:
				case 1:
					goto IL_0204;
				case 6:
					return;
				}
				break;
			}
			goto IL_01e8;
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
		internal static object MvYv1Q4g3MyqtBGV7b1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U2UsKSXlrvh88x8y6C.eUElSBHmx((BinaryReader)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WPGEXL4zxqES31k23s4(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SsjxTaKXH5bCxWVTNOP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q7ViKO4bXh8LQoA7rWV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eII1Nh4slQ3yS3nrwZk()
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
	private struct _003CDownloadLowResAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<QuadMesh> _003C_003Et__builder;

		public QuadMeshDownloader _003C_003E4__this;

		private TaskAwaiter<CacheAccessor> _003C_003Eu__1;

		private TaskAwaiter<QuadMesh> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FjqcFHK4WePKV8tgwxW();
			int num = ((!cyMo0ZKKNkVRgipVsmG()) ? 1 : 5);
			Task<QuadMesh> task = default;
			QuadMeshDownloader quadMeshDownloader = default;
			DownloadedQuadMeshData downloadedQuadMeshData = default;
			IDownloadedData downloadedData = default;
			int num2 = default;
			QuadMesh result2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					break;
				case 4:
					try
					{
						TaskAwaiter<QuadMesh> awaiter;
						TaskAwaiter<CacheAccessor> awaiter2;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0262;
							}
							task = null;
							awaiter2 = CacheAccessor.BuildCacheAccessorAsync(quadMeshDownloader._baseUrl).GetAwaiter();
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
							quadMeshDownloader._cancelToken.ThrowIfCancellationRequested();
							int num3 = 9;
							while (true)
							{
								switch (num3)
								{
								case 4:
									downloadedQuadMeshData = downloadedData as DownloadedQuadMeshData;
									goto case 0;
								default:
									num3 = 0;
									if (FjqcFHK4WePKV8tgwxW())
									{
										continue;
									}
									goto case 8;
								case 8:
									downloadedQuadMeshData.LowRes = quadMeshDownloader.thAm1WnNe();
									goto case 3;
								case 1:
									if (downloadedData == null)
									{
										downloadedData = new DownloadedQuadMeshData();
										FjqcFHK4WePKV8tgwxW();
										if (cyMo0ZKKNkVRgipVsmG())
										{
											num3 = 3;
											if (cyMo0ZKKNkVRgipVsmG())
											{
											}
										}
										else
										{
											num3 = 6;
										}
										continue;
									}
									goto case 4;
								case 0:
									if (downloadedQuadMeshData != null)
									{
										num3 = 5;
										continue;
									}
									throw new Exception((string)aEiNYIKrt6kjJeRp4Po(34));
								case 2:
								case 6:
									result.AddData(downloadedData);
									num3 = 4;
									if (true)
									{
										continue;
									}
									goto case 5;
								case 5:
									if (downloadedQuadMeshData.LowRes == null)
									{
										num3 = 8;
										if (!cyMo0ZKKNkVRgipVsmG())
										{
											continue;
										}
									}
									goto case 3;
								case 3:
								case 7:
									task = downloadedQuadMeshData.LowRes;
									num3 = 10;
									continue;
								case 9:
									downloadedData = (IDownloadedData)geUlkYKeNtQ5kP2PmTw(result);
									num3 = 1;
									if (!cyMo0ZKKNkVRgipVsmG())
									{
										continue;
									}
									break;
								case 10:
									break;
								}
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
						goto IL_0262;
						IL_0262:
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
					break;
				case 2:
					quadMeshDownloader = _003C_003E4__this;
					num = 4;
					if (!FjqcFHK4WePKV8tgwxW())
					{
						return;
					}
					break;
				case 6:
					return;
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
		internal static object geUlkYKeNtQ5kP2PmTw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CacheAccessor)P_0).GetData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aEiNYIKrt6kjJeRp4Po(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FjqcFHK4WePKV8tgwxW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cyMo0ZKKNkVRgipVsmG()
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
	private struct _003CGetPacketHighResAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public QuadMeshDownloader _003C_003E4__this;

		private DownloadingProgress _003Cprogress_003E5__2;

		private TaskAwaiter<CacheAccessor> _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dLv8JyKSpvxkJtobfUN();
			int num = ((!wwpWwHKlNbKmTLCu5vv()) ? 3 : 6);
			int num2 = default;
			QuadMeshDownloader quadMeshDownloader = default;
			byte[] result = default;
			DownloadedQuadMeshData downloadedQuadMeshData = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 6:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					quadMeshDownloader = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (wwpWwHKlNbKmTLCu5vv())
					{
						break;
					}
					goto case 1;
				case 1:
					_003Cprogress_003E5__2 = null;
					num = 4;
					break;
				case 2:
				case 3:
					try
					{
						if ((uint)num2 > 1u)
						{
							_003Cprogress_003E5__2 = null;
						}
						try
						{
							TaskAwaiter<byte[]> awaiter;
							TaskAwaiter<CacheAccessor> awaiter2;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0295;
								}
								awaiter2 = CacheAccessor.BuildCacheAccessorAsync(quadMeshDownloader._baseUrl).GetAwaiter();
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
							CacheAccessor result2 = awaiter2.GetResult();
							Task<byte[]> resource;
							try
							{
								quadMeshDownloader._cancelToken.ThrowIfCancellationRequested();
								int num3 = 6;
								while (true)
								{
									switch (num3)
									{
									case 4:
									case 5:
										downloadedQuadMeshData.HighRes.Resource = quadMeshDownloader.D9a3QWTS9((string)Lrb9flKaGfM6Smm1cWX(quadMeshDownloader._baseUrl, gNAs0BKObNlNtSK37AA(180)), quadMeshDownloader._cancelToken, downloadedQuadMeshData.HighRes.Progress);
										num3 = 7;
										if (0 == 0)
										{
											continue;
										}
										goto case 2;
									case 2:
									case 3:
										if (downloadedQuadMeshData.HighRes.Resource != null)
										{
											break;
										}
										goto case 4;
									case 1:
										_003Cprogress_003E5__2 = (DownloadingProgress)ybht9FKpvm19Q8T9k9P(downloadedQuadMeshData.HighRes);
										num3 = 0;
										continue;
									case 0:
										EEkQgUKoYJYw2HEa3Df(_003Cprogress_003E5__2, new PropertyChangedEventHandler(quadMeshDownloader.txkkqymTr));
										goto default;
									default:
										wwpWwHKlNbKmTLCu5vv();
										num3 = ((!dLv8JyKSpvxkJtobfUN()) ? 2 : 5);
										continue;
									case 6:
										downloadedQuadMeshData = yP9lg7KYMlgTvVnMrDW(result2) as DownloadedQuadMeshData;
										num3 = 1;
										continue;
									case 7:
										break;
									}
									break;
								}
								resource = downloadedQuadMeshData.HighRes.Resource;
							}
							finally
							{
								if (num2 < 0 && result2 != null)
								{
									HdZsCpKCmkPqDQubdgG(result2);
								}
							}
							awaiter = resource.GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0295;
							IL_0295:
							result = awaiter.GetResult();
						}
						catch (Exception)
						{
							throw;
						}
						finally
						{
							if (num2 < 0 && _003Cprogress_003E5__2 != null)
							{
								iob2exKj1WdHc0HkcP7(_003Cprogress_003E5__2, new PropertyChangedEventHandler(quadMeshDownloader.txkkqymTr));
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cprogress_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 1;
				default:
					num = 1;
					if (1 == 0)
					{
						return;
					}
					break;
				case 7:
					return;
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
		internal static object yP9lg7KYMlgTvVnMrDW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CacheAccessor)P_0).GetData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ybht9FKpvm19Q8T9k9P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceDownloadWithProgress<byte[]>)P_0).Progress;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EEkQgUKoYJYw2HEa3Df(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((DownloadingProgress)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gNAs0BKObNlNtSK37AA(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Lrb9flKaGfM6Smm1cWX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HdZsCpKCmkPqDQubdgG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iob2exKj1WdHc0HkcP7(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((DownloadingProgress)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wwpWwHKlNbKmTLCu5vv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dLv8JyKSpvxkJtobfUN()
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
	private struct _003CGetTextureImageAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bitmap> _003C_003Et__builder;

		public QuadMeshDownloader _003C_003E4__this;

		private TaskAwaiter<CacheAccessor> _003C_003Eu__1;

		private TaskAwaiter<Bitmap> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			QuadMeshDownloader quadMeshDownloader = default;
			DownloadedQuadMeshData downloadedQuadMeshData = default;
			int num2 = default;
			Bitmap result2 = default;
			do
			{
				IL_028f:
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!x9F7qCKtkDSAbngPnLn()) ? 5 : 0);
					goto IL_028f;
				case 2:
					try
					{
						_ = 1;
						try
						{
							TaskAwaiter<Bitmap> awaiter;
							TaskAwaiter<CacheAccessor> awaiter2;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0249;
								}
								awaiter2 = CacheAccessor.BuildCacheAccessorAsync(quadMeshDownloader._baseUrl).GetAwaiter();
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
							Task<Bitmap> resource;
							try
							{
								quadMeshDownloader._cancelToken.ThrowIfCancellationRequested();
								int num3 = 1;
								if (!x9F7qCKtkDSAbngPnLn())
								{
									goto IL_00ca;
								}
								goto IL_0115;
								IL_00ca:
								if (downloadedQuadMeshData.Texture.Resource == null)
								{
									goto IL_015e;
								}
								goto IL_01cc;
								IL_015e:
								downloadedQuadMeshData.Texture.Resource = quadMeshDownloader.hgpZJiAeV((string)gF7KGEKLX65dMJOEw8J(quadMeshDownloader._baseUrl, rSG7OyKQq6erOkhN57S(218)), quadMeshDownloader._cancelToken);
								num3 = 8;
								goto IL_0115;
								IL_0115:
								while (true)
								{
									switch (num3)
									{
									case 7:
										break;
									case 0:
										if (downloadedQuadMeshData == null)
										{
											num3 = 2;
											continue;
										}
										break;
									case 2:
										downloadedQuadMeshData = new DownloadedQuadMeshData();
										goto default;
									default:
										x9F7qCKtkDSAbngPnLn();
										if (I9Ii45KHtNPPhQ1u6MY())
										{
											num3 = 4;
											continue;
										}
										num3 = 6;
										if (x9F7qCKtkDSAbngPnLn())
										{
											continue;
										}
										goto IL_015e;
									case 4:
									case 5:
										goto IL_015e;
									case 1:
										downloadedQuadMeshData = L4WSAQKWd6gNANZ213w(result) as DownloadedQuadMeshData;
										num3 = 0;
										if (true)
										{
											continue;
										}
										goto case 3;
									case 3:
									case 6:
										sCkMAOKyLqay2tyWk8a(result, downloadedQuadMeshData);
										num3 = 7;
										if (I9Ii45KHtNPPhQ1u6MY())
										{
										}
										continue;
									case 8:
										goto IL_01cc;
									}
									break;
								}
								goto IL_00ca;
								IL_01cc:
								resource = downloadedQuadMeshData.Texture.Resource;
							}
							finally
							{
								if (num2 < 0 && result != null)
								{
									LkQ8DwKdni5PZyPjj9T(result);
								}
							}
							awaiter = resource.GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0249;
							IL_0249:
							result2 = awaiter.GetResult();
						}
						catch (Exception)
						{
							throw;
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
				case 0:
				case 1:
					quadMeshDownloader = _003C_003E4__this;
					num = 2;
					goto IL_028f;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result2);
				num = 6;
			}
			while (true);
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
		internal static object L4WSAQKWd6gNANZ213w(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CacheAccessor)P_0).GetData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sCkMAOKyLqay2tyWk8a(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CacheAccessor)P_0).AddData((IDownloadedData)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rSG7OyKQq6erOkhN57S(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gF7KGEKLX65dMJOEw8J(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LkQ8DwKdni5PZyPjj9T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x9F7qCKtkDSAbngPnLn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I9Ii45KHtNPPhQ1u6MY()
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
	private struct _003CGetTextureTransformAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Matrix> _003C_003Et__builder;

		public QuadMeshDownloader _003C_003E4__this;

		private TaskAwaiter<CacheAccessor> _003C_003Eu__1;

		private TaskAwaiter<Matrix> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			QuadMeshDownloader quadMeshDownloader = default;
			Matrix result2 = default;
			DownloadedQuadMeshData downloadedQuadMeshData = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					HSalimK1iw8pSaj9FBr();
					num = ((!BfVrCLK9yByWprFRRJl()) ? 3 : 5);
					break;
				case 1:
				case 5:
					quadMeshDownloader = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						TaskAwaiter<Matrix> awaiter;
						Task<Matrix> task;
						TaskAwaiter<CacheAccessor> awaiter2;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0252;
							}
							task = null;
							awaiter2 = CacheAccessor.BuildCacheAccessorAsync(quadMeshDownloader._baseUrl).GetAwaiter();
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
							quadMeshDownloader._cancelToken.ThrowIfCancellationRequested();
							int num3 = 0;
							if (false)
							{
								goto IL_00f4;
							}
							goto IL_01a7;
							IL_00f4:
							if (downloadedQuadMeshData != null)
							{
								goto IL_0140;
							}
							HSalimK1iw8pSaj9FBr();
							num3 = ((!BfVrCLK9yByWprFRRJl()) ? 7 : 4);
							goto IL_01a7;
							IL_015c:
							downloadedQuadMeshData.TextureTransform = quadMeshDownloader.HoNHMm6Or((string)lYi3MjKkdvOi4NtZw6X(quadMeshDownloader._baseUrl, M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(270)), quadMeshDownloader._cancelToken);
							num3 = 8;
							goto IL_01a7;
							IL_01da:
							task = downloadedQuadMeshData.TextureTransform;
							goto end_IL_00dd;
							IL_0140:
							if (downloadedQuadMeshData.TextureTransform == null)
							{
								goto IL_015c;
							}
							goto IL_01da;
							IL_01a7:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								case 6:
									i2iK5YKIVOPMFBnokKD(result, downloadedQuadMeshData);
									num3 = 3;
									continue;
								case 0:
									downloadedQuadMeshData = v5CKs0KVJhfSRwy1dZ7(result) as DownloadedQuadMeshData;
									num3 = 1;
									continue;
								case 3:
									goto IL_0140;
								case 5:
								case 7:
									goto IL_015c;
								case 2:
								case 4:
									downloadedQuadMeshData = new DownloadedQuadMeshData();
									goto case 6;
								default:
									num3 = 6;
									continue;
								case 8:
									goto IL_01da;
								}
								break;
							}
							goto IL_00f4;
							end_IL_00dd:;
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
						goto IL_0252;
						IL_0252:
						result2 = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					break;
				case 6:
					return;
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
		internal static object v5CKs0KVJhfSRwy1dZ7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CacheAccessor)P_0).GetData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void i2iK5YKIVOPMFBnokKD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CacheAccessor)P_0).AddData((IDownloadedData)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lYi3MjKkdvOi4NtZw6X(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BfVrCLK9yByWprFRRJl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HSalimK1iw8pSaj9FBr()
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
	private struct _003CDownloadHighResWithProgressAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public QuadMeshDownloader _003C_003E4__this;

		public string reference;

		public IProgress<double?> progress;

		public CancellationToken token;

		private int _003CnHeaderBytes_003E5__2;

		private Stream _003Cstream_003E5__3;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private byte[] _003CheaderBytes_003E5__4;

		private int _003CremainingHeaderBytes_003E5__5;

		private int _003CpacketSize_003E5__6;

		private byte[] _003Cbytes_003E5__7;

		private long _003CtotalRead_003E5__8;

		private int _003CreadLength_003E5__9;

		private bool _003CisMoreToRead_003E5__10;

		private double _003ClastReportedProgress_003E5__11;

		private TaskAwaiter<int> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			s6ZNl7K7I965g35hIHC();
			int num;
			if (Q4WYKkKm8KW9VN2j3dp())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_0043;
				}
			}
			goto IL_0693;
			IL_002a:
			QuadMeshDownloader quadMeshDownloader = _003C_003E4__this;
			goto IL_0070;
			IL_0043:
			int num2 = _003C_003E1__state;
			num = 5;
			goto IL_0693;
			IL_0070:
			byte[] result4 = default;
			try
			{
				if ((uint)num2 > 2u)
				{
					_003CnHeaderBytes_003E5__2 = 20;
				}
				try
				{
					ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter awaiter;
					if (num2 != 0)
					{
						if ((uint)(num2 - 1) <= 1u)
						{
							goto IL_010e;
						}
						awaiter = quadMeshDownloader._service.GetAsync(reference).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
					_003Cstream_003E5__3 = result;
					goto IL_010e;
					IL_010e:
					try
					{
						int num3;
						TaskAwaiter<int> awaiter2 = default;
						if (num2 != 1)
						{
							num3 = 31;
						}
						else
						{
							awaiter2 = _003C_003Eu__2;
							num3 = 14;
						}
						int result2 = default;
						double num6 = default;
						double num5 = default;
						int result3 = default;
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									num3 = 0;
									continue;
								}
								goto case 10;
							default:
								awaiter2 = _003Cstream_003E5__3.ReadAsync(_003Cbytes_003E5__7, (int)_003CtotalRead_003E5__8, _003CreadLength_003E5__9, token).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 3;
							case 32:
								_003CremainingHeaderBytes_003E5__5 = _003CnHeaderBytes_003E5__2;
								num3 = 20;
								if (true)
								{
									continue;
								}
								goto case 28;
							case 28:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 27:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 18;
								continue;
							case 29:
								_003CheaderBytes_003E5__4 = new byte[_003CnHeaderBytes_003E5__2];
								num3 = 32;
								if (Q4WYKkKm8KW9VN2j3dp())
								{
									continue;
								}
								goto case 9;
							case 9:
								if (result2 == 0)
								{
									num3 = 22;
									continue;
								}
								_003CtotalRead_003E5__8 += result2;
								num3 = 8;
								continue;
							case 19:
								if (!(num6 > 10.0))
								{
									if (num5 == 100.0)
									{
										num3 = 24;
										continue;
									}
									goto case 26;
								}
								goto case 24;
							case 20:
								token.ThrowIfCancellationRequested();
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 26;
							case 26:
							case 34:
								if (!_003CisMoreToRead_003E5__10)
								{
									num3 = 35;
									if (!s6ZNl7K7I965g35hIHC())
									{
										continue;
									}
									goto case 24;
								}
								goto IL_05f8;
							case 24:
								_003ClastReportedProgress_003E5__11 = num5;
								num3 = 25;
								continue;
							case 8:
								num5 = (double)_003CtotalRead_003E5__8 * 1.0 / ((double)_003CpacketSize_003E5__6 * 1.0) * 100.0;
								num6 = num5 - _003ClastReportedProgress_003E5__11;
								if (this.progress != null)
								{
									num3 = 19;
									continue;
								}
								goto case 26;
							case 10:
							case 12:
								result3 = awaiter2.GetResult();
								num3 = 7;
								continue;
							case 16:
							{
								IProgress<double?> progress = this.progress;
								if (progress == null)
								{
									goto case 29;
								}
								progress.Report(0.0);
								num3 = 29;
								continue;
							}
							case 3:
								result2 = awaiter2.GetResult();
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								if (_003CremainingHeaderBytes_003E5__5 <= 0)
								{
									num3 = 21;
									continue;
								}
								goto case 20;
							case 6:
								num2 = (_003C_003E1__state = 2);
								num3 = 15;
								if (Q4WYKkKm8KW9VN2j3dp())
								{
									continue;
								}
								goto case 25;
							case 25:
								this.progress.Report(num5);
								num3 = 26;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 30;
								if (Q4WYKkKm8KW9VN2j3dp())
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__2 = default;
								num3 = 28;
								continue;
							case 15:
								_003C_003Eu__2 = awaiter2;
								num3 = 27;
								if (Q4WYKkKm8KW9VN2j3dp())
								{
									continue;
								}
								goto case 22;
							case 22:
								_003CisMoreToRead_003E5__10 = false;
								num3 = 34;
								if (s6ZNl7K7I965g35hIHC())
								{
								}
								continue;
							case 18:
								return;
							case 7:
								_003CremainingHeaderBytes_003E5__5 -= result3;
								num3 = 4;
								continue;
							case 31:
								if (num2 == 2)
								{
									awaiter2 = _003C_003Eu__2;
									num3 = 11;
									if (s6ZNl7K7I965g35hIHC())
									{
									}
								}
								else
								{
									num3 = 16;
								}
								continue;
							case 14:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								s6ZNl7K7I965g35hIHC();
								if (Q4WYKkKm8KW9VN2j3dp())
								{
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 1;
								}
								num3 = 23;
								continue;
							case 1:
								awaiter2 = _003Cstream_003E5__3.ReadAsync(_003CheaderBytes_003E5__4, _003CnHeaderBytes_003E5__2 - _003CremainingHeaderBytes_003E5__5, _003CremainingHeaderBytes_003E5__5, token).GetAwaiter();
								num3 = 5;
								continue;
							case 2:
								_003CtotalRead_003E5__8 = 0L;
								_003CreadLength_003E5__9 = 32768;
								num3 = 33;
								if (0 == 0)
								{
									continue;
								}
								goto case 13;
							case 13:
								_003CreadLength_003E5__9 = (int)Math.Min(_003CreadLength_003E5__9, _003CpacketSize_003E5__6 - _003CtotalRead_003E5__8);
								goto default;
							case 21:
							{
								int num4 = _003CnHeaderBytes_003E5__2 - 4;
								_003CpacketSize_003E5__6 = dTAStwK6gF0cuwALDlv(_003CheaderBytes_003E5__4, num4);
								_003Cbytes_003E5__7 = new byte[_003CpacketSize_003E5__6];
								num3 = 2;
								if (true)
								{
									continue;
								}
								return;
							}
							case 30:
								return;
							case 33:
								_003CisMoreToRead_003E5__10 = true;
								_003ClastReportedProgress_003E5__11 = 0.0;
								goto IL_05f8;
							case 35:
								break;
								IL_05f8:
								token.ThrowIfCancellationRequested();
								num3 = 13;
								if (Q4WYKkKm8KW9VN2j3dp())
								{
									continue;
								}
								break;
							}
							break;
						}
						result4 = _003Cbytes_003E5__7;
					}
					finally
					{
						if (num2 < 0 && _003Cstream_003E5__3 != null)
						{
							BQGU1gK0px2IUIMELJW(_003Cstream_003E5__3);
						}
					}
				}
				catch (Exception)
				{
					throw;
				}
				finally
				{
					if (num2 < 0)
					{
						this.progress.Report(null);
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
			goto IL_0054;
			IL_0054:
			_003C_003Et__builder.SetResult(result4);
			num = 6;
			if (!Q4WYKkKm8KW9VN2j3dp())
			{
				goto IL_0070;
			}
			goto IL_0693;
			IL_0693:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
				case 3:
					goto IL_0043;
				case 4:
					goto IL_0054;
				case 1:
				case 2:
					goto IL_0070;
				default:
					num = 4;
					if (Q4WYKkKm8KW9VN2j3dp())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static int dTAStwK6gF0cuwALDlv(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BitConverter.ToInt32((byte[])P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BQGU1gK0px2IUIMELJW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q4WYKkKm8KW9VN2j3dp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s6ZNl7K7I965g35hIHC()
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
	private struct _003CDownloadTextureAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bitmap> _003C_003Et__builder;

		public QuadMeshDownloader _003C_003E4__this;

		public string reference;

		public CancellationToken token;

		private Stream _003CimageStream_003E5__2;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private MemoryStream _003CmemoryStream_003E5__3;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (kLgILpKJjOrM7MdH9K1() ? 3 : 5);
			int num2 = default;
			QuadMeshDownloader quadMeshDownloader = default;
			TaskAwaiter awaiter2 = default;
			Bitmap result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						_ = 1;
						try
						{
							ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter awaiter;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									goto IL_00b5;
								}
								awaiter = quadMeshDownloader._service.GetAsync(reference).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							_003CimageStream_003E5__2 = result;
							goto IL_00b5;
							IL_00b5:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 12;
									if (kLgILpKJjOrM7MdH9K1())
									{
										goto IL_00cc;
									}
								}
								else
								{
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num3 = 10;
									if (1 == 0)
									{
										goto IL_01dc;
									}
								}
								goto IL_00e6;
								IL_01dc:
								awaiter2.GetResult();
								token.ThrowIfCancellationRequested();
								num3 = 11;
								goto IL_00e6;
								IL_00e6:
								while (true)
								{
									switch (num3)
									{
									case 2:
										break;
									default:
										num3 = 9;
										continue;
									case 10:
										num2 = (_003C_003E1__state = -1);
										num3 = 7;
										continue;
									case 1:
									case 3:
										if (!awaiter2.IsCompleted)
										{
											goto case 0;
										}
										goto IL_01dc;
									case 12:
										token.ThrowIfCancellationRequested();
										num3 = 8;
										continue;
									case 0:
									case 4:
										num2 = (_003C_003E1__state = 1);
										num3 = 2;
										continue;
									case 9:
										goto IL_018a;
									case 8:
										_003CmemoryStream_003E5__3 = new MemoryStream();
										num3 = 5;
										continue;
									case 6:
										return;
									case 7:
										goto IL_01dc;
									case 11:
										tBoITsK8GMNjLUbMLok(_003CmemoryStream_003E5__3, 0L, SeekOrigin.Begin);
										num3 = 13;
										continue;
									case 5:
										awaiter2 = _003CimageStream_003E5__2.CopyToAsync(_003CmemoryStream_003E5__3, 81920, token).GetAwaiter();
										kAMQMcKPpiU2Fm0bghc();
										if (kLgILpKJjOrM7MdH9K1())
										{
											num3 = 0;
											if (kAMQMcKPpiU2Fm0bghc())
											{
												continue;
											}
											goto case 12;
										}
										num3 = 1;
										continue;
									case 13:
										result2 = new Bitmap(_003CmemoryStream_003E5__3);
										goto end_IL_00b5;
									}
									break;
								}
								goto IL_00cc;
								IL_00cc:
								_003C_003Eu__2 = awaiter2;
								goto IL_018a;
								IL_018a:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 6;
								goto IL_00e6;
								end_IL_00b5:;
							}
							finally
							{
								if (num2 < 0 && _003CimageStream_003E5__2 != null)
								{
									FVjJQrKMiePMCNPvZGu(_003CimageStream_003E5__2);
								}
							}
						}
						catch (Exception)
						{
							result2 = null;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					if (kAMQMcKPpiU2Fm0bghc())
					{
						break;
					}
					goto case 1;
				case 1:
					quadMeshDownloader = _003C_003E4__this;
					goto case 2;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					if (kLgILpKJjOrM7MdH9K1())
					{
					}
					break;
				case 6:
					return;
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
		internal static long tBoITsK8GMNjLUbMLok(object P_0, long P_1, SeekOrigin P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Stream)P_0).Seek(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FVjJQrKMiePMCNPvZGu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kAMQMcKPpiU2Fm0bghc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kLgILpKJjOrM7MdH9K1()
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
	private struct _003CDownloadTextureTransformationAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Matrix> _003C_003Et__builder;

		public QuadMeshDownloader _003C_003E4__this;

		public string reference;

		public CancellationToken token;

		private double[] _003CtransArray_003E5__2;

		private Stream _003CtransStream_003E5__3;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private byte[] _003Cbuffer_003E5__4;

		private TaskAwaiter<int> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			deLGYoKD9oyY6Wm5Ofv();
			int num;
			if (!iycOuFKxbUc02wRYWj0())
			{
				num = 6;
				if (!deLGYoKD9oyY6Wm5Ofv())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_03c6;
			IL_03f5:
			QuadMeshDownloader quadMeshDownloader = _003C_003E4__this;
			num = 4;
			goto IL_03c6;
			IL_03c6:
			Matrix result2 = default;
			int num2 = default;
			TaskAwaiter<int> awaiter2 = default;
			int num4 = default;
			int num5 = default;
			double num6 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 6:
					break;
				case 2:
					_003C_003Et__builder.SetResult(result2);
					num = 7;
					continue;
				case 3:
					_003CtransArray_003E5__2 = null;
					num = 2;
					continue;
				case 4:
					try
					{
						ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_0104;
							}
							_003CtransArray_003E5__2 = new double[0];
							awaiter = quadMeshDownloader._service.GetAsync(reference).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
						_003CtransStream_003E5__3 = result;
						goto IL_0104;
						IL_0104:
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 8;
							}
							else
							{
								awaiter2 = _003C_003Eu__2;
								num3 = 13;
								if (!deLGYoKD9oyY6Wm5Ofv())
								{
									goto IL_02c9;
								}
							}
							goto IL_0179;
							IL_02c9:
							num4 += 8;
							num5++;
							num3 = 14;
							goto IL_0179;
							IL_0179:
							while (true)
							{
								switch (num3)
								{
								case 2:
								case 5:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 12;
										continue;
									}
									goto case 7;
								case 16:
									num5 = 0;
									num3 = 10;
									continue;
								case 7:
									awaiter2.GetResult();
									goto case 11;
								default:
									num3 = 11;
									continue;
								case 11:
									Array.Resize(ref _003CtransArray_003E5__2, _003Cbuffer_003E5__4.Length / 8);
									goto case 0;
								case 8:
									_003Cbuffer_003E5__4 = new byte[48];
									num3 = 4;
									if (deLGYoKD9oyY6Wm5Ofv())
									{
										continue;
									}
									goto case 4;
								case 4:
									token.ThrowIfCancellationRequested();
									awaiter2 = _003CtransStream_003E5__3.ReadAsync(_003Cbuffer_003E5__4, 0, _003Cbuffer_003E5__4.Length).GetAwaiter();
									deLGYoKD9oyY6Wm5Ofv();
									if (iycOuFKxbUc02wRYWj0())
									{
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 8;
									}
									num3 = 5;
									continue;
								case 13:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 1;
								case 1:
									_003CtransArray_003E5__2[num5] = num6;
									num3 = 6;
									if (iycOuFKxbUc02wRYWj0())
									{
									}
									continue;
								case 12:
									_003C_003Eu__2 = awaiter2;
									num3 = 15;
									continue;
								case 3:
									return;
								case 6:
									break;
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 3;
									continue;
								case 0:
								case 9:
									num4 = 0;
									num3 = 16;
									continue;
								case 10:
								case 14:
									if (num4 < _003Cbuffer_003E5__4.Length)
									{
										num6 = OA7X8xKNF4tgtuK28d4(_003Cbuffer_003E5__4, num4);
										num3 = 1;
									}
									else
									{
										num3 = 17;
									}
									continue;
								case 17:
									_003Cbuffer_003E5__4 = null;
									goto end_IL_0179;
								}
								goto IL_02c9;
								continue;
								end_IL_0179:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003CtransStream_003E5__3 != null)
							{
								cW38wvKumgykDgEjtsR(_003CtransStream_003E5__3);
							}
						}
						_003CtransStream_003E5__3 = null;
						result2 = new Matrix(_003CtransArray_003E5__2[2], _003CtransArray_003E5__2[3], _003CtransArray_003E5__2[4], _003CtransArray_003E5__2[5], _003CtransArray_003E5__2[0], _003CtransArray_003E5__2[1]);
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CtransArray_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					continue;
				case 1:
				case 5:
					goto IL_03f5;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			num2 = _003C_003E1__state;
			goto IL_03f5;
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
		internal static double OA7X8xKNF4tgtuK28d4(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BitConverter.ToDouble((byte[])P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cW38wvKumgykDgEjtsR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool deLGYoKD9oyY6Wm5Ofv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iycOuFKxbUc02wRYWj0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly bool mOhIVk7UB;

	protected const int ImageCopyBufferSize = 81920;

	public bool IsTexturable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mOhIVk7UB;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuadMeshDownloader(CognexRemoteServiceBase<Stream> service, string baseUrl, CancellationToken cancelToken, bool isTexturable)
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
		mOhIVk7UB = isTexturable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txkkqymTr(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (js0eoXcGNXvlOONV2F() ? 4 : 3);
		DownloadingProgress downloadingProgress = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				downloadingProgress = P_0 as DownloadingProgress;
				goto case 1;
			case 1:
			case 4:
				if (downloadingProgress != null)
				{
					num = 2;
					break;
				}
				return;
			case 2:
				if (Y9uG2Wv8bHBYj0JyP9(P_1.PropertyName, VSMNa4UPCtd7b34ntH(0)))
				{
					goto case 5;
				}
				return;
			default:
				num = 5;
				break;
			case 5:
				ReportProgress(downloadingProgress.Value);
				num = 6;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadLowResInternalAsync_003Ed__11))]
	private Task<QuadMesh> thAm1WnNe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadLowResInternalAsync_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<QuadMesh>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadLowResAsync_003Ed__12))]
	public Task<QuadMesh> DownloadLowResAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadLowResAsync_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<QuadMesh>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPacketHighResAsync_003Ed__13))]
	public Task<byte[]> GetPacketHighResAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPacketHighResAsync_003Ed__13 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetTextureImageAsync_003Ed__14))]
	public Task<Bitmap> GetTextureImageAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetTextureImageAsync_003Ed__14 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetTextureTransformAsync_003Ed__15))]
	public Task<Matrix> GetTextureTransformAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetTextureTransformAsync_003Ed__15 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Matrix>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadHighResWithProgressAsync_003Ed__16))]
	private Task<byte[]> D9a3QWTS9(string P_0, CancellationToken P_1, IProgress<double?> P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadHighResWithProgressAsync_003Ed__16 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.reference = P_0;
		stateMachine.token = P_1;
		stateMachine.progress = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadTextureAsync_003Ed__17))]
	private Task<Bitmap> hgpZJiAeV(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadTextureAsync_003Ed__17 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.reference = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadTextureTransformationAsync_003Ed__18))]
	private Task<Matrix> HoNHMm6Or(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadTextureTransformationAsync_003Ed__18 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Matrix>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.reference = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VSMNa4UPCtd7b34ntH(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Y9uG2Wv8bHBYj0JyP9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Hn6JtkEvpouYlnnNun()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool js0eoXcGNXvlOONV2F()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
