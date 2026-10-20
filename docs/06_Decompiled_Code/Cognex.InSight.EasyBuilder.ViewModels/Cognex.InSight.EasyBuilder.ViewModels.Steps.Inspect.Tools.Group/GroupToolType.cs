using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;

[Export(typeof(EzToolType))]
public class GroupToolType : EzToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnBeginAddInternal_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GroupToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0190;
			IL_01c3:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0190;
			IL_0190:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 2:
				case 4:
					goto IL_0041;
				default:
					goto IL_01c3;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0041:
			GroupToolType groupToolType = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = qHGHViKMFfOaLf0Kum8c(mdUjTWKM051aRVep77vL(groupToolType.AcceptAddCommand));
					num3 = 7;
					if (!kHybrcKMTmmTNrl3Ram2())
					{
						goto IL_0068;
					}
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
					case 3:
					case 6:
						break;
					default:
						return;
					case 8:
						return;
					case 7:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							if (0 == 0)
							{
								continue;
							}
							goto case 5;
						}
						goto case 9;
					case 5:
						_003C_003Eu__1 = awaiter;
						kHybrcKMTmmTNrl3Ram2();
						num3 = ((!PiaHtNKMyUQbAsatpkMZ()) ? 6 : 8);
						continue;
					case 1:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 0:
						_003C_003Eu__1 = default;
						num3 = 1;
						continue;
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 5;
						continue;
					case 9:
						awaiter.GetResult();
						goto end_IL_0088;
					}
					goto IL_0068;
					continue;
					end_IL_0088:
					break;
				}
				goto end_IL_0041;
				IL_0068:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				end_IL_0041:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01c3;
			IL_001a:
			groupToolType = _003C_003E4__this;
			kHybrcKMTmmTNrl3Ram2();
			if (!PiaHtNKMyUQbAsatpkMZ())
			{
				num = 4;
				if (!kHybrcKMTmmTNrl3Ram2())
				{
					goto IL_0041;
				}
			}
			else
			{
				num = 1;
				if (false)
				{
					goto IL_01c3;
				}
			}
			goto IL_0190;
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
		internal static object mdUjTWKM051aRVep77vL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter qHGHViKMFfOaLf0Kum8c(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kHybrcKMTmmTNrl3Ram2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PiaHtNKMyUQbAsatpkMZ()
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
	private struct _003CCreateTool_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public GroupToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private GroupTool _003Ctool_003E5__2;

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
			goto IL_0206;
			IL_001a:
			GroupToolType groupToolType = _003C_003E4__this;
			SwFgEmKMM2O6ERWL1rD3();
			num = ((!PEcdaWKMYoAYi9hgFWyh()) ? 5 : 0);
			goto IL_0206;
			IL_0206:
			int num2 = default;
			EzTool result = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 6;
					continue;
				case 0:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 3:
					_003Ctool_003E5__2 = null;
					goto case 0;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new GroupTool((InspectStepViewModel)Xr5REcKMUo1RPgCtkWd8(groupToolType), isInitialized: true);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (false)
							{
								goto IL_013e;
							}
						}
						goto IL_017c;
						IL_00b1:
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						goto IL_017c;
						IL_00cb:
						awaiter.GetResult();
						num3 = 10;
						goto IL_017c;
						IL_017c:
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 2:
							case 3:
								break;
							case 4:
								goto IL_00cb;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								continue;
							case 7:
								awaiter = v0QFJBKMxunUCH3RZ4Yo(igwjGLKMHsuxeIAbDmuH(_003Ctool_003E5__2, cells, cellRange));
								PEcdaWKMYoAYi9hgFWyh();
								if (SwFgEmKMM2O6ERWL1rD3())
								{
									num3 = 9;
									continue;
								}
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 8:
								return;
							case 1:
							case 9:
								goto IL_013e;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (!PEcdaWKMYoAYi9hgFWyh())
								{
									continue;
								}
								goto case 10;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0079;
							}
							break;
						}
						goto IL_00b1;
						IL_013e:
						if (!awaiter.IsCompleted)
						{
							goto IL_00b1;
						}
						goto IL_00cb;
						end_IL_0079:;
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
		internal static object Xr5REcKMUo1RPgCtkWd8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object igwjGLKMHsuxeIAbDmuH(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter v0QFJBKMxunUCH3RZ4Yo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SwFgEmKMM2O6ERWL1rD3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PEcdaWKMYoAYi9hgFWyh()
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

		public GroupToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private GroupTool _003CnewTool_003E5__5;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!XP9T3RKMmju5aWdVo0RQ()) ? 5 : 6);
			TaskAwaiter awaiter = default;
			GroupToolType groupToolType = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<CvsCellCollection> awaiter3 = default;
			TaskAwaiter<CvsCellRange> awaiter2 = default;
			CvsCellCollection result2 = default;
			CvsCellRange result3 = default;
			EzTool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003Csheet_003E5__2 = null;
					num = 2;
					break;
				case 3:
					try
					{
						int num3;
						if ((uint)num2 > 2u)
						{
							if (num2 == 3)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03fc;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)ODBwUGKM1pAsPlExngS2(FnbJlcKMc6x85EtSrKkx(JSgth3KM2NabWl0G1uBW(qpgRmyKMNQaemItO1ifZ(groupToolType))));
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
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(groupToolType._pasteObject, (InspectStepViewModel)qpgRmyKMNQaemItO1ifZ(groupToolType), out var _);
								num4 = 2;
								break;
							}
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 7;
								break;
							case 1:
								awaiter3 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num4 = 15;
								break;
							case 0:
								awaiter2 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num4 = 16;
								break;
							}
							while (true)
							{
								switch (num4)
								{
								case 17:
									return;
								case 21:
									result2 = awaiter3.GetResult();
									num4 = 18;
									continue;
								case 16:
									num2 = (_003C_003E1__state = -1);
									num4 = 5;
									continue;
								case 7:
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_00ef;
								case 23:
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 17;
									if (0 == 0)
									{
										continue;
									}
									goto case 10;
								case 10:
								case 13:
									_003C_003Eu__2 = awaiter3;
									goto case 8;
								default:
									num4 = 8;
									if (LqhiAcKMQJLyIaZDGRgp())
									{
									}
									continue;
								case 19:
									_003CpasteRange_003E5__3 = result3;
									awaiter3 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
									num4 = 11;
									if (!LqhiAcKMQJLyIaZDGRgp())
									{
										continue;
									}
									goto case 4;
								case 4:
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num4 = 1;
									continue;
								case 12:
									return;
								case 3:
									if (!awaiter2.IsCompleted)
									{
										num4 = 20;
										if (true)
										{
											continue;
										}
										goto case 20;
									}
									goto case 5;
								case 20:
									num2 = (_003C_003E1__state = 0);
									num4 = 14;
									if (true)
									{
										continue;
									}
									goto case 15;
								case 15:
									num2 = (_003C_003E1__state = -1);
									num4 = 21;
									continue;
								case 0:
									num2 = (_003C_003E1__state = 2);
									num4 = 23;
									continue;
								case 18:
									_003CnewTool_003E5__5 = new GroupTool(groupToolType.Inspect, isInitialized: false);
									num4 = 6;
									continue;
								case 22:
									if (awaiter.IsCompleted)
									{
										goto IL_00ef;
									}
									num4 = 0;
									if (true)
									{
										continue;
									}
									goto case 6;
								case 6:
									awaiter = Shop3rKMhhr8f8qg1hON(T3sfWnKMuS7QKxu2CWpN(_003CnewTool_003E5__5, result2, _003CpasteRange_003E5__3));
									num4 = 22;
									continue;
								case 1:
									return;
								case 11:
									if (awaiter3.IsCompleted)
									{
										goto case 21;
									}
									num2 = (_003C_003E1__state = 1);
									goto case 10;
								case 2:
									awaiter2 = groupToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
									num4 = 3;
									continue;
								case 14:
									_003C_003Eu__1 = awaiter2;
									_ = 0;
									num4 = (XP9T3RKMmju5aWdVo0RQ() ? 9 : 13);
									continue;
								case 5:
									result3 = awaiter2.GetResult();
									num4 = 19;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num4 = 12;
									continue;
								case 24:
									{
										result = _003CnewTool_003E5__5;
										break;
									}
									IL_00ef:
									awaiter.GetResult();
									num4 = 24;
									continue;
								}
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_0395;
						}
						goto end_IL_0035;
						IL_0395:
						if (num3 == 1)
						{
							awaiter = Shop3rKMhhr8f8qg1hON(groupToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_03fc;
						}
						goto IL_0425;
						IL_03fc:
						awaiter.GetResult();
						Y3x29KKMztCxWAZJ4y9E(x0k0bKKMt9XxsIOTojHc((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0425;
						IL_0425:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0035:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 6:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					groupToolType = _003C_003E4__this;
					num = 3;
					if (LqhiAcKMQJLyIaZDGRgp())
					{
					}
					break;
				case 2:
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
		internal static object qpgRmyKMNQaemItO1ifZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JSgth3KM2NabWl0G1uBW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FnbJlcKMc6x85EtSrKkx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ODBwUGKM1pAsPlExngS2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object T3sfWnKMuS7QKxu2CWpN(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Shop3rKMhhr8f8qg1hON(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x0k0bKKMt9XxsIOTojHc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Y3x29KKMztCxWAZJ4y9E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XP9T3RKMmju5aWdVo0RQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LqhiAcKMQJLyIaZDGRgp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public static readonly Guid[] _guids;

	private int Ed74jPEwks;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _guids;
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
			return Resources.zmhtYsvg6p();
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
			return (string)NnKEG63TVL5oFgBWbkX();
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
			return XAMLGraphicKeys.Tools_GroupIcon;
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
			return XAMLGraphicKeys.Tools_GroupIcon;
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
				(string)qHKa5O3yYHbiiEca9ty()
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
			return Ed74jPEwks;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref Ed74jPEwks, value, (string)DkD26n30jgRbR3Fduv3(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (lkrVaY364ddvIwPBM69())
		{
			num = 1;
		}
		else
		{
			num = 3;
			if (!lkrVaY364ddvIwPBM69())
			{
				goto IL_0045;
			}
		}
		goto IL_006c;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 6:
				Ed74jPEwks = 601;
				goto case 2;
			case 0:
			case 1:
				break;
			case 2:
			case 3:
				base._002Ector();
				goto case 5;
			default:
				num = 5;
				continue;
			case 5:
				_pasteObject = (PasteBuffer)m6wcCx3W6ArCXGNBerU(HEvyAJ3RQGijTexSZJ4());
				num = 4;
				continue;
			case 4:
				AddSnippet(_pasteObject);
				num = 7;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_0045;
		IL_0045:
		V6ZbZB3AcyBWB0LkoXr();
		num = 6;
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enumerable.Empty<ISnippetUpdate>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__21))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!zxWIpQ3Ce22Lmt69yIY())
		{
			num = 2;
		}
		else
		{
			num = 5;
			if (zxWIpQ3Ce22Lmt69yIY())
			{
				goto IL_0091;
			}
		}
		goto IL_005a;
		IL_0091:
		_003COnBeginAddInternal_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (true)
		{
			goto IL_005a;
		}
		goto IL_00ab;
		IL_00ab:
		stateMachine._003C_003E4__this = this;
		num = 4;
		goto IL_005a;
		IL_005a:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = xE6anX3FvIQoQpsZ3PN();
				num = 1;
				if (lkrVaY364ddvIwPBM69())
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E1__state = -1;
				break;
			case 1:
				goto IL_00ab;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0091;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__22))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
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
	static GroupToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		_guids = new Guid[1]
		{
			new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(25482))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V6ZbZB3AcyBWB0LkoXr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HEvyAJ3RQGijTexSZJ4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.GroupTool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m6wcCx3W6ArCXGNBerU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lkrVaY364ddvIwPBM69()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zxWIpQ3Ce22Lmt69yIY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NnKEG63TVL5oFgBWbkX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.uuetVYJgUY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qHKa5O3yYHbiiEca9ty()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OKi0OpLUby();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DkD26n30jgRbR3Fduv3(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder xE6anX3FvIQoQpsZ3PN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
