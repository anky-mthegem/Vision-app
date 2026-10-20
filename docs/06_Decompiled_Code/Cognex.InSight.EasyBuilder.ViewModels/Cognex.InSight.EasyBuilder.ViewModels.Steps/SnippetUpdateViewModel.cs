using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.Mvvm;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps;

public class SnippetUpdateViewModel : BroadcastingViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateSnippet_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SnippetUpdateViewModel _003C_003E4__this;

		public Guid guid;

		public CvsCellCollection cells;

		public CvsCellRange range;

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
			TaskAwaiter awaiter = default;
			SnippetUpdateViewModel snippetUpdateViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							goto IL_00b5;
						}
						if (snippetUpdateViewModel.NeedsUpdate(guid, cells, range))
						{
							num3 = 3;
							goto IL_00b5;
						}
						goto end_IL_003e;
						IL_00b5:
						while (true)
						{
							switch (num3)
							{
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (XRqf34KdH0EAH32mXxF1())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								qNEIcOKdxSg9qJ9wR6tw();
								if (XRqf34KdH0EAH32mXxF1())
								{
									num3 = 6;
									if (!qNEIcOKdxSg9qJ9wR6tw())
									{
										continue;
									}
									goto case 7;
								}
								num3 = 9;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 3:
								awaiter = snippetUpdateViewModel.dX1UilvXCm(guid, cells, range).GetAwaiter();
								num3 = 8;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 4:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 9:
								return;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_003e:;
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
					break;
				case 6:
					return;
				}
				do
				{
					snippetUpdateViewModel = _003C_003E4__this;
					_ = 1;
					if (qNEIcOKdxSg9qJ9wR6tw())
					{
						num = 5;
						continue;
					}
					num = 4;
					if (XRqf34KdH0EAH32mXxF1())
					{
						break;
					}
					return;
				}
				while (1 == 0);
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
		internal static bool XRqf34KdH0EAH32mXxF1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qNEIcOKdxSg9qJ9wR6tw()
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
	private struct _003CUpdate_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SnippetUpdateViewModel _003C_003E4__this;

		public Guid guid;

		public CvsCellCollection cells;

		public CvsCellRange range;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			SnippetUpdateViewModel snippetUpdateViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					snippetUpdateViewModel = _003C_003E4__this;
					num = 0;
					break;
				case 0:
					try
					{
						if (num2 == 0)
						{
							goto IL_0077;
						}
						TaskAwaiter awaiter;
						if (num2 != 1)
						{
							IOperationProgressManager oHhUPp1aVD = snippetUpdateViewModel.oHhUPp1aVD;
							if (oHhUPp1aVD != null && !xFn1F9KdNXUD478NIW9c(oHhUPp1aVD))
							{
								IOperationProgressManager oHhUPp1aVD2 = snippetUpdateViewModel.oHhUPp1aVD;
								_003C_003E7__wrap1 = (ITopLevelProgressableOperation)((oHhUPp1aVD2 != null) ? sZw75XKdcqWSHdIyOuvS(oHhUPp1aVD2, RUREhXKd2UehfloYRPwK(), Array.Empty<StepDescriptor>()) : null);
								goto IL_0077;
							}
							awaiter = snippetUpdateViewModel.ymFUkbpkRU.UpdateSnippet(guid, cells, range).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
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
						goto end_IL_0029;
						IL_0077:
						try
						{
							int num3;
							if (num2 != 0)
							{
								awaiter = pYetKEKduGFyxACCmpfe(ecIqhgKd1wIrsuMsFWCN(snippetUpdateViewModel.ymFUkbpkRU, guid, cells, range));
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
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									continue;
								case 4:
									return;
								case 1:
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 2;
									continue;
								case 5:
									if (awaiter.IsCompleted)
									{
										break;
									}
									_ = 1;
									if (!Xcul5KKdQAJSkQVwZI61())
									{
										num3 = 8;
										continue;
									}
									num3 = 0;
									if (qiymeYKdm67GVS5PotTd())
									{
										continue;
									}
									goto case 0;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 4;
									continue;
								case 7:
									_003C_003Eu__1 = default;
									goto case 0;
								case 0:
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
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								GEDU7qKdhWtW3al92ln6(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
						end_IL_0029:;
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
					if (Xcul5KKdQAJSkQVwZI61())
					{
					}
					break;
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					if (Xcul5KKdQAJSkQVwZI61())
					{
						num = 4;
						break;
					}
					num = 2;
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
		internal static bool xFn1F9KdNXUD478NIW9c(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).HasOperationsPending;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RUREhXKd2UehfloYRPwK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.AMwhYPy1Il();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sZw75XKdcqWSHdIyOuvS(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ecIqhgKd1wIrsuMsFWCN(object P_0, Guid guid, object P_2, CvsCellRange snippetRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISnippetOwner)P_0).UpdateSnippet(guid, (CvsCellCollection)P_2, snippetRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pYetKEKduGFyxACCmpfe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GEDU7qKdhWtW3al92ln6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qiymeYKdm67GVS5PotTd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xcul5KKdQAJSkQVwZI61()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ISnippetOwner ymFUkbpkRU;

	private readonly IOperationProgressManager oHhUPp1aVD;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnippetUpdateViewModel(ISnippetOwner snippetOwner, IOperationProgressManager operationManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (ckxVyGeURXWdAnaJ1oO() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				qa2WSfeQCuQUrq5UunN(this, QZsqEoemHNbWyw7eQXH());
				goto case 2;
			case 0:
			case 1:
				Myedl6exDJU8WYClQ9v();
				num = 3;
				continue;
			case 2:
			case 4:
				ymFUkbpkRU = snippetOwner;
				break;
			default:
				num = 5;
				if (b78lRmeHAG4Z50C2xVh())
				{
				}
				continue;
			case 5:
				break;
			case 6:
				return;
			}
			oHhUPp1aVD = operationManager;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnippetUpdateViewModel(ISnippetOwner snippetOwner)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		this._002Ector(snippetOwner, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool NeedsUpdate(Guid guid, CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (f9hpePeNgwIVSGhgCct(ymFUkbpkRU, guid))
		{
			return ymFUkbpkRU.SnippetNeedsUpdate(guid, cells, range);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateSnippet_003Ed__5))]
	public Task UpdateSnippet(Guid guid, CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ckxVyGeURXWdAnaJ1oO();
		int num = (b78lRmeHAG4Z50C2xVh() ? 8 : 4);
		_003CUpdateSnippet_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.guid = guid;
				num = 7;
				if (!b78lRmeHAG4Z50C2xVh())
				{
					break;
				}
				goto case 6;
			case 6:
			case 8:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 6;
			case 3:
				stateMachine.range = range;
				num = 5;
				break;
			case 7:
				stateMachine.cells = cells;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdate_003Ed__6))]
	private Task dX1UilvXCm(Guid P_0, CvsCellCollection P_1, CvsCellRange P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!ckxVyGeURXWdAnaJ1oO())
		{
			goto IL_001e;
		}
		goto IL_0052;
		IL_001e:
		_003CUpdate_003Ed__6 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_00b1;
		IL_0052:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 0:
				stateMachine.cells = P_1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				b78lRmeHAG4Z50C2xVh();
				if (!ckxVyGeURXWdAnaJ1oO())
				{
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				num = 8;
				if (!b78lRmeHAG4Z50C2xVh())
				{
					continue;
				}
				goto IL_00b1;
			case 6:
			case 7:
				goto IL_00b1;
			case 2:
			case 8:
				stateMachine.guid = P_0;
				num = 0;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = f9xhU9e2Mqa5otlO0FM();
				num = 1;
				if (ckxVyGeURXWdAnaJ1oO())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine.range = P_2;
				num = 5;
				continue;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_00b1:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 9;
		goto IL_0052;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Myedl6exDJU8WYClQ9v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QZsqEoemHNbWyw7eQXH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ViewModelBroadcaster.Default;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qa2WSfeQCuQUrq5UunN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BroadcastingViewModel)P_0)._002Ector((IViewModelBroadcaster)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ckxVyGeURXWdAnaJ1oO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b78lRmeHAG4Z50C2xVh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f9hpePeNgwIVSGhgCct(object P_0, Guid guid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ISnippetOwner)P_0).Supports(guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder f9xhU9e2Mqa5otlO0FM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
