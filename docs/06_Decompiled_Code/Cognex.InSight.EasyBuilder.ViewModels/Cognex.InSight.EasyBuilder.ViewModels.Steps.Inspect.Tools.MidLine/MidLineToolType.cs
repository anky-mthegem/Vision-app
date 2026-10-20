using System;
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
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindEdge;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MidLine;

[Export(typeof(EzToolType))]
public class MidLineToolType : EzToolType, IGraphicToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnGraphicChanged_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MidLineToolType _003C_003E4__this;

		public CvsEditEventArgs e;

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
			if (!SvO8YwKAqnhtSIVaGg0c())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
				if (SvO8YwKAqnhtSIVaGg0c())
				{
				}
			}
			goto IL_01aa;
			IL_0026:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01aa;
			IL_01aa:
			MidLineToolType midLineToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 1:
				case 3:
					midLineToolType = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = C9v3AdKApXkqtJpKSWb5(midLineToolType.SetDisplayGraphics(eVLdihKAEVVxGvjFw7mo(e) as CvsEditableDisplayGraphic));
							SvO8YwKAqnhtSIVaGg0c();
							num3 = ((!dpMGSqKA8gfxC1GEZa8C()) ? 7 : 6);
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
							case 4:
								return;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 0:
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (SvO8YwKAqnhtSIVaGg0c())
								{
								}
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
					break;
				default:
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
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
		internal static object eVLdihKAEVVxGvjFw7mo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditEventArgs)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter C9v3AdKApXkqtJpKSWb5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dpMGSqKA8gfxC1GEZa8C()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SvO8YwKAqnhtSIVaGg0c()
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

		public MidLineToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (jWCmHAKAXSP7gubMxqeY())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (false)
				{
					return;
				}
			}
			int num2 = default;
			MidLineToolType midLineToolType = default;
			TaskAwaiter awaiter = default;
			CvsDisplayableLine cvsDisplayableLine = default;
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
							if (graphic != null)
							{
								_ = 1;
								if (!qgEmjvKA9mwNygqY4Eu8())
								{
									num3 = 9;
								}
								else
								{
									num3 = 10;
									if (!jWCmHAKAXSP7gubMxqeY())
									{
										goto IL_0206;
									}
								}
							}
							else
							{
								midLineToolType.TIeQC8uDmk = null;
								num3 = 16;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 8;
						}
						goto IL_021f;
						IL_0206:
						_003C_003Eu__1 = awaiter;
						goto IL_0096;
						IL_0096:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 11;
						goto IL_021f;
						IL_021f:
						while (true)
						{
							switch (num3)
							{
							case 12:
								midLineToolType.Center = PointF.Empty;
								num3 = 15;
								continue;
							case 4:
								if (cvsDisplayableLine != null)
								{
									num3 = 1;
									continue;
								}
								goto end_IL_0024;
							case 8:
								awaiter.GetResult();
								num3 = 2;
								continue;
							case 0:
							case 9:
								if (midLineToolType.TIeQC8uDmk == null)
								{
									num3 = 7;
									continue;
								}
								if (midLineToolType.TIeQC8uDmk != graphic)
								{
									midLineToolType.QfjQOlHnZP = graphic;
									num3 = 12;
									continue;
								}
								goto case 2;
							case 14:
								break;
							case 7:
								midLineToolType.TIeQC8uDmk = graphic;
								num3 = 5;
								continue;
							case 10:
								goto end_IL_0024;
							case 13:
								goto end_IL_0024;
							case 15:
								awaiter = mVdnxrKA7a3YLYMKm7tp(yGgF71KA4H0DaPOvy4LN(midLineToolType.AcceptAddCommand));
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 8;
							case 11:
								return;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (!qgEmjvKA9mwNygqY4Eu8())
								{
									continue;
								}
								goto case 2;
							case 2:
							case 5:
								cvsDisplayableLine = graphic as CvsDisplayableLine;
								num3 = 4;
								continue;
							case 1:
								midLineToolType.Center = new PointF((UkIZfuKAjxxA3m39rkZp(ViKe4HKA3Ec5tXma1i4M(cvsDisplayableLine)).X + ((CvsGraphicLine)ViKe4HKA3Ec5tXma1i4M(cvsDisplayableLine)).EndPoint.X) / 2f, (UkIZfuKAjxxA3m39rkZp(cvsDisplayableLine.Line).Y + juXP4SKA620hY1mWnS77(ViKe4HKA3Ec5tXma1i4M(cvsDisplayableLine)).Y) / 2f);
								goto end_IL_0024;
							case 6:
								goto IL_0206;
							default:
								num3 = 14;
								continue;
							case 16:
								midLineToolType.Center = PointF.Empty;
								goto end_IL_0024;
							}
							break;
						}
						goto IL_0096;
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
				default:
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 5;
					if (jWCmHAKAXSP7gubMxqeY())
					{
						continue;
					}
					break;
				case 1:
					break;
				case 5:
					midLineToolType = _003C_003E4__this;
					goto case 2;
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
		internal static object yGgF71KA4H0DaPOvy4LN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter mVdnxrKA7a3YLYMKm7tp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ViKe4HKA3Ec5tXma1i4M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableLine)P_0).Line;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF UkIZfuKAjxxA3m39rkZp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).StartPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF juXP4SKA620hY1mWnS77(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).EndPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jWCmHAKAXSP7gubMxqeY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qgEmjvKA9mwNygqY4Eu8()
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

		public MidLineToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private MidLineTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EzTool result = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			MidLineToolType midLineToolType = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (!guid.Equals(RByQRMfPxS))
							{
								throw new NotImplementedException();
							}
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							pn0gewKACaMpg2ExAuSG();
							if (!zr9c0XKAAmhk7pp9Bi8f())
							{
								num3 = 8;
								if (false)
								{
									goto IL_0105;
								}
							}
							else
							{
								num3 = 0;
							}
						}
						goto IL_009a;
						IL_009a:
						while (true)
						{
							switch (num3)
							{
							case 6:
							case 8:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 4:
								return;
							case 11:
								break;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									if (pn0gewKACaMpg2ExAuSG())
									{
										continue;
									}
									goto case 0;
								}
								goto case 3;
							case 0:
							case 9:
								result = _003Ctool_003E5__2;
								num3 = 12;
								continue;
							case 1:
								_003Ctool_003E5__2 = new MidLineTool((InspectStepViewModel)ePrQf7KAR3WQusi9tENQ(midLineToolType), isInitialized: true);
								awaiter = ((Task)m689hlKAWOtU06ikSD8s(_003Ctool_003E5__2, cells, cellRange)).GetAwaiter();
								num3 = 2;
								continue;
							case 3:
								awaiter.GetResult();
								goto case 0;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 12:
								goto end_IL_009a;
							}
							goto IL_0105;
							continue;
							end_IL_009a:
							break;
						}
						goto end_IL_003f;
						IL_0105:
						num2 = (_003C_003E1__state = 0);
						num3 = 10;
						goto IL_009a;
						end_IL_003f:;
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
					break;
				case 6:
					return;
				}
				do
				{
					midLineToolType = _003C_003E4__this;
					pn0gewKACaMpg2ExAuSG();
					if (zr9c0XKAAmhk7pp9Bi8f())
					{
						num = 5;
						continue;
					}
					num = 0;
					break;
				}
				while (false);
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
		internal static object ePrQf7KAR3WQusi9tENQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object m689hlKAWOtU06ikSD8s(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pn0gewKACaMpg2ExAuSG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zr9c0XKAAmhk7pp9Bi8f()
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

		public MidLineToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			l6R3mnKAySau7DvZkQ7n();
			int num = ((!fC6Zx9KATDcflhYLukCT()) ? 4 : 3);
			int num2 = default;
			MidLineToolType midLineToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					midLineToolType = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							midLineToolType.TIeQC8uDmk = null;
							num3 = 11;
							if (l6R3mnKAySau7DvZkQ7n())
							{
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 11:
								midLineToolType.QfjQOlHnZP = null;
								num3 = 4;
								if (true)
								{
									continue;
								}
								return;
							case 1:
								return;
							case 8:
								return;
							case 2:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 3;
							default:
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								awaiter = EakjQMKA0YaF9Qat6Px7(midLineToolType.JYfQc7hCWE());
								num3 = 6;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 9:
								midLineToolType.dqPQylbR7h = midLineToolType.VtoQEr1dIu().ToArray();
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								midLineToolType.Center = PointF.Empty;
								num3 = 9;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								num3 = ((!fC6Zx9KATDcflhYLukCT()) ? 1 : 2);
								continue;
							case 12:
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
		internal static TaskAwaiter EakjQMKA0YaF9Qat6Px7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fC6Zx9KATDcflhYLukCT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l6R3mnKAySau7DvZkQ7n()
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

		public MidLineToolType _003C_003E4__this;

		private string _003Cexpr0_003E5__2;

		private string _003Cexpr1_003E5__3;

		private CvsCogSocketSheet _003Csheet_003E5__4;

		private CvsCellRange _003CpasteRange_003E5__5;

		private TaskAwaiter<string> _003C_003Eu__1;

		private object _003C_003E7__wrap5;

		private MidLineTool _003Ctool_003E5__7;

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
			MidLineToolType midLineToolType = default;
			TaskAwaiter<CvsCellCollection> awaiter3 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<CvsCellRange> awaiter5 = default;
			TaskAwaiter<object> awaiter4 = default;
			CvsCellRange result3 = default;
			CvsCellCollection result4 = default;
			EzTool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 8:
					num2 = _003C_003E1__state;
					num = 2;
					break;
				case 1:
					_003Cexpr0_003E5__2 = null;
					goto default;
				default:
					FYG4RnKAFjJj63E637Zg();
					num = (icIGKXKAMvewEL0PEjek() ? 7 : 3);
					break;
				case 2:
					midLineToolType = _003C_003E4__this;
					num = 6;
					break;
				case 6:
					try
					{
						TaskAwaiter<string> awaiter2;
						string result2;
						int num3;
						switch (num2)
						{
						default:
							VCtgK2KAYR9BNgeuX57H(midLineToolType.TIeQC8uDmk);
							awaiter2 = midLineToolType.rQbQbNURVf(midLineToolType.TIeQC8uDmk).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0134;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0134;
						case 1:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01af;
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
									num4 = 35;
									goto IL_0474;
								case 2:
									awaiter3 = _003C_003Eu__2;
									num4 = 30;
									if (1 == 0)
									{
										goto IL_02ac;
									}
									goto IL_0474;
								case 8:
									awaiter = _003C_003Eu__5;
									num4 = 14;
									goto IL_0474;
								case 3:
									awaiter5 = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num4 = 44;
									goto IL_0474;
								case 6:
									awaiter4 = _003C_003Eu__4;
									num4 = 1;
									goto IL_0474;
								case 5:
									awaiter4 = _003C_003Eu__4;
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									num4 = 19;
									goto IL_0474;
								case 4:
									awaiter4 = _003C_003Eu__4;
									num4 = 24;
									if (FYG4RnKAFjJj63E637Zg())
									{
										goto IL_0474;
									}
									goto IL_0819;
								case 7:
									{
										awaiter3 = _003C_003Eu__2;
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 10;
										goto IL_0474;
									}
									IL_0474:
									while (true)
									{
										switch (num4)
										{
										case 2:
										case 16:
											num2 = (_003C_003E1__state = 2);
											num4 = 39;
											if (!icIGKXKAMvewEL0PEjek())
											{
												continue;
											}
											goto case 29;
										case 29:
											result3 = awaiter5.GetResult();
											num4 = 6;
											continue;
										case 32:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num4 = 21;
											continue;
										case 25:
											_003C_003Eu__4 = awaiter4;
											num4 = 13;
											if (!icIGKXKAMvewEL0PEjek())
											{
												continue;
											}
											goto case 7;
										case 7:
											num2 = (_003C_003E1__state = 5);
											num4 = 33;
											continue;
										case 34:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 22:
											break;
										case 3:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
											return;
										case 12:
											return;
										case 47:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											return;
										case 18:
											if (!awaiter3.IsCompleted)
											{
												num2 = (_003C_003E1__state = 7);
												_003C_003Eu__2 = awaiter3;
												num4 = 32;
												if (0 == 0)
												{
													continue;
												}
												goto case 39;
											}
											goto case 10;
										case 39:
											_003C_003Eu__2 = awaiter3;
											num4 = 34;
											continue;
										case 38:
											awaiter4 = _003Csheet_003E5__4.PutCellExpressionAsync(midLineToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, midLineToolType.NNcQW3axjV), _003Cexpr1_003E5__3).GetAwaiter();
											num4 = 26;
											if (true)
											{
												continue;
											}
											goto case 10;
										case 10:
										{
											CvsCellCollection result5 = awaiter3.GetResult();
											_003Ctool_003E5__7 = new MidLineTool((InspectStepViewModel)IUl3TeKAUIUa7Y93nup9(midLineToolType), isInitialized: false);
											awaiter = rVAML2KA2idR0IVPMY9E(A6tyKMKAN2wZWPBq63aC(_003Ctool_003E5__7, result5, _003CpasteRange_003E5__5));
											num4 = 8;
											continue;
										}
										case 30:
											_003C_003Eu__2 = default;
											num4 = 43;
											if (0 == 0)
											{
												continue;
											}
											goto case 17;
										case 17:
											num2 = (_003C_003E1__state = -1);
											num4 = 31;
											continue;
										case 5:
											_003C_003Eu__3 = awaiter5;
											num4 = 3;
											if (!icIGKXKAMvewEL0PEjek())
											{
												continue;
											}
											goto case 8;
										case 8:
											if (!awaiter.IsCompleted)
											{
												num2 = (_003C_003E1__state = 8);
												num4 = 9;
												if (FYG4RnKAFjJj63E637Zg())
												{
													continue;
												}
												goto case 9;
											}
											goto IL_0819;
										case 9:
											_003C_003Eu__5 = awaiter;
											num4 = 47;
											continue;
										case 37:
											awaiter4 = _003Csheet_003E5__4.PutCellExpressionAsync(midLineToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, midLineToolType.xNlQTmqVm6), _003Cexpr0_003E5__2).GetAwaiter();
											goto case 40;
										default:
											num4 = 40;
											continue;
										case 33:
											_003C_003Eu__4 = awaiter4;
											num4 = 15;
											if (FYG4RnKAFjJj63E637Zg())
											{
												continue;
											}
											goto case 0;
										case 0:
											awaiter5 = midLineToolType.RenameAndPasteTool(midLineToolType._pasteObject, result4, runSheet: false).GetAwaiter();
											num4 = 46;
											continue;
										case 44:
											num2 = (_003C_003E1__state = -1);
											num4 = 29;
											continue;
										case 43:
											num2 = (_003C_003E1__state = -1);
											goto IL_059b;
										case 26:
											if (!awaiter4.IsCompleted)
											{
												num2 = (_003C_003E1__state = 6);
												num4 = 11;
												if (true)
												{
													continue;
												}
												goto case 36;
											}
											goto IL_0614;
										case 36:
											if (awaiter3.IsCompleted)
											{
												goto IL_059b;
											}
											goto IL_05db;
										case 14:
											_003C_003Eu__5 = default;
											num4 = 17;
											continue;
										case 28:
											num2 = (_003C_003E1__state = -1);
											goto IL_0614;
										case 40:
											if (!awaiter4.IsCompleted)
											{
												num4 = 7;
												if (FYG4RnKAFjJj63E637Zg())
												{
													continue;
												}
												goto case 35;
											}
											goto case 19;
										case 35:
											awaiter3 = ((CvsCogSocketSheet)hGW3AyKAmDtTcKt0pOmK(((CvsInSight)JNIkRMKAHdmoPrUe3j0T(IUl3TeKAUIUa7Y93nup9(midLineToolType))).CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
											num4 = 36;
											continue;
										case 45:
											return;
										case 24:
											_003C_003Eu__4 = default;
											num2 = (_003C_003E1__state = -1);
											goto IL_06a6;
										case 1:
											_003C_003Eu__4 = default;
											num4 = 28;
											continue;
										case 11:
											_003C_003Eu__4 = awaiter4;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											num4 = 20;
											continue;
										case 20:
											return;
										case 6:
											_003CpasteRange_003E5__5 = result3;
											num4 = 27;
											continue;
										case 27:
											awaiter4 = _003Csheet_003E5__4.PutCellExpressionAsync(midLineToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, midLineToolType.mjjQlc6xwu), (string)aWCFtMKAQgpqvCA8dVTt(midLineToolType.InputImageLinks[midLineToolType.InputImageIndex])).GetAwaiter();
											num4 = 4;
											continue;
										case 15:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											num4 = 23;
											continue;
										case 4:
											if (!awaiter4.IsCompleted)
											{
												num2 = (_003C_003E1__state = 4);
												num4 = 25;
												if (icIGKXKAMvewEL0PEjek())
												{
												}
												continue;
											}
											goto IL_06a6;
										case 23:
											return;
										case 42:
											awaiter3 = _003Csheet_003E5__4.RunAndGetCellResults().GetAwaiter();
											num4 = 18;
											continue;
										case 19:
											awaiter4.GetResult();
											num4 = 38;
											continue;
										case 41:
											return;
										case 31:
											goto IL_0819;
										case 46:
											if (!awaiter5.IsCompleted)
											{
												num2 = (_003C_003E1__state = 3);
												num4 = 5;
												continue;
											}
											goto case 29;
										case 13:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											num4 = 41;
											if (0 == 0)
											{
												continue;
											}
											return;
										case 21:
											return;
										case 48:
											{
												result = _003Ctool_003E5__7;
												goto end_IL_01eb;
											}
											IL_06a6:
											awaiter4.GetResult();
											num4 = 37;
											continue;
											IL_0614:
											awaiter4.GetResult();
											num4 = 42;
											continue;
											IL_059b:
											result4 = awaiter3.GetResult();
											num4 = 22;
											continue;
										}
										break;
										IL_05db:
										FYG4RnKAFjJj63E637Zg();
										num4 = ((!icIGKXKAMvewEL0PEjek()) ? 16 : 45);
									}
									goto IL_02ac;
									IL_0819:
									awaiter.GetResult();
									num4 = 48;
									goto IL_0474;
									IL_02ac:
									_003CpasteRange_003E5__5 = CvsCellRange.Empty;
									num4 = 0;
									goto IL_0474;
									end_IL_01eb:
									break;
								}
							}
							catch (object obj)
							{
								_003C_003E7__wrap5 = obj;
								num3 = 1;
								goto IL_08ad;
							}
							goto end_IL_009a;
						case 9:
							{
								awaiter = _003C_003Eu__5;
								_003C_003Eu__5 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0916;
							}
							IL_08ad:
							if (num3 != 1)
							{
								break;
							}
							awaiter = midLineToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__5).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__5 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0916;
							IL_0134:
							result2 = awaiter2.GetResult();
							_003Cexpr0_003E5__2 = result2;
							VCtgK2KAYR9BNgeuX57H(midLineToolType.QfjQOlHnZP);
							awaiter2 = midLineToolType.rQbQbNURVf(midLineToolType.QfjQOlHnZP).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01af;
							IL_0916:
							awaiter.GetResult();
							((ExceptionDispatchInfo)Fs8iJNKAcKaBmPbNA4Hf((_003C_003E7__wrap5 as Exception) ?? throw _003C_003E7__wrap5)).Throw();
							break;
							IL_01af:
							result2 = awaiter2.GetResult();
							_003Cexpr1_003E5__3 = result2;
							_003Csheet_003E5__4 = (CvsCogSocketSheet)hGW3AyKAmDtTcKt0pOmK(PnNpv7KAxMQ0TvGDgtLT(JNIkRMKAHdmoPrUe3j0T(IUl3TeKAUIUa7Y93nup9(midLineToolType))));
							_003CpasteRange_003E5__5 = CvsCellRange.Empty;
							num3 = 0;
							goto case 2;
						}
						_003C_003E7__wrap5 = null;
						_003Cexpr0_003E5__2 = null;
						_003Cexpr1_003E5__3 = null;
						_003Csheet_003E5__4 = null;
						_003CpasteRange_003E5__5 = default;
						end_IL_009a:;
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
					num = 1;
					break;
				case 5:
				case 7:
					_003Csheet_003E5__4 = null;
					num = 0;
					break;
				case 3:
				case 4:
					_003Cexpr1_003E5__3 = null;
					goto case 5;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 9;
					if (icIGKXKAMvewEL0PEjek())
					{
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
		internal static bool VCtgK2KAYR9BNgeuX57H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DistanceToolType.GsblGSpy7C((CvsEditableDisplayGraphic)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IUl3TeKAUIUa7Y93nup9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JNIkRMKAHdmoPrUe3j0T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PnNpv7KAxMQ0TvGDgtLT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hGW3AyKAmDtTcKt0pOmK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aWCFtMKAQgpqvCA8dVTt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A6tyKMKAN2wZWPBq63aC(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rVAML2KA2idR0IVPMY9E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fs8iJNKAcKaBmPbNA4Hf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FYG4RnKAFjJj63E637Zg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool icIGKXKAMvewEL0PEjek()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<EzToolType, bool> _003C_003E9__42_0;

		public static Func<CellViewModel, bool> _003C_003E9__43_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fIdw3MKAhYawZE5mq2cP();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fIdw3MKAhYawZE5mq2cP();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_FindEdgeToolType_003Eb__42_0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s88Wi5KAzlULTeZmhNvf(QftO5tKAt7wSIkKrfPVP(t), Resources.Kb8tdpAgrR());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetGraphicExpression_003Eb__43_0(CellViewModel p)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return p.DataType == CellType.Line;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fIdw3MKAhYawZE5mq2cP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k0qFHpKA1vTVjytUHBtf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D1xpNBKAu6ATDO1V7AZ3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QftO5tKAt7wSIkKrfPVP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).ToolType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s88Wi5KAzlULTeZmhNvf(object P_0, object P_1)
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

		public MidLineToolType _003C_003E4__this;

		private CvsDisplayableLine _003Cline_003E5__2;

		private FindEdgeToolType _003CfindLineToolType_003E5__3;

		private EzTool _003Ctool_003E5__4;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<EzTool> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			int num2 = default;
			string text = default;
			TaskAwaiter<EzTool> awaiter2 = default;
			TaskAwaiter awaiter = default;
			CvsCellLocation cvsCellLocation = default;
			MidLineToolType midLineToolType = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003Cline_003E5__2 = null;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							text = (string)KMpd3dKR5U6Hc0g5RmIT(1838);
							num3 = 3;
							goto IL_02c5;
						case 1:
							awaiter2 = _003C_003Eu__2;
							wfiJhQKRK6MrIEOHiXe3();
							if (NsbqdbKRL4c5sp94JCgf())
							{
								num3 = 10;
							}
							else
							{
								num3 = 15;
								if (1 == 0)
								{
									goto IL_01d6;
								}
							}
							goto IL_02c5;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 29;
							goto IL_02c5;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								num3 = 11;
								goto IL_02c5;
							}
							IL_02c5:
							while (true)
							{
								switch (num3)
								{
								case 0:
									text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
									num3 = 12;
									if (NsbqdbKRL4c5sp94JCgf())
									{
										continue;
									}
									goto case 13;
								case 13:
									XydwCqKRJGA5DDqGudc3(_003CfindLineToolType_003E5__3);
									num3 = 7;
									if (true)
									{
										continue;
									}
									return;
								case 25:
									return;
								case 6:
									text = _003Ctool_003E5__4.AllProperties.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel p) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return p.DataType == CellType.Line;
									}).RefExpression;
									num3 = 14;
									if (NsbqdbKRL4c5sp94JCgf())
									{
										continue;
									}
									goto case 9;
								case 9:
									_003C_003Eu__1 = awaiter;
									num3 = 21;
									continue;
								case 26:
									cvsCellLocation = rvNjKkKRwKPB8BfhBL1C(editableGraphic);
									num3 = 22;
									continue;
								case 3:
									_003Cline_003E5__2 = editableGraphic as CvsDisplayableLine;
									if (_003Cline_003E5__2 != null)
									{
										num3 = 26;
										continue;
									}
									goto case 12;
								case 20:
									num2 = (_003C_003E1__state = 2);
									num3 = 1;
									continue;
								case 11:
									_003C_003Eu__1 = default;
									num3 = 17;
									if (0 == 0)
									{
										continue;
									}
									goto case 28;
								case 28:
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									if (NsbqdbKRL4c5sp94JCgf())
									{
										continue;
									}
									goto case 8;
								case 8:
								{
									EzTool result2 = awaiter2.GetResult();
									_003Ctool_003E5__4 = result2;
									goto case 15;
								}
								case 5:
									break;
								case 21:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 7:
									awaiter = ((Task)sQ3ifNKReYca9uGsIqGV(_003CfindLineToolType_003E5__3, HdpHbmKRa4kG5ITAENpH(midLineToolType))).GetAwaiter();
									num3 = 24;
									if (0 == 0)
									{
										continue;
									}
									goto case 24;
								case 24:
									if (!awaiter.IsCompleted)
									{
										num3 = 28;
										continue;
									}
									goto case 29;
								case 1:
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									if (wfiJhQKRK6MrIEOHiXe3())
									{
									}
									continue;
								case 22:
									if (!cvsCellLocation.IsValid)
									{
										_003CfindLineToolType_003E5__3 = midLineToolType.xDTQgM1Yup();
										if (_003CfindLineToolType_003E5__3 != null)
										{
											num3 = 13;
											if (true)
											{
												continue;
											}
											goto case 26;
										}
										goto IL_0380;
									}
									num3 = 0;
									continue;
								case 27:
									return;
								case 2:
									_003C_003Eu__2 = awaiter2;
									break;
								default:
									num3 = 5;
									continue;
								case 19:
									awaiter.GetResult();
									num3 = 6;
									continue;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 27;
									continue;
								case 14:
									_003Ctool_003E5__4 = null;
									goto IL_0380;
								case 29:
									awaiter.GetResult();
									awaiter2 = _003CfindLineToolType_003E5__3.YBE4tPvMRf(_003Cline_003E5__2).GetAwaiter();
									num3 = 23;
									continue;
								case 15:
								case 18:
									awaiter = RgaHcdKRO2YuuVyw1gVm(midLineToolType.s1Ou7UoL9J(_003Ctool_003E5__4));
									if (!awaiter.IsCompleted)
									{
										num3 = 20;
										continue;
									}
									goto case 19;
								case 23:
									if (awaiter2.IsCompleted)
									{
										goto case 8;
									}
									num2 = (_003C_003E1__state = 1);
									num3 = 2;
									if (NsbqdbKRL4c5sp94JCgf())
									{
										continue;
									}
									goto case 17;
								case 17:
									num2 = (_003C_003E1__state = -1);
									num3 = 19;
									continue;
								case 10:
								case 16:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 8;
									continue;
								case 12:
								case 30:
									{
										result = text;
										goto end_IL_02c5;
									}
									IL_0380:
									_003CfindLineToolType_003E5__3 = null;
									num3 = 30;
									continue;
								}
								goto IL_01d6;
								continue;
								end_IL_02c5:
								break;
							}
							break;
							IL_01d6:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num3 = 25;
							goto IL_02c5;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cline_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					if (NsbqdbKRL4c5sp94JCgf())
					{
						continue;
					}
					goto case 6;
				case 6:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					midLineToolType = _003C_003E4__this;
					_ = 0;
					if (!NsbqdbKRL4c5sp94JCgf())
					{
						num = 3;
						if (true)
						{
							continue;
						}
						goto case 2;
					}
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
				case 4:
					break;
				case 7:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 7;
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
		internal static object KMpd3dKR5U6Hc0g5RmIT(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation rvNjKkKRwKPB8BfhBL1C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XydwCqKRJGA5DDqGudc3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzToolType)P_0).RefreshInputImageLinks();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int HdpHbmKRa4kG5ITAENpH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sQ3ifNKReYca9uGsIqGV(object P_0, int value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).SetInputImageIndexAsync(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter RgaHcdKRO2YuuVyw1gVm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NsbqdbKRL4c5sp94JCgf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wfiJhQKRK6MrIEOHiXe3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid RByQRMfPxS;

	private static readonly Guid[] s4ZQ4UWEbd;

	private readonly CvsCellLocation mjjQlc6xwu;

	private readonly CvsCellLocation xNlQTmqVm6;

	private readonly CvsCellLocation NNcQW3axjV;

	private FindEdgeToolType ooXQjeqITF;

	private CvsEditableDisplayGraphic TIeQC8uDmk;

	private CvsEditableDisplayGraphic QfjQOlHnZP;

	private PointF NExQHmMjBj;

	private int CoeQwxglIy;

	private CvsEditableDisplayGraphic[] dqPQylbR7h;

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NExQHmMjBj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NExQHmMjBj = value;
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
			return s4ZQ4UWEbd;
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
			return (string)IdQk58EuKcn1kXaCe6x();
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
			return (string)dWTjgEEhrVfOSxDRvpd();
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
			return XAMLGraphicKeys.Tools_AngleIcon;
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
			return XAMLGraphicKeys.Tools_AngleIcon;
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
				(string)ilhd5lEtJqPvxSL1Bem(),
				(string)UkcP0lEzntldIAimYuY()
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
			return CoeQwxglIy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref CoeQwxglIy, value, (string)gJ3fALEcXEnVKhKXtK0(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MidLineToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		while (true)
		{
			switch (num)
			{
			case 5:
				AddSnippet(_pasteObject);
				num = 11;
				continue;
			case 8:
				mjjQlc6xwu = _pasteObject.GetCellOffset((string)gJ3fALEcXEnVKhKXtK0(4928));
				goto case 1;
			case 0:
				_pasteObject = PasteBuffer.FromBytes(Snippets.MidLine);
				goto case 8;
			default:
				num = 8;
				continue;
			case 10:
				NExQHmMjBj = PointF.Empty;
				num = 7;
				continue;
			case 1:
			case 6:
				xNlQTmqVm6 = _pasteObject.GetCellOffset((string)gJ3fALEcXEnVKhKXtK0(21598));
				num = 4;
				continue;
			case 7:
				CoeQwxglIy = 1000;
				AlgNliE2dgk8pgPlNZt();
				if (!cSRin8ENq6x55C6MuTk())
				{
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				num = 2;
				continue;
			case 2:
			case 3:
				base._002Ector();
				num = 0;
				continue;
			case 4:
				NNcQW3axjV = _pasteObject.GetCellOffset((string)gJ3fALEcXEnVKhKXtK0(21622));
				num = 5;
				if (!AlgNliE2dgk8pgPlNZt())
				{
					continue;
				}
				break;
			case 9:
				break;
			case 11:
				return;
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			num = 10;
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
		int num = 0;
		_003COnGraphicChanged_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 6;
				continue;
			case 0:
				stateMachine._003C_003Et__builder = vdI6AJE1FexhCl0CN38();
				AlgNliE2dgk8pgPlNZt();
				num = ((!cSRin8ENq6x55C6MuTk()) ? 5 : 3);
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 6:
				stateMachine.e = e;
				goto case 2;
			default:
				num = 2;
				continue;
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (cSRin8ENq6x55C6MuTk())
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
	[AsyncStateMachine(typeof(_003CSetDisplayGraphics_003Ed__8))]
	public Task SetDisplayGraphics(CvsEditableDisplayGraphic graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (AlgNliE2dgk8pgPlNZt() ? 3 : 6);
		_003CSetDisplayGraphics_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				break;
			case 4:
				stateMachine.graphic = graphic;
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (cSRin8ENq6x55C6MuTk())
				{
					break;
				}
				goto case 0;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = vdI6AJE1FexhCl0CN38();
				goto case 1;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
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
		AlgNliE2dgk8pgPlNZt();
		int num = ((!cSRin8ENq6x55C6MuTk()) ? 4 : 5);
		_003COnBeginAddInternal_003Ed__34 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = vdI6AJE1FexhCl0CN38();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
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
		int num = 5;
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic[] source = default;
		while (true)
		{
			CvsEditableDisplayGraphic[] array;
			switch (num)
			{
			case 0:
			case 1:
				array = Array.Empty<CvsEditableDisplayGraphic>();
				goto IL_001d;
			case 5:
				array = dqPQylbR7h;
				if (array == null)
				{
					AlgNliE2dgk8pgPlNZt();
					num = ((!cSRin8ENq6x55C6MuTk()) ? 3 : 0);
					break;
				}
				goto IL_001d;
			case 4:
				dqPQylbR7h = (CvsEditableDisplayGraphic[])pJmEtmpL8pQC4gq6R4F(list);
				num = 6;
				break;
			case 2:
			case 3:
				FireAddGraphicsChanged(source.ToList(), list);
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return;
				IL_001d:
				source = array;
				list = VtoQEr1dIu();
				goto case 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<CvsEditableDisplayGraphic> VtoQEr1dIu()
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
			if (xDTQgM1Yup() != null && xDTQgM1Yup().IsTypeEnabled)
			{
				FeatureExtractor featureExtractor = new FeatureExtractor();
				if (xDTQgM1Yup() != null)
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
		return dqPQylbR7h;
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
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cells.GetSnippetVersion(range);
		SnippetPasteBuffer.GetSnippetVersion(_pasteObject);
		return new List<ISnippetUpdate>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private FindEdgeToolType xDTQgM1Yup()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ooXQjeqITF == null)
		{
			ooXQjeqITF = Inspect.ToolTypes.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType t) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec.s88Wi5KAzlULTeZmhNvf(_003C_003Ec.QftO5tKAt7wSIkKrfPVP(t), Resources.Kb8tdpAgrR());
			}) as FindEdgeToolType;
		}
		return ooXQjeqITF;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGraphicExpression_003Ed__43))]
	private Task<string> rQbQbNURVf(CvsEditableDisplayGraphic P_0)
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
	static MidLineToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AlgNliE2dgk8pgPlNZt();
		int num = ((!cSRin8ENq6x55C6MuTk()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			default:
				s4ZQ4UWEbd = new Guid[1] { RByQRMfPxS };
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 0:
			case 3:
				break;
			case 1:
				RByQRMfPxS = new Guid((string)gJ3fALEcXEnVKhKXtK0(21674));
				goto default;
			case 5:
				return;
			}
			xW5cFspKs3PskceqJmC();
			num = 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task JYfQc7hCWE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gJ3fALEcXEnVKhKXtK0(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cSRin8ENq6x55C6MuTk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AlgNliE2dgk8pgPlNZt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder vdI6AJE1FexhCl0CN38()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IdQk58EuKcn1kXaCe6x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.qbgVPEvYaf();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dWTjgEEhrVfOSxDRvpd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ToMVKym0ul();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ilhd5lEtJqPvxSL1Bem()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UkcP0lEzntldIAimYuY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ttHtskjScM();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pJmEtmpL8pQC4gq6R4F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xW5cFspKs3PskceqJmC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
