using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.ViDiEL;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Classify;
using Cognex.InSight.Services;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class ViDiELClassifyToolApi : IViDiELClassifyService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetBitmap_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<BitmapImage> _003C_003Et__builder;

		public string imageId;

		public ViDiELClassifyToolApi _003C_003E4__this;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!r5UFEosVytmAcRCpVcq8()) ? 5 : 3);
			int num2 = default;
			TaskAwaiter<Stream> awaiter = default;
			ViDiELClassifyToolApi viDiELClassifyToolApi = default;
			Stream result = default;
			BitmapImage result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (KtJASQsVZw0Q0S4eprUR(imageId))
								{
									_ = 1;
									num3 = (O3oqrBsVgCXIU10xyE4K() ? 8 : 6);
								}
								else
								{
									awaiter = viDiELClassifyToolApi.UnOOoVh76u.GetHttpAsync((string)CM6lpUsVJkrZ95WsH7f7(12472) + imageId, new TimeSpan(0, 1, 0)).GetAwaiter();
									num3 = 10;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 5;
								if (!r5UFEosVytmAcRCpVcq8())
								{
									goto IL_0070;
								}
							}
							while (true)
							{
								switch (num3)
								{
								case 9:
									return;
								case 0:
								case 6:
									break;
								case 1:
									goto end_IL_009c;
								case 3:
									_003C_003Eu__1 = awaiter;
									goto case 7;
								default:
									num3 = 7;
									continue;
								case 4:
									num2 = (_003C_003E1__state = 0);
									num3 = 3;
									continue;
								case 5:
									_003C_003Eu__1 = default;
									num3 = 2;
									continue;
								case 10:
									if (!awaiter.IsCompleted)
									{
										num3 = 4;
										continue;
									}
									goto IL_0123;
								case 2:
									num2 = (_003C_003E1__state = -1);
									goto IL_0123;
								case 8:
									goto end_IL_009c;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 9;
									if (r5UFEosVytmAcRCpVcq8())
									{
										continue;
									}
									goto case 11;
								case 11:
									{
										BitmapImage bitmapImage = new BitmapImage();
										XWHpbPsV8xeZTgMEbCSW(bitmapImage);
										qmX9U5sVzVWdauMQUR6G(bitmapImage, result);
										NiJXipsAw3hEKvoVXiIr(bitmapImage);
										result2 = bitmapImage;
										goto end_IL_009c;
									}
									IL_0123:
									result = awaiter.GetResult();
									num3 = 11;
									continue;
								}
								goto IL_0070;
								continue;
								end_IL_009c:
								break;
							}
							goto end_IL_0027;
							IL_0070:
							result2 = null;
							end_IL_0027:;
						}
						catch (CvsNetworkException)
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
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 4:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					continue;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				viDiELClassifyToolApi = _003C_003E4__this;
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
		internal static bool KtJASQsVZw0Q0S4eprUR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrWhiteSpace((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CM6lpUsVJkrZ95WsH7f7(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XWHpbPsV8xeZTgMEbCSW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BitmapImage)P_0).BeginInit();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qmX9U5sVzVWdauMQUR6G(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BitmapImage)P_0).StreamSource = (Stream)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NiJXipsAw3hEKvoVXiIr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BitmapImage)P_0).EndInit();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r5UFEosVytmAcRCpVcq8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O3oqrBsVgCXIU10xyE4K()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetModelHealth_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<double> _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		private TaskAwaiter<double> _003C_003Eu__1;

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
			goto IL_01a9;
			IL_001a:
			int num2 = _003C_003E1__state;
			IYZycKsAhwuj4ACXVWXo();
			num = ((!Yd6ayysAsF7WaDNsDyFp()) ? 4 : 2);
			goto IL_01a9;
			IL_01a9:
			ViDiELClassifyToolApi viDiELClassifyToolApi = default;
			double result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 5:
					try
					{
						try
						{
							TaskAwaiter<double> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<double>(kgbOBx7BanbFa22Hp9.ol99ukmDA(52646), Array.Empty<object>()).GetAwaiter();
								IYZycKsAhwuj4ACXVWXo();
								num3 = ((!Yd6ayysAsF7WaDNsDyFp()) ? 5 : 8);
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
								case 4:
									_003C_003Eu__1 = default;
									num3 = 6;
									if (true)
									{
										continue;
									}
									return;
								case 3:
									return;
								case 1:
								case 5:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 0:
								case 8:
									if (awaiter.IsCompleted)
									{
										break;
									}
									goto case 1;
								case 7:
									_003C_003Eu__1 = awaiter;
									num3 = 2;
									continue;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 3;
									continue;
								case 9:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						catch (CvsNetworkException)
						{
							result = 0.0;
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
				case 1:
				case 2:
					viDiELClassifyToolApi = _003C_003E4__this;
					num = 5;
					continue;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (Yd6ayysAsF7WaDNsDyFp())
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
		internal static bool Yd6ayysAsF7WaDNsDyFp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IYZycKsAhwuj4ACXVWXo()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetNextImageToLabel_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eer9jIsAL5mPSDet048a();
			int num;
			if (!viFhAEsA9aoMdBty46GZ())
			{
				num = 4;
				if (!eer9jIsAL5mPSDet048a())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_01d1;
			IL_004a:
			ViDiELClassifyToolApi viDiELClassifyToolApi = _003C_003E4__this;
			num = 5;
			goto IL_01d1;
			IL_01d1:
			int num2 = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 1:
				case 3:
					goto IL_004a;
				case 5:
					try
					{
						try
						{
							TaskAwaiter<string> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<string>((string)OTNCFFsASCiiwgF6QKtv(52678), Array.Empty<object>()).GetAwaiter();
								viFhAEsA9aoMdBty46GZ();
								if (eer9jIsAL5mPSDet048a())
								{
									num3 = 6;
									if (1 == 0)
									{
										goto IL_00a0;
									}
								}
								else
								{
									num3 = 8;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 1;
							}
							goto IL_00d1;
							IL_00a0:
							_003C_003Eu__1 = awaiter;
							num3 = 4;
							goto IL_00d1;
							IL_00d1:
							while (true)
							{
								switch (num3)
								{
								case 2:
								case 8:
									break;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 5;
									continue;
								case 5:
									return;
								case 3:
									num2 = (_003C_003E1__state = 0);
									break;
								case 1:
									_003C_003Eu__1 = default;
									num3 = 7;
									if (!viFhAEsA9aoMdBty46GZ())
									{
										continue;
									}
									goto case 0;
								case 0:
								case 6:
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 9;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (viFhAEsA9aoMdBty46GZ())
									{
									}
									continue;
								case 9:
									result = awaiter.GetResult();
									goto end_IL_00d1;
								}
								goto IL_00a0;
								continue;
								end_IL_00d1:
								break;
							}
						}
						catch (CvsNetworkException)
						{
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
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto IL_004a;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (!eer9jIsAL5mPSDet048a())
			{
				goto IL_004a;
			}
			goto IL_01d1;
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
		internal static object OTNCFFsASCiiwgF6QKtv(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eer9jIsAL5mPSDet048a()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool viFhAEsA9aoMdBty46GZ()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DAddClass_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		public string label;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_01b7;
			IL_001a:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_01b7;
			IL_01b7:
			ViDiELClassifyToolApi viDiELClassifyToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					try
					{
						try
						{
							TaskAwaiter<object> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(52720), new object[1] { label }).GetAwaiter();
								akEw5EsAvSXKW7UFuKIv();
								if (rGSfg0sAEaJlS8smyuTI())
								{
									num3 = 4;
									if (akEw5EsAvSXKW7UFuKIv())
									{
										goto IL_0093;
									}
								}
								else
								{
									num3 = 5;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 1;
							}
							goto IL_010a;
							IL_0093:
							_003C_003Eu__1 = default;
							num3 = 2;
							goto IL_010a;
							IL_010a:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 8:
									return;
								case 0:
								case 4:
									if (!awaiter.IsCompleted)
									{
										num3 = 6;
										if (0 == 0)
										{
											continue;
										}
										goto case 3;
									}
									goto case 9;
								case 3:
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 8;
									continue;
								case 7:
									_003C_003Eu__1 = awaiter;
									goto case 3;
								case 6:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 9:
									awaiter.GetResult();
									goto end_IL_010a;
								}
								goto IL_0093;
								continue;
								end_IL_010a:
								break;
							}
						}
						catch (CvsNetworkException)
						{
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
				case 1:
					do
					{
						viDiELClassifyToolApi = _003C_003E4__this;
						_ = 1;
						if (akEw5EsAvSXKW7UFuKIv())
						{
							num = 4;
							continue;
						}
						num = 0;
						break;
					}
					while (!rGSfg0sAEaJlS8smyuTI());
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
		internal static bool rGSfg0sAEaJlS8smyuTI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool akEw5EsAvSXKW7UFuKIv()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DLabelCurrentImage_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		public string label;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dJL5e7sAVjNhw5NKfBpE();
			int num = ((!D8LxmasAHxbpfqNj8JYH()) ? 2 : 3);
			int num2 = default;
			ViDiELClassifyToolApi viDiELClassifyToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(52750), new object[1] { label }).GetAwaiter();
							num3 = 6;
							goto IL_00aa;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0130;
						IL_0130:
						_003C_003Eu__1 = default;
						num3 = 8;
						if (dJL5e7sAVjNhw5NKfBpE())
						{
						}
						goto IL_00aa;
						IL_00aa:
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 7:
								return;
							case 6:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = (D8LxmasAHxbpfqNj8JYH() ? 4 : 3);
									continue;
								}
								goto case 9;
							case 3:
							case 5:
								break;
							case 9:
								awaiter.GetResult();
								goto end_IL_00aa;
							}
							goto IL_0130;
							continue;
							end_IL_00aa:
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
					num = 5;
					if (D8LxmasAHxbpfqNj8JYH())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					viDiELClassifyToolApi = _003C_003E4__this;
					num = 4;
					continue;
				case 5:
					break;
				case 0:
				case 3:
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
		internal static bool D8LxmasAHxbpfqNj8JYH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dJL5e7sAVjNhw5NKfBpE()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DAddCurrentImageToUnlabeled_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!YfI0WqsADESsUqnHrg8T())
			{
				num = 4;
				if (YfI0WqsADESsUqnHrg8T())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01ad;
			IL_0041:
			ViDiELClassifyToolApi viDiELClassifyToolApi = _003C_003E4__this;
			num = 5;
			if (!SKfexUsAAohMVgNfmnLf())
			{
				goto IL_0058;
			}
			goto IL_01ad;
			IL_0058:
			int num2 = default;
			try
			{
				TaskAwaiter<object> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<object>((string)mydeNssAUjHOjeyUiHsf(52788), Array.Empty<object>()).GetAwaiter();
					_ = 0;
					num3 = ((!SKfexUsAAohMVgNfmnLf()) ? 7 : 8);
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
					case 5:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 4:
						_003C_003Eu__1 = default;
						num3 = 5;
						continue;
					case 1:
						return;
					case 6:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						continue;
					case 3:
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 1;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							continue;
						}
						break;
					case 2:
						_003C_003Eu__1 = awaiter;
						goto case 3;
					case 9:
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
			goto IL_002a;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				goto IL_0041;
			}
			goto IL_01ad;
			IL_01ad:
			while (true)
			{
				switch (num)
				{
				case 1:
					goto IL_0041;
				case 5:
					goto IL_0058;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
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
		internal static object mydeNssAUjHOjeyUiHsf(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SKfexUsAAohMVgNfmnLf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YfI0WqsADESsUqnHrg8T()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetPredictedResult_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELClassifyPredictedResult> _003C_003Et__builder;

		public string imageId;

		public ViDiELClassifyToolApi _003C_003E4__this;

		private TaskAwaiter<ELClassifyPredictedResult> _003C_003Eu__1;

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
			goto IL_01f7;
			IL_001a:
			ViDiELClassifyToolApi viDiELClassifyToolApi = _003C_003E4__this;
			num = 4;
			goto IL_01f7;
			IL_01f7:
			int num2 = default;
			ELClassifyPredictedResult result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				case 4:
					try
					{
						if (num2 != 0 && string.IsNullOrEmpty(imageId))
						{
							result = null;
						}
						else
						{
							try
							{
								TaskAwaiter<ELClassifyPredictedResult> awaiter;
								int num3;
								if (num2 != 0)
								{
									awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<ELClassifyPredictedResult>((string)DU3EN4sAic7AxCwMU97G(52844), new object[1] { imageId }).GetAwaiter();
									num3 = 8;
									if (1 == 0)
									{
										goto IL_0085;
									}
									goto IL_00d7;
								}
								awaiter = _003C_003Eu__1;
								goto IL_011e;
								IL_017d:
								ELClassifyPredictedResult result2 = awaiter.GetResult();
								LAkT6UsAqissr4pKoIh4(result2, imageId);
								result = result2;
								goto end_IL_0049;
								IL_00d7:
								while (true)
								{
									switch (num3)
									{
									case 8:
										break;
									case 2:
									case 4:
										return;
									case 6:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										goto default;
									default:
										CBaLp4sATGSlFHj7Zn4P();
										num3 = (OIl0Q0sAdOSX0yE3MMN1() ? 1 : 2);
										continue;
									case 1:
									case 5:
										goto IL_011e;
									case 3:
										num2 = (_003C_003E1__state = 0);
										num3 = 0;
										if (true)
										{
											continue;
										}
										goto case 0;
									case 0:
										_003C_003Eu__1 = awaiter;
										num3 = 6;
										if (CBaLp4sATGSlFHj7Zn4P())
										{
											continue;
										}
										goto case 7;
									case 7:
										num2 = (_003C_003E1__state = -1);
										num3 = 9;
										continue;
									case 9:
										goto IL_017d;
									}
									break;
								}
								goto IL_0085;
								IL_0085:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									goto IL_00d7;
								}
								goto IL_017d;
								IL_011e:
								_003C_003Eu__1 = default;
								num3 = 7;
								if (OIl0Q0sAdOSX0yE3MMN1())
								{
								}
								goto IL_00d7;
								end_IL_0049:;
							}
							catch (CvsErrorResponseNetworkException ex)
							{
								UEP44NsAjs9GZetJUqp7(rl8OAbWtU6, LogLevel.Warn, cfdROXsABhKUMjHkUD6n(DU3EN4sAic7AxCwMU97G(52884), imageId), ex);
								result = null;
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
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					CBaLp4sATGSlFHj7Zn4P();
					num = ((!OIl0Q0sAdOSX0yE3MMN1()) ? 2 : 5);
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
		internal static object DU3EN4sAic7AxCwMU97G(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LAkT6UsAqissr4pKoIh4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELClassifyPredictedResult)P_0).ImageId = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cfdROXsABhKUMjHkUD6n(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UEP44NsAjs9GZetJUqp7(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CBaLp4sATGSlFHj7Zn4P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OIl0Q0sAdOSX0yE3MMN1()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetToolFailingClassNames_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string[]> _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_01db;
			IL_001a:
			string[] result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01db;
			IL_01db:
			ViDiELClassifyToolApi viDiELClassifyToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					viDiELClassifyToolApi = _003C_003E4__this;
					pDTk5JsA2TAboDTW7ELX();
					if (LVKqhpsAc05uV6IVaGJg())
					{
						num = 0;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					}
					num = 5;
					continue;
				case 0:
				case 2:
					try
					{
						try
						{
							TaskAwaiter<string[]> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<string[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(52962), Array.Empty<object>()).GetAwaiter();
								num3 = 9;
								if (!LVKqhpsAc05uV6IVaGJg())
								{
									goto IL_008c;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 6;
							}
							goto IL_0101;
							IL_0101:
							while (true)
							{
								string[] array;
								switch (num3)
								{
								case 0:
								case 1:
									break;
								case 7:
									return;
								case 4:
									_003C_003Eu__1 = awaiter;
									goto case 3;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 8;
									continue;
								case 3:
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								case 8:
									array = awaiter.GetResult();
									if (array == null)
									{
										num3 = 10;
										continue;
									}
									goto IL_0193;
								case 9:
									if (!awaiter.IsCompleted)
									{
										_ = 0;
										num3 = ((!LVKqhpsAc05uV6IVaGJg()) ? 5 : 0);
										continue;
									}
									goto case 8;
								case 6:
									_003C_003Eu__1 = default;
									num3 = 2;
									continue;
								case 10:
									{
										array = Array.Empty<string>();
										goto IL_0193;
									}
									IL_0193:
									result = array;
									goto end_IL_0101;
								}
								goto IL_008c;
								continue;
								end_IL_0101:
								break;
							}
							goto end_IL_0056;
							IL_008c:
							num2 = (_003C_003E1__state = 0);
							num3 = 4;
							if (1 == 0)
							{
								return;
							}
							goto IL_0101;
							end_IL_0056:;
						}
						catch (CvsNetworkException)
						{
							result = Array.Empty<string>();
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
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static bool LVKqhpsAc05uV6IVaGJg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pDTk5JsA2TAboDTW7ELX()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DRemoveImage_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		public string imageId;

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
			ViDiELClassifyToolApi viDiELClassifyToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						try
						{
							TaskAwaiter<object> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<object>((string)M9n6gysAt5PEJKPh9xjB(53008), new object[1] { imageId }).GetAwaiter();
								num3 = 4;
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
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 3;
									if (hHpkaJsAWxloIBKpAwi7())
									{
										continue;
									}
									return;
								case 3:
									return;
								case 2:
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 7;
									continue;
								case 1:
									num2 = (_003C_003E1__state = 0);
									RykDaisA7Ui4oDp6dDNX();
									if (hHpkaJsAWxloIBKpAwi7())
									{
										num3 = 8;
										if (RykDaisA7Ui4oDp6dDNX())
										{
										}
									}
									else
									{
										num3 = 5;
									}
									continue;
								case 5:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 0:
									_003C_003Eu__1 = default;
									goto case 5;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										if (hHpkaJsAWxloIBKpAwi7())
										{
											continue;
										}
									}
									break;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (CvsNetworkException)
						{
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
						break;
					}
					goto case 0;
				case 0:
					viDiELClassifyToolApi = _003C_003E4__this;
					hHpkaJsAWxloIBKpAwi7();
					if (RykDaisA7Ui4oDp6dDNX())
					{
						num = 1;
						if (hHpkaJsAWxloIBKpAwi7())
						{
							break;
						}
						goto default;
					}
					num = 4;
					break;
				case 5:
					num2 = _003C_003E1__state;
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
		internal static object M9n6gysAt5PEJKPh9xjB(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hHpkaJsAWxloIBKpAwi7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RykDaisA7Ui4oDp6dDNX()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DSetClassLabel_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		public string imageId;

		public string label;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gLAaLhsAC4DdrabTyO2b();
			int num = (YiAboSsAK9ULTaqRB0QI() ? 3 : 4);
			ViDiELClassifyToolApi viDiELClassifyToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					viDiELClassifyToolApi = _003C_003E4__this;
					num = 5;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					try
					{
						try
						{
							TaskAwaiter<object> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<object>((string)tiHwtmsA5s3d2fvQl8uf(53034), new object[2] { imageId, label }).GetAwaiter();
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 7;
								if (!gLAaLhsAC4DdrabTyO2b())
								{
									goto IL_00f0;
								}
							}
							goto IL_0140;
							IL_00f0:
							_003C_003Eu__1 = awaiter;
							_ = 0;
							num3 = ((!gLAaLhsAC4DdrabTyO2b()) ? 6 : 8);
							goto IL_0140;
							IL_0140:
							while (true)
							{
								switch (num3)
								{
								case 7:
									_003C_003Eu__1 = default;
									num3 = 2;
									continue;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								default:
									return;
								case 6:
									return;
								case 0:
									break;
								case 1:
									num2 = (_003C_003E1__state = 0);
									num3 = 0;
									continue;
								case 3:
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 5:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto case 9;
								case 9:
									awaiter.GetResult();
									goto end_IL_0140;
								}
								goto IL_00f0;
								continue;
								end_IL_0140:
								break;
							}
						}
						catch (CvsNetworkException)
						{
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
					if (YiAboSsAK9ULTaqRB0QI())
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
		internal static object tiHwtmsA5s3d2fvQl8uf(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gLAaLhsAC4DdrabTyO2b()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YiAboSsAK9ULTaqRB0QI()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DSetClassFailsTool_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		public string label;

		public bool failTool;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gdqQpYsAoCrwcU5GUFxT();
			int num;
			if (!Me17uGsAPUHovZRpGMMB())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01d9;
			IL_002a:
			int num2 = _003C_003E1__state;
			goto IL_0041;
			IL_01d9:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 2:
					goto IL_0041;
				case 4:
					goto IL_0054;
				default:
					num = 5;
					continue;
				case 5:
					goto IL_0204;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_0041:
			ViDiELClassifyToolApi viDiELClassifyToolApi = _003C_003E4__this;
			num = 4;
			if (false)
			{
				goto IL_0054;
			}
			goto IL_01d9;
			IL_0204:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01d9;
			IL_0054:
			try
			{
				try
				{
					TaskAwaiter<object> awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<object>((string)OY7nCWsAYDvdNQkx6Ro7(53064), new object[2] { label, failTool }).GetAwaiter();
						Me17uGsAPUHovZRpGMMB();
						if (gdqQpYsAoCrwcU5GUFxT())
						{
							num3 = 8;
							if (false)
							{
								return;
							}
						}
						else
						{
							num3 = 1;
						}
						goto IL_0104;
					}
					awaiter = _003C_003Eu__1;
					goto IL_013b;
					IL_0104:
					while (true)
					{
						switch (num3)
						{
						case 7:
							return;
						case 3:
							_003C_003Eu__1 = awaiter;
							num3 = 6;
							if (!Me17uGsAPUHovZRpGMMB())
							{
								continue;
							}
							goto case 6;
						case 6:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						default:
							num3 = 7;
							continue;
						case 1:
						case 5:
							break;
						case 2:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							continue;
						case 4:
							num2 = (_003C_003E1__state = 0);
							num3 = 3;
							continue;
						case 0:
						case 8:
							if (!awaiter.IsCompleted)
							{
								num3 = 4;
								continue;
							}
							goto case 9;
						case 9:
							awaiter.GetResult();
							goto end_IL_0104;
						}
						goto IL_013b;
						continue;
						end_IL_0104:
						break;
					}
					goto end_IL_0057;
					IL_013b:
					_003C_003Eu__1 = default;
					num3 = 2;
					goto IL_0104;
					end_IL_0057:;
				}
				catch (CvsNetworkException)
				{
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0204;
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
		internal static object OY7nCWsAYDvdNQkx6Ro7(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gdqQpYsAoCrwcU5GUFxT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Me17uGsAPUHovZRpGMMB()
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
	private struct _003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DTrain_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyToolApi _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (lgr3aysAxpEQPEQHHin5() ? 3 : 4);
			ViDiELClassifyToolApi viDiELClassifyToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
					viDiELClassifyToolApi = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						try
						{
							TaskAwaiter<object> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = viDiELClassifyToolApi.UnOOoVh76u.PostAsync<object>((string)Yy4VyMsA124NTsrnaUpO(52632), Array.Empty<object>()).GetAwaiter();
								num3 = 0;
								if (1 == 0)
								{
									goto IL_0085;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 1;
							}
							goto IL_011d;
							IL_011d:
							while (true)
							{
								switch (num3)
								{
								case 0:
									break;
								case 7:
									_003C_003Eu__1 = awaiter;
									_ = 1;
									if (!lgr3aysAxpEQPEQHHin5())
									{
										num3 = 2;
										if (APZCnisANYpRedYGk4WB())
										{
											continue;
										}
										goto case 6;
									}
									num3 = 5;
									if (!lgr3aysAxpEQPEQHHin5())
									{
										continue;
									}
									goto case 8;
								case 6:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 1:
									_003C_003Eu__1 = default;
									num3 = 8;
									continue;
								default:
									return;
								case 5:
									return;
								case 2:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 9:
									goto IL_0173;
								}
								break;
							}
							goto IL_0085;
							IL_0173:
							awaiter.GetResult();
							goto end_IL_0053;
							IL_0085:
							if (!awaiter.IsCompleted)
							{
								num3 = 6;
								goto IL_011d;
							}
							goto IL_0173;
							end_IL_0053:;
						}
						catch (CvsNetworkException)
						{
						}
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
				case 0:
				case 4:
					num2 = _003C_003E1__state;
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
		internal static object Yy4VyMsA124NTsrnaUpO(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool APZCnisANYpRedYGk4WB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lgr3aysAxpEQPEQHHin5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ResourceNode UnOOoVh76u;

	private static readonly ILogger rl8OAbWtU6;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELClassifyToolApi(ResourceNode toolResourceNode)
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
			default:
				UnOOoVh76u = toolResourceNode;
				num = 5;
				if (!mrSiueiMTKLfQIg1ELA())
				{
					continue;
				}
				break;
			case 0:
				break;
			case 1:
			case 4:
				dY1cJVil36t7LDqd4qD(this);
				goto default;
			case 5:
				return;
			}
			AViZLyiQxxKDyJ7jmnf();
			mrSiueiMTKLfQIg1ELA();
			num = ((!plVuIDiOUxZlrkgh53l()) ? 3 : 4);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IViDiELClassifyService.ClearClassLabel(string imageId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12412), new object[1] { imageId });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<string[]> IViDiELClassifyService.GetImageIds(string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.PostAsync<string[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12446), new object[1] { label });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsCogImage> IViDiELClassifyService.GetImageInfo(string imageId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.GetAsync<CvsCogImage>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12472) + imageId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetBitmap_003Ed__6))]
	Task<BitmapImage> IViDiELClassifyService.GetBitmap(string imageId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetBitmap_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<BitmapImage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.imageId = imageId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetModelHealth_003Ed__7))]
	Task<double> IViDiELClassifyService.GetModelHealth()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetModelHealth_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<double>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetNextImageToLabel_003Ed__8))]
	Task<string> IViDiELClassifyService.GetNextImageToLabel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetNextImageToLabel_003Ed__8 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DAddClass_003Ed__9))]
	Task IViDiELClassifyService.AddClass(string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		plVuIDiOUxZlrkgh53l();
		int num = (mrSiueiMTKLfQIg1ELA() ? 6 : 2);
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DAddClass_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = U6uv01ieIR74EmZyEJs();
				goto case 1;
			case 5:
				stateMachine.label = label;
				goto case 4;
			default:
				num = 4;
				if (plVuIDiOUxZlrkgh53l())
				{
					break;
				}
				goto case 1;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DLabelCurrentImage_003Ed__10))]
	Task IViDiELClassifyService.LabelCurrentImage(string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (plVuIDiOUxZlrkgh53l())
		{
			num = 1;
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_00b5;
			}
		}
		goto IL_0056;
		IL_00cf:
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DLabelCurrentImage_003Ed__10 stateMachine = default;
		return stateMachine._003C_003Et__builder.Task;
		IL_00b5:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		if (true)
		{
			goto IL_0056;
		}
		goto IL_00cf;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (!mrSiueiMTKLfQIg1ELA())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine.label = label;
				goto case 5;
			default:
				num = 5;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = U6uv01ieIR74EmZyEJs();
				num = 2;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			case 4:
			case 6:
				break;
			case 7:
				goto IL_00cf;
			}
			break;
		}
		goto IL_00b5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DAddCurrentImageToUnlabeled_003Ed__11))]
	Task IViDiELClassifyService.AddCurrentImageToUnlabeled()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DAddCurrentImageToUnlabeled_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = U6uv01ieIR74EmZyEJs();
				num = 4;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				mrSiueiMTKLfQIg1ELA();
				num = (plVuIDiOUxZlrkgh53l() ? 5 : 0);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<long> IViDiELClassifyService.GetClassLabelImageCount(string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.PostAsync<long>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12488), new object[1] { label });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<string[]> IViDiELClassifyService.GetClassLabels()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.PostAsync<string[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12538), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetPredictedResult_003Ed__14))]
	Task<ELClassifyPredictedResult> IViDiELClassifyService.GetPredictedResult(string imageId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetPredictedResult_003Ed__14 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELClassifyPredictedResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.imageId = imageId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetToolFailingClassNames_003Ed__15))]
	Task<string[]> IViDiELClassifyService.GetToolFailingClassNames()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DGetToolFailingClassNames_003Ed__15 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DRemoveImage_003Ed__16))]
	Task IViDiELClassifyService.RemoveImage(string imageId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mrSiueiMTKLfQIg1ELA();
		int num = ((!plVuIDiOUxZlrkgh53l()) ? 2 : 4);
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DRemoveImage_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (mrSiueiMTKLfQIg1ELA())
				{
				}
				break;
			case 5:
				stateMachine.imageId = imageId;
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = U6uv01ieIR74EmZyEJs();
				goto case 1;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DSetClassLabel_003Ed__17))]
	Task IViDiELClassifyService.SetClassLabel(string imageId, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (mrSiueiMTKLfQIg1ELA())
		{
			goto IL_001e;
		}
		goto IL_00a0;
		IL_001e:
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DSetClassLabel_003Ed__17 stateMachine = default;
		stateMachine.imageId = imageId;
		num = 2;
		goto IL_00a0;
		IL_00a0:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 6:
				stateMachine._003C_003Et__builder = U6uv01ieIR74EmZyEJs();
				mrSiueiMTKLfQIg1ELA();
				if (plVuIDiOUxZlrkgh53l())
				{
					num = 3;
					if (plVuIDiOUxZlrkgh53l())
					{
						continue;
					}
					goto case 1;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			case 2:
				stateMachine.label = label;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DSetClassFailsTool_003Ed__18))]
	Task IViDiELClassifyService.SetClassFailsTool(string label, bool failTool)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DSetClassFailsTool_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 3:
				stateMachine.failTool = failTool;
				goto case 6;
			default:
				num = 6;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 7:
				stateMachine._003C_003Et__builder = U6uv01ieIR74EmZyEJs();
				mrSiueiMTKLfQIg1ELA();
				num = (plVuIDiOUxZlrkgh53l() ? 2 : 4);
				break;
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 0:
				stateMachine.label = label;
				num = 3;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DTrain_003Ed__19))]
	Task IViDiELClassifyService.Train()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CCognex_002DInSight_002DServices_002DIViDiELClassifyService_002DTrain_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder = U6uv01ieIR74EmZyEJs();
				_ = 0;
				if (plVuIDiOUxZlrkgh53l())
				{
					num = 0;
					if (mrSiueiMTKLfQIg1ELA())
					{
					}
				}
				else
				{
					num = 4;
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IViDiELClassifyService.RemoveClassLabel(string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.PostAsync<object>((string)rPWFgUiuXqSMj7yDUBQ(12570), new object[1] { label });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IViDiELClassifyService.RenameClass(string oldClassName, string newClassName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.PostAsync<object>((string)rPWFgUiuXqSMj7yDUBQ(12606), new object[2] { oldClassName, newClassName });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<ELTunableProjectionParams> IViDiELClassifyService.GetProjectionParams()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.GetAsync<ELTunableProjectionParams>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12632));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IViDiELClassifyService.SetProjectionParams(ELTunableProjectionParams tunableParams)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.PutAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12632), tunableParams);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<ELTunableProjectionParams> IViDiELClassifyService.AutoTuneProjectionParameters()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UnOOoVh76u.PostAsync<ELTunableProjectionParams>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12668), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViDiELClassifyToolApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AViZLyiQxxKDyJ7jmnf();
		rl8OAbWtU6 = LogManager.GetLogger<ViDiELClassifyToolApi>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AViZLyiQxxKDyJ7jmnf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dY1cJVil36t7LDqd4qD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool plVuIDiOUxZlrkgh53l()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mrSiueiMTKLfQIg1ELA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder U6uv01ieIR74EmZyEJs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rPWFgUiuXqSMj7yDUBQ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
