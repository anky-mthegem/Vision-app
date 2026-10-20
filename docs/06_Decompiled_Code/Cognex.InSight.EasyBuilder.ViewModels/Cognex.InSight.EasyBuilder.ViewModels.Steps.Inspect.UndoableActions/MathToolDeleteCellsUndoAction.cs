using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class MathToolDeleteCellsUndoAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolDeleteCellsUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!tKo1LHKcMA9nsAWYIjCi()) ? 3 : 2);
			int num2 = default;
			MathToolDeleteCellsUndoAction mathToolDeleteCellsUndoAction = default;
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
							awaiter = mathToolDeleteCellsUndoAction.Redo().GetAwaiter();
							num3 = 5;
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
							case 0:
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = ((!tKo1LHKcMA9nsAWYIjCi()) ? 7 : 0);
								continue;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								if (!NTcbn8KcYiCVSovnN0V3())
								{
									continue;
								}
								return;
							case 1:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 6;
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
					goto case 4;
				default:
					num = 4;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				mathToolDeleteCellsUndoAction = _003C_003E4__this;
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
		internal static bool tKo1LHKcMA9nsAWYIjCi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NTcbn8KcYiCVSovnN0V3()
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
	private struct _003CRedo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolDeleteCellsUndoAction _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			M43EdGKcU4b26AI88ToW();
			int num = (XZNwteKcH4A9xh1I7yD3() ? 5 : 4);
			MathToolDeleteCellsUndoAction mathToolDeleteCellsUndoAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			CvsCellRange cellRange = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					mathToolDeleteCellsUndoAction = _003C_003E4__this;
					num = 3;
					if (XZNwteKcH4A9xh1I7yD3())
					{
					}
					continue;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 6;
								if (!M43EdGKcU4b26AI88ToW())
								{
									goto IL_0060;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 1;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 11;
							if (false)
							{
								goto IL_0092;
							}
						}
						goto IL_0162;
						IL_0162:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 13:
								break;
							case 15:
								goto IL_0092;
							case 6:
								cellRange = mathToolDeleteCellsUndoAction.CellRange;
								num3 = 14;
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 3:
								awaiter = mathToolDeleteCellsUndoAction.tYTOsLNCwO((CvsCogSocketSheet)rCi9IiKcQWpXXLd7rXtt(a8NKakKcmFe0RypfL6jf(mathToolDeleteCellsUndoAction.o5IOBgitt0.InSight))).GetAwaiter();
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								if (!awaiter2.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto IL_0092;
							case 1:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 8:
								return;
							case 11:
								num2 = (_003C_003E1__state = -1);
								goto IL_0092;
							default:
								num3 = 15;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
							case 7:
								_003C_003Eu__1 = awaiter2;
								break;
							case 9:
								goto IL_01ce;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto case 16;
							case 14:
								awaiter2 = ((CvsCogSocketSheet)rCi9IiKcQWpXXLd7rXtt(a8NKakKcmFe0RypfL6jf(erbxQqKcxv6tUN91YEwU(mathToolDeleteCellsUndoAction.o5IOBgitt0)))).ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 16;
							case 16:
								awaiter.GetResult();
								goto end_IL_0043;
							}
							break;
							IL_01ce:
							num2 = (_003C_003E1__state = 0);
							_ = 1;
							num3 = ((!XZNwteKcH4A9xh1I7yD3()) ? 7 : 13);
						}
						goto IL_0060;
						IL_0092:
						awaiter2.GetResult();
						num3 = 3;
						goto IL_0162;
						IL_0060:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
						end_IL_0043:;
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
				case 2:
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
		internal static object erbxQqKcxv6tUN91YEwU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a8NKakKcmFe0RypfL6jf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rCi9IiKcQWpXXLd7rXtt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M43EdGKcU4b26AI88ToW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XZNwteKcH4A9xh1I7yD3()
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
	private struct _003CSaveState_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolDeleteCellsUndoAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nXLNxGKcNqhV1mwgAEQ1();
			int num = (DKq2MrKc2NxQiiHH1JCN() ? 3 : 4);
			MathToolDeleteCellsUndoAction mathToolDeleteCellsUndoAction = default;
			int num2 = default;
			CvsCellRange cellRange = default;
			TaskAwaiter<byte[]> awaiter = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 3:
					mathToolDeleteCellsUndoAction = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cellRange = mathToolDeleteCellsUndoAction.CellRange;
							num3 = 5;
							goto IL_007f;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0125;
						IL_0125:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_007f;
						IL_007f:
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								DKq2MrKc2NxQiiHH1JCN();
								num3 = (nXLNxGKcNqhV1mwgAEQ1() ? 1 : 2);
								continue;
							case 9:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 5:
								awaiter = ((CvsCogSocketSheet)w6oYE6KcuMYgxoaRZVlj(hd7r7CKc1tifYrDZrGLi(zE0eBFKccGZC2PkyEMpo(mathToolDeleteCellsUndoAction.o5IOBgitt0)))).CopyCellsAsync(cellRange).GetAwaiter();
								num3 = 8;
								continue;
							case 7:
								return;
							case 2:
							case 6:
								break;
							case 1:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (!DKq2MrKc2NxQiiHH1JCN())
								{
									continue;
								}
								goto case 10;
							case 10:
								mathToolDeleteCellsUndoAction.OAgOtOUKMA = result;
								goto end_IL_007f;
							}
							goto IL_0125;
							continue;
							end_IL_007f:
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
					break;
				case 0:
				case 4:
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
		internal static object zE0eBFKccGZC2PkyEMpo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hd7r7CKc1tifYrDZrGLi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object w6oYE6KcuMYgxoaRZVlj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nXLNxGKcNqhV1mwgAEQ1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DKq2MrKc2NxQiiHH1JCN()
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
	private struct _003CUndo_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolDeleteCellsUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter awaiter = default;
			MathToolDeleteCellsUndoAction mathToolDeleteCellsUndoAction = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					ntyZyyKcthEGti3i7XWx();
					if (Dp7mXAKchJRYBQuiBJ1k())
					{
						num = 5;
						if (true)
						{
							continue;
						}
						goto case 0;
					}
					num = 0;
					continue;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 12;
								if (!Dp7mXAKchJRYBQuiBJ1k())
								{
									goto IL_0058;
								}
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
							num3 = 11;
						}
						goto IL_01fc;
						IL_0058:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_01fc;
						IL_01fc:
						while (true)
						{
							switch (num3)
							{
							case 14:
								break;
							case 1:
							case 9:
								awaiter = jmS4fAK15DS1E3RgryPx(O0v9BbK1Kuh17436EpL3(uMxsFRK1LOdqVjXFX4cB(fmS1cBKczprjc9MHBDs5(mathToolDeleteCellsUndoAction.o5IOBgitt0.InSight)), cvsCellRange, mathToolDeleteCellsUndoAction.OAgOtOUKMA, false, false));
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 16;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (!ntyZyyKcthEGti3i7XWx())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									if (ntyZyyKcthEGti3i7XWx())
									{
									}
									continue;
								}
								goto case 2;
							case 15:
								return;
							case 12:
								cvsCellRange = mathToolDeleteCellsUndoAction.CellRange;
								_ = 1;
								if (!ntyZyyKcthEGti3i7XWx())
								{
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								}
								num3 = 10;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							default:
								awaiter = mathToolDeleteCellsUndoAction.tYTOsLNCwO((CvsCogSocketSheet)uMxsFRK1LOdqVjXFX4cB(mathToolDeleteCellsUndoAction.o5IOBgitt0.InSight.CogSocket)).GetAwaiter();
								num3 = 13;
								continue;
							case 2:
								awaiter.GetResult();
								goto default;
							case 16:
								awaiter.GetResult();
								goto end_IL_01fc;
							}
							goto IL_0058;
							continue;
							end_IL_01fc:
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
					num = 3;
					continue;
				case 1:
				case 5:
					mathToolDeleteCellsUndoAction = _003C_003E4__this;
					goto case 0;
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
		internal static object fmS1cBKczprjc9MHBDs5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uMxsFRK1LOdqVjXFX4cB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object O0v9BbK1Kuh17436EpL3(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter jmS4fAK15DS1E3RgryPx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dp7mXAKchJRYBQuiBJ1k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ntyZyyKcthEGti3i7XWx()
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
	private struct _003CRunAndUpdate_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketSheet sheet;

		public MathToolDeleteCellsUndoAction _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			MathToolDeleteCellsUndoAction mathToolDeleteCellsUndoAction = default;
			int num2 = default;
			CvsCellCollection result = default;
			GroupTool groupTool = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					mathToolDeleteCellsUndoAction = _003C_003E4__this;
					GVJXbDK1w3jfOxGZgulU();
					if (!yKYgS6K1J1HPb9L1BDAI())
					{
						num = 1;
						if (!yKYgS6K1J1HPb9L1BDAI())
						{
							break;
						}
						goto default;
					}
					num = 0;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = sheet.RunAndGetCellResults().GetAwaiter();
							num3 = 6;
							goto IL_00a2;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						goto IL_00d7;
						IL_00f3:
						num2 = (_003C_003E1__state = -1);
						num3 = 4;
						goto IL_00a2;
						IL_00d7:
						yKYgS6K1J1HPb9L1BDAI();
						if (GVJXbDK1w3jfOxGZgulU())
						{
							num3 = 1;
							if (1 == 0)
							{
								goto IL_00f3;
							}
						}
						else
						{
							num3 = 3;
							if (yKYgS6K1J1HPb9L1BDAI())
							{
							}
						}
						goto IL_00a2;
						IL_00a2:
						while (true)
						{
							switch (num3)
							{
							case 10:
								return;
							case 1:
							case 5:
								goto IL_00f3;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 4;
							case 4:
								result = awaiter.GetResult();
								goto case 3;
							case 8:
								if (groupTool != null)
								{
									num3 = 11;
									continue;
								}
								goto end_IL_0054;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 7:
								groupTool = Rh2h93K1aspRYZ79dCA3(mathToolDeleteCellsUndoAction.o5IOBgitt0) as GroupTool;
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								groupTool.nnG4uPQKIR(result);
								goto end_IL_0054;
							}
							break;
						}
						goto IL_00d7;
						end_IL_0054:;
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
					num = 5;
					if (yKYgS6K1J1HPb9L1BDAI())
					{
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
		internal static object Rh2h93K1aspRYZ79dCA3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).CurrentTool;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GVJXbDK1w3jfOxGZgulU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yKYgS6K1J1HPb9L1BDAI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private InspectStepViewModel o5IOBgitt0;

	private string yFUOZc6lZs;

	private CvsCellRange D6jOnyXhmL;

	private byte[] OAgOtOUKMA;

	public MathTool MathTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return o5IOBgitt0.Snippets.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet P_0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (string)qTj382yDSrWpJTgxjL5(P_0) == yFUOZc6lZs;
			}) as MathTool;
		}
	}

	private CvsCellRange CellRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qJhktFyaIlsWE87NhDD();
			int num = ((!xH0FY9yJXYmAQbLKdoA()) ? 5 : 3);
			MathTool mathTool = default;
			CvsCellRange result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (mathTool == null)
					{
						break;
					}
					goto case 2;
				default:
					num = 2;
					continue;
				case 0:
				case 3:
					result = CvsCellRange.Invalid;
					goto case 1;
				case 2:
					result = mathTool.GetActualCellRange(D6jOnyXhmL);
					num = 6;
					continue;
				case 1:
				case 5:
					mathTool = MathTool;
					num = 4;
					if (qJhktFyaIlsWE87NhDD())
					{
					}
					continue;
				case 6:
					break;
				}
				break;
			}
			return result;
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
			return string.Format(Resources.iPch32S3YZ(), yFUOZc6lZs, D6jOnyXhmL);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MathToolDeleteCellsUndoAction(InspectStepViewModel inspect, string mathToolName, CvsCellRange virtualCellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qJhktFyaIlsWE87NhDD();
		int num = ((!xH0FY9yJXYmAQbLKdoA()) ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 5:
				D6jOnyXhmL = virtualCellRange;
				num = 7;
				continue;
			case 3:
				o5IOBgitt0 = inspect;
				break;
			default:
				num = 6;
				continue;
			case 6:
				break;
			case 1:
			case 4:
				I8A9fuyOOBmXGF5Ogkh(this);
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				yfmCnOye0I8NJxqJKOa();
				goto case 1;
			case 7:
				return;
			}
			yFUOZc6lZs = mathToolName;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__11))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xH0FY9yJXYmAQbLKdoA();
		int num;
		if (!qJhktFyaIlsWE87NhDD())
		{
			num = 2;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
			if (!xH0FY9yJXYmAQbLKdoA())
			{
				goto IL_006a;
			}
		}
		goto IL_0096;
		IL_0048:
		_003CDo_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder = Skgm0TyIOAP4DsNs2nW();
		goto IL_006a;
		IL_0096:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 2:
				goto IL_0048;
			case 1:
			case 5:
				goto IL_006a;
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 4;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (!xH0FY9yJXYmAQbLKdoA())
		{
			goto IL_0048;
		}
		goto IL_0096;
		IL_006a:
		stateMachine._003C_003E4__this = this;
		num = 3;
		goto IL_0096;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__12))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CRedo_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003E4__this = this;
				qJhktFyaIlsWE87NhDD();
				if (!xH0FY9yJXYmAQbLKdoA())
				{
					num = 5;
					continue;
				}
				num = 4;
				if (qJhktFyaIlsWE87NhDD())
				{
				}
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!qJhktFyaIlsWE87NhDD())
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003Et__builder = Skgm0TyIOAP4DsNs2nW();
				num = 0;
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
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__13))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSaveState_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 3:
				stateMachine._003C_003Et__builder = Skgm0TyIOAP4DsNs2nW();
				_ = 0;
				if (!xH0FY9yJXYmAQbLKdoA())
				{
					num = 4;
					break;
				}
				num = 5;
				if (xH0FY9yJXYmAQbLKdoA())
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__14))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CUndo_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = Skgm0TyIOAP4DsNs2nW();
				qJhktFyaIlsWE87NhDD();
				num = (xH0FY9yJXYmAQbLKdoA() ? 4 : 2);
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 0;
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
	[AsyncStateMachine(typeof(_003CRunAndUpdate_003Ed__15))]
	private Task tYTOsLNCwO(CvsCogSocketSheet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qJhktFyaIlsWE87NhDD();
		int num = ((!xH0FY9yJXYmAQbLKdoA()) ? 3 : 6);
		_003CRunAndUpdate_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				continue;
			case 2:
			case 3:
				stateMachine.sheet = P_0;
				goto case 4;
			default:
				num = 4;
				if (xH0FY9yJXYmAQbLKdoA())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = Skgm0TyIOAP4DsNs2nW();
				num = 5;
				if (true)
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
	[CompilerGenerated]
	private bool OVIOKOC12r(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)qTj382yDSrWpJTgxjL5(P_0) == yFUOZc6lZs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yfmCnOye0I8NJxqJKOa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I8A9fuyOOBmXGF5Ogkh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xH0FY9yJXYmAQbLKdoA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qJhktFyaIlsWE87NhDD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Skgm0TyIOAP4DsNs2nW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qTj382yDSrWpJTgxjL5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}
}
