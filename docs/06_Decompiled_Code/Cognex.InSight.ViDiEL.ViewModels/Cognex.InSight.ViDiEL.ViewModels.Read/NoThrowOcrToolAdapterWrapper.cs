using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Diagnostics.Logging;
using Cognex.Ocr.Client.Tool;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Read;

public class NoThrowOcrToolAdapterWrapper : IOcrToolAdapter, IDisposable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass3_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PoVZwXalEi3mnBGEZnX();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<ICollection<ISample>> _003CGetSamples_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetSamples(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PoVZwXalEi3mnBGEZnX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Si5562abpDpyj6VFfTj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JO2IqcaeiWDjojerOkj()
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
	private struct _003CGetSamples_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ICollection<ISample>> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ICollection<ISample>> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			odKg4oa7d42evLbQN73();
			int num;
			if (!TXVhmhayfTii6vfsxRN())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_01e5;
				}
			}
			goto IL_01b6;
			IL_01b6:
			int num2 = default;
			ICollection<ISample> result = default;
			ICollection<ISample> result2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						TaskAwaiter<ICollection<ISample>> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass3_0 obj = new _003C_003Ec__DisplayClass3_0();
							obj._003C_003E4__this = _003C_003E4__this;
							obj.toolId = toolId;
							awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return obj._003C_003E4__this.NjCxhQei7t.GetSamples(obj.toolId);
							}).GetAwaiter();
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						object obj2;
						while (true)
						{
							switch (num3)
							{
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 2:
							case 6:
								result = awaiter.GetResult();
								num3 = 0;
								continue;
							case 9:
								return;
							case 0:
								obj2 = result;
								if (obj2 == null)
								{
									num3 = 10;
									continue;
								}
								break;
							case 1:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 9;
								if (odKg4oa7d42evLbQN73())
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto case 2;
							case 8:
								_003C_003Eu__1 = awaiter;
								odKg4oa7d42evLbQN73();
								num3 = ((!TXVhmhayfTii6vfsxRN()) ? 1 : 2);
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto case 2;
							case 10:
								obj2 = new List<ISample>();
								break;
							}
							break;
						}
						result2 = (ICollection<ISample>)obj2;
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
					goto IL_01fb;
				case 5:
					return;
				}
				break;
				IL_01fb:
				num2 = _003C_003E1__state;
				num = 3;
				if (false)
				{
					return;
				}
			}
			goto IL_01e5;
			IL_01e5:
			_003C_003Et__builder.SetResult(result2);
			num = 5;
			goto IL_01b6;
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
		internal static bool odKg4oa7d42evLbQN73()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TXVhmhayfTii6vfsxRN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass4_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QtNbQaazo9THPwt7ZRv();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<int> _003CGetNumberOfSamples_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetNumberOfSamples(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QtNbQaazo9THPwt7ZRv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rwZnHWanMcPn627Fd0p()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Em7E94afrGTIRMComTu()
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
	private struct _003CGetNumberOfSamples_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<int> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			int result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					VKI0uNo2m7XHsZgtf9U();
					if (!P3TLRAoX2JU7oQqh7Vy())
					{
						num = 0;
						if (VKI0uNo2m7XHsZgtf9U())
						{
							continue;
						}
						goto case 0;
					}
					num = 4;
					continue;
				case 0:
				case 1:
					try
					{
						TaskAwaiter<int> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass4_0 obj = new _003C_003Ec__DisplayClass4_0();
							obj._003C_003E4__this = _003C_003E4__this;
							obj.toolId = toolId;
							awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return obj._003C_003E4__this.NjCxhQei7t.GetNumberOfSamples(obj.toolId);
							}).GetAwaiter();
							num3 = 3;
							goto IL_0116;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00ca;
						IL_00ca:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0116;
						IL_0116:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (!P3TLRAoX2JU7oQqh7Vy())
								{
									continue;
								}
								return;
							case 4:
							case 7:
								return;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (true)
								{
									continue;
								}
								break;
							case 0:
							case 5:
								break;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 1;
								num3 = ((!P3TLRAoX2JU7oQqh7Vy()) ? 7 : 0);
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_0116;
							}
							goto IL_00ca;
							continue;
							end_IL_0116:
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
		internal static bool VKI0uNo2m7XHsZgtf9U()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P3TLRAoX2JU7oQqh7Vy()
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
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass5_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Xw2N0JomBwmUCGGtOQZ();
			jsPkJ2orG75dnt64r8J(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<int> _003CGetNumberOfUniqueCharacters_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetNumberOfUniqueCharacters(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Xw2N0JomBwmUCGGtOQZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jsPkJ2orG75dnt64r8J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool by6tn5oMnREEdNrF7XA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S6DlxAoktdQrK36XoUK()
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
	private struct _003CGetNumberOfUniqueCharacters_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<int> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (y1kNCRoPVA3ON4dZDuC())
			{
				num = 3;
				if (r6wG9Qo4WNFpqAYv6ea())
				{
				}
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					return;
				}
			}
			int num2 = default;
			int result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						TaskAwaiter<int> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass5_0 obj = new _003C_003Ec__DisplayClass5_0();
							obj._003C_003E4__this = _003C_003E4__this;
							obj.toolId = toolId;
							awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return obj._003C_003E4__this.NjCxhQei7t.GetNumberOfUniqueCharacters(obj.toolId);
							}).GetAwaiter();
							num3 = 8;
							goto IL_00d6;
						}
						awaiter = _003C_003Eu__1;
						goto IL_008d;
						IL_008d:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00d6;
						IL_00d6:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 2:
							case 5:
								break;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 1;
								}
								goto case 9;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								r6wG9Qo4WNFpqAYv6ea();
								if (!y1kNCRoPVA3ON4dZDuC())
								{
									num3 = 2;
									continue;
								}
								num3 = 4;
								if (r6wG9Qo4WNFpqAYv6ea())
								{
								}
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00d6;
							}
							goto IL_008d;
							continue;
							end_IL_00d6:
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
					num = 4;
					continue;
				case 4:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static bool y1kNCRoPVA3ON4dZDuC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r6wG9Qo4WNFpqAYv6ea()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass6_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gyiDyloSb7ShnS85eAL();
			fgUeoQo63fvGMG9pbA2(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<double?> _003CGetConfidencePercentage_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetConfidencePercentage(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gyiDyloSb7ShnS85eAL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fgUeoQo63fvGMG9pbA2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool buxdD3ogKerKXqG1KLR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UHyRXVo1AV6oMMjaQVD()
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
	private struct _003CGetConfidencePercentage_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<double?> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<double?> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			double? result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 5;
					break;
				case 3:
					num2 = _003C_003E1__state;
					DgussDoDwGwBCKauIQl();
					if (!wSnKQZo87yHrX2AtoBL())
					{
						num = 0;
						if (wSnKQZo87yHrX2AtoBL())
						{
						}
					}
					else
					{
						num = 4;
					}
					break;
				case 0:
				case 1:
					try
					{
						TaskAwaiter<double?> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass6_0 obj = new _003C_003Ec__DisplayClass6_0();
							obj._003C_003E4__this = _003C_003E4__this;
							obj.toolId = toolId;
							awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return obj._003C_003E4__this.NjCxhQei7t.GetConfidencePercentage(obj.toolId);
							}).GetAwaiter();
							DgussDoDwGwBCKauIQl();
							num3 = ((!wSnKQZo87yHrX2AtoBL()) ? 1 : 8);
							goto IL_0155;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00bf;
						IL_0155:
						while (true)
						{
							switch (num3)
							{
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 5:
							case 8:
								break;
							case 0:
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									if (wSnKQZo87yHrX2AtoBL())
									{
									}
									continue;
								}
								goto case 9;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 4:
								return;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								if (!wSnKQZo87yHrX2AtoBL())
								{
									continue;
								}
								goto case 9;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_0155;
							}
							goto IL_00bf;
							continue;
							end_IL_0155:
							break;
						}
						goto end_IL_0059;
						IL_00bf:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_0155;
						end_IL_0059:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 5:
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
		internal static bool DgussDoDwGwBCKauIQl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wSnKQZo87yHrX2AtoBL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass7_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ht32m0odmwl2BmOyWVW();
			H4iVZMoEG97nZrUf277(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<IResultImage> _003CGetImage_003Eb__1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetImage(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ht32m0odmwl2BmOyWVW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void H4iVZMoEG97nZrUf277(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SpkKx5oFZaufbMT7eSM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool duwJlXosVwjdE6bsb74()
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
	private struct _003CGetImage_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IResultImage> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<IResultImage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!m5tJAko51LhF8LcXmVI())
			{
				goto IL_001e;
			}
			goto IL_01d0;
			IL_001e:
			IResultImage result = default;
			_003C_003Et__builder.SetResult(result);
			num = 5;
			goto IL_01d0;
			IL_01d0:
			int num2 = default;
			IResultImage result2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					try
					{
						TaskAwaiter<IResultImage> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass7_0 obj = new _003C_003Ec__DisplayClass7_0();
							obj._003C_003E4__this = _003C_003E4__this;
							obj.toolId = toolId;
							awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return obj._003C_003E4__this.NjCxhQei7t.GetImage(obj.toolId);
							}).GetAwaiter();
							num3 = 0;
							if (mUvuoMo3MB0Sy2Sk7rp())
							{
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 4;
						}
						object obj2;
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 5:
								result2 = awaiter.GetResult();
								goto case 3;
							case 1:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								if (mUvuoMo3MB0Sy2Sk7rp())
								{
									num3 = 3;
									continue;
								}
								num3 = 9;
								if (mUvuoMo3MB0Sy2Sk7rp())
								{
								}
								continue;
							case 2:
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 7:
								obj2 = result2;
								if (obj2 != null)
								{
									break;
								}
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 5;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 10:
								obj2 = Ce3XbkoaR1asUhkQX7N();
								break;
							}
							break;
						}
						result = (IResultImage)obj2;
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
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!mUvuoMo3MB0Sy2Sk7rp()) ? 3 : 4);
					continue;
				case 5:
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
		internal static object Ce3XbkoaR1asUhkQX7N()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HO0xNiMd8G();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m5tJAko51LhF8LcXmVI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mUvuoMo3MB0Sy2Sk7rp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass8_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Bwu7nXoui51450wBqHh();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<IResultCharacters> _003CGetCharacters_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetCharacters(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Bwu7nXoui51450wBqHh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pLjIuDooQjeG2HMqkoE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E7mCtfoc9fUFOHqonc4()
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
	private struct _003CGetCharacters_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IResultCharacters> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<IResultCharacters> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!aWIDZYoxvLguo8u6AAN()) ? 1 : 3);
			int num2 = default;
			IResultCharacters result2 = default;
			IResultCharacters result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter<IResultCharacters> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass8_0 obj = new _003C_003Ec__DisplayClass8_0();
							obj._003C_003E4__this = _003C_003E4__this;
							obj.toolId = toolId;
							awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return obj._003C_003E4__this.NjCxhQei7t.GetCharacters(obj.toolId);
							}).GetAwaiter();
							num3 = 3;
							goto IL_0097;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00c8;
						IL_00c8:
						aWIDZYoxvLguo8u6AAN();
						num3 = ((!T0MuD0oBPFsHNwFHdTl()) ? 5 : 9);
						goto IL_0097;
						IL_0097:
						while (true)
						{
							object resultCharacters;
							switch (num3)
							{
							case 7:
								resultCharacters = result2;
								if (resultCharacters == null)
								{
									num3 = 10;
									continue;
								}
								goto IL_0170;
							case 8:
								return;
							case 5:
							case 6:
								result2 = awaiter.GetResult();
								num3 = 7;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 5;
							case 1:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 4:
							case 9:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 5;
							case 10:
								{
									resultCharacters = new ResultCharacters();
									goto IL_0170;
								}
								IL_0170:
								result = (IResultCharacters)resultCharacters;
								goto end_IL_0097;
							}
							goto IL_00c8;
							continue;
							end_IL_0097:
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
					_003C_003Et__builder.SetResult(result);
					num = 5;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 5:
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
		internal static bool T0MuD0oBPFsHNwFHdTl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aWIDZYoxvLguo8u6AAN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass9_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			aYnpOKoQKx1bRmnUdgn(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<FieldingResult> _003CGetFieldingResult_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetFieldingResult(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aYnpOKoQKx1bRmnUdgn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool edj0dlohDsEjpd4sEOG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nsIhJfoUj0fN4wnoHQe()
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
	private struct _003CGetFieldingResult_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FieldingResult> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<FieldingResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_01d9;
			IL_001a:
			int num2 = _003C_003E1__state;
			IP9e02oV9vgVKG0NJvW();
			if (YqGqh6oq5a3445oEuw5())
			{
				num = 0;
				if (false)
				{
					goto IL_003d;
				}
			}
			else
			{
				num = 4;
				if (IP9e02oV9vgVKG0NJvW())
				{
					return;
				}
			}
			goto IL_01d9;
			IL_01d9:
			FieldingResult result = default;
			switch (num)
			{
			case 3:
				break;
			default:
				goto IL_003d;
			case 0:
			case 1:
				try
				{
					TaskAwaiter<FieldingResult> awaiter;
					int num3;
					if (num2 != 0)
					{
						_003C_003Ec__DisplayClass9_0 obj = new _003C_003Ec__DisplayClass9_0();
						obj._003C_003E4__this = _003C_003E4__this;
						obj.toolId = toolId;
						awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							return obj._003C_003E4__this.NjCxhQei7t.GetFieldingResult(obj.toolId);
						}).GetAwaiter();
						num3 = 9;
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 5;
					}
					FieldingResult fieldingResult;
					while (true)
					{
						switch (num3)
						{
						case 7:
							return;
						case 5:
							_003C_003Eu__1 = default;
							num3 = 3;
							continue;
						case 6:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						default:
							num3 = 7;
							continue;
						case 0:
						case 2:
							_003C_003Eu__1 = awaiter;
							num3 = 6;
							continue;
						case 1:
						case 4:
							num2 = (_003C_003E1__state = 0);
							goto case 0;
						case 3:
							num2 = (_003C_003E1__state = -1);
							num3 = 8;
							continue;
						case 8:
							fieldingResult = awaiter.GetResult();
							if (fieldingResult == null)
							{
								num3 = 10;
								continue;
							}
							break;
						case 9:
							if (awaiter.IsCompleted)
							{
								goto case 8;
							}
							YqGqh6oq5a3445oEuw5();
							if (IP9e02oV9vgVKG0NJvW())
							{
								num3 = 0;
								continue;
							}
							num3 = 4;
							if (0 == 0)
							{
								continue;
							}
							goto case 10;
						case 10:
							fieldingResult = new FieldingResult();
							break;
						}
						break;
					}
					result = fieldingResult;
				}
				catch (Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				goto IL_003d;
			case 5:
				return;
			}
			goto IL_001a;
			IL_003d:
			_003C_003Et__builder.SetResult(result);
			num = 5;
			goto IL_01d9;
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
		internal static bool YqGqh6oq5a3445oEuw5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IP9e02oV9vgVKG0NJvW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass10_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rD9lYtotfI0kdffY6QQ();
			VmI0dIo9GdLFqjxMCQY(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<CharacterSize> _003CGetCharacterSize_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetCharacterSize(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rD9lYtotfI0kdffY6QQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VmI0dIo9GdLFqjxMCQY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool obsDYqoivpBhROHxNlk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IoYbAgoLyLKRHxyTqC9()
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
	private struct _003CGetCharacterSize_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CharacterSize> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<CharacterSize> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			p3jnmNoZfCEm711fvhc();
			int num;
			if (v1kIu9ovJ6UvoqtBGJo())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (!v1kIu9ovJ6UvoqtBGJo())
				{
					goto IL_0206;
				}
			}
			goto IL_01c2;
			IL_01c2:
			int num2 = default;
			CharacterSize result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					try
					{
						TaskAwaiter<CharacterSize> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass10_0 obj = new _003C_003Ec__DisplayClass10_0();
							obj._003C_003E4__this = _003C_003E4__this;
							obj.toolId = toolId;
							awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return obj._003C_003E4__this.NjCxhQei7t.GetCharacterSize(obj.toolId);
							}).GetAwaiter();
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							p3jnmNoZfCEm711fvhc();
							num3 = ((!v1kIu9ovJ6UvoqtBGJo()) ? 6 : 3);
						}
						CharacterSize characterSize;
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 6:
							case 7:
								characterSize = awaiter.GetResult();
								if (characterSize == null)
								{
									num3 = 10;
									if (p3jnmNoZfCEm711fvhc())
									{
									}
									continue;
								}
								break;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 6;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (v1kIu9ovJ6UvoqtBGJo())
								{
									continue;
								}
								return;
							case 4:
								return;
							case 3:
							case 5:
								_003C_003Eu__1 = default;
								num3 = 0;
								if (v1kIu9ovJ6UvoqtBGJo())
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 6;
							case 10:
								characterSize = new CharacterSize();
								break;
							}
							break;
						}
						result = characterSize;
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
					goto IL_01df;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				case 5:
					return;
				}
				break;
				IL_01df:
				num = 4;
			}
			goto IL_0206;
			IL_0206:
			_003C_003Et__builder.SetResult(result);
			num = 5;
			goto IL_01c2;
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
		internal static bool v1kIu9ovJ6UvoqtBGJo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p3jnmNoZfCEm711fvhc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		public CharacterSize newCharacterSize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass11_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DhDFuroHvPaXgHb41At();
			Ngg2QpoTeymyZlDPpIf(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003CSetCharacterSize_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)voDCXfoYmm3LceIRYYt(_003C_003E4__this.NjCxhQei7t, toolId, newCharacterSize);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DhDFuroHvPaXgHb41At()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ngg2QpoTeymyZlDPpIf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IaTMaEo0liDxSCI8GFn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KRwC8XoOepOTdHZXuvK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object voDCXfoYmm3LceIRYYt(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOcrToolAdapter)P_0).SetCharacterSize((string)P_1, (CharacterSize)P_2);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		public string resultId;

		public ICollection<RevisedCharacter> revisedCharacters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass12_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kTrXbxoCFieGkkVJ4wo();
			EJUw4FoALJNKQf3Fek6(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003CAcceptLabeling_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.AcceptLabeling(toolId, resultId, revisedCharacters);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kTrXbxoCFieGkkVJ4wo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EJUw4FoALJNKQf3Fek6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P3qrWKoJAvy1VL5hVy8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NSmbbToKJspLngaRka4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass13_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RrQ08Rop686TPRcxs4A();
			vghk7AoGTHmv5Ren87d(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003CSkip_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)W1yob3oRSbku1IKiL00(_003C_003E4__this.NjCxhQei7t, toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RrQ08Rop686TPRcxs4A()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vghk7AoGTHmv5Ren87d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HU4QyLoN6SyRuqadbKu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool APihB9owEqiUacDg2Sd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object W1yob3oRSbku1IKiL00(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOcrToolAdapter)P_0).Skip((string)P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		public string sampleId;

		public ICollection<RevisedCharacter> revisedCharacters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass14_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			UpdthroWcLwOCZxRg6t(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003CChangeSample_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.ChangeSample(toolId, sampleId, revisedCharacters);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UpdthroWcLwOCZxRg6t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yiaSSgoj6b4iqmqmKd7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Kgi1JFoILQV095D6RxC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		public string[] samplesIds;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass15_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			juKFVPolYWtbLnbKFlB(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003CDeleteSamples_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)xgo6vto7LbuNMroeNG1(_003C_003E4__this.NjCxhQei7t, toolId, samplesIds);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void juKFVPolYWtbLnbKFlB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ibn18cobxQSHLYXc6qn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SgIgWdoe1noxMIFSrVo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xgo6vto7LbuNMroeNG1(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOcrToolAdapter)P_0).DeleteSamples((string)P_1, (string[])P_2);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass16_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XcpJk4ofGiUTIkUFnCo();
			tC48SGozquFNUKTflsy(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<FieldingSettings> _003CGetFielding_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.NjCxhQei7t.GetFielding(toolId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XcpJk4ofGiUTIkUFnCo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tC48SGozquFNUKTflsy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ky2SEboy35wBv5HNhbG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RZptnDonL5DxyNF9UKU()
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
	private struct _003CGetFielding_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FieldingSettings> _003C_003Et__builder;

		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<FieldingSettings> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			FieldingSettings result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 5;
					break;
				case 0:
					num2 = _003C_003E1__state;
					swd3uDc28JePpUiVqvl();
					num = (esKjRDcXn1dBLf1STCc() ? 4 : 3);
					break;
				case 1:
				case 3:
					try
					{
						TaskAwaiter<FieldingSettings> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass16_0 obj = new _003C_003Ec__DisplayClass16_0();
							obj._003C_003E4__this = _003C_003E4__this;
							obj.toolId = toolId;
							awaiter = LZkxVHBrDm([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return obj._003C_003E4__this.NjCxhQei7t.GetFielding(obj.toolId);
							}).GetAwaiter();
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						FieldingSettings fieldingSettings;
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!swd3uDc28JePpUiVqvl()) ? 4 : 9);
									continue;
								}
								goto case 4;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								if (swd3uDc28JePpUiVqvl())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 1:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (!esKjRDcXn1dBLf1STCc())
								{
									continue;
								}
								return;
							case 8:
								return;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 4;
							case 4:
							case 7:
								fieldingSettings = awaiter.GetResult();
								if (fieldingSettings == null)
								{
									num3 = 10;
									continue;
								}
								break;
							case 10:
								fieldingSettings = new FieldingSettings();
								break;
							}
							break;
						}
						result = fieldingSettings;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 5:
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
		internal static bool swd3uDc28JePpUiVqvl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool esKjRDcXn1dBLf1STCc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public NoThrowOcrToolAdapterWrapper _003C_003E4__this;

		public string toolId;

		public FieldingSettings fielding;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass17_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Iun49Dcm7QSwAaxDqa6();
			RZVoZHcrtBJObf7C8kY(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003CSetFielding_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)tTqZuscP9ig29hyasox(_003C_003E4__this.NjCxhQei7t, toolId, fielding);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Iun49Dcm7QSwAaxDqa6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RZVoZHcrtBJObf7C8kY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OKL1h7cMOopp2knV5lq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qX3UyWckmGi6QJDI1yR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tTqZuscP9ig29hyasox(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOcrToolAdapter)P_0).SetFielding((string)P_1, (FieldingSettings)P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCaptureExceptions_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Func<Task> func;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!F8PWBPcg1fj1VsYIwnt())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (!aVNnADc4C01Af2iKfHp())
				{
					goto IL_0041;
				}
			}
			goto IL_01b8;
			IL_01b8:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				case 1:
				case 2:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = G8rH5jc1x6tNyIptFR1(func());
								_ = 0;
								num3 = ((!aVNnADc4C01Af2iKfHp()) ? 1 : 8);
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
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									continue;
								case 0:
								case 8:
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									break;
								case 7:
									return;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 7;
									continue;
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 5;
									continue;
								case 4:
									_003C_003Eu__1 = default;
									goto case 1;
								case 1:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (Exception ex)
						{
							UC3xGAMVdh.ErrorException(ex.Message, ex);
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
					goto IL_01d5;
				case 5:
					return;
				}
				break;
				IL_01d5:
				num = 3;
				if (false)
				{
					return;
				}
			}
			goto IL_0041;
			IL_0041:
			_003C_003Et__builder.SetResult();
			num = 5;
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
		internal static TaskAwaiter G8rH5jc1x6tNyIptFR1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aVNnADc4C01Af2iKfHp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F8PWBPcg1fj1VsYIwnt()
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
	private struct _003CCaptureExceptions_003Ed__23<R> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<R> _003C_003Et__builder;

		public Func<Task<R>> func;

		private TaskAwaiter<R> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			R result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					try
					{
						try
						{
							TaskAwaiter<R> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = func().GetAwaiter();
								_ = 0;
								num3 = ((1 == 0) ? 8 : 3);
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
								case 1:
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 5;
									continue;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 2;
									continue;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 2:
									return;
								case 6:
									_003C_003Eu__1 = default;
									num3 = 7;
									continue;
								case 5:
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									continue;
								case 0:
								case 3:
									if (awaiter.IsCompleted)
									{
										break;
									}
									goto case 1;
								case 9:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						catch (Exception ex)
						{
							UC3xGAMVdh.ErrorException(ex.Message, ex);
							result = default;
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
					num = 5;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((1 == 0) ? 3 : 0);
					break;
				case 5:
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
		internal static bool OhrLiHcSi61V1NSwLxy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CBFAFBc6ZNscgYwZOsa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger UC3xGAMVdh;

	private readonly IOcrToolAdapter NjCxhQei7t;

	public event EventHandler<NewResultArgs> NewResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NjCxhQei7t.NewResult += value;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NjCxhQei7t.NewResult -= value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NoThrowOcrToolAdapterWrapper(IOcrToolAdapter wrapped)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Ulx8cSkORwoC7YNJilM();
		base._002Ector();
		NjCxhQei7t = wrapped ?? throw new ArgumentNullException((string)bh1cbEkHkApAO1uIqLg(1920));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamples_003Ed__3))]
	public Task<ICollection<ISample>> GetSamples(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamples_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ICollection<ISample>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNumberOfSamples_003Ed__4))]
	public Task<int> GetNumberOfSamples(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetNumberOfSamples_003Ed__4 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNumberOfUniqueCharacters_003Ed__5))]
	public Task<int> GetNumberOfUniqueCharacters(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetNumberOfUniqueCharacters_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetConfidencePercentage_003Ed__6))]
	public Task<double?> GetConfidencePercentage(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetConfidencePercentage_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<double?>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImage_003Ed__7))]
	public Task<IResultImage> GetImage(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImage_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IResultImage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCharacters_003Ed__8))]
	public Task<IResultCharacters> GetCharacters(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCharacters_003Ed__8 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IResultCharacters>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFieldingResult_003Ed__9))]
	public Task<FieldingResult> GetFieldingResult(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFieldingResult_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<FieldingResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCharacterSize_003Ed__10))]
	public Task<CharacterSize> GetCharacterSize(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCharacterSize_003Ed__10 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CharacterSize>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetCharacterSize(string toolId, CharacterSize newCharacterSize)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass11_0 obj = new _003C_003Ec__DisplayClass11_0();
		obj._003C_003E4__this = this;
		obj.toolId = toolId;
		obj.newCharacterSize = newCharacterSize;
		return exOxal15L2([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)_003C_003Ec__DisplayClass11_0.voDCXfoYmm3LceIRYYt(obj._003C_003E4__this.NjCxhQei7t, obj.toolId, obj.newCharacterSize);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task AcceptLabeling(string toolId, string resultId, ICollection<RevisedCharacter> revisedCharacters)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass12_0 obj = new _003C_003Ec__DisplayClass12_0();
		obj._003C_003E4__this = this;
		obj.toolId = toolId;
		obj.resultId = resultId;
		obj.revisedCharacters = revisedCharacters;
		return exOxal15L2([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return obj._003C_003E4__this.NjCxhQei7t.AcceptLabeling(obj.toolId, obj.resultId, obj.revisedCharacters);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Skip(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass13_0 obj = new _003C_003Ec__DisplayClass13_0();
		obj._003C_003E4__this = this;
		obj.toolId = toolId;
		return exOxal15L2([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)_003C_003Ec__DisplayClass13_0.W1yob3oRSbku1IKiL00(obj._003C_003E4__this.NjCxhQei7t, obj.toolId);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ChangeSample(string toolId, string sampleId, ICollection<RevisedCharacter> revisedCharacters)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass14_0 obj = new _003C_003Ec__DisplayClass14_0();
		obj._003C_003E4__this = this;
		obj.toolId = toolId;
		obj.sampleId = sampleId;
		obj.revisedCharacters = revisedCharacters;
		return exOxal15L2([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return obj._003C_003E4__this.NjCxhQei7t.ChangeSample(obj.toolId, obj.sampleId, obj.revisedCharacters);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task DeleteSamples(string toolId, string[] samplesIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass15_0 obj = new _003C_003Ec__DisplayClass15_0();
		obj._003C_003E4__this = this;
		obj.toolId = toolId;
		obj.samplesIds = samplesIds;
		return exOxal15L2([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)_003C_003Ec__DisplayClass15_0.xgo6vto7LbuNMroeNG1(obj._003C_003E4__this.NjCxhQei7t, obj.toolId, obj.samplesIds);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFielding_003Ed__16))]
	public Task<FieldingSettings> GetFielding(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFielding_003Ed__16 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<FieldingSettings>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetFielding(string toolId, FieldingSettings fielding)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass17_0 obj = new _003C_003Ec__DisplayClass17_0();
		obj._003C_003E4__this = this;
		obj.toolId = toolId;
		obj.fielding = fielding;
		return exOxal15L2([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)_003C_003Ec__DisplayClass17_0.tTqZuscP9ig29hyasox(obj._003C_003E4__this.NjCxhQei7t, obj.toolId, obj.fielding);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!UZfjbXk0QdmQ0vDawU0())
		{
			num = 3;
			if (UZfjbXk0QdmQ0vDawU0())
			{
			}
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_004c;
			}
		}
		goto IL_0074;
		IL_0074:
		IDisposable disposable = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				disposable = NjCxhQei7t as IDisposable;
				goto case 1;
			case 4:
				break;
			case 1:
			case 2:
				if (disposable != null)
				{
					break;
				}
				return;
			default:
				goto IL_0091;
			case 5:
				return;
			}
			break;
			IL_0091:
			num = 4;
			if (UZfjbXk0QdmQ0vDawU0())
			{
				return;
			}
		}
		goto IL_004c;
		IL_004c:
		ILpZVSkTr90AH2oRxNn(disposable);
		num = 5;
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCaptureExceptions_003Ed__22))]
	private static Task exOxal15L2(Func<Task> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCaptureExceptions_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.func = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCaptureExceptions_003Ed__23<>))]
	private static Task<FjwZUMTmkSAc4FKF8Q> LZkxVHBrDm<FjwZUMTmkSAc4FKF8Q>(Func<Task<FjwZUMTmkSAc4FKF8Q>> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCaptureExceptions_003Ed__23<FjwZUMTmkSAc4FKF8Q> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<FjwZUMTmkSAc4FKF8Q>.Create();
		stateMachine.func = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NoThrowOcrToolAdapterWrapper()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Ulx8cSkORwoC7YNJilM();
		UC3xGAMVdh = LogManager.GetLogger<NoThrowOcrToolAdapterWrapper>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	internal static ResultImage HO0xNiMd8G()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ResultImage resultImage = new ResultImage();
		ObT5MWkYvGP1e28aw9E(resultImage, "");
		Image image = new Image();
		eWLNXBkJSANKaLiiJRf(image, Array.Empty<byte>());
		e4eEKNkKJetxSoEKvVx(image, 0);
		j9SMHUkCQitvOTVtyw0(image, 0);
		QavMZOkAlaeJiALWu4V(resultImage, image);
		return resultImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ulx8cSkORwoC7YNJilM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bh1cbEkHkApAO1uIqLg(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool br9xuwkZghDgkDc7Q8n()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UZfjbXk0QdmQ0vDawU0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ILpZVSkTr90AH2oRxNn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ObT5MWkYvGP1e28aw9E(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ResultImage)P_0).Id = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eWLNXBkJSANKaLiiJRf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image)P_0).Content = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e4eEKNkKJetxSoEKvVx(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image)P_0).Height = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j9SMHUkCQitvOTVtyw0(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image)P_0).Width = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QavMZOkAlaeJiALWu4V(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ResultImage)P_0).Image = (Image)P_1;
	}
}
