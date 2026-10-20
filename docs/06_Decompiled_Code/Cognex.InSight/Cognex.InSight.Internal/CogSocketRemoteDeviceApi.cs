using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Cognex.Cnx.Diagnostics;
using Cognex.Extensions;
using Cognex.Features;
using Cognex.InSight.Properties;
using Cognex.Remoting.CogSocket;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

internal class CogSocketRemoteDeviceApi : IRemoteDeviceApi, IDisposable, IMessagePayloadPreview
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConnect_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MVZRVosN42S2cm6PfBNB();
			int num;
			if (aFPplysN0QSRJvRvdXHf())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (MVZRVosN42S2cm6PfBNB())
				{
					goto IL_01e7;
				}
			}
			goto IL_0184;
			IL_0184:
			int num2 = default;
			ConfiguredTaskAwaitable configuredTaskAwaitable = default;
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = IOKbAesNk2gT4CPcfPrX(cogSocketRemoteDeviceApi.Fy4A4Qq83n.Connect(), false);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 6:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 5:
								return;
							case 7:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 2;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								num3 = ((!MVZRVosN42S2cm6PfBNB()) ? 6 : 0);
								continue;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (aFPplysN0QSRJvRvdXHf())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_01e7;
			IL_01e7:
			cogSocketRemoteDeviceApi = _003C_003E4__this;
			num = 3;
			goto IL_0184;
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
		internal static ConfiguredTaskAwaitable IOKbAesNk2gT4CPcfPrX(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aFPplysN0QSRJvRvdXHf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MVZRVosN42S2cm6PfBNB()
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
	private struct _003CGetAsync_003Ed__27<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		public string path;

		private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 4 : 3);
			int num2 = default;
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			ConfiguredTaskAwaitable<T> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter awaiter = default;
			T result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						if (num2 != 0)
						{
							cogSocketRemoteDeviceApi.MpJozqTtll();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								configuredTaskAwaitable = cogSocketRemoteDeviceApi.OKZAPXQYlW(cogSocketRemoteDeviceApi.Fy4A4Qq83n.Get(path).ToTypedTask<T>()).ConfigureAwait(continueOnCapturedContext: false);
								_ = 0;
								num3 = ((1 == 0) ? 7 : 8);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
							}
							while (true)
							{
								switch (num3)
								{
								case 0:
								case 8:
									awaiter = configuredTaskAwaitable.GetAwaiter();
									num3 = 4;
									continue;
								case 1:
									num2 = (_003C_003E1__state = 0);
									goto case 3;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									break;
								case 3:
								case 7:
									_003C_003Eu__1 = awaiter;
									goto case 9;
								default:
									num3 = 9;
									continue;
								case 2:
									_003C_003Eu__1 = default;
									num3 = 5;
									continue;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 6;
									continue;
								case 6:
									return;
								case 5:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 10:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						catch (Exception ex)
						{
							throw bbIA1LrvjR(ex, path);
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 2;
				default:
					num = 2;
					continue;
				case 2:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 1:
				case 4:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				cogSocketRemoteDeviceApi = _003C_003E4__this;
				num = 5;
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
		internal static bool dhBDVZsNfi8hmxAMpUEN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fr2cg2sNFe0dxjhN44el()
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
	private struct _003CPostAsync_003Ed__28<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		public string path;

		public object[] args;

		private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			ConfiguredTaskAwaitable<T> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter awaiter = default;
			T result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						if (num2 != 0)
						{
							cogSocketRemoteDeviceApi.MpJozqTtll();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								configuredTaskAwaitable = cogSocketRemoteDeviceApi.OKZAPXQYlW(cogSocketRemoteDeviceApi.Fy4A4Qq83n.Post(path, args).ToTypedTask<T>()).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 4;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
							}
							while (true)
							{
								switch (num3)
								{
								case 4:
									awaiter = configuredTaskAwaitable.GetAwaiter();
									num3 = 1;
									continue;
								case 0:
									_003C_003Eu__1 = awaiter;
									goto case 8;
								default:
									num3 = 8;
									continue;
								case 5:
								case 9:
									return;
								case 2:
									_003C_003Eu__1 = default;
									goto case 6;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									_ = 0;
									num3 = (true ? 9 : 6);
									continue;
								case 3:
									num2 = (_003C_003E1__state = 0);
									num3 = 0;
									continue;
								case 6:
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 1:
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									break;
								case 10:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						catch (Exception ex)
						{
							throw bbIA1LrvjR(ex, path);
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
				case 0:
				case 1:
					cogSocketRemoteDeviceApi = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((1 == 0) ? 4 : 0);
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
		internal static bool dtCJ1PsNmohgKbeXNRSn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XRmGiesNyMZ82eg7OWxP()
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
	private struct _003CPutAsync_003Ed__31<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		public string path;

		public object arg;

		private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			ConfiguredTaskAwaitable<T> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter awaiter = default;
			T result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						if (num2 != 0)
						{
							cogSocketRemoteDeviceApi.MpJozqTtll();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								configuredTaskAwaitable = cogSocketRemoteDeviceApi.OKZAPXQYlW(cogSocketRemoteDeviceApi.Fy4A4Qq83n.Put(path, arg).ToTypedTask<T>()).ConfigureAwait(continueOnCapturedContext: false);
								_ = 0;
								num3 = ((1 == 0) ? 3 : 5);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 9;
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 6;
									continue;
								case 8:
									return;
								default:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 8;
									continue;
								case 7:
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									break;
								case 0:
								case 5:
									awaiter = configuredTaskAwaitable.GetAwaiter();
									num3 = 7;
									continue;
								case 9:
									_003C_003Eu__1 = default;
									num3 = 1;
									continue;
								case 6:
									_003C_003Eu__1 = awaiter;
									goto default;
								case 10:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						catch (Exception ex)
						{
							throw bbIA1LrvjR(ex, path);
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					break;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 1:
				case 3:
					cogSocketRemoteDeviceApi = _003C_003E4__this;
					goto case 2;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (true ? 3 : 5);
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
		internal static bool OmOwoIsNgYgOTnJlDsaA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b6j0BqsNZ07h1ru4uL6v()
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
	private struct _003CMakeHttpGetRequest_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		public string url;

		public TimeSpan timeout;

		private HttpResponseMessage _003Cresponse_003E5__2;

		private int _003CcontentLength_003E5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!k5ECYwsNJoVeOm93m3x3())
			{
				goto IL_001e;
			}
			goto IL_041d;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 1;
			if (YgqYqqsN8uERUq47shDP())
			{
			}
			goto IL_041d;
			IL_041d:
			Stream result2 = default;
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			TaskAwaiter<Stream> awaiter = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter2 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> configuredTaskAwaitable = default;
			HttpRequestMessage request = default;
			Stream result = default;
			HttpResponseMessage result3 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					continue;
				case 1:
					cogSocketRemoteDeviceApi = _003C_003E4__this;
					_ = 1;
					num = ((!YgqYqqsN8uERUq47shDP()) ? 5 : 0);
					continue;
				case 2:
				case 5:
					try
					{
						if ((uint)num2 > 1u)
						{
							cogSocketRemoteDeviceApi.MpJozqTtll();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 15;
								}
								else
								{
									awaiter = _003C_003Eu__2;
									num3 = 18;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 13;
							}
							while (true)
							{
								object obj2;
								switch (num3)
								{
								case 16:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 20;
									continue;
								case 0:
								{
									CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(timeout);
									configuredTaskAwaitable = cogSocketRemoteDeviceApi.lF0AJTy98J.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, HTqWFTsxwgWMW7crlAc9(cancellationTokenSource)).ConfigureAwait(continueOnCapturedContext: false);
									_ = 1;
									if (!YgqYqqsN8uERUq47shDP())
									{
										num3 = 21;
										continue;
									}
									num3 = 19;
									if (true)
									{
										continue;
									}
									goto case 2;
								}
								case 5:
									if (_003CcontentLength_003E5__3 > 0)
									{
										num3 = 11;
										continue;
									}
									break;
								case 8:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									num3 = 16;
									continue;
								case 22:
									_003CcontentLength_003E5__3 = (int)((HttpContentHeaders)xdFCCmsxLShvYVEHwgb7(er1JTlsxhdU5P8xMmov8(_003Cresponse_003E5__2))).ContentLength.GetValueOrDefault();
									num3 = 1;
									continue;
								case 23:
									_003C_003Eu__2 = awaiter;
									num3 = 4;
									continue;
								case 14:
									obj2 = null;
									goto IL_0165;
								case 7:
									if (!awaiter2.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto IL_0299;
								case 20:
									return;
								case 17:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 23;
										continue;
									}
									goto IL_02bd;
								case 11:
								{
									ProgressReportingStream progressReportingStream = new ProgressReportingStream(result);
									progressReportingStream.SetLength(_003CcontentLength_003E5__3);
									result2 = progressReportingStream;
									num3 = 24;
									continue;
								}
								case 10:
									XufabhsxssxwIgKFp6dD(_003Cresponse_003E5__2);
									goto case 22;
								default:
									num3 = 22;
									continue;
								case 13:
									num2 = (_003C_003E1__state = -1);
									goto IL_0299;
								case 2:
									num2 = (_003C_003E1__state = -1);
									goto IL_02bd;
								case 6:
								{
									object obj = FhWHH8sx9eGi655nfUIt(xdFCCmsxLShvYVEHwgb7(er1JTlsxhdU5P8xMmov8(_003Cresponse_003E5__2)));
									if (obj != null)
									{
										obj2 = DiFM0fsxS5gSHqPuLNIt(obj);
										goto IL_0165;
									}
									num3 = 14;
									if (true)
									{
										continue;
									}
									goto case 4;
								}
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 18:
									_003C_003Eu__2 = default;
									num3 = 2;
									continue;
								case 15:
									url = cogSocketRemoteDeviceApi.MakeAbsoluteUrlFromRelativeIfRequired(url);
									num3 = 12;
									continue;
								case 3:
								case 21:
									awaiter2 = configuredTaskAwaitable.GetAwaiter();
									num3 = 7;
									continue;
								case 1:
									awaiter = ((HttpContent)er1JTlsxhdU5P8xMmov8(_003Cresponse_003E5__2)).ReadAsStreamAsync().GetAwaiter();
									num3 = 17;
									if (!YgqYqqsN8uERUq47shDP())
									{
										continue;
									}
									goto case 9;
								case 9:
								case 19:
									_003Cresponse_003E5__2 = result3;
									num3 = 10;
									if (YgqYqqsN8uERUq47shDP())
									{
									}
									continue;
								case 12:
									request = new HttpRequestMessage((HttpMethod)at2ELrsNz2Hn2JiH44e4(), url);
									num3 = 0;
									continue;
								case 24:
									goto end_IL_021d;
									IL_0165:
									if (!qlsNYisxv5Sw5xk8i49Q(obj2, j0MhRGsxEJbFnJLIX92U(50562)))
									{
										break;
									}
									num3 = 5;
									if (k5ECYwsNJoVeOm93m3x3())
									{
										continue;
									}
									goto case 7;
									IL_02bd:
									result = awaiter.GetResult();
									num3 = 6;
									continue;
									IL_0299:
									result3 = awaiter2.GetResult();
									goto case 9;
								}
								result2 = result;
								break;
								continue;
								end_IL_021d:
								break;
							}
						}
						catch (Exception ex)
						{
							throw linuRvsxHnW8Gc01VwKN(j0MhRGsxEJbFnJLIX92U(55438), url, ex);
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
		internal static object at2ELrsNz2Hn2JiH44e4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HttpMethod.Get;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken HTqWFTsxwgWMW7crlAc9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XufabhsxssxwIgKFp6dD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EZvAFrLMah((HttpResponseMessage)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object er1JTlsxhdU5P8xMmov8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xdFCCmsxLShvYVEHwgb7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpContent)P_0).Headers;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FhWHH8sx9eGi655nfUIt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpContentHeaders)P_0).ContentType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DiFM0fsxS5gSHqPuLNIt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MediaTypeHeaderValue)P_0).MediaType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object j0MhRGsxEJbFnJLIX92U(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qlsNYisxv5Sw5xk8i49Q(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object linuRvsxHnW8Gc01VwKN(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aBRAxslGwf((string)P_0, (string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k5ECYwsNJoVeOm93m3x3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YgqYqqsN8uERUq47shDP()
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
	private struct _003CMakeHttpPostRequest_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		public int contentAt;

		public object[] args;

		public string url;

		public Stream dataStream;

		public string contentType;

		public TimeSpan timeout;

		private Stream _003CcopiedStream_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private Stream _003CresponseStream_003E5__4;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_04d8;
			IL_001a:
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			int num2 = default;
			Stream result3 = default;
			try
			{
				if ((uint)num2 > 2u)
				{
					_003CcopiedStream_003E5__2 = null;
					cogSocketRemoteDeviceApi.MpJozqTtll();
					if (contentAt < -1 || contentAt > args.Length)
					{
						throw new ArgumentOutOfRangeException((string)HUg9rtsxDddbfFUM1hgF(55478));
					}
					if (contentAt == -1)
					{
						contentAt = args.Length;
					}
				}
				try
				{
					ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter;
					if (num2 != 0)
					{
						if ((uint)(num2 - 1) <= 1u)
						{
							goto IL_01fd;
						}
						if (args.Length != 0)
						{
							string text = (string)yTCWmYsxURfXyE77OL7T(new JsonRemoteSerializer(), args);
							url = cogSocketRemoteDeviceApi.MakeAbsoluteUrlFromRelativeIfRequired(url);
							UriBuilder uriBuilder = new UriBuilder(url);
							NameValueCollection nameValueCollection = (NameValueCollection)hAiIM5sxdMfTWPdKRKCM(bV9difsxTEC1s7mm0yjy(uriBuilder));
							nameValueCollection[kgbOBx7BanbFa22Hp9.ol99ukmDA(55478)] = contentAt.ToString();
							opuaNvsxiaogb93sWX3b(nameValueCollection, kgbOBx7BanbFa22Hp9.ol99ukmDA(55500), text);
							uriBuilder.Query = nameValueCollection.ToString();
							url = uriBuilder.ToString();
						}
						HttpContent httpContent = null;
						if (dataStream != null)
						{
							httpContent = new StreamContent(dataStream);
							St4KprsxBPs36mTGcnZo(eL4oMlsxqNWqh7PGsjJs(httpContent), HUg9rtsxDddbfFUM1hgF(54612), contentType);
						}
						HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, url);
						LOdPtOsxjisPPkpVxeJE(httpRequestMessage, httpContent);
						CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(timeout);
						awaiter = cogSocketRemoteDeviceApi.lF0AJTy98J.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseHeadersRead, TV6uCTsxcefkEo22RQpj(cancellationTokenSource)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
					HttpResponseMessage result = awaiter.GetResult();
					_003Cresponse_003E5__3 = result;
					goto IL_01fd;
					IL_01fd:
					try
					{
						ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter awaiter2;
						if (num2 != 1)
						{
							if (num2 == 2)
							{
								goto IL_0296;
							}
							vUDJVIsx2L6vtpef8YkU(_003Cresponse_003E5__3);
							awaiter2 = ((HttpContent)tNKRxmsxWwhW8WVYWoNr(_003Cresponse_003E5__3)).ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
						}
						Stream result2 = awaiter2.GetResult();
						_003CresponseStream_003E5__4 = result2;
						goto IL_0296;
						IL_0296:
						try
						{
							int num3;
							if (num2 != 2)
							{
								num3 = 4;
								goto IL_03c6;
							}
							ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter3 = _003C_003Eu__3;
							goto IL_02ca;
							IL_02ca:
							_003C_003Eu__3 = default;
							num3 = 10;
							goto IL_03c6;
							IL_03c6:
							ConfiguredTaskAwaitable configuredTaskAwaitable = default;
							while (true)
							{
								switch (num3)
								{
								case 3:
									configuredTaskAwaitable = ((Task)pWm8Cfsx7gRNo9naUbmL(_003CresponseStream_003E5__4, _003CcopiedStream_003E5__2)).ConfigureAwait(false);
									num3 = 9;
									continue;
								case 5:
								case 7:
									break;
								case 11:
									_003C_003Eu__3 = awaiter3;
									_ = 1;
									num3 = (PHl4RQsxAqOCV1IthcJ4() ? 5 : 0);
									continue;
								case 1:
									if (!awaiter3.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									goto case 8;
								case 4:
									_003CcopiedStream_003E5__2 = new MemoryStream();
									num3 = 3;
									if (PHl4RQsxAqOCV1IthcJ4())
									{
									}
									continue;
								case 10:
									num2 = (_003C_003E1__state = -1);
									num3 = 8;
									if (PHl4RQsxAqOCV1IthcJ4())
									{
									}
									continue;
								case 9:
									awaiter3 = configuredTaskAwaitable.GetAwaiter();
									num3 = 1;
									if (PHl4RQsxAqOCV1IthcJ4())
									{
									}
									continue;
								case 8:
									awaiter3.GetResult();
									num3 = 12;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								case 0:
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								case 2:
									num2 = (_003C_003E1__state = 2);
									goto case 11;
								default:
									num3 = 11;
									if (!PHl4RQsxAqOCV1IthcJ4())
									{
										continue;
									}
									goto case 12;
								case 12:
									HYHepEsxtlyhkZeRaeIh(_003CcopiedStream_003E5__2, 0L);
									goto end_IL_03c6;
								}
								goto IL_02ca;
								continue;
								end_IL_03c6:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003CresponseStream_003E5__4 != null)
							{
								q9o8l8sxC2QfalTOPQRu(_003CresponseStream_003E5__4);
							}
						}
						_003CresponseStream_003E5__4 = null;
					}
					finally
					{
						if (num2 < 0 && _003Cresponse_003E5__3 != null)
						{
							q9o8l8sxC2QfalTOPQRu(_003Cresponse_003E5__3);
						}
					}
					_003Cresponse_003E5__3 = null;
				}
				catch (Exception ex)
				{
					throw ACelVXsxKWeeVKV9ddAT(HUg9rtsxDddbfFUM1hgF(55520), url, ex);
				}
				result3 = _003CcopiedStream_003E5__2;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CcopiedStream_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_04fd;
			IL_04d8:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					goto IL_04fd;
				case 0:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 4:
				case 6:
					_003C_003Et__builder.SetResult(result3);
					num = 7;
					continue;
				case 3:
				case 5:
					_003CcopiedStream_003E5__2 = null;
					goto case 4;
				case 2:
					cogSocketRemoteDeviceApi = _003C_003E4__this;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_04fd:
			_ = 1;
			num = (PHl4RQsxAqOCV1IthcJ4() ? 6 : 5);
			goto IL_04d8;
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
		internal static object HUg9rtsxDddbfFUM1hgF(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yTCWmYsxURfXyE77OL7T(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((JsonRemoteSerializer)P_0).Serialize(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bV9difsxTEC1s7mm0yjy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UriBuilder)P_0).Query;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hAiIM5sxdMfTWPdKRKCM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HttpUtility.ParseQueryString((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void opuaNvsxiaogb93sWX3b(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((NameValueCollection)P_0)[(string)P_1] = (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eL4oMlsxqNWqh7PGsjJs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpContent)P_0).Headers;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void St4KprsxBPs36mTGcnZo(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpHeaders)P_0).Add((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LOdPtOsxjisPPkpVxeJE(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpRequestMessage)P_0).Content = (HttpContent)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken TV6uCTsxcefkEo22RQpj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vUDJVIsx2L6vtpef8YkU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EZvAFrLMah((HttpResponseMessage)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tNKRxmsxWwhW8WVYWoNr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pWm8Cfsx7gRNo9naUbmL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Stream)P_0).CopyToAsync((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HYHepEsxtlyhkZeRaeIh(object P_0, long P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Position = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void q9o8l8sxC2QfalTOPQRu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ACelVXsxKWeeVKV9ddAT(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aBRAxslGwf((string)P_0, (string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AQtYkXsxVNRjJtyZBCaL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PHl4RQsxAqOCV1IthcJ4()
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
	private struct _003CMakeHttpPutRequest_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		public Stream dataStream;

		public string contentType;

		public string url;

		public TimeSpan timeout;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			TaskAwaiter<Stream> awaiter = default;
			TaskAwaiter<HttpResponseMessage> awaiter2 = default;
			StreamContent streamContent = default;
			Stream result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						if ((uint)num2 > 1u)
						{
							cogSocketRemoteDeviceApi.MpJozqTtll();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 9;
								}
								else
								{
									awaiter = _003C_003Eu__2;
									num3 = 7;
								}
								goto IL_00e7;
							}
							awaiter2 = _003C_003Eu__1;
							goto IL_00c9;
							IL_00e7:
							while (true)
							{
								switch (num3)
								{
								case 1:
								{
									HttpResponseMessage result = awaiter2.GetResult();
									MgTEI5sx3SbOqK1DZmOA(result);
									awaiter = ((HttpContent)PDyXCBsxOFCF8MPQhBdY(result)).ReadAsStreamAsync().GetAwaiter();
									num3 = 18;
									if (!xbZLxUsxor2c1okx2vVl())
									{
										continue;
									}
									goto case 2;
								}
								case 2:
									_003C_003Eu__2 = awaiter;
									num3 = 6;
									continue;
								case 3:
								case 10:
								{
									HttpRequestMessage httpRequestMessage = new HttpRequestMessage((HttpMethod)W6Q2c4sxxFadxkLgC8Uc(), url);
									Jx9O2Csx1DaxByJh97eX(httpRequestMessage, streamContent);
									CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(timeout);
									awaiter2 = cogSocketRemoteDeviceApi.lF0AJTy98J.SendAsync(httpRequestMessage, GVyF9nsxr4HGYyAl70SB(cancellationTokenSource)).GetAwaiter();
									num3 = 13;
									continue;
								}
								case 8:
								case 16:
									break;
								default:
									num3 = 4;
									continue;
								case 0:
									url = cogSocketRemoteDeviceApi.MakeAbsoluteUrlFromRelativeIfRequired(url);
									Uc9hfWsx5OtnHu9bdakU();
									if (!xbZLxUsxor2c1okx2vVl())
									{
										num3 = 10;
										if (!xbZLxUsxor2c1okx2vVl())
										{
											continue;
										}
										goto case 13;
									}
									num3 = 16;
									continue;
								case 13:
									if (awaiter2.IsCompleted)
									{
										goto case 1;
									}
									num3 = 17;
									if (Uc9hfWsx5OtnHu9bdakU())
									{
										continue;
									}
									goto case 18;
								case 18:
									if (!awaiter.IsCompleted)
									{
										num3 = 15;
										continue;
									}
									goto case 19;
								case 14:
									return;
								case 11:
									return;
								case 4:
									goto IL_01de;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 11;
									continue;
								case 7:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 19;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								case 5:
									rlBc3msxNdevj4ELvcxf(ckmXvnsxPNx4fE6E13Ow(streamContent), inpOxisxYb29HFn5hs7R(54612), contentType);
									num3 = 0;
									if (0 == 0)
									{
										continue;
									}
									goto case 15;
								case 15:
									num2 = (_003C_003E1__state = 1);
									num3 = 2;
									continue;
								case 9:
									streamContent = new StreamContent(dataStream);
									num3 = 5;
									continue;
								case 12:
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 14;
									continue;
								case 17:
									num2 = (_003C_003E1__state = 0);
									num3 = 12;
									continue;
								case 19:
									result2 = awaiter.GetResult();
									goto end_IL_0026;
								}
								break;
							}
							goto IL_00c9;
							IL_01de:
							num2 = (_003C_003E1__state = -1);
							num3 = 1;
							goto IL_00e7;
							IL_00c9:
							_003C_003Eu__1 = default;
							goto IL_01de;
							end_IL_0026:;
						}
						catch (Exception ex)
						{
							throw l7uU06sxMLCPuuXtam5L(kgbOBx7BanbFa22Hp9.ol99ukmDA(55562), url, ex);
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
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
					num2 = _003C_003E1__state;
					xbZLxUsxor2c1okx2vVl();
					num = ((!Uc9hfWsx5OtnHu9bdakU()) ? 4 : 5);
					continue;
				case 1:
				case 5:
					cogSocketRemoteDeviceApi = _003C_003E4__this;
					goto case 2;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result2);
				num = 6;
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
		internal static object ckmXvnsxPNx4fE6E13Ow(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpContent)P_0).Headers;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object inpOxisxYb29HFn5hs7R(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rlBc3msxNdevj4ELvcxf(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpHeaders)P_0).Add((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object W6Q2c4sxxFadxkLgC8Uc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HttpMethod.Put;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Jx9O2Csx1DaxByJh97eX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpRequestMessage)P_0).Content = (HttpContent)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken GVyF9nsxr4HGYyAl70SB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MgTEI5sx3SbOqK1DZmOA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EZvAFrLMah((HttpResponseMessage)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PDyXCBsxOFCF8MPQhBdY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object l7uU06sxMLCPuuXtam5L(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aBRAxslGwf((string)P_0, (string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Uc9hfWsx5OtnHu9bdakU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xbZLxUsxor2c1okx2vVl()
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
	private struct _003CAddListener_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		public string eventName;

		public CogSocketEventHandler listener;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (pieZDnsxlYYHPxX1DU0Z())
			{
				goto IL_001e;
			}
			goto IL_01dc;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01dc;
			IL_01dc:
			int num2 = default;
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			ConfiguredTaskAwaitable<object> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						if (num2 != 0)
						{
							cogSocketRemoteDeviceApi.MpJozqTtll();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								configuredTaskAwaitable = cogSocketRemoteDeviceApi.Fy4A4Qq83n.AddListener(eventName, listener).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 0;
								if (pieZDnsxlYYHPxX1DU0Z())
								{
									goto IL_014e;
								}
							}
							goto IL_0087;
							IL_00cc:
							num2 = (_003C_003E1__state = 0);
							num3 = 3;
							if (!pieZDnsxlYYHPxX1DU0Z())
							{
								goto IL_0087;
							}
							goto IL_00e5;
							IL_014e:
							if (!awaiter.IsCompleted)
							{
								goto IL_00cc;
							}
							goto IL_0188;
							IL_0087:
							while (true)
							{
								switch (num3)
								{
								case 3:
									_003C_003Eu__1 = awaiter;
									goto IL_00fa;
								default:
									num3 = 7;
									if (pieZDnsxlYYHPxX1DU0Z())
									{
									}
									continue;
								case 2:
								case 9:
									break;
								case 6:
									goto IL_00e5;
								case 7:
									goto IL_00fa;
								case 0:
									_003C_003Eu__1 = default;
									num3 = 6;
									if (pieZDnsxlYYHPxX1DU0Z())
									{
									}
									continue;
								case 4:
									return;
								case 1:
								case 8:
									goto IL_014e;
								case 5:
									goto IL_016a;
								case 10:
									goto IL_0188;
								}
								break;
								IL_016a:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								_ = 0;
								num3 = (FyxCMIsxQJEj9ImheVQ0() ? 8 : 9);
							}
							goto IL_00cc;
							IL_0188:
							awaiter.GetResult();
							goto end_IL_0040;
							IL_00fa:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 4;
							goto IL_0087;
							IL_00e5:
							num2 = (_003C_003E1__state = -1);
							num3 = 10;
							if (0 == 0)
							{
								goto IL_0087;
							}
							goto IL_00fa;
							end_IL_0040:;
						}
						catch (Exception ex)
						{
							throw Xsdp6msxefTOdNEBjLsm(ex, eventName);
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
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					cogSocketRemoteDeviceApi = _003C_003E4__this;
					FyxCMIsxQJEj9ImheVQ0();
					if (pieZDnsxlYYHPxX1DU0Z())
					{
						num = 4;
						if (true)
						{
							continue;
						}
						goto case 5;
					}
					num = 0;
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
		internal static object Xsdp6msxefTOdNEBjLsm(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bbIA1LrvjR((Exception)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FyxCMIsxQJEj9ImheVQ0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pieZDnsxlYYHPxX1DU0Z()
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
	private struct _003CRemoveListener_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		public string eventName;

		public CogSocketEventHandler listener;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oxZiS9sxu79ftjXsRIHX();
			int num;
			if (!lQM4vasxI7jiSrunhJm7())
			{
				num = 2;
				if (lQM4vasxI7jiSrunhJm7())
				{
				}
			}
			else
			{
				num = 4;
			}
			int num2 = default;
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			ConfiguredTaskAwaitable<object> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 5:
					try
					{
						if (num2 != 0)
						{
							cogSocketRemoteDeviceApi.MpJozqTtll();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								configuredTaskAwaitable = cogSocketRemoteDeviceApi.Fy4A4Qq83n.RemoveListener(eventName, listener).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 4;
								if (1 == 0)
								{
									goto IL_0084;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 0;
								if (lQM4vasxI7jiSrunhJm7())
								{
									goto IL_0157;
								}
							}
							goto IL_00ed;
							IL_0157:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 8;
							goto IL_00ed;
							IL_00ed:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 9:
									if (!awaiter.IsCompleted)
									{
										goto IL_00a2;
									}
									goto case 10;
								case 0:
									_003C_003Eu__1 = default;
									goto case 1;
								case 3:
									_003C_003Eu__1 = awaiter;
									goto IL_0157;
								default:
									num3 = 5;
									continue;
								case 1:
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 8:
									return;
								case 5:
									goto IL_0157;
								case 2:
								case 6:
									num2 = (_003C_003E1__state = 0);
									num3 = 3;
									if (true)
									{
										continue;
									}
									goto case 10;
								case 10:
									awaiter.GetResult();
									goto end_IL_0054;
								}
								break;
								IL_00a2:
								_ = 1;
								num3 = (lQM4vasxI7jiSrunhJm7() ? 1 : 6);
							}
							goto IL_0084;
							IL_0084:
							awaiter = configuredTaskAwaitable.GetAwaiter();
							num3 = 9;
							goto IL_00ed;
							end_IL_0054:;
						}
						catch (Exception ex)
						{
							throw bbIA1LrvjR(ex, eventName);
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
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 4:
					cogSocketRemoteDeviceApi = _003C_003E4__this;
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
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
		internal static bool oxZiS9sxu79ftjXsRIHX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lQM4vasxI7jiSrunhJm7()
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
	private struct _003CDelayedTask_003Ed__42<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public TimeSpan delay;

		public Task<T> task;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<T> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 4 : 3);
			int num2 = default;
			TaskAwaiter<T> awaiter = default;
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2 = default;
			ConfiguredTaskAwaitable configuredTaskAwaitable = default;
			T result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_0067;
							}
							_ = 0;
							num3 = ((1 == 0) ? 15 : 7);
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 11;
						}
						goto IL_0172;
						IL_0067:
						_003C_003Eu__2 = default;
						num3 = 1;
						goto IL_0172;
						IL_0172:
						while (true)
						{
							switch (num3)
							{
							case 8:
								awaiter2.GetResult();
								num3 = 6;
								continue;
							case 12:
							case 15:
								break;
							case 9:
								return;
							case 11:
								_003C_003Eu__1 = default;
								num3 = 14;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 6:
								awaiter = task.GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 13;
									continue;
								}
								goto case 16;
							case 4:
								_003C_003Eu__1 = awaiter2;
								num3 = 3;
								continue;
							case 2:
								awaiter2 = configuredTaskAwaitable.GetAwaiter();
								num3 = 10;
								continue;
							case 0:
							case 7:
								configuredTaskAwaitable = Task.Delay(delay).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 2;
								continue;
							case 14:
								num2 = (_003C_003E1__state = -1);
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 13:
								_003C_003Eu__2 = awaiter;
								num3 = 5;
								continue;
							case 10:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									continue;
								}
								goto case 8;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 16:
								result = awaiter.GetResult();
								goto end_IL_0172;
							}
							goto IL_0067;
							continue;
							end_IL_0172:
							break;
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
					num = 2;
					continue;
				case 2:
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 5;
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
		internal static bool s7kcncsxROIA6SmAao7r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jo1K9dsxa7UHuSqfKBNd()
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
	private struct _003CCloneAndConnect_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IRemoteDeviceApi> _003C_003Et__builder;

		public CogSocketRemoteDeviceApi _003C_003E4__this;

		private IRemoteDeviceApi _003Csecondary_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sxMoHIsxnVF1LYJNhIXP();
			int num = (H6UHNksxGLUmmGkmXB6d() ? 1 : 3);
			CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			IRemoteDeviceApi result = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					cogSocketRemoteDeviceApi = _003C_003E4__this;
					goto case 1;
				case 5:
					_003Csecondary_003E5__2 = null;
					num = 4;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 6;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Csecondary_003E5__2 = (IRemoteDeviceApi)jnRfWVsxXL3VoroY7cEl(cogSocketRemoteDeviceApi);
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								if (H6UHNksxGLUmmGkmXB6d())
								{
								}
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									sxMoHIsxnVF1LYJNhIXP();
									if (!H6UHNksxGLUmmGkmXB6d())
									{
										num3 = 9;
										if (!sxMoHIsxnVF1LYJNhIXP())
										{
											return;
										}
									}
									else
									{
										num3 = 5;
									}
									continue;
								}
								goto case 1;
							case 7:
								return;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 1:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 2:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 3:
								awaiter = DX2JFosx6W4BbFFrS6Sm(FCYPLjsxbbjycL76uIFi(_003Csecondary_003E5__2));
								num3 = 0;
								continue;
							case 10:
								result = _003Csecondary_003E5__2;
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csecondary_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					break;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
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
		internal static object jnRfWVsxXL3VoroY7cEl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRemoteDeviceApi)P_0).Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FCYPLjsxbbjycL76uIFi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRemoteDeviceApi)P_0).Connect();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DX2JFosx6W4BbFFrS6Sm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sxMoHIsxnVF1LYJNhIXP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H6UHNksxGLUmmGkmXB6d()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private static readonly FeatureFlag<int> KuhAhHKpLF;

	internal static bool ShouldPutPathsInExceptions;

	private CogSocket Fy4A4Qq83n;

	private string GKFAl5REfU;

	private string KXmAg1y2gG;

	private string QIxAqRuxfs;

	private readonly string r6VATNHN6f;

	private string wuFABNjXCB;

	private HttpClient lF0AJTy98J;

	private volatile int T5YAM0cbZb;

	public bool IsDisposed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Fy4A4Qq83n == null;
		}
	}

	public event EventHandler Closed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ml1nGYujISH93a3Upcr(Fy4A4Qq83n, value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qXlI0KucKYRCCpvNsZW(Fy4A4Qq83n, value);
		}
	}

	public event EventHandler<MessagePayloadPreviewEventArgs> PreviewMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Fy4A4Qq83n.PreviewMessage += value;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Fy4A4Qq83n.PreviewMessage -= value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private static FeatureFlag<int> beOAOHyUeJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return KuhAhHKpLF;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CogSocketRemoteDeviceApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SUJBPiuv1tvOOGOfpgT();
		int num = (TFXSsquE60tHHCmUmsl() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				ShouldPutPathsInExceptions = false;
				num = 5;
				break;
			case 0:
			case 1:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 3;
				if (SUJBPiuv1tvOOGOfpgT())
				{
				}
				break;
			case 3:
			{
				FeatureDescriptor featureDescriptor = new FeatureDescriptor();
				CZDpXluHBlLd4kBKwaO(featureDescriptor, kgbOBx7BanbFa22Hp9.ol99ukmDA(36874));
				M8Jf8fuAGyQrJNi2HdE(featureDescriptor, bdS2pquVJsTDn2ZcR9a(36950));
				featureDescriptor.DefaultValue = 3000;
				KuhAhHKpLF = FeatureRegistry.RegisterFeature<int>(featureDescriptor);
				goto default;
			}
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketRemoteDeviceApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Ghfg4huDGJetX14rOja();
		this._002Ector(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketRemoteDeviceApi(string connectionToken)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TFXSsquE60tHHCmUmsl();
		int num;
		if (!SUJBPiuv1tvOOGOfpgT())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (!TFXSsquE60tHHCmUmsl())
			{
				goto IL_0073;
			}
		}
		goto IL_0040;
		IL_0073:
		Ghfg4huDGJetX14rOja();
		num = 3;
		if (TFXSsquE60tHHCmUmsl())
		{
			goto IL_0040;
		}
		goto IL_0088;
		IL_0088:
		r6VATNHN6f = connectionToken;
		num = 5;
		if (1 == 0)
		{
			return;
		}
		goto IL_0040;
		IL_0040:
		switch (num)
		{
		case 3:
			UNXdnJuU8yk8sI9XCA1(this);
			goto IL_0088;
		case 0:
		case 1:
			break;
		default:
			goto IL_0088;
		case 5:
			return;
		}
		goto IL_0073;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CogSocket rpvoZoMunr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		Uri uri = default;
		string text = default;
		X509CertificateCollection clientCerts = default;
		X509Certificate2 x509Certificate = default;
		string empty = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				uri = new Uri(text, UriKind.RelativeOrAbsolute);
				num = 8;
				break;
			case 1:
				clientCerts = new X509CertificateCollection(new X509Certificate[1] { x509Certificate });
				num = 11;
				break;
			case 5:
			case 6:
				empty = string.Empty;
				num = 7;
				break;
			case 3:
				text = KXmAg1y2gG;
				num = 10;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			{
				UriBuilder uriBuilder = new UriBuilder(uri);
				NameValueCollection nameValueCollection = HttpUtility.ParseQueryString((string)JcqXMUuTZqHMMdKn3WC(uriBuilder));
				yyfMs7udpZsyFHDKqIO(nameValueCollection, bdS2pquVJsTDn2ZcR9a(37088), r6VATNHN6f);
				nameValueCollection.Add(kgbOBx7BanbFa22Hp9.ol99ukmDA(37122), wuFABNjXCB);
				uriBuilder.Query = nameValueCollection.ToString();
				uri = uriBuilder.Uri;
				_ = 0;
				if (TFXSsquE60tHHCmUmsl())
				{
					num = 0;
					if (!SUJBPiuv1tvOOGOfpgT())
					{
						break;
					}
					goto case 7;
				}
				num = 5;
				break;
			}
			case 7:
				x509Certificate = new X509Certificate2((byte[])fWyE43uqklOcy83YxD0(), empty);
				num = 1;
				if (TFXSsquE60tHHCmUmsl())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				text = uri.ToString();
				goto case 9;
			default:
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 8;
			case 8:
				if (r6VATNHN6f != null)
				{
					num = 2;
					break;
				}
				goto case 9;
			case 9:
				if (((string)M56wjTuiuvXyS2SRjrJ(uri)).Equals((string)bdS2pquVJsTDn2ZcR9a(37134), StringComparison.Ordinal))
				{
					goto case 5;
				}
				return new CogSocket(text, new JsonRemoteSerializer());
			case 11:
				return new CogSocket(text, new JsonRemoteSerializer(), clientCerts);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(string wssUri, string httpUri, string username = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SUJBPiuv1tvOOGOfpgT();
		int num;
		if (TFXSsquE60tHHCmUmsl())
		{
			num = 2;
		}
		else
		{
			num = 7;
			if (1 == 0)
			{
				goto IL_006d;
			}
		}
		goto IL_00d6;
		IL_006d:
		Uri result = default;
		if (!Uri.TryCreate(httpUri, UriKind.Absolute, out result))
		{
			goto IL_0039;
		}
		num = 5;
		goto IL_00d6;
		IL_0039:
		lF0AJTy98J = Eclo87TjlZ(GKFAl5REfU);
		num = 10;
		goto IL_00d6;
		IL_00d6:
		while (true)
		{
			switch (num)
			{
			case 6:
				wuFABNjXCB = username;
				num = 8;
				continue;
			case 3:
				break;
			case 0:
			case 2:
				if (wssUri == null)
				{
					goto case 1;
				}
				KXmAg1y2gG = wssUri;
				num = 4;
				if (TFXSsquE60tHHCmUmsl())
				{
					continue;
				}
				return;
			case 9:
				goto IL_006d;
			case 4:
				QIxAqRuxfs = httpUri;
				num = 6;
				continue;
			case 5:
				GKFAl5REfU = result.GetComponents(UriComponents.StrongAuthority | UriComponents.Scheme, UriFormat.Unescaped);
				num = 3;
				if (!SUJBPiuv1tvOOGOfpgT())
				{
					continue;
				}
				goto case 8;
			case 8:
				Fy4A4Qq83n = rpvoZoMunr();
				goto IL_006d;
			default:
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 7:
				throw new ArgumentNullException((string)bdS2pquVJsTDn2ZcR9a(37144));
			case 10:
				return;
			}
			break;
		}
		goto IL_0039;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRemoteDeviceApi IRemoteDeviceApi.Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = new CogSocketRemoteDeviceApi(r6VATNHN6f);
		cogSocketRemoteDeviceApi.Initialize(KXmAg1y2gG, QIxAqRuxfs);
		return cogSocketRemoteDeviceApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnect_003Ed__17))]
	public Task Connect()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CConnect_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (TFXSsquE60tHHCmUmsl())
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder = m2lDGLuBnkdcShjBMJj();
				SUJBPiuv1tvOOGOfpgT();
				num = ((!TFXSsquE60tHHCmUmsl()) ? 5 : 0);
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 6:
				u78VP5u2s3ZNanrbHx8(Fy4A4Qq83n);
				num = 1;
				break;
			case 2:
			case 3:
				if (lF0AJTy98J != null)
				{
					goto default;
				}
				return;
			case 7:
				lF0AJTy98J = null;
				num = 8;
				if (TFXSsquE60tHHCmUmsl())
				{
					break;
				}
				goto case 0;
			case 0:
				if (Fy4A4Qq83n != null)
				{
					num = 6;
					break;
				}
				goto case 2;
			default:
				BmknLIuWpMXHdEyQF8f(lF0AJTy98J);
				num = 7;
				break;
			case 1:
				Fy4A4Qq83n = null;
				SUJBPiuv1tvOOGOfpgT();
				num = (TFXSsquE60tHHCmUmsl() ? 2 : 5);
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAsync_003Ed__27<>))]
	public Task<T> GetAsync<T>(string path)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAsync_003Ed__27<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.path = path;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostAsync_003Ed__28<>))]
	public Task<T> PostAsync<T>(string path, params object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPostAsync_003Ed__28<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.path = path;
		stateMachine.args = args;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> PostAsync<T>(string path, RequestOptions options, params object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MpJozqTtll();
		try
		{
			int num = Convert.ToInt32(options.ResponseTimeout.Value.TotalMilliseconds);
			if (num > 45000)
			{
				lock (Fy4A4Qq83n)
				{
					T5YAM0cbZb = num;
				}
			}
			Task<T> task = OKZAPXQYlW(Fy4A4Qq83n.PostAsync(path, args, options).ToTypedTask<T>());
			if (num > 45000)
			{
				task.ContinueWith([MethodImpl(MethodImplOptions.NoInlining)] (Task<T> P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					lock (Fy4A4Qq83n)
					{
						T5YAM0cbZb = 0;
					}
				});
			}
			return task;
		}
		catch (Exception ex)
		{
			throw bbIA1LrvjR(ex, path);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPutAsync_003Ed__31<>))]
	public Task<T> PutAsync<T>(string path, object arg)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPutAsync_003Ed__31<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.path = path;
		stateMachine.arg = arg;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMakeHttpGetRequest_003Ed__32))]
	public Task<Stream> MakeHttpGetRequest(string url, TimeSpan timeout)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CMakeHttpGetRequest_003Ed__32 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.timeout = timeout;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Stream> MakeHttpPostRequest(string url, TimeSpan timeout, string contentType, Stream dataStream)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MakeHttpPostRequest(url, timeout, contentType, dataStream, 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMakeHttpPostRequest_003Ed__34))]
	public Task<Stream> MakeHttpPostRequest(string url, TimeSpan timeout, string contentType, Stream dataStream, int contentAt, params object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CMakeHttpPostRequest_003Ed__34 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.timeout = timeout;
		stateMachine.contentType = contentType;
		stateMachine.dataStream = dataStream;
		stateMachine.contentAt = contentAt;
		stateMachine.args = args;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMakeHttpPutRequest_003Ed__35))]
	public Task<Stream> MakeHttpPutRequest(string url, TimeSpan timeout, string contentType, Stream dataStream)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CMakeHttpPutRequest_003Ed__35 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.timeout = timeout;
		stateMachine.contentType = contentType;
		stateMachine.dataStream = dataStream;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HttpClient Eclo87TjlZ(string P_0 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		HttpClient httpClient = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				c8Vv8suCPUVE6PTkFtV(httpClient, CvsCogSocketAcq3DLineScan.HttpImage3DTimeout);
				num = 7;
				break;
			case 6:
				if (r6VATNHN6f == null)
				{
					goto case 0;
				}
				_ = 0;
				if (TFXSsquE60tHHCmUmsl())
				{
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				num = 0;
				break;
			case 1:
			case 2:
				PB0VMlutKRncpMkNLoI(UGhNWTu7NS9wf2xyjc9(httpClient), kgbOBx7BanbFa22Hp9.ol99ukmDA(37160), r6VATNHN6f);
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
				httpClient = HttpClientHelper.CreateHttpClient(new Uri(P_0));
				num = 6;
				break;
			case 3:
				PB0VMlutKRncpMkNLoI(httpClient.DefaultRequestHeaders, bdS2pquVJsTDn2ZcR9a(37226), wuFABNjXCB);
				goto case 0;
			case 7:
				return httpClient;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddListener_003Ed__37))]
	public Task AddListener(string eventName, CogSocketEventHandler listener)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TFXSsquE60tHHCmUmsl();
		int num;
		if (!SUJBPiuv1tvOOGOfpgT())
		{
			num = 7;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0086;
		IL_002a:
		_003CAddListener_003Ed__37 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 8;
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 5:
				stateMachine.eventName = eventName;
				goto case 1;
			case 1:
			case 3:
				stateMachine.listener = listener;
				goto case 6;
			default:
				num = 6;
				continue;
			case 0:
			case 7:
				stateMachine._003C_003Et__builder = m2lDGLuBnkdcShjBMJj();
				num = 2;
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (TFXSsquE60tHHCmUmsl())
				{
					continue;
				}
				goto case 8;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveListener_003Ed__38))]
	public Task RemoveListener(string eventName, CogSocketEventHandler listener = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRemoveListener_003Ed__38 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine.eventName = eventName;
				goto case 3;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 3:
			case 7:
				stateMachine.listener = listener;
				goto case 6;
			default:
				num = 6;
				break;
			case 0:
				stateMachine._003C_003Et__builder = m2lDGLuBnkdcShjBMJj();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = ((!SUJBPiuv1tvOOGOfpgT()) ? 4 : 7);
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MpJozqTtll()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (IsDisposed)
		{
			throw new CvsNotConnectedException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string MakeAbsoluteUrlFromRelativeIfRequired(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!Uri.TryCreate(url, UriKind.Absolute, out var result) && Uri.TryCreate(url, UriKind.Relative, out result))
		{
			return (string)zj2b7IuKNU4nFR9sVEQ(bdS2pquVJsTDn2ZcR9a(3880), GKFAl5REfU, url);
		}
		return url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<ylrOBr68OZVQVqBmJY> OKZAPXQYlW<ylrOBr68OZVQVqBmJY>(Task<ylrOBr68OZVQVqBmJY> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!beOAOHyUeJ().IsEnabled)
		{
			return P_0;
		}
		return oJsAI7CEWt(P_0, TimeSpan.FromMilliseconds(beOAOHyUeJ().Value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDelayedTask_003Ed__42<>))]
	private Task<k32BuOe5rOSZNoxGWs> oJsAI7CEWt<k32BuOe5rOSZNoxGWs>(Task<k32BuOe5rOSZNoxGWs> P_0, TimeSpan P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDelayedTask_003Ed__42<k32BuOe5rOSZNoxGWs> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<k32BuOe5rOSZNoxGWs>.Create();
		stateMachine.task = P_0;
		stateMachine.delay = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Exception bbIA1LrvjR(Exception P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (SUJBPiuv1tvOOGOfpgT())
		{
			goto IL_001e;
		}
		goto IL_0052;
		IL_0052:
		Exception ex2 = default;
		CogSocketErrorResponseReceivedException ex = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 4;
				if (TFXSsquE60tHHCmUmsl())
				{
					continue;
				}
				goto IL_008f;
			case 4:
			case 7:
				goto IL_008f;
			case 6:
				goto IL_00a3;
			case 8:
				ex2.Data[CvsErrorResponseNetworkException.DataPathKey] = P_1;
				num = 9;
				continue;
			case 0:
			case 1:
				if (ex == null)
				{
					ex2 = new CvsNetworkException(P_0);
					goto IL_008f;
				}
				goto case 2;
			case 2:
			case 5:
				ex2 = new CvsErrorResponseNetworkException(Ael4ocu5w8U9gcvcJRP(ex), pYsiI4uoyiChLxk4Q9M(ex), P_0);
				num = 7;
				continue;
			case 9:
				goto IL_0112;
			}
			break;
			IL_00a3:
			ex = P_0 as CogSocketErrorResponseReceivedException;
			TFXSsquE60tHHCmUmsl();
			num = (SUJBPiuv1tvOOGOfpgT() ? 5 : 0);
		}
		goto IL_001e;
		IL_0112:
		return ex2;
		IL_008f:
		if (ShouldPutPathsInExceptions)
		{
			num = 3;
			goto IL_0052;
		}
		goto IL_0112;
		IL_001e:
		if (P_1 != null)
		{
			num = 8;
			if (TFXSsquE60tHHCmUmsl())
			{
				goto IL_0052;
			}
			goto IL_008f;
		}
		goto IL_0112;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsNetworkException aBRAxslGwf(string P_0, string P_1, Exception P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsNetworkException ex = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (ex != null)
				{
					num = 3;
					break;
				}
				if (P_2 is TaskCanceledException)
				{
					num = 7;
					break;
				}
				return new CvsNetworkException(P_2);
			case 4:
				text = (string)LGoD6auYxsLa6qc3jEx(bdS2pquVJsTDn2ZcR9a(37268), P_0, P_1, UfEYj6uPPFbS9Imn41W(P_2));
				TFXSsquE60tHHCmUmsl();
				if (!SUJBPiuv1tvOOGOfpgT())
				{
					num = 6;
					break;
				}
				num = 0;
				if (true)
				{
					break;
				}
				goto case 0;
			case 3:
				return ex;
			case 1:
			case 6:
				AqbAbm4bHM(P_2, text);
				goto case 0;
			case 0:
			case 2:
				ex = P_2 as CvsNetworkException;
				goto case 5;
			default:
				num = 5;
				break;
			case 7:
				return new CvsNetworkException((string)icqYHguN4bcdJAxNna5(), P_2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void EZvAFrLMah(HttpResponseMessage P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			P_0.EnsureSuccessStatusCode();
		}
		catch (HttpRequestException innerException)
		{
			throw new CvsHttpNetworkException((string)YF1a8ju10INTebsKL2H(kgbOBx7BanbFa22Hp9.ol99ukmDA(37298), JeQcY5uxTewn4JrJSQb(P_0).ToString()), JeQcY5uxTewn4JrJSQb(P_0), innerException);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AqbAbm4bHM(Exception P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsTraceSDK.Error.TraceMessage(P_1);
		T8VbxburT2tmuVoDbMq(CvsTraceSDK.Error, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCloneAndConnect_003Ed__47))]
	public Task<IRemoteDeviceApi> CloneAndConnect()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCloneAndConnect_003Ed__47 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IRemoteDeviceApi>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void GIoAamKpRA<ccbCTsGwVbXYHfjgRF>(Task<ccbCTsGwVbXYHfjgRF> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lock (Fy4A4Qq83n)
		{
			T5YAM0cbZb = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CZDpXluHBlLd4kBKwaO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Id = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bdS2pquVJsTDn2ZcR9a(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M8Jf8fuAGyQrJNi2HdE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Description = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TFXSsquE60tHHCmUmsl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SUJBPiuv1tvOOGOfpgT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ghfg4huDGJetX14rOja()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UNXdnJuU8yk8sI9XCA1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JcqXMUuTZqHMMdKn3WC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UriBuilder)P_0).Query;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yyfMs7udpZsyFHDKqIO(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((NameValueCollection)P_0).Add((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M56wjTuiuvXyS2SRjrJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Uri)P_0).Scheme;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fWyE43uqklOcy83YxD0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rootCA;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder m2lDGLuBnkdcShjBMJj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ml1nGYujISH93a3Upcr(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CogSocket)P_0).Closed += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qXlI0KucKYRCCpvNsZW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CogSocket)P_0).Closed -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u78VP5u2s3ZNanrbHx8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CogSocket)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BmknLIuWpMXHdEyQF8f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((HttpMessageInvoker)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UGhNWTu7NS9wf2xyjc9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((HttpClient)P_0).DefaultRequestHeaders;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PB0VMlutKRncpMkNLoI(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((HttpHeaders)P_0).Add((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c8Vv8suCPUVE6PTkFtV(object P_0, TimeSpan P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((HttpClient)P_0).Timeout = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zj2b7IuKNU4nFR9sVEQ(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Ael4ocu5w8U9gcvcJRP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CogSocketErrorResponseReceivedException)P_0).ErrorCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pYsiI4uoyiChLxk4Q9M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CogSocketErrorResponseReceivedException)P_0).AdditionalData;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UfEYj6uPPFbS9Imn41W(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LGoD6auYxsLa6qc3jEx(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object icqYHguN4bcdJAxNna5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OperationCanceledAfterTimeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HttpStatusCode JeQcY5uxTewn4JrJSQb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((HttpResponseMessage)P_0).StatusCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YF1a8ju10INTebsKL2H(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T8VbxburT2tmuVoDbMq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceException((Exception)P_1);
	}
}
