using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Undo;

namespace wjIG9PrX4DALC214Qh;

internal class xb9yB2SHpkLOLZYMq3 : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public xb9yB2SHpkLOLZYMq3 _003C_003E4__this;

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
			if (QLSMPMKAeC25VAYkcHSR())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (HYRypCKAOipHWQvTh9EY())
				{
				}
			}
			xb9yB2SHpkLOLZYMq3 xb9yB2SHpkLOLZYMq4 = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					xb9yB2SHpkLOLZYMq4 = _003C_003E4__this;
					num = 2;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
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
								awaiter = _003C_003Eu__1;
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (1 == 0)
							{
								goto IL_009a;
							}
						}
						goto IL_01cd;
						IL_01cd:
						while (true)
						{
							switch (num3)
							{
							case 14:
								return;
							case 4:
								break;
							case 15:
								awaiter = SYt0l0KADFoU9quJpuKu(xjrnDDKAIQtP5tY8Esmv(xb9yB2SHpkLOLZYMq4.bGbcGlcK9w));
								_ = 1;
								num3 = (HYRypCKAOipHWQvTh9EY() ? 9 : 2);
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 1:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 6;
								}
								goto case 0;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 12:
								return;
							case 9:
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								continue;
							case 13:
								awaiter = ((Task)ieFG6HKAiZCsZuqnkcwp(xb9yB2SHpkLOLZYMq4.Q4ycK618mH)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 11;
									continue;
								}
								goto case 16;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (HYRypCKAOipHWQvTh9EY())
								{
								}
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 0:
								awaiter.GetResult();
								num3 = 13;
								continue;
							case 11:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							case 16:
								awaiter.GetResult();
								goto end_IL_01cd;
							}
							goto IL_009a;
							continue;
							end_IL_01cd:
							break;
						}
						goto end_IL_006b;
						IL_009a:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						goto IL_01cd;
						end_IL_006b:;
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
		internal static object xjrnDDKAIQtP5tY8Esmv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter SYt0l0KADFoU9quJpuKu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ieFG6HKAiZCsZuqnkcwp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoTrainPattern)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QLSMPMKAeC25VAYkcHSR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HYRypCKAOipHWQvTh9EY()
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
	private struct _003CRedo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public xb9yB2SHpkLOLZYMq3 _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_025e;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_025e;
			IL_025e:
			int num2 = default;
			TaskAwaiter awaiter = default;
			xb9yB2SHpkLOLZYMq3 xb9yB2SHpkLOLZYMq4 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							BMOnM5KAVcs4ho6XPUPP();
							num3 = ((!uk7FHpKAnCMdQMRLfub8()) ? 3 : 4);
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 7;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 12;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 10;
								}
								goto case 11;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 11:
								awaiter.GetResult();
								num3 = 14;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 12:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
							case 4:
								awaiter = tjRm46KAfBB3x19wSb9I(xb9yB2SHpkLOLZYMq4.bGbcGlcK9w.Redo());
								num3 = 8;
								if (BMOnM5KAVcs4ho6XPUPP())
								{
								}
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								break;
							case 14:
								awaiter = tjRm46KAfBB3x19wSb9I(waxxKwKAd0PYZxsqxeZU(xb9yB2SHpkLOLZYMq4.Q4ycK618mH));
								num3 = 5;
								if (uk7FHpKAnCMdQMRLfub8())
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								goto case 11;
							default:
								num3 = 11;
								if (BMOnM5KAVcs4ho6XPUPP())
								{
								}
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 3:
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								goto case 3;
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
					num = 3;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					uk7FHpKAnCMdQMRLfub8();
					num = ((!BMOnM5KAVcs4ho6XPUPP()) ? 5 : 0);
					continue;
				case 1:
				case 5:
					xb9yB2SHpkLOLZYMq4 = _003C_003E4__this;
					goto case 0;
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
		internal static TaskAwaiter tjRm46KAfBB3x19wSb9I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object waxxKwKAd0PYZxsqxeZU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoTrainPattern)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uk7FHpKAnCMdQMRLfub8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BMOnM5KAVcs4ho6XPUPP()
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
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public xb9yB2SHpkLOLZYMq3 _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			whmvs2KAlJnOBlBJmVck();
			int num;
			if (!Tm6GPgKAgNTYQDhj2PKa())
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (Tm6GPgKAgNTYQDhj2PKa())
				{
					goto IL_02a6;
				}
			}
			goto IL_026f;
			IL_026f:
			xb9yB2SHpkLOLZYMq3 xb9yB2SHpkLOLZYMq4 = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					xb9yB2SHpkLOLZYMq4 = _003C_003E4__this;
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
								num3 = 8;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 10;
							}
							goto IL_017f;
						}
						awaiter = _003C_003Eu__1;
						goto IL_007d;
						IL_017f:
						while (true)
						{
							switch (num3)
							{
							case 12:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 16;
							case 5:
							case 14:
								break;
							case 11:
								awaiter.GetResult();
								num3 = 15;
								if (Tm6GPgKAgNTYQDhj2PKa())
								{
								}
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									num3 = ((!Tm6GPgKAgNTYQDhj2PKa()) ? 4 : 14);
									continue;
								}
								goto case 11;
							case 2:
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								continue;
							case 15:
								awaiter = DgLKUoKAv2hjD6wJWW33(rmL17FKArsNsg5KJqx2H(xb9yB2SHpkLOLZYMq4.bGbcGlcK9w));
								num3 = 12;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 9:
								return;
							case 3:
								num2 = (_003C_003E1__state = -1);
								goto case 11;
							default:
								num3 = 11;
								continue;
							case 8:
								awaiter = DgLKUoKAv2hjD6wJWW33(z0jcgLKAsHkAYaxHUhGy(xb9yB2SHpkLOLZYMq4.Q4ycK618mH));
								num3 = 0;
								continue;
							case 13:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (whmvs2KAlJnOBlBJmVck())
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_017f;
							}
							goto IL_007d;
							continue;
							end_IL_017f:
							break;
						}
						goto end_IL_0050;
						IL_007d:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_017f;
						end_IL_0050:;
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
					goto IL_02a6;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_02a6:
			num2 = _003C_003E1__state;
			num = 2;
			if (Tm6GPgKAgNTYQDhj2PKa())
			{
				return;
			}
			goto IL_026f;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_026f;
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
		internal static object z0jcgLKAsHkAYaxHUhGy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoTrainPattern)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DgLKUoKAv2hjD6wJWW33(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rmL17FKArsNsg5KJqx2H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool whmvs2KAlJnOBlBJmVck()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tm6GPgKAgNTYQDhj2PKa()
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
	private struct _003CUndo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public xb9yB2SHpkLOLZYMq3 _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!Wl7qsZKAZlYSrGk4AyCT())
			{
			}
			xb9yB2SHpkLOLZYMq3 xb9yB2SHpkLOLZYMq4 = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					xb9yB2SHpkLOLZYMq4 = _003C_003E4__this;
					R56FYYKAPnYEV1QPYoux();
					if (!Wl7qsZKAZlYSrGk4AyCT())
					{
						num = 4;
						if (true)
						{
							break;
						}
						goto default;
					}
					num = 0;
					if (false)
					{
						return;
					}
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								goto IL_00b7;
							}
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_0143;
						IL_0143:
						while (true)
						{
							switch (num3)
							{
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 14;
								continue;
							case 0:
								return;
							case 2:
							case 12:
								break;
							case 8:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 13:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (!R56FYYKAPnYEV1QPYoux())
									{
										num3 = 2;
										if (R56FYYKAPnYEV1QPYoux())
										{
											continue;
										}
										break;
									}
									num3 = 15;
									if (R56FYYKAPnYEV1QPYoux())
									{
										continue;
									}
									goto case 5;
								}
								goto case 16;
							case 5:
								awaiter.GetResult();
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 1:
								awaiter = nmXOUqKAbyfBZfXbSWAo(by3Z1WKAGPHys9r2NQha(xb9yB2SHpkLOLZYMq4.bGbcGlcK9w));
								num3 = 13;
								continue;
							case 4:
								if (awaiter.IsCompleted)
								{
									goto case 5;
								}
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (R56FYYKAPnYEV1QPYoux())
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 7:
								awaiter = nmXOUqKAbyfBZfXbSWAo(hnWChXKABMAex9keDIab(xb9yB2SHpkLOLZYMq4.Q4ycK618mH));
								num3 = 4;
								if (R56FYYKAPnYEV1QPYoux())
								{
									continue;
								}
								goto case 14;
							case 14:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
							case 15:
								num2 = (_003C_003E1__state = 1);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								awaiter.GetResult();
								goto end_IL_0143;
							}
							goto IL_00b7;
							continue;
							end_IL_0143:
							break;
						}
						goto end_IL_006b;
						IL_00b7:
						_003C_003Eu__1 = default;
						num3 = 10;
						goto IL_0143;
						end_IL_006b:;
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
		internal static object hnWChXKABMAex9keDIab(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoTrainPattern)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter nmXOUqKAbyfBZfXbSWAo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object by3Z1WKAGPHys9r2NQha(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R56FYYKAPnYEV1QPYoux()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Wl7qsZKAZlYSrGk4AyCT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly UndoTrainPattern Q4ycK618mH;

	private readonly IUndoAction bGbcGlcK9w;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)ODubu2qtcalRiIFTSym(bGbcGlcK9w);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public xb9yB2SHpkLOLZYMq3(UndoTrainPattern P_0, IUndoAction P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fTomarqcTWy1Ynocyck();
		int num;
		if (!AyJ5yVq1Ps7U5WTDXH7())
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
			if (!fTomarqcTWy1Ynocyck())
			{
				return;
			}
		}
		goto IL_0053;
		IL_002a:
		XjHTKEqh6WZEGjM0Dp5(this);
		num = 3;
		goto IL_0053;
		IL_0053:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 3:
				Q4ycK618mH = P_0;
				goto case 5;
			default:
				num = 5;
				continue;
			case 5:
				bGbcGlcK9w = P_1;
				num = 6;
				continue;
			case 0:
			case 2:
				jKt1PaquE6nPdQOgx6C();
				break;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__5))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fTomarqcTWy1Ynocyck();
		int num = (AyJ5yVq1Ps7U5WTDXH7() ? 5 : 4);
		_003CDo_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (AyJ5yVq1Ps7U5WTDXH7())
				{
				}
				break;
			case 2:
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__6))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!AyJ5yVq1Ps7U5WTDXH7())
		{
		}
		_003CRedo_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (AyJ5yVq1Ps7U5WTDXH7())
				{
					num = 5;
					continue;
				}
				num = 0;
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
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fTomarqcTWy1Ynocyck();
		int num = (AyJ5yVq1Ps7U5WTDXH7() ? 1 : 4);
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				if (!AyJ5yVq1Ps7U5WTDXH7())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__8))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CUndo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				num = ((!AyJ5yVq1Ps7U5WTDXH7()) ? 4 : 5);
				break;
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
	internal static void jKt1PaquE6nPdQOgx6C()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XjHTKEqh6WZEGjM0Dp5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fTomarqcTWy1Ynocyck()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AyJ5yVq1Ps7U5WTDXH7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ODubu2qtcalRiIFTSym(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IUndoAction)P_0).Text;
	}
}
