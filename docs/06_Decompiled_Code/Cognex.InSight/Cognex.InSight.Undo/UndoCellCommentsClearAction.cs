using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoCellCommentsClearAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					zCg73WsBvqeZ3nSmERo8();
					num = ((!Yqh3ecsBE2QcUhNxOYj6()) ? 4 : 0);
					continue;
				case 0:
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ap9jeHsBVcCJkkvBoqiw(O9ZxKjsBHK6d158sZvRE());
							num3 = 8;
							if (Yqh3ecsBE2QcUhNxOYj6())
							{
								goto IL_00a7;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
						}
						goto IL_006f;
						IL_00f4:
						num2 = (_003C_003E1__state = 0);
						num3 = 0;
						goto IL_00a7;
						IL_00a7:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 6:
								break;
							case 7:
								goto IL_0087;
							default:
								goto IL_00d4;
							case 2:
								goto IL_00f4;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 3:
							case 4:
								return;
							case 1:
								goto IL_013a;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_004e;
							}
							break;
						}
						goto IL_006f;
						IL_006f:
						_003C_003Eu__1 = default;
						num3 = 1;
						if (false)
						{
							goto IL_0087;
						}
						goto IL_00a7;
						IL_0087:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto IL_00d4;
						IL_00d4:
						zCg73WsBvqeZ3nSmERo8();
						if (Yqh3ecsBE2QcUhNxOYj6())
						{
							num3 = 3;
							if (!Yqh3ecsBE2QcUhNxOYj6())
							{
								goto IL_00f4;
							}
						}
						else
						{
							num3 = 6;
							if (!Yqh3ecsBE2QcUhNxOYj6())
							{
								goto IL_013a;
							}
						}
						goto IL_00a7;
						IL_013a:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00a7;
						end_IL_004e:;
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
				_003C_003Et__builder.SetResult();
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
		internal static object O9ZxKjsBHK6d158sZvRE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ap9jeHsBVcCJkkvBoqiw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yqh3ecsBE2QcUhNxOYj6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zCg73WsBvqeZ3nSmERo8()
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
	private struct _003CDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellCommentsClearAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_016f;
			IL_001a:
			UndoCellCommentsClearAction undoCellCommentsClearAction = default;
			int num2 = default;
			try
			{
				TaskAwaiter awaiter;
				if (num2 != 0)
				{
					CvsCellComment cvsCellComment = new CvsCellComment("");
					List<CvsCogCellResult>.Enumerator enumerator = undoCellCommentsClearAction.BPO4QZUdib.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CvsCogCellResult current = enumerator.Current;
							XA5fNqsBD8G94pd5ywDf();
							switch ((!PrQWOrsBAespFAqrSKyL()) ? 3 : 2)
							{
							case 0:
							case 2:
								jjNCC8sBdE3yUaCMwhDY(N7IyhwsBTwNRqAbNSxiC(GcVwdIsBUe0PvXQRo4g5(undoCellCommentsClearAction.CAr4Km3PIh)), current, cvsCellComment);
								break;
							}
						}
					}
					finally
					{
						if (num2 < 0)
						{
							((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
						}
					}
					awaiter = Xdd9bcsBqkILQN3sRaUg(A2wTZtsBiCQkXJFrUWMF());
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
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01b1;
			IL_016f:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					num = 3;
					continue;
				case 1:
				case 4:
					undoCellCommentsClearAction = _003C_003E4__this;
					break;
				case 3:
					goto IL_01b1;
				case 0:
					goto IL_01c6;
				case 6:
					return;
				}
				break;
				IL_01c6:
				num2 = _003C_003E1__state;
				_ = 1;
				num = ((!XA5fNqsBD8G94pd5ywDf()) ? 4 : 5);
			}
			goto IL_001a;
			IL_01b1:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_016f;
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
		internal static object GcVwdIsBUe0PvXQRo4g5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N7IyhwsBTwNRqAbNSxiC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jjNCC8sBdE3yUaCMwhDY(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SetCommentAndRunSheet((CvsCogCellResult)P_1, (CvsCellComment)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A2wTZtsBiCQkXJFrUWMF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Xdd9bcsBqkILQN3sRaUg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PrQWOrsBAespFAqrSKyL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XA5fNqsBD8G94pd5ywDf()
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
	private struct _003CRedo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellCommentsClearAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RfVuYlsBjJ6HY9gMWQ9I();
			int num = ((!KnLldjsBBcBN08NErg7f()) ? 2 : 3);
			UndoCellCommentsClearAction undoCellCommentsClearAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					undoCellCommentsClearAction = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							CvsCellComment cvsCellComment = new CvsCellComment("");
							List<CvsCogCellResult>.Enumerator enumerator = undoCellCommentsClearAction.BPO4QZUdib.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCogCellResult current = enumerator.Current;
									KnLldjsBBcBN08NErg7f();
									int num3;
									if (!RfVuYlsBjJ6HY9gMWQ9I())
									{
										num3 = 2;
									}
									else
									{
										num3 = 3;
										if (1 == 0)
										{
											continue;
										}
									}
									switch (num3)
									{
									case 0:
									case 2:
										to6T5RsBWAoBBCmXVhd4(bIqpYFsB2wIAKxlZf3RT(bfcraLsBcl3nnsrPoKjo(undoCellCommentsClearAction.CAr4Km3PIh)), current, cvsCellComment);
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							awaiter = urZXIosBtj3UFQjwAILh(oDfMu9sB7KtXIUip9TTe());
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
						awaiter.GetResult();
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
		internal static object bfcraLsBcl3nnsrPoKjo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bIqpYFsB2wIAKxlZf3RT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void to6T5RsBWAoBBCmXVhd4(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SetCommentAndRunSheet((CvsCogCellResult)P_1, (CvsCellComment)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oDfMu9sB7KtXIUip9TTe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter urZXIosBtj3UFQjwAILh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KnLldjsBBcBN08NErg7f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RfVuYlsBjJ6HY9gMWQ9I()
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
	private struct _003CUndo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellCommentsClearAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!bRp8sksBKrj9ZUKUZ87O()) ? 1 : 5);
			UndoCellCommentsClearAction undoCellCommentsClearAction = default;
			CvsCellComment comment = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							List<CvsCogCellResult>.Enumerator enumerator = undoCellCommentsClearAction.BPO4QZUdib.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCogCellResult current = enumerator.Current;
									int num3 = 4;
									while (true)
									{
										IL_0067:
										switch (num3)
										{
										case 1:
										case 5:
											comment = current.GetComment();
											goto case 2;
										default:
											num3 = 2;
											continue;
										case 0:
										case 3:
											((CvsCogSocketSheet)mlPJLesBYaGjORF7rPkT(GxSU5ssBPPn6c2sc0Fa6(undoCellCommentsClearAction.CAr4Km3PIh))).SetCommentAndRunSheet(current, comment);
											num3 = 6;
											continue;
										case 2:
											if (comment == null)
											{
												break;
											}
											goto case 0;
										case 4:
											while (f0WEVTsBo1EWgjgIGgKb(XIp81nsB5X9O5mHbkFOY(current)) > 0)
											{
												A3BFSJsBCQAD8I2WOmfI();
												if (bRp8sksBKrj9ZUKUZ87O())
												{
													num3 = 0;
													if (!A3BFSJsBCQAD8I2WOmfI())
													{
														continue;
													}
												}
												else
												{
													num3 = 5;
												}
												goto IL_0067;
											}
											break;
										case 6:
											break;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							awaiter = aZygMJsBx4LMuZJZdQ5H(I9lokwsBNRTindbrXiPS());
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
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					undoCellCommentsClearAction = _003C_003E4__this;
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
		internal static object XIp81nsB5X9O5mHbkFOY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Comment;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int f0WEVTsBo1EWgjgIGgKb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GxSU5ssBPPn6c2sc0Fa6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mlPJLesBYaGjORF7rPkT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object I9lokwsBNRTindbrXiPS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter aZygMJsBx4LMuZJZdQ5H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A3BFSJsBCQAD8I2WOmfI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bRp8sksBKrj9ZUKUZ87O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight CAr4Km3PIh;

	private readonly CvsCellRange d0V4E9pBto;

	private List<CvsCogCellResult> BPO4QZUdib;

	private readonly string Tl14NAnsH1;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Tl14NAnsH1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoCellCommentsClearAction(CvsInSight inSight, CvsCellRange range, List<CvsCogCellResult> oldComments, string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		d0V4E9pBto = CvsCellRange.Empty;
		base._002Ector();
		CAr4Km3PIh = inSight;
		d0V4E9pBto = range;
		BPO4QZUdib = oldComments;
		Tl14NAnsH1 = text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		atS9OgWInAmFjIC2D58();
		int num;
		if (!pgPbX9WR8P0KJTxatLj())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_008b;
			}
		}
		goto IL_005c;
		IL_0042:
		_003CSaveState_003Ed__7 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_008b;
		IL_005c:
		switch (num)
		{
		case 0:
		case 3:
			break;
		case 4:
			goto IL_0042;
		default:
			goto IL_008b;
		case 5:
			return stateMachine._003C_003Et__builder.Task;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		num = 4;
		if (1 == 0)
		{
			goto IL_0042;
		}
		goto IL_005c;
		IL_008b:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!atS9OgWInAmFjIC2D58()) ? 4 : 5);
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!pgPbX9WR8P0KJTxatLj()) ? 1 : 5);
		_003CRedo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = e2HQFWWaJenan9UL9ZN();
				num = 3;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				pgPbX9WR8P0KJTxatLj();
				num = (atS9OgWInAmFjIC2D58() ? 5 : 4);
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool atS9OgWInAmFjIC2D58()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pgPbX9WR8P0KJTxatLj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder e2HQFWWaJenan9UL9ZN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
