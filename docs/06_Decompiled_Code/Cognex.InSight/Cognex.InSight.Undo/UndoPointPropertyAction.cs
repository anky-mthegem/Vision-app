using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoPointPropertyAction : IUndoPropertyAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__23 : IAsyncStateMachine
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
			int num = 0;
			if (!skIQTks5Kug4iwDcABrw())
			{
			}
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = tSmPkls5oF7tPnaLeOuu(q9TmQVs558NHYd8ve6i9());
							skIQTks5Kug4iwDcABrw();
							if (IqnK49s5COK0gawlglKK())
							{
								num3 = 5;
								if (false)
								{
									goto IL_004f;
								}
							}
							else
							{
								num3 = 2;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (!IqnK49s5COK0gawlglKK())
							{
								goto IL_0131;
							}
						}
						goto IL_00b5;
						IL_0095:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_00b5:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 6:
								goto IL_0068;
							case 0:
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_0131;
							case 2:
							case 3:
								goto IL_0095;
							default:
								num3 = 1;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 1:
								return;
							case 9:
								goto IL_0131;
							}
							break;
						}
						goto IL_004f;
						IL_0068:
						_003C_003Eu__1 = awaiter;
						goto IL_0095;
						IL_0131:
						awaiter.GetResult();
						goto end_IL_0022;
						IL_004f:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (!IqnK49s5COK0gawlglKK())
						{
							goto IL_0068;
						}
						goto IL_00b5;
						end_IL_0022:;
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
					num = 5;
					break;
				case 0:
					num2 = _003C_003E1__state;
					IqnK49s5COK0gawlglKK();
					num = ((!skIQTks5Kug4iwDcABrw()) ? 4 : 3);
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
		internal static object q9TmQVs558NHYd8ve6i9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tSmPkls5oF7tPnaLeOuu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IqnK49s5COK0gawlglKK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool skIQTks5Kug4iwDcABrw()
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
	private struct _003CDo_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPointPropertyAction _003C_003E4__this;

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
			UndoPointPropertyAction undoPointPropertyAction = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					uwqiINs5PPunn8kFyF2e();
					num = ((!l3rLhSs5YaYUlqi5Py90()) ? 4 : 0);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					undoPointPropertyAction = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoPointPropertyAction.Redo().GetAwaiter();
							num3 = 1;
							goto IL_00fa;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0153;
						IL_0153:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_00fa;
						IL_00fa:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								num3 = ((!l3rLhSs5YaYUlqi5Py90()) ? 6 : 0);
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
								return;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 3:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								if (!l3rLhSs5YaYUlqi5Py90())
								{
									continue;
								}
								goto case 1;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									if (uwqiINs5PPunn8kFyF2e())
									{
										continue;
									}
									break;
								}
								goto case 9;
							case 0:
							case 5:
								break;
							case 9:
								awaiter.GetResult();
								goto end_IL_00fa;
							}
							goto IL_0153;
							continue;
							end_IL_00fa:
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
		internal static bool uwqiINs5PPunn8kFyF2e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l3rLhSs5YaYUlqi5Py90()
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
	private struct _003CRedo_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPointPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CeditPointloc_003E5__2;

		private CvsCellLocation _003ClabelLoc_003E5__3;

		private CvsCellLocation _003CgetterLoc_003E5__4;

		private TaskAwaiter<object> _003C_003Eu__1;

		private int _003Ci_003E5__5;

		private TaskAwaiter<CvsCogEditInfo[]> _003C_003Eu__2;

		private CvsCogEditingObject _003CeditingObj_003E5__6;

		private TaskAwaiter<CvsCogEditingObject> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (VhbNV5s5NjImCDSqj7eg())
			{
				num = 4;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 1;
				if (hu5m26s5xjIMiy8osKMr())
				{
					return;
				}
			}
			goto IL_0511;
			IL_0026:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0511;
			IL_0511:
			UndoPointPropertyAction undoPointPropertyAction = default;
			CvsCogEditInfo[] result = default;
			int num2 = default;
			TaskAwaiter<CvsCogEditingObject> awaiter3 = default;
			CvsCogEditingObject result2 = default;
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
						TaskAwaiter<object> awaiter2;
						TaskAwaiter<CvsCogEditInfo[]> awaiter;
						switch (num2)
						{
						default:
							_003CeditPointloc_003E5__2 = undoPointPropertyAction.DropLocation;
							_003CeditPointloc_003E5__2.Row++;
							awaiter2 = ((CvsCogSocketSheet)qBseDJs5rjktRHVDy4sW(WSHAVBs51Q9HoGDc8UvB(undoPointPropertyAction.InSight))).PutCellExpressionAsync(_003CeditPointloc_003E5__2, undoPointPropertyAction.wLpgvNbvgW).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00e6;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00e6;
						case 1:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01b1;
						case 2:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0248;
						case 3:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0329;
						case 4:
							break;
							IL_0329:
							result = awaiter.GetResult();
							if (result != null && result.Length != 0)
							{
								_003CeditingObj_003E5__6 = null;
								break;
							}
							goto end_IL_003b;
							IL_00e6:
							awaiter2.GetResult();
							_003ClabelLoc_003E5__3 = undoPointPropertyAction.DropLocation;
							_003ClabelLoc_003E5__3.Column++;
							_003CgetterLoc_003E5__4 = _003ClabelLoc_003E5__3;
							_003CgetterLoc_003E5__4.Row++;
							_003Ci_003E5__5 = 0;
							goto IL_0290;
							IL_0290:
							if (_003Ci_003E5__5 < undoPointPropertyAction.p4MgrdyWee.Length)
							{
								awaiter2 = ((CvsCogSocketSheet)qBseDJs5rjktRHVDy4sW(WSHAVBs51Q9HoGDc8UvB(undoPointPropertyAction.InSight))).PutCellExpressionAsync(_003ClabelLoc_003E5__3, undoPointPropertyAction.nLHgSAaXk8[_003Ci_003E5__5]).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_01b1;
							}
							((CvsCogSocketSheet)qBseDJs5rjktRHVDy4sW(undoPointPropertyAction.InSight.CogSocket)).Run(true);
							awaiter = ((CvsCogSocketSheet)qBseDJs5rjktRHVDy4sW(WSHAVBs51Q9HoGDc8UvB(undoPointPropertyAction.InSight))).GetEditInfoAsync(_003CeditPointloc_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0329;
							IL_01b1:
							awaiter2.GetResult();
							awaiter2 = ((CvsCogSocketSheet)qBseDJs5rjktRHVDy4sW(WSHAVBs51Q9HoGDc8UvB(undoPointPropertyAction.InSight))).PutCellExpressionAsync(_003CgetterLoc_003E5__4, (string)pe48SUs53FBl4nIkompB(undoPointPropertyAction.p4MgrdyWee[_003Ci_003E5__5], _003CeditPointloc_003E5__2.ToString())).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0248;
							IL_0248:
							awaiter2.GetResult();
							_003Ci_003E5__5++;
							_003ClabelLoc_003E5__3.Column++;
							_003CgetterLoc_003E5__4.Column++;
							goto IL_0290;
						}
						try
						{
							int num3;
							if (num2 != 4)
							{
								hu5m26s5xjIMiy8osKMr();
								num3 = ((!VhbNV5s5NjImCDSqj7eg()) ? 4 : 6);
							}
							else
							{
								awaiter3 = _003C_003Eu__3;
								num3 = 3;
							}
							while (true)
							{
								switch (num3)
								{
								case 2:
								case 4:
									num2 = (_003C_003E1__state = 4);
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 5;
									continue;
								case 0:
								case 6:
									awaiter3 = ((CvsCogSocket)WSHAVBs51Q9HoGDc8UvB(undoPointPropertyAction.InSight)).Sheet.EditEditableObjectAsync((string)sfyRW5s5OVEIQKBRse01(result[0])).GetAwaiter();
									num3 = 9;
									continue;
								case 7:
									return;
								case 8:
									_003C_003Eu__3 = awaiter3;
									goto case 1;
								default:
									num3 = 1;
									if (hu5m26s5xjIMiy8osKMr())
									{
									}
									continue;
								case 9:
									if (!awaiter3.IsCompleted)
									{
										goto case 2;
									}
									goto case 5;
								case 5:
									result2 = awaiter3.GetResult();
									num3 = 10;
									continue;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 7;
									continue;
								case 10:
									_003CeditingObj_003E5__6 = result2;
									break;
								}
								break;
							}
						}
						catch (Exception)
						{
						}
						if (_003CeditingObj_003E5__6 is CvsCogEditingShape cvsCogEditingShape)
						{
							YKRXqws5QesPxiIWMjdr(qBseDJs5rjktRHVDy4sW(WSHAVBs51Q9HoGDc8UvB(undoPointPropertyAction.InSight)), svKfXUs5M3SoIWpFcIWY(cvsCogEditingShape), undoPointPropertyAction.mfRgZOg5IN);
						}
						_003CeditingObj_003E5__6 = null;
						end_IL_003b:;
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
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					undoPointPropertyAction = _003C_003E4__this;
					goto case 1;
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
		internal static object WSHAVBs51Q9HoGDc8UvB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qBseDJs5rjktRHVDy4sW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pe48SUs53FBl4nIkompB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sfyRW5s5OVEIQKBRse01(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object svKfXUs5M3SoIWpFcIWY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditingObject)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YKRXqws5QesPxiIWMjdr(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ApplyEditableObjectAndRunSheet((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VhbNV5s5NjImCDSqj7eg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hu5m26s5xjIMiy8osKMr()
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
	private struct _003CUndo_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPointPropertyAction _003C_003E4__this;

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
			int num = (vKNom7s5e723SYKsR51c() ? 3 : 4);
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			UndoPointPropertyAction undoPointPropertyAction = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cvsCellRange = default;
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
							modifiedCells = undoPointPropertyAction.ModifiedCells;
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 10:
							{
								CvsCellRange cellRange = new CvsCellRange(undoPointPropertyAction.DropLocation.Row + cvsCellRange.Row, undoPointPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								awaiter = undoPointPropertyAction.InSight.CogSocket.Sheet.ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 13;
								continue;
							}
							case 1:
								_003C_003Eu__1 = default;
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003E7__wrap1 = modifiedCells;
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 14;
							case 14:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = ((!MvgVRVs5lrLKedCp5sqx()) ? 2 : 3);
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 11;
								continue;
							case 0:
								awaiter.GetResult();
								goto case 2;
							case 11:
								return;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 3:
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 13:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto case 0;
							case 2:
							case 12:
								_003C_003E7__wrap2++;
								goto case 4;
							case 4:
								if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
								{
									cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
									num3 = 10;
								}
								else
								{
									_003C_003E7__wrap1 = null;
									num3 = 15;
								}
								continue;
							case 8:
								_003C_003E7__wrap2 = 0;
								num3 = 4;
								continue;
							case 15:
								undoPointPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
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
					goto case 1;
				default:
					num = 1;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					undoPointPropertyAction = _003C_003E4__this;
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
		internal static bool MvgVRVs5lrLKedCp5sqx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vKNom7s5e723SYKsR51c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private string[] nLHgSAaXk8;

	private string[] p4MgrdyWee;

	private CvsCellRange zingCUVWc4;

	private CvsCellRange o1ng2kvR0B;

	private CvsCellRange EtggyWaZ0L;

	private CvsCellRange abSgVNFMy5;

	private string wLpgvNbvgW;

	private CvsCogPoint mfRgZOg5IN;

	[CompilerGenerated]
	private CvsInSight tgGg8nA0xq;

	private CvsCellLocation jURgzF8KTv;

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
			return tgGg8nA0xq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tgGg8nA0xq = value;
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
			return jURgzF8KTv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					abSgVNFMy5 = new CvsCellRange(jURgzF8KTv.Row + o1ng2kvR0B.Row, jURgzF8KTv.Column + o1ng2kvR0B.Column, o1ng2kvR0B.Rows, o1ng2kvR0B.Columns);
					num = 5;
					break;
				case 1:
				case 4:
					jURgzF8KTv = value;
					goto default;
				case 0:
					if (value.IsValid)
					{
						_ = 0;
						num = (E4iQr1C2nBhKcjXd68l() ? 4 : 3);
						break;
					}
					return;
				case 5:
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
			return new CvsCellRange[2] { zingCUVWc4, EtggyWaZ0L };
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
			return abSgVNFMy5;
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
			return (string)VcBjOUCKgbjUjeL6Tx3();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoPointPropertyAction(string editPointExpression, CvsCogPoint point)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 11:
				abSgVNFMy5 = CvsCellRange.Invalid;
				num = 8;
				if (E4iQr1C2nBhKcjXd68l())
				{
					break;
				}
				goto case 7;
			case 7:
				p4MgrdyWee = new string[2]
				{
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16950),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16972)
				};
				num = 11;
				if (0 == 0)
				{
					break;
				}
				goto case 8;
			case 8:
				jURgzF8KTv = CvsCellLocation.Invalid;
				gJbCOkCWllGBF19L7R3();
				num = ((!E4iQr1C2nBhKcjXd68l()) ? 3 : 9);
				break;
			default:
				wLpgvNbvgW = editPointExpression;
				mfRgZOg5IN = point;
				num = 10;
				break;
			case 10:
				zingCUVWc4 = new CvsCellRange(0, 1, 1, nLHgSAaXk8.Length);
				num = 4;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				nLHgSAaXk8 = new string[2]
				{
					(string)iutuITCtKa6pwIJKWWP(16916),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16924)
				};
				num = 7;
				if (E4iQr1C2nBhKcjXd68l())
				{
					break;
				}
				goto case 4;
			case 4:
				o1ng2kvR0B = new CvsCellRange(1, 1, 1, p4MgrdyWee.Length);
				num = 0;
				break;
			case 5:
			case 9:
				dG8JSpCCcr9a1em2AHS(this);
				goto default;
			case 2:
				JYN52EC7jOFRQxT8Lwc();
				num = 1;
				break;
			case 0:
				EtggyWaZ0L = new CvsCellRange(1, 0, 1, p4MgrdyWee.Length + 1);
				num = 12;
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__23))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gJbCOkCWllGBF19L7R3();
		int num = ((!E4iQr1C2nBhKcjXd68l()) ? 3 : 4);
		_003CSaveState_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = NxrrLcC57LORL9eO6HZ();
				num = 1;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__24))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (E4iQr1C2nBhKcjXd68l())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0086;
		IL_0042:
		_003CDo_003Ed__24 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 3:
				goto IL_0042;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				if (gJbCOkCWllGBF19L7R3())
				{
				}
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		stateMachine._003C_003Et__builder = NxrrLcC57LORL9eO6HZ();
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__25))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		E4iQr1C2nBhKcjXd68l();
		int num;
		if (!gJbCOkCWllGBF19L7R3())
		{
			num = 5;
			if (!E4iQr1C2nBhKcjXd68l())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_007c;
		IL_002e:
		_003CRedo_003Ed__25 stateMachine = default;
		stateMachine._003C_003Et__builder = NxrrLcC57LORL9eO6HZ();
		goto IL_004a;
		IL_007c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				break;
			case 1:
			case 3:
				goto IL_004a;
			case 2:
				goto IL_0062;
			default:
				num = 4;
				if (E4iQr1C2nBhKcjXd68l())
				{
					continue;
				}
				goto IL_00ad;
			case 4:
				goto IL_00ad;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_004a:
		stateMachine._003C_003E4__this = this;
		num = 2;
		if (!E4iQr1C2nBhKcjXd68l())
		{
			goto IL_0062;
		}
		goto IL_007c;
		IL_00ad:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_007c;
		IL_0062:
		stateMachine._003C_003E1__state = -1;
		goto IL_00ad;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__26))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!E4iQr1C2nBhKcjXd68l()) ? 1 : 3);
		_003CUndo_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = NxrrLcC57LORL9eO6HZ();
				num = 5;
				if (!gJbCOkCWllGBF19L7R3())
				{
					break;
				}
				goto case 1;
			case 1:
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
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JYN52EC7jOFRQxT8Lwc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iutuITCtKa6pwIJKWWP(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dG8JSpCCcr9a1em2AHS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E4iQr1C2nBhKcjXd68l()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gJbCOkCWllGBF19L7R3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VcBjOUCKgbjUjeL6Tx3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DropPoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder NxrrLcC57LORL9eO6HZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
