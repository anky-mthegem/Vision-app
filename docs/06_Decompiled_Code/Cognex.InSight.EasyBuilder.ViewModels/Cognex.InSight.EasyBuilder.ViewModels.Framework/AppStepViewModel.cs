using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;
using Cognex.InSight.Internal;
using Cognex.InSight.Internal.Analysis;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Framework;

public abstract class AppStepViewModel : StepBase, IInSightAppStep, IAsyncDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		private IEnumerator<EzSnippet> _003C_003E7__wrap1;

		private EzSnippet _003Csnippet_003E5__3;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!WtmwVf5rgu6FEl6SgcyB())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					return;
				}
			}
			AppStepViewModel appStepViewModel = default;
			int num2 = default;
			ValueTask valueTask = default;
			ValueTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					appStepViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = appStepViewModel.Snippets.GetEnumerator();
						}
						try
						{
							if (num2 == 0)
							{
								goto IL_0092;
							}
							goto IL_01f1;
							IL_01f1:
							if (ltquQF5rZN6UTLnEt28r(_003C_003E7__wrap1))
							{
								_003Csnippet_003E5__3 = _003C_003E7__wrap1.Current;
								goto IL_0092;
							}
							goto end_IL_0075;
							IL_0092:
							try
							{
								int num3;
								if (num2 != 0)
								{
									valueTask = PRrHGb5rsJwXexMS6fxs(_003Csnippet_003E5__3);
									num3 = 5;
									goto IL_00fb;
								}
								awaiter = _003C_003Eu__1;
								goto IL_014c;
								IL_014c:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (0 == 0)
								{
									goto IL_00fb;
								}
								goto IL_0164;
								IL_0164:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								goto IL_00fb;
								IL_00fb:
								while (true)
								{
									switch (num3)
									{
									case 0:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 2;
										continue;
									case 2:
										return;
									case 4:
										_003C_003Eu__1 = awaiter;
										goto case 0;
									default:
										num3 = 0;
										continue;
									case 1:
									case 7:
										if (!awaiter.IsCompleted)
										{
											num3 = 9;
											continue;
										}
										goto case 10;
									case 3:
									case 6:
										break;
									case 9:
										goto IL_0164;
									case 8:
										num2 = (_003C_003E1__state = -1);
										num3 = 10;
										continue;
									case 5:
										goto IL_018a;
									case 10:
										awaiter.GetResult();
										goto end_IL_0092;
									}
									break;
									IL_018a:
									awaiter = valueTask.GetAwaiter();
									WtmwVf5rgu6FEl6SgcyB();
									num3 = (JlMPcV5rlP4pejpM0AvN() ? 7 : 3);
								}
								goto IL_014c;
								end_IL_0092:;
							}
							catch (Exception ex)
							{
								string message = (string)Ma0cwc5rPusJV3qjbZok(biJoXe5rvT04evnxe95e(54708), oGCguh5rrcuCNvepDV0T(_003Csnippet_003E5__3));
								LogManager.GetLogger<AppStepViewModel>().LogException(LogLevel.Error, message, ex);
							}
							_003Csnippet_003E5__3 = null;
							goto IL_01f1;
							end_IL_0075:;
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
		internal static ValueTask PRrHGb5rsJwXexMS6fxs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object biJoXe5rvT04evnxe95e(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oGCguh5rrcuCNvepDV0T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ma0cwc5rPusJV3qjbZok(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ltquQF5rZN6UTLnEt28r(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JlMPcV5rlP4pejpM0AvN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WtmwVf5rgu6FEl6SgcyB()
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
	private struct _003CRemoveSnippet_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public EzSnippet snippet;

		private EzSnippet _003CnextCurrentSnippet_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (HIU5BV5rb5MesbJb2Mic() ? 5 : 6);
			int num2 = default;
			TaskAwaiter awaiter = default;
			AppStepViewModel appStepViewModel = default;
			int previousIndex = default;
			int index = default;
			int nextIndex = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003CnextCurrentSnippet_003E5__2 = null;
							num3 = 23;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 26;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 3;
							break;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 15;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 28:
								if (!awaiter.IsCompleted)
								{
									num3 = 20;
									continue;
								}
								goto case 14;
							case 18:
								if (appStepViewModel.CurrentSnippet == null)
								{
									num3 = 11;
									continue;
								}
								goto end_IL_0231;
							case 1:
								if (previousIndex > -1)
								{
									num3 = 0;
									if (ivjNnH5rBJBD68xVAf1B())
									{
										continue;
									}
									goto case 14;
								}
								goto case 21;
							case 14:
								awaiter.GetResult();
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 19;
							case 19:
								if (!appStepViewModel.Snippets.Any())
								{
									goto case 18;
								}
								goto case 4;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 27;
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 30;
								if (true)
								{
									continue;
								}
								return;
							case 24:
								return;
							case 29:
								index = appStepViewModel.Snippets.IndexOf(snippet);
								num3 = 8;
								continue;
							case 2:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
								appStepViewModel.GetSnippetSiblingIndices(index, out previousIndex, out nextIndex);
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 23;
							case 23:
								if (appStepViewModel.CurrentSnippet == snippet)
								{
									num3 = 29;
									continue;
								}
								goto case 10;
							case 16:
								awaiter = CEvSfi5rGlnvajnbhkoP(appStepViewModel.SetCurrentSnippet(_003CnextCurrentSnippet_003E5__2));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									num3 = 5;
									continue;
								}
								break;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 24;
								if (true)
								{
									continue;
								}
								goto case 25;
							case 25:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 13:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 26;
							case 26:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 10:
								awaiter = CEvSfi5rGlnvajnbhkoP(appStepViewModel.RemoveSnippetInternal(snippet));
								if (!awaiter.IsCompleted)
								{
									goto case 17;
								}
								goto case 27;
							default:
								num3 = 17;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
							case 22:
								((CvsInSight)CeC4sg5rSxB82o9EmiAl(appStepViewModel)).MakeNewResult(true, true);
								num3 = 18;
								continue;
							case 11:
								if (_003CnextCurrentSnippet_003E5__2 != null)
								{
									num3 = 16;
									continue;
								}
								goto end_IL_0231;
							case 12:
								if (nextIndex < 0)
								{
									num3 = 1;
									if (HIU5BV5rb5MesbJb2Mic())
									{
									}
									continue;
								}
								_003CnextCurrentSnippet_003E5__2 = appStepViewModel.Snippets[nextIndex];
								goto case 21;
							case 0:
								_003CnextCurrentSnippet_003E5__2 = appStepViewModel.Snippets[previousIndex];
								num3 = 21;
								if (ivjNnH5rBJBD68xVAf1B())
								{
									continue;
								}
								goto case 21;
							case 21:
								awaiter = appStepViewModel.SetCurrentSnippet(null).GetAwaiter();
								num3 = 28;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 25;
								if (HIU5BV5rb5MesbJb2Mic())
								{
								}
								continue;
							case 17:
								num2 = (_003C_003E1__state = 1);
								num3 = 13;
								continue;
							case 20:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								HIU5BV5rb5MesbJb2Mic();
								num3 = (ivjNnH5rBJBD68xVAf1B() ? 2 : 4);
								continue;
							case 27:
								awaiter.GetResult();
								fQujSZ5roxQJBm7caSXp(appStepViewModel, null);
								num3 = 19;
								if (HIU5BV5rb5MesbJb2Mic())
								{
								}
								continue;
							case 30:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0231:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CnextCurrentSnippet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 2;
					continue;
				case 2:
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (ivjNnH5rBJBD68xVAf1B())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 5:
					appStepViewModel = _003C_003E4__this;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 6:
					num2 = _003C_003E1__state;
					goto case 1;
				case 7:
					return;
				}
				_003CnextCurrentSnippet_003E5__2 = null;
				num = 3;
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
		internal static TaskAwaiter CEvSfi5rGlnvajnbhkoP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fQujSZ5roxQJBm7caSXp(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).RefreshPotentialDependencies((EzSnippet)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CeC4sg5rSxB82o9EmiAl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ivjNnH5rBJBD68xVAf1B()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HIU5BV5rb5MesbJb2Mic()
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
	private struct _003CFireSnippetAdded_003Ed__89 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public SnippetAddedEventArgs e;

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
			if (!hA7JTu5r841ndFLxTp3r())
			{
				num = 1;
				if (hA7JTu5r841ndFLxTp3r())
				{
				}
			}
			else
			{
				num = 4;
			}
			AppStepViewModel appStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			Task[] array = default;
			int num4 = default;
			Delegate[] invocationList = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					appStepViewModel = _003C_003E4__this;
					goto case 2;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							goto IL_0105;
						}
						if (appStepViewModel.S86mtPmG87 != null)
						{
							hA7JTu5r841ndFLxTp3r();
							num3 = ((!QTyHSQ5rk8bLUkRtEbH2()) ? 2 : 6);
							goto IL_0105;
						}
						goto end_IL_006b;
						IL_0105:
						while (true)
						{
							switch (num3)
							{
							case 13:
								return;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 13;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 5:
								awaiter = gKUOTh5rE4eZj23AhUBD(cX5QHW5rq40ivwyfcaPG(array));
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 4:
							case 9:
								if (num4 >= invocationList.Length)
								{
									goto case 2;
								}
								array[num4] = ((Func<object, SnippetAddedEventArgs, Task>)invocationList[num4])(appStepViewModel, e);
								num4++;
								num3 = 9;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								num4 = 0;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								array = new Task[invocationList.Length];
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 0:
							case 6:
								invocationList = appStepViewModel.S86mtPmG87.GetInvocationList();
								num3 = 11;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 14:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_006b:;
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
		internal static object cX5QHW5rq40ivwyfcaPG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.WhenAll((Task[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter gKUOTh5rE4eZj23AhUBD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QTyHSQ5rk8bLUkRtEbH2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hA7JTu5r841ndFLxTp3r()
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
	private struct _003CFireSnippetPreRemove_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (LpmYce5rX6agr0FYiHmS() ? 5 : 2);
			AppStepViewModel appStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			int num4 = default;
			Task[] array = default;
			Delegate[] invocationList = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 5:
					appStepViewModel = _003C_003E4__this;
					num = 4;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							goto IL_007c;
						}
						int num3;
						if (appStepViewModel.ccdmYtekeX != null)
						{
							num3 = 4;
							goto IL_0152;
						}
						goto end_IL_0061;
						IL_0152:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 11:
								break;
							case 10:
								num4++;
								_ = 1;
								if (!LpmYce5rX6agr0FYiHmS())
								{
									num3 = 13;
									continue;
								}
								num3 = 0;
								if (zueVm95rp7WPPh2fU5Zx())
								{
									continue;
								}
								goto case 4;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 14;
							case 3:
								array = new Task[invocationList.Length];
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 9:
							case 13:
								if (num4 < invocationList.Length)
								{
									array[num4] = ((Func<object, SnippetPreRemoveEventArgs, Task>)invocationList[num4])(appStepViewModel, e);
									num3 = 10;
									continue;
								}
								awaiter = Nb3AED5r9h3C6Sb4MCEY(Task.WhenAll(array));
								goto case 1;
							default:
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 12:
								return;
							case 4:
								invocationList = appStepViewModel.ccdmYtekeX.GetInvocationList();
								num3 = 3;
								continue;
							case 8:
								num4 = 0;
								num3 = 9;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 14:
								awaiter.GetResult();
								goto end_IL_0152;
							}
							goto IL_007c;
							continue;
							end_IL_0152:
							break;
						}
						goto end_IL_0061;
						IL_007c:
						num2 = (_003C_003E1__state = -1);
						num3 = 14;
						goto IL_0152;
						end_IL_0061:;
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
					if (!zueVm95rp7WPPh2fU5Zx())
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
		internal static TaskAwaiter Nb3AED5r9h3C6Sb4MCEY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zueVm95rp7WPPh2fU5Zx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LpmYce5rX6agr0FYiHmS()
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
	private struct _003CFireSnippetRemove_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public SnippetRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Vpr5Kn5r75qLfJPfRCvI();
			int num = ((!cbCYCP5r4iJZO5WqQNwY()) ? 2 : 4);
			AppStepViewModel appStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			int num4 = default;
			Delegate[] invocationList = default;
			Task[] array = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					appStepViewModel = _003C_003E4__this;
					num = 3;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 14;
							goto IL_0171;
						}
						if (appStepViewModel.SwWm0MYoai != null)
						{
							num3 = 9;
							goto IL_0171;
						}
						goto end_IL_0065;
						IL_0171:
						while (true)
						{
							switch (num3)
							{
							case 8:
								return;
							case 11:
								return;
							case 12:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								if (!Vpr5Kn5r75qLfJPfRCvI())
								{
									num3 = 0;
									continue;
								}
								num3 = 8;
								if (Vpr5Kn5r75qLfJPfRCvI())
								{
								}
								continue;
							case 0:
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								num4++;
								num3 = 7;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 9:
								invocationList = appStepViewModel.SwWm0MYoai.GetInvocationList();
								num3 = 13;
								continue;
							case 1:
							case 7:
								if (num4 < invocationList.Length)
								{
									array[num4] = ((Func<object, SnippetRemoveEventArgs, Task>)invocationList[num4])(appStepViewModel, e);
									num3 = 6;
									continue;
								}
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 2;
								if (cbCYCP5r4iJZO5WqQNwY())
								{
									continue;
								}
								goto case 4;
							case 4:
								awaiter = rJj4E45rjw827OmFB8Y7(jnYHaj5r3EkWZlQ6HOlc(array));
								num3 = 3;
								if (cbCYCP5r4iJZO5WqQNwY())
								{
									continue;
								}
								goto case 13;
							case 13:
								array = new Task[invocationList.Length];
								num3 = 5;
								if (!Vpr5Kn5r75qLfJPfRCvI())
								{
									continue;
								}
								goto case 5;
							case 5:
								num4 = 0;
								num3 = 1;
								if (cbCYCP5r4iJZO5WqQNwY())
								{
									continue;
								}
								break;
							case 14:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_0065:;
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
					if (!cbCYCP5r4iJZO5WqQNwY())
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
		internal static object jnYHaj5r3EkWZlQ6HOlc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.WhenAll((Task[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rJj4E45rjw827OmFB8Y7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cbCYCP5r4iJZO5WqQNwY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vpr5Kn5r75qLfJPfRCvI()
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
	private struct _003CSetCurrentSnippet_003Ed__95 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public EzSnippet snippet;

		private IDisposable _003C_003E7__wrap1;

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
			AppStepViewModel appStepViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					LajVwY5rCqWaBLq454FV();
					num = ((!ULas2W5r6sFMMM64Qocb()) ? 5 : 0);
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					appStepViewModel = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = (IDisposable)ylllyl5rRWMG5gg6nIij(CvsTraceEzb.Info, jYkHFV5rARHMwleSO1B8(48658));
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (appStepViewModel.CurrentSnippet == null)
								{
									goto IL_0105;
								}
								_ = 1;
								num3 = (LajVwY5rCqWaBLq454FV() ? 9 : 4);
								goto IL_0173;
							}
							awaiter = _003C_003Eu__1;
							goto IL_0120;
							IL_0120:
							_003C_003Eu__1 = default;
							num3 = 6;
							goto IL_0173;
							IL_0105:
							if (appStepViewModel.CurrentSnippet != snippet)
							{
								num3 = 11;
								goto IL_0173;
							}
							goto end_IL_0086;
							IL_0173:
							while (true)
							{
								switch (num3)
								{
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									continue;
								case 0:
								case 4:
									awaiter = hWOKPa5rTxRXcFn7ikGO(tkmVS55rWsVDKLwEpwxS(appStepViewModel.CurrentSnippet));
									goto case 1;
								case 3:
									awaiter.GetResult();
									num3 = 7;
									continue;
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 10;
									continue;
								case 7:
									break;
								case 2:
									goto IL_0120;
								case 10:
									_003C_003Eu__1 = awaiter;
									num3 = 5;
									continue;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 2;
									continue;
								case 1:
								case 9:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 3;
								case 11:
									appStepViewModel.CurrentSnippet = snippet;
									goto end_IL_0086;
								}
								break;
							}
							goto IL_0105;
							end_IL_0086:;
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
					goto case 3;
				default:
					num = 3;
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
		internal static object jYkHFV5rARHMwleSO1B8(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ylllyl5rRWMG5gg6nIij(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tkmVS55rWsVDKLwEpwxS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).AwaitIfUpdatingName();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter hWOKPa5rTxRXcFn7ikGO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ULas2W5r6sFMMM64Qocb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LajVwY5rCqWaBLq454FV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public string name;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass96_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ds2wUx5rF08yRraaJuCB();
			NpZTpW5rMmhMfdBR1w5m(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CIsSnippetNameUsed_003Eb__0(EzSnippet snippet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return J7doxi5rUY2KmC82xT16(ppZ4SQ5rYuwCVl1rsA9P(snippet), name, StringComparison.CurrentCultureIgnoreCase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ds2wUx5rF08yRraaJuCB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NpZTpW5rMmhMfdBR1w5m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VfudE05rySN5KAMjEp3c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool USV4m05r0gNXJGytsAOK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ppZ4SQ5rYuwCVl1rsA9P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J7doxi5rUY2KmC82xT16(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<EzSnippet, string> _003C_003E9__97_0;

		public static Func<CellViewModel, CvsCellLocation> _003C_003E9__123_0;

		public static Func<CellViewModel, bool> _003C_003E9__123_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lN6MWx5rmZK36qpNbjUP();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lN6MWx5rmZK36qpNbjUP();
			BquuSe5rQ9F9pKSF11fW(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGenerateUniqueSnippetName_003Eb__97_0(EzSnippet it)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)xJEAKx5rNVCYsM5s3c2Z(it);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsCellLocation _003CRemoveSnippetPropertiesFor_003Eb__123_0(CellViewModel property)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return W1CfaE5r2ibb07FJhQU8(property);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRemoveSnippetPropertiesFor_003Eb__123_1(CellViewModel p)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uCy22H5rcWVkZMLuHi4y(p) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lN6MWx5rmZK36qpNbjUP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QxLTEK5rH2eFPEq2ObZo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EXdRl25rxSAK3yav9FPP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BquuSe5rQ9F9pKSF11fW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xJEAKx5rNVCYsM5s3c2Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation W1CfaE5r2ibb07FJhQU8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uCy22H5rcWVkZMLuHi4y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).SourceProperty;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPauseResults_003Ed__98 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IAsyncDisposable> _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kMtBW55ruB1diBQssA7O();
			int num;
			if (HFugls5r10GwC4EsVLvC())
			{
				num = 1;
			}
			else
			{
				num = 5;
				if (kMtBW55ruB1diBQssA7O())
				{
				}
			}
			AppStepViewModel appStepViewModel = default;
			IAsyncDisposable result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					appStepViewModel = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((EasyBuilderApplicationViewModel)XVXaa15rhgdnyrRGyvQX(appStepViewModel)).PauseResults().GetAwaiter();
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							kMtBW55ruB1diBQssA7O();
							if (HFugls5r10GwC4EsVLvC())
							{
								num3 = 8;
							}
							else
							{
								num3 = 2;
								if (1 == 0)
								{
									goto IL_015e;
								}
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 0:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 8:
								_003C_003Eu__1 = default;
								goto case 2;
							case 9:
								break;
							}
							break;
						}
						goto IL_015e;
						IL_015e:
						result = awaiter.GetResult();
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
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
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
		internal static object XVXaa15rhgdnyrRGyvQX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HFugls5r10GwC4EsVLvC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kMtBW55ruB1diBQssA7O()
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
	private struct _003CEnterStep_003Ed__104 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public StepBase previousState;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			AppStepViewModel appStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					appStepViewModel = _003C_003E4__this;
					goto case 0;
				case 3:
					do
					{
						num2 = _003C_003E1__state;
						h6qqfq5rtAWbFjvaGZ6J();
						if (mGFEPH5rzaeNusyR0Zut())
						{
							num = 0;
							continue;
						}
						num = 4;
						break;
					}
					while (1 == 0);
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (h6qqfq5rtAWbFjvaGZ6J())
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							AppStepDisplayBase stepDisplay = appStepViewModel.StepDisplay;
							if (stepDisplay != null)
							{
								OMlp4T5PLpCOQ6MMGrVI(stepDisplay);
								goto IL_015c;
							}
							_ = 0;
							if (h6qqfq5rtAWbFjvaGZ6J())
							{
								num3 = 6;
							}
							else
							{
								num3 = 7;
								if (false)
								{
									goto IL_013f;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (mGFEPH5rzaeNusyR0Zut())
							{
							}
						}
						goto IL_00fc;
						IL_013f:
						num2 = (_003C_003E1__state = 0);
						num3 = 5;
						goto IL_00fc;
						IL_015c:
						awaiter = tUc4475PKhMNUHfHQDi2(appStepViewModel.zwtmxT5tVh(previousState));
						num3 = 3;
						goto IL_00fc;
						IL_00fc:
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 8:
								return;
							case 5:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 2:
								break;
							case 0:
							case 6:
								goto IL_015c;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 9;
								if (!mGFEPH5rzaeNusyR0Zut())
								{
									continue;
								}
								goto case 3;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_006d;
							}
							break;
						}
						goto IL_013f;
						end_IL_006d:;
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
		internal static void OMlp4T5PLpCOQ6MMGrVI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepDisplayBase)P_0).SetDisplayToStepMode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tUc4475PKhMNUHfHQDi2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h6qqfq5rtAWbFjvaGZ6J()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mGFEPH5rzaeNusyR0Zut()
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
	private struct _003CLeaveStep_003Ed__105 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public StepBase nextState;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!HnvJ765P53K8CNmYELMO()) ? 2 : 5);
			int num2 = default;
			AppStepViewModel appStepViewModel = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_019f:
				switch (num)
				{
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							AppStepDisplayBase stepDisplay = appStepViewModel.StepDisplay;
							if (stepDisplay != null)
							{
								P8T3j65PJXJPmiYRPNEi(stepDisplay);
								goto IL_004b;
							}
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						goto IL_00c7;
						IL_00c7:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 4:
								return;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							default:
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter.IsCompleted)
								{
									f2A29J5PweBH4MtlVK72();
									num3 = (HnvJ765P53K8CNmYELMO() ? 3 : 4);
									continue;
								}
								goto case 10;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (f2A29J5PweBH4MtlVK72())
								{
								}
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_00c7;
							}
							goto IL_004b;
							continue;
							end_IL_00c7:
							break;
						}
						goto end_IL_0024;
						IL_004b:
						awaiter = MEykTS5PartOV0lhBQLN(appStepViewModel.bjcmv2rUtn(nextState));
						num3 = 7;
						goto IL_00c7;
						end_IL_0024:;
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
					if (true)
					{
						goto IL_019f;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_019f;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				appStepViewModel = _003C_003E4__this;
				num = 3;
			}
			while (true);
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
		internal static void P8T3j65PJXJPmiYRPNEi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepDisplayBase)P_0).SetDisplayToNormalState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MEykTS5PartOV0lhBQLN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HnvJ765P53K8CNmYELMO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f2A29J5PweBH4MtlVK72()
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
	private struct _003COnUndo_003Ed__112 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			S9Hbgj5PeP3DfuJIqdaI();
			int num;
			if (!OA32qM5POvZyXVnoMcBC())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_01b9;
			IL_0041:
			int num2 = _003C_003E1__state;
			goto IL_0058;
			IL_01b9:
			AppStepViewModel appStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 4:
					goto IL_0041;
				case 1:
				case 3:
					goto IL_0058;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = B4mljD5PnJD6mXgQeDhj(kyjpK25PiZMfO0wdFEbG(O0AYhG5PDScHC7ePM2bY(jIoufp5PIIWaEjqp0VdC(appStepViewModel))));
							num3 = 4;
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
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 5:
								return;
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								if (!awaiter.IsCompleted)
								{
									OA32qM5POvZyXVnoMcBC();
									if (!S9Hbgj5PeP3DfuJIqdaI())
									{
										num3 = 7;
										continue;
									}
									num3 = 8;
									if (true)
									{
										continue;
									}
								}
								break;
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
					break;
				default:
					num = 2;
					if (0 == 0)
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
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				goto IL_0041;
			}
			goto IL_01b9;
			IL_0058:
			appStepViewModel = _003C_003E4__this;
			num = 5;
			goto IL_01b9;
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
		internal static object jIoufp5PIIWaEjqp0VdC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object O0AYhG5PDScHC7ePM2bY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kyjpK25PiZMfO0wdFEbG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter B4mljD5PnJD6mXgQeDhj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S9Hbgj5PeP3DfuJIqdaI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OA32qM5POvZyXVnoMcBC()
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
	private struct _003COnRedo_003Ed__114 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

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
			if (!BkiHBj5PfESsMnNyvua0())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_0063;
				}
			}
			goto IL_01b3;
			IL_0024:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01b3;
			IL_0063:
			int num2 = default;
			AppStepViewModel appStepViewModel = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = XKbkHk5PgS9UjIFf46dA(((UndoRedoQueue)dx2RyV5PlGY8eEJbJKeg(n1cy3l5PdMj422mupgQJ(appStepViewModel))).Redo());
					num3 = 2;
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
					default:
						return;
					case 7:
						return;
					case 3:
						_003C_003Eu__1 = default;
						num3 = 0;
						continue;
					case 2:
						if (awaiter.IsCompleted)
						{
							break;
						}
						_ = 0;
						if (SlmXOv5PV1ipMHRLh7ZJ())
						{
							num3 = 6;
							continue;
						}
						num3 = 7;
						if (true)
						{
							continue;
						}
						goto case 0;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 1:
					case 6:
						num2 = (_003C_003E1__state = 0);
						num3 = 5;
						continue;
					case 5:
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						if (!BkiHBj5PfESsMnNyvua0())
						{
							continue;
						}
						break;
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
			goto IL_0024;
			IL_01b3:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
				case 5:
					appStepViewModel = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					goto IL_0063;
				default:
					num = 3;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0024;
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
		internal static object n1cy3l5PdMj422mupgQJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dx2RyV5PlGY8eEJbJKeg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XKbkHk5PgS9UjIFf46dA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SlmXOv5PV1ipMHRLh7ZJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BkiHBj5PfESsMnNyvua0()
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
	private struct _003CRemoveSnippetAt_003Ed__115 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public int index;

		public bool removingAll;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (jOKEy55Pv62UC23kZXt3() ? 3 : 2);
			AppStepViewModel appStepViewModel = default;
			int num2 = default;
			EzSnippet ezSnippet = default;
			ValueTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 3:
					appStepViewModel = _003C_003E4__this;
					num = 4;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ezSnippet = appStepViewModel.Snippets[index];
							_ = 1;
							num3 = (jOKEy55Pv62UC23kZXt3() ? 10 : 6);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 16;
						}
						while (true)
						{
							switch (num3)
							{
							case 11:
								QuwEgb5PZElIq3fKuq1b(ezSnippet, new SnippetRenamedEventHandler(appStepViewModel.Snippet_Rename));
								num3 = 15;
								if (OuyvVn5Ps3C0MS41qAgG())
								{
									continue;
								}
								goto case 13;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 8:
								vfLnWr5Pbb2gSWBRExOL(ezSnippet, null);
								if (removingAll)
								{
									goto case 12;
								}
								UBUV6I5PGy6RKNeRbod4(appStepViewModel.Snippets, index);
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 0:
							case 6:
								if ((uint)index < (uint)CFQVIk5PrqJOCkFHIXjd(appStepViewModel.Snippets))
								{
									num3 = 1;
									continue;
								}
								goto end_IL_00e3;
							case 1:
								if (ezSnippet != null)
								{
									goto case 2;
								}
								goto end_IL_00e3;
							case 12:
								awaiter = ezSnippet.DisposeAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 14;
									continue;
								}
								break;
							case 15:
								ezSnippet.Copy -= appStepViewModel.Snippet_CopyAsync;
								num3 = 3;
								continue;
							case 2:
							case 10:
								Yf27Vd5PPOpxaYmLLCkB(ezSnippet, new EventHandler(appStepViewModel.Snippet_DependencyChanged));
								num3 = 4;
								continue;
							case 17:
								return;
							case 7:
								appStepViewModel.UpdateOrderValues();
								num3 = 9;
								continue;
							case 4:
								ezSnippet.Remove -= appStepViewModel.Snippet_RemoveAsync;
								num3 = 11;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 17;
								continue;
							case 14:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 9:
								lWmZmR5PofXqrVyLU7vh(appStepViewModel, ezSnippet);
								num3 = 12;
								if (OuyvVn5Ps3C0MS41qAgG())
								{
									continue;
								}
								goto case 16;
							case 16:
								_003C_003Eu__1 = default;
								num3 = 13;
								continue;
							case 3:
								VQrxMZ5PBAeUui0bTK8U(ezSnippet, null);
								num3 = 8;
								continue;
							case 18:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_00e3:
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
					break;
				case 0:
				case 2:
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
		internal static int CFQVIk5PrqJOCkFHIXjd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Collection<EzSnippet>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Yf27Vd5PPOpxaYmLLCkB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzSnippet)P_0).DependencyChanged -= (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QuwEgb5PZElIq3fKuq1b(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzSnippet)P_0).Rename -= (SnippetRenamedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VQrxMZ5PBAeUui0bTK8U(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzSnippet)P_0).Parent = (AppStepViewModel)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vfLnWr5Pbb2gSWBRExOL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzSnippet)P_0).InSight = (CvsInSight)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UBUV6I5PGy6RKNeRbod4(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Collection<EzSnippet>)P_0).RemoveAt(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lWmZmR5PofXqrVyLU7vh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).RemoveSnippetPropertiesFor((EzSnippet)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OuyvVn5Ps3C0MS41qAgG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jOKEy55Pv62UC23kZXt3()
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
	private struct _003CRemoveAllSnippets_003Ed__116 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public bool jobLoading;

		private int _003Ci_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (YxbcrW5PkTp3QSea8OM4() ? 4 : 3);
			int num2 = default;
			TaskAwaiter awaiter = default;
			int num4 = default;
			AppStepViewModel appStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 17;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 10;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 18;
						}
						while (true)
						{
							switch (num3)
							{
							case 18:
								num2 = (_003C_003E1__state = -1);
								_ = 0;
								if (TWJRS25PSRjXnYio3DBc())
								{
									num3 = 5;
									continue;
								}
								num3 = 13;
								if (TWJRS25PSRjXnYio3DBc())
								{
									continue;
								}
								goto case 15;
							case 5:
							case 7:
								awaiter.GetResult();
								num4 = _003Ci_003E5__2 - 1;
								num3 = 8;
								if (TWJRS25PSRjXnYio3DBc())
								{
									continue;
								}
								return;
							case 14:
								return;
							case 11:
							case 16:
								if (_003Ci_003E5__2 <= -1)
								{
									goto case 1;
								}
								awaiter = YGiOCx5PqEE5CcsTiQ2u(appStepViewModel.RemoveSnippetAt(_003Ci_003E5__2, removingAll: true));
								num3 = 4;
								continue;
							default:
								num3 = 1;
								continue;
							case 19:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 19;
									continue;
								}
								goto case 5;
							case 17:
								_003Ci_003E5__2 = CFwe1J5P8IParH9e2udQ(appStepViewModel.Snippets) - 1;
								num3 = 11;
								continue;
							case 12:
							case 13:
								awaiter = appStepViewModel.SetCurrentSnippet(null).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 20;
									if (0 == 0)
									{
										continue;
									}
									goto case 20;
								}
								goto case 15;
							case 20:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (TWJRS25PSRjXnYio3DBc())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 9:
								appStepViewModel.MainViewModel = null;
								num3 = 21;
								continue;
							case 1:
								R91Fmi5PESx9vjf8PpQf(appStepViewModel.Snippets);
								num3 = 0;
								if (TWJRS25PSRjXnYio3DBc())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003Ci_003E5__2 = num4;
								num3 = 16;
								continue;
							case 0:
								if (!jobLoading)
								{
									goto case 12;
								}
								goto case 9;
							case 15:
								awaiter.GetResult();
								num3 = 9;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 6:
								return;
							case 10:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 15;
								continue;
							case 21:
								appStepViewModel.UpdateShowInSightDisplay();
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
				default:
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 4:
					appStepViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 2:
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
		internal static int CFwe1J5P8IParH9e2udQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Collection<EzSnippet>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YGiOCx5PqEE5CcsTiQ2u(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void R91Fmi5PESx9vjf8PpQf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Collection<EzSnippet>)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TWJRS25PSRjXnYio3DBc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YxbcrW5PkTp3QSea8OM4()
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
	private struct _003CSnippet_RemoveAsync_003Ed__119 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public object sender;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			AppStepViewModel appStepViewModel = default;
			do
			{
				IL_0160:
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = OGE55m5P4dxgyajDh24d(n2lZrf5P9naibT9Aaim1(appStepViewModel, sender));
							num3 = 8;
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
							default:
								return;
							case 7:
								return;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								WbMXoR5Ppaml3IHgIcet();
								num3 = ((!zmy7ud5PXLewpeMw7HXH()) ? 1 : 7);
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
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
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_0160;
				case 1:
					appStepViewModel = _003C_003E4__this;
					_ = 0;
					if (!WbMXoR5Ppaml3IHgIcet())
					{
						num = 0;
						if (WbMXoR5Ppaml3IHgIcet())
						{
							goto IL_0160;
						}
						goto default;
					}
					num = 4;
					if (0 == 0)
					{
						goto IL_0160;
					}
					break;
				case 5:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 1;
			}
			while (true);
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
		internal static object n2lZrf5P9naibT9Aaim1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).Snippet_RemoveAsync(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter OGE55m5P4dxgyajDh24d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WbMXoR5Ppaml3IHgIcet()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zmy7ud5PXLewpeMw7HXH()
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
	private struct _003CSnippet_RemoveAsync_003Ed__120 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public object sender;

		public AppStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dwPkG15P7NRC3N6J96iC();
			int num;
			if (!XNT4hC5P3yWdlOEAGv9X())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_0052;
				}
			}
			goto IL_0221;
			IL_0052:
			int num2 = default;
			AppStepViewModel appStepViewModel = default;
			try
			{
				EzSnippet ezSnippet = default;
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					ezSnippet = sender as EzSnippet;
					_ = 0;
					num3 = ((!dwPkG15P7NRC3N6J96iC()) ? 1 : 5);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 8;
				}
				UndoActionBlockingProgressWrapper action = default;
				RemoveSnippetUndoAction undoAction = default;
				while (true)
				{
					switch (num3)
					{
					case 7:
						action = new UndoActionBlockingProgressWrapper(appStepViewModel.OperationProgressManager, undoAction, (string)LcpHw35PCtKacCmwK7wB(zC0s0E5P6J0Mtjf1QkiJ(), Ob0r0I5Pj3nKTpxUGfkn(ezSnippet)), string.Format((string)nc5f0f5PAO0ltORi7Rgn(), Ob0r0I5Pj3nKTpxUGfkn(ezSnippet)));
						num3 = 11;
						continue;
					case 10:
						return;
					case 11:
						awaiter = ((UndoRedoQueue)DQjkJj5PW8xd4KS6JBoU(PBEbFv5PRw2RTe0PgAmw(appStepViewModel))).AddUndo((IUndoAction)action).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							continue;
						}
						break;
					case 3:
						num2 = (_003C_003E1__state = 0);
						goto case 9;
					default:
						num3 = 9;
						continue;
					case 8:
						_003C_003Eu__1 = default;
						num3 = 2;
						continue;
					case 2:
						num2 = (_003C_003E1__state = -1);
						num3 = 12;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
					case 5:
						if (ezSnippet != null)
						{
							num3 = 4;
							if (dwPkG15P7NRC3N6J96iC())
							{
								continue;
							}
							goto case 9;
						}
						goto end_IL_0114;
					case 9:
						_003C_003Eu__1 = awaiter;
						goto case 1;
					case 4:
						undoAction = new RemoveSnippetUndoAction(appStepViewModel, (string)Ob0r0I5Pj3nKTpxUGfkn(ezSnippet));
						num3 = 7;
						continue;
					case 1:
					case 6:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 10;
						continue;
					case 12:
						break;
					}
					awaiter.GetResult();
					break;
					continue;
					end_IL_0114:
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
			goto IL_024c;
			IL_024c:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0221;
			IL_0221:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					appStepViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_024c;
				case 6:
					return;
				}
				break;
			}
			goto IL_0052;
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
		internal static object Ob0r0I5Pj3nKTpxUGfkn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zC0s0E5P6J0Mtjf1QkiJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.hWv9WN9SZ5();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LcpHw35PCtKacCmwK7wB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nc5f0f5PAO0ltORi7Rgn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.dnvGtdDUjy();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PBEbFv5PRw2RTe0PgAmw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DQjkJj5PW8xd4KS6JBoU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dwPkG15P7NRC3N6J96iC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XNT4hC5P3yWdlOEAGv9X()
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
	private struct _003CSnippet_CopyAsync_003Ed__121 : IAsyncStateMachine
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
			int num = 3;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (fyeIdR5PTQViI4QCBbWk() ? 4 : 0);
					continue;
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = U1Chgw5PFGQDZt3fkOE3(Owh39P5P0Uy2uJ4I0lZN());
							num3 = 8;
							if (anabUK5PywKs1oEbLVR9())
							{
								goto IL_0056;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						goto IL_0076;
						IL_0076:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							default:
								goto IL_00a3;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 0:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!anabUK5PywKs1oEbLVR9())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (fyeIdR5PTQViI4QCBbWk())
								{
									continue;
								}
								goto case 8;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 9;
							case 7:
								_003C_003Eu__1 = default;
								goto case 0;
							case 3:
							case 4:
								return;
							case 9:
								awaiter.GetResult();
								goto end_IL_0035;
							}
							break;
						}
						goto IL_0056;
						IL_00a3:
						_ = 0;
						if (fyeIdR5PTQViI4QCBbWk())
						{
							num3 = 3;
						}
						else
						{
							num3 = 0;
							if (false)
							{
								return;
							}
						}
						goto IL_0076;
						IL_0056:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto IL_00a3;
						end_IL_0035:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 5;
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
		internal static object Owh39P5P0Uy2uJ4I0lZN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter U1Chgw5PFGQDZt3fkOE3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fyeIdR5PTQViI4QCBbWk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool anabUK5PywKs1oEbLVR9()
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
	private struct _003CRemoveSnippetInternal_003Ed__128 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AppStepViewModel _003C_003E4__this;

		public EzSnippet snippet;

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
			AppStepViewModel appStepViewModel = default;
			int index = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					OXCpcm5PYwOs5H9tgfod();
					if (a8w0415PMcUWksXf98CZ())
					{
						num = 4;
						if (true)
						{
							break;
						}
						goto case 1;
					}
					num = 2;
					break;
				case 1:
				case 4:
					appStepViewModel = _003C_003E4__this;
					num = 5;
					if (a8w0415PMcUWksXf98CZ())
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							index = appStepViewModel.Snippets.IndexOf(snippet);
							_ = 1;
							if (!OXCpcm5PYwOs5H9tgfod())
							{
								num3 = 5;
							}
							else
							{
								num3 = 1;
								if (OXCpcm5PYwOs5H9tgfod())
								{
								}
							}
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
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (a8w0415PMcUWksXf98CZ())
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 0:
							case 5:
								awaiter = GGQdLC5PUbop8uq4wMHJ(appStepViewModel.RemoveSnippetAt(index));
								num3 = 6;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (true)
								{
									continue;
								}
								return;
							case 9:
								return;
							case 10:
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
		internal static TaskAwaiter GGQdLC5PUbop8uq4wMHJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a8w0415PMcUWksXf98CZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OXCpcm5PYwOs5H9tgfod()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static ILogger n9fmKJh8aA;

	[CompilerGenerated]
	private AsyncDelegateCommand pXMmGxOLO2;

	[CompilerGenerated]
	private AsyncDelegateCommand FsXmBxBVCM;

	[CompilerGenerated]
	private EventHandler fXSmZUacsg;

	[CompilerGenerated]
	private SnippetRenamedEventHandler TwymnftWqa;

	[CompilerGenerated]
	private Func<object, SnippetAddedEventArgs, Task> S86mtPmG87;

	[CompilerGenerated]
	private Func<object, SnippetPreRemoveEventArgs, Task> ccdmYtekeX;

	[CompilerGenerated]
	private Func<object, SnippetRemoveEventArgs, Task> SwWm0MYoai;

	private EasyBuilderApplicationViewModel nQ5mVFdwgJ;

	private CvsInSight xspmL37bMP;

	private IRuntimeModeService Cs4mJNWJbp;

	[CompilerGenerated]
	private AppStepDisplayBase Najm9M0DvF;

	private bool fS1mr1pOQK;

	private bool zxZmhpZC9W;

	private EzSnippet lnbm8uZy6I;

	[CompilerGenerated]
	private readonly ObservableCollection<EzSnippet> eaImmry2cd;

	private EzSnippetType q0Pm1A54UY;

	private BaseViewModel FNLmzNU4jU;

	private IRuntimeService ypr1aPh0G9;

	private bool R9J158tVjn;

	[CompilerGenerated]
	private Dispatcher hHW1pF1Myk;

	protected readonly CvsJobAnalyzer Analyzer;

	public AsyncDelegateCommand UndoCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pXMmGxOLO2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pXMmGxOLO2 = value;
		}
	}

	public AsyncDelegateCommand RedoCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FsXmBxBVCM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FsXmBxBVCM = value;
		}
	}

	public abstract string Category { get; }

	public abstract string HelpTopic { get; }

	public virtual EasyBuilderApplicationViewModel AppViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nQ5mVFdwgJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 6:
					CosiocKKzZeIYfB82pBL(this, null);
					num = 7;
					continue;
				case 1:
					if (nQ5mVFdwgJ != null)
					{
						num = 8;
						continue;
					}
					goto case 2;
				case 2:
				case 4:
					SetField(ref nQ5mVFdwgJ, value, (string)ycqwSFK5LlDIyqVMeTB7(47138));
					goto case 0;
				case 0:
				case 5:
					if (nQ5mVFdwgJ != null)
					{
						num = 3;
						continue;
					}
					return;
				case 8:
					QFZx8NKKtsqIpEMaDvRR(nQ5mVFdwgJ, new EventHandler(AppViewModel_ActiveStepChanged));
					num = 6;
					if (!B9AXM2KKc7olm2Q9phHN())
					{
						continue;
					}
					goto case 3;
				case 3:
					HQj18WK5Kq9ojbgxolbC(nQ5mVFdwgJ, new EventHandler(AppViewModel_ActiveStepChanged));
					num = 9;
					continue;
				case 7:
					RuntimeService = null;
					goto default;
				default:
					fe8uvWKK2T2V4LwXGh6A();
					if (B9AXM2KKc7olm2Q9phHN())
					{
						num = 0;
						continue;
					}
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 9:
					break;
				}
				object obj = Kx2TcSK55iJUsSfb1p7D(nQ5mVFdwgJ);
				CosiocKKzZeIYfB82pBL(this, (obj != null) ? teg82rK5wKvGbyISl1VJ(obj) : null);
				RuntimeViewModel runtime = nQ5mVFdwgJ.Runtime;
				RuntimeService = (IRuntimeService)((runtime != null) ? p6Zcs9K5JHv2tZTcF1Vr(runtime) : null);
				break;
			}
		}
	}

	public virtual CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xspmL37bMP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xspmL37bMP = value;
		}
	}

	public virtual IRuntimeModeService RuntimeModeService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cs4mJNWJbp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 5:
					SetField(ref Cs4mJNWJbp, value, (string)ycqwSFK5LlDIyqVMeTB7(5250));
					goto case 2;
				default:
					num = 2;
					break;
				case 1:
				case 6:
					Cs4mJNWJbp.RuntimeModeChanged -= RuntimeModeService_RuntimeModeChanged;
					num = 5;
					break;
				case 3:
					if (Cs4mJNWJbp != null)
					{
						_ = 1;
						if (!B9AXM2KKc7olm2Q9phHN())
						{
							num = 6;
							break;
						}
						num = 0;
						if (0 == 0)
						{
							break;
						}
						return;
					}
					goto case 5;
				case 0:
				case 4:
					Cs4mJNWJbp.RuntimeModeChanged += RuntimeModeService_RuntimeModeChanged;
					num = 7;
					break;
				case 2:
					if (Cs4mJNWJbp != null)
					{
						goto case 0;
					}
					return;
				case 7:
					return;
				}
			}
		}
	}

	public AppStepDisplayBase StepDisplay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Najm9M0DvF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Najm9M0DvF = value;
		}
	}

	public bool ShowInSightDisplay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fS1mr1pOQK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref fS1mr1pOQK, value, (string)ycqwSFK5LlDIyqVMeTB7(47166));
		}
	}

	public bool IsInSnippetEditMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zxZmhpZC9W;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
				{
					EzSnippet currentSnippet = CurrentSnippet;
					if (currentSnippet == null)
					{
						num = 5;
						if (true)
						{
							break;
						}
						goto case 1;
					}
					KaVQ6CK5asErKpvcE86v(currentSnippet);
					return;
				}
				case 1:
				case 4:
					UpdateShowInSightDisplay();
					goto default;
				case 3:
					do
					{
						if (SetField(ref zxZmhpZC9W, value, (string)ycqwSFK5LlDIyqVMeTB7(47206)))
						{
							_ = 0;
							if (!fe8uvWKK2T2V4LwXGh6A())
							{
								num = 0;
								continue;
							}
							num = 4;
							break;
						}
						return;
					}
					while (false);
					break;
				case 5:
					return;
				}
			}
		}
	}

	public EzSnippet CurrentSnippet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lnbm8uZy6I;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			B9AXM2KKc7olm2Q9phHN();
			int num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 9 : 3);
			Action<string> method = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (lnbm8uZy6I != null)
					{
						num = 8;
						if (true)
						{
							break;
						}
						goto case 0;
					}
					goto case 4;
				case 0:
				case 3:
					if (lnbm8uZy6I != value)
					{
						num = 6;
						break;
					}
					return;
				case 7:
					method = FirePropertyChanged;
					num = 5;
					break;
				case 2:
				case 9:
					lnbm8uZy6I = value;
					num = 1;
					break;
				case 5:
					FgqmkYdnnf().BeginInvoke(method, ycqwSFK5LlDIyqVMeTB7(47248));
					num = 10;
					break;
				case 8:
					vqQCadK5e3p5wQ1J4L9d(lnbm8uZy6I, new EventHandler(nkymy82okm));
					goto case 4;
				default:
					num = 4;
					break;
				case 4:
					MainViewModel = lnbm8uZy6I?.MainViewModel;
					UpdateShowInSightDisplay();
					num = 7;
					if (fe8uvWKK2T2V4LwXGh6A())
					{
						break;
					}
					goto case 10;
				case 10:
					JGjMLTK5Oy1TEODrwfrj(this);
					num = 11;
					break;
				case 6:
					if (lnbm8uZy6I != null)
					{
						lnbm8uZy6I.ppQ5ZMA0ch(nkymy82okm);
					}
					goto case 2;
				case 11:
					return;
				}
			}
		}
	}

	public ObservableCollection<EzSnippet> Snippets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eaImmry2cd;
		}
	}

	public EzSnippetType AddingSnippetType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return q0Pm1A54UY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 6 : 4);
			while (true)
			{
				switch (num)
				{
				case 5:
					NrnnXgK5DZNWiGJESLWB(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(47318));
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 4:
					if (SetField(ref q0Pm1A54UY, value, (string)ycqwSFK5LlDIyqVMeTB7(47280)))
					{
						goto case 1;
					}
					return;
				case 1:
				case 6:
					IUsyg6K5I7wp5xfv3xgi(this);
					num = 5;
					break;
				case 2:
					t2RIMgK5icRSxSUW1GU0(RedoCommand);
					num = 7;
					break;
				case 3:
					t2RIMgK5icRSxSUW1GU0(UndoCommand);
					num = 2;
					break;
				case 7:
					return;
				}
			}
		}
	}

	public bool IsAddingSnippet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AddingSnippetType != null;
		}
	}

	public BaseViewModel MainViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (FNLmzNU4jU != null)
			{
				return FNLmzNU4jU;
			}
			return this;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref FNLmzNU4jU, value, (string)ycqwSFK5LlDIyqVMeTB7(1014));
		}
	}

	public IRuntimeService RuntimeService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ypr1aPh0G9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 3:
				case 4:
					ypr1aPh0G9.SheetExecuted += RuntimeService_SheetExecuted;
					num = 7;
					break;
				case 5:
					if (ypr1aPh0G9 != null)
					{
						fe8uvWKK2T2V4LwXGh6A();
						if (!B9AXM2KKc7olm2Q9phHN())
						{
							num = 2;
							break;
						}
						num = 3;
						if (true)
						{
							break;
						}
						return;
					}
					goto case 0;
				case 1:
				case 2:
					ypr1aPh0G9.SheetExecuted -= RuntimeService_SheetExecuted;
					num = 0;
					break;
				case 0:
					ypr1aPh0G9 = value;
					goto case 6;
				default:
					num = 6;
					break;
				case 6:
					if (ypr1aPh0G9 != null)
					{
						goto case 3;
					}
					return;
				case 7:
					return;
				}
			}
		}
	}

	public IOperationProgressManager OperationProgressManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)rDuKB6K5nlFcUVXb64eQ(this))?.OperationProgressManager;
		}
	}

	public event EventHandler DependencyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					eventHandler2 = eventHandler;
					fe8uvWKK2T2V4LwXGh6A();
					num = ((!B9AXM2KKc7olm2Q9phHN()) ? 1 : 0);
					break;
				case 0:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 5;
				case 1:
				case 2:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto case 6;
				default:
					num = 6;
					break;
				case 3:
					eventHandler = fXSmZUacsg;
					num = 5;
					if (fe8uvWKK2T2V4LwXGh6A())
					{
						break;
					}
					goto case 6;
				case 6:
					eventHandler = Interlocked.CompareExchange(ref fXSmZUacsg, value2, eventHandler2);
					goto case 0;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 6:
					eventHandler2 = eventHandler;
					goto case 2;
				case 3:
					eventHandler = Interlocked.CompareExchange(ref fXSmZUacsg, value2, eventHandler2);
					num = 0;
					break;
				case 0:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 4:
					eventHandler = fXSmZUacsg;
					_ = 0;
					num = (fe8uvWKK2T2V4LwXGh6A() ? 6 : 5);
					break;
				case 2:
				case 5:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					goto case 3;
				default:
					num = 3;
					break;
				case 7:
					return;
				}
			}
		}
	}

	public event SnippetRenamedEventHandler SnippetRenamed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 5 : 6);
			SnippetRenamedEventHandler snippetRenamedEventHandler = default;
			SnippetRenamedEventHandler snippetRenamedEventHandler2 = default;
			SnippetRenamedEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					if ((object)snippetRenamedEventHandler == snippetRenamedEventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 0:
				case 6:
					snippetRenamedEventHandler = TwymnftWqa;
					goto case 1;
				case 1:
				case 5:
					snippetRenamedEventHandler2 = snippetRenamedEventHandler;
					num = 3;
					break;
				case 2:
					snippetRenamedEventHandler = Interlocked.CompareExchange(ref TwymnftWqa, value2, snippetRenamedEventHandler2);
					num = 4;
					if (fe8uvWKK2T2V4LwXGh6A())
					{
						break;
					}
					goto case 3;
				case 3:
					value2 = (SnippetRenamedEventHandler)Kf62UuKKu2aUoWI4Hb4T(snippetRenamedEventHandler2, value);
					goto case 2;
				default:
					num = 2;
					break;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (fe8uvWKK2T2V4LwXGh6A())
			{
				num = 1;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 6;
			}
			goto IL_0087;
			IL_0026:
			SnippetRenamedEventHandler snippetRenamedEventHandler = TwymnftWqa;
			num = 2;
			if (false)
			{
				goto IL_0039;
			}
			goto IL_0087;
			IL_00b6:
			SnippetRenamedEventHandler snippetRenamedEventHandler2 = snippetRenamedEventHandler;
			num = 3;
			goto IL_0087;
			IL_0039:
			SnippetRenamedEventHandler value2 = default;
			snippetRenamedEventHandler = Interlocked.CompareExchange(ref TwymnftWqa, value2, snippetRenamedEventHandler2);
			goto IL_0057;
			IL_0087:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 5:
					goto IL_0039;
				case 4:
				case 6:
					goto IL_0057;
				case 3:
					value2 = (SnippetRenamedEventHandler)pSA59TKKhVcDyYXmKgdZ(snippetRenamedEventHandler2, value);
					goto IL_0039;
				default:
					num = 5;
					continue;
				case 2:
					goto IL_00b6;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0057:
			if ((object)snippetRenamedEventHandler == snippetRenamedEventHandler2)
			{
				num = 7;
				goto IL_0087;
			}
			goto IL_00b6;
		}
	}

	public event Func<object, SnippetAddedEventArgs, Task> SnippetAdded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, SnippetAddedEventArgs, Task> func = S86mtPmG87;
			Func<object, SnippetAddedEventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, SnippetAddedEventArgs, Task> value2 = (Func<object, SnippetAddedEventArgs, Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref S86mtPmG87, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, SnippetAddedEventArgs, Task> func = S86mtPmG87;
			Func<object, SnippetAddedEventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, SnippetAddedEventArgs, Task> value2 = (Func<object, SnippetAddedEventArgs, Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref S86mtPmG87, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event Func<object, SnippetPreRemoveEventArgs, Task> SnippetPreRemove
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, SnippetPreRemoveEventArgs, Task> func = ccdmYtekeX;
			Func<object, SnippetPreRemoveEventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, SnippetPreRemoveEventArgs, Task> value2 = (Func<object, SnippetPreRemoveEventArgs, Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref ccdmYtekeX, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, SnippetPreRemoveEventArgs, Task> func = ccdmYtekeX;
			Func<object, SnippetPreRemoveEventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, SnippetPreRemoveEventArgs, Task> value2 = (Func<object, SnippetPreRemoveEventArgs, Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref ccdmYtekeX, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event Func<object, SnippetRemoveEventArgs, Task> SnippetRemove
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, SnippetRemoveEventArgs, Task> func = SwWm0MYoai;
			Func<object, SnippetRemoveEventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, SnippetRemoveEventArgs, Task> value2 = (Func<object, SnippetRemoveEventArgs, Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref SwWm0MYoai, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, SnippetRemoveEventArgs, Task> func = SwWm0MYoai;
			Func<object, SnippetRemoveEventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, SnippetRemoveEventArgs, Task> value2 = (Func<object, SnippetRemoveEventArgs, Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref SwWm0MYoai, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AppStepViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 1;
				if (true)
				{
					break;
				}
				goto default;
			default:
				HUSmPYvx72((Dispatcher)PWlaZgKK1qpGSvLo8ZVV());
				num = 0;
				if (!B9AXM2KKc7olm2Q9phHN())
				{
					break;
				}
				goto case 6;
			case 6:
				R9J158tVjn = true;
				B9AXM2KKc7olm2Q9phHN();
				if (fe8uvWKK2T2V4LwXGh6A())
				{
					num = 9;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 8;
				break;
			case 1:
				eaImmry2cd = new ObservableCollection<EzSnippet>();
				num = 6;
				break;
			case 4:
				RedoCommand = new AsyncDelegateCommand(OnRedo, CanRedo);
				num = 10;
				if (!B9AXM2KKc7olm2Q9phHN())
				{
					break;
				}
				goto case 0;
			case 0:
				UndoCommand = new AsyncDelegateCommand(OnUndo, CanUndo);
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
			case 9:
				Analyzer = new CvsJobAnalyzer();
				num = 7;
				if (fe8uvWKK2T2V4LwXGh6A())
				{
					break;
				}
				goto case 7;
			case 7:
				base._002Ector();
				goto default;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__2))]
	public virtual ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (fe8uvWKK2T2V4LwXGh6A())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_003e;
			}
		}
		goto IL_0088;
		IL_0058:
		_003CDisposeAsync_003Ed__2 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
		num = 5;
		goto IL_0088;
		IL_003e:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (1 == 0)
		{
			goto IL_0058;
		}
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 3:
				break;
			case 0:
			case 1:
				goto IL_0058;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 3;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_003e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal bool hNFm2VxOH5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return R9J158tVjn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal void tavmqlZOoL(bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B9AXM2KKc7olm2Q9phHN();
		int num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 0:
			case 3:
				R9J158tVjn = value;
				goto case 1;
			case 1:
			case 4:
			{
				EzSnippet currentSnippet = CurrentSnippet;
				if (currentSnippet == null)
				{
					return;
				}
				t2RIMgK5icRSxSUW1GU0(currentSnippet.DeleteCommand);
				num = 5;
				break;
			}
			default:
				num = 2;
				if (false)
				{
					return;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal Dispatcher FgqmkYdnnf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return hHW1pF1Myk;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void HUSmPYvx72(Dispatcher value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hHW1pF1Myk = value;
	}

	public abstract Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading);

	public abstract Task CompleteInitializationAsync(ISnippetManager snippetManager);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSnippet_003Ed__88))]
	public virtual Task RemoveSnippet(EzSnippet snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fe8uvWKK2T2V4LwXGh6A();
		int num;
		if (!B9AXM2KKc7olm2Q9phHN())
		{
			num = 4;
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_0046;
			}
		}
		goto IL_0072;
		IL_0072:
		_003CRemoveSnippet_003Ed__88 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				break;
			case 1:
			case 6:
				break;
			case 3:
				stateMachine.snippet = snippet;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				continue;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0046;
		IL_0046:
		stateMachine._003C_003E4__this = this;
		num = 3;
		goto IL_0072;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFireSnippetAdded_003Ed__89))]
	public virtual Task FireSnippetAdded(SnippetAddedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0082;
		IL_001a:
		_003CFireSnippetAdded_003Ed__89 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0050;
		IL_0082:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
				goto IL_0032;
			case 1:
			case 4:
				goto IL_0050;
			case 2:
			case 5:
				stateMachine.e = e;
				break;
			default:
				num = 3;
				continue;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 0;
				if (B9AXM2KKc7olm2Q9phHN())
				{
				}
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0032:
			stateMachine._003C_003E4__this = this;
			_ = 0;
			num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 1 : 5);
		}
		goto IL_001a;
		IL_0050:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0082;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFireSnippetPreRemove_003Ed__90))]
	public virtual Task FireSnippetPreRemove(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CFireSnippetPreRemove_003Ed__90 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 3:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 5:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				_ = 1;
				if (!B9AXM2KKc7olm2Q9phHN())
				{
					num = 2;
					if (B9AXM2KKc7olm2Q9phHN())
					{
					}
				}
				else
				{
					num = 3;
					if (B9AXM2KKc7olm2Q9phHN())
					{
					}
				}
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 0:
				stateMachine.e = e;
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
	[AsyncStateMachine(typeof(_003CFireSnippetRemove_003Ed__91))]
	public virtual Task FireSnippetRemove(SnippetRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B9AXM2KKc7olm2Q9phHN();
		int num;
		if (fe8uvWKK2T2V4LwXGh6A())
		{
			num = 1;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_00a6;
		IL_008c:
		_003CFireSnippetRemove_003Ed__91 stateMachine = default;
		stateMachine.e = e;
		goto IL_0062;
		IL_00a6:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				num = 3;
				if (B9AXM2KKc7olm2Q9phHN())
				{
				}
				continue;
			case 6:
				goto IL_0062;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 2:
			case 4:
				goto IL_008c;
			default:
				num = 6;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E4__this = this;
		goto IL_008c;
		IL_0062:
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_00a6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerable<CellViewModel> GetLinkableProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.SelectMany(ExposedProperties);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePropertiesGrouped(CellViewModel targetProperty, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enumerable.Empty<IGrouping<string, CellViewModel>>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePrimitivesGrouped(CellViewModel targetProperty = null, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enumerable.Empty<IGrouping<string, CellViewModel>>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetCurrentSnippet_003Ed__95))]
	public virtual Task SetCurrentSnippet(EzSnippet snippet, bool isRuntimeModeChange = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!B9AXM2KKc7olm2Q9phHN())
		{
			num = 4;
			if (!fe8uvWKK2T2V4LwXGh6A())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0068;
		IL_002a:
		_003CSetCurrentSnippet_003Ed__95 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0068;
		IL_0068:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				continue;
			case 5:
				stateMachine.snippet = snippet;
				goto case 3;
			default:
				num = 3;
				continue;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (B9AXM2KKc7olm2Q9phHN())
				{
				}
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsSnippetNameUsed(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass96_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass96_0();
		CS_0024_003C_003E8__locals2.name = name;
		return Snippets.Any([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet snippet) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass96_0.J7doxi5rUY2KmC82xT16(_003C_003Ec__DisplayClass96_0.ppZ4SQ5rYuwCVl1rsA9P(snippet), CS_0024_003C_003E8__locals2.name, StringComparison.CurrentCultureIgnoreCase);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GenerateUniqueSnippetName(string baseName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!B9AXM2KKc7olm2Q9phHN())
		{
			num = 5;
		}
		else
		{
			num = 2;
			if (!fe8uvWKK2T2V4LwXGh6A())
			{
				goto IL_0112;
			}
		}
		string text = default;
		int num2 = default;
		HashSet<string> hashSet = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				text = (string)CUBDE9K5duIlL5M5pXSA(ycqwSFK5LlDIyqVMeTB7(1170), baseName, ++num2);
				num = 6;
				if (fe8uvWKK2T2V4LwXGh6A())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				hashSet = new HashSet<string>(Snippets.Select([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet it) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return (string)_003C_003Ec.xJEAKx5rNVCYsM5s3c2Z(it);
				}));
				num = 4;
				continue;
			case 6:
				if (!hashSet.Contains(text))
				{
					num = 7;
					continue;
				}
				goto case 3;
			case 4:
				num2 = 0;
				goto case 3;
			default:
				num = 3;
				continue;
			case 0:
			case 5:
				baseName = (string)cZoH3LK5fmQ12vI4CKNy(baseName, ycqwSFK5LlDIyqVMeTB7(1878), "");
				goto case 1;
			case 7:
				break;
			}
			break;
		}
		goto IL_0112;
		IL_0112:
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPauseResults_003Ed__98))]
	public virtual Task<IAsyncDisposable> PauseResults()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPauseResults_003Ed__98 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IAsyncDisposable>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Refresh(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EzSnippet> GetDependentSnippets(EzSnippet snip, bool recursive, CvsCellCollection cells = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<EzSnippet> list = new List<EzSnippet>();
		list.Add(snip);
		foreach (CvsCellLocation dependentCell in GetDependentCells(snip.CellRange, recursive, cells))
		{
			EzSnippet ezSnippet = dHomwE5fPG(dependentCell);
			if (ezSnippet != null && !list.Contains(ezSnippet))
			{
				list.Add(ezSnippet);
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsCellLocation> GetDependentCells(CvsCellRange cellRange, bool recursive, CvsCellCollection cells = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Analyzer.Validate(cells);
		List<CvsCellLocation> list = new List<CvsCellLocation>();
		List<CvsCellLocation> list2 = new List<CvsCellLocation>();
		CvsCellLocation location = cellRange.Location;
		for (int i = cellRange.Row; i <= cellRange.LastRow; i++)
		{
			location.Row = i;
			for (int j = cellRange.Column; j <= cellRange.LastColumn; j++)
			{
				location.Column = j;
				CvsCellReferenceInfo cellReferenceInfo = Analyzer.GetCellReferenceInfo(location);
				if (cellReferenceInfo == null)
				{
					continue;
				}
				CvsCellReference[] dependents = cellReferenceInfo.Dependents;
				foreach (CvsCellReference cvsCellReference in dependents)
				{
					if (!list.Contains(cvsCellReference.CellLocation))
					{
						list.Add(cvsCellReference.CellLocation);
						list2.Add(cvsCellReference.CellLocation);
					}
				}
			}
		}
		if (recursive)
		{
			GetDependentCells(list, list2);
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsCellLocation> GetPrecedentCells(CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsCellLocation> list = new List<CvsCellLocation>();
		Analyzer.Validate();
		CvsCellReferenceInfo cellReferenceInfo = Analyzer.GetCellReferenceInfo(loc);
		if (cellReferenceInfo != null)
		{
			CvsCellReference[] precedents = cellReferenceInfo.Precedents;
			for (int i = 0; i < precedents.Length; i++)
			{
				foreach (CvsCellLocation item in precedents[i].ReferencedRange)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal virtual void RefreshPotentialDependencies(EzSnippet source)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using (tCEGyJK5lG5CmQY2Xd4v(CvsTraceEzb.Info, ycqwSFK5LlDIyqVMeTB7(47352)))
		{
			EzSnippet[] array = Snippets.ToArray();
			int num = 1;
			int num2 = default;
			EzSnippet ezSnippet = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = 0;
					num = 0;
					break;
				case 7:
					if (Snippets.Contains(ezSnippet))
					{
						goto case 4;
					}
					goto case 5;
				case 4:
				case 6:
					ezSnippet.RefreshPotentialDependencies();
					num = 5;
					break;
				case 5:
					num2++;
					num = 8;
					if (fe8uvWKK2T2V4LwXGh6A())
					{
						break;
					}
					goto case 0;
				case 2:
				case 3:
					if (ezSnippet != source)
					{
						goto case 7;
					}
					goto case 5;
				default:
					num = 7;
					break;
				case 0:
				case 8:
					if (num2 < array.Length)
					{
						ezSnippet = array[num2];
						_ = 0;
						if (!fe8uvWKK2T2V4LwXGh6A())
						{
							num = 6;
							if (0 == 0)
							{
								break;
							}
							goto case 4;
						}
						num = 3;
						break;
					}
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnterStep_003Ed__104))]
	internal override Task EnterStep(StepBase previousState)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CEnterStep_003Ed__104 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				_ = 0;
				num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 3 : 0);
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 3:
				stateMachine.previousState = previousState;
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
	[AsyncStateMachine(typeof(_003CLeaveStep_003Ed__105))]
	internal override Task LeaveStep(StepBase nextState)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!fe8uvWKK2T2V4LwXGh6A())
		{
			goto IL_001e;
		}
		goto IL_0068;
		IL_001e:
		_003CLeaveStep_003Ed__105 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0068;
		IL_0068:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				break;
			case 2:
			case 3:
				stateMachine.nextState = nextState;
				goto case 6;
			default:
				num = 6;
				if (!B9AXM2KKc7olm2Q9phHN())
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (B9AXM2KKc7olm2Q9phHN())
				{
					num = 1;
					continue;
				}
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AfKmOqFtTQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = fXSmZUacsg;
		if (eventHandler != null)
		{
			iPMxFDK5g7oh50f2WmBM(eventHandler, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EzSnippet btvmHNqEjR(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		EzSnippet result = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				result = null;
				B9AXM2KKc7olm2Q9phHN();
				num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 5 : 2);
				continue;
			case 1:
			case 2:
				cvsCell = (CvsCell)iiwNliK5v0BoIJjGoWTI(((CvsResultSet)YbrjSnK5sa3tAbeaYefP(InSight)).Cells, P_0);
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				if (cvsCell == null)
				{
					break;
				}
				goto default;
			default:
				result = dHomwE5fPG(cvsCell.Location);
				num = 6;
				continue;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EzSnippet dHomwE5fPG(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B9AXM2KKc7olm2Q9phHN();
		int num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 3 : 2);
		EzSnippet result = default;
		IEnumerator<EzSnippet> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				result = null;
				goto case 1;
			case 1:
			case 3:
				enumerator = Snippets.GetEnumerator();
				break;
			default:
				goto IL_0071;
			case 4:
				break;
			}
			break;
			IL_0071:
			num = 4;
		}
		try
		{
			while (KLCqtpK5POI61VwvBdU2(enumerator))
			{
				EzSnippet current = enumerator.Current;
				fe8uvWKK2T2V4LwXGh6A();
				int num2;
				if (!B9AXM2KKc7olm2Q9phHN())
				{
					num2 = 3;
				}
				else
				{
					num2 = 2;
					if (!fe8uvWKK2T2V4LwXGh6A())
					{
						break;
					}
				}
				while (true)
				{
					switch (num2)
					{
					default:
						result = current;
						num2 = 4;
						continue;
					case 0:
					case 3:
						if (!UJPV42K5rD3UFY7FP9Nc(current, P_0))
						{
							goto IL_00ff;
						}
						goto default;
					case 4:
						break;
					}
					break;
				}
				break;
				IL_00ff:;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				qUZpkrK5ZH7uYIlAb6uw(enumerator);
			}
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnAddingSnippetTypeChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnCurrentSnippetChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CanUndo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (fWEGDHK5bKlQEviv2qj7(MngSG9K5BU4HXyuJSMyg(this)))
		{
			return !IsAddingSnippet;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnUndo_003Ed__112))]
	protected virtual Task OnUndo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 1 : 3);
		_003COnUndo_003Ed__112 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				num = 5;
				if (fe8uvWKK2T2V4LwXGh6A())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CanRedo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (fWEGDHK5bKlQEviv2qj7(MngSG9K5BU4HXyuJSMyg(this)))
		{
			return !IsAddingSnippet;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnRedo_003Ed__114))]
	protected virtual Task OnRedo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!B9AXM2KKc7olm2Q9phHN())
		{
			num = 2;
			if (B9AXM2KKc7olm2Q9phHN())
			{
			}
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0076;
			}
		}
		goto IL_0090;
		IL_0040:
		_003COnRedo_003Ed__114 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0090;
		IL_0076:
		stateMachine._003C_003E1__state = -1;
		goto IL_0040;
		IL_0090:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 5:
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				goto case 1;
			case 3:
				goto IL_0076;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0040;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSnippetAt_003Ed__115))]
	protected virtual Task RemoveSnippetAt(int index, bool removingAll = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CRemoveSnippetAt_003Ed__115 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				stateMachine.removingAll = removingAll;
				goto default;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				continue;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 2:
				stateMachine.index = index;
				B9AXM2KKc7olm2Q9phHN();
				if (!fe8uvWKK2T2V4LwXGh6A())
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				num = 5;
				continue;
			case 1:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveAllSnippets_003Ed__116))]
	protected virtual Task RemoveAllSnippets(bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0098;
		IL_001a:
		_003CRemoveAllSnippets_003Ed__116 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 4;
		goto IL_0098;
		IL_0098:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 2:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				fe8uvWKK2T2V4LwXGh6A();
				if (!B9AXM2KKc7olm2Q9phHN())
				{
					num = 6;
					if (true)
					{
						continue;
					}
					goto default;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				continue;
			case 4:
				stateMachine.jobLoading = jobLoading;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Snippet_DependencyChanged(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hvgRoIK5GBPe3YMn4mMD(Analyzer);
		K5sosTK5onRAdKq0pRBw(this, sender as EzSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Snippet_Rename(object sender, SnippetRenamedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fe8uvWKK2T2V4LwXGh6A();
		int num;
		if (!B9AXM2KKc7olm2Q9phHN())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (B9AXM2KKc7olm2Q9phHN())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 0:
			case 4:
				if (sender is EzSnippet)
				{
					goto case 1;
				}
				return;
			case 1:
			case 2:
			{
				SnippetRenamedEventHandler snippetRenamedEventHandler = TwymnftWqa;
				if (snippetRenamedEventHandler == null)
				{
					return;
				}
				snippetRenamedEventHandler(this, e);
				num = 5;
				break;
			}
			default:
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSnippet_RemoveAsync_003Ed__119))]
	protected virtual Task Snippet_RemoveAsync(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CSnippet_RemoveAsync_003Ed__119 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 1;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine.sender = sender;
				goto default;
			default:
				fe8uvWKK2T2V4LwXGh6A();
				num = ((!B9AXM2KKc7olm2Q9phHN()) ? 2 : 0);
				break;
			case 5:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				num = 6;
				break;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSnippet_RemoveAsync_003Ed__120))]
	protected virtual Task Snippet_RemoveAsync(object sender)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CSnippet_RemoveAsync_003Ed__120 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 1;
				if (!B9AXM2KKc7olm2Q9phHN())
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				num = 6;
				continue;
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 1:
				stateMachine.sender = sender;
				goto default;
			default:
				fe8uvWKK2T2V4LwXGh6A();
				if (B9AXM2KKc7olm2Q9phHN())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSnippet_CopyAsync_003Ed__121))]
	protected virtual Task Snippet_CopyAsync(object sender, EventArgs args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B9AXM2KKc7olm2Q9phHN();
		int num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 4 : 2);
		_003CSnippet_CopyAsync_003Ed__121 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				goto case 1;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual IEnumerable<CellViewModel> ExposedProperties(EzSnippet snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new List<CellViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RemoveSnippetPropertiesFor(EzSnippet removedSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B9AXM2KKc7olm2Q9phHN();
		int num = ((!fe8uvWKK2T2V4LwXGh6A()) ? 3 : 2);
		IEnumerator<CellViewModel> enumerator = default;
		Dictionary<CvsCellLocation, CellViewModel> dictionary = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				enumerator = GetLinkableProperties().Where([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel p) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.uCy22H5rcWVkZMLuHi4y(p) != null;
				}).GetEnumerator();
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				dictionary = removedSnippet.AllProperties.ToDictionary([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel property) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.W1CfaE5r2ibb07FJhQU8(property);
				});
				goto case 1;
			case 4:
				break;
			}
			break;
		}
		try
		{
			while (enumerator.MoveNext())
			{
				CellViewModel current = enumerator.Current;
				_ = 0;
				int num2 = ((!fe8uvWKK2T2V4LwXGh6A()) ? 3 : 2);
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_00f2;
					case 0:
					case 2:
						if (dictionary.ContainsKey(((CellViewModel)rbTN4IK5SuCeeHDH6nkl(current)).CellLocation))
						{
							goto IL_00f2;
						}
						break;
					case 4:
						break;
					}
					break;
					IL_00f2:
					m3qZU1K5khnqGhcgBqdH(current, null, false);
					num2 = 4;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				qUZpkrK5ZH7uYIlAb6uw(enumerator);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AppViewModel_ActiveStepChanged(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AddingSnippetType = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RuntimeModeService_RuntimeModeChanged(object sender, RuntimeModeChangedEventArgs a)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RuntimeService_SheetExecuted(object sender, CvsCogSessionResult e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static int GetSnippetItemOrder(EzSnippet snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		int? num2 = default;
		while (true)
		{
			int? num3;
			int? num4;
			switch (num)
			{
			case 2:
				num3 = num2;
				goto IL_00b6;
			default:
				num = 5;
				continue;
			case 3:
				if (snippet != null)
				{
					EditIntViewModel order = snippet.Order;
					if (order == null)
					{
						goto case 5;
					}
					num3 = order.Value;
					goto IL_00b6;
				}
				fe8uvWKK2T2V4LwXGh6A();
				if (!B9AXM2KKc7olm2Q9phHN())
				{
					num = 6;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 5:
				num2 = null;
				goto case 0;
			case 0:
			case 4:
				num3 = num2;
				goto IL_00b6;
			case 1:
			case 6:
				num2 = null;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 7:
				break;
				IL_00b6:
				num4 = num3;
				if (!num4.HasValue)
				{
					num = 7;
					continue;
				}
				return num4.GetValueOrDefault();
			}
			break;
		}
		return int.MaxValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSnippetInternal_003Ed__128))]
	protected Task RemoveSnippetInternal(EzSnippet snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (B9AXM2KKc7olm2Q9phHN() ? 5 : 4);
		_003CRemoveSnippetInternal_003Ed__128 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine.snippet = snippet;
				goto case 6;
			default:
				num = 6;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				if (fe8uvWKK2T2V4LwXGh6A())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = KsDlcpK5VtkPImrxaq00();
				goto case 1;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void UpdateOrderValues()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		IEnumerator<EzSnippet> enumerator = default;
		HashSet<string> hashSet = default;
		Dictionary<string, object> dictionary = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 6:
				try
				{
					while (KLCqtpK5POI61VwvBdU2(enumerator))
					{
						string text = (string)D5snBJK58xF4LBFtVHPf(enumerator.Current.Order);
						_ = 1;
						int num3;
						if (!B9AXM2KKc7olm2Q9phHN())
						{
							num3 = 2;
							if (1 == 0)
							{
								goto IL_0047;
							}
						}
						else
						{
							num3 = 4;
							if (false)
							{
								goto IL_0066;
							}
						}
						goto IL_0094;
						IL_0047:
						if (!hashSet.Add(text))
						{
							continue;
						}
						goto IL_0074;
						IL_0074:
						dictionary.Add(text, num2);
						goto IL_0066;
						IL_0066:
						num2++;
						num3 = 5;
						goto IL_0094;
						IL_0094:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								break;
							case 3:
								goto IL_0066;
							case 1:
							case 4:
								goto IL_0074;
							default:
								num3 = 3;
								continue;
							case 5:
								goto IL_00bb;
							}
							break;
						}
						goto IL_0047;
						IL_00bb:;
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				((CvsCogSocketSheet)C1LnyCK5qIqAtnoP0OHZ(InSight.CogSocket)).Run(dictionary);
				num = 7;
				continue;
			case 0:
			case 3:
				enumerator = Snippets.GetEnumerator();
				goto case 4;
			case 1:
				dictionary = new Dictionary<string, object>();
				num = 5;
				continue;
			case 2:
				num2 = 1;
				num = 1;
				continue;
			case 5:
				hashSet = new HashSet<string>();
				break;
			case 7:
				return;
			}
			fe8uvWKK2T2V4LwXGh6A();
			if (B9AXM2KKc7olm2Q9phHN())
			{
				num = 6;
				continue;
			}
			num = 0;
			if (B9AXM2KKc7olm2Q9phHN())
			{
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void GetSnippetSiblingIndices(int index, out int previousIndex, out int nextIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				nextIndex = num2;
				num = 1;
				break;
			case 4:
			case 10:
				if (num2 >= wf2rd9K5EXUIejvCN03D(Snippets))
				{
					num = 13;
					if (B9AXM2KKc7olm2Q9phHN())
					{
					}
				}
				else if (Snippets[num2] == null)
				{
					num2++;
					num = 4;
					if (B9AXM2KKc7olm2Q9phHN())
					{
					}
				}
				else
				{
					num = 2;
				}
				break;
			default:
				while (num2 > -1)
				{
					if (Snippets[num2] == null)
					{
						num2--;
						continue;
					}
					goto IL_0140;
				}
				goto case 5;
			case 5:
			case 9:
				num2 = index + 1;
				num = 10;
				break;
			case 12:
				previousIndex = -1;
				num = 3;
				break;
			case 1:
				return;
			case 8:
				num2 = index - 1;
				num = 11;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				nextIndex = -1;
				num = 8;
				break;
			case 0:
				previousIndex = num2;
				_ = 0;
				num = (fe8uvWKK2T2V4LwXGh6A() ? 9 : 7);
				break;
			case 13:
				return;
				IL_0140:
				num = 0;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void GetDependentCells(List<CvsCellLocation> finalList, List<CvsCellLocation> searchList)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsCellLocation> list = new List<CvsCellLocation>();
		foreach (CvsCellLocation search in searchList)
		{
			CvsCellReferenceInfo cellReferenceInfo = Analyzer.GetCellReferenceInfo(search);
			if (cellReferenceInfo == null)
			{
				continue;
			}
			CvsCellReference[] dependents = cellReferenceInfo.Dependents;
			foreach (CvsCellReference cvsCellReference in dependents)
			{
				if (!finalList.Contains(cvsCellReference.CellLocation))
				{
					finalList.Add(cvsCellReference.CellLocation);
					list.Add(cvsCellReference.CellLocation);
				}
			}
			if (list.Count > 0)
			{
				GetDependentCells(finalList, list);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void UpdateShowInSightDisplay()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ShowInSightDisplay = !IsInSnippetEditMode || CurrentSnippet?.MainViewModel == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nkymy82okm(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MainViewModel = (BaseViewModel)bFWdf4K5pXn29eaSEwVI(CurrentSnippet);
		UpdateShowInSightDisplay();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AppStepViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yXyyIRK5X0JabyOgTRbC();
		n9fmKJh8aA = LogManager.GetLogger<AppStepViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task zwtmxT5tVh(StepBase P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.EnterStep(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task bjcmv2rUtn(StepBase P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.LeaveStep(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PWlaZgKK1qpGSvLo8ZVV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Dispatcher.CurrentDispatcher;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fe8uvWKK2T2V4LwXGh6A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B9AXM2KKc7olm2Q9phHN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kf62UuKKu2aUoWI4Hb4T(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pSA59TKKhVcDyYXmKgdZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QFZx8NKKtsqIpEMaDvRR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyBuilderApplicationViewModel)P_0).ActiveStepChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CosiocKKzZeIYfB82pBL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepViewModel)P_0).RuntimeModeService = (IRuntimeModeService)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ycqwSFK5LlDIyqVMeTB7(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HQj18WK5Kq9ojbgxolbC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyBuilderApplicationViewModel)P_0).ActiveStepChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kx2TcSK55iJUsSfb1p7D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).Runtime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object teg82rK5wKvGbyISl1VJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).RuntimeModeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p6Zcs9K5JHv2tZTcF1Vr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).RuntimeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KaVQ6CK5asErKpvcE86v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSnippet)P_0).UpdateOnEditModeChange();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vqQCadK5e3p5wQ1J4L9d(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSnippet)P_0).OLV5BeveD3((EventHandler)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JGjMLTK5Oy1TEODrwfrj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepViewModel)P_0).OnCurrentSnippetChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IUsyg6K5I7wp5xfv3xgi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepViewModel)P_0).OnAddingSnippetTypeChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NrnnXgK5DZNWiGJESLWB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t2RIMgK5icRSxSUW1GU0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rDuKB6K5nlFcUVXb64eQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder KsDlcpK5VtkPImrxaq00()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cZoH3LK5fmQ12vI4CKNy(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CUBDE9K5duIlL5M5pXSA(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tCEGyJK5lG5CmQY2Xd4v(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iPMxFDK5g7oh50f2WmBM(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YbrjSnK5sa3tAbeaYefP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iiwNliK5v0BoIJjGoWTI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).FindCellByName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UJPV42K5rD3UFY7FP9Nc(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).ods5MyNttS(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KLCqtpK5POI61VwvBdU2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qUZpkrK5ZH7uYIlAb6uw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MngSG9K5BU4HXyuJSMyg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).RuntimeModeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fWEGDHK5bKlQEviv2qj7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsOperatorOfflineAndNotInLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hvgRoIK5GBPe3YMn4mMD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsJobAnalyzer)P_0).Reset();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K5sosTK5onRAdKq0pRBw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepViewModel)P_0).RefreshPotentialDependencies((EzSnippet)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rbTN4IK5SuCeeHDH6nkl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).SourceProperty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void m3qZU1K5khnqGhcgBqdH(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).SuRwaP9gGT((CellViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D5snBJK58xF4LBFtVHPf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C1LnyCK5qIqAtnoP0OHZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wf2rd9K5EXUIejvCN03D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<EzSnippet>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bFWdf4K5pXn29eaSEwVI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).MainViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yXyyIRK5X0JabyOgTRbC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
