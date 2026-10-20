using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.UndoActions;

public class UndoRemoveClass : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveClass _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nu43lldahPvYfUkqfI1();
			int num;
			if (MEesBrd3KrN3aSPpjNt())
			{
				num = 4;
				if (!MEesBrd3KrN3aSPpjNt())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01b1;
			IL_002e:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_01b1;
			IL_01b1:
			UndoRemoveClass undoRemoveClass = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!nu43lldahPvYfUkqfI1())
					{
						continue;
					}
					goto case 1;
				case 1:
					undoRemoveClass = _003C_003E4__this;
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((IUndoAction)undoRemoveClass).Redo().GetAwaiter();
							_ = 1;
							num3 = (nu43lldahPvYfUkqfI1() ? 2 : 4);
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
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 3:
								return;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (MEesBrd3KrN3aSPpjNt())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 0:
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
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
		internal static bool MEesBrd3KrN3aSPpjNt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nu43lldahPvYfUkqfI1()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveClass _003C_003E4__this;

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
			if (x3O6AodosHgPq31NdKl())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (MQr1I8dcplkddpOuLFA())
				{
				}
			}
			UndoRemoveClass undoRemoveClass = default;
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					undoRemoveClass = _003C_003E4__this;
					num = 3;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)t6nvM1dutG9yBZNwIyO(undoRemoveClass.D3M2BJffSV);
							num3 = 2;
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
								awaiter = PLoClWdBDKL0VrVxuFE(classifier._DoDeleteClass(undoRemoveClass.SVo2eJXvpU, null));
								num3 = 1;
								if (MQr1I8dcplkddpOuLFA())
								{
								}
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_ = 0;
									if (x3O6AodosHgPq31NdKl())
									{
										num3 = 0;
										continue;
									}
									num3 = 4;
									if (x3O6AodosHgPq31NdKl())
									{
										continue;
									}
								}
								break;
							case 2:
								if (classifier != null)
								{
									num3 = 7;
									continue;
								}
								goto end_IL_0126;
							case 4:
								return;
							case 5:
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (!MQr1I8dcplkddpOuLFA())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 0:
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0126:
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
					break;
				case 0:
				case 5:
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
		internal static object t6nvM1dutG9yBZNwIyO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter PLoClWdBDKL0VrVxuFE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x3O6AodosHgPq31NdKl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MQr1I8dcplkddpOuLFA()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DSaveState_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveClass _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			D896VjdxFUqSLElVvKS();
			int num;
			if (!BF6gXLdh6k7ZGkJtyg5())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_01fb;
				}
			}
			goto IL_01c8;
			IL_01c8:
			int num2 = default;
			CvsCellLocation cellLocation = default;
			UndoRemoveClass undoRemoveClass = default;
			TaskAwaiter<byte[]> awaiter = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cellLocation = undoRemoveClass.D3M2BJffSV.GetCellLocation();
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								return;
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 10;
							default:
								num3 = 10;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								goto case 8;
							case 8:
							case 9:
								result = awaiter.GetResult();
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (cellLocation.IsValid)
								{
									BF6gXLdh6k7ZGkJtyg5();
									if (!D896VjdxFUqSLElVvKS())
									{
										num3 = 9;
										if (D896VjdxFUqSLElVvKS())
										{
											continue;
										}
										goto case 8;
									}
									num3 = 3;
									continue;
								}
								break;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 8;
							case 1:
							case 3:
								awaiter = ((CvsCogSocket)Qfd5ZpdU7FAr5e41LGy(undoRemoveClass.Bj22lLo4OJ)).Sheet.CopyCellsAsync(new CvsCellRange(cellLocation)).GetAwaiter();
								num3 = 6;
								continue;
							case 11:
								undoRemoveClass.TJY23nX8J5 = result;
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
				case 1:
					undoRemoveClass = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					if (D896VjdxFUqSLElVvKS())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_01fb;
			IL_01fb:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01c8;
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
		internal static object Qfd5ZpdU7FAr5e41LGy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D896VjdxFUqSLElVvKS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BF6gXLdh6k7ZGkJtyg5()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveClass _003C_003E4__this;

		private Classifier _003Cclassifier_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			UndoRemoveClass undoRemoveClass = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			CvsCellLocation location = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					undoRemoveClass = _003C_003E4__this;
					g9UyWcdqIdUL0VEoNrI();
					if (vlKO6DdQNTj7NoLITgO())
					{
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto default;
					}
					num = 6;
					if (1 == 0)
					{
						return;
					}
					break;
				default:
					_003Cclassifier_003E5__2 = null;
					num = 1;
					if (!g9UyWcdqIdUL0VEoNrI())
					{
						break;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					if (vlKO6DdQNTj7NoLITgO())
					{
						break;
					}
					goto case 1;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 2;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 0;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							g9UyWcdqIdUL0VEoNrI();
							num3 = (vlKO6DdQNTj7NoLITgO() ? 8 : 6);
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 16:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 2:
								_003Cclassifier_003E5__2 = (Classifier)QMHOWJdVoh3rV5g4OrZ(undoRemoveClass.D3M2BJffSV);
								num3 = 14;
								continue;
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								continue;
							case 4:
								return;
							case 17:
								if (location.IsValid)
								{
									num3 = 15;
									continue;
								}
								goto end_IL_0224;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 11:
								awaiter = vpw4VZdLoJmuKWiIZQm(_003Cclassifier_003E5__2.Refresh());
								num3 = 16;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								goto case 6;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 12;
									continue;
								}
								goto IL_02b0;
							case 3:
								if (_003Cclassifier_003E5__2 != null)
								{
									num3 = 17;
									continue;
								}
								goto end_IL_0224;
							case 15:
								awaiter = undoRemoveClass.Bj22lLo4OJ.CogSocket.Sheet.InternalPasteCellsAsync(new CvsCellRange(location), undoRemoveClass.TJY23nX8J5, cutFromSameSheet: false, runSheet: true).GetAwaiter();
								num3 = 7;
								continue;
							case 6:
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 1:
								return;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 14:
								location = C7SfntdimNqK1WCutXn(undoRemoveClass.D3M2BJffSV);
								num3 = 3;
								if (vlKO6DdQNTj7NoLITgO())
								{
									continue;
								}
								goto case 8;
							case 8:
							case 9:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02b0;
							case 18:
								break;
								IL_02b0:
								awaiter.GetResult();
								num3 = 11;
								continue;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0224:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cclassifier_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
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
		internal static object QMHOWJdVoh3rV5g4OrZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation C7SfntdimNqK1WCutXn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetCellLocation();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vpw4VZdLoJmuKWiIZQm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vlKO6DdQNTj7NoLITgO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g9UyWcdqIdUL0VEoNrI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsInSight Bj22lLo4OJ;

	private IClassifierHandle D3M2BJffSV;

	private ClassViewModel SVo2eJXvpU;

	private Func<string, Task<bool>> DwY2txN8La;

	private byte[] TJY23nX8J5;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)BlwN5EM1U7BRDZQHPVa(), fmAyvmMSbQvutJE2e75(SVo2eJXvpU));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoRemoveClass(CvsInSight insight, IClassifierHandle handle, ClassViewModel item, Func<string, Task<bool>> confirmationCallback)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector();
		Bj22lLo4OJ = insight;
		D3M2BJffSV = handle;
		SVo2eJXvpU = item;
		DwY2txN8La = confirmationCallback;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8))]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				if (W37LJ7M4QN2Zuq1g5YN())
				{
					num = 4;
					if (LxayLAMgwJMuT7QEfvr())
					{
					}
				}
				else
				{
					num = 5;
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__9))]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E4__this = this;
				W37LJ7M4QN2Zuq1g5YN();
				if (!LxayLAMgwJMuT7QEfvr())
				{
					num = 1;
					if (W37LJ7M4QN2Zuq1g5YN())
					{
						break;
					}
					goto case 4;
				}
				num = 0;
				break;
			case 4:
				stateMachine._003C_003Et__builder = NOm5juM6sadxnLldXch();
				num = 5;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
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
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DSaveState_003Ed__10))]
	Task IUndoAction.SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DSaveState_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 3:
				stateMachine._003C_003Et__builder = NOm5juM6sadxnLldXch();
				LxayLAMgwJMuT7QEfvr();
				num = (W37LJ7M4QN2Zuq1g5YN() ? 5 : 4);
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__11))]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = NOm5juM6sadxnLldXch();
				LxayLAMgwJMuT7QEfvr();
				if (W37LJ7M4QN2Zuq1g5YN())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (LxayLAMgwJMuT7QEfvr())
				{
				}
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
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
	internal static object BlwN5EM1U7BRDZQHPVa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.RemoveClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fmAyvmMSbQvutJE2e75(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassViewModel)P_0).ClassName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W37LJ7M4QN2Zuq1g5YN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LxayLAMgwJMuT7QEfvr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder NOm5juM6sadxnLldXch()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
