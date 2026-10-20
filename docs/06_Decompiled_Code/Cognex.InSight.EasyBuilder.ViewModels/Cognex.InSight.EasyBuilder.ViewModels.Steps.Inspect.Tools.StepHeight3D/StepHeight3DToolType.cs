using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
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
using Cognex.InSight.Remoting.Serialization;
using DWrDrVs8ghIMLdvQe6;
using T0vDBXnI5g5LopU5MC;
using afkBKMtfrvFgN7kBbq;
using d6U6rfDQgjJaEyFRUK;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.StepHeight3D;

[Export(typeof(EzToolType))]
public class StepHeight3DToolType : EzToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddTool_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public StepHeight3DToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private string _003CtoolName_003E5__5;

		private double _003Cdifference_003E5__6;

		private StepHeight3DTool _003CnewTool_003E5__7;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<double> _003C_003Eu__5;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__6;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EzTool result = default;
			StepHeight3DToolType stepHeight3DToolType = default;
			TaskAwaiter<double> awaiter6 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 0:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if ((uint)num2 > 10u)
						{
							if (num2 == 11)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_08fa;
							}
							_003Csheet_003E5__2 = ((CvsInSight)FF3cBpK4hc4VRrEAlaAp(JPRpePK4uW6ybR6Vgtvw(stepHeight3DToolType))).CogSocket.Sheet;
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							TaskAwaiter<CvsCellRange> awaiter5;
							TaskAwaiter<object> awaiter4;
							TaskAwaiter<CvsCogSheetResult> awaiter3;
							TaskAwaiter<CvsCellCollection> awaiter2;
							CvsCellRange result2;
							string text;
							CvsCellLocation cellLocation;
							string text2;
							CvsCellLocation cellLocation2;
							CvsCellCollection result4;
							switch (num2)
							{
							default:
							{
								PasteBuffer pasteObject = EzToolType.UpdateNamesInPasteBuffer(stepHeight3DToolType._pasteObject, (InspectStepViewModel)JPRpePK4uW6ybR6Vgtvw(stepHeight3DToolType), out _003CtoolName_003E5__5);
								awaiter5 = stepHeight3DToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
								if (!awaiter5.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter5;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									return;
								}
								goto IL_0110;
							}
							case 0:
								awaiter5 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0110;
							case 1:
								awaiter4 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_01b6;
							case 2:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0261;
							case 3:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0320;
							case 4:
								awaiter3 = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0387;
							case 5:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0424;
							case 6:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_04ac;
							case 7:
								awaiter3 = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0527;
							case 8:
							{
								try
								{
									int num4;
									if (num2 != 8)
									{
										num4 = 8;
										if (TrxvV4K41QsnSWiBfbBZ())
										{
											goto IL_056a;
										}
									}
									else
									{
										awaiter6 = _003C_003Eu__5;
										num4 = 2;
									}
									goto IL_05c9;
									IL_05c9:
									while (true)
									{
										switch (num4)
										{
										case 3:
											break;
										case 6:
											num2 = (_003C_003E1__state = 8);
											num4 = 0;
											continue;
										case 2:
											_003C_003Eu__5 = default;
											num4 = 7;
											continue;
										case 1:
										case 4:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
											return;
										default:
											return;
										case 7:
											num2 = (_003C_003E1__state = -1);
											num4 = 9;
											continue;
										case 0:
											_003C_003Eu__5 = awaiter6;
											h9jhfsK4cNw29giscN3O();
											if (TrxvV4K41QsnSWiBfbBZ())
											{
												num4 = 10;
												if (h9jhfsK4cNw29giscN3O())
												{
													continue;
												}
												goto case 7;
											}
											num4 = 1;
											continue;
										case 9:
											goto IL_0649;
										case 10:
											return;
										case 8:
											awaiter6 = _003Csheet_003E5__2.GetCellPropertyAsync<double>(stepHeight3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, stepHeight3DToolType.X0p3svpd9e), (string)XmpFNlK4tiKDD9x1pis3(1524)).GetAwaiter();
											num4 = 3;
											continue;
										case 11:
											L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, XmpFNlK4tiKDD9x1pis3(49638));
											goto end_IL_0553;
										}
										break;
									}
									goto IL_056a;
									IL_0649:
									double result3 = awaiter6.GetResult();
									_003Cdifference_003E5__6 = result3;
									num4 = 11;
									if (1 == 0)
									{
										return;
									}
									goto IL_05c9;
									IL_056a:
									if (!awaiter6.IsCompleted)
									{
										num4 = 6;
										goto IL_05c9;
									}
									goto IL_0649;
									end_IL_0553:;
								}
								catch (CvsNetworkException ex)
								{
									L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, zvmuOVK7esUyFemlfD6A(XmpFNlK4tiKDD9x1pis3(49680), fxhbyPK7aUBqraaEb3MX(ex)));
								}
								(double min, double max) minMax = StepHeight3DTool.GetMinMax(_003Cdifference_003E5__6);
								double item = minMax.min;
								double item2 = minMax.max;
								Dictionary<string, object> inputs = new Dictionary<string, object>
								{
									{
										EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)XmpFNlK4tiKDD9x1pis3(6148)),
										item
									},
									{
										EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)XmpFNlK4tiKDD9x1pis3(6138)),
										item2
									}
								};
								awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults(inputs).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 9);
									_003C_003Eu__6 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_07c3;
							}
							case 9:
								awaiter2 = _003C_003Eu__6;
								_003C_003Eu__6 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_07c3;
							case 10:
								{
									awaiter = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_0527:
								awaiter3.GetResult();
								L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, XmpFNlK4tiKDD9x1pis3(49436));
								_003Cdifference_003E5__6 = 0.0;
								goto case 8;
								IL_0110:
								result2 = awaiter5.GetResult();
								_003CpasteRange_003E5__3 = result2;
								L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, XmpFNlK4tiKDD9x1pis3(49576));
								awaiter4 = _003Csheet_003E5__2.PutCellExpressionAsync(stepHeight3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, stepHeight3DToolType.Jtw3krG8we), (string)Ro9RM4K7LbSROhNqvvgq(stepHeight3DToolType.CurrentInputImageLink)).GetAwaiter();
								if (!awaiter4.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter4;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									return;
								}
								goto IL_01b6;
								IL_0424:
								awaiter.GetResult();
								awaiter = QejXv1K752tunDlg0ydM(YigB30K7JBr3QKTDFN7A(FF3cBpK4hc4VRrEAlaAp(JPRpePK4uW6ybR6Vgtvw(stepHeight3DToolType)), stepHeight3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, stepHeight3DToolType.rBU3GhjA9E), stepHeight3DToolType.mGM3YLIJQS));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 6);
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_04ac;
								IL_01b6:
								awaiter4.GetResult();
								L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, XmpFNlK4tiKDD9x1pis3(49608));
								text = (string)d9CFTLK7KBdXEjsKgfZv(stepHeight3DToolType.FindInputFixtureCell(stepHeight3DToolType._pasteObject));
								cellLocation = stepHeight3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, stepHeight3DToolType.dBD3PeyGHe);
								awaiter = QejXv1K752tunDlg0ydM(InputFixtureViewModel.YnAyJgATSB(stepHeight3DToolType.Inspect, text, cellLocation));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0261;
								IL_0261:
								awaiter.GetResult();
								L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, XmpFNlK4tiKDD9x1pis3(49398));
								text2 = stepHeight3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, stepHeight3DToolType.dlD3BobmTg).ToString();
								cellLocation2 = stepHeight3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, stepHeight3DToolType.fmy3ZuOqMX);
								awaiter = QejXv1K752tunDlg0ydM(PuWQP1K7w2WtS9g4JqbE(JPRpePK4uW6ybR6Vgtvw(stepHeight3DToolType), text2, cellLocation2));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0320;
								IL_04ac:
								awaiter.GetResult();
								CvsTraceEzb.Info.TraceMessage((string)XmpFNlK4tiKDD9x1pis3(49466));
								awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 7);
									_003C_003Eu__4 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0527;
								IL_0320:
								awaiter.GetResult();
								awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 4);
									_003C_003Eu__4 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0387;
								IL_07c3:
								result4 = awaiter2.GetResult();
								L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, XmpFNlK4tiKDD9x1pis3(49842));
								_003CnewTool_003E5__7 = new StepHeight3DTool((InspectStepViewModel)JPRpePK4uW6ybR6Vgtvw(stepHeight3DToolType), isInitialized: false);
								awaiter = QejXv1K752tunDlg0ydM(bc1YKHK7OIHsPTXp28CB(_003CnewTool_003E5__7, result4, _003CpasteRange_003E5__3));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 10);
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
								IL_0387:
								awaiter3.GetResult();
								L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, XmpFNlK4tiKDD9x1pis3(49436));
								awaiter = QejXv1K752tunDlg0ydM(EditableGraphicHelper.SendGraphicAsync((CvsInSight)FF3cBpK4hc4VRrEAlaAp(JPRpePK4uW6ybR6Vgtvw(stepHeight3DToolType)), stepHeight3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, stepHeight3DToolType.RkA3Kf39PX), stepHeight3DToolType.vnb3tf0oJx));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0424;
							}
							awaiter.GetResult();
							L2lxQuK4zHWpvIgd1MWd(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49876));
							result = _003CnewTool_003E5__7;
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_0892;
						}
						goto end_IL_002e;
						IL_0892:
						if (num3 == 1)
						{
							awaiter = stepHeight3DToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 11);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_08fa;
						}
						goto IL_0923;
						IL_08fa:
						awaiter.GetResult();
						CO9kZfK7IbHqv856B4wI(ExceptionDispatchInfo.Capture((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0923;
						IL_0923:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_002e:;
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
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (h9jhfsK4cNw29giscN3O() ? 2 : 5);
					break;
				default:
					_003Csheet_003E5__2 = null;
					num = 6;
					break;
				case 1:
				case 2:
					stepHeight3DToolType = _003C_003E4__this;
					num = 0;
					if (TrxvV4K41QsnSWiBfbBZ())
					{
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
		internal static object JPRpePK4uW6ybR6Vgtvw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FF3cBpK4hc4VRrEAlaAp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XmpFNlK4tiKDD9x1pis3(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void L2lxQuK4zHWpvIgd1MWd(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ro9RM4K7LbSROhNqvvgq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d9CFTLK7KBdXEjsKgfZv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter QejXv1K752tunDlg0ydM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PuWQP1K7w2WtS9g4JqbE(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputPlaneViewModel.ibey8PGG1m((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YigB30K7JBr3QKTDFN7A(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fxhbyPK7aUBqraaEb3MX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).InnerException;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zvmuOVK7esUyFemlfD6A(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bc1YKHK7OIHsPTXp28CB(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CO9kZfK7IbHqv856B4wI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h9jhfsK4cNw29giscN3O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TrxvV4K41QsnSWiBfbBZ()
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

		public StepHeight3DToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private StepHeight3DTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!Itw4OyK7DZW2ORriNGj4()) ? 3 : 5);
			StepHeight3DToolType stepHeight3DToolType = default;
			int num2 = default;
			EzTool result = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					stepHeight3DToolType = _003C_003E4__this;
					num = 6;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					if (Itw4OyK7DZW2ORriNGj4())
					{
						break;
					}
					goto case 3;
				case 3:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 1:
					_003Ctool_003E5__2 = null;
					goto case 3;
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new StepHeight3DTool(stepHeight3DToolType.Inspect, isInitialized: true);
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							WgxPfEK7iWD12uCjNqym();
							if (!Itw4OyK7DZW2ORriNGj4())
							{
								num3 = 8;
								if (1 == 0)
								{
									goto IL_00b6;
								}
							}
							else
							{
								num3 = 9;
							}
						}
						goto IL_0145;
						IL_0145:
						while (true)
						{
							switch (num3)
							{
							case 3:
								num2 = (_003C_003E1__state = -1);
								goto IL_0182;
							case 0:
								break;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 5:
							case 9:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto IL_0182;
							case 7:
							case 8:
								goto IL_0182;
							case 6:
								return;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0079;
							}
							break;
						}
						goto IL_00b6;
						IL_0182:
						awaiter.GetResult();
						num3 = 10;
						goto IL_0145;
						IL_00b6:
						awaiter = RwsRabK7VWURs1R0xYr4(Jg4V0iK7nOV4Y6R0Wbqp(_003Ctool_003E5__2, cells, cellRange));
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							goto IL_0145;
						}
						goto IL_0182;
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
					goto case 1;
				default:
					num = 1;
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
		internal static object Jg4V0iK7nOV4Y6R0Wbqp(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter RwsRabK7VWURs1R0xYr4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Itw4OyK7DZW2ORriNGj4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WgxPfEK7iWD12uCjNqym()
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

		public StepHeight3DToolType _003C_003E4__this;

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
			StepHeight3DToolType stepHeight3DToolType = default;
			TaskAwaiter awaiter = default;
			CvsCogRectangle acquired2DImageBounds = default;
			CvsGraphicCircle cvsGraphicCircle2 = default;
			float num6 = default;
			float num5 = default;
			CvsGraphicCircle cvsGraphicCircle = default;
			PointF pointF = default;
			float num4 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					stepHeight3DToolType = _003C_003E4__this;
					YCIyGxK7dP3LI8QpQLsD();
					num = (QPZovwK7fmiQP19cobMw() ? 1 : 4);
					continue;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							stepHeight3DToolType.BaseShapeIndex = 1;
							num3 = 18;
							if (1 == 0)
							{
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								return;
							case 18:
								stepHeight3DToolType.MeasureShapeIndex = 1;
								num3 = 9;
								if (!YCIyGxK7dP3LI8QpQLsD())
								{
									continue;
								}
								goto case 3;
							case 3:
								stepHeight3DToolType.mGM3YLIJQS = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 0.0, 0.0, 1.0, 1.0, 0.0, 0.0, acquired2DImageBounds, mustBeExtrudeable: true);
								goto case 6;
							default:
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 14;
							case 14:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 13;
							case 0:
								UbwK5wK7s3VdF3FUFv6F(stepHeight3DToolType.mGM3YLIJQS.CompositeRegion, 0, cvsGraphicCircle2);
								num3 = 2;
								if (!YCIyGxK7dP3LI8QpQLsD())
								{
									continue;
								}
								goto case 15;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 19;
								if (0 == 0)
								{
									continue;
								}
								goto case 13;
							case 13:
							case 16:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 1:
								num6 = (float)poM9ZHK7PT5DFDx9OwLQ(rvjPDsK7r0T3QTt5keca(40.0) * (double)num5);
								num3 = 12;
								continue;
							case 2:
								awaiter = NdQCuwK7GoldrDx3vmlh(stepHeight3DToolType.HOf3qNHnvB());
								num3 = 14;
								continue;
							case 17:
								((CvsGraphic)fNpMOgK7gEIUPDDH5VhX(stepHeight3DToolType.vnb3tf0oJx)).Label = Resources.u0NBwaGMuh();
								UbwK5wK7s3VdF3FUFv6F(fNpMOgK7gEIUPDDH5VhX(stepHeight3DToolType.vnb3tf0oJx), 0, cvsGraphicCircle);
								num3 = 11;
								continue;
							case 4:
							case 7:
							{
								float x = pointF.X + num6;
								pointF = KmS48CK7Zq5roaHJW4Ya(cvsGraphicCircle);
								float y = pointF.Y - num4;
								cvsGraphicCircle2 = (CvsGraphicCircle)oiW4aiK7lfcgA7hOnJaX(x8XKIcK7BIltWmCDa668(x, y, irG0y9K7veNcBp2Dffm0(cvsGraphicCircle), acquired2DImageBounds, null));
								num3 = 3;
								continue;
							}
							case 8:
								cvsGraphicCircle = (CvsGraphicCircle)oiW4aiK7lfcgA7hOnJaX(EditableGraphicHelper.ConstructCircleCenteredToBounds(acquired2DImageBounds, null));
								stepHeight3DToolType.vnb3tf0oJx = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 0.0, 0.0, 1.0, 1.0, 0.0, 0.0, acquired2DImageBounds, mustBeExtrudeable: true);
								num3 = 17;
								continue;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 11:
								num5 = irG0y9K7veNcBp2Dffm0(cvsGraphicCircle) * 2f + 50f;
								num3 = 1;
								continue;
							case 9:
								acquired2DImageBounds = stepHeight3DToolType.GetAcquired2DImageBounds();
								num3 = 8;
								continue;
							case 12:
								num4 = (float)poM9ZHK7PT5DFDx9OwLQ(Math.Sin(40.0) * (double)num5);
								pointF = cvsGraphicCircle.Center;
								_ = 1;
								if (YCIyGxK7dP3LI8QpQLsD())
								{
									num3 = 16;
									continue;
								}
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								((CvsGraphic)fNpMOgK7gEIUPDDH5VhX(stepHeight3DToolType.mGM3YLIJQS)).Label = (string)WTAQtBK7bpmqtsyb6ead();
								num3 = 0;
								if (true)
								{
									continue;
								}
								break;
							case 19:
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
		internal static object oiW4aiK7lfcgA7hOnJaX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableCircle)P_0).CircleGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fNpMOgK7gEIUPDDH5VhX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableComposite)P_0).CompositeRegion;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UbwK5wK7s3VdF3FUFv6F(object P_0, int P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsGraphicCompositeBase)P_0).SetSubregionCircle(P_1, (CvsGraphicCircle)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static float irG0y9K7veNcBp2Dffm0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicCircle)P_0).Radius;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double rvjPDsK7r0T3QTt5keca(double P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Cos(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double poM9ZHK7PT5DFDx9OwLQ(double P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Abs(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF KmS48CK7Zq5roaHJW4Ya(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicCircle)P_0).Center;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x8XKIcK7BIltWmCDa668(float x, float y, float radius, object P_3, object P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.ConstructCircle(x, y, radius, (CvsCogRectangle)P_3, (string)P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WTAQtBK7bpmqtsyb6ead()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.cvXVlL2t7y();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter NdQCuwK7GoldrDx3vmlh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QPZovwK7fmiQP19cobMw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YCIyGxK7dP3LI8QpQLsD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__35 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public StepHeight3DToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__35(int _003C_003E1__state)
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
				default:
					_003C_003El__initialThreadId = Sgnx3pK7qMPM7AY7Ly5V();
					num = 6;
					break;
				case 1:
					iPiKBfK78vXI19xxX4G1(this);
					jE76XPK7ofJGssJEPg8P();
					num = (cNZsheK7SnXQGCwUxCwC() ? 4 : 0);
					break;
				case 0:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 5:
					JGAo1iK7kAgtu1M4UDxu();
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
			int num = 1;
			StepHeight3DToolType stepHeight3DToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 10:
					if (_003CcurrentVersion_003E5__2 >= 4)
					{
						goto case 8;
					}
					goto case 21;
				default:
					num = 21;
					continue;
				case 6:
					return true;
				case 20:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 9;
						continue;
					}
					break;
				case 16:
					return false;
				case 9:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, stepHeight3DToolType.Localizer);
					_003C_003E1__state = 5;
					num = 13;
					if (cNZsheK7SnXQGCwUxCwC())
					{
					}
					continue;
				case 0:
					return true;
				case 19:
					_003C_003E2__current = new JD90np4RpQKAJgWinN(stepHeight3DToolType.Localizer);
					_003C_003E1__state = 2;
					num = 6;
					continue;
				case 8:
					if (_003CcurrentVersion_003E5__2 < 5)
					{
						num = 7;
						continue;
					}
					goto case 20;
				case 2:
					return true;
				case 3:
					if (_003CcurrentVersion_003E5__2 < 3)
					{
						num = 19;
						continue;
					}
					goto case 4;
				case 15:
					stepHeight3DToolType = _003C_003E4__this;
					switch (num2)
					{
					case 2:
						break;
					case 0:
						goto IL_00d7;
					case 1:
						goto IL_0134;
					case 3:
						goto IL_0181;
					default:
						goto IL_01d3;
					case 4:
						goto IL_0213;
					case 5:
						goto IL_028e;
					}
					_003C_003E1__state = -1;
					goto case 4;
				case 14:
					_003C_003E2__current = new qvB7JqC99krLZ0V4yh();
					_ = 0;
					num = (jE76XPK7ofJGssJEPg8P() ? 11 : 4);
					continue;
				case 5:
				case 11:
					_003C_003E1__state = 1;
					num = 0;
					continue;
				case 17:
					return true;
				case 12:
					_003C_003E1__state = 3;
					num = 2;
					continue;
				case 1:
					num2 = _003C_003E1__state;
					num = 15;
					continue;
				case 18:
					_003ClatestVersion_003E5__3 = SnippetPasteBuffer.GetSnippetVersion(stepHeight3DToolType._pasteObject);
					if (_003CcurrentVersion_003E5__2 >= 2)
					{
						goto case 3;
					}
					num = 14;
					if (0 == 0)
					{
						continue;
					}
					goto case 21;
				case 21:
					_003C_003E2__current = new xugoOEMpIcVMHnelFo(stepHeight3DToolType.Localizer);
					num = 12;
					if (true)
					{
						continue;
					}
					goto case 13;
				case 13:
					return true;
				case 7:
					_003C_003E2__current = new vwi48nu0V1Jw83UB8d();
					_003C_003E1__state = 4;
					num = 17;
					if (true)
					{
						continue;
					}
					break;
				case 22:
					break;
					IL_028e:
					_003C_003E1__state = -1;
					num = 22;
					continue;
					IL_0213:
					_003C_003E1__state = -1;
					num = 20;
					continue;
					IL_01d3:
					num = 16;
					if (0 == 0)
					{
						continue;
					}
					goto case 14;
					IL_0181:
					_003C_003E1__state = -1;
					num = 8;
					if (jE76XPK7ofJGssJEPg8P())
					{
						continue;
					}
					goto case 3;
					IL_0134:
					_003C_003E1__state = -1;
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 19;
					IL_00d7:
					_003C_003E1__state = -1;
					_003CcurrentVersion_003E5__2 = lfU2AuK7EO4DQtyFl0YW(cells, range);
					num = 18;
					continue;
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
			_003CGetUpdates_003Ed__35 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__35(0)
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
		internal static void JGAo1iK7kAgtu1M4UDxu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iPiKBfK78vXI19xxX4G1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Sgnx3pK7qMPM7AY7Ly5V()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jE76XPK7ofJGssJEPg8P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cNZsheK7SnXQGCwUxCwC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int lfU2AuK7EO4DQtyFl0YW(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}
	}

	private static readonly Guid[] HeG3irmCLL;

	private readonly CvsCellLocation Jtw3krG8we;

	private readonly CvsCellLocation dBD3PeyGHe;

	private readonly CvsCellLocation X0p3svpd9e;

	private readonly CvsCellLocation RkA3Kf39PX;

	private readonly CvsCellLocation rBU3GhjA9E;

	private readonly CvsCellLocation dlD3BobmTg;

	private readonly CvsCellLocation fmy3ZuOqMX;

	private int uV53n1es8y;

	private CvsDisplayableComposite vnb3tf0oJx;

	private CvsDisplayableComposite mGM3YLIJQS;

	private int fov30RJ33L;

	private int VjV3VxPrhS;

	public override string ToolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)aDGmgXbQ9nBw8gAhXWr();
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
			return (string)QpidlubN1o14ARf0IDS();
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
			return XAMLGraphicKeys.Tools_StepHeightIcon;
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
			return XAMLGraphicKeys.Tools_StepHeightIcon;
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
				(string)iDnvq8b29msIVRkvsw1()
			};
		}
	}

	public string Directions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)fAt1g9bco1REqaaqP85();
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
			return uV53n1es8y;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref uV53n1es8y, value, (string)rUwi8AbxLU0nHJAj2Im(3256));
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
			return HeG3irmCLL;
		}
	}

	public int BaseShapeIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fov30RJ33L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Nfc3GRbMtOq8LvFLj0Q();
			int num;
			if (!OcyEyKbYj2UyVOMasGC())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (OcyEyKbYj2UyVOMasGC())
				{
				}
			}
			while (true)
			{
				switch (num)
				{
				case 4:
					FireAddGraphicsChanged(null, null);
					num = 5;
					break;
				case 0:
				case 3:
					if (SetField(ref fov30RJ33L, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(9276)))
					{
						goto case 1;
					}
					return;
				case 1:
				case 2:
					eFGIqZb1Ydkfn5Bcrvj(vnb3tf0oJx, BaseShapeIndex);
					goto case 4;
				default:
					num = 4;
					break;
				case 5:
					return;
				}
			}
		}
	}

	public int MeasureShapeIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VjV3VxPrhS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Nfc3GRbMtOq8LvFLj0Q();
			int num = (OcyEyKbYj2UyVOMasGC() ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					if (SetField(ref VjV3VxPrhS, value, (string)rUwi8AbxLU0nHJAj2Im(9308)))
					{
						goto case 1;
					}
					return;
				case 4:
					FireAddGraphicsChanged(null, null);
					num = 5;
					break;
				case 1:
				case 2:
					eFGIqZb1Ydkfn5Bcrvj(mGM3YLIJQS, MeasureShapeIndex);
					goto case 4;
				default:
					num = 4;
					break;
				case 5:
					return;
				}
			}
		}
	}

	public IReadOnlyList<string> Shapes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.EditableGraphicShapeNames(mustBeExtrudeable: true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StepHeight3DToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		SnippetLocalizer snippetLocalizer = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				dlD3BobmTg = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(9218));
				num = 10;
				break;
			case 6:
			case 9:
				RkA3Kf39PX = _pasteObject.GetCellOffset((string)rUwi8AbxLU0nHJAj2Im(8980));
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				rBU3GhjA9E = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(9004));
				fmy3ZuOqMX = _pasteObject.GetCellOffset((string)rUwi8AbxLU0nHJAj2Im(9162));
				num = 11;
				break;
			case 5:
				AddSnippet(_pasteObject, snippetLocalizer);
				num = 14;
				break;
			case 10:
				snippetLocalizer = (SnippetLocalizer)QefjAWbmUyAcedqqQuD();
				num = 4;
				break;
			case 8:
				voCnsYbUJhbsLY7ydBI();
				_ = 0;
				num = ((!Nfc3GRbMtOq8LvFLj0Q()) ? 9 : 7);
				break;
			case 1:
			case 7:
				uV53n1es8y = 405;
				num = 13;
				break;
			case 4:
				snippetLocalizer.ExcludedStrings.Add(CdQUGaROfy7He9T0foW.KbIzwHEDLa(9252));
				num = 5;
				break;
			case 3:
				X0p3svpd9e = _pasteObject.GetCellOffset((string)rUwi8AbxLU0nHJAj2Im(8956));
				goto case 6;
			case 13:
				base._002Ector();
				num = 0;
				if (Nfc3GRbMtOq8LvFLj0Q())
				{
					break;
				}
				goto case 12;
			case 12:
				dBD3PeyGHe = _pasteObject.GetCellOffset((string)rUwi8AbxLU0nHJAj2Im(6522));
				num = 3;
				break;
			case 0:
				_pasteObject = (PasteBuffer)vSy1pibHt25IrfQgh1G(Snippets.StepHeight3D);
				Jtw3krG8we = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928));
				num = 12;
				if (false)
				{
					return;
				}
				break;
			case 14:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsDisplayableComposite[2] { vnb3tf0oJx, mGM3YLIJQS };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__32))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__32 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
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
		Nfc3GRbMtOq8LvFLj0Q();
		int num;
		if (!OcyEyKbYj2UyVOMasGC())
		{
			num = 4;
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0042;
			}
		}
		goto IL_0076;
		IL_005c:
		_003COnBeginAddInternal_003Ed__34 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0042;
		IL_0042:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (1 == 0)
		{
			goto IL_005c;
		}
		goto IL_0076;
		IL_0076:
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E4__this = this;
				goto IL_005c;
			case 1:
				break;
			case 2:
			case 5:
				goto IL_005c;
			default:
				num = 1;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__35))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__35(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StepHeight3DToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		voCnsYbUJhbsLY7ydBI();
		HeG3irmCLL = new Guid[1]
		{
			new Guid((string)rUwi8AbxLU0nHJAj2Im(9346))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task HOf3qNHnvB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void voCnsYbUJhbsLY7ydBI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vSy1pibHt25IrfQgh1G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rUwi8AbxLU0nHJAj2Im(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QefjAWbmUyAcedqqQuD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippetType.CreateDefaultSnippetLocalizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Nfc3GRbMtOq8LvFLj0Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OcyEyKbYj2UyVOMasGC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aDGmgXbQ9nBw8gAhXWr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Ru6ViWeeMs();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QpidlubN1o14ARf0IDS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.pQjr2DTM3Q();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iDnvq8b29msIVRkvsw1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.aArVeOJEQe();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fAt1g9bco1REqaaqP85()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.kA1riA0Yn8();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eFGIqZb1Ydkfn5Bcrvj(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateGraphicShape((CvsDisplayableComposite)P_0, index);
	}
}
