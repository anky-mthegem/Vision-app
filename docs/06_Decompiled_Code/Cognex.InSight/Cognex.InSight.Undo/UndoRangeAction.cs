using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public abstract class UndoRangeAction : UndoAction
{
	protected class StoredRange
	{
		public readonly CvsCellRange Range;

		public byte[] BackupData;

		internal List<IExternalCellData> ExternalCellData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoredRange(CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			do
			{
				IL_0056:
				switch (num)
				{
				case 1:
				case 3:
					Range = range;
					break;
				case 5:
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					num = 0;
					goto IL_0056;
				case 2:
					OgfHowsojI3Twy7Q8S0Y(this);
					goto default;
				default:
					i0WYtusoqGDdvEPegxku();
					num = ((!PmJFohsoBQm9HE7vcjkm()) ? 1 : 6);
					goto IL_0056;
				case 0:
					ExternalCellData = new List<IExternalCellData>();
					num = 2;
					goto IL_0056;
				case 4:
				case 6:
					break;
				case 7:
					return;
				}
				BackupData = null;
				num = 7;
			}
			while (0 == 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RestoreExternalData()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			foreach (IExternalCellData externalCellDatum in ExternalCellData)
			{
				xSaLursocbyahJPsNgQG(externalCellDatum);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteExternalData()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			foreach (IExternalCellData externalCellDatum in ExternalCellData)
			{
				IuRavYso26yaeOZKiByo(externalCellDatum);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OgfHowsojI3Twy7Q8S0Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i0WYtusoqGDdvEPegxku()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PmJFohsoBQm9HE7vcjkm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xSaLursocbyahJPsNgQG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IExternalCellData)P_0).Restore();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IuRavYso26yaeOZKiByo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IExternalCellData)P_0).Delete();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRangeAction _003C_003E4__this;

		private int _003Ci_003E5__2;

		private StoredRange _003C_003E7__wrap2;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!tLZtoKsoCJQe7RQFuIUB())
			{
				goto IL_001e;
			}
			goto IL_02b5;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 1;
			if (!qeVSbDsoKaFJATgqaEuW())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (!tLZtoKsoCJQe7RQFuIUB())
				{
					goto IL_02ec;
				}
			}
			goto IL_02b5;
			IL_02ec:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				return;
			}
			goto IL_02b5;
			IL_02b5:
			UndoRangeAction undoRangeAction = default;
			IExternalCellDataHandler externalCellDataHandler = default;
			IExternalCellData externalCellData = default;
			CvsCell cvsCell = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 4:
					undoRangeAction = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						if (num2 != 0)
						{
							_003Ci_003E5__2 = 0;
							goto IL_0267;
						}
						TaskAwaiter<byte[]> awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_00e9;
						IL_00e9:
						byte[] result = awaiter.GetResult();
						_003C_003E7__wrap2.BackupData = result;
						_003C_003E7__wrap2 = null;
						IEnumerator<CvsCellLocation> enumerator = undoRangeAction.StoredRanges[_003Ci_003E5__2].Range.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								CvsCellLocation current = enumerator.Current;
								int num3 = 1;
								while (true)
								{
									switch (num3)
									{
									case 2:
										if (externalCellDataHandler == null)
										{
											break;
										}
										goto case 7;
									default:
										num3 = 7;
										continue;
									case 0:
									case 4:
										if (externalCellData == null)
										{
											break;
										}
										goto case 3;
									case 3:
									case 5:
										undoRangeAction.StoredRanges[_003Ci_003E5__2].ExternalCellData.Add(externalCellData);
										num3 = 8;
										continue;
									case 7:
										externalCellData = externalCellDataHandler.SaveState(undoRangeAction.InSight, c8UFNJsoNBth3nFULsQN(cvsCell));
										qeVSbDsoKaFJATgqaEuW();
										if (!tLZtoKsoCJQe7RQFuIUB())
										{
											num3 = 3;
											if (0 == 0)
											{
												continue;
											}
											goto case 3;
										}
										num3 = 0;
										continue;
									case 6:
										externalCellDataHandler = UndoHandler.GetExternalCellDataHandler(cvsCell);
										num3 = 2;
										continue;
									case 1:
										cvsCell = (CvsCell)lXBjSKsoY9kBPBce7yXS(vJyLrisoPvbUAX8o7xHL(undoRangeAction.InSight.Results), current);
										num3 = 6;
										if (!qeVSbDsoKaFJATgqaEuW())
										{
											continue;
										}
										break;
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
								yGDV6fsoxaConfN4TmXg(enumerator);
							}
						}
						_003Ci_003E5__2++;
						goto IL_0267;
						IL_0267:
						if (_003Ci_003E5__2 < undoRangeAction.StoredRanges.Length)
						{
							_003C_003E7__wrap2 = undoRangeAction.StoredRanges[_003Ci_003E5__2];
							awaiter = ((CvsCogSocketSheet)wf3t3esoohKS61jtlEty(e4O6JXso5FptOt6jcknb(undoRangeAction.InSight))).CopyCellsAsync(undoRangeAction.StoredRanges[_003Ci_003E5__2].Range).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00e9;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_02ec;
				default:
					goto IL_02ec;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object e4O6JXso5FptOt6jcknb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wf3t3esoohKS61jtlEty(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vJyLrisoPvbUAX8o7xHL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lXBjSKsoY9kBPBce7yXS(object P_0, CvsCellLocation cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[cell];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation c8UFNJsoNBth3nFULsQN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yGDV6fsoxaConfN4TmXg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tLZtoKsoCJQe7RQFuIUB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qeVSbDsoKaFJATgqaEuW()
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
	private struct _003CDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRangeAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dR7gNusoreny7cOUrdYO();
			int num;
			if (yKHDWpso1rvfDpatcHcr())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0189;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0189;
			IL_0189:
			int num2 = default;
			UndoRangeAction undoRangeAction = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = qaVXWuso3Wf1D5sKDFbl(undoRangeAction.Redo());
							_ = 0;
							if (yKHDWpso1rvfDpatcHcr())
							{
								num3 = 2;
							}
							else
							{
								num3 = 7;
								if (1 == 0)
								{
									goto IL_0085;
								}
							}
							goto IL_00e9;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00a9;
						IL_00e9:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 1:
								break;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 5:
							case 7:
								goto IL_00a9;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_003f;
							}
							break;
						}
						goto IL_0085;
						IL_0085:
						_003C_003Eu__1 = awaiter;
						num3 = 6;
						goto IL_00e9;
						IL_00a9:
						_003C_003Eu__1 = default;
						num3 = 4;
						if (dR7gNusoreny7cOUrdYO())
						{
						}
						goto IL_00e9;
						end_IL_003f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
					undoRangeAction = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static TaskAwaiter qaVXWuso3Wf1D5sKDFbl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yKHDWpso1rvfDpatcHcr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dR7gNusoreny7cOUrdYO()
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
	private struct _003CUndo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRangeAction _003C_003E4__this;

		private int _003Ci_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoRangeAction undoRangeAction = default;
			int num4 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ci_003E5__2 = 0;
							num3 = 10;
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
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 0:
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
							case 10:
								if (_003Ci_003E5__2 < undoRangeAction.StoredRanges.Length)
								{
									awaiter = ACmy6VsolAMoc2YSNwUI(sO9Di8soQUWxIkGfGDH3(undoRangeAction.m_InSight, undoRangeAction.StoredRanges[_003Ci_003E5__2].Range, undoRangeAction.StoredRanges[_003Ci_003E5__2].BackupData, false, false));
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto case 3;
								}
								num3 = 12;
								if (!FPgwoLsoMCnq5nNHPvJC())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								awaiter.GetResult();
								goto case 6;
							case 11:
								_003C_003Eu__1 = default;
								goto default;
							default:
								_ = 0;
								if (!Sal8J6soOyj0x9SHq8GT())
								{
									num3 = 6;
									if (0 == 0)
									{
										continue;
									}
									goto case 11;
								}
								num3 = 0;
								continue;
							case 4:
								_003Ci_003E5__2 = num4 + 1;
								num3 = 8;
								continue;
							case 6:
							case 7:
								num4 = _003Ci_003E5__2;
								num3 = 4;
								if (!FPgwoLsoMCnq5nNHPvJC())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 12:
								((CvsCogSocketSheet)vJoIl7souVe4R6jfcdr1(RevE7QsoeVd1YalP7eUY(undoRangeAction.m_InSight))).Run(true);
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
					goto case 5;
				default:
					num = 5;
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 3:
					undoRangeAction = _003C_003E4__this;
					goto case 2;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (Sal8J6soOyj0x9SHq8GT() ? 3 : 4);
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
		internal static object sO9Di8soQUWxIkGfGDH3(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ACmy6VsolAMoc2YSNwUI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RevE7QsoeVd1YalP7eUY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vJoIl7souVe4R6jfcdr1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Sal8J6soOyj0x9SHq8GT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FPgwoLsoMCnq5nNHPvJC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected readonly StoredRange[] StoredRanges;

	protected readonly CvsInSight m_InSight;

	protected CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return m_InSight;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected UndoRangeAction(CvsInSight inSight, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nV7siZCl56ZRVvwdXiV();
		this._002Ector(inSight, new CvsCellRange[1] { range });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected UndoRangeAction(CvsInSight inSight, IEnumerable<CvsCellRange> ranges)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector();
		m_InSight = inSight;
		StoredRanges = ranges.Select([MethodImpl(MethodImplOptions.NoInlining)] (CvsCellRange r) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new StoredRange(r);
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public virtual Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				if (!zrZgeNCQFBNsfLZwm4s())
				{
					num = 4;
					break;
				}
				num = 0;
				if (zrZgeNCQFBNsfLZwm4s())
				{
				}
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
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public virtual Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		NPXf38CMjjCbrgjybdE();
		int num = (zrZgeNCQFBNsfLZwm4s() ? 3 : 2);
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = EbIkXMCeEsBjvFqqLZN();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	public abstract Task Redo();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public virtual Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = EbIkXMCeEsBjvFqqLZN();
				num = 4;
				if (NPXf38CMjjCbrgjybdE())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				zrZgeNCQFBNsfLZwm4s();
				num = (NPXf38CMjjCbrgjybdE() ? 1 : 5);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nV7siZCl56ZRVvwdXiV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NPXf38CMjjCbrgjybdE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zrZgeNCQFBNsfLZwm4s()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder EbIkXMCeEsBjvFqqLZN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
