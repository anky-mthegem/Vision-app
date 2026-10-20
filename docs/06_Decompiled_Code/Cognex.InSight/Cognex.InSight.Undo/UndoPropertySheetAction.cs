using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoPropertySheetAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPropertySheetAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (DEPwUAs5uuqPi1HeBkoe())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (!DEPwUAs5uuqPi1HeBkoe())
				{
					goto IL_0290;
				}
			}
			goto IL_0233;
			IL_0233:
			UndoPropertySheetAction undoPropertySheetAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<byte[]> awaiter2;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_01f1;
							}
							awaiter2 = ((CvsCogSocketSheet)ae0Yx1s5RrjTUJp1WNYF(undoPropertySheetAction.fBdqav5kdd.CogSocket)).CopyCellsAsync(new CvsCellRange(undoPropertySheetAction.CellLocation)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						byte[] result = awaiter2.GetResult();
						undoPropertySheetAction.k2jqhJ88Tw = result;
						CvsCell cvsCell = (CvsCell)TkZLCXs5ng74Jl8btQcu(fZSEEns5aIsSxSUqip9q(undoPropertySheetAction.fBdqav5kdd.Results), undoPropertySheetAction.CellLocation);
						if (!CvsCell.IsNullOrEmpty(cvsCell))
						{
							undoPropertySheetAction.ltrqpOdkkX = (string)u0veKys5GdaWYyMHHFqv(cvsCell);
						}
						IEnumerator<CvsCell> enumerator = ((CvsResultSet)oBZEQHs5XiDGWPSsHHbN(undoPropertySheetAction.fBdqav5kdd)).Cells.GetEnumerator();
						try
						{
							while (pq3rens56F0PcOHn8fJ4(enumerator))
							{
								CvsCell current = enumerator.Current;
								mqunY8s5IiBRA0i4cH38();
								int num3;
								if (DEPwUAs5uuqPi1HeBkoe())
								{
									num3 = 2;
								}
								else
								{
									num3 = 3;
									if (1 == 0)
									{
										continue;
									}
								}
								switch (num3)
								{
								case 0:
								case 2:
									undoPropertySheetAction.xVYqluiaCA.Add(oibebms5bd2dx43iFe4C(current));
									break;
								}
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								xLAe4Gs5pCpif113Q92v(enumerator);
							}
						}
						awaiter = Task.CompletedTask.GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01f1;
						IL_01f1:
						awaiter.GetResult();
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
					continue;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					undoPropertySheetAction = _003C_003E4__this;
					goto case 2;
				case 0:
				case 5:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_0290;
			IL_0290:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_0233;
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
		internal static object ae0Yx1s5RrjTUJp1WNYF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fZSEEns5aIsSxSUqip9q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TkZLCXs5ng74Jl8btQcu(object P_0, CvsCellLocation cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[cell];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u0veKys5GdaWYyMHHFqv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oBZEQHs5XiDGWPSsHHbN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation oibebms5bd2dx43iFe4C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pq3rens56F0PcOHn8fJ4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xLAe4Gs5pCpif113Q92v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DEPwUAs5uuqPi1HeBkoe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mqunY8s5IiBRA0i4cH38()
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
	private struct _003CDo_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPropertySheetAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!HHnOJss54FTS430J3yXE())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (HHnOJss54FTS430J3yXE())
				{
				}
			}
			UndoPropertySheetAction undoPropertySheetAction = default;
			CvsCellLocation cellLocation = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					undoPropertySheetAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter2;
						if ((uint)num2 <= 2u || num2 != 3)
						{
							try
							{
								TaskAwaiter<byte[]> awaiter;
								byte[] result;
								CvsCellRange cvsCellRange;
								IEnumerator<CvsCell> enumerator;
								switch (num2)
								{
								default:
									awaiter2 = f67saMs5FTokoH2eQG8N(jfBcUhs5fsdtUSejwrPs(SLYmlSs5kYxAX0msobcU(undoPropertySheetAction.fBdqav5kdd), undoPropertySheetAction.CellLocation, undoPropertySheetAction.v6tqOayS4C));
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									}
									goto IL_00fb;
								case 0:
									awaiter2 = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_00fb;
								case 1:
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0193;
								case 2:
									{
										awaiter = _003C_003Eu__2;
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_0382;
									}
									IL_0382:
									result = awaiter.GetResult();
									undoPropertySheetAction.gDEqqtKSXt = result;
									break;
									IL_00fb:
									awaiter2.GetResult();
									undoPropertySheetAction.fBdqav5kdd.MakeNewResult(updateExposedResults: true);
									if (aEAi8Ks5mtSDGvvl3pX3(undoPropertySheetAction.fBdqav5kdd))
									{
										awaiter = ((CvsCogSocketSheet)cbRPXAs5gGHTXubrlteL(gyjEaKs5yESuOjSeotHv(undoPropertySheetAction.fBdqav5kdd))).CopyCellsAsync(new CvsCellRange(undoPropertySheetAction.CellLocation)).GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 1);
											_003C_003Eu__2 = awaiter;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											return;
										}
										goto IL_0193;
									}
									goto end_IL_007c;
									IL_0193:
									result = awaiter.GetResult();
									undoPropertySheetAction.PrDq4oHto5 = result;
									cvsCellRange = CvsCellRange.Empty;
									enumerator = undoPropertySheetAction.fBdqav5kdd.Results.Cells.GetEnumerator();
									try
									{
										while (qUDymCs58sXdLeXdrhdl(enumerator))
										{
											CvsCell current = enumerator.Current;
											int num3 = 6;
											while (true)
											{
												switch (num3)
												{
												case 7:
													if (cvsCellRange.IsEmpty)
													{
														SSbMFTs50ju24xANngkq();
														num3 = (HHnOJss54FTS430J3yXE() ? 1 : 0);
													}
													else
													{
														cvsCellRange = OMTPans5J6Q5ri80POcw(cvsCellRange, current.Location);
														num3 = 8;
													}
													continue;
												case 3:
													if (cellLocation.Equals(nEM1MTs5ZHevVlamtrOO(current)))
													{
														break;
													}
													goto case 7;
												default:
													num3 = 7;
													if (SSbMFTs50ju24xANngkq())
													{
														continue;
													}
													goto case 0;
												case 0:
												case 4:
													cvsCellRange = new CvsCellRange(nEM1MTs5ZHevVlamtrOO(current));
													break;
												case 6:
													if (!undoPropertySheetAction.xVYqluiaCA.Contains(current.Location))
													{
														num3 = 2;
														continue;
													}
													break;
												case 2:
													cellLocation = undoPropertySheetAction.CellLocation;
													num3 = 3;
													continue;
												case 1:
												case 5:
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
											pC7Fiks5zGS8XDTBnrDJ(enumerator);
										}
									}
									undoPropertySheetAction.I59qg7gIMR = cvsCellRange;
									if (undoPropertySheetAction.I59qg7gIMR.IsEmpty)
									{
										break;
									}
									awaiter = ((CvsCogSocketSheet)cbRPXAs5gGHTXubrlteL(gyjEaKs5yESuOjSeotHv(undoPropertySheetAction.fBdqav5kdd))).CopyCellsAsync(undoPropertySheetAction.I59qg7gIMR).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__2 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_0382;
								}
								object obj = yy0OqYsosxvQmdF0TgVS(A8PwoZsowAsk94eubao1(undoPropertySheetAction.fBdqav5kdd), undoPropertySheetAction.ltrqpOdkkX);
								CvsFunction cvsFunction = ((CvsFunctionTable)A8PwoZsowAsk94eubao1(undoPropertySheetAction.fBdqav5kdd)).FindFunction(undoPropertySheetAction.v6tqOayS4C);
								if (obj != cvsFunction)
								{
									CvsCell cvsCell = (CvsCell)KCHu4rsoLPh6ybkSMOtH(ftLDqxsohP4JXmwUR62A(undoPropertySheetAction.fBdqav5kdd.Results), undoPropertySheetAction.CellLocation);
									IExternalCellDataHandler externalCellDataHandler = UndoHandler.GetExternalCellDataHandler(cvsCell);
									if (externalCellDataHandler != null)
									{
										undoPropertySheetAction.IoWqTESPBC = externalCellDataHandler.SaveState(undoPropertySheetAction.fBdqav5kdd, nEM1MTs5ZHevVlamtrOO(cvsCell));
									}
								}
								end_IL_007c:;
							}
							catch (CvsNetworkException ex)
							{
								rYg60Cso9WCUCuHgNU0q(CvsTraceSDK.Error, ex);
								throw;
							}
							catch (CvsNotConnectedException)
							{
							}
							awaiter2 = f67saMs5FTokoH2eQG8N(P6lJtssoSZE0Y5UdKoIf());
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
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
					goto case 5;
				default:
					num = 5;
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
		internal static object SLYmlSs5kYxAX0msobcU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PropSheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jfBcUhs5fsdtUSejwrPs(object P_0, CvsCellLocation location, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsPropSheet)P_0).AcceptAsync(location, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter f67saMs5FTokoH2eQG8N(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aEAi8Ks5mtSDGvvl3pX3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UndoHandler.CanUndo((CvsInSight)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gyjEaKs5yESuOjSeotHv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cbRPXAs5gGHTXubrlteL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation nEM1MTs5ZHevVlamtrOO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange OMTPans5J6Q5ri80POcw(CvsCellRange range, CvsCellLocation location)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellRange.Union(range, location);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qUDymCs58sXdLeXdrhdl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pC7Fiks5zGS8XDTBnrDJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A8PwoZsowAsk94eubao1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yy0OqYsosxvQmdF0TgVS(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunctionTable)P_0).FindFunction((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ftLDqxsohP4JXmwUR62A(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KCHu4rsoLPh6ybkSMOtH(object P_0, CvsCellLocation cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[cell];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rYg60Cso9WCUCuHgNU0q(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object P6lJtssoSZE0Y5UdKoIf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SSbMFTs50ju24xANngkq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HHnOJss54FTS430J3yXE()
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
	private struct _003CRedo_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPropertySheetAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!MOxd2isoEMSukCr72LAa()) ? 1 : 4);
			UndoPropertySheetAction undoPropertySheetAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					undoPropertySheetAction = _003C_003E4__this;
					goto case 1;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
						{
							IExternalCellData ioWqTESPBC = undoPropertySheetAction.IoWqTESPBC;
							if (ioWqTESPBC == null)
							{
								num3 = 5;
								goto IL_027a;
							}
							H1rDYbsoHGa3bkxwG5hV(ioWqTESPBC);
							goto IL_0128;
						}
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 3;
							goto IL_027a;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 23;
							goto IL_027a;
						case 1:
							{
								awaiter = _003C_003Eu__1;
								num3 = 4;
								goto IL_027a;
							}
							IL_027a:
							while (true)
							{
								switch (num3)
								{
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									continue;
								case 3:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_00b2;
								case 12:
									break;
								case 0:
								case 19:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 16;
									continue;
								case 9:
									awaiter = F2CUiYsoVYlps41G5ChX(undoPropertySheetAction.fBdqav5kdd.PasteCellsAsync(new CvsCellRange(undoPropertySheetAction.CellLocation), undoPropertySheetAction.PrDq4oHto5, cutFromSameSheet: false, runSheet: false));
									num3 = 7;
									continue;
								case 5:
									goto end_IL_027a;
								case 13:
									num2 = (_003C_003E1__state = 0);
									num3 = 1;
									continue;
								case 6:
									return;
								case 16:
									return;
								case 1:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 6;
									continue;
								case 22:
									if (!awaiter.IsCompleted)
									{
										num3 = 10;
										continue;
									}
									goto IL_02fe;
								case 7:
									if (!awaiter.IsCompleted)
									{
										num3 = 13;
										continue;
									}
									goto IL_00b2;
								case 20:
									goto end_IL_0064;
								case 18:
									return;
								case 11:
									if (!awaiter.IsCompleted)
									{
										goto IL_0236;
									}
									goto case 23;
								case 17:
								case 21:
									num2 = (_003C_003E1__state = 2);
									num3 = 14;
									continue;
								case 10:
									num2 = (_003C_003E1__state = 1);
									goto case 2;
								default:
									num3 = 2;
									continue;
								case 4:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_02fe;
								case 15:
									awaiter = F2CUiYsoVYlps41G5ChX(VJTHFEsoAgVILLHWuMLZ(undoPropertySheetAction.fBdqav5kdd, undoPropertySheetAction.I59qg7gIMR, undoPropertySheetAction.gDEqqtKSXt, false, true));
									num3 = 22;
									if (true)
									{
										continue;
									}
									goto case 8;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 18;
									continue;
								case 14:
									_003C_003Eu__1 = awaiter;
									goto case 0;
								case 23:
									{
										awaiter.GetResult();
										goto end_IL_0064;
									}
									IL_00b2:
									awaiter.GetResult();
									num3 = 15;
									continue;
									IL_02fe:
									awaiter.GetResult();
									num3 = 20;
									continue;
								}
								if (undoPropertySheetAction.gDEqqtKSXt != null)
								{
									num3 = 9;
									continue;
								}
								goto IL_01e6;
								IL_0236:
								_ = 0;
								num3 = (MOxd2isoEMSukCr72LAa() ? 21 : 0);
								continue;
								end_IL_027a:
								break;
							}
							goto IL_0128;
							IL_01e6:
							awaiter = F2CUiYsoVYlps41G5ChX(undoPropertySheetAction.fBdqav5kdd.PasteCellsAsync(new CvsCellRange(undoPropertySheetAction.CellLocation), undoPropertySheetAction.PrDq4oHto5, cutFromSameSheet: false, runSheet: true));
							num3 = 11;
							goto IL_027a;
							IL_0128:
							if (undoPropertySheetAction.I59qg7gIMR.IsEmpty)
							{
								goto IL_01e6;
							}
							num3 = 12;
							goto IL_027a;
							end_IL_0064:
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
					goto case 5;
				default:
					num = 5;
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
		internal static void H1rDYbsoHGa3bkxwG5hV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IExternalCellData)P_0).Restore();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter F2CUiYsoVYlps41G5ChX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VJTHFEsoAgVILLHWuMLZ(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MOxd2isoEMSukCr72LAa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gMRPKbsovnG91kCcteSa()
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
	private struct _003CUndo_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoPropertySheetAction _003C_003E4__this;

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
			TaskAwaiter awaiter = default;
			UndoPropertySheetAction undoPropertySheetAction = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					if (DLxshisoD6wWeEOw15nx())
					{
						num = 0;
						break;
					}
					num = 4;
					if (DLxshisoD6wWeEOw15nx())
					{
						break;
					}
					return;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 12;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 14;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (!DLxshisoD6wWeEOw15nx())
							{
								goto IL_0103;
							}
						}
						goto IL_0262;
						IL_0262:
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = default;
								goto case 7;
							case 0:
								break;
							case 12:
								goto IL_00af;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 11:
								goto IL_0103;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 2:
								return;
							case 18:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 7:
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 15;
								continue;
							case 13:
							case 16:
							{
								IExternalCellData ioWqTESPBC = undoPropertySheetAction.IoWqTESPBC;
								if (ioWqTESPBC == null)
								{
									num3 = 19;
									if (0 == 0)
									{
										continue;
									}
									goto case 14;
								}
								IonI4rsoisiuGLLNb2TY(ioWqTESPBC);
								goto end_IL_004c;
							}
							case 14:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 17:
								awaiter = LKhPxQsoTKwGFHEHfaFM(undoPropertySheetAction.fBdqav5kdd.PasteCellsAsync(new CvsCellRange(undoPropertySheetAction.CellLocation), undoPropertySheetAction.k2jqhJ88Tw, cutFromSameSheet: false, runSheet: false));
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 15;
							case 15:
								awaiter.GetResult();
								((CvsCogSocketSheet)TFs6UUsod3UnSLsQhkfM(undoPropertySheetAction.fBdqav5kdd.CogSocket)).ClearCellsAndRunSheet(undoPropertySheetAction.I59qg7gIMR);
								goto case 13;
							default:
								num3 = 13;
								continue;
							case 1:
							case 8:
								goto IL_02c1;
							case 19:
								goto end_IL_004c;
							}
							break;
							IL_02c1:
							if (undoPropertySheetAction.gDEqqtKSXt != null)
							{
								num3 = 17;
								continue;
							}
							goto IL_0127;
							IL_0127:
							awaiter = LKhPxQsoTKwGFHEHfaFM(undoPropertySheetAction.fBdqav5kdd.PasteCellsAsync(new CvsCellRange(undoPropertySheetAction.CellLocation), undoPropertySheetAction.k2jqhJ88Tw, cutFromSameSheet: false, runSheet: true));
							num3 = 11;
							continue;
							IL_00af:
							if (!undoPropertySheetAction.I59qg7gIMR.IsEmpty)
							{
								DLxshisoD6wWeEOw15nx();
								if (lQKn4EsoUbnfmObri8Vr())
								{
									num3 = 10;
									if (1 == 0)
									{
										break;
									}
								}
								else
								{
									num3 = 8;
								}
								continue;
							}
							goto IL_0127;
						}
						goto IL_0094;
						IL_0103:
						if (awaiter.IsCompleted)
						{
							goto IL_0094;
						}
						num2 = (_003C_003E1__state = 1);
						num3 = 18;
						goto IL_0262;
						IL_0094:
						awaiter.GetResult();
						num3 = 16;
						if (lQKn4EsoUbnfmObri8Vr())
						{
						}
						goto IL_0262;
						end_IL_004c:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					if (DLxshisoD6wWeEOw15nx())
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					undoPropertySheetAction = _003C_003E4__this;
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
		internal static TaskAwaiter LKhPxQsoTKwGFHEHfaFM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TFs6UUsod3UnSLsQhkfM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IonI4rsoisiuGLLNb2TY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IExternalCellData)P_0).Delete();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DLxshisoD6wWeEOw15nx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lQKn4EsoUbnfmObri8Vr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight fBdqav5kdd;

	private readonly string v6tqOayS4C;

	private string ltrqpOdkkX;

	private byte[] k2jqhJ88Tw;

	private byte[] PrDq4oHto5;

	private List<CvsCellLocation> xVYqluiaCA;

	private CvsCellRange I59qg7gIMR;

	private byte[] gDEqqtKSXt;

	private IExternalCellData IoWqTESPBC;

	[CompilerGenerated]
	private string gRXqBQKlDh;

	[CompilerGenerated]
	private CvsCellLocation aldqJMogij;

	public virtual string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gRXqBQKlDh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gRXqBQKlDh = value;
		}
	}

	protected CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aldqJMogij;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aldqJMogij = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoPropertySheetAction(CvsInSight inSight, CvsCellLocation cellLocation, string newExpression, string text = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 2:
				base._002Ector();
				goto default;
			case 7:
				CellLocation = cellLocation;
				num = 9;
				if (dxfg8tCYYPqLDLV0YA8())
				{
					break;
				}
				goto case 3;
			case 3:
				I59qg7gIMR = CvsCellRange.Empty;
				num = 2;
				break;
			case 9:
				v6tqOayS4C = newExpression;
				num = 10;
				if (dxfg8tCYYPqLDLV0YA8())
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				ltrqpOdkkX = string.Empty;
				num = 6;
				break;
			case 8:
				S8jCLeCxcKKmpnE7UhV();
				WwWgBACNmCbGAp2L88X();
				if (!dxfg8tCYYPqLDLV0YA8())
				{
					num = 0;
					if (!WwWgBACNmCbGAp2L88X())
					{
						break;
					}
					goto case 7;
				}
				num = 4;
				if (true)
				{
					break;
				}
				goto default;
			default:
				fBdqav5kdd = inSight;
				num = 7;
				break;
			case 6:
				xVYqluiaCA = new List<CvsCellLocation>();
				num = 3;
				break;
			case 10:
				Text = (string)(QjXFshC1gePC1R0aHZM(text) ? WUbRa0C3QkO3BgCLaJm(SXJHyaCrtMkNxJ4xiUK(), CellLocation.ToString()) : text);
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__18))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WwWgBACNmCbGAp2L88X();
		int num;
		if (dxfg8tCYYPqLDLV0YA8())
		{
			num = 2;
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_00c5;
			}
		}
		_003CSaveState_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (WwWgBACNmCbGAp2L88X())
				{
				}
				continue;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (!WwWgBACNmCbGAp2L88X())
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 6:
				break;
			}
			break;
		}
		goto IL_00c5;
		IL_00c5:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__19))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (WwWgBACNmCbGAp2L88X() ? 5 : 3);
		_003CDo_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = Wlxoj1COEBAnnMQPgt0();
				num = 1;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__20))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRedo_003Ed__20 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 0:
				stateMachine._003C_003Et__builder = Wlxoj1COEBAnnMQPgt0();
				_ = 0;
				num = (dxfg8tCYYPqLDLV0YA8() ? 5 : 4);
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__21))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CUndo_003Ed__21 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (WwWgBACNmCbGAp2L88X())
				{
				}
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 2:
				do
				{
					stateMachine._003C_003Et__builder = Wlxoj1COEBAnnMQPgt0();
					_ = 0;
					if (!dxfg8tCYYPqLDLV0YA8())
					{
						num = 0;
						continue;
					}
					num = 4;
					break;
				}
				while (!dxfg8tCYYPqLDLV0YA8());
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S8jCLeCxcKKmpnE7UhV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QjXFshC1gePC1R0aHZM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SXJHyaCrtMkNxJ4xiUK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionPropertySheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WUbRa0C3QkO3BgCLaJm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dxfg8tCYYPqLDLV0YA8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WwWgBACNmCbGAp2L88X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Wlxoj1COEBAnnMQPgt0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
