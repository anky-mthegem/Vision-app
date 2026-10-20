using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Properties;
using Cognex.InSight.Sensor;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoInsertAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
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
			revM83sCxmb9C4tjAT3I();
			int num;
			if (!DjMZCpsC1jlHgoZIwr5r())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (false)
				{
					return;
				}
			}
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					if (revM83sCxmb9C4tjAT3I())
					{
						continue;
					}
					goto case 3;
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((Task)yJwMD4sCrlhnokQRrMR8()).GetAwaiter();
							DjMZCpsC1jlHgoZIwr5r();
							if (revM83sCxmb9C4tjAT3I())
							{
								num3 = 7;
								if (1 == 0)
								{
									goto IL_0081;
								}
							}
							else
							{
								num3 = 1;
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
							case 2:
								break;
							default:
								num3 = 8;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								goto case 1;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto case 9;
							case 8:
								return;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (DjMZCpsC1jlHgoZIwr5r())
								{
								}
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_00a1;
							}
							goto IL_0081;
							continue;
							end_IL_00a1:
							break;
						}
						goto end_IL_0054;
						IL_0081:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0054:;
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
		internal static object yJwMD4sCrlhnokQRrMR8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool revM83sCxmb9C4tjAT3I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DjMZCpsC1jlHgoZIwr5r()
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

		public UndoInsertAction _003C_003E4__this;

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
			if (!ScB8ZasCO7xHCW2XgjKv())
			{
				num = 3;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_0052;
				}
			}
			goto IL_01ac;
			IL_0024:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01ac;
			IL_0052:
			int num2 = default;
			UndoInsertAction undoInsertAction = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = undoInsertAction.Redo().GetAwaiter();
					num3 = 1;
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
						goto case 5;
					case 5:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 8:
						_003C_003Eu__1 = awaiter;
						fbHmmdsC3uMfHZQ8qanC();
						if (ScB8ZasCO7xHCW2XgjKv())
						{
							num3 = 5;
							if (true)
							{
								continue;
							}
							goto case 5;
						}
						num3 = 7;
						continue;
					case 1:
						if (!awaiter.IsCompleted)
						{
							num3 = 0;
							if (ScB8ZasCO7xHCW2XgjKv())
							{
							}
							continue;
						}
						break;
					case 3:
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 2;
						if (fbHmmdsC3uMfHZQ8qanC())
						{
							continue;
						}
						goto case 0;
					case 0:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						if (!ScB8ZasCO7xHCW2XgjKv())
						{
							continue;
						}
						return;
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
			goto IL_0024;
			IL_01ac:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 4:
					undoInsertAction = _003C_003E4__this;
					goto IL_0052;
				case 2:
				case 5:
					goto IL_0052;
				default:
					num = 1;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0024;
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
		internal static bool fbHmmdsC3uMfHZQ8qanC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ScB8ZasCO7xHCW2XgjKv()
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
	private struct _003CRedo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoInsertAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fjjsn2sCMphOOoUAQT5d();
			int num = (YFmwT4sCQ2fNaRXj0wUs() ? 5 : 2);
			int num2 = default;
			UndoInsertAction undoInsertAction = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = dSqMmisCuxwusZwP796A(r1xCDdsCeulT6xtfC0bo(xAFFxMsClZRmCxM8JqTg(undoInsertAction.MhngAHEUCb), undoInsertAction.WaPgtCtGoK, undoInsertAction.tt0gWXYs0a));
							num3 = 3;
							goto IL_0090;
						}
						awaiter = _003C_003Eu__1;
						goto IL_005a;
						IL_005a:
						_003C_003Eu__1 = default;
						num3 = 8;
						goto IL_0090;
						IL_0090:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 5:
								break;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									YFmwT4sCQ2fNaRXj0wUs();
									if (fjjsn2sCMphOOoUAQT5d())
									{
										num3 = 7;
										if (fjjsn2sCMphOOoUAQT5d())
										{
											continue;
										}
										goto case 8;
									}
									num3 = 2;
									continue;
								}
								goto case 9;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								return;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0090;
							}
							goto IL_005a;
							continue;
							end_IL_0090:
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
					goto case 3;
				default:
					num = 3;
					if (YFmwT4sCQ2fNaRXj0wUs())
					{
					}
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				undoInsertAction = _003C_003E4__this;
				num = 4;
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
		internal static object xAFFxMsClZRmCxM8JqTg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object r1xCDdsCeulT6xtfC0bo(object P_0, CvsCellRange selected, ShiftCells shift)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoHandler)P_0).SendInsertCellsAsync(selected, shift);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter dSqMmisCuxwusZwP796A(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fjjsn2sCMphOOoUAQT5d()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YFmwT4sCQ2fNaRXj0wUs()
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

		public UndoInsertAction _003C_003E4__this;

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
			UndoInsertAction undoInsertAction = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = p1kwIQsCG8CoKZI5kEwM(xXma0PsCnUiol38Xj5PM(dfqdiqsCawy4Qh0ZNoLL(undoInsertAction.MhngAHEUCb), undoInsertAction.WaPgtCtGoK, undoInsertAction.tt0gWXYs0a));
							num3 = 3;
							if (1 == 0)
							{
								goto IL_0063;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						goto IL_0105;
						IL_0105:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (fAeJgnsCIBhapK8FCbl5())
									{
										continue;
									}
									return;
								}
								goto case 9;
							case 7:
								return;
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 5:
								goto IL_00c2;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (fAeJgnsCIBhapK8FCbl5())
								{
									continue;
								}
								goto IL_0142;
							case 4:
							case 6:
								goto IL_0142;
							case 9:
								awaiter.GetResult();
								goto end_IL_002f;
							}
							break;
							IL_00c2:
							num2 = (_003C_003E1__state = 0);
							cdIkHTsCRyuWyc7FvsUi();
							num3 = (fAeJgnsCIBhapK8FCbl5() ? 8 : 4);
						}
						goto IL_0063;
						IL_0142:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_0105;
						IL_0063:
						_003C_003Eu__1 = default;
						goto IL_0142;
						end_IL_002f:;
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
				case 2:
					undoInsertAction = _003C_003E4__this;
					num = 5;
					if (cdIkHTsCRyuWyc7FvsUi())
					{
					}
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!cdIkHTsCRyuWyc7FvsUi()) ? 2 : 4);
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
		internal static object dfqdiqsCawy4Qh0ZNoLL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xXma0PsCnUiol38Xj5PM(object P_0, CvsCellRange selected, ShiftCells shift)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoHandler)P_0).SendRemoveCellsAsync(selected, shift);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter p1kwIQsCG8CoKZI5kEwM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fAeJgnsCIBhapK8FCbl5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cdIkHTsCRyuWyc7FvsUi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight MhngAHEUCb;

	private CvsCellRange WaPgtCtGoK;

	private readonly ShiftCells tt0gWXYs0a;

	private readonly CvsCellRange l2Dg3rZukL;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ivcQTFtaYPSrkSvOGJ2();
			int num = (p7IDMetRAxCiDDbWEN1() ? 1 : 11);
			ShiftCells shiftCells = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 9:
					if (shiftCells == ShiftCells.EntireColumn)
					{
						num = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					}
					if (WaPgtCtGoK.Columns != 1 || WaPgtCtGoK.Rows != 1)
					{
						result = (string)SxQj5Vt0PeoMVUOHKeG(Resources.UndoActionInsertCells, WaPgtCtGoK.ToString());
						num = 13;
					}
					else
					{
						result = (string)SxQj5Vt0PeoMVUOHKeG(Resources.UndoActionInsertCell, WaPgtCtGoK.Location.ToString());
						num = 7;
					}
					continue;
				case 0:
				case 1:
					shiftCells = tt0gWXYs0a;
					num = 10;
					continue;
				case 8:
					if (WaPgtCtGoK.Columns == 1)
					{
						goto case 4;
					}
					result = string.Format((string)EAtpKIt6rRtS0xNhwr8(), (char)(65 + WaPgtCtGoK.Column), 65 + WaPgtCtGoK.LastColumn);
					break;
				default:
					num = 6;
					continue;
				case 5:
					result = (string)SxQj5Vt0PeoMVUOHKeG(UpdJERtpVWGbpgVODfk(), WaPgtCtGoK.Row);
					num = 12;
					continue;
				case 10:
					if (shiftCells == ShiftCells.EntireRow)
					{
						if (WaPgtCtGoK.Rows == 1)
						{
							num = 5;
							continue;
						}
						result = (string)ockoYMt4Bldfqdt4bYM(Resources.UndoActionInsertRows, WaPgtCtGoK.Row, WaPgtCtGoK.LastRow);
						num = 2;
					}
					else
					{
						num = 9;
					}
					continue;
				case 4:
				case 11:
					result = string.Format((string)df8qBTtbLhEDZ3ocBnA(), (char)(65 + WaPgtCtGoK.Column));
					num = 3;
					continue;
				case 2:
				case 3:
				case 6:
				case 7:
				case 12:
				case 13:
					break;
				}
				break;
			}
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoInsertAction(CvsInSight inSight, CvsCellRange cellRange, ShiftCells shift)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			return;
		}
		ShiftCells shiftCells = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				return;
			case 12:
				return;
			case 6:
				tt0gWXYs0a = shift;
				num = 5;
				break;
			case 11:
				l2Dg3rZukL.Columns = ((CvsProcessorConstants)QQjURytGmcQiGiBTq9X(MhngAHEUCb)).SpreadsheetColumns;
				num = 0;
				if (p7IDMetRAxCiDDbWEN1())
				{
					break;
				}
				goto case 5;
			case 5:
				l2Dg3rZukL = WaPgtCtGoK;
				goto case 9;
			default:
				num = 9;
				break;
			case 9:
				shiftCells = tt0gWXYs0a;
				ivcQTFtaYPSrkSvOGJ2();
				if (p7IDMetRAxCiDDbWEN1())
				{
					num = 1;
					break;
				}
				num = 12;
				if (true)
				{
					break;
				}
				return;
			case 2:
				WaPgtCtGoK = cellRange;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 7:
				switch (shiftCells)
				{
				default:
					return;
				case ShiftCells.EntireRow:
					l2Dg3rZukL.Column = 0;
					num = 11;
					break;
				case ShiftCells.EntireColumn:
					l2Dg3rZukL.Row = 0;
					l2Dg3rZukL.Rows = Y2h65xtXLm4yrppMoAa(QQjURytGmcQiGiBTq9X(MhngAHEUCb));
					num = 13;
					break;
				case ShiftCells.Horizontally:
				case ShiftCells.Vertically:
					return;
				}
				break;
			case 0:
				return;
			case 3:
				TpMqintnbrHok2Q42hJ();
				num = 10;
				break;
			case 10:
				base._002Ector();
				num = 4;
				break;
			case 4:
				MhngAHEUCb = inSight;
				num = 2;
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ivcQTFtaYPSrkSvOGJ2();
		int num = ((!p7IDMetRAxCiDDbWEN1()) ? 3 : 4);
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = mMOPwNtkfrv25YDbEFk();
				goto case 1;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				p7IDMetRAxCiDDbWEN1();
				num = ((!ivcQTFtaYPSrkSvOGJ2()) ? 3 : 5);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRedo_003Ed__9 stateMachine = default;
		while (true)
		{
			IL_0074:
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				while (true)
				{
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					p7IDMetRAxCiDDbWEN1();
					if (!ivcQTFtaYPSrkSvOGJ2())
					{
						break;
					}
					num = 5;
					if (false)
					{
						continue;
					}
					goto IL_0074;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (p7IDMetRAxCiDDbWEN1())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ivcQTFtaYPSrkSvOGJ2();
		int num;
		if (p7IDMetRAxCiDDbWEN1())
		{
			num = 2;
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_009f;
			}
		}
		goto IL_006c;
		IL_006c:
		_003CUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = mMOPwNtkfrv25YDbEFk();
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_009f;
		IL_009f:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TpMqintnbrHok2Q42hJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QQjURytGmcQiGiBTq9X(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Y2h65xtXLm4yrppMoAa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsProcessorConstants)P_0).SpreadsheetRows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p7IDMetRAxCiDDbWEN1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ivcQTFtaYPSrkSvOGJ2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object df8qBTtbLhEDZ3ocBnA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionInsertColumn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EAtpKIt6rRtS0xNhwr8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionInsertColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UpdJERtpVWGbpgVODfk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionInsertRow;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SxQj5Vt0PeoMVUOHKeG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ockoYMt4Bldfqdt4bYM(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder mMOPwNtkfrv25YDbEFk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
