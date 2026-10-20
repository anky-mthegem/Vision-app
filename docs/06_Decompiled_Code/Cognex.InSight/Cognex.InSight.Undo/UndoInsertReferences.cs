using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoInsertReferences : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoInsertReferences _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!n1gKOBsCX9acNTCXx6BO()) ? 2 : 3);
			int num2 = default;
			UndoInsertReferences undoInsertReferences = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)iIR6w7sCpsbwrti6Tdka(jUmZkEsC6u2vHJOb7l3y(undoInsertReferences.Ov2gL3aNgP))).CopyCellsAsync(undoInsertReferences.VFLgXFal9G).GetAwaiter();
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (n1gKOBsCX9acNTCXx6BO())
									{
										num3 = 9;
										continue;
									}
									num3 = 7;
									if (S48ZugsCbZteSWTuxPls())
									{
									}
									continue;
								}
								goto case 0;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 6:
								return;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 1:
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 10:
								undoInsertReferences.USNgf7fCpO = result;
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
				default:
					num = 4;
					continue;
				case 1:
				case 2:
					undoInsertReferences = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
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
		internal static object jUmZkEsC6u2vHJOb7l3y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iIR6w7sCpsbwrti6Tdka(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n1gKOBsCX9acNTCXx6BO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S48ZugsCbZteSWTuxPls()
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
	private struct _003CDo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoInsertReferences _003C_003E4__this;

		private int _003Cdr_003E5__2;

		private int _003Cdc_003E5__3;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (znY1hCsC4MovMMkMFsaT() ? 2 : 5);
			UndoInsertReferences undoInsertReferences = default;
			int num2 = default;
			TaskAwaiter<byte[]> awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			int num4 = default;
			CvsCellRange cvsCellRange = default;
			CvsCellLocation cvsCellLocation = default;
			CvsCellLocation location = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					undoInsertReferences = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 1;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 21;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 0;
							if (!KShdMtsC0ZGQyB6cdUBM())
							{
								goto IL_0387;
							}
						}
						goto IL_007d;
						IL_007d:
						while (true)
						{
							switch (num3)
							{
							case 18:
								_003Cdc_003E5__3 = num4 + 1;
								goto case 20;
							default:
								num3 = 22;
								if (KShdMtsC0ZGQyB6cdUBM())
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 21:
								num2 = (_003C_003E1__state = -1);
								num3 = 19;
								if (KShdMtsC0ZGQyB6cdUBM())
								{
									continue;
								}
								break;
							case 2:
								break;
							case 1:
								_003Cdr_003E5__2 = 0;
								num3 = 5;
								if (KShdMtsC0ZGQyB6cdUBM())
								{
									continue;
								}
								goto case 17;
							case 17:
								cvsCellRange = anYCAbsCklTXd1Ieyh9C(undoInsertReferences.vN1gktZQ5g);
								_ = 0;
								if (KShdMtsC0ZGQyB6cdUBM())
								{
									num3 = 6;
									continue;
								}
								num3 = 16;
								if (KShdMtsC0ZGQyB6cdUBM())
								{
									continue;
								}
								goto case 24;
							case 4:
							case 6:
							{
								int row = cvsCellRange.Row + _003Cdr_003E5__2;
								cvsCellRange = undoInsertReferences.vN1gktZQ5g.Range;
								cvsCellLocation = new CvsCellLocation(row, cvsCellRange.Column + _003Cdc_003E5__3);
								num3 = 3;
								continue;
							}
							case 11:
								awaiter = ((CvsCogSocketSheet)Ip7VUisCy1u3Iy13exkF(undoInsertReferences.Ov2gL3aNgP.CogSocket)).CopyCellsAsync(undoInsertReferences.VFLgXFal9G).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 24;
									continue;
								}
								goto case 19;
							case 15:
								((CvsCogSocketSheet)Ip7VUisCy1u3Iy13exkF(iKVsO5sCmYlX9qH9xmC6(undoInsertReferences.Ov2gL3aNgP))).Run(true);
								num3 = 11;
								continue;
							case 5:
							case 23:
								goto IL_0260;
							case 3:
							{
								string expression = cvsCellLocation.ToString(OnQt4csCf4QmGylR7d18(undoInsertReferences.vN1gktZQ5g), wmrIIZsCFjJXw68uuh1J(undoInsertReferences.vN1gktZQ5g));
								awaiter2 = undoInsertReferences.Ov2gL3aNgP.CogSocket.Sheet.PutCellExpressionAsync(location, expression).GetAwaiter();
								num3 = 12;
								continue;
							}
							case 19:
								result = awaiter.GetResult();
								num3 = 25;
								continue;
							case 13:
								_003C_003Eu__2 = awaiter;
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								num4 = _003Cdr_003E5__2;
								goto case 14;
							case 24:
								num2 = (_003C_003E1__state = 1);
								num3 = 13;
								continue;
							case 8:
								return;
							case 12:
								goto IL_0387;
							case 14:
							case 16:
								_003Cdr_003E5__2 = num4 + 1;
								num3 = 23;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 8;
								if (KShdMtsC0ZGQyB6cdUBM())
								{
									continue;
								}
								goto case 20;
							case 20:
							case 22:
							{
								int num5 = _003Cdc_003E5__3;
								cvsCellRange = undoInsertReferences.VFLgXFal9G;
								if (num5 < cvsCellRange.Columns)
								{
									int row2 = undoInsertReferences.VFLgXFal9G.Row + _003Cdr_003E5__2;
									cvsCellRange = undoInsertReferences.VFLgXFal9G;
									location = new CvsCellLocation(row2, cvsCellRange.Column + _003Cdc_003E5__3);
									num3 = 17;
									if (!znY1hCsC4MovMMkMFsaT())
									{
										continue;
									}
									goto case 19;
								}
								num3 = 9;
								continue;
							}
							case 25:
								undoInsertReferences.upmgjyZ5e8 = result;
								goto end_IL_004a;
							}
							break;
							IL_0260:
							int num6 = _003Cdr_003E5__2;
							cvsCellRange = undoInsertReferences.VFLgXFal9G;
							if (num6 < cvsCellRange.Rows)
							{
								_003Cdc_003E5__3 = 0;
								num3 = 20;
							}
							else
							{
								num3 = 15;
							}
						}
						goto IL_0163;
						IL_0387:
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							num3 = 10;
							goto IL_007d;
						}
						goto IL_0163;
						IL_0163:
						awaiter2.GetResult();
						num4 = _003Cdc_003E5__3;
						num3 = 18;
						goto IL_007d;
						end_IL_004a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static CvsCellRange anYCAbsCklTXd1Ieyh9C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OnQt4csCf4QmGylR7d18(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).AbsoluteColumn;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wmrIIZsCFjJXw68uuh1J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).AbsoluteRow;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iKVsO5sCmYlX9qH9xmC6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ip7VUisCy1u3Iy13exkF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KShdMtsC0ZGQyB6cdUBM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool znY1hCsC4MovMMkMFsaT()
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

		public UndoInsertReferences _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_01a7;
			IL_0046:
			int num2 = default;
			UndoInsertReferences undoInsertReferences = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = hi641PsC8ikTgsD0gbtf(cOBoVFsCJ5WcEW6BRAyu(undoInsertReferences.Ov2gL3aNgP, undoInsertReferences.VFLgXFal9G, undoInsertReferences.upmgjyZ5e8, false, true));
					num3 = 8;
					if (!zsevVFsCgAhapY83XInD())
					{
						return;
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
					case 3:
						return;
					case 8:
						if (!awaiter.IsCompleted)
						{
							_ = 1;
							num3 = (a0BnJSsCZlJZgCPqZyGD() ? 7 : 6);
							continue;
						}
						break;
					case 2:
					case 7:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						continue;
					case 1:
					case 6:
						num2 = (_003C_003E1__state = 0);
						goto case 2;
					case 0:
						_003C_003Eu__1 = default;
						num3 = 4;
						if (a0BnJSsCZlJZgCPqZyGD())
						{
						}
						continue;
					case 4:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 3;
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
			goto IL_0031;
			IL_01a7:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 3:
					goto IL_0031;
				case 2:
				case 4:
					goto IL_0046;
				default:
					num = 3;
					if (!a0BnJSsCZlJZgCPqZyGD())
					{
						continue;
					}
					goto case 0;
				case 0:
					num2 = _003C_003E1__state;
					zsevVFsCgAhapY83XInD();
					if (a0BnJSsCZlJZgCPqZyGD())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (!zsevVFsCgAhapY83XInD())
					{
						return;
					}
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0031:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a7;
			IL_001a:
			undoInsertReferences = _003C_003E4__this;
			goto IL_0046;
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
		internal static object cOBoVFsCJ5WcEW6BRAyu(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter hi641PsC8ikTgsD0gbtf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zsevVFsCgAhapY83XInD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a0BnJSsCZlJZgCPqZyGD()
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
	private struct _003CUndo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoInsertReferences _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TkZEnPsCzv0gcKHPH1Tk();
			int num = (IAdB4SsKwAiS8ML7DGrb() ? 1 : 5);
			int num2 = default;
			UndoInsertReferences undoInsertReferences = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					undoInsertReferences = _003C_003E4__this;
					goto case 1;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = WVCrCIsKhjQYq2qDF7UF(QKpiCPsKsyiA4nelkK3l(undoInsertReferences.Ov2gL3aNgP, undoInsertReferences.VFLgXFal9G, undoInsertReferences.USNgf7fCpO, false, true));
							IAdB4SsKwAiS8ML7DGrb();
							num3 = ((!TkZEnPsCzv0gcKHPH1Tk()) ? 1 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								return;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
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
					goto case 4;
				default:
					num = 4;
					if (!TkZEnPsCzv0gcKHPH1Tk())
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
		internal static object QKpiCPsKsyiA4nelkK3l(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter WVCrCIsKhjQYq2qDF7UF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TkZEnPsCzv0gcKHPH1Tk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IAdB4SsKwAiS8ML7DGrb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight Ov2gL3aNgP;

	private readonly CvsReferenceRange vN1gktZQ5g;

	private readonly CvsCellRange VFLgXFal9G;

	private byte[] USNgf7fCpO;

	private byte[] upmgjyZ5e8;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)Dp1I9Tty6ALb7ChcycG();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoInsertReferences(CvsInSight insight, CvsReferenceRange refRange, CvsCellRange dest)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TUaR7Xtf78QHmZ6oSv0();
		int num;
		if (!u7Lhj2tFVwATZQIQpNg())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_00aa;
			}
		}
		goto IL_0054;
		IL_0054:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 6:
				Ov2gL3aNgP = insight;
				break;
			default:
				num = 5;
				continue;
			case 1:
			case 2:
				base._002Ector();
				num = 6;
				continue;
			case 0:
			case 4:
				qDcKNjtmBM7onMCpeYj();
				goto case 1;
			case 3:
				goto IL_00aa;
			case 7:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_00aa:
		VFLgXFal9G = dest;
		num = 7;
		if (!TUaR7Xtf78QHmZ6oSv0())
		{
			return;
		}
		goto IL_0054;
		IL_002a:
		vN1gktZQ5g = refRange;
		num = 3;
		goto IL_0054;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__8))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TUaR7Xtf78QHmZ6oSv0();
		int num = ((!u7Lhj2tFVwATZQIQpNg()) ? 1 : 4);
		_003CSaveState_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = OvkYhCtgNZjGmo3EJLR();
				num = 3;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__9))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				TUaR7Xtf78QHmZ6oSv0();
				num = (u7Lhj2tFVwATZQIQpNg() ? 4 : 0);
				continue;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				continue;
			default:
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__10))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRedo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (!u7Lhj2tFVwATZQIQpNg())
				{
					num = 1;
					if (TUaR7Xtf78QHmZ6oSv0())
					{
						continue;
					}
					goto default;
				}
				num = 5;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__11))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		u7Lhj2tFVwATZQIQpNg();
		int num;
		if (TUaR7Xtf78QHmZ6oSv0())
		{
			num = 4;
			if (u7Lhj2tFVwATZQIQpNg())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0060;
		IL_002e:
		_003CUndo_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0060;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = OvkYhCtgNZjGmo3EJLR();
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qDcKNjtmBM7onMCpeYj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TUaR7Xtf78QHmZ6oSv0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u7Lhj2tFVwATZQIQpNg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dp1I9Tty6ALb7ChcycG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoReferences;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder OvkYhCtgNZjGmo3EJLR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
