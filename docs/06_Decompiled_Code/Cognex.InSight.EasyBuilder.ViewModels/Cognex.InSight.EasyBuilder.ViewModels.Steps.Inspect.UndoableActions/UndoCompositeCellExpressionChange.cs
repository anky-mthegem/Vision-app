using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class UndoCompositeCellExpressionChange : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCompositeCellExpressionChange _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			UndoCompositeCellExpressionChange undoCompositeCellExpressionChange = default;
			CvsCellCollection result = default;
			CvsCellLocation cvsCellLocation = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocket)DbDm4yKuYu2ablq2MnAa(undoCompositeCellExpressionChange.EnHHQtK7Pw())).Sheet.RunAndGetCellResults().GetAwaiter();
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 13;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
								result = awaiter.GetResult();
								cvsCellLocation = undoCompositeCellExpressionChange.TiBHEaSiqn(result, undoCompositeCellExpressionChange.VKkHRsiup9);
								num3 = 7;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 8:
							case 11:
								undoCompositeCellExpressionChange.eL9HWuEnkv = undoCompositeCellExpressionChange.JMJHbKTs4J(result, text);
								num3 = 12;
								continue;
							case 13:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 9:
								undoCompositeCellExpressionChange.eeOHjrbr2g.Add(undoCompositeCellExpressionChange.mDSHlZnJjb);
								num3 = 14;
								if (K4iOsSKuMoASPvwgBhhq())
								{
								}
								continue;
							case 7:
								text = (string)nRMg8LKuHurGm9VYXvQN(VMuGlgKuUU5WDDtuNKLT(result, cvsCellLocation));
								_ = 0;
								if (b2ioWBKuFqpMsk1cUjtc())
								{
									num3 = 11;
									if (0 == 0)
									{
										continue;
									}
									goto case 12;
								}
								num3 = 1;
								continue;
							case 12:
								undoCompositeCellExpressionChange.eeOHjrbr2g = new List<string>(undoCompositeCellExpressionChange.eL9HWuEnkv);
								goto case 1;
							case 1:
							case 10:
								if (undoCompositeCellExpressionChange.C1sHTcWLh9)
								{
									num3 = 9;
									continue;
								}
								undoCompositeCellExpressionChange.eeOHjrbr2g.Remove(undoCompositeCellExpressionChange.mDSHlZnJjb);
								break;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto case 0;
							case 2:
								num2 = (_003C_003E1__state = -1);
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 14:
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
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
					undoCompositeCellExpressionChange = _003C_003E4__this;
					_ = 1;
					num = ((!K4iOsSKuMoASPvwgBhhq()) ? 4 : 5);
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
		internal static object DbDm4yKuYu2ablq2MnAa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VMuGlgKuUU5WDDtuNKLT(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nRMg8LKuHurGm9VYXvQN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b2ioWBKuFqpMsk1cUjtc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K4iOsSKuMoASPvwgBhhq()
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

		public UndoCompositeCellExpressionChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0166;
			IL_001a:
			int num2 = default;
			UndoCompositeCellExpressionChange undoCompositeCellExpressionChange = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = VfkD3SKuQPTtf1II8JLD(undoCompositeCellExpressionChange.dotHfiQsnO(undoCompositeCellExpressionChange.eeOHjrbr2g));
					num3 = 8;
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
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						return;
					case 6:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						if (0 == 0)
						{
							continue;
						}
						goto case 8;
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							continue;
						}
						break;
					case 1:
						return;
					case 0:
						_003C_003Eu__1 = default;
						num3 = 5;
						continue;
					case 2:
						_003C_003Eu__1 = awaiter;
						m4DwqIKumbpxhCqMcpBR();
						num3 = ((!gGagv3KuxW2aKh9lIgPC()) ? 1 : 7);
						continue;
					case 5:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
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
			goto IL_0199;
			IL_0166:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_0199;
				case 4:
					goto IL_01ae;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (m4DwqIKumbpxhCqMcpBR())
					{
					}
					continue;
				case 6:
					return;
				}
				break;
				IL_01ae:
				undoCompositeCellExpressionChange = _003C_003E4__this;
				_ = 0;
				if (!gGagv3KuxW2aKh9lIgPC())
				{
					num = 1;
					if (true)
					{
						continue;
					}
					goto IL_0199;
				}
				num = 0;
			}
			goto IL_001a;
			IL_0199:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0166;
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
		internal static TaskAwaiter VfkD3SKuQPTtf1II8JLD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gGagv3KuxW2aKh9lIgPC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m4DwqIKumbpxhCqMcpBR()
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

		public UndoCompositeCellExpressionChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WevCnCKu25KKMvI3KXel();
			int num = ((!aw6UqmKuNuCm0MYTpU0Q()) ? 5 : 4);
			int num2 = default;
			UndoCompositeCellExpressionChange undoCompositeCellExpressionChange = default;
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
							awaiter = tW12XhKucS6TRFirTNNJ(undoCompositeCellExpressionChange.Do());
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (1 == 0)
							{
								goto IL_00b6;
							}
						}
						goto IL_00f2;
						IL_00d2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_00b6:
						_003C_003Eu__1 = default;
						num3 = 8;
						if (WevCnCKu25KKMvI3KXel())
						{
							goto IL_00d2;
						}
						goto IL_00f2;
						IL_00f2:
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								if (WevCnCKu25KKMvI3KXel())
								{
								}
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								WevCnCKu25KKMvI3KXel();
								if (aw6UqmKuNuCm0MYTpU0Q())
								{
									num3 = 1;
									if (aw6UqmKuNuCm0MYTpU0Q())
									{
										continue;
									}
									return;
								}
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							default:
								return;
							case 5:
								return;
							case 0:
								break;
							case 1:
							case 3:
								goto IL_00d2;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0028;
							}
							break;
						}
						goto IL_00b6;
						end_IL_0028:;
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
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				undoCompositeCellExpressionChange = _003C_003E4__this;
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
		internal static TaskAwaiter tW12XhKucS6TRFirTNNJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aw6UqmKuNuCm0MYTpU0Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WevCnCKu25KKMvI3KXel()
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

		public UndoCompositeCellExpressionChange _003C_003E4__this;

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
			if (mEIJ80Ku1EPKA64oB4ny())
			{
				num = 3;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_003f;
				}
			}
			goto IL_01b4;
			IL_01df:
			UndoCompositeCellExpressionChange undoCompositeCellExpressionChange = _003C_003E4__this;
			num = 4;
			if (1 == 0)
			{
				return;
			}
			goto IL_01b4;
			IL_003f:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01b4;
			IL_0026:
			int num2 = _003C_003E1__state;
			goto IL_01df;
			IL_01b4:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 5:
					goto IL_003f;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = SgpAFsKuhaZG3vfyW9FS(undoCompositeCellExpressionChange.dotHfiQsnO(undoCompositeCellExpressionChange.eL9HWuEnkv));
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (UyMUUUKuuKRqNOUW4L6i())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								if (UyMUUUKuuKRqNOUW4L6i())
								{
								}
								continue;
							case 2:
								return;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									UyMUUUKuuKRqNOUW4L6i();
									if (mEIJ80Ku1EPKA64oB4ny())
									{
										num3 = 5;
										continue;
									}
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
								}
								break;
							case 3:
								_003C_003Eu__1 = default;
								goto case 6;
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
					goto IL_003f;
				default:
					num = 5;
					continue;
				case 1:
				case 2:
					goto IL_01df;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
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
		internal static TaskAwaiter SgpAFsKuhaZG3vfyW9FS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mEIJ80Ku1EPKA64oB4ny()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UyMUUUKuuKRqNOUW4L6i()
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
	private struct _003CWriteExpression_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCompositeCellExpressionChange _003C_003E4__this;

		public IEnumerable<string> names;

		private CvsCellLocation _003CcellLoc_003E5__2;

		private GroupTool _003CgroupTool_003E5__3;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			int num2 = default;
			TaskAwaiter<CvsCellCollection> awaiter = default;
			UndoCompositeCellExpressionChange undoCompositeCellExpressionChange = default;
			TaskAwaiter<object> awaiter2 = default;
			string expression = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					_003CgroupTool_003E5__3 = null;
					num = 5;
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter = ((CvsCogSocketSheet)YHUBroKhLbtFEd2Ux2lZ(undoCompositeCellExpressionChange.EnHHQtK7Pw().CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
							num3 = 11;
							goto IL_00d3;
						case 1:
							awaiter2 = _003C_003Eu__2;
							goto IL_02cc;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 17;
							goto IL_00d3;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
								goto IL_00d3;
							}
							IL_00d3:
							while (true)
							{
								switch (num3)
								{
								case 22:
									num2 = (_003C_003E1__state = 2);
									num3 = 15;
									continue;
								case 11:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										num3 = 13;
										continue;
									}
									break;
								case 16:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								default:
									num3 = 10;
									continue;
								case 4:
									break;
								case 0:
									awaiter2 = ((CvsCogSocketSheet)YHUBroKhLbtFEd2Ux2lZ(undoCompositeCellExpressionChange.EnHHQtK7Pw().CogSocket)).PutCellExpressionAsync(_003CcellLoc_003E5__2, expression).GetAwaiter();
									num3 = 20;
									continue;
								case 5:
								case 21:
									_003CcellLoc_003E5__2 = undoCompositeCellExpressionChange.TiBHEaSiqn(result, undoCompositeCellExpressionChange.VKkHRsiup9);
									num3 = 6;
									continue;
								case 7:
									result = awaiter.GetResult();
									num3 = 24;
									if (0 == 0)
									{
										continue;
									}
									goto case 20;
								case 20:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 8;
										continue;
									}
									goto IL_032a;
								case 13:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 14;
									if (0 == 0)
									{
										continue;
									}
									goto case 9;
								case 9:
									_003CgroupTool_003E5__3 = lCHMY8KhKKLj1UDoihPR(undoCompositeCellExpressionChange.SAeHM0LGkE, _003CcellLoc_003E5__2) as GroupTool;
									if (_003CgroupTool_003E5__3 != null)
									{
										num3 = 18;
										continue;
									}
									goto end_IL_0040;
								case 18:
									awaiter = ((CvsCogSocket)Y278sPKh5cDCpgpspIZx(undoCompositeCellExpressionChange.EnHHQtK7Pw())).Sheet.RunAndGetCellResults().GetAwaiter();
									num3 = 1;
									continue;
								case 10:
									return;
								case 14:
									return;
								case 15:
									_003C_003Eu__1 = awaiter;
									num3 = 2;
									continue;
								case 3:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									continue;
								case 8:
									_003C_003Eu__2 = awaiter2;
									num3 = 16;
									if (0 == 0)
									{
										continue;
									}
									goto end_IL_00d3;
								case 12:
								case 19:
									goto end_IL_00d3;
								case 2:
									goto end_IL_0041;
								case 6:
									expression = undoCompositeCellExpressionChange.jLYHcoCKG5(result, names);
									num3 = 0;
									continue;
								case 23:
									num2 = (_003C_003E1__state = -1);
									goto IL_032a;
								case 17:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 1:
									if (!awaiter.IsCompleted)
									{
										num3 = 22;
										continue;
									}
									goto case 7;
								case 24:
									{
										_003CgroupTool_003E5__3.nnG4uPQKIR(result);
										goto end_IL_0040;
									}
									IL_032a:
									awaiter2.GetResult();
									num3 = 9;
									continue;
								}
								result = awaiter.GetResult();
								_ = 1;
								num3 = (dv7FgdKuzRVyvZOldwd1() ? 19 : 21);
								continue;
								end_IL_00d3:
								break;
							}
							goto IL_02cc;
							IL_02cc:
							_003C_003Eu__2 = default;
							num3 = 23;
							if (1 == 0)
							{
								break;
							}
							goto IL_00d3;
							end_IL_0041:
							break;
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0040:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CgroupTool_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 1:
					undoCompositeCellExpressionChange = _003C_003E4__this;
					goto case 2;
				case 6:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!DXeI1fKutDwmhEEbrgo1()) ? 4 : 0);
					break;
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
		internal static object YHUBroKhLbtFEd2Ux2lZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lCHMY8KhKKLj1UDoihPR(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).WrlAbkIDX4(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Y278sPKh5cDCpgpspIZx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DXeI1fKutDwmhEEbrgo1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dv7FgdKuzRVyvZOldwd1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly InspectStepViewModel SAeHM0LGkE;

	private readonly string VKkHRsiup9;

	private readonly string uryH4T9mOC;

	private readonly string mDSHlZnJjb;

	private readonly bool C1sHTcWLh9;

	private List<string> eL9HWuEnkv;

	private List<string> eeOHjrbr2g;

	[CompilerGenerated]
	private readonly string qkjHC4tx2l;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qkjHC4tx2l;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private CvsInSight EnHHQtK7Pw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsInSight)OKxriFyWm103jMwDHvy(SAeHM0LGkE);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoCompositeCellExpressionChange(InspectStepViewModel inspect, string compositeCellName, string expressionOperator, string clauseCellName, bool append)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!MZuaBfyATQyflbfwU46())
		{
			goto IL_001e;
		}
		goto IL_0037;
		IL_001e:
		VKkHRsiup9 = compositeCellName;
		goto IL_006e;
		IL_0037:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_006e;
			case 8:
				mDSHlZnJjb = clauseCellName;
				goto case 6;
			case 1:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 0;
				continue;
			case 6:
			case 7:
				C1sHTcWLh9 = append;
				num = 9;
				if (qgBUdQyRfjoa04w98QG())
				{
				}
				continue;
			case 0:
				yHEpKKyTLQrMsthr9gp(this);
				num = 2;
				continue;
			case 2:
				goto IL_00d2;
			case 9:
				qkjHC4tx2l = (string)(append ? XmRnruy0OuvwvfSgWg7(DK21F3yFFuyyda3Rut7(), clauseCellName, compositeCellName) : XmRnruy0OuvwvfSgWg7(U2cuvSyyruaM9HyEO9O(), clauseCellName, compositeCellName));
				return;
			}
			break;
			IL_00d2:
			SAeHM0LGkE = inspect;
			_ = 1;
			num = ((!qgBUdQyRfjoa04w98QG()) ? 5 : 7);
		}
		goto IL_001e;
		IL_006e:
		uryH4T9mOC = expressionOperator;
		num = 8;
		goto IL_0037;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__13))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qgBUdQyRfjoa04w98QG();
		int num = ((!MZuaBfyATQyflbfwU46()) ? 2 : 4);
		_003CSaveState_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = Xl9ImyyMOMWpjoRlAu3();
				goto case 1;
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
		_ = 1;
		int num = (qgBUdQyRfjoa04w98QG() ? 5 : 3);
		_003CDo_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
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
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder = Xl9ImyyMOMWpjoRlAu3();
				_ = 0;
				if (MZuaBfyATQyflbfwU46())
				{
					num = 3;
					if (MZuaBfyATQyflbfwU46())
					{
						break;
					}
					goto case 2;
				}
				num = 4;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
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
		int num = 0;
		_003CUndo_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!qgBUdQyRfjoa04w98QG())
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = Xl9ImyyMOMWpjoRlAu3();
				_ = 0;
				num = ((!MZuaBfyATQyflbfwU46()) ? 3 : 4);
				continue;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
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
	[AsyncStateMachine(typeof(_003CWriteExpression_003Ed__17))]
	private Task dotHfiQsnO(IEnumerable<string> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CWriteExpression_003Ed__17 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.names = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsCellLocation TiBHEaSiqn(CvsCellCollection P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCell cvsCell = P_0.FindCellByName(P_1 ?? VKkHRsiup9);
		if (cvsCell == null)
		{
			return CvsCellLocation.Invalid;
		}
		return EIb2C1yYPo72yL8isse(cvsCell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<string> JMJHbKTs4J(CvsCellCollection P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string[] array = P_1.Split(uryH4T9mOC.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		List<string> list = new List<string>();
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			string item;
			CvsCellLocation cvsCellLocation = CvsCellLocation.TryParse(item = array2[i]);
			if (cvsCellLocation != CvsCellLocation.Invalid)
			{
				item = P_0[cvsCellLocation].Name;
			}
			list.Add(item);
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string jLYHcoCKG5(CvsCellCollection P_0, IEnumerable<string> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<string> list = new List<string>();
		foreach (string item2 in P_1)
		{
			string item = item2;
			CvsCellLocation cvsCellLocation = TiBHEaSiqn(P_0, item2);
			if (cvsCellLocation != CvsCellLocation.Invalid)
			{
				item = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
			}
			list.Add(item);
		}
		return string.Join(uryH4T9mOC, list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OKxriFyWm103jMwDHvy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MZuaBfyATQyflbfwU46()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qgBUdQyRfjoa04w98QG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yHEpKKyTLQrMsthr9gp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U2cuvSyyruaM9HyEO9O()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.wAQh4j2JE7();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XmRnruy0OuvwvfSgWg7(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DK21F3yFFuyyda3Rut7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Or2hQMrguc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Xl9ImyyMOMWpjoRlAu3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation EIb2C1yYPo72yL8isse(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}
}
