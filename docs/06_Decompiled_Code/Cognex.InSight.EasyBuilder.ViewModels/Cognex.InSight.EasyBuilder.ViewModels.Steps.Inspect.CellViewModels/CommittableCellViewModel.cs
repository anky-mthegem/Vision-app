using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Cell;
using Cognex.InSight.Common.PropertyCommitters;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public abstract class CommittableCellViewModel<TDataType> : CellViewModel where TDataType : struct, IEquatable<TDataType>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCommitToDeviceBlockingAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommittableCellViewModel<TDataType> _003C_003E4__this;

		public TDataType currentValue;

		public TDataType previousValue;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			CommittableCellViewModel<TDataType> committableCellViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((1 == 0) ? 5 : 4);
					break;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					committableCellViewModel = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						if (num2 != 0)
						{
							if (committableCellViewModel.ProgressManager == null)
							{
								throw new NullReferenceException(CdQUGaROfy7He9T0foW.KbIzwHEDLa(51056));
							}
							_003C_003E7__wrap1 = committableCellViewModel.ProgressManager.StartBlockingOperation(Resources.dk2nkhoeRb());
						}
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = committableCellViewModel.baOwqaTSXM(currentValue, previousValue).GetAwaiter();
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
								case 5:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 3:
									_003C_003Eu__1 = default;
									goto case 5;
								case 4:
									num2 = (_003C_003E1__state = 0);
									_ = 0;
									num3 = (true ? 8 : 5);
									continue;
								case 2:
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 7;
									continue;
								case 0:
									if (!awaiter.IsCompleted)
									{
										num3 = 4;
										continue;
									}
									break;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 1;
									continue;
								case 1:
									return;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								_003C_003E7__wrap1.Dispose();
							}
						}
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
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
		internal static bool oRIlmYKhHZTG495QGWBL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YLgrKqKhxxMCMQr3l07R()
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
	private struct _003CCommitToDeviceAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommittableCellViewModel<TDataType> _003C_003E4__this;

		public TDataType previousValue;

		public TDataType currentValue;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (true ? 1 : 2);
			CommittableCellViewModel<TDataType> committableCellViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoEditCellChange<TDataType> undoEditCellChange = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					committableCellViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 6;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 5;
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
							case 15:
								awaiter.GetResult();
								num3 = 11;
								continue;
							case 1:
							case 12:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							case 3:
								awaiter = committableCellViewModel.InSight.UndoHandler.AddUndo(undoEditCellChange).GetAwaiter();
								num3 = 7;
								continue;
							case 9:
								return;
							case 6:
								undoEditCellChange = new UndoEditCellChange<TDataType>(committableCellViewModel.InSight, committableCellViewModel.CellName, previousValue, currentValue, string.Format(Resources.pd1hOYqP56(), committableCellViewModel.CellName, previousValue, currentValue));
								num3 = 16;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								goto case 15;
							default:
								num3 = 15;
								continue;
							case 16:
								if (committableCellViewModel.IsInitialized)
								{
									num3 = 3;
									continue;
								}
								awaiter = undoEditCellChange.Do().GetAwaiter();
								num3 = 10;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 1);
								_ = 0;
								num3 = (true ? 1 : 2);
								continue;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								break;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 11:
								goto end_IL_0110;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									continue;
								}
								goto case 15;
							case 2:
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 17:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0110:
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
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static bool PRtLJPKhmiv4UJkkNZin()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kIrohmKhQVmIgiu81b3Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected readonly IPropertyCommitter<TDataType> Committer;

	protected readonly IOperationProgressManager ProgressManager;

	[CompilerGenerated]
	private Task RTiwPGYTJG;

	public Task CommitTask
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RTiwPGYTJG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RTiwPGYTJG = value;
		}
	}

	public bool IsCommitting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !CommitTask.IsCompleted;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CommittableCellViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, IPropertyCommitter<TDataType> customCommitter = null, IOperationProgressManager operationProgressManager = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		this._002Ector(insight, cells, loc, displayName, true, customCommitter, operationProgressManager);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CommittableCellViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, bool isInitialized = true, IPropertyCommitter<TDataType> customCommitter = null, IOperationProgressManager operationProgressManager = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		RTiwPGYTJG = Task.CompletedTask;
		base._002Ector(insight, loc, displayName, isInitialized);
		ProgressManager = operationProgressManager;
		Committer = customCommitter ?? oDQweLaHas();
		Refresh(cells, init: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IPropertyCommitter<TDataType> oDQweLaHas()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return InternalCreateDefaultCommitter(iDqwi40iU8());
	}

	protected abstract IPropertyCommitter<TDataType> InternalCreateDefaultCommitter(Func<TDataType, TDataType, Task> commitToDeviceTask);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private Func<TDataType, TDataType, Task> iDqwi40iU8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ProgressManager == null)
		{
			return baOwqaTSXM;
		}
		return OLuw2OtOgK;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(CommittableCellViewModel<>._003CCommitToDeviceBlockingAsync_003Ed__14))]
	private Task OLuw2OtOgK(TDataType HFBnEuH69OxlujtZVR, TDataType KneSSqm4f4gHJKBHi5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCommitToDeviceBlockingAsync_003Ed__14 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.currentValue = HFBnEuH69OxlujtZVR;
		stateMachine.previousValue = KneSSqm4f4gHJKBHi5;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(CommittableCellViewModel<>._003CCommitToDeviceAsync_003Ed__15))]
	private Task baOwqaTSXM(TDataType feGF49QsY4gM266BuQ, TDataType qnGMrIwHjI1TnBXdbm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCommitToDeviceAsync_003Ed__15 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.currentValue = feGF49QsY4gM266BuQ;
		stateMachine.previousValue = qnGMrIwHjI1TnBXdbm;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ch6ap3FSGUXjkY7hK6r()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o6nMewFkJbV9RZfjU0s()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
