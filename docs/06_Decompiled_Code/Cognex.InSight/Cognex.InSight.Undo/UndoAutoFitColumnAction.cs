using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoAutoFitColumnAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoAutoFitColumnAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (zKDhTbsigJL8tsnCmTpC())
			{
				goto IL_001e;
			}
			goto IL_01a8;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a8;
			IL_01a8:
			int num2 = default;
			UndoAutoFitColumnAction undoAutoFitColumnAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoAutoFitColumnAction.h4D4kvnd9U = (int[])LCI7VysiJgJae2w3icgp(fH8834siZmFJ2R4ZbNBB(undoAutoFitColumnAction.WO84WMJhsC), undoAutoFitColumnAction.aaI4tiae0E);
							heybsmsiypWBL4qtddhA();
							num3 = (zKDhTbsigJL8tsnCmTpC() ? 6 : 9);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (zKDhTbsigJL8tsnCmTpC())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 0:
							case 9:
								awaiter = GlqsYesizFRwq8yxIF56(BjWxWGsi8n9GNwjrycZJ());
								goto case 1;
							case 2:
								return;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 7;
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
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					if (heybsmsiypWBL4qtddhA())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (!heybsmsiypWBL4qtddhA())
					{
						return;
					}
					continue;
				case 1:
				case 4:
					undoAutoFitColumnAction = _003C_003E4__this;
					goto case 2;
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
		internal static object fH8834siZmFJ2R4ZbNBB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LCI7VysiJgJae2w3icgp(object P_0, CvsCellRange activeRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).GetColumnWidths(activeRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BjWxWGsi8n9GNwjrycZJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter GlqsYesizFRwq8yxIF56(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool heybsmsiypWBL4qtddhA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zKDhTbsigJL8tsnCmTpC()
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

		public UndoAutoFitColumnAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gfQDyUsqwU7m6ljaSbXV();
			int num = (u7F7GysqsQQWHY6a8djE() ? 2 : 3);
			int num2 = default;
			UndoAutoFitColumnAction undoAutoFitColumnAction = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Obv43TsqhjYUqXvEwep5(undoAutoFitColumnAction.Redo());
							num3 = 0;
							goto IL_0097;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00e1;
						IL_00e1:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_0097;
						IL_0097:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
							case 5:
								break;
							case 3:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = (gfQDyUsqwU7m6ljaSbXV() ? 8 : 4);
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0097;
							}
							goto IL_00e1;
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
					goto case 4;
				default:
					num = 4;
					continue;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				undoAutoFitColumnAction = _003C_003E4__this;
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
		internal static TaskAwaiter Obv43TsqhjYUqXvEwep5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gfQDyUsqwU7m6ljaSbXV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u7F7GysqsQQWHY6a8djE()
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

		public UndoAutoFitColumnAction _003C_003E4__this;

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
			if (gKO9TgsqLqc95cFwJ7dy())
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_01a9;
			IL_0026:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a9;
			IL_01a9:
			int num2 = default;
			UndoAutoFitColumnAction undoAutoFitColumnAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							NvRr7XsqEoOu36f1DqMQ(wBLbansqSBAOshQpuUrs(undoAutoFitColumnAction.WO84WMJhsC), undoAutoFitColumnAction.aaI4tiae0E, undoAutoFitColumnAction.Mrg4LjX0Fs);
							num3 = 6;
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
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								gKO9TgsqLqc95cFwJ7dy();
								num3 = (x5jC9Dsq9MnJuFjEPkev() ? 4 : 3);
								continue;
							case 3:
							case 5:
								return;
							case 4:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 6:
								awaiter = iVpiHesqvjI2sP7D6t1b(Task.CompletedTask);
								num3 = 8;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								goto case 4;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								if (true)
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
					undoAutoFitColumnAction = _003C_003E4__this;
					goto case 1;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
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
		internal static object wBLbansqSBAOshQpuUrs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NvRr7XsqEoOu36f1DqMQ(object P_0, CvsCellRange activeRange, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).SetColumnWidths(activeRange, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter iVpiHesqvjI2sP7D6t1b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gKO9TgsqLqc95cFwJ7dy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x5jC9Dsq9MnJuFjEPkev()
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

		public UndoAutoFitColumnAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			UndoAutoFitColumnAction undoAutoFitColumnAction = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_01a3:
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					goto IL_01a3;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							((CvsSheetInfo)zSG1mKsqA2gwWleCSuI1(undoAutoFitColumnAction.WO84WMJhsC)).SetColumnWidths(undoAutoFitColumnAction.aaI4tiae0E, undoAutoFitColumnAction.h4D4kvnd9U);
							num3 = 6;
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
							case 5:
								return;
							case 7:
								return;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (QWLKDQsqHEuiV1Ge8vNZ())
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (!vd7ui1sqV22f7PWfqn2R())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 6:
								awaiter = ((Task)u33IXBsqDpF4Ikhf4u4V()).GetAwaiter();
								vd7ui1sqV22f7PWfqn2R();
								num3 = ((!QWLKDQsqHEuiV1Ge8vNZ()) ? 7 : 9);
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 4:
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
					break;
				case 1:
					do
					{
						undoAutoFitColumnAction = _003C_003E4__this;
						_ = 1;
						if (vd7ui1sqV22f7PWfqn2R())
						{
							num = 0;
							continue;
						}
						num = 4;
						break;
					}
					while (1 == 0);
					goto IL_01a3;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (!vd7ui1sqV22f7PWfqn2R());
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
		internal static object zSG1mKsqA2gwWleCSuI1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u33IXBsqDpF4Ikhf4u4V()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QWLKDQsqHEuiV1Ge8vNZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vd7ui1sqV22f7PWfqn2R()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsCellRange aaI4tiae0E;

	private readonly CvsInSight WO84WMJhsC;

	private CvsCellRange Qgs43pbapc;

	private readonly int[] Mrg4LjX0Fs;

	private int[] h4D4kvnd9U;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hFbRrWW2TU2CeVbY7NG();
			int num;
			if (mcIYO5WcaUJOJGpR0ol())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_00ef;
				}
			}
			goto IL_00c0;
			IL_008f:
			string result = (string)SZCvfmWt2S2ejPgEGY5(ajWQZkW7Tv5r1WTOrTp(), (char)(65 + Qgs43pbapc.Column));
			goto IL_00ef;
			IL_00ef:
			return result;
			IL_002a:
			if (Qgs43pbapc.Columns == 1)
			{
				num = 1;
				if (false)
				{
					goto IL_00ef;
				}
			}
			else
			{
				result = (string)Y5iANsWKRiOCD6bnuW5(u8fqPFWCYa16lV37VuN(), (char)(65 + Qgs43pbapc.Column), (char)(65 + Qgs43pbapc.LastColumn));
				num = 5;
				if (hFbRrWW2TU2CeVbY7NG())
				{
					goto IL_008f;
				}
			}
			goto IL_00c0;
			IL_00c0:
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 1:
				goto IL_008f;
			default:
				goto IL_00ef;
			}
			goto IL_002a;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoAutoFitColumnAction(CvsCellRange activeRange, CvsInSight inSight, CvsCellRange cellRange, int[] widths)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00bc;
		IL_001a:
		Mrg4LjX0Fs = widths;
		num = 10;
		if (hFbRrWW2TU2CeVbY7NG())
		{
			goto IL_0032;
		}
		goto IL_00bc;
		IL_00bc:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 6:
				goto IL_0032;
			case 2:
			case 5:
				if (activeRange.Contains(cellRange.Location))
				{
					num = 1;
					continue;
				}
				goto case 8;
			case 7:
				goto IL_0060;
			case 9:
				WO84WMJhsC = inSight;
				goto IL_0032;
			case 8:
				throw new ArgumentException((string)XZVelrWWNoTpBv9Wf3c(16882));
			default:
				num = 9;
				continue;
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 7;
				continue;
			case 1:
				if (activeRange.Contains(cellRange.LastLocation))
				{
					aaI4tiae0E = activeRange;
					goto case 9;
				}
				num = 8;
				if (true)
				{
					continue;
				}
				return;
			case 10:
				return;
			}
			break;
			IL_0060:
			base._002Ector();
			_ = 1;
			num = ((!hFbRrWW2TU2CeVbY7NG()) ? 5 : 0);
		}
		goto IL_001a;
		IL_0032:
		Qgs43pbapc = cellRange;
		num = 4;
		goto IL_00bc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__8))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CSaveState_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E4__this = this;
				mcIYO5WcaUJOJGpR0ol();
				num = (hFbRrWW2TU2CeVbY7NG() ? 1 : 5);
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = Rmns2mW5yroHMcTtRmR();
				num = 0;
				if (mcIYO5WcaUJOJGpR0ol())
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__9))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (mcIYO5WcaUJOJGpR0ol())
		{
			num = 4;
			if (hFbRrWW2TU2CeVbY7NG())
			{
			}
		}
		else
		{
			num = 5;
			if (!mcIYO5WcaUJOJGpR0ol())
			{
				goto IL_007f;
			}
		}
		goto IL_0048;
		IL_0093:
		_003CDo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0048;
		IL_007f:
		stateMachine._003C_003E4__this = this;
		num = 1;
		if (true)
		{
			goto IL_0048;
		}
		goto IL_0093;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto IL_0093;
			case 2:
				break;
			default:
				goto IL_0093;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = Rmns2mW5yroHMcTtRmR();
				num = 2;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_007f;
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
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0090;
		IL_001a:
		_003CRedo_003Ed__10 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (hFbRrWW2TU2CeVbY7NG())
		{
			goto IL_0038;
		}
		goto IL_0090;
		IL_0090:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 5:
				goto IL_0038;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 0;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0038:
		stateMachine._003C_003Et__builder = Rmns2mW5yroHMcTtRmR();
		hFbRrWW2TU2CeVbY7NG();
		num = ((!mcIYO5WcaUJOJGpR0ol()) ? 4 : 3);
		goto IL_0090;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__11))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!mcIYO5WcaUJOJGpR0ol())
		{
			goto IL_001e;
		}
		goto IL_0056;
		IL_001e:
		_003CUndo_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (!mcIYO5WcaUJOJGpR0ol())
		{
			goto IL_003c;
		}
		goto IL_0056;
		IL_003c:
		stateMachine._003C_003E1__state = -1;
		goto IL_001e;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				goto IL_003c;
			case 1:
				goto IL_0087;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0087:
			stateMachine._003C_003E4__this = this;
			_ = 0;
			num = ((!mcIYO5WcaUJOJGpR0ol()) ? 5 : 0);
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XZVelrWWNoTpBv9Wf3c(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mcIYO5WcaUJOJGpR0ol()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hFbRrWW2TU2CeVbY7NG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ajWQZkW7Tv5r1WTOrTp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionAutoFitColumn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SZCvfmWt2S2ejPgEGY5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u8fqPFWCYa16lV37VuN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionAutoFitColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y5iANsWKRiOCD6bnuW5(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Rmns2mW5yroHMcTtRmR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
