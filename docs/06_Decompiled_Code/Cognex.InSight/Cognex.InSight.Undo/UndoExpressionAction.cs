using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoExpressionAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoExpressionAction _003C_003E4__this;

		private CvsCell _003Ccell_003E5__2;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoExpressionAction undoExpressionAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						if (num2 != 0)
						{
							_003Ccell_003E5__2 = (CvsCell)TFZ3Y1s26BSqAXgW1X9h(jbYvyBs2buO7Fa548j22(wADnras2X5tluSQye0Q3(undoExpressionAction.fjxlSZ0sUf)), undoExpressionAction.zSDlrR2Al4);
							if (KnRuJTs2pffmB81KcU7n(_003Ccell_003E5__2))
							{
								goto IL_013d;
							}
							awaiter = ((CvsCogSocketSheet)k6Ulvbs203RQ9uLsjZO8(undoExpressionAction.fjxlSZ0sUf.CogSocket)).CopyCellsAsync(new CvsCellRange(undoExpressionAction.zSDlrR2Al4)).GetAwaiter();
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
						byte[] result = awaiter.GetResult();
						undoExpressionAction.QUDl8i0eiK = result;
						object obj = nA1TCDs2f3s9Lra3AsZ1(Jr3Aqws24g1hE0IOlX4h(undoExpressionAction.fjxlSZ0sUf), Ldi2iSs2kLxrs5GjegYL(_003Ccell_003E5__2));
						CvsFunction cvsFunction = (CvsFunction)nA1TCDs2f3s9Lra3AsZ1(Jr3Aqws24g1hE0IOlX4h(undoExpressionAction.fjxlSZ0sUf), undoExpressionAction.e48lCGTnBu);
						if (obj != cvsFunction)
						{
							IExternalCellDataHandler externalCellDataHandler = (IExternalCellDataHandler)tfFqBGs2FOMcy6Rg3FOr(_003Ccell_003E5__2);
							if (externalCellDataHandler != null)
							{
								undoExpressionAction.Pd3lZBunxT = externalCellDataHandler.SaveState(undoExpressionAction.fjxlSZ0sUf, zGYm9Qs2muGBagPdPl00(_003Ccell_003E5__2));
							}
						}
						goto IL_013d;
						IL_013d:
						IEnumerator<CvsCell> enumerator = ((CvsResultSet)wADnras2X5tluSQye0Q3(undoExpressionAction.fjxlSZ0sUf)).Cells.GetEnumerator();
						try
						{
							while (Sk6tGOs2y75RjwZcfmUR(enumerator))
							{
								CvsCell current = enumerator.Current;
								_ = 1;
								switch (PvMnpSs2GgOBPZlL8Gbq() ? 3 : 2)
								{
								case 0:
								case 2:
									undoExpressionAction.yKxlyfMQvy.Add(zGYm9Qs2muGBagPdPl00(current));
									break;
								}
							}
						}
						finally
						{
							if (num2 < 0)
							{
								enumerator?.Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ccell_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					break;
				case 2:
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				case 1:
				case 3:
					undoExpressionAction = _003C_003E4__this;
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!PvMnpSs2GgOBPZlL8Gbq())
					{
						num = 3;
						if (PvMnpSs2GgOBPZlL8Gbq())
						{
						}
					}
					else
					{
						num = 2;
					}
					break;
				case 5:
					_003Ccell_003E5__2 = null;
					goto case 2;
				case 7:
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
		internal static object wADnras2X5tluSQye0Q3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jbYvyBs2buO7Fa548j22(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TFZ3Y1s26BSqAXgW1X9h(object P_0, CvsCellLocation cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[cell];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KnRuJTs2pffmB81KcU7n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCell.IsNullOrEmpty((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object k6Ulvbs203RQ9uLsjZO8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Jr3Aqws24g1hE0IOlX4h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ldi2iSs2kLxrs5GjegYL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nA1TCDs2f3s9Lra3AsZ1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunctionTable)P_0).FindFunction((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tfFqBGs2FOMcy6Rg3FOr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UndoHandler.GetExternalCellDataHandler((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation zGYm9Qs2muGBagPdPl00(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Sk6tGOs2y75RjwZcfmUR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bBAiOps2n8vGI1cKFfuk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PvMnpSs2GgOBPZlL8Gbq()
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
	private struct _003CDo_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoExpressionAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			UndoExpressionAction undoExpressionAction = default;
			CvsCellLocation zSDlrR2Al = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!idwDOrs2ZFnTljWrYhKn())
					{
						num = 0;
						if (!idwDOrs2ZFnTljWrYhKn())
						{
							continue;
						}
						goto case 4;
					}
					num = 2;
					continue;
				case 4:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0266;
						}
						if (undoExpressionAction.QUDl8i0eiK != null)
						{
							IExternalCellData pd3lZBunxT = undoExpressionAction.Pd3lZBunxT;
							if (pd3lZBunxT != null)
							{
								sZydOIs2JvCDJbp1jucP(pd3lZBunxT);
							}
							((CvsCogSocketSheet)F9bBv9s2zy5GNox1JSOp(Ifrj08s283wVMqwL87KF(undoExpressionAction.fjxlSZ0sUf))).InsertCellExpressionAndRunSheet(undoExpressionAction.zSDlrR2Al4, undoExpressionAction.e48lCGTnBu, true);
							undoExpressionAction.fjxlSZ0sUf.MakeNewResult(updateExposedResults: true);
							CvsCellRange cvsCellRange = CvsCellRange.Empty;
							IEnumerator<CvsCell> enumerator = ((CvsCellCollection)TZ9JmfsWsFwWfhVyc3Pt(HpE32csWwBIZ1SH6HFK2(undoExpressionAction.fjxlSZ0sUf))).GetEnumerator();
							try
							{
								while (N3U6RfsW9kDOZHeZ18r8(enumerator))
								{
									CvsCell current = enumerator.Current;
									int num3 = 5;
									while (true)
									{
										switch (num3)
										{
										case 6:
											if (zSDlrR2Al.Equals(NwxmBwsWh0R6ZUr5wESd(current)))
											{
												break;
											}
											goto case 3;
										default:
											num3 = 3;
											continue;
										case 1:
										case 7:
											zSDlrR2Al = undoExpressionAction.zSDlrR2Al4;
											num3 = 6;
											continue;
										case 3:
											if (cvsCellRange.IsEmpty)
											{
												goto case 2;
											}
											cvsCellRange = cRmvRusWLq2IJtxaH0O9(cvsCellRange, NwxmBwsWh0R6ZUr5wESd(current));
											num3 = 8;
											continue;
										case 2:
										case 4:
											cvsCellRange = new CvsCellRange(NwxmBwsWh0R6ZUr5wESd(current));
											num3 = 0;
											if (idwDOrs2ZFnTljWrYhKn())
											{
											}
											continue;
										case 5:
											if (!undoExpressionAction.yKxlyfMQvy.Contains(NwxmBwsWh0R6ZUr5wESd(current)))
											{
												_ = 1;
												num3 = ((!idwDOrs2ZFnTljWrYhKn()) ? 7 : 2);
												continue;
											}
											break;
										case 0:
										case 8:
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
									aWuKshsWSeuCp3JAS0NP(enumerator);
								}
							}
							undoExpressionAction.KVZlVL1paa = cvsCellRange;
							if (!undoExpressionAction.KVZlVL1paa.IsEmpty)
							{
								awaiter = ((CvsCogSocketSheet)F9bBv9s2zy5GNox1JSOp(undoExpressionAction.fjxlSZ0sUf.CogSocket)).CopyCellsAsync(cvsCellRange).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0266;
							}
						}
						else
						{
							((CvsCogSocket)Ifrj08s283wVMqwL87KF(undoExpressionAction.fjxlSZ0sUf)).Sheet.PutCellExpressionAndRunSheet(undoExpressionAction.zSDlrR2Al4, undoExpressionAction.e48lCGTnBu);
						}
						goto end_IL_003b;
						IL_0266:
						byte[] result = awaiter.GetResult();
						undoExpressionAction.kvYlvFOWsX = result;
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
				case 0:
				case 1:
					undoExpressionAction = _003C_003E4__this;
					num = 4;
					continue;
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
		internal static void sZydOIs2JvCDJbp1jucP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IExternalCellData)P_0).Delete();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ifrj08s283wVMqwL87KF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F9bBv9s2zy5GNox1JSOp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HpE32csWwBIZ1SH6HFK2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TZ9JmfsWsFwWfhVyc3Pt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation NwxmBwsWh0R6ZUr5wESd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange cRmvRusWLq2IJtxaH0O9(CvsCellRange range, CvsCellLocation location)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellRange.Union(range, location);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N3U6RfsW9kDOZHeZ18r8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aWuKshsWSeuCp3JAS0NP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qiCkPJs2gfqp1dsUkV6Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool idwDOrs2ZFnTljWrYhKn()
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
	private struct _003CRedo_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoExpressionAction _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XIIghmsWESBkh1Pj9CVn();
			int num = (nKpuXWsWvaf9tp11wPpx() ? 3 : 4);
			UndoExpressionAction undoExpressionAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					undoExpressionAction = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 10;
								if (nKpuXWsWvaf9tp11wPpx())
								{
									goto IL_0056;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 5;
							}
							goto IL_0223;
						}
						awaiter2 = _003C_003Eu__1;
						num3 = 16;
						if (true)
						{
							goto IL_0223;
						}
						goto end_IL_0039;
						IL_0056:
						_003C_003Eu__2 = default;
						num3 = 14;
						goto IL_0223;
						IL_0223:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 0:
								if (!undoExpressionAction.KVZlVL1paa.IsEmpty)
								{
									_ = 0;
									num3 = ((!XIIghmsWESBkh1Pj9CVn()) ? 15 : 3);
									continue;
								}
								goto IL_029b;
							case 9:
								if (!awaiter2.IsCompleted)
								{
									num3 = 17;
									continue;
								}
								goto case 12;
							case 4:
								awaiter.GetResult();
								num3 = 18;
								continue;
							case 10:
							{
								IExternalCellData pd3lZBunxT = undoExpressionAction.Pd3lZBunxT;
								if (pd3lZBunxT != null)
								{
									pd3lZBunxT.Delete();
									goto case 0;
								}
								num3 = 0;
								continue;
							}
							case 12:
								awaiter2.GetResult();
								awaiter = undoExpressionAction.fjxlSZ0sUf.PasteCellsAsync(undoExpressionAction.KVZlVL1paa, undoExpressionAction.kvYlvFOWsX, cutFromSameSheet: false, runSheet: true).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto case 4;
								}
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								goto case 11;
							case 1:
								_003C_003Eu__1 = awaiter2;
								num3 = 7;
								if (nKpuXWsWvaf9tp11wPpx())
								{
								}
								continue;
							case 11:
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 13:
								awaiter2 = ((CvsCogSocketSheet)jan1NFsWHEpTuWgPpyG3(undoExpressionAction.fjxlSZ0sUf.CogSocket)).PutCellExpressionAsync(undoExpressionAction.zSDlrR2Al4, undoExpressionAction.e48lCGTnBu).GetAwaiter();
								num3 = 9;
								continue;
							case 2:
							case 3:
								if (undoExpressionAction.kvYlvFOWsX != null)
								{
									num3 = 13;
									continue;
								}
								goto IL_029b;
							case 17:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								continue;
							case 6:
								return;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 8:
								return;
							case 18:
								goto end_IL_0223;
								IL_029b:
								((CvsCogSocketSheet)jan1NFsWHEpTuWgPpyG3(yn1BYOsWVG4kJ1KDTQ9E(undoExpressionAction.fjxlSZ0sUf))).PutCellExpressionAndRunSheet(undoExpressionAction.zSDlrR2Al4, undoExpressionAction.e48lCGTnBu);
								goto end_IL_0223;
							}
							goto IL_0056;
							continue;
							end_IL_0223:
							break;
						}
						end_IL_0039:;
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
		internal static object jan1NFsWHEpTuWgPpyG3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yn1BYOsWVG4kJ1KDTQ9E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XIIghmsWESBkh1Pj9CVn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nKpuXWsWvaf9tp11wPpx()
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
	private struct _003CUndo_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoExpressionAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!Q44faxsWDxdu73gkYOh9()) ? 1 : 4);
			UndoExpressionAction undoExpressionAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					undoExpressionAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								goto IL_00c1;
							}
							num3 = 18;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_0251;
						IL_0251:
						while (true)
						{
							switch (num3)
							{
							case 18:
							{
								IExternalCellData pd3lZBunxT = undoExpressionAction.Pd3lZBunxT;
								if (pd3lZBunxT == null)
								{
									num3 = 10;
									if (0 == 0)
									{
										continue;
									}
									goto case 12;
								}
								pd3lZBunxT.Restore();
								goto case 10;
							}
							case 12:
								awaiter = wAIn47sWq2cycM1oOWQR(undoExpressionAction.fjxlSZ0sUf.PasteCellsAsync(new CvsCellRange(undoExpressionAction.zSDlrR2Al4), undoExpressionAction.QUDl8i0eiK, cutFromSameSheet: false, runSheet: true));
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									continue;
								}
								goto case 9;
							case 13:
							case 16:
								break;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 1;
								if (!Q44faxsWDxdu73gkYOh9())
								{
									num3 = 14;
									continue;
								}
								num3 = 13;
								if (0 == 0)
								{
									continue;
								}
								goto end_IL_0251;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 17;
								continue;
							case 9:
								awaiter.GetResult();
								num3 = 20;
								continue;
							case 3:
								awaiter = ((Task)bSljmEsWUPlowpUfeRE4(undoExpressionAction.fjxlSZ0sUf, new CvsCellRange(undoExpressionAction.zSDlrR2Al4), undoExpressionAction.QUDl8i0eiK, false, false)).GetAwaiter();
								num3 = 5;
								continue;
							case 1:
								vejO3isWiEDt8oMLkhUd(qI67eXsWdwTTcs6smR2T(FoEPqXsWTDv4rPCqPmHo(undoExpressionAction.fjxlSZ0sUf)), undoExpressionAction.KVZlVL1paa);
								num3 = 8;
								continue;
							case 10:
								if (!undoExpressionAction.KVZlVL1paa.IsEmpty)
								{
									num3 = 2;
									if (true)
									{
										continue;
									}
									return;
								}
								goto IL_01c7;
							case 14:
							case 15:
								return;
							case 8:
								goto end_IL_0251;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									if (!Q44faxsWDxdu73gkYOh9())
									{
										continue;
									}
									return;
								}
								goto case 19;
							case 7:
								return;
							case 17:
								num2 = (_003C_003E1__state = -1);
								goto case 19;
							default:
								num3 = 19;
								if (0 == 0)
								{
									continue;
								}
								goto case 19;
							case 19:
								awaiter.GetResult();
								num3 = 1;
								continue;
							case 2:
								if (undoExpressionAction.kvYlvFOWsX != null)
								{
									num3 = 3;
									continue;
								}
								goto IL_01c7;
							case 20:
								goto end_IL_0251;
								IL_01c7:
								if (undoExpressionAction.QUDl8i0eiK != null)
								{
									num3 = 12;
									continue;
								}
								vejO3isWiEDt8oMLkhUd(((CvsCogSocket)FoEPqXsWTDv4rPCqPmHo(undoExpressionAction.fjxlSZ0sUf)).Sheet, new CvsCellRange(undoExpressionAction.zSDlrR2Al4));
								goto end_IL_0251;
							}
							goto IL_00c1;
							continue;
							end_IL_0251:
							break;
						}
						goto end_IL_003b;
						IL_00c1:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_0251;
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
					if (LS8cfrsWATtfT4vJBRr9())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 3:
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
		internal static object bSljmEsWUPlowpUfeRE4(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FoEPqXsWTDv4rPCqPmHo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qI67eXsWdwTTcs6smR2T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vejO3isWiEDt8oMLkhUd(object P_0, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ClearCellsAndRunSheet(cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter wAIn47sWq2cycM1oOWQR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LS8cfrsWATtfT4vJBRr9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q44faxsWDxdu73gkYOh9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight fjxlSZ0sUf;

	private readonly CvsCellLocation zSDlrR2Al4;

	private readonly string e48lCGTnBu;

	private readonly string ARql2hkP3H;

	private List<CvsCellLocation> yKxlyfMQvy;

	private CvsCellRange KVZlVL1paa;

	private byte[] kvYlvFOWsX;

	private IExternalCellData Pd3lZBunxT;

	private byte[] QUDl8i0eiK;

	public virtual string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ARql2hkP3H;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoExpressionAction(CvsInSight inSight, CvsCellLocation cellLocation, string newExpression, string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00af;
		IL_001a:
		e48lCGTnBu = newExpression;
		num = 8;
		goto IL_00af;
		IL_00af:
		while (true)
		{
			switch (num)
			{
			case 9:
				break;
			case 5:
				zSDlrR2Al4 = cellLocation;
				num = 9;
				if (bmnty9tEPXUjsKwb25H())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				base._002Ector();
				goto case 4;
			case 7:
				yKxlyfMQvy = new List<CvsCellLocation>();
				num = 1;
				continue;
			case 8:
				ARql2hkP3H = text;
				num = 10;
				if (bmnty9tEPXUjsKwb25H())
				{
					continue;
				}
				goto case 2;
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 7;
				continue;
			case 4:
			case 6:
				fjxlSZ0sUf = inSight;
				goto case 5;
			default:
				num = 5;
				continue;
			case 1:
				KVZlVL1paa = CvsCellRange.Empty;
				_ = 0;
				if (!bmnty9tEPXUjsKwb25H())
				{
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 7;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				return;
			case 10:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoExpressionAction(CvsInSight inSight, CvsCellLocation cellLocation, string newExpression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bmnWQBtHT1JVpAUiIan();
		this._002Ector(inSight, cellLocation, newExpression, (string)Pt1lA0tAStOQNyF32N4(ysHICutVWIhivZJudmR(), cellLocation.ToString()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__13))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		g3wxxPtv1nbNwKPNxI9();
		int num = ((!bmnty9tEPXUjsKwb25H()) ? 2 : 5);
		_003CSaveState_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = x3PYDrtDxPoX401eKlu();
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__14))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CDo_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (bmnty9tEPXUjsKwb25H())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (g3wxxPtv1nbNwKPNxI9())
				{
					num = 0;
					continue;
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				if (true)
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__15))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CRedo_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = x3PYDrtDxPoX401eKlu();
				_ = 0;
				num = (bmnty9tEPXUjsKwb25H() ? 4 : 0);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (g3wxxPtv1nbNwKPNxI9())
				{
				}
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__16))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (bmnty9tEPXUjsKwb25H())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_00b3;
			}
		}
		_003CUndo_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = x3PYDrtDxPoX401eKlu();
				goto case 1;
			case 6:
				break;
			}
			break;
		}
		goto IL_00b3;
		IL_00b3:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bmnty9tEPXUjsKwb25H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool g3wxxPtv1nbNwKPNxI9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bmnWQBtHT1JVpAUiIan()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ysHICutVWIhivZJudmR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionExpression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Pt1lA0tAStOQNyF32N4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder x3PYDrtDxPoX401eKlu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
