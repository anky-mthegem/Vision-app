using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class UndoSwitchLink : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoSwitch_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoSwitchLink _003C_003E4__this;

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
			if (!fyrFe9KhGu9lfjok8fXV())
			{
				num = 2;
				if (!zssF4CKhb9wL0ypLnbVg())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0353;
			IL_0056:
			UndoSwitchLink undoSwitchLink = _003C_003E4__this;
			num = 4;
			goto IL_0353;
			IL_0353:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 5:
					goto IL_0056;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = bQmSxyKhSxjcpx6IVyFk(prrmAQKhot3UL7nT6mdH(undoSwitchLink.l2gHep6Oo5, undoSwitchLink.IOVH2aEGc5));
							num3 = 4;
							goto IL_00c4;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 7;
							goto IL_00c4;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (true)
							{
								goto IL_00c4;
							}
							goto IL_022a;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								goto IL_0293;
							}
							IL_00c4:
							while (true)
							{
								switch (num3)
								{
								case 12:
									awaiter.GetResult();
									num3 = 19;
									continue;
								case 2:
									_003C_003Eu__1 = awaiter;
									goto case 17;
								default:
									num3 = 17;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								case 6:
									awaiter = bQmSxyKhSxjcpx6IVyFk(((EasyBuilderApplicationViewModel)eRqwIIKh8y4CQVjQLEPN(undoSwitchLink.l2gHep6Oo5)).ReadCurrentPropertyLinks());
									num3 = 11;
									continue;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num3 = 10;
										continue;
									}
									goto case 12;
								case 1:
									awaiter.GetResult();
									num3 = 6;
									if (!fyrFe9KhGu9lfjok8fXV())
									{
										continue;
									}
									goto case 17;
								case 17:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 7:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 1;
									continue;
								case 11:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 16;
										if (0 == 0)
										{
											continue;
										}
										goto case 9;
									}
									goto case 21;
								case 9:
									num2 = (_003C_003E1__state = -1);
									num3 = 12;
									continue;
								case 10:
									num2 = (_003C_003E1__state = 0);
									num3 = 15;
									continue;
								case 3:
								case 13:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 5:
									break;
								case 16:
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									continue;
								case 20:
									return;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 20;
									continue;
								case 14:
								case 18:
									goto IL_0293;
								case 8:
									goto IL_02ac;
								case 19:
									awaiter = bQmSxyKhSxjcpx6IVyFk(bl8bAtKhkWlYebBbhnh5(undoSwitchLink.l2gHep6Oo5, undoSwitchLink.IOVH2aEGc5, undoSwitchLink.RvAHqlm0Ab));
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 1;
								case 15:
									_003C_003Eu__1 = awaiter;
									fyrFe9KhGu9lfjok8fXV();
									if (!zssF4CKhb9wL0ypLnbVg())
									{
										num3 = 14;
										if (true)
										{
											continue;
										}
										goto case 0;
									}
									num3 = 13;
									continue;
								case 21:
									awaiter.GetResult();
									goto end_IL_0068;
								}
								break;
							}
							goto IL_022a;
							IL_0293:
							num2 = (_003C_003E1__state = -1);
							num3 = 21;
							if (zssF4CKhb9wL0ypLnbVg())
							{
								goto IL_00c4;
							}
							goto IL_02ac;
							IL_02ac:
							num2 = (_003C_003E1__state = 1);
							num3 = 2;
							goto IL_00c4;
							IL_022a:
							_003C_003Eu__1 = default;
							num3 = 9;
							goto IL_00c4;
							end_IL_0068:
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
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_0056;
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
		internal static object prrmAQKhot3UL7nT6mdH(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).RemoveLink((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter bQmSxyKhSxjcpx6IVyFk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bl8bAtKhkWlYebBbhnh5(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AddLink((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eRqwIIKh8y4CQVjQLEPN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zssF4CKhb9wL0ypLnbVg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fyrFe9KhGu9lfjok8fXV()
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
	private struct _003CUndoSwitch_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoSwitchLink _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			UndoSwitchLink undoSwitchLink = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					undoSwitchLink = _003C_003E4__this;
					b5M54GKhqRuvOiRq7N0X();
					num = ((!b5gstUKhECrVDbteZ7IW()) ? 1 : 0);
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = Njj1UMKhXirMPcRpQuRP(WLJULWKhpsmNlYtRLHGM(undoSwitchLink.l2gHep6Oo5, undoSwitchLink.IOVH2aEGc5));
							num3 = 4;
							goto IL_00c9;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 20;
							goto IL_00c9;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 10;
							if (1 == 0)
							{
								return;
							}
							goto IL_00c9;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 3;
								goto IL_00c9;
							}
							IL_00c9:
							while (true)
							{
								switch (num3)
								{
								case 7:
								case 8:
									awaiter = Njj1UMKhXirMPcRpQuRP(xeJjMAKh9U7icfkx34NS(undoSwitchLink.l2gHep6Oo5, undoSwitchLink.IOVH2aEGc5, undoSwitchLink.dudHieM7Sp));
									if (!awaiter.IsCompleted)
									{
										num3 = 14;
										continue;
									}
									goto IL_01b8;
								case 0:
									_003C_003Eu__1 = awaiter;
									goto case 16;
								default:
									num3 = 16;
									continue;
								case 1:
									_003C_003Eu__1 = awaiter;
									num3 = 6;
									continue;
								case 14:
									num2 = (_003C_003E1__state = 1);
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 17;
								case 17:
									_003C_003Eu__1 = awaiter;
									num3 = 15;
									continue;
								case 11:
									return;
								case 10:
									_003C_003Eu__1 = default;
									b5gstUKhECrVDbteZ7IW();
									num3 = ((!b5M54GKhqRuvOiRq7N0X()) ? 8 : 12);
									continue;
								case 20:
									num2 = (_003C_003E1__state = -1);
									goto IL_01b8;
								case 9:
									num2 = (_003C_003E1__state = 2);
									num3 = 17;
									continue;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 2:
									return;
								case 13:
									awaiter.GetResult();
									goto case 7;
								case 16:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 3;
								case 3:
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									continue;
								case 5:
								case 12:
									num2 = (_003C_003E1__state = -1);
									num3 = 13;
									continue;
								case 4:
									if (awaiter.IsCompleted)
									{
										goto case 13;
									}
									num3 = 18;
									if (b5M54GKhqRuvOiRq7N0X())
									{
										continue;
									}
									goto case 15;
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 2;
									continue;
								case 19:
									if (!awaiter.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									break;
								case 18:
									num2 = (_003C_003E1__state = 0);
									num3 = 1;
									if (true)
									{
										continue;
									}
									break;
								case 21:
									break;
									IL_01b8:
									awaiter.GetResult();
									awaiter = ((EasyBuilderApplicationViewModel)y7mJVFKh4KBP1lt2hZfu(undoSwitchLink.l2gHep6Oo5)).ReadCurrentPropertyLinks().GetAwaiter();
									num3 = 19;
									continue;
								}
								break;
							}
							awaiter.GetResult();
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
		internal static object WLJULWKhpsmNlYtRLHGM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).RemoveLink((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Njj1UMKhXirMPcRpQuRP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xeJjMAKh9U7icfkx34NS(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AddLink((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object y7mJVFKh4KBP1lt2hZfu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b5M54GKhqRuvOiRq7N0X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b5gstUKhECrVDbteZ7IW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly string eKyHvhqoPI;

	private readonly PropertyLinks l2gHep6Oo5;

	private readonly string IOVH2aEGc5;

	private readonly string RvAHqlm0Ab;

	private readonly string dudHieM7Sp;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eKyHvhqoPI;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoSwitchLink(PropertyLinks links, string dstName, string srcName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XiLdATycbUdCebQYW9d();
		int num = (Og4MS5y1k1vXTguDUUq() ? 2 : 3);
		CvsCellLocation cvsCellLocation = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				xVtVSHyhdAJIe8dOEJZ(this);
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				guJ2ouyua1vFYohke26();
				goto case 1;
			case 6:
				IOVH2aEGc5 = dstName;
				num = 4;
				if (XiLdATycbUdCebQYW9d())
				{
					break;
				}
				goto case 5;
			case 5:
				cvsCellLocation = vGtxaEytTkHWJP2wE09(l2gHep6Oo5, IOVH2aEGc5);
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 8;
			case 8:
				dudHieM7Sp = (string)((cvsCell != null) ? jt8OkX054GHj1T97RaA(cvsCell) : null);
				eKyHvhqoPI = (string)cDKVZv0JbcowgdLcEif(qb3eL10wSVmm4aAw3dN(), IOVH2aEGc5, RvAHqlm0Ab);
				num = 10;
				if (0 == 0)
				{
					break;
				}
				goto case 9;
			case 9:
				l2gHep6Oo5 = links;
				num = 6;
				break;
			case 4:
				RvAHqlm0Ab = srcName;
				goto case 5;
			default:
				num = 5;
				break;
			case 7:
				cvsCell = (CvsCell)ef3MQY0KDcBPOvMNmkO(((CvsResultSet)VyVYpi0L6oTRNuIeSJi(UmohSCyzCQqVv8fwdPW(l2gHep6Oo5))).Cells, cvsCellLocation);
				num = 8;
				if (1 == 0)
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoSwitch_003Ed__6))]
	private Task b4jHyi8Dbm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (Og4MS5y1k1vXTguDUUq() ? 5 : 2);
		_003CDoSwitch_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = oa5DkS0abOtWk4o9nUu();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndoSwitch_003Ed__7))]
	private Task PZKHxOBVQO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CUndoSwitch_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 0:
				stateMachine._003C_003Et__builder = oa5DkS0abOtWk4o9nUu();
				Og4MS5y1k1vXTguDUUq();
				num = (XiLdATycbUdCebQYW9d() ? 5 : 3);
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			num = 4;
			if (Og4MS5y1k1vXTguDUUq())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return b4jHyi8Dbm();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return b4jHyi8Dbm();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)WoE9GS0ecwLkteWu317();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PZKHxOBVQO();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void guJ2ouyua1vFYohke26()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xVtVSHyhdAJIe8dOEJZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation vGtxaEytTkHWJP2wE09(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyLinks)P_0).GetSourceCellLocation((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UmohSCyzCQqVv8fwdPW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VyVYpi0L6oTRNuIeSJi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ef3MQY0KDcBPOvMNmkO(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jt8OkX054GHj1T97RaA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qb3eL10wSVmm4aAw3dN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.jl5hjyWoHB();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cDKVZv0JbcowgdLcEif(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XiLdATycbUdCebQYW9d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Og4MS5y1k1vXTguDUUq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder oa5DkS0abOtWk4o9nUu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WoE9GS0ecwLkteWu317()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
