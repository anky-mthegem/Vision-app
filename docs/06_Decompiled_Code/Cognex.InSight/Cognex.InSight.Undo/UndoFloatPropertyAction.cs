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

public class UndoFloatPropertyAction : IUndoPropertyAction, IUndoAction
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
			int num = 0;
			if (!zocDPRsWBQIB9xfk2X81())
			{
				goto IL_001e;
			}
			goto IL_0188;
			IL_01b7:
			_003C_003Et__builder.SetResult();
			num = 5;
			goto IL_0188;
			IL_0188:
			switch (num)
			{
			case 0:
				break;
			case 1:
			case 4:
				goto IL_0041;
			default:
				goto IL_01b7;
			case 5:
				return;
			}
			goto IL_001e;
			IL_0041:
			int num2 = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = Mj8ma3sW230lREnYbCj3(mod0nDsWcL6VkZ7TwrLH());
					num3 = 7;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 4;
				}
				while (true)
				{
					IL_00ed:
					switch (num3)
					{
					case 8:
						return;
					case 1:
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 0;
						continue;
					case 4:
						_003C_003Eu__1 = default;
						goto case 2;
					case 7:
						while (!awaiter.IsCompleted)
						{
							zocDPRsWBQIB9xfk2X81();
							if (KbqONjsWjbOGD9B0mOL8())
							{
								num3 = 2;
								if (KbqONjsWjbOGD9B0mOL8())
								{
									continue;
								}
							}
							else
							{
								num3 = 3;
							}
							goto IL_00ed;
						}
						break;
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 8;
						continue;
					case 2:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 0:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
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
			goto IL_01b7;
			IL_001e:
			num2 = _003C_003E1__state;
			_ = 0;
			if (zocDPRsWBQIB9xfk2X81())
			{
				num = 4;
				if (KbqONjsWjbOGD9B0mOL8())
				{
					goto IL_0041;
				}
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_01b7;
				}
			}
			goto IL_0188;
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
		internal static object mod0nDsWcL6VkZ7TwrLH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Mj8ma3sW230lREnYbCj3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zocDPRsWBQIB9xfk2X81()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KbqONjsWjbOGD9B0mOL8()
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

		public UndoFloatPropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!Ip1T7rsW7lgvIv0hMv17())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_003d;
				}
			}
			goto IL_01ae;
			IL_01ae:
			int num2 = default;
			UndoFloatPropertyAction undoFloatPropertyAction = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 3:
					break;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = yICh4jsWtyNyhHDRSnMi(undoFloatPropertyAction.Redo());
							num3 = 5;
							if (!mnDcZ5sWWtPFv48ql5pt())
							{
								goto IL_0070;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (Ip1T7rsW7lgvIv0hMv17())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 8:
								break;
							default:
								num3 = 0;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 9;
							case 1:
								num2 = (_003C_003E1__state = 0);
								Ip1T7rsW7lgvIv0hMv17();
								if (mnDcZ5sWWtPFv48ql5pt())
								{
									num3 = 6;
									if (Ip1T7rsW7lgvIv0hMv17())
									{
									}
									continue;
								}
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 0:
								return;
							case 2:
							case 6:
								_003C_003Eu__1 = awaiter;
								break;
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
					goto case 2;
				default:
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_003d;
			IL_003d:
			undoFloatPropertyAction = _003C_003E4__this;
			num = 4;
			goto IL_01ae;
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
		internal static TaskAwaiter yICh4jsWtyNyhHDRSnMi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mnDcZ5sWWtPFv48ql5pt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ip1T7rsW7lgvIv0hMv17()
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

		public UndoFloatPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CeditFloatLoc_003E5__2;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (p8EDggsWKuCq8tyVfQRT() ? 2 : 3);
			int num2 = default;
			TaskAwaiter<object> awaiter = default;
			UndoFloatPropertyAction undoFloatPropertyAction = default;
			CvsCellLocation dropLocation = default;
			do
			{
				IL_0309:
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 18;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 17;
							}
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
								awaiter.GetResult();
								p8EDggsWKuCq8tyVfQRT();
								if (E0wYP4sWCdBgo2fugJPd())
								{
									num3 = 19;
									continue;
								}
								num3 = 15;
								if (E0wYP4sWCdBgo2fugJPd())
								{
									continue;
								}
								goto case 10;
							case 12:
								return;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 1:
								((CvsCogSocketSheet)a5qj6PsWoY37hPoAkigj(FmGLiWsW5mjTYZYUKhj1(undoFloatPropertyAction.InSight))).Run(true);
								num3 = 6;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								goto case 9;
							default:
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								awaiter = ((CvsCogSocketSheet)a5qj6PsWoY37hPoAkigj(FmGLiWsW5mjTYZYUKhj1(undoFloatPropertyAction.InSight))).PutCellExpressionAsync(dropLocation, undoFloatPropertyAction.aSggIb08VK).GetAwaiter();
								num3 = 8;
								continue;
							case 6:
								T2odbXsWPATBcxHp77W5(undoFloatPropertyAction.InSight, _003CeditFloatLoc_003E5__2, undoFloatPropertyAction.feTgxvC6A8);
								num3 = 20;
								continue;
							case 11:
							case 19:
								awaiter = ((CvsCogSocketSheet)a5qj6PsWoY37hPoAkigj(FmGLiWsW5mjTYZYUKhj1(undoFloatPropertyAction.InSight))).PutCellExpressionAsync(_003CeditFloatLoc_003E5__2, undoFloatPropertyAction.d7Ng1gwLVf).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 14;
									continue;
								}
								goto IL_023a;
							case 3:
								_003CeditFloatLoc_003E5__2 = undoFloatPropertyAction.DropLocation;
								_003CeditFloatLoc_003E5__2.Row++;
								num3 = 7;
								continue;
							case 18:
								dropLocation = undoFloatPropertyAction.DropLocation;
								num3 = 3;
								continue;
							case 4:
								return;
							case 13:
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 17:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_023a;
							case 16:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 16;
									continue;
								}
								goto case 5;
							case 14:
								_003C_003Eu__1 = awaiter;
								goto case 13;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 20:
								{
									undoFloatPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
									break;
								}
								IL_023a:
								awaiter.GetResult();
								num3 = 1;
								if (!p8EDggsWKuCq8tyVfQRT())
								{
									continue;
								}
								goto case 16;
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
					num = 5;
					goto IL_0309;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					undoFloatPropertyAction = _003C_003E4__this;
					num = 4;
					goto IL_0309;
				case 5:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (!p8EDggsWKuCq8tyVfQRT());
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
		internal static object FmGLiWsW5mjTYZYUKhj1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a5qj6PsWoY37hPoAkigj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void T2odbXsWPATBcxHp77W5(object P_0, CvsCellLocation location, double cellValue)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).SetFloat(location, cellValue);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E0wYP4sWCdBgo2fugJPd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p8EDggsWKuCq8tyVfQRT()
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

		public UndoFloatPropertyAction _003C_003E4__this;

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
			int num = ((!J6WroQsWYxoIWVSAntoB()) ? 2 : 4);
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			UndoFloatPropertyAction undoFloatPropertyAction = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							modifiedCells = undoFloatPropertyAction.ModifiedCells;
							num3 = 10;
							goto IL_00c7;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0225;
						IL_0225:
						_003C_003Eu__1 = default;
						num3 = 12;
						goto IL_00c7;
						IL_00c7:
						while (true)
						{
							switch (num3)
							{
							case 0:
								cellRange = new CvsCellRange(undoFloatPropertyAction.DropLocation.Row + cvsCellRange.Row, undoFloatPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								J6WroQsWYxoIWVSAntoB();
								if (!FU2xhKsWNVFY1WYBV83H())
								{
									num3 = 13;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								}
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 6:
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 4:
								_003C_003E7__wrap2 = 0;
								goto case 7;
							case 3:
							case 13:
								awaiter = ((CvsCogSocketSheet)CGB3V6sW1XNFQWrssPuV(WL0qvasWxIGLwPcZ2I8M(undoFloatPropertyAction.InSight))).ClearCellsAsync(cellRange).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto case 2;
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								if (FU2xhKsWNVFY1WYBV83H())
								{
								}
								continue;
							case 9:
								_003C_003E7__wrap2++;
								num3 = 7;
								continue;
							case 2:
								awaiter.GetResult();
								num3 = 9;
								continue;
							case 8:
								_003C_003E7__wrap1 = null;
								num3 = 15;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							case 10:
								_003C_003E7__wrap1 = modifiedCells;
								num3 = 4;
								continue;
							case 7:
								if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
								{
									cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
									num3 = 0;
								}
								else
								{
									num3 = 8;
								}
								continue;
							case 14:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 5:
								break;
							case 15:
								undoFloatPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
								goto end_IL_00c7;
							}
							goto IL_0225;
							continue;
							end_IL_00c7:
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
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					undoFloatPropertyAction = _003C_003E4__this;
					num = 3;
					if (FU2xhKsWNVFY1WYBV83H())
					{
					}
					continue;
				case 5:
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
		internal static object WL0qvasWxIGLwPcZ2I8M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CGB3V6sW1XNFQWrssPuV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J6WroQsWYxoIWVSAntoB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FU2xhKsWNVFY1WYBV83H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellRange qkolzShmJY;

	private CvsCellRange zicgPIm35I;

	private string aSggIb08VK;

	private string d7Ng1gwLVf;

	private double feTgxvC6A8;

	[CompilerGenerated]
	private CvsInSight S30gF3J0jo;

	private CvsCellLocation wYVgbus043;

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
			return S30gF3J0jo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			S30gF3J0jo = value;
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
			return wYVgbus043;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (EUS3u7tUV0Y30rZ6Gkl())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (yHfdUetTQiAtPCVdF38())
				{
				}
			}
			while (true)
			{
				switch (num)
				{
				default:
					zicgPIm35I = new CvsCellRange(wYVgbus043.Row + 1, wYVgbus043.Column, 1, 1);
					num = 5;
					break;
				case 0:
				case 4:
					if (value.IsValid)
					{
						num = 3;
						break;
					}
					return;
				case 3:
					wYVgbus043 = value;
					goto default;
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
			return new CvsCellRange[1] { qkolzShmJY };
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
			return zicgPIm35I;
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
	public UndoFloatPropertyAction(UndoPropertyActionArgs<double> args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		this._002Ector(args.Name, args.EditExpression, args.CurrentValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoFloatPropertyAction(string name, string editFloatExpression, double currentValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (EUS3u7tUV0Y30rZ6Gkl())
		{
			num = 2;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0085;
		IL_0041:
		zicgPIm35I = CvsCellRange.Invalid;
		num = 8;
		goto IL_0085;
		IL_0085:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
				goto IL_0041;
			case 9:
				d7Ng1gwLVf = editFloatExpression;
				goto case 5;
			case 6:
				mmJfQCtdDTsWeOLShpE(this);
				goto case 4;
			default:
				num = 4;
				continue;
			case 8:
				wYVgbus043 = CvsCellLocation.Invalid;
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
			case 7:
				feTgxvC6A8 = currentValue;
				num = 10;
				continue;
			case 4:
				aSggIb08VK = (string)MREtaAtiD5OlSb4i2aj(kgbOBx7BanbFa22Hp9.ol99ukmDA(16904), name);
				num = 9;
				continue;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 3;
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		qkolzShmJY = new CvsCellRange(0, 0, 2, 1);
		num = 1;
		if (false)
		{
			goto IL_0041;
		}
		goto IL_0085;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__21))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (EUS3u7tUV0Y30rZ6Gkl())
		{
			num = 3;
			if (!EUS3u7tUV0Y30rZ6Gkl())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0044;
		IL_0087:
		_003CSaveState_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = I00lHGtqyqXNnBN3sIS();
				break;
			case 2:
				goto IL_0087;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_0087;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__22))]
	public Task Do()
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
		goto IL_0048;
		IL_002e:
		_003CDo_003Ed__22 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0083;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 2:
				goto IL_002e;
			default:
				goto IL_0083;
			case 4:
				goto IL_009b;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_009b:
			stateMachine._003C_003Et__builder = I00lHGtqyqXNnBN3sIS();
			EUS3u7tUV0Y30rZ6Gkl();
			if (yHfdUetTQiAtPCVdF38())
			{
				num = 0;
				if (yHfdUetTQiAtPCVdF38())
				{
				}
			}
			else
			{
				num = 5;
			}
		}
		goto IL_001a;
		IL_0083:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0048;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		num = 2;
		if (1 == 0)
		{
			goto IL_002e;
		}
		goto IL_0048;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__23))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (yHfdUetTQiAtPCVdF38())
		{
			goto IL_001e;
		}
		goto IL_008e;
		IL_001e:
		_003CRedo_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_008e;
		IL_008e:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder = I00lHGtqyqXNnBN3sIS();
				yHfdUetTQiAtPCVdF38();
				num = (EUS3u7tUV0Y30rZ6Gkl() ? 5 : 4);
				continue;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 3;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__24))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CUndo_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 3:
				stateMachine._003C_003Et__builder = I00lHGtqyqXNnBN3sIS();
				_ = 1;
				if (yHfdUetTQiAtPCVdF38())
				{
					num = 0;
					if (!yHfdUetTQiAtPCVdF38())
					{
						break;
					}
					goto case 0;
				}
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mmJfQCtdDTsWeOLShpE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MREtaAtiD5OlSb4i2aj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EUS3u7tUV0Y30rZ6Gkl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yHfdUetTQiAtPCVdF38()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder I00lHGtqyqXNnBN3sIS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
