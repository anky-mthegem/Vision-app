using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.Diagnostics.Logging;
using Cognex.Explorer.Diagnostics;
using Cognex.InSight.Internal;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal static class PostImageHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPostImageByHTTPAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public IRemoteDeviceApi deviceApi;

		public string connectionIDFunctionName;

		public string url;

		public Bitmap bmp;

		public bool useSystemDebug;

		public ILogger logger;

		public StreamLogger streamLogger;

		public TimeSpan httpPostTimeout;

		public string imageName;

		public bool sync;

		private bool _003ClogPostOutput_003E5__2;

		private MemoryStream _003CdataStream_003E5__3;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			K0vyBgsSRsFOv5v15l89();
			int num = (bgoD8nsSaUluMNAy8SKB() ? 4 : 3);
			int num2 = default;
			Stream stream = default;
			TaskAwaiter<Stream> awaiter = default;
			Stream result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					if (bgoD8nsSaUluMNAy8SKB())
					{
					}
					continue;
				case 1:
					try
					{
						if (num2 != 0)
						{
							hUgIvOsSn6a6Pgj1HKiT(deviceApi, connectionIDFunctionName, url, bmp);
							stream = null;
						}
						try
						{
							if (num2 != 0)
							{
								LogHttpPost(url, kgbOBx7BanbFa22Hp9.ol99ukmDA(49094), (string)TBE9BSsSGee7O55QOUNW(8974), useSystemDebug, this.logger, connectionIDFunctionName);
								_003ClogPostOutput_003E5__2 = streamLogger?.CanLogStream ?? false;
								_003CdataStream_003E5__3 = new MemoryStream();
							}
							try
							{
								int num3;
								if (num2 != 0)
								{
									bmp.Save(_003CdataStream_003E5__3, ImageFormat.Bmp);
									num3 = 10;
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
										num3 = 7;
										if (!bgoD8nsSaUluMNAy8SKB())
										{
											continue;
										}
										goto case 4;
									case 4:
										awaiter = WZjaUk8yC8(deviceApi, url, httpPostTimeout, kgbOBx7BanbFa22Hp9.ol99ukmDA(50562), _003CdataStream_003E5__3, imageName, sync).GetAwaiter();
										K0vyBgsSRsFOv5v15l89();
										if (!bgoD8nsSaUluMNAy8SKB())
										{
											num3 = 3;
											continue;
										}
										num3 = 6;
										if (0 == 0)
										{
											continue;
										}
										goto case 10;
									case 0:
										num2 = (_003C_003E1__state = 0);
										num3 = 11;
										if (!bgoD8nsSaUluMNAy8SKB())
										{
											continue;
										}
										goto case 11;
									case 11:
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									default:
										return;
									case 10:
										GTWKNwsSXLqCxEPM2FmB(_003CdataStream_003E5__3, 0L);
										num3 = 4;
										if (true)
										{
											continue;
										}
										goto case 7;
									case 7:
										stream = awaiter.GetResult();
										num3 = 8;
										if (true)
										{
											continue;
										}
										goto case 8;
									case 8:
										LogHttpPost(url, (string)TBE9BSsSGee7O55QOUNW(49094), (string)TBE9BSsSGee7O55QOUNW(8988), useSystemDebug, this.logger);
										if (_003ClogPostOutput_003E5__2)
										{
											num3 = 12;
											continue;
										}
										goto end_IL_01ad;
									case 2:
									case 3:
										if (!awaiter.IsCompleted)
										{
											num3 = 0;
											continue;
										}
										goto case 7;
									case 6:
										return;
									case 9:
										_003C_003Eu__1 = default;
										num3 = 1;
										if (true)
										{
											continue;
										}
										break;
									case 12:
										break;
									}
									streamLogger.LogStream(_003CdataStream_003E5__3, (string)TBE9BSsSGee7O55QOUNW(9000));
									break;
									continue;
									end_IL_01ad:
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003CdataStream_003E5__3 != null)
								{
									VrYtvYsSbjQPwi0WfJI9(_003CdataStream_003E5__3);
								}
							}
							_003CdataStream_003E5__3 = null;
							if (_003ClogPostOutput_003E5__2)
							{
								MemoryStream memoryStream = new MemoryStream();
								try
								{
									bmp.Save(memoryStream, (ImageFormat)FphQMgsS6H8nd1Ksu5WR());
									_ = 0;
									int num4;
									if (K0vyBgsSRsFOv5v15l89())
									{
										num4 = 2;
										if (bgoD8nsSaUluMNAy8SKB())
										{
											goto IL_032f;
										}
									}
									else
									{
										num4 = 3;
										if (!K0vyBgsSRsFOv5v15l89())
										{
											goto IL_0375;
										}
									}
									switch (num4)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_0375;
									}
									goto IL_032f;
									IL_0375:
									Q1itHusSp0SYFQx7jGHN(streamLogger, memoryStream, TBE9BSsSGee7O55QOUNW(9022));
									goto end_IL_0301;
									IL_032f:
									GTWKNwsSXLqCxEPM2FmB(memoryStream, 0L);
									goto IL_0375;
									end_IL_0301:;
								}
								finally
								{
									if (num2 < 0 && memoryStream != null)
									{
										VrYtvYsSbjQPwi0WfJI9(memoryStream);
									}
								}
							}
						}
						catch (Exception ex)
						{
							ILogger logger = this.logger;
							if (logger != null)
							{
								thu639sS4se0VNXvPEb4(logger, FaQikbsS0jvTkqCxXlSF(kgbOBx7BanbFa22Hp9.ol99ukmDA(9032), url), ex);
							}
							if (ex is CvsNetworkException)
							{
								throw;
							}
							throw new CvsNetworkException(ex);
						}
						result = stream;
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
		internal static void hUgIvOsSn6a6Pgj1HKiT(object P_0, object P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ValidateParameters((IRemoteDeviceApi)P_0, (string)P_1, (string)P_2, (Bitmap)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TBE9BSsSGee7O55QOUNW(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GTWKNwsSXLqCxEPM2FmB(object P_0, long P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Position = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VrYtvYsSbjQPwi0WfJI9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FphQMgsS6H8nd1Ksu5WR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ImageFormat.Bmp;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Q1itHusSp0SYFQx7jGHN(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StreamLogger)P_0).LogStream((Stream)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FaQikbsS0jvTkqCxXlSF(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void thu639sS4se0VNXvPEb4(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K0vyBgsSRsFOv5v15l89()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bgoD8nsSaUluMNAy8SKB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct mMeiP156SngMsrldYZ : IAsyncStateMachine
		{
			public int xe7nA5VgGK;

			public AsyncTaskMethodBuilder<Stream> SBcntCfT3l;

			public _003C_003Ec__DisplayClass3_0 SusnWKS9aA;

			private TaskAwaiter<Stream> dJ3n3m1dOc;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 4;
				Stream result = default;
				int num2 = default;
				_003C_003Ec__DisplayClass3_0 obj = default;
				while (true)
				{
					switch (num)
					{
					default:
						SBcntCfT3l.SetResult(result);
						num = 6;
						break;
					case 0:
					case 2:
						try
						{
							TaskAwaiter<Stream> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = WZjaUk8yC8(obj.deviceApi, obj.url, obj.httpPostTimeout, (string)wTQ8CdsuonYHi1aKBoEY(50562), obj.dataStream, obj.imageName, obj.sync).GetAwaiter();
								_ = 0;
								num3 = ((!FxM5LNsuK3K6PeudJC7b()) ? 1 : 8);
							}
							else
							{
								awaiter = dJ3n3m1dOc;
								num3 = 7;
								if (1 == 0)
								{
									goto IL_012e;
								}
							}
							while (true)
							{
								switch (num3)
								{
								case 0:
								case 8:
									if (!awaiter.IsCompleted)
									{
										num3 = 4;
										continue;
									}
									goto case 9;
								case 4:
									num2 = (xe7nA5VgGK = 0);
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									break;
								case 1:
								case 3:
									break;
								default:
									num3 = 6;
									continue;
								case 6:
									return;
								case 5:
									goto IL_012e;
								case 2:
									num2 = (xe7nA5VgGK = -1);
									num3 = 9;
									continue;
								case 7:
									dJ3n3m1dOc = default;
									num3 = 2;
									if (FxM5LNsuK3K6PeudJC7b())
									{
										continue;
									}
									goto case 9;
								case 9:
									result = awaiter.GetResult();
									goto end_IL_002e;
								}
								break;
							}
							goto IL_00bf;
							IL_00bf:
							SBcntCfT3l.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							IL_012e:
							dJ3n3m1dOc = awaiter;
							goto IL_00bf;
							end_IL_002e:;
						}
						catch (Exception exception)
						{
							xe7nA5VgGK = -2;
							SBcntCfT3l.SetException(exception);
							return;
						}
						xe7nA5VgGK = -2;
						goto default;
					case 1:
						obj = SusnWKS9aA;
						_ = 1;
						num = (SOBlNYsu5d2boMuhKLVq() ? 5 : 0);
						break;
					case 4:
						num2 = xe7nA5VgGK;
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
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				SBcntCfT3l.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object wTQ8CdsuonYHi1aKBoEY(int P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool FxM5LNsuK3K6PeudJC7b()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool SOBlNYsu5d2boMuhKLVq()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public IRemoteDeviceApi deviceApi;

		public string url;

		public TimeSpan httpPostTimeout;

		public string imageName;

		public bool sync;

		public MemoryStream dataStream;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass3_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LNbPPysSFJr0swaC8eBE();
			QqmGSnsSm6b7QTXGVpQV(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(mMeiP156SngMsrldYZ))]
		internal Task<Stream> _003CPostImageByHTTP_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mMeiP156SngMsrldYZ stateMachine = default;
			stateMachine.SBcntCfT3l = AsyncTaskMethodBuilder<Stream>.Create();
			stateMachine.SusnWKS9aA = this;
			stateMachine.xe7nA5VgGK = -1;
			stateMachine.SBcntCfT3l.Start(ref stateMachine);
			return stateMachine.SBcntCfT3l.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LNbPPysSFJr0swaC8eBE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QqmGSnsSm6b7QTXGVpQV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D75hiSsSkLXJo0JrVlZt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jwoEtKsSfqWht7D9WIqZ()
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
	private struct _003CPostDataByHTTPAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public IRemoteDeviceApi deviceApi;

		public string connectionIDFunctionName;

		public string url;

		public Stream rawData;

		public bool useSystemDebug;

		public ILogger logger;

		public string additionalArgument;

		public TimeSpan httpPostTimeout;

		public string contentType;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xUUlxfsSy5FwSsPWR6dq();
			int num = (oIJHMqsSgFRZghpIqCNB() ? 3 : 4);
			int num2 = default;
			Stream stream = default;
			TaskAwaiter<Stream> awaiter = default;
			Stream result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					try
					{
						if (num2 != 0)
						{
							ValidateParameters(deviceApi, connectionIDFunctionName, url, rawData);
							stream = null;
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								LogHttpPost(url, kgbOBx7BanbFa22Hp9.ol99ukmDA(50584), (string)o9HVURsSZbNhkUrM9Jk0(8974), useSystemDebug, this.logger, connectionIDFunctionName);
								num3 = 6;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 0;
							}
							while (true)
							{
								string text;
								string text2;
								switch (num3)
								{
								case 7:
									_003C_003Eu__1 = awaiter;
									goto case 2;
								default:
									num3 = 2;
									continue;
								case 0:
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 5;
									continue;
								case 1:
								case 9:
									text = additionalArgument;
									goto IL_014a;
								case 3:
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 4:
									stream = awaiter.GetResult();
									num3 = 11;
									continue;
								case 10:
									if (!awaiter.IsCompleted)
									{
										goto case 3;
									}
									goto case 4;
								case 5:
									return;
								case 6:
									if (Y3bZ75sSJSH9pOGHuU01(additionalArgument))
									{
										text = "";
										goto IL_014a;
									}
									xUUlxfsSy5FwSsPWR6dq();
									if (oIJHMqsSgFRZghpIqCNB())
									{
										num3 = 8;
										if (1 == 0)
										{
											return;
										}
									}
									else
									{
										num3 = 9;
									}
									continue;
								case 11:
									{
										LogHttpPost(url, (string)o9HVURsSZbNhkUrM9Jk0(50584), (string)o9HVURsSZbNhkUrM9Jk0(8988), useSystemDebug, this.logger);
										break;
									}
									IL_014a:
									text2 = text;
									awaiter = WZjaUk8yC8(deviceApi, url, httpPostTimeout, contentType, rawData, text2).GetAwaiter();
									num3 = 10;
									continue;
								}
								break;
							}
						}
						catch (Exception ex)
						{
							ILogger logger = this.logger;
							if (logger != null)
							{
								c1t6NpsSzwXFVSjt2PGM(logger, ooCBJdsS8pwnylOQe5af(o9HVURsSZbNhkUrM9Jk0(9084), contentType, o9HVURsSZbNhkUrM9Jk0(9124), url), ex);
							}
							if (ex is CvsNetworkException)
							{
								throw;
							}
							throw new CvsNetworkException(ex);
						}
						result = stream;
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
		internal static object o9HVURsSZbNhkUrM9Jk0(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y3bZ75sSJSH9pOGHuU01(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ooCBJdsS8pwnylOQe5af(object P_0, object P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void c1t6NpsSzwXFVSjt2PGM(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xUUlxfsSy5FwSsPWR6dq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oIJHMqsSgFRZghpIqCNB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct piiUDi9DaBvYwPu3n0 : IAsyncStateMachine
		{
			public int tODnLafjDq;

			public AsyncTaskMethodBuilder<Stream> G65nkwnFkT;

			public _003C_003Ec__DisplayClass5_0 oOTnXTfsMw;

			private TaskAwaiter<Stream> chjnfI7t7k;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				p0CgL6suPTqUS9j2MT60();
				int num = (LQUiTvsuY0ILy4b1BWBx() ? 4 : 3);
				int num2 = default;
				_003C_003Ec__DisplayClass5_0 obj = default;
				Stream result = default;
				do
				{
					IL_01ac:
					switch (num)
					{
					case 0:
					case 3:
						num2 = tODnLafjDq;
						goto case 1;
					case 5:
						try
						{
							TaskAwaiter<Stream> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = WZjaUk8yC8(obj.deviceApi, obj.url, obj.httpPostTimeout, obj.contentType, obj.rawData, obj.localArgument).GetAwaiter();
								num3 = 0;
								goto IL_00a7;
							}
							awaiter = chjnfI7t7k;
							goto IL_00f1;
							IL_00f1:
							chjnfI7t7k = default;
							num3 = 8;
							goto IL_00a7;
							IL_00a7:
							while (true)
							{
								switch (num3)
								{
								case 3:
								case 7:
									G65nkwnFkT.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 4;
									continue;
								case 1:
									num2 = (tODnLafjDq = 0);
									num3 = 2;
									continue;
								case 5:
								case 6:
									break;
								case 8:
									num2 = (tODnLafjDq = -1);
									num3 = 9;
									continue;
								case 4:
									return;
								case 2:
									chjnfI7t7k = awaiter;
									_ = 0;
									num3 = (p0CgL6suPTqUS9j2MT60() ? 7 : 6);
									continue;
								case 0:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto case 9;
								case 9:
									result = awaiter.GetResult();
									goto end_IL_00a7;
								}
								goto IL_00f1;
								continue;
								end_IL_00a7:
								break;
							}
						}
						catch (Exception exception)
						{
							tODnLafjDq = -2;
							G65nkwnFkT.SetException(exception);
							return;
						}
						tODnLafjDq = -2;
						break;
					default:
						num = 2;
						goto IL_01ac;
					case 1:
					case 4:
						obj = oOTnXTfsMw;
						num = 5;
						goto IL_01ac;
					case 2:
						break;
					case 6:
						return;
					}
					G65nkwnFkT.SetResult(result);
					num = 6;
				}
				while (0 == 0);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				G65nkwnFkT.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool p0CgL6suPTqUS9j2MT60()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool LQUiTvsuY0ILy4b1BWBx()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public IRemoteDeviceApi deviceApi;

		public string url;

		public TimeSpan httpPostTimeout;

		public string contentType;

		public Stream rawData;

		public string localArgument;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass5_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(piiUDi9DaBvYwPu3n0))]
		internal Task<Stream> _003CPostDataByHTTP_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			piiUDi9DaBvYwPu3n0 stateMachine = default;
			stateMachine.G65nkwnFkT = AsyncTaskMethodBuilder<Stream>.Create();
			stateMachine.oOTnXTfsMw = this;
			stateMachine.tODnLafjDq = -1;
			stateMachine.G65nkwnFkT.Start(ref stateMachine);
			return stateMachine.G65nkwnFkT.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wkZVWjsEwO58kdFB09Ki()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nSnY9TsEsOCRKJb5mEEm()
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
	private struct _003CMakeHttpPostImageRequest_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public string imageName;

		public IRemoteDeviceApi deviceApi;

		public string url;

		public TimeSpan timeout;

		public string contentType;

		public Stream dataStream;

		public bool sync;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MG8dWLsEhaomEk6q6xwf();
			int num;
			if (!SZDqd6sELcCGLlv7qGHR())
			{
				num = 1;
				if (SZDqd6sELcCGLlv7qGHR())
				{
				}
			}
			else
			{
				num = 3;
				if (SZDqd6sELcCGLlv7qGHR())
				{
					goto IL_022a;
				}
			}
			goto IL_01f7;
			IL_01f7:
			int num2 = default;
			TaskAwaiter<Stream> awaiter = default;
			Stream result = default;
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0032;
				case 4:
					try
					{
						int num3;
						string text;
						if (num2 != 0)
						{
							if (!string.IsNullOrEmpty(imageName))
							{
								num3 = 8;
								goto IL_00eb;
							}
							text = "";
							goto IL_0168;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00bc;
						IL_0158:
						text = imageName;
						goto IL_0168;
						IL_00eb:
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								break;
							case 2:
							case 6:
								goto end_IL_00eb;
							case 3:
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 10;
							case 0:
								return;
							case 8:
								goto IL_0158;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0048;
							}
							num2 = (_003C_003E1__state = 0);
							SZDqd6sELcCGLlv7qGHR();
							if (MG8dWLsEhaomEk6q6xwf())
							{
								num3 = 4;
								if (SZDqd6sELcCGLlv7qGHR())
								{
									break;
								}
							}
							else
							{
								num3 = 2;
							}
							continue;
							end_IL_00eb:
							break;
						}
						goto IL_00bc;
						IL_0168:
						string text2 = text;
						awaiter = WZjaUk8yC8(deviceApi, url, timeout, contentType, dataStream, text2, sync).GetAwaiter();
						num3 = 7;
						goto IL_00eb;
						IL_00bc:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00eb;
						end_IL_0048:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_0032;
				case 0:
				case 1:
					break;
				case 5:
					return;
				}
				break;
				IL_0032:
				_003C_003Et__builder.SetResult(result);
				num = 5;
			}
			goto IL_022a;
			IL_022a:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_01f7;
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
		internal static bool MG8dWLsEhaomEk6q6xwf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SZDqd6sELcCGLlv7qGHR()
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
	private struct _003CMakeHttpPostRequest_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public IRemoteDeviceApi deviceApi;

		public string url;

		public TimeSpan timeout;

		public string contentType;

		public Stream dataStream;

		public object[] args;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (FJbbtrsE9QdHkQg7F0TP())
			{
				num = 2;
				if (pRj5dosES0WGXot5bFjx())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
				if (pRj5dosES0WGXot5bFjx())
				{
				}
			}
			goto IL_018f;
			IL_01b8:
			Stream result = default;
			_003C_003Et__builder.SetResult(result);
			num = 5;
			goto IL_018f;
			IL_018f:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto IL_01b8;
				case 4:
					goto IL_01b8;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				TaskAwaiter<Stream> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = deviceApi.MakeHttpPostRequest(url, timeout, contentType, dataStream, 0, args).GetAwaiter();
					num3 = 0;
					if (false)
					{
						goto IL_006c;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 6;
				}
				goto IL_00a2;
				IL_00a2:
				while (true)
				{
					switch (num3)
					{
					case 6:
						break;
					case 1:
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						return;
					case 7:
						return;
					case 0:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							continue;
						}
						goto case 9;
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						continue;
					case 8:
						_003C_003Eu__1 = awaiter;
						_ = 0;
						num3 = (FJbbtrsE9QdHkQg7F0TP() ? 1 : 7);
						continue;
					case 5:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 9:
						result = awaiter.GetResult();
						goto end_IL_00a2;
					}
					goto IL_006c;
					continue;
					end_IL_00a2:
					break;
				}
				goto end_IL_002a;
				IL_006c:
				_003C_003Eu__1 = default;
				num3 = 5;
				goto IL_00a2;
				end_IL_002a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01b8;
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
		internal static bool FJbbtrsE9QdHkQg7F0TP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pRj5dosES0WGXot5bFjx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostImageByHTTPAsync_003Ed__2))]
	internal static Task<Stream> PostImageByHTTPAsync(IRemoteDeviceApi deviceApi, Bitmap bmp, string url, string connectionIDFunctionName, TimeSpan httpPostTimeout, bool useSystemDebug, ILogger logger = null, StreamLogger streamLogger = null, string imageName = null, bool sync = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPostImageByHTTPAsync_003Ed__2 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine.deviceApi = deviceApi;
		stateMachine.bmp = bmp;
		stateMachine.url = url;
		stateMachine.connectionIDFunctionName = connectionIDFunctionName;
		stateMachine.httpPostTimeout = httpPostTimeout;
		stateMachine.useSystemDebug = useSystemDebug;
		stateMachine.logger = logger;
		stateMachine.streamLogger = streamLogger;
		stateMachine.imageName = imageName;
		stateMachine.sync = sync;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostImageByHTTP(IRemoteDeviceApi deviceApi, Bitmap bmp, string url, string connectionIDFunctionName, TimeSpan httpPostTimeout, bool useSystemDebug, ILogger logger = null, StreamLogger streamLogger = null, string imageName = null, bool sync = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00b4;
		IL_001a:
		_003C_003Ec__DisplayClass3_0 obj = default;
		obj.sync = sync;
		goto IL_004b;
		IL_00b4:
		while (true)
		{
			switch (num)
			{
			case 5:
			case 7:
				break;
			case 0:
				obj.url = url;
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto IL_004b;
			case 1:
			case 6:
				goto IL_004b;
			case 4:
				obj.imageName = imageName;
				m2p4DCTpQTmVKoPHmj3();
				if (!JfeEeoT6NDZ4a5bvloJ())
				{
					num = 1;
					if (JfeEeoT6NDZ4a5bvloJ())
					{
						continue;
					}
					goto case 0;
				}
				num = 7;
				continue;
			case 2:
				obj = new _003C_003Ec__DisplayClass3_0();
				num = 3;
				continue;
			case 8:
				obj.httpPostTimeout = httpPostTimeout;
				goto case 4;
			default:
				num = 4;
				continue;
			case 3:
				obj.deviceApi = deviceApi;
				num = 0;
				continue;
			case 9:
				try
				{
					LogHttpPost(obj.url, (string)K93FMGT4tK8uJJo6mIo(2984), (string)K93FMGT4tK8uJJo6mIo(8974), useSystemDebug, logger, connectionIDFunctionName);
					bool flag = streamLogger?.CanLogStream ?? false;
					obj.dataStream = new MemoryStream();
					try
					{
						bmp.Save(obj.dataStream, ImageFormat.Bmp);
						m2p4DCTpQTmVKoPHmj3();
						int num2 = ((!JfeEeoT6NDZ4a5bvloJ()) ? 2 : 5);
						while (true)
						{
							switch (num2)
							{
							case 4:
								if (flag)
								{
									num2 = 6;
									if (!m2p4DCTpQTmVKoPHmj3())
									{
										continue;
									}
									goto case 3;
								}
								goto end_IL_01f4;
							case 3:
								LogHttpPost(obj.url, (string)K93FMGT4tK8uJJo6mIo(2984), (string)K93FMGT4tK8uJJo6mIo(8988), useSystemDebug, logger);
								num2 = 4;
								continue;
							case 0:
							case 5:
								cHUuexTk6eeAGdGebCL(obj.dataStream, 0L);
								goto case 1;
							case 1:
							case 2:
								wnI13KTf7JvD1W4fGw3(Task.Run((Func<Task<Stream>>)obj._003CPostImageByHTTP_003Eb__0));
								goto case 3;
							default:
								num2 = 3;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 6:
								break;
							}
							streamLogger.LogStream(obj.dataStream, (string)K93FMGT4tK8uJJo6mIo(9000));
							break;
							continue;
							end_IL_01f4:
							break;
						}
					}
					finally
					{
						if (obj.dataStream != null)
						{
							QDu9gLTFdkT4GHkYYOG(obj.dataStream);
						}
					}
					if (!flag)
					{
						return;
					}
					MemoryStream memoryStream = new MemoryStream();
					try
					{
						T5C2UhTm01ss81KB9A0(bmp, memoryStream, ImageFormat.Bmp);
						_ = 1;
						switch (m2p4DCTpQTmVKoPHmj3() ? 3 : 2)
						{
						case 0:
						case 2:
							cHUuexTk6eeAGdGebCL(memoryStream, 0L);
							break;
						}
						pT5e8WTyjwVCpDXFQ2k(streamLogger, memoryStream, K93FMGT4tK8uJJo6mIo(9022));
						return;
					}
					finally
					{
						if (memoryStream != null)
						{
							QDu9gLTFdkT4GHkYYOG(memoryStream);
						}
					}
				}
				catch (Exception ex)
				{
					if (logger != null)
					{
						KJZC4RTgqlYrg0TSb1L(logger, (string)K93FMGT4tK8uJJo6mIo(9032) + obj.url, ex);
					}
					if (ex is CvsNetworkException)
					{
						throw;
					}
					throw new CvsNetworkException(ex);
				}
			}
			break;
		}
		goto IL_001a;
		IL_004b:
		BAXaDpT0QX3thsMO0Xl(obj.deviceApi, connectionIDFunctionName, obj.url, bmp);
		num = 9;
		goto IL_00b4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostDataByHTTPAsync_003Ed__4))]
	internal static Task<Stream> PostDataByHTTPAsync(IRemoteDeviceApi deviceApi, Stream rawData, string contentType, string url, string connectionIDFunctionName, TimeSpan httpPostTimeout, bool useSystemDebug, ILogger logger = null, string additionalArgument = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPostDataByHTTPAsync_003Ed__4 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine.deviceApi = deviceApi;
		stateMachine.rawData = rawData;
		stateMachine.contentType = contentType;
		stateMachine.url = url;
		stateMachine.connectionIDFunctionName = connectionIDFunctionName;
		stateMachine.httpPostTimeout = httpPostTimeout;
		stateMachine.useSystemDebug = useSystemDebug;
		stateMachine.logger = logger;
		stateMachine.additionalArgument = additionalArgument;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostDataByHTTP(IRemoteDeviceApi deviceApi, Stream rawData, string contentType, string url, string connectionIDFunctionName, TimeSpan httpPostTimeout, bool useSystemDebug, ILogger logger = null, string additionalArgument = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0044;
		IL_001a:
		_003C_003Ec__DisplayClass5_0 obj = new _003C_003Ec__DisplayClass5_0();
		num = 4;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 7:
				obj.httpPostTimeout = httpPostTimeout;
				goto case 1;
			default:
				num = 1;
				continue;
			case 3:
			case 5:
				obj.rawData = rawData;
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				obj.contentType = contentType;
				goto case 3;
			case 0:
				wqdonKTZWI37Sgo5m2T(obj.deviceApi, connectionIDFunctionName, obj.url, obj.rawData);
				num = 9;
				continue;
			case 4:
				obj.deviceApi = deviceApi;
				m2p4DCTpQTmVKoPHmj3();
				if (!JfeEeoT6NDZ4a5bvloJ())
				{
					num = 3;
					continue;
				}
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 8:
				obj.url = url;
				num = 7;
				continue;
			case 9:
				try
				{
					LogHttpPost(obj.url, (string)K93FMGT4tK8uJJo6mIo(4802), (string)K93FMGT4tK8uJJo6mIo(8974), useSystemDebug, logger, connectionIDFunctionName);
					m2p4DCTpQTmVKoPHmj3();
					switch ((!JfeEeoT6NDZ4a5bvloJ()) ? 3 : 2)
					{
					case 0:
					case 2:
						obj.localArgument = (MjblhXTJcWl6Tvx5X7l(additionalArgument) ? "" : additionalArgument);
						Task.Run((Func<Task<Stream>>)obj._003CPostDataByHTTP_003Eb__0);
						break;
					}
					LogHttpPost(obj.url, kgbOBx7BanbFa22Hp9.ol99ukmDA(4802), (string)K93FMGT4tK8uJJo6mIo(8988), useSystemDebug, logger);
					return;
				}
				catch (Exception ex)
				{
					if (logger != null)
					{
						KJZC4RTgqlYrg0TSb1L(logger, (string)K93FMGT4tK8uJJo6mIo(9084) + obj.contentType + (string)K93FMGT4tK8uJJo6mIo(9124) + obj.url, ex);
					}
					if (ex is CvsNetworkException)
					{
						throw;
					}
					throw new CvsNetworkException(ex);
				}
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogHttpPost(string url, string callingFunctionName, string description, bool useSystemDebug, ILogger logger = null, string connectionIDFunctionName = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				text = (string)cKBNj1T8oS6q8R6KKkj(new string[5]
				{
					callingFunctionName,
					(string)K93FMGT4tK8uJJo6mIo(9124),
					description,
					(string)K93FMGT4tK8uJJo6mIo(350),
					url
				});
				num = 2;
				break;
			case 3:
			case 5:
				eSfMcVdwEOwWsp8VtM7(CvsTraceSDK.TxCogSocket, K93FMGT4tK8uJJo6mIo(2062), new object[2] { connectionIDFunctionName, url });
				num = 8;
				if (JfeEeoT6NDZ4a5bvloJ())
				{
					break;
				}
				goto case 2;
			case 2:
				num = 1;
				break;
			case 4:
			case 7:
				if (string.IsNullOrEmpty(callingFunctionName))
				{
					goto case 3;
				}
				return;
			case 1:
				if (logger == null)
				{
					goto case 4;
				}
				num = 6;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				mqewEITzIstPwWV8DfZ(logger, text);
				goto default;
			default:
				_ = 1;
				if (m2p4DCTpQTmVKoPHmj3())
				{
					num = 3;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 7;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateParameters(IRemoteDeviceApi deviceApi, string connectionIdFunctionName, string url, Bitmap bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ValidateParameters(deviceApi, connectionIdFunctionName, url);
		if (bmp == null)
		{
			throw new ArgumentException((string)K93FMGT4tK8uJJo6mIo(9130), (string)K93FMGT4tK8uJJo6mIo(9186));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateParameters(IRemoteDeviceApi deviceApi, string connectionIdFunctionName, string url, Stream rawData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tPkaoxdsw1alagRD5yS(deviceApi, connectionIdFunctionName, url);
		if (rawData == null)
		{
			throw new ArgumentException((string)K93FMGT4tK8uJJo6mIo(9196), kgbOBx7BanbFa22Hp9.ol99ukmDA(9256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateParameters(IRemoteDeviceApi deviceApi, string connectionIdFunctionName, string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (deviceApi == null)
				{
					JfeEeoT6NDZ4a5bvloJ();
					num = (m2p4DCTpQTmVKoPHmj3() ? 4 : 0);
					break;
				}
				if (!iamTpsdhHUDZrRMnROl(connectionIdFunctionName))
				{
					if (iamTpsdhHUDZrRMnROl(url))
					{
						num = 5;
						break;
					}
					return;
				}
				goto default;
			default:
				throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(9346), kgbOBx7BanbFa22Hp9.ol99ukmDA(9458));
			case 0:
			case 1:
				throw new ArgumentException((string)K93FMGT4tK8uJJo6mIo(9274), (string)K93FMGT4tK8uJJo6mIo(9324));
			case 5:
				throw new ArgumentException((string)K93FMGT4tK8uJJo6mIo(9510), kgbOBx7BanbFa22Hp9.ol99ukmDA(9548));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMakeHttpPostImageRequest_003Ed__10))]
	internal static Task<Stream> MakeHttpPostImageRequest(IRemoteDeviceApi deviceApi, string url, TimeSpan timeout, string contentType, Stream dataStream, string imageName, bool sync)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CMakeHttpPostImageRequest_003Ed__10 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine.deviceApi = deviceApi;
		stateMachine.url = url;
		stateMachine.timeout = timeout;
		stateMachine.contentType = contentType;
		stateMachine.dataStream = dataStream;
		stateMachine.imageName = imageName;
		stateMachine.sync = sync;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMakeHttpPostRequest_003Ed__11))]
	private static Task<Stream> WZjaUk8yC8(IRemoteDeviceApi P_0, string P_1, TimeSpan P_2, string P_3, Stream P_4, params object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CMakeHttpPostRequest_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine.deviceApi = P_0;
		stateMachine.url = P_1;
		stateMachine.timeout = P_2;
		stateMachine.contentType = P_3;
		stateMachine.dataStream = P_4;
		stateMachine.args = args;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BAXaDpT0QX3thsMO0Xl(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ValidateParameters((IRemoteDeviceApi)P_0, (string)P_1, (string)P_2, (Bitmap)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K93FMGT4tK8uJJo6mIo(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cHUuexTk6eeAGdGebCL(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wnI13KTf7JvD1W4fGw3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).Wait();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QDu9gLTFdkT4GHkYYOG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T5C2UhTm01ss81KB9A0(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image)P_0).Save((Stream)P_1, (ImageFormat)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pT5e8WTyjwVCpDXFQ2k(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((StreamLogger)P_0).LogStream((Stream)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KJZC4RTgqlYrg0TSb1L(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JfeEeoT6NDZ4a5bvloJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m2p4DCTpQTmVKoPHmj3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wqdonKTZWI37Sgo5m2T(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ValidateParameters((IRemoteDeviceApi)P_0, (string)P_1, (string)P_2, (Stream)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MjblhXTJcWl6Tvx5X7l(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cKBNj1T8oS6q8R6KKkj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mqewEITzIstPwWV8DfZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).Debug((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eSfMcVdwEOwWsp8VtM7(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tPkaoxdsw1alagRD5yS(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ValidateParameters((IRemoteDeviceApi)P_0, (string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iamTpsdhHUDZrRMnROl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrWhiteSpace((string)P_0);
	}
}
