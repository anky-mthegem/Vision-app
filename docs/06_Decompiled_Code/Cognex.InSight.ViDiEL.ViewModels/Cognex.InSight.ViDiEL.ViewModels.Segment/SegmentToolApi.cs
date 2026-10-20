using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.ViDiEL;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Segment;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Segment;

public class SegmentToolApi
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddClass_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		public ELSegmenterClass segmenterClass;

		private TaskAwaiter<long> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OLhwYb3yrPaV0s6R3G4();
			int num = (bYmgvN3nTMWiDoZeQkW() ? 3 : 4);
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			int result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter<long> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.PostAsync<long>((string)yUwdd13fgtVGRabnOTO(7014), new object[1] { segmenterClass }).GetAwaiter();
							bYmgvN3nTMWiDoZeQkW();
							num3 = ((!OLhwYb3yrPaV0s6R3G4()) ? 7 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (1 == 0)
							{
								goto IL_0111;
							}
						}
						goto IL_00a7;
						IL_00a7:
						while (true)
						{
							switch (num3)
							{
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 6:
								return;
							case 8:
								break;
							case 0:
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 9:
								result = (int)awaiter.GetResult();
								goto end_IL_00a7;
							}
							goto IL_0111;
							continue;
							end_IL_00a7:
							break;
						}
						goto end_IL_0028;
						IL_0111:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_00a7;
						end_IL_0028:;
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
					segmentToolApi = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
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
		internal static object yUwdd13fgtVGRabnOTO(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OLhwYb3yrPaV0s6R3G4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bYmgvN3nTMWiDoZeQkW()
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
	private struct _003CEditClass_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		public ELSegmenterClass segmenterClass;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!UlC54w3z29I4mTCoLYh()) ? 5 : 4);
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 3:
					segmentToolApi = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.PostAsync<object>((string)Hb1HyqaXpnUJDlqSVW2(7034), new object[1] { segmenterClass }).GetAwaiter();
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 0;
							num3 = ((!UlC54w3z29I4mTCoLYh()) ? 1 : 4);
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 4:
							case 5:
								_003C_003Eu__1 = default;
								goto case 1;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
								return;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								break;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
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
					goto case 1;
				default:
					num = 1;
					if (!UlC54w3z29I4mTCoLYh())
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
		internal static object Hb1HyqaXpnUJDlqSVW2(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UlC54w3z29I4mTCoLYh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MRgFfma2K8ehwOkTVfQ()
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
	private struct _003CGetClasses_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELSegmenterClass[]> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<ELSegmenterClass[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!CHnpjgaMN2DVNQ93jDb()) ? 3 : 4);
			ELSegmenterClass[] result = default;
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 2:
					try
					{
						TaskAwaiter<ELSegmenterClass[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.GetAsync<ELSegmenterClass[]>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7056)).GetAwaiter();
							num3 = 0;
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
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 7:
								_003C_003Eu__1 = default;
								goto case 1;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (CHnpjgaMN2DVNQ93jDb())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								S3r1DlaklSv1HqMgAlt();
								if (!CHnpjgaMN2DVNQ93jDb())
								{
									num3 = 1;
									if (!S3r1DlaklSv1HqMgAlt())
									{
										continue;
									}
									goto case 1;
								}
								num3 = 2;
								continue;
							case 2:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 5:
								return;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				segmentToolApi = _003C_003E4__this;
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
		internal static bool CHnpjgaMN2DVNQ93jDb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S3r1DlaklSv1HqMgAlt()
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
	private struct _003CDeleteClass_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		public int classId;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (qtVwF9arbkmoxjZ5eyy())
			{
				goto IL_001e;
			}
			goto IL_01cd;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 0;
			goto IL_01cd;
			IL_01cd:
			SegmentToolApi segmentToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
					segmentToolApi = _003C_003E4__this;
					_ = 0;
					if (LiwWUvamJ9syWKCKhR1())
					{
						num = 5;
						if (0 == 0)
						{
							continue;
						}
						goto default;
					}
					num = 1;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.PostAsync<object>((string)BV50A8aPxglgwUyOnsR(7074), new object[1] { classId }).GetAwaiter();
							num3 = 4;
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
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								if (true)
								{
									continue;
								}
								return;
							case 0:
								return;
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								qtVwF9arbkmoxjZ5eyy();
								if (!LiwWUvamJ9syWKCKhR1())
								{
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								}
								num3 = 6;
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
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
		internal static object BV50A8aPxglgwUyOnsR(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LiwWUvamJ9syWKCKhR1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qtVwF9arbkmoxjZ5eyy()
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
	private struct _003CGetModelStats_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELSegmenterModelStats> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<ELSegmenterModelStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			ELSegmenterModelStats result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						TaskAwaiter<ELSegmenterModelStats> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.GetAsync<ELSegmenterModelStats>((string)s7pCyma1MiimTmtcvsF(7100)).GetAwaiter();
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (1 == 0)
							{
								goto IL_005b;
							}
						}
						goto IL_00df;
						IL_005b:
						_003C_003Eu__1 = default;
						goto IL_0099;
						IL_0099:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00df;
						IL_00df:
						while (true)
						{
							switch (num3)
							{
							case 4:
							case 8:
								return;
							case 2:
								break;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (UODc6wa4sQ0vqFiEI0s())
									{
										continue;
									}
									goto IL_0099;
								}
								goto case 9;
							case 3:
							case 6:
								goto IL_0099;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								UODc6wa4sQ0vqFiEI0s();
								if (sjxtdWagiGEdP3uc8mp())
								{
									num3 = 3;
									if (!sjxtdWagiGEdP3uc8mp())
									{
										continue;
									}
									goto case 1;
								}
								num3 = 8;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_0018;
							}
							break;
						}
						goto IL_005b;
						end_IL_0018:;
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
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					segmentToolApi = _003C_003E4__this;
					UODc6wa4sQ0vqFiEI0s();
					num = (sjxtdWagiGEdP3uc8mp() ? 5 : 0);
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
		internal static object s7pCyma1MiimTmtcvsF(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UODc6wa4sQ0vqFiEI0s()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sjxtdWagiGEdP3uc8mp()
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
	private struct _003CGetInferenceSize_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Size> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<CogSize> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			Size result2 = default;
			CogSize result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					CRlKKpa6NEXtyeRj2dU();
					if (rJ4C8qaSsZAWcn17Nl5())
					{
						num = 2;
						if (true)
						{
							break;
						}
						goto case 1;
					}
					num = 5;
					break;
				case 1:
				case 2:
					segmentToolApi = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 4:
					try
					{
						try
						{
							TaskAwaiter<CogSize> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = segmentToolApi.ToolNode.GetAsync<CogSize>((string)yoXPvGaD6n1nbvC3A7P(7124)).GetAwaiter();
								num3 = 9;
								if (1 == 0)
								{
									goto IL_0093;
								}
								goto IL_0112;
							}
							awaiter = _003C_003Eu__1;
							goto IL_0153;
							IL_0112:
							while (true)
							{
								switch (num3)
								{
								case 0:
									break;
								case 2:
									result = awaiter.GetResult();
									num3 = 0;
									continue;
								case 9:
									if (awaiter.IsCompleted)
									{
										goto case 2;
									}
									goto IL_00c7;
								case 10:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									continue;
								case 4:
									return;
								default:
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto IL_0153;
								case 7:
									goto IL_0153;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto IL_018c;
								case 6:
								case 8:
									goto IL_018c;
								case 1:
								case 5:
									num2 = (_003C_003E1__state = 0);
									num3 = 10;
									continue;
								case 11:
									goto end_IL_0065;
								}
								break;
								IL_00c7:
								CRlKKpa6NEXtyeRj2dU();
								num3 = (rJ4C8qaSsZAWcn17Nl5() ? 5 : 6);
							}
							goto IL_0093;
							IL_018c:
							result2 = new Size(0, 0);
							num3 = 11;
							goto IL_0112;
							IL_0093:
							if (result == null)
							{
								goto IL_018c;
							}
							result2 = new Size((int)n3EKPHa8L3h7OeFKceG(result), (int)zQUVnaaFLgM3lhVEOlj(result));
							goto end_IL_0065;
							IL_0153:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 2;
							goto IL_0112;
							end_IL_0065:;
						}
						catch
						{
							result2 = new Size(0, 0);
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
		internal static object yoXPvGaD6n1nbvC3A7P(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double n3EKPHa8L3h7OeFKceG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CogSize)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double zQUVnaaFLgM3lhVEOlj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CogSize)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rJ4C8qaSsZAWcn17Nl5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CRlKKpa6NEXtyeRj2dU()
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
	private struct _003CGetFixedRoiSize_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Size> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<CogSize> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (RZ6sKDadGr9QCtM1DIU() ? 2 : 3);
			int num2 = default;
			Size result = default;
			SegmentToolApi segmentToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (SEXwKeasePoYl5mccZG())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					segmentToolApi = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						try
						{
							TaskAwaiter<CogSize> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = segmentToolApi.ToolNode.GetAsync<CogSize>((string)BTC89qaESJh36Kj7hZW(7154)).GetAwaiter();
								num3 = 7;
								goto IL_00b6;
							}
							awaiter = _003C_003Eu__1;
							goto IL_00eb;
							IL_013f:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 9;
							if (true)
							{
								goto IL_00b6;
							}
							goto IL_0159;
							IL_0159:
							num2 = (_003C_003E1__state = 0);
							num3 = 1;
							goto IL_00b6;
							IL_00b6:
							while (true)
							{
								switch (num3)
								{
								case 9:
									return;
								case 7:
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										if (SEXwKeasePoYl5mccZG())
										{
											continue;
										}
										goto case 5;
									}
									goto IL_01a3;
								case 5:
								case 8:
									_003C_003Eu__1 = default;
									goto case 6;
								case 4:
									goto IL_013f;
								case 2:
									goto IL_0159;
								case 1:
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									continue;
								case 0:
									result = new Size(0, 0);
									num3 = 11;
									continue;
								case 6:
								case 10:
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									continue;
								case 3:
									goto IL_01a3;
								case 11:
									goto end_IL_006b;
								}
								break;
								IL_01a3:
								CogSize result2 = awaiter.GetResult();
								if (result2 == null)
								{
									num3 = 0;
									continue;
								}
								result = new Size((int)PZ5HK5a5V8fD7Y2bB7f(result2.Width, MidpointRounding.AwayFromZero), (int)PZ5HK5a5V8fD7Y2bB7f(l9aZC5a3or2bX768L8B(result2), MidpointRounding.AwayFromZero));
								goto end_IL_006b;
							}
							goto IL_00eb;
							IL_00eb:
							_ = 1;
							if (!RZ6sKDadGr9QCtM1DIU())
							{
								num3 = 8;
							}
							else
							{
								num3 = 10;
								if (RZ6sKDadGr9QCtM1DIU())
								{
									goto IL_013f;
								}
							}
							goto IL_00b6;
							end_IL_006b:;
						}
						catch
						{
							result = new Size(0, 0);
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
					if (false)
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
		internal static object BTC89qaESJh36Kj7hZW(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double PZ5HK5a5V8fD7Y2bB7f(double P_0, MidpointRounding P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Round(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double l9aZC5a3or2bX768L8B(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CogSize)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SEXwKeasePoYl5mccZG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RZ6sKDadGr9QCtM1DIU()
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
	private struct _003CGetSamples_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELSegmenterSample[]> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<ELSegmenterSample[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ELSegmenterSample[] result = default;
			SegmentToolApi segmentToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					Dj4PrQao5J1nUO5tTZI();
					num = ((!ARDx3yaa9olZo7ZUT8J()) ? 3 : 4);
					break;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						TaskAwaiter<ELSegmenterSample[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.GetAsync<ELSegmenterSample[]>((string)sEgIcNacJWXhm00SphV(7182)).GetAwaiter();
							num3 = 8;
							if (!ARDx3yaa9olZo7ZUT8J())
							{
								goto IL_0080;
							}
							goto IL_00fa;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0150;
						IL_0150:
						_003C_003Eu__1 = default;
						num3 = 7;
						if (ARDx3yaa9olZo7ZUT8J())
						{
							goto IL_00fa;
						}
						goto IL_016c;
						IL_016c:
						result = awaiter.GetResult();
						goto end_IL_004f;
						IL_0080:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00fa;
						IL_00fa:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 1:
								return;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									if (true)
									{
										continue;
									}
									goto case 0;
								}
								goto IL_016c;
							case 0:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								if (Dj4PrQao5J1nUO5tTZI())
								{
									num3 = 3;
									if (true)
									{
										continue;
									}
									goto case 8;
								}
								num3 = 0;
								continue;
							case 3:
							case 5:
								goto IL_0150;
							case 9:
								goto IL_016c;
							}
							break;
						}
						goto IL_0080;
						end_IL_004f:;
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
				case 4:
					segmentToolApi = _003C_003E4__this;
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
		internal static object sEgIcNacJWXhm00SphV(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ARDx3yaa9olZo7ZUT8J()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dj4PrQao5J1nUO5tTZI()
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
	private struct _003CDeleteSamples_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		public ICollection<string> sampleIds;

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
			SegmentToolApi segmentToolApi = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.PostAsync<object>((string)Oo2BWpaxRACZi4Xms2S(7200), new object[1] { sampleIds }).GetAwaiter();
							num3 = 8;
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
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 2:
								return;
							case 7:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								if (!CACmMDaBgKWhslihA7x())
								{
									num3 = 4;
									if (M8cWQXaup0NbQRK6rYG())
									{
										continue;
									}
									goto case 8;
								}
								num3 = 1;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							case 5:
								_003C_003Eu__1 = default;
								goto case 1;
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
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					segmentToolApi = _003C_003E4__this;
					_ = 0;
					num = (M8cWQXaup0NbQRK6rYG() ? 1 : 5);
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
		internal static object Oo2BWpaxRACZi4Xms2S(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M8cWQXaup0NbQRK6rYG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CACmMDaBgKWhslihA7x()
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
	private struct _003CLabelCurrentImage_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Bitmap maskImage;

		public SegmentToolApi _003C_003E4__this;

		private MemoryStream _003CdataStream_003E5__2;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			string result = default;
			int num2 = default;
			TaskAwaiter<Stream> awaiter = default;
			SegmentToolApi segmentToolApi = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					try
					{
						Stream stream;
						if (num2 != 0)
						{
							stream = null;
							_003CdataStream_003E5__2 = new MemoryStream();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								bu4O8qaQ8Uh0RVjkO57(maskImage, _003CdataStream_003E5__2, ImageFormat.Bmp);
								bjVJcDaUKtyTcw7ZrSr();
								if (NGLmVKahijlJELVQkgE())
								{
									num3 = 1;
								}
								else
								{
									num3 = 5;
									if (!NGLmVKahijlJELVQkgE())
									{
										goto IL_0192;
									}
								}
								goto IL_0095;
							}
							awaiter = _003C_003Eu__1;
							goto IL_0123;
							IL_0095:
							while (true)
							{
								switch (num3)
								{
								case 3:
									num2 = (_003C_003E1__state = 0);
									goto case 6;
								default:
									num3 = 6;
									continue;
								case 6:
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									if (NGLmVKahijlJELVQkgE())
									{
										continue;
									}
									goto case 9;
								case 9:
									awaiter = segmentToolApi.ToolNode.PostHttpAsync(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7230), YEFDwAaVsDE0CUfI8aX(), (string)sMC6oxai37rvTkT7GFJ(7268), _003CdataStream_003E5__2).GetAwaiter();
									num3 = 2;
									continue;
								case 5:
								case 7:
									break;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 10;
								case 0:
								case 1:
									XLxQrUaqlutME3h64ih(_003CdataStream_003E5__2, 0L);
									num3 = 9;
									continue;
								case 8:
									return;
								case 4:
									goto IL_0192;
								case 10:
									stream = awaiter.GetResult();
									goto end_IL_0044;
								}
								break;
							}
							goto IL_0123;
							IL_0192:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 8;
							goto IL_0095;
							IL_0123:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 10;
							goto IL_0095;
							end_IL_0044:;
						}
						finally
						{
							if (num2 < 0 && _003CdataStream_003E5__2 != null)
							{
								((IDisposable)_003CdataStream_003E5__2).Dispose();
							}
						}
						_003CdataStream_003E5__2 = null;
						result = new StreamReader(stream).ReadToEnd();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (bjVJcDaUKtyTcw7ZrSr() ? 5 : 0);
					break;
				case 0:
				case 1:
					segmentToolApi = _003C_003E4__this;
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
		internal static void bu4O8qaQ8Uh0RVjkO57(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Image)P_0).Save((Stream)P_1, (ImageFormat)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XLxQrUaqlutME3h64ih(object P_0, long P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Position = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan YEFDwAaVsDE0CUfI8aX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCogSocketAcq.HttpImageTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sMC6oxai37rvTkT7GFJ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NGLmVKahijlJELVQkgE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bjVJcDaUKtyTcw7ZrSr()
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
	private struct _003CLabelImage_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Bitmap maskImage;

		public SegmentToolApi _003C_003E4__this;

		public string sampleId;

		private MemoryStream _003CdataStream_003E5__2;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ONoWGeatyNkNfBtlA5T();
			int num;
			if (dWvZ2HaLM2igP2E1rS7())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_0052;
				}
			}
			goto IL_0236;
			IL_0263:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (ONoWGeatyNkNfBtlA5T())
			{
				return;
			}
			goto IL_0236;
			IL_0052:
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			try
			{
				if (num2 != 0)
				{
					_003CdataStream_003E5__2 = new MemoryStream();
				}
				try
				{
					int num3;
					TaskAwaiter<Stream> awaiter = default;
					if (num2 != 0)
					{
						bSHFAPa92mMI67LmAfd(maskImage, _003CdataStream_003E5__2, ImageFormat.Bmp);
						ONoWGeatyNkNfBtlA5T();
						num3 = ((!dWvZ2HaLM2igP2E1rS7()) ? 8 : 3);
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
						case 5:
						case 8:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 7;
							continue;
						case 4:
							_003C_003Eu__1 = awaiter;
							goto case 5;
						case 1:
							if (!awaiter.IsCompleted)
							{
								num3 = 9;
								continue;
							}
							break;
						case 7:
							return;
						case 6:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 10;
							continue;
						case 2:
							awaiter = segmentToolApi.ToolNode.PostHttpAsync(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7290), A7kwxwaZnLXEQpASUaY(), (string)qP6AjDa0iWke5pBJWh4(7268), _003CdataStream_003E5__2, 0, sampleId).GetAwaiter();
							num3 = 1;
							continue;
						case 9:
							num2 = (_003C_003E1__state = 0);
							goto case 4;
						default:
							num3 = 4;
							continue;
						case 0:
						case 3:
							veSeTwavl5lhFVPGHFo(_003CdataStream_003E5__2, 0L);
							num3 = 2;
							continue;
						case 10:
							break;
						}
						break;
					}
					awaiter.GetResult();
				}
				finally
				{
					if (num2 < 0 && _003CdataStream_003E5__2 != null)
					{
						((IDisposable)_003CdataStream_003E5__2).Dispose();
					}
				}
				_003CdataStream_003E5__2 = null;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0263;
			IL_0236:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					segmentToolApi = _003C_003E4__this;
					num = 3;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					goto IL_0263;
				case 5:
					goto IL_0263;
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
		internal static void bSHFAPa92mMI67LmAfd(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Image)P_0).Save((Stream)P_1, (ImageFormat)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void veSeTwavl5lhFVPGHFo(object P_0, long P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Position = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan A7kwxwaZnLXEQpASUaY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCogSocketAcq.HttpImageTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qP6AjDa0iWke5pBJWh4(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dWvZ2HaLM2igP2E1rS7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ONoWGeatyNkNfBtlA5T()
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
	private struct _003CGetTunableProjectionParameters_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELTunableProjectionParams> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!kJVZn4aH0HNLVjI1oDF())
			{
			}
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			ELTunableProjectionParams result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter<ELTunableProjectionParams> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.GetAsync<ELTunableProjectionParams>((string)fXRDl0aTKS9OWhc5yyr(7314)).GetAwaiter();
							kJVZn4aH0HNLVjI1oDF();
							num3 = ((!WSAgQyaOkuwvNhtmg0s()) ? 5 : 4);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (!WSAgQyaOkuwvNhtmg0s())
							{
								goto IL_00d2;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (WSAgQyaOkuwvNhtmg0s())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								break;
							case 0:
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 9;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 6:
								return;
							case 3:
							case 5:
								break;
							default:
								num3 = 6;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00f2;
							}
							goto IL_00d2;
							continue;
							end_IL_00f2:
							break;
						}
						goto end_IL_0022;
						IL_00d2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
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
				case 1:
				case 2:
					segmentToolApi = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					WSAgQyaOkuwvNhtmg0s();
					num = ((!kJVZn4aH0HNLVjI1oDF()) ? 2 : 0);
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
		internal static object fXRDl0aTKS9OWhc5yyr(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WSAgQyaOkuwvNhtmg0s()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kJVZn4aH0HNLVjI1oDF()
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
	private struct _003CSetTunableProjectionParameters_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELTunableProjectionParams> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		public ELTunableProjectionParams tunableParams;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			ELTunableProjectionParams result = default;
			SegmentToolApi segmentToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					if (true)
					{
						continue;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						continue;
					}
					break;
				case 5:
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<ELTunableProjectionParams> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.PutAsync<ELTunableProjectionParams>((string)GoSqqEaKPk5qZKBAfVW(7314), tunableParams).GetAwaiter();
							num3 = 3;
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
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 7:
								return;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								_ = 1;
								if (OwVpqBaJ8pWdSojHCsv())
								{
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									return;
								}
								num3 = 6;
								if (!OwVpqBaJ8pWdSojHCsv())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
				segmentToolApi = _003C_003E4__this;
				KUUeyiaYd8D0Dl8lA4i();
				num = (OwVpqBaJ8pWdSojHCsv() ? 1 : 0);
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
		internal static object GoSqqEaKPk5qZKBAfVW(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KUUeyiaYd8D0Dl8lA4i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OwVpqBaJ8pWdSojHCsv()
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
	private struct _003CGetAutoTuneProjectionParameters_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELTunableProjectionParams> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			ELTunableProjectionParams result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						TaskAwaiter<ELTunableProjectionParams> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.PostAsync<ELTunableProjectionParams>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7350), Array.Empty<object>()).GetAwaiter();
							_ = 1;
							num3 = (TxFJKkaA4XJ3D2uPnjY() ? 7 : 3);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (1 == 0)
							{
								goto IL_00f2;
							}
						}
						goto IL_0074;
						IL_0074:
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Eu__1 = default;
								break;
							case 5:
								return;
							case 6:
							case 7:
								break;
							case 0:
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 9;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_0074;
							}
							goto IL_00f2;
							continue;
							end_IL_0074:
							break;
						}
						goto end_IL_0018;
						IL_00f2:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (TxFJKkaA4XJ3D2uPnjY())
						{
						}
						goto IL_0074;
						end_IL_0018:;
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
					num = 5;
					if (TxFJKkaA4XJ3D2uPnjY())
					{
					}
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 5:
					segmentToolApi = _003C_003E4__this;
					pJUOVfaCqwVowkJy5jV();
					num = (TxFJKkaA4XJ3D2uPnjY() ? 4 : 0);
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
		internal static bool pJUOVfaCqwVowkJy5jV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TxFJKkaA4XJ3D2uPnjY()
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
	private struct _003CTrain_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			SegmentToolApi segmentToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					segmentToolApi = _003C_003E4__this;
					_ = 0;
					num = (vNMFO5aNLmcCcKE6gtp() ? 1 : 0);
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.PostAsync<object>((string)TMwfJKapk7XUwDj0lpI(7402), Array.Empty<object>()).GetAwaiter();
							num3 = 1;
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
							case 6:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (vNMFO5aNLmcCcKE6gtp())
								{
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 1;
								}
								num3 = 5;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							default:
								return;
							case 5:
								return;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (ky77wCawpIjSs6x0VAe())
								{
								}
								continue;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								if (vNMFO5aNLmcCcKE6gtp())
								{
									continue;
								}
								break;
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
		internal static object TMwfJKapk7XUwDj0lpI(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vNMFO5aNLmcCcKE6gtp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ky77wCawpIjSs6x0VAe()
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
	private struct _003CGetResult_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELSegmenterResult> _003C_003Et__builder;

		public SegmentToolApi _003C_003E4__this;

		private TaskAwaiter<ELSegmenterResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!UeSshfaRBRkUsYMwm7f())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (false)
				{
					goto IL_01d7;
				}
			}
			goto IL_01a4;
			IL_01a4:
			int num2 = default;
			SegmentToolApi segmentToolApi = default;
			ELSegmenterResult result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					segmentToolApi = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						TaskAwaiter<ELSegmenterResult> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = segmentToolApi.ToolNode.GetAsync<ELSegmenterResult>((string)WX1G5qajJZdP2t8VdSF(7416)).GetAwaiter();
							num3 = 4;
							if (UeSshfaRBRkUsYMwm7f())
							{
								goto IL_0077;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_012a;
						IL_012a:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 1:
								_003C_003Eu__1 = default;
								goto case 6;
							case 2:
								return;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								UeSshfaRBRkUsYMwm7f();
								if (!IZEjS2aGG5P4GcpPDxB())
								{
									num3 = 7;
									continue;
								}
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 9:
								goto IL_0161;
							}
							break;
						}
						goto IL_0077;
						IL_0161:
						result = awaiter.GetResult();
						goto end_IL_0046;
						IL_0077:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							goto IL_012a;
						}
						goto IL_0161;
						end_IL_0046:;
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
				break;
			}
			goto IL_01d7;
			IL_01d7:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01a4;
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
		internal static object WX1G5qajJZdP2t8VdSF(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IZEjS2aGG5P4GcpPDxB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UeSshfaRBRkUsYMwm7f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private ResourceNode Aia2wGuIRI;

	public ResourceNode ToolNode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Aia2wGuIRI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Aia2wGuIRI = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddClass_003Ed__4))]
	public Task<int> AddClass(ELSegmenterClass segmenterClass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddClass_003Ed__4 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.segmenterClass = segmenterClass;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEditClass_003Ed__5))]
	public Task EditClass(ELSegmenterClass segmenterClass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!EfVjsuk6F6i5lHjFKs2())
		{
			num = 5;
		}
		else
		{
			num = 6;
			if (!aLG24YkSdr76XqW0j2F())
			{
				goto IL_006c;
			}
		}
		goto IL_009e;
		IL_009e:
		_003CEditClass_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = GPZr3RkD36EoT6FZFAC();
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				break;
			case 2:
			case 6:
				stateMachine.segmenterClass = segmenterClass;
				goto case 3;
			default:
				num = 3;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_006c;
		IL_006c:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_009e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetClasses_003Ed__6))]
	public Task<ELSegmenterClass[]> GetClasses()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetClasses_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELSegmenterClass[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteClass_003Ed__7))]
	public Task DeleteClass(int classId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDeleteClass_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				stateMachine.classId = classId;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				EfVjsuk6F6i5lHjFKs2();
				if (!aLG24YkSdr76XqW0j2F())
				{
					num = 1;
					if (aLG24YkSdr76XqW0j2F())
					{
						break;
					}
					goto case 4;
				}
				num = 6;
				if (EfVjsuk6F6i5lHjFKs2())
				{
				}
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetModelStats_003Ed__8))]
	public Task<ELSegmenterModelStats> GetModelStats()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetModelStats_003Ed__8 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELSegmenterModelStats>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetInferenceSize_003Ed__9))]
	public Task<Size> GetInferenceSize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetInferenceSize_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Size>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFixedRoiSize_003Ed__10))]
	public Task<Size> GetFixedRoiSize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFixedRoiSize_003Ed__10 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Size>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamples_003Ed__11))]
	public Task<ELSegmenterSample[]> GetSamples()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamples_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELSegmenterSample[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteSamples_003Ed__12))]
	public Task DeleteSamples(ICollection<string> sampleIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDeleteSamples_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sampleIds = sampleIds;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLabelCurrentImage_003Ed__13))]
	public Task<string> LabelCurrentImage(Bitmap maskImage)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CLabelCurrentImage_003Ed__13 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.maskImage = maskImage;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLabelImage_003Ed__14))]
	public Task LabelImage(string sampleId, Bitmap maskImage)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CLabelImage_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				break;
			case 2:
			case 6:
				stateMachine.sampleId = sampleId;
				goto case 3;
			case 3:
			case 7:
				stateMachine.maskImage = maskImage;
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = ((!EfVjsuk6F6i5lHjFKs2()) ? 6 : 7);
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetTunableProjectionParameters_003Ed__15))]
	public Task<ELTunableProjectionParams> GetTunableProjectionParameters()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetTunableProjectionParameters_003Ed__15 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELTunableProjectionParams>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetTunableProjectionParameters_003Ed__16))]
	public Task<ELTunableProjectionParams> SetTunableProjectionParameters(ELTunableProjectionParams tunableParams)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSetTunableProjectionParameters_003Ed__16 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELTunableProjectionParams>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.tunableParams = tunableParams;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAutoTuneProjectionParameters_003Ed__17))]
	public Task<ELTunableProjectionParams> GetAutoTuneProjectionParameters()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAutoTuneProjectionParameters_003Ed__17 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELTunableProjectionParams>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTrain_003Ed__18))]
	public Task Train()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EfVjsuk6F6i5lHjFKs2();
		int num;
		if (aLG24YkSdr76XqW0j2F())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0075;
			}
		}
		goto IL_0042;
		IL_0042:
		_003CTrain_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0075;
		IL_0075:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetResult_003Ed__19))]
	public Task<ELSegmenterResult> GetResult()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetResult_003Ed__19 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELSegmenterResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SegmentToolApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HmrWRdk8KKbCPZd5IPB();
		cZNqc0kFAUooQADCUxR(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aLG24YkSdr76XqW0j2F()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EfVjsuk6F6i5lHjFKs2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GPZr3RkD36EoT6FZFAC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HmrWRdk8KKbCPZd5IPB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cZNqc0kFAUooQADCUxR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
