using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoRowOrColumnSizeAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__14 : IAsyncStateMachine
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
			_ = 1;
			int num;
			if (!CTBGylsYdTp96KSUKT1U())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (CTBGylsYdTp96KSUKT1U())
				{
					return;
				}
			}
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = sEFhKisYqB7yrlpDP3na(JxXoMxsYiTrUxMG2fn8M());
							_ = 1;
							num3 = (CTBGylsYdTp96KSUKT1U() ? 2 : 4);
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
							case 7:
								return;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (QnddgLsYTo8qH2XCpFUs())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								goto case 2;
							case 0:
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								break;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!CTBGylsYdTp96KSUKT1U())
								{
									continue;
								}
								break;
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
					break;
				default:
					num = 3;
					if (!CTBGylsYdTp96KSUKT1U())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object JxXoMxsYiTrUxMG2fn8M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter sEFhKisYqB7yrlpDP3na(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QnddgLsYTo8qH2XCpFUs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CTBGylsYdTp96KSUKT1U()
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
	private struct _003CDo_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRowOrColumnSizeAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yOYBEwsYjrcb7u6mxPqc();
			int num;
			if (qtRQaZsYBhWsWR7eACeM())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_01c1;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01c1;
			IL_01c1:
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 1:
				case 5:
					undoRowOrColumnSizeAction = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = nBOjBisYcvgdt0jcFIQE(undoRowOrColumnSizeAction.Redo());
							num3 = 7;
							if (yOYBEwsYjrcb7u6mxPqc())
							{
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (false)
							{
								goto IL_00b8;
							}
						}
						goto IL_014a;
						IL_00b8:
						_003C_003Eu__1 = default;
						num3 = 8;
						goto IL_014a;
						IL_014a:
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
								return;
							case 0:
								break;
							case 7:
								if (!awaiter.IsCompleted)
								{
									qtRQaZsYBhWsWR7eACeM();
									if (!yOYBEwsYjrcb7u6mxPqc())
									{
										num3 = 6;
										if (yOYBEwsYjrcb7u6mxPqc())
										{
										}
									}
									else
									{
										num3 = 5;
									}
									continue;
								}
								goto case 9;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_014a;
							}
							goto IL_00b8;
							continue;
							end_IL_014a:
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
					num = 2;
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
		internal static TaskAwaiter nBOjBisYcvgdt0jcFIQE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qtRQaZsYBhWsWR7eACeM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yOYBEwsYjrcb7u6mxPqc()
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
	private struct _003CRedo_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRowOrColumnSizeAction _003C_003E4__this;

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
			if (!Tl7ri1sYW05GptXSDwCx())
			{
				num = 3;
				if (Tl7ri1sYW05GptXSDwCx())
				{
				}
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_02ce;
				}
			}
			goto IL_028a;
			IL_028a:
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 7;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 3;
							}
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
								goto case 0;
							default:
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 14;
							case 14:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 12:
								return;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 15:
								return;
							case 7:
								if (undoRowOrColumnSizeAction.V5LqEiTibs)
								{
									awaiter = r3yvkXsYCOF04QPls6CS(GhFNJmsYt4mbKjCrLjEh(nLf6DJsY79AUYNPvAAJ3(undoRowOrColumnSizeAction.lXJqKmNptt), undoRowOrColumnSizeAction.IAtqHZRfY0, undoRowOrColumnSizeAction.BWnqNoONkn));
									num3 = 6;
									continue;
								}
								awaiter = r3yvkXsYCOF04QPls6CS(KFB8cWsYKTD57rs7US6M(undoRowOrColumnSizeAction.lXJqKmNptt.SheetInfo, undoRowOrColumnSizeAction.IAtqHZRfY0, undoRowOrColumnSizeAction.BWnqNoONkn));
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 14;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 1;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								continue;
							case 1:
								awaiter.GetResult();
								goto end_IL_0078;
							case 10:
							case 13:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 8:
								return;
							case 5:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = (MJk38XsY2jxswLAbhEZW() ? 13 : 8);
									continue;
								}
								break;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								continue;
							case 16:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0078:
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
					continue;
				case 5:
					undoRowOrColumnSizeAction = _003C_003E4__this;
					goto case 1;
				case 0:
				case 3:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_02ce;
			IL_02ce:
			num2 = _003C_003E1__state;
			num = 5;
			goto IL_028a;
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
		internal static object nLf6DJsY79AUYNPvAAJ3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GhFNJmsYt4mbKjCrLjEh(object P_0, CvsCellRange activeRange, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).SetRowHeights(activeRange, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter r3yvkXsYCOF04QPls6CS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KFB8cWsYKTD57rs7US6M(object P_0, CvsCellRange activeRange, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).SetColumnWidths(activeRange, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MJk38XsY2jxswLAbhEZW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tl7ri1sYW05GptXSDwCx()
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
	private struct _003CUndo_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRowOrColumnSizeAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E7Z4TOsY5IlDcHptEyrG();
			int num;
			if (!L46RbysYoHNK9noR2Zrf())
			{
				num = 3;
				if (!E7Z4TOsY5IlDcHptEyrG())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0281;
			IL_02b6:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0281;
			IL_0281:
			int num2 = default;
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					num = 4;
					if (L46RbysYoHNK9noR2Zrf())
					{
					}
					continue;
				case 4:
					goto IL_02b6;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					undoRowOrColumnSizeAction = _003C_003E4__this;
					num = 2;
					if (L46RbysYoHNK9noR2Zrf())
					{
					}
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 2;
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 8;
						if (false)
						{
							goto IL_005d;
						}
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 10;
				}
				goto IL_0105;
				IL_0105:
				while (true)
				{
					switch (num3)
					{
					case 9:
						return;
					case 12:
						break;
					case 5:
						if (!awaiter.IsCompleted)
						{
							num3 = 13;
							if (0 == 0)
							{
								continue;
							}
							goto case 8;
						}
						goto IL_022a;
					case 8:
						_003C_003Eu__1 = default;
						num3 = 0;
						continue;
					case 3:
					case 15:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 7;
						continue;
					case 14:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 9;
						continue;
					case 1:
						goto end_IL_0105;
					case 6:
						goto end_IL_0105;
					default:
						num3 = 4;
						if (L46RbysYoHNK9noR2Zrf())
						{
						}
						continue;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 13:
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_ = 1;
						if (!L46RbysYoHNK9noR2Zrf())
						{
							num3 = 15;
							if (true)
							{
								continue;
							}
							goto case 11;
						}
						num3 = 1;
						continue;
					case 11:
						num2 = (_003C_003E1__state = 1);
						num3 = 12;
						continue;
					case 7:
						return;
					case 2:
						if (!undoRowOrColumnSizeAction.V5LqEiTibs)
						{
							awaiter = tBeiCssYYS5c5GUC987o(UuXHIjsYxBgFoGWOwS5M(pGiaWFsYNDxlDEVl84IC(undoRowOrColumnSizeAction.lXJqKmNptt), undoRowOrColumnSizeAction.IAtqHZRfY0, undoRowOrColumnSizeAction.BUyqQJe6eZ));
						}
						else
						{
							awaiter = tBeiCssYYS5c5GUC987o(U0KDeusYPy9T9ktgBTJ9(undoRowOrColumnSizeAction.lXJqKmNptt.SheetInfo, undoRowOrColumnSizeAction.IAtqHZRfY0, undoRowOrColumnSizeAction.BUyqQJe6eZ));
							num3 = 5;
							if (0 == 0)
							{
								continue;
							}
						}
						goto case 4;
					case 4:
						if (!awaiter.IsCompleted)
						{
							num3 = 11;
							continue;
						}
						goto case 16;
					case 10:
						num2 = (_003C_003E1__state = -1);
						goto IL_022a;
					case 16:
						{
							awaiter.GetResult();
							goto end_IL_0105;
						}
						IL_022a:
						awaiter.GetResult();
						goto end_IL_0105;
					}
					goto IL_005d;
					continue;
					end_IL_0105:
					break;
				}
				goto end_IL_002e;
				IL_005d:
				_003C_003Eu__1 = awaiter;
				num3 = 14;
				goto IL_0105;
				end_IL_002e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_02b6;
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
		internal static object U0KDeusYPy9T9ktgBTJ9(object P_0, CvsCellRange activeRange, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).SetRowHeights(activeRange, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tBeiCssYYS5c5GUC987o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pGiaWFsYNDxlDEVl84IC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UuXHIjsYxBgFoGWOwS5M(object P_0, CvsCellRange activeRange, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).SetColumnWidths(activeRange, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E7Z4TOsY5IlDcHptEyrG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L46RbysYoHNK9noR2Zrf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsCellRange IAtqHZRfY0;

	private readonly CvsInSight lXJqKmNptt;

	private readonly bool V5LqEiTibs;

	private readonly int[] BUyqQJe6eZ;

	private readonly int[] BWnqNoONkn;

	private string iyAqinObDX;

	private readonly bool sI6qdQoiSD;

	private readonly int mxbquiFVTt;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iyAqinObDX;
		}
	}

	public bool CanDo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sI6qdQoiSD;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private UndoRowOrColumnSizeAction(CvsCellRange activeRange, CvsInSight inSight, bool resizingRows, int start, int end)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		do
		{
			IL_0056:
			switch (num)
			{
			case 1:
				if (!activeRange.ContainsRow(start))
				{
					throw new ArgumentOutOfRangeException((string)rtBVe7KESdfth4XgqHN(17482));
				}
				if (!activeRange.ContainsRow(end))
				{
					goto default;
				}
				mxbquiFVTt = start - activeRange.Row;
				num = 13;
				goto IL_0056;
			default:
				VGUpW0K9vBHbvKoIWwr();
				if (EBfxUMKL9lKmioMfwLA())
				{
					num = 14;
					goto IL_0056;
				}
				num = 0;
				if (0 == 0)
				{
					goto IL_0056;
				}
				goto case 7;
			case 3:
				vN6f18KSVZUKCJBW9hQ();
				num = 12;
				goto IL_0056;
			case 2:
				if (!resizingRows)
				{
					if (!activeRange.ContainsColumn(start))
					{
						num = 9;
						if (VGUpW0K9vBHbvKoIWwr())
						{
						}
						goto IL_0056;
					}
					if (!activeRange.ContainsColumn(end))
					{
						throw new ArgumentOutOfRangeException(kgbOBx7BanbFa22Hp9.ol99ukmDA(17496));
					}
					mxbquiFVTt = start - activeRange.Column;
					break;
				}
				num = 1;
				goto IL_0056;
			case 4:
				V5LqEiTibs = resizingRows;
				num = 2;
				if (EBfxUMKL9lKmioMfwLA())
				{
					goto IL_0056;
				}
				goto case 12;
			case 12:
				base._002Ector();
				num = 8;
				goto IL_0056;
			case 13:
				BUyqQJe6eZ = (int[])wl3beVKHDNyPC7A2wgE(wHb5qkKv4W4asDfksnm(lXJqKmNptt), IAtqHZRfY0);
				num = 10;
				if (true)
				{
					goto IL_0056;
				}
				goto case 8;
			case 8:
				IAtqHZRfY0 = activeRange;
				num = 5;
				goto IL_0056;
			case 6:
			case 10:
				BWnqNoONkn = (int[])vqGXALKArMeBlLWl03p(BUyqQJe6eZ);
				num = 15;
				goto IL_0056;
			case 5:
				lXJqKmNptt = inSight;
				num = 4;
				goto IL_0056;
			case 9:
				throw new ArgumentOutOfRangeException((string)rtBVe7KESdfth4XgqHN(17482));
			case 7:
			case 14:
				throw new ArgumentOutOfRangeException((string)rtBVe7KESdfth4XgqHN(17496));
			case 0:
			case 11:
				break;
			case 15:
				return;
			}
			BUyqQJe6eZ = (int[])JFTWblKVqFX7WGHT3kl(lXJqKmNptt.SheetInfo, IAtqHZRfY0);
			num = 6;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoRowOrColumnSizeAction(CvsCellRange activeRange, CvsInSight inSight, bool resizingRows, int start, int end, int size)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		int num3 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				sI6qdQoiSD = true;
				goto case 1;
			default:
				num = 1;
				if (EBfxUMKL9lKmioMfwLA())
				{
					break;
				}
				goto case 2;
			case 2:
				num3 = mxbquiFVTt;
				VGUpW0K9vBHbvKoIWwr();
				num = ((!EBfxUMKL9lKmioMfwLA()) ? 10 : 13);
				break;
			case 5:
				return;
			case 0:
			case 6:
				if (num2 > end)
				{
					goto case 9;
				}
				if (BWnqNoONkn[num3] != size)
				{
					num = 8;
					break;
				}
				goto case 1;
			case 4:
				vN6f18KSVZUKCJBW9hQ();
				num = 12;
				break;
			case 3:
			case 13:
				num2 = start;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				BWnqNoONkn[num3] = size;
				num = 7;
				break;
			case 12:
				this._002Ector(activeRange, inSight, resizingRows, start, end);
				num = 2;
				break;
			case 1:
				num2++;
				num3++;
				num = 0;
				break;
			case 9:
			case 10:
				if (sI6qdQoiSD)
				{
					if (!resizingRows)
					{
						am4q67IcgF(Resources.UndoActionColumnWidth, resizingRows, start, end);
						num = 14;
						break;
					}
					num = 11;
					if (!VGUpW0K9vBHbvKoIWwr())
					{
						break;
					}
					goto case 0;
				}
				return;
			case 11:
				am4q67IcgF((string)BkdS8xKD6naKPZXMc2D(), resizingRows, start, end);
				num = 5;
				break;
			case 14:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoRowOrColumnSizeAction(CvsCellRange activeRange, CvsInSight inSight, bool resizingRows, int start, int end, bool hide)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 22;
		int num2 = default;
		int num3 = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				BWnqNoONkn[num2] = -BWnqNoONkn[num2];
				sI6qdQoiSD = true;
				num = 15;
				if (0 == 0)
				{
					break;
				}
				goto case 10;
			case 10:
			case 17:
			case 20:
				while (true)
				{
					if (num3 > end)
					{
						num = 18;
						break;
					}
					if (!hide)
					{
						if (BWnqNoONkn[num2] < 0)
						{
							num = 1;
							if (true)
							{
								break;
							}
							continue;
						}
						goto case 15;
					}
					goto IL_019c;
				}
				break;
			case 4:
				if (hide)
				{
					num = 24;
					break;
				}
				if (start != end)
				{
					if (resizingRows)
					{
						text = (string)pLJAAZKjr52nuOqDYXW();
						num = 3;
						if (true)
						{
							break;
						}
						goto case 23;
					}
					text = Resources.UndoActionUnhideColumns;
					num = 9;
					if (true)
					{
						break;
					}
					goto case 14;
				}
				if (resizingRows)
				{
					num = 12;
					break;
				}
				text = (string)Acbfe0KBlXLlBJ7sB7n();
				num = 21;
				if (VGUpW0K9vBHbvKoIWwr())
				{
				}
				break;
			case 6:
				this._002Ector(activeRange, inSight, resizingRows, start, end);
				num2 = mxbquiFVTt;
				num = 2;
				break;
			case 12:
				text = (string)qntAsVKqsTySunUeMUK();
				num = 19;
				if (0 == 0)
				{
					break;
				}
				goto case 22;
			case 22:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 6;
				break;
			case 23:
				if (BWnqNoONkn[num2] > 0)
				{
					_ = 0;
					num = ((!EBfxUMKL9lKmioMfwLA()) ? 20 : 13);
					break;
				}
				goto case 15;
			case 14:
				text = (string)dNMTaMKUvwJ8imf8loa();
				goto case 0;
			case 15:
			case 16:
				num3++;
				num = 7;
				break;
			case 2:
				num3 = start;
				num = 17;
				break;
			case 24:
				if (start != end)
				{
					if (!resizingRows)
					{
						text = (string)Owas2mKiaq5HbHBj5kB();
						num = 11;
					}
					else
					{
						text = (string)sDy5ZdKd1Jn8ZX9HVYw();
						num = 8;
					}
				}
				else if (!resizingRows)
				{
					text = (string)KWxwyFKTbFDC7eG1ccp();
					num = 0;
				}
				else
				{
					num = 14;
				}
				break;
			case 0:
			case 3:
			case 8:
			case 9:
			case 11:
			case 19:
			case 21:
				am4q67IcgF(text, resizingRows, start, end);
				num = 25;
				break;
			case 7:
				num2++;
				goto case 10;
			case 18:
				if (sI6qdQoiSD)
				{
					goto case 4;
				}
				return;
			default:
				num = 4;
				break;
			case 5:
			case 13:
				BWnqNoONkn[num2] = -BWnqNoONkn[num2];
				sI6qdQoiSD = true;
				num = 16;
				break;
			case 25:
				return;
				IL_019c:
				num = 23;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void am4q67IcgF(string P_0, bool P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		StringBuilder stringBuilder = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 12:
				if (P_2 != P_3)
				{
					num = 10;
					break;
				}
				goto case 0;
			case 7:
			case 9:
				sneAZZKcRJ93cYgVoIk(stringBuilder, P_3.ToString((IFormatProvider)kkREIwK2KDSBZEN6Onp()));
				goto case 0;
			case 10:
				sneAZZKcRJ93cYgVoIk(stringBuilder, rtBVe7KESdfth4XgqHN(17514));
				goto case 6;
			default:
				num = 6;
				break;
			case 1:
				stringBuilder = new StringBuilder(P_0);
				num = 11;
				break;
			case 6:
				if (!P_1)
				{
					stringBuilder.Append((char)(65 + P_3));
					num = 4;
					break;
				}
				_ = 0;
				if (!EBfxUMKL9lKmioMfwLA())
				{
					num = 0;
					break;
				}
				num = 9;
				if (!VGUpW0K9vBHbvKoIWwr())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
			case 8:
				stringBuilder.Append((string)rtBVe7KESdfth4XgqHN(17520));
				num = 3;
				break;
			case 3:
				iyAqinObDX = stringBuilder.ToString();
				num = 13;
				break;
			case 11:
				sneAZZKcRJ93cYgVoIk(stringBuilder, rtBVe7KESdfth4XgqHN(17506));
				if (!P_1)
				{
					a7Z3i5KWKppeAM880Ei(stringBuilder, (char)(65 + P_2));
					num = 5;
					if (!VGUpW0K9vBHbvKoIWwr())
					{
						break;
					}
					goto case 0;
				}
				num = 2;
				break;
			case 2:
				sneAZZKcRJ93cYgVoIk(stringBuilder, P_2.ToString((IFormatProvider)kkREIwK2KDSBZEN6Onp()));
				num = 12;
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__14))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSaveState_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = HSmKWnK70131Q7iKxEB();
				EBfxUMKL9lKmioMfwLA();
				num = ((!VGUpW0K9vBHbvKoIWwr()) ? 4 : 0);
				continue;
			case 1:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				if (EBfxUMKL9lKmioMfwLA())
				{
					continue;
				}
				break;
			case 5:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__15))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CDo_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (EBfxUMKL9lKmioMfwLA())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (VGUpW0K9vBHbvKoIWwr())
				{
				}
				continue;
			case 2:
				stateMachine._003C_003Et__builder = HSmKWnK70131Q7iKxEB();
				EBfxUMKL9lKmioMfwLA();
				if (VGUpW0K9vBHbvKoIWwr())
				{
					num = 0;
					continue;
				}
				num = 5;
				if (!VGUpW0K9vBHbvKoIWwr())
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__16))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (VGUpW0K9vBHbvKoIWwr() ? 4 : 5);
		_003CRedo_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (EBfxUMKL9lKmioMfwLA())
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = HSmKWnK70131Q7iKxEB();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__19))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!VGUpW0K9vBHbvKoIWwr())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_00a1;
			}
		}
		goto IL_003e;
		IL_003e:
		_003CUndo_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				break;
			case 1:
			case 4:
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_00a1;
		IL_00a1:
		stateMachine._003C_003E4__this = this;
		num = 3;
		goto IL_003e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vN6f18KSVZUKCJBW9hQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rtBVe7KESdfth4XgqHN(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wHb5qkKv4W4asDfksnm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).SheetInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wl3beVKHDNyPC7A2wgE(object P_0, CvsCellRange activeRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsSheetInfo)P_0).GetRowHeights(activeRange);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JFTWblKVqFX7WGHT3kl(object P_0, CvsCellRange activeRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsSheetInfo)P_0).GetColumnWidths(activeRange);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vqGXALKArMeBlLWl03p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Array)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EBfxUMKL9lKmioMfwLA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VGUpW0K9vBHbvKoIWwr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BkdS8xKD6naKPZXMc2D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionRowHeight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dNMTaMKUvwJ8imf8loa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionHideRow;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KWxwyFKTbFDC7eG1ccp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionHideColumn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sDy5ZdKd1Jn8ZX9HVYw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionHideRows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Owas2mKiaq5HbHBj5kB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionHideColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qntAsVKqsTySunUeMUK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionUnhideRow;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Acbfe0KBlXLlBJ7sB7n()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionUnhideColumn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pLJAAZKjr52nuOqDYXW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionUnhideRows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sneAZZKcRJ93cYgVoIk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kkREIwK2KDSBZEN6Onp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a7Z3i5KWKppeAM880Ei(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder HSmKWnK70131Q7iKxEB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
