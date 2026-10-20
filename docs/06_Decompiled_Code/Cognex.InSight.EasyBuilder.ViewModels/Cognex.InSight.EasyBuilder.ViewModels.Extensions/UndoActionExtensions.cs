using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Extensions;

public static class UndoActionExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddUndoBackground_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UndoHandler handler;

		public IUndoAction action;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gWcXUt5P1Pb3E3UlkpXf();
			int num = (qFD5VN5PcOHSCteS1e14() ? 1 : 4);
			int num2 = default;
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
							awaiter = ((Task)tYHeQn5PuyvLniTFF85o(handler, action)).GetAwaiter();
							num3 = 7;
							if (false)
							{
								goto IL_0051;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						goto IL_00b3;
						IL_00b3:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 0:
								_003C_003Eu__1 = default;
								goto case 6;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								gWcXUt5P1Pb3E3UlkpXf();
								if (!qFD5VN5PcOHSCteS1e14())
								{
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 3;
								}
								num3 = 5;
								if (gWcXUt5P1Pb3E3UlkpXf())
								{
								}
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
							case 5:
								return;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_00b3;
							}
							goto IL_0051;
							continue;
							end_IL_00b3:
							break;
						}
						goto end_IL_0028;
						IL_0051:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						goto IL_00b3;
						end_IL_0028:;
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
					num = 5;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					if (1 == 0)
					{
						return;
					}
					break;
				case 5:
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
		internal static object tYHeQn5PuyvLniTFF85o(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qFD5VN5PcOHSCteS1e14()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gWcXUt5P1Pb3E3UlkpXf()
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
	private struct _003CDoBackground_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public IUndoAction action;

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
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					if (ab6iD45Ph7EVx5SWlJNk())
					{
						num = 4;
						break;
					}
					num = 0;
					if (BgR1xn5Pt22xChDoZuYl())
					{
					}
					break;
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = nrwxHd5ZLtujoa4D0tVY(Eh71QE5PzLCYGW3UyNDM(action));
							num3 = 4;
							if (false)
							{
								goto IL_006d;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							default:
								num3 = 7;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									ab6iD45Ph7EVx5SWlJNk();
									num3 = (BgR1xn5Pt22xChDoZuYl() ? 8 : 0);
									continue;
								}
								goto case 9;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 0:
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (ab6iD45Ph7EVx5SWlJNk())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								goto case 6;
							case 7:
								return;
							case 9:
								awaiter.GetResult();
								goto end_IL_008d;
							}
							goto IL_006d;
							continue;
							end_IL_008d:
							break;
						}
						goto end_IL_004a;
						IL_006d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
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
				case 5:
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
		internal static object Eh71QE5PzLCYGW3UyNDM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter nrwxHd5ZLtujoa4D0tVY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ab6iD45Ph7EVx5SWlJNk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BgR1xn5Pt22xChDoZuYl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddUndoBackground_003Ed__0))]
	public static void AddUndoBackground(this UndoHandler handler, IUndoAction action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Hk5I55KwsS0VomOpq4kc())
		{
			num = 6;
		}
		else
		{
			num = 5;
			if (Hk5I55KwsS0VomOpq4kc())
			{
			}
		}
		_003CAddUndoBackground_003Ed__0 stateMachine = default;
		do
		{
			IL_0076:
			switch (num)
			{
			case 3:
				stateMachine.handler = handler;
				goto case 2;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				num = 3;
				goto IL_0076;
			case 2:
			case 5:
				stateMachine.action = action;
				break;
			default:
				num = 4;
				goto IL_0076;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				goto IL_0076;
			case 4:
				break;
			case 7:
				return;
			}
			stateMachine._003C_003E1__state = -1;
			num = 1;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoBackground_003Ed__1))]
	public static void DoBackground(this IUndoAction action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Y5etTxKwgcuUGvMMBIJS();
		int num;
		if (!Hk5I55KwsS0VomOpq4kc())
		{
			num = 1;
			if (!Y5etTxKwgcuUGvMMBIJS())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0048;
		IL_0089:
		_003CDoBackground_003Ed__1 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = rUFkciKwvedl5D8xlXpa();
				num = 3;
				continue;
			case 4:
				goto IL_0089;
			case 3:
				stateMachine.action = action;
				break;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003E1__state = -1;
		goto IL_0089;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Y5etTxKwgcuUGvMMBIJS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Hk5I55KwsS0VomOpq4kc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder rUFkciKwvedl5D8xlXpa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}
}
