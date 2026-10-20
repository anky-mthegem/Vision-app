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
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Brightness;

[Export(typeof(EzToolType))]
public class BrightnessToolType : CompositeRegionToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public BrightnessToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private BrightnessTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!LQpcKBKNRhadbPaq8frc()) ? 6 : 2);
			int num2 = default;
			BrightnessToolType brightnessToolType = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new BrightnessTool((InspectStepViewModel)mEXpipKNTMRUdFqE63d6(brightnessToolType), isInitialized: true);
							num3 = 9;
							if (1 == 0)
							{
								goto IL_0048;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (1 == 0)
							{
								goto IL_0152;
							}
						}
						goto IL_0061;
						IL_0061:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							default:
								num3 = 5;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									goto IL_00a8;
								}
								goto case 4;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter = _003Ctool_003E5__2.SetCellRangeAsync(cells, cellRange).GetAwaiter();
								num3 = 1;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto case 4;
							case 4:
							case 7:
								awaiter.GetResult();
								num3 = 10;
								if (LQpcKBKNRhadbPaq8frc())
								{
									continue;
								}
								return;
							case 8:
								return;
							case 5:
								goto IL_0152;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0024;
							}
							break;
							IL_00a8:
							J0LVweKNWty7Q7X3LjAR();
							num3 = ((!LQpcKBKNRhadbPaq8frc()) ? 4 : 6);
						}
						goto IL_0048;
						IL_0152:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						goto IL_0061;
						IL_0048:
						_003C_003Eu__1 = awaiter;
						goto IL_0152;
						end_IL_0024:;
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
					break;
				case 4:
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (J0LVweKNWty7Q7X3LjAR())
					{
					}
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					brightnessToolType = _003C_003E4__this;
					num = 1;
					break;
				case 3:
					_003Ctool_003E5__2 = null;
					goto case 4;
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
		internal static object mEXpipKNTMRUdFqE63d6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LQpcKBKNRhadbPaq8frc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J0LVweKNWty7Q7X3LjAR()
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
	private struct _003COnBeginAddInternal_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BrightnessToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0208;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0208;
			IL_0208:
			BrightnessToolType brightnessToolType = default;
			int num2 = default;
			CvsCogRectangle acquired2DImageBounds = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					brightnessToolType = _003C_003E4__this;
					num = 0;
					continue;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							acquired2DImageBounds = brightnessToolType.GetAcquired2DImageBounds();
							_ = 1;
							num3 = (OoqddWKN07KI9WdKAIHY() ? 4 : 2);
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
							case 0:
							case 2:
								brightnessToolType.EditableComposite = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 200.0, 0.0, 0.0, acquired2DImageBounds);
								num3 = 1;
								continue;
							case 1:
								brightnessToolType.BNpOF8uWlk = new CvsEditableDisplayGraphic[1] { brightnessToolType.EditableComposite };
								num3 = 9;
								continue;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 8;
								if (pPRmdTKNy7u7rPSm76vv())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 9:
								awaiter = UwjaZuKNFNEX2lj4FAao(brightnessToolType.pj0OUtKSaG());
								num3 = 6;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto default;
							case 7:
								return;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								break;
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
					break;
				case 2:
					do
					{
						num2 = _003C_003E1__state;
						_ = 0;
						if (!pPRmdTKNy7u7rPSm76vv())
						{
							num = 5;
							continue;
						}
						num = 4;
						if (0 == 0)
						{
							break;
						}
						return;
					}
					while (false);
					continue;
				case 6:
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
		internal static TaskAwaiter UwjaZuKNFNEX2lj4FAao(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pPRmdTKNy7u7rPSm76vv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OoqddWKN07KI9WdKAIHY()
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
	private struct _003CAddTool_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public BrightnessToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private string _003CtoolName_003E5__5;

		private BrightnessTool _003CnewTool_003E5__6;

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
			int num = 6;
			BrightnessToolType brightnessToolType = default;
			EzTool result = default;
			TaskAwaiter awaiter = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<CvsCogSheetResult> awaiter5 = default;
			TaskAwaiter<object> awaiter6 = default;
			TaskAwaiter<double> awaiter4 = default;
			TaskAwaiter<CvsCellRange> awaiter3 = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			(double, double) minMax = default;
			string text = default;
			CvsCellLocation cellLocation = default;
			Dictionary<string, object> dictionary = default;
			CvsCellCollection result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					num2 = _003C_003E1__state;
					jistg4KNMtg5GxEKrsGH();
					num = (X7Gqf5KNYmax4aIC2w1B() ? 5 : 4);
					break;
				default:
					_003Csheet_003E5__2 = null;
					num = 0;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					brightnessToolType = _003C_003E4__this;
					num = 2;
					break;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
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
								goto IL_0b24;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)zyLfeCKNxN1Fmb1uWQZZ(((CvsInSight)Xh75SRKNHWSN44fXdM8G(atPdsbKNUwtD2qYd29Te(brightnessToolType))).CogSocket);
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(brightnessToolType._pasteObject, (InspectStepViewModel)atPdsbKNUwtD2qYd29Te(brightnessToolType), out _003CtoolName_003E5__5);
								num4 = 22;
								goto IL_0305;
							case 3:
								awaiter5 = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num4 = 16;
								goto IL_0305;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 4;
								goto IL_0305;
							case 1:
								awaiter6 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num4 = 30;
								goto IL_0305;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 5;
								if (X7Gqf5KNYmax4aIC2w1B())
								{
								}
								goto IL_0305;
							case 5:
								awaiter5 = _003C_003Eu__4;
								num4 = 39;
								if (!X7Gqf5KNYmax4aIC2w1B())
								{
									goto IL_0305;
								}
								goto IL_0762;
							case 6:
								awaiter4 = _003C_003Eu__5;
								num4 = 52;
								if (true)
								{
									goto IL_0305;
								}
								goto IL_084c;
							case 8:
								awaiter = _003C_003Eu__3;
								num4 = 62;
								goto IL_0305;
							case 0:
								awaiter3 = _003C_003Eu__1;
								num4 = 48;
								if (true)
								{
									goto IL_0305;
								}
								goto IL_08f5;
							case 7:
								{
									awaiter2 = _003C_003Eu__6;
									num4 = 34;
									goto IL_0305;
								}
								IL_0305:
								while (true)
								{
									switch (num4)
									{
									case 52:
										_003C_003Eu__5 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 61;
										continue;
									case 59:
										num2 = (_003C_003E1__state = -1);
										goto IL_0120;
									case 13:
										awaiter5 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 36;
										continue;
									case 25:
										num2 = (_003C_003E1__state = 8);
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 45;
										if (0 == 0)
										{
											continue;
										}
										goto case 27;
									case 27:
									case 35:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									case 41:
										num2 = (_003C_003E1__state = 1);
										X7Gqf5KNYmax4aIC2w1B();
										if (jistg4KNMtg5GxEKrsGH())
										{
											num4 = 67;
											if (true)
											{
												continue;
											}
											goto case 61;
										}
										num4 = 35;
										if (0 == 0)
										{
											continue;
										}
										goto case 5;
									case 61:
									{
										double result4 = awaiter4.GetResult();
										mZhOWCKNQjXvXRGw2Nyu(CvsTraceEzb.Info, xsSkW7KNmZ19mZdRVyc0(50942));
										minMax = BrightnessTool.GetMinMax(result4);
										num4 = 15;
										if (0 == 0)
										{
											continue;
										}
										goto case 14;
									}
									case 14:
										mZhOWCKNQjXvXRGw2Nyu(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49436));
										num4 = 7;
										continue;
									case 26:
									{
										CvsCellRange result3 = awaiter3.GetResult();
										_003CpasteRange_003E5__3 = result3;
										num4 = 60;
										continue;
									}
									case 55:
										awaiter = sOOoBWKNulA0IblsflrD(rWYNI1KN1w0fJXyrHgnL(brightnessToolType.Inspect, text, cellLocation));
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											_003C_003Eu__3 = awaiter;
											num4 = 58;
											if (0 == 0)
											{
												continue;
											}
											goto case 31;
										}
										goto IL_0855;
									case 31:
										mZhOWCKNQjXvXRGw2Nyu(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49608));
										num4 = 54;
										continue;
									case 58:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 43;
										continue;
									case 54:
										text = (string)DwlppQKNcyo17pWqOcs2(brightnessToolType.FindInputFixtureCell(brightnessToolType._pasteObject));
										num4 = 57;
										continue;
									case 6:
										mZhOWCKNQjXvXRGw2Nyu(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49842));
										num4 = 47;
										if (0 == 0)
										{
											continue;
										}
										goto case 28;
									case 28:
										num2 = (_003C_003E1__state = 4);
										goto case 19;
									default:
										num4 = 19;
										continue;
									case 49:
										mZhOWCKNQjXvXRGw2Nyu(CvsTraceEzb.Info, xsSkW7KNmZ19mZdRVyc0(49436));
										num4 = 66;
										if (0 == 0)
										{
											continue;
										}
										goto case 15;
									case 15:
										dictionary = new Dictionary<string, object> { 
										{
											EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)xsSkW7KNmZ19mZdRVyc0(6148)),
											minMax.Item1
										} };
										num4 = 3;
										continue;
									case 43:
										return;
									case 3:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)), minMax.Item2);
										num4 = 32;
										continue;
									case 51:
										if (!awaiter.IsCompleted)
										{
											num4 = 25;
											continue;
										}
										goto IL_0120;
									case 18:
										num2 = (_003C_003E1__state = -1);
										num4 = 46;
										continue;
									case 10:
										if (!awaiter2.IsCompleted)
										{
											num2 = (_003C_003E1__state = 7);
											num4 = 0;
											continue;
										}
										goto case 46;
									case 8:
										_003C_003Eu__4 = awaiter5;
										num4 = 38;
										continue;
									case 40:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 42;
										continue;
									case 65:
										mZhOWCKNQjXvXRGw2Nyu(CvsTraceEzb.Info, xsSkW7KNmZ19mZdRVyc0(49398));
										num4 = 17;
										if (true)
										{
											continue;
										}
										goto case 33;
									case 33:
										mZhOWCKNQjXvXRGw2Nyu(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(50984));
										num4 = 68;
										continue;
									case 20:
										break;
									case 53:
										awaiter = sOOoBWKNulA0IblsflrD(HeKjV8KNtUC9JCjJxIa1(_003CnewTool_003E5__6, result2, _003CpasteRange_003E5__3));
										num4 = 51;
										continue;
									case 11:
									case 67:
										_003C_003Eu__2 = awaiter6;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
										return;
									case 57:
										cellLocation = brightnessToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, brightnessToolType.XsnOdcc4Ic);
										num4 = 55;
										if (0 == 0)
										{
											continue;
										}
										goto case 2;
									case 2:
										awaiter5.GetResult();
										num4 = 14;
										continue;
									case 1:
										num2 = (_003C_003E1__state = -1);
										num4 = 26;
										continue;
									case 39:
										_003C_003Eu__4 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_0652;
									case 42:
										return;
									case 4:
										_003C_003Eu__3 = default;
										num4 = 63;
										continue;
									case 16:
										num2 = (_003C_003E1__state = -1);
										num4 = 2;
										if (jistg4KNMtg5GxEKrsGH())
										{
											continue;
										}
										goto case 50;
									case 50:
										awaiter6 = _003Csheet_003E5__2.PutCellExpressionAsync(brightnessToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, brightnessToolType.cYAONIB4Ip), (string)pYEQBlKN2dfwdsnE2MVY(brightnessToolType.InputImageLinks[AcA1fwKNNloHjM2w2k6a(brightnessToolType)])).GetAwaiter();
										num4 = 12;
										continue;
									case 17:
										awaiter5 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 64;
										continue;
									case 21:
										num2 = (_003C_003E1__state = 3);
										num4 = 23;
										continue;
									case 38:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									case 62:
										goto IL_0762;
									case 23:
										_003C_003Eu__4 = awaiter5;
										goto case 27;
									case 5:
										_003C_003Eu__3 = default;
										num4 = 20;
										if (jistg4KNMtg5GxEKrsGH())
										{
											continue;
										}
										goto case 32;
									case 32:
										awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults(dictionary).GetAwaiter();
										num4 = 10;
										if (!X7Gqf5KNYmax4aIC2w1B())
										{
											continue;
										}
										goto case 48;
									case 48:
										_003C_003Eu__1 = default;
										num4 = 1;
										continue;
									case 34:
										_003C_003Eu__6 = default;
										num4 = 18;
										if (0 == 0)
										{
											continue;
										}
										goto case 19;
									case 19:
										_003C_003Eu__3 = awaiter;
										num4 = 40;
										if (true)
										{
											continue;
										}
										goto case 9;
									case 9:
										num2 = (_003C_003E1__state = 6);
										_003C_003Eu__5 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									case 63:
										goto IL_084c;
									case 37:
										if (!awaiter3.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											num4 = 24;
											if (0 == 0)
											{
												continue;
											}
											return;
										}
										goto case 26;
									case 45:
										return;
									case 12:
										if (!awaiter6.IsCompleted)
										{
											num4 = 41;
											continue;
										}
										goto case 44;
									case 64:
										if (!awaiter5.IsCompleted)
										{
											num4 = 21;
											continue;
										}
										goto case 2;
									case 44:
										awaiter6.GetResult();
										num4 = 31;
										continue;
									case 56:
										return;
									case 7:
										goto IL_08f5;
									case 60:
										mZhOWCKNQjXvXRGw2Nyu(CvsTraceEzb.Info, xsSkW7KNmZ19mZdRVyc0(49576));
										num4 = 50;
										if (!X7Gqf5KNYmax4aIC2w1B())
										{
											continue;
										}
										goto case 24;
									case 24:
										_003C_003Eu__1 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 56;
										continue;
									case 36:
										if (!awaiter5.IsCompleted)
										{
											num2 = (_003C_003E1__state = 5);
											num4 = 8;
											continue;
										}
										goto IL_0652;
									case 22:
										awaiter3 = brightnessToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										num4 = 37;
										continue;
									case 47:
										_003CnewTool_003E5__6 = new BrightnessTool((InspectStepViewModel)atPdsbKNUwtD2qYd29Te(brightnessToolType), isInitialized: false);
										num4 = 53;
										if (!X7Gqf5KNYmax4aIC2w1B())
										{
											continue;
										}
										goto case 66;
									case 66:
										awaiter4 = _003Csheet_003E5__2.GetCellPropertyAsync<double>(brightnessToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, brightnessToolType.FVbO6wUuZ8), (string)xsSkW7KNmZ19mZdRVyc0(1524)).GetAwaiter();
										if (awaiter4.IsCompleted)
										{
											goto case 61;
										}
										num4 = 9;
										if (jistg4KNMtg5GxEKrsGH())
										{
											continue;
										}
										goto case 29;
									case 29:
										CvsTraceEzb.Info.TraceMessage((string)xsSkW7KNmZ19mZdRVyc0(49466));
										num4 = 13;
										continue;
									case 0:
										_003C_003Eu__6 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									case 30:
										num2 = (_003C_003E1__state = -1);
										num4 = 44;
										continue;
									case 46:
										result2 = awaiter2.GetResult();
										num4 = 6;
										continue;
									case 68:
										{
											result = _003CnewTool_003E5__6;
											goto end_IL_00ac;
										}
										IL_0652:
										awaiter5.GetResult();
										num4 = 49;
										if (X7Gqf5KNYmax4aIC2w1B())
										{
										}
										continue;
										IL_0120:
										awaiter.GetResult();
										num4 = 33;
										if (0 == 0)
										{
											continue;
										}
										goto case 13;
									}
									break;
								}
								num2 = (_003C_003E1__state = -1);
								goto IL_0585;
								IL_08f5:
								awaiter = sOOoBWKNulA0IblsflrD(egMnYDKNhFp10x3orilG(Xh75SRKNHWSN44fXdM8G(atPdsbKNUwtD2qYd29Te(brightnessToolType)), brightnessToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, brightnessToolType.OQLOAIMsSh), brightnessToolType.EditableComposite));
								if (!awaiter.IsCompleted)
								{
									num4 = 28;
									goto IL_0305;
								}
								goto IL_0585;
								IL_0855:
								awaiter.GetResult();
								num4 = 65;
								goto IL_0305;
								IL_084c:
								num2 = (_003C_003E1__state = -1);
								goto IL_0855;
								IL_0762:
								_003C_003Eu__3 = default;
								num4 = 59;
								goto IL_0305;
								IL_0585:
								awaiter.GetResult();
								num4 = 29;
								goto IL_0305;
								end_IL_00ac:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_0abc;
						}
						goto end_IL_0073;
						IL_0abc:
						if (num3 == 1)
						{
							awaiter = sOOoBWKNulA0IblsflrD(brightnessToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0b24;
						}
						goto IL_0b4d;
						IL_0b24:
						awaiter.GetResult();
						tmIepAKNznNdSoqwlsND(ExceptionDispatchInfo.Capture((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0b4d;
						IL_0b4d:
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
		internal static object atPdsbKNUwtD2qYd29Te(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xh75SRKNHWSN44fXdM8G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zyLfeCKNxN1Fmb1uWQZZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xsSkW7KNmZ19mZdRVyc0(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mZhOWCKNQjXvXRGw2Nyu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int AcA1fwKNNloHjM2w2k6a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pYEQBlKN2dfwdsnE2MVY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DwlppQKNcyo17pWqOcs2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rWYNI1KN1w0fJXyrHgnL(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter sOOoBWKNulA0IblsflrD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object egMnYDKNhFp10x3orilG(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HeKjV8KNtUC9JCjJxIa1(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tmIepAKNznNdSoqwlsND(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jistg4KNMtg5GxEKrsGH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X7Gqf5KNYmax4aIC2w1B()
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

		public static Func<PasteBuffer, string> _003C_003E9__29_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kTQy2AK25pRp0CfaRDn1();
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
			n01oAIK2wyjFHXYpLOcM(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetUpdates_003Eb__29_0(PasteBuffer buffer)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellLocation((string)IIJkZUK2JMlGq2sOslHj(SnippetPasteBuffer.GetCellInTool(buffer, CdQUGaROfy7He9T0foW.KbIzwHEDLa(19504)))).ToString(absoluteRow: true, absoluteColumn: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kTQy2AK25pRp0CfaRDn1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JFBNhhK2LkMfRqaSdxi8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zITrDlK2KYAZp1rfs0ki()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void n01oAIK2wyjFHXYpLOcM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IIJkZUK2JMlGq2sOslHj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Location;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__29 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public BrightnessToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__29(int _003C_003E1__state)
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
			goto IL_0087;
			IL_001a:
			QSpbm8K2OQqtVTfAgUUD(this);
			_ = 1;
			num = ((!fAXPPAK2erovEVrbha9U()) ? 1 : 5);
			goto IL_0087;
			IL_0087:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
					num = 6;
					if (fAXPPAK2erovEVrbha9U())
					{
					}
					continue;
				case 0:
					QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
					num = 4;
					if (fAXPPAK2erovEVrbha9U())
					{
					}
					continue;
				case 1:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
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
			int num = 14;
			BrightnessToolType brightnessToolType = default;
			CvsCellLocation offset = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
				case 9:
					_003ClatestVersion_003E5__3 = kwMTDmK2DUIRTlOnq9iC(brightnessToolType._pasteObject);
					num = 0;
					continue;
				case 2:
					_003C_003E1__state = 3;
					num = 11;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
					_003C_003E2__current = new EditArgumentUpdate(offset, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer buffer) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return new CvsCellLocation((string)_003C_003Ec.IIJkZUK2JMlGq2sOslHj(SnippetPasteBuffer.GetCellInTool(buffer, CdQUGaROfy7He9T0foW.KbIzwHEDLa(19504)))).ToString(absoluteRow: true, absoluteColumn: true);
					}, 1, null);
					num = 10;
					if (OrkdksK2aP3Y6er0P93Q())
					{
						continue;
					}
					goto case 6;
				case 6:
					return false;
				case 3:
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					_003C_003E1__state = 2;
					return true;
				case 12:
					brightnessToolType = _003C_003E4__this;
					num = 1;
					continue;
				case 11:
					return true;
				case 14:
					num2 = _003C_003E1__state;
					num = 12;
					if (true)
					{
						continue;
					}
					goto case 8;
				case 8:
					_003CcurrentVersion_003E5__2 = H6fuI6K2IgamTMnlndUT(cells, range);
					_ = 0;
					num = ((!OrkdksK2aP3Y6er0P93Q()) ? 15 : 9);
					continue;
				case 7:
				case 15:
					offset = new CvsCellLocation(3, 1);
					goto case 4;
				default:
					num = 4;
					continue;
				case 0:
					if (_003CcurrentVersion_003E5__2 >= 1)
					{
						goto IL_00b5;
					}
					goto case 7;
				case 1:
					switch (num2)
					{
					case 0:
						break;
					case 2:
						goto IL_00ae;
					case 3:
						goto IL_00e3;
					default:
						goto IL_01d8;
					case 1:
						goto IL_021f;
					}
					_003C_003E1__state = -1;
					num = 8;
					continue;
				case 10:
					_003C_003E1__state = 1;
					num = 16;
					if (0 == 0)
					{
						continue;
					}
					goto case 13;
				case 13:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, brightnessToolType.Localizer);
					num = 2;
					continue;
				case 16:
					return true;
				case 17:
					break;
					IL_021f:
					_003C_003E1__state = -1;
					num = 3;
					continue;
					IL_01d8:
					num = 6;
					if (OrkdksK2aP3Y6er0P93Q())
					{
						continue;
					}
					goto case 10;
					IL_00e3:
					_003C_003E1__state = -1;
					num = 17;
					continue;
					IL_00ae:
					_003C_003E1__state = -1;
					goto IL_00b5;
					IL_00b5:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 13;
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
			_003CGetUpdates_003Ed__29 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__29(0)
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
		internal static void QSpbm8K2OQqtVTfAgUUD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OrkdksK2aP3Y6er0P93Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fAXPPAK2erovEVrbha9U()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int H6fuI6K2IgamTMnlndUT(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int kwMTDmK2DUIRTlOnq9iC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] c0OO7yRleA;

	private readonly CvsCellLocation cYAONIB4Ip;

	private readonly CvsCellLocation OQLOAIMsSh;

	private readonly CvsCellLocation XsnOdcc4Ic;

	private readonly CvsCellLocation FVbO6wUuZ8;

	private int h2WOuOwEnb;

	private CvsEditableDisplayGraphic[] BNpOF8uWlk;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c0OO7yRleA;
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
			return Resources.Brightness;
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
			return (string)Q8r94KTJfnAO067mriC();
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
			return XAMLGraphicKeys.Tools_BrightnessIcon;
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
			return XAMLGraphicKeys.Tools_BrightnessIcon;
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
				(string)yPQEHMTaWDaQ7TMpjBh(),
				Resources.A6xJ0EZQJY()
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
			return h2WOuOwEnb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref h2WOuOwEnb, value, (string)XKWRPZTwl7knZRPSUWZ(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BrightnessToolType()
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
			case 5:
				UiTXVGTLRJqZDXtKqNN();
				_ = 0;
				if (SRHY7ZWtc7rMRYtTbYL())
				{
					num = 7;
					continue;
				}
				num = 10;
				if (SRHY7ZWtc7rMRYtTbYL())
				{
					continue;
				}
				goto case 4;
			case 3:
				OQLOAIMsSh = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5684));
				num = 8;
				continue;
			case 6:
				_pasteObject = (PasteBuffer)oIAQmIT5LW3MlN8Yw4G(IJnOiOTKAufAM1JIWUo());
				cYAONIB4Ip = _pasteObject.GetCellOffset((string)XKWRPZTwl7knZRPSUWZ(4928));
				goto case 3;
			default:
				num = 3;
				if (SRHY7ZWtc7rMRYtTbYL())
				{
					continue;
				}
				goto case 0;
			case 0:
				AddSnippet(_pasteObject);
				num = 11;
				continue;
			case 9:
				FVbO6wUuZ8 = _pasteObject.GetCellOffset((string)XKWRPZTwl7knZRPSUWZ(2152));
				num = 0;
				if (!A3BUeyWzhOfOi7IH50v())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 7:
				c0OO7yRleA = new Guid[1]
				{
					new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27594))
				};
				break;
			case 4:
				base._002Ector();
				num = 6;
				continue;
			case 8:
				XsnOdcc4Ic = _pasteObject.GetCellOffset((string)XKWRPZTwl7knZRPSUWZ(6522));
				num = 9;
				continue;
			case 2:
			case 10:
				break;
			case 11:
				return;
			}
			h2WOuOwEnb = 100;
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__24))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__25))]
	protected override Task OnBeginAddInternal()
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
		goto IL_0092;
		IL_001a:
		_003COnBeginAddInternal_003Ed__25 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0092;
		IL_0092:
		while (true)
		{
			IL_0092_2:
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				while (true)
				{
					stateMachine._003C_003Et__builder = K2Loi7TeqUZFUbrDdmf();
					SRHY7ZWtc7rMRYtTbYL();
					if (!A3BUeyWzhOfOi7IH50v())
					{
						break;
					}
					num = 3;
					if (false)
					{
						continue;
					}
					goto IL_0092_2;
				}
				num = 5;
				if (SRHY7ZWtc7rMRYtTbYL())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 4;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BNpOF8uWlk;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__28))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__28 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__29))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__29(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task pj0OUtKSaG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UiTXVGTLRJqZDXtKqNN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IJnOiOTKAufAM1JIWUo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.Brightness;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oIAQmIT5LW3MlN8Yw4G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XKWRPZTwl7knZRPSUWZ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SRHY7ZWtc7rMRYtTbYL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A3BUeyWzhOfOi7IH50v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q8r94KTJfnAO067mriC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.efoBse8wtm();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yPQEHMTaWDaQ7TMpjBh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder K2Loi7TeqUZFUbrDdmf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
