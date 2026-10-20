using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoImportCxdxSnippetAction : UndoRangeAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoImportCxdxSnippetAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			h1Fq3BsCWqHI7YFH29SL();
			int num = ((!eRbmdbsC26W6LDskUm16()) ? 2 : 4);
			int num2 = default;
			UndoImportCxdxSnippetAction undoImportCxdxSnippetAction = default;
			TaskAwaiter<byte[]> awaiter = default;
			TaskAwaiter awaiter2 = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					undoImportCxdxSnippetAction = _003C_003E4__this;
					num = 3;
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 11;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 10;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 11:
								undoImportCxdxSnippetAction.StoredRanges[0].DeleteExternalData();
								num3 = 12;
								if (eRbmdbsC26W6LDskUm16())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 14:
								result = awaiter.GetResult();
								num3 = 17;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 1;
							case 15:
								num2 = (_003C_003E1__state = -1);
								goto IL_00ca;
							default:
								num3 = 7;
								continue;
							case 8:
								_003C_003Eu__2 = awaiter;
								num3 = 5;
								continue;
							case 4:
								return;
							case 10:
								num2 = (_003C_003E1__state = -1);
								goto case 1;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 4;
								continue;
							case 7:
								awaiter = ((CvsCogSocket)hRp4mEsCtb3RB0NKV3Ua(undoImportCxdxSnippetAction.InSight)).Sheet.CopyCellsAsync(undoImportCxdxSnippetAction.Range).GetAwaiter();
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 13:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 16;
							case 16:
								if (awaiter2.IsCompleted)
								{
									goto IL_00ca;
								}
								_ = 1;
								if (h1Fq3BsCWqHI7YFH29SL())
								{
									num3 = 1;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								}
								num3 = 13;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 12:
								awaiter2 = otXNrPsC7Et8PDWHg3Fg(undoImportCxdxSnippetAction.HPpgoUSbQ6());
								num3 = 16;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 1);
								num3 = 8;
								continue;
							case 17:
								{
									undoImportCxdxSnippetAction.CRtgMomQDS = result;
									break;
								}
								IL_00ca:
								awaiter2.GetResult();
								goto case 7;
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
					goto case 5;
				default:
					num = 5;
					if (1 == 0)
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
		internal static TaskAwaiter otXNrPsC7Et8PDWHg3Fg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hRp4mEsCtb3RB0NKV3Ua(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eRbmdbsC26W6LDskUm16()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h1Fq3BsCWqHI7YFH29SL()
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
	private struct _003CRedo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoImportCxdxSnippetAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_018c;
			IL_001a:
			int num2 = default;
			UndoImportCxdxSnippetAction undoImportCxdxSnippetAction = default;
			try
			{
				int num3;
				if (num2 != 0)
				{
					O4wSZcsC5thLKGnFn5ll(undoImportCxdxSnippetAction.StoredRanges[0]);
					num3 = 8;
					goto IL_00a0;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_0071;
				IL_0071:
				_003C_003Eu__1 = default;
				num3 = 9;
				goto IL_00a0;
				IL_00a0:
				while (true)
				{
					switch (num3)
					{
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 1;
						continue;
					case 4:
						if (!awaiter.IsCompleted)
						{
							_ = 1;
							num3 = ((!S8wj7OsCKOpi9layoO89()) ? 7 : 0);
							continue;
						}
						goto case 10;
					case 0:
					case 6:
						break;
					case 3:
						_003C_003Eu__1 = awaiter;
						goto case 5;
					default:
						num3 = 5;
						continue;
					case 2:
					case 7:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						continue;
					case 8:
						awaiter = eexjUssCowbcGF1uZtN9(undoImportCxdxSnippetAction.InSight.PasteCellsAsync(undoImportCxdxSnippetAction.Range, undoImportCxdxSnippetAction.CRtgMomQDS, cutFromSameSheet: false, runSheet: true));
						num3 = 4;
						continue;
					case 9:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						if (nfXiZWsCCc56Q6EgeOLM())
						{
							continue;
						}
						return;
					case 1:
						return;
					case 10:
						awaiter.GetResult();
						goto end_IL_00a0;
					}
					goto IL_0071;
					continue;
					end_IL_00a0:
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
			goto IL_01bd;
			IL_018c:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					goto IL_01bd;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 0:
					goto IL_01ed;
				case 6:
					return;
				}
				break;
				IL_01ed:
				undoImportCxdxSnippetAction = _003C_003E4__this;
				_ = 1;
				if (S8wj7OsCKOpi9layoO89())
				{
					num = 5;
					continue;
				}
				num = 1;
				if (false)
				{
					return;
				}
			}
			goto IL_001a;
			IL_01bd:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (S8wj7OsCKOpi9layoO89())
			{
			}
			goto IL_018c;
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
		internal static void O4wSZcsC5thLKGnFn5ll(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StoredRange)P_0).DeleteExternalData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter eexjUssCowbcGF1uZtN9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nfXiZWsCCc56Q6EgeOLM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S8wj7OsCKOpi9layoO89()
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
	private struct _003CUndo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoImportCxdxSnippetAction _003C_003E4__this;

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
			if (!llINjgsCY1Pp6vRlwOMD())
			{
				num = 2;
				if (!uK7yDosCP55SZQkcYi5S())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
				if (llINjgsCY1Pp6vRlwOMD())
				{
				}
			}
			goto IL_01da;
			IL_0060:
			UndoImportCxdxSnippetAction undoImportCxdxSnippetAction = _003C_003E4__this;
			num = 4;
			goto IL_01da;
			IL_01da:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 3:
					goto IL_0060;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Bx3tQxsCN7tXK7HtPoyu(undoImportCxdxSnippetAction.U3AgJw0MGf());
							llINjgsCY1Pp6vRlwOMD();
							num3 = ((!uK7yDosCP55SZQkcYi5S()) ? 5 : 4);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (!uK7yDosCP55SZQkcYi5S())
							{
								goto IL_0194;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 0:
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 6;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (!llINjgsCY1Pp6vRlwOMD())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 6:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 7:
								return;
							case 10:
								break;
							}
							break;
						}
						goto IL_0194;
						IL_0194:
						undoImportCxdxSnippetAction.StoredRanges[0].RestoreExternalData();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_0060;
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
		internal static TaskAwaiter Bx3tQxsCN7tXK7HtPoyu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uK7yDosCP55SZQkcYi5S()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool llINjgsCY1Pp6vRlwOMD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private byte[] CRtgMomQDS;

	private readonly Func<Task> HPpgoUSbQ6;

	protected CvsCellRange Range
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return StoredRanges[0].Range;
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
			return (string)CahcFLtu67MiaxZ82BL(Quqq6bteEOXdJk3d6tX(), Range.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoImportCxdxSnippetAction(CvsInSight insight, CvsCellRange range, Func<Task> sendFunc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(insight, range);
		HPpgoUSbQ6 = sendFunc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__7))]
	public override Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (uxmjvktlkZ3t2C7Z9DC())
				{
					num = 0;
					if (uxmjvktlkZ3t2C7Z9DC())
					{
					}
				}
				else
				{
					num = 1;
				}
				continue;
			case 5:
				stateMachine._003C_003Et__builder = nUCITItIyNjeBBvImXi();
				num = 4;
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__8))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CRedo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
				stateMachine._003C_003Et__builder = nUCITItIyNjeBBvImXi();
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				uxmjvktlkZ3t2C7Z9DC();
				num = ((!J9eq1PtQcTSyjAR5YeH()) ? 4 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!J9eq1PtQcTSyjAR5YeH()) ? 5 : 3);
		_003CUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task U3AgJw0MGf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.Undo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool J9eq1PtQcTSyjAR5YeH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uxmjvktlkZ3t2C7Z9DC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Quqq6bteEOXdJk3d6tX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionImportSnippet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CahcFLtu67MiaxZ82BL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder nUCITItIyNjeBBvImXi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
