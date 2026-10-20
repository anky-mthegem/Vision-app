using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Internal;
using Cognex.Utilities.Sdk.InSightController;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class AddProtocolUndoAction : AddSnippetUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__3 : IAsyncStateMachine
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
			int num = 0;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = JLOV0s5ObgBMNGKONdFe(jWvSwO5OB2HDUURQoEmx());
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							IL_00da:
							switch (num3)
							{
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (phAvLh5OPFywOkLmQ83Y())
								{
									continue;
								}
								goto case 4;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (phAvLh5OPFywOkLmQ83Y())
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = default;
								goto case 4;
							case 7:
								while (!awaiter.IsCompleted)
								{
									_ = 0;
									if (!phAvLh5OPFywOkLmQ83Y())
									{
										num3 = 4;
										if (IFPsGG5OZfR7Exx6XbNc())
										{
											continue;
										}
									}
									else
									{
										num3 = 2;
									}
									goto IL_00da;
								}
								break;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								if (true)
								{
									continue;
								}
								return;
							case 5:
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
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!IFPsGG5OZfR7Exx6XbNc()) ? 3 : 4);
					continue;
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
		internal static object jWvSwO5OB2HDUURQoEmx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter JLOV0s5ObgBMNGKONdFe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool phAvLh5OPFywOkLmQ83Y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IFPsGG5OZfR7Exx6XbNc()
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

		public AddProtocolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<byte[]> _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			AddProtocolUndoAction addProtocolUndoAction = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<byte[]> awaiter4 = default;
			byte[] result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					j3ntho5OoxKw94NxT5lu();
					if (MWp6GL5OG6qTYLxed6VM())
					{
						num = 0;
						if (MWp6GL5OG6qTYLxed6VM())
						{
							break;
						}
						goto case 4;
					}
					num = 3;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = ((EasyBuilderApplicationViewModel)qHXAa45OSRw87Pkt8Aro(addProtocolUndoAction.CommStep)).PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00cb;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00cb;
						case 1:
						case 2:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 17;
									if (1 == 0)
									{
										goto IL_00fc;
									}
								}
								else
								{
									awaiter3 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num3 = 12;
								}
								goto IL_0161;
								IL_0161:
								while (true)
								{
									switch (num3)
									{
									case 6:
										return;
									case 0:
										awaiter4 = ((CvsInSight)tTPO0u5OppUeHGC3H3C5(addProtocolUndoAction.CommStep)).UndoHandler.SendCopyAsync(addProtocolUndoAction.Range).GetAwaiter();
										break;
									case 7:
										_003C_003Eu__3 = default;
										num3 = 3;
										continue;
									case 12:
										num2 = (_003C_003E1__state = -1);
										num3 = 1;
										if (true)
										{
											continue;
										}
										goto case 13;
									case 13:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num3 = 6;
										continue;
									case 17:
										if (num2 == 2)
										{
											awaiter4 = _003C_003Eu__3;
											num3 = 7;
											if (0 == 0)
											{
												continue;
											}
											goto case 0;
										}
										num3 = 11;
										continue;
									case 1:
										awaiter3.GetResult();
										addProtocolUndoAction.Range = tJC2a35OEeY3wCo04933(gpDIp85OqdhH9oUV1nmn(addProtocolUndoAction.CommStep));
										num3 = 0;
										if (MWp6GL5OG6qTYLxed6VM())
										{
											continue;
										}
										goto case 14;
									case 14:
										num2 = (_003C_003E1__state = 2);
										num3 = 4;
										if (true)
										{
											continue;
										}
										goto case 5;
									case 5:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										goto case 4;
									case 4:
										_003C_003Eu__3 = awaiter4;
										num3 = 13;
										continue;
									case 15:
										goto IL_0284;
									case 10:
										return;
									case 2:
									case 16:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter3;
										num3 = 5;
										if (true)
										{
											continue;
										}
										goto case 3;
									case 3:
										num2 = (_003C_003E1__state = -1);
										num3 = 15;
										continue;
									case 11:
										awaiter3 = r5F58X5O87UCOJsAh1BX(SMux235OkgTZEbbn2wbb(addProtocolUndoAction.CommStep));
										if (awaiter3.IsCompleted)
										{
											goto case 1;
										}
										goto IL_0308;
									case 18:
										addProtocolUndoAction.gki2eTW4UX = result2;
										goto end_IL_00e9;
									}
									break;
									IL_0308:
									j3ntho5OoxKw94NxT5lu();
									num3 = (MWp6GL5OG6qTYLxed6VM() ? 16 : 9);
								}
								goto IL_00fc;
								IL_0284:
								result2 = awaiter4.GetResult();
								num3 = 18;
								goto IL_0161;
								IL_00fc:
								if (!awaiter4.IsCompleted)
								{
									num3 = 14;
									if (1 == 0)
									{
										return;
									}
									goto IL_0161;
								}
								goto IL_0284;
								end_IL_00e9:;
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003C_003E7__wrap1 == null)
							{
								break;
							}
							awaiter = WXilkf5OXWU5rlejW7X8(_003C_003E7__wrap1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_03ac;
						case 3:
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03ac;
							}
							IL_03ac:
							awaiter.GetResult();
							break;
							IL_00cb:
							result = awaiter2.GetResult();
							_003C_003E7__wrap1 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							MbCjST5O9EZSs01ud2XK(ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
						_003C_003E7__wrap1 = null;
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
				case 1:
					addProtocolUndoAction = _003C_003E4__this;
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
		internal static object qHXAa45OSRw87Pkt8Aro(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SMux235OkgTZEbbn2wbb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CommStepViewModel)P_0).kBOeL4AFAY();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter r5F58X5O87UCOJsAh1BX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gpDIp85OqdhH9oUV1nmn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CommStepViewModel)P_0).FactoryProtocol;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange tJC2a35OEeY3wCo04933(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tTPO0u5OppUeHGC3H3C5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask WXilkf5OXWU5rlejW7X8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MbCjST5O9EZSs01ud2XK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MWp6GL5OG6qTYLxed6VM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j3ntho5OoxKw94NxT5lu()
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

		public AddProtocolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private CvsCellCollection _003Ccells_003E5__5;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__3;

		private TaskAwaiter<string> _003C_003Eu__4;

		private ValueTaskAwaiter _003C_003Eu__5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g13P6r5O7Ml4Bc9cjU9v();
			int num;
			if (E1Fbj05O4DpDeEvyRUcV())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0609;
				}
			}
			goto IL_05c5;
			IL_05c5:
			AddProtocolUndoAction addProtocolUndoAction = default;
			TaskAwaiter awaiter4 = default;
			TaskAwaiter<CvsCellCollection> awaiter5 = default;
			TaskAwaiter<string> awaiter3 = default;
			string result2 = default;
			CvsCellCollection result3 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = ((EasyBuilderApplicationViewModel)C3oPtg5O3TES3pkTalC0(addProtocolUndoAction.CommStep)).PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00a7;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00a7;
						case 1:
						case 2:
						case 3:
						case 4:
							try
							{
								int num3;
								switch (num2)
								{
								default:
									num3 = 27;
									if (!E1Fbj05O4DpDeEvyRUcV())
									{
										goto IL_00ed;
									}
									goto IL_0150;
								case 4:
									awaiter4 = _003C_003Eu__2;
									num3 = 8;
									goto IL_0150;
								case 2:
									awaiter5 = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num3 = 12;
									goto IL_0150;
								case 1:
									awaiter4 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num3 = 20;
									if (E1Fbj05O4DpDeEvyRUcV())
									{
										goto IL_0150;
									}
									goto IL_0432;
								case 3:
									{
										awaiter3 = _003C_003Eu__4;
										_003C_003Eu__4 = default;
										num3 = 5;
										if (E1Fbj05O4DpDeEvyRUcV())
										{
											goto IL_0150;
										}
										goto IL_0479;
									}
									IL_0150:
									while (true)
									{
										IL_0150_2:
										switch (num3)
										{
										case 24:
											break;
										case 18:
											awaiter5 = ((CvsCogSocketSheet)zNhEYm5OAhaxlHflLEfw(FTTftH5OCp1Z5UEXYx8h(FpK4wy5OjbQiggMpRyKe(addProtocolUndoAction.CommStep)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
											num3 = 9;
											continue;
										case 23:
											num2 = (_003C_003E1__state = 3);
											goto case 19;
										default:
											num3 = 19;
											continue;
										case 9:
											goto IL_01d7;
										case 8:
											_003C_003Eu__2 = default;
											num3 = 1;
											if (!g13P6r5O7Ml4Bc9cjU9v())
											{
												continue;
											}
											goto case 3;
										case 3:
										case 4:
											_003C_003Eu__2 = awaiter4;
											num3 = 25;
											continue;
										case 21:
											awaiter4 = kc4ycS5ORZtb8oJSMjTm(((ISnippetOwner)addProtocolUndoAction.CommStep).AddSnippet(new Guid(result2), _003Ccells_003E5__5, addProtocolUndoAction.Range, SnippetAddedEventType.Created));
											num3 = 17;
											if (0 == 0)
											{
												continue;
											}
											goto case 20;
										case 20:
											num2 = (_003C_003E1__state = -1);
											num3 = 14;
											continue;
										case 19:
											_003C_003Eu__4 = awaiter3;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num3 = 13;
											continue;
										case 28:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											num3 = 10;
											continue;
										case 6:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
											num3 = 15;
											if (true)
											{
												continue;
											}
											return;
										case 10:
											return;
										case 26:
											awaiter4.GetResult();
											num3 = 29;
											if (g13P6r5O7Ml4Bc9cjU9v())
											{
											}
											continue;
										case 1:
											num2 = (_003C_003E1__state = -1);
											num3 = 26;
											continue;
										case 5:
											num2 = (_003C_003E1__state = -1);
											num3 = 22;
											continue;
										case 15:
											return;
										case 22:
											goto IL_033e;
										case 17:
											if (!awaiter4.IsCompleted)
											{
												num3 = 16;
												continue;
											}
											goto case 26;
										case 14:
											awaiter4.GetResult();
											num3 = 18;
											continue;
										case 2:
										case 11:
											num2 = (_003C_003E1__state = 1);
											goto case 3;
										case 0:
											while (!awaiter4.IsCompleted)
											{
												g13P6r5O7Ml4Bc9cjU9v();
												if (!E1Fbj05O4DpDeEvyRUcV())
												{
													num3 = 4;
													if (false)
													{
														continue;
													}
												}
												else
												{
													num3 = 11;
												}
												goto IL_0150_2;
											}
											goto case 14;
										case 16:
											num2 = (_003C_003E1__state = 4);
											num3 = 24;
											continue;
										case 27:
											awaiter4 = ((Task)lNd2cN5O6EscI0sCEFNy(FpK4wy5OjbQiggMpRyKe(addProtocolUndoAction.CommStep), addProtocolUndoAction.Range, addProtocolUndoAction.gki2eTW4UX, false, true)).GetAwaiter();
											num3 = 0;
											continue;
										case 25:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											return;
										case 12:
											goto IL_0432;
										case 13:
											return;
										case 7:
											goto IL_0479;
										case 29:
											_003Ccells_003E5__5 = null;
											goto end_IL_00c8;
										}
										break;
										IL_01d7:
										if (!awaiter5.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											_003C_003Eu__3 = awaiter5;
											num3 = 6;
											continue;
										}
										goto IL_043b;
									}
									goto IL_00ed;
									IL_0479:
									_003Ccells_003E5__5 = result3;
									awaiter3 = ((CvsCogSocketSheet)zNhEYm5OAhaxlHflLEfw(FTTftH5OCp1Z5UEXYx8h(FpK4wy5OjbQiggMpRyKe(addProtocolUndoAction.CommStep)))).GetCellCommentAsync(addProtocolUndoAction.Range.Location).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num3 = 23;
										goto IL_0150;
									}
									goto IL_033e;
									IL_00ed:
									_003C_003Eu__2 = awaiter4;
									num3 = 28;
									if (g13P6r5O7Ml4Bc9cjU9v())
									{
									}
									goto IL_0150;
									IL_0432:
									num2 = (_003C_003E1__state = -1);
									goto IL_043b;
									IL_033e:
									result2 = awaiter3.GetResult();
									num3 = 21;
									goto IL_0150;
									IL_043b:
									result3 = awaiter5.GetResult();
									num3 = 7;
									if (1 == 0)
									{
										return;
									}
									goto IL_0150;
									end_IL_00c8:
									break;
								}
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003C_003E7__wrap1 == null)
							{
								break;
							}
							awaiter = zI6ISy5OW5wVWJsnHgdX(_003C_003E7__wrap1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 5);
								_003C_003Eu__5 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_054c;
						case 5:
							{
								awaiter = _003C_003Eu__5;
								_003C_003Eu__5 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_054c;
							}
							IL_054c:
							awaiter.GetResult();
							break;
							IL_00a7:
							result = awaiter2.GetResult();
							_003C_003E7__wrap1 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							cZ15m55OyupWY33td1rQ(tEVHMl5OTMXfGsVMyXC8((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
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
				default:
					num = 2;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				case 1:
				case 3:
					addProtocolUndoAction = _003C_003E4__this;
					num = 4;
					if (!g13P6r5O7Ml4Bc9cjU9v())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0609;
			IL_0609:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_05c5;
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
		internal static object C3oPtg5O3TES3pkTalC0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FpK4wy5OjbQiggMpRyKe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lNd2cN5O6EscI0sCEFNy(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FTTftH5OCp1Z5UEXYx8h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zNhEYm5OAhaxlHflLEfw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kc4ycS5ORZtb8oJSMjTm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask zI6ISy5OW5wVWJsnHgdX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tEVHMl5OTMXfGsVMyXC8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cZ15m55OyupWY33td1rQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E1Fbj05O4DpDeEvyRUcV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g13P6r5O7Ml4Bc9cjU9v()
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

		public AddProtocolUndoAction _003C_003E4__this;

		private RemoveProtocolUndoAction _003Cremove_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_027e;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 7;
			goto IL_027e;
			IL_027e:
			int num2 = default;
			TaskAwaiter awaiter = default;
			AddProtocolUndoAction addProtocolUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				default:
					_003Cremove_003E5__2 = null;
					num = 6;
					continue;
				case 2:
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_ = 0;
							num3 = ((!nvHv1H5O0ZJBRLZMvuCZ()) ? 2 : 10);
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 11;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 16;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 10:
								_003Cremove_003E5__2 = new RemoveProtocolUndoAction(addProtocolUndoAction.CommStep, addProtocolUndoAction.SnippetName);
								awaiter = XKnOoG5OYRAhAos1YN2X(riIKq15OMF8REy2ubLDV(_003Cremove_003E5__2));
								goto case 1;
							case 15:
								_003C_003Eu__1 = awaiter;
								num3 = 14;
								continue;
							case 6:
								return;
							case 9:
								num2 = (_003C_003E1__state = 1);
								num3 = 7;
								continue;
							case 5:
								awaiter = XKnOoG5OYRAhAos1YN2X(c3Aw1R5OUhrHSNpmCPtI(_003Cremove_003E5__2));
								num3 = 3;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								break;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 13;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto IL_0131;
							case 1:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								goto IL_0131;
							case 4:
								return;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 12:
								num2 = (_003C_003E1__state = 0);
								num3 = 15;
								continue;
							case 11:
								_003C_003Eu__1 = default;
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 16:
								break;
								IL_0131:
								awaiter.GetResult();
								num3 = 5;
								continue;
							}
							break;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cremove_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
					do
					{
						addProtocolUndoAction = _003C_003E4__this;
						j5VQJm5OFPacrRJuD8Tm();
						if (!nvHv1H5O0ZJBRLZMvuCZ())
						{
							num = 5;
							continue;
						}
						num = 4;
						break;
					}
					while (j5VQJm5OFPacrRJuD8Tm());
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static object riIKq15OMF8REy2ubLDV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseSnippetAddRemoveAction)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XKnOoG5OYRAhAos1YN2X(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object c3Aw1R5OUhrHSNpmCPtI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseSnippetAddRemoveAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nvHv1H5O0ZJBRLZMvuCZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j5VQJm5OFPacrRJuD8Tm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly FfpType yN92vvINHq;

	private byte[] gki2eTW4UX;

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format(Resources.znyhSQ8CwN(), qAYhjqNbWAaNnFD4ITo(CommStepViewModel.FfpTypeStringConverter, FfpType.None), qAYhjqNbWAaNnFD4ITo(CommStepViewModel.FfpTypeStringConverter, yN92vvINHq));
		}
	}

	protected CommStepViewModel CommStep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CommStepViewModel)AppStepVm;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddProtocolUndoAction(CommStepViewModel commStep, CvsCellRange cellRange, string protocolName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!TghwnQNZbXymuZfsEQY())
		{
			num = 1;
		}
		else
		{
			num = 3;
			if (TghwnQNZbXymuZfsEQY())
			{
				goto IL_0081;
			}
		}
		goto IL_004e;
		IL_004e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				goto IL_0024;
			case 4:
				base._002Ector(commStep, cellRange, protocolName);
				break;
			case 5:
				return;
			}
			break;
			IL_0024:
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			num = 4;
		}
		goto IL_0081;
		IL_0081:
		yN92vvINHq = commStep.Protocol;
		num = 5;
		goto IL_004e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__3))]
	public override Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!rR90DhNPPWgUUcKoVMe()) ? 3 : 4);
		_003CSaveState_003Ed__3 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = R4EyXvNBCs4D9XeRLod();
				goto case 1;
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
		int num = 5;
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				do
				{
					stateMachine._003C_003E4__this = this;
					rR90DhNPPWgUUcKoVMe();
					if (TghwnQNZbXymuZfsEQY())
					{
						num = 4;
						continue;
					}
					num = 1;
					break;
				}
				while (!rR90DhNPPWgUUcKoVMe());
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (TghwnQNZbXymuZfsEQY())
				{
				}
				continue;
			case 5:
				stateMachine._003C_003Et__builder = R4EyXvNBCs4D9XeRLod();
				num = 0;
				if (!TghwnQNZbXymuZfsEQY())
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TghwnQNZbXymuZfsEQY();
		int num = (rR90DhNPPWgUUcKoVMe() ? 1 : 2);
		_003CRedo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (!TghwnQNZbXymuZfsEQY())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = R4EyXvNBCs4D9XeRLod();
				num = 5;
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
		int num = 0;
		_003CUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = R4EyXvNBCs4D9XeRLod();
				_ = 0;
				if (rR90DhNPPWgUUcKoVMe())
				{
					num = 5;
					continue;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rR90DhNPPWgUUcKoVMe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TghwnQNZbXymuZfsEQY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder R4EyXvNBCs4D9XeRLod()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qAYhjqNbWAaNnFD4ITo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TypeConverter)P_0).ConvertToString(P_1);
	}
}
