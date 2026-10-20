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
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using afkBKMtfrvFgN7kBbq;
using d6U6rfDQgjJaEyFRUK;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Height;

[Export(typeof(EzToolType))]
public class HeightToolType : CompositeRegionToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public HeightToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private HeightTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!bsS0faKFgp5cqeo5IYLB())
			{
				goto IL_001e;
			}
			goto IL_020e;
			IL_001e:
			HeightToolType heightToolType = _003C_003E4__this;
			EcsgBVKFsbP6G1HnojwU();
			if (bsS0faKFgp5cqeo5IYLB())
			{
				num = 6;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0058;
				}
			}
			goto IL_020e;
			IL_0058:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_020e;
			IL_020e:
			EzTool result = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
					_003Ctool_003E5__2 = null;
					goto case 3;
				case 5:
					goto IL_0058;
				case 3:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 2:
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new HeightTool((InspectStepViewModel)yYHfgXKFvPJH7C4I94h4(heightToolType), isInitialized: true);
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (false)
							{
								goto IL_012a;
							}
						}
						goto IL_018a;
						IL_012a:
						_003C_003Eu__1 = default;
						goto IL_00a1;
						IL_016a:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_018a:
						while (true)
						{
							switch (num3)
							{
							case 6:
							case 8:
								break;
							case 1:
							case 7:
								goto IL_00ba;
							case 3:
								goto IL_00d9;
							case 2:
								return;
							case 5:
								goto IL_012a;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 9:
								goto IL_0157;
							case 0:
								goto IL_016a;
							default:
								num3 = 2;
								continue;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_007f;
							}
							break;
							IL_00d9:
							awaiter = HAq72FKFrPCpHF5H24Ps(_003Ctool_003E5__2.SetCellRangeAsync(cells, cellRange));
							EcsgBVKFsbP6G1HnojwU();
							if (bsS0faKFgp5cqeo5IYLB())
							{
								num3 = 7;
								if (1 == 0)
								{
									return;
								}
							}
							else
							{
								num3 = 8;
							}
						}
						goto IL_00a1;
						IL_0157:
						awaiter.GetResult();
						num3 = 10;
						if (1 == 0)
						{
							goto IL_016a;
						}
						goto IL_018a;
						IL_00ba:
						if (awaiter.IsCompleted)
						{
							goto IL_0157;
						}
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						goto IL_018a;
						IL_00a1:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (!bsS0faKFgp5cqeo5IYLB())
						{
							goto IL_00ba;
						}
						goto IL_018a;
						end_IL_007f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object yYHfgXKFvPJH7C4I94h4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter HAq72FKFrPCpHF5H24Ps(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bsS0faKFgp5cqeo5IYLB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EcsgBVKFsbP6G1HnojwU()
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

		public HeightToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lraLwOKFPlN6XCXg45x4();
			int num;
			if (!lJ5OFBKFZL2iTALgi2vd())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (lJ5OFBKFZL2iTALgi2vd())
				{
				}
			}
			int num2 = default;
			HeightToolType heightToolType = default;
			CvsCogRectangle acquired2DImageBounds = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					heightToolType = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							acquired2DImageBounds = heightToolType.GetAcquired2DImageBounds();
							num3 = 5;
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
							case 1:
							case 10:
								heightToolType.WuWRJ7sRWU = new CvsEditableDisplayGraphic[1] { heightToolType.EditableComposite };
								num3 = 0;
								continue;
							case 8:
								return;
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 2:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								break;
							case 4:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							case 0:
								awaiter = rHDZ1FKFBosKjiy5Z6hd(heightToolType.nXlRGaXjTF());
								num3 = 9;
								continue;
							case 5:
								heightToolType.EditableComposite = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 200.0, 0.0, 0.0, acquired2DImageBounds, mustBeExtrudeable: true);
								_ = 0;
								if (!lraLwOKFPlN6XCXg45x4())
								{
									num3 = 2;
									if (lraLwOKFPlN6XCXg45x4())
									{
										continue;
									}
									goto case 0;
								}
								num3 = 10;
								continue;
							case 11:
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
					goto case 1;
				default:
					num = 1;
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
		internal static TaskAwaiter rHDZ1FKFBosKjiy5Z6hd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lraLwOKFPlN6XCXg45x4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lJ5OFBKFZL2iTALgi2vd()
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
	private struct _003CAddTool_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public HeightToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private string _003CtoolName_003E5__5;

		private double _003Cheight_003E5__6;

		private HeightTool _003CnewTool_003E5__7;

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
			NgGLN4KFGxTrWAY8Rnwy();
			int num;
			if (JZBZffKFbvyeMcKRvJV4())
			{
				num = 5;
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_0041;
				}
			}
			goto IL_08fa;
			IL_0929:
			_003Csheet_003E5__2 = null;
			num = 3;
			goto IL_08fa;
			IL_0041:
			HeightToolType heightToolType = default;
			EzTool result4 = default;
			int num2 = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if ((uint)num2 > 9u)
				{
					if (num2 == 10)
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0875;
					}
					_003Csheet_003E5__2 = (CvsCogSocketSheet)tZ7UM2KFkuRHh9VAgiKV(((CvsInSight)Wnnqq2KFSXhF6KKta7wA(oAdkPqKFoJU68UYLXT9K(heightToolType))).CogSocket);
					_003CpasteRange_003E5__3 = CvsCellRange.Empty;
					num3 = 0;
				}
				try
				{
					TaskAwaiter<CvsCellRange> awaiter5;
					TaskAwaiter<object> awaiter4;
					TaskAwaiter<CvsCogSheetResult> awaiter3;
					TaskAwaiter<CvsCellCollection> awaiter2;
					CvsCellRange result;
					string expression;
					CvsCellLocation cellLocation;
					string text;
					CvsCellLocation cellLocation2;
					CvsCellCollection result3;
					switch (num2)
					{
					default:
					{
						PasteBuffer pasteObject = EzToolType.UpdateNamesInPasteBuffer(heightToolType._pasteObject, (InspectStepViewModel)oAdkPqKFoJU68UYLXT9K(heightToolType), out _003CtoolName_003E5__5);
						awaiter5 = heightToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
						if (!awaiter5.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter5;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
							return;
						}
						goto IL_011f;
					}
					case 0:
						awaiter5 = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_011f;
					case 1:
						awaiter4 = _003C_003Eu__2;
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_01c5;
					case 2:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0270;
					case 3:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_032f;
					case 4:
						awaiter3 = _003C_003Eu__4;
						_003C_003Eu__4 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0396;
					case 5:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0433;
					case 6:
						awaiter3 = _003C_003Eu__4;
						_003C_003Eu__4 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_04ae;
					case 7:
					{
						try
						{
							int num4;
							if (num2 != 7)
							{
								num4 = 3;
								goto IL_0590;
							}
							TaskAwaiter<double> awaiter6 = _003C_003Eu__5;
							goto IL_04eb;
							IL_04eb:
							_003C_003Eu__5 = default;
							num4 = 9;
							goto IL_0590;
							IL_0590:
							double result2 = default;
							while (true)
							{
								switch (num4)
								{
								case 6:
									result2 = awaiter6.GetResult();
									num4 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								case 3:
									awaiter6 = _003Csheet_003E5__2.GetCellPropertyAsync<double>(heightToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, heightToolType.TpFRYkTfVy), (string)QRVR0iKFqMyCTfOyP6vE(1524)).GetAwaiter();
									_ = 1;
									if (!NgGLN4KFGxTrWAY8Rnwy())
									{
										num4 = 10;
										continue;
									}
									num4 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 9;
								case 7:
									_003Cheight_003E5__6 = result2;
									num4 = 11;
									continue;
								case 0:
									return;
								case 9:
									num2 = (_003C_003E1__state = -1);
									num4 = 6;
									continue;
								case 1:
								case 10:
									if (awaiter6.IsCompleted)
									{
										goto case 6;
									}
									num4 = 8;
									if (true)
									{
										continue;
									}
									goto case 8;
								case 8:
									num2 = (_003C_003E1__state = 7);
									_003C_003Eu__5 = awaiter6;
									num4 = 2;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
									num4 = 0;
									continue;
								case 11:
									QcehfuKFX0OFDX0LKE8D(CvsTraceEzb.Info, QRVR0iKFqMyCTfOyP6vE(50262));
									goto end_IL_0590;
								}
								goto IL_04eb;
								continue;
								end_IL_0590:
								break;
							}
						}
						catch (CvsNetworkException ex)
						{
							CvsTraceEzb.Info.TraceMessage((string)iDwTsQKF3vL6PBDgOyZc(CdQUGaROfy7He9T0foW.KbIzwHEDLa(50296), EifJKdKF7dFdAdwNrvjs(ex)));
						}
						(double, double) minMax = HeightTool.GetMinMax(_003Cheight_003E5__6);
						Dictionary<string, object> inputs = new Dictionary<string, object>
						{
							{
								EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148)),
								minMax.Item1
							},
							{
								EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)),
								minMax.Item2
							}
						};
						awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults(inputs).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 8);
							_003C_003Eu__6 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_073e;
					}
					case 8:
						awaiter2 = _003C_003Eu__6;
						_003C_003Eu__6 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_073e;
					case 9:
						{
							awaiter = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							break;
						}
						IL_0396:
						awaiter3.GetResult();
						CvsTraceEzb.Info.TraceMessage(CdQUGaROfy7He9T0foW.KbIzwHEDLa(49436));
						awaiter = ((Task)ImUAHeKF4LGVBlMC2KvD(Wnnqq2KFSXhF6KKta7wA(oAdkPqKFoJU68UYLXT9K(heightToolType)), heightToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, heightToolType.iQtRnKisyd), heightToolType.EditableComposite)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 5);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0433;
						IL_011f:
						result = awaiter5.GetResult();
						_003CpasteRange_003E5__3 = result;
						CvsTraceEzb.Info.TraceMessage(CdQUGaROfy7He9T0foW.KbIzwHEDLa(49576));
						awaiter4 = _003Csheet_003E5__2.PutCellExpressionAsync(heightToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, heightToolType.KpmRZcv28O), (string)eQrUkaKF8hVgaIw5tUQQ(heightToolType.CurrentInputImageLink)).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter4;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_01c5;
						IL_01c5:
						awaiter4.GetResult();
						CvsTraceEzb.Info.TraceMessage((string)QRVR0iKFqMyCTfOyP6vE(49608));
						expression = heightToolType.FindInputFixtureCell(heightToolType._pasteObject).Expression;
						cellLocation = heightToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, heightToolType.KAQRtLINXF);
						awaiter = qKYJ97KFpjDR0QXdjGR7(JHE883KFESQ1vBmZl8K4(oAdkPqKFoJU68UYLXT9K(heightToolType), expression, cellLocation));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0270;
						IL_0433:
						awaiter.GetResult();
						QcehfuKFX0OFDX0LKE8D(CvsTraceEzb.Info, QRVR0iKFqMyCTfOyP6vE(49466));
						awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num2 = (_003C_003E1__state = 6);
							_003C_003Eu__4 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_04ae;
						IL_0270:
						awaiter.GetResult();
						QcehfuKFX0OFDX0LKE8D(CvsTraceEzb.Info, QRVR0iKFqMyCTfOyP6vE(49398));
						text = heightToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, heightToolType.ownR05MeBv).ToString();
						cellLocation2 = heightToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, heightToolType.D4LRVsN3jA);
						awaiter = ((Task)TByQ8vKF95cKtbgid0y8(oAdkPqKFoJU68UYLXT9K(heightToolType), text, cellLocation2)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 3);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_032f;
						IL_073e:
						result3 = awaiter2.GetResult();
						QcehfuKFX0OFDX0LKE8D(CvsTraceEzb.Info, QRVR0iKFqMyCTfOyP6vE(49842));
						_003CnewTool_003E5__7 = new HeightTool(heightToolType.Inspect, isInitialized: false);
						awaiter = _003CnewTool_003E5__7.SetCellRangeAsync(result3, _003CpasteRange_003E5__3).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 9);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
						IL_032f:
						awaiter.GetResult();
						awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num2 = (_003C_003E1__state = 4);
							_003C_003Eu__4 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_0396;
						IL_04ae:
						awaiter3.GetResult();
						QcehfuKFX0OFDX0LKE8D(CvsTraceEzb.Info, QRVR0iKFqMyCTfOyP6vE(49436));
						_003Cheight_003E5__6 = 0.0;
						goto case 7;
					}
					awaiter.GetResult();
					CvsTraceEzb.Info.TraceMessage((string)QRVR0iKFqMyCTfOyP6vE(50416));
					result4 = _003CnewTool_003E5__7;
				}
				catch (object obj)
				{
					_003C_003E7__wrap3 = obj;
					num3 = 1;
					goto IL_080d;
				}
				goto end_IL_0041;
				IL_080d:
				if (num3 == 1)
				{
					awaiter = qKYJ97KFpjDR0QXdjGR7(heightToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 10);
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0875;
				}
				goto IL_089e;
				IL_0875:
				awaiter.GetResult();
				hJNZewKF6wJXJaxUgedN(xigMeJKFj1Vw0iXsKQoj((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
				goto IL_089e;
				IL_089e:
				_003C_003E7__wrap3 = null;
				_003Csheet_003E5__2 = null;
				_003CpasteRange_003E5__3 = default;
				end_IL_0041:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Csheet_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0929;
			IL_08fa:
			while (true)
			{
				switch (num)
				{
				case 4:
					heightToolType = _003C_003E4__this;
					break;
				case 1:
				case 2:
					break;
				default:
					num = 6;
					continue;
				case 6:
					goto IL_0929;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 3:
					_003C_003Et__builder.SetResult(result4);
					num = 7;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0041;
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
		internal static object oAdkPqKFoJU68UYLXT9K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Wnnqq2KFSXhF6KKta7wA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tZ7UM2KFkuRHh9VAgiKV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eQrUkaKF8hVgaIw5tUQQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QRVR0iKFqMyCTfOyP6vE(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JHE883KFESQ1vBmZl8K4(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter qKYJ97KFpjDR0QXdjGR7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QcehfuKFX0OFDX0LKE8D(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TByQ8vKF95cKtbgid0y8(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputPlaneViewModel.ibey8PGG1m((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ImUAHeKF4LGVBlMC2KvD(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EifJKdKF7dFdAdwNrvjs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).InnerException;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iDwTsQKF3vL6PBDgOyZc(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xigMeJKFj1Vw0iXsKQoj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hJNZewKF6wJXJaxUgedN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JZBZffKFbvyeMcKRvJV4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NgGLN4KFGxTrWAY8Rnwy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__31 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public HeightToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__31(int _003C_003E1__state)
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
				case 5:
					base._002Ector();
					CX4s3iKFAT9b0fZgQU3l();
					num = ((!T77NkSKFCrQpEXspy3tH()) ? 4 : 0);
					continue;
				case 1:
					fFVA4AKFRcKh5W7gALMZ();
					num = 5;
					if (CX4s3iKFAT9b0fZgQU3l())
					{
					}
					continue;
				case 0:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				_003C_003El__initialThreadId = R0GofQKFW4sw6YWSjJ6A();
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
			int num = 4;
			if (CX4s3iKFAT9b0fZgQU3l())
			{
				goto IL_001e;
			}
			goto IL_00a1;
			IL_01ca:
			return false;
			IL_01b3:
			_003C_003E2__current = new vwi48nu0V1Jw83UB8d();
			num = 1;
			if (true)
			{
				goto IL_00a1;
			}
			goto IL_01ca;
			IL_015c:
			HeightToolType heightToolType = default;
			if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
			{
				_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, heightToolType.Localizer);
				num = 15;
				goto IL_00a1;
			}
			goto IL_0205;
			IL_001e:
			int num2 = default;
			switch (num2)
			{
			case 1:
				goto IL_0088;
			case 3:
				goto IL_00fa;
			case 2:
				goto IL_0191;
			case 0:
				goto IL_01cc;
			}
			num = 7;
			goto IL_00a1;
			IL_01cc:
			_003C_003E1__state = -1;
			_003CcurrentVersion_003E5__2 = a2TFx2KFTPgkZyUPqYf0(cells, range);
			_003ClatestVersion_003E5__3 = SnippetPasteBuffer.GetSnippetVersion(heightToolType._pasteObject);
			num = 0;
			goto IL_00a1;
			IL_0088:
			_003C_003E1__state = -1;
			goto IL_010b;
			IL_0191:
			_003C_003E1__state = -1;
			num = 16;
			goto IL_00a1;
			IL_00fa:
			_003C_003E1__state = -1;
			num = 17;
			goto IL_00a1;
			IL_010b:
			if (_003CcurrentVersion_003E5__2 >= 3)
			{
				goto IL_015c;
			}
			goto IL_01b3;
			IL_00a1:
			while (true)
			{
				switch (num)
				{
				case 11:
					break;
				case 15:
					_003C_003E1__state = 3;
					num = 5;
					continue;
				case 14:
					goto IL_004f;
				case 0:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						num = 14;
						continue;
					}
					goto IL_010b;
				case 12:
					return true;
				default:
					num = 2;
					continue;
				case 5:
					return true;
				case 2:
					goto IL_010b;
				case 4:
					num2 = _003C_003E1__state;
					num = 10;
					continue;
				case 10:
					heightToolType = _003C_003E4__this;
					num = 11;
					continue;
				case 6:
				case 8:
					_003C_003E1__state = 1;
					num = 12;
					if (true)
					{
						continue;
					}
					goto IL_015c;
				case 16:
					goto IL_015c;
				case 13:
					return true;
				case 1:
					_003C_003E1__state = 2;
					num = 13;
					continue;
				case 3:
				case 9:
					goto IL_01b3;
				case 7:
					goto IL_01ca;
				case 17:
					goto IL_0205;
				}
				break;
				IL_004f:
				_003C_003E2__current = new qvB7JqC99krLZ0V4yh();
				_ = 1;
				num = (CX4s3iKFAT9b0fZgQU3l() ? 3 : 8);
			}
			goto IL_001e;
			IL_0205:
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
			_003CGetUpdates_003Ed__31 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__31(0)
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
		internal static void fFVA4AKFRcKh5W7gALMZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int R0GofQKFW4sw6YWSjJ6A()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T77NkSKFCrQpEXspy3tH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CX4s3iKFAT9b0fZgQU3l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a2TFx2KFTPgkZyUPqYf0(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}
	}

	private readonly Guid[] NonRBfJR45;

	private readonly CvsCellLocation KpmRZcv28O;

	private readonly CvsCellLocation iQtRnKisyd;

	private readonly CvsCellLocation KAQRtLINXF;

	private readonly CvsCellLocation TpFRYkTfVy;

	private readonly CvsCellLocation ownR05MeBv;

	private readonly CvsCellLocation D4LRVsN3jA;

	private int zseRL73P4H;

	private CvsEditableDisplayGraphic[] WuWRJ7sRWU;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NonRBfJR45;
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
			return Resources.MeasureHeight;
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
			return (string)cJZHs37qRMn7MSceDEp();
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
			return XAMLGraphicKeys.Tools_HeightIcon;
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
			return XAMLGraphicKeys.Tools_HeightIcon;
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
				(string)T04JjD7Erhb7ZgK0NlG(),
				(string)AflFpr7pCoKtMCphbHR()
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
			return zseRL73P4H;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref zseRL73P4H, value, (string)BXw6nu7SVfq2MwqXjZE(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HeightToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (eGiPr47Gp97ipfTK2OQ())
		{
			goto IL_001e;
		}
		goto IL_009b;
		IL_001e:
		ownR05MeBv = _pasteObject.GetCellOffset((string)BXw6nu7SVfq2MwqXjZE(9218));
		SnippetLocalizer snippetLocalizer = (SnippetLocalizer)EseYd9785VLIBd0mRNk();
		num = 10;
		if (1 == 0)
		{
			goto IL_004c;
		}
		goto IL_009b;
		IL_009b:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 7:
			case 11:
				goto IL_004c;
			case 8:
				KAQRtLINXF = _pasteObject.GetCellOffset((string)BXw6nu7SVfq2MwqXjZE(6522));
				goto case 13;
			default:
				num = 13;
				continue;
			case 2:
			case 12:
				zseRL73P4H = 100;
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				D4LRVsN3jA = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(9162));
				num = 4;
				continue;
			case 5:
				iQtRnKisyd = _pasteObject.GetCellOffset((string)BXw6nu7SVfq2MwqXjZE(5684));
				num = 8;
				if (eGiPr47Gp97ipfTK2OQ())
				{
				}
				continue;
			case 10:
				snippetLocalizer.ExcludedStrings.Add(CdQUGaROfy7He9T0foW.KbIzwHEDLa(9252));
				goto IL_004c;
			case 1:
				goto IL_0176;
			case 6:
				IZHmYC7osH9e7R4tgn8();
				num = 1;
				if (AdIoOY7bYOn8jNlSmQK())
				{
					continue;
				}
				goto case 3;
			case 3:
				base._002Ector(is3d: true);
				_pasteObject = (PasteBuffer)gfIp9n7kE7OWMf1fd7e(Snippets.Height);
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 13;
			case 13:
				TpFRYkTfVy = _pasteObject.GetCellOffset((string)BXw6nu7SVfq2MwqXjZE(2374));
				num = 9;
				continue;
			case 0:
				KpmRZcv28O = _pasteObject.GetCellOffset((string)BXw6nu7SVfq2MwqXjZE(4928));
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 14:
				return;
			}
			break;
			IL_0176:
			NonRBfJR45 = new Guid[1]
			{
				new Guid((string)BXw6nu7SVfq2MwqXjZE(25026))
			};
			AdIoOY7bYOn8jNlSmQK();
			num = ((!eGiPr47Gp97ipfTK2OQ()) ? 12 : 7);
		}
		goto IL_001e;
		IL_004c:
		AddSnippet(_pasteObject, snippetLocalizer);
		num = 14;
		if (eGiPr47Gp97ipfTK2OQ())
		{
		}
		goto IL_009b;
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
		int num = 4;
		_003COnBeginAddInternal_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = RViUh47XJ6nCALTObK5();
				eGiPr47Gp97ipfTK2OQ();
				if (!AdIoOY7bYOn8jNlSmQK())
				{
					num = 0;
					continue;
				}
				num = 3;
				if (AdIoOY7bYOn8jNlSmQK())
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
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return WuWRJ7sRWU;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__30))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__30 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__31))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__31(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task nXlRGaXjTF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IZHmYC7osH9e7R4tgn8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BXw6nu7SVfq2MwqXjZE(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gfIp9n7kE7OWMf1fd7e(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EseYd9785VLIBd0mRNk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippetType.CreateDefaultSnippetLocalizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AdIoOY7bYOn8jNlSmQK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eGiPr47Gp97ipfTK2OQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cJZHs37qRMn7MSceDEp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.nn0t9kweuP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T04JjD7Erhb7ZgK0NlG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AflFpr7pCoKtMCphbHR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.aArVeOJEQe();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder RViUh47XJ6nCALTObK5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
