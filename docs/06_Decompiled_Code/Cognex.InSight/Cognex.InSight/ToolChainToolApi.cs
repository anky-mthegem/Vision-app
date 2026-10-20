using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Configuration;
using Cognex.InSight.VisionBuilder.Types;
using Cognex.Remoting.CogSocket;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class ToolChainToolApi : IToolchainApi
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 0:
					toolChainToolApi = _003C_003E4__this;
					_ = 1;
					num = ((!N9PygSsvEKMFAtd77y8c()) ? 1 : 5);
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = LOuCL3svvHRjDOPDJp4l(toolChainToolApi.oWlObHe2a0());
							A8oClMsvSsdG19N5cDOK();
							if (!N9PygSsvEKMFAtd77y8c())
							{
								num3 = 3;
							}
							else
							{
								num3 = 5;
								if (N9PygSsvEKMFAtd77y8c())
								{
									goto IL_00a9;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (!A8oClMsvSsdG19N5cDOK())
							{
								goto IL_00db;
							}
						}
						goto IL_0132;
						IL_016b:
						awaiter.GetResult();
						goto end_IL_005b;
						IL_0132:
						while (true)
						{
							switch (num3)
							{
							case 7:
								_003C_003Eu__1 = default;
								goto IL_00db;
							case 0:
							case 3:
								break;
							case 2:
								return;
							case 5:
							case 6:
								goto IL_00db;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto IL_016b;
							case 9:
								goto IL_016b;
							}
							break;
						}
						goto IL_00a9;
						IL_00db:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_0132;
						IL_00a9:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							goto IL_0132;
						}
						goto IL_016b;
						end_IL_005b:;
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
		internal static TaskAwaiter LOuCL3svvHRjDOPDJp4l(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A8oClMsvSsdG19N5cDOK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N9PygSsvEKMFAtd77y8c()
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
	private struct _003CUpdatePropertiesAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter<long> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dHSgxHsvHNuBErBvf8E9();
			int num;
			if (!DF5JqosvV9dyt2fRG1ri())
			{
				num = 2;
				if (!dHSgxHsvHNuBErBvf8E9())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_02b1;
			IL_0318:
			int num2 = _003C_003E1__state;
			num = 1;
			if (false)
			{
				return;
			}
			goto IL_02b1;
			IL_02b1:
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
					toolChainToolApi = _003C_003E4__this;
					num = 4;
					if (DF5JqosvV9dyt2fRG1ri())
					{
					}
					continue;
				default:
					goto IL_02fd;
				case 0:
				case 2:
					goto IL_0318;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				int num3;
				TaskAwaiter<long> awaiter = default;
				TaskAwaiter<bool> awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 15;
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 3;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 8;
				}
				long result2 = default;
				bool result = default;
				while (true)
				{
					switch (num3)
					{
					case 6:
						return;
					case 17:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 6;
						continue;
					case 11:
						num2 = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						num3 = 17;
						continue;
					case 3:
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_00a4;
					case 5:
					case 9:
						if (!awaiter.IsCompleted)
						{
							num3 = 11;
							continue;
						}
						goto IL_00a4;
					case 0:
						toolChainToolApi.SWNOgfkSUW = result2;
						num3 = 10;
						if (dHSgxHsvHNuBErBvf8E9())
						{
							continue;
						}
						goto case 16;
					case 16:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						if (true)
						{
							continue;
						}
						goto case 1;
					case 1:
						toolChainToolApi.gZKOlTwYDW = result;
						goto case 12;
					default:
						num3 = 12;
						continue;
					case 12:
						awaiter = toolChainToolApi.MmlO49aunJ.GetAsync<long>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51220)).GetAwaiter();
						goto case 5;
					case 13:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						_ = 1;
						num3 = ((!DF5JqosvV9dyt2fRG1ri()) ? 14 : 5);
						continue;
					case 2:
						_003C_003Eu__1 = awaiter2;
						num3 = 13;
						if (0 == 0)
						{
							continue;
						}
						goto case 10;
					case 10:
					{
						EventHandler eventHandler = toolChainToolApi.SrsOTLHqdK;
						if (eventHandler == null)
						{
							num3 = 18;
							continue;
						}
						hAl414svDON5Uf9Pj9GS(eventHandler, toolChainToolApi, EventArgs.Empty);
						break;
					}
					case 8:
						num2 = (_003C_003E1__state = -1);
						num3 = 7;
						continue;
					case 4:
					case 14:
						return;
					case 7:
						result = awaiter2.GetResult();
						num3 = 1;
						continue;
					case 15:
						awaiter2 = toolChainToolApi.MmlO49aunJ.GetAsync<bool>((string)GTkKGYsvA5F69UDn6WF7(51182)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num3 = 16;
							continue;
						}
						goto case 7;
					case 18:
						break;
						IL_00a4:
						result2 = awaiter.GetResult();
						num3 = 0;
						if (!DF5JqosvV9dyt2fRG1ri())
						{
							continue;
						}
						goto case 5;
					}
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
			goto IL_02fd;
			IL_02fd:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (dHSgxHsvHNuBErBvf8E9())
			{
				goto IL_02b1;
			}
			goto IL_0318;
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
		internal static object GTkKGYsvA5F69UDn6WF7(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hAl414svDON5Uf9Pj9GS(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0(P_1, (EventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dHSgxHsvHNuBErBvf8E9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DF5JqosvV9dyt2fRG1ri()
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
	private struct _003CUpdateNumImages_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<long> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!DybYudsvTxhQ72fITe78())
			{
				num = 2;
				if (!Tl4ko4svUoZoNo6JtTcE())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (DybYudsvTxhQ72fITe78())
				{
				}
			}
			goto IL_01dd;
			IL_002a:
			ToolChainToolApi toolChainToolApi = _003C_003E4__this;
			num = 3;
			goto IL_01dd;
			IL_01dd:
			int num2 = default;
			long result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 3:
					try
					{
						TaskAwaiter<long> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.GetAsync<long>((string)tn9bLysvdNlTIsrMKl1Z(51220)).GetAwaiter();
							DybYudsvTxhQ72fITe78();
							if (Tl4ko4svUoZoNo6JtTcE())
							{
								num3 = 10;
							}
							else
							{
								num3 = 1;
								if (!Tl4ko4svUoZoNo6JtTcE())
								{
									goto IL_00a9;
								}
							}
							goto IL_00f2;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00d4;
						IL_00a9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 3;
						goto IL_00f2;
						IL_00f2:
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 3:
								return;
							case 6:
								break;
							case 5:
								goto IL_00c1;
							case 1:
							case 4:
								goto IL_00d4;
							default:
								num3 = 5;
								continue;
							case 9:
								result = awaiter.GetResult();
								num3 = 7;
								if (!DybYudsvTxhQ72fITe78())
								{
									continue;
								}
								goto case 7;
							case 7:
								toolChainToolApi.SWNOgfkSUW = result;
								num3 = 8;
								continue;
							case 8:
								goto IL_015a;
							case 0:
							case 10:
								if (awaiter.IsCompleted)
								{
									goto case 9;
								}
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto end_IL_003b;
							case 11:
								goto end_IL_003b;
							}
							break;
							IL_015a:
							EventHandler eventHandler = toolChainToolApi.SrsOTLHqdK;
							if (eventHandler == null)
							{
								num3 = 11;
								continue;
							}
							cbOZG3svigNrEL7n30Jf(eventHandler, toolChainToolApi, EventArgs.Empty);
							goto end_IL_003b;
						}
						goto IL_00a9;
						IL_00c1:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00f2;
						IL_00d4:
						_003C_003Eu__1 = default;
						goto IL_00c1;
						end_IL_003b:;
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
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
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
		internal static object tn9bLysvdNlTIsrMKl1Z(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cbOZG3svigNrEL7n30Jf(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0(P_1, (EventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tl4ko4svUoZoNo6JtTcE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DybYudsvTxhQ72fITe78()
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
	private struct _003CGetImageMetadataAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageMetadata[]> _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<ImageMetadata[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!TkXH12svBrdfsfpcNLCs())
			{
			}
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			ImageMetadata[] result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						TaskAwaiter<ImageMetadata[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.GetAsync<ImageMetadata[]>((string)os0ZnGsvjfHJDmkihgYR(51242)).GetAwaiter();
							_ = 0;
							if (DKHh3YsvqRqp5JplQQy9())
							{
								num3 = 2;
							}
							else
							{
								num3 = 4;
								if (1 == 0)
								{
									goto IL_0088;
								}
							}
							goto IL_0106;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00b7;
						IL_013d:
						result = awaiter.GetResult();
						goto end_IL_0022;
						IL_0106:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 7:
								return;
							case 0:
							case 2:
								break;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (DKHh3YsvqRqp5JplQQy9())
								{
									continue;
								}
								goto IL_00b7;
							case 4:
							case 5:
								goto IL_00b7;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!TkXH12svBrdfsfpcNLCs())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 9:
								goto IL_013d;
							}
							break;
						}
						goto IL_0088;
						IL_00b7:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0106;
						IL_0088:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							goto IL_0106;
						}
						goto IL_013d;
						end_IL_0022:;
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
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					toolChainToolApi = _003C_003E4__this;
					_ = 0;
					if (!DKHh3YsvqRqp5JplQQy9())
					{
						num = 5;
						if (TkXH12svBrdfsfpcNLCs())
						{
						}
					}
					else
					{
						num = 0;
						if (TkXH12svBrdfsfpcNLCs())
						{
						}
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
		internal static object os0ZnGsvjfHJDmkihgYR(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DKHh3YsvqRqp5JplQQy9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TkXH12svBrdfsfpcNLCs()
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
	private struct _003CGetImageStreamAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public string id;

		private Stream _003Cstream_003E5__2;

		private MemoryStream _003CmemoryStream_003E5__3;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			Stream result2 = default;
			ToolChainToolApi toolChainToolApi = default;
			int num2 = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult(result2);
					num = 8;
					break;
				default:
					_003CmemoryStream_003E5__3 = null;
					num = 3;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (NFDe4isv2cAuwnZqoeEd() ? 5 : 6);
					break;
				case 2:
					_003Cstream_003E5__2 = null;
					goto default;
				case 7:
					try
					{
						TaskAwaiter<Stream> awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_0148;
							}
							TimeSpan timeout = FLUT79svW6HirhNfV0tK();
							awaiter = toolChainToolApi.MmlO49aunJ.GetHttpAsync((string)JEpc6usvtWTBGQRSiZTd(fn5uxFsv7Qp3LTfumEXa(12472), id), timeout).GetAwaiter();
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
						_003Cstream_003E5__2 = result;
						goto IL_0148;
						IL_0148:
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 5;
								goto IL_0195;
							}
							awaiter2 = _003C_003Eu__2;
							goto IL_0208;
							IL_0208:
							_003C_003Eu__2 = default;
							num3 = 9;
							goto IL_0195;
							IL_0195:
							while (true)
							{
								switch (num3)
								{
								case 1:
									awaiter2 = LsUlW7svCDZjCNT7pvKw(_003Cstream_003E5__2.CopyToAsync(_003CmemoryStream_003E5__3));
									num3 = 2;
									continue;
								case 11:
									_003C_003Eu__2 = awaiter2;
									goto case 4;
								default:
									num3 = 4;
									continue;
								case 8:
									num2 = (_003C_003E1__state = 1);
									num3 = 11;
									continue;
								case 10:
									yEE8pgsvKqcxLhKq2lVx(_003CmemoryStream_003E5__3, 0L);
									num3 = 12;
									if (iFtivLsvckBegB4sI8PK())
									{
										continue;
									}
									break;
								case 3:
								case 7:
									break;
								case 9:
									num2 = (_003C_003E1__state = -1);
									goto IL_0227;
								case 0:
								case 6:
									return;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									iFtivLsvckBegB4sI8PK();
									num3 = (NFDe4isv2cAuwnZqoeEd() ? 3 : 0);
									continue;
								case 5:
									_003CmemoryStream_003E5__3 = new MemoryStream();
									num3 = 1;
									continue;
								case 2:
									if (!awaiter2.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto IL_0227;
								case 12:
									{
										result2 = _003CmemoryStream_003E5__3;
										goto end_IL_0195;
									}
									IL_0227:
									awaiter2.GetResult();
									num3 = 10;
									if (true)
									{
										continue;
									}
									return;
								}
								goto IL_0208;
								continue;
								end_IL_0195:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003Cstream_003E5__2 != null)
							{
								((IDisposable)_003Cstream_003E5__2).Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cstream_003E5__2 = null;
						_003CmemoryStream_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 2;
					break;
				case 1:
				case 6:
					toolChainToolApi = _003C_003E4__this;
					num = 7;
					break;
				case 8:
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
		internal static TimeSpan FLUT79svW6HirhNfV0tK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCogSocketAcq.HttpImageTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fn5uxFsv7Qp3LTfumEXa(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JEpc6usvtWTBGQRSiZTd(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter LsUlW7svCDZjCNT7pvKw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yEE8pgsvKqcxLhKq2lVx(object P_0, long P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Position = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iFtivLsvckBegB4sI8PK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NFDe4isv2cAuwnZqoeEd()
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
	private struct _003CGetThumbnailImageAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bitmap> _003C_003Et__builder;

		public string id;

		public ToolChainToolApi _003C_003E4__this;

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
			if (DbZhI4sv553sF9i3uIK1())
			{
				num = 5;
			}
			else
			{
				num = 1;
				if (!DbZhI4sv553sF9i3uIK1())
				{
					return;
				}
			}
			int num2 = default;
			string text = default;
			TaskAwaiter<Stream> awaiter = default;
			ToolChainToolApi toolChainToolApi = default;
			Bitmap result = default;
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
							text = id + (string)sLgB1QsvPtYBMQdl8mE6(51272);
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 0;
							case 0:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter = toolChainToolApi.GetImageStreamAsync(text).GetAwaiter();
								DGC5gFsvoJtlbF7m1AIH();
								num3 = (DbZhI4sv553sF9i3uIK1() ? 4 : 0);
								continue;
							case 10:
								break;
							}
							break;
						}
						result = DFprsRsvYQN9MEvoLGC5(awaiter.GetResult()) as Bitmap;
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
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
				case 5:
					break;
				case 3:
					toolChainToolApi = _003C_003E4__this;
					goto case 1;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 3;
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
		internal static object sLgB1QsvPtYBMQdl8mE6(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DFprsRsvYQN9MEvoLGC5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Image.FromStream((Stream)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DbZhI4sv553sF9i3uIK1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DGC5gFsvoJtlbF7m1AIH()
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
	private struct _003CClearImageAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public string imageId;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pdAwvtsvN9UtCmkXaVXO();
			int num;
			if (!YaV6EIsvxfXDr31fDSYu())
			{
				num = 5;
				if (YaV6EIsvxfXDr31fDSYu())
				{
				}
			}
			else
			{
				num = 3;
				if (YaV6EIsvxfXDr31fDSYu())
				{
				}
			}
			ToolChainToolApi toolChainToolApi = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					toolChainToolApi = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 0;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 13;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 15:
								_003C_003Eu__2 = awaiter;
								goto case 6;
							case 10:
								_003C_003Eu__1 = awaiter2;
								_ = 0;
								num3 = (pdAwvtsvN9UtCmkXaVXO() ? 1 : 6);
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 14:
								awaiter2.GetResult();
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 13:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 5:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 10;
									continue;
								}
								goto case 14;
							case 7:
								return;
							case 2:
								awaiter = GrYPcYsv1ZoFjTv1dwWt(toolChainToolApi.oWlObHe2a0());
								num3 = 9;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 1);
								num3 = 15;
								continue;
							case 0:
								awaiter2 = toolChainToolApi.MmlO49aunJ.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51298), new object[1] { imageId }).GetAwaiter();
								num3 = 5;
								continue;
							case 12:
								return;
							case 6:
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								if (YaV6EIsvxfXDr31fDSYu())
								{
								}
								continue;
							case 1:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 12;
								continue;
							case 16:
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
					break;
				default:
					num = 2;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
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
		internal static TaskAwaiter GrYPcYsv1ZoFjTv1dwWt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pdAwvtsvN9UtCmkXaVXO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YaV6EIsvxfXDr31fDSYu()
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
	private struct _003CClearImagesAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
								if (MNq0rAsv3HL0JLoErKZG())
								{
									goto IL_01dc;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 3;
							if (MNq0rAsv3HL0JLoErKZG())
							{
							}
						}
						goto IL_014e;
						IL_014e:
						while (true)
						{
							switch (num3)
							{
							case 6:
								_003C_003Eu__1 = awaiter2;
								num3 = 14;
								continue;
							case 11:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 6;
									continue;
								}
								goto default;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									if (kKS3B6svrFwNr8IHMKEK())
									{
										continue;
									}
									return;
								}
								goto case 16;
							case 1:
							case 4:
								return;
							case 15:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 12;
								continue;
							case 10:
								awaiter = SkCZ66svMm8awpVsDRsO(toolChainToolApi.oWlObHe2a0());
								num3 = 9;
								continue;
							default:
								awaiter2.GetResult();
								num3 = 10;
								continue;
							case 5:
								awaiter2 = toolChainToolApi.MmlO49aunJ.PostAsync<object>((string)iKdUDosvOY4atYeTwkgq(51322), Array.Empty<object>()).GetAwaiter();
								num3 = 11;
								continue;
							case 12:
								num2 = (_003C_003E1__state = -1);
								goto default;
							case 0:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								if (!MNq0rAsv3HL0JLoErKZG())
								{
									continue;
								}
								return;
							case 13:
								return;
							case 2:
								break;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								_ = 1;
								num3 = ((!MNq0rAsv3HL0JLoErKZG()) ? 1 : 8);
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_014e;
							}
							goto IL_01dc;
							continue;
							end_IL_014e:
							break;
						}
						goto end_IL_0029;
						IL_01dc:
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 13;
						goto IL_014e;
						end_IL_0029:;
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
					if (0 == 0)
					{
						continue;
					}
					break;
				case 5:
					break;
				case 6:
					return;
				}
				toolChainToolApi = _003C_003E4__this;
				kKS3B6svrFwNr8IHMKEK();
				if (MNq0rAsv3HL0JLoErKZG())
				{
					num = 0;
					continue;
				}
				num = 1;
				if (MNq0rAsv3HL0JLoErKZG())
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
		internal static object iKdUDosvOY4atYeTwkgq(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter SkCZ66svMm8awpVsDRsO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kKS3B6svrFwNr8IHMKEK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MNq0rAsv3HL0JLoErKZG()
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
	private struct _003CCollectCurrentImageAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tU3c2bsvlvDdyhLf8s18();
			int num = ((!OujBpLsvQZwshUnC2Dx0()) ? 3 : 4);
			ToolChainToolApi toolChainToolApi = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					toolChainToolApi = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 12;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 9;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 14;
						}
						while (true)
						{
							switch (num3)
							{
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 3:
								if (!awaiter2.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 2;
							case 2:
								awaiter2.GetResult();
								goto default;
							default:
								OujBpLsvQZwshUnC2Dx0();
								num3 = (tU3c2bsvlvDdyhLf8s18() ? 4 : 15);
								continue;
							case 0:
								return;
							case 10:
								return;
							case 11:
								_003C_003Eu__2 = awaiter;
								num3 = 5;
								continue;
							case 4:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 11;
									continue;
								}
								break;
							case 9:
								_003C_003Eu__2 = default;
								num3 = 13;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 10;
								if (tU3c2bsvlvDdyhLf8s18())
								{
								}
								continue;
							case 12:
								awaiter2 = toolChainToolApi.MmlO49aunJ.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51348), Array.Empty<object>()).GetAwaiter();
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 14;
							case 14:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
							case 15:
								awaiter = bJMGi2svea4kbAPVEICC(toolChainToolApi.oWlObHe2a0());
								goto case 4;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 1;
								if (true)
								{
									continue;
								}
								break;
							case 16:
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
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!tU3c2bsvlvDdyhLf8s18())
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static TaskAwaiter bJMGi2svea4kbAPVEICC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OujBpLsvQZwshUnC2Dx0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tU3c2bsvlvDdyhLf8s18()
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
	private struct _003CGetTagsAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<InSightTag[]> _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<InSightTag[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!hc7FOFsvIuAici5NyR7c())
			{
				num = 4;
				if (hc7FOFsvIuAici5NyR7c())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_019e;
			IL_002a:
			InSightTag[] result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_019e;
			IL_019e:
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 5:
					try
					{
						TaskAwaiter<InSightTag[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.GetAsync<InSightTag[]>((string)MYALHasvRGPrSqkmyHXH(51390)).GetAwaiter();
							NMGXmTsvuVNYkOcNUFfB();
							num3 = (hc7FOFsvIuAici5NyR7c() ? 2 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (1 == 0)
							{
								goto IL_0145;
							}
						}
						goto IL_00de;
						IL_00de:
						while (true)
						{
							switch (num3)
							{
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (NMGXmTsvuVNYkOcNUFfB())
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							case 2:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 9;
							case 8:
								return;
							case 6:
								break;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00de;
							}
							goto IL_0145;
							continue;
							end_IL_00de:
							break;
						}
						goto end_IL_0040;
						IL_0145:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00de;
						end_IL_0040:;
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
				case 1:
				case 3:
					toolChainToolApi = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object MYALHasvRGPrSqkmyHXH(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NMGXmTsvuVNYkOcNUFfB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hc7FOFsvIuAici5NyR7c()
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
	private struct _003CAddTagAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<InSightTag> _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public string name;

		public string color;

		private TaskAwaiter<InSightTag> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uufDA6svnNakryqPeg1j();
			int num;
			if (wntmP5svahDH3uLjR8QI())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_01f5;
			IL_002a:
			InSightTag result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01f5;
			IL_01f5:
			int num2 = default;
			Guid guid = default;
			TaskAwaiter<InSightTag> awaiter = default;
			string text = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							guid = g3EBOOsvGdsgN6LUdeVV();
							uufDA6svnNakryqPeg1j();
							if (wntmP5svahDH3uLjR8QI())
							{
								num3 = 4;
								if (false)
								{
									goto IL_007a;
								}
							}
							else
							{
								num3 = 2;
								if (false)
								{
									goto IL_00f0;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 5;
						}
						goto IL_0095;
						IL_0095:
						while (true)
						{
							switch (num3)
							{
							case 6:
								break;
							default:
								num3 = 3;
								continue;
							case 0:
							case 4:
								text = guid.ToString();
								goto case 1;
							case 7:
								goto IL_00f0;
							case 3:
								goto IL_0106;
							case 8:
								return;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 1:
							case 2:
								awaiter = toolChainToolApi.MmlO49aunJ.PostAsync<InSightTag>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51402), new object[3] { text, name, color }).GetAwaiter();
								num3 = 7;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								goto IL_01b2;
							}
							break;
						}
						goto IL_007a;
						IL_0106:
						_003C_003Eu__1 = awaiter;
						num3 = 9;
						if (uufDA6svnNakryqPeg1j())
						{
						}
						goto IL_0095;
						IL_00f0:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							goto IL_0095;
						}
						goto IL_01b2;
						IL_01b2:
						result = awaiter.GetResult();
						goto end_IL_0051;
						IL_007a:
						num2 = (_003C_003E1__state = 0);
						goto IL_0106;
						end_IL_0051:;
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
					toolChainToolApi = _003C_003E4__this;
					goto case 2;
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
		internal static Guid g3EBOOsvGdsgN6LUdeVV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Guid.NewGuid();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wntmP5svahDH3uLjR8QI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uufDA6svnNakryqPeg1j()
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
	private struct _003CDeleteTagAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public string tagId;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!aiot4RsvXM2AY8qZ4n0i())
			{
				goto IL_001e;
			}
			goto IL_01c4;
			IL_001e:
			ToolChainToolApi toolChainToolApi = _003C_003E4__this;
			_ = 0;
			num = ((!aiot4RsvXM2AY8qZ4n0i()) ? 4 : 0);
			goto IL_01c4;
			IL_01c4:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.PostAsync<object>((string)Rwe11Ssv6kbjfTHQ8MuX(51424), new object[1] { tagId }).GetAwaiter();
							num3 = 5;
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
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							default:
								return;
							case 0:
								return;
							case 5:
								if (!awaiter.IsCompleted)
								{
									aiot4RsvXM2AY8qZ4n0i();
									num3 = ((!UKpLj6svb0iKdhEWmZHq()) ? 8 : 0);
									continue;
								}
								break;
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
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
		internal static object Rwe11Ssv6kbjfTHQ8MuX(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aiot4RsvXM2AY8qZ4n0i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UKpLj6svb0iKdhEWmZHq()
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
	private struct _003CUpdateTagAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<InSightTag> _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public string tagId;

		public string name;

		public string color;

		private TaskAwaiter<InSightTag> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (eB8ZLMsv0LLC07Z9jNP9() ? 3 : 5);
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			InSightTag result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					toolChainToolApi = _003C_003E4__this;
					num = 4;
					break;
				case 2:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					try
					{
						TaskAwaiter<InSightTag> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.PostAsync<InSightTag>((string)bdqqBRsv4rb0L5VaoxmG(51446), new object[3] { tagId, name, color }).GetAwaiter();
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (!N2855bsvpMGsX79sSx3e())
							{
								goto IL_019a;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								_ = 1;
								if (!eB8ZLMsv0LLC07Z9jNP9())
								{
									num3 = 7;
									continue;
								}
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 3:
								_003C_003Eu__1 = default;
								goto case 6;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 2:
								return;
							case 9:
								break;
							}
							break;
						}
						goto IL_019a;
						IL_019a:
						result = awaiter.GetResult();
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
		internal static object bdqqBRsv4rb0L5VaoxmG(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N2855bsvpMGsX79sSx3e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eB8ZLMsv0LLC07Z9jNP9()
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
	private struct _003CAddElementsToTagAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public string tagId;

		public string[] elementIds;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			miDnbgsvfpEl88Sf1klu();
			int num;
			if (RvEIEXsvk50q44BDrm7L())
			{
				num = 5;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01a9;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a9;
			IL_01a9:
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 3:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.PostAsync<object>((string)eZgDgCsvF2ANcpaniAF5(51468), new object[2] { tagId, elementIds }).GetAwaiter();
							_ = 1;
							if (!miDnbgsvfpEl88Sf1klu())
							{
								num3 = 3;
								if (false)
								{
									goto IL_0090;
								}
							}
							else
							{
								num3 = 4;
							}
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
							case 6:
								break;
							default:
								num3 = 1;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 1:
								return;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 0:
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_00b0;
							}
							goto IL_0090;
							continue;
							end_IL_00b0:
							break;
						}
						goto end_IL_003f;
						IL_0090:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_003f:;
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
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					toolChainToolApi = _003C_003E4__this;
					num = 3;
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
		internal static object eZgDgCsvF2ANcpaniAF5(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RvEIEXsvk50q44BDrm7L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool miDnbgsvfpEl88Sf1klu()
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
	private struct _003CRemoveElementsFromTagAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public string tagId;

		public string[] elementIds;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					Egstcvsvy8x4FJPx89fX();
					if (cy9YGEsvmmHgRIvvuLJe())
					{
						num = 4;
						if (true)
						{
							break;
						}
						goto case 1;
					}
					num = 5;
					break;
				case 1:
				case 4:
					toolChainToolApi = _003C_003E4__this;
					num = 2;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51500), new object[2] { tagId, elementIds }).GetAwaiter();
							_ = 1;
							if (!Egstcvsvy8x4FJPx89fX())
							{
								num3 = 6;
								if (!cy9YGEsvmmHgRIvvuLJe())
								{
									goto IL_00b6;
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
							num3 = 7;
							if (!cy9YGEsvmmHgRIvvuLJe())
							{
								goto IL_013d;
							}
						}
						goto IL_015d;
						IL_00b6:
						_003C_003Eu__1 = awaiter;
						num3 = 1;
						goto IL_015d;
						IL_015d:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (cy9YGEsvmmHgRIvvuLJe())
								{
									continue;
								}
								return;
							default:
								return;
							case 5:
								return;
							case 1:
								goto IL_013d;
							case 9:
								awaiter.GetResult();
								goto end_IL_0061;
							}
							break;
						}
						goto IL_00b6;
						IL_013d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0061:;
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
		internal static bool cy9YGEsvmmHgRIvvuLJe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Egstcvsvy8x4FJPx89fX()
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
	private struct _003CLoadToolChainAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public Stream toolchainArchive;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<Stream> awaiter2 = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
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
							if (num2 != 1)
							{
								num3 = 11;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 0;
								if (GnLlh5svZjggOyTNu3pX())
								{
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 10;
							if (!N0GioQsvggEATCCTSSPG())
							{
								goto IL_00bc;
							}
						}
						goto IL_01d6;
						IL_01d6:
						while (true)
						{
							switch (num3)
							{
							case 11:
								awaiter2 = toolChainToolApi.MmlO49aunJ.PostHttpAsync((string)TmELu9svJdmdaRPqN60r(51542), xfHOq7CTQ0, (string)TmELu9svJdmdaRPqN60r(49542), toolchainArchive).GetAwaiter();
								num3 = 5;
								if (N0GioQsvggEATCCTSSPG())
								{
									continue;
								}
								goto case 14;
							case 14:
								if (!awaiter.IsCompleted)
								{
									goto case 9;
								}
								goto case 16;
							case 6:
								return;
							case 2:
								break;
							case 3:
							case 7:
								awaiter = toolChainToolApi.PGfOaYge5E().GetAwaiter();
								num3 = 14;
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 6;
								continue;
							case 0:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 12;
								continue;
							case 9:
							case 15:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								continue;
							case 5:
								if (!awaiter2.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_01bc;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (!GnLlh5svZjggOyTNu3pX())
								{
									continue;
								}
								return;
							case 4:
								return;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								goto IL_01bc;
							default:
								_ = 1;
								if (GnLlh5svZjggOyTNu3pX())
								{
									num3 = 15;
									continue;
								}
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								{
									awaiter.GetResult();
									goto end_IL_01d6;
								}
								IL_01bc:
								awaiter2.GetResult();
								goto default;
							}
							goto IL_00bc;
							continue;
							end_IL_01d6:
							break;
						}
						goto end_IL_002d;
						IL_00bc:
						_003C_003Eu__2 = awaiter;
						num3 = 13;
						goto IL_01d6;
						end_IL_002d:;
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
					num2 = _003C_003E1__state;
					num = 4;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					break;
				case 6:
					return;
				}
				toolChainToolApi = _003C_003E4__this;
				_ = 1;
				num = ((!GnLlh5svZjggOyTNu3pX()) ? 5 : 0);
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
		internal static object TmELu9svJdmdaRPqN60r(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N0GioQsvggEATCCTSSPG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GnLlh5svZjggOyTNu3pX()
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
	private struct _003CLoadToolChainAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public byte[] toolchainArchive;

		public ToolChainToolApi _003C_003E4__this;

		private MemoryStream _003Cstream_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (BGZZIwsvzhFgoa5Yx6xo())
			{
				goto IL_001e;
			}
			goto IL_01d8;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01d8;
			IL_01d8:
			ToolChainToolApi toolChainToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 4:
					toolChainToolApi = _003C_003E4__this;
					goto case 0;
				case 0:
				case 2:
					try
					{
						if (num2 != 0)
						{
							_003Cstream_003E5__2 = new MemoryStream(toolchainArchive);
						}
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = IwfBrOsHw6eQXO0Jc72w(toolChainToolApi.LoadToolChainAsync(_003Cstream_003E5__2));
								num3 = 6;
								goto IL_00df;
							}
							awaiter = _003C_003Eu__1;
							goto IL_013a;
							IL_013a:
							_003C_003Eu__1 = default;
							num3 = 1;
							goto IL_00df;
							IL_00df:
							while (true)
							{
								switch (num3)
								{
								case 6:
									if (!awaiter.IsCompleted)
									{
										num3 = 0;
										if (avTaLDsv81hTKbd545jn())
										{
											continue;
										}
										goto case 0;
									}
									goto case 9;
								case 0:
									num2 = (_003C_003E1__state = 0);
									_ = 1;
									if (!BGZZIwsvzhFgoa5Yx6xo())
									{
										num3 = 3;
										continue;
									}
									num3 = 4;
									if (true)
									{
										continue;
									}
									goto case 9;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 8;
									continue;
								case 1:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 2:
								case 3:
									_003C_003Eu__1 = awaiter;
									num3 = 7;
									continue;
								case 4:
								case 5:
									break;
								case 8:
									return;
								case 9:
									awaiter.GetResult();
									goto end_IL_00df;
								}
								goto IL_013a;
								continue;
								end_IL_00df:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003Cstream_003E5__2 != null)
							{
								nrELngsHsjmpaeT4msgj(_003Cstream_003E5__2);
							}
						}
						_003Cstream_003E5__2 = null;
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
					continue;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (avTaLDsv81hTKbd545jn() ? 4 : 0);
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
		internal static TaskAwaiter IwfBrOsHw6eQXO0Jc72w(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nrELngsHsjmpaeT4msgj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool avTaLDsv81hTKbd545jn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BGZZIwsvzhFgoa5Yx6xo()
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
	private struct _003CClearToolChainAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 5;
								if (!LZU9qXsHhnqGDnQAd4Ce())
								{
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 13;
								if (1 == 0)
								{
									goto IL_01c9;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 2;
							if (MISYedsHL7JoWZjx3xHT())
							{
							}
						}
						goto IL_0142;
						IL_0142:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 2:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
							case 14:
								_003C_003Eu__2 = awaiter;
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								continue;
							case 5:
								awaiter2 = toolChainToolApi.MmlO49aunJ.PostAsync<object>((string)l3GxaMsH9lbgN3MUhFaW(51586), Array.Empty<object>()).GetAwaiter();
								num3 = 0;
								continue;
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 7:
								awaiter = FiK3XCsHSZdA5HQkgDSW(toolChainToolApi.PGfOaYge5E());
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (LZU9qXsHhnqGDnQAd4Ce())
									{
										num3 = 11;
										if (true)
										{
											continue;
										}
										goto case 1;
									}
									num3 = 14;
									continue;
								}
								goto case 16;
							case 1:
								awaiter2.GetResult();
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 0:
								if (!awaiter2.IsCompleted)
								{
									num3 = 6;
									if (LZU9qXsHhnqGDnQAd4Ce())
									{
										continue;
									}
									return;
								}
								goto case 1;
							case 15:
								return;
							case 13:
								break;
							case 8:
							case 11:
								num2 = (_003C_003E1__state = 1);
								goto case 9;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 10;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_0142;
							}
							goto IL_01c9;
							continue;
							end_IL_0142:
							break;
						}
						goto end_IL_0018;
						IL_01c9:
						_003C_003Eu__2 = default;
						num3 = 12;
						goto IL_0142;
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
				default:
					num = 0;
					continue;
				case 1:
				case 3:
					toolChainToolApi = _003C_003E4__this;
					goto case 2;
				case 5:
					num2 = _003C_003E1__state;
					LZU9qXsHhnqGDnQAd4Ce();
					num = ((!MISYedsHL7JoWZjx3xHT()) ? 3 : 4);
					continue;
				case 0:
					break;
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
		internal static object l3GxaMsH9lbgN3MUhFaW(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter FiK3XCsHSZdA5HQkgDSW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LZU9qXsHhnqGDnQAd4Ce()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MISYedsHL7JoWZjx3xHT()
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
	private struct _003CSetProjectInfoAsync_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public ProjectInfo projectInfo;

		private TaskAwaiter<ProjectInfo> _003C_003Eu__1;

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
			goto IL_01cb;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01cb;
			IL_01cb:
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					if (RXEjwPsHE1iYbm75Skl4())
					{
						num = 5;
						if (!avHkJDsHvPtPAyRxF10C())
						{
							continue;
						}
						goto case 1;
					}
					num = 3;
					continue;
				case 1:
				case 5:
					toolChainToolApi = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						TaskAwaiter<ProjectInfo> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.PutAsync<ProjectInfo>((string)PXGHDUsHH8o5qpcCyn1M(51618), projectInfo).GetAwaiter();
							num3 = 6;
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
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								avHkJDsHvPtPAyRxF10C();
								if (RXEjwPsHE1iYbm75Skl4())
								{
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 1;
								}
								num3 = 0;
								continue;
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 7:
								return;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (RXEjwPsHE1iYbm75Skl4())
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 0;
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
					break;
				default:
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
		internal static object PXGHDUsHH8o5qpcCyn1M(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RXEjwPsHE1iYbm75Skl4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool avHkJDsHvPtPAyRxF10C()
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
	private struct _003CGetProjectInfoAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ProjectInfo> _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<JObject> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			ProjectInfo result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter<JObject> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.GetAsync<JObject>((string)STbQifsHDNhAUQMVHmeZ(51618)).GetAwaiter();
							_ = 0;
							num3 = ((!Ci3ymHsHVIWdThHQIyfP()) ? 5 : 4);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						object obj;
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 4:
								if (awaiter.IsCompleted)
								{
									goto case 6;
								}
								goto case 1;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 6:
							{
								JObject result = awaiter.GetResult();
								if (result == null)
								{
									num3 = 10;
									continue;
								}
								obj = result.ToObject<ProjectInfo>();
								break;
							}
							case 7:
								return;
							case 1:
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 10:
								obj = null;
								break;
							}
							break;
						}
						result2 = (ProjectInfo)obj;
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
				case 3:
					num2 = _003C_003E1__state;
					Ci3ymHsHVIWdThHQIyfP();
					num = (H39FdesHA4H2AomZe6o4() ? 5 : 0);
					continue;
				case 0:
				case 1:
					toolChainToolApi = _003C_003E4__this;
					goto case 2;
				case 4:
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
		internal static object STbQifsHDNhAUQMVHmeZ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ci3ymHsHVIWdThHQIyfP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H39FdesHA4H2AomZe6o4()
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
	private struct _003CGetServerAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Server> _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter<JObject> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ToolChainToolApi toolChainToolApi = default;
			Server result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						TaskAwaiter<JObject> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = toolChainToolApi.MmlO49aunJ.GetAsync<JObject>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51676)).GetAwaiter();
							yyXTXYsHUZDC8rsQtgZF();
							num3 = (l1c4cLsHTON0wbhCkmRe() ? 9 : 6);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						object obj;
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
							{
								JObject result = awaiter.GetResult();
								if (result == null)
								{
									num3 = 10;
									continue;
								}
								obj = result.ToObject<Server>();
								break;
							}
							case 0:
							case 6:
								if (!awaiter.IsCompleted)
								{
									goto case 1;
								}
								goto case 4;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 5:
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 10:
								obj = null;
								break;
							}
							break;
						}
						result2 = (Server)obj;
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
					continue;
				case 1:
				case 4:
					toolChainToolApi = _003C_003E4__this;
					goto case 2;
				case 0:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 5:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				yyXTXYsHUZDC8rsQtgZF();
				if (l1c4cLsHTON0wbhCkmRe())
				{
					num = 3;
					continue;
				}
				num = 4;
				if (!yyXTXYsHUZDC8rsQtgZF())
				{
					break;
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
		internal static bool yyXTXYsHUZDC8rsQtgZF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l1c4cLsHTON0wbhCkmRe()
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
	private struct _003CSetServerAsync_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		public Server server;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ceGfWisHdesvkxp5Yqb6();
			int num;
			if (!GeLPD5sHicDKkQXGwe2s())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_020b;
				}
			}
			goto IL_01c1;
			IL_01c1:
			int num2 = default;
			JToken arg = default;
			ToolChainToolApi toolChainToolApi = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!GeLPD5sHicDKkQXGwe2s())
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							arg = toolChainToolApi.AKmOOcq5Oe(server);
							num3 = 7;
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
							case 3:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (GeLPD5sHicDKkQXGwe2s())
								{
								}
								continue;
							case 2:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								return;
							case 8:
								return;
							case 7:
								awaiter = toolChainToolApi.MmlO49aunJ.PutAsync<object>((string)YgMyQKsHqXDgNfweCDSu(51676), arg).GetAwaiter();
								num3 = 2;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 1;
								if (!GeLPD5sHicDKkQXGwe2s())
								{
									num3 = 9;
									if (ceGfWisHdesvkxp5Yqb6())
									{
										continue;
									}
									goto case 4;
								}
								num3 = 8;
								continue;
							case 4:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
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
					if (!GeLPD5sHicDKkQXGwe2s())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_020b;
			IL_020b:
			toolChainToolApi = _003C_003E4__this;
			num = 2;
			goto IL_01c1;
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
		internal static object YgMyQKsHqXDgNfweCDSu(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ceGfWisHdesvkxp5Yqb6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GeLPD5sHicDKkQXGwe2s()
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
	private struct _003CRaiseUpdatedEventAndUpdateAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ToolChainToolApi _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (zXcBfhsHBgrDI9g06WuL())
			{
				num = 2;
				if (!zXcBfhsHBgrDI9g06WuL())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_019b;
			IL_01ee:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_019b;
			IL_019b:
			ToolChainToolApi toolChainToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 4:
					toolChainToolApi = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				default:
					goto IL_01ee;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				int num3;
				if (num2 != 0)
				{
					EventHandler eventHandler = toolChainToolApi.zdQOB26kxl;
					if (eventHandler == null)
					{
						num3 = 5;
					}
					else
					{
						eventHandler(toolChainToolApi, EventArgs.Empty);
						num3 = 9;
						if (1 == 0)
						{
							goto IL_0124;
						}
					}
					goto IL_007e;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_00da;
				IL_0148:
				num2 = (_003C_003E1__state = -1);
				num3 = 10;
				goto IL_007e;
				IL_0124:
				if (!awaiter.IsCompleted)
				{
					_ = 1;
					if (TBr11lsHjgRPgL0Y45wI())
					{
						num3 = 4;
					}
					else
					{
						num3 = 2;
						if (false)
						{
							goto IL_0148;
						}
					}
					goto IL_007e;
				}
				goto IL_015b;
				IL_015b:
				awaiter.GetResult();
				goto end_IL_002a;
				IL_00da:
				_003C_003Eu__1 = default;
				num3 = 0;
				goto IL_007e;
				IL_007e:
				while (true)
				{
					switch (num3)
					{
					case 8:
						return;
					case 2:
					case 3:
						num2 = (_003C_003E1__state = 0);
						goto case 7;
					default:
						num3 = 7;
						if (0 == 0)
						{
							continue;
						}
						goto case 7;
					case 7:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						continue;
					case 4:
					case 6:
						break;
					case 5:
					case 9:
						do
						{
							awaiter = WZlaTmsHcEs9FuUwOgZX(toolChainToolApi.oWlObHe2a0());
							num3 = 1;
						}
						while (false);
						continue;
					case 1:
						goto IL_0124;
					case 0:
						goto IL_0148;
					case 10:
						goto IL_015b;
					}
					break;
				}
				goto IL_00da;
				end_IL_002a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ee;
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
		internal static TaskAwaiter WZlaTmsHcEs9FuUwOgZX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zXcBfhsHBgrDI9g06WuL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TBr11lsHjgRPgL0Y45wI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ResourceNode MmlO49aunJ;

	private bool gZKOlTwYDW;

	private long SWNOgfkSUW;

	private static readonly TimeSpan xfHOq7CTQ0;

	[CompilerGenerated]
	private EventHandler SrsOTLHqdK;

	[CompilerGenerated]
	private EventHandler zdQOB26kxl;

	public bool IsToolchainLoaded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gZKOlTwYDW;
		}
	}

	public long NumCollectedImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SWNOgfkSUW;
		}
	}

	public event EventHandler PropertiesUpdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					value2 = (EventHandler)OkIS82iBlvuyElwEeh2(eventHandler2, value);
					goto default;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 4;
				default:
					eventHandler = Interlocked.CompareExchange(ref SrsOTLHqdK, value2, eventHandler2);
					num = 6;
					if (IqPtE6iDsS2O7Y5d2hd())
					{
						break;
					}
					goto case 4;
				case 4:
					eventHandler2 = eventHandler;
					IqPtE6iDsS2O7Y5d2hd();
					if (Xm7jMGiUaMgWdL3ykw4())
					{
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 6;
					}
					num = 0;
					break;
				case 1:
					eventHandler = SrsOTLHqdK;
					num = 4;
					break;
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
			IqPtE6iDsS2O7Y5d2hd();
			int num;
			if (!Xm7jMGiUaMgWdL3ykw4())
			{
				num = 5;
				if (Xm7jMGiUaMgWdL3ykw4())
				{
				}
			}
			else
			{
				num = 2;
			}
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					goto case 3;
				default:
					num = 3;
					continue;
				case 0:
				case 5:
					eventHandler = SrsOTLHqdK;
					num = 1;
					continue;
				case 2:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					break;
				case 1:
					break;
				case 3:
					eventHandler = Interlocked.CompareExchange(ref SrsOTLHqdK, value2, eventHandler2);
					goto case 2;
				case 7:
					return;
				}
				eventHandler2 = eventHandler;
				num = 6;
			}
		}
	}

	public event EventHandler ToolChainUpdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IqPtE6iDsS2O7Y5d2hd();
			int num;
			if (!Xm7jMGiUaMgWdL3ykw4())
			{
				num = 6;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_004d;
				}
			}
			goto IL_0095;
			IL_004d:
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			if ((object)eventHandler != eventHandler2)
			{
				goto IL_0028;
			}
			num = 7;
			goto IL_0095;
			IL_0028:
			eventHandler2 = eventHandler;
			num = 4;
			goto IL_0095;
			IL_0095:
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 0:
				case 6:
					eventHandler = zdQOB26kxl;
					break;
				case 2:
					goto IL_004d;
				case 5:
					eventHandler = Interlocked.CompareExchange(ref zdQOB26kxl, value2, eventHandler2);
					num = 2;
					continue;
				case 4:
					value2 = (EventHandler)OkIS82iBlvuyElwEeh2(eventHandler2, value);
					goto case 5;
				default:
					num = 5;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0028;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!IqPtE6iDsS2O7Y5d2hd()) ? 5 : 3);
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					value2 = (EventHandler)W1LsZwijFK1B4JZunje(eventHandler2, value);
					goto case 6;
				default:
					num = 6;
					break;
				case 6:
					eventHandler = Interlocked.CompareExchange(ref zdQOB26kxl, value2, eventHandler2);
					num = 1;
					break;
				case 1:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 4;
				case 4:
					eventHandler2 = eventHandler;
					goto case 2;
				case 0:
				case 3:
					eventHandler = zdQOB26kxl;
					num = 4;
					break;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ToolChainToolApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Xm7jMGiUaMgWdL3ykw4())
		{
			num = 3;
			if (Xm7jMGiUaMgWdL3ykw4())
			{
			}
		}
		else
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				shv5ohiTS2nfyWwaD0n();
				num = 1;
				if (!Xm7jMGiUaMgWdL3ykw4())
				{
					continue;
				}
				break;
			case 1:
				xfHOq7CTQ0 = yfaOhTH6er();
				break;
			case 5:
				return;
			}
			jVYcyZid1DobVD4eYmp();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolChainToolApi(ResourceNode parentNode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0051;
		IL_001a:
		shv5ohiTS2nfyWwaD0n();
		IqPtE6iDsS2O7Y5d2hd();
		num = (Xm7jMGiUaMgWdL3ykw4() ? 3 : 0);
		goto IL_0051;
		IL_0051:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 1:
				Kb2MnUiiaoYNMYfkcvL(this);
				goto IL_007e;
			default:
				goto IL_007e;
			case 5:
				return;
			}
			break;
			IL_007e:
			MmlO49aunJ = parentNode;
			num = 5;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__8))]
	public Task InitializeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!Xm7jMGiUaMgWdL3ykw4())
		{
		}
		_003CInitializeAsync_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				_ = 0;
				num = ((!IqPtE6iDsS2O7Y5d2hd()) ? 4 : 0);
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdatePropertiesAsync_003Ed__19))]
	private Task oWlObHe2a0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CUpdatePropertiesAsync_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (IqPtE6iDsS2O7Y5d2hd())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				Xm7jMGiUaMgWdL3ykw4();
				num = ((!IqPtE6iDsS2O7Y5d2hd()) ? 2 : 0);
				continue;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateNumImages_003Ed__20))]
	public Task UpdateNumImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (IqPtE6iDsS2O7Y5d2hd())
		{
			num = 2;
			if (!IqPtE6iDsS2O7Y5d2hd())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_006e;
		IL_002a:
		_003CUpdateNumImages_003Ed__20 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 3;
		goto IL_006e;
		IL_006e:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (IqPtE6iDsS2O7Y5d2hd())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImageMetadataAsync_003Ed__21))]
	public Task<ImageMetadata[]> GetImageMetadataAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImageMetadataAsync_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageMetadata[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImageStreamAsync_003Ed__22))]
	public Task<Stream> GetImageStreamAsync(string id)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImageStreamAsync_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.id = id;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetThumbnailImageAsync_003Ed__23))]
	public Task<Bitmap> GetThumbnailImageAsync(string id)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetThumbnailImageAsync_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.id = id;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClearImageAsync_003Ed__24))]
	public Task ClearImageAsync(string imageId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (IqPtE6iDsS2O7Y5d2hd() ? 1 : 3);
		_003CClearImageAsync_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (!Xm7jMGiUaMgWdL3ykw4())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 5:
				stateMachine.imageId = imageId;
				goto case 6;
			default:
				num = 6;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClearImagesAsync_003Ed__25))]
	public Task ClearImagesAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Xm7jMGiUaMgWdL3ykw4();
		int num = ((!IqPtE6iDsS2O7Y5d2hd()) ? 5 : 2);
		_003CClearImagesAsync_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (Xm7jMGiUaMgWdL3ykw4())
				{
				}
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCollectCurrentImageAsync_003Ed__26))]
	public Task CollectCurrentImageAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CCollectCurrentImageAsync_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 4;
				if (IqPtE6iDsS2O7Y5d2hd())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003E4__this = this;
				Xm7jMGiUaMgWdL3ykw4();
				num = ((!IqPtE6iDsS2O7Y5d2hd()) ? 5 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetTagsAsync_003Ed__27))]
	public Task<InSightTag[]> GetTagsAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetTagsAsync_003Ed__27 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<InSightTag[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTagAsync_003Ed__28))]
	public Task<InSightTag> AddTagAsync(string name, string color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTagAsync_003Ed__28 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<InSightTag>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.name = name;
		stateMachine.color = color;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteTagAsync_003Ed__29))]
	public Task DeleteTagAsync(string tagId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (Xm7jMGiUaMgWdL3ykw4())
		{
			goto IL_001e;
		}
		goto IL_006c;
		IL_001e:
		_003CDeleteTagAsync_003Ed__29 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_00ab;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				break;
			case 1:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 0;
				continue;
			case 5:
				stateMachine.tagId = tagId;
				goto default;
			default:
				Xm7jMGiUaMgWdL3ykw4();
				if (!IqPtE6iDsS2O7Y5d2hd())
				{
					num = 2;
					if (IqPtE6iDsS2O7Y5d2hd())
					{
						continue;
					}
					goto case 1;
				}
				num = 6;
				continue;
			case 2:
			case 4:
				goto IL_00ab;
			case 0:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_00ab:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateTagAsync_003Ed__30))]
	public Task<InSightTag> UpdateTagAsync(string tagId, string name, string color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CUpdateTagAsync_003Ed__30 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<InSightTag>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.tagId = tagId;
		stateMachine.name = name;
		stateMachine.color = color;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddElementsToTagAsync_003Ed__31))]
	public Task AddElementsToTagAsync(string tagId, string[] elementIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (IqPtE6iDsS2O7Y5d2hd())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (Xm7jMGiUaMgWdL3ykw4())
			{
				goto IL_00db;
			}
		}
		goto IL_0084;
		IL_00db:
		_003CAddElementsToTagAsync_003Ed__31 stateMachine = default;
		stateMachine.tagId = tagId;
		num = 7;
		if (0 == 0)
		{
			goto IL_0084;
		}
		goto IL_00ef;
		IL_00ef:
		return stateMachine._003C_003Et__builder.Task;
		IL_0084:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (IqPtE6iDsS2O7Y5d2hd())
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 1;
				continue;
			case 7:
				stateMachine.elementIds = elementIds;
				goto case 6;
			default:
				num = 6;
				if (!Xm7jMGiUaMgWdL3ykw4())
				{
					continue;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 3:
				break;
			case 8:
				goto IL_00ef;
			}
			break;
		}
		goto IL_00db;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveElementsFromTagAsync_003Ed__32))]
	public Task RemoveElementsFromTagAsync(string tagId, string[] elementIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IqPtE6iDsS2O7Y5d2hd();
		int num = (Xm7jMGiUaMgWdL3ykw4() ? 3 : 4);
		_003CRemoveElementsFromTagAsync_003Ed__32 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 1;
				if (Xm7jMGiUaMgWdL3ykw4())
				{
				}
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 7:
				stateMachine.elementIds = elementIds;
				goto case 6;
			default:
				num = 6;
				break;
			case 2:
			case 3:
				stateMachine.tagId = tagId;
				num = 7;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadToolChainAsync_003Ed__33))]
	public Task LoadToolChainAsync(Stream toolchainArchive)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CLoadToolChainAsync_003Ed__33 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (Xm7jMGiUaMgWdL3ykw4() ? 5 : 6);
				break;
			case 1:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 0;
				break;
			case 2:
			case 6:
				stateMachine.toolchainArchive = toolchainArchive;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadToolChainAsync_003Ed__34))]
	public Task LoadToolChainAsync(byte[] toolchainArchive)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IqPtE6iDsS2O7Y5d2hd();
		int num = (Xm7jMGiUaMgWdL3ykw4() ? 3 : 4);
		_003CLoadToolChainAsync_003Ed__34 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine.toolchainArchive = toolchainArchive;
				goto case 1;
			default:
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				continue;
			case 6:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 6;
				if (IqPtE6iDsS2O7Y5d2hd())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClearToolChainAsync_003Ed__35))]
	public Task ClearToolChainAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IqPtE6iDsS2O7Y5d2hd();
		int num;
		if (!Xm7jMGiUaMgWdL3ykw4())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0044;
		IL_0095:
		_003CClearToolChainAsync_003Ed__35 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (0 == 0)
		{
			goto IL_0044;
		}
		goto IL_00af;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 5;
				if (Xm7jMGiUaMgWdL3ykw4())
				{
				}
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				goto IL_00af;
			case 5:
				goto IL_0095;
			case 1:
			case 4:
				goto IL_00af;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_0095;
		IL_00af:
		stateMachine._003C_003E4__this = this;
		num = 3;
		goto IL_0044;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetProjectInfoAsync_003Ed__36))]
	public Task SetProjectInfoAsync(ProjectInfo projectInfo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CSetProjectInfoAsync_003Ed__36 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine.projectInfo = projectInfo;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				break;
			case 0:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				Xm7jMGiUaMgWdL3ykw4();
				num = (IqPtE6iDsS2O7Y5d2hd() ? 4 : 6);
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetProjectInfoAsync_003Ed__37))]
	public Task<ProjectInfo> GetProjectInfoAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetProjectInfoAsync_003Ed__37 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ProjectInfo>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetServerAsync_003Ed__38))]
	public Task<Server> GetServerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetServerAsync_003Ed__38 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Server>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetServerAsync_003Ed__39))]
	public Task SetServerAsync(Server server)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IqPtE6iDsS2O7Y5d2hd();
		int num = (Xm7jMGiUaMgWdL3ykw4() ? 6 : 2);
		_003CSetServerAsync_003Ed__39 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
				num = 4;
				if (Xm7jMGiUaMgWdL3ykw4())
				{
				}
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 5:
				stateMachine.server = server;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRaiseUpdatedEventAndUpdateAsync_003Ed__40))]
	private Task PGfOaYge5E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Xm7jMGiUaMgWdL3ykw4())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_005c;
		IL_0087:
		_003CRaiseUpdatedEventAndUpdateAsync_003Ed__40 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 2;
		goto IL_005c;
		IL_005c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				continue;
			case 1:
			case 5:
				goto IL_0087;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		stateMachine._003C_003Et__builder = APTR1ZiqrODt9cVNsbA();
		goto IL_0087;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private JToken AKmOOcq5Oe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JsonSerializer jsonSerializer = new JsonSerializer
		{
			TypeNameHandling = TypeNameHandling.None
		};
		return (JToken)tCRbEwicC87BhKGk42J(P_0, jsonSerializer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void F2rOpefKSW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 4:
				((TypeNameBinder)SxOnWki2CZgVU2Lyjdd()).Register((string)NfvHhdiWK68pyHhyIpi(12104), KQN5jMi7BNV6QKuYMgx(typeof(ImageMetadata).TypeHandle));
				IqPtE6iDsS2O7Y5d2hd();
				num = ((!Xm7jMGiUaMgWdL3ykw4()) ? 3 : 0);
				break;
			case 5:
				pGGykIitKOIIF2XJSNT(SxOnWki2CZgVU2Lyjdd(), kgbOBx7BanbFa22Hp9.ol99ukmDA(12234), typeof(Server));
				num = 6;
				if (IqPtE6iDsS2O7Y5d2hd())
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				pGGykIitKOIIF2XJSNT(SxOnWki2CZgVU2Lyjdd(), kgbOBx7BanbFa22Hp9.ol99ukmDA(12190), KQN5jMi7BNV6QKuYMgx(typeof(ProjectInfo).TypeHandle));
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 3:
				pGGykIitKOIIF2XJSNT(SxOnWki2CZgVU2Lyjdd(), NfvHhdiWK68pyHhyIpi(12152), KQN5jMi7BNV6QKuYMgx(typeof(InSightTag).TypeHandle));
				goto case 0;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static TimeSpan yfaOhTH6er()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (AppConfiguration.TryGet<int>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12276), out var value) && value >= 0)
		{
			return TimeSpan.FromSeconds(value);
		}
		return TgyUaViCl65TnlqTN9w(1.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void shv5ohiTS2nfyWwaD0n()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jVYcyZid1DobVD4eYmp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		F2rOpefKSW();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IqPtE6iDsS2O7Y5d2hd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xm7jMGiUaMgWdL3ykw4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Kb2MnUiiaoYNMYfkcvL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder APTR1ZiqrODt9cVNsbA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OkIS82iBlvuyElwEeh2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W1LsZwijFK1B4JZunje(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tCRbEwicC87BhKGk42J(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JToken.FromObject(P_0, (JsonSerializer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SxOnWki2CZgVU2Lyjdd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JsonRemoteSerializer.TypeNameBinder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NfvHhdiWK68pyHhyIpi(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type KQN5jMi7BNV6QKuYMgx(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pGGykIitKOIIF2XJSNT(object P_0, object P_1, Type P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TypeNameBinder)P_0).Register((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan TgyUaViCl65TnlqTN9w(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TimeSpan.FromMinutes(P_0);
	}
}
