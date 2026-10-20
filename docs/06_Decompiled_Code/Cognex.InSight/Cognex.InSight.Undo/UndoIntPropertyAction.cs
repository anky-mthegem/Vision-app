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

public class UndoIntPropertyAction : IUndoPropertyAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__21 : IAsyncStateMachine
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
			int num = ((!TlF7k2sKLcEw2aOEkRVT()) ? 4 : 2);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((Task)KNA8PasKSnfWjkjegnw2()).GetAwaiter();
							num3 = 7;
							if (J5dRFusK9k6EKsjuyyQN())
							{
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (false)
							{
								goto IL_0078;
							}
						}
						goto IL_011b;
						IL_0152:
						awaiter.GetResult();
						goto end_IL_003b;
						IL_0078:
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							if (J5dRFusK9k6EKsjuyyQN())
							{
							}
							goto IL_011b;
						}
						goto IL_0152;
						IL_011b:
						while (true)
						{
							switch (num3)
							{
							case 0:
								return;
							case 7:
								break;
							case 1:
								goto IL_0098;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 9:
								goto IL_0152;
							}
							break;
							IL_0098:
							num2 = (_003C_003E1__state = 0);
							TlF7k2sKLcEw2aOEkRVT();
							num3 = (J5dRFusK9k6EKsjuyyQN() ? 4 : 8);
						}
						goto IL_0078;
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
				case 3:
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
		internal static object KNA8PasKSnfWjkjegnw2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TlF7k2sKLcEw2aOEkRVT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J5dRFusK9k6EKsjuyyQN()
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
	private struct _003CDo_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoIntPropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_01a4;
			IL_004e:
			int num2 = default;
			UndoIntPropertyAction undoIntPropertyAction = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = undoIntPropertyAction.Redo().GetAwaiter();
					num3 = 8;
					if (dty3q6sKvJmpuhEAaLU2())
					{
						goto IL_0070;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 3;
				}
				while (true)
				{
					switch (num3)
					{
					case 7:
						break;
					default:
						num3 = 6;
						if (!dty3q6sKvJmpuhEAaLU2())
						{
							continue;
						}
						return;
					case 6:
						return;
					case 8:
						if (!awaiter.IsCompleted)
						{
							gpvk9BsKEedslV1195MY();
							if (!dty3q6sKvJmpuhEAaLU2())
							{
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							}
							num3 = 5;
							continue;
						}
						goto case 9;
					case 2:
					case 5:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						if (gpvk9BsKEedslV1195MY())
						{
							continue;
						}
						goto case 0;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 3:
						_003C_003Eu__1 = default;
						num3 = 0;
						continue;
					case 1:
					case 4:
						num2 = (_003C_003E1__state = 0);
						goto case 2;
					case 9:
						awaiter.GetResult();
						goto end_IL_0090;
					}
					goto IL_0070;
					continue;
					end_IL_0090:
					break;
				}
				goto end_IL_004e;
				IL_0070:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				end_IL_004e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01cf;
			IL_01a4:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 4:
					goto IL_0031;
				case 2:
				case 5:
					goto IL_004e;
				default:
					num = 0;
					continue;
				case 0:
					goto IL_01cf;
				case 6:
					return;
				}
				break;
				IL_0031:
				num2 = _003C_003E1__state;
				_ = 0;
				num = (gpvk9BsKEedslV1195MY() ? 3 : 5);
			}
			goto IL_001a;
			IL_01cf:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a4;
			IL_001a:
			undoIntPropertyAction = _003C_003E4__this;
			goto IL_004e;
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
		internal static bool gpvk9BsKEedslV1195MY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dty3q6sKvJmpuhEAaLU2()
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
	private struct _003CRedo_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoIntPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CeditIntLoc_003E5__2;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0307;
			IL_001a:
			int num2 = default;
			UndoIntPropertyAction undoIntPropertyAction = default;
			try
			{
				int num3;
				TaskAwaiter<object> awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 17;
						if (false)
						{
							goto IL_0033;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 0;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					a09xAvsKHKAuZ9JHfTPy();
					if (!DoBFwBsKVuA10HCU1css())
					{
						num3 = 9;
						if (DoBFwBsKVuA10HCU1css())
						{
							goto IL_027c;
						}
					}
					else
					{
						num3 = 16;
					}
				}
				goto IL_01cd;
				IL_01cd:
				CvsCellLocation dropLocation = default;
				while (true)
				{
					switch (num3)
					{
					case 5:
					case 9:
						break;
					case 1:
						return;
					case 18:
						num2 = (_003C_003E1__state = 1);
						num3 = 7;
						continue;
					case 10:
						_003CeditIntLoc_003E5__2 = undoIntPropertyAction.DropLocation;
						_003CeditIntLoc_003E5__2.Row++;
						awaiter = undoIntPropertyAction.InSight.CogSocket.Sheet.PutCellExpressionAsync(dropLocation, undoIntPropertyAction.mFYgYe7A6B).GetAwaiter();
						num3 = 12;
						continue;
					case 12:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							num3 = 6;
							continue;
						}
						goto case 2;
					case 6:
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 14;
					case 14:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 1;
						continue;
					case 17:
						dropLocation = undoIntPropertyAction.DropLocation;
						num3 = 10;
						continue;
					case 15:
					case 16:
						goto IL_0118;
					case 7:
						_003C_003Eu__1 = awaiter;
						num3 = 14;
						continue;
					case 3:
						num2 = (_003C_003E1__state = -1);
						num3 = 2;
						continue;
					case 4:
						((CvsCogSocketSheet)YkcK2lsKDdfjooPUqio7(undoIntPropertyAction.InSight.CogSocket)).Run(true);
						num3 = 11;
						continue;
					case 13:
						if (awaiter.IsCompleted)
						{
							goto IL_0121;
						}
						num3 = 18;
						if (a09xAvsKHKAuZ9JHfTPy())
						{
							continue;
						}
						goto case 19;
					case 19:
						awaiter = ((CvsCogSocketSheet)YkcK2lsKDdfjooPUqio7(VpxLqYsKArhj047jFO9L(undoIntPropertyAction.InSight))).PutCellExpressionAsync(_003CeditIntLoc_003E5__2, undoIntPropertyAction.rGsg7aZERm).GetAwaiter();
						goto case 13;
					default:
						num3 = 13;
						continue;
					case 2:
						awaiter.GetResult();
						num3 = 19;
						continue;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 11:
						goto IL_027c;
					case 0:
						goto IL_02a3;
					case 20:
						undoIntPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
						goto end_IL_001a;
					}
					break;
				}
				goto IL_0033;
				IL_0118:
				num2 = (_003C_003E1__state = -1);
				goto IL_0121;
				IL_02a3:
				_003C_003Eu__1 = default;
				goto IL_0118;
				IL_0033:
				_003C_003Eu__1 = default;
				num3 = 3;
				goto IL_01cd;
				IL_0121:
				awaiter.GetResult();
				num3 = 4;
				goto IL_01cd;
				IL_027c:
				PaScP2sKUYUYqrVH0UVM(undoIntPropertyAction.InSight, _003CeditIntLoc_003E5__2, undoIntPropertyAction.kLlgmWlmUS);
				num3 = 20;
				if (a09xAvsKHKAuZ9JHfTPy())
				{
					goto IL_01cd;
				}
				goto IL_02a3;
				end_IL_001a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0332;
			IL_0307:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					num = 0;
					continue;
				case 0:
					goto IL_0332;
				case 3:
					goto IL_0347;
				case 1:
				case 4:
					undoIntPropertyAction = _003C_003E4__this;
					break;
				case 6:
					return;
				}
				break;
				IL_0347:
				num2 = _003C_003E1__state;
				a09xAvsKHKAuZ9JHfTPy();
				if (!DoBFwBsKVuA10HCU1css())
				{
					num = 4;
					continue;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				return;
			}
			goto IL_001a;
			IL_0332:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0307;
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
		internal static object VpxLqYsKArhj047jFO9L(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YkcK2lsKDdfjooPUqio7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PaScP2sKUYUYqrVH0UVM(object P_0, CvsCellLocation location, int cellValue)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).SetInteger(location, cellValue);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a09xAvsKHKAuZ9JHfTPy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DoBFwBsKVuA10HCU1css()
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
	private struct _003CUndo_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoIntPropertyAction _003C_003E4__this;

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
			UndoIntPropertyAction undoIntPropertyAction = default;
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					undoIntPropertyAction = _003C_003E4__this;
					WP1e2XsKT3aNaPbm2qFk();
					if (!CWs8rVsKdGeaeuNpfTQv())
					{
						num = 1;
						if (true)
						{
							continue;
						}
						goto case 5;
					}
					num = 0;
					continue;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							modifiedCells = undoIntPropertyAction.ModifiedCells;
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003E7__wrap1 = modifiedCells;
								num3 = 14;
								continue;
							case 5:
							case 12:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__1 = default;
								num3 = 13;
								continue;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 4:
								cellRange = new CvsCellRange(undoIntPropertyAction.DropLocation.Row + cvsCellRange.Row, undoIntPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								WP1e2XsKT3aNaPbm2qFk();
								num3 = (CWs8rVsKdGeaeuNpfTQv() ? 12 : 8);
								continue;
							case 10:
								if (!awaiter.IsCompleted)
								{
									goto case 5;
								}
								goto case 7;
							case 2:
								return;
							case 3:
							case 8:
								awaiter = ((CvsCogSocketSheet)ovasM5sKqCeyl5Uv0qvo(AEjyInsKigJh0Bh0X6gj(undoIntPropertyAction.InSight))).ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 10;
								if (WP1e2XsKT3aNaPbm2qFk())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 7:
								awaiter.GetResult();
								_003C_003E7__wrap2++;
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								if (_003C_003E7__wrap2 >= _003C_003E7__wrap1.Length)
								{
									_003C_003E7__wrap1 = null;
									num3 = 15;
								}
								else
								{
									cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
									num3 = 4;
								}
								continue;
							case 14:
								_003C_003E7__wrap2 = 0;
								goto case 6;
							case 15:
								undoIntPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
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
		internal static object AEjyInsKigJh0Bh0X6gj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ovasM5sKqCeyl5Uv0qvo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WP1e2XsKT3aNaPbm2qFk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CWs8rVsKdGeaeuNpfTQv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellRange MfvgcOEwfK;

	private CvsCellRange Smug5x3nl8;

	private string mFYgYe7A6B;

	private string rGsg7aZERm;

	private int kLlgmWlmUS;

	[CompilerGenerated]
	private CvsInSight boSgnKAPN5;

	private CvsCellLocation aLtg9kVUYr;

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
			return boSgnKAPN5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			boSgnKAPN5 = value;
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
			return aLtg9kVUYr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OLR57FtZNvBTXi1I0Wd();
			int num;
			if (!WyhlKStJVJRO5rfDUVw())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0075;
				}
			}
			goto IL_008e;
			IL_0028:
			Smug5x3nl8 = new CvsCellRange(aLtg9kVUYr.Row + 1, aLtg9kVUYr.Column, 1, 1);
			num = 5;
			goto IL_008e;
			IL_0075:
			aLtg9kVUYr = value;
			goto IL_0028;
			IL_008e:
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 4:
					if (value.IsValid)
					{
						goto IL_0075;
					}
					return;
				case 1:
				case 3:
					goto IL_0075;
				default:
					num = 2;
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_0028;
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
			return new CvsCellRange[1] { MfvgcOEwfK };
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
			return Smug5x3nl8;
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
			return Resources.DropInteger;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoIntPropertyAction(UndoPropertyActionArgs<int> args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		this._002Ector(args.Name, args.EditExpression, args.CurrentValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoIntPropertyAction(string name, string editIntExpression, int currentValue)
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
		goto IL_005e;
		IL_001a:
		kLlgmWlmUS = currentValue;
		num = 10;
		goto IL_005e;
		IL_005e:
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 0:
			case 6:
				rGsg7aZERm = editIntExpression;
				num = 8;
				if (WyhlKStJVJRO5rfDUVw())
				{
				}
				continue;
			case 4:
			case 9:
				dMwfaktzP3SfNRiL7Z0(this);
				goto case 3;
			default:
				num = 3;
				continue;
			case 5:
				kWiPput8RmmD4lVuuGK();
				num = 2;
				continue;
			case 1:
				Smug5x3nl8 = CvsCellRange.Invalid;
				num = 7;
				if (OLR57FtZNvBTXi1I0Wd())
				{
					continue;
				}
				goto case 2;
			case 2:
				MfvgcOEwfK = new CvsCellRange(0, 0, 2, 1);
				num = 1;
				continue;
			case 7:
				aLtg9kVUYr = CvsCellLocation.Invalid;
				_ = 1;
				if (!WyhlKStJVJRO5rfDUVw())
				{
					num = 9;
					if (true)
					{
						continue;
					}
					goto case 3;
				}
				num = 0;
				continue;
			case 3:
				mFYgYe7A6B = string.Format((string)L8ZGRsCwR9JI1h6ImgJ(16904), name);
				goto case 0;
			case 10:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__21))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WyhlKStJVJRO5rfDUVw();
		int num;
		if (OLR57FtZNvBTXi1I0Wd())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0046;
			}
		}
		goto IL_0060;
		IL_0089:
		_003CSaveState_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		if (OLR57FtZNvBTXi1I0Wd())
		{
			goto IL_0060;
		}
		goto IL_00a7;
		IL_00a7:
		return stateMachine._003C_003Et__builder.Task;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				break;
			case 1:
			case 3:
				break;
			default:
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0089;
			case 2:
				goto IL_0089;
			case 5:
				goto IL_00a7;
			}
			break;
		}
		goto IL_0046;
		IL_0046:
		stateMachine._003C_003E1__state = -1;
		goto IL_0089;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__22))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDo_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (OLR57FtZNvBTXi1I0Wd())
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = BuVHwKCslSXvG02INIS();
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				WyhlKStJVJRO5rfDUVw();
				num = ((!OLR57FtZNvBTXi1I0Wd()) ? 1 : 5);
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__23))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CRedo_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = ((!WyhlKStJVJRO5rfDUVw()) ? 1 : 0);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = BuVHwKCslSXvG02INIS();
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__24))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WyhlKStJVJRO5rfDUVw())
		{
			num = 3;
			if (WyhlKStJVJRO5rfDUVw())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0062;
		IL_0062:
		_003CUndo_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 4:
				goto IL_0048;
			default:
				num = 2;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = BuVHwKCslSXvG02INIS();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_0048:
		stateMachine._003C_003E1__state = -1;
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (WyhlKStJVJRO5rfDUVw())
		{
			goto IL_0048;
		}
		goto IL_0062;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kWiPput8RmmD4lVuuGK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dMwfaktzP3SfNRiL7Z0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L8ZGRsCwR9JI1h6ImgJ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OLR57FtZNvBTXi1I0Wd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WyhlKStJVJRO5rfDUVw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder BuVHwKCslSXvG02INIS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
