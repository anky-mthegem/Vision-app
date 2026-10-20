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
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Imaging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using EWWMshcielYPHTNN2p;
using oF2MOjpuTE9ryB96aX;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindCircle;

[Export(typeof(EzToolType))]
public class FindCircleToolType : EzToolType, IGraphicInvalidateToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public FindCircleToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private FindCircleTool _003Ctool_003E5__2;

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
			if (wNBFllKUVOyiNC6BhTMX())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
				if (lrx4oHKUfKauCYyeg3UL())
				{
				}
			}
			goto IL_01e1;
			IL_0026:
			FindCircleToolType findCircleToolType = _003C_003E4__this;
			num = 6;
			goto IL_01e1;
			IL_01e1:
			int num2 = default;
			EzTool result = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 4:
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new FindCircleTool(findCircleToolType.Inspect, isInitialized: true);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 2;
							if (false)
							{
								goto IL_0198;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 8;
							case 8:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 7:
								awaiter = lByCEtKUlS7NfbYNSJgv(UA37kPKUdi31rkka6d3K(_003Ctool_003E5__2, cells, cellRange));
								num3 = 1;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto default;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = (wNBFllKUVOyiNC6BhTMX() ? 6 : 0);
								continue;
							case 3:
							case 6:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 5:
								return;
							case 10:
								break;
							}
							break;
						}
						goto IL_0198;
						IL_0198:
						result = _003Ctool_003E5__2;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 1;
				default:
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
					_003Ctool_003E5__2 = null;
					goto case 4;
				case 7:
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
		internal static object UA37kPKUdi31rkka6d3K(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lByCEtKUlS7NfbYNSJgv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wNBFllKUVOyiNC6BhTMX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lrx4oHKUfKauCYyeg3UL()
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
	private struct _003COnBeginAddInternal_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FindCircleToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!yeoHOQKUgtIS7II6Efuv()) ? 3 : 2);
			int num2 = default;
			FindCircleToolType findCircleToolType = default;
			TaskAwaiter awaiter = default;
			CvsCellLocation cvsCellLocation = default;
			CvsCell cvsCell = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							findCircleToolType.ShowCircle = false;
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
							if (1 == 0)
							{
								goto IL_019a;
							}
						}
						goto IL_00f9;
						IL_019a:
						awaiter = mjPQWFKU8oBKk0qS8Exw(findCircleToolType.y6xlR3PyMV());
						num3 = 13;
						goto IL_00f9;
						IL_00f9:
						while (true)
						{
							switch (num3)
							{
							case 9:
								IGNvJZKUokDObGw3rNt2(findCircleToolType.od4lChyulI, c4XWKyKUGFpANxIQGcHi());
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 13;
							case 13:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto case 16;
							default:
								findCircleToolType.ybhlwuBXqN = (CvsEditableDisplayGraphic[])fC8I44KUkxdwiMGZ09pK(findCircleToolType.ovTlg9Cftx());
								num3 = 5;
								if (yeoHOQKUgtIS7II6Efuv())
								{
									continue;
								}
								goto case 2;
							case 2:
								cvsCellLocation = CvsCellLocation.Parse((string)nr4R3CKUvL04mbjYakqX(findCircleToolType.CurrentInputImageLink));
								num3 = 4;
								if (!JJx8WkKUsE2LMk2LEC7Q())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 6:
								Nu2a2YKUbNhnQLstZy50(findCircleToolType.od4lChyulI, false);
								goto default;
							case 10:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								break;
							case 15:
								Nu2a2YKUbNhnQLstZy50(findCircleToolType.HUIlO1nmOK, false);
								num3 = 1;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								findCircleToolType.od4lChyulI = EditableGraphicHelper.ConstructCircle(CvsCellLocation.Invalid, 150.0, 150.0, 100.0, cvsCell);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								findCircleToolType.od4lChyulI.SelectedColor = SippBlKUSXdgR2CybpxR();
								yeoHOQKUgtIS7II6Efuv();
								if (JJx8WkKUsE2LMk2LEC7Q())
								{
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 10;
								}
								num3 = 0;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 4:
								cvsCell = (CvsCell)FWi3m0KUZQPkiwX5Cfsf(CGtMKlKUP6J9lOUEYC43(((AppStepViewModel)s9eFx4KUr8KyQnVXFrki(findCircleToolType)).InSight.Results), cvsCellLocation);
								findCircleToolType.HUIlO1nmOK = (CvsDisplayableAnnulus)DBlVjmKUBKYTKqrKmoLy(CvsCellLocation.Invalid, 150.0, 150.0, 50.0, 100.0, cvsCell);
								num3 = 15;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_00f9;
							}
							goto IL_019a;
							continue;
							end_IL_00f9:
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
					goto case 4;
				default:
					num = 4;
					continue;
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				findCircleToolType = _003C_003E4__this;
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
		internal static object nr4R3CKUvL04mbjYakqX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object s9eFx4KUr8KyQnVXFrki(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CGtMKlKUP6J9lOUEYC43(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FWi3m0KUZQPkiwX5Cfsf(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DBlVjmKUBKYTKqrKmoLy(CvsCellLocation loc, double x, double y, double inner, double outer, object P_5)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.ConstructAnnulus(loc, x, y, inner, outer, (CvsCell)P_5);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Nu2a2YKUbNhnQLstZy50(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Visible = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color c4XWKyKUGFpANxIQGcHi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.Red;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IGNvJZKUokDObGw3rNt2(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Color = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color SippBlKUSXdgR2CybpxR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.OrangeRed;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fC8I44KUkxdwiMGZ09pK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter mjPQWFKU8oBKk0qS8Exw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yeoHOQKUgtIS7II6Efuv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JJx8WkKUsE2LMk2LEC7Q()
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

		public static Func<CvsEditableDisplayGraphic, bool> _003C_003E9__39_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NGEpddKUp1sjUbaqfowV();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			AqQMMRKUXPCbjMfUZHZg(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CAddTool_003Eb__39_0(CvsEditableDisplayGraphic g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Fmh3h1KU9sgnNkDJITyG(g);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NGEpddKUp1sjUbaqfowV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MRUi3yKUqgY5SE4aSyrt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M4OnwHKUEs9EHkKaqV3F()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AqQMMRKUXPCbjMfUZHZg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fmh3h1KU9sgnNkDJITyG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).Selected;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddTool_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public FindCircleToolType _003C_003E4__this;

		private TaskAwaiter<EzTool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EzTool result = default;
			TaskAwaiter<EzTool> awaiter = default;
			FindCircleToolType findCircleToolType = default;
			CvsDisplayableCircle cvsDisplayableCircle = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 6;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 0;
								if (1 == 0)
								{
									goto IL_01b8;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						goto IL_01ea;
						IL_01b8:
						_003C_003Eu__1 = awaiter;
						num3 = 14;
						if (1 == 0)
						{
							goto IL_01cc;
						}
						goto IL_01ea;
						IL_01ea:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 13:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 11:
								goto IL_0081;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									continue;
								}
								goto IL_0081;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 1:
								awaiter = findCircleToolType.yU6lMlvys2(cvsDisplayableCircle).GetAwaiter();
								num3 = 15;
								continue;
							case 6:
								cvsDisplayableCircle = findCircleToolType.ybhlwuBXqN.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return _003C_003Ec.Fmh3h1KU9sgnNkDJITyG(g);
								}) as CvsDisplayableCircle;
								num3 = 2;
								continue;
							case 8:
							case 10:
								goto end_IL_002e;
							case 2:
								goto IL_014a;
							case 9:
								if (!awaiter.IsCompleted)
								{
									goto case 12;
								}
								goto case 17;
							case 12:
							case 16:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 7:
								goto IL_01b8;
							case 3:
								goto IL_01cc;
							default:
								num3 = 4;
								continue;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 17:
								result = awaiter.GetResult();
								goto end_IL_002e;
							}
							break;
							IL_014a:
							if (cvsDisplayableCircle == null)
							{
								awaiter = findCircleToolType.AddTool(findCircleToolType.HUIlO1nmOK).GetAwaiter();
								num3 = 9;
								continue;
							}
							num3 = 1;
							if (e3i2MPKU7HrMrT1cJ9XB())
							{
							}
							continue;
							IL_0081:
							result = awaiter.GetResult();
							_ = 1;
							if (!e3i2MPKU7HrMrT1cJ9XB())
							{
								num3 = 8;
								if (e3i2MPKU7HrMrT1cJ9XB())
								{
								}
							}
							else
							{
								num3 = 16;
							}
						}
						goto IL_0045;
						IL_0045:
						num2 = (_003C_003E1__state = -1);
						num3 = 11;
						goto IL_01ea;
						IL_01cc:
						_003C_003Eu__1 = default;
						goto IL_0045;
						end_IL_002e:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 0:
					findCircleToolType = _003C_003E4__this;
					_ = 1;
					num = (e3i2MPKU7HrMrT1cJ9XB() ? 1 : 5);
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
		internal static bool iUOV0mKU40k7h5lEXd7L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e3i2MPKU7HrMrT1cJ9XB()
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

		public FindCircleToolType _003C_003E4__this;

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
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 1:
					Qmc3RCKUCO5SHRvpp9rn(this);
					_ = 1;
					if (!GbNohPKUjtwA7ldp5PpL())
					{
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 2;
					}
					num = 0;
					break;
				case 2:
				case 5:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				default:
					_003C_003El__initialThreadId = PNlTBeKUAdaA0UJMVq9u();
					num = 6;
					break;
				case 4:
					TcluYwKU6gZ9aoh9soUT();
					num = 1;
					break;
				case 6:
					return;
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
			int num = 22;
			CvsCellLocation offset4 = default;
			CvsCellLocation offset2 = default;
			FindCircleToolType findCircleToolType = default;
			CvsCellLocation offset3 = default;
			CvsCellLocation offset = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 19:
					offset4 = new CvsCellLocation(8, 0);
					num = 23;
					continue;
				case 9:
					offset2 = new CvsCellLocation(4, 2);
					num = 13;
					continue;
				case 25:
					return true;
				case 14:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						CvsCellLocation offset5 = new CvsCellLocation(1, 2);
						_003C_003E2__current = new EditArgumentUpdate(offset5, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
						_003C_003E1__state = 2;
						num = 2;
						continue;
					}
					goto IL_012a;
				case 0:
					findCircleToolType = _003C_003E4__this;
					num = 8;
					if (aPAfPpKU32Lfb3NZNZxt())
					{
						continue;
					}
					goto case 16;
				case 16:
				case 28:
					return true;
				case 31:
					_003ClatestVersion_003E5__3 = VKhdonKUWje1Aggr5jy6(findCircleToolType._pasteObject);
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 3;
						continue;
					}
					goto case 14;
				case 6:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 18;
						continue;
					}
					goto case 1;
				case 23:
					_003C_003E2__current = new EditArgumentUpdate(offset4, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 6;
					return true;
				case 29:
					return false;
				case 24:
					_003C_003E1__state = 9;
					num = 17;
					continue;
				case 17:
					return true;
				case 27:
					_003C_003E1__state = 7;
					num = 5;
					continue;
				case 20:
					offset3 = new CvsCellLocation(4, 0);
					num = 26;
					continue;
				case 18:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, findCircleToolType.Localizer);
					_003C_003E1__state = 8;
					num = 30;
					continue;
				case 11:
					offset = new CvsCellLocation(4, 1);
					num = 21;
					if (aPAfPpKU32Lfb3NZNZxt())
					{
						continue;
					}
					goto case 26;
				case 26:
					_003C_003E2__current = new EditArgumentUpdate(offset3, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					num = 10;
					if (true)
					{
						continue;
					}
					goto case 10;
				case 10:
					_003C_003E1__state = 3;
					num = 25;
					continue;
				case 15:
					_003C_003E1__state = 1;
					num = 12;
					continue;
				case 5:
					return true;
				case 30:
					return true;
				case 13:
					_003C_003E2__current = new EditArgumentUpdate(offset2, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 5;
					return true;
				case 8:
					switch (num2)
					{
					case 3:
						break;
					case 4:
						goto IL_00ab;
					case 6:
						goto IL_0123;
					case 0:
						goto IL_0144;
					case 9:
						goto IL_0186;
					case 7:
						goto IL_0248;
					case 8:
						goto IL_025b;
					case 5:
						goto IL_0291;
					default:
						goto IL_02dc;
					case 2:
						goto IL_02e8;
					case 1:
						goto IL_02fd;
					}
					_003C_003E1__state = -1;
					num = 11;
					continue;
				case 2:
					return true;
				case 12:
					return true;
				case 7:
					_003C_003E2__current = new P47d6pq2XTTdvapjBq(findCircleToolType.Localizer, (CvsFunctionTable)REfRZuKUT5ZpRxTiMpY6(findCircleToolType.InSight), (IExpressionConstants)A5PVNAKU0XEoUE6ybqG2(LlVevUKUy7hs5NP0o3Z6(findCircleToolType)));
					num = 27;
					continue;
				case 32:
					_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(findCircleToolType._pasteObject, (CvsFunctionTable)REfRZuKUT5ZpRxTiMpY6(findCircleToolType.InSight), ((CvsInSight)LlVevUKUy7hs5NP0o3Z6(findCircleToolType)).ProcessorConstants);
					num = 24;
					continue;
				case 21:
					_003C_003E2__current = new EditArgumentUpdate(offset, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
					_003C_003E1__state = 4;
					goto default;
				default:
					aPAfPpKU32Lfb3NZNZxt();
					if (GbNohPKUjtwA7ldp5PpL())
					{
						num = 4;
						if (aPAfPpKU32Lfb3NZNZxt())
						{
							continue;
						}
						goto case 8;
					}
					num = 28;
					continue;
				case 1:
					if (_003CcurrentVersion_003E5__2 < 4)
					{
						num = 32;
						continue;
					}
					break;
				case 22:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 3:
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					num = 15;
					continue;
				case 33:
					break;
					IL_02fd:
					_003C_003E1__state = -1;
					num = 14;
					continue;
					IL_02e8:
					_003C_003E1__state = -1;
					num = 20;
					if (0 == 0)
					{
						continue;
					}
					goto case 12;
					IL_02dc:
					num = 29;
					continue;
					IL_0291:
					_003C_003E1__state = -1;
					goto case 4;
					IL_025b:
					_003C_003E1__state = -1;
					num = 1;
					continue;
					IL_0248:
					_003C_003E1__state = -1;
					num = 6;
					continue;
					IL_0186:
					_003C_003E1__state = -1;
					num = 33;
					continue;
					IL_0144:
					_003C_003E1__state = -1;
					_003CcurrentVersion_003E5__2 = EZB7nlKURub21MxccEjn(cells, range);
					num = 31;
					if (aPAfPpKU32Lfb3NZNZxt())
					{
						continue;
					}
					goto case 24;
					IL_0123:
					_003C_003E1__state = -1;
					goto IL_012a;
					IL_00ab:
					_003C_003E1__state = -1;
					num = 9;
					continue;
					IL_012a:
					if (_003CcurrentVersion_003E5__2 >= 3)
					{
						goto case 6;
					}
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 29;
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
		internal static void TcluYwKU6gZ9aoh9soUT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Qmc3RCKUCO5SHRvpp9rn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int PNlTBeKUAdaA0UJMVq9u()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aPAfPpKU32Lfb3NZNZxt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GbNohPKUjtwA7ldp5PpL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int EZB7nlKURub21MxccEjn(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int VKhdonKUWje1Aggr5jy6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object REfRZuKUT5ZpRxTiMpY6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LlVevUKUy7hs5NP0o3Z6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A5PVNAKU0XEoUE6ybqG2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddTool_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public CvsDisplayableCircle editableCircle;

		public FindCircleToolType _003C_003E4__this;

		private CvsDisplayableAnnulus _003CdisplayableAnnulus_003E5__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private TaskAwaiter<EzTool> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			FindCircleToolType findCircleToolType = default;
			int num2 = default;
			EzTool result = default;
			TaskAwaiter<EzTool> awaiter = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			CvsCellCollection result2 = default;
			CvsGraphicAnnulus graphic = default;
			CvsCogEditingAnnulus cvsCogEditingAnnulus = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					_003CdisplayableAnnulus_003E5__2 = null;
					goto case 3;
				case 5:
					do
					{
						findCircleToolType = _003C_003E4__this;
						Ht9S8lKUFTcLYMvYEMoh();
						if (O7piSWKUME3gMTj9dMIL())
						{
							num = 3;
							continue;
						}
						num = 0;
						break;
					}
					while (false);
					break;
				case 6:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 3:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (true)
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
							if (num2 != 1)
							{
								num3 = 18;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 2;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 10;
							if (!Ht9S8lKUFTcLYMvYEMoh())
							{
								goto IL_03b5;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 19;
								continue;
							case 4:
								return;
							case 7:
								awaiter = findCircleToolType.AddTool(_003CdisplayableAnnulus_003E5__2, result2).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 11;
								if (Ht9S8lKUFTcLYMvYEMoh())
								{
									continue;
								}
								goto case 8;
							case 8:
								graphic = new CvsGraphicAnnulus(CvsCellLocation.Invalid, cvsCogEditingAnnulus);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 17;
							case 17:
								_003C_003Eu__2 = awaiter;
								num3 = 13;
								continue;
							case 12:
								_003CdisplayableAnnulus_003E5__2 = new CvsDisplayableAnnulus(graphic);
								num3 = 0;
								continue;
							case 16:
								result2 = awaiter2.GetResult();
								num3 = 7;
								if (Ht9S8lKUFTcLYMvYEMoh())
								{
									continue;
								}
								goto case 13;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (Ht9S8lKUFTcLYMvYEMoh())
								{
									continue;
								}
								goto case 0;
							case 0:
								awaiter2 = ((CvsCogSocketSheet)bl8kMgKU1sipvEissV0C(rYDdOGKUceMVli8axl67(krucvTKU2AJrFGj0aW5T(j9lhWBKUN27vgfxbgbEG(findCircleToolType))))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
								num3 = 15;
								continue;
							case 18:
								cvsCogEditingAnnulus = new CvsCogEditingAnnulus
								{
									Shape = new CvsCogAnnulus(eKpdG3KUYr2YY1yaxPDf(editableCircle.CircleGraphic).X, eKpdG3KUYr2YY1yaxPDf(N8V0aEKUUpeYnvqwQc3o(editableCircle)).Y, FIjnVWKUx8YsaP3XClYE(jma3JXKUH4ymc7fY09u8(editableCircle.CircleGraphic) - 10f, 5f), editableCircle.CircleGraphic.Radius + 10f)
								};
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = default;
								goto default;
							case 14:
								nYMFJIKUQqx9Ry25Um9Z(cvsCogEditingAnnulus, new CvsCogRectangle(editableCircle.EditBounds.Top, lK3MShKUmKqoyTgEnqkQ(editableCircle).Left, lK3MShKUmKqoyTgEnqkQ(editableCircle).Width, lK3MShKUmKqoyTgEnqkQ(editableCircle).Height));
								num3 = 8;
								continue;
							case 11:
								num2 = (_003C_003E1__state = 1);
								num3 = 17;
								continue;
							default:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								if (awaiter2.IsCompleted)
								{
									goto case 16;
								}
								O7piSWKUME3gMTj9dMIL();
								if (!Ht9S8lKUFTcLYMvYEMoh())
								{
									num3 = 3;
									if (true)
									{
										continue;
									}
									goto case 14;
								}
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 19:
								break;
							}
							break;
						}
						goto IL_03b5;
						IL_03b5:
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CdisplayableAnnulus_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 1;
				default:
					num = 1;
					if (!Ht9S8lKUFTcLYMvYEMoh())
					{
						return;
					}
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
		internal static PointF eKpdG3KUYr2YY1yaxPDf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicCircle)P_0).Center;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N8V0aEKUUpeYnvqwQc3o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableCircle)P_0).CircleGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static float jma3JXKUH4ymc7fY09u8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicCircle)P_0).Radius;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static float FIjnVWKUx8YsaP3XClYE(float P_0, float P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Max(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RectangleF lK3MShKUmKqoyTgEnqkQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).EditBounds;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nYMFJIKUQqx9Ry25Um9Z(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogEditingShape)P_0).Bounds = (CvsCogRectangle)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object j9lhWBKUN27vgfxbgbEG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object krucvTKU2AJrFGj0aW5T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rYDdOGKUceMVli8axl67(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bl8kMgKU1sipvEissV0C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ht9S8lKUFTcLYMvYEMoh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O7piSWKUME3gMTj9dMIL()
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
	private struct _003CAddTool_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public FindCircleToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsDisplayableAnnulus editableAnnulus;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private bool _003ColdPass_003E5__5;

		private FindCircleTool _003CnewTool_003E5__6;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			FindCircleToolType findCircleToolType = default;
			EzTool result3 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<CvsCellRange> awaiter3 = default;
			TaskAwaiter<object> awaiter5 = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter4 = default;
			CvsCellLocation cellLocation = default;
			CvsCellRange result2 = default;
			CvsCellCollection result = default;
			string text = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					findCircleToolType = _003C_003E4__this;
					_ = 1;
					if (!JocFodKUhCxbQuBXEB1t())
					{
						num = 0;
						if (oiq2HyKUuD5lGtGTd1nY())
						{
							break;
						}
						goto default;
					}
					num = 1;
					break;
				default:
					_003Csheet_003E5__2 = null;
					num = 6;
					break;
				case 6:
					_003C_003Et__builder.SetResult(result3);
					num = 7;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if ((uint)num2 > 8u)
						{
							if (num2 == 9)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0a32;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)oXOx9vKUzlx3yuflkUwb(((CvsInSight)dkS5I9KUtwbkcR7mjPQJ(findCircleToolType.Inspect)).CogSocket);
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								awaiter3 = findCircleToolType.RenameAndPasteTool(findCircleToolType._pasteObject, cells, runSheet: false).GetAwaiter();
								num4 = 14;
								if (1 == 0)
								{
									goto IL_00fb;
								}
								goto IL_0497;
							case 6:
								awaiter = _003C_003Eu__3;
								num4 = 7;
								goto IL_0497;
							case 2:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								num4 = 0;
								goto IL_0497;
							case 1:
								awaiter5 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num4 = 62;
								goto IL_0497;
							case 8:
								awaiter2 = _003C_003Eu__5;
								num4 = 56;
								if (JocFodKUhCxbQuBXEB1t())
								{
								}
								goto IL_0497;
							case 7:
								awaiter = _003C_003Eu__3;
								num4 = 25;
								if (0 == 0)
								{
									goto IL_0497;
								}
								goto IL_06d8;
							case 3:
								awaiter4 = _003C_003Eu__4;
								num4 = 23;
								if (0 == 0)
								{
									goto IL_0497;
								}
								goto IL_0724;
							case 0:
								awaiter3 = _003C_003Eu__1;
								num4 = 37;
								goto IL_0497;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 36;
								goto IL_0497;
							case 5:
								{
									awaiter2 = _003C_003Eu__5;
									num4 = 52;
									if (0 == 0)
									{
										goto IL_0497;
									}
									goto IL_08b9;
								}
								IL_0497:
								while (true)
								{
									switch (num4)
									{
									case 34:
										break;
									case 36:
										goto IL_0113;
									case 22:
										goto IL_0134;
									case 2:
									case 20:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 1;
										continue;
									case 55:
										awaiter.GetResult();
										awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num2 = (_003C_003E1__state = 5);
											num4 = 47;
											if (0 == 0)
											{
												continue;
											}
											goto case 61;
										}
										goto IL_08ce;
									case 61:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 57;
										continue;
									case 50:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 21;
										continue;
									case 16:
										awaiter5 = _003Csheet_003E5__2.PutCellExpressionAsync(findCircleToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findCircleToolType.xiCllIHhS2), findCircleToolType.InputImageLinks[o5XXonKHLYAGthVG6Yyx(findCircleToolType)].Expression).GetAwaiter();
										num4 = 44;
										continue;
									case 3:
										num2 = (_003C_003E1__state = 3);
										num4 = 34;
										continue;
									case 58:
										awaiter4.GetResult();
										num4 = 35;
										continue;
									case 21:
										return;
									case 28:
										_003C_003Eu__3 = awaiter;
										num4 = 40;
										if (true)
										{
											continue;
										}
										goto case 43;
									case 43:
										num2 = (_003C_003E1__state = -1);
										num4 = 58;
										continue;
									case 41:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 46:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									case 33:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 7);
											num4 = 28;
											if (!JocFodKUhCxbQuBXEB1t())
											{
												continue;
											}
											return;
										}
										goto case 26;
									case 31:
										return;
									case 24:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											num4 = 41;
											continue;
										}
										goto case 0;
									case 6:
										num2 = (_003C_003E1__state = 1);
										num4 = 49;
										if (oiq2HyKUuD5lGtGTd1nY())
										{
											continue;
										}
										goto case 11;
									case 11:
										cellLocation = findCircleToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findCircleToolType.tmIlWMldId);
										num4 = 54;
										continue;
									case 25:
										_003C_003Eu__3 = default;
										num4 = 39;
										continue;
									case 13:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 6);
											num4 = 50;
											continue;
										}
										goto case 15;
									case 7:
										_003C_003Eu__3 = default;
										num4 = 18;
										continue;
									case 15:
									case 45:
										awaiter.GetResult();
										awaiter = PqwxRZKHwpLM8v8dBjbo(DynamicThresholdCalculator.DynamicallyThresholdTool(_003Csheet_003E5__2, findCircleToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findCircleToolType.GeEljs1KbQ), (EditIntViewModel)CSOEHeKHeuDbgHCKlsBJ(_003CnewTool_003E5__6)));
										num4 = 33;
										if (oiq2HyKUuD5lGtGTd1nY())
										{
											continue;
										}
										goto case 44;
									case 44:
										if (!awaiter5.IsCompleted)
										{
											num4 = 6;
											if (true)
											{
												continue;
											}
											goto case 23;
										}
										goto case 38;
									case 23:
										_003C_003Eu__4 = default;
										num4 = 43;
										continue;
									case 47:
										_003C_003Eu__5 = awaiter2;
										num4 = 61;
										continue;
									case 60:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									default:
										num4 = 12;
										if (true)
										{
											continue;
										}
										goto case 39;
									case 39:
										num2 = (_003C_003E1__state = -1);
										num4 = 26;
										if (true)
										{
											continue;
										}
										goto case 53;
									case 53:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 4);
											_003C_003Eu__3 = awaiter;
											num4 = 60;
											continue;
										}
										goto case 55;
									case 4:
										_003CpasteRange_003E5__3 = result2;
										num4 = 16;
										continue;
									case 5:
										if (((CvsCell)NdYm9cKHO5Kn2u6hoBhY(result, findCircleToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findCircleToolType.GeEljs1KbQ))).CellValue.Equals(1.0))
										{
											num4 = 32;
											continue;
										}
										goto end_IL_00ac;
									case 14:
										if (!awaiter3.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											num4 = 42;
											continue;
										}
										goto IL_06d8;
									case 8:
										text = (string)jAsgj8KHKjRaMaRZ47FD(findCircleToolType.FindInputFixtureCell(findCircleToolType._pasteObject));
										num4 = 11;
										continue;
									case 42:
										_003C_003Eu__1 = awaiter3;
										JocFodKUhCxbQuBXEB1t();
										if (oiq2HyKUuD5lGtGTd1nY())
										{
											num4 = 20;
											if (true)
											{
												continue;
											}
											goto case 59;
										}
										num4 = 15;
										continue;
									case 59:
										if (!awaiter4.IsCompleted)
										{
											num4 = 3;
											continue;
										}
										goto case 58;
									case 40:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 19:
										goto IL_06d8;
									case 38:
										awaiter5.GetResult();
										num4 = 8;
										continue;
									case 51:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									case 10:
										goto IL_0724;
									case 49:
										_003C_003Eu__2 = awaiter5;
										num4 = 46;
										continue;
									case 27:
										result = awaiter2.GetResult();
										num4 = 5;
										continue;
									case 1:
										return;
									case 30:
										awaiter4 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 59;
										if (0 == 0)
										{
											continue;
										}
										goto case 52;
									case 52:
										_003C_003Eu__5 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 9;
										continue;
									case 17:
										num2 = (_003C_003E1__state = 8);
										num4 = 22;
										if (oiq2HyKUuD5lGtGTd1nY())
										{
											continue;
										}
										goto case 32;
									case 32:
										zk58SZKHIm74rMXlwkMK(_003CnewTool_003E5__6, result);
										num4 = 63;
										continue;
									case 35:
										awaiter = PqwxRZKHwpLM8v8dBjbo(F7ocJjKHJuBk4g4gngIm(dkS5I9KUtwbkcR7mjPQJ(findCircleToolType.Inspect), findCircleToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findCircleToolType.DyclTnqx5T), editableAnnulus));
										num4 = 53;
										continue;
									case 37:
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 19;
										continue;
									case 56:
										_003C_003Eu__5 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 27;
										continue;
									case 0:
										awaiter.GetResult();
										num4 = 30;
										continue;
									case 12:
										return;
									case 18:
										num2 = (_003C_003E1__state = -1);
										goto case 15;
									case 57:
										return;
									case 62:
										goto IL_08b9;
									case 9:
										goto IL_08ce;
									case 26:
										awaiter.GetResult();
										num4 = 10;
										continue;
									case 54:
										awaiter = PqwxRZKHwpLM8v8dBjbo(InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)qyy3i4KH5D09fFyMpkjQ(findCircleToolType), text, cellLocation));
										num4 = 24;
										continue;
									case 48:
										awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num4 = 17;
											continue;
										}
										goto case 27;
									case 29:
										_003ColdPass_003E5__5 = oAgac1KHa41sgCbmswLp(result[findCircleToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findCircleToolType.GeEljs1KbQ)]).Equals(1.0);
										_003CnewTool_003E5__6 = new FindCircleTool((InspectStepViewModel)qyy3i4KH5D09fFyMpkjQ(findCircleToolType), isInitialized: false);
										awaiter = PqwxRZKHwpLM8v8dBjbo(_003CnewTool_003E5__6.SetCellRangeAsync(result, _003CpasteRange_003E5__3));
										num4 = 13;
										continue;
									case 63:
										goto end_IL_00ac;
									}
									break;
								}
								goto IL_00fb;
								IL_08b9:
								num2 = (_003C_003E1__state = -1);
								num4 = 38;
								if (true)
								{
									goto IL_0497;
								}
								goto IL_08ce;
								IL_0724:
								if (_003ColdPass_003E5__5)
								{
									break;
								}
								num4 = 48;
								goto IL_0497;
								IL_0134:
								_003C_003Eu__5 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num4 = 31;
								goto IL_0497;
								IL_06d8:
								result2 = awaiter3.GetResult();
								num4 = 4;
								goto IL_0497;
								IL_08ce:
								result = awaiter2.GetResult();
								num4 = 29;
								goto IL_0497;
								IL_00fb:
								_003C_003Eu__4 = awaiter4;
								num4 = 51;
								if (JocFodKUhCxbQuBXEB1t())
								{
									goto IL_0113;
								}
								goto IL_0497;
								IL_0113:
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								num4 = 55;
								if (1 == 0)
								{
									goto IL_0134;
								}
								goto IL_0497;
								end_IL_00ac:
								break;
							}
							result3 = _003CnewTool_003E5__6;
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_09ca;
						}
						goto end_IL_0073;
						IL_09ca:
						if (num3 == 1)
						{
							awaiter = PqwxRZKHwpLM8v8dBjbo(findCircleToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0a32;
						}
						goto IL_0a5b;
						IL_0a32:
						awaiter.GetResult();
						WaJSUUKHiMsRDkemDJiH(BLdnwaKHDkEW5ZUhQ7K6((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0a5b;
						IL_0a5b:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0073:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
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
		internal static object dkS5I9KUtwbkcR7mjPQJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oXOx9vKUzlx3yuflkUwb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int o5XXonKHLYAGthVG6Yyx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jAsgj8KHKjRaMaRZ47FD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qyy3i4KH5D09fFyMpkjQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter PqwxRZKHwpLM8v8dBjbo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F7ocJjKHJuBk4g4gngIm(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oAgac1KHa41sgCbmswLp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CSOEHeKHeuDbgHCKlsBJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FindCircleTool)P_0).AcceptThreshold;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NdYm9cKHO5Kn2u6hoBhY(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zk58SZKHIm74rMXlwkMK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).OnResultsChangedTool((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BLdnwaKHDkEW5ZUhQ7K6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WaJSUUKHiMsRDkemDJiH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oiq2HyKUuD5lGtGTd1nY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JocFodKUhCxbQuBXEB1t()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid[] d4wl4r1YD5;

	private readonly CvsCellLocation xiCllIHhS2;

	private readonly CvsCellLocation DyclTnqx5T;

	private readonly CvsCellLocation tmIlWMldId;

	private readonly CvsCellLocation GeEljs1KbQ;

	private CvsDisplayableCircle od4lChyulI;

	private CvsDisplayableAnnulus HUIlO1nmOK;

	private int oAulHVUq7x;

	private CvsEditableDisplayGraphic[] ybhlwuBXqN;

	private bool tMFly8QbUa;

	[CompilerGenerated]
	private EventHandler wRBlxIdyCm;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d4wl4r1YD5;
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
			return Resources.P4xtUtahBp();
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
			return (string)VsccL9jYODP2fetDRKe();
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
			return XAMLGraphicKeys.Tools_CircleIcon;
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
			return XAMLGraphicKeys.Tools_CircleIcon;
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
				(string)BNv3QXjUIx8Z3qhYAhY(),
				(string)TqwTNKjHR9m2nHAxPbQ()
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
			return oAulHVUq7x;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref oAulHVUq7x, value, (string)Duku2BjMxYYphKLy29f(3256));
		}
	}

	public bool ShowCircle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tMFly8QbUa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			CvsDisplayableCircle cvsDisplayableCircle = default;
			int num2 = default;
			CvsEditableDisplayGraphic[] array = default;
			while (true)
			{
				switch (num)
				{
				case 8:
					uR6vi3jmSAiAQR2lko9(cvsDisplayableCircle, (cvsDisplayableCircle == od4lChyulI) ? tMFly8QbUa : (!tMFly8QbUa));
					goto IL_0066;
				case 0:
				case 7:
				{
					EventHandler eventHandler = wRBlxIdyCm;
					if (eventHandler == null)
					{
						num = 1;
						if (!USok3ojTeqJEJViinNv())
						{
							return;
						}
					}
					else
					{
						QyssjEjQyMA2b0vN8RO(eventHandler, this, EventArgs.Empty);
						num = 11;
					}
					break;
				}
				case 1:
					return;
				case 5:
				case 9:
					if (num2 < array.Length)
					{
						cvsDisplayableCircle = array[num2] as CvsDisplayableCircle;
						uY2bWJjyuBxa2AmMkcO();
						num = (USok3ojTeqJEJViinNv() ? 3 : 0);
						break;
					}
					goto case 0;
				case 6:
					array = ybhlwuBXqN;
					num = 10;
					break;
				case 3:
				case 4:
					if (cvsDisplayableCircle != null)
					{
						goto case 8;
					}
					goto IL_0066;
				default:
					num = 8;
					break;
				case 10:
					num2 = 0;
					num = 9;
					break;
				case 2:
					if (SetField(ref tMFly8QbUa, value, (string)Duku2BjMxYYphKLy29f(25938)))
					{
						num = 6;
						break;
					}
					return;
				case 11:
					return;
					IL_0066:
					num2++;
					num = 5;
					break;
				}
			}
		}
	}

	public event EventHandler Invalidate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_005a;
			IL_001a:
			EventHandler eventHandler = wRBlxIdyCm;
			USok3ojTeqJEJViinNv();
			num = (uY2bWJjyuBxa2AmMkcO() ? 6 : 4);
			goto IL_005a;
			IL_005a:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 2:
					value2 = (EventHandler)DXcs1fjNbr24gKgDHLZ(eventHandler2, value);
					goto default;
				case 1:
				case 4:
					eventHandler2 = eventHandler;
					num = 2;
					continue;
				default:
					eventHandler = Interlocked.CompareExchange(ref wRBlxIdyCm, value2, eventHandler2);
					num = 5;
					continue;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!uY2bWJjyuBxa2AmMkcO()) ? 1 : 5);
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					eventHandler2 = wRBlxIdyCm;
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
				case 5:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						break;
					}
					goto case 6;
				case 3:
					value2 = (EventHandler)Delegate.Remove(eventHandler, value);
					goto case 2;
				default:
					num = 2;
					break;
				case 6:
					eventHandler = eventHandler2;
					num = 3;
					if (!uY2bWJjyuBxa2AmMkcO())
					{
						break;
					}
					goto case 2;
				case 2:
					eventHandler2 = Interlocked.CompareExchange(ref wRBlxIdyCm, value2, eventHandler);
					goto case 4;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FindCircleToolType()
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
			case 3:
				GeEljs1KbQ = _pasteObject.GetCellOffset((string)Duku2BjMxYYphKLy29f(24546));
				num = 8;
				continue;
			case 6:
				base._002Ector();
				num = 7;
				continue;
			case 10:
				DyclTnqx5T = _pasteObject.GetCellOffset((string)Duku2BjMxYYphKLy29f(25878));
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				Aei0MFj0GicgxrihD5Y();
				num = 9;
				continue;
			case 0:
			case 4:
				xiCllIHhS2 = _pasteObject.GetCellOffset((string)Duku2BjMxYYphKLy29f(4928));
				break;
			case 9:
				oAulHVUq7x = 120;
				num = 6;
				continue;
			case 7:
				_pasteObject = PasteBuffer.FromBytes((byte[])YITenGjF3D0PPNvQw7K());
				_ = 0;
				num = ((!USok3ojTeqJEJViinNv()) ? 1 : 0);
				continue;
			case 8:
				AddSnippet(_pasteObject);
				num = 11;
				continue;
			case 11:
				return;
			}
			tmIlWMldId = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6522));
			num = 10;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__26))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__27))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!USok3ojTeqJEJViinNv()) ? 3 : 4);
		_003COnBeginAddInternal_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = WN13ycjxdcKwGYPBqx4();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
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
		USok3ojTeqJEJViinNv();
		int num = (uY2bWJjyuBxa2AmMkcO() ? 1 : 5);
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic[] source = default;
		while (true)
		{
			CvsEditableDisplayGraphic[] array;
			switch (num)
			{
			case 4:
				ybhlwuBXqN = list.ToArray();
				num = 6;
				break;
			case 3:
				array = Array.Empty<CvsEditableDisplayGraphic>();
				goto IL_0043;
			case 1:
			case 2:
				FireAddGraphicsChanged(source.ToList(), list);
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 5:
				array = ybhlwuBXqN;
				if (array == null)
				{
					num = 3;
					break;
				}
				goto IL_0043;
			case 6:
				return;
				IL_0043:
				source = array;
				list = ovTlg9Cftx();
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<CvsEditableDisplayGraphic> ovTlg9Cftx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsEditableDisplayGraphic> list = new List<CvsEditableDisplayGraphic>();
		list.Add(HUIlO1nmOK);
		list.Add(od4lChyulI);
		if (Inspect.InSight.Results.Cells[CvsCellLocation.Parse(InputImageLinks[InputImageIndex].Expression)]?.CellResult.Value is CvsCogImage { Width: var width, Height: var height } cvsCogImage)
		{
			ICvsImageBuffer imageBuffer = CvsImageBufferFactory.FromBitmap(Inspect.InSight.CogSocket.GetImageByHttp(cvsCogImage.Url, new Size(width, height), new Rectangle(0, 0, width, height)), CnxPixelFormat.Format8bppGrayscale);
			RectangleF rectangleF = new RectangleF(cvsCogImage.OffsetX, cvsCogImage.OffsetY, width, height);
			CvsImage image = new CvsImage(imageBuffer, rectangleF, rectangleF);
			List<CvsEditableDisplayGraphic> list2 = new FeatureExtractor().FindCircles(image);
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
		return ybhlwuBXqN;
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
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__41))]
	internal Task<EzTool> yU6lMlvys2(CvsDisplayableCircle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__41 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editableCircle = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__42))]
	internal virtual Task<EzTool> AddTool(CvsDisplayableAnnulus editableAnnulus, CvsCellCollection cells = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__42 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editableAnnulus = editableAnnulus;
		stateMachine.cells = cells;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FindCircleToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Aei0MFj0GicgxrihD5Y();
		d4wl4r1YD5 = new Guid[1]
		{
			new Guid((string)Duku2BjMxYYphKLy29f(25962))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task y6xlR3PyMV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Aei0MFj0GicgxrihD5Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YITenGjF3D0PPNvQw7K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.FindCircle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Duku2BjMxYYphKLy29f(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool USok3ojTeqJEJViinNv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uY2bWJjyuBxa2AmMkcO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VsccL9jYODP2fetDRKe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OK8tNFFhfS();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BNv3QXjUIx8Z3qhYAhY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TqwTNKjHR9m2nHAxPbQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.A6xJ0EZQJY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder WN13ycjxdcKwGYPBqx4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uR6vi3jmSAiAQR2lko9(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).Visible = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QyssjEjQyMA2b0vN8RO(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DXcs1fjNbr24gKgDHLZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}
}
