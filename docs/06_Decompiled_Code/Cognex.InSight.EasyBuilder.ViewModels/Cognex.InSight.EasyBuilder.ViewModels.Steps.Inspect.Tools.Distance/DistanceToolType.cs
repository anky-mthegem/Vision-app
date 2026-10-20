using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
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
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance.DistanceUpdates;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindCircle;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindEdge;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using oF2MOjpuTE9ryB96aX;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance;

[Export(typeof(EzToolType))]
public class DistanceToolType : EzToolType, IGraphicToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnGraphicChanged_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DistanceToolType _003C_003E4__this;

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
			int num = ((!EmyQTAKHnIwlHXvpxfAP()) ? 2 : 4);
			int num2 = default;
			DistanceToolType distanceToolType = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					distanceToolType = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = X7GZSNKHfwTBmVga7l25(distanceToolType.SetDisplayGraphics(e.Value as CvsEditableDisplayGraphic));
							num3 = 4;
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
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								goto case 6;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 8:
								return;
							case 4:
								if (!awaiter.IsCompleted)
								{
									EmyQTAKHnIwlHXvpxfAP();
									num3 = ((!sxh1X1KHVrnwVJbA0w9U()) ? 5 : 7);
									continue;
								}
								break;
							case 1:
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
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
		internal static TaskAwaiter X7GZSNKHfwTBmVga7l25(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EmyQTAKHnIwlHXvpxfAP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sxh1X1KHVrnwVJbA0w9U()
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
	private struct _003CSetDisplayGraphics_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsEditableDisplayGraphic graphic;

		public DistanceToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uRkHvIKHdEhcOr4x37BY();
			int num;
			if (!k1AHf6KHl7f04HVqo4pk())
			{
				num = 3;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_006d;
				}
			}
			goto IL_03f1;
			IL_0028:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_03f1;
			IL_006d:
			int num2 = default;
			DistanceToolType distanceToolType = default;
			try
			{
				int num3;
				if (num2 != 0)
				{
					if (graphic != null)
					{
						num3 = 19;
					}
					else
					{
						distanceToolType.H9KTXltpFd = null;
						num3 = 22;
					}
					goto IL_02a7;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_0308;
				IL_02a7:
				CvsDisplayableLine cvsDisplayableLine = default;
				CvsDisplayableCross cvsDisplayableCross = default;
				CvsDisplayablePoint cvsDisplayablePoint = default;
				CvsDisplayableCircle cvsDisplayableCircle = default;
				while (true)
				{
					switch (num3)
					{
					case 6:
						awaiter = YA4RG4KHseQxhLDdQucU(yqTENvKHguhl1888UagY(distanceToolType.AcceptAddCommand));
						num3 = 20;
						continue;
					case 9:
						goto end_IL_02a7;
					case 8:
						distanceToolType.H9KTXltpFd = graphic;
						num3 = 17;
						if (true)
						{
							continue;
						}
						goto case 2;
					case 2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 21;
						continue;
					case 3:
					case 10:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0111;
					case 16:
						distanceToolType.Center = new PointF((w5flLgKHGeYLIPudxlDt(ilDBaKKHbJaDvtxEXaAB(cvsDisplayableLine)).X + SiwpNQKHoHaUKMdYiR7n(cvsDisplayableLine.Line).X) / 2f, (((CvsGraphicLine)ilDBaKKHbJaDvtxEXaAB(cvsDisplayableLine)).StartPoint.Y + SiwpNQKHoHaUKMdYiR7n(ilDBaKKHbJaDvtxEXaAB(cvsDisplayableLine)).Y) / 2f);
						num3 = 5;
						continue;
					case 19:
						if (distanceToolType.H9KTXltpFd == null)
						{
							num3 = 8;
							if (!k1AHf6KHl7f04HVqo4pk())
							{
								continue;
							}
						}
						else if (distanceToolType.H9KTXltpFd != graphic)
						{
							distanceToolType.XjbTo37kdL = graphic;
							num3 = 1;
							continue;
						}
						goto case 15;
					case 12:
						distanceToolType.Center = eyncbPKHBYUiOBxPuRYx(G3CbB6KHZVs63WCNcMsu(cvsDisplayableCross));
						goto end_IL_02a7;
					case 4:
						_003C_003Eu__1 = awaiter;
						num3 = 2;
						if (uRkHvIKHdEhcOr4x37BY())
						{
							continue;
						}
						goto case 7;
					case 7:
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						continue;
					case 5:
						goto end_IL_02a7;
					case 11:
						if (cvsDisplayablePoint != null)
						{
							distanceToolType.Center = Y49sRpKHr6vgxH1ljFv4(DjTClNKHvQ3QiYMPluUK(cvsDisplayablePoint));
							goto end_IL_02a7;
						}
						cvsDisplayableCircle = graphic as CvsDisplayableCircle;
						goto case 13;
					case 21:
						return;
					case 1:
						distanceToolType.Center = PointF.Empty;
						num3 = 6;
						continue;
					case 0:
						if (cvsDisplayableLine != null)
						{
							num3 = 16;
							if (0 == 0)
							{
								continue;
							}
							goto case 15;
						}
						goto end_IL_02a7;
					case 15:
					case 17:
						cvsDisplayablePoint = graphic as CvsDisplayablePoint;
						num3 = 11;
						continue;
					case 18:
						distanceToolType.Center = ((CvsGraphicCircle)A7SyJdKHPqkhuKRiTH8R(cvsDisplayableCircle)).Center;
						num3 = 9;
						if (0 == 0)
						{
							continue;
						}
						goto case 20;
					case 20:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							continue;
						}
						goto IL_0111;
					case 13:
					case 14:
						if (cvsDisplayableCircle == null)
						{
							cvsDisplayableCross = graphic as CvsDisplayableCross;
							if (cvsDisplayableCross != null)
							{
								num3 = 12;
								if (uRkHvIKHdEhcOr4x37BY())
								{
									continue;
								}
								goto case 8;
							}
							cvsDisplayableLine = graphic as CvsDisplayableLine;
							num3 = 0;
							continue;
						}
						num3 = 18;
						if (uRkHvIKHdEhcOr4x37BY())
						{
							continue;
						}
						goto case 22;
					case 22:
						{
							distanceToolType.Center = PointF.Empty;
							goto end_IL_02a7;
						}
						IL_0111:
						awaiter.GetResult();
						num3 = 15;
						continue;
					}
					goto IL_0308;
					continue;
					end_IL_02a7:
					break;
				}
				goto end_IL_006d;
				IL_0308:
				k1AHf6KHl7f04HVqo4pk();
				if (!uRkHvIKHdEhcOr4x37BY())
				{
					num3 = 14;
					if (false)
					{
						return;
					}
				}
				else
				{
					num3 = 3;
				}
				goto IL_02a7;
				end_IL_006d:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0028;
			IL_03f1:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					if (uRkHvIKHdEhcOr4x37BY())
					{
						continue;
					}
					goto case 4;
				case 4:
					distanceToolType = _003C_003E4__this;
					goto IL_006d;
				case 2:
				case 5:
					goto IL_006d;
				default:
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0028;
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
		internal static object yqTENvKHguhl1888UagY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YA4RG4KHseQxhLDdQucU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DjTClNKHvQ3QiYMPluUK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayablePoint)P_0).PointGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF Y49sRpKHr6vgxH1ljFv4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicPoint)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A7SyJdKHPqkhuKRiTH8R(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableCircle)P_0).CircleGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G3CbB6KHZVs63WCNcMsu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableCross)P_0).CrossGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF eyncbPKHBYUiOBxPuRYx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicCross)P_0).Center;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ilDBaKKHbJaDvtxEXaAB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableLine)P_0).Line;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF w5flLgKHGeYLIPudxlDt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).StartPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF SiwpNQKHoHaUKMdYiR7n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).EndPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uRkHvIKHdEhcOr4x37BY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k1AHf6KHl7f04HVqo4pk()
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
	private struct _003CCreateTool_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public Guid guid;

		public DistanceToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private PointToPointDistanceTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private PointToLineDistanceTool _003Ctool_003E5__3;

		private LineToLineDistanceTool _003Ctool_003E5__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Hoaao3KHSjDN58aMMutL();
			int num = ((!yioa6dKHkgvEYxjvn2tA()) ? 1 : 2);
			int num2 = default;
			DistanceToolType distanceToolType = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (guid.Equals(FUClVDrnVT))
							{
								num3 = 24;
							}
							else if (guid.Equals(aXslLUj9s1))
							{
								_003Ctool_003E5__3 = new PointToLineDistanceTool((InspectStepViewModel)mVrcwDKH8TLDb38HhGCl(distanceToolType), isInitialized: true);
								num3 = 4;
							}
							else
							{
								if (!guid.Equals(z43lJJQFNn))
								{
									throw new ArgumentException();
								}
								num3 = 10;
							}
							goto IL_0335;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 23;
							goto IL_0335;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 1;
							if (1 == 0)
							{
								return;
							}
							goto IL_0335;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								num3 = 9;
								goto IL_0335;
							}
							IL_0335:
							while (true)
							{
								switch (num3)
								{
								case 19:
									return;
								case 8:
									result = _003Ctool_003E5__2;
									num3 = 13;
									if (Hoaao3KHSjDN58aMMutL())
									{
										continue;
									}
									goto case 20;
								case 20:
									_003C_003Eu__1 = awaiter;
									num3 = 14;
									continue;
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 5;
									continue;
								case 15:
								case 25:
									result = _003Ctool_003E5__4;
									num3 = 28;
									if (yioa6dKHkgvEYxjvn2tA())
									{
									}
									continue;
								case 0:
									awaiter.GetResult();
									result = _003Ctool_003E5__3;
									num3 = 16;
									if (!yioa6dKHkgvEYxjvn2tA())
									{
										continue;
									}
									goto case 11;
								case 11:
									if (!awaiter.IsCompleted)
									{
										num3 = 12;
										continue;
									}
									goto case 0;
								case 13:
									break;
								case 16:
									break;
								case 26:
									awaiter.GetResult();
									goto case 15;
								case 1:
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									if (0 == 0)
									{
										continue;
									}
									goto case 18;
								case 18:
									_003C_003Eu__1 = awaiter;
									num3 = 21;
									if (Hoaao3KHSjDN58aMMutL())
									{
										continue;
									}
									goto case 7;
								case 7:
									num2 = (_003C_003E1__state = -1);
									goto IL_01a7;
								case 9:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 26;
									if (Hoaao3KHSjDN58aMMutL())
									{
										continue;
									}
									goto case 23;
								case 23:
									_003C_003Eu__1 = default;
									num3 = 7;
									continue;
								case 4:
									awaiter = cQy8tsKHq1VHEy0Q6ZqM(_003Ctool_003E5__3.SetCellRangeAsync(cells, cellRange));
									num3 = 11;
									continue;
								case 3:
									awaiter = ((Task)V9t8D1KHEuTXnhnPQ1Oc(_003Ctool_003E5__4, cells, cellRange)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 18;
										continue;
									}
									goto case 26;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 6:
								case 22:
									return;
								case 14:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 19;
									if (0 == 0)
									{
										continue;
									}
									goto case 21;
								case 21:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									_ = 0;
									if (!Hoaao3KHSjDN58aMMutL())
									{
										num3 = 15;
										if (yioa6dKHkgvEYxjvn2tA())
										{
										}
										continue;
									}
									num3 = 6;
									if (!yioa6dKHkgvEYxjvn2tA())
									{
										continue;
									}
									goto case 27;
								case 27:
									if (awaiter.IsCompleted)
									{
										goto IL_01a7;
									}
									num3 = 17;
									if (Hoaao3KHSjDN58aMMutL())
									{
										continue;
									}
									goto case 10;
								case 10:
									_003Ctool_003E5__4 = new LineToLineDistanceTool(distanceToolType.Inspect, isInitialized: true);
									num3 = 3;
									continue;
								case 12:
									num2 = (_003C_003E1__state = 1);
									goto case 2;
								default:
									num3 = 2;
									if (true)
									{
										continue;
									}
									goto case 17;
								case 17:
									num2 = (_003C_003E1__state = 0);
									num3 = 20;
									continue;
								case 24:
									_003Ctool_003E5__2 = new PointToPointDistanceTool((InspectStepViewModel)mVrcwDKH8TLDb38HhGCl(distanceToolType), isInitialized: true);
									awaiter = cQy8tsKHq1VHEy0Q6ZqM(_003Ctool_003E5__2.SetCellRangeAsync(cells, cellRange));
									num3 = 27;
									continue;
								case 28:
									break;
									IL_01a7:
									awaiter.GetResult();
									num3 = 8;
									continue;
								}
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
					goto default;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
					break;
				case 6:
					return;
				}
				distanceToolType = _003C_003E4__this;
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
		internal static object mVrcwDKH8TLDb38HhGCl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter cQy8tsKHq1VHEy0Q6ZqM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object V9t8D1KHEuTXnhnPQ1Oc(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hoaao3KHSjDN58aMMutL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yioa6dKHkgvEYxjvn2tA()
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
	private struct _003COnBeginAddInternal_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DistanceToolType _003C_003E4__this;

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
			if (!GaIGb0KHXUxe8gu1AQyq())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (!q4Fn29KHpK4vO5axMDSS())
				{
					goto IL_0219;
				}
			}
			goto IL_01e2;
			IL_01e2:
			DistanceToolType distanceToolType = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					distanceToolType = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							distanceToolType.H9KTXltpFd = null;
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (!q4Fn29KHpK4vO5axMDSS())
							{
								goto IL_0100;
							}
						}
						goto IL_007b;
						IL_0100:
						awaiter = M1f1bSKH4FQ4Y6XTiZp5(distanceToolType.F2RlBbWTbD());
						num3 = 11;
						if (0 == 0)
						{
							goto IL_007b;
						}
						goto IL_0118;
						IL_0118:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_007b:
						while (true)
						{
							switch (num3)
							{
							case 11:
								if (!awaiter.IsCompleted)
								{
									goto case 3;
								}
								goto case 12;
							default:
								num3 = 3;
								continue;
							case 0:
								distanceToolType.XjbTo37kdL = null;
								num3 = 1;
								continue;
							case 1:
								distanceToolType.Center = PointF.Empty;
								num3 = 9;
								continue;
							case 7:
								return;
							case 10:
								return;
							case 8:
								break;
							case 2:
							case 6:
								goto IL_0118;
							case 9:
								distanceToolType.bTUT3D57Ym = (CvsEditableDisplayGraphic[])lAE9tpKH9QYTYKeqHS3n(distanceToolType.v3TlPDYNXl());
								num3 = 8;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = (q4Fn29KHpK4vO5axMDSS() ? 2 : 10);
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 12:
								awaiter.GetResult();
								goto end_IL_0046;
							}
							break;
						}
						goto IL_0100;
						end_IL_0046:;
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
				break;
			}
			goto IL_0219;
			IL_0219:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01e2;
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
		internal static object lAE9tpKH9QYTYKeqHS3n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter M1f1bSKH4FQ4Y6XTiZp5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q4Fn29KHpK4vO5axMDSS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GaIGb0KHXUxe8gu1AQyq()
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
	private struct _003CAddTool_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public DistanceToolType _003C_003E4__this;

		private string _003Cexpr0_003E5__2;

		private bool _003CisPoint0_003E5__3;

		private string _003Cexpr1_003E5__4;

		private bool _003CisPoint1_003E5__5;

		private CvsCogSocketSheet _003Csheet_003E5__6;

		private CvsCellRange _003CpasteRange_003E5__7;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		private string _003CtoolName_003E5__8;

		private PointToPointDistanceTool _003Ctool_003E5__9;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__3;

		private TaskAwaiter<object> _003C_003Eu__4;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__5;

		private TaskAwaiter<double> _003C_003Eu__6;

		private TaskAwaiter _003C_003Eu__7;

		private LineToLineDistanceTool _003Ctool_003E5__10;

		private PointToLineDistanceTool _003Ctool_003E5__11;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (baVxFCKH7BwWtDvD1gRM())
			{
				num = 8;
				if (!baVxFCKH7BwWtDvD1gRM())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 6;
			}
			goto IL_0056;
			IL_002a:
			int num2 = _003C_003E1__state;
			num = 5;
			if (1 == 0)
			{
				goto IL_003d;
			}
			goto IL_0056;
			IL_00a4:
			DistanceToolType distanceToolType = default;
			EzTool result4 = default;
			try
			{
				EzTool ezTool = default;
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<CvsCellCollection> awaiter = default;
				string result;
				CvsCellCollection result2 = default;
				switch (num2)
				{
				default:
					ezTool = null;
					_003CisPoint0_003E5__3 = y0CmhYKHjl1x8lgGbSxu(distanceToolType.H9KTXltpFd);
					awaiter2 = distanceToolType.GetGraphicExpression(distanceToolType.H9KTXltpFd).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0189;
				case 0:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_0189;
				case 1:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_020b;
				case 2:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_028b;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
					break;
					IL_020b:
					result = awaiter2.GetResult();
					_003Cexpr1_003E5__4 = result;
					awaiter = ((CvsCogSocketSheet)R1kvCKKHAqxVNvW4UvuT(H9jrafKHCXMHi4ouAwr6(((AppStepViewModel)d2chk5KH6W5C6jKKeLLK(distanceToolType)).InSight))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 2);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_028b;
					IL_0189:
					result = awaiter2.GetResult();
					_003Cexpr0_003E5__2 = result;
					_003CisPoint1_003E5__5 = y0CmhYKHjl1x8lgGbSxu(distanceToolType.XjbTo37kdL);
					awaiter2 = distanceToolType.GetGraphicExpression(distanceToolType.XjbTo37kdL).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num2 = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_020b;
					IL_028b:
					result2 = awaiter.GetResult();
					_003Csheet_003E5__6 = (CvsCogSocketSheet)R1kvCKKHAqxVNvW4UvuT(H9jrafKHCXMHi4ouAwr6(RCIeaEKHRnPvR5Ta0BCQ(d2chk5KH6W5C6jKKeLLK(distanceToolType))));
					_003CpasteRange_003E5__7 = CvsCellRange.Empty;
					break;
				}
				try
				{
					int num3;
					TaskAwaiter<object> awaiter4 = default;
					TaskAwaiter<CvsCellRange> awaiter5 = default;
					TaskAwaiter<double> awaiter7 = default;
					TaskAwaiter<CvsCogSheetResult> awaiter3 = default;
					TaskAwaiter awaiter6 = default;
					Dictionary<string, object> inputs = default;
					Dictionary<string, object> dictionary2 = default;
					(double, double) minMax2 = default;
					CvsCellCollection result5 = default;
					CvsCellCollection result9 = default;
					PasteBuffer pasteObject = default;
					CvsCellRange result6 = default;
					Dictionary<string, object> dictionary = default;
					(double, double) minMax = default;
					CvsCellCollection result3 = default;
					switch (num2)
					{
					default:
						num3 = 127;
						if (false)
						{
							goto IL_032f;
						}
						goto IL_070d;
					case 22:
						awaiter4 = _003C_003Eu__4;
						_003C_003Eu__4 = default;
						num3 = 87;
						goto IL_070d;
					case 11:
						awaiter5 = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0411;
					case 24:
						awaiter7 = _003C_003Eu__6;
						num3 = 10;
						if (1 == 0)
						{
							goto IL_04d2;
						}
						goto IL_070d;
					case 15:
						awaiter3 = _003C_003Eu__5;
						num3 = 164;
						goto IL_070d;
					case 10:
						awaiter6 = _003C_003Eu__7;
						_003C_003Eu__7 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 123;
						goto IL_070d;
					case 6:
						awaiter4 = _003C_003Eu__4;
						num3 = 30;
						if (0 == 0)
						{
							goto IL_070d;
						}
						goto IL_0a50;
					case 9:
						awaiter = _003C_003Eu__2;
						num3 = 163;
						goto IL_070d;
					case 25:
						awaiter = _003C_003Eu__2;
						num3 = 31;
						goto IL_070d;
					case 4:
						awaiter4 = _003C_003Eu__4;
						num3 = 142;
						if (0 == 0)
						{
							goto IL_070d;
						}
						goto IL_0b6d;
					case 14:
						awaiter4 = _003C_003Eu__4;
						_003C_003Eu__4 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 148;
						goto IL_070d;
					case 19:
						awaiter5 = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num3 = 51;
						if (true)
						{
							goto IL_070d;
						}
						goto IL_0e80;
					case 12:
						awaiter4 = _003C_003Eu__4;
						num3 = 113;
						goto IL_070d;
					case 18:
						awaiter6 = _003C_003Eu__7;
						num3 = 67;
						goto IL_070d;
					case 16:
						awaiter7 = _003C_003Eu__6;
						num3 = 1;
						goto IL_070d;
					case 26:
						awaiter6 = _003C_003Eu__7;
						_003C_003Eu__7 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_12b8;
					case 8:
						awaiter7 = _003C_003Eu__6;
						num3 = 47;
						goto IL_070d;
					case 13:
						awaiter4 = _003C_003Eu__4;
						_ = 0;
						num3 = (baVxFCKH7BwWtDvD1gRM() ? 35 : 83);
						goto IL_070d;
					case 21:
						awaiter4 = _003C_003Eu__4;
						num3 = 96;
						if (true)
						{
							goto IL_070d;
						}
						goto IL_15aa;
					case 17:
						awaiter = _003C_003Eu__2;
						num3 = 103;
						goto IL_070d;
					case 7:
						awaiter3 = _003C_003Eu__5;
						_003C_003Eu__5 = default;
						num3 = 98;
						goto IL_070d;
					case 3:
						awaiter5 = _003C_003Eu__3;
						num3 = 33;
						if (true)
						{
							goto IL_070d;
						}
						goto IL_1a6d;
					case 5:
						awaiter4 = _003C_003Eu__4;
						num3 = 59;
						if (baVxFCKH7BwWtDvD1gRM())
						{
							goto IL_070d;
						}
						goto IL_1b02;
					case 20:
						awaiter4 = _003C_003Eu__4;
						num3 = 139;
						goto IL_070d;
					case 23:
						{
							awaiter3 = _003C_003Eu__5;
							_003C_003Eu__5 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_1bfd;
						}
						IL_1085:
						awaiter6.GetResult();
						ezTool = _003Ctool_003E5__10;
						_003CtoolName_003E5__8 = null;
						num3 = 107;
						goto IL_070d;
						IL_04d2:
						_003C_003Eu__5 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_04e7;
						IL_070d:
						while (true)
						{
							PasteBuffer pasteObject2;
							double result8;
							double result10;
							(double, double) minMax3;
							switch (num3)
							{
							case 72:
								break;
							case 86:
								_003C_003Eu__4 = awaiter4;
								num3 = 78;
								if (toqmOcKH3PMUFCIZ6qcR())
								{
								}
								continue;
							case 71:
								_003C_003Eu__4 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num3 = 42;
								if (toqmOcKH3PMUFCIZ6qcR())
								{
								}
								continue;
							case 155:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							case 109:
								return;
							case 38:
								_003Ctool_003E5__9 = new PointToPointDistanceTool((InspectStepViewModel)d2chk5KH6W5C6jKKeLLK(distanceToolType), isInitialized: false);
								num3 = 53;
								continue;
							case 129:
								if (!awaiter4.IsCompleted)
								{
									num3 = 130;
									continue;
								}
								goto case 19;
							case 135:
								num2 = (_003C_003E1__state = 20);
								_003C_003Eu__4 = awaiter4;
								num3 = 17;
								continue;
							case 111:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 9);
									num3 = 48;
									if (!toqmOcKH3PMUFCIZ6qcR())
									{
										continue;
									}
									goto case 87;
								}
								goto case 157;
							case 87:
								num2 = (_003C_003E1__state = -1);
								num3 = 146;
								continue;
							case 92:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter7, ref this);
								return;
							case 164:
								goto IL_04d2;
							case 48:
								_003C_003Eu__2 = awaiter;
								num3 = 26;
								if (!toqmOcKH3PMUFCIZ6qcR())
								{
									continue;
								}
								goto case 115;
							case 115:
								num2 = (_003C_003E1__state = 10);
								num3 = 56;
								if (true)
								{
									continue;
								}
								goto case 101;
							case 101:
								num2 = (_003C_003E1__state = 16);
								_003C_003Eu__6 = awaiter7;
								num3 = 128;
								continue;
							case 89:
								return;
							case 77:
								_003C_003Eu__4 = awaiter4;
								num3 = 54;
								if (toqmOcKH3PMUFCIZ6qcR())
								{
								}
								continue;
							case 52:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
								return;
							case 124:
								awaiter = _003Csheet_003E5__6.RunAndGetCellResults(inputs).GetAwaiter();
								num3 = 168;
								continue;
							case 153:
								num2 = (_003C_003E1__state = 5);
								num3 = 166;
								continue;
							case 131:
								_003C_003Eu__3 = awaiter5;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
								num3 = 109;
								continue;
							case 146:
								awaiter4.GetResult();
								num3 = 50;
								if (toqmOcKH3PMUFCIZ6qcR())
								{
								}
								continue;
							case 110:
								dictionary2.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__8, (string)Fk1cTTKHygif8HEjLqJb(6138)), minMax2.Item2);
								num3 = 160;
								if (true)
								{
									continue;
								}
								goto case 35;
							case 35:
							case 80:
								_003C_003Eu__4 = default;
								num3 = 79;
								continue;
							case 170:
								awaiter6 = KB2fxVKHMCXUc2iXQeS2(EQgyjIKH0BxbhHOxTbOd(_003Ctool_003E5__11, result5, _003CpasteRange_003E5__7));
								num3 = 100;
								continue;
							case 107:
								_003Ctool_003E5__10 = null;
								goto case 172;
							case 88:
								num2 = (_003C_003E1__state = 14);
								goto case 86;
							default:
								num3 = 86;
								continue;
							case 169:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							case 147:
								return;
							case 24:
								awaiter7 = _003Csheet_003E5__6.GetCellPropertyAsync<double>(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.SXgT61Ttqt), (string)Fk1cTTKHygif8HEjLqJb(1524)).GetAwaiter();
								if (!awaiter7.IsCompleted)
								{
									num3 = 101;
									continue;
								}
								goto IL_11c0;
							case 42:
								return;
							case 159:
								goto IL_0a50;
							case 152:
								num2 = (_003C_003E1__state = 18);
								_003C_003Eu__7 = awaiter6;
								num3 = 122;
								continue;
							case 119:
								return;
							case 167:
								MwQiDEKHTi26xPrvCAeh(CvsTraceEzb.Info, Fk1cTTKHygif8HEjLqJb(49842));
								num3 = 0;
								continue;
							case 29:
								num2 = (_003C_003E1__state = 25);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 53:
								awaiter6 = ((Task)EQgyjIKH0BxbhHOxTbOd(_003Ctool_003E5__9, result9, _003CpasteRange_003E5__7)).GetAwaiter();
								num3 = 2;
								continue;
							case 18:
								if (!awaiter4.IsCompleted)
								{
									num3 = 135;
									if (true)
									{
										continue;
									}
									goto case 13;
								}
								goto IL_0dd3;
							case 13:
								_003C_003Eu__3 = awaiter5;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
								num3 = 137;
								continue;
							case 20:
								return;
							case 67:
								goto IL_0b6d;
							case 142:
								goto IL_0b85;
							case 163:
								_003C_003Eu__2 = default;
								num3 = 143;
								continue;
							case 168:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 17);
									num3 = 120;
									continue;
								}
								goto IL_0d08;
							case 9:
								num2 = (_003C_003E1__state = 8);
								num3 = 44;
								continue;
							case 49:
								_003C_003Eu__6 = awaiter7;
								num3 = 92;
								continue;
							case 0:
								_003Ctool_003E5__10 = new LineToLineDistanceTool((InspectStepViewModel)d2chk5KH6W5C6jKKeLLK(distanceToolType), isInitialized: false);
								num3 = 117;
								continue;
							case 65:
								awaiter5 = distanceToolType.PasteTool(pasteObject, result2, runSheet: false).GetAwaiter();
								num3 = 61;
								if (!toqmOcKH3PMUFCIZ6qcR())
								{
									continue;
								}
								goto case 139;
							case 139:
								_003C_003Eu__4 = default;
								num3 = 57;
								continue;
							case 25:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 26;
							case 26:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 119;
								continue;
							case 102:
								if (!awaiter4.IsCompleted)
								{
									num3 = 88;
									if (true)
									{
										continue;
									}
									goto case 32;
								}
								goto case 148;
							case 32:
								num2 = (_003C_003E1__state = 21);
								_003C_003Eu__4 = awaiter4;
								num3 = 69;
								if (baVxFCKH7BwWtDvD1gRM())
								{
									continue;
								}
								goto case 162;
							case 162:
								awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.ldCTas6Lfe), (string)eLD4u0KHFxNPp35phTcd(distanceToolType.InputImageLinks[oUZIc5KHWUiN7Zxe4Vhw(distanceToolType)])).GetAwaiter();
								num3 = 18;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								goto IL_0d08;
							case 120:
								_003C_003Eu__2 = awaiter;
								num3 = 25;
								continue;
							case 58:
								if (!awaiter4.IsCompleted)
								{
									num2 = (_003C_003E1__state = 4);
									num3 = 112;
									continue;
								}
								goto case 68;
							case 22:
								if (!awaiter3.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto IL_17e8;
							case 166:
								_003C_003Eu__4 = awaiter4;
								num3 = 136;
								if (true)
								{
									continue;
								}
								goto case 46;
							case 46:
								_003C_003Eu__3 = awaiter5;
								num3 = 6;
								continue;
							case 40:
								return;
							case 96:
								_003C_003Eu__4 = default;
								num3 = 75;
								continue;
							case 57:
								num2 = (_003C_003E1__state = -1);
								goto IL_0dd3;
							case 23:
								num2 = (_003C_003E1__state = 26);
								num3 = 132;
								continue;
							case 45:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter7, ref this);
								num3 = 126;
								continue;
							case 33:
								_003C_003Eu__3 = default;
								num3 = 134;
								continue;
							case 21:
								_003CtoolName_003E5__8 = null;
								num3 = 141;
								if (true)
								{
									continue;
								}
								goto case 30;
							case 30:
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 28;
								continue;
							case 137:
								return;
							case 41:
								goto IL_0e80;
							case 140:
								num2 = (_003C_003E1__state = -1);
								goto IL_0ea7;
							case 104:
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 23);
									num3 = 60;
									continue;
								}
								goto IL_1bfd;
							case 1:
								_003C_003Eu__6 = default;
								num3 = 16;
								continue;
							case 75:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 99:
								if (!awaiter7.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 125;
							case 2:
								if (!awaiter6.IsCompleted)
								{
									num3 = 115;
									if (toqmOcKH3PMUFCIZ6qcR())
									{
									}
									continue;
								}
								goto case 123;
							case 61:
								if (!awaiter5.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									num3 = 46;
									continue;
								}
								goto IL_18ee;
							case 141:
								_003Ctool_003E5__9 = null;
								goto case 172;
							case 144:
								return;
							case 156:
								awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.eQPTdVG7JC), _003Cexpr1_003E5__4).GetAwaiter();
								num3 = 102;
								if (true)
								{
									continue;
								}
								goto case 62;
							case 62:
								_003CpasteRange_003E5__7 = result6;
								num3 = 162;
								if (baVxFCKH7BwWtDvD1gRM())
								{
									continue;
								}
								goto case 95;
							case 95:
								if (!awaiter5.IsCompleted)
								{
									num3 = 161;
									continue;
								}
								goto case 165;
							case 148:
								awaiter4.GetResult();
								num3 = 116;
								if (!toqmOcKH3PMUFCIZ6qcR())
								{
									continue;
								}
								goto case 84;
							case 84:
								num2 = (_003C_003E1__state = -1);
								num3 = 150;
								continue;
							case 10:
								_003C_003Eu__6 = default;
								num3 = 140;
								continue;
							case 79:
								goto IL_106a;
							case 145:
								goto IL_1085;
							case 100:
								goto IL_10a4;
							case 81:
								_003Ctool_003E5__11 = null;
								num3 = 172;
								continue;
							case 37:
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 68;
								continue;
							case 56:
								_003C_003Eu__7 = awaiter6;
								num3 = 52;
								if (true)
								{
									continue;
								}
								goto case 125;
							case 125:
							{
								double result7 = awaiter7.GetResult();
								MwQiDEKHTi26xPrvCAeh(CvsTraceEzb.Info, Fk1cTTKHygif8HEjLqJb(50458));
								minMax2 = PointToPointDistanceTool.GetMinMax(result7);
								num3 = 151;
								continue;
							}
							case 127:
								if (!(_003CisPoint0_003E5__3 & _003CisPoint1_003E5__5))
								{
									if (!_003CisPoint0_003E5__3)
									{
										num3 = 82;
										if (toqmOcKH3PMUFCIZ6qcR())
										{
										}
										continue;
									}
									goto IL_06b6;
								}
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(distanceToolType.Qqhlr8yPDj, (InspectStepViewModel)d2chk5KH6W5C6jKKeLLK(distanceToolType), out _003CtoolName_003E5__8);
								num3 = 65;
								continue;
							case 55:
								num2 = (_003C_003E1__state = 6);
								num3 = 71;
								if (baVxFCKH7BwWtDvD1gRM())
								{
									continue;
								}
								goto case 132;
							case 132:
								_003C_003Eu__7 = awaiter6;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
								num3 = 114;
								continue;
							case 130:
								num2 = (_003C_003E1__state = 12);
								num3 = 77;
								continue;
							case 16:
								num2 = (_003C_003E1__state = -1);
								goto IL_11c0;
							case 5:
								num2 = (_003C_003E1__state = 7);
								num3 = 15;
								continue;
							case 128:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter7, ref this);
								return;
							case 143:
								num2 = (_003C_003E1__state = -1);
								num3 = 157;
								continue;
							case 114:
								return;
							case 105:
								awaiter4.GetResult();
								num3 = 76;
								continue;
							case 154:
								_003CpasteRange_003E5__7 = result6;
								num3 = 72;
								continue;
							case 44:
								_003C_003Eu__6 = awaiter7;
								num3 = 45;
								continue;
							case 64:
								CvsTraceEzb.Info.TraceMessage((string)Fk1cTTKHygif8HEjLqJb(49842));
								num3 = 36;
								continue;
							case 74:
								_003CtoolName_003E5__8 = null;
								num3 = 81;
								if (0 == 0)
								{
									continue;
								}
								goto case 97;
							case 97:
								awaiter3 = _003Csheet_003E5__6.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num3 = 22;
								if (baVxFCKH7BwWtDvD1gRM())
								{
									continue;
								}
								goto case 34;
							case 34:
								if (!awaiter7.IsCompleted)
								{
									num3 = 63;
									continue;
								}
								goto IL_0ea7;
							case 82:
								if (_003CisPoint1_003E5__5)
								{
									goto IL_06b6;
								}
								goto IL_137b;
							case 51:
								num2 = (_003C_003E1__state = -1);
								num3 = 165;
								continue;
							case 108:
								num2 = (_003C_003E1__state = 22);
								_003C_003Eu__4 = awaiter4;
								num3 = 155;
								continue;
							case 15:
								_003C_003Eu__5 = awaiter3;
								num3 = 94;
								continue;
							case 93:
								if (awaiter4.IsCompleted)
								{
									goto case 146;
								}
								num3 = 108;
								if (!toqmOcKH3PMUFCIZ6qcR())
								{
									continue;
								}
								goto case 78;
							case 78:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num3 = 40;
								continue;
							case 118:
								_003C_003Eu__4 = awaiter4;
								num3 = 158;
								if (true)
								{
									continue;
								}
								goto case 76;
							case 76:
								awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.QsNlmaD09e), _003Cexpr1_003E5__4).GetAwaiter();
								if (!awaiter4.IsCompleted)
								{
									num3 = 55;
									if (baVxFCKH7BwWtDvD1gRM())
									{
										continue;
									}
									goto case 157;
								}
								goto case 28;
							case 157:
								result9 = awaiter.GetResult();
								num3 = 41;
								continue;
							case 165:
								result6 = awaiter5.GetResult();
								num3 = 62;
								continue;
							case 149:
								num2 = (_003C_003E1__state = -1);
								num3 = 125;
								continue;
							case 150:
								result5 = awaiter.GetResult();
								num3 = 64;
								continue;
							case 66:
								awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.bovlhdB2Qy), distanceToolType.InputImageLinks[oUZIc5KHWUiN7Zxe4Vhw(distanceToolType)].Expression).GetAwaiter();
								num3 = 58;
								continue;
							case 126:
								return;
							case 103:
								_003C_003Eu__2 = default;
								num3 = 7;
								continue;
							case 158:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							case 69:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							case 47:
								goto IL_15aa;
							case 43:
								awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.oFuTpy8gxw), (!_003CisPoint0_003E5__3) ? _003Cexpr0_003E5__2 : _003Cexpr1_003E5__4).GetAwaiter();
								num3 = 93;
								continue;
							case 138:
								num2 = (_003C_003E1__state = -1);
								num3 = 145;
								if (0 == 0)
								{
									continue;
								}
								goto case 31;
							case 31:
								_003C_003Eu__2 = default;
								num3 = 84;
								if (toqmOcKH3PMUFCIZ6qcR())
								{
								}
								continue;
							case 122:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
								num3 = 37;
								if (true)
								{
									continue;
								}
								goto case 68;
							case 68:
								awaiter4.GetResult();
								awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.tsJl8VdPJl), _003Cexpr0_003E5__2).GetAwaiter();
								num3 = 3;
								continue;
							case 112:
								_003C_003Eu__4 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num3 = 20;
								continue;
							case 19:
								awaiter4.GetResult();
								num3 = 4;
								continue;
							case 50:
								awaiter3 = _003Csheet_003E5__6.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num3 = 104;
								continue;
							case 160:
								awaiter = _003Csheet_003E5__6.RunAndGetCellResults(dictionary2).GetAwaiter();
								num3 = 111;
								continue;
							case 121:
								num2 = (_003C_003E1__state = 15);
								num3 = 73;
								if (true)
								{
									continue;
								}
								goto case 116;
							case 116:
								awaiter3 = _003Csheet_003E5__6.RunAsync(fireSheetUpdated: false).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num3 = 121;
									continue;
								}
								goto IL_04e7;
							case 60:
								_003C_003Eu__5 = awaiter3;
								num3 = 169;
								if (0 == 0)
								{
									continue;
								}
								goto case 27;
							case 27:
								awaiter = _003Csheet_003E5__6.RunAndGetCellResults(dictionary).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 29;
									continue;
								}
								goto case 150;
							case 91:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num3 = 89;
								continue;
							case 63:
								num2 = (_003C_003E1__state = 24);
								num3 = 49;
								continue;
							case 70:
								_003CpasteRange_003E5__7 = result6;
								num3 = 66;
								continue;
							case 54:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num3 = 144;
								continue;
							case 98:
								num2 = (_003C_003E1__state = -1);
								goto IL_17e8;
							case 113:
								_003C_003Eu__4 = default;
								num3 = 133;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 12:
								return;
							case 11:
								awaiter4.GetResult();
								num3 = 43;
								continue;
							case 90:
								dictionary2.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__8, (string)Fk1cTTKHygif8HEjLqJb(6148)), minMax2.Item1);
								num3 = 110;
								continue;
							case 161:
								num2 = (_003C_003E1__state = 19);
								num3 = 13;
								if (toqmOcKH3PMUFCIZ6qcR())
								{
								}
								continue;
							case 28:
								awaiter4.GetResult();
								num3 = 97;
								continue;
							case 134:
								num2 = (_003C_003E1__state = -1);
								goto IL_18ee;
							case 136:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num3 = 39;
								continue;
							case 151:
								dictionary2 = new Dictionary<string, object>();
								num3 = 90;
								continue;
							case 171:
								MwQiDEKHTi26xPrvCAeh(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49436));
								awaiter7 = _003Csheet_003E5__6.GetCellPropertyAsync<double>(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.IcmTUUJNMf), (string)Fk1cTTKHygif8HEjLqJb(1524)).GetAwaiter();
								num3 = 34;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 11);
								num3 = 131;
								continue;
							case 133:
								num2 = (_003C_003E1__state = -1);
								num3 = 19;
								continue;
							case 85:
								awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.LrpT52OHjv), _003CisPoint0_003E5__3 ? _003Cexpr0_003E5__2 : _003Cexpr1_003E5__4).GetAwaiter();
								if (!awaiter4.IsCompleted)
								{
									num3 = 32;
									continue;
								}
								goto case 11;
							case 3:
								if (!awaiter4.IsCompleted)
								{
									num3 = 153;
									continue;
								}
								goto case 105;
							case 94:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
								return;
							case 36:
								goto IL_1a6d;
							case 106:
								dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__8, (string)Fk1cTTKHygif8HEjLqJb(6148)), minMax.Item1);
								dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__8, (string)Fk1cTTKHygif8HEjLqJb(6138)), minMax.Item2);
								num3 = 27;
								continue;
							case 39:
								return;
							case 4:
								goto IL_1b02;
							case 123:
								awaiter6.GetResult();
								ezTool = _003Ctool_003E5__9;
								num3 = 21;
								continue;
							case 17:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							case 117:
								awaiter6 = KB2fxVKHMCXUc2iXQeS2(EQgyjIKH0BxbhHOxTbOd(_003Ctool_003E5__10, result3, _003CpasteRange_003E5__7));
								num3 = 159;
								if (toqmOcKH3PMUFCIZ6qcR())
								{
								}
								continue;
							case 59:
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 105;
								continue;
							case 83:
								return;
							case 73:
								_003C_003Eu__5 = awaiter3;
								num3 = 91;
								continue;
							case 172:
								{
									result4 = ezTool;
									goto end_IL_02be;
								}
								IL_06b6:
								pasteObject2 = EzToolType.UpdateNamesInPasteBuffer(distanceToolType.HO2lzZ4F0R, distanceToolType.Inspect, out _003CtoolName_003E5__8);
								awaiter5 = distanceToolType.PasteTool(pasteObject2, result2, runSheet: false).GetAwaiter();
								num3 = 95;
								if (!toqmOcKH3PMUFCIZ6qcR())
								{
									continue;
								}
								goto case 88;
								IL_18ee:
								result6 = awaiter5.GetResult();
								num3 = 70;
								if (0 == 0)
								{
									continue;
								}
								goto case 136;
								IL_0ea7:
								result8 = awaiter7.GetResult();
								MwQiDEKHTi26xPrvCAeh(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(50458));
								minMax = PointToLineDistanceTool.GetMinMax(result8);
								dictionary = new Dictionary<string, object>();
								num3 = 106;
								if (baVxFCKH7BwWtDvD1gRM())
								{
									continue;
								}
								goto case 104;
								IL_17e8:
								awaiter3.GetResult();
								MwQiDEKHTi26xPrvCAeh(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49436));
								awaiter7 = _003Csheet_003E5__6.GetCellPropertyAsync<double>(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.fG5l1OaPT4), (string)Fk1cTTKHygif8HEjLqJb(1524)).GetAwaiter();
								num3 = 99;
								continue;
								IL_0d08:
								result3 = awaiter.GetResult();
								num3 = 167;
								continue;
								IL_0dd3:
								awaiter4.GetResult();
								num3 = 85;
								if (true)
								{
									continue;
								}
								goto case 23;
								IL_11c0:
								result10 = awaiter7.GetResult();
								MwQiDEKHTi26xPrvCAeh(CvsTraceEzb.Info, Fk1cTTKHygif8HEjLqJb(50458));
								minMax3 = LineToLineDistanceTool.GetMinMax(result10);
								inputs = new Dictionary<string, object>
								{
									{
										EzSnippet.AssembleFullCellName(_003CtoolName_003E5__8, (string)Fk1cTTKHygif8HEjLqJb(6148)),
										minMax3.Item1
									},
									{
										EzSnippet.AssembleFullCellName(_003CtoolName_003E5__8, (string)Fk1cTTKHygif8HEjLqJb(6138)),
										minMax3.Item2
									}
								};
								num3 = 124;
								if (!toqmOcKH3PMUFCIZ6qcR())
								{
									continue;
								}
								goto case 5;
							}
							break;
							IL_137b:
							PasteBuffer pasteObject3 = EzToolType.UpdateNamesInPasteBuffer(distanceToolType.Q3QT7IZMpf, (InspectStepViewModel)d2chk5KH6W5C6jKKeLLK(distanceToolType), out _003CtoolName_003E5__8);
							awaiter5 = distanceToolType.PasteTool(pasteObject3, result2, runSheet: false).GetAwaiter();
							if (!awaiter5.IsCompleted)
							{
								num3 = 14;
								continue;
							}
							goto IL_0411;
							IL_10a4:
							if (!awaiter6.IsCompleted)
							{
								num3 = 23;
								continue;
							}
							goto IL_12b8;
						}
						goto IL_032f;
						IL_1b02:
						awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.AfKTAe6CgK), _003Cexpr0_003E5__2).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num2 = (_003C_003E1__state = 13);
							num3 = 118;
							goto IL_070d;
						}
						goto IL_1073;
						IL_04e7:
						awaiter3.GetResult();
						MwQiDEKHTi26xPrvCAeh(CvsTraceEzb.Info, Fk1cTTKHygif8HEjLqJb(49436));
						num3 = 24;
						if (toqmOcKH3PMUFCIZ6qcR())
						{
						}
						goto IL_070d;
						IL_1a6d:
						_003Ctool_003E5__11 = new PointToLineDistanceTool((InspectStepViewModel)d2chk5KH6W5C6jKKeLLK(distanceToolType), isInitialized: false);
						num3 = 170;
						goto IL_070d;
						IL_15aa:
						_003C_003Eu__6 = default;
						num3 = 149;
						goto IL_070d;
						IL_0411:
						result6 = awaiter5.GetResult();
						num3 = 154;
						goto IL_070d;
						IL_12b8:
						awaiter6.GetResult();
						ezTool = _003Ctool_003E5__11;
						num3 = 74;
						goto IL_070d;
						IL_106a:
						num2 = (_003C_003E1__state = -1);
						goto IL_1073;
						IL_1073:
						awaiter4.GetResult();
						num3 = 156;
						goto IL_070d;
						IL_1bfd:
						awaiter3.GetResult();
						num3 = 171;
						goto IL_070d;
						IL_0e80:
						MwQiDEKHTi26xPrvCAeh(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49842));
						num3 = 38;
						goto IL_070d;
						IL_0b6d:
						_003C_003Eu__7 = default;
						num3 = 138;
						if (true)
						{
							goto IL_070d;
						}
						goto IL_0b85;
						IL_0b85:
						_003C_003Eu__4 = default;
						num3 = 8;
						goto IL_070d;
						IL_0a50:
						if (!awaiter6.IsCompleted)
						{
							num3 = 152;
							if (toqmOcKH3PMUFCIZ6qcR())
							{
							}
							goto IL_070d;
						}
						goto IL_1085;
						IL_032f:
						awaiter4 = _003Csheet_003E5__6.PutCellExpressionAsync(distanceToolType.GetCellLocation(_003CpasteRange_003E5__7.Location, distanceToolType.hSGTNr8LhO), (string)eLD4u0KHFxNPp35phTcd(distanceToolType.InputImageLinks[oUZIc5KHWUiN7Zxe4Vhw(distanceToolType)])).GetAwaiter();
						num3 = 129;
						goto IL_070d;
						end_IL_02be:
						break;
					}
				}
				catch (Exception)
				{
					throw;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cexpr0_003E5__2 = null;
				_003Cexpr1_003E5__4 = null;
				_003Csheet_003E5__6 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_003d;
			IL_003d:
			_003Cexpr0_003E5__2 = null;
			goto IL_008d;
			IL_0056:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 8:
					break;
				case 3:
				case 6:
					goto IL_003d;
				default:
					num = 2;
					continue;
				case 2:
					goto IL_008d;
				case 1:
					goto IL_00a4;
				case 4:
					_003Csheet_003E5__6 = null;
					num = 7;
					continue;
				case 7:
					_003C_003Et__builder.SetResult(result4);
					num = 9;
					if (baVxFCKH7BwWtDvD1gRM())
					{
						continue;
					}
					goto case 5;
				case 5:
					distanceToolType = _003C_003E4__this;
					num = 1;
					continue;
				case 9:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_008d:
			_003Cexpr1_003E5__4 = null;
			num = 4;
			if (baVxFCKH7BwWtDvD1gRM())
			{
				goto IL_0056;
			}
			goto IL_00a4;
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
		internal static bool y0CmhYKHjl1x8lgGbSxu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GsblGSpy7C((CvsEditableDisplayGraphic)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d2chk5KH6W5C6jKKeLLK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object H9jrafKHCXMHi4ouAwr6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object R1kvCKKHAqxVNvW4UvuT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RCIeaEKHRnPvR5Ta0BCQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oUZIc5KHWUiN7Zxe4Vhw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MwQiDEKHTi26xPrvCAeh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fk1cTTKHygif8HEjLqJb(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EQgyjIKH0BxbhHOxTbOd(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eLD4u0KHFxNPp35phTcd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter KB2fxVKHMCXUc2iXQeS2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool baVxFCKH7BwWtDvD1gRM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool toqmOcKH3PMUFCIZ6qcR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass55_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			s0XHYVKHHaqMIaZthmCK(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetUpdates_003Eb__0(PasteBuffer s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xt0MpuKHxWlirt79cHux(s).Equals(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void s0XHYVKHHaqMIaZthmCK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JmuHdhKHY1J5rRYFqwGh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J8RcwtKHU8PhZcfcpxXw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Guid xt0MpuKHxWlirt79cHux(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetGuid((PasteBuffer)P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__55 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public DistanceToolType _003C_003E4__this;

		private _003C_003Ec__DisplayClass55_0 _003C_003E8__1;

		private int _003CcurrentVersion_003E5__2;

		private int _003ClatestVersion_003E5__3;

		private CvsCellLocation _003CtransPixelToWorldOffset4_003E5__4;

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
		public _003CGetUpdates_003Ed__55(int _003C_003E1__state)
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
				case 0:
					z3q6Q0KHNxQIhrNwErvt();
					num = 5;
					continue;
				case 2:
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				default:
					_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 5:
					break;
				case 6:
					return;
				}
				base._002Ector();
				_ = 0;
				num = ((!CTkYUlKHmMcfi7f2ly0Q()) ? 1 : 4);
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
			int num = 99;
			CvsCellLocation offset30 = default;
			CvsCellLocation offset35 = default;
			DistanceToolType distanceToolType = default;
			CvsCellLocation offset36 = default;
			CvsCellLocation offset = default;
			CvsCellLocation offset15 = default;
			PasteBuffer pasteBuffer = default;
			CvsCellLocation offset38 = default;
			CvsCellLocation offset21 = default;
			CvsCellLocation offset26 = default;
			CvsCellLocation offset37 = default;
			CvsCellLocation offset10 = default;
			CvsCellLocation offset22 = default;
			int num2 = default;
			CvsCellLocation offset12 = default;
			CvsCellLocation offset6 = default;
			CvsCellLocation offset24 = default;
			CvsCellLocation offset29 = default;
			CvsCellLocation offset8 = default;
			CvsCellLocation offset19 = default;
			CvsCellLocation offset33 = default;
			CvsCellLocation offset31 = default;
			CvsCellLocation offset23 = default;
			CvsCellLocation offset16 = default;
			CvsCellLocation offset18 = default;
			CvsCellLocation offset7 = default;
			CvsCellLocation offset13 = default;
			CvsCellLocation offset14 = default;
			CvsCellLocation offset4 = default;
			CvsCellLocation offset9 = default;
			CvsCellLocation offset28 = default;
			CvsCellLocation offset5 = default;
			while (true)
			{
				CvsCellLocation offset27;
				CvsCellLocation offset32;
				CvsCellLocation offset34;
				switch (num)
				{
				case 40:
					offset30 = new CvsCellLocation(3, 1);
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 10;
				case 10:
					return true;
				case 3:
					_003C_003E2__current = new EditArgumentUpdate(offset30, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 75;
					continue;
				case 59:
					_003C_003E2__current = new EditArgumentUpdate(offset35, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 33;
					return true;
				case 172:
					_003C_003E1__state = 31;
					num = 112;
					if (0 == 0)
					{
						continue;
					}
					goto case 83;
				case 83:
					return true;
				case 148:
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, distanceToolType.I3HlsksnWs, 2, null);
					num = 143;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
					_003C_003E1__state = 52;
					return true;
				case 26:
					return true;
				case 107:
					offset36 = new CvsCellLocation(3, 5);
					num = 142;
					if (true)
					{
						continue;
					}
					goto case 108;
				case 108:
					_003C_003E1__state = 56;
					num = 158;
					continue;
				case 57:
					_003C_003E1__state = 15;
					num = 49;
					continue;
				case 139:
					_003C_003E1__state = 35;
					num = 163;
					if (true)
					{
						continue;
					}
					goto case 154;
				case 25:
					return true;
				case 162:
					return true;
				case 127:
					_003C_003E2__current = new EditArgumentUpdate(offset, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 38;
					num = 83;
					continue;
				case 30:
					return true;
				case 54:
					return true;
				case 78:
					_003C_003E2__current = new EditArgumentUpdate(offset15, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 7;
					continue;
				case 5:
					return true;
				case 120:
				{
					CvsCellLocation offset41 = new CvsCellLocation(2, 0);
					_003C_003E2__current = new EditArgumentUpdate(offset41, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 18;
					return true;
				}
				case 32:
					return true;
				case 142:
					_003C_003E2__current = new EditArgumentUpdate(offset36, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 46;
					return true;
				case 164:
					return true;
				case 34:
					offset35 = new CvsCellLocation(1, 6);
					num = 59;
					continue;
				case 90:
					_003ClatestVersion_003E5__3 = bf5TDxKH1uUigZgKj5jR(pasteBuffer);
					num = 105;
					continue;
				case 140:
					return true;
				case 55:
					return true;
				case 16:
					_003CtransPixelToWorldOffset4_003E5__4 = default;
					num = 31;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 41;
				case 41:
					offset38 = new CvsCellLocation(1, 3);
					num = 51;
					if (im6vVcKHQ9d6BM9Cuase())
					{
					}
					continue;
				case 156:
					_003C_003E1__state = 36;
					num = 63;
					if (0 == 0)
					{
						continue;
					}
					goto case 21;
				case 21:
					return true;
				case 133:
					return true;
				case 92:
					_003C_003E1__state = 44;
					num = 10;
					continue;
				case 144:
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, distanceToolType.I3HlsksnWs, 2, null);
					num = 88;
					continue;
				case 163:
					return true;
				case 67:
					offset21 = new CvsCellLocation(3, 5);
					num = 114;
					if (!im6vVcKHQ9d6BM9Cuase())
					{
						continue;
					}
					goto case 170;
				case 170:
					_003C_003E2__current = new EditArgumentUpdate(offset26, SnippetUpdateHelper.InputImageLocationFactory, 0, null, ignoreInvalidArgIndex: true);
					_003C_003E1__state = 6;
					return true;
				case 76:
					_003C_003E2__current = new EditArgumentUpdate(offset37, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 72;
					continue;
				case 48:
					_003C_003E1__state = 4;
					return true;
				case 143:
					_003C_003E1__state = 41;
					num = 149;
					continue;
				case 12:
					distanceToolType = _003C_003E4__this;
					num = 113;
					if (im6vVcKHQ9d6BM9Cuase())
					{
					}
					continue;
				case 152:
					_003C_003E1__state = 16;
					num = 64;
					continue;
				case 94:
					_003C_003E1__state = 39;
					num = 44;
					continue;
				case 171:
				{
					CvsCellLocation offset40 = new CvsCellLocation(2, 2);
					_003C_003E2__current = new EditArgumentUpdate(offset40, SnippetUpdateHelper.InputImageLocationFactory, 0, null, ignoreInvalidArgIndex: true);
					num = 139;
					continue;
				}
				case 27:
					_003C_003E2__current = new EditArgumentUpdate(offset10, SnippetUpdateHelper.InputImageLocationFactory, 0, null, ignoreInvalidArgIndex: true);
					num = 57;
					continue;
				case 80:
					_003C_003E1__state = 11;
					num = 132;
					if (true)
					{
						continue;
					}
					goto case 146;
				case 146:
				{
					CvsCellLocation offset39 = new CvsCellLocation(2, 4);
					_003C_003E2__current = new EditArgumentUpdate(offset39, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 37;
					return true;
				}
				case 178:
					offset22 = new CvsCellLocation(3, 3);
					num = 29;
					continue;
				case 84:
					_003C_003E1__state = 42;
					return true;
				case 47:
					_003C_003E1__state = 21;
					num = 101;
					continue;
				case 99:
					num2 = _003C_003E1__state;
					num = 12;
					continue;
				case 52:
					return true;
				case 7:
					_003C_003E1__state = 34;
					num = 54;
					continue;
				case 63:
					return true;
				case 128:
					return true;
				case 115:
					if (_003CcurrentVersion_003E5__2 < 5)
					{
						if (_003C_003E8__1.guid.Equals(FUClVDrnVT))
						{
							_003C_003E2__current = new FixTransWorldCalibratePtp(distanceToolType.Localizer, (CvsFunctionTable)PdStJdKHhdEiU4pW6f5n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)), (IExpressionConstants)Aje74nKHtgrHETqTN06n(distanceToolType.InSight));
							num = 108;
							continue;
						}
						if (_003C_003E8__1.guid.Equals(aXslLUj9s1))
						{
							_003C_003E2__current = new FixTransWorldCalibratePtl(distanceToolType.Localizer, (CvsFunctionTable)PdStJdKHhdEiU4pW6f5n(distanceToolType.InSight), ((CvsInSight)SbPbevKHuFmv1WVWi5KZ(distanceToolType)).ProcessorConstants);
							num = 137;
							continue;
						}
						if (_003C_003E8__1.guid.Equals(z43lJJQFNn))
						{
							_003C_003E2__current = new FixTransWorldCalibrateLtl(distanceToolType.Localizer, ((CvsInSight)SbPbevKHuFmv1WVWi5KZ(distanceToolType)).FunctionTable, (IExpressionConstants)Aje74nKHtgrHETqTN06n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)));
							num = 74;
							if (true)
							{
								continue;
							}
							goto case 72;
						}
					}
					goto case 11;
				case 93:
					_003C_003E1__state = 27;
					return true;
				case 97:
					_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(distanceToolType.Q3QT7IZMpf, (CvsFunctionTable)PdStJdKHhdEiU4pW6f5n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)), (IExpressionConstants)Aje74nKHtgrHETqTN06n(distanceToolType.InSight));
					num = 69;
					continue;
				case 20:
					return true;
				case 70:
					_003C_003E2__current = new EditArgumentUpdate(offset12, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 98;
					if (true)
					{
						continue;
					}
					goto case 150;
				case 150:
					offset6 = new CvsCellLocation(1, 2);
					num = 102;
					continue;
				case 51:
					_003C_003E2__current = new EditArgumentUpdate(offset38, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 152;
					continue;
				case 79:
					offset37 = new CvsCellLocation(2, 3);
					num = 76;
					continue;
				case 130:
					_003C_003E2__current = new EditArgumentUpdate(offset24, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 45;
					num = 77;
					continue;
				case 125:
					_003C_003E2__current = new EditArgumentUpdate(offset29, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 2;
					continue;
				case 8:
					if (!_003C_003E8__1.guid.Equals(aXslLUj9s1))
					{
						if (_003C_003E8__1.guid.Equals(FUClVDrnVT))
						{
							num = 131;
							continue;
						}
						if (_003C_003E8__1.guid.Equals(z43lJJQFNn))
						{
							num = 97;
							continue;
						}
						break;
					}
					goto case 85;
				case 18:
					return true;
				case 153:
					offset8 = new CvsCellLocation(2, 1);
					num = 109;
					continue;
				case 1:
					_003C_003E2__current = new EditArgumentUpdate(offset19, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 151;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 64;
				case 64:
					return true;
				case 65:
					_003C_003E2__current = new EditArgumentUpdate(offset33, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 156;
					continue;
				case 113:
					switch (num2)
					{
					case 44:
						break;
					case 33:
						goto IL_008c;
					case 38:
						goto IL_00b9;
					case 52:
						goto IL_0109;
					case 62:
						goto IL_013d;
					case 12:
						goto IL_01ed;
					case 14:
						goto IL_0228;
					case 29:
						goto IL_0269;
					case 34:
						goto IL_0282;
					case 13:
						goto IL_02c1;
					case 18:
						goto IL_0301;
					case 2:
						goto IL_0314;
					case 46:
						goto IL_037d;
					case 28:
						goto IL_03bd;
					case 58:
						goto IL_0421;
					case 19:
						goto IL_0434;
					case 60:
						goto IL_0494;
					case 49:
						goto IL_04c6;
					case 35:
						goto IL_0515;
					case 6:
						goto IL_056d;
					case 4:
						goto IL_05d9;
					case 37:
						goto IL_06d3;
					case 42:
						goto IL_0701;
					case 26:
						goto IL_0737;
					case 36:
						goto IL_076f;
					case 47:
						goto IL_0782;
					case 27:
						goto IL_07f6;
					case 40:
						goto IL_085a;
					case 17:
						goto IL_095f;
					case 16:
						goto IL_09b1;
					default:
						goto IL_0af3;
					case 56:
						goto IL_0aff;
					case 53:
						goto IL_0b48;
					case 8:
						goto IL_0b6d;
					case 57:
						goto IL_0b8b;
					case 50:
						goto IL_0b9e;
					case 55:
						goto IL_0bba;
					case 39:
						goto IL_0cbe;
					case 21:
						goto IL_0dbc;
					case 3:
						goto IL_0df5;
					case 54:
						goto IL_0f05;
					case 45:
						goto IL_0f24;
					case 43:
						goto IL_0f37;
					case 15:
						goto IL_0f70;
					case 25:
						goto IL_0fda;
					case 41:
						goto IL_10cd;
					case 9:
						goto IL_110b;
					case 48:
						goto IL_1189;
					case 11:
						goto IL_1204;
					case 20:
						goto IL_15f3;
					case 22:
						goto IL_160f;
					case 30:
						goto IL_1622;
					case 32:
						goto IL_1637;
					case 10:
						goto IL_1696;
					case 0:
						goto IL_16f7;
					case 24:
						goto IL_1756;
					case 51:
						goto IL_17f0;
					case 61:
						goto IL_1922;
					case 59:
						goto IL_19df;
					case 7:
						goto IL_19fe;
					case 23:
						goto IL_1a19;
					case 31:
						goto IL_1a56;
					case 5:
						goto IL_1ac9;
					case 1:
						goto IL_1afb;
					}
					_003C_003E1__state = -1;
					num = 81;
					continue;
				case 158:
					return true;
				case 45:
					_003C_003E2__current = new EditArgumentUpdate(offset31, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 48;
					if (!im6vVcKHQ9d6BM9Cuase())
					{
						continue;
					}
					goto case 46;
				case 46:
					_003C_003E1__state = 53;
					return true;
				case 19:
					_003C_003E1__state = 19;
					num = 55;
					continue;
				case 121:
					return true;
				case 145:
					return true;
				case 110:
					return true;
				case 62:
					return true;
				case 75:
					_003C_003E1__state = 8;
					num = 121;
					if (!im6vVcKHQ9d6BM9Cuase())
					{
						continue;
					}
					goto case 68;
				case 68:
				{
					CvsCellLocation offset25 = new CvsCellLocation(3, 0);
					_003C_003E2__current = new EditArgumentUpdate(offset25, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 104;
					if (im6vVcKHQ9d6BM9Cuase())
					{
					}
					continue;
				}
				case 81:
					offset24 = new CvsCellLocation(3, 4);
					num = 130;
					if (im6vVcKHQ9d6BM9Cuase())
					{
					}
					continue;
				case 11:
				case 123:
				case 124:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 103;
						continue;
					}
					goto IL_19e6;
				case 131:
					_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(distanceToolType.Qqhlr8yPDj, (CvsFunctionTable)PdStJdKHhdEiU4pW6f5n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)), (IExpressionConstants)Aje74nKHtgrHETqTN06n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)));
					num = 61;
					continue;
				case 137:
					_003C_003E1__state = 57;
					num = 145;
					continue;
				case 23:
					_003C_003E2__current = new EditArgumentUpdate(offset23, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 86;
					continue;
				case 44:
					return true;
				case 88:
					_003C_003E1__state = 12;
					num = 25;
					continue;
				case 74:
					_003C_003E1__state = 58;
					num = 140;
					continue;
				case 39:
					offset = new CvsCellLocation(2, 5);
					num = 127;
					continue;
				case 166:
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 93;
					if (true)
					{
						continue;
					}
					goto case 66;
				case 66:
					pasteBuffer = distanceToolType.SnippetObjects.First([MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer s) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return _003C_003Ec__DisplayClass55_0.xt0MpuKHxWlirt79cHux(s).Equals(_003C_003E8__1.guid);
					});
					num = 90;
					if (0 == 0)
					{
						continue;
					}
					goto case 98;
				case 98:
					_003C_003E1__state = 32;
					num = 122;
					continue;
				case 104:
					_003C_003E1__state = 22;
					num = 22;
					continue;
				case 101:
					return true;
				case 29:
					_003C_003E2__current = new EditArgumentUpdate(offset22, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 173;
					continue;
				case 53:
					return true;
				case 114:
					_003C_003E2__current = new EditArgumentUpdate(offset21, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 14;
					num = 162;
					if (0 == 0)
					{
						continue;
					}
					goto case 138;
				case 138:
					_003CtransPixelToWorldOffset4_003E5__4 = default;
					num = 126;
					continue;
				case 117:
					_003C_003E1__state = 5;
					num = 106;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 73;
				case 73:
				{
					CvsCellLocation offset20 = new CvsCellLocation(4, 5);
					_003C_003E2__current = new EditArgumentUpdate(offset20, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 56;
					continue;
				}
				case 69:
					_003C_003E1__state = 62;
					num = 26;
					if (!im6vVcKHQ9d6BM9Cuase())
					{
						continue;
					}
					goto case 168;
				case 168:
					return true;
				case 154:
					if (_003CcurrentVersion_003E5__2 < 4)
					{
						num = 17;
						continue;
					}
					goto case 115;
				case 77:
					return true;
				case 28:
					return true;
				case 9:
					if (!_003C_003E8__1.guid.Equals(FUClVDrnVT))
					{
						if (_003C_003E8__1.guid.Equals(aXslLUj9s1))
						{
							num = 177;
							if (0 == 0)
							{
								continue;
							}
							goto case 26;
						}
						if (_003C_003E8__1.guid.Equals(z43lJJQFNn))
						{
							_003C_003E2__current = new AddTransWorldToPixelCellUpdateLtl(distanceToolType.Localizer, (CvsFunctionTable)PdStJdKHhdEiU4pW6f5n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)), (IExpressionConstants)Aje74nKHtgrHETqTN06n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)));
							num = 38;
							continue;
						}
						goto case 154;
					}
					num = 50;
					continue;
				case 49:
					return true;
				case 85:
				case 169:
					_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(distanceToolType.HO2lzZ4F0R, (CvsFunctionTable)PdStJdKHhdEiU4pW6f5n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)), (IExpressionConstants)Aje74nKHtgrHETqTN06n(distanceToolType.InSight));
					_003C_003E1__state = 60;
					num = 21;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 38;
				case 38:
					_003C_003E1__state = 54;
					num = 168;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 165;
				case 165:
					return true;
				case 100:
					offset19 = new CvsCellLocation(3, 2);
					num = 1;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 116;
				case 116:
					_003C_003E1__state = 3;
					num = 53;
					continue;
				case 14:
					_003C_003E2__current = new EditArgumentUpdate(offset16, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 49;
					num = 133;
					continue;
				case 24:
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, distanceToolType.kXRlK00wBb, 3, null);
					num = 84;
					continue;
				case 0:
					_003C_003E2__current = new EditArgumentUpdate(offset18, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 147;
					continue;
				case 141:
				{
					CvsCellLocation offset17 = new CvsCellLocation(2, 2);
					_003C_003E2__current = new EditArgumentUpdate(offset17, SnippetUpdateHelper.InputImageLocationFactory, 0, null, ignoreInvalidArgIndex: true);
					num = 19;
					continue;
				}
				case 149:
					return true;
				case 86:
					_003C_003E1__state = 9;
					num = 35;
					continue;
				case 6:
					offset7 = new CvsCellLocation(4, 0);
					num = 118;
					continue;
				case 35:
					return true;
				case 95:
					offset16 = new CvsCellLocation(4, 4);
					num = 14;
					continue;
				case 111:
					_003C_003E2__current = new AddEnabledStateCellStateUpdatePtp();
					num = 175;
					continue;
				case 96:
					_003C_003E1__state = 48;
					return true;
				case 43:
					offset13 = new CvsCellLocation(1, 3);
					num = 89;
					continue;
				case 13:
					_003C_003E1__state = 28;
					num = 164;
					continue;
				case 37:
					offset15 = new CvsCellLocation(1, 7);
					num = 78;
					continue;
				case 60:
					_003C_003E2__current = new EditArgumentUpdate(offset14, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 17;
					num = 18;
					continue;
				case 132:
					return true;
				case 105:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 82;
						continue;
					}
					goto case 176;
				case 89:
					_003C_003E2__current = new EditArgumentUpdate(offset13, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 116;
					continue;
				case 82:
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					_003C_003E1__state = 1;
					num = 136;
					continue;
				case 129:
					offset12 = new CvsCellLocation(1, 4);
					num = 70;
					continue;
				case 42:
					_003CtransPixelToWorldOffset4_003E5__4 = new CvsCellLocation(3, 4);
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 80;
					continue;
				case 91:
				{
					CvsCellLocation offset11 = new CvsCellLocation(1, 3);
					_003C_003E2__current = new EditArgumentUpdate(offset11, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					goto case 172;
				}
				default:
					num = 172;
					continue;
				case 155:
					if (!_003C_003E8__1.guid.Equals(FUClVDrnVT))
					{
						if (_003C_003E8__1.guid.Equals(aXslLUj9s1))
						{
							offset10 = new CvsCellLocation(1, 2);
							num = 27;
							continue;
						}
						if (_003C_003E8__1.guid.Equals(z43lJJQFNn))
						{
							offset4 = new CvsCellLocation(1, 2);
							num = 157;
							continue;
						}
						goto case 31;
					}
					num = 150;
					continue;
				case 15:
					return true;
				case 22:
					return true;
				case 87:
				case 135:
					return true;
				case 122:
					return true;
				case 109:
					_003C_003E2__current = new EditArgumentUpdate(offset8, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 117;
					if (true)
					{
						continue;
					}
					goto case 71;
				case 71:
					_003C_003E2__current = new EditArgumentUpdate(offset9, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 10;
					return true;
				case 58:
					_003C_003E2__current = new EditArgumentUpdate(offset28, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 94;
					continue;
				case 118:
					_003C_003E2__current = new EditArgumentUpdate(offset7, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 96;
					continue;
				case 119:
					return false;
				case 173:
					_003C_003E1__state = 24;
					return true;
				case 102:
					_003C_003E2__current = new EditArgumentUpdate(offset6, SnippetUpdateHelper.InputImageLocationFactory, 0, null, ignoreInvalidArgIndex: true);
					_003C_003E1__state = 2;
					num = 32;
					continue;
				case 160:
					_003C_003E2__current = new EditArgumentUpdate(offset5, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 47;
					continue;
				case 147:
					_003C_003E1__state = 51;
					return true;
				case 176:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						num = 155;
						continue;
					}
					goto case 31;
				case 157:
					_003C_003E2__current = new EditArgumentUpdate(offset4, SnippetUpdateHelper.InputImageLocationFactory, 0, null, ignoreInvalidArgIndex: true);
					_003C_003E1__state = 30;
					CTkYUlKHmMcfi7f2ly0Q();
					num = ((!im6vVcKHQ9d6BM9Cuase()) ? 135 : 85);
					continue;
				case 177:
					_003C_003E2__current = new AddTransWorldToPixelCellUpdatePtl(distanceToolType.Localizer);
					num = 46;
					continue;
				case 103:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, distanceToolType.Localizer);
					num = 33;
					continue;
				case 36:
					_003CtransPixelToWorldOffset4_003E5__4 = default;
					num = 174;
					if (true)
					{
						continue;
					}
					goto case 11;
				case 72:
					_003C_003E1__state = 20;
					num = 15;
					continue;
				case 61:
					_003C_003E1__state = 61;
					return true;
				case 56:
					_003C_003E1__state = 50;
					num = 110;
					continue;
				case 159:
				{
					CvsCellLocation offset3 = new CvsCellLocation(3, 2);
					_003C_003E2__current = new EditArgumentUpdate(offset3, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 92;
					if (!im6vVcKHQ9d6BM9Cuase())
					{
						continue;
					}
					goto case 2;
				}
				case 2:
					_003C_003E1__state = 26;
					num = 52;
					continue;
				case 161:
				{
					CvsCellLocation offset2 = new CvsCellLocation(3, 0);
					_003C_003E2__current = new EditArgumentUpdate(offset2, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 43;
					num = 28;
					continue;
				}
				case 175:
					_003C_003E1__state = 55;
					num = 62;
					continue;
				case 33:
					_003C_003E1__state = 59;
					return true;
				case 134:
					return true;
				case 151:
					_003C_003E1__state = 23;
					return true;
				case 17:
					if (!_003C_003E8__1.guid.Equals(FUClVDrnVT))
					{
						goto case 115;
					}
					num = 111;
					if (!im6vVcKHQ9d6BM9Cuase())
					{
						continue;
					}
					goto case 112;
				case 112:
					return true;
				case 50:
					_003C_003E2__current = new AddTransWorldToPixelCellUpdatePtp(distanceToolType.Localizer, (CvsFunctionTable)PdStJdKHhdEiU4pW6f5n(SbPbevKHuFmv1WVWi5KZ(distanceToolType)), (IExpressionConstants)Aje74nKHtgrHETqTN06n(distanceToolType.InSight));
					num = 4;
					continue;
				case 106:
					return true;
				case 31:
				case 126:
				case 174:
					if (_003CcurrentVersion_003E5__2 < 3)
					{
						num = 9;
						continue;
					}
					goto case 154;
				case 136:
					return true;
				case 167:
				case 179:
					break;
					IL_1afb:
					_003C_003E1__state = -1;
					num = 176;
					continue;
					IL_1ac9:
					_003C_003E1__state = -1;
					offset26 = new CvsCellLocation(2, 2);
					num = 170;
					continue;
					IL_1a56:
					_003C_003E1__state = -1;
					num = 129;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					break;
					IL_1a19:
					_003C_003E1__state = -1;
					num = 178;
					continue;
					IL_19fe:
					_003C_003E1__state = -1;
					num = 40;
					continue;
					IL_19df:
					_003C_003E1__state = -1;
					goto IL_19e6;
					IL_1922:
					_003C_003E1__state = -1;
					num = 167;
					continue;
					IL_17f0:
					_003C_003E1__state = -1;
					num = 16;
					if (im6vVcKHQ9d6BM9Cuase())
					{
					}
					continue;
					IL_1756:
					_003C_003E1__state = -1;
					offset27 = new CvsCellLocation(3, 4);
					_003C_003E2__current = new EditArgumentUpdate(offset27, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 25;
					num = 165;
					continue;
					IL_16f7:
					_003C_003E1__state = -1;
					_003C_003E8__1 = new _003C_003Ec__DisplayClass55_0();
					_003CcurrentVersion_003E5__2 = TCVS3PKH2dvgf1GuAEfk(cells, range);
					_003C_003E8__1.guid = dZjy0ZKHcU2W21C1yll1(cells, range);
					num = 66;
					if (!im6vVcKHQ9d6BM9Cuase())
					{
						continue;
					}
					goto case 173;
					IL_1696:
					_003C_003E1__state = -1;
					num = 42;
					if (0 == 0)
					{
						continue;
					}
					goto case 58;
					IL_1637:
					_003C_003E1__state = -1;
					num = 34;
					continue;
					IL_1622:
					_003C_003E1__state = -1;
					num = 91;
					if (0 == 0)
					{
						continue;
					}
					goto case 122;
					IL_160f:
					_003C_003E1__state = -1;
					num = 100;
					continue;
					IL_15f3:
					_003C_003E1__state = -1;
					offset5 = new CvsCellLocation(2, 4);
					num = 160;
					continue;
					IL_1204:
					_003C_003E1__state = -1;
					num = 144;
					continue;
					IL_1189:
					_003C_003E1__state = -1;
					num = 95;
					if (0 == 0)
					{
						continue;
					}
					goto case 43;
					IL_110b:
					_003C_003E1__state = -1;
					offset9 = new CvsCellLocation(3, 3);
					num = 71;
					continue;
					IL_10cd:
					_003C_003E1__state = -1;
					num = 24;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 86;
					IL_0fda:
					_003C_003E1__state = -1;
					offset29 = new CvsCellLocation(3, 5);
					num = 125;
					continue;
					IL_0f70:
					_003C_003E1__state = -1;
					num = 41;
					continue;
					IL_0f37:
					_003C_003E1__state = -1;
					num = 159;
					if (true)
					{
						continue;
					}
					goto case 9;
					IL_19e6:
					if (_003CcurrentVersion_003E5__2 < 6)
					{
						num = 8;
						continue;
					}
					break;
					IL_0f24:
					_003C_003E1__state = -1;
					num = 107;
					continue;
					IL_0f05:
					_003C_003E1__state = -1;
					goto case 154;
					IL_0df5:
					_003C_003E1__state = -1;
					offset31 = new CvsCellLocation(2, 0);
					num = 45;
					continue;
					IL_0dbc:
					_003C_003E1__state = -1;
					num = 68;
					continue;
					IL_0cbe:
					_003C_003E1__state = -1;
					_003CtransPixelToWorldOffset4_003E5__4 = new CvsCellLocation(2, 7);
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 40;
					num = 20;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 88;
					IL_0bba:
					_003C_003E1__state = -1;
					num = 115;
					continue;
					IL_0b9e:
					_003C_003E1__state = -1;
					offset18 = new CvsCellLocation(4, 6);
					num = 0;
					continue;
					IL_0b8b:
					_003C_003E1__state = -1;
					num = 124;
					continue;
					IL_0b6d:
					_003C_003E1__state = -1;
					offset23 = new CvsCellLocation(3, 2);
					num = 23;
					if (true)
					{
						continue;
					}
					goto case 145;
					IL_0b48:
					_003C_003E1__state = -1;
					num = 154;
					continue;
					IL_0aff:
					_003C_003E1__state = -1;
					num = 11;
					if (0 == 0)
					{
						continue;
					}
					goto case 45;
					IL_0af3:
					num = 119;
					continue;
					IL_09b1:
					_003C_003E1__state = -1;
					offset14 = new CvsCellLocation(1, 4);
					num = 60;
					continue;
					IL_095f:
					_003C_003E1__state = -1;
					num = 120;
					continue;
					IL_085a:
					_003C_003E1__state = -1;
					num = 148;
					continue;
					IL_07f6:
					_003C_003E1__state = -1;
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, distanceToolType.I3HlsksnWs, 2, null);
					num = 13;
					continue;
					IL_0782:
					_003C_003E1__state = -1;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 115;
					IL_076f:
					_003C_003E1__state = -1;
					num = 146;
					continue;
					IL_0737:
					_003C_003E1__state = -1;
					_003CtransPixelToWorldOffset4_003E5__4 = new CvsCellLocation(3, 6);
					num = 166;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 7;
					IL_0701:
					_003C_003E1__state = -1;
					num = 161;
					continue;
					IL_06d3:
					_003C_003E1__state = -1;
					num = 39;
					continue;
					IL_05d9:
					_003C_003E1__state = -1;
					num = 153;
					continue;
					IL_056d:
					_003C_003E1__state = -1;
					offset32 = new CvsCellLocation(2, 3);
					_003C_003E2__current = new EditArgumentUpdate(offset32, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 7;
					num = 134;
					continue;
					IL_0515:
					_003C_003E1__state = -1;
					offset33 = new CvsCellLocation(2, 3);
					num = 65;
					continue;
					IL_04c6:
					_003C_003E1__state = -1;
					num = 73;
					continue;
					IL_0494:
					_003C_003E1__state = -1;
					break;
					IL_0434:
					_003C_003E1__state = -1;
					num = 79;
					continue;
					IL_0421:
					_003C_003E1__state = -1;
					num = 123;
					continue;
					IL_03bd:
					_003C_003E1__state = -1;
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, distanceToolType.kXRlK00wBb, 3, null);
					_003C_003E1__state = 29;
					num = 30;
					continue;
					IL_037d:
					_003C_003E1__state = -1;
					offset34 = new CvsCellLocation(3, 6);
					_003C_003E2__current = new EditArgumentUpdate(offset34, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 47;
					num = 128;
					continue;
					IL_0314:
					_003C_003E1__state = -1;
					num = 43;
					continue;
					IL_0301:
					_003C_003E1__state = -1;
					num = 141;
					continue;
					IL_02c1:
					_003C_003E1__state = -1;
					num = 67;
					continue;
					IL_0282:
					_003C_003E1__state = -1;
					num = 171;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 78;
					IL_0269:
					_003C_003E1__state = -1;
					num = 138;
					if (!im6vVcKHQ9d6BM9Cuase())
					{
						continue;
					}
					goto case 54;
					IL_0228:
					_003C_003E1__state = -1;
					num = 36;
					continue;
					IL_01ed:
					_003C_003E1__state = -1;
					_003C_003E2__current = new EditArgumentUpdate(_003CtransPixelToWorldOffset4_003E5__4, distanceToolType.kXRlK00wBb, 3, null);
					_003C_003E1__state = 13;
					num = 5;
					continue;
					IL_013d:
					_003C_003E1__state = -1;
					num = 179;
					continue;
					IL_0109:
					_003C_003E1__state = -1;
					goto case 154;
					IL_00b9:
					_003C_003E1__state = -1;
					offset28 = new CvsCellLocation(2, 6);
					num = 58;
					continue;
					IL_008c:
					_003C_003E1__state = -1;
					num = 37;
					if (CTkYUlKHmMcfi7f2ly0Q())
					{
						continue;
					}
					goto case 172;
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
			_003CGetUpdates_003Ed__55 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__55(0)
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
		internal static void z3q6Q0KHNxQIhrNwErvt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CTkYUlKHmMcfi7f2ly0Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool im6vVcKHQ9d6BM9Cuase()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int TCVS3PKH2dvgf1GuAEfk(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Guid dZjy0ZKHcU2W21C1yll1(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetGuid(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int bf5TDxKH1uUigZgKj5jR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SbPbevKHuFmv1WVWi5KZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PdStJdKHhdEiU4pW6f5n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Aje74nKHtgrHETqTN06n(object P_0)
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

		public static Func<EzToolType, bool> _003C_003E9__59_0;

		public static Func<EzToolType, bool> _003C_003E9__61_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			naars8KxKfDlMQsRlK7U();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			naars8KxKfDlMQsRlK7U();
			PS2wCnKx56XKlo2CqMgm(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_FindEdgeToolType_003Eb__59_0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rkMo2eKxJv5LwTYw9QNB(t.ToolType, nTv9RaKxw2NcuT1Am996());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_FindCircleToolType_003Eb__61_0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rkMo2eKxJv5LwTYw9QNB(t.ToolType, hKu6a1Kxa0BiXRu75dYw());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void naars8KxKfDlMQsRlK7U()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jgSIFjKHzP4bDckoLBnq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aAfXNpKxLepAN2hq7qax()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PS2wCnKx56XKlo2CqMgm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nTv9RaKxw2NcuT1Am996()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Kb8tdpAgrR();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rkMo2eKxJv5LwTYw9QNB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hKu6a1Kxa0BiXRu75dYw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.P4xtUtahBp();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetGraphicExpression_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CvsEditableDisplayGraphic editableGraphic;

		public DistanceToolType _003C_003E4__this;

		private string _003Cexpr_003E5__2;

		private CvsDisplayableCircle _003Ccircle_003E5__3;

		private FindCircleToolType _003CfindCircleToolType_003E5__4;

		private EzTool _003Ctool_003E5__5;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<EzTool> _003C_003Eu__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__3;

		private CvsDisplayableLine _003Cline_003E5__6;

		private FindEdgeToolType _003CfindLineToolType_003E5__7;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EIuljAKxOGUEXjKagnX7();
			int num;
			if (wHCxuWKxeQU66LduxeJ9())
			{
				num = 2;
				if (!wHCxuWKxeQU66LduxeJ9())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 6;
			}
			goto IL_0bdb;
			IL_0c39:
			_003Cexpr_003E5__2 = null;
			num = 4;
			goto IL_0bdb;
			IL_0bdb:
			string result = default;
			DistanceToolType distanceToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				default:
					num = 5;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0c39;
				case 5:
					goto IL_0c39;
				case 1:
				case 6:
					distanceToolType = _003C_003E4__this;
					num = 3;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				int num3;
				TaskAwaiter awaiter2 = default;
				TaskAwaiter<EzTool> awaiter3 = default;
				TaskAwaiter<CvsCellCollection> awaiter = default;
				CvsCellLocation cvsCellLocation2 = default;
				string text = default;
				CvsCellCollection result4 = default;
				string text5 = default;
				string text3 = default;
				string text2 = default;
				CvsCellCollection result2 = default;
				CvsCellLocation cvsCellLocation3 = default;
				string text6 = default;
				CvsDisplayableCross cvsDisplayableCross = default;
				string text4 = default;
				CvsCellLocation cvsCellLocation = default;
				switch (num2)
				{
				default:
					_003Cexpr_003E5__2 = (string)CbIRDHKxIqkd8U3UIcrF(1838);
					num3 = 65;
					goto IL_0434;
				case 2:
					awaiter2 = _003C_003Eu__1;
					num3 = 79;
					goto IL_0434;
				case 0:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 28;
					goto IL_0434;
				case 1:
					awaiter3 = _003C_003Eu__2;
					_003C_003Eu__2 = default;
					num3 = 6;
					goto IL_0434;
				case 5:
					awaiter3 = _003C_003Eu__2;
					num3 = 50;
					goto IL_0434;
				case 4:
					awaiter2 = _003C_003Eu__1;
					num3 = 84;
					if (true)
					{
						goto IL_0434;
					}
					goto IL_07bb;
				case 7:
					awaiter = _003C_003Eu__3;
					num3 = 17;
					goto IL_0434;
				case 6:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					num3 = 72;
					goto IL_0434;
				case 3:
					{
						awaiter = _003C_003Eu__3;
						num3 = 0;
						goto IL_0434;
					}
					IL_0434:
					while (true)
					{
						switch (num3)
						{
						case 50:
							_003C_003Eu__2 = default;
							num3 = 78;
							continue;
						case 65:
							if (editableGraphic is CvsDisplayablePoint)
							{
								num3 = 40;
								continue;
							}
							_003Ccircle_003E5__3 = editableGraphic as CvsDisplayableCircle;
							num3 = 69;
							continue;
						case 25:
							if (_003CfindLineToolType_003E5__7 != null)
							{
								num3 = 47;
								if (wHCxuWKxeQU66LduxeJ9())
								{
									continue;
								}
								goto case 18;
							}
							goto IL_037e;
						case 18:
						{
							EzTool result3 = awaiter3.GetResult();
							_003Ctool_003E5__5 = result3;
							num3 = 52;
							continue;
						}
						case 14:
							_003Cexpr_003E5__2 = cvsCellLocation2.ToString(absoluteRow: true, absoluteColumn: true);
							num3 = 19;
							if (wHCxuWKxeQU66LduxeJ9())
							{
								continue;
							}
							goto case 46;
						case 46:
							text = AKo8y6KxiumcxRulOTaf(_003Cline_003E5__6) as string;
							num3 = 83;
							continue;
						case 47:
							X0Rg95KxsYFb6BTPg78v(_003CfindLineToolType_003E5__7);
							awaiter2 = BGcZuKKxvysVdJqNwIJf(_003CfindLineToolType_003E5__7.SetInputImageIndexAsync(yeAHXyKxnEfNdRgdMWDn(distanceToolType)));
							num3 = 62;
							if (true)
							{
								continue;
							}
							goto case 10;
						case 10:
							if (!awaiter.IsCompleted)
							{
								num3 = 74;
								continue;
							}
							goto case 44;
						case 72:
							awaiter2.GetResult();
							num3 = 63;
							continue;
						case 64:
							result4 = awaiter.GetResult();
							num3 = 5;
							continue;
						case 2:
							return;
						case 40:
						{
							CvsCellLocation cvsCellLocation4 = pxvPUbKxDlQwKeSCmAkE(editableGraphic);
							text5 = AKo8y6KxiumcxRulOTaf(editableGraphic) as string;
							if (text5 != null)
							{
								num3 = 4;
								continue;
							}
							if (cvsCellLocation4.IsValid)
							{
								_003Cexpr_003E5__2 = cvsCellLocation4.ToString(absoluteRow: true, absoluteColumn: true);
								num3 = 24;
								continue;
							}
							goto case 24;
						}
						case 9:
							_003Cexpr_003E5__2 = text;
							num3 = 30;
							if (0 == 0)
							{
								continue;
							}
							goto case 24;
						case 68:
							_003CfindCircleToolType_003E5__4 = null;
							num3 = 58;
							continue;
						case 45:
							_003Cexpr_003E5__2 = text3;
							EIuljAKxOGUEXjKagnX7();
							if (wHCxuWKxeQU66LduxeJ9())
							{
								num3 = 54;
								if (true)
								{
									continue;
								}
								goto case 19;
							}
							num3 = 76;
							continue;
						case 82:
							text2 = ((IEnumerable<CvsEditableDisplayGraphic>)Iyk3nWKxg269rOFZ09bi(_003Ctool_003E5__5, result2, CellType.Line)).FirstOrDefault().Tag as string;
							num3 = 35;
							continue;
						case 12:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						case 57:
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							num3 = 12;
							if (0 == 0)
							{
								continue;
							}
							return;
						case 29:
							return;
						case 23:
							awaiter2 = ((Task)eq9vyaKxVDOYs3N5eRbc(_003CfindCircleToolType_003E5__4, yeAHXyKxnEfNdRgdMWDn(distanceToolType))).GetAwaiter();
							num3 = 38;
							if (0 == 0)
							{
								continue;
							}
							goto case 76;
						case 76:
						case 81:
							_003Ctool_003E5__5 = null;
							goto IL_037e;
						case 27:
							num2 = (_003C_003E1__state = 3);
							num3 = 59;
							if (wHCxuWKxeQU66LduxeJ9())
							{
								continue;
							}
							return;
						case 33:
							return;
						case 48:
							num2 = (_003C_003E1__state = -1);
							goto IL_03c8;
						case 66:
							num2 = (_003C_003E1__state = -1);
							num3 = 39;
							if (wHCxuWKxeQU66LduxeJ9())
							{
								continue;
							}
							goto case 32;
						case 32:
							if (text3 == null)
							{
								if (cvsCellLocation3.IsValid)
								{
									_003Cexpr_003E5__2 = cvsCellLocation3.ToString(absoluteRow: true, absoluteColumn: true);
									num3 = 70;
									continue;
								}
								goto case 19;
							}
							goto case 45;
						default:
							num3 = 45;
							continue;
						case 6:
							num2 = (_003C_003E1__state = -1);
							num3 = 34;
							continue;
						case 56:
							if (_003Cline_003E5__6 != null)
							{
								num3 = 20;
								if (!EIuljAKxOGUEXjKagnX7())
								{
									continue;
								}
								goto case 7;
							}
							goto case 30;
						case 7:
							_003C_003Eu__2 = awaiter3;
							num3 = 15;
							continue;
						case 34:
						{
							EzTool result3 = awaiter3.GetResult();
							_003Ctool_003E5__5 = result3;
							awaiter2 = distanceToolType.s1Ou7UoL9J(_003Ctool_003E5__5).GetAwaiter();
							if (awaiter2.IsCompleted)
							{
								goto IL_03c8;
							}
							num2 = (_003C_003E1__state = 2);
							num3 = 75;
							if (0 == 0)
							{
								continue;
							}
							goto case 21;
						}
						case 21:
							awaiter3 = _003CfindCircleToolType_003E5__4.yU6lMlvys2(_003Ccircle_003E5__3).GetAwaiter();
							num3 = 16;
							continue;
						case 85:
							text6 = AKo8y6KxiumcxRulOTaf(editableGraphic) as string;
							num3 = 41;
							continue;
						case 79:
							_003C_003Eu__1 = default;
							num3 = 48;
							if (EIuljAKxOGUEXjKagnX7())
							{
							}
							continue;
						case 36:
							num2 = (_003C_003E1__state = -1);
							num3 = 44;
							continue;
						case 62:
							if (!awaiter2.IsCompleted)
							{
								num3 = 73;
								if (EIuljAKxOGUEXjKagnX7())
								{
								}
								continue;
							}
							goto case 39;
						case 16:
							if (!awaiter3.IsCompleted)
							{
								num3 = 53;
								continue;
							}
							goto case 34;
						case 74:
							num2 = (_003C_003E1__state = 7);
							_003C_003Eu__3 = awaiter;
							num3 = 11;
							continue;
						case 53:
							num2 = (_003C_003E1__state = 1);
							num3 = 3;
							continue;
						case 84:
							_003C_003Eu__1 = default;
							num3 = 66;
							continue;
						case 17:
							_003C_003Eu__3 = default;
							num3 = 36;
							if (wHCxuWKxeQU66LduxeJ9())
							{
								continue;
							}
							goto case 73;
						case 73:
							num2 = (_003C_003E1__state = 4);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num3 = 8;
							continue;
						case 0:
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 64;
							continue;
						case 75:
							_003C_003Eu__1 = awaiter2;
							num3 = 31;
							continue;
						case 8:
							return;
						case 5:
							break;
						case 52:
							awaiter2 = BGcZuKKxvysVdJqNwIJf(distanceToolType.s1Ou7UoL9J(_003Ctool_003E5__5));
							if (!awaiter2.IsCompleted)
							{
								num3 = 37;
								continue;
							}
							goto case 72;
						case 13:
							if (awaiter3.IsCompleted)
							{
								goto case 18;
							}
							num3 = 22;
							if (true)
							{
								continue;
							}
							goto case 41;
						case 41:
							if (text6 != null)
							{
								_003Cexpr_003E5__2 = text6;
								num3 = 51;
								continue;
							}
							if (!cvsCellLocation2.IsValid)
							{
								_003CfindCircleToolType_003E5__4 = distanceToolType.zimlYZMcIp();
								num3 = 77;
								if (wHCxuWKxeQU66LduxeJ9())
								{
									continue;
								}
								goto case 12;
							}
							num3 = 14;
							if (0 == 0)
							{
								continue;
							}
							goto case 30;
						case 30:
						case 49:
						case 55:
							_003Cline_003E5__6 = null;
							num3 = 61;
							continue;
						case 38:
							if (!awaiter2.IsCompleted)
							{
								num3 = 57;
								continue;
							}
							goto IL_0b81;
						case 19:
						case 43:
						case 51:
						case 54:
						case 58:
						case 61:
						case 70:
							_003Ccircle_003E5__3 = null;
							num3 = 86;
							continue;
						case 63:
							awaiter = ((CvsCogSocketSheet)jRGR2KKxlT7bFIRgDSki(((CvsInSight)rCmUwlKxfmPlJb4NKolu(distanceToolType)).CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
							num3 = 10;
							if (wHCxuWKxeQU66LduxeJ9())
							{
								continue;
							}
							goto case 11;
						case 11:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 4:
							_003Cexpr_003E5__2 = text5;
							num3 = 60;
							if (0 == 0)
							{
								continue;
							}
							goto case 3;
						case 3:
							_003C_003Eu__2 = awaiter3;
							num3 = 26;
							continue;
						case 78:
							num2 = (_003C_003E1__state = -1);
							num3 = 18;
							continue;
						case 59:
							_003C_003Eu__3 = awaiter;
							num3 = 80;
							continue;
						case 71:
							if (cvsDisplayableCross == null)
							{
								_003Cline_003E5__6 = editableGraphic as CvsDisplayableLine;
								num3 = 56;
							}
							else
							{
								cvsCellLocation3 = pxvPUbKxDlQwKeSCmAkE(editableGraphic);
								text3 = AKo8y6KxiumcxRulOTaf(cvsDisplayableCross) as string;
								num3 = 32;
							}
							continue;
						case 42:
							if (text4 != null)
							{
								num3 = 1;
								continue;
							}
							goto IL_09fa;
						case 15:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							num3 = 33;
							if (true)
							{
								continue;
							}
							goto case 37;
						case 37:
							num2 = (_003C_003E1__state = 6);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						case 1:
							_003Cexpr_003E5__2 = text4;
							goto IL_09fa;
						case 35:
							if (text2 != null)
							{
								_003Cexpr_003E5__2 = text2;
							}
							goto case 76;
						case 31:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num3 = 2;
							continue;
						case 83:
							if (text == null)
							{
								if (cvsCellLocation.IsValid)
								{
									num3 = 67;
									if (true)
									{
										continue;
									}
									goto case 85;
								}
								_003CfindLineToolType_003E5__7 = distanceToolType.m7blnJYQHk();
								num3 = 25;
								continue;
							}
							num3 = 9;
							if (wHCxuWKxeQU66LduxeJ9())
							{
								continue;
							}
							goto case 26;
						case 26:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							num3 = 29;
							continue;
						case 69:
							if (_003Ccircle_003E5__3 == null)
							{
								cvsDisplayableCross = editableGraphic as CvsDisplayableCross;
								num3 = 71;
							}
							else
							{
								cvsCellLocation2 = pxvPUbKxDlQwKeSCmAkE(editableGraphic);
								num3 = 85;
							}
							continue;
						case 22:
							num2 = (_003C_003E1__state = 5);
							num3 = 7;
							continue;
						case 77:
							if (_003CfindCircleToolType_003E5__4 == null)
							{
								goto case 68;
							}
							_003CfindCircleToolType_003E5__4.RefreshInputImageLinks();
							num3 = 23;
							if (wHCxuWKxeQU66LduxeJ9())
							{
								continue;
							}
							goto case 67;
						case 67:
							_003Cexpr_003E5__2 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
							num3 = 55;
							continue;
						case 44:
							result2 = awaiter.GetResult();
							num3 = 82;
							continue;
						case 20:
							cvsCellLocation = pxvPUbKxDlQwKeSCmAkE(editableGraphic);
							num3 = 46;
							continue;
						case 80:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 39:
							awaiter2.GetResult();
							awaiter3 = _003CfindLineToolType_003E5__7.YBE4tPvMRf(_003Cline_003E5__6).GetAwaiter();
							num3 = 13;
							continue;
						case 28:
							num2 = (_003C_003E1__state = -1);
							goto IL_0b81;
						case 24:
						case 60:
						case 86:
							{
								result = _003Cexpr_003E5__2;
								goto end_IL_0434;
							}
							IL_09fa:
							_003Ctool_003E5__5 = null;
							num3 = 68;
							continue;
							IL_0b81:
							awaiter2.GetResult();
							num3 = 21;
							continue;
							IL_037e:
							_003CfindLineToolType_003E5__7 = null;
							num3 = 49;
							continue;
							IL_03c8:
							awaiter2.GetResult();
							awaiter = ((CvsCogSocketSheet)jRGR2KKxlT7bFIRgDSki(Fn23T1KxdQgvR4StkQZx(rCmUwlKxfmPlJb4NKolu(distanceToolType)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num3 = 27;
								continue;
							}
							goto case 64;
						}
						goto IL_07bb;
						continue;
						end_IL_0434:
						break;
					}
					break;
					IL_07bb:
					text4 = AKo8y6KxiumcxRulOTaf(((IEnumerable<CvsEditableDisplayGraphic>)Iyk3nWKxg269rOFZ09bi(_003Ctool_003E5__5, result4, CellType.Circle)).FirstOrDefault()) as string;
					num3 = 42;
					goto IL_0434;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cexpr_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0c39;
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
		internal static object CbIRDHKxIqkd8U3UIcrF(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation pxvPUbKxDlQwKeSCmAkE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AKo8y6KxiumcxRulOTaf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableGraphic)P_0).Tag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int yeAHXyKxnEfNdRgdMWDn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eq9vyaKxVDOYs3N5eRbc(object P_0, int value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).SetInputImageIndexAsync(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rCmUwlKxfmPlJb4NKolu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fn23T1KxdQgvR4StkQZx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jRGR2KKxlT7bFIRgDSki(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Iyk3nWKxg269rOFZ09bi(object P_0, object P_1, CellType reqDataType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).GetFeatures((CvsCellCollection)P_1, reqDataType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void X0Rg95KxsYFb6BTPg78v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzToolType)P_0).RefreshInputImageLinks();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter BGcZuKKxvysVdJqNwIJf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wHCxuWKxeQU66LduxeJ9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EIuljAKxOGUEXjKagnX7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid FUClVDrnVT;

	private static readonly Guid aXslLUj9s1;

	private static readonly Guid z43lJJQFNn;

	private static readonly Guid[] xV8l9tvUUO;

	private readonly PasteBuffer Qqhlr8yPDj;

	private readonly CvsCellLocation bovlhdB2Qy;

	private readonly CvsCellLocation tsJl8VdPJl;

	private readonly CvsCellLocation QsNlmaD09e;

	private readonly CvsCellLocation fG5l1OaPT4;

	private readonly PasteBuffer HO2lzZ4F0R;

	private readonly CvsCellLocation ldCTas6Lfe;

	private readonly CvsCellLocation LrpT52OHjv;

	private readonly CvsCellLocation oFuTpy8gxw;

	private readonly CvsCellLocation IcmTUUJNMf;

	private readonly PasteBuffer Q3QT7IZMpf;

	private readonly CvsCellLocation hSGTNr8LhO;

	private readonly CvsCellLocation AfKTAe6CgK;

	private readonly CvsCellLocation eQPTdVG7JC;

	private readonly CvsCellLocation SXgT61Ttqt;

	private FindCircleToolType wYZTuSfR3j;

	private FindEdgeToolType F28TFj1Z2i;

	private CvsEditableDisplayGraphic H9KTXltpFd;

	private CvsEditableDisplayGraphic XjbTo37kdL;

	private PointF GGCTSVN6OO;

	private int z9lTDXulZ3;

	private CvsEditableDisplayGraphic[] bTUT3D57Ym;

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GGCTSVN6OO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GGCTSVN6OO = value;
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
			return xV8l9tvUUO;
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
			return (string)SpaK0x6VFEfxxxveTCP();
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
			return Resources.mYWVwkQSdi();
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
			return XAMLGraphicKeys.Tools_DistanceIcon;
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
			return XAMLGraphicKeys.Tools_DistanceIcon;
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
				(string)NxXZf76fNAsn5ROvK1d()
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
			return z9lTDXulZ3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref z9lTDXulZ3, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DistanceToolType()
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
			case 4:
				eQPTdVG7JC = Q3QT7IZMpf.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(21622));
				num = 13;
				break;
			case 7:
				IcmTUUJNMf = HO2lzZ4F0R.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(26158));
				num = 12;
				if (TQ9brn6wfJ6wgkhyXP1())
				{
					break;
				}
				goto case 12;
			case 12:
				Q3QT7IZMpf = PasteBuffer.FromBytes((byte[])lGI7mn6iUpwqcD5UyPw());
				num = 14;
				break;
			case 9:
				AddSnippet(Q3QT7IZMpf);
				num = 19;
				break;
			case 10:
				base._002Ector();
				Qqhlr8yPDj = PasteBuffer.FromBytes((byte[])Gei6t26eslCkXIL3lZ4());
				num = 8;
				break;
			case 15:
			case 16:
				AddSnippet(Qqhlr8yPDj);
				AddSnippet(HO2lzZ4F0R);
				num = 9;
				break;
			case 14:
				hSGTNr8LhO = Q3QT7IZMpf.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(4928));
				num = 18;
				break;
			case 0:
				PhuWWe6aarPCJK9KqpM();
				num = 11;
				break;
			case 13:
				SXgT61Ttqt = Q3QT7IZMpf.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(26158));
				goto case 15;
			case 17:
				HO2lzZ4F0R = (PasteBuffer)rqjeLS6DP8lJfWk9lCj(PoFmJB6IXyYZPgPhuXA());
				num = 3;
				break;
			case 11:
				GGCTSVN6OO = PointF.Empty;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				bovlhdB2Qy = Qqhlr8yPDj.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928));
				_ = 1;
				if (jioAEW6J6sacYXLCIhq())
				{
					num = 16;
					break;
				}
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				tsJl8VdPJl = Qqhlr8yPDj.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(26106));
				QsNlmaD09e = Qqhlr8yPDj.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(26132));
				fG5l1OaPT4 = Qqhlr8yPDj.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(26158));
				num = 17;
				break;
			case 2:
				LrpT52OHjv = HO2lzZ4F0R.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(26178));
				oFuTpy8gxw = HO2lzZ4F0R.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(26202));
				goto case 7;
			default:
				num = 7;
				if (!jioAEW6J6sacYXLCIhq())
				{
					break;
				}
				goto case 18;
			case 18:
				AfKTAe6CgK = Q3QT7IZMpf.GetCellOffset((string)tll0ju6Oj79r29Y9XrD(21598));
				num = 4;
				break;
			case 6:
				z9lTDXulZ3 = 200;
				num = 10;
				break;
			case 3:
				ldCTas6Lfe = HO2lzZ4F0R.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928));
				num = 2;
				break;
			case 19:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnGraphicChanged_003Ed__22))]
	public Task OnGraphicChanged(object sender, CvsEditEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!TQ9brn6wfJ6wgkhyXP1())
		{
			goto IL_001e;
		}
		goto IL_0068;
		IL_001e:
		_003COnGraphicChanged_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = Pi22Zp6nripk2uUieN3();
		num = 6;
		goto IL_0068;
		IL_0068:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 1:
				stateMachine.e = e;
				goto default;
			default:
				TQ9brn6wfJ6wgkhyXP1();
				if (jioAEW6J6sacYXLCIhq())
				{
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				}
				num = 2;
				if (!jioAEW6J6sacYXLCIhq())
				{
					continue;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetDisplayGraphics_003Ed__23))]
	public Task SetDisplayGraphics(CvsEditableDisplayGraphic graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		jioAEW6J6sacYXLCIhq();
		int num;
		if (TQ9brn6wfJ6wgkhyXP1())
		{
			num = 5;
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_00ab;
			}
		}
		goto IL_0062;
		IL_0062:
		_003CSetDisplayGraphics_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				if (jioAEW6J6sacYXLCIhq())
				{
				}
				continue;
			case 2:
			case 6:
				stateMachine.graphic = graphic;
				goto case 4;
			default:
				num = 4;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 3:
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_00ab;
		IL_00ab:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		if (jioAEW6J6sacYXLCIhq())
		{
		}
		goto IL_0062;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__48))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__48 stateMachine = default;
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
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__49))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003COnBeginAddInternal_003Ed__49 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (TQ9brn6wfJ6wgkhyXP1())
				{
					num = 0;
					break;
				}
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = Pi22Zp6nripk2uUieN3();
				num = 1;
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
		int num = 1;
		CvsEditableDisplayGraphic[] source = default;
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			CvsEditableDisplayGraphic[] array;
			switch (num)
			{
			case 0:
				array = Array.Empty<CvsEditableDisplayGraphic>();
				goto IL_001d;
			case 2:
			case 4:
				FireAddGraphicsChanged(source.ToList(), list);
				break;
			case 1:
				array = bTUT3D57Ym;
				if (array == null)
				{
					num = 0;
					continue;
				}
				goto IL_001d;
			case 6:
				return;
				IL_001d:
				source = array;
				list = v3TlPDYNXl();
				_ = 1;
				if (!jioAEW6J6sacYXLCIhq())
				{
					num = 4;
					continue;
				}
				num = 5;
				if (jioAEW6J6sacYXLCIhq())
				{
				}
				continue;
			}
			bTUT3D57Ym = (CvsEditableDisplayGraphic[])E7inpc6d1jCmqGUvkGS(list);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<CvsEditableDisplayGraphic> v3TlPDYNXl()
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
			FeatureExtractor featureExtractor = new FeatureExtractor();
			if (m7blnJYQHk() != null && m7blnJYQHk().IsTypeEnabled)
			{
				list2 = featureExtractor.FindLines(image);
			}
			List<CvsEditableDisplayGraphic> list3 = new List<CvsEditableDisplayGraphic>();
			if (zimlYZMcIp() != null && zimlYZMcIp().IsTypeEnabled)
			{
				list3 = featureExtractor.FindCircles(image);
			}
			List<CvsEditableDisplayGraphic> list4 = new List<CvsEditableDisplayGraphic>();
			List<CvsEditableDisplayGraphic> list5 = new List<CvsEditableDisplayGraphic>();
			foreach (EzSnippet snippet in Inspect.Snippets)
			{
				CvsEditableDisplayGraphic[] features = snippet.GetFeatures(Inspect.InSight.Results.Cells, CellType.Point);
				foreach (CvsEditableDisplayGraphic cvsEditableDisplayGraphic in features)
				{
					list5.Add(cvsEditableDisplayGraphic);
					if (!(cvsEditableDisplayGraphic is CvsDisplayableCircle cvsDisplayableCircle))
					{
						continue;
					}
					for (int num = list3.Count - 1; num >= 0; num--)
					{
						if (FeatureExtractor.aPFpSTLwg(list3[num] as CvsDisplayableCircle, cvsDisplayableCircle))
						{
							list3.RemoveAt(num);
						}
					}
				}
				features = snippet.GetFeatures(Inspect.InSight.Results.Cells, CellType.Line);
				foreach (CvsEditableDisplayGraphic cvsEditableDisplayGraphic2 in features)
				{
					list4.Add(cvsEditableDisplayGraphic2);
					if (!(cvsEditableDisplayGraphic2 is CvsDisplayableLine line))
					{
						continue;
					}
					for (int num2 = list2.Count - 1; num2 >= 0; num2--)
					{
						if (FeatureExtractor.LinesAreSimilar(list2[num2] as CvsDisplayableLine, line))
						{
							list2.RemoveAt(num2);
						}
					}
				}
			}
			list.AddRange(list4.ToArray());
			list.AddRange(list5.ToArray());
			list.AddRange(list2.ToArray());
			list.AddRange(list3.ToArray());
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
		return bTUT3D57Ym;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__54))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__54 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__55))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__55(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string I3HlsksnWs(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)VnO0YG6lpAALKYRddYa(CdQUGaROfy7He9T0foW.KbIzwHEDLa(26224), SnippetUpdateHelper.InputImageLocationFactory(P_0), tll0ju6Oj79r29Y9XrD(6970));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string kXRlK00wBb(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)VnO0YG6lpAALKYRddYa(tll0ju6Oj79r29Y9XrD(26246), SnippetUpdateHelper.InputImageLocationFactory(P_0), CdQUGaROfy7He9T0foW.KbIzwHEDLa(6970));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private FindEdgeToolType m7blnJYQHk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (F28TFj1Z2i == null)
		{
			F28TFj1Z2i = ((IEnumerable<EzToolType>)uBTbW16sVOEcmrHxN9H(bb871d6gJLkvaKNq00N(this))).FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType t) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec.rkMo2eKxJv5LwTYw9QNB(t.ToolType, _003C_003Ec.nTv9RaKxw2NcuT1Am996());
			}) as FindEdgeToolType;
		}
		return F28TFj1Z2i;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private FindCircleToolType zimlYZMcIp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (wYZTuSfR3j == null)
		{
			wYZTuSfR3j = ((InspectStepViewModel)bb871d6gJLkvaKNq00N(this)).ToolTypes.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType t) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec.rkMo2eKxJv5LwTYw9QNB(t.ToolType, _003C_003Ec.hKu6a1Kxa0BiXRu75dYw());
			}) as FindCircleToolType;
		}
		return wYZTuSfR3j;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GsblGSpy7C(CvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !(P_0 is CvsDisplayableLine);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGraphicExpression_003Ed__63))]
	public Task<string> GetGraphicExpression(CvsEditableDisplayGraphic editableGraphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetGraphicExpression_003Ed__63 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editableGraphic = editableGraphic;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DistanceToolType()
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
				PhuWWe6aarPCJK9KqpM();
				_ = 1;
				if (!jioAEW6J6sacYXLCIhq())
				{
					num = 0;
					if (true)
					{
						break;
					}
					goto default;
				}
				num = 5;
				break;
			default:
				z43lJJQFNn = new Guid((string)tll0ju6Oj79r29Y9XrD(26422));
				num = 4;
				break;
			case 6:
				aXslLUj9s1 = new Guid((string)tll0ju6Oj79r29Y9XrD(26346));
				goto default;
			case 4:
				xV8l9tvUUO = new Guid[3] { FUClVDrnVT, aXslLUj9s1, z43lJJQFNn };
				num = 7;
				break;
			case 0:
			case 1:
				FUClVDrnVT = new Guid((string)tll0ju6Oj79r29Y9XrD(26270));
				num = 6;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task F2RlBbWTbD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PhuWWe6aarPCJK9KqpM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Gei6t26eslCkXIL3lZ4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.PointToPointDistance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tll0ju6Oj79r29Y9XrD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PoFmJB6IXyYZPgPhuXA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.PointToLineDistance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rqjeLS6DP8lJfWk9lCj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lGI7mn6iUpwqcD5UyPw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.LineToLineDistance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TQ9brn6wfJ6wgkhyXP1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jioAEW6J6sacYXLCIhq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Pi22Zp6nripk2uUieN3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SpaK0x6VFEfxxxveTCP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ddqVOevaSZ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NxXZf76fNAsn5ROvK1d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.aArVeOJEQe();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E7inpc6d1jCmqGUvkGS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VnO0YG6lpAALKYRddYa(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bb871d6gJLkvaKNq00N(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uBTbW16sVOEcmrHxN9H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InspectStepViewModel)P_0).ToolTypes;
	}
}
