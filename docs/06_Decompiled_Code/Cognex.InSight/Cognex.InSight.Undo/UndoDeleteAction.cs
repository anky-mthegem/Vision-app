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
using Cognex.InSight.Sensor;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoDeleteAction : UndoRangeAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUndo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoDeleteAction _003C_003E4__this;

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
			UndoDeleteAction undoDeleteAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (fKM8Vgs2AR5VgG11iMlV())
					{
					}
					break;
				case 5:
					try
					{
						if (num2 != 0)
						{
							List<IExternalCellData>.Enumerator enumerator = undoDeleteAction.Tsil0lUWhx.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									cqV7cUs2DgZ4ZYwtvNht(enumerator.Current);
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							_003Ci_003E5__2 = 0;
							goto IL_0127;
						}
						TaskAwaiter awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_010e;
						IL_0127:
						if (_003Ci_003E5__2 < undoDeleteAction.StoredRanges.Length)
						{
							awaiter = DY2tsNs2TA2xIi8dWG5j(TtQtkxs2Udc1HPe0ySbi(undoDeleteAction.m_InSight, undoDeleteAction.StoredRanges[_003Ci_003E5__2].Range, undoDeleteAction.StoredRanges[_003Ci_003E5__2].BackupData, false, false));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_010e;
						}
						((CvsCogSocket)svtPwas2dBTB2HAAkVrP(undoDeleteAction.m_InSight)).Sheet.Run();
						goto end_IL_0037;
						IL_010e:
						awaiter.GetResult();
						_003Ci_003E5__2++;
						goto IL_0127;
						end_IL_0037:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 1:
				case 4:
					undoDeleteAction = _003C_003E4__this;
					num = 5;
					break;
				case 0:
					num2 = _003C_003E1__state;
					sVciLxs2VWbPgMoatae6();
					if (fKM8Vgs2AR5VgG11iMlV())
					{
						num = 2;
						if (!fKM8Vgs2AR5VgG11iMlV())
						{
							break;
						}
						goto case 1;
					}
					num = 4;
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
		internal static void cqV7cUs2DgZ4ZYwtvNht(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IExternalCellData)P_0).Restore();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TtQtkxs2Udc1HPe0ySbi(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DY2tsNs2TA2xIi8dWG5j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object svtPwas2dBTB2HAAkVrP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sVciLxs2VWbPgMoatae6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fKM8Vgs2AR5VgG11iMlV()
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
	private struct _003CRedo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoDeleteAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			UndoDeleteAction undoDeleteAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							awaiter = EPwoeRs2cBOPsy5WehPU(m3pdK6s2jQ7yXhB8Rnmp(sKEfS0s2Bb3qAhdiFIB6(undoDeleteAction.m_InSight), undoDeleteAction.S38lnajVfg, undoDeleteAction.P4xl9DW9yK));
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
						List<IExternalCellData>.Enumerator enumerator = undoDeleteAction.Tsil0lUWhx.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								LMComVs22wEx2WRWhI7G(enumerator.Current);
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
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 1:
				case 4:
					undoDeleteAction = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					if (b9p0oas2qWxoY5R6RuV3())
					{
						num = 0;
						if (okZfuks2i7b3qIBZbyi7())
						{
							break;
						}
						goto case 1;
					}
					num = 4;
					if (false)
					{
						return;
					}
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
		internal static object sKEfS0s2Bb3qAhdiFIB6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object m3pdK6s2jQ7yXhB8Rnmp(object P_0, CvsCellRange selected, ShiftCells shift)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoHandler)P_0).SendRemoveCellsAsync(selected, shift);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter EPwoeRs2cBOPsy5WehPU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LMComVs22wEx2WRWhI7G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IExternalCellData)P_0).Delete();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool okZfuks2i7b3qIBZbyi7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b9p0oas2qWxoY5R6RuV3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellRange S38lnajVfg;

	private readonly ShiftCells P4xl9DW9yK;

	private readonly CvsCellRange PL9lUr6tJO;

	private List<IExternalCellData> Tsil0lUWhx;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			ShiftCells p4xl9DW9yK = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					p4xl9DW9yK = P4xl9DW9yK;
					num = 11;
					continue;
				case 11:
					if (p4xl9DW9yK != ShiftCells.EntireRow)
					{
						num = 4;
						continue;
					}
					if (S38lnajVfg.Rows != 1)
					{
						result = (string)HsVVeR7b4UxZ9NFqPaL(vGmqPn7pDhCE2kNcU6I(), S38lnajVfg.Row, S38lnajVfg.LastRow);
						num = 6;
						continue;
					}
					goto case 8;
				case 1:
					result = (string)sgBBJj7GKvTBf1NWsJV(hWxgB270ulWHpkN65Yc(), S38lnajVfg.Location.ToString());
					num = 9;
					continue;
				case 8:
					result = string.Format((string)PPjVSl76AZQHJo9G4XI(), S38lnajVfg.Row);
					break;
				case 2:
					if (S38lnajVfg.Rows == 1)
					{
						num = 1;
						continue;
					}
					goto IL_002e;
				case 0:
					result = (string)sgBBJj7GKvTBf1NWsJV(F3chPD7n8R9VqdmF7jp(), (char)(65 + S38lnajVfg.Column));
					break;
				default:
					num = 8;
					if (qrMJ5Y7xsDd785cnOw3())
					{
						continue;
					}
					goto case 4;
				case 4:
					if (p4xl9DW9yK == ShiftCells.EntireColumn)
					{
						ae5cnb71LsuoyDZNdJt();
						if (!qrMJ5Y7xsDd785cnOw3())
						{
							num = 10;
							if (qrMJ5Y7xsDd785cnOw3())
							{
								continue;
							}
							break;
						}
						num = 12;
						continue;
					}
					if (S38lnajVfg.Columns == 1)
					{
						num = 2;
						if (true)
						{
							continue;
						}
						break;
					}
					goto IL_002e;
				case 3:
				case 12:
					if (S38lnajVfg.Columns != 1)
					{
						result = (string)HsVVeR7b4UxZ9NFqPaL(zUDmjT7XhjSVdLyFyW0(), (char)(65 + S38lnajVfg.Column), (char)(65 + S38lnajVfg.LastColumn));
						break;
					}
					num = 0;
					continue;
				case 5:
				case 6:
				case 9:
				case 10:
				case 13:
					break;
					IL_002e:
					result = string.Format((string)qlAjfI74SapAkDGuqjx(), S38lnajVfg.ToString());
					num = 13;
					if (true)
					{
						continue;
					}
					goto case 11;
				}
				break;
			}
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoDeleteAction(CvsInSight inSight, CvsCellRange cellRange, ShiftCells shift)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		IEnumerator<CvsCellLocation> enumerator = default;
		IExternalCellDataHandler externalCellDataHandler = default;
		CvsCell cvsCell = default;
		IExternalCellData externalCellData = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				Tsil0lUWhx = new List<IExternalCellData>();
				num = 0;
				break;
			case 0:
				base._002Ector(inSight, FoH7Ml73SKBw9d2Tg8B(inSight, cellRange, shift));
				_ = 0;
				num = ((!qrMJ5Y7xsDd785cnOw3()) ? 2 : 4);
				break;
			case 2:
			case 6:
				enumerator = PL9lUr6tJO.GetEnumerator();
				num = 9;
				break;
			case 7:
				M3eLIS7rYpfNPRAygKP();
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
			case 4:
				S38lnajVfg = cellRange;
				goto case 8;
			default:
				num = 8;
				break;
			case 1:
				PL9lUr6tJO = jLbl7lY0gn(inSight, cellRange, shift);
				goto case 2;
			case 8:
				P4xl9DW9yK = shift;
				num = 1;
				break;
			case 9:
				try
				{
					while (E9ADkb7e0IF2sTZwkk8(enumerator))
					{
						CvsCellLocation current = enumerator.Current;
						qrMJ5Y7xsDd785cnOw3();
						int num2;
						if (!ae5cnb71LsuoyDZNdJt())
						{
							num2 = 6;
						}
						else
						{
							num2 = 3;
							if (1 == 0)
							{
								goto IL_0147;
							}
						}
						goto IL_0170;
						IL_0147:
						externalCellDataHandler = (IExternalCellDataHandler)z3dQaN7QB3fxtaX45cS(cvsCell);
						num2 = 7;
						goto IL_0170;
						IL_0170:
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 6:
								cvsCell = (CvsCell)yOArQW7M7yq6UYF8aMT(((CvsResultSet)aLMItL7OKMF0JIcVljI(InSight)).Cells, current);
								break;
							case 1:
							case 3:
								break;
							case 7:
								if (externalCellDataHandler == null)
								{
									goto IL_01f4;
								}
								goto case 5;
							default:
								num2 = 5;
								if (ae5cnb71LsuoyDZNdJt())
								{
								}
								continue;
							case 4:
								Tsil0lUWhx.Add(externalCellData);
								num2 = 8;
								continue;
							case 5:
								externalCellData = externalCellDataHandler.SaveState(InSight, H0wWAy7lywyPf4INLFN(cvsCell));
								num2 = 2;
								continue;
							case 2:
								if (externalCellData != null)
								{
									num2 = 4;
									continue;
								}
								goto IL_01f4;
							case 8:
								goto IL_01f4;
							}
							break;
						}
						goto IL_0147;
						IL_01f4:;
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						hxAHNy7um4rWJI4mjbM(enumerator);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsCellRange jLbl7lY0gn(CvsInSight P_0, CvsCellRange P_1, ShiftCells P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!qrMJ5Y7xsDd785cnOw3()) ? 7 : 6);
		CvsCellRange result = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				do
				{
					switch (P_2)
					{
					case ShiftCells.EntireRow:
						break;
					default:
						goto IL_0057;
					case ShiftCells.EntireColumn:
						goto IL_0072;
					case ShiftCells.Horizontally:
					case ShiftCells.Vertically:
						goto end_IL_00ca;
					}
					result.Column = 0;
					num = 5;
					continue;
					IL_0072:
					result.Row = 0;
					num = 2;
					break;
					IL_0057:
					num = 1;
					break;
				}
				while (!qrMJ5Y7xsDd785cnOw3());
				continue;
			case 0:
			case 6:
				result = P_1;
				num = 3;
				continue;
			case 2:
				result.Rows = P_0.ProcessorConstants.SpreadsheetRows;
				num = 8;
				if (qrMJ5Y7xsDd785cnOw3())
				{
					continue;
				}
				goto case 5;
			case 5:
				{
					result.Columns = aKLHV57Iv8UHA3ITmb4(P_0.ProcessorConstants);
					break;
				}
				end_IL_00ca:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsCellRange XhPlmaVAiw(CvsInSight P_0, CvsCellRange P_1, ShiftCells P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (ae5cnb71LsuoyDZNdJt() ? 5 : 6);
		CvsCellLocation location = default;
		CvsCellRange result = default;
		CvsProcessorConstants cvsProcessorConstants = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				location = P_1.Location;
				goto case 2;
			case 7:
				do
				{
					switch (P_2)
					{
					case ShiftCells.Vertically:
					case ShiftCells.EntireRow:
						break;
					case ShiftCells.Horizontally:
					case ShiftCells.EntireColumn:
						goto IL_00ec;
					default:
						goto end_IL_008a;
					}
					result.Rows = cvsProcessorConstants.SpreadsheetRows - location.Row;
					num = 4;
					continue;
					IL_00ec:
					result.Columns = aKLHV57Iv8UHA3ITmb4(cvsProcessorConstants) - location.Column;
					num = 8;
					break;
				}
				while (1 == 0);
				continue;
			default:
				num = 1;
				continue;
			case 0:
			case 6:
				result = G9GXrp7RLJfVqycVPsh(P_0, P_1, P_2);
				num = 3;
				if (qrMJ5Y7xsDd785cnOw3())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 5:
				cvsProcessorConstants = (CvsProcessorConstants)lL9BoW7a2N3H3qi1A74(P_0);
				num = 7;
				continue;
			case 1:
			case 4:
			case 8:
				break;
				end_IL_008a:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!ae5cnb71LsuoyDZNdJt())
		{
			num = 2;
			if (ae5cnb71LsuoyDZNdJt())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0044;
		IL_006f:
		_003CUndo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_006f;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = BtWl6S7kKugsJsRZ37g();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_006f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__10))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (qrMJ5Y7xsDd785cnOw3())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_00b1;
			}
		}
		_003CRedo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = BtWl6S7kKugsJsRZ37g();
				num = 5;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				break;
			}
			break;
		}
		goto IL_00b1;
		IL_00b1:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M3eLIS7rYpfNPRAygKP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange FoH7Ml73SKBw9d2Tg8B(object P_0, CvsCellRange P_1, ShiftCells P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return XhPlmaVAiw((CvsInSight)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aLMItL7OKMF0JIcVljI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yOArQW7M7yq6UYF8aMT(object P_0, CvsCellLocation cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[cell];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z3dQaN7QB3fxtaX45cS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UndoHandler.GetExternalCellDataHandler((CvsCell)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation H0wWAy7lywyPf4INLFN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E9ADkb7e0IF2sTZwkk8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hxAHNy7um4rWJI4mjbM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qrMJ5Y7xsDd785cnOw3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ae5cnb71LsuoyDZNdJt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aKLHV57Iv8UHA3ITmb4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsProcessorConstants)P_0).SpreadsheetColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange G9GXrp7RLJfVqycVPsh(object P_0, CvsCellRange P_1, ShiftCells P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jLbl7lY0gn((CvsInSight)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lL9BoW7a2N3H3qi1A74(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F3chPD7n8R9VqdmF7jp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionDeleteColumn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sgBBJj7GKvTBf1NWsJV(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zUDmjT7XhjSVdLyFyW0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionDeleteColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HsVVeR7b4UxZ9NFqPaL(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PPjVSl76AZQHJo9G4XI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionDeleteRow;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vGmqPn7pDhCE2kNcU6I()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionDeleteRows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hWxgB270ulWHpkN65Yc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionDeleteCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qlAjfI74SapAkDGuqjx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionDeleteCells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder BtWl6S7kKugsJsRZ37g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
