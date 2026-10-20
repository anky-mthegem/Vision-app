using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public class SnippetPreRemoveEventArgs
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshCells_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellCollection> _003C_003Et__builder;

		public SnippetPreRemoveEventArgs _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			SnippetPreRemoveEventArgs e = default;
			CvsCellCollection result = default;
			CvsCellCollection cells = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)isRyrGKiEheZgwLch4R4(XZnW5kKiqlFNQKApnb6C(e.JrhpkSA8No))).GetCellResults().GetAwaiter();
							num3 = 5;
							if (1 == 0)
							{
								goto IL_0057;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_00db;
						IL_00db:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 6:
							case 8:
								result = awaiter.GetResult();
								num3 = 7;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 6;
							case 7:
								e.Cells = result;
								num3 = 10;
								if (jaYX9kKikJRLR0MsGhJE())
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								jaYX9kKikJRLR0MsGhJE();
								num3 = (iM5P3iKi8WbmdbCJopi5() ? 8 : 2);
								continue;
							case 2:
							case 4:
								return;
							case 9:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto case 6;
							case 10:
								cells = e.Cells;
								goto end_IL_00db;
							}
							goto IL_0057;
							continue;
							end_IL_00db:
							break;
						}
						goto end_IL_0029;
						IL_0057:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						goto IL_00db;
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
					_003C_003Et__builder.SetResult(cells);
					num = 6;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					break;
				case 6:
					return;
				}
				e = _003C_003E4__this;
				_ = 1;
				if (iM5P3iKi8WbmdbCJopi5())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (1 == 0)
				{
					break;
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
		internal static object XZnW5kKiqlFNQKApnb6C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object isRyrGKiEheZgwLch4R4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jaYX9kKikJRLR0MsGhJE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iM5P3iKi8WbmdbCJopi5()
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
	private struct _003CAddUndo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SnippetPreRemoveEventArgs _003C_003E4__this;

		public IUndoAction action;

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
			TaskAwaiter awaiter = default;
			SnippetPreRemoveEventArgs e = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 11;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 8;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 10;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								if (e.KGfpiTHWyO == null)
								{
									num3 = 5;
									continue;
								}
								awaiter = jVepEbKi4l4u5BDHxY7k(mrtChsKi9AQBGpm0i3tr(action));
								num3 = 15;
								continue;
							case 2:
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 14:
								return;
							case 7:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								if (!L5Y6RKKiXokQirKjC4F8())
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								_ = 1;
								num3 = (L5Y6RKKiXokQirKjC4F8() ? 2 : 12);
								continue;
							case 0:
								num2 = (_003C_003E1__state = 1);
								goto case 2;
							case 16:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								continue;
							case 1:
								return;
							case 5:
								throw new NotSupportedException();
							case 8:
								_003C_003Eu__1 = default;
								num3 = 16;
								continue;
							case 13:
								if (!awaiter.IsCompleted)
								{
									goto case 0;
								}
								goto case 4;
							default:
								num3 = 0;
								continue;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								}
								goto case 6;
							case 6:
							case 12:
								awaiter.GetResult();
								awaiter = ((Task)wqeioEKi7gHPgBnCA8S8(action)).GetAwaiter();
								num3 = 13;
								continue;
							case 4:
								awaiter.GetResult();
								num3 = 17;
								continue;
							case 17:
								e.KGfpiTHWyO.Add(action);
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
					goto default;
				case 1:
				case 2:
					e = _003C_003E4__this;
					num = 5;
					if (VC8BgqKip6oXI3NLmsFD())
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					L5Y6RKKiXokQirKjC4F8();
					if (!VC8BgqKip6oXI3NLmsFD())
					{
						num = 4;
						if (L5Y6RKKiXokQirKjC4F8())
						{
						}
					}
					else
					{
						num = 2;
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
		internal static object mrtChsKi9AQBGpm0i3tr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter jVepEbKi4l4u5BDHxY7k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wqeioEKi7gHPgBnCA8S8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VC8BgqKip6oXI3NLmsFD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L5Y6RKKiXokQirKjC4F8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private List<IUndoAction> KGfpiTHWyO;

	private CvsInSight JrhpkSA8No;

	[CompilerGenerated]
	private CvsCellCollection tHApPd0UHt;

	[CompilerGenerated]
	private EzSnippet HMApsIyVEf;

	public CvsCellCollection Cells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tHApPd0UHt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tHApPd0UHt = value;
		}
	}

	public EzSnippet Snippet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HMApsIyVEf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HMApsIyVEf = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnippetPreRemoveEventArgs(CvsCellCollection cells, EzSnippet snippet, List<IUndoAction> actions)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector();
		Cells = cells;
		Snippet = snippet;
		JrhpkSA8No = snippet.InSight;
		KGfpiTHWyO = actions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshCells_003Ed__3))]
	public Task<CvsCellCollection> RefreshCells()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRefreshCells_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellCollection>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddUndo_003Ed__12))]
	public Task AddUndo(IUndoAction action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CAddUndo_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
				stateMachine._003C_003Et__builder = GMuwiLwMtxUEJwQEHhV();
				ab34JCw0DwDjxYQrR4K();
				num = ((!MpnBmtwFLHdOOqsdWSd()) ? 5 : 4);
				break;
			case 2:
			case 4:
				stateMachine.action = action;
				goto case 6;
			default:
				num = 6;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ab34JCw0DwDjxYQrR4K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MpnBmtwFLHdOOqsdWSd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GMuwiLwMtxUEJwQEHhV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
