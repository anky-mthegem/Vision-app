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
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindEdge;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using oF2MOjpuTE9ryB96aX;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.LineToLineAngle;

[Export(typeof(EzToolType))]
public class LineToLineAngleToolType : EzToolType, IGraphicToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnGraphicChanged_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LineToLineAngleToolType _003C_003E4__this;

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
			int num;
			if (CaGdX5KywStgB7Xu1v30())
			{
				num = 2;
			}
			else
			{
				num = 1;
				if (false)
				{
					goto IL_01ba;
				}
			}
			goto IL_0187;
			IL_0187:
			LineToLineAngleToolType lineToLineAngleToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					lineToLineAngleToolType = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = bnP7QDKyafNtdrbfDiHs(lineToLineAngleToolType.SetDisplayGraphics(e.Value as CvsEditableDisplayGraphic));
							num3 = 3;
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
							case 0:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									xpx9baKyJCHxFxflibka();
									num3 = ((!CaGdX5KywStgB7Xu1v30()) ? 5 : 8);
									continue;
								}
								break;
							case 7:
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
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
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
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
			goto IL_01ba;
			IL_01ba:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0187;
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
		internal static TaskAwaiter bnP7QDKyafNtdrbfDiHs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CaGdX5KywStgB7Xu1v30()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xpx9baKyJCHxFxflibka()
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

		public LineToLineAngleToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PhELK9KyO8K2ba3xamHT();
			int num;
			if (MJvSGsKyecYMuXI1MKZL())
			{
				num = 2;
				if (!MJvSGsKyecYMuXI1MKZL())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_02c4;
			IL_02ef:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02c4;
			IL_02c4:
			int num2 = default;
			LineToLineAngleToolType lineToLineAngleToolType = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_02ef;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					lineToLineAngleToolType = _003C_003E4__this;
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				int num3;
				if (num2 != 0)
				{
					if (graphic != null)
					{
						num3 = 4;
					}
					else
					{
						lineToLineAngleToolType.tAuMtsiSNf = null;
						num3 = 16;
					}
					goto IL_00a2;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default;
				goto IL_00f5;
				IL_00a2:
				CvsDisplayableLine cvsDisplayableLine = default;
				while (true)
				{
					switch (num3)
					{
					case 10:
						lineToLineAngleToolType.Center = PointF.Empty;
						awaiter = d8mEFlKyDmSFpJSPP4Ka(LXCLUqKyIOniD6UZ1N88(lineToLineAngleToolType.AcceptAddCommand));
						if (!awaiter.IsCompleted)
						{
							num3 = 11;
							continue;
						}
						goto IL_010a;
					case 2:
					case 6:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 3;
						continue;
					case 8:
					case 9:
						break;
					case 1:
						goto IL_010a;
					case 11:
						num2 = (_003C_003E1__state = 0);
						PhELK9KyO8K2ba3xamHT();
						if (MJvSGsKyecYMuXI1MKZL())
						{
							num3 = 2;
							continue;
						}
						num3 = 9;
						if (MJvSGsKyecYMuXI1MKZL())
						{
							continue;
						}
						goto case 12;
					case 7:
					case 15:
						cvsDisplayableLine = graphic as CvsDisplayableLine;
						num3 = 0;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						if (cvsDisplayableLine != null)
						{
							num3 = 12;
							continue;
						}
						goto end_IL_002e;
					case 3:
						return;
					case 12:
						lineToLineAngleToolType.Center = new PointF((((CvsGraphicLine)D4YgUYKyic0DQEIPaI0i(cvsDisplayableLine)).StartPoint.X + siiFOnKyn22ixyvQWUZx(D4YgUYKyic0DQEIPaI0i(cvsDisplayableLine)).X) / 2f, (((CvsGraphicLine)D4YgUYKyic0DQEIPaI0i(cvsDisplayableLine)).StartPoint.Y + siiFOnKyn22ixyvQWUZx(cvsDisplayableLine.Line).Y) / 2f);
						num3 = 13;
						continue;
					case 5:
						lineToLineAngleToolType.OQhMYGw8QL = graphic;
						num3 = 10;
						continue;
					case 14:
						lineToLineAngleToolType.tAuMtsiSNf = graphic;
						num3 = 7;
						continue;
					case 4:
						if (lineToLineAngleToolType.tAuMtsiSNf == null)
						{
							num3 = 14;
							continue;
						}
						if (lineToLineAngleToolType.tAuMtsiSNf != graphic)
						{
							num3 = 5;
							continue;
						}
						goto case 7;
					case 13:
						goto end_IL_002e;
					case 16:
						lineToLineAngleToolType.Center = PointF.Empty;
						goto end_IL_002e;
					}
					break;
				}
				goto IL_00f5;
				IL_00f5:
				num2 = (_003C_003E1__state = -1);
				num3 = 1;
				if (0 == 0)
				{
					goto IL_00a2;
				}
				goto IL_010a;
				IL_010a:
				awaiter.GetResult();
				num3 = 15;
				goto IL_00a2;
				end_IL_002e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_02ef;
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
		internal static object LXCLUqKyIOniD6UZ1N88(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter d8mEFlKyDmSFpJSPP4Ka(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D4YgUYKyic0DQEIPaI0i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableLine)P_0).Line;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF siiFOnKyn22ixyvQWUZx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).EndPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MJvSGsKyecYMuXI1MKZL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PhELK9KyO8K2ba3xamHT()
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

		public LineToLineAngleToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private LineToLineAngleTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			LineToLineAngleToolType lineToLineAngleToolType = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					lineToLineAngleToolType = _003C_003E4__this;
					xDOM1jKyfACKPvZHtq98();
					if (x9EBVmKyVhOUZiDE79EB())
					{
						num = 0;
						break;
					}
					num = 1;
					if (true)
					{
						break;
					}
					goto default;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (!guid.Equals(A2QMsn1bkW))
							{
								throw new NotImplementedException();
							}
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 4:
								result = _003Ctool_003E5__2;
								num3 = 12;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								if (!xDOM1jKyfACKPvZHtq98())
								{
									continue;
								}
								goto case 2;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 5:
								return;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 11:
								awaiter.GetResult();
								num3 = 4;
								continue;
							case 1:
							case 10:
								awaiter = m5aDI5Kygi8AsmcHAxjB(x3IqwyKylOOyOteDMfUH(_003Ctool_003E5__2, cells, cellRange));
								if (!awaiter.IsCompleted)
								{
									goto case 2;
								}
								goto case 11;
							case 3:
								_003Ctool_003E5__2 = new LineToLineAngleTool((InspectStepViewModel)LIrBmlKydcJdcrKv1iCq(lineToLineAngleToolType), isInitialized: true);
								xDOM1jKyfACKPvZHtq98();
								num3 = (x9EBVmKyVhOUZiDE79EB() ? 10 : 6);
								continue;
							case 12:
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
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
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
		internal static object LIrBmlKydcJdcrKv1iCq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x3IqwyKylOOyOteDMfUH(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter m5aDI5Kygi8AsmcHAxjB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x9EBVmKyVhOUZiDE79EB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xDOM1jKyfACKPvZHtq98()
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

		public LineToLineAngleToolType _003C_003E4__this;

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
			LineToLineAngleToolType lineToLineAngleToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
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
							lineToLineAngleToolType.tAuMtsiSNf = null;
							num3 = 1;
							if (hGBUg8Kyvi5S6DcKLYCl())
							{
								goto IL_004c;
							}
							goto IL_011a;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0078;
						IL_011a:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 8:
							case 10:
								goto IL_0078;
							case 2:
								if (!awaiter.IsCompleted)
								{
									hGBUg8Kyvi5S6DcKLYCl();
									if (M4TSIxKysXTdGfD5euLL())
									{
										num3 = 5;
										continue;
									}
									num3 = 10;
									if (M4TSIxKysXTdGfD5euLL())
									{
										continue;
									}
									goto case 4;
								}
								goto case 12;
							case 1:
								lineToLineAngleToolType.OQhMYGw8QL = null;
								num3 = 3;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 0:
								return;
							case 4:
							case 5:
								num2 = (_003C_003E1__state = 0);
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter = QNkYDgKyPhqjF2N0pR1O(lineToLineAngleToolType.TsYMq4Fjqv());
								num3 = 2;
								continue;
							case 12:
								awaiter.GetResult();
								goto end_IL_002f;
							}
							break;
						}
						goto IL_004c;
						IL_0078:
						_003C_003Eu__1 = default;
						num3 = 11;
						goto IL_011a;
						IL_004c:
						lineToLineAngleToolType.Center = PointF.Empty;
						lineToLineAngleToolType.hu8MLKmHnp = (CvsEditableDisplayGraphic[])THm25mKyrL4aVXa4nbXB(lineToLineAngleToolType.PlSMe708m8());
						num3 = 9;
						if (hGBUg8Kyvi5S6DcKLYCl())
						{
							goto IL_0078;
						}
						goto IL_011a;
						end_IL_002f:;
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
				case 1:
				case 3:
					lineToLineAngleToolType = _003C_003E4__this;
					goto case 0;
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!hGBUg8Kyvi5S6DcKLYCl()) ? 3 : 0);
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
		internal static object THm25mKyrL4aVXa4nbXB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter QNkYDgKyPhqjF2N0pR1O(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M4TSIxKysXTdGfD5euLL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hGBUg8Kyvi5S6DcKLYCl()
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

		public LineToLineAngleToolType _003C_003E4__this;

		private string _003Cexpr0_003E5__2;

		private string _003Cexpr1_003E5__3;

		private CvsCogSocketSheet _003Csheet_003E5__4;

		private CvsCellRange _003CpasteRange_003E5__5;

		private TaskAwaiter<string> _003C_003Eu__1;

		private object _003C_003E7__wrap5;

		private LineToLineAngleTool _003Ctool_003E5__7;

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
			int num = 6;
			if (!SAYL8qKyZrCgsjsKIpbi())
			{
				goto IL_001e;
			}
			goto IL_0a46;
			IL_001e:
			_003Csheet_003E5__4 = null;
			num = 3;
			if (false)
			{
				goto IL_0031;
			}
			goto IL_0a46;
			IL_0a46:
			EzTool result = default;
			LineToLineAngleToolType lineToLineAngleToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
				case 7:
					break;
				case 0:
				case 2:
					goto IL_0031;
				case 8:
					_003Cexpr1_003E5__3 = null;
					break;
				case 6:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 9;
					continue;
				case 4:
					_003Cexpr0_003E5__2 = null;
					goto case 8;
				default:
					num = 8;
					continue;
				case 1:
					lineToLineAngleToolType = _003C_003E4__this;
					_ = 1;
					if (n09J8FKyBl1QJ6WGEL3q())
					{
						num = 7;
						if (true)
						{
							continue;
						}
						goto case 6;
					}
					num = 0;
					continue;
				case 9:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_0031:
			try
			{
				TaskAwaiter<string> awaiter2;
				TaskAwaiter awaiter = default;
				string result2;
				int num3;
				switch (num2)
				{
				default:
					BhpAtLKybViT59EeFPY8(lineToLineAngleToolType.tAuMtsiSNf);
					awaiter2 = lineToLineAngleToolType.FUAM2LUBk1(lineToLineAngleToolType.tAuMtsiSNf).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00cf;
				case 0:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_00cf;
				case 1:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_014a;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
					try
					{
						int num4;
						TaskAwaiter<object> awaiter5 = default;
						TaskAwaiter<CvsCellCollection> awaiter4 = default;
						TaskAwaiter<CvsCellRange> awaiter3 = default;
						CvsCellRange result5 = default;
						CvsCellCollection result4 = default;
						CvsCellCollection result3 = default;
						switch (num2)
						{
						default:
							num4 = 33;
							goto IL_051a;
						case 5:
							awaiter5 = _003C_003Eu__4;
							num4 = 2;
							goto IL_051a;
						case 9:
							awaiter = _003C_003Eu__5;
							_003C_003Eu__5 = default;
							num4 = 34;
							goto IL_051a;
						case 7:
							awaiter4 = _003C_003Eu__2;
							num4 = 44;
							goto IL_051a;
						case 4:
							awaiter5 = _003C_003Eu__4;
							num4 = 7;
							if (1 == 0)
							{
								goto IL_037b;
							}
							goto IL_051a;
						case 6:
							awaiter5 = _003C_003Eu__4;
							num4 = 4;
							if (1 == 0)
							{
								goto IL_0428;
							}
							goto IL_051a;
						case 2:
							awaiter4 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							num4 = 17;
							goto IL_051a;
						case 3:
							awaiter3 = _003C_003Eu__3;
							num4 = 26;
							goto IL_051a;
						case 8:
							{
								awaiter = _003C_003Eu__5;
								num4 = 32;
								if (true)
								{
									goto IL_051a;
								}
								goto IL_08a8;
							}
							IL_051a:
							while (true)
							{
								switch (num4)
								{
								case 27:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									return;
								case 19:
									awaiter5 = _003Csheet_003E5__4.PutCellExpressionAsync(lineToLineAngleToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, lineToLineAngleToolType.H0qMBN1lX2), _003Cexpr0_003E5__2).GetAwaiter();
									goto case 5;
								case 23:
									num2 = (_003C_003E1__state = 5);
									num4 = 10;
									continue;
								case 49:
									return;
								case 10:
									_003C_003Eu__4 = awaiter5;
									num4 = 27;
									continue;
								case 7:
									_003C_003Eu__4 = default;
									num4 = 25;
									continue;
								case 33:
									awaiter4 = ((CvsCogSocketSheet)YsXCvRKykjT7xmjD71od(awxN0HKySMa2ZK0AlEgZ(CSb4ZPKyoTGfbqJipwx2(eu2hwcKyGc7LSLUGEclg(lineToLineAngleToolType))))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
									num4 = 43;
									if (true)
									{
										continue;
									}
									goto case 44;
								case 44:
									_003C_003Eu__2 = default;
									num4 = 16;
									continue;
								case 16:
									num2 = (_003C_003E1__state = -1);
									num4 = 0;
									continue;
								case 45:
									_003C_003Eu__2 = awaiter4;
									num4 = 20;
									continue;
								case 29:
									awaiter = TCBHi3KypVTLfLg84ACr(M6WZUNKyX1g0y0fhoHTe(_003Ctool_003E5__7));
									if (!awaiter.IsCompleted)
									{
										num4 = 15;
										continue;
									}
									goto case 39;
								case 8:
									_003C_003Eu__2 = awaiter4;
									num4 = 12;
									if (SAYL8qKyZrCgsjsKIpbi())
									{
										continue;
									}
									return;
								case 48:
									return;
								case 35:
									num2 = (_003C_003E1__state = 6);
									num4 = 31;
									continue;
								case 47:
									_003C_003Eu__4 = awaiter5;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									return;
								case 4:
									break;
								case 52:
									if (!awaiter3.IsCompleted)
									{
										num4 = 38;
										continue;
									}
									goto IL_04e0;
								case 32:
									_003C_003Eu__5 = default;
									num4 = 53;
									if (0 == 0)
									{
										continue;
									}
									goto case 24;
								case 24:
									_003CpasteRange_003E5__5 = result5;
									num4 = 46;
									continue;
								case 14:
									if (!awaiter4.IsCompleted)
									{
										num2 = (_003C_003E1__state = 7);
										num4 = 45;
										continue;
									}
									goto case 0;
								case 31:
									_003C_003Eu__4 = awaiter5;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									return;
								case 15:
									goto IL_0428;
								case 37:
									num2 = (_003C_003E1__state = 2);
									num4 = 8;
									continue;
								case 51:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num4 = 13;
									continue;
								case 22:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 49;
									continue;
								case 12:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									return;
								case 43:
									if (!awaiter4.IsCompleted)
									{
										num4 = 37;
										continue;
									}
									goto case 17;
								case 18:
									num2 = (_003C_003E1__state = -1);
									goto IL_04e0;
								case 2:
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									goto case 28;
								default:
									num4 = 28;
									if (SAYL8qKyZrCgsjsKIpbi())
									{
										continue;
									}
									goto case 6;
								case 6:
								case 11:
									_003CpasteRange_003E5__5 = CvsCellRange.Empty;
									awaiter3 = lineToLineAngleToolType.RenameAndPasteTool(lineToLineAngleToolType._pasteObject, result4, runSheet: false).GetAwaiter();
									num4 = 52;
									continue;
								case 34:
									num2 = (_003C_003E1__state = -1);
									num4 = 39;
									continue;
								case 38:
									num2 = (_003C_003E1__state = 3);
									num4 = 41;
									if (true)
									{
										continue;
									}
									goto case 28;
								case 28:
									awaiter5.GetResult();
									num4 = 3;
									if (SAYL8qKyZrCgsjsKIpbi())
									{
										continue;
									}
									return;
								case 13:
									return;
								case 9:
									_003C_003Eu__5 = awaiter;
									num4 = 30;
									continue;
								case 36:
									awaiter.GetResult();
									num4 = 29;
									continue;
								case 20:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num4 = 48;
									continue;
								case 17:
									result4 = awaiter4.GetResult();
									_ = 0;
									if (!SAYL8qKyZrCgsjsKIpbi())
									{
										num4 = 5;
										if (0 == 0)
										{
											continue;
										}
										goto case 23;
									}
									num4 = 11;
									continue;
								case 26:
									_003C_003Eu__3 = default;
									num4 = 18;
									continue;
								case 3:
									awaiter5 = _003Csheet_003E5__4.PutCellExpressionAsync(lineToLineAngleToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, lineToLineAngleToolType.cc5MZLyvWZ), _003Cexpr1_003E5__3).GetAwaiter();
									num4 = 1;
									continue;
								case 41:
									_003C_003Eu__3 = awaiter3;
									num4 = 51;
									if (true)
									{
										continue;
									}
									goto case 46;
								case 46:
									awaiter5 = _003Csheet_003E5__4.PutCellExpressionAsync(lineToLineAngleToolType.GetCellLocation(_003CpasteRange_003E5__5.Location, lineToLineAngleToolType.uRZMGjnani), (string)a71YgiKyqdRjkYSUqnNT(lineToLineAngleToolType.InputImageLinks[QZVRV6Ky8B1g8NGaPEPh(lineToLineAngleToolType)])).GetAwaiter();
									if (!awaiter5.IsCompleted)
									{
										num4 = 50;
										if (0 == 0)
										{
											continue;
										}
										goto case 0;
									}
									goto IL_085c;
								case 0:
									result3 = awaiter4.GetResult();
									num4 = 40;
									continue;
								case 53:
									num2 = (_003C_003E1__state = -1);
									num4 = 36;
									continue;
								case 40:
									_003Ctool_003E5__7 = new LineToLineAngleTool((InspectStepViewModel)eu2hwcKyGc7LSLUGEclg(lineToLineAngleToolType), isInitialized: false);
									awaiter = TCBHi3KypVTLfLg84ACr(lMD1jZKyEr5GoEQe34hA(_003Ctool_003E5__7, result3, _003CpasteRange_003E5__5));
									if (awaiter.IsCompleted)
									{
										goto case 36;
									}
									num2 = (_003C_003E1__state = 8);
									num4 = 9;
									if (true)
									{
										continue;
									}
									goto case 5;
								case 5:
								case 21:
									if (!awaiter5.IsCompleted)
									{
										num4 = 23;
										continue;
									}
									goto case 28;
								case 50:
									num2 = (_003C_003E1__state = 4);
									num4 = 47;
									continue;
								case 1:
									if (!awaiter5.IsCompleted)
									{
										num4 = 35;
										continue;
									}
									goto IL_08a8;
								case 25:
									num2 = (_003C_003E1__state = -1);
									goto IL_085c;
								case 39:
									awaiter.GetResult();
									num4 = 54;
									continue;
								case 30:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 42:
									goto IL_08a8;
								case 54:
									{
										result = _003Ctool_003E5__7;
										goto end_IL_0186;
									}
									IL_085c:
									awaiter5.GetResult();
									num4 = 19;
									if (true)
									{
										continue;
									}
									goto case 39;
									IL_04e0:
									result5 = awaiter3.GetResult();
									num4 = 24;
									continue;
								}
								break;
							}
							goto IL_037b;
							IL_08a8:
							awaiter5.GetResult();
							awaiter4 = _003Csheet_003E5__4.RunAndGetCellResults().GetAwaiter();
							num4 = 14;
							goto IL_051a;
							IL_0428:
							num2 = (_003C_003E1__state = 9);
							_003C_003Eu__5 = awaiter;
							num4 = 22;
							goto IL_051a;
							IL_037b:
							_003C_003Eu__4 = default;
							num2 = (_003C_003E1__state = -1);
							num4 = 42;
							goto IL_051a;
							end_IL_0186:
							break;
						}
					}
					catch (object obj)
					{
						_003C_003E7__wrap5 = obj;
						num3 = 1;
						goto IL_08eb;
					}
					goto end_IL_0031;
				case 10:
					{
						awaiter = _003C_003Eu__5;
						_003C_003Eu__5 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0954;
					}
					IL_08eb:
					if (num3 != 1)
					{
						break;
					}
					awaiter = lineToLineAngleToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 10);
						_003C_003Eu__5 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0954;
					IL_00cf:
					result2 = awaiter2.GetResult();
					_003Cexpr0_003E5__2 = result2;
					DistanceToolType.GsblGSpy7C(lineToLineAngleToolType.OQhMYGw8QL);
					awaiter2 = lineToLineAngleToolType.FUAM2LUBk1(lineToLineAngleToolType.OQhMYGw8QL).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num2 = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_014a;
					IL_0954:
					awaiter.GetResult();
					VQyRd2Ky4W4e7fD9B8vZ(pDmaOYKy99VPYB2lXXLq((_003C_003E7__wrap5 as Exception) ?? throw _003C_003E7__wrap5));
					break;
					IL_014a:
					result2 = awaiter2.GetResult();
					_003Cexpr1_003E5__3 = result2;
					_003Csheet_003E5__4 = ((CvsCogSocket)awxN0HKySMa2ZK0AlEgZ(CSb4ZPKyoTGfbqJipwx2(eu2hwcKyGc7LSLUGEclg(lineToLineAngleToolType)))).Sheet;
					_003CpasteRange_003E5__5 = CvsCellRange.Empty;
					num3 = 0;
					goto case 2;
				}
				_003C_003E7__wrap5 = null;
				_003Cexpr0_003E5__2 = null;
				_003Cexpr1_003E5__3 = null;
				_003Csheet_003E5__4 = null;
				_003CpasteRange_003E5__5 = default;
				end_IL_0031:;
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
			num = 4;
			goto IL_0a46;
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
		internal static bool BhpAtLKybViT59EeFPY8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DistanceToolType.GsblGSpy7C((CvsEditableDisplayGraphic)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eu2hwcKyGc7LSLUGEclg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CSb4ZPKyoTGfbqJipwx2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object awxN0HKySMa2ZK0AlEgZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YsXCvRKykjT7xmjD71od(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int QZVRV6Ky8B1g8NGaPEPh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a71YgiKyqdRjkYSUqnNT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lMD1jZKyEr5GoEQe34hA(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter TCBHi3KypVTLfLg84ACr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M6WZUNKyX1g0y0fhoHTe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzRangeTool<EditFloatViewModel>)P_0).OnSetRange();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pDmaOYKy99VPYB2lXXLq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VQyRd2Ky4W4e7fD9B8vZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SAYL8qKyZrCgsjsKIpbi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n09J8FKyBl1QJ6WGEL3q()
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

		public LineToLineAngleToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__40(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (WFF3scKy7hBtvBQe347V())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_00a1;
				}
			}
			goto IL_003d;
			IL_003d:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					this._003C_003E1__state = _003C_003E1__state;
					goto case 4;
				default:
					num = 4;
					if (pLAED9Ky3641npVs1k5O())
					{
					}
					continue;
				case 4:
					_003C_003El__initialThreadId = oct6njKyCDAPoIS69xnq();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
					rwdlPLKy6bbYycLpUVvC(this);
					goto case 2;
				case 0:
				case 5:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_00a1;
			IL_00a1:
			RBbuo7KyjmEJiSHt2nKV();
			num = 1;
			if (false)
			{
				return;
			}
			goto IL_003d;
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
			_ = 1;
			int num;
			if (!pLAED9Ky3641npVs1k5O())
			{
				num = 31;
			}
			else
			{
				num = 23;
				if (false)
				{
					goto IL_0521;
				}
			}
			goto IL_0436;
			IL_0436:
			CvsCellLocation offset8 = default;
			LineToLineAngleToolType lineToLineAngleToolType = default;
			CvsCellLocation offset10 = default;
			CvsCellLocation offset11 = default;
			CvsCellLocation offset3 = default;
			CvsCellLocation offset13 = default;
			CvsCellLocation offset7 = default;
			CvsCellLocation offset2 = default;
			CvsCellLocation offset5 = default;
			int num2 = default;
			CvsCellLocation offset = default;
			while (true)
			{
				CvsCellLocation offset6;
				CvsCellLocation offset9;
				switch (num)
				{
				case 39:
					_003C_003E1__state = 14;
					num = 12;
					if (true)
					{
						continue;
					}
					goto case 22;
				case 22:
					return true;
				case 41:
					return true;
				case 13:
					_003CcurrentVersion_003E5__2 = cells.GetSnippetVersion(range);
					num = 19;
					if (true)
					{
						continue;
					}
					goto case 45;
				case 45:
					_003C_003E2__current = new EditArgumentUpdate(offset8, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 51;
					continue;
				case 11:
					_003C_003E1__state = 10;
					return true;
				case 8:
					_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(lineToLineAngleToolType._pasteObject, ((CvsInSight)rxSxy7KyRa9VcGn9EQhB(lineToLineAngleToolType)).FunctionTable, (IExpressionConstants)fvYSXNKyW84yfESJnPAB(rxSxy7KyRa9VcGn9EQhB(lineToLineAngleToolType)));
					_003C_003E1__state = 16;
					return true;
				case 43:
					offset10 = new CvsCellLocation(2, 1);
					num = 50;
					if (WFF3scKy7hBtvBQe347V())
					{
						continue;
					}
					goto case 7;
				case 7:
					_003C_003E1__state = 1;
					return true;
				case 36:
					_003C_003E1__state = 4;
					num = 17;
					continue;
				case 19:
					_003ClatestVersion_003E5__3 = WmEYxSKyABDTx3RKaAKU(lineToLineAngleToolType._pasteObject);
					num = 47;
					continue;
				case 4:
					offset11 = new CvsCellLocation(3, 3);
					num = 30;
					if (0 == 0)
					{
						continue;
					}
					goto case 14;
				case 14:
					_003C_003E2__current = new EditArgumentUpdate(offset3, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 39;
					continue;
				case 25:
					_003C_003E1__state = 12;
					return true;
				case 33:
					_003C_003E1__state = 6;
					num = 48;
					if (true)
					{
						continue;
					}
					goto case 34;
				case 34:
					offset13 = new CvsCellLocation(2, 0);
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 3;
				case 3:
					_003C_003E2__current = new EditArgumentUpdate(offset7, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 25;
					if (!pLAED9Ky3641npVs1k5O())
					{
						continue;
					}
					goto case 40;
				case 40:
					_003C_003E1__state = 11;
					num = 29;
					continue;
				case 38:
					return true;
				case 1:
					_003C_003E2__current = new EditArgumentUpdate(offset13, SnippetUpdateHelper.InputImageLocationFactory, 0, null, ignoreInvalidArgIndex: true);
					num = 33;
					continue;
				case 17:
					return true;
				case 37:
					offset2 = new CvsCellLocation(2, 5);
					num = 28;
					if (0 == 0)
					{
						continue;
					}
					goto case 10;
				case 10:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, lineToLineAngleToolType.Localizer);
					num = 44;
					continue;
				case 21:
				{
					CvsCellLocation offset12 = new CvsCellLocation(1, 4);
					_003C_003E2__current = new EditArgumentUpdate(offset12, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 36;
					continue;
				}
				case 30:
					_003C_003E2__current = new EditArgumentUpdate(offset11, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 11;
					continue;
				case 50:
					_003C_003E2__current = new EditArgumentUpdate(offset10, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 2;
					continue;
				case 24:
					_003C_003E2__current = new EditArgumentUpdate(offset5, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 13;
					return true;
				case 48:
					return true;
				case 9:
					lineToLineAngleToolType = _003C_003E4__this;
					switch (num2)
					{
					case 15:
						break;
					case 5:
						goto IL_005b;
					case 10:
						goto IL_00be;
					case 16:
						goto IL_0100;
					case 1:
						goto IL_013d;
					case 12:
						goto IL_01bf;
					case 9:
						goto IL_0238;
					case 4:
						goto IL_027b;
					case 13:
						goto IL_0389;
					case 6:
						goto IL_039c;
					default:
						goto IL_03fe;
					case 14:
						goto IL_05bb;
					case 7:
						goto IL_05fb;
					case 0:
						goto IL_0647;
					case 8:
						goto IL_06a2;
					case 3:
						goto IL_06ca;
					case 11:
						goto IL_06dd;
					case 2:
						goto IL_070e;
					}
					_003C_003E1__state = -1;
					goto IL_0041;
				case 42:
					offset5 = new CvsCellLocation(5, 1);
					num = 24;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
					_003C_003E1__state = 7;
					goto default;
				case 20:
					break;
				case 16:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						num = 18;
						continue;
					}
					goto IL_05c2;
				case 46:
					_003C_003E1__state = 5;
					num = 41;
					if (pLAED9Ky3641npVs1k5O())
					{
					}
					continue;
				case 51:
					_003C_003E1__state = 2;
					num = 15;
					if (true)
					{
						continue;
					}
					goto case 32;
				case 32:
					_003C_003E2__current = new EditArgumentUpdate(offset, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 9;
					num = 38;
					continue;
				case 0:
				case 31:
					num2 = _003C_003E1__state;
					num = 9;
					continue;
				case 12:
					return true;
				case 47:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 20;
						continue;
					}
					goto case 16;
				default:
					return true;
				case 49:
				{
					CvsCellLocation offset4 = new CvsCellLocation(4, 0);
					_003C_003E2__current = new EditArgumentUpdate(offset4, SnippetUpdateHelper.InputImageLocationFactory, 0, null, ignoreInvalidArgIndex: true);
					num = 40;
					if (pLAED9Ky3641npVs1k5O())
					{
					}
					continue;
				}
				case 35:
					return false;
				case 44:
					_003C_003E1__state = 15;
					num = 22;
					continue;
				case 6:
					offset3 = new CvsCellLocation(5, 3);
					num = 14;
					continue;
				case 28:
					_003C_003E2__current = new EditArgumentUpdate(offset2, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 8;
					return true;
				case 18:
					offset8 = new CvsCellLocation(1, 2);
					num = 45;
					continue;
				case 27:
					return true;
				case 29:
					return true;
				case 5:
					offset = new CvsCellLocation(3, 1);
					num = 32;
					if (true)
					{
						continue;
					}
					goto case 15;
				case 15:
					return true;
				case 52:
					{
						return false;
					}
					IL_070e:
					_003C_003E1__state = -1;
					offset6 = new CvsCellLocation(1, 3);
					_003C_003E2__current = new EditArgumentUpdate(offset6, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 3;
					num = 27;
					if (WFF3scKy7hBtvBQe347V())
					{
						continue;
					}
					goto case 52;
					IL_06dd:
					_003C_003E1__state = -1;
					offset7 = new CvsCellLocation(4, 1);
					num = 3;
					continue;
					IL_06ca:
					_003C_003E1__state = -1;
					num = 21;
					continue;
					IL_06a2:
					_003C_003E1__state = -1;
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 18;
					IL_0647:
					_003C_003E1__state = -1;
					num = 13;
					continue;
					IL_05fb:
					_003C_003E1__state = -1;
					num = 37;
					continue;
					IL_05bb:
					_003C_003E1__state = -1;
					goto IL_05c2;
					IL_05c2:
					if (_003CcurrentVersion_003E5__2 >= _003ClatestVersion_003E5__3)
					{
						goto IL_0041;
					}
					num = 10;
					if (!pLAED9Ky3641npVs1k5O())
					{
						continue;
					}
					goto case 47;
					IL_03fe:
					num = 35;
					continue;
					IL_039c:
					_003C_003E1__state = -1;
					num = 43;
					continue;
					IL_0389:
					_003C_003E1__state = -1;
					num = 6;
					continue;
					IL_027b:
					_003C_003E1__state = -1;
					offset9 = new CvsCellLocation(1, 5);
					_003C_003E2__current = new EditArgumentUpdate(offset9, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 46;
					continue;
					IL_0238:
					_003C_003E1__state = -1;
					num = 4;
					if (pLAED9Ky3641npVs1k5O())
					{
					}
					continue;
					IL_01bf:
					_003C_003E1__state = -1;
					num = 42;
					continue;
					IL_013d:
					_003C_003E1__state = -1;
					num = 16;
					continue;
					IL_0100:
					_003C_003E1__state = -1;
					num = 52;
					if (pLAED9Ky3641npVs1k5O())
					{
					}
					continue;
					IL_00be:
					_003C_003E1__state = -1;
					num = 49;
					continue;
					IL_005b:
					_003C_003E1__state = -1;
					num = 34;
					continue;
					IL_0041:
					if (_003CcurrentVersion_003E5__2 < 3)
					{
						num = 8;
						if (true)
						{
							continue;
						}
						goto case 41;
					}
					goto case 52;
				}
				break;
			}
			goto IL_0521;
			IL_0521:
			_003C_003E2__current = new ToolDisabledJobPassUpdate();
			num = 7;
			goto IL_0436;
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
		internal static void RBbuo7KyjmEJiSHt2nKV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rwdlPLKy6bbYycLpUVvC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oct6njKyCDAPoIS69xnq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WFF3scKy7hBtvBQe347V()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pLAED9Ky3641npVs1k5O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int WmEYxSKyABDTx3RKaAKU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rxSxy7KyRa9VcGn9EQhB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fvYSXNKyW84yfESJnPAB(object P_0)
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
			l1hD8XKy0fmGIBDNtA6a();
			dMbaljKyFg7RfMvsLoyn(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_FindEdgeToolType_003Eb__42_0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FvS85oKyU53Wl2PEuwAw(TROxYpKyMKI2QREyvmVw(t), nSAi6SKyYVCiPb0LWijI());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TkliTDKyTDhnG2YPyuna()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qZc0VWKyy8ymY9PNRyfb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void l1hD8XKy0fmGIBDNtA6a()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dMbaljKyFg7RfMvsLoyn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TROxYpKyMKI2QREyvmVw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).ToolType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nSAi6SKyYVCiPb0LWijI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Kb8tdpAgrR();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FvS85oKyU53Wl2PEuwAw(object P_0, object P_1)
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

		public LineToLineAngleToolType _003C_003E4__this;

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
			int num = 6;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0084;
			IL_001a:
			LineToLineAngleToolType lineToLineAngleToolType = _003C_003E4__this;
			num = 1;
			goto IL_0084;
			IL_0084:
			int num2 = default;
			string result3 = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<EzTool> awaiter3 = default;
			TaskAwaiter<CvsCellCollection> awaiter = default;
			CvsCellLocation cellLocation = default;
			string text2 = default;
			string text = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 4:
					_003Cline_003E5__3 = null;
					goto case 2;
				case 6:
					num2 = _003C_003E1__state;
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
				case 5:
					_003C_003Et__builder.SetResult(result3);
					num = 8;
					continue;
				case 7:
					_003Cexpr_003E5__2 = null;
					goto default;
				default:
					Vur8UuKyHXRXJUAfcdNu();
					num = (ubW5YMKyxfTlDSeZVDwo() ? 2 : 0);
					continue;
				case 1:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003Cexpr_003E5__2 = CdQUGaROfy7He9T0foW.KbIzwHEDLa(1838);
							num3 = 7;
							if (1 == 0)
							{
								goto IL_00f9;
							}
							goto IL_0504;
						case 2:
							awaiter2 = _003C_003Eu__1;
							num3 = 0;
							goto IL_0504;
						case 1:
							awaiter3 = _003C_003Eu__2;
							num3 = 31;
							goto IL_0504;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 8;
							if (ubW5YMKyxfTlDSeZVDwo())
							{
							}
							goto IL_0504;
						case 3:
							{
								awaiter = _003C_003Eu__3;
								num3 = 32;
								goto IL_0504;
							}
							IL_0504:
							while (true)
							{
								EzTool result2;
								switch (num3)
								{
								case 10:
									break;
								case 37:
									goto IL_0111;
								case 8:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 15;
									continue;
								case 29:
									_003Ctool_003E5__5 = null;
									num3 = 18;
									continue;
								case 1:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter3;
									num3 = 35;
									continue;
								case 12:
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									continue;
								case 0:
									_003C_003Eu__1 = default;
									num3 = 12;
									continue;
								case 17:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter2;
									num3 = 26;
									continue;
								case 14:
									if (_003Cline_003E5__3 != null)
									{
										cellLocation = editableGraphic.CellLocation;
										text2 = cIEffMKymwoqqmwG7urI(editableGraphic) as string;
										num3 = 38;
										continue;
									}
									goto case 33;
								case 20:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 22;
									continue;
								case 38:
									goto IL_024a;
								case 9:
									return;
								case 18:
									goto IL_028f;
								case 6:
									return;
								case 23:
									num2 = (_003C_003E1__state = 3);
									num3 = 28;
									if (Vur8UuKyHXRXJUAfcdNu())
									{
										continue;
									}
									goto case 25;
								case 25:
									text = cIEffMKymwoqqmwG7urI(((IEnumerable<CvsEditableDisplayGraphic>)wyLMonKyhQOqRRGVyAHI(_003Ctool_003E5__5, result, CellType.Line)).FirstOrDefault()) as string;
									num3 = 4;
									continue;
								case 26:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 9;
									if (ubW5YMKyxfTlDSeZVDwo())
									{
									}
									continue;
								case 31:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0337;
								case 16:
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 24;
									continue;
								case 7:
									_003Cline_003E5__3 = editableGraphic as CvsDisplayableLine;
									num3 = 14;
									continue;
								case 5:
									_003Cexpr_003E5__2 = cellLocation.ToString(absoluteRow: true, absoluteColumn: true);
									num3 = 36;
									continue;
								case 4:
									if (text != null)
									{
										num3 = 2;
										continue;
									}
									goto case 29;
								case 27:
									num2 = (_003C_003E1__state = -1);
									num3 = 30;
									continue;
								case 30:
									result = awaiter.GetResult();
									num3 = 25;
									continue;
								case 2:
									_003Cexpr_003E5__2 = text;
									num3 = 29;
									continue;
								case 3:
									awaiter2.GetResult();
									awaiter = ((CvsCogSocketSheet)EOFoJ0KyuZlKErSbs1cy(eiIspRKy1LEaXLdNXxDV(hlrl2UKyc7H5pSSCYW8d(lineToLineAngleToolType)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 23;
										continue;
									}
									goto case 30;
								case 15:
									goto IL_0429;
								case 13:
								case 39:
									awaiter3 = _003CfindLineToolType_003E5__4.YBE4tPvMRf(_003Cline_003E5__3).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto IL_0337;
								case 32:
									_003C_003Eu__3 = default;
									num3 = 27;
									continue;
								case 24:
									return;
								default:
									if (!awaiter2.IsCompleted)
									{
										num3 = 17;
										continue;
									}
									goto case 3;
								case 35:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 6;
									if (0 == 0)
									{
										continue;
									}
									goto case 21;
								case 21:
									awaiter2 = qfJPUOKy2vCZoX7HS1rY(lineToLineAngleToolType.s1Ou7UoL9J(_003Ctool_003E5__5));
									goto default;
								case 22:
									return;
								case 34:
									num2 = (_003C_003E1__state = 0);
									num3 = 16;
									continue;
								case 28:
									_003C_003Eu__3 = awaiter;
									num3 = 20;
									continue;
								case 33:
								case 36:
								case 40:
									{
										result3 = _003Cexpr_003E5__2;
										goto end_IL_00c8;
									}
									IL_0337:
									result2 = awaiter3.GetResult();
									_003Ctool_003E5__5 = result2;
									num3 = 21;
									continue;
								}
								break;
								IL_024a:
								if (text2 == null)
								{
									if (cellLocation.IsValid)
									{
										num3 = 5;
										continue;
									}
									_003CfindLineToolType_003E5__4 = lineToLineAngleToolType.uptMk6YIZ8();
									num3 = 37;
									if (true)
									{
										continue;
									}
									goto IL_028f;
								}
								num3 = 10;
							}
							goto IL_00f9;
							IL_00f9:
							_003Cexpr_003E5__2 = text2;
							num3 = 33;
							if (!Vur8UuKyHXRXJUAfcdNu())
							{
								goto IL_0111;
							}
							goto IL_0504;
							IL_0111:
							if (_003CfindLineToolType_003E5__4 == null)
							{
								goto IL_028f;
							}
							_003CfindLineToolType_003E5__4.RefreshInputImageLinks();
							awaiter2 = ((Task)L8GQTSKyNGBKOc0hjtri(_003CfindLineToolType_003E5__4, ULCRgqKyQy0WIB0fK8ec(lineToLineAngleToolType))).GetAwaiter();
							if (awaiter2.IsCompleted)
							{
								goto IL_0429;
							}
							num3 = 34;
							goto IL_0504;
							IL_0429:
							awaiter2.GetResult();
							Vur8UuKyHXRXJUAfcdNu();
							if (!ubW5YMKyxfTlDSeZVDwo())
							{
								num3 = 39;
							}
							else
							{
								num3 = 11;
								if (false)
								{
									return;
								}
							}
							goto IL_0504;
							IL_028f:
							_003CfindLineToolType_003E5__4 = null;
							num3 = 40;
							if (ubW5YMKyxfTlDSeZVDwo())
							{
								return;
							}
							goto IL_0504;
							end_IL_00c8:
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
					num = 7;
					continue;
				case 8:
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
		internal static object cIEffMKymwoqqmwG7urI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableGraphic)P_0).Tag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ULCRgqKyQy0WIB0fK8ec(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L8GQTSKyNGBKOc0hjtri(object P_0, int value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).SetInputImageIndexAsync(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter qfJPUOKy2vCZoX7HS1rY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hlrl2UKyc7H5pSSCYW8d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eiIspRKy1LEaXLdNXxDV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EOFoJ0KyuZlKErSbs1cy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wyLMonKyhQOqRRGVyAHI(object P_0, object P_1, CellType reqDataType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).GetFeatures((CvsCellCollection)P_1, reqDataType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vur8UuKyHXRXJUAfcdNu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ubW5YMKyxfTlDSeZVDwo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid A2QMsn1bkW;

	private static readonly Guid[] BQtMKBhNtM;

	private readonly CvsCellLocation uRZMGjnani;

	private readonly CvsCellLocation H0qMBN1lX2;

	private readonly CvsCellLocation cc5MZLyvWZ;

	private FindEdgeToolType to3MnCjUPm;

	private CvsEditableDisplayGraphic tAuMtsiSNf;

	private CvsEditableDisplayGraphic OQhMYGw8QL;

	private PointF g23M0k1wF9;

	private int u9UMV2jqC4;

	private CvsEditableDisplayGraphic[] hu8MLKmHnp;

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g23M0k1wF9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g23M0k1wF9 = value;
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
			return BQtMKBhNtM;
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
			return (string)EHf4bD9xKD69ubuhtPN();
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
			return (string)TLT7SY9m1BOF7bptiIS();
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
				(string)dy5h6D9QFNXu6ukuMCW(),
				(string)CXuBO39NZu3XFFLRegg()
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
			return u9UMV2jqC4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref u9UMV2jqC4, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineToLineAngleToolType()
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
			case 8:
				uRZMGjnani = _pasteObject.GetCellOffset((string)s6aaK59UjY2Y4lnjTsc(4928));
				num = 3;
				continue;
			case 7:
				g23M0k1wF9 = PointF.Empty;
				_ = 0;
				if (GbLetT90P3WibCM87W7())
				{
					num = 1;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 10:
				base._002Ector();
				goto case 0;
			case 0:
			case 4:
				_pasteObject = (PasteBuffer)hZ1oYb9YZ4pn2j5TMNt(K3C1yZ9MvXqRpmfXTmt());
				goto case 8;
			default:
				num = 8;
				continue;
			case 3:
				H0qMBN1lX2 = _pasteObject.GetCellOffset((string)s6aaK59UjY2Y4lnjTsc(21598));
				num = 9;
				continue;
			case 6:
				AddSnippet(_pasteObject);
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 9;
			case 9:
				cc5MZLyvWZ = _pasteObject.GetCellOffset((string)s6aaK59UjY2Y4lnjTsc(21622));
				num = 6;
				continue;
			case 1:
			case 2:
				u9UMV2jqC4 = 400;
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 5:
				break;
			case 11:
				return;
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			num = 7;
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
		int num = 5;
		_003COnGraphicChanged_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 6:
				stateMachine.e = e;
				goto default;
			default:
				GbLetT90P3WibCM87W7();
				if (!Yk6Fv69F1sCrSmD3nmi())
				{
					num = 1;
					if (Yk6Fv69F1sCrSmD3nmi())
					{
					}
					continue;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003Et__builder = G3QJPf9HpEXoTVaEdpc();
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
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
		int num = 6;
		_003CSetDisplayGraphics_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				GbLetT90P3WibCM87W7();
				if (!Yk6Fv69F1sCrSmD3nmi())
				{
					num = 5;
					break;
				}
				num = 1;
				if (Yk6Fv69F1sCrSmD3nmi())
				{
				}
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 6:
				stateMachine._003C_003Et__builder = G3QJPf9HpEXoTVaEdpc();
				num = 4;
				break;
			case 2:
			case 5:
				stateMachine.graphic = graphic;
				goto default;
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
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0034;
		IL_00af:
		_003COnBeginAddInternal_003Ed__34 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (true)
		{
			goto IL_0034;
		}
		goto IL_00c9;
		IL_00c9:
		return stateMachine._003C_003Et__builder.Task;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 0:
				do
				{
					stateMachine._003C_003E4__this = this;
					GbLetT90P3WibCM87W7();
					if (Yk6Fv69F1sCrSmD3nmi())
					{
						num = 4;
						continue;
					}
					num = 1;
					if (Yk6Fv69F1sCrSmD3nmi())
					{
					}
					break;
				}
				while (!GbLetT90P3WibCM87W7());
				continue;
			case 5:
				stateMachine._003C_003Et__builder = G3QJPf9HpEXoTVaEdpc();
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto IL_00af;
			default:
				goto IL_00af;
			case 6:
				goto IL_00c9;
			}
			break;
		}
		goto IL_001a;
		IL_001a:
		stateMachine._003C_003E1__state = -1;
		goto IL_00af;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateFeatureGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Yk6Fv69F1sCrSmD3nmi())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (Yk6Fv69F1sCrSmD3nmi())
			{
				return;
			}
		}
		CvsEditableDisplayGraphic[] source = default;
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			CvsEditableDisplayGraphic[] array;
			switch (num)
			{
			case 3:
				FireAddGraphicsChanged(source.ToList(), list);
				break;
			default:
				num = 5;
				continue;
			case 1:
			case 4:
				array = Array.Empty<CvsEditableDisplayGraphic>();
				goto IL_0073;
			case 5:
				break;
			case 0:
			case 2:
				array = hu8MLKmHnp;
				if (array == null)
				{
					goto case 1;
				}
				goto IL_0073;
			case 6:
				return;
				IL_0073:
				source = array;
				list = PlSMe708m8();
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				break;
			}
			hu8MLKmHnp = (CvsEditableDisplayGraphic[])vifvfh92g4e7avYcoDg(list);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<CvsEditableDisplayGraphic> PlSMe708m8()
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
			if (uptMk6YIZ8() != null && uptMk6YIZ8().IsTypeEnabled)
			{
				FeatureExtractor featureExtractor = new FeatureExtractor();
				if (uptMk6YIZ8() != null)
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
		return hu8MLKmHnp;
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
	private FindEdgeToolType uptMk6YIZ8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (to3MnCjUPm == null)
		{
			to3MnCjUPm = ((IEnumerable<EzToolType>)N84rBU9ckxwQ0xj6Ocr(Inspect)).FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType t) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec.FvS85oKyU53Wl2PEuwAw(_003C_003Ec.TROxYpKyMKI2QREyvmVw(t), _003C_003Ec.nSAi6SKyYVCiPb0LWijI());
			}) as FindEdgeToolType;
		}
		return to3MnCjUPm;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGraphicExpression_003Ed__43))]
	private Task<string> FUAM2LUBk1(CvsEditableDisplayGraphic P_0)
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
	static LineToLineAngleToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Yk6Fv69F1sCrSmD3nmi();
		int num;
		if (GbLetT90P3WibCM87W7())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_008c;
			}
		}
		goto IL_004e;
		IL_004e:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				A2QMsn1bkW = new Guid((string)s6aaK59UjY2Y4lnjTsc(24470));
				break;
			default:
				goto IL_006b;
			case 0:
			case 2:
				puOejy9123wALJxddPS();
				goto case 1;
			case 4:
				break;
			case 5:
				return;
			}
			break;
			IL_006b:
			num = 4;
		}
		goto IL_008c;
		IL_008c:
		BQtMKBhNtM = new Guid[1] { A2QMsn1bkW };
		num = 5;
		if (!GbLetT90P3WibCM87W7())
		{
			return;
		}
		goto IL_004e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task TsYMq4Fjqv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K3C1yZ9MvXqRpmfXTmt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.LineToLineAngle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hZ1oYb9YZ4pn2j5TMNt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s6aaK59UjY2Y4lnjTsc(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GbLetT90P3WibCM87W7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Yk6Fv69F1sCrSmD3nmi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder G3QJPf9HpEXoTVaEdpc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EHf4bD9xKD69ubuhtPN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.VBOVWZjqO9();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TLT7SY9m1BOF7bptiIS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.HAm031ryYZ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dy5h6D9QFNXu6ukuMCW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CXuBO39NZu3XFFLRegg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.aArVeOJEQe();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vifvfh92g4e7avYcoDg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N84rBU9ckxwQ0xj6Ocr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InspectStepViewModel)P_0).ToolTypes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void puOejy9123wALJxddPS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
