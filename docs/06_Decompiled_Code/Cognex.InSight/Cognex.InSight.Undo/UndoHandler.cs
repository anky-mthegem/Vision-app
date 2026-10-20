using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Sensor;
using Cognex.InSight.UserAccess;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public sealed class UndoHandler : UndoRedoQueue, IInsertDeleteService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnUndoChangedAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public UndoEventType eventType;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			snY9OusWfe3k26Jc9AO4();
			int num = ((!kt0q3VsWkLdhUl2hQXvD()) ? 2 : 5);
			UndoHandler undoHandler = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					undoHandler = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 11;
								if (1 == 0)
								{
									goto IL_0078;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
								if (!kt0q3VsWkLdhUl2hQXvD())
								{
									goto IL_0257;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (snY9OusWfe3k26Jc9AO4())
							{
								return;
							}
						}
						goto IL_00bb;
						IL_0078:
						awaiter = lZ8asvsWm6C8DcfUXrFQ(VhNpH6sWFNgZr8bUqlC9(undoHandler.knCgT6fkuY, eventType));
						num3 = 4;
						goto IL_00bb;
						IL_00bb:
						while (true)
						{
							switch (num3)
							{
							case 15:
								break;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto IL_00a2;
							default:
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (!snY9OusWfe3k26Jc9AO4())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								continue;
							case 11:
								awaiter = undoHandler.xbFggv3SKn(eventType).GetAwaiter();
								kt0q3VsWkLdhUl2hQXvD();
								if (!snY9OusWfe3k26Jc9AO4())
								{
									num3 = 0;
									continue;
								}
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 0:
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto IL_00a2;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto IL_0257;
							case 7:
								_003C_003Eu__1 = default;
								goto case 6;
							case 9:
								num2 = (_003C_003E1__state = 1);
								num3 = 10;
								if (kt0q3VsWkLdhUl2hQXvD())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 13;
								continue;
							case 12:
								return;
							case 14:
								return;
							case 16:
								goto IL_0257;
								IL_00a2:
								awaiter.GetResult();
								break;
							}
							break;
						}
						goto IL_0078;
						IL_0257:
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
		internal static object VhNpH6sWFNgZr8bUqlC9(object P_0, UndoEventType type)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).HandleUndoChangedAsync(type);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lZ8asvsWm6C8DcfUXrFQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kt0q3VsWkLdhUl2hQXvD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool snY9OusWfe3k26Jc9AO4()
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
	private struct _003CDoCopyAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellClipboardData> _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			UndoHandler undoHandler = default;
			int num4 = default;
			int num5 = default;
			StringBuilder stringBuilder = default;
			CvsCell cvsCell = default;
			CvsCellClipboardData result = default;
			byte[] result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((UndoHandler)OGWIZPsWZnNhrfOlJt0B(undoHandler.knCgT6fkuY)).SendCopyAsync(cellRange).GetAwaiter();
							num3 = 17;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (1 == 0)
							{
								goto IL_0295;
							}
						}
						goto IL_022e;
						IL_0295:
						if (num4 <= cellRange.LastRow)
						{
							num5 = cellRange.Column;
							nHbCiDsWgjPnScR6HFIr();
							num3 = (tD3xHusWyOu5BPp6Hujn() ? 20 : 15);
						}
						else
						{
							num3 = 21;
						}
						goto IL_022e;
						IL_022e:
						while (true)
						{
							switch (num3)
							{
							case 4:
								xt7cDRs7hhEaaBvi7i05(stringBuilder, WSLnQvs7sXUXMgp5APhy(46486));
								num3 = 13;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								continue;
							case 9:
							case 15:
							case 16:
							case 20:
							{
								if (num5 > cellRange.LastColumn)
								{
									if (num4 < cellRange.LastRow)
									{
										num3 = 2;
										continue;
									}
									goto IL_0170;
								}
								CvsCellLocation cell = new CvsCellLocation(num4, num5);
								cvsCell = (CvsCell)uh5vwdsWzZlGYwZ9V88B(DVO83XsW8WNsHAOWlWQT(suqvUnsWJY481fL8O4K4(undoHandler.knCgT6fkuY)), cell);
								goto case 14;
							}
							case 13:
							case 18:
								if (num5 < cellRange.LastColumn)
								{
									xt7cDRs7hhEaaBvi7i05(stringBuilder, WSLnQvs7sXUXMgp5APhy(42570));
									num3 = 5;
									continue;
								}
								goto case 5;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 0:
								if (!cvsCell.Error)
								{
									xt7cDRs7hhEaaBvi7i05(stringBuilder, cvsCell.ToString());
									num3 = 18;
								}
								else
								{
									num3 = 4;
								}
								continue;
							case 5:
								num5++;
								goto case 9;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 19;
								continue;
							case 17:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto IL_02ba;
							case 2:
								xt7cDRs7hhEaaBvi7i05(stringBuilder, WSLnQvs7sXUXMgp5APhy(6014));
								goto IL_0170;
							case 12:
								return;
							case 14:
								if (!cnCKIls7wbBe7A8bYXQt(cvsCell))
								{
									num3 = 0;
									continue;
								}
								goto case 13;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (!nHbCiDsWgjPnScR6HFIr())
								{
									continue;
								}
								goto case 9;
							default:
								num3 = 14;
								continue;
							case 1:
							case 8:
								break;
							case 19:
								num2 = (_003C_003E1__state = -1);
								goto IL_02ba;
							case 11:
								stringBuilder = new StringBuilder();
								num4 = cellRange.Row;
								num3 = 8;
								continue;
							case 21:
								{
									result = (CvsCellClipboardData)CUjoIBs7LwWrUtdiLxmV(result2, stringBuilder.ToString());
									goto end_IL_022e;
								}
								IL_02ba:
								result2 = awaiter.GetResult();
								num3 = 11;
								continue;
								IL_0170:
								num4++;
								num3 = 1;
								continue;
							}
							goto IL_0295;
							continue;
							end_IL_022e:
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
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					break;
				case 1:
				case 4:
					undoHandler = _003C_003E4__this;
					goto case 2;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				tD3xHusWyOu5BPp6Hujn();
				num = (nHbCiDsWgjPnScR6HFIr() ? 3 : 4);
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
		internal static object OGWIZPsWZnNhrfOlJt0B(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object suqvUnsWJY481fL8O4K4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DVO83XsW8WNsHAOWlWQT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uh5vwdsWzZlGYwZ9V88B(object P_0, CvsCellLocation cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[cell];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cnCKIls7wbBe7A8bYXQt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCell.IsNullOrEmpty((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WSLnQvs7sXUXMgp5APhy(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xt7cDRs7hhEaaBvi7i05(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StringBuilder)P_0).Append((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CUjoIBs7LwWrUtdiLxmV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellClipboardData.SetClipboard((byte[])P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tD3xHusWyOu5BPp6Hujn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nHbCiDsWgjPnScR6HFIr()
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
	private struct _003CDoPaste_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

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
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!aPINlBs79VWnSrcJxYSL()) ? 4 : 5);
					continue;
				case 1:
				case 5:
					undoHandler = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = V7BcIms7EAe8wML39tlb(undoHandler.AddUndo(new UndoPasteAction(undoHandler.knCgT6fkuY, cellRange)));
							num3 = 7;
							if (!aPINlBs79VWnSrcJxYSL())
							{
								goto IL_0090;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 6:
								break;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 0;
								if (aPINlBs79VWnSrcJxYSL())
								{
									num3 = 1;
									continue;
								}
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 1:
							case 4:
								return;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (iwpRUMs7SnWByjV6hSRW())
								{
								}
								continue;
							case 2:
								_003C_003Eu__1 = default;
								break;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (aPINlBs79VWnSrcJxYSL())
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_00c3;
							}
							goto IL_0090;
							continue;
							end_IL_00c3:
							break;
						}
						goto end_IL_005d;
						IL_0090:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00c3;
						end_IL_005d:;
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
		internal static TaskAwaiter V7BcIms7EAe8wML39tlb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aPINlBs79VWnSrcJxYSL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iwpRUMs7SnWByjV6hSRW()
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
	private struct _003CDoPaste_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		public byte[] pasteData;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UBvQ0ns7v6i43hITmaKt();
			int num = (DkoBGFs7HPYZOd5ctUV7() ? 5 : 3);
			int num2 = default;
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = flp67Bs7V54dVf4PhZJC(undoHandler.AddUndo(new UndoPasteAction(undoHandler.knCgT6fkuY, cellRange, pasteData)));
							num3 = 8;
							if (1 == 0)
							{
								goto IL_0072;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (1 == 0)
							{
								goto IL_0149;
							}
						}
						goto IL_00a8;
						IL_0149:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						goto IL_00a8;
						IL_00a8:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 0:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (UBvQ0ns7v6i43hITmaKt())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								num3 = (DkoBGFs7HPYZOd5ctUV7() ? 4 : 0);
								continue;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								goto case 4;
							case 7:
								return;
							case 1:
								goto IL_0149;
							case 9:
								goto IL_015c;
							}
							break;
						}
						goto IL_0072;
						IL_0072:
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							goto IL_00a8;
						}
						goto IL_015c;
						IL_015c:
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
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 5:
					undoHandler = _003C_003E4__this;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
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
		internal static TaskAwaiter flp67Bs7V54dVf4PhZJC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UBvQ0ns7v6i43hITmaKt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DkoBGFs7HPYZOd5ctUV7()
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
	private struct _003CDoCutAndPaste_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cutyRange;

		public CvsCellRange pasteRange;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gUpYmQs7AgYM2VRRdGle();
			int num = (RNCy72s7DWaIsOCE6DG3() ? 4 : 3);
			int num2 = default;
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = VvOUEMs7UVoTfMjKdlqO(undoHandler.AddUndo(new UndoCutAndPasteAction(undoHandler.knCgT6fkuY, cutyRange, pasteRange)));
							gUpYmQs7AgYM2VRRdGle();
							num3 = (RNCy72s7DWaIsOCE6DG3() ? 1 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (RNCy72s7DWaIsOCE6DG3())
								{
								}
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (RNCy72s7DWaIsOCE6DG3())
								{
								}
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 1:
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
					break;
				default:
					num = 5;
					if (!RNCy72s7DWaIsOCE6DG3())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 5:
					break;
				case 1:
					undoHandler = _003C_003E4__this;
					goto case 2;
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
		internal static TaskAwaiter VvOUEMs7UVoTfMjKdlqO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gUpYmQs7AgYM2VRRdGle()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RNCy72s7DWaIsOCE6DG3()
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
	private struct _003CDoInsert_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		public ShiftCells shift;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			viAeDms7d1YYwee8eOm7();
			int num = (G0q3ofs7TASHlWwibmKZ() ? 1 : 4);
			int num2 = default;
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = UrFEg6s7iAtjCEhRi1sw(undoHandler.AddUndo(new UndoInsertAction(undoHandler.knCgT6fkuY, cellRange, shift)));
							_ = 1;
							num3 = (viAeDms7d1YYwee8eOm7() ? 1 : 6);
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
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (true)
								{
									continue;
								}
								return;
							case 8:
								return;
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 1;
							case 0:
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 4;
								if (!viAeDms7d1YYwee8eOm7())
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (true)
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
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					if (G0q3ofs7TASHlWwibmKZ())
					{
						continue;
					}
					goto case 2;
				case 2:
					undoHandler = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (viAeDms7d1YYwee8eOm7())
				{
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
		internal static TaskAwaiter UrFEg6s7iAtjCEhRi1sw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G0q3ofs7TASHlWwibmKZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool viAeDms7d1YYwee8eOm7()
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
	private struct _003CDoImportCxdxSnippet_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		public Func<Task> func;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LK60LMs7qvRw3eyE6DKr();
			int num;
			if (!nHDt4ls7BF9wx8iicJpU())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (!LK60LMs7qvRw3eyE6DKr())
				{
					goto IL_01cd;
				}
			}
			goto IL_017f;
			IL_01e8:
			UndoHandler undoHandler = _003C_003E4__this;
			num = 5;
			goto IL_017f;
			IL_01cd:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (LK60LMs7qvRw3eyE6DKr())
			{
				goto IL_017f;
			}
			goto IL_01e8;
			IL_017f:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = CiXPpYs7j0GvoUZBbjE2(undoHandler.AddUndo(new UndoImportCxdxSnippetAction(undoHandler.knCgT6fkuY, cellRange, func)));
							num3 = 0;
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
							case 1:
								return;
							case 3:
								_003C_003Eu__1 = default;
								goto case 4;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (!LK60LMs7qvRw3eyE6DKr())
								{
									num3 = 4;
									if (true)
									{
										continue;
									}
									goto case 5;
								}
								num3 = 7;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
							case 7:
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
					break;
				default:
					num = 3;
					if (LK60LMs7qvRw3eyE6DKr())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto IL_01e8;
				case 3:
					break;
				case 1:
				case 2:
					goto IL_01e8;
				case 6:
					return;
				}
				break;
			}
			goto IL_01cd;
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
		internal static TaskAwaiter CiXPpYs7j0GvoUZBbjE2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LK60LMs7qvRw3eyE6DKr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nHDt4ls7BF9wx8iicJpU()
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
	private struct _003CDoDelete_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		public ShiftCells shift;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoHandler undoHandler = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 5:
					undoHandler = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoHandler.AddUndo(new UndoDeleteAction(undoHandler.knCgT6fkuY, cellRange, shift)).GetAwaiter();
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								_ = 1;
								if (fdw6tIs722HcsUqpmJHK())
								{
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 7;
								}
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 0:
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
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
					goto case 3;
				default:
					num = 3;
					if (Rfemnds7cTiURywIjskq())
					{
						continue;
					}
					break;
				case 0:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				Rfemnds7cTiURywIjskq();
				if (fdw6tIs722HcsUqpmJHK())
				{
					num = 4;
					continue;
				}
				num = 5;
				if (fdw6tIs722HcsUqpmJHK())
				{
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
		internal static bool Rfemnds7cTiURywIjskq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fdw6tIs722HcsUqpmJHK()
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
	private struct _003CDoClearContent_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

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
			UndoHandler undoHandler = default;
			List<CvsCogCellResult> list = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					KrdWwIs77M8IfMTNFgRP();
					if (Ac3Qvas7WA1FsQEK6fjL())
					{
						num = 4;
						break;
					}
					num = 2;
					if (KrdWwIs77M8IfMTNFgRP())
					{
					}
					break;
				case 1:
				case 4:
					undoHandler = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							list = ((CvsCellCollection)VryR5Hs7CnAycUZbwAYH(EikIBes7tQ0uvNRA7crM(undoHandler.knCgT6fkuY))).CreateCogCellResultList(cellRange);
							Ac3Qvas7WA1FsQEK6fjL();
							if (!KrdWwIs77M8IfMTNFgRP())
							{
								num3 = 9;
								if (KrdWwIs77M8IfMTNFgRP())
								{
								}
							}
							else
							{
								num3 = 3;
								if (KrdWwIs77M8IfMTNFgRP())
								{
									goto IL_00da;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_0135;
						IL_0135:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									goto case 2;
								}
								goto case 10;
							case 0:
							case 9:
								break;
							case 5:
								goto IL_0104;
							case 7:
								_003C_003Eu__1 = awaiter;
								goto IL_0104;
							default:
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 1:
								return;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_005f;
							}
							break;
						}
						goto IL_00da;
						IL_00da:
						awaiter = undoHandler.AddUndo(new UndoClearContent(undoHandler.knCgT6fkuY, cellRange, list)).GetAwaiter();
						num3 = 8;
						if (1 == 0)
						{
							goto IL_0104;
						}
						goto IL_0135;
						IL_0104:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 1;
						goto IL_0135;
						end_IL_005f:;
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
		internal static object EikIBes7tQ0uvNRA7crM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VryR5Hs7CnAycUZbwAYH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ac3Qvas7WA1FsQEK6fjL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KrdWwIs77M8IfMTNFgRP()
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
	private struct _003CDoClearFormats_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			payHtTs7KlnDuLMPVEKP();
			int num;
			if (!fTRsLPs75eKZ6AfNJD5v())
			{
				num = 1;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01b8;
			IL_002a:
			UndoHandler undoHandler = _003C_003E4__this;
			num = 5;
			goto IL_01b8;
			IL_01b8:
			int num2 = default;
			List<CvsCellFormat> cellFormats = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cellFormats = new List<CvsCellFormat>();
							_ = 1;
							num3 = (fTRsLPs75eKZ6AfNJD5v() ? 3 : 9);
							goto IL_008c;
						}
						awaiter = _003C_003Eu__1;
						goto IL_005d;
						IL_008c:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 6:
								break;
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 4:
								return;
							case 0:
							case 9:
								awaiter = DdOknTs7PrGGfss6ZnA3(undoHandler.AddUndo(new UndoCellStyleAction(undoHandler.knCgT6fkuY, cellRange, cellFormats, (string)aiZVY2s7ogbf9EZWx8TW(Resources.UndoHandlerFormatCells, cellRange))));
								num3 = 8;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_008c;
							}
							goto IL_005d;
							continue;
							end_IL_008c:
							break;
						}
						goto end_IL_003b;
						IL_005d:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_008c;
						end_IL_003b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					if (fTRsLPs75eKZ6AfNJD5v())
					{
					}
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
		internal static object aiZVY2s7ogbf9EZWx8TW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DdOknTs7PrGGfss6ZnA3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool payHtTs7KlnDuLMPVEKP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fTRsLPs75eKZ6AfNJD5v()
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
	private struct _003CDoClearComments_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

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
			if (Qoj0cxs7Y6QXxFD8TknE())
			{
				num = 4;
				if (EaAyCEs7NDr0qgcvNBBG())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0204;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0204;
			IL_0204:
			UndoHandler undoHandler = default;
			int num2 = default;
			List<CvsCogCellResult> oldComments = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					undoHandler = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							oldComments = ((CvsCellCollection)rnthqMs71DLuZYB65XdX(JJYKwas7xHqNjQsYtQfJ(undoHandler.knCgT6fkuY))).CreateCogCellResultList(cellRange);
							num3 = 1;
							goto IL_0150;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0091;
						IL_0091:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_0150;
						IL_0150:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 6:
								break;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (Qoj0cxs7Y6QXxFD8TknE())
									{
										num3 = 8;
										continue;
									}
									num3 = 5;
									if (Qoj0cxs7Y6QXxFD8TknE())
									{
										continue;
									}
								}
								goto case 10;
							case 2:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 1:
								awaiter = JngTZgs7rMiBXDuFUYyq(undoHandler.AddUndo(new UndoCellCommentsClearAction(undoHandler.knCgT6fkuY, cellRange, oldComments, string.Format(Resources.UndoHandlerClearComments, cellRange))));
								num3 = 7;
								if (Qoj0cxs7Y6QXxFD8TknE())
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
								return;
							case 10:
								awaiter.GetResult();
								goto end_IL_0150;
							}
							goto IL_0091;
							continue;
							end_IL_0150:
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
		internal static object JJYKwas7xHqNjQsYtQfJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rnthqMs71DLuZYB65XdX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter JngTZgs7rMiBXDuFUYyq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Qoj0cxs7Y6QXxFD8TknE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EaAyCEs7NDr0qgcvNBBG()
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
	private struct _003CDoClearCellNames_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

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
			if (!Er3dqEs7OvPRCLR7e7Ms())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (Er3dqEs7OvPRCLR7e7Ms())
				{
				}
			}
			int num2 = default;
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = hoaxIGs7Mr9OHAsFwtIO(undoHandler.AddUndo(new UndoClearCellNameAction(undoHandler.knCgT6fkuY, cellRange)));
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (false)
							{
								goto IL_0152;
							}
						}
						goto IL_00ed;
						IL_0152:
						_003C_003Eu__1 = awaiter;
						num3 = 2;
						goto IL_00ed;
						IL_00ed:
						while (true)
						{
							switch (num3)
							{
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (Er3dqEs7OvPRCLR7e7Ms())
								{
								}
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 1;
								if (!Er3dqEs7OvPRCLR7e7Ms())
								{
									num3 = 1;
									if (Er3dqEs7OvPRCLR7e7Ms())
									{
									}
									continue;
								}
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 1:
							case 4:
								return;
							case 3:
								break;
							case 0:
								_003C_003Eu__1 = default;
								goto case 6;
							case 9:
								awaiter.GetResult();
								goto end_IL_00ed;
							}
							goto IL_0152;
							continue;
							end_IL_00ed:
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
					goto case 2;
				default:
					num = 2;
					continue;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				undoHandler = _003C_003E4__this;
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
		internal static TaskAwaiter hoaxIGs7Mr9OHAsFwtIO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yVWcyus73pL3CXKPLRsx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Er3dqEs7OvPRCLR7e7Ms()
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
	private struct _003CDoClearAll_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oYM8S2s7l4Gi98IyFiHF();
			int num;
			if (GW2PMys7QmXweIyxeZiP())
			{
				num = 1;
				if (oYM8S2s7l4Gi98IyFiHF())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_01e7;
				}
			}
			goto IL_01b4;
			IL_002e:
			int num2 = default;
			UndoHandler undoHandler = default;
			try
			{
				List<CvsCogCellResult> list = default;
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					list = ((CvsCellCollection)Ex1Fd4s7elln7ZK49nsJ(undoHandler.knCgT6fkuY.Results)).CreateCogCellResultList(cellRange);
					GW2PMys7QmXweIyxeZiP();
					if (!oYM8S2s7l4Gi98IyFiHF())
					{
						num3 = 1;
					}
					else
					{
						num3 = 5;
						if (!GW2PMys7QmXweIyxeZiP())
						{
							goto IL_010b;
						}
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 6;
				}
				goto IL_00c4;
				IL_00c4:
				while (true)
				{
					switch (num3)
					{
					default:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						continue;
					case 2:
						return;
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						continue;
					case 8:
						_003C_003Eu__1 = awaiter;
						goto default;
					case 9:
						break;
					case 6:
						_003C_003Eu__1 = default;
						num3 = 7;
						continue;
					case 0:
					case 1:
						awaiter = LmN6jrs7unFBVapC17Zk(undoHandler.AddUndo(new UndoClearAllAction(undoHandler.knCgT6fkuY, cellRange, list)));
						num3 = 9;
						continue;
					case 7:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 10:
						goto IL_0172;
					}
					break;
				}
				goto IL_010b;
				IL_0172:
				awaiter.GetResult();
				goto end_IL_002e;
				IL_010b:
				if (!awaiter.IsCompleted)
				{
					num3 = 3;
					goto IL_00c4;
				}
				goto IL_0172;
				end_IL_002e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_020d;
			IL_01fa:
			undoHandler = _003C_003E4__this;
			num = 5;
			if (true)
			{
				goto IL_01b4;
			}
			goto IL_020d;
			IL_01e7:
			num2 = _003C_003E1__state;
			num = 2;
			if (true)
			{
				goto IL_01b4;
			}
			goto IL_01fa;
			IL_01b4:
			switch (num)
			{
			case 5:
				break;
			case 0:
			case 1:
				goto IL_01e7;
			case 2:
				goto IL_01fa;
			default:
				goto IL_020d;
			case 6:
				return;
			}
			goto IL_002e;
			IL_020d:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				return;
			}
			goto IL_01b4;
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
		internal static object Ex1Fd4s7elln7ZK49nsJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter LmN6jrs7unFBVapC17Zk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GW2PMys7QmXweIyxeZiP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oYM8S2s7l4Gi98IyFiHF()
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
	private struct _003CDoRowHeights_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange activeRange;

		public UndoHandler _003C_003E4__this;

		public int startRow;

		public int endRow;

		public int height;

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
			if (!VTIoDls7R1qHjKEw0C2F())
			{
				num = 1;
				if (!MIQ5wss7IWAlwuJlNJBk())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_01f6;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01f6;
			IL_01f6:
			int num2 = default;
			UndoHandler undoHandler = default;
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 2:
					undoHandler = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoRowOrColumnSizeAction = new UndoRowOrColumnSizeAction(activeRange, undoHandler.knCgT6fkuY, resizingRows: true, startRow, endRow, height);
							num3 = 9;
							if (!MIQ5wss7IWAlwuJlNJBk())
							{
								goto IL_009c;
							}
							goto IL_011b;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00d2;
						IL_00ea:
						if (!awaiter.IsCompleted)
						{
							num3 = 0;
							goto IL_011b;
						}
						goto IL_01b4;
						IL_00d2:
						_003C_003Eu__1 = default;
						num3 = 7;
						if (false)
						{
							goto IL_00ea;
						}
						goto IL_011b;
						IL_009c:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						goto IL_011b;
						IL_011b:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 4:
								break;
							case 9:
								if (pd9Q3js7aqgdfL6UwaGK(undoRowOrColumnSizeAction))
								{
									num3 = 1;
									if (0 == 0)
									{
										continue;
									}
									goto IL_00d2;
								}
								goto end_IL_0061;
							case 5:
							case 6:
								goto IL_00d2;
							case 8:
								goto IL_00ea;
							case 0:
								num2 = (_003C_003E1__state = 0);
								goto default;
							default:
								VTIoDls7R1qHjKEw0C2F();
								num3 = ((!MIQ5wss7IWAlwuJlNJBk()) ? 5 : 3);
								continue;
							case 2:
								return;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								awaiter = astNxQs7n2WW3BGLtrtX(undoHandler.AddUndo(undoRowOrColumnSizeAction));
								num3 = 8;
								if (!VTIoDls7R1qHjKEw0C2F())
								{
									continue;
								}
								goto IL_01b4;
							case 10:
								goto IL_01b4;
							}
							break;
						}
						goto IL_009c;
						IL_01b4:
						awaiter.GetResult();
						end_IL_0061:;
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
		internal static bool pd9Q3js7aqgdfL6UwaGK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRowOrColumnSizeAction)P_0).CanDo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter astNxQs7n2WW3BGLtrtX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MIQ5wss7IWAlwuJlNJBk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VTIoDls7R1qHjKEw0C2F()
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
	private struct _003CDoColumnWidths_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange activeRange;

		public UndoHandler _003C_003E4__this;

		public int startColumn;

		public int endColumn;

		public int width;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			UndoHandler undoHandler = default;
			int num2 = default;
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
					undoHandler = _003C_003E4__this;
					_ = 1;
					if (!TKdrYPs7XWo1DLGhJf4K())
					{
						num = 5;
						break;
					}
					num = 1;
					if (BqZun4s7GHL7CoHNyIqt())
					{
						break;
					}
					return;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoRowOrColumnSizeAction = new UndoRowOrColumnSizeAction(activeRange, undoHandler.knCgT6fkuY, resizingRows: false, startColumn, endColumn, width);
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								return;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								if (TKdrYPs7XWo1DLGhJf4K())
								{
								}
								continue;
							case 1:
							case 2:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 3;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								if (lxFQKEs7bDXMaFJ9n469(undoRowOrColumnSizeAction))
								{
									num3 = 8;
									continue;
								}
								goto end_IL_0146;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 3:
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 8:
								awaiter = fAEsnls76jmReWVIl6YU(undoHandler.AddUndo(undoRowOrColumnSizeAction));
								BqZun4s7GHL7CoHNyIqt();
								num3 = ((!TKdrYPs7XWo1DLGhJf4K()) ? 1 : 4);
								continue;
							case 10:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0146:
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
		internal static bool lxFQKEs7bDXMaFJ9n469(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRowOrColumnSizeAction)P_0).CanDo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter fAEsnls76jmReWVIl6YU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BqZun4s7GHL7CoHNyIqt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TKdrYPs7XWo1DLGhJf4K()
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
	private struct _003CDoHideRows_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange activeRange;

		public UndoHandler _003C_003E4__this;

		public int startRow;

		public int endRow;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TvEqrrs7piIMI280V14p();
			int num = (ppE4aYs70F2kH6pSmfMK() ? 5 : 2);
			int num2 = default;
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			UndoHandler undoHandler = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoRowOrColumnSizeAction = new UndoRowOrColumnSizeAction(activeRange, undoHandler.knCgT6fkuY, resizingRows: true, startRow, endRow, hide: true);
							num3 = 1;
							if (ppE4aYs70F2kH6pSmfMK())
							{
								goto IL_0073;
							}
							goto IL_00d4;
						}
						awaiter = _003C_003Eu__1;
						goto IL_010f;
						IL_0183:
						awaiter.GetResult();
						goto end_IL_003d;
						IL_00d4:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 0:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								num2 = (_003C_003E1__state = 0);
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 6:
							case 8:
								goto IL_010f;
							case 1:
								if (Fc9moes74dVJdDGlxbtB(undoRowOrColumnSizeAction))
								{
									num3 = 2;
									continue;
								}
								goto end_IL_003d;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								awaiter = AnP08bs7kHErbXxqnEjE(undoHandler.AddUndo(undoRowOrColumnSizeAction));
								num3 = 7;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								if (ppE4aYs70F2kH6pSmfMK())
								{
									num3 = 8;
									if (!ppE4aYs70F2kH6pSmfMK())
									{
										continue;
									}
									goto case 3;
								}
								num3 = 0;
								continue;
							case 10:
								goto IL_0183;
							}
							break;
						}
						goto IL_0073;
						IL_0073:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							goto IL_00d4;
						}
						goto IL_0183;
						IL_010f:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_00d4;
						end_IL_003d:;
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
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				undoHandler = _003C_003E4__this;
				num = 3;
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
		internal static bool Fc9moes74dVJdDGlxbtB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRowOrColumnSizeAction)P_0).CanDo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter AnP08bs7kHErbXxqnEjE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TvEqrrs7piIMI280V14p()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ppE4aYs70F2kH6pSmfMK()
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
	private struct _003CDoUnhideRows_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange activeRange;

		public UndoHandler _003C_003E4__this;

		public int startRow;

		public int endRow;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LAYrtNs7FdVp7cG562aD();
			int num;
			if (K90K4ts7fGAA6fi72Gfo())
			{
				num = 3;
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					return;
				}
			}
			int num2 = default;
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			UndoHandler undoHandler = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoRowOrColumnSizeAction = new UndoRowOrColumnSizeAction(activeRange, undoHandler.knCgT6fkuY, resizingRows: true, startRow, endRow, hide: false);
							_ = 0;
							num3 = ((!K90K4ts7fGAA6fi72Gfo()) ? 1 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 4:
								return;
							case 8:
								awaiter = HT87uLs7y8a9VXXYXxnt(undoHandler.AddUndo(undoRowOrColumnSizeAction));
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 1:
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 0:
							case 5:
								if (di3fius7maei4XuF9DqG(undoRowOrColumnSizeAction))
								{
									num3 = 8;
									continue;
								}
								goto end_IL_00e1;
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto case 1;
							case 10:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_00e1:
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
					goto case 2;
				default:
					num = 2;
					continue;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 5:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				undoHandler = _003C_003E4__this;
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
		internal static bool di3fius7maei4XuF9DqG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRowOrColumnSizeAction)P_0).CanDo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter HT87uLs7y8a9VXXYXxnt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K90K4ts7fGAA6fi72Gfo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LAYrtNs7FdVp7cG562aD()
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
	private struct _003CDoHideColumns_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange activeRange;

		public UndoHandler _003C_003E4__this;

		public int startColumn;

		public int endColumn;

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
			if (!h8iCbKs7ZxnuqE57hDP2())
			{
				num = 2;
				if (!dsaGVns7gw3QomHZA5i5())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01c7;
			IL_002a:
			UndoHandler undoHandler = _003C_003E4__this;
			num = 5;
			goto IL_01c7;
			IL_01c7:
			int num2 = default;
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoRowOrColumnSizeAction = new UndoRowOrColumnSizeAction(activeRange, undoHandler.knCgT6fkuY, resizingRows: false, startColumn, endColumn, hide: true);
							num3 = 9;
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
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								if (!h8iCbKs7ZxnuqE57hDP2())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								awaiter = undoHandler.AddUndo(undoRowOrColumnSizeAction).GetAwaiter();
								goto case 2;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									return;
								}
								break;
							case 5:
								return;
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							default:
								num3 = 3;
								if (dsaGVns7gw3QomHZA5i5())
								{
									continue;
								}
								goto case 9;
							case 9:
								if (SrEkcgs7JXcvO7D5Fh2I(undoRowOrColumnSizeAction))
								{
									h8iCbKs7ZxnuqE57hDP2();
									num3 = (dsaGVns7gw3QomHZA5i5() ? 6 : 8);
									continue;
								}
								goto end_IL_0109;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 10:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0109:
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
					continue;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
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
		internal static bool SrEkcgs7JXcvO7D5Fh2I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRowOrColumnSizeAction)P_0).CanDo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dsaGVns7gw3QomHZA5i5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h8iCbKs7ZxnuqE57hDP2()
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
	private struct _003CDoUnhideColumns_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange activeRange;

		public UndoHandler _003C_003E4__this;

		public int startColumn;

		public int endColumn;

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
			UndoRowOrColumnSizeAction undoRowOrColumnSizeAction = default;
			UndoHandler undoHandler = default;
			TaskAwaiter awaiter = default;
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
							undoRowOrColumnSizeAction = new UndoRowOrColumnSizeAction(activeRange, undoHandler.knCgT6fkuY, resizingRows: false, startColumn, endColumn, hide: false);
							num3 = 2;
							if (1 == 0)
							{
								goto IL_004a;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_00a4;
						IL_00a4:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 4:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 7:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								pFwKINs78X8CaMEv1eIa();
								if (tMe124s7zWHVJ40h09xY())
								{
									num3 = 1;
									continue;
								}
								num3 = 6;
								if (!tMe124s7zWHVJ40h09xY())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 2:
								if (G2Ps0AstwVqfBe6hulnu(undoRowOrColumnSizeAction))
								{
									num3 = 0;
									continue;
								}
								goto end_IL_0018;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
								return;
							case 10:
								goto IL_015c;
							}
							break;
						}
						goto IL_004a;
						IL_015c:
						awaiter.GetResult();
						goto end_IL_0018;
						IL_004a:
						awaiter = r5O5KastsNYvZXDcFHer(undoHandler.AddUndo(undoRowOrColumnSizeAction));
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							goto IL_00a4;
						}
						goto IL_015c;
						end_IL_0018:;
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
					undoHandler = _003C_003E4__this;
					pFwKINs78X8CaMEv1eIa();
					if (tMe124s7zWHVJ40h09xY())
					{
						num = 1;
						continue;
					}
					num = 4;
					if (pFwKINs78X8CaMEv1eIa())
					{
						continue;
					}
					goto case 5;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
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
		internal static bool G2Ps0AstwVqfBe6hulnu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRowOrColumnSizeAction)P_0).CanDo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter r5O5KastsNYvZXDcFHer(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pFwKINs78X8CaMEv1eIa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tMe124s7zWHVJ40h09xY()
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
	private struct _003CDoPropertySheetChange_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellLocation cell;

		public string expr;

		public string text;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!W2uldUsthmR02k48lpyi()) ? 4 : 2);
			int num2 = default;
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoHandler.AddUndo(new UndoPropertySheetAction(undoHandler.knCgT6fkuY, cell, expr, text)).GetAwaiter();
							_ = 0;
							num3 = ((!W2uldUsthmR02k48lpyi()) ? 8 : 2);
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
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 7;
								if (W2uldUsthmR02k48lpyi())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 8:
								return;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (true)
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
					goto case 5;
				default:
					num = 5;
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (W2uldUsthmR02k48lpyi())
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					undoHandler = _003C_003E4__this;
					num = 3;
					if (W2uldUsthmR02k48lpyi())
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static bool W2uldUsthmR02k48lpyi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RVnoAUstLG3E4v1IsCuN()
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
	private struct _003CDoScriptChange_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellLocation cell;

		public string expr;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!FRK7fkst9SE2lFETnqSC())
			{
				goto IL_001e;
			}
			goto IL_01a5;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 4;
			if (false)
			{
				goto IL_0031;
			}
			goto IL_01a5;
			IL_01a5:
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				default:
					goto IL_0031;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = C5tJxsstEbNxcXQsSyXn(undoHandler.AddUndo(new UndoScriptChangeAction(undoHandler.knCgT6fkuY, cell, expr)));
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (false)
							{
								goto IL_0136;
							}
						}
						goto IL_00aa;
						IL_0136:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_00aa;
						IL_00aa:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (FRK7fkst9SE2lFETnqSC())
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									if (!DDBIB5stSFXH0WSScGSU())
									{
										num3 = 7;
										if (1 == 0)
										{
											return;
										}
									}
									else
									{
										num3 = 4;
									}
									continue;
								}
								goto case 9;
							case 8:
								return;
							case 5:
								break;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 9:
								awaiter.GetResult();
								goto end_IL_00aa;
							}
							goto IL_0136;
							continue;
							end_IL_00aa:
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
					goto IL_0031;
				case 4:
					goto IL_01d6;
				case 6:
					return;
				}
				break;
				IL_01d6:
				undoHandler = _003C_003E4__this;
				_ = 0;
				num = (FRK7fkst9SE2lFETnqSC() ? 1 : 5);
			}
			goto IL_001e;
			IL_0031:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a5;
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
		internal static TaskAwaiter C5tJxsstEbNxcXQsSyXn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FRK7fkst9SE2lFETnqSC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DDBIB5stSFXH0WSScGSU()
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
	private struct _003CDoExpressionChange_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellLocation cell;

		public string expr;

		private TaskAwaiter _003C_003Eu__1;

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
			goto IL_0173;
			IL_001a:
			int num2 = default;
			UndoHandler undoHandler = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = undoHandler.AddUndo(new UndoExpressionAction(undoHandler.knCgT6fkuY, cell, expr)).GetAwaiter();
					num3 = 8;
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
						goto case 2;
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 7;
						continue;
					case 0:
					case 1:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						continue;
					case 8:
						if (awaiter.IsCompleted)
						{
							break;
						}
						_ = 0;
						if (!MaqMKustvkhFJ2HtSQE7())
						{
							num3 = 2;
							if (true)
							{
								continue;
							}
							goto case 5;
						}
						num3 = 0;
						continue;
					case 3:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						continue;
					case 2:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (true)
						{
							continue;
						}
						return;
					case 7:
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
			goto IL_01d2;
			IL_0173:
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
				case 3:
					goto IL_019e;
				case 1:
				case 4:
					undoHandler = _003C_003E4__this;
					break;
				case 0:
					goto IL_01d2;
				case 6:
					return;
				}
				break;
				IL_019e:
				num2 = _003C_003E1__state;
				_ = 1;
				num = (d2luGhstHOsnuqKYXuwt() ? 5 : 4);
			}
			goto IL_001a;
			IL_01d2:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (d2luGhstHOsnuqKYXuwt())
			{
			}
			goto IL_0173;
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
		internal static bool MaqMKustvkhFJ2HtSQE7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d2luGhstHOsnuqKYXuwt()
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
	private struct _003CDoInsertReferences_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsReferenceRange source;

		public CvsCellRange dest;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QqL3REstAEPX9jHCE8pi();
			int num;
			if (TOaNoastVZ9xZXplPohx())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_01e2;
				}
			}
			goto IL_018d;
			IL_018d:
			int num2 = default;
			UndoHandler undoHandler = default;
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
							awaiter = anFCcwstDXioZIhJRupm(undoHandler.AddUndo(new UndoInsertReferences(undoHandler.knCgT6fkuY, source, dest)));
							num3 = 0;
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
							case 4:
								return;
							case 3:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (QqL3REstAEPX9jHCE8pi())
									{
									}
									continue;
								}
								break;
							case 1:
								_003C_003Eu__1 = default;
								goto case 3;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								QqL3REstAEPX9jHCE8pi();
								num3 = (TOaNoastVZ9xZXplPohx() ? 7 : 3);
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
					break;
				default:
					num = 5;
					continue;
				case 1:
				case 3:
					undoHandler = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_01e2;
			IL_01e2:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_018d;
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
		internal static TaskAwaiter anFCcwstDXioZIhJRupm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TOaNoastVZ9xZXplPohx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QqL3REstAEPX9jHCE8pi()
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
	private struct _003CDoExpressionChange_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellLocation cell;

		public string expr;

		public string text;

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
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					if (b0pGr5stUZp0DGUfIrVi())
					{
						num = 3;
						continue;
					}
					num = 4;
					if (lrJYYMstTseCvAZvQYLy())
					{
					}
					continue;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoHandler.AddUndo(new UndoExpressionAction(undoHandler.knCgT6fkuY, cell, expr, text)).GetAwaiter();
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (b0pGr5stUZp0DGUfIrVi())
								{
									continue;
								}
								goto case 2;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 8:
								return;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = (b0pGr5stUZp0DGUfIrVi() ? 3 : 5);
									continue;
								}
								break;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 0;
								if (!lrJYYMstTseCvAZvQYLy())
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
					num = 0;
					continue;
				case 0:
					break;
				case 1:
				case 3:
					undoHandler = _003C_003E4__this;
					goto case 2;
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
		internal static bool b0pGr5stUZp0DGUfIrVi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lrJYYMstTseCvAZvQYLy()
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
	private struct _003CDoReferenceRedirect_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellLocation oldReference;

		public CvsCellLocation newReference;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoHandler.AddUndo(new UndoReferenceRedirectAction(undoHandler.knCgT6fkuY, oldReference, newReference)).GetAwaiter();
							num3 = 4;
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
							case 5:
								_003C_003Eu__1 = default;
								goto case 0;
							case 0:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (jlTicwstdqH3vk0e2nDe())
								{
									continue;
								}
								return;
							case 7:
								return;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (p5wnRlsti5NF0dJkL5ll())
								{
								}
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								p5wnRlsti5NF0dJkL5ll();
								if (!jlTicwstdqH3vk0e2nDe())
								{
									num3 = 0;
									if (jlTicwstdqH3vk0e2nDe())
									{
										continue;
									}
									goto case 0;
								}
								num3 = 2;
								continue;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
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
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					undoHandler = _003C_003E4__this;
					_ = 0;
					num = (jlTicwstdqH3vk0e2nDe() ? 5 : 4);
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
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
		internal static bool jlTicwstdqH3vk0e2nDe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p5wnRlsti5NF0dJkL5ll()
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
	private struct _003CDoAutoFitRows_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange activeRange;

		public CvsCellRange cellRange;

		public int[] heights;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_01b3;
			IL_001a:
			UndoHandler undoHandler = _003C_003E4__this;
			num = 2;
			goto IL_01b3;
			IL_01b3:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = IqCdTOstjQaeRhVDoAX7(undoHandler.AddUndo(new UndoAutoFitRowAction(activeRange, undoHandler.knCgT6fkuY, cellRange, heights)));
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (!zQvLiFstqJJLVPDmdg32())
							{
								goto IL_00c0;
							}
						}
						goto IL_0106;
						IL_0173:
						awaiter.GetResult();
						goto end_IL_0042;
						IL_0162:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						goto IL_0106;
						IL_0106:
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								return;
							case 8:
								break;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (zQvLiFstqJJLVPDmdg32())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								goto IL_0162;
							case 2:
							case 4:
								goto IL_0162;
							case 9:
								goto IL_0173;
							}
							break;
						}
						goto IL_00c0;
						IL_00c0:
						if (!awaiter.IsCompleted)
						{
							zQvLiFstqJJLVPDmdg32();
							if (!qCk06fstBKZvgV7C2R7G())
							{
								num3 = 3;
							}
							else
							{
								num3 = 4;
								if (!zQvLiFstqJJLVPDmdg32())
								{
									goto IL_0162;
								}
							}
							goto IL_0106;
						}
						goto IL_0173;
						end_IL_0042:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!qCk06fstBKZvgV7C2R7G()) ? 5 : 0);
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static TaskAwaiter IqCdTOstjQaeRhVDoAX7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zQvLiFstqJJLVPDmdg32()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qCk06fstBKZvgV7C2R7G()
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
	private struct _003CDoAutoFitColumns_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange activeRange;

		public CvsCellRange cellRange;

		public int[] widths;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CsAfMOst2Akx6HBsroJg();
			int num;
			if (csOiflstcN1YislpmP8b())
			{
				num = 2;
				if (!csOiflstcN1YislpmP8b())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0189;
			IL_01cb:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0189;
			IL_0189:
			UndoHandler undoHandler = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 4:
					undoHandler = _003C_003E4__this;
					num = 1;
					continue;
				default:
					goto IL_01cb;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
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
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = HuUjHMstWXetgRlACsL1(undoHandler.AddUndo(new UndoAutoFitColumnAction(activeRange, undoHandler.knCgT6fkuY, cellRange, widths)));
					num3 = 8;
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
					case 5:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 0:
					case 4:
						return;
					case 1:
						_003C_003Eu__1 = default;
						goto case 5;
					case 2:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						continue;
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto default;
					default:
						_ = 0;
						num3 = ((!csOiflstcN1YislpmP8b()) ? 5 : 0);
						continue;
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							continue;
						}
						break;
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
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
			goto IL_01cb;
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
		internal static TaskAwaiter HuUjHMstWXetgRlACsL1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool csOiflstcN1YislpmP8b()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CsAfMOst2Akx6HBsroJg()
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
	private struct _003CDoGraphicChange_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCogEditInfo editInfo;

		public CvsCogEditingShape originalShape;

		public CvsCogShape editedShape;

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
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = IOtRCBstCxx5FGEfJ9PN(undoHandler.AddUndo(new UndoGraphicAction(undoHandler.knCgT6fkuY, editInfo, originalShape, editedShape)));
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (1 == 0)
							{
								goto IL_008f;
							}
						}
						goto IL_00c0;
						IL_008f:
						_003C_003Eu__1 = awaiter;
						num3 = 4;
						goto IL_00c0;
						IL_00c0:
						while (true)
						{
							switch (num3)
							{
							case 7:
								return;
							case 2:
							case 5:
								break;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								break;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									num3 = ((!dUaT2gsttRhSU0wjOHo0()) ? 6 : 5);
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_00c0;
							}
							goto IL_008f;
							continue;
							end_IL_00c0:
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
					goto default;
				case 1:
					undoHandler = _003C_003E4__this;
					_ = 1;
					num = ((!dUaT2gsttRhSU0wjOHo0()) ? 4 : 5);
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
		internal static TaskAwaiter IOtRCBstCxx5FGEfJ9PN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BbiE5ist7gF9phkwkCZP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dUaT2gsttRhSU0wjOHo0()
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
	private struct _003CDoCellState_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		public string state;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_01a8;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a8;
			IL_01a8:
			int num2 = default;
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoHandler.AddUndo(new UndoCellStateAction(undoHandler.knCgT6fkuY, cellRange, state)).GetAwaiter();
							num3 = 0;
							if (hAw8HBst5Fl4FaWZJ20K())
							{
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								_003C_003Eu__1 = default;
								goto case 1;
							case 5:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								if (hAw8HBst5Fl4FaWZJ20K())
								{
								}
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (!OIjntJstKRn2XoxJGcpg())
								{
									num3 = 1;
									continue;
								}
								num3 = 8;
								if (hAw8HBst5Fl4FaWZJ20K())
								{
								}
								continue;
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (OIjntJstKRn2XoxJGcpg())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
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
					break;
				default:
					num = 5;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!hAw8HBst5Fl4FaWZJ20K()) ? 3 : 0);
					continue;
				case 1:
				case 3:
					undoHandler = _003C_003E4__this;
					goto case 0;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static bool OIjntJstKRn2XoxJGcpg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hAw8HBst5Fl4FaWZJ20K()
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
	private struct _003CDoCellNameEditor_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellInfoCollection originalInfoCollection;

		public CvsCellInfoCollection newInfoCollection;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_019a;
			IL_01de:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_019a;
			IL_019a:
			UndoHandler undoHandler = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 2:
				case 4:
					goto IL_0041;
				default:
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					undoHandler = _003C_003E4__this;
					goto IL_0041;
				case 0:
					goto IL_01de;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0041:
			int num2 = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = VC8iDIstYSrjSfvi5TAm(undoHandler.AddUndo(new UndoCellInfoAction(undoHandler.knCgT6fkuY, originalInfoCollection, newInfoCollection)));
					num3 = 1;
					if (false)
					{
						goto IL_0076;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 8;
				}
				goto IL_00c5;
				IL_00c5:
				while (true)
				{
					switch (num3)
					{
					case 2:
					case 6:
						break;
					case 8:
						_003C_003Eu__1 = default;
						break;
					case 3:
					case 4:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 7;
						continue;
					case 0:
						num2 = (_003C_003E1__state = 0);
						num3 = 5;
						continue;
					case 7:
						return;
					case 1:
						if (!awaiter.IsCompleted)
						{
							num3 = 0;
							continue;
						}
						goto case 9;
					case 5:
						_003C_003Eu__1 = awaiter;
						_ = 0;
						if (!vWlV7Ustoqi8NQamjpit())
						{
							num3 = 2;
							continue;
						}
						num3 = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 9;
					case 9:
						awaiter.GetResult();
						goto end_IL_00c5;
					}
					goto IL_0076;
					continue;
					end_IL_00c5:
					break;
				}
				goto end_IL_0041;
				IL_0076:
				num2 = (_003C_003E1__state = -1);
				num3 = 9;
				goto IL_00c5;
				end_IL_0041:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01de;
			IL_001a:
			num2 = _003C_003E1__state;
			nq7CRZstPgjLFVd0v94h();
			if (vWlV7Ustoqi8NQamjpit())
			{
				num = 3;
				if (nq7CRZstPgjLFVd0v94h())
				{
					goto IL_0041;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_019a;
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
		internal static TaskAwaiter VC8iDIstYSrjSfvi5TAm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vWlV7Ustoqi8NQamjpit()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nq7CRZstPgjLFVd0v94h()
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
	private struct _003CDoInsertComment_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCell cell;

		public UndoHandler _003C_003E4__this;

		public CvsCellComment comment;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			UndoHandler undoHandler = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_01e4:
				switch (num)
				{
				case 4:
					undoHandler = _003C_003E4__this;
					cegg0Tstxps9gtjdrqG5();
					if (cFGsdwstNIJA08qrJfkf())
					{
						num = 0;
						goto IL_01e4;
					}
					num = 5;
					if (cFGsdwstNIJA08qrJfkf())
					{
						goto IL_01e4;
					}
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					goto IL_01e4;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (!cegg0Tstxps9gtjdrqG5())
							{
								goto IL_00b6;
							}
							goto IL_01a4;
						}
						if (!S49f9Vst1T7vT4F7LHXy(cell))
						{
							num3 = 4;
							goto IL_00b6;
						}
						goto end_IL_004a;
						IL_00b6:
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 4:
								awaiter = SPD68jstMSn3XHM8WaeB(undoHandler.AddUndo(new UndoCellCommentsAction(undoHandler.knCgT6fkuY, (CvsCogCellResult)ESs7fdstrihKpnalx9iw(cell), comment, (string)LPDQ55stO1iNCwRrx0LV(Ks4MJjst36KFaXSN7ZvG(), cell.Location))));
								_ = 1;
								num3 = ((!cegg0Tstxps9gtjdrqG5()) ? 7 : 5);
								continue;
							case 1:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								break;
							case 6:
								return;
							case 10:
								break;
							}
							break;
						}
						goto IL_01a4;
						IL_01a4:
						awaiter.GetResult();
						end_IL_004a:;
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
			while (0 == 0);
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
		internal static bool S49f9Vst1T7vT4F7LHXy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCell.IsNullOrEmpty((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ESs7fdstrihKpnalx9iw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellResult;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ks4MJjst36KFaXSN7ZvG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.UndoHandlerInsertComments;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LPDQ55stO1iNCwRrx0LV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter SPD68jstMSn3XHM8WaeB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cFGsdwstNIJA08qrJfkf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cegg0Tstxps9gtjdrqG5()
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
	private struct _003CDoFormatCells_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<CvsCellFormat> cellFormats;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange cellRange;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ywN6CcstQHgGv6yOPTYF();
			int num;
			if (!D1hObsstlMfReFcyQKnA())
			{
				num = 1;
				if (!ywN6CcstQHgGv6yOPTYF())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_0212;
			IL_002e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0212;
			IL_0212:
			UndoHandler undoHandler = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					undoHandler = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							goto IL_00cf;
						}
						if (cellFormats == null)
						{
							num3 = 6;
							goto IL_00cf;
						}
						if (FEF1GastexB3VijYUDph(cellFormats) > 0)
						{
							num3 = 8;
							if (D1hObsstlMfReFcyQKnA())
							{
							}
							goto IL_00cf;
						}
						goto end_IL_0054;
						IL_00cf:
						while (true)
						{
							IL_00cf_2:
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = default;
								goto case 0;
							case 4:
								while (true)
								{
									num2 = (_003C_003E1__state = 0);
									D1hObsstlMfReFcyQKnA();
									if (ywN6CcstQHgGv6yOPTYF())
									{
										break;
									}
									num3 = 0;
									if (1 == 0)
									{
										continue;
									}
									goto IL_00cf_2;
								}
								num3 = 9;
								if (ywN6CcstQHgGv6yOPTYF())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								awaiter = hQdKC0stRoOkRk75xh6f(undoHandler.AddUndo(new UndoCellStyleAction(undoHandler.knCgT6fkuY, cellRange, cellFormats, (string)lGlwyastIXlM87GFTwrx(OiUTiSstub5jCMgGjMyG(), cellRange))));
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 5:
								return;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								if (!D1hObsstlMfReFcyQKnA())
								{
									continue;
								}
								goto case 6;
							case 6:
								throw new ArgumentNullException();
							case 0:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (!D1hObsstlMfReFcyQKnA())
								{
									continue;
								}
								break;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
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
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
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
		internal static int FEF1GastexB3VijYUDph(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<CvsCellFormat>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OiUTiSstub5jCMgGjMyG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.UndoHandlerFormatCells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lGlwyastIXlM87GFTwrx(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter hQdKC0stRoOkRk75xh6f(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ywN6CcstQHgGv6yOPTYF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D1hObsstlMfReFcyQKnA()
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
	private struct _003CSendCutAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange selected;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			UndoHandler undoHandler = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)FwERGJstXSrYVD157Wd2(MexotwstGJwXpDbyTjdv(undoHandler.knCgT6fkuY))).CopyCellsAsync(selected).GetAwaiter();
							num3 = 8;
							if (1 == 0)
							{
								return;
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
							case 5:
								return;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!miyou6staevoCva967ft()) ? 2 : 0);
									continue;
								}
								break;
							case 0:
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								goto case 2;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
					continue;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 1:
				case 4:
					undoHandler = _003C_003E4__this;
					goto case 2;
				case 0:
					break;
				case 6:
					return;
				}
				do
				{
					num2 = _003C_003E1__state;
					miyou6staevoCva967ft();
					if (FrxjKMstn21VPQ8N8rWT())
					{
						num = 3;
						continue;
					}
					num = 4;
					if (true)
					{
						break;
					}
					return;
				}
				while (false);
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
		internal static object MexotwstGJwXpDbyTjdv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FwERGJstXSrYVD157Wd2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool miyou6staevoCva967ft()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FrxjKMstn21VPQ8N8rWT()
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
	private struct _003CSendCopyAsync_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange selected;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (GOmQovstbAcMdOqnMPQG())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
				if (k3dFwsst6UKg7PMyFW5K())
				{
					return;
				}
			}
			goto IL_018a;
			IL_01c6:
			byte[] result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_018a;
			IL_018a:
			UndoHandler undoHandler = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					num = 4;
					continue;
				case 1:
				case 3:
					undoHandler = _003C_003E4__this;
					num = 5;
					continue;
				case 4:
					goto IL_01c6;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				TaskAwaiter<byte[]> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((CvsCogSocket)U5QvLKstpRfDXdWIWXEh(undoHandler.knCgT6fkuY)).Sheet.CopyCellsAsync(selected).GetAwaiter();
					_ = 0;
					if (GOmQovstbAcMdOqnMPQG())
					{
						num3 = 8;
						if (1 == 0)
						{
							goto IL_0065;
						}
					}
					else
					{
						num3 = 7;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 4;
				}
				goto IL_00b4;
				IL_007e:
				if (!awaiter.IsCompleted)
				{
					num3 = 6;
					goto IL_00b4;
				}
				goto IL_0147;
				IL_0065:
				num2 = (_003C_003E1__state = -1);
				num3 = 9;
				if (!GOmQovstbAcMdOqnMPQG())
				{
					goto IL_007e;
				}
				goto IL_00b4;
				IL_00b4:
				while (true)
				{
					switch (num3)
					{
					case 5:
						break;
					case 0:
					case 8:
						goto IL_007e;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 1;
						if (true)
						{
							continue;
						}
						goto case 4;
					case 4:
						_003C_003Eu__1 = default;
						num3 = 5;
						if (true)
						{
							continue;
						}
						goto case 2;
					case 2:
					case 7:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						if (0 == 0)
						{
							continue;
						}
						goto case 6;
					case 6:
						num2 = (_003C_003E1__state = 0);
						goto case 2;
					case 1:
						return;
					case 9:
						goto IL_0147;
					}
					break;
				}
				goto IL_0065;
				IL_0147:
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01c6;
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
		internal static object U5QvLKstpRfDXdWIWXEh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GOmQovstbAcMdOqnMPQG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k3dFwsst6UKg7PMyFW5K()
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
	private struct _003CSendInsertCellsAsync_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange selected;

		public UndoHandler _003C_003E4__this;

		public ShiftCells shift;

		private int[] _003Cheights_003E5__2;

		private CvsCellRange _003CcutRegion_003E5__3;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			c1ZAXNst0Tn5khSGlQYJ();
			int num;
			if (!Co8yrEst4NLT2BdfnNQI())
			{
				num = 1;
			}
			else
			{
				num = 2;
				if (Co8yrEst4NLT2BdfnNQI())
				{
					goto IL_0bfa;
				}
			}
			goto IL_0bc3;
			IL_0c24:
			UndoHandler undoHandler = _003C_003E4__this;
			num = 4;
			goto IL_0bc3;
			IL_0bfa:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (0 == 0)
			{
				goto IL_0bc3;
			}
			goto IL_0c11;
			IL_0bc3:
			int num2 = default;
			switch (num)
			{
			case 4:
				try
				{
					bool flag3 = default;
					int num3;
					TaskAwaiter awaiter2 = default;
					TaskAwaiter<byte[]> awaiter = default;
					ShiftCells shiftCells = default;
					int num5 = default;
					int num9 = default;
					int num10 = default;
					int num8 = default;
					int i = default;
					int num4 = default;
					byte[] result2 = default;
					int num7 = default;
					int num6 = default;
					byte[] result = default;
					switch (num2)
					{
					default:
					{
						bool flag = selected.Columns == ((CvsProcessorConstants)UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)).SpreadsheetColumns;
						bool flag2 = selected.Rows == JRhV0WstfcQctdBRUBB4(UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY));
						if (flag & flag2)
						{
							throw new CvsInvalidInsertException(selected.Location);
						}
						flag3 = false;
						if (flag)
						{
							num3 = 55;
						}
						else
						{
							if (!flag2)
							{
								goto IL_08c8;
							}
							num3 = 3;
						}
						goto IL_020f;
					}
					case 3:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default;
						num3 = 21;
						goto IL_020f;
					case 1:
						awaiter2 = _003C_003Eu__2;
						num3 = 46;
						goto IL_020f;
					case 0:
						awaiter = _003C_003Eu__1;
						num3 = 5;
						if (c1ZAXNst0Tn5khSGlQYJ())
						{
							goto IL_020f;
						}
						goto IL_03ec;
					case 2:
						{
							awaiter = _003C_003Eu__1;
							num3 = 53;
							if (true)
							{
								goto IL_020f;
							}
							goto IL_08b2;
						}
						IL_08c8:
						shiftCells = shift;
						num3 = 16;
						if (0 == 0)
						{
							goto IL_020f;
						}
						goto IL_08dc;
						IL_020f:
						while (true)
						{
							switch (num3)
							{
							case 66:
								undoHandler.knCgT6fkuY.SheetInfo.SetRowHeights(((CvsProcessorConstants)UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)).SpreadsheetRange, _003Cheights_003E5__2);
								goto IL_00ca;
							case 45:
								num2 = (_003C_003E1__state = 2);
								num3 = 50;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 45;
									continue;
								}
								goto case 25;
							case 69:
								num5++;
								goto case 4;
							case 4:
								if (num5 > selected.LastColumn)
								{
									num3 = 24;
									continue;
								}
								_003Cheights_003E5__2[num5] = 64;
								num3 = 69;
								continue;
							case 68:
								selected.Rows = JRhV0WstfcQctdBRUBB4(UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY));
								goto IL_07b1;
							case 43:
								return;
							case 63:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto IL_01bf;
							case 19:
								num9 = _003Cheights_003E5__2.Length - 1;
								goto case 37;
							case 26:
								num10 = selected.Row;
								goto case 12;
							default:
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 51;
							case 51:
								num9--;
								num3 = 44;
								if (0 == 0)
								{
									continue;
								}
								goto case 37;
							case 23:
							case 58:
								num2 = (_003C_003E1__state = 1);
								num3 = 20;
								continue;
							case 12:
							case 64:
								if (num10 > selected.LastRow)
								{
									num3 = 66;
									continue;
								}
								_003Cheights_003E5__2[num10] = 20;
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 36;
							case 27:
								if (_003CcutRegion_003E5__3.Columns > 0)
								{
									num3 = 2;
									if (!Co8yrEst4NLT2BdfnNQI())
									{
										continue;
									}
									return;
								}
								goto case 54;
							case 62:
								return;
							case 65:
								break;
							case 20:
								_003C_003Eu__2 = awaiter2;
								num3 = 57;
								if (0 == 0)
								{
									continue;
								}
								goto case 53;
							case 53:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 25;
								if (Co8yrEst4NLT2BdfnNQI())
								{
								}
								continue;
							case 33:
								awaiter2.GetResult();
								num3 = 31;
								continue;
							case 56:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 62;
								continue;
							case 50:
								_003C_003Eu__1 = awaiter;
								num3 = 13;
								continue;
							case 31:
								if (shift == ShiftCells.EntireColumn)
								{
									num3 = 19;
									if (0 == 0)
									{
										continue;
									}
									goto case 29;
								}
								goto case 54;
							case 29:
								num8++;
								num3 = 28;
								if (c1ZAXNst0Tn5khSGlQYJ())
								{
									continue;
								}
								goto case 57;
							case 57:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 63;
								continue;
							case 30:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 43;
								if (!Co8yrEst4NLT2BdfnNQI())
								{
									continue;
								}
								goto case 16;
							case 16:
								switch (shiftCells)
								{
								case ShiftCells.Horizontally:
									flag3 = false;
									goto IL_07b1;
								case ShiftCells.Vertically:
									break;
								case ShiftCells.EntireRow:
									goto IL_0522;
								case ShiftCells.EntireColumn:
									goto IL_070e;
								default:
									goto IL_07b1;
								}
								flag3 = true;
								num3 = 41;
								continue;
							case 38:
								goto IL_0577;
							case 28:
							case 40:
								if (num8 < JRhV0WstfcQctdBRUBB4(UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)))
								{
									i = selected.Column;
									num3 = 38;
									continue;
								}
								num3 = 59;
								if (true)
								{
									continue;
								}
								goto case 15;
							case 15:
								_003Cheights_003E5__2 = ((CvsSheetInfo)obc5cnstgFr12sQn0QbL(undoHandler.knCgT6fkuY)).GetColumnWidths(((CvsProcessorConstants)UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)).SpreadsheetRange);
								num3 = 47;
								if (c1ZAXNst0Tn5khSGlQYJ())
								{
									continue;
								}
								goto case 49;
							case 49:
								if (shift != ShiftCells.EntireRow)
								{
									goto IL_00ca;
								}
								num4 = _003Cheights_003E5__2.Length - 1;
								num3 = 42;
								if (0 == 0)
								{
									continue;
								}
								goto case 25;
							case 25:
								result2 = awaiter.GetResult();
								num3 = 48;
								continue;
							case 37:
							case 44:
							case 61:
								if (num9 > selected.LastColumn)
								{
									_003Cheights_003E5__2[num9] = _003Cheights_003E5__2[num9 - selected.Columns];
									num3 = 51;
								}
								else
								{
									num3 = 8;
								}
								continue;
							case 59:
								_003Cheights_003E5__2 = null;
								num3 = 34;
								continue;
							case 70:
								num2 = (_003C_003E1__state = -1);
								num3 = 65;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter = undoHandler.SendCutAsync(_003CcutRegion_003E5__3).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 56;
									continue;
								}
								goto IL_01bf;
							case 14:
								if (awaiter2.IsCompleted)
								{
									break;
								}
								_ = 0;
								if (!c1ZAXNst0Tn5khSGlQYJ())
								{
									num3 = 37;
									if (true)
									{
										continue;
									}
									goto case 26;
								}
								num3 = 58;
								continue;
							case 11:
								throw new CvsInvalidInsertException(new CvsCellLocation(num7, num6));
							case 36:
								while (num7 <= selected.LastRow)
								{
									if (N4HJL5sCwoQGCMS4jFYO(((CvsCellCollection)LlK8fjstmEVYJ6pCmaiG(undoHandler.knCgT6fkuY.Results)).GetCell(num7, num6)))
									{
										num7++;
										continue;
									}
									goto IL_0667;
								}
								num6++;
								goto case 52;
							case 52:
								if (num6 >= GoxeGPsCsTkTGGMGqAJP(UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)))
								{
									_003Cheights_003E5__2 = null;
									if (shift == ShiftCells.EntireColumn)
									{
										num3 = 15;
										if (true)
										{
											continue;
										}
										goto IL_07b1;
									}
									goto case 47;
								}
								num7 = selected.Row;
								num3 = 36;
								continue;
							case 32:
							case 41:
								goto IL_07b1;
							case 2:
								awaiter = undoHandler.SendCutAsync(_003CcutRegion_003E5__3).GetAwaiter();
								num3 = 9;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 60:
								awaiter2 = ((Task)HNtoFCst8VwJ6oo8O5VT(undoHandler.knCgT6fkuY, _003CcutRegion_003E5__3, result2, true, false)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__2 = awaiter2;
									num3 = 30;
									continue;
								}
								goto case 33;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
								goto IL_08b2;
							case 35:
								goto IL_08c8;
							case 17:
								goto IL_08dc;
							case 24:
								((CvsSheetInfo)obc5cnstgFr12sQn0QbL(undoHandler.knCgT6fkuY)).SetColumnWidths(BJYJlbstZobVHL5j3tSy(UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)), _003Cheights_003E5__2);
								num3 = 54;
								continue;
							case 7:
								_003CcutRegion_003E5__3.Columns = GoxeGPsCsTkTGGMGqAJP(UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)) - _003CcutRegion_003E5__3.Column - _003CcutRegion_003E5__3.Columns;
								num3 = 27;
								if (c1ZAXNst0Tn5khSGlQYJ())
								{
									continue;
								}
								goto case 18;
							case 18:
							case 42:
								if (num4 > selected.LastRow)
								{
									_003Cheights_003E5__2[num4] = _003Cheights_003E5__2[num4 - selected.Rows];
									num3 = 22;
								}
								else
								{
									num3 = 26;
								}
								continue;
							case 55:
								shift = ShiftCells.EntireRow;
								goto IL_08c8;
							case 48:
								_003CcutRegion_003E5__3.Column += selected.Columns;
								num3 = 60;
								continue;
							case 47:
								_003CcutRegion_003E5__3 = new CvsCellRange(selected.Location, selected.Size);
								num3 = 7;
								continue;
							case 0:
								_003CcutRegion_003E5__3.Row += selected.Rows;
								awaiter2 = USMkFIstzEnCx7uLbkyC(HNtoFCst8VwJ6oo8O5VT(undoHandler.knCgT6fkuY, _003CcutRegion_003E5__3, result, true, false));
								num3 = 14;
								continue;
							case 46:
								_003C_003Eu__2 = default;
								num3 = 70;
								continue;
							case 21:
								num2 = (_003C_003E1__state = -1);
								num3 = 33;
								if (0 == 0)
								{
									continue;
								}
								goto case 54;
							case 54:
								_003Cheights_003E5__2 = null;
								num3 = 71;
								continue;
							case 67:
								selected.Columns = ((CvsProcessorConstants)UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)).SpreadsheetColumns;
								num3 = 32;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								num5 = selected.Column;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								shift = ShiftCells.EntireColumn;
								num3 = 35;
								continue;
							case 34:
								if (shift == ShiftCells.EntireRow)
								{
									_003Cheights_003E5__2 = (int[])DdIcDFstJuwAyekFf5VK(obc5cnstgFr12sQn0QbL(undoHandler.knCgT6fkuY), BJYJlbstZobVHL5j3tSy(UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)));
									num3 = 17;
									continue;
								}
								goto IL_08dc;
							case 39:
								_003CcutRegion_003E5__3.Rows = ((CvsProcessorConstants)UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)).SpreadsheetRows - _003CcutRegion_003E5__3.Row - _003CcutRegion_003E5__3.Rows;
								if (_003CcutRegion_003E5__3.Rows > 0)
								{
									num3 = 10;
									continue;
								}
								goto IL_00ca;
							case 22:
								num4--;
								num3 = 18;
								if (0 == 0)
								{
									continue;
								}
								goto case 71;
							case 71:
								{
									((CvsCogSocketSheet)ABNPeJsCLb4T5ZZarWyA(hn7AppsChKOeq6g5dvsZ(undoHandler.knCgT6fkuY))).Run(true);
									goto end_IL_0029;
								}
								IL_00ca:
								_003Cheights_003E5__2 = null;
								goto case 71;
								IL_0667:
								num3 = 11;
								continue;
								IL_070e:
								flag3 = false;
								selected.Row = 0;
								num3 = 68;
								if (!Co8yrEst4NLT2BdfnNQI())
								{
									continue;
								}
								goto case 14;
								IL_01bf:
								result = awaiter.GetResult();
								num3 = 0;
								continue;
								IL_0522:
								flag3 = true;
								selected.Column = 0;
								num3 = 67;
								continue;
								IL_07b1:
								if (!flag3)
								{
									num6 = ((CvsProcessorConstants)UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)).SpreadsheetColumns - selected.Columns;
									num3 = 52;
								}
								else
								{
									num8 = JRhV0WstfcQctdBRUBB4(UyBR97stkHb9gGEDvceM(undoHandler.knCgT6fkuY)) - selected.Rows;
									num3 = 40;
								}
								continue;
							}
							break;
							IL_0577:
							for (; i <= selected.LastColumn; i++)
							{
								if (!CvsCell.IsNullOrEmpty((CvsCell)Pp8CwmstynTBTRHsZv6I(LlK8fjstmEVYJ6pCmaiG(vcMFEFstFSQdvCjgPu9j(undoHandler.knCgT6fkuY)), num8, i)))
								{
									throw new CvsInvalidInsertException(new CvsCellLocation(num8, i));
								}
							}
							num3 = 29;
						}
						goto IL_03ec;
						IL_08dc:
						_003CcutRegion_003E5__3 = new CvsCellRange(selected.Location, selected.Size);
						num3 = 39;
						goto IL_020f;
						IL_08b2:
						num10++;
						num3 = 64;
						if (c1ZAXNst0Tn5khSGlQYJ())
						{
							goto IL_020f;
						}
						goto IL_08c8;
						IL_03ec:
						awaiter2.GetResult();
						num3 = 49;
						goto IL_020f;
						end_IL_0029:
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
			case 0:
			case 1:
				goto IL_0c11;
			case 5:
				goto IL_0c24;
			case 6:
				return;
			}
			goto IL_0bfa;
			IL_0c11:
			num2 = _003C_003E1__state;
			num = 5;
			if (0 == 0)
			{
				goto IL_0bc3;
			}
			goto IL_0c24;
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
		internal static object UyBR97stkHb9gGEDvceM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int JRhV0WstfcQctdBRUBB4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).SpreadsheetRows;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vcMFEFstFSQdvCjgPu9j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LlK8fjstmEVYJ6pCmaiG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Pp8CwmstynTBTRHsZv6I(object P_0, int row, int column)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetCell(row, column);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object obc5cnstgFr12sQn0QbL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange BJYJlbstZobVHL5j3tSy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).SpreadsheetRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DdIcDFstJuwAyekFf5VK(object P_0, CvsCellRange activeRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).GetRowHeights(activeRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HNtoFCst8VwJ6oo8O5VT(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter USMkFIstzEnCx7uLbkyC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N4HJL5sCwoQGCMS4jFYO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCell.IsNullOrEmpty((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int GoxeGPsCsTkTGGMGqAJP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).SpreadsheetColumns;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hn7AppsChKOeq6g5dvsZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ABNPeJsCLb4T5ZZarWyA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c1ZAXNst0Tn5khSGlQYJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Co8yrEst4NLT2BdfnNQI()
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
	private struct _003CSendRemoveCellsAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoHandler _003C_003E4__this;

		public CvsCellRange selected;

		public ShiftCells shift;

		private int[] _003Cheights_003E5__2;

		private CvsCellRange _003CcutRegion_003E5__3;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (qIZrEVsCS7i9XMG27Bp5() ? 1 : 2);
			UndoHandler undoHandler = default;
			int num2 = default;
			TaskAwaiter<byte[]> awaiter2 = default;
			TaskAwaiter awaiter = default;
			int num6 = default;
			int num5 = default;
			ShiftCells shiftCells = default;
			bool flag = default;
			bool flag2 = default;
			int num7 = default;
			bool flag3 = default;
			byte[] result2 = default;
			byte[] result = default;
			int num4 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					undoHandler = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							A0nPlDsCv4T4fWEb94tg(((CvsCogSocket)vN4uSTsCEuGrs8gOriY4(undoHandler.knCgT6fkuY)).Sheet, selected);
							num3 = 9;
							goto IL_06cd;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 37;
							goto IL_06cd;
						case 1:
							awaiter = _003C_003Eu__2;
							num3 = 53;
							goto IL_06cd;
						case 2:
							awaiter2 = _003C_003Eu__1;
							num3 = 33;
							if (!JwOwnqsC9mP2WbbUVBJA())
							{
								goto IL_0697;
							}
							goto IL_06cd;
						case 3:
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_09e3;
							}
							IL_06cd:
							while (true)
							{
								switch (num3)
								{
								case 57:
									_003CcutRegion_003E5__3.Row -= selected.Rows;
									num3 = 12;
									continue;
								case 14:
									num6 = selected.Row;
									num3 = 49;
									continue;
								case 64:
									_003CcutRegion_003E5__3.Row += selected.Rows;
									num3 = 26;
									continue;
								case 56:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 63:
									_003CcutRegion_003E5__3.Columns = ((CvsProcessorConstants)S2sRpSsCV9OGIN27QLir(undoHandler.knCgT6fkuY)).SpreadsheetColumns - _003CcutRegion_003E5__3.Column;
									num3 = 50;
									if (JwOwnqsC9mP2WbbUVBJA())
									{
										continue;
									}
									break;
								case 43:
									break;
								case 30:
									return;
								case 58:
									num5 = _003Cheights_003E5__2.Length - selected.Columns;
									num3 = 0;
									continue;
								case 54:
									goto IL_01a9;
								case 45:
									return;
								case 21:
									selected.Row = 0;
									num3 = 35;
									if (qIZrEVsCS7i9XMG27Bp5())
									{
									}
									continue;
								case 4:
									goto IL_0231;
								case 44:
									goto IL_0249;
								case 3:
								case 34:
								case 36:
									shiftCells = shift;
									num3 = 54;
									if (!qIZrEVsCS7i9XMG27Bp5())
									{
										continue;
									}
									goto case 0;
								case 15:
									if (!awaiter.IsCompleted)
									{
										num3 = 13;
										continue;
									}
									goto case 61;
								case 38:
									num5++;
									goto case 0;
								case 0:
									if (num5 < _003Cheights_003E5__2.Length)
									{
										_003Cheights_003E5__2[num5] = 64;
										num3 = 38;
									}
									else
									{
										Ht7uYEsCjZnjabBskbti(undoHandler.knCgT6fkuY.SheetInfo, bZHJPcsCUqyL017OCBqD(undoHandler.knCgT6fkuY.ProcessorConstants), _003Cheights_003E5__2);
										num3 = 28;
									}
									continue;
								case 26:
									_003CcutRegion_003E5__3.Rows = dpWuOusCA7isghaInanR(S2sRpSsCV9OGIN27QLir(undoHandler.knCgT6fkuY)) - _003CcutRegion_003E5__3.Row;
									num3 = 17;
									continue;
								case 60:
									if (flag)
									{
										shift = ShiftCells.EntireRow;
										_ = 0;
										if (JwOwnqsC9mP2WbbUVBJA())
										{
											num3 = 34;
											if (!qIZrEVsCS7i9XMG27Bp5())
											{
												continue;
											}
											goto case 8;
										}
										num3 = 59;
										continue;
									}
									if (flag2)
									{
										shift = ShiftCells.EntireColumn;
										num3 = 36;
										continue;
									}
									goto case 3;
								case 8:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									num3 = 56;
									continue;
								case 33:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_03b3;
								case 37:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 42;
									if (JwOwnqsC9mP2WbbUVBJA())
									{
										continue;
									}
									goto case 16;
								case 16:
									_003Cheights_003E5__2 = (int[])EBRdQKsCT11nNCOUut42(fmsnxJsCDIugVUltXN8N(undoHandler.knCgT6fkuY), bZHJPcsCUqyL017OCBqD(S2sRpSsCV9OGIN27QLir(undoHandler.knCgT6fkuY)));
									num3 = 22;
									continue;
								case 19:
									_003Cheights_003E5__2 = (int[])zHvQstsCqKdplMYmir0n(fmsnxJsCDIugVUltXN8N(undoHandler.knCgT6fkuY), bZHJPcsCUqyL017OCBqD(S2sRpSsCV9OGIN27QLir(undoHandler.knCgT6fkuY)));
									num3 = 43;
									if (true)
									{
										continue;
									}
									goto case 25;
								case 25:
									num7 = selected.Column;
									goto case 6;
								case 2:
									flag2 = selected.Rows == dpWuOusCA7isghaInanR(S2sRpSsCV9OGIN27QLir(undoHandler.knCgT6fkuY));
									if (!(flag & flag2))
									{
										flag3 = false;
										num3 = 60;
										continue;
									}
									goto end_IL_0038;
								case 29:
									num7++;
									num3 = 6;
									continue;
								case 31:
									_003CcutRegion_003E5__3.Column += selected.Columns;
									num3 = 63;
									if (true)
									{
										continue;
									}
									goto case 51;
								case 51:
								case 59:
									_003CcutRegion_003E5__3.Column -= selected.Columns;
									awaiter = WYltPjsCBj2MRYEFBPbA(sLiiQPsCdxFsFNHmnhY4(undoHandler.knCgT6fkuY, _003CcutRegion_003E5__3, result2, true, false));
									num3 = 32;
									continue;
								case 20:
									if (shift == ShiftCells.EntireColumn)
									{
										num3 = 25;
										continue;
									}
									goto case 28;
								case 52:
									_003Cheights_003E5__2 = null;
									num3 = 48;
									continue;
								case 24:
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 45;
									continue;
								case 17:
									if (_003CcutRegion_003E5__3.Rows > 0)
									{
										num3 = 1;
										continue;
									}
									goto IL_0a21;
								case 1:
									awaiter2 = undoHandler.SendCutAsync(_003CcutRegion_003E5__3).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num3 = 8;
										if (true)
										{
											continue;
										}
										goto case 13;
									}
									goto IL_0880;
								case 13:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 30;
									continue;
								case 40:
									awVu4esCifV2CWLfrY72(fmsnxJsCDIugVUltXN8N(undoHandler.knCgT6fkuY), bZHJPcsCUqyL017OCBqD(S2sRpSsCV9OGIN27QLir(undoHandler.knCgT6fkuY)), _003Cheights_003E5__2);
									num3 = 52;
									continue;
								case 7:
									num6++;
									goto case 49;
								case 49:
									if (num6 < _003Cheights_003E5__2.Length - selected.Rows)
									{
										_003Cheights_003E5__2[num6] = _003Cheights_003E5__2[num6 + selected.Rows];
										num3 = 7;
									}
									else
									{
										num3 = 46;
									}
									continue;
								case 28:
									_003Cheights_003E5__2 = null;
									num3 = 66;
									continue;
								case 23:
								case 39:
								case 41:
								case 47:
								case 55:
									goto IL_0697;
								case 53:
									_003C_003Eu__2 = default;
									goto case 27;
								default:
									num3 = 27;
									if (true)
									{
										continue;
									}
									goto case 32;
								case 32:
									if (!awaiter.IsCompleted)
									{
										num3 = 18;
										continue;
									}
									goto IL_09e3;
								case 27:
									num2 = (_003C_003E1__state = -1);
									num3 = 61;
									continue;
								case 12:
									awaiter = ((Task)sLiiQPsCdxFsFNHmnhY4(undoHandler.knCgT6fkuY, _003CcutRegion_003E5__3, result, true, false)).GetAwaiter();
									num3 = 15;
									if (true)
									{
										continue;
									}
									goto case 48;
								case 18:
									goto IL_0863;
								case 42:
									goto IL_0880;
								case 35:
									selected.Rows = ((CvsProcessorConstants)S2sRpSsCV9OGIN27QLir(undoHandler.knCgT6fkuY)).SpreadsheetRows;
									num3 = 23;
									continue;
								case 9:
									flag = selected.Columns == CrBTVEsCHlEs2CnOeCxF(undoHandler.knCgT6fkuY.ProcessorConstants);
									num3 = 2;
									if (JwOwnqsC9mP2WbbUVBJA())
									{
										continue;
									}
									goto case 50;
								case 50:
									awaiter2 = undoHandler.SendCutAsync(_003CcutRegion_003E5__3).GetAwaiter();
									if (awaiter2.IsCompleted)
									{
										goto IL_03b3;
									}
									num2 = (_003C_003E1__state = 2);
									num3 = 24;
									if (0 == 0)
									{
										continue;
									}
									goto case 22;
								case 22:
									_003CcutRegion_003E5__3 = new CvsCellRange(selected.Location, selected.Size);
									num3 = 64;
									if (qIZrEVsCS7i9XMG27Bp5())
									{
									}
									continue;
								case 5:
									if (shift == ShiftCells.EntireRow)
									{
										num3 = 16;
										continue;
									}
									goto case 22;
								case 10:
								case 62:
									goto IL_0965;
								case 65:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 11;
									continue;
								case 6:
									if (num7 < _003Cheights_003E5__2.Length - selected.Columns)
									{
										_003Cheights_003E5__2[num7] = _003Cheights_003E5__2[num7 + selected.Columns];
										num3 = 29;
										if (!qIZrEVsCS7i9XMG27Bp5())
										{
											continue;
										}
										goto case 2;
									}
									num3 = 58;
									if (JwOwnqsC9mP2WbbUVBJA())
									{
										continue;
									}
									return;
								case 11:
									return;
								case 46:
									num4 = _003Cheights_003E5__2.Length - selected.Rows;
									num3 = 62;
									if (!qIZrEVsCS7i9XMG27Bp5())
									{
										continue;
									}
									goto case 61;
								case 61:
									awaiter.GetResult();
									goto IL_0a21;
								case 48:
								case 66:
									{
										((CvsCogSocketSheet)BRY0cKsCcFSQhohC2Vw8(vN4uSTsCEuGrs8gOriY4(undoHandler.knCgT6fkuY))).Run(true);
										goto end_IL_0038;
									}
									IL_0a21:
									if (shift == ShiftCells.EntireRow)
									{
										num3 = 14;
										if (qIZrEVsCS7i9XMG27Bp5())
										{
										}
										continue;
									}
									goto case 52;
									IL_03b3:
									result2 = awaiter2.GetResult();
									goto case 51;
								}
								break;
								IL_0965:
								if (num4 < _003Cheights_003E5__2.Length)
								{
									_003Cheights_003E5__2[num4] = 20;
									num4++;
									num3 = 10;
								}
								else
								{
									num3 = 40;
								}
								continue;
								IL_0249:
								selected.Columns = CrBTVEsCHlEs2CnOeCxF(S2sRpSsCV9OGIN27QLir(undoHandler.knCgT6fkuY));
								num3 = 39;
								continue;
								IL_0231:
								selected.Column = 0;
								num3 = 44;
								if (true)
								{
									continue;
								}
								goto IL_0249;
								IL_01a9:
								switch (shiftCells)
								{
								case ShiftCells.EntireRow:
									flag3 = true;
									num3 = 4;
									continue;
								default:
									num3 = 55;
									continue;
								case ShiftCells.EntireColumn:
									flag3 = false;
									num3 = 21;
									continue;
								case ShiftCells.Vertically:
									break;
								case ShiftCells.Horizontally:
									flag3 = false;
									num3 = 41;
									continue;
								}
								flag3 = true;
								num3 = 47;
								if (JwOwnqsC9mP2WbbUVBJA())
								{
									continue;
								}
								goto IL_0231;
							}
							goto IL_0133;
							IL_09e3:
							awaiter.GetResult();
							num3 = 20;
							goto IL_06cd;
							IL_0133:
							_003CcutRegion_003E5__3 = new CvsCellRange(selected.Location, selected.Size);
							num3 = 31;
							if (false)
							{
								goto IL_0697;
							}
							goto IL_06cd;
							IL_0697:
							if (flag3)
							{
								_003Cheights_003E5__2 = null;
								num3 = 5;
							}
							else
							{
								_003Cheights_003E5__2 = null;
								if (shift != ShiftCells.EntireColumn)
								{
									goto IL_0133;
								}
								num3 = 19;
								if (!JwOwnqsC9mP2WbbUVBJA())
								{
									goto IL_0863;
								}
							}
							goto IL_06cd;
							IL_0880:
							result = awaiter2.GetResult();
							num3 = 57;
							goto IL_06cd;
							IL_0863:
							num2 = (_003C_003E1__state = 3);
							_003C_003Eu__2 = awaiter;
							num3 = 65;
							if (0 == 0)
							{
								goto IL_06cd;
							}
							goto IL_0880;
							end_IL_0038:
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
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
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
		internal static object vN4uSTsCEuGrs8gOriY4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void A0nPlDsCv4T4fWEb94tg(object P_0, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ClearCellsAndRunSheet(cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int CrBTVEsCHlEs2CnOeCxF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).SpreadsheetColumns;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object S2sRpSsCV9OGIN27QLir(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int dpWuOusCA7isghaInanR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).SpreadsheetRows;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fmsnxJsCDIugVUltXN8N(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange bZHJPcsCUqyL017OCBqD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).SpreadsheetRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EBRdQKsCT11nNCOUut42(object P_0, CvsCellRange activeRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).GetRowHeights(activeRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sLiiQPsCdxFsFNHmnhY4(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object awVu4esCifV2CWLfrY72(object P_0, CvsCellRange activeRange, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).SetRowHeights(activeRange, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zHvQstsCqKdplMYmir0n(object P_0, CvsCellRange activeRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).GetColumnWidths(activeRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter WYltPjsCBj2MRYEFBPbA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ht7uYEsCjZnjabBskbti(object P_0, CvsCellRange activeRange, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).SetColumnWidths(activeRange, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BRY0cKsCcFSQhohC2Vw8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JwOwnqsC9mP2WbbUVBJA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qIZrEVsCS7i9XMG27Bp5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static Dictionary<string, IExternalCellDataHandler> unEgqfwIGS;

	private readonly CvsInSight knCgT6fkuY;

	private static readonly bool qgMgBg2Lv1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UndoHandler()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0032;
		IL_0070:
		string text = (string)uvMkTgt5WKo79HcVy1A(ConfigurationManager.AppSettings, kgbOBx7BanbFa22Hp9.ol99ukmDA(17068));
		goto IL_0095;
		IL_0032:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				break;
			default:
				num = 0;
				continue;
			case 1:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 5;
				continue;
			case 0:
				goto IL_0070;
			case 3:
			case 4:
				goto IL_0095;
			case 5:
				unEgqfwIGS = new Dictionary<string, IExternalCellDataHandler>((IEqualityComparer<string>)xxNQ4stKXugSTBOuVbJ());
				WbZoAjtCKL98v1cTcaQ();
				if (!gt0FTpttE6Or59ML2bE())
				{
					num = 3;
					continue;
				}
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				try
				{
					qgMgBg2Lv1 = Convert.ToBoolean(text);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			break;
		}
		goto IL_001a;
		IL_0095:
		if (text != null)
		{
			num = 7;
			goto IL_0032;
		}
		return;
		IL_001a:
		qgMgBg2Lv1 = false;
		goto IL_0070;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoHandler(CvsInSight inSight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!gt0FTpttE6Or59ML2bE())
		{
			goto IL_001e;
		}
		goto IL_0066;
		IL_001e:
		UiDHaftoWcGpEPuYgrA();
		_ = 0;
		num = ((!gt0FTpttE6Or59ML2bE()) ? 3 : 0);
		goto IL_0066;
		IL_0066:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				knCgT6fkuY = inSight;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				base._002Ector();
				goto default;
			case 5:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnUndoChanged(UndoEventType eventType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.OnUndoChanged(eventType);
		knCgT6fkuY.HandleUndoChanged(eventType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnUndoChangedAsync_003Ed__6))]
	protected override Task OnUndoChangedAsync(UndoEventType eventType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003COnUndoChangedAsync_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 1:
				do
				{
					stateMachine._003C_003E4__this = this;
					gt0FTpttE6Or59ML2bE();
					if (WbZoAjtCKL98v1cTcaQ())
					{
						num = 3;
						continue;
					}
					num = 5;
					break;
				}
				while (false);
				break;
			case 3:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 2:
			case 5:
				stateMachine.eventType = eventType;
				goto case 0;
			default:
				num = 0;
				break;
			case 6:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 1;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool CanUndo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return I8ffd0tY2yrwvKuutfh(knCgT6fkuY);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CanUndo(CvsInSight inSight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!qgMgBg2Lv1)
		{
			return LTDYs6t1SiZTCDLJ4Gd(eXsT8YtNwoqX66qcBEw(inSight), zddMJjtxO1pe3IvRxnT(16248));
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoCopyAsync_003Ed__9))]
	public Task<CvsCellClipboardData> DoCopyAsync(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDoCopyAsync_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellClipboardData>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoPaste_003Ed__10))]
	public Task DoPaste(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0034;
		IL_001a:
		_003CDoPaste_003Ed__10 stateMachine = default;
		stateMachine.cellRange = cellRange;
		goto IL_0073;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				goto IL_0073;
			case 6:
				goto IL_0085;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0085:
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			WbZoAjtCKL98v1cTcaQ();
			if (!gt0FTpttE6Or59ML2bE())
			{
				num = 2;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
			}
			else
			{
				num = 0;
			}
		}
		goto IL_001a;
		IL_0073:
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoPaste_003Ed__11))]
	public Task DoPaste(CvsCellRange cellRange, byte[] pasteData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDoPaste_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine.pasteData = pasteData;
				goto case 1;
			default:
				num = 1;
				break;
			case 2:
			case 4:
				stateMachine.cellRange = cellRange;
				num = 3;
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				gt0FTpttE6Or59ML2bE();
				num = (WbZoAjtCKL98v1cTcaQ() ? 7 : 4);
				break;
			case 0:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 6;
				break;
			case 5:
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoCutAndPaste_003Ed__12))]
	public Task DoCutAndPaste(CvsCellRange cutyRange, CvsCellRange pasteRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDoCutAndPaste_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine.cutyRange = cutyRange;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 3;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				gt0FTpttE6Or59ML2bE();
				num = (WbZoAjtCKL98v1cTcaQ() ? 6 : 0);
				break;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 7:
				stateMachine.pasteRange = pasteRange;
				goto case 1;
			default:
				num = 1;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoInsert_003Ed__13))]
	public Task DoInsert(CvsCellRange cellRange, ShiftCells shift)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDoInsert_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine.cellRange = cellRange;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 4:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				WbZoAjtCKL98v1cTcaQ();
				num = (gt0FTpttE6Or59ML2bE() ? 6 : 2);
				break;
			case 2:
			case 3:
				stateMachine.shift = shift;
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				break;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 7;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoImportCxdxSnippet_003Ed__14))]
	public Task DoImportCxdxSnippet(CvsCellRange cellRange, Func<Task> func)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDoImportCxdxSnippet_003Ed__14 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cellRange = cellRange;
		stateMachine.func = func;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoDelete_003Ed__15))]
	public Task DoDelete(CvsCellRange cellRange, ShiftCells shift)
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
		goto IL_0034;
		IL_001a:
		_003CDoDelete_003Ed__15 stateMachine = default;
		stateMachine.shift = shift;
		goto IL_0081;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				break;
			default:
				num = 0;
				continue;
			case 2:
				stateMachine.cellRange = cellRange;
				break;
			case 0:
				goto IL_0081;
			case 5:
				goto IL_0093;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0093:
			stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
			_ = 1;
			if (WbZoAjtCKL98v1cTcaQ())
			{
				num = 4;
				if (true)
				{
					continue;
				}
				goto IL_0081;
			}
			num = 6;
		}
		goto IL_001a;
		IL_0081:
		stateMachine._003C_003E1__state = -1;
		num = 7;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoClearContent_003Ed__16))]
	public Task DoClearContent(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDoClearContent_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				stateMachine.cellRange = cellRange;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				WbZoAjtCKL98v1cTcaQ();
				if (!gt0FTpttE6Or59ML2bE())
				{
					num = 1;
					break;
				}
				num = 6;
				if (gt0FTpttE6Or59ML2bE())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 4;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoClearFormats_003Ed__17))]
	public Task DoClearFormats(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDoClearFormats_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine.cellRange = cellRange;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (!gt0FTpttE6Or59ML2bE())
				{
					num = 1;
					break;
				}
				num = 4;
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoClearComments_003Ed__18))]
	public Task DoClearComments(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gt0FTpttE6Or59ML2bE())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0040;
		IL_0083:
		_003CDoClearComments_003Ed__18 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_009b;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 5;
				continue;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (true)
				{
					continue;
				}
				goto IL_0083;
			case 5:
				goto IL_0083;
			case 1:
			case 4:
				goto IL_009b;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		stateMachine.cellRange = cellRange;
		goto IL_0083;
		IL_009b:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0040;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoClearCellNames_003Ed__19))]
	public Task DoClearCellNames(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CDoClearCellNames_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 5:
				stateMachine.cellRange = cellRange;
				goto case 0;
			default:
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 6:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				gt0FTpttE6Or59ML2bE();
				if (WbZoAjtCKL98v1cTcaQ())
				{
					num = 5;
					continue;
				}
				num = 4;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoClearAll_003Ed__20))]
	public Task DoClearAll(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!gt0FTpttE6Or59ML2bE()) ? 4 : 3);
		_003CDoClearAll_003Ed__20 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				goto case 1;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				break;
			case 6:
				stateMachine.cellRange = cellRange;
				goto case 5;
			default:
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoRowHeights_003Ed__21))]
	public Task DoRowHeights(CvsCellRange activeRange, int startRow, int endRow, int height)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDoRowHeights_003Ed__21 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.startRow = startRow;
				gt0FTpttE6Or59ML2bE();
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					num = 3;
					break;
				}
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 1:
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 10;
				break;
			case 0:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 9;
				break;
			case 8:
				stateMachine.activeRange = activeRange;
				num = 5;
				break;
			case 2:
				stateMachine.height = height;
				num = 6;
				break;
			case 3:
			case 4:
				stateMachine.endRow = endRow;
				goto case 2;
			default:
				num = 2;
				break;
			case 9:
				stateMachine._003C_003E4__this = this;
				num = 8;
				break;
			case 10:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoColumnWidths_003Ed__22))]
	public Task DoColumnWidths(CvsCellRange activeRange, int startColumn, int endColumn, int width)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CDoColumnWidths_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine.startColumn = startColumn;
				num = 0;
				continue;
			case 8:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 10;
				continue;
			case 0:
				stateMachine.endColumn = endColumn;
				goto case 2;
			default:
				num = 2;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 9;
				continue;
			case 2:
				stateMachine.width = width;
				goto case 4;
			case 4:
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 8;
				continue;
			case 3:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				_ = 1;
				num = ((!WbZoAjtCKL98v1cTcaQ()) ? 5 : 4);
				continue;
			case 9:
				stateMachine.activeRange = activeRange;
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 10:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoHideRows_003Ed__23))]
	public Task DoHideRows(CvsCellRange activeRange, int startRow, int endRow)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WbZoAjtCKL98v1cTcaQ())
		{
			num = 6;
			if (!gt0FTpttE6Or59ML2bE())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_00da;
		IL_002a:
		_003CDoHideRows_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
		num = 2;
		if (WbZoAjtCKL98v1cTcaQ())
		{
		}
		goto IL_00da;
		IL_00da:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				break;
			case 5:
				stateMachine.endRow = endRow;
				num = 8;
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 7;
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine.activeRange = activeRange;
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine.startRow = startRow;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoUnhideRows_003Ed__24))]
	public Task DoUnhideRows(CvsCellRange activeRange, int startRow, int endRow)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CDoUnhideRows_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 6:
			case 8:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				break;
			case 0:
				stateMachine.activeRange = activeRange;
				num = 5;
				break;
			case 4:
				stateMachine.endRow = endRow;
				num = 3;
				break;
			case 7:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				WbZoAjtCKL98v1cTcaQ();
				num = ((!gt0FTpttE6Or59ML2bE()) ? 8 : 2);
				break;
			case 5:
				stateMachine.startRow = startRow;
				goto case 4;
			default:
				num = 4;
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 6;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoHideColumns_003Ed__25))]
	public Task DoHideColumns(CvsCellRange activeRange, int startColumn, int endColumn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WbZoAjtCKL98v1cTcaQ())
		{
			num = 5;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_009c;
			}
		}
		goto IL_00c8;
		IL_00c8:
		_003CDoHideColumns_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				stateMachine.activeRange = activeRange;
				num = 3;
				continue;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				continue;
			case 4:
				stateMachine.endColumn = endColumn;
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 8;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				goto case 1;
			case 6:
				break;
			case 3:
				stateMachine.startColumn = startColumn;
				goto case 4;
			default:
				num = 4;
				continue;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_009c;
		IL_009c:
		stateMachine._003C_003E1__state = -1;
		num = 7;
		goto IL_00c8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoUnhideColumns_003Ed__26))]
	public Task DoUnhideColumns(CvsCellRange activeRange, int startColumn, int endColumn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!WbZoAjtCKL98v1cTcaQ())
		{
		}
		_003CDoUnhideColumns_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine.endColumn = endColumn;
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 3;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 3:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				continue;
			case 2:
			case 7:
				stateMachine.activeRange = activeRange;
				num = 8;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				continue;
			case 1:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 4;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 8:
				stateMachine.startColumn = startColumn;
				goto case 0;
			default:
				num = 0;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				break;
			case 9:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoPropertySheetChange_003Ed__27))]
	public Task DoPropertySheetChange(CvsCellLocation cell, string expr, string text = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDoPropertySheetChange_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine.expr = expr;
				goto case 7;
			default:
				num = 7;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num = 8;
				continue;
			case 8:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				continue;
			case 7:
				stateMachine.text = text;
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 6;
				continue;
			case 6:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (gt0FTpttE6Or59ML2bE())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 2:
			case 5:
				stateMachine.cell = cell;
				goto case 0;
			case 9:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoScriptChange_003Ed__28))]
	public Task DoScriptChange(CvsCellLocation cell, string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CDoScriptChange_003Ed__28 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				gt0FTpttE6Or59ML2bE();
				num = (WbZoAjtCKL98v1cTcaQ() ? 3 : 6);
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 7:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			case 2:
			case 6:
				stateMachine.cell = cell;
				num = 5;
				if (gt0FTpttE6Or59ML2bE())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine.expr = expr;
				goto default;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoExpressionChange_003Ed__29))]
	public Task DoExpressionChange(CvsCellLocation cell, string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gt0FTpttE6Or59ML2bE();
		int num;
		if (!WbZoAjtCKL98v1cTcaQ())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_00b6;
		IL_002a:
		_003CDoExpressionChange_003Ed__29 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 2;
		goto IL_00b6;
		IL_00b6:
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine.cell = cell;
				num = 4;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				goto case 1;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 4:
				stateMachine.expr = expr;
				break;
			default:
				num = 7;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoInsertReferences_003Ed__30))]
	public Task DoInsertReferences(CvsReferenceRange source, CvsCellRange dest)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (WbZoAjtCKL98v1cTcaQ() ? 5 : 7);
		_003CDoInsertReferences_003Ed__30 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 0:
			case 7:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
				stateMachine.source = source;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				break;
			case 4:
				stateMachine.dest = dest;
				goto case 3;
			default:
				num = 3;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoExpressionChange_003Ed__31))]
	public Task DoExpressionChange(CvsCellLocation cell, string expr, string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CDoExpressionChange_003Ed__31 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 3;
				break;
			case 5:
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				break;
			case 2:
			case 4:
				stateMachine.text = text;
				goto case 5;
			case 0:
				stateMachine.cell = cell;
				num = 8;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					break;
				}
				goto case 8;
			case 8:
				stateMachine.expr = expr;
				goto default;
			default:
				WbZoAjtCKL98v1cTcaQ();
				if (!gt0FTpttE6Or59ML2bE())
				{
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				num = 2;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoReferenceRedirect_003Ed__32))]
	public Task DoReferenceRedirect(CvsCellLocation oldReference, CvsCellLocation newReference)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDoReferenceRedirect_003Ed__32 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 6;
				break;
			case 0:
				stateMachine.oldReference = oldReference;
				gt0FTpttE6Or59ML2bE();
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					num = 7;
					if (WbZoAjtCKL98v1cTcaQ())
					{
					}
				}
				else
				{
					num = 1;
				}
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					break;
				}
				goto case 3;
			case 3:
			case 7:
				stateMachine.newReference = newReference;
				goto default;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAutoFitRows_003Ed__33))]
	public Task DoAutoFitRows(CvsCellRange activeRange, CvsCellRange cellRange, int[] heights)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gt0FTpttE6Or59ML2bE();
		int num;
		if (!WbZoAjtCKL98v1cTcaQ())
		{
			num = 2;
			if (!gt0FTpttE6Or59ML2bE())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0088;
		IL_002e:
		_003CDoAutoFitRows_003Ed__33 stateMachine = default;
		stateMachine.activeRange = activeRange;
		num = 5;
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 1;
				continue;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				continue;
			case 5:
				stateMachine.cellRange = cellRange;
				goto case 7;
			default:
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine.heights = heights;
				num = 3;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 8;
				continue;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAutoFitColumns_003Ed__34))]
	public Task DoAutoFitColumns(CvsCellRange activeRange, CvsCellRange cellRange, int[] widths)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CDoAutoFitColumns_003Ed__34 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 7;
				break;
			case 8:
				stateMachine.widths = widths;
				_ = 0;
				num = (gt0FTpttE6Or59ML2bE() ? 1 : 3);
				break;
			case 1:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 3:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 0:
				stateMachine.cellRange = cellRange;
				goto case 8;
			default:
				num = 8;
				break;
			case 4:
				stateMachine.activeRange = activeRange;
				num = 0;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoGraphicChange_003Ed__35))]
	public Task DoGraphicChange(CvsCogEditInfo editInfo, CvsCogEditingShape originalShape, CvsCogShape editedShape)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CDoGraphicChange_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 8;
				continue;
			case 0:
				stateMachine.editInfo = editInfo;
				gt0FTpttE6Or59ML2bE();
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					num = 2;
					continue;
				}
				num = 4;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				continue;
			case 4:
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				continue;
			case 2:
			case 3:
				stateMachine.originalShape = originalShape;
				goto case 7;
			default:
				num = 7;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine.editedShape = editedShape;
				goto case 4;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				continue;
			case 8:
				stateMachine._003C_003E4__this = this;
				num = 0;
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					continue;
				}
				break;
			case 9:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoCellState_003Ed__36))]
	public Task DoCellState(CvsCellRange cellRange, string state)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gt0FTpttE6Or59ML2bE();
		int num = (WbZoAjtCKL98v1cTcaQ() ? 7 : 4);
		_003CDoCellState_003Ed__36 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.cellRange = cellRange;
				goto case 3;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 3:
			case 7:
				stateMachine.state = state;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoCellNameEditor_003Ed__37))]
	public Task DoCellNameEditor(CvsCellInfoCollection originalInfoCollection, CvsCellInfoCollection newInfoCollection)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!gt0FTpttE6Or59ML2bE())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_001e:
		_003CDoCellNameEditor_003Ed__37 stateMachine = default;
		stateMachine.newInfoCollection = newInfoCollection;
		goto IL_006b;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			default:
				num = 6;
				continue;
			case 6:
				goto IL_006b;
			case 4:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 2:
			case 7:
				stateMachine.originalInfoCollection = originalInfoCollection;
				break;
			case 1:
				do
				{
					stateMachine._003C_003E4__this = this;
					_ = 0;
					if (!gt0FTpttE6Or59ML2bE())
					{
						num = 0;
						continue;
					}
					num = 7;
					break;
				}
				while (!gt0FTpttE6Or59ML2bE());
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_006b:
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoInsertComment_003Ed__38))]
	public Task DoInsertComment(CvsCell cell, CvsCellComment comment)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gt0FTpttE6Or59ML2bE();
		int num = (WbZoAjtCKL98v1cTcaQ() ? 4 : 3);
		_003CDoInsertComment_003Ed__38 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 7;
				if (!WbZoAjtCKL98v1cTcaQ())
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 7:
				stateMachine.cell = cell;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine.comment = comment;
				goto case 1;
			default:
				num = 1;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoFormatCells_003Ed__39))]
	public Task DoFormatCells(CvsCellRange cellRange, List<CvsCellFormat> cellFormats)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDoFormatCells_003Ed__39 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cellRange = cellRange;
		stateMachine.cellFormats = cellFormats;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendCutAsync_003Ed__40))]
	public Task<byte[]> SendCutAsync(CvsCellRange selected)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSendCutAsync_003Ed__40 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.selected = selected;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendCopyAsync_003Ed__41))]
	public Task<byte[]> SendCopyAsync(CvsCellRange selected)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSendCopyAsync_003Ed__41 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.selected = selected;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendInsertCellsAsync_003Ed__42))]
	public Task SendInsertCellsAsync(CvsCellRange selected, ShiftCells shift)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gt0FTpttE6Or59ML2bE())
		{
			num = 1;
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_0076;
			}
		}
		goto IL_00ba;
		IL_0076:
		_003CSendInsertCellsAsync_003Ed__42 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 4;
		if (!gt0FTpttE6Or59ML2bE())
		{
			goto IL_008e;
		}
		goto IL_00ba;
		IL_008e:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_00ba;
		IL_00ba:
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				continue;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 7;
				continue;
			case 5:
				stateMachine.selected = selected;
				goto case 3;
			case 2:
				break;
			case 7:
				goto IL_008e;
			case 3:
			case 6:
				stateMachine.shift = shift;
				break;
			default:
				num = 2;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0076;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendRemoveCellsAsync_003Ed__43))]
	public Task SendRemoveCellsAsync(CvsCellRange selected, ShiftCells shift)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gt0FTpttE6Or59ML2bE();
		int num;
		if (!WbZoAjtCKL98v1cTcaQ())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0044;
		IL_009d:
		_003CSendRemoveCellsAsync_003Ed__43 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_00cb;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			default:
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 3:
				stateMachine.selected = selected;
				num = 7;
				continue;
			case 1:
				goto IL_009d;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = mTvpkqtPGqfXRXKA8eV();
				num = 6;
				continue;
			case 2:
			case 5:
				goto IL_00cb;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine.shift = shift;
		goto IL_009d;
		IL_00cb:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 8;
		goto IL_0044;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterExternalDataHandler(string expr, IExternalCellDataHandler handler)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		unEgqfwIGS[expr] = handler;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IExternalCellDataHandler GetExternalCellDataHandler(CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		IExternalCellDataHandler result = default;
		while (true)
		{
			switch (num)
			{
			default:
				result = GetExternalCellDataHandler(cell.Expression);
				num = 5;
				if (WbZoAjtCKL98v1cTcaQ())
				{
				}
				continue;
			case 0:
			case 1:
				if (XYnpyotrCFYwQdCwPkj(cell))
				{
					break;
				}
				goto default;
			case 3:
				result = null;
				_ = 0;
				num = ((!gt0FTpttE6Or59ML2bE()) ? 4 : 0);
				continue;
			case 5:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IExternalCellDataHandler GetExternalCellDataHandler(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (gt0FTpttE6Or59ML2bE() ? 1 : 5);
		string[] array = default;
		string key = default;
		IExternalCellDataHandler value = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				array = (string[])zv0bdZtO7ivP28MyIjo(expr, new char[1] { '(' });
				goto case 3;
			case 6:
				unEgqfwIGS.TryGetValue(key, out value);
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				key = (string)bUBHmRtMwvsXGTOBgY3(array[0]);
				num = 6;
				continue;
			case 3:
			case 5:
				if (array.Length == 0)
				{
					break;
				}
				goto case 2;
			default:
				num = 2;
				continue;
			case 0:
			case 1:
				value = null;
				num = 4;
				if (gt0FTpttE6Or59ML2bE())
				{
					continue;
				}
				goto case 4;
			case 4:
				if (!fxGQMnt3JyJsEvKhfuf(expr))
				{
					num = 7;
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task xbFggv3SKn(UndoEventType P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnUndoChangedAsync(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xxNQ4stKXugSTBOuVbJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return StringComparer.InvariantCultureIgnoreCase;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uvMkTgt5WKo79HcVy1A(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gt0FTpttE6Or59ML2bE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WbZoAjtCKL98v1cTcaQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UiDHaftoWcGpEPuYgrA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder mTvpkqtPGqfXRXKA8eV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I8ffd0tY2yrwvKuutfh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CanUndo((CvsInSight)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eXsT8YtNwoqX66qcBEw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).ConnectedUser;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zddMJjtxO1pe3IvRxnT(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LTDYs6t1SiZTCDLJ4Gd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsConnectedUser)P_0).HasModifyPermission((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XYnpyotrCFYwQdCwPkj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCell.IsNullOrEmpty((CvsCell)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fxGQMnt3JyJsEvKhfuf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zv0bdZtO7ivP28MyIjo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bUBHmRtMwvsXGTOBgY3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToLowerInvariant();
	}
}
