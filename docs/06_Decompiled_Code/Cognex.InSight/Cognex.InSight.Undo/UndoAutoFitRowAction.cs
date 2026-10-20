using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoAutoFitRowAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoAutoFitRowAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoAutoFitRowAction undoAutoFitRowAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					undoAutoFitRowAction = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					if (qiOXBMsqU2mKrKNPljbH())
					{
						num = 2;
						if (HsAwLpsqTcqytZEnWOx6())
						{
						}
					}
					else
					{
						num = 4;
					}
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoAutoFitRowAction.x4M45HGVeQ = (int[])DnEXSpsqiuR4syfgEkZO(DsoZE4sqd9fe9DI0MI0v(undoAutoFitRowAction.eO24fAMYJd), undoAutoFitRowAction.Cm44XVmpR7);
							num3 = 9;
							goto IL_0165;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00e2;
						IL_00e2:
						_003C_003Eu__1 = default;
						num3 = 5;
						if (HsAwLpsqTcqytZEnWOx6())
						{
						}
						goto IL_0165;
						IL_0165:
						while (true)
						{
							switch (num3)
							{
							case 7:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!qiOXBMsqU2mKrKNPljbH()) ? 1 : 8);
									continue;
								}
								goto case 10;
							case 2:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 3:
								return;
							case 1:
							case 6:
								break;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (HsAwLpsqTcqytZEnWOx6())
								{
								}
								continue;
							case 9:
								awaiter = iZ27kCsqqPqXaatvBh8O(Task.CompletedTask);
								num3 = 7;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0165;
							}
							goto IL_00e2;
							continue;
							end_IL_0165:
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
		internal static object DsoZE4sqd9fe9DI0MI0v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DnEXSpsqiuR4syfgEkZO(object P_0, CvsCellRange activeRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).GetRowHeights(activeRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter iZ27kCsqqPqXaatvBh8O(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qiOXBMsqU2mKrKNPljbH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HsAwLpsqTcqytZEnWOx6()
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

		public UndoAutoFitRowAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!EU1apPsqBekOAMKo6lfu())
			{
				goto IL_001e;
			}
			goto IL_018f;
			IL_001e:
			UndoAutoFitRowAction undoAutoFitRowAction = _003C_003E4__this;
			jvfaXLsqjo1nnrXw7HVO();
			if (EU1apPsqBekOAMKo6lfu())
			{
				num = 1;
			}
			else
			{
				num = 0;
				if (1 == 0)
				{
					goto IL_01c2;
				}
			}
			goto IL_018f;
			IL_01c2:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_018f;
			IL_018f:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = u8mEg4sqc8x18paKRjEW(undoAutoFitRowAction.Redo());
							num3 = 3;
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
							case 6:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							default:
								return;
							case 5:
								return;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
								do
								{
									num2 = (_003C_003E1__state = 0);
									_ = 1;
									if (jvfaXLsqjo1nnrXw7HVO())
									{
										num3 = 5;
										continue;
									}
									num3 = 8;
									if (jvfaXLsqjo1nnrXw7HVO())
									{
									}
									break;
								}
								while (!EU1apPsqBekOAMKo6lfu());
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
					goto IL_01c2;
				default:
					goto IL_01c2;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					return;
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
		internal static TaskAwaiter u8mEg4sqc8x18paKRjEW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EU1apPsqBekOAMKo6lfu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jvfaXLsqjo1nnrXw7HVO()
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

		public UndoAutoFitRowAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			I6QsX1sqWnYNKrdbBFL5();
			int num;
			if (CLCa2msq22HGRAvkXAQi())
			{
				num = 1;
			}
			else
			{
				num = 5;
				if (!CLCa2msq22HGRAvkXAQi())
				{
					goto IL_0045;
				}
			}
			goto IL_01e7;
			IL_01e7:
			UndoAutoFitRowAction undoAutoFitRowAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					undoAutoFitRowAction = _003C_003E4__this;
					goto case 2;
				case 0:
				case 1:
					break;
				case 3:
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
							undoAutoFitRowAction.eO24fAMYJd.SheetInfo.SetRowHeights(undoAutoFitRowAction.Cm44XVmpR7, undoAutoFitRowAction.NKE4cWpHSG);
							num3 = 3;
							goto IL_014e;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0098;
						IL_0098:
						_003C_003Eu__1 = default;
						num3 = 2;
						if (I6QsX1sqWnYNKrdbBFL5())
						{
						}
						goto IL_014e;
						IL_014e:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 6:
								break;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (CLCa2msq22HGRAvkXAQi())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								}
								goto case 10;
							case 3:
								awaiter = xiPsIIsqtn7HYTUvw8Zy(ql8ntKsq7PFNs5LDejPJ());
								_ = 0;
								if (CLCa2msq22HGRAvkXAQi())
								{
									num3 = 8;
									continue;
								}
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 9:
								return;
							case 10:
								awaiter.GetResult();
								goto end_IL_014e;
							}
							goto IL_0098;
							continue;
							end_IL_014e:
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
					goto case 3;
				default:
					num = 3;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0045;
			IL_0045:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_01e7;
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
		internal static object ql8ntKsq7PFNs5LDejPJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter xiPsIIsqtn7HYTUvw8Zy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CLCa2msq22HGRAvkXAQi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I6QsX1sqWnYNKrdbBFL5()
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

		public UndoAutoFitRowAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			UndoAutoFitRowAction undoAutoFitRowAction = default;
			TaskAwaiter awaiter = default;
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
							atnworsqot9wdewB9sOL(wcUS6vsq5GkYhZPoOBRS(undoAutoFitRowAction.eO24fAMYJd), undoAutoFitRowAction.Cm44XVmpR7, undoAutoFitRowAction.x4M45HGVeQ);
							num3 = 5;
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
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (uFVDcqsqCbOMkgNrlwan())
								{
									continue;
								}
								goto case 5;
							case 5:
								awaiter = HNWlVRsqPIFQs2qiidvP(Task.CompletedTask);
								num3 = 3;
								if (uFVDcqsqCbOMkgNrlwan())
								{
									continue;
								}
								goto case 3;
							case 3:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!uFVDcqsqCbOMkgNrlwan()) ? 6 : 9);
									continue;
								}
								break;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = default;
								goto case 6;
							case 2:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 4:
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
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					undoAutoFitRowAction = _003C_003E4__this;
					_ = 0;
					if (!uFVDcqsqCbOMkgNrlwan())
					{
						num = 0;
						continue;
					}
					num = 4;
					if (0 == 0)
					{
						continue;
					}
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
		internal static object wcUS6vsq5GkYhZPoOBRS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object atnworsqot9wdewB9sOL(object P_0, CvsCellRange activeRange, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).SetRowHeights(activeRange, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter HNWlVRsqPIFQs2qiidvP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uFVDcqsqCbOMkgNrlwan()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cM01ZJsqKIN6R6bBgZil()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsCellRange Cm44XVmpR7;

	private readonly CvsInSight eO24fAMYJd;

	private CvsCellRange qXi4j19mI3;

	private readonly int[] NKE4cWpHSG;

	private int[] x4M45HGVeQ;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!UK2vUYWo116L5Tp54aO()) ? 4 : 3);
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					result = (string)d8Hn8UWx7CB7Fwj3HY7(v9NBDyWNXhkEjB4f5L9(), qXi4j19mI3.Row);
					break;
				case 0:
				case 3:
					if (qXi4j19mI3.Rows != 1)
					{
						result = (string)OnxvEdW1OlS2eOSiybI(Resources.UndoActionAutoFitRows, qXi4j19mI3.Row, qXi4j19mI3.LastRow);
						num = 5;
					}
					else
					{
						num = 1;
					}
					continue;
				}
				break;
			}
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoAutoFitRowAction(CvsCellRange activeRange, CvsInSight inSight, CvsCellRange cellRange, int[] heights)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (a4VAVsWPaV0GAiHJFnU() ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!activeRange.Contains(cellRange.Location))
				{
					break;
				}
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				base._002Ector();
				num = 1;
				continue;
			case 5:
			case 6:
				qXi4j19mI3 = cellRange;
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 8;
				continue;
			case 9:
				NKE4cWpHSG = heights;
				num = 10;
				continue;
			case 7:
				if (!activeRange.Contains(cellRange.LastLocation))
				{
					num = 3;
					continue;
				}
				Cm44XVmpR7 = activeRange;
				goto case 4;
			case 3:
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				eO24fAMYJd = inSight;
				goto case 5;
			case 10:
				return;
			}
			break;
		}
		throw new ArgumentException((string)Q70tDYWY1YcoE2OXEZR(16882));
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
			case 4:
				stateMachine._003C_003E4__this = this;
				a4VAVsWPaV0GAiHJFnU();
				num = (UK2vUYWo116L5Tp54aO() ? 1 : 0);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (UK2vUYWo116L5Tp54aO())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = sOnPqrWr8BtCKAvLSle();
				num = 4;
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
		a4VAVsWPaV0GAiHJFnU();
		int num;
		if (UK2vUYWo116L5Tp54aO())
		{
			num = 5;
			if (a4VAVsWPaV0GAiHJFnU())
			{
			}
		}
		else
		{
			num = 4;
		}
		_003CDo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 1;
				if (a4VAVsWPaV0GAiHJFnU())
				{
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!a4VAVsWPaV0GAiHJFnU())
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 2;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__10))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		a4VAVsWPaV0GAiHJFnU();
		int num = ((!UK2vUYWo116L5Tp54aO()) ? 1 : 4);
		_003CRedo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__11))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		a4VAVsWPaV0GAiHJFnU();
		int num = ((!UK2vUYWo116L5Tp54aO()) ? 3 : 5);
		_003CUndo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = sOnPqrWr8BtCKAvLSle();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q70tDYWY1YcoE2OXEZR(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UK2vUYWo116L5Tp54aO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a4VAVsWPaV0GAiHJFnU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v9NBDyWNXhkEjB4f5L9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionAutoFitRow;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d8Hn8UWx7CB7Fwj3HY7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OnxvEdW1OlS2eOSiybI(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder sOnPqrWr8BtCKAvLSle()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
