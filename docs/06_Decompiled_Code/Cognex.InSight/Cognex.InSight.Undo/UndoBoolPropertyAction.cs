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

public class UndoBoolPropertyAction : IUndoPropertyAction, IUndoAction
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
			_ = 0;
			int num;
			if (HlA9OnsqYQFcKgIXeekb())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (bAjjD9sqN4MsMnwlUgGv())
				{
				}
			}
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = mnk6Nksq19ybENimAebo(jpHKwtsqxMjdEJNDNVOr());
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (false)
							{
								goto IL_0068;
							}
						}
						goto IL_0099;
						IL_0068:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						goto IL_0099;
						IL_0099:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 2:
							case 3:
								break;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								break;
							case 8:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (!HlA9OnsqYQFcKgIXeekb())
									{
										num3 = 3;
										continue;
									}
									num3 = 4;
									if (true)
									{
										continue;
									}
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_0099;
							}
							goto IL_0068;
							continue;
							end_IL_0099:
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
				_003C_003Et__builder.SetResult();
				num = 5;
				if (bAjjD9sqN4MsMnwlUgGv())
				{
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
		internal static object jpHKwtsqxMjdEJNDNVOr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter mnk6Nksq19ybENimAebo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HlA9OnsqYQFcKgIXeekb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bAjjD9sqN4MsMnwlUgGv()
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

		public UndoBoolPropertyAction _003C_003E4__this;

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
			if (zFEPIAsqrxyeiXhCWVwc())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (false)
				{
					return;
				}
			}
			UndoBoolPropertyAction undoBoolPropertyAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					undoBoolPropertyAction = _003C_003E4__this;
					num = 1;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = BE51jEsqOeHsDvigpJn4(undoBoolPropertyAction.Redo());
							num3 = 3;
							if (!zFEPIAsqrxyeiXhCWVwc())
							{
								goto IL_007d;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_010b;
						IL_010b:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 0:
								goto IL_0099;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (zFEPIAsqrxyeiXhCWVwc())
								{
									continue;
								}
								return;
							default:
								return;
							case 5:
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 2;
								}
								goto case 9;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_005b;
							}
							break;
						}
						goto IL_007d;
						IL_0099:
						num2 = (_003C_003E1__state = 0);
						UOrmI0sq3IfiHU4UBFNx();
						num3 = ((!zFEPIAsqrxyeiXhCWVwc()) ? 5 : 7);
						goto IL_010b;
						IL_007d:
						_003C_003Eu__1 = default;
						num3 = 8;
						if (!zFEPIAsqrxyeiXhCWVwc())
						{
							goto IL_0099;
						}
						goto IL_010b;
						end_IL_005b:;
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
		internal static TaskAwaiter BE51jEsqOeHsDvigpJn4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zFEPIAsqrxyeiXhCWVwc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UOrmI0sq3IfiHU4UBFNx()
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

		public UndoBoolPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CeditBoolLoc_003E5__2;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!PapR68sqQLm7DnLesJkh())
			{
				num = 2;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0453;
			IL_003d:
			UndoBoolPropertyAction undoBoolPropertyAction = _003C_003E4__this;
			num = 5;
			if (PapR68sqQLm7DnLesJkh())
			{
				goto IL_0054;
			}
			goto IL_0453;
			IL_0453:
			int num2 = default;
			CvsCellLocation dropLocation = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 1:
				case 3:
					goto IL_003d;
				case 4:
					goto IL_0054;
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							dropLocation = undoBoolPropertyAction.DropLocation;
							num3 = 13;
							goto IL_00d5;
						case 1:
							awaiter = _003C_003Eu__1;
							goto IL_028c;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 20;
							if (PapR68sqQLm7DnLesJkh())
							{
							}
							goto IL_00d5;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 12;
								if (0 == 0)
								{
									goto IL_00d5;
								}
								goto IL_020a;
							}
							IL_00d5:
							while (true)
							{
								switch (num3)
								{
								case 24:
									num2 = (_003C_003E1__state = -1);
									goto IL_009f;
								case 16:
									return;
								default:
									num3 = 8;
									continue;
								case 11:
									return;
								case 6:
									yks8mKsquhHHp7yh3lfE(undoBoolPropertyAction.InSight, _003CeditBoolLoc_003E5__2, undoBoolPropertyAction.AIp49VWiKP.Value);
									num3 = 9;
									continue;
								case 17:
									awaiter.GetResult();
									num3 = 23;
									continue;
								case 10:
									if (undoBoolPropertyAction.AIp49VWiKP.HasValue)
									{
										awaiter = ((CvsCogSocketSheet)N6tIEosqlJhGf0Zw87lB(undoBoolPropertyAction.InSight.CogSocket)).PutCellExpressionAsync(dropLocation, undoBoolPropertyAction.jMn4mjK3Nf).GetAwaiter();
										num3 = 21;
										continue;
									}
									awaiter = ((CvsCogSocket)PaDLbHsqenpOK1I5xkhF(undoBoolPropertyAction.InSight)).Sheet.PutCellExpressionAsync(_003CeditBoolLoc_003E5__2, undoBoolPropertyAction.d0W4nuSlo3).GetAwaiter();
									_ = 0;
									if (s5rkpdsqMATuUWqP27sQ())
									{
										num3 = 3;
										continue;
									}
									num3 = 14;
									if (!PapR68sqQLm7DnLesJkh())
									{
										continue;
									}
									goto case 21;
								case 25:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 22:
									break;
								case 13:
									goto IL_023d;
								case 23:
									((CvsCogSocketSheet)N6tIEosqlJhGf0Zw87lB(PaDLbHsqenpOK1I5xkhF(undoBoolPropertyAction.InSight))).Run(true);
									num3 = 6;
									continue;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 11;
									continue;
								case 8:
									goto IL_028c;
								case 14:
								case 19:
									goto IL_02a4;
								case 5:
									goto IL_02b7;
								case 12:
									_003C_003Eu__1 = default;
									num3 = 4;
									continue;
								case 15:
									num2 = (_003C_003E1__state = -1);
									num3 = 17;
									continue;
								case 20:
									_003C_003Eu__1 = default;
									num3 = 24;
									continue;
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 1;
									if (true)
									{
										continue;
									}
									goto case 1;
								case 1:
									awaiter.GetResult();
									_003CeditBoolLoc_003E5__2.Row++;
									num3 = 22;
									continue;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									goto case 17;
								case 3:
								case 18:
									if (awaiter.IsCompleted)
									{
										goto IL_009f;
									}
									num2 = (_003C_003E1__state = 2);
									goto IL_02a4;
								case 21:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										num3 = 25;
										continue;
									}
									goto case 1;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 16;
									continue;
								case 9:
								case 26:
									{
										undoBoolPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
										goto end_IL_0074;
									}
									IL_009f:
									awaiter.GetResult();
									num3 = 26;
									if (s5rkpdsqMATuUWqP27sQ())
									{
										continue;
									}
									return;
								}
								break;
							}
							goto IL_020a;
							IL_028c:
							_003C_003Eu__1 = default;
							num3 = 15;
							if (true)
							{
								goto IL_00d5;
							}
							goto IL_02a4;
							IL_02a4:
							_003C_003Eu__1 = awaiter;
							num3 = 0;
							if (0 == 0)
							{
								goto IL_00d5;
							}
							goto IL_02b7;
							IL_02b7:
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							num3 = 7;
							goto IL_00d5;
							IL_020a:
							awaiter = ((CvsCogSocketSheet)N6tIEosqlJhGf0Zw87lB(PaDLbHsqenpOK1I5xkhF(undoBoolPropertyAction.InSight))).PutCellExpressionAsync(_003CeditBoolLoc_003E5__2, undoBoolPropertyAction.d0W4nuSlo3).GetAwaiter();
							num3 = 2;
							if (0 == 0)
							{
								goto IL_00d5;
							}
							goto IL_023d;
							IL_023d:
							_003CeditBoolLoc_003E5__2 = undoBoolPropertyAction.DropLocation;
							num3 = 10;
							goto IL_00d5;
							end_IL_0074:
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
					goto IL_0054;
				default:
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num2 = _003C_003E1__state;
			goto IL_003d;
			IL_0054:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (PapR68sqQLm7DnLesJkh())
			{
			}
			goto IL_0453;
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
		internal static object N6tIEosqlJhGf0Zw87lB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PaDLbHsqenpOK1I5xkhF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yks8mKsquhHHp7yh3lfE(object P_0, CvsCellLocation location, bool cellValue)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).SetCheckBox(location, cellValue);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s5rkpdsqMATuUWqP27sQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PapR68sqQLm7DnLesJkh()
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

		public UndoBoolPropertyAction _003C_003E4__this;

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
			int num = 5;
			if (!LuJq7qsqRXnZ6M1xYfHT())
			{
			}
			UndoBoolPropertyAction undoBoolPropertyAction = default;
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				IL_02cf:
				switch (num)
				{
				case 0:
				case 1:
					undoBoolPropertyAction = _003C_003E4__this;
					goto case 2;
				case 5:
					while (true)
					{
						num2 = _003C_003E1__state;
						dSdd8tsqIg2EqtO7GCCd();
						if (!LuJq7qsqRXnZ6M1xYfHT())
						{
							break;
						}
						num = 3;
						if (1 == 0)
						{
							continue;
						}
						goto IL_02cf;
					}
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							modifiedCells = undoBoolPropertyAction.ModifiedCells;
							LuJq7qsqRXnZ6M1xYfHT();
							num3 = ((!dSdd8tsqIg2EqtO7GCCd()) ? 7 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
							if (1 == 0)
							{
								goto IL_01e9;
							}
						}
						goto IL_00c2;
						IL_00c2:
						while (true)
						{
							switch (num3)
							{
							case 7:
							case 9:
								num2 = (_003C_003E1__state = -1);
								goto IL_008e;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 8:
								_003C_003E7__wrap2++;
								num3 = 4;
								if (dSdd8tsqIg2EqtO7GCCd())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003E7__wrap1 = null;
								num3 = 15;
								if (dSdd8tsqIg2EqtO7GCCd())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 5:
								_003C_003E7__wrap1 = modifiedCells;
								num3 = 1;
								if (!LuJq7qsqRXnZ6M1xYfHT())
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter = ((CvsCogSocketSheet)Tw2dJKsqnrpyuwuDin47(meCulisqaJuAAyLexpDe(undoBoolPropertyAction.InSight))).ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 13;
								continue;
							case 1:
								_003C_003E7__wrap2 = 0;
								goto case 4;
							case 4:
								if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
								{
									cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
									num3 = 6;
									continue;
								}
								num3 = 2;
								if (!dSdd8tsqIg2EqtO7GCCd())
								{
									return;
								}
								continue;
							case 3:
								return;
							case 6:
								break;
							case 13:
								if (awaiter.IsCompleted)
								{
									goto IL_008e;
								}
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = default;
								goto case 7;
							case 14:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								{
									undoBoolPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
									goto end_IL_00c2;
								}
								IL_008e:
								awaiter.GetResult();
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							}
							goto IL_01e9;
							continue;
							end_IL_00c2:
							break;
						}
						goto end_IL_005e;
						IL_01e9:
						cellRange = new CvsCellRange(undoBoolPropertyAction.DropLocation.Row + cvsCellRange.Row, undoBoolPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
						num3 = 11;
						goto IL_00c2;
						end_IL_005e:;
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
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
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
		internal static object meCulisqaJuAAyLexpDe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Tw2dJKsqnrpyuwuDin47(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dSdd8tsqIg2EqtO7GCCd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LuJq7qsqRXnZ6M1xYfHT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellRange Iay4Y5aesr;

	private CvsCellRange T6547TcpSg;

	private string jMn4mjK3Nf;

	private string d0W4nuSlo3;

	private bool? AIp49VWiKP;

	[CompilerGenerated]
	private CvsInSight HkO4UWCjOD;

	private CvsCellLocation U3540GXbHH;

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
			return HkO4UWCjOD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HkO4UWCjOD = value;
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
			return U3540GXbHH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsCellRange t6547TcpSg = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					t6547TcpSg = new CvsCellRange(U3540GXbHH.Row, U3540GXbHH.Column, 1, 1);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 6;
				case 6:
					if (AIp49VWiKP.HasValue)
					{
						goto case 0;
					}
					goto case 3;
				default:
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
					t6547TcpSg.Row++;
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					T6547TcpSg = t6547TcpSg;
					num = 8;
					break;
				case 5:
					if (!value.IsValid)
					{
						return;
					}
					LXfA6NWOfAIJGyhOUQb();
					if (xkFndDW3QDMU7lyh5bn())
					{
						num = 7;
						if (xkFndDW3QDMU7lyh5bn())
						{
							break;
						}
						goto case 1;
					}
					num = 4;
					if (1 == 0)
					{
						return;
					}
					break;
				case 1:
				case 7:
					U3540GXbHH = value;
					goto case 2;
				case 8:
					return;
				}
			}
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
			return new CvsCellRange[1] { Iay4Y5aesr };
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
			return T6547TcpSg;
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
			return Resources.DropBoolean;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoBoolPropertyAction(string name, string editBoolExpression, bool? currentValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		Iay4Y5aesr = new CvsCellRange(0, 0, 1, 1);
		T6547TcpSg = CvsCellRange.Invalid;
		U3540GXbHH = CvsCellLocation.Invalid;
		base._002Ector();
		jMn4mjK3Nf = string.Format(kgbOBx7BanbFa22Hp9.ol99ukmDA(16904), name);
		d0W4nuSlo3 = editBoolExpression;
		AIp49VWiKP = currentValue;
		if (AIp49VWiKP.HasValue)
		{
			Iay4Y5aesr.Rows++;
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
		xkFndDW3QDMU7lyh5bn();
		int num = (LXfA6NWOfAIJGyhOUQb() ? 2 : 3);
		_003CSaveState_003Ed__20 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = osTIF4WMFbZ2Ojvl5Pw();
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__21))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (LXfA6NWOfAIJGyhOUQb() ? 4 : 3);
		_003CDo_003Ed__21 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = osTIF4WMFbZ2Ojvl5Pw();
				num = 5;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
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
		xkFndDW3QDMU7lyh5bn();
		int num = (LXfA6NWOfAIJGyhOUQb() ? 2 : 4);
		_003CRedo_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
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
		_ = 1;
		int num = (LXfA6NWOfAIJGyhOUQb() ? 1 : 5);
		_003CUndo_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = osTIF4WMFbZ2Ojvl5Pw();
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xkFndDW3QDMU7lyh5bn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LXfA6NWOfAIJGyhOUQb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder osTIF4WMFbZ2Ojvl5Pw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
