using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public abstract class BaseSnippetAddRemoveAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveSnippet_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BaseSnippetAddRemoveAction _003C_003E4__this;

		public CvsCellRange snippetRange;

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
			BaseSnippetAddRemoveAction baseSnippetAddRemoveAction = default;
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
							awaiter = ((CvsInSight)DJIfTKKwccLV9GTYclAa(baseSnippetAddRemoveAction.Step)).UndoHandler.SendCopyAsync(snippetRange).GetAwaiter();
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (false)
							{
								goto IL_0061;
							}
						}
						goto IL_0118;
						IL_0061:
						result = awaiter.GetResult();
						num3 = 10;
						goto IL_0118;
						IL_0118:
						while (true)
						{
							switch (num3)
							{
							case 8:
								return;
							case 3:
								break;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							case 7:
								_003C_003Eu__1 = default;
								goto case 5;
							case 1:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 5:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								if (D3wDmqKw2uxAavcsCpOp())
								{
								}
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								M3SYxxKwNrlqdUMGOc3y();
								if (D3wDmqKw2uxAavcsCpOp())
								{
									num3 = 5;
									if (true)
									{
										continue;
									}
									goto case 1;
								}
								num3 = 1;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 10:
								baseSnippetAddRemoveAction.orVU5KlR2 = result;
								goto end_IL_0118;
							}
							goto IL_0061;
							continue;
							end_IL_0118:
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
					num2 = _003C_003E1__state;
					D3wDmqKw2uxAavcsCpOp();
					num = ((!M3SYxxKwNrlqdUMGOc3y()) ? 3 : 5);
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 5:
					baseSnippetAddRemoveAction = _003C_003E4__this;
					goto case 2;
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
		internal static object DJIfTKKwccLV9GTYclAa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M3SYxxKwNrlqdUMGOc3y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D3wDmqKw2uxAavcsCpOp()
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
	private struct _003CPasteAndParseSnippet_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BaseSnippetAddRemoveAction _003C_003E4__this;

		public bool addDefaultRefs;

		private PasteBuffer _003Cbuffer_003E5__2;

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
			if (!r1OT6JKwuRxyDHSM0odn())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					return;
				}
			}
			int num2 = default;
			TaskAwaiter awaiter = default;
			BaseSnippetAddRemoveAction baseSnippetAddRemoveAction = default;
			CvsCellCollection cvsCellCollection = default;
			string g = default;
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
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								goto IL_01cb;
							}
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 14;
						}
						goto IL_026a;
						IL_026a:
						while (true)
						{
							switch (num3)
							{
							case 18:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								Q9W3T6KJLQYbn11LBkZy(swmfABKwzYePWngSFZv4(baseSnippetAddRemoveAction.Step), true, true);
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 2;
									continue;
								}
								goto IL_0208;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 19;
								continue;
							case 7:
								_003Cbuffer_003E5__2 = (PasteBuffer)XAb41RKwhlTgZedJ4BOy(baseSnippetAddRemoveAction.orVU5KlR2);
								awaiter = GY0QUvKwtBYdjOyh2dP0(baseSnippetAddRemoveAction.Step.AppViewModel.PasteSnippetInLocation(_003Cbuffer_003E5__2));
								num3 = 6;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 16:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!PoUjEPKw1ejs2A7dedQM()) ? 17 : 13);
									continue;
								}
								goto case 19;
							case 5:
								cvsCellCollection = (CvsCellCollection)RrF3N3KJ5RBaxRLhjXKF(Xx4GZFKJKDge8ZNYmovq(swmfABKwzYePWngSFZv4(baseSnippetAddRemoveAction.Step)));
								num3 = 8;
								if (r1OT6JKwuRxyDHSM0odn())
								{
								}
								continue;
							case 11:
							case 13:
								num2 = (_003C_003E1__state = 1);
								num3 = 1;
								continue;
							case 4:
								return;
							case 10:
								return;
							case 12:
							{
								SnippetAddedEventType action = (addDefaultRefs ? SnippetAddedEventType.Created : SnippetAddedEventType.Located);
								awaiter = GY0QUvKwtBYdjOyh2dP0(((ISnippetOwner)baseSnippetAddRemoveAction.Step).AddSnippet(new Guid(g), cvsCellCollection, m3611wKJwBXLuKAQcyps(_003Cbuffer_003E5__2), action));
								num3 = 16;
								continue;
							}
							case 15:
							case 17:
								break;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 18;
								continue;
							case 14:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0208;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								g = (string)gwAB5OKJaFyoDGv80qLq(IFNXOLKJJAQEWyXl4wfo(cvsCellCollection[m3611wKJwBXLuKAQcyps(_003Cbuffer_003E5__2).Location]));
								goto case 12;
							default:
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 19;
							case 19:
								{
									awaiter.GetResult();
									goto end_IL_026a;
								}
								IL_0208:
								awaiter.GetResult();
								num3 = 3;
								continue;
							}
							goto IL_01cb;
							continue;
							end_IL_026a:
							break;
						}
						goto end_IL_0024;
						IL_01cb:
						_003C_003Eu__1 = default;
						num3 = 9;
						goto IL_026a;
						end_IL_0024:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cbuffer_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 5;
					continue;
				case 6:
					_003C_003Et__builder.SetResult();
					num = 7;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 5:
					break;
				case 1:
					baseSnippetAddRemoveAction = _003C_003E4__this;
					goto case 2;
				case 7:
					return;
				}
				_003Cbuffer_003E5__2 = null;
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
		internal static object XAb41RKwhlTgZedJ4BOy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PasteBuffer.FromBytes((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter GY0QUvKwtBYdjOyh2dP0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object swmfABKwzYePWngSFZv4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Q9W3T6KJLQYbn11LBkZy(object P_0, bool P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).MakeNewResult(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xx4GZFKJKDge8ZNYmovq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RrF3N3KJ5RBaxRLhjXKF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange m3611wKJwBXLuKAQcyps(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IFNXOLKJJAQEWyXl4wfo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).GetComment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gwAB5OKJaFyoDGv80qLq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellComment)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PoUjEPKw1ejs2A7dedQM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r1OT6JKwuRxyDHSM0odn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected readonly IInSightAppStep Step;

	private byte[] orVU5KlR2;

	protected readonly string SnippetName;

	public abstract string Text { get; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BaseSnippetAddRemoveAction(IInSightAppStep appStep, string snippetName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				Step = appStep;
				goto default;
			default:
				_ = 0;
				if (nexjtqCVtebiZ3XeCr())
				{
					num = 5;
					break;
				}
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 6:
				qwKtOGWLLlh3rWX7QS(this);
				num = 2;
				break;
			case 3:
			case 5:
				orVU5KlR2 = new byte[0];
				goto case 1;
			case 1:
			case 4:
				SnippetName = snippetName;
				num = 7;
				break;
			case 0:
				AspWaERey8dPqggpsG();
				num = 6;
				if (rg4Y5UAQ5ivIGRSCqw())
				{
					return;
				}
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveSnippet_003Ed__4))]
	public Task SaveSnippet(CvsCellRange snippetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!nexjtqCVtebiZ3XeCr()) ? 3 : 4);
		_003CSaveSnippet_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = ExgjDOTP1WkoHiqFZw();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 3:
				stateMachine.snippetRange = snippetRange;
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPasteAndParseSnippet_003Ed__5))]
	public Task PasteAndParseSnippet(bool addDefaultRefs = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CPasteAndParseSnippet_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine.addDefaultRefs = addDefaultRefs;
				goto default;
			default:
				_ = 0;
				if (nexjtqCVtebiZ3XeCr())
				{
					num = 1;
					if (nexjtqCVtebiZ3XeCr())
					{
						break;
					}
					goto case 0;
				}
				num = 0;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 6;
				break;
			case 2:
				stateMachine._003C_003Et__builder = ExgjDOTP1WkoHiqFZw();
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	public abstract Task SaveState();

	public abstract Task Do();

	public abstract Task Redo();

	public abstract Task Undo();

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AspWaERey8dPqggpsG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qwKtOGWLLlh3rWX7QS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nexjtqCVtebiZ3XeCr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rg4Y5UAQ5ivIGRSCqw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ExgjDOTP1WkoHiqFZw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
