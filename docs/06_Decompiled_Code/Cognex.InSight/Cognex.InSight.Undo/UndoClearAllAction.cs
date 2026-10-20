using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoClearAllAction : UndoRangeAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoClearAllAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (yie24dsj4x6cmBTqY6X9() ? 3 : 2);
			int num2 = default;
			UndoClearAllAction undoClearAllAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							P13i2nsjkUMSGlfX3yLE(undoClearAllAction.StoredRanges[0]);
							num3 = 0;
							if (1 == 0)
							{
								goto IL_0043;
							}
							goto IL_00c1;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0079;
						IL_0079:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_00c1;
						IL_00c1:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 0:
								nw6AfUsjFPdC9S4MVmpB(((CvsCogSocket)bJxjKysjflvF0tKP7Om3(undoClearAllAction.InSight)).Sheet, undoClearAllAction.Range);
								num3 = 1;
								continue;
							case 6:
							case 7:
								goto IL_0079;
							case 1:
								awaiter = eMk2dcsjmWtvEhCSB7mI(Task.CompletedTask);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								break;
							default:
								num3 = 5;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								if (!awaiter.IsCompleted)
								{
									goto IL_0147;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0024;
							}
							break;
							IL_0147:
							awthY0sj0KQ3sjORSp9T();
							if (yie24dsj4x6cmBTqY6X9())
							{
								num3 = 7;
								continue;
							}
							num3 = 2;
							if (yie24dsj4x6cmBTqY6X9())
							{
							}
						}
						goto IL_0043;
						IL_0043:
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						goto IL_00c1;
						end_IL_0024:;
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
				case 1:
				case 3:
					undoClearAllAction = _003C_003E4__this;
					num = 4;
					continue;
				case 5:
					break;
				case 0:
				case 2:
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
		internal static void P13i2nsjkUMSGlfX3yLE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StoredRange)P_0).DeleteExternalData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bJxjKysjflvF0tKP7Om3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nw6AfUsjFPdC9S4MVmpB(object P_0, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ClearCellsAndRunSheet(cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter eMk2dcsjmWtvEhCSB7mI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool awthY0sj0KQ3sjORSp9T()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yie24dsj4x6cmBTqY6X9()
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
	private struct _003CUndo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoClearAllAction _003C_003E4__this;

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
			UndoClearAllAction undoClearAllAction = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Frn7CesjZNHS6WoLVgxq(undoClearAllAction.fJnlgiXcPK());
							MS9b8ZsjynIqj0rku9rV();
							if (!Nex82LsjgUeE0K9pJiTh())
							{
								num3 = 8;
								if (!MS9b8ZsjynIqj0rku9rV())
								{
									goto IL_0072;
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
							num3 = 3;
						}
						goto IL_00be;
						IL_0072:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_00be;
						IL_00be:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 0:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 5;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 5:
							case 7:
								awaiter.GetResult();
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (!Nex82LsjgUeE0K9pJiTh())
								{
									continue;
								}
								return;
							case 1:
								return;
							case 2:
								num2 = (_003C_003E1__state = -1);
								goto case 5;
							case 10:
								KyNixosjJZcvTHxroI1L(undoClearAllAction.StoredRanges[0]);
								goto end_IL_00be;
							}
							goto IL_0072;
							continue;
							end_IL_00be:
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
				case 5:
					undoClearAllAction = _003C_003E4__this;
					_ = 1;
					if (Nex82LsjgUeE0K9pJiTh())
					{
						num = 4;
						break;
					}
					num = 1;
					if (Nex82LsjgUeE0K9pJiTh())
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
		internal static TaskAwaiter Frn7CesjZNHS6WoLVgxq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KyNixosjJZcvTHxroI1L(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StoredRange)P_0).RestoreExternalData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MS9b8ZsjynIqj0rku9rV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Nex82LsjgUeE0K9pJiTh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private List<CvsCogCellResult> UFulqiINGD;

	protected CvsCellRange Range
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return StoredRanges[0].Range;
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
			return (string)jHWRqW795piHJwRvc2M(eqJfpH7LQJdWd4GhZtC(), Range.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoClearAllAction(CvsInSight inSight, CvsCellRange cellRange, List<CvsCogCellResult> list)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(inSight, cellRange);
		UFulqiINGD = list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__6))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!E8rX437sFX5b6WcdslH()) ? 3 : 5);
		_003CRedo_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				if (njvYqi7hFWpHiYtcFbQ())
				{
				}
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = b8iIun7Sk7qu1ZxWQVi();
				goto case 1;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (E8rX437sFX5b6WcdslH())
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__7))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CUndo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = b8iIun7Sk7qu1ZxWQVi();
				num = 4;
				if (!njvYqi7hFWpHiYtcFbQ())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003E4__this = this;
				E8rX437sFX5b6WcdslH();
				if (njvYqi7hFWpHiYtcFbQ())
				{
					num = 0;
					break;
				}
				num = 1;
				if (0 == 0)
				{
					break;
				}
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
	[CompilerGenerated]
	[DebuggerHidden]
	private Task fJnlgiXcPK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.Undo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E8rX437sFX5b6WcdslH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool njvYqi7hFWpHiYtcFbQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eqJfpH7LQJdWd4GhZtC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionClearAll;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jHWRqW795piHJwRvc2M(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder b8iIun7Sk7qu1ZxWQVi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
