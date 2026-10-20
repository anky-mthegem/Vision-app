using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoCellCommentsAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellCommentsAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Eau3PrsqXtB6jg3X30v0();
			int num;
			if (htp2BosqGF4w0EtB9B0O())
			{
				num = 1;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_01f5;
				}
			}
			goto IL_0196;
			IL_0196:
			int num2 = default;
			UndoCellCommentsAction undoCellCommentsAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoCellCommentsAction.l0R46g3QjM = (CvsCellComment)vKmjwFsqbsWl9gVVa6ei(undoCellCommentsAction.L9y4RZQKnN);
							htp2BosqGF4w0EtB9B0O();
							if (!Eau3PrsqXtB6jg3X30v0())
							{
								num3 = 4;
								if (1 == 0)
								{
									goto IL_005b;
								}
							}
							else
							{
								num3 = 1;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
							if (Eau3PrsqXtB6jg3X30v0())
							{
								goto IL_0156;
							}
						}
						goto IL_008a;
						IL_005b:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							goto IL_008a;
						}
						goto IL_0156;
						IL_0156:
						awaiter.GetResult();
						goto end_IL_0028;
						IL_008a:
						while (true)
						{
							switch (num3)
							{
							case 6:
								break;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (!Eau3PrsqXtB6jg3X30v0())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 4:
								awaiter = ((Task)AEFabWsq6HZQBrF6oM1b()).GetAwaiter();
								num3 = 6;
								continue;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								goto case 1;
							case 3:
								return;
							case 10:
								goto IL_0156;
							}
							break;
						}
						goto IL_005b;
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
					num = 4;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					if (Eau3PrsqXtB6jg3X30v0())
					{
					}
					continue;
				case 3:
					undoCellCommentsAction = _003C_003E4__this;
					goto case 2;
				case 4:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_01f5;
			IL_01f5:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!htp2BosqGF4w0EtB9B0O())
			{
				return;
			}
			goto IL_0196;
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
		internal static object vKmjwFsqbsWl9gVVa6ei(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).GetComment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AEFabWsq6HZQBrF6oM1b()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool htp2BosqGF4w0EtB9B0O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Eau3PrsqXtB6jg3X30v0()
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
	private struct _003CDo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellCommentsAction _003C_003E4__this;

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
			if (!sYVwTRsq0LPTgbeWfrTn())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (!VSPCXCsqpZwsPHEjPyVO())
				{
					return;
				}
			}
			UndoCellCommentsAction undoCellCommentsAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					undoCellCommentsAction = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							X0PvlHsqfA0JMXpdeU7c(yNFrDNsqkoThD3sZhhP8(m9Z4Kksq4aZY57sTvufD(undoCellCommentsAction.JLW4wd95x6)), undoCellCommentsAction.L9y4RZQKnN, undoCellCommentsAction.MAA4scV3FM);
							num3 = 4;
							goto IL_00b1;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0105;
						IL_0121:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						if (sYVwTRsq0LPTgbeWfrTn())
						{
						}
						goto IL_00b1;
						IL_0105:
						_003C_003Eu__1 = default;
						num3 = 7;
						if (!sYVwTRsq0LPTgbeWfrTn())
						{
							goto IL_00b1;
						}
						goto IL_0121;
						IL_00b1:
						while (true)
						{
							switch (num3)
							{
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 4:
								awaiter = wXlHCasqm6Y8u0a0GqFX(gGAvDXsqFZwMEu58MtwW());
								num3 = 0;
								if (sYVwTRsq0LPTgbeWfrTn())
								{
								}
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto IL_0121;
							default:
								num3 = 5;
								continue;
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (!sYVwTRsq0LPTgbeWfrTn())
								{
									continue;
								}
								break;
							case 1:
							case 6:
								break;
							case 5:
								goto IL_0121;
							case 8:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									goto IL_016b;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0035;
							}
							break;
							IL_016b:
							_ = 1;
							num3 = (sYVwTRsq0LPTgbeWfrTn() ? 1 : 3);
						}
						goto IL_0105;
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
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 0:
				case 5:
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
		internal static object m9Z4Kksq4aZY57sTvufD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yNFrDNsqkoThD3sZhhP8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void X0PvlHsqfA0JMXpdeU7c(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SetCommentAndRunSheet((CvsCogCellResult)P_1, (CvsCellComment)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gGAvDXsqFZwMEu58MtwW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter wXlHCasqm6Y8u0a0GqFX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VSPCXCsqpZwsPHEjPyVO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sYVwTRsq0LPTgbeWfrTn()
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
	private struct _003CRedo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellCommentsAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			UndoCellCommentsAction undoCellCommentsAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					undoCellCommentsAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							jThLeUsq8IiUYq3Qa4Fq(bRUif3sqJ9LoONFUxvCE(D92hU8sqZP95S9WJjmMJ(undoCellCommentsAction.JLW4wd95x6)), undoCellCommentsAction.L9y4RZQKnN, undoCellCommentsAction.MAA4scV3FM);
							ryuTWAsqgNUlgx5dB9hW();
							num3 = ((!k8H568sqyBcUQmdYbEO9()) ? 5 : 4);
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
							case 9:
								_003C_003Eu__1 = default;
								goto case 5;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 3:
								return;
							case 0:
							case 4:
								awaiter = Ql8YGqsqzXtxPVdEGZS6(Task.CompletedTask);
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 5:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
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
					break;
				default:
					num = 3;
					continue;
				case 5:
					num2 = _003C_003E1__state;
					k8H568sqyBcUQmdYbEO9();
					num = (ryuTWAsqgNUlgx5dB9hW() ? 4 : 0);
					continue;
				case 3:
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
		internal static object D92hU8sqZP95S9WJjmMJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bRUif3sqJ9LoONFUxvCE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jThLeUsq8IiUYq3Qa4Fq(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SetCommentAndRunSheet((CvsCogCellResult)P_1, (CvsCellComment)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Ql8YGqsqzXtxPVdEGZS6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k8H568sqyBcUQmdYbEO9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ryuTWAsqgNUlgx5dB9hW()
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
	private struct _003CUndo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellCommentsAction _003C_003E4__this;

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
			UndoCellCommentsAction undoCellCommentsAction = default;
			TaskAwaiter awaiter = default;
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
							HnLQoxsBL6uHXsAwBPjs(((CvsCogSocket)HSKnBPsBh43jLoO6dHyk(undoCellCommentsAction.JLW4wd95x6)).Sheet, undoCellCommentsAction.L9y4RZQKnN, undoCellCommentsAction.l0R46g3QjM);
							num3 = 8;
							if (!g39a36sBwei9p0MBDitU())
							{
								goto IL_004f;
							}
							goto IL_011d;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00ee;
						IL_015a:
						awaiter.GetResult();
						goto end_IL_0018;
						IL_011d:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								XfLGr2sBs4a9ry2ACDY4();
								if (g39a36sBwei9p0MBDitU())
								{
									num3 = 9;
									if (g39a36sBwei9p0MBDitU())
									{
										continue;
									}
									goto case 8;
								}
								num3 = 4;
								continue;
							case 8:
								awaiter = WY3XX2sBSRersKWfj8MS(zKtwIdsB9egvfoIdGZdj());
								num3 = 2;
								if (true)
								{
									continue;
								}
								return;
							case 0:
								return;
							case 4:
							case 6:
								goto IL_00ee;
							case 3:
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto IL_015a;
							case 10:
								goto IL_015a;
							}
							break;
						}
						goto IL_004f;
						IL_004f:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							goto IL_011d;
						}
						goto IL_015a;
						IL_00ee:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_011d;
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
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!g39a36sBwei9p0MBDitU()) ? 3 : 5);
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 5:
					undoCellCommentsAction = _003C_003E4__this;
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
		internal static object HSKnBPsBh43jLoO6dHyk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HnLQoxsBL6uHXsAwBPjs(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SetCommentAndRunSheet((CvsCogCellResult)P_1, (CvsCellComment)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zKtwIdsB9egvfoIdGZdj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter WY3XX2sBSRersKWfj8MS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g39a36sBwei9p0MBDitU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XfLGr2sBs4a9ry2ACDY4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight JLW4wd95x6;

	private readonly CvsCogCellResult L9y4RZQKnN;

	private CvsCellComment MAA4scV3FM;

	private CvsCellComment l0R46g3QjM;

	private readonly string qsv4Hk1D8D;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qsv4Hk1D8D;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoCellCommentsAction(CvsInSight inSight, CvsCogCellResult cell, CvsCellComment newComments, string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LJam64WQ2okxKrZSF7w();
		int num = (wGFe5PWlAFwh5QnfFkf() ? 1 : 6);
		while (true)
		{
			switch (num)
			{
			case 2:
				base._002Ector();
				num = 3;
				continue;
			case 3:
				JLW4wd95x6 = inSight;
				num = 5;
				continue;
			case 7:
				qsv4Hk1D8D = text;
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				L9y4RZQKnN = cell;
				break;
			case 0:
			case 6:
				y02WREWeENt21LWo9CK();
				num = 2;
				continue;
			case 8:
				return;
			}
			MAA4scV3FM = newComments;
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__8))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CSaveState_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 5:
				do
				{
					stateMachine._003C_003Et__builder = ci7MlwWuVtG4nmOd3OI();
					_ = 0;
					if (!LJam64WQ2okxKrZSF7w())
					{
						num = 0;
						continue;
					}
					num = 3;
					break;
				}
				while (1 == 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__9))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!wGFe5PWlAFwh5QnfFkf())
		{
			num = 2;
			if (wGFe5PWlAFwh5QnfFkf())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0044;
		IL_006f:
		_003CDo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (0 == 0)
		{
			goto IL_0044;
		}
		goto IL_0089;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_006f;
			case 1:
			case 4:
				goto IL_0089;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto IL_0089;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_006f;
		IL_0089:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0044;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__10))]
	public Task Redo()
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
		goto IL_0064;
		IL_004a:
		_003CRedo_003Ed__10 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0032;
		IL_0064:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			case 4:
				goto IL_0032;
			case 2:
			case 3:
				goto IL_004a;
			default:
				num = 4;
				continue;
			case 5:
				goto IL_008f;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_008f:
			stateMachine._003C_003Et__builder = ci7MlwWuVtG4nmOd3OI();
			_ = 0;
			num = ((!LJam64WQ2okxKrZSF7w()) ? 3 : 0);
		}
		goto IL_001a;
		IL_0032:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0064;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_004a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__11))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!LJam64WQ2okxKrZSF7w())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_001e:
		_003CUndo_003Ed__11 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_007d;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				break;
			case 4:
				goto IL_007d;
			case 3:
				stateMachine._003C_003Et__builder = ci7MlwWuVtG4nmOd3OI();
				_ = 0;
				if (!LJam64WQ2okxKrZSF7w())
				{
					num = 5;
					continue;
				}
				num = 0;
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
		goto IL_001e;
		IL_007d:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y02WREWeENt21LWo9CK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LJam64WQ2okxKrZSF7w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wGFe5PWlAFwh5QnfFkf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ci7MlwWuVtG4nmOd3OI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
