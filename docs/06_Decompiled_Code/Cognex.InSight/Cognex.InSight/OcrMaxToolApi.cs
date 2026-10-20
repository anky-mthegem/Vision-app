using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.Explorer.Diagnostics;
using Cognex.Extensions;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Services;
using Svg;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class OcrMaxToolApi : IOcrMaxService, IOcrMaxAutoTuneService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetImages_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageBytes[]> _003C_003Et__builder;

		public OcrMaxToolApi _003C_003E4__this;

		public string command;

		private List<ImageBytes> _003Cbitmaps_003E5__2;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		private string[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private List<ImageBytes> _003C_003E7__wrap4;

		private TaskAwaiter<ImageBytes> _003C_003Eu__2;

		private TaskAwaiter<object> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!luLbb1sEeK6gtKBjyRIL()) ? 4 : 5);
			int num2 = default;
			OcrMaxToolApi ocrMaxToolApi = default;
			ImageBytes[] result = default;
			TaskAwaiter<string[]> awaiter = default;
			TaskAwaiter<object> awaiter3 = default;
			TaskAwaiter<ImageBytes> awaiter2 = default;
			string[] result2 = default;
			ImageBytes result3 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					ocrMaxToolApi = _003C_003E4__this;
					goto case 2;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 6:
					_003Cbitmaps_003E5__2 = null;
					num = 3;
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter = ocrMaxToolApi.sGJaVG7IKE.PostAsync<string[]>(command, Array.Empty<object>()).GetAwaiter();
							num3 = 2;
							goto IL_0201;
						case 2:
							awaiter3 = _003C_003Eu__3;
							num3 = 17;
							goto IL_0201;
						case 1:
							awaiter2 = _003C_003Eu__2;
							goto IL_014c;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 5;
								goto IL_0201;
							}
							IL_0201:
							while (true)
							{
								switch (num3)
								{
								case 19:
									return;
								case 5:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 22:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 3;
									continue;
								case 17:
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 18;
									continue;
								case 11:
									return;
								case 12:
									if (!awaiter2.IsCompleted)
									{
										num3 = 24;
										continue;
									}
									goto case 23;
								case 0:
								case 16:
									break;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 11;
									continue;
								case 15:
									if (result2 != null)
									{
										num3 = 7;
										continue;
									}
									goto case 14;
								case 6:
									num2 = (_003C_003E1__state = 2);
									num3 = 29;
									continue;
								case 3:
									return;
								case 29:
									_003C_003Eu__3 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 19;
									continue;
								case 26:
									_003C_003E7__wrap2 = null;
									num3 = 20;
									if (true)
									{
										continue;
									}
									goto case 21;
								case 21:
									_003C_003Eu__2 = awaiter2;
									goto case 8;
								default:
									num3 = 8;
									continue;
								case 18:
									awaiter3.GetResult();
									num3 = 30;
									continue;
								case 14:
									result = Empty.Array<ImageBytes>();
									num3 = 10;
									if (0 == 0)
									{
										continue;
									}
									goto case 20;
								case 20:
									awaiter3 = ocrMaxToolApi.sGJaVG7IKE.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11154), Array.Empty<object>()).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num3 = 6;
										continue;
									}
									goto case 18;
								case 1:
									_003C_003E7__wrap4.Add(result3);
									_003C_003E7__wrap4 = null;
									_003C_003E7__wrap3++;
									num3 = 27;
									continue;
								case 9:
								case 25:
									_003C_003E7__wrap3 = 0;
									num3 = 28;
									if (OZE8L1sEuodpbFhSKFI9())
									{
									}
									continue;
								case 7:
									if (result2.Length == 0)
									{
										num3 = 14;
										continue;
									}
									_003Cbitmaps_003E5__2 = new List<ImageBytes>();
									_003C_003E7__wrap2 = result2;
									OZE8L1sEuodpbFhSKFI9();
									if (!luLbb1sEeK6gtKBjyRIL())
									{
										num3 = 0;
										continue;
									}
									num3 = 25;
									if (0 == 0)
									{
										continue;
									}
									goto case 4;
								case 24:
									num2 = (_003C_003E1__state = 1);
									num3 = 21;
									continue;
								case 27:
								case 28:
									if (_003C_003E7__wrap3 < _003C_003E7__wrap2.Length)
									{
										string text = _003C_003E7__wrap2[_003C_003E7__wrap3];
										_003C_003E7__wrap4 = _003Cbitmaps_003E5__2;
										awaiter2 = ocrMaxToolApi.JoiaSdKXxZ(text).GetAwaiter();
										num3 = 12;
										continue;
									}
									num3 = 26;
									if (luLbb1sEeK6gtKBjyRIL())
									{
										continue;
									}
									goto case 23;
								case 23:
									result3 = awaiter2.GetResult();
									num3 = 1;
									continue;
								case 13:
									num2 = (_003C_003E1__state = -1);
									num3 = 23;
									continue;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										num3 = 22;
										continue;
									}
									goto case 4;
								case 10:
									goto end_IL_0201;
								case 4:
									result2 = awaiter.GetResult();
									num3 = 15;
									continue;
								case 30:
									result = _003Cbitmaps_003E5__2.ToArray();
									goto end_IL_0201;
								}
								goto IL_014c;
								continue;
								end_IL_0201:
								break;
							}
							break;
							IL_014c:
							_003C_003Eu__2 = default;
							num3 = 13;
							goto IL_0201;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cbitmaps_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
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
		internal static bool luLbb1sEeK6gtKBjyRIL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OZE8L1sEuodpbFhSKFI9()
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
	private struct _003CGetImage_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageBytes> _003C_003Et__builder;

		public OcrMaxToolApi _003C_003E4__this;

		public string url;

		private TaskAwaiter<Stream> _003C_003Eu__1;

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
			goto IL_0181;
			IL_01b2:
			ImageBytes result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0181;
			IL_0181:
			switch (num)
			{
			case 0:
				break;
			case 5:
				goto IL_002d;
			case 2:
			case 4:
				goto IL_0050;
			default:
				goto IL_01b2;
			case 6:
				return;
			}
			goto IL_001a;
			IL_0050:
			int num2 = default;
			OcrMaxToolApi ocrMaxToolApi = default;
			try
			{
				TimeSpan timeout = default;
				if (num2 != 0)
				{
					timeout = L26ps9sEaDapH5R2A9bd(10.0);
				}
				try
				{
					TaskAwaiter<Stream> awaiter;
					if (num2 != 0)
					{
						awaiter = ocrMaxToolApi.dwfavGSImk.DeviceApi.MakeHttpGetRequest((string)pKyTiwsEnoZ3eO0latSN(ocrMaxToolApi.dwfavGSImk, url), timeout).GetAwaiter();
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
						Bitmap bitmap = new Bitmap(result2);
						try
						{
							result = rqiXbbsEGUUnT94lduaJ(bitmap);
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)bitmap)?.Dispose();
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
				catch (Exception ex)
				{
					CvsTraceSDK.Error.TraceException(ex);
					goto IL_0140;
				}
				goto end_IL_0050;
				IL_0140:
				result = ImageBytes.Empty;
				end_IL_0050:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01b2;
			IL_001a:
			num2 = _003C_003E1__state;
			num = 5;
			if (1 == 0)
			{
				goto IL_002d;
			}
			goto IL_0181;
			IL_002d:
			ocrMaxToolApi = _003C_003E4__this;
			g4Uvd8sERb5QVtIXxHAg();
			if (H7CqNvsEIKEc3Qu0O3E4())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0050;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_0181;
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
		internal static TimeSpan L26ps9sEaDapH5R2A9bd(double P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TimeSpan.FromSeconds(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pKyTiwsEnoZ3eO0latSN(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).MakeHttpUrl((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ImageBytes rqiXbbsEGUUnT94lduaJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ImageBytes.FromBitmap((Bitmap)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H7CqNvsEIKEc3Qu0O3E4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g4Uvd8sERb5QVtIXxHAg()
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
	private struct _003CCognex_002DInSight_002DServices_002DIOcrMaxService_002DGetTextDiagnostics_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsOcrMaxDiagnosticData> _003C_003Et__builder;

		public OcrMaxToolApi _003C_003E4__this;

		private ConfiguredTaskAwaitable<CvsOcrMaxDiagnosticData>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aW5ibusEbtF7DlQMN6hq();
			int num = ((!eCtX4WsEXyQbqFA6JlbM()) ? 5 : 2);
			int num2 = default;
			ConfiguredTaskAwaitable<CvsOcrMaxDiagnosticData> configuredTaskAwaitable = default;
			OcrMaxToolApi ocrMaxToolApi = default;
			ConfiguredTaskAwaitable<CvsOcrMaxDiagnosticData>.ConfiguredTaskAwaiter awaiter = default;
			CvsOcrMaxDiagnosticData result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								configuredTaskAwaitable = ocrMaxToolApi.sGJaVG7IKE.PostAsync<CvsOcrMaxDiagnosticData>((string)sBZKQjsE6Hn8EfQdyuQG(50984), Array.Empty<object>()).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 8;
								goto IL_0089;
							}
							awaiter = _003C_003Eu__1;
							goto IL_012d;
							IL_012d:
							_003C_003Eu__1 = default;
							num3 = 7;
							goto IL_0089;
							IL_0089:
							while (true)
							{
								switch (num3)
								{
								case 1:
									num2 = (_003C_003E1__state = 0);
									num3 = 0;
									continue;
								case 0:
									_003C_003Eu__1 = awaiter;
									goto default;
								default:
									eCtX4WsEXyQbqFA6JlbM();
									num3 = (aW5ibusEbtF7DlQMN6hq() ? 3 : 9);
									continue;
								case 4:
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 5;
									continue;
								case 8:
									awaiter = configuredTaskAwaitable.GetAwaiter();
									num3 = 2;
									if (eCtX4WsEXyQbqFA6JlbM())
									{
										continue;
									}
									goto case 7;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto case 10;
								case 3:
								case 6:
									break;
								case 5:
									return;
								case 10:
									result = awaiter.GetResult();
									goto end_IL_0089;
								}
								goto IL_012d;
								continue;
								end_IL_0089:
								break;
							}
						}
						catch (CvsErrorResponseNetworkException ex)
						{
							Blw0O1sEp0GWJO2ZDSen(CvsTrace.Display.Error, ex);
							result = null;
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
					continue;
				case 1:
				case 5:
					ocrMaxToolApi = _003C_003E4__this;
					num = 3;
					if (eCtX4WsEXyQbqFA6JlbM())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object sBZKQjsE6Hn8EfQdyuQG(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Blw0O1sEp0GWJO2ZDSen(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eCtX4WsEXyQbqFA6JlbM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aW5ibusEbtF7DlQMN6hq()
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
	private struct _003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DDeleteRecordInModel_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsOcrMaxAutoTuneRecord[]> _003C_003Et__builder;

		public OcrMaxToolApi _003C_003E4__this;

		public int recordIndex;

		private TaskAwaiter<CvsOcrMaxAutoTuneRecord[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsOcrMaxAutoTuneRecord[] result = default;
			int num2 = default;
			OcrMaxToolApi ocrMaxToolApi = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 5:
					try
					{
						TaskAwaiter<CvsOcrMaxAutoTuneRecord[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ocrMaxToolApi.sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneRecord[]>((string)tYQSrGsEkhZ9db2ylU1h(51024), new object[1] { recordIndex }).GetAwaiter();
							_ = 1;
							if (!LAeZKmsE4wbjBOck7Tik())
							{
								num3 = 8;
							}
							else
							{
								num3 = 7;
								if (!EHrLm0sE02uO5hBZNNWC())
								{
									goto IL_009b;
								}
							}
							goto IL_00d9;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0143;
						IL_0143:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_00d9;
						IL_017d:
						CvsOcrMaxAutoTuneRecord[] array = new CvsOcrMaxAutoTuneRecord[0];
						goto IL_0183;
						IL_009b:
						array = awaiter.GetResult();
						if (array == null)
						{
							num3 = 10;
							if (!EHrLm0sE02uO5hBZNNWC())
							{
								goto IL_00b9;
							}
							goto IL_00d9;
						}
						goto IL_0183;
						IL_0183:
						result = array;
						goto end_IL_002e;
						IL_00d9:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 4:
								break;
							case 6:
								goto IL_00b9;
							default:
								num3 = 2;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								if (EHrLm0sE02uO5hBZNNWC())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 5:
							case 7:
								goto IL_0143;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 10:
								goto IL_017d;
							}
							break;
						}
						goto IL_009b;
						IL_00b9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_002e:;
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
					LAeZKmsE4wbjBOck7Tik();
					if (!EHrLm0sE02uO5hBZNNWC())
					{
						num = 0;
						continue;
					}
					num = 2;
					if (!LAeZKmsE4wbjBOck7Tik())
					{
						continue;
					}
					break;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				ocrMaxToolApi = _003C_003E4__this;
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
		internal static object tYQSrGsEkhZ9db2ylU1h(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EHrLm0sE02uO5hBZNNWC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LAeZKmsE4wbjBOck7Tik()
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
	private struct _003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DExportAutoTuneModel_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public OcrMaxToolApi _003C_003E4__this;

		private ConfiguredTaskAwaitable<CvsOcrMaxExportedAutoTuneData>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			OcrMaxToolApi ocrMaxToolApi = default;
			byte[] result = default;
			ConfiguredTaskAwaitable<CvsOcrMaxExportedAutoTuneData> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<CvsOcrMaxExportedAutoTuneData>.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!sdubsdsEFpCETdRc5xlh()) ? 3 : 0);
					break;
				case 1:
				case 3:
					ocrMaxToolApi = _003C_003E4__this;
					goto case 0;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = ocrMaxToolApi.sGJaVG7IKE.PostAsync<CvsOcrMaxExportedAutoTuneData>((string)MShPejsEmCbmQm7E35TD(51066), Array.Empty<object>()).ConfigureAwait(continueOnCapturedContext: false);
							num3 = 4;
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
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								if (!awaiter.IsCompleted)
								{
									ipH6jUsEf41F4KiRZAFD();
									num3 = (sdubsdsEFpCETdRc5xlh() ? 1 : 7);
									continue;
								}
								break;
							case 6:
								return;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								if (!sdubsdsEFpCETdRc5xlh())
								{
									continue;
								}
								goto case 4;
							case 4:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 9;
								continue;
							case 2:
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 1;
							case 10:
								break;
							}
							break;
						}
						result = CvsOcrMaxExportedAutoTuneData.ConvertToBytes(awaiter.GetResult());
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
		internal static object MShPejsEmCbmQm7E35TD(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ipH6jUsEf41F4KiRZAFD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sdubsdsEFpCETdRc5xlh()
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
	private struct _003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DGetModelImageAndGraphics_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageBytes> _003C_003Et__builder;

		public OcrMaxToolApi _003C_003E4__this;

		public int recordIndex;

		private TaskAwaiter<CvsOcrMaxAutoTuneModelImageGraphic> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!T7gqBJsEytyf4AaeI0js()) ? 4 : 5);
			OcrMaxToolApi ocrMaxToolApi = default;
			int num2 = default;
			ImageBytes result2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					try
					{
						TaskAwaiter<CvsOcrMaxAutoTuneModelImageGraphic> awaiter;
						if (num2 != 0)
						{
							awaiter = ocrMaxToolApi.SEka284550(recordIndex).GetAwaiter();
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
						CvsOcrMaxAutoTuneModelImageGraphic result = awaiter.GetResult();
						string url = ocrMaxToolApi.dwfavGSImk.MakeHttpUrl((string)rssTYmsEZJue6FigwmRX(result));
						Bitmap imageByHttp = ocrMaxToolApi.dwfavGSImk.GetImageByHttp(url, null, null, null, null, null, null, kgbOBx7BanbFa22Hp9.ol99ukmDA(34482), (string)JVMhBXsEJJrPlnXCiKJE(34482));
						try
						{
							Bitmap bitmap = new Bitmap(py38eKsE8g10y4bm1Xl5(imageByHttp), wu6e59sEznbR3iLJvkGe(imageByHttp));
							Graphics graphics = (Graphics)UvgKn1svwga723iK879P(bitmap);
							try
							{
								graphics.DrawImage(imageByHttp, PointF.Empty);
								ocrMaxToolApi.w7GayqluEX(graphics, (string)UMY70VsvswRnYBqnFVUi(result), py38eKsE8g10y4bm1Xl5(bitmap), wu6e59sEznbR3iLJvkGe(bitmap));
							}
							finally
							{
								if (num2 < 0 && graphics != null)
								{
									qcvP6tsvhtuGJTJ7vubJ(graphics);
								}
							}
							result2 = ImageBytes.FromBitmap(bitmap);
						}
						finally
						{
							if (num2 < 0 && imageByHttp != null)
							{
								qcvP6tsvhtuGJTJ7vubJ(imageByHttp);
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
					goto default;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					if (u0U8kXsEgA9QTIFOcZx2())
					{
					}
					continue;
				case 2:
					ocrMaxToolApi = _003C_003E4__this;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
				case 5:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 2;
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
		internal static object rssTYmsEZJue6FigwmRX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsOcrMaxAutoTuneModelImageGraphic)P_0).ImageUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JVMhBXsEJJrPlnXCiKJE(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int py38eKsE8g10y4bm1Xl5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Image)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int wu6e59sEznbR3iLJvkGe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Image)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UvgKn1svwga723iK879P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Graphics.FromImage((Image)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UMY70VsvswRnYBqnFVUi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsOcrMaxAutoTuneModelImageGraphic)P_0).Svg;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qcvP6tsvhtuGJTJ7vubJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T7gqBJsEytyf4AaeI0js()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u0U8kXsEgA9QTIFOcZx2()
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
	private struct _003CAllowAutoTuneCancellation_003Ed__50<T> : IAsyncStateMachine where T : class
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public CancellationToken token;

		public Task<T> dataTask;

		public OcrMaxToolApi _003C_003E4__this;

		private Task _003CcancelTask_003E5__2;

		private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private IRemoteDeviceApi _003Cdevice_003E5__3;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private TaskAwaiter<T> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			OcrMaxToolApi ocrMaxToolApi = default;
			T result2 = default;
			int num2 = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<bool> awaiter3 = default;
			bool result = default;
			TaskAwaiter<T> awaiter4 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((1 == 0) ? 4 : 5);
					break;
				case 1:
				case 5:
					ocrMaxToolApi = _003C_003E4__this;
					num = 6;
					break;
				default:
					_003CcancelTask_003E5__2 = null;
					num = 0;
					break;
				case 0:
					_003C_003Et__builder.SetResult(result2);
					num = 7;
					break;
				case 6:
					try
					{
						ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter awaiter;
						switch (num2)
						{
						default:
							_003CcancelTask_003E5__2 = token.ToTask();
							awaiter = Task.WhenAny(_003CcancelTask_003E5__2, dataTask).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0108;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0108;
						case 1:
						case 2:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 5;
								}
								else
								{
									awaiter2 = _003C_003Eu__2;
									num3 = 14;
								}
								while (true)
								{
									switch (num3)
									{
									case 4:
										num2 = (_003C_003E1__state = -1);
										goto IL_014b;
									case 14:
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										_ = 0;
										num3 = ((1 == 0) ? 13 : 12);
										continue;
									case 5:
										if (num2 != 2)
										{
											num3 = 11;
											continue;
										}
										awaiter3 = _003C_003Eu__3;
										num3 = 10;
										continue;
									case 6:
										return;
									case 15:
										if (!awaiter2.IsCompleted)
										{
											num3 = 3;
											continue;
										}
										goto case 7;
									case 7:
									case 12:
										awaiter2.GetResult();
										awaiter3 = _003Cdevice_003E5__3.PostAsync<bool>(ocrMaxToolApi.cmWaZJXqbx.RootResourceUri + kgbOBx7BanbFa22Hp9.ol99ukmDA(4172), Array.Empty<object>()).GetAwaiter();
										goto case 0;
									default:
										num3 = 0;
										continue;
									case 11:
										awaiter2 = _003Cdevice_003E5__3.Connect().GetAwaiter();
										num3 = 15;
										continue;
									case 0:
										if (awaiter3.IsCompleted)
										{
											goto IL_014b;
										}
										goto case 9;
									case 9:
									case 13:
										num2 = (_003C_003E1__state = 2);
										num3 = 16;
										continue;
									case 10:
										_003C_003Eu__3 = default;
										num3 = 4;
										continue;
									case 3:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter2;
										num3 = 2;
										continue;
									case 16:
										_003C_003Eu__3 = awaiter3;
										num3 = 8;
										continue;
									case 2:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 1;
										continue;
									case 1:
										return;
									case 8:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 6;
										continue;
									case 17:
										{
											CvsTraceSDK.Info.TraceMessage(kgbOBx7BanbFa22Hp9.ol99ukmDA(51108), result);
											break;
										}
										IL_014b:
										result = awaiter3.GetResult();
										num3 = 17;
										continue;
									}
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003Cdevice_003E5__3 != null)
								{
									_003Cdevice_003E5__3.Dispose();
								}
							}
							_003Cdevice_003E5__3 = null;
							break;
						case 3:
							break;
							IL_0108:
							if (awaiter.GetResult() != _003CcancelTask_003E5__2)
							{
								break;
							}
							_003Cdevice_003E5__3 = ((IResourceUriProvider)ocrMaxToolApi.cmWaZJXqbx).DeviceApi.Clone();
							goto case 1;
						}
						try
						{
							int num4;
							if (num2 != 3)
							{
								num4 = 3;
							}
							else
							{
								awaiter4 = _003C_003Eu__4;
								num4 = 4;
							}
							while (true)
							{
								switch (num4)
								{
								case 4:
									_003C_003Eu__4 = default;
									num4 = 7;
									continue;
								case 6:
									if (!awaiter4.IsCompleted)
									{
										_ = 0;
										num4 = (true ? 8 : 0);
										continue;
									}
									break;
								case 2:
								case 8:
									num2 = (_003C_003E1__state = 3);
									num4 = 1;
									continue;
								case 3:
									awaiter4 = dataTask.GetAwaiter();
									num4 = 6;
									continue;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									return;
								case 5:
									return;
								case 1:
									_003C_003Eu__4 = awaiter4;
									goto case 9;
								default:
									num4 = 9;
									continue;
								case 0:
									return;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num4 = 10;
									continue;
								case 10:
									break;
								}
								break;
							}
							result2 = awaiter4.GetResult();
						}
						catch (CvsErrorResponseNetworkException ex)
						{
							if (ex.ErrorCode != -2147483550)
							{
								throw;
							}
							result2 = null;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CcancelTask_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
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
		internal static bool wrRp8csvLdLdxmj20ntr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cChOq9sv9J3dMweWcNY4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ResourceNode sGJaVG7IKE;

	private readonly CvsCogSocket dwfavGSImk;

	private readonly ResourceNode cmWaZJXqbx;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal OcrMaxToolApi(ResourceNode parentNode, CvsCogSocket cogSocket, ResourceNode sheetNode)
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
			case 4:
				sGJaVG7IKE = parentNode;
				break;
			case 0:
				h75OgVdIFX9hccgi34O();
				sbrJpEduum45KvEU9Ey();
				if (!CvsI1NdeSadrZiDWlRF())
				{
					num = 6;
					continue;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				yOTVQedRlaUAwj5earQ(this);
				num = 4;
				continue;
			case 2:
				cmWaZJXqbx = sheetNode;
				num = 7;
				continue;
			case 7:
				return;
			}
			dwfavGSImk = cogSocket;
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxSettings> IOcrMaxService.GetSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxSettings>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10116), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.SetSettings(CvsOcrMaxSettings settings)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10142), new object[1] { settings });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.ResetSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10168), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.ClearAll()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10198), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.RelabelInstance(int index, string newLabel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10246), new object[2] { index, newLabel });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.RemoveInstance(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10280), new object[1] { index });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.TrainAll(string trainString)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10312), new object[1] { trainString });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.TrainNew(string trainString)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10332), new object[1] { trainString });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.TrainSingle(int segmentedCharacterIndex, string trainCharacter, OcrMaxTrainSingleMode trainMode, bool trainEvent)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10352), new object[4] { segmentedCharacterIndex, trainCharacter, trainMode, trainEvent });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.PrepareOCRMaxForTraining(bool trainMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10378), new object[1] { trainMode });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.SetFontName(string fontName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10430), new object[1] { fontName });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxFont> IOcrMaxService.GetFont()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxFont>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10456), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxResult> IOcrMaxService.GetResults()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxResult>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10474), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<ImageBytes[]> IOcrMaxService.GetResultImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BWpaeXK949(kgbOBx7BanbFa22Hp9.ol99ukmDA(10498));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<ImageBytes[]> IOcrMaxService.GetFontImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BWpaeXK949(kgbOBx7BanbFa22Hp9.ol99ukmDA(10538));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.ImportFont(CvsOcrMaxExportedFont font)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10574), new object[1] { font });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxExportedFont> IOcrMaxService.ExportFont()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxExportedFont>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10598), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImages_003Ed__21))]
	private Task<ImageBytes[]> BWpaeXK949(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImages_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageBytes[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.command = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImage_003Ed__22))]
	private Task<ImageBytes> JoiaSdKXxZ(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImage_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageBytes>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIOcrMaxService_002DGetTextDiagnostics_003Ed__23))]
	Task<CvsOcrMaxDiagnosticData> IOcrMaxService.GetTextDiagnostics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIOcrMaxService_002DGetTextDiagnostics_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsOcrMaxDiagnosticData>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxFont> IOcrMaxAutoTuneService.GetAutoTuneFont()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxFont>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10622), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<ImageBytes[]> IOcrMaxAutoTuneService.GetAutoTuneFontImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BWpaeXK949(kgbOBx7BanbFa22Hp9.ol99ukmDA(10656));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<string> IOcrMaxAutoTuneService.GetLastSessionPath()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<string>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10708), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxAutoTuneService.SetLastSessionPath(string autoTuneSessionPath)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(10748), new object[1] { autoTuneSessionPath });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<IEnumerable<string>> IOcrMaxAutoTuneService.GetSavedModelNames()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(dwfavGSImk.Sheet.AutoTuneModelDataCache.GetSessionNames());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<byte[]> IOcrMaxAutoTuneService.GetSavedAutoTuneModelData(string modelName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(dwfavGSImk.Sheet.AutoTuneModelDataCache.GetModelDataFor(modelName));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxAutoTuneService.SetAutoTuneModelData(string modelName, byte[] data)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LEXvKEdX425GktB3qF0(VvgjIAdGPIuFDBgajeV(O2HPlfdnvsc3BYXit8K(dwfavGSImk)), modelName, data);
		return ThreadingTaskHelpers.Completed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxAutoTuneService.AddAutoTuneModelData(Dictionary<string, byte[]> dataDictionary)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dwfavGSImk.Sheet.AutoTuneModelDataCache.AddModelData(dataDictionary);
		return ThreadingTaskHelpers.Completed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxAutoTuneService.ClearAutoTuneData(string modelName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((OcrMaxAutoTuneModelDataCache)VvgjIAdGPIuFDBgajeV(dwfavGSImk.Sheet)).ClearModelDataFor(modelName);
		return ThreadingTaskHelpers.Completed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxAutoTuneService.StartAutoTuneMode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10788), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneResultObject[]> IOcrMaxAutoTuneService.AutoSegment(string trainString, CancellationToken cancellationToken)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Task<CvsOcrMaxAutoTuneResultObject[]> task = sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneResultObject[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10826), new object[1] { trainString });
		return q6CarkFpym(task, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneRecord[]> IOcrMaxAutoTuneService.AutoTune(int recordIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneRecord[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10852), new object[1] { recordIndex });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoSegmentGraphics> IOcrMaxAutoTuneService.GetAutoSegmentGraphics(int resultIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoSegmentGraphics>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10872), new object[1] { resultIndex });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DDeleteRecordInModel_003Ed__37))]
	Task<CvsOcrMaxAutoTuneRecord[]> IOcrMaxAutoTuneService.DeleteRecordInModel(int recordIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DDeleteRecordInModel_003Ed__37 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsOcrMaxAutoTuneRecord[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.recordIndex = recordIndex;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneExit> IOcrMaxAutoTuneService.ExitAutoTuneMode(bool commitSegmentation, bool commitFont)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneExit>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10920), new object[2] { commitSegmentation, commitFont });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneRecord[]> IOcrMaxAutoTuneService.SetAutoTuneRegions(CvsOcrMaxAutoTuneRegions regions, CancellationToken cancellationToken)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Task<CvsOcrMaxAutoTuneRecord[]> task = sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneRecord[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10956), new object[1] { regions });
		return q6CarkFpym(task, cancellationToken);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneRecord[]> IOcrMaxAutoTuneService.GetAutoTuneRecords()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneRecord[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10996), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DExportAutoTuneModel_003Ed__41))]
	Task<byte[]> IOcrMaxAutoTuneService.ExportAutoTuneModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DExportAutoTuneModel_003Ed__41 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneRecord[]> IOcrMaxAutoTuneService.ImportAutoTuneModel(byte[] importedData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsOcrMaxExportedAutoTuneData cvsOcrMaxExportedAutoTuneData = CvsOcrMaxExportedAutoTuneData.FromBytes(importedData);
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneRecord[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11036), new object[1] { cvsOcrMaxExportedAutoTuneData });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxAutoTuneService.SetAutoTuneParameters(CvsOcrMaxAutoTuneParams parameters)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>((string)u4S9ugdaNjrk1vqkwss(11078), new object[1] { parameters });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneParams> IOcrMaxAutoTuneService.GetAutoTuneParameters()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneParams>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11116), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.StartOcrMaxSession()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(result: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IOcrMaxService.EndOcrMaxSession()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11154), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneRecord[]> IOcrMaxAutoTuneService.AddRecord(string trainString)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneRecord[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11190), new object[1] { trainString });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsOcrMaxAutoTuneRecord[]> IOcrMaxAutoTuneService.UseCurrentAsModel(int recordIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneRecord[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11212), new object[1] { recordIndex });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DGetModelImageAndGraphics_003Ed__49))]
	Task<ImageBytes> IOcrMaxAutoTuneService.GetModelImageAndGraphics(int recordIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIOcrMaxAutoTuneService_002DGetModelImageAndGraphics_003Ed__49 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageBytes>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.recordIndex = recordIndex;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAllowAutoTuneCancellation_003Ed__50<>))]
	private Task<AMTaCCrs7tqqIlmJko> q6CarkFpym<AMTaCCrs7tqqIlmJko>(Task<AMTaCCrs7tqqIlmJko> P_0, CancellationToken P_1) where AMTaCCrs7tqqIlmJko : class
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAllowAutoTuneCancellation_003Ed__50<AMTaCCrs7tqqIlmJko> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<AMTaCCrs7tqqIlmJko>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.dataTask = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<CvsOcrMaxAutoTuneModelImageGraphic> eWgaCWItBr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneModelImageGraphic>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11250), new object[1] { P_0 });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<CvsOcrMaxAutoTuneModelImageGraphic> SEka284550(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sGJaVG7IKE.PostAsync<CvsOcrMaxAutoTuneModelImageGraphic>(kgbOBx7BanbFa22Hp9.ol99ukmDA(11292), new object[1] { P_0 });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void w7GayqluEX(Graphics P_0, string P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MemoryStream memoryStream = new MemoryStream((byte[])csWaTxd6lx3GTqwqquL(AyMRv7dbajgWKGne5PV(), P_1));
		try
		{
			P_0.SetClip(new Rectangle(0, 0, P_2, P_3));
			SvgDocument svgDocument = SvgDocument.Open<SvgDocument>(memoryStream);
			svgDocument.ViewBox = new SvgViewBox(0f, 0f, P_2, P_3);
			svgDocument.Draw(P_0);
		}
		finally
		{
			if (memoryStream != null)
			{
				ODUJeodpqrxXkWXlOV0(memoryStream);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h75OgVdIFX9hccgi34O()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yOTVQedRlaUAwj5earQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CvsI1NdeSadrZiDWlRF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sbrJpEduum45KvEU9Ey()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u4S9ugdaNjrk1vqkwss(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O2HPlfdnvsc3BYXit8K(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VvgjIAdGPIuFDBgajeV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).AutoTuneModelDataCache;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LEXvKEdX425GktB3qF0(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((OcrMaxAutoTuneModelDataCache)P_0).SetModelDataFor((string)P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AyMRv7dbajgWKGne5PV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object csWaTxd6lx3GTqwqquL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ODUJeodpqrxXkWXlOV0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}
}
