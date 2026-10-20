using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoStringPropertyAction : IUndoPropertyAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__20 : IAsyncStateMachine
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
			JrSmv7sY1nJoYebNlZFU();
			int num = (KCq8mHsYrA2Tr8JHwupy() ? 2 : 3);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Tc6UjAsYOkExsSChtkJc(HLNaAEsY3OiVSgAdZnNk());
							_ = 1;
							num3 = (KCq8mHsYrA2Tr8JHwupy() ? 3 : 5);
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
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (KCq8mHsYrA2Tr8JHwupy())
								{
								}
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 0:
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 7;
								if (JrSmv7sY1nJoYebNlZFU())
								{
									continue;
								}
								return;
							case 2:
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
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
		internal static object HLNaAEsY3OiVSgAdZnNk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Tc6UjAsYOkExsSChtkJc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JrSmv7sY1nJoYebNlZFU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KCq8mHsYrA2Tr8JHwupy()
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
	private struct _003CDo_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoStringPropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			UndoStringPropertyAction undoStringPropertyAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					undoStringPropertyAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = T9jjmbsYlEFjx5jKfbjN(undoStringPropertyAction.Redo());
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							PEqaWusYQcob2UA4i1ej();
							if (soLPT2sYMgmDg8ZOna2P())
							{
								num3 = 0;
							}
							else
							{
								num3 = 8;
								if (!soLPT2sYMgmDg8ZOna2P())
								{
									goto IL_0127;
								}
							}
						}
						goto IL_0095;
						IL_0095:
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (soLPT2sYMgmDg8ZOna2P())
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
								return;
							case 0:
							case 5:
								_003C_003Eu__1 = default;
								goto case 6;
							case 1:
								break;
							case 9:
								goto IL_013d;
							}
							break;
						}
						goto IL_0127;
						IL_013d:
						awaiter.GetResult();
						goto end_IL_002f;
						IL_0127:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							goto IL_0095;
						}
						goto IL_013d;
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
					num = 0;
					continue;
				case 5:
					num2 = _003C_003E1__state;
					soLPT2sYMgmDg8ZOna2P();
					num = ((!PEqaWusYQcob2UA4i1ej()) ? 3 : 4);
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
		internal static TaskAwaiter T9jjmbsYlEFjx5jKfbjN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool soLPT2sYMgmDg8ZOna2P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PEqaWusYQcob2UA4i1ej()
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
	private struct _003CRedo_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoStringPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CeditStringLoc_003E5__2;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (mHBfMJsYuXswZdOcZyS6() ? 3 : 5);
			int num2 = default;
			TaskAwaiter<object> awaiter = default;
			UndoStringPropertyAction undoStringPropertyAction = default;
			CvsCellLocation dropLocation = default;
			do
			{
				IL_032e:
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 17;
								if (1 == 0)
								{
									goto IL_0054;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 4;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 14;
							if (1 == 0)
							{
								goto IL_0275;
							}
						}
						goto IL_0145;
						IL_0054:
						_003CeditStringLoc_003E5__2 = undoStringPropertyAction.DropLocation;
						num3 = 11;
						goto IL_0145;
						IL_0145:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 15:
								break;
							case 2:
								return;
							case 11:
								_003CeditStringLoc_003E5__2.Row++;
								awaiter = ((CvsCogSocketSheet)VD37scsYReJuFpRNtgw4(qZpK2esYIop9g5YZbfSq(undoStringPropertyAction.InSight))).PutCellExpressionAsync(dropLocation, undoStringPropertyAction.sYQqePTCuW).GetAwaiter();
								num3 = 3;
								continue;
							case 7:
								((CvsCogSocketSheet)VD37scsYReJuFpRNtgw4(undoStringPropertyAction.InSight.CogSocket)).Run(true);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							case 12:
								num2 = (_003C_003E1__state = 1);
								num3 = 8;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 5;
							case 18:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								return;
							case 5:
								awaiter.GetResult();
								goto case 10;
							default:
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 10:
								awaiter = ((CvsCogSocketSheet)VD37scsYReJuFpRNtgw4(undoStringPropertyAction.InSight.CogSocket)).PutCellExpressionAsync(_003CeditStringLoc_003E5__2, undoStringPropertyAction.r07qStXlIt).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								goto case 13;
							case 14:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								if (mHBfMJsYuXswZdOcZyS6())
								{
								}
								continue;
							case 17:
								dropLocation = undoStringPropertyAction.DropLocation;
								_ = 0;
								if (!q7EfqIsYethcWl2lAD7P())
								{
									num3 = 19;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								}
								num3 = 15;
								continue;
							case 13:
								awaiter.GetResult();
								num3 = 7;
								if (q7EfqIsYethcWl2lAD7P())
								{
									continue;
								}
								return;
							case 19:
								return;
							case 8:
								goto IL_0275;
							case 4:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								if (q7EfqIsYethcWl2lAD7P())
								{
									continue;
								}
								goto case 9;
							case 9:
								undoStringPropertyAction.InSight.SetString(_003CeditStringLoc_003E5__2, undoStringPropertyAction.krPqrWWKQJ);
								num3 = 20;
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 18;
								continue;
							case 20:
								undoStringPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
								goto end_IL_003b;
							}
							break;
						}
						goto IL_0054;
						IL_0275:
						_003C_003Eu__1 = awaiter;
						num3 = 16;
						goto IL_0145;
						end_IL_003b:;
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
					goto IL_032e;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_032e;
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				undoStringPropertyAction = _003C_003E4__this;
				num = 2;
			}
			while (!mHBfMJsYuXswZdOcZyS6());
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
		internal static object qZpK2esYIop9g5YZbfSq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VD37scsYReJuFpRNtgw4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q7EfqIsYethcWl2lAD7P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mHBfMJsYuXswZdOcZyS6()
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
	private struct _003CUndo_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoStringPropertyAction _003C_003E4__this;

		private CvsCellRange[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (LoKlA4sYngr99j88hSfS() ? 1 : 4);
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			UndoStringPropertyAction undoStringPropertyAction = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							modifiedCells = undoStringPropertyAction.ModifiedCells;
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 8:
								return;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								_003C_003E7__wrap2++;
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							case 12:
								cellRange = new CvsCellRange(undoStringPropertyAction.DropLocation.Row + cvsCellRange.Row, undoStringPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 13:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 7:
								_003C_003E7__wrap1 = modifiedCells;
								_003C_003E7__wrap2 = 0;
								_ = 0;
								if (!fSvkoosYalcxZTvTPKIK())
								{
									num3 = 6;
									continue;
								}
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 3:
							case 4:
								if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
								{
									cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
									num3 = 12;
									if (!LoKlA4sYngr99j88hSfS())
									{
										continue;
									}
									goto case 13;
								}
								num3 = 0;
								continue;
							case 0:
								_003C_003E7__wrap1 = null;
								num3 = 15;
								continue;
							case 14:
								awaiter = ((CvsCogSocketSheet)xhwJyEsYXYexk6tsPQT8(YACi6jsYGcF1r2gTxSZs(undoStringPropertyAction.InSight))).ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 11;
								continue;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 15:
								undoStringPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
								break;
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
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					undoStringPropertyAction = _003C_003E4__this;
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
		internal static object YACi6jsYGcF1r2gTxSZs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xhwJyEsYXYexk6tsPQT8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fSvkoosYalcxZTvTPKIK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LoKlA4sYngr99j88hSfS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellRange g7ZqGBvFTO;

	private CvsCellRange rnRqDL2YPe;

	private string sYQqePTCuW;

	private string r07qStXlIt;

	private string krPqrWWKQJ;

	[CompilerGenerated]
	private CvsInSight DQaqCMuRgp;

	private CvsCellLocation suFq2Fa7LB;

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DQaqCMuRgp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DQaqCMuRgp = value;
		}
	}

	public CvsCellLocation DropLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return suFq2Fa7LB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JiocpCKYhJgQPYj4PLr();
			int num;
			if (TGIQpVKPZHVeNDDBsuf())
			{
				num = 3;
				if (!TGIQpVKPZHVeNDDBsuf())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_005d;
			IL_002e:
			if (value.IsValid)
			{
				num = 1;
				goto IL_005d;
			}
			return;
			IL_005d:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
					suFq2Fa7LB = value;
					goto IL_008a;
				default:
					goto IL_008a;
				case 5:
					return;
				}
				break;
				IL_008a:
				rnRqDL2YPe = new CvsCellRange(suFq2Fa7LB.Row + 1, suFq2Fa7LB.Column, 1, 1);
				num = 5;
			}
			goto IL_002e;
		}
	}

	public CvsCellRange[] ModifiedCells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellRange[1] { g7ZqGBvFTO };
		}
	}

	public CvsCellRange ValuesRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rnRqDL2YPe;
		}
	}

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.DropFloat;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoStringPropertyAction(string name, string editStringExpression, string currentValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 4:
				suFq2Fa7LB = CvsCellLocation.Invalid;
				num = 2;
				continue;
			case 3:
			case 6:
				r07qStXlIt = editStringExpression;
				num = 8;
				continue;
			case 1:
				z6F4QIKNKlLkEE9TqYY();
				num = 9;
				continue;
			case 0:
				rnRqDL2YPe = CvsCellRange.Invalid;
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				krPqrWWKQJ = currentValue;
				num = 10;
				if (TGIQpVKPZHVeNDDBsuf())
				{
					continue;
				}
				goto case 9;
			case 9:
				g7ZqGBvFTO = new CvsCellRange(0, 0, 2, 1);
				num = 0;
				continue;
			case 5:
			case 7:
				sYQqePTCuW = (string)q8g8rCKruoZCoZ6gFKl(wwOhIRK1uyexuVDEHUx(16904), name);
				goto case 3;
			case 2:
				YVXThEKxJWURWNTyNAW(this);
				break;
			case 10:
				return;
			}
			JiocpCKYhJgQPYj4PLr();
			num = (TGIQpVKPZHVeNDDBsuf() ? 7 : 3);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__20))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSaveState_003Ed__20 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = mquYnEK3Ebk2ZdJUL0n();
				TGIQpVKPZHVeNDDBsuf();
				if (!JiocpCKYhJgQPYj4PLr())
				{
					num = 4;
					if (TGIQpVKPZHVeNDDBsuf())
					{
						continue;
					}
					goto default;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				continue;
			case 1:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__21))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CDo_003Ed__21 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = ((!TGIQpVKPZHVeNDDBsuf()) ? 4 : 5);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003Et__builder = mquYnEK3Ebk2ZdJUL0n();
				num = 0;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__22))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRedo_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = mquYnEK3Ebk2ZdJUL0n();
				num = 0;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				while (true)
				{
					stateMachine._003C_003E4__this = this;
					_ = 0;
					if (TGIQpVKPZHVeNDDBsuf())
					{
						break;
					}
					num = 5;
					if (TGIQpVKPZHVeNDDBsuf())
					{
						goto end_IL_0048;
					}
				}
				num = 1;
				if (TGIQpVKPZHVeNDDBsuf())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				{
					return stateMachine._003C_003Et__builder.Task;
				}
				end_IL_0048:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__23))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CUndo_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003Et__builder = mquYnEK3Ebk2ZdJUL0n();
				num = 0;
				break;
			case 0:
				stateMachine._003C_003E4__this = this;
				JiocpCKYhJgQPYj4PLr();
				num = (TGIQpVKPZHVeNDDBsuf() ? 5 : 4);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z6F4QIKNKlLkEE9TqYY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YVXThEKxJWURWNTyNAW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wwOhIRK1uyexuVDEHUx(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q8g8rCKruoZCoZ6gFKl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TGIQpVKPZHVeNDDBsuf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JiocpCKYhJgQPYj4PLr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder mquYnEK3Ebk2ZdJUL0n()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
