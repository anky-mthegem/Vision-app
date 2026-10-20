using System;
using System.Diagnostics;
using System.Drawing;
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

namespace Cognex.InSight3D.Services;

public class PumbaaAcqResultDownloader : QuadMeshDownloader, IPumbaaAcqResultDownloader, IQuadMeshDownloader, IDownloader
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadImageAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bitmap> _003C_003Et__builder;

		public PumbaaAcqResultDownloader _003C_003E4__this;

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
			int num = 4;
			if (!O5QCmKKEjUVsFJfkJ5m())
			{
			}
			Bitmap result2 = default;
			int num2 = default;
			PumbaaAcqResultDownloader pumbaaAcqResultDownloader = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 1:
				case 2:
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
									goto IL_00c9;
								}
								awaiter = pumbaaAcqResultDownloader._service.GetAsync(reference).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							goto IL_00c9;
							IL_00c9:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 0;
									goto IL_0144;
								}
								awaiter2 = _003C_003Eu__2;
								goto IL_0249;
								IL_0249:
								_003C_003Eu__2 = default;
								num3 = 3;
								goto IL_0144;
								IL_0144:
								while (true)
								{
									switch (num3)
									{
									case 6:
										num2 = (_003C_003E1__state = 1);
										num3 = 5;
										if (0 == 0)
										{
											continue;
										}
										goto case 3;
									case 3:
										num2 = (_003C_003E1__state = -1);
										goto case 8;
									case 8:
									case 11:
										awaiter2.GetResult();
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										return;
									case 2:
										return;
									default:
										num3 = 1;
										if (!O5QCmKKEjUVsFJfkJ5m())
										{
											continue;
										}
										goto case 5;
									case 5:
										_003C_003Eu__2 = awaiter2;
										EnKahXKnFWwLDX251ed();
										if (O5QCmKKEjUVsFJfkJ5m())
										{
											num3 = 11;
											if (O5QCmKKEjUVsFJfkJ5m())
											{
											}
										}
										else
										{
											num3 = 7;
										}
										continue;
									case 9:
										_003CmemoryStream_003E5__3 = new MemoryStream();
										awaiter2 = JvN0QqKcEJRq1SnZo28(_003CimageStream_003E5__2.CopyToAsync(_003CmemoryStream_003E5__3, 81920, token));
										if (!awaiter2.IsCompleted)
										{
											num3 = 6;
											if (O5QCmKKEjUVsFJfkJ5m())
											{
											}
											continue;
										}
										goto case 8;
									case 12:
										PncnODKUkQ2V26tV8ui(_003CmemoryStream_003E5__3, 0L, SeekOrigin.Begin);
										num3 = 13;
										continue;
									case 4:
									case 7:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 2;
										continue;
									case 10:
										token.ThrowIfCancellationRequested();
										num3 = 12;
										if (0 == 0)
										{
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										token.ThrowIfCancellationRequested();
										num3 = 9;
										if (EnKahXKnFWwLDX251ed())
										{
											continue;
										}
										goto case 13;
									case 13:
										result2 = new Bitmap(_003CmemoryStream_003E5__3);
										goto end_IL_0144;
									}
									goto IL_0249;
									continue;
									end_IL_0144:
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003CimageStream_003E5__2 != null)
								{
									GC5kyNKvSYYaAYdNCIe(_003CimageStream_003E5__2);
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
					goto default;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					pumbaaAcqResultDownloader = _003C_003E4__this;
					_ = 0;
					if (!EnKahXKnFWwLDX251ed())
					{
						num = 0;
						if (true)
						{
							break;
						}
						goto case 4;
					}
					num = 1;
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
		internal static TaskAwaiter JvN0QqKcEJRq1SnZo28(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long PncnODKUkQ2V26tV8ui(object P_0, long P_1, SeekOrigin P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Stream)P_0).Seek(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GC5kyNKvSYYaAYdNCIe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EnKahXKnFWwLDX251ed()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O5QCmKKEjUVsFJfkJ5m()
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
	private struct _003CGetImageAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bitmap> _003C_003Et__builder;

		public PumbaaAcqResultDownloader _003C_003E4__this;

		public string imageUrl;

		private TaskAwaiter<CacheAccessor> _003C_003Eu__1;

		private TaskAwaiter<Bitmap> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			PumbaaAcqResultDownloader pumbaaAcqResultDownloader = default;
			string text = default;
			DownloadedPumbaaAcqResultData downloadedPumbaaAcqResultData = default;
			Task<Bitmap> task = default;
			int num2 = default;
			Bitmap result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
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
									goto IL_02b6;
								}
								awaiter2 = CacheAccessor.BuildCacheAccessorAsync(pumbaaAcqResultDownloader._baseUrl).GetAwaiter();
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
							Task<Bitmap> task2;
							try
							{
								pumbaaAcqResultDownloader._cancelToken.ThrowIfCancellationRequested();
								int num3 = 4;
								if (!KANrGkKZINqymdVGs9g())
								{
									goto IL_00ad;
								}
								goto IL_018c;
								IL_00ad:
								text = pumbaaAcqResultDownloader._baseUrl + imageUrl;
								j5ccwtKi4WBNufBOM8C();
								if (KANrGkKZINqymdVGs9g())
								{
									num3 = 10;
									if (!KANrGkKZINqymdVGs9g())
									{
										goto IL_00e0;
									}
								}
								else
								{
									num3 = 3;
								}
								goto IL_018c;
								IL_018c:
								while (true)
								{
									Task<Bitmap> resource;
									switch (num3)
									{
									case 5:
										break;
									case 1:
										goto IL_00e0;
									case 7:
										if (!KTvv91KG73tltSSCF8S(imageUrl, baZfGOKfWY19T8jJOw5(328)))
										{
											downloadedPumbaaAcqResultData.SecondaryMax.Resource = task;
											num3 = 12;
											continue;
										}
										num3 = 11;
										if (true)
										{
											continue;
										}
										goto case 4;
									case 4:
										downloadedPumbaaAcqResultData = QAgmMtKTrp0RbyaoiyQ(result) as DownloadedPumbaaAcqResultData;
										num3 = 0;
										if (!j5ccwtKi4WBNufBOM8C())
										{
											continue;
										}
										goto case 8;
									case 8:
										resource = downloadedPumbaaAcqResultData.SecondaryMax.Resource;
										goto IL_0171;
									default:
										num3 = 5;
										continue;
									case 2:
										if (KTvv91KG73tltSSCF8S(imageUrl, baZfGOKfWY19T8jJOw5(328)))
										{
											resource = downloadedPumbaaAcqResultData.PrimaryMax.Resource;
											goto IL_0171;
										}
										num3 = 8;
										continue;
									case 6:
									case 10:
										task = pumbaaAcqResultDownloader.L1jsKZfP6(text, pumbaaAcqResultDownloader._cancelToken);
										num3 = 7;
										continue;
									case 11:
										downloadedPumbaaAcqResultData.PrimaryMax.Resource = task;
										goto case 3;
									case 0:
										if (downloadedPumbaaAcqResultData == null)
										{
											downloadedPumbaaAcqResultData = new DownloadedPumbaaAcqResultData();
											num3 = 1;
											continue;
										}
										goto case 2;
									case 3:
									case 9:
									case 12:
										{
											task2 = task;
											goto end_IL_0092;
										}
										IL_0171:
										task = resource;
										if (task == null)
										{
											break;
										}
										goto case 3;
									}
									break;
								}
								goto IL_00ad;
								IL_00e0:
								b2NYQtKqZgkm3CCbEIh(result, downloadedPumbaaAcqResultData);
								num3 = 2;
								goto IL_018c;
								end_IL_0092:;
							}
							finally
							{
								if (num2 < 0 && result != null)
								{
									EJxSP3K2bHG3PIpKktg(result);
								}
							}
							awaiter = task2.GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_02b6;
							IL_02b6:
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
					goto case 3;
				default:
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 1:
				case 5:
					pumbaaAcqResultDownloader = _003C_003E4__this;
					goto case 2;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (KANrGkKZINqymdVGs9g() ? 5 : 4);
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
		internal static object QAgmMtKTrp0RbyaoiyQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CacheAccessor)P_0).GetData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void b2NYQtKqZgkm3CCbEIh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CacheAccessor)P_0).AddData((IDownloadedData)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object baZfGOKfWY19T8jJOw5(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KTvv91KG73tltSSCF8S(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EJxSP3K2bHG3PIpKktg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KANrGkKZINqymdVGs9g()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j5ccwtKi4WBNufBOM8C()
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
	private struct _003CGetPrimaryCameraMaxImageAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bitmap> _003C_003Et__builder;

		public PumbaaAcqResultDownloader _003C_003E4__this;

		private TaskAwaiter<Bitmap> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!KK7RDlK5oHpATgdci8X())
			{
				goto IL_001e;
			}
			goto IL_0193;
			IL_001e:
			Bitmap result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0193;
			IL_0193:
			int num2 = default;
			PumbaaAcqResultDownloader pumbaaAcqResultDownloader = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter<Bitmap> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = pumbaaAcqResultDownloader.BYM4pyxmL((string)f2AfhJKFQ41YpZOrfeN(328)).GetAwaiter();
							num3 = 5;
							if (1 == 0)
							{
								goto IL_005c;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 8:
								break;
							default:
								num3 = 7;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 9;
							case 1:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (KK7RDlK5oHpATgdci8X())
								{
									num3 = 4;
									if (UrH4phKBiWSVYEQeBHt())
									{
									}
									continue;
								}
								num3 = 8;
								if (KK7RDlK5oHpATgdci8X())
								{
									continue;
								}
								goto case 0;
							case 7:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								break;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_007c;
							}
							goto IL_005c;
							continue;
							end_IL_007c:
							break;
						}
						goto end_IL_0034;
						IL_005c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0034:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					pumbaaAcqResultDownloader = _003C_003E4__this;
					UrH4phKBiWSVYEQeBHt();
					num = (KK7RDlK5oHpATgdci8X() ? 5 : 0);
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object f2AfhJKFQ41YpZOrfeN(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KK7RDlK5oHpATgdci8X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UrH4phKBiWSVYEQeBHt()
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
	private struct _003CGetSecondaryCameraMaxImageAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bitmap> _003C_003Et__builder;

		public PumbaaAcqResultDownloader _003C_003E4__this;

		private TaskAwaiter<Bitmap> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!lfLYlTKR365giwKPW6x())
			{
				goto IL_001e;
			}
			goto IL_016f;
			IL_001e:
			int num2 = default;
			PumbaaAcqResultDownloader pumbaaAcqResultDownloader = default;
			Bitmap result = default;
			try
			{
				TaskAwaiter<Bitmap> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = pumbaaAcqResultDownloader.BYM4pyxmL((string)XIWydCK3e80ldKWUbsH(408)).GetAwaiter();
					num3 = 5;
					if (false)
					{
						goto IL_0046;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 6;
				}
				goto IL_00df;
				IL_00df:
				while (true)
				{
					switch (num3)
					{
					case 2:
					case 7:
						break;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 5:
						if (!awaiter.IsCompleted)
						{
							lfLYlTKR365giwKPW6x();
							num3 = (qCINOwKh5DvbFrvagT2() ? 7 : 8);
							continue;
						}
						goto case 9;
					case 3:
						return;
					case 1:
					case 8:
						num2 = (_003C_003E1__state = 0);
						break;
					case 4:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 3;
						continue;
					case 6:
						_003C_003Eu__1 = default;
						num3 = 0;
						continue;
					case 9:
						result = awaiter.GetResult();
						goto end_IL_00df;
					}
					goto IL_0046;
					continue;
					end_IL_00df:
					break;
				}
				goto end_IL_001e;
				IL_0046:
				_003C_003Eu__1 = awaiter;
				num3 = 4;
				goto IL_00df;
				end_IL_001e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01de;
			IL_016f:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 5:
					pumbaaAcqResultDownloader = _003C_003E4__this;
					num = 4;
					if (qCINOwKh5DvbFrvagT2())
					{
					}
					continue;
				case 0:
					goto IL_01bb;
				default:
					goto IL_01de;
				case 6:
					return;
				}
				break;
				IL_01bb:
				num2 = _003C_003E1__state;
				lfLYlTKR365giwKPW6x();
				if (qCINOwKh5DvbFrvagT2())
				{
					num = 2;
					continue;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto IL_01de;
			}
			goto IL_001e;
			IL_01de:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_016f;
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
		internal static object XIWydCK3e80ldKWUbsH(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lfLYlTKR365giwKPW6x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qCINOwKh5DvbFrvagT2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PumbaaAcqResultDownloader(CognexRemoteServiceBase<Stream> service, string baseUrl, CancellationToken cancelToken, bool isTexturable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
		base._002Ector(service, baseUrl, cancelToken, isTexturable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadImageAsync_003Ed__5))]
	private Task<Bitmap> L1jsKZfP6(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadImageAsync_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.reference = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImageAsync_003Ed__6))]
	private Task<Bitmap> BYM4pyxmL(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImageAsync_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.imageUrl = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPrimaryCameraMaxImageAsync_003Ed__7))]
	public Task<Bitmap> GetPrimaryCameraMaxImageAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPrimaryCameraMaxImageAsync_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSecondaryCameraMaxImageAsync_003Ed__8))]
	public Task<Bitmap> GetSecondaryCameraMaxImageAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSecondaryCameraMaxImageAsync_003Ed__8 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}
}
