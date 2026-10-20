using System;
using System.Annotations;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.Diagnostics.Logging;
using Cognex.Extensions.Specialized;
using Cognex.InSight.Common;
using Cognex.InSight.Layout;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Sensor;
using Cognex.InSight.Services;
using Cognex.Remoting.CogSocket;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public class CvsCogSocket : IDisposable, IResourceUriProvider
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogSocket> _003C_003Et__builder;

		public Uri rootWssUrl;

		public Uri rootHttpUrl;

		public string path;

		public string sheetPath;

		public string username;

		public WaitForBuildCompleteDelegate waitForResultBuildComplete;

		public ICogSocketAcqFactory acqFactory;

		private CvsCogSocket _003Ccogsocket_003E5__2;

		private ICogSocketAcq _003Cacq_003E5__3;

		private TaskAwaiter<ICogSocketAcq> _003C_003Eu__1;

		private TaskAwaiter<Task> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mgm6w0srkoTMg7e4SlCV();
			int num;
			if (!rJxehosrfFH3dHoyubNd())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
				if (!mgm6w0srkoTMg7e4SlCV())
				{
					goto IL_0047;
				}
			}
			goto IL_0060;
			IL_002a:
			int num2 = _003C_003E1__state;
			goto IL_008b;
			IL_0385:
			CvsCogSocket result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0060;
			IL_008b:
			try
			{
				if ((uint)num2 > 1u)
				{
					_003Ccogsocket_003E5__2 = new CvsCogSocket(rootWssUrl, rootHttpUrl, path, sheetPath, username, waitForResultBuildComplete);
				}
				try
				{
					int num3;
					TaskAwaiter<Task> awaiter = default;
					TaskAwaiter<ICogSocketAcq> awaiter2 = default;
					if (num2 != 0)
					{
						if (num2 != 1)
						{
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__2;
							num3 = 17;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 6;
					}
					ICogSocketAcq result2 = default;
					while (true)
					{
						switch (num3)
						{
						case 0:
							H4mIlLsrgiMJC10eWmPp(_003Ccogsocket_003E5__2, _003Cacq_003E5__3);
							num3 = 18;
							continue;
						case 15:
							_003C_003Eu__1 = awaiter2;
							num3 = 3;
							continue;
						case 9:
						case 13:
							num2 = (_003C_003E1__state = -1);
							num3 = 4;
							continue;
						case 6:
							result2 = awaiter2.GetResult();
							num3 = 14;
							continue;
						case 3:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num3 = 8;
							if (0 == 0)
							{
								continue;
							}
							return;
						case 8:
							return;
						case 14:
							_003Cacq_003E5__3 = result2;
							mgm6w0srkoTMg7e4SlCV();
							if (!rJxehosrfFH3dHoyubNd())
							{
								num3 = 2;
								if (mgm6w0srkoTMg7e4SlCV())
								{
									continue;
								}
								goto case 1;
							}
							num3 = 9;
							continue;
						case 1:
							num2 = (_003C_003E1__state = 1);
							num3 = 11;
							continue;
						case 16:
							if (!awaiter.IsCompleted)
							{
								num3 = 1;
								continue;
							}
							goto case 4;
						case 12:
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								num3 = 15;
								continue;
							}
							goto case 6;
						case 17:
							_003C_003Eu__2 = default;
							goto case 9;
						case 4:
							awaiter.GetResult();
							num3 = 0;
							continue;
						case 11:
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 10;
							continue;
						case 2:
						case 7:
							awaiter = Task.WhenAny((Task)m5bFqZsrFdVYqCALgDgZ(_003Cacq_003E5__3), (Task)XlBsOTsryOId3EbEGw6b(iBKiH1srmKTBlMThMNoy())).GetAwaiter();
							goto case 16;
						default:
							num3 = 16;
							continue;
						case 5:
							awaiter2 = acqFactory.Create(_003Ccogsocket_003E5__2).GetAwaiter();
							num3 = 12;
							continue;
						case 10:
							return;
						case 18:
							_003Cacq_003E5__3 = null;
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					_003Ccogsocket_003E5__2.Dispose();
					QbE48Hsr8RMyEgSybQrX(CvsTraceSDK.Error, (string)DYwvwxsrZ4UWZXGRPcKN(55640) + (string)oH68XDsrJl14193h1Zn3(ex));
					throw new CvsNetworkException((string)vYH5Kdsrz2USPGkIClBt(), ex);
				}
				result = _003Ccogsocket_003E5__2;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Ccogsocket_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			num = 3;
			goto IL_0060;
			IL_0060:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 3:
					goto IL_0047;
				default:
					num = 5;
					continue;
				case 1:
				case 2:
					goto IL_008b;
				case 5:
					goto IL_0385;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_0047:
			_003Ccogsocket_003E5__2 = null;
			goto IL_0385;
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
		internal static object m5bFqZsrFdVYqCALgDgZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICogSocketAcq)P_0).AddListenersAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan iBKiH1srmKTBlMThMNoy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TaskTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XlBsOTsryOId3EbEGw6b(TimeSpan P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.Delay(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void H4mIlLsrgiMJC10eWmPp(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocket)P_0).Acq = (ICogSocketAcq)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DYwvwxsrZ4UWZXGRPcKN(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oH68XDsrJl14193h1Zn3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QbE48Hsr8RMyEgSybQrX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vYH5Kdsrz2USPGkIClBt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.UnableToConnectToDevice;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mgm6w0srkoTMg7e4SlCV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rJxehosrfFH3dHoyubNd()
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
	private struct _003CGetFunctionLibrary_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsFunctionTable> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		private ConfiguredTaskAwaitable<FunctionTableDescriptor>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dQrYMbs3w0OEccD2D2Z1();
			int num = (RGv3Efs3suN4udTx6vpc() ? 5 : 4);
			CvsCogSocket cvsCogSocket = default;
			int num2 = default;
			ConfiguredTaskAwaitable<FunctionTableDescriptor> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<FunctionTableDescriptor>.ConfiguredTaskAwaiter awaiter = default;
			CvsFunctionTable result = default;
			do
			{
				IL_01e6:
				switch (num)
				{
				case 1:
					cvsCogSocket = _003C_003E4__this;
					goto case 2;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					goto IL_01e6;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocket.LZxWMelhoh.PostAsync<FunctionTableDescriptor>((string)BAiWgys39Kdiad3c79Ka(XQKrlbs3hFo24vpLjGtw(41248), It4QAfs3LSCLBHkF3S9v(cvsCogSocket.Sheet), kgbOBx7BanbFa22Hp9.ol99ukmDA(55690)), Array.Empty<object>()).ConfigureAwait(continueOnCapturedContext: false);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								_ = 0;
								if (dQrYMbs3w0OEccD2D2Z1())
								{
									num3 = 3;
									if (false)
									{
										return;
									}
								}
								else
								{
									num3 = 8;
								}
								continue;
							case 9:
								return;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								if (dQrYMbs3w0OEccD2D2Z1())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 2;
							case 2:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 10:
								break;
							}
							break;
						}
						result = new CvsFunctionTable(awaiter.GetResult());
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
					goto IL_01e6;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static object XQKrlbs3hFo24vpLjGtw(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object It4QAfs3LSCLBHkF3S9v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).Path;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BAiWgys39Kdiad3c79Ka(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dQrYMbs3w0OEccD2D2Z1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RGv3Efs3suN4udTx6vpc()
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
	private struct _003CGetLanguage_003Ed__75 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CultureInfo> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dKoAoUs3SApy2YbMyMQy();
			int num;
			if (!nNTAf0s3Eki5fcXsCDIi())
			{
				num = 3;
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					return;
				}
			}
			CultureInfo result = default;
			int num2 = default;
			string path = default;
			CvsCogSocket cvsCogSocket = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<string> configuredTaskAwaitable = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = (string)oMeNQSs3V9K0x6WHP854(kgbOBx7BanbFa22Hp9.ol99ukmDA(41248), M0x6VWs3vss8tPb9OrTe(cvsCogSocket.Sheet), NVUeNCs3Hyrqo6BTYadx(55730));
							num3 = 3;
							goto IL_0101;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00d1;
						IL_00d1:
						_003C_003Eu__1 = default;
						num3 = 8;
						goto IL_0101;
						IL_0101:
						while (true)
						{
							switch (num3)
							{
							case 7:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 1;
								if (!nNTAf0s3Eki5fcXsCDIi())
								{
									num3 = 0;
									if (true)
									{
										continue;
									}
									return;
								}
								num3 = 2;
								if (!nNTAf0s3Eki5fcXsCDIi())
								{
									continue;
								}
								break;
							case 0:
							case 5:
								return;
							case 2:
							case 6:
								break;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 1;
									if (dKoAoUs3SApy2YbMyMQy())
									{
										continue;
									}
									goto case 3;
								}
								goto case 10;
							case 3:
								configuredTaskAwaitable = cvsCogSocket.LZxWMelhoh.GetAsync<string>(path).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 7;
								if (!nNTAf0s3Eki5fcXsCDIi())
								{
									continue;
								}
								goto case 10;
							case 10:
								result = (CultureInfo)dYsdVPs3ADh691lt1Tga(awaiter.GetResult());
								goto end_IL_0101;
							}
							goto IL_00d1;
							continue;
							end_IL_0101:
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
					goto case 1;
				default:
					num = 1;
					if (nNTAf0s3Eki5fcXsCDIi())
					{
					}
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					cvsCogSocket = _003C_003E4__this;
					goto case 2;
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
		internal static object M0x6VWs3vss8tPb9OrTe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).Path;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NVUeNCs3Hyrqo6BTYadx(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oMeNQSs3V9K0x6WHP854(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dYsdVPs3ADh691lt1Tga(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CultureInfo.GetCultureInfo((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dKoAoUs3SApy2YbMyMQy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nNTAf0s3Eki5fcXsCDIi()
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
	private struct _003CSetLanguage_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public CultureInfo culture;

		private string _003ClanguagePath_003E5__2;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			CvsCogSocket cvsCogSocket = default;
			bool result = default;
			ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<object> configuredTaskAwaitable = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					cvsCogSocket = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					k7uESQs3UeDP7I58VhAw();
					num = ((!dMMWLFs3DpUfye9S27eE()) ? 6 : 0);
					break;
				case 5:
					_003ClanguagePath_003E5__2 = null;
					num = 4;
					break;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 2:
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02a5;
							}
							_003ClanguagePath_003E5__2 = string.Format((string)aaf8kVs3TrYtqpmPbohB(41248), ewyJ5os3d9E0FNYGs1Lq(cvsCogSocket.Sheet), kgbOBx7BanbFa22Hp9.ol99ukmDA(55730));
							num3 = 0;
						}
						try
						{
							int num4;
							if (num2 != 0)
							{
								configuredTaskAwaitable = cvsCogSocket.LZxWMelhoh.PutAsync<object>(_003ClanguagePath_003E5__2, GeGCKGs3iWWo8Ig4fjan(culture)).ConfigureAwait(continueOnCapturedContext: false);
								num4 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num4 = 9;
							}
							while (true)
							{
								switch (num4)
								{
								case 4:
									num2 = (_003C_003E1__state = -1);
									goto case 6;
								case 3:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num4 = 2;
									continue;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num4 = 0;
									continue;
								case 6:
								case 7:
									awaiter.GetResult();
									num4 = 10;
									if (!k7uESQs3UeDP7I58VhAw())
									{
										continue;
									}
									goto case 1;
								case 1:
								case 8:
									if (!awaiter.IsCompleted)
									{
										num4 = 3;
										continue;
									}
									goto case 6;
								case 0:
									return;
								case 9:
									_003C_003Eu__1 = default;
									num4 = 4;
									continue;
								case 5:
									awaiter = configuredTaskAwaitable.GetAwaiter();
									_ = 0;
									num4 = (dMMWLFs3DpUfye9S27eE() ? 8 : 6);
									continue;
								case 10:
									result = true;
									break;
								}
								break;
							}
						}
						catch (CvsErrorResponseNetworkException ex) when (ex.ErrorCode == -2147483646)
						{
							num3 = 1;
							goto IL_0225;
						}
						goto end_IL_0077;
						IL_0225:
						if (num3 == 1)
						{
							configuredTaskAwaitable = cvsCogSocket.LZxWMelhoh.PutAsync<object>(_003ClanguagePath_003E5__2, aaf8kVs3TrYtqpmPbohB(55750)).ConfigureAwait(continueOnCapturedContext: false);
							awaiter = configuredTaskAwaitable.GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_02a5;
						}
						_003ClanguagePath_003E5__2 = null;
						goto end_IL_0077;
						IL_02a5:
						awaiter.GetResult();
						result = false;
						end_IL_0077:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003ClanguagePath_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
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
		internal static object aaf8kVs3TrYtqpmPbohB(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ewyJ5os3d9E0FNYGs1Lq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).Path;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GeGCKGs3iWWo8Ig4fjan(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CultureInfo)P_0).TwoLetterISOLanguageName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dMMWLFs3DpUfye9S27eE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k7uESQs3UeDP7I58VhAw()
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
	private struct _003CGetImageByHttpAsync_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bitmap> _003C_003Et__builder;

		public string url;

		public CvsCogSocket _003C_003E4__this;

		public string dw;

		public string dh;

		public string sx;

		public string sy;

		public string sw;

		public string sh;

		public string interp;

		public string fmt;

		private string _003CformatUrl_003E5__2;

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
			if (g8VEe9s3q2W0O9ONOjc2())
			{
				num = 2;
				if (!g8VEe9s3q2W0O9ONOjc2())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_0379;
				}
			}
			goto IL_0333;
			IL_0333:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto IL_0379;
				case 1:
				case 4:
					goto IL_0379;
				case 3:
					goto IL_038c;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_0379:
			CvsCogSocket cvsCogSocket = _003C_003E4__this;
			num = 5;
			if (0 == 0)
			{
				goto IL_0333;
			}
			goto IL_038c;
			IL_002a:
			Bitmap result = default;
			try
			{
				if (num2 == 0)
				{
					goto IL_01b3;
				}
				if (mj8GvBs3jqvngCsa4Wyp(url))
				{
					throw new ArgumentException((string)fgKG5Ys3ccfkaLilIFcB(41384), (string)fgKG5Ys3ccfkaLilIFcB(9548));
				}
				if (!ICj8Mls32TBUPlOqUsLg(url))
				{
					HttpQueryBuilder httpQueryBuilder = new HttpQueryBuilder();
					if (!cvsCogSocket.mI0WIixEdi(dw, dh))
					{
						httpQueryBuilder.SetParameter(kgbOBx7BanbFa22Hp9.ol99ukmDA(41444), dw, dh);
					}
					if (!cvsCogSocket.mI0WIixEdi(sx, sy, sw, sh))
					{
						httpQueryBuilder.SetParameter((string)fgKG5Ys3ccfkaLilIFcB(41452), sx, sy, sw, sh);
					}
					if (!string.IsNullOrEmpty(interp))
					{
						ujjAZis3WMJvLNI1p9Cw(httpQueryBuilder, kgbOBx7BanbFa22Hp9.ol99ukmDA(41464), interp);
					}
					if (!string.IsNullOrEmpty(fmt))
					{
						ujjAZis3WMJvLNI1p9Cw(httpQueryBuilder, fgKG5Ys3ccfkaLilIFcB(41480), fmt);
					}
					string text = (string)k3Oo6Ls37FfaiypkpU1y(httpQueryBuilder);
					_003CformatUrl_003E5__2 = (mj8GvBs3jqvngCsa4Wyp(text) ? url : (url + (string)fgKG5Ys3ccfkaLilIFcB(15296) + text));
					goto IL_01b3;
				}
				result = null;
				goto end_IL_002a;
				IL_01b3:
				try
				{
					TaskAwaiter<Stream> awaiter;
					if (num2 != 0)
					{
						TimeSpan httpImageTimeout = CvsCogSocketAcq.HttpImageTimeout;
						if (ABVMlHs3t5fxPy307fZ1(cvsCogSocket.GLTW3eMjGI))
						{
							UWTcJos3KZ9a8PFPoRTq(cvsCogSocket.Ki4WB9tsk9, rk7ahas3Cm833ds66cVV(kgbOBx7BanbFa22Hp9.ol99ukmDA(55758), _003CformatUrl_003E5__2));
						}
						Ci0ssvs35TDKmoNLPmex(CvsTraceSDK.TxCogSocket, fgKG5Ys3ccfkaLilIFcB(55804), new object[1] { _003CformatUrl_003E5__2 });
						awaiter = cvsCogSocket.LZxWMelhoh.MakeHttpGetRequest(_003CformatUrl_003E5__2, httpImageTimeout).GetAwaiter();
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
					Stream stream = result2;
					try
					{
						MemoryStream memoryStream = new MemoryStream();
						Eli6dWs3oCUg4eQQJQc1(result2, memoryStream);
						result = new Bitmap(memoryStream);
					}
					finally
					{
						if (num2 < 0 && stream != null)
						{
							eD1g8Ts3PvANiLQK1VNU(stream);
						}
					}
				}
				catch (Exception ex)
				{
					LsdYfAs3Y4mQyYb9Z3uI(CvsTraceSDK.Error, ex);
					cvsCogSocket.Ki4WB9tsk9.DebugException((string)ULXS95s3NXygA60PDpwX(fgKG5Ys3ccfkaLilIFcB(55854), _003CformatUrl_003E5__2, kgbOBx7BanbFa22Hp9.ol99ukmDA(17520)), ex);
					throw;
				}
				end_IL_002a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_038c;
			IL_038c:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0333;
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
		internal static bool mj8GvBs3jqvngCsa4Wyp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fgKG5Ys3ccfkaLilIFcB(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ICj8Mls32TBUPlOqUsLg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrWhiteSpace((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ujjAZis3WMJvLNI1p9Cw(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpQueryBuilder)P_0)[(string)P_1] = (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object k3Oo6Ls37FfaiypkpU1y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpQueryBuilder)P_0).Query;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ABVMlHs3t5fxPy307fZ1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TraceSwitch)P_0).TraceVerbose;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rk7ahas3Cm833ds66cVV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UWTcJos3KZ9a8PFPoRTq(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Debug((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ci0ssvs35TDKmoNLPmex(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1, (object[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Eli6dWs3oCUg4eQQJQc1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).CopyTo((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eD1g8Ts3PvANiLQK1VNU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LsdYfAs3Y4mQyYb9Z3uI(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ULXS95s3NXygA60PDpwX(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g8VEe9s3q2W0O9ONOjc2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g5ey2Os3BNupugpM7RlH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass81_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct NCvQev3k6JunYu8jjU : IAsyncStateMachine
		{
			public int x0bns2jcRv;

			public AsyncTaskMethodBuilder<Stream> Uc2n6XBQm9;

			public _003C_003Ec__DisplayClass81_0 Y4ynHUSFcb;

			private TaskAwaiter<Stream> l2VnKDcnXJ;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				Fi4m4lsuaFkNKj2DMEYo();
				int num;
				if (O30OO5suR3CxMuPD6M9x())
				{
					num = 4;
				}
				else
				{
					num = 5;
					if (Fi4m4lsuaFkNKj2DMEYo())
					{
						goto IL_0045;
					}
				}
				goto IL_01b0;
				IL_0045:
				int num2 = default;
				_003C_003Ec__DisplayClass81_0 obj = default;
				Stream result = default;
				try
				{
					TaskAwaiter<Stream> awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = obj._003C_003E4__this.LZxWMelhoh.MakeHttpGetRequest(obj.formatUrl, obj.timeout).GetAwaiter();
						num3 = 1;
						if (!O30OO5suR3CxMuPD6M9x())
						{
							goto IL_007d;
						}
						goto IL_009d;
					}
					awaiter = l2VnKDcnXJ;
					goto IL_00ff;
					IL_009d:
					while (true)
					{
						switch (num3)
						{
						case 8:
							break;
						default:
							goto IL_00ca;
						case 3:
							l2VnKDcnXJ = awaiter;
							num3 = 8;
							continue;
						case 2:
						case 5:
							goto IL_00ff;
						case 1:
							if (!awaiter.IsCompleted)
							{
								num3 = 6;
								continue;
							}
							goto case 9;
						case 6:
							num2 = (x0bns2jcRv = 0);
							num3 = 3;
							continue;
						case 7:
							num2 = (x0bns2jcRv = -1);
							num3 = 9;
							continue;
						case 0:
						case 4:
							return;
						case 9:
							result = awaiter.GetResult();
							goto end_IL_0045;
						}
						break;
					}
					goto IL_007d;
					IL_00ff:
					l2VnKDcnXJ = default;
					num3 = 7;
					goto IL_009d;
					IL_007d:
					Uc2n6XBQm9.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					goto IL_00ca;
					IL_00ca:
					O30OO5suR3CxMuPD6M9x();
					if (!Fi4m4lsuaFkNKj2DMEYo())
					{
						num3 = 0;
						if (Fi4m4lsuaFkNKj2DMEYo())
						{
						}
					}
					else
					{
						num3 = 2;
					}
					goto IL_009d;
					end_IL_0045:;
				}
				catch (Exception exception)
				{
					x0bns2jcRv = -2;
					Uc2n6XBQm9.SetException(exception);
					return;
				}
				x0bns2jcRv = -2;
				goto IL_01ec;
				IL_01ec:
				Uc2n6XBQm9.SetResult(result);
				num = 6;
				goto IL_01b0;
				IL_01b0:
				while (true)
				{
					switch (num)
					{
					case 0:
					case 4:
						num2 = x0bns2jcRv;
						goto case 1;
					case 2:
						break;
					default:
						num = 3;
						continue;
					case 1:
					case 5:
						obj = Y4ynHUSFcb;
						num = 2;
						continue;
					case 3:
						goto IL_01ec;
					case 6:
						return;
					}
					break;
				}
				goto IL_0045;
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
				Uc2n6XBQm9.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool O30OO5suR3CxMuPD6M9x()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool Fi4m4lsuaFkNKj2DMEYo()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public CvsCogSocket _003C_003E4__this;

		public string formatUrl;

		public TimeSpan timeout;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass81_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BKgORqs3r2xHiWoWfHtB();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(NCvQev3k6JunYu8jjU))]
		internal Task<Stream> _003CGetImageByHttp_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NCvQev3k6JunYu8jjU stateMachine = default;
			stateMachine.Uc2n6XBQm9 = AsyncTaskMethodBuilder<Stream>.Create();
			stateMachine.Y4ynHUSFcb = this;
			stateMachine.x0bns2jcRv = -1;
			stateMachine.Uc2n6XBQm9.Start(ref stateMachine);
			return stateMachine.Uc2n6XBQm9.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BKgORqs3r2xHiWoWfHtB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Diih0fs3xIxtTAgfBnPI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jme1k4s31fU8CLANooCr()
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
	private struct _003CGetPointCloudByHttpAsync_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string url;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			TimeSpan timeout = default;
			TaskAwaiter<Stream> awaiter = default;
			CvsCogSocket cvsCogSocket = default;
			Stream result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								timeout = LLSOqns3MXCntgnehlLp();
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
								if (vQjyr2s3OGElQ9k9yxSX())
								{
									goto IL_004e;
								}
							}
							goto IL_00a1;
							IL_004e:
							awaiter = cvsCogSocket.LZxWMelhoh.MakeHttpGetRequest(url, timeout).GetAwaiter();
							num3 = 1;
							goto IL_00a1;
							IL_00a1:
							while (true)
							{
								switch (num3)
								{
								case 6:
									return;
								case 5:
									break;
								case 3:
									_003C_003Eu__1 = default;
									num3 = 8;
									continue;
								case 7:
									_003C_003Eu__1 = awaiter;
									goto default;
								case 2:
								case 9:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 1;
								case 1:
									if (!awaiter.IsCompleted)
									{
										_ = 0;
										num3 = (dxfu0rs33R5uK7gKW1sq() ? 9 : 0);
										continue;
									}
									goto case 10;
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								default:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 6;
									continue;
								case 10:
									result = awaiter.GetResult();
									goto end_IL_00a1;
								}
								goto IL_004e;
								continue;
								end_IL_00a1:
								break;
							}
						}
						catch (Exception ex)
						{
							ANEQrUs3Qcys9DbBsjpT(CvsTraceSDK.Error, ex);
							P4VpYrs3uw9dBHXZ8tyE(cvsCogSocket.Ki4WB9tsk9, PyZHrws3eP3gEA8BVEHB(X3i4xVs3llYS7ugGquS8(55916), url, X3i4xVs3llYS7ugGquS8(17520)), ex);
							if (ex is CvsNetworkException)
							{
								throw;
							}
							throw new CvsNetworkException(ex);
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
					continue;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (dxfu0rs33R5uK7gKW1sq())
					{
						continue;
					}
					break;
				case 5:
					break;
				case 1:
				case 4:
					cvsCogSocket = _003C_003E4__this;
					goto case 0;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				vQjyr2s3OGElQ9k9yxSX();
				if (dxfu0rs33R5uK7gKW1sq())
				{
					num = 4;
					if (vQjyr2s3OGElQ9k9yxSX())
					{
					}
				}
				else
				{
					num = 0;
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
		internal static TimeSpan LLSOqns3MXCntgnehlLp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCogSocketAcq3DLineScan.HttpImage3DTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ANEQrUs3Qcys9DbBsjpT(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object X3i4xVs3llYS7ugGquS8(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PyZHrws3eP3gEA8BVEHB(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void P4VpYrs3uw9dBHXZ8tyE(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).DebugException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dxfu0rs33R5uK7gKW1sq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vQjyr2s3OGElQ9k9yxSX()
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
	private struct _003CGetPointCloudAsync_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogPointCloudRef> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string url;

		private TaskAwaiter<CvsCogPointCloudRef> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsCogSocket cvsCogSocket = default;
			int num2 = default;
			CvsCogPointCloudRef result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					cvsCogSocket = _003C_003E4__this;
					goto case 0;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<CvsCogPointCloudRef> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = cvsCogSocket.LZxWMelhoh.GetAsync<CvsCogPointCloudRef>(url).GetAwaiter();
							num3 = 6;
							if (1 == 0)
							{
								goto IL_0058;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (SNOGIYs3RHOwPa8feeOi())
							{
								goto IL_00aa;
							}
						}
						goto IL_00ca;
						IL_007b:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						goto IL_00ca;
						IL_00ca:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 7:
								goto IL_007b;
							default:
								return;
							case 0:
								return;
							case 2:
							case 3:
								goto IL_00aa;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 9;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_002f;
							}
							break;
						}
						goto IL_0058;
						IL_0058:
						_003C_003Eu__1 = awaiter;
						nmGWZ9s3I0dLi8E3vfLs();
						if (!SNOGIYs3RHOwPa8feeOi())
						{
							num3 = 2;
							if (false)
							{
								goto IL_007b;
							}
						}
						else
						{
							num3 = 0;
						}
						goto IL_00ca;
						IL_00aa:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_002f:;
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
					if (nmGWZ9s3I0dLi8E3vfLs())
					{
						continue;
					}
					goto case 5;
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!SNOGIYs3RHOwPa8feeOi()) ? 3 : 0);
					continue;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static bool nmGWZ9s3I0dLi8E3vfLs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SNOGIYs3RHOwPa8feeOi()
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
	private struct _003CPostImageByHTTPAndRunSheetAsync_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Bitmap bmp;

		public CvsCogSocket _003C_003E4__this;

		public string imageName;

		public bool sync;

		public CvsCellLocation? cellLocation;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0654;
			IL_001a:
			CvsCogSocket cvsCogSocket = _003C_003E4__this;
			num = 5;
			goto IL_0654;
			IL_0654:
			int num2 = default;
			TaskAwaiter<Stream> awaiter = default;
			TaskAwaiter<CvsCogSheetResult> awaiter3 = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!ythNOas3nXcKZwDTCv0F()) ? 4 : 0);
					continue;
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (bmp == null)
							{
								num3 = 19;
							}
							else if (!cvsCogSocket.IsRuntimeSupported)
							{
								if (cellLocation.HasValue)
								{
									goto IL_05b4;
								}
								num3 = 6;
							}
							else
							{
								string text = (string)QRQLHqs3bCY4bpM7y9Ku(TcZNgds3XqClQDPsxOO3(cvsCogSocket.CameraResourceNode, A32R3ds3GcWnXamh72Ra(56020)));
								awaiter = PostImageHelper.PostImageByHTTPAsync(cvsCogSocket.DeviceApi, bmp, text + (string)A32R3ds3GcWnXamh72Ra(56038), cvsCogSocket.dOXWFp2Viw((string)A32R3ds3GcWnXamh72Ra(49094)), eQEXFas365LZGNCJpm5j(), useSystemDebug: false, cvsCogSocket.Ki4WB9tsk9, null, imageName, sync).GetAwaiter();
								num3 = 29;
								if (1 == 0)
								{
									goto IL_032c;
								}
							}
							goto IL_00d0;
						case 4:
							awaiter3 = _003C_003Eu__2;
							num3 = 32;
							if (false)
							{
								return;
							}
							goto IL_00d0;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 25;
							if (false)
							{
								goto IL_00a8;
							}
							goto IL_00d0;
						case 2:
							awaiter3 = _003C_003Eu__2;
							num3 = 27;
							if (ythNOas3nXcKZwDTCv0F())
							{
							}
							goto IL_00d0;
						case 3:
							awaiter2 = _003C_003Eu__3;
							num3 = 12;
							if (ythNOas3nXcKZwDTCv0F())
							{
							}
							goto IL_00d0;
						case 1:
							{
								awaiter = _003C_003Eu__1;
								num3 = 23;
								goto IL_00d0;
							}
							IL_0260:
							num2 = (_003C_003E1__state = -1);
							goto IL_0269;
							IL_0269:
							awaiter.GetResult();
							break;
							IL_00d0:
							while (true)
							{
								switch (num3)
								{
								case 36:
									return;
								case 20:
									return;
								case 15:
									break;
								default:
									num3 = 11;
									if (0 == 0)
									{
										continue;
									}
									goto case 32;
								case 32:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 38;
									continue;
								case 27:
									_003C_003Eu__2 = default;
									num3 = 16;
									continue;
								case 10:
									num2 = (_003C_003E1__state = 4);
									num3 = 4;
									continue;
								case 6:
									goto IL_01c5;
								case 4:
									_003C_003Eu__2 = awaiter3;
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 12;
								case 12:
									_003C_003Eu__3 = default;
									num3 = 34;
									if (ClWsg8s3aU540qsmHM8y())
									{
										continue;
									}
									goto case 16;
								case 16:
									num2 = (_003C_003E1__state = -1);
									goto IL_0215;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 36;
									continue;
								case 11:
									return;
								case 0:
									goto IL_0260;
								case 19:
									throw new ArgumentException((string)A32R3ds3GcWnXamh72Ra(55978), (string)A32R3ds3GcWnXamh72Ra(9186));
								case 29:
									goto IL_032c;
								case 35:
									num2 = (_003C_003E1__state = -1);
									num3 = 2;
									continue;
								case 3:
									num2 = (_003C_003E1__state = 3);
									num3 = 24;
									continue;
								case 5:
									awaiter3 = cvsCogSocket.Sheet.RunAsync().GetAwaiter();
									num3 = 31;
									continue;
								case 33:
									goto IL_038e;
								case 18:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 23:
									_003C_003Eu__1 = default;
									num3 = 35;
									continue;
								case 14:
									awaiter2.GetResult();
									num3 = 17;
									continue;
								case 25:
									_003C_003Eu__1 = default;
									num3 = 0;
									continue;
								case 26:
									_003C_003Eu__1 = awaiter;
									num3 = 22;
									continue;
								case 22:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 20;
									if (!ythNOas3nXcKZwDTCv0F())
									{
										continue;
									}
									goto case 17;
								case 17:
									awaiter3 = cvsCogSocket.Sheet.RunAsync().GetAwaiter();
									goto case 8;
								case 9:
								case 37:
									_003C_003Eu__1 = awaiter;
									num3 = 1;
									continue;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 21;
									if (true)
									{
										continue;
									}
									return;
								case 21:
									return;
								case 24:
									_003C_003Eu__3 = awaiter2;
									num3 = 18;
									continue;
								case 8:
								case 30:
									if (!awaiter3.IsCompleted)
									{
										num3 = 10;
										continue;
									}
									goto case 38;
								case 2:
									goto IL_054f;
								case 28:
									if (!awaiter2.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 14;
								case 31:
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 15;
										continue;
									}
									goto IL_0215;
								case 34:
									num2 = (_003C_003E1__state = -1);
									num3 = 14;
									if (!ythNOas3nXcKZwDTCv0F())
									{
										continue;
									}
									goto end_IL_0049;
								case 13:
									goto end_IL_0049;
								case 38:
									{
										awaiter3.GetResult();
										goto end_IL_0049;
									}
									IL_0215:
									awaiter3.GetResult();
									num3 = 13;
									continue;
								}
								break;
								IL_038e:
								object obj = null;
								goto IL_0399;
								IL_01c5:
								ICogSocketAcq acq = cvsCogSocket.Acq;
								if (acq == null)
								{
									num3 = 33;
									continue;
								}
								obj = acq.AcqPath;
								goto IL_0399;
								IL_0399:
								if (!DgQs8xs3pVe8we83FIGR(obj))
								{
									awaiter = PostImageHelper.PostImageByHTTPAsync(cvsCogSocket.DeviceApi, bmp, (string)YNcoi4s30968TolavS62(cvsCogSocket.Acq.AcqPath, A32R3ds3GcWnXamh72Ra(56038)), cvsCogSocket.dOXWFp2Viw(kgbOBx7BanbFa22Hp9.ol99ukmDA(49094)), eQEXFas365LZGNCJpm5j(), useSystemDebug: false, cvsCogSocket.Ki4WB9tsk9, null, imageName, sync).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_ = 1;
										num3 = (ythNOas3nXcKZwDTCv0F() ? 8 : 37);
										continue;
									}
									goto IL_054f;
								}
								goto IL_05b4;
								IL_054f:
								awaiter.GetResult();
								num3 = 5;
							}
							goto IL_00a8;
							IL_032c:
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								num3 = 26;
								goto IL_00d0;
							}
							goto IL_0269;
							IL_00a8:
							_003C_003Eu__2 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
							IL_05b4:
							if (!cellLocation.HasValue)
							{
								throw new ArgumentException((string)A32R3ds3GcWnXamh72Ra(56060), (string)A32R3ds3GcWnXamh72Ra(56100));
							}
							awaiter2 = cvsCogSocket.Sheet.PostImageByHTTPAsync(cellLocation.Value, bmp, sync).GetAwaiter();
							num3 = 28;
							goto IL_00d0;
							end_IL_0049:
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
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					return;
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
		internal static object A32R3ds3GcWnXamh72Ra(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TcZNgds3XqClQDPsxOO3(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QRQLHqs3bCY4bpM7y9Ku(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).RootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan eQEXFas365LZGNCJpm5j()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCogSocketAcq.HttpImageTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DgQs8xs3pVe8we83FIGR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YNcoi4s30968TolavS62(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ClWsg8s3aU540qsmHM8y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ythNOas3nXcKZwDTCv0F()
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
	private struct _003CPostPointCloudByHTTPAsync_003Ed__85 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public Stream rawData;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aBUiH8s34ggZ7oMcc6LY();
			int num;
			if (!jiIWvFs3kX1NbEsOlnDx())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0052;
				}
			}
			goto IL_0224;
			IL_006d:
			int num2 = default;
			CvsCogSocket cvsCogSocket = default;
			try
			{
				TaskAwaiter<Stream> awaiter = default;
				int num3;
				if (num2 == 0)
				{
					awaiter = _003C_003Eu__1;
					_ = 0;
					num3 = (aBUiH8s34ggZ7oMcc6LY() ? 5 : 3);
					goto IL_0152;
				}
				if (cvsCogSocket.IsRuntimeSupported)
				{
					num3 = 0;
					goto IL_0152;
				}
				goto end_IL_006d;
				IL_0152:
				string url = default;
				while (true)
				{
					switch (num3)
					{
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							continue;
						}
						break;
					case 0:
						url = (string)HIUsY8s3mnsLK5BSlHut(((ResourceNode)tb1pLis3F3A482qeWOpB(cvsCogSocket.CameraResourceNode, P7bYdqs3fZff3ePEfvLa(56020))).RootResourceUri, P7bYdqs3fZff3ePEfvLa(56128));
						num3 = 2;
						continue;
					case 2:
						awaiter = PostImageHelper.PostDataByHTTPAsync(cvsCogSocket.DeviceApi, rawData, (string)P7bYdqs3fZff3ePEfvLa(56160), url, cvsCogSocket.dOXWFp2Viw(kgbOBx7BanbFa22Hp9.ol99ukmDA(56204)), CvsCogSocketAcq3DLineScan.HttpImage3DTimeout, useSystemDebug: false, cvsCogSocket.Ki4WB9tsk9).GetAwaiter();
						num3 = 8;
						continue;
					case 5:
					case 6:
						_003C_003Eu__1 = default;
						goto case 3;
					case 1:
						num2 = (_003C_003E1__state = 0);
						goto case 4;
					default:
						num3 = 4;
						continue;
					case 9:
						return;
					case 3:
					case 7:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 4:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 9;
						continue;
					case 10:
						break;
					}
					break;
				}
				awaiter.GetResult();
				end_IL_006d:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0052;
			IL_0052:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!aBUiH8s34ggZ7oMcc6LY())
			{
				goto IL_006d;
			}
			goto IL_0224;
			IL_0224:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					cvsCogSocket = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				case 4:
					goto IL_006d;
				default:
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0052;
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
		internal static object P7bYdqs3fZff3ePEfvLa(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tb1pLis3F3A482qeWOpB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HIUsY8s3mnsLK5BSlHut(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aBUiH8s34ggZ7oMcc6LY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jiIWvFs3kX1NbEsOlnDx()
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
	private struct _003CMergePointCloudAndRun_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string masterUrl;

		public string slaveUrl;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			string text = default;
			CvsCogSocket cvsCogSocket = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					if (true)
					{
						continue;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							text = (string)V5lO2Is38tK03ZVuHidu(xx0cgAs3JtsC37VObTU8(cvsCogSocket.CameraResourceNode, ENLrTss3ZXFyt1U86wvm(56020)));
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (!B4IKsas3gHLIIX0RjABQ())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = default;
								goto case 7;
							case 6:
								awaiter = cvsCogSocket.DeviceApi.PostAsync<object>((string)nnuY9Js3znwudEOVxWn4(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(56258)), new object[2] { masterUrl, slaveUrl }).GetAwaiter();
								num3 = 2;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 0:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 1;
								num3 = (B4IKsas3gHLIIX0RjABQ() ? 9 : 0);
								continue;
							case 3:
								return;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									if (h1JTPTs3yDyGSjEg6sHI())
									{
										continue;
									}
								}
								break;
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
					goto default;
				case 0:
					break;
				case 6:
					return;
				}
				do
				{
					cvsCogSocket = _003C_003E4__this;
					_ = 1;
					if (B4IKsas3gHLIIX0RjABQ())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (!B4IKsas3gHLIIX0RjABQ())
					{
						break;
					}
					return;
				}
				while (1 == 0);
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
		internal static object ENLrTss3ZXFyt1U86wvm(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xx0cgAs3JtsC37VObTU8(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object V5lO2Is38tK03ZVuHidu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).RootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nnuY9Js3znwudEOVxWn4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h1JTPTs3yDyGSjEg6sHI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B4IKsas3gHLIIX0RjABQ()
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
	private struct _003CAcceptsPointCloudsAsync_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			CvsCogSocket cvsCogSocket = default;
			string text = default;
			TaskAwaiter<object> awaiter = default;
			bool valueOrDefault = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						if (num2 != 0)
						{
							bool? uQxWTMdR0E = cvsCogSocket.uQxWTMdR0E;
							if (uQxWTMdR0E.HasValue)
							{
								goto IL_01c5;
							}
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								text = (string)avhfxcsO9SunCSnhMKiT(HhHNpGsOLxCZ6SbtuV8A(cvsCogSocket.CameraResourceNode, g4LIl0sOhpV3oHGyCcsN(56306)));
								num3 = 5;
								if (false)
								{
									goto IL_0060;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 4;
								if (sapwoGsOsyaRdmQaY2Qb())
								{
									goto IL_010a;
								}
							}
							goto IL_0080;
							IL_018a:
							awaiter.GetResult();
							num3 = 10;
							if (aUqWeksOw1SWpedD5YZG())
							{
								goto IL_0080;
							}
							goto IL_01a2;
							IL_0136:
							num2 = (_003C_003E1__state = -1);
							goto IL_018a;
							IL_0080:
							while (true)
							{
								switch (num3)
								{
								case 3:
									break;
								default:
									num3 = 1;
									continue;
								case 5:
									awaiter = cvsCogSocket.DeviceApi.PostAsync<object>((string)DacRj2sOSJiRjVpe33YW(text, g4LIl0sOhpV3oHGyCcsN(56314)), Array.Empty<object>()).GetAwaiter();
									num3 = 9;
									continue;
								case 1:
									return;
								case 4:
									goto IL_010a;
								case 6:
								case 8:
									goto IL_0136;
								case 0:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									if (sapwoGsOsyaRdmQaY2Qb())
									{
									}
									continue;
								case 9:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 0;
										continue;
									}
									goto IL_018a;
								case 2:
								case 7:
									goto IL_018a;
								case 10:
									goto IL_01a2;
								}
								break;
							}
							goto IL_0060;
							IL_01a2:
							cvsCogSocket.uQxWTMdR0E = true;
							goto end_IL_0032;
							IL_010a:
							_003C_003Eu__1 = default;
							sapwoGsOsyaRdmQaY2Qb();
							if (aUqWeksOw1SWpedD5YZG())
							{
								num3 = 8;
								if (sapwoGsOsyaRdmQaY2Qb())
								{
									goto IL_0136;
								}
							}
							else
							{
								num3 = 2;
							}
							goto IL_0080;
							IL_0060:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							end_IL_0032:;
						}
						catch (Exception)
						{
							cvsCogSocket.uQxWTMdR0E = false;
						}
						goto IL_01c5;
						IL_01c5:
						valueOrDefault = cvsCogSocket.uQxWTMdR0E == true;
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
				case 1:
				case 5:
					cvsCogSocket = _003C_003E4__this;
					goto case 2;
				case 0:
					_003C_003Et__builder.SetResult(valueOrDefault);
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					sapwoGsOsyaRdmQaY2Qb();
					if (!aUqWeksOw1SWpedD5YZG())
					{
						num = 3;
						if (aUqWeksOw1SWpedD5YZG())
						{
							break;
						}
						goto case 0;
					}
					num = 5;
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
		internal static object g4LIl0sOhpV3oHGyCcsN(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HhHNpGsOLxCZ6SbtuV8A(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object avhfxcsO9SunCSnhMKiT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).RootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DacRj2sOSJiRjVpe33YW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aUqWeksOw1SWpedD5YZG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sapwoGsOsyaRdmQaY2Qb()
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
	private struct _003CIsQuadMeshAsync_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string url;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (Tw3qbesOEyKxJNUluUyf())
			{
				num = 5;
				if (!Tw3qbesOEyKxJNUluUyf())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (nvFd7CsOvUEGAxud3EFI())
				{
				}
			}
			goto IL_01e4;
			IL_0225:
			CvsCogSocket cvsCogSocket = _003C_003E4__this;
			num = 2;
			goto IL_01e4;
			IL_01e4:
			int num2 = default;
			bool result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					break;
				case 2:
					try
					{
						try
						{
							TaskAwaiter<bool> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = cvsCogSocket.DeviceApi.GetAsync<bool>((string)M4RHonsOVHMdSASdqcy5(url, WqR4ZRsOHMDSGiflGI8n(56332))).GetAwaiter();
								_ = 1;
								num3 = (nvFd7CsOvUEGAxud3EFI() ? 2 : 6);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 3:
									_003C_003Eu__1 = default;
									num3 = 5;
									if (nvFd7CsOvUEGAxud3EFI())
									{
									}
									continue;
								case 8:
									return;
								case 0:
								case 6:
									if (awaiter.IsCompleted)
									{
										break;
									}
									goto case 1;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 8;
									continue;
								case 5:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 7:
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									if (true)
									{
										continue;
									}
									break;
								case 9:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						catch (Exception ex)
						{
							YVvdH8sOAnLF5mhPOaQY(cvsCogSocket.Ki4WB9tsk9, WqR4ZRsOHMDSGiflGI8n(56358), ex);
							if (ex is CvsNetworkException)
							{
								throw;
							}
							throw new CvsNetworkException(ex);
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
					continue;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 1:
				case 4:
					goto IL_0225;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_0225;
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
		internal static object WqR4ZRsOHMDSGiflGI8n(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M4RHonsOVHMdSASdqcy5(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YVvdH8sOAnLF5mhPOaQY(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).DebugException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tw3qbesOEyKxJNUluUyf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nvFd7CsOvUEGAxud3EFI()
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
	private struct _003CUploadPointCloudAsync_003Ed__89 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogRef> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public Stream rawData;

		public string clientId;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsCogSocket cvsCogSocket = default;
			CvsCogRef result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					cvsCogSocket = _003C_003E4__this;
					goto case 2;
				case 4:
					do
					{
						num2 = _003C_003E1__state;
						oqCvgcsOUJjfMvLgm03R();
						if (!CGjGM5sODimXrmBYbRfs())
						{
							num = 3;
							continue;
						}
						num = 0;
						break;
					}
					while (1 == 0);
					break;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						CvsCogRef cvsCogRef;
						try
						{
							TaskAwaiter<Stream> awaiter;
							if (num2 != 0)
							{
								string url = (string)mQtLZysOiV7qQUfDrRvC(i99bgEsOd99o2L7mVklE(cvsCogSocket.CameraResourceNode, o8r7jdsOTD4WWRH0kJPe(56306))) + kgbOBx7BanbFa22Hp9.ol99ukmDA(56412);
								awaiter = PostImageHelper.PostDataByHTTPAsync(cvsCogSocket.DeviceApi, rawData, (string)o8r7jdsOTD4WWRH0kJPe(56160), url, cvsCogSocket.dOXWFp2Viw((string)o8r7jdsOTD4WWRH0kJPe(56428)), WE8QbosOqhfc4PxjYqyN(), useSystemDebug: false, cvsCogSocket.Ki4WB9tsk9, clientId).GetAwaiter();
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
							StreamReader streamReader = new StreamReader(awaiter.GetResult());
							try
							{
								cvsCogRef = JsonConvert.DeserializeObject<CvsCogRef>((string)wamcCXsOBnhG1W3TqSWx(streamReader));
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)streamReader)?.Dispose();
								}
							}
						}
						catch (Exception ex)
						{
							c6nOW2sOjSRyybX0u5ji(cvsCogSocket.Ki4WB9tsk9, o8r7jdsOTD4WWRH0kJPe(56474), ex);
							if (ex is CvsNetworkException)
							{
								throw;
							}
							throw new CvsNetworkException(ex);
						}
						result = cvsCogRef;
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
					if (!CGjGM5sODimXrmBYbRfs())
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
		internal static object o8r7jdsOTD4WWRH0kJPe(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object i99bgEsOd99o2L7mVklE(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mQtLZysOiV7qQUfDrRvC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).RootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan WE8QbosOqhfc4PxjYqyN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCogSocketAcq3DLineScan.HttpImage3DTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wamcCXsOBnhG1W3TqSWx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TextReader)P_0).ReadToEnd();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void c6nOW2sOjSRyybX0u5ji(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).DebugException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CGjGM5sODimXrmBYbRfs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oqCvgcsOUJjfMvLgm03R()
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
	private struct _003CAddResourceAsync_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string resourceUrl;

		public string clientId;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			string rootResourceUri = default;
			CvsCogSocket cvsCogSocket = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							rootResourceUri = ((ResourceNode)cRZp8ksO7iYomsL0tE3y(cvsCogSocket.CameraResourceNode, HJwjfRsOWXv65ThKPMZ8(56550))).RootResourceUri;
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (false)
							{
								goto IL_005b;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 5:
								return;
							case 8:
								break;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 7:
								awaiter = cvsCogSocket.DeviceApi.PostAsync<object>(rootResourceUri + (string)HJwjfRsOWXv65ThKPMZ8(56572), new object[2] { resourceUrl, clientId }).GetAwaiter();
								num3 = 4;
								if (FRJSjVsOc3QrVJ9sRgId())
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = awaiter;
								break;
							default:
								num3 = 8;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!FRJSjVsOc3QrVJ9sRgId()) ? 1 : 3);
									continue;
								}
								goto case 10;
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0106;
							}
							goto IL_005b;
							continue;
							end_IL_0106:
							break;
						}
						goto end_IL_0018;
						IL_005b:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0018:;
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
				case 5:
					num2 = _003C_003E1__state;
					ohJWtZsO2NCcJcj7v8RY();
					if (FRJSjVsOc3QrVJ9sRgId())
					{
						num = 0;
						break;
					}
					num = 3;
					if (0 == 0)
					{
						break;
					}
					return;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					cvsCogSocket = _003C_003E4__this;
					goto case 2;
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
		internal static object HJwjfRsOWXv65ThKPMZ8(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cRZp8ksO7iYomsL0tE3y(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FRJSjVsOc3QrVJ9sRgId()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ohJWtZsO2NCcJcj7v8RY()
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
	private struct _003CReleaseResourceAsync_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string resourceUrl;

		public string clientId;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vIIWDqsOCM5GI106Fm8F();
			int num;
			if (AhPDXosOts0Rq36Ndj3f())
			{
				num = 5;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_020e;
			IL_0041:
			int num2 = _003C_003E1__state;
			num = 2;
			goto IL_020e;
			IL_020e:
			string text = default;
			CvsCogSocket cvsCogSocket = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 5:
					goto IL_0041;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							text = (string)LVNyiRsOoJy70XGuDE32(vNOW5ksO5oKkGWMOHt6k(cvsCogSocket.CameraResourceNode, gNa8sjsOKAYUHh5RXvqp(56550)));
							_ = 0;
							num3 = ((!AhPDXosOts0Rq36Ndj3f()) ? 3 : 2);
							goto IL_00fa;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0148;
						IL_00fa:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								awaiter = cvsCogSocket.DeviceApi.PostAsync<object>((string)SR3RVdsOPuMFxEOhWbMv(text, gNa8sjsOKAYUHh5RXvqp(56588)), new object[2] { resourceUrl, clientId }).GetAwaiter();
								num3 = 5;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
							case 6:
								break;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (AhPDXosOts0Rq36Ndj3f())
								{
									continue;
								}
								return;
							case 4:
								return;
							case 10:
								awaiter.GetResult();
								goto end_IL_00fa;
							}
							goto IL_0148;
							continue;
							end_IL_00fa:
							break;
						}
						goto end_IL_0067;
						IL_0148:
						_003C_003Eu__1 = default;
						num3 = 9;
						if (vIIWDqsOCM5GI106Fm8F())
						{
						}
						goto IL_00fa;
						end_IL_0067:;
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
			goto IL_002a;
			IL_002a:
			cvsCogSocket = _003C_003E4__this;
			num = 4;
			if (vIIWDqsOCM5GI106Fm8F())
			{
				goto IL_0041;
			}
			goto IL_020e;
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
		internal static object gNa8sjsOKAYUHh5RXvqp(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vNOW5ksO5oKkGWMOHt6k(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LVNyiRsOoJy70XGuDE32(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).RootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SR3RVdsOPuMFxEOhWbMv(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AhPDXosOts0Rq36Ndj3f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vIIWDqsOCM5GI106Fm8F()
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
	private struct _003CLookupResourceAsync_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string resourceUrl;

		public string clientId;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			string text = default;
			CvsCogSocket cvsCogSocket = default;
			TaskAwaiter<bool> awaiter = default;
			bool result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							text = (string)o6P5elsOrEryi6jlCOeR(LahubCsO1O9wxLnEv8pw(cvsCogSocket.CameraResourceNode, gin53SsOxQLkNe9aOESP(56550)));
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (EMEDyxsONLV3n7fCGJKy())
							{
								goto IL_00b5;
							}
						}
						goto IL_005d;
						IL_00b5:
						if (!awaiter.IsCompleted)
						{
							_ = 0;
							num3 = ((!axX9PrsOYvlqBGIJpQhb()) ? 8 : 9);
							goto IL_005d;
						}
						goto IL_0181;
						IL_0181:
						result = awaiter.GetResult();
						goto end_IL_0018;
						IL_005d:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 1:
								return;
							case 5:
								break;
							case 7:
								awaiter = cvsCogSocket.DeviceApi.PostAsync<bool>((string)mxGctXsO3wt9YYua5dXD(text, gin53SsOxQLkNe9aOESP(56610)), new object[2] { resourceUrl, clientId }).GetAwaiter();
								num3 = 5;
								continue;
							case 2:
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (axX9PrsOYvlqBGIJpQhb())
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								if (!EMEDyxsONLV3n7fCGJKy())
								{
									continue;
								}
								goto IL_0181;
							case 10:
								goto IL_0181;
							}
							break;
						}
						goto IL_00b5;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 0:
					cvsCogSocket = _003C_003E4__this;
					_ = 0;
					if (!axX9PrsOYvlqBGIJpQhb())
					{
						num = 5;
						if (axX9PrsOYvlqBGIJpQhb())
						{
							continue;
						}
						goto case 4;
					}
					num = 1;
					if (!EMEDyxsONLV3n7fCGJKy())
					{
						continue;
					}
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static object gin53SsOxQLkNe9aOESP(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LahubCsO1O9wxLnEv8pw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object o6P5elsOrEryi6jlCOeR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).RootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mxGctXsO3wt9YYua5dXD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool axX9PrsOYvlqBGIJpQhb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EMEDyxsONLV3n7fCGJKy()
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
	private struct _003CReleaseClientResourcesAsync_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string clientId;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WCCt96sOM14rWwoBN7X5();
			int num;
			if (sJ764bsOOKJFFiLLyPDh())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (false)
				{
					return;
				}
			}
			int num2 = default;
			string text = default;
			CvsCogSocket cvsCogSocket = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							text = (string)g4qI7msOeCpIyYWB69TV(cAIyjFsOlFVQ6cM2VJA6(cvsCogSocket.CameraResourceNode, wLHFH8sOQgqIb8ZfObMD(56550)));
							num3 = 5;
							if (1 == 0)
							{
								goto IL_0055;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_013c;
						IL_013c:
						while (true)
						{
							switch (num3)
							{
							case 6:
								break;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 9:
								return;
							case 1:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 5:
								awaiter = cvsCogSocket.DeviceApi.PostAsync<object>(text + (string)wLHFH8sOQgqIb8ZfObMD(56632), new object[1] { clientId }).GetAwaiter();
								sJ764bsOOKJFFiLLyPDh();
								if (!WCCt96sOM14rWwoBN7X5())
								{
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto default;
								}
								num3 = 3;
								continue;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 10:
								awaiter.GetResult();
								goto end_IL_013c;
							}
							goto IL_0055;
							continue;
							end_IL_013c:
							break;
						}
						goto end_IL_0028;
						IL_0055:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_013c;
						end_IL_0028:;
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
					continue;
				case 1:
				case 3:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				cvsCogSocket = _003C_003E4__this;
				num = 4;
				if (WCCt96sOM14rWwoBN7X5())
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
		internal static object wLHFH8sOQgqIb8ZfObMD(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cAIyjFsOlFVQ6cM2VJA6(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g4qI7msOeCpIyYWB69TV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).RootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sJ764bsOOKJFFiLLyPDh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WCCt96sOM14rWwoBN7X5()
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
	private struct _003CGetSvgByHttp_003Ed__95 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string url;

		public double scale;

		public CvsImageOrientation orientation;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (X0fpZAsOuJ18Rb5CWWGF() ? 1 : 5);
			CvsCogSocket cvsCogSocket2 = default;
			int num2 = default;
			string result = default;
			do
			{
				IL_019f:
				switch (num)
				{
				case 2:
					cvsCogSocket2 = _003C_003E4__this;
					num = 4;
					goto IL_019f;
				case 4:
					try
					{
						TaskAwaiter<string> awaiter;
						int num4;
						if (num2 != 0)
						{
							CvsCogSocket cvsCogSocket = cvsCogSocket2;
							string text = url;
							object obj = pG7T0ysORKlo8510rdXx(scale, 4);
							int num3 = (int)orientation;
							awaiter = cvsCogSocket.GetSvgByHttp(text, (string)obj, num3.ToString()).GetAwaiter();
							_ = 0;
							if (X0fpZAsOuJ18Rb5CWWGF())
							{
								num4 = 5;
							}
							else
							{
								num4 = 7;
								if (!X0fpZAsOuJ18Rb5CWWGF())
								{
									goto IL_009d;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num4 = 3;
						}
						goto IL_00e4;
						IL_00e4:
						while (true)
						{
							switch (num4)
							{
							case 4:
								num2 = (_003C_003E1__state = 0);
								break;
							case 2:
							case 7:
								break;
							case 3:
								_003C_003Eu__1 = default;
								num4 = 6;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num4 = 1;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num4 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 5:
								if (!awaiter.IsCompleted)
								{
									num4 = 4;
									continue;
								}
								goto case 9;
							case 1:
								return;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00e4;
							}
							goto IL_009d;
							continue;
							end_IL_00e4:
							break;
						}
						goto end_IL_0035;
						IL_009d:
						_003C_003Eu__1 = awaiter;
						num4 = 8;
						goto IL_00e4;
						end_IL_0035:;
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
					num2 = _003C_003E1__state;
					num = 2;
					goto IL_019f;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
			}
			while (X0fpZAsOuJ18Rb5CWWGF());
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
		internal static object pG7T0ysORKlo8510rdXx(double P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.ToTruncString(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X0fpZAsOuJ18Rb5CWWGF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QoxbZfsOI57ewuy49CDC()
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
	private struct _003CGetSvgByHttp_003Ed__96 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string url;

		public string scale;

		public string rotation;

		public CvsCogSocket _003C_003E4__this;

		private string _003CformatUrl_003E5__2;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			string result = default;
			CvsCogSocket cvsCogSocket = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!WRh2fIsOnlQQLKc29UUk())
					{
						num = 5;
						break;
					}
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 6:
					_003CformatUrl_003E5__2 = null;
					goto case 3;
				case 3:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 2:
					try
					{
						if (num2 == 0)
						{
							goto IL_0114;
						}
						if (!jFkovSsOGO9HiqrjQ0mB(url))
						{
							HttpQueryBuilder httpQueryBuilder = new HttpQueryBuilder();
							if (!jFkovSsOGO9HiqrjQ0mB(scale))
							{
								eGmtsisObjvmtPkTaMPd(httpQueryBuilder, rpG0I4sOX1m10wNAeOeb(56660), scale);
							}
							if (!jFkovSsOGO9HiqrjQ0mB(rotation))
							{
								eGmtsisObjvmtPkTaMPd(httpQueryBuilder, rpG0I4sOX1m10wNAeOeb(56674), rotation);
							}
							string text = (string)nvA5dfsO6J2KDDUKP3B0(httpQueryBuilder);
							_003CformatUrl_003E5__2 = (string)(jFkovSsOGO9HiqrjQ0mB(text) ? url : TvWENJsOpGpOYnINAKqZ(url, kgbOBx7BanbFa22Hp9.ol99ukmDA(15296), text));
							goto IL_0114;
						}
						result = string.Empty;
						goto end_IL_0064;
						IL_0114:
						try
						{
							TaskAwaiter<Stream> awaiter;
							if (num2 != 0)
							{
								if (PLqx8AsO0MuVqrOV0hWq(cvsCogSocket.GLTW3eMjGI))
								{
									xl1itIsOky7h7rlq18Zh(cvsCogSocket.Ki4WB9tsk9, srb7rIsO4wI9fcSajNcO(rpG0I4sOX1m10wNAeOeb(56684), _003CformatUrl_003E5__2));
								}
								YjPJyqsOf7l5ONfEOPTM(CvsTraceSDK.Svg, kgbOBx7BanbFa22Hp9.ol99ukmDA(56716), new object[1] { _003CformatUrl_003E5__2 });
								awaiter = cvsCogSocket.LZxWMelhoh.MakeHttpGetRequest(_003CformatUrl_003E5__2, TimeSpan.FromSeconds(10.0)).GetAwaiter();
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
							StreamReader streamReader = new StreamReader(awaiter.GetResult());
							try
							{
								string text2 = (string)oku3lWsOFyatNW5YiZ05(streamReader);
								_ = 1;
								int num3;
								if (!WRh2fIsOnlQQLKc29UUk())
								{
									num3 = 2;
									if (1 == 0)
									{
										goto IL_020f;
									}
								}
								else
								{
									num3 = 3;
									if (false)
									{
										goto IL_0267;
									}
								}
								switch (num3)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_0267;
								}
								goto IL_020f;
								IL_0267:
								result = text2;
								goto end_IL_01ee;
								IL_020f:
								CvsTraceSDK.Svg.TraceMessage(kgbOBx7BanbFa22Hp9.ol99ukmDA(56754), text2);
								goto IL_0267;
								end_IL_01ee:;
							}
							finally
							{
								if (num2 < 0 && streamReader != null)
								{
									rSbg49sOmdV47x9htjnj(streamReader);
								}
							}
						}
						catch (Exception ex)
						{
							Oa8G6FsOyDdYJtlEgOKR(CvsTraceSDK.Error, ex);
							NZClSFsOgxHgq3hmuRDK(cvsCogSocket.Ki4WB9tsk9, TvWENJsOpGpOYnINAKqZ(rpG0I4sOX1m10wNAeOeb(56774), _003CformatUrl_003E5__2, rpG0I4sOX1m10wNAeOeb(17520)), ex);
							throw;
						}
						end_IL_0064:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CformatUrl_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
					break;
				case 1:
				case 5:
					cvsCogSocket = _003C_003E4__this;
					num = 2;
					if (!qvhKuysOagG0fyyZ8DfC())
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
		internal static bool jFkovSsOGO9HiqrjQ0mB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rpG0I4sOX1m10wNAeOeb(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eGmtsisObjvmtPkTaMPd(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpQueryBuilder)P_0)[(string)P_1] = (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nvA5dfsO6J2KDDUKP3B0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpQueryBuilder)P_0).Query;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TvWENJsOpGpOYnINAKqZ(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PLqx8AsO0MuVqrOV0hWq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TraceSwitch)P_0).TraceVerbose;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object srb7rIsO4wI9fcSajNcO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xl1itIsOky7h7rlq18Zh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Debug((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YjPJyqsOf7l5ONfEOPTM(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1, (object[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oku3lWsOFyatNW5YiZ05(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TextReader)P_0).ReadToEnd();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rSbg49sOmdV47x9htjnj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Oa8G6FsOyDdYJtlEgOKR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NZClSFsOgxHgq3hmuRDK(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).DebugException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qvhKuysOagG0fyyZ8DfC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WRh2fIsOnlQQLKc29UUk()
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
	private struct _003CApplyPointCloudFiltersAndRun_003Ed__97 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		public string pointCloudResourceUrl;

		public bool sync;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			string rootResourceUri = default;
			CvsCogSocket cvsCogSocket = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					if (Hq7PshsOZcEugi1hUe7l())
					{
						num = 4;
						if (!noVsv4sOJ3A6e2mLEcLr())
						{
							break;
						}
						goto case 0;
					}
					num = 5;
					break;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							rootResourceUri = ((ResourceNode)rQ9SVXsOznJqD12t7mID(cvsCogSocket.CameraResourceNode, pqjimYsO8ID9T9UHl6H8(56020))).RootResourceUri;
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 8:
								awaiter = cvsCogSocket.DeviceApi.PostAsync<object>((string)kIxae6sMwJabI7U3oGeB(rootResourceUri, pqjimYsO8ID9T9UHl6H8(56822)), new object[2] { pointCloudResourceUrl, sync }).GetAwaiter();
								_ = 0;
								if (Hq7PshsOZcEugi1hUe7l())
								{
									num3 = 0;
									if (noVsv4sOJ3A6e2mLEcLr())
									{
									}
									continue;
								}
								num3 = 7;
								if (Hq7PshsOZcEugi1hUe7l())
								{
									continue;
								}
								break;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								return;
							case 3:
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
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
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					cvsCogSocket = _003C_003E4__this;
					num = 0;
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
		internal static object pqjimYsO8ID9T9UHl6H8(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rQ9SVXsOznJqD12t7mID(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).GetChildResource((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kIxae6sMwJabI7U3oGeB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hq7PshsOZcEugi1hUe7l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool noVsv4sOJ3A6e2mLEcLr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, bool> _003C_003E9__98_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RGV3F6sML8j4uj4FB0xY();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RGV3F6sML8j4uj4FB0xY();
			vJ6KsqsM9hRSoDjWLMSN(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CAnyNullOrEmpty_003Eb__98_0(string str)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LJ5jddsMSibGxJs6b4CX(str);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RGV3F6sML8j4uj4FB0xY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rqY3a2sMsbvoSH1VOaXT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fdu8xSsMh2aefmH9jJRW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vJ6KsqsM9hRSoDjWLMSN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LJ5jddsMSibGxJs6b4CX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CDispose_003Eb__33_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocket _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			CvsCogSocket cvsCogSocket = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (wWELrrsMEZhLra7mP1gD())
					{
						break;
					}
					goto case 5;
				case 5:
					cvsCogSocket = _003C_003E4__this;
					ePiyEWsMvNSeL3nJDbIk();
					if (wWELrrsMEZhLra7mP1gD())
					{
						num = 1;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					}
					num = 4;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							goto IL_00cb;
						}
						if (cvsCogSocket.rlDWp6Tibn != null)
						{
							num3 = 3;
							goto IL_00cb;
						}
						goto end_IL_0067;
						IL_00cb:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 0:
							case 1:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 2;
							case 3:
								do
								{
									awaiter = TV8qrgsMVbcew1ubV0M4(HDSF4isMHDA58bwnFMgn(cvsCogSocket.rlDWp6Tibn));
									wWELrrsMEZhLra7mP1gD();
									if (ePiyEWsMvNSeL3nJDbIk())
									{
										num3 = 5;
										continue;
									}
									num3 = 0;
									break;
								}
								while (1 == 0);
								continue;
							case 2:
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 4:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (wWELrrsMEZhLra7mP1gD())
								{
									continue;
								}
								break;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_0067:;
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
		internal static object HDSF4isMHDA58bwnFMgn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICogSocketAcq)P_0).RemoveListenersAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter TV8qrgsMVbcew1ubV0M4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wWELrrsMEZhLra7mP1gD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ePiyEWsMvNSeL3nJDbIk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private ICogSocketAcq rlDWp6Tibn;

	private readonly CvsCogSocketIo CsoWhpY7vi;

	private readonly CvsCogSocketSheet E0nW4b05uL;

	private readonly ResourceNode SUcWlIZCEg;

	private readonly Uri VqpWgQli3J;

	private readonly Uri YMfWqqAqPy;

	private bool? uQxWTMdR0E;

	private readonly ILogger Ki4WB9tsk9;

	private bool? kqLWJWODF0;

	private IRemoteDeviceApi LZxWMelhoh;

	private readonly WaitForBuildCompleteDelegate mxVWoFQPr0;

	private string Eg3WABEMkg;

	private CvsFunctionTable yK2WtgyAgT;

	private CvsProcessorConstants rm9WWbbyWf;

	private TraceSwitch GLTW3eMjGI;

	public bool ResultChangedEnabled;

	[CompilerGenerated]
	private EventHandler LOHWLjnORD;

	[CompilerGenerated]
	private EventHandler he2WkPWl6k;

	internal string ConnectionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VqpWgQli3J.ToString();
		}
	}

	public Uri WsUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VqpWgQli3J;
		}
	}

	public Uri HttpUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YMfWqqAqPy;
		}
	}

	internal IRemoteDeviceApi DeviceApi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LZxWMelhoh;
		}
	}

	internal static TimeSpan TaskTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nG95teR4SV9JY4kp3hE();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CogSocket.TaskTimeout = value;
		}
	}

	public ResourceNode CameraResourceNode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SUcWlIZCEg;
		}
	}

	public string CamPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)jiCU6eaS6V3HYUHXV34(kgbOBx7BanbFa22Hp9.ol99ukmDA(41026), Eg3WABEMkg);
		}
	}

	public string Camera
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Eg3WABEMkg;
		}
	}

	public ICogSocketAcq Acq
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rlDWp6Tibn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rlDWp6Tibn = value;
		}
	}

	public CvsCogSocketIo Io
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CsoWhpY7vi;
		}
	}

	public CvsCogSocketSheet Sheet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E0nW4b05uL;
		}
	}

	public bool IsDisposed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LZxWMelhoh == null;
		}
	}

	public CvsFunctionTable FunctionTable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yK2WtgyAgT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yK2WtgyAgT = value;
		}
	}

	public CvsProcessorConstants ProcessorConstants
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rm9WWbbyWf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rm9WWbbyWf = value;
		}
	}

	public bool IsRuntimeSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!kqLWJWODF0.HasValue)
			{
				try
				{
					_ = LZxWMelhoh.GetAsync<object>((string)Iu5ubRRZMcmcvxh0ZJR(CamPath, DYkOHURkKnfFhebFejx(41040))).Result;
					kqLWJWODF0 = true;
				}
				catch (Exception)
				{
					kqLWJWODF0 = false;
				}
			}
			return kqLWJWODF0.Value;
		}
	}

	string IResourceUriProvider.RootResourceUri
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CamPath;
		}
	}

	IRemoteDeviceApi IResourceUriProvider.DeviceApi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LZxWMelhoh;
		}
	}

	public event EventHandler Closed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (VQpcZFRbSbKflTBGB2u())
			{
				goto IL_001e;
			}
			goto IL_005c;
			IL_00ae:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = Interlocked.CompareExchange(ref LOHWLjnORD, value2, eventHandler2);
			num = 5;
			goto IL_005c;
			IL_005c:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 2:
				case 6:
					goto IL_003d;
				default:
					num = 3;
					continue;
				case 0:
				case 1:
					eventHandler2 = eventHandler;
					goto IL_003d;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 0;
				case 3:
					goto IL_00ae;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_003d:
			value2 = (EventHandler)ehNe4laET4WKcF24GaY(eventHandler2, value);
			goto IL_00ae;
			IL_001e:
			eventHandler = LOHWLjnORD;
			_ = 0;
			if (vfdUdnRXITVhMJxoxDR())
			{
				num = 0;
				if (false)
				{
					goto IL_003d;
				}
			}
			else
			{
				num = 6;
			}
			goto IL_005c;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 2;
				case 2:
					eventHandler2 = eventHandler;
					num = 5;
					break;
				case 1:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref LOHWLjnORD, value2, eventHandler2);
					goto case 4;
				case 5:
					value2 = (EventHandler)qfo42Yav5KAWdeavEYm(eventHandler2, value);
					goto default;
				default:
					_ = 1;
					if (VQpcZFRbSbKflTBGB2u())
					{
						num = 6;
						if (true)
						{
							break;
						}
						goto case 5;
					}
					num = 1;
					break;
				case 0:
					eventHandler = LOHWLjnORD;
					num = 2;
					break;
				case 7:
					return;
				}
			}
		}
	}

	public event EventHandler ResultChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					eventHandler = Interlocked.CompareExchange(ref he2WkPWl6k, value2, eventHandler2);
					num = 4;
					break;
				case 1:
				case 6:
					eventHandler2 = eventHandler;
					goto case 0;
				case 0:
				case 2:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto case 5;
				default:
					num = 5;
					break;
				case 3:
					eventHandler = he2WkPWl6k;
					VQpcZFRbSbKflTBGB2u();
					if (!vfdUdnRXITVhMJxoxDR())
					{
						num = 0;
						if (vfdUdnRXITVhMJxoxDR())
						{
							break;
						}
						goto case 0;
					}
					num = 6;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					eventHandler = Interlocked.CompareExchange(ref he2WkPWl6k, value2, eventHandler2);
					num = 6;
					if (VQpcZFRbSbKflTBGB2u())
					{
					}
					break;
				case 0:
				case 2:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					goto case 3;
				default:
					num = 3;
					break;
				case 4:
					eventHandler = he2WkPWl6k;
					VQpcZFRbSbKflTBGB2u();
					if (vfdUdnRXITVhMJxoxDR())
					{
						num = 5;
						break;
					}
					num = 0;
					if (true)
					{
						break;
					}
					goto case 6;
				case 1:
				case 5:
					eventHandler2 = eventHandler;
					goto case 0;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void WaitForResultBuildComplete()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		twUUjNR6BgRQTVyxaOh(mxVWoFQPr0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCogSocket()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MoF94iRppHKh9g8rGKE();
		ulsafnR0PQrMIu4QCA8();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsCogSocket(Uri rootWssUrl, Uri rootHttpUrl, [NotNull] string path, string sheetPath, string username, WaitForBuildCompleteDelegate waitForResultBuildComplete)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		bool isRuntimeSupported = default;
		IDisposable disposable = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				ztjM7NRfj2gppRq3vim(this);
				num = 3;
				continue;
			case 7:
				CsoWhpY7vi = new CvsCogSocketIo(new ResourceNode(this, (string)DYkOHURkKnfFhebFejx(40834)));
				goto case 4;
			case 4:
			case 6:
				E0nW4b05uL = new CvsCogSocketSheet(this, sheetPath);
				num = 0;
				continue;
			case 1:
				try
				{
					Eg3WABEMkg = (string)(rfkiijRmO1fGk0qaylq(path) ? DYkOHURkKnfFhebFejx(40796) : path);
					VqpWgQli3J = (X8ssmKRytTaZl9CbGT9(path, sheetPath) ? new Uri(rootWssUrl, path) : rootWssUrl);
					YMfWqqAqPy = new Uri(rootHttpUrl, path);
					mxVWoFQPr0 = waitForResultBuildComplete;
					try
					{
						LZxWMelhoh = (IRemoteDeviceApi)nwbDAsRgm4YPEo84aLO(VqpWgQli3J.ToString(), YMfWqqAqPy.ToString(), username);
						_ = 0;
						int num2 = ((!vfdUdnRXITVhMJxoxDR()) ? 2 : 3);
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 3:
								LZxWMelhoh.Closed += XpiWxY0Rid;
								break;
							case 4:
								UbYYSgRJWmlRe0XJnkW(CvsTraceSDK.Info, Iu5ubRRZMcmcvxh0ZJR(DYkOHURkKnfFhebFejx(40880), isRuntimeSupported.ToString()));
								goto end_IL_0134;
							}
							isRuntimeSupported = IsRuntimeSupported;
							num2 = 4;
							continue;
							end_IL_0134:
							break;
						}
					}
					catch (Exception ex)
					{
						Dispose();
						UbYYSgRJWmlRe0XJnkW(CvsTraceSDK.Error, Iu5ubRRZMcmcvxh0ZJR(DYkOHURkKnfFhebFejx(40914), ex.Message));
						fcJ5a7R8rNb4qY3OW8k(Ki4WB9tsk9, DYkOHURkKnfFhebFejx(40950), ex);
						throw new CvsNetworkException((string)gX8JcERzWSbAHausQF3(), ex);
					}
				}
				finally
				{
					if (disposable != null)
					{
						g2r9jJawMYJbMg2Z0jv(disposable);
					}
				}
				SUcWlIZCEg = new ResourceNode(this, "");
				num = 11;
				continue;
			case 5:
				Ki4WB9tsk9 = LogManager.GetLogger<CvsCogSocket>();
				_ = 1;
				num = ((!VQpcZFRbSbKflTBGB2u()) ? 8 : 4);
				continue;
			case 3:
				QM80q4RFVWVKUEiJbem(GLTW3eMjGI, TraceLevel.Error);
				goto case 7;
			default:
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 8:
				Eg3WABEMkg = (string)DYkOHURkKnfFhebFejx(40796);
				GLTW3eMjGI = new TraceSwitch((string)DYkOHURkKnfFhebFejx(40806), (string)DYkOHURkKnfFhebFejx(40374));
				num = 10;
				continue;
			case 9:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 0:
				break;
			case 11:
				return;
			}
			disposable = CvsTraceSDK.Info.TraceFunction((string)DYkOHURkKnfFhebFejx(40842));
			num = 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateAsync_003Ed__30))]
	public static Task<CvsCogSocket> CreateAsync(Uri rootWssUrl, Uri rootHttpUrl, string path, string sheetPath, string username, WaitForBuildCompleteDelegate waitForResultBuildComplete, ICogSocketAcqFactory acqFactory)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateAsync_003Ed__30 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogSocket>.Create();
		stateMachine.rootWssUrl = rootWssUrl;
		stateMachine.rootHttpUrl = rootHttpUrl;
		stateMachine.path = path;
		stateMachine.sheetPath = sheetPath;
		stateMachine.username = username;
		stateMachine.waitForResultBuildComplete = waitForResultBuildComplete;
		stateMachine.acqFactory = acqFactory;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)YivvwiasRTPqCi2v7Kf(CvsTraceSDK.Info, dOXWFp2Viw((string)DYkOHURkKnfFhebFejx(41008)));
		try
		{
			if (LZxWMelhoh == null)
			{
				return;
			}
			try
			{
				if (!LZxWMelhoh.IsDisposed)
				{
					_ = 0;
					int num = ((!vfdUdnRXITVhMJxoxDR()) ? 2 : 3);
					while (true)
					{
						switch (num)
						{
						default:
							br5K4xaLrqUPVwO4KVA(LZxWMelhoh, new EventHandler(XpiWxY0Rid));
							num = 4;
							if (VQpcZFRbSbKflTBGB2u())
							{
							}
							continue;
						case 0:
						case 3:
							Task.Run([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003CDispose_003Eb__33_0_003Ed))] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								int num2 = 0;
								_003C_003CDispose_003Eb__33_0_003Ed stateMachine = default;
								while (true)
								{
									switch (num2)
									{
									case 2:
									case 4:
										stateMachine._003C_003E1__state = -1;
										goto default;
									case 5:
										do
										{
											stateMachine._003C_003E4__this = this;
											_ = 0;
											if (vfdUdnRXITVhMJxoxDR())
											{
												num2 = 4;
												break;
											}
											num2 = 1;
										}
										while (VQpcZFRbSbKflTBGB2u());
										break;
									default:
										stateMachine._003C_003Et__builder.Start(ref stateMachine);
										num2 = 6;
										break;
									case 0:
										stateMachine._003C_003Et__builder = vwna9ja2YKXcKtSq7i6();
										num2 = 5;
										if (VQpcZFRbSbKflTBGB2u())
										{
										}
										break;
									case 6:
										return stateMachine._003C_003Et__builder.Task;
									}
								}
							}).Wait(qIBkkIahFyUlLbyOw5U());
							goto default;
						case 4:
							RemoteDeviceApiPool.Decrement(VqpWgQli3J.ToString());
							break;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				T4DmPta9jQv4xv0ntjQ(CvsTraceSDK.Error, ex);
			}
			LZxWMelhoh = null;
		}
		finally
		{
			if (disposable != null)
			{
				g2r9jJawMYJbMg2Z0jv(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string[]> ConsolePull()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.PostAsync<string[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11352), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFunctionLibrary_003Ed__61))]
	private Task<CvsFunctionTable> RJRWPrIFYC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFunctionLibrary_003Ed__61 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsFunctionTable>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<double> GetTemperatureAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.GetAsync<double>(CamPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(41082));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogEasyBuilderConfig> GetEasyBuilderConfiguration()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.GetAsync<CvsCogEasyBuilderConfig>(CamPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(41144));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogCamInfo GetCameraInfo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.GetAsync<CvsCogCamInfo>((string)Iu5ubRRZMcmcvxh0ZJR(CamPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(41184))).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogCamInfo> GetCameraInfoAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.GetAsync<CvsCogCamInfo>(CamPath + kgbOBx7BanbFa22Hp9.ol99ukmDA(41184));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HardwareModel GetHardwareDisplayModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (HardwareModel)SUcWlIZCEg.GetAsync<long>((string)DYkOHURkKnfFhebFejx(41196)).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetFunctionTable()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yK2WtgyAgT = RJRWPrIFYC().Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetProcessorConstants()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!vfdUdnRXITVhMJxoxDR()) ? 2 : 3);
		CvsCogSheetLimits limits = default;
		CvsCogAcqProperties acqProperties = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				try
				{
					limits = DeviceApi.GetAsync<CvsCogSheetLimits>((string)D6cNH9aVji07jwgwKDV(DYkOHURkKnfFhebFejx(41248), FeWMwnaHAJYqMHUssPu(Sheet), kgbOBx7BanbFa22Hp9.ol99ukmDA(41272))).Result;
				}
				catch (Exception)
				{
					limits = new CvsCogSheetLimits();
				}
				acqProperties = null;
				break;
			case 1:
			case 2:
				break;
			default:
				goto IL_00d6;
			case 4:
				return;
			}
			break;
			IL_00d6:
			num = 4;
		}
		try
		{
			acqProperties = (CvsCogAcqProperties)U3ZaSKaA8gMlE36Meb4(Acq);
		}
		catch (Exception ex2)
		{
			T4DmPta9jQv4xv0ntjQ(CvsTraceSDK.Error, ex2);
		}
		rm9WWbbyWf = new CvsProcessorConstants(limits, acqProperties);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> AddSheetAsync(string sheetID)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.PostAsync<object>(string.Format(kgbOBx7BanbFa22Hp9.ol99ukmDA(41248), Sheet.Path, kgbOBx7BanbFa22Hp9.ol99ukmDA(41288)), new object[1] { sheetID });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> RemoveSheetAsync(string sheetID)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.PostAsync<object>(string.Format(kgbOBx7BanbFa22Hp9.ol99ukmDA(41248), Sheet.Path, kgbOBx7BanbFa22Hp9.ol99ukmDA(41308)), new object[1] { sheetID });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> RenameSheetAsync(string oldSheetID, string newSheetID)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.PostAsync<object>(string.Format(kgbOBx7BanbFa22Hp9.ol99ukmDA(41248), Sheet.Path, kgbOBx7BanbFa22Hp9.ol99ukmDA(41334)), new object[2] { oldSheetID, newSheetID });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string[]> GetSheetNames()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LZxWMelhoh.GetAsync<string[]>(string.Format(kgbOBx7BanbFa22Hp9.ol99ukmDA(41248), Sheet.Path, kgbOBx7BanbFa22Hp9.ol99ukmDA(41360)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetLanguage_003Ed__75))]
	public Task<CultureInfo> GetLanguage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetLanguage_003Ed__75 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CultureInfo>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetLanguage_003Ed__76))]
	public Task<bool> SetLanguage(CultureInfo culture)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSetLanguage_003Ed__76 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.culture = culture;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string MakeHttpUrl(string relativePath)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!rfkiijRmO1fGk0qaylq(relativePath))
		{
			return new Uri(YMfWqqAqPy, relativePath).ToString();
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Bitmap> GetImageByHttpAsync(string url, Size reqSize, Rectangle imageRect, CvsInterpolationAlgorithm interp = CvsInterpolationAlgorithm.Subsampling, CogSocketImageFormat fmt = CogSocketImageFormat.Bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string dw = reqSize.Width.ToString(CultureInfo.InvariantCulture);
		string dh = reqSize.Height.ToString(CultureInfo.InvariantCulture);
		string sx = imageRect.X.ToString(CultureInfo.InvariantCulture);
		string sy = imageRect.Y.ToString(CultureInfo.InvariantCulture);
		string sw = imageRect.Width.ToString(CultureInfo.InvariantCulture);
		string sh = imageRect.Height.ToString(CultureInfo.InvariantCulture);
		int num = (int)interp;
		string interp2 = num.ToString(CultureInfo.InvariantCulture);
		num = (int)fmt;
		return GetImageByHttpAsync(url, dw, dh, sx, sy, sw, sh, interp2, num.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImageByHttpAsync_003Ed__79))]
	public Task<Bitmap> GetImageByHttpAsync(string url, string dw = null, string dh = null, string sx = null, string sy = null, string sw = null, string sh = null, string interp = "0", string fmt = "0")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImageByHttpAsync_003Ed__79 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.dw = dw;
		stateMachine.dh = dh;
		stateMachine.sx = sx;
		stateMachine.sy = sy;
		stateMachine.sw = sw;
		stateMachine.sh = sh;
		stateMachine.interp = interp;
		stateMachine.fmt = fmt;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bitmap GetImageByHttp(string url, Size reqSize, Rectangle imageRect, CvsInterpolationAlgorithm interp = CvsInterpolationAlgorithm.Subsampling, CogSocketImageFormat fmt = CogSocketImageFormat.Bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string dw = reqSize.Width.ToString((IFormatProvider)rlvppDaDicicfo6ooWA());
		string dh = reqSize.Height.ToString((IFormatProvider)rlvppDaDicicfo6ooWA());
		string sx = imageRect.X.ToString((IFormatProvider)rlvppDaDicicfo6ooWA());
		string sy = imageRect.Y.ToString((IFormatProvider)rlvppDaDicicfo6ooWA());
		string sw = imageRect.Width.ToString((IFormatProvider)rlvppDaDicicfo6ooWA());
		string sh = imageRect.Height.ToString((IFormatProvider)rlvppDaDicicfo6ooWA());
		int num = (int)interp;
		string interp2 = num.ToString(CultureInfo.InvariantCulture);
		num = (int)fmt;
		return GetImageByHttp(url, dw, dh, sx, sy, sw, sh, interp2, num.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bitmap GetImageByHttp(string url, string dw = null, string dh = null, string sx = null, string sy = null, string sw = null, string sh = null, string interp = "0", string fmt = "0")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		HttpQueryBuilder httpQueryBuilder = default;
		_003C_003Ec__DisplayClass81_0 obj = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (!mI0WIixEdi(sx, sy, sw, sh))
				{
					goto case 7;
				}
				goto IL_0143;
			default:
				num = 7;
				break;
			case 9:
				httpQueryBuilder[kgbOBx7BanbFa22Hp9.ol99ukmDA(41480)] = fmt;
				num = 13;
				if (0 == 0)
				{
					break;
				}
				goto case 11;
			case 11:
				if (!mI0WIixEdi(dw, dh))
				{
					num = 0;
					break;
				}
				goto case 5;
			case 4:
				httpQueryBuilder[kgbOBx7BanbFa22Hp9.ol99ukmDA(41464)] = interp;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				obj = new _003C_003Ec__DisplayClass81_0();
				vfdUdnRXITVhMJxoxDR();
				if (!VQpcZFRbSbKflTBGB2u())
				{
					num = 10;
					break;
				}
				num = 3;
				if (vfdUdnRXITVhMJxoxDR())
				{
					break;
				}
				goto case 6;
			case 7:
				httpQueryBuilder.SetParameter((string)DYkOHURkKnfFhebFejx(41452), sx, sy, sw, sh);
				goto IL_0143;
			case 13:
				text = (string)KHc89AaTWQHY19jgr7M(httpQueryBuilder);
				num = 14;
				break;
			case 2:
			case 3:
				throw new ArgumentException((string)DYkOHURkKnfFhebFejx(41384), (string)DYkOHURkKnfFhebFejx(9548));
			case 1:
			case 10:
				obj._003C_003E4__this = this;
				if (!rfkiijRmO1fGk0qaylq(url))
				{
					if (!Oa5JIAaUl4hqAQkusYU(url))
					{
						num = 12;
						break;
					}
					return null;
				}
				goto case 2;
			case 6:
				if (rfkiijRmO1fGk0qaylq(fmt))
				{
					goto case 13;
				}
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 12;
			case 12:
				httpQueryBuilder = new HttpQueryBuilder();
				num = 11;
				break;
			case 0:
				httpQueryBuilder.SetParameter((string)DYkOHURkKnfFhebFejx(41444), dw, dh);
				num = 5;
				if (true)
				{
					break;
				}
				goto case 14;
			case 14:
				{
					obj.formatUrl = (string)(rfkiijRmO1fGk0qaylq(text) ? url : McbwiMaddbEjVLKMm9G(url, DYkOHURkKnfFhebFejx(15296), text));
					try
					{
						obj.timeout = C00xLxaic0IUFFeQILO();
						if (baZYVKaq1ALLnHHyTxJ(GLTW3eMjGI))
						{
							TuDeckaB0J5DfG1b49f(Ki4WB9tsk9, Iu5ubRRZMcmcvxh0ZJR(kgbOBx7BanbFa22Hp9.ol99ukmDA(41490), obj.formatUrl));
						}
						eNX1M6ajmrVYn5jSrCW(CvsTraceSDK.TxCogSocket, kgbOBx7BanbFa22Hp9.ol99ukmDA(41526), new object[1] { obj.formatUrl });
						using Stream stream = Task.Run((Func<Task<Stream>>)obj._003CGetImageByHttp_003Eb__0).Result;
						MemoryStream memoryStream = new MemoryStream();
						tSyiBoachsQ4jsu4xD7(stream, memoryStream);
						return new Bitmap(memoryStream);
					}
					catch (Exception ex)
					{
						T4DmPta9jQv4xv0ntjQ(CvsTraceSDK.Error, ex);
						Ki4WB9tsk9.DebugException((string)McbwiMaddbEjVLKMm9G(kgbOBx7BanbFa22Hp9.ol99ukmDA(41566), obj.formatUrl, DYkOHURkKnfFhebFejx(17520)), ex);
						throw;
					}
				}
				IL_0143:
				if (!rfkiijRmO1fGk0qaylq(interp))
				{
					num = 4;
					break;
				}
				goto case 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPointCloudByHttpAsync_003Ed__82))]
	public Task<Stream> GetPointCloudByHttpAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPointCloudByHttpAsync_003Ed__82 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPointCloudAsync_003Ed__83))]
	public Task<CvsCogPointCloudRef> GetPointCloudAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPointCloudAsync_003Ed__83 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogPointCloudRef>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostImageByHTTPAndRunSheetAsync_003Ed__84))]
	public Task PostImageByHTTPAndRunSheetAsync(Bitmap bmp, CvsCellLocation? cellLocation = null, string imageName = null, bool sync = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPostImageByHTTPAndRunSheetAsync_003Ed__84 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.bmp = bmp;
		stateMachine.cellLocation = cellLocation;
		stateMachine.imageName = imageName;
		stateMachine.sync = sync;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostPointCloudByHTTPAsync_003Ed__85))]
	public Task PostPointCloudByHTTPAsync(Stream rawData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CPostPointCloudByHTTPAsync_003Ed__85 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003Et__builder = vwna9ja2YKXcKtSq7i6();
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			case 0:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine.rawData = rawData;
				goto default;
			default:
				_ = 1;
				num = (VQpcZFRbSbKflTBGB2u() ? 2 : 0);
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMergePointCloudAndRun_003Ed__86))]
	public Task MergePointCloudAndRun(string masterUrl, string slaveUrl)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CMergePointCloudAndRun_003Ed__86 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 6;
				break;
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 1:
			case 3:
				stateMachine.slaveUrl = slaveUrl;
				goto case 0;
			default:
				num = 0;
				break;
			case 7:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 2;
				break;
			case 6:
				stateMachine.masterUrl = masterUrl;
				VQpcZFRbSbKflTBGB2u();
				if (vfdUdnRXITVhMJxoxDR())
				{
					num = 1;
					if (!VQpcZFRbSbKflTBGB2u())
					{
						break;
					}
					goto case 0;
				}
				num = 4;
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptsPointCloudsAsync_003Ed__87))]
	public Task<bool> AcceptsPointCloudsAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAcceptsPointCloudsAsync_003Ed__87 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CIsQuadMeshAsync_003Ed__88))]
	public Task<bool> IsQuadMeshAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CIsQuadMeshAsync_003Ed__88 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUploadPointCloudAsync_003Ed__89))]
	public Task<CvsCogRef> UploadPointCloudAsync(Stream rawData, string clientId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CUploadPointCloudAsync_003Ed__89 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogRef>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.rawData = rawData;
		stateMachine.clientId = clientId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddResourceAsync_003Ed__90))]
	public Task AddResourceAsync(string resourceUrl, string clientId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (vfdUdnRXITVhMJxoxDR())
		{
			num = 7;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_0094;
		IL_0026:
		_003CAddResourceAsync_003Ed__90 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0094;
		IL_0094:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				continue;
			case 5:
				stateMachine.resourceUrl = resourceUrl;
				goto case 3;
			case 3:
			case 6:
				stateMachine.clientId = clientId;
				goto case 1;
			default:
				num = 1;
				continue;
			case 0:
			case 7:
				stateMachine._003C_003Et__builder = vwna9ja2YKXcKtSq7i6();
				num = 4;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReleaseResourceAsync_003Ed__91))]
	public Task ReleaseResourceAsync(string resourceUrl, string clientId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CReleaseResourceAsync_003Ed__91 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 3:
				stateMachine.clientId = clientId;
				goto case 1;
			default:
				num = 1;
				continue;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine.resourceUrl = resourceUrl;
				VQpcZFRbSbKflTBGB2u();
				if (vfdUdnRXITVhMJxoxDR())
				{
					num = 2;
					continue;
				}
				num = 6;
				if (vfdUdnRXITVhMJxoxDR())
				{
					continue;
				}
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLookupResourceAsync_003Ed__92))]
	public Task<bool> LookupResourceAsync(string resourceUrl, string clientId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CLookupResourceAsync_003Ed__92 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.resourceUrl = resourceUrl;
		stateMachine.clientId = clientId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReleaseClientResourcesAsync_003Ed__93))]
	public Task ReleaseClientResourcesAsync(string clientId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (VQpcZFRbSbKflTBGB2u() ? 1 : 3);
		_003CReleaseClientResourcesAsync_003Ed__93 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine.clientId = clientId;
				goto case 6;
			default:
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CognexRemoteServiceBase<Stream> GetRemoteImageService()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new RemoteImageService(LZxWMelhoh);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSvgByHttp_003Ed__95))]
	public Task<string> GetSvgByHttp(string url, double scale, CvsImageOrientation orientation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSvgByHttp_003Ed__95 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.scale = scale;
		stateMachine.orientation = orientation;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSvgByHttp_003Ed__96))]
	public Task<string> GetSvgByHttp(string url, string scale = null, string rotation = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSvgByHttp_003Ed__96 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.scale = scale;
		stateMachine.rotation = rotation;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CApplyPointCloudFiltersAndRun_003Ed__97))]
	public Task ApplyPointCloudFiltersAndRun(string pointCloudResourceUrl, bool sync = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CApplyPointCloudFiltersAndRun_003Ed__97 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (vfdUdnRXITVhMJxoxDR() ? 5 : 0);
				break;
			case 2:
			case 5:
				stateMachine.pointCloudResourceUrl = pointCloudResourceUrl;
				goto case 0;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				if (vfdUdnRXITVhMJxoxDR())
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine.sync = sync;
				goto case 4;
			default:
				num = 4;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool mI0WIixEdi(params string[] values)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return values.Any([MethodImpl(MethodImplOptions.NoInlining)] (string str) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.LJ5jddsMSibGxJs6b4CX(str);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fEEW1bnyHY(object P_0, CogSocketEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			if (!ResultChangedEnabled)
			{
				return;
			}
			_ = 1;
			int num = (VQpcZFRbSbKflTBGB2u() ? 2 : 3);
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					eventHandler = he2WkPWl6k;
					goto default;
				default:
					if (eventHandler == null)
					{
						return;
					}
					break;
				case 4:
					JIdLUjaWIQcBHfgJjBK(eventHandler, this, EventArgs.Empty);
					return;
				}
				num = 4;
			}
		}
		catch (Exception ex)
		{
			fcJ5a7R8rNb4qY3OW8k(Ki4WB9tsk9, DYkOHURkKnfFhebFejx(41618), ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XpiWxY0Rid(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		R12IGya7ZMuCtBxKsPG((Action)([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			try
			{
				if (pyhSQVaoys4VRyM0hsV(GLTW3eMjGI))
				{
					TuDeckaB0J5DfG1b49f(Ki4WB9tsk9, kgbOBx7BanbFa22Hp9.ol99ukmDA(41734) + CamPath);
				}
				IDisposable disposable = (IDisposable)YivvwiasRTPqCi2v7Kf(CvsTraceSDK.Info, dOXWFp2Viw((string)DYkOHURkKnfFhebFejx(41776)));
				try
				{
					if (LZxWMelhoh == null)
					{
						goto IL_007c;
					}
					_ = 1;
					int num;
					if (!VQpcZFRbSbKflTBGB2u())
					{
						num = 3;
						if (1 == 0)
						{
							goto IL_007c;
						}
					}
					else
					{
						num = 2;
					}
					goto IL_00aa;
					IL_007c:
					if (LOHWLjnORD == null)
					{
						return;
					}
					num = 4;
					goto IL_00aa;
					IL_00aa:
					switch (num)
					{
					case 0:
					case 3:
						LZxWMelhoh = null;
						break;
					case 4:
						LOHWLjnORD(this, EventArgs.Empty);
						return;
					}
					goto IL_007c;
				}
				finally
				{
					if (disposable != null)
					{
						g2r9jJawMYJbMg2Z0jv(disposable);
					}
				}
			}
			catch (Exception ex)
			{
				T4DmPta9jQv4xv0ntjQ(CvsTraceSDK.Error, ex);
				rtBRWIaPo6isCO0s7hq(Ki4WB9tsk9, DYkOHURkKnfFhebFejx(41814), ex);
			}
		}));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string dOXWFp2Viw(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)D6cNH9aVji07jwgwKDV(DYkOHURkKnfFhebFejx(41690), Camera, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveDebugImage(string url, Bitmap bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int FindCogSocketErrorCode(Exception ex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VQpcZFRbSbKflTBGB2u();
		int num = ((!vfdUdnRXITVhMJxoxDR()) ? 1 : 5);
		IEnumerator<Exception> enumerator = default;
		int result = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				if (ex == null)
				{
					num = 2;
					if (true)
					{
						break;
					}
					goto case 2;
				}
				if (ex is CogSocketErrorResponseReceivedException)
				{
					num = 6;
					break;
				}
				if (!(ex is CvsErrorResponseNetworkException))
				{
					if (UkJA7QaK8o11F3lVdtt(ex) is AggregateException)
					{
						goto case 1;
					}
					return pSRwGda5ooswjY9tN22(UkJA7QaK8o11F3lVdtt(ex));
				}
				goto case 3;
			case 2:
				return 0;
			case 3:
				return iufYfWaC3o1aJkiEIKu((CvsErrorResponseNetworkException)ex);
			case 1:
			case 4:
				enumerator = ((AggregateException)ex.InnerException).InnerExceptions.GetEnumerator();
				num = 7;
				break;
			case 6:
				return TV34DJatWrTTuagvlxj((CogSocketErrorResponseReceivedException)ex);
			default:
				num = 3;
				break;
			case 7:
				try
				{
					while (enumerator.MoveNext())
					{
						int num2 = FindCogSocketErrorCode(enumerator.Current);
						_ = 0;
						int num3;
						if (vfdUdnRXITVhMJxoxDR())
						{
							num3 = 3;
							if (!vfdUdnRXITVhMJxoxDR())
							{
								goto IL_0122;
							}
						}
						else
						{
							num3 = 2;
						}
						goto IL_013a;
						IL_013a:
						switch (num3)
						{
						case 0:
						case 3:
							break;
						default:
							goto IL_0163;
						case 4:
							return result;
						}
						goto IL_0122;
						IL_0122:
						if (num2 == 0)
						{
							continue;
						}
						goto IL_0163;
						IL_0163:
						result = num2;
						num3 = 4;
						goto IL_013a;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						g2r9jJawMYJbMg2Z0jv(enumerator);
					}
				}
				return 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_003CDispose_003Eb__33_0_003Ed))]
	[CompilerGenerated]
	private Task JgNWbUIeKi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003C_003CDispose_003Eb__33_0_003Ed stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				do
				{
					stateMachine._003C_003E4__this = this;
					_ = 0;
					if (!vfdUdnRXITVhMJxoxDR())
					{
						num = 1;
						continue;
					}
					num = 4;
					break;
				}
				while (VQpcZFRbSbKflTBGB2u());
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003Et__builder = vwna9ja2YKXcKtSq7i6();
				num = 5;
				if (VQpcZFRbSbKflTBGB2u())
				{
				}
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void BQ9WaaRkSa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			if (pyhSQVaoys4VRyM0hsV(GLTW3eMjGI))
			{
				TuDeckaB0J5DfG1b49f(Ki4WB9tsk9, kgbOBx7BanbFa22Hp9.ol99ukmDA(41734) + CamPath);
			}
			IDisposable disposable = (IDisposable)YivvwiasRTPqCi2v7Kf(CvsTraceSDK.Info, dOXWFp2Viw((string)DYkOHURkKnfFhebFejx(41776)));
			try
			{
				if (LZxWMelhoh == null)
				{
					goto IL_007c;
				}
				_ = 1;
				int num;
				if (!VQpcZFRbSbKflTBGB2u())
				{
					num = 3;
					if (1 == 0)
					{
						goto IL_007c;
					}
				}
				else
				{
					num = 2;
				}
				goto IL_00aa;
				IL_007c:
				if (LOHWLjnORD != null)
				{
					num = 4;
					goto IL_00aa;
				}
				return;
				IL_00aa:
				switch (num)
				{
				case 0:
				case 3:
					LZxWMelhoh = null;
					break;
				case 4:
					LOHWLjnORD(this, EventArgs.Empty);
					return;
				}
				goto IL_007c;
			}
			finally
			{
				if (disposable != null)
				{
					g2r9jJawMYJbMg2Z0jv(disposable);
				}
			}
		}
		catch (Exception ex)
		{
			T4DmPta9jQv4xv0ntjQ(CvsTraceSDK.Error, ex);
			rtBRWIaPo6isCO0s7hq(Ki4WB9tsk9, DYkOHURkKnfFhebFejx(41814), ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vfdUdnRXITVhMJxoxDR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VQpcZFRbSbKflTBGB2u()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void twUUjNR6BgRQTVyxaOh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoF94iRppHKh9g8rGKE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ulsafnR0PQrMIu4QCA8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SerializedTypeRegistration.RegisterBuiltIns();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan nG95teR4SV9JY4kp3hE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CogSocket.TaskTimeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DYkOHURkKnfFhebFejx(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ztjM7NRfj2gppRq3vim(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QM80q4RFVWVKUEiJbem(object P_0, TraceLevel P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TraceSwitch)P_0).Level = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rfkiijRmO1fGk0qaylq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool X8ssmKRytTaZl9CbGT9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nwbDAsRgm4YPEo84aLO(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RemoteDeviceApiPool.RetrieveDevice((string)P_0, (string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Iu5ubRRZMcmcvxh0ZJR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UbYYSgRJWmlRe0XJnkW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fcJ5a7R8rNb4qY3OW8k(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).DebugException((string)P_1, (Exception)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gX8JcERzWSbAHausQF3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UnableToConnectToDevice;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g2r9jJawMYJbMg2Z0jv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YivvwiasRTPqCi2v7Kf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan qIBkkIahFyUlLbyOw5U()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TaskTimeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void br5K4xaLrqUPVwO4KVA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IRemoteDeviceApi)P_0).Closed -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T4DmPta9jQv4xv0ntjQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceException((Exception)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jiCU6eaS6V3HYUHXV34(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ehNe4laET4WKcF24GaY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qfo42Yav5KAWdeavEYm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FeWMwnaHAJYqMHUssPu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).Path;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D6cNH9aVji07jwgwKDV(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U3ZaSKaA8gMlE36Meb4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICogSocketAcq)P_0).GetAcqProperties();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rlvppDaDicicfo6ooWA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Oa5JIAaUl4hqAQkusYU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KHc89AaTWQHY19jgr7M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((HttpQueryBuilder)P_0).Query;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object McbwiMaddbEjVLKMm9G(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan C00xLxaic0IUFFeQILO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCogSocketAcq.HttpImageTimeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool baZYVKaq1ALLnHHyTxJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TraceSwitch)P_0).TraceVerbose;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TuDeckaB0J5DfG1b49f(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).Debug((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eNX1M6ajmrVYn5jSrCW(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tSyiBoachsQ4jsu4xD7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder vwna9ja2YKXcKtSq7i6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JIdLUjaWIQcBHfgJjBK(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R12IGya7ZMuCtBxKsPG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.Run((Action)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TV34DJatWrTTuagvlxj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CogSocketErrorResponseReceivedException)P_0).ErrorCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iufYfWaC3o1aJkiEIKu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsErrorResponseNetworkException)P_0).ErrorCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UkJA7QaK8o11F3lVdtt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).InnerException;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pSRwGda5ooswjY9tN22(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return FindCogSocketErrorCode((Exception)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pyhSQVaoys4VRyM0hsV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TraceSwitch)P_0).TraceInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rtBRWIaPo6isCO0s7hq(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
	}
}
