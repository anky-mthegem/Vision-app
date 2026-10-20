using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;

[Export(typeof(EzToolType))]
public class MathToolType : EzToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public MathToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private MathTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!vco9fZKW0kG8QPYi7e9k()) ? 5 : 4);
			int num2 = default;
			MathToolType mathToolType = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new MathTool(mathToolType.Inspect, isInitialized: true);
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								vco9fZKW0kG8QPYi7e9k();
								num3 = (xEFc2iKWFjR2w6KZKj57() ? 4 : 8);
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto IL_00f8;
							case 5:
								_003C_003Eu__1 = default;
								goto case 4;
							case 4:
							case 7:
								num2 = (_003C_003E1__state = -1);
								goto IL_00f8;
							case 0:
								return;
							case 1:
								awaiter = JEXdxrKWY3vuZJwXuZUw(Wb7OvXKWMSJaUxtKZGTM(_003Ctool_003E5__2, cells, cellRange));
								num3 = 6;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 10:
								{
									result = _003Ctool_003E5__2;
									break;
								}
								IL_00f8:
								awaiter.GetResult();
								num3 = 10;
								continue;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					mathToolType = _003C_003E4__this;
					goto case 2;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					_003Ctool_003E5__2 = null;
					num = 6;
					break;
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 7:
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
		internal static object Wb7OvXKWMSJaUxtKZGTM(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter JEXdxrKWY3vuZJwXuZUw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vco9fZKW0kG8QPYi7e9k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xEFc2iKWFjR2w6KZKj57()
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
	private struct _003COnBeginAddInternal_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			MathToolType mathToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 5:
					mathToolType = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!iT4lIbKWUwMhEuRXkcuO())
					{
						num = 4;
						break;
					}
					num = 5;
					if (!lArJqYKWHB7iDsM2CAAb())
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = FF4jntKWmmpoPCXvvRwc(x3FDUuKWxW9h9DCp4cIU(mathToolType.AcceptAddCommand));
							num3 = 0;
							if (lArJqYKWHB7iDsM2CAAb())
							{
								goto IL_008e;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (false)
							{
								goto IL_0151;
							}
						}
						goto IL_0102;
						IL_0102:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (lArJqYKWHB7iDsM2CAAb())
								{
								}
								continue;
							case 3:
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 5:
								return;
							case 4:
							case 6:
								goto IL_0151;
							case 7:
								_003C_003Eu__1 = default;
								goto IL_0151;
							case 9:
								awaiter.GetResult();
								goto end_IL_0067;
							}
							break;
						}
						goto IL_008e;
						IL_0151:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_0102;
						IL_008e:
						_003C_003Eu__1 = awaiter;
						iT4lIbKWUwMhEuRXkcuO();
						num3 = (lArJqYKWHB7iDsM2CAAb() ? 4 : 8);
						goto IL_0102;
						end_IL_0067:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
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
		internal static object x3FDUuKWxW9h9DCp4cIU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter FF4jntKWmmpoPCXvvRwc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iT4lIbKWUwMhEuRXkcuO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lArJqYKWHB7iDsM2CAAb()
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
	private struct _003CAddTool_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public MathToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private MathTool _003CnewTool_003E5__5;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			MathToolType mathToolType = default;
			EzTool result = default;
			TaskAwaiter awaiter = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<object> awaiter4 = default;
			TaskAwaiter<CvsCellRange> awaiter3 = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			CvsCellRange result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					mathToolType = _003C_003E4__this;
					goto case 2;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (!kyiB6WKWN8sPleUGaOoQ())
					{
						break;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					kyiB6WKWN8sPleUGaOoQ();
					if (!O6YDqOKWQ7tiWpS4QWy0())
					{
						num = 6;
						if (true)
						{
							break;
						}
						goto case 5;
					}
					num = 0;
					break;
				case 3:
					_003Csheet_003E5__2 = null;
					num = 5;
					break;
				case 2:
				case 6:
					try
					{
						int num3;
						if ((uint)num2 > 3u)
						{
							if (num2 == 4)
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0530;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)wESkQ4KW1VQ1vjUAplg1(((CvsInSight)XJbUExKWcLwxmx2vH0mX(JOn426KW2Qtv6tNjaa0Z(mathToolType))).CogSocket);
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
							{
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(mathToolType._pasteObject, (InspectStepViewModel)JOn426KW2Qtv6tNjaa0Z(mathToolType), out var _);
								num4 = 7;
								goto IL_0342;
							}
							case 1:
								awaiter4 = _003C_003Eu__2;
								num4 = 28;
								goto IL_0342;
							case 0:
								awaiter3 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num4 = 8;
								goto IL_0342;
							case 2:
								awaiter2 = _003C_003Eu__3;
								num4 = 11;
								if (O6YDqOKWQ7tiWpS4QWy0())
								{
									goto IL_0342;
								}
								goto IL_0418;
							case 3:
								{
									awaiter = _003C_003Eu__4;
									num4 = 1;
									goto IL_0342;
								}
								IL_0342:
								while (true)
								{
									CvsCellCollection result3;
									switch (num4)
									{
									case 21:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 15;
										continue;
									case 22:
										_003CpasteRange_003E5__3 = result2;
										num4 = 26;
										continue;
									case 26:
										awaiter4 = _003Csheet_003E5__2.PutCellExpressionAsync(mathToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, mathToolType.ERXgYMgnf0), mathToolType.InputImageLinks[i6M6ixKWuEGu5jy6AnLK(mathToolType)].Expression).GetAwaiter();
										if (!awaiter4.IsCompleted)
										{
											num4 = 18;
											continue;
										}
										goto case 19;
									case 1:
										_003C_003Eu__4 = default;
										num4 = 9;
										if (O6YDqOKWQ7tiWpS4QWy0())
										{
											continue;
										}
										goto case 28;
									case 28:
										_003C_003Eu__2 = default;
										num4 = 29;
										continue;
									case 11:
										_003C_003Eu__3 = default;
										num4 = 6;
										if (true)
										{
											continue;
										}
										goto case 0;
									case 0:
										awaiter.GetResult();
										num4 = 30;
										continue;
									case 24:
										awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										num4 = 14;
										continue;
									case 6:
										num2 = (_003C_003E1__state = -1);
										goto IL_01eb;
									case 10:
									case 16:
										break;
									case 7:
										awaiter3 = mathToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num4 = 13;
											continue;
										}
										goto case 5;
									case 4:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 17;
										continue;
									case 8:
										goto IL_0290;
									case 25:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 2;
										continue;
									case 3:
										_003C_003Eu__3 = awaiter2;
										num4 = 21;
										if (!kyiB6WKWN8sPleUGaOoQ())
										{
											continue;
										}
										goto case 9;
									case 9:
										num2 = (_003C_003E1__state = -1);
										num4 = 0;
										continue;
									case 5:
									case 27:
										result2 = awaiter3.GetResult();
										num4 = 22;
										continue;
									case 2:
										return;
									case 19:
										awaiter4.GetResult();
										goto case 24;
									default:
										num4 = 24;
										continue;
									case 13:
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter3;
										num4 = 25;
										continue;
									case 29:
										num2 = (_003C_003E1__state = -1);
										num4 = 19;
										continue;
									case 15:
										return;
									case 20:
										goto end_IL_0342;
									case 23:
										_003C_003Eu__4 = awaiter;
										num4 = 4;
										continue;
									case 14:
										if (awaiter2.IsCompleted)
										{
											goto IL_01eb;
										}
										num2 = (_003C_003E1__state = 2);
										num4 = 3;
										if (0 == 0)
										{
											continue;
										}
										goto case 18;
									case 18:
										num2 = (_003C_003E1__state = 1);
										num4 = 20;
										continue;
									case 12:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 3);
											num4 = 23;
											continue;
										}
										goto case 0;
									case 17:
										return;
									case 30:
										{
											result = _003CnewTool_003E5__5;
											goto end_IL_00b6;
										}
										IL_01eb:
										result3 = awaiter2.GetResult();
										_003CnewTool_003E5__5 = new MathTool((InspectStepViewModel)JOn426KW2Qtv6tNjaa0Z(mathToolType), isInitialized: false);
										awaiter = MQJgXWKWtZljuagJ97Yv(UjYWSfKWhTYmdZn50F6h(_003CnewTool_003E5__5, result3, _003CpasteRange_003E5__3));
										num4 = 12;
										if (0 == 0)
										{
											continue;
										}
										break;
									}
									goto end_IL_00b7;
									IL_0290:
									num2 = (_003C_003E1__state = -1);
									_ = 1;
									num4 = (kyiB6WKWN8sPleUGaOoQ() ? 16 : 27);
									continue;
									end_IL_0342:
									break;
								}
								goto IL_0418;
								IL_0418:
								_003C_003Eu__2 = awaiter4;
								break;
								end_IL_00b7:
								break;
							}
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
							end_IL_00b6:;
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_04c9;
						}
						goto end_IL_007f;
						IL_04c9:
						if (num3 == 1)
						{
							awaiter = MQJgXWKWtZljuagJ97Yv(mathToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0530;
						}
						goto IL_0559;
						IL_0530:
						awaiter.GetResult();
						ycBWt0KWzDKQ86SiGDAo(ExceptionDispatchInfo.Capture((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0559;
						IL_0559:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_007f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					break;
				case 7:
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
		internal static object JOn426KW2Qtv6tNjaa0Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XJbUExKWcLwxmx2vH0mX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wESkQ4KW1VQ1vjUAplg1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int i6M6ixKWuEGu5jy6AnLK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UjYWSfKWhTYmdZn50F6h(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MQJgXWKWtZljuagJ97Yv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ycBWt0KWzDKQ86SiGDAo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O6YDqOKWQ7tiWpS4QWy0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kyiB6WKWN8sPleUGaOoQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__24 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public MathToolType _003C_003E4__this;

		private int _003CcurrentVersion_003E5__2;

		private int _003ClatestVersion_003E5__3;

		ISnippetUpdate IEnumerator<ISnippetUpdate>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CGetUpdates_003Ed__24(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (zAeWuhKTKJx8wFrP6o8x() ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					base._002Ector();
					num = 5;
					if (jMnyLaKTLHWpYe7PP4ZW())
					{
						continue;
					}
					goto case 5;
				case 5:
					this._003C_003E1__state = _003C_003E1__state;
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 4:
					QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
					goto case 1;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
				num = 6;
				if (zAeWuhKTKJx8wFrP6o8x())
				{
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			CvsCellLocation offset = default;
			MathToolType mathToolType = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 2;
					if (jMnyLaKTLHWpYe7PP4ZW())
					{
						continue;
					}
					goto case 7;
				case 7:
					_003C_003E2__current = new EditArgumentUpdate(offset, mathToolType.k20gnfewlV, 0, null);
					num = 15;
					continue;
				case 2:
					mathToolType = _003C_003E4__this;
					num = 5;
					continue;
				case 12:
					_003C_003E1__state = 3;
					num = 10;
					continue;
				case 11:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						_003C_003E2__current = new ToolDisabledJobPassUpdate();
						num = 13;
						if (true)
						{
							continue;
						}
						goto case 15;
					}
					goto case 9;
				case 15:
					_003C_003E1__state = 2;
					return true;
				case 13:
					_003C_003E1__state = 1;
					num = 14;
					continue;
				case 5:
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_00eb;
					case 0:
						goto IL_0107;
					case 1:
						goto IL_0155;
					case 3:
						goto IL_021a;
					}
					_003C_003E1__state = -1;
					goto IL_00a9;
				case 3:
				case 16:
					return false;
				case 1:
					offset = new CvsCellLocation(10, 7);
					num = 7;
					if (zAeWuhKTKJx8wFrP6o8x())
					{
					}
					continue;
				case 14:
					return true;
				default:
					num = 9;
					continue;
				case 6:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, mathToolType.Localizer);
					num = 12;
					continue;
				case 9:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						num = 1;
						continue;
					}
					goto IL_00a9;
				case 4:
				case 8:
					_003ClatestVersion_003E5__3 = crUSdQKTwQJC6swW6cjs(mathToolType._pasteObject);
					num = 11;
					continue;
				case 10:
					return true;
				case 17:
					break;
					IL_021a:
					_003C_003E1__state = -1;
					num = 17;
					continue;
					IL_0155:
					_003C_003E1__state = -1;
					goto case 9;
					IL_0107:
					_003C_003E1__state = -1;
					_003CcurrentVersion_003E5__2 = JHAmhCKT5XjaR1UUcUrx(cells, range);
					goto case 4;
					IL_00eb:
					jMnyLaKTLHWpYe7PP4ZW();
					num = (zAeWuhKTKJx8wFrP6o8x() ? 8 : 16);
					continue;
					IL_00a9:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 6;
						continue;
					}
					break;
				}
				break;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotSupportedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<ISnippetUpdate> IEnumerable<ISnippetUpdate>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CGetUpdates_003Ed__24 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__24(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			obj.cells = _003C_003E3__cells;
			obj.range = _003C_003E3__range;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<ISnippetUpdate>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jMnyLaKTLHWpYe7PP4ZW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zAeWuhKTKJx8wFrP6o8x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int JHAmhCKT5XjaR1UUcUrx(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int crUSdQKTwQJC6swW6cjs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private static readonly Guid[] tVqgtVySZo;

	private readonly CvsCellLocation ERXgYMgnf0;

	private int eI6g0Px9Xa;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tVqgtVySZo;
		}
	}

	public override string ToolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)C8GQYPXTqQ9GkuJyshY();
		}
	}

	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)rMo3OUXywvnHoLe2ClQ();
		}
	}

	public override bool IsReleased
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	public override string Source
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_SheetIcon;
		}
	}

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_SheetIcon;
		}
	}

	public override string[] Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new string[2]
			{
				Resources.Inspect,
				(string)TV3McSX0DSHemGX2YYu()
			};
		}
	}

	public override int Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eI6g0Px9Xa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref eI6g0Px9Xa, value, (string)ObtjWYXWrhoA9dsJO28(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MathToolType()
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
				base._002Ector();
				num = 6;
				continue;
			case 1:
			case 7:
				eI6g0Px9Xa = 600;
				num = 2;
				continue;
			default:
				ERXgYMgnf0 = _pasteObject.GetCellOffset((string)ObtjWYXWrhoA9dsJO28(4928));
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				LLQDkHXC2cFLiIqrY9g();
				hxsrMyX6MUWiO3nCvPP();
				if (zAdWg0Xj03bjoMkGOAX())
				{
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				num = 3;
				if (zAdWg0Xj03bjoMkGOAX())
				{
					continue;
				}
				break;
			case 6:
				_pasteObject = (PasteBuffer)VgKgyYXRmhp5DnFymNS(LCbhudXAmQT8nRpRUmm());
				goto default;
			case 5:
				break;
			case 8:
				return;
			}
			AddSnippet(_pasteObject);
			num = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__21))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__22))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (hxsrMyX6MUWiO3nCvPP() ? 3 : 4);
		_003COnBeginAddInternal_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (zAdWg0Xj03bjoMkGOAX())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!hxsrMyX6MUWiO3nCvPP())
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = xMD0KFXFpOvdIdLBfxw();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__23))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__24))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__24(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string k20gnfewlV(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Yg7CLVXYnOUdO40T637(t8meJNXMrClHP7UOAKv(SnippetPasteBuffer.GetCellInTool(P_0, (string)ObtjWYXWrhoA9dsJO28(4928)))).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MathToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		tVqgtVySZo = new Guid[1]
		{
			new Guid((string)ObtjWYXWrhoA9dsJO28(24040))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LLQDkHXC2cFLiIqrY9g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LCbhudXAmQT8nRpRUmm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.MathLogic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VgKgyYXRmhp5DnFymNS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ObtjWYXWrhoA9dsJO28(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zAdWg0Xj03bjoMkGOAX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hxsrMyX6MUWiO3nCvPP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C8GQYPXTqQ9GkuJyshY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.sT50jMreoj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rMo3OUXywvnHoLe2ClQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.XLnVd4okvr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TV3McSX0DSHemGX2YYu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OKi0OpLUby();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder xMD0KFXFpOvdIdLBfxw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t8meJNXMrClHP7UOAKv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Yg7CLVXYnOUdO40T637(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)P_0);
	}
}
