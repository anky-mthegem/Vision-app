using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoPasteAction : UndoRangeAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPasteAction _003C_003E4__this;

		private ApartmentState _003CapartmentState_003E5__2;

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
			if (tl5vUUsKZyjd7VsFGQun())
			{
				num = 1;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_033f;
				}
			}
			goto IL_02e4;
			IL_02e4:
			UndoPasteAction undoPasteAction = default;
			CvsCell cvsCell = default;
			IExternalCellData externalCellData = default;
			IExternalCellDataHandler externalCellDataHandler = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02a2;
							}
							_003CapartmentState_003E5__2 = MLnMOusK8CwZa6OZ3IaH(Thread.CurrentThread);
						}
						try
						{
							if (num2 != 0)
							{
								if (_003CapartmentState_003E5__2 == ApartmentState.STA)
								{
									AJhORss5wPBPwuFFgxBQ(KFOklusKzROjOdTMqLef());
								}
								YwGfsbs5scgAP2knFWSi(undoPasteAction.StoredRanges[0]);
								awaiter = ((Task)uPhty4s5hgMRIuFLYGPH(undoPasteAction.InSight, undoPasteAction.Range, undoPasteAction.kxSgD9XGjC, false, true)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
							}
							awaiter.GetResult();
							undoPasteAction.InSight.MakeNewResult(updateExposedResults: true);
							IEnumerator<CvsCellLocation> enumerator = undoPasteAction.Range.GetEnumerator();
							try
							{
								while (a5SZ2Ys5vQtNDCm2cH0s(enumerator))
								{
									CvsCellLocation current = enumerator.Current;
									int num3 = 0;
									while (true)
									{
										switch (num3)
										{
										case 0:
											cvsCell = (CvsCell)whk4trs59phQcc1mCkVR(braX13s5LPnrDYSYLJpt(undoPasteAction.InSight.Results), current);
											num3 = 2;
											continue;
										case 4:
											if (externalCellData == null)
											{
												break;
											}
											tl5vUUsKZyjd7VsFGQun();
											if (!aqGgprsKJ8i1jKJBlClr())
											{
												num3 = 1;
												continue;
											}
											num3 = 8;
											if (true)
											{
												continue;
											}
											goto case 3;
										case 2:
											externalCellDataHandler = UndoHandler.GetExternalCellDataHandler(cvsCell);
											num3 = 7;
											if (true)
											{
												continue;
											}
											goto case 1;
										case 1:
										case 5:
											undoPasteAction.Ro1geMMqIL.Add(externalCellData);
											goto case 6;
										case 3:
											externalCellData = externalCellDataHandler.SaveState(undoPasteAction.InSight, SEg7e7s5SJDcGcNPeiiX(cvsCell));
											goto case 4;
										default:
											num3 = 4;
											continue;
										case 7:
											if (externalCellDataHandler != null)
											{
												num3 = 3;
												continue;
											}
											break;
										case 6:
										case 8:
											D9yydGs5E6wf47NbxP3V(externalCellData);
											num3 = 9;
											continue;
										case 9:
											break;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									n0MSARs5Hp4cXI2v649s(enumerator);
								}
							}
						}
						finally
						{
							if (num2 < 0 && _003CapartmentState_003E5__2 == ApartmentState.STA)
							{
								AJhORss5wPBPwuFFgxBQ(null);
							}
						}
						awaiter = Task.CompletedTask.GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02a2;
						IL_02a2:
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
					if (!aqGgprsKJ8i1jKJBlClr())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					undoPasteAction = _003C_003E4__this;
					goto case 2;
				case 3:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_033f;
			IL_033f:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02e4;
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
		internal static ApartmentState MLnMOusK8CwZa6OZ3IaH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Thread)P_0).GetApartmentState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KFOklusKzROjOdTMqLef()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cursors.Wait;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AJhORss5wPBPwuFFgxBQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Mouse.OverrideCursor = (Cursor)P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YwGfsbs5scgAP2knFWSi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StoredRange)P_0).DeleteExternalData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uPhty4s5hgMRIuFLYGPH(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object braX13s5LPnrDYSYLJpt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object whk4trs59phQcc1mCkVR(object P_0, CvsCellLocation cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[cell];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation SEg7e7s5SJDcGcNPeiiX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D9yydGs5E6wf47NbxP3V(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IExternalCellData)P_0).CopyPaste();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a5SZ2Ys5vQtNDCm2cH0s(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void n0MSARs5Hp4cXI2v649s(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tl5vUUsKZyjd7VsFGQun()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aqGgprsKJ8i1jKJBlClr()
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
	private struct _003CRedo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPasteAction _003C_003E4__this;

		private ApartmentState _003CapartmentState_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!fOBRLjs5Vq9ynGcHVvI6())
			{
				goto IL_001e;
			}
			goto IL_01e6;
			IL_0230:
			int num2 = _003C_003E1__state;
			num = 4;
			if (TxGxeEs5A2MfJ5iKBZb9())
			{
			}
			goto IL_01e6;
			IL_01e6:
			UndoPasteAction undoPasteAction = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					goto IL_0219;
				case 1:
					goto IL_0230;
				case 4:
					goto IL_024b;
				case 6:
					return;
				}
				break;
				IL_024b:
				undoPasteAction = _003C_003E4__this;
				_ = 0;
				if (!fOBRLjs5Vq9ynGcHVvI6())
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0219;
				}
				num = 5;
			}
			goto IL_001e;
			IL_0219:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (true)
			{
				goto IL_01e6;
			}
			goto IL_0230;
			IL_001e:
			try
			{
				TaskAwaiter awaiter;
				if (num2 != 0)
				{
					if (num2 == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_01a4;
					}
					_003CapartmentState_003E5__2 = NWxQBns5DiOPgmxT2p2U(Thread.CurrentThread);
				}
				try
				{
					if (num2 != 0)
					{
						if (_003CapartmentState_003E5__2 == ApartmentState.STA)
						{
							uWlXn6s5UebWdrpHPOaB(Cursors.Wait);
						}
						TrMIj6s5TlCbpYYdchiS(undoPasteAction.StoredRanges[0]);
						awaiter = iDCMBMs5iPKBKBxR6tVl(aniKcus5dmBK0kNs95g8(undoPasteAction.InSight, undoPasteAction.Range, undoPasteAction.kxSgD9XGjC, false, false));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
					}
					awaiter.GetResult();
					List<IExternalCellData>.Enumerator enumerator = undoPasteAction.Ro1geMMqIL.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.CopyPaste();
						}
					}
					finally
					{
						if (num2 < 0)
						{
							((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
						}
					}
					((CvsCogSocket)RrhyTus5q8EF68AXPPae(undoPasteAction.InSight)).Sheet.Run();
				}
				finally
				{
					if (num2 < 0 && _003CapartmentState_003E5__2 == ApartmentState.STA)
					{
						uWlXn6s5UebWdrpHPOaB(null);
					}
				}
				awaiter = iDCMBMs5iPKBKBxR6tVl(kfs8l6s5BK5V4HnsQgRT());
				if (!awaiter.IsCompleted)
				{
					num2 = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_01a4;
				IL_01a4:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0219;
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
		internal static ApartmentState NWxQBns5DiOPgmxT2p2U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Thread)P_0).GetApartmentState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uWlXn6s5UebWdrpHPOaB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Mouse.OverrideCursor = (Cursor)P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TrMIj6s5TlCbpYYdchiS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StoredRange)P_0).DeleteExternalData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aniKcus5dmBK0kNs95g8(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter iDCMBMs5iPKBKBxR6tVl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RrhyTus5q8EF68AXPPae(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kfs8l6s5BK5V4HnsQgRT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fOBRLjs5Vq9ynGcHVvI6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TxGxeEs5A2MfJ5iKBZb9()
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
	private struct _003CUndo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPasteAction _003C_003E4__this;

		private ApartmentState _003CapartmentState_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (hujRabs5cOYXJiOFcIun() ? 5 : 2);
			int num2 = default;
			UndoPasteAction undoPasteAction = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!hujRabs5cOYXJiOFcIun())
					{
						break;
					}
					goto case 1;
				case 1:
					undoPasteAction = _003C_003E4__this;
					num = 4;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					try
					{
						if (num2 != 0)
						{
							_003CapartmentState_003E5__2 = Thread.CurrentThread.GetApartmentState();
						}
						try
						{
							TaskAwaiter awaiter;
							if (num2 != 0)
							{
								if (_003CapartmentState_003E5__2 == ApartmentState.STA)
								{
									gi3cwgs5WITy1bGED5JK(sAm9Z2s52ksb97iqvk7C());
								}
								awaiter = GmM3xos57OS2CUX7PI5k(undoPasteAction.Hh2gGodEAf());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
							}
							awaiter.GetResult();
							XpJS8Ns5twricGAa4yaW(undoPasteAction.StoredRanges[0]);
							List<IExternalCellData>.Enumerator enumerator = undoPasteAction.Ro1geMMqIL.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									enumerator.Current.UnCopyPaste();
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
						}
						finally
						{
							if (num2 < 0 && _003CapartmentState_003E5__2 == ApartmentState.STA)
							{
								gi3cwgs5WITy1bGED5JK(null);
							}
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
		internal static object sAm9Z2s52ksb97iqvk7C()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cursors.Wait;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gi3cwgs5WITy1bGED5JK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Mouse.OverrideCursor = (Cursor)P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter GmM3xos57OS2CUX7PI5k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XpJS8Ns5twricGAa4yaW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StoredRange)P_0).RestoreExternalData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kPiwF5s5j8vIOwsFraE6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hujRabs5cOYXJiOFcIun()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly byte[] kxSgD9XGjC;

	private List<IExternalCellData> Ro1geMMqIL;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)AEO0oICjc7xroVX7gxU(Resources.UndoActionPaste, Range.ToString());
		}
	}

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

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoPasteAction(CvsInSight inSight, CvsCellRange destination)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (Fx9UD8CdDeNTeq2ys1q())
		{
			num = 4;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0040;
		IL_0086:
		kxSgD9XGjC = (byte[])wIweddCB3i8vl48nbNj();
		num = 6;
		goto IL_0040;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 5:
				Ro1geMMqIL = new List<IExternalCellData>();
				num = 1;
				continue;
			default:
				goto IL_0086;
			case 0:
			case 4:
				jee9I2Cq5wHnsvSubsT();
				num = 5;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		base._002Ector(inSight, destination);
		goto IL_0086;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoPasteAction(CvsInSight inSight, CvsCellRange destination, byte[] data)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		do
		{
			IL_0047:
			switch (num)
			{
			case 1:
			case 4:
				Ro1geMMqIL = new List<IExternalCellData>();
				num = 5;
				goto IL_0047;
			case 5:
				base._002Ector(inSight, destination);
				break;
			case 0:
				jee9I2Cq5wHnsvSubsT();
				_ = 0;
				num = (Fx9UD8CdDeNTeq2ys1q() ? 4 : 2);
				goto IL_0047;
			case 6:
				return;
			}
			kxSgD9XGjC = data;
			num = 6;
		}
		while (Fx9UD8CdDeNTeq2ys1q());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__6))]
	public override Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDo_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003Et__builder = z2oGFECcnFLUyA0qNcC();
				_ = 0;
				num = ((!Fx9UD8CdDeNTeq2ys1q()) ? 2 : 4);
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__7))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lQV3ADCiI16cjnxs7pu();
		int num;
		if (Fx9UD8CdDeNTeq2ys1q())
		{
			num = 1;
			if (lQV3ADCiI16cjnxs7pu())
			{
			}
		}
		else
		{
			num = 4;
		}
		_003CRedo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = z2oGFECcnFLUyA0qNcC();
				num = 3;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__8))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lQV3ADCiI16cjnxs7pu();
		int num;
		if (Fx9UD8CdDeNTeq2ys1q())
		{
			num = 4;
			if (!Fx9UD8CdDeNTeq2ys1q())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0088;
		IL_002e:
		_003CUndo_003Ed__8 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = z2oGFECcnFLUyA0qNcC();
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task Hh2gGodEAf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.Undo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jee9I2Cq5wHnsvSubsT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wIweddCB3i8vl48nbNj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellClipboardData.GetClipboard();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fx9UD8CdDeNTeq2ys1q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lQV3ADCiI16cjnxs7pu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AEO0oICjc7xroVX7gxU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder z2oGFECcnFLUyA0qNcC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
