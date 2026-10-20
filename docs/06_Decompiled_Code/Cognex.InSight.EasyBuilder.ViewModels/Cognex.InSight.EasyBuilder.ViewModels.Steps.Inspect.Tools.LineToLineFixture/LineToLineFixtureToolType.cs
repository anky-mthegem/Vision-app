using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Imaging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindEdge;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using oF2MOjpuTE9ryB96aX;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.LineToLineFixture;

[Export(typeof(EzToolType))]
public class LineToLineFixtureToolType : EzToolType, IGraphicToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnGraphicChanged_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LineToLineFixtureToolType _003C_003E4__this;

		public CvsEditEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (x5WTCQKTJgg2bXKRZSh4() ? 1 : 5);
			int num2 = default;
			LineToLineFixtureToolType lineToLineFixtureToolType = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = lineToLineFixtureToolType.SetDisplayGraphics(xFuR8EKTeEtillJhE6S6(e) as CvsEditableDisplayGraphic).GetAwaiter();
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (1 == 0)
							{
								goto IL_0068;
							}
						}
						goto IL_00cf;
						IL_0138:
						awaiter.GetResult();
						goto end_IL_0024;
						IL_0080:
						_003C_003Eu__1 = default;
						goto IL_009c;
						IL_00cf:
						while (true)
						{
							switch (num3)
							{
							case 0:
								return;
							case 1:
								break;
							case 2:
								goto IL_0080;
							case 5:
							case 6:
								goto IL_009c;
							case 3:
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 7:
								goto IL_0119;
							case 9:
								goto IL_0138;
							}
							break;
							IL_0119:
							_003C_003Eu__1 = awaiter;
							_ = 0;
							if (!x5WTCQKTJgg2bXKRZSh4())
							{
								num3 = 5;
								continue;
							}
							num3 = 8;
							if (0 == 0)
							{
								continue;
							}
							goto IL_0138;
						}
						goto IL_0068;
						IL_0068:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							if (false)
							{
								goto IL_0080;
							}
							goto IL_00cf;
						}
						goto IL_0138;
						IL_009c:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00cf;
						end_IL_0024:;
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
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 2:
					lineToLineFixtureToolType = _003C_003E4__this;
					num = 4;
					continue;
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
		internal static object xFuR8EKTeEtillJhE6S6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditEventArgs)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x5WTCQKTJgg2bXKRZSh4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iMq0s0KTao3CdrEkGtma()
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
	private struct _003CSetDisplayGraphics_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsEditableDisplayGraphic graphic;

		public LineToLineFixtureToolType _003C_003E4__this;

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
			if (!ETLbFyKTInkWcxrp3Due())
			{
				num = 2;
				if (ETLbFyKTInkWcxrp3Due())
				{
				}
			}
			else
			{
				num = 3;
			}
			LineToLineFixtureToolType lineToLineFixtureToolType = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			CvsDisplayableLine cvsDisplayableLine = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (yr5dGLKTOhQNjC8ooOQj())
					{
						break;
					}
					goto case 1;
				case 1:
				case 3:
					lineToLineFixtureToolType = _003C_003E4__this;
					num = 5;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (graphic != null)
							{
								num3 = 7;
							}
							else
							{
								lineToLineFixtureToolType.EYlMcAiXTR = null;
								num3 = 16;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 15;
							if (!yr5dGLKTOhQNjC8ooOQj())
							{
								goto IL_00b9;
							}
						}
						goto IL_00d4;
						IL_00d4:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 8:
								return;
							case 11:
								goto IL_00b9;
							default:
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto end_IL_0071;
							case 10:
								goto end_IL_0071;
							case 7:
								if (lineToLineFixtureToolType.EYlMcAiXTR == null)
								{
									ETLbFyKTInkWcxrp3Due();
									if (yr5dGLKTOhQNjC8ooOQj())
									{
										num3 = 12;
										continue;
									}
									num3 = 14;
									if (0 == 0)
									{
										continue;
									}
									goto case 15;
								}
								if (lineToLineFixtureToolType.EYlMcAiXTR == graphic)
								{
									goto IL_017f;
								}
								lineToLineFixtureToolType.npNMQbWEhO = graphic;
								goto case 3;
							case 5:
								awaiter = UovjDJKTiFdwoV1Pr3wY(AhTxOEKTDRMkXm7uomAP(lineToLineFixtureToolType.AcceptAddCommand));
								num3 = 2;
								continue;
							case 4:
							case 9:
								goto IL_017f;
							case 1:
							case 12:
								lineToLineFixtureToolType.EYlMcAiXTR = graphic;
								num3 = 9;
								continue;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 6:
								if (cvsDisplayableLine != null)
								{
									lineToLineFixtureToolType.Center = new PointF((XEW8TtKTVWyZoyR5LQo3(gwClyBKTnWrtTVd05ZJa(cvsDisplayableLine)).X + hQaDQ0KTf3hCsBPYjXx0(cvsDisplayableLine.Line).X) / 2f, (XEW8TtKTVWyZoyR5LQo3(gwClyBKTnWrtTVd05ZJa(cvsDisplayableLine)).Y + ((CvsGraphicLine)gwClyBKTnWrtTVd05ZJa(cvsDisplayableLine)).EndPoint.Y) / 2f);
									num3 = 10;
									continue;
								}
								goto end_IL_0071;
							case 15:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0285;
							case 3:
							case 14:
								lineToLineFixtureToolType.Center = PointF.Empty;
								num3 = 5;
								continue;
							case 2:
								if (awaiter.IsCompleted)
								{
									goto IL_0285;
								}
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								{
									lineToLineFixtureToolType.Center = PointF.Empty;
									goto end_IL_0071;
								}
								IL_0285:
								awaiter.GetResult();
								num3 = 4;
								if (yr5dGLKTOhQNjC8ooOQj())
								{
									continue;
								}
								goto case 3;
							}
							break;
							IL_017f:
							cvsDisplayableLine = graphic as CvsDisplayableLine;
							num3 = 6;
						}
						goto IL_008c;
						IL_00b9:
						num2 = (_003C_003E1__state = 0);
						goto IL_008c;
						IL_008c:
						_003C_003Eu__1 = awaiter;
						num3 = 13;
						goto IL_00d4;
						end_IL_0071:;
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
		internal static object AhTxOEKTDRMkXm7uomAP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter UovjDJKTiFdwoV1Pr3wY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gwClyBKTnWrtTVd05ZJa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableLine)P_0).Line;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF XEW8TtKTVWyZoyR5LQo3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).StartPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF hQaDQ0KTf3hCsBPYjXx0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).EndPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yr5dGLKTOhQNjC8ooOQj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ETLbFyKTInkWcxrp3Due()
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
	private struct _003CCreateTool_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public Guid guid;

		public LineToLineFixtureToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private LineToLineFixtureTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			LineToLineFixtureToolType lineToLineFixtureToolType = default;
			EzTool result = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					lineToLineFixtureToolType = _003C_003E4__this;
					_ = 0;
					num = ((!wmHLN3KTdMg4nXKmvROJ()) ? 5 : 0);
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (!guid.Equals(FZ1MDxWfYR))
							{
								throw new NotImplementedException();
							}
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								awaiter = e2yHsIKTvmeo7hf0boyL(qXlKg1KTsUb1DeGx4ydF(_003Ctool_003E5__2, cells, cellRange));
								num3 = 7;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								_ = 0;
								num3 = ((!wmHLN3KTdMg4nXKmvROJ()) ? 2 : 5);
								continue;
							case 5:
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto IL_00eb;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto IL_00eb;
							case 3:
								_003Ctool_003E5__2 = new LineToLineFixtureTool((InspectStepViewModel)eFq3C4KTgTxa3qLcloqD(lineToLineFixtureToolType), isInitialized: true);
								num3 = 0;
								if (iq6QlAKTl8HU8gtI31PT())
								{
								}
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 2:
							case 9:
								break;
							case 10:
								return;
							case 12:
								goto end_IL_0157;
								IL_00eb:
								awaiter.GetResult();
								break;
							}
							result = _003Ctool_003E5__2;
							num3 = 12;
							continue;
							end_IL_0157:
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
		internal static object eFq3C4KTgTxa3qLcloqD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qXlKg1KTsUb1DeGx4ydF(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter e2yHsIKTvmeo7hf0boyL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wmHLN3KTdMg4nXKmvROJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iq6QlAKTl8HU8gtI31PT()
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
	private struct _003COnBeginAddInternal_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LineToLineFixtureToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fr68AjKTPerGSwlGmThT();
			int num = ((!KKPQdmKTr1bZ9igbR7Iu()) ? 1 : 4);
			int num2 = default;
			LineToLineFixtureToolType lineToLineFixtureToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 2;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					lineToLineFixtureToolType = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							lineToLineFixtureToolType.EYlMcAiXTR = null;
							num3 = 2;
							if (!KKPQdmKTr1bZ9igbR7Iu())
							{
								goto IL_007c;
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
							case 4:
								break;
							case 8:
								return;
							case 11:
								return;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 5:
								lineToLineFixtureToolType.Ed6MR9pBEY = (CvsEditableDisplayGraphic[])G7FxYRKTZi4tCHASb6dB(lineToLineFixtureToolType.JbhM6ssKa8());
								KKPQdmKTr1bZ9igbR7Iu();
								num3 = ((!fr68AjKTPerGSwlGmThT()) ? 1 : 11);
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									goto case 10;
								}
								goto case 12;
							default:
								num3 = 10;
								if (!fr68AjKTPerGSwlGmThT())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 3:
								awaiter = IC6rW5KTBpynxb6Vlxwv(lineToLineFixtureToolType.s1sMFdxgEW());
								num3 = 9;
								if (KKPQdmKTr1bZ9igbR7Iu())
								{
									continue;
								}
								goto case 10;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 2:
								lineToLineFixtureToolType.npNMQbWEhO = null;
								num3 = 6;
								continue;
							case 6:
								lineToLineFixtureToolType.Center = PointF.Empty;
								num3 = 5;
								continue;
							case 12:
								awaiter.GetResult();
								goto end_IL_012b;
							}
							goto IL_007c;
							continue;
							end_IL_012b:
							break;
						}
						goto end_IL_005f;
						IL_007c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_005f:;
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
		internal static object G7FxYRKTZi4tCHASb6dB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter IC6rW5KTBpynxb6Vlxwv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KKPQdmKTr1bZ9igbR7Iu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fr68AjKTPerGSwlGmThT()
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
	private struct _003CAddTool_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public LineToLineFixtureToolType _003C_003E4__this;

		private string _003Cexpr0_003E5__2;

		private string _003Cexpr1_003E5__3;

		private CvsCogSocketSheet _003Csheet_003E5__4;

		private CvsCellRange _003CpasteRange_003E5__5;

		private TaskAwaiter<string> _003C_003Eu__1;

		private object _003C_003E7__wrap5;

		private LineToLineFixtureTool _003CnewTool_003E5__7;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__3;

		private TaskAwaiter<object> _003C_003Eu__4;

		private TaskAwaiter _003C_003Eu__5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 8;
			EzTool result2 = default;
			LineToLineFixtureToolType lineToLineFixtureToolType = default;
			TaskAwaiter<CvsCellCollection> awaiter5 = default;
			TaskAwaiter<object> awaiter3 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<CvsCellRange> awaiter4 = default;
			CvsCellRange result3 = default;
			CvsCellCollection result5 = default;
			CvsCellCollection result4 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 8:
					num2 = _003C_003E1__state;
					num = 6;
					break;
				case 0:
					_003Csheet_003E5__4 = null;
					num = 7;
					break;
				default:
					_003Cexpr1_003E5__3 = null;
					num = 0;
					break;
				case 7:
					_003C_003Et__builder.SetResult(result2);
					num = 9;
					if (cpRl1OKTbdPPcmKqpcLN())
					{
						break;
					}
					goto case 6;
				case 6:
					lineToLineFixtureToolType = _003C_003E4__this;
					_ = 0;
					if (cpRl1OKTbdPPcmKqpcLN())
					{
						num = 5;
						if (true)
						{
							break;
						}
						goto case 3;
					}
					num = 1;
					break;
				case 3:
					_003Cexpr0_003E5__2 = null;
					goto default;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<string> awaiter2;
						string result;
						int num3;
						switch (num2)
						{
						default:
							awaiter2 = lineToLineFixtureToolType.LmyMut1SPq(lineToLineFixtureToolType.EYlMcAiXTR).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_016a;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_016a;
						case 1:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01d9;
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
							try
							{
								int num4;
								switch (num2)
								{
								default:
									num4 = 32;
									goto IL_0629;
								case 2:
									awaiter5 = _003C_003Eu__2;
									num4 = 20;
									if (LrmepqKTGdXExFsOn8Pu())
									{
										goto IL_0323;
									}
									goto IL_0629;
								case 4:
									awaiter3 = _003C_003Eu__4;
									num4 = 46;
									goto IL_0629;
								case 7:
									awaiter5 = _003C_003Eu__2;
									num4 = 7;
									if (LrmepqKTGdXExFsOn8Pu())
									{
										goto IL_05a4;
									}
									goto IL_0629;
								case 8:
									awaiter = _003C_003Eu__5;
									_003C_003Eu__5 = default;
									num2 = (_003C_003E1__state = -1);
									num4 = 1;
									goto IL_0629;
								case 3:
									awaiter4 = _003C_003Eu__3;
									num4 = 35;
									goto IL_0629;
								case 5:
									awaiter3 = _003C_003Eu__4;
									num4 = 25;
									if (!LrmepqKTGdXExFsOn8Pu())
									{
										goto IL_0629;
									}
									goto IL_07c7;
								case 6:
									{
										awaiter3 = _003C_003Eu__4;
										num4 = 22;
										goto IL_0629;
									}
									IL_0629:
									while (true)
									{
										switch (num4)
										{
										case 32:
											awaiter5 = ((CvsCogSocketSheet)twYEbbKT8MuJPQxALkFp(SH0aKjKTkfGh73xvrE26(GSMdtBKTSmTlWoIvmokT(hkNqbVKToAEXiPo71kLs(lineToLineFixtureToolType))))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
											num4 = 5;
											if (cpRl1OKTbdPPcmKqpcLN())
											{
												continue;
											}
											goto case 23;
										case 23:
											awaiter3.GetResult();
											num4 = 39;
											continue;
										case 2:
										case 47:
											num2 = (_003C_003E1__state = 2);
											num4 = 27;
											continue;
										case 39:
											awaiter5 = _003Csheet_003E5__4.RunAndGetCellResults().GetAwaiter();
											num4 = 12;
											continue;
										case 31:
											if (!awaiter4.IsCompleted)
											{
												num2 = (_003C_003E1__state = 3);
												num4 = 30;
												if (LrmepqKTGdXExFsOn8Pu())
												{
												}
												continue;
											}
											goto case 40;
										case 40:
											result3 = awaiter4.GetResult();
											num4 = 4;
											continue;
										case 38:
											if (!awaiter3.IsCompleted)
											{
												num4 = 0;
												continue;
											}
											goto case 23;
										case 18:
											return;
										case 26:
											break;
										case 17:
											awaiter3 = _003Csheet_003E5__4.PutCellExpressionAsync(lineToLineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, lineToLineFixtureToolType.W55MIHlE2v), (string)DPR9nxKTqZO2qgJ8OdNu(lineToLineFixtureToolType.InputImageLinks[lineToLineFixtureToolType.InputImageIndex])).GetAwaiter();
											num4 = 16;
											continue;
										case 12:
											if (!awaiter5.IsCompleted)
											{
												num4 = 13;
												continue;
											}
											goto IL_0839;
										case 43:
											_003CnewTool_003E5__7 = new LineToLineFixtureTool((InspectStepViewModel)hkNqbVKToAEXiPo71kLs(lineToLineFixtureToolType), isInitialized: false);
											awaiter = vbgqaMKTpjZB0xWyFDhu(U5F663KTEEvUuccxrAHW(_003CnewTool_003E5__7, result5, _003CpasteRange_003E5__5));
											if (!awaiter.IsCompleted)
											{
												num2 = (_003C_003E1__state = 8);
												goto IL_05a4;
											}
											goto case 1;
										case 19:
											_003C_003Eu__4 = awaiter3;
											num4 = 15;
											continue;
										case 6:
											awaiter3.GetResult();
											awaiter3 = _003Csheet_003E5__4.PutCellExpressionAsync(lineToLineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, lineToLineFixtureToolType.bL1MfrCxFe), _003Cexpr0_003E5__2).GetAwaiter();
											num4 = 37;
											continue;
										case 30:
											_003C_003Eu__3 = awaiter4;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											num4 = 24;
											continue;
										case 46:
											_003C_003Eu__4 = default;
											num2 = (_003C_003E1__state = -1);
											num4 = 6;
											continue;
										case 9:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
											num4 = 18;
											continue;
										case 15:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num4 = 3;
											continue;
										case 0:
											num2 = (_003C_003E1__state = 6);
											num4 = 33;
											continue;
										case 7:
											_003C_003Eu__2 = default;
											num4 = 45;
											continue;
										case 5:
											if (!awaiter5.IsCompleted)
											{
												_ = 0;
												if (!cpRl1OKTbdPPcmKqpcLN())
												{
													num4 = 21;
													if (true)
													{
														continue;
													}
													goto case 19;
												}
												num4 = 47;
												continue;
											}
											goto IL_05fb;
										case 35:
											_003C_003Eu__3 = default;
											num2 = (_003C_003E1__state = -1);
											num4 = 40;
											continue;
										case 34:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 41:
											awaiter3 = _003Csheet_003E5__4.PutCellExpressionAsync(lineToLineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, lineToLineFixtureToolType.TvuME1l0rV), _003Cexpr1_003E5__3).GetAwaiter();
											num4 = 38;
											continue;
										case 37:
											if (!awaiter3.IsCompleted)
											{
												num4 = 28;
												continue;
											}
											goto case 8;
										case 11:
											return;
										case 21:
										case 44:
											goto IL_05a4;
										case 20:
											_003C_003Eu__2 = default;
											num2 = (_003C_003E1__state = -1);
											goto IL_05fb;
										case 28:
											num2 = (_003C_003E1__state = 5);
											goto case 19;
										default:
											num4 = 19;
											continue;
										case 27:
											_003C_003Eu__2 = awaiter5;
											num4 = 9;
											continue;
										case 14:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
											num4 = 11;
											continue;
										case 29:
											awaiter4 = lineToLineFixtureToolType.RenameAndPasteTool(lineToLineFixtureToolType._pasteObject, result4, runSheet: false).GetAwaiter();
											num4 = 31;
											if (cpRl1OKTbdPPcmKqpcLN())
											{
												continue;
											}
											goto case 33;
										case 33:
											_003C_003Eu__4 = awaiter3;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num4 = 42;
											if (cpRl1OKTbdPPcmKqpcLN())
											{
												continue;
											}
											goto case 25;
										case 25:
											_003C_003Eu__4 = default;
											num2 = (_003C_003E1__state = -1);
											num4 = 8;
											if (true)
											{
												continue;
											}
											return;
										case 24:
											return;
										case 3:
											return;
										case 36:
											goto IL_07c7;
										case 4:
											_003CpasteRange_003E5__5 = result3;
											num4 = 17;
											if (cpRl1OKTbdPPcmKqpcLN())
											{
												continue;
											}
											goto case 22;
										case 22:
											_003C_003Eu__4 = default;
											num2 = (_003C_003E1__state = -1);
											num4 = 23;
											continue;
										case 42:
											return;
										case 45:
											num2 = (_003C_003E1__state = -1);
											goto IL_0839;
										case 8:
											awaiter3.GetResult();
											num4 = 41;
											continue;
										case 16:
											if (!awaiter3.IsCompleted)
											{
												num4 = 36;
												continue;
											}
											goto case 6;
										case 1:
											awaiter.GetResult();
											num4 = 48;
											continue;
										case 10:
											_003CpasteRange_003E5__5 = CvsCellRange.Empty;
											num4 = 29;
											if (LrmepqKTGdXExFsOn8Pu())
											{
											}
											continue;
										case 13:
											num2 = (_003C_003E1__state = 7);
											num4 = 26;
											continue;
										case 48:
											{
												result2 = _003CnewTool_003E5__7;
												goto end_IL_0215;
											}
											IL_05fb:
											result4 = awaiter5.GetResult();
											num4 = 10;
											continue;
											IL_0839:
											result5 = awaiter5.GetResult();
											num4 = 43;
											continue;
										}
										break;
									}
									goto IL_0323;
									IL_07c7:
									num2 = (_003C_003E1__state = 4);
									_003C_003Eu__4 = awaiter3;
									num4 = 34;
									goto IL_0629;
									IL_05a4:
									_003C_003Eu__5 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
									IL_0323:
									_003C_003Eu__2 = awaiter5;
									num4 = 14;
									goto IL_0629;
									end_IL_0215:
									break;
								}
							}
							catch (object obj)
							{
								_003C_003E7__wrap5 = obj;
								num3 = 1;
								goto IL_08d5;
							}
							goto end_IL_00dc;
						case 9:
							{
								awaiter = _003C_003Eu__5;
								_003C_003Eu__5 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_093e;
							}
							IL_08d5:
							if (num3 != 1)
							{
								break;
							}
							awaiter = lineToLineFixtureToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__5).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__5 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_093e;
							IL_016a:
							result = awaiter2.GetResult();
							_003Cexpr0_003E5__2 = result;
							awaiter2 = lineToLineFixtureToolType.LmyMut1SPq(lineToLineFixtureToolType.npNMQbWEhO).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01d9;
							IL_093e:
							awaiter.GetResult();
							GvRtOJKT9BxZMpdVDmhJ(K4FhrJKTX8tsfRk7h79P((_003C_003E7__wrap5 as Exception) ?? throw _003C_003E7__wrap5));
							break;
							IL_01d9:
							result = awaiter2.GetResult();
							_003Cexpr1_003E5__3 = result;
							_003Csheet_003E5__4 = ((CvsCogSocket)SH0aKjKTkfGh73xvrE26(GSMdtBKTSmTlWoIvmokT(hkNqbVKToAEXiPo71kLs(lineToLineFixtureToolType)))).Sheet;
							_003CpasteRange_003E5__5 = CvsCellRange.Empty;
							num3 = 0;
							goto case 2;
						}
						_003C_003E7__wrap5 = null;
						_003Cexpr0_003E5__2 = null;
						_003Cexpr1_003E5__3 = null;
						_003Csheet_003E5__4 = null;
						_003CpasteRange_003E5__5 = default;
						end_IL_00dc:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cexpr0_003E5__2 = null;
						_003Cexpr1_003E5__3 = null;
						_003Csheet_003E5__4 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 3;
					if (1 == 0)
					{
						return;
					}
					break;
				case 9:
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
		internal static object hkNqbVKToAEXiPo71kLs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GSMdtBKTSmTlWoIvmokT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SH0aKjKTkfGh73xvrE26(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object twYEbbKT8MuJPQxALkFp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DPR9nxKTqZO2qgJ8OdNu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U5F663KTEEvUuccxrAHW(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vbgqaMKTpjZB0xWyFDhu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object K4FhrJKTX8tsfRk7h79P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GvRtOJKT9BxZMpdVDmhJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cpRl1OKTbdPPcmKqpcLN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LrmepqKTGdXExFsOn8Pu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__40 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public LineToLineFixtureToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__40(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			q34008KT4jesPZLy0fhF();
			int num = (eN5wNUKT7pmdSdjR0WnW() ? 5 : 2);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					RWqjvKKT3Pmtdui0iuFo();
					goto case 1;
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					break;
				default:
					num = 3;
					continue;
				case 1:
				case 5:
					MTYSFNKTj2mCTEiLas0Z(this);
					num = 4;
					continue;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
				num = 6;
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
			q34008KT4jesPZLy0fhF();
			int num = (eN5wNUKT7pmdSdjR0WnW() ? 1 : 7);
			int num2 = default;
			LineToLineFixtureToolType lineToLineFixtureToolType = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					return false;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 7:
					num2 = _003C_003E1__state;
					num = 10;
					if (eN5wNUKT7pmdSdjR0WnW())
					{
					}
					continue;
				case 3:
					if (num2 != 1)
					{
						num = 5;
						continue;
					}
					_003C_003E1__state = -1;
					num = 11;
					if (true)
					{
						continue;
					}
					goto case 4;
				case 1:
				case 6:
					_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(lineToLineFixtureToolType._pasteObject, (CvsFunctionTable)SutvPXKTC33G4XgVf5OK(lineToLineFixtureToolType.InSight), (IExpressionConstants)k9Hp01KTAyu1dT4UdSal(lineToLineFixtureToolType.InSight));
					num = 2;
					continue;
				case 8:
					if (num2 == 0)
					{
						_003C_003E1__state = -1;
						goto case 4;
					}
					num = 3;
					continue;
				case 10:
					lineToLineFixtureToolType = _003C_003E4__this;
					num = 8;
					continue;
				case 2:
					_003C_003E1__state = 1;
					num = 9;
					continue;
				case 9:
					return true;
				case 4:
				{
					int num3 = jusEJjKT6S8Vr5kvy0O2(cells, range);
					int snippetVersion = SnippetPasteBuffer.GetSnippetVersion(lineToLineFixtureToolType._pasteObject);
					if (num3 >= snippetVersion)
					{
						break;
					}
					goto case 1;
				}
				case 11:
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
			_003CGetUpdates_003Ed__40 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__40(0)
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
		internal static void RWqjvKKT3Pmtdui0iuFo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MTYSFNKTj2mCTEiLas0Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q34008KT4jesPZLy0fhF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eN5wNUKT7pmdSdjR0WnW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int jusEJjKT6S8Vr5kvy0O2(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SutvPXKTC33G4XgVf5OK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object k9Hp01KTAyu1dT4UdSal(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<EzToolType, bool> _003C_003E9__42_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			M3J4qVKTTpM00AZGqAp2();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_FindEdgeToolType_003Eb__42_0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VK3WtYKT05PQFFqksTZ2(t.ToolType, UZMTPUKTyVgdcfdWu1bb());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gux2w8KTR6gObXM7xJFF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BWobTWKTWEuuOTXgweNm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void M3J4qVKTTpM00AZGqAp2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UZMTPUKTyVgdcfdWu1bb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Kb8tdpAgrR();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VK3WtYKT05PQFFqksTZ2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetGraphicExpression_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CvsEditableDisplayGraphic editableGraphic;

		public LineToLineFixtureToolType _003C_003E4__this;

		private string _003Cexpr_003E5__2;

		private CvsDisplayableLine _003Cline_003E5__3;

		private FindEdgeToolType _003CfindLineToolType_003E5__4;

		private EzTool _003Ctool_003E5__5;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<EzTool> _003C_003Eu__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			string result2 = default;
			int num2 = default;
			LineToLineFixtureToolType lineToLineFixtureToolType = default;
			TaskAwaiter<CvsCellCollection> awaiter3 = default;
			TaskAwaiter<EzTool> awaiter2 = default;
			TaskAwaiter awaiter = default;
			string text2 = default;
			CvsCellLocation cellLocation = default;
			string text = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult(result2);
					num = 8;
					break;
				case 7:
					_003Cline_003E5__3 = null;
					num = 5;
					break;
				case 0:
					num2 = _003C_003E1__state;
					VG2JUdKTMjWDOZbVA0wd();
					if (Gk7mxpKTFvc25FErBU4B())
					{
						num = 2;
						break;
					}
					num = 4;
					if (true)
					{
						break;
					}
					goto case 3;
				case 1:
				case 2:
					lineToLineFixtureToolType = _003C_003E4__this;
					num = 6;
					break;
				case 6:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003Cexpr_003E5__2 = (string)qZDZ4GKTY9nWD5jl1mhH(1838);
							num3 = 24;
							goto IL_02c6;
						case 3:
							awaiter3 = _003C_003Eu__3;
							num3 = 16;
							goto IL_02c6;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 6;
							goto IL_02c6;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_051e;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0437;
							}
							IL_02c6:
							while (true)
							{
								switch (num3)
								{
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 17;
									continue;
								case 5:
								case 26:
									_003Cexpr_003E5__2 = text2;
									num3 = 11;
									continue;
								case 36:
									awaiter = z5DJFUKTma1PmQLugGmT(wDRO1bKTxPwjkhOWXxet(_003CfindLineToolType_003E5__4, xtlbNcKTHo8SFyDFlwKv(lineToLineFixtureToolType)));
									num3 = 19;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								case 3:
									if (_003Cline_003E5__3 != null)
									{
										num3 = 21;
										continue;
									}
									goto case 11;
								case 0:
									awaiter3 = ((CvsCogSocketSheet)XLQsRXKT2qWDyoK4dSEy(ElmL23KTNBIXv1pl5Nyr(gZLqMLKTQ67lr9Kgs7hY(lineToLineFixtureToolType)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
									num3 = 4;
									continue;
								case 32:
									return;
								case 29:
									_003Cexpr_003E5__2 = cellLocation.ToString(absoluteRow: true, absoluteColumn: true);
									goto case 11;
								case 7:
									text2 = iGkkVAKTUweymZZ6aGpg(editableGraphic) as string;
									num3 = 34;
									continue;
								case 14:
									text = ((IEnumerable<CvsEditableDisplayGraphic>)mkaL2PKTcThOFZZR93Aa(_003Ctool_003E5__5, result, CellType.Line)).FirstOrDefault().Tag as string;
									num3 = 10;
									if (true)
									{
										continue;
									}
									break;
								case 34:
									break;
								case 27:
									awaiter2 = _003CfindLineToolType_003E5__4.YBE4tPvMRf(_003Cline_003E5__3).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter2;
										num3 = 31;
										continue;
									}
									goto case 17;
								case 12:
									_003Ctool_003E5__5 = null;
									num3 = 22;
									continue;
								case 2:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 39;
									continue;
								case 19:
									if (!awaiter.IsCompleted)
									{
										num3 = 33;
										if (Gk7mxpKTFvc25FErBU4B())
										{
											continue;
										}
										goto case 30;
									}
									goto IL_051e;
								case 30:
									_003C_003Eu__3 = awaiter3;
									num3 = 1;
									continue;
								case 9:
									num2 = (_003C_003E1__state = 3);
									num3 = 30;
									continue;
								case 17:
								{
									EzTool result3 = awaiter2.GetResult();
									_003Ctool_003E5__5 = result3;
									goto case 37;
								}
								default:
									num3 = 37;
									if (VG2JUdKTMjWDOZbVA0wd())
									{
									}
									continue;
								case 16:
									_003C_003Eu__3 = default;
									num3 = 13;
									continue;
								case 13:
									num2 = (_003C_003E1__state = -1);
									num3 = 25;
									continue;
								case 24:
									_003Cline_003E5__3 = editableGraphic as CvsDisplayableLine;
									num3 = 3;
									if (!VG2JUdKTMjWDOZbVA0wd())
									{
										continue;
									}
									goto case 28;
								case 28:
									_003Cexpr_003E5__2 = text;
									num3 = 12;
									if (VG2JUdKTMjWDOZbVA0wd())
									{
									}
									continue;
								case 33:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num3 = 15;
									continue;
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 18;
									if (VG2JUdKTMjWDOZbVA0wd())
									{
									}
									continue;
								case 22:
									goto IL_0426;
								case 23:
								case 35:
									goto end_IL_02c6;
								case 25:
									result = awaiter3.GetResult();
									num3 = 14;
									continue;
								case 38:
									return;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 32;
									continue;
								case 21:
									cellLocation = editableGraphic.CellLocation;
									num3 = 7;
									continue;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 2;
										continue;
									}
									goto end_IL_02c6;
								case 4:
									if (!awaiter3.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									goto case 25;
								case 10:
									if (text != null)
									{
										num3 = 28;
										if (VG2JUdKTMjWDOZbVA0wd())
										{
										}
										continue;
									}
									goto case 12;
								case 18:
									return;
								case 37:
									awaiter = z5DJFUKTma1PmQLugGmT(lineToLineFixtureToolType.s1Ou7UoL9J(_003Ctool_003E5__5));
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 39:
									return;
								case 31:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 38;
									continue;
								case 20:
									_003CfindLineToolType_003E5__4.RefreshInputImageLinks();
									num3 = 36;
									continue;
								case 11:
								case 40:
									result2 = _003Cexpr_003E5__2;
									goto end_IL_0072;
								}
								if (text2 == null)
								{
									if (cellLocation.IsValid)
									{
										num3 = 29;
										continue;
									}
									_003CfindLineToolType_003E5__4 = lineToLineFixtureToolType.GIuMoFF7S6();
									if (_003CfindLineToolType_003E5__4 != null)
									{
										num3 = 20;
										continue;
									}
									goto IL_0426;
								}
								_ = 0;
								num3 = ((!Gk7mxpKTFvc25FErBU4B()) ? 35 : 26);
								continue;
								IL_0426:
								_003CfindLineToolType_003E5__4 = null;
								num3 = 40;
								continue;
								end_IL_02c6:
								break;
							}
							goto IL_0437;
							IL_0437:
							awaiter.GetResult();
							num3 = 0;
							goto IL_02c6;
							IL_051e:
							awaiter.GetResult();
							num3 = 27;
							goto IL_02c6;
							end_IL_0072:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cexpr_003E5__2 = null;
						_003Cline_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				case 3:
				case 4:
					_003Cexpr_003E5__2 = null;
					goto case 7;
				default:
					num = 7;
					break;
				case 8:
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
		internal static object qZDZ4GKTY9nWD5jl1mhH(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iGkkVAKTUweymZZ6aGpg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableGraphic)P_0).Tag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int xtlbNcKTHo8SFyDFlwKv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wDRO1bKTxPwjkhOWXxet(object P_0, int value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).SetInputImageIndexAsync(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter z5DJFUKTma1PmQLugGmT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gZLqMLKTQ67lr9Kgs7hY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ElmL23KTNBIXv1pl5Nyr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XLQsRXKT2qWDyoK4dSEy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mkaL2PKTcThOFZZR93Aa(object P_0, object P_1, CellType reqDataType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).GetFeatures((CvsCellCollection)P_1, reqDataType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gk7mxpKTFvc25FErBU4B()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VG2JUdKTMjWDOZbVA0wd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid FZ1MDxWfYR;

	private static readonly Guid[] fAnM3duucn;

	private readonly CvsCellLocation W55MIHlE2v;

	private readonly CvsCellLocation bL1MfrCxFe;

	private readonly CvsCellLocation TvuME1l0rV;

	private FindEdgeToolType wUNMbqSkWD;

	private CvsEditableDisplayGraphic EYlMcAiXTR;

	private CvsEditableDisplayGraphic npNMQbWEhO;

	private PointF RptMgin78W;

	private int LnSMMSZNGw;

	private CvsEditableDisplayGraphic[] Ed6MR9pBEY;

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RptMgin78W;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RptMgin78W = value;
		}
	}

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fAnM3duucn;
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
			return (string)Ne1Aj19v9IvqZnXg8R4();
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
			return (string)JWExJa9rXycT3sEYQ1O();
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
			return XAMLGraphicKeys.Tools_LineToLineIntersection;
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
			return XAMLGraphicKeys.Tools_LineToLineIntersection;
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
				(string)aYaM6E9PAZhsrRQIlW1(),
				(string)IHkEXc9ZMoc5dVrPuDV()
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
			return LnSMMSZNGw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref LnSMMSZNGw, value, (string)gs4i5Q9lpH0wUs6Nxs6(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineToLineFixtureToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		SnippetLocalizer snippetLocalizer = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				snippetLocalizer.ExcludedStrings.Add((string)gs4i5Q9lpH0wUs6Nxs6(24288));
				AddSnippet(_pasteObject, snippetLocalizer);
				num = 12;
				break;
			case 1:
				RptMgin78W = PointF.Empty;
				num = 5;
				if (LeWTuq9nGvvv9mqn4bj())
				{
				}
				break;
			case 4:
				bL1MfrCxFe = _pasteObject.GetCellOffset((string)gs4i5Q9lpH0wUs6Nxs6(21598));
				num = 6;
				break;
			case 2:
				_pasteObject = (PasteBuffer)fmFJnq9dDPY3Lm6S43U(nqpN3M9fSEYb6ihNPMn());
				num = 11;
				break;
			case 3:
			case 10:
				base._002Ector();
				num = 2;
				break;
			case 11:
				W55MIHlE2v = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928));
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 8:
				snippetLocalizer = (SnippetLocalizer)N9UTwy9ghgJjUxhifSc();
				num = 9;
				if (!LeWTuq9nGvvv9mqn4bj())
				{
					break;
				}
				goto case 7;
			case 7:
				oVFxBh9VRLRlxW5fgIq();
				num = 1;
				break;
			case 6:
				TvuME1l0rV = _pasteObject.GetCellOffset((string)gs4i5Q9lpH0wUs6Nxs6(21622));
				goto case 0;
			case 5:
				LnSMMSZNGw = 400;
				uqGQyL9iJly3x6HZBZC();
				num = ((!LeWTuq9nGvvv9mqn4bj()) ? 10 : 0);
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnGraphicChanged_003Ed__7))]
	public Task OnGraphicChanged(object sender, CvsEditEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!uqGQyL9iJly3x6HZBZC())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_005d:
		_ = 0;
		if (uqGQyL9iJly3x6HZBZC())
		{
			num = 6;
			if (LeWTuq9nGvvv9mqn4bj())
			{
				goto IL_0079;
			}
		}
		else
		{
			num = 0;
		}
		goto IL_0038;
		IL_0038:
		_003COnGraphicChanged_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_005d;
			case 5:
				goto IL_0079;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 2:
				stateMachine._003C_003Et__builder = pWds9U9sh5N8gunPYkV();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_0079:
		stateMachine._003C_003E4__this = this;
		num = 1;
		goto IL_0038;
		IL_001e:
		stateMachine.e = e;
		goto IL_005d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetDisplayGraphics_003Ed__8))]
	public Task SetDisplayGraphics(CvsEditableDisplayGraphic graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSetDisplayGraphics_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine.graphic = graphic;
				goto case 5;
			default:
				num = 5;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (uqGQyL9iJly3x6HZBZC())
				{
					num = 0;
					continue;
				}
				num = 6;
				if (uqGQyL9iJly3x6HZBZC())
				{
					continue;
				}
				break;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__33))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__33 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.guid = guid;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__34))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003COnBeginAddInternal_003Ed__34 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E4__this = this;
				uqGQyL9iJly3x6HZBZC();
				num = (LeWTuq9nGvvv9mqn4bj() ? 4 : 5);
				break;
			case 1:
				stateMachine._003C_003Et__builder = pWds9U9sh5N8gunPYkV();
				num = 0;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateFeatureGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uqGQyL9iJly3x6HZBZC();
		int num;
		if (!LeWTuq9nGvvv9mqn4bj())
		{
			num = 5;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0049;
		IL_00a8:
		List<CvsEditableDisplayGraphic> list = default;
		Ed6MR9pBEY = (CvsEditableDisplayGraphic[])Ebb4Dv9B97nxyovcmk2(list);
		num = 6;
		goto IL_0049;
		IL_0049:
		CvsEditableDisplayGraphic[] source = default;
		while (true)
		{
			CvsEditableDisplayGraphic[] array;
			switch (num)
			{
			case 2:
			case 3:
				break;
			default:
				num = 4;
				continue;
			case 1:
				array = Array.Empty<CvsEditableDisplayGraphic>();
				goto IL_0079;
			case 0:
			case 5:
				array = Ed6MR9pBEY;
				if (array == null)
				{
					num = 1;
					continue;
				}
				goto IL_0079;
			case 4:
				goto IL_00a8;
			case 6:
				return;
				IL_0079:
				source = array;
				list = JbhM6ssKa8();
				break;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		FireAddGraphicsChanged(source.ToList(), list);
		goto IL_00a8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<CvsEditableDisplayGraphic> JbhM6ssKa8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsEditableDisplayGraphic> list = new List<CvsEditableDisplayGraphic>();
		if (Inspect.InSight.Results.Cells[CvsCellLocation.Parse(InputImageLinks[InputImageIndex].Expression)]?.CellResult.Value is CvsCogImage { Width: var width, Height: var height } cvsCogImage)
		{
			ICvsImageBuffer imageBuffer = CvsImageBufferFactory.FromBitmap(Inspect.InSight.CogSocket.GetImageByHttp(cvsCogImage.Url, new Size(width, height), new Rectangle(0, 0, width, height)), CnxPixelFormat.Format8bppGrayscale);
			RectangleF rectangleF = new RectangleF(cvsCogImage.OffsetX, cvsCogImage.OffsetY, width, height);
			CvsImage image = new CvsImage(imageBuffer, rectangleF, rectangleF);
			List<CvsEditableDisplayGraphic> list2 = new List<CvsEditableDisplayGraphic>();
			if (GIuMoFF7S6() != null && GIuMoFF7S6().IsTypeEnabled)
			{
				FeatureExtractor featureExtractor = new FeatureExtractor();
				if (GIuMoFF7S6() != null)
				{
					list2 = featureExtractor.FindLines(image);
				}
			}
			List<CvsEditableDisplayGraphic> list3 = new List<CvsEditableDisplayGraphic>();
			foreach (EzSnippet snippet in Inspect.Snippets)
			{
				CvsEditableDisplayGraphic[] features = snippet.GetFeatures(Inspect.InSight.Results.Cells, CellType.Line);
				foreach (CvsEditableDisplayGraphic cvsEditableDisplayGraphic in features)
				{
					list3.Add(cvsEditableDisplayGraphic);
					if (!(cvsEditableDisplayGraphic is CvsDisplayableLine line))
					{
						continue;
					}
					for (int num = list2.Count - 1; num >= 0; num--)
					{
						if (FeatureExtractor.LinesAreSimilar(list2[num] as CvsDisplayableLine, line))
						{
							list2.RemoveAt(num);
						}
					}
				}
			}
			list.AddRange(list3.ToArray());
			list.AddRange(list2.ToArray());
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Ed6MR9pBEY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__39))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__39 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__40))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__40(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private FindEdgeToolType GIuMoFF7S6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (wUNMbqSkWD == null)
		{
			wUNMbqSkWD = ((IEnumerable<EzToolType>)cT6Fl79bkoOZRGLIHdM(Inspect)).FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType t) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec.VK3WtYKT05PQFFqksTZ2(t.ToolType, _003C_003Ec.UZMTPUKTyVgdcfdWu1bb());
			}) as FindEdgeToolType;
		}
		return wUNMbqSkWD;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGraphicExpression_003Ed__43))]
	private Task<string> LmyMut1SPq(CvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetGraphicExpression_003Ed__43 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editableGraphic = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LineToLineFixtureToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!LeWTuq9nGvvv9mqn4bj())
		{
		}
		while (true)
		{
			switch (num)
			{
			default:
				fAnM3duucn = new Guid[1] { FZ1MDxWfYR };
				num = 5;
				continue;
			case 1:
			case 3:
				FZ1MDxWfYR = new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(24330));
				goto default;
			case 0:
				break;
			case 5:
				return;
			}
			do
			{
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				LeWTuq9nGvvv9mqn4bj();
				if (!uqGQyL9iJly3x6HZBZC())
				{
					num = 4;
					continue;
				}
				num = 3;
				break;
			}
			while (1 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task s1sMFdxgEW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oVFxBh9VRLRlxW5fgIq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nqpN3M9fSEYb6ihNPMn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.LineToLineFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fmFJnq9dDPY3Lm6S43U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gs4i5Q9lpH0wUs6Nxs6(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N9UTwy9ghgJjUxhifSc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippetType.CreateDefaultSnippetLocalizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uqGQyL9iJly3x6HZBZC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LeWTuq9nGvvv9mqn4bj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder pWds9U9sh5N8gunPYkV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ne1Aj19v9IvqZnXg8R4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.aRPnMq2fml();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JWExJa9rXycT3sEYQ1O()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NTEn4IL5yn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aYaM6E9PAZhsrRQIlW1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IHkEXc9ZMoc5dVrPuDV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.F0Z0bUM6Xp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ebb4Dv9B97nxyovcmk2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cT6Fl79bkoOZRGLIHdM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InspectStepViewModel)P_0).ToolTypes;
	}
}
