using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class AddToolUndoAction : AddSnippetUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUndo_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AddToolUndoAction _003C_003E4__this;

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
			AddToolUndoAction addToolUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					if (z1ZoctK21ZmbPoXv6GgG())
					{
						num = 5;
						if (z1ZoctK21ZmbPoXv6GgG())
						{
							continue;
						}
						goto default;
					}
					num = 0;
					if (!mXLrjnK2unsR8tQketCR())
					{
						continue;
					}
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = WVkagkK2h3RbRnRVUUFh(new DeleteToolUndoAction((InspectStepViewModel)addToolUndoAction.AppStepVm, addToolUndoAction.SnippetName).Do());
							mXLrjnK2unsR8tQketCR();
							if (z1ZoctK21ZmbPoXv6GgG())
							{
								num3 = 6;
								if (false)
								{
									goto IL_0093;
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
							num3 = 8;
						}
						goto IL_00cf;
						IL_0146:
						num2 = (_003C_003E1__state = 0);
						num3 = 5;
						if (mXLrjnK2unsR8tQketCR())
						{
						}
						goto IL_00cf;
						IL_0093:
						if (!awaiter.IsCompleted)
						{
							goto IL_0146;
						}
						goto IL_017b;
						IL_017b:
						awaiter.GetResult();
						goto end_IL_0050;
						IL_00cf:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 6:
								break;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								if (z1ZoctK21ZmbPoXv6GgG())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
								return;
							case 1:
							case 7:
								goto IL_0146;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto IL_017b;
							case 9:
								goto IL_017b;
							}
							break;
						}
						goto IL_0093;
						end_IL_0050:;
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
				case 5:
					break;
				case 6:
					return;
				}
				addToolUndoAction = _003C_003E4__this;
				num = 2;
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
		internal static TaskAwaiter WVkagkK2h3RbRnRVUUFh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z1ZoctK21ZmbPoXv6GgG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mXLrjnK2unsR8tQketCR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly string VtaOCrGp5T;

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VtaOCrGp5T;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddToolUndoAction(InspectStepViewModel inspect, CvsCellRange range, string snippetName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (rabb3STH0Ol3bxiPT28())
		{
			goto IL_001e;
		}
		goto IL_006f;
		IL_001e:
		VtaOCrGp5T = string.Format(Resources.b68hXT30ZK(), snippetName);
		num = 5;
		goto IL_006f;
		IL_006f:
		while (true)
		{
			switch (num)
			{
			case 4:
				jMawB2Tx8bUZN4fCcAZ();
				_ = 1;
				num = ((!rabb3STH0Ol3bxiPT28()) ? 3 : 0);
				continue;
			case 1:
			case 3:
				base._002Ector(inspect, range, snippetName);
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__4))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CUndo_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (QjBAtGTU7mhWnfhkcip() ? 4 : 0);
				break;
			case 1:
				stateMachine._003C_003Et__builder = onHbG9TmSHgvlNoFpgA();
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jMawB2Tx8bUZN4fCcAZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QjBAtGTU7mhWnfhkcip()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rabb3STH0Ol3bxiPT28()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder onHbG9TmSHgvlNoFpgA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
