using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoApplyAcquisitionSettingsPropertyAction<T> : IUndoPropertyAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__24 : IAsyncStateMachine
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
					_ = 0;
					num = (true ? 4 : 0);
					continue;
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Task.CompletedTask.GetAwaiter();
							_ = 0;
							num3 = ((1 == 0) ? 6 : 8);
							goto IL_00b0;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0114;
						IL_00b0:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 9;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 7:
								return;
							case 5:
							case 6:
								break;
							case 9:
								awaiter.GetResult();
								goto end_IL_00b0;
							}
							goto IL_0114;
							continue;
							end_IL_00b0:
							break;
						}
						goto end_IL_0031;
						IL_0114:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_00b0;
						end_IL_0031:;
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
		internal static bool r428Nasi6p0bIExHqrJp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RGOp3IsipAUVLKcJ5B2A()
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
	private struct _003CDo_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoApplyAcquisitionSettingsPropertyAction<T> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 2 : 4);
			UndoApplyAcquisitionSettingsPropertyAction<T> undoApplyAcquisitionSettingsPropertyAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					undoApplyAcquisitionSettingsPropertyAction = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoApplyAcquisitionSettingsPropertyAction.Redo().GetAwaiter();
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								num3 = (true ? 7 : 0);
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
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
		internal static bool RKCjnysi0ZphbBAPMHV8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NjGQRxsi4PRDu3iKHfsM()
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
	private struct _003CRedo_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoApplyAcquisitionSettingsPropertyAction<T> _003C_003E4__this;

		private CvsCellLocation _003CapplyAcqSettingLoc_003E5__2;

		private CvsCellLocation _003ClabelLoc_003E5__3;

		private CvsCellLocation _003CeditLoc_003E5__4;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			UndoApplyAcquisitionSettingsPropertyAction<T> undoApplyAcquisitionSettingsPropertyAction = default;
			TaskAwaiter<object> awaiter2 = default;
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
						switch (num2)
						{
						default:
							_003CapplyAcqSettingLoc_003E5__2 = undoApplyAcquisitionSettingsPropertyAction.DropLocation;
							num3 = 10;
							break;
						case 2:
							awaiter2 = _003C_003Eu__1;
							num3 = 26;
							break;
						case 1:
							awaiter2 = _003C_003Eu__1;
							num3 = 29;
							break;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 34;
							break;
						case 3:
							awaiter = _003C_003Eu__2;
							num3 = 14;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								awaiter2.GetResult();
								awaiter2 = undoApplyAcquisitionSettingsPropertyAction.InSight.CogSocket.Sheet.PutCellExpressionAsync(_003ClabelLoc_003E5__3, undoApplyAcquisitionSettingsPropertyAction.HBN4qcWgSV).GetAwaiter();
								num3 = 7;
								continue;
							case 12:
								_003C_003Eu__2 = awaiter;
								num3 = 16;
								continue;
							case 13:
								awaiter2 = undoApplyAcquisitionSettingsPropertyAction.InSight.CogSocket.Sheet.PutCellExpressionAsync(_003CapplyAcqSettingLoc_003E5__2, string.Format(undoApplyAcquisitionSettingsPropertyAction.sKl4Ti8mCc, _003CeditLoc_003E5__4.ToString(absoluteRow: true, absoluteColumn: true))).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 5;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 17:
								if (!awaiter.IsCompleted)
								{
									num3 = 18;
									continue;
								}
								goto case 30;
							case 7:
								if (!awaiter2.IsCompleted)
								{
									_ = 0;
									num3 = ((1 == 0) ? 27 : 2);
									continue;
								}
								goto case 8;
							case 26:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 21;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 22;
								continue;
							case 10:
								_003ClabelLoc_003E5__3 = undoApplyAcquisitionSettingsPropertyAction.DropLocation;
								num3 = 1;
								continue;
							case 32:
								return;
							case 34:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 24:
								return;
							case 19:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 30:
								awaiter.GetResult();
								undoApplyAcquisitionSettingsPropertyAction.InSight.CogSocket.Sheet.Run(null);
								num3 = 36;
								continue;
							case 22:
								_003C_003Eu__1 = awaiter2;
								num3 = 19;
								continue;
							case 35:
								_003CeditLoc_003E5__4.Row += 2;
								num3 = 13;
								continue;
							case 8:
								awaiter2.GetResult();
								num3 = 3;
								continue;
							case 28:
								if (!awaiter2.IsCompleted)
								{
									goto case 25;
								}
								goto case 21;
							default:
								num3 = 25;
								continue;
							case 20:
								undoApplyAcquisitionSettingsPropertyAction.InSight.SetCheckBox(_003CeditLoc_003E5__4, (bool)(object)undoApplyAcquisitionSettingsPropertyAction.jCa4BC39t2);
								goto case 33;
							case 33:
								awaiter = undoApplyAcquisitionSettingsPropertyAction.InSight.CogSocket.Sheet.SetBoundArgsAsync(_003CapplyAcqSettingLoc_003E5__2, new string[1] { undoApplyAcquisitionSettingsPropertyAction.w2Z4g9l64s }).GetAwaiter();
								num3 = 17;
								continue;
							case 0:
								undoApplyAcquisitionSettingsPropertyAction.InSight.SetInteger(_003CeditLoc_003E5__4, (int)(object)undoApplyAcquisitionSettingsPropertyAction.jCa4BC39t2);
								goto case 33;
							case 18:
								num2 = (_003C_003E1__state = 3);
								num3 = 12;
								continue;
							case 23:
								undoApplyAcquisitionSettingsPropertyAction.InSight.SetFloat(_003CeditLoc_003E5__4, (double)(object)undoApplyAcquisitionSettingsPropertyAction.jCa4BC39t2);
								num3 = 33;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 32;
								continue;
							case 29:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 31:
								return;
							case 25:
								num2 = (_003C_003E1__state = 2);
								num3 = 9;
								continue;
							case 3:
								awaiter2 = undoApplyAcquisitionSettingsPropertyAction.InSight.CogSocket.Sheet.PutCellExpressionAsync(_003CeditLoc_003E5__4, undoApplyAcquisitionSettingsPropertyAction.gGT4JT5jG2).GetAwaiter();
								num3 = 28;
								continue;
							case 2:
							case 11:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 24;
								continue;
							case 27:
								return;
							case 4:
								if (!(typeof(T) == typeof(int)))
								{
									if (!(typeof(T) == typeof(double)))
									{
										if (typeof(T) == typeof(bool))
										{
											num3 = 20;
											continue;
										}
										goto case 33;
									}
									num3 = 23;
									continue;
								}
								num3 = 0;
								continue;
							case 21:
								awaiter2.GetResult();
								undoApplyAcquisitionSettingsPropertyAction.InSight.CogSocket.Sheet.Run(null);
								num3 = 4;
								continue;
							case 1:
								_003ClabelLoc_003E5__3.Row++;
								_003CeditLoc_003E5__4 = undoApplyAcquisitionSettingsPropertyAction.DropLocation;
								num3 = 35;
								continue;
							case 14:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 30;
								continue;
							case 36:
								undoApplyAcquisitionSettingsPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
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
					break;
				default:
					num = 4;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((1 == 0) ? 3 : 5);
					continue;
				case 1:
				case 5:
					undoApplyAcquisitionSettingsPropertyAction = _003C_003E4__this;
					goto case 2;
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
		internal static bool djgdyQsikfq2AyUHEpsQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EQwOFssifyFJodPUaj5X()
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
	private struct _003CUndo_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoApplyAcquisitionSettingsPropertyAction<T> _003C_003E4__this;

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
			_ = 0;
			int num = ((1 == 0) ? 2 : 5);
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			UndoApplyAcquisitionSettingsPropertyAction<T> undoApplyAcquisitionSettingsPropertyAction = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							modifiedCells = undoApplyAcquisitionSettingsPropertyAction.ModifiedCells;
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 13;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								awaiter = undoApplyAcquisitionSettingsPropertyAction.InSight.CogSocket.Sheet.ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 7;
								continue;
							case 4:
								_003C_003E7__wrap2++;
								goto case 0;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 5:
								_003C_003E7__wrap1 = modifiedCells;
								num3 = 3;
								continue;
							case 11:
								cellRange = new CvsCellRange(undoApplyAcquisitionSettingsPropertyAction.DropLocation.Row + cvsCellRange.Row, undoApplyAcquisitionSettingsPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								num3 = 6;
								continue;
							case 13:
								awaiter.GetResult();
								num3 = 4;
								continue;
							case 9:
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 3:
								_003C_003E7__wrap2 = 0;
								goto case 0;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 0:
							case 12:
								if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
								{
									cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
									num3 = 11;
								}
								else
								{
									_003C_003E7__wrap1 = null;
									num3 = 15;
								}
								continue;
							case 10:
								_003C_003Eu__1 = default;
								_ = 0;
								num3 = (true ? 14 : 0);
								continue;
							case 15:
								undoApplyAcquisitionSettingsPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
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
				case 4:
					undoApplyAcquisitionSettingsPropertyAction = _003C_003E4__this;
					num = 1;
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
		internal static bool GZDHl1siFTSCqwBRXNSE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RCtKodsimkF4mgExiwMu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellRange UIp4l0jWAO;

	private string w2Z4g9l64s;

	private string HBN4qcWgSV;

	private string sKl4Ti8mCc;

	private T jCa4BC39t2;

	private string gGT4JT5jG2;

	[CompilerGenerated]
	private CvsInSight pxg4MLqDMK;

	private CvsCellLocation RSx4o5aBJq;

	[CompilerGenerated]
	private CvsCellRange gPE4AS3mqn;

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
			return pxg4MLqDMK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pxg4MLqDMK = value;
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
			return RSx4o5aBJq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (value.IsValid)
					{
						_ = 0;
						num = ((1 == 0) ? 4 : 0);
						continue;
					}
					return;
				case 0:
				case 1:
					RSx4o5aBJq = value;
					break;
				case 5:
					return;
				}
				ValuesRange = new CvsCellRange(RSx4o5aBJq.Row + 2, RSx4o5aBJq.Column, 1, 1);
				num = 5;
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
			return new CvsCellRange[1] { UIp4l0jWAO };
		}
	}

	public CvsCellRange ValuesRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gPE4AS3mqn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gPE4AS3mqn = value;
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
			return Resources.DropApplyAcquisitionSettings;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoApplyAcquisitionSettingsPropertyAction(string id, string expression, UndoPropertyActionArgs<T> args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		UIp4l0jWAO = new CvsCellRange(0, 0, 3, 1);
		RSx4o5aBJq = CvsCellLocation.Invalid;
		gPE4AS3mqn = CvsCellRange.Invalid;
		base._002Ector();
		w2Z4g9l64s = id;
		HBN4qcWgSV = args.LabelExpression;
		sKl4Ti8mCc = expression;
		gGT4JT5jG2 = args.EditExpression;
		jCa4BC39t2 = (T)Convert.ChangeType(args.CurrentValue, typeof(T));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoApplyAcquisitionSettingsPropertyAction(string id, string expression, string editExpression, T currentValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		UIp4l0jWAO = new CvsCellRange(0, 0, 3, 1);
		RSx4o5aBJq = CvsCellLocation.Invalid;
		gPE4AS3mqn = CvsCellRange.Invalid;
		base._002Ector();
		w2Z4g9l64s = id;
		HBN4qcWgSV = kgbOBx7BanbFa22Hp9.ol99ukmDA(16876) + id;
		sKl4Ti8mCc = expression;
		gGT4JT5jG2 = editExpression;
		jCa4BC39t2 = currentValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoApplyAcquisitionSettingsPropertyAction<>._003CSaveState_003Ed__24))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((1 == 0) ? 2 : 3);
		_003CSaveState_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoApplyAcquisitionSettingsPropertyAction<>._003CDo_003Ed__25))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__25 stateMachine = default;
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
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = (true ? 3 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoApplyAcquisitionSettingsPropertyAction<>._003CRedo_003Ed__26))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CRedo_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 0;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (true ? 5 : 4);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoApplyAcquisitionSettingsPropertyAction<>._003CUndo_003Ed__27))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CUndo_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = (true ? 3 : 5);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JmsB3qWBCr8wCl1YrFX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Cnt0HfWjnkD9TwQp1Ip()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
