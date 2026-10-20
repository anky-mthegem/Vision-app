using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps;

public class AddSnippetUndoAction : BaseSnippetAddRemoveAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

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
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					VCvYnVKdJe9EMW7RJg0y();
					if (!iypciiKdaqxvYYk9896M())
					{
						num = 3;
						break;
					}
					num = 0;
					if (VCvYnVKdJe9EMW7RJg0y())
					{
						break;
					}
					return;
				default:
					_003C_003Et__builder.SetResult();
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = lCykpqKdORiqo2ZqokC4(hYXZHkKdetBlbPDegOPG());
							iypciiKdaqxvYYk9896M();
							num3 = ((!VCvYnVKdJe9EMW7RJg0y()) ? 3 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 4:
								return;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
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
		internal static object hYXZHkKdetBlbPDegOPG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lCykpqKdORiqo2ZqokC4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VCvYnVKdJe9EMW7RJg0y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iypciiKdaqxvYYk9896M()
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
	private struct _003CDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AddSnippetUndoAction _003C_003E4__this;

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
			AddSnippetUndoAction addSnippetUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = addSnippetUndoAction.SaveSnippet(addSnippetUndoAction.Range).GetAwaiter();
							num3 = 8;
							if (!HGQs46KdIGEK9qB9kyrr())
							{
								goto IL_0040;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_00ed;
						IL_00ed:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 5:
								break;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (muA6jgKdDRnmHdJvZ2it())
								{
								}
								continue;
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								break;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									muA6jgKdDRnmHdJvZ2it();
									if (!HGQs46KdIGEK9qB9kyrr())
									{
										num3 = 5;
										continue;
									}
									num3 = 4;
									if (muA6jgKdDRnmHdJvZ2it())
									{
									}
									continue;
								}
								goto case 9;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 7:
								return;
							case 9:
								awaiter.GetResult();
								goto end_IL_00ed;
							}
							goto IL_0040;
							continue;
							end_IL_00ed:
							break;
						}
						goto end_IL_0018;
						IL_0040:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						goto IL_00ed;
						end_IL_0018:;
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
					if (HGQs46KdIGEK9qB9kyrr())
					{
						break;
					}
					goto case 0;
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					addSnippetUndoAction = _003C_003E4__this;
					_ = 0;
					if (!HGQs46KdIGEK9qB9kyrr())
					{
						num = 4;
						break;
					}
					num = 1;
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
		internal static bool HGQs46KdIGEK9qB9kyrr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool muA6jgKdDRnmHdJvZ2it()
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
	private struct _003CRedo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AddSnippetUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lItd4dKdnE5uMq8H3x4o();
			int num = ((!oN4dPBKdiYUf3XYoCThb()) ? 4 : 3);
			int num2 = default;
			TaskAwaiter awaiter = default;
			AddSnippetUndoAction addSnippetUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 12;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							oN4dPBKdiYUf3XYoCThb();
							num3 = (lItd4dKdnE5uMq8H3x4o() ? 15 : 4);
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 13;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 13:
								_003C_003Eu__1 = default;
								num3 = 2;
								if (oN4dPBKdiYUf3XYoCThb())
								{
									continue;
								}
								return;
							case 5:
								return;
							case 1:
								awaiter = V6Cj5TKdV89rgQgNIQUT(addSnippetUndoAction.AppStepVm.SetCurrentSnippet(addSnippetUndoAction.AppStepVm.Snippets.Last()));
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								break;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (lItd4dKdnE5uMq8H3x4o())
								{
								}
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 14:
								_003C_003Eu__1 = awaiter;
								goto case 11;
							case 12:
								awaiter = V6Cj5TKdV89rgQgNIQUT(addSnippetUndoAction.PasteAndParseSnippet());
								num3 = 8;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (lItd4dKdnE5uMq8H3x4o())
								{
								}
								continue;
							case 0:
								awaiter.GetResult();
								num3 = 1;
								continue;
							case 11:
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
								num2 = (_003C_003E1__state = 1);
								num3 = 14;
								continue;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto case 0;
							default:
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 0;
							case 16:
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
					goto case 5;
				default:
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
				case 4:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				addSnippetUndoAction = _003C_003E4__this;
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
		internal static TaskAwaiter V6Cj5TKdV89rgQgNIQUT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oN4dPBKdiYUf3XYoCThb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lItd4dKdnE5uMq8H3x4o()
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
	private struct _003CUndo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AddSnippetUndoAction _003C_003E4__this;

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
			if (!IYYoZrKdd7IbBAQ4JQ23())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (!Dln2CcKdfl8ln5No0oFQ())
				{
					return;
				}
			}
			int num2 = default;
			AddSnippetUndoAction addSnippetUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = rknGeMKdggrp7E9ToceZ(Ub8njgKdlIXrpCjUXal0(new RemoveSnippetUndoAction(addSnippetUndoAction.AppStepVm, addSnippetUndoAction.SnippetName)));
							num3 = 1;
							if (IYYoZrKdd7IbBAQ4JQ23())
							{
							}
							goto IL_00f3;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00aa;
						IL_00aa:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_00f3;
						IL_00f3:
						while (true)
						{
							switch (num3)
							{
							case 7:
								return;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								Dln2CcKdfl8ln5No0oFQ();
								num3 = ((!IYYoZrKdd7IbBAQ4JQ23()) ? 4 : 3);
								continue;
							case 3:
							case 5:
								break;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (IYYoZrKdd7IbBAQ4JQ23())
								{
								}
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_00f3;
							}
							goto IL_00aa;
							continue;
							end_IL_00f3:
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
				default:
					num = 2;
					continue;
				case 1:
				case 4:
					addSnippetUndoAction = _003C_003E4__this;
					num = 5;
					if (!IYYoZrKdd7IbBAQ4JQ23())
					{
						continue;
					}
					break;
				case 2:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object Ub8njgKdlIXrpCjUXal0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseSnippetAddRemoveAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rknGeMKdggrp7E9ToceZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dln2CcKdfl8ln5No0oFQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IYYoZrKdd7IbBAQ4JQ23()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected CvsCellRange Range;

	[CompilerGenerated]
	private readonly string NnfUCrY4pm;

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
			return NnfUCrY4pm;
		}
	}

	protected AppStepViewModel AppStepVm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (AppStepViewModel)Step;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddSnippetUndoAction(AppStepViewModel appStepVm, CvsCellRange range, string snippetName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dMfZ84eBGn0PqAdSfkK();
		int num = (UfSxvUebhwMohcSyNJA() ? 2 : 4);
		do
		{
			IL_0041:
			switch (num)
			{
			case 5:
				Range = range;
				goto case 3;
			default:
				num = 3;
				goto IL_0041;
			case 3:
				NnfUCrY4pm = (string)E2nsiVeonuLIi8FeJYe(PYohqUeGWYpvYApoefN(), snippetName);
				num = 6;
				goto IL_0041;
			case 0:
			case 4:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				break;
			case 1:
			case 2:
				break;
			case 6:
				return;
			}
			base._002Ector(appStepVm, snippetName);
			num = 5;
		}
		while (dMfZ84eBGn0PqAdSfkK());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public override Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 3:
				stateMachine._003C_003Et__builder = B1hsjEeSXu50nAvYnib();
				_ = 1;
				num = (UfSxvUebhwMohcSyNJA() ? 4 : 0);
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public override Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UfSxvUebhwMohcSyNJA();
		int num;
		if (dMfZ84eBGn0PqAdSfkK())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_009f;
			}
		}
		goto IL_006c;
		IL_006c:
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_009f;
		IL_009f:
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		num = 5;
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (UfSxvUebhwMohcSyNJA() ? 5 : 4);
		_003CRedo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = B1hsjEeSXu50nAvYnib();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UfSxvUebhwMohcSyNJA();
		int num;
		if (dMfZ84eBGn0PqAdSfkK())
		{
			num = 4;
			if (!dMfZ84eBGn0PqAdSfkK())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0048;
		IL_0073:
		_003CUndo_003Ed__10 stateMachine = default;
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
				num = 3;
				continue;
			case 3:
				goto IL_0073;
			case 1:
				stateMachine._003C_003E4__this = this;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = B1hsjEeSXu50nAvYnib();
				num = 1;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003E1__state = -1;
		goto IL_0073;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PYohqUeGWYpvYApoefN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SywhuGb3xG();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E2nsiVeonuLIi8FeJYe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dMfZ84eBGn0PqAdSfkK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UfSxvUebhwMohcSyNJA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder B1hsjEeSXu50nAvYnib()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
