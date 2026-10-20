using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoApplyAcquisitionSettingsEnumPropertyAction : UndoEnumPropertyAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoApplyAcquisitionSettingsEnumPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CapplyAcqSettingLoc_003E5__2;

		private CvsCellLocation _003ClabelLoc_003E5__3;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!AqtA6QsiRe6DWa2TsLu9()) ? 5 : 4);
			UndoApplyAcquisitionSettingsEnumPropertyAction undoApplyAcquisitionSettingsEnumPropertyAction = default;
			int num2 = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					undoApplyAcquisitionSettingsEnumPropertyAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003CapplyAcqSettingLoc_003E5__2 = undoApplyAcquisitionSettingsEnumPropertyAction.DropLocation;
							num3 = 20;
							if (!AqtA6QsiRe6DWa2TsLu9())
							{
								goto IL_0069;
							}
							goto IL_0127;
						case 2:
							awaiter2 = _003C_003Eu__2;
							num3 = 21;
							if (1 == 0)
							{
								goto IL_0090;
							}
							goto IL_0127;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 8;
							goto IL_0127;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 10;
								if (0 == 0)
								{
									goto IL_0127;
								}
								goto IL_0325;
							}
							IL_0127:
							while (true)
							{
								switch (num3)
								{
								case 6:
									break;
								case 0:
									goto IL_0090;
								case 3:
									goto IL_00a5;
								case 11:
									goto IL_00b9;
								case 14:
									awaiter2 = t4Omtbsiba8G7RQ1IEbv(r8Pl7GsiXd6gJamUWA8V(((CvsCogSocket)O2imLhsinpv9nuAhooI7(undoApplyAcquisitionSettingsEnumPropertyAction.InSight)).Sheet, _003CapplyAcqSettingLoc_003E5__2, new string[1] { undoApplyAcquisitionSettingsEnumPropertyAction.EOr4OdJFcK }));
									if (!awaiter2.IsCompleted)
									{
										goto IL_00b9;
									}
									goto IL_02cc;
								default:
									num3 = 11;
									continue;
								case 5:
								case 18:
									goto IL_019a;
								case 1:
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									if (AqtA6QsiRe6DWa2TsLu9())
									{
										continue;
									}
									goto case 9;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 22;
									continue;
								case 22:
									return;
								case 7:
								{
									CvsCellLocation dropLocation = undoApplyAcquisitionSettingsEnumPropertyAction.DropLocation;
									dropLocation.Row += (undoApplyAcquisitionSettingsEnumPropertyAction.IFS4hoM514 ? 3 : 2);
									awaiter = ((CvsCogSocketSheet)JOKpJtsiGL7GVOsjB2BH(O2imLhsinpv9nuAhooI7(undoApplyAcquisitionSettingsEnumPropertyAction.InSight))).PutCellExpressionAsync(_003CapplyAcqSettingLoc_003E5__2, string.Format(undoApplyAcquisitionSettingsEnumPropertyAction.oCA4pltMLY, dropLocation.ToString(absoluteRow: true, absoluteColumn: true))).GetAwaiter();
									num3 = 19;
									continue;
								}
								case 17:
									awaiter2 = undoApplyAcquisitionSettingsEnumPropertyAction.InsertControlExpression(_003ClabelLoc_003E5__3).GetAwaiter();
									num3 = 16;
									if (0 == 0)
									{
										continue;
									}
									goto case 15;
								case 15:
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									continue;
								case 10:
									_003C_003Eu__1 = default;
									num3 = 1;
									continue;
								case 19:
									if (!awaiter.IsCompleted)
									{
										num3 = 0;
										continue;
									}
									goto IL_00a5;
								case 8:
									num2 = (_003C_003E1__state = -1);
									goto IL_02cc;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 23;
									continue;
								case 2:
									_003C_003Eu__2 = awaiter2;
									num3 = 6;
									continue;
								case 23:
									return;
								case 16:
									goto IL_0325;
								case 12:
								case 13:
									_003C_003Eu__2 = awaiter2;
									num3 = 9;
									if (!NjJuPgsiaAb41WbQuMlN())
									{
										continue;
									}
									goto case 21;
								case 21:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 24;
									if (AqtA6QsiRe6DWa2TsLu9())
									{
										continue;
									}
									goto case 20;
								case 20:
									_003ClabelLoc_003E5__3 = undoApplyAcquisitionSettingsEnumPropertyAction.DropLocation;
									_003ClabelLoc_003E5__3.Row++;
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto end_IL_003c;
								case 24:
									goto end_IL_003c;
									IL_02cc:
									awaiter2.GetResult();
									num3 = 17;
									if (AqtA6QsiRe6DWa2TsLu9())
									{
										continue;
									}
									goto case 4;
								}
								break;
							}
							goto IL_0069;
							IL_0325:
							if (awaiter2.IsCompleted)
							{
								break;
							}
							goto IL_019a;
							IL_019a:
							num2 = (_003C_003E1__state = 2);
							num3 = 2;
							goto IL_0127;
							IL_0090:
							num2 = (_003C_003E1__state = 0);
							num3 = 15;
							if (false)
							{
								goto IL_00a5;
							}
							goto IL_0127;
							IL_00a5:
							awaiter.GetResult();
							num3 = 14;
							if (false)
							{
								goto IL_00b9;
							}
							goto IL_0127;
							IL_00b9:
							num2 = (_003C_003E1__state = 1);
							_ = 1;
							num3 = (NjJuPgsiaAb41WbQuMlN() ? 5 : 13);
							goto IL_0127;
							IL_0069:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
							end_IL_003c:
							break;
						}
						awaiter2.GetResult();
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
					num = 1;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 1:
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
		internal static object O2imLhsinpv9nuAhooI7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JOKpJtsiGL7GVOsjB2BH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object r8Pl7GsiXd6gJamUWA8V(object P_0, CvsCellLocation location, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).SetBoundArgsAsync(location, (string[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter t4Omtbsiba8G7RQ1IEbv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AqtA6QsiRe6DWa2TsLu9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NjJuPgsiaAb41WbQuMlN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellRange QLc4aZr0w9;

	private string EOr4OdJFcK;

	private string oCA4pltMLY;

	private bool IFS4hoM514;

	protected override CvsCellRange DefaultValuesRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellRange(2, 0, 1, 1);
		}
	}

	public override CvsCellRange[] ModifiedCells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellRange[1] { QLc4aZr0w9 };
		}
	}

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)qGnAClWijX3mrh5XdLF();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoApplyAcquisitionSettingsEnumPropertyAction(string id, string expression, UndoEnumPropertyActionArgs args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		oIOe9qWDGBk7fOUKRWs();
		int num = (PjGE0BWUeKdLry5HRKw() ? 2 : 6);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				pGA4tRWT9mUiNVW9k5j();
				num = 4;
				break;
			case 4:
				QLc4aZr0w9 = new CvsCellRange(0, 0, 4, 1);
				num = 1;
				if (oIOe9qWDGBk7fOUKRWs())
				{
					break;
				}
				goto case 5;
			case 5:
				IFS4hoM514 = !string.IsNullOrEmpty((string)bTIWu7WdPCLJoKvlKbY(args));
				num = 8;
				break;
			case 1:
				base._002Ector(args);
				goto case 2;
			case 7:
				oCA4pltMLY = expression;
				num = 5;
				break;
			case 2:
			case 3:
				EOr4OdJFcK = id;
				goto case 7;
			default:
				num = 7;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__11))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!oIOe9qWDGBk7fOUKRWs()) ? 4 : 3);
		_003CRedo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = c2yTLgWqpojgy45UXSS();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pGA4tRWT9mUiNVW9k5j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bTIWu7WdPCLJoKvlKbY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoEnumPropertyActionArgs)P_0).ValueExpression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oIOe9qWDGBk7fOUKRWs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PjGE0BWUeKdLry5HRKw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qGnAClWijX3mrh5XdLF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DropApplyAcquisitionSettings;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder c2yTLgWqpojgy45UXSS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
