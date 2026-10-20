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

public class UndoCirclePropertyAction : IUndoPropertyAction, IUndoAction
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
			SdZKiUsjx1axV4mCDC5h();
			int num = (EE2yu0sj1ecdk33ATpHW() ? 3 : 2);
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
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = BXY7posj3plZPCMPFccZ(nHnbb8sjr4tLKv0JwPwb());
							num3 = 0;
							goto IL_00e0;
						}
						awaiter = _003C_003Eu__1;
						goto IL_012a;
						IL_012a:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_00e0;
						IL_00e0:
						while (true)
						{
							switch (num3)
							{
							case 0:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!SdZKiUsjx1axV4mCDC5h()) ? 7 : 2);
									continue;
								}
								goto case 9;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								return;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 5:
							case 7:
								break;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_00e0;
							}
							goto IL_012a;
							continue;
							end_IL_00e0:
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
					if (EE2yu0sj1ecdk33ATpHW())
					{
					}
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
		internal static object nHnbb8sjr4tLKv0JwPwb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter BXY7posj3plZPCMPFccZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SdZKiUsjx1axV4mCDC5h()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EE2yu0sj1ecdk33ATpHW()
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

		public UndoCirclePropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DhHYeYsjMU6cV0hFs4PM();
			int num = ((!OOMK7EsjOYWR6NcZ465l()) ? 5 : 4);
			UndoCirclePropertyAction undoCirclePropertyAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					undoCirclePropertyAction = _003C_003E4__this;
					num = 3;
					if (OOMK7EsjOYWR6NcZ465l())
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (OOMK7EsjOYWR6NcZ465l())
					{
						break;
					}
					goto case 3;
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = EGa7ZRsjQDY2gb8qmdQ7(undoCirclePropertyAction.Redo());
							_ = 0;
							num3 = ((!OOMK7EsjOYWR6NcZ465l()) ? 3 : 5);
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
							case 4:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 0:
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 2:
								return;
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
					goto case 2;
				default:
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
		internal static TaskAwaiter EGa7ZRsjQDY2gb8qmdQ7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OOMK7EsjOYWR6NcZ465l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DhHYeYsjMU6cV0hFs4PM()
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

		public UndoCirclePropertyAction _003C_003E4__this;

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
			_ = 1;
			int num = (BAkaV5sjeQfVffkMPJAS() ? 2 : 4);
			UndoCirclePropertyAction undoCirclePropertyAction = default;
			CvsCogEditInfo[] result = default;
			int num2 = default;
			TaskAwaiter<CvsCogEditingObject> awaiter3 = default;
			CvsCogEditingObject result2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						TaskAwaiter<object> awaiter2;
						TaskAwaiter<CvsCogEditInfo[]> awaiter;
						switch (num2)
						{
						default:
							_003CeditPointloc_003E5__2 = undoCirclePropertyAction.DropLocation;
							_003CeditPointloc_003E5__2.Row++;
							awaiter2 = ((CvsCogSocketSheet)EvrEnNsjIwPVLAt18X2N(AJJhjcsjun6wkSLl1Cqx(undoCirclePropertyAction.InSight))).PutCellExpressionAsync(_003CeditPointloc_003E5__2, undoCirclePropertyAction.bjBlpA8mIH).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00cf;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00cf;
						case 1:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_019a;
						case 2:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0231;
						case 3:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0312;
						case 4:
							break;
							IL_0312:
							result = awaiter.GetResult();
							if (result != null && result.Length != 0)
							{
								_003CeditingObj_003E5__6 = null;
								break;
							}
							goto end_IL_0024;
							IL_00cf:
							awaiter2.GetResult();
							_003ClabelLoc_003E5__3 = undoCirclePropertyAction.DropLocation;
							_003ClabelLoc_003E5__3.Column++;
							_003CgetterLoc_003E5__4 = _003ClabelLoc_003E5__3;
							_003CgetterLoc_003E5__4.Row++;
							_003Ci_003E5__5 = 0;
							goto IL_0279;
							IL_0279:
							if (_003Ci_003E5__5 < undoCirclePropertyAction.glclxAyV0v.Length)
							{
								awaiter2 = ((CvsCogSocketSheet)EvrEnNsjIwPVLAt18X2N(AJJhjcsjun6wkSLl1Cqx(undoCirclePropertyAction.InSight))).PutCellExpressionAsync(_003ClabelLoc_003E5__3, undoCirclePropertyAction.gK2l1X0wSG[_003Ci_003E5__5]).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019a;
							}
							((CvsCogSocketSheet)EvrEnNsjIwPVLAt18X2N(AJJhjcsjun6wkSLl1Cqx(undoCirclePropertyAction.InSight))).Run(true);
							awaiter = ((CvsCogSocket)AJJhjcsjun6wkSLl1Cqx(undoCirclePropertyAction.InSight)).Sheet.GetEditInfoAsync(_003CeditPointloc_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0312;
							IL_019a:
							awaiter2.GetResult();
							awaiter2 = undoCirclePropertyAction.InSight.CogSocket.Sheet.PutCellExpressionAsync(_003CgetterLoc_003E5__4, (string)dwssJ8sjRup3OxKlq18r(undoCirclePropertyAction.glclxAyV0v[_003Ci_003E5__5], _003CeditPointloc_003E5__2.ToString())).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0231;
							IL_0231:
							awaiter2.GetResult();
							_003Ci_003E5__5++;
							_003ClabelLoc_003E5__3.Column++;
							_003CgetterLoc_003E5__4.Column++;
							goto IL_0279;
						}
						try
						{
							int num3;
							if (num2 != 4)
							{
								_ = 0;
								if (PtRxGrsjls6yc15Vs6I3())
								{
									num3 = 7;
								}
								else
								{
									num3 = 1;
									if (!PtRxGrsjls6yc15Vs6I3())
									{
										goto IL_042b;
									}
								}
							}
							else
							{
								awaiter3 = _003C_003Eu__3;
								num3 = 8;
							}
							goto IL_03b2;
							IL_045d:
							_003C_003Eu__3 = default;
							num3 = 5;
							goto IL_03b2;
							IL_03b2:
							while (true)
							{
								switch (num3)
								{
								case 0:
								case 7:
									awaiter3 = ((CvsCogSocketSheet)EvrEnNsjIwPVLAt18X2N(AJJhjcsjun6wkSLl1Cqx(undoCirclePropertyAction.InSight))).EditEditableObjectAsync((string)Xmh8RNsjaDa2wv6dMt5W(result[0])).GetAwaiter();
									num3 = 6;
									continue;
								case 6:
									if (!awaiter3.IsCompleted)
									{
										num3 = 4;
										if (0 == 0)
										{
											continue;
										}
										goto case 1;
									}
									goto IL_0444;
								case 1:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								default:
									num3 = 2;
									continue;
								case 2:
									return;
								case 4:
									num2 = (_003C_003E1__state = 4);
									_003C_003Eu__3 = awaiter3;
									goto case 1;
								case 5:
									break;
								case 9:
									goto IL_0444;
								case 8:
									goto IL_045d;
								case 10:
									_003CeditingObj_003E5__6 = result2;
									goto end_IL_032f;
								}
								break;
							}
							goto IL_042b;
							IL_0444:
							result2 = awaiter3.GetResult();
							num3 = 10;
							if (!BAkaV5sjeQfVffkMPJAS())
							{
								goto IL_03b2;
							}
							goto IL_045d;
							IL_042b:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							if (PtRxGrsjls6yc15Vs6I3())
							{
								goto IL_03b2;
							}
							goto IL_0444;
							end_IL_032f:;
						}
						catch (Exception)
						{
						}
						if (_003CeditingObj_003E5__6 is CvsCogEditingShape cvsCogEditingShape)
						{
							oPY8JnsjGfKtK1CDspYw(undoCirclePropertyAction.InSight.CogSocket.Sheet, SI5uIisjnQ5q5wSJYOhX(cvsCogEditingShape), undoCirclePropertyAction.mV6lhO5IPe);
						}
						_003CeditingObj_003E5__6 = null;
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
				case 2:
					undoCirclePropertyAction = _003C_003E4__this;
					num = 3;
					continue;
				case 5:
					break;
				case 0:
				case 4:
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
		internal static object AJJhjcsjun6wkSLl1Cqx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EvrEnNsjIwPVLAt18X2N(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dwssJ8sjRup3OxKlq18r(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xmh8RNsjaDa2wv6dMt5W(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SI5uIisjnQ5q5wSJYOhX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditingObject)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oPY8JnsjGfKtK1CDspYw(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ApplyEditableObjectAndRunSheet((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PtRxGrsjls6yc15Vs6I3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BAkaV5sjeQfVffkMPJAS()
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

		public UndoCirclePropertyAction _003C_003E4__this;

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
			int num;
			if (!yA4kCIsjb9JFwHOZR6OX())
			{
				num = 4;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_02a5;
			IL_003d:
			UndoCirclePropertyAction undoCirclePropertyAction = _003C_003E4__this;
			num = 2;
			goto IL_02a5;
			IL_02a5:
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
					goto IL_003d;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							modifiedCells = undoCirclePropertyAction.ModifiedCells;
							num3 = 2;
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
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 7:
								awaiter = ((CvsCogSocketSheet)a50ar6sjppqH4ZthCXyW(nYQ6lnsj6w2jbBsofpY9(undoCirclePropertyAction.InSight))).ClearCellsAsync(cellRange).GetAwaiter();
								_ = 0;
								if (wuFGdnsjXIoh2LHcdgnd())
								{
									num3 = 14;
									continue;
								}
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (!yA4kCIsjb9JFwHOZR6OX())
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								cellRange = new CvsCellRange(undoCirclePropertyAction.DropLocation.Row + cvsCellRange.Row, undoCirclePropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 13;
							case 13:
								_003C_003E7__wrap2++;
								goto case 9;
							case 9:
								if (_003C_003E7__wrap2 >= _003C_003E7__wrap1.Length)
								{
									goto case 11;
								}
								cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
								num3 = 6;
								continue;
							case 2:
								_003C_003E7__wrap1 = modifiedCells;
								num3 = 10;
								continue;
							case 5:
							case 14:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									continue;
								}
								goto case 3;
							case 3:
								awaiter.GetResult();
								num3 = 13;
								continue;
							case 11:
							case 12:
								_003C_003E7__wrap1 = null;
								num3 = 15;
								continue;
							case 10:
								_003C_003E7__wrap2 = 0;
								num3 = 9;
								continue;
							case 15:
								undoCirclePropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
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
					if (!yA4kCIsjb9JFwHOZR6OX())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num2 = _003C_003E1__state;
			num = 1;
			if (!wuFGdnsjXIoh2LHcdgnd())
			{
				goto IL_003d;
			}
			goto IL_02a5;
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
		internal static object nYQ6lnsj6w2jbBsofpY9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a50ar6sjppqH4ZthCXyW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wuFGdnsjXIoh2LHcdgnd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yA4kCIsjb9JFwHOZR6OX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private string[] gK2l1X0wSG;

	private string[] glclxAyV0v;

	private CvsCellRange fCDlFmDkk1;

	private CvsCellRange t2Vlb7w3KE;

	private CvsCellRange MNYla5uiLX;

	private CvsCellRange nhMlOsfkuh;

	private string bjBlpA8mIH;

	private CvsCogCircle mV6lhO5IPe;

	[CompilerGenerated]
	private CvsInSight WgEl4H11AE;

	private CvsCellLocation gryllyChNs;

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
			return WgEl4H11AE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WgEl4H11AE = value;
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
			return gryllyChNs;
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
				case 1:
				case 4:
					gryllyChNs = value;
					goto default;
				default:
					nhMlOsfkuh = new CvsCellRange(gryllyChNs.Row + t2Vlb7w3KE.Row, gryllyChNs.Column + t2Vlb7w3KE.Column, t2Vlb7w3KE.Rows, t2Vlb7w3KE.Columns);
					num = 5;
					if (H2IpJPWZyQpI5wovsIg())
					{
						break;
					}
					goto case 0;
				case 0:
					if (value.IsValid)
					{
						H2IpJPWZyQpI5wovsIg();
						if (OrwVpRWJMiRK7kNFbZs())
						{
							num = 3;
							if (0 == 0)
							{
								break;
							}
							goto default;
						}
						num = 4;
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
			return new CvsCellRange[2] { fCDlFmDkk1, MNYla5uiLX };
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
			return nhMlOsfkuh;
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
			return (string)FbgxVAWzYQISSrVEuOt();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoCirclePropertyAction(string editCircleExpression, CvsCogCircle circle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		while (true)
		{
			switch (num)
			{
			case 9:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 8;
				break;
			case 7:
				fCDlFmDkk1 = new CvsCellRange(0, 1, 1, gK2l1X0wSG.Length);
				num = 3;
				if (!OrwVpRWJMiRK7kNFbZs())
				{
					break;
				}
				goto case 3;
			case 3:
				t2Vlb7w3KE = new CvsCellRange(1, 1, 1, glclxAyV0v.Length);
				num = 11;
				break;
			case 5:
			case 6:
				base._002Ector();
				goto case 10;
			default:
				num = 10;
				break;
			case 1:
				nhMlOsfkuh = CvsCellRange.Invalid;
				num = 4;
				break;
			case 4:
				gryllyChNs = CvsCellLocation.Invalid;
				goto case 5;
			case 10:
				bjBlpA8mIH = editCircleExpression;
				mV6lhO5IPe = circle;
				num = 7;
				break;
			case 8:
				gK2l1X0wSG = new string[3]
				{
					(string)KRb8fVW8GE1Wyk7udUx(16916),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16924),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16932)
				};
				H2IpJPWZyQpI5wovsIg();
				num = (OrwVpRWJMiRK7kNFbZs() ? 6 : 0);
				break;
			case 11:
				MNYla5uiLX = new CvsCellRange(1, 0, 1, glclxAyV0v.Length + 1);
				num = 12;
				if (OrwVpRWJMiRK7kNFbZs())
				{
				}
				break;
			case 0:
			case 2:
				glclxAyV0v = new string[3]
				{
					(string)KRb8fVW8GE1Wyk7udUx(16950),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16972),
					(string)KRb8fVW8GE1Wyk7udUx(16994)
				};
				num = 1;
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
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_004c;
		IL_001a:
		_003CSaveState_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		goto IL_004c;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			case 4:
				stateMachine._003C_003Et__builder = HDEmWS7w8ZQBVft56uC();
				_ = 0;
				if (!H2IpJPWZyQpI5wovsIg())
				{
					num = 0;
					continue;
				}
				num = 3;
				if (H2IpJPWZyQpI5wovsIg())
				{
					continue;
				}
				goto case 5;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__24))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				H2IpJPWZyQpI5wovsIg();
				num = ((!OrwVpRWJMiRK7kNFbZs()) ? 4 : 0);
				break;
			case 5:
				stateMachine._003C_003Et__builder = HDEmWS7w8ZQBVft56uC();
				num = 1;
				if (OrwVpRWJMiRK7kNFbZs())
				{
				}
				break;
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__25))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CRedo_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = HDEmWS7w8ZQBVft56uC();
				_ = 1;
				if (!OrwVpRWJMiRK7kNFbZs())
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				}
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__26))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CUndo_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				OrwVpRWJMiRK7kNFbZs();
				num = ((!H2IpJPWZyQpI5wovsIg()) ? 1 : 0);
				continue;
			case 4:
				stateMachine._003C_003Et__builder = HDEmWS7w8ZQBVft56uC();
				num = 5;
				if (!OrwVpRWJMiRK7kNFbZs())
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
	internal static object KRb8fVW8GE1Wyk7udUx(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H2IpJPWZyQpI5wovsIg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OrwVpRWJMiRK7kNFbZs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FbgxVAWzYQISSrVEuOt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DropCircle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder HDEmWS7w8ZQBVft56uC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
